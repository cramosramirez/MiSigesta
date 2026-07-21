Partial Public Class cTRANSPORTE
    Public Function ObtenerTRANSPORTEPorTRANSPORTISTA_PLACA(ByVal CODTRANSPORT As Int32, ByVal PLACA As String) As TRANSPORTE
        Try
            Return mDb.ObtenerTRANSPORTEPorTRANSPORTISTA_PLACA(CODTRANSPORT, PLACA)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
