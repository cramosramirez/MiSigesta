Partial Public Class cCONTROL_ROZA

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorZAFRA_LOTE(ByVal ID_ZAFRA As Int32, _
                                             ByVal ACCESLOTE As String, _
                                             Optional asColumnaOrden As String = "", _
                                             Optional asTipoOrden As String = "ASC") As listaCONTROL_ROZA
        Try
            Return mDb.ObtenerListaPorZAFRA_LOTE(ID_ZAFRA, ACCESLOTE, asColumnaOrden, asTipoOrden)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ObtenerPorIdREF_CodigoREF(ByVal ID_REF As Int32, _
                                             ByVal CODIGO_REF As String) As CONTROL_ROZA
        Try
            Return mDb.ObtenerPorIdREF_CodigoREF(ID_REF, CODIGO_REF)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorPLAN_COSECHA(ByVal ID_PLAN_COSECHA As Int32, Optional ByVal recuperarForaneas As Boolean = False, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaCONTROL_ROZA
        Try
            Dim mListaCONTROL_ROZA As New listaCONTROL_ROZA
            mListaCONTROL_ROZA = mDb.ObtenerListaPorPLAN_COSECHA(ID_PLAN_COSECHA, asColumnaOrden, asTipoOrden)
            If Not mListaCONTROL_ROZA Is Nothing And recuperarForaneas Then
                For Each lEntidad As CONTROL_ROZA In mListaCONTROL_ROZA
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaCONTROL_ROZA
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function CrearDisponibilidadCuotaRoza(ByVal ID_ROZA_SALDO As String, ByVal USUARIO As String) As CONTROL_ROZA
        Try
            Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZafraActiva
            Dim lControlRoza As CONTROL_ROZA
            Dim bControlRoza As New cCONTROL_ROZA
            Dim bLotesCosecha As New cLOTES_COSECHA
            Dim lDiaZafra As New DIA_ZAFRA
            Dim lUltMovtoRoza As CONTROL_ROZA
            Dim listaCtrlRoza As listaCONTROL_ROZA
            Dim lControlRozaSaldo As CONTROL_ROZA_SALDO
            Dim lLoteCosecha As LOTES_COSECHA
            Dim lMOVTO_ROZA As CONTROL_ROZA = Nothing

            If lZafra IsNot Nothing AndAlso lZafra.DISPO_INVE_ROZA > 0 Then
                'Existe porcentaje autorizado
                'Crear cuota de roza si el saldo es igual o inferior a 33 TC
                lControlRozaSaldo = (New cCONTROL_ROZA_SALDO).ObtenerCONTROL_ROZA_SALDO(ID_ROZA_SALDO)

                If lControlRozaSaldo IsNot Nothing AndAlso lControlRozaSaldo.SALDO <= 33 Then
                    'Obtener el bolson de inventario de roza
                    listaCtrlRoza = bControlRoza.ObtenerListaPorCONTROL_ROZA_SALDO(ID_ROZA_SALDO, False, "ID_CONTROL_ROZA", "DESC")

                    lUltMovtoRoza = Nothing
                    If listaCtrlRoza IsNot Nothing AndAlso listaCtrlRoza.Count > 0 Then
                        For i As Int32 = 0 To listaCtrlRoza.Count - 1
                            If listaCtrlRoza(i).CONCEPTO.StartsWith("(ROZAGEN)") Then
                                Exit For
                            End If
                            If listaCtrlRoza(i).CODIGO_REF = "ROZADIA" Then
                                lUltMovtoRoza = listaCtrlRoza(i)
                                Exit For
                            End If
                        Next

                        If lUltMovtoRoza IsNot Nothing Then
                            lControlRoza = New CONTROL_ROZA
                            lControlRoza.ID_CONTROL_ROZA = 0
                            lControlRoza.ID_ZAFRA = lControlRozaSaldo.ID_ZAFRA
                            lControlRoza.ACCESLOTE = lControlRozaSaldo.ACCESLOTE
                            lDiaZafra = (New cDIA_ZAFRA).ObtenerDiaZafraActivo(lZafra.ID_ZAFRA)
                            If lDiaZafra IsNot Nothing Then lControlRoza.DIAZAFRA = lDiaZafra.DIAZAFRA
                            lControlRoza.CONCEPTO = "(ROZAGEN) CUOTA DE COSECHA GENERADA EN BASE AL MARGEN DEL " + (lZafra.DISPO_INVE_ROZA * 100).ToString("#,##0.00") + "%"
                            lControlRoza.CODIGO_REF = "ROZADIA"
                            lControlRoza.ID_REF = -1
                            lControlRoza.ENTRADAS = Math.Round(lZafra.DISPO_INVE_ROZA * lUltMovtoRoza.ENTRADAS, 2)
                            lControlRoza.SALIDAS = 0
                            lControlRoza.SALDO = lControlRoza.ENTRADAS + lControlRozaSaldo.SALDO
                            lControlRoza.USUARIO_CREA = USUARIO
                            lControlRoza.FECHA_CREA = cFechaHora.ObtenerFechaHora
                            lControlRoza.USUARIO_ACT = USUARIO
                            lControlRoza.FECHA_ACT = cFechaHora.ObtenerFechaHora
                            lControlRoza.FECHA_HORA_QUEMA = lControlRozaSaldo.FECHA_HORA_QUEMA
                            lControlRoza.FECHA_HORA_ROZA = lControlRozaSaldo.FECHA_HORA_ROZA
                            lControlRoza.ID_PROVEEDOR_ROZA = lControlRozaSaldo.ID_PROVEEDOR_ROZA
                            lControlRoza.ID_TIPO_CANA = lControlRozaSaldo.ID_TIPO_CANA
                            lControlRoza.ID_TIPO_ROZA = lControlRozaSaldo.ID_TIPO_ROZA
                            lControlRoza.QUEMA_NOPROG = lControlRozaSaldo.QUEMA_NOPROG
                            lControlRoza.QUEMA_PROGRAMADA = lControlRozaSaldo.QUEMA_PROGRAMADA
                            lControlRoza.CANA_VERDE = lControlRozaSaldo.CANA_VERDE
                            lControlRoza.ID_ROZA_SALDO = lControlRozaSaldo.ID_ROZA_SALDO
                            lControlRoza.ES_PROYECCION = lControlRozaSaldo.ES_PROYECCION
                            lControlRoza.ES_QUERQUEO = lControlRozaSaldo.ES_QUERQUEO
                            If bControlRoza.ActualizarCONTROL_ROZA(lControlRoza) < 1 Then
                                bControlRoza.sError = "Error al crear el movimiento de roza del Lote"
                                Return Nothing
                            End If
                            lMOVTO_ROZA = lControlRoza

                            lLoteCosecha = (New cLOTES_COSECHA).ObtenerLOTES_COSECHAPorLOTE_ZAFRA(lControlRozaSaldo.ACCESLOTE, lControlRozaSaldo.ID_ZAFRA)
                            If lLoteCosecha IsNot Nothing Then
                                lLoteCosecha.SALDO_ROZA += lControlRoza.ENTRADAS
                                lLoteCosecha.FECHA_ACT = cFechaHora.ObtenerFechaHora
                                bLotesCosecha.ActualizarLOTES_COSECHA(lLoteCosecha)
                            End If
                        End If
                    End If
                End If
            Else
                Return Nothing
            End If

            Return lMOVTO_ROZA

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla CONTROL_ROZA que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_CONTROL_ROZA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarCONTROL_ROZA(ByVal ID_CONTROL_ROZA As Int32) As Integer
        Try
            Dim lEntidad As CONTROL_ROZA = Me.ObtenerCONTROL_ROZA(ID_CONTROL_ROZA)
            Dim lRet As Int32 = 0
            Dim lista As listaCONTROL_ROZA = (New cCONTROL_ROZA).ObtenerListaPorZAFRA_LOTE(lEntidad.ID_ZAFRA, lEntidad.ACCESLOTE, "ID_CONTROL_ROZA", "DESC")
            If lista IsNot Nothing AndAlso lista.Count > 0 AndAlso lista(0).ID_CONTROL_ROZA = lEntidad.ID_CONTROL_ROZA Then
                lRet = mDb.Eliminar(lEntidad)

                'Descontar movimiento de inventario de quema
                Dim lControlQuema As listaCONTROL_QUEMA = (New cCONTROL_QUEMA).ObtenerListaPorZAFRA_LOTE(lEntidad.ID_ZAFRA, lEntidad.ACCESLOTE)
                Dim bControlQuema As New cCONTROL_QUEMA
                If lControlQuema IsNot Nothing AndAlso lControlQuema.Count > 0 Then
                    For Each lQuema As CONTROL_QUEMA In lControlQuema
                        If lQuema.SALIDAS = lEntidad.ENTRADAS AndAlso lQuema.CODIGO_REF = "ROZADIA" Then
                            bControlQuema.EliminarCONTROL_QUEMA(lQuema.ID_CONTROL_QUEMA)
                            Exit For
                        End If
                    Next
                End If

                'Actualizar saldos de roza y quema
                Dim lLotesCosecha As LOTES_COSECHA = (New cLOTES_COSECHA).ObtenerLOTES_COSECHAPorLOTE_ZAFRA(lEntidad.ACCESLOTE, lEntidad.ID_ZAFRA)
                Dim bLotesCosecha As New cLOTES_COSECHA
                If lLotesCosecha IsNot Nothing Then
                    lLotesCosecha.FECHA_ACT = cFechaHora.ObtenerFechaHora
                    bLotesCosecha.ActualizarLOTES_COSECHA(lLotesCosecha)
                End If
                Return 1
            End If

            Return -1

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function


    Public Function ObtenerPS_CONTROL_ROZA(ByVal ID_ZAFRA As Int32, ByVal ACCESLOTE As String) As listaCONTROL_ROZA
        Dim lControlRoza As New CONTROL_ROZA
        Dim lstControlRoza As listaCONTROL_ROZA = mDb.ObtenerListaPorZAFRA_LOTE(ID_ZAFRA, ACCESLOTE, "ID_CONTROL_ROZA", "ASC")
        Dim lstControlRozaAux As New listaCONTROL_ROZA
        Dim lstControlRozaRet As New listaCONTROL_ROZA
        Dim entradasRoza As New Dictionary(Of Int32, Decimal)
        Dim entradasRoza2 As New Dictionary(Of Int32, Decimal)
        Dim salidas As Decimal = 0
        Dim valores As New Dictionary(Of String, Object)

        If lstControlRoza IsNot Nothing AndAlso lstControlRoza.Count > 0 Then
            For Each cr As CONTROL_ROZA In lstControlRoza
                If cr.ENTRADAS > 0 AndAlso cr.FECHA_HORA_QUEMA <> #12:00:00 AM# Then
                    entradasRoza.Add(cr.ID_CONTROL_ROZA, cr.ENTRADAS)
                    entradasRoza2.Add(cr.ID_CONTROL_ROZA, cr.ENTRADAS)
                    lstControlRozaAux.Add(cr)
                ElseIf cr.SALIDAS > 0 Then
                    salidas += cr.SALIDAS
                End If
            Next
            For i As Int32 = 0 To lstControlRozaAux.Count - 1
                If lstControlRozaAux(i).ENTRADAS - salidas < 0 Then
                    salidas -= lstControlRozaAux(i).ENTRADAS
                    lstControlRozaAux(i).ENTRADAS = 0
                ElseIf lstControlRozaAux(i).ENTRADAS - salidas >= 0 Then
                    lstControlRozaAux(i).ENTRADAS -= salidas
                    salidas = 0
                    'Dim ctrl As CONTROL_QUEMA
                    'ctrl = (New cCONTROL_QUEMA).ObtenerCONTROL_QUEMA(lstControlQuemaAux(i).ID_CONTROL_QUEMA)
                    'lstControlQuemaRet.Add(lstControlQuemaAux(i))
                    For x As Int32 = i To lstControlRozaAux.Count - 1
                        lstControlRozaRet.Add(lstControlRozaAux(x))
                    Next
                    Exit For
                End If
            Next
        End If

        Return lstControlRozaRet
    End Function

    Public Function ObtenerULTIMA_FECHA_ROZA_DISPO_MOVTO(ByVal ID_ZAFRA As Int32, ByVal ACCESLOTE As String) As DateTime
        Dim lstControlRoza As listaCONTROL_ROZA = mDb.ObtenerListaPorZAFRA_LOTE(ID_ZAFRA, ACCESLOTE, "FECHA_HORA_ROZA", "DESC")

        If lstControlRoza IsNot Nothing AndAlso lstControlRoza.Count > 0 Then
            Return lstControlRoza(0).FECHA_HORA_ROZA
        Else
            Return #12:00:00 AM#
        End If
    End Function

    Public Function ObtenerSaldoRozaPorZAFRA_LOTE(ByVal ID_ZAFRA As Int32, _
                                             ByVal ACCESLOTE As String) As Decimal
        Try
            Return mDb.ObtenerSaldoRozaPorZAFRA_LOTE(ID_ZAFRA, ACCESLOTE)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ObtenerRozaEjecutadaPorZAFRA_LOTE(ByVal ID_ZAFRA As Int32, _
                                             ByVal ACCESLOTE As String) As Decimal
        Try
            Return mDb.ObtenerRozaEjecutadaPorZAFRA_LOTE(ID_ZAFRA, ACCESLOTE)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ObtenerSaldoRozaPorTipoQuemaPorZAFRA_LOTE(ByVal ID_ZAFRA As Int32, _
                                            ByVal ACCESLOTE As String) As Dictionary(Of String, Decimal)
        Try
            Return mDb.ObtenerSaldoRozaPorTipoQuemaPorZAFRA_LOTE(ID_ZAFRA, ACCESLOTE)

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
    ''' 	[GenApp]	16/12/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarCONTROL_ROZA(ByVal aEntidad As CONTROL_ROZA) As Integer
        Try
            Return Me.ActualizarCONTROL_ROZA(aEntidad, TipoConcurrencia.Pesimistica)
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
    ''' 	[GenApp]	16/12/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarCONTROL_ROZA(ByVal aEntidad As CONTROL_ROZA, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try

            If aEntidad.ID_ROZA_SALDO <= 0 AndAlso aEntidad.ENTRADAS > 0 Then
                Dim lstCtrlSaldoRoza As listaCONTROL_ROZA_SALDO = (New cCONTROL_ROZA_SALDO).ObtenerListaPorCriterios(aEntidad.ID_ZAFRA,
                                                                   aEntidad.ACCESLOTE, -1,
                                                                   aEntidad.ID_TIPO_CANA, aEntidad.ID_TIPO_ROZA,
                                                                   If(aEntidad.FECHA_HORA_QUEMA = Nothing, "-", aEntidad.FECHA_HORA_QUEMA.ToString("dd/MM/yyyy HH:mm")),
                                                                   aEntidad.FECHA_HORA_ROZA.ToString("dd/MM/yyyy HH:mm"),
                                                                   If(aEntidad.QUEMA_PROGRAMADA, 1, 0),
                                                                   If(aEntidad.QUEMA_NOPROG, 1, 0),
                                                                   If(aEntidad.CANA_VERDE, 1, 0), "", -1, aEntidad.ES_PROYECCION, 0, If(aEntidad.ES_QUERQUEO, 1, 0), aEntidad.ID_SUBLOTES)

                If lstCtrlSaldoRoza Is Nothing OrElse lstCtrlSaldoRoza.Count = 0 Then
                    'Agregar control de saldo de roza
                    If aEntidad.ENTRADAS > 0 Then
                        If aEntidad.ES_PROYECCION Then
                            aEntidad.CODIGO_REF = "PROYECCION"
                            aEntidad.CONCEPTO = "PROYECCION INICIAL"
                        End If
                    End If

                    Dim mControl As New CONTROL_ROZA_SALDO
                    Dim bControl As New cCONTROL_ROZA_SALDO

                    mControl.ID_ROZA_SALDO = 0
                    mControl.ID_ZAFRA = aEntidad.ID_ZAFRA
                    mControl.ACCESLOTE = aEntidad.ACCESLOTE
                    mControl.ID_PROVEEDOR_ROZA = -1
                    mControl.ID_TIPO_CANA = aEntidad.ID_TIPO_CANA
                    mControl.ID_TIPO_ROZA = aEntidad.ID_TIPO_ROZA
                    mControl.FECHA_HORA_QUEMA = aEntidad.FECHA_HORA_QUEMA
                    mControl.FECHA_HORA_ROZA = aEntidad.FECHA_HORA_ROZA
                    mControl.FECHA_HORA_QUEMA_PROY = aEntidad.FECHA_HORA_QUEMA
                    mControl.FECHA_HORA_ROZA_PROY = aEntidad.FECHA_HORA_ROZA
                    mControl.FECHA_HORA_QUEMA_REAL = Nothing
                    mControl.FECHA_HORA_ROZA_REAL = Nothing
                    mControl.QUEMA_PROGRAMADA = aEntidad.QUEMA_PROGRAMADA
                    mControl.QUEMA_NOPROG = aEntidad.QUEMA_NOPROG
                    mControl.CANA_VERDE = aEntidad.CANA_VERDE
                    mControl.ENTRADAS = 0
                    mControl.SALIDAS = 0
                    mControl.SALDO = 0
                    mControl.USUARIO_CREA = aEntidad.USUARIO_CREA
                    mControl.FECHA_CREA = aEntidad.FECHA_CREA
                    mControl.USUARIO_ACT = aEntidad.USUARIO_ACT
                    mControl.FECHA_ACT = aEntidad.FECHA_ACT
                    mControl.TC_PROY = aEntidad.ENTRADAS
                    mControl.TC_REAL = 0
                    mControl.ES_PROYECCION = aEntidad.ES_PROYECCION
                    mControl.ES_QUERQUEO = aEntidad.ES_QUERQUEO
                    mControl.ID_PROVEE_QQ = aEntidad.ID_PROVEE_QQ
                    mControl.ID_SUBLOTES = aEntidad.ID_SUBLOTES

                    If bControl.ActualizarCONTROL_ROZA_SALDO(mControl) > 0 Then
                        aEntidad.ID_ROZA_SALDO = mControl.ID_ROZA_SALDO
                        aEntidad.SALDO = mControl.SALDO + aEntidad.ENTRADAS - aEntidad.SALIDAS
                    Else
                        Me.sError = "Error al actualizar saldo de roza. No se creo el control de saldo de roza"
                        Return -1
                    End If
                ElseIf lstCtrlSaldoRoza IsNot Nothing OrElse lstCtrlSaldoRoza.Count > 0 Then
                    If aEntidad.ENTRADAS > 0 Then
                        If aEntidad.CODIGO_REF = "PROYECCION" Then
                            aEntidad.CONCEPTO = "INCREMENTO EN PROYECCION"
                            aEntidad.ES_PROYECCION = True
                        ElseIf aEntidad.CODIGO_REF = "ROZADIA" Then
                            aEntidad.ES_PROYECCION = False
                        End If
                    End If
                    aEntidad.ID_ROZA_SALDO = lstCtrlSaldoRoza(0).ID_ROZA_SALDO
                    aEntidad.SALDO = lstCtrlSaldoRoza(0).SALDO + aEntidad.ENTRADAS - aEntidad.SALIDAS
                Else
                    Me.sError = "Error al actualizar saldo de roza"
                    Return -1
                End If
            Else
                Dim lControlRozaSaldo As CONTROL_ROZA_SALDO = (New cCONTROL_ROZA_SALDO).ObtenerCONTROL_ROZA_SALDO(aEntidad.ID_ROZA_SALDO)
                If lControlRozaSaldo IsNot Nothing Then
                    If aEntidad.ENTRADAS > 0 Then
                        If aEntidad.CODIGO_REF = "PROYECCION" Then
                            aEntidad.CONCEPTO = "INCREMENTO EN PROYECCION"
                            aEntidad.ES_PROYECCION = True
                        ElseIf aEntidad.CODIGO_REF = "ROZADIA" Then
                            aEntidad.ES_PROYECCION = False
                        End If
                    End If
                    aEntidad.SALDO = lControlRozaSaldo.SALDO + aEntidad.ENTRADAS - aEntidad.SALIDAS
                End If
            End If

            Return mDb.Actualizar(aEntidad, aTipoConcurrencia)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function
End Class
