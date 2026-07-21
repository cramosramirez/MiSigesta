Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores

Public Class SolicitudAnticipo02
    Dim mID_SOLICITUD As Int32 = -1

    Public Sub CargarDatos(ByVal ID_ANTICIPO As Int32)
        Dim lEntidad As SOLIC_ANTICIPO = (New cSOLIC_ANTICIPO).ObtenerSOLIC_ANTICIPO(ID_ANTICIPO)
        Dim lProveedor As PROVEEDOR

        If lEntidad IsNot Nothing Then
            lProveedor = (New cPROVEEDOR).ObtenerPROVEEDOR(lEntidad.CODIPROVEEDOR)
            If lProveedor IsNot Nothing Then
                If lProveedor.APODERADO.Trim = "" Then
                    Me.lblNombreSociedad.Visible = False
                    Me.txtNombreSociedad.Visible = False
                    Me.lblRepresentante.Text = "NOMBRE DEL PRODUCTOR:"
                    Me.lblFirmaRepresentante.Text = "FIRMA DEL PRODUCTOR"
                    Me.lblNombreRepresentante.Text = "NOMBRE DEL PRODUCTOR"
                End If
            End If
        End If

        Me.DS_SIGESTA1.Clear()
        Me.SOLIC_ANTICIPOTableAdapter1.FillPorIdAnticipo(Me.DS_SIGESTA1.SOLIC_ANTICIPO, ID_ANTICIPO)
    End Sub
    
End Class