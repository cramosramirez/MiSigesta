''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.SOLIC_APLICA_LOTE
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row SOLIC_APLICA_LOTE en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	07/12/2018	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="SOLIC_APLICA_LOTE")> Public Class SOLIC_APLICA_LOTE
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_SOLIC_APLICA_LOTE As Int32, aID_LOTES_COSECHA As Int32, aID_SOLICITUD As Int32, aID_ZAFRA As Int32, aACCESLOTE As String, aMZ As Decimal, aFECHA_APLICA As DateTime, aID_PRODUCTO As Int32, aCANT_X_MZ As Decimal, aTOTAL_PRODUCTO As Decimal, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime, aZAFRA As String, aID_MAESTRO As Int32, aNOMBRE_PRODUCTO As String, aFECHA_INI_VENTANA As DateTime, aFECHA_FIN_VENTANA As DateTime, aFECHA_ROZA_MADURANTE As DateTime, aTONELADAS As Decimal, aUID_REFERENCIA As Guid)
        Me._ID_SOLIC_APLICA_LOTE = aID_SOLIC_APLICA_LOTE
        Me._ID_LOTES_COSECHA = aID_LOTES_COSECHA
        Me._ID_SOLICITUD = aID_SOLICITUD
        Me._ID_ZAFRA = aID_ZAFRA
        Me._ACCESLOTE = aACCESLOTE
        Me._MZ = aMZ
        Me._FECHA_APLICA = aFECHA_APLICA
        Me._ID_PRODUCTO = aID_PRODUCTO
        Me._CANT_X_MZ = aCANT_X_MZ
        Me._TOTAL_PRODUCTO = aTOTAL_PRODUCTO
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
        Me._ZAFRA = aZAFRA
        Me._ID_MAESTRO = aID_MAESTRO
        Me._NOMBRE_PRODUCTO = aNOMBRE_PRODUCTO
        Me._FECHA_INI_VENTANA = aFECHA_INI_VENTANA
        Me._FECHA_FIN_VENTANA = aFECHA_FIN_VENTANA
        Me._FECHA_ROZA_MADURANTE = aFECHA_ROZA_MADURANTE
        Me._TONELADAS = aTONELADAS
        Me._UID_REFERENCIA = aUID_REFERENCIA
    End Sub

