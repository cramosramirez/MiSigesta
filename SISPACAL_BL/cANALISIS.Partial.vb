Partial Public Class cANALISIS
    ' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que recupera una lista de entidades ANALISIS filtrada por el Número de Boleta.
    ''' </summary>
    ''' <history>
    ''' 	[cramos]	02/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorBOLETA(ByVal pID_ZAFRA As Integer, ByVal pNROBOLETA As Integer) As listaANALISIS
        Try
            Return mDb.ObtenerListaPorBOLETA(pID_ZAFRA, pNROBOLETA)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
