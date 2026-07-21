Partial Public Class dbAGRONOMO

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerListaPorESTADO(ByVal ESTADO_AGRONOMO As Int32, ByVal asColumnaOrden As String, ByVal asTipoOrden As String) As listaAGRONOMO
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        strSQL.Append("SELECT * FROM AGRONOMO ")
        strSQL.Append("WHERE ESTADO_AGRONOMO = @ESTADO_AGRONOMO ")


        arg = New SqlParameter("@ESTADO_AGRONOMO", SqlDbType.Int)
        arg.Value = ESTADO_AGRONOMO
        args.Add(arg)

        If asColumnaOrden <> "" Then
            strSQL.Append(" ORDER BY " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaAGRONOMO

        Try
            Do While dr.Read()
                Dim mEntidad As New AGRONOMO
                dbAsignarEntidades.AsignarAGRONOMO(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Foranea, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="USUARIO_SIGESTA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/09/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorUSUARIO(ByVal USUARIO_SIGESTA As String, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaAGRONOMO

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New AGRONOMO))
        strSQL.Append(" WHERE USUARIO_SIGESTA = @USUARIO_SIGESTA ")
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@USUARIO_SIGESTA", SqlDbType.VarChar)
        args(0).Value = USUARIO_SIGESTA

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaAGRONOMO

        Try
            Do While dr.Read()
                Dim mEntidad As New AGRONOMO
                dbAsignarEntidades.AsignarAGRONOMO(dr, mEntidad)
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
    Public Function ObtenerListaParaContrato(ByVal asColumnaOrden As String, ByVal asTipoOrden As String) As listaAGRONOMO
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        strSQL.Append("SELECT * ")
        strSQL.Append("FROM AGRONOMO ")
        strSQL.Append("WHERE VER_CONTRATO = 1 ")

        If asColumnaOrden <> "" Then
            strSQL.Append(" ORDER BY " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As IDataReader


        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())


        Dim lista As New listaAGRONOMO

        Try
            Do While dr.Read()
                Dim mEntidad As New AGRONOMO
                dbAsignarEntidades.AsignarAGRONOMO(dr, mEntidad)
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
