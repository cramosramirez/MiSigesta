Imports SISPACAL.EL
Imports SISPACAL.BL

Public Class SaldosZafraProductores02

    Public Sub CargarDatos(ByVal ID_ZAFRA As Integer, ByVal CODIPROVEEDOR As String, ByVal FECHA As DateTime, ByVal ID_PROVEE As Integer)
        Me.DS_SIFAG1.Clear()
        Me.SALDOS_ZAFRA_PRODUCTORESTableAdapter1.FillPorZafraAcumulado(Me.DS_SIFAG1.SALDOS_ZAFRA_PRODUCTORES, ID_ZAFRA, CODIPROVEEDOR, FECHA, ID_PROVEE)

        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZAFRA(ID_ZAFRA)
        If lZafra IsNot Nothing Then
            Me.lblZAFRA.Text = "ACUMULADO A LA ZAFRA " + lZafra.NOMBRE_ZAFRA + " Y A LA FECHA " + Format(FECHA, "dd/MM/yyyy")
        End If
    End Sub
End Class