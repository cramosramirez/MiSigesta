Partial Public Class dbVARIEDAD
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCriterios(ByVal ID_TIPO As Int32) As listaVARIEDAD
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        strSQL.Append("SELECT * FROM VARIEDAD ")

        If ID_TIPO <> -1 Then
            arg = New SqlParameter("@ID_TIPO", SqlDbType.Int)
            arg.Value = ID_TIPO
            args.Add(arg)
            AgregarCondicion(strCond, "ID_TIPO = @ID_TIPO")
        Else
            AgregarCondicion(strCond, "NOT ID_TIPO IS NULL AND NOT ID_SUB_TIPO IS NULL ")
        End If

        strSQL.Append(strCond.ToString)
        strSQL.Append(" ORDER BY NOM_VARIEDAD")

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaVARIEDAD

        Try
            Do While dr.Read()
                Dim mEntidad As New VARIEDAD
                dbAsignarEntidades.AsignarVARIEDAD(dr, mEntidad)
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
