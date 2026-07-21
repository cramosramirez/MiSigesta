''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.ENVIO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row ENVIO en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	18/11/2019	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="ENVIO")> Public Class ENVIO
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New(aID_ENVIO As Int32, aID_ZAFRA As Int32, aDIAZAFRA As Int32, aCATORCENA As Int32, aCODICONTRATO As String, aCODIPROVEEDOR As String, aCOMPTENVIO As Int32, aACCESLOTE As String, aCODTRANSPORT As Int32, aNOMBRES_MOTORISTA As String, aID_TIPO_CANA As Int32, aID_CARGADORA As Int32, aID_SUPERVISOR As Int32, aFECHA_QUEMA As DateTime, aFECHA_CORTA As DateTime, aQUEMAPROG As Boolean, aFECHA_CARGA As DateTime, aFECHA_PATIO As DateTime, aNROBOLETA As Int32, aMADURANTE As Boolean, aCERRADO As Boolean, aFECHA_ENTRADA As DateTime, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime, aPLACAVEHIC As String, aID_TIPOTRANS As Int32, aSERVICIO_ROZA As Boolean, aTRANSPORTE_PROPIO As Boolean, aID_PROVEEDOR_ROZA As Int32, aID_CARGADOR As Int32, aNUMRECIBO_CANA As Int32, aTIPO_TARIFA_CARGADORA As Int32, aID_MOTORISTA As Int32, aHORAS_QUEMA As Decimal, aANULADO As Boolean, aUSUARIO_ANULACION As String, aFECHA_ANULACION As DateTime, aID_TIPO_ROZA As Int32, aID_TIPO_ALZA As Int32, aES_QUERQUEO As Boolean, aES_BARRIDO As Boolean, aES_PRIMERENVIO_TURNO As Boolean, aES_ULTENVIO_TURNO As Boolean)
        Me._ID_ENVIO = aID_ENVIO
        Me._ID_ZAFRA = aID_ZAFRA
        Me._DIAZAFRA = aDIAZAFRA
        Me._CATORCENA = aCATORCENA
        Me._CODICONTRATO = aCODICONTRATO
        Me._CODIPROVEEDOR = aCODIPROVEEDOR
        Me._COMPTENVIO = aCOMPTENVIO
        Me._ACCESLOTE = aACCESLOTE
        Me._CODTRANSPORT = aCODTRANSPORT
        Me._NOMBRES_MOTORISTA = aNOMBRES_MOTORISTA
        Me._ID_TIPO_CANA = aID_TIPO_CANA
        Me._ID_CARGADORA = aID_CARGADORA
        Me._ID_SUPERVISOR = aID_SUPERVISOR
        Me._FECHA_QUEMA = aFECHA_QUEMA
        Me._FECHA_CORTA = aFECHA_CORTA
        Me._QUEMAPROG = aQUEMAPROG
        Me._FECHA_CARGA = aFECHA_CARGA
        Me._FECHA_PATIO = aFECHA_PATIO
        Me._NROBOLETA = aNROBOLETA
        Me._MADURANTE = aMADURANTE
        Me._CERRADO = aCERRADO
        Me._FECHA_ENTRADA = aFECHA_ENTRADA
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
        Me._PLACAVEHIC = aPLACAVEHIC
        Me._ID_TIPOTRANS = aID_TIPOTRANS
        Me._SERVICIO_ROZA = aSERVICIO_ROZA
        Me._TRANSPORTE_PROPIO = aTRANSPORTE_PROPIO
        Me._ID_PROVEEDOR_ROZA = aID_PROVEEDOR_ROZA
        Me._ID_CARGADOR = aID_CARGADOR
        Me._NUMRECIBO_CANA = aNUMRECIBO_CANA
        Me._TIPO_TARIFA_CARGADORA = aTIPO_TARIFA_CARGADORA
        Me._ID_MOTORISTA = aID_MOTORISTA
        Me._HORAS_QUEMA = aHORAS_QUEMA
        Me._ANULADO = aANULADO
        Me._USUARIO_ANULACION = aUSUARIO_ANULACION
        Me._FECHA_ANULACION = aFECHA_ANULACION
        Me._ID_TIPO_ROZA = aID_TIPO_ROZA
        Me._ID_TIPO_ALZA = aID_TIPO_ALZA
        Me._ES_QUERQUEO = aES_QUERQUEO
        Me._ES_BARRIDO = aES_BARRIDO
        Me._ES_PRIMERENVIO_TURNO = aES_PRIMERENVIO_TURNO
        Me._ES_ULTENVIO_TURNO = aES_ULTENVIO_TURNO
    End Sub

