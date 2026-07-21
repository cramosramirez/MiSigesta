''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.LABFAB_CATEGORIA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row LABFAB_CATEGORIA en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	24/11/2015	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="LABFAB_CATEGORIA")> Public Class LABFAB_CATEGORIA
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_CATEG As Int32, aNOM_CATEG As String)
        Me._ID_CATEG = aID_CATEG
        Me._NOM_CATEG = aNOM_CATEG
    End Sub

#Region " Properties "

    Private _ID_CATEG As Int32
    <Column(Name:="Id categ", Storage:="ID_CATEG", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_CATEG() As Int32
        Get
            Return _ID_CATEG
        End Get
        Set(ByVal Value As Int32)
            _ID_CATEG = Value
            OnPropertyChanged("ID_CATEG")
        End Set
    End Property 

    Private _NOM_CATEG As String
    <Column(Name:="Nom categ", Storage:="NOM_CATEG", DbType:="VARCHAR(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
    Public Property NOM_CATEG() As String
        Get
            Return _NOM_CATEG
        End Get
        Set(ByVal Value As String)
            _NOM_CATEG = Value
            OnPropertyChanged("NOM_CATEG")
        End Set
    End Property 

    Private _NOM_CATEGOld As String
    Public Property NOM_CATEGOld() As String
        Get
            Return _NOM_CATEGOld
        End Get
        Set(ByVal Value As String)
            _NOM_CATEGOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
