Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucListaPRE_ANALISIS_DETA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla PRE_ANALISIS_DETA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	22/05/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucListaPRE_ANALISIS_DETA
    Inherits ucListaBase
 
    Private mComponente As New cPRE_ANALISIS_DETA
    Public Event Seleccionado(ByVal ID_DETA As Int32) 
    Public Event Editando(ByVal ID_DETA As Int32) 

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

    Public Property TextoHeaderZAFRA1() As String
        Get
            Return Me.dxgvLista.Columns("MONTO1").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("MONTO1").Caption = Value
        End Set
    End Property

    Public Property TextoHeaderZAFRA2() As String
        Get
            Return Me.dxgvLista.Columns("MONTO2").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("MONTO2").Caption = Value
        End Set
    End Property

    Public Property TextoHeaderZAFRA3() As String
        Get
            Return Me.dxgvLista.Columns("MONTO3").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("MONTO3").Caption = Value
        End Set
    End Property

    Public Property TextoHeaderZAFRA4() As String
        Get
            Return Me.dxgvLista.Columns("MONTO4").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("MONTO4").Caption = Value
        End Set
    End Property

    Public Property TextoHeaderZAFRA5() As String
        Get
            Return Me.dxgvLista.Columns("MONTO5").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("MONTO5").Caption = Value
        End Set
    End Property

    Public Property TextoHeaderZAFRA6() As String
        Get
            Return Me.dxgvLista.Columns("MONTO6").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("MONTO6").Caption = Value
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

    Public Property VerID_DETA() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_DETA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_DETA").Visible = Value
        End Set
    End Property

    Public Property VerID_ENCA() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_ENCA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_ENCA").Visible = Value
        End Set
    End Property

    Public Property VerUID_REF() As Boolean
        Get
            Return Me.dxgvLista.Columns("UID_REF").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("UID_REF").Visible = Value
        End Set
    End Property

    Public Property VerORDEN() As Boolean
        Get
            Return Me.dxgvLista.Columns("ORDEN").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ORDEN").Visible = Value
        End Set
    End Property

    Public Property VerNUMERO() As Boolean
        Get
            Return Me.dxgvLista.Columns("NUMERO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NUMERO").Visible = Value
        End Set
    End Property

    Public Property VerDESCRIPCION() As Boolean
        Get
            Return Me.dxgvLista.Columns("DESCRIPCION").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("DESCRIPCION").Visible = Value
        End Set
    End Property

    Public Property VerMONTO() As Boolean
        Get
            Return Me.dxgvLista.Columns("MONTO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("MONTO").Visible = Value
        End Set
    End Property

    Public Property VerTARIFA_CAT() As Boolean
        Get
            Return Me.dxgvLista.Columns("TARIFA_CAT").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TARIFA_CAT").Visible = Value
        End Set
    End Property

    Public Property VerTARIFA_CAT_DESCRIP() As Boolean
        Get
            Return Me.dxgvLista.Columns("TARIFA_CAT_DESCRIP").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TARIFA_CAT_DESCRIP").Visible = Value
        End Set
    End Property

    Public Property VerID_CATE() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_CATE").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_CATE").Visible = Value
        End Set
    End Property

    Public Property VerID_CATE_REF() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_CATE_REF").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_CATE_REF").Visible = Value
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

    Public Property VerEDITAR() As Boolean
        Get
            Return Me.dxgvLista.Columns("EDITAR").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("EDITAR").Visible = Value
        End Set
    End Property

    Public Property VerNEGRITA() As Boolean
        Get
            Return Me.dxgvLista.Columns("NEGRITA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NEGRITA").Visible = Value
        End Set
    End Property

    Public Property HeaderID_DETA() As String
        Get
            Return Me.dxgvLista.Columns("ID_DETA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_DETA").Caption = Value
        End Set
    End Property

    Public Property HeaderID_ENCA() As String
        Get
            Return Me.dxgvLista.Columns("ID_ENCA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_ENCA").Caption = Value
        End Set
    End Property

    Public Property HeaderUID_REF() As String
        Get
            Return Me.dxgvLista.Columns("UID_REF").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("UID_REF").Caption = Value
        End Set
    End Property

    Public Property HeaderORDEN() As String
        Get
            Return Me.dxgvLista.Columns("ORDEN").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ORDEN").Caption = Value
        End Set
    End Property

    Public Property HeaderNUMERO() As String
        Get
            Return Me.dxgvLista.Columns("NUMERO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("NUMERO").Caption = Value
        End Set
    End Property

    Public Property HeaderDESCRIPCION() As String
        Get
            Return Me.dxgvLista.Columns("DESCRIPCION").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("DESCRIPCION").Caption = Value
        End Set
    End Property

    Public Property HeaderMONTO() As String
        Get
            Return Me.dxgvLista.Columns("MONTO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("MONTO").Caption = Value
        End Set
    End Property

    Public Property HeaderTARIFA_CAT() As String
        Get
            Return Me.dxgvLista.Columns("TARIFA_CAT").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TARIFA_CAT").Caption = Value
        End Set
    End Property

    Public Property HeaderTARIFA_CAT_DESCRIP() As String
        Get
            Return Me.dxgvLista.Columns("TARIFA_CAT_DESCRIP").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TARIFA_CAT_DESCRIP").Caption = Value
        End Set
    End Property

    Public Property HeaderID_CATE() As String
        Get
            Return Me.dxgvLista.Columns("ID_CATE").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_CATE").Caption = Value
        End Set
    End Property

    Public Property HeaderID_CATE_REF() As String
        Get
            Return Me.dxgvLista.Columns("ID_CATE_REF").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_CATE_REF").Caption = Value
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

    Public Property HeaderEDITAR() As String
        Get
            Return Me.dxgvLista.Columns("EDITAR").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("EDITAR").Caption = Value
        End Set
    End Property

    Public Property HeaderNEGRITA() As String
        Get
            Return Me.dxgvLista.Columns("NEGRITA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("NEGRITA").Caption = Value
        End Set
    End Property

#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla PRE_ANALISIS_DETA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	22/05/2017	Created
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
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla PRE_ANALISIS_DETA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	22/05/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorUID_REF(ByVal UID_REF As String) As Integer
        Me.odsListaPorUIF_REF.SelectParameters("UID_REF").DefaultValue = UID_REF
        Me.odsListaPorUIF_REF.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorUIF_REF"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla PRE_ANALISIS_DETA
    ''' filtrado por la tabla PRE_ANALISIS_ENCA
    ''' </summary>
    ''' <param name="ID_ENCA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	22/05/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorPRE_ANALISIS_ENCA(ByVal ID_ENCA As Int32) As Integer
        Me.odsListaPorPRE_ANALISIS_ENCA.SelectParameters("ID_ENCA").DefaultValue = ID_ENCA.ToString()
        Me.odsListaPorPRE_ANALISIS_ENCA.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorPRE_ANALISIS_ENCA.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorPRE_ANALISIS_ENCA.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorPRE_ANALISIS_ENCA.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorPRE_ANALISIS_ENCA"
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

    Protected Sub dxgvLista_CommandButtonInitialize(sender As Object, e As DevExpress.Web.ASPxGridViewCommandButtonEventArgs) Handles dxgvLista.CommandButtonInitialize
        If e.ButtonType = DevExpress.Web.ColumnCommandButtonType.Edit Then
            If Convert.ToBoolean(dxgvLista.GetRowValues(e.VisibleIndex, "EDITAR")) Then
                e.Visible = True
            Else
                e.Visible = False
            End If
        End If
    End Sub


    Protected Sub dxgvLista_CustomJSProperties(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewClientJSPropertiesEventArgs) Handles dxgvLista.CustomJSProperties
        If Me.PermitirSeleccionParaCombo Then
            Dim grid As DevExpress.Web.ASPxGridView = CType(sender, DevExpress.Web.ASPxGridView)
            Dim keyNames(grid.VisibleRowCount - 1) As Object
            Dim keyValues(grid.VisibleRowCount - 1) As Object
            For i As Integer = 0 To grid.VisibleRowCount - 1
                keyValues(i) = grid.GetRowValues(i, "ID_DETA")
                keyNames(i) = grid.GetRowValues(i, "ID_ENCA")
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
        'CType(Me.dxgvLista.Columns("Edicion"), DevExpress.Web.GridViewCommandColumn).ShowEditButton = Me.PermitirEditarInline
        If Me.PermitirEditar OrElse Me.PermitirEditarInline Then
            Me.dxgvLista.Columns("Edicion").Visible = True
        Else
            Me.dxgvLista.Columns("Edicion").Visible = True
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
                'Dim lbSeleccionar As LinkButton
                'lbSeleccionar = Me.dxgvLista.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "lbtnSeleccionar")
                'lbSeleccionar.Visible = True
                'lbSeleccionar.Text = Me.TextoSeleccionar
                'lbSeleccionar.CommandName = Me.ComandoSeleccionar
                'If lbSeleccionar.CommandName = "Check" Then
                '    lbSeleccionar.Visible = False
                'End If
            End If
        End If
    End Sub

    Public Function DevolverSeleccionados() As listaPRE_ANALISIS_DETA
        Dim mLista As New listaPRE_ANALISIS_DETA
        For Each llave As Decimal In Me.dxgvLista.GetSelectedFieldValues("ID_DETA")
            Dim lEntidad As New PRE_ANALISIS_DETA
            lEntidad.ID_DETA = llave
            mLista.Add(lEntidad)
        Next
        Return mLista
    End Function

    Protected Sub dxgvLista_CustomButtonCallback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewCustomButtonCallbackEventArgs) Handles dxgvLista.CustomButtonCallback
        If e.ButtonID = "btnEliminar" Then
            Dim lEntidad As PRE_ANALISIS_DETA = CType(Me.dxgvLista.GetRow(e.VisibleIndex), PRE_ANALISIS_DETA)

            If Me.mComponente.EliminarPRE_ANALISIS_DETA(lEntidad.ID_DETA) <> 1 Then
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

    Protected Sub dxgvLista_HtmlDataCellPrepared(sender As Object, e As DevExpress.Web.ASPxGridViewTableDataCellEventArgs) Handles dxgvLista.HtmlDataCellPrepared
        If e.DataColumn.FieldName = "DESCRIPCION" OrElse e.DataColumn.FieldName = "TARIFA_CAT" Then
            If e.GetValue("ID_CATE") = 1 Then
                e.Cell.Font.Bold = True
                e.Cell.Font.Size = FontUnit.Small
                e.Cell.BackColor = Drawing.Color.FromArgb(146, 208, 80)
            End If
        End If
        If e.DataColumn.FieldName = "MONTO1" OrElse e.DataColumn.FieldName = "MONTO2" OrElse _
            e.DataColumn.FieldName = "MONTO3" OrElse e.DataColumn.FieldName = "MONTO4" OrElse _
            e.DataColumn.FieldName = "MONTO5" OrElse e.DataColumn.FieldName = "MONTO6" OrElse _
            e.DataColumn.FieldName = "TOTAL" Then
            If e.GetValue("ID_CATE") = 1 Then
                e.Cell.Font.Bold = True
                e.Cell.Font.Size = FontUnit.Small
                e.Cell.BackColor = Drawing.Color.FromArgb(146, 208, 80)
            End If
        End If
    End Sub
End Class
