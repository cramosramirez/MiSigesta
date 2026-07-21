Public Class cNOTACARGO_PARTIDA
    Inherits controladorBase

    Private mDb As New dbNOTACARGO_PARTIDA()
    Private mEntidad As New NOTACARGO_PARTIDA

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerLista(ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaNOTACARGO_PARTIDA
        Try
            Dim mListaNOTACARGO_PARTIDA As New listaNOTACARGO_PARTIDA
            mListaNOTACARGO_PARTIDA = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            Return mListaNOTACARGO_PARTIDA
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerNOTACARGO_PARTIDA(ByRef aEntidad As NOTACARGO_PARTIDA) As Integer
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
    Public Function ObtenerNOTACARGO_PARTIDA(ByVal ID_NOTACARGO_PARTIDA As String, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As NOTACARGO_PARTIDA
        Try
            Dim lEntidad As New NOTACARGO_PARTIDA
            lEntidad.ID_NOTACARGO_PARTIDA = ID_NOTACARGO_PARTIDA
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
    Public Function EliminarNOTACARGO_PARTIDA(ByVal ID_NOTACARGO_PARTIDA As String) As Integer
        Try
            mEntidad.ID_NOTACARGO_PARTIDA = ID_NOTACARGO_PARTIDA
            Return mDb.Eliminar(mEntidad)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)>
    Public Function EliminarNOTACARGO_PARTIDA(ByVal aEntidad As NOTACARGO_PARTIDA, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Return mDb.Eliminar(aEntidad, aTipoConcurrencia)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)>
    Public Function ActualizarNOTACARGO_PARTIDA(ByVal aEntidad As NOTACARGO_PARTIDA) As Integer
        Try
            Return mDb.Actualizar(aEntidad, TipoConcurrencia.Pesimistica)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)>
    Public Function AgregarNOTACARGO_PARTIDA(ByVal aEntidad As NOTACARGO_PARTIDA) As Integer
        Try
            Return mDb.Agregar(aEntidad)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function
End Class
