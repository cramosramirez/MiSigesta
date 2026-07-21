''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.DESCUENTOS_PLANILLA_OC
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row DESCUENTOS_PLANILLA_OC en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	28/01/2014	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="DESCUENTOS_PLANILLA_OC")> Public Class DESCUENTOS_PLANILLA_OC
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_DESC_PLA_OC As Int32, aID_DESCUENTO_PLANILLA As Int32, aID_ORDEN_COMBUS As Int32, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime)
        Me._ID_DESC_PLA_OC = aID_DESC_PLA_OC
        Me._ID_DESCUENTO_PLANILLA = aID_DESCUENTO_PLANILLA
        Me._ID_ORDEN_COMBUS = aID_ORDEN_COMBUS
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
    End Sub

#Region " Properties "

    Private _ID_DESC_PLA_OC As Int32
    <Column(Name:="Id desc pla oc", Storage:="ID_DESC_PLA_OC", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_DESC_PLA_OC() As Int32
        Get
            Return _ID_DESC_PLA_OC
        End Get
        Set(ByVal Value As Int32)
            _ID_DESC_PLA_OC = Value
            OnPropertyChanged("ID_DESC_PLA_OC")
        End Set
    End Property 

    Private _ID_DESCUENTO_PLANILLA As Int32
    <Column(Name:="Id descuento planilla", Storage:="ID_DESCUENTO_PLANILLA", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_DESCUENTO_PLANILLA() As Int32
        Get
            Return _ID_DESCUENTO_PLANILLA
        End Get
        Set(ByVal Value As Int32)
            _ID_DESCUENTO_PLANILLA = Value
            OnPropertyChanged("ID_DESCUENTO_PLANILLA")
        End Set
    End Property 

    Private _ID_DESCUENTO_PLANILLAOld As Int32
    Public Property ID_DESCUENTO_PLANILLAOld() As Int32
        Get
            Return _ID_DESCUENTO_PLANILLAOld
        End Get
        Set(ByVal Value As Int32)
            _ID_DESCUENTO_PLANILLAOld = Value
        End Set
    End Property 

    Private _fkID_DESCUENTO_PLANILLA As DESCUENTOS_PLANILLA
    Public Property fkID_DESCUENTO_PLANILLA() As DESCUENTOS_PLANILLA
        Get
            Return _fkID_DESCUENTO_PLANILLA
        End Get
        Set(ByVal Value As DESCUENTOS_PLANILLA)
            _fkID_DESCUENTO_PLANILLA = Value
        End Set
    End Property 

    Private _ID_ORDEN_COMBUS As Int32
    <Column(Name:="Id orden combus", Storage:="ID_ORDEN_COMBUS", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_ORDEN_COMBUS() As Int32
        Get
            Return _ID_ORDEN_COMBUS
        End Get
        Set(ByVal Value As Int32)
            _ID_ORDEN_COMBUS = Value
            OnPropertyChanged("ID_ORDEN_COMBUS")
        End Set
    End Property 

    Private _ID_ORDEN_COMBUSOld As Int32
    Public Property ID_ORDEN_COMBUSOld() As Int32
        Get
            Return _ID_ORDEN_COMBUSOld
        End Get
        Set(ByVal Value As Int32)
            _ID_ORDEN_COMBUSOld = Value
        End Set
    End Property 

    Private _fkID_ORDEN_COMBUS As ORDEN_COMBUSTIBLE
    Public Property fkID_ORDEN_COMBUS() As ORDEN_COMBUSTIBLE
        Get
            Return _fkID_ORDEN_COMBUS
        End Get
        Set(ByVal Value As ORDEN_COMBUSTIBLE)
            _fkID_ORDEN_COMBUS = Value
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
