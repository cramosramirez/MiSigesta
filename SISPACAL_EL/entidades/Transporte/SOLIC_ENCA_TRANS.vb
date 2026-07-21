''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.SOLIC_ENCA_TRANS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row SOLIC_ENCA_TRANS en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	23/10/2017	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="SOLIC_ENCA_TRANS")> Public Class SOLIC_ENCA_TRANS
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_SOLICITUD As Int32, aID_ZAFRA As Int32, aID_CONTRA_TRANS As Int32, aID_CUENTA_FINAN As Int32, aCONDI_COMPRA As Int32, aNUM_SOLIC_ZAFRA As Int32, aCODTRANSPORT As Int32, aACTIVIDAD As String, aFECHA_SOLIC As DateTime, aID_CONTRA_TRANS_VEHI As Int32, aID_TRANSPORTE As Int32, aSUB_TOTAL As Decimal, aIVA As Decimal, aTOTAL As Decimal, aID_ESTADO_SOLIC As Int32, aUID_SOLIC_ENCA_TRANS As Guid, aOBSERVACIONES As String, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime, aZAFRA As String, aCESC As Decimal)
        Me._ID_SOLICITUD = aID_SOLICITUD
        Me._ID_ZAFRA = aID_ZAFRA
        Me._ID_CONTRA_TRANS = aID_CONTRA_TRANS
        Me._ID_CUENTA_FINAN = aID_CUENTA_FINAN
        Me._CONDI_COMPRA = aCONDI_COMPRA
        Me._NUM_SOLIC_ZAFRA = aNUM_SOLIC_ZAFRA
        Me._CODTRANSPORT = aCODTRANSPORT
        Me._ACTIVIDAD = aACTIVIDAD
        Me._FECHA_SOLIC = aFECHA_SOLIC
        Me._ID_CONTRA_TRANS_VEHI = aID_CONTRA_TRANS_VEHI
        Me._ID_TRANSPORTE = aID_TRANSPORTE
        Me._SUB_TOTAL = aSUB_TOTAL
        Me._IVA = aIVA
        Me._TOTAL = aTOTAL
        Me._ID_ESTADO_SOLIC = aID_ESTADO_SOLIC
        Me._UID_SOLIC_ENCA_TRANS = aUID_SOLIC_ENCA_TRANS
        Me._OBSERVACIONES = aOBSERVACIONES
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
        Me._ZAFRA = aZAFRA
        Me._CESC = aCESC
    End Sub

