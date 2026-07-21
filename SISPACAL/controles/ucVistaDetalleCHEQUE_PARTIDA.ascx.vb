Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetalleCHEQUE_PARTIDA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla CHEQUE_PARTIDA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	06/12/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleCHEQUE_PARTIDA
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_CHEQUE_PARTIDA As Int32
    Dim txtMOTIVO_ANULACION As Object

    Public Property ID_CHEQUE_PARTIDA() As Int32
        Get
            Return Me.txtID_CHEQUE_PARTIDA.Text
        End Get
        Set(ByVal Value As Int32)
            Me._ID_CHEQUE_PARTIDA = Value
            Me.txtID_CHEQUE_PARTIDA.Text = CStr(Value)
            If Me._ID_CHEQUE_PARTIDA > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property ID_CHEQUE_PLANILLA() As Int32
        Get
            Return Me.ddlCHEQUE_PLANILLAID_CHEQUE_PLANILLA.SelectedValue
        End Get
        Set(ByVal value As Int32)
            If Not Me.ddlCHEQUE_PLANILLAID_CHEQUE_PLANILLA.Items.FindByValue(value) Is Nothing Then
                Me.ddlCHEQUE_PLANILLAID_CHEQUE_PLANILLA.SelectedValue = value
            End If
        End Set
    End Property

    Public Property ORDEN() As Int32
        Get
            If Me.txtORDEN.Text ="" Then Return -1
            Return CInt(Me.txtORDEN.Text)
        End Get
        Set(ByVal value As Int32)
            Me.txtORDEN.Text = value.ToString()
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

    Public Property DESCRIPCION_ADICIONAL() As String
        Get
            Return Me.txtDESCRIPCION_ADICIONAL.Text
        End Get
        Set(ByVal value As String)
            Me.txtDESCRIPCION_ADICIONAL.Text = value.ToString()
        End Set
    End Property

    Public Property DEBE() As Decimal
        Get
            If Me.txtDEBE.Text ="" Then Return -1
            Return Me.txtDEBE.Text
        End Get
        Set(ByVal value As Decimal)
            Me.txtDEBE.Text = value.ToString()
        End Set
    End Property

    Public Property HABER() As Decimal
        Get
            If Me.txtHABER.Text ="" Then Return -1
            Return Me.txtHABER.Text
        End Get
        Set(ByVal value As Decimal)
            Me.txtHABER.Text = value.ToString()
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

    Public Property VerID_CHEQUE_PARTIDA() As Boolean
        Get
            Return Me.trID_CHEQUE_PARTIDA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_CHEQUE_PARTIDA.Visible = value
        End Set
    End Property

    Public Property VerID_CHEQUE_PLANILLA() As Boolean
        Get
            Return Me.trID_CHEQUE_PLANILLA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_CHEQUE_PLANILLA.Visible = value
        End Set
    End Property

    Public Property VerORDEN() As Boolean
        Get
            Return Me.trORDEN.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trORDEN.Visible = value
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

    Public Property VerDESCRIPCION_ADICIONAL() As Boolean
        Get
            Return Me.trDESCRIPCION_ADICIONAL.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trDESCRIPCION_ADICIONAL.Visible = value
        End Set
    End Property

    Public Property VerDEBE() As Boolean
        Get
            Return Me.trDEBE.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trDEBE.Visible = value
        End Set
    End Property

    Public Property VerHABER() As Boolean
        Get
            Return Me.trHABER.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trHABER.Visible = value
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
    Private mComponente As New cCHEQUE_PARTIDA
    Private mEntidad As CHEQUE_PARTIDA
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
        If Not Me.ViewState("ID_CHEQUE_PARTIDA") Is Nothing Then Me._ID_CHEQUE_PARTIDA = Me.ViewState("ID_CHEQUE_PARTIDA")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla CHEQUE_PARTIDA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	06/12/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New CHEQUE_PARTIDA
        mEntidad.ID_CHEQUE_PARTIDA = ID_CHEQUE_PARTIDA
 
        If mComponente.ObtenerCHEQUE_PARTIDA(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_CHEQUE_PARTIDA.Text = mEntidad.ID_CHEQUE_PARTIDA.ToString()
        Me.ddlCHEQUE_PLANILLAID_CHEQUE_PLANILLA.Recuperar()
        Me.ddlCHEQUE_PLANILLAID_CHEQUE_PLANILLA.SelectedValue = mEntidad.ID_CHEQUE_PLANILLA
        Me.txtORDEN.Text = mEntidad.ORDEN
        Me.txtCUENTA_CONTABLE.Text = mEntidad.CUENTA_CONTABLE
        Me.txtDESCRIPCION_CUENTA.Text = mEntidad.DESCRIPCION_CUENTA
        Me.txtDESCRIPCION_ADICIONAL.Text = mEntidad.DESCRIPCION_ADICIONAL
        Me.txtDEBE.Text = mEntidad.DEBE
        Me.txtHABER.Text = mEntidad.HABER
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
    ''' 	[GenApp]	06/12/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.ddlCHEQUE_PLANILLAID_CHEQUE_PLANILLA.Enabled = edicion
        Me.txtORDEN.Enabled = edicion
        Me.txtCUENTA_CONTABLE.Enabled = edicion
        Me.txtDESCRIPCION_CUENTA.Enabled = edicion
        Me.txtDESCRIPCION_ADICIONAL.Enabled = edicion
        Me.txtDEBE.Enabled = edicion
        Me.txtHABER.Enabled = edicion
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
    ''' 	[GenApp]	06/12/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.ddlCHEQUE_PLANILLAID_CHEQUE_PLANILLA.Recuperar()
        Me.txtORDEN.Text = ""
        Me.txtCUENTA_CONTABLE.Text = ""
        Me.txtDESCRIPCION_CUENTA.Text = ""
        Me.txtDESCRIPCION_ADICIONAL.Text = ""
        Me.txtDEBE.Text = ""
        Me.txtHABER.Text = ""
        Me.txtUSUARIO_CREA.Text = ""
        Me.txtFECHA_CREA.Text = ""
        Me.txtUSUARIO_ACT.Text = ""
        Me.txtFECHA_ACT.Text = ""
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla CHEQUE_PARTIDA
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	06/12/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        mEntidad = New CHEQUE_PARTIDA
        If Me._nuevo Then
            mEntidad.ID_CHEQUE_PARTIDA = 0
        Else
            mEntidad.ID_CHEQUE_PARTIDA = CInt(Me.txtID_CHEQUE_PARTIDA.Text)
        End If
        mEntidad.ID_CHEQUE_PLANILLA = Me.ddlCHEQUE_PLANILLAID_CHEQUE_PLANILLA.SelectedValue
        mEntidad.ORDEN = Val(Me.txtORDEN.Text)
        mEntidad.CUENTA_CONTABLE = Me.txtCUENTA_CONTABLE.Text
        mEntidad.DESCRIPCION_CUENTA = Me.txtDESCRIPCION_CUENTA.Text
        mEntidad.DESCRIPCION_ADICIONAL = Me.txtDESCRIPCION_ADICIONAL.Text
        mEntidad.DEBE = Val(Me.txtDEBE.Text)
        mEntidad.HABER = Val(Me.txtHABER.Text)
        mEntidad.USUARIO_CREA = Me.txtUSUARIO_CREA.Text
        mEntidad.FECHA_CREA = System.DateTime.Parse(Me.txtFECHA_CREA.Text, New System.Globalization.CultureInfo("fr-FR", True),  _
                System.Globalization.DateTimeStyles.NoCurrentDateDefault)
        mEntidad.USUARIO_ACT = Me.txtUSUARIO_ACT.Text
        mEntidad.FECHA_ACT = System.DateTime.Parse(Me.txtFECHA_ACT.Text, New System.Globalization.CultureInfo("fr-FR", True),  _
                System.Globalization.DateTimeStyles.NoCurrentDateDefault)

        If mComponente.ActualizarCHEQUE_PARTIDA(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_CHEQUE_PARTIDA.Text = mEntidad.ID_CHEQUE_PARTIDA.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
