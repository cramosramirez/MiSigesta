Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucMantMAESTRO_LOTES
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para el Mantenimiento de la tabla MAESTRO_LOTES
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	26/05/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucMantMAESTRO_LOTES
    Inherits ucbase

#Region "Inicializaciones Mantenimiento"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Inicializa la Lista de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla MAESTRO_LOTES
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/05/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub InicializarLista()
        Me.AsignarMensaje("", True, False)
        Me.ucBarraNavegacion1.VerOpcion("Buscar", True)
        Me.ucBarraNavegacion1.VerOpcion("Agregar", True)
        Me.ucBarraNavegacion1.VerOpcion("VistaPrevia", True)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", False)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", False)
        Me.ucBarraNavegacion1.VerOpcion("GuardarCerrar", False)
        Me.ucBarraNavegacion1.VerOpcion("Cesion", False)
        Me.ucCriteriosLotes1.Visible = True
        Me.ucListaMAESTRO_LOTES1.Visible = True
        Me.ucVistaDetalleMAESTRO_LOTES1.Visible = False
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Inicializa el Detalle de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla MAESTRO_LOTES
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/05/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub InicializarDetalle()
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.VerOpcion("Buscar", False)
        Me.ucBarraNavegacion1.VerOpcion("Agregar", False)
        Me.ucBarraNavegacion1.VerOpcion("VistaPrevia", False)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", True)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", True)
        Me.ucBarraNavegacion1.VerOpcion("GuardarCerrar", False)
        Me.ucCriteriosLotes1.Visible = False
        Me.ucListaMAESTRO_LOTES1.Visible = False
        Me.ucVistaDetalleMAESTRO_LOTES1.Visible = True
    End Sub

    Private Sub InicializarDetalleVista()
        Me.AsignarMensaje("", True, False)
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirSalir = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.VerOpcion("Buscar", False)
        Me.ucBarraNavegacion1.VerOpcion("Agregar", False)
        Me.ucBarraNavegacion1.VerOpcion("VistaPrevia", False)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", False)
        Me.ucBarraNavegacion1.VerOpcion("GuardarCerrar", True)
        Me.ucCriteriosLotes1.Visible = False
        Me.ucListaMAESTRO_LOTES1.Visible = False
        Me.ucVistaDetalleMAESTRO_LOTES1.Visible = True
    End Sub

    Private Sub Inicializar()
        Me.ucBarraNavegacion1.PermitirNavegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucBarraNavegacion1.CrearOpcion("Buscar", "Buscar", False, IconoBarra.Buscar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Agregar", "Ingresar nuevo Lote", False, IconoBarra.Generar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("VistaPrevia", "Ver resultados en reporte", False, IconoBarra.Reporte, "onclick", "e.processOnServer=false;VistaPrevia();", True)
        Me.ucBarraNavegacion1.CrearOpcion("Cancelar", "Cancelar", False, IconoBarra.Cancelar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Guardar", "Guardar", True, IconoBarra.Guardar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("GuardarCerrar", "Guardar y cerrar", True, IconoBarra.Guardar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Cesion", "Cesion de Lote", False, IconoBarra.Cesion, "", "", True)
        Me.ucBarraNavegacion1.CargarOpciones()
    End Sub
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla MAESTRO_LOTES
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/05/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Try 
            Return Me.CargarMAESTRO_LOTES()
        Catch ex As Exception 
            Return -1 
        End Try 
        Return 1
    End Function

    Private Function CargarMAESTRO_LOTES() As Integer
        If Me.ucListaMAESTRO_LOTES1.CargarDatos() <> 1 Then Return -1
        Return 1
    End Function

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquÃ­ el cÃ³digo de usuario para inicializar la pÃ¡gina
        If Not IsPostBack Then
            Me.Inicializar()
            Me.InicializarLista()

            If Request.QueryString("op") IsNot Nothing Then
                If Request.QueryString("op") = 1 Then
                    Me.InicializarDetalleVista()
                    Me.ucVistaDetalleMAESTRO_LOTES1.LimpiarControles()
                    Me.ucVistaDetalleMAESTRO_LOTES1.ID_MAESTRO = 0
                ElseIf Request.QueryString("op") = 2 AndAlso Request.QueryString("id") IsNot Nothing Then
                    Me.InicializarDetalleVista()
                    Me.ucVistaDetalleMAESTRO_LOTES1.LimpiarControles()
                    Me.ucVistaDetalleMAESTRO_LOTES1.ID_MAESTRO = CInt(Request.QueryString("id"))
                    Me.ucVistaDetalleMAESTRO_LOTES1.TabActivo = 2
                End If
            End If
        End If
    End Sub

    Private Sub UcBarraNavegacion1_Agregar(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucBarraNavegacion1.Agregar
        Me.InicializarDetalle()
        Me.UcVistaDetalleMAESTRO_LOTES1.LimpiarControles()
        Me.ucVistaDetalleMAESTRO_LOTES1.ID_MAESTRO = 0
    End Sub

    Private Sub ucBarraNavegacion1_Cancelar(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucBarraNavegacion1.Cancelar
        Me.InicializarLista()
    End Sub

    Private Sub ucBarraNavegacion1_Guardar(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucBarraNavegacion1.Guardar
        Dim sError As String
        sError = Me.UcVistaDetalleMAESTRO_LOTES1.Actualizar()
        If sError <> "" Then
            Return
        End If
        Me.InicializarLista()
    End Sub

    Private Sub ucVistaDetalleMAESTRO_LOTES1_ErrorEvent(ByVal errorMessage As String) Handles UcVistaDetalleMAESTRO_LOTES1.ErrorEvent
        'Mostrar mensaje de error contenido en errorMessage
        Me.AsignarMensaje(errorMessage, True, True)
    End Sub

    Protected Sub cpMantMAESTRO_LOTES_Callback(sender As Object, e As DevExpress.Web.CallbackEventArgsBase) Handles cpMantMAESTRO_LOTES.Callback
        Dim parametros As String() = e.Parameter.Split(";")
        Me.cpMantMAESTRO_LOTES.JSProperties.Clear()
        Me.cpMantMAESTRO_LOTES.JSProperties.Add("cpOpcion", parametros(0))

        Select Case parametros(0)
            Case "GuardarMaestroLotes"
                Dim sError As String
                sError = Me.ucVistaDetalleMAESTRO_LOTES1.Actualizar()
                If sError <> "" Then
                    Me.cpMantMAESTRO_LOTES.JSProperties("cpOpcion") = "Error"
                    Me.cpMantMAESTRO_LOTES.JSProperties.Add("cpError", sError)
                    Return
                End If
                Me.InicializarLista()
                Me.ucListaMAESTRO_LOTES1.DataBind()

            Case "SetearZona_SubZona"
                Dim lCanton As CANTON = (New cCANTON).ObtenerCANTON(Me.ucVistaDetalleMAESTRO_LOTES1.CODI_CANTON, Me.ucVistaDetalleMAESTRO_LOTES1.CODI_DEPTO, Me.ucVistaDetalleMAESTRO_LOTES1.CODI_MUNI)
                If lCanton IsNot Nothing Then
                    Me.ucVistaDetalleMAESTRO_LOTES1.ZONA = lCanton.ZONA
                    Me.ucVistaDetalleMAESTRO_LOTES1.SUB_ZONA = lCanton.SUB_ZONA
                Else
                    Me.ucVistaDetalleMAESTRO_LOTES1.ZONA = ""
                    Me.ucVistaDetalleMAESTRO_LOTES1.SUB_ZONA = ""
                End If
        End Select
    End Sub

    Protected Sub ucListaMAESTRO_LOTES1_Editando(ID_MAESTRO As Int32) Handles ucListaMAESTRO_LOTES1.Editando
        Me.InicializarDetalle()
        Me.ucBarraNavegacion1.VerOpcion("Cesion", True)
        Me.ucVistaDetalleMAESTRO_LOTES1.ID_MAESTRO = ID_MAESTRO
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        Select Case CommandName
            Case "Buscar"
                Dim CODIPROVEE As String = ""
                Dim CODISOCIO As String = ""
                If Me.ucCriteriosLotes1.CODIPROVEE.Trim <> "" Then CODIPROVEE = Utilerias.FormatoCODIPROVEE(CInt(Me.ucCriteriosLotes1.CODIPROVEE))
                If Me.ucCriteriosLotes1.CODISOCIO.Trim <> "" Then CODISOCIO = Utilerias.FormatoCODISOCIO(CInt(Me.ucCriteriosLotes1.CODISOCIO))
                Me.ucListaMAESTRO_LOTES1.CargarDatosPorCriteriosPostbackZafra(Me.ucCriteriosLotes1.ZONA,
                                                                 Me.ucCriteriosLotes1.SUB_ZONA,
                                                                 Me.ucCriteriosLotes1.CODI_DETO,
                                                                 Me.ucCriteriosLotes1.CODI_MUNI,
                                                                 Me.ucCriteriosLotes1.CODI_CANTON,
                                                                 CODIPROVEE,
                                                                 CODISOCIO,
                                                                 Me.ucCriteriosLotes1.CODICONTRATO,
                                                                 Me.ucCriteriosLotes1.NOMBRE_PROVEEDOR,
                                                                 Me.ucCriteriosLotes1.ID_ZAFRA)

            Case "Guardar"
                Dim sError As String
                sError = Me.ucVistaDetalleMAESTRO_LOTES1.Actualizar()
                If sError <> "" Then
                    AsignarMensaje(sError, True, False)
                    Return
                End If
                AsignarMensaje("", True, False)
                Me.InicializarLista()
                Me.ucListaMAESTRO_LOTES1.DataBind()

            Case "GuardarCerrar"
                Dim sError As String
                sError = Me.ucVistaDetalleMAESTRO_LOTES1.Actualizar()
                If sError <> "" Then
                    AsignarMensaje(sError, True, False)
                    Return
                End If
                Dim strscript As String = "<script language=javascript>window.top.close();</script>"
                If Not Page.ClientScript.IsStartupScriptRegistered("clientScript") Then
                    Page.ClientScript.RegisterStartupScript(Page.GetType(), "clientScript", strscript)
                End If

            Case "Agregar"
                Me.InicializarDetalle()
                Me.ucVistaDetalleMAESTRO_LOTES1.LimpiarControles()
                Me.ucVistaDetalleMAESTRO_LOTES1.ID_MAESTRO = 0

            Case "Cancelar"
                Me.InicializarLista()
        End Select
    End Sub

    Protected Sub ucVistaDetalleMAESTRO_LOTES1_SeleccionadoCanton(cadCODICANTON As String) Handles ucVistaDetalleMAESTRO_LOTES1.SeleccionadoCanton
        Dim parametros As String() = cadCODICANTON.Split(";")
        Dim lDepto As DEPARTAMENTO = (New cDEPARTAMENTO).ObtenerDEPARTAMENTO(parametros(0))
        Dim lMuni As MUNICIPIO = (New cMUNICIPIO).ObtenerMUNICIPIO(parametros(0), parametros(1))
        Dim lCanton As CANTON = (New cCANTON).ObtenerCANTON(parametros(2), parametros(0), parametros(1))

        If lCanton IsNot Nothing Then
            Me.ucListaMAESTRO_LOTES2.CargarDatosPorCriteriosPostback("", "", lCanton.CODI_DEPTO, lCanton.CODI_MUNI, lCanton.CODI_CANTON, "", "", -1, "")
            Me.pcLotesPorCanton.HeaderText = "Lotes existentes en el Canton: " + lCanton.NOMBRE_CANTON + ", " + lMuni.NOMBRE_MUNI + ", " + lDepto.NOMBRE_DEPTO
            Me.lblpcMensaje.Text = "Verifique si el lote que desea crear ya existe en el Canton: " + lCanton.NOMBRE_CANTON + " y si pertenece a otro Proveedor"
            Me.pcLotesPorCanton.ShowOnPageLoad = True
        End If
    End Sub

    Protected Sub ucListaMAESTRO_LOTES2_Mostrando(ID_MAESTRO As Integer) Handles ucListaMAESTRO_LOTES2.Mostrando
        Me.pcLotesPorCanton.ShowOnPageLoad = False
        Me.ucBarraNavegacion1.VerOpcion("Cesion", True)
        Me.ucVistaDetalleMAESTRO_LOTES1.ID_MAESTRO = ID_MAESTRO
    End Sub
End Class
