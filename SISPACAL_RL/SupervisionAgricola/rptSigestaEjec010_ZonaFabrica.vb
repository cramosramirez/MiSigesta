Imports SISPACAL.BL
Imports SISPACAL.EL

Public Class rptSigestaEjec010_ZonaFabrica

    Private _totalPlanCosecha_EntregadaGrupo As Decimal
    Private _totalPlanCosecha_PorEntregarGrupo As Decimal
    Private _totalPlanCosecha_EntregadaInforme As Decimal
    Private _totalPlanCosecha_PorEntregarInforme As Decimal

    Private _totalCanaEntregadaG As Decimal
    Private _totalCanaEntregadaI As Decimal
    Private _totalCanaPorEntregarG As Decimal
    Private _totalCanaPorEntregarI As Decimal


    Public Sub CargarDatos(ByVal TIPO As String, _
                           ByVal ZONA As String, ByVal SUB_ZONA As String, _
                           ByVal CODI_DEPTO As String, ByVal CODI_MUNI As String, _
                           ByVal CODIPROVEE As String, ByVal CODISOCIO As String,
                           ByVal NOMBRE_PROVEEDOR As String, ByVal ID_ZAFRA As Int32, _
                           ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, _
                           ByVal moliendaDiariaAjustada As Decimal)
        Dim sFecha1 As String = ""
        Dim sFecha2 As String = ""
        Dim sCodiProvee As String = ""
        Dim sCodiSocio As String = ""
        Dim sNombreProveedor As String = ""

        sNombreProveedor = NOMBRE_PROVEEDOR.ToUpper.Trim.Replace(" ", "%")

        Me.RPT_SIGESTA_EJEC010TableAdapter1.SetCommandTimeOut(900000)
        Me.RPT_SIGESTA_EJEC010TableAdapter1.FillPorZonaCriterios(DS_SIGESTA1.RPT_SIGESTA_EJEC010, TIPO, ID_ZAFRA, USUARIO_CREA, FECHA_CREA, ZONA, _
                                                                    SUB_ZONA, CODI_DEPTO, CODI_MUNI, CODIPROVEE, CODISOCIO, sNombreProveedor, True)

        Dim lDiasZafra As listaDIA_ZAFRA = (New cDIA_ZAFRA).ObtenerListaPorZAFRA(ID_ZAFRA, False, "FECHA", "DESC")
        Dim lDiaZafra As DIA_ZAFRA
        Dim bBascula As New cBASCULA
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZAFRA(ID_ZAFRA)
        If lZafra IsNot Nothing Then
            txtTITULO.Text = "EJECUCIÓN PLAN DE COSECHA - ZAFRA " + lZafra.NOMBRE_ZAFRA
            Me.DisplayName = "EJECUCIÓN PLAN DE COSECHA - ZAFRA " + Replace(lZafra.NOMBRE_ZAFRA, "/", "-")
        End If


        If lDiasZafra IsNot Nothing AndAlso lDiasZafra.Count > 0 Then
            lDiaZafra = lDiasZafra(0)
            Dim tonelEntregada As Decimal = bBascula.ObtenerTONEL_ENTREGADAPorZAFRA(ID_ZAFRA)
            Dim tonelPendienteEntregar As Decimal = bBascula.ObtenerTOTAL_TONEL_ENTREGARPorZAFRA(ID_ZAFRA)
            Dim tonelPendienteEntregarAJUSTADO As Decimal = 0
            Dim tonelEntregadaAlDiaZafra As Decimal = bBascula.ObtenerTONEL_ENTREGADA_AL_DIAZAFRA(ID_ZAFRA, lDiaZafra.DIAZAFRA)
            Dim tonelEntregadaAlDiaZafraAJUSTADO As Decimal = 0
            Dim moliendaDiaria As Decimal = 0
            Dim tonelPendienteEntregarAlDiaZafra As Decimal = 0
            Dim tonelPendienteEntregarAlDiaZafraAJUSTADO As Decimal = 0

            lblDiaZafra.Text = lDiaZafra.DIAZAFRA.ToString
            moliendaDiaria = Math.Round(tonelEntregadaAlDiaZafra / lDiaZafra.DIAZAFRA, 2)

            lblMoliendaDiariaPromedio.Text = moliendaDiaria.ToString("#,##0.00")

            tonelPendienteEntregarAlDiaZafra = (tonelEntregada - tonelEntregadaAlDiaZafra) + tonelPendienteEntregar
            lblSaldoPromedio.Text = Math.Round(tonelPendienteEntregarAlDiaZafra / moliendaDiaria, 0).ToString("#,##0.00")
            lblFechaFinPromedio.Text = DateAdd(DateInterval.Day, CDbl(Math.Round(tonelPendienteEntregarAlDiaZafra / moliendaDiaria, 5)), lDiaZafra.FECHA).ToString("dd/MM/yyyy")

            moliendaDiariaAjustada = bBascula.ObtenerTONEL_PROMEDIO_RANGO_DIAS_ZAFRA(ID_ZAFRA, 3)
            If moliendaDiariaAjustada > 0 Then
                lblMoliendaDiariaAjustada.Text = moliendaDiariaAjustada.ToString("#,##0.00")

                tonelPendienteEntregarAlDiaZafraAJUSTADO = (tonelEntregada - tonelEntregadaAlDiaZafraAJUSTADO) + tonelPendienteEntregar
                lblSaldoAjustado.Text = (tonelPendienteEntregarAlDiaZafra / moliendaDiariaAjustada).ToString("#,##0.00")
                lblFechaFinAjustada.Text = DateAdd(DateInterval.Day, CDbl(Math.Round(tonelPendienteEntregarAlDiaZafra / moliendaDiariaAjustada, 5)), lDiaZafra.FECHA).ToString("dd/MM/yyyy")
            End If
        End If
    End Sub

    Private Sub SummaryReset(sender As Object, e As System.EventArgs) Handles _
            xrPorcCanaEntregadaGrupo.SummaryReset, xrPorcCanaPorEntregarGrupo.SummaryReset, _
            xrPorcCanaEntregadaInforme.SummaryReset, xrPorcCanaPorEntregarInforme.SummaryReset
        Dim celda As DevExpress.XtraReports.UI.XRTableCell = TryCast(sender, DevExpress.XtraReports.UI.XRTableCell)
        If IsNothing(celda) Then Return

        Select Case celda.Name
            Case "xrPorcCanaEntregadaGrupo"
                _totalPlanCosecha_EntregadaGrupo = 0
                _totalCanaEntregadaG = 0

            Case "xrPorcCanaPorEntregarGrupo"
                _totalPlanCosecha_PorEntregarGrupo = 0
                _totalCanaPorEntregarG = 0

            Case "xrPorcCanaEntregadaInforme"
                _totalPlanCosecha_EntregadaInforme = 0
                _totalCanaEntregadaI = 0

            Case "xrPorcCanaPorEntregarInforme"
                _totalPlanCosecha_PorEntregarInforme = 0
                _totalCanaPorEntregarI = 0
        End Select
    End Sub

    Private Sub SummaryRowChanged(sender As Object, e As System.EventArgs) Handles _
          xrPorcCanaEntregadaGrupo.SummaryRowChanged, xrPorcCanaPorEntregarGrupo.SummaryRowChanged, _
          xrPorcCanaEntregadaInforme.SummaryRowChanged, xrPorcCanaPorEntregarInforme.SummaryRowChanged

        Dim celda As DevExpress.XtraReports.UI.XRTableCell = TryCast(sender, DevExpress.XtraReports.UI.XRTableCell)
        If IsNothing(celda) Then Return
        Select Case celda.Name
            Case "xrPorcCanaEntregadaGrupo"
                If IsDBNull(GetCurrentColumnValue("TONEL_CENSO")) Then Return
                _totalPlanCosecha_EntregadaGrupo += Convert.ToDecimal(GetCurrentColumnValue("TONEL_CENSO"))
                If Not IsDBNull(GetCurrentColumnValue("TONEL_ENTREGADA")) Then _totalCanaEntregadaG += Convert.ToDecimal(GetCurrentColumnValue("TONEL_ENTREGADA"))
            Case "xrPorcCanaPorEntregarGrupo"
                If IsDBNull(GetCurrentColumnValue("TONEL_CENSO")) Then Return
                _totalPlanCosecha_PorEntregarGrupo += Convert.ToDecimal(GetCurrentColumnValue("TONEL_CENSO"))
                If Not IsDBNull(GetCurrentColumnValue("TONEL_ENTREGAR")) Then _totalCanaPorEntregarG += Convert.ToDecimal(GetCurrentColumnValue("TONEL_ENTREGAR"))
            Case "xrPorcCanaEntregadaInforme"
                If IsDBNull(GetCurrentColumnValue("TONEL_CENSO")) Then Return
                _totalPlanCosecha_EntregadaInforme += Convert.ToDecimal(GetCurrentColumnValue("TONEL_CENSO"))
                If Not IsDBNull(GetCurrentColumnValue("TONEL_ENTREGADA")) Then _totalCanaEntregadaI += Convert.ToDecimal(GetCurrentColumnValue("TONEL_ENTREGADA"))
            Case "xrPorcCanaPorEntregarInforme"
                If IsDBNull(GetCurrentColumnValue("TONEL_CENSO")) Then Return
                _totalPlanCosecha_PorEntregarInforme += Convert.ToDecimal(GetCurrentColumnValue("TONEL_CENSO"))
                If Not IsDBNull(GetCurrentColumnValue("TONEL_ENTREGAR")) Then _totalCanaPorEntregarI += Convert.ToDecimal(GetCurrentColumnValue("TONEL_ENTREGAR"))
        End Select
    End Sub

    Private Sub SummaryGetResult(sender As Object, e As DevExpress.XtraReports.UI.SummaryGetResultEventArgs) Handles _
        xrPorcCanaEntregadaGrupo.SummaryGetResult, xrPorcCanaPorEntregarGrupo.SummaryGetResult, _
        xrPorcCanaEntregadaInforme.SummaryGetResult, xrPorcCanaPorEntregarInforme.SummaryGetResult
        Dim celda As DevExpress.XtraReports.UI.XRTableCell = TryCast(sender, DevExpress.XtraReports.UI.XRTableCell)
        If IsNothing(celda) Then Return
        Select Case celda.Name
            Case "xrPorcCanaEntregadaGrupo"
                If _totalPlanCosecha_EntregadaGrupo > 0 Then e.Result = Math.Round(_totalCanaEntregadaG / _totalPlanCosecha_EntregadaGrupo, 5) Else e.Result = 0
            Case "xrPorcCanaPorEntregarGrupo"
                If _totalPlanCosecha_PorEntregarGrupo > 0 Then e.Result = Math.Round(_totalCanaPorEntregarG / _totalPlanCosecha_PorEntregarGrupo, 5) Else e.Result = 0
            Case "xrPorcCanaEntregadaInforme"
                If _totalPlanCosecha_EntregadaInforme > 0 Then e.Result = Math.Round(_totalCanaEntregadaI / _totalPlanCosecha_EntregadaInforme, 5) Else e.Result = 0
            Case "xrPorcCanaPorEntregarInforme"
                If _totalPlanCosecha_PorEntregarInforme > 0 Then e.Result = Math.Round(_totalCanaPorEntregarI / _totalPlanCosecha_PorEntregarInforme, 5) Else e.Result = 0
        End Select
        e.Handled = True
    End Sub

End Class