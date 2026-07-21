''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.SUB_ZONAS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row SUB_ZONAS en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	26/05/2014	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="SUB_ZONAS")> Public Class SUB_ZONAS
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aZONA As String, aSUB_ZONA As String, aDESCRIP_SUB_ZONA As String, aNO_SUB_ZONA As Int32, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime)
        Me._ZONA = aZONA
        Me._SUB_ZONA = aSUB_ZONA
        Me._DESCRIP_SUB_ZONA = aDESCRIP_SUB_ZONA
        Me._NO_SUB_ZONA = aNO_SUB_ZONA
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
    End Sub

#Region " Properties "

    Private _ZONA As String
    <Column(Name:="Zona", Storage:="ZONA", DbType:="VARCHAR(2) NOT NULL", Id:=True), _
     DataObjectField(True, False, False, 2)> _
    Public Property ZONA() As String
        Get
            Return _ZONA
        End Get
        Set(ByVal Value As String)
            _ZONA = Value
            OnPropertyChanged("ZONA")
        End Set
    End Property 

    Private _fkZONA As ZONAS
    Public Property fkZONA() As ZONAS
        Get
            Return _fkZONA
        End Get
        Set(ByVal Value As ZONAS)
            _fkZONA = Value
        End Set
    End Property 

    Private _SUB_ZONA As String
    <Column(Name:="Sub zona", Storage:="SUB_ZONA", DbType:="VARCHAR(2) NOT NULL", Id:=True), _
     DataObjectField(True, False, False, 2)> _
    Public Property SUB_ZONA() As String
        Get
            Return _SUB_ZONA
        End Get
        Set(ByVal Value As String)
            _SUB_ZONA = Value
            OnPropertyChanged("SUB_ZONA")
        End Set
    End Property 

    Private _DESCRIP_SUB_ZONA As String
    <Column(Name:="Descrip sub zona", Storage:="DESCRIP_SUB_ZONA", DbType:="VARCHAR(100) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 100)> _
    Public Property DESCRIP_SUB_ZONA() As String
        Get
            Return _DESCRIP_SUB_ZONA
        End Get
        Set(ByVal Value As String)
            _DESCRIP_SUB_ZONA = Value
            OnPropertyChanged("DESCRIP_SUB_ZONA")
        End Set
    End Property 

    Private _DESCRIP_SUB_ZONAOld As String
    Public Property DESCRIP_SUB_ZONAOld() As String
        Get
            Return _DESCRIP_SUB_ZONAOld
        End Get
        Set(ByVal Value As String)
            _DESCRIP_SUB_ZONAOld = Value
        End Set
    End Property 

    Private _NO_SUB_ZONA As Int32
    <Column(Name:="No sub zona", Storage:="NO_SUB_ZONA", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property NO_SUB_ZONA() As Int32
        Get
            Return _NO_SUB_ZONA
        End Get
        Set(ByVal Value As Int32)
            _NO_SUB_ZONA = Value
            OnPropertyChanged("NO_SUB_ZONA")
        End Set
    End Property 

    Private _NO_SUB_ZONAOld As Int32
    Public Property NO_SUB_ZONAOld() As Int32
        Get
            Return _NO_SUB_ZONAOld
        End Get
        Set(ByVal Value As Int32)
            _NO_SUB_ZONAOld = Value
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
