Imports SISPACAL.BL
Imports SISPACAL.EL

Public Class ProductoConsignadoPendiente
    Public Sub CargarDatos(ByVal ID_ZAFRA As Integer, ByVal CODIPROVEEDOR As String, ByVal ID_PROVEE As Integer)
        DS_SIFAG1.Clear()
        RPT_PRODUCTO_CONSIGNADO_PENDTableAdapter1.FillPorProductorCasa(DS_SIFAG1.RPT_PRODUCTO_CONSIGNADO_PEND, ID_ZAFRA, CODIPROVEEDOR, ID_PROVEE)
    End Sub
End Class