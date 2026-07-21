Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucListaMAESTRO_LOTES
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla MAESTRO_LOTES
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	26/05/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controlesMaestro_ucListaMAESTRO_LOTES
    Inherits ucListaBase

    Private mComponente As New cMAESTRO_LOTES
    Public Event Seleccionado(ByVal ID_MAESTRO As Int32)
    Public Event Editando(ByVal ID_MAESTRO As Int32)
    Public Event Mostrando(ByVal ID_MAESTRO As Int32)


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
        If Me.hfListaMAESTRO_LOTES.Contains("Metodo") Then
            Select Case Me.hfListaMAESTRO_LOTES("Metodo")
                Case "CargarDatosPorCriterios"
                    Me.CargarDatosPorCriterios()
            End Select
        End If
    End Sub

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquÃ­ el cÃ³digo de usuario para inicializar la pÃ¡gina
        Me.CargarDatosGenericos()
        If Not IsPostBack Then
        Else
            If Me.ViewState("METODO") IsNot Nothing AndAlso Me.ViewState("METODO") = "CargarDatosPorCriteriosPostbackPopup" Then
                Me.CargarDatosPorCriteriosPostbackPopup(Me.ViewState("ZONA"), Me.ViewState("SUB_ZONA"), _
                                                        Me.ViewState("CODI_DEPTO"), Me.ViewState("CODI_MUNI"), _
                                                        Me.ViewState("CODI_CANTON"), Me.ViewState("CODIPROVEE"), _
                                                        Me.ViewState("CODISOCIO"), Me.ViewState("CODICONTRATO"), Me.ViewState("NOMBRE_PROVEEDOR"))
            End If
        End If

        If Not Me.ViewState("PermitirEditar") Is Nothing Then Me._PermitirEditar = Me.ViewState("PermitirEditar")
        If Not Me.ViewState("PermitirSeleccionar") Is Nothing Then Me._PermitirSeleccionar = Me.ViewState("PermitirSeleccionar")
        If Not Me.ViewState("TextoSeleccionar") Is Nothing Then Me._TextoSeleccionar = Me.ViewState("TextoSeleccionar")
        If Not Me.ViewState("ComandoSeleccionar") Is Nothing Then Me._ComandoSeleccionar = Me.ViewState("ComandoSeleccionar")
    End Sub


    Public Sub CargarDatosPorCriterios(ByVal ZONA As String, ByVal SUB_ZONA As String, _
                                        ByVal CODI_DEPTO As String, ByVal CODI_MUNI As String, _
                                        ByVal CODI_CANTON As String, _
                                        ByVal CODIPROVEE As String, ByVal CODISOCIO As String, ByVal CODICONTRATO As Integer, _
                                        ByVal NOMBRE_PROVEEDOR As String)
        Me.hfListaMAESTRO_LOTES.Clear()
        Me.hfListaMAESTRO_LOTES.Add("Metodo", "CargarDatosPorCriterios")
        Me.hfListaMAESTRO_LOTES.Add("p1", ZONA)
        Me.hfListaMAESTRO_LOTES.Add("p2", SUB_ZONA)
        Me.hfListaMAESTRO_LOTES.Add("p3", CODI_DEPTO)
        Me.hfListaMAESTRO_LOTES.Add("p4", CODI_MUNI)
        Me.hfListaMAESTRO_LOTES.Add("p5", CODI_CANTON)
        Me.hfListaMAESTRO_LOTES.Add("p6", CODIPROVEE)
        Me.hfListaMAESTRO_LOTES.Add("p7", CODISOCIO)
        Me.hfListaMAESTRO_LOTES.Add("p8", CODICONTRATO)
        Me.hfListaMAESTRO_LOTES.Add("p9", NOMBRE_PROVEEDOR)
        Me.CargarDatosPorCriterios()
    End Sub

    Public Function CargarDatosPorCriterios() As Integer
        Me.odsCriterios.SelectParameters("ZONA").DefaultValue = Me.hfListaMAESTRO_LOTES("p1")
        Me.odsCriterios.SelectParameters("SUB_ZONA").DefaultValue = Me.hfListaMAESTRO_LOTES("p2")
        Me.odsCriterios.SelectParameters("CODI_DEPTO").DefaultValue = Me.hfListaMAESTRO_LOTES("p3")
        Me.odsCriterios.SelectParameters("CODI_MUNI").DefaultValue = Me.hfListaMAESTRO_LOTES("p4")
        Me.odsCriterios.SelectParameters("CODI_CANTON").DefaultValue = Me.hfListaMAESTRO_LOTES("p5")
        Me.odsCriterios.SelectParameters("CODIPROVEE").DefaultValue = Me.hfListaMAESTRO_LOTES("p6")
        Me.odsCriterios.SelectParameters("CODISOCIO").DefaultValue = Me.hfListaMAESTRO_LOTES("p7")
        Me.odsCriterios.SelectParameters("CODICONTRATO").DefaultValue = Me.hfListaMAESTRO_LOTES("p8")
        Me.odsCriterios.SelectParameters("NOMBRE_PROVEEDOR").DefaultValue = Me.hfListaMAESTRO_LOTES("p9")
        Me.odsCriterios.DataBind()
        Me.dxgvLista.DataSourceID = "odsCriterios"
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    Public Function CargarDatosPorCriteriosPostbackPopup(ByVal ZONA As String, ByVal SUB_ZONA As String, _
                                        ByVal CODI_DEPTO As String, ByVal CODI_MUNI As String, _
                                        ByVal CODI_CANTON As String, _
                                        ByVal CODIPROVEE As String, ByVal CODISOCIO As String, ByVal CODICONTRATO As Integer, _
                                        ByVal NOMBRE_PROVEEDOR As String) As Integer
        Me.ViewState("METODO") = "CargarDatosPorCriteriosPostbackPopup"
        Me.ViewState("ZONA") = ZONA
        Me.ViewState("SUB_ZONA") = SUB_ZONA
        Me.ViewState("CODI_DEPTO") = CODI_DEPTO
        Me.ViewState("CODI_MUNI") = CODI_MUNI
        Me.ViewState("CODI_CANTON") = CODI_CANTON
        Me.ViewState("CODIPROVEE") = CODIPROVEE
        Me.ViewState("CODISOCIO") = CODISOCIO
        Me.ViewState("CODICONTRATO") = CODICONTRATO
        Me.ViewState("NOMBRE_PROVEEDOR") = NOMBRE_PROVEEDOR
        Return Me.CargarDatosPorCriteriosPostback(ZONA, SUB_ZONA, CODI_DEPTO, CODI_MUNI, CODI_CANTON, CODIPROVEE, CODISOCIO, CODICONTRATO, NOMBRE_PROVEEDOR)
    End Function

    Public Function CargarDatosPorCriteriosPostback(ByVal ZONA As String, ByVal SUB_ZONA As String,
                                        ByVal CODI_DEPTO As String, ByVal CODI_MUNI As String,
                                        ByVal CODI_CANTON As String,
                                        ByVal CODIPROVEE As String, ByVal CODISOCIO As String, ByVal CODICONTRATO As Integer,
                                        ByVal NOMBRE_PROVEEDOR As String) As Integer
        Me.odsCriterios.SelectParameters("ZONA").DefaultValue = ZONA
        Me.odsCriterios.SelectParameters("SUB_ZONA").DefaultValue = SUB_ZONA
        Me.odsCriterios.SelectParameters("CODI_DEPTO").DefaultValue = CODI_DEPTO
        Me.odsCriterios.SelectParameters("CODI_MUNI").DefaultValue = CODI_MUNI
        Me.odsCriterios.SelectParameters("CODI_CANTON").DefaultValue = CODI_CANTON
        Me.odsCriterios.SelectParameters("CODIPROVEE").DefaultValue = CODIPROVEE
        Me.odsCriterios.SelectParameters("CODISOCIO").DefaultValue = CODISOCIO
        Me.odsCriterios.SelectParameters("CODICONTRATO").DefaultValue = CODICONTRATO
        Me.odsCriterios.SelectParameters("NOMBRE_PROVEEDOR").DefaultValue = NOMBRE_PROVEEDOR
        Me.odsCriterios.DataBind()
        Me.dxgvLista.DataSourceID = "odsCriterios"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    Public Function CargarDatosPorCriteriosPostbackZafra(ByVal ZONA As String, ByVal SUB_ZONA As String,
                                        ByVal CODI_DEPTO As String, ByVal CODI_MUNI As String,
                                        ByVal CODI_CANTON As String,
                                        ByVal CODIPROVEE As String, ByVal CODISOCIO As String, ByVal CODICONTRATO As Integer,
                                        ByVal NOMBRE_PROVEEDOR As String, ByVal ID_ZAFRA_CONTRATO As Integer) As Integer
        Me.odsCriteriosPorZafra.SelectParameters("ZONA").DefaultValue = ZONA
        Me.odsCriteriosPorZafra.SelectParameters("SUB_ZONA").DefaultValue = SUB_ZONA
        Me.odsCriteriosPorZafra.SelectParameters("CODI_DEPTO").DefaultValue = CODI_DEPTO
        Me.odsCriteriosPorZafra.SelectParameters("CODI_MUNI").DefaultValue = CODI_MUNI
        Me.odsCriteriosPorZafra.SelectParameters("CODI_CANTON").DefaultValue = CODI_CANTON
        Me.odsCriteriosPorZafra.SelectParameters("CODIPROVEE").DefaultValue = CODIPROVEE
        Me.odsCriteriosPorZafra.SelectParameters("CODISOCIO").DefaultValue = CODISOCIO
        Me.odsCriteriosPorZafra.SelectParameters("CODICONTRATO").DefaultValue = CODICONTRATO
        Me.odsCriteriosPorZafra.SelectParameters("NOMBRE_PROVEEDOR").DefaultValue = NOMBRE_PROVEEDOR
        Me.odsCriteriosPorZafra.SelectParameters("ID_ZAFRA_CONTRATO").DefaultValue = ID_ZAFRA_CONTRATO
        Me.odsCriteriosPorZafra.DataBind()
        Me.dxgvLista.DataSourceID = "odsCriteriosPorZafra"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function
