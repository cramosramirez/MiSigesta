Partial Public Class dbCATORCENA_ZAFRA
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla CATORCENA_ZAFRA que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde viene se obtienen los valores de la llave 
    ''' primaria del registro a eliminar.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el 
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overloads Function Eliminar(ByVal aEntidad As entidadBase, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Dim lRet As Integer
        Dim strSQL As New StringBuilder
        Dim args(0) As SqlParameter

        strSQL.Append(Me.QueryDelete(aEntidad, args, aTipoConcurrencia))

        lRet = SqlHelper.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        If lRet > 1 Then lRet = 1
        Return lRet
    End Function


    Public Function ObtenerUltimaCatorcenaCerradaZafra(ByVal ID_ZAFRA As Integer) As CATORCENA_ZAFRA
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim listadoDiasZafra As New listaDIA_ZAFRA
        strSQL.Append("SELECT TOP 1 *  ")
        strSQL.Append("FROM CATORCENA_ZAFRA ")
        strSQL.Append("WHERE ID_ZAFRA = @ID_ZAFRA ")
        strSQL.Append("ORDER BY CATORCENA DESC ")

        arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        arg.Value = ID_ZAFRA
        args.Add(arg)

        Dim aEntidad As New CATORCENA_ZAFRA
        Dim dr As IDataReader
        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Try
            If dr.Read() Then
                dbAsignarEntidades.AsignarCATORCENA_ZAFRA(dr, aEntidad)
            Else
                Return Nothing
            End If

        Catch ex As Exception
            Throw ex

        Finally
            dr.Close()
        End Try

        Return aEntidad
    End Function

    Public Function Obtener(ByVal ID_ZAFRA As Integer) As CATORCENA_ZAFRA
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim listadoDiasZafra As New listaDIA_ZAFRA
        strSQL.Append("SELECT TOP 1 *  ")
        strSQL.Append("FROM CATORCENA_ZAFRA ")
        strSQL.Append("WHERE ID_ZAFRA = @ID_ZAFRA ")
        strSQL.Append("ORDER BY CATORCENA DESC ")

        arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        arg.Value = ID_ZAFRA
        args.Add(arg)

        Dim aEntidad As New CATORCENA_ZAFRA
        Dim dr As IDataReader
        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Try
            If dr.Read() Then
                dbAsignarEntidades.AsignarCATORCENA_ZAFRA(dr, aEntidad)
            Else
                Return Nothing
            End If

        Catch ex As Exception
            Throw ex

        Finally
            dr.Close()
        End Try

        Return aEntidad
    End Function


    Public Function GENERAR_PLANILLA_CATORCENA(ByVal ID_ZAFRA As Int32, ByVal ID_CATORCENA As Int32, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime) As Int32
        Dim lRet As Int32 = 0

        Dim cnLocal As New SqlConnection(Me.cnnStr)
        Dim cmd As New SqlCommand()
        cnLocal.Open()
        cmd.Connection = cnLocal

        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter


        arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        arg.Value = ID_ZAFRA
        args.Add(arg)
        cmd.Parameters.Add(arg)

        arg = New SqlParameter("@ID_CATORCENA", SqlDbType.Int)
        arg.Value = ID_CATORCENA
        args.Add(arg)
        cmd.Parameters.Add(arg)

        arg = New SqlParameter("@USUARIO_CREA", SqlDbType.VarChar)
        arg.Value = USUARIO_CREA
        args.Add(arg)
        cmd.Parameters.Add(arg)

        arg = New SqlParameter("@FECHA_CREA", SqlDbType.DateTime)
        arg.Value = FECHA_CREA
        args.Add(arg)
        cmd.Parameters.Add(arg)

        Try

            cmd.CommandText = "dbo.GENERAR_PLANILLA_CATORCENA"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandTimeout = 900000
            cmd.ExecuteNonQuery()
            cnLocal.Close()
            cnLocal = Nothing

            Return 1

        Catch ex As Exception
            Throw ex
        End Try

        Return lRet
    End Function
End Class
