''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.PLANTILLA_PRODU_DATOS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row PLANTILLA_PRODU_DATOS en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	16/10/2017	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="PLANTILLA_PRODU_DATOS")> Public Class PLANTILLA_PRODU_DATOS
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_PLANTI_DATOS As Int32, aID_ZAFRA As Int32, aID_CATORCENA As Int32, aUID_REFERENCIA As Guid, aPRODUCTOR As String, aCODIPROVEEDOR As String, aID_CREDITO_ENCA As Int32, aID_CUENTA_FINAN As Int32, aID_PROVEE As Int32, aCONCEPTO As String, aPAGO As Decimal, aSALDO_INI As Decimal, aINTERES As Decimal, aABONO As Decimal, aABONO_INTERES As Decimal, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aCODIPROVEE As Int32, aFECHA_APLIC As DateTime, aFECHA_ULTMOV As DateTime, aTASAINT As Decimal, aTIPO_INTERES As String, aIVA_INTERES As Decimal, aPORC_CANA_PEND As Decimal, aMONTO_CANA_PEND As Decimal)
        Me._ID_PLANTI_DATOS = aID_PLANTI_DATOS
        Me._ID_ZAFRA = aID_ZAFRA
        Me._ID_CATORCENA = aID_CATORCENA
        Me._UID_REFERENCIA = aUID_REFERENCIA
        Me._PRODUCTOR = aPRODUCTOR
        Me._CODIPROVEEDOR = aCODIPROVEEDOR
        Me._ID_CREDITO_ENCA = aID_CREDITO_ENCA
        Me._ID_CUENTA_FINAN = aID_CUENTA_FINAN
        Me._ID_PROVEE = aID_PROVEE
        Me._CONCEPTO = aCONCEPTO
        Me._PAGO = aPAGO
        Me._SALDO_INI = aSALDO_INI
        Me._INTERES = aINTERES
        Me._ABONO = aABONO
        Me._ABONO_INTERES = aABONO_INTERES
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._CODIPROVEE = aCODIPROVEE
        Me._FECHA_APLIC = aFECHA_APLIC
        Me._FECHA_ULTMOV = aFECHA_ULTMOV
        Me._TASAINT = aTASAINT
        Me._TIPO_INTERES = aTIPO_INTERES
        Me._IVA_INTERES = aIVA_INTERES
        Me._PORC_CANA_PEND = aPORC_CANA_PEND
        Me._MONTO_CANA_PEND = aMONTO_CANA_PEND
    End Sub

