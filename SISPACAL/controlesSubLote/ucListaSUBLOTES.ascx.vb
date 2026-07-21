
Imports DevExpress.Web
Imports SISPACAL.BL
Imports SISPACAL.EL

Partial Class controlesSubLote_ucListaSUBLOTES
    Inherits ucListaBase

    Public Event Editando(ByVal ID_SUBLOTES As Int32)
    Public Property PermitirEditar As Boolean
        Set(value As Boolean)
            Me.ViewState("PermitirEditar") = value
        End Set
        Get
            If Me.ViewState("PermitirEditar") Is Nothing Then
                Return False
            Else
                Return Convert.ToBoolean(Me.ViewState("PermitirEditar"))
            End If
        End Get
    End Property

    Public WriteOnly Property SeleccionarFila() As Object
        Set(value As Object)
            Dim indice As Int32
            Me.dxgvLista.Selection.SelectRowByKey(value)
            indice = Me.dxgvLista.FindVisibleIndexByKeyValue(value)
            Me.dxgvLista.FocusedRowIndex = indice
        End Set
    End Property
    Private Sub dxgvLista_Init(sender As Object, e As EventArgs) Handles dxgvLista.Init
        dxgvLista.Columns("Editar").Visible = PermitirEditar
    End Sub
    Private Sub dxgvLista_RowCommand(sender As Object, e As ASPxGridViewRowCommandEventArgs) Handles dxgvLista.RowCommand
        If e.CommandArgs.CommandName = "Editar" Then
            RaiseEvent Editando(e.KeyValue)
        End If
    End Sub

    Public Function DevolverSeleccionados() As listaSUBLOTES
        Dim mLista As New listaSUBLOTES

        Dim lista As List(Of Object) = Me.dxgvLista.GetSelectedFieldValues("ID_SUBLOTES", "ACCESLOTE")
        For Each item As Object In lista
            Dim lEntidad As New SUBLOTES
            lEntidad.ID_SUBLOTES = Convert.ToInt32(item(0))
            lEntidad.ACCESLOTE = Convert.ToString(item(1))
            mLista.Add(lEntidad)
        Next
        Return mLista
    End Function

    Public Function CargarDatosPoCriterios(ByVal ID_MAESTRO As Int32,
                                            Optional asColumnaOrden As String = "CORRELATIVO",
                                            Optional asTipoOrden As String = "ASC") As Integer
        Me.odsListaPorCriterios.SelectParameters("ID_MAESTRO").DefaultValue = ID_MAESTRO.ToString()
        Me.odsListaPorCriterios.SelectParameters("asColumnaOrden").DefaultValue = asColumnaOrden
        Me.odsListaPorCriterios.SelectParameters("asTipoOrden").DefaultValue = asTipoOrden
        Me.odsListaPorCriterios.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorCriterios"
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    Public Function CargarDatosPorListaSUBLOTES_CONTRATADOS(ByVal CODIPROVEEDOR As String,
                                           ByVal ID_ZAFRA_CONTRATO As Int32) As Integer
        Me.odsListaSUBLOTES_CONTRATADOS.SelectParameters("CODIPROVEEDOR").DefaultValue = CODIPROVEEDOR
        Me.odsListaSUBLOTES_CONTRATADOS.SelectParameters("ID_ZAFRA_CONTRATO").DefaultValue = ID_ZAFRA_CONTRATO
        Me.odsListaSUBLOTES_CONTRATADOS.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaSUBLOTES_CONTRATADOS"
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    Protected Sub dxgvLista_CustomUnboundColumnData(sender As Object, e As DevExpress.Web.ASPxGridViewColumnDataEventArgs) Handles dxgvLista.CustomUnboundColumnData
        If e.Column.FieldName = "NOMBRE_MAESTRO" Then
            If e.GetListSourceFieldValue("ID_MAESTRO") IsNot Nothing Then
                Dim lEntidad As MAESTRO_LOTES = (New cMAESTRO_LOTES).ObtenerMAESTRO_LOTES(e.GetListSourceFieldValue("ID_MAESTRO"))
                If lEntidad IsNot Nothing Then
                    e.Value = lEntidad.NOMBRE_COMER
                End If
            End If
        ElseIf e.Column.FieldName = "VARIEDAD" Then
            If e.GetListSourceFieldValue("CODIVARIEDA") IsNot Nothing Then
                Dim lEntidad As VARIEDAD = (New cVARIEDAD).ObtenerVARIEDAD(e.GetListSourceFieldValue("CODIVARIEDA"))
                If lEntidad IsNot Nothing Then
                    e.Value = lEntidad.NOM_VARIEDAD
                End If
            End If
        ElseIf e.Column.FieldName = "TIPO_CANA" Then
            If e.GetListSourceFieldValue("ID_TIPO") IsNot Nothing Then
                Dim lEntidad As TIPOS_GENERALES = (New cTIPOS_GENERALES).ObtenerTIPOS_GENERALES(e.GetListSourceFieldValue("ID_TIPO"))
                If lEntidad IsNot Nothing Then
                    e.Value = lEntidad.NOM_TIPO
                End If
            End If
        End If
    End Sub

    Public Property VerACCESLOTE() As Boolean
        Get
            Return Me.dxgvLista.Columns("ACCESLOTE").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ACCESLOTE").Visible = Value
        End Set
    End Property

    Public Property VerCOD_LOTE() As Boolean
        Get
            Return Me.dxgvLista.Columns("CODILOTE").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CODILOTE").Visible = Value
        End Set
    End Property

    Public Property VerNOMBRE_LOTE() As Boolean
        Get
            Return Me.dxgvLista.Columns("NOMBLOTE").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NOMBLOTE").Visible = Value
        End Set
    End Property

    Public Function GetCheckBoxVisible() As Boolean
        Return MostrarCheckTodos
    End Function

    Public Property MostrarCheckTodos() As Boolean
        Get
            If Not Me.ViewState("MostrarCheckTodos") Is Nothing Then
                Return Me.ViewState("MostrarCheckTodos")
            Else
                Return False
            End If
        End Get
        Set(ByVal Value As Boolean)
            If Not Me.ViewState("MostrarCheckTodos") Is Nothing Then Me.ViewState.Remove("MostrarCheckTodos")
            Me.ViewState.Add("MostrarCheckTodos", Value)
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

    Public Property PermitirEliminar() As Boolean
        Get
            Return Me.dxgvLista.Columns("Eliminar").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("Eliminar").Visible = Value
        End Set
    End Property

    Protected Sub chkTodo_Init(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim chkTodo As ASPxCheckBox = TryCast(sender, ASPxCheckBox)
        Dim grd As ASPxGridView = TryCast(chkTodo.NamingContainer, GridViewHeaderTemplateContainer).Grid
        chkTodo.Checked = (grd.Selection.Count = grd.VisibleRowCount) AndAlso grd.VisibleRowCount > 0
    End Sub
End Class
