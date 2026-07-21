Partial Public Class dbFILTRO_CANTON
    Public Function EliminarFiltroPorUsuarioFecha(ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime) As Integer
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim listadoDiasZafra As New listaDIA_ZAFRA
        strSQL.Append("DELETE FROM FILTRO_CANTON WHERE USUARIO_CREA = @USUARIO_CREA AND FECHA_CREA <= @FECHA_CREA ")

        arg = New SqlParameter("@USUARIO_CREA", SqlDbType.VarChar)
        arg.Value = USUARIO_CREA
        args.Add(arg)

        arg = New SqlParameter("@FECHA_CREA", SqlDbType.DateTime)
        arg.Value = FECHA_CREA
        args.Add(arg)

        Dim lRet As Int32

        lRet = SqlHelper.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Try
            Return lRet

        Catch ex As Exception
            Throw ex
        End Try
    End Function


    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorUsuarioFecha(ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime) As listaFILTRO_CANTON
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        strSQL.Append("SELECT * ")
        strSQL.Append("FROM FILTRO_CANTON ")

        If USUARIO_CREA <> "" Then
            arg = New SqlParameter("@USUARIO_CREA", SqlDbType.VarChar)
            arg.Value = USUARIO_CREA
            args.Add(arg)
            AgregarCondicion(strCond, "USUARIO_CREA = @USUARIO_CREA")
        End If
        If FECHA_CREA <> #12:00:00 AM# Then
            arg = New SqlParameter("@FECHA_CREA", SqlDbType.DateTime)
            arg.Value = FECHA_CREA
            args.Add(arg)
            AgregarCondicion(strCond, "FECHA_CREA = @FECHA_CREA")
        End If
        strSQL.Append(strCond.ToString)

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaFILTRO_CANTON

        Try
            Do While dr.Read()
                Dim mEntidad As New FILTRO_CANTON
                dbAsignarEntidades.AsignarFILTRO_CANTON(dr, mEntidad)
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
