Imports SISPACAL.BL
Imports SISPACAL.EL

Public Class rptSigestaEjec003_Zona
    Private _azucar85Grupo As Decimal
    Private _azucar85Informe As Decimal

    Private _azucarRealGrupo As Decimal
    Private _azucarRealInforme As Decimal

    Private _azucarEficienciaGrupo As Decimal
    Private _azucarEficienciaInforme As Decimal

    Private _tonel85Grupo As Decimal
    Private _tonel85Informe As Decimal

    Private _tonelRealGrupo As Decimal
    Private _tonelRealInforme As Decimal

    Private _azucar85EficienciaGrupo As Decimal
    Private _azucarRealEficienciaGrupo As Decimal
    Private _azucar85EficienciaInforme As Decimal
    Private _azucarRealEficienciaInforme As Decimal


    Public Sub CargarDatos(ByVal TIPO As String, _
                           ByVal ZONA As String, ByVal SUB_ZONA As String, _
                           ByVal CODI_DEPTO As String, ByVal CODI_MUNI As String, _
                           ByVal CODIPROVEE As String, ByVal CODISOCIO As String,
                           ByVal CODIVARIEDAD As String, ByVal ID_TIPO_CANA As Int32, ByVal FECHA1 As DateTime, ByVal FECHA2 As DateTime, _
                           ByVal NOMBRE_PROVEEDOR As String, ByVal ID_ZAFRA As Int32, _
                           ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal SEMANA As Int32, ByVal CATORCENA As Int32)
        Dim sFecha1 As String = ""
        Dim sFecha2 As String = ""
        Dim sCodiProvee As String = ""
        Dim sCodiSocio As String = ""
        Dim sNombreProveedor As String = ""

        sNombreProveedor = NOMBRE_PROVEEDOR.ToUpper.Trim.Replace(" ", "%")
        If FECHA1 <> #12:00:00 AM# Then sFecha1 = FECHA1.ToString("dd/MM/yyyy")
        If FECHA2 <> #12:00:00 AM# Then sFecha2 = FECHA1.ToString("dd/MM/yyyy")

        Me.RPT_SIGESTA_EJEC003TableAdapter1.SetCommandTimeOut(900000)
        Me.RPT_SIGESTA_EJEC003TableAdapter1.FillPorCriterios(DS_SIGESTA1.RPT_SIGESTA_EJEC003, TIPO, ID_ZAFRA, USUARIO_CREA, FECHA_CREA, ZONA, _
                                                            SUB_ZONA, CODI_DEPTO, CODI_MUNI, CODIPROVEE, CODISOCIO, CODIVARIEDAD, ID_TIPO_CANA, sFecha1, sFecha2, sNombreProveedor, SEMANA, CATORCENA)

        Dim lDiasZafra As listaDIA_ZAFRA = (New cDIA_ZAFRA).ObtenerListaPorZAFRA(ID_ZAFRA, False, "FECHA", "DESC")
        Dim lCatorcenas As listaCATORCENA_ZAFRA = (New cCATORCENA_ZAFRA).ObtenerListaPorZAFRA(ID_ZAFRA, False, False, "CATORCENA", "DESC")
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZAFRA(ID_ZAFRA)
        If lZafra IsNot Nothing Then lblZAFRA.Text = "ZAFRA " + lZafra.NOMBRE_ZAFRA

        If lDiasZafra IsNot Nothing AndAlso lDiasZafra.Count > 0 Then
            lblDiaZafra.Text = lDiasZafra(0).DIAZAFRA.ToString
        End If
        If lCatorcenas IsNot Nothing AndAlso lCatorcenas.Count > 0 Then
            lblUltimaCatorcena.Text = lCatorcenas(0).CATORCENA.ToString
        End If

        Dim lLotesCosecha As LOTES_COSECHA = (New cLOTES_COSECHA).ObtenerTOTAL_PLAN_COSECHAPorZAFRA(ID_ZAFRA)
        If lLotesCosecha IsNot Nothing AndAlso lLotesCosecha.TONEL_CENSO > 0 Then
            xrMontoPlanCosecha.Text = lLotesCosecha.TONEL_CENSO.ToString("#,##0.00")
            xrMontoEjecutado.Text = lLotesCosecha.TONEL_ENTREGADA.ToString("#,##0.00")
            xrPorcEjecutado.Text = Math.Round(lLotesCosecha.TONEL_ENTREGADA / lLotesCosecha.TONEL_CENSO * 100, 2).ToString("#0.00") + "%"
            xrMontoEjecutar.Text = (lLotesCosecha.TONEL_ENTREGAR).ToString("#,##0.00")
            xrPorcEjecutar.Text = ((lLotesCosecha.TONEL_ENTREGAR) / lLotesCosecha.TONEL_CENSO * 100).ToString("#0.00") + "%"
        Else
            xrMontoPlanCosecha.Text = "0.00"
            xrMontoEjecutado.Text = "0.00"
            xrPorcEjecutado.Text = "0.00%"
            xrMontoEjecutar.Text = "0.00"
            xrPorcEjecutar.Text = "100.00%"
        End If
    End Sub

    'Private Sub SummaryGetResult(sender As Object, e As DevExpress.XtraReports.UI.SummaryGetResultEventArgs) Handles _
    '        xrREND_85grupo.SummaryGetResult, xrREND_85informe.SummaryGetResult, _
    '        xrREND_REALgrupo.SummaryGetResult, xrREND_REALinforme.SummaryGetResult, _
    '        xrEFICIENCIAgrupo.SummaryGetResult, xrEFICIENCIAinforme.SummaryGetResult
    '    Dim celda As DevExpress.XtraReports.UI.XRTableCell = TryCast(sender, DevExpress.XtraReports.UI.XRTableCell)
    '    If IsNothing(celda) Then Return
    '    Select Case celda.Name
    '        Case "xrREND_85grupo"
    '            If _tonel85Grupo > 0 Then e.Result = Math.Round(_azucar85Grupo / _tonel85Grupo, 2) Else e.Result = 0
    '        Case "xrREND_85informe"
    '            If _tonel85Informe > 0 Then e.Result = Math.Round(_azucar85Informe / _tonel85Informe, 2) Else e.Result = 0
    '        Case "xrREND_REALgrupo"
    '            If _tonelRealGrupo > 0 Then e.Result = Math.Round(_azucarRealGrupo / _tonelRealGrupo, 2) Else e.Result = 0
    '        Case "xrREND_REALinforme"
    '            If _tonelRealInforme > 0 Then e.Result = Math.Round(_azucarRealInforme / _tonelRealInforme, 2) Else e.Result = 0
    '        Case "xrEFICIENCIAgrupo"
    '            If _azucarRealEficienciaGrupo > 0 Then e.Result = Math.Round(_azucar85EficienciaGrupo / _azucarRealEficienciaGrupo, 2) Else e.Result = 0
    '        Case "xrEFICIENCIAinforme"
    '            If _azucarRealEficienciaInforme > 0 Then e.Result = Math.Round(_azucar85EficienciaInforme / _azucarRealEficienciaInforme, 2) Else e.Result = 0
    '    End Select
    '    e.Handled = True
    'End Sub

    'Private Sub SummaryReset(sender As Object, e As System.EventArgs) Handles _
    '        xrREND_85grupo.SummaryReset, xrREND_85informe.SummaryReset, _
    '        xrREND_REALgrupo.SummaryReset, xrREND_REALinforme.SummaryReset, _
    '        xrEFICIENCIAgrupo.SummaryReset, xrEFICIENCIAinforme.SummaryReset
    '    Dim celda As DevExpress.XtraReports.UI.XRTableCell = TryCast(sender, DevExpress.XtraReports.UI.XRTableCell)
    '    If IsNothing(celda) Then Return
    '    Select Case celda.Name
    '        Case "xrREND_85grupo"
    '            _tonel85Grupo = 0
    '            _azucar85Grupo = 0
    '        Case "xrREND_85informe"
    '            _tonel85Informe = 0
    '            _azucar85Informe = 0
    '        Case "xrREND_REALgrupo"
    '            _tonelRealGrupo = 0
    '            _azucarRealGrupo = 0
    '        Case "xrREND_REALinforme"
    '            _tonelRealInforme = 0
    '            _azucarRealInforme = 0
    '        Case "xrEFICIENCIAgrupo"
    '            _azucar85EficienciaGrupo = 0
    '            _azucarRealEficienciaGrupo = 0
    '        Case "xrEFICIENCIAinforme"
    '            _azucar85EficienciaInforme = 0
    '            _azucarRealEficienciaInforme = 0
    '    End Select
    'End Sub

    'Private Sub SummaryRowChanged(sender As Object, e As System.EventArgs) Handles _
    '        xrREND_85grupo.SummaryRowChanged, xrREND_85informe.SummaryRowChanged, _
    '        xrREND_REALgrupo.SummaryRowChanged, xrREND_REALinforme.SummaryRowChanged, _
    '        xrEFICIENCIAgrupo.SummaryRowChanged, xrEFICIENCIAinforme.SummaryRowChanged
    '    Dim celda As DevExpress.XtraReports.UI.XRTableCell = TryCast(sender, DevExpress.XtraReports.UI.XRTableCell)
    '    If IsNothing(celda) Then Return
    '    Select Case celda.Name
    '        Case "xrREND_85grupo"
    '            If IsDBNull(GetCurrentColumnValue("AZUCAR_CALC2")) Then Return
    '            _tonel85Grupo += Convert.ToDecimal(GetCurrentColumnValue("NETOTONEL"))
    '            _azucar85Grupo += Convert.ToDecimal(GetCurrentColumnValue("AZUCAR_CALC2"))
    '        Case "xrREND_85informe"
    '            If IsDBNull(GetCurrentColumnValue("AZUCAR_CALC2")) Then Return
    '            _tonel85Informe += Convert.ToDecimal(GetCurrentColumnValue("NETOTONEL"))
    '            _azucar85Informe += Convert.ToDecimal(GetCurrentColumnValue("AZUCAR_CALC2"))
    '        Case "xrREND_REALgrupo"
    '            If IsDBNull(GetCurrentColumnValue("AZUCAR_CATORCENA_REAL")) Then Return
    '            _tonelRealGrupo += Convert.ToDecimal(GetCurrentColumnValue("NETOTONEL"))
    '            _azucarRealGrupo += Convert.ToDecimal(GetCurrentColumnValue("AZUCAR_CATORCENA_REAL"))
    '        Case "xrREND_REALinforme"
    '            If IsDBNull(GetCurrentColumnValue("AZUCAR_CATORCENA_REAL")) Then Return
    '            _tonelRealInforme += Convert.ToDecimal(GetCurrentColumnValue("NETOTONEL"))
    '            _azucarRealInforme += Convert.ToDecimal(GetCurrentColumnValue("AZUCAR_CATORCENA_REAL"))
    '        Case "xrEFICIENCIAgrupo"
    '            If IsDBNull(GetCurrentColumnValue("AZUCAR_CATORCENA_REAL")) Then Return
    '            _azucar85EficienciaGrupo += Convert.ToDecimal(GetCurrentColumnValue("AZUCAR_CALC2"))
    '            _azucarRealEficienciaGrupo += Convert.ToDecimal(GetCurrentColumnValue("AZUCAR_CATORCENA_REAL"))
    '        Case "xrEFICIENCIAinforme"
    '            If IsDBNull(GetCurrentColumnValue("AZUCAR_CATORCENA_REAL")) Then Return
    '            _azucar85EficienciaInforme += Convert.ToDecimal(GetCurrentColumnValue("AZUCAR_CALC2"))
    '            _azucarRealEficienciaInforme += Convert.ToDecimal(GetCurrentColumnValue("AZUCAR_CATORCENA_REAL"))
    '    End Select
    'End Sub

    Private Sub GroupFooter1_BeforePrint(sender As Object, e As System.Drawing.Printing.PrintEventArgs) Handles GroupFooter1.BeforePrint
        e.Cancel = (GetCurrentColumnValue("CORTE_CERRADO") = 0)
    End Sub
End Class