Partial Public Class cREQENCA

    Public Function ObtenerNoSolicitudPorPeriodo(ByVal ID_PERIODOREQ As Int32) As Int32
        Try
            Return mDb.ObtenerNoSolicitudPorPeriodo(ID_PERIODOREQ)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
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
    ''' 	[GenApp]	08/05/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarREQENCA(ByVal aEntidad As REQENCA) As Integer
        Try
            Return Me.ActualizarREQENCA(aEntidad, TipoConcurrencia.Pesimistica)
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
    ''' 	[GenApp]	08/05/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarREQENCA(ByVal aEntidad As REQENCA, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            If aEntidad.ID_REQENCA = 0 Then
                'Nueva solicitud
                'Establecer el N° de Requerimiento
                Dim lPeriodo As PERIODOREQ = (New cPERIODOREQ).ObtenerPERIODOREQ_PorFecha(aEntidad.FECHA_EMISION)

                If lPeriodo IsNot Nothing Then
                    aEntidad.NO_REQ = Me.ObtenerNoSolicitudPorPeriodo(aEntidad.ID_PERIODOREQ)
                    aEntidad.CODI_REQ = lPeriodo.CODIGO + aEntidad.NO_REQ.ToString
                End If
            End If
            aEntidad.NO_REQ_PH = If(aEntidad.NO_REQ_PH = "", Nothing, aEntidad.NO_REQ_PH)
            aEntidad.NO_ORDEN_PH = If(aEntidad.NO_ORDEN_PH = "", Nothing, aEntidad.NO_ORDEN_PH)
            aEntidad.NO_INGRESO_ALM = If(aEntidad.NO_INGRESO_ALM = "", Nothing, aEntidad.NO_INGRESO_ALM)
            aEntidad.NO_QUEDAN = If(aEntidad.NO_QUEDAN = "", Nothing, aEntidad.NO_QUEDAN)
            aEntidad.USUARIO_APROB = If(aEntidad.USUARIO_APROB = "", Nothing, aEntidad.USUARIO_APROB)
            aEntidad.USUARIO_NOAPROB = If(aEntidad.USUARIO_NOAPROB = "", Nothing, aEntidad.USUARIO_NOAPROB)
            aEntidad.USUARIO_ANUL = If(aEntidad.USUARIO_ANUL = "", Nothing, aEntidad.USUARIO_ANUL)
            aEntidad.COMENTARIO_EST = If(aEntidad.COMENTARIO_EST = "", Nothing, aEntidad.COMENTARIO_EST.Trim.ToUpper)

            Return mDb.Actualizar(aEntidad, aTipoConcurrencia)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function


    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCriterios(ByVal ID_PERIODOREQ As Int32, ByVal NO_REQ As Int32, ByVal CODI_REQ As String, ByVal ID_SECCION As Int32, ByVal ID_SOLICITANTE As Int32, ByVal ID_REQETAPA As Int32) As listaREQENCA
        Try

            Return mDb.ObtenerListaPorCriterios(ID_PERIODOREQ, NO_REQ, CODI_REQ, ID_SECCION, ID_SOLICITANTE, ID_REQETAPA)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
