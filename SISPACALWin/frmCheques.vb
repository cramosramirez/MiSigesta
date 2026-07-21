Public Class frmCheques

    Private Sub frmCheques_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmPrincipalRibbon.Habilitar(True)
    End Sub

    Private Sub frmCheques_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Inicializar()
    End Sub

    Private Function IdUltimaCatorcena(ByVal ID_ZAFRA As Integer) As Integer
        Dim lEntidad As CATORCENA_ZAFRA

        lEntidad = (New cCATORCENA_ZAFRA).ObtenerUltimaCatorcenaCerradaZafra(ID_ZAFRA)
        If lEntidad IsNot Nothing Then
            Return lEntidad.ID_CATORCENA
        End If
        Return -1
    End Function

    Private Sub Inicializar()
        Dim lZafraActiva As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        Me.CbxZAFRA1.Recuperar()
        If lZafraActiva IsNot Nothing Then Me.CbxZAFRA1.SelectedValue = lZafraActiva.ID_ZAFRA
        If Me.CbxZAFRA1.SelectedValue IsNot Nothing Then
            Me.CbxCATORCENA_ZAFRA1.RecuperarPorZAFRA(Me.CbxZAFRA1.SelectedValue)
            Me.CbxCATORCENA_ZAFRA1.SelectedValue = IdUltimaCatorcena(Me.CbxZAFRA1.SelectedValue)
        End If
        Me.CbxTIPO_PLANILLA1.Recuperar()
        Me.RecuperarBancos()
        Me.lblRangoCompensacion.Visible = False
        Me.cbxRANGO_COMPENSACION1.Visible = False
    End Sub

    Private Sub RecuperarBancos()
        Dim tipoContribuyente As Integer

        If rdbTodos.Checked Then
            tipoContribuyente = -1
        ElseIf rdbContribuyente.Checked Then
            tipoContribuyente = 1
        ElseIf rdbNoContribuyente.Checked Then
            tipoContribuyente = 0
        End If
        Me.CbxBANCOS1.RecuperarPorCatorcena_Planilla_TipoContribuyente(Me.CbxCATORCENA_ZAFRA1.SelectedValue, Me.CbxTIPO_PLANILLA1.SelectedValue, tipoContribuyente)
    End Sub

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub CbxZAFRA1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CbxZAFRA1.SelectedIndexChanged
        Me.CbxCATORCENA_ZAFRA1.RecuperarPorZAFRA(Me.CbxZAFRA1.SelectedValue)
        Me.CbxCATORCENA_ZAFRA1.SelectedValue = IdUltimaCatorcena(Me.CbxZAFRA1.SelectedValue)
        Me.RecuperarBancos()
    End Sub

    Private Sub btnVerCheques_Click(sender As System.Object, e As System.EventArgs) Handles btnVerCheques.Click
        Dim tipoContribuyente As Integer

        If CbxBANCOS1.SelectedValue Is Nothing Then
            MsgBox("Seleccione el banco", vbCritical, Application.ProductName)
            Return
        End If

        If rdbTodos.Checked Then
            tipoContribuyente = -1
        ElseIf rdbContribuyente.Checked Then
            tipoContribuyente = 1
        ElseIf rdbNoContribuyente.Checked Then
            tipoContribuyente = 0
        End If
        frmImpresiones.CargarCheques(Me.CbxCATORCENA_ZAFRA1.SelectedValue, Me.CbxTIPO_PLANILLA1.SelectedValue, tipoContribuyente, Me.CbxBANCOS1.SelectedValue, Me.cbxRANGO_COMPENSACION1.SelectedValue)
        frmImpresiones.ShowDialog()
    End Sub

    Private Sub CbxTIPO_PLANILLA1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CbxTIPO_PLANILLA1.SelectedIndexChanged
        Me.RecuperarBancos()
        Me.ConfigRangoCompensacion()
    End Sub

    Private Sub rdbTodos_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdbTodos.CheckedChanged
        Me.RecuperarBancos()
    End Sub

    Private Sub rdbContribuyente_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdbContribuyente.CheckedChanged
        Me.RecuperarBancos()
    End Sub

    Private Sub rdbNoContribuyente_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdbNoContribuyente.CheckedChanged
        Me.RecuperarBancos()
    End Sub

    Private Sub CbxCATORCENA_ZAFRA1_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles CbxCATORCENA_ZAFRA1.SelectedIndexChanged
        Me.RecuperarBancos()
        Me.ConfigRangoCompensacion()
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
End Class