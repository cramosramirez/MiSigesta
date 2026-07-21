Public Class ControlRequisiciones

    Public Sub CargaDatos(ByVal CODI_REQ As String, ID_PERIODOREQ As Int32, ID_SECCION As Int32, _
                          ID_SOLICITANTE As Int32, ByVal FECHA_EMISION_INI As DateTime, ByVal FECHA_EMISION_FIN As DateTime, _
                          ETAPA As String)

        Dim sFecha1 As String = ""
        Dim sFecha2 As String = ""
        If FECHA_EMISION_INI <> #12:00:00 AM# AndAlso FECHA_EMISION_FIN <> #12:00:00 AM# Then
            sFecha1 = FECHA_EMISION_INI.ToString("dd/MM/yyyy")
            sFecha2 = FECHA_EMISION_FIN.ToString("dd/MM/yyyy")
        End If
        Me.RPT_REQUISICIONESTableAdapter1.FillPorCriterios(DS_SIGESTA1.RPT_REQUISICIONES, _
                            CODI_REQ, ID_PERIODOREQ, ID_SECCION, ID_SOLICITANTE, sFecha1, sFecha2, ETAPA)
    End Sub

End Class