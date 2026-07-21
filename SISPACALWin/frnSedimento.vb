Public Class frnSedimento
    Private IdZafraActiva As Integer
    Private entidadEnvioSedimento As New ENVIO_SEDIMENTO
    Private cambioDatos As Boolean = False

    Private Sub frmSedimento_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmPrincipalRibbon.Habilitar(True)
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        If btnGuardar.Enabled AndAlso cambioDatos Then
            If MsgBox("¿Desea salir antes de guardar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, Application.ProductName) = MsgBoxResult.No Then
                Return
            End If
        End If
        Me.Close()
    End Sub

    'Procedimiento que establece la Zafra activa
    Private Sub ZafraActiva()
        Dim lZafra As ZAFRA
        lZafra = (New cZAFRA).ObtenerZafraActiva
        If lZafra IsNot Nothing Then
            IdZafraActiva = lZafra.ID_ZAFRA
        Else
            MsgBox("No se encontró una Zafra activa", MsgBoxStyle.Critical, Application.ProductName)
            Application.Exit()
        End If
    End Sub

    Private Sub validarCamposNumericos(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) _
            Handles txtVOLUMEN_SEDIMENTO.Validating

        cambioDatos = True
        Dim campo As TextBox = CType(sender, TextBox)
        campo.Text = campo.Text.Trim
        If Not IsNumeric(campo.Text) AndAlso campo.Text <> String.Empty Then
            If campo Is txtVOLUMEN_SEDIMENTO Then
                lblSEDIMENTO.Text = String.Empty
            End If
            e.Cancel = True
            MsgBox("Se requiere un valor numérico.", vbCritical, Application.ProductName)
            campo.SelectAll()
            campo.Focus()
            Exit Sub
        End If
        If campo.Name = "txtVOLUMEN_SEDIMENTO" Then
            txtVOLUMEN_SEDIMENTO.Text = Math.Round(Convert.ToDecimal(txtVOLUMEN_SEDIMENTO.Text), 2).ToString("#,##0.00")
            If Convert.ToDecimal(txtVOLUMEN_SEDIMENTO.Text) < 0 OrElse Convert.ToDecimal(txtVOLUMEN_SEDIMENTO.Text) > 8 Then
                MsgBox("El rango del volumen sedimento (mL) debe estar entre 0 y 8.", vbCritical, Application.ProductName)
                campo.SelectAll()
                campo.Focus()
                Exit Sub
            End If
            If txtVOLUMEN_SEDIMENTO.Text <> String.Empty Then lblSEDIMENTO.Text = Math.Round((Convert.ToDecimal(txtVOLUMEN_SEDIMENTO.Text) / CDec(15)) * 100, 2) Else lblSEDIMENTO.Text = String.Empty
        End If
    End Sub

    Private Sub txtTACO_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtTACO.Validating
        Dim Envios As listaENVIO
        Dim listaEnvioSedimento As ListaENVIO_SEDIMENTO

        txtTACO.Text = txtTACO.Text.Trim
        If txtTACO.Text.Length = 0 OrElse Not IsNumeric(txtTACO.Text) Then
            txtTACO.Text = String.Empty
            Return
        End If
        Envios = (New cENVIO).ObtenerListaPorBOLETA(IdZafraActiva, Convert.ToInt32(txtTACO.Text))
        If Envios IsNot Nothing AndAlso Envios.Count = 1 Then
            listaEnvioSedimento = (New cENVIO_SEDIMENTO).ObtenerListaPorENVIO(Envios(0).ID_ENVIO)

            If listaEnvioSedimento IsNot Nothing AndAlso listaEnvioSedimento.Count > 0 Then
                entidadEnvioSedimento = listaEnvioSedimento(0)
                If entidadEnvioSedimento.VOL_SEDIMENTO > -1 Then txtVOLUMEN_SEDIMENTO.Text = entidadEnvioSedimento.VOL_SEDIMENTO.ToString("#,##0.00")
                If entidadEnvioSedimento.SEDIMENTO > -1 Then lblSEDIMENTO.Text = entidadEnvioSedimento.SEDIMENTO.ToString("#,##0.00")
            Else
                entidadEnvioSedimento.ID_ENVIO_SEDI = 0
            End If
            txtTACO.Enabled = False
            btnNuevo.Enabled = True
            btnGuardar.Enabled = True
            txtVOLUMEN_SEDIMENTO.Enabled = True
            txtVOLUMEN_SEDIMENTO.Focus()
        Else
            MsgBox("La boleta " + txtTACO.Text + " no existe para esta Zafra", MsgBoxStyle.Critical, Application.ProductName)
            txtTACO.Text = String.Empty
            e.Cancel = True
        End If
    End Sub

    Private Sub escribirEntero(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtTACO.KeyPress
        If (Char.IsDigit(e.KeyChar)) Then
            e.Handled = False
        ElseIf e.KeyChar = Chr(13) Then
            e.Handled = True
            SendKeys.Send(vbTab)
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub frmSedimento_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Inicializar()
        ZafraActiva()
    End Sub

    Private Sub Inicializar()
        Me.txtTACO.Text = ""
        Me.txtVOLUMEN_SEDIMENTO.Text = ""
        Me.lblSEDIMENTO.Text = ""

        Me.txtTACO.Enabled = True
        Me.txtVOLUMEN_SEDIMENTO.Enabled = False

        Me.btnNuevo.Enabled = False
        Me.btnGuardar.Enabled = False
        Me.txtTACO.Focus()
    End Sub

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
        Dim lRet As Integer
        Dim bEnvioSedimento As New cENVIO_SEDIMENTO
        Dim Envios As listaENVIO

        If Me.txtVOLUMEN_SEDIMENTO.Text.Trim = "" Then
            MsgBox("Ingrese el valor de volumen de sedimento (mL)", MsgBoxStyle.Critical, Application.ProductName)
            txtVOLUMEN_SEDIMENTO.Focus()
            Exit Sub
        End If

        Envios = (New cENVIO).ObtenerListaPorBOLETA(IdZafraActiva, Convert.ToInt32(txtTACO.Text))
        If Envios IsNot Nothing AndAlso Envios.Count = 1 Then
            entidadEnvioSedimento.ID_ENVIO = Envios(0).ID_ENVIO
            entidadEnvioSedimento.VOL_SEDIMENTO = Convert.ToDecimal(Me.txtVOLUMEN_SEDIMENTO.Text)
            entidadEnvioSedimento.SEDIMENTO = Convert.ToDecimal(Me.lblSEDIMENTO.Text)
            entidadEnvioSedimento.USUARIO_CREA = Utilerias.ObtenerUsuario
            entidadEnvioSedimento.FECHA_CREA = cFechaHora.ObtenerFechaHora
        Else
            MsgBox("La boleta " + txtTACO.Text + " no existe para esta Zafra", MsgBoxStyle.Critical, Application.ProductName)
            Me.btnNuevo_Click(Me, e)
            Exit Sub
        End If


        lRet = bEnvioSedimento.ActualizarENVIO_SEDIMENTO(entidadEnvioSedimento)
        If lRet > 0 Then
            Me.btnGuardar.Enabled = False
            MsgBox("La información se guardo con éxito!", MsgBoxStyle.Exclamation, Application.ProductName)
            Me.btnNuevo_Click(Me, e)
        Else
            MsgBox("Error al guardar: " + bEnvioSedimento.sError, MsgBoxStyle.Critical, Application.ProductName)
        End If
    End Sub


    Private Sub btnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevo.Click
        If btnGuardar.Enabled AndAlso cambioDatos Then
            If MsgBox("¿Desea ingresar otra boleta antes de guardar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, Application.ProductName) = MsgBoxResult.No Then
                Return
            End If
        End If
        Inicializar()
    End Sub
End Class