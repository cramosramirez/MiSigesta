Public Class cSOLIC_ENCA_FRENTE
    Inherits controladorBase
    Private mDb As New dbSOLIC_ENCA_FRENTE()
    Private mEntidad As New SOLIC_ENCA_FRENTE



    Public Function ObtenerListaPorTIPO_PROVEEDOR(ByVal ID_TIPO_PROVEEDOR As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLIC_ENCA_FRENTE
        Try
            Return mDb.ObtenerListaPorTIPO_PROVEEDOR(ID_TIPO_PROVEEDOR, asColumnaOrden, asTipoOrden)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ObtenerNoSolicitudPorZafraTipoProveedor(ByVal ID_ZAFRA As Int32, ByVal ID_TIPO_PROVEEDOR As Int32) As Int32
        Try
            Return mDb.ObtenerNoSolicitudPorZafraTipoProveedor(ID_ZAFRA, ID_TIPO_PROVEEDOR)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function


    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerLista(ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLIC_ENCA_FRENTE
        Try
            Dim mLista As New listaSOLIC_ENCA_FRENTE
            mLista = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            Return mLista
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerSOLIC_ENCA_FRENTE(ByRef aEntidad As SOLIC_ENCA_FRENTE) As Integer
        Try
            Return mDb.Recuperar(aEntidad)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)>
    Public Function ObtenerSOLIC_ENCA_FRENTE(ByVal ID_SOLICITUD As Integer) As SOLIC_ENCA_FRENTE
        Try
            Dim lEntidad As New SOLIC_ENCA_FRENTE
            lEntidad.ID_SOLICITUD = ID_SOLICITUD
            If mDb.Recuperar(lEntidad) = 1 Then Return lEntidad
            Return Nothing
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)>
    Public Function EliminarSOLIC_ENCA_FRENTE(ByVal ID_SOLICITUD As Integer) As Integer
        Try
            mEntidad.ID_SOLICITUD = ID_SOLICITUD
            Return mDb.Eliminar(mEntidad)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)>
    Public Function EliminarSOLIC_ENCA_FRENTE(ByVal aEntidad As SOLIC_ENCA_FRENTE, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Return mDb.Eliminar(aEntidad, aTipoConcurrencia)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)>
    Public Function ActualizarSOLIC_ENCA_FRENTE(ByVal aEntidad As SOLIC_ENCA_FRENTE) As Integer
        Try
            If aEntidad.ID_SOLICITUD = 0 Then
                aEntidad.NUM_SOLIC_ZAFRA = Me.ObtenerNoSolicitudPorZafraTipoProveedor(aEntidad.ID_ZAFRA, aEntidad.ID_TIPO_PROVEEDOR)
            End If

            Return mDb.Actualizar(aEntidad, TipoConcurrencia.Pesimistica)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)>
    Public Function AgregarSOLIC_ENCA_FRENTE(ByVal aEntidad As SOLIC_ENCA_FRENTE) As Integer
        Try
            Return mDb.Agregar(aEntidad)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerListaPorCriterios(ByVal ID_ZAFRA As Int32,
                                             ByVal NUM_SOLIC_ZAFRA As Int32,
                                             ByVal ID_TIPO_PROVEEDOR As String,
                                             ByVal COD_FRENTE As String) As listaSOLIC_ENCA_FRENTE
        Try

            Return mDb.ObtenerListaPorCriterios(ID_ZAFRA, NUM_SOLIC_ZAFRA, ID_TIPO_PROVEEDOR, COD_FRENTE)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

End Class
