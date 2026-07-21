Partial Public Class cPROVEEDOR_QUERQUEO

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerListaPorCODISIS(ByVal CODISIS As String, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaPROVEEDOR_QUERQUEO
        Try

            Return mDb.ObtenerListaPorCODISIS(CODISIS, asColumnaOrden, asTipoOrden)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerListaPorREPORTE_QUERQUEO_INJIBOA_RELA(ByVal ID_ZAFRA As Int32, ByVal CODIPROVEEDOR As String, ByVal CATORCENA As Int32, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaPROVEEDOR_QUERQUEO
        Try
            Return mDb.ObtenerListaPorREPORTE_QUERQUEO_INJIBOA_RELA(ID_ZAFRA, CODIPROVEEDOR, CATORCENA, asColumnaOrden, asTipoOrden)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerListaCombo() As listaPROVEEDOR_QUERQUEO
        Try
            Return mDb.ObtenerListaCombo()
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

End Class
