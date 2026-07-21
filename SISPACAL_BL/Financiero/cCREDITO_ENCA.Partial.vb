Partial Public Class cCREDITO_ENCA

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorUID_REFERENCIA(ByVal UID_REFERENCIA As Guid) As listaCREDITO_ENCA
        Try
            Return mDb.ObtenerListaPorUID_REFERENCIA(UID_REFERENCIA)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function PROC_Actualizar_Intereses_Productores(ByVal CODIPROVEEDOR As String, _
                                                          ByVal ID_CREDITO_ENCA As Int32) As Integer
        Try
            Return mDb.PROC_Actualizar_Intereses_Productores(CODIPROVEEDOR, ID_CREDITO_ENCA)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function fObtenerPlazoInteres(ByVal ID_CREDITO_ENCA As Int32, ByVal FECHA As DateTime) As Int32
        Try
            Return mDb.fObtenerPlazoInteres(ID_CREDITO_ENCA, FECHA)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return 0
        End Try
    End Function

End Class
