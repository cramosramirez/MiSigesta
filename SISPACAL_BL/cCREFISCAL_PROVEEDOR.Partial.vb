Partial Public Class cCREFISCAL_PROVEEDOR

    Public Function ObtenerDatosUltimoCCF(ByVal CODIGO As String, ByVal ID_TIPO_PROVEEDOR As Integer) As DataSet
        Try
            Return mDb.ObtenerDatosUltimoCCF(CODIGO, ID_TIPO_PROVEEDOR)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
