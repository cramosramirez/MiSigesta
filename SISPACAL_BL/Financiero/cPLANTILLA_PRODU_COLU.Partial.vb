Partial Public Class cPLANTILLA_PRODU_COLU


    Public Function ObtenerListaPorUID(ByVal UID_REFERENCIA As Guid, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaPLANTILLA_PRODU_COLU
        Try
            Return mDb.ObtenerListaPorUID(UID_REFERENCIA, asColumnaOrden, asTipoOrden)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function PROC_Generar_Data_Plantilla_Descto_Productor(ByVal ID_ZAFRA As Int32,
                                                                 ByVal ID_CATORCENA As Int32,
                                                                 ByVal ID_TIPO_PLANILLA As Int32,
                                                                 ByVal UID_REFERENCIA As Guid,
                                                                 ByVal USUARIO_CREA As String,
                                                                 ByVal FECHA_CALC_INTERES As DateTime) As Integer
        Try
            Return mDb.PROC_Generar_Data_Plantilla_Descto_Productor(ID_ZAFRA, ID_CATORCENA, ID_TIPO_PLANILLA, UID_REFERENCIA, USUARIO_CREA, FECHA_CALC_INTERES)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Me.sError = ex.Message.ToString
            Return -1
        End Try
    End Function

    Public Function PROC_Generar_Data_Plantilla_Descto_Productor2(ByVal ID_ZAFRA As Int32,
                                                                 ByVal ID_CATORCENA As Int32,
                                                                 ByVal ID_TIPO_PLANILLA As Int32,
                                                                 ByVal UID_REFERENCIA As Guid,
                                                                 ByVal USUARIO_CREA As String,
                                                                 ByVal FECHA_CALC_INTERES As DateTime) As Integer
        Try
            Return mDb.PROC_Generar_Data_Plantilla_Descto_Productor2(ID_ZAFRA, ID_CATORCENA, ID_TIPO_PLANILLA, UID_REFERENCIA, USUARIO_CREA, FECHA_CALC_INTERES)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Me.sError = ex.Message.ToString
            Return -1
        End Try
    End Function
End Class
