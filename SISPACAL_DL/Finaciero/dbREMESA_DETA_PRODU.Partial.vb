Partial Public Class dbREMESA_DETA_PRODU

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Foranea, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="ID_REMESA_ENCA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	11/09/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorREMESA_ENCA_PRODU(ByVal ID_REMESA_ENCA As Int32, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaREMESA_DETA_PRODU

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New REMESA_DETA_PRODU))
        strSQL.Append(" WHERE ID_REMESA_ENCA = @ID_REMESA_ENCA ")
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_REMESA_ENCA", SqlDbType.Int)
        args(0).Value = ID_REMESA_ENCA

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaREMESA_DETA_PRODU

        Try
            Do While dr.Read()
                Dim mEntidad As New REMESA_DETA_PRODU
                dbAsignarEntidades.AsignarREMESA_DETA_PRODU(dr, mEntidad)
                mEntidad.TOTAL = mEntidad.ABONO_CAPITAL + mEntidad.ABONO_INTERES + mEntidad.ABONO_INTERES_IVA
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
