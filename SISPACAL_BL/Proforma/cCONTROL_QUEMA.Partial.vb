Imports System.Collections.Generic

Partial Public Class cCONTROL_QUEMA


    Public Function ObtenerHorasQuemaTranscurridas(ByVal ID_ZAFRA As Int32, _
                                             ByVal ACCESLOTE As String) As Dictionary(Of String, Int32)
        Try
            Return mDb.ObtenerHorasQuemaTranscurridas(ID_ZAFRA, ACCESLOTE)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorZAFRA_LOTE(ByVal ID_ZAFRA As Int32, _
                                             ByVal ACCESLOTE As String) As listaCONTROL_QUEMA
        Try
            Return mDb.ObtenerListaPorZAFRA_LOTE(ID_ZAFRA, ACCESLOTE)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ObtenerSaldoTipoQuemaPorZAFRA_LOTE(ByVal ID_ZAFRA As Int32, _
                                             ByVal ACCESLOTE As String) As Dictionary(Of String, Decimal)
        Try
            Return mDb.ObtenerSaldoTipoQuemaPorZAFRA_LOTE(ID_ZAFRA, ACCESLOTE)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ObtenerSaldoQuemaPorZAFRA_LOTE(ByVal ID_ZAFRA As Int32,
                                             ByVal ACCESLOTE As String) As Decimal
        Try
            Return mDb.ObtenerSaldoQuemaPorZAFRA_LOTE(ID_ZAFRA, ACCESLOTE)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ObtenerSaldoQuemaPorZAFRA_LOTE_PORCION(ByVal ID_ZAFRA As Int32,
                                             ByVal ACCESLOTE As String, ByVal ID_SUBLOTES As Int32) As Decimal
        Try
            Return mDb.ObtenerSaldoQuemaPorZAFRA_LOTE_PORCION(ID_ZAFRA, ACCESLOTE, ID_SUBLOTES)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function



    'Public Function ObtenerPS_CONTROL_QUEMA(ByVal ID_ZAFRA As Int32, ByVal ACCESLOTE As String) As listaCONTROL_QUEMA
    '    Dim lControlQuema As New CONTROL_QUEMA
    '    Dim bControlQuema As New cCONTROL_QUEMA
    '    Dim lstControlQuema As listaCONTROL_QUEMA = mDb.ObtenerListaPorZAFRA_LOTE(ID_ZAFRA, ACCESLOTE, "ID_CONTROL_QUEMA", "ASC")
    '    Dim lstControlQuemaRet As New listaCONTROL_QUEMA
    '    Dim entradasQuema As New Dictionary(Of Int32, Decimal)
    '    Dim entradasQuema2 As New Dictionary(Of Int32, Decimal)
    '    Dim salidas As Decimal = 0
    '    Dim valores As New Dictionary(Of String, Object)
    '    Dim ultIdEntradaQuema As Int32 = 0
    '    Dim i As Int32 = 0
    '    Dim llaves As New List(Of Int32)

    '    If lstControlQuema IsNot Nothing AndAlso lstControlQuema.Count > 0 Then
    '        For Each cr As CONTROL_QUEMA In lstControlQuema
    '            If cr.ENTRADAS > 0 AndAlso cr.CODIGO_REF = "QUEMADIA" AndAlso cr.FECHA_HORA_QUEMA <> #12:00:00 AM# Then
    '                entradasQuema.Add(cr.ID_CONTROL_QUEMA, cr.ENTRADAS)
    '                entradasQuema2.Add(cr.ID_CONTROL_QUEMA, cr.ENTRADAS)
    '                llaves.Add(cr.ID_CONTROL_QUEMA)
    '                ultIdEntradaQuema = cr.ID_CONTROL_QUEMA
    '            ElseIf cr.ENTRADAS > 0 AndAlso cr.CODIGO_REF <> "QUEMADIA" AndAlso cr.FECHA_HORA_QUEMA <> #12:00:00 AM# Then
    '                If entradasQuema.Count > 0 Then entradasQuema(ultIdEntradaQuema) += cr.ENTRADAS
    '                If entradasQuema2.Count > 0 Then entradasQuema2(ultIdEntradaQuema) += cr.ENTRADAS
    '            ElseIf cr.SALIDAS > 0 Then
    '                salidas += cr.SALIDAS
    '            End If
    '        Next

    '        For Each llave As KeyValuePair(Of Int32, Decimal) In entradasQuema2
    '            If llave.Value - salidas < 0 Then
    '                salidas -= llave.Value
    '                entradasQuema(llave.Key) = 0
    '            Else
    '                entradasQuema(llave.Key) -= salidas
    '                salidas = 0

    '                lControlQuema = bControlQuema.ObtenerCONTROL_QUEMA(llave.Key)
    '                lControlQuema.ENTRADAS = entradasQuema(llave.Key)
    '                lstControlQuemaRet.Add(lControlQuema)
    '            End If

    '            i = +1
    '        Next
    '    End If

    '    Return lstControlQuemaRet
    'End Function

    Public Function ObtenerULTIMA_FECHA_ROZA_DISPO_MOVTO(ByVal ID_ZAFRA As Int32, ByVal ACCESLOTE As String) As DateTime
        Dim lstControlQuema As listaCONTROL_QUEMA = mDb.ObtenerListaPorZAFRA_LOTE(ID_ZAFRA, ACCESLOTE, "FECHA_HORA_QUEMA", "DESC")

        If lstControlQuema IsNot Nothing AndAlso lstControlQuema.Count > 0 Then
            Return lstControlQuema(0).FECHA_HORA_QUEMA
        Else
            Return #12:00:00 AM#
        End If
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
    Public Function ActualizarCONTROL_QUEMA(ByVal aEntidad As CONTROL_QUEMA) As Integer
        Try
            Return Me.ActualizarCONTROL_QUEMA(aEntidad, TipoConcurrencia.Pesimistica)
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
    Public Function ActualizarCONTROL_QUEMA(ByVal aEntidad As CONTROL_QUEMA, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try

            If aEntidad.ID_CONTROL_QUEMA <= 0 AndAlso aEntidad.ENTRADAS > 0 Then
                Dim lstCtrlSaldoQuema As listaCONTROL_QUEMA_SALDO = (New cCONTROL_QUEMA_SALDO).ObtenerListaPorCriterios(aEntidad.ID_ZAFRA,
                                                                   aEntidad.ACCESLOTE,
                                                                   aEntidad.FECHA_HORA_QUEMA,
                                                                   If(aEntidad.QUEMA_PROGRAMADA, 1, 0),
                                                                   If(aEntidad.QUEMA_NOPROG, 1, 0),
                                                                   If(aEntidad.CANA_VERDE, 1, 0),
                                                                   If(aEntidad.ES_PROYECCION, 1, 0),
                                                                   False, aEntidad.ID_SUBLOTES)

                If lstCtrlSaldoQuema Is Nothing OrElse lstCtrlSaldoQuema.Count = 0 Then
                    'Agregar control de saldo de roza
                    If aEntidad.ENTRADAS > 0 Then
                        If aEntidad.ES_PROYECCION Then
                            aEntidad.CODIGO_REF = "PROYECCION"
                            aEntidad.CONCEPTO = "PROYECCION INICIAL"
                        Else
                            aEntidad.CODIGO_REF = "QUEMADIA"
                            aEntidad.CONCEPTO = "QUEMA DEL DIA"
                        End If
                    End If

                    Dim mControl As New CONTROL_QUEMA_SALDO
                    Dim bControl As New cCONTROL_QUEMA_SALDO

                    mControl.ID_QUEMA_SALDO = 0
                    mControl.ID_ZAFRA = aEntidad.ID_ZAFRA
                    mControl.ACCESLOTE = aEntidad.ACCESLOTE
                    mControl.FECHA_HORA_QUEMA = aEntidad.FECHA_HORA_QUEMA
                    mControl.FECHA_HORA_QUEMA_PROY = aEntidad.FECHA_HORA_QUEMA
                    mControl.FECHA_HORA_QUEMA_REAL = Nothing
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
                    mControl.ES_PROYECCION = aEntidad.ES_PROYECCION
                    mControl.TC_PROY = aEntidad.ENTRADAS
                    mControl.TC_REAL = 0
                    mControl.ID_SUBLOTES = aEntidad.ID_SUBLOTES

                    If bControl.ActualizarCONTROL_QUEMA_SALDO(mControl) > 0 Then
                        aEntidad.ID_QUEMA_SALDO = mControl.ID_QUEMA_SALDO
                        aEntidad.SALDO = Me.ObtenerSaldoQuemaPorZAFRA_LOTE(aEntidad.ID_ZAFRA, aEntidad.ACCESLOTE) + aEntidad.ENTRADAS - aEntidad.SALIDAS
                    Else
                        Me.sError = "Error al actualizar saldo de quema. No se creo el control de saldo de quema"
                        Return -1
                    End If
                ElseIf lstCtrlSaldoQuema IsNot Nothing OrElse lstCtrlSaldoQuema.Count > 0 Then
                    If aEntidad.ENTRADAS > 0 Then
                        If aEntidad.CODIGO_REF = "PROYECCION" Then
                            aEntidad.CONCEPTO = "INCREMENTO EN PROYECCION"
                            aEntidad.ES_PROYECCION = True
                        ElseIf aEntidad.CODIGO_REF = "QUEMADIA" Then
                            aEntidad.ES_PROYECCION = False
                        End If
                    End If
                    aEntidad.ID_QUEMA_SALDO = lstCtrlSaldoQuema(0).ID_QUEMA_SALDO
                    aEntidad.SALDO = lstCtrlSaldoQuema(0).SALDO + aEntidad.ENTRADAS - aEntidad.SALIDAS
                Else
                    Me.sError = "Error al actualizar saldo de quema"
                    Return -1
                End If
            Else
                Dim lControlRozaSaldo As CONTROL_QUEMA_SALDO = (New cCONTROL_QUEMA_SALDO).ObtenerCONTROL_QUEMA_SALDO(aEntidad.ID_QUEMA_SALDO)
                If lControlRozaSaldo IsNot Nothing Then
                    If aEntidad.ENTRADAS > 0 Then
                        If aEntidad.CODIGO_REF = "PROYECCION" Then
                            aEntidad.CONCEPTO = "INCREMENTO EN PROYECCION"
                            aEntidad.ES_PROYECCION = True
                        ElseIf aEntidad.CODIGO_REF = "QUEMADIA" Then
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
