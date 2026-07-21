Partial Public Class cCARGADORA_ASIGNADA

    Public Function ObtenerCARGADORA_ASIGNADA(ByVal ID_ZAFRA As Int32, ByVal ID_CARGADORA As Int32, ByVal ID_CARGADOR As Int32) As CARGADORA_ASIGNADA
        Try
            Return mDb.ObtenerCARGADORA_ASIGNADA(ID_ZAFRA, ID_CARGADORA, ID_CARGADOR)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function


    Public Function ObtenerListaPorZAFRA_CARGADORA(ByVal ID_ZAFRA As Int32, ByVal ID_CARGADORA As Int32, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaCARGADORA_ASIGNADA
        Try
            Return mDb.ObtenerListaPorZAFRA_CARGADORA(ID_ZAFRA, ID_CARGADORA, asColumnaOrden, asTipoOrden)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

End Class
