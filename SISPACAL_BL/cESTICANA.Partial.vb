Partial Public Class cESTICANA

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerListaParaIngresoInventario(ByVal ID_ZAFRA As Int32,
                                             ByVal ZONA As String,
                                             ByVal CODIPROVEE As String,
                                             ByVal CODISOCIO As String,
                                             ByVal NOMBRE_PROVEEDOR As String) As listaESTICANA
        Try
            Return mDb.ObtenerListaParaIngresoInventario(ID_ZAFRA, ZONA, CODIPROVEE, CODISOCIO, NOMBRE_PROVEEDOR)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerListaPorCriterios(ByVal ID_ZAFRA As Int32,
                                             ByVal ZONA As String,
                                             ByVal CODIPROVEE As String,
                                             ByVal CODISOCIO As String,
                                             ByVal NOMBRE_PROVEEDOR As String,
                                             ByVal NOMBLOTE As String,
                                             ByVal NO_CONTRATO As Int32,
                                             ByVal CODIAGRON As String) As listaESTICANA
        Try
            Return mDb.ObtenerListaPorCriterios(ID_ZAFRA, ZONA, CODIPROVEE, CODISOCIO, NOMBRE_PROVEEDOR, NOMBLOTE, NO_CONTRATO, CODIAGRON)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function


    Public Function ActualizarTONELADAS_ENTREGADAS(ByVal ID_ZAFRA As Int32, ByVal ACCESLOTE As String) As Integer
        Try
            Return mDb.ActualizarTONELADAS_ENTREGADAS(ID_ZAFRA, ACCESLOTE)
        Catch ex As Exception
            Me.sError = ex.Message
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    Public Function ObtenerListaPorCONTRATO_ZAFRA(ByVal CODICONTRATO As String, ByVal ID_ZAFRA As Int32) As listaESTICANA
        Try
            Return mDb.ObtenerListaPorCONTRATO_ZAFRA(CODICONTRATO, ID_ZAFRA)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ObtenerAutorizacionEntrega(ByVal ID_ZAFRA As Integer, ByVal ACCESSLOTE As String) As String
        Try
            Dim lLoteCosecha As ESTICANA = Me.ObtenerESTICANAPorLOTE_ZAFRA(ACCESSLOTE, ID_ZAFRA)
            Dim finLote As Boolean = False

            If lLoteCosecha IsNot Nothing Then
                If lLoteCosecha.FIN_LOTE Then
                    If lLoteCosecha.FECHA_CIERRE = #12:00:00 AM# Then
                        Return "El lote esta cerrado para esta zafra"
                    ElseIf DateAdd(DateInterval.Hour, lLoteCosecha.HORAS_GRACIA_ENTREGA, lLoteCosecha.FECHA_CIERRE) < cFechaHora.ObtenerFechaHora Then
                        Return "El lote esta cerrado para esta zafra y sobrepasa las " + CStr(Enumeradores.Parametros.HorasPostCierreEntrega + lLoteCosecha.HORAS_GRACIA_ENTREGA) + " horas desde su cierre"
                    End If
                End If
            End If
            Return ""

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
    ''' 	[GenApp]	27/10/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)>
    Public Function ActualizarESTICANA(ByVal aEntidad As ESTICANA) As Integer
        Try
            Return Me.ActualizarESTICANA(aEntidad, TipoConcurrencia.Pesimistica)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    Public Function ActualizarReferenciasESTICANA(ByVal ACCESLOTE_OLD As String, ByVal ACCESLOTE_NEW As String) As Integer
        Try
            Return mDb.ActualizarReferenciasESTICANA(ACCESLOTE_OLD, ACCESLOTE_NEW)
        Catch ex As Exception
            Me.sError = ex.Message
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
    ''' 	[GenApp]	27/10/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)>
    Public Function ActualizarESTICANA(ByVal aEntidad As ESTICANA, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            'Actualizar periodo de fabrica en lotes cosecha
            Dim asigPERIODO_FABRICA As Boolean = False
            Dim loteCosechaAntesAct As ESTICANA

            If aEntidad.ID_ESTICANA = 0 Then
                asigPERIODO_FABRICA = True
                loteCosechaAntesAct = Nothing
            Else
                loteCosechaAntesAct = (New cESTICANA).ObtenerESTICANA(aEntidad.ID_ESTICANA)
                If loteCosechaAntesAct IsNot Nothing AndAlso loteCosechaAntesAct.FECHA_ROZA <> aEntidad.FECHA_ROZA Then
                    asigPERIODO_FABRICA = True
                End If
            End If
            If asigPERIODO_FABRICA Then
                Dim lPeriodoFabrica As CICLO_PERIODO = (New cCICLO_PERIODO).ObtenerCICLO_PERIODOPorFechaTipo(aEntidad.FECHA_ROZA, Enumeradores.TipoCiclo.Fabrica)
                If lPeriodoFabrica IsNot Nothing Then
                    aEntidad.FAB_SEMANA = lPeriodoFabrica.SEMANA
                    aEntidad.FAB_CATORCENA = lPeriodoFabrica.CATORCENA
                    aEntidad.FAB_SUBTERCIO = lPeriodoFabrica.SUB_TERCIO
                    aEntidad.FAB_TERCIO = lPeriodoFabrica.TERCIO
                Else
                    aEntidad.FAB_SEMANA = -1
                    aEntidad.FAB_CATORCENA = -1
                    aEntidad.FAB_SUBTERCIO = Nothing
                    aEntidad.FAB_TERCIO = -1
                End If
            End If

            If loteCosechaAntesAct IsNot Nothing Then
                If aEntidad.FIN_LOTE Then
                    aEntidad.TONEL_CENSO = aEntidad.MZ_CENSO * aEntidad.TONEL_MZ_CENSO
                    aEntidad.TONEL_SALDO_VAR = aEntidad.TONEL_CENSO - aEntidad.TONEL_SEMILLA - loteCosechaAntesAct.TONEL_ENTREGADA
                    aEntidad.MZ_ENTREGAR = 0
                    aEntidad.TONEL_MZ_ENTREGAR = 0
                    aEntidad.TONEL_ENTREGAR = 0
                    If Not loteCosechaAntesAct.FIN_LOTE Then aEntidad.FECHA_CIERRE = cFechaHora.ObtenerFecha
                    aEntidad.HORAS_GRACIA_ENTREGA = 0
                ElseIf Not aEntidad.FIN_LOTE Then
                    aEntidad.TONEL_CENSO = aEntidad.MZ_CENSO * aEntidad.TONEL_MZ_CENSO
                    aEntidad.TONEL_SALDO_VAR = 0
                    aEntidad.TONEL_ENTREGAR = aEntidad.TONEL_CENSO - aEntidad.TONEL_SEMILLA - loteCosechaAntesAct.TONEL_ENTREGADA
                    If aEntidad.TONEL_ENTREGAR = 0 Then
                        aEntidad.TONEL_MZ_ENTREGAR = 0
                        aEntidad.MZ_ENTREGAR = 0
                    Else
                        aEntidad.TONEL_MZ_ENTREGAR = IIf(aEntidad.TONEL_MZ_CENSO = 0, 0, Math.Round(aEntidad.TONEL_ENTREGAR / aEntidad.TONEL_MZ_CENSO, 2))
                        aEntidad.MZ_ENTREGAR = IIf(aEntidad.TONEL_MZ_ENTREGAR = 0, 0, Math.Round(aEntidad.TONEL_ENTREGAR / aEntidad.TONEL_MZ_ENTREGAR, 2))
                    End If
                    aEntidad.FECHA_CIERRE = Nothing
                    aEntidad.HORAS_GRACIA_ENTREGA = 0
                End If
                If aEntidad.TONEL_SEMILLA > 0 Then
                    aEntidad.TONEL_CENSO = aEntidad.TONEL_CENSO - aEntidad.TONEL_SEMILLA
                End If
            End If

            Return mDb.Actualizar(aEntidad, aTipoConcurrencia)
        Catch ex As Exception
            Me.sError = ex.Message
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    Public Function ObtenerUltimaCosechaPorLOTE_FinLote(ByVal ID_MAESTRO As Int32, ByVal ESTADO_LOTE As String, Optional ID_ZAFRA As Int32 = -1) As listaESTICANA
        Try
            Return mDb.ObtenerUltimaCosechaPorLOTE_FinLote(ID_MAESTRO, ESTADO_LOTE, ID_ZAFRA)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ObtenerESTICANAPorLOTE_ZAFRA(ByVal ACCESLOTE As String, ByVal ID_ZAFRA As Int32) As ESTICANA
        Try
            Return mDb.ObtenerESTICANAPorLOTE_ZAFRA(ACCESLOTE, ID_ZAFRA)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ObtenerESTICANAPorMAESTRO_ZAFRA(ByVal ID_MAESTRO As Int32, ByVal ID_ZAFRA As Int32) As ESTICANA
        Try
            Return mDb.ObtenerESTICANAPorMAESTRO_ZAFRA(ID_MAESTRO, ID_ZAFRA)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ObtenerTOTAL_PLAN_COSECHAPorZAFRA(ByVal ID_ZAFRA As Int32) As ESTICANA
        Try
            Return mDb.ObtenerTOTAL_PLAN_COSECHAPorZAFRA(ID_ZAFRA)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ObtenerREND_COSECHA_UltimaZafra(ByVal ID_MAESTRO As Int32, ByVal ID_ZAFRA As Int32) As Decimal
        Try
            Return mDb.ObtenerREND_COSECHA_UltimaZafra(ID_MAESTRO, ID_ZAFRA)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return 0
        End Try
    End Function

    Public Function ObtenerREND_COSECHA_SUB_ZONA(ByVal SUB_ZONA As String, ByVal ID_ZAFRA As Int32) As Decimal
        Try
            Return mDb.ObtenerREND_COSECHA_SUB_ZONA(SUB_ZONA, ID_ZAFRA)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return 0
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerListaProforma(ByVal ID_ZAFRA As Int32, ByVal TIPOS_TRANSPORTE As String, ByVal CON_SALDO_ROZA As Boolean) As listaESTICANA
        Try
            Return mDb.ObtenerListaProforma(ID_ZAFRA, TIPOS_TRANSPORTE, CON_SALDO_ROZA)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ObtenerEJECUCION_ALZA(ByVal ID_ZAFRA As Int32) As Dictionary(Of String, Dictionary(Of String, Decimal))
        Try
            Return mDb.ObtenerEJECUCION_ALZA(ID_ZAFRA)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try

    End Function

    Public Function ObtenerEJECUCION_TRANSPORTE(ByVal ID_ZAFRA As Int32) As Dictionary(Of String, Dictionary(Of String, Decimal))
        Try
            Return mDb.ObtenerEJECUCION_TRANSPORTE(ID_ZAFRA)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

End Class

