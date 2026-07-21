''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.BITACORA_USUARIO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row BITACORA_USUARIO en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	31/08/2013	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="BITACORA_USUARIO")> Public Class BITACORA_USUARIO
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_BITACORA As Int32, aUSUARIO As String, aFECHA_ENTRADA As DateTime, aFECHA_SALIDA As DateTime)
        Me._ID_BITACORA = aID_BITACORA
        Me._USUARIO = aUSUARIO
        Me._FECHA_ENTRADA = aFECHA_ENTRADA
        Me._FECHA_SALIDA = aFECHA_SALIDA
    End Sub

#Region " Properties "

    Private _ID_BITACORA As Int32
    <Column(Name:="Id bitacora", Storage:="ID_BITACORA", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_BITACORA() As Int32
        Get
            Return _ID_BITACORA
        End Get
        Set(ByVal Value As Int32)
            _ID_BITACORA = Value
            OnPropertyChanged("ID_BITACORA")
        End Set
    End Property 

    Private _USUARIO As String
    <Column(Name:="Usuario", Storage:="USUARIO", DbType:="VARCHAR(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
    Public Property USUARIO() As String
        Get
            Return _USUARIO
        End Get
        Set(ByVal Value As String)
            _USUARIO = Value
            OnPropertyChanged("USUARIO")
        End Set
    End Property 

    Private _USUARIOOld As String
    Public Property USUARIOOld() As String
        Get
            Return _USUARIOOld
        End Get
        Set(ByVal Value As String)
            _USUARIOOld = Value
        End Set
    End Property 

    Private _fkUSUARIO As USUARIO
    Public Property fkUSUARIO() As USUARIO
        Get
            Return _fkUSUARIO
        End Get
        Set(ByVal Value As USUARIO)
            _fkUSUARIO = Value
        End Set
    End Property 

    Private _FECHA_ENTRADA As DateTime
    <Column(Name:="Fecha entrada", Storage:="FECHA_ENTRADA", DbType:="DATETIME NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
    Public Property FECHA_ENTRADA() As DateTime
        Get
            Return _FECHA_ENTRADA
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_ENTRADA = Value
            OnPropertyChanged("FECHA_ENTRADA")
        End Set
    End Property 

    Private _FECHA_ENTRADAOld As DateTime
    Public Property FECHA_ENTRADAOld() As DateTime
        Get
            Return _FECHA_ENTRADAOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_ENTRADAOld = Value
        End Set
    End Property 

    Private _FECHA_SALIDA As DateTime
    <Column(Name:="Fecha salida", Storage:="FECHA_SALIDA", DbType:="DATETIME NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
    Public Property FECHA_SALIDA() As DateTime
        Get
            Return _FECHA_SALIDA
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_SALIDA = Value
            OnPropertyChanged("FECHA_SALIDA")
        End Set
    End Property 

    Private _FECHA_SALIDAOld As DateTime
    Public Property FECHA_SALIDAOld() As DateTime
        Get
            Return _FECHA_SALIDAOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_SALIDAOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
