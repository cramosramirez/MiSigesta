Public Class cSOLIC_DETA_FRENTE
    Inherits controladorBase
    Private mDb As New dbSOLIC_DETA_FRENTE()
    Private mEntidad As New SOLIC_DETA_FRENTE

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerLista(ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLIC_DETA_FRENTE
        Try
            Dim mLista As New listaSOLIC_DETA_FRENTE
            mLista = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            Return mLista
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerSOLIC_DETA_FRENTE(ByRef aEntidad As SOLIC_DETA_FRENTE) As Integer
        Try
            Return mDb.Recuperar(aEntidad)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)>
    Public Function ObtenerSOLIC_DETA_FRENTE(ByVal ID_SOLIC_DETA As Integer) As SOLIC_DETA_FRENTE
        Try
            Dim lEntidad As New SOLIC_DETA_FRENTE
            lEntidad.ID_SOLIC_DETA = ID_SOLIC_DETA
            If mDb.Recuperar(lEntidad) = 1 Then Return lEntidad
            Return Nothing
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)>
    Public Function EliminarSOLIC_DETA_FRENTE(ByVal ID_SOLIC_DETA As Integer) As Integer
        Try
            mEntidad.ID_SOLIC_DETA = ID_SOLIC_DETA
            Return mDb.Eliminar(mEntidad)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)>
    Public Function EliminarSOLIC_DETA_FRENTE(ByVal aEntidad As SOLIC_DETA_FRENTE, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Return mDb.Eliminar(aEntidad, aTipoConcurrencia)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)>
    Public Function ActualizarSOLIC_DETA_FRENTE(ByVal aEntidad As SOLIC_DETA_FRENTE) As Integer
        Try
            Return mDb.Actualizar(aEntidad, TipoConcurrencia.Pesimistica)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)>
    Public Function AgregarSOLIC_DETA_FRENTE(ByVal aEntidad As SOLIC_DETA_FRENTE) As Integer
        Try
            Return mDb.Agregar(aEntidad)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerListaPorSOLIC_ENCA_FRENTE(ByVal ID_SOLICITUD As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLIC_DETA_FRENTE
        Try
            Return mDb.ObtenerListaPorSOLIC_ENCA_FRENTE(ID_SOLICITUD, asColumnaOrden, asTipoOrden)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function EliminarSOLIC_DETA_FRENTE_Por_ID_SOLICITUD(ByVal ID_SOLICITUD As Integer) As Integer
        Try
            Return mDb.EliminarSOLIC_DETA_FRENTE_Por_ID_SOLICITUD(ID_SOLICITUD)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
