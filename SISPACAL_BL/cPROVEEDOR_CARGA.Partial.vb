Partial Public Class cPROVEEDOR_CARGA
    Public Shared Function EsIngenio(ByVal ID_PROVEEDOR_CARGA As Integer) As Boolean
        Try
            Dim lEntidad As PROVEEDOR_CARGA
            lEntidad = (New cPROVEEDOR_CARGA).ObtenerPROVEEDOR_CARGA(ID_PROVEEDOR_CARGA)
            If lEntidad IsNot Nothing Then
                Return lEntidad.ES_INGENIO
            Else
                Return False
            End If

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return False
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerListaPorZAFRA(ByVal ID_ZAFRA As Int32, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaPROVEEDOR_CARGA
        Try
            Return mDb.ObtenerListaPorZAFRA(ID_ZAFRA, asColumnaOrden, asTipoOrden)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
