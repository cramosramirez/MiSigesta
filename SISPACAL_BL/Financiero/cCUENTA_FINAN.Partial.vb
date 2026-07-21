Partial Public Class cCUENTA_FINAN

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCriterios(ByVal agregarVacio As Boolean, ByVal APLICA_SOLIC_AGRICOLA As Boolean) As listaCUENTA_FINAN
        Try
            Return mDb.ObtenerListaPorCriterios(agregarVacio, APLICA_SOLIC_AGRICOLA)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerListaParaSolicTransporte(ByVal agregarVacio As Boolean) As listaCUENTA_FINAN
        Try
            Return mDb.ObtenerListaParaSolicTransporte(agregarVacio)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerListaParaSolicFrentes(ByVal agregarVacio As Boolean) As listaCUENTA_FINAN
        Try
            Return mDb.ObtenerListaParaSolicFrentes(agregarVacio)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerListaParaSolicFrentes2(ByVal agregarVacio As Boolean) As listaCUENTA_FINAN
        Try
            Return mDb.ObtenerListaParaSolicFrentes2(agregarVacio)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaParaSolicAnticipo() As listaCUENTA_FINAN
        Try
            Dim lista As New listaCUENTA_FINAN
            Dim lEntidad As CUENTA_FINAN

            lEntidad = New CUENTA_FINAN
            lEntidad = Me.ObtenerCUENTA_FINAN(Enumeradores.CuentaFinanciamiento.PlanillasPago)
            lista.Add(lEntidad)

            lEntidad = New CUENTA_FINAN
            lEntidad = Me.ObtenerCUENTA_FINAN(Enumeradores.CuentaFinanciamiento.PagoIntereses)
            lista.Add(lEntidad)

            lEntidad = New CUENTA_FINAN
            lEntidad = Me.ObtenerCUENTA_FINAN(Enumeradores.CuentaFinanciamiento.CajaChica)
            lista.Add(lEntidad)

            lEntidad = New CUENTA_FINAN
            lEntidad = Me.ObtenerCUENTA_FINAN(Enumeradores.CuentaFinanciamiento.Anticipos)
            lista.Add(lEntidad)

            lEntidad = New CUENTA_FINAN
            lEntidad = Me.ObtenerCUENTA_FINAN(Enumeradores.CuentaFinanciamiento.Mutuos)
            lista.Add(lEntidad)

           
            Return lista
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaParaGremial() As listaCUENTA_FINAN
        Try
            Dim lista As New listaCUENTA_FINAN
            Dim lEntidad As CUENTA_FINAN

            lEntidad = New CUENTA_FINAN
            lEntidad = Me.ObtenerCUENTA_FINAN(Enumeradores.CuentaFinanciamiento.Asprocana)
            lista.Add(lEntidad)

            lEntidad = New CUENTA_FINAN
            lEntidad = Me.ObtenerCUENTA_FINAN(Enumeradores.CuentaFinanciamiento.Asprocarpa)
            lista.Add(lEntidad)

            lEntidad = New CUENTA_FINAN
            lEntidad = Me.ObtenerCUENTA_FINAN(Enumeradores.CuentaFinanciamiento.Procana)
            lista.Add(lEntidad)

            Return lista
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
