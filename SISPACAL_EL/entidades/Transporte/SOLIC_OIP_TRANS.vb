''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.SOLIC_OIP_TRANS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row SOLIC_OIP_TRANS en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	24/10/2017	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="SOLIC_OIP_TRANS")> Public Class SOLIC_OIP_TRANS
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_OIP_TRANS As Int32, aCODTRANSPORT As Int32, aID_ZAFRA As Int32, aCODIBANCO As Int32, aFECHA As DateTime, aMONTO As Decimal, aCUOTA_CORTE As Decimal, aUID_OIP_TRANS As Guid, aPORC_DESC As Decimal, aPORC_DESCEFECTIVO As Decimal, aNUM_OIP_ZAFRA As Int32, aREFERENCIA_GF As String, aES_ACEPTADA As Boolean, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime)
        Me._ID_OIP_TRANS = aID_OIP_TRANS
        Me._CODTRANSPORT = aCODTRANSPORT
        Me._ID_ZAFRA = aID_ZAFRA
        Me._CODIBANCO = aCODIBANCO
        Me._FECHA = aFECHA
        Me._MONTO = aMONTO
        Me._CUOTA_CORTE = aCUOTA_CORTE
        Me._UID_OIP_TRANS = aUID_OIP_TRANS
        Me._PORC_DESC = aPORC_DESC
        Me._PORC_DESCEFECTIVO = aPORC_DESCEFECTIVO
        Me._NUM_OIP_ZAFRA = aNUM_OIP_ZAFRA
        Me._REFERENCIA_GF = aREFERENCIA_GF
        Me._ES_ACEPTADA = aES_ACEPTADA
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
    End Sub

