Imports SISPACAL.BL
Imports SISPACAL.EL
Public Class ResultadoAnalisisPreCosecha
    Private _azucarReductores As Decimal
    Private _pol As Decimal
    Private _brix As Decimal
    Private _dextrana As Decimal
    Private _dextrana_brix As Decimal

    Private _tonel_azucar As Decimal
    Private _tonel_pol As Decimal
    Private _tonel_brix As Decimal
    Private _tonel_dextrana As Decimal
    Private _tonel_dextrana_brix As Decimal

    Public Sub CargarDatos(ByVal ID_ZAFRA As Int32, ByVal FECHA1 As DateTime, FECHA2 As DateTime, Optional ZONA As String = "")
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZAFRA(ID_ZAFRA)
        If Not IsNothing(lZafra) Then xrZafra.Text = "ZAFRA: " + lZafra.NOMBRE_ZAFRA
        Me.ResultadoS_ANALISIS_PRECOSECHATableAdapter1.FillPorFechas(DS_SIGESTA1.RESULTADOS_ANALISIS_PRECOSECHA, FECHA1, FECHA2, ID_ZAFRA, ZONA)
    End Sub

    Private Sub SummaryGetResult(sender As Object, e As DevExpress.XtraReports.UI.SummaryGetResultEventArgs) Handles _
             xrPolJugo.SummaryGetResult, xrBrixJugo.SummaryGetResult, xrDextrana.SummaryGetResult, xrDextranaBrix.SummaryGetResult
        Dim celda As DevExpress.XtraReports.UI.XRTableCell = TryCast(sender, DevExpress.XtraReports.UI.XRTableCell)
        If IsNothing(celda) Then Return
        Select Case celda.Name
            Case "xrAzucarReductores"
                If _tonel_azucar > 0 Then e.Result = Math.Round(_azucarReductores / _tonel_azucar, 4) Else e.Result = 0
            Case "xrPolJugo"
                If _tonel_pol > 0 Then e.Result = Math.Round(_pol / _tonel_pol, 4) Else e.Result = 0
            Case "xrBrixJugo"
                If _tonel_brix > 0 Then e.Result = Math.Round(_brix / _tonel_brix, 4) Else e.Result = 0
            Case "xrDextrana"
                If _tonel_dextrana > 0 Then e.Result = Math.Round(_dextrana / _tonel_dextrana, 4) Else e.Result = 0
            Case "xrDextranaBrix"
                If _tonel_dextrana_brix > 0 Then e.Result = Math.Round(_dextrana_brix / _tonel_dextrana_brix, 4) Else e.Result = 0
        End Select
        e.Handled = True
    End Sub
    Private Sub SummaryReset(sender As Object, e As System.EventArgs) Handles _
            xrAzucarReductores.SummaryReset, xrPolJugo.SummaryReset, xrBrixJugo.SummaryReset, xrDextrana.SummaryReset, xrDextranaBrix.SummaryReset
        Dim celda As DevExpress.XtraReports.UI.XRTableCell = TryCast(sender, DevExpress.XtraReports.UI.XRTableCell)
        If IsNothing(celda) Then Return
        Select Case celda.Name
            Case "xrAzucarReductores"
                _azucarReductores = 0
            Case "xrPolJugo"
                _pol = 0
            Case "xrBrixJugo"
                _brix = 0
            Case "xrDextrana"
                _dextrana = 0
            Case "xrDextranaBrix"
                _dextrana_brix = 0
        End Select
    End Sub
    Private Sub SummaryRowChanged(sender As Object, e As System.EventArgs) Handles _
        xrAzucarReductores.SummaryRowChanged, xrPolJugo.SummaryRowChanged, xrBrixJugo.SummaryRowChanged, xrDextrana.SummaryRowChanged, xrDextranaBrix.SummaryRowChanged
        Dim celda As DevExpress.XtraReports.UI.XRTableCell = TryCast(sender, DevExpress.XtraReports.UI.XRTableCell)
        If IsNothing(celda) Then Return
        Select Case celda.Name
            Case "xrAzucarReductores"
                If IsDBNull(GetCurrentColumnValue("AZUCAR_REDUCTORES")) Then Return
                _azucarReductores += Convert.ToDecimal(GetCurrentColumnValue("AZUCAR_REDUCTORES")) * Convert.ToDecimal(GetCurrentColumnValue("TONEL_CENSO"))
                _tonel_azucar += Convert.ToDecimal(GetCurrentColumnValue("TONEL_CENSO"))
            Case "xrPolJugo"
                If IsDBNull(GetCurrentColumnValue("POL_JUGO")) Then Return
                _pol += Convert.ToDecimal(GetCurrentColumnValue("POL")) * Convert.ToDecimal(GetCurrentColumnValue("TONEL_CENSO"))
                _tonel_pol += Convert.ToDecimal(GetCurrentColumnValue("TONEL_CENSO"))
            Case "xrBrixJugo"
                If IsDBNull(GetCurrentColumnValue("BRIX")) Then Return
                _brix += Convert.ToDecimal(GetCurrentColumnValue("BRIX")) * Convert.ToDecimal(GetCurrentColumnValue("TONEL_CENSO"))
                _tonel_brix += Convert.ToDecimal(GetCurrentColumnValue("TONEL_CENSO"))
            Case "xrDextrana"
                If IsDBNull(GetCurrentColumnValue("DEXTRANA")) Then Return
                _dextrana += Convert.ToDecimal(GetCurrentColumnValue("DEXTRANA")) * Convert.ToDecimal(GetCurrentColumnValue("TONEL_CENSO"))
                _tonel_dextrana += Convert.ToDecimal(GetCurrentColumnValue("TONEL_CENSO"))
            Case "xrDextranaBrix"
                If IsDBNull(GetCurrentColumnValue("DEXTRA_BRIZ")) Then Return
                _dextrana_brix += Convert.ToDecimal(GetCurrentColumnValue("DEXTRA_BRIZ")) * Convert.ToDecimal(GetCurrentColumnValue("TONEL_CENSO"))
                _tonel_dextrana_brix += Convert.ToDecimal(GetCurrentColumnValue("TONEL_CENSO"))
        End Select
    End Sub

End Class