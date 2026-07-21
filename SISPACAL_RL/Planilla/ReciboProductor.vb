Public Class ReciboProductor

    Public Sub CargarDatos(ByVal ID_CATORCENA As Integer, ID_TIPO_PLANILLA As Integer, ByVal ID_GRUPO_DESC As Integer)
        DS_SIFAG1.Clear()
        RECIBO_PRODUCTORTableAdapter1.FillPorCriterios(DS_SIFAG1.RECIBO_PRODUCTOR, ID_CATORCENA, ID_TIPO_PLANILLA, ID_GRUPO_DESC)

        If ID_GRUPO_DESC <> 20 Then
            Me.tblEnca.Rows(0).Cells.Remove(xrEncaTC)
            Me.tblEnca.Rows(0).Cells.Remove(xrEncaTarifa)
            Me.tblDeta.Rows(0).Cells.Remove(xrDetaTC)
            Me.tblDeta.Rows(0).Cells.Remove(xrDetaTarifa)
            Me.tblTotal.Rows(0).Cells.Remove(xrTotalTC)
            Me.tblTotal.Rows(0).Cells.Remove(xrTotalTarifa)
        End If
    End Sub
End Class