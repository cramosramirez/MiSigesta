''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.ORDEN_ROZA_DETA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row ORDEN_ROZA_DETA en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	12/11/2013	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="ORDEN_ROZA_DETA")> Public Class ORDEN_ROZA_DETA
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_ORDEN_DETA As Int32, aID_ORDEN As Int32, aID_PLAN_ENTREGA_CANA As Int32, aACCESLOTE As String, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime)
        Me._ID_ORDEN_DETA = aID_ORDEN_DETA
        Me._ID_ORDEN = aID_ORDEN
        Me._ID_PLAN_ENTREGA_CANA = aID_PLAN_ENTREGA_CANA
        Me._ACCESLOTE = aACCESLOTE
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
    End Sub

#Region " Properties "

    Private _ID_ORDEN_DETA As Int32
    <Column(Name:="Id orden deta", Storage:="ID_ORDEN_DETA", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_ORDEN_DETA() As Int32
        Get
            Return _ID_ORDEN_DETA
        End Get
        Set(ByVal Value As Int32)
            _ID_ORDEN_DETA = Value
            OnPropertyChanged("ID_ORDEN_DETA")
        End Set
    End Property 

    Private _ID_ORDEN As Int32
    <Column(Name:="Id orden", Storage:="ID_ORDEN", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_ORDEN() As Int32
        Get
            Return _ID_ORDEN
        End Get
        Set(ByVal Value As Int32)
            _ID_ORDEN = Value
            OnPropertyChanged("ID_ORDEN")
        End Set
    End Property 

    Private _ID_ORDENOld As Int32
    Public Property ID_ORDENOld() As Int32
        Get
            Return _ID_ORDENOld
        End Get
        Set(ByVal Value As Int32)
            _ID_ORDENOld = Value
        End Set
    End Property 

    Private _fkID_ORDEN As ORDEN_ROZA_ENCA
    Public Property fkID_ORDEN() As ORDEN_ROZA_ENCA
        Get
            Return _fkID_ORDEN
        End Get
        Set(ByVal Value As ORDEN_ROZA_ENCA)
            _fkID_ORDEN = Value
        End Set
    End Property 

    Private _ID_PLAN_ENTREGA_CANA As Int32
    <Column(Name:="Id plan entrega cana", Storage:="ID_PLAN_ENTREGA_CANA", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_PLAN_ENTREGA_CANA() As Int32
        Get
            Return _ID_PLAN_ENTREGA_CANA
        End Get
        Set(ByVal Value As Int32)
            _ID_PLAN_ENTREGA_CANA = Value
            OnPropertyChanged("ID_PLAN_ENTREGA_CANA")
        End Set
    End Property 

    Private _ID_PLAN_ENTREGA_CANAOld As Int32
    Public Property ID_PLAN_ENTREGA_CANAOld() As Int32
        Get
            Return _ID_PLAN_ENTREGA_CANAOld
        End Get
        Set(ByVal Value As Int32)
            _ID_PLAN_ENTREGA_CANAOld = Value
        End Set
    End Property 

    Private _fkID_PLAN_ENTREGA_CANA As PLAN_ENTREGA_CANA
    Public Property fkID_PLAN_ENTREGA_CANA() As PLAN_ENTREGA_CANA
        Get
            Return _fkID_PLAN_ENTREGA_CANA
        End Get
        Set(ByVal Value As PLAN_ENTREGA_CANA)
            _fkID_PLAN_ENTREGA_CANA = Value
        End Set
    End Property 

    Private _ACCESLOTE As String
    <Column(Name:="Acceslote", Storage:="ACCESLOTE", DbType:="CHAR(21) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 21)> _
    Public Property ACCESLOTE() As String
        Get
            Return _ACCESLOTE
        End Get
        Set(ByVal Value As String)
            _ACCESLOTE = Value
            OnPropertyChanged("ACCESLOTE")
        End Set
    End Property 

    Private _ACCESLOTEOld As String
    Public Property ACCESLOTEOld() As String
        Get
            Return _ACCESLOTEOld
        End Get
        Set(ByVal Value As String)
            _ACCESLOTEOld = Value
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
