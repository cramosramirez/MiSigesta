''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.SOLIC_ANTICIPO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row SOLIC_ANTICIPO en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	13/06/2018	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="SOLIC_ANTICIPO")> Public Class SOLIC_ANTICIPO
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_ANTICIPO As Int32, aCODIPROVEEDOR As String, aNUM_ANTICIPO As Int32, aFECHA As DateTime, aCONCEPTO As String, aMONTO As Decimal, aUID_ANTICIPO_CONTRATO As Guid, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime, aID_ZAFRA As Int32, aZAFRA As String, aFECHA_CHEQUE As DateTime, aPORC_INTERES As Decimal, aES_ACEPTADA As Boolean, aCHQ_NO As String, aID_CUENTA_FINAN As Int32, aPLAZO_MESES As Int32, aFECHA_VENCE As DateTime, aID_ESTADO As Int32, aPERFECHA_INI As DateTime, aPERFECHA_FIN As DateTime)
        Me._ID_ANTICIPO = aID_ANTICIPO
        Me._CODIPROVEEDOR = aCODIPROVEEDOR
        Me._NUM_ANTICIPO = aNUM_ANTICIPO
        Me._FECHA = aFECHA
        Me._CONCEPTO = aCONCEPTO
        Me._MONTO = aMONTO
        Me._UID_ANTICIPO_CONTRATO = aUID_ANTICIPO_CONTRATO
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
        Me._ID_ZAFRA = aID_ZAFRA
        Me._ZAFRA = aZAFRA
        Me._FECHA_CHEQUE = aFECHA_CHEQUE
        Me._PORC_INTERES = aPORC_INTERES
        Me._ES_ACEPTADA = aES_ACEPTADA
        Me._CHQ_NO = aCHQ_NO
        Me._ID_CUENTA_FINAN = aID_CUENTA_FINAN
        Me._PLAZO_MESES = aPLAZO_MESES
        Me._FECHA_VENCE = aFECHA_VENCE
        Me._ID_ESTADO = aID_ESTADO
        Me._PERFECHA_INI = aPERFECHA_INI
        Me._PERFECHA_FIN = aPERFECHA_FIN
    End Sub

