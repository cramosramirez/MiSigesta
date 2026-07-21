''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.SOLIC_PROD_TRANS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row SOLIC_PROD_TRANS en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	25/10/2017	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="SOLIC_PROD_TRANS")> Public Class SOLIC_PROD_TRANS
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_SOLIC_PROD_TRANS As Int32, aID_SOLICITUD As Int32, aID_PROVEE As Int32, aID_PRODUCTO As Int32, aNOMBRE_PRODUCTO As String, aPRESENTACION As String, aCANTIDAD As Decimal, aPRECIO_UNITARIO As Decimal, aSUB_TOTAL As Decimal)
        Me._ID_SOLIC_PROD_TRANS = aID_SOLIC_PROD_TRANS
        Me._ID_SOLICITUD = aID_SOLICITUD
        Me._ID_PROVEE = aID_PROVEE
        Me._ID_PRODUCTO = aID_PRODUCTO
        Me._NOMBRE_PRODUCTO = aNOMBRE_PRODUCTO
        Me._PRESENTACION = aPRESENTACION
        Me._CANTIDAD = aCANTIDAD
        Me._PRECIO_UNITARIO = aPRECIO_UNITARIO
        Me._SUB_TOTAL = aSUB_TOTAL
    End Sub

#Region " Properties "

    Private _ID_SOLIC_PROD_TRANS As Int32
    <Column(Name:="Id solic prod trans", Storage:="ID_SOLIC_PROD_TRANS", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_SOLIC_PROD_TRANS() As Int32
        Get
            Return _ID_SOLIC_PROD_TRANS
        End Get
        Set(ByVal Value As Int32)
            _ID_SOLIC_PROD_TRANS = Value
            OnPropertyChanged("ID_SOLIC_PROD_TRANS")
        End Set
    End Property

    Private _ID_SOLICITUD As Int32
    <Column(Name:="Id solicitud", Storage:="ID_SOLICITUD", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_SOLICITUD() As Int32
        Get
            Return _ID_SOLICITUD
        End Get
        Set(ByVal Value As Int32)
            _ID_SOLICITUD = Value
            OnPropertyChanged("ID_SOLICITUD")
        End Set
    End Property

    Private _ID_SOLICITUDOld As Int32
    Public Property ID_SOLICITUDOld() As Int32
        Get
            Return _ID_SOLICITUDOld
        End Get
        Set(ByVal Value As Int32)
            _ID_SOLICITUDOld = Value
        End Set
    End Property

    Private _fkID_SOLICITUD As SOLIC_ENCA_TRANS
    Public Property fkID_SOLICITUD() As SOLIC_ENCA_TRANS
        Get
            Return _fkID_SOLICITUD
        End Get
        Set(ByVal Value As SOLIC_ENCA_TRANS)
            _fkID_SOLICITUD = Value
        End Set
    End Property

    Private _ID_PROVEE As Int32
    <Column(Name:="Id provee", Storage:="ID_PROVEE", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_PROVEE() As Int32
        Get
            Return _ID_PROVEE
        End Get
        Set(ByVal Value As Int32)
            _ID_PROVEE = Value
            OnPropertyChanged("ID_PROVEE")
        End Set
    End Property

    Private _ID_PROVEEOld As Int32
    Public Property ID_PROVEEOld() As Int32
        Get
            Return _ID_PROVEEOld
        End Get
        Set(ByVal Value As Int32)
            _ID_PROVEEOld = Value
        End Set
    End Property

    Private _fkID_PROVEE As PROVEEDOR_AGRICOLA
    Public Property fkID_PROVEE() As PROVEEDOR_AGRICOLA
        Get
            Return _fkID_PROVEE
        End Get
        Set(ByVal Value As PROVEEDOR_AGRICOLA)
            _fkID_PROVEE = Value
        End Set
    End Property

    Private _ID_PRODUCTO As Int32
    <Column(Name:="Id producto", Storage:="ID_PRODUCTO", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_PRODUCTO() As Int32
        Get
            Return _ID_PRODUCTO
        End Get
        Set(ByVal Value As Int32)
            _ID_PRODUCTO = Value
            OnPropertyChanged("ID_PRODUCTO")
        End Set
    End Property

    Private _ID_PRODUCTOOld As Int32
    Public Property ID_PRODUCTOOld() As Int32
        Get
            Return _ID_PRODUCTOOld
        End Get
        Set(ByVal Value As Int32)
            _ID_PRODUCTOOld = Value
        End Set
    End Property

    Private _fkID_PRODUCTO As PRODUCTO
    Public Property fkID_PRODUCTO() As PRODUCTO
        Get
            Return _fkID_PRODUCTO
        End Get
        Set(ByVal Value As PRODUCTO)
            _fkID_PRODUCTO = Value
        End Set
    End Property

    Private _NOMBRE_PRODUCTO As String
    <Column(Name:="Nombre producto", Storage:="NOMBRE_PRODUCTO", DbType:="VARCHAR(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
    Public Property NOMBRE_PRODUCTO() As String
        Get
            Return _NOMBRE_PRODUCTO
        End Get
        Set(ByVal Value As String)
            _NOMBRE_PRODUCTO = Value
            OnPropertyChanged("NOMBRE_PRODUCTO")
        End Set
    End Property

    Private _NOMBRE_PRODUCTOOld As String
    Public Property NOMBRE_PRODUCTOOld() As String
        Get
            Return _NOMBRE_PRODUCTOOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_PRODUCTOOld = Value
        End Set
    End Property

    Private _PRESENTACION As String
    <Column(Name:="Presentacion", Storage:="PRESENTACION", DbType:="VARCHAR(50)", Id:=False), _
     DataObjectField(False, False, True, 50)> _
    Public Property PRESENTACION() As String
        Get
            Return _PRESENTACION
        End Get
        Set(ByVal Value As String)
            _PRESENTACION = Value
            OnPropertyChanged("PRESENTACION")
        End Set
    End Property

    Private _PRESENTACIONOld As String
    Public Property PRESENTACIONOld() As String
        Get
            Return _PRESENTACIONOld
        End Get
        Set(ByVal Value As String)
            _PRESENTACIONOld = Value
        End Set
    End Property

    Private _CANTIDAD As Decimal
    <Column(Name:="Cantidad", Storage:="CANTIDAD", DbType:="NUMERIC(10,4)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=4)> _
    Public Property CANTIDAD() As Decimal
        Get
            Return _CANTIDAD
        End Get
        Set(ByVal Value As Decimal)
            _CANTIDAD = Value
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

    Private _PRECIO_UNITARIO As Decimal
    <Column(Name:="Precio unitario", Storage:="PRECIO_UNITARIO", DbType:="NUMERIC(10,4)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=4)> _
    Public Property PRECIO_UNITARIO() As Decimal
        Get
            Return _PRECIO_UNITARIO
        End Get
        Set(ByVal Value As Decimal)
            _PRECIO_UNITARIO = Value
            OnPropertyChanged("PRECIO_UNITARIO")
        End Set
    End Property

    Private _PRECIO_UNITARIOOld As Decimal
    Public Property PRECIO_UNITARIOOld() As Decimal
        Get
            Return _PRECIO_UNITARIOOld
        End Get
        Set(ByVal Value As Decimal)
            _PRECIO_UNITARIOOld = Value
        End Set
    End Property

    Private _SUB_TOTAL As Decimal
    <Column(Name:="Sub total", Storage:="SUB_TOTAL", DbType:="NUMERIC(10,4)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=4)> _
    Public Property SUB_TOTAL() As Decimal
        Get
            Return _SUB_TOTAL
        End Get
        Set(ByVal Value As Decimal)
            _SUB_TOTAL = Value
            OnPropertyChanged("SUB_TOTAL")
        End Set
    End Property

    Private _SUB_TOTALOld As Decimal
    Public Property SUB_TOTALOld() As Decimal
        Get
            Return _SUB_TOTALOld
        End Get
        Set(ByVal Value As Decimal)
            _SUB_TOTALOld = Value
        End Set
    End Property

    

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
