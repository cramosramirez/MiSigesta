''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.PROFORMA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row PROFORMA en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	11/02/2018	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="PROFORMA")> Public Class PROFORMA
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_PROFORMA As Int32, aID_ZAFRA As Int32, aDIAZAFRA As Int32, aNOPROFORMA As Int32, aCODICONTRATO As String, aCODIPROVEEDOR As String, aACCESLOTE As String, aCODTRANSPORT As Int32, aNOMBRES_MOTORISTA As String, aID_TIPO_CANA As Int32, aID_CARGADORA As Int32, aID_SUPERVISOR As Int32, aFECHA_QUEMA As DateTime, aFECHA_CORTA As DateTime, aQUEMAPROG As Boolean, aQUEMANOPROG As Boolean, aCANA_VERDE As Boolean, aFECHA_ROZA As DateTime, aFECHA_PATIO As DateTime, aID_PRODUCTO As Int32, aFIN_LOTE As Boolean, aPLACAVEHIC As String, aID_TIPOTRANS As Int32, aSERVICIO_ROZA As Boolean, aTRANSPORTE_PROPIO As Boolean, aID_PROVEEDOR_ROZA As Int32, aID_CARGADOR As Int32, aTIPO_TARIFA_CARGADORA As Int32, aID_MOTORISTA As Int32, aOBSERVACIONES As String, aID_ENVIO As Int32, aESTADO As String, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime, aTONELADAS As Decimal, aID_TIPO_ROZA As Int32, aID_TIPO_ALZA As Int32, aFECHA_MADURANTE As DateTime, aOBSERVA_ANUL As String, aUSUARIO_ANUL As String, aFECHA_ANUL As DateTime, aES_QUERQUEO As Boolean, aES_BARRIDA As Boolean, aID_PROVEE As Integer)
        Me._ID_PROFORMA = aID_PROFORMA
        Me._ID_ZAFRA = aID_ZAFRA
        Me._DIAZAFRA = aDIAZAFRA
        Me._NOPROFORMA = aNOPROFORMA
        Me._CODICONTRATO = aCODICONTRATO
        Me._CODIPROVEEDOR = aCODIPROVEEDOR
        Me._ACCESLOTE = aACCESLOTE
        Me._CODTRANSPORT = aCODTRANSPORT
        Me._NOMBRES_MOTORISTA = aNOMBRES_MOTORISTA
        Me._ID_TIPO_CANA = aID_TIPO_CANA
        Me._ID_CARGADORA = aID_CARGADORA
        Me._ID_SUPERVISOR = aID_SUPERVISOR
        Me._FECHA_QUEMA = aFECHA_QUEMA
        Me._FECHA_CORTA = aFECHA_CORTA
        Me._QUEMAPROG = aQUEMAPROG
        Me._QUEMANOPROG = aQUEMANOPROG
        Me._CANA_VERDE = aCANA_VERDE
        Me._FECHA_ROZA = aFECHA_ROZA
        Me._FECHA_PATIO = aFECHA_PATIO
        Me._ID_PRODUCTO = aID_PRODUCTO
        Me._FIN_LOTE = aFIN_LOTE
        Me._PLACAVEHIC = aPLACAVEHIC
        Me._ID_TIPOTRANS = aID_TIPOTRANS
        Me._SERVICIO_ROZA = aSERVICIO_ROZA
        Me._TRANSPORTE_PROPIO = aTRANSPORTE_PROPIO
        Me._ID_PROVEEDOR_ROZA = aID_PROVEEDOR_ROZA
        Me._ID_CARGADOR = aID_CARGADOR
        Me._TIPO_TARIFA_CARGADORA = aTIPO_TARIFA_CARGADORA
        Me._ID_MOTORISTA = aID_MOTORISTA
        Me._OBSERVACIONES = aOBSERVACIONES
        Me._ID_ENVIO = aID_ENVIO
        Me._ESTADO = aESTADO
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
        Me._TONELADAS = aTONELADAS
        Me._ID_TIPO_ROZA = aID_TIPO_ROZA
        Me._ID_TIPO_ALZA = aID_TIPO_ALZA
        Me._FECHA_MADURANTE = aFECHA_MADURANTE
        Me._OBSERVA_ANUL = aOBSERVA_ANUL
        Me._USUARIO_ANUL = aUSUARIO_ANUL
        Me._FECHA_ANUL = aFECHA_ANUL
        Me._ES_QUERQUEO = aES_QUERQUEO
        Me._ES_BARRIDA = aES_BARRIDA
        Me._ID_PROVEE_QQ = aID_PROVEE
    End Sub

