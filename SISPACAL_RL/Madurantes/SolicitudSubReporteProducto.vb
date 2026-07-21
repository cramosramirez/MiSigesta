Public Class SolicitudSubReporteProducto
    Private Const Formato = "#,##0.00"

    Public Sub CargarProducto(ByVal ID_SOLICITUD As Int32, _
                              ByVal SUBTOTAL As Decimal, ByVal IVA As Decimal, ByVal TOTAL As Decimal)
        Me.SoliC_AGRICOLA_PRODUCTOTableAdapter1.FillPorSolicitud(DS_SIGESTA1.SOLIC_AGRICOLA_PRODUCTO, ID_SOLICITUD)

        If SUBTOTAL > 0 Then Me.txtSUBTOTAL.Text = SUBTOTAL.ToString(Formato)
        If IVA > 0 Then Me.txtIVA.Text = IVA.ToString(Formato)
        If TOTAL > 0 Then Me.txtTOTAL.Text = TOTAL.ToString(Formato)
    End Sub
End Class