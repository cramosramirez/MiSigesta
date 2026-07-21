Partial Public Class cLOTES_COSECHA_GESTION

    Public Function ObtenerLOTES_COSECHA_GESTIONPorLOTE_ZAFRA(ByVal ACCESLOTE As String, ByVal ID_ZAFRA As Int32) As listaLOTES_COSECHA_GESTION
        Try
            Return mDb.ObtenerLOTES_COSECHA_GESTIONPorLOTE_ZAFRA(ACCESLOTE, ID_ZAFRA)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
