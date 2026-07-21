''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.ESTICANA_XLS_DETA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row ESTICANA_XLS_DETA en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	10/12/2022	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="ESTICANA_XLS_DETA")> Public Class ESTICANA_XLS_DETA
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_DETA As Int32, aID_ENCA As Int32, aACCESLOTE As String, aZONA As String, aMZ As Decimal, aTC_MZ As Decimal, aTC As Decimal, aOB_PROD_INTERNA As String, aOB_PERSO_TEC As String, aMZ_PERDIDA As Decimal, aTC_PERDIDA As Decimal, aRENOVACION As Decimal, aSIEMBRA_NUEVA As Decimal, aSIEMBRA_PROYE As Decimal, aMZ_PENDIENTE As Decimal, aTC_PENDIENTE As Decimal, aTIPO_ROZA As String, aTIPO_TRANSPORTE As String, aTIPO_QUEMA As String, aMAD_APLICAR As String, aMAD_DOSIS As Decimal, aMAD_FECHA_APLI As DateTime)
        Me._ID_DETA = aID_DETA
        Me._ID_ENCA = aID_ENCA
        Me._ACCESLOTE = aACCESLOTE
        Me._ZONA = aZONA
        Me._MZ = aMZ
        Me._TC_MZ = aTC_MZ
        Me._TC = aTC
        Me._OB_PROD_INTERNA = aOB_PROD_INTERNA
        Me._OB_PERSO_TEC = aOB_PERSO_TEC
        Me._MZ_PERDIDA = aMZ_PERDIDA
        Me._TC_PERDIDA = aTC_PERDIDA
        Me._RENOVACION = aRENOVACION
        Me._SIEMBRA_NUEVA = aSIEMBRA_NUEVA
        Me._SIEMBRA_PROYE = aSIEMBRA_PROYE
        Me._MZ_PENDIENTE = aMZ_PENDIENTE
        Me._TC_PENDIENTE = aTC_PENDIENTE
        Me._TIPO_ROZA = aTIPO_ROZA
        Me._TIPO_TRANSPORTE = aTIPO_TRANSPORTE
        Me._TIPO_QUEMA = aTIPO_QUEMA
        Me._MAD_APLICAR = aMAD_APLICAR
        Me._MAD_DOSIS = aMAD_DOSIS
        Me._MAD_FECHA_APLI = aMAD_FECHA_APLI
    End Sub

