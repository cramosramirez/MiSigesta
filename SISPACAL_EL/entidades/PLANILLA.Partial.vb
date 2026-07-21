Partial Public Class PLANILLA
    Private _CODIGO_FORMATEADO As Integer
    Public Property CODIGO_FORMATEADO() As Integer
        Get
            Return _CODIGO_FORMATEADO
        End Get
        Set(ByVal Value As Integer)
            _CODIGO_FORMATEADO = Value
        End Set
    End Property
End Class
