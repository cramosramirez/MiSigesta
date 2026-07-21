Partial Public Class dbTIPO_PLANILLA_DESCTO

    Public Function ObtenerPorTIPO_PLANILLA_TIPO_DESCUENTO(ByVal ID_TIPO_PLANILLA As Integer, ByVal ID_TIPO_DESCTO As Integer) As TIPO_PLANILLA_DESCTO
        Dim mEntidad As New TIPO_PLANILLA_DESCTO
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT * FROM TIPO_PLANILLA_DESCTO ")
        strSQL.Append("WHERE ID_TIPO_PLANILLA = @ID_TIPO_PLANILLA AND ID_TIPO_DESCTO = @ID_TIPO_DESCTO ")

        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter

        arg = New SqlParameter("@ID_TIPO_PLANILLA", SqlDbType.Int)
        arg.Value = ID_TIPO_PLANILLA
        args.Add(arg)

        arg = New SqlParameter("@ID_TIPO_DESCTO", SqlDbType.Int)
        arg.Value = ID_TIPO_DESCTO
        args.Add(arg)

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Try
            If dr.Read() Then
                dbAsignarEntidades.AsignarTIPO_PLANILLA_DESCTO(dr, mEntidad)
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
