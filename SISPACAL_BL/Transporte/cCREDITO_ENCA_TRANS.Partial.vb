Partial Public Class cCREDITO_ENCA_TRANS

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorUID_REFERENCIA(ByVal UID_REFERENCIA As Guid) As listaCREDITO_ENCA_TRANS
        Try
            Return mDb.ObtenerListaPorUID_REFERENCIA(UID_REFERENCIA)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

End Class
