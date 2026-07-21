''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.BANCOS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row BANCOS en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	15/11/2013	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="BANCOS")> Public Class BANCOS
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aCODIBANCO As Int32, aNOMBRE_BANCO As String, aUSER_CREA As Int32, aFECHA_CREA As DateTime, aUSER_ACT As Int32, aFECHA_ACT As DateTime)
        Me._CODIBANCO = aCODIBANCO
        Me._NOMBRE_BANCO = aNOMBRE_BANCO
        Me._USER_CREA = aUSER_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USER_ACT = aUSER_ACT
        Me._FECHA_ACT = aFECHA_ACT
    End Sub

#Region " Properties "

    Private _CODIBANCO As Int32
    <Column(Name:="Codibanco", Storage:="CODIBANCO", DbType:="INT IDENTITY NOT NULL", Id:=True), _
     DataObjectField(True, True, False), Precision(Precision:=10, Scale:=255)> _
    Public Property CODIBANCO() As Int32
        Get
            Return _CODIBANCO
        End Get
        Set(ByVal Value As Int32)
            _CODIBANCO = Value
            OnPropertyChanged("CODIBANCO")
        End Set
    End Property 

    Private _NOMBRE_BANCO As String
    <Column(Name:="Nombre banco", Storage:="NOMBRE_BANCO", DbType:="VARCHAR(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
    Public Property NOMBRE_BANCO() As String
        Get
            Return _NOMBRE_BANCO
        End Get
        Set(ByVal Value As String)
            _NOMBRE_BANCO = Value
            OnPropertyChanged("NOMBRE_BANCO")
        End Set
    End Property 

    Private _NOMBRE_BANCOOld As String
    Public Property NOMBRE_BANCOOld() As String
        Get
            Return _NOMBRE_BANCOOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_BANCOOld = Value
        End Set
    End Property 

    Private _USER_CREA As Int32
    <Column(Name:="User crea", Storage:="USER_CREA", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property USER_CREA() As Int32
        Get
            Return _USER_CREA
        End Get
        Set(ByVal Value As Int32)
            _USER_CREA = Value
            OnPropertyChanged("USER_CREA")
        End Set
    End Property 

    Private _USER_CREAOld As Int32
    Public Property USER_CREAOld() As Int32
        Get
            Return _USER_CREAOld
        End Get
        Set(ByVal Value As Int32)
            _USER_CREAOld = Value
        End Set
    End Property 

    Private _FECHA_CREA As DateTime
    <Column(Name:="Fecha crea", Storage:="FECHA_CREA", DbType:="DATETIME", Id:=False), _
     DataObjectField(False, False, True)> _
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

    Private _USER_ACT As Int32
    <Column(Name:="User act", Storage:="USER_ACT", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property USER_ACT() As Int32
        Get
            Return _USER_ACT
        End Get
        Set(ByVal Value As Int32)
            _USER_ACT = Value
            OnPropertyChanged("USER_ACT")
        End Set
    End Property 

    Private _USER_ACTOld As Int32
    Public Property USER_ACTOld() As Int32
        Get
            Return _USER_ACTOld
        End Get
        Set(ByVal Value As Int32)
            _USER_ACTOld = Value
        End Set
    End Property 

    Private _FECHA_ACT As DateTime
    <Column(Name:="Fecha act", Storage:="FECHA_ACT", DbType:="DATETIME", Id:=False), _
     DataObjectField(False, False, True)> _
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
