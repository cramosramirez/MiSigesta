Imports SISPACAL.BL
Imports SISPACAL.EL

Public Class EntregasAnomalas

    Public Sub Cargar(ByVal ID_ZAFRA As Integer, ByVal DIA_ZAFRA1 As Integer, ByVal DIA_ZAFRA2 As Integer, ByVal VER_SOLO_ANOMALOS As Boolean)
        Me.DS_SIGESTA1.Clear()
        Me.REPORTE_ENTREGA_ANOMALOTableAdapter1.FillPorCriterios(Me.DS_SIGESTA1.REPORTE_ENTREGA_ANOMALO, ID_ZAFRA, DIA_ZAFRA1, DIA_ZAFRA2, VER_SOLO_ANOMALOS)

        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZAFRA(ID_ZAFRA)
        If lZafra IsNot Nothing Then
            xrZafra.Text = "ZAFRA " + lZafra.NOMBRE_ZAFRA
            Me.DisplayName = "ENTREGAS DE CAÑA CON RENDIMIENTOS ANOMALOS ZAFRA " + Replace(lZafra.NOMBRE_ZAFRA, "/", "-")
        End If
    End Sub

End Class