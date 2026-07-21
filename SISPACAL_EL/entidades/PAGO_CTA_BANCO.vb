''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.PAGO_CTA_BANCO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row PAGO_CTA_BANCO en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	13/01/2017	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="PAGO_CTA_BANCO")> Public Class PAGO_CTA_BANCO
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_PAGO_CTA_BANCO As Int32, aID_CATORCENA As Int32, aCODIPROVEEDOR_TRANSPORTISTA As String, aID_TIPO_PLANILLA As Int32, aCODIBANCO As Int32, aNUM_CUENTA As String, aES_CTA_CORRIENTE As Boolean, aMONTO_PAGO As Decimal, aENTREGO_CCF As Boolean, aPAGO_GENERADO As Boolean, aFECHA_GENPAGO As DateTime, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime)
        Me._ID_PAGO_CTA_BANCO = aID_PAGO_CTA_BANCO
        Me._ID_CATORCENA = aID_CATORCENA
        Me._CODIPROVEEDOR_TRANSPORTISTA = aCODIPROVEEDOR_TRANSPORTISTA
        Me._ID_TIPO_PLANILLA = aID_TIPO_PLANILLA
        Me._CODIBANCO = aCODIBANCO
        Me._NUM_CUENTA = aNUM_CUENTA
        Me._ES_CTA_CORRIENTE = aES_CTA_CORRIENTE
        Me._MONTO_PAGO = aMONTO_PAGO
        Me._ENTREGO_CCF = aENTREGO_CCF
        Me._PAGO_GENERADO = aPAGO_GENERADO
        Me._FECHA_GENPAGO = aFECHA_GENPAGO
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
    End Sub

