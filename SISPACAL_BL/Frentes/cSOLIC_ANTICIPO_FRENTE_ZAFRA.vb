Public Class cSOLIC_ANTICIPO_FRENTE_ZAFRA
    Inherits controladorBase
    Private mDb As New dbSOLIC_ANTICIPO_FRENTE_ZAFRA()
    Private mEntidad As New SOLIC_ANTICIPO_FRENTE_ZAFRA

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerLista(ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLIC_ANTICIPO_FRENTE_ZAFRA
        Try
            Dim mLista As New listaSOLIC_ANTICIPO_FRENTE_ZAFRA
            mLista = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            Return mLista
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerSOLIC_ANTICIPO_FRENTE_ZAFRA(ByRef aEntidad As SOLIC_ANTICIPO_FRENTE_ZAFRA) As Integer
        Try
            Return mDb.Recuperar(aEntidad)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)>
    Public Function ObtenerSOLIC_ANTICIPO_FRENTE_ZAFRA(ByVal ID_ANTI_ZAFRA As Integer) As SOLIC_ANTICIPO_FRENTE_ZAFRA
        Try
            Dim lEntidad As New SOLIC_ANTICIPO_FRENTE_ZAFRA
            lEntidad.ID_ANTI_ZAFRA = ID_ANTI_ZAFRA
            If mDb.Recuperar(lEntidad) = 1 Then Return lEntidad
            Return Nothing
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)>
    Public Function EliminarSOLIC_ANTICIPO_FRENTE_ZAFRA(ByVal ID_ANTI_ZAFRA As Integer) As Integer
        Try
            mEntidad.ID_ANTI_ZAFRA = ID_ANTI_ZAFRA
            Return mDb.Eliminar(mEntidad)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)>
    Public Function EliminarSOLIC_ANTICIPO_FRENTE_ZAFRA(ByVal aEntidad As SOLIC_ANTICIPO_FRENTE_ZAFRA, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Return mDb.Eliminar(aEntidad, aTipoConcurrencia)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)>
    Public Function ActualizarSOLIC_ANTICIPO_FRENTE_ZAFRA(ByVal aEntidad As SOLIC_ANTICIPO_FRENTE_ZAFRA) As Integer
        Try
            Return mDb.Actualizar(aEntidad, TipoConcurrencia.Pesimistica)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)>
    Public Function AgregarSOLIC_ANTICIPO_FRENTE_ZAFRA(ByVal aEntidad As SOLIC_ANTICIPO_FRENTE_ZAFRA) As Integer
        Try
            Return mDb.Agregar(aEntidad)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function
End Class
