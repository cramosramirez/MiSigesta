''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.ORDEN_COMBUSTIBLE_PROD
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row ORDEN_COMBUSTIBLE_PROD en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	30/10/2018	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="ORDEN_COMBUSTIBLE_PROD")> Public Class ORDEN_COMBUSTIBLE_PROD
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_ORDEN_COMBUSTIBLE_PROD As Int32, aID_ORDEN_COMBUS As Int32, aID_PRODUCTO As Int32, aCANTIDAD As Decimal, aPRECIO_VENTA As Decimal, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime, aNOMBRE_PRODUCTO As String)
        Me._ID_ORDEN_COMBUSTIBLE_PROD = aID_ORDEN_COMBUSTIBLE_PROD
        Me._ID_ORDEN_COMBUS = aID_ORDEN_COMBUS
        Me._ID_PRODUCTO = aID_PRODUCTO
        Me._CANTIDAD = aCANTIDAD
        Me._PRECIO_VENTA = aPRECIO_VENTA
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
        Me._NOMBRE_PRODUCTO = aNOMBRE_PRODUCTO
    End Sub

#Region " Properties "

    Private _ID_ORDEN_COMBUSTIBLE_PROD As Int32
    <Column(Name:="Id orden combustible prod", Storage:="ID_ORDEN_COMBUSTIBLE_PROD", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_ORDEN_COMBUSTIBLE_PROD() As Int32
        Get
            Return _ID_ORDEN_COMBUSTIBLE_PROD
        End Get
        Set(ByVal Value As Int32)
            _ID_ORDEN_COMBUSTIBLE_PROD = Value
            OnPropertyChanged("ID_ORDEN_COMBUSTIBLE_PROD")
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

    Private _ID_PRODUCTO As Int32
    <Column(Name:="Id producto", Storage:="ID_PRODUCTO", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_PRODUCTO() As Int32
        Get
            Return _ID_PRODUCTO
        End Get
        Set(ByVal Value As Int32)
            _ID_PRODUCTO = Value
            OnPropertyChanged("ID_PRODUCTO")
        End Set
    End Property 

    Private _ID_PRODUCTOOld As Int32
    Public Property ID_PRODUCTOOld() As Int32
        Get
            Return _ID_PRODUCTOOld
        End Get
        Set(ByVal Value As Int32)
            _ID_PRODUCTOOld = Value
        End Set
    End Property 

    Private _fkID_PRODUCTO As PRODUCTO_COMBUSTIBLE
    Public Property fkID_PRODUCTO() As PRODUCTO_COMBUSTIBLE
        Get
            Return _fkID_PRODUCTO
        End Get
        Set(ByVal Value As PRODUCTO_COMBUSTIBLE)
            _fkID_PRODUCTO = Value
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

    Private _NOMBRE_PRODUCTO As String
    <Column(Name:="NOMBRE_PRODUCTO", Storage:="NOMBRE_PRODUCTO", DbType:="VARCHAR(200)", Id:=False), _
     DataObjectField(False, False, True, 200)> _
    Public Property NOMBRE_PRODUCTO() As String
        Get
            Return _NOMBRE_PRODUCTO
        End Get
        Set(ByVal Value As String)
            _NOMBRE_PRODUCTO = Value
            OnPropertyChanged("NOMBRE_PRODUCTO")
        End Set
    End Property

    Private _NOMBRE_PRODUCTOOld As String
    Public Property NOMBRE_PRODUCTOOld() As String
        Get
            Return _NOMBRE_PRODUCTOOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_PRODUCTOOld = Value
        End Set
    End Property

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
