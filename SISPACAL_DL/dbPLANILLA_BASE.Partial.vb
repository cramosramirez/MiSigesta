Partial Public Class dbPLANILLA_BASE


    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorZAFRA_TIPO_PLANILLA(ByVal ID_ZAFRA As Int32, ByVal ID_TIPO_PLANILLA As Int32, ByVal asColumnaOrden As String, ByVal asTipoOrden As String) As listaPLANILLA_BASE
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        strSQL.Append("SELECT * ")
        strSQL.Append("FROM PLANILLA_BASE ")

        If ID_ZAFRA <> -1 Then
            arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
            arg.Value = ID_ZAFRA
            args.Add(arg)
            AgregarCondicion(strCond, "ID_ZAFRA = @ID_ZAFRA")
        End If

        If ID_TIPO_PLANILLA <> -1 Then
            arg = New SqlParameter("@ID_TIPO_PLANILLA", SqlDbType.Int)
            arg.Value = ID_TIPO_PLANILLA
            args.Add(arg)
            AgregarCondicion(strCond, "ID_TIPO_PLANILLA = @ID_TIPO_PLANILLA")
        End If
        strSQL.Append(strCond.ToString)

        If asColumnaOrden <> "" Then
            strSQL.Append(" ORDER BY " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As IDataReader


        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)


        Dim lista As New listaPLANILLA_BASE

        Try
            Do While dr.Read()
                Dim mEntidad As New PLANILLA_BASE
                dbAsignarEntidades.AsignarPLANILLA_BASE(dr, mEntidad)
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
    Public Function ObtenerListaPorZAFRA_CATORCENA_TIPO_PLANILLA(ByVal ID_ZAFRA As Int32, ByVal ID_CATORCENA As Int32, ByVal ID_TIPO_PLANILLA As Int32, Optional asColumnaOrden As String = "", Optional asTipoOrden As String = "ASC") As listaPLANILLA_BASE
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        strSQL.Append("SELECT * ")
        strSQL.Append("FROM PLANILLA_BASE ")

        If ID_ZAFRA <> -1 Then
            arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
            arg.Value = ID_ZAFRA
            args.Add(arg)
            AgregarCondicion(strCond, "ID_ZAFRA = @ID_ZAFRA")
        End If

        If ID_CATORCENA <> -1 Then
            arg = New SqlParameter("@ID_CATORCENA", SqlDbType.Int)
            arg.Value = ID_CATORCENA
            args.Add(arg)
            AgregarCondicion(strCond, "ID_CATORCENA = @ID_CATORCENA")
        End If

        If ID_TIPO_PLANILLA <> -1 Then
            arg = New SqlParameter("@ID_TIPO_PLANILLA", SqlDbType.Int)
            arg.Value = ID_TIPO_PLANILLA
            args.Add(arg)
            AgregarCondicion(strCond, "ID_TIPO_PLANILLA = @ID_TIPO_PLANILLA")
        End If
        strSQL.Append(strCond.ToString)

        If asColumnaOrden <> "" Then
            strSQL.Append(" ORDER BY " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As IDataReader


        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)


        Dim lista As New listaPLANILLA_BASE

        Try
            Do While dr.Read()
                Dim mEntidad As New PLANILLA_BASE
                dbAsignarEntidades.AsignarPLANILLA_BASE(dr, mEntidad)
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
