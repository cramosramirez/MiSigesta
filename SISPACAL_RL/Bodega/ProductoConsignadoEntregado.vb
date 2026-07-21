Public Class ProductoConsignadoEntregado

    Public Sub Cargar(ByVal ID_ZAFRA As Int32, ByVal CODIPROVEEDOR As String, ByVal FECHA_INICIAL As String, ByVal FECHA_FINAL As String, ByVal ID_PROVEE As Int32, ByVal ID_CUENTA_FINAN As Int32)
        Me.DS_SIFAG1.Clear()
        Me.REPORTE_PRODCONSIGNADO_ENTREGADOTableAdapter1.FillPorCriterios(Me.DS_SIFAG1.REPORTE_PRODCONSIGNADO_ENTREGADO, _
                    CODIPROVEEDOR, ID_ZAFRA, FECHA_INICIAL, FECHA_FINAL, ID_PROVEE, ID_CUENTA_FINAN)
        Me.xrPeriodo.Text = "PERIODO: " + FECHA_INICIAL + " AL " + FECHA_FINAL
        Me.DisplayName = "ProductoConsignadoEntregado"
    End Sub
End Class