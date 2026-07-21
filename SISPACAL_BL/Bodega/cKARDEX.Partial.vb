Partial Public Class cKARDEX

    Public Function ObtenerKARDEX_UltimoMovtoID_PRODUCTO(ByVal ID_BODEGA As Int32, ByVal ID_PRODUCTO As Int32) As KARDEX
        Try
            Return mDb.ObtenerKARDEX_UltimoMovtoID_PRODUCTO(ID_BODEGA, ID_PRODUCTO)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

End Class