#Region " Properties "

    Private _ID_ANTICIPO As Int32
    <Column(Name:="Id anticipo", Storage:="ID_ANTICIPO", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_ANTICIPO() As Int32
        Get
            Return _ID_ANTICIPO
        End Get
        Set(ByVal Value As Int32)
            _ID_ANTICIPO = Value
            OnPropertyChanged("ID_ANTICIPO")
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

    Private _NUM_ANTICIPO As Int32
    <Column(Name:="Num anticipo", Storage:="NUM_ANTICIPO", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property NUM_ANTICIPO() As Int32
        Get
            Return _NUM_ANTICIPO
        End Get
        Set(ByVal Value As Int32)
            _NUM_ANTICIPO = Value
            OnPropertyChanged("NUM_ANTICIPO")
        End Set
    End Property 

    Private _NUM_ANTICIPOOld As Int32
    Public Property NUM_ANTICIPOOld() As Int32
        Get
            Return _NUM_ANTICIPOOld
        End Get
        Set(ByVal Value As Int32)
            _NUM_ANTICIPOOld = Value
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

    Private _CONCEPTO As String
    <Column(Name:="Concepto", Storage:="CONCEPTO", DBType:="VARCHAR(3000) NOT NULL", Id:=False),
     DataObjectField(False, False, False, 3000)>
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

    Private _DESTINO As String
    <Column(Name:="Destino", Storage:="DESTINO", DBType:="VARCHAR(100) NOT NULL", Id:=False),
     DataObjectField(False, False, False, 3000)>
    Public Property DESTINO() As String
        Get
            Return _DESTINO
        End Get
        Set(ByVal Value As String)
            _DESTINO = Value
            OnPropertyChanged("DESTINO")
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

    Private _UID_ANTICIPO_CONTRATO As Guid
    <Column(Name:="Uid anticipo contrato", Storage:="UID_ANTICIPO_CONTRATO", DbType:="UNIQUEIDENTIFIER(36, 0)", Id:=False), _
     DataObjectField(False, False, True, 16)> _
    Public Property UID_ANTICIPO_CONTRATO() As Guid
        Get
            Return _UID_ANTICIPO_CONTRATO
        End Get
        Set(ByVal Value As Guid)
            _UID_ANTICIPO_CONTRATO = Value
            OnPropertyChanged("UID_ANTICIPO_CONTRATO")
        End Set
    End Property 

    Private _UID_ANTICIPO_CONTRATOOld As Guid
    Public Property UID_ANTICIPO_CONTRATOOld() As Guid
        Get
            Return _UID_ANTICIPO_CONTRATOOld
        End Get
        Set(ByVal Value As Guid)
            _UID_ANTICIPO_CONTRATOOld = Value
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

    Private _FECHA_CHEQUE As DateTime
    <Column(Name:="Fecha cheque", Storage:="FECHA_CHEQUE", DbType:="DATETIME", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_CHEQUE() As DateTime
        Get
            Return _FECHA_CHEQUE
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_CHEQUE = Value
            OnPropertyChanged("FECHA_CHEQUE")
        End Set
    End Property 

    Private _FECHA_CHEQUEOld As DateTime
    Public Property FECHA_CHEQUEOld() As DateTime
        Get
            Return _FECHA_CHEQUEOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_CHEQUEOld = Value
        End Set
    End Property 

    Private _PORC_INTERES As Decimal
    <Column(Name:="Porc interes", Storage:="PORC_INTERES", DbType:="NUMERIC(10,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=2)> _
    Public Property PORC_INTERES() As Decimal
        Get
            Return _PORC_INTERES
        End Get
        Set(ByVal Value As Decimal)
            _PORC_INTERES = Value
            OnPropertyChanged("PORC_INTERES")
        End Set
    End Property 

    Private _PORC_INTERESOld As Decimal
    Public Property PORC_INTERESOld() As Decimal
        Get
            Return _PORC_INTERESOld
        End Get
        Set(ByVal Value As Decimal)
            _PORC_INTERESOld = Value
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

    Private _CHQ_NO As String
    <Column(Name:="Chq no", Storage:="CHQ_NO", DbType:="VARCHAR(200)", Id:=False), _
     DataObjectField(False, False, True, 200)> _
    Public Property CHQ_NO() As String
        Get
            Return _CHQ_NO
        End Get
        Set(ByVal Value As String)
            _CHQ_NO = Value
            OnPropertyChanged("CHQ_NO")
        End Set
    End Property 

    Private _CHQ_NOOld As String
    Public Property CHQ_NOOld() As String
        Get
            Return _CHQ_NOOld
        End Get
        Set(ByVal Value As String)
            _CHQ_NOOld = Value
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

    Private _PLAZO_MESES As Int32
    <Column(Name:="Plazo meses", Storage:="PLAZO_MESES", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property PLAZO_MESES() As Int32
        Get
            Return _PLAZO_MESES
        End Get
        Set(ByVal Value As Int32)
            _PLAZO_MESES = Value
            OnPropertyChanged("PLAZO_MESES")
        End Set
    End Property 

    Private _PLAZO_MESESOld As Int32
    Public Property PLAZO_MESESOld() As Int32
        Get
            Return _PLAZO_MESESOld
        End Get
        Set(ByVal Value As Int32)
            _PLAZO_MESESOld = Value
        End Set
    End Property 

    Private _FECHA_VENCE As DateTime
    <Column(Name:="Fecha vence", Storage:="FECHA_VENCE", DbType:="DATETIME", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_VENCE() As DateTime
        Get
            Return _FECHA_VENCE
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_VENCE = Value
            OnPropertyChanged("FECHA_VENCE")
        End Set
    End Property 

    Private _FECHA_VENCEOld As DateTime
    Public Property FECHA_VENCEOld() As DateTime
        Get
            Return _FECHA_VENCEOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_VENCEOld = Value
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


    Private _PERFECHA_INI As DateTime
    <Column(Name:="Per Fecha Ini", Storage:="PERFECHA_INI", DbType:="DATETIME", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property PERFECHA_INI() As DateTime
        Get
            Return _PERFECHA_INI
        End Get
        Set(ByVal Value As DateTime)
            _PERFECHA_INI = Value
            OnPropertyChanged("PERFECHA_INI")
        End Set
    End Property

    Private _PERFECHA_INIOld As DateTime
    Public Property PERFECHA_INIOld() As DateTime
        Get
            Return _PERFECHA_INIOld
        End Get
        Set(ByVal Value As DateTime)
            _PERFECHA_INIOld = Value
        End Set
    End Property


    Private _PERFECHA_FIN As DateTime
    <Column(Name:="Per Fecha Fin", Storage:="PERFECHA_FIN", DbType:="DATETIME", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property PERFECHA_FIN() As DateTime
        Get
            Return _PERFECHA_FIN
        End Get
        Set(ByVal Value As DateTime)
            _PERFECHA_FIN = Value
            OnPropertyChanged("PERFECHA_FIN")
        End Set
    End Property

    Private _PERFECHA_FINOld As DateTime
    Public Property PERFECHA_FINOld() As DateTime
        Get
            Return _PERFECHA_FINOld
        End Get
        Set(ByVal Value As DateTime)
            _PERFECHA_FINOld = Value
        End Set
    End Property
#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
