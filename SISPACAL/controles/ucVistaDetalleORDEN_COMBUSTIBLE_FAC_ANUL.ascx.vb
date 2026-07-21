Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetalleORDEN_COMBUSTIBLE_FAC_ANUL
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla ORDEN_COMBUSTIBLE_FAC_ANUL
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	28/01/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleORDEN_COMBUSTIBLE_FAC_ANUL
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_ORDEN_COMBUS_FAC_ANUL As Int32
    Public Property ID_ORDEN_COMBUS_FAC_ANUL() As Int32
        Get
            Return Me.txtID_ORDEN_COMBUS_FAC_ANUL.Text
        End Get
        Set(ByVal Value As Int32)
            Me._ID_ORDEN_COMBUS_FAC_ANUL = Value
            Me.txtID_ORDEN_COMBUS_FAC_ANUL.Text = CStr(Value)
            If Me._ID_ORDEN_COMBUS_FAC_ANUL > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property ID_ORDEN_COMBUS() As Int32
        Get
            Return Me.ddlORDEN_COMBUSTIBLEID_ORDEN_COMBUS.SelectedValue
        End Get
        Set(ByVal value As Int32)
            If Not Me.ddlORDEN_COMBUSTIBLEID_ORDEN_COMBUS.Items.FindByValue(value) Is Nothing Then
                Me.ddlORDEN_COMBUSTIBLEID_ORDEN_COMBUS.SelectedValue = value
            End If
        End Set
    End Property

    Public Property NO_FACTURA_CCF() As String
        Get
            Return Me.txtNO_FACTURA_CCF.Text
        End Get
        Set(ByVal value As String)
            Me.txtNO_FACTURA_CCF.Text = value.ToString()
        End Set
    End Property

    Public Property FECHA_DESPACHO() As DateTime
        Get
            Return Me.txtFECHA_DESPACHO.Text
        End Get
        Set(ByVal value As DateTime)
            Me.txtFECHA_DESPACHO.Text = value.ToString("dd/MM/yyyy")
        End Set
    End Property

    Public Property FECHA_ANULACION() As DateTime
        Get
            Return Me.txtFECHA_ANULACION.Text
        End Get
        Set(ByVal value As DateTime)
            Me.txtFECHA_ANULACION.Text = value.ToString("dd/MM/yyyy")
        End Set
    End Property

    Public Property MOTIVO_ANULACION() As String
        Get
            Return Me.txtMOTIVO_ANULACION.Text
        End Get
        Set(ByVal value As String)
            Me.txtMOTIVO_ANULACION.Text = value.ToString()
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

    Public Property VerID_ORDEN_COMBUS_FAC_ANUL() As Boolean
        Get
            Return Me.trID_ORDEN_COMBUS_FAC_ANUL.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_ORDEN_COMBUS_FAC_ANUL.Visible = value
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

    Public Property VerNO_FACTURA_CCF() As Boolean
        Get
            Return Me.trNO_FACTURA_CCF.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNO_FACTURA_CCF.Visible = value
        End Set
    End Property

    Public Property VerFECHA_DESPACHO() As Boolean
        Get
            Return Me.trFECHA_DESPACHO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFECHA_DESPACHO.Visible = value
        End Set
    End Property

    Public Property VerFECHA_ANULACION() As Boolean
        Get
            Return Me.trFECHA_ANULACION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFECHA_ANULACION.Visible = value
        End Set
    End Property

    Public Property VerMOTIVO_ANULACION() As Boolean
        Get
            Return Me.trMOTIVO_ANULACION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trMOTIVO_ANULACION.Visible = value
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
    Private mComponente As New cORDEN_COMBUSTIBLE_FAC_ANUL
    Private mEntidad As ORDEN_COMBUSTIBLE_FAC_ANUL
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
        If Not Me.ViewState("ID_ORDEN_COMBUS_FAC_ANUL") Is Nothing Then Me._ID_ORDEN_COMBUS_FAC_ANUL = Me.ViewState("ID_ORDEN_COMBUS_FAC_ANUL")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla ORDEN_COMBUSTIBLE_FAC_ANUL
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/01/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New ORDEN_COMBUSTIBLE_FAC_ANUL
        mEntidad.ID_ORDEN_COMBUS_FAC_ANUL = ID_ORDEN_COMBUS_FAC_ANUL
 
        If mComponente.ObtenerORDEN_COMBUSTIBLE_FAC_ANUL(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_ORDEN_COMBUS_FAC_ANUL.Text = mEntidad.ID_ORDEN_COMBUS_FAC_ANUL.ToString()
        Me.ddlORDEN_COMBUSTIBLEID_ORDEN_COMBUS.Recuperar()
        Me.ddlORDEN_COMBUSTIBLEID_ORDEN_COMBUS.SelectedValue = mEntidad.ID_ORDEN_COMBUS
        Me.txtNO_FACTURA_CCF.Text = mEntidad.NO_FACTURA_CCF
        Me.txtFECHA_DESPACHO.Text = IIf(Not mEntidad.FECHA_DESPACHO = Nothing, Format(mEntidad.FECHA_DESPACHO, "dd/MM/yyyy"), "")
        Me.txtFECHA_ANULACION.Text = IIf(Not mEntidad.FECHA_ANULACION = Nothing, Format(mEntidad.FECHA_ANULACION, "dd/MM/yyyy"), "")
        Me.txtMOTIVO_ANULACION.Text = mEntidad.MOTIVO_ANULACION
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
    ''' 	[GenApp]	28/01/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.ddlORDEN_COMBUSTIBLEID_ORDEN_COMBUS.Enabled = edicion
        Me.txtNO_FACTURA_CCF.Enabled = edicion
        Me.txtFECHA_DESPACHO.Enabled = edicion
        Me.txtFECHA_ANULACION.Enabled = edicion
        Me.txtMOTIVO_ANULACION.Enabled = edicion
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
    ''' 	[GenApp]	28/01/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.ddlORDEN_COMBUSTIBLEID_ORDEN_COMBUS.Recuperar()
        Me.txtNO_FACTURA_CCF.Text = ""
        Me.txtFECHA_DESPACHO.Text = ""
        Me.txtFECHA_ANULACION.Text = ""
        Me.txtMOTIVO_ANULACION.Text = ""
        Me.txtUSUARIO_CREA.Text = ""
        Me.txtFECHA_CREA.Text = ""
        Me.txtUSUARIO_ACT.Text = ""
        Me.txtFECHA_ACT.Text = ""
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla ORDEN_COMBUSTIBLE_FAC_ANUL
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/01/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        mEntidad = New ORDEN_COMBUSTIBLE_FAC_ANUL
        If Me._nuevo Then
            mEntidad.ID_ORDEN_COMBUS_FAC_ANUL = 0
        Else
            mEntidad.ID_ORDEN_COMBUS_FAC_ANUL = CInt(Me.txtID_ORDEN_COMBUS_FAC_ANUL.Text)
        End If
        mEntidad.ID_ORDEN_COMBUS = Me.ddlORDEN_COMBUSTIBLEID_ORDEN_COMBUS.SelectedValue
        mEntidad.NO_FACTURA_CCF = Me.txtNO_FACTURA_CCF.Text
        mEntidad.FECHA_DESPACHO = System.DateTime.Parse(Me.txtFECHA_DESPACHO.Text, New System.Globalization.CultureInfo("fr-FR", True),  _
                System.Globalization.DateTimeStyles.NoCurrentDateDefault)
        mEntidad.FECHA_ANULACION = System.DateTime.Parse(Me.txtFECHA_ANULACION.Text, New System.Globalization.CultureInfo("fr-FR", True),  _
                System.Globalization.DateTimeStyles.NoCurrentDateDefault)
        mEntidad.MOTIVO_ANULACION = Me.txtMOTIVO_ANULACION.Text
        mEntidad.USUARIO_CREA = Me.txtUSUARIO_CREA.Text
        mEntidad.FECHA_CREA = System.DateTime.Parse(Me.txtFECHA_CREA.Text, New System.Globalization.CultureInfo("fr-FR", True),  _
                System.Globalization.DateTimeStyles.NoCurrentDateDefault)
        mEntidad.USUARIO_ACT = Me.txtUSUARIO_ACT.Text
        mEntidad.FECHA_ACT = System.DateTime.Parse(Me.txtFECHA_ACT.Text, New System.Globalization.CultureInfo("fr-FR", True),  _
                System.Globalization.DateTimeStyles.NoCurrentDateDefault)

        If mComponente.ActualizarORDEN_COMBUSTIBLE_FAC_ANUL(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_ORDEN_COMBUS_FAC_ANUL.Text = mEntidad.ID_ORDEN_COMBUS_FAC_ANUL.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
