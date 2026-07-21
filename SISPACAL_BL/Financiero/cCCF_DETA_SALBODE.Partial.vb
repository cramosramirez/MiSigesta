Partial Public Class cCCF_DETA_SALBODE

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPendienteFacturar(ByVal CODIPROVEEDOR As String, ByVal ID_PROVEE As Int32) As listaCCF_DETA_SALBODE
        Try
            Return mDb.ObtenerListaPendienteFacturar(CODIPROVEEDOR, ID_PROVEE)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function


End Class
