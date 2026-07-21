Public Class ContratoEjecucionCensoTCUS_B

    Public Sub CargarDatos(ByVal ID_CENSO As Integer, ByVal ZONA As String, ByVal SUB_ZONA As String, ByVal CODI_DEPTO As String, ByVal CODI_MUNI As String, ByVal CODI_CANTON As String, ByVal CODIPROVEE As String, ByVal CODISOCIO As String)
        Me.CensoTableAdapter1.FillPorContrato(Me.DS_SIGESTA1.CENSO, ID_CENSO, ZONA, SUB_ZONA, CODI_DEPTO, CODI_MUNI, CODI_CANTON, CODIPROVEE, CODISOCIO)
        Me.DisplayName = "CONTRATO VRS EJECUCION CENSO (MZ – TC - $)"
    End Sub
    Public Sub CargarCierreZafra(ByVal ID_CENSO As Integer, ByVal ZONA As String, ByVal SUB_ZONA As String, ByVal CODI_DEPTO As String, ByVal CODI_MUNI As String, ByVal CODI_CANTON As String, ByVal CODIPROVEE As String, ByVal CODISOCIO As String)
        Me.CensoTableAdapter1.FillPorContratoCierreZafra(Me.DS_SIGESTA1.CENSO, ID_CENSO, ZONA, SUB_ZONA, CODI_DEPTO, CODI_MUNI, CODI_CANTON, CODIPROVEE, CODISOCIO)
        Me.DisplayName = "CONTRATO VRS EJECUCION CENSO (MZ – TC - $)"
    End Sub
End Class