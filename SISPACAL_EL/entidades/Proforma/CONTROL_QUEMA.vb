''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.CONTROL_QUEMA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row CONTROL_QUEMA en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	10/11/2016	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="CONTROL_QUEMA")> Public Class CONTROL_QUEMA
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_CONTROL_QUEMA As Int32, aID_ZAFRA As Int32, aACCESLOTE As String, aCONCEPTO As String, aCODIGO_REF As String, aID_REF As Int32, aENTRADAS As Decimal, aSALIDAS As Decimal, aSALDO As Decimal, aQUEMA_PROGRAMADA As Boolean, aQUEMA_NOPROG As Boolean, aCANA_VERDE As Boolean, aFECHA_HORA_QUEMA As DateTime, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime, aID_CONTROL_QUEMA_REF As Int32, aES_PROYECCION As Boolean, aID_QUEMA_SALDO As Int32)
        Me._ID_CONTROL_QUEMA = aID_CONTROL_QUEMA
        Me._ID_ZAFRA = aID_ZAFRA
        Me._ACCESLOTE = aACCESLOTE
        Me._CONCEPTO = aCONCEPTO
        Me._CODIGO_REF = aCODIGO_REF
        Me._ID_REF = aID_REF
        Me._ENTRADAS = aENTRADAS
        Me._SALIDAS = aSALIDAS
        Me._SALDO = aSALDO
        Me._QUEMA_PROGRAMADA = aQUEMA_PROGRAMADA
        Me._QUEMA_NOPROG = aQUEMA_NOPROG
        Me._CANA_VERDE = aCANA_VERDE
        Me._FECHA_HORA_QUEMA = aFECHA_HORA_QUEMA
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
        Me._ID_CONTROL_QUEMA_REF = aID_CONTROL_QUEMA_REF
        Me._ES_PROYECCION = aES_PROYECCION
        Me._ID_QUEMA_SALDO = aID_QUEMA_SALDO
    End Sub

#Region " Properties "

    Private _ID_CONTROL_QUEMA As Int32
    <Column(Name:="Id control quema", Storage:="ID_CONTROL_QUEMA", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_CONTROL_QUEMA() As Int32
        Get
            Return _ID_CONTROL_QUEMA
        End Get
        Set(ByVal Value As Int32)
            _ID_CONTROL_QUEMA = Value
            OnPropertyChanged("ID_CONTROL_QUEMA")
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

    Private _CONCEPTO As String
    <Column(Name:="Concepto", Storage:="CONCEPTO", DbType:="VARCHAR(200) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 200)> _
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

    Private _CODIGO_REF As String
    <Column(Name:="Codigo ref", Storage:="CODIGO_REF", DbType:="CHAR(10) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 10)> _
    Public Property CODIGO_REF() As String
        Get
            Return _CODIGO_REF
        End Get
        Set(ByVal Value As String)
            _CODIGO_REF = Value
            OnPropertyChanged("CODIGO_REF")
        End Set
    End Property 

    Private _CODIGO_REFOld As String
    Public Property CODIGO_REFOld() As String
        Get
            Return _CODIGO_REFOld
        End Get
        Set(ByVal Value As String)
            _CODIGO_REFOld = Value
        End Set
    End Property 

    Private _ID_REF As Int32
    <Column(Name:="Id ref", Storage:="ID_REF", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_REF() As Int32
        Get
            Return _ID_REF
        End Get
        Set(ByVal Value As Int32)
            _ID_REF = Value
            OnPropertyChanged("ID_REF")
        End Set
    End Property 

    Private _ID_REFOld As Int32
    Public Property ID_REFOld() As Int32
        Get
            Return _ID_REFOld
        End Get
        Set(ByVal Value As Int32)
            _ID_REFOld = Value
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

    Private _ID_CONTROL_QUEMA_REF As Int32
    <Column(Name:="Id control quema ref", Storage:="ID_CONTROL_QUEMA_REF", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_CONTROL_QUEMA_REF() As Int32
        Get
            Return _ID_CONTROL_QUEMA_REF
        End Get
        Set(ByVal Value As Int32)
            _ID_CONTROL_QUEMA_REF = Value
            OnPropertyChanged("ID_CONTROL_QUEMA_REF")
        End Set
    End Property 

    Private _ID_CONTROL_QUEMA_REFOld As Int32
    Public Property ID_CONTROL_QUEMA_REFOld() As Int32
        Get
            Return _ID_CONTROL_QUEMA_REFOld
        End Get
        Set(ByVal Value As Int32)
            _ID_CONTROL_QUEMA_REFOld = Value
        End Set
    End Property 

    Private _fkID_CONTROL_QUEMA_REF As CONTROL_QUEMA
    Public Property fkID_CONTROL_QUEMA_REF() As CONTROL_QUEMA
        Get
            Return _fkID_CONTROL_QUEMA_REF
        End Get
        Set(ByVal Value As CONTROL_QUEMA)
            _fkID_CONTROL_QUEMA_REF = Value
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

    Private _ID_QUEMA_SALDO As Int32
    <Column(Name:="Id quema saldo", Storage:="ID_QUEMA_SALDO", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_QUEMA_SALDO() As Int32
        Get
            Return _ID_QUEMA_SALDO
        End Get
        Set(ByVal Value As Int32)
            _ID_QUEMA_SALDO = Value
            OnPropertyChanged("ID_QUEMA_SALDO")
        End Set
    End Property 

    Private _ID_QUEMA_SALDOOld As Int32
    Public Property ID_QUEMA_SALDOOld() As Int32
        Get
            Return _ID_QUEMA_SALDOOld
        End Get
        Set(ByVal Value As Int32)
            _ID_QUEMA_SALDOOld = Value
        End Set
    End Property 

    Private _fkID_QUEMA_SALDO As CONTROL_QUEMA_SALDO
    Public Property fkID_QUEMA_SALDO() As CONTROL_QUEMA_SALDO
        Get
            Return _fkID_QUEMA_SALDO
        End Get
        Set(ByVal Value As CONTROL_QUEMA_SALDO)
            _fkID_QUEMA_SALDO = Value
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
