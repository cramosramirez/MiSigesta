''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.CONTRATO_FINAN
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row CONTRATO_FINAN en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/06/2015	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="CONTRATO_FINAN")> Public Class CONTRATO_FINAN
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_CONTRATO_FINAN As Int32, aID_ZAFRA As Int32, aCODICONTRATO As String, aMZ As Decimal, aTONEL_MZ As Decimal, aTONEL As Decimal, aREND_COSECHA As Decimal, aLIBRAS As Decimal, aVIP As Decimal, aVALOR_CONTRA As Decimal, aPROVI_ROZA As Decimal, aPROVI_ALZA As Decimal, aPROVI_TRANS As Decimal, aPROVISION As Decimal, aCARGO As Decimal, aABONO As Decimal, aDISPONIBLE As Decimal, aZAFRA As String, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime)
        Me._ID_CONTRATO_FINAN = aID_CONTRATO_FINAN
        Me._ID_ZAFRA = aID_ZAFRA
        Me._CODICONTRATO = aCODICONTRATO
        Me._MZ = aMZ
        Me._TONEL_MZ = aTONEL_MZ
        Me._TONEL = aTONEL
        Me._REND_COSECHA = aREND_COSECHA
        Me._LIBRAS = aLIBRAS
        Me._VIP = aVIP
        Me._VALOR_CONTRA = aVALOR_CONTRA
        Me._PROVI_ROZA = aPROVI_ROZA
        Me._PROVI_ALZA = aPROVI_ALZA
        Me._PROVI_TRANS = aPROVI_TRANS
        Me._PROVISION = aPROVISION
        Me._CARGO = aCARGO
        Me._ABONO = aABONO
        Me._DISPONIBLE = aDISPONIBLE
        Me._ZAFRA = aZAFRA
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
    End Sub

