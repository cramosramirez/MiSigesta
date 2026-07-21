Public Class SolicitudRetiroProductoConsignadoProductor
    Private mID_SALBODE_ENCA As Int32

    Public Sub Cargar(ByVal ID_SALBODE_ENCA As Int32)
        mID_SALBODE_ENCA = ID_SALBODE_ENCA
        Me.DS_SIFAG1.Clear()
        Me.SALBODE_ENCATableAdapter1.FillPorId(DS_SIFAG1.SALBODE_ENCA, ID_SALBODE_ENCA)
        Me.DisplayName = "SolicitudRetirodeProductoConsignadoProductor"
    End Sub

End Class