Partial Public Class dbSOLIC_ANTICIPO_CONTRATOS


    Public Function EliminarPorSOLIC_ANTICIPO_CONTRATO(ByVal ID_ANTICIPO As Int32, ByVal CODICONTRATO As String) As Integer
        Dim strSQL As New StringBuilder
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter

        arg = New SqlParameter("@ID_ANTICIPO", SqlDbType.Int)
        arg.Value = ID_ANTICIPO
        args.Add(arg)

        arg = New SqlParameter("@CODICONTRATO", SqlDbType.Char)
        arg.Value = CODICONTRATO
        args.Add(arg)

        strSQL.Append("DELETE FROM SOLIC_ANTICIPO_CONTRATOS WHERE ID_ANTICIPO = @ID_ANTICIPO AND CODICONTRATO = @CODICONTRATO")

        Return SqlHelper.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
    End Function

End Class
