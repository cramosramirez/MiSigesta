''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.SOLIC_QUEMANOPROG
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row SOLIC_QUEMANOPROG en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	16/01/2015	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="SOLIC_QUEMANOPROG")> Public Class SOLIC_QUEMANOPROG
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_SOLIC_QUEMANOPROG As Int32, aID_ZAFRA As Int32, aACCESLOTE As String, aFECHA_SOLIC As DateTime, aNO_SOLICITUD As Int32, aCODIPROVEEDOR As String, aZONA As String, aFECHA_HORA_QUEMA As DateTime, aAREA As Decimal, aTONEL As Decimal, aTIPO_QUEMA As String, aCODIVARIEDA As String, aBRECHAS As Boolean, aRONDAS As Boolean, aVIGILANCIA As Boolean, aMADURANTE As Boolean, aFECHA_APLICA As DateTime, aPRE_MUESTRA As Boolean, aFECHA_ROZA As DateTime, aFECHA_INI_VENTANA As DateTime, aFECHA_FIN_VENTANA As DateTime, aOBSERVACIONES As String, aCODIAGRON As String, aCON_DENUNCIA As Boolean, aZAFRA As String, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime)
        Me._ID_SOLIC_QUEMANOPROG = aID_SOLIC_QUEMANOPROG
        Me._ID_ZAFRA = aID_ZAFRA
        Me._ACCESLOTE = aACCESLOTE
        Me._FECHA_SOLIC = aFECHA_SOLIC
        Me._NO_SOLICITUD = aNO_SOLICITUD
        Me._CODIPROVEEDOR = aCODIPROVEEDOR
        Me._ZONA = aZONA
        Me._FECHA_HORA_QUEMA = aFECHA_HORA_QUEMA
        Me._AREA = aAREA
        Me._TONEL = aTONEL
        Me._TIPO_QUEMA = aTIPO_QUEMA
        Me._CODIVARIEDA = aCODIVARIEDA
        Me._BRECHAS = aBRECHAS
        Me._RONDAS = aRONDAS
        Me._VIGILANCIA = aVIGILANCIA
        Me._MADURANTE = aMADURANTE
        Me._FECHA_APLICA = aFECHA_APLICA
        Me._PRE_MUESTRA = aPRE_MUESTRA
        Me._FECHA_ROZA = aFECHA_ROZA
        Me._FECHA_INI_VENTANA = aFECHA_INI_VENTANA
        Me._FECHA_FIN_VENTANA = aFECHA_FIN_VENTANA
        Me._OBSERVACIONES = aOBSERVACIONES
        Me._CODIAGRON = aCODIAGRON
        Me._CON_DENUNCIA = aCON_DENUNCIA
        Me._ZAFRA = aZAFRA
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
    End Sub

