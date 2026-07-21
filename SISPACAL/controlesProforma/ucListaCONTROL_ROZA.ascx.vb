Imports SISPACAL.BL
Imports SISPACAL.EL
Imports System.Data
Imports DevExpress.Web

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucListaCONTROL_ROZA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla CONTROL_ROZA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	29/11/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucListaCONTROL_ROZA
    Inherits ucListaBase

    Private mComponente As New cCONTROL_ROZA
    Public Event Seleccionado(ByVal ID_CONTROL_ROZA As Int32)
    Public Event Editando(ByVal ID_CONTROL_ROZA As Int32)
    Public Event Eliminado(ByVal ID_ZAFRA As Int32, ByVal ACCESLOTE As String)

#Region "Propiedades"

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

    Public Property TamanoPagina() As Integer
        Get
            Return Me.dxgvLista.SettingsPager.PageSize
        End Get
        Set(ByVal Value As Integer)
            Me.dxgvLista.SettingsPager.PageSize = Value
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

    Public Property VerID_CONTROL_ROZA() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_CONTROL_ROZA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_CONTROL_ROZA").Visible = Value
        End Set
    End Property

    Public Property VerID_ZAFRA() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_ZAFRA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_ZAFRA").Visible = Value
        End Set
    End Property

    Public Property VerACCESLOTE() As Boolean
        Get
            Return Me.dxgvLista.Columns("ACCESLOTE").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ACCESLOTE").Visible = Value
        End Set
    End Property

    Public Property VerDIAZAFRA() As Boolean
        Get
            Return Me.dxgvLista.Columns("DIAZAFRA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("DIAZAFRA").Visible = Value
        End Set
    End Property

    Public Property VerCONCEPTO() As Boolean
        Get
            Return Me.dxgvLista.Columns("CONCEPTO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CONCEPTO").Visible = Value
        End Set
    End Property

    Public Property VerCODIGO_REF() As Boolean
        Get
            Return Me.dxgvLista.Columns("CODIGO_REF").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CODIGO_REF").Visible = Value
        End Set
    End Property

    Public Property VerID_REF() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_REF").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_REF").Visible = Value
        End Set
    End Property

    Public Property VerENTRADAS() As Boolean
        Get
            Return Me.dxgvLista.Columns("ENTRADAS").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ENTRADAS").Visible = Value
        End Set
    End Property

    Public Property VerSALIDAS() As Boolean
        Get
            Return Me.dxgvLista.Columns("SALIDAS").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("SALIDAS").Visible = Value
        End Set
    End Property

    Public Property VerSALDO() As Boolean
        Get
            Return Me.dxgvLista.Columns("SALDO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("SALDO").Visible = Value
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

    Public Property HeaderID_CONTROL_ROZA() As String
        Get
            Return Me.dxgvLista.Columns("ID_CONTROL_ROZA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_CONTROL_ROZA").Caption = Value
        End Set
    End Property

    Public Property HeaderID_ZAFRA() As String
        Get
            Return Me.dxgvLista.Columns("ID_ZAFRA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_ZAFRA").Caption = Value
        End Set
    End Property

    Public Property HeaderACCESLOTE() As String
        Get
            Return Me.dxgvLista.Columns("ACCESLOTE").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ACCESLOTE").Caption = Value
        End Set
    End Property

    Public Property HeaderDIAZAFRA() As String
        Get
            Return Me.dxgvLista.Columns("DIAZAFRA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("DIAZAFRA").Caption = Value
        End Set
    End Property

    Public Property HeaderCONCEPTO() As String
        Get
            Return Me.dxgvLista.Columns("CONCEPTO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CONCEPTO").Caption = Value
        End Set
    End Property

    Public Property HeaderCODIGO_REF() As String
        Get
            Return Me.dxgvLista.Columns("CODIGO_REF").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CODIGO_REF").Caption = Value
        End Set
    End Property

    Public Property HeaderID_REF() As String
        Get
            Return Me.dxgvLista.Columns("ID_REF").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_REF").Caption = Value
        End Set
    End Property

    Public Property HeaderENTRADAS() As String
        Get
            Return Me.dxgvLista.Columns("ENTRADAS").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ENTRADAS").Caption = Value
        End Set
    End Property

    Public Property HeaderSALIDAS() As String
        Get
            Return Me.dxgvLista.Columns("SALIDAS").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("SALIDAS").Caption = Value
        End Set
    End Property

    Public Property HeaderSALDO() As String
        Get
            Return Me.dxgvLista.Columns("SALDO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("SALDO").Caption = Value
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
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla CONTROL_ROZA
    ''' filtrado por la tabla LOTES
    ''' </summary>
    ''' <param name="ID_ZAFRA"></param> 
    ''' <param name="ACCESLOTE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorZAFRA_LOTE(ByVal ID_ZAFRA As Int32, ByVal ACCESLOTE As String, ByVal asColumnaOrden As String, ByVal asTipoOrden As String) As Integer
        Me.odsListaPorZAFRA_LOTE.SelectParameters("ID_ZAFRA").DefaultValue = ID_ZAFRA.ToString()
        Me.odsListaPorZAFRA_LOTE.SelectParameters("ACCESLOTE").DefaultValue = ACCESLOTE
        Me.odsListaPorZAFRA_LOTE.SelectParameters("asColumnaOrden").DefaultValue = asColumnaOrden
        Me.odsListaPorZAFRA_LOTE.SelectParameters("asTipoOrden").DefaultValue = asTipoOrden
        Me.odsListaPorZAFRA_LOTE.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorZAFRA_LOTE"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    Public Function CargarDatosPorCONTROL_SALDO_ROZA(ByVal ID_ROZA_SALDO As Int32, ByVal asColumnaOrden As String, ByVal asTipoOrden As String) As Integer
        Me.odsListaPorCONTROL_SALDO_ROZA.SelectParameters("ID_ROZA_SALDO").DefaultValue = ID_ROZA_SALDO.ToString()
        Me.odsListaPorCONTROL_SALDO_ROZA.SelectParameters("recuperarForaneas").DefaultValue = False
        Me.odsListaPorCONTROL_SALDO_ROZA.SelectParameters("asColumnaOrden").DefaultValue = asColumnaOrden
        Me.odsListaPorCONTROL_SALDO_ROZA.SelectParameters("asTipoOrden").DefaultValue = asTipoOrden
        Me.odsListaPorCONTROL_SALDO_ROZA.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorCONTROL_SALDO_ROZA"
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
                keyValues(i) = grid.GetRowValues(i, "ID_CONTROL_ROZA")
                keyNames(i) = grid.GetRowValues(i, "ID_ZAFRA")
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
        If Me.PermitirEliminar Then
            Me.dxgvLista.Columns("Eliminar").Visible = True
        End If
        If Me.NombreComboCliente = "" Then
            Me.dxgvLista.ClientSideEvents.RowClick = ""
        End If
        Me.dxgvLista.ForceDataRowType(GetType(listaCONTROL_ROZA))
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
                If lbDetalle IsNot Nothing Then
                    lbDetalle.Visible = False
                End If
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

    Public Function DevolverSeleccionados() As listaCONTROL_ROZA
        Dim mLista As New listaCONTROL_ROZA
        For Each llave As Decimal In Me.dxgvLista.GetSelectedFieldValues("ID_CONTROL_ROZA")
            Dim lEntidad As New CONTROL_ROZA
            lEntidad.ID_CONTROL_ROZA = llave
            mLista.Add(lEntidad)
        Next
        Return mLista
    End Function

    Protected Sub dxgvLista_CustomButtonCallback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewCustomButtonCallbackEventArgs) Handles dxgvLista.CustomButtonCallback
        If e.ButtonID = "btnEliminar" Then
            If Not dxgvLista.JSProperties.ContainsKey("cpSaldoRoza") Then dxgvLista.JSProperties.Add("cpSaldoRoza", 0)
            Dim lEntidad As CONTROL_ROZA = CType(CType(sender, ASPxGridView).GetRow(e.VisibleIndex), CONTROL_ROZA)

            If Me.mComponente.EliminarCONTROL_ROZA(lEntidad.ID_CONTROL_ROZA) <> 1 Then
                'Si se cometio un error
                Me.AsignarMensaje("Error al Eliminar Registro", True, True)
            Else
                Me.dxgvLista.DataBind()
                dxgvLista.JSProperties.Add("cpSALDO_ROZA", 0)
            End If
        End If
    End Sub

    Protected Sub dxgvLista_CustomButtonInitialize(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewCustomButtonEventArgs) Handles dxgvLista.CustomButtonInitialize
        If e.ButtonID = "btnEliminar" Then
            'Obtener el último id de control de roza
            e.Visible = DevExpress.Utils.DefaultBoolean.False

            Dim movtoControlRoza As CONTROL_ROZA = CType(dxgvLista.GetRow(e.VisibleIndex), CONTROL_ROZA)

            If movtoControlRoza IsNot Nothing Then
                If movtoControlRoza.CODIGO_REF = "ROZADIA" AndAlso movtoControlRoza.CONCEPTO = "CUOTA DE COSECHA" Then
                    Dim lista As listaCONTROL_ROZA = (New cCONTROL_ROZA).ObtenerListaPorZAFRA_LOTE(movtoControlRoza.ID_ZAFRA, movtoControlRoza.ACCESLOTE, "ID_CONTROL_ROZA", "DESC")
                    If lista IsNot Nothing AndAlso lista.Count > 0 AndAlso lista(0).ID_CONTROL_ROZA = movtoControlRoza.ID_CONTROL_ROZA Then
                        e.Visible = DevExpress.Utils.DefaultBoolean.True
                    End If
                End If
            End If

            e.Text = "<img src='imagenes/Eliminar.gif' style='border-style:none;border-width:0px;height:18px;width:18px;' alt='Eliminar' onclick='if(!window.confirm(" + """" + "Esta seguro de Eliminar el Registro?"")){return false;}'/>"
        End If
    End Sub

    Protected Sub dxgvLista_CustomUnboundColumnData(sender As Object, e As DevExpress.Web.ASPxGridViewColumnDataEventArgs) Handles dxgvLista.CustomUnboundColumnData
        If e.Column.FieldName = "NO_DOCUMENTO" Then
            Select Case e.GetListSourceFieldValue("CODIGO_REF")
                Case "ROZADIA"
                    e.Value = ""
                Case "PROFORMA", "REPROFORMA"
                    Dim lProforma As PROFORMA = (New cPROFORMA).ObtenerPROFORMA(CInt(e.GetListSourceFieldValue("ID_REF")))
                    If lProforma IsNot Nothing Then e.Value = lProforma.NOPROFORMA.ToString Else e.Value = ""
                Case "RECBASCULA"
                    Dim lEnvio As ENVIO = (New cENVIO).ObtenerENVIO(CInt(e.GetListSourceFieldValue("ID_REF")))
                    If lEnvio IsNot Nothing Then e.Value = lEnvio.NUMRECIBO_CANA.ToString Else e.Value = ""
            End Select
        ElseIf e.Column.FieldName = "FECHA_ROZA" Then
            If e.GetListSourceFieldValue("FECHA_HORA_ROZA") IsNot Nothing AndAlso e.GetListSourceFieldValue("FECHA_HORA_ROZA") <> #12:00:00 AM# Then
                e.Value = CDate(e.GetListSourceFieldValue("FECHA_HORA_ROZA")).ToString("dd/MM/yyyy HH:mm")
            End If
        ElseIf e.Column.FieldName = "FECHA_QUEMA" Then
            If e.GetListSourceFieldValue("FECHA_HORA_QUEMA") IsNot Nothing AndAlso e.GetListSourceFieldValue("FECHA_HORA_QUEMA") <> #12:00:00 AM# Then
                e.Value = CDate(e.GetListSourceFieldValue("FECHA_HORA_QUEMA")).ToString("dd/MM/yyyy HH:mm")
            End If
        ElseIf e.Column.FieldName = "TIPO_ROZA" Then
            If e.GetListSourceFieldValue("ID_TIPO_ROZA") IsNot Nothing Then
                Dim lTipos As TIPOS_GENERALES = (New cTIPOS_GENERALES).ObtenerTIPOS_GENERALES(CInt(e.GetListSourceFieldValue("ID_TIPO_ROZA")))
                If lTipos IsNot Nothing Then e.Value = lTipos.NOM_TIPO
            End If
        ElseIf e.Column.FieldName = "FORMA_COSECHA" Then
            If e.GetListSourceFieldValue("ID_TIPO_CANA") IsNot Nothing Then
                Dim lTipos As TIPOS_GENERALES = (New cTIPOS_GENERALES).ObtenerTIPOS_GENERALES(CInt(e.GetListSourceFieldValue("ID_TIPO_CANA")))
                If lTipos IsNot Nothing Then e.Value = lTipos.NOM_TIPO
            End If
        ElseIf e.Column.FieldName = "NOMBRE_USUARIO" Then
            If e.GetListSourceFieldValue("USUARIO_CREA") IsNot Nothing Then
                Dim lEntidad As USUARIO = (New cUSUARIO).ObtenerUSUARIO(e.GetListSourceFieldValue("USUARIO_CREA"))
                If lEntidad IsNot Nothing Then e.Value = lEntidad.NOMBRE
            End If
        ElseIf e.Column.FieldName = "PROVEEDOR_ROZA" Then
            If e.GetListSourceFieldValue("ID_PROVEEDOR_ROZA") <> -1 Then
                Dim lProveedorRoza As PROVEEDOR_ROZA = (New cPROVEEDOR_ROZA).ObtenerPROVEEDOR_ROZA(CInt(e.GetListSourceFieldValue("ID_PROVEEDOR_ROZA")))
                If lProveedorRoza IsNot Nothing Then
                    e.Value = lProveedorRoza.NOMBRE_PROVEEDOR_ROZA
                End If
            End If
        ElseIf e.Column.FieldName = "NOMBRE_TIPO_TRANS" Then
            If e.GetListSourceFieldValue("CODIGO_REF") = "PROFORMA" Then
                Dim lProforma As PROFORMA = (New cPROFORMA).ObtenerPROFORMA(CInt(e.GetListSourceFieldValue("ID_REF")))
                If lProforma IsNot Nothing Then
                    Dim lTransporte As TIPO_TRANSPORTE = (New cTIPO_TRANSPORTE).ObtenerTIPO_TRANSPORTE(lProforma.ID_TIPOTRANS)
                    If lTransporte IsNot Nothing Then
                        e.Value = lTransporte.NOMBRE
                    End If
                End If
            End If
        End If
    End Sub
End Class
