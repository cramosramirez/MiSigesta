''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.CREDITO_ENCA_TRANS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row CREDITO_ENCA_TRANS en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	03/11/2017	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="CREDITO_ENCA_TRANS")> Public Class CREDITO_ENCA_TRANS
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_CREDITO_ENCA As Int32, aCODTRANSPORT As Int32, aID_ZAFRA As Int32, aZAFRA As String, aID_TIPO_COMPROB As Int32, aID_CUENTA_FINAN As Int32, aDESCRIP_FINAN As String, aID_PROVEE As Int32, aFECHA As DateTime, aNO_COMPROB As String, aFECHA_APLIC As DateTime, aFECHA_ULTMOV As DateTime, aUID_REFERENCIA As Guid, aTASAINT As Decimal, aCARGO As Decimal, aABONO As Decimal, aSALDO As Decimal, aINTERES As Decimal, aIVA_INTERES As Decimal, aABONO_IVA As Decimal, aABONO_INTERES As Decimal, aABONO_INTERES_IVA As Decimal, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime, aES_SALDO_INSOLUTO As Boolean, aTIPO_INTERES As String)
        Me._ID_CREDITO_ENCA = aID_CREDITO_ENCA
        Me._CODTRANSPORT = aCODTRANSPORT
        Me._ID_ZAFRA = aID_ZAFRA
        Me._ZAFRA = aZAFRA
        Me._ID_TIPO_COMPROB = aID_TIPO_COMPROB
        Me._ID_CUENTA_FINAN = aID_CUENTA_FINAN
        Me._DESCRIP_FINAN = aDESCRIP_FINAN
        Me._ID_PROVEE = aID_PROVEE
        Me._FECHA = aFECHA
        Me._NO_COMPROB = aNO_COMPROB
        Me._FECHA_APLIC = aFECHA_APLIC
        Me._FECHA_ULTMOV = aFECHA_ULTMOV
        Me._UID_REFERENCIA = aUID_REFERENCIA
        Me._TASAINT = aTASAINT
        Me._CARGO = aCARGO
        Me._ABONO = aABONO
        Me._SALDO = aSALDO
        Me._INTERES = aINTERES
        Me._IVA_INTERES = aIVA_INTERES
        Me._ABONO_IVA = aABONO_IVA
        Me._ABONO_INTERES = aABONO_INTERES
        Me._ABONO_INTERES_IVA = aABONO_INTERES_IVA
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
        Me._ES_SALDO_INSOLUTO = aES_SALDO_INSOLUTO
        Me._TIPO_INTERES = aTIPO_INTERES
    End Sub

