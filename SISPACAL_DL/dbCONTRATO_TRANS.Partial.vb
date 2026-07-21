Partial Public Class dbCONTRATO_TRANS

    Public Function ObtenerNoContratoPorZafra(ByVal ID_ZAFRA As Int32) As Int32
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim lRet As Int32

        strSQL.Append("SELECT ISNULL(MAX(NO_CONTRATO),0) + 1 AS CORRELATIVO ")
        strSQL.Append("FROM CONTRATO_TRANS ")
        strSQL.Append("WHERE ID_ZAFRA = @ID_ZAFRA ")

        arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        arg.Value = ID_ZAFRA
        args.Add(arg)

        Try
            lRet = SqlHelper.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Catch ex As Exception
            Throw ex
        End Try

        Return lRet
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCriterios(ByVal ID_ZAFRA As Int32, _
                                             ByVal NO_CONTRATO As Int32, _
                                             ByVal CODTRANSPORT As Int32) As listaCONTRATO_TRANS
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        strSQL.Append("SELECT C.* FROM CONTRATO_TRANS C ")

        If ID_ZAFRA <> -1 Then
            arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
            arg.Value = ID_ZAFRA
            args.Add(arg)
            AgregarCondicion(strCond, "C.ID_ZAFRA = @ID_ZAFRA")
        End If
        If NO_CONTRATO <> -1 Then
            arg = New SqlParameter("@NO_CONTRATO", SqlDbType.Int)
            arg.Value = NO_CONTRATO
            args.Add(arg)
            AgregarCondicion(strCond, "C.NO_CONTRATO = @NO_CONTRATO")
        End If
        If CODTRANSPORT <> -1 Then
            arg = New SqlParameter("@CODTRANSPORT", SqlDbType.Char)
            arg.Value = CODTRANSPORT
            args.Add(arg)
            AgregarCondicion(strCond, "C.CODTRANSPORT = @CODTRANSPORT")
        End If

        strSQL.Append(strCond.ToString)
        strSQL.Append(" ORDER BY C.NO_CONTRATO ")

        Dim dr As IDataReader

        If args.Count > 0 Then
            dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
        Else
            dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        End If

        Dim lista As New listaCONTRATO_TRANS

        Try
            Do While dr.Read()
                Dim mEntidad As New CONTRATO_TRANS
                dbAsignarEntidades.AsignarCONTRATO_TRANS(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista
    End Function

    Public Function ActualizarZafraLetras() As Int32
        Dim lRet As Int32

        Try
            lRet = SqlHelper.ExecuteNonQuery(Me.cnnStr, CommandType.Text, "UPDATE PARAMETROS SET ZAFRA_LETRAS = LOWER(REPLACE(dbo.fNumero_a_Letras(LEFT(NOMBRE_ZAFRA,4),'') + '/' + dbo.fNumero_a_Letras(RIGHT(NOMBRE_ZAFRA,4),''), ' CON 0/100', '')) FROM ZAFRA WHERE ACTIVA = 1")

        Catch ex As Exception
            Throw ex
        End Try

        Return lRet
    End Function

End Class
