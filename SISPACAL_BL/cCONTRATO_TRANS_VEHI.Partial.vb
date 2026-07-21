Partial Public Class cCONTRATO_TRANS_VEHI


    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCriterios(ByVal ID_ZAFRA As Int32, ByVal ID_CONTRA_TRANS As Int32, ByVal ID_TRANSPORTE As Int32, _
                                            ByVal CODTRANSPORT As Int32) As listaCONTRATO_TRANS_VEHI
        Try

            Return mDb.ObtenerListaPorCriterios(ID_ZAFRA, ID_CONTRA_TRANS, ID_TRANSPORTE, CODTRANSPORT)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

End Class
