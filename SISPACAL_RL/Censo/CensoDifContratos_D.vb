Imports DevExpress.XtraReports.UI

Public Class CensoDifContratos_D

    Private MZ_G1_CONTRA As Decimal = 0
    Private TC_G1_CONTRA As Decimal = 0
    Private MZ_G2_CONTRA As Decimal = 0
    Private TC_G2_CONTRA As Decimal = 0
    Private MZ_G3_CONTRA As Decimal = 0
    Private TC_G3_CONTRA As Decimal = 0

    Private MZ_G1_CENSO As Decimal = 0
    Private TC_G1_CENSO As Decimal = 0
    Private MZ_G2_CENSO As Decimal = 0
    Private TC_G2_CENSO As Decimal = 0
    Private MZ_G3_CENSO As Decimal = 0
    Private TC_G3_CENSO As Decimal = 0

    Private MZ_G1_DIF As Decimal = 0
    Private TC_G1_DIF As Decimal = 0
    Private MZ_G2_DIF As Decimal = 0
    Private TC_G2_DIF As Decimal = 0
    Private MZ_G3_DIF As Decimal = 0
    Private TC_G3_DIF As Decimal = 0

    Public Sub CargarDatos(ByVal ID_CENSO As Integer, ByVal ZONA As String, ByVal SUB_ZONA As String, ByVal CODI_DEPTO As String, ByVal CODI_MUNI As String, ByVal CODI_CANTON As String)
        Me.CensoTableAdapter1.FillPorZona(Me.DS_SIGESTA1.CENSO, ID_CENSO, ZONA, SUB_ZONA, CODI_DEPTO, CODI_MUNI, CODI_CANTON)
        Me.DisplayName = "CONTRATOS VRS CENSO (MZ - TC)"
    End Sub
    Public Sub CargarCierreZafra(ByVal ID_CENSO As Integer, ByVal ZONA As String, ByVal SUB_ZONA As String, ByVal CODI_DEPTO As String, ByVal CODI_MUNI As String, ByVal CODI_CANTON As String)
        Me.CensoTableAdapter1.FillPorZonaCierreZafra(Me.DS_SIGESTA1.CENSO, ID_CENSO, ZONA, SUB_ZONA, CODI_DEPTO, CODI_MUNI, CODI_CANTON)
        Me.DisplayName = "CONTRATOS VRS CENSO (MZ - TC)"
    End Sub

    Private Sub SummaryGetResult(sender As Object, e As DevExpress.XtraReports.UI.SummaryGetResultEventArgs) _
            Handles xrTC_MZG1_CONTRA.SummaryGetResult, xrTC_MZG2_CONTRA.SummaryGetResult, xrTC_MZG3_CONTRA.SummaryGetResult, _
                xrTC_MZG1_CENSO.SummaryGetResult, xrTC_MZG2_CENSO.SummaryGetResult, xrTC_MZG3_CENSO.SummaryGetResult, _
                xrTC_MZG1_DIF.SummaryGetResult, xrTC_MZG2_DIF.SummaryGetResult, xrTC_MZG3_DIF.SummaryGetResult

        Select Case TryCast(sender, XRTableCell).Name
            Case "xrTC_MZG1_CONTRA"
                e.Result = If(MZ_G1_CONTRA > 0, TC_G1_CONTRA / MZ_G1_CONTRA, 0)
            Case "xrTC_MZG2_CONTRA"
                e.Result = If(MZ_G2_CONTRA > 0, TC_G2_CONTRA / MZ_G2_CONTRA, 0)
            Case "xrTC_MZG3_CONTRA"
                e.Result = If(MZ_G3_CONTRA > 0, TC_G3_CONTRA / MZ_G3_CONTRA, 0)

            Case "xrTC_MZG1_CENSO"
                e.Result = If(MZ_G1_CENSO > 0, TC_G1_CENSO / MZ_G1_CENSO, 0)
            Case "xrTC_MZG2_CENSO"
                e.Result = If(MZ_G2_CENSO > 0, TC_G2_CENSO / MZ_G2_CENSO, 0)
            Case "xrTC_MZG3_CENSO"
                e.Result = If(MZ_G3_CENSO > 0, TC_G3_CENSO / MZ_G3_CENSO, 0)

            Case "xrTC_MZG1_DIF"
                e.Result = If(MZ_G1_DIF > 0, TC_G1_DIF / MZ_G1_DIF, 0)
            Case "xrTC_MZG2_DIF"
                e.Result = If(MZ_G2_DIF > 0, TC_G2_DIF / MZ_G2_DIF, 0)
            Case "xrTC_MZG3_DIF"
                e.Result = If(MZ_G3_DIF > 0, TC_G3_DIF / MZ_G3_DIF, 0)
        End Select
        e.Handled = True
    End Sub

    Private Sub SummaryReset(sender As Object, e As System.EventArgs) _
            Handles xrTC_MZG1_CONTRA.SummaryReset, xrTC_MZG2_CONTRA.SummaryReset, xrTC_MZG3_CONTRA.SummaryReset, _
                xrTC_MZG1_CENSO.SummaryReset, xrTC_MZG2_CENSO.SummaryReset, xrTC_MZG3_CENSO.SummaryReset, _
                xrTC_MZG1_DIF.SummaryReset, xrTC_MZG2_DIF.SummaryReset, xrTC_MZG3_DIF.SummaryReset
        Select Case TryCast(sender, XRTableCell).Name
            Case "xrTC_MZG1_CONTRA"
                MZ_G1_CONTRA = 0
                TC_G1_CONTRA = 0
            Case "xrTC_MZG2_CONTRA"
                MZ_G2_CONTRA = 0
                TC_G2_CONTRA = 0
            Case "xrTC_MZG3_CONTRA"
                MZ_G3_CONTRA = 0
                TC_G3_CONTRA = 0
            Case "xrTC_MZG1_CENSO"
                MZ_G1_CENSO = 0
                TC_G1_CENSO = 0
            Case "xrTC_MZG2_CENSO"
                MZ_G2_CENSO = 0
                TC_G2_CENSO = 0
            Case "xrTC_MZG3_CENSO"
                MZ_G3_CENSO = 0
                TC_G3_CENSO = 0
            Case "xrTC_MZG1_DIF"
                MZ_G1_DIF = 0
                TC_G1_DIF = 0
            Case "xrTC_MZG2_DIF"
                MZ_G2_DIF = 0
                TC_G2_DIF = 0
            Case "xrTC_MZG3_DIF"
                MZ_G3_DIF = 0
                TC_G3_DIF = 0
        End Select
    End Sub

    Private Sub SummaryRowChanged(sender As Object, e As System.EventArgs) _
            Handles xrTC_MZG1_CONTRA.SummaryRowChanged, xrTC_MZG2_CONTRA.SummaryRowChanged, xrTC_MZG3_CONTRA.SummaryRowChanged, _
                xrTC_MZG1_CENSO.SummaryRowChanged, xrTC_MZG2_CENSO.SummaryRowChanged, xrTC_MZG3_CENSO.SummaryRowChanged, _
                xrTC_MZG1_DIF.SummaryRowChanged, xrTC_MZG2_DIF.SummaryRowChanged, xrTC_MZG3_DIF.SummaryRowChanged

        Select Case TryCast(sender, XRTableCell).Name
            Case "xrTC_MZG1_CONTRA"
                MZ_G1_CONTRA += Convert.ToDecimal(GetCurrentColumnValue("MZ_CONTRATADO"))
                TC_G1_CONTRA += Convert.ToDecimal(GetCurrentColumnValue("TC_CONTRATADO"))
            Case "xrTC_MZG2_CONTRA"
                MZ_G2_CONTRA += Convert.ToDecimal(GetCurrentColumnValue("MZ_CONTRATADO"))
                TC_G2_CONTRA += Convert.ToDecimal(GetCurrentColumnValue("TC_CONTRATADO"))
            Case "xrTC_MZG3_CONTRA"
                MZ_G3_CONTRA += Convert.ToDecimal(GetCurrentColumnValue("MZ_CONTRATADO"))
                TC_G3_CONTRA += Convert.ToDecimal(GetCurrentColumnValue("TC_CONTRATADO"))
            Case "xrTC_MZG1_CENSO"
                MZ_G1_CENSO += Convert.ToDecimal(GetCurrentColumnValue("MZ_CENSO"))
                TC_G1_CENSO += Convert.ToDecimal(GetCurrentColumnValue("TONEL_CENSO"))
            Case "xrTC_MZG2_CENSO"
                MZ_G2_CENSO += Convert.ToDecimal(GetCurrentColumnValue("MZ_CENSO"))
                TC_G2_CENSO += Convert.ToDecimal(GetCurrentColumnValue("TONEL_CENSO"))
            Case "xrTC_MZG3_CENSO"
                MZ_G3_CENSO += Convert.ToDecimal(GetCurrentColumnValue("MZ_CENSO"))
                TC_G3_CENSO += Convert.ToDecimal(GetCurrentColumnValue("TONEL_CENSO"))
            Case "xrTC_MZG1_DIF"
                MZ_G1_DIF += Convert.ToDecimal(GetCurrentColumnValue("MZ_VAR"))
                TC_G1_DIF += Convert.ToDecimal(GetCurrentColumnValue("TC_VAR"))
            Case "xrTC_MZG2_DIF"
                MZ_G2_DIF += Convert.ToDecimal(GetCurrentColumnValue("MZ_VAR"))
                TC_G2_DIF += Convert.ToDecimal(GetCurrentColumnValue("TC_VAR"))
            Case "xrTC_MZG3_DIF"
                MZ_G3_DIF += Convert.ToDecimal(GetCurrentColumnValue("MZ_VAR"))
                TC_G3_DIF += Convert.ToDecimal(GetCurrentColumnValue("TC_VAR"))
        End Select
    End Sub
End Class