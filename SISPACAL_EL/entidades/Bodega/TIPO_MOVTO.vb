''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.TIPO_MOVTO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row TIPO_MOVTO en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	03/07/2017	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="TIPO_MOVTO")> Public Class TIPO_MOVTO
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_TIPO_MOVTO As Int32, aNOMBRE_TIPO_MOVTO As String, aES_ENTRADA As Boolean, aES_SALIDA As Boolean)
        Me._ID_TIPO_MOVTO = aID_TIPO_MOVTO
        Me._NOMBRE_TIPO_MOVTO = aNOMBRE_TIPO_MOVTO
        Me._ES_ENTRADA = aES_ENTRADA
        Me._ES_SALIDA = aES_SALIDA
    End Sub

#Region " Properties "

    Private _ID_TIPO_MOVTO As Int32
    <Column(Name:="Id tipo movto", Storage:="ID_TIPO_MOVTO", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_TIPO_MOVTO() As Int32
        Get
            Return _ID_TIPO_MOVTO
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_MOVTO = Value
            OnPropertyChanged("ID_TIPO_MOVTO")
        End Set
    End Property 

    Private _NOMBRE_TIPO_MOVTO As String
    <Column(Name:="Nombre tipo movto", Storage:="NOMBRE_TIPO_MOVTO", DbType:="VARCHAR(100) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 100)> _
    Public Property NOMBRE_TIPO_MOVTO() As String
        Get
            Return _NOMBRE_TIPO_MOVTO
        End Get
        Set(ByVal Value As String)
            _NOMBRE_TIPO_MOVTO = Value
            OnPropertyChanged("NOMBRE_TIPO_MOVTO")
        End Set
    End Property 

    Private _NOMBRE_TIPO_MOVTOOld As String
    Public Property NOMBRE_TIPO_MOVTOOld() As String
        Get
            Return _NOMBRE_TIPO_MOVTOOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_TIPO_MOVTOOld = Value
        End Set
    End Property 

    Private _ES_ENTRADA As Boolean
    <Column(Name:="Es entrada", Storage:="ES_ENTRADA", DbType:="BIT NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 1)> _
    Public Property ES_ENTRADA() As Boolean
        Get
            Return _ES_ENTRADA
        End Get
        Set(ByVal Value As Boolean)
            _ES_ENTRADA = Value
            OnPropertyChanged("ES_ENTRADA")
        End Set
    End Property 

    Private _ES_ENTRADAOld As Boolean
    Public Property ES_ENTRADAOld() As Boolean
        Get
            Return _ES_ENTRADAOld
        End Get
        Set(ByVal Value As Boolean)
            _ES_ENTRADAOld = Value
        End Set
    End Property 

    Private _ES_SALIDA As Boolean
    <Column(Name:="Es salida", Storage:="ES_SALIDA", DbType:="BIT NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 1)> _
    Public Property ES_SALIDA() As Boolean
        Get
            Return _ES_SALIDA
        End Get
        Set(ByVal Value As Boolean)
            _ES_SALIDA = Value
            OnPropertyChanged("ES_SALIDA")
        End Set
    End Property 

    Private _ES_SALIDAOld As Boolean
    Public Property ES_SALIDAOld() As Boolean
        Get
            Return _ES_SALIDAOld
        End Get
        Set(ByVal Value As Boolean)
            _ES_SALIDAOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
