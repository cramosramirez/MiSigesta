Public Class OrdenAnalisisMuestra

    Public Sub CargarOrden(ByVal ID_ANALISIS_PRE As Int32)
        Me.OrdeN_ANALISIS_PRECOSECHATableAdapter1.FillPorID_ORDEN(DS_SIGESTA1.ORDEN_ANALISIS_PRECOSECHA, ID_ANALISIS_PRE)
    End Sub
End Class