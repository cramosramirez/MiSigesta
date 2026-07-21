Public Class Kardex

    Public Sub CargarDatos(ByVal ID_ZAFRA As Int32, ByVal ID_BODEGA As Int32, ByVal DESCRIPCION As String, ByVal FECHA As String, ByVal FECHA_FIN As String, ByVal ID_PRODUCTO As Int32, ByVal UID As String)
        Me.DS_SIFAG1.Clear()
        Me.REPORTE_KARDEXTableAdapter1.FillBy(Me.DS_SIFAG1.REPORTE_KARDEX, ID_ZAFRA, ID_BODEGA, DESCRIPCION, FECHA, FECHA_FIN, ID_PRODUCTO, UID)
        Me.DisplayName = "Kardex"
    End Sub

End Class