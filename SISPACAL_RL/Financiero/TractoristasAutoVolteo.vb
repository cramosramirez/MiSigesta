Imports SISPACAL.BL
Imports SISPACAL.EL

Public Class TractoristasAutoVolteo


    Public Sub CargarDatos(ByVal ID_ZAFRA As Integer, ByVal ID_CATORCENA As Integer)
        Dim lCatorcena As CATORCENA_ZAFRA

        Me.DS_SIGESTA1.Clear()
        Me.RPT_AUTOVOLTEO_TRACTORISTATableAdapter1.FillPorCatorcena(Me.DS_SIGESTA1.RPT_AUTOVOLTEO_TRACTORISTA, ID_ZAFRA, ID_CATORCENA)

        lCatorcena = (New cCATORCENA_ZAFRA).ObtenerCATORCENA_ZAFRA(ID_CATORCENA)
        If lCatorcena IsNot Nothing Then
            Me.xrCorte.Text = "CORTE #" + lCatorcena.CATORCENA.ToString
        End If
    End Sub

    Public Sub CargarDatosPorNoCatorcena(ByVal ID_ZAFRA As Integer, ByVal NO_CATORCENA As Integer)
        Me.DS_SIGESTA1.Clear()
        Me.RPT_AUTOVOLTEO_TRACTORISTATableAdapter1.FillPorZafraNumCatorcena(Me.DS_SIGESTA1.RPT_AUTOVOLTEO_TRACTORISTA, ID_ZAFRA, 9)

        Me.xrCorte.Text = "CORTE #" + NO_CATORCENA.ToString
    End Sub
End Class