Public Class cCREDITO_MOV_FRENTE
    Inherits controladorBase
    Private mDb As New dbCREDITO_MOV_FRENTE()
    Private mEntidad As New CREDITO_MOV_FRENTE

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerLista(ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaCREDITO_MOV_FRENTE
        Try
            Dim mLista As New listaCREDITO_MOV_FRENTE
            mLista = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            Return mLista
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerCREDITO_MOV_FRENTE(ByRef aEntidad As CREDITO_MOV_FRENTE) As Integer
        Try
            Return mDb.Recuperar(aEntidad)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)>
    Public Function ObtenerCREDITO_MOV_FRENTE(ByVal ID_CREDITO_MOV As Integer) As CREDITO_MOV_FRENTE
        Try
            Dim lEntidad As New CREDITO_MOV_FRENTE
            lEntidad.ID_CREDITO_MOV = ID_CREDITO_MOV
            If mDb.Recuperar(lEntidad) = 1 Then Return lEntidad
            Return Nothing
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)>
    Public Function EliminarCREDITO_MOV_FRENTE(ByVal ID_CREDITO_MOV As Integer) As Integer
        Try
            mEntidad.ID_CREDITO_MOV = ID_CREDITO_MOV
            Return mDb.Eliminar(mEntidad)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)>
    Public Function EliminarCREDITO_MOV_FRENTE(ByVal aEntidad As CREDITO_MOV_FRENTE, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Return mDb.Eliminar(aEntidad, aTipoConcurrencia)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)>
    Public Function ActualizarCREDITO_MOV_FRENTE(ByVal aEntidad As CREDITO_MOV_FRENTE) As Integer
        Try
            Return mDb.Actualizar(aEntidad, TipoConcurrencia.Pesimistica)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)>
    Public Function AgregarCREDITO_MOV_FRENTE(ByVal aEntidad As CREDITO_MOV_FRENTE) As Integer
        Try
            Return mDb.Agregar(aEntidad)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function
End Class
