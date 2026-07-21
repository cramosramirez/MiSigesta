Imports SISPACAL.BL
Imports SISPACAL.EL

Public Class InventarioCanaTransporte

    Public Sub CargarDatos(ByVal ID_ZAFRA As Int32, ByVal ES_TRANSPORTE As Boolean)
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZAFRA(ID_ZAFRA)
        If lZafra IsNot Nothing Then Me.xrZafra.Text = "ZAFRA " + lZafra.NOMBRE_ZAFRA

        Me.DS_SIGESTA1.Clear()
        Me.INVENTARIO_CANATableAdapter1.FillPorZafra(DS_SIGESTA1.INVENTARIO_CANA, ID_ZAFRA, ES_TRANSPORTE)
    End Sub
End Class