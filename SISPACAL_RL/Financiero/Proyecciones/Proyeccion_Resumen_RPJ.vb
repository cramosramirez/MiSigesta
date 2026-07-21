Imports SISPACAL.BL
Imports SISPACAL.EL

Public Class Proyeccion_Resumen_RPJ
    Public Sub CargarDatos(ByVal ID_ZAFRA As Integer)
        DS_SIFAG1.Clear()
        RPT_PROYECCION_RESUMEN_RPJTableAdapter1.FillPorCriterios(DS_SIFAG1.RPT_PROYECCION_RESUMEN_RPJ, "RPJ", ID_ZAFRA)
    End Sub
End Class