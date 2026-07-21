''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.SOLIC_AGRICOLA_ESTADO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row SOLIC_AGRICOLA_ESTADO en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	19/07/2017	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="SOLIC_AGRICOLA_ESTADO")> Public Class SOLIC_AGRICOLA_ESTADO
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_SOLIC_ESTADO As Int32, aNOMBRE_ESTADO As String)
        Me._ID_SOLIC_ESTADO = aID_SOLIC_ESTADO
        Me._NOMBRE_ESTADO = aNOMBRE_ESTADO
    End Sub

#Region " Properties "

    Private _ID_SOLIC_ESTADO As Int32
    <Column(Name:="Id solic estado", Storage:="ID_SOLIC_ESTADO", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_SOLIC_ESTADO() As Int32
        Get
            Return _ID_SOLIC_ESTADO
        End Get
        Set(ByVal Value As Int32)
            _ID_SOLIC_ESTADO = Value
            OnPropertyChanged("ID_SOLIC_ESTADO")
        End Set
    End Property 

    Private _NOMBRE_ESTADO As String
    <Column(Name:="Nombre estado", Storage:="NOMBRE_ESTADO", DbType:="VARCHAR(100) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 100)> _
    Public Property NOMBRE_ESTADO() As String
        Get
            Return _NOMBRE_ESTADO
        End Get
        Set(ByVal Value As String)
            _NOMBRE_ESTADO = Value
            OnPropertyChanged("NOMBRE_ESTADO")
        End Set
    End Property 

    Private _NOMBRE_ESTADOOld As String
    Public Property NOMBRE_ESTADOOld() As String
        Get
            Return _NOMBRE_ESTADOOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_ESTADOOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
