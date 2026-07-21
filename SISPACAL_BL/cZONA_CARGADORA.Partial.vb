Partial Public Class cZONA_CARGADORA

    Public Function ObtenerZONA_CARGADORA(ByVal ID_ZAFRA As Int32, ByVal ZONA As String, ByVal ID_CARGADORA As Int32) As ZONA_CARGADORA
        Try
            Return mDb.ObtenerZONA_CARGADORA(ID_ZAFRA, ZONA, ID_CARGADORA)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function


    Public Function ObtenerListaPorZAFRA_ZONA(ByVal ID_ZAFRA As Int32, ByVal ZONA As String, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaZONA_CARGADORA
        Try
            Return mDb.ObtenerListaPorZAFRA_ZONA(ID_ZAFRA, ZONA, asColumnaOrden, asTipoOrden)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
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
    ''' 	[GenApp]	08/03/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarZONA_CARGADORA(ByVal aEntidad As ZONA_CARGADORA) As Integer
        Try
            Return Me.ActualizarZONA_CARGADORA(aEntidad, TipoConcurrencia.Pesimistica)
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
    ''' 	[GenApp]	08/03/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarZONA_CARGADORA(ByVal aEntidad As ZONA_CARGADORA, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try

            'If aEntidad.ID_ZONA_CARGA = 0 Then
            '    'Verificar si ya está asignada la cargadora en la zona
            '    Dim lEntidad As ZONA_CARGADORA = Me.ObtenerZONA_CARGADORA(aEntidad.ID_ZAFRA, aEntidad.ZONA, aEntidad.ID_CARGADORA)
            '    If lEntidad IsNot Nothing AndAlso lEntidad.ID_ZONA_CARGA > 0 Then
            '        Return 1
            '    End If
            'End If
            Return mDb.Actualizar(aEntidad, aTipoConcurrencia)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function
End Class
