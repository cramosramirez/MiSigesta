Partial Public Class dbPLANILLA_COMPROB

    Public Function fObtenerUltimoNumeroSerie(ByVal ID_COMPROB_NUME As Int32) As Int32
        Dim lResult As Int32 = 0
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter

        arg = New SqlParameter("@ID_COMPROB_NUME", SqlDbType.Int)
        arg.Value = ID_COMPROB_NUME
        args.Add(arg)


        Try
            lResult = SqlHelper.ExecuteScalar(Me.cnnStr, CommandType.Text, "SELECT ISNULL(MAX(NO_DOCTO),0) FROM PLANILLA_COMPROB WHERE ID_COMPROB_NUME = @ID_COMPROB_NUME", args.ToArray)
            Return lResult

        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
