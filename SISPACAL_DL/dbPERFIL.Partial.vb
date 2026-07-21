Partial Public Class dbPERFIL

    Public Function ObtenerPERFILES_SIN_OPCION(ByVal ID_OPCION As Int32) As listaPERFIL
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder

        strSQL.Append("SELECT * ")
        strSQL.Append("FROM PERFIL P ")
        strSQL.Append("WHERE NOT EXISTS(SELECT 1 FROM OPCION_PERFIL OP WHERE OP.ID_PERFIL = P.ID_PERFIL) ")

        arg = New SqlParameter("@ID_OPCION", SqlDbType.Int)
        arg.Value = ID_OPCION
        args.Add(arg)

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaPERFIL

        Try
            Do While dr.Read()
                Dim mEntidad As New PERFIL
                dbAsignarEntidades.AsignarPERFIL(dr, mEntidad)
                lista.Add(mEntidad)
            Loop

        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    Public Function ObtenerPERFILPorUsuario(ByVal USUARIO As String) As PERFIL
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder

        strSQL.Append("SELECT * ")
        strSQL.Append("FROM PERFIL P ")
        strSQL.Append("WHERE EXISTS(SELECT 1 FROM USUARIO U WHERE U.USUARIO = @USUARIO AND U.ID_PERFIL = P.ID_PERFIL) ")

        arg = New SqlParameter("@USUARIO", SqlDbType.VarChar)
        arg.Value = USUARIO
        args.Add(arg)

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
        Dim mEntidad As New PERFIL

        Try
            If dr.Read() Then
                dbAsignarEntidades.AsignarPERFIL(dr, mEntidad)
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
