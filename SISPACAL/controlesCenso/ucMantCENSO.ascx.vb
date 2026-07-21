Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores
Imports System.Data
Imports System.IO
Imports ClosedXML.Excel

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucMantCENSO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para el Mantenimiento de la tabla CENSO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/04/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucMantCENSO
    Inherits ucBase

#Region "Inicializaciones Mantenimiento"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Inicializa la Lista de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla CENSO
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/04/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub InicializarLista()
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.VerOpcion("Generar", True)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", False)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", False)
        Me.trZAFRA.Visible = True
        Me.ucListaCENSO1.Visible = True
        Me.ucVistaDetalleCENSO1.Visible = False
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Inicializa el Detalle de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla CENSO
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/04/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub InicializarDetalle()
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.VerOpcion("Generar", False)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", True)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", True)
        Me.trZAFRA.Visible = False
        Me.ucListaCENSO1.Visible = False
        Me.ucVistaDetalleCENSO1.Visible = True
    End Sub
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla CENSO
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/04/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------

    Private Sub CargarCENSO()
        If Me.cbxZAFRA.Value IsNot Nothing Then
            Me.ucListaCENSO1.CargarDatosPorZAFRA(Me.cbxZAFRA.Value)
        Else
            Me.ucListaCENSO1.CargarDatosPorZAFRA(-1)
        End If
    End Sub

    Private Sub Inicializar()
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        Me.ucBarraNavegacion1.PermitirNavegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucBarraNavegacion1.CrearOpcion("Generar", "Generar Censo", False, IconoBarra.Generar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Cancelar", "Cancelar", False, IconoBarra.Cancelar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Guardar", "Guardar", True, IconoBarra.Guardar, "", "", True)
        Me.ucBarraNavegacion1.CargarOpciones()
        If lZafra IsNot Nothing Then
            Me.cbxZAFRA.Value = lZafra.ID_ZAFRA
            Me.CargarCENSO()
        End If
    End Sub

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquÃ­ el cÃ³digo de usuario para inicializar la pÃ¡gina
        If Not IsPostBack Then
            Me.Inicializar()
            Me.InicializarLista()
        End If
    End Sub

    Private Sub ucBarraNavegacion1_Cancelar(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucBarraNavegacion1.Cancelar
        Me.InicializarLista()
    End Sub

    Private Sub ucBarraNavegacion1_Guardar(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucBarraNavegacion1.Guardar
        Dim sError As String
        sError = Me.ucVistaDetalleCENSO1.Actualizar()
        If sError <> "" Then
            Return
        End If
        Me.InicializarLista()
    End Sub

    Protected Sub ucListaCENSO1_Editando(ByVal ID_CENSO As Int32) Handles ucListaCENSO1.Editando
        Me.InicializarDetalle()
        Me.ucVistaDetalleCENSO1.ID_CENSO = ID_CENSO
    End Sub

    Private Sub ucVistaDetalleCENSO1_ErrorEvent(ByVal errorMessage As String) Handles ucVistaDetalleCENSO1.ErrorEvent
        'Mostrar mensaje de error contenido en errorMessage
        Me.AsignarMensaje(errorMessage, True, True)
    End Sub

    Protected Sub cbxZAFRA_ValueChanged(sender As Object, e As System.EventArgs) Handles cbxZAFRA.ValueChanged
        Me.CargarCENSO()
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        Select Case CommandName
            Case "Generar"
                Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZafraActiva
                If lZafra IsNot Nothing Then
                    If Me.cbxZAFRA.Value = lZafra.ID_ZAFRA Then
                        Me.InicializarDetalle()
                        Me.ucVistaDetalleCENSO1.LimpiarControles()
                        Me.ucVistaDetalleCENSO1.ID_ZAFRA = lZafra.ID_ZAFRA
                        Me.ucVistaDetalleCENSO1.ID_CENSO = 0
                        Return
                    End If
                End If
                Me.AsignarMensaje("Solo puede generar censo en la zafra actual", False, True, True)

            Case "Guardar"
                Dim sError As String
                sError = Me.ucVistaDetalleCENSO1.Actualizar()
                If sError <> "" Then
                    AsignarMensaje(sError, True, False)
                    Return
                End If
                AsignarMensaje("", True, False)
                Me.InicializarLista()
                Me.ucListaCENSO1.DataBind()

            Case "GenerarExcel"
                Me.GenerarExcel()

            Case "Cancelar"
                Me.InicializarLista()
        End Select
    End Sub

    Private Function GenerarExcel() As String
        Dim libro As XLWorkbook = New XLWorkbook
        Dim bLotesCosecha As New cLOTES_COSECHA
        Dim sResultado As String
        Dim ds As DataSet
        Dim hoja As IXLWorksheet
        Dim lZafraAnt As ZAFRA
        Dim lZafraActiva As ZAFRA
        Dim nombreHoja As String
        Dim nombreArchivo As String
        Dim memStream As MemoryStream
        Dim filaTotal As Integer
        Dim listaColumnas As List(Of Integer)

        Try
            lZafraActiva = (New cZAFRA).ObtenerZafraActiva
            lZafraAnt = (New cZAFRA).ObtenerZAFRA(lZafraActiva.ID_ZAFRA - 1)
            nombreHoja = "ESTICAÑA ACTUA AL " & Now.ToString("ddMMyyyy")
            nombreArchivo = "ESTICAÑA COMPARATIVO ZAFRAS " & lZafraAnt.NOMBRE_ZAFRA.Replace("/", "-") & " Y " &
                lZafraActiva.NOMBRE_ZAFRA.Replace("/", "-") & " AL " & Now.ToString("ddMMyyyy") & ".xlsx"

            ds = bLotesCosecha.execXLS_COMPARATIVO_ZAFRA_ACTUAL_VS_ANTERIOR(lZafraActiva.ID_ZAFRA - 1, lZafraActiva.ID_ZAFRA)
            If ds IsNot Nothing AndAlso ds.Tables.Count > 0 Then
                'Renombrar columnas
                RenombrarColumnas(ds.Tables(0), lZafraActiva.ID_ZAFRA - 1, lZafraActiva.ID_ZAFRA)

                'Agregando datatable como hoja
                hoja = libro.Worksheets.Add(ds.Tables(0), nombreHoja)

                'Incrementando alto de la fila y centrando texto
                hoja.Rows.Style.Font.FontSize = 9
                hoja.FirstRow.Height = 32
                hoja.FirstRow.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center
                hoja.FirstRow.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center
                hoja.FirstRow.Style.Font.FontSize = 10
                hoja.SheetView.FreezeRows(1)

                'Fila Totales
                listaColumnas = Columnas_a_totalizar()
                filaTotal = ds.Tables(0).Rows.Count + 2
                hoja.Cell(filaTotal, 7).Value = "TOTALES"
                hoja.Cell(filaTotal, 7).Style.Font.FontSize = 12
                For i As Integer = 0 To listaColumnas.Count - 1
                    hoja.Cell(filaTotal, listaColumnas(i)).FormulaR1C1 = "=SUM(R[-" & ds.Tables(0).Rows.Count.ToString & "]C:R[-1]C)"
                    hoja.Cell(filaTotal, listaColumnas(i)).Style.NumberFormat.Format = "#,###,##0.00"
                    hoja.Cell(filaTotal, listaColumnas(i)).Style.Font.FontSize = 12
                Next
                For i As Integer = 1 To ds.Tables(0).Columns.Count
                    hoja.Cell(filaTotal, i).Style.Fill.BackgroundColor = XLColor.LightGray
                    hoja.Cell(filaTotal, i).Style.Border.TopBorder = XLBorderStyleValues.Thin
                    hoja.Cell(filaTotal, i).Style.Border.BottomBorder = XLBorderStyleValues.Thin
                    hoja.Cell(filaTotal, i).Style.Border.RightBorder = XLBorderStyleValues.Thin
                    hoja.Cell(filaTotal, i).Style.Border.LeftBorder = XLBorderStyleValues.Thin
                    hoja.Cell(filaTotal, i).Style.Font.Bold = True
                Next
                hoja.ColumnsUsed().AdjustToContents()
                '-------------------------------------------

                Response.Clear()
                Response.Buffer = True
                Response.Charset = ""
                Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"
                Response.AddHeader("content-disposition", "attachment;filename=" & nombreArchivo)
                memStream = New MemoryStream
                libro.SaveAs(memStream)
                Response.BinaryWrite(memStream.ToArray)
                Response.Flush()
                Response.SuppressContent = True
                HttpContext.Current.ApplicationInstance.CompleteRequest()
                sResultado = "0|Esticaña comparativo generado con exito!"
            Else
                sResultado = "-1|Esticaña comparativo"
            End If

            Return sResultado

        Catch ex As Exception
            sResultado = "-1|Error al generar esticaña comparativo: " & ex.Message.ToString
            Return sResultado
        End Try
    End Function

    Private Function Columnas_a_totalizar() As List(Of Integer)
        Dim lista As List(Of Integer)

        lista = New List(Of Integer)(New Integer() {13, 14, 15, 16, 18, 32, 33, 34, 35, 36, 37, 38, 42, 43, 44, 45, 46, 47, 48, 49})
        For i As Integer = 63 To 193
            lista.Add(i)
        Next
        Return lista
    End Function

    Private Sub RenombrarColumnas(ByRef dt As DataTable, ByVal id_zafra1 As Integer, ByVal id_zafra2 As Integer)
        Dim lZafra1 As ZAFRA
        Dim lZafra2 As ZAFRA
        Dim sNombre1 As String
        Dim sNombre2 As String
        Try


            lZafra1 = (New cZAFRA).ObtenerZAFRA(id_zafra1)
            sNombre1 = lZafra1.NOMBRE_ZAFRA
            sNombre1 = Mid(sNombre1, 3, 2) & "-" & Mid(sNombre1, 8, 2)
            lZafra2 = (New cZAFRA).ObtenerZAFRA(id_zafra2)
            sNombre2 = lZafra2.NOMBRE_ZAFRA
            sNombre2 = Mid(sNombre2, 3, 2) & "-" & Mid(sNombre2, 8, 2)

            For i As Integer = 0 To dt.Columns.Count - 1
                If Left(dt.Columns(i).ColumnName, 1) = "C" AndAlso dt.Columns(i).ColumnName.Length <= 4 Then
                    dt.Columns(i).ColumnName = Replace(dt.Columns(i).ColumnName, "C", "")
                Else
                    If i <= 18 Then
                        dt.Columns(i).ColumnName = sNombre1 & " " & dt.Columns(i).ColumnName
                    End If
                End If
            Next
            dt.Columns(16).ColumnName = sNombre1 & " TC/MZ"
            dt.Columns(18).ColumnName = sNombre1 & " REND. REAL LBS/TC"
            dt.Columns("ACCESLOTE_Z").ColumnName = sNombre2 & " ACCESLOTE"
            dt.Columns("ZAFRA_Z").ColumnName = sNombre2 & " ZAFRA"
            dt.Columns("ZONA_Z").ColumnName = sNombre2 & " ZONA"
            dt.Columns("CODIGO_Z").ColumnName = sNombre2 & " CODIGO"
            dt.Columns("SOCIO_Z").ColumnName = sNombre2 & " SOCIO"
            dt.Columns("PRODUCTOR_Z").ColumnName = sNombre2 & " PRODUCTOR"
            dt.Columns("VIENE_MULTI_Z").ColumnName = "VIENE MULTIZAFRAS ANTERIORES"
            dt.Columns("NO_CONTRATO_Z").ColumnName = sNombre2 & " No CONTRATO"
            dt.Columns("CODILOTE_Z").ColumnName = sNombre2 & " CODILOTE"
            dt.Columns("NOMBLOTE_Z").ColumnName = sNombre2 & " NOMBLOTE"
            dt.Columns("OB_PROD_INTERNA").ColumnName = "OBSERVACIONES PRODUCCION INTERNA GRUPO JD"
            dt.Columns("OB_PERSO_TEC").ColumnName = "OBSERVACIONES PERSONAL TECNICO"
            dt.Columns("MZ_PERDIDA").ColumnName = "AREA PERDIDA"
            dt.Columns("TC_PERDIDA").ColumnName = sNombre2 & " TC PERDIDAS"
            dt.Columns("SIEMBRA_NUEVA").ColumnName = "SIEMBRAS NUEVAS"
            dt.Columns("SIEMBRA_PROYE").ColumnName = "PROYECCION DE SIEMBRA"
            dt.Columns("MZ_PENDIENTE").ColumnName = "PENDIENTE DE CONTRATAR MZ"
            dt.Columns("TC_PENDIENTE").ColumnName = "PENDIENTE DE CONTRATAR TC"
            dt.Columns("TIPO_ROZA").ColumnName = "TIPO ROZA"
            dt.Columns("TIPO_TRANSPORTE").ColumnName = "TIPO TRANSPORTE"
            dt.Columns("TIPO_QUEMA").ColumnName = "TIPO QUEMA"
            dt.Columns("MZ_CONTRA_Z").ColumnName = sNombre2 & " MZ CONTRATADAS"
            dt.Columns("MZ_ESTI_Z").ColumnName = sNombre2 & " MZ ESTICAÑA"
            dt.Columns("TC_MZ_ESTI_Z").ColumnName = sNombre2 & " TC/MZ ESTICAÑA"
            dt.Columns("TC_ESTI_Z").ColumnName = sNombre2 & " TOTAL TC ESTICAÑA"
            dt.Columns("TC_ENTREGADO2").ColumnName = sNombre1 & " TC ENTREGADO"
            dt.Columns("TC_ESTI_Z2").ColumnName = sNombre2 & " TC ESTICAÑA"
            dt.Columns("TC_MENOS").ColumnName = sNombre2 & " TC DE MENOS"
            dt.Columns("TC_MAS").ColumnName = sNombre2 & " TC DE MAS"
            dt.Columns("EJEC_MADURANTE").ColumnName = sNombre1 & " MADURANTE APLICADO"
            dt.Columns("EJEC_MADURANTE_DOSIS").ColumnName = sNombre1 & " MADURANTE APLICADO DOSIS"
            dt.Columns("EJEC_FECHA_APLI").ColumnName = sNombre1 & " FECHA APLICACION"
            dt.Columns("EJEC_FECHA_ROZA").ColumnName = sNombre1 & " FECHA ROZA VENTANA"
            dt.Columns("FEC_PRIM_VIAJE").ColumnName = sNombre1 & " FECHA PRIMER VIAJE"
            dt.Columns("FEC_ULT_VIAJE").ColumnName = sNombre1 & " FECHA ULTIMO VIAJE"
            dt.Columns("FEC_PRIM_VIAJE_MAS12").ColumnName = sNombre2 & " CICLO " & sNombre1 & "(PRIMER VIAJE + 12 MESES)"
            dt.Columns("FECHA_ROZA_TECNICO").ColumnName = sNombre2 & " MADURANTE ESTICAÑA"
            dt.Columns("MESES_EN_COSECHARA_LOTE").ColumnName = sNombre2 & " FECHA APLICACION ESTICAÑA"
            dt.Columns("MAD_PROD_XEJE").ColumnName = sNombre2 & " FECHA ROZA VENTANA ESTICAÑA"
            dt.Columns("MAD_FECPROG_XEJE").ColumnName = sNombre2 & " FECHA PRIMER VIAJE"
            dt.Columns("FECHA_APLI_Z").ColumnName = sNombre2 & " FECHA ULTIMO VIAJE"
            dt.Columns("MAD_FECROZA_XEJE").ColumnName = sNombre2 & " MESES CON LOS QUE SE COSECHARA EL LOTE"
            dt.Columns("TC_ENTREGADO3").ColumnName = "TOTAL TC " & sNombre1
            dt.Columns("VARIEDAD_Z").ColumnName = "CAÑA VARIEDAD"
            dt.Columns("TIPO_Z").ColumnName = "CAÑA TIPO"
            dt.Columns("SUBTIPO_Z").ColumnName = "CAÑA SUBTIPO"
            dt.Columns("TERCIO_Z").ColumnName = "TERCIO"
            dt.Columns("SUBTERCIO_Z").ColumnName = "SUBTERCIO"

        Catch ex As Exception
            Exit Sub

        End Try
    End Sub
End Class
