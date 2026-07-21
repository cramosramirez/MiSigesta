Imports SISPACAL.BL
Imports SISPACAL.EL

Public Class InteresJiboa
    Public Sub CargarDatos(ByVal ID_ZAFRA As Integer, ByVal CODIPROVEEDOR As String, ByVal ID_CATORCENA As Integer, ByVal ID_PLANILLA_BASE As Integer)
        Dim lCatorcena As CATORCENA_ZAFRA = (New cCATORCENA_ZAFRA).ObtenerCATORCENA_ZAFRA(ID_CATORCENA)
        DS_SIFAG1.Clear()
        INTERES_PROVEE_AGRICOLATableAdapter1.FillPorCriteriosJiboa(DS_SIFAG1.INTERES_PROVEE_AGRICOLA, CODIPROVEEDOR, ID_CATORCENA, ID_PLANILLA_BASE)

        If lCatorcena IsNot Nothing Then Me.xrABONO_CORTE.Text = "ABONO CORTE " + lCatorcena.NO_CATORCENA.ToString
    End Sub
End Class