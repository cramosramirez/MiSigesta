''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.SALBODE_DETA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row SALBODE_DETA en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	15/06/2018	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="SALBODE_DETA")> Public Class SALBODE_DETA
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_SALBODE_DETA As Int32, aID_SALBODE_ENCA As Int32, aID_SOLICITUD As Int32, aID_PRODUCTO As Int32, aNOMBRE_PRODUCTO As String, aUNIDAD As String, aPRESENTACION As String, aCANTIDAD As Decimal, aPRECIO_UNITARIO As Decimal, aTOTAL As Decimal, aCANT_ENTREGADA As Decimal, aUSUARIO_ACT As String, aFECHA_ACT As DateTime, aCANT_ANULADA As Decimal, aID_ESTADO As Int32)
        Me._ID_SALBODE_DETA = aID_SALBODE_DETA
        Me._ID_SALBODE_ENCA = aID_SALBODE_ENCA
        Me._ID_SOLICITUD = aID_SOLICITUD
        Me._ID_PRODUCTO = aID_PRODUCTO
        Me._NOMBRE_PRODUCTO = aNOMBRE_PRODUCTO
        Me._UNIDAD = aUNIDAD
        Me._PRESENTACION = aPRESENTACION
        Me._CANTIDAD = aCANTIDAD
        Me._PRECIO_UNITARIO = aPRECIO_UNITARIO
        Me._TOTAL = aTOTAL
        Me._CANT_ENTREGADA = aCANT_ENTREGADA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
        Me._CANT_ANULADA = aCANT_ANULADA
        Me._ID_ESTADO = aID_ESTADO
    End Sub

#Region " Properties "

    Private _ID_SALBODE_DETA As Int32
    <Column(Name:="Id salbode deta", Storage:="ID_SALBODE_DETA", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_SALBODE_DETA() As Int32
        Get
            Return _ID_SALBODE_DETA
        End Get
        Set(ByVal Value As Int32)
            _ID_SALBODE_DETA = Value
            OnPropertyChanged("ID_SALBODE_DETA")
        End Set
    End Property 

    Private _ID_SALBODE_ENCA As Int32
    <Column(Name:="Id salbode enca", Storage:="ID_SALBODE_ENCA", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_SALBODE_ENCA() As Int32
        Get
            Return _ID_SALBODE_ENCA
        End Get
        Set(ByVal Value As Int32)
            _ID_SALBODE_ENCA = Value
            OnPropertyChanged("ID_SALBODE_ENCA")
        End Set
    End Property 

    Private _ID_SALBODE_ENCAOld As Int32
    Public Property ID_SALBODE_ENCAOld() As Int32
        Get
            Return _ID_SALBODE_ENCAOld
        End Get
        Set(ByVal Value As Int32)
            _ID_SALBODE_ENCAOld = Value
        End Set
    End Property 

    Private _fkID_SALBODE_ENCA As SALBODE_ENCA
    Public Property fkID_SALBODE_ENCA() As SALBODE_ENCA
        Get
            Return _fkID_SALBODE_ENCA
        End Get
        Set(ByVal Value As SALBODE_ENCA)
            _fkID_SALBODE_ENCA = Value
        End Set
    End Property 

    Private _ID_SOLICITUD As Int32
    <Column(Name:="Id solicitud", Storage:="ID_SOLICITUD", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
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

    Private _fkID_SOLICITUD As SOLIC_AGRICOLA
    Public Property fkID_SOLICITUD() As SOLIC_AGRICOLA
        Get
            Return _fkID_SOLICITUD
        End Get
        Set(ByVal Value As SOLIC_AGRICOLA)
            _fkID_SOLICITUD = Value
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

    Private _TOTAL As Decimal
    <Column(Name:="Total", Storage:="TOTAL", DbType:="NUMERIC(10,4)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=4)> _
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

    Private _CANT_ENTREGADA As Decimal
    <Column(Name:="Cant entregada", Storage:="CANT_ENTREGADA", DbType:="NUMERIC(10,4)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=4)> _
    Public Property CANT_ENTREGADA() As Decimal
        Get
            Return _CANT_ENTREGADA
        End Get
        Set(ByVal Value As Decimal)
            _CANT_ENTREGADA = Value
            OnPropertyChanged("CANT_ENTREGADA")
        End Set
    End Property 

    Private _CANT_ENTREGADAOld As Decimal
    Public Property CANT_ENTREGADAOld() As Decimal
        Get
            Return _CANT_ENTREGADAOld
        End Get
        Set(ByVal Value As Decimal)
            _CANT_ENTREGADAOld = Value
        End Set
    End Property 

    Private _USUARIO_ACT As String
    <Column(Name:="Usuario act", Storage:="USUARIO_ACT", DbType:="VARCHAR(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
    Public Property USUARIO_ACT() As String
        Get
            Return _USUARIO_ACT
        End Get
        Set(ByVal Value As String)
            _USUARIO_ACT = Value
            OnPropertyChanged("USUARIO_ACT")
        End Set
    End Property 

    Private _USUARIO_ACTOld As String
    Public Property USUARIO_ACTOld() As String
        Get
            Return _USUARIO_ACTOld
        End Get
        Set(ByVal Value As String)
            _USUARIO_ACTOld = Value
        End Set
    End Property 

    Private _FECHA_ACT As DateTime
    <Column(Name:="Fecha act", Storage:="FECHA_ACT", DbType:="DATETIME", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_ACT() As DateTime
        Get
            Return _FECHA_ACT
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_ACT = Value
            OnPropertyChanged("FECHA_ACT")
        End Set
    End Property 

    Private _FECHA_ACTOld As DateTime
    Public Property FECHA_ACTOld() As DateTime
        Get
            Return _FECHA_ACTOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_ACTOld = Value
        End Set
    End Property 

    Private _CANT_ANULADA As Decimal
    <Column(Name:="Cant anulada", Storage:="CANT_ANULADA", DbType:="NUMERIC(10,4)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=4)> _
    Public Property CANT_ANULADA() As Decimal
        Get
            Return _CANT_ANULADA
        End Get
        Set(ByVal Value As Decimal)
            _CANT_ANULADA = Value
            OnPropertyChanged("CANT_ANULADA")
        End Set
    End Property 

    Private _CANT_ANULADAOld As Decimal
    Public Property CANT_ANULADAOld() As Decimal
        Get
            Return _CANT_ANULADAOld
        End Get
        Set(ByVal Value As Decimal)
            _CANT_ANULADAOld = Value
        End Set
    End Property 

    Private _ID_ESTADO As Int32
    <Column(Name:="Id estado", Storage:="ID_ESTADO", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_ESTADO() As Int32
        Get
            Return _ID_ESTADO
        End Get
        Set(ByVal Value As Int32)
            _ID_ESTADO = Value
            OnPropertyChanged("ID_ESTADO")
        End Set
    End Property 

    Private _ID_ESTADOOld As Int32
    Public Property ID_ESTADOOld() As Int32
        Get
            Return _ID_ESTADOOld
        End Get
        Set(ByVal Value As Int32)
            _ID_ESTADOOld = Value
        End Set
    End Property 

    Private _fkID_ESTADO As SOLIC_AGRICOLA_ESTADO
    Public Property fkID_ESTADO() As SOLIC_AGRICOLA_ESTADO
        Get
            Return _fkID_ESTADO
        End Get
        Set(ByVal Value As SOLIC_AGRICOLA_ESTADO)
            _fkID_ESTADO = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
