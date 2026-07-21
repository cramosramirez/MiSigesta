''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.KARDEX
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row KARDEX en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	14/06/2018	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="KARDEX")> Public Class KARDEX
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_KARDEX As Int32, aFECHA As DateTime, aREFERENCIA As String, aUID_DOCUMENTO As Guid, aID_TIPO_MOVTO As Int32, aID_PRODUCTO As Int32, aENT_UNIDAD As Decimal, aENT_PRECIO_UNITARIO As Decimal, aENT_TOTAL As Decimal, aSAL_UNIDAD As Decimal, aSAL_PRECIO_UNITARIO As Decimal, aSAL_TOTAL As Decimal, aSDO_UNIDAD As Decimal, aSDO_PRECIO_UNITARIO As Decimal, aSDO_TOTAL As Decimal, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime, aID_BODEGA As Int32, aUID_DOCUMENTO_DETA As Guid, aID_ZAFRA As Int32)
        Me._ID_KARDEX = aID_KARDEX
        Me._FECHA = aFECHA
        Me._REFERENCIA = aREFERENCIA
        Me._UID_DOCUMENTO = aUID_DOCUMENTO
        Me._ID_TIPO_MOVTO = aID_TIPO_MOVTO
        Me._ID_PRODUCTO = aID_PRODUCTO
        Me._ENT_UNIDAD = aENT_UNIDAD
        Me._ENT_PRECIO_UNITARIO = aENT_PRECIO_UNITARIO
        Me._ENT_TOTAL = aENT_TOTAL
        Me._SAL_UNIDAD = aSAL_UNIDAD
        Me._SAL_PRECIO_UNITARIO = aSAL_PRECIO_UNITARIO
        Me._SAL_TOTAL = aSAL_TOTAL
        Me._SDO_UNIDAD = aSDO_UNIDAD
        Me._SDO_PRECIO_UNITARIO = aSDO_PRECIO_UNITARIO
        Me._SDO_TOTAL = aSDO_TOTAL
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
        Me._ID_BODEGA = aID_BODEGA
        Me._UID_DOCUMENTO_DETA = aUID_DOCUMENTO_DETA
        Me._ID_ZAFRA = aID_ZAFRA
    End Sub

