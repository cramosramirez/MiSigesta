Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores

Public Class SolicitudInsumoAgricolaExterno
    Dim mID_SOLICITUD As Int32 = -1

    Public Sub CargarDatos(ByVal ID_SOLICITUD As Int32)
        Dim lEntidad As SOLIC_AGRICOLA = (New cSOLIC_AGRICOLA).ObtenerSOLIC_AGRICOLA(ID_SOLICITUD)
        Dim lProveedor As PROVEEDOR
        Dim lCuentaFinan As CUENTA_FINAN

        mID_SOLICITUD = ID_SOLICITUD
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

            lCuentaFinan = (New cCUENTA_FINAN).ObtenerCUENTA_FINAN(lEntidad.ID_CUENTA_FINAN)
            If lCuentaFinan IsNot Nothing Then Me.xrCuentaFinan.Text = lCuentaFinan.NOMBRE_CUENTA

            If lEntidad.CONDI_COMPRA = 2 Then xrDEUDA.Visible = False
            Me.srpLotesCanaSemilla.Visible = (lEntidad.ID_CUENTA_FINAN = CuentaFinanciamiento.CanaSemilla)
        End If

        Me.DS_SIFAG1.Clear()
        Me.REPORTE_SOLIC_AGRICOLATableAdapter1.FillPorIdSolic(Me.DS_SIFAG1.REPORTE_SOLIC_AGRICOLA, ID_SOLICITUD)

        If lEntidad.ID_CUENTA_FINAN <> CuentaFinanciamiento.Combustible Then
            XrTable3.Rows.Remove(XrTableRow6)
        End If
    End Sub

    Private Sub srpLotesCanaSemilla_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles srpLotesCanaSemilla.BeforePrint
        Dim detalle As SolicitudInsumoSubRepoLotesCanaSemilla = TryCast(Me.srpLotesCanaSemilla.ReportSource, SolicitudInsumoSubRepoLotesCanaSemilla)
        If detalle IsNot Nothing Then
            detalle.CargarDatos(mID_SOLICITUD)
            e.Cancel = False
        End If
    End Sub
End Class