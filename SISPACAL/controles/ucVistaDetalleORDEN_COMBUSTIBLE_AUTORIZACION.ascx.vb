Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetalleORDEN_COMBUSTIBLE_AUTORIZACION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla ORDEN_COMBUSTIBLE_AUTORIZACION
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	25/02/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleORDEN_COMBUSTIBLE_AUTORIZACION
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_ORDEN_COMBUS_AUTO As Int32
    Public Property ID_ORDEN_COMBUS_AUTO() As Int32
        Get
            Return Me.txtID_ORDEN_COMBUS_AUTO.Text
        End Get
        Set(ByVal Value As Int32)
            Me._ID_ORDEN_COMBUS_AUTO = Value
            Me.txtID_ORDEN_COMBUS_AUTO.Text = CStr(Value)
            If Me._ID_ORDEN_COMBUS_AUTO > 0 Then
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

    Public Property ID_ORDEN_COMBUS() As Int32
        Get
            If IsNumeric(Me.txtID_ORDEN_COMBUS.Text) Then
                Return Convert.ToInt32(Me.txtID_ORDEN_COMBUS.Text)
            Else
                Return -1
            End If
        End Get
        Set(ByVal value As Int32)
            Me.txtID_ORDEN_COMBUS.Text = value
        End Set
    End Property

    Public Property AUTORIZACION_APLICADA() As Boolean
        Get
            Return Me.cbxAUTORIZACION_APLICADA.Checked
        End Get
        Set(ByVal value As Boolean)
            Me.cbxAUTORIZACION_APLICADA.Checked = value
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

    Public Property VerID_ORDEN_COMBUS_AUTO() As Boolean
        Get
            Return Me.trID_ORDEN_COMBUS_AUTO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_ORDEN_COMBUS_AUTO.Visible = value
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

    Public Property VerID_ORDEN_COMBUS() As Boolean
        Get
            Return Me.trID_ORDEN_COMBUS.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_ORDEN_COMBUS.Visible = value
        End Set
    End Property

    Public Property VerAUTORIZACION_APLICADA() As Boolean
        Get
            Return Me.trAUTORIZACION_APLICADA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trAUTORIZACION_APLICADA.Visible = value
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
    Private mComponente As New cORDEN_COMBUSTIBLE_AUTORIZACION
    Private mEntidad As ORDEN_COMBUSTIBLE_AUTORIZACION
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
        'Introducir aquí el código de usuario para inicializar la página
        If Not Me.ViewState("nuevo") Is Nothing Then Me._nuevo = Me.ViewState("nuevo")
        If Not Me.ViewState("ID_ORDEN_COMBUS_AUTO") Is Nothing Then Me._ID_ORDEN_COMBUS_AUTO = Me.ViewState("ID_ORDEN_COMBUS_AUTO")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información del registro de la tabla ORDEN_COMBUSTIBLE_AUTORIZACION
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	25/02/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New ORDEN_COMBUSTIBLE_AUTORIZACION
        mEntidad.ID_ORDEN_COMBUS_AUTO = ID_ORDEN_COMBUS_AUTO
 
        If mComponente.ObtenerORDEN_COMBUSTIBLE_AUTORIZACION(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_ORDEN_COMBUS_AUTO.Text = mEntidad.ID_ORDEN_COMBUS_AUTO.ToString()
        Me.txtCODIGO.Text = mEntidad.CODIGO
        Me.ddlTIPO_PROVEEDORID_TIPO_PROVEEDOR.RecuperarParaCombustible()
        Me.ddlTIPO_PROVEEDORID_TIPO_PROVEEDOR.SelectedValue = mEntidad.ID_TIPO_PROVEEDOR
        Select Case mEntidad.ID_TIPO_PROVEEDOR
            Case Enumeradores.TipoProveedor.Transportista
                Dim lCliente As TRANSPORTISTA
                lCliente = (New cTRANSPORTISTA).ObtenerTRANSPORTISTA(mEntidad.CODIGO)
                If lCliente IsNot Nothing Then Me.txtNOMBRE_CLIENTE.Text = lCliente.NOMBRES.Trim + " " + lCliente.APELLIDOS.Trim
            Case Enumeradores.TipoProveedor.Cañero
                Dim lCliente As PROVEEDOR
                lCliente = (New cPROVEEDOR).ObtenerPROVEEDOR(mEntidad.CODIGO.ToString)
                If lCliente IsNot Nothing Then Me.txtNOMBRE_CLIENTE.Text = lCliente.NOMBRES.Trim + " " + lCliente.APELLIDOS.Trim
            Case Enumeradores.TipoProveedor.FrenteRoza
                Dim lCliente As PROVEEDOR_ROZA
                lCliente = (New cPROVEEDOR_ROZA).ObtenerPROVEEDOR_ROZA(mEntidad.CODIGO)
                If lCliente IsNot Nothing Then Me.txtNOMBRE_CLIENTE.Text = lCliente.NOMBRE_PROVEEDOR_ROZA
        End Select
        If mEntidad.ID_ORDEN_COMBUS = -1 Then
            Me.txtID_ORDEN_COMBUS.Text = ""
        Else
            Me.txtID_ORDEN_COMBUS.Text = mEntidad.ID_ORDEN_COMBUS.ToString
        End If
        Me.cbxAUTORIZACION_APLICADA.Checked = mEntidad.AUTORIZACION_APLICADA
        Me.txtUSUARIO_CREA.Text = mEntidad.USUARIO_CREA
        Me.txtFECHA_CREA.Text = IIf(Not mEntidad.FECHA_CREA = Nothing, Format(mEntidad.FECHA_CREA, "dd/MM/yyyy"), "")
        Me.txtUSUARIO_ACT.Text = mEntidad.USUARIO_ACT
        Me.txtFECHA_ACT.Text = IIf(Not mEntidad.FECHA_ACT = Nothing, Format(mEntidad.FECHA_ACT, "dd/MM/yyyy"), "")
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	25/02/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.ddlTIPO_PROVEEDORID_TIPO_PROVEEDOR.Enabled = edicion
        Me.txtID_ORDEN_COMBUS.Enabled = False
        Me.txtCODIGO.Enabled = edicion
        Me.cbxAUTORIZACION_APLICADA.Enabled = False
        Me.txtUSUARIO_CREA.Enabled = edicion
        Me.txtFECHA_CREA.Enabled = edicion
        Me.txtUSUARIO_ACT.Enabled = edicion
        Me.txtFECHA_ACT.Enabled = edicion

        Me.trID_ORDEN_COMBUS.Visible = Not (Me._nuevo)
        Me.trAUTORIZACION_APLICADA.Visible = Not (Me._nuevo)
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	25/02/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.ddlTIPO_PROVEEDORID_TIPO_PROVEEDOR.RecuperarParaCombustible()
        Me.txtID_ORDEN_COMBUS.Text = ""
        Me.txtCODIGO.Text = ""
        Me.cbxAUTORIZACION_APLICADA.Checked = False
        Me.txtUSUARIO_CREA.Text = ""
        Me.txtFECHA_CREA.Text = ""
        Me.txtUSUARIO_ACT.Text = ""
        Me.txtFECHA_ACT.Text = ""
        Me.txtNOMBRE_CLIENTE.Text = ""
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Guarda la información del registro en la tabla ORDEN_COMBUSTIBLE_AUTORIZACION
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	25/02/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        mEntidad = New ORDEN_COMBUSTIBLE_AUTORIZACION
        If Me._nuevo Then
            mEntidad.ID_ORDEN_COMBUS_AUTO = 0
            mEntidad.USUARIO_CREA = Me.ObtenerUsuario
            mEntidad.FECHA_CREA = cFechaHora.ObtenerFechaHora
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
        Else
            mEntidad = (New cORDEN_COMBUSTIBLE_AUTORIZACION).ObtenerORDEN_COMBUSTIBLE_AUTORIZACION(CInt(Me.txtID_ORDEN_COMBUS_AUTO.Text))
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
        End If
        mEntidad.CODIGO = Me.txtCODIGO.Text
        mEntidad.ID_TIPO_PROVEEDOR = Me.ddlTIPO_PROVEEDORID_TIPO_PROVEEDOR.SelectedValue
        If Me.txtID_ORDEN_COMBUS.Text = "" Then
            mEntidad.ID_ORDEN_COMBUS = -1
        Else
            mEntidad.ID_ORDEN_COMBUS = Convert.ToInt32(Me.txtID_ORDEN_COMBUS.Text)
        End If
        mEntidad.AUTORIZACION_APLICADA = Me.cbxAUTORIZACION_APLICADA.Checked

        If mComponente.ActualizarORDEN_COMBUSTIBLE_AUTORIZACION(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_ORDEN_COMBUS_AUTO.Text = mEntidad.ID_ORDEN_COMBUS_AUTO.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function

    Protected Sub txtCODIGO_TextChanged(sender As Object, e As System.EventArgs) Handles txtCODIGO.TextChanged
        txtNOMBRE_CLIENTE.Text = ""
        txtCODIGO.Text = txtCODIGO.Text.Trim
        If Not Utilerias.EsNumeroEntero(txtCODIGO.Text) Then
            Me.txtCODIGO.Text = ""
            Me.txtNOMBRE_CLIENTE.Text = ""
            Me.txtCODIGO.Focus()
            Exit Sub
        End If
        txtCODIGO.Text = CInt(txtCODIGO.Text)
        If Me.ddlTIPO_PROVEEDORID_TIPO_PROVEEDOR.SelectedValue = Enumeradores.TipoProveedor.Transportista Then
            Dim entidad As TRANSPORTISTA
            entidad = (New cTRANSPORTISTA).ObtenerTRANSPORTISTA(Convert.ToInt32(txtCODIGO.Text))
            If entidad IsNot Nothing Then
                txtNOMBRE_CLIENTE.Text = Trim(entidad.NOMBRES + " " + entidad.APELLIDOS)
            Else
                AsignarMensaje(" * Codigo de transportista no esta registrado", True, True)
                txtCODIGO.Text = ""
                txtCODIGO.Focus()
            End If
        ElseIf ddlTIPO_PROVEEDORID_TIPO_PROVEEDOR.SelectedValue = Enumeradores.TipoProveedor.Cañero Then
            Dim entidad As PROVEEDOR
            Dim codiProveedor As String = ""

            entidad = (New cPROVEEDOR).ObtenerPROVEEDOR(Utilerias.FormatearCODIPROVEEDOR(CInt(Me.txtCODIGO.Text)))
            If entidad IsNot Nothing Then
                txtNOMBRE_CLIENTE.Text = entidad.NOMBRES.Trim + " " + entidad.APELLIDOS.Trim
            Else
                AsignarMensaje(" * Codigo de cañero no esta registrado", True, True)
                txtCODIGO.Text = ""
                txtCODIGO.Focus()
            End If
        End If
    End Sub
End Class
