Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucListaCANTON
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla CANTON
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	28/07/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucListaCANTON
    Inherits ucListaBase
 
    Private mComponente As New cCANTON
    Public Event Seleccionado(ByVal CODI_CANTON As String, ByVal CODI_DEPTO As String, ByVal CODI_MUNI As String) 
    Public Event Editando(ByVal CODI_CANTON As String, ByVal CODI_DEPTO As String, ByVal CODI_MUNI As String) 

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

    Public Property VerCODI_CANTON() As Boolean
        Get
            Return Me.dxgvLista.Columns("CODI_CANTON").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CODI_CANTON").Visible = Value
        End Set
    End Property

    Public Property VerCODI_DEPTO() As Boolean
        Get
            Return Me.dxgvLista.Columns("CODI_DEPTO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CODI_DEPTO").Visible = Value
        End Set
    End Property

    Public Property VerCODI_MUNI() As Boolean
        Get
            Return Me.dxgvLista.Columns("CODI_MUNI").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CODI_MUNI").Visible = Value
        End Set
    End Property

    Public Property VerNOMBRE_CANTON() As Boolean
        Get
            Return Me.dxgvLista.Columns("NOMBRE_CANTON").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NOMBRE_CANTON").Visible = Value
        End Set
    End Property

    Public Property VerKILOMETROS() As Boolean
        Get
            Return Me.dxgvLista.Columns("KILOMETROS").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("KILOMETROS").Visible = Value
        End Set
    End Property

    Public Property VerPOSICION_GEO() As Boolean
        Get
            Return Me.dxgvLista.Columns("POSICION_GEO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("POSICION_GEO").Visible = Value
        End Set
    End Property

    Public Property VerCOORDENADAS() As Boolean
        Get
            Return Me.dxgvLista.Columns("COORDENADAS").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("COORDENADAS").Visible = Value
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

    Public Property VerZONA() As Boolean
        Get
            Return Me.dxgvLista.Columns("ZONA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ZONA").Visible = Value
        End Set
    End Property

    Public Property VerSUB_ZONA() As Boolean
        Get
            Return Me.dxgvLista.Columns("SUB_ZONA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("SUB_ZONA").Visible = Value
        End Set
    End Property

    Public Property HeaderCODI_CANTON() As String
        Get
            Return Me.dxgvLista.Columns("CODI_CANTON").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CODI_CANTON").Caption = Value
        End Set
    End Property

    Public Property HeaderCODI_DEPTO() As String
        Get
            Return Me.dxgvLista.Columns("CODI_DEPTO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CODI_DEPTO").Caption = Value
        End Set
    End Property

    Public Property HeaderCODI_MUNI() As String
        Get
            Return Me.dxgvLista.Columns("CODI_MUNI").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CODI_MUNI").Caption = Value
        End Set
    End Property

    Public Property HeaderNOMBRE_CANTON() As String
        Get
            Return Me.dxgvLista.Columns("NOMBRE_CANTON").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("NOMBRE_CANTON").Caption = Value
        End Set
    End Property

    Public Property HeaderKILOMETROS() As String
        Get
            Return Me.dxgvLista.Columns("KILOMETROS").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("KILOMETROS").Caption = Value
        End Set
    End Property

    Public Property HeaderPOSICION_GEO() As String
        Get
            Return Me.dxgvLista.Columns("POSICION_GEO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("POSICION_GEO").Caption = Value
        End Set
    End Property

    Public Property HeaderCOORDENADAS() As String
        Get
            Return Me.dxgvLista.Columns("COORDENADAS").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("COORDENADAS").Caption = Value
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

    Public Property HeaderZONA() As String
        Get
            Return Me.dxgvLista.Columns("ZONA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ZONA").Caption = Value
        End Set
    End Property

    Public Property HeaderSUB_ZONA() As String
        Get
            Return Me.dxgvLista.Columns("SUB_ZONA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("SUB_ZONA").Caption = Value
        End Set
    End Property

#End Region


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla CANTON
    ''' filtrado por la tabla ZONAS
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/07/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorCriterios(ByVal CODI_DEPTO As String, ByVal CODI_MUNI As String, ByVal CODI_CANTON As String) As Integer
        Me.odsCriterios.SelectParameters("CODI_DEPTO").DefaultValue = CODI_DEPTO
        Me.odsCriterios.SelectParameters("CODI_MUNI").DefaultValue = CODI_MUNI
        Me.odsCriterios.SelectParameters("CODI_CANTON").DefaultValue = CODI_CANTON
        Me.odsCriterios.DataBind()
        Me.dxgvLista.DataSourceID = "odsCriterios"
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
                keyValues(i) = grid.GetRowValues(i, "CODI_MUNI")
                keyNames(i) = grid.GetRowValues(i, "CODI_CANTON") + ";" + grid.GetRowValues(i, "CODI_DEPTO") + ";" + grid.GetRowValues(i, "CODI_MUNI")
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
        If Me.PermitirEditarInline Then
            Me.dxgvLista.SettingsEditing.Mode = DevExpress.Web.GridViewEditingMode.Inline
        End If
        If Me.NombreComboCliente = "" Then
            Me.dxgvLista.ClientSideEvents.RowClick = ""
        End If
    End Sub

    Protected Sub dxgvLista_RowCommand(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewRowCommandEventArgs) Handles dxgvLista.RowCommand
        If e.CommandArgs.CommandName = "Select" And ComandoSeleccionar <> "Check" Then
            Me.dxgvLista.Selection.UnselectAll()
            Me.dxgvLista.Selection.SelectRow(e.VisibleIndex)
            'RaiseEvent Seleccionado(e.CommandArgs.CommandArgument)
        End If
        If e.CommandArgs.CommandName = "Editar" Then
            'RaiseEvent Editando(e.CommandArgs.CommandArgument)
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
        If e.RowType = DevExpress.Web.GridViewRowType.EmptyDataRow Then
            Dim btnAgregar As DevExpress.Web.ASPxButton
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

    Public Function DevolverSeleccionados() As listaCANTON
        Dim mLista As New listaCANTON
        For Each llave As Decimal In Me.dxgvLista.GetSelectedFieldValues("CODI_MUNI")
            Dim lEntidad As New CANTON
            'lEntidad.CODI_CANTON = Me.CODI_CANTON
            'lEntidad.CODI_DEPTO = Me.CODI_DEPTO
            'lEntidad.CODI_MUNI = llave
            mLista.Add(lEntidad)
        Next
        Return mLista
    End Function

    Protected Sub dxgvLista_CustomButtonInitialize(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewCustomButtonEventArgs) Handles dxgvLista.CustomButtonInitialize
        If e.ButtonID = "btnEliminar" Then
            e.Text = "<img src='imagenes/Eliminar.gif' style='border-style:none;border-width:0px;height:18px;width:18px;' alt='Eliminar' onclick='if(!window.confirm(" + """" + "Esta seguro de Eliminar el Registro?"")){return false;}'/>"
        End If
    End Sub

    Protected Sub dxgvLista_CustomUnboundColumnData(sender As Object, e As DevExpress.Web.ASPxGridViewColumnDataEventArgs) Handles dxgvLista.CustomUnboundColumnData
        If e.Column.FieldName = "DEPARTAMENTO" Then
            Dim lDepto As DEPARTAMENTO = (New cDEPARTAMENTO).ObtenerDEPARTAMENTO(e.GetListSourceFieldValue("CODI_DEPTO"))
            If lDepto IsNot Nothing Then e.Value = lDepto.NOMBRE_DEPTO
        ElseIf e.Column.FieldName = "MUNICIPIO" Then
            Dim lMuni As MUNICIPIO = (New cMUNICIPIO).ObtenerMUNICIPIO(e.GetListSourceFieldValue("CODI_DEPTO"), e.GetListSourceFieldValue("CODI_MUNI"))
            If lMuni IsNot Nothing Then e.Value = lMuni.NOMBRE_MUNI
        End If
    End Sub
End Class
