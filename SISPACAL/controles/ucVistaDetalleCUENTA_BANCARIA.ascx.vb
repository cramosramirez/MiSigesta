Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetalleCUENTA_BANCARIA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla CUENTA_BANCARIA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	05/12/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleCUENTA_BANCARIA
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_CUENTA As Int32
    Public Property ID_CUENTA() As Int32
        Get
            Return Me.txtID_CUENTA.Text
        End Get
        Set(ByVal Value As Int32)
            Me._ID_CUENTA = Value
            Me.txtID_CUENTA.Text = CStr(Value)
            If Me._ID_CUENTA > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property NO_CUENTA() As String
        Get
            Return Me.txtNO_CUENTA.Text
        End Get
        Set(ByVal value As String)
            Me.txtNO_CUENTA.Text = value.ToString()
        End Set
    End Property

    Public Property CODIBANCO() As Int32
        Get
            Return Me.ddlBANCOSCODIBANCO.SelectedValue
        End Get
        Set(ByVal value As Int32)
            If Not Me.ddlBANCOSCODIBANCO.Items.FindByValue(value) Is Nothing Then
                Me.ddlBANCOSCODIBANCO.SelectedValue = value
            End If
        End Set
    End Property

    Public Property CUENTA_CONTABLE() As String
        Get
            Return Me.txtCUENTA_CONTABLE.Text
        End Get
        Set(ByVal value As String)
            Me.txtCUENTA_CONTABLE.Text = value.ToString()
        End Set
    End Property

    Public Property DESCRIPCION_CUENTA() As String
        Get
            Return Me.txtDESCRIPCION_CUENTA.Text
        End Get
        Set(ByVal value As String)
            Me.txtDESCRIPCION_CUENTA.Text = value.ToString()
        End Set
    End Property

    Public Property ACTIVO() As Boolean
        Get
            Return Me.cbxACTIVO.Checked
        End Get
        Set(ByVal value As Boolean)
            Me.cbxACTIVO.Checked = value
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

    Public Property VerID_CUENTA() As Boolean
        Get
            Return Me.trID_CUENTA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_CUENTA.Visible = value
        End Set
    End Property

    Public Property VerNO_CUENTA() As Boolean
        Get
            Return Me.trNO_CUENTA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNO_CUENTA.Visible = value
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

    Public Property VerCUENTA_CONTABLE() As Boolean
        Get
            Return Me.trCUENTA_CONTABLE.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCUENTA_CONTABLE.Visible = value
        End Set
    End Property

    Public Property VerDESCRIPCION_CUENTA() As Boolean
        Get
            Return Me.trDESCRIPCION_CUENTA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trDESCRIPCION_CUENTA.Visible = value
        End Set
    End Property

    Public Property VerACTIVO() As Boolean
        Get
            Return Me.trACTIVO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trACTIVO.Visible = value
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
    Private mComponente As New cCUENTA_BANCARIA
    Private mEntidad As CUENTA_BANCARIA
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
        If Not Me.ViewState("ID_CUENTA") Is Nothing Then Me._ID_CUENTA = Me.ViewState("ID_CUENTA")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla CUENTA_BANCARIA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/12/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New CUENTA_BANCARIA
        mEntidad.ID_CUENTA = ID_CUENTA
 
        If mComponente.ObtenerCUENTA_BANCARIA(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_CUENTA.Text = mEntidad.ID_CUENTA.ToString()
        Me.txtNO_CUENTA.Text = mEntidad.NO_CUENTA
        Me.ddlBANCOSCODIBANCO.Recuperar()
        Me.ddlBANCOSCODIBANCO.SelectedValue = mEntidad.CODIBANCO
        Me.txtCUENTA_CONTABLE.Text = mEntidad.CUENTA_CONTABLE
        Me.txtDESCRIPCION_CUENTA.Text = mEntidad.DESCRIPCION_CUENTA
        Me.cbxACTIVO.Checked = mEntidad.ACTIVO
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
    ''' 	[GenApp]	05/12/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.ddlBANCOSCODIBANCO.Enabled = edicion
        Me.txtNO_CUENTA.Enabled = edicion
        Me.txtCUENTA_CONTABLE.Enabled = edicion
        Me.txtDESCRIPCION_CUENTA.Enabled = edicion
        Me.cbxACTIVO.Enabled = edicion
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
    ''' 	[GenApp]	05/12/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.ddlBANCOSCODIBANCO.Recuperar()
        Me.txtNO_CUENTA.Text = ""
        Me.txtCUENTA_CONTABLE.Text = ""
        Me.txtDESCRIPCION_CUENTA.Text = ""
        Me.cbxACTIVO.Checked = False
        Me.txtUSUARIO_CREA.Text = ""
        Me.txtFECHA_CREA.Text = ""
        Me.txtUSUARIO_ACT.Text = ""
        Me.txtFECHA_ACT.Text = ""
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla CUENTA_BANCARIA
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/12/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        mEntidad = New CUENTA_BANCARIA
        If Me._nuevo Then
            mEntidad.ID_CUENTA = 0
            mEntidad.USUARIO_CREA = Me.ObtenerUsuario
            mEntidad.FECHA_CREA = cFechaHora.ObtenerFechaHora
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
        Else
            mEntidad = (New cCUENTA_BANCARIA).ObtenerCUENTA_BANCARIA(CInt(Me.txtID_CUENTA.Text))
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
        End If
        mEntidad.NO_CUENTA = Me.txtNO_CUENTA.Text
        mEntidad.CODIBANCO = Me.ddlBANCOSCODIBANCO.SelectedValue
        mEntidad.CUENTA_CONTABLE = Me.txtCUENTA_CONTABLE.Text
        mEntidad.DESCRIPCION_CUENTA = Me.txtDESCRIPCION_CUENTA.Text.ToUpper
        mEntidad.ACTIVO = Me.cbxACTIVO.Checked
       
        If mComponente.ActualizarCUENTA_BANCARIA(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro " + mComponente.sError, True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_CUENTA.Text = mEntidad.ID_CUENTA.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
