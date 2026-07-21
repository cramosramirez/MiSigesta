Public Class frmAlmidonCosecha
    Private IdZafraActiva As Integer
    Private entidadEnvio As ENVIO
    Private entidadDatosLab As DATOS_LABORATORIO

    Private Sub frmAlmidonCosecha_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmPrincipalRibbon.Habilitar(True)
    End Sub

    Private Sub frmAlmidonCosecha_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Inicializar()
        ZafraActiva()
    End Sub

    Private Sub CalcularAlmidon()
        Me.lblAlmidon.Text = Nothing
        If Me.speAbsorbanciaAlmidon.Value = 0 Then
            Return
        End If
        Me.speAbsorbanciaAlmidon.Value = Math.Round(Me.speAbsorbanciaAlmidon.Value, 3)
        If Me.speBrixDiluido.Value > 0 AndAlso (Me.speBrixDiluido.Value < 14 OrElse Me.speBrixDiluido.Value > 17) Then
            MsgBox("Brix diluido del almidon debe estar comprendido en el rango de 14 y 17", MsgBoxStyle.Critical, Application.ProductName)
            Me.speBrixDiluido.Text = Nothing
            Me.speBrixDiluido.Focus()
            Exit Sub
        End If
        Dim gramosSacarosa As Decimal = 0
        Dim lTablaBrix As listaBRIX_SACAROSA = (New cBRIX_SACAROSA).ObtenerLista
        For Each lBrixSacarosa As BRIX_SACAROSA In lTablaBrix
            If lBrixSacarosa.BRIX = Me.speBrixDiluido.Value Then
                gramosSacarosa = lBrixSacarosa.GRAMOS_SACAROSA
                Exit For
            End If
        Next
        If gramosSacarosa > 0 Then
            Me.lblAlmidon.Text = Math.Round(((Me.speAbsorbanciaAlmidon.Value + 0.0097) / 0.0021) / (3 * gramosSacarosa), 2)
        End If
    End Sub

    Private Sub Inicializar()
        Me.txtTACO.Text = ""
        Me.txtTACO.Enabled = True

        Me.speAbsorbanciaAlmidon.Enabled = False
        Me.speAbsorbanciaAlmidon.Text = Nothing
        Me.speBrixDiluido.Enabled = False
        Me.speBrixDiluido.Text = Nothing
        Me.lblAlmidon.Text = Nothing

        Me.btnNuevo.Enabled = False
        Me.btnGuardar.Enabled = False
        Me.txtTACO.Focus()
    End Sub

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

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevo.Click
        Inicializar()
    End Sub

    Private Sub txtTACO_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtTACO.Validating
        Dim Envios As listaENVIO
        Dim lAnalisis As listaANALISIS

        entidadDatosLab = New DATOS_LABORATORIO
        txtTACO.Text = txtTACO.Text.Trim
        If txtTACO.Text.Length = 0 OrElse Not IsNumeric(txtTACO.Text) Then
            txtTACO.Text = String.Empty
            Return
        End If
        Envios = (New cENVIO).ObtenerListaPorBOLETA(IdZafraActiva, Convert.ToInt32(txtTACO.Text))
        If Envios IsNot Nothing AndAlso Envios.Count = 1 Then
            entidadEnvio = Envios(0)
            lAnalisis = (New cANALISIS).ObtenerListaPorENVIO(entidadEnvio.ID_ENVIO)
            If lAnalisis IsNot Nothing AndAlso lAnalisis.Count > 0 Then
                Dim listaDatos As listaDATOS_LABORATORIO = (New cDATOS_LABORATORIO).ObtenerListaPorANALISIS(lAnalisis(0).ID_ANALISIS)
                If listaDatos IsNot Nothing AndAlso listaDatos.Count > 0 Then
                    entidadDatosLab = listaDatos(0)
                    If entidadDatosLab.ABSORBANCIA_ALMIDON <> -1 Then Me.speAbsorbanciaAlmidon.Text = Math.Round(entidadDatosLab.ABSORBANCIA_ALMIDON, 3)
                    If entidadDatosLab.BRIX_DILU <> -1 Then Me.speBrixDiluido.Text = Math.Round(entidadDatosLab.BRIX_DILU, 1)
                    If entidadDatosLab.ALMIDON_JUGO <> -1 Then Me.lblAlmidon.Text = Math.Round(entidadDatosLab.ALMIDON_JUGO, 2)
                Else
                    entidadDatosLab.ID_DATOS_LAB = 0
                    entidadDatosLab.ID_ANALISIS = lAnalisis(0).ID_ANALISIS
                End If

                txtTACO.Enabled = False
                btnNuevo.Enabled = True
                btnGuardar.Enabled = True
                speAbsorbanciaAlmidon.Enabled = True
                speBrixDiluido.Enabled = True
                speAbsorbanciaAlmidon.Focus()
            Else
                MsgBox("El taco " + txtTACO.Text + " no tiene asociado capturas de peso, pol y brix", MsgBoxStyle.Critical, Application.ProductName)
                txtTACO.Text = String.Empty
                e.Cancel = True
            End If
        Else
            MsgBox("El taco " + txtTACO.Text + " no existe para esta Zafra", MsgBoxStyle.Critical, Application.ProductName)
            txtTACO.Text = String.Empty
            e.Cancel = True
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
        Dim lRet As Integer
        Dim bDatos As New cDATOS_LABORATORIO

        If Me.speAbsorbanciaAlmidon.Text.Trim = "" Then
            MsgBox("Ingrese el valor de ABSORBANCIA", MsgBoxStyle.Critical, Application.ProductName)
            speAbsorbanciaAlmidon.Focus()
            Exit Sub
        End If
        If Me.speBrixDiluido.Text.Trim = "" Then
            MsgBox("Ingrese el valor de BRIX DILUIDO", MsgBoxStyle.Critical, Application.ProductName)
            speAbsorbanciaAlmidon.Focus()
            Exit Sub
        End If
        entidadDatosLab.ABSORBANCIA_ALMIDON = speAbsorbanciaAlmidon.Value
        entidadDatosLab.BRIX_DILU = speBrixDiluido.Value
        entidadDatosLab.ALMIDON_JUGO = Convert.ToDecimal(lblAlmidon.Text)

        lRet = bDatos.ActualizarDATOS_LABORATORIO(entidadDatosLab)
        If lRet > 0 Then
            Me.btnGuardar.Enabled = False
            MsgBox("La información se guardo con éxito!", MsgBoxStyle.Exclamation, Application.ProductName)
            Me.btnNuevo_Click(Me, e)
        Else
            MsgBox("Error al guardar: " + bDatos.sError, MsgBoxStyle.Critical, Application.ProductName)
        End If
    End Sub

    Private Sub speAbsorbanciaAlmidon_LostFocus(sender As Object, e As System.EventArgs) Handles speAbsorbanciaAlmidon.LostFocus
        Me.CalcularAlmidon()
    End Sub

    Private Sub speBrixDiluido_LostFocus(sender As Object, e As System.EventArgs) Handles speBrixDiluido.LostFocus
        Me.CalcularAlmidon()
    End Sub
End Class