#Region " Properties "

    Private _ID_PROFORMA As Int32
    <Column(Name:="Id proforma", Storage:="ID_PROFORMA", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_PROFORMA() As Int32
        Get
            Return _ID_PROFORMA
        End Get
        Set(ByVal Value As Int32)
            _ID_PROFORMA = Value
            OnPropertyChanged("ID_PROFORMA")
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

    Private _DIAZAFRA As Int32
    <Column(Name:="Diazafra", Storage:="DIAZAFRA", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property DIAZAFRA() As Int32
        Get
            Return _DIAZAFRA
        End Get
        Set(ByVal Value As Int32)
            _DIAZAFRA = Value
            OnPropertyChanged("DIAZAFRA")
        End Set
    End Property 

    Private _DIAZAFRAOld As Int32
    Public Property DIAZAFRAOld() As Int32
        Get
            Return _DIAZAFRAOld
        End Get
        Set(ByVal Value As Int32)
            _DIAZAFRAOld = Value
        End Set
    End Property 

    Private _NOPROFORMA As Int32
    <Column(Name:="Noproforma", Storage:="NOPROFORMA", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property NOPROFORMA() As Int32
        Get
            Return _NOPROFORMA
        End Get
        Set(ByVal Value As Int32)
            _NOPROFORMA = Value
            OnPropertyChanged("NOPROFORMA")
        End Set
    End Property 

    Private _NOPROFORMAOld As Int32
    Public Property NOPROFORMAOld() As Int32
        Get
            Return _NOPROFORMAOld
        End Get
        Set(ByVal Value As Int32)
            _NOPROFORMAOld = Value
        End Set
    End Property 

    Private _CODICONTRATO As String
    <Column(Name:="Codicontrato", Storage:="CODICONTRATO", DbType:="CHAR(13) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 13)> _
    Public Property CODICONTRATO() As String
        Get
            Return _CODICONTRATO
        End Get
        Set(ByVal Value As String)
            _CODICONTRATO = Value
            OnPropertyChanged("CODICONTRATO")
        End Set
    End Property 

    Private _CODICONTRATOOld As String
    Public Property CODICONTRATOOld() As String
        Get
            Return _CODICONTRATOOld
        End Get
        Set(ByVal Value As String)
            _CODICONTRATOOld = Value
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

    Private _CODTRANSPORT As Int32
    <Column(Name:="Codtransport", Storage:="CODTRANSPORT", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property CODTRANSPORT() As Int32
        Get
            Return _CODTRANSPORT
        End Get
        Set(ByVal Value As Int32)
            _CODTRANSPORT = Value
            OnPropertyChanged("CODTRANSPORT")
        End Set
    End Property 

    Private _CODTRANSPORTOld As Int32
    Public Property CODTRANSPORTOld() As Int32
        Get
            Return _CODTRANSPORTOld
        End Get
        Set(ByVal Value As Int32)
            _CODTRANSPORTOld = Value
        End Set
    End Property 

    Private _NOMBRES_MOTORISTA As String
    <Column(Name:="Nombres motorista", Storage:="NOMBRES_MOTORISTA", DbType:="VARCHAR(60) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 60)> _
    Public Property NOMBRES_MOTORISTA() As String
        Get
            Return _NOMBRES_MOTORISTA
        End Get
        Set(ByVal Value As String)
            _NOMBRES_MOTORISTA = Value
            OnPropertyChanged("NOMBRES_MOTORISTA")
        End Set
    End Property 

    Private _NOMBRES_MOTORISTAOld As String
    Public Property NOMBRES_MOTORISTAOld() As String
        Get
            Return _NOMBRES_MOTORISTAOld
        End Get
        Set(ByVal Value As String)
            _NOMBRES_MOTORISTAOld = Value
        End Set
    End Property 

    Private _ID_TIPO_CANA As Int32
    <Column(Name:="Id tipo cana", Storage:="ID_TIPO_CANA", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
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

    Private _fkID_TIPO_CANA As TIPOS_GENERALES
    Public Property fkID_TIPO_CANA() As TIPOS_GENERALES
        Get
            Return _fkID_TIPO_CANA
        End Get
        Set(ByVal Value As TIPOS_GENERALES)
            _fkID_TIPO_CANA = Value
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

    Private _ID_SUPERVISOR As Int32
    <Column(Name:="Id supervisor", Storage:="ID_SUPERVISOR", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_SUPERVISOR() As Int32
        Get
            Return _ID_SUPERVISOR
        End Get
        Set(ByVal Value As Int32)
            _ID_SUPERVISOR = Value
            OnPropertyChanged("ID_SUPERVISOR")
        End Set
    End Property 

    Private _ID_SUPERVISOROld As Int32
    Public Property ID_SUPERVISOROld() As Int32
        Get
            Return _ID_SUPERVISOROld
        End Get
        Set(ByVal Value As Int32)
            _ID_SUPERVISOROld = Value
        End Set
    End Property 

    Private _fkID_SUPERVISOR As SUPERVISOR
    Public Property fkID_SUPERVISOR() As SUPERVISOR
        Get
            Return _fkID_SUPERVISOR
        End Get
        Set(ByVal Value As SUPERVISOR)
            _fkID_SUPERVISOR = Value
        End Set
    End Property 

    Private _FECHA_QUEMA As DateTime
    <Column(Name:="Fecha quema", Storage:="FECHA_QUEMA", DbType:="DATETIME", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_QUEMA() As DateTime
        Get
            Return _FECHA_QUEMA
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_QUEMA = Value
            OnPropertyChanged("FECHA_QUEMA")
        End Set
    End Property 

    Private _FECHA_QUEMAOld As DateTime
    Public Property FECHA_QUEMAOld() As DateTime
        Get
            Return _FECHA_QUEMAOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_QUEMAOld = Value
        End Set
    End Property 

    Private _FECHA_CORTA As DateTime
    <Column(Name:="Fecha corta", Storage:="FECHA_CORTA", DbType:="DATETIME", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_CORTA() As DateTime
        Get
            Return _FECHA_CORTA
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_CORTA = Value
            OnPropertyChanged("FECHA_CORTA")
        End Set
    End Property 

    Private _FECHA_CORTAOld As DateTime
    Public Property FECHA_CORTAOld() As DateTime
        Get
            Return _FECHA_CORTAOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_CORTAOld = Value
        End Set
    End Property 

    Private _QUEMAPROG As Boolean
    <Column(Name:="Quemaprog", Storage:="QUEMAPROG", DbType:="BIT NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 1)> _
    Public Property QUEMAPROG() As Boolean
        Get
            Return _QUEMAPROG
        End Get
        Set(ByVal Value As Boolean)
            _QUEMAPROG = Value
            OnPropertyChanged("QUEMAPROG")
        End Set
    End Property 

    Private _QUEMAPROGOld As Boolean
    Public Property QUEMAPROGOld() As Boolean
        Get
            Return _QUEMAPROGOld
        End Get
        Set(ByVal Value As Boolean)
            _QUEMAPROGOld = Value
        End Set
    End Property 

    Private _QUEMANOPROG As Boolean
    <Column(Name:="Quemanoprog", Storage:="QUEMANOPROG", DbType:="BIT NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 1)> _
    Public Property QUEMANOPROG() As Boolean
        Get
            Return _QUEMANOPROG
        End Get
        Set(ByVal Value As Boolean)
            _QUEMANOPROG = Value
            OnPropertyChanged("QUEMANOPROG")
        End Set
    End Property 

    Private _QUEMANOPROGOld As Boolean
    Public Property QUEMANOPROGOld() As Boolean
        Get
            Return _QUEMANOPROGOld
        End Get
        Set(ByVal Value As Boolean)
            _QUEMANOPROGOld = Value
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

    Private _FECHA_ROZA As DateTime
    <Column(Name:="Fecha roza", Storage:="FECHA_ROZA", DbType:="DATETIME", Id:=False), _
     DataObjectField(False, False, True)> _
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

    Private _FECHA_PATIO As DateTime
    <Column(Name:="Fecha patio", Storage:="FECHA_PATIO", DbType:="DATETIME", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_PATIO() As DateTime
        Get
            Return _FECHA_PATIO
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_PATIO = Value
            OnPropertyChanged("FECHA_PATIO")
        End Set
    End Property 

    Private _FECHA_PATIOOld As DateTime
    Public Property FECHA_PATIOOld() As DateTime
        Get
            Return _FECHA_PATIOOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_PATIOOld = Value
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

    Private _FIN_LOTE As Boolean
    <Column(Name:="Fin lote", Storage:="FIN_LOTE", DbType:="BIT NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 1)> _
    Public Property FIN_LOTE() As Boolean
        Get
            Return _FIN_LOTE
        End Get
        Set(ByVal Value As Boolean)
            _FIN_LOTE = Value
            OnPropertyChanged("FIN_LOTE")
        End Set
    End Property 

    Private _FIN_LOTEOld As Boolean
    Public Property FIN_LOTEOld() As Boolean
        Get
            Return _FIN_LOTEOld
        End Get
        Set(ByVal Value As Boolean)
            _FIN_LOTEOld = Value
        End Set
    End Property 

    Private _PLACAVEHIC As String
    <Column(Name:="Placavehic", Storage:="PLACAVEHIC", DbType:="VARCHAR(100) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 100)> _
    Public Property PLACAVEHIC() As String
        Get
            Return _PLACAVEHIC
        End Get
        Set(ByVal Value As String)
            _PLACAVEHIC = Value
            OnPropertyChanged("PLACAVEHIC")
        End Set
    End Property 

    Private _PLACAVEHICOld As String
    Public Property PLACAVEHICOld() As String
        Get
            Return _PLACAVEHICOld
        End Get
        Set(ByVal Value As String)
            _PLACAVEHICOld = Value
        End Set
    End Property 

    Private _ID_TIPOTRANS As Int32
    <Column(Name:="Id tipotrans", Storage:="ID_TIPOTRANS", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
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

    Private _fkID_TIPOTRANS As TIPO_TRANSPORTE
    Public Property fkID_TIPOTRANS() As TIPO_TRANSPORTE
        Get
            Return _fkID_TIPOTRANS
        End Get
        Set(ByVal Value As TIPO_TRANSPORTE)
            _fkID_TIPOTRANS = Value
        End Set
    End Property 

    Private _SERVICIO_ROZA As Boolean
    <Column(Name:="Servicio roza", Storage:="SERVICIO_ROZA", DbType:="BIT NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 1)> _
    Public Property SERVICIO_ROZA() As Boolean
        Get
            Return _SERVICIO_ROZA
        End Get
        Set(ByVal Value As Boolean)
            _SERVICIO_ROZA = Value
            OnPropertyChanged("SERVICIO_ROZA")
        End Set
    End Property 

    Private _SERVICIO_ROZAOld As Boolean
    Public Property SERVICIO_ROZAOld() As Boolean
        Get
            Return _SERVICIO_ROZAOld
        End Get
        Set(ByVal Value As Boolean)
            _SERVICIO_ROZAOld = Value
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

    Private _ID_PROVEEDOR_ROZA As Int32
    <Column(Name:="Id proveedor roza", Storage:="ID_PROVEEDOR_ROZA", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_PROVEEDOR_ROZA() As Int32
        Get
            Return _ID_PROVEEDOR_ROZA
        End Get
        Set(ByVal Value As Int32)
            _ID_PROVEEDOR_ROZA = Value
            OnPropertyChanged("ID_PROVEEDOR_ROZA")
        End Set
    End Property 

    Private _ID_PROVEEDOR_ROZAOld As Int32
    Public Property ID_PROVEEDOR_ROZAOld() As Int32
        Get
            Return _ID_PROVEEDOR_ROZAOld
        End Get
        Set(ByVal Value As Int32)
            _ID_PROVEEDOR_ROZAOld = Value
        End Set
    End Property 

    Private _fkID_PROVEEDOR_ROZA As PROVEEDOR_ROZA
    Public Property fkID_PROVEEDOR_ROZA() As PROVEEDOR_ROZA
        Get
            Return _fkID_PROVEEDOR_ROZA
        End Get
        Set(ByVal Value As PROVEEDOR_ROZA)
            _fkID_PROVEEDOR_ROZA = Value
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

    Private _fkID_CARGADOR As CARGADOR
    Public Property fkID_CARGADOR() As CARGADOR
        Get
            Return _fkID_CARGADOR
        End Get
        Set(ByVal Value As CARGADOR)
            _fkID_CARGADOR = Value
        End Set
    End Property 

    Private _TIPO_TARIFA_CARGADORA As Int32
    <Column(Name:="Tipo tarifa cargadora", Storage:="TIPO_TARIFA_CARGADORA", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property TIPO_TARIFA_CARGADORA() As Int32
        Get
            Return _TIPO_TARIFA_CARGADORA
        End Get
        Set(ByVal Value As Int32)
            _TIPO_TARIFA_CARGADORA = Value
            OnPropertyChanged("TIPO_TARIFA_CARGADORA")
        End Set
    End Property 

    Private _TIPO_TARIFA_CARGADORAOld As Int32
    Public Property TIPO_TARIFA_CARGADORAOld() As Int32
        Get
            Return _TIPO_TARIFA_CARGADORAOld
        End Get
        Set(ByVal Value As Int32)
            _TIPO_TARIFA_CARGADORAOld = Value
        End Set
    End Property 

    Private _ID_MOTORISTA As Int32
    <Column(Name:="Id motorista", Storage:="ID_MOTORISTA", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_MOTORISTA() As Int32
        Get
            Return _ID_MOTORISTA
        End Get
        Set(ByVal Value As Int32)
            _ID_MOTORISTA = Value
            OnPropertyChanged("ID_MOTORISTA")
        End Set
    End Property 

    Private _ID_MOTORISTAOld As Int32
    Public Property ID_MOTORISTAOld() As Int32
        Get
            Return _ID_MOTORISTAOld
        End Get
        Set(ByVal Value As Int32)
            _ID_MOTORISTAOld = Value
        End Set
    End Property 

    Private _OBSERVACIONES As String
    <Column(Name:="Observaciones", Storage:="OBSERVACIONES", DbType:="VARCHAR(600)", Id:=False), _
     DataObjectField(False, False, True, 600)> _
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

    Private _ID_ENVIO As Int32
    <Column(Name:="Id envio", Storage:="ID_ENVIO", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_ENVIO() As Int32
        Get
            Return _ID_ENVIO
        End Get
        Set(ByVal Value As Int32)
            _ID_ENVIO = Value
            OnPropertyChanged("ID_ENVIO")
        End Set
    End Property 

    Private _ID_ENVIOOld As Int32
    Public Property ID_ENVIOOld() As Int32
        Get
            Return _ID_ENVIOOld
        End Get
        Set(ByVal Value As Int32)
            _ID_ENVIOOld = Value
        End Set
    End Property 

    Private _fkID_ENVIO As ENVIO
    Public Property fkID_ENVIO() As ENVIO
        Get
            Return _fkID_ENVIO
        End Get
        Set(ByVal Value As ENVIO)
            _fkID_ENVIO = Value
        End Set
    End Property 

    Private _ESTADO As String
    <Column(Name:="Estado", Storage:="ESTADO", DbType:="CHAR(5) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 5)> _
    Public Property ESTADO() As String
        Get
            Return _ESTADO
        End Get
        Set(ByVal Value As String)
            _ESTADO = Value
            OnPropertyChanged("ESTADO")
        End Set
    End Property 

    Private _ESTADOOld As String
    Public Property ESTADOOld() As String
        Get
            Return _ESTADOOld
        End Get
        Set(ByVal Value As String)
            _ESTADOOld = Value
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

    Private _TONELADAS As Decimal
    <Column(Name:="Toneladas", Storage:="TONELADAS", DbType:="NUMERIC(10,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)> _
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

    Private _fkID_TIPO_ROZA As TIPOS_GENERALES
    Public Property fkID_TIPO_ROZA() As TIPOS_GENERALES
        Get
            Return _fkID_TIPO_ROZA
        End Get
        Set(ByVal Value As TIPOS_GENERALES)
            _fkID_TIPO_ROZA = Value
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

    Private _fkID_TIPO_ALZA As TIPOS_GENERALES
    Public Property fkID_TIPO_ALZA() As TIPOS_GENERALES
        Get
            Return _fkID_TIPO_ALZA
        End Get
        Set(ByVal Value As TIPOS_GENERALES)
            _fkID_TIPO_ALZA = Value
        End Set
    End Property 

    Private _FECHA_MADURANTE As DateTime
    <Column(Name:="Fecha madurante", Storage:="FECHA_MADURANTE", DbType:="DATETIME", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_MADURANTE() As DateTime
        Get
            Return _FECHA_MADURANTE
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_MADURANTE = Value
            OnPropertyChanged("FECHA_MADURANTE")
        End Set
    End Property 

    Private _FECHA_MADURANTEOld As DateTime
    Public Property FECHA_MADURANTEOld() As DateTime
        Get
            Return _FECHA_MADURANTEOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_MADURANTEOld = Value
        End Set
    End Property 

    Private _OBSERVA_ANUL As String
    <Column(Name:="Observa anul", Storage:="OBSERVA_ANUL", DbType:="VARCHAR(300)", Id:=False), _
     DataObjectField(False, False, True, 300)> _
    Public Property OBSERVA_ANUL() As String
        Get
            Return _OBSERVA_ANUL
        End Get
        Set(ByVal Value As String)
            _OBSERVA_ANUL = Value
            OnPropertyChanged("OBSERVA_ANUL")
        End Set
    End Property 

    Private _OBSERVA_ANULOld As String
    Public Property OBSERVA_ANULOld() As String
        Get
            Return _OBSERVA_ANULOld
        End Get
        Set(ByVal Value As String)
            _OBSERVA_ANULOld = Value
        End Set
    End Property 

    Private _USUARIO_ANUL As String
    <Column(Name:="Usuario anul", Storage:="USUARIO_ANUL", DbType:="VARCHAR(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
    Public Property USUARIO_ANUL() As String
        Get
            Return _USUARIO_ANUL
        End Get
        Set(ByVal Value As String)
            _USUARIO_ANUL = Value
            OnPropertyChanged("USUARIO_ANUL")
        End Set
    End Property 

    Private _USUARIO_ANULOld As String
    Public Property USUARIO_ANULOld() As String
        Get
            Return _USUARIO_ANULOld
        End Get
        Set(ByVal Value As String)
            _USUARIO_ANULOld = Value
        End Set
    End Property 

    Private _FECHA_ANUL As DateTime
    <Column(Name:="Fecha anul", Storage:="FECHA_ANUL", DbType:="DATETIME", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_ANUL() As DateTime
        Get
            Return _FECHA_ANUL
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_ANUL = Value
            OnPropertyChanged("FECHA_ANUL")
        End Set
    End Property 

    Private _FECHA_ANULOld As DateTime
    Public Property FECHA_ANULOld() As DateTime
        Get
            Return _FECHA_ANULOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_ANULOld = Value
        End Set
    End Property 

    Private _ES_QUERQUEO As Boolean
    <Column(Name:="Es querqueo", Storage:="ES_QUERQUEO", DbType:="BIT", Id:=False), _
     DataObjectField(False, False, True, 1)> _
    Public Property ES_QUERQUEO() As Boolean
        Get
            Return _ES_QUERQUEO
        End Get
        Set(ByVal Value As Boolean)
            _ES_QUERQUEO = Value
            OnPropertyChanged("ES_QUERQUEO")
        End Set
    End Property 

    Private _ES_QUERQUEOOld As Boolean
    Public Property ES_QUERQUEOOld() As Boolean
        Get
            Return _ES_QUERQUEOOld
        End Get
        Set(ByVal Value As Boolean)
            _ES_QUERQUEOOld = Value
        End Set
    End Property 

    Private _ES_BARRIDA As Boolean
    <Column(Name:="Es barrida", Storage:="ES_BARRIDA", DbType:="BIT NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 1)> _
    Public Property ES_BARRIDA() As Boolean
        Get
            Return _ES_BARRIDA
        End Get
        Set(ByVal Value As Boolean)
            _ES_BARRIDA = Value
            OnPropertyChanged("ES_BARRIDA")
        End Set
    End Property 

    Private _ES_BARRIDAOld As Boolean
    Public Property ES_BARRIDAOld() As Boolean
        Get
            Return _ES_BARRIDAOld
        End Get
        Set(ByVal Value As Boolean)
            _ES_BARRIDAOld = Value
        End Set
    End Property

    Private _ID_PROVEE_QQ As Int32
    <Column(Name:="Id provee qq", Storage:="ID_PROVEE_QQ", DBType:="INT", Id:=False),
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)>
    Public Property ID_PROVEE_QQ() As Int32
        Get
            Return _ID_PROVEE_QQ
        End Get
        Set(ByVal Value As Int32)
            _ID_PROVEE_QQ = Value
            OnPropertyChanged("ID_PROVEE_QQ")
        End Set
    End Property

    Private _ID_PROVEE_QQOld As Int32
    Public Property ID_PROVEE_QQOld() As Int32
        Get
            Return _ID_PROVEE_QQOld
        End Get
        Set(ByVal Value As Int32)
            _ID_PROVEE_QQOld = Value
        End Set
    End Property

    Private _ID_SUBLOTES As Int32
    <Column(Name:="Id sublotes", Storage:="ID_SUBLOTES", DBType:="INT  NULL", Id:=False),
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)>
    Public Property ID_SUBLOTES() As Int32
        Get
            Return _ID_SUBLOTES
        End Get
        Set(ByVal Value As Int32)
            _ID_SUBLOTES = Value
            OnPropertyChanged("ID_SUBLOTES")
        End Set
    End Property
#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
