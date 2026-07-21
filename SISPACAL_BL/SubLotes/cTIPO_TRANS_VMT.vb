Public Class cTIPO_TRANS_VMT
    Inherits controladorBase

    Private mDb As New dbTIPO_TRANS_VMT()
    Private mEntidad As New TIPO_TRANS_VMT

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerLista(ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaTIPO_TRANS_VMT
        Try
            Dim mListaTIPO_TRANS_VMT As New listaTIPO_TRANS_VMT
            mListaTIPO_TRANS_VMT = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            Return mListaTIPO_TRANS_VMT
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerTIPO_TRANS_VMT(ByRef aEntidad As TIPO_TRANS_VMT) As Integer
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
    Public Function ObtenerTIPO_TRANS_VMT(ByVal ID_TIPO_TRANS_VMT As String, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As TIPO_TRANS_VMT
        Try
            Dim lEntidad As New TIPO_TRANS_VMT
            lEntidad.ID_TIPO_TRANS_VMT = ID_TIPO_TRANS_VMT
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
    Public Function EliminarTIPO_TRANS_VMT(ByVal ID_TIPO_TRANS_VMT As String) As Integer
        Try
            mEntidad.ID_TIPO_TRANS_VMT = ID_TIPO_TRANS_VMT
            Return mDb.Eliminar(mEntidad)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)>
    Public Function EliminarTIPO_TRANS_VMT(ByVal aEntidad As TIPO_TRANS_VMT, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Return mDb.Eliminar(aEntidad, aTipoConcurrencia)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)>
    Public Function ActualizarTIPO_TRANS_VMT(ByVal aEntidad As TIPO_TRANS_VMT) As Integer
        Try
            Return mDb.Actualizar(aEntidad, TipoConcurrencia.Pesimistica)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)>
    Public Function AgregarTIPO_TRANS_VMT(ByVal aEntidad As TIPO_TRANS_VMT) As Integer
        Try
            Return mDb.Agregar(aEntidad)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function
End Class
