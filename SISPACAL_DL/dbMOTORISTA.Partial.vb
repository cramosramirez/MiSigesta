Partial Public Class dbMOTORISTA
    Public Function ObtenerListaPorTRANSPORTE(ByVal ID_TRANSPORTE As Int32) As listaMOTORISTA

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT * FROM MOTORISTA M ")
        strSQL.Append("WHERE ACTIVO = 1 AND  EXISTS(SELECT 1 FROM MOTORISTA_VEHICULO MV WHERE MV.ID_MOTORISTA = M.ID_MOTORISTA AND MV.ID_TRANSPORTE = @ID_TRANSPORTE) ")
        strSQL.Append("ORDER BY NOMBRES, APELLIDOS")


        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_TRANSPORTE", SqlDbType.Int)
        args(0).Value = ID_TRANSPORTE

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaMOTORISTA

        Try
            Do While dr.Read()
                Dim mEntidad As New MOTORISTA
                dbAsignarEntidades.AsignarMOTORISTA(dr, mEntidad)
                mEntidad.NOMBRE_COMPLETO = mEntidad.NOMBRES + " " + mEntidad.APELLIDOS
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function


    Public Function ObtenerListaActivos() As listaMOTORISTA

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT * FROM MOTORISTA ")
        strSQL.Append("WHERE ACTIVO = 1 ")
        strSQL.Append("ORDER BY NOMBRES, APELLIDOS")


        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New listaMOTORISTA

        Try
            Do While dr.Read()
                Dim mEntidad As New MOTORISTA
                dbAsignarEntidades.AsignarMOTORISTA(dr, mEntidad)
                mEntidad.NOMBRE_COMPLETO = mEntidad.NOMBRES + " " + mEntidad.APELLIDOS
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    Public Function ObtenerListaPorNOMBRES_APELLIDOS(ByVal NOMBRES_APELLIDOS As String) As MOTORISTA
        Dim mEntidad As MOTORISTA
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT * FROM MOTORISTA  ")
        strSQL.Append("WHERE RTRIM(NOMBRES) + ' ' + RTRIM(APELLIDOS) = @NOMBRES_APELLIDOS")


        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@NOMBRES_APELLIDOS", SqlDbType.VarChar)
        args(0).Value = NOMBRES_APELLIDOS

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaMOTORISTA

        Try
            If dr.Read() Then
                mEntidad = New MOTORISTA
                dbAsignarEntidades.AsignarMOTORISTA(dr, mEntidad)
                mEntidad.NOMBRE_COMPLETO = mEntidad.NOMBRES + " " + mEntidad.APELLIDOS
                lista.Add(mEntidad)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return mEntidad

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorID(Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaMOTORISTA

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New MOTORISTA))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New listaMOTORISTA

        Try
            Do While dr.Read()
                Dim mEntidad As New MOTORISTA
                dbAsignarEntidades.AsignarMOTORISTA(dr, mEntidad)
                mEntidad.NOMBRE_COMPLETO = mEntidad.NOMBRES + " " + mEntidad.APELLIDOS
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
