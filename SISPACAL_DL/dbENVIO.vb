Imports System.Text
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_DL
''' Class	 : DL.dbENVIO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Acceso a Datos que contiene las operaciones CRUD(Create, Read,
''' Update y Delete) de la tabla ENVIO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	18/11/2019	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class dbENVIO
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
    ''' 	[GenApp]	18/11/2019	Created
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
    ''' 	[GenApp]	18/11/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overloads Function Actualizar(ByVal aEntidad As entidadBase, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer

        Dim lEntidad As ENVIO
        lEntidad = CType(aEntidad, ENVIO)

        Dim lID As Int32
        If lEntidad.ID_ENVIO =  0 _
            Or lEntidad.ID_ENVIO = Nothing Then 

            lID = CType(Me.ObtenerID(lEntidad), Int32)

            If lID = -1 Then Return -1

            lEntidad.ID_ENVIO = lID

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
    ''' 	[GenApp]	18/11/2019	Created
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
    ''' Función que Elimina un Registro de la Tabla ENVIO que se le envía como parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde viene se obtienen los valores de la llave 
    ''' primaria del registro a eliminar.</param>
    ''' <remarks>Por defecto manda a ejecutar eliminación con concurrencia pesimistica.
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/11/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer
        Return Me.Eliminar(aEntidad, TipoConcurrencia.Pesimistica)
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla ENVIO que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde viene se obtienen los valores de la llave 
    ''' primaria del registro a eliminar.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el 
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/11/2019	Created
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
    ''' 	[GenApp]	18/11/2019	Created
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
                dbAsignarEntidades.AsignarENVIO(dr, CType(aEntidad,ENVIO))
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
    ''' 	[GenApp]	18/11/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function RecuperarConForaneas(ByVal aEntidad As ENVIO, Optional ByVal aZAFRA As Boolean = False, Optional ByVal aCONTRATO As Boolean = False, Optional ByVal aPROVEEDOR As Boolean = False, Optional ByVal aLOTES As Boolean = False, Optional ByVal aTRANSPORTISTA As Boolean = False, Optional ByVal aTIPO_CANA As Boolean = False, Optional ByVal aCARGADORA As Boolean = False, Optional ByVal aSUPERVISOR As Boolean = False, Optional ByVal aPROVEEDOR_ROZA As Boolean = False, Optional ByVal aCARGADOR As Boolean = False, Optional ByVal aMOTORISTA As Boolean = False, Optional ByVal aTIPOS_GENERALES As Boolean = False) As Integer

        Dim strSQL As New StringBuilder
        Dim args(0) As SqlParameter

        If aZAFRA Or aCONTRATO Or aPROVEEDOR Or aLOTES Or aTRANSPORTISTA Or aTIPO_CANA Or aCARGADORA Or aSUPERVISOR Or aPROVEEDOR_ROZA Or aCARGADOR Or aMOTORISTA Or aTIPOS_GENERALES Then
            Dim numTabla As Integer = 0
            Dim strCampos, strWhere As String
            strCampos = ""
            strWhere = ""
            Me.QuerySelectCampos(aEntidad, args, GetType(ENVIO), GetType(SqlParameter), strCampos, strWhere, 0, "ENVIO")
            strSQL.AppendLine("SELECT " + strCampos)
            If aZAFRA Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New ZAFRA, Nothing, GetType(ZAFRA), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aCONTRATO Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New CONTRATO, Nothing, GetType(CONTRATO), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aPROVEEDOR Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New PROVEEDOR, Nothing, GetType(PROVEEDOR), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aLOTES Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New LOTES, Nothing, GetType(LOTES), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aTRANSPORTISTA Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New TRANSPORTISTA, Nothing, GetType(TRANSPORTISTA), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aTIPO_CANA Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New TIPO_CANA, Nothing, GetType(TIPO_CANA), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
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
            If aMOTORISTA Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New MOTORISTA, Nothing, GetType(MOTORISTA), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aTIPOS_GENERALES Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New TIPOS_GENERALES, Nothing, GetType(TIPOS_GENERALES), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            strSQL.AppendLine("FROM ENVIO")
            numTabla = 0
            If aZAFRA Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN ZAFRA T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_ZAFRA = ENVIO.ID_ZAFRA")
            End If
            If aCONTRATO Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN CONTRATO T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".CODICONTRATO = ENVIO.CODICONTRATO")
            End If
            If aPROVEEDOR Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN PROVEEDOR T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".CODIPROVEEDOR = ENVIO.CODIPROVEEDOR")
            End If
            If aLOTES Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN LOTES T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ACCESLOTE = ENVIO.ACCESLOTE")
            End If
            If aTRANSPORTISTA Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN TRANSPORTISTA T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".CODTRANSPORT = ENVIO.CODTRANSPORT")
            End If
            If aTIPO_CANA Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN TIPO_CANA T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_TIPO_CANA = ENVIO.ID_TIPO_CANA")
            End If
            If aCARGADORA Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN CARGADORA T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_CARGADORA = ENVIO.ID_CARGADORA")
            End If
            If aSUPERVISOR Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN SUPERVISOR T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_SUPERVISOR = ENVIO.ID_SUPERVISOR")
            End If
            If aPROVEEDOR_ROZA Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN PROVEEDOR_ROZA T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_PROVEEDOR_ROZA = ENVIO.ID_PROVEEDOR_ROZA")
            End If
            If aCARGADOR Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN CARGADOR T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_CARGADOR = ENVIO.ID_CARGADOR")
            End If
            If aMOTORISTA Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN MOTORISTA T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_MOTORISTA = ENVIO.ID_MOTORISTA")
            End If
            If aTIPOS_GENERALES Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN TIPOS_GENERALES T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_TIPO = ENVIO.ID_TIPO_ROZA AND T" + numTabla.ToString() + ".ID_TIPO = ENVIO.ID_TIPO_ALZA")
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
                dbAsignarEntidades.AsignarENVIO(dr, aEntidad)
                Dim numTabla As Integer = 0
                If aZAFRA Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarZAFRA(dr, aEntidad.fkID_ZAFRA, "T" + numTabla.ToString())
                End If
                If aCONTRATO Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarCONTRATO(dr, aEntidad.fkCODICONTRATO, "T" + numTabla.ToString())
                End If
                If aPROVEEDOR Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarPROVEEDOR(dr, aEntidad.fkCODIPROVEEDOR, "T" + numTabla.ToString())
                End If
                If aLOTES Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarLOTES(dr, aEntidad.fkACCESLOTE, "T" + numTabla.ToString())
                End If
                If aTRANSPORTISTA Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarTRANSPORTISTA(dr, aEntidad.fkCODTRANSPORT, "T" + numTabla.ToString())
                End If
                If aTIPO_CANA Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarTIPO_CANA(dr, aEntidad.fkID_TIPO_CANA, "T" + numTabla.ToString())
                End If
                If aCARGADORA Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarCARGADORA(dr, aEntidad.fkID_CARGADORA, "T" + numTabla.ToString())
                End If
                If aSUPERVISOR Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarSUPERVISOR(dr, aEntidad.fkID_SUPERVISOR, "T" + numTabla.ToString())
                End If
                If aPROVEEDOR_ROZA Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarPROVEEDOR_ROZA(dr, aEntidad.fkID_PROVEEDOR_ROZA, "T" + numTabla.ToString())
                End If
                If aCARGADOR Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarCARGADOR(dr, aEntidad.fkID_CARGADOR, "T" + numTabla.ToString())
                End If
                If aMOTORISTA Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarMOTORISTA(dr, aEntidad.fkID_MOTORISTA, "T" + numTabla.ToString())
                End If
                If aTIPOS_GENERALES Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarTIPOS_GENERALES(dr, aEntidad.fkID_TIPO_ROZA, "T" + numTabla.ToString())
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
        strSQL.AppendLine("SELECT isnull(max(ID_ENVIO),0) + 1 ")
        strSQL.AppendLine(" FROM ENVIO ")

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
    ''' 	[GenApp]	18/11/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorID(ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaENVIO

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New ENVIO))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New listaENVIO

        Try
            Do While dr.Read()
                Dim mEntidad As New ENVIO
                dbAsignarEntidades.AsignarENVIO(dr, mEntidad)
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
    ''' 	[GenApp]	18/11/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetPorID(ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New ENVIO))
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
    ''' 	[GenApp]	18/11/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetPorID(ByRef ds as DataSet, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As Integer

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New ENVIO))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim tables(0) As String
        tables(0) = New String("ENVIO".ToCharArray())

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
    ''' 	[GenApp]	18/11/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub SelectTabla(ByRef strSQL as StringBuilder)

        strSQL.AppendLine(" SELECT ENVIO.ID_ENVIO, ")
        strSQL.AppendLine(" ENVIO.ID_ZAFRA, ")
        strSQL.AppendLine(" ENVIO.DIAZAFRA, ")
        strSQL.AppendLine(" ENVIO.CATORCENA, ")
        strSQL.AppendLine(" ENVIO.CODICONTRATO, ")
        strSQL.AppendLine(" ENVIO.CODIPROVEEDOR, ")
        strSQL.AppendLine(" ENVIO.COMPTENVIO, ")
        strSQL.AppendLine(" ENVIO.ACCESLOTE, ")
        strSQL.AppendLine(" ENVIO.CODTRANSPORT, ")
        strSQL.AppendLine(" ENVIO.NOMBRES_MOTORISTA, ")
        strSQL.AppendLine(" ENVIO.ID_TIPO_CANA, ")
        strSQL.AppendLine(" ENVIO.ID_CARGADORA, ")
        strSQL.AppendLine(" ENVIO.ID_SUPERVISOR, ")
        strSQL.AppendLine(" ENVIO.FECHA_QUEMA, ")
        strSQL.AppendLine(" ENVIO.FECHA_CORTA, ")
        strSQL.AppendLine(" ENVIO.QUEMAPROG, ")
        strSQL.AppendLine(" ENVIO.FECHA_CARGA, ")
        strSQL.AppendLine(" ENVIO.FECHA_PATIO, ")
        strSQL.AppendLine(" ENVIO.NROBOLETA, ")
        strSQL.AppendLine(" ENVIO.MADURANTE, ")
        strSQL.AppendLine(" ENVIO.CERRADO, ")
        strSQL.AppendLine(" ENVIO.FECHA_ENTRADA, ")
        strSQL.AppendLine(" ENVIO.USUARIO_CREA, ")
        strSQL.AppendLine(" ENVIO.FECHA_CREA, ")
        strSQL.AppendLine(" ENVIO.USUARIO_ACT, ")
        strSQL.AppendLine(" ENVIO.FECHA_ACT, ")
        strSQL.AppendLine(" ENVIO.PLACAVEHIC, ")
        strSQL.AppendLine(" ENVIO.ID_TIPOTRANS, ")
        strSQL.AppendLine(" ENVIO.SERVICIO_ROZA, ")
        strSQL.AppendLine(" ENVIO.TRANSPORTE_PROPIO, ")
        strSQL.AppendLine(" ENVIO.ID_PROVEEDOR_ROZA, ")
        strSQL.AppendLine(" ENVIO.ID_CARGADOR, ")
        strSQL.AppendLine(" ENVIO.NUMRECIBO_CANA, ")
        strSQL.AppendLine(" ENVIO.TIPO_TARIFA_CARGADORA, ")
        strSQL.AppendLine(" ENVIO.ID_MOTORISTA, ")
        strSQL.AppendLine(" ENVIO.HORAS_QUEMA, ")
        strSQL.AppendLine(" ENVIO.ANULADO, ")
        strSQL.AppendLine(" ENVIO.USUARIO_ANULACION, ")
        strSQL.AppendLine(" ENVIO.FECHA_ANULACION, ")
        strSQL.AppendLine(" ENVIO.ID_TIPO_ROZA, ")
        strSQL.AppendLine(" ENVIO.ID_TIPO_ALZA, ")
        strSQL.AppendLine(" ENVIO.ES_QUERQUEO, ")
        strSQL.AppendLine(" ENVIO.ES_BARRIDO, ")
        strSQL.AppendLine(" ENVIO.ES_PRIMERENVIO_TURNO, ")
        strSQL.AppendLine(" ENVIO.ES_ULTENVIO_TURNO, ")
        strSQL.AppendLine(" ENVIO.ID_SUBLOTES ")
        strSQL.AppendLine(" FROM ENVIO ")

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
    ''' 	[GenApp]	18/11/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorZAFRA(ByVal ID_ZAFRA As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaENVIO

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New ENVIO))
        strSQL.Append(" WHERE ID_ZAFRA = @ID_ZAFRA ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        args(0).Value = ID_ZAFRA

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaENVIO

        Try
            Do While dr.Read()
                Dim mEntidad As New ENVIO
                dbAsignarEntidades.AsignarENVIO(dr, mEntidad)
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
    ''' <param name="CODICONTRATO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/11/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorCONTRATO(ByVal CODICONTRATO As String, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaENVIO

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New ENVIO))
        strSQL.Append(" WHERE CODICONTRATO = @CODICONTRATO ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@CODICONTRATO", SqlDbType.VarChar)
        args(0).Value = CODICONTRATO

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaENVIO

        Try
            Do While dr.Read()
                Dim mEntidad As New ENVIO
                dbAsignarEntidades.AsignarENVIO(dr, mEntidad)
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
    ''' <param name="CODIPROVEEDOR"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/11/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorPROVEEDOR(ByVal CODIPROVEEDOR As String, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaENVIO

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New ENVIO))
        strSQL.Append(" WHERE CODIPROVEEDOR = @CODIPROVEEDOR ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@CODIPROVEEDOR", SqlDbType.VarChar)
        args(0).Value = CODIPROVEEDOR

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaENVIO

        Try
            Do While dr.Read()
                Dim mEntidad As New ENVIO
                dbAsignarEntidades.AsignarENVIO(dr, mEntidad)
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
    ''' 	[GenApp]	18/11/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorLOTES(ByVal ACCESLOTE As String, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaENVIO

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New ENVIO))
        strSQL.Append(" WHERE ACCESLOTE = @ACCESLOTE ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ACCESLOTE", SqlDbType.VarChar)
        args(0).Value = ACCESLOTE

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaENVIO

        Try
            Do While dr.Read()
                Dim mEntidad As New ENVIO
                dbAsignarEntidades.AsignarENVIO(dr, mEntidad)
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
    ''' <param name="CODTRANSPORT"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/11/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorTRANSPORTISTA(ByVal CODTRANSPORT As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaENVIO

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New ENVIO))
        strSQL.Append(" WHERE CODTRANSPORT = @CODTRANSPORT ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@CODTRANSPORT", SqlDbType.Int)
        args(0).Value = CODTRANSPORT

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaENVIO

        Try
            Do While dr.Read()
                Dim mEntidad As New ENVIO
                dbAsignarEntidades.AsignarENVIO(dr, mEntidad)
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
    ''' <param name="ID_TIPO_CANA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/11/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorTIPO_CANA(ByVal ID_TIPO_CANA As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaENVIO

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New ENVIO))
        strSQL.Append(" WHERE ID_TIPO_CANA = @ID_TIPO_CANA ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_TIPO_CANA", SqlDbType.Int)
        args(0).Value = ID_TIPO_CANA

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaENVIO

        Try
            Do While dr.Read()
                Dim mEntidad As New ENVIO
                dbAsignarEntidades.AsignarENVIO(dr, mEntidad)
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
    ''' 	[GenApp]	18/11/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorCARGADORA(ByVal ID_CARGADORA As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaENVIO

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New ENVIO))
        strSQL.Append(" WHERE ID_CARGADORA = @ID_CARGADORA ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_CARGADORA", SqlDbType.Int)
        args(0).Value = ID_CARGADORA

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaENVIO

        Try
            Do While dr.Read()
                Dim mEntidad As New ENVIO
                dbAsignarEntidades.AsignarENVIO(dr, mEntidad)
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
    ''' 	[GenApp]	18/11/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorSUPERVISOR(ByVal ID_SUPERVISOR As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaENVIO

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New ENVIO))
        strSQL.Append(" WHERE ID_SUPERVISOR = @ID_SUPERVISOR ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_SUPERVISOR", SqlDbType.Int)
        args(0).Value = ID_SUPERVISOR

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaENVIO

        Try
            Do While dr.Read()
                Dim mEntidad As New ENVIO
                dbAsignarEntidades.AsignarENVIO(dr, mEntidad)
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
    ''' 	[GenApp]	18/11/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorPROVEEDOR_ROZA(ByVal ID_PROVEEDOR_ROZA As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaENVIO

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New ENVIO))
        strSQL.Append(" WHERE ID_PROVEEDOR_ROZA = @ID_PROVEEDOR_ROZA ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_PROVEEDOR_ROZA", SqlDbType.Int)
        args(0).Value = ID_PROVEEDOR_ROZA

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaENVIO

        Try
            Do While dr.Read()
                Dim mEntidad As New ENVIO
                dbAsignarEntidades.AsignarENVIO(dr, mEntidad)
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
    ''' 	[GenApp]	18/11/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorCARGADOR(ByVal ID_CARGADOR As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaENVIO

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New ENVIO))
        strSQL.Append(" WHERE ID_CARGADOR = @ID_CARGADOR ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_CARGADOR", SqlDbType.Int)
        args(0).Value = ID_CARGADOR

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaENVIO

        Try
            Do While dr.Read()
                Dim mEntidad As New ENVIO
                dbAsignarEntidades.AsignarENVIO(dr, mEntidad)
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
    ''' <param name="ID_MOTORISTA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/11/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorMOTORISTA(ByVal ID_MOTORISTA As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaENVIO

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New ENVIO))
        strSQL.Append(" WHERE ID_MOTORISTA = @ID_MOTORISTA ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_MOTORISTA", SqlDbType.Int)
        args(0).Value = ID_MOTORISTA

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaENVIO

        Try
            Do While dr.Read()
                Dim mEntidad As New ENVIO
                dbAsignarEntidades.AsignarENVIO(dr, mEntidad)
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
    ''' 	[GenApp]	18/11/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorTIPOS_GENERALES(ByVal ID_TIPO As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaENVIO

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New ENVIO))
        strSQL.Append(" WHERE ID_TIPO = @ID_TIPO ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_TIPO", SqlDbType.Int)
        args(0).Value = ID_TIPO

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaENVIO

        Try
            Do While dr.Read()
                Dim mEntidad As New ENVIO
                dbAsignarEntidades.AsignarENVIO(dr, mEntidad)
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
