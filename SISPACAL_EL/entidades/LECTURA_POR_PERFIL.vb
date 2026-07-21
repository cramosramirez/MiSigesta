''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.LECTURA_POR_PERFIL
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row LECTURA_POR_PERFIL en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	09/09/2013	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="LECTURA_POR_PERFIL")> Public Class LECTURA_POR_PERFIL
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_LECTURA_PERFIL As Int32, aID_PERFIL As Int32, aID_TIPO_LECTURA As Int32, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime)
        Me._ID_LECTURA_PERFIL = aID_LECTURA_PERFIL
        Me._ID_PERFIL = aID_PERFIL
        Me._ID_TIPO_LECTURA = aID_TIPO_LECTURA
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
    End Sub

#Region " Properties "

    Private _ID_LECTURA_PERFIL As Int32
    <Column(Name:="Id lectura perfil", Storage:="ID_LECTURA_PERFIL", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_LECTURA_PERFIL() As Int32
        Get
            Return _ID_LECTURA_PERFIL
        End Get
        Set(ByVal Value As Int32)
            _ID_LECTURA_PERFIL = Value
            OnPropertyChanged("ID_LECTURA_PERFIL")
        End Set
    End Property 

    Private _ID_PERFIL As Int32
    <Column(Name:="Id perfil", Storage:="ID_PERFIL", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
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

    Private _ID_TIPO_LECTURA As Int32
    <Column(Name:="Id tipo lectura", Storage:="ID_TIPO_LECTURA", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_TIPO_LECTURA() As Int32
        Get
            Return _ID_TIPO_LECTURA
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_LECTURA = Value
            OnPropertyChanged("ID_TIPO_LECTURA")
        End Set
    End Property 

    Private _ID_TIPO_LECTURAOld As Int32
    Public Property ID_TIPO_LECTURAOld() As Int32
        Get
            Return _ID_TIPO_LECTURAOld
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_LECTURAOld = Value
        End Set
    End Property 

    Private _fkID_TIPO_LECTURA As TIPO_LECTURA
    Public Property fkID_TIPO_LECTURA() As TIPO_LECTURA
        Get
            Return _fkID_TIPO_LECTURA
        End Get
        Set(ByVal Value As TIPO_LECTURA)
            _fkID_TIPO_LECTURA = Value
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
