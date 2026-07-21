''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.SOLICITANTE
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row SOLICITANTE en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	08/05/2015	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="SOLICITANTE")> Public Class SOLICITANTE
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_SOLICITANTE As Int32, aCODIGO As String, aNOMBRE_SOLICITANTE As String)
        Me._ID_SOLICITANTE = aID_SOLICITANTE
        Me._CODIGO = aCODIGO
        Me._NOMBRE_SOLICITANTE = aNOMBRE_SOLICITANTE
    End Sub

#Region " Properties "

    Private _ID_SOLICITANTE As Int32
    <Column(Name:="Id solicitante", Storage:="ID_SOLICITANTE", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_SOLICITANTE() As Int32
        Get
            Return _ID_SOLICITANTE
        End Get
        Set(ByVal Value As Int32)
            _ID_SOLICITANTE = Value
            OnPropertyChanged("ID_SOLICITANTE")
        End Set
    End Property 

    Private _CODIGO As String
    <Column(Name:="Codigo", Storage:="CODIGO", DbType:="VARCHAR(2)", Id:=False), _
     DataObjectField(False, False, True, 2)> _
    Public Property CODIGO() As String
        Get
            Return _CODIGO
        End Get
        Set(ByVal Value As String)
            _CODIGO = Value
            OnPropertyChanged("CODIGO")
        End Set
    End Property 

    Private _CODIGOOld As String
    Public Property CODIGOOld() As String
        Get
            Return _CODIGOOld
        End Get
        Set(ByVal Value As String)
            _CODIGOOld = Value
        End Set
    End Property 

    Private _NOMBRE_SOLICITANTE As String
    <Column(Name:="Nombre solicitante", Storage:="NOMBRE_SOLICITANTE", DbType:="VARCHAR(255) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 255)> _
    Public Property NOMBRE_SOLICITANTE() As String
        Get
            Return _NOMBRE_SOLICITANTE
        End Get
        Set(ByVal Value As String)
            _NOMBRE_SOLICITANTE = Value
            OnPropertyChanged("NOMBRE_SOLICITANTE")
        End Set
    End Property 

    Private _NOMBRE_SOLICITANTEOld As String
    Public Property NOMBRE_SOLICITANTEOld() As String
        Get
            Return _NOMBRE_SOLICITANTEOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_SOLICITANTEOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