#Region " Properties "

    Private _ID_SOLIC_APLICA_LOTE As Int32
    <Column(Name:="Id solic aplica lote", Storage:="ID_SOLIC_APLICA_LOTE", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_SOLIC_APLICA_LOTE() As Int32
        Get
            Return _ID_SOLIC_APLICA_LOTE
        End Get
        Set(ByVal Value As Int32)
            _ID_SOLIC_APLICA_LOTE = Value
            OnPropertyChanged("ID_SOLIC_APLICA_LOTE")
        End Set
    End Property 

    Private _ID_LOTES_COSECHA As Int32
    <Column(Name:="Id lotes cosecha", Storage:="ID_LOTES_COSECHA", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_LOTES_COSECHA() As Int32
        Get
            Return _ID_LOTES_COSECHA
        End Get
        Set(ByVal Value As Int32)
            _ID_LOTES_COSECHA = Value
            OnPropertyChanged("ID_LOTES_COSECHA")
        End Set
    End Property 

    Private _ID_LOTES_COSECHAOld As Int32
    Public Property ID_LOTES_COSECHAOld() As Int32
        Get
            Return _ID_LOTES_COSECHAOld
        End Get
        Set(ByVal Value As Int32)
            _ID_LOTES_COSECHAOld = Value
        End Set
    End Property 

    Private _fkID_LOTES_COSECHA As LOTES_COSECHA
    Public Property fkID_LOTES_COSECHA() As LOTES_COSECHA
        Get
            Return _fkID_LOTES_COSECHA
        End Get
        Set(ByVal Value As LOTES_COSECHA)
            _fkID_LOTES_COSECHA = Value
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

    Private _ID_ZAFRA As Int32
    <Column(Name:="Id zafra", Storage:="ID_ZAFRA", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
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

    Private _ACCESLOTE As String
    <Column(Name:="Acceslote", Storage:="ACCESLOTE", DbType:="CHAR(21) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 21)> _
    Public Property ACCESLOTE() As String
        Get
            Return _ACCESLOTE
        End Get
        Set(ByVal Value As String)
            _ACCESLOTE = Value
            OnPropertyChanged("ACCESLOTE")
        End Set
    End Property 

    Private _ACCESLOTEOld As String
    Public Property ACCESLOTEOld() As String
        Get
            Return _ACCESLOTEOld
        End Get
        Set(ByVal Value As String)
            _ACCESLOTEOld = Value
        End Set
    End Property 

    Private _fkACCESLOTE As LOTES
    Public Property fkACCESLOTE() As LOTES
        Get
            Return _fkACCESLOTE
        End Get
        Set(ByVal Value As LOTES)
            _fkACCESLOTE = Value
        End Set
    End Property 

    Private _MZ As Decimal
    <Column(Name:="Mz", Storage:="MZ", DbType:="NUMERIC(10,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)> _
    Public Property MZ() As Decimal
        Get
            Return _MZ
        End Get
        Set(ByVal Value As Decimal)
            _MZ = Value
            OnPropertyChanged("MZ")
        End Set
    End Property 

    Private _MZOld As Decimal
    Public Property MZOld() As Decimal
        Get
            Return _MZOld
        End Get
        Set(ByVal Value As Decimal)
            _MZOld = Value
        End Set
    End Property 

    Private _FECHA_APLICA As DateTime
    <Column(Name:="Fecha aplica", Storage:="FECHA_APLICA", DbType:="DATETIME NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
    Public Property FECHA_APLICA() As DateTime
        Get
            Return _FECHA_APLICA
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_APLICA = Value
            OnPropertyChanged("FECHA_APLICA")
        End Set
    End Property 

    Private _FECHA_APLICAOld As DateTime
    Public Property FECHA_APLICAOld() As DateTime
        Get
            Return _FECHA_APLICAOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_APLICAOld = Value
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

    Private _ID_MAESTRO As Int32
    <Column(Name:="Id maestro", Storage:="ID_MAESTRO", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_MAESTRO() As Int32
        Get
            Return _ID_MAESTRO
        End Get
        Set(ByVal Value As Int32)
            _ID_MAESTRO = Value
            OnPropertyChanged("ID_MAESTRO")
        End Set
    End Property 

    Private _ID_MAESTROOld As Int32
    Public Property ID_MAESTROOld() As Int32
        Get
            Return _ID_MAESTROOld
        End Get
        Set(ByVal Value As Int32)
            _ID_MAESTROOld = Value
        End Set
    End Property 

    Private _fkID_MAESTRO As MAESTRO_LOTES
    Public Property fkID_MAESTRO() As MAESTRO_LOTES
        Get
            Return _fkID_MAESTRO
        End Get
        Set(ByVal Value As MAESTRO_LOTES)
            _fkID_MAESTRO = Value
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

    Private _FECHA_INI_VENTANA As DateTime
    <Column(Name:="Fecha ini ventana", Storage:="FECHA_INI_VENTANA", DbType:="DATETIME NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
    Public Property FECHA_INI_VENTANA() As DateTime
        Get
            Return _FECHA_INI_VENTANA
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_INI_VENTANA = Value
            OnPropertyChanged("FECHA_INI_VENTANA")
        End Set
    End Property 

    Private _FECHA_INI_VENTANAOld As DateTime
    Public Property FECHA_INI_VENTANAOld() As DateTime
        Get
            Return _FECHA_INI_VENTANAOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_INI_VENTANAOld = Value
        End Set
    End Property 

    Private _FECHA_FIN_VENTANA As DateTime
    <Column(Name:="Fecha fin ventana", Storage:="FECHA_FIN_VENTANA", DbType:="DATETIME NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
    Public Property FECHA_FIN_VENTANA() As DateTime
        Get
            Return _FECHA_FIN_VENTANA
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_FIN_VENTANA = Value
            OnPropertyChanged("FECHA_FIN_VENTANA")
        End Set
    End Property 

    Private _FECHA_FIN_VENTANAOld As DateTime
    Public Property FECHA_FIN_VENTANAOld() As DateTime
        Get
            Return _FECHA_FIN_VENTANAOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_FIN_VENTANAOld = Value
        End Set
    End Property 

    Private _FECHA_ROZA_MADURANTE As DateTime
    <Column(Name:="Fecha roza madurante", Storage:="FECHA_ROZA_MADURANTE", DbType:="DATETIME", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_ROZA_MADURANTE() As DateTime
        Get
            Return _FECHA_ROZA_MADURANTE
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_ROZA_MADURANTE = Value
            OnPropertyChanged("FECHA_ROZA_MADURANTE")
        End Set
    End Property 

    Private _FECHA_ROZA_MADURANTEOld As DateTime
    Public Property FECHA_ROZA_MADURANTEOld() As DateTime
        Get
            Return _FECHA_ROZA_MADURANTEOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_ROZA_MADURANTEOld = Value
        End Set
    End Property 

    Private _TONELADAS As Decimal
    <Column(Name:="Toneladas", Storage:="TONELADAS", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property TONELADAS() As Decimal
        Get
            Return _TONELADAS
        End Get
        Set(ByVal Value As Decimal)
            _TONELADAS = Value
            OnPropertyChanged("TONELADAS")
        End Set
    End Property 

    Private _TONELADASOld As Decimal
    Public Property TONELADASOld() As Decimal
        Get
            Return _TONELADASOld
        End Get
        Set(ByVal Value As Decimal)
            _TONELADASOld = Value
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
