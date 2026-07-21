
Partial Class controlesCenso_ucVisorReporte
    Inherits ucBase

    Public Sub CargarDatos(ByVal reporte As DevExpress.XtraReports.UI.XtraReport)
        Me.ASPxDocumentViewer1.ReportTypeName = "XtraReportsDemos.MultiColumnReport.Report"
        Me.ASPxDocumentViewer1.Report = reporte
        Me.ASPxDocumentViewer1.DataBind()
    End Sub
End Class
