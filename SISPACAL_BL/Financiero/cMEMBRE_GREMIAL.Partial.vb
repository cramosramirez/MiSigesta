Partial Public Class cMEMBRE_GREMIAL
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCriterios(ByVal ID_ZAFRA As Int32, _
                                             ByVal NUM_MEMBRE_GREMIAL As Int32, _
                                             ByVal CODIPROVEE As String, _
                                             ByVal CODISOCIO As String, _
                                             ByVal NOMBRE_PROVEEDOR As String,
                                             ByVal FECHA As DateTime) As listaMEMBRE_GREMIAL
        Try
            Return mDb.ObtenerListaPorCriterios(ID_ZAFRA, NUM_MEMBRE_GREMIAL, CODIPROVEE, CODISOCIO, NOMBRE_PROVEEDOR, FECHA)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ObtenerNoMembresiaPorZafra(ByVal ID_ZAFRA As Int32) As Int32
        Try
            Return mDb.ObtenerNoMembresiaPorZafra(ID_ZAFRA)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function


    ''' </summary>
    ''' <param name="aEntidad">Entidad que contiene los datos a Actualizar o Ingresar.</param>
    ''' <remarks>La entidad ya debe estar inicializada. Si es una tabla de Muchos a Muchos
    ''' este método unicamente actualiza el registro. Si no es una tabla de Muchos a Muchos
    ''' puede Actualizar o insertar un registro, dependiendo si la llave única trae un valor
    ''' de Cero(0) para ser autoincrementada por el método de la Clase de Acceso a Datos.</remarks>
    ''' <history>
    ''' 	[GenApp]	08/07/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarMEMBRE_GREMIAL(ByVal aEntidad As MEMBRE_GREMIAL) As Integer
        Try
            Return Me.ActualizarMEMBRE_GREMIAL(aEntidad, TipoConcurrencia.Pesimistica)
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
    ''' 	[GenApp]	08/07/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarMEMBRE_GREMIAL(ByVal aEntidad As MEMBRE_GREMIAL, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Dim bNuevo As Boolean = (aEntidad.ID_MEMBRE_GREMIAL = 0)
            Dim lRet As Int32
            If aEntidad.NUM_MEMBRE_GREMIAL = 0 Then
                aEntidad.NUM_MEMBRE_GREMIAL = Me.ObtenerNoMembresiaPorZafra(aEntidad.ID_ZAFRA)
            End If

            lRet = mDb.Actualizar(aEntidad, aTipoConcurrencia)
            Return lRet

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function
End Class
