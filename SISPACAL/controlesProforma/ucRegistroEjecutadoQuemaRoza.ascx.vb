Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores

Partial Class controlesProforma_ucRegistroEjecutadoQuemaRoza
    Inherits ucBase


#Region "Inicializaciones Mantenimiento"
    Private Sub CargarCatorcenas()
        Dim lista As List(Of Int32) = (New cCICLO_PERIODO).ObtenerCatorcenasPorZAFRA_TIPO_CICLO(Me.cbxZAFRA.Value, 2)
        Dim listaCad As New List(Of String)

        If lista Is Nothing Then lista = New List(Of Int32)
        For i As Int32 = 0 To lista.Count - 1
            listaCad.Add(lista(i).ToString)
        Next
        listaCad.Insert(0, "")
        Me.cbxCATORCENA.DataSource = listaCad
        Me.cbxCATORCENA.DataBind()
    End Sub

    Private Sub ConfigurarTipoInventario()
        Me.CargarDatos()
    End Sub

    Private Sub Inicializar()
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        Dim lNoCatorcena As Int32 = -1

        If lZafra IsNot Nothing Then
            Me.cbxZAFRA.Value = lZafra.ID_ZAFRA
        End If
        Me.CargarCatorcenas()
        If Me.cbxCATORCENA.Value IsNot Nothing Then lNoCatorcena = Me.cbxCATORCENA.Value

        Me.ucBarraNavegacion1.LimpiarOpciones()
        Me.ucBarraNavegacion1.PermitirNavegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucBarraNavegacion1.CrearOpcion("Buscar", "Buscar", False, IconoBarra.Buscar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("LiquidarSaldo", "Liquidar Saldos", False, IconoBarra.Anular, "", "", True)
        Me.ucBarraNavegacion1.CargarOpciones()

        If Me.cbxTIPO_INVENTARIO.Value = 1 Then
            'Quema
            Me.ucListaCONTROL_QUEMA_SALDO1.Visible = True
            Me.ucListaCONTROL_ROZA_SALDO1.Visible = False
        Else
            'Roza           
            Me.ucListaCONTROL_QUEMA_SALDO1.Visible = False
            Me.ucListaCONTROL_ROZA_SALDO1.Visible = True
        End If
    End Sub
#End Region

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Me.Inicializar()
        End If
    End Sub

    Protected Sub cbxTIPO_INVENTARIO_ValueChanged(sender As Object, e As EventArgs) Handles cbxTIPO_INVENTARIO.ValueChanged
        If Me.cbxTIPO_INVENTARIO.Value = 1 Then
            'Quema
            Me.ucListaCONTROL_QUEMA_SALDO1.Visible = True
            Me.ucListaCONTROL_ROZA_SALDO1.Visible = False
        Else
            'Roza           
            Me.ucListaCONTROL_QUEMA_SALDO1.Visible = False
            Me.ucListaCONTROL_ROZA_SALDO1.Visible = True
        End If
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        Select Case CommandName
            Case "Buscar"
                Me.CargarDatos()

            Case "LiquidarSaldo"
                If Me.cbxTIPO_INVENTARIO.Value = 1 Then
                    Me.lblLiquidarSaldos.Text = "Liquidar Saldos de Quema con horas mayores a:"
                Else
                    Me.lblLiquidarSaldos.Text = "Liquidar Saldos de Roza con horas mayores a:"
                End If
                Me.speHorasLiquidar.Value = Nothing
                Me.pcLiquidarSaldos.ShowOnPageLoad = True

        End Select
    End Sub

    Private Sub CargarDatos()
        Dim noCatorcena As Int32 = -1
        Dim codiprovee As String = ""
        Dim codisocio As String = ""

        If Me.cbxCATORCENA.Text <> "" Then noCatorcena = CInt(Me.cbxCATORCENA.Text)
        If Me.speCODIPROVEE.Text <> "" Then codiprovee = Utilerias.FormatoCODIPROVEE(Me.speCODIPROVEE.Text)
        If Me.speCODISOCIO.Text <> "" Then codisocio = Utilerias.FormatoCODISOCIO(Me.speCODISOCIO.Text)

        If Me.cbxTIPO_INVENTARIO.Value = 1 Then 'Es quema
            Me.ucListaCONTROL_QUEMA_SALDO1.CargarDatosPorCriteriosLiquidacion(Me.cbxZAFRA.Value, noCatorcena, codiprovee, codisocio, Me.txtNOMBRE_PROVEEDOR.Text.ToUpper, _
                                                                              Me.txtNOMBLOTE.Text.ToUpper, 1, Me.cbxTIPO_SALDO.Value)
        Else
            Me.ucListaCONTROL_ROZA_SALDO1.CargarDatosPorCriteriosLiquidacion(Me.cbxZAFRA.Value, noCatorcena, codiprovee, codisocio, Me.txtNOMBRE_PROVEEDOR.Text.ToUpper, _
                                                                             Me.txtNOMBLOTE.Text.ToUpper, 1, Me.cbxTIPO_SALDO.Value)
        End If
    End Sub

    Protected Sub ucListaCONTROL_QUEMA_SALDO1_ModificarTCQuema(ID_QUEMA_SALDO As Integer) Handles ucListaCONTROL_QUEMA_SALDO1.ModificarTCQuema
        Me.MostrarPopupLiquidacion(ID_QUEMA_SALDO)
    End Sub

    Protected Sub ucListaCONTROL_ROZA_SALDO1_ModificarTCRoza(ID_ROZA_SALDO As Integer) Handles ucListaCONTROL_ROZA_SALDO1.ModificarTCRoza
        Me.MostrarPopupLiquidacion(ID_ROZA_SALDO)
    End Sub

    Private Sub MostrarPopupLiquidacion(ByVal ID As Int32)
        Me.trFECHA_QUEMA_OLD1.Visible = False
        Me.trFECHA_QUEMA_OLD2.Visible = False
        Me.trFECHA_ROZA_OLD1.Visible = False
        Me.trFECHA_ROZA_OLD2.Visible = False

        If Me.cbxTIPO_INVENTARIO.Value = 1 Then
            Dim lControl As CONTROL_QUEMA_SALDO = (New cCONTROL_QUEMA_SALDO).ObtenerCONTROL_QUEMA_SALDO(ID)
            If lControl IsNot Nothing Then
                txtFECHA_HORA_QUEMA_ACTUAL.Text = lControl.FECHA_HORA_QUEMA.ToString("dd/MM/yyyy HH:mm")
                dteFECHA_HORA_QUEMA_NUEVA.Value = Nothing
                lblpcMensaje.Text = ""
                lblIDEjecucion.Text = ID.ToString

                Me.trFECHA_QUEMA_OLD1.Visible = True
                Me.trFECHA_QUEMA_OLD2.Visible = True
            End If
        Else
            Dim lControl As CONTROL_ROZA_SALDO = (New cCONTROL_ROZA_SALDO).ObtenerCONTROL_ROZA_SALDO(ID)
            If lControl IsNot Nothing Then
                If lControl.FECHA_HORA_QUEMA <> Nothing Then
                    txtFECHA_HORA_QUEMA_ACTUAL.Text = lControl.FECHA_HORA_QUEMA.ToString("dd/MM/yyyy HH:mm")
                    dteFECHA_HORA_QUEMA_NUEVA.Value = Nothing
                    Me.trFECHA_QUEMA_OLD1.Visible = True
                    Me.trFECHA_QUEMA_OLD2.Visible = True
                End If
                txtFECHA_HORA_ROZA_ACTUAL.Text = lControl.FECHA_HORA_ROZA.ToString("dd/MM/yyyy HH:mm")
                dteFECHA_HORA_ROZA_NUEVA.Value = Nothing
                lblpcMensaje.Text = ""
                lblIDEjecucion.Text = ID.ToString

                Me.trFECHA_ROZA_OLD1.Visible = True
                Me.trFECHA_ROZA_OLD2.Visible = True
            End If
        End If

        Me.rblTipoLiquidacion.Value = Nothing
        Me.speCantidadLiquidarTC.ClientEnabled = False
        Me.lblpcMensaje.Text = ""
        Me.tblTipoLiquidacion.Visible = True
        If Me.cbxTIPO_INVENTARIO.Value = 1 Then
            lblCantidadReal.Text = "Cantidad Real Quema (TC):"
        Else
            lblCantidadReal.Text = "Cantidad Real Roza (TC):"
        End If
        Me.pcEjecucionReal.ShowOnPageLoad = True
    End Sub


    Protected Sub btnLiquidar_Click(sender As Object, e As EventArgs) Handles btnLiquidar.Click

        If Me.trFECHA_QUEMA_OLD2.Visible AndAlso Me.dteFECHA_HORA_QUEMA_NUEVA.Value Is Nothing Then
            Me.lblpcMensaje.Text = "Ingrese la nueva fecha/hora de quema"
            Return
        End If
        If Me.trFECHA_ROZA_OLD2.Visible AndAlso Me.dteFECHA_HORA_ROZA_NUEVA.Value Is Nothing Then
            Me.lblpcMensaje.Text = "Ingrese la nueva fecha/hora de roza"
            Return
        End If
        If Me.rblTipoLiquidacion.Value Is Nothing Then
            AsignarMensaje("Seleccione el tipo de reversion", False, True, True)
            Return
        End If
        If Me.rblTipoLiquidacion.Value = 2 AndAlso Me.speCantidadLiquidarTC.Value = 0 Then
            AsignarMensaje("Ingrese el TC a revertir", False, True, True)
            Return
        End If
        If Me.speCantidadRealTC.Value = 0 Then
            AsignarMensaje("Ingrese el TC real a aplicar", False, True, True)
            Return
        End If

        If Me.cbxTIPO_INVENTARIO.Value = 1 Then
            Dim bCtrlQuemaSaldo As New cCONTROL_QUEMA_SALDO
            Dim lCtrlQuemaSaldo As CONTROL_QUEMA_SALDO = (New cCONTROL_QUEMA_SALDO).ObtenerCONTROL_QUEMA_SALDO(CInt(Me.lblIDEjecucion.Text))
            Dim bControlQuema As New cCONTROL_QUEMA
            Dim listaControlQuema As listaCONTROL_QUEMA
            Dim bProforma As New cPROFORMA
            Dim benvio As New cENVIO

            If lCtrlQuemaSaldo IsNot Nothing Then
                lCtrlQuemaSaldo.FECHA_HORA_QUEMA = Me.dteFECHA_HORA_QUEMA_NUEVA.Date
                bCtrlQuemaSaldo.ActualizarCONTROL_QUEMA_SALDO(lCtrlQuemaSaldo)

                listaControlQuema = bControlQuema.ObtenerListaPorCONTROL_QUEMA_SALDO(lCtrlQuemaSaldo.ID_QUEMA_SALDO)
                For Each lEntidad As CONTROL_QUEMA In listaControlQuema
                    lEntidad.FECHA_HORA_QUEMA = Me.dteFECHA_HORA_QUEMA_NUEVA.Date
                    bControlQuema.ActualizarCONTROL_QUEMA(lEntidad)

                    If lEntidad.CODIGO_REF = "PROFORMA" Then
                        Dim lProforma As PROFORMA = (New cPROFORMA).ObtenerPROFORMA(lEntidad.ID_REF)
                        If lProforma IsNot Nothing Then
                            If lProforma.ESTADO <> EstadoProforma.Tara AndAlso lProforma.FECHA_QUEMA <> #12:00:00 AM# AndAlso lProforma.FECHA_ROZA >= Me.dteFECHA_HORA_QUEMA_NUEVA.Date Then
                                lProforma.FECHA_QUEMA = Me.dteFECHA_HORA_QUEMA_NUEVA.Date
                                bProforma.ActualizarPROFORMA(lProforma)

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
        Else
            Dim bCtrlRozaSaldo As New cCONTROL_ROZA_SALDO
            Dim lCtrlRozaSaldo As CONTROL_ROZA_SALDO = (New cCONTROL_ROZA_SALDO).ObtenerCONTROL_ROZA_SALDO(CInt(Me.lblIDEjecucion.Text))
            Dim bControlRoza As New cCONTROL_ROZA
            Dim listaControlRoza As listaCONTROL_ROZA
            Dim bProforma As New cPROFORMA
            Dim benvio As New cENVIO

            If lCtrlRozaSaldo IsNot Nothing Then
                If Me.trFECHA_QUEMA_OLD2.Visible Then
                    lCtrlRozaSaldo.FECHA_HORA_QUEMA = Me.dteFECHA_HORA_QUEMA_NUEVA.Date
                End If
                lCtrlRozaSaldo.FECHA_HORA_ROZA = Me.dteFECHA_HORA_ROZA_NUEVA.Date
                bCtrlRozaSaldo.ActualizarCONTROL_ROZA_SALDO(lCtrlRozaSaldo)

                listaControlRoza = bControlRoza.ObtenerListaPorCONTROL_ROZA_SALDO(lCtrlRozaSaldo.ID_ROZA_SALDO)
                For Each lEntidad As CONTROL_ROZA In listaControlRoza
                    If Me.trFECHA_QUEMA_OLD2.Visible Then
                        lEntidad.FECHA_HORA_QUEMA = Me.dteFECHA_HORA_QUEMA_NUEVA.Date
                    End If
                    lEntidad.FECHA_HORA_ROZA = Me.dteFECHA_HORA_ROZA_NUEVA.Date
                    bControlRoza.ActualizarCONTROL_ROZA(lEntidad)

                    If lEntidad.CODIGO_REF = "PROFORMA" Then
                        Dim lProforma As PROFORMA = (New cPROFORMA).ObtenerPROFORMA(lEntidad.ID_REF)
                        If lProforma IsNot Nothing Then
                            If lProforma.ESTADO <> EstadoProforma.Tara AndAlso lProforma.FECHA_QUEMA <> #12:00:00 AM# AndAlso lProforma.FECHA_ROZA >= Me.dteFECHA_HORA_QUEMA_NUEVA.Date Then
                                If Me.trFECHA_QUEMA_OLD2.Visible Then
                                    lProforma.FECHA_QUEMA = Me.dteFECHA_HORA_QUEMA_NUEVA.Date
                                End If
                                lProforma.FECHA_ROZA = Me.dteFECHA_HORA_ROZA_NUEVA.Date
                                bProforma.ActualizarPROFORMA(lProforma)

                                Dim lEnvio As ENVIO = benvio.ObtenerENVIO(lProforma.ID_ENVIO)
                                If lEnvio IsNot Nothing AndAlso lEnvio.FECHA_QUEMA <> #12:00:00 AM# Then
                                    'Validar que no tiene peso tara
                                    Dim lstBascula As listaBASCULA = (New cBASCULA).ObtenerListaPorENVIO(lEnvio.ID_ENVIO)
                                    Dim conPesoTara As Boolean = (lstBascula IsNot Nothing AndAlso lstBascula.Count > 0 AndAlso lstBascula(0).NETOLIBRAS > 0)

                                    If Not conPesoTara Then
                                        If Me.trFECHA_QUEMA_OLD2.Visible Then
                                            lEnvio.FECHA_QUEMA = Me.dteFECHA_HORA_QUEMA_NUEVA.Date
                                        End If
                                        lEnvio.FECHA_CORTA = Me.dteFECHA_HORA_ROZA_NUEVA.Date
                                        lEnvio.HORAS_QUEMA = 0
                                        benvio.ActualizarENVIO(lEnvio)
                                    End If
                                End If
                            End If
                        End If
                    End If
                Next
            End If
        End If

        If Me.cbxTIPO_INVENTARIO.Value = 1 Then
            Dim bCtrlQuemaSaldo As New cCONTROL_QUEMA_SALDO
            Dim lCtrlQuemaSaldo As CONTROL_QUEMA_SALDO = (New cCONTROL_QUEMA_SALDO).ObtenerCONTROL_QUEMA_SALDO(CInt(Me.lblIDEjecucion.Text))
            Dim bControlQuema As New cCONTROL_QUEMA
            Dim lControlQuema As CONTROL_QUEMA
            Dim dMontoRevertir As Decimal

            If lCtrlQuemaSaldo IsNot Nothing Then
                dMontoRevertir = If(Me.rblTipoLiquidacion.Value = 1, lCtrlQuemaSaldo.TC_PROY, Me.speCantidadLiquidarTC.Value)
                If lCtrlQuemaSaldo.TC_PROY < dMontoRevertir Then
                    AsignarMensaje("La cantidad en TC a revertir es mayor que la proyeccion", False, True, True)
                    Return
                End If
                If lCtrlQuemaSaldo.SALDO = 0 Then
                    AsignarMensaje("No existe saldo de Quema para esta proyeccion", False, True, True)
                    Return
                End If
                lControlQuema = New CONTROL_QUEMA
                lControlQuema.ID_CONTROL_QUEMA = 0
                lControlQuema.ID_ZAFRA = lCtrlQuemaSaldo.ID_ZAFRA
                lControlQuema.ACCESLOTE = lCtrlQuemaSaldo.ACCESLOTE
                lControlQuema.CONCEPTO = If(Me.rblTipoLiquidacion.Value = 1, "REVERSION TOTAL PROYECCION", "REVERSION PARCIAL PROYECCION")
                lControlQuema.CODIGO_REF = "AJUSTE"
                lControlQuema.ID_REF = -1
                lControlQuema.ENTRADAS = 0
                lControlQuema.SALIDAS = dMontoRevertir
                lControlQuema.SALDO = lCtrlQuemaSaldo.SALDO - dMontoRevertir
                lControlQuema.QUEMA_PROGRAMADA = lCtrlQuemaSaldo.QUEMA_PROGRAMADA
                lControlQuema.QUEMA_NOPROG = lCtrlQuemaSaldo.QUEMA_NOPROG
                lControlQuema.CANA_VERDE = lCtrlQuemaSaldo.CANA_VERDE
                lControlQuema.FECHA_HORA_QUEMA = lCtrlQuemaSaldo.FECHA_HORA_QUEMA
                lControlQuema.USUARIO_CREA = Me.ObtenerUsuario
                lControlQuema.FECHA_CREA = cFechaHora.ObtenerFechaHora
                lControlQuema.USUARIO_ACT = Me.ObtenerUsuario
                lControlQuema.FECHA_ACT = cFechaHora.ObtenerFechaHora
                lControlQuema.ID_CONTROL_QUEMA_REF = -1
                lControlQuema.ES_PROYECCION = lCtrlQuemaSaldo.ES_PROYECCION
                lControlQuema.ID_QUEMA_SALDO = lCtrlQuemaSaldo.ID_QUEMA_SALDO
                bControlQuema.ActualizarCONTROL_QUEMA(lControlQuema)

                lControlQuema = New CONTROL_QUEMA
                lControlQuema.ID_CONTROL_QUEMA = 0
                lControlQuema.ID_ZAFRA = lCtrlQuemaSaldo.ID_ZAFRA
                lControlQuema.ACCESLOTE = lCtrlQuemaSaldo.ACCESLOTE
                lControlQuema.CONCEPTO = "QUEMA REAL DEL DIA"
                lControlQuema.CODIGO_REF = "QUEMADIA"
                lControlQuema.ID_REF = -1
                lControlQuema.ENTRADAS = Me.speCantidadRealTC.Value
                lControlQuema.SALIDAS = 0
                lControlQuema.SALDO = lCtrlQuemaSaldo.SALDO - dMontoRevertir + Me.speCantidadRealTC.Value
                lControlQuema.QUEMA_PROGRAMADA = lCtrlQuemaSaldo.QUEMA_PROGRAMADA
                lControlQuema.QUEMA_NOPROG = lCtrlQuemaSaldo.QUEMA_NOPROG
                lControlQuema.CANA_VERDE = lCtrlQuemaSaldo.CANA_VERDE
                lControlQuema.FECHA_HORA_QUEMA = lCtrlQuemaSaldo.FECHA_HORA_QUEMA
                lControlQuema.USUARIO_CREA = Me.ObtenerUsuario
                lControlQuema.FECHA_CREA = cFechaHora.ObtenerFechaHora
                lControlQuema.USUARIO_ACT = Me.ObtenerUsuario
                lControlQuema.FECHA_ACT = cFechaHora.ObtenerFechaHora
                lControlQuema.ID_CONTROL_QUEMA_REF = -1
                lControlQuema.ES_PROYECCION = lCtrlQuemaSaldo.ES_PROYECCION
                lControlQuema.ID_QUEMA_SALDO = lCtrlQuemaSaldo.ID_QUEMA_SALDO
                bControlQuema.ActualizarCONTROL_QUEMA(lControlQuema)
            End If
        Else
            Dim bCtrlRozaSaldo As New cCONTROL_ROZA_SALDO
            Dim lCtrlRozaSaldo As CONTROL_ROZA_SALDO = (New cCONTROL_ROZA_SALDO).ObtenerCONTROL_ROZA_SALDO(CInt(Me.lblIDEjecucion.Text))
            Dim bControlRoza As New cCONTROL_ROZA
            Dim lControlRoza As CONTROL_ROZA
            Dim dMontoRevertir As Decimal

            If lCtrlRozaSaldo IsNot Nothing Then
                dMontoRevertir = If(Me.rblTipoLiquidacion.Value = 1, lCtrlRozaSaldo.TC_PROY, Me.speCantidadLiquidarTC.Value)
                If lCtrlRozaSaldo.TC_PROY < dMontoRevertir Then
                    AsignarMensaje("La cantidad en TC a revertir es mayor que la proyeccion", False, True, True)
                    Return
                End If
                If lCtrlRozaSaldo.SALDO = 0 Then
                    AsignarMensaje("No existe saldo de Quema para esta proyeccion", False, True, True)
                    Return
                End If
                lControlRoza = New CONTROL_ROZA
                lControlRoza.ID_CONTROL_ROZA = 0
                lControlRoza.ID_ZAFRA = cbxZAFRA.Value
                lControlRoza.ACCESLOTE = lCtrlRozaSaldo.ACCESLOTE
                lControlRoza.CONCEPTO = If(Me.rblTipoLiquidacion.Value = 1, "REVERSION TOTAL PROYECCION", "REVERSION PARCIAL PROYECCION")
                lControlRoza.CODIGO_REF = "AJUSTE"
                lControlRoza.ID_REF = -1
                lControlRoza.ENTRADAS = 0
                lControlRoza.SALIDAS = dMontoRevertir
                lControlRoza.SALDO = lCtrlRozaSaldo.SALDO - dMontoRevertir
                lControlRoza.QUEMA_PROGRAMADA = lCtrlRozaSaldo.QUEMA_PROGRAMADA
                lControlRoza.QUEMA_NOPROG = lCtrlRozaSaldo.QUEMA_NOPROG
                lControlRoza.CANA_VERDE = lCtrlRozaSaldo.CANA_VERDE
                lControlRoza.ID_PROVEEDOR_ROZA = -1
                lControlRoza.ID_TIPO_CANA = lCtrlRozaSaldo.ID_TIPO_CANA
                lControlRoza.ID_TIPO_ROZA = lCtrlRozaSaldo.ID_TIPO_ROZA
                lControlRoza.FECHA_HORA_QUEMA = lCtrlRozaSaldo.FECHA_HORA_QUEMA
                lControlRoza.USUARIO_CREA = Me.ObtenerUsuario
                lControlRoza.FECHA_CREA = cFechaHora.ObtenerFechaHora
                lControlRoza.USUARIO_ACT = Me.ObtenerUsuario
                lControlRoza.FECHA_ACT = cFechaHora.ObtenerFechaHora
                lControlRoza.ES_PROYECCION = lCtrlRozaSaldo.ES_PROYECCION
                lControlRoza.ID_ROZA_SALDO = lCtrlRozaSaldo.ID_ROZA_SALDO
                bControlRoza.ActualizarCONTROL_ROZA(lControlRoza)

                lControlRoza = New CONTROL_ROZA
                lControlRoza.ID_CONTROL_ROZA = 0
                lControlRoza.ID_ZAFRA = cbxZAFRA.Value
                lControlRoza.ACCESLOTE = lCtrlRozaSaldo.ACCESLOTE
                lControlRoza.CONCEPTO = "ROZA REAL DEL DIA"
                lControlRoza.CODIGO_REF = "ROZADIA"
                lControlRoza.ID_REF = -1
                lControlRoza.ENTRADAS = Me.speCantidadRealTC.Value
                lControlRoza.SALIDAS = 0
                lControlRoza.SALDO = lCtrlRozaSaldo.SALDO - dMontoRevertir + Me.speCantidadRealTC.Value
                lControlRoza.QUEMA_PROGRAMADA = lCtrlRozaSaldo.QUEMA_PROGRAMADA
                lControlRoza.QUEMA_NOPROG = lCtrlRozaSaldo.QUEMA_NOPROG
                lControlRoza.CANA_VERDE = lCtrlRozaSaldo.CANA_VERDE
                lControlRoza.ID_PROVEEDOR_ROZA = -1
                lControlRoza.ID_TIPO_CANA = lCtrlRozaSaldo.ID_TIPO_CANA
                lControlRoza.ID_TIPO_ROZA = lCtrlRozaSaldo.ID_TIPO_ROZA
                lControlRoza.FECHA_HORA_QUEMA = lCtrlRozaSaldo.FECHA_HORA_QUEMA
                lControlRoza.USUARIO_CREA = Me.ObtenerUsuario
                lControlRoza.FECHA_CREA = cFechaHora.ObtenerFechaHora
                lControlRoza.USUARIO_ACT = Me.ObtenerUsuario
                lControlRoza.FECHA_ACT = cFechaHora.ObtenerFechaHora
                lControlRoza.ES_PROYECCION = lCtrlRozaSaldo.ES_PROYECCION
                lControlRoza.ID_ROZA_SALDO = lCtrlRozaSaldo.ID_ROZA_SALDO
                bControlRoza.ActualizarCONTROL_ROZA(lControlRoza)
            End If
        End If

        If Me.cbxTIPO_INVENTARIO.Value = 1 Then
            Me.ucListaCONTROL_QUEMA_SALDO1.DataBind()
        Else
            Me.ucListaCONTROL_ROZA_SALDO1.DataBind()
        End If
        Me.pcEjecucionReal.ShowOnPageLoad = False
    End Sub

 
    Protected Sub btnLiquidarSaldoHoras_Click(sender As Object, e As EventArgs) Handles btnLiquidarSaldoHoras.Click
        If Me.speHorasLiquidar.Value Is Nothing OrElse Me.speHorasLiquidar.Value = 0 Then
            Me.AsignarMensaje("Ingrese el número de horas", False, True, True)
            Return
        End If

        Dim lZafraActiva As ZAFRA = (New cZAFRA).ObtenerZafraActiva

        If lZafraActiva IsNot Nothing Then
            If Me.cbxTIPO_INVENTARIO.Value = 1 Then
                'Liquidar saldos de control de saldos quema mayores a X horas
                Dim bControlQuema As New cCONTROL_QUEMA
                Dim bControlQuemaSdo As New cCONTROL_QUEMA_SALDO
                Dim lControlQuema As CONTROL_QUEMA
                Dim lista As listaCONTROL_QUEMA_SALDO = bControlQuemaSdo.ObtenerListaPorCriterios(lZafraActiva.ID_ZAFRA, "", Nothing, -1, -1, -1, 1, True)
                Dim difHoras As Int32

                For i As Int32 = 0 To lista.Count - 1
                    difHoras = 0
                    If lista(i).FECHA_HORA_QUEMA_REAL <> Nothing Then
                        difHoras = Math.Abs(DateDiff(DateInterval.Hour, lista(i).FECHA_HORA_QUEMA_REAL, cFechaHora.ObtenerFechaHora))
                    ElseIf lista(i).FECHA_HORA_QUEMA <> Nothing Then
                        difHoras = Math.Abs(DateDiff(DateInterval.Hour, lista(i).FECHA_HORA_QUEMA, cFechaHora.ObtenerFechaHora))
                    End If

                    If difHoras > CInt(speHorasLiquidar.Value) And lista(i).SALDO <> 0 Then
                        lControlQuema = New CONTROL_QUEMA
                        lControlQuema.ID_CONTROL_QUEMA = 0
                        lControlQuema.ID_ZAFRA = lZafraActiva.ID_ZAFRA
                        lControlQuema.ACCESLOTE = lista(i).ACCESLOTE
                        lControlQuema.CONCEPTO = "LIQUIDACION TOTAL DE SALDO"
                        lControlQuema.CODIGO_REF = "AJUSTE"
                        lControlQuema.ID_REF = -1
                        If lista(i).SALDO > 0 Then
                            lControlQuema.ENTRADAS = 0
                            lControlQuema.SALIDAS = lista(i).SALDO
                        Else
                            lControlQuema.ENTRADAS = Math.Abs(lista(i).SALDO)
                            lControlQuema.SALIDAS = 0
                        End If
                        lControlQuema.SALDO = 0
                        lControlQuema.QUEMA_PROGRAMADA = lista(i).QUEMA_PROGRAMADA
                        lControlQuema.QUEMA_NOPROG = lista(i).QUEMA_NOPROG
                        lControlQuema.CANA_VERDE = lista(i).CANA_VERDE
                        lControlQuema.FECHA_HORA_QUEMA = lista(i).FECHA_HORA_QUEMA
                        lControlQuema.USUARIO_CREA = Me.ObtenerUsuario
                        lControlQuema.FECHA_CREA = cFechaHora.ObtenerFechaHora
                        lControlQuema.USUARIO_ACT = Me.ObtenerUsuario
                        lControlQuema.FECHA_ACT = cFechaHora.ObtenerFechaHora
                        lControlQuema.ID_CONTROL_QUEMA_REF = -1
                        lControlQuema.ES_PROYECCION = lista(i).ES_PROYECCION
                        lControlQuema.ID_QUEMA_SALDO = lista(i).ID_QUEMA_SALDO

                        bControlQuema.ActualizarCONTROL_QUEMA(lControlQuema)
                    End If
                Next
            Else
                'Liquidar saldos de control de saldos roza mayores a X horas
                Dim bControlRoza As New cCONTROL_ROZA
                Dim bControlRozaSdo As New cCONTROL_ROZA_SALDO
                Dim lControlRoza As CONTROL_ROZA
                Dim lista As listaCONTROL_ROZA_SALDO = bControlRozaSdo.ObtenerListaPorCriterios(lZafraActiva.ID_ZAFRA, "", -1, -1, -1, "", "", -1, -1, -1, "", -1, 1, True, -1)
                Dim difHoras As Int32

                For i As Int32 = 0 To lista.Count - 1
                    difHoras = 0
                    If lista(i).FECHA_HORA_ROZA_REAL <> Nothing Then
                        difHoras = Math.Abs(DateDiff(DateInterval.Hour, lista(i).FECHA_HORA_ROZA_REAL, cFechaHora.ObtenerFechaHora))
                    ElseIf lista(i).FECHA_HORA_ROZA <> Nothing Then
                        difHoras = Math.Abs(DateDiff(DateInterval.Hour, lista(i).FECHA_HORA_ROZA, cFechaHora.ObtenerFechaHora))
                    End If

                    If difHoras > CInt(speHorasLiquidar.Value) And lista(i).SALDO <> 0 Then
                        lControlRoza = New CONTROL_ROZA
                        lControlRoza.ID_CONTROL_ROZA = 0
                        lControlRoza.ID_ZAFRA = cbxZAFRA.Value
                        lControlRoza.ACCESLOTE = lista(i).ACCESLOTE
                        lControlRoza.CONCEPTO = "LIQUIDACION TOTAL DE SALDO"
                        lControlRoza.CODIGO_REF = "AJUSTE"
                        lControlRoza.ID_REF = -1
                        If lista(i).SALDO > 0 Then
                            lControlRoza.ENTRADAS = 0
                            lControlRoza.SALIDAS = lista(i).SALDO
                        Else
                            lControlRoza.ENTRADAS = Math.Abs(lista(i).SALDO)
                            lControlRoza.SALIDAS = 0
                        End If
                        lControlRoza.SALDO = 0
                        lControlRoza.QUEMA_PROGRAMADA = lista(i).QUEMA_PROGRAMADA
                        lControlRoza.QUEMA_NOPROG = lista(i).QUEMA_NOPROG
                        lControlRoza.CANA_VERDE = lista(i).CANA_VERDE
                        lControlRoza.ID_PROVEEDOR_ROZA = -1
                        lControlRoza.ID_TIPO_CANA = lista(i).ID_TIPO_CANA
                        lControlRoza.ID_TIPO_ROZA = lista(i).ID_TIPO_ROZA
                        lControlRoza.FECHA_HORA_QUEMA = lista(i).FECHA_HORA_QUEMA
                        lControlRoza.USUARIO_CREA = Me.ObtenerUsuario
                        lControlRoza.FECHA_CREA = cFechaHora.ObtenerFechaHora
                        lControlRoza.USUARIO_ACT = Me.ObtenerUsuario
                        lControlRoza.FECHA_ACT = cFechaHora.ObtenerFechaHora
                        lControlRoza.ES_PROYECCION = lista(i).ES_PROYECCION
                        lControlRoza.ID_ROZA_SALDO = lista(i).ID_ROZA_SALDO

                        bControlRoza.ActualizarCONTROL_ROZA(lControlRoza)
                    End If
                Next
            End If
        End If
        Me.pcLiquidarSaldos.ShowOnPageLoad = False

        Me.AsignarMensaje("La liquidacion de saldos con horas mayores a " + speHorasLiquidar.Text + " horas se realizo correctamente", False, True, True)
    End Sub
End Class
