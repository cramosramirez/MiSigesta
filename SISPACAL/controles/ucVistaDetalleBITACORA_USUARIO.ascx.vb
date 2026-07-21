Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetalleBITACORA_USUARIO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla BITACORA_USUARIO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	31/08/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleBITACORA_USUARIO
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_BITACORA As Int32
    Public Property ID_BITACORA() As Int32
        Get
            Return Me.txtID_BITACORA.Text
        End Get
        Set(ByVal Value As Int32)
            Me._ID_BITACORA = Value
            Me.txtID_BITACORA.Text = CStr(Value)
            If Me._ID_BITACORA > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property USUARIO() As String
        Get
            Return Me.ddlUSUARIOUSUARIO.SelectedValue
        End Get
        Set(ByVal value As String)
            If Not Me.ddlUSUARIOUSUARIO.Items.FindByValue(value) Is Nothing Then
                Me.ddlUSUARIOUSUARIO.SelectedValue = value
            End If
        End Set
    End Property

    Public Property FECHA_ENTRADA() As DateTime
        Get
            Return Me.txtFECHA_ENTRADA.Text
        End Get
        Set(ByVal value As DateTime)
            Me.txtFECHA_ENTRADA.Text = value.ToString("dd/MM/yyyy")
        End Set
    End Property

    Public Property FECHA_SALIDA() As DateTime
        Get
            Return Me.txtFECHA_SALIDA.Text
        End Get
        Set(ByVal value As DateTime)
            Me.txtFECHA_SALIDA.Text = value.ToString("dd/MM/yyyy")
        End Set
    End Property

    Public Property VerID_BITACORA() As Boolean
        Get
            Return Me.trID_BITACORA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_BITACORA.Visible = value
        End Set
    End Property

    Public Property VerUSUARIO() As Boolean
        Get
            Return Me.trUSUARIO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trUSUARIO.Visible = value
        End Set
    End Property

    Public Property VerFECHA_ENTRADA() As Boolean
        Get
            Return Me.trFECHA_ENTRADA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFECHA_ENTRADA.Visible = value
        End Set
    End Property

    Public Property VerFECHA_SALIDA() As Boolean
        Get
            Return Me.trFECHA_SALIDA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFECHA_SALIDA.Visible = value
        End Set
    End Property

    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cBITACORA_USUARIO
    Private mEntidad As BITACORA_USUARIO
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
        If Not Me.ViewState("ID_BITACORA") Is Nothing Then Me._ID_BITACORA = Me.ViewState("ID_BITACORA")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla BITACORA_USUARIO
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	31/08/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New BITACORA_USUARIO
        mEntidad.ID_BITACORA = ID_BITACORA
 
        If mComponente.ObtenerBITACORA_USUARIO(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_BITACORA.Text = mEntidad.ID_BITACORA.ToString()
        Me.ddlUSUARIOUSUARIO.Recuperar()
        Me.ddlUSUARIOUSUARIO.SelectedValue = mEntidad.USUARIO
        Me.txtFECHA_ENTRADA.Text = IIf(Not mEntidad.FECHA_ENTRADA = Nothing, Format(mEntidad.FECHA_ENTRADA, "dd/MM/yyyy"), "")
        Me.txtFECHA_SALIDA.Text = IIf(Not mEntidad.FECHA_SALIDA = Nothing, Format(mEntidad.FECHA_SALIDA, "dd/MM/yyyy"), "")
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	31/08/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.ddlUSUARIOUSUARIO.Enabled = edicion
        Me.txtFECHA_ENTRADA.Enabled = edicion
        Me.txtFECHA_SALIDA.Enabled = edicion
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	31/08/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.ddlUSUARIOUSUARIO.Recuperar()
        Me.txtFECHA_ENTRADA.Text = ""
        Me.txtFECHA_SALIDA.Text = ""
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla BITACORA_USUARIO
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	31/08/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        mEntidad = New BITACORA_USUARIO
        If Me._nuevo Then
            mEntidad.ID_BITACORA = 0
        Else
            mEntidad.ID_BITACORA = CInt(Me.txtID_BITACORA.Text)
        End If
        mEntidad.USUARIO = Me.ddlUSUARIOUSUARIO.SelectedValue
        mEntidad.FECHA_ENTRADA = System.DateTime.Parse(Me.txtFECHA_ENTRADA.Text, New System.Globalization.CultureInfo("fr-FR", True),  _
                System.Globalization.DateTimeStyles.NoCurrentDateDefault)
        mEntidad.FECHA_SALIDA = System.DateTime.Parse(Me.txtFECHA_SALIDA.Text, New System.Globalization.CultureInfo("fr-FR", True),  _
                System.Globalization.DateTimeStyles.NoCurrentDateDefault)

        If mComponente.ActualizarBITACORA_USUARIO(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_BITACORA.Text = mEntidad.ID_BITACORA.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
