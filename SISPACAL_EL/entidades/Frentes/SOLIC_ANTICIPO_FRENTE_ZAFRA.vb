<Serializable(), Table(Name:="SOLIC_ANTICIPO_FRENTE_ZAFRA")>
Public Class SOLIC_ANTICIPO_FRENTE_ZAFRA
    Inherits entidadBase

    Public Sub New()
    End Sub

    Private _ID_ANTI_ZAFRA As Int32
    <Column(Name:="ID_ANTI_ZAFRA", Storage:="ID_ANTI_ZAFRA", DBType:="INT NOT NULL", Id:=True),
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property ID_ANTI_ZAFRA() As Int32
        Get
            Return _ID_ANTI_ZAFRA
        End Get
        Set(ByVal Value As Int32)
            _ID_ANTI_ZAFRA = Value
            OnPropertyChanged("ID_ANTI_ZAFRA")
        End Set
    End Property

    Private _ID_ANTICIPO As Int32
    <Column(Name:="ID_ANTICIPO", Storage:="ID_ANTICIPO", DBType:="INT NOT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property ID_ANTICIPO() As Int32
        Get
            Return _ID_ANTICIPO
        End Get
        Set(ByVal Value As Int32)
            _ID_ANTICIPO = Value
            OnPropertyChanged("ID_ANTICIPO")
        End Set
    End Property

    Private _ID_ZAFRA As Int32
    <Column(Name:="ID_ZAFRA", Storage:="ID_ZAFRA", DBType:="INT NOT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property ID_ZAFRA() As Int32
        Get
            Return _ID_ZAFRA
        End Get
        Set(ByVal Value As Int32)
            _ID_ZAFRA = Value
            OnPropertyChanged("ID_ZAFRA")
        End Set
    End Property

    Private _FECHA_ULTMOV As DateTime
    <Column(Name:="FECHA_ULTMOV", Storage:="FECHA_ULTMOV", DBType:="DATETIME NOT NULL", Id:=False)>
    Public Property FECHA_ULTMOV() As DateTime
        Get
            Return _FECHA_ULTMOV
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_ULTMOV = Value
            OnPropertyChanged("FECHA_ULTMOV")
        End Set
    End Property

    Private _CUOTA As Decimal
    <Column(Name:="CUOTA", Storage:="CUOTA", DBType:="NUMERIC(20,2) NOT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)>
    Public Property CUOTA() As Decimal
        Get
            Return _CUOTA
        End Get
        Set(ByVal Value As Decimal)
            _CUOTA = Value
            OnPropertyChanged("CUOTA")
        End Set
    End Property

    Private _USUARIO_CREA As String
    <Column(Name:="USUARIO_CREA", Storage:="USUARIO_CREA", DBType:="VARCHAR(100) NOT NULL", Id:=False),
     DataObjectField(False, False, True, 100)>
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
    <Column(Name:="FECHA_CREA", Storage:="FECHA_CREA", DBType:="DATETIME NOT NULL", Id:=False),
    DataObjectField(False, False, False)>
    Public Property FECHA_CREA() As DateTime
        Get
            Return _FECHA_CREA
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_CREA = Value
            OnPropertyChanged("FECHA_CREA")
        End Set
    End Property

End Class
