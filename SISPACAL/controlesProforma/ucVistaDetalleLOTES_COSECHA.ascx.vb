Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetalleLOTES_COSECHA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla LOTES_COSECHA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	19/01/2015	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleLOTES_COSECHA
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_LOTES_COSECHA As Int32
    Public Property ID_LOTES_COSECHA() As Int32
        Get
            Return Me.txtID_LOTES_COSECHA.Text
        End Get
        Set(ByVal Value As Int32)
            Me._ID_LOTES_COSECHA = Value
            Me.txtID_LOTES_COSECHA.Text = CStr(Value)
            If Me._ID_LOTES_COSECHA > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property ACCESLOTE() As String
        Get
            Return Me.ddlLOTESACCESLOTE.SelectedValue
        End Get
        Set(ByVal value As String)
            If Not Me.ddlLOTESACCESLOTE.Items.FindByValue(value) Is Nothing Then
                Me.ddlLOTESACCESLOTE.SelectedValue = value
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

    Public Property FECHA_ROZA() As DateTime
        Get
            Return Me.deFECHA_ROZA.Value
        End Get
        Set(ByVal value As DateTime)
            Me.deFECHA_ROZA.Value = value
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

    Public Property MZ_ENTREGAR() As Decimal
        Get
            If Me.txtMZ_ENTREGAR.Value Is Nothing Then Return -1
            Return Me.txtMZ_ENTREGAR.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtMZ_ENTREGAR.Value = value
        End Set
    End Property

    Public Property TONEL_MZ_ENTREGAR() As Decimal
        Get
            If Me.txtTONEL_MZ_ENTREGAR.Value Is Nothing Then Return -1
            Return Me.txtTONEL_MZ_ENTREGAR.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtTONEL_MZ_ENTREGAR.Value = value
        End Set
    End Property

    Public Property TONEL_ENTREGAR() As Decimal
        Get
            If Me.txtTONEL_ENTREGAR.Value Is Nothing Then Return -1
            Return Me.txtTONEL_ENTREGAR.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtTONEL_ENTREGAR.Value = value
        End Set
    End Property

    Public Property LBS_ENTREGAR() As Decimal
        Get
            If Me.txtLBS_ENTREGAR.Value Is Nothing Then Return -1
            Return Me.txtLBS_ENTREGAR.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtLBS_ENTREGAR.Value = value
        End Set
    End Property

    Public Property VALOR_ENTREGAR() As Decimal
        Get
            If Me.txtVALOR_ENTREGAR.Value Is Nothing Then Return -1
            Return Me.txtVALOR_ENTREGAR.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtVALOR_ENTREGAR.Value = value
        End Set
    End Property

    Public Property MZ_ENTREGADA() As Decimal
        Get
            If Me.txtMZ_ENTREGADA.Value Is Nothing Then Return -1
            Return Me.txtMZ_ENTREGADA.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtMZ_ENTREGADA.Value = value
        End Set
    End Property

    Public Property TONEL_MZ_ENTREGADA() As Decimal
        Get
            If Me.txtTONEL_MZ_ENTREGADA.Value Is Nothing Then Return -1
            Return Me.txtTONEL_MZ_ENTREGADA.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtTONEL_MZ_ENTREGADA.Value = value
        End Set
    End Property

    Public Property TONEL_ENTREGADA() As Decimal
        Get
            If Me.txtTONEL_ENTREGADA.Value Is Nothing Then Return -1
            Return Me.txtTONEL_ENTREGADA.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtTONEL_ENTREGADA.Value = value
        End Set
    End Property

    Public Property LBS_ENTREGADA() As Decimal
        Get
            If Me.txtLBS_ENTREGADA.Value Is Nothing Then Return -1
            Return Me.txtLBS_ENTREGADA.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtLBS_ENTREGADA.Value = value
        End Set
    End Property

    Public Property VALOR_ENTREGADA() As Decimal
        Get
            If Me.txtVALOR_ENTREGADA.Value Is Nothing Then Return -1
            Return Me.txtVALOR_ENTREGADA.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtVALOR_ENTREGADA.Value = value
        End Set
    End Property

    Public Property MZ_CENSO() As Decimal
        Get
            If Me.txtMZ_CENSO.Value Is Nothing Then Return -1
            Return Me.txtMZ_CENSO.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtMZ_CENSO.Value = value
        End Set
    End Property

    Public Property TONEL_MZ_CENSO() As Decimal
        Get
            If Me.txtTONEL_MZ_CENSO.Value Is Nothing Then Return -1
            Return Me.txtTONEL_MZ_CENSO.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtTONEL_MZ_CENSO.Value = value
        End Set
    End Property

    Public Property TONEL_CENSO() As Decimal
        Get
            If Me.txtTONEL_CENSO.Value Is Nothing Then Return -1
            Return Me.txtTONEL_CENSO.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtTONEL_CENSO.Value = value
        End Set
    End Property

    Public Property LBS_CENSO() As Decimal
        Get
            If Me.txtLBS_CENSO.Value Is Nothing Then Return -1
            Return Me.txtLBS_CENSO.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtLBS_CENSO.Value = value
        End Set
    End Property

    Public Property VALOR_CENSO() As Decimal
        Get
            If Me.txtVALOR_CENSO.Value Is Nothing Then Return -1
            Return Me.txtVALOR_CENSO.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtVALOR_CENSO.Value = value
        End Set
    End Property

    Public Property FIN_LOTE() As Boolean
        Get
            Return Me.cbxFIN_LOTE.Checked
        End Get
        Set(ByVal value As Boolean)
            Me.cbxFIN_LOTE.Checked = value
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

    Public Property CODIAGRON() As String
        Get
            Return Me.ddlAGRONOMOCODIAGRON.SelectedValue
        End Get
        Set(ByVal value As String)
            If Not Me.ddlAGRONOMOCODIAGRON.Items.FindByValue(value) Is Nothing Then
                Me.ddlAGRONOMOCODIAGRON.SelectedValue = value
            End If
        End Set
    End Property

    Public Property FECHA_SIEMBRA() As DateTime
        Get
            Return Me.deFECHA_SIEMBRA.Value
        End Get
        Set(ByVal value As DateTime)
            Me.deFECHA_SIEMBRA.Value = value
        End Set
    End Property


    Public Property FAB_SEMANA() As Int32
        Get
            If Me.txtFAB_SEMANA.Value Is Nothing Then Return -1
            Return CInt(Me.txtFAB_SEMANA.Value)
        End Get
        Set(ByVal value As Int32)
            Me.txtFAB_SEMANA.Value = value
        End Set
    End Property

    Public Property FAB_CATORCENA() As Int32
        Get
            If Me.txtFAB_CATORCENA.Value Is Nothing Then Return -1
            Return CInt(Me.txtFAB_CATORCENA.Value)
        End Get
        Set(ByVal value As Int32)
            Me.txtFAB_CATORCENA.Value = value
        End Set
    End Property

    Public Property FAB_SUBTERCIO() As String
        Get
            Return Me.txtFAB_SUBTERCIO.Text
        End Get
        Set(ByVal value As String)
            Me.txtFAB_SUBTERCIO.Text = value.ToString()
        End Set
    End Property

    Public Property FAB_TERCIO() As Int32
        Get
            If Me.txtFAB_TERCIO.Value Is Nothing Then Return -1
            Return CInt(Me.txtFAB_TERCIO.Value)
        End Get
        Set(ByVal value As Int32)
            Me.txtFAB_TERCIO.Value = value
        End Set
    End Property

    Public Property TARIFA_ROZA() As Decimal
        Get
            If Me.txtTARIFA_ROZA.Value Is Nothing Then Return -1
            Return Me.txtTARIFA_ROZA.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtTARIFA_ROZA.Value = value
        End Set
    End Property

    Public Property TARIFA_ALZA() As Decimal
        Get
            If Me.txtTARIFA_ALZA.Value Is Nothing Then Return -1
            Return Me.txtTARIFA_ALZA.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtTARIFA_ALZA.Value = value
        End Set
    End Property

    Public Property TARIFA_TRANS() As Decimal
        Get
            If Me.txtTARIFA_TRANS.Value Is Nothing Then Return -1
            Return Me.txtTARIFA_TRANS.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtTARIFA_TRANS.Value = value
        End Set
    End Property

    Public Property TARIFA_CORTA() As Decimal
        Get
            If Me.txtTARIFA_CORTA.Value Is Nothing Then Return -1
            Return Me.txtTARIFA_CORTA.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtTARIFA_CORTA.Value = value
        End Set
    End Property

    Public Property TARIFA_LARGA() As Decimal
        Get
            If Me.txtTARIFA_LARGA.Value Is Nothing Then Return -1
            Return Me.txtTARIFA_LARGA.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtTARIFA_LARGA.Value = value
        End Set
    End Property

    Public Property SALDO_ROZA() As Decimal
        Get
            If Me.txtSALDO_ROZA.Value Is Nothing Then Return -1
            Return Me.txtSALDO_ROZA.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtSALDO_ROZA.Value = value
        End Set
    End Property

    Public Property EDAD_LOTE() As Int32
        Get
            If Me.txtEDAD_LOTE.Value Is Nothing Then Return -1
            Return CInt(Me.txtEDAD_LOTE.Value)
        End Get
        Set(ByVal value As Int32)
            Me.txtEDAD_LOTE.Value = value
        End Set
    End Property

    Public Property SALDO_QUEMA() As Decimal
        Get
            If Me.txtSALDO_QUEMA.Value Is Nothing Then Return -1
            Return Me.txtSALDO_QUEMA.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtSALDO_QUEMA.Value = value
        End Set
    End Property

    Public Property VerID_LOTES_COSECHA() As Boolean
        Get
            Return Me.trID_LOTES_COSECHA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_LOTES_COSECHA.Visible = value
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

    Public Property VerID_ZAFRA() As Boolean
        Get
            Return Me.trID_ZAFRA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_ZAFRA.Visible = value
        End Set
    End Property

    Public Property VerFECHA_ROZA() As Boolean
        Get
            Return Me.trFECHA_ROZA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFECHA_ROZA.Visible = value
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

    Public Property VerMZ_ENTREGAR() As Boolean
        Get
            Return Me.trMZ_ENTREGAR.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trMZ_ENTREGAR.Visible = value
        End Set
    End Property

    Public Property VerTONEL_MZ_ENTREGAR() As Boolean
        Get
            Return Me.trTONEL_MZ_ENTREGAR.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTONEL_MZ_ENTREGAR.Visible = value
        End Set
    End Property

    Public Property VerTONEL_ENTREGAR() As Boolean
        Get
            Return Me.trTONEL_ENTREGAR.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTONEL_ENTREGAR.Visible = value
        End Set
    End Property

    Public Property VerLBS_ENTREGAR() As Boolean
        Get
            Return Me.trLBS_ENTREGAR.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trLBS_ENTREGAR.Visible = value
        End Set
    End Property

    Public Property VerVALOR_ENTREGAR() As Boolean
        Get
            Return Me.trVALOR_ENTREGAR.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trVALOR_ENTREGAR.Visible = value
        End Set
    End Property

    Public Property VerMZ_ENTREGADA() As Boolean
        Get
            Return Me.trMZ_ENTREGADA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trMZ_ENTREGADA.Visible = value
        End Set
    End Property

    Public Property VerTONEL_MZ_ENTREGADA() As Boolean
        Get
            Return Me.trTONEL_MZ_ENTREGADA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTONEL_MZ_ENTREGADA.Visible = value
        End Set
    End Property

    Public Property VerTONEL_ENTREGADA() As Boolean
        Get
            Return Me.trTONEL_ENTREGADA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTONEL_ENTREGADA.Visible = value
        End Set
    End Property

    Public Property VerLBS_ENTREGADA() As Boolean
        Get
            Return Me.trLBS_ENTREGADA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trLBS_ENTREGADA.Visible = value
        End Set
    End Property

    Public Property VerVALOR_ENTREGADA() As Boolean
        Get
            Return Me.trVALOR_ENTREGADA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trVALOR_ENTREGADA.Visible = value
        End Set
    End Property

    Public Property VerMZ_CENSO() As Boolean
        Get
            Return Me.trMZ_CENSO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trMZ_CENSO.Visible = value
        End Set
    End Property

    Public Property VerTONEL_MZ_CENSO() As Boolean
        Get
            Return Me.trTONEL_MZ_CENSO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTONEL_MZ_CENSO.Visible = value
        End Set
    End Property

    Public Property VerTONEL_CENSO() As Boolean
        Get
            Return Me.trTONEL_CENSO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTONEL_CENSO.Visible = value
        End Set
    End Property

    Public Property VerLBS_CENSO() As Boolean
        Get
            Return Me.trLBS_CENSO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trLBS_CENSO.Visible = value
        End Set
    End Property

    Public Property VerVALOR_CENSO() As Boolean
        Get
            Return Me.trVALOR_CENSO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trVALOR_CENSO.Visible = value
        End Set
    End Property

    Public Property VerFIN_LOTE() As Boolean
        Get
            Return Me.trFIN_LOTE.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFIN_LOTE.Visible = value
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

    Public Property VerCODIAGRON() As Boolean
        Get
            Return Me.trCODIAGRON.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCODIAGRON.Visible = value
        End Set
    End Property

    Public Property VerFECHA_SIEMBRA() As Boolean
        Get
            Return Me.trFECHA_SIEMBRA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFECHA_SIEMBRA.Visible = value
        End Set
    End Property

    Public Property VerFAB_SEMANA() As Boolean
        Get
            Return Me.trFAB_SEMANA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFAB_SEMANA.Visible = value
        End Set
    End Property

    Public Property VerFAB_CATORCENA() As Boolean
        Get
            Return Me.trFAB_CATORCENA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFAB_CATORCENA.Visible = value
        End Set
    End Property

    Public Property VerFAB_SUBTERCIO() As Boolean
        Get
            Return Me.trFAB_SUBTERCIO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFAB_SUBTERCIO.Visible = value
        End Set
    End Property

    Public Property VerFAB_TERCIO() As Boolean
        Get
            Return Me.trFAB_TERCIO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFAB_TERCIO.Visible = value
        End Set
    End Property

    Public Property VerTARIFA_ROZA() As Boolean
        Get
            Return Me.trTARIFA_ROZA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTARIFA_ROZA.Visible = value
        End Set
    End Property

    Public Property VerTARIFA_ALZA() As Boolean
        Get
            Return Me.trTARIFA_ALZA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTARIFA_ALZA.Visible = value
        End Set
    End Property

    Public Property VerTARIFA_TRANS() As Boolean
        Get
            Return Me.trTARIFA_TRANS.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTARIFA_TRANS.Visible = value
        End Set
    End Property

    Public Property VerTARIFA_CORTA() As Boolean
        Get
            Return Me.trTARIFA_CORTA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTARIFA_CORTA.Visible = value
        End Set
    End Property

    Public Property VerTARIFA_LARGA() As Boolean
        Get
            Return Me.trTARIFA_LARGA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTARIFA_LARGA.Visible = value
        End Set
    End Property

    Public Property VerSALDO_ROZA() As Boolean
        Get
            Return Me.trSALDO_ROZA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trSALDO_ROZA.Visible = value
        End Set
    End Property

    Public Property VerEDAD_LOTE() As Boolean
        Get
            Return Me.trEDAD_LOTE.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trEDAD_LOTE.Visible = value
        End Set
    End Property

    Public Property VerSALDO_QUEMA() As Boolean
        Get
            Return Me.trSALDO_QUEMA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trSALDO_QUEMA.Visible = value
        End Set
    End Property

    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cLOTES_COSECHA
    Private mEntidad As LOTES_COSECHA
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
        If Not Me.ViewState("ID_LOTES_COSECHA") Is Nothing Then Me._ID_LOTES_COSECHA = Me.ViewState("ID_LOTES_COSECHA")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla LOTES_COSECHA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New LOTES_COSECHA
        mEntidad.ID_LOTES_COSECHA = ID_LOTES_COSECHA
 
        If mComponente.ObtenerLOTES_COSECHA(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_LOTES_COSECHA.Text = mEntidad.ID_LOTES_COSECHA.ToString()
        Me.ddlLOTESACCESLOTE.Recuperar()
        Me.ddlLOTESACCESLOTE.SelectedValue = mEntidad.ACCESLOTE
        Me.ddlZAFRAID_ZAFRA.Recuperar()
        Me.ddlZAFRAID_ZAFRA.SelectedValue = mEntidad.ID_ZAFRA
        Me.deFECHA_ROZA.Value = mEntidad.FECHA_ROZA
        Me.txtREND_COSECHA.Value = mEntidad.REND_COSECHA
        Me.txtMZ_ENTREGAR.Value = mEntidad.MZ_ENTREGAR
        Me.txtTONEL_MZ_ENTREGAR.Value = mEntidad.TONEL_MZ_ENTREGAR
        Me.txtTONEL_ENTREGAR.Value = mEntidad.TONEL_ENTREGAR
        Me.txtLBS_ENTREGAR.Value = mEntidad.LBS_ENTREGAR
        Me.txtVALOR_ENTREGAR.Value = mEntidad.VALOR_ENTREGAR
        Me.txtMZ_ENTREGADA.Value = mEntidad.MZ_ENTREGADA
        Me.txtTONEL_MZ_ENTREGADA.Value = mEntidad.TONEL_MZ_ENTREGADA
        Me.txtTONEL_ENTREGADA.Value = mEntidad.TONEL_ENTREGADA
        Me.txtLBS_ENTREGADA.Value = mEntidad.LBS_ENTREGADA
        Me.txtVALOR_ENTREGADA.Value = mEntidad.VALOR_ENTREGADA
        Me.txtMZ_CENSO.Value = mEntidad.MZ_CENSO
        Me.txtTONEL_MZ_CENSO.Value = mEntidad.TONEL_MZ_CENSO
        Me.txtTONEL_CENSO.Value = mEntidad.TONEL_CENSO
        Me.txtLBS_CENSO.Value = mEntidad.LBS_CENSO
        Me.txtVALOR_CENSO.Value = mEntidad.VALOR_CENSO
        Me.cbxFIN_LOTE.Checked = mEntidad.FIN_LOTE
        Me.txtUSUARIO_CREA.Text = mEntidad.USUARIO_CREA
        Me.deFECHA_CREA.Value = mEntidad.FECHA_CREA
        Me.txtUSUARIO_ACT.Text = mEntidad.USUARIO_ACT
        Me.deFECHA_ACT.Value = mEntidad.FECHA_ACT
        Me.ddlAGRONOMOCODIAGRON.Recuperar()
        Me.ddlAGRONOMOCODIAGRON.SelectedValue = mEntidad.CODIAGRON
        Me.deFECHA_SIEMBRA.Value = mEntidad.FECHA_SIEMBRA
        Me.txtFAB_SEMANA.Value = mEntidad.FAB_SEMANA
        Me.txtFAB_CATORCENA.Value = mEntidad.FAB_CATORCENA
        Me.txtFAB_SUBTERCIO.Text = mEntidad.FAB_SUBTERCIO
        Me.txtFAB_TERCIO.Value = mEntidad.FAB_TERCIO
        Me.txtTARIFA_ROZA.Value = mEntidad.TARIFA_ROZA
        Me.txtTARIFA_ALZA.Value = mEntidad.TARIFA_ALZA
        Me.txtTARIFA_TRANS.Value = mEntidad.TARIFA_TRANS
        Me.txtTARIFA_CORTA.Value = mEntidad.TARIFA_CORTA
        Me.txtTARIFA_LARGA.Value = mEntidad.TARIFA_LARGA
        Me.txtSALDO_ROZA.Value = mEntidad.SALDO_ROZA
        Me.txtEDAD_LOTE.Value = mEntidad.EDAD_LOTE
        Me.txtSALDO_QUEMA.Value = mEntidad.SALDO_QUEMA
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.ddlLOTESACCESLOTE.Enabled = edicion
        Me.ddlZAFRAID_ZAFRA.Enabled = edicion
        Me.ddlAGRONOMOCODIAGRON.Enabled = edicion
        Me.deFECHA_ROZA.Enabled = edicion
        Me.txtREND_COSECHA.Enabled = edicion
        Me.txtMZ_ENTREGAR.Enabled = edicion
        Me.txtTONEL_MZ_ENTREGAR.Enabled = edicion
        Me.txtTONEL_ENTREGAR.Enabled = edicion
        Me.txtLBS_ENTREGAR.Enabled = edicion
        Me.txtVALOR_ENTREGAR.Enabled = edicion
        Me.txtMZ_ENTREGADA.Enabled = edicion
        Me.txtTONEL_MZ_ENTREGADA.Enabled = edicion
        Me.txtTONEL_ENTREGADA.Enabled = edicion
        Me.txtLBS_ENTREGADA.Enabled = edicion
        Me.txtVALOR_ENTREGADA.Enabled = edicion
        Me.txtMZ_CENSO.Enabled = edicion
        Me.txtTONEL_MZ_CENSO.Enabled = edicion
        Me.txtTONEL_CENSO.Enabled = edicion
        Me.txtLBS_CENSO.Enabled = edicion
        Me.txtVALOR_CENSO.Enabled = edicion
        Me.cbxFIN_LOTE.Enabled = edicion
        Me.txtUSUARIO_CREA.Enabled = edicion
        Me.deFECHA_CREA.Enabled = edicion
        Me.txtUSUARIO_ACT.Enabled = edicion
        Me.deFECHA_ACT.Enabled = edicion
        Me.deFECHA_SIEMBRA.Enabled = edicion
        Me.txtFAB_SEMANA.Enabled = edicion
        Me.txtFAB_CATORCENA.Enabled = edicion
        Me.txtFAB_SUBTERCIO.Enabled = edicion
        Me.txtFAB_TERCIO.Enabled = edicion
        Me.txtTARIFA_ROZA.Enabled = edicion
        Me.txtTARIFA_ALZA.Enabled = edicion
        Me.txtTARIFA_TRANS.Enabled = edicion
        Me.txtTARIFA_CORTA.Enabled = edicion
        Me.txtTARIFA_LARGA.Enabled = edicion
        Me.txtSALDO_ROZA.Enabled = edicion
        Me.txtEDAD_LOTE.Enabled = edicion
        Me.txtSALDO_QUEMA.Enabled = edicion
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.ddlLOTESACCESLOTE.Recuperar()
        Me.ddlZAFRAID_ZAFRA.Recuperar()
        Me.ddlAGRONOMOCODIAGRON.Recuperar()
        Me.deFECHA_ROZA.Value = Nothing
        Me.txtREND_COSECHA.Value = Nothing
        Me.txtMZ_ENTREGAR.Value = Nothing
        Me.txtTONEL_MZ_ENTREGAR.Value = Nothing
        Me.txtTONEL_ENTREGAR.Value = Nothing
        Me.txtLBS_ENTREGAR.Value = Nothing
        Me.txtVALOR_ENTREGAR.Value = Nothing
        Me.txtMZ_ENTREGADA.Value = Nothing
        Me.txtTONEL_MZ_ENTREGADA.Value = Nothing
        Me.txtTONEL_ENTREGADA.Value = Nothing
        Me.txtLBS_ENTREGADA.Value = Nothing
        Me.txtVALOR_ENTREGADA.Value = Nothing
        Me.txtMZ_CENSO.Value = Nothing
        Me.txtTONEL_MZ_CENSO.Value = Nothing
        Me.txtTONEL_CENSO.Value = Nothing
        Me.txtLBS_CENSO.Value = Nothing
        Me.txtVALOR_CENSO.Value = Nothing
        Me.cbxFIN_LOTE.Checked = False
        Me.txtUSUARIO_CREA.Text = ""
        Me.deFECHA_CREA.Value = Nothing
        Me.txtUSUARIO_ACT.Text = ""
        Me.deFECHA_ACT.Value = Nothing
        Me.deFECHA_SIEMBRA.Value = Nothing
        Me.txtFAB_SEMANA.Value = Nothing
        Me.txtFAB_CATORCENA.Value = Nothing
        Me.txtFAB_SUBTERCIO.Text = ""
        Me.txtFAB_TERCIO.Value = Nothing
        Me.txtTARIFA_ROZA.Value = Nothing
        Me.txtTARIFA_ALZA.Value = Nothing
        Me.txtTARIFA_TRANS.Value = Nothing
        Me.txtTARIFA_CORTA.Value = Nothing
        Me.txtTARIFA_LARGA.Value = Nothing
        Me.txtSALDO_ROZA.Value = Nothing
        Me.txtEDAD_LOTE.Value = Nothing
        Me.txtSALDO_QUEMA.Value = Nothing
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla LOTES_COSECHA
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        mEntidad = New LOTES_COSECHA
        If Me._nuevo Then
            mEntidad.ID_LOTES_COSECHA = 0
        Else
            mEntidad.ID_LOTES_COSECHA = CInt(Me.txtID_LOTES_COSECHA.Text)
        End If
        mEntidad.ACCESLOTE = Me.ddlLOTESACCESLOTE.SelectedValue
        mEntidad.ID_ZAFRA = Me.ddlZAFRAID_ZAFRA.SelectedValue
        mEntidad.FECHA_ROZA = Me.deFECHA_ROZA.Value
        mEntidad.REND_COSECHA = Me.txtREND_COSECHA.Value
        mEntidad.MZ_ENTREGAR = Me.txtMZ_ENTREGAR.Value
        mEntidad.TONEL_MZ_ENTREGAR = Me.txtTONEL_MZ_ENTREGAR.Value
        mEntidad.TONEL_ENTREGAR = Me.txtTONEL_ENTREGAR.Value
        mEntidad.LBS_ENTREGAR = Me.txtLBS_ENTREGAR.Value
        mEntidad.VALOR_ENTREGAR = Me.txtVALOR_ENTREGAR.Value
        mEntidad.MZ_ENTREGADA = Me.txtMZ_ENTREGADA.Value
        mEntidad.TONEL_MZ_ENTREGADA = Me.txtTONEL_MZ_ENTREGADA.Value
        mEntidad.TONEL_ENTREGADA = Me.txtTONEL_ENTREGADA.Value
        mEntidad.LBS_ENTREGADA = Me.txtLBS_ENTREGADA.Value
        mEntidad.VALOR_ENTREGADA = Me.txtVALOR_ENTREGADA.Value
        mEntidad.MZ_CENSO = Me.txtMZ_CENSO.Value
        mEntidad.TONEL_MZ_CENSO = Me.txtTONEL_MZ_CENSO.Value
        mEntidad.TONEL_CENSO = Me.txtTONEL_CENSO.Value
        mEntidad.LBS_CENSO = Me.txtLBS_CENSO.Value
        mEntidad.VALOR_CENSO = Me.txtVALOR_CENSO.Value
        mEntidad.FIN_LOTE = Me.cbxFIN_LOTE.Checked
        mEntidad.USUARIO_CREA = Me.txtUSUARIO_CREA.Text
        mEntidad.FECHA_CREA = Me.deFECHA_CREA.Value
        mEntidad.USUARIO_ACT = Me.txtUSUARIO_ACT.Text
        mEntidad.FECHA_ACT = Me.deFECHA_ACT.Value
        mEntidad.CODIAGRON = Me.ddlAGRONOMOCODIAGRON.SelectedValue
        mEntidad.FECHA_SIEMBRA = Me.deFECHA_SIEMBRA.Value
        mEntidad.FAB_SEMANA = Me.txtFAB_SEMANA.Value
        mEntidad.FAB_CATORCENA = Me.txtFAB_CATORCENA.Value
        mEntidad.FAB_SUBTERCIO = Me.txtFAB_SUBTERCIO.Text
        mEntidad.FAB_TERCIO = Me.txtFAB_TERCIO.Value
        mEntidad.TARIFA_ROZA = Me.txtTARIFA_ROZA.Value
        mEntidad.TARIFA_ALZA = Me.txtTARIFA_ALZA.Value
        mEntidad.TARIFA_TRANS = Me.txtTARIFA_TRANS.Value
        mEntidad.TARIFA_CORTA = Me.txtTARIFA_CORTA.Value
        mEntidad.TARIFA_LARGA = Me.txtTARIFA_LARGA.Value
        mEntidad.SALDO_ROZA = Me.txtSALDO_ROZA.Value
        mEntidad.EDAD_LOTE = Me.txtEDAD_LOTE.Value
        mEntidad.SALDO_QUEMA = Me.txtSALDO_QUEMA.Value

        If mComponente.ActualizarLOTES_COSECHA(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_LOTES_COSECHA.Text = mEntidad.ID_LOTES_COSECHA.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
