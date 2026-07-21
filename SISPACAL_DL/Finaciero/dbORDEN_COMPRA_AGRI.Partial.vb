Partial Public Class dbORDEN_COMPRA_AGRI


    Public Function PROC_GenerarORDEN_COMPRA_AGRICOLA(ByVal ID_SOLICITUD As Int32, ByVal FECHA As Date, ByVal CCF_NOMBRE As String, ByVal LUGAR_ENTREGA As String, ByVal CONTACTO As String, ByVal USUARIO As String) As Integer
        Dim lResult As Integer = -1
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter

        arg = New SqlParameter("@ID_SOLICITUD", SqlDbType.Int)
        arg.Value = ID_SOLICITUD
        args.Add(arg)

        arg = New SqlParameter("@FECHA", SqlDbType.DateTime)
        arg.Value = FECHA
        args.Add(arg)

        arg = New SqlParameter("@CCF_NOMBRE", SqlDbType.VarChar)
        arg.Value = CCF_NOMBRE
        args.Add(arg)

        arg = New SqlParameter("@LUGAR_ENTREGA", SqlDbType.VarChar)
        arg.Value = LUGAR_ENTREGA
        args.Add(arg)

        arg = New SqlParameter("@CONTACTO", SqlDbType.VarChar)
        arg.Value = CONTACTO
        args.Add(arg)

        arg = New SqlParameter("@USUARIO", SqlDbType.VarChar)
        arg.Value = USUARIO
        args.Add(arg)

        Try
            lResult = SqlHelper.ExecuteNonQuery(Me.cnnStr, CommandType.StoredProcedure, "PROC_GENERAR_ORDEN_COMPRA_AGRICOLA", args.ToArray)
            Return 1

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCriterios(ByVal ID_PROVEE As Int32, ByVal CONDI_COMPRA As Int32, ByVal SOLO_ENTREGA_PENDIENTE As Boolean, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaORDEN_COMPRA_AGRI
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter

        Dim strSQL As New StringBuilder
        Dim strCondicion As New StringBuilder
        strSQL.Append("SELECT E.* FROM ORDEN_COMPRA_AGRI E ")

        Dim dr As IDataReader

        If ID_PROVEE <> -1 Then
            arg = New SqlParameter("@ID_PROVEE", DbType.Int32)
            arg.Value = ID_PROVEE
            args.Add(arg)
            AgregarCondicion(strCondicion, "E.ID_PROVEE = @ID_PROVEE")
        End If
        If CONDI_COMPRA <> -1 Then
            arg = New SqlParameter("@CONDI_COMPRA", DbType.Int32)
            arg.Value = CONDI_COMPRA
            args.Add(arg)
            AgregarCondicion(strCondicion, "E.CONDI_COMPRA = @CONDI_COMPRA")
        End If
        If SOLO_ENTREGA_PENDIENTE Then
            Dim s As New StringBuilder
            s.AppendLine("EXISTS( ")
            s.AppendLine("	SELECT * FROM ")
            s.AppendLine("	(	SELECT D.ID_ORDEN, D.CANTIDAD - ISNULL((SELECT SUM(T.CANTIDAD) FROM DOCUMENTO_ENTRADA_DETA T WHERE T.ID_ORDEN_DETA = D.ID_ORDEN_DETA),0) AS SALDO ")
            s.AppendLine("		FROM ORDEN_DETA_AGRI D ")
            s.AppendLine("		WHERE D.ID_ORDEN = E.ID_ORDEN ")
            s.AppendLine("	) S ")
            s.AppendLine("	WHERE S.ID_ORDEN = E.ID_ORDEN AND SALDO > 0 ")
            s.AppendLine(") ")
            AgregarCondicion(strCondicion, s.ToString)
        End If

        strSQL.Append(strCondicion.ToString)

        If asColumnaOrden <> "" Then
            strSQL.Append(" ORDER BY " + asColumnaOrden + " " + asTipoOrden)
        End If

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaORDEN_COMPRA_AGRI

        Try
            Do While dr.Read()
                Dim mEntidad As New ORDEN_COMPRA_AGRI
                dbAsignarEntidades.AsignarORDEN_COMPRA_AGRI(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    Public Function ObtenerNoOrdenCompraPorZafra(ByVal ID_ZAFRA As Int32, ByVal CONDI_COMPRA As Int32) As Int32
        Dim strSQL As New StringBuilder
        Dim lRet As Int32

        strSQL.Append("SELECT ISNULL(MAX(NO_ORDEN),0) + 1 AS CORRELATIVO ")
        If CONDI_COMPRA = 3 Then
            strSQL.Append("FROM ORDEN_COMPRA_AGRI WHERE ID_ZAFRA = " + ID_ZAFRA.ToString + " AND CONDI_COMPRA = 3")
        Else
            strSQL.Append("FROM ORDEN_COMPRA_AGRI WHERE ID_ZAFRA = " + ID_ZAFRA.ToString + " AND CONDI_COMPRA <> 3")
        End If

        Try
            lRet = SqlHelper.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Catch ex As Exception
            Throw ex
        End Try

        Return lRet
    End Function
End Class
