Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucMantSOLIC_OIP_TRANS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para el Mantenimiento de la tabla SOLIC_OIP_TRANS
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	23/10/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucMantSOLIC_OIP_TRANS
    Inherits ucBase


#Region "Inicializaciones Mantenimiento"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Inicializa la Lista de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla SOLIC_ANTICIPO
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	17/06/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub InicializarLista()
        Me.lblTitulo.Text = "Orden Irrevocable de Pago de Transportistas"
        Me.ucBarraNavegacion1.VerOpcion("Buscar", True)
        Me.ucBarraNavegacion1.VerOpcion("Agregar", True)
        Me.ucBarraNavegacion1.VerOpcion("Exportar", True)
        Me.ucBarraNavegacion1.VerOpcion("Aceptar", False)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", False)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", False)
        Me.ucBarraNavegacion1.VerOpcion("GuardarCerrar", False)
        Me.ucListaSOLIC_OIP_TRANS1.Visible = True
        Me.ucVistaDetalleSOLIC_OIP_TRANS1.Visible = False
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Inicializa el Detalle de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla SOLIC_ANTICIPO
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	17/06/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub InicializarDetalle(Optional ByVal ID_OIP_TRANS As Int32 = -1)
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.VerOpcion("Buscar", False)
        Me.ucBarraNavegacion1.VerOpcion("Agregar", False)
        Me.ucBarraNavegacion1.VerOpcion("Exportar", False)
        Me.ucBarraNavegacion1.VerOpcion("Aceptar", False)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", True)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", True)
        Me.ucBarraNavegacion1.VerOpcion("GuardarCerrar", False)
        If ID_OIP_TRANS <> -1 Then
            Dim lSolicOpi As SOLIC_OIP_TRANS = (New cSOLIC_OIP_TRANS).ObtenerSOLIC_OIP_TRANS(ID_OIP_TRANS)
            If lSolicOpi IsNot Nothing Then
                If Not lSolicOpi.ES_ACEPTADA Then
                    Me.ucBarraNavegacion1.VerOpcion("Aceptar", True)
                Else
                    Me.ucBarraNavegacion1.VerOpcion("Guardar", False)
                End If
            End If
        End If
        Me.ucListaSOLIC_OIP_TRANS1.Visible = False
        Me.ucVistaDetalleSOLIC_OIP_TRANS1.Visible = True
    End Sub

    Private Sub InicializarDetalleVista()
        Me.AsignarMensaje("", True, False)
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirSalir = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.VerOpcion("Buscar", False)
        Me.ucBarraNavegacion1.VerOpcion("Agregar", False)
        Me.ucBarraNavegacion1.VerOpcion("Exportar", False)
        Me.ucBarraNavegacion1.VerOpcion("Aceptar", False)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", False)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", False)
        Me.ucBarraNavegacion1.VerOpcion("GuardarCerrar", True)
        Me.ucListaSOLIC_OIP_TRANS1.Visible = False
        Me.ucVistaDetalleSOLIC_OIP_TRANS1.Visible = True
    End Sub

    Private Sub Inicializar()
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        Me.ucBarraNavegacion1.PermitirNavegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucBarraNavegacion1.CrearOpcion("Buscar", "Buscar", False, IconoBarra.Buscar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Agregar", "Ingresar nueva OIP", False, IconoBarra.Generar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Exportar", "Exportar a Excel", False, IconoBarra.ExportarXlsx, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Cancelar", "Cancelar", False, IconoBarra.Cancelar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Guardar", "Guardar", True, IconoBarra.Guardar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Aceptar", "Aceptar OIP", False, IconoBarra.Aplicar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("GuardarCerrar", "Guardar y cerrar", True, IconoBarra.Guardar, "", "", True)
        Me.ucBarraNavegacion1.CargarOpciones()
        'If lZafra IsNot Nothing Then
        '    Me.cbxZAFRA.Value = lZafra.ID_ZAFRA
        'End If
    End Sub
#End Region


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla SOLIC_OPI
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/06/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Try
            Return Me.CargarSOLIC_OPI()
        Catch ex As Exception
            Return -1
        End Try
        Return 1
    End Function

    Private Function CargarSOLIC_OPI() As Integer
        If Me.ucListaSOLIC_OIP_TRANS1.CargarDatos() <> 1 Then Return -1
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
                    Me.ucVistaDetalleSOLIC_OIP_TRANS1.LimpiarControles()
                    Me.ucVistaDetalleSOLIC_OIP_TRANS1.ID_OIP_TRANS = 0
                End If
            End If
        End If
    End Sub

    Protected Sub ucListaSOLIC_OIP_TRANS1_Editando(ByVal ID_OIP_TRANS As Int32) Handles ucListaSOLIC_OIP_TRANS1.Editando
        Me.InicializarDetalle(ID_OIP_TRANS)
        Me.ucVistaDetalleSOLIC_OIP_TRANS1.ID_OIP_TRANS = ID_OIP_TRANS
    End Sub

    Private Sub ucVistaDetalleSOLIC_OIP_TRANS1_ErrorEvent(ByVal errorMessage As String) Handles ucVistaDetalleSOLIC_OIP_TRANS1.ErrorEvent
        'Mostrar mensaje de error contenido en errorMessage
        Me.AsignarMensaje(errorMessage, True, True)
    End Sub

    'Private Sub Buscar()
    '    Dim CORR_OPI As Integer = -1
    '    Dim CODIPROVEE As String = ""
    '    Dim CODISOCIO As String = ""
    '    Dim FECHA_SOLIC As DateTime = Nothing
    '    Dim FECHA_APLICA As DateTime = Nothing

    '    If txtCORR_OPI.Text <> "" Then CORR_OPI = CInt(txtCORR_OPI.Value)
    '    If Me.txtCODIPROVEE.Text <> "" Then CODIPROVEE = Utilerias.FormatoCODIPROVEE(CInt(Me.txtCODIPROVEE.Text))
    '    If Me.txtCODISOCIO.Text <> "" Then CODISOCIO = Utilerias.FormatoCODISOCIO(CInt(Me.txtCODISOCIO.Text))
    '    If Me.dteFECHA_SOLIC.Value IsNot Nothing AndAlso IsDate(Me.dteFECHA_SOLIC.Value) Then FECHA_SOLIC = Me.dteFECHA_SOLIC.Date

    '    Me.ucListaSOLIC_OIP_TRANS1.CargarDatosPoCriterios(Me.cbxZAFRA.Value, CORR_OPI, CODIPROVEE, CODISOCIO, Me.txtNOMBRE_PROVEEDOR.Text, FECHA_SOLIC)
    'End Sub

    Private Sub Buscar()
        Me.ucListaSOLIC_OIP_TRANS1.CargarDatos()
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        Select Case CommandName
            Case "Buscar"
                Me.Buscar()

            Case "Agregar"
                Me.InicializarDetalle()
                Me.ucVistaDetalleSOLIC_OIP_TRANS1.LimpiarControles()
                Me.ucVistaDetalleSOLIC_OIP_TRANS1.ID_OIP_TRANS = 0

            Case "Exportar"
                Me.ucListaSOLIC_OIP_TRANS1.ExportarExcel()

            Case "Guardar"
                Dim sError As String
                sError = Me.ucVistaDetalleSOLIC_OIP_TRANS1.Actualizar()
                If sError <> "" Then
                    AsignarMensaje(sError, True, False)
                    Return
                End If
                AsignarMensaje("", True, False)
                AsignarMensaje("La OIP se guardo con exito.", False, True, True)
                Me.ucListaSOLIC_OIP_TRANS1.DataBind()
                Me.ucVistaDetalleSOLIC_OIP_TRANS1.LimpiarControles()
                Me.ucVistaDetalleSOLIC_OIP_TRANS1.ID_OIP_TRANS = 0
                Me.Buscar()
                Me.InicializarLista()
                Return

            Case "Aceptar"
                Dim sError As String
                sError = Me.ucVistaDetalleSOLIC_OIP_TRANS1.AceptarOIP()
                If sError <> "" Then
                    AsignarMensaje(sError, True, False)
                    Return
                End If
                AsignarMensaje("", True, False)
                AsignarMensaje("La OIP ha sido aceptada.", False, True, True)
                Me.Buscar()
                Me.InicializarLista()
                Return

            Case "GuardarCerrar"
                Dim sError As String = ""
                sError = Me.ucVistaDetalleSOLIC_OIP_TRANS1.Actualizar()
                If sError <> "" Then
                    AsignarMensaje(sError, True, False)
                    Return
                End If
                Dim strscript As String = "<script language=javascript>window.top.close();</script>"
                If Not Page.ClientScript.IsStartupScriptRegistered("clientScript") Then
                    Page.ClientScript.RegisterStartupScript(Page.GetType(), "clientScript", strscript)
                End If

            Case "Cancelar"
                AsignarMensaje("", True, False)
                Me.InicializarLista()
        End Select
    End Sub


End Class
