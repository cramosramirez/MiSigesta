''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.SOLIC_OPI
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row SOLIC_OPI en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	13/06/2018	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="SOLIC_OPI")> Public Class SOLIC_OPI
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_OPI As Int32, aCODIPROVEEDOR As String, aFECHA As DateTime, aCODIBANCO As Int32, aMONTO As Decimal, aPORC_DESCTO As Decimal, aUID_OPI_CONTRATO As Guid, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime, aID_ZAFRA As Int32, aZAFRA As String, aREFERENCIA_GF As String, aNUM_OPI_ZAFRA As Int32, aES_ACEPTADA As Boolean, aNUM_OPI_PROVEE_ZAFRA As Int32, aPORC_DESCTO_PLA As Decimal, aID_ESTADO As Int32)
        Me._ID_OPI = aID_OPI
        Me._CODIPROVEEDOR = aCODIPROVEEDOR
        Me._FECHA = aFECHA
        Me._CODIBANCO = aCODIBANCO
        Me._MONTO = aMONTO
        Me._PORC_DESCTO = aPORC_DESCTO
        Me._UID_OPI_CONTRATO = aUID_OPI_CONTRATO
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
        Me._ID_ZAFRA = aID_ZAFRA
        Me._ZAFRA = aZAFRA
        Me._REFERENCIA_GF = aREFERENCIA_GF
        Me._NUM_OPI_ZAFRA = aNUM_OPI_ZAFRA
        Me._ES_ACEPTADA = aES_ACEPTADA
        Me._NUM_OPI_PROVEE_ZAFRA = aNUM_OPI_PROVEE_ZAFRA
        Me._PORC_DESCTO_PLA = aPORC_DESCTO_PLA
        Me._ID_ESTADO = aID_ESTADO
    End Sub

