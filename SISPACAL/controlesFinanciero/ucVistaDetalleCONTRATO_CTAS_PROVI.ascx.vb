Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetalleCONTRATO_CTAS_PROVI
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla CONTRATO_CTAS_PROVI
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	06/11/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleCONTRATO_CTAS_PROVI
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_CONTRATO_CTAS_PROVI As Int32
    Public Property ID_CONTRATO_CTAS_PROVI() As Int32
        Get
            Return Me.txtID_CONTRATO_CTAS_PROVI.Text
        End Get
        Set(ByVal Value As Int32)
            Me._ID_CONTRATO_CTAS_PROVI = Value
            Me.txtID_CONTRATO_CTAS_PROVI.Text = CStr(Value)
            If Me._ID_CONTRATO_CTAS_PROVI > 0 Then
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

    Public Property FECHA_APLICA() As DateTime
        Get
            Return Me.deFECHA_APLICA.Value
        End Get
        Set(ByVal value As DateTime)
            Me.deFECHA_APLICA.Value = value
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

    Public Property PROVISION() As Decimal
        Get
            If Me.txtPROVISION.Value Is Nothing Then Return -1
            Return Me.txtPROVISION.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtPROVISION.Value = value
        End Set
    End Property

    Public Property UID_SOLIC_AGRI_PROD() As Guid
        Get
            If Me.txtUID_SOLIC_AGRI_PROD.Text <> "" Then
                Dim guid As Guid = New Guid(Me.txtUID_SOLIC_AGRI_PROD.Text)
                Return guid
            Else
                Return Nothing
            End If
        End Get
        Set(ByVal value As Guid)
            Me.txtUID_SOLIC_AGRI_PROD.Text = value.ToString()
        End Set
    End Property

    Public Property UID_SOLIC_AGRI_VUELO() As Guid
        Get
            If Me.txtUID_SOLIC_AGRI_VUELO.Text <> "" Then
                Dim guid As Guid = New Guid(Me.txtUID_SOLIC_AGRI_VUELO.Text)
                Return guid
            Else
                Return Nothing
            End If
        End Get
        Set(ByVal value As Guid)
            Me.txtUID_SOLIC_AGRI_VUELO.Text = value.ToString()
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

    Public Property VerID_CONTRATO_CTAS_PROVI() As Boolean
        Get
            Return Me.trID_CONTRATO_CTAS_PROVI.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_CONTRATO_CTAS_PROVI.Visible = value
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

    Public Property VerFECHA_APLICA() As Boolean
        Get
            Return Me.trFECHA_APLICA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFECHA_APLICA.Visible = value
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

    Public Property VerPROVISION() As Boolean
        Get
            Return Me.trPROVISION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trPROVISION.Visible = value
        End Set
    End Property

    Public Property VerUID_SOLIC_AGRI_PROD() As Boolean
        Get
            Return Me.trUID_SOLIC_AGRI_PROD.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trUID_SOLIC_AGRI_PROD.Visible = value
        End Set
    End Property

    Public Property VerUID_SOLIC_AGRI_VUELO() As Boolean
        Get
            Return Me.trUID_SOLIC_AGRI_VUELO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trUID_SOLIC_AGRI_VUELO.Visible = value
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
    Private mComponente As New cCONTRATO_CTAS_PROVI
    Private mEntidad As CONTRATO_CTAS_PROVI
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
        If Not Me.ViewState("ID_CONTRATO_CTAS_PROVI") Is Nothing Then Me._ID_CONTRATO_CTAS_PROVI = Me.ViewState("ID_CONTRATO_CTAS_PROVI")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla CONTRATO_CTAS_PROVI
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
        mEntidad = New CONTRATO_CTAS_PROVI
        mEntidad.ID_CONTRATO_CTAS_PROVI = ID_CONTRATO_CTAS_PROVI
 
        If mComponente.ObtenerCONTRATO_CTAS_PROVI(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_CONTRATO_CTAS_PROVI.Text = mEntidad.ID_CONTRATO_CTAS_PROVI.ToString()
        Me.ddlCONTRATO_FINANID_CONTRATO_FINAN.Recuperar()
        Me.ddlCONTRATO_FINANID_CONTRATO_FINAN.SelectedValue = mEntidad.ID_CONTRATO_FINAN
        Me.ddlCONTRATOCODICONTRATO.Recuperar()
        Me.ddlCONTRATOCODICONTRATO.SelectedValue = mEntidad.CODICONTRATO
        Me.ddlZAFRAID_ZAFRA.Recuperar()
        Me.ddlZAFRAID_ZAFRA.SelectedValue = mEntidad.ID_ZAFRA
        Me.deFECHA_APLICA.Value = mEntidad.FECHA_APLICA
        Me.txtCONCEPTO.Text = mEntidad.CONCEPTO
        Me.txtPROVISION.Value = mEntidad.PROVISION
        'Me.txtUID_SOLIC_AGRI_PROD.Text = mEntidad.UID_SOLIC_AGRI_PROD
        'Me.txtUID_SOLIC_AGRI_VUELO.Text = mEntidad.UID_SOLIC_AGRI_VUELO
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
        Me.deFECHA_APLICA.Enabled = edicion
        Me.txtCONCEPTO.Enabled = edicion
        Me.txtPROVISION.Enabled = edicion
        Me.txtUID_SOLIC_AGRI_PROD.Enabled = edicion
        Me.txtUID_SOLIC_AGRI_VUELO.Enabled = edicion
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
        Me.deFECHA_APLICA.Value = Nothing
        Me.txtCONCEPTO.Text = ""
        Me.txtPROVISION.Value = Nothing
        Me.txtUID_SOLIC_AGRI_PROD.Text = ""
        Me.txtUID_SOLIC_AGRI_VUELO.Text = ""
        Me.txtZAFRA.Text = ""
        Me.txtUSUARIO_CREA.Text = ""
        Me.deFECHA_CREA.Value = Nothing
        Me.txtUSUARIO_ACT.Text = ""
        Me.deFECHA_ACT.Value = Nothing
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla CONTRATO_CTAS_PROVI
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
        mEntidad = New CONTRATO_CTAS_PROVI
        If Me._nuevo Then
            mEntidad.ID_CONTRATO_CTAS_PROVI = 0
        Else
            mEntidad.ID_CONTRATO_CTAS_PROVI = CInt(Me.txtID_CONTRATO_CTAS_PROVI.Text)
        End If
        mEntidad.ID_CONTRATO_FINAN = Me.ddlCONTRATO_FINANID_CONTRATO_FINAN.SelectedValue
        mEntidad.CODICONTRATO = Me.ddlCONTRATOCODICONTRATO.SelectedValue
        mEntidad.ID_ZAFRA = Me.ddlZAFRAID_ZAFRA.SelectedValue
        mEntidad.FECHA_APLICA = Me.deFECHA_APLICA.Value
        mEntidad.CONCEPTO = Me.txtCONCEPTO.Text
        mEntidad.PROVISION = Me.txtPROVISION.Value
        'mEntidad.UID_SOLIC_AGRI_PROD = Me.txtUID_SOLIC_AGRI_PROD.Text
        'mEntidad.UID_SOLIC_AGRI_VUELO = Me.txtUID_SOLIC_AGRI_VUELO.Text
        mEntidad.ZAFRA = Me.txtZAFRA.Text
        mEntidad.USUARIO_CREA = Me.txtUSUARIO_CREA.Text
        mEntidad.FECHA_CREA = Me.deFECHA_CREA.Value
        mEntidad.USUARIO_ACT = Me.txtUSUARIO_ACT.Text
        mEntidad.FECHA_ACT = Me.deFECHA_ACT.Value

        If mComponente.ActualizarCONTRATO_CTAS_PROVI(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_CONTRATO_CTAS_PROVI.Text = mEntidad.ID_CONTRATO_CTAS_PROVI.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
