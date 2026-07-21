''' -----------------------------------------------------------------------------
''' Project	 : INJIBOA_EL
''' Class	 : EL.LOTES_COSECHA_GESTION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row LOTES_COSECHA_GESTION en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	12/09/2022	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="LOTES_COSECHA_GESTION")> Public Class LOTES_COSECHA_GESTION
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_LOTE_COSE_GESTION As Int32, aID_LOTES_COSECHA As Int32, aACCESLOTE As String, aOB_PROD_INTERNA As String, aOB_PERSO_TEC As String, aMZ_PERDIDA As Decimal, aTC_PERDIDA As Decimal, aRENOVACION As Decimal, aSIEMBRA_NUEVA As Decimal, aSIEMBRA_PROYE As Decimal, aMZ_PENDIENTE As Decimal, aTC_PENDIENTE As Decimal, aTIPO_ROZA As String, aTIPO_TRANSPORTE As String, aTIPO_QUEMA As String, aMAD_APLICAR As String, aMAD_DOSIS As Decimal, aMAD_FECHA_APLI As DateTime)
        Me._ID_LOTE_COSE_GESTION = aID_LOTE_COSE_GESTION
        Me._ID_LOTES_COSECHA = aID_LOTES_COSECHA
        Me._ACCESLOTE = aACCESLOTE
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

    Private _ID_LOTE_COSE_GESTION As Int32
    <Column(Name:="Id lote cose gestion", Storage:="ID_LOTE_COSE_GESTION", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_LOTE_COSE_GESTION() As Int32
        Get
            Return _ID_LOTE_COSE_GESTION
        End Get
        Set(ByVal Value As Int32)
            _ID_LOTE_COSE_GESTION = Value
            OnPropertyChanged("ID_LOTE_COSE_GESTION")
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

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
