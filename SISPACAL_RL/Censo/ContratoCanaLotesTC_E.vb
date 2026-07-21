Imports DevExpress.XtraReports.UI
Imports SISPACAL.DL

Public Class ContratoCanaLotesTC_E
    Private mID_ZAFRA As Int32
    Private mZONA As String
    Private mSUB_ZONA As String
    Private mCODI_DEPTO As String
    Private mCODI_MUNI As String
    Private mCODI_CANTON As String


    Private MZ_G1 As Decimal = 0
    Private TC_G1 As Decimal = 0

    Private MZ_G2 As Decimal = 0
    Private TC_G2 As Decimal = 0

    Private MZ_G3 As Decimal = 0
    Private TC_G3 As Decimal = 0


    Public Sub CargarDatos(ByVal ID_ZAFRA As Int32, ByVal ZONA As String, ByVal SUB_ZONA As String, ByVal CODI_DEPTO As String, ByVal CODI_MUNI As String, ByVal CODI_CANTON As String)
        Me.ContratO_REND_ESTIMADOTableAdapter1.SetCommandTimeOut(900000)
        Me.ContratO_REND_ESTIMADOTableAdapter1.FillPorZona(Me.DS_SIGESTA1.CONTRATO_REND_ESTIMADO, ID_ZAFRA, ZONA, SUB_ZONA, CODI_DEPTO, CODI_MUNI, CODI_CANTON)
        mID_ZAFRA = ID_ZAFRA
        mZONA = ZONA
        mSUB_ZONA = SUB_ZONA
        mCODI_DEPTO = CODI_DEPTO
        mCODI_MUNI = CODI_MUNI
        mCODI_CANTON = CODI_CANTON
        Me.xrTitulo.Text = "CONTRATOS DE CAÑA (MZ - TC)"
    End Sub

    Public Sub CargarDatosEsticana(ByVal ID_ZAFRA As Int32, ByVal ZONA As String, ByVal SUB_ZONA As String, ByVal CODI_DEPTO As String, ByVal CODI_MUNI As String, ByVal CODI_CANTON As String)
        Me.ContratO_REND_ESTIMADOTableAdapter1.SetCommandTimeOut(900000)
        Me.ContratO_REND_ESTIMADOTableAdapter1.FillPorZonaEsticana(Me.DS_SIGESTA1.CONTRATO_REND_ESTIMADO, ID_ZAFRA, ZONA, SUB_ZONA, CODI_DEPTO, CODI_MUNI, CODI_CANTON)
        mID_ZAFRA = ID_ZAFRA
        mZONA = ZONA
        mSUB_ZONA = SUB_ZONA
        mCODI_DEPTO = CODI_DEPTO
        mCODI_MUNI = CODI_MUNI
        mCODI_CANTON = CODI_CANTON
        Me.xrTitulo.Text = "CONTRATOS DE CAÑA (MZ - TC)"
    End Sub

    Private Sub ReportFooter_BeforePrint(sender As Object, e As System.Drawing.Printing.PrintEventArgs) Handles ReportFooter.BeforePrint
        Dim da As New DS_SIGESTATableAdapters.CONTRATO_RESUMENTableAdapter
        Dim dt As New DS_SIGESTA.CONTRATO_RESUMENDataTable
        da.Fill(dt, mID_ZAFRA, mZONA, mSUB_ZONA, mCODI_DEPTO, mCODI_MUNI, mCODI_CANTON, "", "")
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso dt(0).TC_CONTRATADO > 0 Then
            If dt(0).MZ_CONTRATADO > 0 Then Me.XrTableTC_MZ.Text = (dt(0).TC_CONTRATADO / dt(0).MZ_CONTRATADO).ToString("#,##0.00")
        End If
    End Sub

    Private Sub SummaryGetResult(sender As Object, e As DevExpress.XtraReports.UI.SummaryGetResultEventArgs) Handles xrTC_MZG1.SummaryGetResult, xrTC_MZG2.SummaryGetResult, xrTC_MZG3.SummaryGetResult
        Select Case TryCast(sender, XRTableCell).Name
            Case "xrTC_MZG1"
                e.Result = If(MZ_G1 > 0, TC_G1 / MZ_G1, 0)
            Case "xrTC_MZG2"
                e.Result = If(MZ_G2 > 0, TC_G2 / MZ_G2, 0)
            Case "xrTC_MZG3"
                e.Result = If(MZ_G3 > 0, TC_G3 / MZ_G3, 0)
        End Select
        e.Handled = True
    End Sub

    Private Sub SummaryReset(sender As Object, e As System.EventArgs) Handles xrTC_MZG1.SummaryReset, xrTC_MZG2.SummaryReset, xrTC_MZG3.SummaryReset
        Select Case TryCast(sender, XRTableCell).Name
            Case "xrTC_MZG1"
                MZ_G1 = 0
                TC_G1 = 0
            Case "xrTC_MZG2"
                MZ_G2 = 0
                TC_G2 = 0
            Case "xrTC_MZG3"
                MZ_G3 = 0
                TC_G3 = 0
        End Select
    End Sub

    Private Sub SummaryRowChanged(sender As Object, e As System.EventArgs) Handles xrTC_MZG1.SummaryRowChanged, xrTC_MZG2.SummaryRowChanged, xrTC_MZG3.SummaryRowChanged
        Select Case TryCast(sender, XRTableCell).Name
            Case "xrTC_MZG1"
                MZ_G1 += Convert.ToDecimal(GetCurrentColumnValue("MZ_CONTRATADO"))
                TC_G1 += Convert.ToDecimal(GetCurrentColumnValue("TC_CONTRATADO"))
            Case "xrTC_MZG2"
                MZ_G2 += Convert.ToDecimal(GetCurrentColumnValue("MZ_CONTRATADO"))
                TC_G2 += Convert.ToDecimal(GetCurrentColumnValue("TC_CONTRATADO"))
            Case "xrTC_MZG3"
                MZ_G3 += Convert.ToDecimal(GetCurrentColumnValue("MZ_CONTRATADO"))
                TC_G3 += Convert.ToDecimal(GetCurrentColumnValue("TC_CONTRATADO"))
        End Select
    End Sub
End Class