Imports SISPACAL.BL
Imports SISPACAL.EL
Partial Class controlesFrentes_ucListaCCF_ENCA_FRENTE
    Inherits ucListaBase

    Private mComponente As New cCCF_ENCA_FRENTE
    Public Event Seleccionado(ByVal ID_CCF_ENCA As Int32)
    Public Event Editando(ByVal ID_CCF_ENCA As Int32)

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

    Public Property VerID_CCF_ENCA() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_CCF_ENCA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_CCF_ENCA").Visible = Value
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

    Public Property VerID_SOLICITUD() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_SOLICITUD").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_SOLICITUD").Visible = Value
        End Set
    End Property

    Public Property VerID_CUENTA_FINAN() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_CUENTA_FINAN").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_CUENTA_FINAN").Visible = Value
        End Set
    End Property

    Public Property VerID_TIPO_COMPROB() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_TIPO_COMPROB").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_TIPO_COMPROB").Visible = Value
        End Set
    End Property

    Public Property VerNO_CCF() As Boolean
        Get
            Return Me.dxgvLista.Columns("NO_CCF").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NO_CCF").Visible = Value
        End Set
    End Property

    Public Property VerFECHA() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA").Visible = Value
        End Set
    End Property

    Public Property VerCODIPROVEEDOR() As Boolean
        Get
            Return Me.dxgvLista.Columns("CODIPROVEEDOR").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CODIPROVEEDOR").Visible = Value
        End Set
    End Property

    Public Property VerSUB_TOTAL() As Boolean
        Get
            Return Me.dxgvLista.Columns("SUB_TOTAL").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("SUB_TOTAL").Visible = Value
        End Set
    End Property

    Public Property VerDESCTO_PORC() As Boolean
        Get
            Return Me.dxgvLista.Columns("DESCTO_PORC").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("DESCTO_PORC").Visible = Value
        End Set
    End Property

    Public Property VerDESCTO_MONTO() As Boolean
        Get
            Return Me.dxgvLista.Columns("DESCTO_MONTO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("DESCTO_MONTO").Visible = Value
        End Set
    End Property

    Public Property VerSUMAS() As Boolean
        Get
            Return Me.dxgvLista.Columns("SUMAS").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("SUMAS").Visible = Value
        End Set
    End Property

    Public Property VerIVA() As Boolean
        Get
            Return Me.dxgvLista.Columns("IVA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("IVA").Visible = Value
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

    Public Property VerTOTAL_LETRAS() As Boolean
        Get
            Return Me.dxgvLista.Columns("TOTAL_LETRAS").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TOTAL_LETRAS").Visible = Value
        End Set
    End Property

    Public Property VerUSUARIO_CREACION() As Boolean
        Get
            Return Me.dxgvLista.Columns("USUARIO_CREACION").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("USUARIO_CREACION").Visible = Value
        End Set
    End Property

    Public Property VerFECHA_CREACION() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_CREACION").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_CREACION").Visible = Value
        End Set
    End Property

    Public Property HeaderID_CCF_ENCA() As String
        Get
            Return Me.dxgvLista.Columns("ID_CCF_ENCA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_CCF_ENCA").Caption = Value
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

    Public Property HeaderID_SOLICITUD() As String
        Get
            Return Me.dxgvLista.Columns("ID_SOLICITUD").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_SOLICITUD").Caption = Value
        End Set
    End Property

    Public Property HeaderID_CUENTA_FINAN() As String
        Get
            Return Me.dxgvLista.Columns("ID_CUENTA_FINAN").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_CUENTA_FINAN").Caption = Value
        End Set
    End Property

    Public Property HeaderID_TIPO_COMPROB() As String
        Get
            Return Me.dxgvLista.Columns("ID_TIPO_COMPROB").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_TIPO_COMPROB").Caption = Value
        End Set
    End Property

    Public Property HeaderNO_CCF() As String
        Get
            Return Me.dxgvLista.Columns("NO_CCF").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("NO_CCF").Caption = Value
        End Set
    End Property

    Public Property HeaderFECHA() As String
        Get
            Return Me.dxgvLista.Columns("FECHA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA").Caption = Value
        End Set
    End Property

    Public Property HeaderCODIPROVEEDOR() As String
        Get
            Return Me.dxgvLista.Columns("CODIPROVEEDOR").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CODIPROVEEDOR").Caption = Value
        End Set
    End Property

    Public Property HeaderSUB_TOTAL() As String
        Get
            Return Me.dxgvLista.Columns("SUB_TOTAL").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("SUB_TOTAL").Caption = Value
        End Set
    End Property

    Public Property HeaderDESCTO_PORC() As String
        Get
            Return Me.dxgvLista.Columns("DESCTO_PORC").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("DESCTO_PORC").Caption = Value
        End Set
    End Property

    Public Property HeaderDESCTO_MONTO() As String
        Get
            Return Me.dxgvLista.Columns("DESCTO_MONTO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("DESCTO_MONTO").Caption = Value
        End Set
    End Property

    Public Property HeaderSUMAS() As String
        Get
            Return Me.dxgvLista.Columns("SUMAS").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("SUMAS").Caption = Value
        End Set
    End Property

    Public Property HeaderIVA() As String
        Get
            Return Me.dxgvLista.Columns("IVA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("IVA").Caption = Value
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

    Public Property HeaderTOTAL_LETRAS() As String
        Get
            Return Me.dxgvLista.Columns("TOTAL_LETRAS").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TOTAL_LETRAS").Caption = Value
        End Set
    End Property

    Public Property HeaderUSUARIO_CREACION() As String
        Get
            Return Me.dxgvLista.Columns("USUARIO_CREACION").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("USUARIO_CREACION").Caption = Value
        End Set
    End Property

    Public Property HeaderFECHA_CREACION() As String
        Get
            Return Me.dxgvLista.Columns("FECHA_CREACION").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA_CREACION").Caption = Value
        End Set
    End Property

#End Region

    Public Sub ExportarExcel()
        gridExport.WriteXlsxToResponse(New DevExpress.XtraPrinting.XlsxExportOptionsEx With {.ExportType = DevExpress.Export.ExportType.WYSIWYG})
    End Sub

    Public Function CargarDatosPorTIPO_PROVEEDOR(ByVal ID_TIPO_PROVEEDOR As Int32) As Integer
        Me.odsListaPorTipoProveedor.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorTipoProveedor.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorTipoProveedor.SelectParameters("ID_TIPO_PROVEEDOR").DefaultValue = ID_TIPO_PROVEEDOR.ToString
        Me.odsListaPorTipoProveedor.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorTipoProveedor"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    Public Function CargarDatos() As Integer
        Me.odsLista.SelectParameters("asColumnaOrden").DefaultValue = "FECHA"
        Me.odsLista.SelectParameters("asTipoOrden").DefaultValue = "DESC"
        Me.odsLista.DataBind()
        Me.dxgvLista.DataSourceID = "odsLista"
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
                keyValues(i) = grid.GetRowValues(i, "ID_CCF_ENCA")
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

    Public Function DevolverSeleccionados() As listaCCF_ENCA_FRENTE
        Dim mLista As New listaCCF_ENCA_FRENTE
        For Each llave As Decimal In Me.dxgvLista.GetSelectedFieldValues("ID_CCF_ENCA")
            Dim lEntidad As New CCF_ENCA_FRENTE
            lEntidad.ID_CCF_ENCA = llave
            mLista.Add(lEntidad)
        Next
        Return mLista
    End Function

    Protected Sub dxgvLista_CustomButtonCallback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewCustomButtonCallbackEventArgs) Handles dxgvLista.CustomButtonCallback
        If e.ButtonID = "btnEliminar" Then
            Dim lEntidad As CCF_ENCA_FRENTE = CType(Me.dxgvLista.GetRow(e.VisibleIndex), CCF_ENCA_FRENTE)

            If Me.mComponente.EliminarCCF_ENCA_FRENTE(lEntidad.ID_CCF_ENCA) <> 1 Then
                'Si se cometio un error
                dxgvLista.JSProperties.Add("cpMensaje", "Error al Eliminar Registro: " + Me.mComponente.sError)
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
        If e.Column.FieldName = "NOMBRE_ZAFRA" Then
            Dim lEntidad As ZAFRA = (New cZAFRA).ObtenerZAFRA(e.GetListSourceFieldValue("ID_ZAFRA"))
            If lEntidad IsNot Nothing Then e.Value = lEntidad.NOMBRE_ZAFRA
        ElseIf e.Column.FieldName = "NUM_SOLIC_ZAFRA" Then
            Dim lEntidad As SOLIC_ENCA_FRENTE = (New cSOLIC_ENCA_FRENTE).ObtenerSOLIC_ENCA_FRENTE(e.GetListSourceFieldValue("ID_SOLICITUD"))
            If lEntidad IsNot Nothing Then e.Value = lEntidad.NUM_SOLIC_ZAFRA
        ElseIf e.Column.FieldName = "TIPO_COMPROB" Then
            Dim lEntidad As TIPO_COMPROB = (New cTIPO_COMPROB).ObtenerTIPO_COMPROB(e.GetListSourceFieldValue("ID_TIPO_COMPROB"))
            If lEntidad IsNot Nothing Then e.Value = lEntidad.NOMBRE_TIPO
        ElseIf e.Column.FieldName = "NOMBRE_CONDI_COMPRA" Then
            e.Value = Utilerias.NombreCondicionCompra(e.GetListSourceFieldValue("CONDI_COMPRA"))
        ElseIf e.Column.FieldName = "NOMBRE_PROVEE_AGRICOLA" Then
            Dim lEntidad As PROVEEDOR_AGRICOLA = (New cPROVEEDOR_AGRICOLA).ObtenerPROVEEDOR_AGRICOLA(e.GetListSourceFieldValue("ID_PROVEE"))
            If lEntidad IsNot Nothing Then
                e.Value = lEntidad.NOMBRE
            End If
        End If
    End Sub

End Class
