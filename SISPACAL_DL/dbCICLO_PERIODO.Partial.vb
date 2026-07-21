Partial Public Class dbCICLO_PERIODO
    Public Function ObtenerCICLO_PERIODOPorFechaTipo(ByVal FECHA As Date, ByVal TIPO_CICLO As Int32) As CICLO_PERIODO

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT * FROM CICLO_PERIODO ")
        strSQL.Append("WHERE FECHA = @FECHA ")
        strSQL.Append("AND EXISTS(SELECT 1 FROM CICLO C WHERE C.ID_CICLO = CICLO_PERIODO.ID_CICLO AND C.TIPO_CICLO = @TIPO_CICLO) ")


        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@FECHA", SqlDbType.DateTime)
        args(0).Value = FECHA

        args(1) = New SqlParameter("@TIPO_CICLO", SqlDbType.Int)
        args(1).Value = TIPO_CICLO

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim mEntidad As New CICLO_PERIODO

        Try
            If dr.Read() Then
                dbAsignarEntidades.AsignarCICLO_PERIODO(dr, mEntidad)
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


    Public Function ObtenerCatorcenasPorZAFRA_TIPO_CICLO(ByVal ID_ZAFRA As Int32, ByVal TIPO_CICLO As Int32) As List(Of Int32)

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT DISTINCT CATORCENA ")
        strSQL.Append("FROM CICLO_PERIODO ")
        strSQL.Append("WHERE  ")
        strSQL.Append("EXISTS(  SELECT 1 FROM CICLO C ")
        strSQL.Append("         WHERE C.ID_CICLO = CICLO_PERIODO.ID_CICLO ")
        strSQL.Append("         AND C.ID_ZAFRA = @ID_ZAFRA ")
        strSQL.Append("         AND C.TIPO_CICLO = @TIPO_CICLO ")
        strSQL.Append("     ) ")
        strSQL.Append("ORDER BY CATORCENA ")


        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        args(0).Value = ID_ZAFRA

        args(1) = New SqlParameter("@TIPO_CICLO", SqlDbType.Int)
        args(1).Value = TIPO_CICLO

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New List(Of Int32)

        Try
            While dr.Read
                lista.Add(dr(0))
            End While

        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    Public Function ObtenerSemanasPorZAFRA_TIPO_CICLO_CATORCENA(ByVal ID_ZAFRA As Int32, ByVal TIPO_CICLO As Int32, ByVal CATORCENA As Int32) As List(Of Int32)

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT DISTINCT SEMANA ")
        strSQL.Append("FROM CICLO_PERIODO ")
        strSQL.Append("WHERE  ")
        strSQL.Append("EXISTS(  SELECT 1 FROM CICLO C ")
        strSQL.Append("         WHERE C.ID_CICLO = CICLO_PERIODO.ID_CICLO ")
        strSQL.Append("         AND C.ID_ZAFRA = @ID_ZAFRA ")
        strSQL.Append("         AND C.TIPO_CICLO = @TIPO_CICLO ")
        strSQL.Append("     ) ")
        strSQL.Append("AND CATORCENA = @CATORCENA ")
        strSQL.Append("ORDER BY SEMANA ")


        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter

        arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        arg.Value = ID_ZAFRA
        args.Add(arg)

        arg = New SqlParameter("@TIPO_CICLO", SqlDbType.Int)
        arg.Value = TIPO_CICLO
        args.Add(arg)

        arg = New SqlParameter("@CATORCENA", SqlDbType.Int)
        arg.Value = CATORCENA
        args.Add(arg)

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New List(Of Int32)

        Try
            While dr.Read
                lista.Add(dr(0))
            End While

        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    Public Function ObtenerFechaInicialFinalCatorcena(ByVal ID_ZAFRA As Int32, ByVal TIPO_CICLO As Int32, ByVal CATORCENA As Int32) As List(Of DateTime)

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT MIN(FECHA) AS FECHA_INI, MAX(FECHA) AS FECHA_FIN ")
        strSQL.Append("FROM CICLO_PERIODO ")
        strSQL.Append("WHERE CATORCENA = @CATORCENA ")
        strSQL.Append("AND EXISTS(  SELECT 1 FROM CICLO C ")
        strSQL.Append("         WHERE C.ID_CICLO = CICLO_PERIODO.ID_CICLO ")
        strSQL.Append("         AND C.ID_ZAFRA = @ID_ZAFRA ")
        strSQL.Append("         AND C.TIPO_CICLO = @TIPO_CICLO ")
        strSQL.Append("     ) ")


        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        args(0).Value = ID_ZAFRA

        args(1) = New SqlParameter("@TIPO_CICLO", SqlDbType.Int)
        args(1).Value = TIPO_CICLO

        args(2) = New SqlParameter("@CATORCENA", SqlDbType.Int)
        args(2).Value = CATORCENA

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New List(Of DateTime)

        Try
            If dr.Read() Then
                lista.Add(dr(0))
                lista.Add(dr(1))
            Else
                lista = Nothing
            End If
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista


    End Function


    Public Function ObtenerListaPorCriterios(ByVal ID_ZAFRA As Int32, _
                                             ByVal TIPO_CICLO As Int32, _
                                             ByVal CATORCENA As Int32, _
                                             ByVal SEMANA As Int32, _
                                             ByVal FECHA As DateTime, _
                                             Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaCICLO_PERIODO

        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        strSQL.Append("SELECT * FROM CICLO_PERIODO CP ")

        If ID_ZAFRA <> -1 AndAlso TIPO_CICLO <> -1 Then
            arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
            arg.Value = ID_ZAFRA
            args.Add(arg)

            arg = New SqlParameter("@TIPO_CICLO", SqlDbType.Int)
            arg.Value = TIPO_CICLO
            args.Add(arg)

            AgregarCondicion(strCond, "EXISTS(SELECT 1 FROM CICLO C WHERE C.ID_ZAFRA = @ID_ZAFRA AND C.TIPO_CICLO = @TIPO_CICLO AND C.ID_CICLO = CP.ID_CICLO)")
        End If

        If CATORCENA <> -1 Then
            arg = New SqlParameter("@CATORCENA", SqlDbType.Int)
            arg.Value = CATORCENA
            args.Add(arg)
            AgregarCondicion(strCond, "CP.CATORCENA = @CATORCENA")
        End If
        If SEMANA <> -1 Then
            arg = New SqlParameter("@SEMANA", SqlDbType.Int)
            arg.Value = SEMANA
            args.Add(arg)
            AgregarCondicion(strCond, "CP.SEMANA = @SEMANA")
        End If
        If FECHA <> #12:00:00 AM# Then
            arg = New SqlParameter("@FECHA", SqlDbType.DateTime)
            arg.Value = FECHA
            args.Add(arg)
            AgregarCondicion(strCond, "CP.FECHA = @FECHA")
        End If
        strSQL.AppendLine(strCond.ToString)

        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaCICLO_PERIODO

        Try
            Do While dr.Read()
                Dim mEntidad As New CICLO_PERIODO
                dbAsignarEntidades.AsignarCICLO_PERIODO(dr, mEntidad)
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
