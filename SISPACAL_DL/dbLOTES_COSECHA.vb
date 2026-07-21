Imports System.Text
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_DL
''' Class	 : DL.dbLOTES_COSECHA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Acceso a Datos que contiene las operaciones CRUD(Create, Read,
''' Update y Delete) de la tabla LOTES_COSECHA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	19/01/2015	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class dbLOTES_COSECHA
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
    ''' 	[GenApp]	19/01/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Actualizar(ByVal aEntidad As entidadBase) As Integer
        Return Me.Actualizar(aEntidad, TipoConcurrencia.Pesimistica)
    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla LOTES_COSECHA que se le envía como parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde viene se obtienen los valores de la llave 
    ''' primaria del registro a eliminar.</param>
    ''' <remarks>Por defecto manda a ejecutar eliminación con concurrencia pesimistica.
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer
        Return Me.Eliminar(aEntidad, TipoConcurrencia.Pesimistica)
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla LOTES_COSECHA que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde viene se obtienen los valores de la llave 
    ''' primaria del registro a eliminar.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el 
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2015	Created
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
    ''' 	[GenApp]	19/01/2015	Created
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
                dbAsignarEntidades.AsignarLOTES_COSECHA(dr, CType(aEntidad,LOTES_COSECHA))
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
    ''' 	[GenApp]	19/01/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function RecuperarConForaneas(ByVal aEntidad As LOTES_COSECHA, Optional ByVal aLOTES As Boolean = False, Optional ByVal aZAFRA As Boolean = False, Optional ByVal aAGRONOMO As Boolean = False, Optional ByVal aTIPOS_GENERALES As Boolean = False) As Integer

        Dim strSQL As New StringBuilder
        Dim args(0) As SqlParameter

        If aLOTES Or aZAFRA Or aAGRONOMO Or aTIPOS_GENERALES Then
            Dim numTabla As Integer = 0
            Dim strCampos, strWhere As String
            strCampos = ""
            strWhere = ""
            Me.QuerySelectCampos(aEntidad, args, GetType(LOTES_COSECHA), GetType(SqlParameter), strCampos, strWhere, 0, "LOTES_COSECHA")
            strSQL.AppendLine("SELECT " + strCampos)
            If aLOTES Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New LOTES, Nothing, GetType(LOTES), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aZAFRA Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New ZAFRA, Nothing, GetType(ZAFRA), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aAGRONOMO Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New AGRONOMO, Nothing, GetType(AGRONOMO), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aTIPOS_GENERALES Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New TIPOS_GENERALES, Nothing, GetType(TIPOS_GENERALES), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            strSQL.AppendLine("FROM LOTES_COSECHA")
            numTabla = 0
            If aLOTES Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN LOTES T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ACCESLOTE = LOTES_COSECHA.ACCESLOTE")
            End If
            If aZAFRA Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN ZAFRA T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_ZAFRA = LOTES_COSECHA.ID_ZAFRA")
            End If
            If aAGRONOMO Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN AGRONOMO T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".CODIAGRON = LOTES_COSECHA.CODIAGRON")
            End If
            If aTIPOS_GENERALES Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN TIPOS_GENERALES T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_TIPO = LOTES_COSECHA.ID_TIPO_CANA AND T" + numTabla.ToString() + ".ID_TIPO = LOTES_COSECHA.ID_TIPO_ROZA AND T" + numTabla.ToString() + ".ID_TIPO = LOTES_COSECHA.ID_TIPO_ALZA AND T" + numTabla.ToString() + ".ID_TIPO = LOTES_COSECHA.ID_TIPO_TRANS")
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
                dbAsignarEntidades.AsignarLOTES_COSECHA(dr, aEntidad)
                Dim numTabla As Integer = 0
                If aLOTES Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarLOTES(dr, aEntidad.fkACCESLOTE, "T" + numTabla.ToString())
                End If
                If aZAFRA Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarZAFRA(dr, aEntidad.fkID_ZAFRA, "T" + numTabla.ToString())
                End If
                If aAGRONOMO Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarAGRONOMO(dr, aEntidad.fkCODIAGRON, "T" + numTabla.ToString())
                End If
                If aTIPOS_GENERALES Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarTIPOS_GENERALES(dr, aEntidad.fkID_TIPO_CANA, "T" + numTabla.ToString())
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
        strSQL.AppendLine("SELECT isnull(max(ID_LOTES_COSECHA),0) + 1 ")
        strSQL.AppendLine(" FROM LOTES_COSECHA ")

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
    ''' 	[GenApp]	19/01/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorID(ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaLOTES_COSECHA

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New LOTES_COSECHA))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New listaLOTES_COSECHA

        Try
            Do While dr.Read()
                Dim mEntidad As New LOTES_COSECHA
                dbAsignarEntidades.AsignarLOTES_COSECHA(dr, mEntidad)
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
    ''' 	[GenApp]	19/01/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetPorID(ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New LOTES_COSECHA))
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
    ''' 	[GenApp]	19/01/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetPorID(ByRef ds as DataSet, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As Integer

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New LOTES_COSECHA))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim tables(0) As String
        tables(0) = New String("LOTES_COSECHA".ToCharArray())

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
    ''' 	[GenApp]	19/01/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub SelectTabla(ByRef strSQL as StringBuilder)

        strSQL.AppendLine(" SELECT LOTES_COSECHA.ID_LOTES_COSECHA, ")
        strSQL.AppendLine(" LOTES_COSECHA.ACCESLOTE, ")
        strSQL.AppendLine(" LOTES_COSECHA.ID_ZAFRA, ")
        strSQL.AppendLine(" LOTES_COSECHA.FECHA_ROZA, ")
        strSQL.AppendLine(" LOTES_COSECHA.REND_COSECHA, ")
        strSQL.AppendLine(" LOTES_COSECHA.MZ_ENTREGAR, ")
        strSQL.AppendLine(" LOTES_COSECHA.TONEL_MZ_ENTREGAR, ")
        strSQL.AppendLine(" LOTES_COSECHA.TONEL_ENTREGAR, ")
        strSQL.AppendLine(" LOTES_COSECHA.LBS_ENTREGAR, ")
        strSQL.AppendLine(" LOTES_COSECHA.VALOR_ENTREGAR, ")
        strSQL.AppendLine(" LOTES_COSECHA.MZ_ENTREGADA, ")
        strSQL.AppendLine(" LOTES_COSECHA.TONEL_MZ_ENTREGADA, ")
        strSQL.AppendLine(" LOTES_COSECHA.TONEL_ENTREGADA, ")
        strSQL.AppendLine(" LOTES_COSECHA.LBS_ENTREGADA, ")
        strSQL.AppendLine(" LOTES_COSECHA.VALOR_ENTREGADA, ")
        strSQL.AppendLine(" LOTES_COSECHA.MZ_CENSO, ")
        strSQL.AppendLine(" LOTES_COSECHA.TONEL_MZ_CENSO, ")
        strSQL.AppendLine(" LOTES_COSECHA.TONEL_CENSO, ")
        strSQL.AppendLine(" LOTES_COSECHA.LBS_CENSO, ")
        strSQL.AppendLine(" LOTES_COSECHA.VALOR_CENSO, ")
        strSQL.AppendLine(" LOTES_COSECHA.FIN_LOTE, ")
        strSQL.AppendLine(" LOTES_COSECHA.USUARIO_CREA, ")
        strSQL.AppendLine(" LOTES_COSECHA.FECHA_CREA, ")
        strSQL.AppendLine(" LOTES_COSECHA.USUARIO_ACT, ")
        strSQL.AppendLine(" LOTES_COSECHA.FECHA_ACT, ")
        strSQL.AppendLine(" LOTES_COSECHA.CODIAGRON, ")
        strSQL.AppendLine(" LOTES_COSECHA.FECHA_SIEMBRA, ")
        strSQL.AppendLine(" LOTES_COSECHA.ID_TIPO_CANA, ")
        strSQL.AppendLine(" LOTES_COSECHA.ID_TIPO_ROZA, ")
        strSQL.AppendLine(" LOTES_COSECHA.ID_TIPO_ALZA, ")
        strSQL.AppendLine(" LOTES_COSECHA.ID_TIPO_TRANS, ")
        strSQL.AppendLine(" LOTES_COSECHA.FAB_SEMANA, ")
        strSQL.AppendLine(" LOTES_COSECHA.FAB_CATORCENA, ")
        strSQL.AppendLine(" LOTES_COSECHA.FAB_SUBTERCIO, ")
        strSQL.AppendLine(" LOTES_COSECHA.FAB_TERCIO, ")
        strSQL.AppendLine(" LOTES_COSECHA.TARIFA_ROZA, ")
        strSQL.AppendLine(" LOTES_COSECHA.TARIFA_ALZA, ")
        strSQL.AppendLine(" LOTES_COSECHA.TARIFA_TRANS, ")
        strSQL.AppendLine(" LOTES_COSECHA.TARIFA_CORTA, ")
        strSQL.AppendLine(" LOTES_COSECHA.TARIFA_LARGA, ")
        strSQL.AppendLine(" LOTES_COSECHA.SALDO_ROZA, ")
        strSQL.AppendLine(" LOTES_COSECHA.EDAD_LOTE, ")
        strSQL.AppendLine(" LOTES_COSECHA.SALDO_QUEMA, ")
        strSQL.AppendLine(" LOTES_COSECHA.FECHA_ROZA_DISPO, ")
        strSQL.AppendLine(" LOTES_COSECHA.TONEL_SALDO_VAR, ")
        strSQL.AppendLine(" LOTES_COSECHA.TONEL_SEMILLA ")
        strSQL.AppendLine(" FROM LOTES_COSECHA ")

    End Sub

