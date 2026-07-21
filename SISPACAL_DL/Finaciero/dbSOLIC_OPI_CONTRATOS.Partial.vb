Partial Public Class dbSOLIC_OPI_CONTRATOS

    
    Public Function EliminarPorSOLIC_OPI_CONTRATO(ByVal ID_OPI As Int32, ByVal CODICONTRATO As String) As Integer
        Dim strSQL As New StringBuilder
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter

        arg = New SqlParameter("@ID_OPI", SqlDbType.Int)
        arg.Value = ID_OPI
        args.Add(arg)

        arg = New SqlParameter("@CODICONTRATO", SqlDbType.Char)
        arg.Value = CODICONTRATO
        args.Add(arg)

        strSQL.Append("DELETE FROM SOLIC_OPI_CONTRATOS WHERE ID_OPI = @ID_OPI AND CODICONTRATO = @CODICONTRATO")

        Return SqlHelper.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
    End Function
End Class
