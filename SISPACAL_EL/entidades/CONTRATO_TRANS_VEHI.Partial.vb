Partial Public Class CONTRATO_TRANS_VEHI

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

    Private _ES_CONTRATADO As Boolean
    Public Property ES_CONTRATADO() As Boolean
        Get
            Return _ES_CONTRATADO
        End Get
        Set(ByVal Value As Boolean)
            _ES_CONTRATADO = Value
            OnPropertyChanged("ES_CONTRATADO")
        End Set
    End Property
End Class
