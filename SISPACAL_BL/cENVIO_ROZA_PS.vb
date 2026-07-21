<System.ComponentModel.DataObject()>
Public Class cENVIO_ROZA_PS
    Inherits controladorBase


#Region " Privadas "
    Private mDb As New dbENVIO_ROZA_PS()
    Private mEntidad As New ENVIO_ROZA_PS
#End Region


    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerLista(ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaENVIO_ROZA_PS
        Try
            Dim mListaENVIO_ROZA_PS As New listaENVIO_ROZA_PS
            mListaENVIO_ROZA_PS = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            Return mListaENVIO_ROZA_PS
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerENVIO_ROZA_PS(ByRef aEntidad As ENVIO_ROZA_PS, ByVal Optional recuperarForaneas As Boolean = False) As Integer
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
    Public Function ObtenerENVIO_ROZA_PS(ByVal ID_ENVIO_ROZA As Int32, ByVal Optional recuperarForaneas As Boolean = False) As ENVIO_ROZA_PS
        Try
            Dim lEntidad As New ENVIO_ROZA_PS
            lEntidad.ID_ENVIO_ROZA = ID_ENVIO_ROZA
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
    Public Function EliminarENVIO_ROZA_PS(ByVal ID_ENVIO_ROZA As Int32) As Integer
        Try
            mEntidad.ID_ENVIO_ROZA = ID_ENVIO_ROZA
            Return mDb.Eliminar(mEntidad)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)>
    Public Function EliminarENVIO_ROZA_PS(ByVal aEntidad As ENVIO_ROZA_PS, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Return mDb.Eliminar(aEntidad, aTipoConcurrencia)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)>
    Public Function ActualizarENVIO_ROZA_PS(ByVal aEntidad As ENVIO_ROZA_PS) As Integer
        Try
            Return mDb.Actualizar(aEntidad)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)>
    Public Function ActualizarENVIO_ROZA_PS(ByVal aEntidad As ENVIO_ROZA_PS, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Return mDb.Actualizar(aEntidad, aTipoConcurrencia)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerListaPorENVIO(ByVal ID_ENVIO As Int32, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaENVIO_ROZA_PS
        Try
            Dim mListaENVIO_ROZA_PS As New ListaENVIO_ROZA_PS
            mListaENVIO_ROZA_PS = mDb.ObtenerListaPorENVIO(ID_ENVIO, asColumnaOrden, asTipoOrden)
            Return mListaENVIO_ROZA_PS
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
