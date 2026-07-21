<Serializable(), Table(Name:="CREDITO_ENCA_FRENTE")>
Public Class CREDITO_ENCA_FRENTE
    Inherits entidadBase

    Public Sub New()
    End Sub

    Private _ID_CREDITO_ENCA As Int32
    <Column(Name:="ID_CREDITO_ENCA", Storage:="ID_CREDITO_ENCA", DBType:="INT NOT NULL", Id:=True),
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property ID_CREDITO_ENCA() As Int32
        Get
            Return _ID_CREDITO_ENCA
        End Get
        Set(ByVal Value As Int32)
            _ID_CREDITO_ENCA = Value
            OnPropertyChanged("ID_CREDITO_ENCA")
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

    Private _ID_TIPO_COMPROB As Int32
    <Column(Name:="ID_TIPO_COMPROB", Storage:="ID_TIPO_COMPROB", DBType:="INT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property ID_TIPO_COMPROB() As Int32
        Get
            Return _ID_TIPO_COMPROB
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_COMPROB = Value
            OnPropertyChanged("ID_TIPO_COMPROB")
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

    Private _DESCRIP_FINAN As String
    <Column(Name:="DESCRIP_FINAN", Storage:="DESCRIP_FINAN", DBType:="VARCHAR(200) NULL", Id:=False),
     DataObjectField(False, False, True, 200)>
    Public Property DESCRIP_FINAN() As String
        Get
            Return _DESCRIP_FINAN
        End Get
        Set(ByVal Value As String)
            _DESCRIP_FINAN = Value
            OnPropertyChanged("DESCRIP_FINAN")
        End Set
    End Property

    Private _ID_PROVEE As Int32
    <Column(Name:="ID_PROVEE", Storage:="ID_PROVEE", DBType:="INT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property ID_PROVEE() As Int32
        Get
            Return _ID_PROVEE
        End Get
        Set(ByVal Value As Int32)
            _ID_PROVEE = Value
            OnPropertyChanged("ID_PROVEE")
        End Set
    End Property

    Private _FECHA As DateTime
    <Column(Name:="FECHA", Storage:="FECHA", DBType:="DATETIME NULL", Id:=False)>
    Public Property FECHA() As DateTime
        Get
            Return _FECHA
        End Get
        Set(ByVal Value As DateTime)
            _FECHA = Value
            OnPropertyChanged("FECHA")
        End Set
    End Property

    Private _NO_COMPROB As String
    <Column(Name:="NO_COMPROB", Storage:="NO_COMPROB", DBType:="VARCHAR(200) NULL", Id:=False),
     DataObjectField(False, False, True, 200)>
    Public Property NO_COMPROB() As String
        Get
            Return _NO_COMPROB
        End Get
        Set(ByVal Value As String)
            _NO_COMPROB = Value
            OnPropertyChanged("NO_COMPROB")
        End Set
    End Property

    Private _FECHA_APLIC As DateTime
    <Column(Name:="FECHA_APLIC", Storage:="FECHA_APLIC", DBType:="DATETIME NULL", Id:=False)>
    Public Property FECHA_APLIC() As DateTime
        Get
            Return _FECHA_APLIC
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_APLIC = Value
            OnPropertyChanged("FECHA_APLIC")
        End Set
    End Property

    Private _FECHA_ULTMOV As DateTime
    <Column(Name:="FECHA_ULTMOV", Storage:="FECHA_ULTMOV", DBType:="DATETIME NULL", Id:=False)>
    Public Property FECHA_ULTMOV() As DateTime
        Get
            Return _FECHA_ULTMOV
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_ULTMOV = Value
            OnPropertyChanged("FECHA_ULTMOV")
        End Set
    End Property

    Private _UID_REFERENCIA As Guid
    <Column(Name:="UID_REFERENCIA", Storage:="UID_REFERENCIA", DBType:="UNIQUEIDENTIFIER(36, 0)", Id:=False),
    DataObjectField(False, False, True, 36)>
    Public Property UID_REFERENCIA() As Guid
        Get
            Return _UID_REFERENCIA
        End Get
        Set(ByVal Value As Guid)
            _UID_REFERENCIA = Value
            OnPropertyChanged("UID_REFERENCIA")
        End Set
    End Property

    Private _TASAINT As Decimal
    <Column(Name:="TASAINT", Storage:="TASAINT", DBType:="NUMERIC(20,4) NOT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=4)>
    Public Property TASAINT() As Decimal
        Get
            Return _TASAINT
        End Get
        Set(ByVal Value As Decimal)
            _TASAINT = Value
            OnPropertyChanged("TASAINT")
        End Set
    End Property

    Private _CARGO As Decimal
    <Column(Name:="CARGO", Storage:="CARGO", DBType:="NUMERIC(20,4) NOT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=4)>
    Public Property CARGO() As Decimal
        Get
            Return _CARGO
        End Get
        Set(ByVal Value As Decimal)
            _CARGO = Value
            OnPropertyChanged("CARGO")
        End Set
    End Property

    Private _ABONO As Decimal
    <Column(Name:="ABONO", Storage:="ABONO", DBType:="NUMERIC(20,4) NOT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=4)>
    Public Property ABONO() As Decimal
        Get
            Return _ABONO
        End Get
        Set(ByVal Value As Decimal)
            _ABONO = Value
            OnPropertyChanged("ABONO")
        End Set
    End Property

    Private _SALDO As Decimal
    <Column(Name:="SALDO", Storage:="SALDO", DBType:="NUMERIC(20,4) NOT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=4)>
    Public Property SALDO() As Decimal
        Get
            Return _SALDO
        End Get
        Set(ByVal Value As Decimal)
            _SALDO = Value
            OnPropertyChanged("SALDO")
        End Set
    End Property

    Private _INTERES As Decimal
    <Column(Name:="INTERES", Storage:="INTERES", DBType:="NUMERIC(20,4) NOT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=4)>
    Public Property INTERES() As Decimal
        Get
            Return _INTERES
        End Get
        Set(ByVal Value As Decimal)
            _INTERES = Value
            OnPropertyChanged("INTERES")
        End Set
    End Property

    Private _IVA_INTERES As Decimal
    <Column(Name:="IVA_INTERES", Storage:="IVA_INTERES", DBType:="NUMERIC(20,4) NOT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=4)>
    Public Property IVA_INTERES() As Decimal
        Get
            Return _IVA_INTERES
        End Get
        Set(ByVal Value As Decimal)
            _IVA_INTERES = Value
            OnPropertyChanged("IVA_INTERES")
        End Set
    End Property

    Private _ABONO_IVA As Decimal
    <Column(Name:="ABONO_IVA", Storage:="ABONO_IVA", DBType:="NUMERIC(20,4) NOT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=4)>
    Public Property ABONO_IVA() As Decimal
        Get
            Return _ABONO_IVA
        End Get
        Set(ByVal Value As Decimal)
            _ABONO_IVA = Value
            OnPropertyChanged("ABONO_IVA")
        End Set
    End Property

    Private _ABONO_INTERES As Decimal
    <Column(Name:="ABONO_INTERES", Storage:="ABONO_INTERES", DBType:="NUMERIC(20,4) NOT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=4)>
    Public Property ABONO_INTERES() As Decimal
        Get
            Return _ABONO_INTERES
        End Get
        Set(ByVal Value As Decimal)
            _ABONO_INTERES = Value
            OnPropertyChanged("ABONO_INTERES")
        End Set
    End Property

    Private _ABONO_INTERES_IVA As Decimal
    <Column(Name:="ABONO_INTERES_IVA", Storage:="ABONO_INTERES_IVA", DBType:="NUMERIC(20,4) NOT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=4)>
    Public Property ABONO_INTERES_IVA() As Decimal
        Get
            Return _ABONO_INTERES_IVA
        End Get
        Set(ByVal Value As Decimal)
            _ABONO_INTERES_IVA = Value
            OnPropertyChanged("ABONO_INTERES_IVA")
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
    <Column(Name:="FECHA_ACT", Storage:="FECHA_ACT", DBType:="DATETIME NOT NULL", Id:=False),
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

    Private _TIPO_INTERES As String
    <Column(Name:="TIPO_INTERES", Storage:="TIPO_INTERES", DBType:="CHAR(1) NULL", Id:=False),
     DataObjectField(False, False, True, 1)>
    Public Property TIPO_INTERES() As String
        Get
            Return _TIPO_INTERES
        End Get
        Set(ByVal Value As String)
            _TIPO_INTERES = Value
            OnPropertyChanged("TIPO_INTERES")
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

    Private _CTA_CONTABLE As String
    <Column(Name:="CTA_CONTABLE", Storage:="CTA_CONTABLE", DBType:="VARCHAR(50)", Id:=False),
     DataObjectField(False, False, True, 50)>
    Public Property CTA_CONTABLE() As String
        Get
            Return _CTA_CONTABLE
        End Get
        Set(ByVal Value As String)
            _CTA_CONTABLE = Value
            OnPropertyChanged("CTA_CONTABLE")
        End Set
    End Property

End Class
