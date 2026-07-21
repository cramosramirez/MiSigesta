Imports System.Data
Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.DL
Imports System.Collections.Generic

Partial Class controles_ucPlanEntregaCanaPorLote
    Inherits ucBase

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

        Me.lblTitulo.Text = "Programación de Entrega de Caña"
        Me.ucBarraNavegacion1.PermitirNavegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucBarraNavegacion1.CrearOpcion("Buscar", "Buscar", False, "../Imagenes/buscar.png", "", "")
        Me.ucBarraNavegacion1.CrearOpcion("Programar", "Programar", False, "../Imagenes/Calendar.png", "", "")
        Me.ucBarraNavegacion1.CrearOpcion("Eliminar", "Eliminar", False, "../Imagenes/eliminarProgramacion.png", "", "")
        Me.ucBarraNavegacion1.VerOpcion("Programar", True)
        Me.ucBarraNavegacion1.VerOpcion("Eliminar", True)
        Me.ucBarraNavegacion1.CargarOpciones()
        Me.DdlZONAS1.Recuperar()
        Me.DdlPLAN_SEMANAL1.Recuperar()
    End Sub

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Me.Inicializar()
        End If
    End Sub

    Public Sub CargarLotesPorCriterios()
        Dim ds As DataSet
        Dim bLotes As New cLOTES
        ds = bLotes.ObtenerDataSetPorCriterios1(Me.NOMBRE_ZAFRA, Me.DdlZONAS1.SelectedValue, Me.DdlPLAN_SEMANAL1.SelectedValue, _
                                               Me.txtCODIPROVEE.Text, Me.txtCODSOCIO.Text, Me.txtNOMBRE_PROVEEDOR.Text, _
                                               Me.chkINCLUIR_LOTES_NO_PROGRAMADOS.Checked)
        If ds Is Nothing Then
            Me.grdLotes.Visible = False
        End If
        Me.grdLotes.SelectedIndex = -1
        Me.grdLotes.Visible = True
        Me.grdLotes.DataSource = ds
        Me.grdLotes.DataBind()
        If bLotes.sError <> "" Then
            AsignarMensaje("* Error en consulta: " + bLotes.sError, True, False)
        End If
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        Dim accesLote As String

        AsignarMensaje("", True, False)

        Select Case CommandName
            Case "Buscar"
                txtMANZANAS_PROGRAMADAS.Text = ""
                txtTONELADAS_PROGRAMADAS.Text = ""
                If Me.DdlZONAS1.SelectedValue IsNot Nothing Then
                    Me.ID_PLAN_SEMANAL = DdlPLAN_SEMANAL1.SelectedValue
                    CargarLotesPorCriterios()
                End If
                If Me.grdLotes.Rows.Count = 0 AndAlso (txtCODIPROVEE.Text <> "" OrElse txtCODSOCIO.Text <> "") Then
                    MostrarMensaje("Proveedor no posee Lotes en la Zona: " + Me.DdlZONAS1.SelectedItem.Text, "Alerta")
                End If
                If Me.grdLotes.Rows.Count = 0 AndAlso txtCODIPROVEE.Text = "" AndAlso txtCODSOCIO.Text = "" Then
                    MostrarMensaje("No existen Lotes con los criterios seleccionados", "Alerta")
                End If

            Case "Programar"
                Dim lista As New List(Of String)
                Dim lProgramacionLote As New PLAN_ENTREGA_CANA
                Dim lProgramacionLotes As New listaPLAN_ENTREGA_CANA
                Dim bPlanEntrega As New cPLAN_ENTREGA_CANA
                Dim existeSeleccion As Boolean = False
                Dim lLote As LOTES

                If grdLotes.SelectedValue Is Nothing Then
                    AsignarMensaje("* Seleccione un Lote", True)
                    Return
                End If
                accesLote = grdLotes.SelectedDataKey.Value
                If Not IsNumeric(Me.txtMANZANAS_PROGRAMADAS.Text) Then
                    AsignarMensaje("* Manzanas programadas debe ser un numero", True)
                    txtMANZANAS_PROGRAMADAS.Focus()
                    Return
                End If
                If Not IsNumeric(Me.txtTONELADAS_PROGRAMADAS.Text) Then
                    AsignarMensaje("* Toneladas programadas debe ser un numero", True)
                    txtTONELADAS_PROGRAMADAS.Focus()
                    Return
                End If
                If Convert.ToDecimal(Me.txtMANZANAS_PROGRAMADAS.Text) <= 0 Then
                    AsignarMensaje("* Manzanas programadas debe ser mayor que cero", True)
                    txtMANZANAS_PROGRAMADAS.Focus()
                    Return
                End If
                If Convert.ToDecimal(Me.txtTONELADAS_PROGRAMADAS.Text) <= 0 Then
                    AsignarMensaje("* Toneladas programadas debe ser mayor que cero", True)
                    txtTONELADAS_PROGRAMADAS.Focus()
                    Return
                End If

                'Validar que no se programen más manzanas y toneladas de las contratadas
                lLote = (New cLOTES).ObtenerLOTES(accesLote)
                If lLote IsNot Nothing Then
                    Dim lProgramadoManzanaTone As Dictionary(Of String, Decimal) = bPlanEntrega.ObtenerManzanasToneladasProgramadas(Me.NOMBRE_ZAFRA, accesLote, Me.ID_PLAN_SEMANAL)
                    'If lProgramadoManzanaTone IsNot Nothing AndAlso lProgramadoManzanaTone.Count > 0 Then
                    '    If lProgramadoManzanaTone("MANZANAS") + Convert.ToDecimal(Me.txtMANZANAS_PROGRAMADAS.Text) > lLote.AREA Then
                    '        AsignarMensaje("* Manzanas programadas de otra(s) semana(s): " + lProgramadoManzanaTone("MANZANAS").ToString("#,##0.00") + _
                    '                       " mas la programacion de semana seleccionada: " + Convert.ToDecimal(Me.txtMANZANAS_PROGRAMADAS.Text).ToString("#,##0.00") + " sobrepasan lo contratado " + lLote.AREA.ToString("#,##0.00"), True)
                    '        txtMANZANAS_PROGRAMADAS.Focus()
                    '        Return
                    '    End If
                    'End If
                    If lProgramadoManzanaTone IsNot Nothing AndAlso lProgramadoManzanaTone.Count > 0 Then
                        If lProgramadoManzanaTone("TONELADAS") + Convert.ToDecimal(Me.txtTONELADAS_PROGRAMADAS.Text) > lLote.TONEL_TC Then
                            AsignarMensaje("* Toneladas programadas de otra(s) semana(s): " + lProgramadoManzanaTone("TONELADAS").ToString("#,##0.00") + _
                                           " mas la programacion de semana seleccionada: " + Convert.ToDecimal(Me.txtTONELADAS_PROGRAMADAS.Text).ToString("#,##0.00") + " sobrepasan lo contratado " + lLote.TONELADAS.ToString("#,##0.00"), True)
                            txtTONELADAS_PROGRAMADAS.Focus()
                            Return
                        End If
                    End If
                End If

                lProgramacionLote = bPlanEntrega.ObtenerPorPLAN_SEMANAL_ACCESLOTE(Me.ID_PLAN_SEMANAL, accesLote)
                If lProgramacionLote IsNot Nothing AndAlso lProgramacionLote.ID_PLAN_ENTREGA_CANA > 0 Then
                    lProgramacionLote.AREA_PROGRAMADA = Convert.ToDecimal(Me.txtMANZANAS_PROGRAMADAS.Text)
                    lProgramacionLote.TONEL_PROGRAMADA = Convert.ToDecimal(Me.txtTONELADAS_PROGRAMADAS.Text)
                    lProgramacionLote.USUARIO_ACT = Me.ObtenerUsuario
                    lProgramacionLote.FECHA_ACT = cFechaHora.ObtenerFechaHora
                Else
                    lProgramacionLote = New PLAN_ENTREGA_CANA
                    lProgramacionLote.ID_PLAN_SEMANAL = Me.ID_PLAN_SEMANAL
                    lProgramacionLote.ID_PLAN_ENTREGA_CANA = 0
                    lProgramacionLote.ACCESLOTE = accesLote
                    lProgramacionLote.AREA_PROGRAMADA = Convert.ToDecimal(Me.txtMANZANAS_PROGRAMADAS.Text)
                    lProgramacionLote.TONEL_PROGRAMADA = Convert.ToDecimal(Me.txtTONELADAS_PROGRAMADAS.Text)
                    lProgramacionLote.USUARIO_CREA = Me.ObtenerUsuario
                    lProgramacionLote.FECHA_CREA = cFechaHora.ObtenerFechaHora
                    lProgramacionLote.USUARIO_ACT = Me.ObtenerUsuario
                    lProgramacionLote.FECHA_ACT = cFechaHora.ObtenerFechaHora
                End If
                If bPlanEntrega.ActualizarPLAN_ENTREGA_CANA(lProgramacionLote) <> 1 Then
                    AsignarMensaje("* " + bPlanEntrega.sError, True)
                    Return
                End If
                Me.txtMANZANAS_PROGRAMADAS.Text = ""
                Me.txtTONELADAS_PROGRAMADAS.Text = ""
                MostrarMensaje("Programacion aplicada con exito")
                INDICE_SELECCIONADO = grdLotes.SelectedIndex
                CargarLotesPorCriterios()
                grdLotes.SelectedIndex = INDICE_SELECCIONADO
                txtMANZANAS_PROGRAMADAS.Text = ""
                txtTONELADAS_PROGRAMADAS.Text = ""

            Case "Eliminar"
                Dim bPlanEntrega As New cPLAN_ENTREGA_CANA
                Dim lProgramacionLote As PLAN_ENTREGA_CANA

                If grdLotes.SelectedDataKey Is Nothing Then
                    AsignarMensaje("* Seleccione un Lote", True)
                    Return
                End If
                accesLote = grdLotes.SelectedDataKey.Value
                lProgramacionLote = bPlanEntrega.ObtenerPorPLAN_SEMANAL_ACCESLOTE(Me.ID_PLAN_SEMANAL, accesLote)
                If lProgramacionLote Is Nothing Then
                    AsignarMensaje("* No existe programacion del Lote seleccionado para la semana seleccionada", True)
                    Return
                Else
                    bPlanEntrega.EliminarPLAN_ENTREGA_CANA(lProgramacionLote.ID_PLAN_ENTREGA_CANA)
                    MostrarMensaje("Programacion se elimino con exito")
                    INDICE_SELECCIONADO = grdLotes.SelectedIndex
                    CargarLotesPorCriterios()
                    grdLotes.SelectedIndex = INDICE_SELECCIONADO
                    RecuperarProgramacionLote()
                End If
                txtMANZANAS_PROGRAMADAS.Text = ""
                txtTONELADAS_PROGRAMADAS.Text = ""
        End Select
    End Sub

    Private Sub RecuperarProgramacionLote()
        If grdLotes.SelectedDataKey IsNot Nothing Then
            Dim lPlanEntrega As New PLAN_ENTREGA_CANA
            Dim bPlanEntrega As New cPLAN_ENTREGA_CANA
            Dim lTonelEntregadas As Decimal = 0

            'Cargar lo programado en la semana seleccionada
            lPlanEntrega = bPlanEntrega.ObtenerPorPLAN_SEMANAL_ACCESLOTE(DdlPLAN_SEMANAL1.SelectedValue, grdLotes.SelectedDataKey.Value)
            If lPlanEntrega IsNot Nothing Then
                Me.txtMANZANAS_PROGRAMADAS.Text = lPlanEntrega.AREA_PROGRAMADA.ToString("#,##0.00")
                Me.txtTONELADAS_PROGRAMADAS.Text = lPlanEntrega.TONEL_PROGRAMADA.ToString("#,##0.00")
            Else
                Me.txtMANZANAS_PROGRAMADAS.Text = ""
                Me.txtTONELADAS_PROGRAMADAS.Text = ""
            End If
        End If
        grdLotes.Focus()
    End Sub

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
    End Sub
End Class
