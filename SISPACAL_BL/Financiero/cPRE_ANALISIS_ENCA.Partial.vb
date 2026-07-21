Partial Public Class cPRE_ANALISIS_ENCA


    Public Function PROC_Generar_Pre_Analisis_Finan(ByVal ID_ZAFRA As Int32, ByVal ID_ZAFRA2 As Int32, ByVal CODIPROVEEDOR As String, ByVal CONTRATOS As String,
                                                    ByVal UID_REF As String, ByVal FECHA As Date, ByVal USUARIO_CREA As String,
                                                    Optional ByVal MONTO_SOLICITADO As Decimal = 0, Optional ByVal MONTO_SOLICITADO2 As Decimal = 0, Optional ByVal TIPO_MONTO_SOLICITADO As String = "",
                                                    Optional ByVal UID_DOCUMENTO As String = "") As Integer
        Try
            Return mDb.PROC_Generar_Pre_Analisis_Finan(ID_ZAFRA, ID_ZAFRA2, CODIPROVEEDOR, CONTRATOS, UID_REF, FECHA, USUARIO_CREA, MONTO_SOLICITADO, MONTO_SOLICITADO2, TIPO_MONTO_SOLICITADO, UID_DOCUMENTO)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    Public Function PROC_Generar_Analisis_Financiero_proyectado(ByVal ID_ZAFRA As Int32, ByVal ID_ZAFRA2 As Int32, ByVal CODIPROVEEDOR As String, ByVal CONTRATOS As String,
                                                    ByVal UID_REF As String, ByVal FECHA As Date, ByVal USUARIO_CREA As String,
                                                    Optional ByVal MONTO_SOLICITADO As Decimal = 0, Optional ByVal MONTO_SOLICITADO2 As Decimal = 0, Optional TIPO_MONTO_SOLICITADO As String = "",
                                                    Optional ByVal UID_DOCUMENTO As String = "") As Integer
        Try
            Return mDb.PROC_Generar_Analisis_Financiero_proyectado(ID_ZAFRA, ID_ZAFRA2, CODIPROVEEDOR, CONTRATOS, UID_REF, FECHA, USUARIO_CREA, MONTO_SOLICITADO, MONTO_SOLICITADO2, TIPO_MONTO_SOLICITADO, UID_DOCUMENTO)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorUID_REF(ByVal UID_REF As String) As listaPRE_ANALISIS_ENCA
        Try
            Return mDb.ObtenerListaPorUID_REF(UID_REF)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ReporteExcelFinancieroProductores(ByVal ID_ZAFRA As Integer) As DataTable
        Try
            Return mDb.ReporteExcelFinancieroProductores(ID_ZAFRA)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

End Class
