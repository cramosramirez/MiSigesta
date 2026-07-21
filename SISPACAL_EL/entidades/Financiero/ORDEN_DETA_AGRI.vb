''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.ORDEN_DETA_AGRI
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row ORDEN_DETA_AGRI en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	19/06/2017	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="ORDEN_DETA_AGRI")> Public Class ORDEN_DETA_AGRI
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_ORDEN_DETA As Int32, aID_ORDEN As Int32, aID_PRODUCTO As Int32, aNOMBRE_PRODUCTO As String, aUNIDAD As String, aPRESENTACION As String, aCANTIDAD As Decimal, aPRECIO_UNITARIO As Decimal, aTOTAL As Decimal)
        Me._ID_ORDEN_DETA = aID_ORDEN_DETA
        Me._ID_ORDEN = aID_ORDEN
        Me._ID_PRODUCTO = aID_PRODUCTO
        Me._NOMBRE_PRODUCTO = aNOMBRE_PRODUCTO
        Me._UNIDAD = aUNIDAD
        Me._PRESENTACION = aPRESENTACION
        Me._CANTIDAD = aCANTIDAD
        Me._PRECIO_UNITARIO = aPRECIO_UNITARIO
        Me._TOTAL = aTOTAL
    End Sub

#Region " Properties "

    Private _ID_ORDEN_DETA As Int32
    <Column(Name:="Id orden deta", Storage:="ID_ORDEN_DETA", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_ORDEN_DETA() As Int32
        Get
            Return _ID_ORDEN_DETA
        End Get
        Set(ByVal Value As Int32)
            _ID_ORDEN_DETA = Value
            OnPropertyChanged("ID_ORDEN_DETA")
        End Set
    End Property 

    Private _ID_ORDEN As Int32
    <Column(Name:="Id orden", Storage:="ID_ORDEN", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_ORDEN() As Int32
        Get
            Return _ID_ORDEN
        End Get
        Set(ByVal Value As Int32)
            _ID_ORDEN = Value
            OnPropertyChanged("ID_ORDEN")
        End Set
    End Property 

    Private _ID_ORDENOld As Int32
    Public Property ID_ORDENOld() As Int32
        Get
            Return _ID_ORDENOld
        End Get
        Set(ByVal Value As Int32)
            _ID_ORDENOld = Value
        End Set
    End Property 

    Private _fkID_ORDEN As ORDEN_COMPRA_AGRI
    Public Property fkID_ORDEN() As ORDEN_COMPRA_AGRI
        Get
            Return _fkID_ORDEN
        End Get
        Set(ByVal Value As ORDEN_COMPRA_AGRI)
            _fkID_ORDEN = Value
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
    <Column(Name:="Nombre producto", Storage:="NOMBRE_PRODUCTO", DbType:="VARCHAR(100) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 100)> _
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

    Private _UNIDAD As String
    <Column(Name:="Unidad", Storage:="UNIDAD", DbType:="VARCHAR(50)", Id:=False), _
     DataObjectField(False, False, True, 50)> _
    Public Property UNIDAD() As String
        Get
            Return _UNIDAD
        End Get
        Set(ByVal Value As String)
            _UNIDAD = Value
            OnPropertyChanged("UNIDAD")
        End Set
    End Property

    Private _UNIDADOld As String
    Public Property UNIDADOld() As String
        Get
            Return _UNIDADOld
        End Get
        Set(ByVal Value As String)
            _UNIDADOld = Value
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
    <Column(Name:="Cantidad", Storage:="CANTIDAD", DbType:="NUMERIC(10,4) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=4)> _
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
    <Column(Name:="Precio unitario", Storage:="PRECIO_UNITARIO", DbType:="NUMERIC(10,4) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=4)> _
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

    Private _TOTAL As Decimal
    <Column(Name:="Total", Storage:="TOTAL", DbType:="NUMERIC(10,4) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=4)> _
    Public Property TOTAL() As Decimal
        Get
            Return _TOTAL
        End Get
        Set(ByVal Value As Decimal)
            _TOTAL = Value
            OnPropertyChanged("TOTAL")
        End Set
    End Property 

    Private _TOTALOld As Decimal
    Public Property TOTALOld() As Decimal
        Get
            Return _TOTALOld
        End Get
        Set(ByVal Value As Decimal)
            _TOTALOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
