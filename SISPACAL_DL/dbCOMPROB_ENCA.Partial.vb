Partial Public Class dbCOMPROB_ENCA


    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerListaPorCriterios(ByVal ID_CATORCENA As Int32, ByVal ID_TIPO_PLANILLA As Integer) As listaCOMPROB_ENCA
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        strSQL.Append("SELECT IIF(ID_TIPO_PLANILLA = 2, CAST(CODIGO AS INT),   CAST(dbo.QuitarFormatoCODIPROVEEDOR(CODIGO) AS INT)) AS CODIGO_NUMERICO, C.* ")
        strSQL.Append("FROM COMPROB_ENCA C ")
        strSQL.Append("WHERE C.ID_TIPO_COMPROB = 9 ")

        arg = New SqlParameter("@ID_CATORCENA", SqlDbType.Int)
        arg.Value = ID_CATORCENA
        args.Add(arg)
        strSQL.Append("AND C.ID_CATORCENA = @ID_CATORCENA ")

        arg = New SqlParameter("@ID_TIPO_PLANILLA", SqlDbType.Int)
        arg.Value = ID_TIPO_PLANILLA
        args.Add(arg)
        strSQL.Append("AND C.ID_TIPO_PLANILLA = @ID_TIPO_PLANILLA ")


        strSQL.Append("ORDER BY 1")

        Dim dr As IDataReader

        If args.Count > 0 Then
            dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
        Else
            dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        End If

        Dim lista As New listaCOMPROB_ENCA

        Try
            Do While dr.Read()
                Dim mEntidad As New COMPROB_ENCA
                dbAsignarEntidades.AsignarCOMPROB_ENCA(dr, mEntidad)
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
