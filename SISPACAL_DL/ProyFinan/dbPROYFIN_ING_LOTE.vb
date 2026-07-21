Imports System.Text
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_DL
''' Class	 : DL.dbPROYFIN_ING_LOTE
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Acceso a Datos que contiene las operaciones CRUD(Create, Read,
''' Update y Delete) de la tabla PROYFIN_ING_LOTE
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	23/01/2020	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class dbPROYFIN_ING_LOTE
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
    ''' 	[GenApp]	23/01/2020	Created
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
    ''' 	[GenApp]	23/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overloads Function Actualizar(ByVal aEntidad As entidadBase, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer

        Dim lEntidad As PROYFIN_ING_LOTE
        lEntidad = CType(aEntidad, PROYFIN_ING_LOTE)

        Dim lID As Int32
        If lEntidad.ID_PROYFIN_ING_LOTE =  0 _
            Or lEntidad.ID_PROYFIN_ING_LOTE = Nothing Then 

            lID = CType(Me.ObtenerID(lEntidad), Int32)

            If lID = -1 Then Return -1

            lEntidad.ID_PROYFIN_ING_LOTE = lID

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
    ''' 	[GenApp]	23/01/2020	Created
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
    ''' Función que Elimina un Registro de la Tabla PROYFIN_ING_LOTE que se le envía como parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde viene se obtienen los valores de la llave 
    ''' primaria del registro a eliminar.</param>
    ''' <remarks>Por defecto manda a ejecutar eliminación con concurrencia pesimistica.
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer
        Return Me.Eliminar(aEntidad, TipoConcurrencia.Pesimistica)
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla PROYFIN_ING_LOTE que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde viene se obtienen los valores de la llave 
    ''' primaria del registro a eliminar.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el 
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/01/2020	Created
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
    ''' 	[GenApp]	23/01/2020	Created
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
                dbAsignarEntidades.AsignarPROYFIN_ING_LOTE(dr, CType(aEntidad,PROYFIN_ING_LOTE))
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
    ''' 	[GenApp]	23/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function RecuperarConForaneas(ByVal aEntidad As PROYFIN_ING_LOTE, Optional ByVal aPROYFIN_ING As Boolean = False, Optional ByVal aLOTES As Boolean = False) As Integer

        Dim strSQL As New StringBuilder
        Dim args(0) As SqlParameter

        If aPROYFIN_ING Or aLOTES Then
            Dim numTabla As Integer = 0
            Dim strCampos, strWhere As String
            strCampos = ""
            strWhere = ""
            Me.QuerySelectCampos(aEntidad, args, GetType(PROYFIN_ING_LOTE), GetType(SqlParameter), strCampos, strWhere, 0, "PROYFIN_ING_LOTE")
            strSQL.AppendLine("SELECT " + strCampos)
            If aPROYFIN_ING Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New PROYFIN_ING, Nothing, GetType(PROYFIN_ING), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aLOTES Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New LOTES, Nothing, GetType(LOTES), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            strSQL.AppendLine("FROM PROYFIN_ING_LOTE")
            numTabla = 0
            If aPROYFIN_ING Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN PROYFIN_ING T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_PROYFIN_ING = PROYFIN_ING_LOTE.ID_PROYFIN_ING")
            End If
            If aLOTES Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN LOTES T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ACCESLOTE = PROYFIN_ING_LOTE.ACCESLOTE")
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
                dbAsignarEntidades.AsignarPROYFIN_ING_LOTE(dr, aEntidad)
                Dim numTabla As Integer = 0
                If aPROYFIN_ING Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarPROYFIN_ING(dr, aEntidad.fkID_PROYFIN_ING, "T" + numTabla.ToString())
                End If
                If aLOTES Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarLOTES(dr, aEntidad.fkACCESLOTE, "T" + numTabla.ToString())
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
        strSQL.AppendLine("SELECT isnull(max(ID_PROYFIN_ING_LOTE),0) + 1 ")
        strSQL.AppendLine(" FROM PROYFIN_ING_LOTE ")

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
    ''' 	[GenApp]	23/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorID(ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaPROYFIN_ING_LOTE

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New PROYFIN_ING_LOTE))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New listaPROYFIN_ING_LOTE

        Try
            Do While dr.Read()
                Dim mEntidad As New PROYFIN_ING_LOTE
                dbAsignarEntidades.AsignarPROYFIN_ING_LOTE(dr, mEntidad)
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
    ''' 	[GenApp]	23/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetPorID(ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New PROYFIN_ING_LOTE))
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
    ''' 	[GenApp]	23/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetPorID(ByRef ds as DataSet, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As Integer

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New PROYFIN_ING_LOTE))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim tables(0) As String
        tables(0) = New String("PROYFIN_ING_LOTE".ToCharArray())

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
    ''' 	[GenApp]	23/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub SelectTabla(ByRef strSQL as StringBuilder)

        strSQL.AppendLine(" SELECT PROYFIN_ING_LOTE.ID_PROYFIN_ING_LOTE, ")
        strSQL.AppendLine(" PROYFIN_ING_LOTE.ID_PROYFIN_ING, ")
        strSQL.AppendLine(" PROYFIN_ING_LOTE.ACCESLOTE, ")
        strSQL.AppendLine(" PROYFIN_ING_LOTE.NO_CONTRATO, ")
        strSQL.AppendLine(" PROYFIN_ING_LOTE.CICLO, ")
        strSQL.AppendLine(" PROYFIN_ING_LOTE.CICLO1, ")
        strSQL.AppendLine(" PROYFIN_ING_LOTE.MZ1, ")
        strSQL.AppendLine(" PROYFIN_ING_LOTE.TC_MZ1, ")
        strSQL.AppendLine(" PROYFIN_ING_LOTE.TC1, ")
        strSQL.AppendLine(" PROYFIN_ING_LOTE.REND1, ")
        strSQL.AppendLine(" PROYFIN_ING_LOTE.LBS1, ")
        strSQL.AppendLine(" PROYFIN_ING_LOTE.CICLO2, ")
        strSQL.AppendLine(" PROYFIN_ING_LOTE.MZ2, ")
        strSQL.AppendLine(" PROYFIN_ING_LOTE.TC_MZ2, ")
        strSQL.AppendLine(" PROYFIN_ING_LOTE.TC2, ")
        strSQL.AppendLine(" PROYFIN_ING_LOTE.REND2, ")
        strSQL.AppendLine(" PROYFIN_ING_LOTE.LBS2, ")
        strSQL.AppendLine(" PROYFIN_ING_LOTE.CICLO3, ")
        strSQL.AppendLine(" PROYFIN_ING_LOTE.MZ3, ")
        strSQL.AppendLine(" PROYFIN_ING_LOTE.TC_MZ3, ")
        strSQL.AppendLine(" PROYFIN_ING_LOTE.TC3, ")
        strSQL.AppendLine(" PROYFIN_ING_LOTE.REND3, ")
        strSQL.AppendLine(" PROYFIN_ING_LOTE.LBS3, ")
        strSQL.AppendLine(" PROYFIN_ING_LOTE.CICLO4, ")
        strSQL.AppendLine(" PROYFIN_ING_LOTE.MZ4, ")
        strSQL.AppendLine(" PROYFIN_ING_LOTE.TC_MZ4, ")
        strSQL.AppendLine(" PROYFIN_ING_LOTE.TC4, ")
        strSQL.AppendLine(" PROYFIN_ING_LOTE.REND4, ")
        strSQL.AppendLine(" PROYFIN_ING_LOTE.LBS4, ")
        strSQL.AppendLine(" PROYFIN_ING_LOTE.CICLO5, ")
        strSQL.AppendLine(" PROYFIN_ING_LOTE.MZ5, ")
        strSQL.AppendLine(" PROYFIN_ING_LOTE.TC_MZ5, ")
        strSQL.AppendLine(" PROYFIN_ING_LOTE.TC5, ")
        strSQL.AppendLine(" PROYFIN_ING_LOTE.REND5, ")
        strSQL.AppendLine(" PROYFIN_ING_LOTE.LBS5, ")
        strSQL.AppendLine(" PROYFIN_ING_LOTE.CICLO6, ")
        strSQL.AppendLine(" PROYFIN_ING_LOTE.MZ6, ")
        strSQL.AppendLine(" PROYFIN_ING_LOTE.TC_MZ6, ")
        strSQL.AppendLine(" PROYFIN_ING_LOTE.TC6, ")
        strSQL.AppendLine(" PROYFIN_ING_LOTE.REND6, ")
        strSQL.AppendLine(" PROYFIN_ING_LOTE.LBS6, ")
        strSQL.AppendLine(" PROYFIN_ING_LOTE.CICLO7, ")
        strSQL.AppendLine(" PROYFIN_ING_LOTE.MZ7, ")
        strSQL.AppendLine(" PROYFIN_ING_LOTE.TC_MZ7, ")
        strSQL.AppendLine(" PROYFIN_ING_LOTE.TC7, ")
        strSQL.AppendLine(" PROYFIN_ING_LOTE.REND7, ")
        strSQL.AppendLine(" PROYFIN_ING_LOTE.LBS7 ")
        strSQL.AppendLine(" FROM PROYFIN_ING_LOTE ")

    End Sub

#Region "Obtener Listas Por Foraneas"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Foranea, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="ID_PROYFIN_ING"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorPROYFIN_ING(ByVal ID_PROYFIN_ING As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaPROYFIN_ING_LOTE

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New PROYFIN_ING_LOTE))
        strSQL.Append(" WHERE ID_PROYFIN_ING = @ID_PROYFIN_ING ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_PROYFIN_ING", SqlDbType.Int)
        args(0).Value = ID_PROYFIN_ING

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaPROYFIN_ING_LOTE

        Try
            Do While dr.Read()
                Dim mEntidad As New PROYFIN_ING_LOTE
                dbAsignarEntidades.AsignarPROYFIN_ING_LOTE(dr, mEntidad)
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
    ''' 	[GenApp]	23/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorLOTES(ByVal ACCESLOTE As String, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaPROYFIN_ING_LOTE

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New PROYFIN_ING_LOTE))
        strSQL.Append(" WHERE ACCESLOTE = @ACCESLOTE ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ACCESLOTE", SqlDbType.VarChar)
        args(0).Value = ACCESLOTE

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaPROYFIN_ING_LOTE

        Try
            Do While dr.Read()
                Dim mEntidad As New PROYFIN_ING_LOTE
                dbAsignarEntidades.AsignarPROYFIN_ING_LOTE(dr, mEntidad)
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
