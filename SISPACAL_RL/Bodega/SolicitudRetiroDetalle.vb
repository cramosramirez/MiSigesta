Public Class SolicitudRetiroDetalle

    Public Sub CargarDetalle(ByVal ID_SALBODE_ENCA As Int32)
        Me.DS_SIFAG1.Clear()
        Me.SALBODE_DETATableAdapter1.FillPorId(Me.DS_SIFAG1.SALBODE_DETA, ID_SALBODE_ENCA)
        Me.DisplayName = "SolicitudRetirodeProductosBodega"
    End Sub
End Class