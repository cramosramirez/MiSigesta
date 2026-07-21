''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.SOLIC_APLICACION_PRODUCTO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row SOLIC_APLICACION_PRODUCTO en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	07/12/2018	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="SOLIC_APLICACION_PRODUCTO")> Public Class SOLIC_APLICACION_PRODUCTO
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_SOLIC_APLICACION_PROD As Int32, aID_SOLICITUD As Int32, aID_PRODUCTO As Int32, aCANT_X_MZ As Decimal, aTOTAL_PRODUCTO As Decimal, aPRECIO_UNITARIO As Decimal, aPRECIO_TOTAL As Decimal, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime, aZAFRA As String, aUID_SOLIC_AGRI_PROD As Guid, aUID_REFERENCIA As Guid)
        Me._ID_SOLIC_APLICACION_PROD = aID_SOLIC_APLICACION_PROD
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
        Me._UID_REFERENCIA = aUID_REFERENCIA
    End Sub

#Region " Properties "

    Private _ID_SOLIC_APLICACION_PROD As Int32
    <Column(Name:="Id solic aplicacion prod", Storage:="ID_SOLIC_APLICACION_PROD", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_SOLIC_APLICACION_PROD() As Int32
        Get
            Return _ID_SOLIC_APLICACION_PROD
        End Get
        Set(ByVal Value As Int32)
            _ID_SOLIC_APLICACION_PROD = Value
            OnPropertyChanged("ID_SOLIC_APLICACION_PROD")
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

    Private _UID_REFERENCIA As Guid
    <Column(Name:="Uid referencia", Storage:="UID_REFERENCIA", DbType:="UNIQUEIDENTIFIER(36, 0)", Id:=False), _
     DataObjectField(False, False, True, 16)> _
    Public Property UID_REFERENCIA() As Guid
        Get
            Return _UID_REFERENCIA
        End Get
        Set(ByVal Value As Guid)
            _UID_REFERENCIA = Value
            OnPropertyChanged("UID_REFERENCIA")
        End Set
    End Property 

    Private _UID_REFERENCIAOld As Guid
    Public Property UID_REFERENCIAOld() As Guid
        Get
            Return _UID_REFERENCIAOld
        End Get
        Set(ByVal Value As Guid)
            _UID_REFERENCIAOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
