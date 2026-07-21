<Serializable(), Table(Name:="NOTACARGO_PARTIDA")> Public Class NOTACARGO_PARTIDA
    Inherits entidadBase

    Public Sub New()
    End Sub

    Private _ID_NOTACARGO_PARTIDA As Int32
    <Column(Name:="ID_NOTACARGO_PARTIDA", Storage:="ID_NOTACARGO_PARTIDA", DBType:="INT NOT NULL", Id:=True),
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property ID_NOTACARGO_PARTIDA() As Int32
        Get
            Return _ID_NOTACARGO_PARTIDA
        End Get
        Set(ByVal Value As Int32)
            _ID_NOTACARGO_PARTIDA = Value
            OnPropertyChanged("ID_NOTACARGO_PARTIDA")
        End Set
    End Property

    Private _ID_NOTACARGO As Int32
    <Column(Name:="ID_NOTACARGO", Storage:="ID_NOTACARGO", DBType:="INT NOT NULL", Id:=True),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property ID_NOTACARGO() As Int32
        Get
            Return _ID_NOTACARGO
        End Get
        Set(ByVal Value As Int32)
            _ID_NOTACARGO = Value
            OnPropertyChanged("ID_NOTACARGO")
        End Set
    End Property

    Private _ORDEN As Int32
    <Column(Name:="ORDEN", Storage:="ORDEN", DBType:="INT NULL", Id:=True),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property ORDEN() As Int32
        Get
            Return _ORDEN
        End Get
        Set(ByVal Value As Int32)
            _ORDEN = Value
            OnPropertyChanged("ORDEN")
        End Set
    End Property

    Private _CUENTA_CONTABLE As String
    <Column(Name:="CUENTA_CONTABLE", Storage:="CUENTA_CONTABLE", DBType:="VARCHAR(100) NULL", Id:=False),
     DataObjectField(False, False, True, 100)>
    Public Property CUENTA_CONTABLE() As String
        Get
            Return _CUENTA_CONTABLE
        End Get
        Set(ByVal Value As String)
            _CUENTA_CONTABLE = Value
            OnPropertyChanged("CUENTA_CONTABLE")
        End Set
    End Property

    Private _DESCRIPCION_CUENTA As String
    <Column(Name:="DESCRIPCION_CUENTA", Storage:="DESCRIPCION_CUENTA", DBType:="VARCHAR(200) NULL", Id:=False),
     DataObjectField(False, False, True, 200)>
    Public Property DESCRIPCION_CUENTA() As String
        Get
            Return _DESCRIPCION_CUENTA
        End Get
        Set(ByVal Value As String)
            _DESCRIPCION_CUENTA = Value
            OnPropertyChanged("DESCRIPCION_CUENTA")
        End Set
    End Property

    Private _DESCRIPCION_ADICIONAL As String
    <Column(Name:="DESCRIPCION_ADICIONAL", Storage:="DESCRIPCION_ADICIONAL", DBType:="VARCHAR(200) NULL", Id:=False),
     DataObjectField(False, False, True, 200)>
    Public Property DESCRIPCION_ADICIONAL() As String
        Get
            Return _DESCRIPCION_ADICIONAL
        End Get
        Set(ByVal Value As String)
            _DESCRIPCION_ADICIONAL = Value
            OnPropertyChanged("DESCRIPCION_ADICIONAL")
        End Set
    End Property

    Private _DEBE As Decimal
    <Column(Name:="DEBE", Storage:="DEBE", DBType:="NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)>
    Public Property DEBE() As Decimal
        Get
            Return _DEBE
        End Get
        Set(ByVal Value As Decimal)
            _DEBE = Value
            OnPropertyChanged("DEBE")
        End Set
    End Property

    Private _HABER As Decimal
    <Column(Name:="HABER", Storage:="HABER", DBType:="NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)>
    Public Property HABER() As Decimal
        Get
            Return _HABER
        End Get
        Set(ByVal Value As Decimal)
            _HABER = Value
            OnPropertyChanged("HABER")
        End Set
    End Property

    Private _USUARIO_CREA As String
    <Column(Name:="USUARIO_CREA", Storage:="USUARIO_CREA", DBType:="VARCHAR(1000) NULL", Id:=False),
     DataObjectField(False, False, True, 1000)>
    Public Property USUARIO_CREA() As String
        Get
            Return _USUARIO_CREA
        End Get
        Set(ByVal Value As String)
            _USUARIO_CREA = Value
            OnPropertyChanged("USUARIO_CREA")
        End Set
    End Property

    Private _FECHA_CREA As DateTime
    <Column(Name:="FECHA_CREA", Storage:="FECHA_CREA", DBType:="DateTime NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property FECHA_CREA() As DateTime
        Get
            Return _FECHA_CREA
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_CREA = Value
            OnPropertyChanged("FECHA_CREA")
        End Set
    End Property

    Private _USUARIO_ACT As String
    <Column(Name:="USUARIO_ACT", Storage:="USUARIO_ACT", DBType:="VARCHAR(1000) NULL", Id:=False),
     DataObjectField(False, False, True, 1000)>
    Public Property USUARIO_ACT() As String
        Get
            Return _USUARIO_ACT
        End Get
        Set(ByVal Value As String)
            _USUARIO_ACT = Value
            OnPropertyChanged("USUARIO_ACT")
        End Set
    End Property

    Private _FECHA_ACT As DateTime
    <Column(Name:="FECHA_ACT", Storage:="FECHA_ACT", DBType:="DateTime NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property FECHA_ACT() As DateTime
        Get
            Return _FECHA_ACT
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_ACT = Value
            OnPropertyChanged("FECHA_ACT")
        End Set
    End Property
End Class