#Region " Properties "

    Private _ID_SOLICITUD As Int32
    <Column(Name:="Id solicitud", Storage:="ID_SOLICITUD", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_SOLICITUD() As Int32
        Get
            Return _ID_SOLICITUD
        End Get
        Set(ByVal Value As Int32)
            _ID_SOLICITUD = Value
            OnPropertyChanged("ID_SOLICITUD")
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

    Private _ID_CONTRA_TRANS As Int32
    <Column(Name:="Id contra trans", Storage:="ID_CONTRA_TRANS", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_CONTRA_TRANS() As Int32
        Get
            Return _ID_CONTRA_TRANS
        End Get
        Set(ByVal Value As Int32)
            _ID_CONTRA_TRANS = Value
            OnPropertyChanged("ID_CONTRA_TRANS")
        End Set
    End Property 

    Private _ID_CONTRA_TRANSOld As Int32
    Public Property ID_CONTRA_TRANSOld() As Int32
        Get
            Return _ID_CONTRA_TRANSOld
        End Get
        Set(ByVal Value As Int32)
            _ID_CONTRA_TRANSOld = Value
        End Set
    End Property 

    Private _ID_CUENTA_FINAN As Int32
    <Column(Name:="Id cuenta finan", Storage:="ID_CUENTA_FINAN", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_CUENTA_FINAN() As Int32
        Get
            Return _ID_CUENTA_FINAN
        End Get
        Set(ByVal Value As Int32)
            _ID_CUENTA_FINAN = Value
            OnPropertyChanged("ID_CUENTA_FINAN")
        End Set
    End Property 

    Private _ID_CUENTA_FINANOld As Int32
    Public Property ID_CUENTA_FINANOld() As Int32
        Get
            Return _ID_CUENTA_FINANOld
        End Get
        Set(ByVal Value As Int32)
            _ID_CUENTA_FINANOld = Value
        End Set
    End Property 

    Private _fkID_CUENTA_FINAN As CUENTA_FINAN
    Public Property fkID_CUENTA_FINAN() As CUENTA_FINAN
        Get
            Return _fkID_CUENTA_FINAN
        End Get
        Set(ByVal Value As CUENTA_FINAN)
            _fkID_CUENTA_FINAN = Value
        End Set
    End Property 

    Private _CONDI_COMPRA As Int32
    <Column(Name:="Condi compra", Storage:="CONDI_COMPRA", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property CONDI_COMPRA() As Int32
        Get
            Return _CONDI_COMPRA
        End Get
        Set(ByVal Value As Int32)
            _CONDI_COMPRA = Value
            OnPropertyChanged("CONDI_COMPRA")
        End Set
    End Property 

    Private _CONDI_COMPRAOld As Int32
    Public Property CONDI_COMPRAOld() As Int32
        Get
            Return _CONDI_COMPRAOld
        End Get
        Set(ByVal Value As Int32)
            _CONDI_COMPRAOld = Value
        End Set
    End Property 

    Private _NUM_SOLIC_ZAFRA As Int32
    <Column(Name:="Num solic zafra", Storage:="NUM_SOLIC_ZAFRA", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property NUM_SOLIC_ZAFRA() As Int32
        Get
            Return _NUM_SOLIC_ZAFRA
        End Get
        Set(ByVal Value As Int32)
            _NUM_SOLIC_ZAFRA = Value
            OnPropertyChanged("NUM_SOLIC_ZAFRA")
        End Set
    End Property 

    Private _NUM_SOLIC_ZAFRAOld As Int32
    Public Property NUM_SOLIC_ZAFRAOld() As Int32
        Get
            Return _NUM_SOLIC_ZAFRAOld
        End Get
        Set(ByVal Value As Int32)
            _NUM_SOLIC_ZAFRAOld = Value
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

    Private _ACTIVIDAD As String
    <Column(Name:="Actividad", Storage:="ACTIVIDAD", DbType:="VARCHAR(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
    Public Property ACTIVIDAD() As String
        Get
            Return _ACTIVIDAD
        End Get
        Set(ByVal Value As String)
            _ACTIVIDAD = Value
            OnPropertyChanged("ACTIVIDAD")
        End Set
    End Property 

    Private _ACTIVIDADOld As String
    Public Property ACTIVIDADOld() As String
        Get
            Return _ACTIVIDADOld
        End Get
        Set(ByVal Value As String)
            _ACTIVIDADOld = Value
        End Set
    End Property 

    Private _FECHA_SOLIC As DateTime
    <Column(Name:="Fecha solic", Storage:="FECHA_SOLIC", DbType:="DATETIME", Id:=False), _
     DataObjectField(False, False, True)> _
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

    Private _ID_CONTRA_TRANS_VEHI As Int32
    <Column(Name:="Id contra trans vehi", Storage:="ID_CONTRA_TRANS_VEHI", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_CONTRA_TRANS_VEHI() As Int32
        Get
            Return _ID_CONTRA_TRANS_VEHI
        End Get
        Set(ByVal Value As Int32)
            _ID_CONTRA_TRANS_VEHI = Value
            OnPropertyChanged("ID_CONTRA_TRANS_VEHI")
        End Set
    End Property 

    Private _ID_CONTRA_TRANS_VEHIOld As Int32
    Public Property ID_CONTRA_TRANS_VEHIOld() As Int32
        Get
            Return _ID_CONTRA_TRANS_VEHIOld
        End Get
        Set(ByVal Value As Int32)
            _ID_CONTRA_TRANS_VEHIOld = Value
        End Set
    End Property 

    Private _ID_TRANSPORTE As Int32
    <Column(Name:="Id transporte", Storage:="ID_TRANSPORTE", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_TRANSPORTE() As Int32
        Get
            Return _ID_TRANSPORTE
        End Get
        Set(ByVal Value As Int32)
            _ID_TRANSPORTE = Value
            OnPropertyChanged("ID_TRANSPORTE")
        End Set
    End Property 

    Private _ID_TRANSPORTEOld As Int32
    Public Property ID_TRANSPORTEOld() As Int32
        Get
            Return _ID_TRANSPORTEOld
        End Get
        Set(ByVal Value As Int32)
            _ID_TRANSPORTEOld = Value
        End Set
    End Property 

    Private _SUB_TOTAL As Decimal
    <Column(Name:="Sub total", Storage:="SUB_TOTAL", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property SUB_TOTAL() As Decimal
        Get
            Return _SUB_TOTAL
        End Get
        Set(ByVal Value As Decimal)
            _SUB_TOTAL = Value
            OnPropertyChanged("SUB_TOTAL")
        End Set
    End Property 

    Private _SUB_TOTALOld As Decimal
    Public Property SUB_TOTALOld() As Decimal
        Get
            Return _SUB_TOTALOld
        End Get
        Set(ByVal Value As Decimal)
            _SUB_TOTALOld = Value
        End Set
    End Property 

    Private _IVA As Decimal
    <Column(Name:="Iva", Storage:="IVA", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property IVA() As Decimal
        Get
            Return _IVA
        End Get
        Set(ByVal Value As Decimal)
            _IVA = Value
            OnPropertyChanged("IVA")
        End Set
    End Property 

    Private _IVAOld As Decimal
    Public Property IVAOld() As Decimal
        Get
            Return _IVAOld
        End Get
        Set(ByVal Value As Decimal)
            _IVAOld = Value
        End Set
    End Property 

    Private _TOTAL As Decimal
    <Column(Name:="Total", Storage:="TOTAL", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property TOTAL() As Decimal
        Get
            Return _TOTAL
        End Get
        Set(ByVal Value As Decimal)
            _TOTAL = Value
            OnPropertyChanged("TOTAL")
        End Set
    End Property 

    Private _TOTALOld As Decimal
    Public Property TOTALOld() As Decimal
        Get
            Return _TOTALOld
        End Get
        Set(ByVal Value As Decimal)
            _TOTALOld = Value
        End Set
    End Property 

    Private _ID_ESTADO_SOLIC As Int32
    <Column(Name:="Id estado solic", Storage:="ID_ESTADO_SOLIC", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_ESTADO_SOLIC() As Int32
        Get
            Return _ID_ESTADO_SOLIC
        End Get
        Set(ByVal Value As Int32)
            _ID_ESTADO_SOLIC = Value
            OnPropertyChanged("ID_ESTADO_SOLIC")
        End Set
    End Property 

    Private _ID_ESTADO_SOLICOld As Int32
    Public Property ID_ESTADO_SOLICOld() As Int32
        Get
            Return _ID_ESTADO_SOLICOld
        End Get
        Set(ByVal Value As Int32)
            _ID_ESTADO_SOLICOld = Value
        End Set
    End Property 

    Private _fkID_ESTADO_SOLIC As ESTADO_SOLIC
    Public Property fkID_ESTADO_SOLIC() As ESTADO_SOLIC
        Get
            Return _fkID_ESTADO_SOLIC
        End Get
        Set(ByVal Value As ESTADO_SOLIC)
            _fkID_ESTADO_SOLIC = Value
        End Set
    End Property 

    Private _UID_SOLIC_ENCA_TRANS As Guid
    <Column(Name:="Uid solic enca trans", Storage:="UID_SOLIC_ENCA_TRANS", DbType:="UNIQUEIDENTIFIER(36, 0)", Id:=False), _
     DataObjectField(False, False, True, 16)> _
    Public Property UID_SOLIC_ENCA_TRANS() As Guid
        Get
            Return _UID_SOLIC_ENCA_TRANS
        End Get
        Set(ByVal Value As Guid)
            _UID_SOLIC_ENCA_TRANS = Value
            OnPropertyChanged("UID_SOLIC_ENCA_TRANS")
        End Set
    End Property 

    Private _UID_SOLIC_ENCA_TRANSOld As Guid
    Public Property UID_SOLIC_ENCA_TRANSOld() As Guid
        Get
            Return _UID_SOLIC_ENCA_TRANSOld
        End Get
        Set(ByVal Value As Guid)
            _UID_SOLIC_ENCA_TRANSOld = Value
        End Set
    End Property 

    Private _OBSERVACIONES As String
    <Column(Name:="Observaciones", Storage:="OBSERVACIONES", DbType:="VARCHAR(1000)", Id:=False), _
     DataObjectField(False, False, True, 1000)> _
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

    Private _ZAFRA As String
    <Column(Name:="Zafra", Storage:="ZAFRA", DbType:="VARCHAR(10)", Id:=False), _
     DataObjectField(False, False, True, 10)> _
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

    Private _CESC As Decimal
    <Column(Name:="Cesc", Storage:="CESC", DbType:="NUMERIC(20,5)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=5)> _
    Public Property CESC() As Decimal
        Get
            Return _CESC
        End Get
        Set(ByVal Value As Decimal)
            _CESC = Value
            OnPropertyChanged("CESC")
        End Set
    End Property

    Private _CESCOld As Decimal
    Public Property CESCOld() As Decimal
        Get
            Return _CESCOld
        End Get
        Set(ByVal Value As Decimal)
            _CESCOld = Value
        End Set
    End Property

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
