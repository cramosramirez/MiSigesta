Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetalleCUENTA_PROVEEDOR
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla CUENTA_PROVEEDOR
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	17/01/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleCUENTA_PROVEEDOR
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_CUENTA_PROVEEDOR As Int32
    Public Property ID_CUENTA_PROVEEDOR() As Int32
        Get
            Return Me.txtID_CUENTA_PROVEEDOR.Text
        End Get
        Set(ByVal Value As Int32)
            Me._ID_CUENTA_PROVEEDOR = Value
            Me.txtID_CUENTA_PROVEEDOR.Text = CStr(Value)
            If Me._ID_CUENTA_PROVEEDOR > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property CUENTA() As String
        Get
            Return Me.txtCUENTA.Text
        End Get
        Set(ByVal value As String)
            Me.txtCUENTA.Text = value.ToString()
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

    Public Property ID_TIPO_PROVEEDOR() As Int32
        Get
            Return Me.ddlTIPO_PROVEEDORID_TIPO_PROVEEDOR.SelectedValue
        End Get
        Set(ByVal value As Int32)
            If Not Me.ddlTIPO_PROVEEDORID_TIPO_PROVEEDOR.Items.FindByValue(value) Is Nothing Then
                Me.ddlTIPO_PROVEEDORID_TIPO_PROVEEDOR.SelectedValue = value
            End If
        End Set
    End Property

    Public Property USUARIO_CREA() As String
        Get
            Return Me.txtUSUARIO_CREA.Text
        End Get
        Set(ByVal value As String)
            Me.txtUSUARIO_CREA.Text = value.ToString()
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

    Public Property USUARIO_ACT() As String
        Get
            Return Me.txtUSUARIO_ACT.Text
        End Get
        Set(ByVal value As String)
            Me.txtUSUARIO_ACT.Text = value.ToString()
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

    Public Property VerID_CUENTA_PROVEEDOR() As Boolean
        Get
            Return Me.trID_CUENTA_PROVEEDOR.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_CUENTA_PROVEEDOR.Visible = value
        End Set
    End Property

    Public Property VerCUENTA() As Boolean
        Get
            Return Me.trCUENTA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCUENTA.Visible = value
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

    Public Property VerID_TIPO_PROVEEDOR() As Boolean
        Get
            Return Me.trID_TIPO_PROVEEDOR.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_TIPO_PROVEEDOR.Visible = value
        End Set
    End Property

    Public Property VerUSUARIO_CREA() As Boolean
        Get
            Return Me.trUSUARIO_CREA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trUSUARIO_CREA.Visible = value
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

    Public Property VerUSUARIO_ACT() As Boolean
        Get
            Return Me.trUSUARIO_ACT.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trUSUARIO_ACT.Visible = value
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
    Private mComponente As New cCUENTA_PROVEEDOR
    Private mEntidad As CUENTA_PROVEEDOR
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
        If Not Me.ViewState("ID_CUENTA_PROVEEDOR") Is Nothing Then Me._ID_CUENTA_PROVEEDOR = Me.ViewState("ID_CUENTA_PROVEEDOR")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla CUENTA_PROVEEDOR
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	17/01/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New CUENTA_PROVEEDOR
        mEntidad.ID_CUENTA_PROVEEDOR = ID_CUENTA_PROVEEDOR
 
        If mComponente.ObtenerCUENTA_PROVEEDOR(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_CUENTA_PROVEEDOR.Text = mEntidad.ID_CUENTA_PROVEEDOR.ToString()
        Me.txtCUENTA.Text = mEntidad.CUENTA
        Me.txtCODIGO.Text = mEntidad.CODIGO
        Me.ddlTIPO_PROVEEDORID_TIPO_PROVEEDOR.Recuperar()
        Me.ddlTIPO_PROVEEDORID_TIPO_PROVEEDOR.SelectedValue = mEntidad.ID_TIPO_PROVEEDOR
        Me.txtUSUARIO_CREA.Text = mEntidad.USUARIO_CREA
        Me.txtFECHA_CREA.Text = IIf(Not mEntidad.FECHA_CREA = Nothing, Format(mEntidad.FECHA_CREA, "dd/MM/yyyy"), "")
        Me.txtUSUARIO_ACT.Text = mEntidad.USUARIO_ACT
        Me.txtFECHA_ACT.Text = IIf(Not mEntidad.FECHA_ACT = Nothing, Format(mEntidad.FECHA_ACT, "dd/MM/yyyy"), "")
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	17/01/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.ddlTIPO_PROVEEDORID_TIPO_PROVEEDOR.Enabled = edicion
        Me.txtCUENTA.Enabled = edicion
        Me.txtCODIGO.Enabled = edicion
        Me.txtUSUARIO_CREA.Enabled = edicion
        Me.txtFECHA_CREA.Enabled = edicion
        Me.txtUSUARIO_ACT.Enabled = edicion
        Me.txtFECHA_ACT.Enabled = edicion
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	17/01/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.ddlTIPO_PROVEEDORID_TIPO_PROVEEDOR.Recuperar()
        Me.txtCUENTA.Text = ""
        Me.txtCODIGO.Text = ""
        Me.txtUSUARIO_CREA.Text = ""
        Me.txtFECHA_CREA.Text = ""
        Me.txtUSUARIO_ACT.Text = ""
        Me.txtFECHA_ACT.Text = ""
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla CUENTA_PROVEEDOR
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	17/01/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        mEntidad = New CUENTA_PROVEEDOR
        If Me._nuevo Then
            mEntidad.ID_CUENTA_PROVEEDOR = 0
        Else
            mEntidad.ID_CUENTA_PROVEEDOR = CInt(Me.txtID_CUENTA_PROVEEDOR.Text)
        End If
        mEntidad.CUENTA = Me.txtCUENTA.Text
        mEntidad.CODIGO = Me.txtCODIGO.Text
        mEntidad.ID_TIPO_PROVEEDOR = Me.ddlTIPO_PROVEEDORID_TIPO_PROVEEDOR.SelectedValue
        mEntidad.USUARIO_CREA = Me.txtUSUARIO_CREA.Text
        mEntidad.FECHA_CREA = System.DateTime.Parse(Me.txtFECHA_CREA.Text, New System.Globalization.CultureInfo("fr-FR", True),  _
                System.Globalization.DateTimeStyles.NoCurrentDateDefault)
        mEntidad.USUARIO_ACT = Me.txtUSUARIO_ACT.Text
        mEntidad.FECHA_ACT = System.DateTime.Parse(Me.txtFECHA_ACT.Text, New System.Globalization.CultureInfo("fr-FR", True),  _
                System.Globalization.DateTimeStyles.NoCurrentDateDefault)

        If mComponente.ActualizarCUENTA_PROVEEDOR(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_CUENTA_PROVEEDOR.Text = mEntidad.ID_CUENTA_PROVEEDOR.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
