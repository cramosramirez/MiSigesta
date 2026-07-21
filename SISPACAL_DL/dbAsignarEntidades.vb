Friend Module dbAsignarEntidades

    Public Sub AsignarENVIO_ROZA_PS(ByVal dr As IDataReader, ByRef e As ENVIO_ROZA_PS, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New ENVIO_ROZA_PS
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_ENVIO_ROZA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ENVIO_ROZA", aliasTabla))))
        e.ID_ENVIO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ENVIO", aliasTabla)), -1))
        e.ID_TIPO_ROZA_P = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_ROZA_P", aliasTabla)), -1))
        e.ID_PROVEEDOR_ROZA_P = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PROVEEDOR_ROZA_P", aliasTabla)), -1))
        e.ID_TIPO_ROZA_S = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_ROZA_S", aliasTabla)), -1))
        e.ID_PROVEEDOR_ROZA_S = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PROVEEDOR_ROZA_S", aliasTabla)), -1))
        e.TARIFA_ROZA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TARIFA_ROZA", aliasTabla)), -1))
    End Sub

    Public Sub AsignarSOLIC_ANTICIPO_LIQFINAN(ByVal dr As IDataReader, ByRef e As SOLIC_ANTICIPO_LIQFINAN, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New SOLIC_ANTICIPO_LIQFINAN
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_ANTI_LIQ = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ANTI_LIQ", aliasTabla))))
        e.ID_ANTICIPO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ANTICIPO", aliasTabla)), -1))
        e.ID_CREDITO_ENCA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CREDITO_ENCA", aliasTabla)), -1))
        e.UID_REFERENCIA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}UID_REFERENCIA", aliasTabla))))
        e.SALDO_INI = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}SALDO_INI", aliasTabla)), -1))
        e.INTERES = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}INTERES", aliasTabla)), -1))
        e.INTERES_IVA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}INTERES_IVA", aliasTabla)), -1))
        e.ABONO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ABONO", aliasTabla)), -1))
        e.INTERES_ABO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}INTERES_ABO", aliasTabla)), -1))
        e.INTERES_IVA_ABO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}INTERES_IVA_ABO", aliasTabla)), -1))
        e.SALDO_FIN = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}SALDO_FIN", aliasTabla)), -1))
    End Sub

    Public Sub AsignarNOTACARGO_PLANILLA(ByVal dr As IDataReader, ByRef e As NOTACARGO_PLANILLA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New NOTACARGO_PLANILLA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_NOTACARGO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_NOTACARGO", aliasTabla))))
        e.MONTO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MONTO", aliasTabla)), -1))
        e.CANTIDAD_LETRAS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CANTIDAD_LETRAS", aliasTabla))))
        e.TITULAR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TITULAR", aliasTabla))))
        e.ESTADO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ESTADO", aliasTabla))))
        e.FECHA_EMISION = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_EMISION", aliasTabla))))
        e.FECHA_ANULACION = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ANULACION", aliasTabla))))
        e.MOTIVO_ANULACION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}MOTIVO_ANULACION", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.NO_PARTIDA_PH = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}NO_PARTIDA_PH", aliasTabla)), -1))
        e.ID_CATORCENA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CATORCENA", aliasTabla)), -1))
        e.ID_TIPO_PLANILLA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_PLANILLA", aliasTabla)), -1))
        e.CODIPROVEEDOR_TRANSPORTISTA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIPROVEEDOR_TRANSPORTISTA", aliasTabla))))
        e.NUM_AUTORIZA_BCO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}NUM_AUTORIZA_BCO", aliasTabla)), -1))
        e.ID_CUENTA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CUENTA", aliasTabla)), -1))
    End Sub

    Public Sub AsignarNOTACARGO_PARTIDA(ByVal dr As IDataReader, ByRef e As NOTACARGO_PARTIDA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New NOTACARGO_PARTIDA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_NOTACARGO_PARTIDA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_NOTACARGO_PARTIDA", aliasTabla))))
        e.ID_NOTACARGO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_NOTACARGO", aliasTabla))))
        e.ORDEN = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ORDEN", aliasTabla)), -1))
        e.CUENTA_CONTABLE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CUENTA_CONTABLE", aliasTabla))))
        e.DESCRIPCION_CUENTA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DESCRIPCION_CUENTA", aliasTabla))))
        e.DESCRIPCION_ADICIONAL = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DESCRIPCION_ADICIONAL", aliasTabla))))
        e.DEBE = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}DEBE", aliasTabla)), -1))
        e.HABER = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}HABER", aliasTabla)), -1))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub

    Public Sub AsignarENVIO_SEDIMENTO(ByVal dr As IDataReader, ByRef e As ENVIO_SEDIMENTO, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New ENVIO_SEDIMENTO
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_ENVIO_SEDI = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ENVIO_SEDI", aliasTabla))))
        e.ID_ENVIO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ENVIO", aliasTabla)), -1))
        e.VOL_SEDIMENTO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}VOL_SEDIMENTO", aliasTabla)), -1))
        e.SEDIMENTO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}SEDIMENTO", aliasTabla)), -1))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
    End Sub
    Public Sub AsignarSUBLOTES(ByVal dr As IDataReader, ByRef e As SUBLOTES, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New SUBLOTES
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_SUBLOTES = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_SUBLOTES", aliasTabla))))
        e.ID_MAESTRO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_MAESTRO", aliasTabla)), -1))
        e.CODIGO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO", aliasTabla))))
        e.CORRELATIVO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}CORRELATIVO", aliasTabla)), -1))
        e.NOMBRE_PORCION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_PORCION", aliasTabla))))
        e.CODIVARIEDA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIVARIEDA", aliasTabla))))
        e.ID_TIPO_SIEMBRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_SIEMBRA", aliasTabla)), -1))
        e.FECHA_SIEMBRA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_SIEMBRA", aliasTabla))))
        e.DISTANCIAMIENTO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}DISTANCIAMIENTO", aliasTabla)), -1))
        e.CICLO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}CICLO", aliasTabla)), -1))
        e.ZONA_RAMSAR = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}ZONA_RAMSAR", aliasTabla)), 0))
        e.LONGITUD = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}LONGITUD", aliasTabla))))
        e.LATITUD = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}LATITUD", aliasTabla))))
        e.ALTITUD = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ALTITUD", aliasTabla))))
        e.ID_TIPO_SUELO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_SUELO", aliasTabla)), -1))
        e.ID_RIESGO_PIEDRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_RIESGO_PIEDRA", aliasTabla)), -1))
        e.ID_ESTRATO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ESTRATO", aliasTabla)), -1))
        e.ID_TOPOGRAFIA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TOPOGRAFIA", aliasTabla)), -1))
        e.VIABILIDAD_RIEGO = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}VIABILIDAD_RIEGO", aliasTabla)), 0))
        e.AREA_CONTRATO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}AREA_CONTRATO", aliasTabla)), -1))
        e.AREA_PRODUCTIVA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}AREA_PRODUCTIVA", aliasTabla)), -1))
        e.AREA_EFEC = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}AREA_EFEC", aliasTabla)), -1))
        e.TC_MZ_EFEC = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TC_MZ_EFEC", aliasTabla)), -1))
        e.TC_EFEC = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TC_EFEC", aliasTabla)), -1))
        e.ID_USO_MAD = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_USO_MAD", aliasTabla)), -1))
        e.ID_TIPO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO", aliasTabla)), -1))
        e.POTENCIAL_COSECHA_MECA = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}POTENCIAL_COSECHA_MECA", aliasTabla)), 0))
        e.TIPO_QUEMA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TIPO_QUEMA", aliasTabla))))
        e.ID_TIPO_TRANS_VMT = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_TRANS_VMT", aliasTabla)), -1))
        e.CIRCUITO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}CIRCUITO", aliasTabla)), -1))
        e.TARIFA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TARIFA", aliasTabla)), -1))
        e.CARRET_PPAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}CARRET_PPAL", aliasTabla)), -1))
        e.CARRET_SEC = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}CARRET_SEC", aliasTabla)), -1))
        e.REPARA_ACCESO = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}REPARA_ACCESO", aliasTabla)), 0))
        e.FECHA_COSECHA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_COSECHA", aliasTabla))))
        e.ES_CERRADO = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}ES_CERRADO", aliasTabla)), 0))
    End Sub
    Public Sub AsignarESTRATO(ByVal dr As IDataReader, ByRef e As ESTRATO, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New ESTRATO
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_ESTRATO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ESTRATO", aliasTabla))))
        e.NOMBRE_ESTRATO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_ESTRATO", aliasTabla))))
    End Sub

    Public Sub AsignarRIESGO_PIEDRA(ByVal dr As IDataReader, ByRef e As RIESGO_PIEDRA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New RIESGO_PIEDRA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_RIESGO_PIEDRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_RIESGO_PIEDRA", aliasTabla))))
        e.NOMBRE_RIESGO_PIEDRA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_RIESGO_PIEDRA", aliasTabla))))
    End Sub

    Public Sub AsignarTIPO_SIEMBRA(ByVal dr As IDataReader, ByRef e As TIPO_SIEMBRA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New TIPO_SIEMBRA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_TIPO_SIEMBRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_SIEMBRA", aliasTabla))))
        e.NOMBRE_TIPO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_TIPO", aliasTabla))))
    End Sub

    Public Sub AsignarTIPOSUELO(ByVal dr As IDataReader, ByRef e As TIPOSUELO, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New TIPOSUELO
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_TIPO_SUELO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_SUELO", aliasTabla))))
        e.NOMBRE_TIPO_SUELO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_TIPO_SUELO", aliasTabla))))
    End Sub

    Public Sub AsignarTIPO_TRANS_VMT(ByVal dr As IDataReader, ByRef e As TIPO_TRANS_VMT, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New TIPO_TRANS_VMT
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_TIPO_TRANS_VMT = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_TRANS_VMT", aliasTabla))))
        e.NOMBRE_TIPO_TRANS_VMT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_TIPO_TRANS_VMT", aliasTabla))))
    End Sub

    Public Sub AsignarTOPOGRAFIA(ByVal dr As IDataReader, ByRef e As TOPOGRAFIA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New TOPOGRAFIA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_TOPOGRAFIA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TOPOGRAFIA", aliasTabla))))
        e.NOMBRE_TOPOGRAFIA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_TOPOGRAFIA", aliasTabla))))
    End Sub

    Public Sub AsignarUSO_MADURANTE(ByVal dr As IDataReader, ByRef e As USO_MADURANTE, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New USO_MADURANTE
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_USO_MAD = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_USO_MAD", aliasTabla))))
        e.NOMBRE_USO_MAD = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_USO_MAD", aliasTabla))))
    End Sub

    Public Sub AsignarACUKARDE(ByVal dr As IDataReader, ByRef e As ACUKARDE, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New ACUKARDE
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID", aliasTabla))))
        e.CODIGO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO", aliasTabla))))
        e.MATERIAL = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}MATERIAL", aliasTabla))))
        e.TIPO_DOC = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TIPO_DOC", aliasTabla))))
        e.DOCUMENTO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}DOCUMENTO", aliasTabla)), -1))
        e.FECHA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA", aliasTabla))))
        e.UENT = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}UENT", aliasTabla)), -1))
        e.USAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}USAL", aliasTabla)), -1))
        e.SALDO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}SALDO", aliasTabla)), -1))
        e.VENT = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}VENT", aliasTabla)), -1))
        e.VSAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}VSAL", aliasTabla)), -1))
        e.VSALDO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}VSALDO", aliasTabla)), -1))
        e.PROMEDIO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PROMEDIO", aliasTabla)), -1))
        e.ORDEN = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ORDEN", aliasTabla)), -1))
        e.PROVEEDOR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}PROVEEDOR", aliasTabla))))
        e.CUENTA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CUENTA", aliasTabla))))
        e.NOMCUENTA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMCUENTA", aliasTabla))))
        e.UNIDAD = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}UNIDAD", aliasTabla))))
    End Sub

    Public Sub AsignarSOLIC_ENCA_FRENTE(ByVal dr As IDataReader, ByRef e As SOLIC_ENCA_FRENTE, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New SOLIC_ENCA_FRENTE
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If

        e.ID_SOLICITUD = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_SOLICITUD", aliasTabla))))
        e.ID_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA", aliasTabla)), -1))
        e.ZAFRA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ZAFRA", aliasTabla))))
        e.ID_CUENTA_FINAN = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CUENTA_FINAN", aliasTabla)), -1))
        e.NUM_SOLIC_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}NUM_SOLIC_ZAFRA", aliasTabla)), -1))
        e.ID_TIPO_PROVEEDOR = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_PROVEEDOR", aliasTabla)), -1))
        e.ID_FRENTE = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_FRENTE", aliasTabla)), -1))
        e.COD_FRENTE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}COD_FRENTE", aliasTabla))))
        e.NOM_FRENTE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOM_FRENTE", aliasTabla))))
        e.ACTIVIDAD = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ACTIVIDAD", aliasTabla))))
        e.FECHA_SOLIC = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_SOLIC", aliasTabla))))
        e.SUB_TOTAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}SUB_TOTAL", aliasTabla)), -1))
        e.IVA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}IVA", aliasTabla)), -1))
        e.TOTAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TOTAL", aliasTabla)), -1))
        e.ID_ESTADO_SOLIC = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ESTADO_SOLIC", aliasTabla)), -1))
        e.UID_SOLIC_ENCA_FRENTE = If(TypeOf ObtenerValor(dr.Item(String.Format("{0}UID_SOLIC_ENCA_FRENTE", aliasTabla))) Is Guid,
                                 CType(ObtenerValor(dr.Item(String.Format("{0}UID_SOLIC_ENCA_FRENTE", aliasTabla))), Guid?), Nothing)
        e.OBSERVACIONES = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}OBSERVACIONES", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.CUOTA_X_CORTE = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}CUOTA_X_CORTE", aliasTabla)), -1))
    End Sub

    Public Sub AsignarCCF_ENCA_FRENTE(ByVal dr As IDataReader, ByRef e As CCF_ENCA_FRENTE, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New CCF_ENCA_FRENTE
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If

        e.ID_CCF_ENCA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CCF_ENCA", aliasTabla))))
        e.ID_TIPO_PROVEEDOR = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_PROVEEDOR", aliasTabla)), -1))
        e.ID_FRENTE = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_FRENTE", aliasTabla)), -1))
        e.COD_FRENTE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}COD_FRENTE", aliasTabla))))
        e.NOM_FRENTE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOM_FRENTE", aliasTabla))))
        e.ID_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA", aliasTabla)), -1))
        e.ID_SOLICITUD = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_SOLICITUD", aliasTabla)), -1))
        e.ID_CUENTA_FINAN = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CUENTA_FINAN", aliasTabla)), -1))
        e.ID_TIPO_COMPROB = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_COMPROB", aliasTabla)), -1))
        e.ID_PROVEE = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PROVEE", aliasTabla)), -1))
        e.NO_CCF = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NO_CCF", aliasTabla))))
        e.CONDI_COMPRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}CONDI_COMPRA", aliasTabla)), -1))

        ' UID_CCF es nullable Guid?
        e.UID_CCF = If(TypeOf ObtenerValor(dr.Item(String.Format("{0}UID_CCF", aliasTabla))) Is Guid,
                   CType(ObtenerValor(dr.Item(String.Format("{0}UID_CCF", aliasTabla))), Guid?),
                   Nothing)

        e.FECHA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA", aliasTabla))))
        e.SUB_TOTAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}SUB_TOTAL", aliasTabla)), -1))
        e.DESCTO_PORC = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}DESCTO_PORC", aliasTabla)), -1))
        e.DESCTO_MONTO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}DESCTO_MONTO", aliasTabla)), -1))
        e.SUMAS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}SUMAS", aliasTabla)), -1))
        e.IVA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}IVA", aliasTabla)), -1))
        e.TOTAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TOTAL", aliasTabla)), -1))
        e.USUARIO_CREACION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREACION", aliasTabla))))
        e.FECHA_CREACION = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREACION", aliasTabla))))
        e.CTA_CONTABLE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CTA_CONTABLE", aliasTabla))))
    End Sub

    Public Sub AsignarCCF_DETA_FRENTE(ByVal dr As IDataReader, ByRef e As CCF_DETA_FRENTE, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New CCF_DETA_FRENTE
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If

        e.ID_CCF_DETA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CCF_DETA", aliasTabla))))
        e.ID_CCF_ENCA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CCF_ENCA", aliasTabla)), -1))
        e.ID_PRODUCTO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PRODUCTO", aliasTabla)), -1))
        e.NOMBRE_PRODUCTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_PRODUCTO", aliasTabla))))
        e.PRESENTACION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}PRESENTACION", aliasTabla))))
        e.CANTIDAD = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}CANTIDAD", aliasTabla)), -1))
        e.PRECIO_UNITARIO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PRECIO_UNITARIO", aliasTabla)), -1))
        e.TOTAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TOTAL", aliasTabla)), -1))
    End Sub

    Public Sub AsignarSOLIC_DETA_FRENTE(ByVal dr As IDataReader, ByRef e As SOLIC_DETA_FRENTE, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New SOLIC_DETA_FRENTE
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If

        e.ID_SOLIC_DETA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_SOLIC_DETA", aliasTabla))))
        e.ID_SOLICITUD = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_SOLICITUD", aliasTabla)), -1))
        e.ID_PROVEE = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PROVEE", aliasTabla)), -1))
        e.ID_PRODUCTO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PRODUCTO", aliasTabla)), -1))
        e.NOMBRE_PRODUCTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_PRODUCTO", aliasTabla))))
        e.PRESENTACION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}PRESENTACION", aliasTabla))))
        e.CANTIDAD = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}CANTIDAD", aliasTabla)), -1))
        e.PRECIO_UNITARIO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PRECIO_UNITARIO", aliasTabla)), -1))
        e.SUB_TOTAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}SUB_TOTAL", aliasTabla)), -1))
    End Sub

    Public Sub AsignarSOLIC_ANTICIPO_FRENTE(ByVal dr As IDataReader, ByRef e As SOLIC_ANTICIPO_FRENTE, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New SOLIC_ANTICIPO_FRENTE
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If

        e.ID_ANTICIPO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ANTICIPO", aliasTabla))))
        e.ID_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA", aliasTabla))))
        e.ZAFRA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ZAFRA", aliasTabla))))
        e.ID_TIPO_PROVEEDOR = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_PROVEEDOR", aliasTabla)), -1))
        e.ID_FRENTE = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_FRENTE", aliasTabla)), -1))
        e.COD_FRENTE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}COD_FRENTE", aliasTabla))))
        e.NOM_FRENTE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOM_FRENTE", aliasTabla))))
        e.NUM_ANTICIPO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}NUM_ANTICIPO", aliasTabla))))
        e.FECHA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA", aliasTabla))))
        e.CONCEPTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CONCEPTO", aliasTabla))))
        e.MONTO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MONTO", aliasTabla))))
        e.UID_ANTICIPO = If(TypeOf ObtenerValor(dr.Item(String.Format("{0}UID_ANTICIPO", aliasTabla))) Is Guid,
                        CType(ObtenerValor(dr.Item(String.Format("{0}UID_ANTICIPO", aliasTabla))), Guid?), Nothing)
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.FECHA_CHEQUE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CHEQUE", aliasTabla))))
        e.PORC_INTERES = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PORC_INTERES", aliasTabla)), -1))
        e.ES_ACEPTADA = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}ES_ACEPTADA", aliasTabla))))
        e.CHQ_NO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CHQ_NO", aliasTabla))))
        e.ID_CUENTA_FINAN = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CUENTA_FINAN", aliasTabla)), -1))
        e.PLAZO_MESES = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}PLAZO_MESES", aliasTabla)), -1))
        e.FECHA_VENCE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_VENCE", aliasTabla))))
        e.ID_ESTADO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ESTADO", aliasTabla)), -1))
        e.PERFECHA_INI = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}PERFECHA_INI", aliasTabla))))
        e.PERFECHA_FIN = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}PERFECHA_FIN", aliasTabla))))
        e.DESTINO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DESTINO", aliasTabla))))
        e.CUOTA_X_CORTE = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}CUOTA_X_CORTE", aliasTabla))))
    End Sub

    Public Sub AsignarSOLIC_ANTICIPO_FRENTE_ZAFRA(ByVal dr As IDataReader, ByRef e As SOLIC_ANTICIPO_FRENTE_ZAFRA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New SOLIC_ANTICIPO_FRENTE_ZAFRA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If

        e.ID_ANTI_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ANTI_ZAFRA", aliasTabla))))
        e.ID_ANTICIPO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ANTICIPO", aliasTabla))))
        e.ID_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA", aliasTabla))))
        e.FECHA_ULTMOV = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ULTMOV", aliasTabla))))
        e.CUOTA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}CUOTA", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
    End Sub

    Public Sub AsignarCREDITO_ENCA_FRENTE(ByVal dr As IDataReader, ByRef e As CREDITO_ENCA_FRENTE, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New CREDITO_ENCA_FRENTE
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If

        e.ID_CREDITO_ENCA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CREDITO_ENCA", aliasTabla))))
        e.ID_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA", aliasTabla)), -1))
        e.ZAFRA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ZAFRA", aliasTabla))))
        e.ID_TIPO_PROVEEDOR = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_PROVEEDOR", aliasTabla)), -1))
        e.ID_FRENTE = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_FRENTE", aliasTabla)), -1))
        e.COD_FRENTE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}COD_FRENTE", aliasTabla))))
        e.ID_TIPO_COMPROB = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_COMPROB", aliasTabla)), -1))
        e.ID_CUENTA_FINAN = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CUENTA_FINAN", aliasTabla)), -1))
        e.DESCRIP_FINAN = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DESCRIP_FINAN", aliasTabla))))
        e.ID_PROVEE = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PROVEE", aliasTabla)), -1))
        e.FECHA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA", aliasTabla))))
        e.NO_COMPROB = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NO_COMPROB", aliasTabla))))
        e.FECHA_APLIC = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_APLIC", aliasTabla))))
        e.FECHA_ULTMOV = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ULTMOV", aliasTabla))))
        e.UID_REFERENCIA = If(TypeOf ObtenerValor(dr.Item(String.Format("{0}UID_REFERENCIA", aliasTabla))) Is Guid,
                          CType(ObtenerValor(dr.Item(String.Format("{0}UID_REFERENCIA", aliasTabla))), Guid?), Nothing)
        e.TASAINT = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TASAINT", aliasTabla))))
        e.CARGO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}CARGO", aliasTabla))))
        e.ABONO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ABONO", aliasTabla))))
        e.SALDO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}SALDO", aliasTabla))))
        e.INTERES = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}INTERES", aliasTabla))))
        e.IVA_INTERES = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}IVA_INTERES", aliasTabla))))
        e.ABONO_IVA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ABONO_IVA", aliasTabla))))
        e.ABONO_INTERES = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ABONO_INTERES", aliasTabla))))
        e.ABONO_INTERES_IVA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ABONO_INTERES_IVA", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.TIPO_INTERES = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TIPO_INTERES", aliasTabla))))
        e.CUOTA_X_CORTE = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}CUOTA_X_CORTE", aliasTabla))))
        e.CTA_CONTABLE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CTA_CONTABLE", aliasTabla))))
    End Sub

    Public Sub AsignarCREDITO_MOV_FRENTE(ByVal dr As IDataReader, ByRef e As CREDITO_MOV_FRENTE, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New CREDITO_MOV_FRENTE
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If

        e.ID_CREDITO_MOV = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CREDITO_MOV", aliasTabla))))
        e.ID_CREDITO_ENCA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CREDITO_ENCA", aliasTabla))))
        e.FECHA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA", aliasTabla))))
        e.UID_REFERENCIA = CType(ObtenerValor(dr.Item(String.Format("{0}UID_REFERENCIA", aliasTabla))), Guid)
        e.ID_CATORCENA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CATORCENA", aliasTabla)), -1))
        e.CARGO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}CARGO", aliasTabla))))
        e.ABONO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ABONO", aliasTabla))))
        e.SALDO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}SALDO", aliasTabla))))
        e.ABONO_IVA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ABONO_IVA", aliasTabla))))
        e.ABONO_INTERES = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ABONO_INTERES", aliasTabla))))
        e.ABONO_INTERES_IVA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ABONO_INTERES_IVA", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.CODIBANCO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}CODIBANCO", aliasTabla)), -1))
        e.NO_DOCUMENTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NO_DOCUMENTO", aliasTabla))))
        e.FECHA_ULTMOV = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ULTMOV", aliasTabla))))
        e.TASAINT = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TASAINT", aliasTabla)), -1))
        e.SALDO_INICIAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}SALDO_INICIAL", aliasTabla)), -1))
        e.TIPO_INTERES = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TIPO_INTERES", aliasTabla))))
        e.PLAZO_DIAS = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}PLAZO_DIAS", aliasTabla)), -1))
        e.ID_PLANILLA_BASE = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PLANILLA_BASE", aliasTabla)), -1))
        e.ID_CATORCENA_VTO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CATORCENA_VTO", aliasTabla)), -1))
    End Sub

    Public Sub AsignarCREFISCAL_PROVEEDOR(ByVal dr As IDataReader, ByRef e As CREFISCAL_PROVEEDOR, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New CREFISCAL_PROVEEDOR
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_CCF = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CCF", aliasTabla))))
        e.ID_COMPROB_ENCA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_COMPROB_ENCA", aliasTabla))))
        e.ID_TIPO_COMPROB = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_COMPROB", aliasTabla))))
        e.FECHA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA", aliasTabla))))
        e.NUMERO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NUMERO", aliasTabla))))
        e.SERIE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}SERIE", aliasTabla))))
        e.CODI_GENERACION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODI_GENERACION", aliasTabla))))
        e.SELLO_RECEPCION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}SELLO_RECEPCION", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
    End Sub

    Public Sub AsignarCOMPROB_ENCA(ByVal dr As IDataReader, ByRef e As COMPROB_ENCA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New COMPROB_ENCA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_COMPROB_ENCA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_COMPROB_ENCA", aliasTabla))))
        e.ID_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA", aliasTabla))))
        e.ID_CATORCENA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CATORCENA", aliasTabla))))
        e.ID_TIPO_PLANILLA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_PLANILLA", aliasTabla))))
        e.ID_TIPO_COMPROB = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_COMPROB", aliasTabla))))
        e.SERIE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}SERIE", aliasTabla))))
        e.NUM_DOCTO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}NUM_DOCTO", aliasTabla))))
        e.ESTADO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ESTADO", aliasTabla))))
        e.FECHA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA", aliasTabla))))
        e.CODIGO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO", aliasTabla))))
        e.NOMBRES = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRES", aliasTabla))))
        e.APELLIDOS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}APELLIDOS", aliasTabla))))
        e.DIRECCION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DIRECCION", aliasTabla))))
        e.CODI_DEPTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODI_DEPTO", aliasTabla))))
        e.CODI_MUNI = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODI_MUNI", aliasTabla))))
        e.NIT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NIT", aliasTabla))))
        e.DUI = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DUI", aliasTabla))))
        e.NRC = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NRC", aliasTabla))))
        e.GIRO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}GIRO", aliasTabla))))
        e.CORREO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CORREO", aliasTabla))))
        e.SUMAS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}SUMAS", aliasTabla))))
        e.IVA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}IVA", aliasTabla))))
        e.RENTA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}RENTA", aliasTabla))))
        e.SUBTOTAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}SUBTOTAL", aliasTabla))))
        e.IVA_RETENIDO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}IVA_RETENIDO", aliasTabla))))
        e.TOTAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TOTAL", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.ID_PLANILLA_COMPROB = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PLANILLA_COMPROB", aliasTabla)), -1))
    End Sub
    Public Sub AsignarESTICANA_XLS_ENCA(ByVal dr As IDataReader, ByRef e As ESTICANA_XLS_ENCA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New ESTICANA_XLS_ENCA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_ENCA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ENCA", aliasTabla))))
        e.FECHA_CARGA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CARGA", aliasTabla))))
        e.NOMBRE_ARCHIVO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_ARCHIVO", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
    End Sub

    Public Sub AsignarESTICANA_XLS_DETA(ByVal dr As IDataReader, ByRef e As ESTICANA_XLS_DETA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New ESTICANA_XLS_DETA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_DETA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_DETA", aliasTabla))))
        e.ID_ENCA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ENCA", aliasTabla))))
        e.ACCESLOTE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ACCESLOTE", aliasTabla))))
        e.ZONA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ZONA", aliasTabla))))
        e.MZ = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MZ", aliasTabla)), -1))
        e.TC_MZ = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TC_MZ", aliasTabla)), -1))
        e.TC = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TC", aliasTabla)), -1))
        e.OB_PROD_INTERNA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}OB_PROD_INTERNA", aliasTabla))))
        e.OB_PERSO_TEC = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}OB_PERSO_TEC", aliasTabla))))
        e.MZ_PERDIDA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MZ_PERDIDA", aliasTabla)), -1))
        e.TC_PERDIDA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TC_PERDIDA", aliasTabla)), -1))
        e.RENOVACION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}RENOVACION", aliasTabla)), -1))
        e.SIEMBRA_NUEVA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}SIEMBRA_NUEVA", aliasTabla)), -1))
        e.SIEMBRA_PROYE = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}SIEMBRA_PROYE", aliasTabla)), -1))
        e.MZ_PENDIENTE = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MZ_PENDIENTE", aliasTabla)), -1))
        e.TC_PENDIENTE = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TC_PENDIENTE", aliasTabla)), -1))
        e.TIPO_ROZA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TIPO_ROZA", aliasTabla))))
        e.TIPO_TRANSPORTE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TIPO_TRANSPORTE", aliasTabla))))
        e.TIPO_QUEMA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TIPO_QUEMA", aliasTabla))))
        e.MAD_APLICAR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}MAD_APLICAR", aliasTabla))))
        e.MAD_DOSIS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MAD_DOSIS", aliasTabla)), -1))
        e.MAD_FECHA_APLI = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}MAD_FECHA_APLI", aliasTabla))))
        e.OBSERVACIONES = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}OBSERVACIONES", aliasTabla))))
        e.CANA_VARIEDAD = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CANA_VARIEDAD", aliasTabla))))

        e.CONCEPTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CONCEPTO", aliasTabla))))
        e.EQUIPO_ANTERIOR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}EQUIPO_ANTERIOR", aliasTabla))))
        e.AREA_ANTERIOR = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}AREA_ANTERIOR", aliasTabla)), -1))
        e.MAD_APLI_DOSIS_ACTUAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MAD_APLI_DOSIS_ACTUAL", aliasTabla)), -1))
        e.EQUIPO_ACTUAL = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}EQUIPO_ACTUAL", aliasTabla))))
        e.ACCESLOTE_ANT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ACCESLOTE_ANT", aliasTabla))))
        e.SEMILLA_MZ = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}SEMILLA_MZ", aliasTabla)), -1))
        e.SEMILLA_TC = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}SEMILLA_TC", aliasTabla)), -1))

        e.GRUPO_Z1 = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}GRUPO_Z1", aliasTabla))))
        e.HA_Z1 = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}HA_Z1", aliasTabla)), -1))
        e.TC_Z1 = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TC_Z1", aliasTabla)), -1))
        e.TCH_Z1 = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}TCH_Z1", aliasTabla)), -1))
        e.GRUPO_Z2 = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}GRUPO_Z2", aliasTabla))))
        e.HA_EFEC_Z2 = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}HA_EFEC_Z2", aliasTabla)), -1))
        e.TCH_Z2 = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}TCH_Z2", aliasTabla)), -1))
        e.TC_Z2 = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TC_Z2", aliasTabla)), -1))
    End Sub

    Public Sub AsignarENVIO_MONI_QQ(ByVal dr As IDataReader, ByRef e As ENVIO_MONI_QQ, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New ENVIO_MONI_QQ
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_ENVIO_MQQ = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ENVIO_MQQ", aliasTabla))))
        e.ID_ENVIO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ENVIO", aliasTabla)), -1))
        e.ID_MONITOR = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_MONITOR", aliasTabla)), -1))
        e.ID_PROVEE_QQ = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PROVEE_QQ", aliasTabla)), -1))
        e.ID_PROVEE_QQ_CORTE = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PROVEE_QQ_CORTE", aliasTabla)), -1))
        e.TARIFA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TARIFA", aliasTabla)), -1))
    End Sub

    Public Sub AsignarPROVEEDOR_QUERQUEO(ByVal dr As IDataReader, ByRef e As PROVEEDOR_QUERQUEO, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New PROVEEDOR_QUERQUEO
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_PROVEE_QQ = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PROVEE_QQ", aliasTabla))))
        e.ID_TIPO_PERSONA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_PERSONA", aliasTabla)), -1))
        e.CODISIS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODISIS", aliasTabla))))
        e.NOMBRES = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRES", aliasTabla))))
        e.APELLIDOS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}APELLIDOS", aliasTabla))))
        e.NIT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NIT", aliasTabla))))
        e.DUI = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DUI", aliasTabla))))
        e.NRC = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NRC", aliasTabla))))
        e.DIRECCION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DIRECCION", aliasTabla))))
        e.TELEFONO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TELEFONO", aliasTabla))))
        e.CORREO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CORREO", aliasTabla))))
        e.CODI_DEPTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODI_DEPTO", aliasTabla))))
        e.CODI_MUNI = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODI_MUNI", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub

    Public Sub AsignarMONITOR_CAL(ByVal dr As IDataReader, ByRef e As MONITOR_CAL, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New MONITOR_CAL
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_MONITOR = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_MONITOR", aliasTabla))))
        e.NOMBRES = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRES", aliasTabla))))
        e.DUI = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DUI", aliasTabla))))
        e.DIRECCION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DIRECCION", aliasTabla))))
        e.CODIEMP = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIEMP", aliasTabla))))
        e.CODISIS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODISIS", aliasTabla))))
    End Sub
    Public Sub AsignarTIPO_PERSONA(ByVal dr As IDataReader, ByRef e As TIPO_PERSONA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New TIPO_PERSONA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_TIPO_PERSONA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_PERSONA", aliasTabla))))
        e.DESCRIPCION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DESCRIPCION", aliasTabla))))
    End Sub
    Public Sub AsignarBASE_PROVEEDORES_MH(ByVal dr As IDataReader, ByRef e As BASE_PROVEEDORES_MH, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New BASE_PROVEEDORES_MH
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_BASE_PROVEE = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_BASE_PROVEE", aliasTabla))))
        e.DUI = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DUI", aliasTabla))))
        e.NIT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NIT", aliasTabla))))
        e.NOMBRES = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRES", aliasTabla))))
        e.APELLIDOS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}APELLIDOS", aliasTabla))))
        e.TELEFONO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TELEFONO", aliasTabla))))
        e.DIRECCION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DIRECCION", aliasTabla))))
        e.CODI_DEPTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODI_DEPTO", aliasTabla))))
        e.CODI_MUNI = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODI_MUNI", aliasTabla))))
        e.CORREO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CORREO", aliasTabla))))
        e.NRC = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NRC", aliasTabla))))
        e.ID_TIPO_PERSONA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_PERSONA", aliasTabla)), -1))
        e.ACTIVIDAD = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ACTIVIDAD", aliasTabla))))
    End Sub
    Public Sub AsignarLOTES_COSECHA_GESTION(ByVal dr As IDataReader, ByRef e As LOTES_COSECHA_GESTION, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New LOTES_COSECHA_GESTION
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_LOTE_COSE_GESTION = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_LOTE_COSE_GESTION", aliasTabla))))
        e.ID_LOTES_COSECHA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_LOTES_COSECHA", aliasTabla))))
        e.ACCESLOTE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ACCESLOTE", aliasTabla))))
        e.OB_PROD_INTERNA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}OB_PROD_INTERNA", aliasTabla))))
        e.OB_PERSO_TEC = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}OB_PERSO_TEC", aliasTabla))))
        e.MZ_PERDIDA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MZ_PERDIDA", aliasTabla)), -1))
        e.TC_PERDIDA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TC_PERDIDA", aliasTabla)), -1))
        e.RENOVACION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}RENOVACION", aliasTabla)), -1))
        e.SIEMBRA_NUEVA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}SIEMBRA_NUEVA", aliasTabla)), -1))
        e.SIEMBRA_PROYE = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}SIEMBRA_PROYE", aliasTabla)), -1))
        e.MZ_PENDIENTE = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MZ_PENDIENTE", aliasTabla)), -1))
        e.TC_PENDIENTE = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TC_PENDIENTE", aliasTabla)), -1))
        e.TIPO_ROZA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TIPO_ROZA", aliasTabla))))
        e.TIPO_TRANSPORTE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TIPO_TRANSPORTE", aliasTabla))))
        e.TIPO_QUEMA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TIPO_QUEMA", aliasTabla))))
        e.MAD_APLICAR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}MAD_APLICAR", aliasTabla))))
        e.MAD_DOSIS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MAD_DOSIS", aliasTabla)), -1))
        e.MAD_FECHA_APLI = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}MAD_FECHA_APLI", aliasTabla))))
    End Sub

    Public Sub AsignarLOTES_LG(ByVal dr As IDataReader, ByRef e As LOTES_LG, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New LOTES_LG
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ACCESLOTE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ACCESLOTE", aliasTabla))))
        e.ANIOZAFRA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ANIOZAFRA", aliasTabla))))
        e.CODIPROVEEDOR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIPROVEEDOR", aliasTabla))))
        e.CODILOTE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODILOTE", aliasTabla))))
        e.CODIAGRON = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIAGRON", aliasTabla))))
        e.CODIVARIEDA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIVARIEDA", aliasTabla))))
        e.CODIUBICACION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIUBICACION", aliasTabla))))
        e.CODICONTRATO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODICONTRATO", aliasTabla))))
        e.NOMBLOTE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBLOTE", aliasTabla))))
        e.AREA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}AREA", aliasTabla)), -1))
        e.TONELADAS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TONELADAS", aliasTabla)), -1))
        e.TONEL_TC = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TONEL_TC", aliasTabla)), -1))
        e.ZONA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ZONA", aliasTabla))))
        e.EDAD_LOTE = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}EDAD_LOTE", aliasTabla)), -1))
        e.USER_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USER_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USER_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USER_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.ID_MAESTRO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_MAESTRO", aliasTabla)), -1))
        e.TIPO_DERECHO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}TIPO_DERECHO", aliasTabla)), -1))
        e.SUB_ZONA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}SUB_ZONA", aliasTabla))))
        e.ID_LOTE_TRASPASO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_LOTE_TRASPASO", aliasTabla)), -1))
        e.AREA_CANA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}AREA_CANA", aliasTabla)), -1))
        e.RIESGO_PIEDRA = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}RIESGO_PIEDRA", aliasTabla))))
        e.REPARA_ACCESO = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}REPARA_ACCESO", aliasTabla))))
        e.SIN_ACCESO_PROPIO = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}SIN_ACCESO_PROPIO", aliasTabla))))
    End Sub

    Public Sub AsignarCONTRATO_ZAFRAS_LG(ByVal dr As IDataReader, ByRef e As CONTRATO_ZAFRAS_LG, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New CONTRATO_ZAFRAS_LG
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_CONTRATO_ZAFRAS = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CONTRATO_ZAFRAS", aliasTabla))))
        e.CODICONTRATO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODICONTRATO", aliasTabla))))
        e.ID_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub

    Public Sub AsignarCONTRATO_LG(ByVal dr As IDataReader, ByRef e As CONTRATO_LG, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New CONTRATO_LG
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.CODICONTRATO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODICONTRATO", aliasTabla))))
        e.ANIOZAFRA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ANIOZAFRA", aliasTabla))))
        e.CODIPROVEEDOR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIPROVEEDOR", aliasTabla))))
        e.FECHA_CONTRATOCB = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CONTRATOCB", aliasTabla))))
        e.ESTADO_CONTRATOCB = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ESTADO_CONTRATOCB", aliasTabla)), -1))
        e.FINANCOADO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}FINANCOADO", aliasTabla))))
        e.FINAN_NUMERO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}FINAN_NUMERO", aliasTabla))))
        e.TOTALMZ_CONTRATOCB = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TOTALMZ_CONTRATOCB", aliasTabla)), -1))
        e.TONELADAS_CONTRATOCB = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TONELADAS_CONTRATOCB", aliasTabla)), -1))
        e.OBSERVACIONES_CONTRATOCB = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}OBSERVACIONES_CONTRATOCB", aliasTabla))))
        e.USER_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USER_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USER_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USER_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.NO_REGISTRO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NO_REGISTRO", aliasTabla))))
        e.FECHA_REGISTRO = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_REGISTRO", aliasTabla))))
        e.APELLIDOS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}APELLIDOS", aliasTabla))))
        e.NOMBRES = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRES", aliasTabla))))
        e.DIRECCION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DIRECCION", aliasTabla))))
        e.TELEFONO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TELEFONO", aliasTabla))))
        e.CELULAR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CELULAR", aliasTabla))))
        e.DUI = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DUI", aliasTabla))))
        e.NIT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NIT", aliasTabla))))
        e.CREDITFISCAL = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CREDITFISCAL", aliasTabla))))
        e.APODERADO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}APODERADO", aliasTabla))))
        e.DUI_APODERADO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DUI_APODERADO", aliasTabla))))
        e.NIT_APODERADO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NIT_APODERADO", aliasTabla))))
        e.ID_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA", aliasTabla)), -1))
        e.NO_CONTRATO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}NO_CONTRATO", aliasTabla)), -1))
        e.TIPO_CONTRATO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}TIPO_CONTRATO", aliasTabla)), -1))
        e.FECHA_CONTRA_LEGAL = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CONTRA_LEGAL", aliasTabla))))
        e.EDAD = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}EDAD", aliasTabla)), -1))
    End Sub


    Public Sub AsignarSOLIC_OIP_LOTE(ByVal dr As IDataReader, ByRef e As SOLIC_OIP_LOTE, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New SOLIC_OIP_LOTE
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_SOLI_LOTE = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_SOLI_LOTE", aliasTabla))))
        e.ID_OPI = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_OPI", aliasTabla))))
        e.ACCESLOTE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ACCESLOTE", aliasTabla))))
        e.MZ = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MZ", aliasTabla))))
        e.TONEL_ESTI = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TONEL_ESTI", aliasTabla))))
        e.PROPORCION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PROPORCION", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.ID_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA", aliasTabla))))
    End Sub

    Public Sub AsignarSOLIC_ANTICIPO_LOTE(ByVal dr As IDataReader, ByRef e As SOLIC_ANTICIPO_LOTE, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New SOLIC_ANTICIPO_LOTE
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_SOLI_LOTE = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_SOLI_LOTE", aliasTabla))))
        e.ID_ANTICIPO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ANTICIPO", aliasTabla))))
        e.ACCESLOTE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ACCESLOTE", aliasTabla))))
        e.MZ = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MZ", aliasTabla))))
        e.TONEL_ESTI = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TONEL_ESTI", aliasTabla))))
        e.PROPORCION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PROPORCION", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.ID_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA", aliasTabla))))
    End Sub

    Public Sub AsignarPROYFIN_ING_LOTE(ByVal dr As IDataReader, ByRef e As PROYFIN_ING_LOTE, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New PROYFIN_ING_LOTE
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_PROYFIN_ING_LOTE = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PROYFIN_ING_LOTE", aliasTabla))))
        e.ID_PROYFIN_ING = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PROYFIN_ING", aliasTabla)), -1))
        e.ACCESLOTE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ACCESLOTE", aliasTabla))))
        e.NO_CONTRATO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}NO_CONTRATO", aliasTabla)), -1))
        e.CICLO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}CICLO", aliasTabla)), -1))
        e.CICLO1 = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}CICLO1", aliasTabla)), -1))
        e.MZ1 = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MZ1", aliasTabla)), -1))
        e.TC_MZ1 = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TC_MZ1", aliasTabla)), -1))
        e.TC1 = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TC1", aliasTabla)), -1))
        e.REND1 = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}REND1", aliasTabla)), -1))
        e.LBS1 = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}LBS1", aliasTabla)), -1))
        e.CICLO2 = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}CICLO2", aliasTabla)), -1))
        e.MZ2 = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MZ2", aliasTabla)), -1))
        e.TC_MZ2 = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TC_MZ2", aliasTabla)), -1))
        e.TC2 = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TC2", aliasTabla)), -1))
        e.REND2 = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}REND2", aliasTabla)), -1))
        e.LBS2 = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}LBS2", aliasTabla)), -1))
        e.CICLO3 = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}CICLO3", aliasTabla)), -1))
        e.MZ3 = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MZ3", aliasTabla)), -1))
        e.TC_MZ3 = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TC_MZ3", aliasTabla)), -1))
        e.TC3 = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TC3", aliasTabla)), -1))
        e.REND3 = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}REND3", aliasTabla)), -1))
        e.LBS3 = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}LBS3", aliasTabla)), -1))
        e.CICLO4 = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}CICLO4", aliasTabla)), -1))
        e.MZ4 = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MZ4", aliasTabla)), -1))
        e.TC_MZ4 = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TC_MZ4", aliasTabla)), -1))
        e.TC4 = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TC4", aliasTabla)), -1))
        e.REND4 = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}REND4", aliasTabla)), -1))
        e.LBS4 = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}LBS4", aliasTabla)), -1))
        e.CICLO5 = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}CICLO5", aliasTabla)), -1))
        e.MZ5 = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MZ5", aliasTabla)), -1))
        e.TC_MZ5 = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TC_MZ5", aliasTabla)), -1))
        e.TC5 = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TC5", aliasTabla)), -1))
        e.REND5 = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}REND5", aliasTabla)), -1))
        e.LBS5 = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}LBS5", aliasTabla)), -1))
        e.CICLO6 = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}CICLO6", aliasTabla)), -1))
        e.MZ6 = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MZ6", aliasTabla)), -1))
        e.TC_MZ6 = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TC_MZ6", aliasTabla)), -1))
        e.TC6 = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TC6", aliasTabla)), -1))
        e.REND6 = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}REND6", aliasTabla)), -1))
        e.LBS6 = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}LBS6", aliasTabla)), -1))
        e.CICLO7 = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}CICLO7", aliasTabla)), -1))
        e.MZ7 = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MZ7", aliasTabla)), -1))
        e.TC_MZ7 = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TC_MZ7", aliasTabla)), -1))
        e.TC7 = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TC7", aliasTabla)), -1))
        e.REND7 = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}REND7", aliasTabla)), -1))
        e.LBS7 = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}LBS7", aliasTabla)), -1))
    End Sub

    Public Sub AsignarPROYFIN_ING(ByVal dr As IDataReader, ByRef e As PROYFIN_ING, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New PROYFIN_ING
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_PROYFIN_ING = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PROYFIN_ING", aliasTabla))))
        e.ID_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA", aliasTabla))))
        e.CODIPROVEEDOR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIPROVEEDOR", aliasTabla))))
        e.FECHA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA", aliasTabla))))
        e.VIP = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}VIP", aliasTabla))))
        e.EN_PROCESO = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}EN_PROCESO", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub

    Public Sub AsignarPERSONAL_FCAT(ByVal dr As IDataReader, ByRef e As PERSONAL_FCAT, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New PERSONAL_FCAT
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_PERSO_AT = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PERSO_AT", aliasTabla))))
        e.CODIGO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO", aliasTabla))))
        e.NOMBRE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE", aliasTabla))))
        e.ES_MOCHADOR = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}ES_MOCHADOR", aliasTabla))))
        e.ES_CHEQUERO = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}ES_CHEQUERO", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub


    Public Sub AsignarENVIO_FACT(ByVal dr As IDataReader, ByRef e As ENVIO_FACT, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New ENVIO_FACT
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_ENVIO_FACT = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ENVIO_FACT", aliasTabla))))
        e.ID_ENVIO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ENVIO", aliasTabla))))
        e.VALOR_TARIFA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}VALOR_TARIFA", aliasTabla))))
        e.CODIGO_MOCHADOR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_MOCHADOR", aliasTabla))))
        e.CODIGO_CHEQUERO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_CHEQUERO", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub

    Public Sub AsignarENVIO_COSECHA_BANDA(ByVal dr As IDataReader, ByRef e As ENVIO_COSECHA_BANDA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New ENVIO_COSECHA_BANDA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_ENVIO_BANDA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ENVIO_BANDA", aliasTabla))))
        e.ID_ENVIO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ENVIO", aliasTabla))))
        e.VALOR_TARIFA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}VALOR_TARIFA", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.ID_CARGADOR1 = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CARGADOR1", aliasTabla)), -1))
        e.ID_CARGADOR2 = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CARGADOR2", aliasTabla)), -1))
    End Sub

    Public Sub AsignarCOMPROB_NUMERACION(ByVal dr As IDataReader, ByRef e As COMPROB_NUMERACION, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New COMPROB_NUMERACION
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_COMPROB_NUME = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_COMPROB_NUME", aliasTabla))))
        e.ID_TIPO_COMPROB = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_COMPROB", aliasTabla))))
        e.SERIE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}SERIE", aliasTabla))))
        e.NO_INICIAL = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}NO_INICIAL", aliasTabla))))
        e.NO_FINAL = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}NO_FINAL", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub

    Public Sub AsignarPLANILLA_COMPROB(ByVal dr As IDataReader, ByRef e As PLANILLA_COMPROB, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New PLANILLA_COMPROB
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_PLANILLA_COMPROB = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PLANILLA_COMPROB", aliasTabla))))
        e.ID_CATORCENA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CATORCENA", aliasTabla))))
        e.CODIPROVEEDOR_TRANSPORTISTA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIPROVEEDOR_TRANSPORTISTA", aliasTabla))))
        e.NOMBRE_CLIENTE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_CLIENTE", aliasTabla))))
        e.ID_TIPO_PLANILLA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_PLANILLA", aliasTabla))))
        e.ID_TIPO_COMPROB = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_COMPROB", aliasTabla))))
        e.SERIE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}SERIE", aliasTabla))))
        e.NO_DOCTO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}NO_DOCTO", aliasTabla))))
        e.ESTADO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ESTADO", aliasTabla))))
        e.FECHA_EMISION = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_EMISION", aliasTabla))))
        e.NRC = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NRC", aliasTabla))))
        e.TIPO_CONTRIBUYENTE = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}TIPO_CONTRIBUYENTE", aliasTabla))))
        e.AFECTO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}AFECTO", aliasTabla))))
        e.EXENTO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}EXENTO", aliasTabla))))
        e.IVA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}IVA", aliasTabla))))
        e.RETENCION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}RETENCION", aliasTabla))))
        e.PERCEPCION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PERCEPCION", aliasTabla))))
        e.VTA_SUJETO_EXCLUIDO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}VTA_SUJETO_EXCLUIDO", aliasTabla))))
        e.TOTAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TOTAL", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub

    Public Sub AsignarPRODUCTO_TIPO_TRANS(ByVal dr As IDataReader, ByRef e As PRODUCTO_TIPO_TRANS, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New PRODUCTO_TIPO_TRANS
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_PRODTT = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PRODTT", aliasTabla))))
        e.ID_PRODUCTO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PRODUCTO", aliasTabla))))
        e.ID_TIPOTRANS = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPOTRANS", aliasTabla))))
        e.CANTIDAD_AUTO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}CANTIDAD_AUTO", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub


    Public Sub AsignarREMESA_DETA_TRANS(ByVal dr As IDataReader, ByRef e As REMESA_DETA_TRANS, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New REMESA_DETA_TRANS
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_REMESA_DETA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_REMESA_DETA", aliasTabla))))
        e.ID_REMESA_ENCA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_REMESA_ENCA", aliasTabla)), -1))
        e.ID_CREDITO_ENCA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CREDITO_ENCA", aliasTabla)), -1))
        e.UID_REMESA_DETA = ObtenerValor(dr.Item(String.Format("{0}UID_REMESA_DETA", aliasTabla)))
        e.ABONO_CAPITAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ABONO_CAPITAL", aliasTabla))))
        e.ABONO_INTERES = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ABONO_INTERES", aliasTabla))))
        e.ABONO_INTERES_IVA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ABONO_INTERES_IVA", aliasTabla))))
    End Sub

    Public Sub AsignarREMESA_ENCA_TRANS(ByVal dr As IDataReader, ByRef e As REMESA_ENCA_TRANS, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New REMESA_ENCA_TRANS
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_REMESA_ENCA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_REMESA_ENCA", aliasTabla))))
        e.CODTRANSPORT = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}CODTRANSPORT", aliasTabla)), -1))
        e.CODIBANCO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}CODIBANCO", aliasTabla))))
        e.FECHA_REMESA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_REMESA", aliasTabla))))
        e.UID_REMESA_ENCA = ObtenerValor(dr.Item(String.Format("{0}UID_REMESA_ENCA", aliasTabla)))
        e.NO_REMESA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NO_REMESA", aliasTabla))))
        e.OBSERVACION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}OBSERVACION", aliasTabla))))
        e.ABONO_CAPITAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ABONO_CAPITAL", aliasTabla))))
        e.ABONO_INTERES = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ABONO_INTERES", aliasTabla))))
        e.ABONO_INTERES_IVA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ABONO_INTERES_IVA", aliasTabla))))
        e.TOTAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TOTAL", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub

    Public Sub AsignarPLANTILLA_TRANS_DATOS(ByVal dr As IDataReader, ByRef e As PLANTILLA_TRANS_DATOS, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New PLANTILLA_TRANS_DATOS
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_PLANTI_DATOS = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PLANTI_DATOS", aliasTabla))))
        e.ID_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA", aliasTabla)), -1))
        e.ID_CATORCENA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CATORCENA", aliasTabla)), -1))
        e.UID_REFERENCIA = ObtenerValor(dr.Item(String.Format("{0}UID_REFERENCIA", aliasTabla)))
        e.TRANSPORTISTA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TRANSPORTISTA", aliasTabla))))
        e.CODTRANSPORT = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}CODTRANSPORT", aliasTabla)), -1))
        e.ID_CREDITO_ENCA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CREDITO_ENCA", aliasTabla)), -1))
        e.ID_CUENTA_FINAN = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CUENTA_FINAN", aliasTabla)), -1))
        e.ID_PROVEE = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PROVEE", aliasTabla)), -1))
        e.CONCEPTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CONCEPTO", aliasTabla))))
        e.PAGO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PAGO", aliasTabla)), -1))
        e.SALDO_INI = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}SALDO_INI", aliasTabla)), -1))
        e.INTERES = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}INTERES", aliasTabla)), -1))
        e.ABONO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ABONO", aliasTabla)), -1))
        e.ABONO_INTERES = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ABONO_INTERES", aliasTabla)), -1))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.FECHA_APLIC = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_APLIC", aliasTabla))))
        e.FECHA_ULTMOV = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ULTMOV", aliasTabla))))
        e.TASAINT = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TASAINT", aliasTabla)), -1))
        e.TIPO_INTERES = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TIPO_INTERES", aliasTabla))))
        e.IVA_INTERES = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}IVA_INTERES", aliasTabla)), -1))
        e.NO_CATORCENA_VTO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}NO_CATORCENA_VTO", aliasTabla)), -1))
    End Sub

    Public Sub AsignarPLANTILLA_TRANS_COLU(ByVal dr As IDataReader, ByRef e As PLANTILLA_TRANS_COLU, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New PLANTILLA_TRANS_COLU
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_PLANTI_COLU = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PLANTI_COLU", aliasTabla))))
        e.UID_REFERENCIA = ObtenerValor(dr.Item(String.Format("{0}UID_REFERENCIA", aliasTabla)))
        e.ORDEN_HOJA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ORDEN_HOJA", aliasTabla)), -1))
        e.ORDEN_DESCTO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ORDEN_DESCTO", aliasTabla)), -1))
        e.ID_PROVEE = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PROVEE", aliasTabla)), -1))
        e.CODIBANCO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}CODIBANCO", aliasTabla)), -1))
        e.ID_CUENTA_FINAN = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CUENTA_FINAN", aliasTabla)), -1))
        e.CONCEPTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CONCEPTO", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
    End Sub

    Public Sub AsignarPRE_ANALISIS_DETA_TRANS(ByVal dr As IDataReader, ByRef e As PRE_ANALISIS_DETA_TRANS, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New PRE_ANALISIS_DETA_TRANS
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_DETA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_DETA", aliasTabla))))
        e.ID_ENCA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ENCA", aliasTabla)), -1))
        e.UID_REF = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}UID_REF", aliasTabla))))
        e.ORDEN = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ORDEN", aliasTabla)), -1))
        e.NUMERO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NUMERO", aliasTabla))))
        e.DESCRIPCION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DESCRIPCION", aliasTabla))))
        e.MONTO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MONTO", aliasTabla)), -1))
        e.UNIDADES = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}UNIDADES", aliasTabla))))
        e.ID_CATE = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CATE", aliasTabla)), -1))
        e.ID_CATE_REF = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CATE_REF", aliasTabla)), -1))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.EDITAR = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}EDITAR", aliasTabla))))
        e.NEGRITA = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}NEGRITA", aliasTabla))))
    End Sub

    Public Sub AsignarPRE_ANALISIS_DOCTO_TRANS(ByVal dr As IDataReader, ByRef e As PRE_ANALISIS_DOCTO_TRANS, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New PRE_ANALISIS_DOCTO_TRANS
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_AUX = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_AUX", aliasTabla))))
        e.ID_ENCA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ENCA", aliasTabla)), -1))
        e.CATEGORIA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CATEGORIA", aliasTabla))))
        e.ORDEN = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ORDEN", aliasTabla)), -1))
        e.ID_CUENTA_FINAN = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CUENTA_FINAN", aliasTabla)), -1))
        e.FECHA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA", aliasTabla))))
        e.ZAFRA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ZAFRA", aliasTabla))))
        e.IDENTIFICADOR = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}IDENTIFICADOR", aliasTabla)), -1))
        e.NUM_SOLIC = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NUM_SOLIC", aliasTabla))))
        e.CONDICION_COMPRA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CONDICION_COMPRA", aliasTabla))))
        e.MONTO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MONTO", aliasTabla)), -1))
        e.UID_DOCUMENTO = ObtenerValor(dr.Item(String.Format("{0}UID_DOCUMENTO", aliasTabla)))
    End Sub

    Public Sub AsignarPRE_ANALISIS_ENCA_TRANS(ByVal dr As IDataReader, ByRef e As PRE_ANALISIS_ENCA_TRANS, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New PRE_ANALISIS_ENCA_TRANS
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_ENCA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ENCA", aliasTabla))))
        e.UID_REF = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}UID_REF", aliasTabla))))
        e.ID_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA", aliasTabla)), -1))
        e.FECHA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA", aliasTabla))))
        e.CODTRANSPORT = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}CODTRANSPORT", aliasTabla)), -1))
        e.NOMBRE_TRANSPORTISTA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_TRANSPORTISTA", aliasTabla))))
        e.UNIDADES = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}UNIDADES", aliasTabla)), -1))
        e.NO_VIAJES = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}NO_VIAJES", aliasTabla)), -1))
        e.TC_PROM_VIAJE = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TC_PROM_VIAJE", aliasTabla)), -1))
        e.TC_TOTALES = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TC_TOTALES", aliasTabla)), -1))
        e.TC_FLETE = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TC_FLETE", aliasTabla)), -1))
        e.VALOR_TOTAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}VALOR_TOTAL", aliasTabla)), -1))
        e.COMENTARIO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}COMENTARIO", aliasTabla))))
        e.IMPRESO = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}IMPRESO", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
    End Sub

    Public Sub AsignarCREDITO_MOV_TRANS(ByVal dr As IDataReader, ByRef e As CREDITO_MOV_TRANS, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New CREDITO_MOV_TRANS
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_CREDITO_MOV = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CREDITO_MOV", aliasTabla))))
        e.ID_CREDITO_ENCA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CREDITO_ENCA", aliasTabla))))
        e.FECHA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA", aliasTabla))))
        e.UID_REFERENCIA = ObtenerValor(dr.Item(String.Format("{0}UID_REFERENCIA", aliasTabla)))
        e.ID_CATORCENA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CATORCENA", aliasTabla)), -1))
        e.CARGO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}CARGO", aliasTabla))))
        e.ABONO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ABONO", aliasTabla))))
        e.SALDO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}SALDO", aliasTabla))))
        e.ABONO_IVA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ABONO_IVA", aliasTabla))))
        e.ABONO_INTERES = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ABONO_INTERES", aliasTabla))))
        e.ABONO_INTERES_IVA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ABONO_INTERES_IVA", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.CODIBANCO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}CODIBANCO", aliasTabla)), -1))
        e.NO_DOCUMENTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NO_DOCUMENTO", aliasTabla))))
        e.FECHA_ULTMOV = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ULTMOV", aliasTabla))))
        e.TASAINT = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TASAINT", aliasTabla)), -1))
        e.SALDO_INICIAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}SALDO_INICIAL", aliasTabla)), -1))
        e.TIPO_INTERES = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TIPO_INTERES", aliasTabla))))
        e.PLAZO_DIAS = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}PLAZO_DIAS", aliasTabla)), -1))
        e.ID_PLANILLA_BASE = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PLANILLA_BASE", aliasTabla)), -1))
        e.ID_CATORCENA_VTO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CATORCENA_VTO", aliasTabla)), -1))
    End Sub

    Public Sub AsignarCREDITO_ENCA_TRANS(ByVal dr As IDataReader, ByRef e As CREDITO_ENCA_TRANS, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New CREDITO_ENCA_TRANS
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_CREDITO_ENCA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CREDITO_ENCA", aliasTabla))))
        e.CODTRANSPORT = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}CODTRANSPORT", aliasTabla)), -1))
        e.ID_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA", aliasTabla)), -1))
        e.ZAFRA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ZAFRA", aliasTabla))))
        e.ID_TIPO_COMPROB = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_COMPROB", aliasTabla)), -1))
        e.ID_CUENTA_FINAN = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CUENTA_FINAN", aliasTabla)), -1))
        e.DESCRIP_FINAN = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DESCRIP_FINAN", aliasTabla))))
        e.ID_PROVEE = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PROVEE", aliasTabla)), -1))
        e.FECHA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA", aliasTabla))))
        e.NO_COMPROB = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NO_COMPROB", aliasTabla))))
        e.FECHA_APLIC = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_APLIC", aliasTabla))))
        e.FECHA_ULTMOV = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ULTMOV", aliasTabla))))
        e.UID_REFERENCIA = ObtenerValor(dr.Item(String.Format("{0}UID_REFERENCIA", aliasTabla)))
        e.TASAINT = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TASAINT", aliasTabla))))
        e.CARGO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}CARGO", aliasTabla))))
        e.ABONO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ABONO", aliasTabla))))
        e.SALDO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}SALDO", aliasTabla))))
        e.INTERES = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}INTERES", aliasTabla))))
        e.IVA_INTERES = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}IVA_INTERES", aliasTabla))))
        e.ABONO_IVA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ABONO_IVA", aliasTabla))))
        e.ABONO_INTERES = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ABONO_INTERES", aliasTabla))))
        e.ABONO_INTERES_IVA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ABONO_INTERES_IVA", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.ES_SALDO_INSOLUTO = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}ES_SALDO_INSOLUTO", aliasTabla))))
        e.TIPO_INTERES = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TIPO_INTERES", aliasTabla))))
    End Sub

    Public Sub AsignarCCF_DETA_TRANS(ByVal dr As IDataReader, ByRef e As CCF_DETA_TRANS, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New CCF_DETA_TRANS
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_CCF_DETA_TRANS = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CCF_DETA_TRANS", aliasTabla))))
        e.ID_CCF_TRANS = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CCF_TRANS", aliasTabla)), -1))
        e.ID_PRODUCTO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PRODUCTO", aliasTabla)), -1))
        e.NOMBRE_PRODUCTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_PRODUCTO", aliasTabla))))
        e.PRESENTACION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}PRESENTACION", aliasTabla))))
        e.CANTIDAD = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}CANTIDAD", aliasTabla)), -1))
        e.PRECIO_UNITARIO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PRECIO_UNITARIO", aliasTabla)), -1))
        e.TOTAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TOTAL", aliasTabla)), -1))
    End Sub

    Public Sub AsignarCCF_ENCA_TRANS(ByVal dr As IDataReader, ByRef e As CCF_ENCA_TRANS, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New CCF_ENCA_TRANS
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_CCF_TRANS = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CCF_TRANS", aliasTabla))))
        e.CODTRANSPORT = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}CODTRANSPORT", aliasTabla)), -1))
        e.ID_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA", aliasTabla)), -1))
        e.ID_SOLICITUD = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_SOLICITUD", aliasTabla)), -1))
        e.ID_CUENTA_FINAN = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CUENTA_FINAN", aliasTabla)), -1))
        e.ID_TIPO_COMPROB = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_COMPROB", aliasTabla)), -1))
        e.ID_PROVEE = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PROVEE", aliasTabla)), -1))
        e.NO_CCF = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NO_CCF", aliasTabla))))
        e.CONDI_COMPRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}CONDI_COMPRA", aliasTabla)), -1))
        e.UID_CCF = ObtenerValor(dr.Item(String.Format("{0}UID_CCF", aliasTabla)))
        e.FECHA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA", aliasTabla))))
        e.SUB_TOTAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}SUB_TOTAL", aliasTabla)), -1))
        e.DESCTO_PORC = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}DESCTO_PORC", aliasTabla)), -1))
        e.DESCTO_MONTO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}DESCTO_MONTO", aliasTabla)), -1))
        e.SUMAS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}SUMAS", aliasTabla)), -1))
        e.IVA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}IVA", aliasTabla)), -1))
        e.TOTAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TOTAL", aliasTabla)), -1))
        e.USUARIO_CREACION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREACION", aliasTabla))))
        e.FECHA_CREACION = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREACION", aliasTabla))))
        e.CESC = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}CESC", aliasTabla)), -1))
    End Sub

    Public Sub AsignarESTADO_SOLIC(ByVal dr As IDataReader, ByRef e As ESTADO_SOLIC, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New ESTADO_SOLIC
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_ESTADO_SOLIC = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ESTADO_SOLIC", aliasTabla))))
        e.DESCRIP_ESTADO_SOLIC = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DESCRIP_ESTADO_SOLIC", aliasTabla))))
    End Sub

    Public Sub AsignarSOLIC_PROD_TRANS(ByVal dr As IDataReader, ByRef e As SOLIC_PROD_TRANS, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New SOLIC_PROD_TRANS
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_SOLIC_PROD_TRANS = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_SOLIC_PROD_TRANS", aliasTabla))))
        e.ID_SOLICITUD = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_SOLICITUD", aliasTabla)), -1))
        e.ID_PROVEE = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PROVEE", aliasTabla)), -1))
        e.ID_PRODUCTO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PRODUCTO", aliasTabla)), -1))
        e.NOMBRE_PRODUCTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_PRODUCTO", aliasTabla))))
        e.PRESENTACION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}PRESENTACION", aliasTabla))))
        e.CANTIDAD = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}CANTIDAD", aliasTabla)), -1))
        e.PRECIO_UNITARIO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PRECIO_UNITARIO", aliasTabla)), -1))
        e.SUB_TOTAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}SUB_TOTAL", aliasTabla)), -1))
    End Sub

    Public Sub AsignarSOLIC_ENCA_TRANS(ByVal dr As IDataReader, ByRef e As SOLIC_ENCA_TRANS, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New SOLIC_ENCA_TRANS
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_SOLICITUD = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_SOLICITUD", aliasTabla))))
        e.ID_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA", aliasTabla)), -1))
        e.ID_CONTRA_TRANS = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CONTRA_TRANS", aliasTabla)), -1))
        e.ID_CUENTA_FINAN = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CUENTA_FINAN", aliasTabla)), -1))
        e.CONDI_COMPRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}CONDI_COMPRA", aliasTabla)), -1))
        e.NUM_SOLIC_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}NUM_SOLIC_ZAFRA", aliasTabla)), -1))
        e.CODTRANSPORT = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}CODTRANSPORT", aliasTabla)), -1))
        e.ACTIVIDAD = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ACTIVIDAD", aliasTabla))))
        e.FECHA_SOLIC = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_SOLIC", aliasTabla))))
        e.ID_CONTRA_TRANS_VEHI = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CONTRA_TRANS_VEHI", aliasTabla)), -1))
        e.ID_TRANSPORTE = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TRANSPORTE", aliasTabla)), -1))
        e.SUB_TOTAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}SUB_TOTAL", aliasTabla)), -1))
        e.IVA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}IVA", aliasTabla)), -1))
        e.TOTAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TOTAL", aliasTabla)), -1))
        e.ID_ESTADO_SOLIC = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ESTADO_SOLIC", aliasTabla)), -1))
        e.UID_SOLIC_ENCA_TRANS = ObtenerValor(dr.Item(String.Format("{0}UID_SOLIC_ENCA_TRANS", aliasTabla)))
        e.OBSERVACIONES = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}OBSERVACIONES", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.ZAFRA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ZAFRA", aliasTabla))))
        e.CESC = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}CESC", aliasTabla)), -1))
    End Sub

    Public Sub AsignarSOLIC_OIP_TRANS(ByVal dr As IDataReader, ByRef e As SOLIC_OIP_TRANS, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New SOLIC_OIP_TRANS
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_OIP_TRANS = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_OIP_TRANS", aliasTabla))))
        e.CODTRANSPORT = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}CODTRANSPORT", aliasTabla)), -1))
        e.ID_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA", aliasTabla)), -1))
        e.CODIBANCO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}CODIBANCO", aliasTabla)), -1))
        e.FECHA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA", aliasTabla))))
        e.MONTO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MONTO", aliasTabla)), -1))
        e.CUOTA_CORTE = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}CUOTA_CORTE", aliasTabla)), -1))
        e.UID_OIP_TRANS = ObtenerValor(dr.Item(String.Format("{0}UID_OIP_TRANS", aliasTabla)))
        e.PORC_DESC = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PORC_DESC", aliasTabla)), -1))
        e.PORC_DESCEFECTIVO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PORC_DESCEFECTIVO", aliasTabla)), -1))
        e.NUM_OIP_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}NUM_OIP_ZAFRA", aliasTabla)), -1))
        e.REFERENCIA_GF = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}REFERENCIA_GF", aliasTabla))))
        e.ES_ACEPTADA = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}ES_ACEPTADA", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub



    Public Sub AsignarPLANILLA_BASE(ByVal dr As IDataReader, ByRef e As PLANILLA_BASE, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New PLANILLA_BASE
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_PLANILLA_BASE = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PLANILLA_BASE", aliasTabla))))
        e.ID_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA", aliasTabla))))
        e.ID_CATORCENA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CATORCENA", aliasTabla))))
        e.ID_TIPO_PLANILLA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_PLANILLA", aliasTabla))))
        e.FECHA_INICIO = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_INICIO", aliasTabla))))
        e.FECHA_FIN = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_FIN", aliasTabla))))
        e.FECHA_PAGO = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_PAGO", aliasTabla))))
        e.NO_ANTICIPO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}NO_ANTICIPO", aliasTabla)), -1))
        e.NO_ANTICIPO_LETRAS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NO_ANTICIPO_LETRAS", aliasTabla))))
        e.VALOR_UNIT_PAGO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}VALOR_UNIT_PAGO", aliasTabla)), -1))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.CONCEPTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CONCEPTO", aliasTabla))))
        e.FECHA_COMPROB = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_COMPROB", aliasTabla))))
        e.CTACONTA_PLANI_CANA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CTACONTA_PLANI_CANA", aliasTabla))))
    End Sub


    Public Sub AsignarPLANTILLA_PRODU_DATOS(ByVal dr As IDataReader, ByRef e As PLANTILLA_PRODU_DATOS, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New PLANTILLA_PRODU_DATOS
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_PLANTI_DATOS = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PLANTI_DATOS", aliasTabla))))
        e.ID_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA", aliasTabla)), -1))
        e.ID_CATORCENA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CATORCENA", aliasTabla)), -1))
        e.UID_REFERENCIA = ObtenerValor(dr.Item(String.Format("{0}UID_REFERENCIA", aliasTabla)))
        e.PRODUCTOR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}PRODUCTOR", aliasTabla))))
        e.CODIPROVEEDOR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIPROVEEDOR", aliasTabla))))
        e.ID_CREDITO_ENCA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CREDITO_ENCA", aliasTabla)), -1))
        e.ID_CUENTA_FINAN = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CUENTA_FINAN", aliasTabla)), -1))
        e.ID_PROVEE = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PROVEE", aliasTabla)), -1))
        e.CONCEPTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CONCEPTO", aliasTabla))))
        e.PAGO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PAGO", aliasTabla)), -1))
        e.SALDO_INI = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}SALDO_INI", aliasTabla)), -1))
        e.INTERES = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}INTERES", aliasTabla)), -1))
        e.ABONO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ABONO", aliasTabla)), -1))
        e.ABONO_INTERES = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ABONO_INTERES", aliasTabla)), -1))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.CODIPROVEE = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}CODIPROVEE", aliasTabla)), -1))
        e.FECHA_APLIC = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_APLIC", aliasTabla))))
        e.FECHA_ULTMOV = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ULTMOV", aliasTabla))))
        e.TASAINT = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TASAINT", aliasTabla)), -1))
        e.TIPO_INTERES = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TIPO_INTERES", aliasTabla))))
        e.IVA_INTERES = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}IVA_INTERES", aliasTabla)), -1))
        e.PORC_CANA_PEND = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PORC_CANA_PEND", aliasTabla)), -1))
        e.MONTO_CANA_PEND = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MONTO_CANA_PEND", aliasTabla)), -1))
    End Sub


    Public Sub AsignarPLANTILLA_PRODU_COLU(ByVal dr As IDataReader, ByRef e As PLANTILLA_PRODU_COLU, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New PLANTILLA_PRODU_COLU
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_PLANTI_COLU = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PLANTI_COLU", aliasTabla))))
        e.UID_REFERENCIA = ObtenerValor(dr.Item(String.Format("{0}UID_REFERENCIA", aliasTabla)))
        e.ORDEN_HOJA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ORDEN_HOJA", aliasTabla)), -1))
        e.ORDEN_DESCTO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ORDEN_DESCTO", aliasTabla)), -1))
        e.ID_PROVEE = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PROVEE", aliasTabla)), -1))
        e.CODIBANCO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}CODIBANCO", aliasTabla)), -1))
        e.ID_CUENTA_FINAN = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CUENTA_FINAN", aliasTabla)), -1))
        e.CONCEPTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CONCEPTO", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
    End Sub

    Public Sub AsignarREMESA_ENCA_PRODU(ByVal dr As IDataReader, ByRef e As REMESA_ENCA_PRODU, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New REMESA_ENCA_PRODU
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_REMESA_ENCA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_REMESA_ENCA", aliasTabla))))
        e.CODIPROVEEDOR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIPROVEEDOR", aliasTabla))))
        e.CODIBANCO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}CODIBANCO", aliasTabla))))
        e.FECHA_REMESA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_REMESA", aliasTabla))))
        e.UID_REMESA_ENCA = ObtenerValor(dr.Item(String.Format("{0}UID_REMESA_ENCA", aliasTabla)))
        e.NO_REMESA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NO_REMESA", aliasTabla))))
        e.OBSERVACION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}OBSERVACION", aliasTabla))))
        e.ABONO_CAPITAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ABONO_CAPITAL", aliasTabla))))
        e.ABONO_INTERES = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ABONO_INTERES", aliasTabla))))
        e.ABONO_INTERES_IVA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ABONO_INTERES_IVA", aliasTabla))))
        e.TOTAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TOTAL", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub

    Public Sub AsignarREMESA_DETA_PRODU(ByVal dr As IDataReader, ByRef e As REMESA_DETA_PRODU, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New REMESA_DETA_PRODU
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_REMESA_DETA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_REMESA_DETA", aliasTabla))))
        e.ID_REMESA_ENCA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_REMESA_ENCA", aliasTabla)), -1))
        e.ID_CREDITO_ENCA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CREDITO_ENCA", aliasTabla)), -1))
        e.UID_REMESA_DETA = ObtenerValor(dr.Item(String.Format("{0}UID_REMESA_DETA", aliasTabla)))
        e.ABONO_CAPITAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ABONO_CAPITAL", aliasTabla))))
        e.ABONO_INTERES = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ABONO_INTERES", aliasTabla))))
        e.ABONO_INTERES_IVA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ABONO_INTERES_IVA", aliasTabla))))
    End Sub

    Public Sub AsignarCREDITO_MOV(ByVal dr As IDataReader, ByRef e As CREDITO_MOV, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New CREDITO_MOV
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_CREDITO_MOV = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CREDITO_MOV", aliasTabla))))
        e.ID_CREDITO_ENCA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CREDITO_ENCA", aliasTabla))))
        e.FECHA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA", aliasTabla))))
        e.UID_REFERENCIA = ObtenerValor(dr.Item(String.Format("{0}UID_REFERENCIA", aliasTabla)))
        e.ID_CATORCENA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CATORCENA", aliasTabla)), -1))
        e.CARGO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}CARGO", aliasTabla))))
        e.ABONO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ABONO", aliasTabla))))
        e.SALDO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}SALDO", aliasTabla))))
        e.ABONO_IVA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ABONO_IVA", aliasTabla))))
        e.ABONO_INTERES = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ABONO_INTERES", aliasTabla))))
        e.ABONO_INTERES_IVA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ABONO_INTERES_IVA", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.CODIBANCO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}CODIBANCO", aliasTabla)), -1))
        e.NO_DOCUMENTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NO_DOCUMENTO", aliasTabla))))
        e.FECHA_ULTMOV = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ULTMOV", aliasTabla))))
        e.TASAINT = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TASAINT", aliasTabla)), -1))
        e.SALDO_INICIAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}SALDO_INICIAL", aliasTabla)), -1))
        e.TIPO_INTERES = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TIPO_INTERES", aliasTabla))))
        e.PLAZO_DIAS = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}PLAZO_DIAS", aliasTabla)), -1))
        e.ID_PLANILLA_BASE = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PLANILLA_BASE", aliasTabla)), -1))
    End Sub


    Public Sub AsignarCREDITO_ENCA(ByVal dr As IDataReader, ByRef e As CREDITO_ENCA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New CREDITO_ENCA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_CREDITO_ENCA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CREDITO_ENCA", aliasTabla))))
        e.CODIPROVEEDOR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIPROVEEDOR", aliasTabla))))
        e.ID_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA", aliasTabla)), -1))
        e.ZAFRA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ZAFRA", aliasTabla))))
        e.ID_TIPO_COMPROB = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_COMPROB", aliasTabla)), -1))
        e.ID_CUENTA_FINAN = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CUENTA_FINAN", aliasTabla)), -1))
        e.DESCRIP_FINAN = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DESCRIP_FINAN", aliasTabla))))
        e.ID_PROVEE = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PROVEE", aliasTabla)), -1))
        e.FECHA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA", aliasTabla))))
        e.NO_COMPROB = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NO_COMPROB", aliasTabla))))
        e.FECHA_APLIC = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_APLIC", aliasTabla))))
        e.FECHA_ULTMOV = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ULTMOV", aliasTabla))))
        e.UID_REFERENCIA = ObtenerValor(dr.Item(String.Format("{0}UID_REFERENCIA", aliasTabla)))
        e.TASAINT = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TASAINT", aliasTabla))))
        e.CARGO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}CARGO", aliasTabla))))
        e.ABONO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ABONO", aliasTabla))))
        e.SALDO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}SALDO", aliasTabla))))
        e.INTERES = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}INTERES", aliasTabla))))
        e.IVA_INTERES = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}IVA_INTERES", aliasTabla))))
        e.ABONO_IVA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ABONO_IVA", aliasTabla))))
        e.ABONO_INTERES = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ABONO_INTERES", aliasTabla))))
        e.ABONO_INTERES_IVA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ABONO_INTERES_IVA", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.ES_SALDO_INSOLUTO = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}ES_SALDO_INSOLUTO", aliasTabla))))
        e.TIPO_INTERES = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TIPO_INTERES", aliasTabla))))
        e.ID_PROVEEDOR_ROZA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PROVEEDOR_ROZA", aliasTabla)), -1))
    End Sub

    Public Sub AsignarSOLIC_AGRICOLA_ESTADO(ByVal dr As IDataReader, ByRef e As SOLIC_AGRICOLA_ESTADO, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New SOLIC_AGRICOLA_ESTADO
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_SOLIC_ESTADO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_SOLIC_ESTADO", aliasTabla))))
        e.NOMBRE_ESTADO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_ESTADO", aliasTabla))))
    End Sub

    Public Sub AsignarSALBODE_ENCA(ByVal dr As IDataReader, ByRef e As SALBODE_ENCA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New SALBODE_ENCA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_SALBODE_ENCA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_SALBODE_ENCA", aliasTabla))))
        e.ID_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA", aliasTabla))))
        e.NO_DOCUMENTO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}NO_DOCUMENTO", aliasTabla))))
        e.FECHA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA", aliasTabla))))
        e.USUARIO_CREACION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREACION", aliasTabla))))
        e.FECHA_CREACION = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREACION", aliasTabla))))
        e.NUMS_SOLICITUDES = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NUMS_SOLICITUDES", aliasTabla))))
        e.RETIRO_PROD = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}RETIRO_PROD", aliasTabla))))
    End Sub

    Public Sub AsignarSALBODE_DETA(ByVal dr As IDataReader, ByRef e As SALBODE_DETA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New SALBODE_DETA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_SALBODE_DETA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_SALBODE_DETA", aliasTabla))))
        e.ID_SALBODE_ENCA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_SALBODE_ENCA", aliasTabla))))
        e.ID_SOLICITUD = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_SOLICITUD", aliasTabla))))
        e.ID_PRODUCTO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PRODUCTO", aliasTabla)), -1))
        e.NOMBRE_PRODUCTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_PRODUCTO", aliasTabla))))
        e.UNIDAD = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}UNIDAD", aliasTabla))))
        e.PRESENTACION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}PRESENTACION", aliasTabla))))
        e.CANTIDAD = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}CANTIDAD", aliasTabla)), -1))
        e.PRECIO_UNITARIO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PRECIO_UNITARIO", aliasTabla)), -1))
        e.TOTAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TOTAL", aliasTabla)), -1))
        e.CANT_ENTREGADA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}CANT_ENTREGADA", aliasTabla)), -1))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.CANT_ANULADA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}CANT_ANULADA", aliasTabla)), -1))
        e.ID_ESTADO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ESTADO", aliasTabla)), -1))
    End Sub

    Public Sub AsignarCCF_DETA(ByVal dr As IDataReader, ByRef e As CCF_DETA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New CCF_DETA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_CCF_DETA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CCF_DETA", aliasTabla))))
        e.ID_CCF_ENCA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CCF_ENCA", aliasTabla)), -1))
        e.ID_PRODUCTO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PRODUCTO", aliasTabla)), -1))
        e.NOMBRE_PRODUCTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_PRODUCTO", aliasTabla))))
        e.UNIDAD = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}UNIDAD", aliasTabla))))
        e.PRESENTACION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}PRESENTACION", aliasTabla))))
        e.CANTIDAD = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}CANTIDAD", aliasTabla)), -1))
        e.PRECIO_UNITARIO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PRECIO_UNITARIO", aliasTabla)), -1))
        e.TOTAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TOTAL", aliasTabla)), -1))
    End Sub


    Public Sub AsignarCCF_DETA_SALBODE(ByVal dr As IDataReader, ByRef e As CCF_DETA_SALBODE, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New CCF_DETA_SALBODE
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_CCF_DETA_SAL = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CCF_DETA_SAL", aliasTabla))))
        e.ID_CCF_ENCA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CCF_ENCA", aliasTabla))))
        e.ID_SALBODE_DETA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_SALBODE_DETA", aliasTabla))))
        e.ID_SOLICITUD = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_SOLICITUD", aliasTabla))))
        e.ID_PRODUCTO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PRODUCTO", aliasTabla))))
        e.NOMBRE_PRODUCTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_PRODUCTO", aliasTabla))))
        e.PRESENTACION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}PRESENTACION", aliasTabla))))
        e.CANTIDAD_CCF = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}CANTIDAD_CCF", aliasTabla))))
        e.PRECIO_UNITARIO_CCF = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PRECIO_UNITARIO_CCF", aliasTabla))))
        e.TOTAL_CCF = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TOTAL_CCF", aliasTabla))))
    End Sub


    Public Sub AsignarCCF_ENCA(ByVal dr As IDataReader, ByRef e As CCF_ENCA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New CCF_ENCA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_CCF_ENCA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CCF_ENCA", aliasTabla))))
        e.ID_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA", aliasTabla)), -1))
        e.ID_SOLICITUD = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_SOLICITUD", aliasTabla)), -1))
        e.ID_ORDEN = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ORDEN", aliasTabla)), -1))
        e.ID_CUENTA_FINAN = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CUENTA_FINAN", aliasTabla)), -1))
        e.ID_TIPO_COMPROB = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_COMPROB", aliasTabla)), -1))
        e.NO_CCF = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NO_CCF", aliasTabla))))
        e.FECHA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA", aliasTabla))))
        e.CODIPROVEEDOR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIPROVEEDOR", aliasTabla))))
        e.SUB_TOTAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}SUB_TOTAL", aliasTabla)), -1))
        e.DESCTO_PORC = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}DESCTO_PORC", aliasTabla)), -1))
        e.DESCTO_MONTO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}DESCTO_MONTO", aliasTabla)), -1))
        e.SUMAS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}SUMAS", aliasTabla)), -1))
        e.IVA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}IVA", aliasTabla)), -1))
        e.TOTAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TOTAL", aliasTabla)), -1))
        e.TOTAL_LETRAS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TOTAL_LETRAS", aliasTabla))))
        e.USUARIO_CREACION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREACION", aliasTabla))))
        e.FECHA_CREACION = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREACION", aliasTabla))))
        e.CONDI_COMPRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}CONDI_COMPRA", aliasTabla)), -1))
        e.ID_PROVEE = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PROVEE", aliasTabla)), -1))
        e.CONCEPTO_CCF = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}CONCEPTO_CCF", aliasTabla)), -1))
        e.UID_REFERENCIA_CCF = ObtenerValor(dr.Item(String.Format("{0}UID_REFERENCIA_CCF", aliasTabla)))
        e.FOVIAL_COTRANS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}FOVIAL_COTRANS", aliasTabla))))
    End Sub



    Public Sub AsignarKARDEX(ByVal dr As IDataReader, ByRef e As KARDEX, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New KARDEX
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_KARDEX = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_KARDEX", aliasTabla))))
        e.FECHA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA", aliasTabla))))
        e.REFERENCIA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}REFERENCIA", aliasTabla))))
        e.UID_DOCUMENTO = ObtenerValor(dr.Item(String.Format("{0}UID_DOCUMENTO", aliasTabla)))
        e.ID_TIPO_MOVTO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_MOVTO", aliasTabla))))
        e.ID_PRODUCTO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PRODUCTO", aliasTabla))))
        e.ENT_UNIDAD = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ENT_UNIDAD", aliasTabla))))
        e.ENT_PRECIO_UNITARIO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ENT_PRECIO_UNITARIO", aliasTabla))))
        e.ENT_TOTAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ENT_TOTAL", aliasTabla))))
        e.SAL_UNIDAD = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}SAL_UNIDAD", aliasTabla))))
        e.SAL_PRECIO_UNITARIO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}SAL_PRECIO_UNITARIO", aliasTabla))))
        e.SAL_TOTAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}SAL_TOTAL", aliasTabla))))
        e.SDO_UNIDAD = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}SDO_UNIDAD", aliasTabla))))
        e.SDO_PRECIO_UNITARIO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}SDO_PRECIO_UNITARIO", aliasTabla))))
        e.SDO_TOTAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}SDO_TOTAL", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.ID_BODEGA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_BODEGA", aliasTabla))))
        e.UID_DOCUMENTO_DETA = ObtenerValor(dr.Item(String.Format("{0}UID_DOCUMENTO_DETA", aliasTabla)))
        e.ID_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA", aliasTabla)), -1))
    End Sub

    Public Sub AsignarDOCUMENTO_SALIDA_ENCA(ByVal dr As IDataReader, ByRef e As DOCUMENTO_SALIDA_ENCA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New DOCUMENTO_SALIDA_ENCA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_DOCSAL_ENCA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_DOCSAL_ENCA", aliasTabla))))
        e.NO_DOCUMENTO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}NO_DOCUMENTO", aliasTabla))))
        e.ID_TIPO_MOVTO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_MOVTO", aliasTabla))))
        e.FECHA_DOCTO = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_DOCTO", aliasTabla))))
        e.UID_DOCUMENTO = ObtenerValor(dr.Item(String.Format("{0}UID_DOCUMENTO", aliasTabla)))
        e.ID_BODEGA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_BODEGA", aliasTabla)), -1))
        e.OBSERVACIONES = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}OBSERVACIONES", aliasTabla))))
        e.ENTREGADO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ENTREGADO", aliasTabla))))
        e.RECIBIDO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}RECIBIDO", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.ID_SALBODE_ENCA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_SALBODE_ENCA", aliasTabla)), -1))
        e.ID_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA", aliasTabla)), -1))
    End Sub

    Public Sub AsignarDOCUMENTO_SALIDA_DETA(ByVal dr As IDataReader, ByRef e As DOCUMENTO_SALIDA_DETA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New DOCUMENTO_SALIDA_DETA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_DOCSAL_ENCA_DETA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_DOCSAL_ENCA_DETA", aliasTabla))))
        e.ID_DOCSAL_ENCA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_DOCSAL_ENCA", aliasTabla))))
        e.ID_PRODUCTO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PRODUCTO", aliasTabla))))
        e.CANTIDAD = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}CANTIDAD", aliasTabla))))
        e.PRECIO_UNITARIO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PRECIO_UNITARIO", aliasTabla))))
        e.TOTAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TOTAL", aliasTabla))))
        e.UNIDAD = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}UNIDAD", aliasTabla))))
        e.PRESENTACION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}PRESENTACION", aliasTabla))))
        e.NOMBRE_PRODUCTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_PRODUCTO", aliasTabla))))
        e.UID_DOCUMENTO_DETA = ObtenerValor(dr.Item(String.Format("{0}UID_DOCUMENTO_DETA", aliasTabla)))
    End Sub

    Public Sub AsignarDOCUMENTO_ENTRADA_ENCA(ByVal dr As IDataReader, ByRef e As DOCUMENTO_ENTRADA_ENCA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New DOCUMENTO_ENTRADA_ENCA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_DOCENTRA_ENCA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_DOCENTRA_ENCA", aliasTabla))))
        e.ID_BODEGA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_BODEGA", aliasTabla))))
        e.NO_DOCUMENTO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}NO_DOCUMENTO", aliasTabla))))
        e.FEC_DOCTO = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FEC_DOCTO", aliasTabla))))
        e.ID_TIPO_MOVTO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_MOVTO", aliasTabla))))
        e.UID_DOCUMENTO = ObtenerValor(dr.Item(String.Format("{0}UID_DOCUMENTO", aliasTabla)))
        e.TOTAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TOTAL", aliasTabla))))
        e.ID_PROVEE = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PROVEE", aliasTabla)), -1))
        e.FORMA_ENTREGA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}FORMA_ENTREGA", aliasTabla)), -1))
        e.ID_ORDEN = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ORDEN", aliasTabla)), -1))
        e.NO_COMPROB = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NO_COMPROB", aliasTabla))))
        e.ID_TIPO_COMPROB = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_COMPROB", aliasTabla)), -1))
        e.FECHA_COMPROB = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_COMPROB", aliasTabla))))
        e.OBSERVACIONES = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}OBSERVACIONES", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.ID_DOCSAL_ENCA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_DOCSAL_ENCA", aliasTabla)), -1))
        e.ID_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA", aliasTabla)), -1))
    End Sub

    Public Sub AsignarDOCUMENTO_ENTRADA_DETA(ByVal dr As IDataReader, ByRef e As DOCUMENTO_ENTRADA_DETA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New DOCUMENTO_ENTRADA_DETA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_DOCENTRA_ENCA_DETA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_DOCENTRA_ENCA_DETA", aliasTabla))))
        e.ID_DOCENTRA_ENCA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_DOCENTRA_ENCA", aliasTabla))))
        e.ID_PRODUCTO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PRODUCTO", aliasTabla))))
        e.CANTIDAD = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}CANTIDAD", aliasTabla)), -1))
        e.PRECIO_UNITARIO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PRECIO_UNITARIO", aliasTabla)), -1))
        e.TOTAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TOTAL", aliasTabla))))
        e.ID_ORDEN_DETA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ORDEN_DETA", aliasTabla)), -1))
        e.UNIDAD = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}UNIDAD", aliasTabla))))
        e.PRESENTACION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}PRESENTACION", aliasTabla))))
        e.NOMBRE_PRODUCTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_PRODUCTO", aliasTabla))))
        e.FECHA_VTO = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_VTO", aliasTabla))))
        e.UID_DOCUMENTO_DETA = ObtenerValor(dr.Item(String.Format("{0}UID_DOCUMENTO_DETA", aliasTabla)))
    End Sub

    Public Sub AsignarTIPO_MOVTO(ByVal dr As IDataReader, ByRef e As TIPO_MOVTO, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New TIPO_MOVTO
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_TIPO_MOVTO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_MOVTO", aliasTabla))))
        e.NOMBRE_TIPO_MOVTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_TIPO_MOVTO", aliasTabla))))
        e.ES_ENTRADA = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}ES_ENTRADA", aliasTabla))))
        e.ES_SALIDA = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}ES_SALIDA", aliasTabla))))
    End Sub

    Public Sub AsignarTIPO_COMPROB(ByVal dr As IDataReader, ByRef e As TIPO_COMPROB, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New TIPO_COMPROB
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_TIPO_COMPROB = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_COMPROB", aliasTabla))))
        e.CODIGO_TIPO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_TIPO", aliasTabla))))
        e.NOMBRE_TIPO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_TIPO", aliasTabla))))
        e.VER_REGISTRO = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}VER_REGISTRO", aliasTabla))))
    End Sub

    Public Sub AsignarBODEGA(ByVal dr As IDataReader, ByRef e As BODEGA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New BODEGA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_BODEGA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_BODEGA", aliasTabla))))
        e.NOMBRE_BODEGA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_BODEGA", aliasTabla))))
    End Sub

    Public Sub AsignarUNIDAD_ORG(ByVal dr As IDataReader, ByRef e As UNIDAD_ORG, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New UNIDAD_ORG
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_UNIDAD_ORG = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_UNIDAD_ORG", aliasTabla))))
        e.NOMBRE_UNIDAD_ORG = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_UNIDAD_ORG", aliasTabla))))
    End Sub



    Public Sub AsignarORDEN_DETA_AGRI(ByVal dr As IDataReader, ByRef e As ORDEN_DETA_AGRI, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New ORDEN_DETA_AGRI
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_ORDEN_DETA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ORDEN_DETA", aliasTabla))))
        e.ID_ORDEN = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ORDEN", aliasTabla))))
        e.ID_PRODUCTO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PRODUCTO", aliasTabla)), -1))
        e.NOMBRE_PRODUCTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_PRODUCTO", aliasTabla))))
        e.UNIDAD = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}UNIDAD", aliasTabla))))
        e.PRESENTACION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}PRESENTACION", aliasTabla))))
        e.CANTIDAD = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}CANTIDAD", aliasTabla))))
        e.PRECIO_UNITARIO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PRECIO_UNITARIO", aliasTabla))))
        e.TOTAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TOTAL", aliasTabla))))
    End Sub

    Public Sub AsignarORDEN_COMPRA_AGRI(ByVal dr As IDataReader, ByRef e As ORDEN_COMPRA_AGRI, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New ORDEN_COMPRA_AGRI
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_ORDEN = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ORDEN", aliasTabla))))
        e.ID_PROVEE = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PROVEE", aliasTabla))))
        e.NO_ORDEN = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}NO_ORDEN", aliasTabla))))
        e.CODI_ORDEN = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODI_ORDEN", aliasTabla))))
        e.FECHA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA", aliasTabla))))
        e.ID_SOLICITUD = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_SOLICITUD", aliasTabla)), -1))
        e.CODIPROVEEDOR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIPROVEEDOR", aliasTabla))))
        e.CONDI_COMPRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}CONDI_COMPRA", aliasTabla))))
        e.SUB_TOTAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}SUB_TOTAL", aliasTabla))))
        e.IVA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}IVA", aliasTabla))))
        e.TOTAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TOTAL", aliasTabla))))
        e.CCF_NOMBRE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CCF_NOMBRE", aliasTabla))))
        e.LUGAR_ENTREGA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}LUGAR_ENTREGA", aliasTabla))))
        e.CONTACTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CONTACTO", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.ID_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA", aliasTabla)), -1))
    End Sub


    Public Sub AsignarSOLIC_OPI_CONTRATOS(ByVal dr As IDataReader, ByRef e As SOLIC_OPI_CONTRATOS, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New SOLIC_OPI_CONTRATOS
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_OPI_CONTRATO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_OPI_CONTRATO", aliasTabla))))
        e.ID_OPI = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_OPI", aliasTabla)), -1))
        e.CODICONTRATO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODICONTRATO", aliasTabla))))
    End Sub

    Public Sub AsignarPRE_ANALISIS_ENCA(ByVal dr As IDataReader, ByRef e As PRE_ANALISIS_ENCA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New PRE_ANALISIS_ENCA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_ENCA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ENCA", aliasTabla))))
        e.UID_REF = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}UID_REF", aliasTabla))))
        e.ID_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA", aliasTabla)), -1))
        e.FECHA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA", aliasTabla))))
        e.CODIPROVEEDOR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIPROVEEDOR", aliasTabla))))
        e.NOMBRE_PROVEEDOR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_PROVEEDOR", aliasTabla))))
        e.CONTRATOS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CONTRATOS", aliasTabla))))
        e.ZONAS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ZONAS", aliasTabla))))
        e.CAT_TC_MZ = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}CAT_TC_MZ", aliasTabla)), -1))
        e.CAT_TOTAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}CAT_TOTAL", aliasTabla)), -1))
        e.CAT_PORC = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}CAT_PORC", aliasTabla)), -1))
        e.COMENTARIO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}COMENTARIO", aliasTabla))))
        e.IMPRESO = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}IMPRESO", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.CODIAGRON = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIAGRON", aliasTabla))))
        e.CODIAGRON2 = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIAGRON2", aliasTabla))))
        e.CODIAGRON3 = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIAGRON3", aliasTabla))))
    End Sub

    Public Sub AsignarPRE_ANALISIS_DETA(ByVal dr As IDataReader, ByRef e As PRE_ANALISIS_DETA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New PRE_ANALISIS_DETA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_DETA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_DETA", aliasTabla))))
        e.ID_ENCA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ENCA", aliasTabla)), -1))
        e.UID_REF = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}UID_REF", aliasTabla))))
        e.ORDEN = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ORDEN", aliasTabla)), -1))
        e.NUMERO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NUMERO", aliasTabla))))
        e.DESCRIPCION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DESCRIPCION", aliasTabla))))
        e.TARIFA_CAT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TARIFA_CAT", aliasTabla))))
        e.TARIFA_CAT_DESCRIP = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TARIFA_CAT_DESCRIP", aliasTabla))))
        e.ID_CATE = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CATE", aliasTabla)), -1))
        e.ID_CATE_REF = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CATE_REF", aliasTabla)), -1))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.EDITAR = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}EDITAR", aliasTabla))))
        e.NEGRITA = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}NEGRITA", aliasTabla))))
        e.MONTO1 = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MONTO1", aliasTabla)), 0))
        e.MONTO2 = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MONTO2", aliasTabla)), 0))
        e.MONTO3 = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MONTO3", aliasTabla)), 0))
        e.MONTO4 = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MONTO4", aliasTabla)), 0))
        e.MONTO5 = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MONTO5", aliasTabla)), 0))
        e.MONTO6 = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MONTO6", aliasTabla)), 0))
        e.TOTAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TOTAL", aliasTabla)), 0))
    End Sub

    Public Sub AsignarPAGO_CTA_BANCO(ByVal dr As IDataReader, ByRef e As PAGO_CTA_BANCO, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New PAGO_CTA_BANCO
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_PAGO_CTA_BANCO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PAGO_CTA_BANCO", aliasTabla))))
        e.ID_CATORCENA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CATORCENA", aliasTabla))))
        e.CODIPROVEEDOR_TRANSPORTISTA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIPROVEEDOR_TRANSPORTISTA", aliasTabla))))
        e.ID_TIPO_PLANILLA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_PLANILLA", aliasTabla))))
        e.CODIBANCO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}CODIBANCO", aliasTabla))))
        e.NUM_CUENTA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NUM_CUENTA", aliasTabla))))
        e.ES_CTA_CORRIENTE = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}ES_CTA_CORRIENTE", aliasTabla))))
        e.MONTO_PAGO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MONTO_PAGO", aliasTabla))))
        e.ENTREGO_CCF = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}ENTREGO_CCF", aliasTabla))))
        e.PAGO_GENERADO = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}PAGO_GENERADO", aliasTabla))))
        e.FECHA_GENPAGO = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_GENPAGO", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub

    Public Sub AsignarIntermedia(ByVal dr As IDataReader, ByRef e As Intermedia, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New Intermedia
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.Envio = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}Envio", aliasTabla))))
        e.Vehiculo = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}Vehiculo", aliasTabla))))
        e.Hacienda = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}Hacienda", aliasTabla))))
        e.Fin_Envio = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}Fin_Envio", aliasTabla)), -1))
        e.Id_Maestro = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}Id_Maestro", aliasTabla)), -1))
    End Sub

    Public Sub AsignarCONTROL_QUEMA_SALDO(ByVal dr As IDataReader, ByRef e As CONTROL_QUEMA_SALDO, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New CONTROL_QUEMA_SALDO
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_QUEMA_SALDO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_QUEMA_SALDO", aliasTabla))))
        e.ID_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA", aliasTabla))))
        e.ACCESLOTE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ACCESLOTE", aliasTabla))))
        e.FECHA_HORA_QUEMA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_HORA_QUEMA", aliasTabla))))
        e.QUEMA_PROGRAMADA = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}QUEMA_PROGRAMADA", aliasTabla))))
        e.QUEMA_NOPROG = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}QUEMA_NOPROG", aliasTabla))))
        e.CANA_VERDE = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}CANA_VERDE", aliasTabla))))
        e.ES_PROYECCION = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}ES_PROYECCION", aliasTabla))))
        e.ENTRADAS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ENTRADAS", aliasTabla))))
        e.SALIDAS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}SALIDAS", aliasTabla))))
        e.SALDO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}SALDO", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.FECHA_HORA_QUEMA_PROY = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_HORA_QUEMA_PROY", aliasTabla))))
        e.FECHA_HORA_QUEMA_REAL = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_HORA_QUEMA_REAL", aliasTabla))))
        e.TC_PROY = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TC_PROY", aliasTabla)), -1))
        e.TC_REAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TC_REAL", aliasTabla)), -1))
        e.ID_SUBLOTES = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_SUBLOTES", aliasTabla)), -1))
    End Sub

    Public Sub AsignarLABFAB_CATEGORIA(ByVal dr As IDataReader, ByRef e As LABFAB_CATEGORIA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New LABFAB_CATEGORIA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_CATEG = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CATEG", aliasTabla))))
        e.NOM_CATEG = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOM_CATEG", aliasTabla))))
    End Sub

    Public Sub AsignarCAPACIDAD_TIPO_TRANS(ByVal dr As IDataReader, ByRef e As CAPACIDAD_TIPO_TRANS, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New CAPACIDAD_TIPO_TRANS
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_CAPACIDAD = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CAPACIDAD", aliasTabla))))
        e.ID_TIPO_CANA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_CANA", aliasTabla))))
        e.ID_TIPO_TRANS = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_TRANS", aliasTabla))))
        e.CAPACIDAD_TC = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}CAPACIDAD_TC", aliasTabla))))
    End Sub

    Public Sub AsignarLABFAB_INFOVARSXDIA(ByVal dr As IDataReader, ByRef e As LABFAB_INFOVARSXDIA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New LABFAB_INFOVARSXDIA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_INFOVARSXDIA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_INFOVARSXDIA", aliasTabla))))
        e.ID_INFO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_INFO", aliasTabla))))
        e.ID_INFOVAR = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_INFOVAR", aliasTabla))))
        e.ID_DIAZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_DIAZAFRA", aliasTabla)), -1))
        e.ID_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA", aliasTabla))))
        e.DIAZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}DIAZAFRA", aliasTabla))))
        e.NOMBRE_VAR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_VAR", aliasTabla))))
        e.VALOR = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}VALOR", aliasTabla)), -1))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub

    Public Sub AsignarLABFAB_INFOVAR(ByVal dr As IDataReader, ByRef e As LABFAB_INFOVAR, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New LABFAB_INFOVAR
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_INFOVAR = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_INFOVAR", aliasTabla))))
        e.ID_INFO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_INFO", aliasTabla))))
        e.ID_TIPOVAR = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPOVAR", aliasTabla))))
        e.ID_CATEG = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CATEG", aliasTabla))))
        e.ORDEN = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ORDEN", aliasTabla))))
        e.NOMBRE_INFOVAR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_INFOVAR", aliasTabla))))
        e.DESCRIP_VAR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DESCRIP_VAR", aliasTabla))))
        e.ID_ANALISIS_REF = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ANALISIS_REF", aliasTabla)), -1))
        e.ID_INFOVAR_REF = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_INFOVAR_REF", aliasTabla)), -1))
        e.SQLREPO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}SQLREPO", aliasTabla))))
    End Sub

    Public Sub AsignarLABFAB_INFORME(ByVal dr As IDataReader, ByRef e As LABFAB_INFORME, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New LABFAB_INFORME
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_INFO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_INFO", aliasTabla))))
        e.NOMBRE_INFO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_INFO", aliasTabla))))
    End Sub


    Public Sub AsignarLABFAB_VARSXANALISIS(ByVal dr As IDataReader, ByRef e As LABFAB_VARSXANALISIS, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New LABFAB_VARSXANALISIS
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_VARXANALISIS = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_VARXANALISIS", aliasTabla))))
        e.ID_ANALISISXDIA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ANALISISXDIA", aliasTabla))))
        e.ID_VAR = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_VAR", aliasTabla))))
        e.NOMBRE_VAR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_VAR", aliasTabla))))
        e.VALOR = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}VALOR", aliasTabla)), -1))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub

    Public Sub AsignarLABFAB_VAR(ByVal dr As IDataReader, ByRef e As LABFAB_VAR, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New LABFAB_VAR
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_VAR = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_VAR", aliasTabla))))
        e.ID_ANALISIS = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ANALISIS", aliasTabla))))
        e.ID_TIPOVAR = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPOVAR", aliasTabla))))
        e.NOMBRE_VAR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_VAR", aliasTabla))))
        e.DESCRIP_VAR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DESCRIP_VAR", aliasTabla))))
        e.ID_ANALISIS_REF = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ANALISIS_REF", aliasTabla)), -1))
        e.TABLA_REF = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TABLA_REF", aliasTabla))))
        e.COLUM1_REF = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}COLUM1_REF", aliasTabla))))
        e.COLUM2_REF = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}COLUM2_REF", aliasTabla))))
        e.COLUM_VALOR_REF = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}COLUM_VALOR_REF", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub


    Public Sub AsignarLABFAB_TIPOVAR(ByVal dr As IDataReader, ByRef e As LABFAB_TIPOVAR, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New LABFAB_TIPOVAR
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_TIPOVAR = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPOVAR", aliasTabla))))
        e.COD_TIPOVAR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}COD_TIPOVAR", aliasTabla))))
        e.NOMBRE_TIPOVAR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_TIPOVAR", aliasTabla))))
    End Sub

    Public Sub AsignarLABFAB_MUESTRA(ByVal dr As IDataReader, ByRef e As LABFAB_MUESTRA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New LABFAB_MUESTRA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_MUESTRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_MUESTRA", aliasTabla))))
        e.ID_ETAPA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ETAPA", aliasTabla)), -1))
        e.NOMBRE_MUESTRA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_MUESTRA", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub

    Public Sub AsignarLABFAB_ETAPA(ByVal dr As IDataReader, ByRef e As LABFAB_ETAPA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New LABFAB_ETAPA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_ETAPA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ETAPA", aliasTabla))))
        e.NOMBRE_ETAPA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_ETAPA", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub

    Public Sub AsignarLABFAB_DIAZAFRA(ByVal dr As IDataReader, ByRef e As LABFAB_DIAZAFRA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New LABFAB_DIAZAFRA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_DIAZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_DIAZAFRA", aliasTabla))))
        e.DIAZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}DIAZAFRA", aliasTabla))))
        e.ID_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA", aliasTabla)), -1))
        e.CIERRE_LABFAB = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}CIERRE_LABFAB", aliasTabla))))
        e.ACTIVO = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}ACTIVO", aliasTabla))))
    End Sub

    Public Sub AsignarLABFAB_ANALISISXDIA(ByVal dr As IDataReader, ByRef e As LABFAB_ANALISISXDIA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New LABFAB_ANALISISXDIA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_ANALISISXDIA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ANALISISXDIA", aliasTabla))))
        e.ID_DIAZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_DIAZAFRA", aliasTabla)), -1))
        e.ID_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA", aliasTabla))))
        e.DIAZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}DIAZAFRA", aliasTabla))))
        e.ID_ANALISIS = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ANALISIS", aliasTabla))))
        e.NO_ANALISIS = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}NO_ANALISIS", aliasTabla))))
        e.VALOR = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}VALOR", aliasTabla)), -1))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub


    Public Sub AsignarLABFAB_ANALISIS(ByVal dr As IDataReader, ByRef e As LABFAB_ANALISIS, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New LABFAB_ANALISIS
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_ANALISIS = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ANALISIS", aliasTabla))))
        e.ID_MUESTRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_MUESTRA", aliasTabla))))
        e.NOMBRE_ANALISIS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_ANALISIS", aliasTabla))))
        e.FORMULA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}FORMULA", aliasTabla))))
        e.OBSERVACIONES = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}OBSERVACIONES", aliasTabla))))
        e.CANT_ANALISIS = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}CANT_ANALISIS", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.ORDEN_EJEC = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ORDEN_EJEC", aliasTabla))))
    End Sub


    Public Sub AsignarFACTURA_SERVICIOS_DETA(ByVal dr As IDataReader, ByRef e As FACTURA_SERVICIOS_DETA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New FACTURA_SERVICIOS_DETA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_FACTURA_SERVICIOS_DETA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_FACTURA_SERVICIOS_DETA", aliasTabla))))
        e.ID_FACTURA_SERVICIOS_ENCA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_FACTURA_SERVICIOS_ENCA", aliasTabla))))
        e.DESCRIPCION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DESCRIPCION", aliasTabla))))
        e.CANTIDAD = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}CANTIDAD", aliasTabla)), -1))
        e.PRECIO_UNITARIO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PRECIO_UNITARIO", aliasTabla))))
        e.EXENTO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}EXENTO", aliasTabla))))
        e.AFECTO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}AFECTO", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub

    Public Sub AsignarFACTURA_SERVICIOS_ENCA(ByVal dr As IDataReader, ByRef e As FACTURA_SERVICIOS_ENCA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New FACTURA_SERVICIOS_ENCA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_FACTURA_SERVICIOS_ENCA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_FACTURA_SERVICIOS_ENCA", aliasTabla))))
        e.NO_DOCTO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}NO_DOCTO", aliasTabla))))
        e.TIPO_DOCTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TIPO_DOCTO", aliasTabla))))
        e.FECHA_EMISION = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_EMISION", aliasTabla))))
        e.ESTADO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ESTADO", aliasTabla))))
        e.CODICONTRATO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODICONTRATO", aliasTabla))))
        e.CODIPROVEEDOR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIPROVEEDOR", aliasTabla))))
        e.NOMBRE_PROVEEDOR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_PROVEEDOR", aliasTabla))))
        e.GIRO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}GIRO", aliasTabla))))
        e.DIRECCION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DIRECCION", aliasTabla))))
        e.DUI = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DUI", aliasTabla))))
        e.NIT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NIT", aliasTabla))))
        e.NRC = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NRC", aliasTabla))))
        e.EXENTO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}EXENTO", aliasTabla))))
        e.AFECTO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}AFECTO", aliasTabla))))
        e.PORC_DESCUENTO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PORC_DESCUENTO", aliasTabla))))
        e.DESCUENTO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}DESCUENTO", aliasTabla))))
        e.SUMAS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}SUMAS", aliasTabla))))
        e.IVA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}IVA", aliasTabla))))
        e.TOTAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TOTAL", aliasTabla))))
        e.CANT_LETRAS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CANT_LETRAS", aliasTabla))))
        e.ID_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA", aliasTabla))))
        e.ZAFRA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ZAFRA", aliasTabla))))
        e.UID_FACTURA_SERVICIOS = ObtenerValor(dr.Item(String.Format("{0}UID_FACTURA_SERVICIOS", aliasTabla)))
        e.UID_REFERENCIA = ObtenerValor(dr.Item(String.Format("{0}UID_REFERENCIA", aliasTabla)))
        e.ID_CUENTA_FINAN = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CUENTA_FINAN", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.USUARIO_ANUL = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ANUL", aliasTabla))))
        e.FECHA_ANUL = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ANUL", aliasTabla))))
    End Sub

    Public Sub AsignarMEMBRE_GREMIAL(ByVal dr As IDataReader, ByRef e As MEMBRE_GREMIAL, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New MEMBRE_GREMIAL
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_MEMBRE_GREMIAL = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_MEMBRE_GREMIAL", aliasTabla))))
        e.CODIPROVEEDOR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIPROVEEDOR", aliasTabla))))
        e.NUM_MEMBRE_GREMIAL = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}NUM_MEMBRE_GREMIAL", aliasTabla))))
        e.FECHA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA", aliasTabla))))
        e.ID_GREMIAL = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_GREMIAL", aliasTabla))))
        e.MONTO_X_TC = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MONTO_X_TC", aliasTabla))))
        e.UID_MEMBRE_CONTRATO = ObtenerValor(dr.Item(String.Format("{0}UID_MEMBRE_CONTRATO", aliasTabla)))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.ID_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA", aliasTabla))))
        e.ZAFRA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ZAFRA", aliasTabla))))
        e.ACTIVO = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}ACTIVO", aliasTabla))))
    End Sub

    Public Sub AsignarSOLIC_OPI(ByVal dr As IDataReader, ByRef e As SOLIC_OPI, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New SOLIC_OPI
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_OPI = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_OPI", aliasTabla))))
        e.CODIPROVEEDOR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIPROVEEDOR", aliasTabla))))
        e.FECHA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA", aliasTabla))))
        e.CODIBANCO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}CODIBANCO", aliasTabla))))
        e.MONTO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MONTO", aliasTabla))))
        e.PORC_DESCTO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PORC_DESCTO", aliasTabla))))
        e.UID_OPI_CONTRATO = ObtenerValor(dr.Item(String.Format("{0}UID_OPI_CONTRATO", aliasTabla)))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.ID_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA", aliasTabla))))
        e.ZAFRA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ZAFRA", aliasTabla))))
        e.REFERENCIA_GF = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}REFERENCIA_GF", aliasTabla))))
        e.NUM_OPI_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}NUM_OPI_ZAFRA", aliasTabla)), -1))
        e.ES_ACEPTADA = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}ES_ACEPTADA", aliasTabla))))
        e.NUM_OPI_PROVEE_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}NUM_OPI_PROVEE_ZAFRA", aliasTabla)), -1))
        e.PORC_DESCTO_PLA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PORC_DESCTO_PLA", aliasTabla)), -1))
        e.ID_ESTADO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ESTADO", aliasTabla)), -1))
        e.INTERES = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}INTERES", aliasTabla))))
        e.IVA_INTERES = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}IVA_INTERES", aliasTabla))))
    End Sub

    Public Sub AsignarSOLIC_ANTICIPO_CONTRATOS(ByVal dr As IDataReader, ByRef e As SOLIC_ANTICIPO_CONTRATOS, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New SOLIC_ANTICIPO_CONTRATOS
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_ANTI_CONTRATO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ANTI_CONTRATO", aliasTabla))))
        e.ID_ANTICIPO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ANTICIPO", aliasTabla)), -1))
        e.CODICONTRATO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODICONTRATO", aliasTabla))))
    End Sub


    Public Sub AsignarSOLIC_ANTICIPO(ByVal dr As IDataReader, ByRef e As SOLIC_ANTICIPO, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New SOLIC_ANTICIPO
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_ANTICIPO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ANTICIPO", aliasTabla))))
        e.CODIPROVEEDOR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIPROVEEDOR", aliasTabla))))
        e.NUM_ANTICIPO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}NUM_ANTICIPO", aliasTabla))))
        e.FECHA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA", aliasTabla))))
        e.CONCEPTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CONCEPTO", aliasTabla))))
        e.MONTO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MONTO", aliasTabla))))
        e.UID_ANTICIPO_CONTRATO = ObtenerValor(dr.Item(String.Format("{0}UID_ANTICIPO_CONTRATO", aliasTabla)))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.ID_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA", aliasTabla))))
        e.ZAFRA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ZAFRA", aliasTabla))))
        e.FECHA_CHEQUE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CHEQUE", aliasTabla))))
        e.PORC_INTERES = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PORC_INTERES", aliasTabla)), -1))
        e.ES_ACEPTADA = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}ES_ACEPTADA", aliasTabla))))
        e.CHQ_NO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CHQ_NO", aliasTabla))))
        e.ID_CUENTA_FINAN = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CUENTA_FINAN", aliasTabla)), -1))
        e.PLAZO_MESES = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}PLAZO_MESES", aliasTabla)), -1))
        e.FECHA_VENCE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_VENCE", aliasTabla))))
        e.ID_ESTADO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ESTADO", aliasTabla)), -1))
        e.PERFECHA_INI = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}PERFECHA_INI", aliasTabla))))
        e.PERFECHA_FIN = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}PERFECHA_FIN", aliasTabla))))
        e.DESTINO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DESTINO", aliasTabla))))
    End Sub

    Public Sub AsignarSOLIC_ANTICIPO_ZAFRA(ByVal dr As IDataReader, ByRef e As SOLIC_ANTICIPO_ZAFRA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New SOLIC_ANTICIPO_ZAFRA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_ANTI_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ANTI_ZAFRA", aliasTabla))))
        e.ID_ANTICIPO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ANTICIPO", aliasTabla))))
        e.ID_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA", aliasTabla))))
        e.FECHA_ULTMOV = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ULTMOV", aliasTabla))))
        e.CUOTA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}CUOTA", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
    End Sub


    Public Sub AsignarPROVEEDOR_CODIGOREL(ByVal dr As IDataReader, ByRef e As PROVEEDOR_CODIGOREL, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New PROVEEDOR_CODIGOREL
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_PROVEE_CODIGOREL = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PROVEE_CODIGOREL", aliasTabla))))
        e.CODIPROVEEDOR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIPROVEEDOR", aliasTabla))))
        e.CODIPROVEEDOR_REL = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIPROVEEDOR_REL", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub

    Public Sub AsignarPLAN_COSECHA_DIARIO(ByVal dr As IDataReader, ByRef e As PLAN_COSECHA_DIARIO, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New PLAN_COSECHA_DIARIO
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_PLAN_COSECHA_DIARIO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PLAN_COSECHA_DIARIO", aliasTabla))))
        e.ID_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA", aliasTabla))))
        e.ACCESLOTE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ACCESLOTE", aliasTabla))))
        e.ZONA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ZONA", aliasTabla))))
        e.CODILOTE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODILOTE", aliasTabla))))
        e.NOMBLOTE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBLOTE", aliasTabla))))
        e.CODIPROVEE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIPROVEE", aliasTabla))))
        e.CCODISOCIO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CCODISOCIO", aliasTabla))))
        e.PROVEEDOR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}PROVEEDOR", aliasTabla))))
        e.ROZA_PROYECTADA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ROZA_PROYECTADA", aliasTabla))))
        e.AUTORIZADO = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}AUTORIZADO", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.DIAZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}DIAZAFRA", aliasTabla)), -1))
    End Sub

    Public Sub AsignarSOLIC_APLICACION_VUELO(ByVal dr As IDataReader, ByRef e As SOLIC_APLICACION_VUELO, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New SOLIC_APLICACION_VUELO
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_SOLIC_APLICACION_VUELO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_SOLIC_APLICACION_VUELO", aliasTabla))))
        e.ID_SOLICITUD = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_SOLICITUD", aliasTabla))))
        e.ID_PROVEE = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PROVEE", aliasTabla)), -1))
        e.MEDIO_APLICA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}MEDIO_APLICA", aliasTabla))))
        e.DESCRIP_AERONAVE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DESCRIP_AERONAVE", aliasTabla))))
        e.NOMBRE_PILOTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_PILOTO", aliasTabla))))
        e.PRECIO_UNIT_VUELO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PRECIO_UNIT_VUELO", aliasTabla))))
        e.MZ_HORAS_VUELO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MZ_HORAS_VUELO", aliasTabla))))
        e.CARGO_VUELO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}CARGO_VUELO", aliasTabla))))
        e.PRECIO_TOTAL_VUELO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PRECIO_TOTAL_VUELO", aliasTabla))))
        e.PRECIO_UNIT_AGUA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PRECIO_UNIT_AGUA", aliasTabla)), -1))
        e.MZ_REGAR_AGUA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MZ_REGAR_AGUA", aliasTabla)), -1))
        e.PRECIO_TOTAL_AGUA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PRECIO_TOTAL_AGUA", aliasTabla)), -1))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.ZAFRA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ZAFRA", aliasTabla))))
        e.UID_SOLIC_AGRI_VUELO = ObtenerValor(dr.Item(String.Format("{0}UID_SOLIC_AGRI_VUELO", aliasTabla)))
        e.UID_REFERENCIA = ObtenerValor(dr.Item(String.Format("{0}UID_REFERENCIA", aliasTabla)))
    End Sub

    Public Sub AsignarSOLIC_APLICACION_PRODUCTO(ByVal dr As IDataReader, ByRef e As SOLIC_APLICACION_PRODUCTO, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New SOLIC_APLICACION_PRODUCTO
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_SOLIC_APLICACION_PROD = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_SOLIC_APLICACION_PROD", aliasTabla))))
        e.ID_SOLICITUD = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_SOLICITUD", aliasTabla))))
        e.ID_PRODUCTO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PRODUCTO", aliasTabla))))
        e.CANT_X_MZ = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}CANT_X_MZ", aliasTabla))))
        e.TOTAL_PRODUCTO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TOTAL_PRODUCTO", aliasTabla))))
        e.PRECIO_UNITARIO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PRECIO_UNITARIO", aliasTabla))))
        e.PRECIO_TOTAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PRECIO_TOTAL", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.ZAFRA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ZAFRA", aliasTabla))))
        e.UID_SOLIC_AGRI_PROD = ObtenerValor(dr.Item(String.Format("{0}UID_SOLIC_AGRI_PROD", aliasTabla)))
        e.UID_REFERENCIA = ObtenerValor(dr.Item(String.Format("{0}UID_REFERENCIA", aliasTabla)))
    End Sub


    Public Sub AsignarSOLIC_APLICACION_LOTE(ByVal dr As IDataReader, ByRef e As SOLIC_APLICACION_LOTE, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New SOLIC_APLICACION_LOTE
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_SOLIC_APLICACION_LOTE = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_SOLIC_APLICACION_LOTE", aliasTabla))))
        e.ID_SOLICITUD = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_SOLICITUD", aliasTabla))))
        e.ID_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA", aliasTabla))))
        e.ACCESLOTE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ACCESLOTE", aliasTabla))))
        e.MZ = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MZ", aliasTabla))))
        e.TONEL_ESTI = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TONEL_ESTI", aliasTabla))))
        e.RIEGO_APLICADO = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}RIEGO_APLICADO", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.ZAFRA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ZAFRA", aliasTabla))))
        e.UID_REFERENCIA = ObtenerValor(dr.Item(String.Format("{0}UID_REFERENCIA", aliasTabla)))
    End Sub


    Public Sub AsignarSOLIC_QUEMANOPROG(ByVal dr As IDataReader, ByRef e As SOLIC_QUEMANOPROG, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New SOLIC_QUEMANOPROG
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_SOLIC_QUEMANOPROG = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_SOLIC_QUEMANOPROG", aliasTabla))))
        e.ID_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA", aliasTabla))))
        e.ACCESLOTE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ACCESLOTE", aliasTabla))))
        e.FECHA_SOLIC = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_SOLIC", aliasTabla))))
        e.NO_SOLICITUD = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}NO_SOLICITUD", aliasTabla))))
        e.CODIPROVEEDOR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIPROVEEDOR", aliasTabla))))
        e.ZONA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ZONA", aliasTabla))))
        e.FECHA_HORA_QUEMA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_HORA_QUEMA", aliasTabla))))
        e.AREA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}AREA", aliasTabla))))
        e.TONEL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TONEL", aliasTabla))))
        e.TIPO_QUEMA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TIPO_QUEMA", aliasTabla))))
        e.CODIVARIEDA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIVARIEDA", aliasTabla))))
        e.BRECHAS = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}BRECHAS", aliasTabla))))
        e.RONDAS = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}RONDAS", aliasTabla))))
        e.VIGILANCIA = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}VIGILANCIA", aliasTabla))))
        e.MADURANTE = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}MADURANTE", aliasTabla))))
        e.FECHA_APLICA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_APLICA", aliasTabla))))
        e.PRE_MUESTRA = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}PRE_MUESTRA", aliasTabla))))
        e.FECHA_ROZA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ROZA", aliasTabla))))
        e.FECHA_INI_VENTANA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_INI_VENTANA", aliasTabla))))
        e.FECHA_FIN_VENTANA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_FIN_VENTANA", aliasTabla))))
        e.OBSERVACIONES = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}OBSERVACIONES", aliasTabla))))
        e.CODIAGRON = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIAGRON", aliasTabla))))
        e.CON_DENUNCIA = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}CON_DENUNCIA", aliasTabla))))
        e.ZAFRA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ZAFRA", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub

    Public Sub AsignarRANGO_COMPENSACION(ByVal dr As IDataReader, ByRef e As RANGO_COMPENSACION, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New RANGO_COMPENSACION
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_RANGO_COMPE = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_RANGO_COMPE", aliasTabla))))
        e.ID_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA", aliasTabla))))
        e.ID_CATORCENA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CATORCENA", aliasTabla))))
        e.REND_INICIAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}REND_INICIAL", aliasTabla))))
        e.REND_FINAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}REND_FINAL", aliasTabla))))
        e.VALOR_UNIT_PAGO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}VALOR_UNIT_PAGO", aliasTabla))))
        e.DESCRIPCION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DESCRIPCION", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub

    Public Sub AsignarFILTRO_ORDEN_ROZA(ByVal dr As IDataReader, ByRef e As FILTRO_ORDEN_ROZA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New FILTRO_ORDEN_ROZA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_FILTRO_ORDEN_ROZA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_FILTRO_ORDEN_ROZA", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.ID_PLAN_COSECHA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PLAN_COSECHA", aliasTabla))))
    End Sub

    Public Sub AsignarLOTES_TRASPASO(ByVal dr As IDataReader, ByRef e As LOTES_TRASPASO, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New LOTES_TRASPASO
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_LOTE_TRASPASO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_LOTE_TRASPASO", aliasTabla))))
        e.ACCESLOTE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ACCESLOTE", aliasTabla))))
        e.ANIOZAFRA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ANIOZAFRA", aliasTabla))))
        e.CODIPROVEEDOR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIPROVEEDOR", aliasTabla))))
        e.CODILOTE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODILOTE", aliasTabla))))
        e.CODIVARIEDA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIVARIEDA", aliasTabla))))
        e.CODICONTRATO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODICONTRATO", aliasTabla))))
        e.NOMBLOTE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBLOTE", aliasTabla))))
        e.AREA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}AREA", aliasTabla)), -1))
        e.TONELADAS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TONELADAS", aliasTabla)), -1))
        e.TONEL_TC = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TONEL_TC", aliasTabla)), -1))
        e.ZONA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ZONA", aliasTabla))))
        e.EDAD_LOTE = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}EDAD_LOTE", aliasTabla)), -1))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.ID_MAESTRO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_MAESTRO", aliasTabla)), -1))
        e.TIPO_DERECHO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}TIPO_DERECHO", aliasTabla)), -1))
        e.SUB_ZONA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}SUB_ZONA", aliasTabla))))
        e.ID_ZAFRA_TRASPASO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA_TRASPASO", aliasTabla)), -1))
    End Sub

    Public Sub AsignarPROFORMA(ByVal dr As IDataReader, ByRef e As PROFORMA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New PROFORMA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_PROFORMA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PROFORMA", aliasTabla))))
        e.ID_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA", aliasTabla))))
        e.DIAZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}DIAZAFRA", aliasTabla))))
        e.NOPROFORMA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}NOPROFORMA", aliasTabla))))
        e.CODICONTRATO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODICONTRATO", aliasTabla))))
        e.CODIPROVEEDOR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIPROVEEDOR", aliasTabla))))
        e.ACCESLOTE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ACCESLOTE", aliasTabla))))
        e.CODTRANSPORT = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}CODTRANSPORT", aliasTabla))))
        e.NOMBRES_MOTORISTA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRES_MOTORISTA", aliasTabla))))
        e.ID_TIPO_CANA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_CANA", aliasTabla))))
        e.ID_CARGADORA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CARGADORA", aliasTabla)), -1))
        e.ID_SUPERVISOR = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_SUPERVISOR", aliasTabla)), -1))
        e.FECHA_QUEMA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_QUEMA", aliasTabla))))
        e.FECHA_CORTA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CORTA", aliasTabla))))
        e.QUEMAPROG = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}QUEMAPROG", aliasTabla))))
        e.QUEMANOPROG = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}QUEMANOPROG", aliasTabla))))
        e.CANA_VERDE = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}CANA_VERDE", aliasTabla))))
        e.FECHA_ROZA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ROZA", aliasTabla))))
        e.FECHA_PATIO = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_PATIO", aliasTabla))))
        e.ID_PRODUCTO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PRODUCTO", aliasTabla)), -1))
        e.FIN_LOTE = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}FIN_LOTE", aliasTabla))))
        e.PLACAVEHIC = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}PLACAVEHIC", aliasTabla))))
        e.ID_TIPOTRANS = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPOTRANS", aliasTabla))))
        e.SERVICIO_ROZA = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}SERVICIO_ROZA", aliasTabla))))
        e.TRANSPORTE_PROPIO = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}TRANSPORTE_PROPIO", aliasTabla))))
        e.ID_PROVEEDOR_ROZA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PROVEEDOR_ROZA", aliasTabla)), -1))
        e.ID_CARGADOR = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CARGADOR", aliasTabla)), -1))
        e.TIPO_TARIFA_CARGADORA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}TIPO_TARIFA_CARGADORA", aliasTabla)), -1))
        e.ID_MOTORISTA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_MOTORISTA", aliasTabla)), -1))
        e.OBSERVACIONES = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}OBSERVACIONES", aliasTabla))))
        e.ID_ENVIO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ENVIO", aliasTabla)), -1))
        e.ESTADO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ESTADO", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.TONELADAS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TONELADAS", aliasTabla))))
        e.ID_TIPO_ROZA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_ROZA", aliasTabla)), -1))
        e.ID_TIPO_ALZA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_ALZA", aliasTabla)), -1))
        e.FECHA_MADURANTE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_MADURANTE", aliasTabla))))
        e.OBSERVA_ANUL = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}OBSERVA_ANUL", aliasTabla))))
        e.USUARIO_ANUL = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ANUL", aliasTabla))))
        e.FECHA_ANUL = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ANUL", aliasTabla))))
        e.ES_QUERQUEO = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}ES_QUERQUEO", aliasTabla))))
        e.ES_BARRIDA = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}ES_BARRIDA", aliasTabla))))
        e.ID_PROVEE_QQ = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PROVEE_QQ", aliasTabla)), -1))
        e.ID_SUBLOTES = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_SUBLOTES", aliasTabla)), -1))
    End Sub

    Public Sub AsignarCONTROL_ENTREGA_LOTE(ByVal dr As IDataReader, ByRef e As CONTROL_ENTREGA_LOTE, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New CONTROL_ENTREGA_LOTE
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_CTRL_ENTREGA_LOTE = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CTRL_ENTREGA_LOTE", aliasTabla))))
        e.ID_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA", aliasTabla))))
        e.ACCESLOTE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ACCESLOTE", aliasTabla))))
        e.DIAZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}DIAZAFRA", aliasTabla))))
        e.CONCEPTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CONCEPTO", aliasTabla))))
        e.CODIGO_REF = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_REF", aliasTabla))))
        e.ID_REF = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_REF", aliasTabla)), -1))
        e.INICIAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}INICIAL", aliasTabla))))
        e.SALIDAS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}SALIDAS", aliasTabla))))
        e.SALDO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}SALDO", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub

    Public Sub AsignarCONTROL_ROZA(ByVal dr As IDataReader, ByRef e As CONTROL_ROZA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New CONTROL_ROZA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_CONTROL_ROZA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CONTROL_ROZA", aliasTabla))))
        e.ID_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA", aliasTabla))))
        e.ACCESLOTE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ACCESLOTE", aliasTabla))))
        e.DIAZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}DIAZAFRA", aliasTabla))))
        e.CONCEPTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CONCEPTO", aliasTabla))))
        e.CODIGO_REF = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_REF", aliasTabla))))
        e.ID_REF = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_REF", aliasTabla)), -1))
        e.ENTRADAS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ENTRADAS", aliasTabla))))
        e.SALIDAS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}SALIDAS", aliasTabla))))
        e.SALDO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}SALDO", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.FECHA_HORA_ROZA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_HORA_ROZA", aliasTabla))))
        e.ID_PROVEEDOR_ROZA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PROVEEDOR_ROZA", aliasTabla)), -1))
        e.ID_TIPO_CANA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_CANA", aliasTabla)), -1))
        e.ID_TIPO_ROZA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_ROZA", aliasTabla)), -1))
        e.QUEMA_PROGRAMADA = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}QUEMA_PROGRAMADA", aliasTabla))))
        e.QUEMA_NOPROG = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}QUEMA_NOPROG", aliasTabla))))
        e.CANA_VERDE = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}CANA_VERDE", aliasTabla))))
        e.FECHA_HORA_QUEMA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_HORA_QUEMA", aliasTabla))))
        e.ID_ROZA_SALDO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ROZA_SALDO", aliasTabla)), -1))
        e.ES_PROYECCION = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}ES_PROYECCION", aliasTabla))))
        e.ES_QUERQUEO = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}ES_QUERQUEO", aliasTabla))))
        e.ID_PROVEE_QQ = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PROVEE_QQ", aliasTabla)), -1))
        e.ID_SUBLOTES = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_SUBLOTES", aliasTabla)), -1))
    End Sub

    Public Sub AsignarCONTROL_QUEMA(ByVal dr As IDataReader, ByRef e As CONTROL_QUEMA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New CONTROL_QUEMA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_CONTROL_QUEMA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CONTROL_QUEMA", aliasTabla))))
        e.ID_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA", aliasTabla))))
        e.ACCESLOTE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ACCESLOTE", aliasTabla))))
        e.CONCEPTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CONCEPTO", aliasTabla))))
        e.CODIGO_REF = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_REF", aliasTabla))))
        e.ID_REF = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_REF", aliasTabla)), -1))
        e.ENTRADAS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ENTRADAS", aliasTabla))))
        e.SALIDAS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}SALIDAS", aliasTabla))))
        e.SALDO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}SALDO", aliasTabla))))
        e.QUEMA_PROGRAMADA = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}QUEMA_PROGRAMADA", aliasTabla))))
        e.QUEMA_NOPROG = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}QUEMA_NOPROG", aliasTabla))))
        e.CANA_VERDE = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}CANA_VERDE", aliasTabla))))
        e.FECHA_HORA_QUEMA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_HORA_QUEMA", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.ID_CONTROL_QUEMA_REF = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CONTROL_QUEMA_REF", aliasTabla)), -1))
        e.ES_PROYECCION = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}ES_PROYECCION", aliasTabla))))
        e.ID_QUEMA_SALDO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_QUEMA_SALDO", aliasTabla)), -1))
        e.ID_SUBLOTES = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_SUBLOTES", aliasTabla)), -1))
    End Sub

    Public Sub AsignarCONTROL_ROZA_SALDO(ByVal dr As IDataReader, ByRef e As CONTROL_ROZA_SALDO, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New CONTROL_ROZA_SALDO
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_ROZA_SALDO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ROZA_SALDO", aliasTabla))))
        e.ID_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA", aliasTabla))))
        e.ACCESLOTE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ACCESLOTE", aliasTabla))))
        e.ID_PROVEEDOR_ROZA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PROVEEDOR_ROZA", aliasTabla)), -1))
        e.ID_TIPO_CANA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_CANA", aliasTabla))))
        e.ID_TIPO_ROZA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_ROZA", aliasTabla))))
        e.FECHA_HORA_ROZA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_HORA_ROZA", aliasTabla))))
        e.FECHA_HORA_QUEMA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_HORA_QUEMA", aliasTabla))))
        e.QUEMA_PROGRAMADA = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}QUEMA_PROGRAMADA", aliasTabla))))
        e.QUEMA_NOPROG = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}QUEMA_NOPROG", aliasTabla))))
        e.CANA_VERDE = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}CANA_VERDE", aliasTabla))))
        e.ENTRADAS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ENTRADAS", aliasTabla))))
        e.SALIDAS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}SALIDAS", aliasTabla))))
        e.SALDO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}SALDO", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.ES_PROYECCION = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}ES_PROYECCION", aliasTabla))))
        e.FECHA_HORA_QUEMA_PROY = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_HORA_QUEMA_PROY", aliasTabla))))
        e.FECHA_HORA_ROZA_PROY = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_HORA_ROZA_PROY", aliasTabla))))
        e.FECHA_HORA_QUEMA_REAL = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_HORA_QUEMA_REAL", aliasTabla))))
        e.FECHA_HORA_ROZA_REAL = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_HORA_ROZA_REAL", aliasTabla))))
        e.TC_PROY = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TC_PROY", aliasTabla)), -1))
        e.TC_REAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TC_REAL", aliasTabla)), -1))
        e.ES_QUERQUEO = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}ES_QUERQUEO", aliasTabla))))
        e.ID_PROVEE_QQ = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PROVEE_QQ", aliasTabla)), -1))
        e.ID_SUBLOTES = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_SUBLOTES", aliasTabla)), -1))
    End Sub

    Public Sub AsignarPLAN_COSECHA(ByVal dr As IDataReader, ByRef e As PLAN_COSECHA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New PLAN_COSECHA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_PLAN_COSECHA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PLAN_COSECHA", aliasTabla))))
        e.ID_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA", aliasTabla))))
        e.ACCESLOTE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ACCESLOTE", aliasTabla))))
        e.MZ_SALDO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MZ_SALDO", aliasTabla))))
        e.TONEL_SALDO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TONEL_SALDO", aliasTabla))))
        e.MZ_COSECHA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MZ_COSECHA", aliasTabla))))
        e.TONEL_MZ_COSECHA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TONEL_MZ_COSECHA", aliasTabla))))
        e.TONEL_COSECHA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TONEL_COSECHA", aliasTabla))))
        e.CUOTA_DIARIA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}CUOTA_DIARIA", aliasTabla))))
        e.FECHA_INI_COSECHA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_INI_COSECHA", aliasTabla))))
        e.FECHA_FIN_COSECHA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_FIN_COSECHA", aliasTabla))))
        e.TOTAL_SEMANA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TOTAL_SEMANA", aliasTabla))))
        e.QUEMA_PROGRAMADA = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}QUEMA_PROGRAMADA", aliasTabla))))
        e.QUEMA_NO_PROGRAMADA = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}QUEMA_NO_PROGRAMADA", aliasTabla))))
        e.ID_TIPO_CANA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_CANA", aliasTabla)), -1))
        e.ID_TIPO_ROZA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_ROZA", aliasTabla)), -1))
        e.ID_TIPO_ALZA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_ALZA", aliasTabla)), -1))
        e.ID_CARGADORA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CARGADORA", aliasTabla)), -1))
        e.ID_CARGADOR = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CARGADOR", aliasTabla)), -1))
        e.ID_TIPOTRANS = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPOTRANS", aliasTabla)), -1))
        e.TRANSPORTE_PROPIO = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}TRANSPORTE_PROPIO", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.CANA_VERDE = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}CANA_VERDE", aliasTabla))))
        e.FECHA_ESTIM_QUEMA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ESTIM_QUEMA", aliasTabla))))
        e.FECHA_REAL_QUEMA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_REAL_QUEMA", aliasTabla))))
        e.FECHA_QUEMA_NOPROG = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_QUEMA_NOPROG", aliasTabla))))
        e.CATORCENA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}CATORCENA", aliasTabla)), -1))
        e.SEMANA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}SEMANA", aliasTabla)), -1))
    End Sub

    Public Sub AsignarCUENTA_FINAN(ByVal dr As IDataReader, ByRef e As CUENTA_FINAN, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New CUENTA_FINAN
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_CUENTA_FINAN = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CUENTA_FINAN", aliasTabla))))
        e.CODIGO_CUENTA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_CUENTA", aliasTabla))))
        e.NOMBRE_CUENTA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_CUENTA", aliasTabla))))
        e.DESCRIP_CUENTA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DESCRIP_CUENTA", aliasTabla))))
        e.TIPO_FTO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}TIPO_FTO", aliasTabla))))
        e.APLICA_SOLIC_AGRICOLA = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}APLICA_SOLIC_AGRICOLA", aliasTabla))))
        e.APLICA_ANALIS_FTO = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}APLICA_ANALIS_FTO", aliasTabla))))
        e.APLICA_FACTURACION = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}APLICA_FACTURACION", aliasTabla))))
        e.APLICA_INTERES = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}APLICA_INTERES", aliasTabla))))
        e.APLICA_EMISION_CHEQ = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}APLICA_EMISION_CHEQ", aliasTabla))))
        e.APLICA_DESCTO_PLA = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}APLICA_DESCTO_PLA", aliasTabla))))
        e.PORC_SUBSIDIO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PORC_SUBSIDIO", aliasTabla))))
        e.ZAFRA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ZAFRA", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub

    Public Sub AsignarSOLIC_APLICA_VUELO(ByVal dr As IDataReader, ByRef e As SOLIC_APLICA_VUELO, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New SOLIC_APLICA_VUELO
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_SOLIC_APLICA_VUELO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_SOLIC_APLICA_VUELO", aliasTabla))))
        e.ID_SOLICITUD = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_SOLICITUD", aliasTabla))))
        e.ID_PROVEE = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PROVEE", aliasTabla))))
        e.MEDIO_APLICA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}MEDIO_APLICA", aliasTabla))))
        e.DESCRIP_AERONAVE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DESCRIP_AERONAVE", aliasTabla))))
        e.NOMBRE_PILOTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_PILOTO", aliasTabla))))
        e.PRECIO_UNIT_VUELO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PRECIO_UNIT_VUELO", aliasTabla))))
        e.MZ_HORAS_VUELO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MZ_HORAS_VUELO", aliasTabla))))
        e.CARGO_VUELO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}CARGO_VUELO", aliasTabla))))
        e.PRECIO_TOTAL_VUELO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PRECIO_TOTAL_VUELO", aliasTabla))))
        e.PRECIO_UNIT_AGUA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PRECIO_UNIT_AGUA", aliasTabla)), -1))
        e.MZ_REGAR_AGUA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MZ_REGAR_AGUA", aliasTabla)), -1))
        e.PRECIO_TOTAL_AGUA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PRECIO_TOTAL_AGUA", aliasTabla)), -1))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.ZAFRA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ZAFRA", aliasTabla))))
    End Sub

    Public Sub AsignarSOLIC_APLICA_LOTE(ByVal dr As IDataReader, ByRef e As SOLIC_APLICA_LOTE, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New SOLIC_APLICA_LOTE
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_SOLIC_APLICA_LOTE = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_SOLIC_APLICA_LOTE", aliasTabla))))
        e.ID_LOTES_COSECHA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_LOTES_COSECHA", aliasTabla))))
        e.ID_SOLICITUD = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_SOLICITUD", aliasTabla))))
        e.ID_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA", aliasTabla))))
        e.ACCESLOTE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ACCESLOTE", aliasTabla))))
        e.MZ = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MZ", aliasTabla))))
        e.FECHA_APLICA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_APLICA", aliasTabla))))
        e.ID_PRODUCTO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PRODUCTO", aliasTabla))))
        e.CANT_X_MZ = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}CANT_X_MZ", aliasTabla))))
        e.TOTAL_PRODUCTO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TOTAL_PRODUCTO", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.ZAFRA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ZAFRA", aliasTabla))))
        e.ID_MAESTRO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_MAESTRO", aliasTabla))))
        e.NOMBRE_PRODUCTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_PRODUCTO", aliasTabla))))
        e.FECHA_INI_VENTANA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_INI_VENTANA", aliasTabla))))
        e.FECHA_FIN_VENTANA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_FIN_VENTANA", aliasTabla))))
        e.FECHA_ROZA_MADURANTE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ROZA_MADURANTE", aliasTabla))))
        e.TONELADAS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TONELADAS", aliasTabla)), -1))
        e.UID_REFERENCIA = ObtenerValor(dr.Item(String.Format("{0}UID_REFERENCIA", aliasTabla)))
    End Sub


    Public Sub AsignarCONTRATO_FINAN(ByVal dr As IDataReader, ByRef e As CONTRATO_FINAN, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New CONTRATO_FINAN
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_CONTRATO_FINAN = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CONTRATO_FINAN", aliasTabla))))
        e.ID_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA", aliasTabla))))
        e.CODICONTRATO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODICONTRATO", aliasTabla))))
        e.MZ = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MZ", aliasTabla))))
        e.TONEL_MZ = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TONEL_MZ", aliasTabla))))
        e.TONEL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TONEL", aliasTabla))))
        e.REND_COSECHA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}REND_COSECHA", aliasTabla))))
        e.LIBRAS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}LIBRAS", aliasTabla))))
        e.VIP = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}VIP", aliasTabla))))
        e.VALOR_CONTRA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}VALOR_CONTRA", aliasTabla))))
        e.PROVI_ROZA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PROVI_ROZA", aliasTabla))))
        e.PROVI_ALZA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PROVI_ALZA", aliasTabla))))
        e.PROVI_TRANS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PROVI_TRANS", aliasTabla))))
        e.PROVISION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PROVISION", aliasTabla))))
        e.CARGO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}CARGO", aliasTabla))))
        e.ABONO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ABONO", aliasTabla))))
        e.DISPONIBLE = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}DISPONIBLE", aliasTabla))))
        e.ZAFRA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ZAFRA", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub


    Public Sub AsignarCONTRATO_CTAS_PROVI(ByVal dr As IDataReader, ByRef e As CONTRATO_CTAS_PROVI, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New CONTRATO_CTAS_PROVI
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_CONTRATO_CTAS_PROVI = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CONTRATO_CTAS_PROVI", aliasTabla))))
        e.ID_CONTRATO_FINAN = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CONTRATO_FINAN", aliasTabla))))
        e.CODICONTRATO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODICONTRATO", aliasTabla))))
        e.ID_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA", aliasTabla))))
        e.FECHA_APLICA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_APLICA", aliasTabla))))
        e.CONCEPTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CONCEPTO", aliasTabla))))
        e.PROVISION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PROVISION", aliasTabla))))
        e.ID_CUENTA_FINAN = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CUENTA_FINAN", aliasTabla))))
        e.UID_SOLICITUD = ObtenerValor(dr.Item(String.Format("{0}UID_SOLICITUD", aliasTabla)))
        e.ZAFRA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ZAFRA", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub

    Public Sub AsignarCONTRATO_CTAS_MOVTOS(ByVal dr As IDataReader, ByRef e As CONTRATO_CTAS_MOVTOS, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New CONTRATO_CTAS_MOVTOS
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_CONTRATO_CTAS_MOVTOS = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CONTRATO_CTAS_MOVTOS", aliasTabla))))
        e.ID_CONTRATO_CTAS = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CONTRATO_CTAS", aliasTabla))))
        e.CODICONTRATO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODICONTRATO", aliasTabla))))
        e.ID_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA", aliasTabla))))
        e.FECHA_APLICA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_APLICA", aliasTabla))))
        e.CONCEPTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CONCEPTO", aliasTabla))))
        e.CARGO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}CARGO", aliasTabla))))
        e.ABONO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ABONO", aliasTabla))))
        e.UID_REFERENCIA = ObtenerValor(dr.Item(String.Format("{0}UID_REFERENCIA", aliasTabla)), "")
        e.ZAFRA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ZAFRA", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub

    Public Sub AsignarCONTRATO_CTAS(ByVal dr As IDataReader, ByRef e As CONTRATO_CTAS, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New CONTRATO_CTAS
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_CONTRATO_CTAS = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CONTRATO_CTAS", aliasTabla))))
        e.ID_CONTRATO_FINAN = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CONTRATO_FINAN", aliasTabla))))
        e.CODICONTRATO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODICONTRATO", aliasTabla))))
        e.ID_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA", aliasTabla))))
        e.ID_CUENTA_FINAN = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CUENTA_FINAN", aliasTabla)), -1))
        e.NO_DOCTO_REFERENCIA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NO_DOCTO_REFERENCIA", aliasTabla))))
        e.UID_REFERENCIA = ObtenerValor(dr.Item(String.Format("{0}UID_REFERENCIA", aliasTabla)), "")
        e.CARGO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}CARGO", aliasTabla))))
        e.ABONO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ABONO", aliasTabla))))
        e.SALDO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}SALDO", aliasTabla))))
        e.ZAFRA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ZAFRA", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub




    Public Sub AsignarANTICIPO_CANA(ByVal dr As IDataReader, ByRef e As ANTICIPO_CANA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New ANTICIPO_CANA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_ANTICIPO_CANA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ANTICIPO_CANA", aliasTabla))))
        e.ID_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA", aliasTabla))))
        e.ID_CATORCENA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CATORCENA", aliasTabla))))
        e.NO_ANTICIPO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}NO_ANTICIPO", aliasTabla))))
        e.NO_ANTICIPO_LETRAS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NO_ANTICIPO_LETRAS", aliasTabla))))
        e.VALOR_ANTICIPO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}VALOR_ANTICIPO", aliasTabla))))
        e.FECHA_INICIO = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_INICIO", aliasTabla))))
        e.FECHA_FINAL = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_FINAL", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.FECHA_PAGO = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_PAGO", aliasTabla))))
        e.ES_COMP_VFP = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}ES_COMP_VFP", aliasTabla))))
    End Sub

    Public Sub AsignarSOLIC_AGRICOLA_VUELO(ByVal dr As IDataReader, ByRef e As SOLIC_AGRICOLA_VUELO, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New SOLIC_AGRICOLA_VUELO
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_SOLIC_AGRI_VUELO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_SOLIC_AGRI_VUELO", aliasTabla))))
        e.ID_SOLICITUD = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_SOLICITUD", aliasTabla))))
        e.ID_PROVEE = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PROVEE", aliasTabla)), -1))
        e.MEDIO_APLICA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}MEDIO_APLICA", aliasTabla))))
        e.DESCRIP_AERONAVE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DESCRIP_AERONAVE", aliasTabla))))
        e.NOMBRE_PILOTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_PILOTO", aliasTabla))))
        e.PRECIO_UNIT_VUELO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PRECIO_UNIT_VUELO", aliasTabla))))
        e.MZ_HORAS_VUELO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MZ_HORAS_VUELO", aliasTabla))))
        e.CARGO_VUELO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}CARGO_VUELO", aliasTabla))))
        e.PRECIO_TOTAL_VUELO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PRECIO_TOTAL_VUELO", aliasTabla))))
        e.PRECIO_UNIT_AGUA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PRECIO_UNIT_AGUA", aliasTabla)), -1))
        e.MZ_REGAR_AGUA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MZ_REGAR_AGUA", aliasTabla)), -1))
        e.PRECIO_TOTAL_AGUA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PRECIO_TOTAL_AGUA", aliasTabla)), -1))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.ZAFRA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ZAFRA", aliasTabla))))
        e.UID_SOLIC_AGRI_VUELO = ObtenerValor(dr.Item(String.Format("{0}UID_SOLIC_AGRI_VUELO", aliasTabla)), "")
    End Sub

    Public Sub AsignarCATEGORIA_PROD(ByVal dr As IDataReader, ByRef e As CATEGORIA_PROD, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New CATEGORIA_PROD
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_CATEGORIA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CATEGORIA", aliasTabla))))
        e.NOMBRE_CATEGORIA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_CATEGORIA", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.ZAFRA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ZAFRA", aliasTabla))))
    End Sub

    Public Sub AsignarSOLIC_AGRICOLA_PRODUCTO(ByVal dr As IDataReader, ByRef e As SOLIC_AGRICOLA_PRODUCTO, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New SOLIC_AGRICOLA_PRODUCTO
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_SOLIC_AGRI_PROD = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_SOLIC_AGRI_PROD", aliasTabla))))
        e.ID_SOLICITUD = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_SOLICITUD", aliasTabla))))
        e.ID_PRODUCTO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PRODUCTO", aliasTabla)), -1))
        e.CANT_X_MZ = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}CANT_X_MZ", aliasTabla))))
        e.TOTAL_PRODUCTO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TOTAL_PRODUCTO", aliasTabla))))
        e.PRECIO_UNITARIO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PRECIO_UNITARIO", aliasTabla))))
        e.PRECIO_TOTAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PRECIO_TOTAL", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.ZAFRA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ZAFRA", aliasTabla))))
        e.UID_SOLIC_AGRI_PROD = ObtenerValor(dr.Item(String.Format("{0}UID_SOLIC_AGRI_PROD", aliasTabla)))
        e.NOMBRE_PRODUCTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_PRODUCTO", aliasTabla))))
        e.PRESENTACION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}PRESENTACION", aliasTabla))))
        e.ID_PROVEE = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PROVEE", aliasTabla)), -1))
        e.UNIDAD = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}UNIDAD", aliasTabla))))
        e.ID_PROVEE_ADJU = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PROVEE_ADJU", aliasTabla)), -1))
        e.CANT_ADJU = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}CANT_ADJU", aliasTabla)), -1))
        e.PRECIO_ADJU = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PRECIO_ADJU", aliasTabla)), -1))
        e.TOTAL_ADJU = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TOTAL_ADJU", aliasTabla)), -1))
    End Sub

    Public Sub AsignarSOLIC_AGRICOLA_LOTE(ByVal dr As IDataReader, ByRef e As SOLIC_AGRICOLA_LOTE, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New SOLIC_AGRICOLA_LOTE
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_SOLIC_AGRI_LOTE = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_SOLIC_AGRI_LOTE", aliasTabla))))
        e.ID_SOLICITUD = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_SOLICITUD", aliasTabla))))
        e.ID_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA", aliasTabla))))
        e.ACCESLOTE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ACCESLOTE", aliasTabla))))
        e.MZ = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MZ", aliasTabla))))
        e.TONEL_ESTI = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TONEL_ESTI", aliasTabla))))
        e.RIEGO_APLICADO = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}RIEGO_APLICADO", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.ZAFRA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ZAFRA", aliasTabla))))
        e.CODIVARIEDA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIVARIEDA", aliasTabla))))
    End Sub

    Public Sub AsignarSOLIC_AGRICOLA(ByVal dr As IDataReader, ByRef e As SOLIC_AGRICOLA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New SOLIC_AGRICOLA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_SOLICITUD = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_SOLICITUD", aliasTabla))))
        e.ID_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA", aliasTabla))))
        e.NUM_SOLICITUD = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}NUM_SOLICITUD", aliasTabla))))
        e.CODIPROVEEDOR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIPROVEEDOR", aliasTabla))))
        e.NOMBRE_PROVEEDOR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_PROVEEDOR", aliasTabla))))
        e.ACTIVIDAD = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ACTIVIDAD", aliasTabla))))
        e.FECHA_SOLIC = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_SOLIC", aliasTabla))))
        e.FECHA_APLICA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_APLICA", aliasTabla))))
        e.DUI = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DUI", aliasTabla))))
        e.NIT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NIT", aliasTabla))))
        e.NRC = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NRC", aliasTabla))))
        e.TIPO_CONTRIBUYENTE = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}TIPO_CONTRIBUYENTE", aliasTabla)), -1))
        e.SUB_TOTAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}SUB_TOTAL", aliasTabla))))
        e.IVA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}IVA", aliasTabla))))
        e.TOTAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TOTAL", aliasTabla))))
        e.ESTADO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ESTADO", aliasTabla)), -1))
        e.OBSERVACIONES = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}OBSERVACIONES", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.ZAFRA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ZAFRA", aliasTabla))))
        e.CODIAGRON = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIAGRON", aliasTabla))))
        e.CODICONTRATO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODICONTRATO", aliasTabla))))
        e.UID_SOLIC_AGRICOLA = ObtenerValor(dr.Item(String.Format("{0}UID_SOLIC_AGRICOLA", aliasTabla)))
        e.ID_CATEGORIA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CATEGORIA", aliasTabla)), -1))
        e.ID_CUENTA_FINAN = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CUENTA_FINAN", aliasTabla)), -1))
        e.CONDI_COMPRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}CONDI_COMPRA", aliasTabla)), -1))
        e.CONTRATOS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CONTRATOS", aliasTabla))))
        e.FOVIAL_COTRANS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}FOVIAL_COTRANS", aliasTabla))))
    End Sub


    Public Sub AsignarTARIFA_VUELO(ByVal dr As IDataReader, ByRef e As TARIFA_VUELO, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New TARIFA_VUELO
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_TARIFA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TARIFA", aliasTabla))))
        e.ID_PROVEE = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PROVEE", aliasTabla))))
        e.MEDIO_APLICA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}MEDIO_APLICA", aliasTabla))))
        e.PRECIO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PRECIO", aliasTabla))))
        e.OTRO_CARGO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}OTRO_CARGO", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.ZAFRA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ZAFRA", aliasTabla))))
    End Sub

    Public Sub AsignarPROVEEDOR_AGRICOLA(ByVal dr As IDataReader, ByRef e As PROVEEDOR_AGRICOLA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New PROVEEDOR_AGRICOLA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_PROVEE = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PROVEE", aliasTabla))))
        e.NOMBRE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE", aliasTabla))))
        e.DUI = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DUI", aliasTabla))))
        e.NIT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NIT", aliasTabla))))
        e.NRC = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NRC", aliasTabla))))
        e.TIPO_CONTRIBUYENTE = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}TIPO_CONTRIBUYENTE", aliasTabla)), -1))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.ZAFRA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ZAFRA", aliasTabla))))
        e.ES_PROVEE_VUELO = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}ES_PROVEE_VUELO", aliasTabla))))
        e.ES_CASA_COMER = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}ES_CASA_COMER", aliasTabla))))
        e.NOMBRE_LEGAL = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_LEGAL", aliasTabla))))
        e.APELLIDOS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}APELLIDOS", aliasTabla))))
        e.DIRECCION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DIRECCION", aliasTabla))))
        e.CODI_DEPTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODI_DEPTO", aliasTabla))))
        e.CODI_MUNI = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODI_MUNI", aliasTabla))))
        e.CORREO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CORREO", aliasTabla))))
        e.ID_TIPO_PERSONA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_PERSONA", aliasTabla)), -1))
        e.TELEFONO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TELEFONO", aliasTabla))))
        e.ACTIVIDAD = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ACTIVIDAD", aliasTabla))))
    End Sub

    Public Sub AsignarPRODUCTO(ByVal dr As IDataReader, ByRef e As PRODUCTO, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New PRODUCTO
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_PRODUCTO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PRODUCTO", aliasTabla))))
        e.NOMBRE_PRODUCTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_PRODUCTO", aliasTabla))))
        e.ID_CATEGORIA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CATEGORIA", aliasTabla))))
        e.ID_UNIDAD = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_UNIDAD", aliasTabla))))
        e.PRECIO_UNITARIO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PRECIO_UNITARIO", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.ZAFRA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ZAFRA", aliasTabla))))
        e.VENTSEMA_INI = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}VENTSEMA_INI", aliasTabla)), -1))
        e.VENTSEMA_FIN = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}VENTSEMA_FIN", aliasTabla)), -1))
        e.NOMBRE_COMERCIAL = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_COMERCIAL", aliasTabla))))
        e.ID_CUENTA_FINAN = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CUENTA_FINAN", aliasTabla)), -1))
        e.PRESENTACION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}PRESENTACION", aliasTabla))))
        e.PORC_SUBSIDIO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PORC_SUBSIDIO", aliasTabla)), -1))
        e.ID_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA", aliasTabla)), -1))
        e.ACTIVO = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}ACTIVO", aliasTabla))))
        e.EXISTENCIA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}EXISTENCIA", aliasTabla)), -1))
        e.EN_CONSIGNA = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}EN_CONSIGNA", aliasTabla))))
        e.ID_PROVEE = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PROVEE", aliasTabla)), -1))
        e.APLICA_CESC = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}APLICA_CESC", aliasTabla))))
    End Sub



    Public Sub AsignarUNIDAD_MEDIDA(ByVal dr As IDataReader, ByRef e As UNIDAD_MEDIDA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New UNIDAD_MEDIDA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_UNIDAD = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_UNIDAD", aliasTabla))))
        e.NOMBRE_UNIDAD = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_UNIDAD", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub

    Public Sub AsignarBRIX_SACAROSA(ByVal dr As IDataReader, ByRef e As BRIX_SACAROSA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New BRIX_SACAROSA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_BRIX_SACA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_BRIX_SACA", aliasTabla))))
        e.BRIX = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}BRIX", aliasTabla))))
        e.GRAMOS_SACAROSA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}GRAMOS_SACAROSA", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub

    Public Sub AsignarPARAM_PRECOSECHA(ByVal dr As IDataReader, ByRef e As PARAM_PRECOSECHA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New PARAM_PRECOSECHA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_PARAM_PRECOSECHA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PARAM_PRECOSECHA", aliasTabla))))
        e.ID_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA", aliasTabla))))
        e.CTE_A_DEXTRA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}CTE_A_DEXTRA", aliasTabla))))
        e.CTE_B_DEXTRA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}CTE_B_DEXTRA", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_CT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CT", aliasTabla))))
    End Sub

    Public Sub AsignarLOTES_COSECHA(ByVal dr As IDataReader, ByRef e As LOTES_COSECHA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New LOTES_COSECHA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_LOTES_COSECHA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_LOTES_COSECHA", aliasTabla))))
        e.ACCESLOTE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ACCESLOTE", aliasTabla))))
        e.ID_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA", aliasTabla))))
        e.FECHA_ROZA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ROZA", aliasTabla))))
        e.REND_COSECHA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}REND_COSECHA", aliasTabla))))
        e.MZ_ENTREGAR = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MZ_ENTREGAR", aliasTabla))))
        e.TONEL_MZ_ENTREGAR = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TONEL_MZ_ENTREGAR", aliasTabla))))
        e.TONEL_ENTREGAR = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TONEL_ENTREGAR", aliasTabla))))
        e.LBS_ENTREGAR = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}LBS_ENTREGAR", aliasTabla))))
        e.VALOR_ENTREGAR = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}VALOR_ENTREGAR", aliasTabla))))
        e.MZ_ENTREGADA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MZ_ENTREGADA", aliasTabla))))
        e.TONEL_MZ_ENTREGADA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TONEL_MZ_ENTREGADA", aliasTabla))))
        e.TONEL_ENTREGADA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TONEL_ENTREGADA", aliasTabla))))
        e.LBS_ENTREGADA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}LBS_ENTREGADA", aliasTabla))))
        e.VALOR_ENTREGADA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}VALOR_ENTREGADA", aliasTabla))))
        e.MZ_CENSO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MZ_CENSO", aliasTabla))))
        e.TONEL_MZ_CENSO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TONEL_MZ_CENSO", aliasTabla))))
        e.TONEL_CENSO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TONEL_CENSO", aliasTabla))))
        e.LBS_CENSO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}LBS_CENSO", aliasTabla))))
        e.VALOR_CENSO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}VALOR_CENSO", aliasTabla))))
        e.FIN_LOTE = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}FIN_LOTE", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.CODIAGRON = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIAGRON", aliasTabla))))
        e.FECHA_SIEMBRA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_SIEMBRA", aliasTabla))))
        e.ID_TIPO_CANA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_CANA", aliasTabla)), -1))
        e.ID_TIPO_ROZA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_ROZA", aliasTabla)), -1))
        e.ID_TIPO_ALZA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_ALZA", aliasTabla)), -1))
        e.ID_TIPO_TRANS = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_TRANS", aliasTabla)), -1))
        e.FAB_SEMANA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}FAB_SEMANA", aliasTabla)), -1))
        e.FAB_CATORCENA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}FAB_CATORCENA", aliasTabla)), -1))
        e.FAB_SUBTERCIO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}FAB_SUBTERCIO", aliasTabla))))
        e.FAB_TERCIO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}FAB_TERCIO", aliasTabla)), -1))
        e.TARIFA_ROZA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TARIFA_ROZA", aliasTabla)), -1))
        e.TARIFA_ALZA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TARIFA_ALZA", aliasTabla)), -1))
        e.TARIFA_TRANS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TARIFA_TRANS", aliasTabla)), -1))
        e.TARIFA_CORTA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TARIFA_CORTA", aliasTabla)), -1))
        e.TARIFA_LARGA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TARIFA_LARGA", aliasTabla)), -1))
        e.SALDO_ROZA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}SALDO_ROZA", aliasTabla))))
        e.EDAD_LOTE = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}EDAD_LOTE", aliasTabla))))
        e.SALDO_QUEMA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}SALDO_QUEMA", aliasTabla))))
        e.FECHA_ROZA_DISPO = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ROZA_DISPO", aliasTabla))))
        e.TONEL_SALDO_VAR = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TONEL_SALDO_VAR", aliasTabla))))
        e.TONEL_SEMILLA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TONEL_SEMILLA", aliasTabla))))
        e.FECHA_CIERRE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CIERRE", aliasTabla))))
        e.HORAS_GRACIA_ENTREGA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}HORAS_GRACIA_ENTREGA", aliasTabla)), -1))
    End Sub

    Public Sub AsignarLOTES_COSECHA_IncluyeContrato(ByVal dr As IDataReader, ByRef e As LOTES_COSECHA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New LOTES_COSECHA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_LOTES_COSECHA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_LOTES_COSECHA", aliasTabla))))
        e.ACCESLOTE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ACCESLOTE", aliasTabla))))
        e.ID_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA", aliasTabla))))
        e.FECHA_ROZA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ROZA", aliasTabla))))
        e.REND_COSECHA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}REND_COSECHA", aliasTabla))))
        e.MZ_ENTREGAR = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MZ_ENTREGAR", aliasTabla))))
        e.TONEL_MZ_ENTREGAR = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TONEL_MZ_ENTREGAR", aliasTabla))))
        e.TONEL_ENTREGAR = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TONEL_ENTREGAR", aliasTabla))))
        e.LBS_ENTREGAR = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}LBS_ENTREGAR", aliasTabla))))
        e.VALOR_ENTREGAR = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}VALOR_ENTREGAR", aliasTabla))))
        e.MZ_ENTREGADA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MZ_ENTREGADA", aliasTabla))))
        e.TONEL_MZ_ENTREGADA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TONEL_MZ_ENTREGADA", aliasTabla))))
        e.TONEL_ENTREGADA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TONEL_ENTREGADA", aliasTabla))))
        e.LBS_ENTREGADA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}LBS_ENTREGADA", aliasTabla))))
        e.VALOR_ENTREGADA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}VALOR_ENTREGADA", aliasTabla))))
        e.MZ_CENSO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MZ_CENSO", aliasTabla))))
        e.TONEL_MZ_CENSO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TONEL_MZ_CENSO", aliasTabla))))
        e.TONEL_CENSO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TONEL_CENSO", aliasTabla))))
        e.LBS_CENSO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}LBS_CENSO", aliasTabla))))
        e.VALOR_CENSO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}VALOR_CENSO", aliasTabla))))
        e.FIN_LOTE = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}FIN_LOTE", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.CODIAGRON = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIAGRON", aliasTabla))))
        e.FECHA_SIEMBRA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_SIEMBRA", aliasTabla))))
        e.ID_TIPO_CANA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_CANA", aliasTabla)), -1))
        e.ID_TIPO_ROZA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_ROZA", aliasTabla)), -1))
        e.ID_TIPO_ALZA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_ALZA", aliasTabla)), -1))
        e.ID_TIPO_TRANS = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_TRANS", aliasTabla)), -1))
        e.FAB_SEMANA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}FAB_SEMANA", aliasTabla)), -1))
        e.FAB_CATORCENA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}FAB_CATORCENA", aliasTabla)), -1))
        e.FAB_SUBTERCIO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}FAB_SUBTERCIO", aliasTabla))))
        e.FAB_TERCIO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}FAB_TERCIO", aliasTabla)), -1))
        e.TARIFA_ROZA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TARIFA_ROZA", aliasTabla)), -1))
        e.TARIFA_ALZA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TARIFA_ALZA", aliasTabla)), -1))
        e.TARIFA_TRANS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TARIFA_TRANS", aliasTabla)), -1))
        e.TARIFA_CORTA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TARIFA_CORTA", aliasTabla)), -1))
        e.TARIFA_LARGA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TARIFA_LARGA", aliasTabla)), -1))
        e.SALDO_ROZA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}SALDO_ROZA", aliasTabla))))
        e.EDAD_LOTE = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}EDAD_LOTE", aliasTabla))))
        e.SALDO_QUEMA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}SALDO_QUEMA", aliasTabla))))
        e.FECHA_ROZA_DISPO = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ROZA_DISPO", aliasTabla))))
        e.TONEL_SALDO_VAR = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TONEL_SALDO_VAR", aliasTabla))))
        e.TONEL_SEMILLA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TONEL_SEMILLA", aliasTabla))))
        e.FECHA_CIERRE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CIERRE", aliasTabla))))
        e.HORAS_GRACIA_ENTREGA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}HORAS_GRACIA_ENTREGA", aliasTabla)), -1))
        e.MZ_CONTRATO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MZ_CONTRATO", aliasTabla))))
        e.TC_MZ_CONTRATO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TC_MZ_CONTRATO", aliasTabla))))
        e.TC_CONTRATO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TC_CONTRATO", aliasTabla))))
    End Sub

    Public Sub AsignarESTICANA(ByVal dr As IDataReader, ByRef e As ESTICANA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New ESTICANA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_ESTICANA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ESTICANA", aliasTabla))))
        e.ACCESLOTE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ACCESLOTE", aliasTabla))))
        e.ID_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA", aliasTabla))))
        e.FECHA_ROZA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ROZA", aliasTabla))))
        e.REND_COSECHA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}REND_COSECHA", aliasTabla))))
        e.MZ_ENTREGAR = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MZ_ENTREGAR", aliasTabla))))
        e.TONEL_MZ_ENTREGAR = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TONEL_MZ_ENTREGAR", aliasTabla))))
        e.TONEL_ENTREGAR = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TONEL_ENTREGAR", aliasTabla))))
        e.LBS_ENTREGAR = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}LBS_ENTREGAR", aliasTabla))))
        e.VALOR_ENTREGAR = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}VALOR_ENTREGAR", aliasTabla))))
        e.MZ_ENTREGADA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MZ_ENTREGADA", aliasTabla))))
        e.TONEL_MZ_ENTREGADA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TONEL_MZ_ENTREGADA", aliasTabla))))
        e.TONEL_ENTREGADA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TONEL_ENTREGADA", aliasTabla))))
        e.LBS_ENTREGADA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}LBS_ENTREGADA", aliasTabla))))
        e.VALOR_ENTREGADA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}VALOR_ENTREGADA", aliasTabla))))
        e.MZ_CENSO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MZ_CENSO", aliasTabla))))
        e.TONEL_MZ_CENSO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TONEL_MZ_CENSO", aliasTabla))))
        e.TONEL_CENSO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TONEL_CENSO", aliasTabla))))
        e.LBS_CENSO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}LBS_CENSO", aliasTabla))))
        e.VALOR_CENSO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}VALOR_CENSO", aliasTabla))))
        e.FIN_LOTE = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}FIN_LOTE", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.CODIAGRON = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIAGRON", aliasTabla))))
        e.FECHA_SIEMBRA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_SIEMBRA", aliasTabla))))
        e.ID_TIPO_CANA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_CANA", aliasTabla)), -1))
        e.ID_TIPO_ROZA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_ROZA", aliasTabla)), -1))
        e.ID_TIPO_ALZA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_ALZA", aliasTabla)), -1))
        e.ID_TIPO_TRANS = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_TRANS", aliasTabla)), -1))
        e.FAB_SEMANA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}FAB_SEMANA", aliasTabla)), -1))
        e.FAB_CATORCENA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}FAB_CATORCENA", aliasTabla)), -1))
        e.FAB_SUBTERCIO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}FAB_SUBTERCIO", aliasTabla))))
        e.FAB_TERCIO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}FAB_TERCIO", aliasTabla)), -1))
        e.TARIFA_ROZA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TARIFA_ROZA", aliasTabla)), -1))
        e.TARIFA_ALZA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TARIFA_ALZA", aliasTabla)), -1))
        e.TARIFA_TRANS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TARIFA_TRANS", aliasTabla)), -1))
        e.TARIFA_CORTA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TARIFA_CORTA", aliasTabla)), -1))
        e.TARIFA_LARGA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TARIFA_LARGA", aliasTabla)), -1))
        e.SALDO_ROZA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}SALDO_ROZA", aliasTabla))))
        e.EDAD_LOTE = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}EDAD_LOTE", aliasTabla))))
        e.SALDO_QUEMA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}SALDO_QUEMA", aliasTabla))))
        e.FECHA_ROZA_DISPO = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ROZA_DISPO", aliasTabla))))
        e.TONEL_SALDO_VAR = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TONEL_SALDO_VAR", aliasTabla))))
        e.TONEL_SEMILLA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TONEL_SEMILLA", aliasTabla))))
        e.FECHA_CIERRE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CIERRE", aliasTabla))))
        e.HORAS_GRACIA_ENTREGA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}HORAS_GRACIA_ENTREGA", aliasTabla)), -1))

        e.CODILOTE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODILOTE", aliasTabla))))
        e.NOMBLOTE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBLOTE", aliasTabla))))
        e.CODIPROVEEDOR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIPROVEEDOR", aliasTabla))))
        e.CONTRATADO = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}CONTRATADO", aliasTabla))))
        e.ID_MAESTRO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_MAESTRO", aliasTabla)), -1))
    End Sub

    Public Sub AsignarANALISIS_PRECOSECHA(ByVal dr As IDataReader, ByRef e As ANALISIS_PRECOSECHA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New ANALISIS_PRECOSECHA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_ANALISIS_PRE = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ANALISIS_PRE", aliasTabla))))
        e.ACCESLOTE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ACCESLOTE", aliasTabla))))
        e.ID_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA", aliasTabla))))
        e.NO_ANALISIS = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}NO_ANALISIS", aliasTabla))))
        e.FECHA_MUESTRA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_MUESTRA", aliasTabla))))
        e.NO_MUESTRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}NO_MUESTRA", aliasTabla))))
        e.AREA_MUESTRA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}AREA_MUESTRA", aliasTabla)), -1))
        e.BAGAZO_BRUTO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}BAGAZO_BRUTO", aliasTabla)), -1))
        e.BAGAZO_NETO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}BAGAZO_NETO", aliasTabla)), -1))
        e.POL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}POL", aliasTabla)), -1))
        e.BRIX = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}BRIX", aliasTabla)), -1))
        e.FIBRA_CANA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}FIBRA_CANA", aliasTabla)), -1))
        e.HUMEDAD = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}HUMEDAD", aliasTabla)), -1))
        e.POL_JUGO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}POL_JUGO", aliasTabla)), -1))
        e.JUGO_CANA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}JUGO_CANA", aliasTabla)), -1))
        e.POL_CANA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}POL_CANA", aliasTabla)), -1))
        e.PUREZA_JUGO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PUREZA_JUGO", aliasTabla)), -1))
        e.PUREZA_AZUCAR = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PUREZA_AZUCAR", aliasTabla)), -1))
        e.SJM = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}SJM", aliasTabla)), -1))
        e.RENDIA_CALC1 = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}RENDIA_CALC1", aliasTabla)), -1))
        e.RENDIA_CALC2 = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}RENDIA_CALC2", aliasTabla)), -1))
        e.POL_LECTURA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}POL_LECTURA", aliasTabla)), -1))
        e.PH = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PH", aliasTabla)), -1))
        e.AZUCAR_REDUCTORES = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}AZUCAR_REDUCTORES", aliasTabla)), -1))
        e.CANT_JUGO_ML = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}CANT_JUGO_ML", aliasTabla)), -1))
        e.VOL_TITULANTE = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}VOL_TITULANTE", aliasTabla)), -1))
        e.OBSERVACION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}OBSERVACION", aliasTabla))))
        e.ALMIDON_JUGO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ALMIDON_JUGO", aliasTabla)), -1))
        e.ACIDEZ_JUGO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ACIDEZ_JUGO", aliasTabla)), -1))
        e.ABSORVANCIA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ABSORVANCIA", aliasTabla)), -1))
        e.DEXTRANA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}DEXTRANA", aliasTabla)), -1))
        e.USUARIO_LEE_BAGAZO_BRUTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_LEE_BAGAZO_BRUTO", aliasTabla))))
        e.FECHA_LEE_BAGAZO_BRUTO = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_LEE_BAGAZO_BRUTO", aliasTabla))))
        e.USUARIO_LEE_BAGAZO_TARA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_LEE_BAGAZO_TARA", aliasTabla))))
        e.FECHA_LEE_BAGAZO_TARA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_LEE_BAGAZO_TARA", aliasTabla))))
        e.USUARIO_LEE_POL = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_LEE_POL", aliasTabla))))
        e.FECHA_LEE_POL = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_LEE_POL", aliasTabla))))
        e.USUARIO_LEE_BRIX = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_LEE_BRIX", aliasTabla))))
        e.FECHA_LEE_BRIX = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_LEE_BRIX", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_CT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CT", aliasTabla))))
        e.BRIX_DILU = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}BRIX_DILU", aliasTabla)), -1))
        e.ABSORBANCIA_ALMIDON = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ABSORBANCIA_ALMIDON", aliasTabla)), -1))
        e.ID_SUBLOTES = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_SUBLOTES", aliasTabla)), -1))
    End Sub


    Public Sub AsignarFILTRO_CANTON(ByVal dr As IDataReader, ByRef e As FILTRO_CANTON, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New FILTRO_CANTON
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_FILTRO_CANTON = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_FILTRO_CANTON", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.CODI_DEPTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODI_DEPTO", aliasTabla))))
        e.CODI_MUNI = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODI_MUNI", aliasTabla))))
        e.CODI_CANTON = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODI_CANTON", aliasTabla))))
    End Sub

    Public Sub AsignarTIPOS_GENERALES(ByVal dr As IDataReader, ByRef e As TIPOS_GENERALES, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New TIPOS_GENERALES
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_TIPO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO", aliasTabla))))
        e.ID_TIPO_TABLA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_TABLA", aliasTabla)), -1))
        e.ID_TIPO_PADRE = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_PADRE", aliasTabla)), -1))
        e.NOM_TIPO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOM_TIPO", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub

    Public Sub AsignarCICLO(ByVal dr As IDataReader, ByRef e As CICLO, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New CICLO
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_CICLO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CICLO", aliasTabla))))
        e.ID_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA", aliasTabla))))
        e.NOM_CICLO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOM_CICLO", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.TIPO_CICLO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}TIPO_CICLO", aliasTabla)), -1))
    End Sub


    Public Sub AsignarCICLO_PERIODO(ByVal dr As IDataReader, ByRef e As CICLO_PERIODO, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New CICLO_PERIODO
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_CICLO_PERIODO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CICLO_PERIODO", aliasTabla))))
        e.ID_CICLO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CICLO", aliasTabla))))
        e.FECHA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA", aliasTabla))))
        e.SEMANA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}SEMANA", aliasTabla)), -1))
        e.CATORCENA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}CATORCENA", aliasTabla)), -1))
        e.TERCIO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}TERCIO", aliasTabla)), -1))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.SUB_TERCIO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}SUB_TERCIO", aliasTabla))))
        e.TC_DIA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TC_DIA", aliasTabla)), -1))
    End Sub

    Public Sub AsignarMOTIVO_VARIACION(ByVal dr As IDataReader, ByRef e As MOTIVO_VARIACION, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New MOTIVO_VARIACION
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_MOTIVO_VARIACION = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_MOTIVO_VARIACION", aliasTabla))))
        e.DESCRIP_MOTIVO_VARIACION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DESCRIP_MOTIVO_VARIACION", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub

    Public Sub AsignarCENSO(ByVal dr As IDataReader, ByRef e As CENSO, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New CENSO
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_CENSO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CENSO", aliasTabla))))
        e.ID_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA", aliasTabla)), -1))
        e.FECHA_CENSO = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CENSO", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.NOMBRE_CENSO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_CENSO", aliasTabla))))
    End Sub

    Public Sub AsignarCENSO_LOTES(ByVal dr As IDataReader, ByRef e As CENSO_LOTES, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New CENSO_LOTES
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_CENSO_LOTES = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CENSO_LOTES", aliasTabla))))
        e.ID_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA", aliasTabla)), -1))
        e.ACCESLOTE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ACCESLOTE", aliasTabla))))
        e.FECHA_VERIFICACION = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_VERIFICACION", aliasTabla))))
        e.REND_HISTO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}REND_HISTO", aliasTabla)), -1))
        e.MZ_ENTREGAR = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MZ_ENTREGAR", aliasTabla))))
        e.TONEL_MZ_ENTREGAR = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TONEL_MZ_ENTREGAR", aliasTabla))))
        e.TONEL_ENTREGAR = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TONEL_ENTREGAR", aliasTabla))))
        e.LBS_ENTREGAR = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}LBS_ENTREGAR", aliasTabla))))
        e.VALOR_ENTREGAR = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}VALOR_ENTREGAR", aliasTabla))))
        e.MZ_ENTREGADA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MZ_ENTREGADA", aliasTabla))))
        e.TONEL_MZ_ENTREGADA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TONEL_MZ_ENTREGADA", aliasTabla))))
        e.TONEL_ENTREGADA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TONEL_ENTREGADA", aliasTabla))))
        e.LBS_ENTREGADA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}LBS_ENTREGADA", aliasTabla))))
        e.VALOR_ENTREGADA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}VALOR_ENTREGADA", aliasTabla))))
        e.MZ_CENSO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MZ_CENSO", aliasTabla))))
        e.TONEL_MZ_CENSO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TONEL_MZ_CENSO", aliasTabla))))
        e.TONEL_CENSO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TONEL_CENSO", aliasTabla))))
        e.LBS_CENSO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}LBS_CENSO", aliasTabla))))
        e.VALOR_CENSO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}VALOR_CENSO", aliasTabla))))
        e.ID_CENSO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CENSO", aliasTabla)), -1))
        e.ID_MOTIVO_VARIACION = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_MOTIVO_VARIACION", aliasTabla)), -1))
        e.OBSERVACION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}OBSERVACION", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub

    Public Sub AsignarTIPO_TEXTURA(ByVal dr As IDataReader, ByRef e As TIPO_TEXTURA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New TIPO_TEXTURA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.CODI_TEXTURA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODI_TEXTURA", aliasTabla))))
        e.NOMBRE_TEXTURA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_TEXTURA", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub

    Public Sub AsignarORDEN_COMBUSTIBLE_AUTORIZACION(ByVal dr As IDataReader, ByRef e As ORDEN_COMBUSTIBLE_AUTORIZACION, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New ORDEN_COMBUSTIBLE_AUTORIZACION
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_ORDEN_COMBUS_AUTO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ORDEN_COMBUS_AUTO", aliasTabla))))
        e.CODIGO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO", aliasTabla))))
        e.ID_TIPO_PROVEEDOR = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_PROVEEDOR", aliasTabla))))
        e.ID_ORDEN_COMBUS = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ORDEN_COMBUS", aliasTabla)), -1))
        e.AUTORIZACION_APLICADA = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}AUTORIZACION_APLICADA", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub

    Public Sub AsignarORDEN_COMBUSTIBLE_FAC_ANUL(ByVal dr As IDataReader, ByRef e As ORDEN_COMBUSTIBLE_FAC_ANUL, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New ORDEN_COMBUSTIBLE_FAC_ANUL
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_ORDEN_COMBUS_FAC_ANUL = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ORDEN_COMBUS_FAC_ANUL", aliasTabla))))
        e.ID_ORDEN_COMBUS = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ORDEN_COMBUS", aliasTabla))))
        e.NO_FACTURA_CCF = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NO_FACTURA_CCF", aliasTabla))))
        e.FECHA_DESPACHO = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_DESPACHO", aliasTabla))))
        e.FECHA_ANULACION = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ANULACION", aliasTabla))))
        e.MOTIVO_ANULACION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}MOTIVO_ANULACION", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.MONTO_FACTURA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MONTO_FACTURA", aliasTabla))))
    End Sub

    Public Sub AsignarTIPO_PROVEEDOR(ByVal dr As IDataReader, ByRef e As TIPO_PROVEEDOR, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New TIPO_PROVEEDOR
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_TIPO_PROVEEDOR = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_PROVEEDOR", aliasTabla))))
        e.NOMBRE_TIPO_PROVEEDOR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_TIPO_PROVEEDOR", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub

    Public Sub AsignarORDEN_COMBUSTIBLE_PROD(ByVal dr As IDataReader, ByRef e As ORDEN_COMBUSTIBLE_PROD, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New ORDEN_COMBUSTIBLE_PROD
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_ORDEN_COMBUSTIBLE_PROD = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ORDEN_COMBUSTIBLE_PROD", aliasTabla))))
        e.ID_ORDEN_COMBUS = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ORDEN_COMBUS", aliasTabla))))
        e.ID_PRODUCTO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PRODUCTO", aliasTabla))))
        e.CANTIDAD = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}CANTIDAD", aliasTabla))))
        e.PRECIO_VENTA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PRECIO_VENTA", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.NOMBRE_PRODUCTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_PRODUCTO", aliasTabla))))
    End Sub

    Public Sub AsignarCUENTA_PROVEEDOR(ByVal dr As IDataReader, ByRef e As CUENTA_PROVEEDOR, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New CUENTA_PROVEEDOR
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_CUENTA_PROVEEDOR = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CUENTA_PROVEEDOR", aliasTabla))))
        e.CUENTA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CUENTA", aliasTabla))))
        e.CODIGO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO", aliasTabla))))
        e.ID_TIPO_PROVEEDOR = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_PROVEEDOR", aliasTabla)), -1))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub

    Public Sub AsignarPRODUCTO_COMBUSTIBLE(ByVal dr As IDataReader, ByRef e As PRODUCTO_COMBUSTIBLE, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New PRODUCTO_COMBUSTIBLE
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_PRODUCTO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PRODUCTO", aliasTabla))))
        e.NOMBRE_PRODUCTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_PRODUCTO", aliasTabla))))
        e.PRECIO_VENTA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PRECIO_VENTA", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub

    Public Sub AsignarTIPO_PLANILLA_DESCTO(ByVal dr As IDataReader, ByRef e As TIPO_PLANILLA_DESCTO, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New TIPO_PLANILLA_DESCTO
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_TIPO_PLANILLA_DESCTO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_PLANILLA_DESCTO", aliasTabla))))
        e.ID_TIPO_PLANILLA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_PLANILLA", aliasTabla)), -1))
        e.ID_TIPO_DESCTO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_DESCTO", aliasTabla)), -1))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub

    Public Sub AsignarORDEN_ROZA_ENCA(ByVal dr As IDataReader, ByRef e As ORDEN_ROZA_ENCA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New ORDEN_ROZA_ENCA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_ORDEN = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ORDEN", aliasTabla))))
        e.FECHA_ORDEN = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ORDEN", aliasTabla))))
        e.TONEL_DIARIA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TONEL_DIARIA", aliasTabla))))
        e.CORRELATIVO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}CORRELATIVO", aliasTabla))))
        e.ID_PLAN_SEMANAL = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PLAN_SEMANAL", aliasTabla)), -1))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.ID_GENERACION = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_GENERACION", aliasTabla))))
    End Sub

    Public Sub AsignarORDEN_ROZA_DETA(ByVal dr As IDataReader, ByRef e As ORDEN_ROZA_DETA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New ORDEN_ROZA_DETA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_ORDEN_DETA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ORDEN_DETA", aliasTabla))))
        e.ID_ORDEN = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ORDEN", aliasTabla))))
        e.ID_PLAN_ENTREGA_CANA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PLAN_ENTREGA_CANA", aliasTabla))))
        e.ACCESLOTE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ACCESLOTE", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub

    Public Sub AsignarBANCOS(ByVal dr As IDataReader, ByRef e As BANCOS, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New BANCOS
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.CODIBANCO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}CODIBANCO", aliasTabla))))
        e.NOMBRE_BANCO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_BANCO", aliasTabla))))
        e.USER_CREA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}USER_CREA", aliasTabla)), -1))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USER_ACT = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}USER_ACT", aliasTabla)), -1))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub

    Public Sub AsignarRECIBO_CANA_NUMERACION(ByVal dr As IDataReader, ByRef e As RECIBO_CANA_NUMERACION, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New RECIBO_CANA_NUMERACION
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_RECIBO_CANA_NUM = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_RECIBO_CANA_NUM", aliasTabla))))
        e.NUM_INICIAL = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}NUM_INICIAL", aliasTabla))))
        e.NUM_FINAL = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}NUM_FINAL", aliasTabla))))
        e.ULT_NUM_ASIGNADO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ULT_NUM_ASIGNADO", aliasTabla)), -1))
        e.ACTIVO = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}ACTIVO", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub


    Public Sub AsignarRECIBO_CANA_ANULADO(ByVal dr As IDataReader, ByRef e As RECIBO_CANA_ANULADO, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New RECIBO_CANA_ANULADO
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_RECIBO_CANA_ANUL = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_RECIBO_CANA_ANUL", aliasTabla))))
        e.NUMRECIBO_CANA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}NUMRECIBO_CANA", aliasTabla)), -1))
        e.FECHA_ANULACION = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ANULACION", aliasTabla))))
        e.MOTIVO_ANULACION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}MOTIVO_ANULACION", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.ID_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA", aliasTabla))))
        e.ID_ENVIO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ENVIO", aliasTabla)), -1))
    End Sub

    Public Sub AsignarTARIFA_ROZA(ByVal dr As IDataReader, ByRef e As TARIFA_ROZA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New TARIFA_ROZA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_TARIFA_ROZA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TARIFA_ROZA", aliasTabla))))
        e.ACCESLOTE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ACCESLOTE", aliasTabla))))
        e.ROZA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ROZA", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub

    Public Sub AsignarTIPO_PLANILLA(ByVal dr As IDataReader, ByRef e As TIPO_PLANILLA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New TIPO_PLANILLA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_TIPO_PLANILLA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_PLANILLA", aliasTabla))))
        e.NOMBRE_TIPO_PLANILLA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_TIPO_PLANILLA", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub


    Public Sub AsignarPROVEEDOR_COMBUSTIBLE(ByVal dr As IDataReader, ByRef e As PROVEEDOR_COMBUSTIBLE, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New PROVEEDOR_COMBUSTIBLE
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_PROVEEDOR_COMBUS = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PROVEEDOR_COMBUS", aliasTabla))))
        e.NOMBRE_PROVEEDOR_COMBUS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_PROVEEDOR_COMBUS", aliasTabla))))
        e.NIT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NIT", aliasTabla))))
        e.DUI = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DUI", aliasTabla))))
        e.CREDITO_FISCAL = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CREDITO_FISCAL", aliasTabla))))
        e.ES_CONTRIBUYENTE = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}ES_CONTRIBUYENTE", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub


    Public Sub AsignarPROVEEDOR_ROZA(ByVal dr As IDataReader, ByRef e As PROVEEDOR_ROZA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New PROVEEDOR_ROZA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_PROVEEDOR_ROZA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PROVEEDOR_ROZA", aliasTabla))))
        e.NOMBRE_PROVEEDOR_ROZA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_PROVEEDOR_ROZA", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.NIT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NIT", aliasTabla))))
        e.DUI = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DUI", aliasTabla))))
        e.CREDITO_FISCAL = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CREDITO_FISCAL", aliasTabla))))
        e.ES_CONTRIBUYENTE = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}ES_CONTRIBUYENTE", aliasTabla))))
        e.FACTOR_PAGO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}FACTOR_PAGO", aliasTabla)), -1))
        e.ID_TIPO_ROZA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_ROZA", aliasTabla))))
        e.ACTIVO = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}ACTIVO", aliasTabla))))
        e.DIRECCION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DIRECCION", aliasTabla))))
        e.CODI_DEPTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODI_DEPTO", aliasTabla))))
        e.CODI_MUNI = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODI_MUNI", aliasTabla))))
        e.CORREO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CORREO", aliasTabla))))
        e.ID_TIPO_PERSONA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_PERSONA", aliasTabla)), -1))
        e.TELEFONO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TELEFONO", aliasTabla))))
        e.ACTIVIDAD = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ACTIVIDAD", aliasTabla))))
        e.APELLIDOS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}APELLIDOS", aliasTabla))))
        e.CODIGO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO", aliasTabla))))
    End Sub


    Public Sub AsignarPLAN_SEMANAL(ByVal dr As IDataReader, ByRef e As PLAN_SEMANAL, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New PLAN_SEMANAL
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_PLAN_SEMANAL = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PLAN_SEMANAL", aliasTabla))))
        e.ID_PLAN_CATORCENA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PLAN_CATORCENA", aliasTabla))))
        e.NO_SEMANA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}NO_SEMANA", aliasTabla))))
        e.FECHA_INICIO = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_INICIO", aliasTabla))))
        e.FECHA_FIN = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_FIN", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub

    Public Sub AsignarPLAN_ENTREGA_CANA(ByVal dr As IDataReader, ByRef e As PLAN_ENTREGA_CANA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New PLAN_ENTREGA_CANA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_PLAN_ENTREGA_CANA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PLAN_ENTREGA_CANA", aliasTabla))))
        e.ID_PLAN_SEMANAL = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PLAN_SEMANAL", aliasTabla))))
        e.ACCESLOTE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ACCESLOTE", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.AREA_PROGRAMADA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}AREA_PROGRAMADA", aliasTabla)), -1))
        e.TONEL_PROGRAMADA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TONEL_PROGRAMADA", aliasTabla)), -1))
    End Sub

    Public Sub AsignarPLAN_CATORCENA(ByVal dr As IDataReader, ByRef e As PLAN_CATORCENA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New PLAN_CATORCENA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_PLAN_CATORCENA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PLAN_CATORCENA", aliasTabla))))
        e.ID_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA", aliasTabla)), -1))
        e.NO_CATORCENA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}NO_CATORCENA", aliasTabla))))
        e.FECHA_INICIO = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_INICIO", aliasTabla))))
        e.FECHA_FIN = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_FIN", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub

    Public Sub AsignarPLANILLA(ByVal dr As IDataReader, ByRef e As PLANILLA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New PLANILLA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_CATORCENA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CATORCENA", aliasTabla))))
        e.CODIPROVEEDOR_TRANSPORTISTA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIPROVEEDOR_TRANSPORTISTA", aliasTabla))))
        e.ID_TIPO_PLANILLA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_PLANILLA", aliasTabla))))
        e.NOMBRE_ZAFRA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_ZAFRA", aliasTabla))))
        e.CODIPROVEE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIPROVEE", aliasTabla))))
        e.CODISOCIO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODISOCIO", aliasTabla))))
        e.CANT_RECIBOS = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}CANT_RECIBOS", aliasTabla))))
        e.TONEL_CANA_ENTREGADA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TONEL_CANA_ENTREGADA", aliasTabla)), -1))
        e.AZUCAR_CATORCENA_REAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}AZUCAR_CATORCENA_REAL", aliasTabla)), -1))
        e.VALOR = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}VALOR", aliasTabla))))
        e.IVA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}IVA", aliasTabla))))
        e.VALOR_BRUTO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}VALOR_BRUTO", aliasTabla))))
        e.RENTA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}RENTA", aliasTabla))))
        e.RETENCION_IVA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}RETENCION_IVA", aliasTabla))))
        e.DESC_FLETE = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}DESC_FLETE", aliasTabla))))
        e.DESC_CARGA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}DESC_CARGA", aliasTabla))))
        e.DESC_CARGA_CONTRA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}DESC_CARGA_CONTRA", aliasTabla))))
        e.DESC_BANCOS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}DESC_BANCOS", aliasTabla))))
        e.DESC_COMBUSTIBLE = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}DESC_COMBUSTIBLE", aliasTabla))))
        e.DESC_ANTICIPO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}DESC_ANTICIPO", aliasTabla))))
        e.DESC_INTERES = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}DESC_INTERES", aliasTabla))))
        e.DESC_AGROQUIMICO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}DESC_AGROQUIMICO", aliasTabla))))
        e.DESC_SEGURO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}DESC_SEGURO", aliasTabla))))
        e.DESC_RESPUESTOS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}DESC_RESPUESTOS", aliasTabla))))
        e.DESC_OTROS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}DESC_OTROS", aliasTabla))))
        e.PAGO_NETO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PAGO_NETO", aliasTabla))))
        e.ES_CONTRIBUYENTE = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}ES_CONTRIBUYENTE", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.DESC_SERVICIO_ROZA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}DESC_SERVICIO_ROZA", aliasTabla))))
        e.NOMBRE_PROVEE_TRANS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_PROVEE_TRANS", aliasTabla))))
        e.NO_CHEQUE = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}NO_CHEQUE", aliasTabla)), -1))
        e.ID_CHEQUE_PLANILLA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CHEQUE_PLANILLA", aliasTabla)), -1))
        e.ID_PLANILLA_BASE = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PLANILLA_BASE", aliasTabla)), -1))
        e.ID_TIPO_PROVEEDOR = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_PROVEEDOR", aliasTabla))))
    End Sub

    Public Sub AsignarCUENTA_BANCARIA(ByVal dr As IDataReader, ByRef e As CUENTA_BANCARIA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New CUENTA_BANCARIA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_CUENTA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CUENTA", aliasTabla))))
        e.NO_CUENTA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NO_CUENTA", aliasTabla))))
        e.CODIBANCO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}CODIBANCO", aliasTabla))))
        e.CUENTA_CONTABLE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CUENTA_CONTABLE", aliasTabla))))
        e.DESCRIPCION_CUENTA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DESCRIPCION_CUENTA", aliasTabla))))
        e.ACTIVO = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}ACTIVO", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub

    Public Sub AsignarAPLICACION_DESCTO(ByVal dr As IDataReader, ByRef e As APLICACION_DESCTO, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New APLICACION_DESCTO
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_APLICACION_DESCTO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_APLICACION_DESCTO", aliasTabla))))
        e.NOMBRE_APLICACION_DESCTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_APLICACION_DESCTO", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub

    Public Sub AsignarGRUPO_DESCUENTOS(ByVal dr As IDataReader, ByRef e As GRUPO_DESCUENTOS, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New GRUPO_DESCUENTOS
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_GRUPO_DESC = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_GRUPO_DESC", aliasTabla))))
        e.NOMBRE_GRUPO_DESC = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_GRUPO_DESC", aliasTabla))))
        e.ORDEN = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ORDEN", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub

    Public Sub AsignarTIPO_DESCUENTO(ByVal dr As IDataReader, ByRef e As TIPO_DESCUENTO, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New TIPO_DESCUENTO
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_TIPO_DESCTO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_DESCTO", aliasTabla))))
        e.NOMBRE_TIPO_DESCTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_TIPO_DESCTO", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.ID_GRUPO_DESC = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_GRUPO_DESC", aliasTabla))))
    End Sub

    Public Sub AsignarDESCUENTOS_PLANILLA_OC(ByVal dr As IDataReader, ByRef e As DESCUENTOS_PLANILLA_OC, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New DESCUENTOS_PLANILLA_OC
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_DESC_PLA_OC = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_DESC_PLA_OC", aliasTabla))))
        e.ID_DESCUENTO_PLANILLA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_DESCUENTO_PLANILLA", aliasTabla))))
        e.ID_ORDEN_COMBUS = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ORDEN_COMBUS", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub

    Public Sub AsignarDESCUENTOS_PLANILLA(ByVal dr As IDataReader, ByRef e As DESCUENTOS_PLANILLA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New DESCUENTOS_PLANILLA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_DESCUENTO_PLANILLA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_DESCUENTO_PLANILLA", aliasTabla))))
        e.ID_CATORCENA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CATORCENA", aliasTabla))))
        e.CODIPROVEEDOR_TRANSPORTISTA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIPROVEEDOR_TRANSPORTISTA", aliasTabla))))
        e.ID_TIPO_PLANILLA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_PLANILLA", aliasTabla))))
        e.ID_TIPO_DESCTO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_DESCTO", aliasTabla))))
        e.ID_APLICACION_DESCTO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_APLICACION_DESCTO", aliasTabla))))
        e.MONTO_DESCUENTO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MONTO_DESCUENTO", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.IVA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}IVA", aliasTabla))))
        e.CODIBANCO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}CODIBANCO", aliasTabla)), -1))
        e.ID_CREDITO_ENCA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CREDITO_ENCA", aliasTabla)), -1))
        e.ID_CREDITO_ENCA_TRANS = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CREDITO_ENCA_TRANS", aliasTabla)), -1))
    End Sub

    Public Sub AsignarDISTRIBUCION_DESCTO(ByVal dr As IDataReader, ByRef e As DISTRIBUCION_DESCTO, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New DISTRIBUCION_DESCTO
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_DISTRIB_DESCTO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_DISTRIB_DESCTO", aliasTabla))))
        e.CODICONTRATO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODICONTRATO", aliasTabla))))
        e.ACCESLOTE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ACCESLOTE", aliasTabla))))
        e.ID_DESCUENTO_PLANILLA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_DESCUENTO_PLANILLA", aliasTabla))))
        e.MONTO_DESCUENTO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MONTO_DESCUENTO", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub

    Public Sub AsignarZAFGAS(ByVal dr As IDataReader, ByRef e As ZAFGAS, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New ZAFGAS
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.MEDIO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}MEDIO", aliasTabla))))
        e.EFICIENCIA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}EFICIENCIA", aliasTabla))))
        e.CAPACIDAD = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}CAPACIDAD", aliasTabla))))
        e.GASBASE = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}GASBASE", aliasTabla))))
        e.GASPRECIO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}GASPRECIO", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub

    Public Sub AsignarAJUSTE_POL(ByVal dr As IDataReader, ByRef e As AJUSTE_POL, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New AJUSTE_POL
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.DENSIDAD = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}DENSIDAD", aliasTabla))))
        e.DENSIAPARE = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}DENSIAPARE", aliasTabla))))
        e.PESOESP = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PESOESP", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub

    Public Sub AsignarZONAS(ByVal dr As IDataReader, ByRef e As ZONAS, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New ZONAS
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ZONA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ZONA", aliasTabla))))
        e.DESCRIP_ZONA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DESCRIP_ZONA", aliasTabla))))
        e.USER_CREA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}USER_CREA", aliasTabla)), -1))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USER_ACT = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}USER_ACT", aliasTabla)), -1))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub

    Public Sub AsignarDATOS_LABORATORIO(ByVal dr As IDataReader, ByRef e As DATOS_LABORATORIO, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New DATOS_LABORATORIO
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_DATOS_LAB = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_DATOS_LAB", aliasTabla))))
        e.ID_ANALISIS = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ANALISIS", aliasTabla))))
        e.ANALISTA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ANALISTA", aliasTabla))))
        e.LBS_MUESTRA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}LBS_MUESTRA", aliasTabla)), -1))
        e.LBS_PUNTAS_TIERNA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}LBS_PUNTAS_TIERNA", aliasTabla)), -1))
        e.LBS_CANA_SECA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}LBS_CANA_SECA", aliasTabla)), -1))
        e.LBS_MAMONES = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}LBS_MAMONES", aliasTabla)), -1))
        e.LBS_BAJERA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}LBS_BAJERA", aliasTabla)), -1))
        e.LBS_TIERRA_RAICES = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}LBS_TIERRA_RAICES", aliasTabla)), -1))
        e.LBS_PIEDRA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}LBS_PIEDRA", aliasTabla)), -1))
        e.LBS_CANA_LIMPIA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}LBS_CANA_LIMPIA", aliasTabla)), -1))
        e.OBSERVACION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}OBSERVACION", aliasTabla))))
        e.PORC_PUNTAS_TIERNA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PORC_PUNTAS_TIERNA", aliasTabla)), -1))
        e.PORC_CANA_SECA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PORC_CANA_SECA", aliasTabla)), -1))
        e.PORC_MAMONES = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PORC_MAMONES", aliasTabla)), -1))
        e.PORC_BAJERA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PORC_BAJERA", aliasTabla)), -1))
        e.PORC_TIERRA_RAICES = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PORC_TIERRA_RAICES", aliasTabla)), -1))
        e.PORC_PIEDRA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PORC_PIEDRA", aliasTabla)), -1))
        e.PORC_CANA_LIMPIA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PORC_CANA_LIMPIA", aliasTabla)), -1))
        e.PORC_MATERIA_EXTRA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PORC_MATERIA_EXTRA", aliasTabla)), -1))
        e.ABSORVANCIA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ABSORVANCIA", aliasTabla)), -1))
        e.DEXTRANA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}DEXTRANA", aliasTabla)), -1))
        e.ACIDEZ = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ACIDEZ", aliasTabla)), -1))
        e.REDUCTORES = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}REDUCTORES", aliasTabla)), -1))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.BRIX_DILU = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}BRIX_DILU", aliasTabla)), -1))
        e.ABSORBANCIA_ALMIDON = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ABSORBANCIA_ALMIDON", aliasTabla)), -1))
        e.ALMIDON_JUGO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ALMIDON_JUGO", aliasTabla)), -1))
    End Sub

    Public Sub AsignarZAFRA(ByVal dr As IDataReader, ByRef e As ZAFRA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New ZAFRA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA", aliasTabla))))
        e.NOMBRE_ZAFRA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_ZAFRA", aliasTabla))))
        e.DIAZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}DIAZAFRA", aliasTabla))))
        e.CATORCENA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}CATORCENA", aliasTabla))))
        e.FECHA_INICIO = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_INICIO", aliasTabla))))
        e.FECHA_FINAL = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_FINAL", aliasTabla))))
        e.POL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}POL", aliasTabla))))
        e.HUMEDAD = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}HUMEDAD", aliasTabla))))
        e.PUREZA_MIEL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PUREZA_MIEL", aliasTabla))))
        e.EFICIENCIA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}EFICIENCIA", aliasTabla))))
        e.PRECIO_LIBRA_AZUCAR = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PRECIO_LIBRA_AZUCAR", aliasTabla))))
        e.CONSTANTE_A = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}CONSTANTE_A", aliasTabla))))
        e.CONSTANTE_B = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}CONSTANTE_B", aliasTabla))))
        e.CONSTANTE_D = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}CONSTANTE_D", aliasTabla))))
        e.CONSTANTE_E = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}CONSTANTE_E", aliasTabla))))
        e.ULTFECHA_CIERRE_DIARIO = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}ULTFECHA_CIERRE_DIARIO", aliasTabla))))
        e.ACTIVA = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}ACTIVA", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.DISPO_INVE_ROZA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}DISPO_INVE_ROZA", aliasTabla)), -1))
        e.REND_MODFINAN = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}REND_MODFINAN", aliasTabla)), -1))
        e.TARIFA_ROZA_MODFINAN = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TARIFA_ROZA_MODFINAN", aliasTabla)), -1))
        e.TARIFA_ALZA_MODFINAN = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TARIFA_ALZA_MODFINAN", aliasTabla)), -1))
        e.TARIFA_QUERQUEO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TARIFA_QUERQUEO", aliasTabla)), -1))
        e.PUREZA_AZUCAR = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PUREZA_AZUCAR", aliasTabla)), -1))
        e.CAPTURA_POL_BRIX_SIMULTANEA = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}CAPTURA_POL_BRIX_SIMULTANEA", aliasTabla))))
        e.VIP_UNIDAD_TRADICIONAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}VIP_UNIDAD_TRADICIONAL", aliasTabla)), -1))
    End Sub

    Public Sub AsignarTIPO_LECTURA(ByVal dr As IDataReader, ByRef e As TIPO_LECTURA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New TIPO_LECTURA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_TIPO_LECTURA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_LECTURA", aliasTabla))))
        e.NOMBRE_TIPO_LECTURA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_TIPO_LECTURA", aliasTabla))))
        e.ID_EQUIPO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_EQUIPO", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub

    Public Sub AsignarLECTURA_POR_PERFIL(ByVal dr As IDataReader, ByRef e As LECTURA_POR_PERFIL, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New LECTURA_POR_PERFIL
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_LECTURA_PERFIL = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_LECTURA_PERFIL", aliasTabla))))
        e.ID_PERFIL = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PERFIL", aliasTabla))))
        e.ID_TIPO_LECTURA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_LECTURA", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub

    Public Sub AsignarEQUIPO_MEDICION(ByVal dr As IDataReader, ByRef e As EQUIPO_MEDICION, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New EQUIPO_MEDICION
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_EQUIPO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_EQUIPO", aliasTabla))))
        e.NOMBRE_EQUIPO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_EQUIPO", aliasTabla))))
        e.PUERTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}PUERTO", aliasTabla))))
        e.BITS_POR_SEGUNDO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}BITS_POR_SEGUNDO", aliasTabla))))
        e.BITS_DATOS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}BITS_DATOS", aliasTabla))))
        e.PARIDAD = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}PARIDAD", aliasTabla))))
        e.BITS_PARADA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}BITS_PARADA", aliasTabla))))
        e.CONTROL_FLUJO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CONTROL_FLUJO", aliasTabla))))
        e.HABILITADO = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}HABILITADO", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub

    Public Sub AsignarVARIEDAD(ByVal dr As IDataReader, ByRef e As VARIEDAD, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New VARIEDAD
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.CODIVARIEDA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIVARIEDA", aliasTabla))))
        e.NOM_VARIEDAD = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOM_VARIEDAD", aliasTabla))))
        e.DESCRP_VARIEDAD = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DESCRP_VARIEDAD", aliasTabla))))
        e.USER_CREA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}USER_CREA", aliasTabla)), -1))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USER_ACT = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}USER_ACT", aliasTabla)), -1))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.ID_TIPO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO", aliasTabla)), -1))
        e.ID_SUB_TIPO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_SUB_TIPO", aliasTabla)), -1))
    End Sub


    Public Sub AsignarUSUARIO(ByVal dr As IDataReader, ByRef e As USUARIO, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New USUARIO
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.USUARIO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO", aliasTabla))))
        e.ID_PERFIL = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PERFIL", aliasTabla)), -1))
        e.NOMBRE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE", aliasTabla))))
        e.EMAIL = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}EMAIL", aliasTabla))))
        e.CLAVE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CLAVE", aliasTabla))))
        e.ACTIVO = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}ACTIVO", aliasTabla))))
        e.BLOQUEADO = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}BLOQUEADO", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.FECHA_ULTACCESO = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ULTACCESO", aliasTabla))))
    End Sub


    Public Sub AsignarUBICACION(ByVal dr As IDataReader, ByRef e As UBICACION, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New UBICACION
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.CODIUBICACION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIUBICACION", aliasTabla))))
        e.CODITARIFA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODITARIFA", aliasTabla))))
        e.DEPARTAMENTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DEPARTAMENTO", aliasTabla))))
        e.MUNICIPIO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}MUNICIPIO", aliasTabla))))
        e.CANTON = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CANTON", aliasTabla))))
        e.KILOMETRO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}KILOMETRO", aliasTabla)), -1))
        e.USER_CREA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}USER_CREA", aliasTabla)), -1))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USER_ACT = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}USER_ACT", aliasTabla)), -1))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub

    Public Sub AsignarMOTORISTA_VEHICULO(ByVal dr As IDataReader, ByRef e As MOTORISTA_VEHICULO, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New MOTORISTA_VEHICULO
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_MOTORISTA_VEHI = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_MOTORISTA_VEHI", aliasTabla))))
        e.ID_MOTORISTA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_MOTORISTA", aliasTabla)), -1))
        e.ID_TRANSPORTE = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TRANSPORTE", aliasTabla)), -1))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.ES_PARTICULAR = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}ES_PARTICULAR", aliasTabla))))
        e.VER_ORDEN_COMB = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}VER_ORDEN_COMB", aliasTabla))))
        e.VER_PROFORMA = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}VER_PROFORMA", aliasTabla))))
        e.ID_LIC = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_LIC", aliasTabla)), -1))
        e.ACTIVO = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}ACTIVO", aliasTabla))))
        e.CASTIGADO = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}CASTIGADO", aliasTabla))))
        e.ID_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA", aliasTabla)), -1))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.ID_CARGADORA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CARGADORA", aliasTabla)), -1))
    End Sub

    Public Sub AsignarCONTRATO_TRANS_VEHI(ByVal dr As IDataReader, ByRef e As CONTRATO_TRANS_VEHI, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New CONTRATO_TRANS_VEHI
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_CONTRA_TRANS_VEHI = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CONTRA_TRANS_VEHI", aliasTabla))))
        e.ID_CONTRA_TRANS = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CONTRA_TRANS", aliasTabla)), -1))
        e.ID_TRANSPORTE = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TRANSPORTE", aliasTabla)), -1))
        e.ID_TIPOTRANS = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPOTRANS", aliasTabla)), -1))
        e.REMOLQUE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}REMOLQUE", aliasTabla))))
        e.PLACA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}PLACA", aliasTabla))))
        e.CAPACIDAD = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}CAPACIDAD", aliasTabla)), -1))
        e.MARCA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}MARCA", aliasTabla))))
        e.ANIO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ANIO", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub


    Public Sub AsignarCONTRATO_TRANS(ByVal dr As IDataReader, ByRef e As CONTRATO_TRANS, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New CONTRATO_TRANS
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_CONTRA_TRANS = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CONTRA_TRANS", aliasTabla))))
        e.COD_CONTRATO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}COD_CONTRATO", aliasTabla))))
        e.NO_CONTRATO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}NO_CONTRATO", aliasTabla)), -1))
        e.ID_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA", aliasTabla)), -1))
        e.FECINI = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECINI", aliasTabla))))
        e.FECFIN = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECFIN", aliasTabla))))
        e.LUGAR_CORTE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}LUGAR_CORTE", aliasTabla))))
        e.FECHA_CONTRA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CONTRA", aliasTabla))))
        e.CODTRANSPORT = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}CODTRANSPORT", aliasTabla)), -1))
        e.NOMBRE_TRANS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_TRANS", aliasTabla))))
        e.NIT_TRANS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NIT_TRANS", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub


    Public Sub AsignarTRANSPORTE(ByVal dr As IDataReader, ByRef e As TRANSPORTE, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New TRANSPORTE
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_TRANSPORTE = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TRANSPORTE", aliasTabla))))
        e.PLACA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}PLACA", aliasTabla))))
        e.CODTRANSPORT = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}CODTRANSPORT", aliasTabla))))
        e.ID_TIPOTRANS = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPOTRANS", aliasTabla))))
        e.REMOLQUE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}REMOLQUE", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.MARCA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}MARCA", aliasTabla))))
        e.CAPACIDAD = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}CAPACIDAD", aliasTabla)), -1))
        e.ANIO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ANIO", aliasTabla))))
    End Sub

    Public Sub AsignarCHEQUERA_PLANILLA(ByVal dr As IDataReader, ByRef e As CHEQUERA_PLANILLA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New CHEQUERA_PLANILLA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_CHEQUERA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CHEQUERA", aliasTabla))))
        e.ID_CUENTA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CUENTA", aliasTabla))))
        e.SERIE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}SERIE", aliasTabla))))
        e.NO_CHEQUE_INICIAL = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}NO_CHEQUE_INICIAL", aliasTabla))))
        e.NO_CHEQUE_FINAL = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}NO_CHEQUE_FINAL", aliasTabla))))
        e.ULT_CHEQUE_ASIGNADO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ULT_CHEQUE_ASIGNADO", aliasTabla)), -1))
        e.ACTIVO = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}ACTIVO", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub

    Public Sub AsignarCHEQUE_PARTIDA(ByVal dr As IDataReader, ByRef e As CHEQUE_PARTIDA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New CHEQUE_PARTIDA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_CHEQUE_PARTIDA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CHEQUE_PARTIDA", aliasTabla))))
        e.ID_CHEQUE_PLANILLA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CHEQUE_PLANILLA", aliasTabla))))
        e.ORDEN = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ORDEN", aliasTabla))))
        e.CUENTA_CONTABLE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CUENTA_CONTABLE", aliasTabla))))
        e.DESCRIPCION_CUENTA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DESCRIPCION_CUENTA", aliasTabla))))
        e.DESCRIPCION_ADICIONAL = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DESCRIPCION_ADICIONAL", aliasTabla))))
        e.DEBE = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}DEBE", aliasTabla))))
        e.HABER = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}HABER", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub

    Public Sub AsignarCHEQUE_PLANILLA(ByVal dr As IDataReader, ByRef e As CHEQUE_PLANILLA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New CHEQUE_PLANILLA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_CHEQUE_PLANILLA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CHEQUE_PLANILLA", aliasTabla))))
        e.ID_CHEQUERA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CHEQUERA", aliasTabla))))
        e.NO_CHEQUE = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}NO_CHEQUE", aliasTabla))))
        e.MONTO_CHEQUE = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MONTO_CHEQUE", aliasTabla)), -1))
        e.CANTIDAD_LETRAS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CANTIDAD_LETRAS", aliasTabla))))
        e.TITULAR_CHEQUE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TITULAR_CHEQUE", aliasTabla))))
        e.ESTADO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ESTADO", aliasTabla))))
        e.FECHA_EMISION = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_EMISION", aliasTabla))))
        e.FECHA_ANULACION = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ANULACION", aliasTabla))))
        e.MOTIVO_ANULACION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}MOTIVO_ANULACION", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.NO_PARTIDA_PH = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}NO_PARTIDA_PH", aliasTabla)), -1))
        e.ID_CATORCENA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CATORCENA", aliasTabla)), -1))
        e.ID_TIPO_PLANILLA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_PLANILLA", aliasTabla)), -1))
        e.CODIPROVEEDOR_TRANSPORTISTA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIPROVEEDOR_TRANSPORTISTA", aliasTabla))))
    End Sub

    Public Sub AsignarTRANSPORTISTA(ByVal dr As IDataReader, ByRef e As TRANSPORTISTA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New TRANSPORTISTA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.CODTRANSPORT = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}CODTRANSPORT", aliasTabla))))
        e.ACTIVO = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}ACTIVO", aliasTabla))))
        e.NOMBRES = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRES", aliasTabla))))
        e.APELLIDOS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}APELLIDOS", aliasTabla))))
        e.NIT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NIT", aliasTabla))))
        e.CREDITO_FISCAL = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CREDITO_FISCAL", aliasTabla))))
        e.TELEFONO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TELEFONO", aliasTabla))))
        e.NOMBRE_CH = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_CH", aliasTabla))))
        e.DIRECCION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DIRECCION", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.DUI = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DUI", aliasTabla))))
        e.ES_INGENIO = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}ES_INGENIO", aliasTabla))))
        e.NOCUENTA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOCUENTA", aliasTabla))))
        e.COD_SIGASI = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}COD_SIGASI", aliasTabla)), -1))
        e.COD_COMBUST = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}COD_COMBUST", aliasTabla)), -1))
        e.CODIBANCO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}CODIBANCO", aliasTabla)), -1))
        e.NUM_CUENTA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NUM_CUENTA", aliasTabla))))
        e.ES_CTA_CORRIENTE = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}ES_CTA_CORRIENTE", aliasTabla))))
        e.PROFESION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}PROFESION", aliasTabla))))
        e.FECHA_NACIMIENTO = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_NACIMIENTO", aliasTabla))))
        e.CODI_DEPTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODI_DEPTO", aliasTabla))))
        e.CODI_MUNI = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODI_MUNI", aliasTabla))))
        e.CORREO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CORREO", aliasTabla))))
        e.ID_TIPO_PERSONA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_PERSONA", aliasTabla)), -1))
        e.ACTIVIDAD = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ACTIVIDAD", aliasTabla))))
        e.ACTIVIDAD2 = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ACTIVIDAD2", aliasTabla))))
        e.ACTIVIDAD3 = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ACTIVIDAD3", aliasTabla))))
    End Sub


    Public Sub AsignarTIPO_TRANSPORTE(ByVal dr As IDataReader, ByRef e As TIPO_TRANSPORTE, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New TIPO_TRANSPORTE
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_TIPOTRANS = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPOTRANS", aliasTabla))))
        e.NOMBRE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub

    Public Sub AsignarTIPO_CARGADORA(ByVal dr As IDataReader, ByRef e As TIPO_CARGADORA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New TIPO_CARGADORA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_TIPO_CARGADORA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_CARGADORA", aliasTabla))))
        e.NOMBRE_TIPO_CARGADORA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_TIPO_CARGADORA", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub

    Public Sub AsignarTIPO_CANA(ByVal dr As IDataReader, ByRef e As TIPO_CANA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New TIPO_CANA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_TIPO_CANA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_CANA", aliasTabla))))
        e.NOMBRE_CANA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_CANA", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub

    Public Sub AsignarTARIFA(ByVal dr As IDataReader, ByRef e As TARIFA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New TARIFA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.CODITARIFA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODITARIFA", aliasTabla))))
        e.CORTA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}CORTA", aliasTabla)), -1))
        e.LARGA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}LARGA", aliasTabla)), -1))
        e.USER_CREA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}USER_CREA", aliasTabla)), -1))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USER_ACT = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}USER_ACT", aliasTabla)), -1))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub

    Public Sub AsignarSUPERVISOR(ByVal dr As IDataReader, ByRef e As SUPERVISOR, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New SUPERVISOR
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_SUPERVISOR = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_SUPERVISOR", aliasTabla))))
        e.NOMBRE_SUPERVISOR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_SUPERVISOR", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub


    Public Sub AsignarORDEN_COMBUSTIBLE(ByVal dr As IDataReader, ByRef e As ORDEN_COMBUSTIBLE, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New ORDEN_COMBUSTIBLE
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_ORDEN_COMBUS = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ORDEN_COMBUS", aliasTabla))))
        e.ID_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA", aliasTabla)), -1))
        e.ID_PROVEEDOR_COMBUS = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PROVEEDOR_COMBUS", aliasTabla))))
        e.ID_TRANSPORTE = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TRANSPORTE", aliasTabla)), -1))
        e.ID_MOTORISTA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_MOTORISTA", aliasTabla)), -1))
        e.FECHA_EMISION = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_EMISION", aliasTabla))))
        e.NOMBRES_MOTORISTA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRES_MOTORISTA", aliasTabla))))
        e.APELLIDOS_MOTORISTA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}APELLIDOS_MOTORISTA", aliasTabla))))
        e.PLACA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}PLACA", aliasTabla))))
        e.FECHA_DESPACHO = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_DESPACHO", aliasTabla))))
        e.NO_FACTURA_CCF = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NO_FACTURA_CCF", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.DUI = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DUI", aliasTabla))))
        e.LICENCIA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}LICENCIA", aliasTabla))))
        e.ESTADO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ESTADO", aliasTabla))))
        e.FECHA_ANULACION = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ANULACION", aliasTabla))))
        e.MOTIVO_ANULACION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}MOTIVO_ANULACION", aliasTabla))))
        e.NO_ORDEN = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NO_ORDEN", aliasTabla))))
        e.ID_ORDEN_COMBUSTIBLE_NUM = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ORDEN_COMBUSTIBLE_NUM", aliasTabla)), -1))
        e.TOTAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TOTAL", aliasTabla)), -1))
        e.CODIGO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO", aliasTabla))))
        e.ID_TIPO_PROVEEDOR = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_PROVEEDOR", aliasTabla))))
        e.ID_CATORCENA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CATORCENA", aliasTabla)), -1))
        e.NIT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NIT", aliasTabla))))
        e.NRC = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NRC", aliasTabla))))
        e.CODIBARRA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIBARRA", aliasTabla))))
        e.ID_SECCION = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_SECCION", aliasTabla)), -1))
        e.OBSERVACION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}OBSERVACION", aliasTabla))))
        e.ID_MOTORISTA_VEHI = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ID_MOTORISTA_VEHI", aliasTabla)), -1))
    End Sub

    Public Sub AsignarORDEN_COMBUSTIBLE_NUMERACION(ByVal dr As IDataReader, ByRef e As ORDEN_COMBUSTIBLE_NUMERACION, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New ORDEN_COMBUSTIBLE_NUMERACION
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_ORDEN_COMBUSTIBLE_NUM = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ORDEN_COMBUSTIBLE_NUM", aliasTabla))))
        e.ID_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA", aliasTabla))))
        e.SERIE_ORDEN_COMBUSTIBLE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}SERIE_ORDEN_COMBUSTIBLE", aliasTabla))))
        e.NO_INICIAL = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}NO_INICIAL", aliasTabla))))
        e.NO_FINAL = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}NO_FINAL", aliasTabla))))
        e.ULT_NUM_ASIGNADO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ULT_NUM_ASIGNADO", aliasTabla)), -1))
        e.ES_INGENIO = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}ES_INGENIO", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub

    Public Sub AsignarPROVEEDOR_CARGA(ByVal dr As IDataReader, ByRef e As PROVEEDOR_CARGA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New PROVEEDOR_CARGA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_PROVEEDOR_CARGA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PROVEEDOR_CARGA", aliasTabla))))
        e.NOMBRE_PROVEEDOR_CARGA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_PROVEEDOR_CARGA", aliasTabla))))
        e.NIT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NIT", aliasTabla))))
        e.DUI = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DUI", aliasTabla))))
        e.CREDITO_FISCAL = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CREDITO_FISCAL", aliasTabla))))
        e.ES_CONTRIBUYENTE = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}ES_CONTRIBUYENTE", aliasTabla))))
        e.ES_INGENIO = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}ES_INGENIO", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.TELEFONO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TELEFONO", aliasTabla))))
        e.ACTIVIDAD = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ACTIVIDAD", aliasTabla))))
        e.DIRECCION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DIRECCION", aliasTabla))))
        e.CORREO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CORREO", aliasTabla))))
        e.CODIGO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO", aliasTabla))))
    End Sub

    Public Sub AsignarPROVEEDOR(ByVal dr As IDataReader, ByRef e As PROVEEDOR, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New PROVEEDOR
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.CODIPROVEEDOR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIPROVEEDOR", aliasTabla))))
        e.CODIPROVEE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIPROVEE", aliasTabla))))
        e.CODISOCIO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODISOCIO", aliasTabla))))
        e.APELLIDOS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}APELLIDOS", aliasTabla))))
        e.NOMBRES = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRES", aliasTabla))))
        e.EDAD = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}EDAD", aliasTabla))))
        e.DIRECCION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DIRECCION", aliasTabla))))
        e.TELEFONO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TELEFONO", aliasTabla))))
        e.CELULAR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CELULAR", aliasTabla))))
        e.DUI = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DUI", aliasTabla))))
        e.NIT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NIT", aliasTabla))))
        e.CREDITFISCAL = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CREDITFISCAL", aliasTabla))))
        e.PROFESION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}PROFESION", aliasTabla))))
        e.NOMBRENIT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRENIT", aliasTabla))))
        e.APODERADO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}APODERADO", aliasTabla))))
        e.DUI_APODERADO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DUI_APODERADO", aliasTabla))))
        e.NIT_APODERADO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NIT_APODERADO", aliasTabla))))
        e.USER_CREA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}USER_CREA", aliasTabla)), -1))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USER_ACT = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}USER_ACT", aliasTabla)), -1))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.FECHA_NAC = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_NAC", aliasTabla))))
        e.TIPO_CONTRIBUYENTE = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}TIPO_CONTRIBUYENTE", aliasTabla)), -1))
        e.ACTIVIDAD = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ACTIVIDAD", aliasTabla))))
        e.CODIBANCO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}CODIBANCO", aliasTabla)), -1))
        e.NUM_CUENTA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NUM_CUENTA", aliasTabla))))
        e.ES_CTA_CORRIENTE = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}ES_CTA_CORRIENTE", aliasTabla))))
        e.CODI_DEPTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODI_DEPTO", aliasTabla))))
        e.CODI_MUNI = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODI_MUNI", aliasTabla))))
        e.CORREO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CORREO", aliasTabla))))
        e.ID_TIPO_PERSONA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_PERSONA", aliasTabla)), -1))
    End Sub


    Public Sub AsignarSUB_ZONAS(ByVal dr As IDataReader, ByRef e As SUB_ZONAS, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New SUB_ZONAS
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ZONA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ZONA", aliasTabla))))
        e.SUB_ZONA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}SUB_ZONA", aliasTabla))))
        e.DESCRIP_SUB_ZONA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DESCRIP_SUB_ZONA", aliasTabla))))
        e.NO_SUB_ZONA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}NO_SUB_ZONA", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub

    Public Sub AsignarPERFIL(ByVal dr As IDataReader, ByRef e As PERFIL, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New PERFIL
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_PERFIL = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PERFIL", aliasTabla))))
        e.NOMBRE_PERFIL = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_PERFIL", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub

    Public Sub AsignarOPCION_PERFIL(ByVal dr As IDataReader, ByRef e As OPCION_PERFIL, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New OPCION_PERFIL
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_OPCION_PERFIL = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_OPCION_PERFIL", aliasTabla))))
        e.ID_PERFIL = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PERFIL", aliasTabla))))
        e.ID_OPCION = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_OPCION", aliasTabla))))
        e.ACTIVO = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}ACTIVO", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub

    Public Sub AsignarOPCION(ByVal dr As IDataReader, ByRef e As OPCION, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New OPCION
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_OPCION = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_OPCION", aliasTabla))))
        e.NOMBRE_OPCION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_OPCION", aliasTabla))))
        e.ORDEN = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ORDEN", aliasTabla))))
        e.URL = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}URL", aliasTabla))))
        e.ACTIVO = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}ACTIVO", aliasTabla))))
        e.ID_OPCION_PADRE = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_OPCION_PADRE", aliasTabla)), -1))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub

    Public Sub AsignarMOTORISTA(ByVal dr As IDataReader, ByRef e As MOTORISTA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New MOTORISTA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_MOTORISTA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_MOTORISTA", aliasTabla))))
        e.NIT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NIT", aliasTabla))))
        e.NOMBRES = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRES", aliasTabla))))
        e.APELLIDOS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}APELLIDOS", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.DUI = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DUI", aliasTabla))))
        e.LICENCIA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}LICENCIA", aliasTabla))))
        e.ACTIVO = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}ACTIVO", aliasTabla))))
    End Sub

    Public Sub AsignarLOTES(ByVal dr As IDataReader, ByRef e As LOTES, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New LOTES
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ACCESLOTE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ACCESLOTE", aliasTabla))))
        e.ANIOZAFRA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ANIOZAFRA", aliasTabla))))
        e.CODIPROVEEDOR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIPROVEEDOR", aliasTabla))))
        e.CODILOTE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODILOTE", aliasTabla))))
        e.CODIAGRON = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIAGRON", aliasTabla))))
        e.CODIVARIEDA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIVARIEDA", aliasTabla))))
        e.CODIUBICACION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIUBICACION", aliasTabla))))
        e.CODICONTRATO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODICONTRATO", aliasTabla))))
        e.NOMBLOTE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBLOTE", aliasTabla))))
        e.AREA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}AREA", aliasTabla)), -1))
        e.TONELADAS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TONELADAS", aliasTabla)), -1))
        e.TONEL_TC = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TONEL_TC", aliasTabla)), -1))
        e.ZONA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ZONA", aliasTabla))))
        e.EDAD_LOTE = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}EDAD_LOTE", aliasTabla)), -1))
        e.USER_CREA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}USER_CREA", aliasTabla)), -1))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USER_ACT = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}USER_ACT", aliasTabla)), -1))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.ID_MAESTRO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_MAESTRO", aliasTabla)), -1))
        e.TIPO_DERECHO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}TIPO_DERECHO", aliasTabla)), -1))
        e.SUB_ZONA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}SUB_ZONA", aliasTabla))))
        e.ID_LOTE_TRASPASO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_LOTE_TRASPASO", aliasTabla)), -1))
        e.AREA_CANA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}AREA_CANA", aliasTabla)), -1))
        e.RIESGO_PIEDRA = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}RIESGO_PIEDRA", aliasTabla))))
        e.REPARA_ACCESO = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}REPARA_ACCESO", aliasTabla))))
        e.SIN_ACCESO_PROPIO = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}SIN_ACCESO_PROPIO", aliasTabla))))
    End Sub

    Public Sub AsignarTIPO_SUELO(ByVal dr As IDataReader, ByRef e As TIPO_SUELO, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New TIPO_SUELO
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.COD_TIPO_SUELO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}COD_TIPO_SUELO", aliasTabla))))
        e.NOMBRE_TIPO_SUELO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_TIPO_SUELO", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub

    Public Sub AsignarMUNICIPIO(ByVal dr As IDataReader, ByRef e As MUNICIPIO, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New MUNICIPIO
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.CODI_DEPTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODI_DEPTO", aliasTabla))))
        e.CODI_MUNI = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODI_MUNI", aliasTabla))))
        e.NOMBRE_MUNI = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_MUNI", aliasTabla))))
        e.POSICION_GEO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}POSICION_GEO", aliasTabla))))
        e.COORDENADAS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}COORDENADAS", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub

    Public Sub AsignarCANTON(ByVal dr As IDataReader, ByRef e As CANTON, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New CANTON
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.CODI_CANTON = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODI_CANTON", aliasTabla))))
        e.CODI_DEPTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODI_DEPTO", aliasTabla))))
        e.CODI_MUNI = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODI_MUNI", aliasTabla))))
        e.NOMBRE_CANTON = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_CANTON", aliasTabla))))
        e.KILOMETROS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}KILOMETROS", aliasTabla))))
        e.POSICION_GEO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}POSICION_GEO", aliasTabla))))
        e.COORDENADAS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}COORDENADAS", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.ZONA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ZONA", aliasTabla))))
        e.SUB_ZONA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}SUB_ZONA", aliasTabla))))
    End Sub

    Public Sub AsignarCOMPORTAMIENTO_CANA(ByVal dr As IDataReader, ByRef e As COMPORTAMIENTO_CANA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New COMPORTAMIENTO_CANA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_COMPOR = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_COMPOR", aliasTabla))))
        e.NOMBRE_COMPOR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_COMPOR", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub

    Public Sub AsignarCONDICION_SIEMBRA(ByVal dr As IDataReader, ByRef e As CONDICION_SIEMBRA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New CONDICION_SIEMBRA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_COND_SIEMBRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_COND_SIEMBRA", aliasTabla))))
        e.NOMBRE_COND = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_COND", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub

    Public Sub AsignarDEPARTAMENTO(ByVal dr As IDataReader, ByRef e As DEPARTAMENTO, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New DEPARTAMENTO
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.CODI_DEPTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODI_DEPTO", aliasTabla))))
        e.NOMBRE_DEPTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_DEPTO", aliasTabla))))
        e.COORDENADAS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}COORDENADAS", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub

    Public Sub AsignarNIVEL_HUMEDAD(ByVal dr As IDataReader, ByRef e As NIVEL_HUMEDAD, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New NIVEL_HUMEDAD
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_NIVEL_HUMEDAD = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_NIVEL_HUMEDAD", aliasTabla))))
        e.NOMBRE_NIVEL_HUMEDAD = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_NIVEL_HUMEDAD", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub


    Public Sub AsignarMAESTRO_LOTES(ByVal dr As IDataReader, ByRef e As MAESTRO_LOTES, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New MAESTRO_LOTES
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_MAESTRO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_MAESTRO", aliasTabla))))
        e.CUI = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CUI", aliasTabla))))
        e.CODI_DEPTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODI_DEPTO", aliasTabla))))
        e.CODI_MUNI = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODI_MUNI", aliasTabla))))
        e.CODI_CANTON = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODI_CANTON", aliasTabla))))
        e.ZONA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ZONA", aliasTabla))))
        e.SUB_ZONA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}SUB_ZONA", aliasTabla))))
        e.CORRELATIVO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CORRELATIVO", aliasTabla))))
        e.CODIPROVEEDOR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIPROVEEDOR", aliasTabla))))
        e.NOMBRE_COMER = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_COMER", aliasTabla))))
        e.CODILOTE_COMER = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODILOTE_COMER", aliasTabla))))
        e.MZ_CULTIVADA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MZ_CULTIVADA", aliasTabla))))
        e.CODIVARIEDA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIVARIEDA", aliasTabla))))
        e.ID_COMPOR = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_COMPOR", aliasTabla)), -1))
        e.COD_TIPO_SUELO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}COD_TIPO_SUELO", aliasTabla))))
        e.ID_COND_SIEMBRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_COND_SIEMBRA", aliasTabla)), -1))
        e.ID_NIVEL_HUMEDAD = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_NIVEL_HUMEDAD", aliasTabla)), -1))
        e.NO_CORTE = Convert.ToInt16(ObtenerValor(dr.Item(String.Format("{0}NO_CORTE", aliasTabla))))
        e.MSNM = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MSNM", aliasTabla)), -1))
        e.KM_CARRETERA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}KM_CARRETERA", aliasTabla))))
        e.KM_TIERRA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}KM_TIERRA", aliasTabla))))
        e.RIESGO_PIEDRA = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}RIESGO_PIEDRA", aliasTabla))))
        e.FECHA_SIEMBRA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_SIEMBRA", aliasTabla))))
        e.FECHA_CORTE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CORTE", aliasTabla))))
        e.PROD_TC = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PROD_TC", aliasTabla)), -1))
        e.PROD_LB = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PROD_LB", aliasTabla)), -1))
        e.FACTOR_DESPOBLA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}FACTOR_DESPOBLA", aliasTabla)), -1))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.CODICONTRATO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}CODICONTRATO", aliasTabla)), -1))
        e.TIPO_DERECHO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}TIPO_DERECHO", aliasTabla))))
        e.ID_TIPO_CANA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_CANA", aliasTabla)), -1))
        e.ID_TIPO_ROZA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_ROZA", aliasTabla)), -1))
        e.ID_TIPO_ALZA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_ALZA", aliasTabla)), -1))
        e.ID_TIPO_TRANS = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_TRANS", aliasTabla)), -1))
        e.CODIAGRON = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIAGRON", aliasTabla))))
        e.TARIFA_ROZA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TARIFA_ROZA", aliasTabla)), -1))
        e.TARIFA_ALZA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TARIFA_ALZA", aliasTabla)), -1))
        e.TARIFA_TRANS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TARIFA_TRANS", aliasTabla)), -1))
        e.TARIFA_CORTA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TARIFA_CORTA", aliasTabla)), -1))
        e.TARIFA_LARGA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TARIFA_LARGA", aliasTabla)), -1))
        e.TARIFA_LARGA_T3S3 = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TARIFA_LARGA_T3S3", aliasTabla)), -1))
        e.REPARA_ACCESO = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}REPARA_ACCESO", aliasTabla))))
        e.SIN_ACCESO_PROPIO = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}SIN_ACCESO_PROPIO", aliasTabla))))
        e.HACIENDA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}HACIENDA", aliasTabla))))
        e.ESTADO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ESTADO", aliasTabla))))
        e.ID_SUBLOTES = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_SUBLOTES", aliasTabla)), -1))
    End Sub


    Public Sub AsignarENVIO(ByVal dr As IDataReader, ByRef e As ENVIO, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New ENVIO
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_ENVIO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ENVIO", aliasTabla))))
        e.ID_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA", aliasTabla))))
        e.DIAZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}DIAZAFRA", aliasTabla))))
        e.CATORCENA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}CATORCENA", aliasTabla))))
        e.CODICONTRATO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODICONTRATO", aliasTabla))))
        e.CODIPROVEEDOR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIPROVEEDOR", aliasTabla))))
        e.COMPTENVIO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}COMPTENVIO", aliasTabla))))
        e.ACCESLOTE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ACCESLOTE", aliasTabla))))
        e.CODTRANSPORT = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}CODTRANSPORT", aliasTabla))))
        e.NOMBRES_MOTORISTA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRES_MOTORISTA", aliasTabla))))
        e.ID_TIPO_CANA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_CANA", aliasTabla))))
        e.ID_CARGADORA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CARGADORA", aliasTabla))))
        e.ID_SUPERVISOR = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_SUPERVISOR", aliasTabla))))
        e.FECHA_QUEMA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_QUEMA", aliasTabla))))
        e.FECHA_CORTA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CORTA", aliasTabla))))
        e.QUEMAPROG = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}QUEMAPROG", aliasTabla))))
        e.FECHA_CARGA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CARGA", aliasTabla))))
        e.FECHA_PATIO = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_PATIO", aliasTabla))))
        e.NROBOLETA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}NROBOLETA", aliasTabla))))
        e.MADURANTE = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}MADURANTE", aliasTabla))))
        e.CERRADO = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}CERRADO", aliasTabla))))
        e.FECHA_ENTRADA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ENTRADA", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.PLACAVEHIC = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}PLACAVEHIC", aliasTabla))))
        e.ID_TIPOTRANS = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPOTRANS", aliasTabla)), -1))
        e.SERVICIO_ROZA = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}SERVICIO_ROZA", aliasTabla))))
        e.TRANSPORTE_PROPIO = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}TRANSPORTE_PROPIO", aliasTabla))))
        e.ID_PROVEEDOR_ROZA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PROVEEDOR_ROZA", aliasTabla)), -1))
        e.ID_CARGADOR = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CARGADOR", aliasTabla)), -1))
        e.NUMRECIBO_CANA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}NUMRECIBO_CANA", aliasTabla)), -1))
        e.TIPO_TARIFA_CARGADORA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}TIPO_TARIFA_CARGADORA", aliasTabla)), -1))
        e.ID_MOTORISTA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_MOTORISTA", aliasTabla)), -1))
        e.HORAS_QUEMA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}HORAS_QUEMA", aliasTabla)), -1))
        e.ANULADO = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}ANULADO", aliasTabla))))
        e.USUARIO_ANULACION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ANULACION", aliasTabla))))
        e.FECHA_ANULACION = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ANULACION", aliasTabla))))
        e.ID_TIPO_ROZA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_ROZA", aliasTabla)), -1))
        e.ID_TIPO_ALZA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_ALZA", aliasTabla)), -1))
        e.ES_QUERQUEO = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}ES_QUERQUEO", aliasTabla))))
        e.ES_BARRIDO = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}ES_BARRIDO", aliasTabla))))
        e.ES_PRIMERENVIO_TURNO = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}ES_PRIMERENVIO_TURNO", aliasTabla))))
        e.ES_ULTENVIO_TURNO = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}ES_ULTENVIO_TURNO", aliasTabla))))
        e.ID_SUBLOTES = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_SUBLOTES", aliasTabla)), -1))
    End Sub

    Public Sub AsignarAGRONOMO(ByVal dr As IDataReader, ByRef e As AGRONOMO, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New AGRONOMO
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.CODIAGRON = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIAGRON", aliasTabla))))
        e.APELLIDO_AGRONOMO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}APELLIDO_AGRONOMO", aliasTabla))))
        e.NOMBRE_AGRONOMO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_AGRONOMO", aliasTabla))))
        e.TELEF_AGRONOMO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TELEF_AGRONOMO", aliasTabla))))
        e.ZONA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ZONA", aliasTabla))))
        e.ESTADO_AGRONOMO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ESTADO_AGRONOMO", aliasTabla)), -1))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.USUARIO_SIGESTA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_SIGESTA", aliasTabla))))
        e.VER_CONTRATO = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}VER_CONTRATO", aliasTabla))))
    End Sub

    Public Sub AsignarDIA_ZAFRA(ByVal dr As IDataReader, ByRef e As DIA_ZAFRA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New DIA_ZAFRA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_DIA_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_DIA_ZAFRA", aliasTabla))))
        e.ID_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA", aliasTabla))))
        e.DIAZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}DIAZAFRA", aliasTabla))))
        e.FECHA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA", aliasTabla))))
        e.AZUCAR_PRODUCIDA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}AZUCAR_PRODUCIDA", aliasTabla)), -1))
        e.AZUCAR_CALC1 = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}AZUCAR_CALC1", aliasTabla))))
        e.EFICIENCIA_REAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}EFICIENCIA_REAL", aliasTabla)), -1))
        e.USUARIO_CIERRE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CIERRE", aliasTabla))))
        e.FECHA_CIERRE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CIERRE", aliasTabla))))
        e.HORA_CIERRE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}HORA_CIERRE", aliasTabla))))
    End Sub

    Public Sub AsignarCONTRATO_ZAFRAS(ByVal dr As IDataReader, ByRef e As CONTRATO_ZAFRAS, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New CONTRATO_ZAFRAS
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_CONTRATO_ZAFRAS = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CONTRATO_ZAFRAS", aliasTabla))))
        e.CODICONTRATO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODICONTRATO", aliasTabla))))
        e.ID_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub

    Public Sub AsignarCONTRATO(ByVal dr As IDataReader, ByRef e As CONTRATO, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New CONTRATO
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.CODICONTRATO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODICONTRATO", aliasTabla))))
        e.ANIOZAFRA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ANIOZAFRA", aliasTabla))))
        e.CODIPROVEEDOR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIPROVEEDOR", aliasTabla))))
        e.FECHA_CONTRATOCB = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CONTRATOCB", aliasTabla))))
        e.ESTADO_CONTRATOCB = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ESTADO_CONTRATOCB", aliasTabla)), -1))
        e.FINANCOADO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}FINANCOADO", aliasTabla))))
        e.FINAN_NUMERO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}FINAN_NUMERO", aliasTabla))))
        e.TOTALMZ_CONTRATOCB = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TOTALMZ_CONTRATOCB", aliasTabla)), -1))
        e.TONELADAS_CONTRATOCB = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TONELADAS_CONTRATOCB", aliasTabla)), -1))
        e.OBSERVACIONES_CONTRATOCB = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}OBSERVACIONES_CONTRATOCB", aliasTabla))))
        e.USER_CREA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}USER_CREA", aliasTabla)), -1))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USER_ACT = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}USER_ACT", aliasTabla)), -1))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.NO_REGISTRO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NO_REGISTRO", aliasTabla))))
        e.FECHA_REGISTRO = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_REGISTRO", aliasTabla))))
        e.APELLIDOS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}APELLIDOS", aliasTabla))))
        e.NOMBRES = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRES", aliasTabla))))
        e.DIRECCION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DIRECCION", aliasTabla))))
        e.TELEFONO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TELEFONO", aliasTabla))))
        e.CELULAR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CELULAR", aliasTabla))))
        e.DUI = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DUI", aliasTabla))))
        e.NIT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NIT", aliasTabla))))
        e.CREDITFISCAL = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CREDITFISCAL", aliasTabla))))
        e.APODERADO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}APODERADO", aliasTabla))))
        e.DUI_APODERADO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DUI_APODERADO", aliasTabla))))
        e.NIT_APODERADO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NIT_APODERADO", aliasTabla))))
        e.ID_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA", aliasTabla)), -1))
        e.NO_CONTRATO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}NO_CONTRATO", aliasTabla)), -1))
        e.TIPO_CONTRATO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}TIPO_CONTRATO", aliasTabla)), -1))
        e.FECHA_CONTRA_LEGAL = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CONTRA_LEGAL", aliasTabla))))
        e.EDAD = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}EDAD", aliasTabla)), -1))
    End Sub

    Public Sub AsignarCATORCENA_ZAFRA(ByVal dr As IDataReader, ByRef e As CATORCENA_ZAFRA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New CATORCENA_ZAFRA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_CATORCENA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CATORCENA", aliasTabla))))
        e.ID_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA", aliasTabla))))
        e.CATORCENA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}CATORCENA", aliasTabla))))
        e.AZUCAR_PRODUCIDA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}AZUCAR_PRODUCIDA", aliasTabla))))
        e.AZUCAR_CALC1 = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}AZUCAR_CALC1", aliasTabla))))
        e.EFICIENCIA_REAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}EFICIENCIA_REAL", aliasTabla))))
        e.FECHA_INICIO = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_INICIO", aliasTabla))))
        e.FECHA_FIN = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_FIN", aliasTabla))))
        e.USUARIO_CIERRE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CIERRE", aliasTabla))))
        e.FECHA_CIERRE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CIERRE", aliasTabla))))
        e.RENDIMIENTO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}RENDIMIENTO", aliasTabla)), -1))
        e.TONELADA_PRODUCIDA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TONELADA_PRODUCIDA", aliasTabla)), -1))
        e.POL_CANA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}POL_CANA", aliasTabla)), -1))
        e.FECHA_PAGO = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_PAGO", aliasTabla))))
    End Sub

    Public Sub AsignarLOTE_CARGADORA(ByVal dr As IDataReader, ByRef e As LOTE_CARGADORA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New LOTE_CARGADORA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_ZONA_CARGA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZONA_CARGA", aliasTabla))))
        e.FECHA_ASIGNACION = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ASIGNACION", aliasTabla))))
        e.ACCESLOTE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ACCESLOTE", aliasTabla))))
        e.ID_CARGADORA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CARGADORA", aliasTabla)), -1))
        e.ID_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA", aliasTabla)), -1))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub

    Public Sub AsignarZONA_CARGADORA(ByVal dr As IDataReader, ByRef e As ZONA_CARGADORA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New ZONA_CARGADORA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_ZONA_CARGA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZONA_CARGA", aliasTabla))))
        e.ZONA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ZONA", aliasTabla))))
        e.ID_CARGADORA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CARGADORA", aliasTabla)), -1))
        e.ID_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA", aliasTabla)), -1))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub

    Public Sub AsignarCARGADORA_ASIGNADA(ByVal dr As IDataReader, ByRef e As CARGADORA_ASIGNADA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New CARGADORA_ASIGNADA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_CARGADORA_ASIG = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CARGADORA_ASIG", aliasTabla))))
        e.ID_CARGADORA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CARGADORA", aliasTabla))))
        e.ID_CARGADOR = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CARGADOR", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.ID_ZAFRA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ZAFRA", aliasTabla)), -1))
    End Sub

    Public Sub AsignarCARGADOR(ByVal dr As IDataReader, ByRef e As CARGADOR, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New CARGADOR
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_CARGADOR = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CARGADOR", aliasTabla))))
        e.NOMBRE_CARGADOR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_CARGADOR", aliasTabla))))
        e.DUI = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DUI", aliasTabla))))
        e.NIT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NIT", aliasTabla))))
        e.DIRECCION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DIRECCION", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.CODIGO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO", aliasTabla))))
        e.ES_EMPLEADO_INGENIO = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}ES_EMPLEADO_INGENIO", aliasTabla))))
    End Sub


    Public Sub AsignarCARGADORA(ByVal dr As IDataReader, ByRef e As CARGADORA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New CARGADORA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_CARGADORA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_CARGADORA", aliasTabla))))
        e.NOMBRE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.ES_PROPIA = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}ES_PROPIA", aliasTabla))))
        e.ID_PROVEEDOR_CARGA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PROVEEDOR_CARGA", aliasTabla)), -1))
        e.ID_TIPO_CARGADORA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_CARGADORA", aliasTabla)), -1))
        e.TARIFA_SIN_TRIPULACION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TARIFA_SIN_TRIPULACION", aliasTabla)), -1))
        e.TARIFA_CON_TRIPULACION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TARIFA_CON_TRIPULACION", aliasTabla)), -1))
        e.TARIFA_NORMAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TARIFA_NORMAL", aliasTabla)), -1))
        e.ID_TIPO_ALZA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_ALZA", aliasTabla))))
        e.PRECALIFI_AUTO = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}PRECALIFI_AUTO", aliasTabla))))
        e.ACTIVO = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}ACTIVO", aliasTabla))))
        e.TARIFA_PAGAR_CARGADORA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TARIFA_PAGAR_CARGADORA", aliasTabla)), -1))
    End Sub

    Public Sub AsignarBITACORA_USUARIO(ByVal dr As IDataReader, ByRef e As BITACORA_USUARIO, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New BITACORA_USUARIO
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_BITACORA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_BITACORA", aliasTabla))))
        e.USUARIO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO", aliasTabla))))
        e.FECHA_ENTRADA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ENTRADA", aliasTabla))))
        e.FECHA_SALIDA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_SALIDA", aliasTabla))))
    End Sub

    Public Sub AsignarBASCULA(ByVal dr As IDataReader, ByRef e As BASCULA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New BASCULA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_BASCULA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_BASCULA", aliasTabla))))
        e.ID_ENVIO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ENVIO", aliasTabla))))
        e.BRUTO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}BRUTO", aliasTabla)), -1))
        e.TARA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TARA", aliasTabla)), -1))
        e.NETOLIBRAS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}NETOLIBRAS", aliasTabla)), -1))
        e.NETOTONEL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}NETOTONEL", aliasTabla)), -1))
        e.USUARIO_LEE_BRUTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_LEE_BRUTO", aliasTabla))))
        e.FECHA_LEE_BRUTO = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_LEE_BRUTO", aliasTabla))))
        e.USUARIO_LEE_TARA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_LEE_TARA", aliasTabla))))
        e.FECHA_LEE_TARA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_LEE_TARA", aliasTabla))))
    End Sub

    Public Sub AsignarANALISIS(ByVal dr As IDataReader, ByRef e As ANALISIS, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New ANALISIS
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_ANALISIS = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ANALISIS", aliasTabla))))
        e.ID_ENVIO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_ENVIO", aliasTabla))))
        e.BAGAZO_BRUTO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}BAGAZO_BRUTO", aliasTabla)), -1))
        e.BAGAZO_NETO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}BAGAZO_NETO", aliasTabla)), -1))
        e.POL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}POL", aliasTabla)), -1))
        e.BRIX = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}BRIX", aliasTabla)), -1))
        e.FIBRA_CANA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}FIBRA_CANA", aliasTabla)), -1))
        e.HUMEDAD = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}HUMEDAD", aliasTabla)), -1))
        e.POL_JUGO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}POL_JUGO", aliasTabla)), -1))
        e.JUGO_CANA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}JUGO_CANA", aliasTabla)), -1))
        e.POL_CANA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}POL_CANA", aliasTabla)), -1))
        e.PUREZA_JUGO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PUREZA_JUGO", aliasTabla)), -1))
        e.PUREZA_AZUCAR = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PUREZA_AZUCAR", aliasTabla)), -1))
        e.SJM = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}SJM", aliasTabla)), -1))
        e.RENDIA_CALC1 = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}RENDIA_CALC1", aliasTabla)), -1))
        e.RENDIA_CALC2 = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}RENDIA_CALC2", aliasTabla)), -1))
        e.RENDIA_REAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}RENDIA_REAL", aliasTabla)), -1))
        e.RENCATORCENA_REAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}RENCATORCENA_REAL", aliasTabla)), -1))
        e.AZUCAR_CALC1 = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}AZUCAR_CALC1", aliasTabla)), -1))
        e.AZUCAR_CALC2 = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}AZUCAR_CALC2", aliasTabla)), -1))
        e.AZUCAR_REAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}AZUCAR_REAL", aliasTabla)), -1))
        e.AZUCAR_CATORCENA_REAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}AZUCAR_CATORCENA_REAL", aliasTabla)), -1))
        e.PAGO_INI_CALC = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PAGO_INI_CALC", aliasTabla)), -1))
        e.PAGO_INI_REAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PAGO_INI_REAL", aliasTabla)), -1))
        e.PAGO_CATORCENA_REAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PAGO_CATORCENA_REAL", aliasTabla)), -1))
        e.USUARIO_LEE_BAGAZO_BRUTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_LEE_BAGAZO_BRUTO", aliasTabla))))
        e.FECHA_LEE_BAGAZO_BRUTO = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_LEE_BAGAZO_BRUTO", aliasTabla))))
        e.USUARIO_LEE_BAGAZO_TARA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_LEE_BAGAZO_TARA", aliasTabla))))
        e.FECHA_LEE_BAGAZO_TARA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_LEE_BAGAZO_TARA", aliasTabla))))
        e.USUARIO_LEE_POL = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_LEE_POL", aliasTabla))))
        e.FECHA_LEE_POL = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_LEE_POL", aliasTabla))))
        e.USUARIO_LEE_BRIX = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_LEE_BRIX", aliasTabla))))
        e.FECHA_LEE_BRIX = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_LEE_BRIX", aliasTabla))))
        e.POL_LECTURA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}POL_LECTURA", aliasTabla)), -1))
        e.PH = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PH", aliasTabla)), -1))
        e.AZUCAR_REDUCTORES = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}AZUCAR_REDUCTORES", aliasTabla)), -1))
        e.ES_ANOMALO = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}ES_ANOMALO", aliasTabla))))
        e.RENDIA85_ANOMALO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}RENDIA85_ANOMALO", aliasTabla)), -1))
        e.APLICAR_REND_DIA = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}APLICAR_REND_DIA", aliasTabla))))
    End Sub


    Public Function ObtenerValor(ByVal valor As Object) As Object
        If valor Is DBNull.Value Then
            Return Nothing
        Else
            If TypeOf valor Is String Then valor = Strings.Trim(valor)
            Return valor
        End If
    End Function

    Public Function ObtenerValor(ByVal valor As Object, ByVal valorDefault As Integer) As Object
        If valor Is DBNull.Value Then
            Return valorDefault
        Else
            If TypeOf valor Is String Then valor = Strings.Trim(valor)
            Return valor
        End If
    End Function

    Public Function ObtenerValor(ByVal valor As Object, ByVal valorDefault As String) As Object
        If valor Is DBNull.Value Then
            Return Nothing
        Else
            If TypeOf valor Is String Then valor = Strings.Trim(valor)
            Return valor
        End If
    End Function











    ' **************************************** REQUISICION *****************************************


    Public Sub AsignarPERIODOREQ(ByVal dr As IDataReader, ByRef e As PERIODOREQ, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New PERIODOREQ
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_PERIODOREQ = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PERIODOREQ", aliasTabla))))
        e.DESCRIP_PERIODO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DESCRIP_PERIODO", aliasTabla))))
        e.ACTIVO = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}ACTIVO", aliasTabla))))
        e.USUARIO_CREACION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREACION", aliasTabla))))
        e.FECHA_CREACION = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREACION", aliasTabla))))
        e.USUARIO_CIERRE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CIERRE", aliasTabla))))
        e.FECHA_CIERRE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CIERRE", aliasTabla))))
        e.FECHA_INICIO = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_INICIO", aliasTabla))))
        e.FECHA_FIN = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_FIN", aliasTabla))))
        e.CODIGO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO", aliasTabla))))
    End Sub

    Public Sub AsignarREQENCA(ByVal dr As IDataReader, ByRef e As REQENCA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New REQENCA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_REQENCA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_REQENCA", aliasTabla))))
        e.ID_PERIODOREQ = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_PERIODOREQ", aliasTabla))))
        e.ID_SECCION = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_SECCION", aliasTabla))))
        e.ID_SOLICITANTE = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_SOLICITANTE", aliasTabla))))
        e.NO_REQ = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}NO_REQ", aliasTabla))))
        e.FECHA_EMISION = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_EMISION", aliasTabla))))
        e.NO_REQ_PH = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NO_REQ_PH", aliasTabla))))
        e.FECHA_REQ_PH = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_REQ_PH", aliasTabla))))
        e.NO_ORDEN_PH = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NO_ORDEN_PH", aliasTabla))))
        e.FECHA_ORDEN_PH = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ORDEN_PH", aliasTabla))))
        e.TOTAL_ORDEN_PH = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TOTAL_ORDEN_PH", aliasTabla)), -1))
        e.AFECTO_ORDEN_PH = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}AFECTO_ORDEN_PH", aliasTabla)), -1))
        e.IVA_ORDEN_PH = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}IVA_ORDEN_PH", aliasTabla)), -1))
        e.NO_INGRESO_ALM = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NO_INGRESO_ALM", aliasTabla))))
        e.FECHA_INGRESO_ALM = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_INGRESO_ALM", aliasTabla))))
        e.NO_QUEDAN = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NO_QUEDAN", aliasTabla))))
        e.FECHA_QUEDAN = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_QUEDAN", aliasTabla))))
        e.USO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USO", aliasTabla))))
        e.USUARIO_APROB = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_APROB", aliasTabla))))
        e.FECHA_APROB = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_APROB", aliasTabla))))
        e.USUARIO_NOAPROB = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_NOAPROB", aliasTabla))))
        e.FECHA_NOAPROB = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_NOAPROB", aliasTabla))))
        e.USUARIO_ANUL = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ANUL", aliasTabla))))
        e.FECHA_ANUL = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ANUL", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.CODI_REQ = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODI_REQ", aliasTabla))))
        e.ORDEN_LOCAL = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}ORDEN_LOCAL", aliasTabla))))
        e.FECHA_INGRESO_EST = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_INGRESO_EST", aliasTabla))))
        e.COMENTARIO_EST = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}COMENTARIO_EST", aliasTabla))))
        e.TOTAL_INGRESO_ALM = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TOTAL_INGRESO_ALM", aliasTabla)), -1))
        e.AFECTO_INGRESO_ALM = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}AFECTO_INGRESO_ALM", aliasTabla)), -1))
        e.IVA_INGRESO_ALM = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}IVA_INGRESO_ALM", aliasTabla)), -1))
        e.TOTAL_QUEDAN = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TOTAL_QUEDAN", aliasTabla)), -1))
        e.AFECTO_QUEDAN = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}AFECTO_QUEDAN", aliasTabla)), -1))
        e.IVA_QUEDAN = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}IVA_QUEDAN", aliasTabla)), -1))
        e.SECCION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}SECCION", aliasTabla))))
        e.EQUIPO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}EQUIPO", aliasTabla))))
        e.PROPOSITO = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}PROPOSITO", aliasTabla)), -1))
        e.COMPRA_LOCAL = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}COMPRA_LOCAL", aliasTabla))))
        e.FECHA_MAX_SUMIN = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_MAX_SUMIN", aliasTabla))))
        e.FECHA_RECIBOREQ = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_RECIBOREQ", aliasTabla))))
        e.PROVEE_INVITADOS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}PROVEE_INVITADOS", aliasTabla))))
        e.PROVEE_ADJUDICADO_ORDEN = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}PROVEE_ADJUDICADO_ORDEN", aliasTabla))))
        e.FECHA_ESTI_INGRESO_ORDEN = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ESTI_INGRESO_ORDEN", aliasTabla))))
        e.TIPO_DOCCOMPRA_ALM = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}TIPO_DOCCOMPRA_ALM", aliasTabla)), -1))
        e.NO_DOCCOMPRA_ALM = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NO_DOCCOMPRA_ALM", aliasTabla))))
        e.NO_CHEQUE_CHQ = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NO_CHEQUE_CHQ", aliasTabla))))
        e.BANCO_CHQ = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}BANCO_CHQ", aliasTabla))))
        e.FECHA_CHQ = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CHQ", aliasTabla))))
        e.MONTO_CHQ = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MONTO_CHQ", aliasTabla)), -1))
        e.ID_REQETAPA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_REQETAPA", aliasTabla)), -1))
    End Sub



    Public Sub AsignarREQETAPA(ByVal dr As IDataReader, ByRef e As REQETAPA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New REQETAPA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_REQETAPA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_REQETAPA", aliasTabla))))
        e.NOM_REQETAPA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOM_REQETAPA", aliasTabla))))
    End Sub

    Public Sub AsignarREQDETA(ByVal dr As IDataReader, ByRef e As REQDETA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New REQDETA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_REQDETA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_REQDETA", aliasTabla))))
        e.ID_REQENCA = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_REQENCA", aliasTabla)), -1))
        e.CODIGO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO", aliasTabla))))
        e.CANTIDAD = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CANTIDAD", aliasTabla))))
        e.UNIDAD = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}UNIDAD", aliasTabla))))
        e.DESCRIPCION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DESCRIPCION", aliasTabla))))
        e.OBSERVACION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}OBSERVACION", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub

    Public Sub AsignarSOLICITANTE(ByVal dr As IDataReader, ByRef e As SOLICITANTE, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New SOLICITANTE
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_SOLICITANTE = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_SOLICITANTE", aliasTabla))))
        e.CODIGO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO", aliasTabla))))
        e.NOMBRE_SOLICITANTE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_SOLICITANTE", aliasTabla))))
    End Sub

    Public Sub AsignarSECCION(ByVal dr As IDataReader, ByRef e As SECCION, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New SECCION
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_SECCION = Convert.ToInt32(ObtenerValor(dr.Item(String.Format("{0}ID_SECCION", aliasTabla))))
        e.CODIGO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO", aliasTabla))))
        e.NOMBRE_SECCION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_SECCION", aliasTabla))))
        e.VER_REQUISICION = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}VER_REQUISICION", aliasTabla))))
        e.VER_ORDEN_COMB = Convert.ToBoolean(ObtenerValor(dr.Item(String.Format("{0}VER_ORDEN_COMB", aliasTabla))))
    End Sub
End Module
