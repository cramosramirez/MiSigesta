Public Class SaldosInsolutosPorProveeFinan


    Public Sub Cargar(ByVal ID_ZAFRA As Integer, ByVal CODIPROVEEDOR As String, ByVal ID_CUENTA_FINAN As Integer, ByVal ES_TOTAL As Boolean)
        Me.DS_SIFAG1.Clear()
        Me.RPT_SALDOS_INSOLUTOSTableAdapter1.FillPorCriterios(Me.DS_SIFAG1.RPT_SALDOS_INSOLUTOS, ID_ZAFRA, CODIPROVEEDOR, ID_CUENTA_FINAN, 1, ES_TOTAL)

        Me.xrZafra1.Text = "ZAFRA " + Me.DS_SIFAG1.RPT_SALDOS_INSOLUTOS.Rows(0)("ZAFRA_1").ToString
        Me.xrZafra2.Text = "ZAFRA " + Me.DS_SIFAG1.RPT_SALDOS_INSOLUTOS.Rows(0)("ZAFRA_2").ToString
        Me.xrZafra3.Text = "ZAFRA " + Me.DS_SIFAG1.RPT_SALDOS_INSOLUTOS.Rows(0)("ZAFRA_3").ToString
        Me.xrZafra4.Text = "ZAFRA " + Me.DS_SIFAG1.RPT_SALDOS_INSOLUTOS.Rows(0)("ZAFRA_4").ToString
        Me.xrZafra5.Text = "ZAFRA " + Me.DS_SIFAG1.RPT_SALDOS_INSOLUTOS.Rows(0)("ZAFRA_5").ToString
        Me.xrZafraSeleccionada.Text = "ZAFRA " + Me.DS_SIFAG1.RPT_SALDOS_INSOLUTOS.Rows(0)("ZAFRA_SELECCIONADA").ToString

        If ES_TOTAL Then
            Me.tblEnca.DeleteColumn(XrTableCell5)
            Me.tblDeta.DeleteColumn(XrTableCell14)
            Me.tblPie.DeleteColumn(XrTableCell3)
            Me.tblEnca.LeftF = 100
            Me.tblDeta.LeftF = 100
            Me.tblPie.LeftF = 100
        End If
    End Sub
End Class