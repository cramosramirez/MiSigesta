Partial Public Class cLOTES
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve un DataSer filtrado por los parámetros.
    ''' </summary>
    ''' <param name="ZONA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerDataSetPorCriterios1(ByVal NOMBRE_ZAFRA As String, ByVal ZONA As String, ByVal ID_PLAN_SEMANAL As Integer, ByVal CODIPROVEE As String, _
                                               ByVal CODISOCIO As String, ByVal NOMBRE_PROVEEDOR As String, ByVal INCLUIR_LOTES_NO_PROGRAMADOS As Boolean, _
                                               Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As DataSet
        Try
            Return mDb.ObtenerDataSetPorCriterios1(NOMBRE_ZAFRA, ZONA, ID_PLAN_SEMANAL, CODIPROVEE, CODISOCIO, NOMBRE_PROVEEDOR, INCLUIR_LOTES_NO_PROGRAMADOS, asColumnaOrden, asTipoOrden)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function AsignarAgronomo(ByVal OPCION As String, ByVal ID_ZAFRA As Integer, ByVal ZONA As String, ByVal ACCESLOTE As String, ByVal CODIAGRON As String, ByVal USUARIO As String) As Integer
        Try
            Return mDb.AsignarAgronomo(OPCION, ID_ZAFRA, ZONA, ACCESLOTE, CODIAGRON, USUARIO)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve un DataSer filtrado por los parámetros.
    ''' </summary>
    ''' <param name="ZONA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerDataSetPorCriterios2(ByVal NOMBRE_ZAFRA As String, ByVal ZONA As String, ByVal CODIPROVEE As String, _
                                               ByVal CODISOCIO As String, ByVal NOMBRE_PROVEEDOR As String, _
                                               Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As DataSet
        Try
            Return mDb.ObtenerDataSetPorCriterios2(NOMBRE_ZAFRA, ZONA, CODIPROVEE, CODISOCIO, NOMBRE_PROVEEDOR, asColumnaOrden, asTipoOrden)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve un DataSer filtrado por los parámetros.
    ''' </summary>
    ''' <param name="ZONA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCriterios(ByVal NOMBRE_ZAFRA As String, ByVal ZONA As String, ByVal ID_PLAN_SEMANAL As Integer, ByVal CODIPROVEE As String, _
                                               ByVal CODISOCIO As String, ByVal NOMBRE_PROVEEDOR As String, ByVal INCLUIR_LOTES_NO_PROGRAMADOS As Boolean, _
                                               Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaLOTES
        Try
            Return mDb.ObtenerListaPorCriterios(NOMBRE_ZAFRA, ZONA, ID_PLAN_SEMANAL, CODIPROVEE, CODISOCIO, NOMBRE_PROVEEDOR, INCLUIR_LOTES_NO_PROGRAMADOS, asColumnaOrden, asTipoOrden)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorANIOZAFRA_PROVEEDOR(ByVal ANIOZAFRA As String, ByVal CODIPROVEEDOR As String, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaLOTES
        Try
            Return mDb.ObtenerListaPorANIOZAFRA_PROVEEDOR(ANIOZAFRA, CODIPROVEEDOR, asColumnaOrden, asTipoOrden)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCriterios2(ByVal ID_ZAFRA As Int32, ByVal ZONA As String, ByVal SUB_ZONA As String, _
                                              ByVal CODI_DEPTO As String, ByVal CODI_MUNI As String, ByVal CODI_CANTON As String, _
                                              ByVal CODIPROVEE As String, ByVal CODISOCIO As String, ByVal NOMBRE_PROVEEDOR As String) As listaLOTES
        Try
            Return mDb.ObtenerListaPorCriterios2(ID_ZAFRA, ZONA, SUB_ZONA, CODI_DEPTO, CODI_MUNI, CODI_CANTON, CODIPROVEE, CODISOCIO, NOMBRE_PROVEEDOR)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorZAFRA_NO_CONTRATO(ByVal ID_ZAFRA As Int32, ByVal NO_CONTRATO As Int32) As listaLOTES
        Try
            Return mDb.ObtenerListaPorZAFRA_NO_CONTRATO(ID_ZAFRA, NO_CONTRATO)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorZAFRA_CONTRATADA_PROVEEDOR_CONTRATADO(ByVal ID_ZAFRA As Int32, ByVal CODIPROVEEDOR As String, ByVal CODIAGRON As String) As listaLOTES
        Try
            Return mDb.ObtenerListaPorZAFRA_CONTRATADA_PROVEEDOR_CONTRATADO(ID_ZAFRA, CODIPROVEEDOR, CODIAGRON)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorZAFRA_CONTRATADA_PROVEEDOR(ByVal ID_ZAFRA As Int32, ByVal CODIPROVEEDOR As String, ByVal CODIAGRON As String) As listaLOTES
        Try
            Return mDb.ObtenerListaPorZAFRA_CONTRATADA_PROVEEDOR(ID_ZAFRA, CODIPROVEEDOR, CODIAGRON)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ObtenerTonelLibrasEntregadasPorZafraLote(ByVal ID_ZAFRA As Integer, ByVal ACCESLOTE As String) As Dictionary(Of String, Decimal)
        Try
            Return mDb.ObtenerTonelLibrasEntregadasPorZafraLote(ID_ZAFRA, ACCESLOTE)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ObtenerTonelLibrasEntregadasPorZafraLoteFechaTara(ByVal ID_ZAFRA As Integer, ByVal ACCESLOTE As String, ByVal FECHA_LEE_TARA As DateTime) As Dictionary(Of String, Decimal)
        Try
            Return mDb.ObtenerTonelLibrasEntregadasPorZafraLoteFechaTara(ID_ZAFRA, ACCESLOTE, FECHA_LEE_TARA)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorZAFRA_MAESTRO_LOTES(ByVal ID_ZAFRA As Integer, ByVal ID_MAESTRO As Int32, Optional CODICONTRATO_NOINCLUIR As String = "") As listaLOTES
        Try
            Return mDb.ObtenerListaPorZAFRA_MAESTRO_LOTES(ID_ZAFRA, ID_MAESTRO, CODICONTRATO_NOINCLUIR)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Actualiza un registro de la Entidad que recibe de parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad que contiene los datos a Actualizar o Ingresar.</param>
    ''' <remarks>La entidad ya debe estar inicializada. Si es una tabla de Muchos a Muchos
    ''' este método unicamente actualiza el registro. Si no es una tabla de Muchos a Muchos
    ''' puede Actualizar o insertar un registro, dependiendo si la llave única trae un valor
    ''' de Cero(0) para ser autoincrementada por el método de la Clase de Acceso a Datos.</remarks>
    ''' <history>
    ''' 	[GenApp]	15/07/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarLOTES(ByVal aEntidad As LOTES) As Integer
        Try
            Return Me.ActualizarLOTES(aEntidad, TipoConcurrencia.Pesimistica)
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
    ''' 	[GenApp]	23/06/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarLOTES(ByVal aEntidad As LOTES, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Dim lRet As Int32
            Dim lMaestro As MAESTRO_LOTES
            Dim bMaestro As New cMAESTRO_LOTES
            Dim lContrato As CONTRATO
            Dim lLoteTraspaso As New LOTES_TRASPASO
            Dim bLotesTraspaso As New cLOTES_TRASPASO
            Dim EsTraspaso As Boolean = False

            If aEntidad.CODIAGRON = "" Then aEntidad.CODIAGRON = Nothing
            If aEntidad.CODIUBICACION = "" Then aEntidad.CODIUBICACION = Nothing
            If aEntidad.TIPO_DERECHO = 0 Then aEntidad.TIPO_DERECHO = -1
            If aEntidad.ACCESLOTE = "" Then
                'Verificar que no exista el código a generar
                lMaestro = (New cMAESTRO_LOTES).ObtenerMAESTRO_LOTES(aEntidad.ID_MAESTRO)
                lContrato = (New cCONTRATO).ObtenerCONTRATO(aEntidad.CODICONTRATO)
                Dim sAccesLote As String = aEntidad.ANIOZAFRA + Utilerias.RellenarIzquierda(lContrato.NO_CONTRATO.ToString, 4) + _
                                            Utilerias.RellenarIzquierda(aEntidad.ID_MAESTRO.ToString, 8)

                Dim lEntidad As LOTES = (New cLOTES).ObtenerLOTES(sAccesLote)
                If lEntidad IsNot Nothing Then
                    sAccesLote = aEntidad.ANIOZAFRA + Utilerias.RellenarIzquierda(lContrato.NO_CONTRATO.ToString, 4) + Left(Guid.NewGuid.ToString, 8)
                    'sError = "El código " + sAccesLote + " para el Lote " + aEntidad.NOMBLOTE + " ya esta en uso"
                    'Return -1
                End If
                aEntidad.ACCESLOTE = sAccesLote
                If aEntidad.ACCESLOTE_TRASPASAR <> "" Then
                    Dim lLoteOld As LOTES = (New cLOTES).ObtenerLOTES(aEntidad.ACCESLOTE_TRASPASAR)
                    lLoteTraspaso = New LOTES_TRASPASO
                    lLoteTraspaso.ID_LOTE_TRASPASO = 0
                    lLoteTraspaso.ACCESLOTE = aEntidad.ACCESLOTE_TRASPASAR
                    lLoteTraspaso.ANIOZAFRA = lLoteOld.ANIOZAFRA
                    lLoteTraspaso.CODIPROVEEDOR = lLoteOld.CODIPROVEEDOR
                    lLoteTraspaso.CODILOTE = lLoteOld.CODILOTE
                    lLoteTraspaso.CODIVARIEDA = lLoteOld.CODIVARIEDA
                    lLoteTraspaso.CODICONTRATO = lLoteOld.CODICONTRATO
                    lLoteTraspaso.NOMBLOTE = lLoteOld.NOMBLOTE
                    lLoteTraspaso.AREA = lLoteOld.AREA
                    lLoteTraspaso.TONELADAS = lLoteOld.TONELADAS
                    lLoteTraspaso.TONEL_TC = lLoteOld.TONEL_TC
                    lLoteTraspaso.ZONA = lLoteOld.ZONA
                    lLoteTraspaso.EDAD_LOTE = lLoteOld.EDAD_LOTE
                    lLoteTraspaso.USUARIO_CREA = Utilerias.ObtenerUsuario
                    lLoteTraspaso.FECHA_CREA = cFechaHora.ObtenerFechaHora
                    lLoteTraspaso.ID_MAESTRO = lLoteOld.ID_MAESTRO
                    lLoteTraspaso.TIPO_DERECHO = lLoteOld.TIPO_DERECHO
                    lLoteTraspaso.SUB_ZONA = lLoteOld.SUB_ZONA
                    lLoteTraspaso.ID_ZAFRA_TRASPASO = -1

                    'Código agregado para asignar la zafra activa en el traspaso
                    '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                    Dim lZafraActiva As ZAFRA = (New cZAFRA).ObtenerZafraActiva
                    If lZafraActiva IsNot Nothing Then
                        Dim lZafraContra As CONTRATO_ZAFRAS = (New cCONTRATO_ZAFRAS).ObtenerCONTRATO_ZAFRASPorZAFRA_CONTRATO(lZafraActiva.ID_ZAFRA, aEntidad.CODICONTRATO)
                        If lZafraContra IsNot Nothing Then
                            lLoteTraspaso.ID_ZAFRA_TRASPASO = lZafraActiva.ID_ZAFRA
                        End If
                    End If
                    '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                    If bLotesTraspaso.ActualizarLOTES_TRASPASO(lLoteTraspaso) > 0 Then
                        aEntidad.ID_LOTE_TRASPASO = lLoteTraspaso.ID_LOTE_TRASPASO

                    End If
                End If

                lRet = mDb.Agregar(aEntidad)

                If lRet > 0 AndAlso aEntidad.ACCESLOTE_TRASPASAR <> "" Then
                    '(SE CANCELA ESTA CONDICION)Actualizar maestro lotes si el proveedor quedo como propietario
                    'If aEntidad.TIPO_DERECHO = Enumeradores.TipoDerechoLote.Propietario Then
                    lMaestro = (New cMAESTRO_LOTES).ObtenerMAESTRO_LOTES(aEntidad.ID_MAESTRO)
                    If lMaestro IsNot Nothing AndAlso lMaestro.CODIPROVEEDOR <> aEntidad.CODIPROVEEDOR Then
                        lMaestro.CODIPROVEEDOR = aEntidad.CODIPROVEEDOR
                        lMaestro.TIPO_DERECHO = aEntidad.TIPO_DERECHO
                        lMaestro.USUARIO_ACT = Utilerias.ObtenerUsuario
                        lMaestro.FECHA_ACT = cFechaHora.ObtenerFechaHora

                        bMaestro.ActualizarMAESTRO_LOTES(lMaestro)
                    End If
                    'End If

                    'Actualizar tablas (con nuevo código de lote) que hagan refererencia a las zafras donde el lote esta abierto
                    If (New cLOTES_COSECHA).ActualizarReferenciasLOTES_COSECHA(aEntidad.ACCESLOTE_TRASPASAR, aEntidad.ACCESLOTE) <= -1 Then
                        sError = "No se lograron actualizar las referencias de LOTES_COSECHA mediante el procedimiento. Información inconsistente, reporte de inmediato"
                        Return -1
                    End If

                    'Eliminar lote traspasado del contrato original
                    Me.EliminarLOTES(aEntidad.ACCESLOTE_TRASPASAR)

                    'Actualizar area y toneladas del contrato al que pertenece
                    lContrato = (New cCONTRATO).ObtenerCONTRATO(lLoteTraspaso.CODICONTRATO)
                    If lContrato IsNot Nothing Then
                        Dim bContrato As New cCONTRATO
                        Dim totalArea As Decimal = 0
                        Dim totalTons As Decimal = 0
                        Dim lLotesContrato As listaLOTES = (New cLOTES).ObtenerListaPorCONTRATO(lContrato.CODICONTRATO)
                        If lLotesContrato IsNot Nothing AndAlso lLotesContrato.Count > 0 Then
                            For Each l As LOTES In lLotesContrato
                                totalArea += l.AREA
                                totalTons += l.TONEL_TC
                            Next
                        End If
                        lContrato.TOTALMZ_CONTRATOCB = totalArea
                        lContrato.TONELADAS_CONTRATOCB = totalTons
                        bContrato.ActualizarCONTRATO(lContrato)
                    End If

                    'Actualizar lotes cosecha por si ya hay censo
                    EsTraspaso = True
                End If
            Else
                If aEntidad.ACCESLOTE_TRASPASAR <> "" Then
                    Dim lLoteOld As LOTES = (New cLOTES).ObtenerLOTES(aEntidad.ACCESLOTE_TRASPASAR)
                    lLoteTraspaso = New LOTES_TRASPASO
                    lLoteTraspaso.ID_LOTE_TRASPASO = 0
                    lLoteTraspaso.ACCESLOTE = aEntidad.ACCESLOTE_TRASPASAR
                    lLoteTraspaso.ANIOZAFRA = lLoteOld.ANIOZAFRA
                    lLoteTraspaso.CODIPROVEEDOR = lLoteOld.CODIPROVEEDOR
                    lLoteTraspaso.CODILOTE = lLoteOld.CODILOTE
                    lLoteTraspaso.CODIVARIEDA = lLoteOld.CODIVARIEDA
                    lLoteTraspaso.CODICONTRATO = lLoteOld.CODICONTRATO
                    lLoteTraspaso.NOMBLOTE = lLoteOld.NOMBLOTE
                    lLoteTraspaso.AREA = lLoteOld.AREA
                    lLoteTraspaso.TONELADAS = lLoteOld.TONELADAS
                    lLoteTraspaso.TONEL_TC = lLoteOld.TONEL_TC
                    lLoteTraspaso.ZONA = lLoteOld.ZONA
                    lLoteTraspaso.EDAD_LOTE = lLoteOld.EDAD_LOTE
                    lLoteTraspaso.USUARIO_CREA = Utilerias.ObtenerUsuario
                    lLoteTraspaso.FECHA_CREA = cFechaHora.ObtenerFechaHora
                    lLoteTraspaso.ID_MAESTRO = lLoteOld.ID_MAESTRO
                    lLoteTraspaso.TIPO_DERECHO = lLoteOld.TIPO_DERECHO
                    lLoteTraspaso.SUB_ZONA = lLoteOld.SUB_ZONA
                    lLoteTraspaso.ID_ZAFRA_TRASPASO = -1

                    'Código agregado para asignar la zafra activa en el traspaso
                    '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                    Dim lZafraActiva As ZAFRA = (New cZAFRA).ObtenerZafraActiva
                    If lZafraActiva IsNot Nothing Then
                        Dim lZafraContra As CONTRATO_ZAFRAS = (New cCONTRATO_ZAFRAS).ObtenerCONTRATO_ZAFRASPorZAFRA_CONTRATO(lZafraActiva.ID_ZAFRA, aEntidad.CODICONTRATO)
                        If lZafraContra IsNot Nothing Then
                            lLoteTraspaso.ID_ZAFRA_TRASPASO = lZafraActiva.ID_ZAFRA
                        End If
                    End If
                    '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

                    If bLotesTraspaso.ActualizarLOTES_TRASPASO(lLoteTraspaso) > 0 Then
                        aEntidad.ID_LOTE_TRASPASO = lLoteTraspaso.ID_LOTE_TRASPASO
                    End If

                    'Actualizar lotes cosecha por si ya hay censo
                    EsTraspaso = True
                End If
                lRet = mDb.Actualizar(aEntidad, aTipoConcurrencia)
            End If

            'Agrega o Actualiza registro en tabla Lotes Cosecha
            'If lRet <> -1 Then
            '    lRet = GenerarLoteDeCosecha(aEntidad, EsTraspaso)
            'End If
            Return lRet

        Catch ex As Exception
            Me.sError = ex.Message
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    Private Function GenerarLoteDeCosecha(ByVal aEntidad As LOTES, Optional EsTraspaso As Boolean = False) As Int32
        Dim lMaestro As MAESTRO_LOTES
        Dim lLoteCosecha As LOTES_COSECHA
        Dim lLoteCosechaMaestro As New LOTES_COSECHA
        Dim lZafraActiva As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        Dim lZafraAnterior As ZAFRA
        Dim bLotesCosecha As New cLOTES_COSECHA
        Dim RendCosecha As Decimal = 0
        Dim lRet As Integer = 1


        If lZafraActiva IsNot Nothing Then
            lZafraAnterior = (New cZAFRA).ObtenerZafraAnterior(lZafraActiva.ID_ZAFRA)
            lMaestro = (New cMAESTRO_LOTES).ObtenerMAESTRO_LOTES(aEntidad.ID_MAESTRO)

            'Verificar si el lote está contratado para la zafra activa
            Dim lContratosZafra As listaCONTRATO_ZAFRAS = (New cCONTRATO_ZAFRAS).ObtenerListaPorCONTRATO(aEntidad.CODICONTRATO)
            If lContratosZafra IsNot Nothing AndAlso lContratosZafra.Count > 0 Then

                For Each lContratoZ As CONTRATO_ZAFRAS In lContratosZafra
                    If lContratoZ.ID_ZAFRA = lZafraActiva.ID_ZAFRA Then
                        'Verificar que si existe el lote de cosecha para la zafra actual
                        lLoteCosecha = (New cLOTES_COSECHA).ObtenerLOTES_COSECHAPorLOTE_ZAFRA(aEntidad.ACCESLOTE, lContratoZ.ID_ZAFRA)

                        If lZafraAnterior IsNot Nothing Then
                            lLoteCosechaMaestro = (New cLOTES_COSECHA).ObtenerLOTES_COSECHAPorMAESTRO_ZAFRA(lMaestro.ID_MAESTRO, lZafraAnterior.ID_ZAFRA)
                        Else
                            lLoteCosechaMaestro = Nothing
                        End If

                        If lLoteCosecha Is Nothing Then
                            RendCosecha = bLotesCosecha.ObtenerREND_COSECHA_UltimaZafra(aEntidad.ID_MAESTRO, lZafraActiva.ID_ZAFRA)
                            If RendCosecha = 0 Then RendCosecha = bLotesCosecha.ObtenerREND_COSECHA_SUB_ZONA(aEntidad.SUB_ZONA, lZafraActiva.ID_ZAFRA)
                            lLoteCosecha = New LOTES_COSECHA
                            lLoteCosecha.ID_LOTES_COSECHA = 0
                            lLoteCosecha.ACCESLOTE = aEntidad.ACCESLOTE
                            lLoteCosecha.ID_ZAFRA = lZafraActiva.ID_ZAFRA
                            lLoteCosecha.FECHA_ROZA = lMaestro.FECHA_CORTE
                            lLoteCosecha.REND_COSECHA = RendCosecha
                            lLoteCosecha.MZ_ENTREGAR = aEntidad.AREA
                            lLoteCosecha.TONEL_MZ_ENTREGAR = aEntidad.TONELADAS
                            lLoteCosecha.TONEL_ENTREGAR = aEntidad.TONEL_TC
                            lLoteCosecha.LBS_ENTREGAR = aEntidad.TONEL_TC * RendCosecha
                            lLoteCosecha.VALOR_ENTREGAR = lLoteCosecha.LBS_ENTREGAR * lZafraActiva.PRECIO_LIBRA_AZUCAR
                            lLoteCosecha.MZ_ENTREGADA = 0
                            lLoteCosecha.TONEL_MZ_ENTREGADA = 0
                            lLoteCosecha.TONEL_ENTREGADA = 0
                            lLoteCosecha.LBS_ENTREGADA = 0
                            lLoteCosecha.VALOR_ENTREGADA = 0
                            lLoteCosecha.MZ_CENSO = lLoteCosecha.MZ_ENTREGAR + lLoteCosecha.MZ_ENTREGADA
                            lLoteCosecha.TONEL_MZ_CENSO = aEntidad.TONELADAS
                            lLoteCosecha.TONEL_CENSO = aEntidad.TONEL_TC + lLoteCosecha.TONEL_ENTREGADA
                            lLoteCosecha.LBS_CENSO = (aEntidad.TONEL_TC + lLoteCosecha.TONEL_ENTREGADA) * RendCosecha
                            lLoteCosecha.VALOR_CENSO = lLoteCosecha.LBS_CENSO * lZafraActiva.PRECIO_LIBRA_AZUCAR
                            lLoteCosecha.FIN_LOTE = False
                            lLoteCosecha.USUARIO_CREA = Utilerias.ObtenerUsuario
                            lLoteCosecha.FECHA_CREA = cFechaHora.ObtenerFechaHora
                            lLoteCosecha.USUARIO_ACT = Utilerias.ObtenerUsuario
                            lLoteCosecha.FECHA_ACT = cFechaHora.ObtenerFechaHora
                            lLoteCosecha.CODIAGRON = If(lLoteCosechaMaestro IsNot Nothing, lLoteCosechaMaestro.CODIAGRON, lMaestro.CODIAGRON)
                            lLoteCosecha.FECHA_SIEMBRA = lMaestro.FECHA_SIEMBRA
                            lLoteCosecha.ID_TIPO_CANA = lMaestro.ID_TIPO_CANA
                            lLoteCosecha.ID_TIPO_ROZA = lMaestro.ID_TIPO_ROZA
                            lLoteCosecha.ID_TIPO_ALZA = lMaestro.ID_TIPO_ALZA
                            lLoteCosecha.ID_TIPO_TRANS = lMaestro.ID_TIPO_TRANS
                            lLoteCosecha.TARIFA_ROZA = lMaestro.TARIFA_ROZA
                            lLoteCosecha.TARIFA_ALZA = lMaestro.TARIFA_ALZA
                            lLoteCosecha.TARIFA_TRANS = lMaestro.TARIFA_TRANS
                            lLoteCosecha.TARIFA_CORTA = lMaestro.TARIFA_CORTA
                            lLoteCosecha.TARIFA_LARGA = lMaestro.TARIFA_LARGA
                            lLoteCosecha.SALDO_ROZA = 0
                            lLoteCosecha.EDAD_LOTE = aEntidad.EDAD_LOTE
                            lLoteCosecha.TONEL_SALDO_VAR = 0
                            lLoteCosecha.TONEL_SEMILLA = 0
                            lLoteCosecha.HORAS_GRACIA_ENTREGA = 0
                            lRet = bLotesCosecha.ActualizarLOTES_COSECHA(lLoteCosecha)
                        Else
                            'Si existe censo de este lote en la zafra activa entonces no actualizar
                            Dim lCensoLote As CENSO_LOTES = (New cCENSO_LOTES).ObtenerPorZAFRA_LOTE(lZafraActiva.ID_ZAFRA, aEntidad.ACCESLOTE)

                            If lCensoLote Is Nothing OrElse EsTraspaso Then
                                lLoteCosecha.ACCESLOTE = aEntidad.ACCESLOTE
                                lLoteCosecha.ID_ZAFRA = lZafraActiva.ID_ZAFRA
                                lLoteCosecha.MZ_ENTREGAR = aEntidad.AREA
                                lLoteCosecha.TONEL_MZ_ENTREGAR = aEntidad.TONELADAS
                                lLoteCosecha.TONEL_ENTREGAR = aEntidad.TONEL_TC
                                lLoteCosecha.LBS_ENTREGAR = aEntidad.TONEL_TC * lLoteCosecha.REND_COSECHA
                                lLoteCosecha.VALOR_ENTREGAR = lLoteCosecha.LBS_ENTREGAR * lZafraActiva.PRECIO_LIBRA_AZUCAR
                                lLoteCosecha.MZ_CENSO = lLoteCosecha.MZ_ENTREGAR + lLoteCosecha.MZ_ENTREGADA
                                lLoteCosecha.TONEL_CENSO = (lLoteCosecha.TONEL_ENTREGAR + lLoteCosecha.TONEL_ENTREGADA)
                                lLoteCosecha.LBS_CENSO = (lLoteCosecha.TONEL_ENTREGAR + lLoteCosecha.TONEL_ENTREGADA) * lLoteCosecha.REND_COSECHA
                                If lLoteCosecha.MZ_CENSO > 0 Then
                                    lLoteCosecha.TONEL_MZ_CENSO = Math.Round(lLoteCosecha.TONEL_CENSO / lLoteCosecha.MZ_CENSO, 2)
                                Else
                                    lLoteCosecha.TONEL_MZ_CENSO = lLoteCosecha.TONEL_MZ_ENTREGAR
                                End If
                                lLoteCosecha.VALOR_CENSO = lLoteCosecha.LBS_CENSO * lLoteCosecha.REND_COSECHA
                                'lLoteCosecha.ID_TIPO_CANA = lMaestro.ID_TIPO_CANA
                                'lLoteCosecha.ID_TIPO_ROZA = lMaestro.ID_TIPO_ROZA
                                'lLoteCosecha.ID_TIPO_ALZA = lMaestro.ID_TIPO_ALZA
                                'lLoteCosecha.ID_TIPO_TRANS = lMaestro.ID_TIPO_TRANS
                                'lLoteCosecha.TARIFA_ROZA = lMaestro.TARIFA_ROZA
                                'lLoteCosecha.TARIFA_ALZA = lMaestro.TARIFA_ALZA
                                'lLoteCosecha.TARIFA_TRANS = lMaestro.TARIFA_TRANS
                                'lLoteCosecha.TARIFA_CORTA = lMaestro.TARIFA_CORTA
                                'lLoteCosecha.TARIFA_LARGA = lMaestro.TARIFA_LARGA
                                lLoteCosecha.USUARIO_ACT = Utilerias.ObtenerUsuario
                                lLoteCosecha.FECHA_ACT = cFechaHora.ObtenerFechaHora
                                lRet = bLotesCosecha.ActualizarLOTES_COSECHA(lLoteCosecha)
                            Else
                                lRet = 1
                            End If
                        End If

                        If lRet <= -1 Then
                            Me.sError = "Ocurrio un error al generar o actualizar el historico de lote cosecha para la Zafra " + lZafraActiva.NOMBRE_ZAFRA + ": " + bLotesCosecha.sError
                            Return -1
                        End If
                    End If
                Next
            End If
        End If

        Return lRet
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Actualiza un registro que recibe de parámetro.
    ''' </summary>
    ''' <remarks>Si es una tabla de Muchos a Muchos este método unicamente actualiza el 
    ''' registro. Si no es una tabla de Muchos a Muchos puede Actualizar o insertar un 
    ''' registro, dependiendo si la llave única trae un valor de Cero(0) para ser 
    ''' autoincrementada por el método de la Clase de Acceso a Datos.</remarks>
    ''' <history>
    ''' 	[GenApp]	18/07/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarLOTES(ByVal ACCESLOTE As String, ByVal ANIOZAFRA As String, ByVal CODIPROVEEDOR As String, ByVal CODILOTE As String, ByVal CODIAGRON As String, ByVal CODIVARIEDA As String, ByVal CODIUBICACION As String, ByVal CODICONTRATO As String, ByVal NOMBLOTE As String, ByVal AREA As Decimal, ByVal TONELADAS As Decimal, ByVal TONEL_TC As Decimal, ByVal ZONA As String, ByVal EDAD_LOTE As Decimal, ByVal FFCHPROXENT As DateTime, ByVal TONXENTREGAR As Decimal, ByVal ENTREGADA As Int32, ByVal USER_CREA As Int32, ByVal FECHA_CREA As DateTime, ByVal USER_ACT As Int32, ByVal FECHA_ACT As DateTime, ByVal fin_lote As Boolean, ByVal REND_CONTRATADO As Decimal, ByVal LBS_CONTRATADO As Decimal, ByVal VALOR_CONTRATADO As Decimal, ByVal REND_ENTREGADA As Decimal, ByVal MZ_ENTREGADA As Decimal, ByVal TONEL_MZ_ENTREGADA As Decimal, ByVal TONEL_ENTREGADA As Decimal, ByVal LBS_ENTREGADA As Decimal, ByVal VALOR_ENTREGADA As Decimal, ByVal ID_MAESTRO As Int32, ByVal TIPO_DERECHO As Int32, ByVal SUB_ZONA As String, ByVal ID_LOTE_TRASPASO As Int32, ByVal AREA_CANA As Decimal) As Integer
        Try
            Dim lEntidad As New LOTES
            lEntidad.ACCESLOTE = ACCESLOTE
            lEntidad.ANIOZAFRA = ANIOZAFRA
            lEntidad.CODIPROVEEDOR = CODIPROVEEDOR
            lEntidad.CODILOTE = CODILOTE
            lEntidad.CODIAGRON = CODIAGRON
            lEntidad.CODIVARIEDA = CODIVARIEDA
            lEntidad.CODIUBICACION = CODIUBICACION
            lEntidad.CODICONTRATO = CODICONTRATO
            lEntidad.NOMBLOTE = NOMBLOTE
            lEntidad.AREA = AREA
            lEntidad.TONELADAS = TONELADAS
            lEntidad.TONEL_TC = TONEL_TC
            lEntidad.ZONA = ZONA
            lEntidad.EDAD_LOTE = EDAD_LOTE
            lEntidad.USER_CREA = USER_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USER_ACT = USER_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            lEntidad.ID_MAESTRO = ID_MAESTRO
            lEntidad.TIPO_DERECHO = TIPO_DERECHO
            lEntidad.SUB_ZONA = SUB_ZONA
            lEntidad.ID_LOTE_TRASPASO = ID_LOTE_TRASPASO
            lEntidad.AREA_CANA = AREA_CANA
            Return Me.ActualizarLOTES(lEntidad)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function
End Class
