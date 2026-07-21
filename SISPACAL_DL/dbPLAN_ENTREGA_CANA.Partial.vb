Partial Public Class dbPLAN_ENTREGA_CANA

    Public Function EsEntregaProgramada(ByVal ID_ZAFRA As Integer, ByVal ACCESSLOTE As String) As Boolean
        Dim strSQL As New StringBuilder
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim lRet As Boolean = False

        'strSQL.Append("SELECT COUNT(*) ")
        'strSQL.Append("FROM PLAN_ENTREGA_CANA E ")
        'strSQL.Append("WHERE EXISTS(SELECT 1 ")
        'strSQL.Append("             FROM PLAN_SEMANAL S, PLAN_CATORCENA PC ")
        'strSQL.Append("             WHERE S.ID_PLAN_SEMANAL = E.ID_PLAN_SEMANAL AND S.ID_PLAN_CATORCENA = PC.ID_PLAN_CATORCENA ")
        'strSQL.Append("             AND PC.FECHA_INICIO <= @FECHA_ENTREGA AND PC.FECHA_FIN >= @FECHA_ENTREGA) ")
        'strSQL.Append("AND ACCESLOTE = @ACCESLOTE")

        strSQL.Append("SELECT COUNT(*) ")
        strSQL.Append("FROM PLAN_ENTREGA_CANA E ")
        strSQL.Append("WHERE EXISTS(SELECT 1 ")
        strSQL.Append("             FROM PLAN_SEMANAL S, PLAN_CATORCENA PC ")
        strSQL.Append("             WHERE S.ID_PLAN_SEMANAL = E.ID_PLAN_SEMANAL AND S.ID_PLAN_CATORCENA = PC.ID_PLAN_CATORCENA ")
        strSQL.Append("             AND PC.ID_ZAFRA = @ID_ZAFRA) ")
        strSQL.Append("AND ACCESLOTE = @ACCESLOTE")

        arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        arg.Value = ID_ZAFRA
        args.Add(arg)

        arg = New SqlParameter("@ACCESLOTE", SqlDbType.VarChar)
        arg.Value = ACCESSLOTE
        args.Add(arg)

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        If dr Is Nothing Then Return 0

        Try
            If dr.Read() Then
                If dr(0) > 0 Then
                    lRet = True
                End If
            Else
                Return False
            End If
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lRet

    End Function

    Public Function ObtenerManzanasToneladasProgramadas(ByVal NOMBRE_ZAFRA As String, ByVal ACCESLOTE As String, Optional ID_PLAN_SEMANAL_EXCLUIR As Integer = -1) As Dictionary(Of String, Decimal)
        Dim strSQL As New StringBuilder
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim lResultado As New Dictionary(Of String, Decimal)
        Dim strCondicion As New StringBuilder

        strSQL.Append("SELECT ISNULL(SUM(E.AREA_PROGRAMADA),0) AS TOTAL_AREA_PROGRAMADA, ISNULL(SUM(E.TONEL_PROGRAMADA),0) AS TOTAL_TONEL_PROGRAMADA ")
        strSQL.Append("FROM PLAN_ENTREGA_CANA E ")

        If NOMBRE_ZAFRA <> "" Then
            arg = New SqlParameter("@NOMBRE_ZAFRA", SqlDbType.VarChar)
            arg.Value = NOMBRE_ZAFRA
            args.Add(arg)
            AgregarCondicion(strCondicion, " EXISTS(SELECT 1 FROM PLAN_SEMANAL PS, PLAN_CATORCENA PC, ZAFRA Z WHERE PS.ID_PLAN_CATORCENA = PC.ID_PLAN_CATORCENA AND PC.ID_ZAFRA = Z.ID_ZAFRA AND Z.NOMBRE_ZAFRA = @NOMBRE_ZAFRA) ")
        End If

        If ACCESLOTE <> "" Then
            arg = New SqlParameter("@ACCESLOTE", SqlDbType.VarChar)
            arg.Value = ACCESLOTE
            args.Add(arg)
            AgregarCondicion(strCondicion, " E.ACCESLOTE = @ACCESLOTE ")
        End If

        If ID_PLAN_SEMANAL_EXCLUIR <> -1 Then
            arg = New SqlParameter("@ID_PLAN_SEMANAL_EXCLUIR", SqlDbType.Int)
            arg.Value = ID_PLAN_SEMANAL_EXCLUIR
            args.Add(arg)
            AgregarCondicion(strCondicion, " E.ID_PLAN_SEMANAL <> @ID_PLAN_SEMANAL_EXCLUIR ")
        End If
        strSQL.Append(strCondicion.ToString)

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        If dr Is Nothing Then Return Nothing

        Try
            If dr.Read() Then
                lResultado.Add("MANZANAS", dr(0))
                lResultado.Add("TONELADAS", dr(1))
            End If
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lResultado
    End Function

    Public Function ObtenerPorPLAN_SEMANAL_ACCESLOTE(ByVal ID_PLAN_SEMANAL As Integer, ByVal ACCESLOTE As String) As PLAN_ENTREGA_CANA
        Dim strSQL As New StringBuilder
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim lEntidad As New PLAN_ENTREGA_CANA

        strSQL.Append(Me.QuerySelect(lEntidad))

        arg = New SqlParameter("@ID_PLAN_SEMANAL", SqlDbType.Int)
        arg.Value = ID_PLAN_SEMANAL
        args.Add(arg)

        arg = New SqlParameter("@ACCESLOTE", SqlDbType.VarChar)
        arg.Value = ACCESLOTE
        args.Add(arg)

        strSQL.Append(" WHERE ID_PLAN_SEMANAL = @ID_PLAN_SEMANAL AND ACCESLOTE = @ACCESLOTE ")

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        If dr Is Nothing Then Return Nothing

        Try
            If dr.Read() Then
                dbAsignarEntidades.AsignarPLAN_ENTREGA_CANA(dr, CType(lEntidad, PLAN_ENTREGA_CANA))
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


    'Public Function ObtenerPoByVal ID_PLAN_SEMANAL As Integer, ByVal ACCESLOTE As String) As PLAN_ENTREGA_CANA
    '    Dim strSQL As New StringBuilder
    '    Dim args As New List(Of SqlParameter)
    '    Dim arg As SqlParameter
    '    Dim lEntidad As New PLAN_ENTREGA_CANA

    '    strSQL.Append(Me.QuerySelect(lEntidad))

    '    arg = New SqlParameter("@ID_PLAN_SEMANAL", SqlDbType.Int)
    '    arg.Value = ID_PLAN_SEMANAL
    '    args.Add(arg)

    '    arg = New SqlParameter("@ID_PLAN_SEMANAL", SqlDbType.Int)
    '    arg.Value = ID_PLAN_SEMANAL
    '    args.Add(arg)

    '    strSQL.Append(" WHERE PLAN_ENTREGA_CANA.ID_PLAN_SEMANAL = @ID_PLAN_SEMANAL AND PLAN_ENTREGA_CANA.ACCESLOTE = @ACCESLOTE ")

    '    Dim dr As IDataReader

    '    dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    '    If dr Is Nothing Then Return Nothing

    '    Try
    '        If dr.Read() Then
    '            dbAsignarEntidades.AsignarPLAN_ENTREGA_CANA(dr, CType(lEntidad, PLAN_ENTREGA_CANA))
    '        Else
    '            lEntidad = Nothing
    '        End If
    '    Catch ex As Exception
    '        Throw ex
    '    Finally
    '        dr.Close()
    '    End Try

    '    Return lEntidad
    'End Function
End Class
