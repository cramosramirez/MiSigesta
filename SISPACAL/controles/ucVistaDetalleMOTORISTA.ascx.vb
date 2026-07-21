Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetalleMOTORISTA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla MOTORISTA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	10/11/2015	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleMOTORISTA
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_MOTORISTA As Int32
    Public Property ID_MOTORISTA() As Int32
        Get
            Return Me.txtID_MOTORISTA.Text
        End Get
        Set(ByVal Value As Int32)
            Me._ID_MOTORISTA = Value
            Me.txtID_MOTORISTA.Text = CStr(Value)
            If Me._ID_MOTORISTA > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property NIT() As String
        Get
            Return Me.txtNIT.Text
        End Get
        Set(ByVal value As String)
            Me.txtNIT.Text = value.ToString()
        End Set
    End Property

    Public Property NOMBRES() As String
        Get
            Return Me.txtNOMBRES.Text
        End Get
        Set(ByVal value As String)
            Me.txtNOMBRES.Text = value.ToString()
        End Set
    End Property

    Public Property APELLIDOS() As String
        Get
            Return Me.txtAPELLIDOS.Text
        End Get
        Set(ByVal value As String)
            Me.txtAPELLIDOS.Text = value.ToString()
        End Set
    End Property


    Public Property DUI() As String
        Get
            Return Me.txtDUI.Text
        End Get
        Set(ByVal value As String)
            Me.txtDUI.Text = value.ToString()
        End Set
    End Property

    Public Property LICENCIA() As String
        Get
            Return Me.txtLICENCIA.Text
        End Get
        Set(ByVal value As String)
            Me.txtLICENCIA.Text = value.ToString()
        End Set
    End Property

    Public Property ACTIVO() As Boolean
        Get
            Return Me.chkActivo.Checked
        End Get
        Set(ByVal value As Boolean)
            Me.chkActivo.Checked = value
        End Set
    End Property


    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cMOTORISTA
    Private mEntidad As MOTORISTA
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
        If Not Me.ViewState("ID_MOTORISTA") Is Nothing Then Me._ID_MOTORISTA = Me.ViewState("ID_MOTORISTA")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla MOTORISTA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/11/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New MOTORISTA
        mEntidad.ID_MOTORISTA = ID_MOTORISTA
 
        If mComponente.ObtenerMOTORISTA(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_MOTORISTA.Text = mEntidad.ID_MOTORISTA.ToString()
        Me.txtNIT.Text = mEntidad.NIT
        Me.txtNOMBRES.Text = mEntidad.NOMBRES.ToUpper
        Me.txtAPELLIDOS.Text = mEntidad.APELLIDOS.ToUpper
        Me.txtDUI.Text = mEntidad.DUI
        Me.txtLICENCIA.Text = mEntidad.LICENCIA
        Me.chkActivo.Checked = mEntidad.ACTIVO
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/11/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.txtID_MOTORISTA.ClientEnabled = False
        Me.txtNIT.ClientEnabled = edicion
        Me.txtNOMBRES.ClientEnabled = edicion
        Me.txtAPELLIDOS.ClientEnabled = edicion
        Me.txtDUI.ClientEnabled = edicion
        Me.txtLICENCIA.ClientEnabled = edicion
        Me.chkActivo.ClientEnabled = edicion
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/11/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.txtNIT.Text = ""
        Me.txtNOMBRES.Text = ""
        Me.txtAPELLIDOS.Text = ""
        Me.txtDUI.Text = ""
        Me.txtLICENCIA.Text = ""
        Me.chkActivo.Checked = False
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla MOTORISTA
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/11/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        mEntidad = New MOTORISTA
        If Me._nuevo Then
            mEntidad.ID_MOTORISTA = 0
            mEntidad.USUARIO_CREA = Me.ObtenerUsuario
            mEntidad.FECHA_CREA = cFechaHora.ObtenerFechaHora
        Else
            mEntidad = (New cMOTORISTA).ObtenerMOTORISTA(CInt(Me.txtID_MOTORISTA.Text))
        End If

        mEntidad.NIT = IIf(Me.txtNIT.Text.Trim() = "", " ", Me.txtNIT.Text.Trim())
        mEntidad.NOMBRES = Me.txtNOMBRES.Text.ToUpper
        mEntidad.APELLIDOS = Me.txtAPELLIDOS.Text.ToUpper
        mEntidad.DUI = Me.txtDUI.Text
        mEntidad.LICENCIA = Me.txtLICENCIA.Text
        mEntidad.ACTIVO = Me.chkActivo.Checked

        mEntidad.USUARIO_ACT = Me.ObtenerUsuario
        mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora

        If mComponente.ActualizarMOTORISTA(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_MOTORISTA.Text = mEntidad.ID_MOTORISTA.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
