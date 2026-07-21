Partial Public Class cFILTRO_ORDEN_ROZA
    Public Function EliminarFiltroPorUsuarioFecha(ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime) As Integer
        Try
            Return mDb.EliminarFiltroPorUsuarioFecha(USUARIO_CREA, FECHA_CREA)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    Public Function ObtenerListaPorUsuarioFecha(ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime) As listaFILTRO_ORDEN_ROZA
        Try
            Return mDb.ObtenerListaPorUsuarioFecha(USUARIO_CREA, FECHA_CREA)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
