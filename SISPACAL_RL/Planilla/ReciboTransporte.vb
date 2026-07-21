Public Class ReciboTransporte
    Public Sub CargarDatos(ByVal ID_CATORCENA As Integer, ID_TIPO_PLANILLA As Integer, ByVal ID_GRUPO_DESC As Integer)
        DS_SIFAG1.Clear()
        RECIBO_TRANSTableAdapter1.FillPorPlanilla(DS_SIFAG1.RECIBO_TRANS, ID_CATORCENA, ID_TIPO_PLANILLA, ID_GRUPO_DESC)

        If ID_GRUPO_DESC <> 8 Then
            Me.tblEnca.Rows(0).Cells.Remove(xrReferenciaEnca)
            Me.tblDeta.Rows(0).Cells.Remove(xrReferenciaDeta)
            Me.tblPie.Rows(0).Cells.Remove(xrReferenciaPie)
        End If
    End Sub
End Class