Partial Public Class cPRODUCTO


    Public Function ObtenerExistenciaTotal(ByVal ID_PRODUCTO As Int32) As Decimal
        Try
            Return mDb.ObtenerExistenciaTotal(ID_PRODUCTO)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return 0
        End Try
    End Function

    Public Function ObtenerExistenciaPorBodega(ByVal ID_BODEGA As Int32, ByVal ID_PRODUCTO As Int32) As Decimal
        Try
            Return mDb.ObtenerExistenciaPorBodega(ID_BODEGA, ID_PRODUCTO)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return 0
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla CATEGORIA_PROD .
    ''' </summary>
    ''' <param name="ID_CATEGORIA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/10/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCATEGORIA_PROD(ByVal ID_CATEGORIA As Int32, ByVal asColumnaOrden As String, ByVal asTipoOrden As String, ByVal AgregarVacio As Boolean) As listaPRODUCTO
        Try
            Dim mListaPRODUCTO As New listaPRODUCTO
            mListaPRODUCTO = mDb.ObtenerListaPorCATEGORIA_PROD(ID_CATEGORIA, asColumnaOrden, asTipoOrden)
            If Not mListaPRODUCTO Is Nothing AndAlso AgregarVacio Then
                Dim lEntidad As New PRODUCTO
                lEntidad.ID_PRODUCTO = -1
                lEntidad.NOMBRE_PRODUCTO = ""
                mListaPRODUCTO.Insertar(0, lEntidad)
            End If
            Return mListaPRODUCTO
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla CATEGORIA_PROD .
    ''' </summary>
    ''' <param name="ID_CUENTA_FINAN"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/10/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCUENTA_FINAN(ByVal ID_CUENTA_FINAN As Int32, ByVal ACTIVO As Int32, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaPRODUCTO
        Try
            Return mDb.ObtenerListaPorCUENTA_FINAN(ID_CUENTA_FINAN, ACTIVO, asColumnaOrden, asTipoOrden)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCriterios(ByVal ID_PROVEE As Int32, ByVal ID_CATEGORIA As Int32, ByVal ID_CUENTA_FINAN As Int32, ByVal ID_ZAFRA As Int32, ByVal ACTIVO As Int32, ByVal EN_CONSIGNA As Int32, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC", Optional OcultarGenerico As Boolean = False) As listaPRODUCTO
        Try
            Return mDb.ObtenerListaPorCriterios(ID_PROVEE, ID_CATEGORIA, ID_CUENTA_FINAN, ID_ZAFRA, ACTIVO, EN_CONSIGNA, asColumnaOrden, asTipoOrden, OcultarGenerico)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ObtenerListaPorNOMBRE_PRODUCTO(ByVal NOMBRE_PRODUCTO As String, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaPRODUCTO
        Try
            Dim mListaPRODUCTO As New listaPRODUCTO
            mListaPRODUCTO = mDb.ObtenerListaPorNOMBRE_PRODUCTO(NOMBRE_PRODUCTO)

            Return mListaPRODUCTO

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ObtenerListaPorNOMBRE_PRODUCTO_EXACTO(ByVal NOMBRE_PRODUCTO As String, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaPRODUCTO
        Try
            Dim mListaPRODUCTO As New listaPRODUCTO
            mListaPRODUCTO = mDb.ObtenerListaPorNOMBRE_PRODUCTO_EXACTO(NOMBRE_PRODUCTO)

            Return mListaPRODUCTO

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