#End Region

#Region "Propiedades"

    Public Property MostrarFooter() As Boolean
        Get
            Return Me.dxgvLista.SettingsPager.Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.SettingsPager.Visible = Value
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

    'Private _PermitirEditar As Boolean = True
    'Public Property PermitirEditar() As Boolean
    '    Get
    '        Return _PermitirEditar
    '    End Get
    '    Set(ByVal Value As Boolean)
    '        _PermitirEditar = Value
    '        If Not Me.ViewState("PermitirEditar") Is Nothing Then Me.ViewState.Remove("PermitirEditar")
    '        Me.ViewState.Add("PermitirEditar", Value)
    '    End Set
    'End Property

    Private _PermitirEditar As Boolean = True
    Public Property PermitirEditar() As Boolean
        Get
            Return Me.dxgvLista.Columns("colEditar").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("colEditar").Visible = Value
            If Not Me.ViewState("PermitirEditar") Is Nothing Then Me.ViewState.Remove("PermitirEditar")
            Me.ViewState.Add("PermitirEditar", Value)
        End Set
    End Property

    Private _PermitirMostrar As Boolean = True
    Public Property PermitirMostrar() As Boolean
        Get
            Return Me.dxgvLista.Columns("colMostrar").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("colMostrar").Visible = Value
            If Not Me.ViewState("PermitirMostrar") Is Nothing Then Me.ViewState.Remove("PermitirMostrar")
            Me.ViewState.Add("PermitirMostrar", Value)
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

    Public Property TamanoPagina As Int32
        Set(value As Int32)
            Me.dxgvLista.SettingsPager.PageSize = value
        End Set
        Get
            Return Me.dxgvLista.SettingsPager.PageSize
        End Get
    End Property

    Public Property AgruparPor As String
        Set(value As String)
            Me.dxgvLista.GroupBy(Me.dxgvLista.Columns(value))
        End Set
        Get
            Return ""
        End Get
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

    Public Property VerCODIGO_LOTE() As Boolean
        Get
            Return Me.dxgvLista.Columns("CODIGO_LOTE").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CODIGO_LOTE").Visible = Value
        End Set
    End Property

    Public Property VerCODI_DEPTO() As Boolean
        Get
            Return Me.dxgvLista.Columns("CODI_DEPTO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CODI_DEPTO").Visible = Value
        End Set
    End Property

    Public Property VerCODI_MUNI() As Boolean
        Get
            Return Me.dxgvLista.Columns("CODI_MUNI").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CODI_MUNI").Visible = Value
        End Set
    End Property

    Public Property VerCODI_CANTON() As Boolean
        Get
            Return Me.dxgvLista.Columns("CODI_CANTON").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CODI_CANTON").Visible = Value
        End Set
    End Property

    Public Property VerZONA() As Boolean
        Get
            Return Me.dxgvLista.Columns("ZONA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ZONA").Visible = Value
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

    Public Property VerNOMBRE_DEPARTAMENTO() As Boolean
        Get
            Return Me.dxgvLista.Columns("NOMBRE_DEPTO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NOMBRE_DEPTO").Visible = Value
        End Set
    End Property

    Public Property VerNOMBRE_MUNICIPIO() As Boolean
        Get
            Return Me.dxgvLista.Columns("NOMBRE_MUNI").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NOMBRE_MUNI").Visible = Value
        End Set
    End Property

    Public Property VerNOMBRE_CANTON() As Boolean
        Get
            Return Me.dxgvLista.Columns("NOMBRE_CANTON").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NOMBRE_CANTON").Visible = Value
        End Set
    End Property

    Public Property VerCUI() As Boolean
        Get
            Return Me.dxgvLista.Columns("CUI").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CUI").Visible = Value
        End Set
    End Property

    Public Property VerSUB_ZONA() As Boolean
        Get
            Return Me.dxgvLista.Columns("SUB_ZONA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("SUB_ZONA").Visible = Value
        End Set
    End Property

    Public Property VerCORRELATIVO() As Boolean
        Get
            Return Me.dxgvLista.Columns("CORRELATIVO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CORRELATIVO").Visible = Value
        End Set
    End Property

    Public Property VerCODICONTRATO() As Boolean
        Get
            Return Me.dxgvLista.Columns("CODICONTRATO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CODICONTRATO").Visible = Value
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

    Public Property VerNOMBRE_PROVEEDOR() As Boolean
        Get
            Return Me.dxgvLista.Columns("NOMBRE_PROVEEDOR").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NOMBRE_PROVEEDOR").Visible = Value
        End Set
    End Property

    Public Property VerNOMBRE_COMER() As Boolean
        Get
            Return Me.dxgvLista.Columns("NOMBRE_COMER").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NOMBRE_COMER").Visible = Value
        End Set
    End Property

    Public Property VerCODILOTE_COMER() As Boolean
        Get
            Return Me.dxgvLista.Columns("CODILOTE_COMER").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CODILOTE_COMER").Visible = Value
        End Set
    End Property

    Public Property VerMZ_CULTIVADA() As Boolean
        Get
            Return Me.dxgvLista.Columns("MZ_CULTIVADA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("MZ_CULTIVADA").Visible = Value
        End Set
    End Property

    Public Property VerCODIVARIEDA() As Boolean
        Get
            Return Me.dxgvLista.Columns("CODIVARIEDA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CODIVARIEDA").Visible = Value
        End Set
    End Property

    Public Property VerID_COMPOR() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_COMPOR").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_COMPOR").Visible = Value
        End Set
    End Property

    Public Property VerCOD_TIPO_SUELO() As Boolean
        Get
            Return Me.dxgvLista.Columns("COD_TIPO_SUELO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("COD_TIPO_SUELO").Visible = Value
        End Set
    End Property

    Public Property VerID_COND_SIEMBRA() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_COND_SIEMBRA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_COND_SIEMBRA").Visible = Value
        End Set
    End Property

    Public Property VerID_NIVEL_HUMEDAD() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_NIVEL_HUMEDAD").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_NIVEL_HUMEDAD").Visible = Value
        End Set
    End Property

    Public Property VerNO_CORTE() As Boolean
        Get
            Return Me.dxgvLista.Columns("NO_CORTE").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NO_CORTE").Visible = Value
        End Set
    End Property

    Public Property VerMSNM() As Boolean
        Get
            Return Me.dxgvLista.Columns("MSNM").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("MSNM").Visible = Value
        End Set
    End Property

    Public Property VerKM_CARRETERA() As Boolean
        Get
            Return Me.dxgvLista.Columns("KM_CARRETERA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("KM_CARRETERA").Visible = Value
        End Set
    End Property

    Public Property VerKM_TIERRA() As Boolean
        Get
            Return Me.dxgvLista.Columns("KM_TIERRA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("KM_TIERRA").Visible = Value
        End Set
    End Property

    Public Property VerRIESGO_PIEDRA() As Boolean
        Get
            Return Me.dxgvLista.Columns("RIESGO_PIEDRA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("RIESGO_PIEDRA").Visible = Value
        End Set
    End Property

    Public Property VerFECHA_SIEMBRA() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_SIEMBRA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_SIEMBRA").Visible = Value
        End Set
    End Property

    Public Property VerFECHA_CORTE() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_CORTE").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_CORTE").Visible = Value
        End Set
    End Property

    Public Property VerPROD_TC() As Boolean
        Get
            Return Me.dxgvLista.Columns("PROD_TC").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("PROD_TC").Visible = Value
        End Set
    End Property

    Public Property VerPROD_LB() As Boolean
        Get
            Return Me.dxgvLista.Columns("PROD_LB").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("PROD_LB").Visible = Value
        End Set
    End Property

    Public Property VerFACTOR_DESPOBLA() As Boolean
        Get
            Return Me.dxgvLista.Columns("FACTOR_DESPOBLA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FACTOR_DESPOBLA").Visible = Value
        End Set
    End Property

    Public Property VerUSUARIO_CREA() As Boolean
        Get
            Return Me.dxgvLista.Columns("USUARIO_CREA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("USUARIO_CREA").Visible = Value
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

    Public Property VerUSUARIO_ACT() As Boolean
        Get
            Return Me.dxgvLista.Columns("USUARIO_ACT").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("USUARIO_ACT").Visible = Value
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

    Public Property HeaderCODIGO_LOTE() As String
        Get
            Return Me.dxgvLista.Columns("CODIGO_LOTE").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CODIGO_LOTE").Caption = Value
        End Set
    End Property

    Public Property HeaderCODI_DEPTO() As String
        Get
            Return Me.dxgvLista.Columns("CODI_DEPTO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CODI_DEPTO").Caption = Value
        End Set
    End Property

    Public Property HeaderCODI_MUNI() As String
        Get
            Return Me.dxgvLista.Columns("CODI_MUNI").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CODI_MUNI").Caption = Value
        End Set
    End Property

    Public Property HeaderCODI_CANTON() As String
        Get
            Return Me.dxgvLista.Columns("CODI_CANTON").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CODI_CANTON").Caption = Value
        End Set
    End Property

    Public Property HeaderZONA() As String
        Get
            Return Me.dxgvLista.Columns("ZONA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ZONA").Caption = Value
        End Set
    End Property

    Public Property HeaderSUB_ZONA() As String
        Get
            Return Me.dxgvLista.Columns("SUB_ZONA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("SUB_ZONA").Caption = Value
        End Set
    End Property

    Public Property HeaderCORRELATIVO() As String
        Get
            Return Me.dxgvLista.Columns("CORRELATIVO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CORRELATIVO").Caption = Value
        End Set
    End Property

    Public Property HeaderNOMBRE_COMER() As String
        Get
            Return Me.dxgvLista.Columns("NOMBRE_COMER").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("NOMBRE_COMER").Caption = Value
        End Set
    End Property

    Public Property HeaderCODILOTE_COMER() As String
        Get
            Return Me.dxgvLista.Columns("CODILOTE_COMER").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CODILOTE_COMER").Caption = Value
        End Set
    End Property

    Public Property HeaderMZ_CULTIVADA() As String
        Get
            Return Me.dxgvLista.Columns("MZ_CULTIVADA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("MZ_CULTIVADA").Caption = Value
        End Set
    End Property

    Public Property HeaderCODIVARIEDA() As String
        Get
            Return Me.dxgvLista.Columns("CODIVARIEDA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CODIVARIEDA").Caption = Value
        End Set
    End Property

    Public Property HeaderID_COMPOR() As String
        Get
            Return Me.dxgvLista.Columns("ID_COMPOR").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_COMPOR").Caption = Value
        End Set
    End Property

    Public Property HeaderCOD_TIPO_SUELO() As String
        Get
            Return Me.dxgvLista.Columns("COD_TIPO_SUELO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("COD_TIPO_SUELO").Caption = Value
        End Set
    End Property

    Public Property HeaderID_COND_SIEMBRA() As String
        Get
            Return Me.dxgvLista.Columns("ID_COND_SIEMBRA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_COND_SIEMBRA").Caption = Value
        End Set
    End Property

    Public Property HeaderID_NIVEL_HUMEDAD() As String
        Get
            Return Me.dxgvLista.Columns("ID_NIVEL_HUMEDAD").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_NIVEL_HUMEDAD").Caption = Value
        End Set
    End Property

    Public Property HeaderNO_CORTE() As String
        Get
            Return Me.dxgvLista.Columns("NO_CORTE").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("NO_CORTE").Caption = Value
        End Set
    End Property

    Public Property HeaderMSNM() As String
        Get
            Return Me.dxgvLista.Columns("MSNM").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("MSNM").Caption = Value
        End Set
    End Property

    Public Property HeaderKM_CARRETERA() As String
        Get
            Return Me.dxgvLista.Columns("KM_CARRETERA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("KM_CARRETERA").Caption = Value
        End Set
    End Property

    Public Property HeaderKM_TIERRA() As String
        Get
            Return Me.dxgvLista.Columns("KM_TIERRA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("KM_TIERRA").Caption = Value
        End Set
    End Property

    Public Property HeaderRIESGO_PIEDRA() As String
        Get
            Return Me.dxgvLista.Columns("RIESGO_PIEDRA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("RIESGO_PIEDRA").Caption = Value
        End Set
    End Property

    Public Property HeaderFECHA_SIEMBRA() As String
        Get
            Return Me.dxgvLista.Columns("FECHA_SIEMBRA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA_SIEMBRA").Caption = Value
        End Set
    End Property

    Public Property HeaderFECHA_CORTE() As String
        Get
            Return Me.dxgvLista.Columns("FECHA_CORTE").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA_CORTE").Caption = Value
        End Set
    End Property

    Public Property HeaderPROD_TC() As String
        Get
            Return Me.dxgvLista.Columns("PROD_TC").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("PROD_TC").Caption = Value
        End Set
    End Property

    Public Property HeaderPROD_LB() As String
        Get
            Return Me.dxgvLista.Columns("PROD_LB").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("PROD_LB").Caption = Value
        End Set
    End Property

    Public Property HeaderFACTOR_DESPOBLA() As String
        Get
            Return Me.dxgvLista.Columns("FACTOR_DESPOBLA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FACTOR_DESPOBLA").Caption = Value
        End Set
    End Property

    Public Property HeaderUSUARIO_CREA() As String
        Get
            Return Me.dxgvLista.Columns("USUARIO_CREA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("USUARIO_CREA").Caption = Value
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

    Public Property HeaderUSUARIO_ACT() As String
        Get
            Return Me.dxgvLista.Columns("USUARIO_ACT").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("USUARIO_ACT").Caption = Value
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

#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla MAESTRO_LOTES
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/05/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Me.odsLista.SelectParameters("recuperarHijas").DefaultValue = "False"
        Me.odsLista.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsLista.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsLista.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsLista.DataBind()
        Me.dxgvLista.DataSourceID = "odsLista"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla MAESTRO_LOTES
    ''' filtrado por la tabla DEPARTAMENTO
    ''' </summary>
    ''' <param name="CODI_DEPTO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/05/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorDEPARTAMENTO(ByVal CODI_DEPTO As String) As Integer
        Me.odsListaPorDEPARTAMENTO.SelectParameters("CODI_DEPTO").DefaultValue = CODI_DEPTO.ToString()
        Me.odsListaPorDEPARTAMENTO.SelectParameters("recuperarHijas").DefaultValue = "False"
        Me.odsListaPorDEPARTAMENTO.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorDEPARTAMENTO.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorDEPARTAMENTO.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorDEPARTAMENTO.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorDEPARTAMENTO"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla MAESTRO_LOTES
    ''' filtrado por la tabla MUNICIPIO
    ''' </summary>
    ''' <param name="CODI_DEPTO"></param>
    ''' <param name="CODI_MUNI"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/05/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorMUNICIPIO(ByVal CODI_DEPTO As String, ByVal CODI_MUNI As String) As Integer
        Me.odsListaPorMUNICIPIO.SelectParameters("CODI_DEPTO").DefaultValue = CODI_DEPTO.ToString()
        Me.odsListaPorMUNICIPIO.SelectParameters("CODI_MUNI").DefaultValue = CODI_MUNI.ToString()
        Me.odsListaPorMUNICIPIO.SelectParameters("recuperarHijas").DefaultValue = "False"
        Me.odsListaPorMUNICIPIO.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorMUNICIPIO.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorMUNICIPIO.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorMUNICIPIO.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorMUNICIPIO"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla MAESTRO_LOTES
    ''' filtrado por la tabla CANTON
    ''' </summary>
    ''' <param name="CODI_CANTON"></param>
    ''' <param name="CODI_DEPTO"></param>
    ''' <param name="CODI_MUNI"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/05/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorCANTON(ByVal CODI_CANTON As String, ByVal CODI_DEPTO As String, ByVal CODI_MUNI As String) As Integer
        Me.odsListaPorCANTON.SelectParameters("CODI_CANTON").DefaultValue = CODI_CANTON.ToString()
        Me.odsListaPorCANTON.SelectParameters("CODI_DEPTO").DefaultValue = CODI_DEPTO.ToString()
        Me.odsListaPorCANTON.SelectParameters("CODI_MUNI").DefaultValue = CODI_MUNI.ToString()
        Me.odsListaPorCANTON.SelectParameters("recuperarHijas").DefaultValue = "False"
        Me.odsListaPorCANTON.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorCANTON.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorCANTON.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorCANTON.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorCANTON"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla MAESTRO_LOTES
    ''' filtrado por la tabla ZONAS
    ''' </summary>
    ''' <param name="ZONA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/05/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorZONAS(ByVal ZONA As String) As Integer
        Me.odsListaPorZONAS.SelectParameters("ZONA").DefaultValue = ZONA.ToString()
        Me.odsListaPorZONAS.SelectParameters("recuperarHijas").DefaultValue = "False"
        Me.odsListaPorZONAS.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorZONAS.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorZONAS.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorZONAS.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorZONAS"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla MAESTRO_LOTES
    ''' filtrado por la tabla SUB_ZONAS
    ''' </summary>
    ''' <param name="ZONA"></param>
    ''' <param name="SUB_ZONA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/05/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorSUB_ZONAS(ByVal ZONA As String, ByVal SUB_ZONA As String) As Integer
        Me.odsListaPorSUB_ZONAS.SelectParameters("ZONA").DefaultValue = ZONA.ToString()
        Me.odsListaPorSUB_ZONAS.SelectParameters("SUB_ZONA").DefaultValue = SUB_ZONA.ToString()
        Me.odsListaPorSUB_ZONAS.SelectParameters("recuperarHijas").DefaultValue = "False"
        Me.odsListaPorSUB_ZONAS.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorSUB_ZONAS.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorSUB_ZONAS.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorSUB_ZONAS.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorSUB_ZONAS"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla MAESTRO_LOTES
    ''' filtrado por la tabla COMPORTAMIENTO_CANA
    ''' </summary>
    ''' <param name="ID_COMPOR"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/05/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorCOMPORTAMIENTO_CANA(ByVal ID_COMPOR As Int32) As Integer
        Me.odsListaPorCOMPORTAMIENTO_CANA.SelectParameters("ID_COMPOR").DefaultValue = ID_COMPOR.ToString()
        Me.odsListaPorCOMPORTAMIENTO_CANA.SelectParameters("recuperarHijas").DefaultValue = "False"
        Me.odsListaPorCOMPORTAMIENTO_CANA.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorCOMPORTAMIENTO_CANA.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorCOMPORTAMIENTO_CANA.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorCOMPORTAMIENTO_CANA.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorCOMPORTAMIENTO_CANA"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla MAESTRO_LOTES
    ''' filtrado por la tabla TIPO_SUELO
    ''' </summary>
    ''' <param name="COD_TIPO_SUELO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/05/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorTIPO_SUELO(ByVal COD_TIPO_SUELO As String) As Integer
        Me.odsListaPorTIPO_SUELO.SelectParameters("COD_TIPO_SUELO").DefaultValue = COD_TIPO_SUELO.ToString()
        Me.odsListaPorTIPO_SUELO.SelectParameters("recuperarHijas").DefaultValue = "False"
        Me.odsListaPorTIPO_SUELO.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorTIPO_SUELO.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorTIPO_SUELO.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorTIPO_SUELO.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorTIPO_SUELO"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla MAESTRO_LOTES
    ''' filtrado por la tabla CONDICION_SIEMBRA
    ''' </summary>
    ''' <param name="ID_COND_SIEMBRA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/05/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorCONDICION_SIEMBRA(ByVal ID_COND_SIEMBRA As Int32) As Integer
        Me.odsListaPorCONDICION_SIEMBRA.SelectParameters("ID_COND_SIEMBRA").DefaultValue = ID_COND_SIEMBRA.ToString()
        Me.odsListaPorCONDICION_SIEMBRA.SelectParameters("recuperarHijas").DefaultValue = "False"
        Me.odsListaPorCONDICION_SIEMBRA.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorCONDICION_SIEMBRA.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorCONDICION_SIEMBRA.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorCONDICION_SIEMBRA.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorCONDICION_SIEMBRA"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla MAESTRO_LOTES
    ''' filtrado por la tabla NIVEL_HUMEDAD
    ''' </summary>
    ''' <param name="ID_NIVEL_HUMEDAD"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/05/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorNIVEL_HUMEDAD(ByVal ID_NIVEL_HUMEDAD As Int32) As Integer
        Me.odsListaPorNIVEL_HUMEDAD.SelectParameters("ID_NIVEL_HUMEDAD").DefaultValue = ID_NIVEL_HUMEDAD.ToString()
        Me.odsListaPorNIVEL_HUMEDAD.SelectParameters("recuperarHijas").DefaultValue = "False"
        Me.odsListaPorNIVEL_HUMEDAD.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorNIVEL_HUMEDAD.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorNIVEL_HUMEDAD.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorNIVEL_HUMEDAD.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorNIVEL_HUMEDAD"
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
                keyValues(i) = grid.GetRowValues(i, "CODIGO_LOTE")
                keyNames(i) = grid.GetRowValues(i, "CODI_DEPTO")
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
            'CType(Me.dxgvLista.Columns("Edicion"), DevExpress.Web.GridViewCommandColumn).NewButton.Visible = Me.PermitirAgregarInline
            'CType(Me.dxgvLista.Columns("Edicion"), DevExpress.Web.GridViewCommandColumn).EditButton.Visible = Me.PermitirEditarInline
            'CType(Me.dxgvLista.Columns("Edicion"), DevExpress.Web.GridViewCommandColumn).DeleteButton.Visible = Me.PermitirEliminarInline
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
        If e.CommandArgs.CommandName = "Mostrar" Then
            RaiseEvent Mostrando(e.KeyValue)
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
            Dim btnAgregar As DevExpress.Web.ASPxButton
            'btnAgregar = Me.dxgvLista.FindEmptyDataRowTemplateControl("btnAgregar")
            'btnAgregar.JSProperties.Add("cp_NombreClienteLista", Me.NombreGridCliente)
            'btnAgregar.Visible = Me.PermitirAgregarInline
            Dim lblEmptyDataRow As DevExpress.Web.ASPxLabel
            lblEmptyDataRow = Me.dxgvLista.FindEmptyDataRowTemplateControl("lblEmptyDataRow")
            'lblEmptyDataRow.Text = Me.dxgvLista.SettingsText.EmptyDataRow
        End If
        'If e.RowType = DevExpress.Web.GridViewRowType.Data Then
        '    If Not Me.PermitirEditar Then
        '        Dim lbDetalle As LinkButton
        '        lbDetalle = Me.dxgvLista.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "lbtnEditar")
        '        'lbDetalle.Visible = False
        '    End If
        '    If Me.PermitirSeleccionar Then
        '        Me.dxgvLista.Columns("Seleccionar").Visible = True
        '    End If
        'End If
    End Sub

    Public Function DevolverSeleccionados() As listaMAESTRO_LOTES
        Dim mLista As New listaMAESTRO_LOTES
        For Each llave As String In Me.dxgvLista.GetSelectedFieldValues("CODIGO_LOTE")
            Dim lEntidad As New MAESTRO_LOTES
            lEntidad = (New cMAESTRO_LOTES).ObtenerMAESTRO_LOTES(llave)
            mLista.Add(lEntidad)
        Next
        Return mLista
    End Function

    Public Sub QuitarSeleccionados()
        dxgvLista.Selection.UnselectAll()
    End Sub

    Protected Sub dxgvLista_CustomButtonCallback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewCustomButtonCallbackEventArgs) Handles dxgvLista.CustomButtonCallback
        If e.ButtonID = "btnEditar" Then
            Dim lEntidad As MAESTRO_LOTES = CType(Me.dxgvLista.GetRow(e.VisibleIndex), MAESTRO_LOTES)
            RaiseEvent Editando(lEntidad.ID_MAESTRO)
        End If
        If e.ButtonID = "btnEliminar" Then
            Dim lEntidad As MAESTRO_LOTES = CType(Me.dxgvLista.GetRow(e.VisibleIndex), MAESTRO_LOTES)
            Dim listaLotesContra As listaLOTES = (New cLOTES).ObtenerListaPorMAESTRO_LOTES(lEntidad.ID_MAESTRO)

            If listaLotesContra IsNot Nothing AndAlso listaLotesContra.Count > 0 Then
                dxgvLista.JSProperties.Add("cpMensaje", "Solo se pueden eliminar maestro de lote que no este contratado")
                Return
            End If
            If Me.mComponente.EliminarMAESTRO_LOTES(lEntidad.ID_MAESTRO) <> 1 Then
                'Si se cometio un error
                dxgvLista.JSProperties.Add("cpMensaje", "Error al Eliminar Registro: " + Me.mComponente.sError)
            Else
                Me.dxgvLista.DataBind()
            End If
        End If
    End Sub

    Protected Sub dxgvLista_CustomButtonInitialize(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewCustomButtonEventArgs) Handles dxgvLista.CustomButtonInitialize
        If e.ButtonID = "btnEliminar" Then
            e.Text = "<img src='imagenes/Eliminar.gif' style='border-style:none;border-width:0px;height:18px;width:18px;' alt='Eliminar' onclick='if(!window.confirm(" + """" + "Esta seguro de Eliminar el Registro?"")){return false;}'/>"
        End If
    End Sub

    Protected Sub dxgvLista_CustomUnboundColumnData(sender As Object, e As DevExpress.Web.ASPxGridViewColumnDataEventArgs) Handles dxgvLista.CustomUnboundColumnData
        Static lCodiProveedor As String = ""
        Static lCodiProvee As String = ""
        Static lCodiSocio As String = ""
        Static lNombreProveedor As String = ""
        Static lCodiDepto As String = ""
        Static lCodiMuni As String = ""
        Static lCodiCanton As String = ""
        Static lNombreDepto As String = ""
        Static lNombreMuni As String = ""
        Static lNombreCanton As String = ""
        Dim lProveedor As PROVEEDOR
        Dim lDepartamento As DEPARTAMENTO
        Dim lMunicipio As MUNICIPIO
        Dim lCanton As CANTON

        If lCodiProvee = "" OrElse (lCodiProveedor <> e.GetListSourceFieldValue("CODIPROVEEDOR")) Then
            lProveedor = (New cPROVEEDOR).ObtenerPROVEEDOR(e.GetListSourceFieldValue("CODIPROVEEDOR"))
            If lProveedor IsNot Nothing Then
                lCodiProvee = lProveedor.CODIPROVEE
                lCodiSocio = lProveedor.CODISOCIO
                lNombreProveedor = lProveedor.NOMBRES.Trim + " " + lProveedor.APELLIDOS.Trim
            End If
        End If
        If lCodiDepto = "" OrElse (lCodiDepto <> e.GetListSourceFieldValue("CODI_DEPTO")) Then
            lDepartamento = (New cDEPARTAMENTO).ObtenerDEPARTAMENTO(e.GetListSourceFieldValue("CODI_DEPTO"))
            If lDepartamento IsNot Nothing Then
                lMunicipio = (New cMUNICIPIO).ObtenerMUNICIPIO(e.GetListSourceFieldValue("CODI_DEPTO"), e.GetListSourceFieldValue("CODI_MUNI"))
                If lMunicipio IsNot Nothing Then
                    lCanton = (New cCANTON).ObtenerCANTON(e.GetListSourceFieldValue("CODI_CANTON"), e.GetListSourceFieldValue("CODI_DEPTO"), e.GetListSourceFieldValue("CODI_MUNI"))
                    If lCanton IsNot Nothing Then
                        lCodiDepto = lDepartamento.CODI_DEPTO
                        lCodiMuni = lMunicipio.CODI_MUNI
                        lCodiCanton = lCanton.CODI_CANTON
                        lNombreDepto = lDepartamento.NOMBRE_DEPTO : lNombreMuni = lMunicipio.NOMBRE_MUNI : lNombreCanton = lCanton.NOMBRE_CANTON
                    End If
                End If
            End If
            
        End If
        If lCodiMuni = "" OrElse (lCodiMuni <> e.GetListSourceFieldValue("CODI_MUNI")) Then
            lMunicipio = (New cMUNICIPIO).ObtenerMUNICIPIO(e.GetListSourceFieldValue("CODI_DEPTO"), e.GetListSourceFieldValue("CODI_MUNI"))
            If lMunicipio IsNot Nothing Then
                lCanton = (New cCANTON).ObtenerCANTON(e.GetListSourceFieldValue("CODI_CANTON"), e.GetListSourceFieldValue("CODI_DEPTO"), e.GetListSourceFieldValue("CODI_MUNI"))
                If lCanton IsNot Nothing Then
                    lCodiMuni = lMunicipio.CODI_MUNI
                    lCodiCanton = lCanton.CODI_CANTON
                    lNombreMuni = lMunicipio.NOMBRE_MUNI : lNombreCanton = lCanton.NOMBRE_CANTON
                End If
            End If
        End If
        If lCodiCanton = "" OrElse (lCodiCanton <> e.GetListSourceFieldValue("CODI_CANTON")) Then
            lCanton = (New cCANTON).ObtenerCANTON(e.GetListSourceFieldValue("CODI_CANTON"), e.GetListSourceFieldValue("CODI_DEPTO"), e.GetListSourceFieldValue("CODI_MUNI"))
            If lCanton IsNot Nothing Then
                lCodiCanton = lCanton.CODI_CANTON
                lNombreCanton = lCanton.NOMBRE_CANTON
            End If
        End If

        Select Case e.Column.FieldName
            Case "NOMBRE_DEPTO"
                e.Value = lNombreDepto
            Case "NOMBRE_MUNI"
                e.Value = lNombreMuni
            Case "NOMBRE_CANTON"
                e.Value = lNombreCanton
            Case "CODIPROVEE"
                e.Value = lCodiProvee
            Case "CODISOCIO"
                e.Value = lCodiSocio
            Case "NOMBRE_PROVEEDOR"
                e.Value = lNombreProveedor
        End Select
    End Sub
End Class
