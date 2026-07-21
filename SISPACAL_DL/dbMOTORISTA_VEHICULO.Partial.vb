Partial Public Class dbMOTORISTA_VEHICULO

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada el CODIGO DE TRANSPORTISTA.
    ''' </summary>
    ''' <param name="CODTRANSPORT"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	13/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorTRANSPORTISTA(ByVal CODTRANSPORT As Int32, Optional ByVal asColumnaOrden As String = "PLACAVEHIC", Optional ByVal asTipoOrden As String = "ASC") As listaMOTORISTA_VEHICULO

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT * FROM MOTORISTA_VEHICULO V ")
        strSQL.Append("WHERE EXISTS(SELECT 1 FROM TRANSPORTISTA T, MOTORISTA M WHERE T.CODTRANSPORT = M.CODTRANSPORT AND M.ID_MOTORISTA = V.ID_MOTORISTA AND T.CODTRANSPORT =  @CODTRANSPORT) ")
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@CODTRANSPORT", SqlDbType.Int)
        args(0).Value = CODTRANSPORT

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaMOTORISTA_VEHICULO

        Try
            Do While dr.Read()
                Dim mEntidad As New MOTORISTA_VEHICULO
                dbAsignarEntidades.AsignarMOTORISTA_VEHICULO(dr, mEntidad)
                lista.Add(mEntidad)
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
    ''' la Tabla TRANSPORTISTA.
    ''' </summary>
    ''' <param name="CODTRANSPORT"></param>
    ''' <param name="PLACAVEHIC"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	13/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerMOTORISTA_VEHICULOPorTRANSPORTISTA_PLACA(ByVal CODTRANSPORT As Int32, ByVal PLACAVEHIC As String) As MOTORISTA_VEHICULO
        Dim mEntidad As MOTORISTA_VEHICULO = Nothing
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT * FROM MOTORISTA_VEHICULO V ")
        strSQL.Append("WHERE EXISTS(SELECT 1 FROM TRANSPORTISTA T, MOTORISTA M, TRANSPORTE E WHERE T.CODTRANSPORT = E.CODTRANSPORT AND M.ID_MOTORISTA = V.ID_MOTORISTA AND E.ID_TRANSPORTE = V.ID_TRANSPORTE AND T.CODTRANSPORT = E.CODTRANSPORT AND T.CODTRANSPORT =  @CODTRANSPORT AND E.PLACA = @PLACAVEHIC )")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@CODTRANSPORT", SqlDbType.Int)
        args(0).Value = CODTRANSPORT

        args(1) = New SqlParameter("@PLACAVEHIC", SqlDbType.VarChar)
        args(1).Value = PLACAVEHIC

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaMOTORISTA_VEHICULO

        Try
            If dr.Read() Then
                mEntidad = New MOTORISTA_VEHICULO
                dbAsignarEntidades.AsignarMOTORISTA_VEHICULO(dr, mEntidad)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return mEntidad
    End Function

    Public Function ObtenerMOTORISTA_VEHICULOPorTRANSPORTE_MOTORISTA(ByVal ID_TRANSPORTE As Int32, ByVal ID_MOTORISTA As Int32) As MOTORISTA_VEHICULO
        Dim mEntidad As MOTORISTA_VEHICULO = Nothing
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT * FROM MOTORISTA_VEHICULO V ")
        strSQL.Append("WHERE ID_TRANSPORTE = @ID_TRANSPORTE AND ID_MOTORISTA = @ID_MOTORISTA ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ID_TRANSPORTE", SqlDbType.Int)
        args(0).Value = ID_TRANSPORTE

        args(1) = New SqlParameter("@ID_MOTORISTA", SqlDbType.Int)
        args(1).Value = ID_MOTORISTA

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaMOTORISTA_VEHICULO

        Try
            If dr.Read() Then
                mEntidad = New MOTORISTA_VEHICULO
                dbAsignarEntidades.AsignarMOTORISTA_VEHICULO(dr, mEntidad)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return mEntidad
    End Function
End Class
