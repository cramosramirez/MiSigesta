Partial Public Class cCONTRATO_LG


    Public Function ObtenerCorrelativoContrato() As Int32
        Try
            Return mDb.ObtenerCorrelativoContrato()

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    Public Function ObtenerCorrelativoContratoPorZafra(ByVal ID_ZAFRA As Int32) As Int32
        Try
            Return mDb.ObtenerCorrelativoContratoPorZafra(ID_ZAFRA)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerListaPorCriterios(ByVal ID_ZAFRA As Int32,
                                             ByVal NO_CONTRATO As Int32,
                                             ByVal CODIPROVEE As String,
                                             ByVal CODISOCIO As String) As listaCONTRATO_LG
        Try
            Dim mListaCONTRATOS As New listaCONTRATO_LG
            Return mDb.ObtenerListaPorCriterios(ID_ZAFRA, NO_CONTRATO, CODIPROVEE, CODISOCIO)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla CONTRATO que se le envía como parámetro.
    ''' </summary>
    ''' <param name="CODICONTRATO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/07/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)>
    Public Function EliminarCONTRATO_LG(ByVal CODICONTRATO As String) As Integer
        Try
            mEntidad.CODICONTRATO = CODICONTRATO
            Return Me.EliminarCONTRATO_LG(mEntidad, TipoConcurrencia.Pesimistica)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla CONTRATO que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/07/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)>
    Public Function EliminarCONTRATO_LG(ByVal aEntidad As CONTRATO_LG, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Dim bContraZafra As New cCONTRATO_ZAFRAS
            Dim bContraFinan As New cCONTRATO_FINAN
            Dim bLote As New cLOTES
            Dim bLoteCosecha As New cLOTES_COSECHA
            Dim lLoteCosecha As LOTES_COSECHA
            Dim lContraZafras As listaCONTRATO_ZAFRAS
            Dim lContratosFinan As listaCONTRATO_FINAN
            Dim lLotes As listaLOTES
            Dim lEnvios As listaENVIO

            lEnvios = (New cENVIO).ObtenerListaPorCONTRATO(aEntidad.CODICONTRATO)
            If lEnvios IsNot Nothing AndAlso lEnvios.Count > 0 Then
                Me.sError = "El contrato tiene relacionado documentos de entregas de cana (envios)"
                Return -1
            End If

            'Eliminar lotes del contrato
            lLotes = bLote.ObtenerListaPorCONTRATO(aEntidad.CODICONTRATO)
            If lLotes IsNot Nothing Then
                For Each lLote As LOTES In lLotes
                    'Eliminar lotes de cosecha
                    lContraZafras = bContraZafra.ObtenerListaPorCONTRATO(aEntidad.CODICONTRATO)
                    If lContraZafras IsNot Nothing AndAlso lContraZafras.Count > 0 Then
                        For Each lContraZafra As CONTRATO_ZAFRAS In lContraZafras
                            lLoteCosecha = bLoteCosecha.ObtenerLOTES_COSECHAPorLOTE_ZAFRA(lLote.ACCESLOTE, lContraZafra.ID_ZAFRA)
                            If lLoteCosecha IsNot Nothing Then
                                Dim lRet As Int32
                                lRet = bLoteCosecha.EliminarLOTES_COSECHA(lLoteCosecha.ID_LOTES_COSECHA)
                                If lRet < 0 Then
                                    Me.sError = bLoteCosecha.sError
                                    Return -1
                                End If
                            End If
                        Next
                        bLote.EliminarLOTES(lLote.ACCESLOTE)
                    End If
                Next
            End If

            'Eliminar zafras del contratos
            lContraZafras = bContraZafra.ObtenerListaPorCONTRATO(aEntidad.CODICONTRATO)
            If lContraZafras IsNot Nothing Then
                For Each lContraZafra As CONTRATO_ZAFRAS In lContraZafras
                    bContraZafra.EliminarCONTRATO_ZAFRAS(lContraZafra.ID_CONTRATO_ZAFRAS)
                Next
            End If

            'Eliminar contrato de financiamiento
            lContratosFinan = bContraFinan.ObtenerListaPorCONTRATO(aEntidad.CODICONTRATO)
            If lContratosFinan IsNot Nothing Then
                For Each lContraFinan As CONTRATO_FINAN In lContratosFinan
                    bContraFinan.EliminarCONTRATO_FINAN(lContraFinan.ID_CONTRATO_FINAN)
                Next
            End If


            Return mDb.Eliminar(aEntidad, aTipoConcurrencia)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Me.sError = ex.Message
            Return -1
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
    ''' 	[GenApp]	23/06/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)>
    Public Function ActualizarCONTRATO_LG(ByVal aEntidad As CONTRATO_LG) As Integer
        Try
            Return Me.ActualizarCONTRATO_LG(aEntidad, TipoConcurrencia.Pesimistica)
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
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)>
    Public Function ActualizarCONTRATO_LG(ByVal aEntidad As CONTRATO_LG, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            If (aEntidad.TIPO_CONTRATO = Enumeradores.TipoContrato.PersonaJuridica OrElse
                aEntidad.TIPO_CONTRATO = Enumeradores.TipoContrato.Cooperativa) AndAlso aEntidad.APODERADO.Trim = "" Then
                sError = "Por el tipo de contrato debe ingresar el Nombre del Representante"
                Return -1
            End If
            If (aEntidad.TIPO_CONTRATO = Enumeradores.TipoContrato.PersonaJuridica OrElse
                aEntidad.TIPO_CONTRATO = Enumeradores.TipoContrato.Cooperativa) AndAlso aEntidad.NIT_APODERADO.Trim = "" Then
                sError = "Por el tipo de contrato debe ingresar el NIT del Representante"
                Return -1
            End If
            If aEntidad.CODICONTRATO = "" Then
                Dim lContrato As CONTRATO_LG
                lContrato = (New cCONTRATO_LG).ObtenerCONTRATO_LG(aEntidad.ANIOZAFRA + Utilerias.RellenarIzquierda(aEntidad.NO_CONTRATO.ToString, 4))
                If lContrato IsNot Nothing Then
                    sError = "Ya existe el contrato " + lContrato.NO_CONTRATO.ToString + " para la zafra " + lContrato.ANIOZAFRA
                    Return -1
                End If
                aEntidad.CODICONTRATO = aEntidad.ANIOZAFRA + Utilerias.RellenarIzquierda(aEntidad.NO_CONTRATO.ToString, 4)
                Return mDb.Agregar(aEntidad)
            End If
            Return mDb.Actualizar(aEntidad, aTipoConcurrencia)
        Catch ex As Exception
            sError = ex.Message
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function


End Class
