Public Class ReciboConsolidadoCombustible
    Public Sub CargarDatos(ByVal ID_CATORCENA As Integer)
        DS_SIFAG1.Clear()
        RECIBO_CONSOLIDADO_COMBUSTIBLETableAdapter1.FillPorCatorcena(DS_SIFAG1.RECIBO_CONSOLIDADO_COMBUSTIBLE, ID_CATORCENA)
    End Sub
End Class