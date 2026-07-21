Partial Public Class SOLIC_PROD_TRANS
    Private _REFERENCIA As String
    Public Property REFERENCIA() As String
        Get
            Return _REFERENCIA
        End Get
        Set(ByVal Value As String)
            _REFERENCIA = Value
            OnPropertyChanged("REFERENCIA")
        End Set
    End Property
End Class