#Region " Properties "

    Private _ID_OPI As Int32
    <Column(Name:="Id opi", Storage:="ID_OPI", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_OPI() As Int32
        Get
            Return _ID_OPI
        End Get
        Set(ByVal Value As Int32)
            _ID_OPI = Value
            OnPropertyChanged("ID_OPI")
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

    Private _CODIBANCO As Int32
    <Column(Name:="Codibanco", Storage:="CODIBANCO", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
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

    Private _MONTO As Decimal
    <Column(Name:="Monto", Storage:="MONTO", DbType:="NUMERIC(20,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)> _
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

    Private _PORC_DESCTO As Decimal
    <Column(Name:="Porc descto", Storage:="PORC_DESCTO", DbType:="NUMERIC(10,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)> _
    Public Property PORC_DESCTO() As Decimal
        Get
            Return _PORC_DESCTO
        End Get
        Set(ByVal Value As Decimal)
            _PORC_DESCTO = Value
            OnPropertyChanged("PORC_DESCTO")
        End Set
    End Property 

    Private _PORC_DESCTOOld As Decimal
    Public Property PORC_DESCTOOld() As Decimal
        Get
            Return _PORC_DESCTOOld
        End Get
        Set(ByVal Value As Decimal)
            _PORC_DESCTOOld = Value
        End Set
    End Property 

    Private _UID_OPI_CONTRATO As Guid
    <Column(Name:="Uid opi contrato", Storage:="UID_OPI_CONTRATO", DbType:="UNIQUEIDENTIFIER(36, 0)", Id:=False), _
     DataObjectField(False, False, True, 16)> _
    Public Property UID_OPI_CONTRATO() As Guid
        Get
            Return _UID_OPI_CONTRATO
        End Get
        Set(ByVal Value As Guid)
            _UID_OPI_CONTRATO = Value
            OnPropertyChanged("UID_OPI_CONTRATO")
        End Set
    End Property 

    Private _UID_OPI_CONTRATOOld As Guid
    Public Property UID_OPI_CONTRATOOld() As Guid
        Get
            Return _UID_OPI_CONTRATOOld
        End Get
        Set(ByVal Value As Guid)
            _UID_OPI_CONTRATOOld = Value
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

    Private _NUM_OPI_ZAFRA As Int32
    <Column(Name:="Num opi zafra", Storage:="NUM_OPI_ZAFRA", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property NUM_OPI_ZAFRA() As Int32
        Get
            Return _NUM_OPI_ZAFRA
        End Get
        Set(ByVal Value As Int32)
            _NUM_OPI_ZAFRA = Value
            OnPropertyChanged("NUM_OPI_ZAFRA")
        End Set
    End Property 

    Private _NUM_OPI_ZAFRAOld As Int32
    Public Property NUM_OPI_ZAFRAOld() As Int32
        Get
            Return _NUM_OPI_ZAFRAOld
        End Get
        Set(ByVal Value As Int32)
            _NUM_OPI_ZAFRAOld = Value
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

    Private _NUM_OPI_PROVEE_ZAFRA As Int32
    <Column(Name:="Num opi provee zafra", Storage:="NUM_OPI_PROVEE_ZAFRA", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property NUM_OPI_PROVEE_ZAFRA() As Int32
        Get
            Return _NUM_OPI_PROVEE_ZAFRA
        End Get
        Set(ByVal Value As Int32)
            _NUM_OPI_PROVEE_ZAFRA = Value
            OnPropertyChanged("NUM_OPI_PROVEE_ZAFRA")
        End Set
    End Property 

    Private _NUM_OPI_PROVEE_ZAFRAOld As Int32
    Public Property NUM_OPI_PROVEE_ZAFRAOld() As Int32
        Get
            Return _NUM_OPI_PROVEE_ZAFRAOld
        End Get
        Set(ByVal Value As Int32)
            _NUM_OPI_PROVEE_ZAFRAOld = Value
        End Set
    End Property 

    Private _PORC_DESCTO_PLA As Decimal
    <Column(Name:="Porc descto pla", Storage:="PORC_DESCTO_PLA", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property PORC_DESCTO_PLA() As Decimal
        Get
            Return _PORC_DESCTO_PLA
        End Get
        Set(ByVal Value As Decimal)
            _PORC_DESCTO_PLA = Value
            OnPropertyChanged("PORC_DESCTO_PLA")
        End Set
    End Property 

    Private _PORC_DESCTO_PLAOld As Decimal
    Public Property PORC_DESCTO_PLAOld() As Decimal
        Get
            Return _PORC_DESCTO_PLAOld
        End Get
        Set(ByVal Value As Decimal)
            _PORC_DESCTO_PLAOld = Value
        End Set
    End Property 

    Private _ID_ESTADO As Int32
    <Column(Name:="Id estado", Storage:="ID_ESTADO", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_ESTADO() As Int32
        Get
            Return _ID_ESTADO
        End Get
        Set(ByVal Value As Int32)
            _ID_ESTADO = Value
            OnPropertyChanged("ID_ESTADO")
        End Set
    End Property 

    Private _ID_ESTADOOld As Int32
    Public Property ID_ESTADOOld() As Int32
        Get
            Return _ID_ESTADOOld
        End Get
        Set(ByVal Value As Int32)
            _ID_ESTADOOld = Value
        End Set
    End Property 

    Private _fkID_ESTADO As SOLIC_AGRICOLA_ESTADO
    Public Property fkID_ESTADO() As SOLIC_AGRICOLA_ESTADO
        Get
            Return _fkID_ESTADO
        End Get
        Set(ByVal Value As SOLIC_AGRICOLA_ESTADO)
            _fkID_ESTADO = Value
        End Set
    End Property

    Private _INTERES As Decimal
    <Column(Name:="INTERES", Storage:="INTERES", DBType:="NUMERIC(20,2) NOT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)>
    Public Property INTERES() As Decimal
        Get
            Return _INTERES
        End Get
        Set(ByVal Value As Decimal)
            _INTERES = Value
            OnPropertyChanged("INTERES")
        End Set
    End Property

    Private _IVA_INTERES As Decimal
    <Column(Name:="IVA_INTERES", Storage:="IVA_INTERES", DBType:="NUMERIC(20,2) NOT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)>
    Public Property IVA_INTERES() As Decimal
        Get
            Return _IVA_INTERES
        End Get
        Set(ByVal Value As Decimal)
            _IVA_INTERES = Value
            OnPropertyChanged("IVA_INTERES")
        End Set
    End Property


#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
