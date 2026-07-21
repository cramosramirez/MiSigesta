Partial Public Class dbLABFAB_ANALISIS


    Public Function GenerarActualizarVariables(ByVal ID_ANALISIS As Int32, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime) As Int32
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim lRet As Int32 = 0

        arg = New SqlParameter("@ID_ANALISIS", SqlDbType.Int)
        arg.Value = ID_ANALISIS
        args.Add(arg)

        arg = New SqlParameter("@USUARIO", SqlDbType.VarChar)
        arg.Value = USUARIO_ACT
        args.Add(arg)

        arg = New SqlParameter("@FECHA", SqlDbType.DateTime)
        arg.Value = FECHA_ACT
        args.Add(arg)

        Try
            lRet = SqlHelper.ExecuteNonQuery(Me.cnnStr, CommandType.StoredProcedure, "GENERAR_LABFAB_VAR", args.ToArray)

        Catch ex As Exception
            Throw ex
        End Try

        Return lRet
    End Function
End Class
