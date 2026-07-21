Imports SISPACAL.BL
Imports SISPACAL.EL

Public Class InventarioRozaSaldos

    Public Sub CargarDatos(ByVal ID_ZAFRA As Int32, ByVal ZONA As String, ByVal OPCION As String)
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZAFRA(ID_ZAFRA)
        If lZafra IsNot Nothing Then xrZafra.Text = "ZAFRA " + lZafra.NOMBRE_ZAFRA
        Me.xlblSubtitulo.Text = OPCION

        DS_SIGESTA1.Clear()
        INVENTARIO_ROZA_SALDOSTableAdapter1.FillPorZafra(DS_SIGESTA1.INVENTARIO_ROZA_SALDOS, ID_ZAFRA, ZONA, OPCION)
        Me.DisplayName = "SALDOS DE INVENTARIOS DE CAÑA POR LOTE - TIPO DE CAÑA Y FORMA DE COSECHA ZAFRA " + Replace(lZafra.NOMBRE_ZAFRA, "/", "-")
    End Sub

End Class