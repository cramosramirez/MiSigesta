''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.CREDITO_MOV
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row CREDITO_MOV en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	03/11/2017	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="CREDITO_MOV")> Public Class CREDITO_MOV
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_CREDITO_MOV As Int32, aID_CREDITO_ENCA As Int32, aFECHA As DateTime, aUID_REFERENCIA As Guid, aID_CATORCENA As Int32, aCARGO As Decimal, aABONO As Decimal, aSALDO As Decimal, aABONO_IVA As Decimal, aABONO_INTERES As Decimal, aABONO_INTERES_IVA As Decimal, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime, aCODIBANCO As Int32, aNO_DOCUMENTO As String, aFECHA_ULTMOV As DateTime, aTASAINT As Decimal, aSALDO_INICIAL As Decimal, aTIPO_INTERES As String, aPLAZO_DIAS As Int32, aID_PLANILLA_BASE As Int32)
        Me._ID_CREDITO_MOV = aID_CREDITO_MOV
        Me._ID_CREDITO_ENCA = aID_CREDITO_ENCA
        Me._FECHA = aFECHA
        Me._UID_REFERENCIA = aUID_REFERENCIA
        Me._ID_CATORCENA = aID_CATORCENA
        Me._CARGO = aCARGO
        Me._ABONO = aABONO
        Me._SALDO = aSALDO
        Me._ABONO_IVA = aABONO_IVA
        Me._ABONO_INTERES = aABONO_INTERES
        Me._ABONO_INTERES_IVA = aABONO_INTERES_IVA
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
        Me._CODIBANCO = aCODIBANCO
        Me._NO_DOCUMENTO = aNO_DOCUMENTO
        Me._FECHA_ULTMOV = aFECHA_ULTMOV
        Me._TASAINT = aTASAINT
        Me._SALDO_INICIAL = aSALDO_INICIAL
        Me._TIPO_INTERES = aTIPO_INTERES
        Me._PLAZO_DIAS = aPLAZO_DIAS
        Me._ID_PLANILLA_BASE = aID_PLANILLA_BASE
    End Sub

