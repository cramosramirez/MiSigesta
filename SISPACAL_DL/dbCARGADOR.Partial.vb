Partial Public Class dbCARGADOR
    Public Function ObtenerListaPorCARGADORA(ByVal ID_CARGADORA As Integer) As listaCARGADOR
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT R.* FROM CARGADOR R ")
        strSQL.Append("WHERE EXISTS(SELECT 1 FROM CARGADORA_ASIGNADA CA WHERE CA.ID_CARGADOR = R.ID_CARGADOR AND CA.ID_CARGADORA = @ID_CARGADORA) ")
        strSQL.Append("ORDER BY R.NOMBRE_CARGADOR")

        arg = New SqlParameter("@ID_CARGADORA", SqlDbType.Int)
        arg.Value = ID_CARGADORA
        args.Add(arg)

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaCARGADOR

        Try
            Do While dr.Read()
                Dim mEntidad As New CARGADOR
                dbAsignarEntidades.AsignarCARGADOR(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    Public Function ObtenerListaPorTIPO_CARGADORA(ByVal idTipoAlza As Int32) As listaCARGADOR
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim esEmpleado As Boolean = False
        Dim agregar As Boolean = False

        strSQL.Append("SELECT R.* FROM CARGADOR R ")
        strSQL.Append("WHERE R.ES_EMPLEADO_INGENIO = @ES_EMPLEADO_INGENIO ")
        strSQL.Append("ORDER BY R.NOMBRE_CARGADOR")

        If idTipoAlza = Enumeradores.CAT.TipoAlza.AlzaCargadoraJiboa OrElse _
            idTipoAlza = Enumeradores.CAT.TipoAlza.AlzaCosechadoraJiboa Then
            esEmpleado = True
        End If

        arg = New SqlParameter("@ES_EMPLEADO_INGENIO", SqlDbType.Bit)
        arg.Value = esEmpleado
        args.Add(arg)

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaCARGADOR

        Try
            Do While dr.Read()
                Dim mEntidad As New CARGADOR
                dbAsignarEntidades.AsignarCARGADOR(dr, mEntidad)
                agregar = True
                If (idTipoAlza = Enumeradores.CAT.TipoAlza.AlzaManualParticular OrElse _
                    idTipoAlza = Enumeradores.CAT.TipoAlza.AlzaManualProductor) AndAlso _
                    mEntidad.ID_CARGADOR <> 33 Then
                    agregar = False
                End If
                If (idTipoAlza = Enumeradores.CAT.TipoAlza.AlzaCargadoraParticular OrElse _
                    idTipoAlza = Enumeradores.CAT.TipoAlza.AlzaCosechadoraParticular) AndAlso _
                    mEntidad.ID_CARGADOR <> 60 Then
                    agregar = False
                End If
                If (idTipoAlza = Enumeradores.CAT.TipoAlza.AlzaCargadoraProductor OrElse _
                    idTipoAlza = Enumeradores.CAT.TipoAlza.AlzaCosechadoraProductor) AndAlso _
                    mEntidad.ID_CARGADOR <> 63 Then
                    agregar = False
                End If

                If agregar Then lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function


    Public Function ObtenerListaPorTRACTOR() As listaCARGADOR
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT R.* FROM CARGADOR R ")
        strSQL.Append("WHERE R.NOMBRE_CARGADOR LIKE '%TRAC%' ")
        strSQL.Append("ORDER BY R.NOMBRE_CARGADOR")

       
        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New listaCARGADOR

        Try
            Do While dr.Read()
                Dim mEntidad As New CARGADOR
                dbAsignarEntidades.AsignarCARGADOR(dr, mEntidad)
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
