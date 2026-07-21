Partial Public Class cTIPO_PLANILLA_DESCTO
    Public Function ObtenerPorTIPO_PLANILLA_TIPO_DESCUENTO(ByVal ID_TIPO_PLANILLA As Integer, ByVal ID_TIPO_DESCTO As Integer) As TIPO_PLANILLA_DESCTO
        Try
            Return mDb.ObtenerPorTIPO_PLANILLA_TIPO_DESCUENTO(ID_TIPO_PLANILLA, ID_TIPO_DESCTO)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
