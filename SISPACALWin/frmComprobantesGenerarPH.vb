Imports Microsoft.ApplicationBlocks.ExceptionManagement
Imports System.IO
Imports SISPACAL.DL

Public Class frmComprobantesGenerarPH

    Private Function IdUltimaCatorcena(ByVal ID_ZAFRA As Integer) As Integer
        Dim lEntidad As CATORCENA_ZAFRA

        lEntidad = (New cCATORCENA_ZAFRA).ObtenerUltimaCatorcenaCerradaZafra(ID_ZAFRA)
        If lEntidad IsNot Nothing Then
            Return lEntidad.ID_CATORCENA
        End If
        Return -1
    End Function

    Private Sub Inicializar()
        Dim lZafraActiva As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        Me.CbxZAFRA1.Recuperar()
        If lZafraActiva IsNot Nothing Then Me.CbxZAFRA1.SelectedValue = lZafraActiva.ID_ZAFRA
        If Me.CbxZAFRA1.SelectedValue IsNot Nothing Then
            Me.CbxCATORCENA_ZAFRA1.RecuperarPorZAFRA(Me.CbxZAFRA1.SelectedValue)
            Me.CbxCATORCENA_ZAFRA1.SelectedValue = IdUltimaCatorcena(Me.CbxZAFRA1.SelectedValue)
        End If
        Me.rbtPlanillaCana.Checked = True
        Me.lblRangoCompensacion.Visible = False
        Me.cbxRANGO_COMPENSACION1.Visible = False
    End Sub

    Private Sub frmArchivosPH_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmPrincipalRibbon.Habilitar(True)
    End Sub

    Private Sub frmArchivosPH_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Me.Inicializar()
    End Sub

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub CbxZAFRA1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CbxZAFRA1.SelectedIndexChanged
        Me.CbxCATORCENA_ZAFRA1.RecuperarPorZAFRA(Me.CbxZAFRA1.SelectedValue)
        Me.CbxCATORCENA_ZAFRA1.SelectedValue = IdUltimaCatorcena(Me.CbxZAFRA1.SelectedValue)
    End Sub

    Private Sub btnGenerarArchivos_Click(sender As System.Object, e As System.EventArgs) Handles btnGenerarArchivos.Click
        If txtDirectorio.Text.Trim = "" Then
            MsgBox("Seleccione un directorio", vbCritical, Application.ProductName)
            txtDirectorio.Focus()
            Return
        End If
        If Not My.Computer.FileSystem.DirectoryExists(txtDirectorio.Text.Trim) Then
            MsgBox("El directorio no existe", vbCritical, Application.ProductName)
            txtDirectorio.Focus()
            Return
        End If

        Dim lCatorcena As CATORCENA_ZAFRA = (New cCATORCENA_ZAFRA).ObtenerCATORCENA_ZAFRA(Me.CbxCATORCENA_ZAFRA1.SelectedValue)
        Dim lRet As Integer
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        Try


            'Crear archivos para PH            
            Dim strDirectorio As String = Me.txtDirectorio.Text.Trim
            Dim bRet As Boolean = False
            Dim daEnca As New DS_COMPROBANTESTableAdapters.ARCHIVOS_PH_CCF_FATableAdapter
            Dim dtEnca As New DS_COMPROBANTES.ARCHIVOS_PH_CCF_FADataTable
            Dim daDeta As New DS_COMPROBANTESTableAdapters.ARCHIVOS_PH_CCF_FA_DETATableAdapter
            Dim dtDeta As New DS_COMPROBANTES.ARCHIVOS_PH_CCF_FA_DETADataTable
            Dim nombreEnca As String = ""
            Dim nombreDeta As String = ""

            Select Case True
                Case rbtPlanillaCana.Checked
                    nombreEnca = "FACTURA Corte " & lCatorcena.CATORCENA.ToString & " Planilla Caña.xlsx"
                    daEnca.FillPlanillaNormal(dtEnca, Me.CbxCATORCENA_ZAFRA1.SelectedValue)
                Case rbtAnticipo.Checked
                    nombreEnca = "FACTURA Corte " & lCatorcena.CATORCENA.ToString & " Planilla Anticipo.xlsx"
                    daEnca.FillPorCriterios(dtEnca, Me.CbxCATORCENA_ZAFRA1.SelectedValue, Enumeradores.TipoPlanilla.AnticipoCaneros)
                Case rbtComplemento.Checked
                    nombreEnca = "FACTURA Corte " & lCatorcena.CATORCENA.ToString & " Planilla Complemento Valor.xlsx"
                    daEnca.FillPorCriterios(dtEnca, Me.CbxCATORCENA_ZAFRA1.SelectedValue, Enumeradores.TipoPlanilla.ComplementoValorFinalPago)
                Case rbtCompensacion.Checked
                    nombreEnca = "FACTURA Corte " & lCatorcena.CATORCENA.ToString & " Planilla Compensacion Entrega Caña - " & Me.cbxRANGO_COMPENSACION1.Text.Replace("/", "-") & ".xlsx"
                    daEnca.FillPorCriterios(dtEnca, Me.CbxCATORCENA_ZAFRA1.SelectedValue, Enumeradores.TipoPlanilla.CompensacionEntregaCana)
                Case rbtIncentivo.Checked
                    nombreEnca = "FACTURA Corte " & lCatorcena.CATORCENA.ToString & " Planilla Incentivo a Productores.xlsx"
                    daEnca.FillPorCriterios(dtEnca, Me.CbxCATORCENA_ZAFRA1.SelectedValue, Enumeradores.TipoPlanilla.IncentivoProductores)
            End Select

            If Microsoft.VisualBasic.Right(strDirectorio, 1) <> "\" Then
                strDirectorio = strDirectorio & "\"
            End If

            If dtEnca.Rows.Count > 0 Then
                bRet = Me.ExportarExcel(dtEnca, strDirectorio & nombreEnca, "factura", True)
                If bRet Then
                    Select Case True
                        Case rbtPlanillaCana.Checked
                            nombreDeta = "DETAFAC Corte " & lCatorcena.CATORCENA.ToString & " Planilla Caña.xlsx"
                            daDeta.FillPlanillaNormal(dtDeta, Me.CbxCATORCENA_ZAFRA1.SelectedValue)
                        Case rbtAnticipo.Checked
                            nombreDeta = "DETAFAC Corte " & lCatorcena.CATORCENA.ToString & " Planilla Anticipo.xlsx"
                            daDeta.FillPorCriterios(dtDeta, Me.CbxCATORCENA_ZAFRA1.SelectedValue, Enumeradores.TipoPlanilla.AnticipoCaneros)
                        Case rbtComplemento.Checked
                            nombreDeta = "DETAFAC Corte " & lCatorcena.CATORCENA.ToString & " Planilla Complemento Valor.xlsx"
                            daDeta.FillPorCriterios(dtDeta, Me.CbxCATORCENA_ZAFRA1.SelectedValue, Enumeradores.TipoPlanilla.ComplementoValorFinalPago)
                        Case rbtCompensacion.Checked
                            nombreDeta = "DETAFAC Corte " & lCatorcena.CATORCENA.ToString & " Planilla Compensacion Entrega Caña - " & Me.cbxRANGO_COMPENSACION1.Text.Replace("/", "-") & ".xlsx"
                            daDeta.FillPorCriterios(dtDeta, Me.CbxCATORCENA_ZAFRA1.SelectedValue, Enumeradores.TipoPlanilla.CompensacionEntregaCana)
                        Case rbtIncentivo.Checked
                            nombreDeta = "DETAFAC Corte " & lCatorcena.CATORCENA.ToString & " Planilla Incentivo a Productores.xlsx"
                            daDeta.FillPorCriterios(dtDeta, Me.CbxCATORCENA_ZAFRA1.SelectedValue, Enumeradores.TipoPlanilla.IncentivoProductores)
                    End Select

                    If dtDeta.Rows.Count > 0 Then
                        bRet = Me.ExportarExcel(dtDeta, strDirectorio & nombreDeta, "detafac", False)
                        If bRet Then
                            Me.Cursor = System.Windows.Forms.Cursors.Default
                            Me.txtDirectorio.Text = ""
                            MsgBox("Los archivos de créditos fiscales y facturas para PH se generaron con éxito", vbInformation, Application.ProductName)
                        Else
                            Me.Cursor = System.Windows.Forms.Cursors.Default
                            MsgBox("Error al generar el archivo de detalle de PH", vbInformation, Application.ProductName)
                        End If
                    End If
                Else
                    Me.Cursor = System.Windows.Forms.Cursors.Default
                    MsgBox("Error al generar el archivo de encabezado de PH", vbInformation, Application.ProductName)
                End If
            Else
                Me.Cursor = System.Windows.Forms.Cursors.Default
            End If

        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            MsgBox(ex.Message, vbCritical, Application.ProductName)
            ExceptionManager.Publish(ex)
        End Try
    End Sub

    Private Sub btnSeleccionarDirectorio_Click(sender As System.Object, e As System.EventArgs) Handles btnSeleccionarDirectorio.Click
        FolderBrowserDialog1.ShowDialog()
        If FolderBrowserDialog1.SelectedPath <> "" Then
            txtDirectorio.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub txtNO_PARTIDA_PH_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    Function ExportarExcel(ByVal DT As DataTable, ByVal nombreArchivo As String, ByVal nombreHoja As String, ByVal esEncabezado As Boolean) As Boolean
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

            If esEncabezado Then
                exHoja.Range("B:B").NumberFormat = "#"
                exHoja.Range("C:C").NumberFormat = "dd/MM/yyyy"
                exHoja.Range("D:D").NumberFormat = "@"
                exHoja.Range("E:E").NumberFormat = "@"
                exHoja.Range("F:F").NumberFormat = "@"
                exHoja.Range("I:I", "O:O").NumberFormat = "##0.00"
            Else
                exHoja.Range("B:B").NumberFormat = "#"
                exHoja.Range("C:C").NumberFormat = "dd/MM/yyyy"
                exHoja.Range("D:D").NumberFormat = "@"
                exHoja.Range("F:F").NumberFormat = "@"
                exHoja.Range("F:F", "I:I").NumberFormat = "##0.00"
            End If

            'Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
            For i As Integer = 1 To NCol
                exHoja.Cells.Item(1, i) = DT.Columns(i - 1).ColumnName.ToString
            Next
            For Fila As Integer = 0 To NRow - 1
                For Col As Integer = 0 To NCol - 1
                    exHoja.Cells.Item(Fila + 2, Col + 1) = DT.Rows(Fila).Item(Col).ToString()
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

    Private Sub ConfigRangoCompensacion()
        If Me.rbtCompensacion.Checked Then
            If Me.CbxCATORCENA_ZAFRA1.SelectedValue IsNot Nothing Then
                Me.cbxRANGO_COMPENSACION1.RecuperarPorCATORCENA_ZAFRA(Me.CbxCATORCENA_ZAFRA1.SelectedValue)
            Else
                Me.cbxRANGO_COMPENSACION1.RecuperarPorCATORCENA_ZAFRA(-1)
            End If
            Me.lblRangoCompensacion.Visible = True
            Me.cbxRANGO_COMPENSACION1.Visible = True
        Else
            Me.lblRangoCompensacion.Visible = False
            Me.cbxRANGO_COMPENSACION1.Visible = False
        End If
    End Sub

    Private Sub rbtCompensacion_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtCompensacion.CheckedChanged
        Me.ConfigRangoCompensacion()
    End Sub

    Private Sub CbxCATORCENA_ZAFRA1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CbxCATORCENA_ZAFRA1.SelectedIndexChanged
        Me.ConfigRangoCompensacion()
    End Sub
End Class