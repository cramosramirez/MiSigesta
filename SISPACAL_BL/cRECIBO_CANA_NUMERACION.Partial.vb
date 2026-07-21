Partial Public Class cRECIBO_CANA_NUMERACION

    Public Function ObtenerReciboCanaActivo() As RECIBO_CANA_NUMERACION
        Try
            Return mDb.ObtenerReciboCanaActivo

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ExisteNumeracionReciboCana() As Boolean
        Try
            Dim lEntidad As RECIBO_CANA_NUMERACION
            lEntidad = mDb.ObtenerReciboCanaActivo
            If lEntidad IsNot Nothing Then
                If lEntidad.NUM_FINAL = lEntidad.ULT_NUM_ASIGNADO Then
                    Return False
                Else
                    Return True
                End If
            Else
                Return False
            End If

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return False
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
    ''' 	[GenApp]	04/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarRECIBO_CANA_NUMERACION(ByVal aEntidad As RECIBO_CANA_NUMERACION) As Integer
        Try
            Return Me.ActualizarRECIBO_CANA_NUMERACION(aEntidad, TipoConcurrencia.Pesimistica)
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
    ''' 	[GenApp]	04/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarRECIBO_CANA_NUMERACION(ByVal aEntidad As RECIBO_CANA_NUMERACION, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            If aEntidad.ACTIVO Then
                Dim lNumeracionesReciboCana As listaRECIBO_CANA_NUMERACION
                Dim lCriterios As New List(Of Criteria)
                Dim lReciboCanaNum As New RECIBO_CANA_NUMERACION

                lCriterios.Add(New Criteria("ACTIVO", "=", "1", ""))
                lReciboCanaNum.ACTIVO = 1
                lNumeracionesReciboCana = Me.ObtenerListaPorBusqueda(lReciboCanaNum, lCriterios.ToArray)
                If lNumeracionesReciboCana IsNot Nothing AndAlso lNumeracionesReciboCana.Count > 0 Then
                    For i As Integer = 0 To lNumeracionesReciboCana.Count - 1
                        If lNumeracionesReciboCana(i).ACTIVO Then
                            lNumeracionesReciboCana(i).ACTIVO = False
                            mDb.Actualizar(lNumeracionesReciboCana(i), aTipoConcurrencia)
                        End If
                    Next
                End If
            End If

            Return mDb.Actualizar(aEntidad, aTipoConcurrencia)
        Catch ex As Exception
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
    ''' 	[GenApp]	04/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarRECIBO_CANA_NUMERACION(ByVal ID_RECIBO_CANA_NUM As Int32, ByVal NUM_INICIAL As Int32, ByVal NUM_FINAL As Int32, ByVal ULT_NUM_ASIGNADO As Int32, ByVal ACTIVO As Boolean, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime) As Integer
        Try
            Dim lEntidad As New RECIBO_CANA_NUMERACION
            lEntidad.ID_RECIBO_CANA_NUM = ID_RECIBO_CANA_NUM
            lEntidad.NUM_INICIAL = NUM_INICIAL
            lEntidad.NUM_FINAL = NUM_FINAL
            lEntidad.ULT_NUM_ASIGNADO = ULT_NUM_ASIGNADO
            lEntidad.ACTIVO = ACTIVO
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            Return Me.ActualizarRECIBO_CANA_NUMERACION(lEntidad)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    Public Function ExisteNumeroReciboCana(ByVal NUMRECIBO_CANA As Integer) As Boolean
        Try
            Return mDb.ExisteNumeroReciboCana(NUMRECIBO_CANA)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return False
        End Try
    End Function

    Public Function ExisteAsignacionNumeroReciboCana(ByVal ID_ZAFRA As Integer, ByVal NUMRECIBO_CANA As Integer) As Boolean
        Try
            Return mDb.ExisteAsignacionNumeroReciboCana(ID_ZAFRA, NUMRECIBO_CANA)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return False
        End Try
    End Function

    Public Function ObtenerProximoNUMRECIBO_CANA() As Integer
        Dim lResultado As Integer = -1
        Dim condicion As Boolean = True
        Dim lNumRecibo As Integer
        Dim lNumeracionActiva As RECIBO_CANA_NUMERACION
        Dim lZafra As ZAFRA

        Try
            lZafra = (New cZAFRA).ObtenerZafraActiva
            lNumeracionActiva = Me.ObtenerReciboCanaActivo
            If lNumeracionActiva IsNot Nothing Then
                'Verificar que el próximo número de recibo no se encuentre anulado, de lo contrario incrementar
                'hasta encontrar uno disponible
                If lNumeracionActiva.ULT_NUM_ASIGNADO = -1 Then
                    lNumRecibo = lNumeracionActiva.NUM_INICIAL
                Else
                    lNumRecibo = lNumeracionActiva.ULT_NUM_ASIGNADO + 1
                End If

                While condicion
                    Dim lReciboAnulado As listaRECIBO_CANA_ANULADO = (New cRECIBO_CANA_ANULADO).ObtenerListaPorNUMRECIBO_CANA(lZafra.ID_ZAFRA, lNumRecibo)
                    If lReciboAnulado Is Nothing AndAlso Not ExisteAsignacionNumeroReciboCana(lZafra.ID_ZAFRA, lNumRecibo) Then
                        lResultado = lNumRecibo
                        condicion = False
                    Else
                        If lNumRecibo + 1 <= lNumeracionActiva.NUM_FINAL Then
                            lNumRecibo += 1
                        Else
                            condicion = False
                        End If
                    End If
                End While
            End If
            Return lNumRecibo

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return lResultado
        End Try
    End Function
End Class
