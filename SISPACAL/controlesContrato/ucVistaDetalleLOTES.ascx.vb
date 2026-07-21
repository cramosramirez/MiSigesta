Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetalleLOTES
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla LOTES
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	23/06/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleLOTES
    Inherits ucBase
 
#Region"Propiedades"

    Private _ACCESLOTE As String
    Public Property ACCESLOTE() As String
        Get
            Return Me.txtACCESLOTE.Text
        End Get
        Set(ByVal Value As String)
            Me._ACCESLOTE = Value
            Me.txtACCESLOTE.Text = Value
            If Me._ACCESLOTE <> "" Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property ANIOZAFRA() As String
        Get
            Return Me.txtANIOZAFRA.Text
        End Get
        Set(ByVal value As String)
            Me.txtANIOZAFRA.Text = value.ToString()
        End Set
    End Property

    Public Property CODIPROVEEDOR() As String
        Get
            Return Me.ddlPROVEEDORCODIPROVEEDOR.SelectedValue
        End Get
        Set(ByVal value As String)
            If Not Me.ddlPROVEEDORCODIPROVEEDOR.Items.FindByValue(value) Is Nothing Then
                Me.ddlPROVEEDORCODIPROVEEDOR.SelectedValue = value
            End If
        End Set
    End Property

    Public Property CODILOTE() As String
        Get
            Return Me.txtCODILOTE.Text
        End Get
        Set(ByVal value As String)
            Me.txtCODILOTE.Text = value.ToString()
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

    Public Property CODIVARIEDA() As String
        Get
            Return Me.ddlVARIEDADCODIVARIEDA.SelectedValue
        End Get
        Set(ByVal value As String)
            If Not Me.ddlVARIEDADCODIVARIEDA.Items.FindByValue(value) Is Nothing Then
                Me.ddlVARIEDADCODIVARIEDA.SelectedValue = value
            End If
        End Set
    End Property

    Public Property CODIUBICACION() As String
        Get
            Return Me.ddlUBICACIONCODIUBICACION.SelectedValue
        End Get
        Set(ByVal value As String)
            If Not Me.ddlUBICACIONCODIUBICACION.Items.FindByValue(value) Is Nothing Then
                Me.ddlUBICACIONCODIUBICACION.SelectedValue = value
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

    Public Property NOMBLOTE() As String
        Get
            Return Me.txtNOMBLOTE.Text
        End Get
        Set(ByVal value As String)
            Me.txtNOMBLOTE.Text = value.ToString()
        End Set
    End Property

    Public Property AREA() As Decimal
        Get
            If Me.txtAREA.Value Is Nothing Then Return -1
            Return Me.txtAREA.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtAREA.Value = value
        End Set
    End Property

    Public Property TONELADAS() As Decimal
        Get
            If Me.txtTONELADAS.Value Is Nothing Then Return -1
            Return Me.txtTONELADAS.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtTONELADAS.Value = value
        End Set
    End Property

    Public Property TONEL_TC() As Decimal
        Get
            If Me.txtTONEL_TC.Value Is Nothing Then Return -1
            Return Me.txtTONEL_TC.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtTONEL_TC.Value = value
        End Set
    End Property

    Public Property ZONA() As String
        Get
            Return Me.txtZONA.Text
        End Get
        Set(ByVal value As String)
            Me.txtZONA.Text = value.ToString()
        End Set
    End Property

    Public Property EDAD_LOTE() As Decimal
        Get
            If Me.txtEDAD_LOTE.Value Is Nothing Then Return -1
            Return Me.txtEDAD_LOTE.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtEDAD_LOTE.Value = value
        End Set
    End Property

    Public Property FFCHPROXENT() As DateTime
        Get
            Return Me.deFFCHPROXENT.Value
        End Get
        Set(ByVal value As DateTime)
            Me.deFFCHPROXENT.Value = value
        End Set
    End Property

    Public Property TONXENTREGAR() As Decimal
        Get
            If Me.txtTONXENTREGAR.Value Is Nothing Then Return -1
            Return Me.txtTONXENTREGAR.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtTONXENTREGAR.Value = value
        End Set
    End Property

    Public Property ENTREGADA() As Int32
        Get
            If Me.txtENTREGADA.Value Is Nothing Then Return -1
            Return CInt(Me.txtENTREGADA.Value)
        End Get
        Set(ByVal value As Int32)
            Me.txtENTREGADA.Value = value
        End Set
    End Property

    Public Property USER_CREA() As Int32
        Get
            If Me.txtUSER_CREA.Value Is Nothing Then Return -1
            Return CInt(Me.txtUSER_CREA.Value)
        End Get
        Set(ByVal value As Int32)
            Me.txtUSER_CREA.Value = value
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

    Public Property USER_ACT() As Int32
        Get
            If Me.txtUSER_ACT.Value Is Nothing Then Return -1
            Return CInt(Me.txtUSER_ACT.Value)
        End Get
        Set(ByVal value As Int32)
            Me.txtUSER_ACT.Value = value
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

    Public Property fin_lote() As Boolean
        Get
            Return Me.cbxfin_lote.Checked
        End Get
        Set(ByVal value As Boolean)
            Me.cbxfin_lote.Checked = value
        End Set
    End Property

    Public Property REND_CONTRATADO() As Decimal
        Get
            If Me.txtREND_CONTRATADO.Value Is Nothing Then Return -1
            Return Me.txtREND_CONTRATADO.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtREND_CONTRATADO.Value = value
        End Set
    End Property

    Public Property LBS_CONTRATADO() As Decimal
        Get
            If Me.txtLBS_CONTRATADO.Value Is Nothing Then Return -1
            Return Me.txtLBS_CONTRATADO.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtLBS_CONTRATADO.Value = value
        End Set
    End Property

    Public Property VALOR_CONTRATADO() As Decimal
        Get
            If Me.txtVALOR_CONTRATADO.Value Is Nothing Then Return -1
            Return Me.txtVALOR_CONTRATADO.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtVALOR_CONTRATADO.Value = value
        End Set
    End Property

    Public Property REND_ENTREGADA() As Decimal
        Get
            If Me.txtREND_ENTREGADA.Value Is Nothing Then Return -1
            Return Me.txtREND_ENTREGADA.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtREND_ENTREGADA.Value = value
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

    Public Property CODIGO_LOTE() As String
        Get
            Return Me.ddlMAESTRO_LOTESCODIGO_LOTE.SelectedValue
        End Get
        Set(ByVal value As String)
            If Not Me.ddlMAESTRO_LOTESCODIGO_LOTE.Items.FindByValue(value) Is Nothing Then
                Me.ddlMAESTRO_LOTESCODIGO_LOTE.SelectedValue = value
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

    Public Property VerACCESLOTE() As Boolean
        Get
            Return Me.trACCESLOTE.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trACCESLOTE.Visible = value
        End Set
    End Property

    Public Property VerANIOZAFRA() As Boolean
        Get
            Return Me.trANIOZAFRA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trANIOZAFRA.Visible = value
        End Set
    End Property

    Public Property VerCODIPROVEEDOR() As Boolean
        Get
            Return Me.trCODIPROVEEDOR.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCODIPROVEEDOR.Visible = value
        End Set
    End Property

    Public Property VerCODILOTE() As Boolean
        Get
            Return Me.trCODILOTE.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCODILOTE.Visible = value
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

    Public Property VerCODIVARIEDA() As Boolean
        Get
            Return Me.trCODIVARIEDA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCODIVARIEDA.Visible = value
        End Set
    End Property

    Public Property VerCODIUBICACION() As Boolean
        Get
            Return Me.trCODIUBICACION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCODIUBICACION.Visible = value
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

    Public Property VerNOMBLOTE() As Boolean
        Get
            Return Me.trNOMBLOTE.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNOMBLOTE.Visible = value
        End Set
    End Property

    Public Property VerAREA() As Boolean
        Get
            Return Me.trAREA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trAREA.Visible = value
        End Set
    End Property

    Public Property VerTONELADAS() As Boolean
        Get
            Return Me.trTONELADAS.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTONELADAS.Visible = value
        End Set
    End Property

    Public Property VerTONEL_TC() As Boolean
        Get
            Return Me.trTONEL_TC.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTONEL_TC.Visible = value
        End Set
    End Property

    Public Property VerZONA() As Boolean
        Get
            Return Me.trZONA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trZONA.Visible = value
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

    Public Property VerFFCHPROXENT() As Boolean
        Get
            Return Me.trFFCHPROXENT.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFFCHPROXENT.Visible = value
        End Set
    End Property

    Public Property VerTONXENTREGAR() As Boolean
        Get
            Return Me.trTONXENTREGAR.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTONXENTREGAR.Visible = value
        End Set
    End Property

    Public Property VerENTREGADA() As Boolean
        Get
            Return Me.trENTREGADA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trENTREGADA.Visible = value
        End Set
    End Property

    Public Property VerUSER_CREA() As Boolean
        Get
            Return Me.trUSER_CREA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trUSER_CREA.Visible = value
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

    Public Property VerUSER_ACT() As Boolean
        Get
            Return Me.trUSER_ACT.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trUSER_ACT.Visible = value
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

    Public Property Verfin_lote() As Boolean
        Get
            Return Me.trfin_lote.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trfin_lote.Visible = value
        End Set
    End Property

    Public Property VerREND_CONTRATADO() As Boolean
        Get
            Return Me.trREND_CONTRATADO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trREND_CONTRATADO.Visible = value
        End Set
    End Property

    Public Property VerLBS_CONTRATADO() As Boolean
        Get
            Return Me.trLBS_CONTRATADO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trLBS_CONTRATADO.Visible = value
        End Set
    End Property

    Public Property VerVALOR_CONTRATADO() As Boolean
        Get
            Return Me.trVALOR_CONTRATADO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trVALOR_CONTRATADO.Visible = value
        End Set
    End Property

    Public Property VerREND_ENTREGADA() As Boolean
        Get
            Return Me.trREND_ENTREGADA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trREND_ENTREGADA.Visible = value
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

    Public Property VerCODIGO_LOTE() As Boolean
        Get
            Return Me.trCODIGO_LOTE.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCODIGO_LOTE.Visible = value
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

    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cLOTES
    Private mEntidad As LOTES
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
        If Not Me.ViewState("ACCESLOTE") Is Nothing Then Me._ACCESLOTE = Me.ViewState("ACCESLOTE")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla LOTES
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/06/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New LOTES
        mEntidad.ACCESLOTE = ACCESLOTE
 
        If mComponente.ObtenerLOTES(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtACCESLOTE.Text = mEntidad.ACCESLOTE
        Me.txtANIOZAFRA.Text = mEntidad.ANIOZAFRA
        Me.ddlPROVEEDORCODIPROVEEDOR.Recuperar()
        Me.ddlPROVEEDORCODIPROVEEDOR.SelectedValue = mEntidad.CODIPROVEEDOR
        Me.txtCODILOTE.Text = mEntidad.CODILOTE
        Me.ddlAGRONOMOCODIAGRON.Recuperar()
        Me.ddlAGRONOMOCODIAGRON.SelectedValue = mEntidad.CODIAGRON
        Me.ddlVARIEDADCODIVARIEDA.Recuperar()
        Me.ddlVARIEDADCODIVARIEDA.SelectedValue = mEntidad.CODIVARIEDA
        Me.ddlUBICACIONCODIUBICACION.Recuperar()
        Me.ddlUBICACIONCODIUBICACION.SelectedValue = mEntidad.CODIUBICACION
        Me.ddlCONTRATOCODICONTRATO.Recuperar()
        Me.ddlCONTRATOCODICONTRATO.SelectedValue = mEntidad.CODICONTRATO
        Me.txtNOMBLOTE.Text = mEntidad.NOMBLOTE
        Me.txtAREA.Value = mEntidad.AREA
        Me.txtTONELADAS.Value = mEntidad.TONELADAS
        Me.txtTONEL_TC.Value = mEntidad.TONEL_TC
        Me.txtZONA.Text = mEntidad.ZONA
        Me.txtEDAD_LOTE.Value = mEntidad.EDAD_LOTE
        Me.txtUSER_CREA.Value = mEntidad.USER_CREA
        Me.deFECHA_CREA.Value = mEntidad.FECHA_CREA
        Me.txtUSER_ACT.Value = mEntidad.USER_ACT
        Me.ddlZAFRAID_ZAFRA.Recuperar()
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/06/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.ddlPROVEEDORCODIPROVEEDOR.Enabled = edicion
        Me.ddlAGRONOMOCODIAGRON.Enabled = edicion
        Me.ddlVARIEDADCODIVARIEDA.Enabled = edicion
        Me.ddlUBICACIONCODIUBICACION.Enabled = edicion
        Me.ddlCONTRATOCODICONTRATO.Enabled = edicion
        Me.ddlMAESTRO_LOTESCODIGO_LOTE.Enabled = edicion
        Me.ddlZAFRAID_ZAFRA.Enabled = edicion
        Me.txtANIOZAFRA.Enabled = edicion
        Me.txtCODILOTE.Enabled = edicion
        Me.txtNOMBLOTE.Enabled = edicion
        Me.txtAREA.Enabled = edicion
        Me.txtTONELADAS.Enabled = edicion
        Me.txtTONEL_TC.Enabled = edicion
        Me.txtZONA.Enabled = edicion
        Me.txtEDAD_LOTE.Enabled = edicion
        Me.deFFCHPROXENT.Enabled = edicion
        Me.txtTONXENTREGAR.Enabled = edicion
        Me.txtENTREGADA.Enabled = edicion
        Me.txtUSER_CREA.Enabled = edicion
        Me.deFECHA_CREA.Enabled = edicion
        Me.txtUSER_ACT.Enabled = edicion
        Me.deFECHA_ACT.Enabled = edicion
        Me.cbxfin_lote.Enabled = edicion
        Me.txtREND_CONTRATADO.Enabled = edicion
        Me.txtLBS_CONTRATADO.Enabled = edicion
        Me.txtVALOR_CONTRATADO.Enabled = edicion
        Me.txtREND_ENTREGADA.Enabled = edicion
        Me.txtMZ_ENTREGADA.Enabled = edicion
        Me.txtTONEL_MZ_ENTREGADA.Enabled = edicion
        Me.txtTONEL_ENTREGADA.Enabled = edicion
        Me.txtLBS_ENTREGADA.Enabled = edicion
        Me.txtVALOR_ENTREGADA.Enabled = edicion
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/06/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.ddlPROVEEDORCODIPROVEEDOR.Recuperar()
        Me.ddlAGRONOMOCODIAGRON.Recuperar()
        Me.ddlVARIEDADCODIVARIEDA.Recuperar()
        Me.ddlUBICACIONCODIUBICACION.Recuperar()
        Me.ddlCONTRATOCODICONTRATO.Recuperar()
        Me.ddlMAESTRO_LOTESCODIGO_LOTE.Recuperar()
        Me.ddlZAFRAID_ZAFRA.Recuperar()
        Me.txtANIOZAFRA.Text = ""
        Me.txtCODILOTE.Text = ""
        Me.txtNOMBLOTE.Text = ""
        Me.txtAREA.Value = Nothing
        Me.txtTONELADAS.Value = Nothing
        Me.txtTONEL_TC.Value = Nothing
        Me.txtZONA.Text = ""
        Me.txtEDAD_LOTE.Value = Nothing
        Me.deFFCHPROXENT.Value = Nothing
        Me.txtTONXENTREGAR.Value = Nothing
        Me.txtENTREGADA.Value = Nothing
        Me.txtUSER_CREA.Value = Nothing
        Me.deFECHA_CREA.Value = Nothing
        Me.txtUSER_ACT.Value = Nothing
        Me.deFECHA_ACT.Value = Nothing
        Me.cbxfin_lote.Checked = False
        Me.txtREND_CONTRATADO.Value = Nothing
        Me.txtLBS_CONTRATADO.Value = Nothing
        Me.txtVALOR_CONTRATADO.Value = Nothing
        Me.txtREND_ENTREGADA.Value = Nothing
        Me.txtMZ_ENTREGADA.Value = Nothing
        Me.txtTONEL_MZ_ENTREGADA.Value = Nothing
        Me.txtTONEL_ENTREGADA.Value = Nothing
        Me.txtLBS_ENTREGADA.Value = Nothing
        Me.txtVALOR_ENTREGADA.Value = Nothing
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla LOTES
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/06/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        mEntidad = New LOTES
        If Me.txtACCESLOTE.Text = "0" Then
            Me.AsignarMensaje("Asigne un valor al Acceslote que sea valido", True, True)
            Return "Error"
        End If
            mEntidad.ACCESLOTE = Me.txtACCESLOTE.Text
        mEntidad.ANIOZAFRA = Me.txtANIOZAFRA.Text
        mEntidad.CODIPROVEEDOR = Me.ddlPROVEEDORCODIPROVEEDOR.SelectedValue
        mEntidad.CODILOTE = Me.txtCODILOTE.Text
        mEntidad.CODIAGRON = Me.ddlAGRONOMOCODIAGRON.SelectedValue
        mEntidad.CODIVARIEDA = Me.ddlVARIEDADCODIVARIEDA.SelectedValue
        mEntidad.CODIUBICACION = Me.ddlUBICACIONCODIUBICACION.SelectedValue
        mEntidad.CODICONTRATO = Me.ddlCONTRATOCODICONTRATO.SelectedValue
        mEntidad.NOMBLOTE = Me.txtNOMBLOTE.Text
        mEntidad.AREA = Me.txtAREA.Value
        mEntidad.TONELADAS = Me.txtTONELADAS.Value
        mEntidad.TONEL_TC = Me.txtTONEL_TC.Value
        mEntidad.ZONA = Me.txtZONA.Text
        mEntidad.EDAD_LOTE = Me.txtEDAD_LOTE.Value
        mEntidad.USER_CREA = Me.txtUSER_CREA.Value
        mEntidad.FECHA_CREA = Me.deFECHA_CREA.Value
        mEntidad.USER_ACT = Me.txtUSER_ACT.Value
        mEntidad.FECHA_ACT = Me.deFECHA_ACT.Value
        If Me._nuevo Then
            If mComponente.AgregarLOTES(mEntidad) <> 1 Then
                Me.AsignarMensaje("Error al Guardar registro.", True, True)
                Return "Error al Guardar registro."
            End If
         Else
            If mComponente.ActualizarLOTES(mEntidad) <> 1 Then
                Me.AsignarMensaje("Error al Guardar registro.", True, True)
                Return "Error al Guardar registro."
            End If
        End If
        Me.txtACCESLOTE.Text = mEntidad.ACCESLOTE.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