#Region " Properties "

    Private _ID_DETA As Int32
    <Column(Name:="Id deta", Storage:="ID_DETA", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_DETA() As Int32
        Get
            Return _ID_DETA
        End Get
        Set(ByVal Value As Int32)
            _ID_DETA = Value
            OnPropertyChanged("ID_DETA")
        End Set
    End Property 

    Private _ID_ENCA As Int32
    <Column(Name:="Id enca", Storage:="ID_ENCA", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_ENCA() As Int32
        Get
            Return _ID_ENCA
        End Get
        Set(ByVal Value As Int32)
            _ID_ENCA = Value
            OnPropertyChanged("ID_ENCA")
        End Set
    End Property 

    Private _ID_ENCAOld As Int32
    Public Property ID_ENCAOld() As Int32
        Get
            Return _ID_ENCAOld
        End Get
        Set(ByVal Value As Int32)
            _ID_ENCAOld = Value
        End Set
    End Property 

    Private _fkID_ENCA As ESTICANA_XLS_ENCA
    Public Property fkID_ENCA() As ESTICANA_XLS_ENCA
        Get
            Return _fkID_ENCA
        End Get
        Set(ByVal Value As ESTICANA_XLS_ENCA)
            _fkID_ENCA = Value
        End Set
    End Property 

    Private _ACCESLOTE As String
    <Column(Name:="Acceslote", Storage:="ACCESLOTE", DbType:="NVARCHAR(510)", Id:=False), _
     DataObjectField(False, False, True, 510)> _
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

    Private _ZONA As String
    <Column(Name:="Zona", Storage:="ZONA", DbType:="NVARCHAR(510)", Id:=False), _
     DataObjectField(False, False, True, 510)> _
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

    Private _MZ As Decimal
    <Column(Name:="Mz", Storage:="MZ", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
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

    Private _TC_MZ As Decimal
    <Column(Name:="Tc mz", Storage:="TC_MZ", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property TC_MZ() As Decimal
        Get
            Return _TC_MZ
        End Get
        Set(ByVal Value As Decimal)
            _TC_MZ = Value
            OnPropertyChanged("TC_MZ")
        End Set
    End Property 

    Private _TC_MZOld As Decimal
    Public Property TC_MZOld() As Decimal
        Get
            Return _TC_MZOld
        End Get
        Set(ByVal Value As Decimal)
            _TC_MZOld = Value
        End Set
    End Property 

    Private _TC As Decimal
    <Column(Name:="Tc", Storage:="TC", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property TC() As Decimal
        Get
            Return _TC
        End Get
        Set(ByVal Value As Decimal)
            _TC = Value
            OnPropertyChanged("TC")
        End Set
    End Property 

    Private _TCOld As Decimal
    Public Property TCOld() As Decimal
        Get
            Return _TCOld
        End Get
        Set(ByVal Value As Decimal)
            _TCOld = Value
        End Set
    End Property 

    Private _OB_PROD_INTERNA As String
    <Column(Name:="Ob prod interna", Storage:="OB_PROD_INTERNA", DbType:="VARCHAR(500)", Id:=False), _
     DataObjectField(False, False, True, 500)> _
    Public Property OB_PROD_INTERNA() As String
        Get
            Return _OB_PROD_INTERNA
        End Get
        Set(ByVal Value As String)
            _OB_PROD_INTERNA = Value
            OnPropertyChanged("OB_PROD_INTERNA")
        End Set
    End Property 

    Private _OB_PROD_INTERNAOld As String
    Public Property OB_PROD_INTERNAOld() As String
        Get
            Return _OB_PROD_INTERNAOld
        End Get
        Set(ByVal Value As String)
            _OB_PROD_INTERNAOld = Value
        End Set
    End Property 

    Private _OB_PERSO_TEC As String
    <Column(Name:="Ob perso tec", Storage:="OB_PERSO_TEC", DbType:="VARCHAR(500)", Id:=False), _
     DataObjectField(False, False, True, 500)> _
    Public Property OB_PERSO_TEC() As String
        Get
            Return _OB_PERSO_TEC
        End Get
        Set(ByVal Value As String)
            _OB_PERSO_TEC = Value
            OnPropertyChanged("OB_PERSO_TEC")
        End Set
    End Property 

    Private _OB_PERSO_TECOld As String
    Public Property OB_PERSO_TECOld() As String
        Get
            Return _OB_PERSO_TECOld
        End Get
        Set(ByVal Value As String)
            _OB_PERSO_TECOld = Value
        End Set
    End Property 

    Private _MZ_PERDIDA As Decimal
    <Column(Name:="Mz perdida", Storage:="MZ_PERDIDA", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property MZ_PERDIDA() As Decimal
        Get
            Return _MZ_PERDIDA
        End Get
        Set(ByVal Value As Decimal)
            _MZ_PERDIDA = Value
            OnPropertyChanged("MZ_PERDIDA")
        End Set
    End Property 

    Private _MZ_PERDIDAOld As Decimal
    Public Property MZ_PERDIDAOld() As Decimal
        Get
            Return _MZ_PERDIDAOld
        End Get
        Set(ByVal Value As Decimal)
            _MZ_PERDIDAOld = Value
        End Set
    End Property 

    Private _TC_PERDIDA As Decimal
    <Column(Name:="Tc perdida", Storage:="TC_PERDIDA", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property TC_PERDIDA() As Decimal
        Get
            Return _TC_PERDIDA
        End Get
        Set(ByVal Value As Decimal)
            _TC_PERDIDA = Value
            OnPropertyChanged("TC_PERDIDA")
        End Set
    End Property 

    Private _TC_PERDIDAOld As Decimal
    Public Property TC_PERDIDAOld() As Decimal
        Get
            Return _TC_PERDIDAOld
        End Get
        Set(ByVal Value As Decimal)
            _TC_PERDIDAOld = Value
        End Set
    End Property 

    Private _RENOVACION As Decimal
    <Column(Name:="Renovacion", Storage:="RENOVACION", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property RENOVACION() As Decimal
        Get
            Return _RENOVACION
        End Get
        Set(ByVal Value As Decimal)
            _RENOVACION = Value
            OnPropertyChanged("RENOVACION")
        End Set
    End Property 

    Private _RENOVACIONOld As Decimal
    Public Property RENOVACIONOld() As Decimal
        Get
            Return _RENOVACIONOld
        End Get
        Set(ByVal Value As Decimal)
            _RENOVACIONOld = Value
        End Set
    End Property 

    Private _SIEMBRA_NUEVA As Decimal
    <Column(Name:="Siembra nueva", Storage:="SIEMBRA_NUEVA", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property SIEMBRA_NUEVA() As Decimal
        Get
            Return _SIEMBRA_NUEVA
        End Get
        Set(ByVal Value As Decimal)
            _SIEMBRA_NUEVA = Value
            OnPropertyChanged("SIEMBRA_NUEVA")
        End Set
    End Property 

    Private _SIEMBRA_NUEVAOld As Decimal
    Public Property SIEMBRA_NUEVAOld() As Decimal
        Get
            Return _SIEMBRA_NUEVAOld
        End Get
        Set(ByVal Value As Decimal)
            _SIEMBRA_NUEVAOld = Value
        End Set
    End Property 

    Private _SIEMBRA_PROYE As Decimal
    <Column(Name:="Siembra proye", Storage:="SIEMBRA_PROYE", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property SIEMBRA_PROYE() As Decimal
        Get
            Return _SIEMBRA_PROYE
        End Get
        Set(ByVal Value As Decimal)
            _SIEMBRA_PROYE = Value
            OnPropertyChanged("SIEMBRA_PROYE")
        End Set
    End Property 

    Private _SIEMBRA_PROYEOld As Decimal
    Public Property SIEMBRA_PROYEOld() As Decimal
        Get
            Return _SIEMBRA_PROYEOld
        End Get
        Set(ByVal Value As Decimal)
            _SIEMBRA_PROYEOld = Value
        End Set
    End Property 

    Private _MZ_PENDIENTE As Decimal
    <Column(Name:="Mz pendiente", Storage:="MZ_PENDIENTE", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property MZ_PENDIENTE() As Decimal
        Get
            Return _MZ_PENDIENTE
        End Get
        Set(ByVal Value As Decimal)
            _MZ_PENDIENTE = Value
            OnPropertyChanged("MZ_PENDIENTE")
        End Set
    End Property 

    Private _MZ_PENDIENTEOld As Decimal
    Public Property MZ_PENDIENTEOld() As Decimal
        Get
            Return _MZ_PENDIENTEOld
        End Get
        Set(ByVal Value As Decimal)
            _MZ_PENDIENTEOld = Value
        End Set
    End Property 

    Private _TC_PENDIENTE As Decimal
    <Column(Name:="Tc pendiente", Storage:="TC_PENDIENTE", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property TC_PENDIENTE() As Decimal
        Get
            Return _TC_PENDIENTE
        End Get
        Set(ByVal Value As Decimal)
            _TC_PENDIENTE = Value
            OnPropertyChanged("TC_PENDIENTE")
        End Set
    End Property 

    Private _TC_PENDIENTEOld As Decimal
    Public Property TC_PENDIENTEOld() As Decimal
        Get
            Return _TC_PENDIENTEOld
        End Get
        Set(ByVal Value As Decimal)
            _TC_PENDIENTEOld = Value
        End Set
    End Property 

    Private _TIPO_ROZA As String
    <Column(Name:="Tipo roza", Storage:="TIPO_ROZA", DbType:="VARCHAR(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
    Public Property TIPO_ROZA() As String
        Get
            Return _TIPO_ROZA
        End Get
        Set(ByVal Value As String)
            _TIPO_ROZA = Value
            OnPropertyChanged("TIPO_ROZA")
        End Set
    End Property 

    Private _TIPO_ROZAOld As String
    Public Property TIPO_ROZAOld() As String
        Get
            Return _TIPO_ROZAOld
        End Get
        Set(ByVal Value As String)
            _TIPO_ROZAOld = Value
        End Set
    End Property 

    Private _TIPO_TRANSPORTE As String
    <Column(Name:="Tipo transporte", Storage:="TIPO_TRANSPORTE", DbType:="VARCHAR(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
    Public Property TIPO_TRANSPORTE() As String
        Get
            Return _TIPO_TRANSPORTE
        End Get
        Set(ByVal Value As String)
            _TIPO_TRANSPORTE = Value
            OnPropertyChanged("TIPO_TRANSPORTE")
        End Set
    End Property 

    Private _TIPO_TRANSPORTEOld As String
    Public Property TIPO_TRANSPORTEOld() As String
        Get
            Return _TIPO_TRANSPORTEOld
        End Get
        Set(ByVal Value As String)
            _TIPO_TRANSPORTEOld = Value
        End Set
    End Property 

    Private _TIPO_QUEMA As String
    <Column(Name:="Tipo quema", Storage:="TIPO_QUEMA", DbType:="VARCHAR(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
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

    Private _MAD_APLICAR As String
    <Column(Name:="Mad aplicar", Storage:="MAD_APLICAR", DbType:="VARCHAR(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
    Public Property MAD_APLICAR() As String
        Get
            Return _MAD_APLICAR
        End Get
        Set(ByVal Value As String)
            _MAD_APLICAR = Value
            OnPropertyChanged("MAD_APLICAR")
        End Set
    End Property 

    Private _MAD_APLICAROld As String
    Public Property MAD_APLICAROld() As String
        Get
            Return _MAD_APLICAROld
        End Get
        Set(ByVal Value As String)
            _MAD_APLICAROld = Value
        End Set
    End Property 

    Private _MAD_DOSIS As Decimal
    <Column(Name:="Mad dosis", Storage:="MAD_DOSIS", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property MAD_DOSIS() As Decimal
        Get
            Return _MAD_DOSIS
        End Get
        Set(ByVal Value As Decimal)
            _MAD_DOSIS = Value
            OnPropertyChanged("MAD_DOSIS")
        End Set
    End Property 

    Private _MAD_DOSISOld As Decimal
    Public Property MAD_DOSISOld() As Decimal
        Get
            Return _MAD_DOSISOld
        End Get
        Set(ByVal Value As Decimal)
            _MAD_DOSISOld = Value
        End Set
    End Property 

    Private _MAD_FECHA_APLI As DateTime
    <Column(Name:="Mad fecha apli", Storage:="MAD_FECHA_APLI", DbType:="DATETIME", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property MAD_FECHA_APLI() As DateTime
        Get
            Return _MAD_FECHA_APLI
        End Get
        Set(ByVal Value As DateTime)
            _MAD_FECHA_APLI = Value
            OnPropertyChanged("MAD_FECHA_APLI")
        End Set
    End Property 

    Private _MAD_FECHA_APLIOld As DateTime
    Public Property MAD_FECHA_APLIOld() As DateTime
        Get
            Return _MAD_FECHA_APLIOld
        End Get
        Set(ByVal Value As DateTime)
            _MAD_FECHA_APLIOld = Value
        End Set
    End Property


    Private _OBSERVACIONES As String
    <Column(Name:="Observaciones", Storage:="OBSERVACIONES", DBType:="VARCHAR(1000)", Id:=False),
     DataObjectField(False, False, True, 1000)>
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


    Private _CANA_VARIEDAD As String
    <Column(Name:="Cana variedad", Storage:="CANA_VARIEDAD", DBType:="VARCHAR(200)", Id:=False),
     DataObjectField(False, False, True, 200)>
    Public Property CANA_VARIEDAD() As String
        Get
            Return _CANA_VARIEDAD
        End Get
        Set(ByVal Value As String)
            _CANA_VARIEDAD = Value
            OnPropertyChanged("CANA_VARIEDAD")
        End Set
    End Property

    Private _CANA_VARIEDADOld As String
    Public Property CANA_VARIEDADOld() As String
        Get
            Return _CANA_VARIEDADOld
        End Get
        Set(ByVal Value As String)
            _CANA_VARIEDADOld = Value
        End Set
    End Property


    Private _CONCEPTO As String
    <Column(Name:="Concepto", Storage:="CONCEPTO", DBType:="VARCHAR(500)", Id:=False),
     DataObjectField(False, False, True, 500)>
    Public Property CONCEPTO() As String
        Get
            Return _CONCEPTO
        End Get
        Set(ByVal Value As String)
            _CONCEPTO = Value
            OnPropertyChanged("CONCEPTO")
        End Set
    End Property

    Private _CONCEPTOOld As String
    Public Property CONCEPTOOld() As String
        Get
            Return _CONCEPTOOld
        End Get
        Set(ByVal Value As String)
            _CONCEPTOOld = Value
        End Set
    End Property

    Private _EQUIPO_ANTERIOR As String
    <Column(Name:="Equipo anterior", Storage:="EQUIPO_ANTERIOR", DBType:="VARCHAR(500)", Id:=False),
     DataObjectField(False, False, True, 500)>
    Public Property EQUIPO_ANTERIOR() As String
        Get
            Return _EQUIPO_ANTERIOR
        End Get
        Set(ByVal Value As String)
            _EQUIPO_ANTERIOR = Value
            OnPropertyChanged("EQUIPO_ANTERIOR")
        End Set
    End Property

    Private _EQUIPO_ANTERIOROld As String
    Public Property EQUIPO_ANTERIOROld() As String
        Get
            Return _EQUIPO_ANTERIOROld
        End Get
        Set(ByVal Value As String)
            _EQUIPO_ANTERIOROld = Value
        End Set
    End Property

    Private _AREA_ANTERIOR As Decimal
    <Column(Name:="Area anterior", Storage:="AREA_ANTERIOR", DBType:="NUMERIC(20,2)", Id:=False),
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)>
    Public Property AREA_ANTERIOR() As Decimal
        Get
            Return _AREA_ANTERIOR
        End Get
        Set(ByVal Value As Decimal)
            _AREA_ANTERIOR = Value
            OnPropertyChanged("AREA_ANTERIOR")
        End Set
    End Property

    Private _AREA_ANTERIOROld As Decimal
    Public Property AREA_ANTERIOROld() As Decimal
        Get
            Return _AREA_ANTERIOROld
        End Get
        Set(ByVal Value As Decimal)
            _AREA_ANTERIOROld = Value
        End Set
    End Property

    Private _MAD_APLI_DOSIS_ACTUAL As Decimal
    <Column(Name:="Mad aplic dosis actual", Storage:="MAD_APLI_DOSIS_ACTUAL", DBType:="NUMERIC(20,2)", Id:=False),
      DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)>
    Public Property MAD_APLI_DOSIS_ACTUAL() As Decimal
        Get
            Return _MAD_APLI_DOSIS_ACTUAL
        End Get
        Set(ByVal Value As Decimal)
            _MAD_APLI_DOSIS_ACTUAL = Value
            OnPropertyChanged("MAD_APLI_DOSIS_ACTUAL")
        End Set
    End Property

    Private _MAD_APLI_DOSIS_ACTUALOld As Decimal
    Public Property MAD_APLI_DOSIS_ACTUALOld() As Decimal
        Get
            Return _MAD_APLI_DOSIS_ACTUALOld
        End Get
        Set(ByVal Value As Decimal)
            _MAD_APLI_DOSIS_ACTUALOld = Value
        End Set
    End Property

    Private _EQUIPO_ACTUAL As String
    <Column(Name:="Equipo actual", Storage:="EQUIPO_ACTUAL", DBType:="VARCHAR(500)", Id:=False),
     DataObjectField(False, False, True, 500)>
    Public Property EQUIPO_ACTUAL() As String
        Get
            Return _EQUIPO_ACTUAL
        End Get
        Set(ByVal Value As String)
            _EQUIPO_ACTUAL = Value
            OnPropertyChanged("EQUIPO_ACTUAL")
        End Set
    End Property

    Private _EQUIPO_ACTUALOld As String
    Public Property EQUIPO_ACTUALOld() As String
        Get
            Return _EQUIPO_ACTUALOld
        End Get
        Set(ByVal Value As String)
            _EQUIPO_ACTUALOld = Value
        End Set
    End Property

    Private _ACCESLOTE_ANT As String
    <Column(Name:="Acceslote_ant", Storage:="ACCESLOTE_ANT", DBType:="NVARCHAR(510)", Id:=False),
     DataObjectField(False, False, True, 510)>
    Public Property ACCESLOTE_ANT() As String
        Get
            Return _ACCESLOTE_ANT
        End Get
        Set(ByVal Value As String)
            _ACCESLOTE_ANT = Value
            OnPropertyChanged("ACCESLOTE_ANT")
        End Set
    End Property

    Private _ACCESLOTE_ANTOld As String
    Public Property ACCESLOTE_ANTOld() As String
        Get
            Return _ACCESLOTE_ANTOld
        End Get
        Set(ByVal Value As String)
            _ACCESLOTE_ANTOld = Value
        End Set
    End Property

    Private _SEMILLA_MZ As Decimal
    <Column(Name:="Semilla MZ", Storage:="SEMILLA_MZ", DBType:="NUMERIC(20,2)", Id:=False),
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)>
    Public Property SEMILLA_MZ() As Decimal
        Get
            Return _SEMILLA_MZ
        End Get
        Set(ByVal Value As Decimal)
            _SEMILLA_MZ = Value
            OnPropertyChanged("SEMILLA_MZ")
        End Set
    End Property

    Private _SEMILLA_MZOld As Decimal
    Public Property SEMILLA_MZOld() As Decimal
        Get
            Return _SEMILLA_MZOld
        End Get
        Set(ByVal Value As Decimal)
            _SEMILLA_MZOld = Value
        End Set
    End Property

    Private _SEMILLA_TC As Decimal
    <Column(Name:="Semilla TC", Storage:="SEMILLA_TC", DBType:="NUMERIC(20,2)", Id:=False),
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)>
    Public Property SEMILLA_TC() As Decimal
        Get
            Return _SEMILLA_TC
        End Get
        Set(ByVal Value As Decimal)
            _SEMILLA_TC = Value
            OnPropertyChanged("SEMILLA_TC")
        End Set
    End Property

    Private _SEMILLA_TCOld As Decimal
    Public Property SEMILLA_TCOld() As Decimal
        Get
            Return _SEMILLA_TCOld
        End Get
        Set(ByVal Value As Decimal)
            _SEMILLA_TCOld = Value
        End Set
    End Property


    Private _GRUPO_Z1 As String
    <Column(Name:="GRUPO_Z1", Storage:="GRUPO_Z1", DBType:="NVARCHAR(100)", Id:=False),
     DataObjectField(False, False, True, 100)>
    Public Property GRUPO_Z1() As String
        Get
            Return _GRUPO_Z1
        End Get
        Set(ByVal Value As String)
            _GRUPO_Z1 = Value
            OnPropertyChanged("GRUPO_Z1")
        End Set
    End Property

    Private _GRUPO_Z1Old As String
    Public Property GRUPO_Z1Old() As String
        Get
            Return _GRUPO_Z1Old
        End Get
        Set(ByVal Value As String)
            _GRUPO_Z1Old = Value
        End Set
    End Property

    Private _HA_Z1 As Decimal
    <Column(Name:="HA_Z1", Storage:="HA_Z1", DBType:="NUMERIC(20,3)", Id:=False),
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=3)>
    Public Property HA_Z1() As Decimal
        Get
            Return _HA_Z1
        End Get
        Set(ByVal Value As Decimal)
            _HA_Z1 = Value
            OnPropertyChanged("HA_Z1")
        End Set
    End Property

    Private _HA_Z1Old As Decimal
    Public Property HA_Z1Old() As Decimal
        Get
            Return _HA_Z1Old
        End Get
        Set(ByVal Value As Decimal)
            _HA_Z1Old = Value
        End Set
    End Property

    Private _TC_Z1 As Decimal
    <Column(Name:="TC_Z1", Storage:="TC_Z1", DBType:="NUMERIC(20,4)", Id:=False),
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=4)>
    Public Property TC_Z1() As Decimal
        Get
            Return _TC_Z1
        End Get
        Set(ByVal Value As Decimal)
            _TC_Z1 = Value
            OnPropertyChanged("TC_Z1")
        End Set
    End Property

    Private _TC_Z1Old As Decimal
    Public Property TC_Z1Old() As Decimal
        Get
            Return _TC_Z1Old
        End Get
        Set(ByVal Value As Decimal)
            _TC_Z1Old = Value
        End Set
    End Property

    Private _TCH_Z1 As Integer
    <Column(Name:="TCH_Z1", Storage:="TCH_Z1", DBType:="INT", Id:=False),
     DataObjectField(False, False, True)>
    Public Property TCH_Z1() As Integer
        Get
            Return _TCH_Z1
        End Get
        Set(ByVal Value As Integer)
            _TCH_Z1 = Value
            OnPropertyChanged("TCH_Z1")
        End Set
    End Property

    Private _TCH_Z1Old As Integer
    Public Property TCH_Z1Old() As Integer
        Get
            Return _TCH_Z1Old
        End Get
        Set(ByVal Value As Integer)
            _TCH_Z1Old = Value
        End Set
    End Property

    Private _GRUPO_Z2 As String
    <Column(Name:="GRUPO_Z2", Storage:="GRUPO_Z2", DBType:="NVARCHAR(100)", Id:=False),
     DataObjectField(False, False, True, 100)>
    Public Property GRUPO_Z2() As String
        Get
            Return _GRUPO_Z2
        End Get
        Set(ByVal Value As String)
            _GRUPO_Z2 = Value
            OnPropertyChanged("GRUPO_Z2")
        End Set
    End Property

    Private _GRUPO_Z2Old As String
    Public Property GRUPO_Z2Old() As String
        Get
            Return _GRUPO_Z2Old
        End Get
        Set(ByVal Value As String)
            _GRUPO_Z2Old = Value
        End Set
    End Property

    Private _HA_EFEC_Z2 As Decimal
    <Column(Name:="HA_EFEC_Z2", Storage:="HA_EFEC_Z2", DBType:="NUMERIC(20,3)", Id:=False),
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=3)>
    Public Property HA_EFEC_Z2() As Decimal
        Get
            Return _HA_EFEC_Z2
        End Get
        Set(ByVal Value As Decimal)
            _HA_EFEC_Z2 = Value
            OnPropertyChanged("HA_EFEC_Z2")
        End Set
    End Property

    Private _HA_EFEC_Z2Old As Decimal
    Public Property HA_EFEC_Z2Old() As Decimal
        Get
            Return _HA_EFEC_Z2Old
        End Get
        Set(ByVal Value As Decimal)
            _HA_EFEC_Z2Old = Value
        End Set
    End Property

    Private _TCH_Z2 As Integer
    <Column(Name:="TCH_Z2", Storage:="TCH_Z2", DBType:="INT", Id:=False),
     DataObjectField(False, False, True)>
    Public Property TCH_Z2() As Integer
        Get
            Return _TCH_Z2
        End Get
        Set(ByVal Value As Integer)
            _TCH_Z2 = Value
            OnPropertyChanged("TCH_Z2")
        End Set
    End Property

    Private _TCH_Z2Old As Integer
    Public Property TCH_Z2Old() As Integer
        Get
            Return _TCH_Z2Old
        End Get
        Set(ByVal Value As Integer)
            _TCH_Z2Old = Value
        End Set
    End Property

    Private _TC_Z2 As Decimal
    <Column(Name:="TC_Z2", Storage:="TC_Z2", DBType:="NUMERIC(20,4)", Id:=False),
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=4)>
    Public Property TC_Z2() As Decimal
        Get
            Return _TC_Z2
        End Get
        Set(ByVal Value As Decimal)
            _TC_Z2 = Value
            OnPropertyChanged("TC_Z2")
        End Set
    End Property

    Private _TC_Z2Old As Decimal
    Public Property TC_Z2Old() As Decimal
        Get
            Return _TC_Z2Old
        End Get
        Set(ByVal Value As Decimal)
            _TC_Z2Old = Value
        End Set
    End Property

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
