
Partial Public Class cORDEN_DETA_AGRI

    Public Function ObtenerCantidadEntregada(ByVal ID_ORDEN_DETA As Int32) As Decimal
        Try
            Return mDb.ObtenerCantidadEntregada(ID_ORDEN_DETA)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

End Class
