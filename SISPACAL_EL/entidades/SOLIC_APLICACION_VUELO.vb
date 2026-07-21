''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.SOLIC_APLICACION_VUELO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row SOLIC_APLICACION_VUELO en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	07/12/2018	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="SOLIC_APLICACION_VUELO")> Public Class SOLIC_APLICACION_VUELO
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_SOLIC_APLICACION_VUELO As Int32, aID_SOLICITUD As Int32, aID_PROVEE As Int32, aMEDIO_APLICA As String, aDESCRIP_AERONAVE As String, aNOMBRE_PILOTO As String, aPRECIO_UNIT_VUELO As Decimal, aMZ_HORAS_VUELO As Decimal, aCARGO_VUELO As Decimal, aPRECIO_TOTAL_VUELO As Decimal, aPRECIO_UNIT_AGUA As Decimal, aMZ_REGAR_AGUA As Decimal, aPRECIO_TOTAL_AGUA As Decimal, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime, aZAFRA As String, aUID_SOLIC_AGRI_VUELO As Guid, aUID_REFERENCIA As Guid)
        Me._ID_SOLIC_APLICACION_VUELO = aID_SOLIC_APLICACION_VUELO
        Me._ID_SOLICITUD = aID_SOLICITUD
        Me._ID_PROVEE = aID_PROVEE
        Me._MEDIO_APLICA = aMEDIO_APLICA
        Me._DESCRIP_AERONAVE = aDESCRIP_AERONAVE
        Me._NOMBRE_PILOTO = aNOMBRE_PILOTO
        Me._PRECIO_UNIT_VUELO = aPRECIO_UNIT_VUELO
        Me._MZ_HORAS_VUELO = aMZ_HORAS_VUELO
        Me._CARGO_VUELO = aCARGO_VUELO
        Me._PRECIO_TOTAL_VUELO = aPRECIO_TOTAL_VUELO
        Me._PRECIO_UNIT_AGUA = aPRECIO_UNIT_AGUA
        Me._MZ_REGAR_AGUA = aMZ_REGAR_AGUA
        Me._PRECIO_TOTAL_AGUA = aPRECIO_TOTAL_AGUA
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
        Me._ZAFRA = aZAFRA
        Me._UID_SOLIC_AGRI_VUELO = aUID_SOLIC_AGRI_VUELO
        Me._UID_REFERENCIA = aUID_REFERENCIA
    End Sub

