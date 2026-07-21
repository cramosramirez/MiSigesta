Partial Public Class cCUENTA_PROVEEDOR
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve un DataSer filtrado por los parámetros.
    ''' </summary>
    ''' <param name="ID_TIPO_PROVEEDOR"></param>
    ''' <param name="CODIPROVEE"></param>
    ''' <param name="CODISOCIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerDataSetPorTipoProveedor(ByVal ID_TIPO_PROVEEDOR As Integer, ByVal CODIPROVEE As String, ByVal CODISOCIO As String) As DataSet
        Try
            Return mDb.ObtenerDataSetPorTipoProveedor(ID_TIPO_PROVEEDOR, CODIPROVEE, CODISOCIO)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ObtenerPorCODIGO_TIPO_PROVEEDOR(ByVal CODIGO As String, ByVal ID_TIPO_PROVEEDOR As Integer) As CUENTA_PROVEEDOR
        Try
            Dim lCriterios As New List(Of Criteria)
            Dim lEntidad As New CUENTA_PROVEEDOR
            Dim lista As listaCUENTA_PROVEEDOR

            lCriterios.Add(New Criteria("CODIGO", "=", CODIGO.ToString, "AND"))
            lCriterios.Add(New Criteria("ID_TIPO_PROVEEDOR", "=", ID_TIPO_PROVEEDOR.ToString, "AND"))
            lEntidad.CODIGO = CODIGO
            lEntidad.ID_TIPO_PROVEEDOR = ID_TIPO_PROVEEDOR

            lista = mDb.ObtenerListaPorBusqueda(lEntidad, lCriterios.ToArray)
            If lista IsNot Nothing AndAlso lista.Count > 0 Then
                Return lista(0)
            Else
                Return Nothing
            End If

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
