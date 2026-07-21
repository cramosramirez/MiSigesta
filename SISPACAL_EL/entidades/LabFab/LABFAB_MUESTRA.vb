''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.LABFAB_MUESTRA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row LABFAB_MUESTRA en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	17/11/2015	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="LABFAB_MUESTRA")> Public Class LABFAB_MUESTRA
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_MUESTRA As Int32, aID_ETAPA As Int32, aNOMBRE_MUESTRA As String, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime)
        Me._ID_MUESTRA = aID_MUESTRA
        Me._ID_ETAPA = aID_ETAPA
        Me._NOMBRE_MUESTRA = aNOMBRE_MUESTRA
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
    End Sub

#Region " Properties "

    Private _ID_MUESTRA As Int32
    <Column(Name:="Id muestra", Storage:="ID_MUESTRA", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_MUESTRA() As Int32
        Get
            Return _ID_MUESTRA
        End Get
        Set(ByVal Value As Int32)
            _ID_MUESTRA = Value
            OnPropertyChanged("ID_MUESTRA")
        End Set
    End Property 

    Private _ID_ETAPA As Int32
    <Column(Name:="Id etapa", Storage:="ID_ETAPA", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_ETAPA() As Int32
        Get
            Return _ID_ETAPA
        End Get
        Set(ByVal Value As Int32)
            _ID_ETAPA = Value
            OnPropertyChanged("ID_ETAPA")
        End Set
    End Property 

    Private _ID_ETAPAOld As Int32
    Public Property ID_ETAPAOld() As Int32
        Get
            Return _ID_ETAPAOld
        End Get
        Set(ByVal Value As Int32)
            _ID_ETAPAOld = Value
        End Set
    End Property 

    Private _fkID_ETAPA As LABFAB_ETAPA
    Public Property fkID_ETAPA() As LABFAB_ETAPA
        Get
            Return _fkID_ETAPA
        End Get
        Set(ByVal Value As LABFAB_ETAPA)
            _fkID_ETAPA = Value
        End Set
    End Property 

    Private _NOMBRE_MUESTRA As String
    <Column(Name:="Nombre muestra", Storage:="NOMBRE_MUESTRA", DbType:="VARCHAR(200) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 200)> _
    Public Property NOMBRE_MUESTRA() As String
        Get
            Return _NOMBRE_MUESTRA
        End Get
        Set(ByVal Value As String)
            _NOMBRE_MUESTRA = Value
            OnPropertyChanged("NOMBRE_MUESTRA")
        End Set
    End Property 

    Private _NOMBRE_MUESTRAOld As String
    Public Property NOMBRE_MUESTRAOld() As String
        Get
            Return _NOMBRE_MUESTRAOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_MUESTRAOld = Value
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
