Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucListaLABFAB_INFOVAR
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla LABFAB_INFOVAR
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	28/11/2015	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucListaLABFAB_INFOVAR
    Inherits ucListaBase
 
    Private mComponente As New cLABFAB_INFOVAR
    Public Event Seleccionado(ByVal ID_INFOVAR As Int32) 
    Public Event Editando(ByVal ID_INFOVAR As Int32) 

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

    Public Property NombreGridCliente() As String
        Get
            Return dxgvLista.ClientInstanceName
        End Get
        Set(ByVal value As String)
            dxgvLista.ClientInstanceName = value
        End Set
    End Property

    Public Property VerID_INFOVAR() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_INFOVAR").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_INFOVAR").Visible = Value
        End Set
    End Property

    Public Property VerID_INFO() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_INFO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_INFO").Visible = Value
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

    Public Property VerID_CATEG() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_CATEG").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_CATEG").Visible = Value
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

    Public Property VerNOMBRE_INFOVAR() As Boolean
        Get
            Return Me.dxgvLista.Columns("NOMBRE_INFOVAR").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NOMBRE_INFOVAR").Visible = Value
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

    Public Property VerID_INFOVAR_REF() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_INFOVAR_REF").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_INFOVAR_REF").Visible = Value
        End Set
    End Property

    Public Property VerSQLREPO() As Boolean
        Get
            Return Me.dxgvLista.Columns("SQLREPO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("SQLREPO").Visible = Value
        End Set
    End Property

    Public Property HeaderID_INFOVAR() As String
        Get
            Return Me.dxgvLista.Columns("ID_INFOVAR").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_INFOVAR").Caption = Value
        End Set
    End Property

    Public Property HeaderID_INFO() As String
        Get
            Return Me.dxgvLista.Columns("ID_INFO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_INFO").Caption = Value
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

    Public Property HeaderID_CATEG() As String
        Get
            Return Me.dxgvLista.Columns("ID_CATEG").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_CATEG").Caption = Value
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

    Public Property HeaderNOMBRE_INFOVAR() As String
        Get
            Return Me.dxgvLista.Columns("NOMBRE_INFOVAR").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("NOMBRE_INFOVAR").Caption = Value
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

    Public Property HeaderID_INFOVAR_REF() As String
        Get
            Return Me.dxgvLista.Columns("ID_INFOVAR_REF").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_INFOVAR_REF").Caption = Value
        End Set
    End Property

    Public Property HeaderSQLREPO() As String
        Get
            Return Me.dxgvLista.Columns("SQLREPO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("SQLREPO").Caption = Value
        End Set
    End Property

#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla LABFAB_INFOVAR
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/11/2015	Created
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
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla LABFAB_INFOVAR
    ''' filtrado por la tabla LABFAB_INFORME
    ''' </summary>
    ''' <param name="ID_INFO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/11/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorLABFAB_INFORME(ByVal ID_INFO As Int32) As Integer
        Me.odsListaPorLABFAB_INFORME.SelectParameters("ID_INFO").DefaultValue = ID_INFO.ToString()
        Me.odsListaPorLABFAB_INFORME.SelectParameters("recuperarHijas").DefaultValue = "False"
        Me.odsListaPorLABFAB_INFORME.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorLABFAB_INFORME.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorLABFAB_INFORME.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorLABFAB_INFORME.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorLABFAB_INFORME"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla LABFAB_INFOVAR
    ''' filtrado por la tabla LABFAB_TIPOVAR
    ''' </summary>
    ''' <param name="ID_TIPOVAR"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/11/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorLABFAB_TIPOVAR(ByVal ID_TIPOVAR As Int32) As Integer
        Me.odsListaPorLABFAB_TIPOVAR.SelectParameters("ID_TIPOVAR").DefaultValue = ID_TIPOVAR.ToString()
        Me.odsListaPorLABFAB_TIPOVAR.SelectParameters("recuperarHijas").DefaultValue = "False"
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

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla LABFAB_INFOVAR
    ''' filtrado por la tabla LABFAB_CATEGORIA
    ''' </summary>
    ''' <param name="ID_CATEG"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/11/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorLABFAB_CATEGORIA(ByVal ID_CATEG As Int32) As Integer
        Me.odsListaPorLABFAB_CATEGORIA.SelectParameters("ID_CATEG").DefaultValue = ID_CATEG.ToString()
        Me.odsListaPorLABFAB_CATEGORIA.SelectParameters("recuperarHijas").DefaultValue = "False"
        Me.odsListaPorLABFAB_CATEGORIA.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorLABFAB_CATEGORIA.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorLABFAB_CATEGORIA.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorLABFAB_CATEGORIA.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorLABFAB_CATEGORIA"
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
                keyValues(i) = grid.GetRowValues(i, "ID_INFOVAR")
                keyNames(i) = grid.GetRowValues(i, "ID_INFO")
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
        '    Dim btnAgregar As DevExpress.Web.ASPxButton
        '    btnAgregar = Me.dxgvLista.FindEmptyDataRowTemplateControl("btnAgregar")
        '    btnAgregar.JSProperties.Add("cp_NombreClienteLista", Me.NombreGridCliente)
        '    btnAgregar.Visible = Me.PermitirAgregarInline
        '    Dim lblEmptyDataRow As DevExpress.Web.ASPxLabel
        '    lblEmptyDataRow = Me.dxgvLista.FindEmptyDataRowTemplateControl("lblEmptyDataRow")
        '    lblEmptyDataRow.Text = Me.dxgvLista.SettingsText.EmptyDataRow
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

    Public Function DevolverSeleccionados() As listaLABFAB_INFOVAR
        Dim mLista As New listaLABFAB_INFOVAR
        For Each llave As Decimal In Me.dxgvLista.GetSelectedFieldValues("ID_INFOVAR")
            Dim lEntidad As New LABFAB_INFOVAR
            lEntidad.ID_INFOVAR = llave
            mLista.Add(lEntidad)
        Next
        Return mLista
    End Function

    Protected Sub dxgvLista_CustomButtonCallback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewCustomButtonCallbackEventArgs) Handles dxgvLista.CustomButtonCallback
        If e.ButtonID = "btnEliminar" Then
            Dim lEntidad As LABFAB_INFOVAR = CType(Me.dxgvLista.GetRow(e.VisibleIndex), LABFAB_INFOVAR)

            If Me.mComponente.EliminarLABFAB_INFOVAR(lEntidad.ID_INFOVAR) <> 1 Then
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
        If e.Column.FieldName = "NOMBRE_TIPOVAR" Then
            Dim lEntidad As LABFAB_TIPOVAR = (New cLABFAB_TIPOVAR).ObtenerLABFAB_TIPOVAR(e.GetListSourceFieldValue("ID_TIPOVAR"))
            If lEntidad IsNot Nothing Then
                e.Value = lEntidad.NOMBRE_TIPOVAR
            End If
        ElseIf e.Column.FieldName = "NOMBRE_INFO" Then
            Dim lEntidad As LABFAB_INFORME = (New cLABFAB_INFORME).ObtenerLABFAB_INFORME(e.GetListSourceFieldValue("ID_INFO"))
            If lEntidad IsNot Nothing Then
                e.Value = lEntidad.NOMBRE_INFO
            End If
        ElseIf e.Column.FieldName = "NOMBRE_ANALISIS" Then
            Dim sCad As New StringBuilder
            Dim lEntidad As LABFAB_ANALISIS = (New cLABFAB_ANALISIS).ObtenerLABFAB_ANALISIS(e.GetListSourceFieldValue("ID_ANALISIS_REF"))
            If lEntidad IsNot Nothing Then
                Dim lMuestra As LABFAB_MUESTRA = (New cLABFAB_MUESTRA).ObtenerLABFAB_MUESTRA(lEntidad.ID_MUESTRA)
                If lMuestra IsNot Nothing Then
                    Dim lEtapa As LABFAB_ETAPA = (New cLABFAB_ETAPA).ObtenerLABFAB_ETAPA(lMuestra.ID_ETAPA)
                    If lEtapa IsNot Nothing Then e.Value = lEtapa.NOMBRE_ETAPA + " - " + lMuestra.NOMBRE_MUESTRA + " - " + lEntidad.NOMBRE_ANALISIS
                End If
            End If
        End If
    End Sub
End Class