#Region " Properties "

    Private _ID_SOLIC_APLICACION_VUELO As Int32
    <Column(Name:="Id solic aplicacion vuelo", Storage:="ID_SOLIC_APLICACION_VUELO", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_SOLIC_APLICACION_VUELO() As Int32
        Get
            Return _ID_SOLIC_APLICACION_VUELO
        End Get
        Set(ByVal Value As Int32)
            _ID_SOLIC_APLICACION_VUELO = Value
            OnPropertyChanged("ID_SOLIC_APLICACION_VUELO")
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

    Private _MEDIO_APLICA As String
    <Column(Name:="Medio aplica", Storage:="MEDIO_APLICA", DbType:="CHAR(1)", Id:=False), _
     DataObjectField(False, False, True, 1)> _
    Public Property MEDIO_APLICA() As String
        Get
            Return _MEDIO_APLICA
        End Get
        Set(ByVal Value As String)
            _MEDIO_APLICA = Value
            OnPropertyChanged("MEDIO_APLICA")
        End Set
    End Property 

    Private _MEDIO_APLICAOld As String
    Public Property MEDIO_APLICAOld() As String
        Get
            Return _MEDIO_APLICAOld
        End Get
        Set(ByVal Value As String)
            _MEDIO_APLICAOld = Value
        End Set
    End Property 

    Private _DESCRIP_AERONAVE As String
    <Column(Name:="Descrip aeronave", Storage:="DESCRIP_AERONAVE", DbType:="VARCHAR(20)", Id:=False), _
     DataObjectField(False, False, True, 20)> _
    Public Property DESCRIP_AERONAVE() As String
        Get
            Return _DESCRIP_AERONAVE
        End Get
        Set(ByVal Value As String)
            _DESCRIP_AERONAVE = Value
            OnPropertyChanged("DESCRIP_AERONAVE")
        End Set
    End Property 

    Private _DESCRIP_AERONAVEOld As String
    Public Property DESCRIP_AERONAVEOld() As String
        Get
            Return _DESCRIP_AERONAVEOld
        End Get
        Set(ByVal Value As String)
            _DESCRIP_AERONAVEOld = Value
        End Set
    End Property 

    Private _NOMBRE_PILOTO As String
    <Column(Name:="Nombre piloto", Storage:="NOMBRE_PILOTO", DbType:="VARCHAR(60)", Id:=False), _
     DataObjectField(False, False, True, 60)> _
    Public Property NOMBRE_PILOTO() As String
        Get
            Return _NOMBRE_PILOTO
        End Get
        Set(ByVal Value As String)
            _NOMBRE_PILOTO = Value
            OnPropertyChanged("NOMBRE_PILOTO")
        End Set
    End Property 

    Private _NOMBRE_PILOTOOld As String
    Public Property NOMBRE_PILOTOOld() As String
        Get
            Return _NOMBRE_PILOTOOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_PILOTOOld = Value
        End Set
    End Property 

    Private _PRECIO_UNIT_VUELO As Decimal
    <Column(Name:="Precio unit vuelo", Storage:="PRECIO_UNIT_VUELO", DbType:="NUMERIC(10,4) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=4)> _
    Public Property PRECIO_UNIT_VUELO() As Decimal
        Get
            Return _PRECIO_UNIT_VUELO
        End Get
        Set(ByVal Value As Decimal)
            _PRECIO_UNIT_VUELO = Value
            OnPropertyChanged("PRECIO_UNIT_VUELO")
        End Set
    End Property 

    Private _PRECIO_UNIT_VUELOOld As Decimal
    Public Property PRECIO_UNIT_VUELOOld() As Decimal
        Get
            Return _PRECIO_UNIT_VUELOOld
        End Get
        Set(ByVal Value As Decimal)
            _PRECIO_UNIT_VUELOOld = Value
        End Set
    End Property 

    Private _MZ_HORAS_VUELO As Decimal
    <Column(Name:="Mz horas vuelo", Storage:="MZ_HORAS_VUELO", DbType:="NUMERIC(10,4) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=4)> _
    Public Property MZ_HORAS_VUELO() As Decimal
        Get
            Return _MZ_HORAS_VUELO
        End Get
        Set(ByVal Value As Decimal)
            _MZ_HORAS_VUELO = Value
            OnPropertyChanged("MZ_HORAS_VUELO")
        End Set
    End Property 

    Private _MZ_HORAS_VUELOOld As Decimal
    Public Property MZ_HORAS_VUELOOld() As Decimal
        Get
            Return _MZ_HORAS_VUELOOld
        End Get
        Set(ByVal Value As Decimal)
            _MZ_HORAS_VUELOOld = Value
        End Set
    End Property 

    Private _CARGO_VUELO As Decimal
    <Column(Name:="Cargo vuelo", Storage:="CARGO_VUELO", DbType:="NUMERIC(10,4) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=4)> _
    Public Property CARGO_VUELO() As Decimal
        Get
            Return _CARGO_VUELO
        End Get
        Set(ByVal Value As Decimal)
            _CARGO_VUELO = Value
            OnPropertyChanged("CARGO_VUELO")
        End Set
    End Property 

    Private _CARGO_VUELOOld As Decimal
    Public Property CARGO_VUELOOld() As Decimal
        Get
            Return _CARGO_VUELOOld
        End Get
        Set(ByVal Value As Decimal)
            _CARGO_VUELOOld = Value
        End Set
    End Property 

    Private _PRECIO_TOTAL_VUELO As Decimal
    <Column(Name:="Precio total vuelo", Storage:="PRECIO_TOTAL_VUELO", DbType:="NUMERIC(10,4) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=4)> _
    Public Property PRECIO_TOTAL_VUELO() As Decimal
        Get
            Return _PRECIO_TOTAL_VUELO
        End Get
        Set(ByVal Value As Decimal)
            _PRECIO_TOTAL_VUELO = Value
            OnPropertyChanged("PRECIO_TOTAL_VUELO")
        End Set
    End Property 

    Private _PRECIO_TOTAL_VUELOOld As Decimal
    Public Property PRECIO_TOTAL_VUELOOld() As Decimal
        Get
            Return _PRECIO_TOTAL_VUELOOld
        End Get
        Set(ByVal Value As Decimal)
            _PRECIO_TOTAL_VUELOOld = Value
        End Set
    End Property 

    Private _PRECIO_UNIT_AGUA As Decimal
    <Column(Name:="Precio unit agua", Storage:="PRECIO_UNIT_AGUA", DbType:="NUMERIC(10,4)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=4)> _
    Public Property PRECIO_UNIT_AGUA() As Decimal
        Get
            Return _PRECIO_UNIT_AGUA
        End Get
        Set(ByVal Value As Decimal)
            _PRECIO_UNIT_AGUA = Value
            OnPropertyChanged("PRECIO_UNIT_AGUA")
        End Set
    End Property 

    Private _PRECIO_UNIT_AGUAOld As Decimal
    Public Property PRECIO_UNIT_AGUAOld() As Decimal
        Get
            Return _PRECIO_UNIT_AGUAOld
        End Get
        Set(ByVal Value As Decimal)
            _PRECIO_UNIT_AGUAOld = Value
        End Set
    End Property 

    Private _MZ_REGAR_AGUA As Decimal
    <Column(Name:="Mz regar agua", Storage:="MZ_REGAR_AGUA", DbType:="NUMERIC(10,4)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=4)> _
    Public Property MZ_REGAR_AGUA() As Decimal
        Get
            Return _MZ_REGAR_AGUA
        End Get
        Set(ByVal Value As Decimal)
            _MZ_REGAR_AGUA = Value
            OnPropertyChanged("MZ_REGAR_AGUA")
        End Set
    End Property 

    Private _MZ_REGAR_AGUAOld As Decimal
    Public Property MZ_REGAR_AGUAOld() As Decimal
        Get
            Return _MZ_REGAR_AGUAOld
        End Get
        Set(ByVal Value As Decimal)
            _MZ_REGAR_AGUAOld = Value
        End Set
    End Property 

    Private _PRECIO_TOTAL_AGUA As Decimal
    <Column(Name:="Precio total agua", Storage:="PRECIO_TOTAL_AGUA", DbType:="NUMERIC(10,4)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=4)> _
    Public Property PRECIO_TOTAL_AGUA() As Decimal
        Get
            Return _PRECIO_TOTAL_AGUA
        End Get
        Set(ByVal Value As Decimal)
            _PRECIO_TOTAL_AGUA = Value
            OnPropertyChanged("PRECIO_TOTAL_AGUA")
        End Set
    End Property 

    Private _PRECIO_TOTAL_AGUAOld As Decimal
    Public Property PRECIO_TOTAL_AGUAOld() As Decimal
        Get
            Return _PRECIO_TOTAL_AGUAOld
        End Get
        Set(ByVal Value As Decimal)
            _PRECIO_TOTAL_AGUAOld = Value
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

    Private _UID_SOLIC_AGRI_VUELO As Guid
    <Column(Name:="Uid solic agri vuelo", Storage:="UID_SOLIC_AGRI_VUELO", DbType:="UNIQUEIDENTIFIER(36, 0)", Id:=False), _
     DataObjectField(False, False, True, 16)> _
    Public Property UID_SOLIC_AGRI_VUELO() As Guid
        Get
            Return _UID_SOLIC_AGRI_VUELO
        End Get
        Set(ByVal Value As Guid)
            _UID_SOLIC_AGRI_VUELO = Value
            OnPropertyChanged("UID_SOLIC_AGRI_VUELO")
        End Set
    End Property 

    Private _UID_SOLIC_AGRI_VUELOOld As Guid
    Public Property UID_SOLIC_AGRI_VUELOOld() As Guid
        Get
            Return _UID_SOLIC_AGRI_VUELOOld
        End Get
        Set(ByVal Value As Guid)
            _UID_SOLIC_AGRI_VUELOOld = Value
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
