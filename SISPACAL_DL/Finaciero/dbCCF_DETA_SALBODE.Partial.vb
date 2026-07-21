Partial Public Class dbCCF_DETA_SALBODE

    Public Function ObtenerListaPendienteFacturar(ByVal CODIPROVEEDOR As String, ByVal ID_PROVEE As Int32) As listaCCF_DETA_SALBODE
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder

        strSQL.Append("SELECT ")
        strSQL.Append(" (SELECT ISNULL(MAX(ID_CCF_DETA_SAL),0) FROM CCF_DETA_SALBODE) + ROW_NUMBER() OVER(ORDER BY D.ID_PRODUCTO) AS ID_CCF_DETA_SAL, 0 AS ID_CCF_ENCA, ")
        strSQL.Append(" D.ID_SALBODE_DETA, D.ID_SOLICITUD, D.ID_PRODUCTO, D.NOMBRE_PRODUCTO, D.PRESENTACION, ")
        strSQL.Append(" ( ")
        strSQL.Append(" D.CANT_ENTREGADA - ISNULL((SELECT SUM(CANTIDAD_CCF) FROM CCF_DETA_SALBODE C WHERE C.ID_SALBODE_DETA = D.ID_SALBODE_DETA ),0)  ")
        strSQL.Append(" ) AS CANTIDAD_CCF, ")
        strSQL.Append(" D.PRECIO_UNITARIO AS PRECIO_UNITARIO_CCF, ")
        strSQL.Append(" ROUND(( ")
        strSQL.Append(" D.CANT_ENTREGADA - ISNULL((SELECT SUM(CANTIDAD_CCF) FROM CCF_DETA_SALBODE C WHERE C.ID_SALBODE_DETA = D.ID_SALBODE_DETA ),0)  ")
        strSQL.Append(" ) * D.PRECIO_UNITARIO ,2) AS TOTAL_CCF ")
        strSQL.Append("FROM SALBODE_ENCA E, SALBODE_DETA D, SOLIC_AGRICOLA S, PRODUCTO P ")
        strSQL.Append("WHERE E.ID_SALBODE_ENCA = D.ID_SALBODE_ENCA ")
        strSQL.Append("AND D.ID_SOLICITUD = S.ID_SOLICITUD ")
        strSQL.Append("AND S.CODIPROVEEDOR = @CODIPROVEEDOR ")
        strSQL.Append("AND D.ID_PRODUCTO = P.ID_PRODUCTO ")
        strSQL.Append("AND (SELECT COUNT(1) FROM SOLIC_AGRICOLA_PRODUCTO SP WHERE SP.ID_SOLICITUD = S.ID_SOLICITUD AND SP.ID_PRODUCTO = D.ID_PRODUCTO AND SP.ID_PROVEE = @ID_PROVEE ) > 0 ")
        strSQL.Append("AND D.CANT_ENTREGADA > 0 ")
        strSQL.Append("AND D.ID_ESTADO = 4 ")
        strSQL.Append("AND ( ")
        strSQL.Append(" D.CANT_ENTREGADA - ISNULL((SELECT SUM(CANTIDAD_CCF) FROM CCF_DETA_SALBODE C WHERE C.ID_SALBODE_DETA = D.ID_SALBODE_DETA ),0)  ")
        strSQL.Append(" ) > 0 ")


        arg = New SqlParameter("@CODIPROVEEDOR", SqlDbType.Char)
        arg.Value = CODIPROVEEDOR
        args.Add(arg)

        arg = New SqlParameter("@ID_PROVEE", SqlDbType.Int)
        arg.Value = ID_PROVEE
        args.Add(arg)

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaCCF_DETA_SALBODE

        Try
            While dr.Read
                Dim mEntidad As New CCF_DETA_SALBODE
                dbAsignarEntidades.AsignarCCF_DETA_SALBODE(dr, mEntidad)
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
