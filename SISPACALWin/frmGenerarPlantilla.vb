Imports Microsoft.ApplicationBlocks.ExceptionManagement
Imports SISPACAL.BL.cCREAR_ARCHIVO_LOG
Imports System.Configuration
Imports System.IO
Imports System.Text

Public Class frmGenerarPlantilla
    Private NombrePlantilla As String
    Private log As New cCREAR_ARCHIVO_LOG
    Private archivoLog As String = ConfigurationManager.AppSettings("ARCHIVO_LOG_PLANTILLA")
    Private directorioLog As String = ConfigurationManager.AppSettings("DIRECTORIO_LOG")

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Function IdUltimaCatorcena(ByVal ID_ZAFRA As Integer) As Integer
        Dim lEntidad As CATORCENA_ZAFRA

        lEntidad = (New cCATORCENA_ZAFRA).ObtenerUltimaCatorcenaCerradaZafra(ID_ZAFRA)
        If lEntidad IsNot Nothing Then
            Return lEntidad.ID_CATORCENA
        End If
        Return -1
    End Function

    Private Sub CargarTiposDescuentos()
        Dim listaTiposDescuentos As listaTIPO_DESCUENTO = (New cTIPO_DESCUENTO).ObtenerLista

        lstTiposDescuentos.Items.Clear()
        lstTiposDescuentos.SelectedIndices.Clear()

        For Each lTipoDesc As TIPO_DESCUENTO In listaTiposDescuentos
            Dim lDescuento As TIPO_DESCUENTO
            Dim lGrupoDescto As GRUPO_DESCUENTOS

            lGrupoDescto = (New cGRUPO_DESCUENTOS).ObtenerGRUPO_DESCUENTOS(lTipoDesc.ID_GRUPO_DESC)
            If lGrupoDescto IsNot Nothing AndAlso
                lGrupoDescto.ID_GRUPO_DESC <> 1 AndAlso
                lGrupoDescto.ID_GRUPO_DESC <> 2 AndAlso
                lGrupoDescto.ID_GRUPO_DESC <> 3 Then
                lstTiposDescuentos.Items.Add(lTipoDesc.NOMBRE_TIPO_DESCTO)

                lDescuento = (New cTIPO_DESCUENTO).ObtenerPorNOMBRE_TIPO_DESCTO(lTipoDesc.NOMBRE_TIPO_DESCTO)
                If lDescuento IsNot Nothing Then
                    Dim lTipoPlaDescto As TIPO_PLANILLA_DESCTO
                    lTipoPlaDescto = (New cTIPO_PLANILLA_DESCTO).ObtenerPorTIPO_PLANILLA_TIPO_DESCUENTO(Me.CbxTIPO_PLANILLA1.SelectedValue, lDescuento.ID_TIPO_DESCTO)

                    If lTipoPlaDescto IsNot Nothing Then
                        lstTiposDescuentos.SelectedIndices.Add(lstTiposDescuentos.Items.IndexOf(lTipoDesc.NOMBRE_TIPO_DESCTO))
                    End If
                End If
            End If
        Next
    End Sub

    Private Sub Inicializar()
        Dim lZafraActiva As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        Me.CbxZAFRA1.Recuperar()
        If lZafraActiva IsNot Nothing Then Me.CbxZAFRA1.SelectedValue = lZafraActiva.ID_ZAFRA
        If Me.CbxZAFRA1.SelectedValue IsNot Nothing Then
            Me.CbxCATORCENA_ZAFRA1.RecuperarPorZAFRA(Me.CbxZAFRA1.SelectedValue)
            Me.CbxCATORCENA_ZAFRA1.SelectedValue = IdUltimaCatorcena(Me.CbxZAFRA1.SelectedValue)
        End If
        Me.CbxTIPO_PLANILLA1.Recuperar()
    End Sub

    Private Sub CbxZAFRA1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CbxZAFRA1.SelectedIndexChanged
        Me.CbxCATORCENA_ZAFRA1.RecuperarPorZAFRA(Me.CbxZAFRA1.SelectedValue)
        Me.CbxCATORCENA_ZAFRA1.SelectedValue = IdUltimaCatorcena(Me.CbxZAFRA1.SelectedValue)
    End Sub

    Private Function GenerarPlantillaProductorCana(ByVal nombreArchivo As String) As Boolean
        log.DIRECTORIO_ARCHIVO = directorioLog
        log.crea_archivo(archivoLog, "GenerarPlantillaProductorCana", "Inicio nombreArchivo: " + nombreArchivo, Direccion.Input, "")
        Dim exApp As New Microsoft.Office.Interop.Excel.Application
        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        Dim exHojaDescuento As Microsoft.Office.Interop.Excel.Worksheet
        Dim exHojaDetalle As Microsoft.Office.Interop.Excel.Worksheet
        Dim existeHoja As Boolean = False

        Dim bPlantillaColu As New cPLANTILLA_PRODU_COLU
        Dim listaEncabezado As listaPLANTILLA_PRODU_COLU
        Dim listaProductores As listaPLANTILLA_PRODU_DATOS
        Dim Uid As Guid = Guid.NewGuid
        Dim col As Int32 = 1
        Dim colFinCreditos As Int32
        Dim fila As Int32 = 1
        Dim colDescto As Int32
        Dim lRet As Integer


        Try
            log.crea_archivo(archivoLog, "GenerarPlantillaProductorCana", "Comprobar si existe archivo para borrarlo: " + nombreArchivo, Direccion.Input, "")
            If My.Computer.FileSystem.FileExists(nombreArchivo) Then
                My.Computer.FileSystem.DeleteFile(nombreArchivo)
            End If

            '   Inicializar libro
            log.crea_archivo(archivoLog, "GenerarPlantillaProductorCana", "Inicializar libro", Direccion.Input, "")
            exLibro = exApp.Workbooks.Add
            exLibro.SaveAs(nombreArchivo)
            exLibro = Nothing
            exLibro = exApp.Workbooks.Open(nombreArchivo)
            exApp.DisplayAlerts = False


            log.crea_archivo(archivoLog, "GenerarPlantillaProductorCana", "Invocar bPlantillaColu.PROC_Generar_Data_Plantilla_Descto_Productor2: " &
                             "| ID_ZAFRA:" & Me.CbxZAFRA1.SelectedValue.ToString & "| ID_CATORCENA:" & Me.CbxCATORCENA_ZAFRA1.SelectedValue.ToString &
                             "| ID_TIPO_PLANILLA:" & Me.CbxTIPO_PLANILLA1.SelectedValue.ToString &
                             "| UID_REFERENCIA: " & Uid.ToString &
                             "| USUARIO_CREA: " & Utilerias.ObtenerUsuario &
                             "| FECHA_CALC_INTERES: " & Me.dteFechaCalcInteres.DateTime.ToString("dd/MM/yyyy"), Direccion.Input, "")
            lRet = bPlantillaColu.PROC_Generar_Data_Plantilla_Descto_Productor2(Me.CbxZAFRA1.SelectedValue, Me.CbxCATORCENA_ZAFRA1.SelectedValue, Me.CbxTIPO_PLANILLA1.SelectedValue, Uid, Utilerias.ObtenerUsuario, Me.dteFechaCalcInteres.DateTime)
            lRet = 1
            If lRet <> 1 Then
                Me.Cursor = System.Windows.Forms.Cursors.Default
                MsgBox(bPlantillaColu.sError, vbCritical, Application.ProductName)

                If exLibro IsNot Nothing Then
                    exLibro.Save()
                    exLibro.Close()
                    exApp.DisplayAlerts = True
                    exHojaDescuento = Nothing
                    exLibro = Nothing
                    exApp = Nothing
                End If
                Me.Cursor = System.Windows.Forms.Cursors.Default
                Exit Function
            End If

            ' *******************************************
            '   Generar información para plantilla detalle
            ' *******************************************
            log.crea_archivo(archivoLog, "GenerarPlantillaProductorCana", "Generar información para plantilla detalle", Direccion.Input, "")
            exHojaDetalle = exLibro.Worksheets.Add()
            exHojaDetalle.Name = "DETALLE"

            Dim ds As DataSet = (New cPLANTILLA_PRODU_DATOS).ObtenerDetalleParaPlantilla(Uid)

            If ds IsNot Nothing AndAlso ds.Tables.Count > 0 Then
                Dim dtTable As DataTable = ds.Tables(0)
                Dim NCol As Integer = dtTable.Columns.Count
                Dim NRow As Integer = dtTable.Rows.Count
                'Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
                exHojaDetalle.Range("A:A").NumberFormat = "@"
                exHojaDetalle.Range("D:D").NumberFormat = "@"
                exHojaDetalle.Range("F:F").NumberFormat = "dd/MM/yyyy"
                exHojaDetalle.Range("G:G").NumberFormat = "dd/MM/yyyy"
                exHojaDetalle.Range("H:H").NumberFormat = "#,##0.00"
                exHojaDetalle.Range("J:J", "O:O").NumberFormat = "#,##0.00"
                For i As Integer = 1 To NCol
                    exHojaDetalle.Cells.Item(1, i) = dtTable.Columns(i - 1).ColumnName.ToString
                Next
                For fila = 0 To NRow - 1
                    For col = 0 To NCol - 1
                        If col = 5 OrElse col = 6 Then
                            If Not IsDBNull(dtTable.Rows(fila).Item(col)) Then
                                exHojaDetalle.Cells.Item(fila + 2, col + 1) = CDate(dtTable.Rows(fila).Item(col))
                            Else
                                exHojaDetalle.Cells.Item(fila + 2, col + 1) = ""
                            End If
                        Else
                            exHojaDetalle.Cells.Item(fila + 2, col + 1) = dtTable.Rows(fila).Item(col).ToString()
                        End If
                    Next
                Next
                exHojaDetalle.Range("1:1").HorizontalAlignment = 3
                exHojaDetalle.Range("F:F").HorizontalAlignment = 3
                exHojaDetalle.Range("G:G").HorizontalAlignment = 3
                exHojaDetalle.Range("I:I").HorizontalAlignment = 3
                exHojaDetalle.Range("P:P").HorizontalAlignment = 3
                exHojaDetalle.Range("Q:Q").HorizontalAlignment = 3
                exHojaDetalle.Rows.Font.Name = "Arial Narrow"
                exHojaDetalle.Rows.Font.Size = 9
                exHojaDetalle.Rows.Item(1).Font.Bold = 1
                exHojaDetalle.Columns.AutoFit()
                exHojaDetalle.Rows("2:2").Select()
                exApp.ActiveWindow.FreezePanes = True
            End If


            ' *******************************************
            '   Generar información para plantilla resumen
            ' *******************************************
            log.crea_archivo(archivoLog, "GenerarPlantillaProductorCana", "Generar información para plantilla resumen", Direccion.Input, "")
            exHojaDescuento = exLibro.Worksheets.Add()
            exHojaDescuento.Name = "DESCUENTOS"

            fila = 1
            col = 1
            listaEncabezado = bPlantillaColu.ObtenerListaPorUID(Uid, "ORDEN_HOJA, ORDEN_DESCTO", "ASC")
            If listaEncabezado IsNot Nothing AndAlso listaEncabezado.Count > 0 Then
                exHojaDescuento.Cells(fila, col) = "CODIGO"
                col += 1
                exHojaDescuento.Cells(fila, col) = "PRODUCTOR"
                col += 1
                exHojaDescuento.Cells(fila, col) = "PAGO"
                col += 1
                For Each lEntidad As PLANTILLA_PRODU_COLU In listaEncabezado
                    exHojaDescuento.Cells(fila, col) = lEntidad.CONCEPTO
                    Select Case lEntidad.ORDEN_HOJA
                        Case 1
                            exHojaDescuento.Cells(fila, col).Interior.Color = System.Drawing.ColorTranslator.ToOle(Color.LightSkyBlue)
                        Case 2
                            exHojaDescuento.Cells(fila, col).Interior.Color = System.Drawing.ColorTranslator.ToOle(Color.MediumAquamarine)
                        Case 3
                            exHojaDescuento.Cells(fila, col).Interior.Color = System.Drawing.ColorTranslator.ToOle(Color.Beige)
                    End Select
                    exHojaDescuento.Range(exHojaDescuento.Cells(fila, col), exHojaDescuento.Cells(fila, col + 3)).Merge(True)
                    exHojaDescuento.Cells(fila + 1, col) = "SALDO"
                    exHojaDescuento.Cells(fila + 1, col + 1) = "INTERES"
                    exHojaDescuento.Cells(fila + 1, col + 2) = "DESCUENTO"
                    exHojaDescuento.Cells(fila + 1, col + 3) = "PAGO INTERES"
                    col += 4
                Next
                colFinCreditos = col - 1
                exHojaDescuento.Cells(fila, col) = "TOTAL" & vbCrLf & "DESCUENTOS"
                exHojaDescuento.Cells(fila, col).Font.Color = -16776961
                exHojaDescuento.Cells(fila, col).WrapText = True

                exHojaDescuento.Cells(fila, col + 1) = "PAGO MENOS" & vbCrLf & "DESCUENTOS"
                exHojaDescuento.Cells(fila, col + 1).Font.Color = -65536
                exHojaDescuento.Cells(fila, col + 1).WrapText = True

                exHojaDescuento.Cells(fila, col + 2) = "SALDO PENDIENTE"
                exHojaDescuento.Cells(fila, col + 2).WrapText = True

                exHojaDescuento.Cells(fila, col + 3) = "%" & vbCrLf & "DESCONTADO SOBRE PAGO"
                exHojaDescuento.Cells(fila, col + 3).WrapText = True

                exHojaDescuento.Cells(fila, col + 4) = "%" & vbCrLf & "ENTREGA PENDIENTE CAÑA"
                exHojaDescuento.Cells(fila, col + 4).WrapText = True

                exHojaDescuento.Cells(fila, col + 5) = "VALOR NETO ESTIMADO" & vbCrLf & "ENTREGA PENDIENTE CAÑA"
                exHojaDescuento.Cells(fila, col + 5).WrapText = True

                colDescto = col
            End If

            fila = 3
            col = 1
            exHojaDescuento.Range("A:A").NumberFormat = "@"
            listaProductores = (New cPLANTILLA_PRODU_DATOS).ObtenerListaAgrupadaProductores(Uid, "CODIPROVEE", "ASC")
            If listaProductores IsNot Nothing AndAlso listaProductores.Count > 0 Then
                log.crea_archivo(archivoLog, "GenerarPlantillaProductorCana", "Total de descuentos y pago menos descuento", Direccion.Input, "")
                For Each lProductor As PLANTILLA_PRODU_DATOS In listaProductores
                    exHojaDescuento.Cells(fila, col) = lProductor.CODIPROVEEDOR
                    exHojaDescuento.Cells(fila, col + 1) = lProductor.PRODUCTOR
                    exHojaDescuento.Cells(fila, col + 2) = lProductor.PAGO
                    exHojaDescuento.Rows(fila).Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous

                    'Completar la información a la que aplica
                    Dim sConcepto As String = ""
                    Dim sRangoFormulaSdo As New StringBuilder
                    Dim colLetraSdo As String = ""
                    Dim sRangoFormula As New StringBuilder
                    Dim colLetra As String = ""

                    For colCredi As Int32 = 4 To colFinCreditos Step 4
                        Dim dsTotal As DataSet

                        sConcepto = exHojaDescuento.Cells(1, colCredi).Value2
                        dsTotal = (New cPLANTILLA_PRODU_DATOS).ObtenerTotalesCantidadesParaPlantilla(Uid, lProductor.CODIPROVEEDOR, sConcepto)

                        If dsTotal IsNot Nothing AndAlso dsTotal.Tables.Count > 0 AndAlso dsTotal.Tables(0).Rows.Count > 0 Then
                            exHojaDescuento.Cells(fila, colCredi) = If(IsDBNull(dsTotal.Tables(0).Rows(0)("SALDO_INI")), "", dsTotal.Tables(0).Rows(0)("SALDO_INI"))
                            exHojaDescuento.Cells(fila, colCredi + 1) = If(IsDBNull(dsTotal.Tables(0).Rows(0)("INTERES")), "", dsTotal.Tables(0).Rows(0)("INTERES"))
                            exHojaDescuento.Cells(fila, colCredi + 2) = If(IsDBNull(dsTotal.Tables(0).Rows(0)("ABONO")), "", dsTotal.Tables(0).Rows(0)("ABONO"))
                            exHojaDescuento.Cells(fila, colCredi + 3) = If(IsDBNull(dsTotal.Tables(0).Rows(0)("ABONO_INTERES")), "", dsTotal.Tables(0).Rows(0)("ABONO_INTERES"))

                            colLetraSdo = Split(exHojaDescuento.Cells(fila, colCredi).Address, "$")(1) + fila.ToString
                            sRangoFormulaSdo.Append(colLetraSdo)
                            sRangoFormulaSdo.Append(",")
                            colLetraSdo = Split(exHojaDescuento.Cells(fila, colCredi + 1).Address, "$")(1) + fila.ToString
                            sRangoFormulaSdo.Append(colLetraSdo)
                            sRangoFormulaSdo.Append(",")

                            colLetra = Split(exHojaDescuento.Cells(fila, colCredi + 2).Address, "$")(1) + fila.ToString
                            sRangoFormula.Append(colLetra)
                            sRangoFormula.Append(",")
                            colLetra = Split(exHojaDescuento.Cells(fila, colCredi + 3).Address, "$")(1) + fila.ToString
                            sRangoFormula.Append(colLetra)
                            sRangoFormula.Append(",")
                        End If
                    Next

                    'Total de descuentos y Pago menos descuentos
                    exHojaDescuento.Cells(fila, colDescto) = "=SUM(" + Strings.Left(sRangoFormula.ToString, sRangoFormula.ToString.Length - 1) + ")"
                    exHojaDescuento.Cells(fila, colDescto + 1) = "=C" + fila.ToString + " - " + Split(exHojaDescuento.Cells(fila, colDescto).Address, "$")(1) + fila.ToString
                    exHojaDescuento.Cells(fila, colDescto + 2) = "=SUM(" + Strings.Left(sRangoFormulaSdo.ToString, sRangoFormulaSdo.ToString.Length - 1) + ")" & "-SUM(" + Strings.Left(sRangoFormula.ToString, sRangoFormula.ToString.Length - 1) + ")"
                    exHojaDescuento.Cells(fila, colDescto + 2).NumberFormat = "#,###,##0.00"
                    exHojaDescuento.Cells(fila, colDescto + 3) = "=TRUNC(" + Split(exHojaDescuento.Cells(fila, colDescto).Address, "$")(1) + fila.ToString + "/C" + fila.ToString + ",4)"
                    exHojaDescuento.Cells(fila, colDescto + 3).NumberFormat = "0.00%"
                    exHojaDescuento.Cells(fila, colDescto + 4) = lProductor.PORC_CANA_PEND
                    exHojaDescuento.Cells(fila, colDescto + 4).NumberFormat = "0.00%"
                    exHojaDescuento.Cells(fila, colDescto + 5) = lProductor.MONTO_CANA_PEND
                    exHojaDescuento.Cells(fila, colDescto + 5).NumberFormat = "#,###,##0.00"

                    fila += 1
                Next
            End If

            'Gran Total de la última fila
            log.crea_archivo(archivoLog, "GenerarPlantillaProductorCana", "Gran total última fila", Direccion.Input, "")
            exHojaDescuento.Range(exHojaDescuento.Cells(fila, 1), exHojaDescuento.Cells(fila, 2)).Merge(True)
            exHojaDescuento.Cells(fila, 1) = "TOTALES"
            exHojaDescuento.Cells(fila, 1).HorizontalAlignment = 3
            exHojaDescuento.Cells(fila, 1).VerticalAlignment = 2
            exHojaDescuento.Rows.Item(fila).Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous
            For cx As Int32 = 3 To colFinCreditos + 3 'Se suma 2 para que totalize descuentos y liquido a pagar
                exHojaDescuento.Cells(fila, cx) = "=SUM(" + Split(exHojaDescuento.Cells(fila, cx).Address, "$")(1) + "3" +
                                                    ":" +
                                                    Split(exHojaDescuento.Cells(fila, cx).Address, "$")(1) + (fila - 1).ToString + ")"
            Next

            For cx As Int32 = colFinCreditos + 6 To colFinCreditos + 6 'Se suma 2 para que totalize descuentos y liquido a pagar
                exHojaDescuento.Cells(fila, cx) = "=SUM(" + Split(exHojaDescuento.Cells(fila, cx).Address, "$")(1) + "3" +
                                                    ":" +
                                                    Split(exHojaDescuento.Cells(fila, cx).Address, "$")(1) + (fila - 1).ToString + ")"
            Next


            'Titulo en negrita, Alineado al centro y que el tamaño de la columna se ajuste al texto
            log.crea_archivo(archivoLog, "GenerarPlantillaProductorCana", "Titulo en negrita, Alineado al centro y que el tamaño de la columna se ajuste al texto", Direccion.Input, "")
            exHojaDescuento.Rows.Font.Name = "Arial Narrow"
            exHojaDescuento.Rows.Font.Size = 9
            exHojaDescuento.Rows.Item(1).Font.Bold = 1
            exHojaDescuento.Rows.Item(2).Font.Bold = 1
            exHojaDescuento.Rows.Item(1).Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous
            exHojaDescuento.Rows.Item(2).Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous
            exHojaDescuento.Rows.Item(1).HorizontalAlignment = 3
            exHojaDescuento.Rows.Item(1).VerticalAlignment = 2
            exHojaDescuento.Rows.Item(2).HorizontalAlignment = 3
            exHojaDescuento.Rows.Item(2).VerticalAlignment = 2

            exHojaDescuento.Range("C3:" + Split(exHojaDescuento.Cells(fila, colFinCreditos + 2).Address, "$")(1) + fila.ToString).NumberFormat = "#,##0.00"
            exHojaDescuento.Range("C3:" + Split(exHojaDescuento.Cells(fila, colFinCreditos + 2).Address, "$")(1) + fila.ToString).Font.Size = 10
            exHojaDescuento.Rows.Item(fila).Font.Bold = 1
            exHojaDescuento.Rows.Item(fila).Font.Size = 10
            exHojaDescuento.Columns.AutoFit()
            exHojaDescuento.Range("D3").Select()
            exApp.ActiveWindow.FreezePanes = True


            'Aplicación visible
            'exApp.Application.Visible = True
            log.crea_archivo(archivoLog, "GenerarPlantillaProductorCana", "Guardando y cerrando libro", Direccion.Output, "")
            exLibro.Save()
            exLibro.Close()
            exApp.DisplayAlerts = True
            exHojaDescuento = Nothing
            exLibro = Nothing
            exApp = Nothing
            Me.Cursor = System.Windows.Forms.Cursors.Default
            log.crea_archivo(archivoLog, "GenerarPlantillaProductorCana", "Fin nombreArchivo: " + nombreArchivo, Direccion.Output, "")
            Return True

        Catch ex As Exception
            log.crea_archivo(archivoLog, "GenerarPlantillaProductorCana", "Error al generar plantilla " & ex.Message, Direccion.Output, "Catch Exception")
            MsgBox(ex.Message, vbCritical, Application.ProductName)
            exApp.DisplayAlerts = True
            If exLibro IsNot Nothing Then
                exLibro.Save()
                exLibro.Close()
                exApp.DisplayAlerts = True
                exHojaDescuento = Nothing
                exLibro = Nothing
                exApp = Nothing
            End If
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Return False
        End Try

    End Function

    Private Function GenerarPlantillaTransportistas(ByVal nombreArchivo As String) As Boolean
        Dim exApp As New Microsoft.Office.Interop.Excel.Application
        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        Dim exHojaDescuento As Microsoft.Office.Interop.Excel.Worksheet
        Dim exHojaDetalle As Microsoft.Office.Interop.Excel.Worksheet
        Dim existeHoja As Boolean = False

        Dim bPlantillaColu As New cPLANTILLA_TRANS_COLU
        Dim listaEncabezado As listaPLANTILLA_TRANS_COLU
        Dim listaProductores As listaPLANTILLA_TRANS_DATOS
        Dim Uid As Guid = Guid.NewGuid
        Dim col As Int32 = 1
        Dim colFinCreditos As Int32
        Dim fila As Int32 = 1
        Dim colDescto As Int32

        Try
            If My.Computer.FileSystem.FileExists(nombreArchivo) Then
                My.Computer.FileSystem.DeleteFile(nombreArchivo)
            End If

            '   Inicializar libro
            exLibro = exApp.Workbooks.Add
            exLibro.SaveAs(nombreArchivo)
            exLibro = Nothing
            exLibro = exApp.Workbooks.Open(nombreArchivo)
            exApp.DisplayAlerts = False


            bPlantillaColu.PROC_Generar_Data_Plantilla_Descto_Transportista(Me.CbxZAFRA1.SelectedValue, Me.CbxCATORCENA_ZAFRA1.SelectedValue, Me.CbxTIPO_PLANILLA1.SelectedValue, Uid, Utilerias.ObtenerUsuario, Today)

            ' *******************************************
            '   Generar información para plantilla detalle
            ' *******************************************
            exHojaDetalle = exLibro.Worksheets.Add()
            exHojaDetalle.Name = "DETALLE"

            Dim ds As DataSet = (New cPLANTILLA_TRANS_DATOS).ObtenerDetalleParaPlantilla(Uid)

            If ds IsNot Nothing AndAlso ds.Tables.Count > 0 Then
                Dim dtTable As DataTable = ds.Tables(0)
                Dim NCol As Integer = dtTable.Columns.Count
                Dim NRow As Integer = dtTable.Rows.Count
                'Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
                exHojaDetalle.Range("A:A").NumberFormat = "@"
                exHojaDetalle.Range("D:D").NumberFormat = "@"
                exHojaDetalle.Range("F:F").NumberFormat = "dd/MM/yyyy"
                exHojaDetalle.Range("G:G").NumberFormat = "dd/MM/yyyy"
                exHojaDetalle.Range("H:H").NumberFormat = "#,##0.00"
                exHojaDetalle.Range("J:J", "O:O").NumberFormat = "#,##0.00"
                For i As Integer = 1 To NCol
                    exHojaDetalle.Cells.Item(1, i) = dtTable.Columns(i - 1).ColumnName.ToString
                Next
                For fila = 0 To NRow - 1
                    For col = 0 To NCol - 1
                        If col = 5 OrElse col = 6 Then
                            If Not IsDBNull(dtTable.Rows(fila).Item(col)) Then
                                exHojaDetalle.Cells.Item(fila + 2, col + 1) = CDate(dtTable.Rows(fila).Item(col))
                            Else
                                exHojaDetalle.Cells.Item(fila + 2, col + 1) = ""
                            End If
                        Else
                            exHojaDetalle.Cells.Item(fila + 2, col + 1) = dtTable.Rows(fila).Item(col).ToString()
                        End If
                    Next
                Next
                exHojaDetalle.Range("1:1").HorizontalAlignment = 3
                exHojaDetalle.Range("F:F").HorizontalAlignment = 3
                exHojaDetalle.Range("G:G").HorizontalAlignment = 3
                exHojaDetalle.Range("I:I").HorizontalAlignment = 3
                exHojaDetalle.Range("P:P").HorizontalAlignment = 3
                exHojaDetalle.Range("Q:Q").HorizontalAlignment = 3
                exHojaDetalle.Range("R:R").HorizontalAlignment = 3
                exHojaDetalle.Rows.Font.Name = "Arial Narrow"
                exHojaDetalle.Rows.Font.Size = 9
                exHojaDetalle.Rows.Item(1).Font.Bold = 1
                exHojaDetalle.Columns.AutoFit()
                exHojaDetalle.Rows("2:2").Select()
                exApp.ActiveWindow.FreezePanes = True
            End If


            ' *******************************************
            '   Generar información para plantilla resumen
            ' *******************************************
            exHojaDescuento = exLibro.Worksheets.Add()
            exHojaDescuento.Name = "DESCUENTOS"

            fila = 1
            col = 1
            listaEncabezado = bPlantillaColu.ObtenerListaPorUID(Uid, "ORDEN_HOJA, ORDEN_DESCTO", "ASC")
            If listaEncabezado IsNot Nothing AndAlso listaEncabezado.Count > 0 Then
                exHojaDescuento.Cells(fila, col) = "CODIGO"
                col += 1
                exHojaDescuento.Cells(fila, col) = "TRANSPORTISTA"
                col += 1
                exHojaDescuento.Cells(fila, col) = "PAGO"
                col += 1
                For Each lEntidad As PLANTILLA_TRANS_COLU In listaEncabezado
                    exHojaDescuento.Cells(fila, col) = lEntidad.CONCEPTO
                    Select Case lEntidad.ORDEN_HOJA
                        Case 1
                            exHojaDescuento.Cells(fila, col).Interior.Color = System.Drawing.ColorTranslator.ToOle(Color.LightSkyBlue)
                        Case 2
                            exHojaDescuento.Cells(fila, col).Interior.Color = System.Drawing.ColorTranslator.ToOle(Color.MediumAquamarine)
                        Case 3
                            exHojaDescuento.Cells(fila, col).Interior.Color = System.Drawing.ColorTranslator.ToOle(Color.Beige)
                    End Select
                    exHojaDescuento.Range(exHojaDescuento.Cells(fila, col), exHojaDescuento.Cells(fila, col + 3)).Merge(True)
                    exHojaDescuento.Cells(fila + 1, col) = "SALDO"
                    exHojaDescuento.Cells(fila + 1, col + 1) = "INTERES"
                    exHojaDescuento.Cells(fila + 1, col + 2) = "DESCUENTO"
                    exHojaDescuento.Cells(fila + 1, col + 3) = "PAGO INTERES"
                    col += 4
                Next
                colFinCreditos = col - 1
                exHojaDescuento.Cells(fila, col) = "TOTAL" & vbCrLf & "DESCUENTOS"
                exHojaDescuento.Cells(fila, col).Font.Color = -16776961
                exHojaDescuento.Cells(fila, col).WrapText = True

                exHojaDescuento.Cells(fila, col + 1) = "PAGO MENOS" & vbCrLf & "DESCUENTOS"
                exHojaDescuento.Cells(fila, col + 1).Font.Color = -65536
                exHojaDescuento.Cells(fila, col + 1).WrapText = True

                exHojaDescuento.Cells(fila, col + 2) = "SALDO PENDIENTE"
                exHojaDescuento.Cells(fila, col + 2).WrapText = True

                exHojaDescuento.Cells(fila, col + 3) = "%" & vbCrLf & "DESCONTADO SOBRE PAGO"
                exHojaDescuento.Cells(fila, col + 3).WrapText = True

                'exHojaDescuento.Cells(fila, col + 4) = "%" & vbCrLf & "ENTREGA PENDIENTE CAÑA"
                'exHojaDescuento.Cells(fila, col + 4).WrapText = True

                'exHojaDescuento.Cells(fila, col + 5) = "VALOR NETO ESTIMADO" & vbCrLf & "ENTREGA PENDIENTE CAÑA"
                'exHojaDescuento.Cells(fila, col + 5).WrapText = True

                colDescto = col
            End If

            fila = 3
            col = 1
            exHojaDescuento.Range("A:A").NumberFormat = "@"
            listaProductores = (New cPLANTILLA_TRANS_DATOS).ObtenerListaAgrupadaProductores(Uid, "CODTRANSPORT", "ASC")
            If listaProductores IsNot Nothing AndAlso listaProductores.Count > 0 Then
                For Each lProductor As PLANTILLA_TRANS_DATOS In listaProductores
                    exHojaDescuento.Cells(fila, col) = lProductor.CODTRANSPORT
                    exHojaDescuento.Cells(fila, col + 1) = lProductor.TRANSPORTISTA
                    exHojaDescuento.Cells(fila, col + 2) = lProductor.PAGO
                    exHojaDescuento.Rows(fila).Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous

                    'Completar la información a la que aplica
                    Dim sConcepto As String = ""
                    Dim sRangoFormulaSdo As New StringBuilder
                    Dim colLetraSdo As String = ""
                    Dim sRangoFormula As New StringBuilder
                    Dim colLetra As String = ""

                    For colCredi As Int32 = 4 To colFinCreditos Step 4
                        Dim dsTotal As DataSet

                        sConcepto = exHojaDescuento.Cells(1, colCredi).Value2
                        dsTotal = (New cPLANTILLA_TRANS_DATOS).ObtenerTotalesCantidadesParaPlantilla(Uid, lProductor.CODTRANSPORT, sConcepto)

                        If dsTotal IsNot Nothing AndAlso dsTotal.Tables.Count > 0 AndAlso dsTotal.Tables(0).Rows.Count > 0 Then
                            exHojaDescuento.Cells(fila, colCredi) = If(IsDBNull(dsTotal.Tables(0).Rows(0)("SALDO_INI")), "", dsTotal.Tables(0).Rows(0)("SALDO_INI"))
                            exHojaDescuento.Cells(fila, colCredi + 1) = If(IsDBNull(dsTotal.Tables(0).Rows(0)("INTERES")), "", dsTotal.Tables(0).Rows(0)("INTERES"))
                            exHojaDescuento.Cells(fila, colCredi + 2) = If(IsDBNull(dsTotal.Tables(0).Rows(0)("ABONO")), "", dsTotal.Tables(0).Rows(0)("ABONO"))
                            exHojaDescuento.Cells(fila, colCredi + 3) = If(IsDBNull(dsTotal.Tables(0).Rows(0)("ABONO_INTERES")), "", dsTotal.Tables(0).Rows(0)("ABONO_INTERES"))

                            colLetraSdo = Split(exHojaDescuento.Cells(fila, colCredi).Address, "$")(1) + fila.ToString
                            sRangoFormulaSdo.Append(colLetraSdo)
                            sRangoFormulaSdo.Append(",")
                            colLetraSdo = Split(exHojaDescuento.Cells(fila, colCredi + 1).Address, "$")(1) + fila.ToString
                            sRangoFormulaSdo.Append(colLetraSdo)
                            sRangoFormulaSdo.Append(",")

                            colLetra = Split(exHojaDescuento.Cells(fila, colCredi + 2).Address, "$")(1) + fila.ToString
                            sRangoFormula.Append(colLetra)
                            sRangoFormula.Append(",")
                            colLetra = Split(exHojaDescuento.Cells(fila, colCredi + 3).Address, "$")(1) + fila.ToString
                            sRangoFormula.Append(colLetra)
                            sRangoFormula.Append(",")
                        End If
                    Next

                    'Total de descuentos y Pago menos descuentos
                    exHojaDescuento.Cells(fila, colDescto) = "=SUM(" + Strings.Left(sRangoFormula.ToString, sRangoFormula.ToString.Length - 1) + ")"
                    exHojaDescuento.Cells(fila, colDescto + 1) = "=C" + fila.ToString + " - " + Split(exHojaDescuento.Cells(fila, colDescto).Address, "$")(1) + fila.ToString
                    exHojaDescuento.Cells(fila, colDescto + 2) = "=SUM(" + Strings.Left(sRangoFormulaSdo.ToString, sRangoFormulaSdo.ToString.Length - 1) + ")" & "-SUM(" + Strings.Left(sRangoFormula.ToString, sRangoFormula.ToString.Length - 1) + ")"
                    exHojaDescuento.Cells(fila, colDescto + 2).NumberFormat = "#,###,##0.00"
                    exHojaDescuento.Cells(fila, colDescto + 3) = "=TRUNC(" + Split(exHojaDescuento.Cells(fila, colDescto).Address, "$")(1) + fila.ToString + "/C" + fila.ToString + ",4)"
                    exHojaDescuento.Cells(fila, colDescto + 3).NumberFormat = "0.00%"
                    'exHojaDescuento.Cells(fila, colDescto + 4) = lProductor.PORC_CANA_PEND
                    'exHojaDescuento.Cells(fila, colDescto + 4).NumberFormat = "0.00%"
                    'exHojaDescuento.Cells(fila, colDescto + 5) = lProductor.MONTO_CANA_PEND
                    'exHojaDescuento.Cells(fila, colDescto + 5).NumberFormat = "#,###,##0.00"

                    fila += 1
                Next
            End If

            'Gran Total de la última fila
            exHojaDescuento.Range(exHojaDescuento.Cells(fila, 1), exHojaDescuento.Cells(fila, 2)).Merge(True)
            exHojaDescuento.Cells(fila, 1) = "TOTALES"
            exHojaDescuento.Cells(fila, 1).HorizontalAlignment = 3
            exHojaDescuento.Cells(fila, 1).VerticalAlignment = 2
            exHojaDescuento.Rows.Item(fila).Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous
            For cx As Int32 = 3 To colFinCreditos + 3 'Se suma 2 para que totalize descuentos y liquido a pagar
                exHojaDescuento.Cells(fila, cx) = "=SUM(" + Split(exHojaDescuento.Cells(fila, cx).Address, "$")(1) + "3" +
                                                    ":" +
                                                    Split(exHojaDescuento.Cells(fila, cx).Address, "$")(1) + (fila - 1).ToString + ")"
            Next

            For cx As Int32 = colFinCreditos + 6 To colFinCreditos + 6 'Se suma 2 para que totalize descuentos y liquido a pagar
                exHojaDescuento.Cells(fila, cx) = "=SUM(" + Split(exHojaDescuento.Cells(fila, cx).Address, "$")(1) + "3" +
                                                    ":" +
                                                    Split(exHojaDescuento.Cells(fila, cx).Address, "$")(1) + (fila - 1).ToString + ")"
            Next


            'Titulo en negrita, Alineado al centro y que el tamaño de la columna se ajuste al texto
            exHojaDescuento.Rows.Font.Name = "Arial Narrow"
            exHojaDescuento.Rows.Font.Size = 9
            exHojaDescuento.Rows.Item(1).Font.Bold = 1
            exHojaDescuento.Rows.Item(2).Font.Bold = 1
            exHojaDescuento.Rows.Item(1).Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous
            exHojaDescuento.Rows.Item(2).Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous
            exHojaDescuento.Rows.Item(1).HorizontalAlignment = 3
            exHojaDescuento.Rows.Item(1).VerticalAlignment = 2
            exHojaDescuento.Rows.Item(2).HorizontalAlignment = 3
            exHojaDescuento.Rows.Item(2).VerticalAlignment = 2

            exHojaDescuento.Range("C3:" + Split(exHojaDescuento.Cells(fila, colFinCreditos + 2).Address, "$")(1) + fila.ToString).NumberFormat = "#,##0.00"
            exHojaDescuento.Range("C3:" + Split(exHojaDescuento.Cells(fila, colFinCreditos + 2).Address, "$")(1) + fila.ToString).Font.Size = 10
            exHojaDescuento.Rows.Item(fila).Font.Bold = 1
            exHojaDescuento.Rows.Item(fila).Font.Size = 10
            exHojaDescuento.Columns.AutoFit()
            exHojaDescuento.Range("D3").Select()
            exApp.ActiveWindow.FreezePanes = True


            'Aplicación visible
            'exApp.Application.Visible = True
            exLibro.Save()
            exLibro.Close()
            exApp.DisplayAlerts = True
            exHojaDescuento = Nothing
            exLibro = Nothing
            exApp = Nothing
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Return True

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            MsgBox(ex.Message, vbCritical, Application.ProductName)
            exApp.DisplayAlerts = True
            If exLibro IsNot Nothing Then
                exLibro.Save()
                exLibro.Close()
                exApp.DisplayAlerts = True
                exHojaDescuento = Nothing
                exLibro = Nothing
                exApp = Nothing
            End If
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Return False
        End Try

    End Function

    Private Sub btnGenerarPlantilla_Click(sender As System.Object, e As System.EventArgs) Handles btnGenerarPlantilla.Click
        Dim tabla As New DataTable
        Dim lRet As Boolean

        If txtDirectorio.Text.Trim = "" Then
            MsgBox("Seleccione un directorio", vbCritical, Application.ProductName)
            Return
        End If

        'Actualizar descuentos por planilla
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        Dim lstPlanillaBase As listaPLANILLA_BASE = (New cPLANILLA_BASE).ObtenerListaPorZAFRA_CATORCENA_TIPO_PLANILLA(Me.CbxZAFRA1.SelectedValue, Me.CbxCATORCENA_ZAFRA1.SelectedValue, Me.CbxTIPO_PLANILLA1.SelectedValue)
        If Not (lstPlanillaBase IsNot Nothing AndAlso lstPlanillaBase.Count > 0 AndAlso lstPlanillaBase(0).FECHA_PAGO <> #12:00:00 AM#) Then
            MsgBox("Registre la fecha de pago para la planilla", vbInformation, Application.ProductName)
            Return
        End If

        Select Case Me.CbxTIPO_PLANILLA1.SelectedValue
            Case Enumeradores.TipoPlanilla.Cañeros, Enumeradores.TipoPlanilla.AnticipoCaneros, Enumeradores.TipoPlanilla.ComplementoValorFinalPago, Enumeradores.TipoPlanilla.CompensacionEntregaCana
                lRet = Me.GenerarPlantillaProductorCana(Me.txtDirectorio.Text)
                If Not lRet Then
                    Exit Sub
                End If
            Case Enumeradores.TipoPlanilla.Transportistas, Enumeradores.TipoPlanilla.ComplementoTransportistas
                lRet = Me.GenerarPlantillaTransportistas(Me.txtDirectorio.Text)
                If Not lRet Then
                    Exit Sub
                End If
        End Select

        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtDirectorio.Text = ""
        MsgBox("La plantilla se generó con éxito", vbInformation, Application.ProductName)
    End Sub

    Private Sub btnSeleccionarDirectorio_Click(sender As System.Object, e As System.EventArgs) Handles btnSeleccionarDirectorio.Click
        FolderBrowserDialog1.ShowDialog()
        If FolderBrowserDialog1.SelectedPath <> "" Then
            Select Case CbxTIPO_PLANILLA1.SelectedValue
                Case Enumeradores.TipoPlanilla.Cañeros
                    Me.NombrePlantilla = "PlantillaCañeros"
                Case Enumeradores.TipoPlanilla.Transportistas
                    Me.NombrePlantilla = "PlantillaTransportistas"
                Case Enumeradores.TipoPlanilla.ComplementoTransportistas
                    Me.NombrePlantilla = "PlantillaComplementoPagoTransportistas"
                Case Enumeradores.TipoPlanilla.Cargadoras
                    Me.NombrePlantilla = "PlantillaCargadoras"
                Case Enumeradores.TipoPlanilla.AnticipoCaneros
                    Me.NombrePlantilla = "PlantillaAnticipoCañeros"
                Case Enumeradores.TipoPlanilla.ComplementoValorFinalPago
                    Me.NombrePlantilla = "PlantillaComplementoValorFinal"
                Case Enumeradores.TipoPlanilla.CompensacionEntregaCana
                    Me.NombrePlantilla = "PlantillaCompensacion"
            End Select
            txtDirectorio.Text = FolderBrowserDialog1.SelectedPath & "\" & Me.NombrePlantilla & " - Catorcena " & Me.CbxCATORCENA_ZAFRA1.Text & " Zafra " + Me.CbxZAFRA1.Text.Replace("/", "-") + ".xlsx"
        End If
    End Sub

    Private Function CrearDataTable(ByVal nombre As String) As DataTable
        Dim tabla As DataTable = New DataTable(nombre)

        tabla.Columns.Add("CODIGO", System.Type.GetType("System.String"))
        tabla.Columns.Add("NOMBRE", System.Type.GetType("System.String"))
        tabla.Columns.Add("PAGO", System.Type.GetType("System.Decimal"))
        For i As Integer = 0 To lstTiposDescuentos.SelectedItems.Count - 1
            tabla.Columns.Add(lstTiposDescuentos.SelectedItems(i))
        Next
        tabla.Columns.Add("TOTAL DESCUENTOS", System.Type.GetType("System.Decimal"))
        tabla.Columns.Add("NETO A PAGAR", System.Type.GetType("System.Decimal"))

        Return tabla
    End Function

    Function ExportarExcel(ByVal DT As DataTable, ByVal nombreArchivo As String, ByVal nombreHoja As String) As Boolean
        'Creamos las variables
        Dim exApp As New Microsoft.Office.Interop.Excel.Application
        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet
        Dim existeHoja As Boolean = False
        Try
            'Añadimos el Libro al programa, y la hoja al libro
            exApp.DisplayAlerts = False
            If My.Computer.FileSystem.FileExists(nombreArchivo) Then
                My.Computer.FileSystem.DeleteFile(nombreArchivo)
            End If
            exLibro = exApp.Workbooks.Add
            exLibro.SaveAs(nombreArchivo)
            exLibro = Nothing
            exLibro = exApp.Workbooks.Open(nombreArchivo)
            exHoja = exLibro.Worksheets.Add()
            exHoja.Name = nombreHoja

            ' ¿Cuantas columnas y cuantas filas?
            Dim NCol As Integer = DT.Columns.Count
            Dim NRow As Integer = DT.Rows.Count
            'Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
            For i As Integer = 1 To NCol
                exHoja.Cells.Item(1, i) = DT.Columns(i - 1).ColumnName.ToString
                'exHoja.Cells.AutoFormat(vFormato)
            Next
            For Fila As Integer = 0 To NRow - 1
                For Col As Integer = 0 To NCol - 1
                    If Col = 0 Then
                        exHoja.Cells.Item(Fila + 2, Col + 1).NumberFormat = "@"
                    End If
                    exHoja.Cells.Item(Fila + 2, Col + 1) = DT.Rows(Fila).Item(Col).ToString()
                    If Col = NCol - 2 Then
                        exHoja.Cells.Item(Fila + 2, Col + 1).Formula = "=SUM(D" & CStr(Fila + 2) & ":" & CStr(Chr(65 + Col - 1)) & CStr(Fila + 2) & ")"
                    End If
                    If Col = NCol - 1 Then
                        exHoja.Cells.Item(Fila + 2, Col + 1).Formula = "=C" & CStr(Fila + 2) & "-" & CStr(Chr(65 + Col - 1)) & CStr(Fila + 2)
                    End If
                Next
            Next
            'Titulo en negrita, Alineado al centro y que el tamaño de la columna se ajuste al texto
            exHoja.Rows.Item(1).Font.Bold = 1
            exHoja.Rows.Item(1).HorizontalAlignment = 3
            exHoja.Columns.AutoFit()

            'Aplicación visible
            'exApp.Application.Visible = True
            exLibro.Save()
            exLibro.Close()
            exApp.DisplayAlerts = True
            exHoja = Nothing
            exLibro = Nothing
            exApp = Nothing
            Return True

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            MsgBox(ex.Message, vbCritical, Application.ProductName)
            exApp.DisplayAlerts = True
            If exLibro IsNot Nothing Then
                exLibro.Save()
                exLibro.Close()
                exApp.DisplayAlerts = True
                exHoja = Nothing
                exLibro = Nothing
                exApp = Nothing
            End If
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Return False
        End Try
        Return True
    End Function

    Private Sub frmGenerarPlantilla_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmPrincipalRibbon.Habilitar(True)
    End Sub

    Private Sub frmGenerarPlantilla_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Me.Inicializar()
    End Sub

    Private Sub CbxTIPO_PLANILLA1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CbxTIPO_PLANILLA1.SelectedIndexChanged
        Me.txtDirectorio.Text = ""
        Me.CargarTiposDescuentos()
    End Sub

    Private Sub CbxCATORCENA_ZAFRA1_SelectedValueChanged(sender As Object, e As EventArgs) Handles CbxCATORCENA_ZAFRA1.SelectedValueChanged, CbxZAFRA1.SelectedValueChanged, CbxTIPO_PLANILLA1.SelectedValueChanged
        If Me.CbxZAFRA1.SelectedValue IsNot Nothing AndAlso Me.CbxCATORCENA_ZAFRA1.SelectedValue IsNot Nothing AndAlso Me.CbxTIPO_PLANILLA1.SelectedValue IsNot Nothing Then
            Dim lstPlanillaBase As listaPLANILLA_BASE = (New cPLANILLA_BASE).ObtenerListaPorZAFRA_CATORCENA_TIPO_PLANILLA(Me.CbxZAFRA1.SelectedValue, Me.CbxCATORCENA_ZAFRA1.SelectedValue, Me.CbxTIPO_PLANILLA1.SelectedValue)
            If lstPlanillaBase IsNot Nothing AndAlso lstPlanillaBase.Count > 0 AndAlso lstPlanillaBase(0).FECHA_PAGO <> #12:00:00 AM# Then
                dteFechaCalcInteres.DateTime = lstPlanillaBase(0).FECHA_PAGO
            Else
                dteFechaCalcInteres.Text = ""
            End If
        Else
            dteFechaCalcInteres.Text = ""
        End If
    End Sub
End Class