Public Class dbCCF_DETA_FRENTE
    Inherits dbBase

    Public Function ObtenerListaPorID(ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaCCF_DETA_FRENTE
        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New CCF_DETA_FRENTE))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If
        Dim dr As IDataReader
        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        Dim lista As New listaCCF_DETA_FRENTE
        Try
            Do While dr.Read()
                Dim mEntidad As New CCF_DETA_FRENTE
                dbAsignarEntidades.AsignarCCF_DETA_FRENTE(dr, mEntidad)
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
        Dim lEntidad As CCF_DETA_FRENTE = CType(aEntidad, CCF_DETA_FRENTE)
        Dim lID As Int32
        If lEntidad.ID_CCF_DETA = 0 Or lEntidad.ID_CCF_DETA = Nothing Then
            lID = CType(Me.ObtenerID(lEntidad), Int32)
            If lID = -1 Then Return -1
            lEntidad.ID_CCF_DETA = lID
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
                dbAsignarEntidades.AsignarCCF_DETA_FRENTE(dr, CType(aEntidad, CCF_DETA_FRENTE))
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
        strSQL.AppendLine("SELECT isnull(max(ID_CCF_DETA),0) + 1 ")
        strSQL.AppendLine(" FROM CCF_DETA_FRENTE ")
        Return SqlHelper.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString())
    End Function

    Public Function ObtenerListaPorCCF_ENCA_FRENTE(ByVal ID_CCF_ENCA As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaCCF_DETA_FRENTE

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New CCF_DETA_FRENTE))
        strSQL.Append(" WHERE ID_CCF_ENCA = @ID_CCF_ENCA ")
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_CCF_ENCA", SqlDbType.Int)
        args(0).Value = ID_CCF_ENCA

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaCCF_DETA_FRENTE

        Try
            Do While dr.Read()
                Dim mEntidad As New CCF_DETA_FRENTE
                dbAsignarEntidades.AsignarCCF_DETA_FRENTE(dr, mEntidad)
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
