Partial Public Class cBASCULA
    ' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que recupera una lista de entidades ANALISIS filtrada por el Número de Boleta.
    ''' </summary>
    ''' <history>
    ''' 	[cramos]	02/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorBOLETA(ByVal pID_ZAFRA As Integer, ByVal pNROBOLETA As Integer) As listaBASCULA
        Try
            Return mDb.ObtenerListaPorBOLETA(pID_ZAFRA, pNROBOLETA)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que recupera las toneladas ingresadas de las que no se ha realizado corte
    ''' </summary>
    ''' <history>
    ''' 	[cramos]	24/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerToneladasSinCorte() As Decimal
        Try
            Return mDb.ObtenerToneladasSinCorte()

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return 0
        End Try
    End Function


    ''' -----------------------------------------------------------------------------
    Public Function ObtenerTONEL_ENTREGADA_AL_DIAZAFRA(ByVal ID_ZAFRA As Int32, ByVal DIAZAFRA As Int32) As Decimal
        Try
            Return mDb.ObtenerTONEL_ENTREGADA_AL_DIAZAFRA(ID_ZAFRA, DIAZAFRA)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return 0
        End Try
    End Function

    Public Function ObtenerTONEL_ENTREGADAPorZAFRA(ByVal ID_ZAFRA As Int32) As Decimal
        Try
            Return mDb.ObtenerTONEL_ENTREGADAPorZAFRA(ID_ZAFRA)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return 0
        End Try
    End Function

    Public Function ObtenerTOTAL_TONEL_ENTREGARPorZAFRA(ByVal ID_ZAFRA As Int32) As Decimal
        Try
            Return mDb.ObtenerTOTAL_TONEL_ENTREGARPorZAFRA(ID_ZAFRA)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return 0
        End Try
    End Function

    Public Function ObtenerTONEL_PROMEDIO_RANGO_DIAS_ZAFRA(ByVal ID_ZAFRA As Int32, ByVal ULTIMOS_NUMERO_DIAS As Int32) As Decimal
        Try
            Return mDb.ObtenerTONEL_PROMEDIO_RANGO_DIAS_ZAFRA(ID_ZAFRA, ULTIMOS_NUMERO_DIAS)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return 0
        End Try
    End Function

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
    ''' 	[GenApp]	11/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarBASCULA(ByVal aEntidad As BASCULA) As Integer
        Try
            Return Me.ActualizarBASCULA(aEntidad, TipoConcurrencia.Pesimistica)
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
    ''' 	[GenApp]	11/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarBASCULA(ByVal aEntidad As BASCULA, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Return mDb.Actualizar(aEntidad, aTipoConcurrencia)

        Catch ex As Exception
            Me.sError = ex.Message
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Actualiza o Ingresa un registro que recibe de parámetro.
    ''' </summary>
    ''' <remarks>Si es una tabla de Muchos a Muchos este método unicamente actualiza el 
    ''' registro. Si no es una tabla de Muchos a Muchos puede Actualizar o insertar un 
    ''' registro, dependiendo si la llave única trae un valor de Cero(0) para ser 
    ''' autoincrementada por el método de la Clase de Acceso a Datos.</remarks>
    ''' <history>
    ''' 	[GenApp]	11/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarBASCULA(ByVal ID_BASCULA As Int32, ByVal ID_ENVIO As Int32, ByVal BRUTO As Decimal, ByVal TARA As Decimal, ByVal NETOLIBRAS As Decimal, ByVal NETOTONEL As Decimal, ByVal USUARIO_LEE_BRUTO As String, ByVal FECHA_LEE_BRUTO As DateTime, ByVal USUARIO_LEE_TARA As String, ByVal FECHA_LEE_TARA As DateTime) As Integer
        Try
            Dim lEntidad As New BASCULA
            lEntidad.ID_BASCULA = ID_BASCULA
            lEntidad.ID_ENVIO = ID_ENVIO
            lEntidad.BRUTO = BRUTO
            lEntidad.TARA = TARA
            lEntidad.NETOLIBRAS = NETOLIBRAS
            lEntidad.NETOTONEL = NETOTONEL
            lEntidad.USUARIO_LEE_BRUTO = USUARIO_LEE_BRUTO
            lEntidad.FECHA_LEE_BRUTO = FECHA_LEE_BRUTO
            lEntidad.USUARIO_LEE_TARA = USUARIO_LEE_TARA
            lEntidad.FECHA_LEE_TARA = FECHA_LEE_TARA
            Return Me.ActualizarBASCULA(lEntidad)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function
End Class
