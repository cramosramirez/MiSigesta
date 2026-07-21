''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.ORDEN_ROZA_ENCA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row ORDEN_ROZA_ENCA en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	12/11/2013	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="ORDEN_ROZA_ENCA")> Public Class ORDEN_ROZA_ENCA
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_ORDEN As Int32, aFECHA_ORDEN As DateTime, aTONEL_DIARIA As Decimal, aCORRELATIVO As Int32, aID_PLAN_SEMANAL As Int32, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime)
        Me._ID_ORDEN = aID_ORDEN
        Me._FECHA_ORDEN = aFECHA_ORDEN
        Me._TONEL_DIARIA = aTONEL_DIARIA
        Me._CORRELATIVO = aCORRELATIVO
        Me._ID_PLAN_SEMANAL = aID_PLAN_SEMANAL
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
    End Sub

#Region " Properties "

    Private _ID_ORDEN As Int32
    <Column(Name:="Id orden", Storage:="ID_ORDEN", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_ORDEN() As Int32
        Get
            Return _ID_ORDEN
        End Get
        Set(ByVal Value As Int32)
            _ID_ORDEN = Value
            OnPropertyChanged("ID_ORDEN")
        End Set
    End Property 

    Private _FECHA_ORDEN As DateTime
    <Column(Name:="Fecha orden", Storage:="FECHA_ORDEN", DbType:="DATETIME NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
    Public Property FECHA_ORDEN() As DateTime
        Get
            Return _FECHA_ORDEN
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_ORDEN = Value
            OnPropertyChanged("FECHA_ORDEN")
        End Set
    End Property 

    Private _FECHA_ORDENOld As DateTime
    Public Property FECHA_ORDENOld() As DateTime
        Get
            Return _FECHA_ORDENOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_ORDENOld = Value
        End Set
    End Property 

    Private _TONEL_DIARIA As Decimal
    <Column(Name:="Tonel diaria", Storage:="TONEL_DIARIA", DbType:="NUMERIC(20,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)> _
    Public Property TONEL_DIARIA() As Decimal
        Get
            Return _TONEL_DIARIA
        End Get
        Set(ByVal Value As Decimal)
            _TONEL_DIARIA = Value
            OnPropertyChanged("TONEL_DIARIA")
        End Set
    End Property 

    Private _TONEL_DIARIAOld As Decimal
    Public Property TONEL_DIARIAOld() As Decimal
        Get
            Return _TONEL_DIARIAOld
        End Get
        Set(ByVal Value As Decimal)
            _TONEL_DIARIAOld = Value
        End Set
    End Property 

    Private _CORRELATIVO As Int32
    <Column(Name:="Correlativo", Storage:="CORRELATIVO", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property CORRELATIVO() As Int32
        Get
            Return _CORRELATIVO
        End Get
        Set(ByVal Value As Int32)
            _CORRELATIVO = Value
            OnPropertyChanged("CORRELATIVO")
        End Set
    End Property 

    Private _CORRELATIVOOld As Int32
    Public Property CORRELATIVOOld() As Int32
        Get
            Return _CORRELATIVOOld
        End Get
        Set(ByVal Value As Int32)
            _CORRELATIVOOld = Value
        End Set
    End Property 

    Private _ID_PLAN_SEMANAL As Int32
    <Column(Name:="Id plan semanal", Storage:="ID_PLAN_SEMANAL", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_PLAN_SEMANAL() As Int32
        Get
            Return _ID_PLAN_SEMANAL
        End Get
        Set(ByVal Value As Int32)
            _ID_PLAN_SEMANAL = Value
            OnPropertyChanged("ID_PLAN_SEMANAL")
        End Set
    End Property 

    Private _ID_PLAN_SEMANALOld As Int32
    Public Property ID_PLAN_SEMANALOld() As Int32
        Get
            Return _ID_PLAN_SEMANALOld
        End Get
        Set(ByVal Value As Int32)
            _ID_PLAN_SEMANALOld = Value
        End Set
    End Property 

    Private _fkID_PLAN_SEMANAL As PLAN_SEMANAL
    Public Property fkID_PLAN_SEMANAL() As PLAN_SEMANAL
        Get
            Return _fkID_PLAN_SEMANAL
        End Get
        Set(ByVal Value As PLAN_SEMANAL)
            _fkID_PLAN_SEMANAL = Value
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

    Private _ID_GENERACION As Int32
    <Column(Name:="Id Generacion", Storage:="ID_GENERACION", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_GENERACION() As Int32
        Get
            Return _ID_GENERACION
        End Get
        Set(ByVal Value As Int32)
            _ID_GENERACION = Value
            OnPropertyChanged("ID_GENERACION")
        End Set
    End Property

    Private _ID_GENERACIONOld As Int32
    Public Property ID_GENERACIONOld() As Int32
        Get
            Return _ID_GENERACIONOld
        End Get
        Set(ByVal Value As Int32)
            _ID_GENERACIONOld = Value
        End Set
    End Property

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
