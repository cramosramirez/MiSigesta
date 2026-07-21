Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucListaPROVEEDOR
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla PROVEEDOR
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	16/06/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucListaPROVEEDOR
    Inherits ucListaBase
 
    Private mComponente As New cPROVEEDOR
    Public Event Seleccionado(ByVal CODIPROVEEDOR As String) 
    Public Event Editando(ByVal CODIPROVEEDOR As String) 


#Region "ConfiguraciÃ³n Callback"
    Public Property VisibleEnCliente As Boolean
        Set(value As Boolean)
            dxgvLista.ClientVisible = value
        End Set
        Get
            Return dxgvLista.ClientVisible
        End Get
    End Property

    Private Sub CargarDatosGenericos()
        If Me.hfListaPROVEEDOR.Contains("Metodo") Then
            Select Case Me.hfListaPROVEEDOR("Metodo")
                Case "CargarDatosPorCriterios"
                    Me.CargarDatosPorCriterios()
            End Select
        End If
    End Sub

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquÃ­ el cÃ³digo de usuario para inicializar la pÃ¡gina
        Me.CargarDatosGenericos()

        If Not Me.ViewState("PermitirEditar") Is Nothing Then Me._PermitirEditar = Me.ViewState("PermitirEditar")
        If Not Me.ViewState("PermitirSeleccionar") Is Nothing Then Me._PermitirSeleccionar = Me.ViewState("PermitirSeleccionar")
        If Not Me.ViewState("TextoSeleccionar") Is Nothing Then Me._TextoSeleccionar = Me.ViewState("TextoSeleccionar")
        If Not Me.ViewState("ComandoSeleccionar") Is Nothing Then Me._ComandoSeleccionar = Me.ViewState("ComandoSeleccionar")
    End Sub

    Public Function CargarDatosPorCriteriosPostback(ByVal CODIPROVEE As String, ByVal CODISOCIO As String, ByVal APELLIDOS As String,
                                       ByVal NOMBRES As String, ByVal DUI As String, ByVal NIT As String, ByVal CREDITFISCAL As String, ByVal ID_ZAFRA_CONTRATADA As Integer,
                                       Optional soloProveedoresConContrato As Boolean = False) As Integer
        Me.odsCriterios.SelectParameters("CODIPROVEE").DefaultValue = CODIPROVEE
        Me.odsCriterios.SelectParameters("CODISOCIO").DefaultValue = CODISOCIO
        Me.odsCriterios.SelectParameters("APELLIDOS").DefaultValue = APELLIDOS
        Me.odsCriterios.SelectParameters("NOMBRES").DefaultValue = NOMBRES
        Me.odsCriterios.SelectParameters("DUI").DefaultValue = DUI
        Me.odsCriterios.SelectParameters("NIT").DefaultValue = NIT
        Me.odsCriterios.SelectParameters("CREDITFISCAL").DefaultValue = CREDITFISCAL
        Me.odsCriterios.SelectParameters("ID_ZAFRA_CONTRATADA").DefaultValue = ID_ZAFRA_CONTRATADA
        Me.odsCriterios.SelectParameters("soloProveedoresConContrato").DefaultValue = soloProveedoresConContrato
        Me.odsCriterios.DataBind()
        Me.dxgvLista.DataSourceID = "odsCriterios"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    Public Sub CargarDatosPorCriterios(ByVal CODIPROVEE As String, ByVal CODISOCIO As String, ByVal APELLIDOS As String,
                                       ByVal NOMBRES As String, ByVal DUI As String, ByVal NIT As String, ByVal CREDITFISCAL As String, ByVal ID_ZAFRA_CONTRATADA As Integer)
        Me.hfListaPROVEEDOR.Clear()
        Me.hfListaPROVEEDOR.Add("Metodo", "CargarDatosPorCriterios")
        Me.hfListaPROVEEDOR.Add("p1", CODIPROVEE)
        Me.hfListaPROVEEDOR.Add("p2", CODISOCIO)
        Me.hfListaPROVEEDOR.Add("p3", APELLIDOS)
        Me.hfListaPROVEEDOR.Add("p4", NOMBRES)
        Me.hfListaPROVEEDOR.Add("p5", DUI)
        Me.hfListaPROVEEDOR.Add("p6", NIT)
        Me.hfListaPROVEEDOR.Add("p7", CREDITFISCAL)
        Me.hfListaPROVEEDOR.Add("p8", ID_ZAFRA_CONTRATADA)
        Me.CargarDatosPorCriterios()
    End Sub

    Public Function CargarDatosPorCriterios() As Integer
        Me.odsCriterios.SelectParameters("CODIPROVEE").DefaultValue = Me.hfListaPROVEEDOR("p1")
        Me.odsCriterios.SelectParameters("CODISOCIO").DefaultValue = Me.hfListaPROVEEDOR("p2")
        Me.odsCriterios.SelectParameters("APELLIDOS").DefaultValue = Me.hfListaPROVEEDOR("p3")
        Me.odsCriterios.SelectParameters("NOMBRES").DefaultValue = Me.hfListaPROVEEDOR("p4")
        Me.odsCriterios.SelectParameters("DUI").DefaultValue = Me.hfListaPROVEEDOR("p5")
        Me.odsCriterios.SelectParameters("NIT").DefaultValue = Me.hfListaPROVEEDOR("p6")
        Me.odsCriterios.SelectParameters("CREDITFISCAL").DefaultValue = Me.hfListaPROVEEDOR("p7")
        Me.odsCriterios.SelectParameters("ID_ZAFRA_CONTRATADA").DefaultValue = Me.hfListaPROVEEDOR("p8")
        Me.odsCriterios.DataBind()
        Me.dxgvLista.DataSourceID = "odsCriterios"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function
