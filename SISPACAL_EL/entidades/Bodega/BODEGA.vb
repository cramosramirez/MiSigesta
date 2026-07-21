''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.BODEGA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row BODEGA en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	03/07/2017	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="BODEGA")> Public Class BODEGA
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_BODEGA As Int32, aNOMBRE_BODEGA As String)
        Me._ID_BODEGA = aID_BODEGA
        Me._NOMBRE_BODEGA = aNOMBRE_BODEGA
    End Sub

#Region " Properties "

    Private _ID_BODEGA As Int32
    <Column(Name:="Id bodega", Storage:="ID_BODEGA", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_BODEGA() As Int32
        Get
            Return _ID_BODEGA
        End Get
        Set(ByVal Value As Int32)
            _ID_BODEGA = Value
            OnPropertyChanged("ID_BODEGA")
        End Set
    End Property 

    Private _NOMBRE_BODEGA As String
    <Column(Name:="Nombre bodega", Storage:="NOMBRE_BODEGA", DbType:="VARCHAR(200) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 200)> _
    Public Property NOMBRE_BODEGA() As String
        Get
            Return _NOMBRE_BODEGA
        End Get
        Set(ByVal Value As String)
            _NOMBRE_BODEGA = Value
            OnPropertyChanged("NOMBRE_BODEGA")
        End Set
    End Property 

    Private _NOMBRE_BODEGAOld As String
    Public Property NOMBRE_BODEGAOld() As String
        Get
            Return _NOMBRE_BODEGAOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_BODEGAOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
