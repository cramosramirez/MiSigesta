Imports SISPACAL.BL
Imports SISPACAL.EL

Public Class TractoristasAutoVolteoResumen


    Public Sub CargarDatos(ByVal ID_ZAFRA As Integer, ByVal ID_CATORCENA As Integer, ByVal FECHA_INICIAL As DateTime, ByVal FECHA_FINAL As DateTime)
        Dim lCatorcena As CATORCENA_ZAFRA

        Me.DS_SIGESTA1.Clear()
        Me.RPT_AUTOVOLTEO_TRACTORISTA_PARA_PLANILLATableAdapter1.FillPorCatorcena(Me.DS_SIGESTA1.RPT_AUTOVOLTEO_TRACTORISTA_PARA_PLANILLA, ID_ZAFRA, ID_CATORCENA, FECHA_INICIAL, FECHA_FINAL)

        lCatorcena = (New cCATORCENA_ZAFRA).ObtenerCATORCENA_ZAFRA(ID_CATORCENA)
        If lCatorcena IsNot Nothing Then
            Me.xrCorte.Text = "CORTE #" + lCatorcena.CATORCENA.ToString
        Else
            Me.xrCorte.Text = "PERIODO DEL " + FECHA_INICIAL.ToString("dd/MM/yyyy") + " AL " + FECHA_FINAL.ToString("dd/MM/yyyy")
        End If
    End Sub

End Class