Partial Public Class cSOLIC_QUEMANOPROG

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCriterios(ByVal ID_ZAFRA As Int32, _
                                             ByVal ZONA As String, _
                                             ByVal CODIPROVEE As String, _
                                             ByVal CODISOCIO As String, _
                                             ByVal NOMBRE_PROVEEDOR As String, _
                                             ByVal NOMBLOTE As String) As listaSOLIC_QUEMANOPROG
        Try
            Return mDb.ObtenerListaPorCriterios(ID_ZAFRA, ZONA, CODIPROVEE, CODISOCIO, NOMBRE_PROVEEDOR, NOMBLOTE)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

End Class
