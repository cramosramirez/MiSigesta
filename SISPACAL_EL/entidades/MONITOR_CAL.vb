''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.MONITOR_CAL
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row MONITOR_CAL en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	28/11/2022	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="MONITOR_CAL")> Public Class MONITOR_CAL
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_MONITOR As Int32, aNOMBRES As String, aDUI As String, aDIRECCION As String, aCODIEMP As String, aCODISIS As String)
        Me._ID_MONITOR = aID_MONITOR
        Me._NOMBRES = aNOMBRES
        Me._DUI = aDUI
        Me._DIRECCION = aDIRECCION
        Me._CODIEMP = aCODIEMP
        Me._CODISIS = aCODISIS
    End Sub

#Region " Properties "

    Private _ID_MONITOR As Int32
    <Column(Name:="Id monitor", Storage:="ID_MONITOR", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_MONITOR() As Int32
        Get
            Return _ID_MONITOR
        End Get
        Set(ByVal Value As Int32)
            _ID_MONITOR = Value
            OnPropertyChanged("ID_MONITOR")
        End Set
    End Property 

    Private _NOMBRES As String
    <Column(Name:="Nombres", Storage:="NOMBRES", DbType:="VARCHAR(200)", Id:=False), _
     DataObjectField(False, False, True, 200)> _
    Public Property NOMBRES() As String
        Get
            Return _NOMBRES
        End Get
        Set(ByVal Value As String)
            _NOMBRES = Value
            OnPropertyChanged("NOMBRES")
        End Set
    End Property 

    Private _NOMBRESOld As String
    Public Property NOMBRESOld() As String
        Get
            Return _NOMBRESOld
        End Get
        Set(ByVal Value As String)
            _NOMBRESOld = Value
        End Set
    End Property 

    Private _DUI As String
    <Column(Name:="Dui", Storage:="DUI", DbType:="VARCHAR(20)", Id:=False), _
     DataObjectField(False, False, True, 20)> _
    Public Property DUI() As String
        Get
            Return _DUI
        End Get
        Set(ByVal Value As String)
            _DUI = Value
            OnPropertyChanged("DUI")
        End Set
    End Property 

    Private _DUIOld As String
    Public Property DUIOld() As String
        Get
            Return _DUIOld
        End Get
        Set(ByVal Value As String)
            _DUIOld = Value
        End Set
    End Property 

    Private _DIRECCION As String
    <Column(Name:="Direccion", Storage:="DIRECCION", DbType:="VARCHAR(250)", Id:=False), _
     DataObjectField(False, False, True, 250)> _
    Public Property DIRECCION() As String
        Get
            Return _DIRECCION
        End Get
        Set(ByVal Value As String)
            _DIRECCION = Value
            OnPropertyChanged("DIRECCION")
        End Set
    End Property 

    Private _DIRECCIONOld As String
    Public Property DIRECCIONOld() As String
        Get
            Return _DIRECCIONOld
        End Get
        Set(ByVal Value As String)
            _DIRECCIONOld = Value
        End Set
    End Property 

    Private _CODIEMP As String
    <Column(Name:="Codiemp", Storage:="CODIEMP", DbType:="VARCHAR(20)", Id:=False), _
     DataObjectField(False, False, True, 20)> _
    Public Property CODIEMP() As String
        Get
            Return _CODIEMP
        End Get
        Set(ByVal Value As String)
            _CODIEMP = Value
            OnPropertyChanged("CODIEMP")
        End Set
    End Property 

    Private _CODIEMPOld As String
    Public Property CODIEMPOld() As String
        Get
            Return _CODIEMPOld
        End Get
        Set(ByVal Value As String)
            _CODIEMPOld = Value
        End Set
    End Property 

    Private _CODISIS As String
    <Column(Name:="Codisis", Storage:="CODISIS", DbType:="VARCHAR(20)", Id:=False), _
     DataObjectField(False, False, True, 20)> _
    Public Property CODISIS() As String
        Get
            Return _CODISIS
        End Get
        Set(ByVal Value As String)
            _CODISIS = Value
            OnPropertyChanged("CODISIS")
        End Set
    End Property 

    Private _CODISISOld As String
    Public Property CODISISOld() As String
        Get
            Return _CODISISOld
        End Get
        Set(ByVal Value As String)
            _CODISISOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
