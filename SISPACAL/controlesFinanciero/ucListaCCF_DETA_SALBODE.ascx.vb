Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucListaCCF_DETA_SALBODE
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla CCF_DETA_SALBODE
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	05/09/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucListaCCF_DETA_SALBODE
    Inherits ucListaBase
 
    Private mComponente As New cCCF_DETA_SALBODE
    Public Event Seleccionado(ByVal ID_CCF_DETA_SAL As Int32) 
    Public Event Editando(ByVal ID_CCF_DETA_SAL As Int32) 

#Region"Propiedades"

    Public Property REFERENCIA() As String
        Get
            Return Me.ViewState("REFERENCIA")
        End Get
        Set(ByVal value As String)
            Me.ViewState("REFERENCIA") = value
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

    Public Property VerID_CCF_DETA_SAL() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_CCF_DETA_SAL").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_CCF_DETA_SAL").Visible = Value
        End Set
    End Property

    Public Property VerID_SALBODE_DETA() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_SALBODE_DETA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_SALBODE_DETA").Visible = Value
        End Set
    End Property

    Public Property VerID_SOLICITUD() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_SOLICITUD").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_SOLICITUD").Visible = Value
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

    Public Property VerNOMBRE_PRODUCTO() As Boolean
        Get
            Return Me.dxgvLista.Columns("NOMBRE_PRODUCTO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NOMBRE_PRODUCTO").Visible = Value
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

    Public Property VerCANTIDAD_CCF() As Boolean
        Get
            Return Me.dxgvLista.Columns("CANTIDAD_CCF").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CANTIDAD_CCF").Visible = Value
        End Set
    End Property

    Public Property VerPRECIO_UNITARIO_CCF() As Boolean
        Get
            Return Me.dxgvLista.Columns("PRECIO_UNITARIO_CCF").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("PRECIO_UNITARIO_CCF").Visible = Value
        End Set
    End Property

    Public Property VerTOTAL_CCF() As Boolean
        Get
            Return Me.dxgvLista.Columns("TOTAL_CCF").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TOTAL_CCF").Visible = Value
        End Set
    End Property

    Public Property HeaderID_CCF_DETA_SAL() As String
        Get
            Return Me.dxgvLista.Columns("ID_CCF_DETA_SAL").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_CCF_DETA_SAL").Caption = Value
        End Set
    End Property

    Public Property HeaderID_SALBODE_DETA() As String
        Get
            Return Me.dxgvLista.Columns("ID_SALBODE_DETA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_SALBODE_DETA").Caption = Value
        End Set
    End Property

    Public Property HeaderID_SOLICITUD() As String
        Get
            Return Me.dxgvLista.Columns("ID_SOLICITUD").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_SOLICITUD").Caption = Value
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

    Public Property HeaderNOMBRE_PRODUCTO() As String
        Get
            Return Me.dxgvLista.Columns("NOMBRE_PRODUCTO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("NOMBRE_PRODUCTO").Caption = Value
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

    Public Property HeaderCANTIDAD_CCF() As String
        Get
            Return Me.dxgvLista.Columns("CANTIDAD_CCF").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CANTIDAD_CCF").Caption = Value
        End Set
    End Property

    Public Property HeaderPRECIO_UNITARIO_CCF() As String
        Get
            Return Me.dxgvLista.Columns("PRECIO_UNITARIO_CCF").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("PRECIO_UNITARIO_CCF").Caption = Value
        End Set
    End Property

    Public Property HeaderTOTAL_CCF() As String
        Get
            Return Me.dxgvLista.Columns("TOTAL_CCF").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TOTAL_CCF").Caption = Value
        End Set
    End Property

#End Region


    Public Function CargarDatosCache(ByVal nombreSesion As String) As Integer
        Me.REFERENCIA = nombreSesion
        Me.odsCCF_DETA_SALBODEcache.SelectParameters("nombreSesion_ucListaCCF_DETA_SALBODE").DefaultValue = nombreSesion
        Me.odsCCF_DETA_SALBODEcache.DataBind()
        Me.dxgvLista.DataSourceID = "odsCCF_DETA_SALBODEcache"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla CCF_DETA_SALBODE
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/09/2017	Created
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
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla CCF_DETA_SALBODE
    ''' filtrado por la tabla SALBODE_DETA
    ''' </summary>
    ''' <param name="ID_SALBODE_DETA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/09/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorSALBODE_DETA(ByVal ID_SALBODE_DETA As Int32) As Integer
        Me.odsListaPorSALBODE_DETA.SelectParameters("ID_SALBODE_DETA").DefaultValue = ID_SALBODE_DETA.ToString()
        Me.odsListaPorSALBODE_DETA.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorSALBODE_DETA.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorSALBODE_DETA.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorSALBODE_DETA.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorSALBODE_DETA"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla CCF_DETA_SALBODE
    ''' filtrado por la tabla SOLIC_AGRICOLA
    ''' </summary>
    ''' <param name="ID_SOLICITUD"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/09/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorSOLIC_AGRICOLA(ByVal ID_SOLICITUD As Int32) As Integer
        Me.odsListaPorSOLIC_AGRICOLA.SelectParameters("ID_SOLICITUD").DefaultValue = ID_SOLICITUD.ToString()
        Me.odsListaPorSOLIC_AGRICOLA.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorSOLIC_AGRICOLA.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorSOLIC_AGRICOLA.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorSOLIC_AGRICOLA.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorSOLIC_AGRICOLA"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla CCF_DETA_SALBODE
    ''' filtrado por la tabla PRODUCTO
    ''' </summary>
    ''' <param name="ID_PRODUCTO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/09/2017	Created
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
                keyValues(i) = grid.GetRowValues(i, "ID_CCF_DETA_SAL")
                keyNames(i) = grid.GetRowValues(i, "ID_SALBODE_DETA")
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


    Public Function DevolverSeleccionados() As listaCCF_DETA_SALBODE
        Dim mLista As New listaCCF_DETA_SALBODE
        For Each llave As String In Me.dxgvLista.GetSelectedFieldValues("ID_CCF_DETA_SAL")
            Dim lEntidad As New CCF_DETA_SALBODE
            lEntidad.ID_CCF_DETA_SAL = Me.dxgvLista.GetRowValuesByKeyValue(llave, "ID_CCF_DETA_SAL")
            lEntidad.ID_SALBODE_DETA = Me.dxgvLista.GetRowValuesByKeyValue(llave, "ID_SALBODE_DETA")
            lEntidad.ID_SOLICITUD = Me.dxgvLista.GetRowValuesByKeyValue(llave, "ID_SOLICITUD")
            lEntidad.ID_PRODUCTO = Me.dxgvLista.GetRowValuesByKeyValue(llave, "ID_PRODUCTO")
            lEntidad.NOMBRE_PRODUCTO = Me.dxgvLista.GetRowValuesByKeyValue(llave, "NOMBRE_PRODUCTO")
            lEntidad.PRESENTACION = Me.dxgvLista.GetRowValuesByKeyValue(llave, "PRESENTACION")
            lEntidad.CANTIDAD_CCF = Me.dxgvLista.GetRowValuesByKeyValue(llave, "CANTIDAD_CCF")
            lEntidad.PRECIO_UNITARIO_CCF = Me.dxgvLista.GetRowValuesByKeyValue(llave, "PRECIO_UNITARIO_CCF")
            lEntidad.TOTAL_CCF = Me.dxgvLista.GetRowValuesByKeyValue(llave, "TOTAL_CCF")
            mLista.Add(lEntidad)
        Next
        Return mLista
    End Function

    Public Sub SeleccionarRegistros(ByVal p As List(Of String))
        Me.dxgvLista.Selection.UnselectAll()
        If p IsNot Nothing AndAlso p.Count > 0 Then
            For i As Int32 = 0 To p.Count - 1
                Me.dxgvLista.Selection.SelectRowByKey(p(i))
            Next
        End If
    End Sub


    Protected Sub dxgvLista_CustomButtonCallback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewCustomButtonCallbackEventArgs) Handles dxgvLista.CustomButtonCallback
        If e.ButtonID = "btnEliminar" Then
            Dim lEntidad As CCF_DETA_SALBODE = CType(Me.dxgvLista.GetRow(e.VisibleIndex), CCF_DETA_SALBODE)

            If Me.mComponente.EliminarCCF_DETA_SALBODE(lEntidad.ID_CCF_DETA_SAL) <> 1 Then
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
        Select Case e.Column.FieldName
            Case "NUM_SOLICITUD"
                If e.GetListSourceFieldValue("ID_SOLICITUD") IsNot Nothing Then
                    Dim lEntidad As SOLIC_AGRICOLA = (New cSOLIC_AGRICOLA).ObtenerSOLIC_AGRICOLA(e.GetListSourceFieldValue("ID_SOLICITUD"))
                    e.Value = lEntidad.NUM_SOLICITUD
                End If
        End Select
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
End Class
