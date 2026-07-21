''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.ORDEN_COMBUSTIBLE_FAC_ANUL
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row ORDEN_COMBUSTIBLE_FAC_ANUL en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	30/10/2018	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="ORDEN_COMBUSTIBLE_FAC_ANUL")> Public Class ORDEN_COMBUSTIBLE_FAC_ANUL
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_ORDEN_COMBUS_FAC_ANUL As Int32, aID_ORDEN_COMBUS As Int32, aNO_FACTURA_CCF As String, aFECHA_DESPACHO As DateTime, aFECHA_ANULACION As DateTime, aMOTIVO_ANULACION As String, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime, aMONTO_FACTURA As Decimal)
        Me._ID_ORDEN_COMBUS_FAC_ANUL = aID_ORDEN_COMBUS_FAC_ANUL
        Me._ID_ORDEN_COMBUS = aID_ORDEN_COMBUS
        Me._NO_FACTURA_CCF = aNO_FACTURA_CCF
        Me._FECHA_DESPACHO = aFECHA_DESPACHO
        Me._FECHA_ANULACION = aFECHA_ANULACION
        Me._MOTIVO_ANULACION = aMOTIVO_ANULACION
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
        Me._MONTO_FACTURA = aMONTO_FACTURA
    End Sub

#Region " Properties "

    Private _ID_ORDEN_COMBUS_FAC_ANUL As Int32
    <Column(Name:="Id orden combus fac anul", Storage:="ID_ORDEN_COMBUS_FAC_ANUL", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_ORDEN_COMBUS_FAC_ANUL() As Int32
        Get
            Return _ID_ORDEN_COMBUS_FAC_ANUL
        End Get
        Set(ByVal Value As Int32)
            _ID_ORDEN_COMBUS_FAC_ANUL = Value
            OnPropertyChanged("ID_ORDEN_COMBUS_FAC_ANUL")
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

    Private _NO_FACTURA_CCF As String
    <Column(Name:="No factura ccf", Storage:="NO_FACTURA_CCF", DbType:="VARCHAR(30) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 30)> _
    Public Property NO_FACTURA_CCF() As String
        Get
            Return _NO_FACTURA_CCF
        End Get
        Set(ByVal Value As String)
            _NO_FACTURA_CCF = Value
            OnPropertyChanged("NO_FACTURA_CCF")
        End Set
    End Property 

    Private _NO_FACTURA_CCFOld As String
    Public Property NO_FACTURA_CCFOld() As String
        Get
            Return _NO_FACTURA_CCFOld
        End Get
        Set(ByVal Value As String)
            _NO_FACTURA_CCFOld = Value
        End Set
    End Property 

    Private _FECHA_DESPACHO As DateTime
    <Column(Name:="Fecha despacho", Storage:="FECHA_DESPACHO", DbType:="DATETIME NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
    Public Property FECHA_DESPACHO() As DateTime
        Get
            Return _FECHA_DESPACHO
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_DESPACHO = Value
            OnPropertyChanged("FECHA_DESPACHO")
        End Set
    End Property 

    Private _FECHA_DESPACHOOld As DateTime
    Public Property FECHA_DESPACHOOld() As DateTime
        Get
            Return _FECHA_DESPACHOOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_DESPACHOOld = Value
        End Set
    End Property 

    Private _FECHA_ANULACION As DateTime
    <Column(Name:="Fecha anulacion", Storage:="FECHA_ANULACION", DbType:="DATETIME NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
    Public Property FECHA_ANULACION() As DateTime
        Get
            Return _FECHA_ANULACION
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_ANULACION = Value
            OnPropertyChanged("FECHA_ANULACION")
        End Set
    End Property 

    Private _FECHA_ANULACIONOld As DateTime
    Public Property FECHA_ANULACIONOld() As DateTime
        Get
            Return _FECHA_ANULACIONOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_ANULACIONOld = Value
        End Set
    End Property 

    Private _MOTIVO_ANULACION As String
    <Column(Name:="Motivo anulacion", Storage:="MOTIVO_ANULACION", DbType:="VARCHAR(1000) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 1000)> _
    Public Property MOTIVO_ANULACION() As String
        Get
            Return _MOTIVO_ANULACION
        End Get
        Set(ByVal Value As String)
            _MOTIVO_ANULACION = Value
            OnPropertyChanged("MOTIVO_ANULACION")
        End Set
    End Property 

    Private _MOTIVO_ANULACIONOld As String
    Public Property MOTIVO_ANULACIONOld() As String
        Get
            Return _MOTIVO_ANULACIONOld
        End Get
        Set(ByVal Value As String)
            _MOTIVO_ANULACIONOld = Value
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

    Private _MONTO_FACTURA As Decimal
    <Column(Name:="Monto factura", Storage:="MONTO_FACTURA", DbType:="NUMERIC(15,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=15, Scale:=2)> _
    Public Property MONTO_FACTURA() As Decimal
        Get
            Return _MONTO_FACTURA
        End Get
        Set(ByVal Value As Decimal)
            _MONTO_FACTURA = Value
            OnPropertyChanged("MONTO_FACTURA")
        End Set
    End Property 

    Private _MONTO_FACTURAOld As Decimal
    Public Property MONTO_FACTURAOld() As Decimal
        Get
            Return _MONTO_FACTURAOld
        End Get
        Set(ByVal Value As Decimal)
            _MONTO_FACTURAOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
