Imports CrystalDecisions.CrystalReports.Engine
Imports SISPACAL.DL
Imports SISPACAL.RL

Public Class frmReciboBascula

    Public Sub CargarReporte(ByVal ID_ENVIO As Integer)
        Try
            Dim reporte As New ReciboCana
            Dim ds As New DS_DS1
            Dim dt As New DS_DS1.RECIBO_CANADataTable
            Dim adapter As New DS_DS1TableAdapters.RECIBO_CANATableAdapter

            adapter.FillPorENVIO(dt, ID_ENVIO)
            ds.Tables("RECIBO_CANA").Merge(dt)
            reporte.SetDataSource(ds)
            CrystalReportViewer1.ReportSource = reporte

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, Application.ProductName)
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
        frmAnalisisPeso_Muestra.btnNuevo_Click(Me, e)
    End Sub
End Class