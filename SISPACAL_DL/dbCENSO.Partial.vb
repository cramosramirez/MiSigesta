Partial Public Class dbCENSO
    

    Public Function ObtenerListaPorFECHA(ByVal FECHA_CENSO As DateTime) As listaCENSO
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT * FROM CENSO ")
        strSQL.Append("WHERE FECHA_CENSO = @FECHA_CENSO ")

        arg = New SqlParameter("@FECHA_CENSO", SqlDbType.DateTime)
        arg.Value = FECHA_CENSO
        args.Add(arg)

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaCENSO

        Try
            Do While dr.Read()
                Dim mEntidad As New CENSO
                dbAsignarEntidades.AsignarCENSO(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function
End Class
