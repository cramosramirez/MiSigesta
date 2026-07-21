Imports System.Text
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_DL
''' Class	 : DL.dbCONTROL_ROZA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Acceso a Datos que contiene las operaciones CRUD(Create, Read,
''' Update y Delete) de la tabla CONTROL_ROZA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	09/01/2018	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class dbCONTROL_ROZA
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
    ''' 	[GenApp]	09/01/2018	Created
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
    ''' 	[GenApp]	09/01/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overloads Function Actualizar(ByVal aEntidad As entidadBase, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer

        Dim lEntidad As CONTROL_ROZA
        lEntidad = CType(aEntidad, CONTROL_ROZA)

        Dim lID As Int32
        If lEntidad.ID_CONTROL_ROZA =  0 _
            Or lEntidad.ID_CONTROL_ROZA = Nothing Then 

            lID = CType(Me.ObtenerID(lEntidad), Int32)

            If lID = -1 Then Return -1

            lEntidad.ID_CONTROL_ROZA = lID

            Return Agregar(lEntidad)

        End If

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
    ''' 	[GenApp]	09/01/2018	Created
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
    ''' Función que Elimina un Registro de la Tabla CONTROL_ROZA que se le envía como parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde viene se obtienen los valores de la llave 
    ''' primaria del registro a eliminar.</param>
    ''' <remarks>Por defecto manda a ejecutar eliminación con concurrencia pesimistica.
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	09/01/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer
        Return Me.Eliminar(aEntidad, TipoConcurrencia.Pesimistica)
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla CONTROL_ROZA que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde viene se obtienen los valores de la llave 
    ''' primaria del registro a eliminar.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el 
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	09/01/2018	Created
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
    ''' 	[GenApp]	09/01/2018	Created
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
                dbAsignarEntidades.AsignarCONTROL_ROZA(dr, CType(aEntidad,CONTROL_ROZA))
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
    ''' 	[GenApp]	09/01/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function RecuperarConForaneas(ByVal aEntidad As CONTROL_ROZA, Optional ByVal aZAFRA As Boolean = False, Optional ByVal aLOTES As Boolean = False, Optional ByVal aPROVEEDOR_ROZA As Boolean = False, Optional ByVal aTIPOS_GENERALES As Boolean = False, Optional ByVal aCONTROL_ROZA_SALDO As Boolean = False) As Integer

        Dim strSQL As New StringBuilder
        Dim args(0) As SqlParameter

        If aZAFRA Or aLOTES Or aPROVEEDOR_ROZA Or aTIPOS_GENERALES Or aCONTROL_ROZA_SALDO Then
            Dim numTabla As Integer = 0
            Dim strCampos, strWhere As String
            strCampos = ""
            strWhere = ""
            Me.QuerySelectCampos(aEntidad, args, GetType(CONTROL_ROZA), GetType(SqlParameter), strCampos, strWhere, 0, "CONTROL_ROZA")
            strSQL.AppendLine("SELECT " + strCampos)
            If aZAFRA Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New ZAFRA, Nothing, GetType(ZAFRA), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aLOTES Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New LOTES, Nothing, GetType(LOTES), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aPROVEEDOR_ROZA Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New PROVEEDOR_ROZA, Nothing, GetType(PROVEEDOR_ROZA), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aTIPOS_GENERALES Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New TIPOS_GENERALES, Nothing, GetType(TIPOS_GENERALES), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aCONTROL_ROZA_SALDO Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New CONTROL_ROZA_SALDO, Nothing, GetType(CONTROL_ROZA_SALDO), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            strSQL.AppendLine("FROM CONTROL_ROZA")
            numTabla = 0
            If aZAFRA Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN ZAFRA T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_ZAFRA = CONTROL_ROZA.ID_ZAFRA")
            End If
            If aLOTES Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN LOTES T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ACCESLOTE = CONTROL_ROZA.ACCESLOTE")
            End If
            If aPROVEEDOR_ROZA Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN PROVEEDOR_ROZA T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_PROVEEDOR_ROZA = CONTROL_ROZA.ID_PROVEEDOR_ROZA")
            End If
            If aTIPOS_GENERALES Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN TIPOS_GENERALES T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_TIPO = CONTROL_ROZA.ID_TIPO_CANA AND T" + numTabla.ToString() + ".ID_TIPO = CONTROL_ROZA.ID_TIPO_ROZA")
            End If
            If aCONTROL_ROZA_SALDO Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN CONTROL_ROZA_SALDO T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_ROZA_SALDO = CONTROL_ROZA.ID_ROZA_SALDO")
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
                dbAsignarEntidades.AsignarCONTROL_ROZA(dr, aEntidad)
                Dim numTabla As Integer = 0
                If aZAFRA Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarZAFRA(dr, aEntidad.fkID_ZAFRA, "T" + numTabla.ToString())
                End If
                If aLOTES Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarLOTES(dr, aEntidad.fkACCESLOTE, "T" + numTabla.ToString())
                End If
                If aPROVEEDOR_ROZA Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarPROVEEDOR_ROZA(dr, aEntidad.fkID_PROVEEDOR_ROZA, "T" + numTabla.ToString())
                End If
                If aTIPOS_GENERALES Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarTIPOS_GENERALES(dr, aEntidad.fkID_TIPO_CANA, "T" + numTabla.ToString())
                End If
                If aCONTROL_ROZA_SALDO Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarCONTROL_ROZA_SALDO(dr, aEntidad.fkID_ROZA_SALDO, "T" + numTabla.ToString())
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

        Dim strSQL As New StringBuilder
        strSQL.AppendLine("SELECT isnull(max(ID_CONTROL_ROZA),0) + 1 ")
        strSQL.AppendLine(" FROM CONTROL_ROZA ")

        Return SqlHelper.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString())

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	09/01/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorID(ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaCONTROL_ROZA

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New CONTROL_ROZA))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New listaCONTROL_ROZA

        Try
            Do While dr.Read()
                Dim mEntidad As New CONTROL_ROZA
                dbAsignarEntidades.AsignarCONTROL_ROZA(dr, mEntidad)
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
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	09/01/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetPorID(ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New CONTROL_ROZA))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim ds As DataSet

        ds = SqlHelper.ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Return ds

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que llena un DataSet filtrado por los parámetros de la Tabla Padre,
    ''' si no tiene una tabla Padre llena con todos los registros de la Entidad.
    ''' </summary>
    ''' <param name="ds"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	09/01/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetPorID(ByRef ds as DataSet, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As Integer

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New CONTROL_ROZA))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim tables(0) As String
        tables(0) = New String("CONTROL_ROZA".ToCharArray())

        SqlHelper.FillDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables)

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
    ''' 	[GenApp]	09/01/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub SelectTabla(ByRef strSQL as StringBuilder)

        strSQL.AppendLine(" SELECT CONTROL_ROZA.ID_CONTROL_ROZA, ")
        strSQL.AppendLine(" CONTROL_ROZA.ID_ZAFRA, ")
        strSQL.AppendLine(" CONTROL_ROZA.ACCESLOTE, ")
        strSQL.AppendLine(" CONTROL_ROZA.DIAZAFRA, ")
        strSQL.AppendLine(" CONTROL_ROZA.CONCEPTO, ")
        strSQL.AppendLine(" CONTROL_ROZA.CODIGO_REF, ")
        strSQL.AppendLine(" CONTROL_ROZA.ID_REF, ")
        strSQL.AppendLine(" CONTROL_ROZA.ENTRADAS, ")
        strSQL.AppendLine(" CONTROL_ROZA.SALIDAS, ")
        strSQL.AppendLine(" CONTROL_ROZA.SALDO, ")
        strSQL.AppendLine(" CONTROL_ROZA.USUARIO_CREA, ")
        strSQL.AppendLine(" CONTROL_ROZA.FECHA_CREA, ")
        strSQL.AppendLine(" CONTROL_ROZA.USUARIO_ACT, ")
        strSQL.AppendLine(" CONTROL_ROZA.FECHA_ACT, ")
        strSQL.AppendLine(" CONTROL_ROZA.FECHA_HORA_ROZA, ")
        strSQL.AppendLine(" CONTROL_ROZA.ID_PROVEEDOR_ROZA, ")
        strSQL.AppendLine(" CONTROL_ROZA.ID_TIPO_CANA, ")
        strSQL.AppendLine(" CONTROL_ROZA.ID_TIPO_ROZA, ")
        strSQL.AppendLine(" CONTROL_ROZA.QUEMA_PROGRAMADA, ")
        strSQL.AppendLine(" CONTROL_ROZA.QUEMA_NOPROG, ")
        strSQL.AppendLine(" CONTROL_ROZA.CANA_VERDE, ")
        strSQL.AppendLine(" CONTROL_ROZA.FECHA_HORA_QUEMA, ")
        strSQL.AppendLine(" CONTROL_ROZA.ID_ROZA_SALDO, ")
        strSQL.AppendLine(" CONTROL_ROZA.ES_PROYECCION, ")
        strSQL.AppendLine(" CONTROL_ROZA.ES_QUERQUEO, ")
        strSQL.AppendLine(" CONTROL_ROZA.ID_PROVEE_QQ, ")
        strSQL.AppendLine(" CONTROL_ROZA.ID_SUBLOTES ")
        strSQL.AppendLine(" FROM CONTROL_ROZA ")

    End Sub

#Region "Obtener Listas Por Foraneas"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Foranea, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="ID_ZAFRA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	09/01/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorZAFRA(ByVal ID_ZAFRA As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaCONTROL_ROZA

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New CONTROL_ROZA))
        strSQL.Append(" WHERE ID_ZAFRA = @ID_ZAFRA ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        args(0).Value = ID_ZAFRA

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaCONTROL_ROZA

        Try
            Do While dr.Read()
                Dim mEntidad As New CONTROL_ROZA
                dbAsignarEntidades.AsignarCONTROL_ROZA(dr, mEntidad)
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
    ''' <param name="ACCESLOTE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	09/01/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorLOTES(ByVal ACCESLOTE As String, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaCONTROL_ROZA

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New CONTROL_ROZA))
        strSQL.Append(" WHERE ACCESLOTE = @ACCESLOTE ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ACCESLOTE", SqlDbType.VarChar)
        args(0).Value = ACCESLOTE

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaCONTROL_ROZA

        Try
            Do While dr.Read()
                Dim mEntidad As New CONTROL_ROZA
                dbAsignarEntidades.AsignarCONTROL_ROZA(dr, mEntidad)
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
    ''' <param name="ID_PROVEEDOR_ROZA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	09/01/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorPROVEEDOR_ROZA(ByVal ID_PROVEEDOR_ROZA As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaCONTROL_ROZA

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New CONTROL_ROZA))
        strSQL.Append(" WHERE ID_PROVEEDOR_ROZA = @ID_PROVEEDOR_ROZA ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_PROVEEDOR_ROZA", SqlDbType.Int)
        args(0).Value = ID_PROVEEDOR_ROZA

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaCONTROL_ROZA

        Try
            Do While dr.Read()
                Dim mEntidad As New CONTROL_ROZA
                dbAsignarEntidades.AsignarCONTROL_ROZA(dr, mEntidad)
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
    ''' <param name="ID_TIPO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	09/01/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorTIPOS_GENERALES(ByVal ID_TIPO As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaCONTROL_ROZA

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New CONTROL_ROZA))
        strSQL.Append(" WHERE ID_TIPO = @ID_TIPO ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_TIPO", SqlDbType.Int)
        args(0).Value = ID_TIPO

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaCONTROL_ROZA

        Try
            Do While dr.Read()
                Dim mEntidad As New CONTROL_ROZA
                dbAsignarEntidades.AsignarCONTROL_ROZA(dr, mEntidad)
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
    ''' <param name="ID_ROZA_SALDO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	09/01/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorCONTROL_ROZA_SALDO(ByVal ID_ROZA_SALDO As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaCONTROL_ROZA

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New CONTROL_ROZA))
        strSQL.Append(" WHERE ID_ROZA_SALDO = @ID_ROZA_SALDO ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_ROZA_SALDO", SqlDbType.Int)
        args(0).Value = ID_ROZA_SALDO

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaCONTROL_ROZA

        Try
            Do While dr.Read()
                Dim mEntidad As New CONTROL_ROZA
                dbAsignarEntidades.AsignarCONTROL_ROZA(dr, mEntidad)
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
