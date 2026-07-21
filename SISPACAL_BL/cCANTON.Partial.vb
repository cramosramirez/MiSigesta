Partial Public Class cCANTON

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Ingresa un registro que recibe como parámetro.
    ''' </summary>
    ''' <remarks>Se reciben los parametros uno a uno para la entidad 
    ''' y son asignados a una entidad y se ejecuta el Metodo Actualizar
    ''' o Agregar mandando la entidad de parametro.</remarks>
    ''' <history>
    ''' 	[GenApp]	02/07/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarCANTON(ByVal CODI_CANTON As String, ByVal CODI_DEPTO As String, ByVal CODI_MUNI As String, ByVal NOMBRE_CANTON As String, ByVal KILOMETROS As Decimal, ByVal POSICION_GEO As String, ByVal COORDENADAS As String, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime, ByVal ZONA As String, ByVal SUB_ZONA As String) As Integer
        Try
            Dim lEntidad As New CANTON
            lEntidad.CODI_CANTON = CODI_CANTON
            lEntidad.CODI_DEPTO = CODI_DEPTO
            lEntidad.CODI_MUNI = CODI_MUNI
            lEntidad.NOMBRE_CANTON = NOMBRE_CANTON
            lEntidad.KILOMETROS = KILOMETROS
            lEntidad.POSICION_GEO = POSICION_GEO
            lEntidad.COORDENADAS = COORDENADAS
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            lEntidad.ZONA = ZONA
            lEntidad.SUB_ZONA = SUB_ZONA
            Return Me.AgregarCANTON(lEntidad)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Ingresa un registro de la Entidad que recibe como parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad que contiene los datos a Ingresar.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados al menos los
    ''' valores de la Llave Primaria, para su inserción.</remarks>
    ''' <history>
    ''' 	[GenApp]	02/07/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarCANTON(ByVal aEntidad As CANTON) As Integer
        Try
            Return mDb.Agregar(aEntidad)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Actualiza un registro de la Entidad que recibe de parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad que contiene los datos a Actualizar o Ingresar.</param>
    ''' <remarks>La entidad ya debe estar inicializada. Si es una tabla de Muchos a Muchos
    ''' este método unicamente actualiza el registro. Si no es una tabla de Muchos a Muchos
    ''' puede Actualizar o insertar un registro, dependiendo si la llave única trae un valor
    ''' de Cero(0) para ser autoincrementada por el método de la Clase de Acceso a Datos.</remarks>
    ''' <history>
    ''' 	[GenApp]	02/07/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarCANTON(ByVal aEntidad As CANTON) As Integer
        Try
            Return Me.ActualizarCANTON(aEntidad, TipoConcurrencia.Pesimistica)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Actualiza o Ingresa un registro de la Entidad que recibe de 
    ''' parámetro; en el caso de que sea actualizar toma en cuenta el Tipo de 
    ''' Concurrencia recibida de parametro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad que contiene los datos a Actualizar o Ingresar.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia del Registro a Actualizar</param>
    ''' <remarks>La entidad ya debe estar inicializada. Si es una tabla de Muchos a Muchos
    ''' este método unicamente actualiza el registro. Si no es una tabla de Muchos a Muchos
    ''' puede Actualizar o insertar un registro, dependiendo si la llave única trae un valor
    ''' de Cero(0) para ser autoincrementada por el método de la Clase de Acceso a Datos.</remarks>
    ''' <history>
    ''' 	[GenApp]	02/07/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarCANTON(ByVal aEntidad As CANTON, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            'Asignando la zona
            Dim lRet As Integer
            Dim bMaestroLotes As New cMAESTRO_LOTES
            Dim lSubZonas As listaSUB_ZONAS = (New cSUB_ZONAS).ObtenerLista

            If lSubZonas IsNot Nothing AndAlso lSubZonas.Count > 0 Then
                For i As Integer = 0 To lSubZonas.Count - 1
                    If lSubZonas(i).SUB_ZONA = aEntidad.SUB_ZONA Then
                        aEntidad.ZONA = lSubZonas(i).ZONA
                    End If
                Next
            End If
            lRet = mDb.Actualizar(aEntidad, aTipoConcurrencia)

            If lRet > 0 Then
                'Actualizar la zona y sub zona en el maestro de lotes de los lotes que pertencen al canton
                Dim lMaestroLotes As listaMAESTRO_LOTES = (New cMAESTRO_LOTES).ObtenerListaPorCANTON(aEntidad.CODI_CANTON, aEntidad.CODI_DEPTO, aEntidad.CODI_MUNI)
                If lMaestroLotes IsNot Nothing AndAlso lMaestroLotes.Count > 0 Then
                    For i As Integer = 0 To lMaestroLotes.Count - 1
                        lMaestroLotes(i).ZONA = aEntidad.ZONA
                        lMaestroLotes(i).SUB_ZONA = aEntidad.SUB_ZONA
                        lMaestroLotes(i).FECHA_ACT = cFechaHora.ObtenerFechaHora
                        lMaestroLotes(i).USUARIO_ACT = Utilerias.ObtenerUsuario
                        If bMaestroLotes.ActualizarMAESTRO_LOTES(lMaestroLotes(i)) < 0 Then
                            Me.sError = "Error al actualizar la zona y sub zona del maestro de lotes"
                            Return -2
                        End If
                    Next
                End If
            End If

            Return lRet
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Actualiza un registro que recibe de parámetro.
    ''' </summary>
    ''' <remarks>Si es una tabla de Muchos a Muchos este método unicamente actualiza el 
    ''' registro. Si no es una tabla de Muchos a Muchos puede Actualizar o insertar un 
    ''' registro, dependiendo si la llave única trae un valor de Cero(0) para ser 
    ''' autoincrementada por el método de la Clase de Acceso a Datos.</remarks>
    ''' <history>
    ''' 	[GenApp]	02/07/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarCANTON(ByVal CODI_CANTON As String, ByVal CODI_DEPTO As String, ByVal CODI_MUNI As String, ByVal NOMBRE_CANTON As String, ByVal KILOMETROS As Decimal, ByVal POSICION_GEO As String, ByVal COORDENADAS As String, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime, ByVal ZONA As String, ByVal SUB_ZONA As String) As Integer
        Try
            Dim lEntidad As New CANTON
            lEntidad.CODI_CANTON = CODI_CANTON
            lEntidad.CODI_DEPTO = CODI_DEPTO
            lEntidad.CODI_MUNI = CODI_MUNI
            lEntidad.NOMBRE_CANTON = NOMBRE_CANTON
            lEntidad.KILOMETROS = KILOMETROS
            lEntidad.POSICION_GEO = POSICION_GEO
            lEntidad.COORDENADAS = COORDENADAS
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            lEntidad.ZONA = ZONA
            lEntidad.SUB_ZONA = SUB_ZONA
            Return Me.ActualizarCANTON(lEntidad)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function Recuperar(ByVal CODI_DEPTO As String, ByVal CODI_MUNI As String, Optional agregarVacio As Boolean = False, Optional agregarTodos As Boolean = False, Optional conPresencia As Boolean = False) As listaCANTON
        Try
            Dim lCanton As CANTON
            Dim mListaCANTON As New listaCANTON
            If conPresencia Then
                mListaCANTON = mDb.ObtenerListaPorPresencia(CODI_DEPTO, CODI_MUNI, "NOMBRE_CANTON")
            Else
                mListaCANTON = mDb.ObtenerListaPorID(CODI_DEPTO, CODI_MUNI, "NOMBRE_CANTON")
            End If
            If agregarVacio Then
                lCanton = New CANTON
                lCanton.CODI_DEPTO = CODI_DEPTO
                lCanton.CODI_MUNI = CODI_MUNI
                lCanton.CODI_CANTON = ""
                lCanton.NOMBRE_CANTON = ""
                mListaCANTON.Insertar(0, lCanton)
            End If
            If agregarTodos Then
                lCanton = New CANTON
                lCanton.CODI_DEPTO = CODI_DEPTO
                lCanton.CODI_MUNI = CODI_MUNI
                lCanton.CODI_CANTON = ""
                lCanton.NOMBRE_CANTON = "[Todos]"
                mListaCANTON.Insertar(0, lCanton)
            End If
            Return mListaCANTON
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCriterios(ByVal CODI_DEPTO As String, ByVal CODI_MUNI As String, ByVal CODI_CANTON As String) As listaCANTON
        Try
            Dim mListaCANTON As New listaMAESTRO_LOTES
            Return mDb.ObtenerListaPorCriterios(CODI_DEPTO, CODI_MUNI, CODI_CANTON)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorZAFRA(ByVal ID_ZAFRA As Int32, ByVal CODI_DEPTO As String, CODI_MUNI As String) As listaCANTON
        Try
            Return mDb.ObtenerListaPorZAFRA(ID_ZAFRA, CODI_DEPTO, CODI_MUNI)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
