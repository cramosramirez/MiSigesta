Imports SISPACAL.BL
Imports SISPACAL.EL

Public Class rptSigestaEjec004_Zafra


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
        Me.RpT_SIGESTA_EJEC004_PLAN_COSECHATableAdapter1.FillPorZafra(DS_SIGESTA1.RPT_SIGESTA_EJEC004_PLAN_COSECHA, TIPO, ID_ZAFRA, USUARIO_CREA, FECHA_CREA, ZONA, _
                                                                    SUB_ZONA, CODI_DEPTO, CODI_MUNI, CODIPROVEE, CODISOCIO, CODIVARIEDAD, ID_TIPO_CANA, sFecha1, sFecha2, sNombreProveedor, SEMANA, CATORCENA)


        Dim lCensos As listaCENSO = (New cCENSO).ObtenerListaPorZAFRA(ID_ZAFRA, False, False, "FECHA_CENSO", "DESC")
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZAFRA(ID_ZAFRA)
        Dim lDiasZafra As listaDIA_ZAFRA = (New cDIA_ZAFRA).ObtenerListaPorZAFRA(ID_ZAFRA, False, "FECHA", "DESC")
        Dim lCatorcenas As listaCATORCENA_ZAFRA = (New cCATORCENA_ZAFRA).ObtenerListaPorZAFRA(ID_ZAFRA, False, False, "CATORCENA", "DESC")

        If lZafra IsNot Nothing Then
            lblZafra.Text = "ZAFRA " + lZafra.NOMBRE_ZAFRA
        End If
        If lCensos IsNot Nothing AndAlso lCensos.Count > 0 Then
            Me.txtTITULO.Text = "SEGÚN ESTICAÑA DETERMINADO AL " + lCensos(0).FECHA_CENSO.ToString("dd/MMM/yyyy").ToUpper
        End If

        If lDiasZafra IsNot Nothing AndAlso lDiasZafra.Count > 0 Then
            lblDiaZafra.Text = lDiasZafra(0).DIAZAFRA.ToString
        End If
        If lCatorcenas IsNot Nothing AndAlso lCatorcenas.Count > 0 Then
            lblUltimaCatorcena.Text = lCatorcenas(0).CATORCENA.ToString
        End If
    End Sub

End Class