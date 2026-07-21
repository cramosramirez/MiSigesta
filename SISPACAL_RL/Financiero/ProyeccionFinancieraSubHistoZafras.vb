Public Class ProyeccionFinancieraSubHistoZafras

    Public Sub CargarHistoZafras(ByVal ID_ENCA As Integer)
        Me.DS_SIFAG1.Clear()
        Me.PROYECCION_FINANCIERA_HISTO_ZAFRASTableAdapter1.FillPorIdEnca(Me.DS_SIFAG1.PROYECCION_FINANCIERA_HISTO_ZAFRAS, ID_ENCA)
    End Sub

End Class