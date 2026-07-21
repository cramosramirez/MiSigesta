Imports System.Configuration
Imports System.Globalization

Partial Public Class cORDEN_COMBUSTIBLE

    Public Function CantidadCoincidencias(ByVal ID_ZAFRA As Int32, _
                                            ByVal ID_PROVEEDOR_COMBUS As Int32, _
                                            ByVal CODIGO As Int32, _
                                            ByVal ID_TIPO_PROVEEDOR As Int32, _
                                            ByVal FECHA_EMISION As DateTime, _
                                            ByVal PLACA As String, _
                                            ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime) As Integer
        Try
            Return mDb.CantidadCoincidencias(ID_ZAFRA, ID_PROVEEDOR_COMBUS, CODIGO, ID_TIPO_PROVEEDOR, FECHA_EMISION, PLACA, USUARIO_CREA, FECHA_CREA)

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
    ''' 	[GenApp]	05/01/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarORDEN_COMBUSTIBLE(ByVal aEntidad As ORDEN_COMBUSTIBLE) As Integer
        Try
            Return Me.ActualizarORDEN_COMBUSTIBLE(aEntidad, TipoConcurrencia.Pesimistica)
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
    ''' 	[GenApp]	05/01/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarORDEN_COMBUSTIBLE(ByVal aEntidad As ORDEN_COMBUSTIBLE, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            'Verificar si existe una orden con los mismos valores que la orden actual
            Dim lCatorcenas As listaCATORCENA_ZAFRA
            Dim lZafra As ZAFRA
            Dim bOrdenCombustible As cORDEN_COMBUSTIBLE
            Dim sZafra As String = ""
            Dim lRet As Integer
            Dim NumeroAutorizacion As Integer = -1
            Dim bNuevo As Boolean = (aEntidad.ID_ORDEN_COMBUS = 0)

            If aEntidad.ID_ORDEN_COMBUS = 0 Then
                Dim cantidad As Integer
                cantidad = Me.CantidadCoincidencias(aEntidad.ID_ZAFRA, aEntidad.ID_PROVEEDOR_COMBUS, aEntidad.CODIGO, aEntidad.ID_TIPO_PROVEEDOR, aEntidad.FECHA_EMISION, aEntidad.PLACA, aEntidad.USUARIO_CREA, aEntidad.FECHA_CREA)
                If cantidad > 0 Then
                    Return -7
                End If
            Else
                If aEntidad.ID_CATORCENA > 0 Then
                    Me.sError = "Orden pertenece a un corte de catorcena. No se permite modificarla"
                    Return -1
                End If
                If aEntidad.FECHA_DESPACHO <> #12:00:00 AM# Then
                    'Validar que la fecha despacho no sea menor a la fecha de la última catorcena cerrada
                    lCatorcenas = (New cCATORCENA_ZAFRA).ObtenerListaPorZAFRA(aEntidad.ID_ZAFRA, False, False, "CATORCENA", "DESC")
                    If lCatorcenas IsNot Nothing AndAlso lCatorcenas.Count > 0 Then
                        If aEntidad.FECHA_DESPACHO <= lCatorcenas(0).FECHA_FIN Then
                            Me.sError = "La fecha de despacho no puede ser menor a la fecha final de la ultima catorcena."
                            Return -1
                        End If
                    End If
                End If
            End If

            lRet = mDb.Actualizar(aEntidad, aTipoConcurrencia)
            If bNuevo AndAlso lRet >= 1 Then
                Dim lTransportista As TRANSPORTISTA = (New cTRANSPORTISTA).ObtenerTRANSPORTISTA(aEntidad.CODIGO)
                Dim nombreTransportista As String = ""
                Dim cuenta As String = ""
                If lTransportista IsNot Nothing Then
                    nombreTransportista = Trim(lTransportista.NOMBRES.Trim + " " + lTransportista.APELLIDOS.Trim)
                    cuenta = lTransportista.NOCUENTA
                End If
                bOrdenCombustible = New cORDEN_COMBUSTIBLE
                lZafra = (New cZAFRA).ObtenerZAFRA(aEntidad.ID_ZAFRA)
                sZafra = lZafra.NOMBRE_ZAFRA.Replace("/", "")
                aEntidad.CODIBARRA = Utilerias.RellenarIzquierda(aEntidad.ID_ORDEN_COMBUS.ToString, 7)
                bOrdenCombustible.ActualizarORDEN_COMBUSTIBLE(aEntidad)
                Dim dbOrdenSIGASI As New dbOrdenSIGASI
                Dim lResult As Int32
                lResult = dbOrdenSIGASI.AgregarValesx(aEntidad.CODIBARRA, aEntidad.FECHA_EMISION, aEntidad.FECHA_CREA.ToString("t", CultureInfo.CreateSpecificCulture("es-ES")), _
                                Convert.ToDecimal(aEntidad.CODIGO), aEntidad.ID_ORDEN_COMBUS, IIf(aEntidad.PLACA = Nothing, " ", aEntidad.PLACA), aEntidad.TOTAL, #12:00:00 AM#, 0, 0, 0, _
                                IIf(aEntidad.NRC = Nothing, " ", aEntidad.NRC), IIf(aEntidad.NIT = Nothing, " ", aEntidad.NIT), nombreTransportista, IIf(cuenta = Nothing, " ", cuenta))
                If lResult < 1 Then
                    Me.sError = "Error: Transaccion incompleta no se logró crear el registro SIGASI"
                    Return -1
                End If
            End If
            Return lRet
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Me.sError = ex.Message
            Return -1
        End Try
    End Function

    Private Function ObtenerNumeroAutorizacionOrden(ByVal CODIGO As String, ByVal ID_TIPO_PROVEEDOR As Integer) As Integer
        Dim lCriterios As New List(Of Criteria)
        Dim lOrdenAuto As New ORDEN_COMBUSTIBLE_AUTORIZACION
        Dim listaOrdenAutorizadas As listaORDEN_COMBUSTIBLE_AUTORIZACION
        Dim bOrdenAutorizada As New cORDEN_COMBUSTIBLE_AUTORIZACION

        lCriterios.Add(New Criteria("CODIGO", "=", CODIGO, "AND"))
        lCriterios.Add(New Criteria("ID_TIPO_PROVEEDOR", "=", ID_TIPO_PROVEEDOR.ToString, "AND"))
        lCriterios.Add(New Criteria("AUTORIZACION_APLICADA", "=", "0", ""))
        lOrdenAuto.CODIGO = CODIGO
        lOrdenAuto.ID_TIPO_PROVEEDOR = ID_TIPO_PROVEEDOR
        lOrdenAuto.AUTORIZACION_APLICADA = False
        listaOrdenAutorizadas = bOrdenAutorizada.ObtenerListaPorBusqueda(lOrdenAuto, lCriterios.ToArray)
        If listaOrdenAutorizadas IsNot Nothing AndAlso listaOrdenAutorizadas.Count > 0 Then
            listaOrdenAutorizadas = listaOrdenAutorizadas.DevolverListaOrdenadaPorColumna("FECHA_CREA", SortOrder.Descending)
            Return listaOrdenAutorizadas(0).ID_ORDEN_COMBUS_AUTO
        Else
            Return -1
        End If
    End Function

    Public Function ObtenerUltimosRegistrosPorUsuario(ByVal USUARIO As String, ByVal NUM_REGISTROS As Integer) As listaORDEN_COMBUSTIBLE
        Try
            Return mDb.ObtenerUltimosRegistrosPorUsuario(USUARIO, NUM_REGISTROS)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ActualizarPorLoteORDEN_COMSUSTIBLE() As Integer
        Try
            Dim lOrden As New dbOrdenSIGASI
            Return lOrden.ActualizarPorLoteORDEN_COMSUSTIBLE()

        Catch ex As Exception
            Me.sError = ex.Message
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function
End Class
