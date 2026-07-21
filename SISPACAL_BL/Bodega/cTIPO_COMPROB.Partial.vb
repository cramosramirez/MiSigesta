Partial Public Class cTIPO_COMPROB

    Public Function ObtenerListaVerRegistro(Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaTIPO_COMPROB
        Try
            Return mDb.ObtenerListaVerRegistro(asColumnaOrden, asTipoOrden)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

End Class