#Region " Properties "

    Private _ID_ENVIO As Int32
    <Column(Name:="Id envio", Storage:="ID_ENVIO", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_ENVIO() As Int32
        Get
            Return _ID_ENVIO
        End Get
        Set(ByVal Value As Int32)
            _ID_ENVIO = Value
            OnPropertyChanged("ID_ENVIO")
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

    Private _CATORCENA As Int32
    <Column(Name:="Catorcena", Storage:="CATORCENA", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
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

    Private _fkCODICONTRATO As CONTRATO
    Public Property fkCODICONTRATO() As CONTRATO
        Get
            Return _fkCODICONTRATO
        End Get
        Set(ByVal Value As CONTRATO)
            _fkCODICONTRATO = Value
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

    Private _COMPTENVIO As Int32
    <Column(Name:="Comptenvio", Storage:="COMPTENVIO", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property COMPTENVIO() As Int32
        Get
            Return _COMPTENVIO
        End Get
        Set(ByVal Value As Int32)
            _COMPTENVIO = Value
            OnPropertyChanged("COMPTENVIO")
        End Set
    End Property 

    Private _COMPTENVIOOld As Int32
    Public Property COMPTENVIOOld() As Int32
        Get
            Return _COMPTENVIOOld
        End Get
        Set(ByVal Value As Int32)
            _COMPTENVIOOld = Value
        End Set
    End Property 

    Private _ACCESLOTE As String
    <Column(Name:="Acceslote", Storage:="ACCESLOTE", DbType:="CHAR(21)", Id:=False), _
     DataObjectField(False, False, True, 21)> _
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

    Private _fkCODTRANSPORT As TRANSPORTISTA
    Public Property fkCODTRANSPORT() As TRANSPORTISTA
        Get
            Return _fkCODTRANSPORT
        End Get
        Set(ByVal Value As TRANSPORTISTA)
            _fkCODTRANSPORT = Value
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

    Private _fkID_TIPO_CANA As TIPO_CANA
    Public Property fkID_TIPO_CANA() As TIPO_CANA
        Get
            Return _fkID_TIPO_CANA
        End Get
        Set(ByVal Value As TIPO_CANA)
            _fkID_TIPO_CANA = Value
        End Set
    End Property 

    Private _ID_CARGADORA As Int32
    <Column(Name:="Id cargadora", Storage:="ID_CARGADORA", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
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
    <Column(Name:="Id supervisor", Storage:="ID_SUPERVISOR", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
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
    <Column(Name:="Fecha corta", Storage:="FECHA_CORTA", DbType:="DATETIME NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
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

    Private _FECHA_CARGA As DateTime
    <Column(Name:="Fecha carga", Storage:="FECHA_CARGA", DbType:="DATETIME NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
    Public Property FECHA_CARGA() As DateTime
        Get
            Return _FECHA_CARGA
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_CARGA = Value
            OnPropertyChanged("FECHA_CARGA")
        End Set
    End Property 

    Private _FECHA_CARGAOld As DateTime
    Public Property FECHA_CARGAOld() As DateTime
        Get
            Return _FECHA_CARGAOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_CARGAOld = Value
        End Set
    End Property 

    Private _FECHA_PATIO As DateTime
    <Column(Name:="Fecha patio", Storage:="FECHA_PATIO", DbType:="DATETIME NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
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

    Private _NROBOLETA As Int32
    <Column(Name:="Nroboleta", Storage:="NROBOLETA", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property NROBOLETA() As Int32
        Get
            Return _NROBOLETA
        End Get
        Set(ByVal Value As Int32)
            _NROBOLETA = Value
            OnPropertyChanged("NROBOLETA")
        End Set
    End Property 

    Private _NROBOLETAOld As Int32
    Public Property NROBOLETAOld() As Int32
        Get
            Return _NROBOLETAOld
        End Get
        Set(ByVal Value As Int32)
            _NROBOLETAOld = Value
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

    Private _CERRADO As Boolean
    <Column(Name:="Cerrado", Storage:="CERRADO", DbType:="BIT NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 1)> _
    Public Property CERRADO() As Boolean
        Get
            Return _CERRADO
        End Get
        Set(ByVal Value As Boolean)
            _CERRADO = Value
            OnPropertyChanged("CERRADO")
        End Set
    End Property 

    Private _CERRADOOld As Boolean
    Public Property CERRADOOld() As Boolean
        Get
            Return _CERRADOOld
        End Get
        Set(ByVal Value As Boolean)
            _CERRADOOld = Value
        End Set
    End Property 

    Private _FECHA_ENTRADA As DateTime
    <Column(Name:="Fecha entrada", Storage:="FECHA_ENTRADA", DbType:="DATETIME NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
    Public Property FECHA_ENTRADA() As DateTime
        Get
            Return _FECHA_ENTRADA
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_ENTRADA = Value
            OnPropertyChanged("FECHA_ENTRADA")
        End Set
    End Property 

    Private _FECHA_ENTRADAOld As DateTime
    Public Property FECHA_ENTRADAOld() As DateTime
        Get
            Return _FECHA_ENTRADAOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_ENTRADAOld = Value
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

    Private _NUMRECIBO_CANA As Int32
    <Column(Name:="Numrecibo cana", Storage:="NUMRECIBO_CANA", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property NUMRECIBO_CANA() As Int32
        Get
            Return _NUMRECIBO_CANA
        End Get
        Set(ByVal Value As Int32)
            _NUMRECIBO_CANA = Value
            OnPropertyChanged("NUMRECIBO_CANA")
        End Set
    End Property 

    Private _NUMRECIBO_CANAOld As Int32
    Public Property NUMRECIBO_CANAOld() As Int32
        Get
            Return _NUMRECIBO_CANAOld
        End Get
        Set(ByVal Value As Int32)
            _NUMRECIBO_CANAOld = Value
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

    Private _fkID_MOTORISTA As MOTORISTA
    Public Property fkID_MOTORISTA() As MOTORISTA
        Get
            Return _fkID_MOTORISTA
        End Get
        Set(ByVal Value As MOTORISTA)
            _fkID_MOTORISTA = Value
        End Set
    End Property 

    Private _HORAS_QUEMA As Decimal
    <Column(Name:="Horas quema", Storage:="HORAS_QUEMA", DbType:="NUMERIC(6,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=6, Scale:=2)> _
    Public Property HORAS_QUEMA() As Decimal
        Get
            Return _HORAS_QUEMA
        End Get
        Set(ByVal Value As Decimal)
            _HORAS_QUEMA = Value
            OnPropertyChanged("HORAS_QUEMA")
        End Set
    End Property 

    Private _HORAS_QUEMAOld As Decimal
    Public Property HORAS_QUEMAOld() As Decimal
        Get
            Return _HORAS_QUEMAOld
        End Get
        Set(ByVal Value As Decimal)
            _HORAS_QUEMAOld = Value
        End Set
    End Property 

    Private _ANULADO As Boolean
    <Column(Name:="Anulado", Storage:="ANULADO", DbType:="BIT", Id:=False), _
     DataObjectField(False, False, True, 1)> _
    Public Property ANULADO() As Boolean
        Get
            Return _ANULADO
        End Get
        Set(ByVal Value As Boolean)
            _ANULADO = Value
            OnPropertyChanged("ANULADO")
        End Set
    End Property 

    Private _ANULADOOld As Boolean
    Public Property ANULADOOld() As Boolean
        Get
            Return _ANULADOOld
        End Get
        Set(ByVal Value As Boolean)
            _ANULADOOld = Value
        End Set
    End Property 

    Private _USUARIO_ANULACION As String
    <Column(Name:="Usuario anulacion", Storage:="USUARIO_ANULACION", DbType:="VARCHAR(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
    Public Property USUARIO_ANULACION() As String
        Get
            Return _USUARIO_ANULACION
        End Get
        Set(ByVal Value As String)
            _USUARIO_ANULACION = Value
            OnPropertyChanged("USUARIO_ANULACION")
        End Set
    End Property 

    Private _USUARIO_ANULACIONOld As String
    Public Property USUARIO_ANULACIONOld() As String
        Get
            Return _USUARIO_ANULACIONOld
        End Get
        Set(ByVal Value As String)
            _USUARIO_ANULACIONOld = Value
        End Set
    End Property 

    Private _FECHA_ANULACION As DateTime
    <Column(Name:="Fecha anulacion", Storage:="FECHA_ANULACION", DbType:="DATETIME", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_ANULACION() As DateTime
        Get
            Return _FECHA_ANULACION
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_ANULACION = Value
            OnPropertyChanged("FECHA_ANULACION")
        End Set
    End Property 

    Private _FECHA_ANULACIONOld As DateTime
    Public Property FECHA_ANULACIONOld() As DateTime
        Get
            Return _FECHA_ANULACIONOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_ANULACIONOld = Value
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

    Private _ES_BARRIDO As Boolean
    <Column(Name:="Es barrido", Storage:="ES_BARRIDO", DbType:="BIT", Id:=False), _
     DataObjectField(False, False, True, 1)> _
    Public Property ES_BARRIDO() As Boolean
        Get
            Return _ES_BARRIDO
        End Get
        Set(ByVal Value As Boolean)
            _ES_BARRIDO = Value
            OnPropertyChanged("ES_BARRIDO")
        End Set
    End Property 

    Private _ES_BARRIDOOld As Boolean
    Public Property ES_BARRIDOOld() As Boolean
        Get
            Return _ES_BARRIDOOld
        End Get
        Set(ByVal Value As Boolean)
            _ES_BARRIDOOld = Value
        End Set
    End Property 

    Private _ES_PRIMERENVIO_TURNO As Boolean
    <Column(Name:="Es primerenvio turno", Storage:="ES_PRIMERENVIO_TURNO", DbType:="BIT", Id:=False), _
     DataObjectField(False, False, True, 1)> _
    Public Property ES_PRIMERENVIO_TURNO() As Boolean
        Get
            Return _ES_PRIMERENVIO_TURNO
        End Get
        Set(ByVal Value As Boolean)
            _ES_PRIMERENVIO_TURNO = Value
            OnPropertyChanged("ES_PRIMERENVIO_TURNO")
        End Set
    End Property 

    Private _ES_PRIMERENVIO_TURNOOld As Boolean
    Public Property ES_PRIMERENVIO_TURNOOld() As Boolean
        Get
            Return _ES_PRIMERENVIO_TURNOOld
        End Get
        Set(ByVal Value As Boolean)
            _ES_PRIMERENVIO_TURNOOld = Value
        End Set
    End Property 

    Private _ES_ULTENVIO_TURNO As Boolean
    <Column(Name:="Es ultenvio turno", Storage:="ES_ULTENVIO_TURNO", DbType:="BIT", Id:=False), _
     DataObjectField(False, False, True, 1)> _
    Public Property ES_ULTENVIO_TURNO() As Boolean
        Get
            Return _ES_ULTENVIO_TURNO
        End Get
        Set(ByVal Value As Boolean)
            _ES_ULTENVIO_TURNO = Value
            OnPropertyChanged("ES_ULTENVIO_TURNO")
        End Set
    End Property 

    Private _ES_ULTENVIO_TURNOOld As Boolean
    Public Property ES_ULTENVIO_TURNOOld() As Boolean
        Get
            Return _ES_ULTENVIO_TURNOOld
        End Get
        Set(ByVal Value As Boolean)
            _ES_ULTENVIO_TURNOOld = Value
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
