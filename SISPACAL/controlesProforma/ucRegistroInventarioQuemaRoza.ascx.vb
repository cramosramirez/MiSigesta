Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores

Partial Class controlesProforma_ucRegistroInventarioQuemaRoza
    Inherits ucBase



#Region "Inicializaciones Mantenimiento"
    Private Sub CargarCatorcenas()
        Dim lista As List(Of Int32) = (New cCICLO_PERIODO).ObtenerCatorcenasPorZAFRA_TIPO_CICLO(Me.cbxZAFRA.Value, 2)
        If lista Is Nothing Then lista = New List(Of Int32)
        Me.cbxCATORCENA.DataSource = lista
        Me.cbxCATORCENA.DataBind()
    End Sub

    Private Sub CargarSemanas()
        Dim listaCad As New List(Of String)
        Dim _Catorcena As Int32 = -1
        If Me.cbxCATORCENA.Text <> "" Then _Catorcena = CInt(Me.cbxCATORCENA.Text)
        Dim lista As List(Of Int32) = (New cCICLO_PERIODO).ObtenerSemanasPorZAFRA_TIPO_CICLO_CATORCENA(Me.cbxZAFRA.Value, 2, _Catorcena)
        If lista Is Nothing Then lista = New List(Of Int32)

        listaCad.Add("[Todas]")
        For Each s As Int32 In lista
            listaCad.Add(s.ToString)
        Next
        Me.cbxSEMANA.DataSource = listaCad
        Me.cbxSEMANA.DataBind()
        If cbxSEMANA.Items.Count > 0 Then cbxSEMANA.SelectedItem = cbxSEMANA.Items.FindByValue("[Todas]")
    End Sub

