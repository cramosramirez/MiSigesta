
Imports System.Data
Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores

Partial Class controlesProforma_ucAsignacionTransporte
    Inherits ucBase

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Me.Inicializar()
        End If
    End Sub

    Public Property PROFORMA_EXTRAORDINARIO As Boolean
        Set(value As Boolean)
            Me.ViewState("PROFORMA_EXTRAORDINARIO") = value
        End Set
        Get
            If Me.ViewState("PROFORMA_EXTRAORDINARIO") IsNot Nothing Then
                Return Convert.ToBoolean(Me.ViewState("PROFORMA_EXTRAORDINARIO"))
            Else
                Return False
            End If
        End Get
    End Property

    Private Sub Inicializar()
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        Me.ucBarraNavegacion1.PermitirNavegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucBarraNavegacion1.CrearOpcion("Cancelar", "Cancelar", False, IconoBarra.Cancelar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("EmitirProforma", "Emitir Proforma", True, IconoBarra.Guardar, "", "", True)
        Me.ucBarraNavegacion1.CargarOpciones()
        If lZafra IsNot Nothing Then
            Me.cbxZAFRA.Value = lZafra.ID_ZAFRA
        End If
        Me.chkASIG_MANUAL.Checked = False
        Me.txtNOMBRE_MOTORISTA.ClientEnabled = False
        Me.txtPLACA.ClientEnabled = False
        Me.txtTIPO_TRANSPORTE.ClientEnabled = False
        Me.txtCODTRANSPORT.ClientEnabled = False
        Me.txtNOMBRE_TRANSPORTISTA.ClientEnabled = False
        Me.txtCONDICION_TRANSPORTE.ClientEnabled = False
        Me.tblDestino.Visible = False
        Me.tblAsignacionManual.Visible = False

        If Me.PROFORMA_EXTRAORDINARIO Then
            Me.chkASIG_MANUAL.Checked = True
            Me.chkASIG_MANUAL.ClientEnabled = False
            Me.trProformaExtraordinario.Visible = True
        Else
            Me.chkASIG_MANUAL.Checked = False
            Me.chkASIG_MANUAL.ClientEnabled = True
            Me.trProformaExtraordinario.Visible = False
        End If
        gridLotesDisponibles.SearchPanelFilter = ""
    End Sub


    Protected Sub speID_MOTORISTA_VEHI_ValueChanged(sender As Object, e As EventArgs) Handles speID_MOTORISTA_VEHI.ValueChanged
        AsignarMensaje("", True, False)
        Me.tblDestino.Visible = False
        Me.tblAsignacionManual.Visible = False

        If Me.speID_MOTORISTA_VEHI.Value Is Nothing Then Return

        Dim lMotoVehi As MOTORISTA_VEHICULO = (New cMOTORISTA_VEHICULO).ObtenerMOTORISTA_VEHICULO(Me.speID_MOTORISTA_VEHI.Value)
        If lMotoVehi IsNot Nothing Then
            Dim lTransporte As TRANSPORTE
            Dim lMotorista As MOTORISTA
            Dim lTipoTrans As TIPO_TRANSPORTE

            If Not lMotoVehi.ACTIVO Then
                Me.speID_MOTORISTA_VEHI.Value = Nothing
                Me.txtCODTRANSPORT.Text = ""
                Me.txtNOMBRE_TRANSPORTISTA.Text = ""
                Me.txtPLACA.Text = ""
                Me.txtTIPO_TRANSPORTE.Text = ""
                Me.txtCONDICION_TRANSPORTE.Text = ""
                Me.AsignarMensaje("* MOTORISTA NO ESTA ACTIVO", True, False)
                Return
            End If
            Me.txtCONDICION_TRANSPORTE.Text = IIf(lMotoVehi.ES_PARTICULAR, "PARTICULAR", "PROPIO")
            lMotorista = (New cMOTORISTA).ObtenerMOTORISTA(lMotoVehi.ID_MOTORISTA)
            If lMotorista IsNot Nothing Then
                Me.txtNOMBRE_MOTORISTA.Text = lMotorista.NOMBRES.Trim + " " + lMotorista.APELLIDOS.Trim
            End If
            lTransporte = (New cTRANSPORTE).ObtenerTRANSPORTE(lMotoVehi.ID_TRANSPORTE)
            If lTransporte IsNot Nothing Then
                Me.txtCODTRANSPORT.Value = lTransporte.CODTRANSPORT
                Me.MostrarInfoTransportista()
                Me.txtPLACA.Text = lTransporte.PLACA

                lTipoTrans = (New cTIPO_TRANSPORTE).ObtenerTIPO_TRANSPORTE(lTransporte.ID_TIPOTRANS)
                If lTipoTrans IsNot Nothing Then
                    Me.txtTIPO_TRANSPORTE.Text = lTipoTrans.NOMBRE
                End If
            End If

            Dim bExec As New cPROFORMA
            Dim ds As DataSet
            Dim idZafra As Integer = Convert.ToInt32(Me.cbxZAFRA.Value)
            Dim idMotoristaVehi As Integer = Convert.ToInt32(Me.speID_MOTORISTA_VEHI.Value)
            Dim idAsignacion As Integer = -1

            ' *****************************************
            ' VALIDAR SI PLACA TIENE PROFORMAS EN PROCESO
            ds = bExec.SP_CC_ASIGNAR_LOTE_TRANS("VERIFICAR PLACA-PROFORMA", idZafra, idMotoristaVehi, -1, Me.ObtenerUsuario, -1)
            If ds IsNot Nothing Then
                If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows(0)("CODIGO") <> "0" Then
                    AsignarMensaje("* " + ds.Tables(0).Rows(0)("MENSAJE").ToString, True, False)
                    Return
                End If
            End If

            If Not PROFORMA_EXTRAORDINARIO Then
                ' *****************************************
                ' EJECUTAR PREVISUALIZACION DE ASIGNACION
                ds = bExec.SP_CC_ASIGNAR_LOTE_TRANS("PREASIGNAR", idZafra, idMotoristaVehi, idAsignacion, Me.ObtenerUsuario, -1)
                If ds IsNot Nothing Then
                    If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows(0)("CODIGO") = "0" Then
                        Dim dr As DataRow = ds.Tables(0).Rows(0)
                        Me.txtNO_CONTRATO.Text = dr("NO_CONTRATO").ToString
                        Me.txtZONA.Text = dr("ZONA").ToString
                        Me.txtCODIPROVEEDOR.Text = dr("CODIPROVEE").ToString
                        Me.txtPRODUCTOR.Text = dr("PRODUCTOR").ToString
                        Me.txtCODILOTE.Text = dr("CODILOTE").ToString
                        Me.txtLOTE.Text = dr("NOMBLOTE").ToString
                        Me.txtTIPO_CANA.Text = dr("TIPO_CANA").ToString
                        If dr("ID_TIPO_QUEMA") Is Nothing OrElse Convert.ToInt32(dr("ID_TIPO_QUEMA")) = 0 Then
                            Me.txtTIPO_QUEMA.Text = ""
                        Else
                            Me.txtTIPO_QUEMA.Text = dr("TIPO_QUEMA").ToString
                        End If
                        If Not IsDBNull(dr("FECHA_QUEMA")) Then
                            Me.txtFECHA_QUEMA.Text = Format(dr("FECHA_QUEMA"), "dd/MM/yyyy HH:mm")
                        Else
                            Me.txtFECHA_QUEMA.Text = ""
                        End If
                        Me.txtCARGADORA.Text = dr("CARGADORA").ToString
                        Me.txtTIPO_ROZA.Text = dr("TIPO_ROZA").ToString
                        Me.txtFECHA_ROZA.Text = Format(dr("FECHA_ROZA"), "dd/MM/yyyy HH:mm")
                        Me.txtFRENTE_QUERQUEO.Text = dr("PROVEEDOR_QUERQUEO").ToString
                        ' GUARDANDO EL VALOR DE ID_CC_TIPOTRANS
                        Me.hdID_ASIGNACION.Clear()
                        Me.hdID_ASIGNACION.Add("ID_CC_TIPOTRANS", dr("ID_CC_TIPOTRANS").ToString)
                        Me.hdID_ASIGNACION.Add("TIPO_ASIGNACION", dr("TIPO_ASIGNACION").ToString)
                        Me.tblDestino.Visible = True
                    Else
                        AsignarMensaje("* " + ds.Tables(0).Rows(0)("MENSAJE").ToString, True, False)
                    End If
                Else
                    AsignarMensaje("* NO SE OBTUVIERON DATOS", True, False)
                End If
            Else
                Me.MostrarLotesDisponibles()
            End If

        Else
            Me.speID_MOTORISTA_VEHI.Value = Nothing
            Me.txtCODTRANSPORT.Text = ""
            Me.txtNOMBRE_TRANSPORTISTA.Text = ""
            Me.txtPLACA.Text = ""
            Me.txtTIPO_TRANSPORTE.Text = ""
        End If
    End Sub

    Private Sub MostrarInfoTransportista()
        If txtCODTRANSPORT.Value Is Nothing Then Return

        Dim lTransportista As TRANSPORTISTA = (New cTRANSPORTISTA).ObtenerTRANSPORTISTA(txtCODTRANSPORT.Value)
        If lTransportista IsNot Nothing Then
            Me.txtNOMBRE_TRANSPORTISTA.Text = lTransportista.NOMBRES + " " + lTransportista.APELLIDOS
        Else
            Me.txtCODTRANSPORT.Text = ""
            Me.txtNOMBRE_TRANSPORTISTA.Text = ""
        End If
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        Select Case CommandName

            Case "EmitirProforma"
                Dim sError As String = ""
                Dim bExec As New cPROFORMA
                Dim ds As DataSet
                Dim idZafra As Integer
                Dim idMotoristaVehi As Integer
                Dim idAsignacion As Integer
                Dim idProforma As Integer
                Dim ID_CC_ASIG As Integer
                Dim tipoAsignacion As String = ""

                AsignarMensaje("", True, False)
                If Me.speID_MOTORISTA_VEHI.Text = "" Then
                    AsignarMensaje("* INGRESE EL CODIGO DEL MOTORISTA", True, False)
                    Return
                End If

                idZafra = Convert.ToInt32(Me.cbxZAFRA.Value)
                idMotoristaVehi = Convert.ToInt32(Me.speID_MOTORISTA_VEHI.Value)

                If Me.chkASIG_MANUAL.Checked Then
                    If Me.gridLotesDisponibles.GetSelectedFieldValues("ID_CC_TIPOTRANS") Is Nothing OrElse
                        Me.gridLotesDisponibles.GetSelectedFieldValues("ID_CC_TIPOTRANS").Count = 0 Then
                        AsignarMensaje("* SELECCIONE EL LOTE QUE SE ASIGNARA AL TRANSPORTE", True, False)
                        Return
                    End If
                    For Each id As Decimal In Me.gridLotesDisponibles.GetSelectedFieldValues("ID_CC_TIPOTRANS")
                        idAsignacion = id
                        If Me.PROFORMA_EXTRAORDINARIO Then
                            tipoAsignacion = "PROFORMA-EXTRAORDINARIO"
                        Else
                            tipoAsignacion = "PROFORMA-MANUAL"
                        End If
                        Exit For
                    Next
                Else
                    If Not Me.tblDestino.Visible Then
                        AsignarMensaje("* NO EXISTE ASIGNACION PARA EL TRANSPORTE", True, False)
                        Return
                    End If
                    idAsignacion = Convert.ToInt32(Me.hdID_ASIGNACION("ID_CC_TIPOTRANS"))
                    tipoAsignacion = Me.hdID_ASIGNACION("TIPO_ASIGNACION").ToString
                    If tipoAsignacion = "A" Then
                        tipoAsignacion = "PROFORMA-AUTOMATICO"
                    ElseIf tipoAsignacion = "P" Then
                        tipoAsignacion = "PROFORMA-PREASIGNADO"
                    End If
                End If
                ds = bExec.SP_CC_ASIGNAR_LOTE_TRANS(tipoAsignacion, idZafra, idMotoristaVehi, idAsignacion, Me.ObtenerUsuario, -1)
                If ds IsNot Nothing Then
                    If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows(0)("CODIGO") = "0" Then
                        ID_CC_ASIG = Convert.ToInt32(ds.Tables(0).Rows(0)("ID_CC_ASIG"))
                        idProforma = Me.EmitirProforma(ds.Tables(0).Rows(0))
                        If idProforma > 0 Then
                            bExec.SP_CC_ASIGNAR_LOTE_TRANS("ASIGNAR PROFORMA", idZafra, idMotoristaVehi, ID_CC_ASIG, Me.ObtenerUsuario, idProforma)
                        End If
                    Else
                        AsignarMensaje("* " + ds.Tables(0).Rows(0)("MENSAJE").ToString, True, False)
                    End If
                Else
                    AsignarMensaje("* NO SE OBTUVIERON DATOS", True, False)
                End If

            Case "Cancelar"
                AsignarMensaje("", True, False)
                LimpiarCampos()
                Me.speID_MOTORISTA_VEHI.Focus()
        End Select
    End Sub

    Private Sub LimpiarCampos()
        Me.speID_MOTORISTA_VEHI.Value = Nothing
        Me.txtNOMBRE_MOTORISTA.Text = ""
        Me.txtPLACA.Text = ""
        Me.txtTIPO_TRANSPORTE.Text = ""
        Me.txtCODTRANSPORT.Text = ""
        Me.txtNOMBRE_TRANSPORTISTA.Text = ""
        Me.txtCONDICION_TRANSPORTE.Text = ""
        Me.chkASIG_MANUAL.Checked = IIf(Me.PROFORMA_EXTRAORDINARIO, True, False)
        Me.tblDestino.Visible = False
        Me.tblAsignacionManual.Visible = False
    End Sub

    Private Function EmitirProforma(ByVal dr As DataRow) As Integer
        Dim bProforma As New cPROFORMA
        Dim lProforma As New PROFORMA
        Dim lDiaZafra As DIA_ZAFRA
        Dim lAplicacionesMadurante As listaSOLIC_APLICA_LOTE
        Dim bCapacidadTrans As New cCAPACIDAD_TIPO_TRANS
        Dim lCargadora As CARGADORA

        Try
            lProforma.ID_PROFORMA = 0
            lProforma.ID_ZAFRA = Me.cbxZAFRA.Value
            lDiaZafra = (New cDIA_ZAFRA).ObtenerDiaZafraActivo(lProforma.ID_ZAFRA)
            If lDiaZafra IsNot Nothing Then lProforma.DIAZAFRA = lDiaZafra.DIAZAFRA
            lProforma.NOPROFORMA = bProforma.ObtenerNoProformaPorZafra(lProforma.ID_ZAFRA)
            lProforma.CODICONTRATO = dr("CODICONTRATO").ToString
            lProforma.CODIPROVEEDOR = dr("CODIPROVEEDOR").ToString
            lProforma.ACCESLOTE = dr("ACCESLOTE").ToString
            lProforma.CODTRANSPORT = Convert.ToInt32(Me.txtCODTRANSPORT.Value)
            lProforma.NOMBRES_MOTORISTA = Me.txtNOMBRE_MOTORISTA.Text
            lProforma.ID_TIPO_CANA = Convert.ToInt32(dr("ID_TIPO_CANA"))
            lProforma.ID_CARGADORA = Convert.ToInt32(dr("ID_CARGADORA"))
            lCargadora = (New cCARGADORA).ObtenerCARGADORA(lProforma.ID_CARGADORA)
            If lCargadora IsNot Nothing Then
                lProforma.ID_TIPO_ALZA = lCargadora.ID_TIPO_ALZA
            End If
            lProforma.ID_CARGADOR = -1
            lProforma.ID_SUPERVISOR = -1
            If IsDBNull(dr("ID_TIPO_QUEMA")) Then
                lProforma.QUEMAPROG = False
                lProforma.QUEMANOPROG = False
                lProforma.CANA_VERDE = False
                lProforma.FECHA_QUEMA = Nothing
            Else
                Select Case Convert.ToInt32(dr("ID_TIPO_QUEMA"))
                    Case 0
                        lProforma.QUEMAPROG = False
                        lProforma.QUEMANOPROG = False
                        lProforma.CANA_VERDE = False
                        lProforma.FECHA_QUEMA = Nothing
                    Case 1
                        lProforma.QUEMAPROG = True
                        lProforma.FECHA_QUEMA = Convert.ToDateTime(dr("FECHA_QUEMA"))
                    Case 2
                        lProforma.QUEMANOPROG = True
                        lProforma.FECHA_QUEMA = Convert.ToDateTime(dr("FECHA_QUEMA"))
                    Case 3
                        lProforma.CANA_VERDE = True
                        lProforma.FECHA_QUEMA = Nothing
                End Select
            End If
            lProforma.SERVICIO_ROZA = True
            lProforma.ID_PROVEEDOR_ROZA = Convert.ToInt32(dr("ID_PROVEEDOR_ROZA"))
            lProforma.FECHA_ROZA = Convert.ToDateTime(dr("FECHA_ROZA"))
            lProforma.FECHA_CORTA = Nothing
            lProforma.FECHA_PATIO = Nothing
            lProforma.ID_PRODUCTO = -1
            lProforma.FIN_LOTE = False
            lProforma.PLACAVEHIC = Me.txtPLACA.Text
            lProforma.ID_TIPOTRANS = Convert.ToInt32(dr("ID_TIPOTRANS"))

            If Convert.ToBoolean(dr("ES_PARTICULAR")) Then
                lProforma.TRANSPORTE_PROPIO = False
            Else
                lProforma.TRANSPORTE_PROPIO = True
            End If
            'If cbxCARGADOR.Text <> "" Then
            '    lProforma.ID_CARGADOR = Me.cbxCARGADOR.Value
            'Else
            '    lProforma.ID_CARGADOR = -1
            'End If
            lProforma.ID_CARGADOR = -1
            lProforma.TIPO_TARIFA_CARGADORA = -1
            lProforma.ID_MOTORISTA = Convert.ToInt32(dr("ID_MOTORISTA"))
            lProforma.ID_TIPO_ROZA = Convert.ToInt32(dr("ID_TIPO_ROZA"))
            lProforma.OBSERVACIONES = Nothing
            lProforma.ID_ENVIO = -1
            lProforma.ESTADO = EstadoProforma.Transito
            lProforma.USUARIO_CREA = Me.ObtenerUsuario
            lProforma.FECHA_CREA = cFechaHora.ObtenerFechaHora
            lProforma.USUARIO_ACT = Me.ObtenerUsuario
            lProforma.FECHA_ACT = cFechaHora.ObtenerFechaHora
            If dr("ID_PROVEE_QQ") Is Nothing Then
                lProforma.ES_QUERQUEO = False
                lProforma.ID_PROVEE_QQ = -1
            Else
                lProforma.ES_QUERQUEO = True
                lProforma.ID_PROVEE_QQ = Convert.ToInt32(dr("ID_PROVEE_QQ"))
            End If
            lProforma.ES_BARRIDA = False
            'If Me.dteFECHA_CARGA.ClientEnabled AndAlso Me.dteFECHA_CARGA.Value IsNot Nothing Then
            '    lProforma.FECHA_CORTA = Me.dteFECHA_CARGA.Date
            '    lProforma.ESTADO = EstadoProforma.Rueda
            'End If

            lAplicacionesMadurante = (New cSOLIC_APLICA_LOTE).ObtenerListaPorZAFRA_LOTE(CInt(Me.cbxZAFRA.Value), dr("ACCESLOTE").ToString, "", "DESC")
            If lAplicacionesMadurante IsNot Nothing AndAlso lAplicacionesMadurante.Count > 0 Then
                lProforma.ID_PRODUCTO = lAplicacionesMadurante(0).ID_PRODUCTO
                lProforma.FECHA_MADURANTE = lAplicacionesMadurante(0).FECHA_APLICA
            Else
                lProforma.ID_PRODUCTO = -1
                lProforma.FECHA_MADURANTE = #12:00:00 AM#
            End If

            'Estableciendo la capacidad por tipo de transporte
            lProforma.TONELADAS = bCapacidadTrans.ObtenerCapacidadPorTIPO_CANA_TIPO_TRANS(lProforma.ID_TIPOTRANS)

            If lProforma.TONELADAS < 0 Then
                lProforma.TONELADAS = 0
            End If
            '***** Asignar proforma
            lProforma.ID_SUBLOTES = -1

            '***** Crear proforma
            If bProforma.ActualizarPROFORMA(lProforma) <> 1 Then
                AsignarMensaje("* ERROR AL EMITIR PROFORMA: " + bProforma.sError, True, False)
                Return -1
            End If

            LimpiarCampos()
            Me.speID_MOTORISTA_VEHI.Focus()
            AsignarMensaje("El Proforma se emitio con exito.", False, True, True)
            ScriptManager.RegisterClientScriptBlock(Me, Page.GetType, "script", "MostrarProforma(" + lProforma.ID_PROFORMA.ToString + ")", True)
            Return lProforma.ID_PROFORMA

        Catch ex As Exception
            Return -1
        End Try

    End Function

    Private Sub MostrarLotesDisponibles()
        Me.tblDestino.Visible = False
        Me.tblAsignacionManual.Visible = False
        AsignarMensaje("", True, False)
        If Me.PROFORMA_EXTRAORDINARIO Then
            Me.odsSP_CC_ASIGNAR_LOTE_TRANS.SelectParameters("OPCION").DefaultValue = "CONSULTA EXTRAORDINARIA"
        Else
            Me.odsSP_CC_ASIGNAR_LOTE_TRANS.SelectParameters("OPCION").DefaultValue = "CONSULTA MANUAL"
        End If
        Me.odsSP_CC_ASIGNAR_LOTE_TRANS.SelectParameters("ID_ZAFRA").DefaultValue = Me.cbxZAFRA.Value.ToString
        Me.odsSP_CC_ASIGNAR_LOTE_TRANS.SelectParameters("ID_MOTORISTA_VEHI").DefaultValue = Me.speID_MOTORISTA_VEHI.Value.ToString
        Me.odsSP_CC_ASIGNAR_LOTE_TRANS.SelectParameters("ID_ASIGNACION").DefaultValue = "-1"
        Me.odsSP_CC_ASIGNAR_LOTE_TRANS.SelectParameters("USUARIO").DefaultValue = Me.ObtenerUsuario
        Me.odsSP_CC_ASIGNAR_LOTE_TRANS.SelectParameters("ID_PROFORMA").DefaultValue = "-1"
        Me.odsSP_CC_ASIGNAR_LOTE_TRANS.DataBind()
        Me.gridLotesDisponibles.DataSourceID = "odsSP_CC_ASIGNAR_LOTE_TRANS"
        Me.gridLotesDisponibles.DataBind()
        Me.gridLotesDisponibles.Selection.UnselectAll()
        Me.tblAsignacionManual.Visible = True
    End Sub

    Private Sub chkASIG_MANUAL_CheckedChanged(sender As Object, e As EventArgs) Handles chkASIG_MANUAL.CheckedChanged
        If Me.speID_MOTORISTA_VEHI.Value Is Nothing Then Return
        If chkASIG_MANUAL.Checked Then
            Dim bExec As New cPROFORMA
            Dim ds As DataSet
            Dim idZafra As Integer = Convert.ToInt32(Me.cbxZAFRA.Value)
            Dim idMotoristaVehi As Integer = Convert.ToInt32(Me.speID_MOTORISTA_VEHI.Value)
            Dim idAsignacion As Integer = -1

            ' *****************************************
            ' VALIDAR SI PLACA TIENE PROFORMAS EN PROCESO
            ds = bExec.SP_CC_ASIGNAR_LOTE_TRANS("VERIFICAR PLACA-PROFORMA", idZafra, idMotoristaVehi, -1, Me.ObtenerUsuario, -1)
            If ds IsNot Nothing Then
                If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows(0)("CODIGO") <> "0" Then
                    AsignarMensaje("* " + ds.Tables(0).Rows(0)("MENSAJE").ToString, True, False)
                    Return
                End If
            End If
            Me.MostrarLotesDisponibles()
        Else
            Me.speID_MOTORISTA_VEHI_ValueChanged(Me.speID_MOTORISTA_VEHI, New EventArgs())
        End If
    End Sub
End Class
