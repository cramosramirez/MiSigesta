''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.AGRONOMO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row AGRONOMO en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	14/06/2015	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="AGRONOMO")> Public Class AGRONOMO
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aCODIAGRON As String, aAPELLIDO_AGRONOMO As String, aNOMBRE_AGRONOMO As String, aTELEF_AGRONOMO As String, aZONA As String, aESTADO_AGRONOMO As Int32, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime, aUSUARIO_SIGESTA As String, aVER_CONTRATO As Boolean)
        Me._CODIAGRON = aCODIAGRON
        Me._APELLIDO_AGRONOMO = aAPELLIDO_AGRONOMO
        Me._NOMBRE_AGRONOMO = aNOMBRE_AGRONOMO
        Me._TELEF_AGRONOMO = aTELEF_AGRONOMO
        Me._ZONA = aZONA
        Me._ESTADO_AGRONOMO = aESTADO_AGRONOMO
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
        Me._USUARIO_SIGESTA = aUSUARIO_SIGESTA
        Me._VER_CONTRATO = aVER_CONTRATO
    End Sub

#Region " Properties "

    Private _CODIAGRON As String
    <Column(Name:="Codiagron", Storage:="CODIAGRON", DBType:="CHAR(8) NOT NULL", Id:=True),
     DataObjectField(True, False, False, 8)>
    Public Property CODIAGRON() As String
        Get
            Return _CODIAGRON
        End Get
        Set(ByVal Value As String)
            _CODIAGRON = Value
            OnPropertyChanged("CODIAGRON")
        End Set
    End Property 

    Private _APELLIDO_AGRONOMO As String
    <Column(Name:="Apellido agronomo", Storage:="APELLIDO_AGRONOMO", DbType:="VARCHAR(32)", Id:=False), _
     DataObjectField(False, False, True, 32)> _
    Public Property APELLIDO_AGRONOMO() As String
        Get
            Return _APELLIDO_AGRONOMO
        End Get
        Set(ByVal Value As String)
            _APELLIDO_AGRONOMO = Value
            OnPropertyChanged("APELLIDO_AGRONOMO")
        End Set
    End Property 

    Private _APELLIDO_AGRONOMOOld As String
    Public Property APELLIDO_AGRONOMOOld() As String
        Get
            Return _APELLIDO_AGRONOMOOld
        End Get
        Set(ByVal Value As String)
            _APELLIDO_AGRONOMOOld = Value
        End Set
    End Property 

    Private _NOMBRE_AGRONOMO As String
    <Column(Name:="Nombre agronomo", Storage:="NOMBRE_AGRONOMO", DbType:="VARCHAR(32)", Id:=False), _
     DataObjectField(False, False, True, 32)> _
    Public Property NOMBRE_AGRONOMO() As String
        Get
            Return _NOMBRE_AGRONOMO
        End Get
        Set(ByVal Value As String)
            _NOMBRE_AGRONOMO = Value
            OnPropertyChanged("NOMBRE_AGRONOMO")
        End Set
    End Property 

    Private _NOMBRE_AGRONOMOOld As String
    Public Property NOMBRE_AGRONOMOOld() As String
        Get
            Return _NOMBRE_AGRONOMOOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_AGRONOMOOld = Value
        End Set
    End Property 

    Private _TELEF_AGRONOMO As String
    <Column(Name:="Telef agronomo", Storage:="TELEF_AGRONOMO", DbType:="VARCHAR(8)", Id:=False), _
     DataObjectField(False, False, True, 8)> _
    Public Property TELEF_AGRONOMO() As String
        Get
            Return _TELEF_AGRONOMO
        End Get
        Set(ByVal Value As String)
            _TELEF_AGRONOMO = Value
            OnPropertyChanged("TELEF_AGRONOMO")
        End Set
    End Property 

    Private _TELEF_AGRONOMOOld As String
    Public Property TELEF_AGRONOMOOld() As String
        Get
            Return _TELEF_AGRONOMOOld
        End Get
        Set(ByVal Value As String)
            _TELEF_AGRONOMOOld = Value
        End Set
    End Property 

    Private _ZONA As String
    <Column(Name:="Zona", Storage:="ZONA", DbType:="VARCHAR(2)", Id:=False), _
     DataObjectField(False, False, True, 2)> _
    Public Property ZONA() As String
        Get
            Return _ZONA
        End Get
        Set(ByVal Value As String)
            _ZONA = Value
            OnPropertyChanged("ZONA")
        End Set
    End Property 

    Private _ZONAOld As String
    Public Property ZONAOld() As String
        Get
            Return _ZONAOld
        End Get
        Set(ByVal Value As String)
            _ZONAOld = Value
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

    Private _ESTADO_AGRONOMO As Int32
    <Column(Name:="Estado agronomo", Storage:="ESTADO_AGRONOMO", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ESTADO_AGRONOMO() As Int32
        Get
            Return _ESTADO_AGRONOMO
        End Get
        Set(ByVal Value As Int32)
            _ESTADO_AGRONOMO = Value
            OnPropertyChanged("ESTADO_AGRONOMO")
        End Set
    End Property 

    Private _ESTADO_AGRONOMOOld As Int32
    Public Property ESTADO_AGRONOMOOld() As Int32
        Get
            Return _ESTADO_AGRONOMOOld
        End Get
        Set(ByVal Value As Int32)
            _ESTADO_AGRONOMOOld = Value
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

    Private _USUARIO_SIGESTA As String
    <Column(Name:="Usuario sigesta", Storage:="USUARIO_SIGESTA", DbType:="VARCHAR(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
    Public Property USUARIO_SIGESTA() As String
        Get
            Return _USUARIO_SIGESTA
        End Get
        Set(ByVal Value As String)
            _USUARIO_SIGESTA = Value
            OnPropertyChanged("USUARIO_SIGESTA")
        End Set
    End Property 

    Private _USUARIO_SIGESTAOld As String
    Public Property USUARIO_SIGESTAOld() As String
        Get
            Return _USUARIO_SIGESTAOld
        End Get
        Set(ByVal Value As String)
            _USUARIO_SIGESTAOld = Value
        End Set
    End Property 

    Private _fkUSUARIO_SIGESTA As USUARIO
    Public Property fkUSUARIO_SIGESTA() As USUARIO
        Get
            Return _fkUSUARIO_SIGESTA
        End Get
        Set(ByVal Value As USUARIO)
            _fkUSUARIO_SIGESTA = Value
        End Set
    End Property 

    Private _VER_CONTRATO As Boolean
    <Column(Name:="Ver contrato", Storage:="VER_CONTRATO", DbType:="BIT", Id:=False), _
     DataObjectField(False, False, True, 1)> _
    Public Property VER_CONTRATO() As Boolean
        Get
            Return _VER_CONTRATO
        End Get
        Set(ByVal Value As Boolean)
            _VER_CONTRATO = Value
            OnPropertyChanged("VER_CONTRATO")
        End Set
    End Property 

    Private _VER_CONTRATOOld As Boolean
    Public Property VER_CONTRATOOld() As Boolean
        Get
            Return _VER_CONTRATOOld
        End Get
        Set(ByVal Value As Boolean)
            _VER_CONTRATOOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
