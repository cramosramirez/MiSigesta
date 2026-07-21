Partial Public Class dbCREDITO_MOV_TRANS

    Public Function ObtenerListaPorUID_REFERENCIA(ByVal UID_REFERENCIA As Guid) As listaCREDITO_MOV_TRANS
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT M.* ")
        strSQL.Append("FROM CREDITO_MOV_TRANS M ")
        strSQL.Append("WHERE (SELECT COUNT(1) FROM CREDITO_ENCA_TRANS E WHERE E.ID_CREDITO_ENCA = M.ID_CREDITO_ENCA AND E.UID_REFERENCIA = @UID_REFERENCIA) > 0 ")

        arg = New SqlParameter("@UID_REFERENCIA", SqlDbType.UniqueIdentifier)
        arg.Value = UID_REFERENCIA
        args.Add(arg)

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaCREDITO_MOV_TRANS

        Try
            While dr.Read
                Dim mEntidad As New CREDITO_MOV_TRANS
                dbAsignarEntidades.AsignarCREDITO_MOV_TRANS(dr, mEntidad)
                lista.Add(mEntidad)
            End While
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

End Class
