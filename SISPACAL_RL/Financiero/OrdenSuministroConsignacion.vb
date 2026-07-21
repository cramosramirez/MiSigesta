Public Class OrdenSuministroConsignacion

    Public Sub CargarDatos(ByVal ID_SOLICITUD As Int32)
        DS_SIFAG1.Clear()
        REPO_ORDEN_COMPRA_AGRICOLATableAdapter1.FillPorSolicitud(DS_SIFAG1.REPO_ORDEN_COMPRA_AGRICOLA, ID_SOLICITUD)
    End Sub

    Public Sub CargarDatosPorOrden(ByVal ID_ORDEN As Int32)
        DS_SIFAG1.Clear()
        REPO_ORDEN_COMPRA_AGRICOLATableAdapter1.FillPorOrden(DS_SIFAG1.REPO_ORDEN_COMPRA_AGRICOLA, ID_ORDEN)
    End Sub
End Class