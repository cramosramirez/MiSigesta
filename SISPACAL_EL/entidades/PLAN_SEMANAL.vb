''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.PLAN_SEMANAL
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row PLAN_SEMANAL en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	21/10/2013	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="PLAN_SEMANAL")> Public Class PLAN_SEMANAL
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_PLAN_SEMANAL As Int32, aID_PLAN_CATORCENA As Int32, aNO_SEMANA As Int32, aFECHA_INICIO As DateTime, aFECHA_FIN As DateTime, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime)
        Me._ID_PLAN_SEMANAL = aID_PLAN_SEMANAL
        Me._ID_PLAN_CATORCENA = aID_PLAN_CATORCENA
        Me._NO_SEMANA = aNO_SEMANA
        Me._FECHA_INICIO = aFECHA_INICIO
        Me._FECHA_FIN = aFECHA_FIN
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
    End Sub

#Region " Properties "

    Private _ID_PLAN_SEMANAL As Int32
    <Column(Name:="Id plan semanal", Storage:="ID_PLAN_SEMANAL", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_PLAN_SEMANAL() As Int32
        Get
            Return _ID_PLAN_SEMANAL
        End Get
        Set(ByVal Value As Int32)
            _ID_PLAN_SEMANAL = Value
            OnPropertyChanged("ID_PLAN_SEMANAL")
        End Set
    End Property 

    Private _ID_PLAN_CATORCENA As Int32
    <Column(Name:="Id plan catorcena", Storage:="ID_PLAN_CATORCENA", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_PLAN_CATORCENA() As Int32
        Get
            Return _ID_PLAN_CATORCENA
        End Get
        Set(ByVal Value As Int32)
            _ID_PLAN_CATORCENA = Value
            OnPropertyChanged("ID_PLAN_CATORCENA")
        End Set
    End Property 

    Private _ID_PLAN_CATORCENAOld As Int32
    Public Property ID_PLAN_CATORCENAOld() As Int32
        Get
            Return _ID_PLAN_CATORCENAOld
        End Get
        Set(ByVal Value As Int32)
            _ID_PLAN_CATORCENAOld = Value
        End Set
    End Property 

    Private _fkID_PLAN_CATORCENA As PLAN_CATORCENA
    Public Property fkID_PLAN_CATORCENA() As PLAN_CATORCENA
        Get
            Return _fkID_PLAN_CATORCENA
        End Get
        Set(ByVal Value As PLAN_CATORCENA)
            _fkID_PLAN_CATORCENA = Value
        End Set
    End Property 

    Private _NO_SEMANA As Int32
    <Column(Name:="No semana", Storage:="NO_SEMANA", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property NO_SEMANA() As Int32
        Get
            Return _NO_SEMANA
        End Get
        Set(ByVal Value As Int32)
            _NO_SEMANA = Value
            OnPropertyChanged("NO_SEMANA")
        End Set
    End Property 

    Private _NO_SEMANAOld As Int32
    Public Property NO_SEMANAOld() As Int32
        Get
            Return _NO_SEMANAOld
        End Get
        Set(ByVal Value As Int32)
            _NO_SEMANAOld = Value
        End Set
    End Property 

    Private _FECHA_INICIO As DateTime
    <Column(Name:="Fecha inicio", Storage:="FECHA_INICIO", DbType:="DATETIME NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
    Public Property FECHA_INICIO() As DateTime
        Get
            Return _FECHA_INICIO
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_INICIO = Value
            OnPropertyChanged("FECHA_INICIO")
        End Set
    End Property 

    Private _FECHA_INICIOOld As DateTime
    Public Property FECHA_INICIOOld() As DateTime
        Get
            Return _FECHA_INICIOOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_INICIOOld = Value
        End Set
    End Property 

    Private _FECHA_FIN As DateTime
    <Column(Name:="Fecha fin", Storage:="FECHA_FIN", DbType:="DATETIME NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
    Public Property FECHA_FIN() As DateTime
        Get
            Return _FECHA_FIN
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_FIN = Value
            OnPropertyChanged("FECHA_FIN")
        End Set
    End Property 

    Private _FECHA_FINOld As DateTime
    Public Property FECHA_FINOld() As DateTime
        Get
            Return _FECHA_FINOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_FINOld = Value
        End Set
    End Property 

    Private _USUARIO_CREA As String
    <Column(Name:="Usuario crea", Storage:="USUARIO_CREA", DbType:="VARCHAR(100) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 100)> _
    Public Property USUARIO_CREA() As String
        Get
            Return _USUARIO_CREA
        End Get
        Set(ByVal Value As String)
            _USUARIO_CREA = Value
            OnPropertyChanged("USUARIO_CREA")
        End Set
    End Property 

    Private _USUARIO_CREAOld As String
    Public Property USUARIO_CREAOld() As String
        Get
            Return _USUARIO_CREAOld
        End Get
        Set(ByVal Value As String)
            _USUARIO_CREAOld = Value
        End Set
    End Property 

    Private _FECHA_CREA As DateTime
    <Column(Name:="Fecha crea", Storage:="FECHA_CREA", DbType:="DATETIME NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
    Public Property FECHA_CREA() As DateTime
        Get
            Return _FECHA_CREA
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_CREA = Value
            OnPropertyChanged("FECHA_CREA")
        End Set
    End Property 

    Private _FECHA_CREAOld As DateTime
    Public Property FECHA_CREAOld() As DateTime
        Get
            Return _FECHA_CREAOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_CREAOld = Value
        End Set
    End Property 

    Private _USUARIO_ACT As String
    <Column(Name:="Usuario act", Storage:="USUARIO_ACT", DbType:="VARCHAR(100) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 100)> _
    Public Property USUARIO_ACT() As String
        Get
            Return _USUARIO_ACT
        End Get
        Set(ByVal Value As String)
            _USUARIO_ACT = Value
            OnPropertyChanged("USUARIO_ACT")
        End Set
    End Property 

    Private _USUARIO_ACTOld As String
    Public Property USUARIO_ACTOld() As String
        Get
            Return _USUARIO_ACTOld
        End Get
        Set(ByVal Value As String)
            _USUARIO_ACTOld = Value
        End Set
    End Property 

    Private _FECHA_ACT As DateTime
    <Column(Name:="Fecha act", Storage:="FECHA_ACT", DbType:="DATETIME NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
    Public Property FECHA_ACT() As DateTime
        Get
            Return _FECHA_ACT
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_ACT = Value
            OnPropertyChanged("FECHA_ACT")
        End Set
    End Property 

    Private _FECHA_ACTOld As DateTime
    Public Property FECHA_ACTOld() As DateTime
        Get
            Return _FECHA_ACTOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_ACTOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
