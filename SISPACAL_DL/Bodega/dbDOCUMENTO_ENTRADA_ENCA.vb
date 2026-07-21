Imports System.Text
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_DL
''' Class	 : DL.dbDOCUMENTO_ENTRADA_ENCA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Acceso a Datos que contiene las operaciones CRUD(Create, Read,
''' Update y Delete) de la tabla DOCUMENTO_ENTRADA_ENCA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	14/06/2018	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class dbDOCUMENTO_ENTRADA_ENCA
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
    ''' 	[GenApp]	14/06/2018	Created
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
    ''' 	[GenApp]	14/06/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overloads Function Actualizar(ByVal aEntidad As entidadBase, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer

        Dim lEntidad As DOCUMENTO_ENTRADA_ENCA
        lEntidad = CType(aEntidad, DOCUMENTO_ENTRADA_ENCA)

        Dim lID As Int32
        If lEntidad.ID_DOCENTRA_ENCA =  0 _
            Or lEntidad.ID_DOCENTRA_ENCA = Nothing Then 

            lID = CType(Me.ObtenerID(lEntidad), Int32)

            If lID = -1 Then Return -1

            lEntidad.ID_DOCENTRA_ENCA = lID

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
    ''' 	[GenApp]	14/06/2018	Created
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
    ''' Función que Elimina un Registro de la Tabla DOCUMENTO_ENTRADA_ENCA que se le envía como parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde viene se obtienen los valores de la llave 
    ''' primaria del registro a eliminar.</param>
    ''' <remarks>Por defecto manda a ejecutar eliminación con concurrencia pesimistica.
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	14/06/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer
        Return Me.Eliminar(aEntidad, TipoConcurrencia.Pesimistica)
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla DOCUMENTO_ENTRADA_ENCA que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde viene se obtienen los valores de la llave 
    ''' primaria del registro a eliminar.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el 
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	14/06/2018	Created
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
    ''' 	[GenApp]	14/06/2018	Created
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
                dbAsignarEntidades.AsignarDOCUMENTO_ENTRADA_ENCA(dr, CType(aEntidad,DOCUMENTO_ENTRADA_ENCA))
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
    ''' 	[GenApp]	14/06/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function RecuperarConForaneas(ByVal aEntidad As DOCUMENTO_ENTRADA_ENCA, Optional ByVal aBODEGA As Boolean = False, Optional ByVal aTIPO_MOVTO As Boolean = False, Optional ByVal aPROVEEDOR_AGRICOLA As Boolean = False, Optional ByVal aORDEN_COMPRA_AGRI As Boolean = False, Optional ByVal aTIPO_COMPROB As Boolean = False, Optional ByVal aDOCUMENTO_SALIDA_ENCA As Boolean = False, Optional ByVal aZAFRA As Boolean = False) As Integer

        Dim strSQL As New StringBuilder
        Dim args(0) As SqlParameter

        If aBODEGA Or aTIPO_MOVTO Or aPROVEEDOR_AGRICOLA Or aORDEN_COMPRA_AGRI Or aTIPO_COMPROB Or aDOCUMENTO_SALIDA_ENCA Or aZAFRA Then
            Dim numTabla As Integer = 0
            Dim strCampos, strWhere As String
            strCampos = ""
            strWhere = ""
            Me.QuerySelectCampos(aEntidad, args, GetType(DOCUMENTO_ENTRADA_ENCA), GetType(SqlParameter), strCampos, strWhere, 0, "DOCUMENTO_ENTRADA_ENCA")
            strSQL.AppendLine("SELECT " + strCampos)
            If aBODEGA Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New BODEGA, Nothing, GetType(BODEGA), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aTIPO_MOVTO Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New TIPO_MOVTO, Nothing, GetType(TIPO_MOVTO), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aPROVEEDOR_AGRICOLA Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New PROVEEDOR_AGRICOLA, Nothing, GetType(PROVEEDOR_AGRICOLA), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aORDEN_COMPRA_AGRI Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New ORDEN_COMPRA_AGRI, Nothing, GetType(ORDEN_COMPRA_AGRI), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aTIPO_COMPROB Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New TIPO_COMPROB, Nothing, GetType(TIPO_COMPROB), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aDOCUMENTO_SALIDA_ENCA Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New DOCUMENTO_SALIDA_ENCA, Nothing, GetType(DOCUMENTO_SALIDA_ENCA), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aZAFRA Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New ZAFRA, Nothing, GetType(ZAFRA), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            strSQL.AppendLine("FROM DOCUMENTO_ENTRADA_ENCA")
            numTabla = 0
            If aBODEGA Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN BODEGA T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_BODEGA = DOCUMENTO_ENTRADA_ENCA.ID_BODEGA")
            End If
            If aTIPO_MOVTO Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN TIPO_MOVTO T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_TIPO_MOVTO = DOCUMENTO_ENTRADA_ENCA.ID_TIPO_MOVTO")
            End If
            If aPROVEEDOR_AGRICOLA Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN PROVEEDOR_AGRICOLA T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_PROVEE = DOCUMENTO_ENTRADA_ENCA.ID_PROVEE")
            End If
            If aORDEN_COMPRA_AGRI Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN ORDEN_COMPRA_AGRI T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_ORDEN = DOCUMENTO_ENTRADA_ENCA.ID_ORDEN")
            End If
            If aTIPO_COMPROB Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN TIPO_COMPROB T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_TIPO_COMPROB = DOCUMENTO_ENTRADA_ENCA.ID_TIPO_COMPROB")
            End If
            If aDOCUMENTO_SALIDA_ENCA Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN DOCUMENTO_SALIDA_ENCA T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_DOCSAL_ENCA = DOCUMENTO_ENTRADA_ENCA.ID_DOCSAL_ENCA")
            End If
            If aZAFRA Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN ZAFRA T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_ZAFRA = DOCUMENTO_ENTRADA_ENCA.ID_ZAFRA")
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
                dbAsignarEntidades.AsignarDOCUMENTO_ENTRADA_ENCA(dr, aEntidad)
                Dim numTabla As Integer = 0
                If aBODEGA Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarBODEGA(dr, aEntidad.fkID_BODEGA, "T" + numTabla.ToString())
                End If
                If aTIPO_MOVTO Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarTIPO_MOVTO(dr, aEntidad.fkID_TIPO_MOVTO, "T" + numTabla.ToString())
                End If
                If aPROVEEDOR_AGRICOLA Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarPROVEEDOR_AGRICOLA(dr, aEntidad.fkID_PROVEE, "T" + numTabla.ToString())
                End If
                If aORDEN_COMPRA_AGRI Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarORDEN_COMPRA_AGRI(dr, aEntidad.fkID_ORDEN, "T" + numTabla.ToString())
                End If
                If aTIPO_COMPROB Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarTIPO_COMPROB(dr, aEntidad.fkID_TIPO_COMPROB, "T" + numTabla.ToString())
                End If
                If aDOCUMENTO_SALIDA_ENCA Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarDOCUMENTO_SALIDA_ENCA(dr, aEntidad.fkID_DOCSAL_ENCA, "T" + numTabla.ToString())
                End If
                If aZAFRA Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarZAFRA(dr, aEntidad.fkID_ZAFRA, "T" + numTabla.ToString())
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
        strSQL.AppendLine("SELECT isnull(max(ID_DOCENTRA_ENCA),0) + 1 ")
        strSQL.AppendLine(" FROM DOCUMENTO_ENTRADA_ENCA ")

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
    ''' 	[GenApp]	14/06/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorID(ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaDOCUMENTO_ENTRADA_ENCA

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New DOCUMENTO_ENTRADA_ENCA))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New listaDOCUMENTO_ENTRADA_ENCA

        Try
            Do While dr.Read()
                Dim mEntidad As New DOCUMENTO_ENTRADA_ENCA
                dbAsignarEntidades.AsignarDOCUMENTO_ENTRADA_ENCA(dr, mEntidad)
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
    ''' 	[GenApp]	14/06/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetPorID(ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New DOCUMENTO_ENTRADA_ENCA))
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
    ''' 	[GenApp]	14/06/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetPorID(ByRef ds as DataSet, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As Integer

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New DOCUMENTO_ENTRADA_ENCA))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim tables(0) As String
        tables(0) = New String("DOCUMENTO_ENTRADA_ENCA".ToCharArray())

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
    ''' 	[GenApp]	14/06/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub SelectTabla(ByRef strSQL as StringBuilder)

        strSQL.AppendLine(" SELECT DOCUMENTO_ENTRADA_ENCA.ID_DOCENTRA_ENCA, ")
        strSQL.AppendLine(" DOCUMENTO_ENTRADA_ENCA.ID_BODEGA, ")
        strSQL.AppendLine(" DOCUMENTO_ENTRADA_ENCA.NO_DOCUMENTO, ")
        strSQL.AppendLine(" DOCUMENTO_ENTRADA_ENCA.FEC_DOCTO, ")
        strSQL.AppendLine(" DOCUMENTO_ENTRADA_ENCA.ID_TIPO_MOVTO, ")
        strSQL.AppendLine(" DOCUMENTO_ENTRADA_ENCA.UID_DOCUMENTO, ")
        strSQL.AppendLine(" DOCUMENTO_ENTRADA_ENCA.TOTAL, ")
        strSQL.AppendLine(" DOCUMENTO_ENTRADA_ENCA.ID_PROVEE, ")
        strSQL.AppendLine(" DOCUMENTO_ENTRADA_ENCA.FORMA_ENTREGA, ")
        strSQL.AppendLine(" DOCUMENTO_ENTRADA_ENCA.ID_ORDEN, ")
        strSQL.AppendLine(" DOCUMENTO_ENTRADA_ENCA.NO_COMPROB, ")
        strSQL.AppendLine(" DOCUMENTO_ENTRADA_ENCA.ID_TIPO_COMPROB, ")
        strSQL.AppendLine(" DOCUMENTO_ENTRADA_ENCA.FECHA_COMPROB, ")
        strSQL.AppendLine(" DOCUMENTO_ENTRADA_ENCA.OBSERVACIONES, ")
        strSQL.AppendLine(" DOCUMENTO_ENTRADA_ENCA.USUARIO_CREA, ")
        strSQL.AppendLine(" DOCUMENTO_ENTRADA_ENCA.FECHA_CREA, ")
        strSQL.AppendLine(" DOCUMENTO_ENTRADA_ENCA.USUARIO_ACT, ")
        strSQL.AppendLine(" DOCUMENTO_ENTRADA_ENCA.FECHA_ACT, ")
        strSQL.AppendLine(" DOCUMENTO_ENTRADA_ENCA.ID_DOCSAL_ENCA, ")
        strSQL.AppendLine(" DOCUMENTO_ENTRADA_ENCA.ID_ZAFRA ")
        strSQL.AppendLine(" FROM DOCUMENTO_ENTRADA_ENCA ")

    End Sub

#Region "Obtener Listas Por Foraneas"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Foranea, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="ID_BODEGA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	14/06/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorBODEGA(ByVal ID_BODEGA As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaDOCUMENTO_ENTRADA_ENCA

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New DOCUMENTO_ENTRADA_ENCA))
        strSQL.Append(" WHERE ID_BODEGA = @ID_BODEGA ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_BODEGA", SqlDbType.Int)
        args(0).Value = ID_BODEGA

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaDOCUMENTO_ENTRADA_ENCA

        Try
            Do While dr.Read()
                Dim mEntidad As New DOCUMENTO_ENTRADA_ENCA
                dbAsignarEntidades.AsignarDOCUMENTO_ENTRADA_ENCA(dr, mEntidad)
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
    ''' <param name="ID_TIPO_MOVTO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	14/06/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorTIPO_MOVTO(ByVal ID_TIPO_MOVTO As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaDOCUMENTO_ENTRADA_ENCA

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New DOCUMENTO_ENTRADA_ENCA))
        strSQL.Append(" WHERE ID_TIPO_MOVTO = @ID_TIPO_MOVTO ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_TIPO_MOVTO", SqlDbType.Int)
        args(0).Value = ID_TIPO_MOVTO

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaDOCUMENTO_ENTRADA_ENCA

        Try
            Do While dr.Read()
                Dim mEntidad As New DOCUMENTO_ENTRADA_ENCA
                dbAsignarEntidades.AsignarDOCUMENTO_ENTRADA_ENCA(dr, mEntidad)
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
    ''' 	[GenApp]	14/06/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorPROVEEDOR_AGRICOLA(ByVal ID_PROVEE As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaDOCUMENTO_ENTRADA_ENCA

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New DOCUMENTO_ENTRADA_ENCA))
        strSQL.Append(" WHERE ID_PROVEE = @ID_PROVEE ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_PROVEE", SqlDbType.Int)
        args(0).Value = ID_PROVEE

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaDOCUMENTO_ENTRADA_ENCA

        Try
            Do While dr.Read()
                Dim mEntidad As New DOCUMENTO_ENTRADA_ENCA
                dbAsignarEntidades.AsignarDOCUMENTO_ENTRADA_ENCA(dr, mEntidad)
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
    ''' <param name="ID_ORDEN"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	14/06/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorORDEN_COMPRA_AGRI(ByVal ID_ORDEN As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaDOCUMENTO_ENTRADA_ENCA

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New DOCUMENTO_ENTRADA_ENCA))
        strSQL.Append(" WHERE ID_ORDEN = @ID_ORDEN ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_ORDEN", SqlDbType.Int)
        args(0).Value = ID_ORDEN

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaDOCUMENTO_ENTRADA_ENCA

        Try
            Do While dr.Read()
                Dim mEntidad As New DOCUMENTO_ENTRADA_ENCA
                dbAsignarEntidades.AsignarDOCUMENTO_ENTRADA_ENCA(dr, mEntidad)
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
    ''' 	[GenApp]	14/06/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorTIPO_COMPROB(ByVal ID_TIPO_COMPROB As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaDOCUMENTO_ENTRADA_ENCA

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New DOCUMENTO_ENTRADA_ENCA))
        strSQL.Append(" WHERE ID_TIPO_COMPROB = @ID_TIPO_COMPROB ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_TIPO_COMPROB", SqlDbType.Int)
        args(0).Value = ID_TIPO_COMPROB

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaDOCUMENTO_ENTRADA_ENCA

        Try
            Do While dr.Read()
                Dim mEntidad As New DOCUMENTO_ENTRADA_ENCA
                dbAsignarEntidades.AsignarDOCUMENTO_ENTRADA_ENCA(dr, mEntidad)
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
    ''' <param name="ID_DOCSAL_ENCA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	14/06/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorDOCUMENTO_SALIDA_ENCA(ByVal ID_DOCSAL_ENCA As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaDOCUMENTO_ENTRADA_ENCA

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New DOCUMENTO_ENTRADA_ENCA))
        strSQL.Append(" WHERE ID_DOCSAL_ENCA = @ID_DOCSAL_ENCA ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_DOCSAL_ENCA", SqlDbType.Int)
        args(0).Value = ID_DOCSAL_ENCA

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaDOCUMENTO_ENTRADA_ENCA

        Try
            Do While dr.Read()
                Dim mEntidad As New DOCUMENTO_ENTRADA_ENCA
                dbAsignarEntidades.AsignarDOCUMENTO_ENTRADA_ENCA(dr, mEntidad)
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
    ''' 	[GenApp]	14/06/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorZAFRA(ByVal ID_ZAFRA As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaDOCUMENTO_ENTRADA_ENCA

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New DOCUMENTO_ENTRADA_ENCA))
        strSQL.Append(" WHERE ID_ZAFRA = @ID_ZAFRA ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_ZAFRA", SqlDbType.Int)
        args(0).Value = ID_ZAFRA

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaDOCUMENTO_ENTRADA_ENCA

        Try
            Do While dr.Read()
                Dim mEntidad As New DOCUMENTO_ENTRADA_ENCA
                dbAsignarEntidades.AsignarDOCUMENTO_ENTRADA_ENCA(dr, mEntidad)
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
