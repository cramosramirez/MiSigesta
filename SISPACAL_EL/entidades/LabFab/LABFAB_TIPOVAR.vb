''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.LABFAB_TIPOVAR
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row LABFAB_TIPOVAR en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	18/11/2015	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="LABFAB_TIPOVAR")> Public Class LABFAB_TIPOVAR
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_TIPOVAR As Int32, aCOD_TIPOVAR As String, aNOMBRE_TIPOVAR As String)
        Me._ID_TIPOVAR = aID_TIPOVAR
        Me._COD_TIPOVAR = aCOD_TIPOVAR
        Me._NOMBRE_TIPOVAR = aNOMBRE_TIPOVAR
    End Sub

#Region " Properties "

    Private _ID_TIPOVAR As Int32
    <Column(Name:="Id tipovar", Storage:="ID_TIPOVAR", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_TIPOVAR() As Int32
        Get
            Return _ID_TIPOVAR
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPOVAR = Value
            OnPropertyChanged("ID_TIPOVAR")
        End Set
    End Property 

    Private _COD_TIPOVAR As String
    <Column(Name:="Cod tipovar", Storage:="COD_TIPOVAR", DbType:="VARCHAR(5) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 5)> _
    Public Property COD_TIPOVAR() As String
        Get
            Return _COD_TIPOVAR
        End Get
        Set(ByVal Value As String)
            _COD_TIPOVAR = Value
            OnPropertyChanged("COD_TIPOVAR")
        End Set
    End Property 

    Private _COD_TIPOVAROld As String
    Public Property COD_TIPOVAROld() As String
        Get
            Return _COD_TIPOVAROld
        End Get
        Set(ByVal Value As String)
            _COD_TIPOVAROld = Value
        End Set
    End Property 

    Private _NOMBRE_TIPOVAR As String
    <Column(Name:="Nombre tipovar", Storage:="NOMBRE_TIPOVAR", DbType:="VARCHAR(100) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 100)> _
    Public Property NOMBRE_TIPOVAR() As String
        Get
            Return _NOMBRE_TIPOVAR
        End Get
        Set(ByVal Value As String)
            _NOMBRE_TIPOVAR = Value
            OnPropertyChanged("NOMBRE_TIPOVAR")
        End Set
    End Property 

    Private _NOMBRE_TIPOVAROld As String
    Public Property NOMBRE_TIPOVAROld() As String
        Get
            Return _NOMBRE_TIPOVAROld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_TIPOVAROld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
