Imports SISPACAL.BL
Imports SISPACAL.EL

Public Class PlanCosechaEjecucionPorLote

    Public Sub CargarDatosProgramacionCatorcenal(ByVal TIPO As Int32, ByVal ID_ZAFRA As Int32, ByVal FECHA1 As DateTime, ByVal FECHA2 As DateTime, _
                           ByVal SEMANA As Int32, ByVal CATORCENA As Int32, ByVal CODIAGRON As String, ByVal EDAD_LOTE As Int32)
        Dim sFecha1 As String = ""
        Dim sFecha2 As String = ""
        Dim sCodiProvee As String = ""
        Dim sCodiSocio As String = ""

        If FECHA1 <> #12:00:00 AM# AndAlso FECHA2 <> #12:00:00 AM# Then
            sFecha1 = FECHA1.ToString("dd/MM/yyyy")
            sFecha2 = FECHA2.ToString("dd/MM/yyyy")
        End If

        Me.PlAN_COSECHA_EJECUCIONTableAdapter1.FillPorCriterios(DS_SIGESTA1.PLAN_COSECHA_EJECUCION, TIPO, ID_ZAFRA, -1, "", "", Now, "", _
                                                                    "", "", "", "", "", "", -1, sFecha1, sFecha2, "", SEMANA, CATORCENA, -1, CODIAGRON, EDAD_LOTE)


        Dim lCensos As listaCENSO = (New cCENSO).ObtenerListaPorZAFRA(ID_ZAFRA, False, False, "FECHA_CENSO", "DESC")
        Dim lDiasZafra As listaDIA_ZAFRA = (New cDIA_ZAFRA).ObtenerListaPorZAFRA(ID_ZAFRA, False, "FECHA", "DESC")
        Dim lDiaZafra As DIA_ZAFRA
        Dim bBascula As New cBASCULA

        txtTITULO.Text = "PROGRAMACION DE COSECHA CATORCENAL / SEMANAL POR LOTE"
        lblFechaReporte.Text = cFechaHora.ObtenerFecha.ToString("dd/MM/yyyy")

        If CATORCENA <> -1 Then Me.lblEsticana.Text = "CATORCENA: " + CATORCENA.ToString
        If SEMANA <> -1 Then Me.lblEsticana.Text += " SEMANA: " + SEMANA.ToString

        If lDiasZafra IsNot Nothing AndAlso lDiasZafra.Count > 0 Then
            lDiaZafra = lDiasZafra(0)
            Dim tonelEntregada As Decimal = bBascula.ObtenerTONEL_ENTREGADAPorZAFRA(ID_ZAFRA)
            Dim tonelPendienteEntregar As Decimal = bBascula.ObtenerTOTAL_TONEL_ENTREGARPorZAFRA(ID_ZAFRA)
            Dim tonelEntregadaAlDiaZafra As Decimal = bBascula.ObtenerTONEL_ENTREGADA_AL_DIAZAFRA(ID_ZAFRA, lDiaZafra.DIAZAFRA)
            Dim moliendaDiaria As Decimal = 0
            Dim tonelPendienteEntregarAlDiaZafra As Decimal = 0

            lblDiaZafra.Text = lDiaZafra.DIAZAFRA.ToString
            moliendaDiaria = Math.Round(tonelEntregadaAlDiaZafra / lDiaZafra.DIAZAFRA, 2)
            lblMolienda_a_laFecha.Text = moliendaDiaria.ToString("#,##0.00")
            tonelPendienteEntregarAlDiaZafra = (tonelEntregada - tonelEntregadaAlDiaZafra) + tonelPendienteEntregar
            lblMoliendaSaldo.Text = Math.Round(tonelPendienteEntregarAlDiaZafra / moliendaDiaria, 0).ToString("#,##0")
            lblFechaFinZafra.Text = DateAdd(DateInterval.Day, CDbl(Math.Round(tonelPendienteEntregarAlDiaZafra / moliendaDiaria, 0)), lDiaZafra.FECHA).ToString("dd/MM/yyyy")
        End If
    End Sub

    Public Sub CargarDatos(ByVal TIPO As Int32, ByVal ID_CENSO As Int32, ByVal FECHA1 As DateTime, ByVal FECHA2 As DateTime, _
                           ByVal ZONA As String, ByVal SUB_ZONA As String, _
                           ByVal CODI_DEPTO As String, ByVal CODI_MUNI As String, _
                           ByVal CODIPROVEE As String, ByVal CODISOCIO As String, ByVal CODIVARIEDAD As String, _
                           ByVal ID_TIPO_CANA As Int32, ByVal SEMANA As Int32, ByVal CATORCENA As Int32, _
                           ByVal NOMBRE_PROVEEDOR As String, ByVal ID_ZAFRA As Int32, _
                           ByVal ID_CICLO As Int32, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal ESTADO_LOTE As Int32, ByVal EDAD_LOTE As Int32)
        Dim sFecha1 As String = ""
        Dim sFecha2 As String = ""
        Dim sCodiProvee As String = ""
        Dim sCodiSocio As String = ""
        Dim sNombreProveedor As String = ""

        If FECHA1 <> #12:00:00 AM# AndAlso FECHA2 <> #12:00:00 AM# Then
            sFecha1 = FECHA1.ToString("dd/MM/yyyy")
            sFecha2 = FECHA2.ToString("dd/MM/yyyy")
        End If
        sNombreProveedor = NOMBRE_PROVEEDOR.ToUpper.Trim.Replace(" ", "%")

        Me.PlAN_COSECHA_EJECUCIONTableAdapter1.FillPorCriterios(DS_SIGESTA1.PLAN_COSECHA_EJECUCION, TIPO, ID_ZAFRA, ID_CENSO, "", USUARIO_CREA, FECHA_CREA, ZONA, _
                                                                    SUB_ZONA, CODI_DEPTO, CODI_MUNI, CODIPROVEE, CODISOCIO, CODIVARIEDAD, ID_TIPO_CANA, sFecha1, sFecha2, sNombreProveedor, SEMANA, CATORCENA, ESTADO_LOTE, "", EDAD_LOTE)

        Dim lCensos As listaCENSO = (New cCENSO).ObtenerListaPorZAFRA(ID_ZAFRA, False, False, "FECHA_CENSO", "DESC")
        Dim lDiasZafra As listaDIA_ZAFRA = (New cDIA_ZAFRA).ObtenerListaPorZAFRA(ID_ZAFRA, False, "FECHA", "DESC")
        Dim lCicloPeriodo As listaCICLO_PERIODO = (New cCICLO_PERIODO).ObtenerListaPorCICLO(ID_CICLO, False, "FECHA", "DESC")
        Dim lDiaZafra As DIA_ZAFRA
        Dim bBascula As New cBASCULA

        lblFechaReporte.Text = cFechaHora.ObtenerFecha.ToString("dd/MM/yyyy")

        If TIPO = 1 OrElse TIPO = 11 Then
            Me.lblEsticana.Text = "ESTICAÑA A LA FECHA " + Today.ToString("dd/MMM/yyyy").ToUpper
        Else
            If lCensos IsNot Nothing AndAlso lCensos.Count > 0 Then
                Me.lblEsticana.Text = "ESTICAÑA DETERMINADO AL " + lCensos(0).FECHA_CENSO.ToString("dd/MMM/yyyy").ToUpper
            End If
        End If

        
        If lDiasZafra IsNot Nothing AndAlso lDiasZafra.Count > 0 Then
            lDiaZafra = lDiasZafra(0)
            Dim tonelEntregada As Decimal = bBascula.ObtenerTONEL_ENTREGADAPorZAFRA(ID_ZAFRA)
            Dim tonelPendienteEntregar As Decimal = bBascula.ObtenerTOTAL_TONEL_ENTREGARPorZAFRA(ID_ZAFRA)
            Dim tonelEntregadaAlDiaZafra As Decimal = bBascula.ObtenerTONEL_ENTREGADA_AL_DIAZAFRA(ID_ZAFRA, lDiaZafra.DIAZAFRA)
            Dim moliendaDiaria As Decimal = 0
            Dim tonelPendienteEntregarAlDiaZafra As Decimal = 0

            lblDiaZafra.Text = lDiaZafra.DIAZAFRA.ToString
            moliendaDiaria = Math.Round(tonelEntregadaAlDiaZafra / lDiaZafra.DIAZAFRA, 2)
            lblMolienda_a_laFecha.Text = moliendaDiaria.ToString("#,##0.00")
            tonelPendienteEntregarAlDiaZafra = (tonelEntregada - tonelEntregadaAlDiaZafra) + tonelPendienteEntregar
            lblMoliendaSaldo.Text = Math.Round(tonelPendienteEntregarAlDiaZafra / moliendaDiaria, 0).ToString("#,##0")
            lblFechaFinZafra.Text = DateAdd(DateInterval.Day, CDbl(Math.Round(tonelPendienteEntregarAlDiaZafra / moliendaDiaria, 0)), lDiaZafra.FECHA).ToString("dd/MM/yyyy")
        End If
    End Sub
End Class