''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.ESTADO_SOLIC
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row ESTADO_SOLIC en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	24/10/2017	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="ESTADO_SOLIC")> Public Class ESTADO_SOLIC
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_ESTADO_SOLIC As Int32, aDESCRIP_ESTADO_SOLIC As String)
        Me._ID_ESTADO_SOLIC = aID_ESTADO_SOLIC
        Me._DESCRIP_ESTADO_SOLIC = aDESCRIP_ESTADO_SOLIC
    End Sub

#Region " Properties "

    Private _ID_ESTADO_SOLIC As Int32
    <Column(Name:="Id estado solic", Storage:="ID_ESTADO_SOLIC", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_ESTADO_SOLIC() As Int32
        Get
            Return _ID_ESTADO_SOLIC
        End Get
        Set(ByVal Value As Int32)
            _ID_ESTADO_SOLIC = Value
            OnPropertyChanged("ID_ESTADO_SOLIC")
        End Set
    End Property 

    Private _DESCRIP_ESTADO_SOLIC As String
    <Column(Name:="Descrip estado solic", Storage:="DESCRIP_ESTADO_SOLIC", DbType:="VARCHAR(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
    Public Property DESCRIP_ESTADO_SOLIC() As String
        Get
            Return _DESCRIP_ESTADO_SOLIC
        End Get
        Set(ByVal Value As String)
            _DESCRIP_ESTADO_SOLIC = Value
            OnPropertyChanged("DESCRIP_ESTADO_SOLIC")
        End Set
    End Property 

    Private _DESCRIP_ESTADO_SOLICOld As String
    Public Property DESCRIP_ESTADO_SOLICOld() As String
        Get
            Return _DESCRIP_ESTADO_SOLICOld
        End Get
        Set(ByVal Value As String)
            _DESCRIP_ESTADO_SOLICOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
