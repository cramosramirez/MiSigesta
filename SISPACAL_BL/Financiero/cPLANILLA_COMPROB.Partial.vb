Partial Public Class cPLANILLA_COMPROB

    Public Function fObtenerUltimoNumeroSerie(ByVal ID_COMPROB_NUME As Int32) As Int32
        Try
            Return mDb.fObtenerUltimoNumeroSerie(ID_COMPROB_NUME)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function


End Class
