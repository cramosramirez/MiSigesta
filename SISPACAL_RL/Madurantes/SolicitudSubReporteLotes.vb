Public Class SolicitudSubReporteLotes
    Public Sub CargarLotes(ByVal ID_SOLICITUD As Int32)
        Me.SoliC_AGRICOLA_LOTESTableAdapter1.FillPorSolicitud(DS_SIGESTA1.SOLIC_AGRICOLA_LOTES, ID_SOLICITUD)
    End Sub
End Class