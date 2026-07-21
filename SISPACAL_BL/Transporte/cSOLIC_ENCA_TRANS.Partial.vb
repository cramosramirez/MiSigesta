Partial Public Class cSOLIC_ENCA_TRANS

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCriterios(ByVal ID_ZAFRA As Int32, _
                                             ByVal NUM_SOLICITUD As Int32, _
                                             ByVal CODTRANSPORT As Int32, _
                                             ByVal NO_CONTRATO As Int32, _
                                             ByVal NOMBRE_TRANSPORTISTA As String) As listaSOLIC_ENCA_TRANS
        Try
            Return mDb.ObtenerListaPorCriterios(ID_ZAFRA, NUM_SOLICITUD, CODTRANSPORT, NO_CONTRATO, NOMBRE_TRANSPORTISTA)

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
    ''' 	[GenApp]	23/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarSOLIC_ENCA_TRANS(ByVal aEntidad As SOLIC_ENCA_TRANS) As Integer
        Try
            Return Me.ActualizarSOLIC_ENCA_TRANS(aEntidad, TipoConcurrencia.Pesimistica)
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
    ''' 	[GenApp]	23/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarSOLIC_ENCA_TRANS(ByVal aEntidad As SOLIC_ENCA_TRANS, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            If aEntidad.ID_SOLICITUD = 0 Then
                'Asignar N° de Solicitud  
                Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZAFRA(aEntidad.ID_ZAFRA)
                aEntidad.NUM_SOLIC_ZAFRA = mDb.ObtenerNoSolicPorZafra(aEntidad.ID_ZAFRA)
            End If

            Return mDb.Actualizar(aEntidad, aTipoConcurrencia)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla SOLIC_ENCA_TRANS que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_SOLICITUD"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarSOLIC_ENCA_TRANS(ByVal ID_SOLICITUD As Int32) As Integer
        Try
            mEntidad.ID_SOLICITUD = ID_SOLICITUD
            Return Me.EliminarSOLIC_ENCA_TRANS(mEntidad, TipoConcurrencia.Pesimistica)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla SOLIC_ENCA_TRANS que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarSOLIC_ENCA_TRANS(ByVal aEntidad As SOLIC_ENCA_TRANS, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Dim lDetalle As listaSOLIC_PROD_TRANS = (New cSOLIC_PROD_TRANS).ObtenerListaPorSOLIC_ENCA_TRANS(aEntidad.ID_SOLICITUD)
            Dim bSolicProd As New cSOLIC_PROD_TRANS

            If lDetalle IsNot Nothing AndAlso lDetalle.Count > 0 Then
                For i As Int32 = 0 To lDetalle.Count - 1
                    bSolicProd.EliminarSOLIC_PROD_TRANS(lDetalle(i).ID_SOLIC_PROD_TRANS)
                Next
            End If

            Return mDb.Eliminar(aEntidad, aTipoConcurrencia)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

End Class
