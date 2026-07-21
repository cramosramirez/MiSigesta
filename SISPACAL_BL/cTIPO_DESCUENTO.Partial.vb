Partial Public Class cTIPO_DESCUENTO
    Public Function ObtenerPorNOMBRE_TIPO_DESCTO(ByVal NOMBRE_TIPO_DESCTO As String) As TIPO_DESCUENTO
        Try
            Return mDb.ObtenerPorNOMBRE_TIPO_DESCTO(NOMBRE_TIPO_DESCTO)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
