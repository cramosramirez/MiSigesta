Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores
Imports DevExpress.Web
Imports System.Data

Partial Class controlesProforma_ucEnvioProforma
    Inherits ucBase

    Private _Enabled As Boolean = True
    Private _sError As String
    Private mcENVIO As New cENVIO
    Private mENVIO As ENVIO
    Private mcPROFORMA As New cPROFORMA
    Private mPROFORMA As PROFORMA
    Public Event ErrorEvent(ByVal errorMessage As String)


    Private Function EsCosechadoraBanda(ByVal ID_CARGADORA As Integer) As Boolean
        Dim esPrecalificada As Boolean = False
        Dim lCargadora As CARGADORA = (New cCARGADORA).ObtenerCARGADORA(ID_CARGADORA)

        If lCargadora IsNot Nothing Then
            esPrecalificada = lCargadora.PRECALIFI_AUTO
        End If
        Return esPrecalificada
    End Function

    Public Property ID_ENVIO() As Int32
        Get
            If Me.ViewState("ID_ENVIO") IsNot Nothing Then
                Return CInt(Me.ViewState("ID_ENVIO"))
            Else
                Return 0
            End If
        End Get
        Set(ByVal Value As Int32)
            Me.ViewState("ID_ENVIO") = Value
            If Value > 0 Then
                Me.CargarDatosENVIO()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property ID_PROFORMA() As Int32
        Get
            If Me.ViewState("ID_PROFORMA") IsNot Nothing Then
                Return CInt(Me.ViewState("ID_PROFORMA"))
            Else
                Return 0
            End If
        End Get
        Set(ByVal Value As Int32)
            Me.ViewState("ID_PROFORMA") = Value
            If Value > 0 Then
                Me.CargarDatosPROFORMA()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property ID_LOTES_COSECHA As Int32
        Get
            If Me.ViewState("ID_LOTES_COSECHA") IsNot Nothing Then
                Return Me.ViewState("ID_LOTES_COSECHA")
            Else
                Return -1
            End If
        End Get
        Set(value As Int32)
            Me.ViewState("ID_LOTES_COSECHA") = value
            If value > 0 Then
                Me.Nuevo()
                Me.CargarInfoLote()
            End If
        End Set
    End Property

    Public Property _nuevo As Boolean
        Get
            If Me.ViewState("_nuevo") IsNot Nothing Then
                Return Me.ViewState("_nuevo")
            Else
                Return False
            End If
        End Get
        Set(value As Boolean)
            Me.ViewState("_nuevo") = value
        End Set
    End Property

    Public Property Enabled() As Boolean
        Get
            Return Me._Enabled
        End Get
        Set(ByVal Value As Boolean)
            Me._Enabled = Value
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property TIPO_OPERACION As TipoOperacion
        Get
            If Me.ViewState("TIPO_OPERACION") Is Nothing Then
                Return TipoOperacion.Recepcion
            Else
                Return Me.ViewState("TIPO_OPERACION")
            End If
        End Get
        Set(ByVal value As TipoOperacion)
            Me.hfucEnvioProforma.Clear()
            Me.hfucEnvioProforma.Add("ACCESLOTE", "")
            Me.hfucEnvioProforma.Add("CODICONTRATO", "")

            Me.hfucEnvioProforma.Add("ID_ROZA_SALDO", -1)
            Me.hfucEnvioProforma.Add("ID_TIPO_CANA", -1)
            Me.hfucEnvioProforma.Add("ID_TIPO_ROZA", -1)
            Me.hfucEnvioProforma.Add("ID_PROVEEDOR_ROZA", -1)
            Me.hfucEnvioProforma.Add("FECHA_QUEMA", Nothing)
            Me.hfucEnvioProforma.Add("FECHA_CORTE", #12:00:00 AM#)
            Me.hfucEnvioProforma.Add("QUEMA_PROGRAMADA", False)
            Me.hfucEnvioProforma.Add("QUEMA_NOPROG", False)
            Me.hfucEnvioProforma.Add("CANA_VERDE", False)
            Me.hfucEnvioProforma.Add("PLACAVEHIC", "")
            Me.hfucEnvioProforma.Add("ID_MOTORISTA", -1)
            Me.hfucEnvioProforma.Add("ID_TIPOVEHIC", -1)
            Me.hfucEnvioProforma.Add("ES_QUERQUEO", False)
            Me.hfucEnvioProforma.Add("ES_BARRIDA", False)
            Me.hfucEnvioProforma.Add("COD_MONITOR", "")
            Me.hfucEnvioProforma.Add("ID_PROVEE_QQ", -1)

            Me.ViewState("TIPO_OPERACION") = value
            If value = TipoOperacion.EmisionProforma Then
                Me.ID_PROFORMA = 0
                Me.LimpiarControles()
                Me.Nuevo()
                Me.HabilitarEdicion(Me._Enabled)
            ElseIf value = TipoOperacion.Recepcion Then
                Me.ID_ENVIO = 0
                Me.LimpiarControles()
                Me.Nuevo()
                Me.HabilitarEdicion(Me._Enabled)
            ElseIf value = TipoOperacion.RegistroProforma OrElse value = TipoOperacion.CambioFechaQuemaRoza Then
                Me.ID_PROFORMA = 0
                Me.LimpiarControles()
                Me.Nuevo()
                Me.HabilitarEdicion(Me._Enabled)
            ElseIf value = TipoOperacion.Edicion OrElse value = TipoOperacion.Consulta OrElse value = TipoOperacion.EdicionParcialBascula OrElse value = TipoOperacion.Anulacion OrElse value = TipoOperacion.Eliminacion Then
                Me.LimpiarControles()
                Me.Nuevo()
                Me.HabilitarEdicion(False)
            End If
            Me.txtNOPROFORMA.Focus()
        End Set
    End Property

    Private Sub CargarInfoLote()
        Dim lLoteCosecha As LOTES_COSECHA
        Dim lLote As LOTES
        Dim lContrato As CONTRATO
        Dim lProveedor As PROVEEDOR
        Dim lSocio As PROVEEDOR
        Dim lDiaZafra As DIA_ZAFRA
        Dim bControlRoza As New cCONTROL_ROZA
        Dim lControlRoza As New CONTROL_ROZA
        Dim sError As New String("")
        Dim lMaestro As New MAESTRO_LOTES
        Dim ultIdEntradaRoza As Int32 = 0

        Me._nuevo = True

        lLoteCosecha = (New cLOTES_COSECHA).ObtenerLOTES_COSECHA(Me.ID_LOTES_COSECHA)
        If lLoteCosecha IsNot Nothing Then
            Dim lTecnico As AGRONOMO = (New cAGRONOMO).ObtenerAGRONOMO(lLoteCosecha.CODIAGRON)
            If lTecnico IsNot Nothing Then Me.txtTECNICO_ZONA.Text = lTecnico.NOMBRE_AGRONOMO + " " + lTecnico.APELLIDO_AGRONOMO
            lLote = (New cLOTES).ObtenerLOTES(lLoteCosecha.ACCESLOTE)
            lContrato = (New cCONTRATO).ObtenerCONTRATO(lLote.CODICONTRATO)
            If lLote IsNot Nothing Then
                lMaestro = (New cMAESTRO_LOTES).ObtenerMAESTRO_LOTES(lLote.ID_MAESTRO)
            End If

            Me.txtCOMPTENVIO.Text = ""
            Me.cbxZAFRA.Value = lLoteCosecha.ID_ZAFRA
            lDiaZafra = (New cDIA_ZAFRA).ObtenerDiaZafraActivo(lLoteCosecha.ID_ZAFRA)
            If lDiaZafra IsNot Nothing Then Me.txtDIAZAFRA.Text = lDiaZafra.DIAZAFRA.ToString
            Me.txtCODICONTRATO.Text = lLote.CODICONTRATO
            Me.txtNOCONTRATO.Value = lContrato.NO_CONTRATO
            lProveedor = (New cPROVEEDOR).ObtenerPROVEEDOR(lContrato.CODIPROVEEDOR)
            Me.txtCODIPROVEE.Value = CInt(lProveedor.CODIPROVEE)

            lSocio = Nothing
            If lContrato.CODIPROVEEDOR <> lLote.CODIPROVEEDOR Then
                lSocio = (New cPROVEEDOR).ObtenerPROVEEDOR(lLote.CODIPROVEEDOR)
                Me.txtCODISOCIO.Value = lSocio.CODISOCIO
                Me.txtNOMPROVEEDOR.Text = lProveedor.NOMBRES.Trim + " " + lProveedor.APELLIDOS.Trim + "/" + lSocio.NOMBRES + " " + lSocio.APELLIDOS
            Else
                Me.txtNOMPROVEEDOR.Text = lProveedor.NOMBRES.Trim + " " + lProveedor.APELLIDOS.Trim
            End If
            Me.txtHACIENDA.Text = If(lMaestro.HACIENDA Is Nothing, "", lMaestro.HACIENDA)
            Me.txtCODILOTE.Value = lLote.CODILOTE
            Me.txtNOMLOTE.Value = lLote.NOMBLOTE

            Me.ucListaCONTROL_ROZA_SALDO1.CargarDatosPorCriterios(lLoteCosecha.ID_ZAFRA, lLoteCosecha.ACCESLOTE, -1, -1, -1, "", "", -1, -1, -1, "", -1, -1, 1, -1, -1)
            Me.ucListaCONTROL_ROZA_SALDO1.QuitarSeleccion()

            Me.cbxID_TIPO_CANA.ClientEnabled = False
            Me.rblTIPO_QUEMA.ClientEnabled = False
            Me.cbxID_TIPO_ROZA.ClientEnabled = False
            Me.cbxID_PROVEEDOR_ROZA.ClientEnabled = False
            Me.dteFECHA_QUEMA.ClientEnabled = False
            Me.CargarTipoAlza()

            Dim dRozaEjecutada As Decimal =
               (New cCONTROL_ROZA).ObtenerRozaEjecutadaPorZAFRA_LOTE(lLoteCosecha.ID_ZAFRA, lLoteCosecha.ACCESLOTE)

            Me.txtROZA_EJECUTADA.Value = dRozaEjecutada
            Me.txtESTICANA.Value = lLoteCosecha.TONEL_CENSO
            Me.txtDIF_ESTICANA_ROZA.Value = lLoteCosecha.TONEL_CENSO - dRozaEjecutada

            Dim lstProformas As listaPROFORMA = (New cPROFORMA).ObtenerListaPorCriterios(lLoteCosecha.ID_ZAFRA, -1, lLoteCosecha.ACCESLOTE, EstadoProforma.Anulado, "FECHA_ANUL", "DESC")
            If lstProformas IsNot Nothing AndAlso lstProformas.Count > 0 AndAlso DateDiff(DateInterval.Hour, lstProformas(0).FECHA_ANUL, cFechaHora.ObtenerFecha) <= 3 Then
                Me.dteFECHA_CARGA.ClientEnabled = True
                Me.dteFECHA_PATIO.Date = Now
            Else
                Me.dteFECHA_CARGA.ClientEnabled = False
                Me.dteFECHA_PATIO.Value = Nothing
            End If
        End If
    End Sub

    Private Sub SetInfoRoza(ByVal ID_ROZA_SALDO As Int32)
        'De acuerdo al control de roza obtener la fecha de roza
        Dim lControlRozaSdo As CONTROL_ROZA_SALDO = (New cCONTROL_ROZA_SALDO).ObtenerCONTROL_ROZA_SALDO(ID_ROZA_SALDO)
        Dim entradasRoza As New Dictionary(Of Int32, Decimal)
        Dim entradasRoza2 As New Dictionary(Of Int32, Decimal)
        Dim salidas As Decimal = 0
        Dim bControlRoza As New cCONTROL_ROZA
        Dim sError As New String("")
        Dim ultIdEntradaRoza As Int32 = 0
        Dim lSubLote As SUBLOTES



        If lControlRozaSdo IsNot Nothing Then
            'If lControlRozaSdo.ID_PROVEEDOR_ROZA > 0 Then
            '    Me.cbxID_PROVEEDOR_ROZA.Value = lControlRoza.ID_PROVEEDOR_ROZA
            '    Me.hfucEnvioProforma("ID_PROVEEDOR_ROZA") = lControlRoza.ID_PROVEEDOR_ROZA
            'End If
            Me.hfucEnvioProforma("ID_ROZA_SALDO") = ID_ROZA_SALDO
            Me.hfucEnvioProforma("ID_TIPO_CANA") = lControlRozaSdo.ID_TIPO_CANA
            Me.hfucEnvioProforma("FECHA_QUEMA") = If(lControlRozaSdo.FECHA_HORA_QUEMA = Nothing, Nothing, lControlRozaSdo.FECHA_HORA_QUEMA)
            Me.hfucEnvioProforma("FECHA_CORTE") = lControlRozaSdo.FECHA_HORA_ROZA
            Me.hfucEnvioProforma("ES_QUERQUEO") = lControlRozaSdo.ES_QUERQUEO
            Me.hfucEnvioProforma("ID_PROVEE_QQ") = lControlRozaSdo.ID_PROVEE_QQ
            Me.hfucEnvioProforma("ID_SUBLOTES") = lControlRozaSdo.ID_SUBLOTES

            Me.dteFECHA_CORTE.Date = lControlRozaSdo.FECHA_HORA_ROZA
            Me.dteFECHA_QUEMA.Date = lControlRozaSdo.FECHA_HORA_QUEMA
            Me.cbxID_TIPO_CANA.Value = lControlRozaSdo.ID_TIPO_CANA
            If lControlRozaSdo.QUEMA_PROGRAMADA Then
                Me.rblTIPO_QUEMA.Value = 1
            ElseIf lControlRozaSdo.QUEMA_NOPROG Then
                Me.rblTIPO_QUEMA.Value = 2
            ElseIf lControlRozaSdo.CANA_VERDE Then
                Me.rblTIPO_QUEMA.Value = 3
                Me.dteFECHA_QUEMA.Value = Nothing
            End If
            Me.CargarTipoRoza()
            Me.hfucEnvioProforma("ID_TIPO_ROZA") = lControlRozaSdo.ID_TIPO_ROZA
            Me.cbxID_TIPO_ROZA.Value = lControlRozaSdo.ID_TIPO_ROZA
            Me.CargarProveedorRoza()
            If Me.cbxID_PROVEEDOR_ROZA.Items.Count > 0 Then
                If lControlRozaSdo.ID_TIPO_ROZA = CAT.TipoRoza.RozaCosechadoraJiboa OrElse
                    lControlRozaSdo.ID_TIPO_ROZA = CAT.TipoRoza.RozaCosechadoraParticular OrElse
                    lControlRozaSdo.ID_TIPO_ROZA = CAT.TipoRoza.RozaCosechadoraProductor Then
                    Me.cbxID_PROVEEDOR_ROZA.SelectedIndex = 0
                Else
                    Me.cbxID_PROVEEDOR_ROZA.Value = lControlRozaSdo.ID_PROVEEDOR_ROZA
                End If
            End If
            If lControlRozaSdo.ID_PROVEE_QQ > 0 Then
                cbxPROVEEDOR_QUERQUEO.Value = lControlRozaSdo.ID_PROVEE_QQ
            Else
                cbxPROVEEDOR_QUERQUEO.Value = -1
            End If
            Me.chkQuerqueo.Checked = lControlRozaSdo.ES_QUERQUEO

            Dim lEntidadSaldo As CONTROL_ROZA_SALDO = (New cCONTROL_ROZA_SALDO).ObtenerCONTROL_ROZA_SALDO(ID_ROZA_SALDO)
            If lEntidadSaldo IsNot Nothing Then Me.txtDISPONIBLE.Value = lEntidadSaldo.SALDO
            Me.CargarTipoAlza()
            Me.CargarCargadoras()
            Me.CargarCargadores()

            ' Info sublote
            lSubLote = (New cSUBLOTES).ObtenerSUBLOTES(lControlRozaSdo.ID_SUBLOTES)
            If lSubLote IsNot Nothing Then
                Me.txtSUBLOTE.Text = lSubLote.CODIGO + " " + lSubLote.NOMBRE_PORCION
            End If
        End If
    End Sub

    Private Sub SetInfoControlesRoza()
        If Me.hfucEnvioProforma.Contains("ID_TIPO_CANA") AndAlso Me.hfucEnvioProforma("ID_TIPO_CANA") > 0 Then
            If Me.hfucEnvioProforma("ID_PROVEEDOR_ROZA") > 0 Then
                Me.cbxID_PROVEEDOR_ROZA.Value = Me.hfucEnvioProforma("ID_PROVEEDOR_ROZA")
            End If
            Me.dteFECHA_CORTE.Date = Me.hfucEnvioProforma("FECHA_CORTE")
            Me.dteFECHA_QUEMA.Value = If(Me.hfucEnvioProforma("FECHA_QUEMA") < #1/1/1910#, Nothing, Me.hfucEnvioProforma("FECHA_QUEMA"))
            Me.cbxID_TIPO_CANA.Value = CInt(Me.hfucEnvioProforma("ID_TIPO_CANA"))
            If Me.hfucEnvioProforma("QUEMA_PROGRAMADA") Then
                Me.rblTIPO_QUEMA.Value = 1
            ElseIf Me.hfucEnvioProforma("QUEMA_NOPROG") Then
                Me.rblTIPO_QUEMA.Value = 2
            ElseIf Me.hfucEnvioProforma("CANA_VERDE") Then
                Me.rblTIPO_QUEMA.Value = 3
                Me.dteFECHA_QUEMA.Value = Nothing
            End If
            Me.CargarTipoRoza()
            Me.cbxID_TIPO_ROZA.Value = CInt(Me.hfucEnvioProforma("ID_TIPO_ROZA"))
            Me.CargarProveedorRoza()
            If Me.cbxID_PROVEEDOR_ROZA.Items.Count > 0 Then
                If Me.hfucEnvioProforma("ID_TIPO_ROZA") = CAT.TipoRoza.RozaCosechadoraJiboa OrElse
                    Me.hfucEnvioProforma("ID_TIPO_ROZA") = CAT.TipoRoza.RozaCosechadoraParticular OrElse
                    Me.hfucEnvioProforma("ID_TIPO_ROZA") = CAT.TipoRoza.RozaCosechadoraProductor Then
                    Me.cbxID_PROVEEDOR_ROZA.SelectedIndex = 0
                Else
                    Me.cbxID_PROVEEDOR_ROZA.Value = Me.hfucEnvioProforma("ID_PROVEEDOR_ROZA")
                End If
            End If

            Dim lEntidad As CONTROL_ROZA_SALDO = (New cCONTROL_ROZA_SALDO).ObtenerCONTROL_ROZA_SALDO(CInt(Me.hfucEnvioProforma("ID_ROZA_SALDO")))
            If lEntidad IsNot Nothing Then Me.txtDISPONIBLE.Value = lEntidad.SALDO
            Me.CargarTipoAlza(False)
            Me.CargarPlacas()
            If Me.hfucEnvioProforma("PLACAVEHIC").ToString <> "" Then
                Dim lTransporte As TRANSPORTE = (New cTRANSPORTE).ObtenerTRANSPORTEPorTRANSPORTISTA_PLACA(CInt(Me.txtCODTRANSPORT.Text), Me.hfucEnvioProforma("PLACAVEHIC").ToString)
                If lTransporte IsNot Nothing AndAlso lTransporte.ID_TRANSPORTE > 0 Then
                    Me.cbxPLACAVEHIC.Value = lTransporte.ID_TRANSPORTE
                    Me.cbxTIPO_TRANS.Value = lTransporte.ID_TIPOTRANS
                Else
                    Me.cbxPLACAVEHIC.Text = Me.hfucEnvioProforma("PLACAVEHIC")
                End If
            End If
            Me.CargarMotoristas()
            If Me.cbxMOTORISTA.Items.Count > 0 Then
                If Me.hfucEnvioProforma.Contains("ID_MOTORISTA") AndAlso Utilerias.EsNumeroEntero(Me.hfucEnvioProforma("ID_MOTORISTA")) AndAlso Me.hfucEnvioProforma("ID_MOTORISTA") <> -1 Then
                    Me.cbxMOTORISTA.Value = Me.hfucEnvioProforma("ID_MOTORISTA")
                ElseIf Me.hfucEnvioProforma.Contains("ID_MOTORISTA") AndAlso Me.hfucEnvioProforma("ID_MOTORISTA").ToString <> "-1" Then
                    Me.cbxMOTORISTA.Text = Me.hfucEnvioProforma("ID_MOTORISTA")
                End If
            End If
            If Me.cbxTIPO_TRANS.Items.Count > 0 AndAlso Me.hfucEnvioProforma("ID_TIPOVEHIC") <> -1 Then
                Me.cbxTIPO_TRANS.Value = Me.hfucEnvioProforma("ID_TIPOVEHIC")
            End If
            Me.chkQuerqueo.Checked = Me.hfucEnvioProforma("ES_QUERQUEO")
            Me.cbxPROVEEDOR_QUERQUEO.Value = Me.hfucEnvioProforma("ID_PROVEE_QQ")
            Me.lblID_SUBLOTES.Text = Me.hfucEnvioProforma("ID_SUBLOTES")
            ' Info sublote
            Dim lSubLote As SUBLOTES
            lSubLote = (New cSUBLOTES).ObtenerSUBLOTES(CInt(Me.hfucEnvioProforma("ID_SUBLOTES").ToString))
            If lSubLote IsNot Nothing Then
                Me.txtSUBLOTE.Text = lSubLote.CODIGO + " " + lSubLote.NOMBRE_PORCION
            End If
        End If
    End Sub


    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Dim item As LayoutItemBase
        Dim creacionProforma As Boolean = Me.TIPO_OPERACION = TipoOperacion.EmisionProforma
        Dim registroProforma As Boolean = Me.TIPO_OPERACION = TipoOperacion.RegistroProforma
        Dim consultaEliminaAnulacionEnvio As Boolean = (Me.TIPO_OPERACION = TipoOperacion.Consulta OrElse
                                                       Me.TIPO_OPERACION = TipoOperacion.Eliminacion OrElse
                                                       Me.TIPO_OPERACION = TipoOperacion.Anulacion)
        Dim edicionRecepcionEdicion As Boolean = (Me.TIPO_OPERACION = TipoOperacion.Recepcion OrElse
                                                 Me.TIPO_OPERACION = TipoOperacion.Edicion)
        Dim edicionRecepcionEdicionBascula As Boolean = (Me.TIPO_OPERACION = TipoOperacion.Recepcion OrElse
                                                 Me.TIPO_OPERACION = TipoOperacion.EdicionParcialBascula)
        Me.cbxZAFRA.ClientEnabled = Me.TIPO_OPERACION = TipoOperacion.Consulta
        Me.txtCATORCENA_ZAFRA.ClientEnabled = False
        Me.txtDIAZAFRA.ClientEnabled = False

        Me.lblProforma.ClientVisible = True
        Me.txtNOPROFORMA.ClientVisible = True

        Me.lblTaco.ClientVisible = (Me.TIPO_OPERACION <> TipoOperacion.EmisionProforma)
        Me.txtNROBOLETA.ClientVisible = (Me.TIPO_OPERACION <> TipoOperacion.EmisionProforma)

        Me.lblComprobante.ClientVisible = (Me.TIPO_OPERACION <> TipoOperacion.EmisionProforma)
        Me.txtCOMPTENVIO.ClientVisible = (Me.TIPO_OPERACION <> TipoOperacion.EmisionProforma)

        Me.txtNOPROFORMA.ClientEnabled = (registroProforma OrElse Me.TIPO_OPERACION = TipoOperacion.Recepcion OrElse Me.TIPO_OPERACION = TipoOperacion.CambioFechaQuemaRoza)
        Me.txtNROBOLETA.ClientEnabled = edicionRecepcionEdicion OrElse edicionRecepcionEdicionBascula OrElse consultaEliminaAnulacionEnvio
        Me.txtCOMPTENVIO.ClientEnabled = edicionRecepcionEdicion OrElse edicionRecepcionEdicionBascula 'OrElse registroProforma
        Me.txtNOCONTRATO.ClientEnabled = False 'edicionRecepcionEdicion
        Me.txtCODIPROVEE.ClientEnabled = False
        Me.txtCODISOCIO.ClientEnabled = False
        Me.txtNOMPROVEEDOR.ClientEnabled = False
        Me.txtCODILOTE.ClientEnabled = False
        Me.txtNOMLOTE.ClientEnabled = False
        Me.txtHACIENDA.ClientEnabled = False
        Me.cbxID_TIPO_CANA.ClientEnabled = creacionProforma 'OrElse edicionRecepcionEdicion
        Me.cbxID_TIPO_ROZA.ClientEnabled = creacionProforma 'OrElse edicionRecepcionEdicion
        Me.cbxID_TIPO_ALZA.ClientEnabled = creacionProforma OrElse edicionRecepcionEdicion
        Me.speID_MOTORISTA_VEHI.ClientEnabled = creacionProforma OrElse (Me.TIPO_OPERACION = TipoOperacion.Edicion)
        'Me.txtCODTRANSPORT.ClientEnabled = creacionProforma OrElse (Me.TIPO_OPERACION = TipoOperacion.Edicion)
        Me.txtCODTRANSPORT.ClientEnabled = False
        Me.txtNOMBRE_TRANSPORTISTA.ClientEnabled = False
        Me.rblTRANS_PROPIEDAD.ClientEnabled = creacionProforma OrElse (Me.TIPO_OPERACION = TipoOperacion.Edicion)
        Me.cbxPLACAVEHIC.ClientEnabled = (Me.TIPO_OPERACION = TipoOperacion.Edicion)
        Me.cbxMOTORISTA.ClientEnabled = edicionRecepcionEdicion
        Me.cbxCARGADORA.ClientEnabled = creacionProforma OrElse edicionRecepcionEdicion

        Me.chkVerTodosMotoristas.ClientEnabled = creacionProforma
        Me.chkVerTodosMotoristas.Checked = True
        Me.chkVerTodosProveedoresRoza.ClientVisible = edicionRecepcionEdicion
        Me.chkVerTodosProveedoresRoza.ClientEnabled = (Me.TIPO_OPERACION = TipoOperacion.Edicion)
        Me.chkVerTodosProveedoresRoza.Checked = (Me.TIPO_OPERACION = TipoOperacion.Edicion OrElse Me.TIPO_OPERACION = TipoOperacion.Consulta OrElse Me.TIPO_OPERACION = TipoOperacion.Anulacion OrElse Me.TIPO_OPERACION = TipoOperacion.EdicionParcialBascula OrElse Me.TIPO_OPERACION = TipoOperacion.Eliminacion)

        Me.cbxCARGADOR.ClientEnabled = creacionProforma OrElse edicionRecepcionEdicion 'OrElse registroProforma
        Me.dteFECHA_QUEMA.ClientEnabled = (Me.rblTIPO_QUEMA.Value = 1 OrElse Me.rblTIPO_QUEMA.Value = 2) AndAlso (edicionRecepcionEdicion OrElse (Me.TIPO_OPERACION = TipoOperacion.CambioFechaQuemaRoza))
        Me.dteFECHA_CORTE.ClientEnabled = (edicionRecepcionEdicion) OrElse (Me.TIPO_OPERACION = TipoOperacion.CambioFechaQuemaRoza)

        Me.dteFECHA_CARGA.ClientEnabled = (Me.TIPO_OPERACION = TipoOperacion.Edicion) OrElse registroProforma OrElse (Me.TIPO_OPERACION = TipoOperacion.CambioFechaQuemaRoza)
        Me.dteFECHA_PATIO.ClientEnabled = (Me.TIPO_OPERACION = TipoOperacion.Recepcion OrElse Me.TIPO_OPERACION = TipoOperacion.Edicion)
        Me.rblTIPO_QUEMA.ClientEnabled = creacionProforma 'OrElse edicionRecepcionEdicionBascula 'OrElse edicionRecepcionEdicion
        Me.cbxTIPO_TRANS.ClientEnabled = False

        Me.cbxID_PROVEEDOR_ROZA.ClientEnabled = creacionProforma OrElse edicionRecepcionEdicion
        Me.cbxSUPERVISOR.ClientVisible = False
        Me.lblDisponible.ClientVisible = creacionProforma
        Me.txtDISPONIBLE.ClientVisible = creacionProforma
        Me.trEsticana.Visible = creacionProforma
        Me.ucListaCONTROL_ROZA_SALDO1.Visible = creacionProforma
        Me.trOBSERVA_ANUL1.Visible = Me.TIPO_OPERACION = TipoOperacion.AnulacionProforma
        Me.trOBSERVA_ANUL11.Visible = Me.TIPO_OPERACION = TipoOperacion.AnulacionProforma
        Me.trOBSERVA_ANUL2.Visible = Me.TIPO_OPERACION = TipoOperacion.AnulacionProforma
        Me.txtOBSERVA_ANUL.ClientEnabled = False
        Me.txtOBSERVA_ANUL.Text = ""

        Me.txtESTICANA.ClientEnabled = False
        Me.txtROZA_EJECUTADA.ClientEnabled = False
        Me.txtDIF_ESTICANA_ROZA.ClientEnabled = False
        Me.txtTECNICO_ZONA.ClientEnabled = False

        Me.chkQuerqueo.ClientEnabled = False
        Me.cbxPROVEEDOR_QUERQUEO.ClientEnabled = (Me.TIPO_OPERACION = TipoOperacion.Edicion)
        Me.chkBarrido.ClientEnabled = creacionProforma OrElse (Me.TIPO_OPERACION = TipoOperacion.Edicion)
        'Me.chkPrimerEnvioTurno.ClientEnabled = (Me.TIPO_OPERACION = TipoOperacion.Recepcion OrElse Me.TIPO_OPERACION = TipoOperacion.Edicion)
        'Me.chkUltimoEnvioTurno.ClientEnabled = (Me.TIPO_OPERACION = TipoOperacion.Recepcion OrElse Me.TIPO_OPERACION = TipoOperacion.Edicion)
        Me.chkPrimerEnvioTurno.ClientVisible = False
        Me.chkUltimoEnvioTurno.ClientVisible = False

        Me.txtCODIGO_MOCHADOR.ClientEnabled = edicionRecepcionEdicion
        Me.txtCODIGO_CHEQUERO.ClientEnabled = edicionRecepcionEdicion
        Me.txtNOMBRE_MOCHADOR.ClientEnabled = False
        Me.txtNOMBRE_CHEQUERO.ClientEnabled = False
        Me.chkAUTOVOLTEO.ClientEnabled = False

        Me.txtCOD_MONITOR.ClientEnabled = edicionRecepcionEdicion
        Me.cbxPROVEEDOR_QUERQUEO.ClientEnabled = edicionRecepcionEdicion
        Me.txtSUBLOTE.ClientEnabled = False
    End Sub

    Public Function Actualizar() As String
        Dim sError As New StringBuilder
        Dim alDatos As New ArrayList
        Dim idMonitor As Integer = -1
        Dim idQR As Integer = -1
        Dim bEnvioMoniQQ As New cENVIO_MONI_QQ
        Dim lRetMoniQQ As List(Of Dictionary(Of Integer, String))
        Dim codiProveedor As String
        Dim idProveedorRozaAntesActualizar As Integer

        mENVIO = New ENVIO
        If Me._nuevo Then
            mENVIO.ID_ENVIO = 0
            mENVIO.USUARIO_CREA = Me.ObtenerUsuario
            mENVIO.FECHA_CREA = cFechaHora.ObtenerFechaHora
            mENVIO.USUARIO_ACT = Me.ObtenerUsuario
            mENVIO.FECHA_ACT = cFechaHora.ObtenerFechaHora
            mENVIO.FECHA_ENTRADA = cFechaHora.ObtenerFecha
        Else
            mENVIO = (New cENVIO).ObtenerENVIO(Me.ID_ENVIO)
            mENVIO.USUARIO_ACT = Me.ObtenerUsuario
            mENVIO.FECHA_ACT = cFechaHora.ObtenerFechaHora
            idProveedorRozaAntesActualizar = mENVIO.ID_PROVEEDOR_ROZA
        End If
        If Me.cbxZAFRA.Value Is Nothing Then
            sError.AppendLine(" * No existe Periodo de Zafra.")
        End If
        If Me.txtNOCONTRATO.Text = "" Then
            sError.AppendLine(" * Ingrese el Contrato.")
        End If
        If Me.txtCOMPTENVIO.Text.Trim = String.Empty Then
            sError.AppendLine(" * Ingrese el No. de Comprobante.")
        End If
        If Me.txtNROBOLETA.Text.Trim = String.Empty Then
            sError.AppendLine(" * Ingrese el No. de TACO.")
        End If
        If Me.txtCODILOTE.Text = "" Then
            sError.AppendLine(" * Seleccione un lote.")
        End If
        If Me.txtCODTRANSPORT.Text.Trim = String.Empty Then
            sError.AppendLine(" * Ingrese el codigo de Transportista.")
        Else
            Dim lTransportista As TRANSPORTISTA = (New cTRANSPORTISTA).ObtenerTRANSPORTISTA(Me.txtCODTRANSPORT.Text.Trim)
            If lTransportista Is Nothing Then
                sError.AppendLine(" * Transportista no existe en el sistema.")
            End If
        End If
        If Me.cbxPLACAVEHIC.Text = String.Empty Then
            sError.AppendLine(" * Ingrese el numero de placa.")
        End If
        If Me.cbxMOTORISTA.Text = "" OrElse cbxMOTORISTA.Value Is Nothing Then
            sError.AppendLine(" * Seleccione o ingrese el nombre del motorista.")
        End If
        If Me.cbxCARGADORA.Value Is Nothing OrElse Me.cbxCARGADORA.Text = "" Then
            sError.AppendLine(" * Seleccione la Cargadora/Cosechadora.")
        End If
        If (Me.cbxID_TIPO_ALZA.Value <> Enumeradores.CAT.TipoAlza.AlzaManualParticular AndAlso
            Me.cbxID_TIPO_ALZA.Value <> Enumeradores.CAT.TipoAlza.AlzaManualProductor) AndAlso (Me.cbxCARGADOR.Value Is Nothing OrElse Me.cbxCARGADOR.Text = "") Then
            sError.AppendLine(" * Seleccione el operador.")
        End If
        If Me.cbxID_TIPO_CANA.Value Is Nothing OrElse Me.cbxID_TIPO_CANA.Text = "" Then
            sError.AppendLine(" * Seleccione la Forma de Cosecha.")
        End If
        If Me.cbxID_PROVEEDOR_ROZA.Items.Count > 0 AndAlso Me.cbxID_PROVEEDOR_ROZA.Value Is Nothing Then
            sError.AppendLine(" * Seleccione el proveedor de roza.")
        End If
        If Me.rblTRANS_PROPIEDAD.Value Is Nothing Then
            sError.AppendLine(" * Seleccione si el transporte es particular o propio.")
        End If
        If Me.cbxTIPO_TRANS.Value Is Nothing OrElse Me.cbxTIPO_TRANS.Text = "" Then
            sError.AppendLine(" * Seleccione el tipo de transporte.")
        End If
        If Me.dteFECHA_QUEMA.Value = Nothing AndAlso (Me.rblTIPO_QUEMA.Value = 1 OrElse Me.rblTIPO_QUEMA.Value = 2) Then
            sError.AppendLine(" * Ingrese fecha de quema.")
        End If
        If Me.dteFECHA_QUEMA.Value <> Nothing AndAlso (Me.rblTIPO_QUEMA.Value = 1 OrElse Me.rblTIPO_QUEMA.Value = 2) Then
            If dteFECHA_QUEMA.Date < DateAdd(DateInterval.Day, -7, mENVIO.FECHA_CREA) Then
                sError.AppendLine(" * Fecha de quema no puede ser menor a 7 dias de la fecha de ingreso al sistema.")
            End If
        End If
        If Me.dteFECHA_CORTE.Value = Nothing Then
            sError.AppendLine(" * Ingrese fecha de corta.")
        End If
        If Me.dteFECHA_CARGA.Value = Nothing Then
            sError.AppendLine(" * Ingrese fecha de carga.")
        End If
        If Me.dteFECHA_PATIO.Value = Nothing Then
            sError.AppendLine(" * Ingrese fecha de ingreso JIBOA.")
        End If
        If (Me.rblTIPO_QUEMA.Value = 1 OrElse Me.rblTIPO_QUEMA.Value = 2) Then
            If Me.dteFECHA_QUEMA.Date > Me.dteFECHA_CORTE.Date Then
                sError.AppendLine(" * Fecha de quema no puede ser mayor a fecha de corta.")
            End If
            If Me.dteFECHA_QUEMA.Date > mENVIO.FECHA_CREA Then
                sError.AppendLine(" * Fecha de quema no puede ser mayor a la fecha de ingreso al sistema.")
            End If
        End If
        If Me.dteFECHA_CORTE.Date > Me.dteFECHA_CARGA.Date Then
            sError.AppendLine(" * Fecha de corta no puede ser mayor a fecha de carga.")
        End If
        'If Me.dteFECHA_CORTE.Date > mENVIO.FECHA_CREA Then
        '    sError.AppendLine(" * Fecha de corta no puede ser mayor a la fecha de ingreso al sistema.")
        'End If
        'If Me.dteFECHA_CARGA.Date > Me.dteFECHA_PATIO.Date Then
        '    sError.AppendLine(" * Fecha de carga no puede ser mayor a fecha de ingreso JIBOA.")
        'End If
        If Me.dteFECHA_PATIO.Date > mENVIO.FECHA_CREA Then
            sError.AppendLine(" * Fecha de carga patio no puede ser mayor a la fecha del sistema.")
        End If
        'If EsCargadoraJIBOA(Convert.ToInt32(Me.cbxCARGADORA.Value)) AndAlso (Me.txtCODIGO_MOCHADOR.Text = "" OrElse Me.txtCODIGO_CHEQUERO.Text = "") Then
        '    sError.AppendLine(" * Ingrese los codigos de mochador y chequero.")
        'End If

        If EsCosechadoraBanda(Me.cbxCARGADORA.Value) AndAlso chkAUTOVOLTEO.Checked Then
            If (Me.cbxOPERADOR_TRACTOR1.Value Is Nothing) AndAlso (Me.cbxOPERADOR_TRACTOR2.Value Is Nothing) Then
                sError.AppendLine(" * Ingrese al menos un operador de tractor.")
            End If
            If Me.cbxOPERADOR_TRACTOR1.Value IsNot Nothing AndAlso Me.cbxOPERADOR_TRACTOR2.Value IsNot Nothing AndAlso (Me.cbxOPERADOR_TRACTOR1.Value = Me.cbxOPERADOR_TRACTOR2.Value) Then
                sError.AppendLine(" * El operador de tractor uno y dos no pueden ser el mismo.")
            End If
        End If
        If Me.txtCOD_MONITOR.Text.Trim <> "" Then
            Dim lstMonitor As listaMONITOR_CAL = (New cMONITOR_CAL).ObtenerListaPorCODISIS(Me.txtCOD_MONITOR.Text.Trim.ToUpper)
            If lstMonitor IsNot Nothing AndAlso lstMonitor.Count > 0 Then
                idMonitor = lstMonitor(0).ID_MONITOR
            Else
                sError.AppendLine(" * El codigo de monitor de calidad no existe.")
            End If
        End If

        codiProveedor = Utilerias.FormatoCODIPROVEE(Me.txtCODIPROVEE.Value) + IIf(Me.txtCODISOCIO.Text <> "", Utilerias.FormatoCODISOCIO(Me.txtCODISOCIO.Value), Utilerias.FormatoCODISOCIO(0))
        If Me.cbxPROVEEDOR_QUERQUEO.Value IsNot Nothing AndAlso CInt(cbxPROVEEDOR_QUERQUEO.Value) > 0 Then

            'Establecer el código de querqueo primario (ID_PROVEE_QQ) y secundario (ID_PROVEE_QQ_S) asi como la tarifa
            idQR = CInt(cbxPROVEEDOR_QUERQUEO.Value)
            lRetMoniQQ = bEnvioMoniQQ.SP_SERVICIO_MONITOR_QUERQUEO("V", codiProveedor, -1, -1, idQR)
            If lRetMoniQQ IsNot Nothing AndAlso lRetMoniQQ.Count = 1 Then
                If lRetMoniQQ(0).Keys(0) <> 0 Then sError.AppendLine(lRetMoniQQ(0).Values(0).ToString)
            Else
                sError.AppendLine(" * No se logro validar frente de querqueo.")
            End If
        End If

        'Referencia al proforma
        Dim lProforma As PROFORMA = (New cPROFORMA).ObtenerPROFORMAPorNumZafra(Me.txtNOPROFORMA.Value, Me.cbxZAFRA.Value)
        If lProforma IsNot Nothing Then
            If lProforma.PLACAVEHIC.Replace("-", "") <> Me.cbxPLACAVEHIC.Text.Trim.Replace("-", "") Then
                sError.AppendLine(" * No puede procesar dos placas distintas ya que la placa del proforma es " + lProforma.PLACAVEHIC + " y la placa del envio es " + Me.cbxPLACAVEHIC.Text)
            End If
        Else
            sError.AppendLine(" * El No de Proforma " + Me.txtNOPROFORMA.Text + " no existe para esta zafra")
        End If

        If sError.ToString.Length > 0 Then
            Return sError.ToString
        End If
        mENVIO.ID_ZAFRA = Me.cbxZAFRA.Value
        mENVIO.CATORCENA = Convert.ToInt32(Me.txtCATORCENA_ZAFRA.Text)
        mENVIO.DIAZAFRA = Convert.ToInt32(Me.txtDIAZAFRA.Text)
        mENVIO.CODICONTRATO = Me.hfucEnvioProforma("CODICONTRATO")
        mENVIO.CODIPROVEEDOR = Utilerias.FormatoCODIPROVEE(Me.txtCODIPROVEE.Value) + IIf(Me.txtCODISOCIO.Text <> "", Utilerias.FormatoCODISOCIO(Me.txtCODISOCIO.Value), Utilerias.FormatoCODISOCIO(0))
        mENVIO.COMPTENVIO = Convert.ToInt32(Me.txtCOMPTENVIO.Value)
        mENVIO.NROBOLETA = Convert.ToInt32(Me.txtNROBOLETA.Value)
        mENVIO.CODTRANSPORT = Convert.ToInt32(Me.txtCODTRANSPORT.Value)
        mENVIO.PLACAVEHIC = Me.cbxPLACAVEHIC.Text.ToUpper
        If Utilerias.EsNumeroEntero(Me.cbxMOTORISTA.Value) Then
            mENVIO.NOMBRES_MOTORISTA = Me.cbxMOTORISTA.Text.Trim.ToUpper
            mENVIO.ID_MOTORISTA = Me.cbxMOTORISTA.Value
        Else
            mENVIO.NOMBRES_MOTORISTA = Me.cbxMOTORISTA.Text.Trim.ToUpper
            mENVIO.ID_MOTORISTA = -1
        End If

        If Me.cbxID_TIPO_CANA.Value = CAT.TipoCana.Corta Then
            If Me.rblTIPO_QUEMA.Value = 1 OrElse Me.rblTIPO_QUEMA.Value = 2 Then
                mENVIO.ID_TIPO_CANA = 43
            Else
                mENVIO.ID_TIPO_CANA = 35
            End If
        ElseIf Me.cbxID_TIPO_CANA.Value = CAT.TipoCana.Larga Then
            If Me.rblTIPO_QUEMA.Value = 1 OrElse Me.rblTIPO_QUEMA.Value = 2 Then
                mENVIO.ID_TIPO_CANA = 27
            Else
                mENVIO.ID_TIPO_CANA = 19
            End If
        Else
            mENVIO.ID_TIPO_CANA = 55
        End If

        mENVIO.ID_TIPO_ROZA = Me.cbxID_TIPO_ROZA.Value
        mENVIO.ID_TIPO_ALZA = Me.cbxID_TIPO_ALZA.Value
        'mENVIO.ID_TIPOTRANS = If(Me.cbxTIPO_TRANS.Value = 28, 19, Me.cbxTIPO_TRANS.Value)
        mENVIO.ID_TIPOTRANS = Me.cbxTIPO_TRANS.Value
        mENVIO.ID_CARGADORA = Convert.ToInt32(Me.cbxCARGADORA.Value)
        If Me.cbxID_TIPO_ALZA.Value = Enumeradores.CAT.TipoAlza.AlzaManualParticular OrElse
            Me.cbxID_TIPO_ALZA.Value = Enumeradores.CAT.TipoAlza.AlzaManualProductor Then
            mENVIO.ID_CARGADOR = 33
        Else
            mENVIO.ID_CARGADOR = Convert.ToInt32(Me.cbxCARGADOR.Value)
        End If
        mENVIO.TIPO_TARIFA_CARGADORA = 0
        mENVIO.ID_SUPERVISOR = 1
        mENVIO.FECHA_QUEMAOld = cFechaHora.ObtenerFechaHora
        mENVIO.FECHA_QUEMA = Me.dteFECHA_QUEMA.Date
        mENVIO.FECHA_CORTA = Me.dteFECHA_CORTE.Date
        If Me.rblTIPO_QUEMA.Value = 1 Then mENVIO.QUEMAPROG = True Else mENVIO.QUEMAPROG = False
        mENVIO.FECHA_CARGA = Me.dteFECHA_CARGA.Date
        mENVIO.FECHA_PATIO = Me.dteFECHA_PATIO.Date
        mENVIO.ACCESLOTE = Me.hfucEnvioProforma("ACCESLOTE")
        mENVIO.SERVICIO_ROZA = IIf(Me.cbxID_PROVEEDOR_ROZA.Text <> "", True, False)
        If Me.cbxID_PROVEEDOR_ROZA.Value IsNot Nothing Then
            mENVIO.ID_PROVEEDOR_ROZA = Me.cbxID_PROVEEDOR_ROZA.Value
        Else
            mENVIO.ID_PROVEEDOR_ROZA = -1
        End If
        If Me.rblTRANS_PROPIEDAD.Value = 1 Then
            mENVIO.TRANSPORTE_PROPIO = True
        Else
            mENVIO.TRANSPORTE_PROPIO = False
        End If
        If idQR > 0 Then
            mENVIO.ES_QUERQUEO = True
        Else
            mENVIO.ES_QUERQUEO = False
        End If

        mENVIO.ES_BARRIDO = Me.chkBarrido.Checked
        mENVIO.ES_PRIMERENVIO_TURNO = Me.chkPrimerEnvioTurno.Checked
        mENVIO.ES_ULTENVIO_TURNO = Me.chkUltimoEnvioTurno.Checked
        mENVIO.ID_SUBLOTES = lProforma.ID_SUBLOTES

        'If TIPO_OPERACION = TipoOperacion.Recepcion AndAlso _
        '        Not (New cPLAN_COSECHA).EsEntregaProgramada(Me.cbxZAFRA.Value, Me.hfucEnvioProforma("ACCESLOTE"), cFechaHora.ObtenerFecha) Then
        '    Return "* La entrega de caña del Lote no ha sido programada para esta zafra."
        'End If

        If TIPO_OPERACION = TipoOperacion.Edicion Then
            If mcENVIO.ActualizarENVIOsinValidacion(mENVIO, TipoConcurrencia.Pesimistica) <> 1 Then
                Return "* Error al Guardar registro. " + mcENVIO.sError
            End If

            If idProveedorRozaAntesActualizar <> mENVIO.ID_PROVEEDOR_ROZA Then
                'Actualizar proveedor de roza en tabla ENVIO_ROZA_PS
                Dim bEnvioRozaPS As New cENVIO_ROZA_PS
                Dim lstEnvioRozaPS As ListaENVIO_ROZA_PS = (New cENVIO_ROZA_PS).ObtenerListaPorENVIO(mENVIO.ID_ENVIO)
                If lstEnvioRozaPS IsNot Nothing AndAlso lstEnvioRozaPS.Count > 0 Then
                    If lstEnvioRozaPS(0).ID_TIPO_ROZA_S = 21 Then
                        lstEnvioRozaPS(0).ID_PROVEEDOR_ROZA_P = mENVIO.ID_PROVEEDOR_ROZA
                        lstEnvioRozaPS(0).ID_PROVEEDOR_ROZA_S = mENVIO.ID_PROVEEDOR_ROZA
                        bEnvioRozaPS.ActualizarENVIO_ROZA_PS(lstEnvioRozaPS(0))
                    End If
                End If
            End If
        Else
            If mcENVIO.ActualizarENVIO(mENVIO) <> 1 Then
                If mcENVIO.sErrorTecnico = "2601" Then
                    MostrarMensaje(mcENVIO.sError, "Alerta")
                    Return ""
                End If
                Return mcENVIO.sError
            End If
        End If



        '*********************************************************************
        'Generar registro de servicio:  FRENTE DE CALIDAD EN ALZA Y TRANSPORTE

        'Dim lstEnvioFcat As listaENVIO_FACT = (New cENVIO_FACT).ObtenerListaPorENVIO(mENVIO.ID_ENVIO)
        'Dim bEnvioFcat As New cENVIO_FACT
        'Dim lEnvioFcat As ENVIO_FACT
        'If EsCargadoraJIBOA(Convert.ToInt32(Me.cbxCARGADORA.Value)) Then
        '    If lstEnvioFcat IsNot Nothing AndAlso lstEnvioFcat.Count > 0 Then
        '        For i As Integer = 0 To lstEnvioFcat.Count - 1
        '            bEnvioFcat.EliminarENVIO_FACT(lstEnvioFcat(i).ID_ENVIO_FACT)
        '        Next
        '    End If

        '    lEnvioFcat = New ENVIO_FACT
        '    lEnvioFcat.ID_ENVIO_FACT = 0
        '    lEnvioFcat.ID_ENVIO = mENVIO.ID_ENVIO
        '    lEnvioFcat.VALOR_TARIFA = 0.29
        '    lEnvioFcat.CODIGO_MOCHADOR = Me.txtCODIGO_MOCHADOR.Text
        '    lEnvioFcat.CODIGO_CHEQUERO = Me.txtCODIGO_CHEQUERO.Text
        '    lEnvioFcat.USUARIO_CREA = Me.ObtenerUsuario
        '    lEnvioFcat.FECHA_CREA = cFechaHora.ObtenerFechaHora
        '    lEnvioFcat.USUARIO_ACT = Me.ObtenerUsuario
        '    lEnvioFcat.FECHA_ACT = cFechaHora.ObtenerFechaHora
        '    bEnvioFcat.ActualizarENVIO_FACT(lEnvioFcat)
        'Else
        '    If lstEnvioFcat IsNot Nothing AndAlso lstEnvioFcat.Count > 0 Then
        '        For i As Integer = 0 To lstEnvioFcat.Count - 1
        '            bEnvioFcat.EliminarENVIO_FACT(lstEnvioFcat(i).ID_ENVIO_FACT)
        '        Next
        '    End If
        'End If

        '*********************************************************************
        'Generar registro de servicio: COSECHADORA DE BANDA
        Dim lstEnvioCosecha As listaENVIO_COSECHA_BANDA = (New cENVIO_COSECHA_BANDA).ObtenerListaPorENVIO(mENVIO.ID_ENVIO)
        Dim bEnvioCosecha As New cENVIO_COSECHA_BANDA
        Dim lEnvioCosecha As ENVIO_COSECHA_BANDA
        If EsCosechadoraBanda(Convert.ToInt32(Me.cbxCARGADORA.Value)) AndAlso Me.chkAUTOVOLTEO.Checked Then
            If lstEnvioCosecha IsNot Nothing AndAlso lstEnvioCosecha.Count > 0 Then
                For i As Integer = 0 To lstEnvioCosecha.Count - 1
                    bEnvioCosecha.EliminarENVIO_COSECHA_BANDA(lstEnvioCosecha(i).ID_ENVIO_BANDA)
                Next
            End If
            lEnvioCosecha = New ENVIO_COSECHA_BANDA
            lEnvioCosecha.ID_ENVIO_BANDA = 0
            lEnvioCosecha.ID_ENVIO = mENVIO.ID_ENVIO
            lEnvioCosecha.VALOR_TARIFA = 0.6
            lEnvioCosecha.USUARIO_CREA = Me.ObtenerUsuario
            lEnvioCosecha.FECHA_CREA = cFechaHora.ObtenerFechaHora
            lEnvioCosecha.USUARIO_ACT = Me.ObtenerUsuario
            lEnvioCosecha.FECHA_ACT = cFechaHora.ObtenerFechaHora
            If Me.cbxOPERADOR_TRACTOR1.Value IsNot Nothing Then
                lEnvioCosecha.ID_CARGADOR1 = Me.cbxOPERADOR_TRACTOR1.Value
            Else
                lEnvioCosecha.ID_CARGADOR1 = -1
            End If
            If Me.cbxOPERADOR_TRACTOR2.Value IsNot Nothing Then
                lEnvioCosecha.ID_CARGADOR2 = Me.cbxOPERADOR_TRACTOR2.Value
            Else
                lEnvioCosecha.ID_CARGADOR2 = -1
            End If
            bEnvioCosecha.ActualizarENVIO_COSECHA_BANDA(lEnvioCosecha)
        Else
            If lstEnvioCosecha IsNot Nothing AndAlso lstEnvioCosecha.Count > 0 Then
                For i As Integer = 0 To lstEnvioCosecha.Count - 1
                    bEnvioCosecha.EliminarENVIO_COSECHA_BANDA(lstEnvioCosecha(i).ID_ENVIO_BANDA)
                Next
            End If
        End If

        '*********************************************************************
        'Generar registro de servicio: MONITOR DE CALIDAD Y FRENTE DE QUERQUEO
        lRetMoniQQ = bEnvioMoniQQ.SP_SERVICIO_MONITOR_QUERQUEO("R", codiProveedor, mENVIO.ID_ENVIO, idMonitor, idQR)
        If lRetMoniQQ IsNot Nothing AndAlso lRetMoniQQ.Count > 0 AndAlso lRetMoniQQ(0).Keys(0) <> 0 Then
            Return lRetMoniQQ(0).Values(0).ToString
        End If


        If Me.txtNOPROFORMA.Text <> "" Then
            If lProforma IsNot Nothing AndAlso lProforma.ID_ENVIO <> mENVIO.ID_ENVIO Then
                lProforma.ID_ENVIO = mENVIO.ID_ENVIO
                lProforma.ESTADO = EstadoProforma.ConEnvio
                lProforma.USUARIO_ACT = Me.ObtenerUsuario
                lProforma.FECHA_ACT = cFechaHora.ObtenerFechaHora
                If mcPROFORMA.ActualizarPROFORMA(lProforma) <> 1 Then
                    Return "No se logro relacionar el proforma al envio: " + mcPROFORMA.sError
                End If
            End If
        End If
        If TIPO_OPERACION = TipoOperacion.Edicion OrElse TIPO_OPERACION = TipoOperacion.EdicionParcialBascula Then
            'Actualizar tipo de transporte si se requiere
            Dim bTransporte As New cTRANSPORTE
            Dim lTransporte As TRANSPORTE = (New cTRANSPORTE).ObtenerTRANSPORTEPorTRANSPORTISTA_PLACA(Convert.ToInt32(txtCODTRANSPORT.Text), Me.cbxPLACAVEHIC.Text)
            If lTransporte IsNot Nothing Then
                lTransporte.ID_TIPOTRANS = Me.cbxTIPO_TRANS.Value
                lTransporte.USUARIO_ACT = Me.ObtenerUsuario
                lTransporte.FECHA_ACT = cFechaHora.ObtenerFechaHora
                bTransporte.ActualizarTRANSPORTE(lTransporte)
            End If
        End If



        Me.AsignarMensaje("", True, False)
        Me.ViewState("ID_ENVIO") = mENVIO.ID_ENVIO
        Me._nuevo = False
        Me.AsignarMensaje("Registro guardado!", False, True, True)
        Return ""
    End Function

    Public Function Eliminar() As String
        Dim bEnvio As New cENVIO
        Dim lRet As Integer

        lRet = bEnvio.EliminarENVIO(Me.ID_ENVIO)
        If lRet < 0 Then
            Return "* " + bEnvio.sError
        Else
            Me.MostrarMensaje("Registro eliminado!")
        End If
        Return ""
    End Function

    Public Function Anular() As String
        Dim bEnvio As New cENVIO
        Dim lRet As Integer

        lRet = bEnvio.AnularENVIO(Me.ID_ENVIO)
        If lRet < 0 Then
            Return "* " + bEnvio.sError
        Else
            Me.MostrarMensaje("Registro anulado!")
        End If
        Return ""
    End Function

    Private Sub CargarDatosENVIO()
        Dim lTransportista As TRANSPORTISTA
        Dim lProveedor As PROVEEDOR
        Dim lSocio As PROVEEDOR
        Dim lContrato As CONTRATO
        Dim lProformas As listaPROFORMA
        Dim lMaestro As MAESTRO_LOTES
        Dim lSubLote As SUBLOTES

        Me._nuevo = False

        Dim sError As New String("")
        mENVIO = New ENVIO
        mENVIO.ID_ENVIO = Me.ID_ENVIO

        Me.AsignarMensaje("", True, False, False)

        If mcENVIO.ObtenerENVIO(mENVIO) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.cbxZAFRA.Value = mENVIO.ID_ZAFRA
        Me.txtCATORCENA_ZAFRA.Text = mENVIO.CATORCENA
        Me.txtDIAZAFRA.Text = mENVIO.DIAZAFRA
        Me.txtCOMPTENVIO.Text = mENVIO.COMPTENVIO
        lContrato = (New cCONTRATO).ObtenerCONTRATO(mENVIO.CODICONTRATO)
        Me.txtCODICONTRATO.Text = mENVIO.CODICONTRATO
        Me.hfucEnvioProforma("CODICONTRATO") = mENVIO.CODICONTRATO
        Me.txtNOCONTRATO.Value = lContrato.NO_CONTRATO
        lProveedor = (New cPROVEEDOR).ObtenerPROVEEDOR(lContrato.CODIPROVEEDOR)
        Me.txtCODIPROVEE.Value = CInt(lProveedor.CODIPROVEE)
        Dim lLote As LOTES = (New cLOTES).ObtenerLOTES(mENVIO.ACCESLOTE)
        If lLote IsNot Nothing Then
            Me.hfucEnvioProforma("ACCESLOTE") = lLote.ACCESLOTE
            Me.txtCODILOTE.Value = lLote.CODILOTE
            Me.txtNOMLOTE.Value = lLote.NOMBLOTE
            lMaestro = (New cMAESTRO_LOTES).ObtenerMAESTRO_LOTES(lLote.ID_MAESTRO)
            If lMaestro IsNot Nothing Then txtHACIENDA.Text = lMaestro.HACIENDA
        End If
        Dim lLoteCosecha As LOTES_COSECHA = (New cLOTES_COSECHA).ObtenerLOTES_COSECHAPorLOTE_ZAFRA(mENVIO.ACCESLOTE, mENVIO.ID_ZAFRA)
        If lLoteCosecha IsNot Nothing Then
            Dim lTecnico As AGRONOMO = (New cAGRONOMO).ObtenerAGRONOMO(lLoteCosecha.CODIAGRON)
            If lTecnico IsNot Nothing Then Me.txtTECNICO_ZONA.Text = lTecnico.NOMBRE_AGRONOMO + " " + lTecnico.APELLIDO_AGRONOMO
        End If

        lSocio = Nothing
        If lContrato.CODIPROVEEDOR <> lLote.CODIPROVEEDOR Then
            lSocio = (New cPROVEEDOR).ObtenerPROVEEDOR(lLote.CODIPROVEEDOR)
            Me.txtCODISOCIO.Value = lSocio.CODISOCIO
            Me.txtNOMPROVEEDOR.Text = lProveedor.NOMBRES.Trim + " " + lProveedor.APELLIDOS.Trim + "/" + lSocio.NOMBRES + " " + lSocio.APELLIDOS
        Else
            Me.txtNOMPROVEEDOR.Text = lProveedor.NOMBRES.Trim + " " + lProveedor.APELLIDOS.Trim
        End If
        Select Case mENVIO.ID_TIPO_CANA
            Case 19, 27
                Me.cbxID_TIPO_CANA.Value = CInt(CAT.TipoCana.Larga)
                ConfigPorTipoCana(CInt(CAT.TipoCana.Larga))
            Case 35, 43
                Me.cbxID_TIPO_CANA.Value = CInt(CAT.TipoCana.Corta)
                ConfigPorTipoCana(CAT.TipoCana.Corta)
            Case Else
                Me.cbxID_TIPO_CANA.Value = CInt(CAT.TipoCana.PicadaMecanizada)
                ConfigPorTipoCana(CInt(CAT.TipoCana.PicadaMecanizada))
        End Select
        Me.CargarTipoRoza()
        Me.cbxID_TIPO_ROZA.Value = mENVIO.ID_TIPO_ROZA
        Me.CargarProveedorRoza()
        If mENVIO.ID_PROVEEDOR_ROZA = -1 Then
            Me.cbxID_PROVEEDOR_ROZA.Value = Nothing
        Else
            Me.cbxID_PROVEEDOR_ROZA.Value = mENVIO.ID_PROVEEDOR_ROZA
        End If
        Me.CargarTipoAlza()
        Me.cbxID_TIPO_ALZA.Value = mENVIO.ID_TIPO_ALZA
        Me.CargarCargadoras()
        Me.cbxCARGADORA.Value = mENVIO.ID_CARGADORA
        Me.CargarCargadores()
        Me.cbxCARGADOR.Value = mENVIO.ID_CARGADOR

        Me.txtCODTRANSPORT.Text = mENVIO.CODTRANSPORT
        lTransportista = (New cTRANSPORTISTA).ObtenerTRANSPORTISTA(mENVIO.CODTRANSPORT)
        If mENVIO.TRANSPORTE_PROPIO Then
            Me.rblTRANS_PROPIEDAD.Value = 1
        Else
            Me.rblTRANS_PROPIEDAD.Value = 2
        End If

        Me.txtNOMBRE_TRANSPORTISTA.Text = lTransportista.NOMBRES + " " + lTransportista.APELLIDOS
        Me.CargarPlacas()
        If Me.cbxPLACAVEHIC.Items.FindByValue(mENVIO.PLACAVEHIC) IsNot Nothing Then
            Me.cbxPLACAVEHIC.Value = mENVIO.PLACAVEHIC
        Else
            Me.cbxPLACAVEHIC.Text = mENVIO.PLACAVEHIC
        End If
        Me.CargarMotoristas()
        If mENVIO.ID_MOTORISTA <> -1 Then Me.cbxMOTORISTA.Value = mENVIO.ID_MOTORISTA Else Me.cbxMOTORISTA.Text = mENVIO.NOMBRES_MOTORISTA
        Me.cbxTIPO_TRANS.Value = mENVIO.ID_TIPOTRANS

        Me.dteFECHA_CORTE.Value = mENVIO.FECHA_CORTA
        Me.dteFECHA_CARGA.Value = mENVIO.FECHA_CARGA
        Me.dteFECHA_PATIO.Value = mENVIO.FECHA_PATIO

        If mENVIO.FECHA_QUEMA <> #12:00:00 AM# Then
            If mENVIO.QUEMAPROG Then
                Me.rblTIPO_QUEMA.Value = 1
            Else
                Me.rblTIPO_QUEMA.Value = 2
            End If
        Else
            Me.rblTIPO_QUEMA.Value = 3
        End If

        If mENVIO.FECHA_QUEMA <> #12:00:00 AM# Then
            Me.dteFECHA_QUEMA.Value = mENVIO.FECHA_QUEMA
            Me.dteFECHA_QUEMA.ClientEnabled = (TIPO_OPERACION = TipoOperacion.Edicion OrElse TIPO_OPERACION = TipoOperacion.EdicionParcialBascula)
        Else
            Me.dteFECHA_QUEMA.ClientEnabled = False
        End If
        Me.txtNROBOLETA.Text = mENVIO.NROBOLETA
        Me.chkBarrido.Checked = mENVIO.ES_BARRIDO
        'Me.chkPrimerEnvioTurno.Checked = mENVIO.ES_PRIMERENVIO_TURNO
        'Me.chkPrimerEnvioTurno.Checked = mENVIO.ES_PRIMERENVIO_TURNO

        'If Me.EsCargadoraJIBOA(mENVIO.ID_CARGADORA) Then
        '    Dim lstEnvioFcat As listaENVIO_FACT = (New cENVIO_FACT).ObtenerListaPorENVIO(mENVIO.ID_ENVIO)
        '    Dim lPersonal As PERSONAL_FCAT

        '    If lstEnvioFcat IsNot Nothing AndAlso lstEnvioFcat.Count > 0 Then
        '        lPersonal = (New cPERSONAL_FCAT).ObtenerPorCODIGO(lstEnvioFcat(0).CODIGO_MOCHADOR)
        '        If lPersonal IsNot Nothing Then
        '            Me.txtCODIGO_MOCHADOR.Text = lPersonal.CODIGO
        '            Me.txtNOMBRE_MOCHADOR.Text = lPersonal.NOMBRE
        '        End If

        '        lPersonal = (New cPERSONAL_FCAT).ObtenerPorCODIGO(lstEnvioFcat(0).CODIGO_CHEQUERO)
        '        If lPersonal IsNot Nothing Then
        '            Me.txtCODIGO_CHEQUERO.Text = lPersonal.CODIGO
        '            Me.txtNOMBRE_CHEQUERO.Text = lPersonal.NOMBRE
        '        End If
        '    End If
        'End If


        Dim lstEnvioCosecha As listaENVIO_COSECHA_BANDA = (New cENVIO_COSECHA_BANDA).ObtenerListaPorENVIO(mENVIO.ID_ENVIO)
        If lstEnvioCosecha IsNot Nothing AndAlso lstEnvioCosecha.Count > 0 Then
            If lstEnvioCosecha(0).ID_CARGADOR1 > 0 Then
                Me.cbxOPERADOR_TRACTOR1.Value = lstEnvioCosecha(0).ID_CARGADOR1
            Else
                Me.cbxOPERADOR_TRACTOR1.Value = Nothing
            End If
            If lstEnvioCosecha(0).ID_CARGADOR2 > 0 Then
                Me.cbxOPERADOR_TRACTOR2.Value = lstEnvioCosecha(0).ID_CARGADOR2
            Else
                Me.cbxOPERADOR_TRACTOR2.Value = Nothing
            End If
            Me.chkAUTOVOLTEO.Checked = True
        Else
            Me.chkAUTOVOLTEO.Checked = False
        End If

        Me.chkQuerqueo.Checked = False
        Dim lstEnvioMoniCalQQ As listaENVIO_MONI_QQ = (New cENVIO_MONI_QQ).ObtenerListaPorENVIO(mENVIO.ID_ENVIO)
        If lstEnvioMoniCalQQ IsNot Nothing AndAlso lstEnvioMoniCalQQ.Count > 0 Then
            If lstEnvioMoniCalQQ(0).ID_MONITOR > 0 Then
                Dim lMonitor As MONITOR_CAL = (New cMONITOR_CAL).ObtenerMONITOR_CAL(lstEnvioMoniCalQQ(0).ID_MONITOR)
                If lMonitor IsNot Nothing Then Me.txtCOD_MONITOR.Text = lMonitor.CODISIS
            End If
            If lstEnvioMoniCalQQ(0).ID_PROVEE_QQ > 0 Then
                Me.cbxPROVEEDOR_QUERQUEO.Value = lstEnvioMoniCalQQ(0).ID_PROVEE_QQ
                Me.chkQuerqueo.Checked = True
            End If
        End If

        lProformas = (New cPROFORMA).ObtenerListaPorENVIO(mENVIO.ID_ENVIO)
        If lProformas IsNot Nothing AndAlso lProformas.Count > 0 Then Me.txtNOPROFORMA.Text = lProformas(0).NOPROFORMA.ToString
        'Obtener porción
        lSubLote = (New cSUBLOTES).ObtenerSUBLOTES(mENVIO.ID_SUBLOTES)
        If lSubLote IsNot Nothing Then Me.txtSUBLOTE.Text = lSubLote.CODIGO + " " + lSubLote.NOMBRE_PORCION
    End Sub

    Public Function AnularProforma() As String
        Dim sError As New StringBuilder
        Dim bProforma As New cPROFORMA
        Dim lProforma As New PROFORMA
        Dim lLoteCosecha As LOTES_COSECHA
        Dim bLoteCosecha As New cLOTES_COSECHA
        Dim lControlRoza As CONTROL_ROZA
        Dim lControlRozaProforma As CONTROL_ROZA
        Dim bControlRoza As New cCONTROL_ROZA
        Dim lDiaZafra As New DIA_ZAFRA
        Dim ds As DataSet


        lProforma = bProforma.ObtenerPROFORMA(Me.ID_PROFORMA)

        If lProforma.ESTADO = EstadoProforma.Anulado Then
            Return "* El proforma ya fue anulado"
        End If

        If Me.cbxMOTIVO_ANULACION_PROFORMA.Value = Nothing Then
            Return "* Seleccione un motivo de la lista"
        End If
        If Me.cbxMOTIVO_ANULACION_PROFORMA.Text = "OTRO" AndAlso Me.txtOBSERVA_ANUL.Text.Trim.Length > 300 Then
            Return "* El motivo de anulación contiene mas de 300 caracteres. Reduzcalo"
        End If
        If Me.cbxMOTIVO_ANULACION_PROFORMA.Text = "OTRO" AndAlso Me.txtOBSERVA_ANUL.Text.Trim.Length < 15 Then
            Return "* El motivo de anulación debe tener al menos 15 caracteres"
        End If

        'Validar que el estado sea en transito o rueda
        If (lProforma.ESTADO <> EstadoProforma.Transito AndAlso lProforma.ESTADO <> EstadoProforma.Rueda) OrElse lProforma.ID_ENVIO <> -1 Then
            Return "* No se puede Anular el proforma ya que esta asociado a un envio"
        End If

        lProforma.ESTADO = EstadoProforma.Anulado
        If Me.cbxMOTIVO_ANULACION_PROFORMA.Text = "OTRO" Then
            lProforma.OBSERVA_ANUL = Me.cbxMOTIVO_ANULACION_PROFORMA.Text + " " + Me.txtOBSERVA_ANUL.Text.Trim.ToUpper
        Else
            lProforma.OBSERVA_ANUL = Me.cbxMOTIVO_ANULACION_PROFORMA.Text
        End If
        lProforma.USUARIO_ANUL = Me.ObtenerUsuario
        lProforma.FECHA_ANUL = cFechaHora.ObtenerFechaHora
        lProforma.USUARIO_ACT = Me.ObtenerUsuario
        lProforma.FECHA_ACT = cFechaHora.ObtenerFechaHora
        If bProforma.ActualizarPROFORMA(lProforma) <= 0 Then
            Return "* No se logro Anular el Proforma"
        End If
        ds = bProforma.SP_CC_ASIGNAR_LOTE_TRANS("PROFORMA ANULADO", lProforma.ID_ZAFRA, 0, 0, Me.ObtenerUsuario, lProforma.ID_PROFORMA)
        If ds IsNot Nothing Then
            If ds.Tables(0).Rows(0)("CODIGO").ToString() <> 0 Then
                Return "* Error en actualizacion de transporte asignado: " + ds.Tables(0).Rows(0)("MENSAJE").ToString()
            End If
        End If

        lControlRozaProforma = bControlRoza.ObtenerPorIdREF_CodigoREF(lProforma.ID_PROFORMA, "PROFORMA")

        If lControlRozaProforma IsNot Nothing Then
            '***** Crear movimiento en Control de Roza
            lLoteCosecha = (New cLOTES_COSECHA).ObtenerLOTES_COSECHAPorLOTE_ZAFRA(lProforma.ACCESLOTE, lProforma.ID_ZAFRA)
            If lLoteCosecha IsNot Nothing Then
                lLoteCosecha.SALDO_ROZA = lLoteCosecha.SALDO_ROZA + lProforma.TONELADAS
            End If

            lControlRoza = New CONTROL_ROZA
            lControlRoza.ID_CONTROL_ROZA = 0
            lControlRoza.ID_ZAFRA = lLoteCosecha.ID_ZAFRA
            lControlRoza.ACCESLOTE = lLoteCosecha.ACCESLOTE
            lDiaZafra = (New cDIA_ZAFRA).ObtenerDiaZafraActivo(lProforma.ID_ZAFRA)
            If lDiaZafra IsNot Nothing Then lControlRoza.DIAZAFRA = lDiaZafra.DIAZAFRA
            lControlRoza.CONCEPTO = "ANULACION DE PROFORMA N° " + lProforma.NOPROFORMA.ToString
            lControlRoza.CODIGO_REF = "PROFORMA"
            lControlRoza.ID_REF = lProforma.ID_PROFORMA
            lControlRoza.ENTRADAS = lProforma.TONELADAS
            lControlRoza.SALIDAS = 0
            lControlRoza.SALDO = lLoteCosecha.SALDO_ROZA
            lControlRoza.USUARIO_CREA = Me.ObtenerUsuario
            lControlRoza.FECHA_CREA = cFechaHora.ObtenerFechaHora
            lControlRoza.USUARIO_ACT = Me.ObtenerUsuario
            lControlRoza.FECHA_ACT = cFechaHora.ObtenerFechaHora
            lControlRoza.FECHA_HORA_ROZA = lProforma.FECHA_ROZA
            lControlRoza.ID_PROVEEDOR_ROZA = -1
            lControlRoza.ID_TIPO_CANA = -1
            lControlRoza.ID_TIPO_ROZA = -1
            lControlRoza.QUEMA_NOPROG = False
            lControlRoza.QUEMA_PROGRAMADA = False
            lControlRoza.CANA_VERDE = False
            lControlRoza.FECHA_HORA_QUEMA = Nothing
            lControlRoza.ID_ROZA_SALDO = lControlRozaProforma.ID_ROZA_SALDO
            lControlRoza.ES_PROYECCION = lControlRozaProforma.ES_PROYECCION
            lControlRoza.ES_QUERQUEO = lControlRozaProforma.ES_QUERQUEO
            lControlRoza.ID_PROVEE_QQ = lControlRozaProforma.ID_PROVEE_QQ
            lControlRoza.ID_SUBLOTES = lProforma.ID_SUBLOTES
            If bControlRoza.ActualizarCONTROL_ROZA(lControlRoza) < 1 Then
                Return "Error al crear el movimiento de roza del Lote: " + bControlRoza.sError
            End If

            '***** Actualizar Saldo de Roza
            If lLoteCosecha IsNot Nothing Then
                If bLoteCosecha.ActualizarLOTES_COSECHA(lLoteCosecha) < 0 Then
                    Return "Error al actualizar el Saldo del Lote para esta Zafra: " + bLoteCosecha.sError
                End If
            End If
        End If


        AsignarMensaje("El Proforma se anulo con exito.", False, True, True)
        Return ""
    End Function

    Public Function EmitirProforma() As String
        Dim sError As New StringBuilder
        Dim bProforma As New cPROFORMA
        Dim lProforma As New PROFORMA
        Dim lDiaZafra As DIA_ZAFRA
        Dim lLote As LOTES
        Dim bLoteCosecha As New cLOTES_COSECHA
        Dim lLoteCosecha As LOTES_COSECHA = (New cLOTES_COSECHA).ObtenerLOTES_COSECHA(Me.ID_LOTES_COSECHA)
        Dim lstControlRozaSaldo As listaCONTROL_ROZA_SALDO
        Dim bControlRoza As New cCONTROL_ROZA
        Dim lControlRoza As CONTROL_ROZA
        Dim lMovtoMargenRoza As CONTROL_ROZA
        Dim lAplicacionesMadurante As listaSOLIC_APLICA_LOTE
        Dim bCapacidadTrans As New cCAPACIDAD_TIPO_TRANS
        Dim dSaldoRoza As Decimal = 0


        lstControlRozaSaldo = Me.ucListaCONTROL_ROZA_SALDO1.DevolverSeleccionados
        If lstControlRozaSaldo Is Nothing OrElse lstControlRozaSaldo.Count = 0 Then
            sError.AppendLine(" * Seleccione un Inventario de Roza.")
        End If
        If Me.cbxZAFRA.Value Is Nothing Then
            sError.AppendLine(" * No existe Periodo de Zafra.")
        End If
        If Me.txtNOCONTRATO.Text = "" Then
            sError.AppendLine(" * Ingrese el Contrato.")
        End If
        If Me.txtCODILOTE.Text = "" Then
            sError.AppendLine(" * Seleccione un lote.")
        End If
        If Me.txtCODTRANSPORT.Text.Trim = String.Empty Then
            sError.AppendLine(" * Ingrese el codigo de Transportista.")
        Else
            Dim lTransportista As TRANSPORTISTA = (New cTRANSPORTISTA).ObtenerTRANSPORTISTA(Me.txtCODTRANSPORT.Text.Trim)
            If lTransportista Is Nothing Then
                sError.AppendLine(" * Transportista no existe en el sistema.")
            End If
        End If
        If Me.cbxPLACAVEHIC.Text.Trim = String.Empty Then
            sError.AppendLine(" * Ingrese el numero de placa.")
        End If
        If Me.cbxMOTORISTA.Text = "" OrElse cbxMOTORISTA.Value Is Nothing Then
            sError.AppendLine(" * Seleccione o ingrese el nombre del motorista.")
        End If
        If Me.cbxCARGADORA.Value Is Nothing OrElse Me.cbxCARGADORA.Text = "" Then
            sError.AppendLine(" * Seleccione la Cargadora/Cosechadora.")
        End If
        'If Me.cbxCARGADOR.ClientEnabled AndAlso (Me.cbxCARGADOR.Value Is Nothing OrElse Me.cbxCARGADOR.Text = "") Then
        '    sError.AppendLine(" * Seleccione el Operador de la  cargadora.")
        'End If
        If Me.cbxID_TIPO_CANA.Value Is Nothing OrElse Me.cbxID_TIPO_CANA.Text = "" Then
            sError.AppendLine(" * Seleccione la Forma de Cosecha.")
        End If
        If Me.rblTIPO_QUEMA.Value Is Nothing Then
            sError.AppendLine(" * Seleccione el Tipo de Quema.")
        End If
        If Me.rblTRANS_PROPIEDAD.Value Is Nothing Then
            sError.AppendLine(" * Seleccione si el transporte es particular o propio.")
        End If
        If Me.cbxTIPO_TRANS.Value Is Nothing OrElse Me.cbxTIPO_TRANS.Text = "" Then
            sError.AppendLine(" * Seleccione el tipo de transporte.")
        End If
        If Me.dteFECHA_QUEMA.Value Is Nothing AndAlso (Me.rblTIPO_QUEMA.Value = 1 OrElse Me.rblTIPO_QUEMA.Value = 2) Then
            sError.AppendLine(" * Ingrese fecha de quema.")
        End If
        If Me.rblTIPO_QUEMA.Value <> 3 Then
            If dteFECHA_QUEMA.Date < DateAdd(DateInterval.Day, -30, cFechaHora.ObtenerFechaHora) Then
                sError.AppendLine(" * Fecha de quema no puede ser menor a 30 dias de la fecha de ingreso al sistema.")
            End If
        End If
        If Me.dteFECHA_CORTE.Value Is Nothing Then
            sError.AppendLine(" * Ingrese fecha de corta.")
        End If
        If Me.dteFECHA_CARGA.ClientEnabled AndAlso Me.dteFECHA_CARGA.Value IsNot Nothing Then
            If dteFECHA_PATIO.Value < Me.dteFECHA_CARGA.Date Then
                sError.AppendLine(" Fecha de ingreso a Jiboa no puede ser menor a la fecha de Cargado")
            End If
            If dteFECHA_CARGA.Value < Me.dteFECHA_CORTE.Date Then
                sError.AppendLine(" Fecha de Cargado no puede ser menor a la fecha de Corte")
            End If
        End If

        If (Me.rblTIPO_QUEMA.Value = 1 OrElse Me.rblTIPO_QUEMA.Value = 2) Then
            If Me.dteFECHA_QUEMA.Date > Me.dteFECHA_CORTE.Date Then
                sError.AppendLine(" * Fecha de quema no puede ser mayor a fecha de corta.")
            End If
            'If Me.dteFECHA_QUEMA.Date > cFechaHora.ObtenerFechaHora Then
            '    sError.AppendLine(" * Fecha de quema no puede ser mayor a la fecha del sistema.")
            'End If
        End If
        'If Me.dteFECHA_CORTE.Date > cFechaHora.ObtenerFechaHora Then
        '    sError.AppendLine(" * Fecha de corta no puede ser mayor a la fecha del sistema.")
        'End If
        'Verificar si hay proformas que no tengan estado PATIO
        Dim listaProformas As listaPROFORMA = (New cPROFORMA).ObtenerListaPorZAFRA_PLACAVEHIC(Me.cbxZAFRA.Value, Me.cbxPLACAVEHIC.Text, True)
        If listaProformas IsNot Nothing AndAlso listaProformas.Count > 0 Then
            Dim j As Int32 = 0
            Dim infoLotes As New StringBuilder
            Dim lLoteProforma As New LOTES

            For i As Int32 = 0 To listaProformas.Count - 1
                j += 1
                lLoteProforma = (New cLOTES).ObtenerLOTES(listaProformas(i).ACCESLOTE)
                If lLoteProforma IsNot Nothing Then
                    Dim lProveeProforma As PROVEEDOR = (New cPROVEEDOR).ObtenerPROVEEDOR(lLoteProforma.CODIPROVEEDOR)
                    If lProveeProforma IsNot Nothing Then
                        infoLotes.Append("No. Proforma: " + listaProformas(i).NOPROFORMA.ToString + ", ")
                        infoLotes.Append("Emitido: " + listaProformas(i).FECHA_CREA.ToString("dd/MM/yyy HH:mm") + ", ")
                        infoLotes.Append("Estado: " + listaProformas(i).ESTADO + ", ")
                        infoLotes.Append("Productor: " + lProveeProforma.NOMBRES + " " + lProveeProforma.APELLIDOS + ", ")
                        infoLotes.AppendLine("Lote: " + lLoteProforma.CODILOTE + " " + lLoteProforma.NOMBLOTE)
                    End If
                End If
            Next
            If j > 0 Then
                sError.AppendLine(" * Existe " + j.ToString + " proforma(s) para la placa " + Me.cbxPLACAVEHIC.Text + " que estan pendientes de ingresar a patio.")
                sError.AppendLine(infoLotes.ToString)
            End If
        End If

        If sError.ToString <> "" Then
            Return sError.ToString
        End If

        lLote = (New cLOTES).ObtenerLOTES(lLoteCosecha.ACCESLOTE)
        lProforma.ID_PROFORMA = 0
        lProforma.ID_ZAFRA = Me.cbxZAFRA.Value
        lDiaZafra = (New cDIA_ZAFRA).ObtenerDiaZafraActivo(lProforma.ID_ZAFRA)
        If lDiaZafra IsNot Nothing Then lProforma.DIAZAFRA = lDiaZafra.DIAZAFRA
        lProforma.NOPROFORMA = bProforma.ObtenerNoProformaPorZafra(lProforma.ID_ZAFRA)
        lProforma.CODICONTRATO = Me.txtCODICONTRATO.Text
        lProforma.CODIPROVEEDOR = lLote.CODIPROVEEDOR
        lProforma.ACCESLOTE = lLote.ACCESLOTE
        lProforma.CODTRANSPORT = Me.txtCODTRANSPORT.Value
        lProforma.NOMBRES_MOTORISTA = Me.cbxMOTORISTA.Text.ToUpper
        lProforma.ID_TIPO_CANA = Me.cbxID_TIPO_CANA.Value

        If Me.cbxCARGADORA.Value IsNot Nothing AndAlso IsNumeric(Me.cbxCARGADORA.Value) AndAlso Me.cbxCARGADORA.Value > 0 Then
            lProforma.ID_CARGADORA = Me.cbxCARGADORA.Value
        Else
            lProforma.ID_CARGADORA = -1
        End If

        'lProforma.ID_CARGADORA = -1
        lProforma.ID_CARGADOR = -1
        lProforma.ID_SUPERVISOR = -1
        Select Case CInt(Me.rblTIPO_QUEMA.Value)
            Case 1
                lProforma.QUEMAPROG = True
                lProforma.FECHA_QUEMA = dteFECHA_QUEMA.Date
            Case 2
                lProforma.QUEMANOPROG = True
                lProforma.FECHA_QUEMA = dteFECHA_QUEMA.Date
            Case 3
                lProforma.CANA_VERDE = True
                lProforma.FECHA_QUEMA = Nothing
        End Select

        'lProforma.SERVICIO_ROZA = IIf(Me.cbxID_PROVEEDOR_ROZA.Value = Nothing, False, True)
        lProforma.SERVICIO_ROZA = False
        'lProforma.ID_PROVEEDOR_ROZA = IIf(Me.cbxID_PROVEEDOR_ROZA.Value = Nothing, -1, Me.cbxID_PROVEEDOR_ROZA.Value)
        lProforma.ID_PROVEEDOR_ROZA = -1
        lProforma.FECHA_ROZA = Me.dteFECHA_CORTE.Date
        lProforma.FECHA_CORTA = Nothing
        lProforma.FECHA_PATIO = Nothing
        lProforma.ID_PRODUCTO = -1
        lProforma.FIN_LOTE = False
        lProforma.PLACAVEHIC = Me.cbxPLACAVEHIC.Text
        lProforma.ID_TIPOTRANS = Me.cbxTIPO_TRANS.Value

        If Me.rblTRANS_PROPIEDAD.Value = 1 Then
            lProforma.TRANSPORTE_PROPIO = True
        Else
            lProforma.TRANSPORTE_PROPIO = False
        End If
        'If cbxCARGADOR.Text <> "" Then
        '    lProforma.ID_CARGADOR = Me.cbxCARGADOR.Value
        'Else
        '    lProforma.ID_CARGADOR = -1
        'End If
        lProforma.ID_CARGADOR = -1
        lProforma.TIPO_TARIFA_CARGADORA = -1
        If Utilerias.EsNumeroEntero(Me.cbxMOTORISTA.Value) Then
            lProforma.ID_MOTORISTA = Me.cbxMOTORISTA.Value
        Else
            lProforma.ID_MOTORISTA = -1
        End If
        lProforma.ID_TIPO_ROZA = Me.cbxID_TIPO_ROZA.Value
        'lProforma.ID_TIPO_ALZA = Me.cbxID_TIPO_ALZA.Value
        lProforma.ID_TIPO_ALZA = -1
        lProforma.OBSERVACIONES = Nothing
        lProforma.ID_ENVIO = -1
        lProforma.ESTADO = EstadoProforma.Transito
        lProforma.USUARIO_CREA = Me.ObtenerUsuario
        lProforma.FECHA_CREA = cFechaHora.ObtenerFechaHora
        lProforma.USUARIO_ACT = Me.ObtenerUsuario
        lProforma.FECHA_ACT = cFechaHora.ObtenerFechaHora
        If Me.cbxPROVEEDOR_QUERQUEO.Value IsNot Nothing AndAlso CInt(cbxPROVEEDOR_QUERQUEO.Value) > 0 Then
            lProforma.ES_QUERQUEO = True
            lProforma.ID_PROVEE_QQ = CInt(cbxPROVEEDOR_QUERQUEO.Value)
        Else
            lProforma.ES_QUERQUEO = False
            lProforma.ID_PROVEE_QQ = -1
        End If

        lProforma.ES_BARRIDA = Me.chkBarrido.Checked

        If Me.dteFECHA_CARGA.ClientEnabled AndAlso Me.dteFECHA_CARGA.Value IsNot Nothing Then
            lProforma.FECHA_CORTA = Me.dteFECHA_CARGA.Date
            lProforma.ESTADO = EstadoProforma.Rueda
        End If

        lAplicacionesMadurante = (New cSOLIC_APLICA_LOTE).ObtenerListaPorZAFRA_LOTE(CInt(Me.cbxZAFRA.Value), lLote.ACCESLOTE, "", "DESC")
        If lAplicacionesMadurante IsNot Nothing AndAlso lAplicacionesMadurante.Count > 0 Then
            lProforma.ID_PRODUCTO = lAplicacionesMadurante(0).ID_PRODUCTO
            lProforma.FECHA_MADURANTE = lAplicacionesMadurante(0).FECHA_APLICA
        Else
            lProforma.ID_PRODUCTO = -1
            lProforma.FECHA_MADURANTE = #12:00:00 AM#
        End If

        If lstControlRozaSaldo(0).SALDO <= 0 Then
            Return "* El saldo de roza del lote no permite emitir proforma. Saldo roza:" + lLoteCosecha.SALDO_ROZA.ToString("#,##0.00")
        End If

        'Estableciendo la capacidad por tipo de transporte
        lProforma.TONELADAS = bCapacidadTrans.ObtenerCapacidadPorTIPO_CANA_TIPO_TRANS(lProforma.ID_TIPOTRANS)
        'Select Case lProforma.ID_TIPOTRANS
        '    Case 19
        '        If rblTRANS_PROPIEDAD.Value = 1 Then
        '            lProforma.TONELADAS = bCapacidadTrans.ObtenerCapacidadPorTIPO_CANA_TIPO_TRANS(lProforma.ID_TIPO_CANA, CAT.TipoTransporte.CamionProductor)
        '        Else
        '            lProforma.TONELADAS = bCapacidadTrans.ObtenerCapacidadPorTIPO_CANA_TIPO_TRANS(lProforma.ID_TIPO_CANA, CAT.TipoTransporte.CamionParticular)
        '        End If
        '    Case 20
        '        If rblTRANS_PROPIEDAD.Value = 1 Then
        '            lProforma.TONELADAS = bCapacidadTrans.ObtenerCapacidadPorTIPO_CANA_TIPO_TRANS(lProforma.ID_TIPO_CANA, CAT.TipoTransporte.RastraProductor)
        '        Else
        '            lProforma.TONELADAS = bCapacidadTrans.ObtenerCapacidadPorTIPO_CANA_TIPO_TRANS(lProforma.ID_TIPO_CANA, CAT.TipoTransporte.RastraParticular)
        '        End If
        '    Case 21
        '        If rblTRANS_PROPIEDAD.Value = 1 Then
        '            lProforma.TONELADAS = bCapacidadTrans.ObtenerCapacidadPorTIPO_CANA_TIPO_TRANS(lProforma.ID_TIPO_CANA, CAT.TipoTransporte._3EjesProductor)
        '        Else
        '            lProforma.TONELADAS = bCapacidadTrans.ObtenerCapacidadPorTIPO_CANA_TIPO_TRANS(lProforma.ID_TIPO_CANA, CAT.TipoTransporte._3EjesParticular)
        '        End If
        '    Case 28
        '        If rblTRANS_PROPIEDAD.Value = 1 Then
        '            lProforma.TONELADAS = bCapacidadTrans.ObtenerCapacidadPorTIPO_CANA_TIPO_TRANS(lProforma.ID_TIPO_CANA, CAT.TipoTransporte.Camion7TonParticular)
        '        Else
        '            lProforma.TONELADAS = bCapacidadTrans.ObtenerCapacidadPorTIPO_CANA_TIPO_TRANS(lProforma.ID_TIPO_CANA, CAT.TipoTransporte.Camion7TonProductor)
        '        End If
        'End Select

        If lProforma.TONELADAS <= 0 Then
            Return "* No se ha establecido la capacidad del transporte para el tipo de cana y tipo de transporte"
        End If
        If lProforma.TONELADAS > lstControlRozaSaldo(0).SALDO Then
            Return "* El saldo de roza es menor a la capacidad del vehiculo que es de " + lProforma.TONELADAS.ToString + " Tons. Debe aumentarse la roza"
            'lProforma.TONELADAS = lstControlRozaSaldo(0).SALDO
        End If
        '***** Asignar proforma
        lProforma.ID_SUBLOTES = lstControlRozaSaldo(0).ID_SUBLOTES

        '***** Crear proforma
        If bProforma.ActualizarPROFORMA(lProforma) <> 1 Then
            Return "Error al emitir Proforma: " + bProforma.sError
        End If

        '***** Crear movimiento en Control de Roza
        lControlRoza = New CONTROL_ROZA
        lControlRoza.ID_CONTROL_ROZA = 0
        lControlRoza.ID_ZAFRA = lLoteCosecha.ID_ZAFRA
        lControlRoza.ACCESLOTE = lLoteCosecha.ACCESLOTE
        lControlRoza.DIAZAFRA = lDiaZafra.DIAZAFRA
        lControlRoza.CONCEPTO = "EMISION DE PROFORMA N° " + lProforma.NOPROFORMA.ToString
        lControlRoza.CODIGO_REF = "PROFORMA"
        lControlRoza.ID_REF = lProforma.ID_PROFORMA
        lControlRoza.ENTRADAS = 0
        lControlRoza.SALIDAS = lProforma.TONELADAS
        lControlRoza.SALDO = lstControlRozaSaldo(0).SALDO - lProforma.TONELADAS
        lControlRoza.USUARIO_CREA = Me.ObtenerUsuario
        lControlRoza.FECHA_CREA = cFechaHora.ObtenerFechaHora
        lControlRoza.USUARIO_ACT = Me.ObtenerUsuario
        lControlRoza.FECHA_ACT = cFechaHora.ObtenerFechaHora
        lControlRoza.FECHA_HORA_ROZA = lstControlRozaSaldo(0).FECHA_HORA_ROZA
        lControlRoza.ID_PROVEEDOR_ROZA = lstControlRozaSaldo(0).ID_PROVEEDOR_ROZA
        lControlRoza.ID_TIPO_CANA = lstControlRozaSaldo(0).ID_TIPO_CANA
        lControlRoza.ID_TIPO_ROZA = lstControlRozaSaldo(0).ID_TIPO_ROZA
        lControlRoza.QUEMA_NOPROG = lstControlRozaSaldo(0).QUEMA_NOPROG
        lControlRoza.QUEMA_PROGRAMADA = lstControlRozaSaldo(0).QUEMA_PROGRAMADA
        lControlRoza.CANA_VERDE = lstControlRozaSaldo(0).CANA_VERDE
        lControlRoza.FECHA_HORA_QUEMA = lstControlRozaSaldo(0).FECHA_HORA_QUEMA
        lControlRoza.ID_ROZA_SALDO = lstControlRozaSaldo(0).ID_ROZA_SALDO
        lControlRoza.ES_PROYECCION = lstControlRozaSaldo(0).ES_PROYECCION
        lControlRoza.ID_SUBLOTES = lstControlRozaSaldo(0).ID_SUBLOTES
        If Me.cbxPROVEEDOR_QUERQUEO.Value IsNot Nothing AndAlso CInt(cbxPROVEEDOR_QUERQUEO.Value) > 0 Then
            lControlRoza.ES_QUERQUEO = True
            lControlRoza.ID_PROVEE_QQ = CInt(cbxPROVEEDOR_QUERQUEO.Value)
        Else
            lControlRoza.ES_QUERQUEO = False
            lControlRoza.ID_PROVEE_QQ = -1
        End If
        If bControlRoza.ActualizarCONTROL_ROZA(lControlRoza) < 1 Then
            lLoteCosecha.FECHA_ACT = cFechaHora.ObtenerFechaHora
            bLoteCosecha.ActualizarLOTES_COSECHA(lLoteCosecha)
            Return "Error al crear el movimiento de roza del Lote: " + bControlRoza.sError
        End If

        '***** Actualizar Saldo de Roza        
        lLoteCosecha.SALDO_ROZA = lLoteCosecha.SALDO_ROZA - lProforma.TONELADAS
        lLoteCosecha.USUARIO_ACT = Me.ObtenerUsuario
        lLoteCosecha.FECHA_ACT = cFechaHora.ObtenerFechaHora
        If bLoteCosecha.ActualizarLOTES_COSECHA(lLoteCosecha) < 1 Then
            Return "Error al actualizar el Saldo del Lote para esta Zafra: " + bLoteCosecha.sError
        End If

        '***** Generar disponibilidad
        lMovtoMargenRoza = bControlRoza.CrearDisponibilidadCuotaRoza(lstControlRozaSaldo(0).ID_ROZA_SALDO, Me.ObtenerUsuario)

        AsignarMensaje("El Proforma se emitio con exito.", False, True, True)

        'Mostrar reporte de proforma
        ScriptManager.RegisterClientScriptBlock(Me, Page.GetType, "script", "MostrarProforma(" + lProforma.ID_PROFORMA.ToString + ")", True)
        Return ""
    End Function

    Public Function ActualizarProforma() As String
        Dim lProFormaAntes As PROFORMA = mcPROFORMA.ObtenerPROFORMAPorNumZafra(Me.txtNOPROFORMA.Value, Me.cbxZAFRA.Value)
        If Me.txtNOPROFORMA.Value Is Nothing Then
            Return "* Ingrese el No. de Proforma"
        End If
        If Me.dteFECHA_CARGA.Value Is Nothing Then
            Return "* Ingrese la fecha de Cargado"
        End If
        mPROFORMA = mcPROFORMA.ObtenerPROFORMAPorNumZafra(Me.txtNOPROFORMA.Value, Me.cbxZAFRA.Value)
        If mPROFORMA Is Nothing Then
            Return "* No. de Proforma invalido"
        End If

        If Me.TIPO_OPERACION = TipoOperacion.CambioFechaQuemaRoza Then
            If mPROFORMA.ESTADO = EstadoProforma.ConEnvio OrElse mPROFORMA.ESTADO = EstadoProforma.Patio OrElse mPROFORMA.ESTADO = EstadoProforma.Tara Then
                Return "* El proforma tiene un estado no valido para el cambio de fechas"
            End If
            If (Me.rblTIPO_QUEMA.Value = 1 OrElse Me.rblTIPO_QUEMA.Value = 2) AndAlso Me.dteFECHA_QUEMA.Value Is Nothing Then
                Return "* Ingrese la fecha de quema"
            End If
            If (Me.rblTIPO_QUEMA.Value = 1 OrElse Me.rblTIPO_QUEMA.Value = 2) Then
                If Me.dteFECHA_QUEMA.Date > Me.dteFECHA_CORTE.Date Then
                    Return "* Fecha de quema no puede ser mayor a fecha de corta"
                End If
                If Me.dteFECHA_QUEMA.Date > cFechaHora.ObtenerFechaHora Then
                    Return "* Fecha de quema no puede ser mayor a la fecha del sistema"
                End If
            End If
            If Me.dteFECHA_CORTE.Date > Me.dteFECHA_CARGA.Date Then
                Return "* Fecha de corta no puede ser mayor a fecha de carga"
            End If
            If Me.dteFECHA_CORTE.Date > cFechaHora.ObtenerFechaHora Then
                Return "* Fecha de corta no puede ser mayor a la fecha del sistema"
            End If

            If (Me.rblTIPO_QUEMA.Value = 1 OrElse Me.rblTIPO_QUEMA.Value = 2) Then
                mPROFORMA.FECHA_QUEMA = Me.dteFECHA_QUEMA.Date
            End If
        End If

        'If dteFECHA_PATIO.Value < Me.dteFECHA_CARGA.Date Then
        '    Return "* Fecha de ingreso a Jiboa no puede ser menor a la fecha de Cargado"
        'End If
        If dteFECHA_CARGA.Value < Me.dteFECHA_CORTE.Date Then
            Return "* Fecha de Cargado no puede ser menor a la fecha de Corte"
        End If

        mPROFORMA.FECHA_ROZA = Me.dteFECHA_CORTE.Date
        mPROFORMA.FECHA_CORTA = Me.dteFECHA_CARGA.Date 'TODO: Cambiar a fecha de carga
        mPROFORMA.FECHA_PATIO = dteFECHA_PATIO.Value
        mPROFORMA.ES_QUERQUEO = Me.chkQuerqueo.Checked
        mPROFORMA.ES_BARRIDA = Me.chkBarrido.Checked
        mPROFORMA.USUARIO_ACT = Me.ObtenerUsuario
        mPROFORMA.FECHA_ACT = cFechaHora.ObtenerFechaHora
        If mPROFORMA.ESTADO = EstadoProforma.Transito Then
            mPROFORMA.ESTADO = EstadoProforma.Rueda
        End If
        If mcPROFORMA.ActualizarPROFORMA(mPROFORMA) <> 1 Then
            Return "* Error al Registrar Proforma: " + mcPROFORMA.sError
        End If
        mcPROFORMA.SP_CC_ASIGNAR_LOTE_TRANS("ACTUALIZAR ESTADO PROFORMA", -1, -1, -1, Me.ObtenerUsuario, mPROFORMA.ID_PROFORMA)

        'If lProFormaAntes.FECHA_QUEMA <> mPROFORMA.FECHA_QUEMA OrElse lProFormaAntes.FECHA_ROZA <> mPROFORMA.FECHA_ROZA Then
        '    Dim lCtrlRoza As CONTROL_ROZA = (New cCONTROL_ROZA).ObtenerPorIdREF_CodigoREF(mPROFORMA.ID_PROFORMA, "PROFORMA")
        '    Dim lRozaSaldo As CONTROL_ROZA_SALDO
        '    Dim bControlRozaSaldo As New cCONTROL_ROZA_SALDO
        '    Dim bControlRoza As New cCONTROL_ROZA
        '    Dim bEnvio As New cENVIO

        '    If lCtrlRoza IsNot Nothing Then

        '        'Actualizar bolsón de Roza Saldo
        '        lRozaSaldo = (New cCONTROL_ROZA_SALDO).ObtenerCONTROL_ROZA_SALDO(lCtrlRoza.ID_ROZA_SALDO)
        '        lRozaSaldo.FECHA_HORA_QUEMA = mPROFORMA.FECHA_QUEMA
        '        lRozaSaldo.FECHA_HORA_ROZA = mPROFORMA.FECHA_ROZA
        '        bControlRozaSaldo.ActualizarCONTROL_ROZA_SALDO(lRozaSaldo)

        '        Dim lstMovtoRoza As listaCONTROL_ROZA = (New cCONTROL_ROZA).ObtenerListaPorCONTROL_ROZA_SALDO(lRozaSaldo.ID_ROZA_SALDO)

        '        For Each lEntidad As CONTROL_ROZA In lstMovtoRoza
        '            If lEntidad.CODIGO_REF = "PROFORMA" Then
        '                Dim lProforma As PROFORMA = (New cPROFORMA).ObtenerPROFORMA(lEntidad.ID_REF)
        '                If lProforma IsNot Nothing Then
        '                    If lProforma.ESTADO <> EstadoProforma.Tara Then

        '                        'Actualizar proformas del bolsón
        '                        lProforma.FECHA_QUEMA = mPROFORMA.FECHA_QUEMA
        '                        lProforma.FECHA_ROZA = mPROFORMA.FECHA_QUEMA
        '                        mcPROFORMA.ActualizarPROFORMA(lProforma)

        '                        'Actualizar movimientos de roza
        '                        lEntidad.FECHA_HORA_QUEMA = mPROFORMA.FECHA_QUEMA
        '                        lEntidad.FECHA_HORA_ROZA = mPROFORMA.FECHA_ROZA
        '                        bControlRoza.ActualizarCONTROL_ROZA(lEntidad)

        '                        Dim lEnvio As ENVIO = bEnvio.ObtenerENVIO(lProforma.ID_ENVIO)
        '                        If lEnvio IsNot Nothing AndAlso lEnvio.FECHA_QUEMA <> #12:00:00 AM# Then
        '                            'Validar que no tiene peso tara
        '                            Dim lstBascula As listaBASCULA = (New cBASCULA).ObtenerListaPorENVIO(lEnvio.ID_ENVIO)
        '                            Dim conPesoTara As Boolean = (lstBascula IsNot Nothing AndAlso lstBascula.Count > 0 AndAlso lstBascula(0).NETOLIBRAS > 0)

        '                            If Not conPesoTara Then
        '                                lEnvio.FECHA_QUEMA = mPROFORMA.FECHA_QUEMA
        '                                lEnvio.FECHA_CORTA = mPROFORMA.FECHA_ROZA
        '                                lEnvio.HORAS_QUEMA = 0
        '                                bEnvio.ActualizarENVIO(lEnvio)
        '                            End If
        '                        End If
        '                    End If
        '                End If
        '            End If
        '        Next
        '    End If
        'End If

        Me.AsignarMensaje("Proforma actualizado!", False, True, True)
        Me.txtNOPROFORMA.Focus()
        Return ""

    End Function

    Private Sub CargarDatosPROFORMA()
        Dim lTransportista As TRANSPORTISTA
        Dim lProveedor As PROVEEDOR
        Dim lSocio As PROVEEDOR
        Dim lContrato As CONTRATO
        Dim lMaestro As MAESTRO_LOTES
        Dim lSubLote As SUBLOTES

        If Me.TIPO_OPERACION <> TipoOperacion.Recepcion Then
            Me._nuevo = False
        End If

        Dim sError As New String("")
        mPROFORMA = New PROFORMA
        mPROFORMA.ID_PROFORMA = Me.ID_PROFORMA

        Me.AsignarMensaje("", True, False, False)

        If mcPROFORMA.ObtenerPROFORMA(mPROFORMA) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If

        Me.cbxZAFRA.Value = mPROFORMA.ID_ZAFRA
        Me.txtCOMPTENVIO.Text = ""
        Me.txtNOPROFORMA.Text = mPROFORMA.NOPROFORMA.ToString
        lContrato = (New cCONTRATO).ObtenerCONTRATO(mPROFORMA.CODICONTRATO)
        Me.txtCODICONTRATO.Text = mPROFORMA.CODICONTRATO
        Me.txtNOCONTRATO.Value = lContrato.NO_CONTRATO
        Me.hfucEnvioProforma("CODICONTRATO") = mPROFORMA.CODICONTRATO

        Dim lLote As LOTES = (New cLOTES).ObtenerLOTES(mPROFORMA.ACCESLOTE)
        If lLote IsNot Nothing Then
            Me.hfucEnvioProforma("ACCESLOTE") = lLote.ACCESLOTE
            Me.txtCODILOTE.Value = lLote.CODILOTE
            Me.txtNOMLOTE.Value = lLote.NOMBLOTE
            lMaestro = (New cMAESTRO_LOTES).ObtenerMAESTRO_LOTES(lLote.ID_MAESTRO)
            If lMaestro IsNot Nothing Then txtHACIENDA.Text = lMaestro.HACIENDA
        End If

        Dim lLoteCosecha As LOTES_COSECHA = (New cLOTES_COSECHA).ObtenerLOTES_COSECHAPorLOTE_ZAFRA(mPROFORMA.ACCESLOTE, mPROFORMA.ID_ZAFRA)
        If lLoteCosecha IsNot Nothing Then
            Dim lTecnico As AGRONOMO = (New cAGRONOMO).ObtenerAGRONOMO(lLoteCosecha.CODIAGRON)
            If lTecnico IsNot Nothing Then Me.txtTECNICO_ZONA.Text = lTecnico.NOMBRE_AGRONOMO + " " + lTecnico.APELLIDO_AGRONOMO
        End If

        lProveedor = (New cPROVEEDOR).ObtenerPROVEEDOR(lContrato.CODIPROVEEDOR)
        Me.txtCODIPROVEE.Value = CInt(lProveedor.CODIPROVEE)

        lSocio = Nothing
        If lContrato.CODIPROVEEDOR <> lLote.CODIPROVEEDOR Then
            lSocio = (New cPROVEEDOR).ObtenerPROVEEDOR(lLote.CODIPROVEEDOR)
            Me.txtCODISOCIO.Value = lSocio.CODISOCIO
            Me.txtNOMPROVEEDOR.Text = lProveedor.NOMBRES.Trim + " " + lProveedor.APELLIDOS.Trim + "/" + lSocio.NOMBRES + " " + lSocio.APELLIDOS
        Else
            Me.txtNOMPROVEEDOR.Text = lProveedor.NOMBRES.Trim + " " + lProveedor.APELLIDOS.Trim
        End If
        If mPROFORMA.ID_PROVEE_QQ > 0 Then
            Me.chkQuerqueo.Checked = True
            Me.cbxPROVEEDOR_QUERQUEO.Value = CInt(mPROFORMA.ID_PROVEE_QQ)
        Else
            Me.chkQuerqueo.Checked = False
            Me.cbxPROVEEDOR_QUERQUEO.Value = -1
        End If

        Me.cbxID_TIPO_CANA.Value = mPROFORMA.ID_TIPO_CANA
        Select Case True
            Case mPROFORMA.QUEMAPROG
                Me.rblTIPO_QUEMA.Value = 1
                Me.dteFECHA_QUEMA.Value = mPROFORMA.FECHA_QUEMA
                Me.dteFECHA_QUEMA.ClientEnabled = (TIPO_OPERACION = TipoOperacion.Edicion OrElse TIPO_OPERACION = TipoOperacion.EdicionParcialBascula)
            Case mPROFORMA.QUEMANOPROG
                Me.rblTIPO_QUEMA.Value = 2
                Me.dteFECHA_QUEMA.Value = mPROFORMA.FECHA_QUEMA
                Me.dteFECHA_QUEMA.ClientEnabled = (TIPO_OPERACION = TipoOperacion.Edicion OrElse TIPO_OPERACION = TipoOperacion.EdicionParcialBascula)
            Case Else
                Me.rblTIPO_QUEMA.Value = 3
                Me.dteFECHA_QUEMA.Value = Nothing
                Me.dteFECHA_QUEMA.Text = ""
                Me.dteFECHA_QUEMA.ClientEnabled = False
        End Select
        Me.CargarTipoRoza()
        Me.cbxID_TIPO_ROZA.Value = mPROFORMA.ID_TIPO_ROZA
        Me.CargarProveedorRoza()
        If mPROFORMA.ID_PROVEEDOR_ROZA = -1 Then
            Me.cbxID_PROVEEDOR_ROZA.Value = Nothing
        Else
            Me.cbxID_PROVEEDOR_ROZA.Value = mPROFORMA.ID_PROVEEDOR_ROZA
        End If
        Me.CargarTipoAlza()
        Me.cbxID_TIPO_ALZA.Value = IIf(mPROFORMA.ID_TIPO_ALZA <> -1, mPROFORMA.ID_TIPO_ALZA, Nothing)
        Me.CargarCargadorasTodas()
        Me.cbxCARGADORA.Value = IIf(mPROFORMA.ID_CARGADORA <> -1, mPROFORMA.ID_CARGADORA, Nothing)

        Me.ConfigurarCodigosMocheroCherquero(mPROFORMA.ID_CARGADORA, True)
        Me.ConfigurarOperadoresTractor(mPROFORMA.ID_CARGADORA, True)

        Me.CargarCargadores()
        If mPROFORMA.ID_TIPO_ALZA = Enumeradores.CAT.TipoAlza.AlzaManualParticular OrElse mPROFORMA.ID_TIPO_ALZA = Enumeradores.CAT.TipoAlza.AlzaManualProductor Then
            Me.cbxCARGADOR.ClientEnabled = False
        Else
            Me.cbxCARGADOR.ClientEnabled = True
        End If
        If mPROFORMA.ID_CARGADOR <> -1 Then
            Me.cbxCARGADOR.Value = mPROFORMA.ID_CARGADOR
        Else
            Me.cbxCARGADOR.Value = Nothing
        End If

        Me.txtCODTRANSPORT.Text = mPROFORMA.CODTRANSPORT
        lTransportista = (New cTRANSPORTISTA).ObtenerTRANSPORTISTA(mPROFORMA.CODTRANSPORT)
        If mPROFORMA.TRANSPORTE_PROPIO Then
            Me.rblTRANS_PROPIEDAD.Value = 1
        Else
            Me.rblTRANS_PROPIEDAD.Value = 2
        End If
        If lTransportista IsNot Nothing Then
            Me.txtNOMBRE_TRANSPORTISTA.Text = lTransportista.NOMBRES + " " + lTransportista.APELLIDOS
        End If

        Me.CargarPlacas()
        If Me.cbxPLACAVEHIC.Items.FindByValue(mPROFORMA.PLACAVEHIC) IsNot Nothing Then
            Me.cbxPLACAVEHIC.Value = mPROFORMA.PLACAVEHIC
        Else
            Me.cbxPLACAVEHIC.Text = mPROFORMA.PLACAVEHIC
        End If
        Me.CargarMotoristas()
        If mPROFORMA.ID_MOTORISTA <> -1 Then
            Dim lMotoVehi As MOTORISTA_VEHICULO = (New cMOTORISTA_VEHICULO).ObtenerMOTORISTA_VEHICULOPorTRANSPORTISTA_PLACA(mPROFORMA.CODTRANSPORT, mPROFORMA.PLACAVEHIC)
            If lMotoVehi IsNot Nothing Then
                Me.speID_MOTORISTA_VEHI.Value = lMotoVehi.ID_MOTORISTA_VEHI
            End If
            Me.cbxMOTORISTA.Value = mPROFORMA.ID_MOTORISTA
        Else
            Me.cbxMOTORISTA.Text = mPROFORMA.NOMBRES_MOTORISTA
        End If
        Me.CargarTipoTransporte()
        Me.cbxTIPO_TRANS.Value = mPROFORMA.ID_TIPOTRANS
        Me.dteFECHA_CORTE.Value = mPROFORMA.FECHA_ROZA
        Me.dteFECHA_CORTE.ClientEnabled = True
        Me.dteFECHA_CARGA.Value = mPROFORMA.FECHA_CORTA
        If mPROFORMA.ESTADO = Enumeradores.EstadoProforma.Anulado Then
            Me.txtOBSERVA_ANUL.Text = mPROFORMA.OBSERVA_ANUL
        End If
        If TIPO_OPERACION = TipoOperacion.RegistroProforma OrElse TIPO_OPERACION = TipoOperacion.CambioFechaQuemaRoza Then
            Me.dteFECHA_PATIO.Value = If(mPROFORMA.FECHA_PATIO <> Nothing, mPROFORMA.FECHA_PATIO, cFechaHora.ObtenerFechaHora)
        Else
            Me.dteFECHA_PATIO.Value = If(mPROFORMA.FECHA_PATIO <> Nothing, mPROFORMA.FECHA_PATIO, Nothing)
        End If
        Me.chkQuerqueo.Checked = mPROFORMA.ES_QUERQUEO
        Me.chkBarrido.Checked = mPROFORMA.ES_BARRIDA
        Me.txtNROBOLETA.Text = ""
        If mPROFORMA.TRANSPORTE_PROPIO Then
            Me.rblTRANS_PROPIEDAD.Value = 1
        Else
            Me.rblTRANS_PROPIEDAD.Value = 2
        End If
        Me.cbxTIPO_TRANS.Value = mPROFORMA.ID_TIPOTRANS
        Me.ConfigurarOperadoresTractor(mPROFORMA.ID_CARGADORA, True)
        If mPROFORMA.ID_ENVIO > 0 Then
            Dim lEnvio As ENVIO = (New cENVIO).ObtenerENVIO(mPROFORMA.ID_ENVIO)
            If lEnvio IsNot Nothing Then
                Me.txtCATORCENA_ZAFRA.Text = lEnvio.CATORCENA.ToString
                Me.txtDIAZAFRA.Text = lEnvio.DIAZAFRA.ToString
                Me.txtNROBOLETA.Text = lEnvio.NROBOLETA.ToString
                Me.txtCOMPTENVIO.Text = lEnvio.COMPTENVIO.ToString
            End If
        End If
        'Datos del SUBLOTE/PORCION
        lSubLote = (New cSUBLOTES).ObtenerSUBLOTES(mPROFORMA.ID_SUBLOTES)
        If lSubLote IsNot Nothing Then
            Me.txtSUBLOTE.Text = lSubLote.CODIGO + " " + lSubLote.NOMBRE_PORCION
        End If
    End Sub

    Private Sub ConfigurarCodigosMocheroCherquero(ByVal idCargadora As Integer, ByVal habilitar As Boolean)
        Dim lCargadora As CARGADORA = (New cCARGADORA).ObtenerCARGADORA(idCargadora)
        If lCargadora IsNot Nothing AndAlso EsCargadoraJIBOA(idCargadora) Then
            Me.txtCODIGO_MOCHADOR.ClientEnabled = habilitar
            Me.txtCODIGO_CHEQUERO.ClientEnabled = habilitar
        Else
            Me.txtCODIGO_MOCHADOR.ClientEnabled = False
            Me.txtCODIGO_CHEQUERO.ClientEnabled = False
        End If
        Me.txtCODIGO_CHEQUERO.Text = ""
        Me.txtCODIGO_MOCHADOR.Text = ""
        Me.txtNOMBRE_CHEQUERO.Text = ""
        Me.txtNOMBRE_MOCHADOR.Text = ""
    End Sub

    Private Sub ConfigurarOperadoresTractor(ByVal idCargadora As Integer, ByVal habilitar As Boolean)
        Dim lCargadora As CARGADORA = (New cCARGADORA).ObtenerCARGADORA(idCargadora)
        If EsCosechadoraBanda(idCargadora) Then
            'Me.cbxOPERADOR_TRACTOR1.ClientEnabled = habilitar
            'Me.cbxOPERADOR_TRACTOR2.ClientEnabled = habilitar
            Me.chkAUTOVOLTEO.ClientEnabled = True
        Else
            Me.chkAUTOVOLTEO.Checked = False
            Me.chkAUTOVOLTEO.ClientEnabled = False
            Me.cbxOPERADOR_TRACTOR1.Value = Nothing
            Me.cbxOPERADOR_TRACTOR2.Value = Nothing
            Me.cbxOPERADOR_TRACTOR1.ClientEnabled = False
            Me.cbxOPERADOR_TRACTOR2.ClientEnabled = False
        End If
    End Sub

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If IsPostBack Then
            If Me.cbxID_TIPO_ALZA.Value IsNot Nothing Then
                If Me.cbxCARGADORA.Value IsNot Nothing Then
                    Me.CargarCargadoras(Me.cbxCARGADORA.Value)
                Else
                    Me.CargarCargadoras()
                End If
            End If
        End If
        CargarCargadoresAux()
        CargarMotoristasAux()
        SetInfoControlesRoza()
    End Sub

    Private Sub CargarTipoRoza()
        Dim lOrigen As listaTIPOS_GENERALES = (New cTIPOS_GENERALES).ObtenerListaPorCriterios(-1, Enumeradores.CAT.TipoCAT.Roza, -1)
        Dim lDestino As New listaTIPOS_GENERALES

        If cbxID_TIPO_CANA.Value IsNot Nothing Then
            Dim lPermitido As List(Of Int32) = configuracion.RozaEnTipoCana(CInt(cbxID_TIPO_CANA.Value))
            For Each lTipo As TIPOS_GENERALES In lOrigen
                If lPermitido.Contains(lTipo.ID_TIPO) Then
                    lDestino.Add(lTipo)
                End If
            Next
        End If
        Me.cbxID_TIPO_ROZA.DataSource = lDestino
        Me.cbxID_TIPO_ROZA.DataBind()
        Me.cbxID_TIPO_ROZA.Text = ""
    End Sub

    Private Sub CargarTipoAlza(Optional Limpiar As Boolean = True)
        Dim lOrigen As listaTIPOS_GENERALES = (New cTIPOS_GENERALES).ObtenerListaPorCriterios(-1, Enumeradores.CAT.TipoCAT.Alza, -1)
        Dim lDestino As New listaTIPOS_GENERALES

        If cbxID_TIPO_CANA.Value IsNot Nothing AndAlso cbxID_TIPO_ROZA.Value IsNot Nothing Then
            Dim lPermitido As List(Of Int32) = configuracion.AlzaEnTipoCana(CInt(cbxID_TIPO_CANA.Value), CInt(cbxID_TIPO_ROZA.Value))
            For Each lTipo As TIPOS_GENERALES In lOrigen
                If lPermitido.Contains(lTipo.ID_TIPO) Then
                    lDestino.Add(lTipo)
                End If
            Next
        End If
        Me.cbxID_TIPO_ALZA.DataSource = lDestino
        Me.cbxID_TIPO_ALZA.DataBind()
        If Limpiar Then Me.cbxID_TIPO_ALZA.Text = ""
    End Sub

    Private Sub CargarCargadoresAux()
        Dim lCargadores As New listaCARGADOR

        If Me.cbxCARGADORA.Value IsNot Nothing Then
            Dim lCargadora As CARGADORA = (New cCARGADORA).ObtenerCARGADORA(cbxCARGADORA.Value)
            If lCargadora IsNot Nothing Then
                lCargadores = (New cCARGADOR).ObtenerListaPorTIPO_CARGADORA(lCargadora.ID_TIPO_ALZA)
            End If
            If lCargadores Is Nothing Then lCargadores = New listaCARGADOR
            Me.cbxCARGADOR.DataSource = lCargadores
            Me.cbxCARGADOR.DataBind()
        End If
    End Sub

    Private Sub CargarCargadores()
        Dim lCargadores As New listaCARGADOR

        Me.cbxCARGADOR.Text = ""
        If Me.cbxCARGADORA.Value IsNot Nothing Then
            Dim lCargadora As CARGADORA = (New cCARGADORA).ObtenerCARGADORA(cbxCARGADORA.Value)
            If lCargadora IsNot Nothing Then
                lCargadores = (New cCARGADOR).ObtenerListaPorTIPO_CARGADORA(lCargadora.ID_TIPO_ALZA)
                Me.cbxCARGADOR.DataSource = lCargadores
                Me.cbxCARGADOR.DataBind()
                If Me.cbxCARGADOR.Items.Count = 1 Then Me.cbxCARGADOR.SelectedIndex = 0
            End If
        End If
    End Sub

    Private Sub CargarCargadorasTodas(Optional ID_CARGADORA As Int32 = -1)
        Dim lCargadoras As New listaCARGADORA
        Me.cbxCARGADORA.Text = ""
        lCargadoras = (New cCARGADORA).ObtenerListaActivas
        Me.cbxCARGADORA.DataSource = lCargadoras
        Me.cbxCARGADORA.DataBind()
        If ID_CARGADORA <> -1 AndAlso Me.cbxCARGADORA.Items.FindByValue(ID_CARGADORA) IsNot Nothing Then
            Me.cbxCARGADORA.SelectedItem = Me.cbxCARGADORA.Items.FindByValue(ID_CARGADORA)
        Else
            If Me.cbxCARGADORA.Items.Count = 1 Then Me.cbxCARGADORA.SelectedIndex = 0
        End If
    End Sub

    Private Sub CargarCargadoras(Optional ID_CARGADORA As Int32 = -1)
        Dim lCargadoras As New listaCARGADORA
        Me.cbxCARGADORA.Text = ""
        lCargadoras = (New cCARGADORA).ObtenerListaPorTIPO_ALZA(Me.cbxID_TIPO_ALZA.Value)
        Me.cbxCARGADORA.DataSource = lCargadoras
        Me.cbxCARGADORA.DataBind()
        If ID_CARGADORA <> -1 AndAlso Me.cbxCARGADORA.Items.FindByValue(ID_CARGADORA) IsNot Nothing Then
            Me.cbxCARGADORA.SelectedItem = Me.cbxCARGADORA.Items.FindByValue(ID_CARGADORA)
        Else
            If Me.cbxCARGADORA.Items.Count = 1 Then Me.cbxCARGADORA.SelectedIndex = 0
        End If
    End Sub

    Private Sub CargarCargadorasManual()
        Dim lCargadoras As New listaCARGADORA
        Dim lCargadora As CARGADORA
        Me.cbxCARGADORA.Text = ""
        If Me.cbxID_TIPO_ALZA.Value = CAT.TipoAlza.AlzaManualProductor Then 'Productor
            lCargadora = (New cCARGADORA).ObtenerCARGADORA(33)
            lCargadoras.Add(lCargadora)
        ElseIf Me.cbxID_TIPO_ALZA.Value = CAT.TipoAlza.AlzaManualParticular Then 'Particular
            lCargadora = (New cCARGADORA).ObtenerCARGADORA(34)
            lCargadoras.Add(lCargadora)
        End If
        Me.cbxCARGADORA.DataSource = lCargadoras
        Me.cbxCARGADORA.DataBind()
        If Me.cbxCARGADORA.Items.Count = 1 Then Me.cbxCARGADORA.SelectedIndex = 0
    End Sub


    Private Sub ConfigurarEncabezado()
        Dim entZafra As New ZAFRA
        entZafra = (New cZAFRA).ObtenerZafraActiva()
        If entZafra IsNot Nothing Then
            Me.cbxZAFRA.Value = entZafra.ID_ZAFRA
            If Me.TIPO_OPERACION <> TipoOperacion.Consulta Then
                Me.txtCATORCENA_ZAFRA.Text = entZafra.CATORCENA.ToString
                Me.txtDIAZAFRA.Text = entZafra.DIAZAFRA.ToString
            End If
        End If
    End Sub

    Private Sub Nuevo()
        Me._nuevo = True
        If Me.hfucEnvioProforma.Contains("ACCESLOTE") Then Me.hfucEnvioProforma("ACCESLOTE") = ""
        Me.txtCATORCENA_ZAFRA.Text = ""
        Me.txtDIAZAFRA.Text = ""
        Me.ConfigurarEncabezado()
        Me.txtNOPROFORMA.Value = Nothing
        Me.txtNROBOLETA.Value = Nothing
        Me.txtCOMPTENVIO.Value = Nothing
        Me.txtCODICONTRATO.Value = Nothing
        Me.txtNOCONTRATO.Value = Nothing
        Me.txtCODIPROVEE.Value = Nothing
        Me.txtCODISOCIO.Value = Nothing
        Me.txtNOMPROVEEDOR.Value = Nothing
        Me.txtCODILOTE.Value = Nothing
        Me.txtNOMLOTE.Value = Nothing
        Me.txtHACIENDA.Text = ""
        Me.txtCODTRANSPORT.Value = Nothing
        Me.txtNOMBRE_TRANSPORTISTA.Value = Nothing
        Me.rblTRANS_PROPIEDAD.Value = Nothing
        Me.cbxPLACAVEHIC.DataSource = New listaTRANSPORTE
        Me.cbxPLACAVEHIC.DataBind()
        Me.cbxPLACAVEHIC.Value = Nothing
        Me.cbxMOTORISTA.DataSource = New listaMOTORISTA
        Me.cbxMOTORISTA.DataBind()
        Me.cbxMOTORISTA.Value = Nothing
        Me.cbxID_TIPO_CANA.Value = Nothing
        Me.rblTIPO_QUEMA.Value = Nothing
        Me.txtDISPONIBLE.Value = Nothing
        Me.cbxID_TIPO_ROZA.Value = Nothing
        Me.cbxID_TIPO_ALZA.Value = Nothing
        Me.cbxID_PROVEEDOR_ROZA.Value = Nothing
        Me.cbxCARGADORA.Value = Nothing
        Me.cbxCARGADOR.Value = Nothing
        Me.cbxTIPO_TRANS.Value = Nothing
        Me.txtOBSERVA_ANUL.Text = ""
        Me.txtTECNICO_ZONA.Text = ""

        Me.speID_MOTORISTA_VEHI.Value = Nothing
        Me.dteFECHA_QUEMA.Text = ""
        Me.dteFECHA_CORTE.Text = ""
        Me.dteFECHA_CARGA.Text = ""
        Me.dteFECHA_PATIO.Text = ""
        Me.cbxSUPERVISOR.Value = Nothing
        Me.chkQuerqueo.Checked = False
        Me.chkBarrido.Checked = False
        Me.CargarTipoTransporte()
        Me.CargarMotoristas()

        Me.txtCODIGO_MOCHADOR.Text = ""
        Me.txtCODIGO_CHEQUERO.Text = ""
        Me.txtNOMBRE_CHEQUERO.Text = ""
        Me.txtNOMBRE_MOCHADOR.Text = ""
        Me.cbxOPERADOR_TRACTOR1.Value = Nothing
        Me.cbxOPERADOR_TRACTOR2.Value = Nothing
        Me.chkAUTOVOLTEO.Checked = False
        If Me.TIPO_OPERACION = TipoOperacion.EmisionProforma OrElse Me.TIPO_OPERACION = TipoOperacion.RegistroProforma Then
            Me.chkVerTodosProveedoresRoza.ClientVisible = False
            Me.cbxID_PROVEEDOR_ROZA.ClientVisible = False
            Me.lblTIPO_CARGA.ClientVisible = False
            Me.cbxID_TIPO_ALZA.ClientVisible = False
            Me.lblCARGADORA.ClientVisible = True
            Me.cbxCARGADORA.ClientVisible = True
            Me.lblOPERADOR.ClientVisible = False
            Me.cbxCARGADOR.ClientVisible = False
        Else
            Me.chkVerTodosProveedoresRoza.ClientVisible = True
            Me.cbxID_PROVEEDOR_ROZA.ClientVisible = True
            Me.lblTIPO_CARGA.ClientVisible = True
            Me.cbxID_TIPO_ALZA.ClientVisible = True
            Me.lblCARGADORA.ClientVisible = True
            Me.cbxCARGADORA.ClientVisible = True
            Me.lblOPERADOR.ClientVisible = True
            Me.cbxCARGADOR.ClientVisible = True
            Me.trQUERQUEO_BARRIDA.Visible = True
            Me.trFCAT.Visible = False
            Me.trOPERADORES_TRACTOR.Visible = True
        End If
        Me.cbxOPERADOR_TRACTOR1.ClientEnabled = False
        Me.cbxOPERADOR_TRACTOR2.ClientEnabled = False
        Me.chkAUTOVOLTEO.ClientEnabled = False
        Me.txtCOD_MONITOR.Text = ""
        Me.cbxPROVEEDOR_QUERQUEO.Value = Nothing
        Me.txtSUBLOTE.ClientEnabled = False
        Me.txtSUBLOTE.Text = ""
    End Sub

    Protected Sub txtNROBOLETA_ValueChanged(sender As Object, e As System.EventArgs) Handles txtNROBOLETA.ValueChanged
        If TIPO_OPERACION = TipoOperacion.Recepcion Then
            'Verificar que no se utiliza el número de boleta para esta zafra
            Dim lista As listaENVIO
            Dim bEnvio As New cENVIO

            If Me.txtNROBOLETA.Text.Trim <> String.Empty Then
                lista = bEnvio.ObtenerListaPorBOLETA(Me.cbxZAFRA.Value, Me.txtNROBOLETA.Value)
                If lista IsNot Nothing AndAlso lista.Count > 0 Then
                    Me.AsignarMensaje(" * El No. de Taco: " + txtNROBOLETA.Text + " ya se encuentra registrado para esta Zafra", True, False)
                    Me.txtNROBOLETA.Value = Nothing
                    Me.txtNROBOLETA.Focus()
                    Exit Sub
                End If
            End If
            txtCOMPTENVIO.Focus()

        ElseIf TIPO_OPERACION = TipoOperacion.Edicion OrElse TIPO_OPERACION = TipoOperacion.Consulta OrElse TipoOperacion.EdicionParcialBascula OrElse _
             TIPO_OPERACION = TipoOperacion.Eliminacion Then
            'Recuperar datos del taco
            Dim lista As listaENVIO
            Dim bEnvio As New cENVIO

            If Me.txtNROBOLETA.Text.Trim <> String.Empty Then
                lista = bEnvio.ObtenerListaPorBOLETA(Me.cbxZAFRA.Value, Me.txtNROBOLETA.Value)
                If lista IsNot Nothing AndAlso lista.Count > 0 Then
                    Me.Enabled = (TIPO_OPERACION = TipoOperacion.Edicion)
                    Me.ID_ENVIO = lista(0).ID_ENVIO
                    Exit Sub
                Else
                    Me.AsignarMensaje(" * El No. de Taco: " + txtNROBOLETA.Text + " no se encuentra registrado para esta Zafra", True)
                    Return
                End If
            End If
            txtCOMPTENVIO.Focus()
        End If
    End Sub

    Protected Sub txtCOMPTENVIO_ValueChanged(sender As Object, e As System.EventArgs) Handles txtCOMPTENVIO.ValueChanged
        If TIPO_OPERACION = TipoOperacion.Recepcion Then
            'Verificar que no se utiliza el número de taco para esta zafra
            Dim lista As listaENVIO
            Dim bEnvio As New cENVIO

            If Me.txtCOMPTENVIO.Text.Trim <> String.Empty Then
                lista = bEnvio.ObtenerListaPorCOMPROBANTE(Me.cbxZAFRA.Value, Me.txtCOMPTENVIO.Value)
                If lista IsNot Nothing AndAlso lista.Count > 0 Then
                    Me.AsignarMensaje(" * El No. de Comprobante: " + txtCOMPTENVIO.Text + " ya se encuentra registrado para esta Zafra", True, False)
                    Me.txtCOMPTENVIO.Text = ""
                    Me.txtCOMPTENVIO.Focus()
                    Exit Sub
                End If
            End If
        End If
        txtCODICONTRATO.Focus()
    End Sub

    Protected Sub txtNOCONTRATO_ValueChanged(sender As Object, e As System.EventArgs) Handles txtNOCONTRATO.ValueChanged
        Dim sCodiContrato As String = ""

        If TIPO_OPERACION = TipoOperacion.Recepcion OrElse TIPO_OPERACION = TipoOperacion.Edicion Then
            Me.txtCODIPROVEE.Value = Nothing
            Me.txtCODISOCIO.Value = Nothing
            Me.txtNOMPROVEEDOR.Value = Nothing

            If Me.txtNOCONTRATO.Value IsNot Nothing Then
                Dim lContratos As listaCONTRATO = (New cCONTRATO).ObtenerListaPorCriterios(Me.cbxZAFRA.Value, Me.txtNOCONTRATO.Value, "", "")
                Dim entProveedor As New PROVEEDOR

                If lContratos IsNot Nothing AndAlso lContratos.Count > 0 Then
                    entProveedor = (New cPROVEEDOR).ObtenerPROVEEDOR(lContratos(0).CODIPROVEEDOR)
                    If entProveedor IsNot Nothing Then
                        Me.txtCODIPROVEE.Value = CInt(entProveedor.CODIPROVEE)
                        Me.txtCODISOCIO.Value = Nothing
                        Me.txtNOMPROVEEDOR.Value = Trim(entProveedor.NOMBRES.TrimEnd + " " + entProveedor.APELLIDOS.TrimEnd)
                        'Me.hfucEnvioProforma("CODICONTRATO") = lContratos(0).CODICONTRATO
                    End If

                    'Mostrar popup lotes del contrato
                    'Me.MostrarLotesDelContrato()
                Else
                    AsignarMensaje(" * Contrato no esta registrado", True, False)
                    Me.txtCODICONTRATO.Value = Nothing
                    Me.txtCODICONTRATO.Focus()
                    Return
                End If
            End If
        End If
        Me.txtCODTRANSPORT.Focus()
    End Sub

    'Public Function MostrarLotesDelContrato() As String
    '    If Me.cbxZAFRA.Value Is Nothing Then
    '        Return "* No existe una Zafra activa"
    '    End If
    '    If Me.txtNOCONTRATO.Value Is Nothing OrElse Me.txtNOCONTRATO.Text = "" OrElse Me.txtCODIPROVEE.Value Is Nothing Then
    '        Return "* Ingrese un No. de Contrato"
    '    End If
    '    Me.lblpcError.Text = ""
    '    Me.pcLotesContratados.HeaderText = "Lotes del Contrato N° " + Me.txtNOCONTRATO.Text
    '    Me.ucListaLOTES1.CargarDatosPorZAFRA_NO_CONTRATO(Me.cbxZAFRA.Value, Me.txtNOCONTRATO.Value)
    '    Me.ucListaLOTES1.QuitarFiltros()
    '    Me.pcLotesContratados.ShowOnPageLoad = True
    '    Return ""
    'End Function

    'Public Function MostrarLotesProveedorEnZafra() As String
    '    If Me.cbxZAFRA.Value Is Nothing Then
    '        Return "* No existe una Zafra activa"
    '    End If
    '    If Me.txtNOCONTRATO.Value Is Nothing OrElse Me.txtNOCONTRATO.Text = "" OrElse Me.txtCODIPROVEE.Value Is Nothing Then
    '        If Me.TIPO_OPERACION = TipoOperacion.Recepcion Then
    '            Return "* Ingrese un No. de Contrato"
    '        ElseIf Me.TIPO_OPERACION = TipoOperacion.Edicion OrElse Me.TIPO_OPERACION = TipoOperacion.EdicionParcialBascula Then
    '            Return "* Ingrese el No de Taco"
    '        End If
    '    End If
    '    Dim lContratos As listaCONTRATO = (New cCONTRATO).ObtenerListaPorCriterios(Me.cbxZAFRA.Value, -1, Utilerias.FormatoCODIPROVEE(Me.txtCODIPROVEE.Value), "")
    '    If lContratos Is Nothing OrElse lContratos.Count = 0 Then
    '        Return "* No se encontraron contratos"
    '    End If
    '    Me.lblpcError.Text = ""
    '    Me.pcLotesContratados.HeaderText = "Lotes Contratados en Zafra " + Me.cbxZAFRA.Text + " del Proveedor " + Me.txtNOMPROVEEDOR.Text
    '    Me.ucListaLOTES1.CargarDatosPorZAFRA_CONTRATADA_PROVEEDOR_CONTRATADO(Me.cbxZAFRA.Value, lContratos(0).CODIPROVEEDOR, "")
    '    Me.ucListaLOTES1.QuitarFiltros()
    '    Me.pcLotesContratados.ShowOnPageLoad = True
    '    Return ""
    'End Function

    Protected Sub txtCODTRANSPORT_ValueChanged(sender As Object, e As System.EventArgs) Handles txtCODTRANSPORT.ValueChanged
        Me.MostrarInfoTransportista()
    End Sub

    Private Sub MostrarInfoTransportista()
        If txtCODTRANSPORT.Value Is Nothing Then Return

        Dim lTransportista As TRANSPORTISTA = (New cTRANSPORTISTA).ObtenerTRANSPORTISTA(txtCODTRANSPORT.Value)
        If lTransportista IsNot Nothing Then
            Me.txtNOMBRE_TRANSPORTISTA.Text = lTransportista.NOMBRES + " " + lTransportista.APELLIDOS
            Me.CargarPlacas()
            Me.cbxPLACAVEHIC.Focus()
        Else
            Me.txtCODTRANSPORT.Text = ""
            Me.txtNOMBRE_TRANSPORTISTA.Text = ""
        End If
    End Sub

    Private Sub MostrarInfoChequero()
        If txtCODIGO_CHEQUERO.Value Is Nothing Then Return

        Dim lEntidad As PERSONAL_FCAT = (New cPERSONAL_FCAT).ObtenerPorCODIGO(txtCODIGO_CHEQUERO.Text)
        If lEntidad IsNot Nothing AndAlso lEntidad.ES_CHEQUERO Then
            Me.txtNOMBRE_CHEQUERO.Text = lEntidad.NOMBRE
        Else
            Me.txtCODIGO_CHEQUERO.Text = ""
            Me.txtNOMBRE_CHEQUERO.Text = ""
        End If
    End Sub

    Private Sub MostrarInfoMochador()
        If txtCODIGO_MOCHADOR.Value Is Nothing Then Return

        Dim lEntidad As PERSONAL_FCAT = (New cPERSONAL_FCAT).ObtenerPorCODIGO(txtCODIGO_MOCHADOR.Text)
        If lEntidad IsNot Nothing AndAlso lEntidad.ES_MOCHADOR Then
            Me.txtNOMBRE_MOCHADOR.Text = lEntidad.NOMBRE
        Else
            Me.txtCODIGO_MOCHADOR.Text = ""
            Me.txtNOMBRE_MOCHADOR.Text = ""
        End If
    End Sub

    Private Sub CargarPlacas()
        Dim listaPlacas As New listaTRANSPORTE
        If txtCODTRANSPORT.Value IsNot Nothing AndAlso txtCODTRANSPORT.Text <> "" Then
            listaPlacas = (New cTRANSPORTE).ObtenerListaPorTRANSPORTISTA(Me.txtCODTRANSPORT.Value, False, False, "PLACA", "ASC")
        End If
        Me.cbxPLACAVEHIC.DataSource = listaPlacas
        Me.cbxPLACAVEHIC.DataBind()
    End Sub

    Private Sub CargarMotoristas()
        Dim listaMotoristas As New listaMOTORISTA

        If Me.cbxPLACAVEHIC.Value IsNot Nothing Then
            If Me.chkVerTodosMotoristas.Checked Then
                listaMotoristas = (New cMOTORISTA).ObtenerListaActivos()
            Else
                listaMotoristas = (New cMOTORISTA).ObtenerListaPorTRANSPORTE(Me.cbxPLACAVEHIC.Value)
            End If
        End If

        Me.cbxMOTORISTA.DataSource = listaMotoristas
        Me.cbxMOTORISTA.DataBind()
    End Sub

    Private Sub CargarMotoristasAux()
        Dim listaMotoristas As New listaMOTORISTA

        If Me.cbxPLACAVEHIC.Value IsNot Nothing Then
            If Me.chkVerTodosMotoristas.Checked Then
                listaMotoristas = (New cMOTORISTA).ObtenerListaActivos()
            Else
                listaMotoristas = (New cMOTORISTA).ObtenerListaPorTRANSPORTE(Me.cbxPLACAVEHIC.Value)
            End If
        End If

        Me.cbxMOTORISTA.DataSource = listaMotoristas
        Me.cbxMOTORISTA.DataBind()
    End Sub

    Public Sub TipoTransporte_Enabled(ByVal valor As Boolean)
        Me.cbxTIPO_TRANS.ClientEnabled = False
    End Sub

    Public Sub TipoTransporte_Value(ByVal valor As Object)
        If valor Is Nothing Then
            Me.cbxTIPO_TRANS.Value = Nothing
        ElseIf Utilerias.EsNumeroEntero(valor) Then
            Me.cbxTIPO_TRANS.Value = valor
        End If
    End Sub

    Protected Sub cbxPLACAVEHIC_ValueChanged(sender As Object, e As System.EventArgs) Handles cbxPLACAVEHIC.ValueChanged
        If Me.cbxPLACAVEHIC.Text = "" Then
            Me.TipoTransporte_Value(Nothing)
            Me.TipoTransporte_Enabled(False)
            Me.cbxMOTORISTA.Focus()
            Return
        End If
        If Me.cbxPLACAVEHIC.Value IsNot Nothing Then
            If Me.cbxPLACAVEHIC.Items.FindByTextWithTrim(Me.cbxPLACAVEHIC.Text) Is Nothing Then
                Me.TipoTransporte_Value(Nothing)
                Me.TipoTransporte_Enabled(True)
                Me.cbxMOTORISTA.Focus()
                Return
            End If
            Dim lTransporte As TRANSPORTE = (New cTRANSPORTE).ObtenerTRANSPORTE(Me.cbxPLACAVEHIC.Value)
            If lTransporte IsNot Nothing Then
                Me.TipoTransporte_Value(lTransporte.ID_TIPOTRANS)
                Me.TipoTransporte_Enabled(True)
                Me.cbxMOTORISTA.Focus()
            Else
                Me.TipoTransporte_Value(Nothing)
                Me.TipoTransporte_Enabled(True)
                Me.cbxMOTORISTA.Focus()
            End If
        Else
            Me.TipoTransporte_Value(Nothing)
            Me.TipoTransporte_Enabled(True)
            Me.cbxMOTORISTA.Focus()
        End If
    End Sub

    Protected Sub txtNOPROFORMA_ValueChanged(sender As Object, e As EventArgs) Handles txtNOPROFORMA.ValueChanged
        If TIPO_OPERACION = TipoOperacion.RegistroProforma OrElse TIPO_OPERACION = TipoOperacion.CambioFechaQuemaRoza OrElse TIPO_OPERACION = TipoOperacion.Recepcion Then
            'Verificar que no se utiliza el número de boleta para esta zafra
            Dim lProforma As PROFORMA
            Dim lZafraActiva As ZAFRA = (New cZAFRA).ObtenerZafraActiva

            Me.dteFECHA_PATIO.ClientEnabled = True
            If Me.txtNOPROFORMA.Value IsNot Nothing Then
                lProforma = mcPROFORMA.ObtenerPROFORMAPorNumZafra(Me.txtNOPROFORMA.Value, lZafraActiva.ID_ZAFRA)
                If lProforma IsNot Nothing Then
                    If lProforma.ID_ENVIO <> -1 AndAlso TIPO_OPERACION <> TipoOperacion.AnulacionProforma AndAlso TIPO_OPERACION <> TipoOperacion.ConsultaProforma Then
                        Dim lEnvio As ENVIO = (New cENVIO).ObtenerENVIO(lProforma.ID_ENVIO)
                        Me.AsignarMensaje(" * El No. Proforma: " + txtNOPROFORMA.Text + " esta asociado a la boleta No. " + lEnvio.NROBOLETA.ToString, True, False)
                        Me.txtNOPROFORMA.Value = Nothing
                        Me.txtNOPROFORMA.Focus()
                        Exit Sub
                    End If
                    If lProforma.FECHA_PATIO <> Nothing AndAlso TIPO_OPERACION = TipoOperacion.RegistroProforma Then
                        Me.AsignarMensaje(" * El No. Proforma: " + txtNOPROFORMA.Text + " ya esta registrado", True, False)
                        Me.txtNOPROFORMA.Value = Nothing
                        Me.txtNOPROFORMA.Focus()
                        Exit Sub
                    End If
                    If lProforma.FECHA_PATIO = Nothing AndAlso TIPO_OPERACION = TipoOperacion.Recepcion Then
                        Me.AsignarMensaje(" * El No. Proforma: " + txtNOPROFORMA.Text + " no se encuentra registrado. Debe registrarse en patio.", True, False)
                        Me.txtNOPROFORMA.Value = Nothing
                        Me.txtNOPROFORMA.Focus()
                        Exit Sub
                    End If
                    If lProforma.ID_ZAFRA <> cbxZAFRA.Value Then
                        Me.AsignarMensaje(" * El No. Proforma: " + txtNOPROFORMA.Text + " no corresponde a la zafra " + Me.cbxZAFRA.Text, True, False)
                        Me.txtNOPROFORMA.Value = Nothing
                        Me.txtNOPROFORMA.Focus()
                        Exit Sub
                    End If
                    Me.ID_PROFORMA = lProforma.ID_PROFORMA
                    Me.txtNOPROFORMA.ClientEnabled = False
                    Me.dteFECHA_PATIO.ClientEnabled = False
                Else
                    Me.AsignarMensaje(" * El No. Proforma: " + txtNOPROFORMA.Text + " no existe", True, False)
                    Me.txtNOPROFORMA.Value = Nothing
                    Me.txtNOPROFORMA.Focus()
                    Exit Sub
                End If
            Else
                Me.ID_PROFORMA = 0
            End If
            txtNROBOLETA.Focus()
        End If
    End Sub

    Private Sub CargarProveedorRoza()
        Dim lProveedores As New listaPROVEEDOR_ROZA

        If Me.cbxID_TIPO_ROZA.Value IsNot Nothing Then
            If Me.chkVerTodosProveedoresRoza.Checked Then
                lProveedores = (New cPROVEEDOR_ROZA).ObtenerListaPorTIPO_ROZA(Me.cbxID_TIPO_ROZA.Value)
                'Else
                '    Dim lProveeAux As listaPROVEEDOR_ROZA = (New cPROVEEDOR_ROZA).ObtenerListaPorPROFORMA_CONTROL_ROZA_SALDO(Me.ID_PROFORMA)
                '    If lProveeAux IsNot Nothing Then
                '        For Each lEntidad As PROVEEDOR_ROZA In lProveeAux
                '            If lEntidad.ID_TIPO_ROZA = Me.cbxID_TIPO_ROZA.Value Then
                '                lProveedores.Add(lEntidad)
                '            End If
                '        Next
                '    End If
            End If
            If (Me.cbxID_TIPO_ROZA.Value = 22 OrElse Me.cbxID_TIPO_ROZA.Value = 23) AndAlso (lProveedores Is Nothing OrElse lProveedores.Count = 0) Then
                Dim lEntidad As PROVEEDOR_ROZA = (New cPROVEEDOR_ROZA).ObtenerPROVEEDOR_ROZA(28)
                lProveedores = New listaPROVEEDOR_ROZA
                lProveedores.Add(lEntidad)
            ElseIf (Me.cbxID_TIPO_ROZA.Value = 20 OrElse Me.cbxID_TIPO_ROZA.Value = 21) AndAlso (lProveedores Is Nothing OrElse lProveedores.Count = 0) Then
                Dim lEntidades As listaPROVEEDOR_ROZA = (New cPROVEEDOR_ROZA).ObtenerListaPorTIPO_ROZA(Me.cbxID_TIPO_ROZA.Value)
                lProveedores = lEntidades
            End If
        End If

        If lProveedores IsNot Nothing AndAlso lProveedores.Count > 0 Then
            For i As Integer = 0 To lProveedores.Count - 1
                If Not Left(lProveedores(i).NOMBRE_PROVEEDOR_ROZA, 2) = "RZ" Then
                    lProveedores(i).NOMBRE_PROVEEDOR_ROZA = lProveedores(i).CODIGO + " - " + lProveedores(i).NOMBRE_PROVEEDOR_ROZA.Trim + " " + lProveedores(i).APELLIDOS.Trim
                End If
            Next

        End If

        Me.cbxID_PROVEEDOR_ROZA.DataSource = lProveedores
        Me.cbxID_PROVEEDOR_ROZA.DataBind()
        If cbxID_PROVEEDOR_ROZA.Items.Count = 1 Then cbxID_PROVEEDOR_ROZA.SelectedIndex = 0 Else cbxID_PROVEEDOR_ROZA.Text = ""
    End Sub

    Protected Sub cbxID_TIPO_ROZA_ValueChanged(sender As Object, e As System.EventArgs) Handles cbxID_TIPO_ROZA.ValueChanged
        Me.CargarProveedorRoza()
        Me.CargarTipoAlza()
        Me.CargarCargadoras()
    End Sub

    Protected Sub cbxID_TIPO_ALZA_ValueChanged(sender As Object, e As System.EventArgs) Handles cbxID_TIPO_ALZA.ValueChanged

        If Me.cbxID_TIPO_ALZA.Value = CAT.TipoAlza.AlzaManualParticular OrElse _
            Me.cbxID_TIPO_ALZA.Value = CAT.TipoAlza.AlzaManualProductor Then
            Me.cbxCARGADOR.Text = ""
            Me.cbxCARGADOR.ClientEnabled = False
        Else
            Me.cbxCARGADOR.ClientEnabled = True
            Me.cbxCARGADOR.Text = ""
        End If
        Me.CargarCargadoras()
        If Me.cbxCARGADORA.Value IsNot Nothing Then
            Me.ConfigurarOperadoresTractor(Me.cbxCARGADORA.Value, True)
        Else
            Me.ConfigurarOperadoresTractor(-1, True)
        End If
        Me.cbxCARGADORA.Focus()
    End Sub

    Private Sub CargarTipoTransporte()
        'Dim lista As New listaTRANSPORTE
        'Dim listaTipoTransporte As listaTIPO_TRANSPORTE = (New cTIPO_TRANSPORTE).ObtenerLista(False, "NOMBRE")
        'If listaTipoTransporte IsNot Nothing AndAlso listaTipoTransporte.Count > 0 Then
        '    For i As Integer = 0 To listaTipoTransporte.Count - 1
        '        If listaTipoTransporte(i).ID_TIPOTRANS = 19 OrElse _
        '            listaTipoTransporte(i).ID_TIPOTRANS = 20 OrElse
        '            listaTipoTransporte(i).ID_TIPOTRANS = 21 OrElse _
        '            listaTipoTransporte(i).ID_TIPOTRANS = 28 Then
        '            lista.Add(listaTipoTransporte(i))
        '        End If
        '    Next
        'End If
        'Me.cbxTIPO_TRANS.DataSource = lista
        'Me.cbxTIPO_TRANS.DataBind()
    End Sub

    Protected Sub cbxID_TIPO_CANA_ValueChanged(sender As Object, e As System.EventArgs) Handles cbxID_TIPO_CANA.ValueChanged
        Me.CargarTipoRoza()
        Me.CargarTipoAlza()
        Me.CargarCargadoras()
        Me.CargarProveedorRoza()

        If cbxID_TIPO_CANA.Value IsNot Nothing Then
            Me.ConfigPorTipoCana(Me.cbxID_TIPO_CANA.Value)
        End If
    End Sub

    Private Sub ConfigPorTipoCana(ByVal ID_TIPO_CANA As Int32)
        'Me.rblTIPO_QUEMA.ClientEnabled = True
    End Sub

    Protected Sub cbxCARGADORA_ValueChanged(sender As Object, e As System.EventArgs) Handles cbxCARGADORA.ValueChanged
        Me.CargarCargadores()
        Me.ConfigurarCodigosMocheroCherquero(Me.cbxCARGADORA.Value, True)
        Me.ConfigurarOperadoresTractor(Me.cbxCARGADORA.Value, True)
    End Sub

    Protected Sub cpINVENTARIO_ROZA_Callback(sender As Object, e As DevExpress.Web.CallbackEventArgsBase) Handles cpINVENTARIO_ROZA.Callback
        If e.Parameter = "SeleccionRoza" Then
            Dim lista As listaCONTROL_ROZA_SALDO = Me.ucListaCONTROL_ROZA_SALDO1.DevolverSeleccionados
            If lista IsNot Nothing AndAlso lista.Count > 0 Then
                Me.SetInfoRoza(lista(0).ID_ROZA_SALDO)
            End If
        End If
    End Sub

    Protected Sub chkVerTodosProveedoresRoza_CheckedChanged(sender As Object, e As EventArgs) Handles chkVerTodosProveedoresRoza.CheckedChanged
        Me.CargarProveedorRoza()
    End Sub

    Protected Sub chkVerTodosMotoristas_CheckedChanged(sender As Object, e As EventArgs) Handles chkVerTodosMotoristas.CheckedChanged
        Me.CargarMotoristas()
    End Sub

    Protected Sub speID_MOTORISTA_VEHI_ValueChanged(sender As Object, e As EventArgs) Handles speID_MOTORISTA_VEHI.ValueChanged
        If Me.speID_MOTORISTA_VEHI.Value Is Nothing Then Return

        Dim lMotoVehi As MOTORISTA_VEHICULO = (New cMOTORISTA_VEHICULO).ObtenerMOTORISTA_VEHICULO(Me.speID_MOTORISTA_VEHI.Value)
        If lMotoVehi IsNot Nothing Then
            Dim lTransporte As TRANSPORTE

            If Not lMotoVehi.ACTIVO Then
                Me.speID_MOTORISTA_VEHI.Value = Nothing
                Me.txtCODTRANSPORT.Text = ""
                Me.txtNOMBRE_TRANSPORTISTA.Text = ""
                Me.AsignarMensaje("* Motorista no esta activo", True, False)
                Return
            End If
            lTransporte = (New cTRANSPORTE).ObtenerTRANSPORTE(lMotoVehi.ID_TRANSPORTE)
            If lTransporte IsNot Nothing Then
                Me.txtCODTRANSPORT.Value = lTransporte.CODTRANSPORT
                Me.MostrarInfoTransportista()
                Me.rblTRANS_PROPIEDAD.Value = If(lMotoVehi.ES_PARTICULAR, 2, 1)
                If Me.cbxPLACAVEHIC.Items.FindByValue(lMotoVehi.ID_TRANSPORTE) IsNot Nothing Then Me.cbxPLACAVEHIC.Value = lMotoVehi.ID_TRANSPORTE
                Me.CargarMotoristas()
                Me.cbxMOTORISTA.Value = lMotoVehi.ID_MOTORISTA
                Me.cbxTIPO_TRANS.Value = lTransporte.ID_TIPOTRANS
            End If
            Me.CargarCargadorasTodas()
            If Me.cbxCARGADORA.Items.FindByValue(lMotoVehi.ID_CARGADORA) IsNot Nothing Then
                Me.cbxCARGADORA.Value = lMotoVehi.ID_CARGADORA
            End If
        Else
            Me.speID_MOTORISTA_VEHI.Value = Nothing
            Me.txtCODTRANSPORT.Text = ""
            Me.txtNOMBRE_TRANSPORTISTA.Text = ""
        End If
    End Sub


    Protected Sub txtCODIGO_CHEQUERO_ValueChanged(sender As Object, e As EventArgs) Handles txtCODIGO_CHEQUERO.ValueChanged
        MostrarInfoChequero()
    End Sub

    Protected Sub txtCODIGO_MOCHADOR_ValueChanged(sender As Object, e As EventArgs) Handles txtCODIGO_MOCHADOR.ValueChanged
        MostrarInfoMochador()
    End Sub

    Private Function EsCargadoraJIBOA(ByVal idCargadora As Integer) As Boolean
        Dim lCargadora As CARGADORA = (New cCARGADORA).ObtenerCARGADORA(idCargadora)
        If lCargadora IsNot Nothing AndAlso lCargadora.ID_PROVEEDOR_CARGA = 1 AndAlso lCargadora.ID_TIPO_CARGADORA = 1 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub chkAUTOVOLTEO_CheckedChanged(sender As Object, e As EventArgs) Handles chkAUTOVOLTEO.CheckedChanged
        If chkAUTOVOLTEO.Checked Then
            Me.cbxOPERADOR_TRACTOR1.ClientEnabled = True
            Me.cbxOPERADOR_TRACTOR2.ClientEnabled = True
        Else
            Me.cbxOPERADOR_TRACTOR1.Value = Nothing
            Me.cbxOPERADOR_TRACTOR2.Value = Nothing
            Me.cbxOPERADOR_TRACTOR1.ClientEnabled = False
            Me.cbxOPERADOR_TRACTOR2.ClientEnabled = False
        End If
    End Sub

    Private Sub cbxMOTIVO_ANULACION_PROFORMA_ValueChanged(sender As Object, e As EventArgs) Handles cbxMOTIVO_ANULACION_PROFORMA.ValueChanged
        If Me.cbxMOTIVO_ANULACION_PROFORMA.Text = "OTRO" Then
            Me.txtOBSERVA_ANUL.ClientEnabled = True
        Else
            Me.txtOBSERVA_ANUL.Text = ""
            Me.txtOBSERVA_ANUL.ClientEnabled = False
        End If
    End Sub
End Class
