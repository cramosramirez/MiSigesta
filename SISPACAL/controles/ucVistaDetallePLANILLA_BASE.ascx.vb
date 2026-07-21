Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetallePLANILLA_BASE
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla PLANILLA_BASE
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	18/10/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetallePLANILLA_BASE
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_PLANILLA_BASE As Int32
    Public Property ID_PLANILLA_BASE() As Int32
        Get
            Return Me.txtID_PLANILLA_BASE.Text
        End Get
        Set(ByVal Value As Int32)
            Me._ID_PLANILLA_BASE = Value
            Me.txtID_PLANILLA_BASE.Text = CStr(Value)
            If Me._ID_PLANILLA_BASE > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property ID_ZAFRA() As Int32
        Get
            Return Me.ddlZAFRAID_ZAFRA.SelectedValue
        End Get
        Set(ByVal value As Int32)
            If Not Me.ddlZAFRAID_ZAFRA.Items.FindByValue(value) Is Nothing Then
                Me.ddlZAFRAID_ZAFRA.SelectedValue = value
            End If
        End Set
    End Property

    Public Property ID_CATORCENA() As Int32
        Get
            If Me.txtID_CATORCENA.Value Is Nothing Then Return -1
            Return CInt(Me.txtID_CATORCENA.Value)
        End Get
        Set(ByVal value As Int32)
            Me.txtID_CATORCENA.Value = value
        End Set
    End Property

    Public Property ID_TIPO_PLANILLA() As Int32
        Get
            Return Me.ddlTIPO_PLANILLAID_TIPO_PLANILLA.SelectedValue
        End Get
        Set(ByVal value As Int32)
            If Not Me.ddlTIPO_PLANILLAID_TIPO_PLANILLA.Items.FindByValue(value) Is Nothing Then
                Me.ddlTIPO_PLANILLAID_TIPO_PLANILLA.SelectedValue = value
            End If
        End Set
    End Property

    Public Property FECHA_INICIO() As DateTime
        Get
            Return Me.deFECHA_INICIO.Value
        End Get
        Set(ByVal value As DateTime)
            Me.deFECHA_INICIO.Value = value
        End Set
    End Property

    Public Property FECHA_FIN() As DateTime
        Get
            Return Me.deFECHA_FIN.Value
        End Get
        Set(ByVal value As DateTime)
            Me.deFECHA_FIN.Value = value
        End Set
    End Property

    Public Property FECHA_PAGO() As DateTime
        Get
            Return Me.deFECHA_PAGO.Value
        End Get
        Set(ByVal value As DateTime)
            Me.deFECHA_PAGO.Value = value
        End Set
    End Property

    Public Property NO_ANTICIPO() As Int32
        Get
            If Me.txtNO_ANTICIPO.Value Is Nothing Then Return -1
            Return CInt(Me.txtNO_ANTICIPO.Value)
        End Get
        Set(ByVal value As Int32)
            Me.txtNO_ANTICIPO.Value = value
        End Set
    End Property

    Public Property NO_ANTICIPO_LETRAS() As String
        Get
            Return Me.txtNO_ANTICIPO_LETRAS.Text
        End Get
        Set(ByVal value As String)
            Me.txtNO_ANTICIPO_LETRAS.Text = value.ToString()
        End Set
    End Property

    Public Property VALOR_UNIT_PAGO() As Decimal
        Get
            If Me.txtVALOR_UNIT_PAGO.Value Is Nothing Then Return -1
            Return Me.txtVALOR_UNIT_PAGO.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtVALOR_UNIT_PAGO.Value = value
        End Set
    End Property


    Public Property CONCEPTO() As String
        Get
            Return Me.txtCONCEPTO.Text
        End Get
        Set(ByVal value As String)
            Me.txtCONCEPTO.Text = value.ToString()
        End Set
    End Property

    Public Property VerID_PLANILLA_BASE() As Boolean
        Get
            Return Me.trID_PLANILLA_BASE.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_PLANILLA_BASE.Visible = value
        End Set
    End Property

    Public Property VerID_ZAFRA() As Boolean
        Get
            Return Me.trID_ZAFRA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_ZAFRA.Visible = value
        End Set
    End Property

    Public Property VerID_CATORCENA() As Boolean
        Get
            Return Me.trID_CATORCENA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_CATORCENA.Visible = value
        End Set
    End Property

    Public Property VerID_TIPO_PLANILLA() As Boolean
        Get
            Return Me.trID_TIPO_PLANILLA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_TIPO_PLANILLA.Visible = value
        End Set
    End Property

    Public Property VerFECHA_INICIO() As Boolean
        Get
            Return Me.trFECHA_INICIO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFECHA_INICIO.Visible = value
        End Set
    End Property

    Public Property VerFECHA_FIN() As Boolean
        Get
            Return Me.trFECHA_FIN.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFECHA_FIN.Visible = value
        End Set
    End Property

    Public Property VerFECHA_PAGO() As Boolean
        Get
            Return Me.trFECHA_PAGO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFECHA_PAGO.Visible = value
        End Set
    End Property

    Public Property VerNO_ANTICIPO() As Boolean
        Get
            Return Me.trNO_ANTICIPO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNO_ANTICIPO.Visible = value
        End Set
    End Property

    Public Property VerNO_ANTICIPO_LETRAS() As Boolean
        Get
            Return Me.trNO_ANTICIPO_LETRAS.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNO_ANTICIPO_LETRAS.Visible = value
        End Set
    End Property

    Public Property VerVALOR_UNIT_PAGO() As Boolean
        Get
            Return Me.trVALOR_UNIT_PAGO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trVALOR_UNIT_PAGO.Visible = value
        End Set
    End Property


    Public Property VerCONCEPTO() As Boolean
        Get
            Return Me.trCONCEPTO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCONCEPTO.Visible = value
        End Set
    End Property

    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cPLANILLA_BASE
    Private mEntidad As PLANILLA_BASE
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
        If Not Me.ViewState("ID_PLANILLA_BASE") Is Nothing Then Me._ID_PLANILLA_BASE = Me.ViewState("ID_PLANILLA_BASE")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla PLANILLA_BASE
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New PLANILLA_BASE
        mEntidad.ID_PLANILLA_BASE = ID_PLANILLA_BASE
 
        If mComponente.ObtenerPLANILLA_BASE(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_PLANILLA_BASE.Text = mEntidad.ID_PLANILLA_BASE.ToString()
        Me.ddlZAFRAID_ZAFRA.Recuperar()
        Me.ddlZAFRAID_ZAFRA.SelectedValue = mEntidad.ID_ZAFRA
        Me.txtID_CATORCENA.Value = mEntidad.ID_CATORCENA
        Me.ddlTIPO_PLANILLAID_TIPO_PLANILLA.Recuperar()
        Me.ddlTIPO_PLANILLAID_TIPO_PLANILLA.SelectedValue = mEntidad.ID_TIPO_PLANILLA
        Me.deFECHA_INICIO.Value = mEntidad.FECHA_INICIO
        Me.deFECHA_FIN.Value = mEntidad.FECHA_FIN
        Me.deFECHA_PAGO.Value = mEntidad.FECHA_PAGO
        Me.txtNO_ANTICIPO.Value = IIf(mEntidad.NO_ANTICIPO < 0, Nothing, mEntidad.NO_ANTICIPO)
        Me.txtNO_ANTICIPO_LETRAS.Text = mEntidad.NO_ANTICIPO_LETRAS
        Me.txtVALOR_UNIT_PAGO.Value = IIf(mEntidad.VALOR_UNIT_PAGO < 0, Nothing, mEntidad.VALOR_UNIT_PAGO)
        Me.txtCONCEPTO.Text = mEntidad.CONCEPTO
        Me.deFECHA_COMPROB.Value = mEntidad.FECHA_COMPROB
        Me.txtCTACONTA_PLANI_CANA.Value = mEntidad.CTACONTA_PLANI_CANA
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.ddlZAFRAID_ZAFRA.Enabled = _nuevo
        Me.ddlTIPO_PLANILLAID_TIPO_PLANILLA.Enabled = _nuevo
        Me.txtID_CATORCENA.Enabled = edicion
        Me.deFECHA_INICIO.Enabled = False
        Me.deFECHA_FIN.Enabled = False
        Me.deFECHA_PAGO.Enabled = _nuevo OrElse edicion
        Me.txtNO_ANTICIPO.Enabled = _nuevo
        Me.txtNO_ANTICIPO_LETRAS.Enabled = _nuevo
        Me.txtVALOR_UNIT_PAGO.Enabled = _nuevo
        Me.txtCONCEPTO.Enabled = _nuevo OrElse edicion
        Me.deFECHA_COMPROB.ClientEnabled = _nuevo OrElse edicion
        Me.txtCTACONTA_PLANI_CANA.ClientEnabled = _nuevo OrElse edicion
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.ddlZAFRAID_ZAFRA.Recuperar()
        Me.ddlTIPO_PLANILLAID_TIPO_PLANILLA.Recuperar()
        Me.txtID_CATORCENA.Value = Nothing
        Me.deFECHA_INICIO.Value = Nothing
        Me.deFECHA_FIN.Value = Nothing
        Me.deFECHA_PAGO.Value = Nothing
        Me.txtNO_ANTICIPO.Value = Nothing
        Me.txtNO_ANTICIPO_LETRAS.Text = ""
        Me.txtVALOR_UNIT_PAGO.Value = Nothing
        Me.txtCONCEPTO.Text = ""
        Me.deFECHA_COMPROB.Value = Nothing
        Me.txtCTACONTA_PLANI_CANA.Value = Nothing
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla PLANILLA_BASE
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        mEntidad = New PLANILLA_BASE
        If Me._nuevo Then
            mEntidad.ID_PLANILLA_BASE = 0
            mEntidad.USUARIO_CREA = Me.ObtenerUsuario
            mEntidad.FECHA_CREA = cFechaHora.ObtenerFechaHora
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
        Else
            mEntidad = mComponente.ObtenerPLANILLA_BASE(CInt(Me.txtID_PLANILLA_BASE.Text))
            mEntidad.USUARIO_CREA = Me.ObtenerUsuario
            mEntidad.FECHA_CREA = cFechaHora.ObtenerFechaHora
        End If
        mEntidad.ID_ZAFRA = Me.ddlZAFRAID_ZAFRA.SelectedValue
        mEntidad.ID_CATORCENA = Me.txtID_CATORCENA.Value
        mEntidad.ID_TIPO_PLANILLA = Me.ddlTIPO_PLANILLAID_TIPO_PLANILLA.SelectedValue
        mEntidad.FECHA_INICIO = Me.deFECHA_INICIO.Value
        mEntidad.FECHA_FIN = Me.deFECHA_FIN.Value
        mEntidad.FECHA_PAGO = Me.deFECHA_PAGO.Value
        mEntidad.FECHA_COMPROB = Me.deFECHA_COMPROB.Date
        mEntidad.NO_ANTICIPO = IIf(Me.txtNO_ANTICIPO.Value = Nothing, -1, Me.txtNO_ANTICIPO.Value)
        mEntidad.NO_ANTICIPO_LETRAS = Me.txtNO_ANTICIPO_LETRAS.Text
        mEntidad.VALOR_UNIT_PAGO = IIf(Me.txtVALOR_UNIT_PAGO.Value = Nothing, -1, Me.txtVALOR_UNIT_PAGO.Value)
        mEntidad.CONCEPTO = Me.txtCONCEPTO.Text.ToUpper
        mEntidad.CTACONTA_PLANI_CANA = Me.txtCTACONTA_PLANI_CANA.Text.Trim.ToUpper

        If mComponente.ActualizarPLANILLA_BASE(mEntidad) <= 0 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_PLANILLA_BASE.Text = mEntidad.ID_PLANILLA_BASE.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
