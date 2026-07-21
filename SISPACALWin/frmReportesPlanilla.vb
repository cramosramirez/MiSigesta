Public Class frmReportesPlanilla

    Private Sub Inicializar()
        Dim lZafraActiva As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        Me.CbxZAFRA1.Recuperar()
        If lZafraActiva IsNot Nothing Then Me.CbxZAFRA1.SelectedValue = lZafraActiva.ID_ZAFRA
        If Me.CbxZAFRA1.SelectedValue IsNot Nothing Then
            Me.CbxCATORCENA_ZAFRA1.RecuperarPorZAFRA(Me.CbxZAFRA1.SelectedValue)
            Me.CbxCATORCENA_ZAFRA1.SelectedValue = IdUltimaCatorcena(Me.CbxZAFRA1.SelectedValue)
        End If
        Me.CbxTIPO_PLANILLA1.Recuperar()
        Me.CbxTIPO_PAGO1.Recuperar()
        Me.CbxTIPO_PAGO1.SelectedIndex = 0
        Me.lblRangoCompensacion.Visible = False
        Me.cbxRANGO_COMPENSACION1.Visible = False
    End Sub

    Private Function IdUltimaCatorcena(ByVal ID_ZAFRA As Integer) As Integer
        Dim lEntidad As CATORCENA_ZAFRA

        lEntidad = (New cCATORCENA_ZAFRA).ObtenerUltimaCatorcenaCerradaZafra(ID_ZAFRA)
        If lEntidad IsNot Nothing Then
            Return lEntidad.ID_CATORCENA
        End If
        Return -1
    End Function

    Private Sub frmReportesPlanilla_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmPrincipalRibbon.Habilitar(True)
    End Sub

    Private Sub frmReportesPlanilla_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Me.Inicializar()
    End Sub

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub CbxZAFRA1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CbxZAFRA1.SelectedIndexChanged
        Me.CbxCATORCENA_ZAFRA1.RecuperarPorZAFRA(Me.CbxZAFRA1.SelectedValue)
        Me.CbxCATORCENA_ZAFRA1.SelectedValue = IdUltimaCatorcena(Me.CbxZAFRA1.SelectedValue)
    End Sub

    Private Sub btnVerPlanilla_Click(sender As System.Object, e As System.EventArgs) Handles btnVerPlanilla.Click
        Dim esContribuyente As Boolean = rdbContribuyente.Checked
        Dim tipoPago As Integer = -1

        If Me.CbxTIPO_PAGO1.SelectedIndex = 1 Then
            tipoPago = 0
        ElseIf Me.CbxTIPO_PAGO1.SelectedIndex = 2 Then
            tipoPago = 1
        End If
        frmImpresiones.CargarPlanilla(Me.CbxCATORCENA_ZAFRA1.SelectedValue, Me.CbxTIPO_PLANILLA1.SelectedValue, esContribuyente, Me.cbxRANGO_COMPENSACION1.SelectedValue, tipoPago)
        frmImpresiones.ShowDialog()
    End Sub

    Private Sub ConfigRangoCompensacion()
        If CInt(CbxTIPO_PLANILLA1.SelectedValue) = Enumeradores.TipoPlanilla.CompensacionEntregaCana Then
            If Me.CbxCATORCENA_ZAFRA1.SelectedValue IsNot Nothing Then
                Me.cbxRANGO_COMPENSACION1.RecuperarPorCATORCENA_ZAFRA(Me.CbxCATORCENA_ZAFRA1.SelectedValue)
            Else
                Me.cbxRANGO_COMPENSACION1.RecuperarPorCATORCENA_ZAFRA(-1)
            End If
            Me.lblRangoCompensacion.Visible = True
            Me.cbxRANGO_COMPENSACION1.Visible = True
        Else
            Me.lblRangoCompensacion.Visible = False
            Me.cbxRANGO_COMPENSACION1.Visible = False
        End If
    End Sub

    Private Sub CbxCATORCENA_ZAFRA1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CbxCATORCENA_ZAFRA1.SelectedIndexChanged
        Me.ConfigRangoCompensacion()
    End Sub

    Private Sub CbxTIPO_PLANILLA1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CbxTIPO_PLANILLA1.SelectedIndexChanged
        Me.ConfigRangoCompensacion()
    End Sub
End Class