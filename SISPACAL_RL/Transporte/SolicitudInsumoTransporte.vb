Imports SISPACAL.EL
Imports SISPACAL.BL

Public Class SolicitudInsumoTransporte

    Public Sub CargarDatos(ByVal ID_SOLICITUD As Int32)
        Me.DS_SIFAG1.Clear()
        Me.SOLIC_ENCA_TRANSTableAdapter1.FillPorId(Me.DS_SIFAG1.SOLIC_ENCA_TRANS, ID_SOLICITUD)

        Dim lSolic As SOLIC_ENCA_TRANS = (New cSOLIC_ENCA_TRANS).ObtenerSOLIC_ENCA_TRANS(ID_SOLICITUD)
        If lSolic IsNot Nothing Then
            If Not lSolic.CESC > 0 Then
                XrTable3.Rows.Remove(filaCESC)
            End If
        End If
    End Sub
End Class