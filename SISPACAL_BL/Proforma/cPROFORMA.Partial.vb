Partial Public Class cPROFORMA

    Public Function ObtenerNoProformaPorZafra(ByVal ID_ZAFRA As Int32) As Int32
        Try
            Return mDb.ObtenerNoProformaPorZafra(ID_ZAFRA)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function


    Public Function ObtenerPROFORMAPorNumZafra(ByVal NOPROFORMA As Int32, ByVal ID_ZAFRA As Int32) As PROFORMA
        Try
            Return mDb.ObtenerPROFORMAPorNumZafra(NOPROFORMA, ID_ZAFRA)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function SP_CC_ASIGNAR_LOTE_TRANS(ByVal OPCION As String, ByVal ID_ZAFRA As Integer, ByVal ID_MOTORISTA_VEHI As Integer, ByVal ID_ASIGNACION As Integer, ByVal USUARIO As String, ByVal ID_PROFORMA As Integer) As DataSet
        Try
            Return mDb.SP_CC_ASIGNAR_LOTE_TRANS(OPCION, ID_ZAFRA, ID_MOTORISTA_VEHI, ID_ASIGNACION, USUARIO, ID_PROFORMA)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla TIPO_CANA .
    ''' </summary>
    ''' <param name="ID_TIPO_CANA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	11/12/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorTIPO_CANA(ByVal ID_TIPO_CANA As Int32, Optional ByVal recuperarForaneas As Boolean = False, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaPROFORMA
        Try
            Dim mListaPROFORMA As New listaPROFORMA
            mListaPROFORMA = mDb.ObtenerListaPorTIPO_CANA(ID_TIPO_CANA, asColumnaOrden, asTipoOrden)
            If Not mListaPROFORMA Is Nothing And recuperarForaneas Then
                For Each lEntidad As PROFORMA In mListaPROFORMA
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaPROFORMA
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ObtenerListaPorZAFRA_PLACAVEHIC(ByVal ID_ZAFRA As Int32, ByVal PLACAVEHIC As String, ByVal SOLO_EN_PROCESO As Boolean, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaPROFORMA
        Try
            Return mDb.ObtenerListaPorZAFRA_PLACAVEHIC(ID_ZAFRA, PLACAVEHIC, SOLO_EN_PROCESO, asColumnaOrden, asTipoOrden)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ObtenerListaPorCriterios(ByVal ID_ZAFRA As Int32,
                                            ByVal NOPROFORMA As Int32,
                                            ByVal ACCESLOTE As String,
                                            ByVal ESTADO As String,
                                            Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaPROFORMA
        Try
            Return mDb.ObtenerListaPorCriterios(ID_ZAFRA, NOPROFORMA, ACCESLOTE, ESTADO)

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
    ''' 	[GenApp]	10/01/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarPROFORMA(ByVal aEntidad As PROFORMA) As Integer
        Try
            Return Me.ActualizarPROFORMA(aEntidad, TipoConcurrencia.Pesimistica)
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
    ''' 	[GenApp]	10/01/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarPROFORMA(ByVal aEntidad As PROFORMA, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Dim bIntermedia As New cIntermedia
            'Dim lIntermedia As Intermedia
            Dim esNuevo As Boolean = (aEntidad.ID_PROFORMA = 0)
            Dim lRet As Int32

            lRet = mDb.Actualizar(aEntidad, aTipoConcurrencia)

            'Recuperar PROFORMA
            'Dim lProforma As PROFORMA = Me.ObtenerPROFORMA(aEntidad.ID_PROFORMA)

            'If esNuevo AndAlso lProforma IsNot Nothing Then

            '    Dim lLote As LOTES = (New cLOTES).ObtenerLOTES(lProforma.ACCESLOTE)
            '    lIntermedia = New Intermedia
            '    lIntermedia.Envio = lProforma.NOPROFORMA
            '    lIntermedia.Vehiculo = lProforma.PLACAVEHIC
            '    lIntermedia.Hacienda = lProforma.CODIPROVEEDOR + lLote.CODILOTE
            '    lIntermedia.Fin_Envio = 4
            '    lIntermedia.Id_Maestro = lLote.ID_MAESTRO
            '    bIntermedia.AgregarIntermedia(lIntermedia.Envio, lIntermedia.Vehiculo, lIntermedia.Hacienda, lIntermedia.Fin_Envio, lIntermedia.Id_Maestro)

            'ElseIf Not esNuevo AndAlso lProforma IsNot Nothing AndAlso lProforma.ESTADO = Enumeradores.EstadoProforma.Anulado Then

            '    lIntermedia = bIntermedia.ObtenerIntermedia(lProforma.NOPROFORMA)
            '    If lIntermedia IsNot Nothing Then
            '        lIntermedia.Fin_Envio = -4
            '        bIntermedia.ActualizarIntermedia(lIntermedia)
            '    End If
            'End If

            Return lRet

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function
End Class
