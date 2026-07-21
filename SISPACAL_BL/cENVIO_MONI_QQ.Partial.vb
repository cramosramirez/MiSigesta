Partial Public Class cENVIO_MONI_QQ

    Public Function SP_SERVICIO_MONITOR_QUERQUEO(ByVal OPCION As String,
                                                ByVal CODIPROVEEDOR As String,
                                                ByVal ID_ENVIO As Integer,
                                                ByVal ID_MONITOR As Integer,
                                                ByVal ID_PROVEE_QQ As Integer) As List(Of Dictionary(Of Integer, String))
        Try
            Return mDb.SP_SERVICIO_MONITOR_QUERQUEO(OPCION, CODIPROVEEDOR, ID_ENVIO, ID_MONITOR, ID_PROVEE_QQ)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
