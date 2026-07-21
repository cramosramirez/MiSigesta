Partial Public Class PRODUCTO

    Private _NOMBRE_PROVEEDOR As String
    Public Property NOMBRE_PROVEEDOR() As String
        Get
            Return _NOMBRE_PROVEEDOR
        End Get
        Set(ByVal Value As String)
            _NOMBRE_PROVEEDOR = Value
            OnPropertyChanged("NOMBRE_PROVEEDOR")
        End Set
    End Property

End Class
