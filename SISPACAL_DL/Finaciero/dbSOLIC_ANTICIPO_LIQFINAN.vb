Public Class dbSOLIC_ANTICIPO_LIQFINAN
    Inherits dbBase


    Public Function ObtenerListaPorID(ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLIC_ANTICIPO_LIQFINAN

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLIC_ANTICIPO_LIQFINAN))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New ListaSOLIC_ANTICIPO_LIQFINAN

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLIC_ANTICIPO_LIQFINAN
                dbAsignarEntidades.AsignarSOLIC_ANTICIPO_LIQFINAN(dr, mEntidad)
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

        Dim lEntidad As SOLIC_ANTICIPO_LIQFINAN
        lEntidad = CType(aEntidad, SOLIC_ANTICIPO_LIQFINAN)

        Dim lID As Int32
        If lEntidad.ID_ANTI_LIQ = 0 _
            Or lEntidad.ID_ANTI_LIQ = Nothing Then

            lID = CType(Me.ObtenerID(lEntidad), Int32)

            If lID = -1 Then Return -1

            lEntidad.ID_ANTI_LIQ = lID

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
                dbAsignarEntidades.AsignarSOLIC_ANTICIPO_LIQFINAN(dr, CType(aEntidad, SOLIC_ANTICIPO_LIQFINAN))
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
        strSQL.AppendLine("SELECT isnull(max(ID_ANTI_LIQ),0) + 1 ")
        strSQL.AppendLine(" FROM SOLIC_ANTICIPO_LIQFINAN ")

        Return SqlHelper.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString())

    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerListaPorSOLIC_ANTICIPO(ByVal ID_ANTICIPO As Int32) As listaSOLIC_ANTICIPO_LIQFINAN
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLIC_ANTICIPO_LIQFINAN))
        strSQL.Append(" WHERE ID_ANTICIPO = @ID_ANTICIPO ")


        arg = New SqlParameter("@ID_ANTICIPO", SqlDbType.Int)
        arg.Value = ID_ANTICIPO
        args.Add(arg)

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaSOLIC_ANTICIPO_LIQFINAN

        Try
            While dr.Read
                Dim mEntidad As New SOLIC_ANTICIPO_LIQFINAN
                dbAsignarEntidades.AsignarSOLIC_ANTICIPO_LIQFINAN(dr, mEntidad)
                lista.Add(mEntidad)
            End While
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerListaPorCriterios(ByVal CODIPROVEEDOR As String,
                                             ByVal ID_ZAFRA As Int32) As listaSOLIC_ANTICIPO_LIQFINAN
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter

        arg = New SqlParameter("@CODIPROVEEDOR", SqlDbType.VarChar)
        arg.Value = CODIPROVEEDOR
        args.Add(arg)

        arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        arg.Value = ID_ZAFRA
        args.Add(arg)


        Dim dr As IDataReader


        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.StoredProcedure, "OBTENER_SALDOS_PARA_LIQFINAN", args.ToArray)

        Dim lista As New listaSOLIC_ANTICIPO_LIQFINAN

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLIC_ANTICIPO_LIQFINAN
                mEntidad.ID_ANTI_LIQ = Integer.Parse(dr("ID_ANTI_LIQ").ToString)
                mEntidad.ID_ANTICIPO = Integer.Parse(dr("ID_ANTICIPO").ToString)
                mEntidad.ID_CREDITO_ENCA = Integer.Parse(dr("ID_CREDITO_ENCA").ToString)
                mEntidad.UID_REFERENCIA = dr("UID_REFERENCIA").ToString
                mEntidad.SALDO_INI = Convert.ToDecimal(dr("SALDO_INI"))
                mEntidad.INTERES = Convert.ToDecimal(dr("INTERES"))
                mEntidad.INTERES_IVA = Convert.ToDecimal(dr("INTERES_IVA"))
                mEntidad.ABONO = Convert.ToDecimal(dr("ABONO"))
                mEntidad.INTERES_ABO = Convert.ToDecimal(dr("INTERES_ABO"))
                mEntidad.INTERES_IVA_ABO = Convert.ToDecimal(dr("INTERES_IVA_ABO"))
                mEntidad.SALDO_FIN = Convert.ToDecimal(dr("SALDO_FIN"))

                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista
    End Function

    Public Function EliminarPorSOLIC_ANTICIPO(ByVal ID_ANTICIPO As Int32) As Integer
        Dim strSQL As New StringBuilder
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim lRet As Integer = 0

        arg = New SqlParameter("@ID_ANTICIPO", SqlDbType.Int)
        arg.Value = ID_ANTICIPO
        args.Add(arg)

        strSQL.Append("DELETE FROM SOLIC_ANTICIPO_LIQFINAN WHERE ID_ANTICIPO = @ID_ANTICIPO")

        Try
            lRet = SqlHelper.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Catch ex As Exception
            Throw ex
        End Try

        Return lRet
    End Function

End Class
