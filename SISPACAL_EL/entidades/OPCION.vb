''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.OPCION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row OPCION en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	31/08/2013	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="OPCION")> Public Class OPCION
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_OPCION As Int32, aNOMBRE_OPCION As String, aORDEN As Int32, aURL As String, aACTIVO As Boolean, aID_OPCION_PADRE As Int32, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime)
        Me._ID_OPCION = aID_OPCION
        Me._NOMBRE_OPCION = aNOMBRE_OPCION
        Me._ORDEN = aORDEN
        Me._URL = aURL
        Me._ACTIVO = aACTIVO
        Me._ID_OPCION_PADRE = aID_OPCION_PADRE
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
    End Sub

#Region " Properties "

    Private _ID_OPCION As Int32
    <Column(Name:="Id opcion", Storage:="ID_OPCION", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_OPCION() As Int32
        Get
            Return _ID_OPCION
        End Get
        Set(ByVal Value As Int32)
            _ID_OPCION = Value
            OnPropertyChanged("ID_OPCION")
        End Set
    End Property 

    Private _NOMBRE_OPCION As String
    <Column(Name:="Nombre opcion", Storage:="NOMBRE_OPCION", DbType:="VARCHAR(200) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 200)> _
    Public Property NOMBRE_OPCION() As String
        Get
            Return _NOMBRE_OPCION
        End Get
        Set(ByVal Value As String)
            _NOMBRE_OPCION = Value
            OnPropertyChanged("NOMBRE_OPCION")
        End Set
    End Property 

    Private _NOMBRE_OPCIONOld As String
    Public Property NOMBRE_OPCIONOld() As String
        Get
            Return _NOMBRE_OPCIONOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_OPCIONOld = Value
        End Set
    End Property 

    Private _ORDEN As Int32
    <Column(Name:="Orden", Storage:="ORDEN", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ORDEN() As Int32
        Get
            Return _ORDEN
        End Get
        Set(ByVal Value As Int32)
            _ORDEN = Value
            OnPropertyChanged("ORDEN")
        End Set
    End Property 

    Private _ORDENOld As Int32
    Public Property ORDENOld() As Int32
        Get
            Return _ORDENOld
        End Get
        Set(ByVal Value As Int32)
            _ORDENOld = Value
        End Set
    End Property 

    Private _URL As String
    <Column(Name:="Url", Storage:="URL", DbType:="VARCHAR(300)", Id:=False), _
     DataObjectField(False, False, True, 300)> _
    Public Property URL() As String
        Get
            Return _URL
        End Get
        Set(ByVal Value As String)
            _URL = Value
            OnPropertyChanged("URL")
        End Set
    End Property 

    Private _URLOld As String
    Public Property URLOld() As String
        Get
            Return _URLOld
        End Get
        Set(ByVal Value As String)
            _URLOld = Value
        End Set
    End Property 

    Private _ACTIVO As Boolean
    <Column(Name:="Activo", Storage:="ACTIVO", DbType:="BIT NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 1)> _
    Public Property ACTIVO() As Boolean
        Get
            Return _ACTIVO
        End Get
        Set(ByVal Value As Boolean)
            _ACTIVO = Value
            OnPropertyChanged("ACTIVO")
        End Set
    End Property 

    Private _ACTIVOOld As Boolean
    Public Property ACTIVOOld() As Boolean
        Get
            Return _ACTIVOOld
        End Get
        Set(ByVal Value As Boolean)
            _ACTIVOOld = Value
        End Set
    End Property 

    Private _ID_OPCION_PADRE As Int32
    <Column(Name:="Id opcion padre", Storage:="ID_OPCION_PADRE", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_OPCION_PADRE() As Int32
        Get
            Return _ID_OPCION_PADRE
        End Get
        Set(ByVal Value As Int32)
            _ID_OPCION_PADRE = Value
            OnPropertyChanged("ID_OPCION_PADRE")
        End Set
    End Property 

    Private _ID_OPCION_PADREOld As Int32
    Public Property ID_OPCION_PADREOld() As Int32
        Get
            Return _ID_OPCION_PADREOld
        End Get
        Set(ByVal Value As Int32)
            _ID_OPCION_PADREOld = Value
        End Set
    End Property 

    Private _fkID_OPCION_PADRE As OPCION
    Public Property fkID_OPCION_PADRE() As OPCION
        Get
            Return _fkID_OPCION_PADRE
        End Get
        Set(ByVal Value As OPCION)
            _fkID_OPCION_PADRE = Value
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
