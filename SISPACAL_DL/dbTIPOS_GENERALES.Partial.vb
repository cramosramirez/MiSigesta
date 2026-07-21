Partial Public Class dbTIPOS_GENERALES

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCriterios(ByVal ID_TIPO As Int32, ByVal ID_TIPO_TABLA As Int32, ByVal ID_TIPO_PADRE As Int32) As listaTIPOS_GENERALES
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        strSQL.Append("SELECT * FROM TIPOS_GENERALES ")

        If ID_TIPO <> -1 Then
            arg = New SqlParameter("@ID_TIPO", SqlDbType.Int)
            arg.Value = ID_TIPO
            args.Add(arg)
            AgregarCondicion(strCond, "ID_TIPO = @ID_TIPO")
        End If
        If ID_TIPO_TABLA <> -1 Then
            arg = New SqlParameter("@ID_TIPO_TABLA", SqlDbType.Int)
            arg.Value = ID_TIPO_TABLA
            args.Add(arg)
            AgregarCondicion(strCond, "ID_TIPO_TABLA = @ID_TIPO_TABLA")
        End If
        If ID_TIPO_PADRE <> -1 Then
            arg = New SqlParameter("@ID_TIPO_PADRE", SqlDbType.Int)
            arg.Value = ID_TIPO_PADRE
            args.Add(arg)
            AgregarCondicion(strCond, "ID_TIPO_PADRE = @ID_TIPO_PADRE")
        End If

        strSQL.Append(strCond.ToString)
        strSQL.Append(" ORDER BY ID_TIPO")

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaTIPOS_GENERALES

        Try
            Do While dr.Read()
                Dim mEntidad As New TIPOS_GENERALES
                dbAsignarEntidades.AsignarTIPOS_GENERALES(dr, mEntidad)
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