#Region " Properties "

    Private _ID_PLANTI_DATOS As Int32
    <Column(Name:="Id planti datos", Storage:="ID_PLANTI_DATOS", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_PLANTI_DATOS() As Int32
        Get
            Return _ID_PLANTI_DATOS
        End Get
        Set(ByVal Value As Int32)
            _ID_PLANTI_DATOS = Value
            OnPropertyChanged("ID_PLANTI_DATOS")
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

    Private _PRODUCTOR As String
    <Column(Name:="Productor", Storage:="PRODUCTOR", DbType:="VARCHAR(200)", Id:=False), _
     DataObjectField(False, False, True, 200)> _
    Public Property PRODUCTOR() As String
        Get
            Return _PRODUCTOR
        End Get
        Set(ByVal Value As String)
            _PRODUCTOR = Value
            OnPropertyChanged("PRODUCTOR")
        End Set
    End Property 

    Private _PRODUCTOROld As String
    Public Property PRODUCTOROld() As String
        Get
            Return _PRODUCTOROld
        End Get
        Set(ByVal Value As String)
            _PRODUCTOROld = Value
        End Set
    End Property 

    Private _CODIPROVEEDOR As String
    <Column(Name:="Codiproveedor", Storage:="CODIPROVEEDOR", DbType:="VARCHAR(50)", Id:=False), _
     DataObjectField(False, False, True, 50)> _
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

    Private _ID_CREDITO_ENCA As Int32
    <Column(Name:="Id credito enca", Storage:="ID_CREDITO_ENCA", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
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

    Private _CONCEPTO As String
    <Column(Name:="Concepto", Storage:="CONCEPTO", DbType:="VARCHAR(200)", Id:=False), _
     DataObjectField(False, False, True, 200)> _
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

    Private _PAGO As Decimal
    <Column(Name:="Pago", Storage:="PAGO", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property PAGO() As Decimal
        Get
            Return _PAGO
        End Get
        Set(ByVal Value As Decimal)
            _PAGO = Value
            OnPropertyChanged("PAGO")
        End Set
    End Property 

    Private _PAGOOld As Decimal
    Public Property PAGOOld() As Decimal
        Get
            Return _PAGOOld
        End Get
        Set(ByVal Value As Decimal)
            _PAGOOld = Value
        End Set
    End Property 

    Private _SALDO_INI As Decimal
    <Column(Name:="Saldo ini", Storage:="SALDO_INI", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property SALDO_INI() As Decimal
        Get
            Return _SALDO_INI
        End Get
        Set(ByVal Value As Decimal)
            _SALDO_INI = Value
            OnPropertyChanged("SALDO_INI")
        End Set
    End Property 

    Private _SALDO_INIOld As Decimal
    Public Property SALDO_INIOld() As Decimal
        Get
            Return _SALDO_INIOld
        End Get
        Set(ByVal Value As Decimal)
            _SALDO_INIOld = Value
        End Set
    End Property 

    Private _INTERES As Decimal
    <Column(Name:="Interes", Storage:="INTERES", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
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

    Private _ABONO As Decimal
    <Column(Name:="Abono", Storage:="ABONO", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
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

    Private _ABONO_INTERES As Decimal
    <Column(Name:="Abono interes", Storage:="ABONO_INTERES", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
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

    Private _CODIPROVEE As Int32
    <Column(Name:="Codiprovee", Storage:="CODIPROVEE", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property CODIPROVEE() As Int32
        Get
            Return _CODIPROVEE
        End Get
        Set(ByVal Value As Int32)
            _CODIPROVEE = Value
            OnPropertyChanged("CODIPROVEE")
        End Set
    End Property 

    Private _CODIPROVEEOld As Int32
    Public Property CODIPROVEEOld() As Int32
        Get
            Return _CODIPROVEEOld
        End Get
        Set(ByVal Value As Int32)
            _CODIPROVEEOld = Value
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

    Private _IVA_INTERES As Decimal
    <Column(Name:="Iva interes", Storage:="IVA_INTERES", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
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

    Private _PORC_CANA_PEND As Decimal
    <Column(Name:="Porc cana pend", Storage:="PORC_CANA_PEND", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property PORC_CANA_PEND() As Decimal
        Get
            Return _PORC_CANA_PEND
        End Get
        Set(ByVal Value As Decimal)
            _PORC_CANA_PEND = Value
            OnPropertyChanged("PORC_CANA_PEND")
        End Set
    End Property 

    Private _PORC_CANA_PENDOld As Decimal
    Public Property PORC_CANA_PENDOld() As Decimal
        Get
            Return _PORC_CANA_PENDOld
        End Get
        Set(ByVal Value As Decimal)
            _PORC_CANA_PENDOld = Value
        End Set
    End Property 

    Private _MONTO_CANA_PEND As Decimal
    <Column(Name:="Monto cana pend", Storage:="MONTO_CANA_PEND", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property MONTO_CANA_PEND() As Decimal
        Get
            Return _MONTO_CANA_PEND
        End Get
        Set(ByVal Value As Decimal)
            _MONTO_CANA_PEND = Value
            OnPropertyChanged("MONTO_CANA_PEND")
        End Set
    End Property 

    Private _MONTO_CANA_PENDOld As Decimal
    Public Property MONTO_CANA_PENDOld() As Decimal
        Get
            Return _MONTO_CANA_PENDOld
        End Get
        Set(ByVal Value As Decimal)
            _MONTO_CANA_PENDOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
