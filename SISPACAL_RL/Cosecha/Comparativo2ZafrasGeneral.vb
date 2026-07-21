Public Class Comparativo2ZafrasGeneral

    Public Sub Cargar(ByVal ID_ZAFRA1 As Integer, ByVal ID_ZAFRA2 As Integer, ByVal REND As Decimal, ByVal VIP As Decimal, ByVal CODIPROVEEDOR As String, ByVal ES_PROPUESTA As Boolean)
        Me.DS_SIFAG1.Clear()
        Me.REPORTE_COMPARATIVO_2_ZAFRASTableAdapter1.FillPorCriterios(DS_SIFAG1.REPORTE_COMPARATIVO_2_ZAFRAS, ID_ZAFRA1, ID_ZAFRA2, REND, VIP, CODIPROVEEDOR, ES_PROPUESTA)
        Me.DisplayName = "COMPARATIVO DE PRODUCCION Y RENDIMIENTO DE ZAFRAS"
    End Sub
End Class