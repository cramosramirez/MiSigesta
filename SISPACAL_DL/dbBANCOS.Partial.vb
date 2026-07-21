Partial Public Class dbBANCOS
    Public Function ObtenerPorCATORCENA_PLANILLA_tipoCONTRIBUYENTE(ByVal ID_CATORCENA As Integer, _
                                                                   ByVal ID_TIPO_PLANILLA As Integer, _
                                                                   ByVal TIPO_CONTRIBUYENTE As Integer) As listaBANCOS
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT DISTINCT * FROM BANCOS ")
        strSQL.Append("WHERE EXISTS( ")
        strSQL.Append("  SELECT 1 FROM CUENTA_BANCARIA C, CHEQUERA_PLANILLA CP, CHEQUE_PLANILLA CH, PLANILLA P ")
        strSQL.Append("  WHERE C.CODIBANCO = BANCOS.CODIBANCO AND C.ID_CUENTA = CP.ID_CUENTA AND CP.ID_CHEQUERA = CH.ID_CHEQUERA AND CH.ID_CHEQUE_PLANILLA = P.ID_CHEQUE_PLANILLA ")
        strSQL.Append("  AND P.ID_CATORCENA = @ID_CATORCENA AND P.ID_TIPO_PLANILLA = @ID_TIPO_PLANILLA ")

        arg = New SqlParameter("@ID_CATORCENA", SqlDbType.Int)
        arg.Value = ID_CATORCENA
        args.Add(arg)

        arg = New SqlParameter("@ID_TIPO_PLANILLA", SqlDbType.Int)
        arg.Value = ID_TIPO_PLANILLA
        args.Add(arg)

        If TIPO_CONTRIBUYENTE <> -1 Then
            arg = New SqlParameter("@TIPO_CONTRIBUYENTE", SqlDbType.Bit)
            arg.Value = TIPO_CONTRIBUYENTE
            args.Add(arg)
            strSQL.Append(" AND ES_CONTRIBUYENTE = @TIPO_CONTRIBUYENTE)")
        Else
            strSQL.Append(")")
        End If
        strSQL.Append(" ORDER BY NOMBRE_BANCO")

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaBANCOS

        Try
            Do While dr.Read()
                Dim mEntidad As New BANCOS
                dbAsignarEntidades.AsignarBANCOS(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    Public Function ObtenerListaConOIP() As listaBANCOS
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT * FROM BANCOS B ")
        strSQL.Append("WHERE (SELECT COUNT(1) FROM SOLIC_OPI S WHERE S.CODIBANCO = B.CODIBANCO) > 0 ")
        strSQL.Append("ORDER BY NOMBRE_BANCO ")

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New listaBANCOS

        Try
            Do While dr.Read()
                Dim mEntidad As New BANCOS
                dbAsignarEntidades.AsignarBANCOS(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    Public Function ObtenerListaParaGeneracionPAGO_CTA(ByVal ID_CATORCENA As Integer,
                                                                   ByVal ID_TIPO_PLANILLA As Integer,
                                                                   ByVal TIPO_CONTRIBUYENTE As Integer) As listaBANCOS
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT DISTINCT B.* ")
        strSQL.Append("FROM PAGO_CTA_BANCO PG, BANCOS B ")
        strSQL.Append("WHERE PG.CODIBANCO = B.CODIBANCO ")
        strSQL.Append("AND PG.ID_CATORCENA = @ID_CATORCENA ")
        strSQL.Append("AND PG.ID_TIPO_PLANILLA = @ID_TIPO_PLANILLA ")
        strSQL.Append("AND (SELECT COUNT(1) FROM PLANILLA P WHERE P.ID_CATORCENA = PG.ID_CATORCENA AND P.CODIPROVEEDOR_TRANSPORTISTA = PG.CODIPROVEEDOR_TRANSPORTISTA AND P.ID_TIPO_PLANILLA = PG.ID_TIPO_PLANILLA AND P.ES_CONTRIBUYENTE = @TIPO_CONTRIBUYENTE) > 0 ")

        arg = New SqlParameter("@ID_CATORCENA", SqlDbType.Int)
        arg.Value = ID_CATORCENA
        args.Add(arg)

        arg = New SqlParameter("@ID_TIPO_PLANILLA", SqlDbType.Int)
        arg.Value = ID_TIPO_PLANILLA
        args.Add(arg)

        arg = New SqlParameter("@TIPO_CONTRIBUYENTE", SqlDbType.Bit)
        arg.Value = TIPO_CONTRIBUYENTE
        args.Add(arg)

        strSQL.Append(" ORDER BY NOMBRE_BANCO")

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaBANCOS

        Try
            Do While dr.Read()
                Dim mEntidad As New BANCOS
                dbAsignarEntidades.AsignarBANCOS(dr, mEntidad)
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
