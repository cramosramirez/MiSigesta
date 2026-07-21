Partial Public Class cDESCUENTOS_PLANILLA

    Public Function EliminarPorCatorcenaPlanilla(ByVal ID_CATORCENA As Integer, ByVal ID_TIPO_PLANILLA As Integer) As Integer
        Try
            Return mDb.EliminarPorCatorcenaPlanilla(ID_CATORCENA, ID_TIPO_PLANILLA)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    Public Function ObtenerListaPorCATORCENA_ZAFRA_TIPO_PLANILLA(ByVal ID_CATORCENA As Integer, ByVal ID_TIPO_PLANILLA As Integer) As listaDESCUENTOS_PLANILLA
        Try
            Return mDb.ObtenerListaPorCATORCENA_ZAFRA_TIPO_PLANILLA(ID_CATORCENA, ID_TIPO_PLANILLA)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
