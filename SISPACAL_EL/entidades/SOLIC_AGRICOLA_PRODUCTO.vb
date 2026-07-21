''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.SOLIC_AGRICOLA_PRODUCTO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row SOLIC_AGRICOLA_PRODUCTO en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	20/06/2017	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="SOLIC_AGRICOLA_PRODUCTO")> Public Class SOLIC_AGRICOLA_PRODUCTO
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_SOLIC_AGRI_PROD As Int32, aID_SOLICITUD As Int32, aID_PRODUCTO As Int32, aCANT_X_MZ As Decimal, aTOTAL_PRODUCTO As Decimal, aPRECIO_UNITARIO As Decimal, aPRECIO_TOTAL As Decimal, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime, aZAFRA As String, aUID_SOLIC_AGRI_PROD As Guid, aNOMBRE_PRODUCTO As String, aPRESENTACION As String, aID_PROVEE As Int32, aUNIDAD As String, aID_PROVEE_ADJU As Int32, aCANT_ADJU As Decimal, aPRECIO_ADJU As Decimal, aTOTAL_ADJU As Decimal)
        Me._ID_SOLIC_AGRI_PROD = aID_SOLIC_AGRI_PROD
        Me._ID_SOLICITUD = aID_SOLICITUD
        Me._ID_PRODUCTO = aID_PRODUCTO
        Me._CANT_X_MZ = aCANT_X_MZ
        Me._TOTAL_PRODUCTO = aTOTAL_PRODUCTO
        Me._PRECIO_UNITARIO = aPRECIO_UNITARIO
        Me._PRECIO_TOTAL = aPRECIO_TOTAL
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
        Me._ZAFRA = aZAFRA
        Me._UID_SOLIC_AGRI_PROD = aUID_SOLIC_AGRI_PROD
        Me._NOMBRE_PRODUCTO = aNOMBRE_PRODUCTO
        Me._PRESENTACION = aPRESENTACION
        Me._ID_PROVEE = aID_PROVEE
        Me._UNIDAD = aUNIDAD
        Me._ID_PROVEE_ADJU = aID_PROVEE_ADJU
        Me._CANT_ADJU = aCANT_ADJU
        Me._PRECIO_ADJU = aPRECIO_ADJU
        Me._TOTAL_ADJU = aTOTAL_ADJU
    End Sub

