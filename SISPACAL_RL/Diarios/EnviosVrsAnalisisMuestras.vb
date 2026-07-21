Imports SISPACAL.BL
Imports SISPACAL.EL
Imports System.Text

Public Class EnviosVrsAnalisisMuestras

    Public Sub CargarDatos(ByVal OPCION As Int32, ByVal ID_ZAFRA As Int32, ByVal FECHA_CORTE As Object, _
                           ByVal FECHA1 As Object, ByVal FECHA2 As Object, ByVal NROBOLETA As Int32, _
                           ByVal NOMBRE_PROVEEDOR As String)
        Dim sACCESLOTE As String = ""
        Dim sCAD As New StringBuilder
        Dim sNOMBRE_PROVEEDOR = NOMBRE_PROVEEDOR
        Dim sFECHA1 As String = ""
        Dim sFECHA2 As String = ""

        sNOMBRE_PROVEEDOR = sNOMBRE_PROVEEDOR.ToUpper.Trim.Replace(" ", "%")
        If NROBOLETA <> -1 Then
            Dim lEnvios As listaENVIO = (New cENVIO).ObtenerListaPorBOLETA(ID_ZAFRA, NROBOLETA)
            If lEnvios IsNot Nothing AndAlso lEnvios.Count > 0 Then
                sACCESLOTE = lEnvios(0).ACCESLOTE
            End If
        End If

        If OPCION = 1 Then
            ANALISIS_MUESTRAS_ENVIOTableAdapter1.FillPorCriterios(DS_SIGESTA1.ANALISIS_MUESTRAS_ENVIO, OPCION, ID_ZAFRA, CDate(FECHA_CORTE), "", "", sACCESLOTE, "")
        ElseIf OPCION = 2 Then
            If FECHA1 = #12:00:00 AM# Then sFECHA1 = "" Else sFECHA1 = CDate(FECHA1).ToString("dd/MM/yyyy HH:mm")
            If FECHA2 = #12:00:00 AM# Then sFECHA2 = "" Else sFECHA2 = CDate(FECHA2).ToString("dd/MM/yyyy HH:mm")

            ANALISIS_MUESTRAS_ENVIOTableAdapter1.FillPorCriterios(DS_SIGESTA1.ANALISIS_MUESTRAS_ENVIO, OPCION, ID_ZAFRA, cFechaHora.ObtenerFecha, sFECHA1, sFECHA2, sACCESLOTE, NOMBRE_PROVEEDOR)
        End If

        If FECHA_CORTE <> #12:00:00 AM# Then
            Dim lDiaZafra As DIA_ZAFRA = (New cDIA_ZAFRA).ObtenerPorFECHA(FECHA_CORTE)
            If lDiaZafra IsNot Nothing Then
                sCAD.AppendLine("DIA ZAFRA: " + lDiaZafra.DIAZAFRA.ToString)
            ElseIf DS_SIGESTA1.ANALISIS_MUESTRAS_ENVIO.Rows.Count > 0 Then
                Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZAFRA(ID_ZAFRA)
                sCAD.AppendLine("DIA ZAFRA: " + lZafra.DIAZAFRA.ToString)
            End If
            sCAD.AppendLine("FECHA DE CORTE " + CDate(FECHA_CORTE).ToString("dd/MM/yyyy"))
        End If
        If FECHA1 <> #12:00:00 AM# Then
            sCAD.AppendLine("PERIODO DEL " + sFECHA1 + " AL " + sFECHA2)
        End If
        If NROBOLETA <> -1 Then
            sCAD.AppendLine("TACO: " + NROBOLETA.ToString)
        End If
        If NOMBRE_PROVEEDOR <> "" Then
            sCAD.AppendLine("PROVEEDOR: " + NOMBRE_PROVEEDOR.Trim.ToUpper)
        End If
        lblCriterios.Text = sCAD.ToString

        Dim iZafra As ZAFRA = (New cZAFRA).ObtenerZAFRA(ID_ZAFRA)
        If iZafra IsNot Nothing Then
            Me.DisplayName = "INFORMACION LOTE - ANALISIS MUESTRAS ENVIOS ZAFRA " + Replace(iZafra.NOMBRE_ZAFRA, "/", "-")
        End If

    End Sub

End Class