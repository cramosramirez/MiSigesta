Imports System.Text
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_DL
''' Class	 : DL.dbMAESTRO_LOTES
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Acceso a Datos que contiene las operaciones CRUD(Create, Read,
''' Update y Delete) de la tabla MAESTRO_LOTES
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/01/2020	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class dbMAESTRO_LOTES
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
    ''' 	[GenApp]	02/01/2020	Created
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
    ''' 	[GenApp]	02/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overloads Function Actualizar(ByVal aEntidad As entidadBase, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer

        Dim lEntidad As MAESTRO_LOTES
        lEntidad = CType(aEntidad, MAESTRO_LOTES)

        Dim lID As Int32
        If lEntidad.ID_MAESTRO =  0 _
            Or lEntidad.ID_MAESTRO = Nothing Then 

            lID = CType(Me.ObtenerID(lEntidad), Int32)

            If lID = -1 Then Return -1

            lEntidad.ID_MAESTRO = lID

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
    ''' 	[GenApp]	02/01/2020	Created
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
    ''' Función que Elimina un Registro de la Tabla MAESTRO_LOTES que se le envía como parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde viene se obtienen los valores de la llave 
    ''' primaria del registro a eliminar.</param>
    ''' <remarks>Por defecto manda a ejecutar eliminación con concurrencia pesimistica.
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer
        Return Me.Eliminar(aEntidad, TipoConcurrencia.Pesimistica)
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla MAESTRO_LOTES que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde viene se obtienen los valores de la llave 
    ''' primaria del registro a eliminar.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el 
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/01/2020	Created
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
    ''' 	[GenApp]	02/01/2020	Created
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
                dbAsignarEntidades.AsignarMAESTRO_LOTES(dr, CType(aEntidad,MAESTRO_LOTES))
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
    ''' 	[GenApp]	02/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function RecuperarConForaneas(ByVal aEntidad As MAESTRO_LOTES, Optional ByVal aCANTON As Boolean = False, Optional ByVal aZONAS As Boolean = False, Optional ByVal aSUB_ZONAS As Boolean = False, Optional ByVal aCOMPORTAMIENTO_CANA As Boolean = False, Optional ByVal aTIPO_SUELO As Boolean = False, Optional ByVal aCONDICION_SIEMBRA As Boolean = False, Optional ByVal aNIVEL_HUMEDAD As Boolean = False, Optional ByVal aTIPOS_GENERALES As Boolean = False, Optional ByVal aAGRONOMO As Boolean = False) As Integer

        Dim strSQL As New StringBuilder
        Dim args(0) As SqlParameter

        If aCANTON Or aZONAS Or aSUB_ZONAS Or aCOMPORTAMIENTO_CANA Or aTIPO_SUELO Or aCONDICION_SIEMBRA Or aNIVEL_HUMEDAD Or aTIPOS_GENERALES Or aAGRONOMO Then
            Dim numTabla As Integer = 0
            Dim strCampos, strWhere As String
            strCampos = ""
            strWhere = ""
            Me.QuerySelectCampos(aEntidad, args, GetType(MAESTRO_LOTES), GetType(SqlParameter), strCampos, strWhere, 0, "MAESTRO_LOTES")
            strSQL.AppendLine("SELECT " + strCampos)
            If aCANTON Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New CANTON, Nothing, GetType(CANTON), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aZONAS Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New ZONAS, Nothing, GetType(ZONAS), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aSUB_ZONAS Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New SUB_ZONAS, Nothing, GetType(SUB_ZONAS), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aCOMPORTAMIENTO_CANA Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New COMPORTAMIENTO_CANA, Nothing, GetType(COMPORTAMIENTO_CANA), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aTIPO_SUELO Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New TIPO_SUELO, Nothing, GetType(TIPO_SUELO), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aCONDICION_SIEMBRA Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New CONDICION_SIEMBRA, Nothing, GetType(CONDICION_SIEMBRA), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aNIVEL_HUMEDAD Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New NIVEL_HUMEDAD, Nothing, GetType(NIVEL_HUMEDAD), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aTIPOS_GENERALES Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New TIPOS_GENERALES, Nothing, GetType(TIPOS_GENERALES), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aAGRONOMO Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New AGRONOMO, Nothing, GetType(AGRONOMO), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            strSQL.AppendLine("FROM MAESTRO_LOTES")
            numTabla = 0
            If aCANTON Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN CANTON T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".CODI_MUNI = MAESTRO_LOTES.CODI_DEPTO AND T" + numTabla.ToString() + ".CODI_MUNI = MAESTRO_LOTES.CODI_MUNI AND T" + numTabla.ToString() + ".CODI_CANTON = MAESTRO_LOTES.CODI_CANTON")
            End If
            If aZONAS Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN ZONAS T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ZONA = MAESTRO_LOTES.ZONA")
            End If
            If aSUB_ZONAS Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN SUB_ZONAS T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".SUB_ZONA = MAESTRO_LOTES.SUB_ZONA")
            End If
            If aCOMPORTAMIENTO_CANA Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN COMPORTAMIENTO_CANA T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_COMPOR = MAESTRO_LOTES.ID_COMPOR")
            End If
            If aTIPO_SUELO Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN TIPO_SUELO T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".COD_TIPO_SUELO = MAESTRO_LOTES.COD_TIPO_SUELO")
            End If
            If aCONDICION_SIEMBRA Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN CONDICION_SIEMBRA T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_COND_SIEMBRA = MAESTRO_LOTES.ID_COND_SIEMBRA")
            End If
            If aNIVEL_HUMEDAD Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN NIVEL_HUMEDAD T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_NIVEL_HUMEDAD = MAESTRO_LOTES.ID_NIVEL_HUMEDAD")
            End If
            If aTIPOS_GENERALES Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN TIPOS_GENERALES T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_TIPO = MAESTRO_LOTES.ID_TIPO_CANA AND T" + numTabla.ToString() + ".ID_TIPO = MAESTRO_LOTES.ID_TIPO_ROZA AND T" + numTabla.ToString() + ".ID_TIPO = MAESTRO_LOTES.ID_TIPO_ALZA AND T" + numTabla.ToString() + ".ID_TIPO = MAESTRO_LOTES.ID_TIPO_TRANS")
            End If
            If aAGRONOMO Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN AGRONOMO T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".CODIAGRON = MAESTRO_LOTES.CODIAGRON")
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
                dbAsignarEntidades.AsignarMAESTRO_LOTES(dr, aEntidad)
                Dim numTabla As Integer = 0
                If aCANTON Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarCANTON(dr, aEntidad.fkCODI_DEPTO, "T" + numTabla.ToString())
                End If
                If aZONAS Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarZONAS(dr, aEntidad.fkZONA, "T" + numTabla.ToString())
                End If
                If aSUB_ZONAS Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarSUB_ZONAS(dr, aEntidad.fkSUB_ZONA, "T" + numTabla.ToString())
                End If
                If aCOMPORTAMIENTO_CANA Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarCOMPORTAMIENTO_CANA(dr, aEntidad.fkID_COMPOR, "T" + numTabla.ToString())
                End If
                If aTIPO_SUELO Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarTIPO_SUELO(dr, aEntidad.fkCOD_TIPO_SUELO, "T" + numTabla.ToString())
                End If
                If aCONDICION_SIEMBRA Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarCONDICION_SIEMBRA(dr, aEntidad.fkID_COND_SIEMBRA, "T" + numTabla.ToString())
                End If
                If aNIVEL_HUMEDAD Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarNIVEL_HUMEDAD(dr, aEntidad.fkID_NIVEL_HUMEDAD, "T" + numTabla.ToString())
                End If
                If aTIPOS_GENERALES Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarTIPOS_GENERALES(dr, aEntidad.fkID_TIPO_CANA, "T" + numTabla.ToString())
                End If
                If aAGRONOMO Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarAGRONOMO(dr, aEntidad.fkCODIAGRON, "T" + numTabla.ToString())
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
        strSQL.AppendLine("SELECT isnull(max(ID_MAESTRO),0) + 1 ")
        strSQL.AppendLine(" FROM MAESTRO_LOTES ")

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
    ''' 	[GenApp]	02/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorID(ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaMAESTRO_LOTES

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New MAESTRO_LOTES))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New listaMAESTRO_LOTES

        Try
            Do While dr.Read()
                Dim mEntidad As New MAESTRO_LOTES
                dbAsignarEntidades.AsignarMAESTRO_LOTES(dr, mEntidad)
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
    ''' 	[GenApp]	02/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetPorID(ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New MAESTRO_LOTES))
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
    ''' 	[GenApp]	02/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetPorID(ByRef ds as DataSet, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As Integer

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New MAESTRO_LOTES))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim tables(0) As String
        tables(0) = New String("MAESTRO_LOTES".ToCharArray())

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
    ''' 	[GenApp]	02/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub SelectTabla(ByRef strSQL as StringBuilder)

        strSQL.AppendLine(" SELECT MAESTRO_LOTES.ID_MAESTRO, ")
        strSQL.AppendLine(" MAESTRO_LOTES.CUI, ")
        strSQL.AppendLine(" MAESTRO_LOTES.CODI_DEPTO, ")
        strSQL.AppendLine(" MAESTRO_LOTES.CODI_MUNI, ")
        strSQL.AppendLine(" MAESTRO_LOTES.CODI_CANTON, ")
        strSQL.AppendLine(" MAESTRO_LOTES.ZONA, ")
        strSQL.AppendLine(" MAESTRO_LOTES.SUB_ZONA, ")
        strSQL.AppendLine(" MAESTRO_LOTES.CORRELATIVO, ")
        strSQL.AppendLine(" MAESTRO_LOTES.CODIPROVEEDOR, ")
        strSQL.AppendLine(" MAESTRO_LOTES.NOMBRE_COMER, ")
        strSQL.AppendLine(" MAESTRO_LOTES.CODILOTE_COMER, ")
        strSQL.AppendLine(" MAESTRO_LOTES.MZ_CULTIVADA, ")
        strSQL.AppendLine(" MAESTRO_LOTES.CODIVARIEDA, ")
        strSQL.AppendLine(" MAESTRO_LOTES.ID_COMPOR, ")
        strSQL.AppendLine(" MAESTRO_LOTES.COD_TIPO_SUELO, ")
        strSQL.AppendLine(" MAESTRO_LOTES.ID_COND_SIEMBRA, ")
        strSQL.AppendLine(" MAESTRO_LOTES.ID_NIVEL_HUMEDAD, ")
        strSQL.AppendLine(" MAESTRO_LOTES.NO_CORTE, ")
        strSQL.AppendLine(" MAESTRO_LOTES.MSNM, ")
        strSQL.AppendLine(" MAESTRO_LOTES.KM_CARRETERA, ")
        strSQL.AppendLine(" MAESTRO_LOTES.KM_TIERRA, ")
        strSQL.AppendLine(" MAESTRO_LOTES.RIESGO_PIEDRA, ")
        strSQL.AppendLine(" MAESTRO_LOTES.FECHA_SIEMBRA, ")
        strSQL.AppendLine(" MAESTRO_LOTES.FECHA_CORTE, ")
        strSQL.AppendLine(" MAESTRO_LOTES.PROD_TC, ")
        strSQL.AppendLine(" MAESTRO_LOTES.PROD_LB, ")
        strSQL.AppendLine(" MAESTRO_LOTES.FACTOR_DESPOBLA, ")
        strSQL.AppendLine(" MAESTRO_LOTES.USUARIO_CREA, ")
        strSQL.AppendLine(" MAESTRO_LOTES.FECHA_CREA, ")
        strSQL.AppendLine(" MAESTRO_LOTES.USUARIO_ACT, ")
        strSQL.AppendLine(" MAESTRO_LOTES.FECHA_ACT, ")
        strSQL.AppendLine(" MAESTRO_LOTES.CODICONTRATO, ")
        strSQL.AppendLine(" MAESTRO_LOTES.TIPO_DERECHO, ")
        strSQL.AppendLine(" MAESTRO_LOTES.ID_TIPO_CANA, ")
        strSQL.AppendLine(" MAESTRO_LOTES.ID_TIPO_ROZA, ")
        strSQL.AppendLine(" MAESTRO_LOTES.ID_TIPO_ALZA, ")
        strSQL.AppendLine(" MAESTRO_LOTES.ID_TIPO_TRANS, ")
        strSQL.AppendLine(" MAESTRO_LOTES.CODIAGRON, ")
        strSQL.AppendLine(" MAESTRO_LOTES.TARIFA_ROZA, ")
        strSQL.AppendLine(" MAESTRO_LOTES.TARIFA_ALZA, ")
        strSQL.AppendLine(" MAESTRO_LOTES.TARIFA_TRANS, ")
        strSQL.AppendLine(" MAESTRO_LOTES.TARIFA_CORTA, ")
        strSQL.AppendLine(" MAESTRO_LOTES.TARIFA_LARGA, ")
        strSQL.AppendLine(" MAESTRO_LOTES.REPARA_ACCESO, ")
        strSQL.AppendLine(" MAESTRO_LOTES.SIN_ACCESO_PROPIO, ")
        strSQL.AppendLine(" MAESTRO_LOTES.HACIENDA, ")
        strSQL.AppendLine(" MAESTRO_LOTES.TARIFA_LARGA_T3S3, ")
        strSQL.AppendLine(" MAESTRO_LOTES.ESTADO, ")
        strSQL.AppendLine(" MAESTRO_LOTES.ID_SUBLOTES ")
        strSQL.AppendLine(" FROM MAESTRO_LOTES ")

    End Sub

#Region "Obtener Listas Por Foraneas"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Foranea, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="CODI_CANTON"></param>
    ''' <param name="CODI_DEPTO"></param>
    ''' <param name="CODI_MUNI"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorCANTON(ByVal CODI_CANTON As String, ByVal CODI_DEPTO As String, ByVal CODI_MUNI As String, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaMAESTRO_LOTES

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New MAESTRO_LOTES))
        strSQL.Append(" WHERE CODI_CANTON = @CODI_CANTON ") 
        strSQL.Append(" AND CODI_DEPTO = @CODI_DEPTO ") 
        strSQL.Append(" AND CODI_MUNI = @CODI_MUNI ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@CODI_CANTON", SqlDbType.VarChar)
        args(0).Value = CODI_CANTON
        args(1) = New SqlParameter("@CODI_DEPTO", SqlDbType.VarChar)
        args(1).Value = CODI_DEPTO
        args(2) = New SqlParameter("@CODI_MUNI", SqlDbType.VarChar)
        args(2).Value = CODI_MUNI

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaMAESTRO_LOTES

        Try
            Do While dr.Read()
                Dim mEntidad As New MAESTRO_LOTES
                dbAsignarEntidades.AsignarMAESTRO_LOTES(dr, mEntidad)
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
    ''' <param name="ZONA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorZONAS(ByVal ZONA As String, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaMAESTRO_LOTES

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New MAESTRO_LOTES))
        strSQL.Append(" WHERE ZONA = @ZONA ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ZONA", SqlDbType.VarChar)
        args(0).Value = ZONA

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaMAESTRO_LOTES

        Try
            Do While dr.Read()
                Dim mEntidad As New MAESTRO_LOTES
                dbAsignarEntidades.AsignarMAESTRO_LOTES(dr, mEntidad)
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
    ''' <param name="ZONA"></param>
    ''' <param name="SUB_ZONA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorSUB_ZONAS(ByVal ZONA As String, ByVal SUB_ZONA As String, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaMAESTRO_LOTES

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New MAESTRO_LOTES))
        strSQL.Append(" WHERE ZONA = @ZONA ") 
        strSQL.Append(" AND SUB_ZONA = @SUB_ZONA ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ZONA", SqlDbType.VarChar)
        args(0).Value = ZONA
        args(1) = New SqlParameter("@SUB_ZONA", SqlDbType.VarChar)
        args(1).Value = SUB_ZONA

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaMAESTRO_LOTES

        Try
            Do While dr.Read()
                Dim mEntidad As New MAESTRO_LOTES
                dbAsignarEntidades.AsignarMAESTRO_LOTES(dr, mEntidad)
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
    ''' <param name="ID_COMPOR"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorCOMPORTAMIENTO_CANA(ByVal ID_COMPOR As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaMAESTRO_LOTES

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New MAESTRO_LOTES))
        strSQL.Append(" WHERE ID_COMPOR = @ID_COMPOR ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_COMPOR", SqlDbType.Int)
        args(0).Value = ID_COMPOR

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaMAESTRO_LOTES

        Try
            Do While dr.Read()
                Dim mEntidad As New MAESTRO_LOTES
                dbAsignarEntidades.AsignarMAESTRO_LOTES(dr, mEntidad)
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
    ''' <param name="COD_TIPO_SUELO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorTIPO_SUELO(ByVal COD_TIPO_SUELO As String, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaMAESTRO_LOTES

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New MAESTRO_LOTES))
        strSQL.Append(" WHERE COD_TIPO_SUELO = @COD_TIPO_SUELO ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@COD_TIPO_SUELO", SqlDbType.VarChar)
        args(0).Value = COD_TIPO_SUELO

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaMAESTRO_LOTES

        Try
            Do While dr.Read()
                Dim mEntidad As New MAESTRO_LOTES
                dbAsignarEntidades.AsignarMAESTRO_LOTES(dr, mEntidad)
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
    ''' <param name="ID_COND_SIEMBRA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorCONDICION_SIEMBRA(ByVal ID_COND_SIEMBRA As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaMAESTRO_LOTES

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New MAESTRO_LOTES))
        strSQL.Append(" WHERE ID_COND_SIEMBRA = @ID_COND_SIEMBRA ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_COND_SIEMBRA", SqlDbType.Int)
        args(0).Value = ID_COND_SIEMBRA

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaMAESTRO_LOTES

        Try
            Do While dr.Read()
                Dim mEntidad As New MAESTRO_LOTES
                dbAsignarEntidades.AsignarMAESTRO_LOTES(dr, mEntidad)
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
    ''' <param name="ID_NIVEL_HUMEDAD"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorNIVEL_HUMEDAD(ByVal ID_NIVEL_HUMEDAD As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaMAESTRO_LOTES

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New MAESTRO_LOTES))
        strSQL.Append(" WHERE ID_NIVEL_HUMEDAD = @ID_NIVEL_HUMEDAD ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_NIVEL_HUMEDAD", SqlDbType.Int)
        args(0).Value = ID_NIVEL_HUMEDAD

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaMAESTRO_LOTES

        Try
            Do While dr.Read()
                Dim mEntidad As New MAESTRO_LOTES
                dbAsignarEntidades.AsignarMAESTRO_LOTES(dr, mEntidad)
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
    ''' 	[GenApp]	02/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorTIPOS_GENERALES(ByVal ID_TIPO As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaMAESTRO_LOTES

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New MAESTRO_LOTES))
        strSQL.Append(" WHERE ID_TIPO = @ID_TIPO ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_TIPO", SqlDbType.Int)
        args(0).Value = ID_TIPO

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaMAESTRO_LOTES

        Try
            Do While dr.Read()
                Dim mEntidad As New MAESTRO_LOTES
                dbAsignarEntidades.AsignarMAESTRO_LOTES(dr, mEntidad)
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
    ''' <param name="CODIAGRON"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorAGRONOMO(ByVal CODIAGRON As String, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaMAESTRO_LOTES

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New MAESTRO_LOTES))
        strSQL.Append(" WHERE CODIAGRON = @CODIAGRON ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@CODIAGRON", SqlDbType.VarChar)
        args(0).Value = CODIAGRON

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaMAESTRO_LOTES

        Try
            Do While dr.Read()
                Dim mEntidad As New MAESTRO_LOTES
                dbAsignarEntidades.AsignarMAESTRO_LOTES(dr, mEntidad)
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
