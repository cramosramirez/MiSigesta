Public Class cENVIO_SEDIMENTO
    Inherits controladorBase

    Private mDb As New dbENVIO_SEDIMENTO()
    Private mEntidad As New ENVIO_SEDIMENTO


    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerListaPorENVIO(ByVal ID_ENVIO As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaENVIO_SEDIMENTO
        Try
            Return mDb.ObtenerListaPorENVIO(ID_ENVIO, asColumnaOrden, asTipoOrden)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function


    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerLista(ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaENVIO_SEDIMENTO
        Try
            Dim mListaENVIO_SEDIMENTO As New ListaENVIO_SEDIMENTO
            mListaENVIO_SEDIMENTO = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            Return mListaENVIO_SEDIMENTO
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerENVIO_SEDIMENTO(ByRef aEntidad As ENVIO_SEDIMENTO) As Integer
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
    Public Function ObtenerENVIO_SEDIMENTO(ByVal ID_ENVIO_SEDI As String, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As ENVIO_SEDIMENTO
        Try
            Dim lEntidad As New ENVIO_SEDIMENTO
            lEntidad.ID_ENVIO_SEDI = ID_ENVIO_SEDI
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
    Public Function EliminarENVIO_SEDIMENTO(ByVal ID_ENVIO_SEDI As String) As Integer
        Try
            mEntidad.ID_ENVIO_SEDI = ID_ENVIO_SEDI
            Return mDb.Eliminar(mEntidad)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)>
    Public Function EliminarENVIO_SEDIMENTO(ByVal aEntidad As ESTRATO, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Return mDb.Eliminar(aEntidad, aTipoConcurrencia)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)>
    Public Function ActualizarENVIO_SEDIMENTO(ByVal aEntidad As ENVIO_SEDIMENTO) As Integer
        Try
            Return mDb.Actualizar(aEntidad, TipoConcurrencia.Pesimistica)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)>
    Public Function AgregarENVIO_SEDIMENTO(ByVal aEntidad As ENVIO_SEDIMENTO) As Integer
        Try
            Return mDb.Agregar(aEntidad)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function
End Class
