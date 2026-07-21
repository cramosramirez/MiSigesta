Partial Public Class cPLANILLA


    Public Function PROC_GenerarCOMPROBANTES(ByVal ID_PLANILLA_BASE As Int32, ByVal ID_COMPROB_NUME As Int32, ByVal NO_DOCTO As Int32, ByVal TIPO As Int32, ByVal ES_CONTRIBUYENTE As Int32, ByVal USUARIO As String, ByVal ID_COMPROB_CONCE As Int32, ByVal FECHA_EMISION As DateTime) As String
        Try
            Return mDb.PROC_GenerarCOMPROBANTES(ID_PLANILLA_BASE, ID_COMPROB_NUME, NO_DOCTO, TIPO, ES_CONTRIBUYENTE, USUARIO, ID_COMPROB_CONCE, FECHA_EMISION)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return "Error en la emisión"
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerPLANILLAPorCATORCENA_PROVEEDOR(ByVal ID_CATORCENA As Integer, ByVal CODIPROVEEDOR As String) As PLANILLA
        Try
            Dim lCriterios As New List(Of Criteria)
            Dim listaPlanillas As listaPLANILLA
            Dim lPlanilla As New PLANILLA

            lCriterios.Add(New Criteria("ID_CATORCENA", "=", ID_CATORCENA.ToString, "AND"))
            lCriterios.Add(New Criteria("CODIPROVEEDOR_TRANSPORTISTA", "=", CODIPROVEEDOR, "AND"))
            lPlanilla.ID_CATORCENA = ID_CATORCENA
            lPlanilla.CODIPROVEEDOR_TRANSPORTISTA = CODIPROVEEDOR

            listaPlanillas = Me.ObtenerListaPorBusqueda(lPlanilla, lCriterios.ToArray)
            If listaPlanillas IsNot Nothing AndAlso listaPlanillas.Count > 0 Then
                Return listaPlanillas(0)
            End If

            Return Nothing

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que llena un DataSet filtrado por los parámetros de la Tabla Padre,
    ''' si no tiene una tabla Padre llena con todos los registros de la Entidad.
    ''' </summary>
    ''' <param name="ID_CATORCENA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerContratosLotesPorCATORCENA_PROVEEDOR(ByVal ID_CATORCENA As Integer, ByVal CODIPROVEEDOR As String, ByVal POR_LOTE As Boolean, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As DataSet
        Try
            Return mDb.ObtenerContratosLotesPorCATORCENA_PROVEEDOR(ID_CATORCENA, CODIPROVEEDOR, POR_LOTE, asColumnaOrden, asTipoOrden)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que llena un DataSet filtrado por los parámetros de la Tabla Padre,
    ''' si no tiene una tabla Padre llena con todos los registros de la Entidad.
    ''' </summary>
    ''' <param name="ID_CATORCENA"></param>
    ''' <param name="ID_TIPO_PLANILLA"></param>
    ''' <param name="CODIPROVEEDOR_TRANSPORTISTA"></param>
    ''' <param name="NOMBRE_PROVEE_TRANS"></param>
    ''' <param name="ES_CONTRIBUYENTE"></param>
    ''' <param name="asColumnaOrden"></param>
    ''' <param name="asTipoOrden"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorCRITERIOS(ByVal ID_CATORCENA As Integer, _
                                            ByVal ID_TIPO_PLANILLA As Integer, _
                                            ByVal CODIPROVEEDOR_TRANSPORTISTA As String, _
                                            ByVal NOMBRE_PROVEE_TRANS As String, _
                                            ByVal ES_CONTRIBUYENTE As Boolean, _
                                            Optional ByVal asColumnaOrden As String = "", _
                                            Optional ByVal asTipoOrden As String = "ASC") As listaPLANILLA
        Try
            Return mDb.ObtenerListaPorCRITERIOS(ID_CATORCENA, ID_TIPO_PLANILLA, CODIPROVEEDOR_TRANSPORTISTA, _
                                                         NOMBRE_PROVEE_TRANS, ES_CONTRIBUYENTE, asColumnaOrden, asTipoOrden)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function


    Public Function ObtenerListaPorCRITERIOS(ByVal ID_CATORCENA As Integer, _
                                            ByVal ID_TIPO_PLANILLA As Integer, _
                                            ByVal CODIPROVEEDOR_TRANSPORTISTA As String, _
                                            ByVal NOMBRE_PROVEE_TRANS As String, _
                                            Optional ByVal asColumnaOrden As String = "", _
                                            Optional ByVal asTipoOrden As String = "ASC") As listaPLANILLA
        Try
            Return mDb.ObtenerListaPorCRITERIOS(ID_CATORCENA, ID_TIPO_PLANILLA, CODIPROVEEDOR_TRANSPORTISTA, _
                                                         NOMBRE_PROVEE_TRANS, asColumnaOrden, asTipoOrden)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que llena un DataSet filtrado por los parámetros de la Tabla Padre,
    ''' si no tiene una tabla Padre llena con todos los registros de la Entidad.
    ''' </summary>
    ''' <param name="ID_CATORCENA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaChequesPendientesEmitir(ByVal ID_CATORCENA As Integer, _
                                            ByVal ID_TIPO_PLANILLA As Integer, _
                                            ByVal ES_CONTRIBUYENTE As Integer, _
                                            ByVal NO_CHEQUE_INICIAL As Integer, _
                                            Optional ID_RANGO_COMPE As Int32 = -1) As listaPLANILLA
        Try
            Return mDb.ObtenerListaChequesPendientesEmitir(ID_CATORCENA, ID_TIPO_PLANILLA, ES_CONTRIBUYENTE, NO_CHEQUE_INICIAL, ID_RANGO_COMPE)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Me.sError = ex.Message
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que llena un DataSet filtrado por los parámetros de la Tabla Padre,
    ''' si no tiene una tabla Padre llena con todos los registros de la Entidad.
    ''' </summary>
    ''' <param name="ID_CATORCENA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaChequesPlanilla(ByVal ID_CATORCENA As Integer, _
                                            ByVal ID_TIPO_PLANILLA As Integer, _
                                            ByVal ES_CONTRIBUYENTE As Integer, _
                                            Optional ID_RANGO_COMPE As Int32 = -1) As listaPLANILLA
        Try
            Return mDb.ObtenerListaChequesPlanilla(ID_CATORCENA, ID_TIPO_PLANILLA, ES_CONTRIBUYENTE, ID_RANGO_COMPE)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function EmitirCheques(ByVal ID_CATORCENA As Integer, _
                 ByVal ID_TIPO_PLANILLA As Integer, _
                 ByVal ES_CONTRIBUYENTE As Integer, _
                 ByVal ID_CUENTA As Integer, _
                 ByVal ID_CHEQUERA As Integer, _
                 ByVal PRIMER_CHEQUE As Integer, _
                 ByVal ULTIMO_CHEQUE As Integer, _
                 ByVal USUARIO_CREA As String, _
                 ByVal FECHA_CREA As DateTime, _
                 ByVal ID_RANGO_COMPE As Int32) As Integer
        Try
            Dim lRet As Integer
            Dim mensaje As String

            lRet = mDb.EmitirCheques(ID_CATORCENA, ID_TIPO_PLANILLA, ES_CONTRIBUYENTE, ID_CUENTA, ID_CHEQUERA, PRIMER_CHEQUE, ULTIMO_CHEQUE, USUARIO_CREA, FECHA_CREA, mensaje, ID_RANGO_COMPE)
            If lRet = -1 Then
                sError = mensaje
            End If
            Return lRet

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            sError = ex.Message
            Return -1
        End Try
    End Function

    Public Function GenerarPlanilla(ByVal ID_ZAFRA As Integer, _
                 ByVal ID_CATORCENA As Integer, _
                 ByVal USUARIO_CREA As String, _
                 ByVal FECHA_CREA As Date) As Integer
        Try
            'Si no es la última catorcena no se puede regenerar planilla
            Dim lCatorcenas As listaCATORCENA_ZAFRA = (New cCATORCENA_ZAFRA).ObtenerListaPorZAFRA(ID_ZAFRA, False, False, "CATORCENA", "DESC")
            Dim lCatorcena As CATORCENA_ZAFRA = (New cCATORCENA_ZAFRA).ObtenerCATORCENA_ZAFRA(ID_CATORCENA)

            If lCatorcenas IsNot Nothing AndAlso lCatorcenas.Count > 0 Then
                If lCatorcenas(0).CATORCENA <> lCatorcena.CATORCENA Then
                    Me.sError = "Solo puede generar planilla de la ultima catorcena generada"
                    Return -1
                End If
            End If
            Return mDb.GenerarPlanilla(ID_ZAFRA, ID_CATORCENA, USUARIO_CREA, FECHA_CREA)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            sError = ex.Message
            Return -1
        End Try
    End Function


    Public Function AnularChequesPlanilla(ByVal ID_CATORCENA As Integer, _
         ByVal ID_TIPO_PLANILLA As Integer, _
         ByVal ES_CONTRIBUYENTE As Integer, _
         ByVal CHEQUE_INICIAL As Integer, _
         ByVal CHEQUE_FINAL As Integer, _
         ByVal ID_RANGO_COMPE As Int32) As Integer
        Try
            Return mDb.AnularChequesPlanilla(ID_CATORCENA, ID_TIPO_PLANILLA, ES_CONTRIBUYENTE, CHEQUE_INICIAL, CHEQUE_FINAL, ID_RANGO_COMPE)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            sError = ex.Message
            Return -1
        End Try
    End Function

    Public Function ObtenerPorCATORCENA_TIPO_PLANILLA(ByVal ID_CATORCENA As Integer, _
                                           ByVal ID_TIPO_PLANILLA As Integer) As listaPLANILLA
        Try
            Return mDb.ObtenerPorCATORCENA_TIPO_PLANILLA(ID_CATORCENA, ID_TIPO_PLANILLA)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Me.sError = ex.Message
            Return Nothing
        End Try
    End Function

    Public Function GenerarPlanillaAnticipoCaneros(ByVal ID_ZAFRA As Integer, ByVal ID_CATORCENA As Integer, ByVal NO_ANTICIPO As Integer, ByVal VALOR_ANTICIPO As Decimal, ByVal CONCEPTO As String) As Integer
        Try
            Return mDb.GenerarPlanillaAnticipoCaneros(ID_ZAFRA, ID_CATORCENA, NO_ANTICIPO, VALOR_ANTICIPO, CONCEPTO)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Me.sError = ex.Message
            Return Nothing
        End Try
    End Function

    Public Function GenerarPlanillaComplementoValorFinal(ByVal ID_ZAFRA As Integer, ByVal VALOR_FINAL_PAGO As Decimal) As Integer
        Try
            Return mDb.GenerarPlanillaComplementoValorFinal(ID_ZAFRA, VALOR_FINAL_PAGO)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Me.sError = ex.Message
            Return Nothing
        End Try
    End Function
End Class
