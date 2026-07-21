<Serializable(), Table(Name:="ENVIO_ROZA_PS")> Public Class ENVIO_ROZA_PS
    Inherits entidadBase


    Public Sub New()
    End Sub

    Public Sub New(aID_ENVIO_ROZA As Int32, aID_ENVIO As Int32, aID_TIPO_ROZA_P As Int32, aID_PROVEEDOR_ROZA_P As Int32, aID_TIPO_ROZA_S As Int32, aID_PROVEEDOR_ROZA_S As Int32, aTARIFA_ROZA As Decimal)
        Me._ID_ENVIO_ROZA = aID_ENVIO_ROZA
        Me._ID_ENVIO = aID_ENVIO
        Me._ID_TIPO_ROZA_P = aID_TIPO_ROZA_P
        Me._ID_PROVEEDOR_ROZA_P = aID_PROVEEDOR_ROZA_P
        Me._ID_TIPO_ROZA_S = aID_TIPO_ROZA_S
        Me._ID_PROVEEDOR_ROZA_S = aID_PROVEEDOR_ROZA_S
        Me._TARIFA_ROZA = aTARIFA_ROZA
    End Sub


    Private _ID_ENVIO_ROZA As Int32
    <Column(Name:="Id envio roza", Storage:="ID_ENVIO_ROZA", DBType:="INT NOT NULL", Id:=True),
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property ID_ENVIO_ROZA() As Int32
        Get
            Return _ID_ENVIO_ROZA
        End Get
        Set(ByVal Value As Int32)
            _ID_ENVIO_ROZA = Value
            OnPropertyChanged("ID_ENVIO_ROZA")
        End Set
    End Property

    Private _ID_ENVIO As Int32
    <Column(Name:="Id envio", Storage:="ID_ENVIO", DBType:="INT", Id:=False),
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)>
    Public Property ID_ENVIO() As Int32
        Get
            Return _ID_ENVIO
        End Get
        Set(ByVal Value As Int32)
            _ID_ENVIO = Value
            OnPropertyChanged("ID_ENVIO")
        End Set
    End Property

    Private _ID_TIPO_ROZA_P As Int32
    <Column(Name:="Id tipo roza p", Storage:="ID_TIPO_ROZA_P", DBType:="INT", Id:=False),
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)>
    Public Property ID_TIPO_ROZA_P() As Int32
        Get
            Return _ID_TIPO_ROZA_P
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_ROZA_P = Value
            OnPropertyChanged("ID_TIPO_ROZA_P")
        End Set
    End Property

    Private _ID_PROVEEDOR_ROZA_P As Int32
    <Column(Name:="Id proveedor roza p", Storage:="ID_PROVEEDOR_ROZA_P", DBType:="INT", Id:=False),
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)>
    Public Property ID_PROVEEDOR_ROZA_P() As Int32
        Get
            Return _ID_PROVEEDOR_ROZA_P
        End Get
        Set(ByVal Value As Int32)
            _ID_PROVEEDOR_ROZA_P = Value
            OnPropertyChanged("ID_PROVEEDOR_ROZA_P")
        End Set
    End Property

    Private _ID_TIPO_ROZA_S As Int32
    <Column(Name:="Id tipo roza s", Storage:="ID_TIPO_ROZA_S", DBType:="INT", Id:=False),
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)>
    Public Property ID_TIPO_ROZA_S() As Int32
        Get
            Return _ID_TIPO_ROZA_S
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_ROZA_S = Value
            OnPropertyChanged("ID_TIPO_ROZA_S")
        End Set
    End Property

    Private _ID_PROVEEDOR_ROZA_S As Int32
    <Column(Name:="Id proveedor roza s", Storage:="ID_PROVEEDOR_ROZA_S", DBType:="INT", Id:=False),
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)>
    Public Property ID_PROVEEDOR_ROZA_S() As Int32
        Get
            Return _ID_PROVEEDOR_ROZA_S
        End Get
        Set(ByVal Value As Int32)
            _ID_PROVEEDOR_ROZA_S = Value
            OnPropertyChanged("ID_PROVEEDOR_ROZA_S")
        End Set
    End Property

    Private _TARIFA_ROZA As Decimal
    <Column(Name:="Tarifa roza", Storage:="TARIFA_ROZA", DBType:="NUMERIC(10,4) NOT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=4)>
    Public Property TARIFA_ROZA() As Decimal
        Get
            Return _TARIFA_ROZA
        End Get
        Set(ByVal Value As Decimal)
            _TARIFA_ROZA = Value
            OnPropertyChanged("TARIFA_ROZA")
        End Set
    End Property
End Class
