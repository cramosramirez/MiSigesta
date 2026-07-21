Partial Public Class cSOLIC_APLICACION_VUELO

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorUID_REF(ByVal UID_REFERENCIA As Guid) As listaSOLIC_APLICACION_VUELO
        Try
            Return mDb.ObtenerListaPorUID_REF(UID_REFERENCIA)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
