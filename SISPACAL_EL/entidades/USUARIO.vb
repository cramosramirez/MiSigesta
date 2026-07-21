''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.USUARIO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row USUARIO en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	31/08/2013	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="USUARIO")> Public Class USUARIO
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aUSUARIO As String, aID_PERFIL As Int32, aNOMBRE As String, aEMAIL As String, aCLAVE As String, aACTIVO As Boolean, aBLOQUEADO As Boolean, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime, aFECHA_ULTACCESO As DateTime)
        Me._USUARIO = aUSUARIO
        Me._ID_PERFIL = aID_PERFIL
        Me._NOMBRE = aNOMBRE
        Me._EMAIL = aEMAIL
        Me._CLAVE = aCLAVE
        Me._ACTIVO = aACTIVO
        Me._BLOQUEADO = aBLOQUEADO
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
        Me._FECHA_ULTACCESO = aFECHA_ULTACCESO
    End Sub

#Region " Properties "

    Private _USUARIO As String
    <Column(Name:="Usuario", Storage:="USUARIO", DbType:="VARCHAR(100) NOT NULL", Id:=True), _
     DataObjectField(True, False, False, 100)> _
    Public Property USUARIO() As String
        Get
            Return _USUARIO
        End Get
        Set(ByVal Value As String)
            _USUARIO = Value
            OnPropertyChanged("USUARIO")
        End Set
    End Property 

    Private _ID_PERFIL As Int32
    <Column(Name:="Id perfil", Storage:="ID_PERFIL", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_PERFIL() As Int32
        Get
            Return _ID_PERFIL
        End Get
        Set(ByVal Value As Int32)
            _ID_PERFIL = Value
            OnPropertyChanged("ID_PERFIL")
        End Set
    End Property 

    Private _ID_PERFILOld As Int32
    Public Property ID_PERFILOld() As Int32
        Get
            Return _ID_PERFILOld
        End Get
        Set(ByVal Value As Int32)
            _ID_PERFILOld = Value
        End Set
    End Property 

    Private _fkID_PERFIL As PERFIL
    Public Property fkID_PERFIL() As PERFIL
        Get
            Return _fkID_PERFIL
        End Get
        Set(ByVal Value As PERFIL)
            _fkID_PERFIL = Value
        End Set
    End Property 

    Private _NOMBRE As String
    <Column(Name:="Nombre", Storage:="NOMBRE", DbType:="VARCHAR(200) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 200)> _
    Public Property NOMBRE() As String
        Get
            Return _NOMBRE
        End Get
        Set(ByVal Value As String)
            _NOMBRE = Value
            OnPropertyChanged("NOMBRE")
        End Set
    End Property 

    Private _NOMBREOld As String
    Public Property NOMBREOld() As String
        Get
            Return _NOMBREOld
        End Get
        Set(ByVal Value As String)
            _NOMBREOld = Value
        End Set
    End Property 

    Private _EMAIL As String
    <Column(Name:="Email", Storage:="EMAIL", DbType:="VARCHAR(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
    Public Property EMAIL() As String
        Get
            Return _EMAIL
        End Get
        Set(ByVal Value As String)
            _EMAIL = Value
            OnPropertyChanged("EMAIL")
        End Set
    End Property 

    Private _EMAILOld As String
    Public Property EMAILOld() As String
        Get
            Return _EMAILOld
        End Get
        Set(ByVal Value As String)
            _EMAILOld = Value
        End Set
    End Property 

    Private _CLAVE As String
    <Column(Name:="Clave", Storage:="CLAVE", DbType:="VARCHAR(200) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 200)> _
    Public Property CLAVE() As String
        Get
            Return _CLAVE
        End Get
        Set(ByVal Value As String)
            _CLAVE = Value
            OnPropertyChanged("CLAVE")
        End Set
    End Property 

    Private _CLAVEOld As String
    Public Property CLAVEOld() As String
        Get
            Return _CLAVEOld
        End Get
        Set(ByVal Value As String)
            _CLAVEOld = Value
        End Set
    End Property 

    Private _ACTIVO As Boolean
    <Column(Name:="Activo", Storage:="ACTIVO", DbType:="BIT NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 1)> _
    Public Property ACTIVO() As Boolean
        Get
            Return _ACTIVO
        End Get
        Set(ByVal Value As Boolean)
            _ACTIVO = Value
            OnPropertyChanged("ACTIVO")
        End Set
    End Property 

    Private _ACTIVOOld As Boolean
    Public Property ACTIVOOld() As Boolean
        Get
            Return _ACTIVOOld
        End Get
        Set(ByVal Value As Boolean)
            _ACTIVOOld = Value
        End Set
    End Property 

    Private _BLOQUEADO As Boolean
    <Column(Name:="Bloqueado", Storage:="BLOQUEADO", DbType:="BIT", Id:=False), _
     DataObjectField(False, False, True, 1)> _
    Public Property BLOQUEADO() As Boolean
        Get
            Return _BLOQUEADO
        End Get
        Set(ByVal Value As Boolean)
            _BLOQUEADO = Value
            OnPropertyChanged("BLOQUEADO")
        End Set
    End Property 

    Private _BLOQUEADOOld As Boolean
    Public Property BLOQUEADOOld() As Boolean
        Get
            Return _BLOQUEADOOld
        End Get
        Set(ByVal Value As Boolean)
            _BLOQUEADOOld = Value
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

    Private _FECHA_ULTACCESO As DateTime
    <Column(Name:="Fecha ultacceso", Storage:="FECHA_ULTACCESO", DbType:="DATETIME", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_ULTACCESO() As DateTime
        Get
            Return _FECHA_ULTACCESO
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_ULTACCESO = Value
            OnPropertyChanged("FECHA_ULTACCESO")
        End Set
    End Property 

    Private _FECHA_ULTACCESOOld As DateTime
    Public Property FECHA_ULTACCESOOld() As DateTime
        Get
            Return _FECHA_ULTACCESOOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_ULTACCESOOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
