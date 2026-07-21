Imports SISPACAL.BL
Imports SISPACAL.EL
Public Class ResultadoAnalisisPreCosechaAlmidon
    Dim _azucarReductores As Decimal
    Dim _pol As Decimal
    Dim _brix As Decimal
    Dim _almidon As Decimal

    Dim _tonel_azucar As Decimal
    Dim _tonel_pol As Decimal
    Dim _tonel_brix As Decimal
    Dim _tonel_almidon As Decimal

    Public Sub CargarDatos(ByVal ID_ZAFRA As Int32, ByVal FECHA1 As DateTime, FECHA2 As DateTime, Optional ZAFRA As String = "")
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZAFRA(ID_ZAFRA)
        If Not IsNothing(lZafra) Then xrZafra.Text = "ZAFRA: " + lZafra.NOMBRE_ZAFRA
        Me.ResultadoS_ANALISIS_PRECOSECHATableAdapter1.FillPorFechas(DS_SIGESTA1.RESULTADOS_ANALISIS_PRECOSECHA, FECHA1, FECHA2, ID_ZAFRA, ZAFRA)
    End Sub

    Private Sub SummaryGetResult(sender As Object, e As DevExpress.XtraReports.UI.SummaryGetResultEventArgs) Handles _
             xrPolJugo.SummaryGetResult, xrBrixJugo.SummaryGetResult, xrAlmidon.SummaryGetResult
        Dim celda As DevExpress.XtraReports.UI.XRTableCell = TryCast(sender, DevExpress.XtraReports.UI.XRTableCell)
        If IsNothing(celda) Then Return
        Select Case celda.Name
            Case "xrAzucarReductores"
                If _tonel_azucar > 0 Then e.Result = Math.Round(_azucarReductores / _tonel_azucar, 4) Else e.Result = 0
            Case "xrPolJugo"
                If _tonel_pol > 0 Then e.Result = Math.Round(_pol / _tonel_pol, 4) Else e.Result = 0
            Case "xrBrixJugo"
                If _tonel_brix > 0 Then e.Result = Math.Round(_brix / _tonel_brix, 4) Else e.Result = 0
        End Select
        e.Handled = True
    End Sub
    Private Sub SummaryReset(sender As Object, e As System.EventArgs) Handles _
             xrPolJugo.SummaryReset, xrBrixJugo.SummaryReset, xrAlmidon.SummaryReset
        Dim celda As DevExpress.XtraReports.UI.XRTableCell = TryCast(sender, DevExpress.XtraReports.UI.XRTableCell)
        If IsNothing(celda) Then Return
        Select Case celda.Name
            Case "xrAzucarReductores"
                _azucarReductores = 0
            Case "xrPolJugo"
                _pol = 0
            Case "xrBrixJugo"
                _brix = 0
        End Select
    End Sub
    Private Sub SummaryRowChanged(sender As Object, e As System.EventArgs) Handles _
         xrPolJugo.SummaryRowChanged, xrBrixJugo.SummaryRowChanged, xrAlmidon.SummaryRowChanged
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
        End Select
    End Sub
End Class