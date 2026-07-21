Imports SISPACAL.BL
Imports SISPACAL.EL

Public Class CartaAutorizacionServicios
    Public Sub CargarDatos(ByVal CODICONTRATO As String)
        DS_SIFAG1.Clear()
        CARTA_AUTORIZACION_SERVICIOSTableAdapter1.FillPorContrato(DS_SIFAG1.CARTA_AUTORIZACION_SERVICIOS, CODICONTRATO)
    End Sub
End Class