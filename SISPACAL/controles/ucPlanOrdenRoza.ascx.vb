Imports System.Data
Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.DL
Imports System.Collections.Generic

Partial Class controles_ucPlanOrdenRoza
    Inherits ucBase


    Private Sub GetData()
        If grdLotes.HeaderRow Is Nothing Then Return
        Dim arr As ArrayList
        If ViewState("SelectedRecords") IsNot Nothing Then
            arr = DirectCast(ViewState("SelectedRecords"), ArrayList)
        Else
            arr = New ArrayList()
        End If
        Dim chkAll As CheckBox = DirectCast(grdLotes.HeaderRow.Cells(0).FindControl("chkAll"), CheckBox)
        For i As Integer = 0 To grdLotes.Rows.Count - 1
            If chkAll.Checked Then
                If Not arr.Contains(grdLotes.DataKeys(i).Value) Then
                    arr.Add(grdLotes.DataKeys(i).Value)
                End If
            Else
                Dim chk As CheckBox = DirectCast(grdLotes.Rows(i).Cells(0).FindControl("chk"), CheckBox)
                If chk.Checked Then
                    If Not arr.Contains(grdLotes.DataKeys(i).Value) Then
                        arr.Add(grdLotes.DataKeys(i).Value)
                    End If
                Else
                    If arr.Contains(grdLotes.DataKeys(i).Value) Then
                        arr.Remove(grdLotes.DataKeys(i).Value)
                    End If
                End If
            End If
        Next
        ViewState("SelectedRecords") = arr
    End Sub

    Private Sub SetData()
        If grdLotes.HeaderRow Is Nothing Then Return
        Dim currentCount As Integer = 0
        Dim chkAll As CheckBox = DirectCast(grdLotes.HeaderRow.Cells(0).FindControl("chkAll"), CheckBox)
        chkAll.Checked = True
        Dim arr As ArrayList = DirectCast(ViewState("SelectedRecords"), ArrayList)
        For i As Integer = 0 To grdLotes.Rows.Count - 1
            Dim chk As CheckBox = DirectCast(grdLotes.Rows(i).Cells(0).FindControl("chk"), CheckBox)
            If chk IsNot Nothing Then
                chk.Checked = arr.Contains(grdLotes.DataKeys(i).Value)
                If Not chk.Checked Then
                    chkAll.Checked = False
                Else
                    currentCount += 1
                End If
            End If
        Next
        hfCount.Value = (arr.Count - currentCount).ToString()
    End Sub

    Public Property NOMBRE_ZAFRA As String
        Get
            If Me.ViewState("NOMBRE_ZAFRA") Is Nothing Then Return ""
            Return Me.ViewState("NOMBRE_ZAFRA")
        End Get
        Set(ByVal value As String)
            Me.ViewState("NOMBRE_ZAFRA") = value
        End Set
    End Property

    Public Property ID_PLAN_SEMANAL As Integer
        Get
            If Me.ViewState("ID_PLAN_SEMANAL") Is Nothing Then Return 0
            Return Me.ViewState("ID_PLAN_SEMANAL")
        End Get
        Set(ByVal value As Integer)
            Me.ViewState("ID_PLAN_SEMANAL") = value
        End Set
    End Property

    Public Property INDICE_SELECCIONADO As Integer
        Get
            If Me.ViewState("INDICE_SELECCIONADO") Is Nothing Then Return ""
            Return Me.ViewState("INDICE_SELECCIONADO")
        End Get
        Set(ByVal value As Integer)
            Me.ViewState("INDICE_SELECCIONADO") = value
        End Set
    End Property

    Public Sub Inicializar()
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        If lZafra IsNot Nothing Then
            Me.NOMBRE_ZAFRA = lZafra.NOMBRE_ZAFRA
        End If

        Me.lblTitulo.Text = "Generar Orden de Roza"
        Me.ucBarraNavegacion1.PermitirNavegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucBarraNavegacion1.CrearOpcion("Buscar", "Buscar", False, "../Imagenes/buscar.png", "", "")
        Me.ucBarraNavegacion1.CrearOpcion("Generar", "Generar", False, "../Imagenes/generarOrden.png", "", "")
        Me.ucBarraNavegacion1.VerOpcion("Generar", True)
        Me.ucBarraNavegacion1.CargarOpciones()
        Me.DdlZONAS1.Recuperar()
        Me.DdlPLAN_SEMANAL1.Recuperar()
    End Sub

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Me.Inicializar()
        Else
            Me.GetData()
        End If
    End Sub

    Public Sub CargarLotesPorCriterios()
        Dim ds As DataSet
        Dim bLotes As New cLOTES
        ds = bLotes.ObtenerDataSetPorCriterios1(Me.NOMBRE_ZAFRA, Me.DdlZONAS1.SelectedValue, Me.DdlPLAN_SEMANAL1.SelectedValue, _
                                               Me.txtCODIPROVEE.Text, Me.txtCODSOCIO.Text, Me.txtNOMBRE_PROVEEDOR.Text, _
                                               False)
        If ds Is Nothing Then
            Me.grdLotes.Visible = False
        End If
        Me.grdLotes.SelectedIndex = -1
        Me.grdLotes.Visible = True
        Me.grdLotes.DataSource = ds
        Me.grdLotes.DataBind()
        If bLotes.sError <> "" Then
            AsignarMensaje("* Error en consulta: " + bLotes.sError, True)
        End If
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        AsignarMensaje("", True, False)

        Select Case CommandName
            Case "Buscar"
                Me.txtFECHA_ORDEN.Text = ""
                Me.txtTONEL_DIARIA.Text = ""
                If Me.DdlZONAS1.SelectedValue IsNot Nothing Then
                    Me.ID_PLAN_SEMANAL = DdlPLAN_SEMANAL1.SelectedValue
                    CargarLotesPorCriterios()
                End If
                If Me.grdLotes.Rows.Count = 0 AndAlso (txtCODIPROVEE.Text <> "" OrElse txtCODSOCIO.Text <> "") Then
                    MostrarMensaje("Proveedor no posee Lotes programados en la Zona: " + Me.DdlZONAS1.SelectedItem.Text, "Alerta")
                End If
                If Me.grdLotes.Rows.Count = 0 AndAlso txtCODIPROVEE.Text = "" AndAlso txtCODSOCIO.Text = "" Then
                    MostrarMensaje("No existen Lotes programados con los criterios seleccionados", "Alerta")
                End If

            Case "Generar"
                Dim lista As New List(Of String)
                Dim lProgramacionLote As New PLAN_ENTREGA_CANA
                Dim lProgramacionLotes As New listaPLAN_ENTREGA_CANA
                Dim bPlanEntrega As New cPLAN_ENTREGA_CANA
                Dim existeSeleccion As Boolean = False
                Dim fechaOrden As Date
                Dim lRet As Integer

                If Not IsNumeric(Me.txtTONEL_DIARIA.Text) Then
                    AsignarMensaje("* Cuota diaria debe ser un numero", True)
                    txtTONEL_DIARIA.Focus()
                    Return
                End If
                If Convert.ToDecimal(Me.txtTONEL_DIARIA.Text) <= 0 Then
                    AsignarMensaje("* Cuota diaria debe ser mayor que cero", True)
                    Me.txtTONEL_DIARIA.Focus()
                    Return
                End If
                If Not System.DateTime.TryParse(Me.txtFECHA_ORDEN.Text, _
                       New System.Globalization.CultureInfo("fr-FR", True), System.Globalization.DateTimeStyles.NoCurrentDateDefault, fechaOrden) Then
                    AsignarMensaje("* Fecha de orden invalida", True)
                    Me.txtFECHA_ORDEN.Focus()
                    Return
                End If

                If fechaOrden < cFechaHora.ObtenerFecha Then
                    AsignarMensaje("* Fecha de orden no puede ser menor a la fecha del sistema", True)
                    Me.txtFECHA_ORDEN.Focus()
                    Return
                End If

                lRet = GenerarOrdenRoza()
                If lRet = 0 Then
                    AsignarMensaje("* Seleccione lotes programados", True)
                    Return
                End If
                If lRet = -1 Then
                    AsignarMensaje("* No se logro generar la orden", True)
                    Return
                End If
                Me.txtFECHA_ORDEN.Text = ""
                Me.txtTONEL_DIARIA.Text = ""

                'Mostrar reporte
                ScriptManager.RegisterClientScriptBlock(Me, Page.GetType, "script", "MostrarReporte(1," + lRet.ToString + ")", True)
        End Select
    End Sub

    '  0: No hay lotes seleccionados
    ' -1: Error al crear encabezado de la orden
    Private Function GenerarOrdenRoza() As Integer
        Dim lLote As LOTES
        Dim lProveedorLote As New Dictionary(Of String, List(Of String))

        Dim bOrdenEnca As New cORDEN_ROZA_ENCA
        Dim bOrdenDeta As New cORDEN_ROZA_DETA
        Dim bPlanEntrega As New cPLAN_ENTREGA_CANA
        Dim lOrdenEnca As New ORDEN_ROZA_ENCA
        Dim lOrdenDeta As ORDEN_ROZA_DETA
        Dim lotesAfectados As Integer = 0
        Dim count As Integer = 0
        Dim fechaOrden As Date
        Dim lRet As Integer = 0
        Dim lIdGeneracion As Integer = 0

        SetData()
        grdLotes.AllowPaging = False
        CargarLotesPorCriterios()
        Dim arr As ArrayList = DirectCast(ViewState("SelectedRecords"), ArrayList)
        count = arr.Count

        For i As Integer = 0 To grdLotes.Rows.Count - 1
            If arr.Contains(grdLotes.DataKeys(i).Value) Then
                lLote = (New cLOTES).ObtenerLOTES(grdLotes.DataKeys(i).Value.ToString)
                If lLote IsNot Nothing Then
                    If lProveedorLote.ContainsKey(lLote.CODIPROVEEDOR) Then
                        lProveedorLote(lLote.CODIPROVEEDOR).Add(lLote.ACCESLOTE)
                    Else
                        Dim l As New List(Of String)
                        l.Add(lLote.ACCESLOTE)
                        lProveedorLote.Add(lLote.CODIPROVEEDOR, l)
                    End If
                End If
            End If
        Next

        lIdGeneracion = bOrdenEnca.ObtenerProximoID_GENERACION
        For Each registro As KeyValuePair(Of String, List(Of String)) In lProveedorLote
            'Crear encabezado de la orden
            lOrdenEnca = New ORDEN_ROZA_ENCA
            lOrdenEnca.ID_ORDEN = 0
            lOrdenEnca.ID_PLAN_SEMANAL = Me.ID_PLAN_SEMANAL
            lOrdenEnca.ID_GENERACION = lIdGeneracion
            System.DateTime.TryParse(Me.txtFECHA_ORDEN.Text, _
                    New System.Globalization.CultureInfo("fr-FR", True), System.Globalization.DateTimeStyles.NoCurrentDateDefault, fechaOrden)
            lOrdenEnca.FECHA_ORDEN = fechaOrden
            lOrdenEnca.TONEL_DIARIA = Convert.ToDecimal(Me.txtTONEL_DIARIA.Text)
            lOrdenEnca.USUARIO_CREA = Me.ObtenerUsuario
            lOrdenEnca.FECHA_CREA = cFechaHora.ObtenerFechaHora
            lOrdenEnca.USUARIO_ACT = Me.ObtenerUsuario
            lOrdenEnca.FECHA_ACT = cFechaHora.ObtenerFechaHora
            lOrdenEnca.CORRELATIVO = bOrdenEnca.ObtenerProximoCORRELATIVO
            lRet = bOrdenEnca.ActualizarORDEN_ROZA_ENCA(lOrdenEnca)
            If lRet <= 0 Then
                Return -1
            End If

            For i As Integer = 0 To registro.Value.Count - 1
                Dim lPlanEntrega As PLAN_ENTREGA_CANA
                lPlanEntrega = bPlanEntrega.ObtenerPorPLAN_SEMANAL_ACCESLOTE(Me.ID_PLAN_SEMANAL, registro.Value(i))
                'Crear detalle de la orden
                lOrdenDeta = New ORDEN_ROZA_DETA
                lOrdenDeta.ID_ORDEN_DETA = 0
                lOrdenDeta.ID_ORDEN = lOrdenEnca.ID_ORDEN
                ' N O T A   I M P O R T A N T E
                'Aunque para generar una orden de roza se parte de requiere que un lote este programado
                'Se va a romper la relación entre programación y orden de roza, es decir la orden de roza ya generada no se podrá volver a
                '   recuperar y si se elimina la programación quedará la orden de roza

                'If lPlanEntrega IsNot Nothing Then
                '    lOrdenDeta.ID_PLAN_ENTREGA_CANA = lPlanEntrega.ID_PLAN_ENTREGA_CANA
                'Else
                '    lOrdenDeta.ID_PLAN_ENTREGA_CANA = -1
                'End If
                lOrdenDeta.ID_PLAN_ENTREGA_CANA = -1
                lOrdenDeta.ACCESLOTE = registro.Value(i)
                lOrdenDeta.USUARIO_CREA = Me.ObtenerUsuario
                lOrdenDeta.FECHA_CREA = cFechaHora.ObtenerFechaHora
                lOrdenDeta.USUARIO_ACT = Me.ObtenerUsuario
                lOrdenDeta.FECHA_ACT = cFechaHora.ObtenerFechaHora
                bOrdenDeta.ActualizarORDEN_ROZA_DETA(lOrdenDeta)

                arr.Remove(grdLotes.DataKeys(i).Value)
                lotesAfectados += 1
            Next
        Next

        ViewState("SelectedRecords") = arr
        hfCount.Value = "0"
        grdLotes.AllowPaging = True
        CargarLotesPorCriterios()
        Return lIdGeneracion
    End Function

    Private Sub ObtenerProveedor()
        Dim lProveedor As PROVEEDOR
        Dim Codiprovee As String = Utilerias.RellenarIzquierda(Me.txtCODIPROVEE.Text, 6)
        Dim Codisocio As String = Utilerias.RellenarIzquierda(Me.txtCODSOCIO.Text, 4)

        lProveedor = (New cPROVEEDOR).ObtenerPROVEEDOR(Codiprovee + Codisocio)
        If lProveedor IsNot Nothing Then
            Me.txtNOMBRE_PROVEEDOR.Text = lProveedor.NOMBRES.Trim + " " + lProveedor.APELLIDOS.Trim
        Else
            Me.txtNOMBRE_PROVEEDOR.Text = ""
        End If
    End Sub

    Protected Sub txtCODIPROVEE_TextChanged(sender As Object, e As System.EventArgs) Handles txtCODIPROVEE.TextChanged
        ObtenerProveedor()
    End Sub

    Protected Sub txtCODSOCIO_TextChanged(sender As Object, e As System.EventArgs) Handles txtCODSOCIO.TextChanged
        ObtenerProveedor()
    End Sub

    Protected Sub grdLotes_PageIndexChanging(sender As Object, e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles grdLotes.PageIndexChanging
        Me.grdLotes.PageIndex = e.NewPageIndex
        Me.CargarLotesPorCriterios()
        Me.SetData()
    End Sub

    Protected Sub grdLotes_RowDataBound(sender As Object, e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles grdLotes.RowDataBound
        ' N O T A   I M P O R T A N T E
        'Aunque para generar una orden de roza se parte de requiere que un lote este programado
        'Se va a romper la relación entre programación y orden de roza, es decir la orden de roza ya generada no se podrá volver a
        '   recuperar y si se elimina la programación quedará la orden de roza

        'If e.Row.RowType = DataControlRowType.DataRow Then
        '    Dim lLote As DataRowView = CType(e.Row.DataItem, DataRowView)
        '    'Orden de Roza
        '    Dim lnkOrdenRoza As LinkButton = CType(e.Row.FindControl("lnkOrdenRoza"), LinkButton)
        '    If lnkOrdenRoza IsNot Nothing Then
        '        If lLote("ID_PLAN_ENTREGA_CANA").ToString = String.Empty Then
        '            lnkOrdenRoza.Visible = False
        '        Else
        '            lnkOrdenRoza.Attributes.Add("onclick", "MostrarReporte(2," + lLote("ID_PLAN_ENTREGA_CANA").ToString + ")")
        '            lnkOrdenRoza.Visible = True
        '        End If
        '    End If
        'End If
    End Sub
End Class
