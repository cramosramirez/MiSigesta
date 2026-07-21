Imports System.Text
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_DL
''' Class	 : DL.dbREQENCA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Acceso a Datos que contiene las operaciones CRUD(Create, Read,
''' Update y Delete) de la tabla REQENCA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	10/06/2015	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class dbREQENCA
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
    ''' 	[GenApp]	10/06/2015	Created
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
    ''' 	[GenApp]	10/06/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overloads Function Actualizar(ByVal aEntidad As entidadBase, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer

        Dim lEntidad As REQENCA
        lEntidad = CType(aEntidad, REQENCA)

        Dim lID As Int32
        If lEntidad.ID_REQENCA =  0 _
            Or lEntidad.ID_REQENCA = Nothing Then 

            lID = CType(Me.ObtenerID(lEntidad), Int32)

            If lID = -1 Then Return -1

            lEntidad.ID_REQENCA = lID

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
    ''' 	[GenApp]	10/06/2015	Created
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
    ''' Función que Elimina un Registro de la Tabla REQENCA que se le envía como parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde viene se obtienen los valores de la llave 
    ''' primaria del registro a eliminar.</param>
    ''' <remarks>Por defecto manda a ejecutar eliminación con concurrencia pesimistica.
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/06/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer
        Return Me.Eliminar(aEntidad, TipoConcurrencia.Pesimistica)
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla REQENCA que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde viene se obtienen los valores de la llave 
    ''' primaria del registro a eliminar.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el 
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/06/2015	Created
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
    ''' 	[GenApp]	10/06/2015	Created
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
                dbAsignarEntidades.AsignarREQENCA(dr, CType(aEntidad,REQENCA))
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
    ''' 	[GenApp]	10/06/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function RecuperarConForaneas(ByVal aEntidad As REQENCA, Optional ByVal aPERIODOREQ As Boolean = False, Optional ByVal aSECCION As Boolean = False, Optional ByVal aSOLICITANTE As Boolean = False, Optional ByVal aREQETAPA As Boolean = False) As Integer

        Dim strSQL As New StringBuilder
        Dim args(0) As SqlParameter

        If aPERIODOREQ Or aSECCION Or aSOLICITANTE Or aREQETAPA Then
            Dim numTabla As Integer = 0
            Dim strCampos, strWhere As String
            strCampos = ""
            strWhere = ""
            Me.QuerySelectCampos(aEntidad, args, GetType(REQENCA), GetType(SqlParameter), strCampos, strWhere, 0, "REQENCA")
            strSQL.AppendLine("SELECT " + strCampos)
            If aPERIODOREQ Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New PERIODOREQ, Nothing, GetType(PERIODOREQ), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aSECCION Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New SECCION, Nothing, GetType(SECCION), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aSOLICITANTE Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New SOLICITANTE, Nothing, GetType(SOLICITANTE), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aREQETAPA Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New REQETAPA, Nothing, GetType(REQETAPA), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            strSQL.AppendLine("FROM REQENCA")
            numTabla = 0
            If aPERIODOREQ Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN PERIODOREQ T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_PERIODOREQ = REQENCA.ID_PERIODOREQ")
            End If
            If aSECCION Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN SECCION T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_SECCION = REQENCA.ID_SECCION")
            End If
            If aSOLICITANTE Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN SOLICITANTE T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_SOLICITANTE = REQENCA.ID_SOLICITANTE")
            End If
            If aREQETAPA Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN REQETAPA T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_REQETAPA = REQENCA.ID_REQETAPA")
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
                dbAsignarEntidades.AsignarREQENCA(dr, aEntidad)
                Dim numTabla As Integer = 0
                If aPERIODOREQ Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarPERIODOREQ(dr, aEntidad.fkID_PERIODOREQ, "T" + numTabla.ToString())
                End If
                If aSECCION Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarSECCION(dr, aEntidad.fkID_SECCION, "T" + numTabla.ToString())
                End If
                If aSOLICITANTE Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarSOLICITANTE(dr, aEntidad.fkID_SOLICITANTE, "T" + numTabla.ToString())
                End If
                If aREQETAPA Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarREQETAPA(dr, aEntidad.fkID_REQETAPA, "T" + numTabla.ToString())
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
        strSQL.AppendLine("SELECT isnull(max(ID_REQENCA),0) + 1 ")
        strSQL.AppendLine(" FROM REQENCA ")

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
    ''' 	[GenApp]	10/06/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorID(ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaREQENCA

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New REQENCA))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New listaREQENCA

        Try
            Do While dr.Read()
                Dim mEntidad As New REQENCA
                dbAsignarEntidades.AsignarREQENCA(dr, mEntidad)
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
    ''' 	[GenApp]	10/06/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetPorID(ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New REQENCA))
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
    ''' 	[GenApp]	10/06/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetPorID(ByRef ds as DataSet, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As Integer

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New REQENCA))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim tables(0) As String
        tables(0) = New String("REQENCA".ToCharArray())

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
    ''' 	[GenApp]	10/06/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub SelectTabla(ByRef strSQL as StringBuilder)

        strSQL.AppendLine(" SELECT REQENCA.ID_REQENCA, ")
        strSQL.AppendLine(" REQENCA.ID_PERIODOREQ, ")
        strSQL.AppendLine(" REQENCA.ID_SECCION, ")
        strSQL.AppendLine(" REQENCA.ID_SOLICITANTE, ")
        strSQL.AppendLine(" REQENCA.NO_REQ, ")
        strSQL.AppendLine(" REQENCA.FECHA_EMISION, ")
        strSQL.AppendLine(" REQENCA.NO_REQ_PH, ")
        strSQL.AppendLine(" REQENCA.FECHA_REQ_PH, ")
        strSQL.AppendLine(" REQENCA.NO_ORDEN_PH, ")
        strSQL.AppendLine(" REQENCA.FECHA_ORDEN_PH, ")
        strSQL.AppendLine(" REQENCA.TOTAL_ORDEN_PH, ")
        strSQL.AppendLine(" REQENCA.AFECTO_ORDEN_PH, ")
        strSQL.AppendLine(" REQENCA.IVA_ORDEN_PH, ")
        strSQL.AppendLine(" REQENCA.NO_INGRESO_ALM, ")
        strSQL.AppendLine(" REQENCA.FECHA_INGRESO_ALM, ")
        strSQL.AppendLine(" REQENCA.NO_QUEDAN, ")
        strSQL.AppendLine(" REQENCA.FECHA_QUEDAN, ")
        strSQL.AppendLine(" REQENCA.USO, ")
        strSQL.AppendLine(" REQENCA.USUARIO_APROB, ")
        strSQL.AppendLine(" REQENCA.FECHA_APROB, ")
        strSQL.AppendLine(" REQENCA.USUARIO_NOAPROB, ")
        strSQL.AppendLine(" REQENCA.FECHA_NOAPROB, ")
        strSQL.AppendLine(" REQENCA.USUARIO_ANUL, ")
        strSQL.AppendLine(" REQENCA.FECHA_ANUL, ")
        strSQL.AppendLine(" REQENCA.USUARIO_CREA, ")
        strSQL.AppendLine(" REQENCA.FECHA_CREA, ")
        strSQL.AppendLine(" REQENCA.USUARIO_ACT, ")
        strSQL.AppendLine(" REQENCA.FECHA_ACT, ")
        strSQL.AppendLine(" REQENCA.CODI_REQ, ")
        strSQL.AppendLine(" REQENCA.ORDEN_LOCAL, ")
        strSQL.AppendLine(" REQENCA.FECHA_INGRESO_EST, ")
        strSQL.AppendLine(" REQENCA.COMENTARIO_EST, ")
        strSQL.AppendLine(" REQENCA.TOTAL_INGRESO_ALM, ")
        strSQL.AppendLine(" REQENCA.AFECTO_INGRESO_ALM, ")
        strSQL.AppendLine(" REQENCA.IVA_INGRESO_ALM, ")
        strSQL.AppendLine(" REQENCA.TOTAL_QUEDAN, ")
        strSQL.AppendLine(" REQENCA.AFECTO_QUEDAN, ")
        strSQL.AppendLine(" REQENCA.IVA_QUEDAN, ")
        strSQL.AppendLine(" REQENCA.SECCION, ")
        strSQL.AppendLine(" REQENCA.EQUIPO, ")
        strSQL.AppendLine(" REQENCA.PROPOSITO, ")
        strSQL.AppendLine(" REQENCA.COMPRA_LOCAL, ")
        strSQL.AppendLine(" REQENCA.FECHA_MAX_SUMIN, ")
        strSQL.AppendLine(" REQENCA.FECHA_RECIBOREQ, ")
        strSQL.AppendLine(" REQENCA.PROVEE_INVITADOS, ")
        strSQL.AppendLine(" REQENCA.PROVEE_ADJUDICADO_ORDEN, ")
        strSQL.AppendLine(" REQENCA.FECHA_ESTI_INGRESO_ORDEN, ")
        strSQL.AppendLine(" REQENCA.TIPO_DOCCOMPRA_ALM, ")
        strSQL.AppendLine(" REQENCA.NO_DOCCOMPRA_ALM, ")
        strSQL.AppendLine(" REQENCA.NO_CHEQUE_CHQ, ")
        strSQL.AppendLine(" REQENCA.BANCO_CHQ, ")
        strSQL.AppendLine(" REQENCA.FECHA_CHQ, ")
        strSQL.AppendLine(" REQENCA.MONTO_CHQ, ")
        strSQL.AppendLine(" REQENCA.ID_REQETAPA ")
        strSQL.AppendLine(" FROM REQENCA ")

    End Sub

#Region "Obtener Listas Por Foraneas"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Foranea, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="ID_PERIODOREQ"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/06/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorPERIODOREQ(ByVal ID_PERIODOREQ As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaREQENCA

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New REQENCA))
        strSQL.Append(" WHERE ID_PERIODOREQ = @ID_PERIODOREQ ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_PERIODOREQ", SqlDbType.Int)
        args(0).Value = ID_PERIODOREQ

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaREQENCA

        Try
            Do While dr.Read()
                Dim mEntidad As New REQENCA
                dbAsignarEntidades.AsignarREQENCA(dr, mEntidad)
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
    ''' <param name="ID_SECCION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/06/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorSECCION(ByVal ID_SECCION As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaREQENCA

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New REQENCA))
        strSQL.Append(" WHERE ID_SECCION = @ID_SECCION ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_SECCION", SqlDbType.Int)
        args(0).Value = ID_SECCION

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaREQENCA

        Try
            Do While dr.Read()
                Dim mEntidad As New REQENCA
                dbAsignarEntidades.AsignarREQENCA(dr, mEntidad)
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
    ''' <param name="ID_SOLICITANTE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/06/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorSOLICITANTE(ByVal ID_SOLICITANTE As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaREQENCA

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New REQENCA))
        strSQL.Append(" WHERE ID_SOLICITANTE = @ID_SOLICITANTE ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_SOLICITANTE", SqlDbType.Int)
        args(0).Value = ID_SOLICITANTE

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaREQENCA

        Try
            Do While dr.Read()
                Dim mEntidad As New REQENCA
                dbAsignarEntidades.AsignarREQENCA(dr, mEntidad)
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
    ''' <param name="ID_REQETAPA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/06/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorREQETAPA(ByVal ID_REQETAPA As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaREQENCA

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New REQENCA))
        strSQL.Append(" WHERE ID_REQETAPA = @ID_REQETAPA ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_REQETAPA", SqlDbType.Int)
        args(0).Value = ID_REQETAPA

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaREQENCA

        Try
            Do While dr.Read()
                Dim mEntidad As New REQENCA
                dbAsignarEntidades.AsignarREQENCA(dr, mEntidad)
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
