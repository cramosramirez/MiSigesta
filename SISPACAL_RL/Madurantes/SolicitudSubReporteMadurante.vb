Public Class SolicitudSubReporteMadurante
    Private Const Formato = "#,##0.00"

    Public Sub CargarProducto(ByVal ID_SOLICITUD As Int32, _
                              ByVal AGUA_MZ As Decimal, ByVal AGUA_PRECIO_UNIT As Decimal, ByVal AGUA_TOTAL As Decimal, _
                              ByVal RIEGO_MZ As Decimal, ByVal RIEGO_PRECIO_UNIT As Decimal, ByVal RIEGO_TOTAL As Decimal, _
                              ByVal SUBTOTAL As Decimal, ByVal IVA As Decimal, ByVal TOTAL As Decimal)
        Me.SoliC_AGRICOLA_PRODUCTOTableAdapter1.FillPorSolicitud(DS_SIGESTA1.SOLIC_AGRICOLA_PRODUCTO, ID_SOLICITUD)
        If AGUA_MZ > 0 Then Me.txtAGUA_MZ.Text = AGUA_MZ.ToString(Formato)
        If AGUA_PRECIO_UNIT > 0 Then Me.txtAGUA_PRECIO_UNIT.Text = AGUA_PRECIO_UNIT.ToString(Formato)
        If AGUA_TOTAL > 0 Then Me.txtAGUA_TOTAL.Text = AGUA_TOTAL.ToString(Formato)

        If RIEGO_MZ > 0 Then Me.txtRIEGO_MZ.Text = RIEGO_MZ.ToString(Formato)
        If RIEGO_PRECIO_UNIT > 0 Then Me.txtRIEGO_PRECIO_UNIT.Text = RIEGO_PRECIO_UNIT.ToString(Formato)
        If RIEGO_TOTAL > 0 Then Me.txtRIEGO_TOTAL.Text = RIEGO_TOTAL.ToString(Formato)

        If SUBTOTAL > 0 Then Me.txtSUBTOTAL.Text = SUBTOTAL.ToString(Formato)
        If IVA > 0 Then Me.txtIVA.Text = IVA.ToString(Formato)
        If TOTAL > 0 Then Me.txtTOTAL.Text = TOTAL.ToString(Formato)
    End Sub
End Class