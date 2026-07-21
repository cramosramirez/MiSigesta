Public Class HojaAnalisisMuestraCana
    Public Sub CargarDatos(ByVal ID_ANALISIS_PRE As Int32)
        Me.HOJA_ANALISIS_LOTETableAdapter1.FillPorAnalisis(DS_SIGESTA1.HOJA_ANALISIS_LOTE, ID_ANALISIS_PRE)
    End Sub
End Class