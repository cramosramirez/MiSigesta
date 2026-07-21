Imports System.Text
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_DL
''' Class	 : DL.dbCCF_ENCA_TRANS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Acceso a Datos que contiene las operaciones CRUD(Create, Read,
''' Update y Delete) de la tabla CCF_ENCA_TRANS
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	30/11/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class dbCCF_ENCA_TRANS
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
    ''' 	[GenApp]	30/11/2017	Created
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
    ''' 	[GenApp]	30/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overloads Function Actualizar(ByVal aEntidad As entidadBase, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer

        Dim lEntidad As CCF_ENCA_TRANS
        lEntidad = CType(aEntidad, CCF_ENCA_TRANS)

        Dim lID As Int32
        If lEntidad.ID_CCF_TRANS =  0 _
            Or lEntidad.ID_CCF_TRANS = Nothing Then 

            lID = CType(Me.ObtenerID(lEntidad), Int32)

            If lID = -1 Then Return -1

            lEntidad.ID_CCF_TRANS = lID

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
    ''' 	[GenApp]	30/11/2017	Created
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
    ''' Función que Elimina un Registro de la Tabla CCF_ENCA_TRANS que se le envía como parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde viene se obtienen los valores de la llave 
    ''' primaria del registro a eliminar.</param>
    ''' <remarks>Por defecto manda a ejecutar eliminación con concurrencia pesimistica.
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	30/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer
        Return Me.Eliminar(aEntidad, TipoConcurrencia.Pesimistica)
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla CCF_ENCA_TRANS que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde viene se obtienen los valores de la llave 
    ''' primaria del registro a eliminar.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el 
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	30/11/2017	Created
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
    ''' 	[GenApp]	30/11/2017	Created
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
                dbAsignarEntidades.AsignarCCF_ENCA_TRANS(dr, CType(aEntidad,CCF_ENCA_TRANS))
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
    ''' 	[GenApp]	30/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function RecuperarConForaneas(ByVal aEntidad As CCF_ENCA_TRANS, Optional ByVal aTRANSPORTISTA As Boolean = False, Optional ByVal aZAFRA As Boolean = False, Optional ByVal aSOLIC_ENCA_TRANS As Boolean = False, Optional ByVal aCUENTA_FINAN As Boolean = False, Optional ByVal aTIPO_COMPROB As Boolean = False, Optional ByVal aPROVEEDOR_AGRICOLA As Boolean = False) As Integer

        Dim strSQL As New StringBuilder
        Dim args(0) As SqlParameter

        If aTRANSPORTISTA Or aZAFRA Or aSOLIC_ENCA_TRANS Or aCUENTA_FINAN Or aTIPO_COMPROB Or aPROVEEDOR_AGRICOLA Then
            Dim numTabla As Integer = 0
            Dim strCampos, strWhere As String
            strCampos = ""
            strWhere = ""
            Me.QuerySelectCampos(aEntidad, args, GetType(CCF_ENCA_TRANS), GetType(SqlParameter), strCampos, strWhere, 0, "CCF_ENCA_TRANS")
            strSQL.AppendLine("SELECT " + strCampos)
            If aTRANSPORTISTA Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New TRANSPORTISTA, Nothing, GetType(TRANSPORTISTA), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aZAFRA Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New ZAFRA, Nothing, GetType(ZAFRA), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aSOLIC_ENCA_TRANS Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New SOLIC_ENCA_TRANS, Nothing, GetType(SOLIC_ENCA_TRANS), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aCUENTA_FINAN Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New CUENTA_FINAN, Nothing, GetType(CUENTA_FINAN), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aTIPO_COMPROB Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New TIPO_COMPROB, Nothing, GetType(TIPO_COMPROB), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aPROVEEDOR_AGRICOLA Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New PROVEEDOR_AGRICOLA, Nothing, GetType(PROVEEDOR_AGRICOLA), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            strSQL.AppendLine("FROM CCF_ENCA_TRANS")
            numTabla = 0
            If aTRANSPORTISTA Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN TRANSPORTISTA T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".CODTRANSPORT = CCF_ENCA_TRANS.CODTRANSPORT")
            End If
            If aZAFRA Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN ZAFRA T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_ZAFRA = CCF_ENCA_TRANS.ID_ZAFRA")
            End If
            If aSOLIC_ENCA_TRANS Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN SOLIC_ENCA_TRANS T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_SOLICITUD = CCF_ENCA_TRANS.ID_SOLICITUD")
            End If
            If aCUENTA_FINAN Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN CUENTA_FINAN T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_CUENTA_FINAN = CCF_ENCA_TRANS.ID_CUENTA_FINAN")
            End If
            If aTIPO_COMPROB Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN TIPO_COMPROB T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_TIPO_COMPROB = CCF_ENCA_TRANS.ID_TIPO_COMPROB")
            End If
            If aPROVEEDOR_AGRICOLA Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN PROVEEDOR_AGRICOLA T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_PROVEE = CCF_ENCA_TRANS.ID_PROVEE")
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
                dbAsignarEntidades.AsignarCCF_ENCA_TRANS(dr, aEntidad)
                Dim numTabla As Integer = 0
                If aTRANSPORTISTA Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarTRANSPORTISTA(dr, aEntidad.fkCODTRANSPORT, "T" + numTabla.ToString())
                End If
                If aZAFRA Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarZAFRA(dr, aEntidad.fkID_ZAFRA, "T" + numTabla.ToString())
                End If
                If aSOLIC_ENCA_TRANS Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarSOLIC_ENCA_TRANS(dr, aEntidad.fkID_SOLICITUD, "T" + numTabla.ToString())
                End If
                If aCUENTA_FINAN Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarCUENTA_FINAN(dr, aEntidad.fkID_CUENTA_FINAN, "T" + numTabla.ToString())
                End If
                If aTIPO_COMPROB Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarTIPO_COMPROB(dr, aEntidad.fkID_TIPO_COMPROB, "T" + numTabla.ToString())
                End If
                If aPROVEEDOR_AGRICOLA Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarPROVEEDOR_AGRICOLA(dr, aEntidad.fkID_PROVEE, "T" + numTabla.ToString())
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
        strSQL.AppendLine("SELECT isnull(max(ID_CCF_TRANS),0) + 1 ")
        strSQL.AppendLine(" FROM CCF_ENCA_TRANS ")

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
    ''' 	[GenApp]	30/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorID(ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaCCF_ENCA_TRANS

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New CCF_ENCA_TRANS))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New listaCCF_ENCA_TRANS

        Try
            Do While dr.Read()
                Dim mEntidad As New CCF_ENCA_TRANS
                dbAsignarEntidades.AsignarCCF_ENCA_TRANS(dr, mEntidad)
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
    ''' 	[GenApp]	30/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetPorID(ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New CCF_ENCA_TRANS))
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
    ''' 	[GenApp]	30/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetPorID(ByRef ds as DataSet, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As Integer

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New CCF_ENCA_TRANS))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim tables(0) As String
        tables(0) = New String("CCF_ENCA_TRANS".ToCharArray())

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
    ''' 	[GenApp]	30/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub SelectTabla(ByRef strSQL as StringBuilder)

        strSQL.AppendLine(" SELECT CCF_ENCA_TRANS.ID_CCF_TRANS, ")
        strSQL.AppendLine(" CCF_ENCA_TRANS.CODTRANSPORT, ")
        strSQL.AppendLine(" CCF_ENCA_TRANS.ID_ZAFRA, ")
        strSQL.AppendLine(" CCF_ENCA_TRANS.ID_SOLICITUD, ")
        strSQL.AppendLine(" CCF_ENCA_TRANS.ID_CUENTA_FINAN, ")
        strSQL.AppendLine(" CCF_ENCA_TRANS.ID_TIPO_COMPROB, ")
        strSQL.AppendLine(" CCF_ENCA_TRANS.ID_PROVEE, ")
        strSQL.AppendLine(" CCF_ENCA_TRANS.NO_CCF, ")
        strSQL.AppendLine(" CCF_ENCA_TRANS.CONDI_COMPRA, ")
        strSQL.AppendLine(" CCF_ENCA_TRANS.UID_CCF, ")
        strSQL.AppendLine(" CCF_ENCA_TRANS.FECHA, ")
        strSQL.AppendLine(" CCF_ENCA_TRANS.SUB_TOTAL, ")
        strSQL.AppendLine(" CCF_ENCA_TRANS.DESCTO_PORC, ")
        strSQL.AppendLine(" CCF_ENCA_TRANS.DESCTO_MONTO, ")
        strSQL.AppendLine(" CCF_ENCA_TRANS.SUMAS, ")
        strSQL.AppendLine(" CCF_ENCA_TRANS.IVA, ")
        strSQL.AppendLine(" CCF_ENCA_TRANS.TOTAL, ")
        strSQL.AppendLine(" CCF_ENCA_TRANS.USUARIO_CREACION, ")
        strSQL.AppendLine(" CCF_ENCA_TRANS.FECHA_CREACION, ")
        strSQL.AppendLine(" CCF_ENCA_TRANS.CESC ")
        strSQL.AppendLine(" FROM CCF_ENCA_TRANS ")

    End Sub

#Region "Obtener Listas Por Foraneas"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Foranea, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="CODTRANSPORT"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	30/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorTRANSPORTISTA(ByVal CODTRANSPORT As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaCCF_ENCA_TRANS

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New CCF_ENCA_TRANS))
        strSQL.Append(" WHERE CODTRANSPORT = @CODTRANSPORT ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@CODTRANSPORT", SqlDbType.Int)
        args(0).Value = CODTRANSPORT

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaCCF_ENCA_TRANS

        Try
            Do While dr.Read()
                Dim mEntidad As New CCF_ENCA_TRANS
                dbAsignarEntidades.AsignarCCF_ENCA_TRANS(dr, mEntidad)
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
    ''' 	[GenApp]	30/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorZAFRA(ByVal ID_ZAFRA As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaCCF_ENCA_TRANS

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New CCF_ENCA_TRANS))
        strSQL.Append(" WHERE ID_ZAFRA = @ID_ZAFRA ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        args(0).Value = ID_ZAFRA

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaCCF_ENCA_TRANS

        Try
            Do While dr.Read()
                Dim mEntidad As New CCF_ENCA_TRANS
                dbAsignarEntidades.AsignarCCF_ENCA_TRANS(dr, mEntidad)
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
    ''' <param name="ID_SOLICITUD"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	30/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorSOLIC_ENCA_TRANS(ByVal ID_SOLICITUD As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaCCF_ENCA_TRANS

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New CCF_ENCA_TRANS))
        strSQL.Append(" WHERE ID_SOLICITUD = @ID_SOLICITUD ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_SOLICITUD", SqlDbType.Int)
        args(0).Value = ID_SOLICITUD

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaCCF_ENCA_TRANS

        Try
            Do While dr.Read()
                Dim mEntidad As New CCF_ENCA_TRANS
                dbAsignarEntidades.AsignarCCF_ENCA_TRANS(dr, mEntidad)
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
    ''' <param name="ID_CUENTA_FINAN"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	30/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorCUENTA_FINAN(ByVal ID_CUENTA_FINAN As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaCCF_ENCA_TRANS

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New CCF_ENCA_TRANS))
        strSQL.Append(" WHERE ID_CUENTA_FINAN = @ID_CUENTA_FINAN ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_CUENTA_FINAN", SqlDbType.Int)
        args(0).Value = ID_CUENTA_FINAN

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaCCF_ENCA_TRANS

        Try
            Do While dr.Read()
                Dim mEntidad As New CCF_ENCA_TRANS
                dbAsignarEntidades.AsignarCCF_ENCA_TRANS(dr, mEntidad)
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
    ''' <param name="ID_TIPO_COMPROB"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	30/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorTIPO_COMPROB(ByVal ID_TIPO_COMPROB As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaCCF_ENCA_TRANS

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New CCF_ENCA_TRANS))
        strSQL.Append(" WHERE ID_TIPO_COMPROB = @ID_TIPO_COMPROB ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_TIPO_COMPROB", SqlDbType.Int)
        args(0).Value = ID_TIPO_COMPROB

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaCCF_ENCA_TRANS

        Try
            Do While dr.Read()
                Dim mEntidad As New CCF_ENCA_TRANS
                dbAsignarEntidades.AsignarCCF_ENCA_TRANS(dr, mEntidad)
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
    ''' <param name="ID_PROVEE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	30/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorPROVEEDOR_AGRICOLA(ByVal ID_PROVEE As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaCCF_ENCA_TRANS

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New CCF_ENCA_TRANS))
        strSQL.Append(" WHERE ID_PROVEE = @ID_PROVEE ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_PROVEE", SqlDbType.Int)
        args(0).Value = ID_PROVEE

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaCCF_ENCA_TRANS

        Try
            Do While dr.Read()
                Dim mEntidad As New CCF_ENCA_TRANS
                dbAsignarEntidades.AsignarCCF_ENCA_TRANS(dr, mEntidad)
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
