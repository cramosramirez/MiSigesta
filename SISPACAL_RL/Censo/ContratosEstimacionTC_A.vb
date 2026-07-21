Public Class ContratosEstimacionTC_A

    Public Sub CargarDatos(ByVal ID_CENSO As Integer, ByVal ZONA As String, ByVal SUB_ZONA As String, _
                           ByVal CODI_DEPTO As String, ByVal CODI_MUNI As String, ByVal CODI_CANTON As String, _
                           ByVal CODIPROVEE As String, ByVal CODISOCIO As String, ByVal ID_ZAFRA_COMPA As Int32)
        Me.CensoTableAdapter1.FillPorLoteEstimacion(Me.DS_SIGESTA1.CENSO, ZONA, SUB_ZONA, CODI_DEPTO, CODI_MUNI, CODI_CANTON, CODIPROVEE, CODISOCIO, ID_ZAFRA_COMPA, ID_CENSO)
        Me.txtTITULO.Text = ""
        Me.DisplayName = "CONTRATOS VS ESTIMACIÓN DE CAÑA"
    End Sub

End Class