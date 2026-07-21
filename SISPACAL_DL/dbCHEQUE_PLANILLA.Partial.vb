partial Public Class dbCHEQUE_PLANILLA
    Public Function ObtenerListaPorCATORCENA_TIPO_PLANILLA(ByVal ID_CATORCENA As Integer, ByVal ID_TIPO_PLANILLA As Int32, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaCHEQUE_PLANILLA

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New CHEQUE_PLANILLA))
        strSQL.Append(" WHERE ID_CATORCENA = @ID_CATORCENA AND ID_TIPO_PLANILLA = @ID_TIPO_PLANILLA ")
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ID_CATORCENA", SqlDbType.Int)
        args(0).Value = ID_CATORCENA

        args(1) = New SqlParameter("@ID_TIPO_PLANILLA", SqlDbType.Int)
        args(1).Value = ID_TIPO_PLANILLA

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaCHEQUE_PLANILLA

        Try
            Do While dr.Read()
                Dim mEntidad As New CHEQUE_PLANILLA
                dbAsignarEntidades.AsignarCHEQUE_PLANILLA(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    Public Function ObtenerListaPorCATORCENA_TIPO_PLANILLA(ByVal ID_CATORCENA As Integer, ByVal ID_TIPO_PLANILLA As Int32, ByVal ID_RANGO_COMPE As Int32, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaCHEQUE_PLANILLA

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New CHEQUE_PLANILLA))
        strSQL.Append(" WHERE ID_CATORCENA = @ID_CATORCENA AND ID_TIPO_PLANILLA = @ID_TIPO_PLANILLA ")
        strSQL.Append(" AND EXISTS( SELECT 1 FROM PLANILLA P, RANGO_COMPENSACION R ")
        strSQL.Append("             WHERE P.ID_CHEQUE_PLANILLA = CHEQUE_PLANILLA.ID_CHEQUE_PLANILLA ")
        strSQL.Append("             AND P.ID_CATORCENA = R.ID_CATORCENA AND P.VALOR_UNIT_PAGO = R.VALOR_UNIT_PAGO AND R.ID_RANGO_COMPE = @ID_RANGO_COMPE ")
        strSQL.Append("         )")
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ID_CATORCENA", SqlDbType.Int)
        args(0).Value = ID_CATORCENA

        args(1) = New SqlParameter("@ID_TIPO_PLANILLA", SqlDbType.Int)
        args(1).Value = ID_TIPO_PLANILLA

        args(2) = New SqlParameter("@ID_RANGO_COMPE", SqlDbType.Int)
        args(2).Value = ID_RANGO_COMPE

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaCHEQUE_PLANILLA

        Try
            Do While dr.Read()
                Dim mEntidad As New CHEQUE_PLANILLA
                dbAsignarEntidades.AsignarCHEQUE_PLANILLA(dr, mEntidad)
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
