Public Class SolicitudParaRequisicion

    Public Sub CargarSolicitud(ByVal ID_REQENCA As Int32)
        Me.SOLICITUD_REQUISICIONTableAdapter1.FillPorId(DS_SIGESTA1.SOLICITUD_REQUISICION, ID_REQENCA)
    End Sub
End Class