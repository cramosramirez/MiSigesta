Public Class OrdenRozaCosecha

    Public Sub CargarDatos(ByVal ID_ZAFRA As Int32, USUARIO As String, FECHA As DateTime)
        Me.ORDEN_ROZA_COSECHATableAdapter1.FillPorZafraFiltro(Me.DS_SIGESTA1.ORDEN_ROZA_COSECHA, ID_ZAFRA, USUARIO, FECHA)
    End Sub
End Class