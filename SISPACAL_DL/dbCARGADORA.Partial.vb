Partial Public Class dbCARGADORA

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
    ''' 	[GenApp]	18/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overloads Function Actualizar(ByVal aEntidad As entidadBase, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer

        Dim lEntidad As CARGADORA
        lEntidad = CType(aEntidad, CARGADORA)

        Dim lID As Int32
        If lEntidad.ID_CARGADORA = 0 _
            Or lEntidad.ID_CARGADORA = Nothing Then

            lID = CType(Me.ObtenerID(lEntidad), Int32)

            If lID = -1 Then Return -1

            lEntidad.ID_CARGADORA = lID

            Return Agregar(lEntidad)
        Else
            Dim _Entidad As New CARGADORA
            Dim lRet As Integer

            _Entidad.ID_CARGADORA = lEntidad.ID_CARGADORA
            lRet = Me.Recuperar(_Entidad)
            If lRet <> 1 Then Return Agregar(lEntidad)
        End If

        Dim strSQL As New StringBuilder


        Dim args(0) As SqlParameter

        strSQL.Append(Me.QueryUpdate(aEntidad, args, aTipoConcurrencia))

        Return SqlHelper.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Function ObtenerListaPorTIPO_ALZA(ByVal ID_TIPO_ALZA As Int32, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaCARGADORA
        Dim strSQL As New StringBuilder
        Dim args(0) As SqlParameter

        strSQL.Append(Me.QuerySelect(New CARGADORA))
        If ID_TIPO_ALZA = Enumeradores.CAT.TipoAlza.AlzaManualParticular OrElse _
            ID_TIPO_ALZA = Enumeradores.CAT.TipoAlza.AlzaManualProductor Then
            args(0) = New SqlParameter("@ID_CARGADORA", SqlDbType.Int)
            args(0).Value = 33

            strSQL.Append(" WHERE ID_CARGADORA = @ID_CARGADORA ")
        Else
            args(0) = New SqlParameter("@ID_TIPO_ALZA", SqlDbType.Int)
            args(0).Value = ID_TIPO_ALZA

            strSQL.Append(" WHERE ID_TIPO_ALZA = @ID_TIPO_ALZA AND ACTIVO = 1 ")
        End If
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaCARGADORA

        Try
            Do While dr.Read()
                Dim mEntidad As New CARGADORA
                dbAsignarEntidades.AsignarCARGADORA(dr, mEntidad)
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
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorID(Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaCARGADORA

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New CARGADORA))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New listaCARGADORA

        Try
            Do While dr.Read()
                Dim mEntidad As New CARGADORA
                dbAsignarEntidades.AsignarCARGADORA(dr, mEntidad)
                mEntidad.CODIGO_NOMBRE = mEntidad.ID_CARGADORA.ToString + " - " + mEntidad.NOMBRE
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
