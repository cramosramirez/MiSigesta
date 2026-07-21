Partial Public Class CANTON

    Private _NOMBRE_DEPTO As String
    Public Property NOMBRE_DEPTO() As String
        Get
            Return _NOMBRE_DEPTO
        End Get
        Set(ByVal Value As String)
            _NOMBRE_DEPTO = Value
        End Set
    End Property

    Private _NOMBRE_MUNI As String
    Public Property NOMBRE_MUNI() As String
        Get
            Return _NOMBRE_MUNI
        End Get
        Set(ByVal Value As String)
            _NOMBRE_MUNI = Value
        End Set
    End Property

    Private _CODIUNICO As String
    Public Property CODIUNICO() As String
        Get
            Return _CODIUNICO
        End Get
        Set(ByVal Value As String)
            _CODIUNICO = Value
        End Set
    End Property
End Class
