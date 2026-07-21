Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetalleCONTRATO_CTAS_MOVTOS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla CONTRATO_CTAS_MOVTOS
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	06/11/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleCONTRATO_CTAS_MOVTOS
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_CONTRATO_CTAS_MOVTOS As Int32
    Public Property ID_CONTRATO_CTAS_MOVTOS() As Int32
        Get
            Return Me.txtID_CONTRATO_CTAS_MOVTOS.Text
        End Get
        Set(ByVal Value As Int32)
            Me._ID_CONTRATO_CTAS_MOVTOS = Value
            Me.txtID_CONTRATO_CTAS_MOVTOS.Text = CStr(Value)
            If Me._ID_CONTRATO_CTAS_MOVTOS > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property ID_CONTRATO_CTAS() As Int32
        Get
            Return Me.ddlCONTRATO_CTASID_CONTRATO_CTAS.SelectedValue
        End Get
        Set(ByVal value As Int32)
            If Not Me.ddlCONTRATO_CTASID_CONTRATO_CTAS.Items.FindByValue(value) Is Nothing Then
                Me.ddlCONTRATO_CTASID_CONTRATO_CTAS.SelectedValue = value
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

    Public Property SALDO_INI() As Decimal
        Get
            If Me.txtSALDO_INI.Value Is Nothing Then Return -1
            Return Me.txtSALDO_INI.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtSALDO_INI.Value = value
        End Set
    End Property

    Public Property CARGO() As Decimal
        Get
            If Me.txtCARGO.Value Is Nothing Then Return -1
            Return Me.txtCARGO.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtCARGO.Value = value
        End Set
    End Property

    Public Property ABONO() As Decimal
        Get
            If Me.txtABONO.Value Is Nothing Then Return -1
            Return Me.txtABONO.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtABONO.Value = value
        End Set
    End Property

    Public Property SALDO_FIN() As Decimal
        Get
            If Me.txtSALDO_FIN.Value Is Nothing Then Return -1
            Return Me.txtSALDO_FIN.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtSALDO_FIN.Value = value
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

    Public Property UID_PLANILLA() As Guid
        Get
            If Me.txtUID_PLANILLA.Text <> "" Then
                Dim guid As Guid = New Guid(Me.txtUID_PLANILLA.Text)
                Return guid
            Else
                Return Nothing
            End If
        End Get
        Set(ByVal value As Guid)
            Me.txtUID_PLANILLA.Text = value.ToString()
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

    Public Property VerID_CONTRATO_CTAS_MOVTOS() As Boolean
        Get
            Return Me.trID_CONTRATO_CTAS_MOVTOS.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_CONTRATO_CTAS_MOVTOS.Visible = value
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

    Public Property VerSALDO_INI() As Boolean
        Get
            Return Me.trSALDO_INI.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trSALDO_INI.Visible = value
        End Set
    End Property

    Public Property VerCARGO() As Boolean
        Get
            Return Me.trCARGO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCARGO.Visible = value
        End Set
    End Property

    Public Property VerABONO() As Boolean
        Get
            Return Me.trABONO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trABONO.Visible = value
        End Set
    End Property

    Public Property VerSALDO_FIN() As Boolean
        Get
            Return Me.trSALDO_FIN.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trSALDO_FIN.Visible = value
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

    Public Property VerUID_PLANILLA() As Boolean
        Get
            Return Me.trUID_PLANILLA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trUID_PLANILLA.Visible = value
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
    Private mComponente As New cCONTRATO_CTAS_MOVTOS
    Private mEntidad As CONTRATO_CTAS_MOVTOS
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
        If Not Me.ViewState("ID_CONTRATO_CTAS_MOVTOS") Is Nothing Then Me._ID_CONTRATO_CTAS_MOVTOS = Me.ViewState("ID_CONTRATO_CTAS_MOVTOS")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla CONTRATO_CTAS_MOVTOS
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
        mEntidad = New CONTRATO_CTAS_MOVTOS
        mEntidad.ID_CONTRATO_CTAS_MOVTOS = ID_CONTRATO_CTAS_MOVTOS
 
        If mComponente.ObtenerCONTRATO_CTAS_MOVTOS(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_CONTRATO_CTAS_MOVTOS.Text = mEntidad.ID_CONTRATO_CTAS_MOVTOS.ToString()
        Me.ddlCONTRATO_CTASID_CONTRATO_CTAS.Recuperar()
        Me.ddlCONTRATO_CTASID_CONTRATO_CTAS.SelectedValue = mEntidad.ID_CONTRATO_CTAS
        Me.ddlCONTRATOCODICONTRATO.Recuperar()
        Me.ddlCONTRATOCODICONTRATO.SelectedValue = mEntidad.CODICONTRATO
        Me.ddlZAFRAID_ZAFRA.Recuperar()
        Me.ddlZAFRAID_ZAFRA.SelectedValue = mEntidad.ID_ZAFRA
        Me.deFECHA_APLICA.Value = mEntidad.FECHA_APLICA
        Me.txtCONCEPTO.Text = mEntidad.CONCEPTO
        Me.txtCARGO.Value = mEntidad.CARGO
        Me.txtABONO.Value = mEntidad.ABONO
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
        Me.ddlCONTRATO_CTASID_CONTRATO_CTAS.Enabled = edicion
        Me.ddlCONTRATOCODICONTRATO.Enabled = edicion
        Me.ddlZAFRAID_ZAFRA.Enabled = edicion
        Me.deFECHA_APLICA.Enabled = edicion
        Me.txtCONCEPTO.Enabled = edicion
        Me.txtSALDO_INI.Enabled = edicion
        Me.txtCARGO.Enabled = edicion
        Me.txtABONO.Enabled = edicion
        Me.txtSALDO_FIN.Enabled = edicion
        Me.txtUID_SOLIC_AGRI_PROD.Enabled = edicion
        Me.txtUID_SOLIC_AGRI_VUELO.Enabled = edicion
        Me.txtUID_PLANILLA.Enabled = edicion
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
        Me.ddlCONTRATO_CTASID_CONTRATO_CTAS.Recuperar()
        Me.ddlCONTRATOCODICONTRATO.Recuperar()
        Me.ddlZAFRAID_ZAFRA.Recuperar()
        Me.deFECHA_APLICA.Value = Nothing
        Me.txtCONCEPTO.Text = ""
        Me.txtSALDO_INI.Value = Nothing
        Me.txtCARGO.Value = Nothing
        Me.txtABONO.Value = Nothing
        Me.txtSALDO_FIN.Value = Nothing
        Me.txtUID_SOLIC_AGRI_PROD.Text = ""
        Me.txtUID_SOLIC_AGRI_VUELO.Text = ""
        Me.txtUID_PLANILLA.Text = ""
        Me.txtZAFRA.Text = ""
        Me.txtUSUARIO_CREA.Text = ""
        Me.deFECHA_CREA.Value = Nothing
        Me.txtUSUARIO_ACT.Text = ""
        Me.deFECHA_ACT.Value = Nothing
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla CONTRATO_CTAS_MOVTOS
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
        mEntidad = New CONTRATO_CTAS_MOVTOS
        If Me._nuevo Then
            mEntidad.ID_CONTRATO_CTAS_MOVTOS = 0
        Else
            mEntidad.ID_CONTRATO_CTAS_MOVTOS = CInt(Me.txtID_CONTRATO_CTAS_MOVTOS.Text)
        End If
        mEntidad.ID_CONTRATO_CTAS = Me.ddlCONTRATO_CTASID_CONTRATO_CTAS.SelectedValue
        mEntidad.CODICONTRATO = Me.ddlCONTRATOCODICONTRATO.SelectedValue
        mEntidad.ID_ZAFRA = Me.ddlZAFRAID_ZAFRA.SelectedValue
        mEntidad.FECHA_APLICA = Me.deFECHA_APLICA.Value
        mEntidad.CONCEPTO = Me.txtCONCEPTO.Text
        mEntidad.CARGO = Me.txtCARGO.Value
        mEntidad.ABONO = Me.txtABONO.Value
        mEntidad.ZAFRA = Me.txtZAFRA.Text
        mEntidad.USUARIO_CREA = Me.txtUSUARIO_CREA.Text
        mEntidad.FECHA_CREA = Me.deFECHA_CREA.Value
        mEntidad.USUARIO_ACT = Me.txtUSUARIO_ACT.Text
        mEntidad.FECHA_ACT = Me.deFECHA_ACT.Value

        If mComponente.ActualizarCONTRATO_CTAS_MOVTOS(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_CONTRATO_CTAS_MOVTOS.Text = mEntidad.ID_CONTRATO_CTAS_MOVTOS.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
