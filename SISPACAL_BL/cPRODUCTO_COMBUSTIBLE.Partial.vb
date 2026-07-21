Partial Public Class cPRODUCTO_COMBUSTIBLE
    Public Function ObtenerPorNOMBRE_PRODUCTO(ByVal NOMBRE_PRODUCTO As String) As PRODUCTO_COMBUSTIBLE
        Try
            Return mDb.ObtenerPorNOMBRE_PRODUCTO(NOMBRE_PRODUCTO)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
