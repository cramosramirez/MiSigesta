Partial Public Class dbLABFAB_ANALISISXDIA
    Public Function ObtenerNoAnalisisDiaZafra(ByVal ID_ANALISIS As Int32, ByVal ID_ZAFRA As Int32, ByVal DIAZAFRA As Int32) As Int32
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim lRet As Int32

        strSQL.Append("SELECT ISNULL(COUNT(*),0) + 1 AS NO_ANALISIS ")
        strSQL.Append("FROM LABFAB_ANALISISXDIA ")
        strSQL.Append("WHERE ID_ANALISIS = @ID_ANALISIS ")
        strSQL.Append("AND ID_ZAFRA = @ID_ZAFRA ")
        strSQL.Append("AND DIAZAFRA = @DIAZAFRA ")

        arg = New SqlParameter("@ID_ANALISIS", SqlDbType.Int)
        arg.Value = ID_ANALISIS
        args.Add(arg)

        arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        arg.Value = ID_ZAFRA
        args.Add(arg)

        arg = New SqlParameter("@DIAZAFRA", SqlDbType.Int)
        arg.Value = DIAZAFRA
        args.Add(arg)

        Try
            lRet = SqlHelper.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Catch ex As Exception
            Throw ex
        End Try

        Return lRet
    End Function


    Public Function GenerarValoresAnalisisEnSerie(ByVal ID_ANALISISXDIA As Int32) As Integer

        Dim lResult As Integer = -1
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter

        arg = New SqlParameter("@ID_ANALISISXDIA", SqlDbType.Int)
        arg.Value = ID_ANALISISXDIA
        args.Add(arg)

        Try
            lResult = SqlHelper.ExecuteNonQuery(Me.cnnStr, CommandType.StoredProcedure, "PROC_ACTUALIZAR_LABFAB_ANALISISXDIA_SERIE", args.ToArray)
        Catch ex As Exception
            Throw ex
        End Try
        Return lResult
    End Function
End Class
