Imports SISPACAL.EL
Imports SISPACAL.BL

Public Class PlanCosechaDiarioPorLote
    Public Sub CargarDatos(ByVal ID_ZAFRA As Int32, ByVal FECHA As DateTime, ByVal ZONA As String, ByVal AUTORIZADO As Int32)
        Dim lZafra As ZAFRA
        Me.xrFECHA.Text = "A LA FECHA: " + FECHA.ToString("dd/MM/yyyy") + " HORA: " + FECHA.ToString("HH:mm")
        Me.PLAN_COSECHA_DIARIOTableAdapter1.FillPorCriterios(Me.DS_SIGESTA1.PLAN_COSECHA_DIARIO, ID_ZAFRA, FECHA, ZONA, AUTORIZADO)

        lZafra = (New cZAFRA).ObtenerZAFRA(ID_ZAFRA)
        If lZafra IsNot Nothing Then xrZafra.Text += lZafra.NOMBRE_ZAFRA
        Me.DisplayName = "PLAN DE COSECHA DIARIO POR LOTE ZAFRA " + Replace(lZafra.NOMBRE_ZAFRA, "/", "-")
    End Sub
End Class