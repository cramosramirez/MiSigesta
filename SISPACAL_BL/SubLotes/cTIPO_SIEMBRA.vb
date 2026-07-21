Public Class cTIPO_SIEMBRA
    Inherits controladorBase

    Private mDb As New dbTIPO_SIEMBRA()
    Private mEntidad As New TIPO_SIEMBRA

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerLista(ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaTIPO_SIEMBRA
        Try
            Dim mListaTIPO_SIEMBRA As New listaTIPO_SIEMBRA
            mListaTIPO_SIEMBRA = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            Return mListaTIPO_SIEMBRA
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerTIPO_SIEMBRA(ByRef aEntidad As TIPO_SIEMBRA) As Integer
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
    Public Function ObtenerTIPO_SIEMBRA(ByVal ID_TIPO_SIEMBRA As String, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As TIPO_SIEMBRA
        Try
            Dim lEntidad As New TIPO_SIEMBRA
            lEntidad.ID_TIPO_SIEMBRA = ID_TIPO_SIEMBRA
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
    Public Function EliminarTIPO_SIEMBRA(ByVal ID_TIPO_SIEMBRA As String) As Integer
        Try
            mEntidad.ID_TIPO_SIEMBRA = ID_TIPO_SIEMBRA
            Return mDb.Eliminar(mEntidad)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)>
    Public Function EliminarTIPO_SIEMBRA(ByVal aEntidad As TIPO_SIEMBRA, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Return mDb.Eliminar(aEntidad, aTipoConcurrencia)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)>
    Public Function ActualizarTIPO_SIEMBRA(ByVal aEntidad As TIPO_SIEMBRA) As Integer
        Try
            Return mDb.Actualizar(aEntidad, TipoConcurrencia.Pesimistica)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)>
    Public Function AgregarTIPO_SIEMBRA(ByVal aEntidad As TIPO_SIEMBRA) As Integer
        Try
            Return mDb.Agregar(aEntidad)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function
End Class
