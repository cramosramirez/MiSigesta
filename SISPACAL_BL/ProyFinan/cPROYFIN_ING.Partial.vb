Partial Public Class cPROYFIN_ING

    Public Function PROC_Iniciar_ProyFinan_Productor(ByVal CODIPROVEEDOR As String, _
                                                         ByVal ID_ZAFRA As Int32, _
                                                         ByVal USUARIO As String) As Integer
        Try
            Return mDb.PROC_Iniciar_Proyfinan_productor(CODIPROVEEDOR, ID_ZAFRA, USUARIO)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function


    Public Function PROC_Generar_ProyFinan_Lote(ByVal ID_ZAFRA As Int32, _
                                                ByVal ID_PROYFIN_ING_LOTE As Int32, _
                                                ByVal ACCESLOTE As String) As Integer
        Try
            Return mDb.PROC_Generar_ProyFinan_Lote(ID_ZAFRA, ID_PROYFIN_ING_LOTE, ACCESLOTE)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function PROC_Eliminar_ProyFinan_Lote(ByVal USUARIO As String) As Integer
        Try
            Return mDb.PROC_Eliminar_ProyFinan_Lote(USUARIO)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

End Class
