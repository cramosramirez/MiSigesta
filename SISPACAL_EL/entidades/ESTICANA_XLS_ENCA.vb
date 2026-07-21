''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.ESTICANA_XLS_ENCA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row ESTICANA_XLS_ENCA en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	10/12/2022	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="ESTICANA_XLS_ENCA")> Public Class ESTICANA_XLS_ENCA
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_ENCA As Int32, aFECHA_CARGA As DateTime, aNOMBRE_ARCHIVO As String, aUSUARIO_CREA As String, aFECHA_CREA As DateTime)
        Me._ID_ENCA = aID_ENCA
        Me._FECHA_CARGA = aFECHA_CARGA
        Me._NOMBRE_ARCHIVO = aNOMBRE_ARCHIVO
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
    End Sub

#Region " Properties "

    Private _ID_ENCA As Int32
    <Column(Name:="Id enca", Storage:="ID_ENCA", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_ENCA() As Int32
        Get
            Return _ID_ENCA
        End Get
        Set(ByVal Value As Int32)
            _ID_ENCA = Value
            OnPropertyChanged("ID_ENCA")
        End Set
    End Property 

    Private _FECHA_CARGA As DateTime
    <Column(Name:="Fecha carga", Storage:="FECHA_CARGA", DbType:="DATETIME NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
    Public Property FECHA_CARGA() As DateTime
        Get
            Return _FECHA_CARGA
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_CARGA = Value
            OnPropertyChanged("FECHA_CARGA")
        End Set
    End Property 

    Private _FECHA_CARGAOld As DateTime
    Public Property FECHA_CARGAOld() As DateTime
        Get
            Return _FECHA_CARGAOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_CARGAOld = Value
        End Set
    End Property 

    Private _NOMBRE_ARCHIVO As String
    <Column(Name:="Nombre archivo", Storage:="NOMBRE_ARCHIVO", DbType:="VARCHAR(200) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 200)> _
    Public Property NOMBRE_ARCHIVO() As String
        Get
            Return _NOMBRE_ARCHIVO
        End Get
        Set(ByVal Value As String)
            _NOMBRE_ARCHIVO = Value
            OnPropertyChanged("NOMBRE_ARCHIVO")
        End Set
    End Property 

    Private _NOMBRE_ARCHIVOOld As String
    Public Property NOMBRE_ARCHIVOOld() As String
        Get
            Return _NOMBRE_ARCHIVOOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_ARCHIVOOld = Value
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

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
