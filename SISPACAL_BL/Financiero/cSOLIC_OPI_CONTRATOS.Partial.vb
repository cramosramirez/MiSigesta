Partial Public Class cSOLIC_OPI_CONTRATOS

    Public Function EliminarPorSOLIC_OPI_CONTRATO(ByVal ID_OPI As Int32, ByVal CODICONTRATO As String) As Integer
        Try
            Return mDb.EliminarPorSOLIC_OPI_CONTRATO(ID_OPI, CODICONTRATO)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

End Class
