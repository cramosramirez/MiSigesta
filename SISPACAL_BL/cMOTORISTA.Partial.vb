Partial Public Class cMOTORISTA
    Public Function ObtenerListaPorTRANSPORTE(ByVal ID_TRANSPORTE As Int32) As listaMOTORISTA
        Try
            Return mDb.ObtenerListaPorTRANSPORTE(ID_TRANSPORTE)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ObtenerListaPorNOMBRES_APELLIDOS(ByVal NOMBRES_APELLIDOS As String) As MOTORISTA
        Try
            Return mDb.ObtenerListaPorNOMBRES_APELLIDOS(NOMBRES_APELLIDOS)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ObtenerListaActivos() As listaMOTORISTA
        Try
            Return mDb.ObtenerListaActivos()
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
