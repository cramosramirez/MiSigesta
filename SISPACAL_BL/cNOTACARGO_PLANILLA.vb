Public Class cNOTACARGO_PLANILLA
    Inherits controladorBase

    Private mDb As New dbNOTACARGO_PLANILLA()
    Private mEntidad As New NOTACARGO_PLANILLA

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerLista(ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaNOTACARGO_PLANILLA
        Try
            Dim mListaNOTACARGO_PLANILLA As New ListaNOTACARGO_PLANILLA
            mListaNOTACARGO_PLANILLA = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            Return mListaNOTACARGO_PLANILLA
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerNOTACARGO_PLANILLA(ByRef aEntidad As NOTACARGO_PLANILLA) As Integer
        Try
            Dim liRet As Integer
            liRet = mDb.Recuperar(aEntidad)

            Return liRet
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)>
    Public Function ObtenerNOTACARGO_PLANILLA(ByVal ID_NOTACARGO As String, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As NOTACARGO_PLANILLA
        Try
            Dim lEntidad As New NOTACARGO_PLANILLA
            lEntidad.ID_NOTACARGO = ID_NOTACARGO
            Dim liRet As Integer
            liRet = mDb.Recuperar(lEntidad)
            If liRet = 1 Then Return lEntidad
            Return Nothing
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)>
    Public Function EliminarNOTACARGO_PLANILLA(ByVal ID_NOTACARGO As String) As Integer
        Try
            mEntidad.ID_NOTACARGO = ID_NOTACARGO
            Return mDb.Eliminar(mEntidad)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)>
    Public Function EliminarNOTACARGO_PLANILLA(ByVal aEntidad As NOTACARGO_PLANILLA, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Return mDb.Eliminar(aEntidad, aTipoConcurrencia)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)>
    Public Function ActualizarNOTACARGO_PLANILLA(ByVal aEntidad As NOTACARGO_PLANILLA) As Integer
        Try
            Return mDb.Actualizar(aEntidad, TipoConcurrencia.Pesimistica)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)>
    Public Function AgregarNOTACARGO_PLANILLA(ByVal aEntidad As NOTACARGO_PLANILLA) As Integer
        Try
            Return mDb.Agregar(aEntidad)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    Public Function ObtenerListaPorCATORCENA_TIPO_PLANILLA(ByVal ID_CATORCENA As Integer, ByVal ID_TIPO_PLANILLA As Int32, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaNOTACARGO_PLANILLA
        Try
            Return mDb.ObtenerListaPorCATORCENA_TIPO_PLANILLA(ID_CATORCENA, ID_TIPO_PLANILLA, asColumnaOrden, asTipoOrden)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function EmitirNotasCargoPorPlanilla(ByVal ID_CATORCENA As Integer,
                                                ByVal ID_TIPO_PLANILLA As Integer,
                                                ByVal ES_CONTRIBUYENTE As Integer,
                                                ByVal ID_CUENTA As Integer,
                                                ByVal USUARIO_CREA As String,
                                                ByVal FECHA_CREA As DateTime) As DataSet
        Try
            Return mDb.EmitirNotasCargoPorPlanilla(ID_CATORCENA, ID_TIPO_PLANILLA, ES_CONTRIBUYENTE, ID_CUENTA, USUARIO_CREA, FECHA_CREA)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function AsignarNUM_AUTO_BANCO(ByVal ID_CATORCENA As Integer,
                                            ByVal ID_TIPO_PLANILLA As Integer,
                                            ByVal MONTO As Decimal,
                                            ByVal NUM_CUENTA_REMESA As String,
                                            ByVal NUM_AUTORIZA_BCO As Integer) As DataSet
        Try
            Return mDb.AsignarNUM_AUTO_BANCO(ID_CATORCENA, ID_TIPO_PLANILLA, MONTO, NUM_CUENTA_REMESA, NUM_AUTORIZA_BCO)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
