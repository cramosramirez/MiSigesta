Imports SISPACAL.EL.Enumeradores

Partial Public Class cTRANSPORTISTA


    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerListaPorNombreCompleto(ByVal NOMBRE_TRANSPORTISTA As String) As listaTRANSPORTISTA
        Try

            Return mDb.ObtenerListaPorNombreCompleto(NOMBRE_TRANSPORTISTA)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerListaPorZAFRA_CONTRATADA(ByVal ID_ZAFRA_CONTRATADA As Integer) As listaTRANSPORTISTA
        Try

            Return mDb.ObtenerListaPorZAFRA_CONTRATADA(ID_ZAFRA_CONTRATADA)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function


    Public Function ObtenerCorrelativoCtaContable() As String
        Try
            Return mDb.ObtenerCorrelativoCtaContable

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ObtenerListaPorNIT(ByVal NIT As String) As listaTRANSPORTISTA
        Try
            Dim lCriterios As New List(Of Criteria)
            Dim listaTrans As listaTRANSPORTISTA
            Dim lTransportista As New TRANSPORTISTA

            lCriterios.Add(New Criteria("NIT", "=", NIT, "AND"))
            lTransportista.NIT = NIT

            listaTrans = Me.ObtenerListaPorBusqueda(lTransportista, lCriterios.ToArray)
            If listaTrans IsNot Nothing AndAlso listaTrans.Count > 0 Then
                Return listaTrans
            End If

            Return Nothing

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function


    Private Function Validar(ByVal aNuevo As Boolean, ByVal aEntidad As TRANSPORTISTA) As String
        If aEntidad.DUI <> String.Empty Then
            If Not Utilerias.EsDUI(aEntidad.DUI) Then
                Return "El numero de DUI no es valido"
            End If
        End If
        If aEntidad.ID_TIPO_PERSONA = TipoPersona.Juridica AndAlso aEntidad.NIT <> String.Empty Then
            If Not Utilerias.EsNIT(aEntidad.NIT) Then
                Return "El numero de NIT no es valido"
            End If
        End If
        If aNuevo Then
            'Verificar si ya existe un transportista con el mismo DUI / NIT / NRC
            Dim lTransportistas As listaTRANSPORTISTA

            If aEntidad.NIT <> "" Then
                lTransportistas = Me.ObtenerListaPorNIT(aEntidad.NIT)
                If lTransportistas IsNot Nothing AndAlso lTransportistas.Count > 0 Then
                    Return "Ya existe un transportista con el mismo numero de NIT"
                End If
            End If
        Else
            Dim lTransportistas As listaTRANSPORTISTA
            If aEntidad.ID_TIPO_PERSONA = TipoPersona.Juridica AndAlso aEntidad.NIT <> "" Then
                lTransportistas = Me.ObtenerListaPorNIT(aEntidad.NIT)
                If lTransportistas IsNot Nothing Then
                    For Each lTransportista As TRANSPORTISTA In lTransportistas
                        If lTransportista.CODTRANSPORT <> aEntidad.CODTRANSPORT Then
                            Return "Ya existe un transportista con el mismo numero de NIT"
                        End If
                    Next
                End If
            End If
        End If
        Return ""
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
    ''' 	[GenApp]	15/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)>
    Public Function ActualizarTRANSPORTISTA(ByVal aEntidad As TRANSPORTISTA) As Integer
        Try
            Return Me.ActualizarTRANSPORTISTA(aEntidad, TipoConcurrencia.Pesimistica)
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
    ''' 	[GenApp]	15/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)>
    Public Function ActualizarTRANSPORTISTA(ByVal aEntidad As TRANSPORTISTA, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Dim lRet As String = Validar(aEntidad.CODTRANSPORT = 0, aEntidad)
            Dim i As Int32 = 0
            If lRet <> "" Then
                Me.sError = lRet
                Return -1
            End If
            Return mDb.Actualizar(aEntidad, aTipoConcurrencia)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function
End Class
