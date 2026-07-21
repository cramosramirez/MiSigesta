Public Class dbSOLIC_DETA_FRENTE
    Inherits dbBase

    Public Function ObtenerListaPorID(ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLIC_DETA_FRENTE
        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLIC_DETA_FRENTE))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If
        Dim dr As IDataReader
        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        Dim lista As New listaSOLIC_DETA_FRENTE
        Try
            Do While dr.Read()
                Dim mEntidad As New SOLIC_DETA_FRENTE
                dbAsignarEntidades.AsignarSOLIC_DETA_FRENTE(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try
        Return lista
    End Function

    Public Overrides Function Actualizar(aEntidad As entidadBase) As Integer
        Return Me.Actualizar(aEntidad, TipoConcurrencia.Pesimistica)
    End Function

    Public Overloads Function Actualizar(ByVal aEntidad As entidadBase, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Dim lEntidad As SOLIC_DETA_FRENTE = CType(aEntidad, SOLIC_DETA_FRENTE)
        Dim lID As Int32
        If lEntidad.ID_SOLIC_DETA = 0 Or lEntidad.ID_SOLIC_DETA = Nothing Then
            lID = CType(Me.ObtenerID(lEntidad), Int32)
            If lID = -1 Then Return -1
            lEntidad.ID_SOLIC_DETA = lID
            Return Agregar(lEntidad)
        End If
        Dim strSQL As New StringBuilder
        Dim args(0) As SqlParameter
        strSQL.Append(Me.QueryUpdate(aEntidad, args, aTipoConcurrencia))
        Return SqlHelper.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
    End Function

    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer
        Dim strSQL As New StringBuilder
        Dim args(0) As SqlParameter
        strSQL.Append(Me.QueryInsert(aEntidad, args))
        Return SqlHelper.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
    End Function

    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer
        Return Me.Eliminar(aEntidad, TipoConcurrencia.Pesimistica)
    End Function

    Public Overloads Function Eliminar(ByVal aEntidad As entidadBase, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Dim strSQL As New StringBuilder
        Dim args(0) As SqlParameter
        strSQL.Append(Me.QueryDelete(aEntidad, args, aTipoConcurrencia))
        Return SqlHelper.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
    End Function

    Public Overrides Function Recuperar(ByVal aEntidad As entidadBase) As Integer
        Dim strSQL As New StringBuilder
        Dim args(0) As SqlParameter
        strSQL.Append(Me.QuerySelect(aEntidad, args))
        Dim dr As IDataReader
        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        If dr Is Nothing Then Return 0
        Try
            If dr.Read() Then
                dbAsignarEntidades.AsignarSOLIC_DETA_FRENTE(dr, CType(aEntidad, SOLIC_DETA_FRENTE))
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

    Public Overrides Function ObtenerID(ByVal aEntidad As entidadBase) As Object
        Dim strSQL As New StringBuilder
        strSQL.AppendLine("SELECT isnull(max(ID_SOLIC_DETA),0) + 1 ")
        strSQL.AppendLine(" FROM SOLIC_DETA_FRENTE ")
        Return SqlHelper.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString())
    End Function

    Public Function ObtenerListaPorSOLIC_ENCA_FRENTE(ByVal ID_SOLICITUD As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLIC_DETA_FRENTE

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLIC_DETA_FRENTE))
        strSQL.Append(" WHERE ID_SOLICITUD = @ID_SOLICITUD ")
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_SOLICITUD", SqlDbType.Int)
        args(0).Value = ID_SOLICITUD

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSOLIC_DETA_FRENTE

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLIC_DETA_FRENTE
                dbAsignarEntidades.AsignarSOLIC_DETA_FRENTE(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    Public Function EliminarSOLIC_DETA_FRENTE_Por_ID_SOLICITUD(ByVal ID_SOLICITUD As Integer) As Integer
        Try
            Dim args As New List(Of SqlParameter)
            Dim arg As SqlParameter
            Dim strSQL As New StringBuilder

            strSQL.Append(" DELETE FROM SOLIC_DETA_FRENTE ")

            arg = New SqlParameter("@ID_SOLICITUD", SqlDbType.Int)
            arg.Value = ID_SOLICITUD
            args.Add(arg)
            strSQL.Append("WHERE ID_SOLICITUD = @ID_SOLICITUD ")

            Return SqlHelper.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
