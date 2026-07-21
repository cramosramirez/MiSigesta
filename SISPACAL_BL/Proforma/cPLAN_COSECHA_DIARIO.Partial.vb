Partial Public Class cPLAN_COSECHA_DIARIO


    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCriterios(ByVal ID_ZAFRA As Int32, _
                                             ByVal ZONA As String, _
                                             ByVal DIAZAFRA As Int32, _
                                             ByVal CODIPROVEE As String, _
                                             ByVal CODISOCIO As String, _
                                             ByVal NOMBRE_PROVEEDOR As String) As listaPLAN_COSECHA_DIARIO
        Try
            Return mDb.ObtenerListaPorCriterios(ID_ZAFRA, ZONA, DIAZAFRA, CODIPROVEE, CODISOCIO, NOMBRE_PROVEEDOR)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function GenerarPropuestaCosechaDiaria(ByVal ID_ZAFRA As Integer, _
                 ByVal FECHA As DateTime, _
                 ByVal USUARIO_CREA As String, _
                 ByVal FECHA_CREA As DateTime) As Integer
        Try
            Return mDb.GenerarPropuestaCosechaDiaria(ID_ZAFRA, FECHA, USUARIO_CREA, FECHA_CREA)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Me.sError = ex.Message
            Return -1
        End Try
    End Function
End Class
