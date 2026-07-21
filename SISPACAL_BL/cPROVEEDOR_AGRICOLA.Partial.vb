Partial Public Class cPROVEEDOR_AGRICOLA

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerListaPorTIPO_PROVEEDOR(ByVal ES_PROVEE_VUELO As Int32, ByVal ES_CASA_COMER As Int32, ByVal ID_CUENTA_FINAN As Int32, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaPROVEEDOR_AGRICOLA
        Try
            Dim lst As listaPROVEEDOR_AGRICOLA
            lst = mDb.ObtenerListaPorTIPO_PROVEEDOR(ES_PROVEE_VUELO, ES_CASA_COMER, ID_CUENTA_FINAN, asColumnaOrden, asTipoOrden)
            Return lst
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPROVEEDOR_BANCOS(ByVal ES_PROVEE_VUELO As Boolean, ByVal ES_CASA_COMER As Boolean, ByVal ID_CUENTA_FINAN As Int32, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaPROVEEDOR_AGRICOLA
        Try
            Return mDb.ObtenerListaPROVEEDOR_BANCOS(ES_PROVEE_VUELO, ES_CASA_COMER, ID_CUENTA_FINAN, asColumnaOrden, asTipoOrden)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCUENTA_FINAN(ByVal ID_CUENTA_FINAN As Int32, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaPROVEEDOR_AGRICOLA
        Try
            Return mDb.ObtenerListaPorCUENTA_FINAN(ID_CUENTA_FINAN, asColumnaOrden, asTipoOrden)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ObtenerListaPorCriterios(ByVal agregarVacio As Boolean, ByVal ES_PROVEE_VUELO As Int32, ByVal ES_CASA_COMER As Int32, ByVal ID_CUENTA_FINAN As Int32, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaPROVEEDOR_AGRICOLA
        Try
            Dim mListaPROVEEDOR_AGRICOLA As New listaPROVEEDOR_AGRICOLA
            mListaPROVEEDOR_AGRICOLA = mDb.ObtenerListaPorTIPO_PROVEEDOR(ES_PROVEE_VUELO, ES_CASA_COMER, ID_CUENTA_FINAN, asColumnaOrden, asTipoOrden)

            If Not mListaPROVEEDOR_AGRICOLA Is Nothing AndAlso agregarVacio Then
                Dim lProveeAgri As New PROVEEDOR_AGRICOLA
                lProveeAgri.ID_PROVEE = -1
                lProveeAgri.NOMBRE = ""
                lProveeAgri.NOMBRE_LEGAL = ""
                mListaPROVEEDOR_AGRICOLA.Insertar(0, lProveeAgri)
            End If
            Return mListaPROVEEDOR_AGRICOLA
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerListaParaTransporteCreditoEncaTrans(Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaPROVEEDOR_AGRICOLA
        Try
            Return mDb.ObtenerListaParaTransporteCreditoEncaTrans(asColumnaOrden, asTipoOrden)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
