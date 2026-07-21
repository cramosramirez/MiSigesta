''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.PLAN_COSECHA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row PLAN_COSECHA en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	29/11/2014	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="PLAN_COSECHA")> Public Class PLAN_COSECHA
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_PLAN_COSECHA As Int32, aID_ZAFRA As Int32, aACCESLOTE As String, aMZ_SALDO As Decimal, aTONEL_SALDO As Decimal, aMZ_COSECHA As Decimal, aTONEL_MZ_COSECHA As Decimal, aTONEL_COSECHA As Decimal, aCUOTA_DIARIA As Decimal, aFECHA_INI_COSECHA As DateTime, aFECHA_FIN_COSECHA As DateTime, aTOTAL_SEMANA As Decimal, aQUEMA_PROGRAMADA As Boolean, aQUEMA_NO_PROGRAMADA As Boolean, aID_TIPO_CANA As Int32, aID_TIPO_ROZA As Int32, aID_TIPO_ALZA As Int32, aID_CARGADORA As Int32, aID_CARGADOR As Int32, aID_TIPOTRANS As Int32, aTRANSPORTE_PROPIO As Boolean, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, _
                   aFECHA_ACT As DateTime, aCANA_VERDE As Boolean, aFECHA_ESTIM_QUEMA As DateTime, aFECHA_REAL_QUEMA As DateTime, aFECHA_QUEMA_NOPROG As DateTime, aCATORCENA As Int32)
        Me._ID_PLAN_COSECHA = aID_PLAN_COSECHA
        Me._ID_ZAFRA = aID_ZAFRA
        Me._ACCESLOTE = aACCESLOTE
        Me._MZ_SALDO = aMZ_SALDO
        Me._TONEL_SALDO = aTONEL_SALDO
        Me._MZ_COSECHA = aMZ_COSECHA
        Me._TONEL_MZ_COSECHA = aTONEL_MZ_COSECHA
        Me._TONEL_COSECHA = aTONEL_COSECHA
        Me._CUOTA_DIARIA = aCUOTA_DIARIA
        Me._FECHA_INI_COSECHA = aFECHA_INI_COSECHA
        Me._FECHA_FIN_COSECHA = aFECHA_FIN_COSECHA
        Me._TOTAL_SEMANA = aTOTAL_SEMANA
        Me._QUEMA_PROGRAMADA = aQUEMA_PROGRAMADA
        Me._QUEMA_NO_PROGRAMADA = aQUEMA_NO_PROGRAMADA
        Me._ID_TIPO_CANA = aID_TIPO_CANA
        Me._ID_TIPO_ROZA = aID_TIPO_ROZA
        Me._ID_TIPO_ALZA = aID_TIPO_ALZA
        Me._ID_CARGADORA = aID_CARGADORA
        Me._ID_CARGADOR = aID_CARGADOR
        Me._ID_TIPOTRANS = aID_TIPOTRANS
        Me._TRANSPORTE_PROPIO = aTRANSPORTE_PROPIO
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
        Me._CANA_VERDE = aCANA_VERDE
        Me._FECHA_ESTIM_QUEMA = aFECHA_ESTIM_QUEMA
        Me.FECHA_REAL_QUEMA = aFECHA_REAL_QUEMA
        Me.FECHA_QUEMA_NOPROG = aFECHA_QUEMA_NOPROG
        Me.CATORCENA = aCATORCENA
    End Sub

