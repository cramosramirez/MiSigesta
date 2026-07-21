Partial Public Class dbTRANSPORTISTA


    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerListaPorNombreCompleto(ByVal NOMBRE_TRANSPORTISTA As String) As listaTRANSPORTISTA
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        strSQL.Append("SELECT * FROM TRANSPORTISTA ")

        arg = New SqlParameter("@NOMBRE_TRANSPORTISTA", SqlDbType.NVarChar)
        arg.Value = "%" & Replace(NOMBRE_TRANSPORTISTA.ToUpper, " ", "%") & "%"
        args.Add(arg)
        AgregarCondicion(strCond, "RTRIM(ISNULL(NOMBRES,'')) + ' ' + RTRIM(ISNULL(APELLIDOS,'')) LIKE @NOMBRE_TRANSPORTISTA")

        strSQL.Append(strCond.ToString)
        strSQL.Append(" ORDER BY APELLIDOS ")

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaTRANSPORTISTA

        Try
            Do While dr.Read()
                Dim mEntidad As New TRANSPORTISTA
                dbAsignarEntidades.AsignarTRANSPORTISTA(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerListaPorZAFRA_CONTRATADA(ByVal ID_ZAFRA_CONTRATADA As String) As listaTRANSPORTISTA
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        strSQL.Append("SELECT * FROM TRANSPORTISTA T ")

        If ID_ZAFRA_CONTRATADA <> -1 Then
            arg = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
            arg.Value = ID_ZAFRA_CONTRATADA
            args.Add(arg)
            AgregarCondicion(strCond, "(SELECT COUNT(1) FROM CONTRATO_TRANS C WHERE C.CODTRANSPORT = T.CODTRANSPORT AND C.ID_ZAFRA = @ID_ZAFRA) > 0 ")
        End If

        strSQL.Append(strCond.ToString)

        strSQL.Append(" ORDER BY APELLIDOS ")

        Dim dr As IDataReader

        If args.Count > 0 Then
            dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
        Else
            dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        End If


        Dim lista As New listaTRANSPORTISTA

        Try
            Do While dr.Read()
                Dim mEntidad As New TRANSPORTISTA
                dbAsignarEntidades.AsignarTRANSPORTISTA(dr, mEntidad)
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
    ''' 	[GenApp]	05/12/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overloads Function Actualizar(ByVal aEntidad As entidadBase, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer

        Dim lEntidad As TRANSPORTISTA
        lEntidad = CType(aEntidad, TRANSPORTISTA)

        Dim lID As Int32

        If lEntidad.CODTRANSPORT = 0 _
            Or lEntidad.CODTRANSPORT = Nothing Then

            lID = CType(Me.ObtenerID(lEntidad), Int32)

            If lID = -1 Then Return -1

            lEntidad.CODTRANSPORT = lID

            Return Agregar(lEntidad)
        Else
            Dim _Entidad As New TRANSPORTISTA
            Dim lRet As Integer

            _Entidad.CODTRANSPORT = lEntidad.CODTRANSPORT
            lRet = Me.Recuperar(_Entidad)
            If lRet <> 1 Then Return Agregar(lEntidad)
        End If

        Dim strSQL As New StringBuilder


        Dim args(0) As SqlParameter

        strSQL.Append(Me.QueryUpdate(aEntidad, args, aTipoConcurrencia))

        Return SqlHelper.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Function ObtenerCorrelativoCtaContable() As String
        Dim strCuenta As String = ""
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        strSQL.Append("SELECT ISNULL(MAX(RTRIM(NOCUENTA)),'') FROM TRANSPORTISTA ")

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaTIPOS_GENERALES

        Try
            If dr.Read() Then
                Dim correlativo As Integer
                strCuenta = dr(0).ToString
                If strCuenta.Length > 0 Then
                    correlativo = Convert.ToInt32(Right(strCuenta, 3))
                    strCuenta = Left(strCuenta, strCuenta.Length - 3)
                    strCuenta = strCuenta + (correlativo + 1).ToString
                End If

            End If
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return strCuenta
    End Function
End Class
