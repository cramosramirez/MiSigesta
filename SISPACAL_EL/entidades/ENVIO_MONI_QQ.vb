''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.ENVIO_MONI_QQ
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row ENVIO_MONI_QQ en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	28/11/2022	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="ENVIO_MONI_QQ")> Public Class ENVIO_MONI_QQ
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_ENVIO_MQQ As Int32, aID_ENVIO As Int32, aID_MONITOR As Int32, aID_PROVEE_QQ As Int32, aID_PROVEE_QQ_CORTE As Int32, aTARIFA As Decimal)
        Me._ID_ENVIO_MQQ = aID_ENVIO_MQQ
        Me._ID_ENVIO = aID_ENVIO
        Me._ID_MONITOR = aID_MONITOR
        Me._ID_PROVEE_QQ = aID_PROVEE_QQ
        Me._ID_PROVEE_QQ_CORTE = aID_PROVEE_QQ_CORTE
        Me._TARIFA = aTARIFA
    End Sub

#Region " Properties "

    Private _ID_ENVIO_MQQ As Int32
    <Column(Name:="Id envio mqq", Storage:="ID_ENVIO_MQQ", DBType:="INT NOT NULL", Id:=True),
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property ID_ENVIO_MQQ() As Int32
        Get
            Return _ID_ENVIO_MQQ
        End Get
        Set(ByVal Value As Int32)
            _ID_ENVIO_MQQ = Value
            OnPropertyChanged("ID_ENVIO_MQQ")
        End Set
    End Property


    Private _ID_ENVIO As Int32
    <Column(Name:="Id envio", Storage:="ID_ENVIO", DBType:="INT", Id:=False),
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)>
    Public Property ID_ENVIO() As Int32
        Get
            Return _ID_ENVIO
        End Get
        Set(ByVal Value As Int32)
            _ID_ENVIO = Value
            OnPropertyChanged("ID_ENVIO")
        End Set
    End Property


    Private _ID_ENVIOOld As Int32
    Public Property ID_ENVIOOld() As Int32
        Get
            Return _ID_ENVIOOld
        End Get
        Set(ByVal Value As Int32)
            _ID_ENVIOOld = Value
        End Set
    End Property 

    Private _fkID_ENVIO As ENVIO
    Public Property fkID_ENVIO() As ENVIO
        Get
            Return _fkID_ENVIO
        End Get
        Set(ByVal Value As ENVIO)
            _fkID_ENVIO = Value
        End Set
    End Property 

    Private _ID_MONITOR As Int32
    <Column(Name:="Id monitor", Storage:="ID_MONITOR", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_MONITOR() As Int32
        Get
            Return _ID_MONITOR
        End Get
        Set(ByVal Value As Int32)
            _ID_MONITOR = Value
            OnPropertyChanged("ID_MONITOR")
        End Set
    End Property 

    Private _ID_MONITOROld As Int32
    Public Property ID_MONITOROld() As Int32
        Get
            Return _ID_MONITOROld
        End Get
        Set(ByVal Value As Int32)
            _ID_MONITOROld = Value
        End Set
    End Property 

    Private _fkID_MONITOR As MONITOR_CAL
    Public Property fkID_MONITOR() As MONITOR_CAL
        Get
            Return _fkID_MONITOR
        End Get
        Set(ByVal Value As MONITOR_CAL)
            _fkID_MONITOR = Value
        End Set
    End Property 

    Private _ID_PROVEE_QQ As Int32
    <Column(Name:="Id provee qq", Storage:="ID_PROVEE_QQ", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_PROVEE_QQ() As Int32
        Get
            Return _ID_PROVEE_QQ
        End Get
        Set(ByVal Value As Int32)
            _ID_PROVEE_QQ = Value
            OnPropertyChanged("ID_PROVEE_QQ")
        End Set
    End Property 

    Private _ID_PROVEE_QQOld As Int32
    Public Property ID_PROVEE_QQOld() As Int32
        Get
            Return _ID_PROVEE_QQOld
        End Get
        Set(ByVal Value As Int32)
            _ID_PROVEE_QQOld = Value
        End Set
    End Property 

    Private _fkID_PROVEE_QQ As PROVEEDOR_QUERQUEO
    Public Property fkID_PROVEE_QQ() As PROVEEDOR_QUERQUEO
        Get
            Return _fkID_PROVEE_QQ
        End Get
        Set(ByVal Value As PROVEEDOR_QUERQUEO)
            _fkID_PROVEE_QQ = Value
        End Set
    End Property

    Private _ID_PROVEE_QQ_CORTE As Int32
    <Column(Name:="Id provee qq corte", Storage:="ID_PROVEE_QQ_CORTE", DBType:="INT", Id:=False),
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)>
    Public Property ID_PROVEE_QQ_CORTE() As Int32
        Get
            Return _ID_PROVEE_QQ_CORTE
        End Get
        Set(ByVal Value As Int32)
            _ID_PROVEE_QQ_CORTE = Value
            OnPropertyChanged("ID_PROVEE_QQ_CORTE")
        End Set
    End Property

    Private _ID_PROVEE_QQ_CORTEOld As Int32
    Public Property ID_PROVEE_QQ_CORTEOld() As Int32
        Get
            Return _ID_PROVEE_QQ_CORTEOld
        End Get
        Set(ByVal Value As Int32)
            _ID_PROVEE_QQ_CORTEOld = Value
        End Set
    End Property

    Private _TARIFA As Decimal
    <Column(Name:="Tarifa", Storage:="TARIFA", DBType:="NUMERIC(10,4) NOT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=4)>
    Public Property TARIFA() As Decimal
        Get
            Return _TARIFA
        End Get
        Set(ByVal Value As Decimal)
            _TARIFA = Value
            OnPropertyChanged("TARIFA")
        End Set
    End Property

    Private _TARIFAOld As Decimal
    Public Property TARIFAOld() As Decimal
        Get
            Return _TARIFAOld
        End Get
        Set(ByVal Value As Decimal)
            _TARIFAOld = Value
        End Set
    End Property

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
