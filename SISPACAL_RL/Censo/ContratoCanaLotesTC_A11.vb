Public Class ContratoCanaLotesTC_A11

    Public Sub CargarDatos(ByVal ID_ZAFRA As Int32, ByVal ZONA As String, ByVal SUB_ZONA As String,
                           ByVal CODI_DEPTO As String, ByVal CODI_MUNI As String, ByVal CODI_CANTON As String,
                           ByVal CODIPROVEE As String, ByVal CODISOCIO As String)
        Me.ContratO_REND_ESTIMADOTableAdapter1.SetCommandTimeOut(900000)
        Me.ContratO_REND_ESTIMADOTableAdapter1.FillBy(Me.DS_SIGESTA1.CONTRATO_REND_ESTIMADO, ID_ZAFRA, ZONA, SUB_ZONA, CODI_DEPTO, CODI_MUNI, CODI_CANTON, CODIPROVEE, CODISOCIO)
        Me.xrTitulo.Text = "CONTRATOS DE CAÑA (MZ - TC)"
    End Sub

    Public Sub CargarDatosEsticana(ByVal ID_ZAFRA As Int32, ByVal ZONA As String, ByVal SUB_ZONA As String,
                           ByVal CODI_DEPTO As String, ByVal CODI_MUNI As String, ByVal CODI_CANTON As String,
                           ByVal CODIPROVEE As String, ByVal CODISOCIO As String)
        Me.ContratO_REND_ESTIMADOTableAdapter1.SetCommandTimeOut(900000)
        Me.ContratO_REND_ESTIMADOTableAdapter1.FillByEsticana(Me.DS_SIGESTA1.CONTRATO_REND_ESTIMADO, ID_ZAFRA, ZONA, SUB_ZONA, CODI_DEPTO, CODI_MUNI, CODI_CANTON, CODIPROVEE, CODISOCIO)
        Me.xrTitulo.Text = "CONTRATOS DE ESTICAÑA (MZ - TC)"
    End Sub
End Class