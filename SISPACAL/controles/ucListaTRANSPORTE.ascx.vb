Imports SISPACAL.BL
Imports SISPACAL.EL
Imports DevExpress.Web

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucListaTRANSPORTE
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla TRANSPORTE
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	21/11/2016	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucListaTRANSPORTE
    Inherits ucListaBase

    Private mComponente As New cTRANSPORTE
    Public Event Seleccionado(ByVal ID_TRANSPORTE As Int32)
    Public Event Editando(ByVal ID_TRANSPORTE As Int32)

#Region "Propiedades"

    Public Property REFERENCIA() As String
        Get
            Return Me.ViewState("REFERENCIA")
        End Get
        Set(ByVal value As String)
            Me.ViewState("REFERENCIA") = value
        End Set
    End Property

    Public WriteOnly Property SeleccionarFila() As Object
        Set(value As Object)
            Dim indice As Int32
            Me.dxgvLista.Selection.SelectRowByKey(value)
            indice = Me.dxgvLista.FindVisibleIndexByKeyValue(value)
            If dxgvLista.SettingsBehavior.AllowSelectSingleRowOnly Then Me.dxgvLista.FocusedRowIndex = indice
        End Set
    End Property

    Public Property MostrarCheckUnaSeleccion As Boolean
        Set(value As Boolean)
            If dxgvLista.Columns("CheckSeleccionar") IsNot Nothing Then
                dxgvLista.Columns("CheckSeleccionar").Visible = value
                dxgvLista.EnableCallBacks = False
                dxgvLista.SettingsBehavior.AllowSelectSingleRowOnly = value
                dxgvLista.SettingsBehavior.ProcessSelectionChangedOnServer = True
            End If
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

    Public Sub QuitarSeleccion()
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.PageIndex = 0
    End Sub

    Public Sub QuitarFiltros()
        Me.dxgvLista.FilterExpression = ""
        Me.dxgvLista.PageIndex = 0
    End Sub


    Public Property TamanoPagina() As Integer
        Get
            Return Me.dxgvLista.SettingsPager.PageSize
        End Get
        Set(ByVal Value As Integer)
            Me.dxgvLista.SettingsPager.PageSize = Value
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
            Me.dxgvLista.Columns("Edicion").Visible = value
            CType(Me.dxgvLista.Columns("Edicion"), DevExpress.Web.GridViewCommandColumn).EditButton.Visible = value
            Me.dxgvLista.SettingsEditing.Mode = DevExpress.Web.GridViewEditingMode.Inline
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

    Public Property VerID_TRANSPORTE() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_TRANSPORTE").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_TRANSPORTE").Visible = Value
        End Set
    End Property

    Public Property VerPLACA() As Boolean
        Get
            Return Me.dxgvLista.Columns("PLACA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("PLACA").Visible = Value
        End Set
    End Property

    Public Property VerCODTRANSPORT() As Boolean
        Get
            Return Me.dxgvLista.Columns("CODTRANSPORT").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CODTRANSPORT").Visible = Value
        End Set
    End Property

    Public Property VerID_TIPOTRANS() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_TIPOTRANS").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_TIPOTRANS").Visible = Value
        End Set
    End Property

    Public Property VerREMOLQUE() As Boolean
        Get
            Return Me.dxgvLista.Columns("REMOLQUE").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("REMOLQUE").Visible = Value
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

    Public Property HeaderID_TRANSPORTE() As String
        Get
            Return Me.dxgvLista.Columns("ID_TRANSPORTE").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_TRANSPORTE").Caption = Value
        End Set
    End Property

    Public Property HeaderPLACA() As String
        Get
            Return Me.dxgvLista.Columns("PLACA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("PLACA").Caption = Value
        End Set
    End Property

    Public Property HeaderCODTRANSPORT() As String
        Get
            Return Me.dxgvLista.Columns("CODTRANSPORT").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CODTRANSPORT").Caption = Value
        End Set
    End Property

    Public Property HeaderID_TIPOTRANS() As String
        Get
            Return Me.dxgvLista.Columns("ID_TIPOTRANS").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_TIPOTRANS").Caption = Value
        End Set
    End Property

    Public Property HeaderREMOLQUE() As String
        Get
            Return Me.dxgvLista.Columns("REMOLQUE").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("REMOLQUE").Caption = Value
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

    Public Function CargarDatosCache(ByVal nombreSesion As String) As Integer
        Me.REFERENCIA = nombreSesion
        Me.odsTRANSPORTEcache.SelectParameters("nombreSesion_ucListaTRANSPORTE").DefaultValue = nombreSesion
        Me.odsTRANSPORTEcache.DataBind()
        Me.dxgvLista.DataSourceID = "odsTRANSPORTEcache"
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla TRANSPORTE
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/11/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Me.odsLista.SelectParameters("recuperarHijas").DefaultValue = "False"
        Me.odsLista.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsLista.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsLista.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsLista.DataBind()
        Me.dxgvLista.DataSourceID = "odsLista"
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla TRANSPORTE
    ''' filtrado por la tabla TRANSPORTISTA
    ''' </summary>
    ''' <param name="CODTRANSPORT"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/11/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorTRANSPORTISTA(ByVal CODTRANSPORT As Int32) As Integer
        Me.odsListaPorTRANSPORTISTA.SelectParameters("CODTRANSPORT").DefaultValue = CODTRANSPORT.ToString()
        Me.odsListaPorTRANSPORTISTA.SelectParameters("recuperarHijas").DefaultValue = "False"
        Me.odsListaPorTRANSPORTISTA.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorTRANSPORTISTA.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorTRANSPORTISTA.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorTRANSPORTISTA.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorTRANSPORTISTA"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla TRANSPORTE
    ''' filtrado por la tabla TIPO_TRANSPORTE
    ''' </summary>
    ''' <param name="ID_TIPOTRANS"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/11/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorTIPO_TRANSPORTE(ByVal ID_TIPOTRANS As Int32) As Integer
        Me.odsListaPorTIPO_TRANSPORTE.SelectParameters("ID_TIPOTRANS").DefaultValue = ID_TIPOTRANS.ToString()
        Me.odsListaPorTIPO_TRANSPORTE.SelectParameters("recuperarHijas").DefaultValue = "False"
        Me.odsListaPorTIPO_TRANSPORTE.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorTIPO_TRANSPORTE.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorTIPO_TRANSPORTE.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorTIPO_TRANSPORTE.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorTIPO_TRANSPORTE"
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
                keyValues(i) = grid.GetRowValues(i, "ID_TRANSPORTE")
                keyNames(i) = grid.GetRowValues(i, "PLACA")
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
        dxgvLista.ForceDataRowType(GetType(listaTRANSPORTE))
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

    Public Function DevolverSeleccionados() As listaTRANSPORTE
        Dim mLista As New listaTRANSPORTE
        For Each llave As Decimal In Me.dxgvLista.GetSelectedFieldValues("ID_TRANSPORTE")
            Dim lEntidad As New TRANSPORTE
            lEntidad.ID_TRANSPORTE = llave
            mLista.Add(lEntidad)
        Next
        Return mLista
    End Function

    Protected Sub dxgvLista_CustomButtonCallback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewCustomButtonCallbackEventArgs) Handles dxgvLista.CustomButtonCallback
        If e.ButtonID = "btnEliminar" Then
            Dim lEntidad As TRANSPORTE = CType(Me.dxgvLista.GetRow(e.VisibleIndex), TRANSPORTE)
            Dim bTransCache As New cTRANSPORTEcache

            If bTransCache.Eliminar(lEntidad.ID_TRANSPORTE, REFERENCIA) < 0 Then
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
        If e.Column.FieldName = "NOMBRE_TRANSPORTISTA" Then
            Dim lEntidad As TRANSPORTISTA = (New cTRANSPORTISTA).ObtenerTRANSPORTISTA(e.GetListSourceFieldValue("CODTRANSPORT"))
            If lEntidad IsNot Nothing Then
                e.Value = lEntidad.NOMBRES + " " + lEntidad.APELLIDOS
            End If
        ElseIf e.Column.FieldName = "TIPOTRANS" Then
            Dim lEntidad As TIPO_TRANSPORTE = (New cTIPO_TRANSPORTE).ObtenerTIPO_TRANSPORTE(e.GetListSourceFieldValue("ID_TIPOTRANS"))
            If lEntidad IsNot Nothing Then
                e.Value = lEntidad.NOMBRE
            End If
        End If
    End Sub

    Protected Sub dxgvLista_InitNewRow(sender As Object, e As DevExpress.Web.Data.ASPxDataInitNewRowEventArgs) Handles dxgvLista.InitNewRow
        e.NewValues("REFERENCIA") = Me.REFERENCIA
    End Sub

    Protected Sub dxgvLista_RowInserting(sender As Object, e As DevExpress.Web.Data.ASPxDataInsertingEventArgs) Handles dxgvLista.RowInserting
        e.NewValues("REFERENCIA") = Me.REFERENCIA
    End Sub

    Protected Sub dxgvLista_RowUpdating(sender As Object, e As DevExpress.Web.Data.ASPxDataUpdatingEventArgs) Handles dxgvLista.RowUpdating
        If e.NewValues("PLACA") IsNot Nothing Then e.NewValues("PLACA") = CStr(e.NewValues("PLACA")).Trim.ToUpper
        If e.NewValues("REMOLQUE") IsNot Nothing Then e.NewValues("REMOLQUE") = CStr(e.NewValues("REMOLQUE")).Trim.ToUpper
        If e.NewValues("MARCA") IsNot Nothing Then e.NewValues("MARCA") = CStr(e.NewValues("MARCA")).Trim.ToUpper
        e.NewValues("REFERENCIA") = Me.REFERENCIA
    End Sub

    Protected Sub dxgvLista_SelectionChanged(sender As Object, e As System.EventArgs) Handles dxgvLista.SelectionChanged
        If dxgvLista.GetSelectedFieldValues("ID_TRANSPORTE").Count > 0 Then RaiseEvent Seleccionado(dxgvLista.GetSelectedFieldValues("ID_TRANSPORTE")(0).ToString())
    End Sub

    Protected Sub dxgvLista_RowValidating(sender As Object, e As DevExpress.Web.Data.ASPxDataValidationEventArgs) Handles dxgvLista.RowValidating
        Dim mIdProducto As Int32 = 0
        Dim mCantidad As Decimal = 0

        e.Errors.Clear()
        For Each column As GridViewColumn In dxgvLista.Columns
            Dim dataColumn As GridViewDataColumn = TryCast(column, GridViewDataColumn)
            If dataColumn IsNot Nothing Then

                Select Case dataColumn.FieldName
                    Case "PLACA"
                        If (e.NewValues(dataColumn.FieldName) Is Nothing) Then
                            e.Errors(dataColumn) = "Ingrese Placa"
                        End If

                    Case "CAPACIDAD"
                        If (e.NewValues(dataColumn.FieldName) Is Nothing) Then
                            e.Errors(dataColumn) = "Ingrese Capacidad"
                        End If
                End Select
            End If
        Next column


        If e.Errors.Count > 0 Then
            e.RowError = "Existe información incompleta"
        End If
    End Sub
End Class
