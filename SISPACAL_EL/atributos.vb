<AttributeUsage(AttributeTargets.Property)> _
Public Class ColumnAttribute
    Inherits System.Attribute

    Private _Name As String = ""
    Public Property Name() As String
        Get
            Return _Name
        End Get
        Set(ByVal Value As String)
            _Name = Value
        End Set
    End Property

    Private _Storage As String = ""
    Public Property Storage() As String
        Get
            Return _Storage
        End Get
        Set(ByVal Value As String)
            _Storage = Value
        End Set
    End Property

    Private _DBType As String = ""
    Public Property DBType() As String
        Get
            Return _DBType
        End Get
        Set(ByVal Value As String)
            _DBType = Value
        End Set
    End Property

    Private _Id As Boolean = False
    Public Property Id() As Boolean
        Get
            Return _Id
        End Get
        Set(ByVal Value As Boolean)
            _Id = Value
        End Set
    End Property

End Class

<AttributeUsage(AttributeTargets.Property)> _
Public Class PrecisionAttribute
    Inherits System.Attribute

    Private _Precision As Integer = 0
    Public Property Precision() As Integer
        Get
            Return _Precision
        End Get
        Set(ByVal Value As Integer)
            _Precision = Value
        End Set
    End Property

    Private _Scale As Integer = 0
    Public Property Scale() As Integer
        Get
            Return _Scale
        End Get
        Set(ByVal Value As Integer)
            _Scale = Value
        End Set
    End Property

End Class

<AttributeUsage(AttributeTargets.Class)> _
Public Class TableAttribute
    Inherits System.Attribute

    Private _Name As String = ""
    Public Property Name() As String
        Get
            Return _Name
        End Get
        Set(ByVal Value As String)
            _Name = Value
        End Set
    End Property
End Class

