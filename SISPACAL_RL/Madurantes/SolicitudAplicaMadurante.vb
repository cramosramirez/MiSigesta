Public Class SolicitudAplicaMadurante
    Public Sub CargarDatos(ByVal ID_SOLICITUD As Int32)
        Me.SOLICITUD_APLICACIONESTableAdapter1.FillPorSolicitud(DS_SIGESTA1.SOLICITUD_APLICACIONES, ID_SOLICITUD)
    End Sub
End Class