''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.CONTROL_QUEMA_SALDO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row CONTROL_QUEMA_SALDO en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	18/11/2016	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="CONTROL_QUEMA_SALDO")> Public Class CONTROL_QUEMA_SALDO
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_QUEMA_SALDO As Int32, aID_ZAFRA As Int32, aACCESLOTE As String, aFECHA_HORA_QUEMA As DateTime, aQUEMA_PROGRAMADA As Boolean, aQUEMA_NOPROG As Boolean, aCANA_VERDE As Boolean, aES_PROYECCION As Boolean, aENTRADAS As Decimal, aSALIDAS As Decimal, aSALDO As Decimal, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime, aFECHA_HORA_QUEMA_PROY As DateTime, aFECHA_HORA_QUEMA_REAL As DateTime, aTC_PROY As Decimal, aTC_REAL As Decimal)
        Me._ID_QUEMA_SALDO = aID_QUEMA_SALDO
        Me._ID_ZAFRA = aID_ZAFRA
        Me._ACCESLOTE = aACCESLOTE
        Me._FECHA_HORA_QUEMA = aFECHA_HORA_QUEMA
        Me._QUEMA_PROGRAMADA = aQUEMA_PROGRAMADA
        Me._QUEMA_NOPROG = aQUEMA_NOPROG
        Me._CANA_VERDE = aCANA_VERDE
        Me._ES_PROYECCION = aES_PROYECCION
        Me._ENTRADAS = aENTRADAS
        Me._SALIDAS = aSALIDAS
        Me._SALDO = aSALDO
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
        Me._FECHA_HORA_QUEMA_PROY = aFECHA_HORA_QUEMA_PROY
        Me._FECHA_HORA_QUEMA_REAL = aFECHA_HORA_QUEMA_REAL
        Me._TC_PROY = aTC_PROY
        Me._TC_REAL = aTC_REAL
    End Sub

