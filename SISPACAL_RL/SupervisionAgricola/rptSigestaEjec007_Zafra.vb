Imports SISPACAL.BL
Imports SISPACAL.EL

Public Class rptSigestaEjec007_Zafra
    Dim ftoDecimal As String = "#,###,##0.00"
    Dim ftoPorc As String = "0.00%"

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


        Me.RPT_SIGESTA_EJEC007_PLAN_COSECHATableAdapter1.FillPorCriterios(DS_SIGESTA1.RPT_SIGESTA_EJEC007_PLAN_COSECHA, TIPO, ID_ZAFRA, USUARIO_CREA, FECHA_CREA, ZONA, _
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

        Dim lEjecucionAlza As Dictionary(Of String, Dictionary(Of String, Decimal)) = (New cLOTES_COSECHA).ObtenerEJECUCION_ALZA(ID_ZAFRA)

        If lEjecucionAlza IsNot Nothing AndAlso lEjecucionAlza.Count > 0 Then
            ' Obteniendo totales
            Dim lTC_TOTAL As Decimal = 0
            Dim lLBS_85_TOTAL As Decimal = 0
            Dim lLBS_REAL_TOTAL As Decimal = 0

            Dim lTC As Decimal = 0
            Dim lLBS_85 As Decimal = 0
            Dim lLBS_REAL As Decimal = 0

            For Each p1 As Dictionary(Of String, Decimal) In lEjecucionAlza.Values
                For Each p2 As String In p1.Keys
                    If p2 = "TC" Then
                        lTC_TOTAL += p1("TC")
                    ElseIf p2 = "LBS_85" Then
                        lLBS_85_TOTAL += p1("LBS_85")
                    ElseIf p2 = "LBS_REAL" Then
                        lLBS_REAL_TOTAL += p1("LBS_REAL")
                    End If
                Next
            Next
            xrEjecTC.Text = lTC_TOTAL.ToString(ftoDecimal)
            If lTC_TOTAL > 0 Then
                xrEjecPorcTC.Text = (1).ToString(ftoPorc)
                xrEjecREND_85.Text = (lLBS_85_TOTAL / lTC_TOTAL).ToString(ftoDecimal)
                xrEjecREND_REAL.Text = (lLBS_REAL_TOTAL / lTC_TOTAL).ToString(ftoDecimal)
                'xrEjecEFICIENCIA.Text = ((lLBS_85_TOTAL / lTC_TOTAL) / (lLBS_REAL_TOTAL / lTC_TOTAL)).ToString(ftoPorc)
                xrEjecLBS.Text = (lLBS_REAL_TOTAL).ToString(ftoDecimal)
                xrEjecPorcLBS.Text = (1).ToString(ftoPorc)
            End If


            If lEjecucionAlza.ContainsKey("COSECHADORA") Then
                lTC = lEjecucionAlza("COSECHADORA")("TC")
                lLBS_85 = lEjecucionAlza("COSECHADORA")("LBS_85")
                lLBS_REAL = lEjecucionAlza("COSECHADORA")("LBS_REAL")
                If lTC > 0 Then
                    xrCosechaTC.Text = (lTC).ToString(ftoDecimal)
                    xrCosechaPorcTC.Text = (lTC / lTC_TOTAL).ToString(ftoPorc)
                    xrCosechaREND_85.Text = (lLBS_85 / lTC).ToString(ftoDecimal)
                    xrCosechaREND_REAL.Text = (lLBS_REAL / lTC).ToString(ftoDecimal)
                    'xrCosechaEFICIENCIA.Text = ((lLBS_85 / lTC) / (lLBS_REAL / lTC)).ToString(ftoPorc)
                    xrCosechaLBS.Text = (lLBS_REAL).ToString(ftoDecimal)
                    xrCosechaPorcLBS.Text = (lLBS_REAL / lLBS_REAL_TOTAL).ToString(ftoPorc)
                End If
            End If

            lTC = 0
            lLBS_85 = 0
            lLBS_REAL = 0
            If lEjecucionAlza.ContainsKey("MANUAL") Then
                lTC += lEjecucionAlza("MANUAL")("TC")
                lLBS_85 += lEjecucionAlza("MANUAL")("LBS_85")
                lLBS_REAL += lEjecucionAlza("MANUAL")("LBS_REAL")
            End If
            If lEjecucionAlza.ContainsKey("CARGADORA") Then
                lTC += lEjecucionAlza("CARGADORA")("TC")
                lLBS_85 += lEjecucionAlza("CARGADORA")("LBS_85")
                lLBS_REAL += lEjecucionAlza("CARGADORA")("LBS_REAL")
            End If

            If lTC > 0 Then
                xrCargaManualTC.Text = (lTC).ToString(ftoDecimal)
                xrCargaManualPorcTC.Text = (lTC / lTC_TOTAL).ToString(ftoPorc)
                xrCargaManualREND_85.Text = (lLBS_85 / lTC).ToString(ftoDecimal)
                xrCargaManualREND_REAL.Text = (lLBS_REAL / lTC).ToString(ftoDecimal)
                'xrCargaManualEFICIENCIA.Text = ((lLBS_85 / lTC) / (lLBS_REAL / lTC)).ToString(ftoPorc)
                xrCargaManualLBS.Text = (lLBS_REAL).ToString(ftoDecimal)
                xrCargaManualPorcLBS.Text = (lLBS_REAL / lLBS_REAL_TOTAL).ToString(ftoPorc)
            End If
        End If
    End Sub
End Class