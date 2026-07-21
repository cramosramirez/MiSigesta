Public Class SolicitudInsumoSubRepoLotesCanaSemilla

    Public Sub CargarDatos(ByVal ID_SOLICITUD As Int32)
        Me.DS_SIFAG1.Clear()
        Me.SOLIC_AGRICOLA_CANA_SEMILLATableAdapter1.FillPorIdSolicitud(Me.DS_SIFAG1.SOLIC_AGRICOLA_CANA_SEMILLA, ID_SOLICITUD)
    End Sub
End Class