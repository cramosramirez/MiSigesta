Public Class ProyeccionFinancieraSubSaldosInsolutos

    Public Sub Cargar(ByVal CODIPROVEEDOR As String, ByVal ID_ZAFRA As Int32)
        Me.DS_SIFAG1.Clear()
        Me.PROYECCION_FINANCIERA_SALDO_INSOTableAdapter1.FillPorCodiproveedor(Me.DS_SIFAG1.PROYECCION_FINANCIERA_SALDO_INSO, ID_ZAFRA, CODIPROVEEDOR)
    End Sub
End Class