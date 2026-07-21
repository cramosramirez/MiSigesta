Partial Public Class LOTES_COSECHA

    Private _MZ_CONTRATO As Decimal
    Public Property MZ_CONTRATO() As Decimal
        Get
            Return _MZ_CONTRATO
        End Get
        Set(ByVal Value As Decimal)
            _MZ_CONTRATO = Value
        End Set
    End Property

    Private _TC_MZ_CONTRATO As Decimal
    Public Property TC_MZ_CONTRATO() As Decimal
        Get
            Return _TC_MZ_CONTRATO
        End Get
        Set(ByVal Value As Decimal)
            _TC_MZ_CONTRATO = Value
        End Set
    End Property

    Private _TC_CONTRATO As Decimal
    Public Property TC_CONTRATO() As Decimal
        Get
            Return _TC_CONTRATO
        End Get
        Set(ByVal Value As Decimal)
            _TC_CONTRATO = Value
        End Set
    End Property
End Class
