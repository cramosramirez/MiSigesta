Partial Public Class dbPROYFIN_ING


    Public Function PROC_Iniciar_ProyFinan_Productor(ByVal CODIPROVEEDOR As String, _
                                                         ByVal ID_ZAFRA As Int32, _
                                                         ByVal USUARIO As String) As Integer
        Dim lResult As Integer = -1
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter

        arg = New SqlParameter("@CODIPROVEEDOR", SqlDbType.VarChar)
        arg.Value = CODIPROVEEDOR
        args.Add(arg)

        arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        arg.Value = ID_ZAFRA
        args.Add(arg)

        arg = New SqlParameter("@USUARIO", SqlDbType.VarChar)
        arg.Value = USUARIO
        args.Add(arg)

        Dim dr As IDataReader
        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.StoredProcedure, "INICIAR_PROYFINAN_PRODUCTOR", args.ToArray)

        Try
            If dr.Read Then
                Return CInt(dr(0))
            End If

            Return -1

        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try
    End Function


    Public Function PROC_Generar_ProyFinan_Lote(ByVal ID_ZAFRA As Int32, _
                                                ByVal ID_PROYFIN_ING_LOTE As Int32, _
                                                ByVal ACCESLOTE As String) As Integer
        Dim lResult As Integer = -1
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim lret As Integer = 0

        arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        arg.Value = ID_ZAFRA
        args.Add(arg)

        arg = New SqlParameter("@ID_PROYFIN_ING_LOTE", SqlDbType.Int)
        arg.Value = ID_PROYFIN_ING_LOTE
        args.Add(arg)

        arg = New SqlParameter("@ACCESLOTE", SqlDbType.VarChar)
        arg.Value = ACCESLOTE
        args.Add(arg)
        
        Try

            lret = SqlHelper.ExecuteNonQuery(Me.cnnStr, CommandType.StoredProcedure, "GENERAR_PROYFIN_LOTE", args.ToArray)
            Return lret

        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Function PROC_Eliminar_ProyFinan_Lote(ByVal USUARIO As String) As Integer
        Dim lResult As Integer = -1
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim lret As Integer = 0

        arg = New SqlParameter("@USUARIO", SqlDbType.VarChar)
        arg.Value = USUARIO
        args.Add(arg)

        Try

            lret = SqlHelper.ExecuteNonQuery(Me.cnnStr, CommandType.StoredProcedure, "ELIMINAR_PROYFINAN_EN_PROCESO", args.ToArray)
            Return lret

        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