#Region " Properties "

    Private _ID_PAGO_CTA_BANCO As Int32
    <Column(Name:="Id pago cta banco", Storage:="ID_PAGO_CTA_BANCO", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_PAGO_CTA_BANCO() As Int32
        Get
            Return _ID_PAGO_CTA_BANCO
        End Get
        Set(ByVal Value As Int32)
            _ID_PAGO_CTA_BANCO = Value
            OnPropertyChanged("ID_PAGO_CTA_BANCO")
        End Set
    End Property 

    Private _ID_CATORCENA As Int32
    <Column(Name:="Id catorcena", Storage:="ID_CATORCENA", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
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

    Private _fkID_CATORCENA As CATORCENA_ZAFRA
    Public Property fkID_CATORCENA() As CATORCENA_ZAFRA
        Get
            Return _fkID_CATORCENA
        End Get
        Set(ByVal Value As CATORCENA_ZAFRA)
            _fkID_CATORCENA = Value
        End Set
    End Property 

    Private _CODIPROVEEDOR_TRANSPORTISTA As String
    <Column(Name:="Codiproveedor transportista", Storage:="CODIPROVEEDOR_TRANSPORTISTA", DbType:="VARCHAR(10) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 10)> _
    Public Property CODIPROVEEDOR_TRANSPORTISTA() As String
        Get
            Return _CODIPROVEEDOR_TRANSPORTISTA
        End Get
        Set(ByVal Value As String)
            _CODIPROVEEDOR_TRANSPORTISTA = Value
            OnPropertyChanged("CODIPROVEEDOR_TRANSPORTISTA")
        End Set
    End Property 

    Private _CODIPROVEEDOR_TRANSPORTISTAOld As String
    Public Property CODIPROVEEDOR_TRANSPORTISTAOld() As String
        Get
            Return _CODIPROVEEDOR_TRANSPORTISTAOld
        End Get
        Set(ByVal Value As String)
            _CODIPROVEEDOR_TRANSPORTISTAOld = Value
        End Set
    End Property 

    Private _fkCODIPROVEEDOR_TRANSPORTISTA As PLANILLA
    Public Property fkCODIPROVEEDOR_TRANSPORTISTA() As PLANILLA
        Get
            Return _fkCODIPROVEEDOR_TRANSPORTISTA
        End Get
        Set(ByVal Value As PLANILLA)
            _fkCODIPROVEEDOR_TRANSPORTISTA = Value
        End Set
    End Property 

    Private _ID_TIPO_PLANILLA As Int32
    <Column(Name:="Id tipo planilla", Storage:="ID_TIPO_PLANILLA", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_TIPO_PLANILLA() As Int32
        Get
            Return _ID_TIPO_PLANILLA
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_PLANILLA = Value
            OnPropertyChanged("ID_TIPO_PLANILLA")
        End Set
    End Property 

    Private _ID_TIPO_PLANILLAOld As Int32
    Public Property ID_TIPO_PLANILLAOld() As Int32
        Get
            Return _ID_TIPO_PLANILLAOld
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_PLANILLAOld = Value
        End Set
    End Property 

    Private _fkID_TIPO_PLANILLA As TIPO_PLANILLA
    Public Property fkID_TIPO_PLANILLA() As TIPO_PLANILLA
        Get
            Return _fkID_TIPO_PLANILLA
        End Get
        Set(ByVal Value As TIPO_PLANILLA)
            _fkID_TIPO_PLANILLA = Value
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

    Private _NUM_CUENTA As String
    <Column(Name:="Num cuenta", Storage:="NUM_CUENTA", DbType:="VARCHAR(30) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 30)> _
    Public Property NUM_CUENTA() As String
        Get
            Return _NUM_CUENTA
        End Get
        Set(ByVal Value As String)
            _NUM_CUENTA = Value
            OnPropertyChanged("NUM_CUENTA")
        End Set
    End Property 

    Private _NUM_CUENTAOld As String
    Public Property NUM_CUENTAOld() As String
        Get
            Return _NUM_CUENTAOld
        End Get
        Set(ByVal Value As String)
            _NUM_CUENTAOld = Value
        End Set
    End Property 

    Private _ES_CTA_CORRIENTE As Boolean
    <Column(Name:="Es cta corriente", Storage:="ES_CTA_CORRIENTE", DbType:="BIT NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 1)> _
    Public Property ES_CTA_CORRIENTE() As Boolean
        Get
            Return _ES_CTA_CORRIENTE
        End Get
        Set(ByVal Value As Boolean)
            _ES_CTA_CORRIENTE = Value
            OnPropertyChanged("ES_CTA_CORRIENTE")
        End Set
    End Property 

    Private _ES_CTA_CORRIENTEOld As Boolean
    Public Property ES_CTA_CORRIENTEOld() As Boolean
        Get
            Return _ES_CTA_CORRIENTEOld
        End Get
        Set(ByVal Value As Boolean)
            _ES_CTA_CORRIENTEOld = Value
        End Set
    End Property 

    Private _MONTO_PAGO As Decimal
    <Column(Name:="Monto pago", Storage:="MONTO_PAGO", DbType:="NUMERIC(20,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)> _
    Public Property MONTO_PAGO() As Decimal
        Get
            Return _MONTO_PAGO
        End Get
        Set(ByVal Value As Decimal)
            _MONTO_PAGO = Value
            OnPropertyChanged("MONTO_PAGO")
        End Set
    End Property 

    Private _MONTO_PAGOOld As Decimal
    Public Property MONTO_PAGOOld() As Decimal
        Get
            Return _MONTO_PAGOOld
        End Get
        Set(ByVal Value As Decimal)
            _MONTO_PAGOOld = Value
        End Set
    End Property 

    Private _ENTREGO_CCF As Boolean
    <Column(Name:="Entrego ccf", Storage:="ENTREGO_CCF", DbType:="BIT NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 1)> _
    Public Property ENTREGO_CCF() As Boolean
        Get
            Return _ENTREGO_CCF
        End Get
        Set(ByVal Value As Boolean)
            _ENTREGO_CCF = Value
            OnPropertyChanged("ENTREGO_CCF")
        End Set
    End Property 

    Private _ENTREGO_CCFOld As Boolean
    Public Property ENTREGO_CCFOld() As Boolean
        Get
            Return _ENTREGO_CCFOld
        End Get
        Set(ByVal Value As Boolean)
            _ENTREGO_CCFOld = Value
        End Set
    End Property 

    Private _PAGO_GENERADO As Boolean
    <Column(Name:="Pago generado", Storage:="PAGO_GENERADO", DbType:="BIT NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 1)> _
    Public Property PAGO_GENERADO() As Boolean
        Get
            Return _PAGO_GENERADO
        End Get
        Set(ByVal Value As Boolean)
            _PAGO_GENERADO = Value
            OnPropertyChanged("PAGO_GENERADO")
        End Set
    End Property 

    Private _PAGO_GENERADOOld As Boolean
    Public Property PAGO_GENERADOOld() As Boolean
        Get
            Return _PAGO_GENERADOOld
        End Get
        Set(ByVal Value As Boolean)
            _PAGO_GENERADOOld = Value
        End Set
    End Property 

    Private _FECHA_GENPAGO As DateTime
    <Column(Name:="Fecha genpago", Storage:="FECHA_GENPAGO", DbType:="DATETIME", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_GENPAGO() As DateTime
        Get
            Return _FECHA_GENPAGO
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_GENPAGO = Value
            OnPropertyChanged("FECHA_GENPAGO")
        End Set
    End Property 

    Private _FECHA_GENPAGOOld As DateTime
    Public Property FECHA_GENPAGOOld() As DateTime
        Get
            Return _FECHA_GENPAGOOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_GENPAGOOld = Value
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
