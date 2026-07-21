Imports SISPACAL.BL
Imports SISPACAL.EL
Imports DevExpress.Web

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucListaDOCUMENTO_SALIDA_DETA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla DOCUMENTO_SALIDA_DETA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	03/07/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucListaDOCUMENTO_SALIDA_DETA
    Inherits ucListaBase

    Private mComponente As New cDOCUMENTO_SALIDA_DETA
    Public Event Seleccionado(ByVal ID_DOCSAL_ENCA_DETA As Int32)
    Public Event Editando(ByVal ID_DOCSAL_ENCA_DETA As Int32)

#Region "Propiedades"


    Public Property REFERENCIA() As String
        Get
            Return Me.ViewState("REFERENCIA")
        End Get
        Set(ByVal value As String)
            Me.ViewState("REFERENCIA") = value
        End Set
    End Property


    Public Property ID_BODEGA() As Int32
        Get
            If Me.ViewState("ID_BODEGA") Is Nothing Then
                Return -1
            Else
                Return CInt(Me.ViewState("ID_BODEGA"))
            End If
        End Get
        Set(ByVal value As Int32)
            Me.ViewState("ID_BODEGA") = value
        End Set
    End Property

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

    Public Property PermitirEditarInline2() As Boolean
        Get
            Return Me.ViewState("PermitirEdicionInline2")
        End Get
        Set(ByVal value As Boolean)
            Me.ViewState("PermitirEdicionInline2") = value
            CType(Me.dxgvLista.Columns("Edicion2"), DevExpress.Web.GridViewCommandColumn).ShowEditButton = value
            Me.dxgvLista.Columns("Edicion2").Visible = Me.PermitirEditarInline2
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

    Public Property VerID_DOCSAL_ENCA_DETA() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_DOCSAL_ENCA_DETA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_DOCSAL_ENCA_DETA").Visible = Value
        End Set
    End Property

    Public Property VerID_DOCSAL_ENCA() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_DOCSAL_ENCA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_DOCSAL_ENCA").Visible = Value
        End Set
    End Property

    Public Property VerID_PRODUCTO() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_PRODUCTO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_PRODUCTO").Visible = Value
        End Set
    End Property

    Public Property VerCANTIDAD() As Boolean
        Get
            Return Me.dxgvLista.Columns("CANTIDAD").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CANTIDAD").Visible = Value
        End Set
    End Property

    Public Property VerPRECIO_UNITARIO() As Boolean
        Get
            Return Me.dxgvLista.Columns("PRECIO_UNITARIO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("PRECIO_UNITARIO").Visible = Value
        End Set
    End Property

    Public Property VerTOTAL() As Boolean
        Get
            Return Me.dxgvLista.Columns("TOTAL").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TOTAL").Visible = Value
        End Set
    End Property

    Public Property VerUNIDAD() As Boolean
        Get
            Return Me.dxgvLista.Columns("UNIDAD").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("UNIDAD").Visible = Value
        End Set
    End Property

    Public Property VerPRESENTACION() As Boolean
        Get
            Return Me.dxgvLista.Columns("PRESENTACION").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("PRESENTACION").Visible = Value
        End Set
    End Property

    Public Property VerNOMBRE_PRODUCTO() As Boolean
        Get
            Return Me.dxgvLista.Columns("NOMBRE_PRODUCTO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NOMBRE_PRODUCTO").Visible = Value
        End Set
    End Property

    Public Property VerUID_DOCUMENTO_DETA() As Boolean
        Get
            Return Me.dxgvLista.Columns("UID_DOCUMENTO_DETA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("UID_DOCUMENTO_DETA").Visible = Value
        End Set
    End Property

    Public Property HeaderID_DOCSAL_ENCA_DETA() As String
        Get
            Return Me.dxgvLista.Columns("ID_DOCSAL_ENCA_DETA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_DOCSAL_ENCA_DETA").Caption = Value
        End Set
    End Property

    Public Property HeaderID_DOCSAL_ENCA() As String
        Get
            Return Me.dxgvLista.Columns("ID_DOCSAL_ENCA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_DOCSAL_ENCA").Caption = Value
        End Set
    End Property

    Public Property HeaderID_PRODUCTO() As String
        Get
            Return Me.dxgvLista.Columns("ID_PRODUCTO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_PRODUCTO").Caption = Value
        End Set
    End Property

    Public Property HeaderCANTIDAD() As String
        Get
            Return Me.dxgvLista.Columns("CANTIDAD").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CANTIDAD").Caption = Value
        End Set
    End Property

    Public Property HeaderPRECIO_UNITARIO() As String
        Get
            Return Me.dxgvLista.Columns("PRECIO_UNITARIO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("PRECIO_UNITARIO").Caption = Value
        End Set
    End Property

    Public Property HeaderTOTAL() As String
        Get
            Return Me.dxgvLista.Columns("TOTAL").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TOTAL").Caption = Value
        End Set
    End Property

    Public Property HeaderUNIDAD() As String
        Get
            Return Me.dxgvLista.Columns("UNIDAD").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("UNIDAD").Caption = Value
        End Set
    End Property

    Public Property HeaderPRESENTACION() As String
        Get
            Return Me.dxgvLista.Columns("PRESENTACION").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("PRESENTACION").Caption = Value
        End Set
    End Property

    Public Property HeaderNOMBRE_PRODUCTO() As String
        Get
            Return Me.dxgvLista.Columns("NOMBRE_PRODUCTO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("NOMBRE_PRODUCTO").Caption = Value
        End Set
    End Property

    Public Property HeaderUID_DOCUMENTO_DETA() As String
        Get
            Return Me.dxgvLista.Columns("UID_DOCUMENTO_DETA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("UID_DOCUMENTO_DETA").Caption = Value
        End Set
    End Property

#End Region



    Public Function CargarDatosCache(ByVal nombreSesion As String) As Integer
        Me.REFERENCIA = nombreSesion
        Me.odsDOCUMENTO_SALIDA_DETAcache.SelectParameters("nombreSesion_ucListaDOCUMENTO_SALIDA_DETA").DefaultValue = nombreSesion
        Me.odsDOCUMENTO_SALIDA_DETAcache.DataBind()
        Me.dxgvLista.DataSourceID = "odsDOCUMENTO_SALIDA_DETAcache"
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla DOCUMENTO_SALIDA_DETA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/07/2017	Created
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
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla DOCUMENTO_SALIDA_DETA
    ''' filtrado por la tabla DOCUMENTO_SALIDA_ENCA
    ''' </summary>
    ''' <param name="ID_DOCSAL_ENCA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/07/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorDOCUMENTO_SALIDA_ENCA(ByVal ID_DOCSAL_ENCA As Int32) As Integer
        Me.odsListaPorDOCUMENTO_SALIDA_ENCA.SelectParameters("ID_DOCSAL_ENCA").DefaultValue = ID_DOCSAL_ENCA.ToString()
        Me.odsListaPorDOCUMENTO_SALIDA_ENCA.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorDOCUMENTO_SALIDA_ENCA.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorDOCUMENTO_SALIDA_ENCA.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorDOCUMENTO_SALIDA_ENCA.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorDOCUMENTO_SALIDA_ENCA"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla DOCUMENTO_SALIDA_DETA
    ''' filtrado por la tabla PRODUCTO
    ''' </summary>
    ''' <param name="ID_PRODUCTO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/07/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorPRODUCTO(ByVal ID_PRODUCTO As Int32) As Integer
        Me.odsListaPorPRODUCTO.SelectParameters("ID_PRODUCTO").DefaultValue = ID_PRODUCTO.ToString()
        Me.odsListaPorPRODUCTO.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorPRODUCTO.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorPRODUCTO.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorPRODUCTO.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorPRODUCTO"
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
                keyValues(i) = grid.GetRowValues(i, "ID_DOCSAL_ENCA_DETA")
                keyNames(i) = grid.GetRowValues(i, "ID_DOCSAL_ENCA")
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
            CType(Me.dxgvLista.Columns("Edicion"), DevExpress.Web.GridViewCommandColumn).ShowNewButtonInHeader = Me.PermitirAgregarInline
            CType(Me.dxgvLista.Columns("Edicion"), DevExpress.Web.GridViewCommandColumn).NewButton.Visible = Me.PermitirAgregarInline
            CType(Me.dxgvLista.Columns("Edicion"), DevExpress.Web.GridViewCommandColumn).EditButton.Visible = Me.PermitirEditarInline
            CType(Me.dxgvLista.Columns("Edicion"), DevExpress.Web.GridViewCommandColumn).DeleteButton.Visible = Me.PermitirEliminarInline
        Else
            Me.dxgvLista.Columns("Edicion").Visible = False
        End If
        If Me.PermitirEditarInline2 Then
            Me.dxgvLista.Columns("Edicion2").Visible = True
            Me.dxgvLista.Columns("Eliminar").Visible = PermitirEliminarInline
            CType(Me.dxgvLista.Columns("Edicion2"), DevExpress.Web.GridViewCommandColumn).ShowNewButtonInHeader = Me.PermitirAgregarInline
            CType(Me.dxgvLista.Columns("Edicion2"), DevExpress.Web.GridViewCommandColumn).EditButton.Visible = Me.PermitirEditarInline
            CType(Me.dxgvLista.Columns("Eliminar"), DevExpress.Web.GridViewCommandColumn).DeleteButton.Visible = Me.PermitirEliminarInline
        Else
            Me.dxgvLista.Columns("Edicion2").Visible = False
        End If
        If Me.PermitirEditarInline Or Me.PermitirEditarInline2 Then
            Me.dxgvLista.SettingsEditing.Mode = DevExpress.Web.GridViewEditingMode.Inline
        End If
        If Me.NombreComboCliente = "" Then
            Me.dxgvLista.ClientSideEvents.RowClick = ""
        End If
        dxgvLista.ForceDataRowType(GetType(listaDOCUMENTO_SALIDA_DETA))
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
        If e.CommandArgs.CommandName = "Eliminar" Then
            Dim b As New cDOCUMENTO_SALIDA_DETAcache

            b.Eliminar(e.KeyValue, Me.REFERENCIA)
            Me.dxgvLista.DataBind()
            Me.CargarDatosCache(Me.REFERENCIA)
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
            'If Not Me.PermitirEditar Then
            '    Dim lbDetalle As LinkButton
            '    lbDetalle = Me.dxgvLista.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "lbtnEditar")
            '    lbDetalle.Visible = False
            'End If
            'If Me.PermitirSeleccionar Then
            '    Dim lbSeleccionar As LinkButton
            '    lbSeleccionar = Me.dxgvLista.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "lbtnSeleccionar")
            '    lbSeleccionar.Visible = True
            '    lbSeleccionar.Text = Me.TextoSeleccionar
            '    lbSeleccionar.CommandName = Me.ComandoSeleccionar
            '    If lbSeleccionar.CommandName = "Check" Then
            '        lbSeleccionar.Visible = False
            '    End If
            'End If
        End If
    End Sub

    Public Function DevolverSeleccionados() As listaDOCUMENTO_SALIDA_DETA
        Dim mLista As New listaDOCUMENTO_SALIDA_DETA
        For Each llave As Decimal In Me.dxgvLista.GetSelectedFieldValues("ID_DOCSAL_ENCA_DETA")
            Dim lEntidad As New DOCUMENTO_SALIDA_DETA
            lEntidad.ID_DOCSAL_ENCA_DETA = llave
            mLista.Add(lEntidad)
        Next
        Return mLista
    End Function


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

    Protected Sub dxgvLista_RowUpdating(sender As Object, e As DevExpress.Web.Data.ASPxDataUpdatingEventArgs) Handles dxgvLista.RowUpdating
        e.NewValues("REFERENCIA") = Me.REFERENCIA
    End Sub

    Protected Sub dxgvLista_RowValidating(sender As Object, e As DevExpress.Web.Data.ASPxDataValidationEventArgs) Handles dxgvLista.RowValidating
        Dim mIdProducto As Int32 = 0
        Dim mCantidad As Decimal = 0

        e.Errors.Clear()
        For Each column As GridViewColumn In dxgvLista.Columns
            Dim dataColumn As GridViewDataColumn = TryCast(column, GridViewDataColumn)
            If dataColumn IsNot Nothing Then

                Select Case dataColumn.FieldName
                    Case "ID_PRODUCTO"
                        If (e.NewValues(dataColumn.FieldName) Is Nothing) Then
                            e.Errors(dataColumn) = "Ingrese Producto"
                        Else
                            mIdProducto = e.NewValues(dataColumn.FieldName)
                        End If

                    Case "CANTIDAD"
                        If (e.NewValues(dataColumn.FieldName) Is Nothing) Then
                            e.Errors(dataColumn) = "Ingrese Cantidad"
                        ElseIf e.NewValues(dataColumn.FieldName) = 0 Then
                            e.Errors(dataColumn) = "Cantidad no puede ser cero"
                        Else
                            mCantidad = e.NewValues(dataColumn.FieldName)
                        End If
                End Select
            End If
        Next column

        'Verificar si el producto posee disponibilidad de existencia        
        If mIdProducto <> 0 AndAlso mCantidad > 0 Then
            Dim lKardex As KARDEX = (New cKARDEX).ObtenerKARDEX_UltimoMovtoID_PRODUCTO(Me.ID_BODEGA, mIdProducto)
            If lKardex IsNot Nothing Then
                If lKardex.SDO_UNIDAD - mCantidad < 0 Then
                    e.RowError = "No hay existencia para el producto, la existencia actual es: " + lKardex.SDO_UNIDAD.ToString("#,##0.00##")
                    Return
                End If
            Else
                e.RowError = "No hay existencia para el producto"
                Return
            End If
        End If


        If e.Errors.Count > 0 Then
            e.RowError = "Existe información incompleta"
        End If
    End Sub

    Protected Sub dxgvLista_CustomUnboundColumnData(sender As Object, e As ASPxGridViewColumnDataEventArgs) Handles dxgvLista.CustomUnboundColumnData
        If e.Column.FieldName = "NOMBRE_PROVEEDOR" Then
            Dim lProducto As PRODUCTO = (New cPRODUCTO).ObtenerPRODUCTO(CInt(e.GetListSourceFieldValue("ID_PRODUCTO")))

            If lProducto IsNot Nothing Then
                Dim lEntidad As PROVEEDOR_AGRICOLA = (New cPROVEEDOR_AGRICOLA).ObtenerPROVEEDOR_AGRICOLA(lProducto.ID_PROVEE)
                If lEntidad IsNot Nothing Then e.Value = lEntidad.NOMBRE
            End If
        End If
    End Sub
End Class
