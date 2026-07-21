Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucMantDOCUMENTO_ENTRADA_ENCA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para el Mantenimiento de la tabla DOCUMENTO_ENTRADA_ENCA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	03/07/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucMantDOCUMENTO_ENTRADA_ENCA
    Inherits ucBase

#Region "Inicializaciones Mantenimiento"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Inicializa la Lista de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla DOCUMENTO_ENTRADA_ENCA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/07/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub InicializarLista()
        Me.AsignarMensaje("", True, False)
        Me.ucBarraNavegacion1.VerOpcion("Agregar", True)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", False)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", False)
        Me.ucListaDOCUMENTO_ENTRADA_ENCA1.Visible = True
        Me.ucVistaDetalleDOCUMENTO_ENTRADA_ENCA1.Visible = False
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Inicializa el Detalle de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla DOCUMENTO_ENTRADA_ENCA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/07/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub InicializarDetalle(Optional editarEmision As Boolean = False)
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.VerOpcion("Agregar", False)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", True)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", Not editarEmision)
        Me.ucListaDOCUMENTO_ENTRADA_ENCA1.Visible = False
        Me.ucVistaDetalleDOCUMENTO_ENTRADA_ENCA1.Visible = True
    End Sub

    Private Sub Inicializar()
        Me.ucBarraNavegacion1.PermitirNavegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False

        Me.ucBarraNavegacion1.CrearOpcion("Agregar", "Nuevo Ingreso a Bodega", False, IconoBarra.Generar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Guardar", "Guardar", False, IconoBarra.Guardar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Cancelar", "Cancelar", False, IconoBarra.Cancelar, "", "", True)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", False)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", False)
        Me.ucBarraNavegacion1.CargarOpciones()
    End Sub
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla DOCUMENTO_ENTRADA_ENCA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/07/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Try
            Return Me.CargarDOCUMENTO_ENTRADA_ENCA()
        Catch ex As Exception
            Return -1
        End Try
        Return 1
    End Function

    Private Function CargarDOCUMENTO_ENTRADA_ENCA() As Integer
        If Me.ucListaDOCUMENTO_ENTRADA_ENCA1.CargarDatos() <> 1 Then Return -1
        Return 1
    End Function

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquÃ­ el cÃ³digo de usuario para inicializar la pÃ¡gina
        If Not IsPostBack Then
            Me.Inicializar()
            Me.InicializarLista()
        End If
    End Sub

    Protected Sub ucListaDOCUMENTO_ENTRADA_ENCA1_Editando(ByVal ID_DOCENTRA_ENCA As Int32) Handles ucListaDOCUMENTO_ENTRADA_ENCA1.Editando
        Me.InicializarDetalle(True)
        Me.ucVistaDetalleDOCUMENTO_ENTRADA_ENCA1.ID_DOCENTRA_ENCA = ID_DOCENTRA_ENCA
    End Sub

    Private Sub ucVistaDetalleDOCUMENTO_ENTRADA_ENCA1_ErrorEvent(ByVal errorMessage As String) Handles ucVistaDetalleDOCUMENTO_ENTRADA_ENCA1.ErrorEvent
        'Mostrar mensaje de error contenido en errorMessage
        Me.AsignarMensaje(errorMessage, True, True)
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        Select Case CommandName

            Case "Agregar"
                Me.InicializarDetalle()
                Me.ucVistaDetalleDOCUMENTO_ENTRADA_ENCA1.LimpiarControles()
                Me.ucVistaDetalleDOCUMENTO_ENTRADA_ENCA1.ID_DOCENTRA_ENCA = 0

            Case "Guardar"
                Dim lRet As String

                lRet = Me.ucVistaDetalleDOCUMENTO_ENTRADA_ENCA1.Actualizar
                If lRet <> "" Then
                    Me.AsignarMensaje(lRet, True, False)
                    Exit Sub
                End If
                Me.ucVistaDetalleDOCUMENTO_ENTRADA_ENCA1.LimpiarControles()
                Me.ucVistaDetalleDOCUMENTO_ENTRADA_ENCA1.ID_DOCENTRA_ENCA = 0
                Me.InicializarLista()
                Me.ucListaDOCUMENTO_ENTRADA_ENCA1.DataBind()

                Me.AsignarMensaje("", True, False)

            Case "Cancelar"
                Me.AsignarMensaje("", True, False)
                Me.ucVistaDetalleDOCUMENTO_ENTRADA_ENCA1.LimpiarControles()
                Me.ucVistaDetalleDOCUMENTO_ENTRADA_ENCA1.ID_DOCENTRA_ENCA = 0
                Me.InicializarLista()
                Me.ucListaDOCUMENTO_ENTRADA_ENCA1.DataBind()
        End Select
    End Sub
End Class