#End Region

#Region"Propiedades"

    Public Property MostrarFooter() As Boolean
        Get
            Return Me.dxgvLista.SettingsPager.Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.SettingsPager.Visible = Value
        End Set
    End Property

    Public Property SeleccionarFilaSideServer() As Boolean
        Get
            Return Me.dxgvLista.SettingsBehavior.ProcessSelectionChangedOnServer
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.SettingsBehavior.ProcessSelectionChangedOnServer = Value
        End Set
    End Property

    Public Property SeleccionarFilaPorClick() As Boolean
        Get
            Return Me.dxgvLista.SettingsBehavior.AllowSelectByRowClick
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.SettingsBehavior.AllowSelectByRowClick = Value
        End Set
    End Property

    Public Property PermitirPaginacion() As Boolean
        Get
            If Me.dxgvLista.SettingsPager.Mode = DevExpress.Web.GridViewPagerMode.ShowPager Then
                Return True
            End If
            Return False
        End Get
        Set(ByVal Value As Boolean)
            If Value Then
                Me.dxgvLista.SettingsPager.Mode = DevExpress.Web.GridViewPagerMode.ShowPager
            Else
                Me.dxgvLista.SettingsPager.Mode = DevExpress.Web.GridViewPagerMode.ShowAllRecords
            End If
        End Set
    End Property

    Private _PermitirEditar As Boolean = True
    Public Property PermitirEditar() As Boolean
        Get
            Return _PermitirEditar
        End Get
        Set(ByVal Value As Boolean)
            _PermitirEditar = Value
            If Not Me.ViewState("PermitirEditar") Is Nothing Then Me.ViewState.Remove("PermitirEditar")
            Me.ViewState.Add("PermitirEditar", Value)
        End Set
    End Property

    Private _PermitirSeleccionar As Boolean = False
    Public Property PermitirSeleccionar() As Boolean
        Get
            Return _PermitirSeleccionar
        End Get
        Set(ByVal Value As Boolean)
            _PermitirSeleccionar = Value
            If Not Me.ViewState("PermitirSeleccionar") Is Nothing Then Me.ViewState.Remove("PermitirSeleccionar")
            Me.ViewState.Add("PermitirSeleccionar", Value)
        End Set
    End Property

    Public Property PermitirEliminar() As Boolean
        Get
            Return Me.dxgvLista.Columns("Eliminar").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("Eliminar").Visible = Value
        End Set
    End Property

    Public Property PermitirAgrupar() As Boolean
        Get
            Return Me.dxgvLista.Settings.ShowGroupPanel
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Settings.ShowGroupPanel = Value
        End Set
    End Property

    Public Property PermitirFilaDeFiltro() As Boolean
        Get
            Return Me.dxgvLista.Settings.ShowFilterRow
        End Get
        Set(ByVal value As Boolean)
            Me.dxgvLista.Settings.ShowFilterRow = value
        End Set
    End Property

    Public Property PermitirFiltroEnEncabezado() As Boolean
        Get
            Return Me.dxgvLista.Settings.ShowHeaderFilterButton
        End Get
        Set(ByVal value As Boolean)
            Me.dxgvLista.Settings.ShowHeaderFilterButton = value
        End Set
    End Property

    Public Property PermitirEditarInline() As Boolean
        Get
            Return Me.ViewState("PermitirEdicionInline")
        End Get
        Set(ByVal value As Boolean)
            Me.ViewState("PermitirEdicionInline") = value
        End Set
    End Property

    Public Property PermitirEliminarInline() As Boolean
        Get
            Return Me.ViewState("PermitirEliminacionInline")
        End Get
        Set(ByVal value As Boolean)
            Me.ViewState("PermitirEliminacionInline") = value
        End Set
    End Property

    Public Property PermitirAgregarInline() As Boolean
        Get
            Return Me.ViewState("PermitirAgregarInline")
        End Get
        Set(ByVal value As Boolean)
            Me.ViewState("PermitirAgregarInline") = value
        End Set
    End Property

    Public Property PermitirRowHotTrack() As Boolean
        Get
            Return Me.dxgvLista.SettingsBehavior.EnableRowHotTrack
        End Get
        Set(ByVal value As Boolean)
            Me.dxgvLista.SettingsBehavior.EnableRowHotTrack = value
        End Set
    End Property

    Public Property PermitirFocoEnFilas() As Boolean
        Get
            Return Me.dxgvLista.SettingsBehavior.AllowFocusedRow
        End Get
        Set(ByVal value As Boolean)
            Me.dxgvLista.SettingsBehavior.AllowFocusedRow = value
        End Set
    End Property

    Public Property PermitirSeleccionParaCombo() As Boolean
        Get
            Return Me.ViewState("PermitirSeleccionParaCombo")
        End Get
        Set(ByVal value As Boolean)
            Me.ViewState("PermitirSeleccionParaCombo") = value
        End Set
    End Property

    Public Property NombreComboCliente() As String
        Get
            Return Me.ViewState("NombreComboCliente")
        End Get
        Set(ByVal value As String)
            Me.ViewState("NombreComboCliente") = value
        End Set
    End Property

    Private _TextoSeleccionar As String = "Seleccionar"
    Public Property TextoSeleccionar() As String
        Get
            Return _TextoSeleccionar
        End Get
        Set(ByVal Value As String)
            _TextoSeleccionar = Value
            If Not Me.ViewState("TextoSeleccionar") Is Nothing Then Me.ViewState.Remove("TextoSeleccionar")
            Me.ViewState.Add("TextoSeleccionar", Value)
        End Set
    End Property

    Private _ComandoSeleccionar As String = "Select"
    Public Property ComandoSeleccionar() As String
        Get
            Return _ComandoSeleccionar
        End Get
        Set(ByVal Value As String)
            _ComandoSeleccionar = Value
            If Not Me.ViewState("ComandoSeleccionar") Is Nothing Then Me.ViewState.Remove("ComandoSeleccionar")
            Me.ViewState.Add("ComandoSeleccionar", Value)
        End Set
    End Property

    Public Property TextoHeaderSeleccionar() As String
        Get
            Return Me.dxgvLista.Columns("Seleccionar").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("Seleccionar").Caption = Value
        End Set
    End Property

    Public Property NombreGridCliente() As String
        Get
            Return dxgvLista.ClientInstanceName
        End Get
        Set(ByVal value As String)
            dxgvLista.ClientInstanceName = value
        End Set
    End Property

    Public Property VerCODIPROVEEDOR() As Boolean
        Get
            Return Me.dxgvLista.Columns("CODIPROVEEDOR").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CODIPROVEEDOR").Visible = Value
        End Set
    End Property

    Public Property VerCODIPROVEE() As Boolean
        Get
            Return Me.dxgvLista.Columns("CODIPROVEE").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CODIPROVEE").Visible = Value
        End Set
    End Property

    Public Property VerCODISOCIO() As Boolean
        Get
            Return Me.dxgvLista.Columns("CODISOCIO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CODISOCIO").Visible = Value
        End Set
    End Property

    Public Property VerAPELLIDOS() As Boolean
        Get
            Return Me.dxgvLista.Columns("APELLIDOS").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("APELLIDOS").Visible = Value
        End Set
    End Property

    Public Property VerNOMBRES() As Boolean
        Get
            Return Me.dxgvLista.Columns("NOMBRES").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NOMBRES").Visible = Value
        End Set
    End Property

    Public Property VerEDAD() As Boolean
        Get
            Return Me.dxgvLista.Columns("EDAD").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("EDAD").Visible = Value
        End Set
    End Property

    Public Property VerDIRECCION() As Boolean
        Get
            Return Me.dxgvLista.Columns("DIRECCION").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("DIRECCION").Visible = Value
        End Set
    End Property

    Public Property VerTELEFONO() As Boolean
        Get
            Return Me.dxgvLista.Columns("TELEFONO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TELEFONO").Visible = Value
        End Set
    End Property

    Public Property VerCORREO() As Boolean
        Get
            Return Me.dxgvLista.Columns("CORREO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CORREO").Visible = Value
        End Set
    End Property

    Public Property VerCELULAR() As Boolean
        Get
            Return Me.dxgvLista.Columns("CELULAR").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CELULAR").Visible = Value
        End Set
    End Property

    Public Property VerDUI() As Boolean
        Get
            Return Me.dxgvLista.Columns("DUI").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("DUI").Visible = Value
        End Set
    End Property

    Public Property VerNIT() As Boolean
        Get
            Return Me.dxgvLista.Columns("NIT").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NIT").Visible = Value
        End Set
    End Property

    Public Property VerCREDITFISCAL() As Boolean
        Get
            Return Me.dxgvLista.Columns("CREDITFISCAL").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CREDITFISCAL").Visible = Value
        End Set
    End Property

    Public Property VerPROFESION() As Boolean
        Get
            Return Me.dxgvLista.Columns("PROFESION").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("PROFESION").Visible = Value
        End Set
    End Property

    Public Property VerNOMBRENIT() As Boolean
        Get
            Return Me.dxgvLista.Columns("NOMBRENIT").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NOMBRENIT").Visible = Value
        End Set
    End Property

    Public Property VerAPODERADO() As Boolean
        Get
            Return Me.dxgvLista.Columns("APODERADO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("APODERADO").Visible = Value
        End Set
    End Property

    Public Property VerDUI_APODERADO() As Boolean
        Get
            Return Me.dxgvLista.Columns("DUI_APODERADO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("DUI_APODERADO").Visible = Value
        End Set
    End Property

    Public Property VerNIT_APODERADO() As Boolean
        Get
            Return Me.dxgvLista.Columns("NIT_APODERADO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NIT_APODERADO").Visible = Value
        End Set
    End Property

    Public Property VerUSER_CREA() As Boolean
        Get
            Return Me.dxgvLista.Columns("USER_CREA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("USER_CREA").Visible = Value
        End Set
    End Property

    Public Property VerFECHA_CREA() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_CREA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_CREA").Visible = Value
        End Set
    End Property

    Public Property VerUSER_ACT() As Boolean
        Get
            Return Me.dxgvLista.Columns("USER_ACT").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("USER_ACT").Visible = Value
        End Set
    End Property

    Public Property VerFECHA_ACT() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_ACT").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_ACT").Visible = Value
        End Set
    End Property

    Public Property VerFECHA_NAC() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_NAC").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_NAC").Visible = Value
        End Set
    End Property

    Public Property VerTIPO_CONTRIBUYENTE() As Boolean
        Get
            Return Me.dxgvLista.Columns("TIPO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TIPO").Visible = Value
        End Set
    End Property

    Public Property HeaderCODIPROVEEDOR() As String
        Get
            Return Me.dxgvLista.Columns("CODIPROVEEDOR").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CODIPROVEEDOR").Caption = Value
        End Set
    End Property

    Public Property HeaderCODIPROVEE() As String
        Get
            Return Me.dxgvLista.Columns("CODIPROVEE").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CODIPROVEE").Caption = Value
        End Set
    End Property

    Public Property HeaderCODISOCIO() As String
        Get
            Return Me.dxgvLista.Columns("CODISOCIO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CODISOCIO").Caption = Value
        End Set
    End Property

    Public Property HeaderAPELLIDOS() As String
        Get
            Return Me.dxgvLista.Columns("APELLIDOS").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("APELLIDOS").Caption = Value
        End Set
    End Property

    Public Property HeaderNOMBRES() As String
        Get
            Return Me.dxgvLista.Columns("NOMBRES").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("NOMBRES").Caption = Value
        End Set
    End Property

    Public Property HeaderEDAD() As String
        Get
            Return Me.dxgvLista.Columns("EDAD").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("EDAD").Caption = Value
        End Set
    End Property

    Public Property HeaderDIRECCION() As String
        Get
            Return Me.dxgvLista.Columns("DIRECCION").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("DIRECCION").Caption = Value
        End Set
    End Property

    Public Property HeaderTELEFONO() As String
        Get
            Return Me.dxgvLista.Columns("TELEFONO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TELEFONO").Caption = Value
        End Set
    End Property

    Public Property HeaderCELULAR() As String
        Get
            Return Me.dxgvLista.Columns("CELULAR").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CELULAR").Caption = Value
        End Set
    End Property

    Public Property HeaderDUI() As String
        Get
            Return Me.dxgvLista.Columns("DUI").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("DUI").Caption = Value
        End Set
    End Property

    Public Property HeaderNIT() As String
        Get
            Return Me.dxgvLista.Columns("NIT").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("NIT").Caption = Value
        End Set
    End Property

    Public Property HeaderCREDITFISCAL() As String
        Get
            Return Me.dxgvLista.Columns("CREDITFISCAL").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CREDITFISCAL").Caption = Value
        End Set
    End Property

    Public Property HeaderPROFESION() As String
        Get
            Return Me.dxgvLista.Columns("PROFESION").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("PROFESION").Caption = Value
        End Set
    End Property

    Public Property HeaderNOMBRENIT() As String
        Get
            Return Me.dxgvLista.Columns("NOMBRENIT").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("NOMBRENIT").Caption = Value
        End Set
    End Property

    Public Property HeaderAPODERADO() As String
        Get
            Return Me.dxgvLista.Columns("APODERADO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("APODERADO").Caption = Value
        End Set
    End Property

    Public Property HeaderDUI_APODERADO() As String
        Get
            Return Me.dxgvLista.Columns("DUI_APODERADO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("DUI_APODERADO").Caption = Value
        End Set
    End Property

    Public Property HeaderNIT_APODERADO() As String
        Get
            Return Me.dxgvLista.Columns("NIT_APODERADO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("NIT_APODERADO").Caption = Value
        End Set
    End Property

    Public Property HeaderUSER_CREA() As String
        Get
            Return Me.dxgvLista.Columns("USER_CREA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("USER_CREA").Caption = Value
        End Set
    End Property

    Public Property HeaderFECHA_CREA() As String
        Get
            Return Me.dxgvLista.Columns("FECHA_CREA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA_CREA").Caption = Value
        End Set
    End Property

    Public Property HeaderUSER_ACT() As String
        Get
            Return Me.dxgvLista.Columns("USER_ACT").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("USER_ACT").Caption = Value
        End Set
    End Property

    Public Property HeaderFECHA_ACT() As String
        Get
            Return Me.dxgvLista.Columns("FECHA_ACT").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA_ACT").Caption = Value
        End Set
    End Property

    Public Property HeaderFECHA_NAC() As String
        Get
            Return Me.dxgvLista.Columns("FECHA_NAC").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA_NAC").Caption = Value
        End Set
    End Property

    Public Property HeaderTIPO_CONTRIBUYENTE() As String
        Get
            Return Me.dxgvLista.Columns("TIPO_CONTRIBUYENTE").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TIPO_CONTRIBUYENTE").Caption = Value
        End Set
    End Property

#End Region


    Public Function CargarDatosPorNombreCompleto(ByVal NOMBRE_PROVEEDOR As String) As Integer
        Me.odsListaNombreCompleto.SelectParameters("NOMBRE_PROVEEDOR").DefaultValue = NOMBRE_PROVEEDOR
        Me.odsListaNombreCompleto.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaNombreCompleto"
        'Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla PROVEEDOR
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/06/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Me.odsLista.SelectParameters("recuperarHijas").DefaultValue = "False"
        Me.odsLista.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsLista.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsLista.DataBind()
        Me.dxgvLista.DataSourceID = "odsLista"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function


    Protected Sub dxgvLista_CustomJSProperties(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewClientJSPropertiesEventArgs) Handles dxgvLista.CustomJSProperties
        If Me.PermitirSeleccionParaCombo Then
            Dim grid As DevExpress.Web.ASPxGridView = CType(sender, DevExpress.Web.ASPxGridView)
            Dim keyNames(grid.VisibleRowCount - 1) As Object
            Dim keyValues(grid.VisibleRowCount - 1) As Object
            For i As Integer = 0 To grid.VisibleRowCount - 1
                keyValues(i) = grid.GetRowValues(i, "CODIPROVEEDOR")
                keyNames(i) = grid.GetRowValues(i, "CODIPROVEE")
            Next i
            e.Properties("cpKeyValues") = keyValues
            e.Properties("cpKeyNames") = keyNames
            e.Properties("cpNombreComboCliente") = Me.NombreComboCliente
        End If
    End Sub

    Protected Sub dxgvLista_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles dxgvLista.Init
        If Me.PermitirSeleccionar And Me.ComandoSeleccionar = "Check" Then
            Me.dxgvLista.Columns("Seleccionar").Visible = True
            CType(Me.dxgvLista.Columns("Seleccionar"), DevExpress.Web.GridViewCommandColumn).ShowSelectCheckbox = True
        End If
        If Me.PermitirEditarInline Or Me.PermitirAgregarInline Or Me.PermitirEliminarInline Then
            Me.dxgvLista.Columns("Edicion").Visible = True
            CType(Me.dxgvLista.Columns("Edicion"), DevExpress.Web.GridViewCommandColumn).NewButton.Visible = Me.PermitirAgregarInline
            CType(Me.dxgvLista.Columns("Edicion"), DevExpress.Web.GridViewCommandColumn).EditButton.Visible = Me.PermitirEditarInline
            CType(Me.dxgvLista.Columns("Edicion"), DevExpress.Web.GridViewCommandColumn).DeleteButton.Visible = Me.PermitirEliminarInline
        End If
        If Me.NombreComboCliente = "" Then
            Me.dxgvLista.ClientSideEvents.RowClick = ""
        End If
    End Sub

    Protected Sub dxgvLista_RowCommand(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewRowCommandEventArgs) Handles dxgvLista.RowCommand
        If e.CommandArgs.CommandName = "Select" And ComandoSeleccionar <> "Check" Then
            Me.dxgvLista.Selection.UnselectAll()
            Me.dxgvLista.Selection.SelectRow(e.VisibleIndex)
            RaiseEvent Seleccionado(e.CommandArgs.CommandArgument)
        End If
        If e.CommandArgs.CommandName = "Editar" Then
            RaiseEvent Editando(e.KeyValue)
        End If
    End Sub

    Protected Sub dxgvLista_HtmlRowCreated(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewTableRowEventArgs) Handles dxgvLista.HtmlRowCreated
        If e.RowType = DevExpress.Web.GridViewRowType.EditForm Then
            Dim btnGuardar As DevExpress.Web.ASPxButton
            Dim btnCancelar As DevExpress.Web.ASPxButton
            btnGuardar = Me.dxgvLista.FindEditFormTemplateControl("btnGuardar")
            btnCancelar = Me.dxgvLista.FindEditFormTemplateControl("btnCancelar")
            btnGuardar.JSProperties.Add("cp_NombreClienteLista", Me.NombreGridCliente)
            btnCancelar.JSProperties.Add("cp_NombreClienteLista", Me.NombreGridCliente)
        End If
        If e.RowType = DevExpress.Web.GridViewRowType.EmptyDataRow Then
            'Dim btnAgregar As DevExpress.Web.ASPxButton
            'btnAgregar = Me.dxgvLista.FindEmptyDataRowTemplateControl("btnAgregar")
            'btnAgregar.JSProperties.Add("cp_NombreClienteLista", Me.NombreGridCliente)
            'btnAgregar.Visible = Me.PermitirAgregarInline
            Dim lblEmptyDataRow As DevExpress.Web.ASPxLabel
            lblEmptyDataRow = Me.dxgvLista.FindEmptyDataRowTemplateControl("lblEmptyDataRow")
            'lblEmptyDataRow.Text = Me.dxgvLista.SettingsText.EmptyDataRow
        End If
        If e.RowType = DevExpress.Web.GridViewRowType.Data Then
            Dim lbDetalle As ImageButton
            lbDetalle = Me.dxgvLista.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "lbtnEditar")
            If lbDetalle IsNot Nothing Then lbDetalle.Visible = Me.PermitirEditar
            If Me.PermitirSeleccionar Then
                Dim lbSeleccionar As LinkButton
                lbSeleccionar = Me.dxgvLista.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "lbtnSeleccionar")
                'lbSeleccionar.Visible = True
                'lbSeleccionar.Text = Me.TextoSeleccionar
                'lbSeleccionar.CommandName = Me.ComandoSeleccionar
                'If lbSeleccionar.CommandName = "Check" Then
                '    lbSeleccionar.Visible = False
                'End If
            End If
        End If
    End Sub

    Public Function DevolverSeleccionados() As listaPROVEEDOR
        Dim mLista As New listaPROVEEDOR
        For Each llave As String In Me.dxgvLista.GetSelectedFieldValues("CODIPROVEEDOR")
            Dim lEntidad As New PROVEEDOR
            lEntidad.CODIPROVEEDOR = llave
            mLista.Add(lEntidad)
        Next
        Return mLista
    End Function

    Protected Sub dxgvLista_CustomButtonCallback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewCustomButtonCallbackEventArgs) Handles dxgvLista.CustomButtonCallback
        If e.ButtonID = "btnEliminar" Then
            Dim lEntidad As PROVEEDOR = CType(Me.dxgvLista.GetRow(e.VisibleIndex), PROVEEDOR)

            If Me.mComponente.EliminarPROVEEDOR(lEntidad.CODIPROVEEDOR) <> 1 Then
                'Si se cometio un error
                Me.AsignarMensaje("Error al Eliminar Registro", True, True)
            Else
                Me.dxgvLista.DataBind()
            End If
        End If
    End Sub

    Protected Sub dxgvLista_CustomUnboundColumnData(sender As Object, e As DevExpress.Web.ASPxGridViewColumnDataEventArgs) Handles dxgvLista.CustomUnboundColumnData
        If e.Column.FieldName = "TIPO" Then
            If e.GetListSourceFieldValue("TIPO_CONTRIBUYENTE") <> -1 Then
                Select Case e.GetListSourceFieldValue("TIPO_CONTRIBUYENTE")
                    Case 0
                        e.Value = "NO CONTRIBUYENTE"
                    Case 1
                        e.Value = "CONTRIBUYENTE"
                    Case 2
                        e.Value = "GRAN CONTRIBUYENTE"
                End Select
            Else
                e.Value = ""
            End If
        ElseIf e.Column.FieldName = "NOMBRE_BANCO" Then
            If e.GetListSourceFieldValue("CODIBANCO") IsNot Nothing Then
                Dim lEntidad As BANCOS = (New cBANCOS).ObtenerBANCOS(e.GetListSourceFieldValue("CODIBANCO"))
                If lEntidad IsNot Nothing Then
                    e.Value = lEntidad.NOMBRE_BANCO
                End If
            End If
        ElseIf e.Column.FieldName = "MUNICIPIO" Then
            Dim lEntidad As MUNICIPIO = (New cMUNICIPIO).ObtenerMUNICIPIO(e.GetListSourceFieldValue("CODI_DEPTO"), e.GetListSourceFieldValue("CODI_MUNI"))
            If lEntidad IsNot Nothing Then e.Value = lEntidad.NOMBRE_MUNI
        ElseIf e.Column.FieldName = "DEPARTAMENTO" Then
            Dim lEntidad As DEPARTAMENTO = (New cDEPARTAMENTO).ObtenerDEPARTAMENTO(e.GetListSourceFieldValue("CODI_DEPTO"))
            If lEntidad IsNot Nothing Then e.Value = lEntidad.NOMBRE_DEPTO
        End If
    End Sub
End Class
