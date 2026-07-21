Partial Public Class dbSOLIC_ANTICIPO_ZAFRA

    Public Function ObtenerPorZafraAnticipo(ByVal ID_ZAFRA As Int32, ByVal ID_ANTICIPO As Int32) As SOLIC_ANTICIPO_ZAFRA
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        strSQL.Append("SELECT * FROM SOLIC_ANTICIPO_ZAFRA ")

        arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        arg.Value = ID_ZAFRA
        args.Add(arg)
        AgregarCondicion(strCond, "ID_ZAFRA = @ID_ZAFRA")

        arg = New SqlParameter("@ID_ANTICIPO", SqlDbType.Int)
        arg.Value = ID_ANTICIPO
        args.Add(arg)
        AgregarCondicion(strCond, "ID_ANTICIPO = @ID_ANTICIPO")

        strSQL.Append(strCond.ToString)

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim mEntidad As New SOLIC_ANTICIPO_ZAFRA

        Try
            If dr.Read() Then
                dbAsignarEntidades.AsignarSOLIC_ANTICIPO_ZAFRA(dr, mEntidad)
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
End Class
