Public Class SaldosInsolutosPorProveeAgricola


    Public Sub Cargar(ByVal ID_ZAFRA As Integer, ByVal ID_PROVEE As Integer, ByVal CODIPROVEEDOR As String, ByVal ID_CUENTA_FINAN As Integer, ByVal ES_BANCO As Boolean)
        Me.DS_SIFAG1.Clear()
        Me.RPT_SALDOS_INSOLUTOSTableAdapter1.FillPorProveedorAgri(Me.DS_SIFAG1.RPT_SALDOS_INSOLUTOS, ID_ZAFRA, ID_PROVEE, CODIPROVEEDOR, ID_CUENTA_FINAN, 2, ES_BANCO)

        If Me.DS_SIFAG1.RPT_SALDOS_INSOLUTOS.Rows.Count > 0 Then
            Me.xrZafra1.Text = "ZAFRA " + Me.DS_SIFAG1.RPT_SALDOS_INSOLUTOS.Rows(0)("ZAFRA_1").ToString
            Me.xrZafra2.Text = "ZAFRA " + Me.DS_SIFAG1.RPT_SALDOS_INSOLUTOS.Rows(0)("ZAFRA_2").ToString
            Me.xrZafra3.Text = "ZAFRA " + Me.DS_SIFAG1.RPT_SALDOS_INSOLUTOS.Rows(0)("ZAFRA_3").ToString
            Me.xrZafra4.Text = "ZAFRA " + Me.DS_SIFAG1.RPT_SALDOS_INSOLUTOS.Rows(0)("ZAFRA_4").ToString
            Me.xrZafra5.Text = "ZAFRA " + Me.DS_SIFAG1.RPT_SALDOS_INSOLUTOS.Rows(0)("ZAFRA_5").ToString
            Me.xrZafraSeleccionada.Text = "ZAFRA " + Me.DS_SIFAG1.RPT_SALDOS_INSOLUTOS.Rows(0)("ZAFRA_SELECCIONADA").ToString
        End If
    End Sub
End Class