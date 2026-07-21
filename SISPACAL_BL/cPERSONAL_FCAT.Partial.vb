Partial Public Class cPERSONAL_FCAT

    Public Function ObtenerPorCODIGO(ByVal CODIGO As String) As PERSONAL_FCAT
        Try
            Return mDb.ObtenerPorCODIGO(CODIGO)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

End Class
