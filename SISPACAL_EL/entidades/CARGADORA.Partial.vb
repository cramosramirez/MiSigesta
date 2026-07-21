Partial Public Class CARGADORA
    Private _CODIGO_NOMBRE As String
    Public Property CODIGO_NOMBRE() As String
        Get
            Return _CODIGO_NOMBRE
        End Get
        Set(ByVal Value As String)
            _CODIGO_NOMBRE = Value
        End Set
    End Property
End Class
