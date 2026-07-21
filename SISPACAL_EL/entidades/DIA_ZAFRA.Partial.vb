Partial Public Class DIA_ZAFRA
    Private _DESCRIPCION_DIA As String
    Public Property DESCRIPCION_DIA() As String
        Get
            Return _DESCRIPCION_DIA
        End Get
        Set(ByVal Value As String)
            _DESCRIPCION_DIA = Value
            OnPropertyChanged("DESCRIPCION_DIA")
        End Set
    End Property
End Class
