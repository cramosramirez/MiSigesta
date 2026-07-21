Partial Public Class cPROVEEDOR_ROZA

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerListaPorTIPO_ROZA(ByVal ID_TIPO_ROZA As Int32, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaPROVEEDOR_ROZA
        Try
            Return mDb.ObtenerListaPorTIPO_ROZA(ID_TIPO_ROZA, asColumnaOrden, asTipoOrden)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerListaPorPROFORMA_CONTROL_ROZA_SALDO(ByVal ID_PROFORMA As Int32, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaPROVEEDOR_ROZA
        Try
            Return mDb.ObtenerListaPorPROFORMA_CONTROL_ROZA_SALDO(ID_PROFORMA, asColumnaOrden, asTipoOrden)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerListaPorREPORTE_ROZA_INJIBOA_RELA(ByVal ID_ZAFRA As Int32, ByVal CODIPROVEEDOR As String, ByVal CATORCENA As Int32, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaPROVEEDOR_ROZA
        Try
            Return mDb.ObtenerListaPorREPORTE_ROZA_INJIBOA_RELA(ID_ZAFRA, CODIPROVEEDOR, CATORCENA, asColumnaOrden, asTipoOrden)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)>
    Public Function ObtenerPorCODIGO(ByVal CODIGO As String) As PROVEEDOR_ROZA
        Try
            Return mDb.ObtenerPorCODIGO(CODIGO)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

End Class
