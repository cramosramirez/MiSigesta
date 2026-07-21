Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucMantSOLIC_ENCA_TRANS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para el Mantenimiento de la tabla SOLIC_ENCA_TRANS
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	23/10/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucMantSOLIC_ENCA_TRANS
    Inherits ucBase

#Region "Inicializaciones Mantenimiento"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Inicializa la Lista de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla SOLIC_ENCA_TRANS
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub InicializarLista()
        Me.lblTitulo.Text = "Mantenimiento de Solicitudes de Insumo por Servicio de Transporte"
        Me.ucBarraNavegacion1.VerOpcion("Buscar", True)
        Me.ucBarraNavegacion1.VerOpcion("Agregar", True)
        Me.ucBarraNavegacion1.VerOpcion("Exportar", True)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", False)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", False)
        Me.ucBarraNavegacion1.VerOpcion("Aceptar", False)
        Me.ucListaSOLIC_ENCA_TRANS1.Visible = True
        Me.ucVistaDetalleSOLIC_ENCA_TRANS1.Visible = False
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Inicializa el Detalle de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla SOLIC_ENCA_TRANS
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub InicializarDetalle(ByVal estado As Int32)
        Me.lblTitulo.Text = "Consulta de Solicitud de Insumo por Servicio de Transporte"
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.VerOpcion("Buscar", False)
        Me.ucBarraNavegacion1.VerOpcion("Agregar", False)
        Me.ucBarraNavegacion1.VerOpcion("Exportar", False)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", estado = -1)
        Me.ucBarraNavegacion1.VerOpcion("Aceptar", estado = 1)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", True)
        Me.ucListaSOLIC_ENCA_TRANS1.Visible = False
        Me.ucVistaDetalleSOLIC_ENCA_TRANS1.Visible = True
    End Sub

    Private Sub Inicializar()
        'Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        Me.ucBarraNavegacion1.PermitirNavegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucBarraNavegacion1.CrearOpcion("Buscar", "Buscar", False, IconoBarra.Buscar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Agregar", "Ingresar nueva Solicitud", False, IconoBarra.Generar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Exportar", "Exportar a Excel", False, IconoBarra.ExportarXlsx, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Cancelar", "Cancelar", False, IconoBarra.Cancelar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Guardar", "Guardar", True, IconoBarra.Guardar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Aceptar", "Aceptar Solicitud", True, IconoBarra.Aplicar, "", "", True)
        Me.ucBarraNavegacion1.CargarOpciones()
        'If lZafra IsNot Nothing Then
        '    Me.cbxZAFRA.Value = lZafra.ID_ZAFRA
        'End If
        Me.CargarDatos()
    End Sub
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla SOLIC_ENCA_TRANS
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Try
            Return Me.CargarSOLIC_ENCA_TRANS()
        Catch ex As Exception
            Return -1
        End Try
        Return 1
    End Function

    Private Function CargarSOLIC_ENCA_TRANS() As Integer
        If Me.ucListaSOLIC_ENCA_TRANS1.CargarDatos() <> 1 Then Return -1
        Return 1
    End Function

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquÃ­ el cÃ³digo de usuario para inicializar la pÃ¡gina
        If Not IsPostBack Then
            Me.Inicializar()
            Me.InicializarLista()
        End If
    End Sub


    Private Sub ucBarraNavegacion1_Guardar(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucBarraNavegacion1.Guardar
        Dim sError As String
        sError = Me.ucVistaDetalleSOLIC_ENCA_TRANS1.Actualizar()
        If sError <> "" Then
            Return
        End If
        Me.InicializarLista()
    End Sub

    Protected Sub ucListaSOLIC_ENCA_TRANS1_Editando(ByVal ID_SOLICITUD As Int32) Handles ucListaSOLIC_ENCA_TRANS1.Editando
        Dim lEntidad As SOLIC_ENCA_TRANS = (New cSOLIC_ENCA_TRANS).ObtenerSOLIC_ENCA_TRANS(ID_SOLICITUD)
        Me.InicializarDetalle(lEntidad.ID_ESTADO_SOLIC)
        Me.ucVistaDetalleSOLIC_ENCA_TRANS1.ID_SOLICITUD = ID_SOLICITUD
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        Select Case CommandName
            'Case "Buscar"
            '    Dim NUM_SOLICITUD As Integer = -1
            '    Dim CODIPROVEE As String = ""
            '    Dim CODISOCIO As String = ""
            '    Dim FECHA_SOLIC As DateTime = Nothing
            '    Dim FECHA_APLICA As DateTime = Nothing

            '    If txtNUM_SOLICITUD.Text <> "" Then NUM_SOLICITUD = CInt(txtNUM_SOLICITUD.Value)
            '    If Me.txtCODIPROVEE.Text <> "" Then CODIPROVEE = Utilerias.FormatoCODIPROVEE(CInt(Me.txtCODIPROVEE.Text))
            '    If Me.txtCODISOCIO.Text <> "" Then CODISOCIO = Utilerias.FormatoCODISOCIO(CInt(Me.txtCODISOCIO.Text))
            '    If Me.dteFECHA_SOLIC.Value IsNot Nothing AndAlso IsDate(Me.dteFECHA_SOLIC.Value) Then FECHA_SOLIC = Me.dteFECHA_SOLIC.Date
            '    If Me.dteFECHA_APLICA.Value IsNot Nothing AndAlso IsDate(Me.dteFECHA_APLICA.Value) Then FECHA_APLICA = Me.dteFECHA_APLICA.Date

            '    Me.ucListaSOLIC_AGRICOLA1.CargarDatosPoCriterios(Me.cbxZAFRA.Value, NUM_SOLICITUD, CODIPROVEE, CODISOCIO, Me.txtNOMBRE_PROVEEDOR.Text, Me.txtNOMBLOTE.Text, FECHA_SOLIC, FECHA_APLICA, cProceso.ObtenerCODIAGRON(Me.ObtenerUsuario))

            Case "Exportar"
                Me.ucListaSOLIC_ENCA_TRANS1.ExportarExcel()

            Case "Agregar"
                Me.InicializarDetalle(-1)
                Me.ucVistaDetalleSOLIC_ENCA_TRANS1.LimpiarControles()
                Me.ucVistaDetalleSOLIC_ENCA_TRANS1.ID_SOLICITUD = 0

            Case "Guardar"
                Dim sError As String
                sError = Me.ucVistaDetalleSOLIC_ENCA_TRANS1.Actualizar()
                If sError <> "" Then
                    AsignarMensaje(sError, True, False)
                    Return
                End If
                AsignarMensaje("", True, False)
                AsignarMensaje("La Solicitud se guardo con exito.", False, True, True)
                Me.ucListaSOLIC_ENCA_TRANS1.DataBind()
                Me.ucVistaDetalleSOLIC_ENCA_TRANS1.LimpiarControles()
                Me.ucVistaDetalleSOLIC_ENCA_TRANS1.ID_SOLICITUD = 0
                Return

            Case "Aceptar"
                Dim sError As String
                sError = Me.ucVistaDetalleSOLIC_ENCA_TRANS1.Aceptar
                If sError <> "" Then
                    AsignarMensaje(sError, True, False)
                    Return
                End If
                AsignarMensaje("", True, False)
                AsignarMensaje("La Solicitud ha sido aceptada.", False, True, True)
                Me.ucListaSOLIC_ENCA_TRANS1.DataBind()
                Me.InicializarLista()
                Return
         
            Case "Cancelar"
                Me.InicializarLista()
        End Select
    End Sub

End Class