#Region " Properties "

    Private _ID_CONTRATO_FINAN As Int32
    <Column(Name:="Id contrato finan", Storage:="ID_CONTRATO_FINAN", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_CONTRATO_FINAN() As Int32
        Get
            Return _ID_CONTRATO_FINAN
        End Get
        Set(ByVal Value As Int32)
            _ID_CONTRATO_FINAN = Value
            OnPropertyChanged("ID_CONTRATO_FINAN")
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

    Private _TONEL_MZ As Decimal
    <Column(Name:="Tonel mz", Storage:="TONEL_MZ", DbType:="NUMERIC(10,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)> _
    Public Property TONEL_MZ() As Decimal
        Get
            Return _TONEL_MZ
        End Get
        Set(ByVal Value As Decimal)
            _TONEL_MZ = Value
            OnPropertyChanged("TONEL_MZ")
        End Set
    End Property 

    Private _TONEL_MZOld As Decimal
    Public Property TONEL_MZOld() As Decimal
        Get
            Return _TONEL_MZOld
        End Get
        Set(ByVal Value As Decimal)
            _TONEL_MZOld = Value
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

    Private _REND_COSECHA As Decimal
    <Column(Name:="Rend cosecha", Storage:="REND_COSECHA", DbType:="NUMERIC(10,4) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=4)> _
    Public Property REND_COSECHA() As Decimal
        Get
            Return _REND_COSECHA
        End Get
        Set(ByVal Value As Decimal)
            _REND_COSECHA = Value
            OnPropertyChanged("REND_COSECHA")
        End Set
    End Property 

    Private _REND_COSECHAOld As Decimal
    Public Property REND_COSECHAOld() As Decimal
        Get
            Return _REND_COSECHAOld
        End Get
        Set(ByVal Value As Decimal)
            _REND_COSECHAOld = Value
        End Set
    End Property 

    Private _LIBRAS As Decimal
    <Column(Name:="Libras", Storage:="LIBRAS", DbType:="NUMERIC(10,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)> _
    Public Property LIBRAS() As Decimal
        Get
            Return _LIBRAS
        End Get
        Set(ByVal Value As Decimal)
            _LIBRAS = Value
            OnPropertyChanged("LIBRAS")
        End Set
    End Property 

    Private _LIBRASOld As Decimal
    Public Property LIBRASOld() As Decimal
        Get
            Return _LIBRASOld
        End Get
        Set(ByVal Value As Decimal)
            _LIBRASOld = Value
        End Set
    End Property 

    Private _VIP As Decimal
    <Column(Name:="Vip", Storage:="VIP", DbType:="NUMERIC(20,6) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=6)> _
    Public Property VIP() As Decimal
        Get
            Return _VIP
        End Get
        Set(ByVal Value As Decimal)
            _VIP = Value
            OnPropertyChanged("VIP")
        End Set
    End Property

    Private _VIPOld As Decimal
    Public Property VIPOld() As Decimal
        Get
            Return _VIPOld
        End Get
        Set(ByVal Value As Decimal)
            _VIPOld = Value
        End Set
    End Property 

    Private _VALOR_CONTRA As Decimal
    <Column(Name:="Valor contra", Storage:="VALOR_CONTRA", DbType:="NUMERIC(20,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)> _
    Public Property VALOR_CONTRA() As Decimal
        Get
            Return _VALOR_CONTRA
        End Get
        Set(ByVal Value As Decimal)
            _VALOR_CONTRA = Value
            OnPropertyChanged("VALOR_CONTRA")
        End Set
    End Property 

    Private _VALOR_CONTRAOld As Decimal
    Public Property VALOR_CONTRAOld() As Decimal
        Get
            Return _VALOR_CONTRAOld
        End Get
        Set(ByVal Value As Decimal)
            _VALOR_CONTRAOld = Value
        End Set
    End Property 

    Private _PROVI_ROZA As Decimal
    <Column(Name:="Provi roza", Storage:="PROVI_ROZA", DbType:="NUMERIC(20,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)> _
    Public Property PROVI_ROZA() As Decimal
        Get
            Return _PROVI_ROZA
        End Get
        Set(ByVal Value As Decimal)
            _PROVI_ROZA = Value
            OnPropertyChanged("PROVI_ROZA")
        End Set
    End Property 

    Private _PROVI_ROZAOld As Decimal
    Public Property PROVI_ROZAOld() As Decimal
        Get
            Return _PROVI_ROZAOld
        End Get
        Set(ByVal Value As Decimal)
            _PROVI_ROZAOld = Value
        End Set
    End Property 

    Private _PROVI_ALZA As Decimal
    <Column(Name:="Provi alza", Storage:="PROVI_ALZA", DbType:="NUMERIC(20,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)> _
    Public Property PROVI_ALZA() As Decimal
        Get
            Return _PROVI_ALZA
        End Get
        Set(ByVal Value As Decimal)
            _PROVI_ALZA = Value
            OnPropertyChanged("PROVI_ALZA")
        End Set
    End Property 

    Private _PROVI_ALZAOld As Decimal
    Public Property PROVI_ALZAOld() As Decimal
        Get
            Return _PROVI_ALZAOld
        End Get
        Set(ByVal Value As Decimal)
            _PROVI_ALZAOld = Value
        End Set
    End Property 

    Private _PROVI_TRANS As Decimal
    <Column(Name:="Provi trans", Storage:="PROVI_TRANS", DbType:="NUMERIC(20,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)> _
    Public Property PROVI_TRANS() As Decimal
        Get
            Return _PROVI_TRANS
        End Get
        Set(ByVal Value As Decimal)
            _PROVI_TRANS = Value
            OnPropertyChanged("PROVI_TRANS")
        End Set
    End Property 

    Private _PROVI_TRANSOld As Decimal
    Public Property PROVI_TRANSOld() As Decimal
        Get
            Return _PROVI_TRANSOld
        End Get
        Set(ByVal Value As Decimal)
            _PROVI_TRANSOld = Value
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

    Private _CARGO As Decimal
    <Column(Name:="Cargo", Storage:="CARGO", DbType:="NUMERIC(20,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)> _
    Public Property CARGO() As Decimal
        Get
            Return _CARGO
        End Get
        Set(ByVal Value As Decimal)
            _CARGO = Value
            OnPropertyChanged("CARGO")
        End Set
    End Property 

    Private _CARGOOld As Decimal
    Public Property CARGOOld() As Decimal
        Get
            Return _CARGOOld
        End Get
        Set(ByVal Value As Decimal)
            _CARGOOld = Value
        End Set
    End Property 

    Private _ABONO As Decimal
    <Column(Name:="Abono", Storage:="ABONO", DbType:="NUMERIC(20,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)> _
    Public Property ABONO() As Decimal
        Get
            Return _ABONO
        End Get
        Set(ByVal Value As Decimal)
            _ABONO = Value
            OnPropertyChanged("ABONO")
        End Set
    End Property 

    Private _ABONOOld As Decimal
    Public Property ABONOOld() As Decimal
        Get
            Return _ABONOOld
        End Get
        Set(ByVal Value As Decimal)
            _ABONOOld = Value
        End Set
    End Property 

    Private _DISPONIBLE As Decimal
    <Column(Name:="Disponible", Storage:="DISPONIBLE", DbType:="NUMERIC(20,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)> _
    Public Property DISPONIBLE() As Decimal
        Get
            Return _DISPONIBLE
        End Get
        Set(ByVal Value As Decimal)
            _DISPONIBLE = Value
            OnPropertyChanged("DISPONIBLE")
        End Set
    End Property

    Private _DISPONIBLEOld As Decimal
    Public Property DISPONIBLEOld() As Decimal
        Get
            Return _DISPONIBLEOld
        End Get
        Set(ByVal Value As Decimal)
            _DISPONIBLEOld = Value
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
