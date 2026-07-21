Imports System.Text
Public Class dbSUBLOTES
    Inherits dbBase

    Public Function ObtenerListaPorID(ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSUBLOTES

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SUBLOTES))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New listaSUBLOTES

        Try
            Do While dr.Read()
                Dim mEntidad As New SUBLOTES
                dbAsignarEntidades.AsignarSUBLOTES(dr, mEntidad)
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

        Dim lEntidad As SUBLOTES
        lEntidad = CType(aEntidad, SUBLOTES)

        Dim lID As Int32
        If lEntidad.ID_SUBLOTES = 0 _
            Or lEntidad.ID_SUBLOTES = Nothing Then

            lID = CType(Me.ObtenerID(lEntidad), Int32)

            If lID = -1 Then Return -1

            lEntidad.ID_SUBLOTES = lID

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
                dbAsignarEntidades.AsignarSUBLOTES(dr, CType(aEntidad, SUBLOTES))
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
        strSQL.AppendLine("SELECT isnull(max(ID_SUBLOTES),0) + 1 ")
        strSQL.AppendLine(" FROM SUBLOTES ")

        Return SqlHelper.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString())

    End Function

    Public Function ObtenerListaPorMAESTRO_LOTES(ByVal ID_MAESTRO As Integer, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSUBLOTES

        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT * FROM SUBLOTES")
        strSQL.Append(" WHERE ID_MAESTRO = @ID_MAESTRO ")
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_MAESTRO", SqlDbType.Int)
        args(0).Value = ID_MAESTRO

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSUBLOTES

        Try
            Do While dr.Read()
                Dim mEntidad As New SUBLOTES
                dbAsignarEntidades.AsignarSUBLOTES(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    Public Function ObtenerListaPorLOTES_COSECHA(ByVal ID_LOTES_COSECHA As Integer, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSUBLOTES

        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT S.* ")
        strSQL.Append(" FROM LOTES_COSECHA LC, LOTES L, SUBLOTES S ")
        strSQL.Append(" WHERE LC.ACCESLOTE = L.ACCESLOTE ")
        strSQL.Append(" AND L.ID_MAESTRO = S.ID_MAESTRO ")
        strSQL.Append(" AND LC.ID_LOTES_COSECHA = @ID_LOTES_COSECHA ")
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_LOTES_COSECHA", SqlDbType.Int)
        args(0).Value = ID_LOTES_COSECHA

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSUBLOTES

        Try
            Do While dr.Read()
                Dim mEntidad As New SUBLOTES
                dbAsignarEntidades.AsignarSUBLOTES(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    Public Function ObtenerCorrelativoPorMaestro(ByVal ID_MAESTRO As Integer) As Int32
        Dim args As New List(Of SqlParameter)
        Dim arg As New SqlParameter
        Dim strSQL As New StringBuilder
        Dim lRet As Int32

        strSQL.Append("SELECT ISNULL(MAX(CORRELATIVO),0) + 1 AS CORRELATIVO FROM SUBLOTES WHERE ID_MAESTRO = @ID_MAESTRO ")
        arg = New SqlParameter("@ID_MAESTRO", SqlDbType.Int)
        arg.Value = ID_MAESTRO
        args.Add(arg)

        Try
            lRet = SqlHelper.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Catch ex As Exception
            Throw ex
        End Try

        Return lRet
    End Function

    Public Function ObtenerListaSUBLOTES_CONTRATADOS(ByVal CODIPROVEEDOR As String, ByVal ID_ZAFRA_CONTRATO As Int32) As DataSet
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter

        arg = New SqlParameter("@CODIPROVEEDOR", SqlDbType.VarChar)
        arg.Value = CODIPROVEEDOR
        args.Add(arg)

        arg = New SqlParameter("@ID_ZAFRA_CONTRATO", SqlDbType.VarChar)
        arg.Value = ID_ZAFRA_CONTRATO
        args.Add(arg)

        Dim ds As DataSet

        Try
            ds = SqlHelper.ExecuteDataset(Me.cnnStr, CommandType.StoredProcedure, "SP_CONSULTA_SUBLOTES_CONTRATADOS", args.ToArray)

        Catch ex As Exception
            Throw ex
        End Try

        Return ds

    End Function

    Public Function ACTUALIZAR_ESTICANA_X_SUBLOTE(ByVal ID_SUBLOTES As Int32) As String
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter

        arg = New SqlParameter("@ID_SUBLOTES", SqlDbType.Int)
        arg.Value = ID_SUBLOTES
        args.Add(arg)

        Try
            SqlHelper.ExecuteNonQuery(Me.cnnStr, CommandType.StoredProcedure, "ACTUALIZAR_ESTICANA_X_SUBLOTE", args.ToArray)
            Return ""

        Catch ex As Exception
            Throw ex

        End Try



    End Function
End Class


