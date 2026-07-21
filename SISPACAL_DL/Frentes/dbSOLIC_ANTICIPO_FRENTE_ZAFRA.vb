Public Class dbSOLIC_ANTICIPO_FRENTE_ZAFRA
    Inherits dbBase

    Public Function ObtenerListaPorID(ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLIC_ANTICIPO_FRENTE_ZAFRA
        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLIC_ANTICIPO_FRENTE_ZAFRA))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If
        Dim dr As IDataReader
        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        Dim lista As New listaSOLIC_ANTICIPO_FRENTE_ZAFRA
        Try
            Do While dr.Read()
                Dim mEntidad As New SOLIC_ANTICIPO_FRENTE_ZAFRA
                dbAsignarEntidades.AsignarSOLIC_ANTICIPO_FRENTE_ZAFRA(dr, mEntidad)
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
        Dim lEntidad As SOLIC_ANTICIPO_FRENTE_ZAFRA = CType(aEntidad, SOLIC_ANTICIPO_FRENTE_ZAFRA)
        Dim lID As Int32
        If lEntidad.ID_ANTI_ZAFRA = 0 Or lEntidad.ID_ANTI_ZAFRA = Nothing Then
            lID = CType(Me.ObtenerID(lEntidad), Int32)
            If lID = -1 Then Return -1
            lEntidad.ID_ANTI_ZAFRA = lID
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
                dbAsignarEntidades.AsignarSOLIC_ANTICIPO_FRENTE_ZAFRA(dr, CType(aEntidad, SOLIC_ANTICIPO_FRENTE_ZAFRA))
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
        strSQL.AppendLine("SELECT isnull(max(ID_ANTI_ZAFRA),0) + 1 ")
        strSQL.AppendLine(" FROM SOLIC_ANTICIPO_FRENTE_ZAFRA ")
        Return SqlHelper.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString())
    End Function
End Class