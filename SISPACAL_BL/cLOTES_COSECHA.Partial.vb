Partial Public Class cLOTES_COSECHA

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
   Public Function ObtenerListaParaIngresoInventario(ByVal ID_ZAFRA As Int32, _
                                             ByVal ZONA As String, _
                                             ByVal CODIPROVEE As String, _
                                             ByVal CODISOCIO As String, _
                                             ByVal NOMBRE_PROVEEDOR As String) As listaLOTES_COSECHA
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
                                             ByVal CODIAGRON As String,
                                             ByVal USUARIO As String) As listaLOTES_COSECHA
        Try
            Return mDb.ObtenerListaPorCriterios(ID_ZAFRA, ZONA, CODIPROVEE, CODISOCIO, NOMBRE_PROVEEDOR, NOMBLOTE, NO_CONTRATO, CODIAGRON, USUARIO)
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

    Public Function ObtenerListaPorCONTRATO_ZAFRA(ByVal CODICONTRATO As String, ByVal ID_ZAFRA As Int32) As listaLOTES_COSECHA
        Try
            Return mDb.ObtenerListaPorCONTRATO_ZAFRA(CODICONTRATO, ID_ZAFRA)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ObtenerAutorizacionEntrega(ByVal ID_ZAFRA As Integer, ByVal ACCESSLOTE As String) As String
        Try
            Dim lLoteCosecha As LOTES_COSECHA = Me.ObtenerLOTES_COSECHAPorLOTE_ZAFRA(ACCESSLOTE, ID_ZAFRA)
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
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarLOTES_COSECHA(ByVal aEntidad As LOTES_COSECHA) As Integer
        Try
            Return Me.ActualizarLOTES_COSECHA(aEntidad, TipoConcurrencia.Pesimistica)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    Public Function ActualizarReferenciasLOTES_COSECHA(ByVal ACCESLOTE_OLD As String, ByVal ACCESLOTE_NEW As String) As Integer
        Try
            Return mDb.ActualizarReferenciasLOTES_COSECHA(ACCESLOTE_OLD, ACCESLOTE_NEW)
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
    Public Function ActualizarLOTES_COSECHA(ByVal aEntidad As LOTES_COSECHA, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            'Actualizar periodo de fabrica en lotes cosecha
            Dim asigPERIODO_FABRICA As Boolean = False
            Dim loteCosechaAntesAct As LOTES_COSECHA

            If aEntidad.ID_LOTES_COSECHA = 0 Then
                asigPERIODO_FABRICA = True
                loteCosechaAntesAct = Nothing
            Else
                loteCosechaAntesAct = (New cLOTES_COSECHA).ObtenerLOTES_COSECHA(aEntidad.ID_LOTES_COSECHA)
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
                    'aEntidad.TONEL_CENSO = aEntidad.MZ_CENSO * aEntidad.TONEL_MZ_CENSO
                    'aEntidad.TONEL_SALDO_VAR = aEntidad.TONEL_CENSO - aEntidad.TONEL_SEMILLA - loteCosechaAntesAct.TONEL_ENTREGADA
                    'aEntidad.MZ_ENTREGAR = 0
                    'aEntidad.TONEL_MZ_ENTREGAR = 0
                    'aEntidad.TONEL_ENTREGAR = 0
                    If Not loteCosechaAntesAct.FIN_LOTE Then aEntidad.FECHA_CIERRE = cFechaHora.ObtenerFecha
                    aEntidad.HORAS_GRACIA_ENTREGA = 0
                ElseIf Not aEntidad.FIN_LOTE Then
                    'aEntidad.TONEL_CENSO = aEntidad.MZ_CENSO * aEntidad.TONEL_MZ_CENSO
                    'aEntidad.TONEL_SALDO_VAR = 0
                    'aEntidad.TONEL_ENTREGAR = aEntidad.TONEL_CENSO - aEntidad.TONEL_SEMILLA - loteCosechaAntesAct.TONEL_ENTREGADA
                    'If aEntidad.TONEL_ENTREGAR = 0 Then
                    '    aEntidad.TONEL_MZ_ENTREGAR = 0
                    '    aEntidad.MZ_ENTREGAR = 0
                    'Else
                    '    'aEntidad.TONEL_MZ_ENTREGAR = IIf(aEntidad.TONEL_MZ_CENSO = 0, 0, Math.Round(aEntidad.TONEL_ENTREGAR / aEntidad.TONEL_MZ_CENSO, 2))
                    '    'aEntidad.MZ_ENTREGAR = IIf(aEntidad.TONEL_MZ_ENTREGAR = 0, 0, Math.Round(aEntidad.TONEL_ENTREGAR / aEntidad.TONEL_MZ_ENTREGAR, 2))
                    'End If
                    aEntidad.FECHA_CIERRE = Nothing
                    aEntidad.HORAS_GRACIA_ENTREGA = 0
                End If
                'If aEntidad.TONEL_SEMILLA > 0 Then
                '    aEntidad.TONEL_CENSO = aEntidad.TONEL_CENSO - aEntidad.TONEL_SEMILLA
                'End If
            End If

            Return mDb.Actualizar(aEntidad, aTipoConcurrencia)
        Catch ex As Exception
            Me.sError = ex.Message
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)>
    Public Function ActualizarLOTES_COSECHA2(ByVal ID_LOTES_COSECHA As Int32, ByVal ACCESLOTE As String, ByVal ID_ZAFRA As Int32, ByVal FECHA_ROZA As DateTime, ByVal REND_COSECHA As Decimal,
                                            ByVal MZ_ENTREGAR As Decimal, ByVal TONEL_MZ_ENTREGAR As Decimal, ByVal TONEL_ENTREGAR As Decimal, ByVal LBS_ENTREGAR As Decimal,
                                            ByVal VALOR_ENTREGAR As Decimal, ByVal MZ_ENTREGADA As Decimal, ByVal TONEL_MZ_ENTREGADA As Decimal, ByVal TONEL_ENTREGADA As Decimal,
                                            ByVal LBS_ENTREGADA As Decimal, ByVal VALOR_ENTREGADA As Decimal, ByVal MZ_CENSO As Decimal, ByVal TONEL_MZ_CENSO As Decimal, ByVal TONEL_CENSO As Decimal,
                                            ByVal LBS_CENSO As Decimal, ByVal VALOR_CENSO As Decimal, ByVal FIN_LOTE As Boolean,
                                            ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime,
                                            ByVal CODIAGRON As String, ByVal FECHA_SIEMBRA As DateTime, ByVal ID_TIPO_CANA As Int32, ByVal ID_TIPO_ROZA As Int32,
                                            ByVal ID_TIPO_ALZA As Int32, ByVal ID_TIPO_TRANS As Int32, ByVal FAB_SEMANA As Int32, ByVal FAB_CATORCENA As Int32,
                                            ByVal FAB_SUBTERCIO As String, ByVal FAB_TERCIO As Int32, ByVal TARIFA_ROZA As Decimal, ByVal TARIFA_ALZA As Decimal,
                                            ByVal TARIFA_TRANS As Decimal, ByVal TARIFA_CORTA As Decimal, ByVal TARIFA_LARGA As Decimal, ByVal SALDO_ROZA As Decimal,
                                            ByVal EDAD_LOTE As Int32, ByVal SALDO_QUEMA As Decimal, ByVal FECHA_ROZA_DISPO As DateTime, ByVal TONEL_SALDO_VAR As Decimal,
                                            ByVal TONEL_SEMILLA As Decimal, ByVal FECHA_CIERRE As DateTime, ByVal HORAS_GRACIA_ENTREGA As Int32) As Integer
        Try
            Dim lEntidad As New LOTES_COSECHA
            lEntidad.ID_LOTES_COSECHA = ID_LOTES_COSECHA
            lEntidad.ACCESLOTE = ACCESLOTE
            lEntidad.ID_ZAFRA = ID_ZAFRA
            lEntidad.FECHA_ROZA = FECHA_ROZA
            lEntidad.REND_COSECHA = REND_COSECHA
            lEntidad.MZ_ENTREGAR = MZ_ENTREGAR
            lEntidad.TONEL_MZ_ENTREGAR = TONEL_MZ_ENTREGAR
            lEntidad.TONEL_ENTREGAR = TONEL_ENTREGAR
            lEntidad.LBS_ENTREGAR = LBS_ENTREGAR
            lEntidad.VALOR_ENTREGAR = VALOR_ENTREGAR
            lEntidad.MZ_ENTREGADA = MZ_ENTREGADA
            lEntidad.TONEL_MZ_ENTREGADA = TONEL_MZ_ENTREGADA
            lEntidad.TONEL_ENTREGADA = TONEL_ENTREGADA
            lEntidad.LBS_ENTREGADA = LBS_ENTREGADA
            lEntidad.VALOR_ENTREGADA = VALOR_ENTREGADA
            lEntidad.MZ_CENSO = MZ_CENSO
            lEntidad.TONEL_MZ_CENSO = TONEL_MZ_CENSO
            lEntidad.TONEL_CENSO = TONEL_CENSO
            lEntidad.LBS_CENSO = LBS_CENSO
            lEntidad.VALOR_CENSO = VALOR_CENSO
            lEntidad.FIN_LOTE = FIN_LOTE
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            lEntidad.CODIAGRON = CODIAGRON
            lEntidad.FECHA_SIEMBRA = FECHA_SIEMBRA
            lEntidad.ID_TIPO_CANA = ID_TIPO_CANA
            lEntidad.ID_TIPO_ROZA = ID_TIPO_ROZA
            lEntidad.ID_TIPO_ALZA = ID_TIPO_ALZA
            lEntidad.ID_TIPO_TRANS = ID_TIPO_TRANS
            lEntidad.FAB_SEMANA = FAB_SEMANA
            lEntidad.FAB_CATORCENA = FAB_CATORCENA
            lEntidad.FAB_SUBTERCIO = FAB_SUBTERCIO
            lEntidad.FAB_TERCIO = FAB_TERCIO
            lEntidad.TARIFA_ROZA = TARIFA_ROZA
            lEntidad.TARIFA_ALZA = TARIFA_ALZA
            lEntidad.TARIFA_TRANS = TARIFA_TRANS
            lEntidad.TARIFA_CORTA = TARIFA_CORTA
            lEntidad.TARIFA_LARGA = TARIFA_LARGA
            lEntidad.SALDO_ROZA = SALDO_ROZA
            lEntidad.EDAD_LOTE = EDAD_LOTE
            lEntidad.SALDO_QUEMA = SALDO_QUEMA
            lEntidad.FECHA_ROZA_DISPO = FECHA_ROZA_DISPO
            lEntidad.TONEL_SALDO_VAR = TONEL_SALDO_VAR
            lEntidad.TONEL_SEMILLA = TONEL_SEMILLA
            lEntidad.FECHA_CIERRE = FECHA_CIERRE
            lEntidad.HORAS_GRACIA_ENTREGA = HORAS_GRACIA_ENTREGA
            Return Me.ActualizarLOTES_COSECHA2(lEntidad, TipoConcurrencia.Pesimistica)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)>
    Public Function ActualizarLOTES_COSECHA2(ByVal aEntidad As LOTES_COSECHA, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            'Actualizar periodo de fabrica en lotes cosecha
            Dim asigPERIODO_FABRICA As Boolean = False
            Dim loteCosechaAntesAct As LOTES_COSECHA

            If aEntidad.ID_LOTES_COSECHA = 0 Then
                asigPERIODO_FABRICA = True
                loteCosechaAntesAct = Nothing
            Else
                loteCosechaAntesAct = (New cLOTES_COSECHA).ObtenerLOTES_COSECHA(aEntidad.ID_LOTES_COSECHA)
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
                    If Not loteCosechaAntesAct.FIN_LOTE Then aEntidad.FECHA_CIERRE = cFechaHora.ObtenerFecha
                    aEntidad.HORAS_GRACIA_ENTREGA = 0
                ElseIf Not aEntidad.FIN_LOTE Then
                    aEntidad.FECHA_CIERRE = Nothing
                    aEntidad.HORAS_GRACIA_ENTREGA = 0
                End If
            End If
            aEntidad.USUARIO_ACT = Utilerias.ObtenerUsuario
            aEntidad.FECHA_ACT = Now

            Return mDb.Actualizar(aEntidad, aTipoConcurrencia)
        Catch ex As Exception
            Me.sError = ex.Message
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    Public Function ObtenerUltimaCosechaPorLOTE_FinLote(ByVal ID_MAESTRO As Int32, ByVal ESTADO_LOTE As String, Optional ID_ZAFRA As Int32 = -1) As listaLOTES_COSECHA
        Try
            Return mDb.ObtenerUltimaCosechaPorLOTE_FinLote(ID_MAESTRO, ESTADO_LOTE, ID_ZAFRA)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ObtenerLOTES_COSECHAPorLOTE_ZAFRA(ByVal ACCESLOTE As String, ByVal ID_ZAFRA As Int32) As LOTES_COSECHA
        Try
            Return mDb.ObtenerLOTES_COSECHAPorLOTE_ZAFRA(ACCESLOTE, ID_ZAFRA)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ObtenerLOTES_COSECHAPorMAESTRO_ZAFRA(ByVal ID_MAESTRO As Int32, ByVal ID_ZAFRA As Int32) As LOTES_COSECHA
        Try
            Return mDb.ObtenerLOTES_COSECHAPorMAESTRO_ZAFRA(ID_MAESTRO, ID_ZAFRA)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ObtenerTOTAL_PLAN_COSECHAPorZAFRA(ByVal ID_ZAFRA As Int32) As LOTES_COSECHA
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

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaProforma(ByVal ID_ZAFRA As Int32, ByVal TIPOS_TRANSPORTE As String, ByVal CON_SALDO_ROZA As Boolean) As listaLOTES_COSECHA
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

    Public Function execXLS_COMPARATIVO_ZAFRA_ACTUAL_VS_ANTERIOR(ByVal idZafraInicial As Integer, ByVal idZafraFinal As Integer) As DataSet

        Try
            Return mDb.execXLS_COMPARATIVO_ZAFRA_ACTUAL_VS_ANTERIOR(idZafraInicial, idZafraFinal)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try

    End Function

    Public Function execXLS_APLICACION_TARIFA_FLETE_PRECORTE(ByVal ID_ZAFRA As Integer, ByVal NO_CATORCENA As Integer) As DataSet

        Try
            Return mDb.execXLS_APLICACION_TARIFA_FLETE_PRECORTE(ID_ZAFRA, NO_CATORCENA)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try

    End Function

    Public Function execXLS_APLICACION_TARIFA_CARGA_COSECHA_PRECORTE(ByVal ID_ZAFRA As Integer, ByVal NO_CATORCENA As Integer) As DataSet

        Try
            Return mDb.execXLS_APLICACION_TARIFA_CARGA_COSECHA_PRECORTE(ID_ZAFRA, NO_CATORCENA)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try

    End Function

    Public Function Actualizar_LOTES_COSECHA_Import_Excel(ByVal ID_ZAFRA As Integer, ByVal ID_ENCA As Integer) As String
        Try
            Return mDb.Actualizar_LOTES_COSECHA_Import_Excel(ID_ZAFRA, ID_ENCA)

        Catch ex As Exception
            Me.sError = ex.Message
            ExceptionManager.Publish(ex)
            Return Me.sError
        End Try
    End Function

End Class
