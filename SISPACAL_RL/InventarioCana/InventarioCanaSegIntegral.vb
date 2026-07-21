Imports SISPACAL.BL
Imports SISPACAL.EL

Public Class InventarioCanaSegIntegral

    Public Sub CargarDatos(ByVal ID_ZAFRA As Int32, ByVal ZONA As String, ByVal OPCION As String)
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZAFRA(ID_ZAFRA)
        If lZafra IsNot Nothing Then Me.xrZafra.Text = "ZAFRA " + lZafra.NOMBRE_ZAFRA
        Me.xlblSubtitulo.Text = OPCION

        Me.DS_SIGESTA1.Clear()
        Me.INVENTARIO_CANA_SEGUINTEGRALTableAdapter1.FillPorZafraZona(Me.DS_SIGESTA1.INVENTARIO_CANA_SEGUINTEGRAL, ID_ZAFRA, ZONA, OPCION)
    End Sub
End Class