#Region "Obtener Listas Por Foraneas"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Foranea, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="ACCESLOTE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorLOTES(ByVal ACCESLOTE As String, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaLOTES_COSECHA

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New LOTES_COSECHA))
        strSQL.Append(" WHERE ACCESLOTE = @ACCESLOTE ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ACCESLOTE", SqlDbType.VarChar)
        args(0).Value = ACCESLOTE

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaLOTES_COSECHA

        Try
            Do While dr.Read()
                Dim mEntidad As New LOTES_COSECHA
                dbAsignarEntidades.AsignarLOTES_COSECHA(dr, mEntidad)
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
    ''' <param name="ID_ZAFRA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorZAFRA(ByVal ID_ZAFRA As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaLOTES_COSECHA

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New LOTES_COSECHA))
        strSQL.Append(" WHERE ID_ZAFRA = @ID_ZAFRA ")
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        args(0).Value = ID_ZAFRA

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaLOTES_COSECHA

        Try
            Do While dr.Read()
                Dim mEntidad As New LOTES_COSECHA
                dbAsignarEntidades.AsignarLOTES_COSECHA(dr, mEntidad)
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
    ''' 	[GenApp]	19/01/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorAGRONOMO(ByVal CODIAGRON As String, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaLOTES_COSECHA

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New LOTES_COSECHA))
        strSQL.Append(" WHERE CODIAGRON = @CODIAGRON ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@CODIAGRON", SqlDbType.VarChar)
        args(0).Value = CODIAGRON

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaLOTES_COSECHA

        Try
            Do While dr.Read()
                Dim mEntidad As New LOTES_COSECHA
                dbAsignarEntidades.AsignarLOTES_COSECHA(dr, mEntidad)
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
    ''' 	[GenApp]	19/01/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorTIPOS_GENERALES(ByVal ID_TIPO As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaLOTES_COSECHA

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New LOTES_COSECHA))
        strSQL.Append(" WHERE ID_TIPO = @ID_TIPO ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_TIPO", SqlDbType.Int)
        args(0).Value = ID_TIPO

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaLOTES_COSECHA

        Try
            Do While dr.Read()
                Dim mEntidad As New LOTES_COSECHA
                dbAsignarEntidades.AsignarLOTES_COSECHA(dr, mEntidad)
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
