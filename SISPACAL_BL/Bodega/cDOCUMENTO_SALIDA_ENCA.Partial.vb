Partial Public Class cDOCUMENTO_SALIDA_ENCA

    Public Function ObtenerCantidadProductoDoctoSalida(ByVal ID_DOCSAL_ENCA As Int32, ByVal ID_PRODUCTO As Int32) As Decimal
        Try
            Return mDb.ObtenerCantidadProductoDoctoSalida(ID_DOCSAL_ENCA, ID_PRODUCTO)

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
    ''' 	[GenApp]	27/07/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarDOCUMENTO_SALIDA_ENCA(ByVal aEntidad As DOCUMENTO_SALIDA_ENCA) As Integer
        Try
            Return Me.ActualizarDOCUMENTO_SALIDA_ENCA(aEntidad, TipoConcurrencia.Pesimistica)
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
    ''' 	[GenApp]	27/07/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarDOCUMENTO_SALIDA_ENCA(ByVal aEntidad As DOCUMENTO_SALIDA_ENCA, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Dim lRet As Int32 = 0
            If aEntidad.ID_DOCSAL_ENCA = 0 Then
                lRet = mDb.Actualizar(aEntidad, aTipoConcurrencia)
                aEntidad.NO_DOCUMENTO = aEntidad.ID_DOCSAL_ENCA
                lRet = mDb.Actualizar(aEntidad, aTipoConcurrencia)
            Else
                lRet = mDb.Actualizar(aEntidad, aTipoConcurrencia)
            End If
            Return lRet
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla DOCUMENTO_SALIDA_ENCA que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_DOCSAL_ENCA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	27/07/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarDOCUMENTO_SALIDA_ENCA(ByVal ID_DOCSAL_ENCA As Int32) As Integer
        Try
            mEntidad.ID_DOCSAL_ENCA = ID_DOCSAL_ENCA
            Return Me.EliminarDOCUMENTO_SALIDA_ENCA(mEntidad, TipoConcurrencia.Pesimistica)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla DOCUMENTO_SALIDA_ENCA que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	27/07/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarDOCUMENTO_SALIDA_ENCA(ByVal aEntidad As DOCUMENTO_SALIDA_ENCA, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            'Eliminar detalle de salida de bodega
            Dim bDocumentoDeta As New cDOCUMENTO_SALIDA_DETA
            Dim lista As listaDOCUMENTO_SALIDA_DETA = (New cDOCUMENTO_SALIDA_DETA).ObtenerListaPorDOCUMENTO_SALIDA_ENCA(aEntidad.ID_DOCSAL_ENCA)
            If lista IsNot Nothing AndAlso lista.Count > 0 Then
                For i As Int32 = 0 To lista.Count - 1
                    bDocumentoDeta.EliminarDOCUMENTO_SALIDA_DETA(lista(i).ID_DOCSAL_ENCA_DETA)
                Next
            End If

            Return mDb.Eliminar(aEntidad, aTipoConcurrencia)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function
End Class
