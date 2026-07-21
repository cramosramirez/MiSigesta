Partial Public Class cBANCOS
    Public Function ObtenerPorCATORCENA_PLANILLA_tipoCONTRIBUYENTE(ByVal ID_CATORCENA As Integer, _
                                                                  ByVal ID_TIPO_PLANILLA As Integer, _
                                                                  ByVal TIPO_CONTRIBUYENTE As Integer) As listaBANCOS
        Try
            Return mDb.ObtenerPorCATORCENA_PLANILLA_tipoCONTRIBUYENTE(ID_CATORCENA, ID_TIPO_PLANILLA, TIPO_CONTRIBUYENTE)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ObtenerListaConOIP() As listaBANCOS
        Try
            Return mDb.ObtenerListaConOIP
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ObtenerListaParaGeneracionPAGO_CTA(ByVal ID_CATORCENA As Integer,
                                                                  ByVal ID_TIPO_PLANILLA As Integer,
                                                                  ByVal TIPO_CONTRIBUYENTE As Integer) As listaBANCOS
        Try
            Return mDb.ObtenerListaParaGeneracionPAGO_CTA(ID_CATORCENA, ID_TIPO_PLANILLA, TIPO_CONTRIBUYENTE)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
