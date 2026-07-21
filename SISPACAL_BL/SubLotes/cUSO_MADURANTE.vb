Public Class cUSO_MADURANTE
    Inherits controladorBase

    Private mDb As New dbUSO_MADURANTE()
    Private mEntidad As New USO_MADURANTE

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerLista(ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaUSO_MADURANTE
        Try
            Dim mListaUSO_MADURANTE As New listaUSO_MADURANTE
            mListaUSO_MADURANTE = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            Return mListaUSO_MADURANTE
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerUSO_MADURANTE(ByRef aEntidad As USO_MADURANTE) As Integer
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
    Public Function ObtenerUSO_MADURANTE(ByVal ID_USO_MAD As String, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As USO_MADURANTE
        Try
            Dim lEntidad As New USO_MADURANTE
            lEntidad.ID_USO_MAD = ID_USO_MAD
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
    Public Function EliminarUSO_MADURANTE(ByVal ID_USO_MAD As String) As Integer
        Try
            mEntidad.ID_USO_MAD = ID_USO_MAD
            Return mDb.Eliminar(mEntidad)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)>
    Public Function EliminarUSO_MADURANTE(ByVal aEntidad As USO_MADURANTE, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Return mDb.Eliminar(aEntidad, aTipoConcurrencia)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)>
    Public Function ActualizarUSO_MADURANTE(ByVal aEntidad As USO_MADURANTE) As Integer
        Try
            Return mDb.Actualizar(aEntidad, TipoConcurrencia.Pesimistica)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)>
    Public Function AgregarUSO_MADURANTE(ByVal aEntidad As USO_MADURANTE) As Integer
        Try
            Return mDb.Agregar(aEntidad)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function
End Class


