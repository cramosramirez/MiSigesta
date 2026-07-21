Imports SISPACAL.BL
Imports SISPACAL.EL

Public Class AnalisisVMTcompleto

    Public Sub CargarDatos(ID_ZAFRA As Int32, ES_TM As Boolean, VER_TIPO_QUEMA As Boolean, _
                           CATORCENA As Int32, ACUMULADO As Boolean, FECHA_INI As String, FECHA_FIN As String)
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZAFRA(ID_ZAFRA)

        If lZafra IsNot Nothing Then xrZafra.Text = "ZAFRA " + lZafra.NOMBRE_ZAFRA

        xrUnidadMedida.Text = If(ES_TM, "TONELADAS METRICAS - TM", "TONELADAS CORTAS - TC")
        xrTC15.Text = If(ES_TM, "15% TM", "15% TC")
        xrTC.Text = If(ES_TM, "TM", "TC")
        xrTC_SOBREPESO.Text = If(ES_TM, "SOBREPESO TM", "SOBREPESO TC")
        xrPesoBruto.Text = If(ES_TM, "PESO BRUTO TM", "PESO BRUTO TC")
        xrTC_PESO_NETO.Text = If(ES_TM, "PESO NETO TM", "PESO NETO TC")
        xrTC_RANGO.Text = If(ES_TM, "VIAJES POR RANGOS SOBREPESO TM", "VIAJES POR RANGOS SOBREPESO TC")
        xrNivelReporte.Text = "COMPLETO"

        If CATORCENA <> -1 Then
            xrPeriodo.Text = "CORTE #" + CATORCENA.ToString
        ElseIf ACUMULADO Then
            xrPeriodo.Text = "ACUMULADO A LA FECHA"
        ElseIf CDate(FECHA_INI) <> #12:00:00 AM# Then
            xrPeriodo.Text = "DEL " + FECHA_INI + " AL " + FECHA_FIN
        End If

        Me.DS_SIGESTA1.Clear()
        Me.AnalisiS_VMTTableAdapter1.SetCommandTimeOut(9000000)
        Me.AnalisiS_VMTTableAdapter1.FillPorCriterios(Me.DS_SIGESTA1.ANALISIS_VMT, _
                                                    ID_ZAFRA, ES_TM, VER_TIPO_QUEMA, CATORCENA, ACUMULADO, FECHA_INI, FECHA_FIN)
        Me.DisplayName = "ANALISIS CUMPLIMIENTO RESOLUCION PESOS VMT"
    End Sub
End Class