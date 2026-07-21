Public Class dbNOTACARGO_PLANILLA
    Inherits dbBase

    Public Function ObtenerListaPorID(ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaNOTACARGO_PLANILLA

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New NOTACARGO_PLANILLA))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New ListaNOTACARGO_PLANILLA

        Try
            Do While dr.Read()
                Dim mEntidad As New NOTACARGO_PLANILLA
                dbAsignarEntidades.AsignarNOTACARGO_PLANILLA(dr, mEntidad)
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

        Dim lEntidad As NOTACARGO_PLANILLA
        lEntidad = CType(aEntidad, NOTACARGO_PLANILLA)

        Dim lID As Int32
        If lEntidad.ID_NOTACARGO = 0 _
            Or lEntidad.ID_NOTACARGO = Nothing Then

            lID = CType(Me.ObtenerID(lEntidad), Int32)

            If lID = -1 Then Return -1

            lEntidad.ID_NOTACARGO = lID

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
                dbAsignarEntidades.AsignarNOTACARGO_PLANILLA(dr, CType(aEntidad, NOTACARGO_PLANILLA))
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
        strSQL.AppendLine("SELECT isnull(max(ID_NOTACARGO),0) + 1 ")
        strSQL.AppendLine(" FROM NOTACARGO_PLANILLA ")

        Return SqlHelper.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString())

    End Function

    Public Function ObtenerListaPorCATORCENA_TIPO_PLANILLA(ByVal ID_CATORCENA As Integer, ByVal ID_TIPO_PLANILLA As Int32, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As ListaNOTACARGO_PLANILLA

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New NOTACARGO_PLANILLA))
        strSQL.Append(" WHERE ID_CATORCENA = @ID_CATORCENA AND (ID_TIPO_PLANILLA = @ID_TIPO_PLANILLA OR  @ID_TIPO_PLANILLA = -1) ")
        If asColumnaOrden <> "" Then
            strSQL.Append(" ORDER BY " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ID_CATORCENA", SqlDbType.Int)
        args(0).Value = ID_CATORCENA

        args(1) = New SqlParameter("@ID_TIPO_PLANILLA", SqlDbType.Int)
        args(1).Value = ID_TIPO_PLANILLA

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New ListaNOTACARGO_PLANILLA

        Try
            Do While dr.Read()
                Dim mEntidad As New NOTACARGO_PLANILLA
                dbAsignarEntidades.AsignarNOTACARGO_PLANILLA(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    Public Function EmitirNotasCargoPorPlanilla(ByVal ID_CATORCENA As Integer,
                                                ByVal ID_TIPO_PLANILLA As Integer,
                                                ByVal ES_CONTRIBUYENTE As Integer,
                                                ByVal ID_CUENTA As Integer,
                                                ByVal USUARIO_CREA As String,
                                                ByVal FECHA_CREA As DateTime) As DataSet
        Dim strSQL As New StringBuilder
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter

        arg = New SqlParameter("@ID_CATORCENA", SqlDbType.Int)
        arg.Value = ID_CATORCENA
        args.Add(arg)

        arg = New SqlParameter("@ID_TIPO_PLANILLA", SqlDbType.Int)
        arg.Value = ID_TIPO_PLANILLA
        args.Add(arg)

        arg = New SqlParameter("@ES_CONTRIBUYENTE", SqlDbType.Int)
        arg.Value = ES_CONTRIBUYENTE
        args.Add(arg)

        arg = New SqlParameter("@ID_CUENTA", SqlDbType.Int)
        arg.Value = ID_CUENTA
        args.Add(arg)

        arg = New SqlParameter("@USUARIO_CREA", SqlDbType.VarChar)
        arg.Value = USUARIO_CREA
        args.Add(arg)

        arg = New SqlParameter("@FECHA_CREA", SqlDbType.DateTime)
        arg.Value = FECHA_CREA
        args.Add(arg)

        Dim ds As DataSet

        Try
            ds = SqlHelper.ExecuteDataset(Me.cnnStr, CommandType.StoredProcedure, "EMISION_NOTACARGO", args.ToArray)

        Catch ex As Exception
            Throw ex
        End Try

        Return ds

    End Function

    Public Function AsignarNUM_AUTO_BANCO(ByVal ID_CATORCENA As Integer,
                                            ByVal ID_TIPO_PLANILLA As Integer,
                                            ByVal MONTO As Decimal,
                                            ByVal NUM_CUENTA_REMESA As String,
                                            ByVal NUM_AUTORIZA_BCO As Integer) As DataSet
        Dim strSQL As New StringBuilder
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter

        arg = New SqlParameter("@ID_CATORCENA", SqlDbType.Int)
        arg.Value = ID_CATORCENA
        args.Add(arg)

        arg = New SqlParameter("@ID_TIPO_PLANILLA", SqlDbType.Int)
        arg.Value = ID_TIPO_PLANILLA
        args.Add(arg)

        arg = New SqlParameter("@MONTO", SqlDbType.Decimal)
        arg.Value = MONTO
        args.Add(arg)

        arg = New SqlParameter("@NUM_CUENTA_REMESA", SqlDbType.VarChar)
        arg.Value = NUM_CUENTA_REMESA
        args.Add(arg)

        arg = New SqlParameter("@NUM_AUTORIZA_BCO", SqlDbType.Int)
        arg.Value = NUM_AUTORIZA_BCO
        args.Add(arg)


        Dim ds As DataSet

        Try
            ds = SqlHelper.ExecuteDataset(Me.cnnStr, CommandType.StoredProcedure, "SP_NOTACARGO_PLANILLA_ACT_NUM_AUTORIZA_BCO", args.ToArray)

        Catch ex As Exception
            Throw ex
        End Try

        Return ds

    End Function

End Class
