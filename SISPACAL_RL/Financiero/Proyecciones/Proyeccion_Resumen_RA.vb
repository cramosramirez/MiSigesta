Imports SISPACAL.BL
Imports SISPACAL.EL

Public Class Proyeccion_Resumen_RA
    Public Sub CargarDatos(ByVal ID_ZAFRA As Integer)

        DS_SIFAG1.Clear()
        RPT_PROYECCION_RESUMEN_RATableAdapter1.FillPorCriterios(DS_SIFAG1.RPT_PROYECCION_RESUMEN_RA, "RA", ID_ZAFRA)
    End Sub
End Class