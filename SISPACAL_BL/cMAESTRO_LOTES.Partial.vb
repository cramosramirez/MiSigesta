Partial Public Class cMAESTRO_LOTES

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla PROVEEDOR .
    ''' </summary>
    ''' <param name="CODIPROVEEDOR"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/07/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorPROVEEDOR(ByVal CODIPROVEEDOR As String, Optional ByVal recuperarHijas As Boolean = False, Optional ByVal recuperarForaneas As Boolean = False, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaMAESTRO_LOTES
        Try
            Dim mListaMAESTRO_LOTES As New ListaMAESTRO_LOTES
            mListaMAESTRO_LOTES = mDb.ObtenerListaPorPROVEEDOR(CODIPROVEEDOR, asColumnaOrden, asTipoOrden)
            If Not mListaMAESTRO_LOTES Is Nothing And recuperarForaneas Then
                For Each lEntidad As MAESTRO_LOTES In mListaMAESTRO_LOTES
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaMAESTRO_LOTES
            If Not mListaMAESTRO_LOTES Is Nothing Then
                For Each lEntidad As MAESTRO_LOTES In mListaMAESTRO_LOTES
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaMAESTRO_LOTES
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerListaPorCriterios(ByVal ZONA As String, ByVal SUB_ZONA As String,
                                             ByVal CODI_DEPTO As String, ByVal CODI_MUNI As String,
                                             ByVal CODI_CANTON As String,
                                             ByVal CODIPROVEE As String,
                                             ByVal CODISOCIO As String,
                                             ByVal CODICONTRATO As Integer,
                                             ByVal NOMBRE_PROVEEDOR As String) As listaMAESTRO_LOTES
        Try
            Dim mListaMAESTRO_LOTES As New listaMAESTRO_LOTES
            Return mDb.ObtenerListaPorCriterios(ZONA, SUB_ZONA, CODI_DEPTO, CODI_MUNI, CODI_CANTON, CODIPROVEE, CODISOCIO, CODICONTRATO, NOMBRE_PROVEEDOR)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerListaPorCriteriosZafra(ByVal ZONA As String, ByVal SUB_ZONA As String,
                                             ByVal CODI_DEPTO As String, ByVal CODI_MUNI As String,
                                             ByVal CODI_CANTON As String,
                                             ByVal CODIPROVEE As String,
                                             ByVal CODISOCIO As String,
                                             ByVal CODICONTRATO As Integer,
                                             ByVal NOMBRE_PROVEEDOR As String,
                                             ByVal ID_ZAFRA_CONTRATO As Integer) As listaMAESTRO_LOTES
        Try
            Dim mListaMAESTRO_LOTES As New listaMAESTRO_LOTES
            Return mDb.ObtenerListaPorCriteriosZafra(ZONA, SUB_ZONA, CODI_DEPTO, CODI_MUNI, CODI_CANTON, CODIPROVEE, CODISOCIO, CODICONTRATO, NOMBRE_PROVEEDOR, ID_ZAFRA_CONTRATO)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function


    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCODIPROVEE(ByVal CODIPROVEE As String) As listaMAESTRO_LOTES
        Try
            Return mDb.ObtenerListaPorCODIPROVEE(CODIPROVEE)

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
    ''' 	[GenApp]	28/05/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarMAESTRO_LOTES(ByVal aEntidad As MAESTRO_LOTES) As Integer
        Try
            Return Me.ActualizarMAESTRO_LOTES(aEntidad, TipoConcurrencia.Pesimistica)
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
    ''' 	[GenApp]	28/05/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarMAESTRO_LOTES(ByVal aEntidad As MAESTRO_LOTES, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Dim lCanton As CANTON = (New cCANTON).ObtenerCANTON(aEntidad.CODI_CANTON, aEntidad.CODI_DEPTO, aEntidad.CODI_MUNI)
            Dim generarCUI As Boolean = False
            Dim lCorrelativo As Int32
            Dim lstLotes As listaLOTES
            Dim lZafraActiva As ZAFRA
            Dim lRet As Integer
            Dim bLotes As New cLOTES

            If aEntidad.CUI = "" Then
                generarCUI = True
            Else
                'Dim lEntidadAntes As MAESTRO_LOTES = Me.ObtenerMAESTRO_LOTES(aEntidad.ID_MAESTRO)
                'If lEntidadAntes IsNot Nothing AndAlso _
                '    (lEntidadAntes.CUI.Substring(0, 8) <> aEntidad.ZONA + lEntidadAntes.CODI_DEPTO + lEntidadAntes.CODI_MUNI + aEntidad.CODI_CANTON) Then
                '    generarCUI = True
                'End If
            End If

            If aEntidad.ZONA = "" Then
                Me.sError = "Zona no valida"
                Return -1
            End If
            If aEntidad.SUB_ZONA = "" Then
                Me.sError = "Subzona no valida"
                Return -1
            End If
            If lCanton Is Nothing Then
                Me.sError = "El canton donde se encuentra el Lote no es existe"
                Return -1
            End If

            If generarCUI Then
                'lCorrelativo = Me.ObtenerCorrelativoPorCanton(aEntidad.CODI_DEPTO, aEntidad.CODI_MUNI, aEntidad.CODI_CANTON)
                'aEntidad.CUI = aEntidad.ZONA.Trim + aEntidad.CODI_DEPTO + aEntidad.CODI_MUNI + aEntidad.CODI_CANTON + Utilerias.RellenarIzquierda(CStr(lCorrelativo), 3)
                'aEntidad.CORRELATIVO = Utilerias.RellenarIzquierda(CStr(lCorrelativo), 3)
                aEntidad.CUI = Left(Replace(Guid.NewGuid.ToString, "-", ""), 11)
                aEntidad.CORRELATIVO = "000"
            End If

            lRet = mDb.Actualizar(aEntidad, aTipoConcurrencia)

            'Si el lote existe en una zafra activa hay que actualizar datos del lote 
            lZafraActiva = (New cZAFRA).ObtenerZafraActiva
            If lRet >= 1 AndAlso lZafraActiva IsNot Nothing Then
                lstLotes = (New cLOTES).ObtenerListaPorZAFRA_MAESTRO_LOTES(lZafraActiva.ID_ZAFRA, aEntidad.ID_MAESTRO)
                If lstLotes IsNot Nothing AndAlso lstLotes.Count > 0 Then
                    For Each lLote As LOTES In lstLotes
                        lLote.ZONA = aEntidad.ZONA
                        lLote.SUB_ZONA = aEntidad.SUB_ZONA
                        lLote.NOMBLOTE = aEntidad.NOMBRE_COMER
                        lLote.CODILOTE = aEntidad.CODILOTE_COMER
                        lLote.CODIAGRON = aEntidad.CODIAGRON
                        lLote.CODIUBICACION = Nothing
                        lLote.FECHA_ACT = cFechaHora.ObtenerFechaHora
                        If bLotes.ActualizarLOTES(lLote) <= 0 Then
                            Me.sError = "Se actualizo el maestro de lotes pero no se actualizo la zona en los lotes contratados"
                            Return -1
                        End If
                    Next
                End If
            End If

            Return lRet


        Catch ex As Exception
            Me.sError = ex.Message
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Actualiza o Ingresa un registro que recibe de parámetro.
    ''' </summary>
    ''' <remarks>Si es una tabla de Muchos a Muchos este método unicamente actualiza el 
    ''' registro. Si no es una tabla de Muchos a Muchos puede Actualizar o insertar un 
    ''' registro, dependiendo si la llave única trae un valor de Cero(0) para ser 
    ''' autoincrementada por el método de la Clase de Acceso a Datos.</remarks>
    ''' <history>
    ''' 	[GenApp]	15/07/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarMAESTRO_LOTES(ByVal ID_MAESTRO As Int32, ByVal CUI As String, ByVal CODI_DEPTO As String, ByVal CODI_MUNI As String, ByVal CODI_CANTON As String, ByVal ZONA As String, ByVal SUB_ZONA As String, ByVal CORRELATIVO As String, ByVal CODIPROVEEDOR As String, ByVal NOMBRE_COMER As String, ByVal CODILOTE_COMER As String, ByVal MZ_CULTIVADA As Decimal, ByVal CODIVARIEDA As String, ByVal ID_COMPOR As Int32, ByVal COD_TIPO_SUELO As String, ByVal ID_COND_SIEMBRA As Int32, ByVal ID_NIVEL_HUMEDAD As Int32, ByVal NO_CORTE As Int16, ByVal MSNM As Decimal, ByVal KM_CARRETERA As Decimal, ByVal KM_TIERRA As Decimal, ByVal RIESGO_PIEDRA As Boolean, ByVal FECHA_SIEMBRA As DateTime, ByVal FECHA_CORTE As DateTime, ByVal PROD_TC As Decimal, ByVal PROD_LB As Decimal, ByVal FACTOR_DESPOBLA As Decimal, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime, ByVal CODICONTRATO As Int32) As Integer
        Try
            Dim lEntidad As New MAESTRO_LOTES
            lEntidad.ID_MAESTRO = ID_MAESTRO
            lEntidad.CUI = CUI
            lEntidad.CODI_DEPTO = CODI_DEPTO
            lEntidad.CODI_MUNI = CODI_MUNI
            lEntidad.CODI_CANTON = CODI_CANTON
            lEntidad.ZONA = ZONA
            lEntidad.SUB_ZONA = SUB_ZONA
            lEntidad.CORRELATIVO = CORRELATIVO
            lEntidad.CODIPROVEEDOR = CODIPROVEEDOR
            lEntidad.NOMBRE_COMER = NOMBRE_COMER
            lEntidad.CODILOTE_COMER = CODILOTE_COMER
            lEntidad.MZ_CULTIVADA = MZ_CULTIVADA
            lEntidad.CODIVARIEDA = CODIVARIEDA
            lEntidad.ID_COMPOR = ID_COMPOR
            lEntidad.COD_TIPO_SUELO = COD_TIPO_SUELO
            lEntidad.ID_COND_SIEMBRA = ID_COND_SIEMBRA
            lEntidad.ID_NIVEL_HUMEDAD = ID_NIVEL_HUMEDAD
            lEntidad.NO_CORTE = NO_CORTE
            lEntidad.MSNM = MSNM
            lEntidad.KM_CARRETERA = KM_CARRETERA
            lEntidad.KM_TIERRA = KM_TIERRA
            lEntidad.RIESGO_PIEDRA = RIESGO_PIEDRA
            lEntidad.FECHA_SIEMBRA = FECHA_SIEMBRA
            lEntidad.FECHA_CORTE = FECHA_CORTE
            lEntidad.PROD_TC = PROD_TC
            lEntidad.PROD_LB = PROD_LB
            lEntidad.FACTOR_DESPOBLA = FACTOR_DESPOBLA
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            lEntidad.CODICONTRATO = CODICONTRATO
            Return Me.ActualizarMAESTRO_LOTES(lEntidad)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    Public Function ObtenerCorrelativoPorCanton(ByVal CODI_DEPTO As String, ByVal CODI_MUNI As String, ByVal CODI_CANTON As String) As Integer
        Try
            Return mDb.ObtenerCorrelativoPorCanton(CODI_DEPTO, CODI_MUNI, CODI_CANTON)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    Public Function ObtenerRangoFlete(ByVal KMS As Decimal) As DataSet
        Try
            Return mDb.ObtenerRangoFlete(KMS)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
