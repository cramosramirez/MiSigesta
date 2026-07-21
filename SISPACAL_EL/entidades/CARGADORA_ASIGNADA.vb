''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.CARGADORA_ASIGNADA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row CARGADORA_ASIGNADA en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	08/03/2015	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="CARGADORA_ASIGNADA")> Public Class CARGADORA_ASIGNADA
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_CARGADORA_ASIG As Int32, aID_CARGADORA As Int32, aID_CARGADOR As Int32, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime, aID_ZAFRA As Int32)
        Me._ID_CARGADORA_ASIG = aID_CARGADORA_ASIG
        Me._ID_CARGADORA = aID_CARGADORA
        Me._ID_CARGADOR = aID_CARGADOR
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
        Me._ID_ZAFRA = aID_ZAFRA
    End Sub

#Region " Properties "

    Private _ID_CARGADORA_ASIG As Int32
    <Column(Name:="Id cargadora asig", Storage:="ID_CARGADORA_ASIG", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_CARGADORA_ASIG() As Int32
        Get
            Return _ID_CARGADORA_ASIG
        End Get
        Set(ByVal Value As Int32)
            _ID_CARGADORA_ASIG = Value
            OnPropertyChanged("ID_CARGADORA_ASIG")
        End Set
    End Property 

    Private _ID_CARGADORA As Int32
    <Column(Name:="Id cargadora", Storage:="ID_CARGADORA", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_CARGADORA() As Int32
        Get
            Return _ID_CARGADORA
        End Get
        Set(ByVal Value As Int32)
            _ID_CARGADORA = Value
            OnPropertyChanged("ID_CARGADORA")
        End Set
    End Property 

    Private _ID_CARGADORAOld As Int32
    Public Property ID_CARGADORAOld() As Int32
        Get
            Return _ID_CARGADORAOld
        End Get
        Set(ByVal Value As Int32)
            _ID_CARGADORAOld = Value
        End Set
    End Property 

    Private _fkID_CARGADORA As CARGADORA
    Public Property fkID_CARGADORA() As CARGADORA
        Get
            Return _fkID_CARGADORA
        End Get
        Set(ByVal Value As CARGADORA)
            _fkID_CARGADORA = Value
        End Set
    End Property 

    Private _ID_CARGADOR As Int32
    <Column(Name:="Id cargador", Storage:="ID_CARGADOR", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_CARGADOR() As Int32
        Get
            Return _ID_CARGADOR
        End Get
        Set(ByVal Value As Int32)
            _ID_CARGADOR = Value
            OnPropertyChanged("ID_CARGADOR")
        End Set
    End Property 

    Private _ID_CARGADOROld As Int32
    Public Property ID_CARGADOROld() As Int32
        Get
            Return _ID_CARGADOROld
        End Get
        Set(ByVal Value As Int32)
            _ID_CARGADOROld = Value
        End Set
    End Property 

    Private _fkID_CARGADOR As CARGADOR
    Public Property fkID_CARGADOR() As CARGADOR
        Get
            Return _fkID_CARGADOR
        End Get
        Set(ByVal Value As CARGADOR)
            _fkID_CARGADOR = Value
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

    Private _ID_ZAFRA As Int32
    <Column(Name:="Id zafra", Storage:="ID_ZAFRA", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_ZAFRA() As Int32
        Get
            Return _ID_ZAFRA
        End Get
        Set(ByVal Value As Int32)
            _ID_ZAFRA = Value
            OnPropertyChanged("ID_ZAFRA")
        End Set
    End Property 

    Private _ID_ZAFRAOld As Int32
    Public Property ID_ZAFRAOld() As Int32
        Get
            Return _ID_ZAFRAOld
        End Get
        Set(ByVal Value As Int32)
            _ID_ZAFRAOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