#Region " Properties "

    Private _ID_OIP_TRANS As Int32
    <Column(Name:="Id oip trans", Storage:="ID_OIP_TRANS", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_OIP_TRANS() As Int32
        Get
            Return _ID_OIP_TRANS
        End Get
        Set(ByVal Value As Int32)
            _ID_OIP_TRANS = Value
            OnPropertyChanged("ID_OIP_TRANS")
        End Set
    End Property 

    Private _CODTRANSPORT As Int32
    <Column(Name:="Codtransport", Storage:="CODTRANSPORT", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
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

    Private _ID_ZAFRA As Int32
    <Column(Name:="Id zafra", Storage:="ID_ZAFRA", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
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

    Private _CODIBANCO As Int32
    <Column(Name:="Codibanco", Storage:="CODIBANCO", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property CODIBANCO() As Int32
        Get
            Return _CODIBANCO
        End Get
        Set(ByVal Value As Int32)
            _CODIBANCO = Value
            OnPropertyChanged("CODIBANCO")
        End Set
    End Property 

    Private _CODIBANCOOld As Int32
    Public Property CODIBANCOOld() As Int32
        Get
            Return _CODIBANCOOld
        End Get
        Set(ByVal Value As Int32)
            _CODIBANCOOld = Value
        End Set
    End Property 

    Private _fkCODIBANCO As BANCOS
    Public Property fkCODIBANCO() As BANCOS
        Get
            Return _fkCODIBANCO
        End Get
        Set(ByVal Value As BANCOS)
            _fkCODIBANCO = Value
        End Set
    End Property 

    Private _FECHA As DateTime
    <Column(Name:="Fecha", Storage:="FECHA", DbType:="DATETIME", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA() As DateTime
        Get
            Return _FECHA
        End Get
        Set(ByVal Value As DateTime)
            _FECHA = Value
            OnPropertyChanged("FECHA")
        End Set
    End Property 

    Private _FECHAOld As DateTime
    Public Property FECHAOld() As DateTime
        Get
            Return _FECHAOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHAOld = Value
        End Set
    End Property 

    Private _MONTO As Decimal
    <Column(Name:="Monto", Storage:="MONTO", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property MONTO() As Decimal
        Get
            Return _MONTO
        End Get
        Set(ByVal Value As Decimal)
            _MONTO = Value
            OnPropertyChanged("MONTO")
        End Set
    End Property 

    Private _MONTOOld As Decimal
    Public Property MONTOOld() As Decimal
        Get
            Return _MONTOOld
        End Get
        Set(ByVal Value As Decimal)
            _MONTOOld = Value
        End Set
    End Property 

    Private _CUOTA_CORTE As Decimal
    <Column(Name:="Cuota corte", Storage:="CUOTA_CORTE", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property CUOTA_CORTE() As Decimal
        Get
            Return _CUOTA_CORTE
        End Get
        Set(ByVal Value As Decimal)
            _CUOTA_CORTE = Value
            OnPropertyChanged("CUOTA_CORTE")
        End Set
    End Property 

    Private _CUOTA_CORTEOld As Decimal
    Public Property CUOTA_CORTEOld() As Decimal
        Get
            Return _CUOTA_CORTEOld
        End Get
        Set(ByVal Value As Decimal)
            _CUOTA_CORTEOld = Value
        End Set
    End Property 

    Private _UID_OIP_TRANS As Guid
    <Column(Name:="Uid oip trans", Storage:="UID_OIP_TRANS", DbType:="UNIQUEIDENTIFIER(36, 0)", Id:=False), _
     DataObjectField(False, False, True, 16)> _
    Public Property UID_OIP_TRANS() As Guid
        Get
            Return _UID_OIP_TRANS
        End Get
        Set(ByVal Value As Guid)
            _UID_OIP_TRANS = Value
            OnPropertyChanged("UID_OIP_TRANS")
        End Set
    End Property 

    Private _UID_OIP_TRANSOld As Guid
    Public Property UID_OIP_TRANSOld() As Guid
        Get
            Return _UID_OIP_TRANSOld
        End Get
        Set(ByVal Value As Guid)
            _UID_OIP_TRANSOld = Value
        End Set
    End Property 

    Private _PORC_DESC As Decimal
    <Column(Name:="Porc desc", Storage:="PORC_DESC", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property PORC_DESC() As Decimal
        Get
            Return _PORC_DESC
        End Get
        Set(ByVal Value As Decimal)
            _PORC_DESC = Value
            OnPropertyChanged("PORC_DESC")
        End Set
    End Property 

    Private _PORC_DESCOld As Decimal
    Public Property PORC_DESCOld() As Decimal
        Get
            Return _PORC_DESCOld
        End Get
        Set(ByVal Value As Decimal)
            _PORC_DESCOld = Value
        End Set
    End Property 

    Private _PORC_DESCEFECTIVO As Decimal
    <Column(Name:="Porc descefectivo", Storage:="PORC_DESCEFECTIVO", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property PORC_DESCEFECTIVO() As Decimal
        Get
            Return _PORC_DESCEFECTIVO
        End Get
        Set(ByVal Value As Decimal)
            _PORC_DESCEFECTIVO = Value
            OnPropertyChanged("PORC_DESCEFECTIVO")
        End Set
    End Property 

    Private _PORC_DESCEFECTIVOOld As Decimal
    Public Property PORC_DESCEFECTIVOOld() As Decimal
        Get
            Return _PORC_DESCEFECTIVOOld
        End Get
        Set(ByVal Value As Decimal)
            _PORC_DESCEFECTIVOOld = Value
        End Set
    End Property 

    Private _NUM_OIP_ZAFRA As Int32
    <Column(Name:="Num oip zafra", Storage:="NUM_OIP_ZAFRA", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property NUM_OIP_ZAFRA() As Int32
        Get
            Return _NUM_OIP_ZAFRA
        End Get
        Set(ByVal Value As Int32)
            _NUM_OIP_ZAFRA = Value
            OnPropertyChanged("NUM_OIP_ZAFRA")
        End Set
    End Property 

    Private _NUM_OIP_ZAFRAOld As Int32
    Public Property NUM_OIP_ZAFRAOld() As Int32
        Get
            Return _NUM_OIP_ZAFRAOld
        End Get
        Set(ByVal Value As Int32)
            _NUM_OIP_ZAFRAOld = Value
        End Set
    End Property 

    Private _REFERENCIA_GF As String
    <Column(Name:="Referencia gf", Storage:="REFERENCIA_GF", DbType:="VARCHAR(20)", Id:=False), _
     DataObjectField(False, False, True, 20)> _
    Public Property REFERENCIA_GF() As String
        Get
            Return _REFERENCIA_GF
        End Get
        Set(ByVal Value As String)
            _REFERENCIA_GF = Value
            OnPropertyChanged("REFERENCIA_GF")
        End Set
    End Property 

    Private _REFERENCIA_GFOld As String
    Public Property REFERENCIA_GFOld() As String
        Get
            Return _REFERENCIA_GFOld
        End Get
        Set(ByVal Value As String)
            _REFERENCIA_GFOld = Value
        End Set
    End Property 

    Private _ES_ACEPTADA As Boolean
    <Column(Name:="Es aceptada", Storage:="ES_ACEPTADA", DbType:="BIT", Id:=False), _
     DataObjectField(False, False, True, 1)> _
    Public Property ES_ACEPTADA() As Boolean
        Get
            Return _ES_ACEPTADA
        End Get
        Set(ByVal Value As Boolean)
            _ES_ACEPTADA = Value
            OnPropertyChanged("ES_ACEPTADA")
        End Set
    End Property 

    Private _ES_ACEPTADAOld As Boolean
    Public Property ES_ACEPTADAOld() As Boolean
        Get
            Return _ES_ACEPTADAOld
        End Get
        Set(ByVal Value As Boolean)
            _ES_ACEPTADAOld = Value
        End Set
    End Property 

    Private _USUARIO_CREA As String
    <Column(Name:="Usuario crea", Storage:="USUARIO_CREA", DbType:="VARCHAR(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
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
    <Column(Name:="Fecha crea", Storage:="FECHA_CREA", DbType:="DATETIME", Id:=False), _
     DataObjectField(False, False, True)> _
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
    <Column(Name:="Usuario act", Storage:="USUARIO_ACT", DbType:="VARCHAR(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
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
    <Column(Name:="Fecha act", Storage:="FECHA_ACT", DbType:="DATETIME", Id:=False), _
     DataObjectField(False, False, True)> _
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
