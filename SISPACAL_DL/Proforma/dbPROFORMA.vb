Imports System.Text
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_DL
''' Class	 : DL.dbPROFORMA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Acceso a Datos que contiene las operaciones CRUD(Create, Read,
''' Update y Delete) de la tabla PROFORMA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	09/01/2018	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class dbPROFORMA
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

        Dim lEntidad As PROFORMA
        lEntidad = CType(aEntidad, PROFORMA)

        Dim lID As Int32
        If lEntidad.ID_PROFORMA =  0 _
            Or lEntidad.ID_PROFORMA = Nothing Then 

            lID = CType(Me.ObtenerID(lEntidad), Int32)

            If lID = -1 Then Return -1

            lEntidad.ID_PROFORMA = lID

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
    ''' Función que Elimina un Registro de la Tabla PROFORMA que se le envía como parámetro.
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
    ''' Función que Elimina un Registro de la Tabla PROFORMA que se le envía como
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
                dbAsignarEntidades.AsignarPROFORMA(dr, CType(aEntidad,PROFORMA))
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
    Public Function RecuperarConForaneas(ByVal aEntidad As PROFORMA, Optional ByVal aZAFRA As Boolean = False, Optional ByVal aTIPOS_GENERALES As Boolean = False, Optional ByVal aCARGADORA As Boolean = False, Optional ByVal aSUPERVISOR As Boolean = False, Optional ByVal aPRODUCTO As Boolean = False, Optional ByVal aTIPO_TRANSPORTE As Boolean = False, Optional ByVal aPROVEEDOR_ROZA As Boolean = False, Optional ByVal aCARGADOR As Boolean = False, Optional ByVal aENVIO As Boolean = False) As Integer

        Dim strSQL As New StringBuilder
        Dim args(0) As SqlParameter

        If aZAFRA Or aTIPOS_GENERALES Or aCARGADORA Or aSUPERVISOR Or aPRODUCTO Or aTIPO_TRANSPORTE Or aPROVEEDOR_ROZA Or aCARGADOR Or aENVIO Then
            Dim numTabla As Integer = 0
            Dim strCampos, strWhere As String
            strCampos = ""
            strWhere = ""
            Me.QuerySelectCampos(aEntidad, args, GetType(PROFORMA), GetType(SqlParameter), strCampos, strWhere, 0, "PROFORMA")
            strSQL.AppendLine("SELECT " + strCampos)
            If aZAFRA Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New ZAFRA, Nothing, GetType(ZAFRA), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aTIPOS_GENERALES Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New TIPOS_GENERALES, Nothing, GetType(TIPOS_GENERALES), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aCARGADORA Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New CARGADORA, Nothing, GetType(CARGADORA), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aSUPERVISOR Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New SUPERVISOR, Nothing, GetType(SUPERVISOR), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aPRODUCTO Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New PRODUCTO, Nothing, GetType(PRODUCTO), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aTIPO_TRANSPORTE Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New TIPO_TRANSPORTE, Nothing, GetType(TIPO_TRANSPORTE), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aPROVEEDOR_ROZA Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New PROVEEDOR_ROZA, Nothing, GetType(PROVEEDOR_ROZA), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aCARGADOR Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New CARGADOR, Nothing, GetType(CARGADOR), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aENVIO Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New ENVIO, Nothing, GetType(ENVIO), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            strSQL.AppendLine("FROM PROFORMA")
            numTabla = 0
            If aZAFRA Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN ZAFRA T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_ZAFRA = PROFORMA.ID_ZAFRA")
            End If
            If aTIPOS_GENERALES Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN TIPOS_GENERALES T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_TIPO = PROFORMA.ID_TIPO_CANA AND T" + numTabla.ToString() + ".ID_TIPO = PROFORMA.ID_TIPO_ROZA AND T" + numTabla.ToString() + ".ID_TIPO = PROFORMA.ID_TIPO_ALZA")
            End If
            If aCARGADORA Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN CARGADORA T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_CARGADORA = PROFORMA.ID_CARGADORA")
            End If
            If aSUPERVISOR Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN SUPERVISOR T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_SUPERVISOR = PROFORMA.ID_SUPERVISOR")
            End If
            If aPRODUCTO Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN PRODUCTO T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_PRODUCTO = PROFORMA.ID_PRODUCTO")
            End If
            If aTIPO_TRANSPORTE Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN TIPO_TRANSPORTE T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_TIPOTRANS = PROFORMA.ID_TIPOTRANS")
            End If
            If aPROVEEDOR_ROZA Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN PROVEEDOR_ROZA T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_PROVEEDOR_ROZA = PROFORMA.ID_PROVEEDOR_ROZA")
            End If
            If aCARGADOR Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN CARGADOR T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_CARGADOR = PROFORMA.ID_CARGADOR")
            End If
            If aENVIO Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN ENVIO T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_ENVIO = PROFORMA.ID_ENVIO")
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
                dbAsignarEntidades.AsignarPROFORMA(dr, aEntidad)
                Dim numTabla As Integer = 0
                If aZAFRA Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarZAFRA(dr, aEntidad.fkID_ZAFRA, "T" + numTabla.ToString())
                End If
                If aTIPOS_GENERALES Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarTIPOS_GENERALES(dr, aEntidad.fkID_TIPO_CANA, "T" + numTabla.ToString())
                End If
                If aCARGADORA Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarCARGADORA(dr, aEntidad.fkID_CARGADORA, "T" + numTabla.ToString())
                End If
                If aSUPERVISOR Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarSUPERVISOR(dr, aEntidad.fkID_SUPERVISOR, "T" + numTabla.ToString())
                End If
                If aPRODUCTO Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarPRODUCTO(dr, aEntidad.fkID_PRODUCTO, "T" + numTabla.ToString())
                End If
                If aTIPO_TRANSPORTE Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarTIPO_TRANSPORTE(dr, aEntidad.fkID_TIPOTRANS, "T" + numTabla.ToString())
                End If
                If aPROVEEDOR_ROZA Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarPROVEEDOR_ROZA(dr, aEntidad.fkID_PROVEEDOR_ROZA, "T" + numTabla.ToString())
                End If
                If aCARGADOR Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarCARGADOR(dr, aEntidad.fkID_CARGADOR, "T" + numTabla.ToString())
                End If
                If aENVIO Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarENVIO(dr, aEntidad.fkID_ENVIO, "T" + numTabla.ToString())
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
        strSQL.AppendLine("SELECT isnull(max(ID_PROFORMA),0) + 1 ")
        strSQL.AppendLine(" FROM PROFORMA ")

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
    Public Function ObtenerListaPorID(ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaPROFORMA

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New PROFORMA))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New listaPROFORMA

        Try
            Do While dr.Read()
                Dim mEntidad As New PROFORMA
                dbAsignarEntidades.AsignarPROFORMA(dr, mEntidad)
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
        strSQL.Append(Me.QuerySelect(New PROFORMA))
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
        strSQL.Append(Me.QuerySelect(New PROFORMA))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim tables(0) As String
        tables(0) = New String("PROFORMA".ToCharArray())

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

        strSQL.AppendLine(" SELECT PROFORMA.ID_PROFORMA, ")
        strSQL.AppendLine(" PROFORMA.ID_ZAFRA, ")
        strSQL.AppendLine(" PROFORMA.DIAZAFRA, ")
        strSQL.AppendLine(" PROFORMA.NOPROFORMA, ")
        strSQL.AppendLine(" PROFORMA.CODICONTRATO, ")
        strSQL.AppendLine(" PROFORMA.CODIPROVEEDOR, ")
        strSQL.AppendLine(" PROFORMA.ACCESLOTE, ")
        strSQL.AppendLine(" PROFORMA.CODTRANSPORT, ")
        strSQL.AppendLine(" PROFORMA.NOMBRES_MOTORISTA, ")
        strSQL.AppendLine(" PROFORMA.ID_TIPO_CANA, ")
        strSQL.AppendLine(" PROFORMA.ID_CARGADORA, ")
        strSQL.AppendLine(" PROFORMA.ID_SUPERVISOR, ")
        strSQL.AppendLine(" PROFORMA.FECHA_QUEMA, ")
        strSQL.AppendLine(" PROFORMA.FECHA_CORTA, ")
        strSQL.AppendLine(" PROFORMA.QUEMAPROG, ")
        strSQL.AppendLine(" PROFORMA.QUEMANOPROG, ")
        strSQL.AppendLine(" PROFORMA.CANA_VERDE, ")
        strSQL.AppendLine(" PROFORMA.FECHA_ROZA, ")
        strSQL.AppendLine(" PROFORMA.FECHA_PATIO, ")
        strSQL.AppendLine(" PROFORMA.ID_PRODUCTO, ")
        strSQL.AppendLine(" PROFORMA.FIN_LOTE, ")
        strSQL.AppendLine(" PROFORMA.PLACAVEHIC, ")
        strSQL.AppendLine(" PROFORMA.ID_TIPOTRANS, ")
        strSQL.AppendLine(" PROFORMA.SERVICIO_ROZA, ")
        strSQL.AppendLine(" PROFORMA.TRANSPORTE_PROPIO, ")
        strSQL.AppendLine(" PROFORMA.ID_PROVEEDOR_ROZA, ")
        strSQL.AppendLine(" PROFORMA.ID_CARGADOR, ")
        strSQL.AppendLine(" PROFORMA.TIPO_TARIFA_CARGADORA, ")
        strSQL.AppendLine(" PROFORMA.ID_MOTORISTA, ")
        strSQL.AppendLine(" PROFORMA.OBSERVACIONES, ")
        strSQL.AppendLine(" PROFORMA.ID_ENVIO, ")
        strSQL.AppendLine(" PROFORMA.ESTADO, ")
        strSQL.AppendLine(" PROFORMA.USUARIO_CREA, ")
        strSQL.AppendLine(" PROFORMA.FECHA_CREA, ")
        strSQL.AppendLine(" PROFORMA.USUARIO_ACT, ")
        strSQL.AppendLine(" PROFORMA.FECHA_ACT, ")
        strSQL.AppendLine(" PROFORMA.TONELADAS, ")
        strSQL.AppendLine(" PROFORMA.ID_TIPO_ROZA, ")
        strSQL.AppendLine(" PROFORMA.ID_TIPO_ALZA, ")
        strSQL.AppendLine(" PROFORMA.FECHA_MADURANTE, ")
        strSQL.AppendLine(" PROFORMA.OBSERVA_ANUL, ")
        strSQL.AppendLine(" PROFORMA.USUARIO_ANUL, ")
        strSQL.AppendLine(" PROFORMA.FECHA_ANUL, ")
        strSQL.AppendLine(" PROFORMA.ES_QUERQUEO, ")
        strSQL.AppendLine(" PROFORMA.ID_PROVEE, ")
        strSQL.AppendLine(" PROFORMA.ID_SUBLOTES ")
        strSQL.AppendLine(" FROM PROFORMA ")

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
    Public Function ObtenerListaPorZAFRA(ByVal ID_ZAFRA As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaPROFORMA

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New PROFORMA))
        strSQL.Append(" WHERE ID_ZAFRA = @ID_ZAFRA ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        args(0).Value = ID_ZAFRA

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaPROFORMA

        Try
            Do While dr.Read()
                Dim mEntidad As New PROFORMA
                dbAsignarEntidades.AsignarPROFORMA(dr, mEntidad)
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
    Public Function ObtenerListaPorTIPOS_GENERALES(ByVal ID_TIPO As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaPROFORMA

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New PROFORMA))
        strSQL.Append(" WHERE ID_TIPO = @ID_TIPO ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_TIPO", SqlDbType.Int)
        args(0).Value = ID_TIPO

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaPROFORMA

        Try
            Do While dr.Read()
                Dim mEntidad As New PROFORMA
                dbAsignarEntidades.AsignarPROFORMA(dr, mEntidad)
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
    ''' <param name="ID_CARGADORA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	09/01/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorCARGADORA(ByVal ID_CARGADORA As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaPROFORMA

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New PROFORMA))
        strSQL.Append(" WHERE ID_CARGADORA = @ID_CARGADORA ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_CARGADORA", SqlDbType.Int)
        args(0).Value = ID_CARGADORA

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaPROFORMA

        Try
            Do While dr.Read()
                Dim mEntidad As New PROFORMA
                dbAsignarEntidades.AsignarPROFORMA(dr, mEntidad)
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
    ''' <param name="ID_SUPERVISOR"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	09/01/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorSUPERVISOR(ByVal ID_SUPERVISOR As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaPROFORMA

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New PROFORMA))
        strSQL.Append(" WHERE ID_SUPERVISOR = @ID_SUPERVISOR ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_SUPERVISOR", SqlDbType.Int)
        args(0).Value = ID_SUPERVISOR

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaPROFORMA

        Try
            Do While dr.Read()
                Dim mEntidad As New PROFORMA
                dbAsignarEntidades.AsignarPROFORMA(dr, mEntidad)
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
    ''' <param name="ID_PRODUCTO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	09/01/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorPRODUCTO(ByVal ID_PRODUCTO As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaPROFORMA

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New PROFORMA))
        strSQL.Append(" WHERE ID_PRODUCTO = @ID_PRODUCTO ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_PRODUCTO", SqlDbType.Int)
        args(0).Value = ID_PRODUCTO

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaPROFORMA

        Try
            Do While dr.Read()
                Dim mEntidad As New PROFORMA
                dbAsignarEntidades.AsignarPROFORMA(dr, mEntidad)
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
    ''' <param name="ID_TIPOTRANS"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	09/01/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorTIPO_TRANSPORTE(ByVal ID_TIPOTRANS As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaPROFORMA

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New PROFORMA))
        strSQL.Append(" WHERE ID_TIPOTRANS = @ID_TIPOTRANS ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_TIPOTRANS", SqlDbType.Int)
        args(0).Value = ID_TIPOTRANS

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaPROFORMA

        Try
            Do While dr.Read()
                Dim mEntidad As New PROFORMA
                dbAsignarEntidades.AsignarPROFORMA(dr, mEntidad)
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
    Public Function ObtenerListaPorPROVEEDOR_ROZA(ByVal ID_PROVEEDOR_ROZA As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaPROFORMA

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New PROFORMA))
        strSQL.Append(" WHERE ID_PROVEEDOR_ROZA = @ID_PROVEEDOR_ROZA ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_PROVEEDOR_ROZA", SqlDbType.Int)
        args(0).Value = ID_PROVEEDOR_ROZA

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaPROFORMA

        Try
            Do While dr.Read()
                Dim mEntidad As New PROFORMA
                dbAsignarEntidades.AsignarPROFORMA(dr, mEntidad)
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
    ''' <param name="ID_CARGADOR"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	09/01/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorCARGADOR(ByVal ID_CARGADOR As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaPROFORMA

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New PROFORMA))
        strSQL.Append(" WHERE ID_CARGADOR = @ID_CARGADOR ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_CARGADOR", SqlDbType.Int)
        args(0).Value = ID_CARGADOR

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaPROFORMA

        Try
            Do While dr.Read()
                Dim mEntidad As New PROFORMA
                dbAsignarEntidades.AsignarPROFORMA(dr, mEntidad)
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
    ''' <param name="ID_ENVIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	09/01/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorENVIO(ByVal ID_ENVIO As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaPROFORMA

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New PROFORMA))
        strSQL.Append(" WHERE ID_ENVIO = @ID_ENVIO ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_ENVIO", SqlDbType.Int)
        args(0).Value = ID_ENVIO

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaPROFORMA

        Try
            Do While dr.Read()
                Dim mEntidad As New PROFORMA
                dbAsignarEntidades.AsignarPROFORMA(dr, mEntidad)
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
