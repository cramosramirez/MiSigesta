Imports System.Text
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_DL
''' Class	 : DL.dbLOTES_LG
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Acceso a Datos que contiene las operaciones CRUD(Create, Read,
''' Update y Delete) de la tabla LOTES_LG
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	10/08/2020	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class dbLOTES_LG
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
    ''' 	[GenApp]	10/08/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Actualizar(ByVal aEntidad As entidadBase) As Integer
        Return Me.Actualizar(aEntidad, TipoConcurrencia.Pesimistica)
    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Ingresa un registro de la Entidad que recibe como parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad que contiene los datos a Ingresar.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados al menos los
    ''' valores de la Llave Primaria, para su inserción.</remarks>
    ''' <history>
    ''' 	[GenApp]	10/08/2020	Created
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
    ''' Función que Elimina un Registro de la Tabla LOTES_LG que se le envía como parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde viene se obtienen los valores de la llave 
    ''' primaria del registro a eliminar.</param>
    ''' <remarks>Por defecto manda a ejecutar eliminación con concurrencia pesimistica.
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/08/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer
        Return Me.Eliminar(aEntidad, TipoConcurrencia.Pesimistica)
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla LOTES_LG que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde viene se obtienen los valores de la llave 
    ''' primaria del registro a eliminar.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el 
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/08/2020	Created
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
    ''' 	[GenApp]	10/08/2020	Created
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
                dbAsignarEntidades.AsignarLOTES_LG(dr, CType(aEntidad,LOTES_LG))
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
    ''' 	[GenApp]	10/08/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function RecuperarConForaneas(ByVal aEntidad As LOTES_LG, Optional ByVal aPROVEEDOR As Boolean = False, Optional ByVal aAGRONOMO As Boolean = False, Optional ByVal aVARIEDAD As Boolean = False, Optional ByVal aUBICACION As Boolean = False, Optional ByVal aCONTRATO_LG As Boolean = False, Optional ByVal aMAESTRO_LOTES As Boolean = False, Optional ByVal aLOTES_TRASPASO As Boolean = False) As Integer

        Dim strSQL As New StringBuilder
        Dim args(0) As SqlParameter

        If aPROVEEDOR Or aAGRONOMO Or aVARIEDAD Or aUBICACION Or aCONTRATO_LG Or aMAESTRO_LOTES Or aLOTES_TRASPASO Then
            Dim numTabla As Integer = 0
            Dim strCampos, strWhere As String
            strCampos = ""
            strWhere = ""
            Me.QuerySelectCampos(aEntidad, args, GetType(LOTES_LG), GetType(SqlParameter), strCampos, strWhere, 0, "LOTES_LG")
            strSQL.AppendLine("SELECT " + strCampos)
            If aPROVEEDOR Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New PROVEEDOR, Nothing, GetType(PROVEEDOR), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aAGRONOMO Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New AGRONOMO, Nothing, GetType(AGRONOMO), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aVARIEDAD Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New VARIEDAD, Nothing, GetType(VARIEDAD), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aUBICACION Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New UBICACION, Nothing, GetType(UBICACION), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aCONTRATO_LG Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New CONTRATO_LG, Nothing, GetType(CONTRATO_LG), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aMAESTRO_LOTES Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New MAESTRO_LOTES, Nothing, GetType(MAESTRO_LOTES), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aLOTES_TRASPASO Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New LOTES_TRASPASO, Nothing, GetType(LOTES_TRASPASO), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            strSQL.AppendLine("FROM LOTES_LG")
            numTabla = 0
            If aPROVEEDOR Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN PROVEEDOR T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".CODIPROVEEDOR = LOTES_LG.CODIPROVEEDOR")
            End If
            If aAGRONOMO Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN AGRONOMO T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".CODIAGRON = LOTES_LG.CODIAGRON")
            End If
            If aVARIEDAD Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN VARIEDAD T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".CODIVARIEDA = LOTES_LG.CODIVARIEDA")
            End If
            If aUBICACION Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN UBICACION T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".CODIUBICACION = LOTES_LG.CODIUBICACION")
            End If
            If aCONTRATO_LG Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN CONTRATO_LG T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".CODICONTRATO = LOTES_LG.CODICONTRATO")
            End If
            If aMAESTRO_LOTES Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN MAESTRO_LOTES T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_MAESTRO = LOTES_LG.ID_MAESTRO")
            End If
            If aLOTES_TRASPASO Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN LOTES_TRASPASO T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_LOTE_TRASPASO = LOTES_LG.ID_LOTE_TRASPASO")
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
                dbAsignarEntidades.AsignarLOTES_LG(dr, aEntidad)
                Dim numTabla As Integer = 0
                If aPROVEEDOR Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarPROVEEDOR(dr, aEntidad.fkCODIPROVEEDOR, "T" + numTabla.ToString())
                End If
                If aAGRONOMO Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarAGRONOMO(dr, aEntidad.fkCODIAGRON, "T" + numTabla.ToString())
                End If
                If aVARIEDAD Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarVARIEDAD(dr, aEntidad.fkCODIVARIEDA, "T" + numTabla.ToString())
                End If
                If aUBICACION Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarUBICACION(dr, aEntidad.fkCODIUBICACION, "T" + numTabla.ToString())
                End If
                If aCONTRATO_LG Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarCONTRATO_LG(dr, aEntidad.fkCODICONTRATO, "T" + numTabla.ToString())
                End If
                If aMAESTRO_LOTES Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarMAESTRO_LOTES(dr, aEntidad.fkID_MAESTRO, "T" + numTabla.ToString())
                End If
                If aLOTES_TRASPASO Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarLOTES_TRASPASO(dr, aEntidad.fkID_LOTE_TRASPASO, "T" + numTabla.ToString())
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
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/08/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorID(ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaLOTES_LG

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New LOTES_LG))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New listaLOTES_LG

        Try
            Do While dr.Read()
                Dim mEntidad As New LOTES_LG
                dbAsignarEntidades.AsignarLOTES_LG(dr, mEntidad)
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
    ''' 	[GenApp]	10/08/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetPorID(ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New LOTES_LG))
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
    ''' 	[GenApp]	10/08/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetPorID(ByRef ds as DataSet, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As Integer

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New LOTES_LG))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim tables(0) As String
        tables(0) = New String("LOTES_LG".ToCharArray())

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
    ''' 	[GenApp]	10/08/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub SelectTabla(ByRef strSQL as StringBuilder)

        strSQL.AppendLine(" SELECT LOTES_LG.ACCESLOTE, ")
        strSQL.AppendLine(" LOTES_LG.ANIOZAFRA, ")
        strSQL.AppendLine(" LOTES_LG.CODIPROVEEDOR, ")
        strSQL.AppendLine(" LOTES_LG.CODILOTE, ")
        strSQL.AppendLine(" LOTES_LG.CODIAGRON, ")
        strSQL.AppendLine(" LOTES_LG.CODIVARIEDA, ")
        strSQL.AppendLine(" LOTES_LG.CODIUBICACION, ")
        strSQL.AppendLine(" LOTES_LG.CODICONTRATO, ")
        strSQL.AppendLine(" LOTES_LG.NOMBLOTE, ")
        strSQL.AppendLine(" LOTES_LG.AREA, ")
        strSQL.AppendLine(" LOTES_LG.TONELADAS, ")
        strSQL.AppendLine(" LOTES_LG.TONEL_TC, ")
        strSQL.AppendLine(" LOTES_LG.ZONA, ")
        strSQL.AppendLine(" LOTES_LG.EDAD_LOTE, ")
        strSQL.AppendLine(" LOTES_LG.USER_CREA, ")
        strSQL.AppendLine(" LOTES_LG.FECHA_CREA, ")
        strSQL.AppendLine(" LOTES_LG.USER_ACT, ")
        strSQL.AppendLine(" LOTES_LG.FECHA_ACT, ")
        strSQL.AppendLine(" LOTES_LG.ID_MAESTRO, ")
        strSQL.AppendLine(" LOTES_LG.TIPO_DERECHO, ")
        strSQL.AppendLine(" LOTES_LG.SUB_ZONA, ")
        strSQL.AppendLine(" LOTES_LG.ID_LOTE_TRASPASO, ")
        strSQL.AppendLine(" LOTES_LG.AREA_CANA, ")
        strSQL.AppendLine(" LOTES_LG.RIESGO_PIEDRA, ")
        strSQL.AppendLine(" LOTES_LG.REPARA_ACCESO, ")
        strSQL.AppendLine(" LOTES_LG.SIN_ACCESO_PROPIO ")
        strSQL.AppendLine(" FROM LOTES_LG ")

    End Sub

#Region "Obtener Listas Por Foraneas"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Foranea, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="CODIPROVEEDOR"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/08/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorPROVEEDOR(ByVal CODIPROVEEDOR As String, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaLOTES_LG

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New LOTES_LG))
        strSQL.Append(" WHERE CODIPROVEEDOR = @CODIPROVEEDOR ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@CODIPROVEEDOR", SqlDbType.VarChar)
        args(0).Value = CODIPROVEEDOR

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaLOTES_LG

        Try
            Do While dr.Read()
                Dim mEntidad As New LOTES_LG
                dbAsignarEntidades.AsignarLOTES_LG(dr, mEntidad)
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
    ''' 	[GenApp]	10/08/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorAGRONOMO(ByVal CODIAGRON As String, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaLOTES_LG

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New LOTES_LG))
        strSQL.Append(" WHERE CODIAGRON = @CODIAGRON ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@CODIAGRON", SqlDbType.VarChar)
        args(0).Value = CODIAGRON

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaLOTES_LG

        Try
            Do While dr.Read()
                Dim mEntidad As New LOTES_LG
                dbAsignarEntidades.AsignarLOTES_LG(dr, mEntidad)
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
    ''' <param name="CODIVARIEDA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/08/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorVARIEDAD(ByVal CODIVARIEDA As String, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaLOTES_LG

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New LOTES_LG))
        strSQL.Append(" WHERE CODIVARIEDA = @CODIVARIEDA ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@CODIVARIEDA", SqlDbType.VarChar)
        args(0).Value = CODIVARIEDA

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaLOTES_LG

        Try
            Do While dr.Read()
                Dim mEntidad As New LOTES_LG
                dbAsignarEntidades.AsignarLOTES_LG(dr, mEntidad)
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
    ''' <param name="CODIUBICACION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/08/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorUBICACION(ByVal CODIUBICACION As String, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaLOTES_LG

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New LOTES_LG))
        strSQL.Append(" WHERE CODIUBICACION = @CODIUBICACION ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@CODIUBICACION", SqlDbType.VarChar)
        args(0).Value = CODIUBICACION

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaLOTES_LG

        Try
            Do While dr.Read()
                Dim mEntidad As New LOTES_LG
                dbAsignarEntidades.AsignarLOTES_LG(dr, mEntidad)
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
    ''' 	[GenApp]	10/08/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorCONTRATO_LG(ByVal CODICONTRATO As String, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaLOTES_LG

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New LOTES_LG))
        strSQL.Append(" WHERE CODICONTRATO = @CODICONTRATO ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@CODICONTRATO", SqlDbType.VarChar)
        args(0).Value = CODICONTRATO

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaLOTES_LG

        Try
            Do While dr.Read()
                Dim mEntidad As New LOTES_LG
                dbAsignarEntidades.AsignarLOTES_LG(dr, mEntidad)
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
    ''' <param name="ID_MAESTRO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/08/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorMAESTRO_LOTES(ByVal ID_MAESTRO As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaLOTES_LG

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New LOTES_LG))
        strSQL.Append(" WHERE ID_MAESTRO = @ID_MAESTRO ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_MAESTRO", SqlDbType.Int)
        args(0).Value = ID_MAESTRO

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaLOTES_LG

        Try
            Do While dr.Read()
                Dim mEntidad As New LOTES_LG
                dbAsignarEntidades.AsignarLOTES_LG(dr, mEntidad)
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
    ''' <param name="ID_LOTE_TRASPASO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/08/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorLOTES_TRASPASO(ByVal ID_LOTE_TRASPASO As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaLOTES_LG

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New LOTES_LG))
        strSQL.Append(" WHERE ID_LOTE_TRASPASO = @ID_LOTE_TRASPASO ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_LOTE_TRASPASO", SqlDbType.Int)
        args(0).Value = ID_LOTE_TRASPASO

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaLOTES_LG

        Try
            Do While dr.Read()
                Dim mEntidad As New LOTES_LG
                dbAsignarEntidades.AsignarLOTES_LG(dr, mEntidad)
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
