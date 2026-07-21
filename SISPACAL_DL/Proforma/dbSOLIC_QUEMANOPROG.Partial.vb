Partial Public Class dbSOLIC_QUEMANOPROG


    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCriterios(ByVal ID_ZAFRA As Int32, _
                                             ByVal ZONA As String, _
                                             ByVal CODIPROVEE As String, _
                                             ByVal CODISOCIO As String, _
                                             ByVal NOMBRE_PROVEEDOR As String, _
                                             ByVal NOMBLOTE As String) As listaSOLIC_QUEMANOPROG
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        strSQL.Append("SELECT * FROM SOLIC_QUEMANOPROG S ")

        If ID_ZAFRA <> -1 Then
            arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
            arg.Value = ID_ZAFRA
            args.Add(arg)
            AgregarCondicion(strCond, "S.ID_ZAFRA = @ID_ZAFRA")
        End If
        If ZONA <> "" Then
            arg = New SqlParameter("@ZONA", SqlDbType.Char)
            arg.Value = ZONA
            args.Add(arg)
            AgregarCondicion(strCond, "S.ZONA = @ZONA")
        End If
        If CODIPROVEE <> "" Then
            arg = New SqlParameter("@CODIPROVEE", SqlDbType.Char)
            arg.Value = CODIPROVEE
            args.Add(arg)
            AgregarCondicion(strCond, "EXISTS(SELECT 1 FROM PROVEEDOR P WHERE P.CODIPROVEEDOR = S.CODIPROVEEDOR AND P.CODIPROVEE = @CODIPROVEE)")
        End If
        If CODISOCIO <> "" Then
            arg = New SqlParameter("@CODISOCIO", SqlDbType.Char)
            arg.Value = CODISOCIO
            args.Add(arg)
            AgregarCondicion(strCond, "EXISTS(SELECT 1 FROM PROVEEDOR P WHERE P.CODIPROVEEDOR = S.CODIPROVEEDOR AND P.CODISOCIO = @CODISOCIO)")
        End If
        If NOMBRE_PROVEEDOR <> "" Then
            arg = New SqlParameter("@NOMBRE_PROVEEDOR", SqlDbType.VarChar)
            arg.Value = "%" + NOMBRE_PROVEEDOR.ToUpper.Trim.Replace(" ", "%") + "%"
            args.Add(arg)
            AgregarCondicion(strCond, "EXISTS(SELECT 1 FROM PROVEEDOR P WHERE P.CODIPROVEEDOR = S.CODIPROVEEDOR AND ISNULL(RTRIM(P.NOMBRES),'') + ' ' + ISNULL(RTRIM(P.APELLIDOS),'') LIKE @NOMBRE_PROVEEDOR)")
        End If
        If NOMBLOTE <> "" Then
            arg = New SqlParameter("@NOMBLOTE", SqlDbType.Int)
            arg.Value = NOMBLOTE
            args.Add(arg)
            AgregarCondicion(strCond, "EXISTS(SELECT 1 FROM LOTES L WHERE L.ACCESLOTE = S.ACCESLOTE AND L.NOMBLOTE LIKE @NOMBLOTE)")
        End If

        strSQL.Append(strCond.ToString)


        Dim dr As IDataReader

        If args.Count = 0 Then
            dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        Else
            dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
        End If

        Dim lista As New listaSOLIC_QUEMANOPROG

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLIC_QUEMANOPROG
                dbAsignarEntidades.AsignarSOLIC_QUEMANOPROG(dr, mEntidad)
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
