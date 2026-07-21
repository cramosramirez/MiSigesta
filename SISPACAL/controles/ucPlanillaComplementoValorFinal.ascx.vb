Imports SISPACAL.EL
Imports SISPACAL.BL
Imports SISPACAL.EL.Enumeradores
Imports DevExpress.Web

Partial Class controles_ucPlanillaComplementoValorFinal
    Inherits ucBase

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Me.Inicializar()
        End If
    End Sub

    Private Sub Inicializar()
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        If lZafra IsNot Nothing Then
            Me.cbxZAFRA.Value = lZafra.ID_ZAFRA
        End If
        Me.lblTitulo.Text = "Generar Planilla de Complemento al Valor Final de Pago"
        
        If Me.cbxZAFRA.Value Is Nothing OrElse Me.cbxZAFRA.Value = 0 Then
            Me.ConfigMenu(-1)
        Else
            Me.ConfigMenu(Me.cbxZAFRA.Value)
        End If
    End Sub

    Private Sub ConfigMenu(ByVal ID_ZAFRA As Int32)
        Dim lAnticipo As ANTICIPO_CANA = (New cANTICIPO_CANA).ObtenerANTICIPO_CANAPorZAFRA_ES_COMP_VFP(ID_ZAFRA, True)
        Dim ly As LayoutItemBase = Me.ASPxFormLayout1.FindItemOrGroupByName("FECHA_PAGO")
        If lAnticipo Is Nothing Then
            Me.ucBarraNavegacion1.LimpiarOpciones()
            Me.ucBarraNavegacion1.PermitirNavegacion = False
            Me.ucBarraNavegacion1.PermitirAgregar = False
            Me.ucBarraNavegacion1.PermitirEditar = False
            Me.ucBarraNavegacion1.PermitirGuardar = False
            Me.ucBarraNavegacion1.CrearOpcion("Generar", "Generar Planilla", False, IconoBarra.Generar, "", "", True)
            Me.ucBarraNavegacion1.VerOpcion("Generar", True)
            Me.ucBarraNavegacion1.CargarOpciones()
            Me.speValorFinalPago.Value = Nothing
            Me.dteFECHA_PAGO.Value = Nothing
            ly.Visible = False
        Else
            Me.ucBarraNavegacion1.LimpiarOpciones()
            Me.ucBarraNavegacion1.PermitirNavegacion = False
            Me.ucBarraNavegacion1.PermitirAgregar = False
            Me.ucBarraNavegacion1.PermitirEditar = False
            Me.ucBarraNavegacion1.PermitirGuardar = False
            Me.ucBarraNavegacion1.CrearOpcion("Regenerar", "Regenerar Planilla", False, IconoBarra.Generar, "", "", True)
            Me.ucBarraNavegacion1.CrearOpcion("Guardar", "Guardar Fecha Pago", False, IconoBarra.Guardar, "", "", True)
            Me.ucBarraNavegacion1.VerOpcion("Regenerar", True)
            Me.ucBarraNavegacion1.VerOpcion("Guardar", True)
            Me.ucBarraNavegacion1.CargarOpciones()
            Me.speValorFinalPago.Value = lAnticipo.VALOR_ANTICIPO
            If lAnticipo.FECHA_PAGO <> Nothing Then
                Me.dteFECHA_PAGO.Value = lAnticipo.FECHA_PAGO
            End If
            ly.Visible = True
        End If
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        If CommandName = "Generar" OrElse CommandName = "Regenerar" Then
            If Me.cbxZAFRA.Value Is Nothing Then
                Me.AsignarMensaje("* Seleccione la zafra", True, False)
                Return
            End If
            If Me.speValorFinalPago.Value <= 0 Then
                Me.AsignarMensaje("* El valor del complemento no puede ser cero", True, False)
                Return
            End If
            Dim lCatorcenas As listaCATORCENA_ZAFRA = (New cCATORCENA_ZAFRA).ObtenerListaPorZAFRA(Convert.ToInt32(Me.cbxZAFRA.Value))
            If lCatorcenas Is Nothing OrElse lCatorcenas.Count = 0 Then
                Me.AsignarMensaje(String.Format("{0} {1}", "No existen catorcenas para la Zafra seleccionada", Me.cbxZAFRA.Text), True, False)
                Return
            End If

            'Generar/Regenerar planilla
            Dim bPlanilla As New cPLANILLA
            Dim lRet As Integer

            lRet = bPlanilla.GenerarPlanillaComplementoValorFinal(Convert.ToInt32(Me.cbxZAFRA.Value), Convert.ToDecimal(Me.speValorFinalPago.Value))
            If lRet <= 0 Then
                AsignarMensaje("No se logro generar la planilla", True, False)
                Return
            End If

            If dteFECHA_PAGO.Value IsNot Nothing Then
                Dim bAnticipo As New cANTICIPO_CANA
                Dim lAnticipo As ANTICIPO_CANA = (New cANTICIPO_CANA).ObtenerANTICIPO_CANAPorZAFRA_ES_COMP_VFP(Me.cbxZAFRA.Value, True)

                If lAnticipo IsNot Nothing Then
                    lAnticipo.FECHA_PAGO = dteFECHA_PAGO.Date
                    lAnticipo.USUARIO_ACT = Me.ObtenerUsuario
                    lAnticipo.FECHA_ACT = cFechaHora.ObtenerFechaHora
                    bAnticipo.ActualizarANTICIPO_CANA(lAnticipo)
                End If
            End If
            
            Me.speValorFinalPago.Text = ""
            Me.AsignarMensaje("", True, False)
            Me.AsignarMensaje("La Planilla de Complemento al Valor Final de Pago fue generada con exito!", False, True, True)
        End If
        If CommandName = "Guardar" Then
            If dteFECHA_PAGO.Value = Nothing Then
                AsignarMensaje("Ingrese la fecha de pago", True, False)
                Return
            End If
            Dim bAnticipo As New cANTICIPO_CANA
            Dim lAnticipo As ANTICIPO_CANA = (New cANTICIPO_CANA).ObtenerANTICIPO_CANAPorZAFRA_ES_COMP_VFP(Me.cbxZAFRA.Value, True)

            If lAnticipo IsNot Nothing Then
                lAnticipo.FECHA_PAGO = dteFECHA_PAGO.Date
                lAnticipo.USUARIO_ACT = Me.ObtenerUsuario
                lAnticipo.FECHA_ACT = cFechaHora.ObtenerFechaHora
                bAnticipo.ActualizarANTICIPO_CANA(lAnticipo)
            End If
            Me.AsignarMensaje("", True, False)
            Me.AsignarMensaje("La fecha se guardo con exito!", False, True, True)
        End If
    End Sub

    Protected Sub cbxZAFRA_ValueChanged(sender As Object, e As System.EventArgs) Handles cbxZAFRA.ValueChanged
        Me.ConfigMenu(DirectCast(sender, ASPxComboBox).Value)
    End Sub
End Class
