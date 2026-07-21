''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.CONTRATO_CTAS_PROVI
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row CONTRATO_CTAS_PROVI en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	12/07/2015	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="CONTRATO_CTAS_PROVI")> Public Class CONTRATO_CTAS_PROVI
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_CONTRATO_CTAS_PROVI As Int32, aID_CONTRATO_FINAN As Int32, aCODICONTRATO As String, aID_ZAFRA As Int32, aFECHA_APLICA As DateTime, aCONCEPTO As String, aPROVISION As Decimal, aID_CUENTA_FINAN As Int32, aUID_SOLICITUD As Guid, aZAFRA As String, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime)
        Me._ID_CONTRATO_CTAS_PROVI = aID_CONTRATO_CTAS_PROVI
        Me._ID_CONTRATO_FINAN = aID_CONTRATO_FINAN
        Me._CODICONTRATO = aCODICONTRATO
        Me._ID_ZAFRA = aID_ZAFRA
        Me._FECHA_APLICA = aFECHA_APLICA
        Me._CONCEPTO = aCONCEPTO
        Me._PROVISION = aPROVISION
        Me._ID_CUENTA_FINAN = aID_CUENTA_FINAN
        Me._UID_SOLICITUD = aUID_SOLICITUD
        Me._ZAFRA = aZAFRA
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
    End Sub

#Region " Properties "

    Private _ID_CONTRATO_CTAS_PROVI As Int32
    <Column(Name:="Id contrato ctas provi", Storage:="ID_CONTRATO_CTAS_PROVI", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_CONTRATO_CTAS_PROVI() As Int32
        Get
            Return _ID_CONTRATO_CTAS_PROVI
        End Get
        Set(ByVal Value As Int32)
            _ID_CONTRATO_CTAS_PROVI = Value
            OnPropertyChanged("ID_CONTRATO_CTAS_PROVI")
        End Set
    End Property 

    Private _ID_CONTRATO_FINAN As Int32
    <Column(Name:="Id contrato finan", Storage:="ID_CONTRATO_FINAN", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_CONTRATO_FINAN() As Int32
        Get
            Return _ID_CONTRATO_FINAN
        End Get
        Set(ByVal Value As Int32)
            _ID_CONTRATO_FINAN = Value
            OnPropertyChanged("ID_CONTRATO_FINAN")
        End Set
    End Property 

    Private _ID_CONTRATO_FINANOld As Int32
    Public Property ID_CONTRATO_FINANOld() As Int32
        Get
            Return _ID_CONTRATO_FINANOld
        End Get
        Set(ByVal Value As Int32)
            _ID_CONTRATO_FINANOld = Value
        End Set
    End Property 

    Private _fkID_CONTRATO_FINAN As CONTRATO_FINAN
    Public Property fkID_CONTRATO_FINAN() As CONTRATO_FINAN
        Get
            Return _fkID_CONTRATO_FINAN
        End Get
        Set(ByVal Value As CONTRATO_FINAN)
            _fkID_CONTRATO_FINAN = Value
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

    Private _CONCEPTO As String
    <Column(Name:="Concepto", Storage:="CONCEPTO", DbType:="VARCHAR(255)", Id:=False), _
     DataObjectField(False, False, True, 255)> _
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

    Private _PROVISION As Decimal
    <Column(Name:="Provision", Storage:="PROVISION", DbType:="NUMERIC(20,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)> _
    Public Property PROVISION() As Decimal
        Get
            Return _PROVISION
        End Get
        Set(ByVal Value As Decimal)
            _PROVISION = Value
            OnPropertyChanged("PROVISION")
        End Set
    End Property 

    Private _PROVISIONOld As Decimal
    Public Property PROVISIONOld() As Decimal
        Get
            Return _PROVISIONOld
        End Get
        Set(ByVal Value As Decimal)
            _PROVISIONOld = Value
        End Set
    End Property 

    Private _ID_CUENTA_FINAN As Int32
    <Column(Name:="Id cuenta finan", Storage:="ID_CUENTA_FINAN", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
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

    Private _UID_SOLICITUD As Guid
    <Column(Name:="Uid solicitud", Storage:="UID_SOLICITUD", DbType:="UNIQUEIDENTIFIER(36, 0) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 16)> _
    Public Property UID_SOLICITUD() As Guid
        Get
            Return _UID_SOLICITUD
        End Get
        Set(ByVal Value As Guid)
            _UID_SOLICITUD = Value
            OnPropertyChanged("UID_SOLICITUD")
        End Set
    End Property 

    Private _UID_SOLICITUDOld As Guid
    Public Property UID_SOLICITUDOld() As Guid
        Get
            Return _UID_SOLICITUDOld
        End Get
        Set(ByVal Value As Guid)
            _UID_SOLICITUDOld = Value
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
