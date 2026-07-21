Partial Public Class cIntermedia

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Ingresa un registro que recibe como parámetro.
    ''' </summary>
    ''' <remarks>Se reciben los parametros uno a uno para la entidad 
    ''' y son asignados a una entidad y se ejecuta el Metodo Actualizar
    ''' o Agregar mandando la entidad de parametro.</remarks>
    ''' <history>
    ''' 	[GenApp]	29/11/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)>
    Public Function AgregarIntermedia(ByVal Envio As Int32, ByVal Vehiculo As String, ByVal Hacienda As String, ByVal Fin_Envio As Int32, ByVal Id_Maestro As Int32) As Integer
        Try
            Dim lEntidad As New Intermedia
            lEntidad.Envio = Envio
            lEntidad.Vehiculo = Vehiculo
            lEntidad.Hacienda = Hacienda
            lEntidad.Fin_Envio = Fin_Envio
            lEntidad.Id_Maestro = Id_Maestro
            Return mDb.Agregar(lEntidad)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function
End Class
