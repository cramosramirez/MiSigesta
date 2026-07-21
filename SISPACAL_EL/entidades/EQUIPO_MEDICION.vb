''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.EQUIPO_MEDICION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row EQUIPO_MEDICION en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	18/09/2013	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="EQUIPO_MEDICION")> Public Class EQUIPO_MEDICION
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_EQUIPO As Int32, aNOMBRE_EQUIPO As String, aPUERTO As String, aBITS_POR_SEGUNDO As Decimal, aBITS_DATOS As Decimal, aPARIDAD As String, aBITS_PARADA As Decimal, aCONTROL_FLUJO As String, aHABILITADO As Boolean, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime)
        Me._ID_EQUIPO = aID_EQUIPO
        Me._NOMBRE_EQUIPO = aNOMBRE_EQUIPO
        Me._PUERTO = aPUERTO
        Me._BITS_POR_SEGUNDO = aBITS_POR_SEGUNDO
        Me._BITS_DATOS = aBITS_DATOS
        Me._PARIDAD = aPARIDAD
        Me._BITS_PARADA = aBITS_PARADA
        Me._CONTROL_FLUJO = aCONTROL_FLUJO
        Me._HABILITADO = aHABILITADO
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
    End Sub

#Region " Properties "

    Private _ID_EQUIPO As Int32
    <Column(Name:="Id equipo", Storage:="ID_EQUIPO", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_EQUIPO() As Int32
        Get
            Return _ID_EQUIPO
        End Get
        Set(ByVal Value As Int32)
            _ID_EQUIPO = Value
            OnPropertyChanged("ID_EQUIPO")
        End Set
    End Property 

    Private _NOMBRE_EQUIPO As String
    <Column(Name:="Nombre equipo", Storage:="NOMBRE_EQUIPO", DbType:="VARCHAR(200) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 200)> _
    Public Property NOMBRE_EQUIPO() As String
        Get
            Return _NOMBRE_EQUIPO
        End Get
        Set(ByVal Value As String)
            _NOMBRE_EQUIPO = Value
            OnPropertyChanged("NOMBRE_EQUIPO")
        End Set
    End Property 

    Private _NOMBRE_EQUIPOOld As String
    Public Property NOMBRE_EQUIPOOld() As String
        Get
            Return _NOMBRE_EQUIPOOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_EQUIPOOld = Value
        End Set
    End Property 

    Private _PUERTO As String
    <Column(Name:="Puerto", Storage:="PUERTO", DbType:="VARCHAR(20) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 20)> _
    Public Property PUERTO() As String
        Get
            Return _PUERTO
        End Get
        Set(ByVal Value As String)
            _PUERTO = Value
            OnPropertyChanged("PUERTO")
        End Set
    End Property 

    Private _PUERTOOld As String
    Public Property PUERTOOld() As String
        Get
            Return _PUERTOOld
        End Get
        Set(ByVal Value As String)
            _PUERTOOld = Value
        End Set
    End Property 

    Private _BITS_POR_SEGUNDO As Decimal
    <Column(Name:="Bits por segundo", Storage:="BITS_POR_SEGUNDO", DbType:="NUMERIC(10,0) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=0)> _
    Public Property BITS_POR_SEGUNDO() As Decimal
        Get
            Return _BITS_POR_SEGUNDO
        End Get
        Set(ByVal Value As Decimal)
            _BITS_POR_SEGUNDO = Value
            OnPropertyChanged("BITS_POR_SEGUNDO")
        End Set
    End Property 

    Private _BITS_POR_SEGUNDOOld As Decimal
    Public Property BITS_POR_SEGUNDOOld() As Decimal
        Get
            Return _BITS_POR_SEGUNDOOld
        End Get
        Set(ByVal Value As Decimal)
            _BITS_POR_SEGUNDOOld = Value
        End Set
    End Property 

    Private _BITS_DATOS As Decimal
    <Column(Name:="Bits datos", Storage:="BITS_DATOS", DbType:="NUMERIC(1,0) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=1, Scale:=0)> _
    Public Property BITS_DATOS() As Decimal
        Get
            Return _BITS_DATOS
        End Get
        Set(ByVal Value As Decimal)
            _BITS_DATOS = Value
            OnPropertyChanged("BITS_DATOS")
        End Set
    End Property 

    Private _BITS_DATOSOld As Decimal
    Public Property BITS_DATOSOld() As Decimal
        Get
            Return _BITS_DATOSOld
        End Get
        Set(ByVal Value As Decimal)
            _BITS_DATOSOld = Value
        End Set
    End Property 

    Private _PARIDAD As String
    <Column(Name:="Paridad", Storage:="PARIDAD", DbType:="VARCHAR(12) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 12)> _
    Public Property PARIDAD() As String
        Get
            Return _PARIDAD
        End Get
        Set(ByVal Value As String)
            _PARIDAD = Value
            OnPropertyChanged("PARIDAD")
        End Set
    End Property 

    Private _PARIDADOld As String
    Public Property PARIDADOld() As String
        Get
            Return _PARIDADOld
        End Get
        Set(ByVal Value As String)
            _PARIDADOld = Value
        End Set
    End Property 

    Private _BITS_PARADA As Decimal
    <Column(Name:="Bits parada", Storage:="BITS_PARADA", DbType:="NUMERIC(2,1) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=2, Scale:=1)> _
    Public Property BITS_PARADA() As Decimal
        Get
            Return _BITS_PARADA
        End Get
        Set(ByVal Value As Decimal)
            _BITS_PARADA = Value
            OnPropertyChanged("BITS_PARADA")
        End Set
    End Property 

    Private _BITS_PARADAOld As Decimal
    Public Property BITS_PARADAOld() As Decimal
        Get
            Return _BITS_PARADAOld
        End Get
        Set(ByVal Value As Decimal)
            _BITS_PARADAOld = Value
        End Set
    End Property 

    Private _CONTROL_FLUJO As String
    <Column(Name:="Control flujo", Storage:="CONTROL_FLUJO", DbType:="VARCHAR(20) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 20)> _
    Public Property CONTROL_FLUJO() As String
        Get
            Return _CONTROL_FLUJO
        End Get
        Set(ByVal Value As String)
            _CONTROL_FLUJO = Value
            OnPropertyChanged("CONTROL_FLUJO")
        End Set
    End Property 

    Private _CONTROL_FLUJOOld As String
    Public Property CONTROL_FLUJOOld() As String
        Get
            Return _CONTROL_FLUJOOld
        End Get
        Set(ByVal Value As String)
            _CONTROL_FLUJOOld = Value
        End Set
    End Property 

    Private _HABILITADO As Boolean
    <Column(Name:="Habilitado", Storage:="HABILITADO", DbType:="BIT NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 1)> _
    Public Property HABILITADO() As Boolean
        Get
            Return _HABILITADO
        End Get
        Set(ByVal Value As Boolean)
            _HABILITADO = Value
            OnPropertyChanged("HABILITADO")
        End Set
    End Property 

    Private _HABILITADOOld As Boolean
    Public Property HABILITADOOld() As Boolean
        Get
            Return _HABILITADOOld
        End Get
        Set(ByVal Value As Boolean)
            _HABILITADOOld = Value
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
