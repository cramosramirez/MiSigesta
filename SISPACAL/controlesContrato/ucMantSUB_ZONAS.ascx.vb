Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucMantSUB_ZONAS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para el Mantenimiento de la tabla SUB_ZONAS
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	26/05/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucMantSUB_ZONAS
    Inherits ucBase

#Region "Inicializaciones Mantenimiento"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Inicializa la Lista de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla SUB_ZONAS
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/05/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub InicializarLista()
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = True
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucBarraNavegacion1.HabilitarEdicion(False)
        Me.ucListaSUB_ZONAS1.Visible = True
        Me.UcVistaDetalleSUB_ZONAS1.Visible = False
        Me.lblZONA.Visible = True
        Me.ddlZONASZONA.Visible = True
        If Me.CargarDatos() <> 1 Then
            Me.AsignarMensaje("Error al Recuperar Lista", True, True)
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Inicializa el Detalle de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla SUB_ZONAS
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
        Me.ucBarraNavegacion1.PermitirEditar = True
        Me.ucBarraNavegacion1.HabilitarEdicion(True)
        Me.ucListaSUB_ZONAS1.Visible = False
        Me.UcVistaDetalleSUB_ZONAS1.Visible = True
        Me.lblZONA.Visible = False
        Me.ddlZONASZONA.Visible = False
    End Sub
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla SUB_ZONAS
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/05/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Try 
            Me.ddlZONASZONA.Recuperar()
            Return Me.CargarSUB_ZONAS()
        Catch ex As Exception 
            Return -1 
        End Try 
        Return 1
    End Function

    Private Function CargarSUB_ZONAS() As Integer
        Me.ucListaSUB_ZONAS1.ZONA = IIf(Me.ddlZONASZONA.SelectedValue = "", 0, Me.ddlZONASZONA.SelectedValue)
        If Me.ucListaSUB_ZONAS1.CargarDatosPorZONAS(Me.ddlZONASZONA.SelectedValue) <> 1 Then Return -1
        Return 1
    End Function

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquÃ­ el cÃ³digo de usuario para inicializar la pÃ¡gina
        If Not IsPostBack Then
            Me.InicializarLista()
        End If
    End Sub

    Private Sub UcBarraNavegacion1_Agregar(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucBarraNavegacion1.Agregar
        Me.InicializarDetalle()
        Me.UcVistaDetalleSUB_ZONAS1.LimpiarControles()
        Me.ucVistaDetalleSUB_ZONAS1.ZONA = Me.ddlZONASZONA.SelectedValue
        Me.ucVistaDetalleSUB_ZONAS1.SUB_ZONA = 0
    End Sub

    Private Sub ucBarraNavegacion1_Cancelar(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucBarraNavegacion1.Cancelar
        Me.InicializarLista()
    End Sub

    Private Sub ucBarraNavegacion1_Guardar(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucBarraNavegacion1.Guardar
        Dim sError As String
        sError = Me.UcVistaDetalleSUB_ZONAS1.Actualizar()
        If sError <> "" Then
            Return
        End If
        Me.InicializarLista()
    End Sub

    Protected Sub ucListaSUB_ZONAS1_Editando(ByVal ZONA As String, ByVal SUB_ZONA As String) Handles ucListaSUB_ZONAS1.Editando
        Me.InicializarDetalle()
        Me.UcVistaDetalleSUB_ZONAS1.ZONA = ZONA
        Me.UcVistaDetalleSUB_ZONAS1.SUB_ZONA = SUB_ZONA
    End Sub

    Private Sub ucVistaDetalleSUB_ZONAS1_ErrorEvent(ByVal errorMessage As String) Handles UcVistaDetalleSUB_ZONAS1.ErrorEvent
        'Mostrar mensaje de error contenido en errorMessage
        Me.AsignarMensaje(errorMessage, True, True)
    End Sub

    Protected Sub ddlZONASZONA_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlZONASZONA.SelectedIndexChanged
        Me.CargarSUB_ZONAS()
    End Sub

End Class
