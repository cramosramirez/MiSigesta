''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.LABFAB_INFORME
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row LABFAB_INFORME en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	28/11/2015	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="LABFAB_INFORME")> Public Class LABFAB_INFORME
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_INFO As Int32, aNOMBRE_INFO As String)
        Me._ID_INFO = aID_INFO
        Me._NOMBRE_INFO = aNOMBRE_INFO
    End Sub

#Region " Properties "

    Private _ID_INFO As Int32
    <Column(Name:="Id info", Storage:="ID_INFO", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_INFO() As Int32
        Get
            Return _ID_INFO
        End Get
        Set(ByVal Value As Int32)
            _ID_INFO = Value
            OnPropertyChanged("ID_INFO")
        End Set
    End Property 

    Private _NOMBRE_INFO As String
    <Column(Name:="Nombre info", Storage:="NOMBRE_INFO", DbType:="VARCHAR(100) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 100)> _
    Public Property NOMBRE_INFO() As String
        Get
            Return _NOMBRE_INFO
        End Get
        Set(ByVal Value As String)
            _NOMBRE_INFO = Value
            OnPropertyChanged("NOMBRE_INFO")
        End Set
    End Property 

    Private _NOMBRE_INFOOld As String
    Public Property NOMBRE_INFOOld() As String
        Get
            Return _NOMBRE_INFOOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_INFOOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
