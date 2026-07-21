Partial Public Class cSOLIC_ANTICIPO_LOTE

    Public Function ObtenerListaPorZAFRA_CONTRATADA_PROVEEDOR_CONTRATADO(ByVal ID_ZAFRA As Int32, ByVal CODIPROVEEDOR As String) As listaSOLIC_ANTICIPO_LOTE
        Try
            Return mDb.ObtenerListaPorZAFRA_CONTRATADA_PROVEEDOR_CONTRATADO(ID_ZAFRA, CODIPROVEEDOR)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try

    End Function
End Class
