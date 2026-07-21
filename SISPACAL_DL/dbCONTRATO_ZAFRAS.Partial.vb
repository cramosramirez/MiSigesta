Partial Public Class dbCONTRATO_ZAFRAS

    Public Function ObtenerCONTRATO_ZAFRASPorZAFRA_CONTRATO(ByVal ID_ZAFRA As Int32, ByVal CODICONTRATO As String) As CONTRATO_ZAFRAS

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT * FROM CONTRATO_ZAFRAS ")
        strSQL.Append("WHERE ID_ZAFRA = @ID_ZAFRA AND CODICONTRATO = @CODICONTRATO ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        args(0).Value = ID_ZAFRA

        args(1) = New SqlParameter("@CODICONTRATO", SqlDbType.VarChar)
        args(1).Value = CODICONTRATO

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim mEntidad As New CONTRATO_ZAFRAS

        Try
            If dr.Read() Then
                dbAsignarEntidades.AsignarCONTRATO_ZAFRAS(dr, mEntidad)
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

    Public Function ObtenerCONTRATO_ZAFRASPorZAFRA_LOTE(ByVal ID_ZAFRA As Int32, ByVal ACCESLOTE As String) As CONTRATO_ZAFRAS

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT * FROM CONTRATO_ZAFRAS C ")
        strSQL.Append("WHERE (SELECT COUNT(1) FROM LOTES L WHERE L.ACCESLOTE = @ACCESLOTE AND L.CODICONTRATO = C.CODICONTRATO) > 0 ")
        strSQL.Append("AND C.ID_ZAFRA = @ID_ZAFRA ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        args(0).Value = ID_ZAFRA

        args(1) = New SqlParameter("@ACCESLOTE", SqlDbType.VarChar)
        args(1).Value = ACCESLOTE

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim mEntidad As New CONTRATO_ZAFRAS

        Try
            If dr.Read() Then
                dbAsignarEntidades.AsignarCONTRATO_ZAFRAS(dr, mEntidad)
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
