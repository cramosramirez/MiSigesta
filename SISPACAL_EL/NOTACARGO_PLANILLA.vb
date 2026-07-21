<Serializable(), Table(Name:="NOTACARGO_PLANILLA")> Public Class NOTACARGO_PLANILLA
    Inherits entidadBase

    Public Sub New()
    End Sub

    Private _ID_NOTACARGO As Int32
    <Column(Name:="ID_NOTACARGO", Storage:="ID_NOTACARGO", DBType:="INT NOT NULL", Id:=True),
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property ID_NOTACARGO() As Int32
        Get
            Return _ID_NOTACARGO
        End Get
        Set(ByVal Value As Int32)
            _ID_NOTACARGO = Value
            OnPropertyChanged("ID_NOTACARGO")
        End Set
    End Property

    Private _MONTO As Decimal
    <Column(Name:="MONTO", Storage:="MONTO", DBType:="NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)>
    Public Property MONTO() As Decimal
        Get
            Return _MONTO
        End Get
        Set(ByVal Value As Decimal)
            _MONTO = Value
            OnPropertyChanged("MONTO")
        End Set
    End Property

    Private _CANTIDAD_LETRAS As String
    <Column(Name:="CANTIDAD_LETRAS", Storage:="CANTIDAD_LETRAS", DBType:="VARCHAR(200) NULL", Id:=False),
     DataObjectField(False, False, True, 200)>
    Public Property CANTIDAD_LETRAS() As String
        Get
            Return _CANTIDAD_LETRAS
        End Get
        Set(ByVal Value As String)
            _CANTIDAD_LETRAS = Value
            OnPropertyChanged("CANTIDAD_LETRAS")
        End Set
    End Property

    Private _TITULAR As String
    <Column(Name:="TITULAR", Storage:="TITULAR", DBType:="VARCHAR(120) NULL", Id:=False),
     DataObjectField(False, False, True, 120)>
    Public Property TITULAR() As String
        Get
            Return _TITULAR
        End Get
        Set(ByVal Value As String)
            _TITULAR = Value
            OnPropertyChanged("TITULAR")
        End Set
    End Property

    Private _ESTADO As String
    <Column(Name:="ESTADO", Storage:="ESTADO", DBType:="CHAR(1) NULL", Id:=False),
     DataObjectField(False, False, True, 1)>
    Public Property ESTADO() As String
        Get
            Return _ESTADO
        End Get
        Set(ByVal Value As String)
            _ESTADO = Value
            OnPropertyChanged("ESTADO")
        End Set
    End Property

    Private _FECHA_EMISION As DateTime
    <Column(Name:="FECHA_EMISION", Storage:="FECHA_EMISION", DBType:="DateTime NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property FECHA_EMISION() As DateTime
        Get
            Return _FECHA_EMISION
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_EMISION = Value
            OnPropertyChanged("FECHA_EMISION")
        End Set
    End Property

    Private _FECHA_ANULACION As DateTime
    <Column(Name:="FECHA_ANULACION", Storage:="FECHA_ANULACION", DBType:="DateTime NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property FECHA_ANULACION() As DateTime
        Get
            Return _FECHA_ANULACION
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_ANULACION = Value
            OnPropertyChanged("FECHA_ANULACION")
        End Set
    End Property

    Private _MOTIVO_ANULACION As String
    <Column(Name:="MOTIVO_ANULACION", Storage:="MOTIVO_ANULACION", DBType:="VARCHAR(1000) NULL", Id:=False),
     DataObjectField(False, False, True, 1000)>
    Public Property MOTIVO_ANULACION() As String
        Get
            Return _MOTIVO_ANULACION
        End Get
        Set(ByVal Value As String)
            _MOTIVO_ANULACION = Value
            OnPropertyChanged("MOTIVO_ANULACION")
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

    Private _NO_PARTIDA_PH As Int32
    <Column(Name:="NO_PARTIDA_PH", Storage:="NO_PARTIDA_PH", DBType:="INT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property NO_PARTIDA_PH() As Int32
        Get
            Return _NO_PARTIDA_PH
        End Get
        Set(ByVal Value As Int32)
            _NO_PARTIDA_PH = Value
            OnPropertyChanged("NO_PARTIDA_PH")
        End Set
    End Property

    Private _ID_CATORCENA As Int32
    <Column(Name:="ID_CATORCENA", Storage:="ID_CATORCENA", DBType:="INT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property ID_CATORCENA() As Int32
        Get
            Return _ID_CATORCENA
        End Get
        Set(ByVal Value As Int32)
            _ID_CATORCENA = Value
            OnPropertyChanged("ID_CATORCENA")
        End Set
    End Property

    Private _ID_TIPO_PLANILLA As Int32
    <Column(Name:="ID_TIPO_PLANILLA", Storage:="ID_TIPO_PLANILLA", DBType:="INT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property ID_TIPO_PLANILLA() As Int32
        Get
            Return _ID_TIPO_PLANILLA
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_PLANILLA = Value
            OnPropertyChanged("ID_TIPO_PLANILLA")
        End Set
    End Property

    Private _CODIPROVEEDOR_TRANSPORTISTA As String
    <Column(Name:="CODIPROVEEDOR_TRANSPORTISTA", Storage:="CODIPROVEEDOR_TRANSPORTISTA", DBType:="VARCHAR(10) NULL", Id:=False),
     DataObjectField(False, False, True, 10)>
    Public Property CODIPROVEEDOR_TRANSPORTISTA() As String
        Get
            Return _CODIPROVEEDOR_TRANSPORTISTA
        End Get
        Set(ByVal Value As String)
            _CODIPROVEEDOR_TRANSPORTISTA = Value
            OnPropertyChanged("CODIPROVEEDOR_TRANSPORTISTA")
        End Set
    End Property

    Private _NUM_AUTORIZA_BCO As Int32
    <Column(Name:="NUM_AUTORIZA_BCO", Storage:="NUM_AUTORIZA_BCO", DBType:="INT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property NUM_AUTORIZA_BCO() As Int32
        Get
            Return _NUM_AUTORIZA_BCO
        End Get
        Set(ByVal Value As Int32)
            _NUM_AUTORIZA_BCO = Value
            OnPropertyChanged("NUM_AUTORIZA_BCO")
        End Set
    End Property

    Private _ID_CUENTA As Int32
    <Column(Name:="ID_CUENTA", Storage:="ID_CUENTA", DBType:="INT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property ID_CUENTA() As Int32
        Get
            Return _ID_CUENTA
        End Get
        Set(ByVal Value As Int32)
            _ID_CUENTA = Value
            OnPropertyChanged("ID_CUENTA")
        End Set
    End Property
End Class
