Imports SISPACAL.DL
Imports DevExpress.XtraReports.UI



Public Class ContratoCanaLotesTCUS_C
    Private mID_ZAFRA As Int32
    Private mZONA As String

    Private MZ As Decimal = 0
    Private TC As Decimal = 0

    Private LBS_R1 As Decimal = 0
    Private TC_R1 As Decimal = 0
    Private LBS_R2 As Decimal = 0
    Private TC_R2 As Decimal = 0

    Public Sub CargarDatos(ByVal ID_ZAFRA As Int32, ByVal ZONA As String)
        Me.Contrato_REND_ESTIMADOTableAdapter1.FillPorZona(Me.DS_SIGESTA1.CONTRATO_REND_ESTIMADO, ID_ZAFRA, ZONA, "", "", "", "")
        mID_ZAFRA = ID_ZAFRA
        mZONA = ZONA
        Me.DisplayName = "CONTRATOS DE CAÑA (MZ – TC - $)"
    End Sub

    Private Sub ReportFooter_BeforePrint(sender As Object, e As System.Drawing.Printing.PrintEventArgs) Handles ReportFooter.BeforePrint
        Dim da As New DS_SIGESTATableAdapters.CONTRATO_RESUMENTableAdapter
        Dim dt As New DS_SIGESTA.CONTRATO_RESUMENDataTable
        da.Fill(dt, mID_ZAFRA, mZONA, "", "", "", "", "", "")
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso dt(0).TC_CONTRATADO > 0 Then
            'Me.xrRENDG2.Text = (dt(0).LBS_CONTRATADO / dt(0).TC_CONTRATADO).ToString("#,##0.0000")
            If dt(0).MZ_CONTRATADO > 0 Then Me.XrTableTC_MZ.Text = (dt(0).TC_CONTRATADO / dt(0).MZ_CONTRATADO).ToString("#,##0.00")
        End If
    End Sub

    Private Sub SummaryGetResult(sender As Object, e As DevExpress.XtraReports.UI.SummaryGetResultEventArgs) Handles xrTC_MZ.SummaryGetResult
        If MZ > 0 Then
            e.Result = TC / MZ
        Else
            e.Result = 0
        End If
        e.Handled = True
    End Sub

    Private Sub SummaryReset(sender As Object, e As System.EventArgs) Handles xrTC_MZ.SummaryReset
        MZ = 0
        TC = 0
    End Sub

    Private Sub SummaryRowChanged(sender As Object, e As System.EventArgs) Handles xrTC_MZ.SummaryRowChanged
        MZ += Convert.ToDecimal(GetCurrentColumnValue("MZ_CONTRATADO"))
        TC += Convert.ToDecimal(GetCurrentColumnValue("TC_CONTRATADO"))
    End Sub



    Private Sub SummaryGetResultREND(sender As Object, e As DevExpress.XtraReports.UI.SummaryGetResultEventArgs) Handles xrRENDG1.SummaryGetResult, xrRENDG2.SummaryGetResult
        Select Case TryCast(sender, XRTableCell).Name
            Case "xrRENDG1"
                e.Result = If(TC_R1 > 0, LBS_R1 / TC_R1, 0)
            Case "xrRENDG2"
                e.Result = If(TC_R2 > 0, LBS_R2 / TC_R2, 0)
        End Select
        e.Handled = True
    End Sub

    Private Sub SummaryResetREND(sender As Object, e As System.EventArgs) Handles xrRENDG1.SummaryReset, xrRENDG2.SummaryReset
        Select Case TryCast(sender, XRTableCell).Name
            Case "xrRENDG1"
                LBS_R1 = 0
                TC_R1 = 0
            Case "xrRENDG2"
                LBS_R2 = 0
                TC_R2 = 0
        End Select
    End Sub

    Private Sub SummaryRowChangedREND(sender As Object, e As System.EventArgs) Handles xrRENDG1.SummaryRowChanged, xrRENDG2.SummaryRowChanged
        Select Case TryCast(sender, XRTableCell).Name
            Case "xrRENDG1"
                LBS_R1 += Convert.ToDecimal(GetCurrentColumnValue("LBS_CONTRATADO"))
                TC_R1 += Convert.ToDecimal(GetCurrentColumnValue("TC_CONTRATADO"))
            Case "xrRENDG2"
                LBS_R2 += Convert.ToDecimal(GetCurrentColumnValue("LBS_CONTRATADO"))
                TC_R2 += Convert.ToDecimal(GetCurrentColumnValue("TC_CONTRATADO"))
        End Select
    End Sub
End Class