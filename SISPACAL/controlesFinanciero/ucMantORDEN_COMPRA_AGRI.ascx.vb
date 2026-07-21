Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucMantORDEN_COMPRA_AGRI
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para el Mantenimiento de la tabla ORDEN_COMPRA_AGRI
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	10/07/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucMantORDEN_COMPRA_AGRI
    Inherits ucBase

#Region "Inicializaciones Mantenimiento"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Inicializa la Lista de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla ORDEN_COMPRA_AGRI
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/07/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub InicializarLista()
        Me.AsignarMensaje("", True, False)
        Me.ucBarraNavegacion1.VerOpcion("Agregar", True)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", False)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", False)
        Me.ucListaORDEN_COMPRA_AGRI1.Visible = True
        Me.ucVistaDetalleORDEN_COMPRA_AGRI1.Visible = False
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Inicializa el Detalle de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla ORDEN_COMPRA_AGRI
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/07/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub InicializarDetalle(Optional editarEmision As Boolean = False)
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.VerOpcion("Agregar", False)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", True)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", Not editarEmision)
        Me.ucListaORDEN_COMPRA_AGRI1.Visible = False
        Me.ucVistaDetalleORDEN_COMPRA_AGRI1.Visible = True
    End Sub

    Private Sub Inicializar()
        Me.ucBarraNavegacion1.PermitirNavegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False

        Me.ucBarraNavegacion1.CrearOpcion("Agregar", "Nueva Orden de Compra", False, IconoBarra.Agregar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Guardar", "Guardar", False, IconoBarra.Guardar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Cancelar", "Cancelar", False, IconoBarra.Cancelar, "", "", True)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", False)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", False)
        Me.ucBarraNavegacion1.CargarOpciones()
    End Sub
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla ORDEN_COMPRA_AGRI
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/07/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Try
            Return Me.CargarORDEN_COMPRA_AGRI()
        Catch ex As Exception
            Return -1
        End Try
        Return 1
    End Function

    Private Function CargarORDEN_COMPRA_AGRI() As Integer
        If Me.ucListaORDEN_COMPRA_AGRI1.CargarDatos() <> 1 Then Return -1
        Return 1
    End Function

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquÃ­ el cÃ³digo de usuario para inicializar la pÃ¡gina
        If Not IsPostBack Then
            Me.Inicializar()
            Me.InicializarLista()
        End If
    End Sub


    Protected Sub ucListaORDEN_COMPRA_AGRI1_Editando(ByVal ID_ORDEN As Int32) Handles ucListaORDEN_COMPRA_AGRI1.Editando
        Me.InicializarDetalle(True)
        Me.ucVistaDetalleORDEN_COMPRA_AGRI1.ID_ORDEN = ID_ORDEN
    End Sub

    Private Sub ucVistaDetalleORDEN_COMPRA_AGRI1_ErrorEvent(ByVal errorMessage As String) Handles ucVistaDetalleORDEN_COMPRA_AGRI1.ErrorEvent
        'Mostrar mensaje de error contenido en errorMessage
        Me.AsignarMensaje(errorMessage, True, True)
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        Select Case CommandName

            Case "Agregar"
                Me.ucVistaDetalleORDEN_COMPRA_AGRI1.LimpiarControles()
                Me.ucVistaDetalleORDEN_COMPRA_AGRI1.ID_ORDEN = 0
                Me.InicializarDetalle()

            Case "Guardar"
                Dim lRet As String

                lRet = Me.ucVistaDetalleORDEN_COMPRA_AGRI1.Actualizar
                If lRet <> "" Then
                    Me.AsignarMensaje(lRet, True, False)
                    Exit Sub
                End If
                Me.ucVistaDetalleORDEN_COMPRA_AGRI1.LimpiarControles()
                Me.ucVistaDetalleORDEN_COMPRA_AGRI1.ID_ORDEN = 0
                Me.InicializarLista()
                Me.ucListaORDEN_COMPRA_AGRI1.DataBind()

                Me.AsignarMensaje("", True, False)

            Case "Cancelar"
                Me.AsignarMensaje("", True, False)
                Me.ucVistaDetalleORDEN_COMPRA_AGRI1.LimpiarControles()
                Me.ucVistaDetalleORDEN_COMPRA_AGRI1.ID_ORDEN = 0
                Me.InicializarLista()
                Me.ucListaORDEN_COMPRA_AGRI1.DataBind()
        End Select
    End Sub
End Class
