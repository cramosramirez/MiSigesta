Imports SISPACAL.BL
Imports SISPACAL.EL

Public Class InventarioRozaDiariaProveedor

    Public Sub CargarDatos(ByVal ID_ZAFRA As Int32, ByVal ZONA As String, ByVal OPCION As String)
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZAFRA(ID_ZAFRA)
        If lZafra IsNot Nothing Then xrZafra.Text = "ZAFRA " + lZafra.NOMBRE_ZAFRA
        Me.xlblSubtitulo.Text = OPCION

        DS_SIGESTA1.Clear()
        INVENTARIO_ROZA_DIARIA_PROVEEDORTableAdapter1.FillPorZafra(DS_SIGESTA1.INVENTARIO_ROZA_DIARIA_PROVEEDOR, ID_ZAFRA, ZONA, OPCION)
        Me.DisplayName = "ROZA DIARIA EJECUTADA POR FRENTE DE ROZA ZAFRA " + Replace(lZafra.NOMBRE_ZAFRA, "/", "-")
    End Sub
End Class