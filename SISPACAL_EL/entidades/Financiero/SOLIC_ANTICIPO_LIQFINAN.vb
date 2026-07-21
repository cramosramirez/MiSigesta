<Serializable(), Table(Name:="SOLIC_ANTICIPO_LIQFINAN")> Public Class SOLIC_ANTICIPO_LIQFINAN
    Inherits entidadBase

    Public Sub New()
    End Sub

    Private _ID_ANTI_LIQ As Int32
    <Column(Name:="ID_ANTI_LIQ", Storage:="ID_ANTI_LIQ", DBType:="INT NOT NULL", Id:=True),
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property ID_ANTI_LIQ() As Int32
        Get
            Return _ID_ANTI_LIQ
        End Get
        Set(ByVal Value As Int32)
            _ID_ANTI_LIQ = Value
            OnPropertyChanged("ID_ANTI_LIQ")
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


    Private _UID_REFERENCIA As String
    <Column(Name:="UID_REFERENCIA", Storage:="UID_REFERENCIA", DBType:="VARCHAR(100)", Id:=False),
     DataObjectField(False, False, True, 100)>
    Public Property UID_REFERENCIA() As String
        Get
            Return _UID_REFERENCIA
        End Get
        Set(ByVal Value As String)
            _UID_REFERENCIA = Value
            OnPropertyChanged("UID_REFERENCIA")
        End Set
    End Property

    Private _SALDO_INI As Decimal
    <Column(Name:="SALDO_INI", Storage:="SALDO_INI", DBType:="NUMERIC(20,4)", Id:=False),
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=4)>
    Public Property SALDO_INI() As Decimal
        Get
            Return _SALDO_INI
        End Get
        Set(ByVal Value As Decimal)
            _SALDO_INI = Value
            OnPropertyChanged("SALDO_INI")
        End Set
    End Property

    Private _INTERES As Decimal
    <Column(Name:="INTERES", Storage:="INTERES", DBType:="NUMERIC(20,4)", Id:=False),
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=4)>
    Public Property INTERES() As Decimal
        Get
            Return _INTERES
        End Get
        Set(ByVal Value As Decimal)
            _INTERES = Value
            OnPropertyChanged("INTERES")
        End Set
    End Property

    Private _INTERES_IVA As Decimal
    <Column(Name:="INTERES_IVA", Storage:="INTERES_IVA", DBType:="NUMERIC(20,4)", Id:=False),
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=4)>
    Public Property INTERES_IVA() As Decimal
        Get
            Return _INTERES_IVA
        End Get
        Set(ByVal Value As Decimal)
            _INTERES_IVA = Value
            OnPropertyChanged("INTERES_IVA")
        End Set
    End Property

    Private _ABONO As Decimal
    <Column(Name:="ABONO", Storage:="ABONO", DBType:="NUMERIC(20,4)", Id:=False),
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=4)>
    Public Property ABONO() As Decimal
        Get
            Return _ABONO
        End Get
        Set(ByVal Value As Decimal)
            _ABONO = Value
            OnPropertyChanged("ABONO")
        End Set
    End Property

    Private _INTERES_ABO As Decimal
    <Column(Name:="INTERES_ABO", Storage:="INTERES_ABO", DBType:="NUMERIC(20,4)", Id:=False),
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=4)>
    Public Property INTERES_ABO() As Decimal
        Get
            Return _INTERES_ABO
        End Get
        Set(ByVal Value As Decimal)
            _INTERES_ABO = Value
            OnPropertyChanged("INTERES_ABO")
        End Set
    End Property

    Private _INTERES_IVA_ABO As Decimal
    <Column(Name:="INTERES_IVA_ABO", Storage:="INTERES_IVA_ABO", DBType:="NUMERIC(20,4)", Id:=False),
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=4)>
    Public Property INTERES_IVA_ABO() As Decimal
        Get
            Return _INTERES_IVA_ABO
        End Get
        Set(ByVal Value As Decimal)
            _INTERES_IVA_ABO = Value
            OnPropertyChanged("INTERES_IVA_ABO")
        End Set
    End Property

    Private _SALDO_FIN As Decimal
    <Column(Name:="SALDO_FIN", Storage:="SALDO_FIN", DBType:="NUMERIC(20,4)", Id:=False),
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=4)>
    Public Property SALDO_FIN() As Decimal
        Get
            Return _SALDO_FIN
        End Get
        Set(ByVal Value As Decimal)
            _SALDO_FIN = Value
            OnPropertyChanged("SALDO_FIN")
        End Set
    End Property

End Class
