Public Class dbENVIO_ROZA_PS
    Inherits dbBase


    Public Overrides Function Actualizar(aEntidad As entidadBase) As Integer
        Return Me.Actualizar(aEntidad, TipoConcurrencia.Pesimistica)
    End Function

    Public Overloads Function Actualizar(ByVal aEntidad As entidadBase, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer

        Dim lEntidad As ENVIO_ROZA_PS
        lEntidad = CType(aEntidad, ENVIO_ROZA_PS)

        Dim lID As Int32
        If lEntidad.ID_ENVIO_ROZA = 0 _
            Or lEntidad.ID_ENVIO_ROZA = Nothing Then


            Return Agregar(lEntidad)

        End If

        Dim strSQL As New StringBuilder


        Dim args(0) As SqlParameter

        strSQL.Append(Me.QueryUpdate(aEntidad, args, aTipoConcurrencia))

        Return SqlHelper.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Agregar(aEntidad As entidadBase) As Integer
        Dim strSQL As New StringBuilder


        Dim args(0) As SqlParameter

        strSQL.Append(Me.QueryInsert(aEntidad, args))


        Return SqlHelper.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
    End Function

    Public Overrides Function Eliminar(aEntidad As entidadBase) As Integer
        Return Me.Eliminar(aEntidad, TipoConcurrencia.Pesimistica)
    End Function

    Public Overloads Function Eliminar(ByVal aEntidad As entidadBase, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer

        Dim strSQL As New StringBuilder
        Dim args(0) As SqlParameter

        strSQL.Append(Me.QueryDelete(aEntidad, args, aTipoConcurrencia))

        Return SqlHelper.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Recuperar(aEntidad As entidadBase) As Integer
        Dim strSQL As New StringBuilder
        Dim args(0) As SqlParameter

        strSQL.Append(Me.QuerySelect(aEntidad, args))

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dr Is Nothing Then Return 0

        Try
            If dr.Read() Then
                dbAsignarEntidades.AsignarENVIO_ROZA_PS(dr, CType(aEntidad, ENVIO_ROZA_PS))
            Else
                Return 0
            End If
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return 1
    End Function

    Public Overrides Function ObtenerID(aEntidad As entidadBase) As Object
        Dim strSQL As New StringBuilder
        strSQL.AppendLine("SELECT isnull(max(ID_ENVIO_ROZA),0) + 1 ")
        strSQL.AppendLine(" FROM ENVIO_ROZA_PS ")

        Return SqlHelper.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString())
    End Function

    Public Function ObtenerListaPorID(ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaENVIO_ROZA_PS

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New ENVIO_ROZA_PS))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New ListaENVIO_ROZA_PS

        Try
            Do While dr.Read()
                Dim mEntidad As New ENVIO_ROZA_PS
                dbAsignarEntidades.AsignarENVIO_ROZA_PS(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    Public Function ObtenerListaPorENVIO(ByVal ID_ENVIO As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaENVIO_ROZA_PS

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New ENVIO_ROZA_PS))
        strSQL.Append(" WHERE ID_ENVIO = @ID_ENVIO ")
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_ENVIO", SqlDbType.Int)
        args(0).Value = ID_ENVIO

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New ListaENVIO_ROZA_PS

        Try
            Do While dr.Read()
                Dim mEntidad As New ENVIO_ROZA_PS
                dbAsignarEntidades.AsignarENVIO_ROZA_PS(dr, mEntidad)
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
