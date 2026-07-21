Public Class ValidacionContratosTC_A

    Public Sub CargarDatos(ByVal ID_CENSO As Integer, ByVal ZONA As String, ByVal SUB_ZONA As String, _
                           ByVal CODI_DEPTO As String, ByVal CODI_MUNI As String, ByVal CODI_CANTON As String, _
                           ByVal CODIPROVEE As String, ByVal CODISOCIO As String, ByVal ID_ZAFRA_COMPA As Int32)
        Me.CensoTableAdapter1.FillPorLoteCompaZafra(Me.DS_SIGESTA1.CENSO, ZONA, SUB_ZONA, CODI_DEPTO, CODI_MUNI, CODI_CANTON, CODIPROVEE, CODISOCIO, ID_CENSO, ID_ZAFRA_COMPA)
        Me.txtTITULO.Text = ""
        Me.DisplayName = "VALIDACION CONTRATOS"
    End Sub

    Public Sub CargarDatosEnRango(ByVal ID_CENSO As Integer, ByVal ZONA As String, ByVal SUB_ZONA As String, _
                           ByVal CODI_DEPTO As String, ByVal CODI_MUNI As String, ByVal CODI_CANTON As String, _
                           ByVal CODIPROVEE As String, ByVal CODISOCIO As String, ByVal ID_ZAFRA_COMPA As Int32)
        Me.CensoTableAdapter1.FillPorLoteCompaZafraEnRango(Me.DS_SIGESTA1.CENSO, ZONA, SUB_ZONA, CODI_DEPTO, CODI_MUNI, CODI_CANTON, CODIPROVEE, CODISOCIO, ID_ZAFRA_COMPA, ID_CENSO)
        Me.txtTITULO.Text = "LOTES CON TC ENTREGADAS ZAFRA 13/14 DENTRO DE MARGEN (+-)20% TC CONTRATADO ZAFRA 14/15"
        Me.DisplayName = "VALIDACION CONTRATOS"
    End Sub

    Public Sub CargarDatosFueraRango(ByVal ID_CENSO As Integer, ByVal ZONA As String, ByVal SUB_ZONA As String, _
                           ByVal CODI_DEPTO As String, ByVal CODI_MUNI As String, ByVal CODI_CANTON As String, _
                           ByVal CODIPROVEE As String, ByVal CODISOCIO As String, ByVal ID_ZAFRA_COMPA As Int32)
        Me.CensoTableAdapter1.FillPorLoteCompaFueraRango(Me.DS_SIGESTA1.CENSO, ZONA, SUB_ZONA, CODI_DEPTO, CODI_MUNI, CODI_CANTON, CODIPROVEE, CODISOCIO, ID_ZAFRA_COMPA, ID_CENSO)
        Me.txtTITULO.Text = "LOTES CON TC ENTREGADAS ZAFRA 13/14 FUERA DE MARGEN (+-)20% TC CONTRATADO ZAFRA 14/15"
        Me.DisplayName = "VALIDACION CONTRATOS"
    End Sub
End Class