#Region " Properties "

    Private _ID_KARDEX As Int32
    <Column(Name:="Id kardex", Storage:="ID_KARDEX", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_KARDEX() As Int32
        Get
            Return _ID_KARDEX
        End Get
        Set(ByVal Value As Int32)
            _ID_KARDEX = Value
            OnPropertyChanged("ID_KARDEX")
        End Set
    End Property 

    Private _FECHA As DateTime
    <Column(Name:="Fecha", Storage:="FECHA", DbType:="DATETIME NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
    Public Property FECHA() As DateTime
        Get
            Return _FECHA
        End Get
        Set(ByVal Value As DateTime)
            _FECHA = Value
            OnPropertyChanged("FECHA")
        End Set
    End Property 

    Private _FECHAOld As DateTime
    Public Property FECHAOld() As DateTime
        Get
            Return _FECHAOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHAOld = Value
        End Set
    End Property 

    Private _REFERENCIA As String
    <Column(Name:="Referencia", Storage:="REFERENCIA", DbType:="VARCHAR(200) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 200)> _
    Public Property REFERENCIA() As String
        Get
            Return _REFERENCIA
        End Get
        Set(ByVal Value As String)
            _REFERENCIA = Value
            OnPropertyChanged("REFERENCIA")
        End Set
    End Property 

    Private _REFERENCIAOld As String
    Public Property REFERENCIAOld() As String
        Get
            Return _REFERENCIAOld
        End Get
        Set(ByVal Value As String)
            _REFERENCIAOld = Value
        End Set
    End Property 

    Private _UID_DOCUMENTO As Guid
    <Column(Name:="Uid documento", Storage:="UID_DOCUMENTO", DbType:="UNIQUEIDENTIFIER(36, 0) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 16)> _
    Public Property UID_DOCUMENTO() As Guid
        Get
            Return _UID_DOCUMENTO
        End Get
        Set(ByVal Value As Guid)
            _UID_DOCUMENTO = Value
            OnPropertyChanged("UID_DOCUMENTO")
        End Set
    End Property 

    Private _UID_DOCUMENTOOld As Guid
    Public Property UID_DOCUMENTOOld() As Guid
        Get
            Return _UID_DOCUMENTOOld
        End Get
        Set(ByVal Value As Guid)
            _UID_DOCUMENTOOld = Value
        End Set
    End Property 

    Private _ID_TIPO_MOVTO As Int32
    <Column(Name:="Id tipo movto", Storage:="ID_TIPO_MOVTO", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_TIPO_MOVTO() As Int32
        Get
            Return _ID_TIPO_MOVTO
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_MOVTO = Value
            OnPropertyChanged("ID_TIPO_MOVTO")
        End Set
    End Property 

    Private _ID_TIPO_MOVTOOld As Int32
    Public Property ID_TIPO_MOVTOOld() As Int32
        Get
            Return _ID_TIPO_MOVTOOld
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_MOVTOOld = Value
        End Set
    End Property 

    Private _fkID_TIPO_MOVTO As TIPO_MOVTO
    Public Property fkID_TIPO_MOVTO() As TIPO_MOVTO
        Get
            Return _fkID_TIPO_MOVTO
        End Get
        Set(ByVal Value As TIPO_MOVTO)
            _fkID_TIPO_MOVTO = Value
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

    Private _ENT_UNIDAD As Decimal
    <Column(Name:="Ent unidad", Storage:="ENT_UNIDAD", DbType:="NUMERIC(20,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)> _
    Public Property ENT_UNIDAD() As Decimal
        Get
            Return _ENT_UNIDAD
        End Get
        Set(ByVal Value As Decimal)
            _ENT_UNIDAD = Value
            OnPropertyChanged("ENT_UNIDAD")
        End Set
    End Property 

    Private _ENT_UNIDADOld As Decimal
    Public Property ENT_UNIDADOld() As Decimal
        Get
            Return _ENT_UNIDADOld
        End Get
        Set(ByVal Value As Decimal)
            _ENT_UNIDADOld = Value
        End Set
    End Property 

    Private _ENT_PRECIO_UNITARIO As Decimal
    <Column(Name:="Ent precio unitario", Storage:="ENT_PRECIO_UNITARIO", DbType:="NUMERIC(20,5) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=5)> _
    Public Property ENT_PRECIO_UNITARIO() As Decimal
        Get
            Return _ENT_PRECIO_UNITARIO
        End Get
        Set(ByVal Value As Decimal)
            _ENT_PRECIO_UNITARIO = Value
            OnPropertyChanged("ENT_PRECIO_UNITARIO")
        End Set
    End Property 

    Private _ENT_PRECIO_UNITARIOOld As Decimal
    Public Property ENT_PRECIO_UNITARIOOld() As Decimal
        Get
            Return _ENT_PRECIO_UNITARIOOld
        End Get
        Set(ByVal Value As Decimal)
            _ENT_PRECIO_UNITARIOOld = Value
        End Set
    End Property 

    Private _ENT_TOTAL As Decimal
    <Column(Name:="Ent total", Storage:="ENT_TOTAL", DbType:="NUMERIC(20,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)> _
    Public Property ENT_TOTAL() As Decimal
        Get
            Return _ENT_TOTAL
        End Get
        Set(ByVal Value As Decimal)
            _ENT_TOTAL = Value
            OnPropertyChanged("ENT_TOTAL")
        End Set
    End Property 

    Private _ENT_TOTALOld As Decimal
    Public Property ENT_TOTALOld() As Decimal
        Get
            Return _ENT_TOTALOld
        End Get
        Set(ByVal Value As Decimal)
            _ENT_TOTALOld = Value
        End Set
    End Property 

    Private _SAL_UNIDAD As Decimal
    <Column(Name:="Sal unidad", Storage:="SAL_UNIDAD", DbType:="NUMERIC(20,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)> _
    Public Property SAL_UNIDAD() As Decimal
        Get
            Return _SAL_UNIDAD
        End Get
        Set(ByVal Value As Decimal)
            _SAL_UNIDAD = Value
            OnPropertyChanged("SAL_UNIDAD")
        End Set
    End Property 

    Private _SAL_UNIDADOld As Decimal
    Public Property SAL_UNIDADOld() As Decimal
        Get
            Return _SAL_UNIDADOld
        End Get
        Set(ByVal Value As Decimal)
            _SAL_UNIDADOld = Value
        End Set
    End Property 

    Private _SAL_PRECIO_UNITARIO As Decimal
    <Column(Name:="Sal precio unitario", Storage:="SAL_PRECIO_UNITARIO", DbType:="NUMERIC(20,5) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=5)> _
    Public Property SAL_PRECIO_UNITARIO() As Decimal
        Get
            Return _SAL_PRECIO_UNITARIO
        End Get
        Set(ByVal Value As Decimal)
            _SAL_PRECIO_UNITARIO = Value
            OnPropertyChanged("SAL_PRECIO_UNITARIO")
        End Set
    End Property 

    Private _SAL_PRECIO_UNITARIOOld As Decimal
    Public Property SAL_PRECIO_UNITARIOOld() As Decimal
        Get
            Return _SAL_PRECIO_UNITARIOOld
        End Get
        Set(ByVal Value As Decimal)
            _SAL_PRECIO_UNITARIOOld = Value
        End Set
    End Property 

    Private _SAL_TOTAL As Decimal
    <Column(Name:="Sal total", Storage:="SAL_TOTAL", DbType:="NUMERIC(20,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)> _
    Public Property SAL_TOTAL() As Decimal
        Get
            Return _SAL_TOTAL
        End Get
        Set(ByVal Value As Decimal)
            _SAL_TOTAL = Value
            OnPropertyChanged("SAL_TOTAL")
        End Set
    End Property 

    Private _SAL_TOTALOld As Decimal
    Public Property SAL_TOTALOld() As Decimal
        Get
            Return _SAL_TOTALOld
        End Get
        Set(ByVal Value As Decimal)
            _SAL_TOTALOld = Value
        End Set
    End Property 

    Private _SDO_UNIDAD As Decimal
    <Column(Name:="Sdo unidad", Storage:="SDO_UNIDAD", DbType:="NUMERIC(20,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)> _
    Public Property SDO_UNIDAD() As Decimal
        Get
            Return _SDO_UNIDAD
        End Get
        Set(ByVal Value As Decimal)
            _SDO_UNIDAD = Value
            OnPropertyChanged("SDO_UNIDAD")
        End Set
    End Property 

    Private _SDO_UNIDADOld As Decimal
    Public Property SDO_UNIDADOld() As Decimal
        Get
            Return _SDO_UNIDADOld
        End Get
        Set(ByVal Value As Decimal)
            _SDO_UNIDADOld = Value
        End Set
    End Property 

    Private _SDO_PRECIO_UNITARIO As Decimal
    <Column(Name:="Sdo precio unitario", Storage:="SDO_PRECIO_UNITARIO", DbType:="NUMERIC(20,5) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=5)> _
    Public Property SDO_PRECIO_UNITARIO() As Decimal
        Get
            Return _SDO_PRECIO_UNITARIO
        End Get
        Set(ByVal Value As Decimal)
            _SDO_PRECIO_UNITARIO = Value
            OnPropertyChanged("SDO_PRECIO_UNITARIO")
        End Set
    End Property 

    Private _SDO_PRECIO_UNITARIOOld As Decimal
    Public Property SDO_PRECIO_UNITARIOOld() As Decimal
        Get
            Return _SDO_PRECIO_UNITARIOOld
        End Get
        Set(ByVal Value As Decimal)
            _SDO_PRECIO_UNITARIOOld = Value
        End Set
    End Property 

    Private _SDO_TOTAL As Decimal
    <Column(Name:="Sdo total", Storage:="SDO_TOTAL", DbType:="NUMERIC(20,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)> _
    Public Property SDO_TOTAL() As Decimal
        Get
            Return _SDO_TOTAL
        End Get
        Set(ByVal Value As Decimal)
            _SDO_TOTAL = Value
            OnPropertyChanged("SDO_TOTAL")
        End Set
    End Property 

    Private _SDO_TOTALOld As Decimal
    Public Property SDO_TOTALOld() As Decimal
        Get
            Return _SDO_TOTALOld
        End Get
        Set(ByVal Value As Decimal)
            _SDO_TOTALOld = Value
        End Set
    End Property 

    Private _USUARIO_CREA As String
    <Column(Name:="Usuario crea", Storage:="USUARIO_CREA", DbType:="VARCHAR(100) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 100)> _
    Public Property USUARIO_CREA() As String
        Get
            Return _USUARIO_CREA
        End Get
        Set(ByVal Value As String)
            _USUARIO_CREA = Value
            OnPropertyChanged("USUARIO_CREA")
        End Set
    End Property 

    Private _USUARIO_CREAOld As String
    Public Property USUARIO_CREAOld() As String
        Get
            Return _USUARIO_CREAOld
        End Get
        Set(ByVal Value As String)
            _USUARIO_CREAOld = Value
        End Set
    End Property 

    Private _FECHA_CREA As DateTime
    <Column(Name:="Fecha crea", Storage:="FECHA_CREA", DbType:="DATETIME NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
    Public Property FECHA_CREA() As DateTime
        Get
            Return _FECHA_CREA
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_CREA = Value
            OnPropertyChanged("FECHA_CREA")
        End Set
    End Property 

    Private _FECHA_CREAOld As DateTime
    Public Property FECHA_CREAOld() As DateTime
        Get
            Return _FECHA_CREAOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_CREAOld = Value
        End Set
    End Property 

    Private _USUARIO_ACT As String
    <Column(Name:="Usuario act", Storage:="USUARIO_ACT", DbType:="VARCHAR(100) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 100)> _
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
    <Column(Name:="Fecha act", Storage:="FECHA_ACT", DbType:="DATETIME NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
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

    Private _ID_BODEGA As Int32
    <Column(Name:="Id bodega", Storage:="ID_BODEGA", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_BODEGA() As Int32
        Get
            Return _ID_BODEGA
        End Get
        Set(ByVal Value As Int32)
            _ID_BODEGA = Value
            OnPropertyChanged("ID_BODEGA")
        End Set
    End Property 

    Private _ID_BODEGAOld As Int32
    Public Property ID_BODEGAOld() As Int32
        Get
            Return _ID_BODEGAOld
        End Get
        Set(ByVal Value As Int32)
            _ID_BODEGAOld = Value
        End Set
    End Property 

    Private _fkID_BODEGA As BODEGA
    Public Property fkID_BODEGA() As BODEGA
        Get
            Return _fkID_BODEGA
        End Get
        Set(ByVal Value As BODEGA)
            _fkID_BODEGA = Value
        End Set
    End Property 

    Private _UID_DOCUMENTO_DETA As Guid
    <Column(Name:="Uid documento deta", Storage:="UID_DOCUMENTO_DETA", DbType:="UNIQUEIDENTIFIER(36, 0) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 16)> _
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

    Private _ID_ZAFRA As Int32
    <Column(Name:="Id zafra", Storage:="ID_ZAFRA", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_ZAFRA() As Int32
        Get
            Return _ID_ZAFRA
        End Get
        Set(ByVal Value As Int32)
            _ID_ZAFRA = Value
            OnPropertyChanged("ID_ZAFRA")
        End Set
    End Property 

    Private _ID_ZAFRAOld As Int32
    Public Property ID_ZAFRAOld() As Int32
        Get
            Return _ID_ZAFRAOld
        End Get
        Set(ByVal Value As Int32)
            _ID_ZAFRAOld = Value
        End Set
    End Property 

    Private _fkID_ZAFRA As ZAFRA
    Public Property fkID_ZAFRA() As ZAFRA
        Get
            Return _fkID_ZAFRA
        End Get
        Set(ByVal Value As ZAFRA)
            _fkID_ZAFRA = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
