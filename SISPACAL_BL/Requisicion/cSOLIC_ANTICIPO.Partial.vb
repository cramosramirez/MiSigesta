Partial Public Class cSOLIC_ANTICIPO

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCriterios(ByVal ID_ZAFRA As Int32, _
                                             ByVal NUM_ANTICIPO As Int32, _
                                             ByVal CODIPROVEE As String, _
                                             ByVal CODISOCIO As String, _
                                             ByVal NOMBRE_PROVEEDOR As String, _
                                             ByVal NOMBLOTE As String, _
                                             ByVal FECHA As DateTime) As listaSOLIC_ANTICIPO
        Try

            Return mDb.ObtenerListaPorCriterios(ID_ZAFRA, NUM_ANTICIPO, CODIPROVEE, CODISOCIO, NOMBRE_PROVEEDOR, FECHA)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

End Class
