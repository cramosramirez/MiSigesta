Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetalleBANCOS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla BANCOS
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	15/11/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleBANCOS
    Inherits ucBase
 
#Region"Propiedades"

    Private _CODIBANCO As Int32
    Public Property CODIBANCO() As Int32
        Get
            Return Me.txtCODIBANCO.Text
        End Get
        Set(ByVal Value As Int32)
            Me._CODIBANCO = Value
            Me.txtCODIBANCO.Text = CStr(Value)
            If Me._CODIBANCO > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property NOMBRE_BANCO() As String
        Get
            Return Me.txtNOMBRE_BANCO.Text
        End Get
        Set(ByVal value As String)
            Me.txtNOMBRE_BANCO.Text = value.ToString()
        End Set
    End Property

    Public Property USER_CREA() As Int32
        Get
            If Me.txtUSER_CREA.Text ="" Then Return -1
            Return CInt(Me.txtUSER_CREA.Text)
        End Get
        Set(ByVal value As Int32)
            Me.txtUSER_CREA.Text = value.ToString()
        End Set
    End Property

    Public Property FECHA_CREA() As DateTime
        Get
            Return Me.txtFECHA_CREA.Text
        End Get
        Set(ByVal value As DateTime)
            Me.txtFECHA_CREA.Text = value.ToString("dd/MM/yyyy")
        End Set
    End Property

    Public Property USER_ACT() As Int32
        Get
            If Me.txtUSER_ACT.Text ="" Then Return -1
            Return CInt(Me.txtUSER_ACT.Text)
        End Get
        Set(ByVal value As Int32)
            Me.txtUSER_ACT.Text = value.ToString()
        End Set
    End Property

    Public Property FECHA_ACT() As DateTime
        Get
            Return Me.txtFECHA_ACT.Text
        End Get
        Set(ByVal value As DateTime)
            Me.txtFECHA_ACT.Text = value.ToString("dd/MM/yyyy")
        End Set
    End Property

    Public Property VerCODIBANCO() As Boolean
        Get
            Return Me.trCODIBANCO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCODIBANCO.Visible = value
        End Set
    End Property

    Public Property VerNOMBRE_BANCO() As Boolean
        Get
            Return Me.trNOMBRE_BANCO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNOMBRE_BANCO.Visible = value
        End Set
    End Property

    Public Property VerUSER_CREA() As Boolean
        Get
            Return Me.trUSER_CREA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trUSER_CREA.Visible = value
        End Set
    End Property

    Public Property VerFECHA_CREA() As Boolean
        Get
            Return Me.trFECHA_CREA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFECHA_CREA.Visible = value
        End Set
    End Property

    Public Property VerUSER_ACT() As Boolean
        Get
            Return Me.trUSER_ACT.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trUSER_ACT.Visible = value
        End Set
    End Property

    Public Property VerFECHA_ACT() As Boolean
        Get
            Return Me.trFECHA_ACT.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFECHA_ACT.Visible = value
        End Set
    End Property

    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cBANCOS
    Private mEntidad As BANCOS
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
        If Not Me.ViewState("CODIBANCO") Is Nothing Then Me._CODIBANCO = Me.ViewState("CODIBANCO")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla BANCOS
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	15/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New BANCOS
        mEntidad.CODIBANCO = CODIBANCO
 
        If mComponente.ObtenerBANCOS(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtCODIBANCO.Text = mEntidad.CODIBANCO.ToString()
        Me.txtNOMBRE_BANCO.Text = mEntidad.NOMBRE_BANCO
        Me.txtUSER_CREA.Text = mEntidad.USER_CREA
        Me.txtFECHA_CREA.Text = IIf(Not mEntidad.FECHA_CREA = Nothing, Format(mEntidad.FECHA_CREA, "dd/MM/yyyy"), "")
        Me.txtUSER_ACT.Text = mEntidad.USER_ACT
        Me.txtFECHA_ACT.Text = IIf(Not mEntidad.FECHA_ACT = Nothing, Format(mEntidad.FECHA_ACT, "dd/MM/yyyy"), "")
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	15/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.txtNOMBRE_BANCO.Enabled = edicion
        Me.txtUSER_CREA.Enabled = edicion
        Me.txtFECHA_CREA.Enabled = edicion
        Me.txtUSER_ACT.Enabled = edicion
        Me.txtFECHA_ACT.Enabled = edicion
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	15/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.txtNOMBRE_BANCO.Text = ""
        Me.txtUSER_CREA.Text = ""
        Me.txtFECHA_CREA.Text = ""
        Me.txtUSER_ACT.Text = ""
        Me.txtFECHA_ACT.Text = ""
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla BANCOS
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	15/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        mEntidad = New BANCOS
        If Me._nuevo Then
            mEntidad.CODIBANCO = 0
            mEntidad.USER_CREA = -1
            mEntidad.FECHA_CREA = Today
            mEntidad.USER_ACT = -1
            mEntidad.FECHA_ACT = Today
        Else
            mEntidad = (New cBANCOS).ObtenerBANCOS(CInt(Me.txtCODIBANCO.Text))
            mEntidad.USER_ACT = -1
            mEntidad.FECHA_ACT = Today
        End If
        mEntidad.NOMBRE_BANCO = Me.txtNOMBRE_BANCO.Text.ToUpper
        If mComponente.ActualizarBANCOS(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtCODIBANCO.Text = mEntidad.CODIBANCO.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
