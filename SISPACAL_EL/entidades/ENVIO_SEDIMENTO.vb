<Serializable(), Table(Name:="ENVIO_SEDIMENTO")> Public Class ENVIO_SEDIMENTO
    Inherits entidadBase

    Public Sub New()
    End Sub

    Private _ID_ENVIO_SEDI As Int32
    <Column(Name:="ID_ENVIO_SEDI", Storage:="ID_ENVIO_SEDI", DBType:="INT NULL", Id:=True),
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property ID_ENVIO_SEDI() As Int32
        Get
            Return _ID_ENVIO_SEDI
        End Get
        Set(ByVal Value As Int32)
            _ID_ENVIO_SEDI = Value
            OnPropertyChanged("ID_ENVIO_SEDI")
        End Set
    End Property

    Private _ID_ENVIO As Int32
    <Column(Name:="ID_ENVIO", Storage:="ID_ENVIO", DBType:="INT NULL", Id:=True),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property ID_ENVIO() As Int32
        Get
            Return _ID_ENVIO
        End Get
        Set(ByVal Value As Int32)
            _ID_ENVIO = Value
            OnPropertyChanged("ID_ENVIO")
        End Set
    End Property


    Private _VOL_SEDIMENTO As Decimal
    <Column(Name:="VOL_SEDIMENTO", Storage:="VOL_SEDIMENTO", DBType:="NUMWERIC(10,2)", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)>
    Public Property VOL_SEDIMENTO() As Decimal
        Get
            Return _VOL_SEDIMENTO
        End Get
        Set(ByVal Value As Decimal)
            _VOL_SEDIMENTO = Value
            OnPropertyChanged("VOL_SEDIMENTO")
        End Set
    End Property

    Private _SEDIMENTO As Decimal
    <Column(Name:="SEDIMENTO", Storage:="SEDIMENTO", DBType:="NUMWERIC(10,2)", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)>
    Public Property SEDIMENTO() As Decimal
        Get
            Return _SEDIMENTO
        End Get
        Set(ByVal Value As Decimal)
            _SEDIMENTO = Value
            OnPropertyChanged("SEDIMENTO")
        End Set
    End Property

    Private _USUARIO_CREA As String
    <Column(Name:="USUARIO_CREA", Storage:="USUARIO_CREA", DBType:="VARCHAR(100) NULL", Id:=False),
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

End Class
