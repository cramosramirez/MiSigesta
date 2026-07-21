''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.UNIDAD_ORG
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row UNIDAD_ORG en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	03/07/2017	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="UNIDAD_ORG")> Public Class UNIDAD_ORG
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_UNIDAD_ORG As Int32, aNOMBRE_UNIDAD_ORG As String)
        Me._ID_UNIDAD_ORG = aID_UNIDAD_ORG
        Me._NOMBRE_UNIDAD_ORG = aNOMBRE_UNIDAD_ORG
    End Sub

#Region " Properties "

    Private _ID_UNIDAD_ORG As Int32
    <Column(Name:="Id unidad org", Storage:="ID_UNIDAD_ORG", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_UNIDAD_ORG() As Int32
        Get
            Return _ID_UNIDAD_ORG
        End Get
        Set(ByVal Value As Int32)
            _ID_UNIDAD_ORG = Value
            OnPropertyChanged("ID_UNIDAD_ORG")
        End Set
    End Property 

    Private _NOMBRE_UNIDAD_ORG As String
    <Column(Name:="Nombre unidad org", Storage:="NOMBRE_UNIDAD_ORG", DbType:="VARCHAR(200) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 200)> _
    Public Property NOMBRE_UNIDAD_ORG() As String
        Get
            Return _NOMBRE_UNIDAD_ORG
        End Get
        Set(ByVal Value As String)
            _NOMBRE_UNIDAD_ORG = Value
            OnPropertyChanged("NOMBRE_UNIDAD_ORG")
        End Set
    End Property 

    Private _NOMBRE_UNIDAD_ORGOld As String
    Public Property NOMBRE_UNIDAD_ORGOld() As String
        Get
            Return _NOMBRE_UNIDAD_ORGOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_UNIDAD_ORGOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
