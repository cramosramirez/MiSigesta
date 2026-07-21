Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucListaREMESA_DETA_PRODU
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla REMESA_DETA_PRODU
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	11/09/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucListaREMESA_DETA_PRODU
    Inherits ucListaBase
 
    Private mComponente As New cREMESA_DETA_PRODU
    Public Event Seleccionado(ByVal ID_REMESA_DETA As Int32) 
    Public Event Editando(ByVal ID_REMESA_DETA As Int32) 

#Region"Propiedades"

    Public Property REFERENCIA() As String
        Get
            Return Me.ViewState("REFERENCIA")
        End Get
        Set(ByVal value As String)
            Me.ViewState("REFERENCIA") = value
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

    Public Property VerID_REMESA_DETA() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_REMESA_DETA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_REMESA_DETA").Visible = Value
        End Set
    End Property

    Public Property VerID_REMESA_ENCA() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_REMESA_ENCA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_REMESA_ENCA").Visible = Value
        End Set
    End Property

    Public Property VerID_CREDITO_ENCA() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_CREDITO_ENCA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_CREDITO_ENCA").Visible = Value
        End Set
    End Property

    Public Property VerUID_REMESA_DETA() As Boolean
        Get
            Return Me.dxgvLista.Columns("UID_REMESA_DETA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("UID_REMESA_DETA").Visible = Value
        End Set
    End Property

    Public Property VerABONO_CAPITAL() As Boolean
        Get
            Return Me.dxgvLista.Columns("ABONO_CAPITAL").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ABONO_CAPITAL").Visible = Value
        End Set
    End Property

    Public Property VerABONO_INTERES() As Boolean
        Get
            Return Me.dxgvLista.Columns("ABONO_INTERES").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ABONO_INTERES").Visible = Value
        End Set
    End Property

    Public Property VerABONO_INTERES_IVA() As Boolean
        Get
            Return Me.dxgvLista.Columns("ABONO_INTERES_IVA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ABONO_INTERES_IVA").Visible = Value
        End Set
    End Property

    Public Property HeaderID_REMESA_DETA() As String
        Get
            Return Me.dxgvLista.Columns("ID_REMESA_DETA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_REMESA_DETA").Caption = Value
        End Set
    End Property

    Public Property HeaderID_REMESA_ENCA() As String
        Get
            Return Me.dxgvLista.Columns("ID_REMESA_ENCA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_REMESA_ENCA").Caption = Value
        End Set
    End Property

    Public Property HeaderID_CREDITO_ENCA() As String
        Get
            Return Me.dxgvLista.Columns("ID_CREDITO_ENCA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_CREDITO_ENCA").Caption = Value
        End Set
    End Property

    Public Property HeaderUID_REMESA_DETA() As String
        Get
            Return Me.dxgvLista.Columns("UID_REMESA_DETA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("UID_REMESA_DETA").Caption = Value
        End Set
    End Property

    Public Property HeaderABONO_CAPITAL() As String
        Get
            Return Me.dxgvLista.Columns("ABONO_CAPITAL").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ABONO_CAPITAL").Caption = Value
        End Set
    End Property

    Public Property HeaderABONO_INTERES() As String
        Get
            Return Me.dxgvLista.Columns("ABONO_INTERES").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ABONO_INTERES").Caption = Value
        End Set
    End Property

    Public Property HeaderABONO_INTERES_IVA() As String
        Get
            Return Me.dxgvLista.Columns("ABONO_INTERES_IVA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ABONO_INTERES_IVA").Caption = Value
        End Set
    End Property

#End Region

    Public Function CargarDatosCache(ByVal nombreSesion As String) As Integer
        Me.REFERENCIA = nombreSesion
        Me.odsREMESA_DETA_PRODUcache.SelectParameters("nombreSesion_ucListaREMESA_DETA_PRODU").DefaultValue = nombreSesion
        Me.odsREMESA_DETA_PRODUcache.DataBind()
        Me.dxgvLista.DataSourceID = "odsREMESA_DETA_PRODUcache"
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla REMESA_DETA_PRODU
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	11/09/2017	Created
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
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla REMESA_DETA_PRODU
    ''' filtrado por la tabla REMESA_ENCA_PRODU
    ''' </summary>
    ''' <param name="ID_REMESA_ENCA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	11/09/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorREMESA_ENCA_PRODU(ByVal ID_REMESA_ENCA As Int32) As Integer
        Me.odsListaPorREMESA_ENCA_PRODU.SelectParameters("ID_REMESA_ENCA").DefaultValue = ID_REMESA_ENCA.ToString()
        Me.odsListaPorREMESA_ENCA_PRODU.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorREMESA_ENCA_PRODU.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorREMESA_ENCA_PRODU.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorREMESA_ENCA_PRODU.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorREMESA_ENCA_PRODU"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla REMESA_DETA_PRODU
    ''' filtrado por la tabla CREDITO_ENCA
    ''' </summary>
    ''' <param name="ID_CREDITO_ENCA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	11/09/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorCREDITO_ENCA(ByVal ID_CREDITO_ENCA As Int32) As Integer
        Me.odsListaPorCREDITO_ENCA.SelectParameters("ID_CREDITO_ENCA").DefaultValue = ID_CREDITO_ENCA.ToString()
        Me.odsListaPorCREDITO_ENCA.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorCREDITO_ENCA.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorCREDITO_ENCA.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorCREDITO_ENCA.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorCREDITO_ENCA"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquÃ­ el cÃ³digo de usuario para inicializar la pÃ¡gina
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
                keyValues(i) = grid.GetRowValues(i, "ID_REMESA_DETA")
                keyNames(i) = grid.GetRowValues(i, "ID_REMESA_ENCA")
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
        dxgvLista.ForceDataRowType(GetType(listaREMESA_DETA_PRODU))
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

    Public Function DevolverSeleccionados() As listaREMESA_DETA_PRODU
        Dim mLista As New listaREMESA_DETA_PRODU
        For Each llave As Decimal In Me.dxgvLista.GetSelectedFieldValues("ID_REMESA_DETA")
            Dim lEntidad As New REMESA_DETA_PRODU
            lEntidad.ID_REMESA_DETA = llave
            mLista.Add(lEntidad)
        Next
        Return mLista
    End Function

    Protected Sub dxgvLista_CustomButtonCallback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewCustomButtonCallbackEventArgs) Handles dxgvLista.CustomButtonCallback
        If e.ButtonID = "btnEliminar" Then
            Dim lEntidad As REMESA_DETA_PRODU = CType(Me.dxgvLista.GetRow(e.VisibleIndex), REMESA_DETA_PRODU)

            If Me.mComponente.EliminarREMESA_DETA_PRODU(lEntidad.ID_REMESA_DETA) <> 1 Then
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

    Protected Sub dxgvLista_RowUpdating(sender As Object, e As DevExpress.Web.Data.ASPxDataUpdatingEventArgs) Handles dxgvLista.RowUpdating
        e.NewValues("REFERENCIA") = Me.REFERENCIA
    End Sub

    Protected Sub dxgvLista_CustomUnboundColumnData(sender As Object, e As DevExpress.Web.ASPxGridViewColumnDataEventArgs) Handles dxgvLista.CustomUnboundColumnData
        Static idCrediEnca As Int32 = -1
        Static lZafra As String = ""
        Static lDescripFinan As String = ""
        Static lDocumento As String = ""
        Static lNoDocumento As String = ""
        Static lFecha As String = ""
        Static lFecUltMov As String = ""
        Static lTasaInt As Decimal = 0
        Static lSaldo As Decimal = 0
        Static lInteresPend As Decimal = 0
        Static lInteresIvaPend As Decimal = 0

        Dim lEntidad As CREDITO_ENCA

        If idCrediEnca <> e.GetListSourceFieldValue("ID_CREDITO_ENCA") IsNot Nothing Then
            idCrediEnca = CInt(e.GetListSourceFieldValue("ID_CREDITO_ENCA"))
            lEntidad = (New cCREDITO_ENCA).ObtenerCREDITO_ENCA(idCrediEnca)

            If lEntidad IsNot Nothing Then
                lZafra = lEntidad.ZAFRA
                lDescripFinan = lEntidad.DESCRIP_FINAN
                lDocumento = ""
                If lEntidad.ID_TIPO_COMPROB <> -1 Then lDocumento = (New cTIPO_COMPROB).ObtenerTIPO_COMPROB(lEntidad.ID_TIPO_COMPROB).NOMBRE_TIPO
                lNoDocumento = lEntidad.NO_COMPROB
                lFecha = If(lEntidad.FECHA <> #12:00:00 AM#, lEntidad.FECHA.ToString("dd/MM/yyyy"), "")
                lFecUltMov = If(lEntidad.FECHA_ULTMOV <> #12:00:00 AM#, lEntidad.FECHA_ULTMOV.ToString("dd/MM/yyyy"), "")
                lTasaInt = lEntidad.TASAINT
                lSaldo = lEntidad.SALDO
                lInteresPend = lEntidad.INTERES
                lInteresIvaPend = lEntidad.IVA_INTERES
            End If
        End If

        If e.Column.FieldName = "ZAFRA" Then
            e.Value = lZafra
        ElseIf e.Column.FieldName = "DESCRIP_FINAN" Then
            e.Value = lDescripFinan
        ElseIf e.Column.FieldName = "DOCUMENTO" Then
            e.Value = lDocumento
        ElseIf e.Column.FieldName = "NO_DOCUMENTO" Then
            e.Value = lNoDocumento
        ElseIf e.Column.FieldName = "FECHA" Then
            e.Value = lFecha
        ElseIf e.Column.FieldName = "FECHA_ULTMOVTO" Then
            e.Value = lFecUltMov
        ElseIf e.Column.FieldName = "TASA_INTERES" Then
            e.Value = lTasaInt
        ElseIf e.Column.FieldName = "SALDO" Then
            e.Value = lSaldo
        ElseIf e.Column.FieldName = "INTERES_PENDIENTE" Then
            e.Value = lInteresPend
        ElseIf e.Column.FieldName = "INTERES_IVA_PENDIENTE" Then
            e.Value = lInteresIvaPend
        End If
    End Sub
End Class
