Partial Public Class cCONTRATO_FINAN

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerPorZAFRA_CONTRATO(ByVal ID_ZAFRA As Int32, ByVal CODICONTRATO As String) As CONTRATO_FINAN
        Try
            Return mDb.ObtenerPorZAFRA_CONTRATO(ID_ZAFRA, CODICONTRATO)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorZAFRA_PROVEEDOR(ByVal ID_ZAFRA As Int32, ByVal CODIPROVEEDOR As String) As listaCONTRATO_FINAN
        Try
            Return mDb.ObtenerListaPorZAFRA_PROVEEDOR(ID_ZAFRA, CODIPROVEEDOR)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCriterios(ByVal ID_ZAFRA As Int32, ByVal CODIPROVEEDOR As String, ByVal NOMBRE_PROVEEDOR As String) As listaCONTRATO_FINAN
        Try
            Return mDb.ObtenerListaPorCriterios(ID_ZAFRA, CODIPROVEEDOR, NOMBRE_PROVEEDOR)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
