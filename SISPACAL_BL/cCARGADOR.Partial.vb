Partial Public Class cCARGADOR
    Public Function ObtenerListaPorCARGADORA(ByVal ID_CARGADORA As Integer) As listaCARGADOR
        Try
            Return mDb.ObtenerListaPorCARGADORA(ID_CARGADORA)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ObtenerListaPorTIPO_CARGADORA(ByVal idTipoAlza As Integer) As listaCARGADOR
        Try
            Return mDb.ObtenerListaPorTIPO_CARGADORA(idTipoAlza)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ObtenerListaPorTRACTOR() As listaCARGADOR
        Try
            Return mDb.ObtenerListaPorTRACTOR()
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
