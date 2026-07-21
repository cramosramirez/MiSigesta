Imports SISPACAL.EL.Enumeradores

Partial Public Class dbREQENCA

    Public Function ObtenerNoSolicitudPorPeriodo(ByVal ID_PERIODOREQ As Int32) As Int32
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim lRet As Int32

        strSQL.Append("SELECT ISNULL(MAX(NO_REQ),0) + 1 AS CORRELATIVO ")
        strSQL.Append("FROM REQENCA ")
        strSQL.Append("WHERE ID_PERIODOREQ = @ID_PERIODOREQ ")

        arg = New SqlParameter("@ID_PERIODOREQ", SqlDbType.Int)
        arg.Value = ID_PERIODOREQ
        args.Add(arg)

        Try
            lRet = SqlHelper.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Catch ex As Exception
            Throw ex
        End Try

        Return lRet
    End Function


    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCriterios(ByVal ID_PERIODOREQ As Int32, ByVal NO_REQ As Int32, ByVal CODI_REQ As String, ByVal ID_SECCION As Int32, ByVal ID_SOLICITANTE As Int32, _
                                             ByVal ID_REQETAPA As Int32) As listaREQENCA
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        strSQL.Append("SELECT * ")
        strSQL.Append("FROM REQENCA ")

        If ID_PERIODOREQ <> -1 Then
            arg = New SqlParameter("@ID_PERIODOREQ", SqlDbType.Int)
            arg.Value = ID_PERIODOREQ
            args.Add(arg)
            AgregarCondicion(strCond, "ID_PERIODOREQ = @ID_PERIODOREQ")
        End If
        If NO_REQ <> -1 Then
            arg = New SqlParameter("@NO_REQ", SqlDbType.Int)
            arg.Value = NO_REQ
            args.Add(arg)
            AgregarCondicion(strCond, "NO_REQ = @NO_REQ")
        End If
        If CODI_REQ <> "" Then
            arg = New SqlParameter("@CODI_REQ", SqlDbType.Char)
            arg.Value = CODI_REQ
            args.Add(arg)
            AgregarCondicion(strCond, "CODI_REQ = @CODI_REQ")
        End If
        If ID_SECCION <> -1 Then
            arg = New SqlParameter("@ID_SECCION", SqlDbType.Int)
            arg.Value = ID_SECCION
            args.Add(arg)
            AgregarCondicion(strCond, "ID_SECCION = @ID_SECCION")
        End If
        If ID_SOLICITANTE <> -1 Then
            arg = New SqlParameter("@ID_SOLICITANTE", SqlDbType.Int)
            arg.Value = ID_SOLICITANTE
            args.Add(arg)
            AgregarCondicion(strCond, "ID_SOLICITANTE = @ID_SOLICITANTE")
        End If
        If ID_REQETAPA <> -1 Then
            arg = New SqlParameter("@ID_REQETAPA", SqlDbType.Int)
            arg.Value = ID_REQETAPA
            args.Add(arg)
            AgregarCondicion(strCond, "ID_REQETAPA = @ID_REQETAPA")
        End If

        strSQL.Append(strCond.ToString)
        strSQL.Append("ORDER BY ID_PERIODOREQ, NO_REQ")

        Dim dr As IDataReader

        If args.Count > 0 Then
            dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
        Else
            dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        End If

        Dim lista As New listaREQENCA

        Try
            Do While dr.Read()
                Dim mEntidad As New REQENCA
                dbAsignarEntidades.AsignarREQENCA(dr, mEntidad)
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
