Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetalleCONTRATO_FINAN
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla CONTRATO_FINAN
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	06/11/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleCONTRATO_FINAN
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_CONTRATO_FINAN As Int32
    Public Property ID_CONTRATO_FINAN() As Int32
        Get
            Return Me.txtID_CONTRATO_FINAN.Text
        End Get
        Set(ByVal Value As Int32)
            Me._ID_CONTRATO_FINAN = Value
            Me.txtID_CONTRATO_FINAN.Text = CStr(Value)
            If Me._ID_CONTRATO_FINAN > 0 Then
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

    Public Property MZ() As Decimal
        Get
            If Me.txtMZ.Value Is Nothing Then Return -1
            Return Me.txtMZ.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtMZ.Value = value
        End Set
    End Property

    Public Property TONEL_MZ() As Decimal
        Get
            If Me.txtTONEL_MZ.Value Is Nothing Then Return -1
            Return Me.txtTONEL_MZ.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtTONEL_MZ.Value = value
        End Set
    End Property

    Public Property TONEL() As Decimal
        Get
            If Me.txtTONEL.Value Is Nothing Then Return -1
            Return Me.txtTONEL.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtTONEL.Value = value
        End Set
    End Property

    Public Property REND_COSECHA() As Decimal
        Get
            If Me.txtREND_COSECHA.Value Is Nothing Then Return -1
            Return Me.txtREND_COSECHA.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtREND_COSECHA.Value = value
        End Set
    End Property

    Public Property LIBRAS() As Decimal
        Get
            If Me.txtLIBRAS.Value Is Nothing Then Return -1
            Return Me.txtLIBRAS.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtLIBRAS.Value = value
        End Set
    End Property

    Public Property VIP() As Decimal
        Get
            If Me.txtVIP.Value Is Nothing Then Return -1
            Return Me.txtVIP.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtVIP.Value = value
        End Set
    End Property

    Public Property VALOR_CONTRA() As Decimal
        Get
            If Me.txtVALOR_CONTRA.Value Is Nothing Then Return -1
            Return Me.txtVALOR_CONTRA.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtVALOR_CONTRA.Value = value
        End Set
    End Property

    Public Property PROVI_ROZA() As Decimal
        Get
            If Me.txtPROVI_ROZA.Value Is Nothing Then Return -1
            Return Me.txtPROVI_ROZA.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtPROVI_ROZA.Value = value
        End Set
    End Property

    Public Property PROVI_ALZA() As Decimal
        Get
            If Me.txtPROVI_ALZA.Value Is Nothing Then Return -1
            Return Me.txtPROVI_ALZA.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtPROVI_ALZA.Value = value
        End Set
    End Property

    Public Property PROVI_TRANS() As Decimal
        Get
            If Me.txtPROVI_TRANS.Value Is Nothing Then Return -1
            Return Me.txtPROVI_TRANS.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtPROVI_TRANS.Value = value
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

    Public Property SALDO_DISPO() As Decimal
        Get
            If Me.txtSALDO_DISPO.Value Is Nothing Then Return -1
            Return Me.txtSALDO_DISPO.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtSALDO_DISPO.Value = value
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

    Public Property VerID_CONTRATO_FINAN() As Boolean
        Get
            Return Me.trID_CONTRATO_FINAN.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_CONTRATO_FINAN.Visible = value
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

    Public Property VerCODICONTRATO() As Boolean
        Get
            Return Me.trCODICONTRATO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCODICONTRATO.Visible = value
        End Set
    End Property

    Public Property VerMZ() As Boolean
        Get
            Return Me.trMZ.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trMZ.Visible = value
        End Set
    End Property

    Public Property VerTONEL_MZ() As Boolean
        Get
            Return Me.trTONEL_MZ.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTONEL_MZ.Visible = value
        End Set
    End Property

    Public Property VerTONEL() As Boolean
        Get
            Return Me.trTONEL.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTONEL.Visible = value
        End Set
    End Property

    Public Property VerREND_COSECHA() As Boolean
        Get
            Return Me.trREND_COSECHA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trREND_COSECHA.Visible = value
        End Set
    End Property

    Public Property VerLIBRAS() As Boolean
        Get
            Return Me.trLIBRAS.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trLIBRAS.Visible = value
        End Set
    End Property

    Public Property VerVIP() As Boolean
        Get
            Return Me.trVIP.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trVIP.Visible = value
        End Set
    End Property

    Public Property VerVALOR_CONTRA() As Boolean
        Get
            Return Me.trVALOR_CONTRA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trVALOR_CONTRA.Visible = value
        End Set
    End Property

    Public Property VerPROVI_ROZA() As Boolean
        Get
            Return Me.trPROVI_ROZA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trPROVI_ROZA.Visible = value
        End Set
    End Property

    Public Property VerPROVI_ALZA() As Boolean
        Get
            Return Me.trPROVI_ALZA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trPROVI_ALZA.Visible = value
        End Set
    End Property

    Public Property VerPROVI_TRANS() As Boolean
        Get
            Return Me.trPROVI_TRANS.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trPROVI_TRANS.Visible = value
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

    Public Property VerSALDO_DISPO() As Boolean
        Get
            Return Me.trSALDO_DISPO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trSALDO_DISPO.Visible = value
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
    Private mComponente As New cCONTRATO_FINAN
    Private mEntidad As CONTRATO_FINAN
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
        If Not Me.ViewState("ID_CONTRATO_FINAN") Is Nothing Then Me._ID_CONTRATO_FINAN = Me.ViewState("ID_CONTRATO_FINAN")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla CONTRATO_FINAN
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
        mEntidad = New CONTRATO_FINAN
        mEntidad.ID_CONTRATO_FINAN = ID_CONTRATO_FINAN
 
        If mComponente.ObtenerCONTRATO_FINAN(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_CONTRATO_FINAN.Text = mEntidad.ID_CONTRATO_FINAN.ToString()
        Me.ddlZAFRAID_ZAFRA.Recuperar()
        Me.ddlZAFRAID_ZAFRA.SelectedValue = mEntidad.ID_ZAFRA
        Me.ddlCONTRATOCODICONTRATO.Recuperar()
        Me.ddlCONTRATOCODICONTRATO.SelectedValue = mEntidad.CODICONTRATO
        Me.txtMZ.Value = mEntidad.MZ
        Me.txtTONEL_MZ.Value = mEntidad.TONEL_MZ
        Me.txtTONEL.Value = mEntidad.TONEL
        Me.txtREND_COSECHA.Value = mEntidad.REND_COSECHA
        Me.txtLIBRAS.Value = mEntidad.LIBRAS
        Me.txtVIP.Value = mEntidad.VIP
        Me.txtVALOR_CONTRA.Value = mEntidad.VALOR_CONTRA
        Me.txtPROVI_ROZA.Value = mEntidad.PROVI_ROZA
        Me.txtPROVI_ALZA.Value = mEntidad.PROVI_ALZA
        Me.txtPROVI_TRANS.Value = mEntidad.PROVI_TRANS
        Me.txtPROVISION.Value = mEntidad.PROVISION
        Me.txtMONTO_FINAN.Value = mEntidad.CARGO
        Me.txtABONO_FINAN.Value = mEntidad.ABONO
        Me.txtSALDO_DISPO.Value = mEntidad.DISPONIBLE
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
        Me.ddlZAFRAID_ZAFRA.Enabled = edicion
        Me.ddlCONTRATOCODICONTRATO.Enabled = edicion
        Me.txtMZ.Enabled = edicion
        Me.txtTONEL_MZ.Enabled = edicion
        Me.txtTONEL.Enabled = edicion
        Me.txtREND_COSECHA.Enabled = edicion
        Me.txtLIBRAS.Enabled = edicion
        Me.txtVIP.Enabled = edicion
        Me.txtVALOR_CONTRA.Enabled = edicion
        Me.txtPROVI_ROZA.Enabled = edicion
        Me.txtPROVI_ALZA.Enabled = edicion
        Me.txtPROVI_TRANS.Enabled = edicion
        Me.txtPROVISION.Enabled = edicion
        Me.txtMONTO_FINAN.Enabled = edicion
        Me.txtABONO_FINAN.Enabled = edicion
        Me.txtSALDO_FINAN.Enabled = edicion
        Me.txtSALDO_DISPO.Enabled = edicion
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
        Me.ddlZAFRAID_ZAFRA.Recuperar()
        Me.ddlCONTRATOCODICONTRATO.Recuperar()
        Me.txtMZ.Value = Nothing
        Me.txtTONEL_MZ.Value = Nothing
        Me.txtTONEL.Value = Nothing
        Me.txtREND_COSECHA.Value = Nothing
        Me.txtLIBRAS.Value = Nothing
        Me.txtVIP.Value = Nothing
        Me.txtVALOR_CONTRA.Value = Nothing
        Me.txtPROVI_ROZA.Value = Nothing
        Me.txtPROVI_ALZA.Value = Nothing
        Me.txtPROVI_TRANS.Value = Nothing
        Me.txtPROVISION.Value = Nothing
        Me.txtMONTO_FINAN.Value = Nothing
        Me.txtABONO_FINAN.Value = Nothing
        Me.txtSALDO_FINAN.Value = Nothing
        Me.txtSALDO_DISPO.Value = Nothing
        Me.txtZAFRA.Text = ""
        Me.txtUSUARIO_CREA.Text = ""
        Me.deFECHA_CREA.Value = Nothing
        Me.txtUSUARIO_ACT.Text = ""
        Me.deFECHA_ACT.Value = Nothing
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla CONTRATO_FINAN
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
        mEntidad = New CONTRATO_FINAN
        If Me._nuevo Then
            mEntidad.ID_CONTRATO_FINAN = 0
        Else
            mEntidad.ID_CONTRATO_FINAN = CInt(Me.txtID_CONTRATO_FINAN.Text)
        End If
        mEntidad.ID_ZAFRA = Me.ddlZAFRAID_ZAFRA.SelectedValue
        mEntidad.CODICONTRATO = Me.ddlCONTRATOCODICONTRATO.SelectedValue
        mEntidad.MZ = Me.txtMZ.Value
        mEntidad.TONEL_MZ = Me.txtTONEL_MZ.Value
        mEntidad.TONEL = Me.txtTONEL.Value
        mEntidad.REND_COSECHA = Me.txtREND_COSECHA.Value
        mEntidad.LIBRAS = Me.txtLIBRAS.Value
        mEntidad.VIP = Me.txtVIP.Value
        mEntidad.VALOR_CONTRA = Me.txtVALOR_CONTRA.Value
        mEntidad.PROVI_ROZA = Me.txtPROVI_ROZA.Value
        mEntidad.PROVI_ALZA = Me.txtPROVI_ALZA.Value
        mEntidad.PROVI_TRANS = Me.txtPROVI_TRANS.Value
        mEntidad.PROVISION = Me.txtPROVISION.Value
        mEntidad.CARGO = Me.txtMONTO_FINAN.Value
        mEntidad.ABONO = Me.txtABONO_FINAN.Value
        mEntidad.DISPONIBLE = Me.txtSALDO_DISPO.Value
        mEntidad.ZAFRA = Me.txtZAFRA.Text
        mEntidad.USUARIO_CREA = Me.txtUSUARIO_CREA.Text
        mEntidad.FECHA_CREA = Me.deFECHA_CREA.Value
        mEntidad.USUARIO_ACT = Me.txtUSUARIO_ACT.Text
        mEntidad.FECHA_ACT = Me.deFECHA_ACT.Value

        If mComponente.ActualizarCONTRATO_FINAN(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_CONTRATO_FINAN.Text = mEntidad.ID_CONTRATO_FINAN.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
