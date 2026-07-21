Partial Public Class cPRODUCTO_TIPO_TRANS


    Public Function ObtenerPorTRANSPORTE(ByVal ID_TRANSPORTE As Int32) As PRODUCTO_TIPO_TRANS
        Try
            Return mDb.ObtenerPorTRANSPORTE(ID_TRANSPORTE)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

End Class
