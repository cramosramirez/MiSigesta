Partial Public Class dbPLAN_COSECHA_DIARIO

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCriterios(ByVal ID_ZAFRA As Int32, _
                                             ByVal ZONA As String, _
                                             ByVal DIAZAFRA As Int32, _
                                             ByVal CODIPROVEE As String, _
                                             ByVal CODISOCIO As String, _
                                             ByVal NOMBRE_PROVEEDOR As String) As listaPLAN_COSECHA_DIARIO
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        strSQL.Append("SELECT * FROM PLAN_COSECHA_DIARIO ")

        '** ID_ZAFRA
        arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        arg.Value = ID_ZAFRA
        args.Add(arg)
        AgregarCondicion(strCond, "ID_ZAFRA = @ID_ZAFRA")

        '** ZONA
        If ZONA <> "" AndAlso ZONA <> Nothing Then
            arg = New SqlParameter("@ZONA", SqlDbType.Char)
            arg.Value = ZONA
            args.Add(arg)
            AgregarCondicion(strCond, "ZONA = @ZONA")
        End If

        '** DIAZAFRA
        arg = New SqlParameter("@DIAZAFRA", SqlDbType.Int)
        arg.Value = DIAZAFRA
        args.Add(arg)
        AgregarCondicion(strCond, "DIAZAFRA = @DIAZAFRA")

        If CODIPROVEE <> "" Then
            arg = New SqlParameter("@CODIPROVEE", SqlDbType.Char)
            arg.Value = CODIPROVEE
            args.Add(arg)
            AgregarCondicion(strCond, "CODIPROVEE = @CODIPROVEE")
        End If
        If CODISOCIO <> "" Then
            arg = New SqlParameter("@CODISOCIO", SqlDbType.Char)
            arg.Value = CODISOCIO
            args.Add(arg)
            AgregarCondicion(strCond, "CCODISOCIO = @CODISOCIO")
        End If
        If NOMBRE_PROVEEDOR <> "" Then
            arg = New SqlParameter("@NOMBRE_PROVEEDOR", SqlDbType.VarChar)
            arg.Value = "%" + NOMBRE_PROVEEDOR.ToUpper.Trim.Replace(" ", "%") + "%"
            args.Add(arg)
            AgregarCondicion(strCond, "PROVEEDOR LIKE @NOMBRE_PROVEEDOR")
        End If

        strSQL.Append(strCond.ToString)
        strSQL.Append(" ORDER BY ZONA, PROVEEDOR, CODILOTE")

        Dim dr As IDataReader

        If args.Count = 0 Then
            dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        Else
            dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
        End If

        Dim lista As New listaPLAN_COSECHA_DIARIO

        Try
            Do While dr.Read()
                Dim mEntidad As New PLAN_COSECHA_DIARIO
                dbAsignarEntidades.AsignarPLAN_COSECHA_DIARIO(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista
    End Function


    Public Function GenerarPropuestaCosechaDiaria(ByVal ID_ZAFRA As Integer, _
                 ByVal FECHA As DateTime, _
                 ByVal USUARIO_CREA As String, _
                 ByVal FECHA_CREA As DateTime) As Integer

        Dim lResult As Integer = -1
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter

        arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        arg.Value = ID_ZAFRA
        args.Add(arg)

        arg = New SqlParameter("@FECHA", SqlDbType.DateTime)
        arg.Value = FECHA
        args.Add(arg)

        arg = New SqlParameter("@USUARIO_CREA", SqlDbType.VarChar)
        arg.Value = USUARIO_CREA
        args.Add(arg)

        arg = New SqlParameter("@FECHA_CREA", SqlDbType.DateTime)
        arg.Value = FECHA_CREA
        args.Add(arg)

        Try
            lResult = SqlHelper.ExecuteNonQuery(Me.cnnStr, CommandType.StoredProcedure, "GENERAR_PROPUESTA_COSECHA_DIARIA", args.ToArray)
            Return 1

        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
