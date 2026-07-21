Public Class CatalogoLotes

    Public Sub CargarDatos(ByVal ZONA As String, ByVal SUB_ZONA As String, _
                            ByVal CODI_DEPTO As String, ByVal CODI_MUNI As String, _
                            ByVal CODI_CANTON As String, _
                            ByVal CODIPROVEE As String, ByVal CODISOCIO As String, ByVal CODICONTRATO As String)
        Me.Maestro_LOTESTableAdapter1.FillPorCriterios(Me.DS_SIGESTA1.MAESTRO_LOTES, ZONA, SUB_ZONA, CODI_DEPTO, CODI_MUNI, CODI_CANTON, CODIPROVEE, CODISOCIO, CODICONTRATO)
    End Sub

End Class