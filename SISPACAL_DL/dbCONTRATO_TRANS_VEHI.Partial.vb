Partial Public Class dbCONTRATO_TRANS_VEHI

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCriterios(ByVal ID_ZAFRA As Int32, ByVal ID_CONTRA_TRANS As Int32, ByVal ID_TRANSPORTE As Int32, _
                                            ByVal CODTRANSPORT As Int32) As listaCONTRATO_TRANS_VEHI
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        strSQL.Append("SELECT * ")
        strSQL.Append("FROM CONTRATO_TRANS_VEHI D ")

        If ID_ZAFRA <> -1 Then
            arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
            arg.Value = ID_ZAFRA
            args.Add(arg)
            AgregarCondicion(strCond, "(SELECT COUNT(1) FROM CONTRATO_TRANS E WHERE E.ID_ZAFRA = @ID_ZAFRA AND E.ID_CONTRA_TRANS = D.ID_CONTRA_TRANS) > 0")
        End If
        If ID_CONTRA_TRANS <> -1 Then
            arg = New SqlParameter("@ID_CONTRA_TRANS", SqlDbType.Int)
            arg.Value = ID_CONTRA_TRANS
            args.Add(arg)
            AgregarCondicion(strCond, "D.ID_CONTRA_TRANS = @ID_CONTRA_TRANS")
        End If
        If ID_TRANSPORTE <> -1 Then
            arg = New SqlParameter("@ID_TRANSPORTE", SqlDbType.Int)
            arg.Value = ID_TRANSPORTE
            args.Add(arg)
            AgregarCondicion(strCond, "D.ID_TRANSPORTE = @ID_TRANSPORTE")
        End If
        If CODTRANSPORT <> -1 Then
            arg = New SqlParameter("@CODTRANSPORT", SqlDbType.Int)
            arg.Value = CODTRANSPORT
            args.Add(arg)
            AgregarCondicion(strCond, "(SELECT COUNT(1) FROM CONTRATO_TRANS E WHERE E.CODTRANSPORT = @CODTRANSPORT AND E.ID_CONTRA_TRANS = D.ID_CONTRA_TRANS) > 0")
        End If

        strSQL.Append(strCond.ToString)

        Dim dr As IDataReader

        If args.Count > 0 Then
            dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
        Else
            dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        End If

        Dim lista As New listaCONTRATO_TRANS_VEHI

        Try
            Do While dr.Read()
                Dim mEntidad As New CONTRATO_TRANS_VEHI
                dbAsignarEntidades.AsignarCONTRATO_TRANS_VEHI(dr, mEntidad)
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
