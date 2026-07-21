Public Class CombustibleSaldoResumen

    Public Sub CargarDatos(ByVal ID_ZAFRA As Int32, ByVal ID_CATORCENA As Int32)
        Me.DS_SIFAG1.Clear()
        Me.COMBUSTIBLE_PENDIENTE_RESUMENTableAdapter1.FillPorCatorcena(Me.DS_SIFAG1.COMBUSTIBLE_PENDIENTE_RESUMEN, ID_ZAFRA, ID_CATORCENA, 2)
    End Sub
End Class