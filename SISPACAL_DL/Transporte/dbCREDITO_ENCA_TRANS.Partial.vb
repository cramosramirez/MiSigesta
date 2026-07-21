Partial Public Class dbCREDITO_ENCA_TRANS

    Public Function ObtenerListaPorUID_REFERENCIA(ByVal UID_REFERENCIA As Guid) As listaCREDITO_ENCA_TRANS
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT * ")
        strSQL.Append("FROM CREDITO_ENCA_TRANS E ")
        strSQL.Append("WHERE UID_REFERENCIA = @UID_REFERENCIA ")

        arg = New SqlParameter("@UID_REFERENCIA", SqlDbType.UniqueIdentifier)
        arg.Value = UID_REFERENCIA
        args.Add(arg)

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaCREDITO_ENCA_TRANS

        Try
            While dr.Read
                Dim mEntidad As New CREDITO_ENCA_TRANS
                dbAsignarEntidades.AsignarCREDITO_ENCA_TRANS(dr, mEntidad)
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
