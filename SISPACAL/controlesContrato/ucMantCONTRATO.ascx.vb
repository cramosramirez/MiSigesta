Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores
Imports DevExpress.Web
Imports System.Data
Imports System.IO
Imports DocumentFormat.OpenXml.Packaging
Imports DocumentFormat.OpenXml.Wordprocessing
Imports System.Diagnostics
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucMantCONTRATO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para el Mantenimiento de la tabla CONTRATO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	23/06/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucMantCONTRATO
    Inherits ucBase


    Private _tipo_operacion As TipoOperacionContrato
    Public Property TIPO_OPERACION As TipoOperacionContrato
        Get
            Return _tipo_operacion
        End Get
        Set(ByVal value As TipoOperacionContrato)
            _tipo_operacion = value
        End Set
    End Property

#Region "Inicializaciones Mantenimiento"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Inicializa la Lista de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla CONTRATO
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/06/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------


    Public Sub InicializarLista()
        Me.AsignarMensaje("", True, False)
        Me.ucBarraNavegacion1.VerOpcion("Buscar", True)
        Me.ucBarraNavegacion1.VerOpcion("Agregar", True)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", False)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", False)
        Me.ucBarraNavegacion1.VerOpcion("CrearProveedor", False)
        Me.ucBarraNavegacion1.VerOpcion("CrearSocio", False)
        Me.ucBarraNavegacion1.VerOpcion("CrearLote", False)
        Me.ucBarraNavegacion1.VerOpcion("TraspasarLote", False)
        Me.ucBarraNavegacion1.VerOpcion("Actualizar", False)

        Me.ucCriteriosLotesLayout.Visible = True
        Me.ucListaCONTRATO1.Visible = True
        Me.ucVistaDetalleCONTRATO1.LimpiarSesion()
        Me.ucVistaDetalleCONTRATO1.Visible = False
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Inicializa el Detalle de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla CONTRATO
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/06/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    ''' 

    Private Sub InicializarDetalle()
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.VerOpcion("Buscar", False)
        Me.ucBarraNavegacion1.VerOpcion("Agregar", False)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", True)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", True)
        Me.ucBarraNavegacion1.VerOpcion("CrearProveedor", True)
        Me.ucBarraNavegacion1.VerOpcion("CrearSocio", True)
        Me.ucBarraNavegacion1.VerOpcion("CrearLote", True)
        Me.ucBarraNavegacion1.VerOpcion("TraspasarLote", True)
        Me.ucBarraNavegacion1.VerOpcion("Actualizar", True)

        Me.ucCriteriosLotesLayout.Visible = False
        Me.ucListaCONTRATO1.Visible = False
        Me.ucVistaDetalleCONTRATO1.Visible = True
    End Sub
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla CONTRATO
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/06/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Try
            Return Me.CargarCONTRATO()
        Catch ex As Exception
            Return -1
        End Try
        Return 1
    End Function

    Private Function CargarCONTRATO() As Integer
        If Me.ucListaCONTRATO1.CargarDatos() <> 1 Then Return -1
        Return 1
    End Function

    Private Sub Inicializar()
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        Me.ucVistaDetalleCONTRATO1.TIPO_OPERACION = Me.TIPO_OPERACION
        Me.ucBarraNavegacion1.PermitirNavegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucBarraNavegacion1.CrearOpcion("Buscar", "Buscar", False, IconoBarra.Buscar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Agregar", "Ingresar nuevo Contrato", False, IconoBarra.Generar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Cancelar", "Cancelar", False, IconoBarra.Cancelar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Guardar", "Guardar", True, IconoBarra.Guardar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("CrearProveedor", "Ingresar nuevo Proveedor", False, IconoBarra.Proveedor, "onclick", "e.processOnServer=false;CrearProveedor()", True)
        Me.ucBarraNavegacion1.CrearOpcion("CrearSocio", "Ingresar nuevo socio", False, IconoBarra.Socio, "onclick", "e.processOnServer=false;CrearSocio()", True)
        Me.ucBarraNavegacion1.CrearOpcion("CrearLote", "Ingresar nuevo Lote", False, IconoBarra.Lote, "onclick", "e.processOnServer=false;CrearLote()", True)
        Me.ucBarraNavegacion1.CrearOpcion("TraspasarLote", "Traspasar Lote de Contrato", False, "people_team_16x16", "", "", True)
        Select Case TIPO_OPERACION
            Case TipoOperacionContrato.Ingreso
                Me.lblTitulo.Text = "Mantenimiento de Contratos"

            Case TipoOperacionContrato.Consulta
                Me.lblTitulo.Text = "Consulta de Contratos"
        End Select
        Me.ucBarraNavegacion1.CrearOpcion("Actualizar", "Actualizar lotes", False, IconoBarra.Actualizar, "", "", True)
        Me.ucBarraNavegacion1.CargarOpciones()
        If lZafra IsNot Nothing Then
            Me.cbxZAFRA.Value = lZafra.ID_ZAFRA
        End If
        Me.CargarZafras()
    End Sub

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquÃ­ el cÃ³digo de usuario para inicializar la pÃ¡gina
        If Not IsPostBack Then
            Me.Inicializar()
            Me.InicializarLista()
        End If
    End Sub

    Protected Sub ucListaCONTRATO1_Editando(ByVal CODICONTRATO As String) Handles ucListaCONTRATO1.Editando
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZafraActiva

        Me.InicializarDetalle()
        Me.ucVistaDetalleCONTRATO1.CODICONTRATO = CODICONTRATO
        Me.SetearAREA_TCXAREA()
        If lZafra IsNot Nothing Then
            If lZafra.ID_ZAFRA <> Me.ucVistaDetalleCONTRATO1.ID_ZAFRA Then
                Me.ucBarraNavegacion1.VerOpcion("Guardar", True)
                Me.ucBarraNavegacion1.VerOpcion("CrearProveedor", False)
                Me.ucBarraNavegacion1.VerOpcion("CrearSocio", False)
                Me.ucBarraNavegacion1.VerOpcion("CrearLote", False)
                Me.ucBarraNavegacion1.VerOpcion("Actualizar", True)
            End If
        End If
    End Sub

    Private Sub ucVistaDetalleCONTRATO1_ErrorEvent(ByVal errorMessage As String) Handles ucVistaDetalleCONTRATO1.ErrorEvent
        'Mostrar mensaje de error contenido en errorMessage
        Me.AsignarMensaje(errorMessage, True, True)
    End Sub

    Private Sub CargarZafras()
        Dim lZafra As ZAFRA
        Dim lZafras As New listaZAFRA


        lZafra = (New cZAFRA).ObtenerZafraActiva
        lZafras = (New cZAFRA).ObtenerLista
        Me.cbxZAFRAadd.DataSource = lZafras
        Me.cbxZAFRAadd.DataBind()
        If Me.cbxZAFRAadd.Items.Count > 0 AndAlso lZafra IsNot Nothing Then Me.cbxZAFRAadd.Value = lZafra.ID_ZAFRA
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        Select Case CommandName
            Case "Buscar"
                Dim noContrato As Integer = -1
                Dim CODIPROVEE As String = ""
                Dim CODISOCIO As String = ""
                If Me.txtCODIPROVEE.Text <> "" Then CODIPROVEE = Utilerias.FormatoCODIPROVEE(CInt(Me.txtCODIPROVEE.Text))
                If Me.txtCODISOCIO.Text <> "" Then CODISOCIO = Utilerias.FormatoCODISOCIO(CInt(Me.txtCODISOCIO.Text))

                If Me.txtNO_CONTRATO.Text <> "" Then
                    noContrato = Me.txtNO_CONTRATO.Value
                End If
                Me.ucListaCONTRATO1.CargarDatosPorCriterios(Me.cbxZAFRA.Value, noContrato, CODIPROVEE, CODISOCIO)

            Case "Agregar"
                Me.InicializarDetalle()
                Me.ucVistaDetalleCONTRATO1.LimpiarControles()
                Me.ucVistaDetalleCONTRATO1.CODICONTRATO = ""

            Case "Guardar"
                Dim sError As String
                sError = Me.ucVistaDetalleCONTRATO1.Actualizar()
                If sError <> "" Then
                    AsignarMensaje(sError, True, False)
                    Return
                End If
                AsignarMensaje("", True, False)
                Me.InicializarLista()
                Me.ucListaCONTRATO1.DataBind()

            Case "TraspasarLote"
                Dim lResult As String = Me.ucVistaDetalleCONTRATO1.ElegirLoteContratado
                AsignarMensaje(lResult, True, False)

            Case "Cancelar"
                'Dim l As New cACUKARDE
                'l.ExportarDatos()
                Me.InicializarLista()

            Case "Actualizar"
                Me.ucVistaDetalleCONTRATO1.RefrescarDetalleLotes()
        End Select
    End Sub

    Protected Sub cpMantCONTRATO_Callback(sender As Object, e As DevExpress.Web.CallbackEventArgsBase) Handles cpMantCONTRATO.Callback
        Dim parametros As String() = e.Parameter.Split(";")
        Me.cpMantCONTRATO.JSProperties.Clear()
        Me.cpMantCONTRATO.JSProperties.Add("cpOpcion", parametros(0))

        Select Case parametros(0)
            Case "TotalizarMZ_TONEL"
                Me.ucVistaDetalleCONTRATO1.SetearAREA_TCXAREA()
        End Select
    End Sub

    Private Sub SetearAREA_TCXAREA()
        Dim MZ As Decimal = 0
        Dim TC As Decimal = 0
        Dim TC_X_AREA As Decimal = 0
        For Each lLotes As LOTES In Me.ucVistaDetalleCONTRATO1.LISTA_LOTES
            MZ += lLotes.AREA
            TC += lLotes.TONELADAS
            TC_X_AREA += (lLotes.AREA * lLotes.TONELADAS)
        Next
        Me.ucVistaDetalleCONTRATO1.AREA_CULTIVADA = MZ
        Me.ucVistaDetalleCONTRATO1.TONEL_X_AREA = TC_X_AREA
    End Sub

    Private Sub ucListaCONTRATO1_GenerarContratoLegal(CODICONTRATO As String) Handles ucListaCONTRATO1.GenerarContratoLegal
        Me.GenerarContratoLegal(CODICONTRATO)
    End Sub

    Private Sub GenerarContratoLegal(ByVal CODICONTRATO As String)
        Dim bContrato As New cCONTRATO
        Dim ds As DataSet
        Dim fila As DataRow
        Dim plantillaWord As String
        Dim nombreBase As String
        Dim wordTemp As String
        Dim carpetaTemp As String
        Dim pdfFinal As String
        Dim lContrato As CONTRATO

        Try
            lContrato = (New cCONTRATO).ObtenerCONTRATO(CODICONTRATO)
            ds = bContrato.SP_GENERA_CONTRATO_LEGAL_PRODUCTOR(CODICONTRATO)
            If ds IsNot Nothing AndAlso ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                fila = ds.Tables(0).Rows(0)
                plantillaWord = Server.MapPath(ConfigurationManager.AppSettings("CONTRATO_LEGAL_PRODUCTOR"))
                nombreBase = lContrato.CODIPROVEEDOR + "_" + lContrato.NO_CONTRATO.ToString + "_" + Now.ToString("yyyyMMdd") + "_" + Now.ToString("HHmmss") + ".docx"
                wordTemp = Server.MapPath("~/temp/" & nombreBase)
                carpetaTemp = Server.MapPath("~/temp")
                ' Copiar archivo nombreBase a ~/Temp
                File.Copy(plantillaWord, wordTemp, True)
                ' Reemplazar marcadores en archivo copiado
                ReemplazarMarcadoresWord(wordTemp, fila)
                ' Generar pdf con librería LibreOffice
                ConvertirWordAPdf(wordTemp, carpetaTemp)
                pdfFinal = wordTemp.Replace(".docx", ".pdf")
                'Eliminar word generado
                File.Delete(wordTemp)
                ' Enviar PDF al navegador
                ScriptManager.RegisterClientScriptBlock(Me, Page.GetType, "script", "MostrarContratoLegal('" & nombreBase.Replace(".docx", ".pdf") & "','" & CODICONTRATO & "')", True)
            End If

        Catch ex As Exception
            AsignarMensaje("Fallo al generar contrato: " + ex.Message.ToString, True, False)
        End Try
    End Sub

    Sub ReemplazarMarcadoresWord(ByVal rutaWord As String, ByVal fila As DataRow)
        Using doc As WordprocessingDocument =
        WordprocessingDocument.Open(rutaWord, True)

            Dim textos = doc.MainDocumentPart.Document.Descendants(Of Text)()

            For Each t As Text In textos
                For Each col As DataColumn In fila.Table.Columns
                    Dim marcador As String = "{{" & col.ColumnName & "}}"

                    If t.Text.Contains(marcador) Then
                        t.Text = t.Text.Replace(
                        marcador,
                        If(IsDBNull(fila(col)), "", fila(col).ToString())
                    )
                    End If
                Next
            Next
            doc.MainDocumentPart.Document.Save()
        End Using
    End Sub

    Sub ConvertirWordAPdf(rutaWord As String, carpetaSalida As String)
        Dim libreOffice As String = ConfigurationManager.AppSettings("UBICACION_LIBRE_OFFICE")
        Dim p As New Process()
        Dim cadena As New StringBuilder

        cadena.Append("--headless ")
        cadena.Append("--convert-to pdf ")
        cadena.Append("""" & rutaWord & """ ")
        cadena.Append("--outdir ")
        cadena.Append("""" & carpetaSalida & """")
        p.StartInfo.FileName = libreOffice
        p.StartInfo.Arguments = cadena.ToString
        p.StartInfo.UseShellExecute = False
        p.StartInfo.CreateNoWindow = True
        p.Start()
        p.WaitForExit()
    End Sub

End Class
