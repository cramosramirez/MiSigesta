Public Class cRIESGO_PIEDRA
    Inherits controladorBase

    Private mDb As New dbRIESGO_PIEDRA()
    Private mEntidad As New RIESGO_PIEDRA

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerLista(ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaRIESGO_PIEDRA
        Try
            Dim mListaRIESGO_PIEDRA As New listaRIESGO_PIEDRA
            mListaRIESGO_PIEDRA = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            Return mListaRIESGO_PIEDRA
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerRIESGO_PIEDRA(ByRef aEntidad As RIESGO_PIEDRA) As Integer
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
    Public Function ObtenerRIESGO_PIEDRA(ByVal ID_RIESGO_PIEDRA As String, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As RIESGO_PIEDRA
        Try
            Dim lEntidad As New RIESGO_PIEDRA
            lEntidad.ID_RIESGO_PIEDRA = ID_RIESGO_PIEDRA
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
    Public Function EliminarRIESGO_PIEDRA(ByVal ID_RIESGO_PIEDRA As String) As Integer
        Try
            mEntidad.ID_RIESGO_PIEDRA = ID_RIESGO_PIEDRA
            Return mDb.Eliminar(mEntidad)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)>
    Public Function EliminarRIESGO_PIEDRA(ByVal aEntidad As RIESGO_PIEDRA, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Return mDb.Eliminar(aEntidad, aTipoConcurrencia)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)>
    Public Function ActualizarRIESGO_PIEDRA(ByVal aEntidad As RIESGO_PIEDRA) As Integer
        Try
            Return mDb.Actualizar(aEntidad, TipoConcurrencia.Pesimistica)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)>
    Public Function AgregarRIESGO_PIEDRA(ByVal aEntidad As RIESGO_PIEDRA) As Integer
        Try
            Return mDb.Agregar(aEntidad)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function
End Class

