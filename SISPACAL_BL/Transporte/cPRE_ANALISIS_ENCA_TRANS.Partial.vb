Partial Public Class cPRE_ANALISIS_ENCA_TRANS

    Public Function PROC_Generar_Pre_Analisis_Finan_Trans(ByVal ID_ZAFRA As Int32, ByVal CODTRANSPORT As Int32, _
                                                ByVal UID_REF As String, ByVal FECHA As Date, ByVal USUARIO_CREA As String, _
                                                Optional ByVal MONTO_SOLICITADO As Decimal = 0, Optional TIPO_MONTO_SOLICITADO As String = "", _
                                                Optional ByVal UID_DOCUMENTO As String = "") As Integer
        Try
            Return mDb.PROC_Generar_Pre_Analisis_Finan_Trans(ID_ZAFRA, CODTRANSPORT, UID_REF, FECHA, USUARIO_CREA, MONTO_SOLICITADO, TIPO_MONTO_SOLICITADO, UID_DOCUMENTO)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorUID_REF(ByVal UID_REF As String) As listaPRE_ANALISIS_ENCA_TRANS
        Try
            Return mDb.ObtenerListaPorUID_REF(UID_REF)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

End Class