#Region " Properties "

    Private _ID_SOLIC_AGRI_PROD As Int32
    <Column(Name:="Id solic agri prod", Storage:="ID_SOLIC_AGRI_PROD", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_SOLIC_AGRI_PROD() As Int32
        Get
            Return _ID_SOLIC_AGRI_PROD
        End Get
        Set(ByVal Value As Int32)
            _ID_SOLIC_AGRI_PROD = Value
            OnPropertyChanged("ID_SOLIC_AGRI_PROD")
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

    Private _CANT_X_MZ As Decimal
    <Column(Name:="Cant x mz", Storage:="CANT_X_MZ", DbType:="NUMERIC(10,4) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=4)> _
    Public Property CANT_X_MZ() As Decimal
        Get
            Return _CANT_X_MZ
        End Get
        Set(ByVal Value As Decimal)
            _CANT_X_MZ = Value
            OnPropertyChanged("CANT_X_MZ")
        End Set
    End Property 

    Private _CANT_X_MZOld As Decimal
    Public Property CANT_X_MZOld() As Decimal
        Get
            Return _CANT_X_MZOld
        End Get
        Set(ByVal Value As Decimal)
            _CANT_X_MZOld = Value
        End Set
    End Property 

    Private _TOTAL_PRODUCTO As Decimal
    <Column(Name:="Total producto", Storage:="TOTAL_PRODUCTO", DbType:="NUMERIC(10,4) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=4)> _
    Public Property TOTAL_PRODUCTO() As Decimal
        Get
            Return _TOTAL_PRODUCTO
        End Get
        Set(ByVal Value As Decimal)
            _TOTAL_PRODUCTO = Value
            OnPropertyChanged("TOTAL_PRODUCTO")
        End Set
    End Property 

    Private _TOTAL_PRODUCTOOld As Decimal
    Public Property TOTAL_PRODUCTOOld() As Decimal
        Get
            Return _TOTAL_PRODUCTOOld
        End Get
        Set(ByVal Value As Decimal)
            _TOTAL_PRODUCTOOld = Value
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

    Private _PRECIO_TOTAL As Decimal
    <Column(Name:="Precio total", Storage:="PRECIO_TOTAL", DbType:="NUMERIC(10,4) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=4)> _
    Public Property PRECIO_TOTAL() As Decimal
        Get
            Return _PRECIO_TOTAL
        End Get
        Set(ByVal Value As Decimal)
            _PRECIO_TOTAL = Value
            OnPropertyChanged("PRECIO_TOTAL")
        End Set
    End Property 

    Private _PRECIO_TOTALOld As Decimal
    Public Property PRECIO_TOTALOld() As Decimal
        Get
            Return _PRECIO_TOTALOld
        End Get
        Set(ByVal Value As Decimal)
            _PRECIO_TOTALOld = Value
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

    Private _ZAFRA As String
    <Column(Name:="Zafra", Storage:="ZAFRA", DbType:="VARCHAR(9) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 9)> _
    Public Property ZAFRA() As String
        Get
            Return _ZAFRA
        End Get
        Set(ByVal Value As String)
            _ZAFRA = Value
            OnPropertyChanged("ZAFRA")
        End Set
    End Property 

    Private _ZAFRAOld As String
    Public Property ZAFRAOld() As String
        Get
            Return _ZAFRAOld
        End Get
        Set(ByVal Value As String)
            _ZAFRAOld = Value
        End Set
    End Property 

    Private _UID_SOLIC_AGRI_PROD As Guid
    <Column(Name:="Uid solic agri prod", Storage:="UID_SOLIC_AGRI_PROD", DbType:="UNIQUEIDENTIFIER(36, 0)", Id:=False), _
     DataObjectField(False, False, True, 16)> _
    Public Property UID_SOLIC_AGRI_PROD() As Guid
        Get
            Return _UID_SOLIC_AGRI_PROD
        End Get
        Set(ByVal Value As Guid)
            _UID_SOLIC_AGRI_PROD = Value
            OnPropertyChanged("UID_SOLIC_AGRI_PROD")
        End Set
    End Property 

    Private _UID_SOLIC_AGRI_PRODOld As Guid
    Public Property UID_SOLIC_AGRI_PRODOld() As Guid
        Get
            Return _UID_SOLIC_AGRI_PRODOld
        End Get
        Set(ByVal Value As Guid)
            _UID_SOLIC_AGRI_PRODOld = Value
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

    Private _ID_PROVEE_ADJU As Int32
    <Column(Name:="Id provee adju", Storage:="ID_PROVEE_ADJU", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_PROVEE_ADJU() As Int32
        Get
            Return _ID_PROVEE_ADJU
        End Get
        Set(ByVal Value As Int32)
            _ID_PROVEE_ADJU = Value
            OnPropertyChanged("ID_PROVEE_ADJU")
        End Set
    End Property 

    Private _ID_PROVEE_ADJUOld As Int32
    Public Property ID_PROVEE_ADJUOld() As Int32
        Get
            Return _ID_PROVEE_ADJUOld
        End Get
        Set(ByVal Value As Int32)
            _ID_PROVEE_ADJUOld = Value
        End Set
    End Property 

    Private _CANT_ADJU As Decimal
    <Column(Name:="Cant adju", Storage:="CANT_ADJU", DbType:="NUMERIC(10,4)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=4)> _
    Public Property CANT_ADJU() As Decimal
        Get
            Return _CANT_ADJU
        End Get
        Set(ByVal Value As Decimal)
            _CANT_ADJU = Value
            OnPropertyChanged("CANT_ADJU")
        End Set
    End Property 

    Private _CANT_ADJUOld As Decimal
    Public Property CANT_ADJUOld() As Decimal
        Get
            Return _CANT_ADJUOld
        End Get
        Set(ByVal Value As Decimal)
            _CANT_ADJUOld = Value
        End Set
    End Property 

    Private _PRECIO_ADJU As Decimal
    <Column(Name:="Precio adju", Storage:="PRECIO_ADJU", DbType:="NUMERIC(10,4)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=4)> _
    Public Property PRECIO_ADJU() As Decimal
        Get
            Return _PRECIO_ADJU
        End Get
        Set(ByVal Value As Decimal)
            _PRECIO_ADJU = Value
            OnPropertyChanged("PRECIO_ADJU")
        End Set
    End Property 

    Private _PRECIO_ADJUOld As Decimal
    Public Property PRECIO_ADJUOld() As Decimal
        Get
            Return _PRECIO_ADJUOld
        End Get
        Set(ByVal Value As Decimal)
            _PRECIO_ADJUOld = Value
        End Set
    End Property 

    Private _TOTAL_ADJU As Decimal
    <Column(Name:="Total adju", Storage:="TOTAL_ADJU", DbType:="NUMERIC(10,4)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=4)> _
    Public Property TOTAL_ADJU() As Decimal
        Get
            Return _TOTAL_ADJU
        End Get
        Set(ByVal Value As Decimal)
            _TOTAL_ADJU = Value
            OnPropertyChanged("TOTAL_ADJU")
        End Set
    End Property 

    Private _TOTAL_ADJUOld As Decimal
    Public Property TOTAL_ADJUOld() As Decimal
        Get
            Return _TOTAL_ADJUOld
        End Get
        Set(ByVal Value As Decimal)
            _TOTAL_ADJUOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
