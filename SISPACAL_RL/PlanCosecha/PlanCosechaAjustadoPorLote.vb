Imports SISPACAL.BL
Imports SISPACAL.EL

Public Class PlanCosechaAjustadoPorLote

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

        If ID_CENSO <> -1 Then
            Dim lCenso As CENSO = (New cCENSO).ObtenerCENSO(ID_CENSO)
            Dim lDiasZafra As listaDIA_ZAFRA = (New cDIA_ZAFRA).ObtenerListaPorZAFRA(ID_ZAFRA)
            Dim lCicloPeriodo As listaCICLO_PERIODO = (New cCICLO_PERIODO).ObtenerListaPorCICLO(ID_CICLO, False, "FECHA", "ASC")
            Dim acumDias As Decimal = 0
            Dim saldoDias As Decimal = 0

            If lCenso IsNot Nothing Then Me.lblEsticana.Text = lCenso.NOMBRE_CENSO + " AL " + lCenso.FECHA_CENSO.ToString("dd/MMM/yyyy").ToUpper
        End If
    End Sub
End Class