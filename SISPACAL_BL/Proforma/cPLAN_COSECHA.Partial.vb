Partial Public Class cPLAN_COSECHA

    Public Function EsEntregaProgramada(ByVal ID_ZAFRA As Integer, ByVal ACCESSLOTE As String, ByVal FECHA As Date) As Boolean
        Try
            'Dim lLoteCosecha As LOTES_COSECHA = (New cLOTES_COSECHA).ObtenerLOTES_COSECHAPorLOTE_ZAFRA(ACCESSLOTE, ID_ZAFRA)
            'Dim programado As Boolean = False
            'If lLoteCosecha IsNot Nothing Then
            '    If lLoteCosecha.FECHA_ROZA <= FECHA Then
            '        programado = True
            '    End If
            'End If
            'Return programado

            Return mDb.EsEntregaProgramada(ID_ZAFRA, ACCESSLOTE, FECHA)
            'Return True

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return False
        End Try
    End Function

    Public Function ObtenerUltimaCatorcenaPropuesta(ByVal ID_ZAFRA As Int32) As Int32
        Try
            Return mDb.ObtenerUltimaCatorcenaPropuesta(ID_ZAFRA)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return False
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCriterios(ByVal ID_ZAFRA As Int32, _
                                             ByVal ZONA As String, _
                                             ByVal SUB_ZONA As String, _
                                             ByVal CATORCENA As Int32, _
                                             ByVal SEMANA As Int32, _
                                             ByVal FECHA_INI As DateTime, _
                                             ByVal FECHA_FIN As DateTime, _
                                             ByVal CODIPROVEE As String, _
                                             ByVal CODISOCIO As String, _
                                             ByVal NOMBRE_PROVEEDOR As String, _
                                             ByVal NO_CONTRATO As Int32, _
                                             ByVal CODIAGRON As String, _
                                             ByVal TIPOS_TRANSPORTE As String, _
                                             ByVal CON_SALDO_ROZA As Boolean, _
                                             ByVal FIN_LOTE As Int32, _
                                             Optional CON_CUOTA_DIARIA As Boolean = False) As listaPLAN_COSECHA
        Try
            Return mDb.ObtenerListaPorCriterios(ID_ZAFRA, ZONA, SUB_ZONA, CATORCENA, SEMANA, FECHA_INI, FECHA_FIN, CODIPROVEE, CODISOCIO, NOMBRE_PROVEEDOR, NO_CONTRATO, CODIAGRON, TIPOS_TRANSPORTE, CON_SALDO_ROZA, FIN_LOTE, CON_CUOTA_DIARIA)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaParaProforma(ByVal ID_ZAFRA As Int32, _
                                             ByVal ZONA As String, _
                                             ByVal SUB_ZONA As String, _
                                             ByVal CATORCENA As Int32, _
                                             ByVal SEMANA As Int32, _
                                             ByVal FECHA_INI As DateTime, _
                                             ByVal FECHA_FIN As DateTime, _
                                             ByVal CODIPROVEE As String, _
                                             ByVal CODISOCIO As String, _
                                             ByVal NOMBRE_PROVEEDOR As String, _
                                             ByVal NO_CONTRATO As Int32, _
                                             ByVal CODIAGRON As String, _
                                             ByVal TIPOS_TRANSPORTE As String, _
                                             ByVal CON_SALDO_ROZA As Boolean, _
                                             ByVal FIN_LOTE As Int32, _
                                             ByVal FECHA_PROFORMA As DateTime) As listaPLAN_COSECHA
        Try
            Return mDb.ObtenerListaParaProforma(ID_ZAFRA, ZONA, SUB_ZONA, CATORCENA, SEMANA, FECHA_INI, FECHA_FIN, CODIPROVEE, CODISOCIO, NOMBRE_PROVEEDOR, NO_CONTRATO, CODIAGRON, TIPOS_TRANSPORTE, CON_SALDO_ROZA, FIN_LOTE, FECHA_PROFORMA)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function GenerarPropuestaCosechaCatorcenal(ByVal ID_ZAFRA As Int32, ByVal CATORCENA As Int32, _
                                                      ByVal SEMANA As Int32, _
                                                      ByVal USUARIO_CREA As String, FECHA_CREA As DateTime) As Int32
        Try
            Return mDb.GenerarPropuestaCosechaCatorcenal(ID_ZAFRA, CATORCENA, SEMANA, USUARIO_CREA, FECHA_CREA)
        Catch ex As Exception
            Me.sError = ex.Message
            ExceptionManager.Publish(ex)
            Return -1
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
    ''' 	[GenApp]	29/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarPLAN_COSECHA(ByVal aEntidad As PLAN_COSECHA) As Integer
        Try
            Return Me.ActualizarPLAN_COSECHA(aEntidad, TipoConcurrencia.Pesimistica)
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
    ''' 	[GenApp]	29/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarPLAN_COSECHA(ByVal aEntidad As PLAN_COSECHA, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Dim bNuevo As Boolean = (aEntidad.ID_PLAN_COSECHA = 0)
            Dim lCicloPeriodo As CICLO_PERIODO
            Dim lRet As Int32 = 0

            lCicloPeriodo = (New cCICLO_PERIODO).ObtenerCICLO_PERIODOPorFechaTipo(aEntidad.FECHA_INI_COSECHA, 2)
            If lCicloPeriodo IsNot Nothing Then
                aEntidad.CATORCENA = lCicloPeriodo.CATORCENA
                aEntidad.SEMANA = lCicloPeriodo.SEMANA
            End If

            lRet = mDb.Actualizar(aEntidad, aTipoConcurrencia)

            If lRet > 0 AndAlso Not bNuevo Then
                'Actualizar lotes cosecha
                Dim bLoteCosecha As New cLOTES_COSECHA
                Dim lLoteCosecha As LOTES_COSECHA

                lLoteCosecha = bLoteCosecha.ObtenerLOTES_COSECHAPorLOTE_ZAFRA(aEntidad.ACCESLOTE, aEntidad.ID_ZAFRA)
                If lLoteCosecha IsNot Nothing Then
                    lLoteCosecha.FECHA_ROZA = aEntidad.FECHA_INI_COSECHA
                    lLoteCosecha.ID_TIPO_CANA = aEntidad.ID_TIPO_CANA
                    lLoteCosecha.ID_TIPO_ROZA = aEntidad.ID_TIPO_ROZA
                    lLoteCosecha.ID_TIPO_ALZA = aEntidad.ID_TIPO_ALZA
                    lLoteCosecha.ID_TIPO_TRANS = aEntidad.ID_TIPOTRANS
                    lLoteCosecha.USUARIO_ACT = aEntidad.USUARIO_ACT
                    lLoteCosecha.FECHA_ACT = aEntidad.FECHA_ACT
                    lRet = bLoteCosecha.ActualizarLOTES_COSECHA(lLoteCosecha)
                End If
            End If

            If lRet > 0 Then
                mDb.EliminarProgramacionCosechaRepetidaLote(aEntidad.ID_ZAFRA, aEntidad.CATORCENA, aEntidad.ACCESLOTE)
            End If

            Return lRet

        Catch ex As Exception
            Me.sError = ex.Message
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function


    Public Function EliminarProgramacionCosechaRepetidaLote(ByVal ID_ZAFRA As Int32, ByVal CATORCENA As Int32, ByVal ACCESLOTE As String) As Int32
        Try
            Return mDb.EliminarProgramacionCosechaRepetidaLote(ID_ZAFRA, CATORCENA, ACCESLOTE)

        Catch ex As Exception
            Me.sError = ex.Message
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function
End Class
