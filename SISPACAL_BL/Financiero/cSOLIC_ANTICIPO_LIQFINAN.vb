Public Class cSOLIC_ANTICIPO_LIQFINAN
    Inherits controladorBase

    Private mDb As New dbSOLIC_ANTICIPO_LIQFINAN()
    Private mEntidad As New SOLIC_ANTICIPO_LIQFINAN

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerLista(ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLIC_ANTICIPO_LIQFINAN
        Try
            Dim mListaSOLIC_ANTICIPO_LIQFINAN As New ListaSOLIC_ANTICIPO_LIQFINAN
            mListaSOLIC_ANTICIPO_LIQFINAN = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            Return mListaSOLIC_ANTICIPO_LIQFINAN
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerListaPorCriterios(ByVal CODIPROVEEDOR As String,
                                             ByVal ID_ZAFRA As Int32) As listaSOLIC_ANTICIPO_LIQFINAN
        Try
            Return mDb.ObtenerListaPorCriterios(CODIPROVEEDOR, ID_ZAFRA)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerListaPorSOLIC_ANTICIPO(ByVal ID_ANTICIPO As Int32) As listaSOLIC_ANTICIPO_LIQFINAN
        Try
            Return mDb.ObtenerListaPorSOLIC_ANTICIPO(ID_ANTICIPO)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerSOLIC_ANTICIPO_LIQFINAN(ByRef aEntidad As SOLIC_ANTICIPO_LIQFINAN) As Integer
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
    Public Function ObtenerSOLIC_ANTICIPO_LIQFINAN(ByVal ID_ANTI_LIQ As Integer, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As SOLIC_ANTICIPO_LIQFINAN
        Try
            Dim lEntidad As New SOLIC_ANTICIPO_LIQFINAN
            lEntidad.ID_ANTI_LIQ = ID_ANTI_LIQ
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
    Public Function EliminarSOLIC_ANTICIPO_LIQFINAN(ByVal ID_ANTI_LIQ As Integer) As Integer
        Try
            mEntidad.ID_ANTI_LIQ = ID_ANTI_LIQ
            Return mDb.Eliminar(mEntidad)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)>
    Public Function EliminarSOLIC_ANTICIPO_LIQFINAN(ByVal aEntidad As SOLIC_ANTICIPO_LIQFINAN, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Return mDb.Eliminar(aEntidad, aTipoConcurrencia)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)>
    Public Function ActualizarSOLIC_ANTICIPO_LIQFINAN(ByVal aEntidad As SOLIC_ANTICIPO_LIQFINAN) As Integer
        Try

            Return mDb.Actualizar(aEntidad, TipoConcurrencia.Pesimistica)


        Catch ex As Exception
            Me.sError = ex.Message.ToString
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)>
    Public Function AgregarSOLIC_ANTICIPO_LIQFINAN(ByVal aEntidad As SOLIC_ANTICIPO_LIQFINAN) As Integer
        Try
            Return mDb.Agregar(aEntidad)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    Public Function EliminarPorSOLIC_ANTICIPO(ByVal ID_ANTICIPO As Int32) As Integer
        Try
            Return mDb.EliminarPorSOLIC_ANTICIPO(ID_ANTICIPO)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

End Class
