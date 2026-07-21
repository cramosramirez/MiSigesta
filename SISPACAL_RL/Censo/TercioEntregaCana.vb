Imports SISPACAL.BL
Imports SISPACAL.EL

Public Class TercioEntregaCana


    Public Sub Cargar(ByVal ID_ZAFRA As Int32)
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZafraActiva

        Me.DS_SIGESTA1.Clear()
        Me.TERCIO_ENTREGA_CANATableAdapter1.FillPorZafra(Me.DS_SIGESTA1.TERCIO_ENTREGA_CANA, ID_ZAFRA, -1)

        If lZafra IsNot Nothing Then xrZafra.Text = "ZAFRA " + lZafra.NOMBRE_ZAFRA
        Me.DisplayName = "PLAN DE COSECHA CATORCENAL ZAFRA " + Replace(lZafra.NOMBRE_ZAFRA, "/", "-")
    End Sub
End Class