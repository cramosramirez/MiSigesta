''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.FILTRO_ORDEN_ROZA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row FILTRO_ORDEN_ROZA en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	06/12/2014	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="FILTRO_ORDEN_ROZA")> Public Class FILTRO_ORDEN_ROZA
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_FILTRO_ORDEN_ROZA As Int32, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aID_PLAN_COSECHA As Int32)
        Me._ID_FILTRO_ORDEN_ROZA = aID_FILTRO_ORDEN_ROZA
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._ID_PLAN_COSECHA = aID_PLAN_COSECHA
    End Sub

#Region " Properties "

    Private _ID_FILTRO_ORDEN_ROZA As Int32
    <Column(Name:="Id filtro orden roza", Storage:="ID_FILTRO_ORDEN_ROZA", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_FILTRO_ORDEN_ROZA() As Int32
        Get
            Return _ID_FILTRO_ORDEN_ROZA
        End Get
        Set(ByVal Value As Int32)
            _ID_FILTRO_ORDEN_ROZA = Value
            OnPropertyChanged("ID_FILTRO_ORDEN_ROZA")
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

    Private _ID_PLAN_COSECHA As Int32
    <Column(Name:="Id plan cosecha", Storage:="ID_PLAN_COSECHA", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_PLAN_COSECHA() As Int32
        Get
            Return _ID_PLAN_COSECHA
        End Get
        Set(ByVal Value As Int32)
            _ID_PLAN_COSECHA = Value
            OnPropertyChanged("ID_PLAN_COSECHA")
        End Set
    End Property 

    Private _ID_PLAN_COSECHAOld As Int32
    Public Property ID_PLAN_COSECHAOld() As Int32
        Get
            Return _ID_PLAN_COSECHAOld
        End Get
        Set(ByVal Value As Int32)
            _ID_PLAN_COSECHAOld = Value
        End Set
    End Property 

    Private _fkID_PLAN_COSECHA As PLAN_COSECHA
    Public Property fkID_PLAN_COSECHA() As PLAN_COSECHA
        Get
            Return _fkID_PLAN_COSECHA
        End Get
        Set(ByVal Value As PLAN_COSECHA)
            _fkID_PLAN_COSECHA = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
