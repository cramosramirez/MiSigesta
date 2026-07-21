Partial Public Class PAGO_CTA_BANCO

    Private _CODIGO_SINFTO As Integer
    Public Property CODIGO_SINFTO() As Integer
        Get
            Return _CODIGO_SINFTO
        End Get
        Set(ByVal Value As Integer)
            _CODIGO_SINFTO = Value
            OnPropertyChanged("CODIGO_SINFTO")
        End Set
    End Property
    
End Class
