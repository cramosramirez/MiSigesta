Public Class dbSOLIC_ENCA_FRENTE
    Inherits dbBase

    Public Function ObtenerListaPorTIPO_PROVEEDOR(ByVal ID_TIPO_PROVEEDOR As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLIC_ENCA_FRENTE

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLIC_ENCA_FRENTE))
        strSQL.Append(" WHERE ID_TIPO_PROVEEDOR = @ID_TIPO_PROVEEDOR ")
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_TIPO_PROVEEDOR", SqlDbType.Int)
        args(0).Value = ID_TIPO_PROVEEDOR

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSOLIC_ENCA_FRENTE

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLIC_ENCA_FRENTE
                dbAsignarEntidades.AsignarSOLIC_ENCA_FRENTE(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function
    Public Function ObtenerNoSolicitudPorZafraTipoProveedor(ByVal ID_ZAFRA As Int32, ByVal ID_TIPO_PROVEEDOR As Int32) As Int32
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim lRet As Int32

        strSQL.Append("SELECT ISNULL(MAX(NUM_SOLIC_ZAFRA),0) + 1 AS CORRELATIVO ")
        strSQL.Append("FROM SOLIC_ENCA_FRENTE ")
        strSQL.Append("WHERE ID_ZAFRA = @ID_ZAFRA AND ID_TIPO_PROVEEDOR = @ID_TIPO_PROVEEDOR ")

        arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        arg.Value = ID_ZAFRA
        args.Add(arg)

        arg = New SqlParameter("@ID_TIPO_PROVEEDOR", SqlDbType.Int)
        arg.Value = ID_TIPO_PROVEEDOR
        args.Add(arg)

        Try
            lRet = SqlHelper.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Catch ex As Exception
            Throw ex
        End Try

        Return lRet
    End Function
    Public Function ObtenerListaPorID(ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLIC_ENCA_FRENTE
        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLIC_ENCA_FRENTE))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If
        Dim dr As IDataReader
        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        Dim lista As New listaSOLIC_ENCA_FRENTE
        Try
            Do While dr.Read()
                Dim mEntidad As New SOLIC_ENCA_FRENTE
                dbAsignarEntidades.AsignarSOLIC_ENCA_FRENTE(dr, mEntidad)
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
        Dim lEntidad As SOLIC_ENCA_FRENTE
        lEntidad = CType(aEntidad, SOLIC_ENCA_FRENTE)
        Dim lID As Int32
        If lEntidad.ID_SOLICITUD = 0 Or lEntidad.ID_SOLICITUD = Nothing Then
            lID = CType(Me.ObtenerID(lEntidad), Int32)
            If lID = -1 Then Return -1
            lEntidad.ID_SOLICITUD = lID
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
                dbAsignarEntidades.AsignarSOLIC_ENCA_FRENTE(dr, CType(aEntidad, SOLIC_ENCA_FRENTE))
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
        strSQL.AppendLine("SELECT isnull(max(ID_SOLICITUD),0) + 1 ")
        strSQL.AppendLine(" FROM SOLIC_ENCA_FRENTE ")
        Return SqlHelper.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString())
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerListaPorCriterios(ByVal ID_ZAFRA As Int32,
                                             ByVal NUM_SOLIC_ZAFRA As Int32,
                                             ByVal ID_TIPO_PROVEEDOR As String,
                                             ByVal COD_FRENTE As String) As listaSOLIC_ENCA_FRENTE
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        strSQL.Append("SELECT * FROM SOLIC_ENCA_FRENTE S ")

        If ID_ZAFRA <> -1 Then
            arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
            arg.Value = ID_ZAFRA
            args.Add(arg)
            AgregarCondicion(strCond, "S.ID_ZAFRA = @ID_ZAFRA")
        End If
        If NUM_SOLIC_ZAFRA <> -1 Then
            arg = New SqlParameter("@NUM_SOLIC_ZAFRA", SqlDbType.Int)
            arg.Value = NUM_SOLIC_ZAFRA
            args.Add(arg)
            AgregarCondicion(strCond, "S.NUM_SOLIC_ZAFRA = @NUM_SOLIC_ZAFRA")
        End If
        If ID_TIPO_PROVEEDOR <> "" Then
            arg = New SqlParameter("@ID_TIPO_PROVEEDOR", SqlDbType.Int)
            arg.Value = ID_TIPO_PROVEEDOR
            args.Add(arg)
            AgregarCondicion(strCond, "S.ID_TIPO_PROVEEDOR = @ID_TIPO_PROVEEDOR")
        End If
        If COD_FRENTE <> "" Then
            arg = New SqlParameter("@COD_FRENTE", SqlDbType.VarChar)
            arg.Value = COD_FRENTE
            args.Add(arg)
            AgregarCondicion(strCond, "S.COD_FRENTE = @COD_FRENTE")
        End If


        strSQL.Append(strCond.ToString)
        strSQL.Append(" ORDER BY S.FECHA_SOLIC ")

        Dim dr As IDataReader

        If args.Count > 0 Then
            dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
        Else
            dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        End If

        Dim lista As New listaSOLIC_ENCA_FRENTE

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLIC_ENCA_FRENTE
                dbAsignarEntidades.AsignarSOLIC_ENCA_FRENTE(dr, mEntidad)
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
