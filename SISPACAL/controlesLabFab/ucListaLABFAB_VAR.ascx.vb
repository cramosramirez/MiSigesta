Imports SISPACAL.BL
Imports SISPACAL.EL
Imports DevExpress.Web
Imports SISPACAL.EL.Enumeradores

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucListaLABFAB_VAR
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla LABFAB_VAR
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	18/11/2015	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucListaLABFAB_VAR
    Inherits ucListaBase

    Private mComponente As New cLABFAB_VAR
    Public Event Seleccionado(ByVal ID_VAR As Int32)
    Public Event Editando(ByVal ID_VAR As Int32)

#Region "Propiedades"

    Public Property REFERENCIA() As String
        Get
            Return Me.ViewState("REFERENCIA")
        End Get
        Set(ByVal value As String)
            Me.ViewState("REFERENCIA") = value
        End Set
    End Property

    Public Sub IniciarEdicion()
        dxgvLista.StartEdit(dxgvLista.VisibleStartIndex)
    End Sub

    Public Sub CancelarEdicion()
        dxgvLista.CancelEdit()
    End Sub


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
        End Set
    End Property

    Public Property PermitirEliminarInline() As Boolean
        Get
            Return Me.ViewState("PermitirEliminacionInline")
        End Get
        Set(ByVal value As Boolean)
            Me.ViewState("PermitirEliminacionInline") = value
            CType(Me.dxgvLista.Columns("Eliminar"), DevExpress.Web.GridViewCommandColumn).ShowDeleteButton = value
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

    Public Property VerID_VAR() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_VAR").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_VAR").Visible = Value
        End Set
    End Property

    Public Property VerID_ANALISIS() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_ANALISIS").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_ANALISIS").Visible = Value
        End Set
    End Property

    Public Property VerID_TIPOVAR() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_TIPOVAR").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_TIPOVAR").Visible = Value
        End Set
    End Property

    Public Property VerCOD_VAR() As Boolean
        Get
            Return Me.dxgvLista.Columns("COD_VAR").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("COD_VAR").Visible = Value
        End Set
    End Property

    Public Property VerDESCRIP_VAR() As Boolean
        Get
            Return Me.dxgvLista.Columns("DESCRIP_VAR").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("DESCRIP_VAR").Visible = Value
        End Set
    End Property

    Public Property VerID_ANALISIS_REF() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_ANALISIS_REF").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_ANALISIS_REF").Visible = Value
        End Set
    End Property

    Public Property VerTABLA_REF() As Boolean
        Get
            Return Me.dxgvLista.Columns("TABLA_REF").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TABLA_REF").Visible = Value
        End Set
    End Property

    Public Property VerCOLUM1_REF() As Boolean
        Get
            Return Me.dxgvLista.Columns("COLUM1_REF").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("COLUM1_REF").Visible = Value
        End Set
    End Property

    Public Property VerCOLUM2_REF() As Boolean
        Get
            Return Me.dxgvLista.Columns("COLUM2_REF").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("COLUM2_REF").Visible = Value
        End Set
    End Property

    Public Property VerCOLUM_VALOR_REF() As Boolean
        Get
            Return Me.dxgvLista.Columns("COLUM_VALOR_REF").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("COLUM_VALOR_REF").Visible = Value
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

    Public Property HeaderID_VAR() As String
        Get
            Return Me.dxgvLista.Columns("ID_VAR").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_VAR").Caption = Value
        End Set
    End Property

    Public Property HeaderID_ANALISIS() As String
        Get
            Return Me.dxgvLista.Columns("ID_ANALISIS").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_ANALISIS").Caption = Value
        End Set
    End Property

    Public Property HeaderID_TIPOVAR() As String
        Get
            Return Me.dxgvLista.Columns("ID_TIPOVAR").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_TIPOVAR").Caption = Value
        End Set
    End Property

    Public Property HeaderCOD_VAR() As String
        Get
            Return Me.dxgvLista.Columns("COD_VAR").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("COD_VAR").Caption = Value
        End Set
    End Property

    Public Property HeaderDESCRIP_VAR() As String
        Get
            Return Me.dxgvLista.Columns("DESCRIP_VAR").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("DESCRIP_VAR").Caption = Value
        End Set
    End Property

    Public Property HeaderID_ANALISIS_REF() As String
        Get
            Return Me.dxgvLista.Columns("ID_ANALISIS_REF").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_ANALISIS_REF").Caption = Value
        End Set
    End Property

    Public Property HeaderTABLA_REF() As String
        Get
            Return Me.dxgvLista.Columns("TABLA_REF").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TABLA_REF").Caption = Value
        End Set
    End Property

    Public Property HeaderCOLUM1_REF() As String
        Get
            Return Me.dxgvLista.Columns("COLUM1_REF").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("COLUM1_REF").Caption = Value
        End Set
    End Property

    Public Property HeaderCOLUM2_REF() As String
        Get
            Return Me.dxgvLista.Columns("COLUM2_REF").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("COLUM2_REF").Caption = Value
        End Set
    End Property

    Public Property HeaderCOLUM_VALOR_REF() As String
        Get
            Return Me.dxgvLista.Columns("COLUM_VALOR_REF").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("COLUM_VALOR_REF").Caption = Value
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
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla LABFAB_VAR
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/11/2015	Created
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
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla LABFAB_VAR
    ''' filtrado por la tabla LABFAB_ANALISIS
    ''' </summary>
    ''' <param name="ID_ANALISIS"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/11/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorLABFAB_ANALISIS(ByVal ID_ANALISIS As Int32) As Integer
        Me.odsListaPorLABFAB_ANALISIS.SelectParameters("ID_ANALISIS").DefaultValue = ID_ANALISIS.ToString()
        Me.odsListaPorLABFAB_ANALISIS.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorLABFAB_ANALISIS.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorLABFAB_ANALISIS.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorLABFAB_ANALISIS.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorLABFAB_ANALISIS"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function


    Public Function CargarDatosCache(ByVal nombreSesion As String) As Integer
        Me.REFERENCIA = nombreSesion
        Me.odsLABFAB_VARCache.SelectParameters("nombreSesion").DefaultValue = nombreSesion
        Me.odsLABFAB_VARCache.DataBind()
        Me.dxgvLista.DataSourceID = "odsLABFAB_VARCache"
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla LABFAB_VAR
    ''' filtrado por la tabla LABFAB_TIPOVAR
    ''' </summary>
    ''' <param name="ID_TIPOVAR"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/11/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorLABFAB_TIPOVAR(ByVal ID_TIPOVAR As Int32) As Integer
        Me.odsListaPorLABFAB_TIPOVAR.SelectParameters("ID_TIPOVAR").DefaultValue = ID_TIPOVAR.ToString()
        Me.odsListaPorLABFAB_TIPOVAR.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorLABFAB_TIPOVAR.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorLABFAB_TIPOVAR.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorLABFAB_TIPOVAR.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorLABFAB_TIPOVAR"
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
                keyValues(i) = grid.GetRowValues(i, "ID_VAR")
                keyNames(i) = grid.GetRowValues(i, "ID_ANALISIS")
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
            CType(Me.dxgvLista.Columns("Edicion"), DevExpress.Web.GridViewCommandColumn).ShowEditButton = Me.PermitirEditarInline
            CType(Me.dxgvLista.Columns("Edicion"), DevExpress.Web.GridViewCommandColumn).ShowDeleteButton = Me.PermitirEliminarInline
        End If
        If Me.PermitirEditarInline Then
            Me.dxgvLista.SettingsEditing.Mode = DevExpress.Web.GridViewEditingMode.Inline
        End If
        If Me.NombreComboCliente = "" Then
            Me.dxgvLista.ClientSideEvents.RowClick = ""
        End If
        dxgvLista.ForceDataRowType(GetType(listaLABFAB_VAR))
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

    Public Function DevolverSeleccionados() As listaLABFAB_VAR
        Dim mLista As New listaLABFAB_VAR
        For Each llave As Decimal In Me.dxgvLista.GetSelectedFieldValues("ID_VAR")
            Dim lEntidad As New LABFAB_VAR
            lEntidad.ID_VAR = llave
            mLista.Add(lEntidad)
        Next
        Return mLista
    End Function

    Protected Sub dxgvLista_CustomButtonCallback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewCustomButtonCallbackEventArgs) Handles dxgvLista.CustomButtonCallback
        If e.ButtonID = "btnEliminar" Then
            Dim lEntidad As LABFAB_VAR = CType(Me.dxgvLista.GetRow(e.VisibleIndex), LABFAB_VAR)

            If Me.mComponente.EliminarLABFAB_VAR(lEntidad.ID_VAR) <> 1 Then
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

    Protected Sub dxgvLista_InitNewRow(sender As Object, e As DevExpress.Web.Data.ASPxDataInitNewRowEventArgs) Handles dxgvLista.InitNewRow
        e.NewValues("REFERENCIA") = Me.REFERENCIA
    End Sub

    Protected Sub dxgvLista_RowInserting(sender As Object, e As DevExpress.Web.Data.ASPxDataInsertingEventArgs) Handles dxgvLista.RowInserting
        e.NewValues("REFERENCIA") = Me.REFERENCIA
    End Sub

    Protected Sub dxgvLista_RowValidating(sender As Object, e As DevExpress.Web.Data.ASPxDataValidationEventArgs) Handles dxgvLista.RowValidating
        Dim mID_TIPOVAR As Int32 = -1
        Dim mNOMBRE_VAR As String = ""
        Dim mDESCRIP_VAR As String = ""
        Dim mID_ANALISIS_REF As Int32 = -1
        Dim mTABLA_REF As String = ""
        Dim mCOLUM1_REF As String = ""
        Dim mCOLUM2_REF As String = ""
        Dim mCOLUM_VALOR_REF As String = ""

        For Each column As GridViewColumn In dxgvLista.Columns
            Dim dataColumn As GridViewDataColumn = TryCast(column, GridViewDataColumn)

            If Not dataColumn Is Nothing Then
                Select Case dataColumn.FieldName
                    Case "ID_TIPOVAR"
                        mID_TIPOVAR = If(e.NewValues(dataColumn.FieldName) Is Nothing, -1, e.NewValues(dataColumn.FieldName))
                    Case "DESCRIP_VAR"
                        mDESCRIP_VAR = If(e.NewValues(dataColumn.FieldName) Is Nothing, "", e.NewValues(dataColumn.FieldName))
                    Case "ID_ANALISIS_REF"
                        mID_ANALISIS_REF = If(e.NewValues(dataColumn.FieldName) Is Nothing, -1, e.NewValues(dataColumn.FieldName))
                    Case "TABLA_REF"
                        mTABLA_REF = If(e.NewValues(dataColumn.FieldName) Is Nothing, "", e.NewValues(dataColumn.FieldName))
                    Case "COLUM1_REF"
                        mCOLUM1_REF = If(e.NewValues(dataColumn.FieldName) Is Nothing, "", e.NewValues(dataColumn.FieldName))
                    Case "COLUM2_REF"
                        mCOLUM2_REF = If(e.NewValues(dataColumn.FieldName) Is Nothing, "", e.NewValues(dataColumn.FieldName))
                    Case "COLUM_VALOR_REF"
                        mCOLUM_VALOR_REF = If(e.NewValues(dataColumn.FieldName) Is Nothing, "", e.NewValues(dataColumn.FieldName))
                End Select
            End If
        Next column

        For Each column As GridViewColumn In dxgvLista.Columns
            Dim dataColumn As GridViewDataColumn = TryCast(column, GridViewDataColumn)

            If Not dataColumn Is Nothing Then
                Select Case dataColumn.FieldName
                    Case "ID_TIPOVAR"
                        If mID_TIPOVAR = -1 Then
                            e.Errors(dataColumn) = "Seleccione el tipo de variable"
                        End If
                    Case "ID_ANALISIS_REF"
                        If (mID_TIPOVAR = TipoLabFabVariable.ResultadoAnalisis OrElse _
                            mID_TIPOVAR = TipoLabFabVariable.CalculadoEnFuncionAnalisis) AndAlso mID_ANALISIS_REF = -1 Then
                            e.Errors(dataColumn) = "Seleccione el análisis de referencia"
                        End If
                    Case "TABLA_REF"
                        If mID_TIPOVAR = TipoLabFabVariable.CalculadoEnFuncionAnalisis AndAlso mID_ANALISIS_REF = -1 Then
                            e.Errors(dataColumn) = "Ingrese el nombre de la tabla referencia"
                        End If
                    Case "COLUM1_REF"
                        If mID_TIPOVAR = TipoLabFabVariable.CalculadoEnFuncionAnalisis AndAlso mCOLUM1_REF = "" Then
                            e.Errors(dataColumn) = "Ingrese el nombre de la columna 1 de la tabla referencia"
                        End If
                    Case "COLUM_VALOR_REF"
                        If mID_TIPOVAR = TipoLabFabVariable.CalculadoEnFuncionAnalisis AndAlso mCOLUM_VALOR_REF = "" Then
                            e.Errors(dataColumn) = "Ingrese el nombre de la columna que contiene el valor en la tabla referencia"
                        End If
                End Select
            End If
        Next column

        If e.Errors.Count > 0 Then
            e.RowError = "Existe información incompleta"
        End If
    End Sub

    Protected Sub dxgvLista_RowUpdating(sender As Object, e As DevExpress.Web.Data.ASPxDataUpdatingEventArgs) Handles dxgvLista.RowUpdating
        e.NewValues("REFERENCIA") = Me.REFERENCIA
    End Sub
End Class
