Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucMantMEMBRE_GREMIAL
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para el Mantenimiento de la tabla MEMBRE_GREMIAL
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	28/06/2015	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucMantMEMBRE_GREMIAL
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
        Me.Label1.Text = "Mantenimiento de Membresía por Gremial"
        Me.ucBarraNavegacion1.VerOpcion("Buscar", True)
        Me.ucBarraNavegacion1.VerOpcion("Agregar", True)
        Me.ucBarraNavegacion1.VerOpcion("Exportar", True)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", False)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", False)
        Me.ucBarraNavegacion1.VerOpcion("GuardarCerrar", False)
        Me.ucCriteriosMembreGremialLayout.Visible = True
        Me.ucListaMEMBRE_GREMIAL1.Visible = True
        Me.ucVistaDetalleMEMBRE_GREMIAL1.Visible = False
        Me.CargarDatos()
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
    Private Sub InicializarDetalle()
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.VerOpcion("Buscar", False)
        Me.ucBarraNavegacion1.VerOpcion("Agregar", False)
        Me.ucBarraNavegacion1.VerOpcion("Exportar", False)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", True)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", True)
        Me.ucBarraNavegacion1.VerOpcion("GuardarCerrar", False)
        Me.ucCriteriosMembreGremialLayout.Visible = False
        Me.ucListaMEMBRE_GREMIAL1.Visible = False
        Me.ucVistaDetalleMEMBRE_GREMIAL1.Visible = True
    End Sub

    Private Sub InicializarDetalleVista()
        Me.AsignarMensaje("", True, False)
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirSalir = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.VerOpcion("Buscar", False)
        Me.ucBarraNavegacion1.VerOpcion("Agregar", False)
        Me.ucBarraNavegacion1.VerOpcion("Exportar", False)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", False)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", False)
        Me.ucBarraNavegacion1.VerOpcion("GuardarCerrar", True)
        Me.ucCriteriosMembreGremialLayout.Visible = False
        Me.ucListaMEMBRE_GREMIAL1.Visible = False
        Me.ucVistaDetalleMEMBRE_GREMIAL1.Visible = True
    End Sub

    Private Sub Inicializar()
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        Me.ucBarraNavegacion1.PermitirNavegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucBarraNavegacion1.CrearOpcion("Buscar", "Buscar", False, IconoBarra.Buscar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Agregar", "Ingresar nueva Membresia", False, IconoBarra.Generar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Exportar", "Exportar a Excel", False, IconoBarra.ExportarXlsx, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Cancelar", "Cancelar", False, IconoBarra.Cancelar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Guardar", "Guardar", True, IconoBarra.Guardar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("GuardarCerrar", "Guardar y cerrar", True, IconoBarra.Guardar, "", "", True)
        Me.ucBarraNavegacion1.CargarOpciones()
        If lZafra IsNot Nothing Then
            Me.cbxZAFRA.Value = lZafra.ID_ZAFRA
        End If
    End Sub
#End Region



    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla MEMBRE_GREMIAL
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/06/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Try
            Return Me.CargarMEMBRE_GREMIAL()
        Catch ex As Exception
            Return -1
        End Try
        Return 1
    End Function

    Private Function CargarMEMBRE_GREMIAL() As Integer
        Dim CORR_OPI As Integer = -1
        Dim CODIPROVEE As String = ""
        Dim CODISOCIO As String = ""
        Dim FECHA As DateTime = Nothing

        If txtNUM_MEMBRE_GREMIAL.Text <> "" Then CORR_OPI = CInt(txtNUM_MEMBRE_GREMIAL.Value)
        If Me.txtCODIPROVEE.Text <> "" Then CODIPROVEE = Utilerias.FormatoCODIPROVEE(CInt(Me.txtCODIPROVEE.Text))
        If Me.txtCODISOCIO.Text <> "" Then CODISOCIO = Utilerias.FormatoCODISOCIO(CInt(Me.txtCODISOCIO.Text))
        If Me.dteFECHA_MEMBRESIA.Value IsNot Nothing AndAlso IsDate(Me.dteFECHA_MEMBRESIA.Value) Then FECHA = Me.dteFECHA_MEMBRESIA.Date

        Me.ucListaMEMBRE_GREMIAL1.CargarDatosPoCriterios(Me.cbxZAFRA.Value, CORR_OPI, CODIPROVEE, CODISOCIO, Me.txtNOMBRE_PROVEEDOR.Text, FECHA)
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
                    Me.ucVistaDetalleMEMBRE_GREMIAL1.LimpiarControles()
                    Me.ucVistaDetalleMEMBRE_GREMIAL1.ID_MEMBRE_GREMIAL = 0
                End If
            End If
        End If
    End Sub

    Protected Sub ucListaMEMBRE_GREMIAL1_Editando(ByVal ID_MEMBRE_GREMIAL As Int32) Handles ucListaMEMBRE_GREMIAL1.Editando
        Me.InicializarDetalle()
        Me.ucVistaDetalleMEMBRE_GREMIAL1.ID_MEMBRE_GREMIAL = ID_MEMBRE_GREMIAL
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        Select Case CommandName
            Case "Buscar"
                Me.CargarMEMBRE_GREMIAL()

            Case "Agregar"
                Me.InicializarDetalle()
                Me.ucVistaDetalleMEMBRE_GREMIAL1.LimpiarControles()
                Me.ucVistaDetalleMEMBRE_GREMIAL1.ID_MEMBRE_GREMIAL = 0

            Case "Exportar"
                Me.ucListaMEMBRE_GREMIAL1.ExportarExcel()

            Case "Guardar"
                Dim sError As String
                sError = Me.ucVistaDetalleMEMBRE_GREMIAL1.Actualizar()
                If sError <> "" Then
                    AsignarMensaje(sError, True, False)
                    Return
                End If
                AsignarMensaje("", True, False)
                AsignarMensaje("El cargo por membresia se guardo con exito.", False, True, True)
                Me.ucListaMEMBRE_GREMIAL1.DataBind()
                Me.ucVistaDetalleMEMBRE_GREMIAL1.LimpiarControles()
                Me.ucVistaDetalleMEMBRE_GREMIAL1.ID_MEMBRE_GREMIAL = 0
                Me.InicializarLista()
                Return

            Case "GuardarCerrar"
                Dim sError As String = ""
                sError = Me.ucVistaDetalleMEMBRE_GREMIAL1.Actualizar()
                If sError <> "" Then
                    AsignarMensaje(sError, True, False)
                    Return
                End If
                Dim strscript As String = "<script language=javascript>window.top.close();</script>"
                If Not Page.ClientScript.IsStartupScriptRegistered("clientScript") Then
                    Page.ClientScript.RegisterStartupScript(Page.GetType(), "clientScript", strscript)
                End If

            Case "Cancelar"
                Me.InicializarLista()
        End Select
    End Sub
End Class
