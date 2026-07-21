Partial Public Class cCOMPROB_ENCA



    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerListaPorCriterios(ByVal ID_CATORCENA As Int32, ByVal ID_TIPO_PLANILLA As Integer) As listaCOMPROB_ENCA
        Try

            Return mDb.ObtenerListaPorCriterios(ID_CATORCENA, ID_TIPO_PLANILLA)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
