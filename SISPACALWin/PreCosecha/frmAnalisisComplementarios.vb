Public Class frmAnalisisComplementarios 
    Dim bFechaHora As New cFechaHora
    Private IdZafraActiva As Integer

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub frmAnalisisComplementarios_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmPrincipalRibbon.Habilitar(True)
    End Sub

    Private Sub frmAnalisisComplementarios_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Inicializar()
    End Sub

    Private Sub Inicializar()
        Me.speNoOrden.Enabled = True
        Me.speNoOrden.Text = Nothing
        Me.speAbsorbancia.Text = Nothing
        Me.lblDextrana.Text = Nothing
        Me.speAcidezJugo.Text = Nothing
        Me.speCantidadJugo.Text = Nothing
        Me.speVolTitulante.Text = Nothing
        Me.speAbsorbanciaAlmidon.Text = Nothing
        Me.speBrixDiluido.Text = Nothing
        Me.lblAzucarReductores.Text = Nothing
        Me.lblAlmidon.Text = Nothing
        Me.medObservacion.Text = Nothing
        Me.Habilitar(False)
        Me.ZafraActiva()
        Me.speNoOrden.Focus()
    End Sub

    Private Sub Habilitar(modo As Boolean)
        Me.speAbsorbancia.Enabled = modo
        Me.speAcidezJugo.Enabled = modo
        Me.speCantidadJugo.Enabled = modo
        Me.speVolTitulante.Enabled = modo
        Me.speAbsorbanciaAlmidon.Enabled = modo
        Me.speBrixDiluido.Enabled = modo
        Me.medObservacion.Enabled = modo
        Me.btnAceptar.Enabled = modo
        Me.btnNuevaMuestra.Enabled = modo
    End Sub

    Private Sub speNoOrden_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles speNoOrden.KeyPress
        If e.KeyChar = Chr(13) Then
            e.Handled = True
            SendKeys.Send(vbTab)
        End If
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

    Private Sub speNoOrden_LostFocus(sender As Object, e As System.EventArgs) Handles speNoOrden.LostFocus
        If speNoOrden.Text = Nothing Then
            Inicializar()
            Return
        End If

        Dim lEntidad As ANALISIS_PRECOSECHA = (New cANALISIS_PRECOSECHA).ObtenerPorZAFRA_NO_ANALISIS(IdZafraActiva, Convert.ToInt32(Me.speNoOrden.Value))
        If lEntidad IsNot Nothing Then
            If lEntidad.ABSORVANCIA <> -1 Then Me.speAbsorbancia.Value = Math.Round(lEntidad.ABSORVANCIA, 2)
            If lEntidad.DEXTRANA <> -1 Then Me.lblDextrana.Text = Math.Round(lEntidad.DEXTRANA, 2)
            If lEntidad.ACIDEZ_JUGO <> -1 Then Me.speAcidezJugo.Value = Math.Round(lEntidad.ACIDEZ_JUGO, 2)
            If lEntidad.CANT_JUGO_ML <> -1 Then Me.speCantidadJugo.Value = Math.Round(lEntidad.CANT_JUGO_ML, 2)
            If lEntidad.VOL_TITULANTE <> -1 Then Me.speVolTitulante.Value = Math.Round(lEntidad.VOL_TITULANTE, 2)
            If lEntidad.AZUCAR_REDUCTORES <> -1 Then Me.lblAzucarReductores.Text = Math.Round(lEntidad.AZUCAR_REDUCTORES, 2)
            If lEntidad.ABSORBANCIA_ALMIDON <> -1 Then Me.speAbsorbanciaAlmidon.Text = Math.Round(lEntidad.ABSORBANCIA_ALMIDON, 3)
            If lEntidad.BRIX_DILU <> -1 Then Me.speBrixDiluido.Text = Math.Round(lEntidad.BRIX_DILU, 2)
            If lEntidad.ALMIDON_JUGO <> -1 Then Me.lblAlmidon.Text = Math.Round(lEntidad.ALMIDON_JUGO, 2)
            Me.medObservacion.Text = lEntidad.OBSERVACION
            Me.speNoOrden.Enabled = False
            Me.Habilitar(True)
            Me.speAbsorbancia.Focus()
        Else
            Inicializar()
            Exit Sub
        End If
    End Sub

    Private Sub speAbsorbancia_LostFocus(sender As Object, e As System.EventArgs) Handles speAbsorbancia.LostFocus
        Me.lblDextrana.Text = Nothing
        If speAbsorbancia.Text = Nothing OrElse speAbsorbancia.Value = 0 Then
            Me.speAbsorbancia.Text = Nothing
            Return
        End If
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        If lZafra Is Nothing Then
            MsgBox("No de ha definido una zafra activa", MsgBoxStyle.Critical, Application.ProductName)
            Exit Sub
        End If
        If Me.speAbsorbancia.Value > 5 Then
            MsgBox("Absorbancia no puede ser mayor de 5", MsgBoxStyle.Critical, Application.ProductName)
            Me.speAbsorbancia.Text = Nothing
            Me.speAbsorbancia.Focus()
            Exit Sub
        End If
        Dim lParametrosFormula As listaPARAM_PRECOSECHA = (New cPARAM_PRECOSECHA).ObtenerListaPorZAFRA(lZafra.ID_ZAFRA)
        If lParametrosFormula IsNot Nothing AndAlso lParametrosFormula.Count > 0 Then
            Me.lblDextrana.Text = Math.Round((lParametrosFormula(0).CTE_A_DEXTRA + Me.speAbsorbancia.Value) / lParametrosFormula(0).CTE_B_DEXTRA, 2)
        Else
            MsgBox("No se han definido las constantes de la fórmula de Dextrana", MsgBoxStyle.Critical, Application.ProductName)
            Exit Sub
        End If
    End Sub

    Private Sub CalcularAlmidon()
        Me.lblAlmidon.Text = Nothing
        If Me.speAbsorbanciaAlmidon.Value = 0 Then
            Return
        End If
        Me.speAbsorbanciaAlmidon.Value = Math.Round(Me.speAbsorbanciaAlmidon.Value, 3)
        If Me.speBrixDiluido.Value > 0 AndAlso (Me.speBrixDiluido.Value < 14 OrElse Me.speBrixDiluido.Value > 17) Then
            MsgBox("Brix diluido del almidon debe estar comprendida en el rango de 14 y 17", MsgBoxStyle.Critical, Application.ProductName)
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

    Private Sub speAcidezJugo_LostFocus(sender As Object, e As System.EventArgs) Handles speAcidezJugo.LostFocus
        If speAcidezJugo.Text = Nothing OrElse speAcidezJugo.Value = 0 Then
            Me.speAcidezJugo.Text = Nothing
            Return
        End If
        If Me.speAcidezJugo.Value > 10 Then
            MsgBox("Acidez en Jugo no puede ser mayor de 10", MsgBoxStyle.Critical, Application.ProductName)
            Me.speAcidezJugo.Text = Nothing
            Me.speAcidezJugo.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub speCantidadJugo_LostFocus(sender As Object, e As System.EventArgs) Handles speCantidadJugo.LostFocus
        lblAzucarReductores.Text = ""
        If speCantidadJugo.Text = Nothing OrElse speCantidadJugo.Value = 0 Then
            Me.speCantidadJugo.Text = Nothing
            Exit Sub
        End If
        If (Me.speCantidadJugo.Value > 95 OrElse Me.speCantidadJugo.Value < 5) Then
            MsgBox("Cantidad de Jugo debe estar en el rango de 5 a 95 gramos", MsgBoxStyle.Critical, Application.ProductName)
            Me.speCantidadJugo.Text = Nothing
            Me.speCantidadJugo.Focus()
            Exit Sub
        End If
        Me.CalculoAzucaresReductores()
    End Sub

    Private Sub speVolTitulante_LostFocus(sender As Object, e As System.EventArgs) Handles speVolTitulante.LostFocus
        lblAzucarReductores.Text = ""
        If speVolTitulante.Text = Nothing OrElse speVolTitulante.Value = 0 Then
            Me.speVolTitulante.Text = Nothing
            Exit Sub
        End If
        If Me.speVolTitulante.Value > 100 OrElse Me.speVolTitulante.Value < 5 Then
            MsgBox("Volumen titulante debe estar en el rango de 5 a 100 mL", MsgBoxStyle.Critical, Application.ProductName)
            Me.speVolTitulante.Text = Nothing
            Me.speVolTitulante.Focus()
            Exit Sub
        End If
        Me.CalculoAzucaresReductores()
    End Sub

    Private Sub CalculoAzucaresReductores()
        lblAzucarReductores.Text = ""
        If (Me.speCantidadJugo.Text <> Nothing AndAlso IsNumeric(Me.speCantidadJugo.Value) AndAlso Me.speCantidadJugo.Value <> 0) AndAlso _
         (Me.speVolTitulante.Text <> Nothing AndAlso IsNumeric(Me.speVolTitulante.Value) AndAlso Me.speVolTitulante.Value <> 0) Then

            lblAzucarReductores.Text = Math.Round(500 / (Me.speCantidadJugo.Value * speVolTitulante.Value), 2)
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
        Dim lEntidad As ANALISIS_PRECOSECHA = (New cANALISIS_PRECOSECHA).ObtenerPorZAFRA_NO_ANALISIS(IdZafraActiva, Me.speNoOrden.Value)
        Dim bAnalisis As New cANALISIS_PRECOSECHA
        If lEntidad IsNot Nothing Then
            If speAbsorbancia.Value > 0 Then
                lEntidad.ABSORVANCIA = speAbsorbancia.Value
                lEntidad.DEXTRANA = Convert.ToDecimal(lblDextrana.Text)
            Else
                lEntidad.ABSORVANCIA = -1
                lEntidad.DEXTRANA = -1
            End If
            If speAcidezJugo.Value > 0 Then
                lEntidad.ACIDEZ_JUGO = speAcidezJugo.Value
            Else
                lEntidad.ACIDEZ_JUGO = -1
            End If
            If speCantidadJugo.Value > 0 AndAlso speVolTitulante.Value > 0 Then
                lEntidad.CANT_JUGO_ML = speCantidadJugo.Value
                lEntidad.VOL_TITULANTE = speVolTitulante.Value
                lEntidad.AZUCAR_REDUCTORES = Convert.ToDecimal(lblAzucarReductores.Text)
            Else
                lEntidad.CANT_JUGO_ML = -1
                lEntidad.VOL_TITULANTE = -1
                lEntidad.AZUCAR_REDUCTORES = -1
            End If
            If speAbsorbanciaAlmidon.Value > 0 AndAlso speBrixDiluido.Value > 0 Then
                lEntidad.ABSORBANCIA_ALMIDON = speAbsorbanciaAlmidon.Value
                lEntidad.BRIX_DILU = speBrixDiluido.Value
                lEntidad.ALMIDON_JUGO = Convert.ToDecimal(lblAlmidon.Text)
            Else
                lEntidad.ABSORBANCIA_ALMIDON = -1
                lEntidad.BRIX_DILU = -1
                lEntidad.ALMIDON_JUGO = -1
            End If
            lEntidad.OBSERVACION = medObservacion.Text
            lEntidad.USUARIO_ACT = configuracion.usuarioActualiza
            lEntidad.FECHA_CT = cFechaHora.ObtenerFechaHora
            If bAnalisis.ActualizarANALISIS_PRECOSECHA(lEntidad) < 1 Then
                MsgBox("No se actualizó la información: " + bAnalisis.sError, MsgBoxStyle.Critical, Application.ProductName)
                Exit Sub
            End If
            MsgBox("Análisis complementario ha sido guardado!", MsgBoxStyle.Information, Application.ProductName)
            Me.Inicializar()
        Else
            MsgBox("No existe el N° de Orden", MsgBoxStyle.Critical, Application.ProductName)
        End If
    End Sub
    
    Private Sub btnNuevaMuestra_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevaMuestra.Click
        Me.Inicializar()
    End Sub

    Private Sub speAbsorbanciaAlmidon_LostFocus(sender As Object, e As System.EventArgs) Handles speAbsorbanciaAlmidon.LostFocus
        Me.CalcularAlmidon()
    End Sub

    Private Sub speBrixDiluido_LostFocus(sender As Object, e As System.EventArgs) Handles speBrixDiluido.LostFocus
        Me.CalcularAlmidon()
    End Sub

    Private Sub speNoOrden_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles speNoOrden.EditValueChanged

    End Sub
End Class