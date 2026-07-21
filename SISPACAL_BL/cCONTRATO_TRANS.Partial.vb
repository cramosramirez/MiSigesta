Partial Public Class cCONTRATO_TRANS


    Public Function ActualizarZafraLetras() As Int32
        Try
           
            Return mDb.ActualizarZafraLetras

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function


    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCriterios(ByVal ID_ZAFRA As Int32, _
                                             ByVal NO_CONTRATO As Int32, _
                                             ByVal CODTRANSPORT As Int32) As listaCONTRATO_TRANS
        Try
            Return mDb.ObtenerListaPorCriterios(ID_ZAFRA, NO_CONTRATO, CODTRANSPORT)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ObtenerCONTRATO_TRANS_PorCONTRATO_TRANS_VEHI(ByVal ID_CONTRA_TRANS_VEHI As Int32) As CONTRATO_TRANS
        Try
            Dim lEntidad As CONTRATO_TRANS_VEHI = (New cCONTRATO_TRANS_VEHI).ObtenerCONTRATO_TRANS_VEHI(ID_CONTRA_TRANS_VEHI)
            Dim lContrato As CONTRATO_TRANS

            If lEntidad IsNot Nothing Then
                lContrato = (New cCONTRATO_TRANS).ObtenerCONTRATO_TRANS(lEntidad.ID_CONTRA_TRANS)
            End If

            Return lContrato

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
    ''' 	[GenApp]	22/09/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarCONTRATO_TRANS(ByVal aEntidad As CONTRATO_TRANS) As Integer
        Try
            Return Me.ActualizarCONTRATO_TRANS(aEntidad, TipoConcurrencia.Pesimistica)
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
    ''' 	[GenApp]	22/09/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarCONTRATO_TRANS(ByVal aEntidad As CONTRATO_TRANS, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            If aEntidad.ID_CONTRA_TRANS = 0 Then
                aEntidad.NO_CONTRATO = mDb.ObtenerNoContratoPorZafra(aEntidad.ID_ZAFRA)
                aEntidad.COD_CONTRATO = aEntidad.NO_CONTRATO.ToString
            End If
            Return mDb.Actualizar(aEntidad, aTipoConcurrencia)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function


    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarCONTRATO_TRANS(ByVal ID_CONTRA_TRANS As Int32) As Integer
        Try
            mEntidad.ID_CONTRA_TRANS = ID_CONTRA_TRANS
            Return Me.EliminarCONTRATO_TRANS(mEntidad, TipoConcurrencia.Pesimistica)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla CONTRATO_TRANS que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	22/09/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarCONTRATO_TRANS(ByVal aEntidad As CONTRATO_TRANS, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Dim listaDetalle As listaCONTRATO_TRANS_VEHI = (New cCONTRATO_TRANS_VEHI).ObtenerListaPorCONTRATO_TRANS(aEntidad.ID_CONTRA_TRANS)
            Dim bContratoVehi As New cCONTRATO_TRANS_VEHI
            If listaDetalle IsNot Nothing AndAlso listaDetalle.Count > 0 Then
                For Each lEntidad As CONTRATO_TRANS_VEHI In listaDetalle
                    bContratoVehi.EliminarCONTRATO_TRANS_VEHI(lEntidad.ID_CONTRA_TRANS_VEHI)
                Next
            End If

            Return mDb.Eliminar(aEntidad, aTipoConcurrencia)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function
End Class
