Partial Public Class dbLOTES_COSECHA_GESTION

    Public Function ObtenerLOTES_COSECHA_GESTIONPorLOTE_ZAFRA(ByVal ACCESLOTE As String, ByVal ID_ZAFRA As Int32) As listaLOTES_COSECHA_GESTION

        Dim strSQL As New StringBuilder
        Dim args As New List(Of SqlParameter)
        Dim arg As New SqlParameter

        strSQL.Append("SELECT G.* ")
        strSQL.Append("FROM LOTES_COSECHA_GESTION G ")
        strSQL.Append("WHERE G.ACCESLOTE = @ACCESLOTE ")
        strSQL.Append("AND (SELECT COUNT(1) FROM LOTES_COSECHA LC WHERE LC.ID_LOTES_COSECHA = G.ID_LOTES_COSECHA AND LC.ID_ZAFRA = @ID_ZAFRA ) > 0 ")

        arg = New SqlParameter("@ACCESLOTE", SqlDbType.Char)
        arg.Value = ACCESLOTE
        args.Add(arg)

        arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        arg.Value = ID_ZAFRA
        args.Add(arg)

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaLOTES_COSECHA_GESTION

        Try
            Do While dr.Read()
                Dim mEntidad As New LOTES_COSECHA_GESTION
                dbAsignarEntidades.AsignarLOTES_COSECHA_GESTION(dr, mEntidad)
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
