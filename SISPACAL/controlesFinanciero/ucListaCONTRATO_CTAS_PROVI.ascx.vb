Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucListaCONTRATO_CTAS_PROVI
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla CONTRATO_CTAS_PROVI
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	06/11/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucListaCONTRATO_CTAS_PROVI
    Inherits ucListaBase
 
    Private mComponente As New cCONTRATO_CTAS_PROVI
    Public Event Seleccionado(ByVal ID_CONTRATO_CTAS_PROVI As Int32) 
    Public Event Editando(ByVal ID_CONTRATO_CTAS_PROVI As Int32) 

#Region"Propiedades"

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

    Public Property MostrarCheckUnaSeleccion As Boolean
        Set(value As Boolean)
            dxgvLista.Columns("CheckSeleccionar").Visible = value
            dxgvLista.SettingsBehavior.AllowSelectSingleRowOnly = value
        End Set
        Get
            Return dxgvLista.SettingsBehavior.AllowSelectSingleRowOnly
        End Get
    End Property
    Public Property MostrarCheckVariaSeleccion As Boolean
        Set(value As Boolean)
            dxgvLista.Columns("CheckSeleccionar").Visible = value
        End Set
        Get
            Return dxgvLista.Columns("CheckSeleccionar").Visible
        End Get
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

    Public Property VerID_CONTRATO_CTAS_PROVI() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_CONTRATO_CTAS_PROVI").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_CONTRATO_CTAS_PROVI").Visible = Value
        End Set
    End Property

    Public Property VerID_CONTRATO_FINAN() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_CONTRATO_FINAN").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_CONTRATO_FINAN").Visible = Value
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

    Public Property VerID_ZAFRA() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_ZAFRA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_ZAFRA").Visible = Value
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
    Public Property VerNOMBRE_PROVEEDOR() As Boolean
        Get
            Return Me.dxgvLista.Columns("NOMBRE_PROVEEDOR").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NOMBRE_PROVEEDOR").Visible = Value
        End Set
    End Property
    Public Property VerNO_CONTRATO() As Boolean
        Get
            Return Me.dxgvLista.Columns("NO_CONTRATO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NO_CONTRATO").Visible = Value
        End Set
    End Property
    Public Property VerCONCEPTO() As Boolean
        Get
            Return Me.dxgvLista.Columns("CONCEPTO_FINANCIAMIENTO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CONCEPTO_FINANCIAMIENTO").Visible = Value
        End Set
    End Property


    Public Property VerFECHA_APLICA() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_APLICA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_APLICA").Visible = Value
        End Set
    End Property

    Public Property VerDESCRIPCION() As Boolean
        Get
            Return Me.dxgvLista.Columns("CONCEPTO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CONCEPTO").Visible = Value
        End Set
    End Property

    Public Property VerPROVISION() As Boolean
        Get
            Return Me.dxgvLista.Columns("PROVISION").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("PROVISION").Visible = Value
        End Set
    End Property

    Public Property VerUID_SOLIC_AGRI_PROD() As Boolean
        Get
            Return Me.dxgvLista.Columns("UID_SOLIC_AGRI_PROD").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("UID_SOLIC_AGRI_PROD").Visible = Value
        End Set
    End Property

    Public Property VerUID_SOLIC_AGRI_VUELO() As Boolean
        Get
            Return Me.dxgvLista.Columns("UID_SOLIC_AGRI_VUELO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("UID_SOLIC_AGRI_VUELO").Visible = Value
        End Set
    End Property

    Public Property VerZAFRA() As Boolean
        Get
            Return Me.dxgvLista.Columns("ZAFRA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ZAFRA").Visible = Value
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

    Public Property HeaderID_CONTRATO_CTAS_PROVI() As String
        Get
            Return Me.dxgvLista.Columns("ID_CONTRATO_CTAS_PROVI").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_CONTRATO_CTAS_PROVI").Caption = Value
        End Set
    End Property

    Public Property HeaderID_CONTRATO_FINAN() As String
        Get
            Return Me.dxgvLista.Columns("ID_CONTRATO_FINAN").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_CONTRATO_FINAN").Caption = Value
        End Set
    End Property

    Public Property HeaderCODICONTRATO() As String
        Get
            Return Me.dxgvLista.Columns("CODICONTRATO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CODICONTRATO").Caption = Value
        End Set
    End Property

    Public Property HeaderID_ZAFRA() As String
        Get
            Return Me.dxgvLista.Columns("ID_ZAFRA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_ZAFRA").Caption = Value
        End Set
    End Property

    Public Property HeaderFECHA_APLICA() As String
        Get
            Return Me.dxgvLista.Columns("FECHA_APLICA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA_APLICA").Caption = Value
        End Set
    End Property

    Public Property HeaderCONCEPTO() As String
        Get
            Return Me.dxgvLista.Columns("CONCEPTO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CONCEPTO").Caption = Value
        End Set
    End Property

    Public Property HeaderPROVISION() As String
        Get
            Return Me.dxgvLista.Columns("PROVISION").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("PROVISION").Caption = Value
        End Set
    End Property

    Public Property HeaderUID_SOLIC_AGRI_PROD() As String
        Get
            Return Me.dxgvLista.Columns("UID_SOLIC_AGRI_PROD").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("UID_SOLIC_AGRI_PROD").Caption = Value
        End Set
    End Property

    Public Property HeaderUID_SOLIC_AGRI_VUELO() As String
        Get
            Return Me.dxgvLista.Columns("UID_SOLIC_AGRI_VUELO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("UID_SOLIC_AGRI_VUELO").Caption = Value
        End Set
    End Property

    Public Property HeaderZAFRA() As String
        Get
            Return Me.dxgvLista.Columns("ZAFRA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ZAFRA").Caption = Value
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
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla CONTRATO_CTAS_PROVI
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	06/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
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
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla CONTRATO_CTAS_PROVI
    ''' filtrado por la tabla CONTRATO_FINAN
    ''' </summary>
    ''' <param name="ID_CONTRATO_FINAN"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	06/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorCONTRATO_FINAN(ByVal ID_CONTRATO_FINAN As Int32) As Integer
        Me.odsListaPorCONTRATO_FINAN.SelectParameters("ID_CONTRATO_FINAN").DefaultValue = ID_CONTRATO_FINAN.ToString()
        Me.odsListaPorCONTRATO_FINAN.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorCONTRATO_FINAN.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorCONTRATO_FINAN.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorCONTRATO_FINAN.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorCONTRATO_FINAN"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    Public Function CargarDatosPorCriterios(ByVal ID_ZAFRA As Int32, ByVal TIPO_CONTRIBUYENTE As Int32, ByVal CODIPROVEEDOR As String, _
                                             ByVal NOMBRE_PROVEEDOR As String, ByVal ID_CUENTA_FINAN As Int32) As Integer
        Me.odsListaPorCriterios.SelectParameters("ID_ZAFRA").DefaultValue = ID_ZAFRA.ToString
        Me.odsListaPorCriterios.SelectParameters("TIPO_CONTRIBUYENTE").DefaultValue = TIPO_CONTRIBUYENTE.ToString
        Me.odsListaPorCriterios.SelectParameters("CODIPROVEEDOR").DefaultValue = CODIPROVEEDOR
        Me.odsListaPorCriterios.SelectParameters("NOMBRE_PROVEEDOR").DefaultValue = NOMBRE_PROVEEDOR
        Me.odsListaPorCriterios.SelectParameters("ID_CUENTA_FINAN").DefaultValue = ID_CUENTA_FINAN.ToString
        Me.odsListaPorCriterios.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorCriterios"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla CONTRATO_CTAS_PROVI
    ''' filtrado por la tabla CONTRATO
    ''' </summary>
    ''' <param name="CODICONTRATO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	06/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorCONTRATO(ByVal CODICONTRATO As String) As Integer
        Me.odsListaPorCONTRATO.SelectParameters("CODICONTRATO").DefaultValue = CODICONTRATO.ToString()
        Me.odsListaPorCONTRATO.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorCONTRATO.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorCONTRATO.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorCONTRATO.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorCONTRATO"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla CONTRATO_CTAS_PROVI
    ''' filtrado por la tabla ZAFRA
    ''' </summary>
    ''' <param name="ID_ZAFRA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	06/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorZAFRA(ByVal ID_ZAFRA As Int32) As Integer
        Me.odsListaPorZAFRA.SelectParameters("ID_ZAFRA").DefaultValue = ID_ZAFRA.ToString()
        Me.odsListaPorZAFRA.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorZAFRA.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorZAFRA.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorZAFRA.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorZAFRA"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquÃ­ el cÃ³digo de usuario para inicializar la pÃ¡gina
        If Not Me.ViewState("PermitirEditar") Is Nothing Then Me._PermitirEditar = Me.ViewState("PermitirEditar")
        If Not Me.ViewState("PermitirSeleccionar") Is Nothing Then Me._PermitirSeleccionar = Me.ViewState("PermitirSeleccionar")
        If Not Me.ViewState("TextoSeleccionar") Is Nothing Then Me._TextoSeleccionar = Me.ViewState("TextoSeleccionar")
        If Not Me.ViewState("ComandoSeleccionar") Is Nothing Then Me._ComandoSeleccionar = Me.ViewState("ComandoSeleccionar")
    End Sub


    Protected Sub dxgvLista_CustomJSProperties(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewClientJSPropertiesEventArgs) Handles dxgvLista.CustomJSProperties
        If Me.PermitirSeleccionParaCombo Then
            Dim grid As DevExpress.Web.ASPxGridView = CType(sender, DevExpress.Web.ASPxGridView)
            Dim keyNames(grid.VisibleRowCount - 1) As Object
            Dim keyValues(grid.VisibleRowCount - 1) As Object
            For i As Integer = 0 To grid.VisibleRowCount - 1
                keyValues(i) = grid.GetRowValues(i, "ID_CONTRATO_CTAS_PROVI")
                keyNames(i) = grid.GetRowValues(i, "ID_CONTRATO_FINAN")
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
            RaiseEvent Editando(e.CommandArgs.CommandArgument)
        End If
    End Sub

    Protected Sub dxgvLista_HtmlRowCreated(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewTableRowEventArgs) Handles dxgvLista.HtmlRowCreated
        If e.RowType = DevExpress.Web.GridViewRowType.EditForm Then
            'Dim btnGuardar As DevExpress.Web.ASPxButton
            'Dim btnCancelar As DevExpress.Web.ASPxButton
            'btnGuardar = Me.dxgvLista.FindEditFormTemplateControl("btnGuardar")
            'btnCancelar = Me.dxgvLista.FindEditFormTemplateControl("btnCancelar")
            'btnGuardar.JSProperties.Add("cp_NombreClienteLista", Me.NombreGridCliente)
            'btnCancelar.JSProperties.Add("cp_NombreClienteLista", Me.NombreGridCliente)
        End If
        If e.RowType = DevExpress.Web.GridViewRowType.EmptyDataRow Then
            'Dim btnAgregar As DevExpress.Web.ASPxButton
            'btnAgregar = Me.dxgvLista.FindEmptyDataRowTemplateControl("btnAgregar")
            'btnAgregar.JSProperties.Add("cp_NombreClienteLista", Me.NombreGridCliente)
            'btnAgregar.Visible = Me.PermitirAgregarInline
            'Dim lblEmptyDataRow As DevExpress.Web.ASPxLabel
            'lblEmptyDataRow = Me.dxgvLista.FindEmptyDataRowTemplateControl("lblEmptyDataRow")
            'lblEmptyDataRow.Text = Me.dxgvLista.SettingsText.EmptyDataRow
        End If
        If e.RowType = DevExpress.Web.GridViewRowType.Data Then
            If Not Me.PermitirEditar Then
                'Dim lbDetalle As LinkButton
                'lbDetalle = Me.dxgvLista.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "lbtnEditar")
                'lbDetalle.Visible = False
            End If
            If Me.PermitirSeleccionar Then
                Dim lbSeleccionar As LinkButton
                lbSeleccionar = Me.dxgvLista.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "lbtnSeleccionar")
                lbSeleccionar.Visible = True
                lbSeleccionar.Text = Me.TextoSeleccionar
                lbSeleccionar.CommandName = Me.ComandoSeleccionar
                If lbSeleccionar.CommandName = "Check" Then
                    lbSeleccionar.Visible = False
                End If
            End If
        End If
    End Sub

    Public Function DevolverSeleccionados() As listaCONTRATO_CTAS_PROVI
        Dim mLista As New listaCONTRATO_CTAS_PROVI
        For Each llave As Decimal In Me.dxgvLista.GetSelectedFieldValues("ID_CONTRATO_CTAS_PROVI")
            Dim lEntidad As New CONTRATO_CTAS_PROVI
            lEntidad.ID_CONTRATO_CTAS_PROVI = llave
            mLista.Add(lEntidad)
        Next
        Return mLista
    End Function

    Protected Sub dxgvLista_CustomButtonCallback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewCustomButtonCallbackEventArgs) Handles dxgvLista.CustomButtonCallback
        If e.ButtonID = "btnEliminar" Then
            Dim lEntidad As CONTRATO_CTAS_PROVI = CType(Me.dxgvLista.GetRow(e.VisibleIndex), CONTRATO_CTAS_PROVI)

            If Me.mComponente.EliminarCONTRATO_CTAS_PROVI(lEntidad.ID_CONTRATO_CTAS_PROVI) <> 1 Then
                'Si se cometio un error
                Me.AsignarMensaje("Error al Eliminar Registro", True, True)
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
        If e.Column.FieldName = "CODIPROVEE" AndAlso Me.VerCODIPROVEE Then
            Dim lSolicitud As SOLIC_AGRICOLA = (New cSOLIC_AGRICOLA).ObtenerPorUID(e.GetListSourceFieldValue("UID_SOLICITUD"))
            If lSolicitud IsNot Nothing Then
                e.Value = Convert.ToInt32(Utilerias.RecuperarCODIPROVEE(lSolicitud.CODIPROVEEDOR))
            End If
        ElseIf e.Column.FieldName = "NOMBRE_PROVEEDOR" AndAlso Me.VerNOMBRE_PROVEEDOR Then
            Dim lSolicitud As SOLIC_AGRICOLA = (New cSOLIC_AGRICOLA).ObtenerPorUID(e.GetListSourceFieldValue("UID_SOLICITUD"))
            If lSolicitud IsNot Nothing Then
                e.Value = lSolicitud.NOMBRE_PROVEEDOR
            End If
        ElseIf e.Column.FieldName = "NO_CONTRATO" AndAlso Me.VerNO_CONTRATO Then
            Dim lSolicitud As SOLIC_AGRICOLA = (New cSOLIC_AGRICOLA).ObtenerPorUID(e.GetListSourceFieldValue("UID_SOLICITUD"))
            If lSolicitud IsNot Nothing Then
                Dim lContrato As CONTRATO = (New cCONTRATO).ObtenerCONTRATO(lSolicitud.CODICONTRATO)
                If lContrato IsNot Nothing Then e.Value = lContrato.NO_CONTRATO
            End If
        ElseIf e.Column.FieldName = "CONCEPTO_FINANCIAMIENTO" AndAlso Me.VerCONCEPTO Then
            Dim lCuentaFto As CUENTA_FINAN = (New cCUENTA_FINAN).ObtenerCUENTA_FINAN(e.GetListSourceFieldValue("ID_CUENTA_FINAN"))
            If lCuentaFto IsNot Nothing Then
                e.Value = lCuentaFto.NOMBRE_CUENTA
            End If
        End If
    End Sub
End Class
