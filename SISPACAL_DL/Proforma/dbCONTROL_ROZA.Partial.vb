Partial Public Class dbCONTROL_ROZA


    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorZAFRA_LOTE(ByVal ID_ZAFRA As Int32, _
                                             ByVal ACCESLOTE As String, _
                                             Optional asColumnaOrden As String = "", _
                                             Optional asTipoOrden As String = "ASC") As listaCONTROL_ROZA
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        strSQL.Append("SELECT * FROM CONTROL_ROZA ")


        arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        arg.Value = ID_ZAFRA
        args.Add(arg)
        AgregarCondicion(strCond, "ID_ZAFRA = @ID_ZAFRA")

        arg = New SqlParameter("@ACCESLOTE", SqlDbType.Char)
        arg.Value = ACCESLOTE
        args.Add(arg)
        AgregarCondicion(strCond, "ACCESLOTE = @ACCESLOTE")

        strSQL.Append(strCond.ToString)

        If asColumnaOrden = "" Then
            strSQL.Append(" ORDER BY ID_CONTROL_ROZA DESC")
        Else
            strSQL.Append(" ORDER BY " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaCONTROL_ROZA

        Try
            Do While dr.Read()
                Dim mEntidad As New CONTROL_ROZA
                dbAsignarEntidades.AsignarCONTROL_ROZA(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista
    End Function

    Public Function ObtenerListaPorPLAN_COSECHA(ByVal ID_PLAN_COSECHA As Int32, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaCONTROL_ROZA

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New CONTROL_ROZA))
        strSQL.Append(" WHERE ID_PLAN_COSECHA = @ID_PLAN_COSECHA ")
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_PLAN_COSECHA", SqlDbType.Int)
        args(0).Value = ID_PLAN_COSECHA

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaCONTROL_ROZA

        Try
            Do While dr.Read()
                Dim mEntidad As New CONTROL_ROZA
                dbAsignarEntidades.AsignarCONTROL_ROZA(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    Public Function ObtenerSaldoRozaPorZAFRA_LOTE(ByVal ID_ZAFRA As Int32, _
                                             ByVal ACCESLOTE As String) As Decimal
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        Dim lRet As Decimal = 0

        strSQL.AppendLine("SELECT ISNULL(SUM(SALDO),0) FROM CONTROL_ROZA_SALDO WHERE ID_ZAFRA = @ID_ZAFRA AND ACCESLOTE = @ACCESLOTE ")


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


    Public Function ObtenerPorIdREF_CodigoREF(ByVal ID_REF As Int32, _
                                             ByVal CODIGO_REF As String) As CONTROL_ROZA
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        strSQL.Append("SELECT * FROM CONTROL_ROZA ")

        arg = New SqlParameter("@ID_REF", SqlDbType.Int)
        arg.Value = ID_REF
        args.Add(arg)
        AgregarCondicion(strCond, "ID_REF = @ID_REF")

        arg = New SqlParameter("@CODIGO_REF", SqlDbType.Char)
        arg.Value = CODIGO_REF
        args.Add(arg)
        AgregarCondicion(strCond, "CODIGO_REF = @CODIGO_REF")

        strSQL.Append(strCond.ToString)

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim mEntidad As New CONTROL_ROZA

        Try
            If dr.Read() Then
                dbAsignarEntidades.AsignarCONTROL_ROZA(dr, mEntidad)
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

    Public Function ObtenerSaldoRozaPorTipoQuemaPorZAFRA_LOTE(ByVal ID_ZAFRA As Int32, _
                                            ByVal ACCESLOTE As String) As Dictionary(Of String, Decimal)
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        strSQL.AppendLine("SELECT  ")
        strSQL.AppendLine("	(SELECT ISNULL(SUM(SALDO),0) FROM CONTROL_ROZA_SALDO WHERE ID_ZAFRA = @ID_ZAFRA AND ACCESLOTE = @ACCESLOTE AND QUEMA_PROGRAMADA = 1) AS QUEMA_PROGRAMADA, ")
        strSQL.AppendLine("	(SELECT ISNULL(SUM(SALDO),0) FROM CONTROL_ROZA_SALDO WHERE ID_ZAFRA = @ID_ZAFRA AND ACCESLOTE = @ACCESLOTE AND QUEMA_NOPROG = 1) AS QUEMA_NOPROG, ")
        strSQL.AppendLine("	(SELECT ISNULL(SUM(SALDO),0) FROM CONTROL_ROZA_SALDO WHERE ID_ZAFRA = @ID_ZAFRA AND ACCESLOTE = @ACCESLOTE AND CANA_VERDE = 1) AS CANA_VERDE ")

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

    Public Function ObtenerRozaEjecutadaPorZAFRA_LOTE(ByVal ID_ZAFRA As Int32, _
                                             ByVal ACCESLOTE As String) As Decimal
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        Dim lRet As Decimal = 0

        strSQL.AppendLine("SELECT ISNULL(SUM(ENTRADAS),0) - ISNULL(SUM(SALIDAS),0) FROM CONTROL_ROZA WHERE ID_ZAFRA = @ID_ZAFRA AND ACCESLOTE = @ACCESLOTE AND CODIGO_REF IN('ROZADIA','PROYECCION','AJUSTE')")


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
End Class
