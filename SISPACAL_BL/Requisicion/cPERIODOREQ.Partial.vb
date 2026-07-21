Partial Public Class cPERIODOREQ

    Public Function ObtenerPeriodoReqActivo() As PERIODOREQ
        Try
            Return mDb.ObtenerPeriodoReqActivo

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ObtenerPERIODOREQ_PorFecha(ByVal FECHA As DateTime) As PERIODOREQ
        Try
            Return mDb.ObtenerPERIODOREQ_PorFecha(FECHA)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

End Class
