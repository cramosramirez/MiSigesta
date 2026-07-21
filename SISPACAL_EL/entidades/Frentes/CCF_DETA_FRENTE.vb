<Serializable(), Table(Name:="CCF_DETA_FRENTE")>
Public Class CCF_DETA_FRENTE
    Inherits entidadBase

    Public Sub New()
    End Sub

    Private _ID_CCF_DETA As Int32
    <Column(Name:="ID_CCF_DETA", Storage:="ID_CCF_DETA", DBType:="INT NOT NULL", Id:=True),
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property ID_CCF_DETA() As Int32
        Get
            Return _ID_CCF_DETA
        End Get
        Set(ByVal Value As Int32)
            _ID_CCF_DETA = Value
            OnPropertyChanged("ID_CCF_DETA")
        End Set
    End Property

    Private _ID_CCF_ENCA As Int32?
    <Column(Name:="ID_CCF_ENCA", Storage:="ID_CCF_ENCA", DBType:="INT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property ID_CCF_ENCA() As Int32?
        Get
            Return _ID_CCF_ENCA
        End Get
        Set(ByVal Value As Int32?)
            _ID_CCF_ENCA = Value
            OnPropertyChanged("ID_CCF_ENCA")
        End Set
    End Property

    Private _ID_PRODUCTO As Int32?
    <Column(Name:="ID_PRODUCTO", Storage:="ID_PRODUCTO", DBType:="INT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property ID_PRODUCTO() As Int32?
        Get
            Return _ID_PRODUCTO
        End Get
        Set(ByVal Value As Int32?)
            _ID_PRODUCTO = Value
            OnPropertyChanged("ID_PRODUCTO")
        End Set
    End Property

    Private _NOMBRE_PRODUCTO As String
    <Column(Name:="NOMBRE_PRODUCTO", Storage:="NOMBRE_PRODUCTO", DBType:="VARCHAR(200) NULL", Id:=False),
     DataObjectField(False, False, True, 200)>
    Public Property NOMBRE_PRODUCTO() As String
        Get
            Return _NOMBRE_PRODUCTO
        End Get
        Set(ByVal Value As String)
            _NOMBRE_PRODUCTO = Value
            OnPropertyChanged("NOMBRE_PRODUCTO")
        End Set
    End Property

    Private _PRESENTACION As String
    <Column(Name:="PRESENTACION", Storage:="PRESENTACION", DBType:="VARCHAR(50) NULL", Id:=False),
     DataObjectField(False, False, True, 50)>
    Public Property PRESENTACION() As String
        Get
            Return _PRESENTACION
        End Get
        Set(ByVal Value As String)
            _PRESENTACION = Value
            OnPropertyChanged("PRESENTACION")
        End Set
    End Property

    Private _CANTIDAD As Decimal?
    <Column(Name:="CANTIDAD", Storage:="CANTIDAD", DBType:="NUMERIC(10,4) NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=4)>
    Public Property CANTIDAD() As Decimal?
        Get
            Return _CANTIDAD
        End Get
        Set(ByVal Value As Decimal?)
            _CANTIDAD = Value
            OnPropertyChanged("CANTIDAD")
        End Set
    End Property

    Private _PRECIO_UNITARIO As Decimal?
    <Column(Name:="PRECIO_UNITARIO", Storage:="PRECIO_UNITARIO", DBType:="NUMERIC(10,4) NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=4)>
    Public Property PRECIO_UNITARIO() As Decimal?
        Get
            Return _PRECIO_UNITARIO
        End Get
        Set(ByVal Value As Decimal?)
            _PRECIO_UNITARIO = Value
            OnPropertyChanged("PRECIO_UNITARIO")
        End Set
    End Property

    Private _TOTAL As Decimal?
    <Column(Name:="TOTAL", Storage:="TOTAL", DBType:="NUMERIC(10,4) NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=4)>
    Public Property TOTAL() As Decimal?
        Get
            Return _TOTAL
        End Get
        Set(ByVal Value As Decimal?)
            _TOTAL = Value
            OnPropertyChanged("TOTAL")
        End Set
    End Property

    Private _REFERENCIA As String
    Public Property REFERENCIA() As String
        Get
            Return _REFERENCIA
        End Get
        Set(ByVal Value As String)
            _REFERENCIA = Value
            OnPropertyChanged("REFERENCIA")
        End Set
    End Property
End Class
