<Serializable(), Table(Name:="SOLIC_ENCA_FRENTE")>
Public Class SOLIC_ENCA_FRENTE
    Inherits entidadBase

    Public Sub New()
    End Sub

    Private _ID_SOLICITUD As Int32
    <Column(Name:="ID_SOLICITUD", Storage:="ID_SOLICITUD", DBType:="INT NOT NULL", Id:=True),
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property ID_SOLICITUD() As Int32
        Get
            Return _ID_SOLICITUD
        End Get
        Set(ByVal Value As Int32)
            _ID_SOLICITUD = Value
            OnPropertyChanged("ID_SOLICITUD")
        End Set
    End Property

    Private _ID_ZAFRA As Int32
    <Column(Name:="ID_ZAFRA", Storage:="ID_ZAFRA", DBType:="INT NULL", Id:=False),
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
    <Column(Name:="ZAFRA", Storage:="ZAFRA", DBType:="VARCHAR(10) NULL", Id:=False),
     DataObjectField(False, False, True, 10)>
    Public Property ZAFRA() As String
        Get
            Return _ZAFRA
        End Get
        Set(ByVal Value As String)
            _ZAFRA = Value
            OnPropertyChanged("ZAFRA")
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

    Private _NUM_SOLIC_ZAFRA As Int32
    <Column(Name:="NUM_SOLIC_ZAFRA", Storage:="NUM_SOLIC_ZAFRA", DBType:="INT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property NUM_SOLIC_ZAFRA() As Int32
        Get
            Return _NUM_SOLIC_ZAFRA
        End Get
        Set(ByVal Value As Int32)
            _NUM_SOLIC_ZAFRA = Value
            OnPropertyChanged("NUM_SOLIC_ZAFRA")
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

    Private _ACTIVIDAD As String
    <Column(Name:="ACTIVIDAD", Storage:="ACTIVIDAD", DBType:="VARCHAR(100) NULL", Id:=False),
     DataObjectField(False, False, True, 100)>
    Public Property ACTIVIDAD() As String
        Get
            Return _ACTIVIDAD
        End Get
        Set(ByVal Value As String)
            _ACTIVIDAD = Value
            OnPropertyChanged("ACTIVIDAD")
        End Set
    End Property

    Private _FECHA_SOLIC As DateTime
    <Column(Name:="FECHA_SOLIC", Storage:="FECHA_SOLIC", DBType:="DATETIME NULL", Id:=False),
     DataObjectField(False, False, False)>
    Public Property FECHA_SOLIC() As DateTime
        Get
            Return _FECHA_SOLIC
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_SOLIC = Value
            OnPropertyChanged("FECHA_SOLIC")
        End Set
    End Property

    Private _SUB_TOTAL As Decimal
    <Column(Name:="SUB_TOTAL", Storage:="SUB_TOTAL", DBType:="NUMERIC(20,2) NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)>
    Public Property SUB_TOTAL() As Decimal
        Get
            Return _SUB_TOTAL
        End Get
        Set(ByVal Value As Decimal)
            _SUB_TOTAL = Value
            OnPropertyChanged("SUB_TOTAL")
        End Set
    End Property

    Private _IVA As Decimal
    <Column(Name:="IVA", Storage:="IVA", DBType:="NUMERIC(20,2) NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)>
    Public Property IVA() As Decimal
        Get
            Return _IVA
        End Get
        Set(ByVal Value As Decimal)
            _IVA = Value
            OnPropertyChanged("IVA")
        End Set
    End Property

    Private _TOTAL As Decimal
    <Column(Name:="TOTAL", Storage:="TOTAL", DBType:="NUMERIC(20,2) NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)>
    Public Property TOTAL() As Decimal
        Get
            Return _TOTAL
        End Get
        Set(ByVal Value As Decimal)
            _TOTAL = Value
            OnPropertyChanged("TOTAL")
        End Set
    End Property

    Private _ID_ESTADO_SOLIC As Int32
    <Column(Name:="ID_ESTADO_SOLIC", Storage:="ID_ESTADO_SOLIC", DBType:="INT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property ID_ESTADO_SOLIC() As Int32
        Get
            Return _ID_ESTADO_SOLIC
        End Get
        Set(ByVal Value As Int32)
            _ID_ESTADO_SOLIC = Value
            OnPropertyChanged("ID_ESTADO_SOLIC")
        End Set
    End Property

    Private _UID_SOLIC_ENCA_FRENTE As Guid
    <Column(Name:="UID_SOLIC_ENCA_FRENTE", Storage:="UID_SOLIC_ENCA_FRENTE", DBType:="UNIQUEIDENTIFIER(36, 0)", Id:=False),
         DataObjectField(False, False, True, 36)>
    Public Property UID_SOLIC_ENCA_FRENTE() As Guid
        Get
            Return _UID_SOLIC_ENCA_FRENTE
        End Get
        Set(ByVal Value As Guid)
            _UID_SOLIC_ENCA_FRENTE = Value
            OnPropertyChanged("UID_SOLIC_ENCA_FRENTE")
        End Set
    End Property

    Private _OBSERVACIONES As String
    <Column(Name:="OBSERVACIONES", Storage:="OBSERVACIONES", DBType:="VARCHAR(1000) NULL", Id:=False),
     DataObjectField(False, False, True, 1000)>
    Public Property OBSERVACIONES() As String
        Get
            Return _OBSERVACIONES
        End Get
        Set(ByVal Value As String)
            _OBSERVACIONES = Value
            OnPropertyChanged("OBSERVACIONES")
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
    <Column(Name:="FECHA_CREA", Storage:="FECHA_CREA", DBType:="DATETIME NULL", Id:=False),
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

    Private _USUARIO_ACT As String
    <Column(Name:="USUARIO_ACT", Storage:="USUARIO_ACT", DBType:="VARCHAR(100) NULL", Id:=False),
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
    <Column(Name:="FECHA_ACT", Storage:="FECHA_ACT", DBType:="DATETIME NULL", Id:=False),
    DataObjectField(False, False, False)>
    Public Property FECHA_ACT() As DateTime
        Get
            Return _FECHA_ACT
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_ACT = Value
            OnPropertyChanged("FECHA_ACT")
        End Set
    End Property

    Private _CUOTA_X_CORTE As Decimal
    <Column(Name:="CUOTA_X_CORTE", Storage:="CUOTA_X_CORTE", DBType:="NUMERIC(20,2) NULL", Id:=False),
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