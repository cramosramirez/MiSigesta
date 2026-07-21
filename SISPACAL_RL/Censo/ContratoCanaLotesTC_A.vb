
Imports SISPACAL.DL
Imports DevExpress.XtraReports.UI

Public Class ContratoCanaLotesTC_A
    Private mID_ZAFRA As Int32
    Private mZONA As String
    Private mSUB_ZONA As String
    Private mCODI_DEPTO As String
    Private mCODI_MUNI As String
    Private mCODI_CANTON As String

    Private MZ As Decimal = 0
    Private TC As Decimal = 0

    Public Sub CargarDatos(ByVal ID_ZAFRA As Int32, ByVal ZONA As String, ByVal SUB_ZONA As String,
                           ByVal CODI_DEPTO As String, ByVal CODI_MUNI As String, ByVal CODI_CANTON As String,
                           ByVal CODIPROVEE As String, ByVal CODISOCIO As String)
        Me.ContratO_REND_ESTIMADOTableAdapter1.SetCommandTimeOut(900000)
        Me.ContratO_REND_ESTIMADOTableAdapter1.FillBy(Me.DS_SIGESTA1.CONTRATO_REND_ESTIMADO, ID_ZAFRA, ZONA, SUB_ZONA, CODI_DEPTO, CODI_MUNI, CODI_CANTON, CODIPROVEE, CODISOCIO)
        mID_ZAFRA = ID_ZAFRA
        mZONA = ZONA
        mSUB_ZONA = SUB_ZONA
        mCODI_DEPTO = CODI_DEPTO
        mCODI_MUNI = CODI_MUNI
        mCODI_CANTON = CODI_CANTON
        Me.xrTitulo.Text = "CONTRATOS DE CAÑA (MZ - TC)"
    End Sub

    Public Sub CargarDatosEsticana(ByVal ID_ZAFRA As Int32, ByVal ZONA As String, ByVal SUB_ZONA As String,
                           ByVal CODI_DEPTO As String, ByVal CODI_MUNI As String, ByVal CODI_CANTON As String,
                           ByVal CODIPROVEE As String, ByVal CODISOCIO As String)
        Me.ContratO_REND_ESTIMADOTableAdapter1.SetCommandTimeOut(900000)
        Me.ContratO_REND_ESTIMADOTableAdapter1.FillByEsticana(Me.DS_SIGESTA1.CONTRATO_REND_ESTIMADO, ID_ZAFRA, ZONA, SUB_ZONA, CODI_DEPTO, CODI_MUNI, CODI_CANTON, CODIPROVEE, CODISOCIO)
        mID_ZAFRA = ID_ZAFRA
        mZONA = ZONA
        mSUB_ZONA = SUB_ZONA
        mCODI_DEPTO = CODI_DEPTO
        mCODI_MUNI = CODI_MUNI
        mCODI_CANTON = CODI_CANTON
        Me.xrTitulo.Text = "CONTRATOS DE ESTICAÑA (MZ - TC)"
    End Sub

    Private Sub ReportFooter_BeforePrint(sender As Object, e As System.Drawing.Printing.PrintEventArgs) Handles ReportFooter.BeforePrint
        Dim da As New DS_SIGESTATableAdapters.CONTRATO_RESUMENTableAdapter
        Dim dt As New DS_SIGESTA.CONTRATO_RESUMENDataTable
        da.Fill(dt, mID_ZAFRA, mZONA, mSUB_ZONA, mCODI_DEPTO, mCODI_MUNI, mCODI_CANTON, "", "")
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso dt(0).TC_CONTRATADO > 0 Then
            If dt(0).MZ_CONTRATADO > 0 Then Me.XrTableTC_MZ.Text = (dt(0).TC_CONTRATADO / dt(0).MZ_CONTRATADO).ToString("#,##0.00")
        End If

    End Sub


    Private Sub SummaryGetResult(sender As Object, e As DevExpress.XtraReports.UI.SummaryGetResultEventArgs) Handles xrTC_MZG1.SummaryGetResult
        If MZ > 0 Then
            e.Result = TC / MZ
        Else
            e.Result = 0
        End If
        e.Handled = True
    End Sub

    Private Sub SummaryReset(sender As Object, e As System.EventArgs) Handles xrTC_MZG1.SummaryReset
        MZ = 0
        TC = 0
    End Sub

    Private Sub SummaryRowChanged(sender As Object, e As System.EventArgs) Handles xrTC_MZG1.SummaryRowChanged
        MZ += Convert.ToDecimal(GetCurrentColumnValue("MZ_CONTRATADO"))
        TC += Convert.ToDecimal(GetCurrentColumnValue("TC_CONTRATADO"))
    End Sub
End Class