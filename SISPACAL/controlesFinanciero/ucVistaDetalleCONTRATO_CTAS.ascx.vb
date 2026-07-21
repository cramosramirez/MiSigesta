Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetalleCONTRATO_CTAS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla CONTRATO_CTAS
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	06/11/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleCONTRATO_CTAS
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_CONTRATO_CTAS As Int32
    Public Property ID_CONTRATO_CTAS() As Int32
        Get
            Return Me.txtID_CONTRATO_CTAS.Text
        End Get
        Set(ByVal Value As Int32)
            Me._ID_CONTRATO_CTAS = Value
            Me.txtID_CONTRATO_CTAS.Text = CStr(Value)
            If Me._ID_CONTRATO_CTAS > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property ID_CONTRATO_FINAN() As Int32
        Get
            Return Me.ddlCONTRATO_FINANID_CONTRATO_FINAN.SelectedValue
        End Get
        Set(ByVal value As Int32)
            If Not Me.ddlCONTRATO_FINANID_CONTRATO_FINAN.Items.FindByValue(value) Is Nothing Then
                Me.ddlCONTRATO_FINANID_CONTRATO_FINAN.SelectedValue = value
            End If
        End Set
    End Property

    Public Property CODICONTRATO() As String
        Get
            Return Me.ddlCONTRATOCODICONTRATO.SelectedValue
        End Get
        Set(ByVal value As String)
            If Not Me.ddlCONTRATOCODICONTRATO.Items.FindByValue(value) Is Nothing Then
                Me.ddlCONTRATOCODICONTRATO.SelectedValue = value
            End If
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

    Public Property ID_CUENTA_FINAN() As Int32
        Get
            Return Me.ddlCUENTA_FINANID_CUENTA_FINAN.SelectedValue
        End Get
        Set(ByVal value As Int32)
            If Not Me.ddlCUENTA_FINANID_CUENTA_FINAN.Items.FindByValue(value) Is Nothing Then
                Me.ddlCUENTA_FINANID_CUENTA_FINAN.SelectedValue = value
            End If
        End Set
    End Property

    Public Property MONTO_FINAN() As Decimal
        Get
            If Me.txtMONTO_FINAN.Value Is Nothing Then Return -1
            Return Me.txtMONTO_FINAN.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtMONTO_FINAN.Value = value
        End Set
    End Property

    Public Property ABONO_FINAN() As Decimal
        Get
            If Me.txtABONO_FINAN.Value Is Nothing Then Return -1
            Return Me.txtABONO_FINAN.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtABONO_FINAN.Value = value
        End Set
    End Property

    Public Property SALDO_FINAN() As Decimal
        Get
            If Me.txtSALDO_FINAN.Value Is Nothing Then Return -1
            Return Me.txtSALDO_FINAN.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtSALDO_FINAN.Value = value
        End Set
    End Property

    Public Property ZAFRA() As String
        Get
            Return Me.txtZAFRA.Text
        End Get
        Set(ByVal value As String)
            Me.txtZAFRA.Text = value.ToString()
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
            Return Me.deFECHA_CREA.Value
        End Get
        Set(ByVal value As DateTime)
            Me.deFECHA_CREA.Value = value
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
            Return Me.deFECHA_ACT.Value
        End Get
        Set(ByVal value As DateTime)
            Me.deFECHA_ACT.Value = value
        End Set
    End Property

    Public Property VerID_CONTRATO_CTAS() As Boolean
        Get
            Return Me.trID_CONTRATO_CTAS.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_CONTRATO_CTAS.Visible = value
        End Set
    End Property

    Public Property VerID_CONTRATO_FINAN() As Boolean
        Get
            Return Me.trID_CONTRATO_FINAN.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_CONTRATO_FINAN.Visible = value
        End Set
    End Property

    Public Property VerCODICONTRATO() As Boolean
        Get
            Return Me.trCODICONTRATO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCODICONTRATO.Visible = value
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

    Public Property VerID_CUENTA_FINAN() As Boolean
        Get
            Return Me.trID_CUENTA_FINAN.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_CUENTA_FINAN.Visible = value
        End Set
    End Property

    Public Property VerMONTO_FINAN() As Boolean
        Get
            Return Me.trMONTO_FINAN.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trMONTO_FINAN.Visible = value
        End Set
    End Property

    Public Property VerABONO_FINAN() As Boolean
        Get
            Return Me.trABONO_FINAN.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trABONO_FINAN.Visible = value
        End Set
    End Property

    Public Property VerSALDO_FINAN() As Boolean
        Get
            Return Me.trSALDO_FINAN.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trSALDO_FINAN.Visible = value
        End Set
    End Property

    Public Property VerZAFRA() As Boolean
        Get
            Return Me.trZAFRA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trZAFRA.Visible = value
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
    Private mComponente As New cCONTRATO_CTAS
    Private mEntidad As CONTRATO_CTAS
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
        If Not Me.ViewState("ID_CONTRATO_CTAS") Is Nothing Then Me._ID_CONTRATO_CTAS = Me.ViewState("ID_CONTRATO_CTAS")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla CONTRATO_CTAS
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	06/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New CONTRATO_CTAS
        mEntidad.ID_CONTRATO_CTAS = ID_CONTRATO_CTAS
 
        If mComponente.ObtenerCONTRATO_CTAS(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_CONTRATO_CTAS.Text = mEntidad.ID_CONTRATO_CTAS.ToString()
        Me.ddlCONTRATO_FINANID_CONTRATO_FINAN.Recuperar()
        Me.ddlCONTRATO_FINANID_CONTRATO_FINAN.SelectedValue = mEntidad.ID_CONTRATO_FINAN
        Me.ddlCONTRATOCODICONTRATO.Recuperar()
        Me.ddlCONTRATOCODICONTRATO.SelectedValue = mEntidad.CODICONTRATO
        Me.ddlZAFRAID_ZAFRA.Recuperar()
        Me.ddlZAFRAID_ZAFRA.SelectedValue = mEntidad.ID_ZAFRA
        Me.ddlCUENTA_FINANID_CUENTA_FINAN.Recuperar()
        Me.ddlCUENTA_FINANID_CUENTA_FINAN.SelectedValue = mEntidad.ID_CUENTA_FINAN
        Me.txtMONTO_FINAN.Value = mEntidad.CARGO
        Me.txtABONO_FINAN.Value = mEntidad.ABONO
        Me.txtSALDO_FINAN.Value = mEntidad.SALDO
        Me.txtZAFRA.Text = mEntidad.ZAFRA
        Me.txtUSUARIO_CREA.Text = mEntidad.USUARIO_CREA
        Me.deFECHA_CREA.Value = mEntidad.FECHA_CREA
        Me.txtUSUARIO_ACT.Text = mEntidad.USUARIO_ACT
        Me.deFECHA_ACT.Value = mEntidad.FECHA_ACT
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	06/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.ddlCONTRATO_FINANID_CONTRATO_FINAN.Enabled = edicion
        Me.ddlCONTRATOCODICONTRATO.Enabled = edicion
        Me.ddlZAFRAID_ZAFRA.Enabled = edicion
        Me.ddlCUENTA_FINANID_CUENTA_FINAN.Enabled = edicion
        Me.txtMONTO_FINAN.Enabled = edicion
        Me.txtABONO_FINAN.Enabled = edicion
        Me.txtSALDO_FINAN.Enabled = edicion
        Me.txtZAFRA.Enabled = edicion
        Me.txtUSUARIO_CREA.Enabled = edicion
        Me.deFECHA_CREA.Enabled = edicion
        Me.txtUSUARIO_ACT.Enabled = edicion
        Me.deFECHA_ACT.Enabled = edicion
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	06/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.ddlCONTRATO_FINANID_CONTRATO_FINAN.Recuperar()
        Me.ddlCONTRATOCODICONTRATO.Recuperar()
        Me.ddlZAFRAID_ZAFRA.Recuperar()
        Me.ddlCUENTA_FINANID_CUENTA_FINAN.Recuperar()
        Me.txtMONTO_FINAN.Value = Nothing
        Me.txtABONO_FINAN.Value = Nothing
        Me.txtSALDO_FINAN.Value = Nothing
        Me.txtZAFRA.Text = ""
        Me.txtUSUARIO_CREA.Text = ""
        Me.deFECHA_CREA.Value = Nothing
        Me.txtUSUARIO_ACT.Text = ""
        Me.deFECHA_ACT.Value = Nothing
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla CONTRATO_CTAS
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	06/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        mEntidad = New CONTRATO_CTAS
        If Me._nuevo Then
            mEntidad.ID_CONTRATO_CTAS = 0
        Else
            mEntidad.ID_CONTRATO_CTAS = CInt(Me.txtID_CONTRATO_CTAS.Text)
        End If
        mEntidad.ID_CONTRATO_FINAN = Me.ddlCONTRATO_FINANID_CONTRATO_FINAN.SelectedValue
        mEntidad.CODICONTRATO = Me.ddlCONTRATOCODICONTRATO.SelectedValue
        mEntidad.ID_ZAFRA = Me.ddlZAFRAID_ZAFRA.SelectedValue
        mEntidad.ID_CUENTA_FINAN = Me.ddlCUENTA_FINANID_CUENTA_FINAN.SelectedValue
        mEntidad.CARGO = Me.txtMONTO_FINAN.Value
        mEntidad.ABONO = Me.txtABONO_FINAN.Value
        mEntidad.SALDO = Me.txtSALDO_FINAN.Value
        mEntidad.ZAFRA = Me.txtZAFRA.Text
        mEntidad.USUARIO_CREA = Me.txtUSUARIO_CREA.Text
        mEntidad.FECHA_CREA = Me.deFECHA_CREA.Value
        mEntidad.USUARIO_ACT = Me.txtUSUARIO_ACT.Text
        mEntidad.FECHA_ACT = Me.deFECHA_ACT.Value

        If mComponente.ActualizarCONTRATO_CTAS(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_CONTRATO_CTAS.Text = mEntidad.ID_CONTRATO_CTAS.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
