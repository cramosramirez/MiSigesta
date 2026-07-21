''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.DOCUMENTO_ENTRADA_DETA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row DOCUMENTO_ENTRADA_DETA en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	12/07/2017	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="DOCUMENTO_ENTRADA_DETA")> Public Class DOCUMENTO_ENTRADA_DETA
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_DOCENTRA_ENCA_DETA As Int32, aID_DOCENTRA_ENCA As Int32, aID_PRODUCTO As Int32, aCANTIDAD As Decimal, aPRECIO_UNITARIO As Decimal, aTOTAL As Decimal, aID_ORDEN_DETA As Int32, aUNIDAD As String, aPRESENTACION As String, aNOMBRE_PRODUCTO As String, aFECHA_VTO As DateTime, aUID_DOCUMENTO_DETA As Guid)
        Me._ID_DOCENTRA_ENCA_DETA = aID_DOCENTRA_ENCA_DETA
        Me._ID_DOCENTRA_ENCA = aID_DOCENTRA_ENCA
        Me._ID_PRODUCTO = aID_PRODUCTO
        Me._CANTIDAD = aCANTIDAD
        Me._PRECIO_UNITARIO = aPRECIO_UNITARIO
        Me._TOTAL = aTOTAL
        Me._ID_ORDEN_DETA = aID_ORDEN_DETA
        Me._UNIDAD = aUNIDAD
        Me._PRESENTACION = aPRESENTACION
        Me._NOMBRE_PRODUCTO = aNOMBRE_PRODUCTO
        Me._FECHA_VTO = aFECHA_VTO
        Me._UID_DOCUMENTO_DETA = aUID_DOCUMENTO_DETA
    End Sub

#Region " Properties "

    Private _ID_DOCENTRA_ENCA_DETA As Int32
    <Column(Name:="Id docentra enca deta", Storage:="ID_DOCENTRA_ENCA_DETA", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_DOCENTRA_ENCA_DETA() As Int32
        Get
            Return _ID_DOCENTRA_ENCA_DETA
        End Get
        Set(ByVal Value As Int32)
            _ID_DOCENTRA_ENCA_DETA = Value
            OnPropertyChanged("ID_DOCENTRA_ENCA_DETA")
        End Set
    End Property

    Private _ID_DOCENTRA_ENCA As Int32
    <Column(Name:="Id docentra enca", Storage:="ID_DOCENTRA_ENCA", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_DOCENTRA_ENCA() As Int32
        Get
            Return _ID_DOCENTRA_ENCA
        End Get
        Set(ByVal Value As Int32)
            _ID_DOCENTRA_ENCA = Value
            OnPropertyChanged("ID_DOCENTRA_ENCA")
        End Set
    End Property

    Private _ID_DOCENTRA_ENCAOld As Int32
    Public Property ID_DOCENTRA_ENCAOld() As Int32
        Get
            Return _ID_DOCENTRA_ENCAOld
        End Get
        Set(ByVal Value As Int32)
            _ID_DOCENTRA_ENCAOld = Value
        End Set
    End Property

    Private _fkID_DOCENTRA_ENCA As DOCUMENTO_ENTRADA_ENCA
    Public Property fkID_DOCENTRA_ENCA() As DOCUMENTO_ENTRADA_ENCA
        Get
            Return _fkID_DOCENTRA_ENCA
        End Get
        Set(ByVal Value As DOCUMENTO_ENTRADA_ENCA)
            _fkID_DOCENTRA_ENCA = Value
        End Set
    End Property

    Private _ID_PRODUCTO As Int32
    <Column(Name:="Id producto", Storage:="ID_PRODUCTO", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
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

    Private _ID_ORDEN_DETA As Int32
    <Column(Name:="Id orden deta", Storage:="ID_ORDEN_DETA", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_ORDEN_DETA() As Int32
        Get
            Return _ID_ORDEN_DETA
        End Get
        Set(ByVal Value As Int32)
            _ID_ORDEN_DETA = Value
            OnPropertyChanged("ID_ORDEN_DETA")
        End Set
    End Property

    Private _ID_ORDEN_DETAOld As Int32
    Public Property ID_ORDEN_DETAOld() As Int32
        Get
            Return _ID_ORDEN_DETAOld
        End Get
        Set(ByVal Value As Int32)
            _ID_ORDEN_DETAOld = Value
        End Set
    End Property

    Private _fkID_ORDEN_DETA As ORDEN_DETA_AGRI
    Public Property fkID_ORDEN_DETA() As ORDEN_DETA_AGRI
        Get
            Return _fkID_ORDEN_DETA
        End Get
        Set(ByVal Value As ORDEN_DETA_AGRI)
            _fkID_ORDEN_DETA = Value
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

    Private _NOMBRE_PRODUCTO As String
    <Column(Name:="Nombre producto", Storage:="NOMBRE_PRODUCTO", DbType:="VARCHAR(2000)", Id:=False), _
     DataObjectField(False, False, True, 2000)> _
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

    Private _FECHA_VTO As DateTime
    <Column(Name:="Fecha vto", Storage:="FECHA_VTO", DbType:="DATETIME", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_VTO() As DateTime
        Get
            Return _FECHA_VTO
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_VTO = Value
            OnPropertyChanged("FECHA_VTO")
        End Set
    End Property

    Private _FECHA_VTOOld As DateTime
    Public Property FECHA_VTOOld() As DateTime
        Get
            Return _FECHA_VTOOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_VTOOld = Value
        End Set
    End Property

    Private _UID_DOCUMENTO_DETA As Guid
    <Column(Name:="Uid documento deta", Storage:="UID_DOCUMENTO_DETA", DbType:="UNIQUEIDENTIFIER(36, 0)", Id:=False), _
     DataObjectField(False, False, True, 16)> _
    Public Property UID_DOCUMENTO_DETA() As Guid
        Get
            Return _UID_DOCUMENTO_DETA
        End Get
        Set(ByVal Value As Guid)
            _UID_DOCUMENTO_DETA = Value
            OnPropertyChanged("UID_DOCUMENTO_DETA")
        End Set
    End Property

    Private _UID_DOCUMENTO_DETAOld As Guid
    Public Property UID_DOCUMENTO_DETAOld() As Guid
        Get
            Return _UID_DOCUMENTO_DETAOld
        End Get
        Set(ByVal Value As Guid)
            _UID_DOCUMENTO_DETAOld = Value
        End Set
    End Property

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
