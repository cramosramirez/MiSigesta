Partial Public Class cSOLIC_OIP_TRANS

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
    ''' 	[GenApp]	24/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarSOLIC_OIP_TRANS(ByVal aEntidad As SOLIC_OIP_TRANS) As Integer
        Try
            Return Me.ActualizarSOLIC_OPI(aEntidad, TipoConcurrencia.Pesimistica)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function



    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarSOLIC_OPI(ByVal aEntidad As SOLIC_OIP_TRANS, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            If aEntidad.ID_OIP_TRANS = 0 Then
                'Dim lLotes As listaLOTES = (New cLOTES).ObtenerListaPorCONTRATO(aEntidad.f)
                'Dim sDescripLotes As StringBuilder

                'Asignar N° de OPI  
                Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZAFRA(aEntidad.ID_ZAFRA)
                aEntidad.NUM_OIP_ZAFRA = mDb.ObtenerNoOPIPorZafra(aEntidad.ID_ZAFRA)
                aEntidad.REFERENCIA_GF = aEntidad.NUM_OIP_ZAFRA.ToString + "-" + lZafra.NOMBRE_ZAFRA.Replace("/", "-")
            End If

            Return mDb.Actualizar(aEntidad, aTipoConcurrencia)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

End Class
