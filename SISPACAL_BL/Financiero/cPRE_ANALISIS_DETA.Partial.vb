Partial Public Class cPRE_ANALISIS_DETA

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorUID_REF(ByVal UID_REF As String) As listaPRE_ANALISIS_DETA
        Try
            Return mDb.ObtenerListaPorUID_REF(UID_REF)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

End Class
