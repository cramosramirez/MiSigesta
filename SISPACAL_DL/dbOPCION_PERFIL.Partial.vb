Partial Public Class dbOPCION_PERFIL


    Public Function ObtenerOPCION_PERFILporOpcionPerfil(ByVal ID_OPCION As Int32, ByVal ID_PERFIL As Int32) As OPCION_PERFIL

        Dim strSQL As New StringBuilder
        Dim args As New List(Of SqlParameter)
        Dim arg As New SqlParameter

        strSQL.Append("SELECT * ")
        strSQL.Append("FROM OPCION_PERFIL ")
        strSQL.Append("WHERE ID_OPCION = @ID_OPCION ")
        strSQL.Append("AND ID_PERFIL = @ID_PERFIL ")

        arg = New SqlParameter("@ID_OPCION", SqlDbType.Int)
        arg.Value = ID_OPCION
        args.Add(arg)
        arg = New SqlParameter("@ID_PERFIL", SqlDbType.Int)
        arg.Value = ID_PERFIL
        args.Add(arg)

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim mEntidad As OPCION_PERFIL

        Try
            If dr.Read() Then
                mEntidad = New OPCION_PERFIL
                dbAsignarEntidades.AsignarOPCION_PERFIL(dr, mEntidad)
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

    Public Function ObtenerListaOPCION_PERFILporOpcionPadrePerfil(ByVal ID_OPCION_PADRE As Int32, ByVal ID_PERFIL As Int32) As listaOPCION_PERFIL

        Dim strSQL As New StringBuilder
        Dim args As New List(Of SqlParameter)
        Dim arg As New SqlParameter

        strSQL.Append("SELECT * ")
        strSQL.Append("FROM OPCION_PERFIL ")
        strSQL.Append("WHERE ID_PERFIL = @ID_PERFIL ")
        strSQL.Append("AND EXISTS(SELECT 1 FROM OPCION P WHERE P.ID_OPCION = OPCION_PERFIL.ID_OPCION AND P.ID_OPCION_PADRE = @ID_OPCION_PADRE) ")

        arg = New SqlParameter("@ID_PERFIL", SqlDbType.Int)
        arg.Value = ID_PERFIL
        args.Add(arg)
        arg = New SqlParameter("@ID_OPCION_PADRE", SqlDbType.Int)
        arg.Value = ID_OPCION_PADRE
        args.Add(arg)

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaOPCION_PERFIL

        Try
            Do While dr.Read()
                Dim mEntidad As New OPCION_PERFIL
                dbAsignarEntidades.AsignarOPCION_PERFIL(dr, mEntidad)
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
