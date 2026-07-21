Partial Public Class dbCONTROL_QUEMA


    Public Function ObtenerHorasQuemaTranscurridas(ByVal ID_ZAFRA As Int32, _
                                                   ByVal ACCESLOTE As String) As Dictionary(Of String, Int32)
        Dim dFechora As New dbFechaHora
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim fechaHora As DateTime = dFechora.ObtenerFechaHora

        strSQL.Append("SELECT ")
        strSQL.Append(" ISNULL(DATEDIFF(hour,MIN(FECHA_HORA_QUEMA_PROGRAMADA),@FECHORA_ACTUAL),0) AS QP,")
        strSQL.Append(" ISNULL(DATEDIFF(hour,MIN(FECHA_HORA_QUEMA_NOPROG),@FECHORA_ACTUAL),0) AS QNP ")
        strSQL.Append("FROM ( ")
        strSQL.Append(" SELECT ")
        strSQL.Append("     (SELECT MIN(FECHA_HORA_QUEMA) FROM CONTROL_QUEMA_SALDO WHERE ID_ZAFRA = @ID_ZAFRA AND ACCESLOTE = @ACCESLOTE AND QUEMA_PROGRAMADA = 1 AND SALDO > 0) AS FECHA_HORA_QUEMA_PROGRAMADA, ")
        strSQL.Append("     (SELECT MIN(FECHA_HORA_QUEMA) FROM CONTROL_QUEMA_SALDO WHERE ID_ZAFRA = @ID_ZAFRA AND ACCESLOTE = @ACCESLOTE AND QUEMA_NOPROG = 1 AND SALDO > 0) AS FECHA_HORA_QUEMA_NOPROG ")
        strSQL.Append("     ) S ")

        arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        arg.Value = ID_ZAFRA
        args.Add(arg)

        arg = New SqlParameter("@ACCESLOTE", SqlDbType.VarChar)
        arg.Value = ACCESLOTE
        args.Add(arg)

        arg = New SqlParameter("@FECHORA_ACTUAL", SqlDbType.DateTime)
        arg.Value = fechaHora
        args.Add(arg)

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New Dictionary(Of String, Int32)
        lista.Add("QP", 0)
        lista.Add("QNP", 0)

        Try

            If dr.Read() Then
                lista("QP") = dr("QP")
                lista("QNP") = dr("QNP")
            End If

        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista
    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Foranea, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="ID_TIPO_CANA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorTIPO_CANA(ByVal ID_TIPO_CANA As Int32, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaCONTROL_QUEMA

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New CONTROL_QUEMA))
        strSQL.Append(" WHERE ID_TIPO_CANA = @ID_TIPO ")
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_TIPO_CANA", SqlDbType.Int)
        args(0).Value = ID_TIPO_CANA

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaCONTROL_QUEMA

        Try
            Do While dr.Read()
                Dim mEntidad As New CONTROL_QUEMA
                dbAsignarEntidades.AsignarCONTROL_QUEMA(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorZAFRA_LOTE(ByVal ID_ZAFRA As Int32, _
                                             ByVal ACCESLOTE As String, _
                                             Optional asColumnaOrden As String = "", _
                                             Optional asTipoOrden As String = "ASC") As listaCONTROL_QUEMA
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        strSQL.Append("SELECT * FROM CONTROL_QUEMA ")

        If ID_ZAFRA <> -1 Then
            arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
            arg.Value = ID_ZAFRA
            args.Add(arg)
            AgregarCondicion(strCond, "ID_ZAFRA = @ID_ZAFRA")
        End If
        If ACCESLOTE <> "" Then
            arg = New SqlParameter("@ACCESLOTE", SqlDbType.Char)
            arg.Value = ACCESLOTE
            args.Add(arg)
            AgregarCondicion(strCond, "ACCESLOTE = @ACCESLOTE")
        End If
        strSQL.Append(strCond.ToString)

        If asColumnaOrden = "" Then
            strSQL.Append(" ORDER BY ID_CONTROL_QUEMA DESC")
        Else
            strSQL.Append(" ORDER BY " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaCONTROL_QUEMA

        Try
            Do While dr.Read()
                Dim mEntidad As New CONTROL_QUEMA
                dbAsignarEntidades.AsignarCONTROL_QUEMA(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista
    End Function

    Public Function ObtenerSaldoTipoQuemaPorZAFRA_LOTE(ByVal ID_ZAFRA As Int32, _
                                             ByVal ACCESLOTE As String) As Dictionary(Of String, Decimal)
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        strSQL.AppendLine("SELECT  ")
        strSQL.AppendLine("	(SELECT ISNULL(SUM(SALDO),0) FROM CONTROL_QUEMA_SALDO WHERE ID_ZAFRA = @ID_ZAFRA AND ACCESLOTE = @ACCESLOTE AND QUEMA_PROGRAMADA = 1) AS QUEMA_PROGRAMADA, ")
        strSQL.AppendLine("	(SELECT ISNULL(SUM(SALDO),0) FROM CONTROL_QUEMA_SALDO WHERE ID_ZAFRA = @ID_ZAFRA AND ACCESLOTE = @ACCESLOTE AND QUEMA_NOPROG = 1) AS QUEMA_NOPROG, ")
        strSQL.AppendLine("	(SELECT ISNULL(SUM(SALDO),0) FROM CONTROL_QUEMA_SALDO WHERE ID_ZAFRA = @ID_ZAFRA AND ACCESLOTE = @ACCESLOTE AND CANA_VERDE = 1) AS CANA_VERDE ")

        If ID_ZAFRA <> -1 Then
            arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
            arg.Value = ID_ZAFRA
            args.Add(arg)
        End If
        If ACCESLOTE <> "" Then
            arg = New SqlParameter("@ACCESLOTE", SqlDbType.Char)
            arg.Value = ACCESLOTE
            args.Add(arg)
        End If
        strSQL.Append(strCond.ToString)

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New Dictionary(Of String, Decimal)

        Try
            If dr.Read() Then
                lista.Add("QUEMA_PROGRAMADA", dr("QUEMA_PROGRAMADA"))
                lista.Add("QUEMA_NOPROG", dr("QUEMA_NOPROG"))
                lista.Add("CANA_VERDE", dr("CANA_VERDE"))
            End If
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista
    End Function

    Public Function ObtenerSaldoQuemaPorZAFRA_LOTE(ByVal ID_ZAFRA As Int32,
                                             ByVal ACCESLOTE As String) As Decimal
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        Dim lRet As Decimal = 0

        strSQL.AppendLine("SELECT ISNULL(SUM(SALDO),0) FROM CONTROL_QUEMA_SALDO WHERE ID_ZAFRA = @ID_ZAFRA AND ACCESLOTE = @ACCESLOTE ")


        If ID_ZAFRA <> -1 Then
            arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
            arg.Value = ID_ZAFRA
            args.Add(arg)
        End If
        If ACCESLOTE <> "" Then
            arg = New SqlParameter("@ACCESLOTE", SqlDbType.Char)
            arg.Value = ACCESLOTE
            args.Add(arg)
        End If
        strSQL.Append(strCond.ToString)

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Try
            If dr.Read() Then
                lRet = CDec(dr(0))
            End If
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lRet
    End Function


    Public Function ObtenerSaldoQuemaPorZAFRA_LOTE_PORCION(ByVal ID_ZAFRA As Int32,
                                             ByVal ACCESLOTE As String,
                                             ByVal ID_SUBLOTES As Int32) As Decimal
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        Dim lRet As Decimal = 0

        strSQL.AppendLine("SELECT ISNULL(SUM(SALDO),0) FROM CONTROL_QUEMA_SALDO WHERE ID_ZAFRA = @ID_ZAFRA AND ACCESLOTE = @ACCESLOTE AND ID_SUBLOTES = @ID_SUBLOTES ")


        If ID_ZAFRA <> -1 Then
            arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
            arg.Value = ID_ZAFRA
            args.Add(arg)
        End If
        If ACCESLOTE <> "" Then
            arg = New SqlParameter("@ACCESLOTE", SqlDbType.Char)
            arg.Value = ACCESLOTE
            args.Add(arg)
        End If
        If ID_SUBLOTES > 0 Then
            arg = New SqlParameter("@ID_SUBLOTES", SqlDbType.Int)
            arg.Value = ID_SUBLOTES
            args.Add(arg)
        End If
        strSQL.Append(strCond.ToString)

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Try
            If dr.Read() Then
                lRet = CDec(dr(0))
            End If
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lRet
    End Function

End Class
