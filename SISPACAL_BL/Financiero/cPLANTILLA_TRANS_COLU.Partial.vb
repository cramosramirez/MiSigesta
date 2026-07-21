Partial Public Class cPLANTILLA_TRANS_COLU

    Public Function ObtenerListaPorUID(ByVal UID_REFERENCIA As Guid, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaPLANTILLA_TRANS_COLU
        Try
            Return mDb.ObtenerListaPorUID(UID_REFERENCIA, asColumnaOrden, asTipoOrden)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function PROC_Generar_Data_Plantilla_Descto_Transportista(ByVal ID_ZAFRA As Int32, _
                                                                 ByVal ID_CATORCENA As Int32, _
                                                                 ByVal ID_TIPO_PLANILLA As Int32, _
                                                                 ByVal UID_REFERENCIA As Guid, _
                                                                 ByVal USUARIO_CREA As String, _
                                                                 ByVal FECHA_CALC_INTERES As DateTime) As Integer
        Try
            Return mDb.PROC_Generar_Data_Plantilla_Descto_Transportista(ID_ZAFRA, ID_CATORCENA, ID_TIPO_PLANILLA, UID_REFERENCIA, USUARIO_CREA, FECHA_CALC_INTERES)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

End Class
