Public Class CensoDifContratos_A

    Public Sub CargarCierreZafra(ByVal ID_CENSO As Integer, ByVal ZONA As String, ByVal SUB_ZONA As String, ByVal CODI_DEPTO As String, ByVal CODI_MUNI As String, CODI_CANTON As String, ByVal CODIPROVEE As String, ByVal CODISOCIO As String)
        Me.CensoTableAdapter1.FillPorLoteCierreZafra(Me.DS_SIGESTA1.CENSO, ID_CENSO, ZONA, SUB_ZONA, CODI_DEPTO, CODI_MUNI, CODI_CANTON, CODIPROVEE, CODISOCIO)
        Me.DisplayName = "CONTRATOS VRS CENSO (MZ - TC)"
    End Sub
    Public Sub CargarDatos(ByVal ID_CENSO As Integer, ByVal ZONA As String, ByVal SUB_ZONA As String, ByVal CODI_DEPTO As String, ByVal CODI_MUNI As String, CODI_CANTON As String, ByVal CODIPROVEE As String, ByVal CODISOCIO As String)
        Me.CensoTableAdapter1.FillBy(Me.DS_SIGESTA1.CENSO, ID_CENSO, ZONA, SUB_ZONA, CODI_DEPTO, CODI_MUNI, CODI_CANTON, CODIPROVEE, CODISOCIO)
        Me.DisplayName = "CONTRATOS VRS CENSO (MZ - TC)"
    End Sub
End Class