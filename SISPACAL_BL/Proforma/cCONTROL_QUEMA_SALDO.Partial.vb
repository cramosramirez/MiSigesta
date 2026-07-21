Partial Public Class cCONTROL_QUEMA_SALDO

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerListaPorCriterios(ByVal ID_ZAFRA As Int32,
                                            ByVal ACCESLOTE As String,
                                            ByVal FECHA_HORA_QUEMA As Object,
                                            ByVal QUEMA_PROGRAMADA As Int32,
                                            ByVal QUEMA_NOPROG As Int32,
                                            ByVal CANA_VERDE As Int32,
                                            ByVal ES_PROYECCION As Int32,
                                            ByVal CON_SALDO As Boolean,
                                            Optional ID_SUBLOTES As Int32 = -1,
                                            Optional ByVal asColumnaOrden As String = "",
                                            Optional ByVal asTipoOrden As String = "ASC") As listaCONTROL_QUEMA_SALDO

        Try
            Return mDb.ObtenerListaPorCriterios(ID_ZAFRA, ACCESLOTE, FECHA_HORA_QUEMA, QUEMA_PROGRAMADA, QUEMA_NOPROG, CANA_VERDE, ES_PROYECCION, CON_SALDO, ID_SUBLOTES, asColumnaOrden, asTipoOrden)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ObtenerPS_CONTROL_QUEMA(ByVal ID_ZAFRA As Int32, ByVal ACCESLOTE As String) As listaCONTROL_QUEMA_SALDO
        Try

            Return mDb.ObtenerListaPorCriterios(ID_ZAFRA, ACCESLOTE, -1, -1, -1, -1, -1, False, "FECHA_HORA_QUEMA, ID_QUEMA_SALDO", "ASC")

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCriteriosLiquidacion(ByVal ID_ZAFRA As Int32, _
                                            ByVal NO_CATORCENA As Int32, _
                                            ByVal CODIPROVEE As String, _
                                            ByVal CODISOCIO As String, _
                                            ByVal NOMBRE_PROVEEDOR As String, _
                                            ByVal NOMBRE_LOTE As String, _
                                            ByVal ES_PROYECCION As Int32, _
                                            ByVal TIPO_SALDO As Int32, _
                                            Optional ByVal asColumnaOrden As String = "", _
                                            Optional ByVal asTipoOrden As String = "ASC") As listaCONTROL_QUEMA_SALDO

        Try
            Return mDb.ObtenerListaPorCriteriosLiquidacion(ID_ZAFRA, NO_CATORCENA, CODIPROVEE, CODISOCIO, NOMBRE_PROVEEDOR, NOMBRE_LOTE, ES_PROYECCION, TIPO_SALDO, asColumnaOrden, asTipoOrden)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
