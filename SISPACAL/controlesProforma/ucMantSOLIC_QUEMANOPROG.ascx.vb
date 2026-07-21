Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucMantSOLIC_QUEMANOPROG
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para el Mantenimiento de la tabla SOLIC_QUEMANOPROG
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	16/01/2015	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucMantSOLIC_QUEMANOPROG
    Inherits ucBase

#Region "Inicializaciones Mantenimiento"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Inicializa la Lista de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla SOLIC_QUEMANOPROG
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/01/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub InicializarLista()
        Me.AsignarMensaje("", True, False)
        Me.Label1.Text = "Mantenimiento de Solicitudes de Quema no programada"
        Me.ucBarraNavegacion1.VerOpcion("Buscar", True)
        Me.ucBarraNavegacion1.VerOpcion("Agregar", True)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", False)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", False)
        Me.ucCriteriosManttoSolicitudQuemaNoProgLayout.Visible = True
        Me.ucListaSOLIC_QUEMANOPROG1.Visible = True
        Me.ucVistaDetalleSOLIC_QUEMANOPROG1.Visible = False
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Inicializa el Detalle de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla SOLIC_QUEMANOPROG
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/01/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub InicializarDetalle()
        Me.Label1.Text = "Ingresando/Modificando Solicitud de Quema no programada"
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.VerOpcion("Buscar", False)
        Me.ucBarraNavegacion1.VerOpcion("Agregar", False)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", True)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", True)
        Me.ucCriteriosManttoSolicitudQuemaNoProgLayout.Visible = False
        Me.ucListaSOLIC_QUEMANOPROG1.Visible = False
        Me.ucVistaDetalleSOLIC_QUEMANOPROG1.Visible = True
    End Sub
#End Region



    Private Sub Inicializar()
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        Dim codiAgron As String = cProceso.ObtenerCODIAGRON(Me.ObtenerUsuario)
        Me.ucBarraNavegacion1.PermitirNavegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucBarraNavegacion1.CrearOpcion("Buscar", "Buscar", False, IconoBarra.Buscar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Agregar", "Ingresar nueva solicitud", False, IconoBarra.Generar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Cancelar", "Cancelar", False, IconoBarra.Cancelar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Guardar", "Guardar", True, IconoBarra.Guardar, "", "", True)
        Me.ucBarraNavegacion1.CargarOpciones()
        If lZafra IsNot Nothing Then
            Me.cbxZAFRA.Value = lZafra.ID_ZAFRA
        End If
    End Sub

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquÃ­ el cÃ³digo de usuario para inicializar la pÃ¡gina
        If Not IsPostBack Then
            Me.Inicializar()
            Me.InicializarLista()
        End If
    End Sub

    Protected Sub ucListaSOLIC_QUEMANOPROG1_Editando(ByVal ID_SOLIC_QUEMANOPROG As Int32) Handles ucListaSOLIC_QUEMANOPROG1.Editando
        Me.InicializarDetalle()
        Me.ucVistaDetalleSOLIC_QUEMANOPROG1.ID_SOLIC_QUEMANOPROG = ID_SOLIC_QUEMANOPROG
    End Sub

    Private Sub ucVistaDetalleSOLIC_QUEMANOPROG1_ErrorEvent(ByVal errorMessage As String) Handles ucVistaDetalleSOLIC_QUEMANOPROG1.ErrorEvent
        'Mostrar mensaje de error contenido en errorMessage
        Me.AsignarMensaje(errorMessage, True, True)
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        Select Case CommandName
            Case "Buscar"
                Dim ID_ZAFRA As Int32 = -1
                Dim FECHA_INI As Object = Nothing
                Dim FECHA_FIN As Object = Nothing
                Dim CODIPROVEE As String = ""
                Dim CODISOCIO As String = ""

                If Me.cbxZAFRA.Value IsNot Nothing Then ID_ZAFRA = cbxZAFRA.Value
                If Me.speCODIPROVEE.Text <> "" Then CODIPROVEE = Utilerias.FormatoCODIPROVEE(CInt(Me.speCODIPROVEE.Text))
                If Me.speCODISOCIO.Text <> "" Then CODISOCIO = Utilerias.FormatoCODISOCIO(CInt(Me.speCODISOCIO.Text))

                Me.ucListaSOLIC_QUEMANOPROG1.CargarDatosPorCriterios(ID_ZAFRA, Me.cbxZONA.Value, CODIPROVEE, CODISOCIO, Me.txtNOMBRE_PROVEEDOR.Text, Me.txtNOMBLOTE.Text)

            Case "Agregar"
                Me.InicializarDetalle()
                Me.ucVistaDetalleSOLIC_QUEMANOPROG1.LimpiarControles()
                Me.ucVistaDetalleSOLIC_QUEMANOPROG1.ID_SOLIC_QUEMANOPROG = 0

            Case "Guardar"
                Dim sError As String = ""

                sError = Me.ucVistaDetalleSOLIC_QUEMANOPROG1.Actualizar()
                If sError <> "" Then
                    AsignarMensaje(sError, True, False)
                    Return
                End If
                AsignarMensaje("", True, False)
                Me.InicializarLista()
                Me.ucListaSOLIC_QUEMANOPROG1.DataBind()

            Case "Cancelar"
                Me.InicializarLista()
        End Select
    End Sub
End Class
