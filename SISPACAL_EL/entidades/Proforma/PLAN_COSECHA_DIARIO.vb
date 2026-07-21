''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.PLAN_COSECHA_DIARIO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row PLAN_COSECHA_DIARIO en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	19/03/2015	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="PLAN_COSECHA_DIARIO")> Public Class PLAN_COSECHA_DIARIO
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_PLAN_COSECHA_DIARIO As Int32, aID_ZAFRA As Int32, aACCESLOTE As String, aZONA As String, aCODILOTE As String, aNOMBLOTE As String, aCODIPROVEE As String, aCCODISOCIO As String, aPROVEEDOR As String, aROZA_PROYECTADA As Decimal, aAUTORIZADO As Boolean, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime, aDIAZAFRA As Int32)
        Me._ID_PLAN_COSECHA_DIARIO = aID_PLAN_COSECHA_DIARIO
        Me._ID_ZAFRA = aID_ZAFRA
        Me._ACCESLOTE = aACCESLOTE
        Me._ZONA = aZONA
        Me._CODILOTE = aCODILOTE
        Me._NOMBLOTE = aNOMBLOTE
        Me._CODIPROVEE = aCODIPROVEE
        Me._CCODISOCIO = aCCODISOCIO
        Me._PROVEEDOR = aPROVEEDOR
        Me._ROZA_PROYECTADA = aROZA_PROYECTADA
        Me._AUTORIZADO = aAUTORIZADO
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
        Me._DIAZAFRA = aDIAZAFRA
    End Sub

