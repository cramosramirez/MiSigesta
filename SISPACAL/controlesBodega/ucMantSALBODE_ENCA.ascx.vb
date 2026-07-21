Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucMantSALBODE_ENCA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para el Mantenimiento de la tabla SALBODE_ENCA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	18/07/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucMantSALBODE_ENCA
    Inherits ucBase

#Region "Inicializaciones Mantenimiento"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Inicializa la Lista de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla SALBODE_ENCA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/07/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub InicializarLista()
        Me.lblTitulo.Text = "Solicitud de Retiro de productos en consignación"
        Me.AsignarMensaje("", True, False)
        Me.ucBarraNavegacion1.VerOpcion("Agregar", False)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", False)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", False)
        Me.ucListaSALBODE_ENCA1.Visible = True
        Me.ucVistaDetalleSALBODE_ENCA1.Visible = False
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Inicializa el Detalle de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla SALBODE_ENCA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/07/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub InicializarDetalle(Optional editarEmision As Boolean = False)
        Me.lblTitulo.Text = "Registro de entregas de productos en consignación"
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.VerOpcion("Agregar", False)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", True)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", Not editarEmision)
        Me.ucListaSALBODE_ENCA1.Visible = False
        Me.ucVistaDetalleSALBODE_ENCA1.Visible = True
    End Sub

    Private Sub Inicializar()
        Me.ucBarraNavegacion1.PermitirNavegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False

        Me.ucBarraNavegacion1.CrearOpcion("Agregar", "Nuevo Retiro", False, IconoBarra.Agregar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Guardar", "Guardar producto entregado", False, IconoBarra.Guardar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Cancelar", "Cancelar", False, IconoBarra.Cancelar, "", "", True)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", False)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", False)
        Me.ucBarraNavegacion1.CargarOpciones()
    End Sub
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla SALBODE_ENCA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/07/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Try
            Return Me.CargarSALBODE_ENCA()
        Catch ex As Exception
            Return -1
        End Try
        Return 1
    End Function

    Private Function CargarSALBODE_ENCA() As Integer
        If Me.ucListaSALBODE_ENCA1.CargarDatos() <> 1 Then Return -1
        Return 1
    End Function

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquÃ­ el cÃ³digo de usuario para inicializar la pÃ¡gina
        If Not IsPostBack Then
            Me.Inicializar()
            Me.InicializarLista()
        End If
    End Sub

    Protected Sub ucListaSALBODE_ENCA1_Editando(ID_SALBODE_ENCA As Integer) Handles ucListaSALBODE_ENCA1.Editando
        Me.InicializarDetalle()
        Me.ucVistaDetalleSALBODE_ENCA1.ID_SALBODE_ENCA = ID_SALBODE_ENCA
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        Select Case CommandName

            Case "Agregar"
                Me.ucVistaDetalleSALBODE_ENCA1.LimpiarControles()
                Me.ucVistaDetalleSALBODE_ENCA1.ID_SALBODE_ENCA = 0
                Me.InicializarDetalle()

            Case "Guardar"
                Dim lRet As String

                lRet = Me.ucVistaDetalleSALBODE_ENCA1.Actualizar
                If lRet <> "" Then
                    Me.AsignarMensaje(lRet, True, False)
                    Exit Sub
                End If
                Me.ucVistaDetalleSALBODE_ENCA1.LimpiarSesion()
                Me.ucVistaDetalleSALBODE_ENCA1.LimpiarControles()
                Me.ucVistaDetalleSALBODE_ENCA1.ID_SALBODE_ENCA = 0
                Me.InicializarLista()
                Me.ucListaSALBODE_ENCA1.DataBind()
                Me.AsignarMensaje("Las entregas de producto se registraron correctamente", False, True, True)

                Me.AsignarMensaje("", True, False)

            Case "Cancelar"
                Me.AsignarMensaje("", True, False)
                Me.ucVistaDetalleSALBODE_ENCA1.LimpiarSesion()
                Me.ucVistaDetalleSALBODE_ENCA1.LimpiarControles()
                Me.ucVistaDetalleSALBODE_ENCA1.ID_SALBODE_ENCA = 0
                Me.InicializarLista()
                Me.ucListaSALBODE_ENCA1.DataBind()
        End Select
    End Sub
End Class
