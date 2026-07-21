Imports SISPACAL.EL
Imports SISPACAL.BL

Public Class SaldosZafraProductores01

    Public Sub CargarDatos(ByVal ID_ZAFRA As Integer, ByVal CODIPROVEEDOR As String)
        Me.DS_SIFAG1.Clear()
        Me.SALDOS_ZAFRA_PRODUCTORESTableAdapter1.FillPorCriterios(Me.DS_SIFAG1.SALDOS_ZAFRA_PRODUCTORES, ID_ZAFRA, CODIPROVEEDOR)

        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZAFRA(ID_ZAFRA)
        If lZafra IsNot Nothing Then
            Me.lblZAFRA.Text = "ZAFRA " + lZafra.NOMBRE_ZAFRA
        End If
    End Sub
End Class