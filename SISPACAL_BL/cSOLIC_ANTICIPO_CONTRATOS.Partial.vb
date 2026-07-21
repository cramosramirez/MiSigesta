Partial Public Class cSOLIC_ANTICIPO_CONTRATOS

    Public Function EliminarPorSOLIC_ANTICIPO_CONTRATO(ByVal ID_ANTICIPO As Int32, ByVal CODICONTRATO As String) As Integer
        Try
            Return mDb.EliminarPorSOLIC_ANTICIPO_CONTRATO(ID_ANTICIPO, CODICONTRATO)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function
End Class
