Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucListaAGRONOMO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla AGRONOMO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	25/09/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucListaAGRONOMO
    Inherits ucListaBase
 
    Private mComponente As New cAGRONOMO
    Public Event Seleccionado(ByVal CODIAGRON As String) 
    Public Event Editando(ByVal CODIAGRON As String) 

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

    Public Property VerCODIAGRON() As Boolean
        Get
            Return Me.dxgvLista.Columns("CODIAGRON").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CODIAGRON").Visible = Value
        End Set
    End Property

    Public Property VerAPELLIDO_AGRONOMO() As Boolean
        Get
            Return Me.dxgvLista.Columns("APELLIDO_AGRONOMO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("APELLIDO_AGRONOMO").Visible = Value
        End Set
    End Property

    Public Property VerNOMBRE_AGRONOMO() As Boolean
        Get
            Return Me.dxgvLista.Columns("NOMBRE_AGRONOMO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NOMBRE_AGRONOMO").Visible = Value
        End Set
    End Property

    Public Property VerTELEF_AGRONOMO() As Boolean
        Get
            Return Me.dxgvLista.Columns("TELEF_AGRONOMO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TELEF_AGRONOMO").Visible = Value
        End Set
    End Property

    Public Property VerZONA() As Boolean
        Get
            Return Me.dxgvLista.Columns("ZONA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ZONA").Visible = Value
        End Set
    End Property

    Public Property VerESTADO_AGRONOMO() As Boolean
        Get
            Return Me.dxgvLista.Columns("ESTADO_AGRONOMO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ESTADO_AGRONOMO").Visible = Value
        End Set
    End Property

    Public Property VerUSER_CREA() As Boolean
        Get
            Return Me.dxgvLista.Columns("USER_CREA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("USER_CREA").Visible = Value
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

    Public Property VerUSER_ACT() As Boolean
        Get
            Return Me.dxgvLista.Columns("USER_ACT").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("USER_ACT").Visible = Value
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

    Public Property VerUSUARIO_SIGESTA() As Boolean
        Get
            Return Me.dxgvLista.Columns("USUARIO_SIGESTA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("USUARIO_SIGESTA").Visible = Value
        End Set
    End Property

    Public Property HeaderCODIAGRON() As String
        Get
            Return Me.dxgvLista.Columns("CODIAGRON").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CODIAGRON").Caption = Value
        End Set
    End Property

    Public Property HeaderAPELLIDO_AGRONOMO() As String
        Get
            Return Me.dxgvLista.Columns("APELLIDO_AGRONOMO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("APELLIDO_AGRONOMO").Caption = Value
        End Set
    End Property

    Public Property HeaderNOMBRE_AGRONOMO() As String
        Get
            Return Me.dxgvLista.Columns("NOMBRE_AGRONOMO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("NOMBRE_AGRONOMO").Caption = Value
        End Set
    End Property

    Public Property HeaderTELEF_AGRONOMO() As String
        Get
            Return Me.dxgvLista.Columns("TELEF_AGRONOMO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TELEF_AGRONOMO").Caption = Value
        End Set
    End Property

    Public Property HeaderZONA() As String
        Get
            Return Me.dxgvLista.Columns("ZONA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ZONA").Caption = Value
        End Set
    End Property

    Public Property HeaderESTADO_AGRONOMO() As String
        Get
            Return Me.dxgvLista.Columns("ESTADO_AGRONOMO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ESTADO_AGRONOMO").Caption = Value
        End Set
    End Property

    Public Property HeaderUSER_CREA() As String
        Get
            Return Me.dxgvLista.Columns("USER_CREA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("USER_CREA").Caption = Value
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

    Public Property HeaderUSER_ACT() As String
        Get
            Return Me.dxgvLista.Columns("USER_ACT").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("USER_ACT").Caption = Value
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

    Public Property HeaderUSUARIO_SIGESTA() As String
        Get
            Return Me.dxgvLista.Columns("USUARIO_SIGESTA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("USUARIO_SIGESTA").Caption = Value
        End Set
    End Property

#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla AGRONOMO
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	25/09/2014	Created
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
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla AGRONOMO
    ''' filtrado por la tabla ZONAS
    ''' </summary>
    ''' <param name="ZONA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	25/09/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorZONAS(ByVal ZONA As String) As Integer
        Me.odsListaPorZONAS.SelectParameters("ZONA").DefaultValue = ZONA.ToString()
        Me.odsListaPorZONAS.SelectParameters("recuperarHijas").DefaultValue = "False"
        Me.odsListaPorZONAS.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorZONAS.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorZONAS.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorZONAS.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorZONAS"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla AGRONOMO
    ''' filtrado por la tabla USUARIO
    ''' </summary>
    ''' <param name="USUARIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	25/09/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorUSUARIO(ByVal USUARIO As String) As Integer
        Me.odsListaPorUSUARIO.SelectParameters("USUARIO").DefaultValue = USUARIO.ToString()
        Me.odsListaPorUSUARIO.SelectParameters("recuperarHijas").DefaultValue = "False"
        Me.odsListaPorUSUARIO.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorUSUARIO.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorUSUARIO.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorUSUARIO.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorUSUARIO"
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
                keyValues(i) = grid.GetRowValues(i, "CODIAGRON")
                keyNames(i) = grid.GetRowValues(i, "APELLIDO_AGRONOMO")
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
        'If e.RowType = DevExpress.Web.GridViewRowType.EditForm Then
        '    Dim btnGuardar As DevExpress.Web.ASPxButton
        '    Dim btnCancelar As DevExpress.Web.ASPxButton
        '    btnGuardar = Me.dxgvLista.FindEditFormTemplateControl("btnGuardar")
        '    btnCancelar = Me.dxgvLista.FindEditFormTemplateControl("btnCancelar")
        '    btnGuardar.JSProperties.Add("cp_NombreClienteLista", Me.NombreGridCliente)
        '    btnCancelar.JSProperties.Add("cp_NombreClienteLista", Me.NombreGridCliente)
        'End If
        'If e.RowType = DevExpress.Web.GridViewRowType.EmptyDataRow Then
        '    Dim btnAgregar As DevExpress.Web.ASPxButton
        '    btnAgregar = Me.dxgvLista.FindEmptyDataRowTemplateControl("btnAgregar")
        '    btnAgregar.JSProperties.Add("cp_NombreClienteLista", Me.NombreGridCliente)
        '    btnAgregar.Visible = Me.PermitirAgregarInline
        '    Dim lblEmptyDataRow As DevExpress.Web.ASPxLabel
        '    lblEmptyDataRow = Me.dxgvLista.FindEmptyDataRowTemplateControl("lblEmptyDataRow")
        '    lblEmptyDataRow.Text = Me.dxgvLista.SettingsText.EmptyDataRow
        'End If
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

    Public Function DevolverSeleccionados() As listaAGRONOMO
        Dim mLista As New listaAGRONOMO
        For Each llave As Decimal In Me.dxgvLista.GetSelectedFieldValues("CODIAGRON")
            Dim lEntidad As New AGRONOMO
            lEntidad.CODIAGRON = llave
            mLista.Add(lEntidad)
        Next
        Return mLista
    End Function

    Protected Sub dxgvLista_CustomButtonCallback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewCustomButtonCallbackEventArgs) Handles dxgvLista.CustomButtonCallback
        If e.ButtonID = "btnEliminar" Then
            Dim lEntidad As AGRONOMO = CType(Me.dxgvLista.GetRow(e.VisibleIndex), AGRONOMO)

            If Me.mComponente.EliminarAGRONOMO(lEntidad.CODIAGRON) <> 1 Then
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
        If e.Column.FieldName = "ESTADO" Then
            If e.GetListSourceFieldValue("ESTADO_AGRONOMO") = 1 Then
                e.Value = True
            Else
                e.Value = False
            End If
        End If
    End Sub
End Class
