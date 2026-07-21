Imports SISPACAL.DL
Public Class ContratoCanaLotesTC_C

    Public Sub CargarDatos(ByVal ID_ZAFRA As Int32, ByVal ZONA As String)
        Me.DS_SIGESTA1.Clear()
        Me.CONTRATO_CANA_ZONATableAdapter1.SetCommandTimeOut(900000)
        Me.CONTRATO_CANA_ZONATableAdapter1.FillPorCriterios(Me.DS_SIGESTA1.CONTRATO_CANA_ZONA, ID_ZAFRA, ZONA, "", "", "", "")
        Me.xrTitulo.Text = "CONTRATOS DE CAÑA (MZ - TC)"
    End Sub

    Public Sub CargarDatosEsticana(ByVal ID_ZAFRA As Int32, ByVal ZONA As String)
        Me.DS_SIGESTA1.Clear()
        Me.CONTRATO_CANA_ZONATableAdapter1.SetCommandTimeOut(900000)
        Me.CONTRATO_CANA_ZONATableAdapter1.FillPorCriteriosEsticana(Me.DS_SIGESTA1.CONTRATO_CANA_ZONA, ID_ZAFRA, ZONA, "", "", "", "")
        Me.xrTitulo.Text = "CONTRATOS DE ESTICAÑA (MZ - TC)"
    End Sub

End Class