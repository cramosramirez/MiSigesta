Partial Public Class cORDEN_COMBUSTIBLE_PROD

    Public Function EliminarPorORDEN_COMBUSTIBLE(ByVal ID_ORDEN_COMBUS As Integer) As Integer
        Try
            Return mDb.EliminarPorORDEN_COMBUSTIBLE(ID_ORDEN_COMBUS)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

End Class
