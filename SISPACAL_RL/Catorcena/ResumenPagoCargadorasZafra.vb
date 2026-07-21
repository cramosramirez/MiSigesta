Imports SISPACAL.BL
Imports SISPACAL.EL

Public Class ResumenPagoCargadorasZafra

    Public Sub CargarDatos(ByVal ID_PROVEEDOR_CARGA As Integer, ByVal ID_ZAFRA As Int32, ByVal NuevaPaginaPorProveedor As Boolean)
        Me.DS_CATORCENA1.Clear()
        Me.ResumeN_PAGO_CARGADORAS_ZAFRATableAdapter1.FillPorCriterios(Me.DS_CATORCENA1.RESUMEN_PAGO_CARGADORAS_ZAFRA, ID_PROVEEDOR_CARGA, ID_ZAFRA)

        If NuevaPaginaPorProveedor Then
            Me.GroupFooter1.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
        End If
    End Sub
End Class