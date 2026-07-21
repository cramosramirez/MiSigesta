Imports SISPACAL.BL
Imports SISPACAL.EL
Public Class ResultadoAnalisisMuestras

    Public Sub CargarDatos(ByVal ID_ZAFRA As Int32, ByVal FECHA1 As DateTime, FECHA2 As DateTime, Optional ZONA As String = "")
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZAFRA(ID_ZAFRA)
        If Not IsNothing(lZafra) Then xrZAFRA.Text = "ZAFRA: " + lZafra.NOMBRE_ZAFRA
        Me.ResultadoS_ANALISIS_PRECOSECHATableAdapter1.FillPorFechas(DS_SIGESTA1.RESULTADOS_ANALISIS_PRECOSECHA, FECHA1, FECHA2, ID_ZAFRA, ZONA)
        If ZONA <> "" Then
            Dim lZona As ZONAS = (New cZONAS).ObtenerZONAS(ZONA)
            If lZona IsNot Nothing Then xrZONA.Text = "ZONA: " + lZona.DESCRIP_ZONA
        Else
            xrZONA.Text = ""
        End If
    End Sub
End Class