Partial Public Class dbPRE_ANALISIS_DETA

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerListaPorUID_REF(ByVal UID_REF As String) As listaPRE_ANALISIS_DETA
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New PRE_ANALISIS_DETA))
        strSQL.Append(" WHERE UID_REF = @UID_REF ")
        strSQL.Append(" ORDER BY ORDEN ")


        arg = New SqlParameter("@UID_REF", SqlDbType.VarChar)
        arg.Value = UID_REF
        args.Add(arg)

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaPRE_ANALISIS_DETA

        Try
            While dr.Read
                Dim mEntidad As New PRE_ANALISIS_DETA
                dbAsignarEntidades.AsignarPRE_ANALISIS_DETA(dr, mEntidad)
                lista.Add(mEntidad)
            End While
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    Public Function PROC_ACTUALIZAR_PRE_ANALISIS_DETA_RESULTADOS(ByVal UID_REF As String) As Integer
        Dim lResult As Integer = -1
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter

        arg = New SqlParameter("@UID_REF", SqlDbType.VarChar)
        arg.Value = UID_REF
        args.Add(arg)

        Try
            lResult = SqlHelper.ExecuteNonQuery(Me.cnnStr, CommandType.StoredProcedure, "ACTUALIZAR_PRE_ANALISIS_DETA_RESULTADOS", args.ToArray)
            Return 1

        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
