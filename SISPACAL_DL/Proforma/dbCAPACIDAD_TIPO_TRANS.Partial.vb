Partial Public Class dbCAPACIDAD_TIPO_TRANS


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Foranea, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="ID_TIPO_CANA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerCapacidadPorTIPO_CANA_TIPO_TRANS(ByVal ID_TIPO_TRANS As Int32) As Decimal

        Dim strSQL As New StringBuilder
        Dim lRet As Decimal = 0
        strSQL.Append(" SELECT CAPACIDAD_TC ")
        strSQL.Append(" FROM CAPACIDAD_TIPO_TRANS ")
        strSQL.Append(" WHERE ID_TIPO_TRANS = @ID_TIPO_TRANS ")

        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter

        arg = New SqlParameter("@ID_TIPO_TRANS", SqlDbType.Int)
        arg.Value = ID_TIPO_TRANS
        args.Add(arg)

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Try
            If dr.Read() Then
                lRet = CDec(dr(0))
            End If

        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lRet

    End Function
End Class
