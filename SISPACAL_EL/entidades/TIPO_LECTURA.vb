''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.TIPO_LECTURA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row TIPO_LECTURA en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	18/09/2013	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="TIPO_LECTURA")> Public Class TIPO_LECTURA
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_TIPO_LECTURA As Int32, aNOMBRE_TIPO_LECTURA As String, aID_EQUIPO As Int32, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime)
        Me._ID_TIPO_LECTURA = aID_TIPO_LECTURA
        Me._NOMBRE_TIPO_LECTURA = aNOMBRE_TIPO_LECTURA
        Me._ID_EQUIPO = aID_EQUIPO
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
    End Sub

#Region " Properties "

    Private _ID_TIPO_LECTURA As Int32
    <Column(Name:="Id tipo lectura", Storage:="ID_TIPO_LECTURA", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_TIPO_LECTURA() As Int32
        Get
            Return _ID_TIPO_LECTURA
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_LECTURA = Value
            OnPropertyChanged("ID_TIPO_LECTURA")
        End Set
    End Property 

    Private _NOMBRE_TIPO_LECTURA As String
    <Column(Name:="Nombre tipo lectura", Storage:="NOMBRE_TIPO_LECTURA", DbType:="VARCHAR(50) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 50)> _
    Public Property NOMBRE_TIPO_LECTURA() As String
        Get
            Return _NOMBRE_TIPO_LECTURA
        End Get
        Set(ByVal Value As String)
            _NOMBRE_TIPO_LECTURA = Value
            OnPropertyChanged("NOMBRE_TIPO_LECTURA")
        End Set
    End Property 

    Private _NOMBRE_TIPO_LECTURAOld As String
    Public Property NOMBRE_TIPO_LECTURAOld() As String
        Get
            Return _NOMBRE_TIPO_LECTURAOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_TIPO_LECTURAOld = Value
        End Set
    End Property 

    Private _ID_EQUIPO As Int32
    <Column(Name:="Id equipo", Storage:="ID_EQUIPO", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_EQUIPO() As Int32
        Get
            Return _ID_EQUIPO
        End Get
        Set(ByVal Value As Int32)
            _ID_EQUIPO = Value
            OnPropertyChanged("ID_EQUIPO")
        End Set
    End Property 

    Private _ID_EQUIPOOld As Int32
    Public Property ID_EQUIPOOld() As Int32
        Get
            Return _ID_EQUIPOOld
        End Get
        Set(ByVal Value As Int32)
            _ID_EQUIPOOld = Value
        End Set
    End Property 

    Private _fkID_EQUIPO As EQUIPO_MEDICION
    Public Property fkID_EQUIPO() As EQUIPO_MEDICION
        Get
            Return _fkID_EQUIPO
        End Get
        Set(ByVal Value As EQUIPO_MEDICION)
            _fkID_EQUIPO = Value
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
