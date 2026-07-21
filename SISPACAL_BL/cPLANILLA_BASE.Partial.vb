Partial Public Class cPLANILLA_BASE

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorZAFRA_TIPO_PLANILLA(ByVal ID_ZAFRA As Int32, ByVal ID_TIPO_PLANILLA As Int32, ByVal asColumnaOrden As String, ByVal asTipoOrden As String) As listaPLANILLA_BASE
        Try

            Return mDb.ObtenerListaPorZAFRA_TIPO_PLANILLA(ID_ZAFRA, ID_TIPO_PLANILLA, asColumnaOrden, asTipoOrden)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorZAFRA_CATORCENA_TIPO_PLANILLA(ByVal ID_ZAFRA As Int32, ByVal ID_CATORCENA As Int32, ByVal ID_TIPO_PLANILLA As Int32, Optional asColumnaOrden As String = "", Optional asTipoOrden As String = "ASC") As listaPLANILLA_BASE
        Try

            Return mDb.ObtenerListaPorZAFRA_CATORCENA_TIPO_PLANILLA(ID_ZAFRA, ID_CATORCENA, ID_TIPO_PLANILLA, asColumnaOrden, asTipoOrden)
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
    ''' 	[GenApp]	18/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarPLANILLA_BASE(ByVal aEntidad As PLANILLA_BASE) As Integer
        Try
            Return Me.ActualizarPLANILLA_BASE(aEntidad, TipoConcurrencia.Pesimistica)
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
    ''' 	[GenApp]	18/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarPLANILLA_BASE(ByVal aEntidad As PLANILLA_BASE, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            If aEntidad.ID_PLANILLA_BASE > 0 Then
                'Actualizar fecha de pago de catorcena
                If aEntidad.ID_TIPO_PLANILLA = Enumeradores.TipoPlanilla.Cañeros Then
                    Dim bCatorcena As New cCATORCENA_ZAFRA
                    Dim lCatorcena As CATORCENA_ZAFRA = (New cCATORCENA_ZAFRA).ObtenerCATORCENA_ZAFRA(aEntidad.ID_CATORCENA)
                    If lCatorcena IsNot Nothing Then
                        lCatorcena.FECHA_PAGO = aEntidad.FECHA_PAGO
                        bCatorcena.ActualizarCATORCENA_ZAFRA(lCatorcena)
                    End If
                End If
            End If

            Return mDb.Actualizar(aEntidad, aTipoConcurrencia)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function
End Class
