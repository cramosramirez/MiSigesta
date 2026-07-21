Imports SISPACAL.EL
Imports SISPACAL.BL

Public Class OrdenIrrevocablePagoTransportista
    Dim lEntidad As SOLIC_OIP_TRANS
    Dim esPersonal As Boolean

    Public Sub CargarDatos(ByVal ID_OIP_TRANS As Int32)
        esPersonal = False
        Me.DS_SIFAG1.Clear()
        Me.SOLICITUD_OIP_TRANSTableAdapter1.FillPorId(DS_SIFAG1.SOLICITUD_OIP_TRANS, ID_OIP_TRANS)
    End Sub


End Class