#Region " Properties "

    Private _ID_QUEMA_SALDO As Int32
    <Column(Name:="Id quema saldo", Storage:="ID_QUEMA_SALDO", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_QUEMA_SALDO() As Int32
        Get
            Return _ID_QUEMA_SALDO
        End Get
        Set(ByVal Value As Int32)
            _ID_QUEMA_SALDO = Value
            OnPropertyChanged("ID_QUEMA_SALDO")
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

    Private _FECHA_HORA_QUEMA As DateTime
    <Column(Name:="Fecha hora quema", Storage:="FECHA_HORA_QUEMA", DbType:="DATETIME", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_HORA_QUEMA() As DateTime
        Get
            Return _FECHA_HORA_QUEMA
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_HORA_QUEMA = Value
            OnPropertyChanged("FECHA_HORA_QUEMA")
        End Set
    End Property 

    Private _FECHA_HORA_QUEMAOld As DateTime
    Public Property FECHA_HORA_QUEMAOld() As DateTime
        Get
            Return _FECHA_HORA_QUEMAOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_HORA_QUEMAOld = Value
        End Set
    End Property 

    Private _QUEMA_PROGRAMADA As Boolean
    <Column(Name:="Quema programada", Storage:="QUEMA_PROGRAMADA", DbType:="BIT NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 1)> _
    Public Property QUEMA_PROGRAMADA() As Boolean
        Get
            Return _QUEMA_PROGRAMADA
        End Get
        Set(ByVal Value As Boolean)
            _QUEMA_PROGRAMADA = Value
            OnPropertyChanged("QUEMA_PROGRAMADA")
        End Set
    End Property 

    Private _QUEMA_PROGRAMADAOld As Boolean
    Public Property QUEMA_PROGRAMADAOld() As Boolean
        Get
            Return _QUEMA_PROGRAMADAOld
        End Get
        Set(ByVal Value As Boolean)
            _QUEMA_PROGRAMADAOld = Value
        End Set
    End Property 

    Private _QUEMA_NOPROG As Boolean
    <Column(Name:="Quema noprog", Storage:="QUEMA_NOPROG", DbType:="BIT NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 1)> _
    Public Property QUEMA_NOPROG() As Boolean
        Get
            Return _QUEMA_NOPROG
        End Get
        Set(ByVal Value As Boolean)
            _QUEMA_NOPROG = Value
            OnPropertyChanged("QUEMA_NOPROG")
        End Set
    End Property 

    Private _QUEMA_NOPROGOld As Boolean
    Public Property QUEMA_NOPROGOld() As Boolean
        Get
            Return _QUEMA_NOPROGOld
        End Get
        Set(ByVal Value As Boolean)
            _QUEMA_NOPROGOld = Value
        End Set
    End Property 

    Private _CANA_VERDE As Boolean
    <Column(Name:="Cana verde", Storage:="CANA_VERDE", DbType:="BIT NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 1)> _
    Public Property CANA_VERDE() As Boolean
        Get
            Return _CANA_VERDE
        End Get
        Set(ByVal Value As Boolean)
            _CANA_VERDE = Value
            OnPropertyChanged("CANA_VERDE")
        End Set
    End Property 

    Private _CANA_VERDEOld As Boolean
    Public Property CANA_VERDEOld() As Boolean
        Get
            Return _CANA_VERDEOld
        End Get
        Set(ByVal Value As Boolean)
            _CANA_VERDEOld = Value
        End Set
    End Property 

    Private _ES_PROYECCION As Boolean
    <Column(Name:="Es proyeccion", Storage:="ES_PROYECCION", DbType:="BIT NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 1)> _
    Public Property ES_PROYECCION() As Boolean
        Get
            Return _ES_PROYECCION
        End Get
        Set(ByVal Value As Boolean)
            _ES_PROYECCION = Value
            OnPropertyChanged("ES_PROYECCION")
        End Set
    End Property 

    Private _ES_PROYECCIONOld As Boolean
    Public Property ES_PROYECCIONOld() As Boolean
        Get
            Return _ES_PROYECCIONOld
        End Get
        Set(ByVal Value As Boolean)
            _ES_PROYECCIONOld = Value
        End Set
    End Property 

    Private _ENTRADAS As Decimal
    <Column(Name:="Entradas", Storage:="ENTRADAS", DbType:="NUMERIC(10,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)> _
    Public Property ENTRADAS() As Decimal
        Get
            Return _ENTRADAS
        End Get
        Set(ByVal Value As Decimal)
            _ENTRADAS = Value
            OnPropertyChanged("ENTRADAS")
        End Set
    End Property 

    Private _ENTRADASOld As Decimal
    Public Property ENTRADASOld() As Decimal
        Get
            Return _ENTRADASOld
        End Get
        Set(ByVal Value As Decimal)
            _ENTRADASOld = Value
        End Set
    End Property 

    Private _SALIDAS As Decimal
    <Column(Name:="Salidas", Storage:="SALIDAS", DbType:="NUMERIC(10,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)> _
    Public Property SALIDAS() As Decimal
        Get
            Return _SALIDAS
        End Get
        Set(ByVal Value As Decimal)
            _SALIDAS = Value
            OnPropertyChanged("SALIDAS")
        End Set
    End Property 

    Private _SALIDASOld As Decimal
    Public Property SALIDASOld() As Decimal
        Get
            Return _SALIDASOld
        End Get
        Set(ByVal Value As Decimal)
            _SALIDASOld = Value
        End Set
    End Property 

    Private _SALDO As Decimal
    <Column(Name:="Saldo", Storage:="SALDO", DbType:="NUMERIC(10,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)> _
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

    Private _FECHA_HORA_QUEMA_PROY As DateTime
    <Column(Name:="Fecha hora quema proy", Storage:="FECHA_HORA_QUEMA_PROY", DbType:="DATETIME", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_HORA_QUEMA_PROY() As DateTime
        Get
            Return _FECHA_HORA_QUEMA_PROY
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_HORA_QUEMA_PROY = Value
            OnPropertyChanged("FECHA_HORA_QUEMA_PROY")
        End Set
    End Property 

    Private _FECHA_HORA_QUEMA_PROYOld As DateTime
    Public Property FECHA_HORA_QUEMA_PROYOld() As DateTime
        Get
            Return _FECHA_HORA_QUEMA_PROYOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_HORA_QUEMA_PROYOld = Value
        End Set
    End Property 

    Private _FECHA_HORA_QUEMA_REAL As DateTime
    <Column(Name:="Fecha hora quema real", Storage:="FECHA_HORA_QUEMA_REAL", DbType:="DATETIME", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_HORA_QUEMA_REAL() As DateTime
        Get
            Return _FECHA_HORA_QUEMA_REAL
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_HORA_QUEMA_REAL = Value
            OnPropertyChanged("FECHA_HORA_QUEMA_REAL")
        End Set
    End Property 

    Private _FECHA_HORA_QUEMA_REALOld As DateTime
    Public Property FECHA_HORA_QUEMA_REALOld() As DateTime
        Get
            Return _FECHA_HORA_QUEMA_REALOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_HORA_QUEMA_REALOld = Value
        End Set
    End Property 

    Private _TC_PROY As Decimal
    <Column(Name:="Tc proy", Storage:="TC_PROY", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property TC_PROY() As Decimal
        Get
            Return _TC_PROY
        End Get
        Set(ByVal Value As Decimal)
            _TC_PROY = Value
            OnPropertyChanged("TC_PROY")
        End Set
    End Property 

    Private _TC_PROYOld As Decimal
    Public Property TC_PROYOld() As Decimal
        Get
            Return _TC_PROYOld
        End Get
        Set(ByVal Value As Decimal)
            _TC_PROYOld = Value
        End Set
    End Property 

    Private _TC_REAL As Decimal
    <Column(Name:="Tc real", Storage:="TC_REAL", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property TC_REAL() As Decimal
        Get
            Return _TC_REAL
        End Get
        Set(ByVal Value As Decimal)
            _TC_REAL = Value
            OnPropertyChanged("TC_REAL")
        End Set
    End Property 

    Private _TC_REALOld As Decimal
    Public Property TC_REALOld() As Decimal
        Get
            Return _TC_REALOld
        End Get
        Set(ByVal Value As Decimal)
            _TC_REALOld = Value
        End Set
    End Property

    Private _ID_SUBLOTES As Int32
    <Column(Name:="Id sublotes", Storage:="ID_SUBLOTES", DBType:="INT  NULL", Id:=False),
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)>
    Public Property ID_SUBLOTES() As Int32
        Get
            Return _ID_SUBLOTES
        End Get
        Set(ByVal Value As Int32)
            _ID_SUBLOTES = Value
            OnPropertyChanged("ID_SUBLOTES")
        End Set
    End Property

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
