Partial Public Class cCICLO_PERIODO
    Public Function ObtenerCICLO_PERIODOPorFechaTipo(ByVal FECHA As Date, ByVal TIPO_CICLO As Int32) As CICLO_PERIODO
        Try
            Return mDb.ObtenerCICLO_PERIODOPorFechaTipo(FECHA, TIPO_CICLO)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function


    Public Function ObtenerCatorcenasPorZAFRA_TIPO_CICLO(ByVal ID_ZAFRA As Int32, ByVal TIPO_CICLO As Int32) As List(Of Int32)
        Try
            Return mDb.ObtenerCatorcenasPorZAFRA_TIPO_CICLO(ID_ZAFRA, TIPO_CICLO)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ObtenerSemanasPorZAFRA_TIPO_CICLO_CATORCENA(ByVal ID_ZAFRA As Int32, ByVal TIPO_CICLO As Int32, ByVal CATORCENA As Int32) As List(Of Int32)
        Try
            Return mDb.ObtenerSemanasPorZAFRA_TIPO_CICLO_CATORCENA(ID_ZAFRA, TIPO_CICLO, CATORCENA)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function


    Public Function ObtenerFechaInicialFinalCatorcena(ByVal ID_ZAFRA As Int32, ByVal TIPO_CICLO As Int32, ByVal CATORCENA As Int32) As List(Of DateTime)
        Try
            Return mDb.ObtenerFechaInicialFinalCatorcena(ID_ZAFRA, TIPO_CICLO, CATORCENA)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ObtenerListaPorCriterios(ByVal ID_ZAFRA As Int32, _
                                             ByVal TIPO_CICLO As Int32, _
                                             ByVal CATORCENA As Int32, _
                                             ByVal SEMANA As Int32, _
                                             ByVal FECHA As DateTime, _
                                             Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaCICLO_PERIODO
        Try
            Return mDb.ObtenerListaPorCriterios(ID_ZAFRA, TIPO_CICLO, CATORCENA, SEMANA, FECHA, asColumnaOrden, asTipoOrden)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
