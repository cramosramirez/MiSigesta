Imports SISPACAL.BL
Imports SISPACAL.EL

Public Class ProgramacionCosechaTransporte


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
        Me.RPT_SIGESTA_EJEC014_PLAN_COSECHATableAdapter1.FillPorZona(DS_SIGESTA1.RPT_SIGESTA_EJEC014_PLAN_COSECHA, TIPO, ID_ZAFRA, USUARIO_CREA, FECHA_CREA, ZONA, _
                                                                    SUB_ZONA, CODI_DEPTO, CODI_MUNI, CODIPROVEE, CODISOCIO, CODIVARIEDAD, ID_TIPO_CANA, sFecha1, sFecha2, sNombreProveedor, SEMANA, CATORCENA)


        Dim lDiasZafra As listaDIA_ZAFRA = (New cDIA_ZAFRA).ObtenerListaPorZAFRA(ID_ZAFRA, False, "FECHA", "DESC")
        Dim lDiaZafra As DIA_ZAFRA
        Dim bBascula As New cBASCULA
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZAFRA(ID_ZAFRA)
        If lZafra IsNot Nothing Then txtTITULO.Text = "RECURSO DEL CAT POR TIPO DE TRANSPORTE - ZAFRA " + lZafra.NOMBRE_ZAFRA

        If lDiasZafra IsNot Nothing AndAlso lDiasZafra.Count > 0 Then
            lDiaZafra = lDiasZafra(0)
            Dim tonelEntregada As Decimal = bBascula.ObtenerTONEL_ENTREGADAPorZAFRA(ID_ZAFRA)
            Dim tonelPendienteEntregar As Decimal = bBascula.ObtenerTOTAL_TONEL_ENTREGARPorZAFRA(ID_ZAFRA)
            Dim tonelPendienteEntregarAJUSTADO As Decimal = 0
            Dim tonelEntregadaAlDiaZafra As Decimal = bBascula.ObtenerTONEL_ENTREGADA_AL_DIAZAFRA(ID_ZAFRA, lDiaZafra.DIAZAFRA)
            Dim tonelEntregadaAlDiaZafraAJUSTADO As Decimal = 0
            Dim moliendaDiaria As Decimal = 0
            Dim moliendaDiariaAJUSTADO As Decimal = 0
            Dim tonelPendienteEntregarAlDiaZafra As Decimal = 0
            Dim tonelPendienteEntregarAlDiaZafraAJUSTADO As Decimal = 0

            lblDiaZafra.Text = lDiaZafra.DIAZAFRA.ToString
            moliendaDiaria = Math.Round(tonelEntregadaAlDiaZafra / lDiaZafra.DIAZAFRA, 2)
            moliendaDiariaAJUSTADO = bBascula.ObtenerTONEL_PROMEDIO_RANGO_DIAS_ZAFRA(ID_ZAFRA, 3)

            lblMoliendaDiariaPromedio.Text = moliendaDiaria.ToString("#,##0.00")
            lblMoliendaDiariaAjustada.Text = moliendaDiariaAJUSTADO.ToString("#,##0.00")

            tonelPendienteEntregarAlDiaZafra = (tonelEntregada - tonelEntregadaAlDiaZafra) + tonelPendienteEntregar
            lblSaldoPromedio.Text = Math.Round(tonelPendienteEntregarAlDiaZafra / moliendaDiaria, 0).ToString("#,##0.00")
            lblFechaFinPromedio.Text = DateAdd(DateInterval.Day, CDbl(Math.Round(tonelPendienteEntregarAlDiaZafra / moliendaDiaria, 5)), lDiaZafra.FECHA).ToString("dd/MM/yyyy")

            lblSaldoAjustado.Text = (tonelPendienteEntregarAlDiaZafra / moliendaDiariaAJUSTADO).ToString("#,##0.00")
            lblFechaFinAjustada.Text = DateAdd(DateInterval.Day, CDbl(Math.Round(tonelPendienteEntregarAlDiaZafra / moliendaDiariaAJUSTADO, 5)), lDiaZafra.FECHA).ToString("dd/MM/yyyy")
        End If
    End Sub

End Class