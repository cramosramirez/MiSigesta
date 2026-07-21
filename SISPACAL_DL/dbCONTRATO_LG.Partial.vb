Partial Public Class dbCONTRATO_LG
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerListaPorCriterios(ByVal ID_ZAFRA As Int32,
                                             ByVal NO_CONTRATO As Int32,
                                             ByVal CODIPROVEE As String,
                                             ByVal CODISOCIO As String) As listaCONTRATO_LG
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        strSQL.Append("SELECT C.* FROM CONTRATO_LG C ")

        If ID_ZAFRA <> -1 Then
            arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
            arg.Value = ID_ZAFRA
            args.Add(arg)
            AgregarCondicion(strCond, "EXISTS(SELECT 1 FROM CONTRATO_ZAFRAS_LG CZ WHERE CZ.CODICONTRATO = C.CODICONTRATO AND CZ.ID_ZAFRA = @ID_ZAFRA)")
        End If
        If NO_CONTRATO <> -1 Then
            arg = New SqlParameter("@NO_CONTRATO", SqlDbType.Int)
            arg.Value = NO_CONTRATO
            args.Add(arg)
            AgregarCondicion(strCond, "C.NO_CONTRATO = @NO_CONTRATO")
        End If
        If CODIPROVEE <> "" Then
            arg = New SqlParameter("@CODIPROVEE", SqlDbType.Char)
            arg.Value = CODIPROVEE
            args.Add(arg)
            AgregarCondicion(strCond, "EXISTS(SELECT 1 FROM PROVEEDOR P WHERE P.CODIPROVEEDOR = C.CODIPROVEEDOR AND P.CODIPROVEE = @CODIPROVEE)")
        End If
        If CODISOCIO <> "" Then
            arg = New SqlParameter("@CODISOCIO", SqlDbType.Char)
            arg.Value = CODISOCIO
            args.Add(arg)
            AgregarCondicion(strCond, "EXISTS(SELECT 1 FROM PROVEEDOR P WHERE P.CODIPROVEEDOR = C.CODIPROVEEDOR AND P.CODISOCIO = @CODISOCIO)")
        End If

        strSQL.Append(strCond.ToString)
        strSQL.Append(" ORDER BY C.NO_CONTRATO ")

        Dim dr As IDataReader

        If args.Count > 0 Then
            dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
        Else
            dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        End If

        Dim lista As New listaCONTRATO_LG

        Try
            Do While dr.Read()
                Dim mEntidad As New CONTRATO_LG
                dbAsignarEntidades.AsignarCONTRATO_LG(dr, mEntidad)
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
    ''' Función que Actualiza o Ingresa un registro de la Entidad que recibe de 
    ''' parámetro; en el caso de que sea actualizar toma en cuenta el Tipo de 
    ''' Concurrencia recibida de parametro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad que contiene los datos a Actualizar o Ingresar.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia del Registro a Actualizar.</param>
    ''' <remarks>La entidad ya debe estar inicializada. Si es una tabla de Muchos a Muchos
    ''' este método unicamente actualiza el registro. Si no es una tabla de Muchos a Muchos
    ''' puede Actualizar o insertar un registro, dependiendo si la llave única trae un valor
    ''' de Cero(0) para ser autoincrementada por el método de la Clase de Acceso a Datos.</remarks>
    ''' <history>
    ''' 	[GenApp]	23/06/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overloads Function Actualizar(ByVal aEntidad As entidadBase, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer

        Dim lEntidad As CONTRATO_LG
        lEntidad = CType(aEntidad, CONTRATO_LG)

        If lEntidad.CODICONTRATO = "" Then
            lEntidad.CODICONTRATO = lEntidad.ANIOZAFRA + Utilerias.RellenarIzquierda(CStr(lEntidad.NO_CONTRATO), 4)
            Return Agregar(lEntidad)
        End If

        Dim strSQL As New StringBuilder


        Dim args(0) As SqlParameter

        strSQL.Append(Me.QueryUpdate(aEntidad, args, aTipoConcurrencia))

        Return SqlHelper.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function


    Public Function ObtenerCorrelativoContrato() As Int32
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim lRet As Int32

        strSQL.Append("SELECT ISNULL(MAX(C.NO_CONTRATO),0) + 1 AS CORRELATIVO FROM CONTRATO_LG C ")

        Try
            lRet = SqlHelper.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Catch ex As Exception
            Throw ex
        End Try

        Return lRet
    End Function

    Public Function ObtenerCorrelativoContratoPorZafra(ByVal ID_ZAFRA As Int32) As Int32
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim lRet As Int32 = -1

        arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        arg.Value = ID_ZAFRA
        args.Add(arg)

        Try
            Dim dr As IDataReader

            dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.StoredProcedure, "OBTENER_CORRELATIVO_CONTRATO_LG", args.ToArray)

            If dr.Read Then
                lRet = CInt(dr(0))
            End If

        Catch ex As Exception
            Throw ex
        End Try

        Return lRet
    End Function

End Class
