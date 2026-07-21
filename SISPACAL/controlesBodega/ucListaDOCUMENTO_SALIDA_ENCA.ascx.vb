Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucListaDOCUMENTO_SALIDA_ENCA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla DOCUMENTO_SALIDA_ENCA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	03/07/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucListaDOCUMENTO_SALIDA_ENCA
    Inherits ucListaBase
 
    Private mComponente As New cDOCUMENTO_SALIDA_ENCA
    Public Event Seleccionado(ByVal ID_DOCSAL_ENCA As Int32) 
    Public Event Editando(ByVal ID_DOCSAL_ENCA As Int32) 

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

    Public Property VerVistaPreviaReporte() As Boolean
        Get
            Return Me.dxgvLista.Columns("colVistaPrevia").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("colVistaPrevia").Visible = Value
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

    Public Property VerID_DOCSAL_ENCA() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_DOCSAL_ENCA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_DOCSAL_ENCA").Visible = Value
        End Set
    End Property

    Public Property VerNO_DOCUMENTO() As Boolean
        Get
            Return Me.dxgvLista.Columns("NO_DOCUMENTO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NO_DOCUMENTO").Visible = Value
        End Set
    End Property

    Public Property VerID_TIPO_MOVTO() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_TIPO_MOVTO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_TIPO_MOVTO").Visible = Value
        End Set
    End Property

    Public Property VerFECHA_DOCTO() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_DOCTO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_DOCTO").Visible = Value
        End Set
    End Property

    Public Property VerUID_DOCUMENTO() As Boolean
        Get
            Return Me.dxgvLista.Columns("UID_DOCUMENTO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("UID_DOCUMENTO").Visible = Value
        End Set
    End Property

    Public Property VerID_BODEGA() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_BODEGA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_BODEGA").Visible = Value
        End Set
    End Property

    Public Property VerID_UNIDAD_ORG() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_UNIDAD_ORG").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_UNIDAD_ORG").Visible = Value
        End Set
    End Property

    Public Property VerOBSERVACIONES() As Boolean
        Get
            Return Me.dxgvLista.Columns("OBSERVACIONES").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("OBSERVACIONES").Visible = Value
        End Set
    End Property

    Public Property VerENTREGADO() As Boolean
        Get
            Return Me.dxgvLista.Columns("ENTREGADO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ENTREGADO").Visible = Value
        End Set
    End Property

    Public Property VerRECIBIDO() As Boolean
        Get
            Return Me.dxgvLista.Columns("RECIBIDO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("RECIBIDO").Visible = Value
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

    Public Property HeaderID_DOCSAL_ENCA() As String
        Get
            Return Me.dxgvLista.Columns("ID_DOCSAL_ENCA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_DOCSAL_ENCA").Caption = Value
        End Set
    End Property

    Public Property HeaderNO_DOCUMENTO() As String
        Get
            Return Me.dxgvLista.Columns("NO_DOCUMENTO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("NO_DOCUMENTO").Caption = Value
        End Set
    End Property

    Public Property HeaderID_TIPO_MOVTO() As String
        Get
            Return Me.dxgvLista.Columns("ID_TIPO_MOVTO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_TIPO_MOVTO").Caption = Value
        End Set
    End Property

    Public Property HeaderFECHA_DOCTO() As String
        Get
            Return Me.dxgvLista.Columns("FECHA_DOCTO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA_DOCTO").Caption = Value
        End Set
    End Property

    Public Property HeaderUID_DOCUMENTO() As String
        Get
            Return Me.dxgvLista.Columns("UID_DOCUMENTO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("UID_DOCUMENTO").Caption = Value
        End Set
    End Property

    Public Property HeaderID_BODEGA() As String
        Get
            Return Me.dxgvLista.Columns("ID_BODEGA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_BODEGA").Caption = Value
        End Set
    End Property

    Public Property HeaderID_UNIDAD_ORG() As String
        Get
            Return Me.dxgvLista.Columns("ID_UNIDAD_ORG").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_UNIDAD_ORG").Caption = Value
        End Set
    End Property

    Public Property HeaderOBSERVACIONES() As String
        Get
            Return Me.dxgvLista.Columns("OBSERVACIONES").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("OBSERVACIONES").Caption = Value
        End Set
    End Property

    Public Property HeaderENTREGADO() As String
        Get
            Return Me.dxgvLista.Columns("ENTREGADO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ENTREGADO").Caption = Value
        End Set
    End Property

    Public Property HeaderRECIBIDO() As String
        Get
            Return Me.dxgvLista.Columns("RECIBIDO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("RECIBIDO").Caption = Value
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
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla DOCUMENTO_SALIDA_ENCA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/07/2017	Created
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
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla DOCUMENTO_SALIDA_ENCA
    ''' filtrado por la tabla TIPO_MOVTO
    ''' </summary>
    ''' <param name="ID_TIPO_MOVTO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/07/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorTIPO_MOVTO(ByVal ID_TIPO_MOVTO As Int32) As Integer
        Me.odsListaPorTIPO_MOVTO.SelectParameters("ID_TIPO_MOVTO").DefaultValue = ID_TIPO_MOVTO.ToString()
        Me.odsListaPorTIPO_MOVTO.SelectParameters("recuperarHijas").DefaultValue = "False"
        Me.odsListaPorTIPO_MOVTO.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorTIPO_MOVTO.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorTIPO_MOVTO.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorTIPO_MOVTO.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorTIPO_MOVTO"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla DOCUMENTO_SALIDA_ENCA
    ''' filtrado por la tabla BODEGA
    ''' </summary>
    ''' <param name="ID_BODEGA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/07/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorBODEGA(ByVal ID_BODEGA As Int32) As Integer
        Me.odsListaPorBODEGA.SelectParameters("ID_BODEGA").DefaultValue = ID_BODEGA.ToString()
        Me.odsListaPorBODEGA.SelectParameters("recuperarHijas").DefaultValue = "False"
        Me.odsListaPorBODEGA.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorBODEGA.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorBODEGA.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorBODEGA.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorBODEGA"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla DOCUMENTO_SALIDA_ENCA
    ''' filtrado por la tabla UNIDAD_ORG
    ''' </summary>
    ''' <param name="ID_UNIDAD_ORG"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/07/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorUNIDAD_ORG(ByVal ID_UNIDAD_ORG As Int32) As Integer
        Me.odsListaPorUNIDAD_ORG.SelectParameters("ID_UNIDAD_ORG").DefaultValue = ID_UNIDAD_ORG.ToString()
        Me.odsListaPorUNIDAD_ORG.SelectParameters("recuperarHijas").DefaultValue = "False"
        Me.odsListaPorUNIDAD_ORG.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorUNIDAD_ORG.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorUNIDAD_ORG.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorUNIDAD_ORG.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorUNIDAD_ORG"
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
                keyValues(i) = grid.GetRowValues(i, "ID_DOCSAL_ENCA")
                keyNames(i) = grid.GetRowValues(i, "NO_DOCUMENTO")
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

    Public Function DevolverSeleccionados() As listaDOCUMENTO_SALIDA_ENCA
        Dim mLista As New listaDOCUMENTO_SALIDA_ENCA
        For Each llave As Decimal In Me.dxgvLista.GetSelectedFieldValues("ID_DOCSAL_ENCA")
            Dim lEntidad As New DOCUMENTO_SALIDA_ENCA
            lEntidad.ID_DOCSAL_ENCA = llave
            mLista.Add(lEntidad)
        Next
        Return mLista
    End Function

    Protected Sub dxgvLista_CustomButtonCallback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewCustomButtonCallbackEventArgs) Handles dxgvLista.CustomButtonCallback
        If e.ButtonID = "btnEliminar" Then
            Dim lEntidad As DOCUMENTO_SALIDA_ENCA = CType(Me.dxgvLista.GetRow(e.VisibleIndex), DOCUMENTO_SALIDA_ENCA)

            If Me.mComponente.EliminarDOCUMENTO_SALIDA_ENCA(lEntidad.ID_DOCSAL_ENCA) <> 1 Then
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
        If e.Column.FieldName = "TIPO_MOVIMIENTO" Then
            If e.GetListSourceFieldValue("ID_TIPO_MOVTO") IsNot Nothing Then
                Dim lEntidad As TIPO_MOVTO = (New cTIPO_MOVTO).ObtenerTIPO_MOVTO(e.GetListSourceFieldValue("ID_TIPO_MOVTO"))
                If lEntidad IsNot Nothing Then e.Value = lEntidad.NOMBRE_TIPO_MOVTO
            End If
        ElseIf e.Column.FieldName = "NOMBRE_BODEGA" Then
            If e.GetListSourceFieldValue("ID_BODEGA") IsNot Nothing Then
                Dim lEntidad As BODEGA = (New cBODEGA).ObtenerBODEGA(e.GetListSourceFieldValue("ID_BODEGA"))
                If lEntidad IsNot Nothing Then e.Value = lEntidad.NOMBRE_BODEGA
            End If
        ElseIf e.Column.FieldName = "NO_SOLICITUD_RETIRO" Then
            If e.GetListSourceFieldValue("ID_SALBODE_ENCA") IsNot Nothing AndAlso e.GetListSourceFieldValue("ID_SALBODE_ENCA") > 0 Then
                Dim lEntidad As SALBODE_ENCA = (New cSALBODE_ENCA).ObtenerSALBODE_ENCA(e.GetListSourceFieldValue("ID_SALBODE_ENCA"))
                If lEntidad IsNot Nothing Then e.Value = lEntidad.NO_DOCUMENTO.ToString + "-" + (New cZAFRA).ObtenerZAFRA(lEntidad.ID_ZAFRA).NOMBRE_ZAFRA
            End If
        End If
    End Sub
End Class