#Region " Properties "

    Private _ID_SOLIC_QUEMANOPROG As Int32
    <Column(Name:="Id solic quemanoprog", Storage:="ID_SOLIC_QUEMANOPROG", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_SOLIC_QUEMANOPROG() As Int32
        Get
            Return _ID_SOLIC_QUEMANOPROG
        End Get
        Set(ByVal Value As Int32)
            _ID_SOLIC_QUEMANOPROG = Value
            OnPropertyChanged("ID_SOLIC_QUEMANOPROG")
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

    Private _FECHA_SOLIC As DateTime
    <Column(Name:="Fecha solic", Storage:="FECHA_SOLIC", DbType:="DATETIME NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
    Public Property FECHA_SOLIC() As DateTime
        Get
            Return _FECHA_SOLIC
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_SOLIC = Value
            OnPropertyChanged("FECHA_SOLIC")
        End Set
    End Property 

    Private _FECHA_SOLICOld As DateTime
    Public Property FECHA_SOLICOld() As DateTime
        Get
            Return _FECHA_SOLICOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_SOLICOld = Value
        End Set
    End Property 

    Private _NO_SOLICITUD As Int32
    <Column(Name:="No solicitud", Storage:="NO_SOLICITUD", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property NO_SOLICITUD() As Int32
        Get
            Return _NO_SOLICITUD
        End Get
        Set(ByVal Value As Int32)
            _NO_SOLICITUD = Value
            OnPropertyChanged("NO_SOLICITUD")
        End Set
    End Property 

    Private _NO_SOLICITUDOld As Int32
    Public Property NO_SOLICITUDOld() As Int32
        Get
            Return _NO_SOLICITUDOld
        End Get
        Set(ByVal Value As Int32)
            _NO_SOLICITUDOld = Value
        End Set
    End Property 

    Private _CODIPROVEEDOR As String
    <Column(Name:="Codiproveedor", Storage:="CODIPROVEEDOR", DbType:="CHAR(10) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 10)> _
    Public Property CODIPROVEEDOR() As String
        Get
            Return _CODIPROVEEDOR
        End Get
        Set(ByVal Value As String)
            _CODIPROVEEDOR = Value
            OnPropertyChanged("CODIPROVEEDOR")
        End Set
    End Property 

    Private _CODIPROVEEDOROld As String
    Public Property CODIPROVEEDOROld() As String
        Get
            Return _CODIPROVEEDOROld
        End Get
        Set(ByVal Value As String)
            _CODIPROVEEDOROld = Value
        End Set
    End Property 

    Private _fkCODIPROVEEDOR As PROVEEDOR
    Public Property fkCODIPROVEEDOR() As PROVEEDOR
        Get
            Return _fkCODIPROVEEDOR
        End Get
        Set(ByVal Value As PROVEEDOR)
            _fkCODIPROVEEDOR = Value
        End Set
    End Property 

    Private _ZONA As String
    <Column(Name:="Zona", Storage:="ZONA", DbType:="CHAR(2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 2)> _
    Public Property ZONA() As String
        Get
            Return _ZONA
        End Get
        Set(ByVal Value As String)
            _ZONA = Value
            OnPropertyChanged("ZONA")
        End Set
    End Property 

    Private _ZONAOld As String
    Public Property ZONAOld() As String
        Get
            Return _ZONAOld
        End Get
        Set(ByVal Value As String)
            _ZONAOld = Value
        End Set
    End Property 

    Private _FECHA_HORA_QUEMA As DateTime
    <Column(Name:="Fecha hora quema", Storage:="FECHA_HORA_QUEMA", DbType:="DATETIME NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
    Public Property FECHA_HORA_QUEMA() As DateTime
        Get
            Return _FECHA_HORA_QUEMA
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_HORA_QUEMA = Value
            OnPropertyChanged("FECHA_HORA_QUEMA")
        End Set
    End Property 

    Private _FECHA_HORA_QUEMAOld As DateTime
    Public Property FECHA_HORA_QUEMAOld() As DateTime
        Get
            Return _FECHA_HORA_QUEMAOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_HORA_QUEMAOld = Value
        End Set
    End Property 

    Private _AREA As Decimal
    <Column(Name:="Area", Storage:="AREA", DbType:="NUMERIC(10,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)> _
    Public Property AREA() As Decimal
        Get
            Return _AREA
        End Get
        Set(ByVal Value As Decimal)
            _AREA = Value
            OnPropertyChanged("AREA")
        End Set
    End Property 

    Private _AREAOld As Decimal
    Public Property AREAOld() As Decimal
        Get
            Return _AREAOld
        End Get
        Set(ByVal Value As Decimal)
            _AREAOld = Value
        End Set
    End Property 

    Private _TONEL As Decimal
    <Column(Name:="Tonel", Storage:="TONEL", DbType:="NUMERIC(10,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)> _
    Public Property TONEL() As Decimal
        Get
            Return _TONEL
        End Get
        Set(ByVal Value As Decimal)
            _TONEL = Value
            OnPropertyChanged("TONEL")
        End Set
    End Property 

    Private _TONELOld As Decimal
    Public Property TONELOld() As Decimal
        Get
            Return _TONELOld
        End Get
        Set(ByVal Value As Decimal)
            _TONELOld = Value
        End Set
    End Property 

    Private _TIPO_QUEMA As String
    <Column(Name:="Tipo quema", Storage:="TIPO_QUEMA", DbType:="CHAR(2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 2)> _
    Public Property TIPO_QUEMA() As String
        Get
            Return _TIPO_QUEMA
        End Get
        Set(ByVal Value As String)
            _TIPO_QUEMA = Value
            OnPropertyChanged("TIPO_QUEMA")
        End Set
    End Property 

    Private _TIPO_QUEMAOld As String
    Public Property TIPO_QUEMAOld() As String
        Get
            Return _TIPO_QUEMAOld
        End Get
        Set(ByVal Value As String)
            _TIPO_QUEMAOld = Value
        End Set
    End Property 

    Private _CODIVARIEDA As String
    <Column(Name:="Codivarieda", Storage:="CODIVARIEDA", DbType:="CHAR(3) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 3)> _
    Public Property CODIVARIEDA() As String
        Get
            Return _CODIVARIEDA
        End Get
        Set(ByVal Value As String)
            _CODIVARIEDA = Value
            OnPropertyChanged("CODIVARIEDA")
        End Set
    End Property 

    Private _CODIVARIEDAOld As String
    Public Property CODIVARIEDAOld() As String
        Get
            Return _CODIVARIEDAOld
        End Get
        Set(ByVal Value As String)
            _CODIVARIEDAOld = Value
        End Set
    End Property 

    Private _fkCODIVARIEDA As VARIEDAD
    Public Property fkCODIVARIEDA() As VARIEDAD
        Get
            Return _fkCODIVARIEDA
        End Get
        Set(ByVal Value As VARIEDAD)
            _fkCODIVARIEDA = Value
        End Set
    End Property 

    Private _BRECHAS As Boolean
    <Column(Name:="Brechas", Storage:="BRECHAS", DbType:="BIT NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 1)> _
    Public Property BRECHAS() As Boolean
        Get
            Return _BRECHAS
        End Get
        Set(ByVal Value As Boolean)
            _BRECHAS = Value
            OnPropertyChanged("BRECHAS")
        End Set
    End Property 

    Private _BRECHASOld As Boolean
    Public Property BRECHASOld() As Boolean
        Get
            Return _BRECHASOld
        End Get
        Set(ByVal Value As Boolean)
            _BRECHASOld = Value
        End Set
    End Property 

    Private _RONDAS As Boolean
    <Column(Name:="Rondas", Storage:="RONDAS", DbType:="BIT NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 1)> _
    Public Property RONDAS() As Boolean
        Get
            Return _RONDAS
        End Get
        Set(ByVal Value As Boolean)
            _RONDAS = Value
            OnPropertyChanged("RONDAS")
        End Set
    End Property 

    Private _RONDASOld As Boolean
    Public Property RONDASOld() As Boolean
        Get
            Return _RONDASOld
        End Get
        Set(ByVal Value As Boolean)
            _RONDASOld = Value
        End Set
    End Property 

    Private _VIGILANCIA As Boolean
    <Column(Name:="Vigilancia", Storage:="VIGILANCIA", DbType:="BIT NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 1)> _
    Public Property VIGILANCIA() As Boolean
        Get
            Return _VIGILANCIA
        End Get
        Set(ByVal Value As Boolean)
            _VIGILANCIA = Value
            OnPropertyChanged("VIGILANCIA")
        End Set
    End Property 

    Private _VIGILANCIAOld As Boolean
    Public Property VIGILANCIAOld() As Boolean
        Get
            Return _VIGILANCIAOld
        End Get
        Set(ByVal Value As Boolean)
            _VIGILANCIAOld = Value
        End Set
    End Property 

    Private _MADURANTE As Boolean
    <Column(Name:="Madurante", Storage:="MADURANTE", DbType:="BIT NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 1)> _
    Public Property MADURANTE() As Boolean
        Get
            Return _MADURANTE
        End Get
        Set(ByVal Value As Boolean)
            _MADURANTE = Value
            OnPropertyChanged("MADURANTE")
        End Set
    End Property 

    Private _MADURANTEOld As Boolean
    Public Property MADURANTEOld() As Boolean
        Get
            Return _MADURANTEOld
        End Get
        Set(ByVal Value As Boolean)
            _MADURANTEOld = Value
        End Set
    End Property 

    Private _FECHA_APLICA As DateTime
    <Column(Name:="Fecha aplica", Storage:="FECHA_APLICA", DbType:="DATETIME", Id:=False), _
     DataObjectField(False, False, True)> _
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

    Private _PRE_MUESTRA As Boolean
    <Column(Name:="Pre muestra", Storage:="PRE_MUESTRA", DbType:="BIT NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 1)> _
    Public Property PRE_MUESTRA() As Boolean
        Get
            Return _PRE_MUESTRA
        End Get
        Set(ByVal Value As Boolean)
            _PRE_MUESTRA = Value
            OnPropertyChanged("PRE_MUESTRA")
        End Set
    End Property 

    Private _PRE_MUESTRAOld As Boolean
    Public Property PRE_MUESTRAOld() As Boolean
        Get
            Return _PRE_MUESTRAOld
        End Get
        Set(ByVal Value As Boolean)
            _PRE_MUESTRAOld = Value
        End Set
    End Property 

    Private _FECHA_ROZA As DateTime
    <Column(Name:="Fecha roza", Storage:="FECHA_ROZA", DbType:="DATETIME NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
    Public Property FECHA_ROZA() As DateTime
        Get
            Return _FECHA_ROZA
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_ROZA = Value
            OnPropertyChanged("FECHA_ROZA")
        End Set
    End Property 

    Private _FECHA_ROZAOld As DateTime
    Public Property FECHA_ROZAOld() As DateTime
        Get
            Return _FECHA_ROZAOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_ROZAOld = Value
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

    Private _OBSERVACIONES As String
    <Column(Name:="Observaciones", Storage:="OBSERVACIONES", DbType:="VARCHAR(800)", Id:=False), _
     DataObjectField(False, False, True, 800)> _
    Public Property OBSERVACIONES() As String
        Get
            Return _OBSERVACIONES
        End Get
        Set(ByVal Value As String)
            _OBSERVACIONES = Value
            OnPropertyChanged("OBSERVACIONES")
        End Set
    End Property 

    Private _OBSERVACIONESOld As String
    Public Property OBSERVACIONESOld() As String
        Get
            Return _OBSERVACIONESOld
        End Get
        Set(ByVal Value As String)
            _OBSERVACIONESOld = Value
        End Set
    End Property 

    Private _CODIAGRON As String
    <Column(Name:="Codiagron", Storage:="CODIAGRON", DbType:="CHAR(8)", Id:=False), _
     DataObjectField(False, False, True, 8)> _
    Public Property CODIAGRON() As String
        Get
            Return _CODIAGRON
        End Get
        Set(ByVal Value As String)
            _CODIAGRON = Value
            OnPropertyChanged("CODIAGRON")
        End Set
    End Property 

    Private _CODIAGRONOld As String
    Public Property CODIAGRONOld() As String
        Get
            Return _CODIAGRONOld
        End Get
        Set(ByVal Value As String)
            _CODIAGRONOld = Value
        End Set
    End Property 

    Private _CON_DENUNCIA As Boolean
    <Column(Name:="Con denuncia", Storage:="CON_DENUNCIA", DbType:="BIT NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 1)> _
    Public Property CON_DENUNCIA() As Boolean
        Get
            Return _CON_DENUNCIA
        End Get
        Set(ByVal Value As Boolean)
            _CON_DENUNCIA = Value
            OnPropertyChanged("CON_DENUNCIA")
        End Set
    End Property 

    Private _CON_DENUNCIAOld As Boolean
    Public Property CON_DENUNCIAOld() As Boolean
        Get
            Return _CON_DENUNCIAOld
        End Get
        Set(ByVal Value As Boolean)
            _CON_DENUNCIAOld = Value
        End Set
    End Property 

    Private _ZAFRA As String
    <Column(Name:="Zafra", Storage:="ZAFRA", DbType:="CHAR(9) NOT NULL", Id:=False), _
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

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
