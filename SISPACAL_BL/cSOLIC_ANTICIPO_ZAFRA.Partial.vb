Partial Public Class cSOLIC_ANTICIPO_ZAFRA

    Public Function ObtenerPorZafraAnticipo(ByVal ID_ZAFRA As Int32, ID_ANTICIPO As Int32) As SOLIC_ANTICIPO_ZAFRA
        Try
            Return mDb.ObtenerPorZafraAnticipo(ID_ZAFRA, ID_ANTICIPO)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

End Class
