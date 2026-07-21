<Serializable(), Table(Name:="CREDITO_MOV_FRENTE")>
Public Class CREDITO_MOV_FRENTE
    Inherits entidadBase

    Public Sub New()
    End Sub

    Private _ID_CREDITO_MOV As Int32
    <Column(Name:="ID_CREDITO_MOV", Storage:="ID_CREDITO_MOV", DBType:="INT NOT NULL", Id:=True),
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property ID_CREDITO_MOV() As Int32
        Get
            Return _ID_CREDITO_MOV
        End Get
        Set(ByVal Value As Int32)
            _ID_CREDITO_MOV = Value
            OnPropertyChanged("ID_CREDITO_MOV")
        End Set
    End Property

    Private _ID_CREDITO_ENCA As Int32
    <Column(Name:="ID_CREDITO_ENCA", Storage:="ID_CREDITO_ENCA", DBType:="INT NOT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property ID_CREDITO_ENCA() As Int32
        Get
            Return _ID_CREDITO_ENCA
        End Get
        Set(ByVal Value As Int32)
            _ID_CREDITO_ENCA = Value
            OnPropertyChanged("ID_CREDITO_ENCA")
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

    Private _UID_REFERENCIA As Guid
    <Column(Name:="UID_REFERENCIA", Storage:="UID_REFERENCIA", DBType:="UNIQUEIDENTIFIER NOT NULL", Id:=False)>
    Public Property UID_REFERENCIA() As Guid
        Get
            Return _UID_REFERENCIA
        End Get
        Set(ByVal Value As Guid)
            _UID_REFERENCIA = Value
            OnPropertyChanged("UID_REFERENCIA")
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

    Private _CODIBANCO As Int32
    <Column(Name:="CODIBANCO", Storage:="CODIBANCO", DBType:="INT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property CODIBANCO() As Int32
        Get
            Return _CODIBANCO
        End Get
        Set(ByVal Value As Int32)
            _CODIBANCO = Value
            OnPropertyChanged("CODIBANCO")
        End Set
    End Property

    Private _NO_DOCUMENTO As String
    <Column(Name:="NO_DOCUMENTO", Storage:="NO_DOCUMENTO", DBType:="VARCHAR(150) NOT NULL", Id:=False),
     DataObjectField(False, False, True, 150)>
    Public Property NO_DOCUMENTO() As String
        Get
            Return _NO_DOCUMENTO
        End Get
        Set(ByVal Value As String)
            _NO_DOCUMENTO = Value
            OnPropertyChanged("NO_DOCUMENTO")
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

    Private _TASAINT As Decimal
    <Column(Name:="TASAINT", Storage:="TASAINT", DBType:="NUMERIC(20,4) NULL", Id:=False),
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

    Private _SALDO_INICIAL As Decimal
    <Column(Name:="SALDO_INICIAL", Storage:="SALDO_INICIAL", DBType:="NUMERIC(20,2) NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)>
    Public Property SALDO_INICIAL() As Decimal
        Get
            Return _SALDO_INICIAL
        End Get
        Set(ByVal Value As Decimal)
            _SALDO_INICIAL = Value
            OnPropertyChanged("SALDO_INICIAL")
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

    Private _PLAZO_DIAS As Int32
    <Column(Name:="PLAZO_DIAS", Storage:="PLAZO_DIAS", DBType:="INT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property PLAZO_DIAS() As Int32
        Get
            Return _PLAZO_DIAS
        End Get
        Set(ByVal Value As Int32)
            _PLAZO_DIAS = Value
            OnPropertyChanged("PLAZO_DIAS")
        End Set
    End Property

    Private _ID_PLANILLA_BASE As Int32
    <Column(Name:="ID_PLANILLA_BASE", Storage:="ID_PLANILLA_BASE", DBType:="INT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property ID_PLANILLA_BASE() As Int32
        Get
            Return _ID_PLANILLA_BASE
        End Get
        Set(ByVal Value As Int32)
            _ID_PLANILLA_BASE = Value
            OnPropertyChanged("ID_PLANILLA_BASE")
        End Set
    End Property

    Private _ID_CATORCENA_VTO As Int32
    <Column(Name:="ID_CATORCENA_VTO", Storage:="ID_CATORCENA_VTO", DBType:="INT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property ID_CATORCENA_VTO() As Int32
        Get
            Return _ID_CATORCENA_VTO
        End Get
        Set(ByVal Value As Int32)
            _ID_CATORCENA_VTO = Value
            OnPropertyChanged("ID_CATORCENA_VTO")
        End Set
    End Property

End Class
