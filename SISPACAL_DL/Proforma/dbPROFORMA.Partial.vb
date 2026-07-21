Partial Public Class dbPROFORMA

    Public Function ObtenerNoProformaPorZafra(ByVal ID_ZAFRA As Int32) As Int32
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim lRet As Int32

        strSQL.Append("SELECT ISNULL(MAX(NOPROFORMA),0) + 1 AS CORRELATIVO ")
        strSQL.Append("FROM PROFORMA ")
        strSQL.Append("WHERE ID_ZAFRA = @ID_ZAFRA ")

        arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        arg.Value = ID_ZAFRA
        args.Add(arg)

        Try
            lRet = SqlHelper.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Catch ex As Exception
            Throw ex
        End Try

        Return lRet
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
    ''' 	[GenApp]	11/12/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorTIPO_CANA(ByVal ID_TIPO_CANA As Int32, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaPROFORMA

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New PROFORMA))
        strSQL.Append(" WHERE ID_TIPO_CANA = @ID_TIPO_CANA ")
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_TIPO_CANA", SqlDbType.Int)
        args(0).Value = ID_TIPO_CANA

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaPROFORMA

        Try
            Do While dr.Read()
                Dim mEntidad As New PROFORMA
                dbAsignarEntidades.AsignarPROFORMA(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    Public Function ObtenerListaPorZAFRA_PLACAVEHIC(ByVal ID_ZAFRA As Int32, ByVal PLACAVEHIC As String, ByVal SOLO_EN_PROCESO As Boolean, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaPROFORMA
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New PROFORMA))
        strSQL.Append(" WHERE ID_ZAFRA = @ID_ZAFRA AND RTRIM(REPLACE(PLACAVEHIC,'-','')) = @PLACAVEHIC ")
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        arg.Value = ID_ZAFRA
        args.Add(arg)

        arg = New SqlParameter("@PLACAVEHIC", SqlDbType.Char)
        arg.Value = Trim(Replace(PLACAVEHIC, "-", ""))
        args.Add(arg)

        If SOLO_EN_PROCESO Then
            strSQL.Append(" AND ESTADO IN('TTO','RUEDA','ENVIO') ")
        End If

        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaPROFORMA

        Try
            Do While dr.Read()
                Dim mEntidad As New PROFORMA
                dbAsignarEntidades.AsignarPROFORMA(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    Public Function ObtenerPROFORMAPorNumZafra(ByVal NOPROFORMA As Int32, ByVal ID_ZAFRA As Int32) As PROFORMA

        Dim strSQL As New StringBuilder
        Dim args As New List(Of SqlParameter)
        Dim arg As New SqlParameter

        strSQL.Append("SELECT * ")
        strSQL.Append("FROM PROFORMA ")
        strSQL.Append("WHERE NOPROFORMA = @NOPROFORMA ")
        strSQL.Append("AND ID_ZAFRA = @ID_ZAFRA ")

        arg = New SqlParameter("@NOPROFORMA", SqlDbType.Int)
        arg.Value = NOPROFORMA
        args.Add(arg)

        arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        arg.Value = ID_ZAFRA
        args.Add(arg)

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim mEntidad As PROFORMA

        Try
            If dr.Read() Then
                mEntidad = New PROFORMA
                dbAsignarEntidades.AsignarPROFORMA(dr, mEntidad)
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



    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerListaPorCriterios(ByVal ID_ZAFRA As Int32,
                                            ByVal NOPROFORMA As Int32,
                                            ByVal ACCESLOTE As String,
                                            ByVal ESTADO As String,
                                            Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaPROFORMA
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        strSQL.Append("SELECT * FROM PROFORMA ")

        If ID_ZAFRA <> -1 Then
            arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
            arg.Value = ID_ZAFRA
            args.Add(arg)
            AgregarCondicion(strCond, "ID_ZAFRA = @ID_ZAFRA")
        End If
        If NOPROFORMA <> -1 Then
            arg = New SqlParameter("@NOPROFORMA", SqlDbType.Int)
            arg.Value = NOPROFORMA
            args.Add(arg)
            AgregarCondicion(strCond, "NOPROFORMA = @NOPROFORMA")
        End If
        If ACCESLOTE <> "" Then
            arg = New SqlParameter("@ACCESLOTE", SqlDbType.Char)
            arg.Value = ACCESLOTE
            args.Add(arg)
            AgregarCondicion(strCond, "ACCESLOTE = @ACCESLOTE")
        End If
        If ESTADO <> "" Then
            arg = New SqlParameter("@ESTADO", SqlDbType.Char)
            arg.Value = ESTADO
            args.Add(arg)
            AgregarCondicion(strCond, "ESTADO = @ESTADO")
        End If

        strSQL.Append(strCond.ToString)
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As IDataReader

        If args.Count > 0 Then
            dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
        Else
            dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        End If

        Dim lista As New listaPROFORMA

        Try
            Do While dr.Read()
                Dim mEntidad As New PROFORMA
                dbAsignarEntidades.AsignarPROFORMA(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista
    End Function

    Public Function SP_CC_ASIGNAR_LOTE_TRANS(ByVal OPCION As String, ByVal ID_ZAFRA As Integer, ByVal ID_MOTORISTA_VEHI As Integer, ByVal ID_ASIGNACION As Integer, ByVal USUARIO As String, ByVal ID_PROFORMA As Integer) As DataSet
        Dim connection As New SqlConnection
        Dim command As New SqlCommand
        Dim adapter As New SqlDataAdapter
        Dim arg As SqlParameter
        Dim ds As New DataSet

        Try

            connection = New SqlConnection(Me.cnnStr)
            connection.Open()
            command = New SqlCommand()
            command.Connection = connection
            command.CommandText = "SP_CC_ASIGNAR_LOTE_TRANS"
            command.CommandType = CommandType.StoredProcedure
            command.CommandTimeout = 90000000

            arg = New SqlParameter("@OPCION", OPCION)
            command.Parameters.Add(arg)
            arg = New SqlParameter("@ID_ZAFRA", ID_ZAFRA)
            command.Parameters.Add(arg)
            arg = New SqlParameter("@ID_MOTORISTA_VEHI", ID_MOTORISTA_VEHI)
            command.Parameters.Add(arg)
            arg = New SqlParameter("@ID_ASIGNACION", ID_ASIGNACION)
            command.Parameters.Add(arg)
            arg = New SqlParameter("@USUARIO", USUARIO)
            command.Parameters.Add(arg)
            arg = New SqlParameter("@ID_PROFORMA", ID_PROFORMA)
            command.Parameters.Add(arg)

            adapter.SelectCommand = command
            adapter.Fill(ds)
            adapter.Dispose()
            command.Dispose()
            connection.Close()


        Catch ex As Exception
            Throw ex
        Finally
            command.Dispose()
            connection.Close()
        End Try

        Return ds

    End Function

End Class
