Partial Public Class dbANALISIS
    ' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que recupera una lista de entidades ANALISIS filtrada por Zafra y Boleta.
    ''' </summary>
    ''' <history>
    ''' 	[cramos]	02/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorBOLETA(ByVal pID_ZAFRA As Integer, ByVal pNROBOLETA As Integer) As listaANALISIS
        Dim lCriterios As New List(Of Criteria)
        Dim lista As listaENVIO
        Dim lEnvio As New ENVIO
        Dim listaAnalisis As listaANALISIS

        lCriterios.Add(New Criteria("ID_ZAFRA", "=", pID_ZAFRA, "AND"))
        lCriterios.Add(New Criteria("NROBOLETA", "=", pNROBOLETA, "AND"))
        lEnvio.ID_ZAFRA = pID_ZAFRA
        lEnvio.NROBOLETA = pNROBOLETA
        lista = Me.ObtenerListaPorBusqueda(lEnvio, lCriterios.ToArray)
        If lista IsNot Nothing AndAlso lista.Count > 0 Then
            listaAnalisis = (New dbANALISIS).ObtenerListaPorENVIO(lista(0).ID_ENVIO)
            Return listaAnalisis
        Else
            Return Nothing
        End If
    End Function
End Class
