Partial Public Class MOTORISTA

    Private _NOMBRE_COMPLETO As String
    Public Property NOMBRE_COMPLETO() As String
        Get
            Return _NOMBRE_COMPLETO
        End Get
        Set(ByVal Value As String)
            _NOMBRE_COMPLETO = Value
        End Set
    End Property
End Class
