Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetalleORDEN_ROZA_DETA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla ORDEN_ROZA_DETA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	12/11/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleORDEN_ROZA_DETA
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_ORDEN_DETA As Int32
    Public Property ID_ORDEN_DETA() As Int32
        Get
            Return Me.txtID_ORDEN_DETA.Text
        End Get
        Set(ByVal Value As Int32)
            Me._ID_ORDEN_DETA = Value
            Me.txtID_ORDEN_DETA.Text = CStr(Value)
            If Me._ID_ORDEN_DETA > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property ID_ORDEN() As Int32
        Get
            Return Me.ddlORDEN_ROZA_ENCAID_ORDEN.SelectedValue
        End Get
        Set(ByVal value As Int32)
            If Not Me.ddlORDEN_ROZA_ENCAID_ORDEN.Items.FindByValue(value) Is Nothing Then
                Me.ddlORDEN_ROZA_ENCAID_ORDEN.SelectedValue = value
            End If
        End Set
    End Property

    Public Property ID_PLAN_ENTREGA_CANA() As Int32
        Get
            Return Me.ddlPLAN_ENTREGA_CANAID_PLAN_ENTREGA_CANA.SelectedValue
        End Get
        Set(ByVal value As Int32)
            If Not Me.ddlPLAN_ENTREGA_CANAID_PLAN_ENTREGA_CANA.Items.FindByValue(value) Is Nothing Then
                Me.ddlPLAN_ENTREGA_CANAID_PLAN_ENTREGA_CANA.SelectedValue = value
            End If
        End Set
    End Property

    Public Property ACCESLOTE() As String
        Get
            Return Me.txtACCESLOTE.Text
        End Get
        Set(ByVal value As String)
            Me.txtACCESLOTE.Text = value.ToString()
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

    Public Property VerID_ORDEN_DETA() As Boolean
        Get
            Return Me.trID_ORDEN_DETA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_ORDEN_DETA.Visible = value
        End Set
    End Property

    Public Property VerID_ORDEN() As Boolean
        Get
            Return Me.trID_ORDEN.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_ORDEN.Visible = value
        End Set
    End Property

    Public Property VerID_PLAN_ENTREGA_CANA() As Boolean
        Get
            Return Me.trID_PLAN_ENTREGA_CANA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_PLAN_ENTREGA_CANA.Visible = value
        End Set
    End Property

    Public Property VerACCESLOTE() As Boolean
        Get
            Return Me.trACCESLOTE.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trACCESLOTE.Visible = value
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
    Private mComponente As New cORDEN_ROZA_DETA
    Private mEntidad As ORDEN_ROZA_DETA
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
        If Not Me.ViewState("ID_ORDEN_DETA") Is Nothing Then Me._ID_ORDEN_DETA = Me.ViewState("ID_ORDEN_DETA")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla ORDEN_ROZA_DETA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	12/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New ORDEN_ROZA_DETA
        mEntidad.ID_ORDEN_DETA = ID_ORDEN_DETA
 
        If mComponente.ObtenerORDEN_ROZA_DETA(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_ORDEN_DETA.Text = mEntidad.ID_ORDEN_DETA.ToString()
        Me.ddlORDEN_ROZA_ENCAID_ORDEN.Recuperar()
        Me.ddlORDEN_ROZA_ENCAID_ORDEN.SelectedValue = mEntidad.ID_ORDEN
        Me.ddlPLAN_ENTREGA_CANAID_PLAN_ENTREGA_CANA.Recuperar()
        Me.ddlPLAN_ENTREGA_CANAID_PLAN_ENTREGA_CANA.SelectedValue = mEntidad.ID_PLAN_ENTREGA_CANA
        Me.txtACCESLOTE.Text = mEntidad.ACCESLOTE
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
    ''' 	[GenApp]	12/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.ddlORDEN_ROZA_ENCAID_ORDEN.Enabled = edicion
        Me.ddlPLAN_ENTREGA_CANAID_PLAN_ENTREGA_CANA.Enabled = edicion
        Me.txtACCESLOTE.Enabled = edicion
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
    ''' 	[GenApp]	12/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.ddlORDEN_ROZA_ENCAID_ORDEN.Recuperar()
        Me.ddlPLAN_ENTREGA_CANAID_PLAN_ENTREGA_CANA.Recuperar()
        Me.txtACCESLOTE.Text = ""
        Me.txtUSUARIO_CREA.Text = ""
        Me.txtFECHA_CREA.Text = ""
        Me.txtUSUARIO_ACT.Text = ""
        Me.txtFECHA_ACT.Text = ""
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla ORDEN_ROZA_DETA
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	12/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        mEntidad = New ORDEN_ROZA_DETA
        If Me._nuevo Then
            mEntidad.ID_ORDEN_DETA = 0
        Else
            mEntidad.ID_ORDEN_DETA = CInt(Me.txtID_ORDEN_DETA.Text)
        End If
        mEntidad.ID_ORDEN = Me.ddlORDEN_ROZA_ENCAID_ORDEN.SelectedValue
        mEntidad.ID_PLAN_ENTREGA_CANA = Me.ddlPLAN_ENTREGA_CANAID_PLAN_ENTREGA_CANA.SelectedValue
        mEntidad.ACCESLOTE = Me.txtACCESLOTE.Text
        mEntidad.USUARIO_CREA = Me.txtUSUARIO_CREA.Text
        mEntidad.FECHA_CREA = System.DateTime.Parse(Me.txtFECHA_CREA.Text, New System.Globalization.CultureInfo("fr-FR", True),  _
                System.Globalization.DateTimeStyles.NoCurrentDateDefault)
        mEntidad.USUARIO_ACT = Me.txtUSUARIO_ACT.Text
        mEntidad.FECHA_ACT = System.DateTime.Parse(Me.txtFECHA_ACT.Text, New System.Globalization.CultureInfo("fr-FR", True),  _
                System.Globalization.DateTimeStyles.NoCurrentDateDefault)

        If mComponente.ActualizarORDEN_ROZA_DETA(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_ORDEN_DETA.Text = mEntidad.ID_ORDEN_DETA.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
