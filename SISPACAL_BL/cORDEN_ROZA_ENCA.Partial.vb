Partial Public Class cORDEN_ROZA_ENCA

    Public Function ObtenerProximoID_GENERACION() As Object
        Try
            Return mDb.ObtenerProximoID_GENERACION
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ObtenerProximoCORRELATIVO() As Object
        Try
            Return mDb.ObtenerProximoCORRELATIVO
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
