Partial Public Class dbCUENTA_FINAN

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCriterios(ByVal agregarVacio As Boolean, ByVal APLICA_SOLIC_AGRICOLA As Boolean) As listaCUENTA_FINAN
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        strSQL.Append("SELECT * FROM CUENTA_FINAN ")


        arg = New SqlParameter("@APLICA_SOLIC_AGRICOLA", SqlDbType.Bit)
        arg.Value = If(APLICA_SOLIC_AGRICOLA, 1, 0)
        args.Add(arg)
        AgregarCondicion(strCond, "APLICA_SOLIC_AGRICOLA = @APLICA_SOLIC_AGRICOLA")

        strSQL.Append(strCond.ToString)
        strSQL.Append(" ORDER BY NOMBRE_CUENTA")

        Dim dr As IDataReader

        If args.Count > 0 Then
            dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
        Else
            dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        End If

        Dim lista As New listaCUENTA_FINAN

        Try
            Do While dr.Read()
                Dim mEntidad As New CUENTA_FINAN
                dbAsignarEntidades.AsignarCUENTA_FINAN(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
            If agregarVacio AndAlso lista.Count > 0 Then
                Dim lEntidad As New CUENTA_FINAN
                lEntidad.ID_CUENTA_FINAN = -1
                lEntidad.NOMBRE_CUENTA = ""
                lista.Insertar(0, lEntidad)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerListaParaSolicTransporte(ByVal agregarVacio As Boolean) As listaCUENTA_FINAN
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        strSQL.Append("SELECT * FROM CUENTA_FINAN WHERE APLICA_SOLIC_TRANSPORTE = 1")

        strSQL.Append(strCond.ToString)
        strSQL.Append(" ORDER BY NOMBRE_CUENTA")

        Dim dr As IDataReader

        If args.Count > 0 Then
            dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
        Else
            dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        End If

        Dim lista As New listaCUENTA_FINAN

        Try
            Do While dr.Read()
                Dim mEntidad As New CUENTA_FINAN
                dbAsignarEntidades.AsignarCUENTA_FINAN(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
            If agregarVacio AndAlso lista.Count > 0 Then
                Dim lEntidad As New CUENTA_FINAN
                lEntidad.ID_CUENTA_FINAN = -1
                lEntidad.NOMBRE_CUENTA = ""
                lista.Insertar(0, lEntidad)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerListaParaSolicFrentes(ByVal agregarVacio As Boolean) As listaCUENTA_FINAN
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        strSQL.Append("SELECT * FROM CUENTA_FINAN WHERE APLICA_SOLIC_FRENTES = 1")

        strSQL.Append(strCond.ToString)
        strSQL.Append(" ORDER BY NOMBRE_CUENTA")

        Dim dr As IDataReader

        If args.Count > 0 Then
            dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
        Else
            dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        End If

        Dim lista As New listaCUENTA_FINAN

        Try
            Do While dr.Read()
                Dim mEntidad As New CUENTA_FINAN
                dbAsignarEntidades.AsignarCUENTA_FINAN(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
            If agregarVacio AndAlso lista.Count > 0 Then
                Dim lEntidad As New CUENTA_FINAN
                lEntidad.ID_CUENTA_FINAN = -1
                lEntidad.NOMBRE_CUENTA = ""
                lista.Insertar(0, lEntidad)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerListaParaSolicFrentes2(ByVal agregarVacio As Boolean) As listaCUENTA_FINAN
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        strSQL.Append("SELECT DISTINCT C.* FROM CREDITO_ENCA_FRENTE F, CUENTA_FINAN C WHERE F.ID_CUENTA_FINAN = C.ID_CUENTA_FINAN")

        strSQL.Append(strCond.ToString)
        strSQL.Append(" ORDER BY C.ID_CUENTA_FINAN")

        Dim dr As IDataReader

        If args.Count > 0 Then
            dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
        Else
            dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        End If

        Dim lista As New listaCUENTA_FINAN

        Try
            Do While dr.Read()
                Dim mEntidad As New CUENTA_FINAN
                dbAsignarEntidades.AsignarCUENTA_FINAN(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
            If agregarVacio AndAlso lista.Count > 0 Then
                Dim lEntidad As New CUENTA_FINAN
                lEntidad.ID_CUENTA_FINAN = -1
                lEntidad.NOMBRE_CUENTA = ""
                lista.Insertar(0, lEntidad)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista
    End Function
End Class
