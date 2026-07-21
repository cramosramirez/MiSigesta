<Serializable(), Table(Name:="SOLIC_ANTICIPO_FRENTE")>
Public Class SOLIC_ANTICIPO_FRENTE
    Inherits entidadBase

    Public Sub New()
    End Sub

    Private _ID_ANTICIPO As Int32
    <Column(Name:="ID_ANTICIPO", Storage:="ID_ANTICIPO", DBType:="INT NOT NULL", Id:=True),
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)>
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

    Private _ZAFRA As String
    <Column(Name:="ZAFRA", Storage:="ZAFRA", DBType:="VARCHAR(9) NOT NULL", Id:=False),
     DataObjectField(False, False, True, 9)>
    Public Property ZAFRA() As String
        Get
            Return _ZAFRA
        End Get
        Set(ByVal Value As String)
            _ZAFRA = Value
            OnPropertyChanged("ZAFRA")
        End Set
    End Property

    Private _ID_TIPO_PROVEEDOR As Int32
    <Column(Name:="ID_TIPO_PROVEEDOR", Storage:="ID_TIPO_PROVEEDOR", DBType:="INT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property ID_TIPO_PROVEEDOR() As Int32
        Get
            Return _ID_TIPO_PROVEEDOR
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_PROVEEDOR = Value
            OnPropertyChanged("ID_TIPO_PROVEEDOR")
        End Set
    End Property

    Private _ID_FRENTE As Int32
    <Column(Name:="ID_FRENTE", Storage:="ID_FRENTE", DBType:="INT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property ID_FRENTE() As Int32
        Get
            Return _ID_FRENTE
        End Get
        Set(ByVal Value As Int32)
            _ID_FRENTE = Value
            OnPropertyChanged("ID_FRENTE")
        End Set
    End Property

    Private _COD_FRENTE As String
    <Column(Name:="COD_FRENTE", Storage:="COD_FRENTE", DBType:="VARCHAR(30) NULL", Id:=False),
     DataObjectField(False, False, True, 30)>
    Public Property COD_FRENTE() As String
        Get
            Return _COD_FRENTE
        End Get
        Set(ByVal Value As String)
            _COD_FRENTE = Value
            OnPropertyChanged("COD_FRENTE")
        End Set
    End Property

    Private _NOM_FRENTE As String
    <Column(Name:="NOM_FRENTE", Storage:="NOM_FRENTE", DBType:="VARCHAR(100) NULL", Id:=False),
     DataObjectField(False, False, True, 100)>
    Public Property NOM_FRENTE() As String
        Get
            Return _NOM_FRENTE
        End Get
        Set(ByVal Value As String)
            _NOM_FRENTE = Value
            OnPropertyChanged("NOM_FRENTE")
        End Set
    End Property

    Private _NUM_ANTICIPO As Int32
    <Column(Name:="NUM_ANTICIPO", Storage:="NUM_ANTICIPO", DBType:="INT NOT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property NUM_ANTICIPO() As Int32
        Get
            Return _NUM_ANTICIPO
        End Get
        Set(ByVal Value As Int32)
            _NUM_ANTICIPO = Value
            OnPropertyChanged("NUM_ANTICIPO")
        End Set
    End Property

    Private _FECHA As DateTime
    <Column(Name:="FECHA", Storage:="FECHA", DBType:="DATETIME NOT NULL", Id:=False)>
    Public Property FECHA() As DateTime
        Get
            Return _FECHA
        End Get
        Set(ByVal Value As DateTime)
            _FECHA = Value
            OnPropertyChanged("FECHA")
        End Set
    End Property

    Private _CONCEPTO As String
    <Column(Name:="CONCEPTO", Storage:="CONCEPTO", DBType:="VARCHAR(3000) NOT NULL", Id:=False),
     DataObjectField(False, False, True, 3000)>
    Public Property CONCEPTO() As String
        Get
            Return _CONCEPTO
        End Get
        Set(ByVal Value As String)
            _CONCEPTO = Value
            OnPropertyChanged("CONCEPTO")
        End Set
    End Property

    Private _MONTO As Decimal
    <Column(Name:="MONTO", Storage:="MONTO", DBType:="NUMERIC(20,2) NOT NULL", Id:=False),
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

    Private _UID_ANTICIPO As Guid
    <Column(Name:="UID_ANTICIPO", Storage:="UID_ANTICIPO", DBType:="UNIQUEIDENTIFIER NULL", Id:=False),
    DataObjectField(False, False, True, 16)>
    Public Property UID_ANTICIPO() As Guid
        Get
            Return _UID_ANTICIPO
        End Get
        Set(ByVal Value As Guid)
            _UID_ANTICIPO = Value
            OnPropertyChanged("UID_ANTICIPO")
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
    <Column(Name:="FECHA_CREA", Storage:="FECHA_CREA", DBType:="DATETIME NOT NULL", Id:=False)>
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
    <Column(Name:="USUARIO_ACT", Storage:="USUARIO_ACT", DBType:="VARCHAR(100) NOT NULL", Id:=False),
     DataObjectField(False, False, True, 100)>
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
    <Column(Name:="FECHA_ACT", Storage:="FECHA_ACT", DBType:="DATETIME NOT NULL", Id:=False)>
    Public Property FECHA_ACT() As DateTime
        Get
            Return _FECHA_ACT
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_ACT = Value
            OnPropertyChanged("FECHA_ACT")
        End Set
    End Property

    Private _FECHA_CHEQUE As DateTime
    <Column(Name:="FECHA_CHEQUE", Storage:="FECHA_CHEQUE", DBType:="DATETIME NULL", Id:=False)>
    Public Property FECHA_CHEQUE() As DateTime
        Get
            Return _FECHA_CHEQUE
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_CHEQUE = Value
            OnPropertyChanged("FECHA_CHEQUE")
        End Set
    End Property

    Private _PORC_INTERES As Decimal
    <Column(Name:="PORC_INTERES", Storage:="PORC_INTERES", DBType:="NUMERIC(10,2) NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)>
    Public Property PORC_INTERES() As Decimal
        Get
            Return _PORC_INTERES
        End Get
        Set(ByVal Value As Decimal)
            _PORC_INTERES = Value
            OnPropertyChanged("PORC_INTERES")
        End Set
    End Property

    Private _ES_ACEPTADA As Boolean
    <Column(Name:="ES_ACEPTADA", Storage:="ES_ACEPTADA", DBType:="BIT NULL", Id:=False)>
    Public Property ES_ACEPTADA() As Boolean
        Get
            Return _ES_ACEPTADA
        End Get
        Set(ByVal Value As Boolean)
            _ES_ACEPTADA = Value
            OnPropertyChanged("ES_ACEPTADA")
        End Set
    End Property

    Private _CHQ_NO As String
    <Column(Name:="CHQ_NO", Storage:="CHQ_NO", DBType:="VARCHAR(200) NULL", Id:=False),
     DataObjectField(False, False, True, 200)>
    Public Property CHQ_NO() As String
        Get
            Return _CHQ_NO
        End Get
        Set(ByVal Value As String)
            _CHQ_NO = Value
            OnPropertyChanged("CHQ_NO")
        End Set
    End Property

    Private _ID_CUENTA_FINAN As Int32
    <Column(Name:="ID_CUENTA_FINAN", Storage:="ID_CUENTA_FINAN", DBType:="INT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property ID_CUENTA_FINAN() As Int32
        Get
            Return _ID_CUENTA_FINAN
        End Get
        Set(ByVal Value As Int32)
            _ID_CUENTA_FINAN = Value
            OnPropertyChanged("ID_CUENTA_FINAN")
        End Set
    End Property

    Private _PLAZO_MESES As Int32
    <Column(Name:="PLAZO_MESES", Storage:="PLAZO_MESES", DBType:="INT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property PLAZO_MESES() As Int32
        Get
            Return _PLAZO_MESES
        End Get
        Set(ByVal Value As Int32)
            _PLAZO_MESES = Value
            OnPropertyChanged("PLAZO_MESES")
        End Set
    End Property

    Private _FECHA_VENCE As DateTime
    <Column(Name:="FECHA_VENCE", Storage:="FECHA_VENCE", DBType:="DATETIME NULL", Id:=False)>
    Public Property FECHA_VENCE() As DateTime
        Get
            Return _FECHA_VENCE
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_VENCE = Value
            OnPropertyChanged("FECHA_VENCE")
        End Set
    End Property

    Private _ID_ESTADO As Int32
    <Column(Name:="ID_ESTADO", Storage:="ID_ESTADO", DBType:="INT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property ID_ESTADO() As Int32
        Get
            Return _ID_ESTADO
        End Get
        Set(ByVal Value As Int32)
            _ID_ESTADO = Value
            OnPropertyChanged("ID_ESTADO")
        End Set
    End Property

    Private _PERFECHA_INI As DateTime
    <Column(Name:="PERFECHA_INI", Storage:="PERFECHA_INI", DBType:="DATETIME NULL", Id:=False)>
    Public Property PERFECHA_INI() As DateTime
        Get
            Return _PERFECHA_INI
        End Get
        Set(ByVal Value As DateTime)
            _PERFECHA_INI = Value
            OnPropertyChanged("PERFECHA_INI")
        End Set
    End Property

    Private _PERFECHA_FIN As DateTime
    <Column(Name:="PERFECHA_FIN", Storage:="PERFECHA_FIN", DBType:="DATETIME NULL", Id:=False)>
    Public Property PERFECHA_FIN() As DateTime
        Get
            Return _PERFECHA_FIN
        End Get
        Set(ByVal Value As DateTime)
            _PERFECHA_FIN = Value
            OnPropertyChanged("PERFECHA_FIN")
        End Set
    End Property

    Private _DESTINO As String
    <Column(Name:="DESTINO", Storage:="DESTINO", DBType:="VARCHAR(100) NULL", Id:=False),
     DataObjectField(False, False, True, 100)>
    Public Property DESTINO() As String
        Get
            Return _DESTINO
        End Get
        Set(ByVal Value As String)
            _DESTINO = Value
            OnPropertyChanged("DESTINO")
        End Set
    End Property

    Private _CUOTA_X_CORTE As Decimal
    <Column(Name:="CUOTA_X_CORTE", Storage:="MONTO", DBType:="NUMERIC(20,2) NOT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)>
    Public Property CUOTA_X_CORTE() As Decimal
        Get
            Return _CUOTA_X_CORTE
        End Get
        Set(ByVal Value As Decimal)
            _CUOTA_X_CORTE = Value
            OnPropertyChanged("CUOTA_X_CORTE")
        End Set
    End Property

End Class