#Region " Properties "

    Private _ID_CREDITO_ENCA As Int32
    <Column(Name:="Id credito enca", Storage:="ID_CREDITO_ENCA", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_CREDITO_ENCA() As Int32
        Get
            Return _ID_CREDITO_ENCA
        End Get
        Set(ByVal Value As Int32)
            _ID_CREDITO_ENCA = Value
            OnPropertyChanged("ID_CREDITO_ENCA")
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

    Private _ID_TIPO_COMPROB As Int32
    <Column(Name:="Id tipo comprob", Storage:="ID_TIPO_COMPROB", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_TIPO_COMPROB() As Int32
        Get
            Return _ID_TIPO_COMPROB
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_COMPROB = Value
            OnPropertyChanged("ID_TIPO_COMPROB")
        End Set
    End Property 

    Private _ID_TIPO_COMPROBOld As Int32
    Public Property ID_TIPO_COMPROBOld() As Int32
        Get
            Return _ID_TIPO_COMPROBOld
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_COMPROBOld = Value
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

    Private _DESCRIP_FINAN As String
    <Column(Name:="Descrip finan", Storage:="DESCRIP_FINAN", DbType:="VARCHAR(200)", Id:=False), _
     DataObjectField(False, False, True, 200)> _
    Public Property DESCRIP_FINAN() As String
        Get
            Return _DESCRIP_FINAN
        End Get
        Set(ByVal Value As String)
            _DESCRIP_FINAN = Value
            OnPropertyChanged("DESCRIP_FINAN")
        End Set
    End Property 

    Private _DESCRIP_FINANOld As String
    Public Property DESCRIP_FINANOld() As String
        Get
            Return _DESCRIP_FINANOld
        End Get
        Set(ByVal Value As String)
            _DESCRIP_FINANOld = Value
        End Set
    End Property 

    Private _ID_PROVEE As Int32
    <Column(Name:="Id provee", Storage:="ID_PROVEE", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_PROVEE() As Int32
        Get
            Return _ID_PROVEE
        End Get
        Set(ByVal Value As Int32)
            _ID_PROVEE = Value
            OnPropertyChanged("ID_PROVEE")
        End Set
    End Property 

    Private _ID_PROVEEOld As Int32
    Public Property ID_PROVEEOld() As Int32
        Get
            Return _ID_PROVEEOld
        End Get
        Set(ByVal Value As Int32)
            _ID_PROVEEOld = Value
        End Set
    End Property 

    Private _fkID_PROVEE As PROVEEDOR_AGRICOLA
    Public Property fkID_PROVEE() As PROVEEDOR_AGRICOLA
        Get
            Return _fkID_PROVEE
        End Get
        Set(ByVal Value As PROVEEDOR_AGRICOLA)
            _fkID_PROVEE = Value
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

    Private _NO_COMPROB As String
    <Column(Name:="No comprob", Storage:="NO_COMPROB", DbType:="VARCHAR(200)", Id:=False), _
     DataObjectField(False, False, True, 200)> _
    Public Property NO_COMPROB() As String
        Get
            Return _NO_COMPROB
        End Get
        Set(ByVal Value As String)
            _NO_COMPROB = Value
            OnPropertyChanged("NO_COMPROB")
        End Set
    End Property 

    Private _NO_COMPROBOld As String
    Public Property NO_COMPROBOld() As String
        Get
            Return _NO_COMPROBOld
        End Get
        Set(ByVal Value As String)
            _NO_COMPROBOld = Value
        End Set
    End Property 

    Private _FECHA_APLIC As DateTime
    <Column(Name:="Fecha aplic", Storage:="FECHA_APLIC", DbType:="DATETIME", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_APLIC() As DateTime
        Get
            Return _FECHA_APLIC
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_APLIC = Value
            OnPropertyChanged("FECHA_APLIC")
        End Set
    End Property 

    Private _FECHA_APLICOld As DateTime
    Public Property FECHA_APLICOld() As DateTime
        Get
            Return _FECHA_APLICOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_APLICOld = Value
        End Set
    End Property 

    Private _FECHA_ULTMOV As DateTime
    <Column(Name:="Fecha ultmov", Storage:="FECHA_ULTMOV", DbType:="DATETIME", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_ULTMOV() As DateTime
        Get
            Return _FECHA_ULTMOV
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_ULTMOV = Value
            OnPropertyChanged("FECHA_ULTMOV")
        End Set
    End Property 

    Private _FECHA_ULTMOVOld As DateTime
    Public Property FECHA_ULTMOVOld() As DateTime
        Get
            Return _FECHA_ULTMOVOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_ULTMOVOld = Value
        End Set
    End Property 

    Private _UID_REFERENCIA As Guid
    <Column(Name:="Uid referencia", Storage:="UID_REFERENCIA", DbType:="UNIQUEIDENTIFIER(36, 0)", Id:=False), _
     DataObjectField(False, False, True, 16)> _
    Public Property UID_REFERENCIA() As Guid
        Get
            Return _UID_REFERENCIA
        End Get
        Set(ByVal Value As Guid)
            _UID_REFERENCIA = Value
            OnPropertyChanged("UID_REFERENCIA")
        End Set
    End Property 

    Private _UID_REFERENCIAOld As Guid
    Public Property UID_REFERENCIAOld() As Guid
        Get
            Return _UID_REFERENCIAOld
        End Get
        Set(ByVal Value As Guid)
            _UID_REFERENCIAOld = Value
        End Set
    End Property 

    Private _TASAINT As Decimal
    <Column(Name:="Tasaint", Storage:="TASAINT", DbType:="NUMERIC(20,4) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=4)> _
    Public Property TASAINT() As Decimal
        Get
            Return _TASAINT
        End Get
        Set(ByVal Value As Decimal)
            _TASAINT = Value
            OnPropertyChanged("TASAINT")
        End Set
    End Property 

    Private _TASAINTOld As Decimal
    Public Property TASAINTOld() As Decimal
        Get
            Return _TASAINTOld
        End Get
        Set(ByVal Value As Decimal)
            _TASAINTOld = Value
        End Set
    End Property 

    Private _CARGO As Decimal
    <Column(Name:="Cargo", Storage:="CARGO", DbType:="NUMERIC(20,4) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=4)> _
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
    <Column(Name:="Abono", Storage:="ABONO", DbType:="NUMERIC(20,4) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=4)> _
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

    Private _SALDO As Decimal
    <Column(Name:="Saldo", Storage:="SALDO", DbType:="NUMERIC(20,4) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=4)> _
    Public Property SALDO() As Decimal
        Get
            Return _SALDO
        End Get
        Set(ByVal Value As Decimal)
            _SALDO = Value
            OnPropertyChanged("SALDO")
        End Set
    End Property 

    Private _SALDOOld As Decimal
    Public Property SALDOOld() As Decimal
        Get
            Return _SALDOOld
        End Get
        Set(ByVal Value As Decimal)
            _SALDOOld = Value
        End Set
    End Property 

    Private _INTERES As Decimal
    <Column(Name:="Interes", Storage:="INTERES", DbType:="NUMERIC(20,4) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=4)> _
    Public Property INTERES() As Decimal
        Get
            Return _INTERES
        End Get
        Set(ByVal Value As Decimal)
            _INTERES = Value
            OnPropertyChanged("INTERES")
        End Set
    End Property 

    Private _INTERESOld As Decimal
    Public Property INTERESOld() As Decimal
        Get
            Return _INTERESOld
        End Get
        Set(ByVal Value As Decimal)
            _INTERESOld = Value
        End Set
    End Property 

    Private _IVA_INTERES As Decimal
    <Column(Name:="Iva interes", Storage:="IVA_INTERES", DbType:="NUMERIC(20,4) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=4)> _
    Public Property IVA_INTERES() As Decimal
        Get
            Return _IVA_INTERES
        End Get
        Set(ByVal Value As Decimal)
            _IVA_INTERES = Value
            OnPropertyChanged("IVA_INTERES")
        End Set
    End Property 

    Private _IVA_INTERESOld As Decimal
    Public Property IVA_INTERESOld() As Decimal
        Get
            Return _IVA_INTERESOld
        End Get
        Set(ByVal Value As Decimal)
            _IVA_INTERESOld = Value
        End Set
    End Property 

    Private _ABONO_IVA As Decimal
    <Column(Name:="Abono iva", Storage:="ABONO_IVA", DbType:="NUMERIC(20,4) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=4)> _
    Public Property ABONO_IVA() As Decimal
        Get
            Return _ABONO_IVA
        End Get
        Set(ByVal Value As Decimal)
            _ABONO_IVA = Value
            OnPropertyChanged("ABONO_IVA")
        End Set
    End Property 

    Private _ABONO_IVAOld As Decimal
    Public Property ABONO_IVAOld() As Decimal
        Get
            Return _ABONO_IVAOld
        End Get
        Set(ByVal Value As Decimal)
            _ABONO_IVAOld = Value
        End Set
    End Property 

    Private _ABONO_INTERES As Decimal
    <Column(Name:="Abono interes", Storage:="ABONO_INTERES", DbType:="NUMERIC(20,4) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=4)> _
    Public Property ABONO_INTERES() As Decimal
        Get
            Return _ABONO_INTERES
        End Get
        Set(ByVal Value As Decimal)
            _ABONO_INTERES = Value
            OnPropertyChanged("ABONO_INTERES")
        End Set
    End Property 

    Private _ABONO_INTERESOld As Decimal
    Public Property ABONO_INTERESOld() As Decimal
        Get
            Return _ABONO_INTERESOld
        End Get
        Set(ByVal Value As Decimal)
            _ABONO_INTERESOld = Value
        End Set
    End Property 

    Private _ABONO_INTERES_IVA As Decimal
    <Column(Name:="Abono interes iva", Storage:="ABONO_INTERES_IVA", DbType:="NUMERIC(20,4) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=4)> _
    Public Property ABONO_INTERES_IVA() As Decimal
        Get
            Return _ABONO_INTERES_IVA
        End Get
        Set(ByVal Value As Decimal)
            _ABONO_INTERES_IVA = Value
            OnPropertyChanged("ABONO_INTERES_IVA")
        End Set
    End Property 

    Private _ABONO_INTERES_IVAOld As Decimal
    Public Property ABONO_INTERES_IVAOld() As Decimal
        Get
            Return _ABONO_INTERES_IVAOld
        End Get
        Set(ByVal Value As Decimal)
            _ABONO_INTERES_IVAOld = Value
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

    Private _ES_SALDO_INSOLUTO As Boolean
    <Column(Name:="Es saldo insoluto", Storage:="ES_SALDO_INSOLUTO", DbType:="BIT NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 1)> _
    Public Property ES_SALDO_INSOLUTO() As Boolean
        Get
            Return _ES_SALDO_INSOLUTO
        End Get
        Set(ByVal Value As Boolean)
            _ES_SALDO_INSOLUTO = Value
            OnPropertyChanged("ES_SALDO_INSOLUTO")
        End Set
    End Property 

    Private _ES_SALDO_INSOLUTOOld As Boolean
    Public Property ES_SALDO_INSOLUTOOld() As Boolean
        Get
            Return _ES_SALDO_INSOLUTOOld
        End Get
        Set(ByVal Value As Boolean)
            _ES_SALDO_INSOLUTOOld = Value
        End Set
    End Property 

    Private _TIPO_INTERES As String
    <Column(Name:="Tipo interes", Storage:="TIPO_INTERES", DbType:="CHAR(1)", Id:=False), _
     DataObjectField(False, False, True, 1)> _
    Public Property TIPO_INTERES() As String
        Get
            Return _TIPO_INTERES
        End Get
        Set(ByVal Value As String)
            _TIPO_INTERES = Value
            OnPropertyChanged("TIPO_INTERES")
        End Set
    End Property 

    Private _TIPO_INTERESOld As String
    Public Property TIPO_INTERESOld() As String
        Get
            Return _TIPO_INTERESOld
        End Get
        Set(ByVal Value As String)
            _TIPO_INTERESOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
