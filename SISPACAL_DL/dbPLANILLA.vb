Imports System.Text
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_DL
''' Class	 : DL.dbPLANILLA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Acceso a Datos que contiene las operaciones CRUD(Create, Read,
''' Update y Delete) de la tabla PLANILLA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	05/12/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class dbPLANILLA
    Inherits dbBase

#Region " Metodos Generador "

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Actualiza o Ingresa un registro de la Entidad que recibe de parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad que contiene los datos a Actualizar o Ingresar.</param>
    ''' <remarks>La entidad ya debe estar inicializada. Si es una tabla de Muchos a Muchos
    ''' este método unicamente actualiza el registro. Si no es una tabla de Muchos a Muchos
    ''' puede Actualizar o insertar un registro, dependiendo si la llave única trae un valor
    ''' de Cero(0) para ser autoincrementada por el método de la Clase de Acceso a Datos.</remarks>
    ''' <history>
    ''' 	[GenApp]	05/12/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Actualizar(ByVal aEntidad As entidadBase) As Integer
        Return Me.Actualizar(aEntidad, TipoConcurrencia.Pesimistica)
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

        Dim lEntidad As PLANILLA
        lEntidad = CType(aEntidad, PLANILLA)


        Dim strSQL As New StringBuilder


        Dim args(0) As SqlParameter

        strSQL.Append(Me.QueryUpdate(aEntidad, args, aTipoConcurrencia))

        Return SqlHelper.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Ingresa un registro de la Entidad que recibe como parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad que contiene los datos a Ingresar.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados al menos los
    ''' valores de la Llave Primaria, para su inserción.</remarks>
    ''' <history>
    ''' 	[GenApp]	05/12/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim strSQL As New StringBuilder


        Dim args(0) As SqlParameter

        strSQL.Append(Me.QueryInsert(aEntidad, args))


        Return SqlHelper.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla PLANILLA que se le envía como parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde viene se obtienen los valores de la llave 
    ''' primaria del registro a eliminar.</param>
    ''' <remarks>Por defecto manda a ejecutar eliminación con concurrencia pesimistica.
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/12/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer
        Return Me.Eliminar(aEntidad, TipoConcurrencia.Pesimistica)
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla PLANILLA que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde viene se obtienen los valores de la llave 
    ''' primaria del registro a eliminar.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el 
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/12/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overloads Function Eliminar(ByVal aEntidad As entidadBase, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer

        Dim strSQL As New StringBuilder
        Dim args(0) As SqlParameter

        strSQL.Append(Me.QueryDelete(aEntidad, args, aTipoConcurrencia))

        Return SqlHelper.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que selecciona un registro y lo setea en la Entidad que recibe de
    ''' parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde se ingresara el registro seleccionado.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	05/12/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Recuperar(ByVal aEntidad As entidadBase) As Integer

        Dim strSQL As New StringBuilder
        Dim args(0) As SqlParameter

        strSQL.Append(Me.QuerySelect(aEntidad, args))

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dr Is Nothing Then Return 0

        Try
            If dr.Read() Then
                dbAsignarEntidades.AsignarPLANILLA(dr, CType(aEntidad,PLANILLA))
            Else
                Return 0
            End If
        Catch ex As Exception 
            Throw ex
        Finally
            dr.Close()
        End Try

        Return 1

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que selecciona un registro y lo setea en la Entidad que recibe de
    ''' parámetro, ademas de permitir agregar en la Entidad las Foraneas.
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde se ingresara el registro seleccionado.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	05/12/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function RecuperarConForaneas(ByVal aEntidad As PLANILLA, Optional ByVal aCATORCENA_ZAFRA As Boolean = False, Optional ByVal aTIPO_PLANILLA As Boolean = False, Optional ByVal aCHEQUE_PLANILLA As Boolean = False) As Integer

        Dim strSQL As New StringBuilder
        Dim args(0) As SqlParameter

        If aCATORCENA_ZAFRA Or aTIPO_PLANILLA Or aCHEQUE_PLANILLA Then
            Dim numTabla As Integer = 0
            Dim strCampos, strWhere As String
            strCampos = ""
            strWhere = ""
            Me.QuerySelectCampos(aEntidad, args, GetType(PLANILLA), GetType(SqlParameter), strCampos, strWhere, 0, "PLANILLA")
            strSQL.AppendLine("SELECT " + strCampos)
            If aCATORCENA_ZAFRA Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New CATORCENA_ZAFRA, Nothing, GetType(CATORCENA_ZAFRA), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aTIPO_PLANILLA Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New TIPO_PLANILLA, Nothing, GetType(TIPO_PLANILLA), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aCHEQUE_PLANILLA Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New CHEQUE_PLANILLA, Nothing, GetType(CHEQUE_PLANILLA), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            strSQL.AppendLine("FROM PLANILLA")
            numTabla = 0
            If aCATORCENA_ZAFRA Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN CATORCENA_ZAFRA T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_CATORCENA = PLANILLA.ID_CATORCENA")
            End If
            If aTIPO_PLANILLA Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN TIPO_PLANILLA T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_TIPO_PLANILLA = PLANILLA.ID_TIPO_PLANILLA")
            End If
            If aCHEQUE_PLANILLA Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN CHEQUE_PLANILLA T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_CHEQUE_PLANILLA = PLANILLA.ID_CHEQUE_PLANILLA")
            End If
            strSQL.Append(strWhere)
        Else
            strSQL.Append(Me.QuerySelect(aEntidad, args))
        End If

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dr Is Nothing Then Return 0

        Try
            If dr.Read() Then
                dbAsignarEntidades.AsignarPLANILLA(dr, aEntidad)
                Dim numTabla As Integer = 0
                If aCATORCENA_ZAFRA Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarCATORCENA_ZAFRA(dr, aEntidad.fkID_CATORCENA, "T" + numTabla.ToString())
                End If
                If aTIPO_PLANILLA Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarTIPO_PLANILLA(dr, aEntidad.fkID_TIPO_PLANILLA, "T" + numTabla.ToString())
                End If
                If aCHEQUE_PLANILLA Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarCHEQUE_PLANILLA(dr, aEntidad.fkID_CHEQUE_PLANILLA, "T" + numTabla.ToString())
                End If
            Else
                Return 0
            End If
        Catch ex As Exception 
            Throw ex
        Finally
            dr.Close()
        End Try

        Return 1

    End Function

    Public Overrides Function ObtenerID(ByVal aEntidad As entidadBase) As Object

        Return -1

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="ID_CATORCENA"></param>
    ''' <param name="ID_TIPO_PLANILLA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/12/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorID(ByVal ID_CATORCENA As Int32, ByVal ID_TIPO_PLANILLA As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaPLANILLA

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New PLANILLA))
        strSQL.Append(" WHERE ID_CATORCENA = @ID_CATORCENA ") 
        strSQL.Append(" AND ID_TIPO_PLANILLA = @ID_TIPO_PLANILLA ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ID_CATORCENA", SqlDbType.Int)
        args(0).Value = ID_CATORCENA
        args(1) = New SqlParameter("@ID_TIPO_PLANILLA", SqlDbType.Int)
        args(1).Value = ID_TIPO_PLANILLA

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaPLANILLA

        Try
            Do While dr.Read()
                Dim mEntidad As New PLANILLA
                dbAsignarEntidades.AsignarPLANILLA(dr, mEntidad)
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
    ''' Función que Devuelve un DataSet filtrado por los parámetros de la Tabla Padre,
    ''' si no tiene una tabla Padre devuelve todos los registros de la Entidad.
    ''' </summary>
    ''' <param name="ID_CATORCENA"></param>
    ''' <param name="ID_TIPO_PLANILLA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/12/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetPorID(ByVal ID_CATORCENA As Int32, ByVal ID_TIPO_PLANILLA As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New PLANILLA))
        strSQL.Append(" WHERE ID_CATORCENA = @ID_CATORCENA ") 
        strSQL.Append(" AND ID_TIPO_PLANILLA = @ID_TIPO_PLANILLA ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ID_CATORCENA", SqlDbType.Int)
        args(0).Value = ID_CATORCENA
        args(1) = New SqlParameter("@ID_TIPO_PLANILLA", SqlDbType.Int)
        args(1).Value = ID_TIPO_PLANILLA

        Dim ds As DataSet

        ds = SqlHelper.ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que llena un DataSet filtrado por los parámetros de la Tabla Padre,
    ''' si no tiene una tabla Padre llena con todos los registros de la Entidad.
    ''' </summary>
    ''' <param name="ID_CATORCENA"></param>
    ''' <param name="ID_TIPO_PLANILLA"></param>
    ''' <param name="ds"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/12/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetPorID(ByVal ID_CATORCENA As Int32, ByVal ID_TIPO_PLANILLA As Int32, ByRef ds as DataSet, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As Integer

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New PLANILLA))
        strSQL.Append(" WHERE ID_CATORCENA = @ID_CATORCENA ") 
        strSQL.Append(" AND ID_TIPO_PLANILLA = @ID_TIPO_PLANILLA ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ID_CATORCENA", SqlDbType.Int)
        args(0).Value = ID_CATORCENA
        args(1) = New SqlParameter("@ID_TIPO_PLANILLA", SqlDbType.Int)
        args(1).Value = ID_TIPO_PLANILLA

        Dim tables(0) As String
        tables(0) = New String("PLANILLA".ToCharArray())

        SqlHelper.FillDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables, args)

        Return 1

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve en el StringBuilder que recibe como parámetro el Query
    ''' de la Tabla de la Clase.
    ''' </summary>
    ''' <param name="strSQL">StringBuilder donde se escribe el Query</param>
    ''' <remarks>
    ''' Obsoleto, se recomienda utilizar los métodos del ancestro para esta operación.
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/12/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub SelectTabla(ByRef strSQL as StringBuilder)

        strSQL.AppendLine(" SELECT PLANILLA.ID_CATORCENA, ")
        strSQL.AppendLine(" PLANILLA.CODIPROVEEDOR_TRANSPORTISTA, ")
        strSQL.AppendLine(" PLANILLA.ID_TIPO_PLANILLA, ")
        strSQL.AppendLine(" PLANILLA.NOMBRE_ZAFRA, ")
        strSQL.AppendLine(" PLANILLA.CODIPROVEE, ")
        strSQL.AppendLine(" PLANILLA.CODISOCIO, ")
        strSQL.AppendLine(" PLANILLA.CANT_RECIBOS, ")
        strSQL.AppendLine(" PLANILLA.TONEL_CANA_ENTREGADA, ")
        strSQL.AppendLine(" PLANILLA.AZUCAR_CATORCENA_REAL, ")
        strSQL.AppendLine(" PLANILLA.VALOR, ")
        strSQL.AppendLine(" PLANILLA.IVA, ")
        strSQL.AppendLine(" PLANILLA.VALOR_BRUTO, ")
        strSQL.AppendLine(" PLANILLA.RENTA, ")
        strSQL.AppendLine(" PLANILLA.RETENCION_IVA, ")
        strSQL.AppendLine(" PLANILLA.DESC_FLETE, ")
        strSQL.AppendLine(" PLANILLA.DESC_CARGA, ")
        strSQL.AppendLine(" PLANILLA.DESC_CARGA_CONTRA, ")
        strSQL.AppendLine(" PLANILLA.DESC_BANCOS, ")
        strSQL.AppendLine(" PLANILLA.DESC_COMBUSTIBLE, ")
        strSQL.AppendLine(" PLANILLA.DESC_ANTICIPO, ")
        strSQL.AppendLine(" PLANILLA.DESC_INTERES, ")
        strSQL.AppendLine(" PLANILLA.DESC_AGROQUIMICO, ")
        strSQL.AppendLine(" PLANILLA.DESC_SEGURO, ")
        strSQL.AppendLine(" PLANILLA.DESC_RESPUESTOS, ")
        strSQL.AppendLine(" PLANILLA.DESC_OTROS, ")
        strSQL.AppendLine(" PLANILLA.PAGO_NETO, ")
        strSQL.AppendLine(" PLANILLA.ES_CONTRIBUYENTE, ")
        strSQL.AppendLine(" PLANILLA.USUARIO_CREA, ")
        strSQL.AppendLine(" PLANILLA.FECHA_CREA, ")
        strSQL.AppendLine(" PLANILLA.USUARIO_ACT, ")
        strSQL.AppendLine(" PLANILLA.FECHA_ACT, ")
        strSQL.AppendLine(" PLANILLA.DESC_SERVICIO_ROZA, ")
        strSQL.AppendLine(" PLANILLA.NOMBRE_PROVEE_TRANS, ")
        strSQL.AppendLine(" PLANILLA.NO_CHEQUE, ")
        strSQL.AppendLine(" PLANILLA.ID_CHEQUE_PLANILLA, ")
        strSQL.AppendLine(" PLANILLA.ID_PLANILLA_BASE, ")
        strSQL.AppendLine(" PLANILLA.ID_TIPO_PROVEEDOR ")
        strSQL.AppendLine(" FROM PLANILLA ")

    End Sub

#Region "Obtener Listas Por Foraneas"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Foranea, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="ID_CATORCENA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/12/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorCATORCENA_ZAFRA(ByVal ID_CATORCENA As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaPLANILLA

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New PLANILLA))
        strSQL.Append(" WHERE ID_CATORCENA = @ID_CATORCENA ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_CATORCENA", SqlDbType.Int)
        args(0).Value = ID_CATORCENA

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaPLANILLA

        Try
            Do While dr.Read()
                Dim mEntidad As New PLANILLA
                dbAsignarEntidades.AsignarPLANILLA(dr, mEntidad)
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
    ''' <param name="ID_TIPO_PLANILLA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/12/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorTIPO_PLANILLA(ByVal ID_TIPO_PLANILLA As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaPLANILLA

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New PLANILLA))
        strSQL.Append(" WHERE ID_TIPO_PLANILLA = @ID_TIPO_PLANILLA ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_TIPO_PLANILLA", SqlDbType.Int)
        args(0).Value = ID_TIPO_PLANILLA

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaPLANILLA

        Try
            Do While dr.Read()
                Dim mEntidad As New PLANILLA
                dbAsignarEntidades.AsignarPLANILLA(dr, mEntidad)
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
    ''' <param name="ID_CHEQUE_PLANILLA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/12/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorCHEQUE_PLANILLA(ByVal ID_CHEQUE_PLANILLA As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaPLANILLA

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New PLANILLA))
        strSQL.Append(" WHERE ID_CHEQUE_PLANILLA = @ID_CHEQUE_PLANILLA ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_CHEQUE_PLANILLA", SqlDbType.Int)
        args(0).Value = ID_CHEQUE_PLANILLA

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaPLANILLA

        Try
            Do While dr.Read()
                Dim mEntidad As New PLANILLA
                dbAsignarEntidades.AsignarPLANILLA(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

#End Region

#End Region

End Class
