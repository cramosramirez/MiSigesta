Imports SISPACAL.EL
Imports SISPACAL.BL

Public Class OrdenIrrevocablePago
    Dim lEntidad As SOLIC_OPI
    Dim esPersonal As Boolean

    Public Sub CargarDatos(ByVal ID_OPI As Int32)
        esPersonal = False
        Me.DS_SIFAG1.Clear()
        Me.SOLICITUD_OIPTableAdapter1.FillPorId(DS_SIFAG1.SOLICITUD_OIP, ID_OPI)
    End Sub

    
End Class