#End Region


    Public Property TIPO_INGRESO As TipoIngresoQuemaRoza
        Get
            If Me.ViewState("TIPO_INGRESO") Is Nothing Then
                Return -1
            Else
                Return CInt(Me.ViewState("TIPO_INGRESO"))
            End If
        End Get
        Set(value As TipoIngresoQuemaRoza)
            Me.ViewState("TIPO_INGRESO") = value
        End Set
    End Property

    Public Property ID_ZAFRA_ACTUAL As Int32
        Get
            If Me.ViewState("ID_ZAFRA") Is Nothing Then
                Return -1
            Else
                Return CInt(Me.ViewState("ID_ZAFRA"))
            End If
        End Get
        Set(value As Int32)
            Me.ViewState("ID_ZAFRA") = value
        End Set
    End Property

    Public Sub InicializarLista()
        Me.AsignarMensaje("", True, False)
        Select Case TIPO_INGRESO
            Case TipoIngresoQuemaRoza.Ejecutada
                Me.lblTitulo.Text = "Registro de Inventario de Quema y Roza (EJECUTADA)"
            Case TipoIngresoQuemaRoza.Proyectada
                Me.lblTitulo.Text = "Registro de Inventario de Quema y Roza (PROYECTADA)"
        End Select

        Me.ucBarraNavegacion1.VerOpcion("Buscar", True)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", False)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", False)
        Me.ucBarraNavegacion1.VerOpcion("ModificarQuema", False)
        Me.ucBarraNavegacion1.VerOpcion("LiquidarSaldo", False)
        'Me.ucBarraNavegacion1.VerOpcion("LiquidarSaldoNegativo", False)
        Me.ucBarraNavegacion1.VerOpcion("LiquidarProyeccion", False)
        Me.ucCriteriosRegistroInventarioQuemaRoza.Visible = True
        Me.ucListaLOTES_COSECHA1.Visible = True
        Me.ucVistaDetalleCONTROL_ROZA1.Visible = False
        Me.ucVistaDetalleCONTROL_QUEMA1.Visible = False
    End Sub

    Private Sub InicializarDetalleRoza()
        Select Case TIPO_INGRESO
            Case TipoIngresoQuemaRoza.Ejecutada
                Me.lblTitulo.Text = "Control de Roza (EJECUTADA)"
            Case TipoIngresoQuemaRoza.Proyectada
                Me.lblTitulo.Text = "Control de Roza (PROYECTADA)"
        End Select
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.VerOpcion("Buscar", False)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", True)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", True)
        Me.ucBarraNavegacion1.VerOpcion("ModificarQuema", (TIPO_INGRESO = TipoIngresoQuemaRoza.Proyectada))
        Me.ucBarraNavegacion1.VerOpcion("LiquidarSaldo", (TIPO_INGRESO = TipoIngresoQuemaRoza.Ejecutada))
        'Me.ucBarraNavegacion1.VerOpcion("LiquidarSaldoNegativo", True)
        Me.ucBarraNavegacion1.VerOpcion("LiquidarProyeccion", (TIPO_INGRESO = TipoIngresoQuemaRoza.Proyectada))
        Me.ucCriteriosRegistroInventarioQuemaRoza.Visible = False
        Me.ucListaLOTES_COSECHA1.Visible = False
        Me.ucVistaDetalleCONTROL_QUEMA1.Visible = False
        Me.ucVistaDetalleCONTROL_ROZA1.Visible = True
    End Sub

    Private Sub InicializarDetalleQuema()
        Select Case TIPO_INGRESO
            Case TipoIngresoQuemaRoza.Ejecutada
                Me.lblTitulo.Text = "Control de Quema (EJECUTADA)"
            Case TipoIngresoQuemaRoza.Proyectada
                Me.lblTitulo.Text = "Control de Quema (PROYECTADA)"
        End Select
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.VerOpcion("Buscar", False)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", True)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", True)
        Me.ucBarraNavegacion1.VerOpcion("ModificarQuema", False)
        Me.ucBarraNavegacion1.VerOpcion("LiquidarSaldo", (TIPO_INGRESO = TipoIngresoQuemaRoza.Ejecutada))
        'Me.ucBarraNavegacion1.VerOpcion("LiquidarSaldoNegativo", True)
        Me.ucBarraNavegacion1.VerOpcion("LiquidarProyeccion", (TIPO_INGRESO = TipoIngresoQuemaRoza.Proyectada))
        Me.ucCriteriosRegistroInventarioQuemaRoza.Visible = False
        Me.ucListaLOTES_COSECHA1.Visible = False
        Me.ucVistaDetalleCONTROL_QUEMA1.Visible = True
        Me.ucVistaDetalleCONTROL_ROZA1.Visible = False
    End Sub

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Me.Inicializar()
            Me.InicializarLista()
        End If
    End Sub

    Private Sub Inicializar()
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        Dim lNoCatorcena As Int32 = -1
        Dim codiAgron As String = cProceso.ObtenerCODIAGRON(Me.ObtenerUsuario)

        Me.ucBarraNavegacion1.PermitirNavegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucBarraNavegacion1.CrearOpcion("Buscar", "Buscar", False, IconoBarra.Buscar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Cancelar", "Regresar", False, IconoBarra.Cancelar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Guardar", "Guardar", True, IconoBarra.Guardar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("ModificarQuema", "Modificar Fecha/Hora de Quema en Proyección", False, "~/imagenes/fire.png", "", "", False)
        Me.ucBarraNavegacion1.CrearOpcion("LiquidarSaldo", "Liquidar Saldo Ejecutado", False, IconoBarra.Anular, "", "", True)
        'Me.ucBarraNavegacion1.CrearOpcion("LiquidarSaldoNegativo", "Liquidar Saldo negativo", False, IconoBarra.Anular, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("LiquidarProyeccion", "Liquidar Saldo Proyectado", False, IconoBarra.Anular, "", "", True)


        Me.ucBarraNavegacion1.CargarOpciones()

        Me.cbxCATORCENA.ClientEnabled = False

        If lZafra IsNot Nothing Then
            Me.cbxZAFRA.Value = lZafra.ID_ZAFRA
        End If
        Me.CargarCatorcenas()
        Me.CargarSemanas()
        If Me.cbxCATORCENA.Value IsNot Nothing Then lNoCatorcena = Me.cbxCATORCENA.Value
        Me.ucListaLOTES_COSECHA1.CargarDatosParaIngresoInventario(lZafra.ID_ZAFRA, "", "", "", "~")
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        Select Case CommandName
            Case "Buscar"
                Dim ID_ZAFRA As Int32 = -1
                Dim FECHA_INI As Object = Nothing
                Dim FECHA_FIN As Object = Nothing
                Dim CODIPROVEE As String = ""
                Dim CODISOCIO As String = ""
                Dim NO_CONTRATO As Int32 = -1
                Dim SEMANA As Int32 = -1
                Dim CATORCENA As Int32 = -1

                If Me.cbxZAFRA.Value IsNot Nothing Then ID_ZAFRA = cbxZAFRA.Value
                If Me.speCODIPROVEE.Text <> "" Then CODIPROVEE = Utilerias.FormatoCODIPROVEE(CInt(Me.speCODIPROVEE.Text))
                If Me.speCODISOCIO.Text <> "" Then CODISOCIO = Utilerias.FormatoCODISOCIO(CInt(Me.speCODISOCIO.Text))
                If Me.cbxSEMANA.Value IsNot Nothing AndAlso IsNumeric(Me.cbxSEMANA.Value) Then
                    SEMANA = CInt(Me.cbxSEMANA.Value)
                End If
                If cbxCATORCENA.Value IsNot Nothing Then
                    CATORCENA = CInt(cbxCATORCENA.Value)
                End If
                Me.ucListaLOTES_COSECHA1.QuitarSeleccion()
                Me.ucListaLOTES_COSECHA1.CargarDatosParaIngresoInventario(ID_ZAFRA, Me.cbxZONA.Value, CODIPROVEE, CODISOCIO, Me.txtNOMBRE_PROVEEDOR.Text)

            Case "Guardar"
                Dim sError As String = ""
                If ucVistaDetalleCONTROL_ROZA1.Visible Then
                    sError = Me.ucVistaDetalleCONTROL_ROZA1.Actualizar()
                ElseIf ucVistaDetalleCONTROL_QUEMA1.Visible Then
                    sError = Me.ucVistaDetalleCONTROL_QUEMA1.Actualizar()
                End If
                If sError <> "" Then
                    AsignarMensaje(sError, True, False)
                    Return
                Else
                    Me.ucListaLOTES_COSECHA1.DataBind()
                End If
                AsignarMensaje("", True, False)

            Case "ModificarQuema"
                If Me.ucVistaDetalleCONTROL_ROZA1.Visible Then
                    Dim lControlRoza As CONTROL_ROZA_SALDO = Me.ucVistaDetalleCONTROL_ROZA1.ControlRozaSaldoSelecionado
                    If lControlRoza Is Nothing Then
                        Me.AsignarMensaje("Seleccione un inventario de roza proyectado", False, True, True)
                        Return
                    Else
                        If Not lControlRoza.ES_PROYECCION Then
                            Me.AsignarMensaje("Seleccione un inventario de roza proyectado", False, True, True)
                            Return
                        End If
                        txtFECHA_HORA_QUEMA_ACTUAL.Text = lControlRoza.FECHA_HORA_QUEMA.ToString("dd/MM/yyyy HH:mm")
                        dteFECHA_HORA_QUEMA_NUEVA.Value = Nothing
                        lblpcMensajeModiQuema.Text = ""
                        pcModificarQuema.ShowOnPageLoad = True
                    End If
                End If

            Case "LiquidarSaldo"
                Me.rblTipoLiquidacion.Value = Nothing
                Me.speCantidadLiquidarTC.ClientEnabled = False
                Me.chkLIQUIDAR_PROYECCION.Checked = False
                If Me.ucVistaDetalleCONTROL_QUEMA1.Visible Then
                    Me.lblpcMensaje.Text = "¿Esta seguro(a) de Liquidar a cero el Saldo Ejecutado de Quema?"
                    Me.tblTipoLiquidacion.Visible = False
                ElseIf Me.ucVistaDetalleCONTROL_ROZA1.Visible Then
                    Dim lControlRoza As CONTROL_ROZA_SALDO = Me.ucVistaDetalleCONTROL_ROZA1.ControlRozaSaldoSelecionado
                    If lControlRoza Is Nothing Then
                        Me.AsignarMensaje("Seleccione un inventario de roza", False, True, True)
                        Return
                    Else
                        Me.lblpcMensaje.Text = ""
                        Me.tblTipoLiquidacion.Visible = True
                    End If
                End If
                Me.pcLiquidarSaldo.ShowOnPageLoad = True

                'Case "LiquidarSaldoNegativo"
                '    If Me.ucVistaDetalleCONTROL_QUEMA1.Visible Then

                '    ElseIf Me.ucVistaDetalleCONTROL_ROZA1.Visible Then

                '    End If
                '    Dim bControlRoza As New cCONTROL_ROZA
                '    Dim listaCtrlRoza As listaCONTROL_ROZA_SALDO
                '    Dim bControlRozaSaldo As New cCONTROL_ROZA_SALDO
                '    Dim lControlRozaSaldo As CONTROL_ROZA_SALDO
                '    Dim lDiaZafra As DIA_ZAFRA
                '    Dim lLotesCosecha As LOTES_COSECHA
                '    Dim bLotesCosecha As New cLOTES_COSECHA

                '    lLotesCosecha = bLotesCosecha.ObtenerLOTES_COSECHA(Session("ucMantPLAN_COSECHA_ID_LOTES_COSECHA"))

                '    listaCtrlRoza = bControlRozaSaldo.ObtenerListaPorCriterios(Me.ID_ZAFRA_ACTUAL, lLotesCosecha.ACCESLOTE, -1, -1, -1, "", "", -1, -1, -1, "", -1, -1, False)
                '    For Each lControlRoza As CONTROL_ROZA In listaCtrlRoza
                '        lControlRozaSaldo = bControlRozaSaldo.ObtenerCONTROL_ROZA_SALDO(lControlRoza.ID_ROZA_SALDO)
                '        If lControlRozaSaldo IsNot Nothing AndAlso lControlRozaSaldo.SALDO < 0 Then
                '            lControlRoza.ID_CONTROL_ROZA = 0
                '            lControlRoza.ID_ZAFRA = Me.cbxZAFRA.Value
                '            lControlRoza.ACCESLOTE = lLotesCosecha.ACCESLOTE
                '            lDiaZafra = (New cDIA_ZAFRA).ObtenerDiaZafraActivo(Me.cbxZAFRA.Value)
                '            If lDiaZafra IsNot Nothing Then lControlRoza.DIAZAFRA = lDiaZafra.DIAZAFRA
                '            lControlRoza.FECHA_HORA_QUEMA = lControlRozaSaldo.FECHA_HORA_QUEMA
                '            lControlRoza.FECHA_HORA_ROZA = lControlRozaSaldo.FECHA_HORA_ROZA
                '            lControlRoza.ID_PROVEEDOR_ROZA = -1
                '            lControlRoza.CONCEPTO = "MOVIMIENTO DE LIQUIDACION TOTAL DE SALDO EN FECHA " + cFechaHora.ObtenerFechaHora.ToString("dd/MM/yyyy HH:mm")
                '            lControlRoza.CODIGO_REF = "AJUSTE"
                '            lControlRoza.ID_REF = -1
                '            lControlRoza.ENTRADAS = lControlRozaSaldo.SALDO
                '            lControlRoza.SALIDAS = 0
                '            lControlRoza.SALDO = 0
                '            lControlRoza.ID_TIPO_CANA = lControlRozaSaldo.ID_TIPO_CANA
                '            lControlRoza.ID_TIPO_ROZA = lControlRozaSaldo.ID_TIPO_ROZA
                '            lControlRoza.USUARIO_CREA = Me.ObtenerUsuario
                '            lControlRoza.FECHA_CREA = cFechaHora.ObtenerFechaHora
                '            lControlRoza.USUARIO_ACT = Me.ObtenerUsuario
                '            lControlRoza.FECHA_ACT = cFechaHora.ObtenerFechaHora
                '            lControlRoza.QUEMA_PROGRAMADA = lControlRozaSaldo.QUEMA_PROGRAMADA
                '            lControlRoza.QUEMA_NOPROG = lControlRozaSaldo.QUEMA_NOPROG
                '            lControlRoza.CANA_VERDE = lControlRozaSaldo.CANA_VERDE
                '            lControlRoza.ID_ROZA_SALDO = lControlRozaSaldo.ID_ROZA_SALDO
                '            lControlRoza.ES_PROYECCION = lControlRozaSaldo.ES_PROYECCION

                '            bControlRoza.ActualizarCONTROL_ROZA(lControlRoza)

                '            lLotesCosecha.USUARIO_ACT = Me.ObtenerUsuario
                '            lLotesCosecha.FECHA_ACT = cFechaHora.ObtenerFechaHora
                '            bLotesCosecha.ActualizarLOTES_COSECHA(lLotesCosecha)
                '        End If
                '    Next
                '    AsignarMensaje("Los saldos negativos del inventario se liquidaron correctamente", False, True, True)

            Case "LiquidarProyeccion"
                Me.rblTipoLiquidacion.Value = Nothing
                Me.speCantidadLiquidarTC.ClientEnabled = False
                Me.chkLIQUIDAR_PROYECCION.Checked = False
                If Me.ucVistaDetalleCONTROL_QUEMA1.Visible Then
                    Me.lblpcMensaje.Text = "¿Esta seguro(a) de Liquidar a cero las Proyecciones de Quema?"
                    Me.tblTipoLiquidacion.Visible = False
                ElseIf Me.ucVistaDetalleCONTROL_ROZA1.Visible Then
                    Dim lControlRoza As CONTROL_ROZA_SALDO = Me.ucVistaDetalleCONTROL_ROZA1.ControlRozaSaldoSelecionado
                    If lControlRoza Is Nothing Then
                        Me.AsignarMensaje("Seleccione un control de roza proyectado", False, True, True)
                        Return
                    Else
                        If Not lControlRoza.ES_PROYECCION Then
                            Me.AsignarMensaje("Seleccione un inventario de roza proyectado", False, True, True)
                            Return
                        End If
                        Me.lblpcMensaje.Text = ""
                        Me.tblTipoLiquidacion.Visible = True
                    End If
                End If
                Me.pcLiquidarSaldo.ShowOnPageLoad = True

            Case "Cancelar"
                Me.InicializarLista()
                Me.ucListaLOTES_COSECHA1.DataBind()
        End Select
    End Sub

    Protected Sub cbxCATORCENA_DataBound(sender As Object, e As System.EventArgs) Handles cbxCATORCENA.DataBound
        Dim lCatorcena As CATORCENA_ZAFRA = (New cCATORCENA_ZAFRA).ObtenerUltimaCatorcenaCerradaZafra(Me.cbxZAFRA.Value)

        If lCatorcena IsNot Nothing Then
            Me.cbxCATORCENA.SelectedItem = Me.cbxCATORCENA.Items.FindByText(CStr(lCatorcena.CATORCENA + 1))
        Else
            Me.cbxCATORCENA.SelectedIndex = 0
        End If
    End Sub

    Protected Sub cbxCATORCENA_ValueChanged(sender As Object, e As System.EventArgs) Handles cbxCATORCENA.ValueChanged
        Me.CargarSemanas()
    End Sub

    Protected Sub cbxZAFRA_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles cbxZAFRA.SelectedIndexChanged
        Me.CargarCatorcenas()
    End Sub

    Protected Sub ucListaLOTES_COSECHA1_Quemando(ID_LOTES_COSECHA As Integer) Handles ucListaLOTES_COSECHA1.Quemando
        Dim lLotesCosecha As LOTES_COSECHA

        lLotesCosecha = (New cLOTES_COSECHA).ObtenerLOTES_COSECHA(ID_LOTES_COSECHA)
        If lLotesCosecha IsNot Nothing Then
            Session("ucMantPLAN_COSECHA_ID_LOTES_COSECHA") = lLotesCosecha.ID_LOTES_COSECHA
            Me.InicializarDetalleQuema()
            Me.ucVistaDetalleCONTROL_QUEMA1.TIPO_INGRESO = TIPO_INGRESO
            Me.ucVistaDetalleCONTROL_QUEMA1.ID_LOTES_COSECHA = lLotesCosecha.ID_LOTES_COSECHA
            Return
        End If

        Me.AsignarMensaje("No se logro acceder al control de quema", False, True)
    End Sub

    Protected Sub ucListaLOTES_COSECHA1_Rozando(ID_LOTES_COSECHA As Integer) Handles ucListaLOTES_COSECHA1.Rozando
        Dim lLotesCosecha As LOTES_COSECHA

        lLotesCosecha = (New cLOTES_COSECHA).ObtenerLOTES_COSECHA(ID_LOTES_COSECHA)
        If lLotesCosecha IsNot Nothing Then
            Session("ucMantPLAN_COSECHA_ID_LOTES_COSECHA") = lLotesCosecha.ID_LOTES_COSECHA
            Me.InicializarDetalleRoza()
            Me.ucVistaDetalleCONTROL_ROZA1.TIPO_INGRESO = TIPO_INGRESO
            Me.ucVistaDetalleCONTROL_ROZA1.ID_LOTES_COSECHA = lLotesCosecha.ID_LOTES_COSECHA
            Return
        End If

        Me.AsignarMensaje("No se logro acceder al control de roza", False, True)
    End Sub

    Protected Sub btnLiquidar_Click(sender As Object, e As System.EventArgs) Handles btnLiquidar.Click
        Dim sError As String = ""
        If Me.ucVistaDetalleCONTROL_QUEMA1.Visible Then
            sError = Me.ucVistaDetalleCONTROL_QUEMA1.LiquidarSaldoQuema((TIPO_INGRESO = TipoIngresoQuemaRoza.Proyectada))
        ElseIf Me.ucVistaDetalleCONTROL_ROZA1.Visible Then
            Dim lControlRozaSaldo As CONTROL_ROZA_SALDO = Me.ucVistaDetalleCONTROL_ROZA1.ControlRozaSaldoSelecionado
            If lControlRozaSaldo Is Nothing Then
                AsignarMensaje("Seleccione el inventario de Roza", False, True, True)
                Return
            End If
            If Me.rblTipoLiquidacion.Value Is Nothing Then
                AsignarMensaje("Seleccione el tipo de liquidacion", False, True, True)
                Return
            End If
            If Me.rblTipoLiquidacion.Value = 1 Then
                sError = Me.ucVistaDetalleCONTROL_ROZA1.LiquidarSaldoRoza(lControlRozaSaldo.ID_ROZA_SALDO, -1)
            Else
                sError = Me.ucVistaDetalleCONTROL_ROZA1.LiquidarSaldoRoza(lControlRozaSaldo.ID_ROZA_SALDO, CInt(Me.speCantidadLiquidarTC.Value))
            End If
            If sError <> "" Then
                AsignarMensaje(sError, False, True, True)
                Return
            End If
        End If
        Me.pcLiquidarSaldo.ShowOnPageLoad = False
        If sError <> "" Then
            AsignarMensaje(sError, True, False)
            Return
        Else
            Me.ucListaLOTES_COSECHA1.DataBind()
        End If
        AsignarMensaje("", True, False)
    End Sub

    Protected Sub btnAceptarModiQuema_Click(sender As Object, e As EventArgs) Handles btnAceptarModiQuema.Click
        Dim lControlSaldo As CONTROL_ROZA_SALDO = Me.ucVistaDetalleCONTROL_ROZA1.ControlRozaSaldoSelecionado
        Dim bControlRozaSaldo As New cCONTROL_ROZA_SALDO
        Dim bControlRoza As New cCONTROL_ROZA
        Dim bProforma As New cPROFORMA
        Dim bEnvio As New cENVIO

        If Me.dteFECHA_HORA_QUEMA_NUEVA.Value Is Nothing Then
            Me.lblpcMensajeModiQuema.Text = "Ingrese la nueva fecha/hora de quema"
            Return
        End If

        If lControlSaldo IsNot Nothing Then
            'Verificar que la fecha/hora de roza del control de roza saldo no sea menor que la nueva fecha/hora de quema
            If lControlSaldo.FECHA_HORA_ROZA < Me.dteFECHA_HORA_QUEMA_NUEVA.Date Then
                Me.lblpcMensajeModiQuema.Text = "La fecha de roza del control de roza es menor a la nueva fecha de quema"
                Return
            End If

            'Verificar que la fecha/hora de roza de los proformas emitidos no sea menor que la nueva fecha/hora de quema
            Dim lstMovtoRoza As listaCONTROL_ROZA = bControlRoza.ObtenerListaPorCONTROL_ROZA_SALDO(lControlSaldo.ID_ROZA_SALDO)
            Dim s As New StringBuilder

            For Each lEntidad As CONTROL_ROZA In lstMovtoRoza
                If lEntidad.CODIGO_REF = "PROFORMA" Then
                    Dim lProforma As PROFORMA = (New cPROFORMA).ObtenerPROFORMA(lEntidad.ID_REF)
                    If lProforma IsNot Nothing Then
                        If lProforma.ESTADO <> EstadoProforma.Tara AndAlso lProforma.FECHA_QUEMA <> #12:00:00 AM# AndAlso lProforma.FECHA_ROZA < Me.dteFECHA_HORA_QUEMA_NUEVA.Date Then
                            s.Append(lProforma.NOPROFORMA.ToString)
                            s.Append(",")
                        End If
                    End If
                End If
            Next

            If s.ToString <> "" Then
                Me.lblpcMensajeModiQuema.Text = "Lo siguientes proformas tiene una fecha de roza menor a la nueva fecha de quema: " + s.ToString
                Return
            End If

            lControlSaldo.FECHA_HORA_QUEMA = Me.dteFECHA_HORA_QUEMA_NUEVA.Date
            bControlRozaSaldo.ActualizarCONTROL_ROZA_SALDO(lControlSaldo)

            For Each lEntidad As CONTROL_ROZA In lstMovtoRoza
                If lEntidad.CODIGO_REF = "PROFORMA" Then
                    Dim lProforma As PROFORMA = (New cPROFORMA).ObtenerPROFORMA(lEntidad.ID_REF)
                    If lProforma IsNot Nothing Then
                        If lProforma.ESTADO <> EstadoProforma.Tara AndAlso lProforma.FECHA_QUEMA <> #12:00:00 AM# AndAlso lProforma.FECHA_ROZA >= Me.dteFECHA_HORA_QUEMA_NUEVA.Date Then
                            lProforma.FECHA_QUEMA = Me.dteFECHA_HORA_QUEMA_NUEVA.Date
                            bProforma.ActualizarPROFORMA(lProforma)

                            lEntidad.FECHA_HORA_QUEMA = Me.dteFECHA_HORA_QUEMA_NUEVA.Date
                            bControlRoza.ActualizarCONTROL_ROZA(lEntidad)

                            Dim lEnvio As ENVIO = bEnvio.ObtenerENVIO(lProforma.ID_ENVIO)
                            If lEnvio IsNot Nothing AndAlso lEnvio.FECHA_QUEMA <> #12:00:00 AM# Then
                                'Validar que no tiene peso tara
                                Dim lstBascula As listaBASCULA = (New cBASCULA).ObtenerListaPorENVIO(lEnvio.ID_ENVIO)
                                Dim conPesoTara As Boolean = (lstBascula IsNot Nothing AndAlso lstBascula.Count > 0 AndAlso lstBascula(0).NETOLIBRAS > 0)

                                If Not conPesoTara Then
                                    lEnvio.FECHA_QUEMA = Me.dteFECHA_HORA_QUEMA_NUEVA.Date
                                    lEnvio.HORAS_QUEMA = 0
                                    bEnvio.ActualizarENVIO(lEnvio)
                                End If
                            End If
                        End If
                    End If
                End If
            Next
        End If

        Me.pcModificarQuema.ShowOnPageLoad = False
    End Sub
End Class
