''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.REQETAPA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row REQETAPA en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	10/06/2015	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="REQETAPA")> Public Class REQETAPA
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_REQETAPA As Int32, aNOM_REQETAPA As String)
        Me._ID_REQETAPA = aID_REQETAPA
        Me._NOM_REQETAPA = aNOM_REQETAPA
    End Sub

#Region " Properties "

    Private _ID_REQETAPA As Int32
    <Column(Name:="Id reqetapa", Storage:="ID_REQETAPA", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_REQETAPA() As Int32
        Get
            Return _ID_REQETAPA
        End Get
        Set(ByVal Value As Int32)
            _ID_REQETAPA = Value
            OnPropertyChanged("ID_REQETAPA")
        End Set
    End Property 

    Private _NOM_REQETAPA As String
    <Column(Name:="Nom reqetapa", Storage:="NOM_REQETAPA", DbType:="VARCHAR(200)", Id:=False), _
     DataObjectField(False, False, True, 200)> _
    Public Property NOM_REQETAPA() As String
        Get
            Return _NOM_REQETAPA
        End Get
        Set(ByVal Value As String)
            _NOM_REQETAPA = Value
            OnPropertyChanged("NOM_REQETAPA")
        End Set
    End Property 

    Private _NOM_REQETAPAOld As String
    Public Property NOM_REQETAPAOld() As String
        Get
            Return _NOM_REQETAPAOld
        End Get
        Set(ByVal Value As String)
            _NOM_REQETAPAOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