#Region " Properties "

    Private _ID_CREDITO_MOV As Int32
    <Column(Name:="Id credito mov", Storage:="ID_CREDITO_MOV", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_CREDITO_MOV() As Int32
        Get
            Return _ID_CREDITO_MOV
        End Get
        Set(ByVal Value As Int32)
            _ID_CREDITO_MOV = Value
            OnPropertyChanged("ID_CREDITO_MOV")
        End Set
    End Property 

    Private _ID_CREDITO_ENCA As Int32
    <Column(Name:="Id credito enca", Storage:="ID_CREDITO_ENCA", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_CREDITO_ENCA() As Int32
        Get
            Return _ID_CREDITO_ENCA
        End Get
        Set(ByVal Value As Int32)
            _ID_CREDITO_ENCA = Value
            OnPropertyChanged("ID_CREDITO_ENCA")
        End Set
    End Property 

    Private _ID_CREDITO_ENCAOld As Int32
    Public Property ID_CREDITO_ENCAOld() As Int32
        Get
            Return _ID_CREDITO_ENCAOld
        End Get
        Set(ByVal Value As Int32)
            _ID_CREDITO_ENCAOld = Value
        End Set
    End Property 

    Private _fkID_CREDITO_ENCA As CREDITO_ENCA
    Public Property fkID_CREDITO_ENCA() As CREDITO_ENCA
        Get
            Return _fkID_CREDITO_ENCA
        End Get
        Set(ByVal Value As CREDITO_ENCA)
            _fkID_CREDITO_ENCA = Value
        End Set
    End Property 

    Private _FECHA As DateTime
    <Column(Name:="Fecha", Storage:="FECHA", DbType:="DATETIME NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
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

    Private _UID_REFERENCIA As Guid
    <Column(Name:="Uid referencia", Storage:="UID_REFERENCIA", DbType:="UNIQUEIDENTIFIER(36, 0) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 16)> _
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

    Private _ID_CATORCENA As Int32
    <Column(Name:="Id catorcena", Storage:="ID_CATORCENA", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_CATORCENA() As Int32
        Get
            Return _ID_CATORCENA
        End Get
        Set(ByVal Value As Int32)
            _ID_CATORCENA = Value
            OnPropertyChanged("ID_CATORCENA")
        End Set
    End Property 

    Private _ID_CATORCENAOld As Int32
    Public Property ID_CATORCENAOld() As Int32
        Get
            Return _ID_CATORCENAOld
        End Get
        Set(ByVal Value As Int32)
            _ID_CATORCENAOld = Value
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

    Private _NO_DOCUMENTO As String
    <Column(Name:="No documento", Storage:="NO_DOCUMENTO", DbType:="VARCHAR(150) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 150)> _
    Public Property NO_DOCUMENTO() As String
        Get
            Return _NO_DOCUMENTO
        End Get
        Set(ByVal Value As String)
            _NO_DOCUMENTO = Value
            OnPropertyChanged("NO_DOCUMENTO")
        End Set
    End Property 

    Private _NO_DOCUMENTOOld As String
    Public Property NO_DOCUMENTOOld() As String
        Get
            Return _NO_DOCUMENTOOld
        End Get
        Set(ByVal Value As String)
            _NO_DOCUMENTOOld = Value
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

    Private _TASAINT As Decimal
    <Column(Name:="Tasaint", Storage:="TASAINT", DbType:="NUMERIC(20,4)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=4)> _
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

    Private _SALDO_INICIAL As Decimal
    <Column(Name:="Saldo inicial", Storage:="SALDO_INICIAL", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property SALDO_INICIAL() As Decimal
        Get
            Return _SALDO_INICIAL
        End Get
        Set(ByVal Value As Decimal)
            _SALDO_INICIAL = Value
            OnPropertyChanged("SALDO_INICIAL")
        End Set
    End Property 

    Private _SALDO_INICIALOld As Decimal
    Public Property SALDO_INICIALOld() As Decimal
        Get
            Return _SALDO_INICIALOld
        End Get
        Set(ByVal Value As Decimal)
            _SALDO_INICIALOld = Value
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

    Private _PLAZO_DIAS As Int32
    <Column(Name:="Plazo dias", Storage:="PLAZO_DIAS", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property PLAZO_DIAS() As Int32
        Get
            Return _PLAZO_DIAS
        End Get
        Set(ByVal Value As Int32)
            _PLAZO_DIAS = Value
            OnPropertyChanged("PLAZO_DIAS")
        End Set
    End Property 

    Private _PLAZO_DIASOld As Int32
    Public Property PLAZO_DIASOld() As Int32
        Get
            Return _PLAZO_DIASOld
        End Get
        Set(ByVal Value As Int32)
            _PLAZO_DIASOld = Value
        End Set
    End Property 

    Private _ID_PLANILLA_BASE As Int32
    <Column(Name:="Id planilla base", Storage:="ID_PLANILLA_BASE", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_PLANILLA_BASE() As Int32
        Get
            Return _ID_PLANILLA_BASE
        End Get
        Set(ByVal Value As Int32)
            _ID_PLANILLA_BASE = Value
            OnPropertyChanged("ID_PLANILLA_BASE")
        End Set
    End Property 

    Private _ID_PLANILLA_BASEOld As Int32
    Public Property ID_PLANILLA_BASEOld() As Int32
        Get
            Return _ID_PLANILLA_BASEOld
        End Get
        Set(ByVal Value As Int32)
            _ID_PLANILLA_BASEOld = Value
        End Set
    End Property 

    Private _fkID_PLANILLA_BASE As PLANILLA_BASE
    Public Property fkID_PLANILLA_BASE() As PLANILLA_BASE
        Get
            Return _fkID_PLANILLA_BASE
        End Get
        Set(ByVal Value As PLANILLA_BASE)
            _fkID_PLANILLA_BASE = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
