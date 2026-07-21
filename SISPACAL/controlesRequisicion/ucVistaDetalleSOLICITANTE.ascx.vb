Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetalleSOLICITANTE
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla SOLICITANTE
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	08/05/2015	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleSOLICITANTE
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_SOLICITANTE As Int32
    Public Property ID_SOLICITANTE() As Int32
        Get
            Return Me.txtID_SOLICITANTE.Text
        End Get
        Set(ByVal Value As Int32)
            Me._ID_SOLICITANTE = Value
            Me.txtID_SOLICITANTE.Text = CStr(Value)
            If Me._ID_SOLICITANTE > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property CODIGO() As String
        Get
            Return Me.txtCODIGO.Text
        End Get
        Set(ByVal value As String)
            Me.txtCODIGO.Text = value.ToString()
        End Set
    End Property

    Public Property NOMBRE_SOLICITANTE() As String
        Get
            Return Me.txtNOMBRE_SOLICITANTE.Text
        End Get
        Set(ByVal value As String)
            Me.txtNOMBRE_SOLICITANTE.Text = value.ToString()
        End Set
    End Property

    Public Property VerID_SOLICITANTE() As Boolean
        Get
            Return Me.trID_SOLICITANTE.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_SOLICITANTE.Visible = value
        End Set
    End Property

    Public Property VerCODIGO() As Boolean
        Get
            Return Me.trCODIGO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCODIGO.Visible = value
        End Set
    End Property

    Public Property VerNOMBRE_SOLICITANTE() As Boolean
        Get
            Return Me.trNOMBRE_SOLICITANTE.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNOMBRE_SOLICITANTE.Visible = value
        End Set
    End Property

    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cSOLICITANTE
    Private mEntidad As SOLICITANTE
    Public Event ErrorEvent(ByVal errorMessage As String)

    Public ReadOnly Property sError() As String
        Get
            Return _sError
        End Get
    End Property
 
    Public Property Enabled() As Boolean
        Get
            Return Me._Enabled
        End Get
        Set(ByVal Value As Boolean)
            Me._Enabled = Value
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquÃ­ el cÃ³digo de usuario para inicializar la pÃ¡gina
        If Not Me.ViewState("nuevo") Is Nothing Then Me._nuevo = Me.ViewState("nuevo")
        If Not Me.ViewState("ID_SOLICITANTE") Is Nothing Then Me._ID_SOLICITANTE = Me.ViewState("ID_SOLICITANTE")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla SOLICITANTE
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	08/05/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New SOLICITANTE
        mEntidad.ID_SOLICITANTE = ID_SOLICITANTE
 
        If mComponente.ObtenerSOLICITANTE(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_SOLICITANTE.Text = mEntidad.ID_SOLICITANTE.ToString()
        Me.txtCODIGO.Text = mEntidad.CODIGO
        Me.txtNOMBRE_SOLICITANTE.Text = mEntidad.NOMBRE_SOLICITANTE
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	08/05/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.txtCODIGO.Enabled = edicion
        Me.txtNOMBRE_SOLICITANTE.Enabled = edicion
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	08/05/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.txtCODIGO.Text = ""
        Me.txtNOMBRE_SOLICITANTE.Text = ""
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla SOLICITANTE
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	08/05/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        mEntidad = New SOLICITANTE
        If Me._nuevo Then
            mEntidad.ID_SOLICITANTE = 0
        Else
            mEntidad.ID_SOLICITANTE = CInt(Me.txtID_SOLICITANTE.Text)
        End If
        mEntidad.CODIGO = Me.txtCODIGO.Text
        mEntidad.NOMBRE_SOLICITANTE = Me.txtNOMBRE_SOLICITANTE.Text

        If mComponente.ActualizarSOLICITANTE(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_SOLICITANTE.Text = mEntidad.ID_SOLICITANTE.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
