''' -----------------------------------------------------------------------------
''' Project	 : SADPRO_EL
''' Class	 : EL.Intermedia
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row Intermedia en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	29/11/2016	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="Intermedia")> Public Class Intermedia
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aEnvio As Int32, aVehiculo As String, aHacienda As String, aFin_Envio As Int32, aId_Maestro As Int32)
        Me._Envio = aEnvio
        Me._Vehiculo = aVehiculo
        Me._Hacienda = aHacienda
        Me._Fin_Envio = aFin_Envio
        Me._Id_Maestro = aId_Maestro
    End Sub

#Region " Properties "

    Private _Envio As Int32
    <Column(Name:="Envio", Storage:="Envio", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property Envio() As Int32
        Get
            Return _Envio
        End Get
        Set(ByVal Value As Int32)
            _Envio = Value
            OnPropertyChanged("Envio")
        End Set
    End Property 

    Private _Vehiculo As String
    <Column(Name:="Vehiculo", Storage:="Vehiculo", DbType:="VARCHAR(50) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 50)> _
    Public Property Vehiculo() As String
        Get
            Return _Vehiculo
        End Get
        Set(ByVal Value As String)
            _Vehiculo = Value
            OnPropertyChanged("Vehiculo")
        End Set
    End Property 

    Private _VehiculoOld As String
    Public Property VehiculoOld() As String
        Get
            Return _VehiculoOld
        End Get
        Set(ByVal Value As String)
            _VehiculoOld = Value
        End Set
    End Property 

    Private _Hacienda As String
    <Column(Name:="Hacienda", Storage:="Hacienda", DbType:="VARCHAR(50)", Id:=False), _
     DataObjectField(False, False, True, 50)> _
    Public Property Hacienda() As String
        Get
            Return _Hacienda
        End Get
        Set(ByVal Value As String)
            _Hacienda = Value
            OnPropertyChanged("Hacienda")
        End Set
    End Property 

    Private _HaciendaOld As String
    Public Property HaciendaOld() As String
        Get
            Return _HaciendaOld
        End Get
        Set(ByVal Value As String)
            _HaciendaOld = Value
        End Set
    End Property 

    Private _Fin_Envio As Int32
    <Column(Name:="Fin  envio", Storage:="Fin_Envio", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property Fin_Envio() As Int32
        Get
            Return _Fin_Envio
        End Get
        Set(ByVal Value As Int32)
            _Fin_Envio = Value
            OnPropertyChanged("Fin_Envio")
        End Set
    End Property 

    Private _Fin_EnvioOld As Int32
    Public Property Fin_EnvioOld() As Int32
        Get
            Return _Fin_EnvioOld
        End Get
        Set(ByVal Value As Int32)
            _Fin_EnvioOld = Value
        End Set
    End Property

    Private _Id_Maestro As Int32
    <Column(Name:="Id Maestro", Storage:="Id_Maestro", DBType:="INT", Id:=False),
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)>
    Public Property Id_Maestro() As Int32
        Get
            Return _Id_Maestro
        End Get
        Set(ByVal Value As Int32)
            _Id_Maestro = Value
            OnPropertyChanged("Id_Maestro")
        End Set
    End Property

    Private _Id_MaestroOld As Int32
    Public Property Id_MaestroOld() As Int32
        Get
            Return _Id_MaestroOld
        End Get
        Set(ByVal Value As Int32)
            _Id_MaestroOld = Value
        End Set
    End Property

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
