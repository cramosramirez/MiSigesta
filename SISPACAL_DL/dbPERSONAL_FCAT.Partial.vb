Partial Public Class dbPERSONAL_FCAT

    Public Function ObtenerPorCODIGO(ByVal CODIGO As String) As PERSONAL_FCAT
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        strSQL.Append("SELECT * FROM PERSONAL_FCAT ")
        strSQL.Append("WHERE CODIGO = @CODIGO ")


        arg = New SqlParameter("@CODIGO", SqlDbType.VarChar)
        arg.Value = CODIGO
        args.Add(arg)


        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lEntidad As New PERSONAL_FCAT

        Try
            If dr.Read() Then
                dbAsignarEntidades.AsignarPERSONAL_FCAT(dr, lEntidad)
            Else
                lEntidad = Nothing
            End If
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lEntidad
    End Function


End Class
