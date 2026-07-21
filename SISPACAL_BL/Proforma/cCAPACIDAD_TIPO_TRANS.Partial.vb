Partial Public Class cCAPACIDAD_TIPO_TRANS

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerCapacidadPorTIPO_CANA_TIPO_TRANS(ByVal ID_TIPO_TRANS As Int32) As Decimal
        Try
            Return mDb.ObtenerCapacidadPorTIPO_CANA_TIPO_TRANS(ID_TIPO_TRANS)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return 0
        End Try
    End Function
End Class
