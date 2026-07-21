Imports System.Text
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_DL
''' Class	 : DL.dbDESCUENTOS_PLANILLA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Acceso a Datos que contiene las operaciones CRUD(Create, Read,
''' Update y Delete) de la tabla DESCUENTOS_PLANILLA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	16/11/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class dbDESCUENTOS_PLANILLA
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
    ''' 	[GenApp]	16/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Actualizar(ByVal aEntidad As entidadBase) As Integer
        Return Me.Actualizar(aEntidad, TipoConcurrencia.Pesimistica)
    End Function

   
   
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla DESCUENTOS_PLANILLA que se le envía como parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde viene se obtienen los valores de la llave 
    ''' primaria del registro a eliminar.</param>
    ''' <remarks>Por defecto manda a ejecutar eliminación con concurrencia pesimistica.
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer
        Return Me.Eliminar(aEntidad, TipoConcurrencia.Pesimistica)
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
    ''' 	[GenApp]	16/11/2017	Created
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
                dbAsignarEntidades.AsignarDESCUENTOS_PLANILLA(dr, CType(aEntidad,DESCUENTOS_PLANILLA))
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
    ''' 	[GenApp]	16/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function RecuperarConForaneas(ByVal aEntidad As DESCUENTOS_PLANILLA, Optional ByVal aCATORCENA_ZAFRA As Boolean = False, Optional ByVal aPLANILLA As Boolean = False, Optional ByVal aTIPO_PLANILLA As Boolean = False, Optional ByVal aTIPO_DESCUENTO As Boolean = False, Optional ByVal aAPLICACION_DESCTO As Boolean = False, Optional ByVal aBANCOS As Boolean = False, Optional ByVal aCREDITO_ENCA As Boolean = False, Optional ByVal aCREDITO_ENCA_TRANS As Boolean = False) As Integer

        Dim strSQL As New StringBuilder
        Dim args(0) As SqlParameter

        If aCATORCENA_ZAFRA Or aPLANILLA Or aTIPO_PLANILLA Or aTIPO_DESCUENTO Or aAPLICACION_DESCTO Or aBANCOS Or aCREDITO_ENCA Or aCREDITO_ENCA_TRANS Then
            Dim numTabla As Integer = 0
            Dim strCampos, strWhere As String
            strCampos = ""
            strWhere = ""
            Me.QuerySelectCampos(aEntidad, args, GetType(DESCUENTOS_PLANILLA), GetType(SqlParameter), strCampos, strWhere, 0, "DESCUENTOS_PLANILLA")
            strSQL.AppendLine("SELECT " + strCampos)
            If aCATORCENA_ZAFRA Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New CATORCENA_ZAFRA, Nothing, GetType(CATORCENA_ZAFRA), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aPLANILLA Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New PLANILLA, Nothing, GetType(PLANILLA), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aTIPO_PLANILLA Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New TIPO_PLANILLA, Nothing, GetType(TIPO_PLANILLA), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aTIPO_DESCUENTO Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New TIPO_DESCUENTO, Nothing, GetType(TIPO_DESCUENTO), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aAPLICACION_DESCTO Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New APLICACION_DESCTO, Nothing, GetType(APLICACION_DESCTO), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aBANCOS Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New BANCOS, Nothing, GetType(BANCOS), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aCREDITO_ENCA Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New CREDITO_ENCA, Nothing, GetType(CREDITO_ENCA), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aCREDITO_ENCA_TRANS Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New CREDITO_ENCA_TRANS, Nothing, GetType(CREDITO_ENCA_TRANS), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            strSQL.AppendLine("FROM DESCUENTOS_PLANILLA")
            numTabla = 0
            If aCATORCENA_ZAFRA Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN CATORCENA_ZAFRA T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_CATORCENA = DESCUENTOS_PLANILLA.ID_CATORCENA")
            End If
            If aPLANILLA Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN PLANILLA T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".CODIPROVEEDOR_TRANSPORTISTA = DESCUENTOS_PLANILLA.CODIPROVEEDOR_TRANSPORTISTA")
            End If
            If aTIPO_PLANILLA Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN TIPO_PLANILLA T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_TIPO_PLANILLA = DESCUENTOS_PLANILLA.ID_TIPO_PLANILLA")
            End If
            If aTIPO_DESCUENTO Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN TIPO_DESCUENTO T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_TIPO_DESCTO = DESCUENTOS_PLANILLA.ID_TIPO_DESCTO")
            End If
            If aAPLICACION_DESCTO Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN APLICACION_DESCTO T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_APLICACION_DESCTO = DESCUENTOS_PLANILLA.ID_APLICACION_DESCTO")
            End If
            If aBANCOS Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN BANCOS T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".CODIBANCO = DESCUENTOS_PLANILLA.CODIBANCO")
            End If
            If aCREDITO_ENCA Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN CREDITO_ENCA T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_CREDITO_ENCA = DESCUENTOS_PLANILLA.ID_CREDITO_ENCA")
            End If
            If aCREDITO_ENCA_TRANS Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN CREDITO_ENCA_TRANS T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_CREDITO_ENCA = DESCUENTOS_PLANILLA.ID_CREDITO_ENCA_TRANS")
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
                dbAsignarEntidades.AsignarDESCUENTOS_PLANILLA(dr, aEntidad)
                Dim numTabla As Integer = 0
                If aCATORCENA_ZAFRA Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarCATORCENA_ZAFRA(dr, aEntidad.fkID_CATORCENA, "T" + numTabla.ToString())
                End If
                If aPLANILLA Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarPLANILLA(dr, aEntidad.fkCODIPROVEEDOR_TRANSPORTISTA, "T" + numTabla.ToString())
                End If
                If aTIPO_PLANILLA Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarTIPO_PLANILLA(dr, aEntidad.fkID_TIPO_PLANILLA, "T" + numTabla.ToString())
                End If
                If aTIPO_DESCUENTO Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarTIPO_DESCUENTO(dr, aEntidad.fkID_TIPO_DESCTO, "T" + numTabla.ToString())
                End If
                If aAPLICACION_DESCTO Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarAPLICACION_DESCTO(dr, aEntidad.fkID_APLICACION_DESCTO, "T" + numTabla.ToString())
                End If
                If aBANCOS Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarBANCOS(dr, aEntidad.fkCODIBANCO, "T" + numTabla.ToString())
                End If
                If aCREDITO_ENCA Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarCREDITO_ENCA(dr, aEntidad.fkID_CREDITO_ENCA, "T" + numTabla.ToString())
                End If
                If aCREDITO_ENCA_TRANS Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarCREDITO_ENCA_TRANS(dr, aEntidad.fkID_CREDITO_ENCA_TRANS, "T" + numTabla.ToString())
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
        strSQL.AppendLine("SELECT isnull(max(ID_DESCUENTO_PLANILLA),0) + 1 ")
        strSQL.AppendLine(" FROM DESCUENTOS_PLANILLA ")

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
    ''' 	[GenApp]	16/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorID(ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaDESCUENTOS_PLANILLA

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New DESCUENTOS_PLANILLA))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New listaDESCUENTOS_PLANILLA

        Try
            Do While dr.Read()
                Dim mEntidad As New DESCUENTOS_PLANILLA
                dbAsignarEntidades.AsignarDESCUENTOS_PLANILLA(dr, mEntidad)
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
    ''' 	[GenApp]	16/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetPorID(ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New DESCUENTOS_PLANILLA))
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
    ''' 	[GenApp]	16/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetPorID(ByRef ds as DataSet, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As Integer

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New DESCUENTOS_PLANILLA))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim tables(0) As String
        tables(0) = New String("DESCUENTOS_PLANILLA".ToCharArray())

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
    ''' 	[GenApp]	16/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub SelectTabla(ByRef strSQL as StringBuilder)

        strSQL.AppendLine(" SELECT DESCUENTOS_PLANILLA.ID_DESCUENTO_PLANILLA, ")
        strSQL.AppendLine(" DESCUENTOS_PLANILLA.ID_CATORCENA, ")
        strSQL.AppendLine(" DESCUENTOS_PLANILLA.CODIPROVEEDOR_TRANSPORTISTA, ")
        strSQL.AppendLine(" DESCUENTOS_PLANILLA.ID_TIPO_PLANILLA, ")
        strSQL.AppendLine(" DESCUENTOS_PLANILLA.ID_TIPO_DESCTO, ")
        strSQL.AppendLine(" DESCUENTOS_PLANILLA.ID_APLICACION_DESCTO, ")
        strSQL.AppendLine(" DESCUENTOS_PLANILLA.MONTO_DESCUENTO, ")
        strSQL.AppendLine(" DESCUENTOS_PLANILLA.USUARIO_CREA, ")
        strSQL.AppendLine(" DESCUENTOS_PLANILLA.FECHA_CREA, ")
        strSQL.AppendLine(" DESCUENTOS_PLANILLA.USUARIO_ACT, ")
        strSQL.AppendLine(" DESCUENTOS_PLANILLA.FECHA_ACT, ")
        strSQL.AppendLine(" DESCUENTOS_PLANILLA.IVA, ")
        strSQL.AppendLine(" DESCUENTOS_PLANILLA.CODIBANCO, ")
        strSQL.AppendLine(" DESCUENTOS_PLANILLA.ID_CREDITO_ENCA, ")
        strSQL.AppendLine(" DESCUENTOS_PLANILLA.ID_CREDITO_ENCA_TRANS ")
        strSQL.AppendLine(" FROM DESCUENTOS_PLANILLA ")

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
    ''' 	[GenApp]	16/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorCATORCENA_ZAFRA(ByVal ID_CATORCENA As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaDESCUENTOS_PLANILLA

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New DESCUENTOS_PLANILLA))
        strSQL.Append(" WHERE ID_CATORCENA = @ID_CATORCENA ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_CATORCENA", SqlDbType.Int)
        args(0).Value = ID_CATORCENA

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaDESCUENTOS_PLANILLA

        Try
            Do While dr.Read()
                Dim mEntidad As New DESCUENTOS_PLANILLA
                dbAsignarEntidades.AsignarDESCUENTOS_PLANILLA(dr, mEntidad)
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
    ''' <param name="ID_CATORCENA"></param>
    ''' <param name="CODIPROVEEDOR_TRANSPORTISTA"></param>
    ''' <param name="ID_TIPO_PLANILLA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorPLANILLA(ByVal ID_CATORCENA As Int32, ByVal CODIPROVEEDOR_TRANSPORTISTA As String, ByVal ID_TIPO_PLANILLA As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaDESCUENTOS_PLANILLA

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New DESCUENTOS_PLANILLA))
        strSQL.Append(" WHERE ID_CATORCENA = @ID_CATORCENA ") 
        strSQL.Append(" AND CODIPROVEEDOR_TRANSPORTISTA = @CODIPROVEEDOR_TRANSPORTISTA ") 
        strSQL.Append(" AND ID_TIPO_PLANILLA = @ID_TIPO_PLANILLA ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ID_CATORCENA", SqlDbType.Int)
        args(0).Value = ID_CATORCENA
        args(1) = New SqlParameter("@CODIPROVEEDOR_TRANSPORTISTA", SqlDbType.VarChar)
        args(1).Value = CODIPROVEEDOR_TRANSPORTISTA
        args(2) = New SqlParameter("@ID_TIPO_PLANILLA", SqlDbType.Int)
        args(2).Value = ID_TIPO_PLANILLA

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaDESCUENTOS_PLANILLA

        Try
            Do While dr.Read()
                Dim mEntidad As New DESCUENTOS_PLANILLA
                dbAsignarEntidades.AsignarDESCUENTOS_PLANILLA(dr, mEntidad)
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
    ''' 	[GenApp]	16/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorTIPO_PLANILLA(ByVal ID_TIPO_PLANILLA As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaDESCUENTOS_PLANILLA

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New DESCUENTOS_PLANILLA))
        strSQL.Append(" WHERE ID_TIPO_PLANILLA = @ID_TIPO_PLANILLA ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_TIPO_PLANILLA", SqlDbType.Int)
        args(0).Value = ID_TIPO_PLANILLA

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaDESCUENTOS_PLANILLA

        Try
            Do While dr.Read()
                Dim mEntidad As New DESCUENTOS_PLANILLA
                dbAsignarEntidades.AsignarDESCUENTOS_PLANILLA(dr, mEntidad)
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
    ''' <param name="ID_TIPO_DESCTO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorTIPO_DESCUENTO(ByVal ID_TIPO_DESCTO As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaDESCUENTOS_PLANILLA

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New DESCUENTOS_PLANILLA))
        strSQL.Append(" WHERE ID_TIPO_DESCTO = @ID_TIPO_DESCTO ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_TIPO_DESCTO", SqlDbType.Int)
        args(0).Value = ID_TIPO_DESCTO

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaDESCUENTOS_PLANILLA

        Try
            Do While dr.Read()
                Dim mEntidad As New DESCUENTOS_PLANILLA
                dbAsignarEntidades.AsignarDESCUENTOS_PLANILLA(dr, mEntidad)
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
    ''' <param name="ID_APLICACION_DESCTO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorAPLICACION_DESCTO(ByVal ID_APLICACION_DESCTO As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaDESCUENTOS_PLANILLA

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New DESCUENTOS_PLANILLA))
        strSQL.Append(" WHERE ID_APLICACION_DESCTO = @ID_APLICACION_DESCTO ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_APLICACION_DESCTO", SqlDbType.Int)
        args(0).Value = ID_APLICACION_DESCTO

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaDESCUENTOS_PLANILLA

        Try
            Do While dr.Read()
                Dim mEntidad As New DESCUENTOS_PLANILLA
                dbAsignarEntidades.AsignarDESCUENTOS_PLANILLA(dr, mEntidad)
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
    ''' <param name="CODIBANCO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorBANCOS(ByVal CODIBANCO As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaDESCUENTOS_PLANILLA

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New DESCUENTOS_PLANILLA))
        strSQL.Append(" WHERE CODIBANCO = @CODIBANCO ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@CODIBANCO", SqlDbType.Int)
        args(0).Value = CODIBANCO

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaDESCUENTOS_PLANILLA

        Try
            Do While dr.Read()
                Dim mEntidad As New DESCUENTOS_PLANILLA
                dbAsignarEntidades.AsignarDESCUENTOS_PLANILLA(dr, mEntidad)
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
    ''' <param name="ID_CREDITO_ENCA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorCREDITO_ENCA(ByVal ID_CREDITO_ENCA As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaDESCUENTOS_PLANILLA

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New DESCUENTOS_PLANILLA))
        strSQL.Append(" WHERE ID_CREDITO_ENCA = @ID_CREDITO_ENCA ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_CREDITO_ENCA", SqlDbType.Int)
        args(0).Value = ID_CREDITO_ENCA

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaDESCUENTOS_PLANILLA

        Try
            Do While dr.Read()
                Dim mEntidad As New DESCUENTOS_PLANILLA
                dbAsignarEntidades.AsignarDESCUENTOS_PLANILLA(dr, mEntidad)
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
    ''' <param name="ID_CREDITO_ENCA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorCREDITO_ENCA_TRANS(ByVal ID_CREDITO_ENCA As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaDESCUENTOS_PLANILLA

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New DESCUENTOS_PLANILLA))
        strSQL.Append(" WHERE ID_CREDITO_ENCA = @ID_CREDITO_ENCA ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_CREDITO_ENCA", SqlDbType.Int)
        args(0).Value = ID_CREDITO_ENCA

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaDESCUENTOS_PLANILLA

        Try
            Do While dr.Read()
                Dim mEntidad As New DESCUENTOS_PLANILLA
                dbAsignarEntidades.AsignarDESCUENTOS_PLANILLA(dr, mEntidad)
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
