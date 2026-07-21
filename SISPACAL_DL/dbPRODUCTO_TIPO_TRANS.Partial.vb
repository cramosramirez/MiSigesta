Partial Public Class dbPRODUCTO_TIPO_TRANS


    Public Function ObtenerPorTRANSPORTE(ByVal ID_TRANSPORTE As Int32) As PRODUCTO_TIPO_TRANS
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        strSQL.Append("SELECT S.* FROM PRODUCTO_TIPO_TRANS S ")
        strSQL.Append("WHERE (SELECT COUNT(1) FROM TRANSPORTE T WHERE T.ID_TIPOTRANS = S.ID_TIPOTRANS AND T.ID_TRANSPORTE = @ID_TRANSPORTE) > 0 ")


        arg = New SqlParameter("@ID_TRANSPORTE", SqlDbType.Int)
        arg.Value = ID_TRANSPORTE
        args.Add(arg)


        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim mEntidad As PRODUCTO_TIPO_TRANS

        Try
            If dr.Read() Then
                mEntidad = New PRODUCTO_TIPO_TRANS
                dbAsignarEntidades.AsignarPRODUCTO_TIPO_TRANS(dr, mEntidad)
            Else
                mEntidad = Nothing
            End If
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return mEntidad
    End Function

End Class
