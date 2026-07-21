Imports SISPACAL.BL
Imports SISPACAL.EL
Imports DevExpress.Web
Imports DevExpress.XtraPrinting
Imports DevExpress.Export

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucListaPAGO_CTA_BANCO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla PAGO_CTA_BANCO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	13/01/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucListaPAGO_CTA_BANCO
    Inherits ucListaBase

    Private mComponente As New cPAGO_CTA_BANCO
    Public Event Seleccionado(ByVal ID_PAGO_CTA_BANCO As Int32)
    Public Event Editando(ByVal ID_PAGO_CTA_BANCO As Int32)

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
            CType(Me.dxgvLista.Columns("Edicion"), DevExpress.Web.GridViewCommandColumn).ShowEditButton = value
            Me.dxgvLista.Columns("Edicion").Visible = Me.PermitirEditarInline
            Me.dxgvLista.SettingsEditing.Mode = DevExpress.Web.GridViewEditingMode.Inline
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

    Public Property EditarENTREGO_CCF() As Boolean
        Get
            Dim c As GridViewDataColumn = Me.dxgvLista.Columns("ENTREGO_CCF")
            If c IsNot Nothing Then Return Not c.ReadOnly Else Return True
        End Get
        Set(ByVal Value As Boolean)
            Dim c As GridViewDataColumn = Me.dxgvLista.Columns("ENTREGO_CCF")
            If c IsNot Nothing Then c.ReadOnly = Not Value
        End Set
    End Property

    Public Property EditarPAGO_GENERADO() As Boolean
        Get
            Dim c As GridViewDataColumn = Me.dxgvLista.Columns("PAGO_GENERADO")
            If c IsNot Nothing Then Return Not c.ReadOnly Else Return True
        End Get
        Set(ByVal Value As Boolean)
            Dim c As GridViewDataColumn = Me.dxgvLista.Columns("PAGO_GENERADO")
            If c IsNot Nothing Then c.ReadOnly = Not Value
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

    Public Property VerID_PAGO_CTA_BANCO() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_PAGO_CTA_BANCO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_PAGO_CTA_BANCO").Visible = Value
        End Set
    End Property

    Public Property VerID_CATORCENA() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_CATORCENA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_CATORCENA").Visible = Value
        End Set
    End Property

    Public Property VerCODIPROVEEDOR_TRANSPORTISTA() As Boolean
        Get
            Return Me.dxgvLista.Columns("CODIPROVEEDOR_TRANSPORTISTA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CODIPROVEEDOR_TRANSPORTISTA").Visible = Value
        End Set
    End Property

    Public Property VerID_TIPO_PLANILLA() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_TIPO_PLANILLA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_TIPO_PLANILLA").Visible = Value
        End Set
    End Property

    Public Property VerCODIBANCO() As Boolean
        Get
            Return Me.dxgvLista.Columns("CODIBANCO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CODIBANCO").Visible = Value
        End Set
    End Property

    Public Property VerNUM_CUENTA() As Boolean
        Get
            Return Me.dxgvLista.Columns("NUM_CUENTA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NUM_CUENTA").Visible = Value
        End Set
    End Property

    Public Property VerES_CTA_CORRIENTE() As Boolean
        Get
            Return Me.dxgvLista.Columns("ES_CTA_CORRIENTE").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ES_CTA_CORRIENTE").Visible = Value
        End Set
    End Property

    Public Property VerMONTO_PAGO() As Boolean
        Get
            Return Me.dxgvLista.Columns("MONTO_PAGO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("MONTO_PAGO").Visible = Value
        End Set
    End Property

    Public Property VerENTREGO_CCF() As Boolean
        Get
            Return Me.dxgvLista.Columns("ENTREGO_CCF").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ENTREGO_CCF").Visible = Value
        End Set
    End Property

    Public Property VerPAGO_GENERADO() As Boolean
        Get
            Return Me.dxgvLista.Columns("PAGO_GENERADO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("PAGO_GENERADO").Visible = Value
        End Set
    End Property

    Public Property VerFECHA_GENPAGO() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_GENPAGO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_GENPAGO").Visible = Value
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

    Public Property HeaderID_PAGO_CTA_BANCO() As String
        Get
            Return Me.dxgvLista.Columns("ID_PAGO_CTA_BANCO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_PAGO_CTA_BANCO").Caption = Value
        End Set
    End Property

    Public Property HeaderID_CATORCENA() As String
        Get
            Return Me.dxgvLista.Columns("ID_CATORCENA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_CATORCENA").Caption = Value
        End Set
    End Property

    Public Property HeaderCODIPROVEEDOR_TRANSPORTISTA() As String
        Get
            Return Me.dxgvLista.Columns("CODIPROVEEDOR_TRANSPORTISTA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CODIPROVEEDOR_TRANSPORTISTA").Caption = Value
        End Set
    End Property

    Public Property HeaderID_TIPO_PLANILLA() As String
        Get
            Return Me.dxgvLista.Columns("ID_TIPO_PLANILLA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_TIPO_PLANILLA").Caption = Value
        End Set
    End Property

    Public Property HeaderCODIBANCO() As String
        Get
            Return Me.dxgvLista.Columns("CODIBANCO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CODIBANCO").Caption = Value
        End Set
    End Property

    Public Property HeaderNUM_CUENTA() As String
        Get
            Return Me.dxgvLista.Columns("NUM_CUENTA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("NUM_CUENTA").Caption = Value
        End Set
    End Property

    Public Property HeaderES_CTA_CORRIENTE() As String
        Get
            Return Me.dxgvLista.Columns("ES_CTA_CORRIENTE").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ES_CTA_CORRIENTE").Caption = Value
        End Set
    End Property

    Public Property HeaderMONTO_PAGO() As String
        Get
            Return Me.dxgvLista.Columns("MONTO_PAGO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("MONTO_PAGO").Caption = Value
        End Set
    End Property

    Public Property HeaderENTREGO_CCF() As String
        Get
            Return Me.dxgvLista.Columns("ENTREGO_CCF").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ENTREGO_CCF").Caption = Value
        End Set
    End Property

    Public Property HeaderPAGO_GENERADO() As String
        Get
            Return Me.dxgvLista.Columns("PAGO_GENERADO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("PAGO_GENERADO").Caption = Value
        End Set
    End Property

    Public Property HeaderFECHA_GENPAGO() As String
        Get
            Return Me.dxgvLista.Columns("FECHA_GENPAGO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA_GENPAGO").Caption = Value
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
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla PAGO_CTA_BANCO
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	13/01/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorCriterios(ByVal ID_CATORCENA As Int32, ByVal ID_TIPO_PLANILLA As Int32, ByVal ES_CONTRIBUYENTE As Int32, ByVal MOSTRAR_POR As Int32) As Integer
        Me.odsListaPorCriterios.SelectParameters("ID_CATORCENA").DefaultValue = ID_CATORCENA.ToString
        Me.odsListaPorCriterios.SelectParameters("ID_TIPO_PLANILLA").DefaultValue = ID_TIPO_PLANILLA.ToString
        Me.odsListaPorCriterios.SelectParameters("ES_CONTRIBUYENTE").DefaultValue = ES_CONTRIBUYENTE.ToString
        Me.odsListaPorCriterios.SelectParameters("MOSTRAR_POR").DefaultValue = MOSTRAR_POR.ToString
        Me.odsListaPorCriterios.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorCriterios"
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla PAGO_CTA_BANCO
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	13/01/2017	Created
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
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla PAGO_CTA_BANCO
    ''' filtrado por la tabla CATORCENA_ZAFRA
    ''' </summary>
    ''' <param name="ID_CATORCENA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	13/01/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorCATORCENA_ZAFRA(ByVal ID_CATORCENA As Int32) As Integer
        Me.odsListaPorCATORCENA_ZAFRA.SelectParameters("ID_CATORCENA").DefaultValue = ID_CATORCENA.ToString()
        Me.odsListaPorCATORCENA_ZAFRA.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorCATORCENA_ZAFRA.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorCATORCENA_ZAFRA.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorCATORCENA_ZAFRA.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorCATORCENA_ZAFRA"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla PAGO_CTA_BANCO
    ''' filtrado por la tabla PLANILLA
    ''' </summary>
    ''' <param name="ID_CATORCENA"></param>
    ''' <param name="CODIPROVEEDOR_TRANSPORTISTA"></param>
    ''' <param name="ID_TIPO_PLANILLA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	13/01/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorPLANILLA(ByVal ID_CATORCENA As Int32, ByVal CODIPROVEEDOR_TRANSPORTISTA As String, ByVal ID_TIPO_PLANILLA As Int32) As Integer
        Me.odsListaPorPLANILLA.SelectParameters("ID_CATORCENA").DefaultValue = ID_CATORCENA.ToString()
        Me.odsListaPorPLANILLA.SelectParameters("CODIPROVEEDOR_TRANSPORTISTA").DefaultValue = CODIPROVEEDOR_TRANSPORTISTA.ToString()
        Me.odsListaPorPLANILLA.SelectParameters("ID_TIPO_PLANILLA").DefaultValue = ID_TIPO_PLANILLA.ToString()
        Me.odsListaPorPLANILLA.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorPLANILLA.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorPLANILLA.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorPLANILLA.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorPLANILLA"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla PAGO_CTA_BANCO
    ''' filtrado por la tabla TIPO_PLANILLA
    ''' </summary>
    ''' <param name="ID_TIPO_PLANILLA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	13/01/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorTIPO_PLANILLA(ByVal ID_TIPO_PLANILLA As Int32) As Integer
        Me.odsListaPorTIPO_PLANILLA.SelectParameters("ID_TIPO_PLANILLA").DefaultValue = ID_TIPO_PLANILLA.ToString()
        Me.odsListaPorTIPO_PLANILLA.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorTIPO_PLANILLA.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorTIPO_PLANILLA.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorTIPO_PLANILLA.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorTIPO_PLANILLA"
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
                keyValues(i) = grid.GetRowValues(i, "ID_PAGO_CTA_BANCO")
                keyNames(i) = grid.GetRowValues(i, "ID_CATORCENA")
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
            RaiseEvent Seleccionado(e.KeyValue)
        End If
        If e.CommandArgs.CommandName = "Editar" Then
            RaiseEvent Editando(e.KeyValue)
        End If

    End Sub

    Public Sub ExportarToXls(Optional Descripcion As String = "")
        gridExport.WriteXlsToResponse("PAGO A CUENTA - " + Descripcion + " " + cFechaHora.ObtenerFechaHora.ToString("ddMMyyyy HH.mm.ss"), New XlsExportOptionsEx With {.ExportType = ExportType.WYSIWYG})
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
                Dim lbDetalle As LinkButton
                lbDetalle = Me.dxgvLista.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "lbtnEditar")
                lbDetalle.Visible = False
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

    Public Function DevolverSeleccionados() As listaPAGO_CTA_BANCO
        Dim mLista As New listaPAGO_CTA_BANCO
        For Each llave As Decimal In Me.dxgvLista.GetSelectedFieldValues("ID_PAGO_CTA_BANCO")
            Dim lEntidad As New PAGO_CTA_BANCO
            lEntidad.ID_PAGO_CTA_BANCO = llave
            mLista.Add(lEntidad)
        Next
        Return mLista
    End Function

    Protected Sub dxgvLista_CustomButtonCallback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewCustomButtonCallbackEventArgs) Handles dxgvLista.CustomButtonCallback
        If e.ButtonID = "btnEliminar" Then
            Dim lEntidad As PAGO_CTA_BANCO = CType(Me.dxgvLista.GetRow(e.VisibleIndex), PAGO_CTA_BANCO)

            If Me.mComponente.EliminarPAGO_CTA_BANCO(lEntidad.ID_PAGO_CTA_BANCO) <> 1 Then
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
        If e.Column.FieldName = "NOMBRE_TIPO_PLANILLA" Then
            Dim lEntidad As TIPO_PLANILLA = (New cTIPO_PLANILLA).ObtenerTIPO_PLANILLA(e.GetListSourceFieldValue("ID_TIPO_PLANILLA"))
            If lEntidad IsNot Nothing Then e.Value = lEntidad.NOMBRE_TIPO_PLANILLA
        ElseIf e.Column.FieldName = "CATORCENA" Then
            Dim lEntidad As CATORCENA_ZAFRA = (New cCATORCENA_ZAFRA).ObtenerCATORCENA_ZAFRA(e.GetListSourceFieldValue("ID_CATORCENA"))
            If lEntidad IsNot Nothing Then e.Value = lEntidad.CATORCENA.ToString
        ElseIf e.Column.FieldName = "NOMBRE_ZAFRA" Then
            Dim lEntidad As CATORCENA_ZAFRA = (New cCATORCENA_ZAFRA).ObtenerCATORCENA_ZAFRA(e.GetListSourceFieldValue("ID_CATORCENA"))
            If lEntidad IsNot Nothing Then
                Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZAFRA(lEntidad.ID_ZAFRA)
                If lZafra IsNot Nothing Then e.Value = lZafra.NOMBRE_ZAFRA
            End If
        ElseIf e.Column.FieldName = "NOMBRE_PROVEEDOR_TRANSPORTISTA" Then
            If e.GetListSourceFieldValue("ID_TIPO_PLANILLA") = 1 OrElse e.GetListSourceFieldValue("ID_TIPO_PLANILLA") = 6 Then
                Dim lEntidad As PROVEEDOR = (New cPROVEEDOR).ObtenerPROVEEDOR(e.GetListSourceFieldValue("CODIPROVEEDOR_TRANSPORTISTA"))
                If lEntidad IsNot Nothing Then e.Value = lEntidad.NOMBRES + " " + lEntidad.APELLIDOS
            ElseIf e.GetListSourceFieldValue("ID_TIPO_PLANILLA") = 2 Then
                Dim lEntidad As TRANSPORTISTA = (New cTRANSPORTISTA).ObtenerTRANSPORTISTA(e.GetListSourceFieldValue("CODIPROVEEDOR_TRANSPORTISTA"))
                If lEntidad IsNot Nothing Then e.Value = lEntidad.NOMBRES + " " + lEntidad.APELLIDOS
            End If
        ElseIf e.Column.FieldName = "FECHA_GENPAGO_" Then
            If e.GetListSourceFieldValue("FECHA_GENPAGO") <> Nothing Then
                e.Value = CDate(e.GetListSourceFieldValue("FECHA_GENPAGO")).ToString("dd/MM/yyyy HH:mm")
            End If
        ElseIf e.Column.FieldName = "CODIGO" Then
            If e.GetListSourceFieldValue("ID_TIPO_PLANILLA") <> 2 Then
                e.Value = CInt(Utilerias.RecuperarCODIPROVEE(e.GetListSourceFieldValue("CODIPROVEEDOR_TRANSPORTISTA")))
            Else
                e.Value = CInt(e.GetListSourceFieldValue("CODIPROVEEDOR_TRANSPORTISTA"))
            End If
        ElseIf e.Column.FieldName = "NOMBRE_BANCO" Then
            Dim lEntidad As BANCOS = (New cBANCOS).ObtenerBANCOS(e.GetListSourceFieldValue("CODIBANCO"))
            If lEntidad IsNot Nothing Then e.Value = lEntidad.NOMBRE_BANCO
        End If
    End Sub
End Class
