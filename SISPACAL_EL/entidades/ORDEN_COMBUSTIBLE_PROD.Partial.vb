Partial Public Class ORDEN_COMBUSTIBLE_PROD
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

    Private _TOTAL As Decimal
    Public Property TOTAL() As Decimal
        Get
            Return _TOTAL
        End Get
        Set(ByVal Value As Decimal)
            _TOTAL = Value
            OnPropertyChanged("TOTAL")
        End Set
    End Property

    Private _CANTIDAD As Decimal
    <Column(Name:="Cantidad", Storage:="CANTIDAD", DbType:="NUMERIC(10,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)> _
    Public Property CANTIDAD() As Decimal
        Get
            Return _CANTIDAD
        End Get
        Set(ByVal Value As Decimal)
            _CANTIDAD = Value
            Me.TOTAL = Math.Round(PRECIO_VENTA * CANTIDAD, 2)
            OnPropertyChanged("CANTIDAD")
        End Set
    End Property

    Private _CANTIDADOld As Decimal
    Public Property CANTIDADOld() As Decimal
        Get
            Return _CANTIDADOld
        End Get
        Set(ByVal Value As Decimal)
            _CANTIDADOld = Value
        End Set
    End Property

    Private _PRECIO_VENTA As Decimal
    <Column(Name:="Precio venta", Storage:="PRECIO_VENTA", DbType:="NUMERIC(10,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)> _
    Public Property PRECIO_VENTA() As Decimal
        Get
            Return _PRECIO_VENTA
        End Get
        Set(ByVal Value As Decimal)
            _PRECIO_VENTA = Value
            Me.TOTAL = Math.Round(PRECIO_VENTA * CANTIDAD, 2)
            OnPropertyChanged("PRECIO_VENTA")
        End Set
    End Property

    Private _PRECIO_VENTAOld As Decimal
    Public Property PRECIO_VENTAOld() As Decimal
        Get
            Return _PRECIO_VENTAOld
        End Get
        Set(ByVal Value As Decimal)
            _PRECIO_VENTAOld = Value
        End Set
    End Property

End Class