#Region " Properties "

    Private _ID_PLAN_COSECHA_DIARIO As Int32
    <Column(Name:="Id plan cosecha diario", Storage:="ID_PLAN_COSECHA_DIARIO", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_PLAN_COSECHA_DIARIO() As Int32
        Get
            Return _ID_PLAN_COSECHA_DIARIO
        End Get
        Set(ByVal Value As Int32)
            _ID_PLAN_COSECHA_DIARIO = Value
            OnPropertyChanged("ID_PLAN_COSECHA_DIARIO")
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

    Private _ACCESLOTE As String
    <Column(Name:="Acceslote", Storage:="ACCESLOTE", DbType:="CHAR(21) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 21)> _
    Public Property ACCESLOTE() As String
        Get
            Return _ACCESLOTE
        End Get
        Set(ByVal Value As String)
            _ACCESLOTE = Value
            OnPropertyChanged("ACCESLOTE")
        End Set
    End Property 

    Private _ACCESLOTEOld As String
    Public Property ACCESLOTEOld() As String
        Get
            Return _ACCESLOTEOld
        End Get
        Set(ByVal Value As String)
            _ACCESLOTEOld = Value
        End Set
    End Property 

    Private _fkACCESLOTE As LOTES
    Public Property fkACCESLOTE() As LOTES
        Get
            Return _fkACCESLOTE
        End Get
        Set(ByVal Value As LOTES)
            _fkACCESLOTE = Value
        End Set
    End Property 

    Private _ZONA As String
    <Column(Name:="Zona", Storage:="ZONA", DbType:="CHAR(2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 2)> _
    Public Property ZONA() As String
        Get
            Return _ZONA
        End Get
        Set(ByVal Value As String)
            _ZONA = Value
            OnPropertyChanged("ZONA")
        End Set
    End Property 

    Private _ZONAOld As String
    Public Property ZONAOld() As String
        Get
            Return _ZONAOld
        End Get
        Set(ByVal Value As String)
            _ZONAOld = Value
        End Set
    End Property 

    Private _CODILOTE As String
    <Column(Name:="Codilote", Storage:="CODILOTE", DbType:="CHAR(5) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 5)> _
    Public Property CODILOTE() As String
        Get
            Return _CODILOTE
        End Get
        Set(ByVal Value As String)
            _CODILOTE = Value
            OnPropertyChanged("CODILOTE")
        End Set
    End Property 

    Private _CODILOTEOld As String
    Public Property CODILOTEOld() As String
        Get
            Return _CODILOTEOld
        End Get
        Set(ByVal Value As String)
            _CODILOTEOld = Value
        End Set
    End Property 

    Private _NOMBLOTE As String
    <Column(Name:="Nomblote", Storage:="NOMBLOTE", DbType:="CHAR(60) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 60)> _
    Public Property NOMBLOTE() As String
        Get
            Return _NOMBLOTE
        End Get
        Set(ByVal Value As String)
            _NOMBLOTE = Value
            OnPropertyChanged("NOMBLOTE")
        End Set
    End Property 

    Private _NOMBLOTEOld As String
    Public Property NOMBLOTEOld() As String
        Get
            Return _NOMBLOTEOld
        End Get
        Set(ByVal Value As String)
            _NOMBLOTEOld = Value
        End Set
    End Property 

    Private _CODIPROVEE As String
    <Column(Name:="Codiprovee", Storage:="CODIPROVEE", DbType:="CHAR(6) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 6)> _
    Public Property CODIPROVEE() As String
        Get
            Return _CODIPROVEE
        End Get
        Set(ByVal Value As String)
            _CODIPROVEE = Value
            OnPropertyChanged("CODIPROVEE")
        End Set
    End Property 

    Private _CODIPROVEEOld As String
    Public Property CODIPROVEEOld() As String
        Get
            Return _CODIPROVEEOld
        End Get
        Set(ByVal Value As String)
            _CODIPROVEEOld = Value
        End Set
    End Property 

    Private _CCODISOCIO As String
    <Column(Name:="Ccodisocio", Storage:="CCODISOCIO", DbType:="CHAR(4)", Id:=False), _
     DataObjectField(False, False, True, 4)> _
    Public Property CCODISOCIO() As String
        Get
            Return _CCODISOCIO
        End Get
        Set(ByVal Value As String)
            _CCODISOCIO = Value
            OnPropertyChanged("CCODISOCIO")
        End Set
    End Property 

    Private _CCODISOCIOOld As String
    Public Property CCODISOCIOOld() As String
        Get
            Return _CCODISOCIOOld
        End Get
        Set(ByVal Value As String)
            _CCODISOCIOOld = Value
        End Set
    End Property 

    Private _PROVEEDOR As String
    <Column(Name:="Proveedor", Storage:="PROVEEDOR", DbType:="VARCHAR(200) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 200)> _
    Public Property PROVEEDOR() As String
        Get
            Return _PROVEEDOR
        End Get
        Set(ByVal Value As String)
            _PROVEEDOR = Value
            OnPropertyChanged("PROVEEDOR")
        End Set
    End Property 

    Private _PROVEEDOROld As String
    Public Property PROVEEDOROld() As String
        Get
            Return _PROVEEDOROld
        End Get
        Set(ByVal Value As String)
            _PROVEEDOROld = Value
        End Set
    End Property 

    Private _ROZA_PROYECTADA As Decimal
    <Column(Name:="Roza proyectada", Storage:="ROZA_PROYECTADA", DbType:="NUMERIC(10,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)> _
    Public Property ROZA_PROYECTADA() As Decimal
        Get
            Return _ROZA_PROYECTADA
        End Get
        Set(ByVal Value As Decimal)
            _ROZA_PROYECTADA = Value
            OnPropertyChanged("ROZA_PROYECTADA")
        End Set
    End Property 

    Private _ROZA_PROYECTADAOld As Decimal
    Public Property ROZA_PROYECTADAOld() As Decimal
        Get
            Return _ROZA_PROYECTADAOld
        End Get
        Set(ByVal Value As Decimal)
            _ROZA_PROYECTADAOld = Value
        End Set
    End Property 

    Private _AUTORIZADO As Boolean
    <Column(Name:="Autorizado", Storage:="AUTORIZADO", DbType:="BIT NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 1)> _
    Public Property AUTORIZADO() As Boolean
        Get
            Return _AUTORIZADO
        End Get
        Set(ByVal Value As Boolean)
            _AUTORIZADO = Value
            OnPropertyChanged("AUTORIZADO")
        End Set
    End Property 

    Private _AUTORIZADOOld As Boolean
    Public Property AUTORIZADOOld() As Boolean
        Get
            Return _AUTORIZADOOld
        End Get
        Set(ByVal Value As Boolean)
            _AUTORIZADOOld = Value
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

    Private _DIAZAFRA As Int32
    <Column(Name:="Diazafra", Storage:="DIAZAFRA", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property DIAZAFRA() As Int32
        Get
            Return _DIAZAFRA
        End Get
        Set(ByVal Value As Int32)
            _DIAZAFRA = Value
            OnPropertyChanged("DIAZAFRA")
        End Set
    End Property 

    Private _DIAZAFRAOld As Int32
    Public Property DIAZAFRAOld() As Int32
        Get
            Return _DIAZAFRAOld
        End Get
        Set(ByVal Value As Int32)
            _DIAZAFRAOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
