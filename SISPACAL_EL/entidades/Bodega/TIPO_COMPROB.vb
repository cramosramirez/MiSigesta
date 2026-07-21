''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.TIPO_COMPROB
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row TIPO_COMPROB en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	30/08/2017	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="TIPO_COMPROB")> Public Class TIPO_COMPROB
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_TIPO_COMPROB As Int32, aCODIGO_TIPO As String, aNOMBRE_TIPO As String, aVER_REGISTRO As Boolean)
        Me._ID_TIPO_COMPROB = aID_TIPO_COMPROB
        Me._CODIGO_TIPO = aCODIGO_TIPO
        Me._NOMBRE_TIPO = aNOMBRE_TIPO
        Me._VER_REGISTRO = aVER_REGISTRO
    End Sub

#Region " Properties "

    Private _ID_TIPO_COMPROB As Int32
    <Column(Name:="Id tipo comprob", Storage:="ID_TIPO_COMPROB", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_TIPO_COMPROB() As Int32
        Get
            Return _ID_TIPO_COMPROB
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_COMPROB = Value
            OnPropertyChanged("ID_TIPO_COMPROB")
        End Set
    End Property 

    Private _CODIGO_TIPO As String
    <Column(Name:="Codigo tipo", Storage:="CODIGO_TIPO", DbType:="VARCHAR(10) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 10)> _
    Public Property CODIGO_TIPO() As String
        Get
            Return _CODIGO_TIPO
        End Get
        Set(ByVal Value As String)
            _CODIGO_TIPO = Value
            OnPropertyChanged("CODIGO_TIPO")
        End Set
    End Property 

    Private _CODIGO_TIPOOld As String
    Public Property CODIGO_TIPOOld() As String
        Get
            Return _CODIGO_TIPOOld
        End Get
        Set(ByVal Value As String)
            _CODIGO_TIPOOld = Value
        End Set
    End Property 

    Private _NOMBRE_TIPO As String
    <Column(Name:="Nombre tipo", Storage:="NOMBRE_TIPO", DbType:="VARCHAR(100) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 100)> _
    Public Property NOMBRE_TIPO() As String
        Get
            Return _NOMBRE_TIPO
        End Get
        Set(ByVal Value As String)
            _NOMBRE_TIPO = Value
            OnPropertyChanged("NOMBRE_TIPO")
        End Set
    End Property 

    Private _NOMBRE_TIPOOld As String
    Public Property NOMBRE_TIPOOld() As String
        Get
            Return _NOMBRE_TIPOOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_TIPOOld = Value
        End Set
    End Property 

    Private _VER_REGISTRO As Boolean
    <Column(Name:="Ver registro", Storage:="VER_REGISTRO", DbType:="BIT", Id:=False), _
     DataObjectField(False, False, True, 1)> _
    Public Property VER_REGISTRO() As Boolean
        Get
            Return _VER_REGISTRO
        End Get
        Set(ByVal Value As Boolean)
            _VER_REGISTRO = Value
            OnPropertyChanged("VER_REGISTRO")
        End Set
    End Property 

    Private _VER_REGISTROOld As Boolean
    Public Property VER_REGISTROOld() As Boolean
        Get
            Return _VER_REGISTROOld
        End Get
        Set(ByVal Value As Boolean)
            _VER_REGISTROOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
