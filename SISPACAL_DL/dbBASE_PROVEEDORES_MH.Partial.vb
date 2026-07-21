Partial Public Class dbBASE_PROVEEDORES_MH

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerListaPorCriterios(ByVal NOMBRES As String, ByVal APELLIDOS As String,
                                             ByVal DUI As String,
                                             ByVal NIT As String,
                                             ByVal NRC As String) As listaBASE_PROVEEDORES_MH
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        strSQL.Append("SELECT P.* FROM BASE_PROVEEDORES_MH P ")

        If APELLIDOS <> "" Then
            arg = New SqlParameter("@APELLIDOS", SqlDbType.VarChar)
            arg.Value = APELLIDOS.ToUpper
            args.Add(arg)
            AgregarCondicion(strCond, "P.APELLIDOS LIKE '%' + @APELLIDOS + '%'")
        End If
        If NOMBRES <> "" Then
            arg = New SqlParameter("@NOMBRES", SqlDbType.VarChar)
            arg.Value = NOMBRES.ToUpper
            args.Add(arg)
            AgregarCondicion(strCond, "P.NOMBRES LIKE '%' + @NOMBRES + '%'")
        End If
        If DUI <> "" Then
            arg = New SqlParameter("@DUI", SqlDbType.VarChar)
            arg.Value = DUI
            args.Add(arg)
            AgregarCondicion(strCond, "P.DUI = @DUI")
        End If
        If NIT <> "" Then
            arg = New SqlParameter("@NIT", SqlDbType.VarChar)
            arg.Value = NIT
            args.Add(arg)
            AgregarCondicion(strCond, "P.NIT = @NIT")
        End If
        If NRC <> "" Then
            arg = New SqlParameter("@NRC", SqlDbType.VarChar)
            arg.Value = NRC
            args.Add(arg)
            AgregarCondicion(strCond, "P.NRC = @NRC")
        End If

        strSQL.Append(strCond.ToString)
        strSQL.Append(" ORDER BY P.NOMBRES ")

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaBASE_PROVEEDORES_MH

        Try
            Do While dr.Read()
                Dim mEntidad As New BASE_PROVEEDORES_MH
                dbAsignarEntidades.AsignarBASE_PROVEEDORES_MH(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista
    End Function

    Public Function ACTUALIZAR_CATALOGOS_PROVEEDORES(ByVal DUI As String, ByVal NIT As String) As Int32
        Dim lRet As Int32 = 0

        Dim cnLocal As New SqlConnection(Me.cnnStr)
        Dim cmd As New SqlCommand()
        cnLocal.Open()
        cmd.Connection = cnLocal

        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter


        arg = New SqlParameter("@DUI", SqlDbType.VarChar)
        arg.Value = DUI
        args.Add(arg)
        cmd.Parameters.Add(arg)

        arg = New SqlParameter("@NIT", SqlDbType.VarChar)
        arg.Value = NIT
        args.Add(arg)
        cmd.Parameters.Add(arg)

        Try

            cmd.CommandText = "dbo.ACTUALIZAR_CATALOGOS_PROVEEDORES"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandTimeout = 900000
            cmd.ExecuteNonQuery()
            cnLocal.Close()
            cnLocal = Nothing

            Return 1

        Catch ex As Exception
            Throw ex
        End Try

        Return lRet
    End Function
End Class