#Region " Properties "

    Private _ID_PLAN_COSECHA As Int32
    <Column(Name:="Id plan cosecha", Storage:="ID_PLAN_COSECHA", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_PLAN_COSECHA() As Int32
        Get
            Return _ID_PLAN_COSECHA
        End Get
        Set(ByVal Value As Int32)
            _ID_PLAN_COSECHA = Value
            OnPropertyChanged("ID_PLAN_COSECHA")
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

    Private _MZ_SALDO As Decimal
    <Column(Name:="Mz saldo", Storage:="MZ_SALDO", DbType:="NUMERIC(10,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)> _
    Public Property MZ_SALDO() As Decimal
        Get
            Return _MZ_SALDO
        End Get
        Set(ByVal Value As Decimal)
            _MZ_SALDO = Value
            OnPropertyChanged("MZ_SALDO")
        End Set
    End Property 

    Private _MZ_SALDOOld As Decimal
    Public Property MZ_SALDOOld() As Decimal
        Get
            Return _MZ_SALDOOld
        End Get
        Set(ByVal Value As Decimal)
            _MZ_SALDOOld = Value
        End Set
    End Property 

    Private _TONEL_SALDO As Decimal
    <Column(Name:="Tonel saldo", Storage:="TONEL_SALDO", DbType:="NUMERIC(10,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)> _
    Public Property TONEL_SALDO() As Decimal
        Get
            Return _TONEL_SALDO
        End Get
        Set(ByVal Value As Decimal)
            _TONEL_SALDO = Value
            OnPropertyChanged("TONEL_SALDO")
        End Set
    End Property 

    Private _TONEL_SALDOOld As Decimal
    Public Property TONEL_SALDOOld() As Decimal
        Get
            Return _TONEL_SALDOOld
        End Get
        Set(ByVal Value As Decimal)
            _TONEL_SALDOOld = Value
        End Set
    End Property 

    Private _MZ_COSECHA As Decimal
    <Column(Name:="Mz cosecha", Storage:="MZ_COSECHA", DbType:="NUMERIC(10,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)> _
    Public Property MZ_COSECHA() As Decimal
        Get
            Return _MZ_COSECHA
        End Get
        Set(ByVal Value As Decimal)
            _MZ_COSECHA = Value
            OnPropertyChanged("MZ_COSECHA")
        End Set
    End Property 

    Private _MZ_COSECHAOld As Decimal
    Public Property MZ_COSECHAOld() As Decimal
        Get
            Return _MZ_COSECHAOld
        End Get
        Set(ByVal Value As Decimal)
            _MZ_COSECHAOld = Value
        End Set
    End Property 

    Private _TONEL_MZ_COSECHA As Decimal
    <Column(Name:="Tonel mz cosecha", Storage:="TONEL_MZ_COSECHA", DbType:="NUMERIC(10,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)> _
    Public Property TONEL_MZ_COSECHA() As Decimal
        Get
            Return _TONEL_MZ_COSECHA
        End Get
        Set(ByVal Value As Decimal)
            _TONEL_MZ_COSECHA = Value
            OnPropertyChanged("TONEL_MZ_COSECHA")
        End Set
    End Property 

    Private _TONEL_MZ_COSECHAOld As Decimal
    Public Property TONEL_MZ_COSECHAOld() As Decimal
        Get
            Return _TONEL_MZ_COSECHAOld
        End Get
        Set(ByVal Value As Decimal)
            _TONEL_MZ_COSECHAOld = Value
        End Set
    End Property 

    Private _TONEL_COSECHA As Decimal
    <Column(Name:="Tonel cosecha", Storage:="TONEL_COSECHA", DbType:="NUMERIC(10,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)> _
    Public Property TONEL_COSECHA() As Decimal
        Get
            Return _TONEL_COSECHA
        End Get
        Set(ByVal Value As Decimal)
            _TONEL_COSECHA = Value
            OnPropertyChanged("TONEL_COSECHA")
        End Set
    End Property 

    Private _TONEL_COSECHAOld As Decimal
    Public Property TONEL_COSECHAOld() As Decimal
        Get
            Return _TONEL_COSECHAOld
        End Get
        Set(ByVal Value As Decimal)
            _TONEL_COSECHAOld = Value
        End Set
    End Property 

    Private _CUOTA_DIARIA As Decimal
    <Column(Name:="Cuota diaria", Storage:="CUOTA_DIARIA", DbType:="NUMERIC(10,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)> _
    Public Property CUOTA_DIARIA() As Decimal
        Get
            Return _CUOTA_DIARIA
        End Get
        Set(ByVal Value As Decimal)
            _CUOTA_DIARIA = Value
            OnPropertyChanged("CUOTA_DIARIA")
        End Set
    End Property 

    Private _CUOTA_DIARIAOld As Decimal
    Public Property CUOTA_DIARIAOld() As Decimal
        Get
            Return _CUOTA_DIARIAOld
        End Get
        Set(ByVal Value As Decimal)
            _CUOTA_DIARIAOld = Value
        End Set
    End Property 

    Private _FECHA_INI_COSECHA As DateTime
    <Column(Name:="Fecha ini cosecha", Storage:="FECHA_INI_COSECHA", DbType:="DATETIME NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
    Public Property FECHA_INI_COSECHA() As DateTime
        Get
            Return _FECHA_INI_COSECHA
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_INI_COSECHA = Value
            OnPropertyChanged("FECHA_INI_COSECHA")
        End Set
    End Property 

    Private _FECHA_INI_COSECHAOld As DateTime
    Public Property FECHA_INI_COSECHAOld() As DateTime
        Get
            Return _FECHA_INI_COSECHAOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_INI_COSECHAOld = Value
        End Set
    End Property 

    Private _FECHA_FIN_COSECHA As DateTime
    <Column(Name:="Fecha fin cosecha", Storage:="FECHA_FIN_COSECHA", DbType:="DATETIME NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
    Public Property FECHA_FIN_COSECHA() As DateTime
        Get
            Return _FECHA_FIN_COSECHA
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_FIN_COSECHA = Value
            OnPropertyChanged("FECHA_FIN_COSECHA")
        End Set
    End Property 

    Private _FECHA_FIN_COSECHAOld As DateTime
    Public Property FECHA_FIN_COSECHAOld() As DateTime
        Get
            Return _FECHA_FIN_COSECHAOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_FIN_COSECHAOld = Value
        End Set
    End Property 

    Private _TOTAL_SEMANA As Decimal
    <Column(Name:="Total semana", Storage:="TOTAL_SEMANA", DbType:="NUMERIC(10,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)> _
    Public Property TOTAL_SEMANA() As Decimal
        Get
            Return _TOTAL_SEMANA
        End Get
        Set(ByVal Value As Decimal)
            _TOTAL_SEMANA = Value
            OnPropertyChanged("TOTAL_SEMANA")
        End Set
    End Property 

    Private _TOTAL_SEMANAOld As Decimal
    Public Property TOTAL_SEMANAOld() As Decimal
        Get
            Return _TOTAL_SEMANAOld
        End Get
        Set(ByVal Value As Decimal)
            _TOTAL_SEMANAOld = Value
        End Set
    End Property 

    Private _QUEMA_PROGRAMADA As Boolean
    <Column(Name:="Quema programada", Storage:="QUEMA_PROGRAMADA", DbType:="BIT NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 1)> _
    Public Property QUEMA_PROGRAMADA() As Boolean
        Get
            Return _QUEMA_PROGRAMADA
        End Get
        Set(ByVal Value As Boolean)
            _QUEMA_PROGRAMADA = Value
            OnPropertyChanged("QUEMA_PROGRAMADA")
        End Set
    End Property 

    Private _QUEMA_PROGRAMADAOld As Boolean
    Public Property QUEMA_PROGRAMADAOld() As Boolean
        Get
            Return _QUEMA_PROGRAMADAOld
        End Get
        Set(ByVal Value As Boolean)
            _QUEMA_PROGRAMADAOld = Value
        End Set
    End Property 

    Private _QUEMA_NO_PROGRAMADA As Boolean
    <Column(Name:="Quema no programada", Storage:="QUEMA_NO_PROGRAMADA", DbType:="BIT NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 1)> _
    Public Property QUEMA_NO_PROGRAMADA() As Boolean
        Get
            Return _QUEMA_NO_PROGRAMADA
        End Get
        Set(ByVal Value As Boolean)
            _QUEMA_NO_PROGRAMADA = Value
            OnPropertyChanged("QUEMA_NO_PROGRAMADA")
        End Set
    End Property 

    Private _QUEMA_NO_PROGRAMADAOld As Boolean
    Public Property QUEMA_NO_PROGRAMADAOld() As Boolean
        Get
            Return _QUEMA_NO_PROGRAMADAOld
        End Get
        Set(ByVal Value As Boolean)
            _QUEMA_NO_PROGRAMADAOld = Value
        End Set
    End Property 

    Private _ID_TIPO_CANA As Int32
    <Column(Name:="Id tipo cana", Storage:="ID_TIPO_CANA", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_TIPO_CANA() As Int32
        Get
            Return _ID_TIPO_CANA
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_CANA = Value
            OnPropertyChanged("ID_TIPO_CANA")
        End Set
    End Property 

    Private _ID_TIPO_CANAOld As Int32
    Public Property ID_TIPO_CANAOld() As Int32
        Get
            Return _ID_TIPO_CANAOld
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_CANAOld = Value
        End Set
    End Property 

    Private _ID_TIPO_ROZA As Int32
    <Column(Name:="Id tipo roza", Storage:="ID_TIPO_ROZA", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_TIPO_ROZA() As Int32
        Get
            Return _ID_TIPO_ROZA
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_ROZA = Value
            OnPropertyChanged("ID_TIPO_ROZA")
        End Set
    End Property 

    Private _ID_TIPO_ROZAOld As Int32
    Public Property ID_TIPO_ROZAOld() As Int32
        Get
            Return _ID_TIPO_ROZAOld
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_ROZAOld = Value
        End Set
    End Property 

    Private _ID_TIPO_ALZA As Int32
    <Column(Name:="Id tipo alza", Storage:="ID_TIPO_ALZA", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_TIPO_ALZA() As Int32
        Get
            Return _ID_TIPO_ALZA
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_ALZA = Value
            OnPropertyChanged("ID_TIPO_ALZA")
        End Set
    End Property 

    Private _ID_TIPO_ALZAOld As Int32
    Public Property ID_TIPO_ALZAOld() As Int32
        Get
            Return _ID_TIPO_ALZAOld
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_ALZAOld = Value
        End Set
    End Property 

    Private _ID_CARGADORA As Int32
    <Column(Name:="Id cargadora", Storage:="ID_CARGADORA", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_CARGADORA() As Int32
        Get
            Return _ID_CARGADORA
        End Get
        Set(ByVal Value As Int32)
            _ID_CARGADORA = Value
            OnPropertyChanged("ID_CARGADORA")
        End Set
    End Property 

    Private _ID_CARGADORAOld As Int32
    Public Property ID_CARGADORAOld() As Int32
        Get
            Return _ID_CARGADORAOld
        End Get
        Set(ByVal Value As Int32)
            _ID_CARGADORAOld = Value
        End Set
    End Property 

    Private _fkID_CARGADORA As CARGADORA
    Public Property fkID_CARGADORA() As CARGADORA
        Get
            Return _fkID_CARGADORA
        End Get
        Set(ByVal Value As CARGADORA)
            _fkID_CARGADORA = Value
        End Set
    End Property 

    Private _ID_CARGADOR As Int32
    <Column(Name:="Id cargador", Storage:="ID_CARGADOR", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_CARGADOR() As Int32
        Get
            Return _ID_CARGADOR
        End Get
        Set(ByVal Value As Int32)
            _ID_CARGADOR = Value
            OnPropertyChanged("ID_CARGADOR")
        End Set
    End Property 

    Private _ID_CARGADOROld As Int32
    Public Property ID_CARGADOROld() As Int32
        Get
            Return _ID_CARGADOROld
        End Get
        Set(ByVal Value As Int32)
            _ID_CARGADOROld = Value
        End Set
    End Property 

    Private _ID_TIPOTRANS As Int32
    <Column(Name:="Id tipotrans", Storage:="ID_TIPOTRANS", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_TIPOTRANS() As Int32
        Get
            Return _ID_TIPOTRANS
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPOTRANS = Value
            OnPropertyChanged("ID_TIPOTRANS")
        End Set
    End Property 

    Private _ID_TIPOTRANSOld As Int32
    Public Property ID_TIPOTRANSOld() As Int32
        Get
            Return _ID_TIPOTRANSOld
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPOTRANSOld = Value
        End Set
    End Property 

    Private _TRANSPORTE_PROPIO As Boolean
    <Column(Name:="Transporte propio", Storage:="TRANSPORTE_PROPIO", DbType:="BIT NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 1)> _
    Public Property TRANSPORTE_PROPIO() As Boolean
        Get
            Return _TRANSPORTE_PROPIO
        End Get
        Set(ByVal Value As Boolean)
            _TRANSPORTE_PROPIO = Value
            OnPropertyChanged("TRANSPORTE_PROPIO")
        End Set
    End Property 

    Private _TRANSPORTE_PROPIOOld As Boolean
    Public Property TRANSPORTE_PROPIOOld() As Boolean
        Get
            Return _TRANSPORTE_PROPIOOld
        End Get
        Set(ByVal Value As Boolean)
            _TRANSPORTE_PROPIOOld = Value
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


    Private _CANA_VERDE As Boolean
    <Column(Name:="Cana verde", Storage:="CANA_VERDE", DbType:="BIT NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 1)> _
    Public Property CANA_VERDE() As Boolean
        Get
            Return _CANA_VERDE
        End Get
        Set(ByVal Value As Boolean)
            _CANA_VERDE = Value
            OnPropertyChanged("CANA_VERDE")
        End Set
    End Property

    Private _CANA_VERDEOld As Boolean
    Public Property CANA_VERDEOld() As Boolean
        Get
            Return _CANA_VERDEOld
        End Get
        Set(ByVal Value As Boolean)
            _CANA_VERDEOld = Value
        End Set
    End Property

    Private _FECHA_ESTIM_QUEMA As DateTime
    <Column(Name:="Fecha estim quema", Storage:="FECHA_ESTIM_QUEMA", DbType:="DATETIME NULL", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_ESTIM_QUEMA() As DateTime
        Get
            Return _FECHA_ESTIM_QUEMA
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_ESTIM_QUEMA = Value
            OnPropertyChanged("FECHA_ESTIM_QUEMA")
        End Set
    End Property
    Private _FECHA_ESTIM_QUEMAOld As DateTime
    Public Property FECHA_ESTIM_QUEMAOld() As DateTime
        Get
            Return _FECHA_ESTIM_QUEMAOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_ESTIM_QUEMAOld = Value
        End Set
    End Property

    Private _FECHA_REAL_QUEMA As DateTime
    <Column(Name:="Fecha real quema", Storage:="FECHA_REAL_QUEMA", DbType:="DATETIME NULL", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_REAL_QUEMA() As DateTime
        Get
            Return _FECHA_REAL_QUEMA
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_REAL_QUEMA = Value
            OnPropertyChanged("FECHA_REAL_QUEMA")
        End Set
    End Property
    Private _FECHA_REAL_QUEMAOld As DateTime
    Public Property FECHA_REAL_QUEMAOld() As DateTime
        Get
            Return _FECHA_REAL_QUEMAOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_REAL_QUEMAOld = Value
        End Set
    End Property

    Private _FECHA_QUEMA_NOPROG As DateTime
    <Column(Name:="Fecha quema no prog", Storage:="FECHA_QUEMA_NOPROG", DbType:="DATETIME NULL", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_QUEMA_NOPROG() As DateTime
        Get
            Return _FECHA_QUEMA_NOPROG
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_QUEMA_NOPROG = Value
            OnPropertyChanged("FECHA_QUEMA_NOPROG")
        End Set
    End Property
    Private _FECHA_QUEMA_NOPROGOld As DateTime
    Public Property FECHA_QUEMA_NOPROGOld() As DateTime
        Get
            Return _FECHA_QUEMA_NOPROGOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_QUEMA_NOPROGOld = Value
        End Set
    End Property

    Private _CATORCENA As Int32
    <Column(Name:="Catorcena", Storage:="CATORCENA", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property CATORCENA() As Int32
        Get
            Return _CATORCENA
        End Get
        Set(ByVal Value As Int32)
            _CATORCENA = Value
            OnPropertyChanged("CATORCENA")
        End Set
    End Property

    Private _CATORCENAOld As Int32
    Public Property CATORCENAOld() As Int32
        Get
            Return _CATORCENAOld
        End Get
        Set(ByVal Value As Int32)
            _CATORCENAOld = Value
        End Set
    End Property


    Private _SEMANA As Int32
    <Column(Name:="Semana", Storage:="SEMANA", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property SEMANA() As Int32
        Get
            Return _SEMANA
        End Get
        Set(ByVal Value As Int32)
            _SEMANA = Value
            OnPropertyChanged("SEMANA")
        End Set
    End Property

    Private _SEMANAOld As Int32
    Public Property SEMANAOld() As Int32
        Get
            Return _SEMANAOld
        End Get
        Set(ByVal Value As Int32)
            _SEMANAOld = Value
        End Set
    End Property
#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
