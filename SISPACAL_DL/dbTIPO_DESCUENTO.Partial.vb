Partial Public Class dbTIPO_DESCUENTO
    Public Function ObtenerPorNOMBRE_TIPO_DESCTO(ByVal NOMBRE_TIPO_DESCTO As String) As TIPO_DESCUENTO
        NOMBRE_TIPO_DESCTO = NOMBRE_TIPO_DESCTO.ToUpper
        Dim mEntidad As New TIPO_DESCUENTO
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT * FROM TIPO_DESCUENTO ")
        strSQL.Append("WHERE UPPER(NOMBRE_TIPO_DESCTO) =  @NOMBRE_TIPO_DESCTO ")

        Dim args As New List(Of SqlParameter)
        Dim arg As New SqlParameter
        arg = New SqlParameter("@NOMBRE_TIPO_DESCTO", SqlDbType.VarChar)
        arg.Value = NOMBRE_TIPO_DESCTO
        args.Add(arg)

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Try
            If dr.Read() Then
                dbAsignarEntidades.AsignarTIPO_DESCUENTO(dr, mEntidad)
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
