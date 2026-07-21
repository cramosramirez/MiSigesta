Partial Public Class dbCENSO_LOTES

    Public Function EliminarListaPorCENSO(ByVal ID_CENSO As Int32) As Int32
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM CENSO_LOTES WHERE ID_CENSO = @ID_CENSO")

        arg = New SqlParameter("@ID_CENSO", SqlDbType.Int)
        arg.Value = ID_CENSO
        args.Add(arg)


        Try

            SqlHelper.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Catch ex As Exception
            Throw ex
        End Try

        Return 1

    End Function

    Public Function ObtenerListaParaIngresoCenso(ByVal ID_ZAFRA As Integer, ByVal ZONA As String, ByVal ID_CENSO As Integer, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaCENSO_LOTES
        Dim lista As New listaCENSO_LOTES
        Dim lZafra As New ZAFRA
        Dim bZafra As New dbZAFRA
        Dim bCenso As New dbCENSO
        Dim lCenso As New CENSO
        Dim strSQL As New StringBuilder
        Dim args(1) As SqlParameter
        Dim i As Integer = 1

        strSQL.Append(Me.QuerySelect(New LOTES))
        strSQL.Append(" WHERE ANIOZAFRA = @ANIOZAFRA ")
        strSQL.Append(" AND ZONA = @ZONA ")
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        lZafra.ID_ZAFRA = ID_ZAFRA
        bZafra.Recuperar(lZafra)

        If lZafra IsNot Nothing Then
            args(0) = New SqlParameter("@ANIOZAFRA", SqlDbType.VarChar)
            args(0).Value = lZafra.NOMBRE_ZAFRA

            args(1) = New SqlParameter("@ZONA", SqlDbType.VarChar)
            args(1).Value = ZONA
        Else
            Return lista
        End If

        lCenso.ID_CENSO = ID_CENSO
        bCenso.Recuperar(lCenso)
        If lCenso Is Nothing Then
            Return lista
        End If

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Try
            Do While dr.Read()
                Dim mEntidad As New LOTES
                Dim mCensoLote As New CENSO_LOTES

                dbAsignarEntidades.AsignarLOTES(dr, mEntidad)

                'Recuperar el censo del lote
                mCensoLote = ObtenerPorCENSO_LOTE(ID_CENSO, mEntidad.ACCESLOTE)

                If mCensoLote Is Nothing Then
                    mCensoLote = New CENSO_LOTES
                    mCensoLote.ID_CENSO_LOTES = 0
                    mCensoLote.ID_ZAFRA = ID_ZAFRA
                    mCensoLote.ACCESLOTE = mEntidad.ACCESLOTE
                    mCensoLote.ID_CENSO = ID_CENSO
                    mCensoLote.FECHA_VERIFICACION = lCenso.FECHA_CENSO
                End If
                lista.Add(mCensoLote)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Foranea, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="ID_CENSO"></param>
    ''' <param name="ACCESLOTE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/04/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerPorCENSO_LOTE(ByVal ID_CENSO As Integer, ByVal ACCESLOTE As String) As CENSO_LOTES
        Dim mEntidad As New CENSO_LOTES
        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New CENSO_LOTES))
        strSQL.Append(" WHERE ID_CENSO = @ID_CENSO AND ACCESLOTE = @ACCESLOTE ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ID_CENSO", SqlDbType.Int)
        args(0).Value = ID_CENSO

        args(1) = New SqlParameter("@ACCESLOTE", SqlDbType.VarChar)
        args(1).Value = ACCESLOTE


        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Try
            If dr.Read() Then
                dbAsignarEntidades.AsignarCENSO_LOTES(dr, mEntidad)
            Else
                mEntidad = Nothing
            End If
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return mEntidad

    End Function


    Public Function ObtenerPorZAFRA_LOTE(ByVal ID_ZAFRA As Integer, ByVal ACCESLOTE As String) As CENSO_LOTES
        Dim mEntidad As New CENSO_LOTES
        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New CENSO_LOTES))
        strSQL.Append(" WHERE ID_ZAFRA = @ID_ZAFRA AND ACCESLOTE = @ACCESLOTE ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        args(0).Value = ID_ZAFRA

        args(1) = New SqlParameter("@ACCESLOTE", SqlDbType.VarChar)
        args(1).Value = ACCESLOTE


        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Try
            If dr.Read() Then
                dbAsignarEntidades.AsignarCENSO_LOTES(dr, mEntidad)
            Else
                mEntidad = Nothing
            End If
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return mEntidad

    End Function

    Public Function GenerarCENSO_LOTES(ByVal ID_CENSO As Int32, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime) As Int32
        Dim lRet As Int32 = 0
        Dim args(2) As SqlParameter

        args(0) = New SqlParameter("@ID_CENSO", SqlDbType.Int)
        args(0).Value = ID_CENSO

        args(1) = New SqlParameter("@USUARIO_CREA", SqlDbType.VarChar)
        args(1).Value = USUARIO_CREA

        args(2) = New SqlParameter("@FECHA_CREA", SqlDbType.DateTime)
        args(2).Value = FECHA_CREA

        Try
            SqlHelper.ExecuteNonQuery(Me.cnnStr, "GENERAR_CENSO_LOTES", args)
            Return 1

        Catch ex As Exception
            Return -1
        End Try

        Return lRet
    End Function

End Class
