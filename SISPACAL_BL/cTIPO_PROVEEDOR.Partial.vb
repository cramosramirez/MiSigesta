Partial Public Class cTIPO_PROVEEDOR


    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerListaFrentes(ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaTIPO_PROVEEDOR
        Try
            Dim lista As New listaTIPO_PROVEEDOR
            Dim lEntidad As TIPO_PROVEEDOR

            lEntidad = ObtenerTIPO_PROVEEDOR(Enumeradores.TipoProveedor.FrenteRoza)
            lista.Add(lEntidad)
            lEntidad = ObtenerTIPO_PROVEEDOR(Enumeradores.TipoProveedor.FrenteQuerqueo)
            lista.Add(lEntidad)

            Return lista
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
