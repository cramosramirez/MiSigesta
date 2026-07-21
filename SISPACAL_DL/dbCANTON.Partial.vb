Partial Public Class dbCANTON
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCriterios(ByVal CODI_DEPTO As String, ByVal CODI_MUNI As String, ByVal CODI_CANTON As String) As listaCANTON
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        strSQL.Append("SELECT * ")
        strSQL.Append("FROM CANTON ")

        If CODI_DEPTO <> "" Then
            arg = New SqlParameter("@CODI_DEPTO", SqlDbType.Char)
            arg.Value = CODI_DEPTO
            args.Add(arg)
            AgregarCondicion(strCond, "CODI_DEPTO = @CODI_DEPTO")
        End If
        If CODI_MUNI <> "" Then
            arg = New SqlParameter("@CODI_MUNI", SqlDbType.Char)
            arg.Value = CODI_MUNI
            args.Add(arg)
            AgregarCondicion(strCond, "CODI_MUNI = @CODI_MUNI")
        End If
        If CODI_CANTON <> "" Then
            arg = New SqlParameter("@CODI_CANTON", SqlDbType.Char)
            arg.Value = CODI_CANTON
            args.Add(arg)
            AgregarCondicion(strCond, "CODI_CANTON = @CODI_CANTON")
        End If
        strSQL.Append(strCond.ToString)

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaCANTON

        Try
            Do While dr.Read()
                Dim mEntidad As New CANTON
                dbAsignarEntidades.AsignarCANTON(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorZAFRA(ByVal ID_ZAFRA As Int32, ByVal CODI_DEPTO As String, CODI_MUNI As String) As listaCANTON
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        strSQL.Append("SELECT C.*, D.NOMBRE_DEPTO, M.NOMBRE_MUNI ")
        strSQL.Append("FROM CANTON C, MUNICIPIO M, DEPARTAMENTO D ")
        strSQL.Append("WHERE  ")
        strSQL.Append("C.CODI_DEPTO = M.CODI_DEPTO AND C.CODI_MUNI = M.CODI_MUNI AND M.CODI_DEPTO = D.CODI_DEPTO ")
        strSQL.Append("AND ((C.CODI_DEPTO = @CODI_DEPTO OR @CODI_DEPTO = '') AND (C.CODI_MUNI = @CODI_MUNI OR @CODI_MUNI = '')) ")
        strSQL.Append("AND EXISTS( ")
        strSQL.Append("     SELECT 1 FROM MAESTRO_LOTES ML, LOTES L, CONTRATO_ZAFRAS CZ ")
        strSQL.Append("     WHERE C.CODI_DEPTO = ML.CODI_DEPTO AND C.CODI_MUNI = ML.CODI_MUNI AND C.CODI_CANTON = ML.CODI_CANTON AND ML.ID_MAESTRO = L.ID_MAESTRO AND L.CODICONTRATO = CZ.CODICONTRATO AND CZ.ID_ZAFRA = @ID_ZAFRA ")
        strSQL.Append(" ) ")
        strSQL.Append(" ORDER BY D.NOMBRE_DEPTO, M.NOMBRE_MUNI, C.NOMBRE_CANTON ")


        arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        arg.Value = ID_ZAFRA
        args.Add(arg)

        arg = New SqlParameter("@CODI_DEPTO", SqlDbType.VarChar)
        arg.Value = CODI_DEPTO
        args.Add(arg)

        arg = New SqlParameter("@CODI_MUNI", SqlDbType.VarChar)
        arg.Value = CODI_MUNI
        args.Add(arg)

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaCANTON

        Try
            Do While dr.Read()
                Dim mEntidad As New CANTON
                dbAsignarEntidades.AsignarCANTON(dr, mEntidad)
                mEntidad.CODIUNICO = mEntidad.CODI_DEPTO + ";" + mEntidad.CODI_MUNI + ";" + mEntidad.CODI_CANTON
                mEntidad.NOMBRE_DEPTO = dr("NOMBRE_DEPTO")
                mEntidad.NOMBRE_MUNI = dr("NOMBRE_MUNI")

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
