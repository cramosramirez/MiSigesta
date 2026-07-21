Partial Public Class cCHEQUE_PLANILLA
    Public Function ObtenerListaPorCATORCENA_TIPO_PLANILLA(ByVal ID_CATORCENA As Integer, ByVal ID_TIPO_PLANILLA As Int32, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaCHEQUE_PLANILLA
        Try
            Return mDb.ObtenerListaPorCATORCENA_TIPO_PLANILLA(ID_CATORCENA, ID_TIPO_PLANILLA, asColumnaOrden, asTipoOrden)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ObtenerListaPorCATORCENA_TIPO_PLANILLA(ByVal ID_CATORCENA As Integer, ByVal ID_TIPO_PLANILLA As Int32, ByVal ID_RANGO_COMPE As Int32, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaCHEQUE_PLANILLA
        Try
            Return mDb.ObtenerListaPorCATORCENA_TIPO_PLANILLA(ID_CATORCENA, ID_TIPO_PLANILLA, ID_RANGO_COMPE, asColumnaOrden, asTipoOrden)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
