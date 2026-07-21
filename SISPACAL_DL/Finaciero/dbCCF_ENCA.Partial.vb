Partial Public Class dbCCF_ENCA

    Public Function ObtenerListaPorCONCEPTO_CCF(ByVal CONCEPTO_CCF As Int32) As listaCCF_ENCA
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New CCF_ENCA))
        strSQL.Append(" WHERE CONCEPTO_CCF = @CONCEPTO_CCF ")


        arg = New SqlParameter("@CONCEPTO_CCF", SqlDbType.Int)
        arg.Value = CONCEPTO_CCF
        args.Add(arg)

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaCCF_ENCA

        Try
            While dr.Read
                Dim mEntidad As New CCF_ENCA
                dbAsignarEntidades.AsignarCCF_ENCA(dr, mEntidad)
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
