''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.FACTURA_SERVICIOS_DETA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row FACTURA_SERVICIOS_DETA en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	15/07/2015	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="FACTURA_SERVICIOS_DETA")> Public Class FACTURA_SERVICIOS_DETA
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_FACTURA_SERVICIOS_DETA As Int32, aID_FACTURA_SERVICIOS_ENCA As Int32, aDESCRIPCION As String, aCANTIDAD As Decimal, aPRECIO_UNITARIO As Decimal, aEXENTO As Decimal, aAFECTO As Decimal, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime)
        Me._ID_FACTURA_SERVICIOS_DETA = aID_FACTURA_SERVICIOS_DETA
        Me._ID_FACTURA_SERVICIOS_ENCA = aID_FACTURA_SERVICIOS_ENCA
        Me._DESCRIPCION = aDESCRIPCION
        Me._CANTIDAD = aCANTIDAD
        Me._PRECIO_UNITARIO = aPRECIO_UNITARIO
        Me._EXENTO = aEXENTO
        Me._AFECTO = aAFECTO
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
    End Sub

#Region " Properties "

    Private _ID_FACTURA_SERVICIOS_DETA As Int32
    <Column(Name:="Id factura servicios deta", Storage:="ID_FACTURA_SERVICIOS_DETA", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_FACTURA_SERVICIOS_DETA() As Int32
        Get
            Return _ID_FACTURA_SERVICIOS_DETA
        End Get
        Set(ByVal Value As Int32)
            _ID_FACTURA_SERVICIOS_DETA = Value
            OnPropertyChanged("ID_FACTURA_SERVICIOS_DETA")
        End Set
    End Property 

    Private _ID_FACTURA_SERVICIOS_ENCA As Int32
    <Column(Name:="Id factura servicios enca", Storage:="ID_FACTURA_SERVICIOS_ENCA", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_FACTURA_SERVICIOS_ENCA() As Int32
        Get
            Return _ID_FACTURA_SERVICIOS_ENCA
        End Get
        Set(ByVal Value As Int32)
            _ID_FACTURA_SERVICIOS_ENCA = Value
            OnPropertyChanged("ID_FACTURA_SERVICIOS_ENCA")
        End Set
    End Property 

    Private _ID_FACTURA_SERVICIOS_ENCAOld As Int32
    Public Property ID_FACTURA_SERVICIOS_ENCAOld() As Int32
        Get
            Return _ID_FACTURA_SERVICIOS_ENCAOld
        End Get
        Set(ByVal Value As Int32)
            _ID_FACTURA_SERVICIOS_ENCAOld = Value
        End Set
    End Property 

    Private _fkID_FACTURA_SERVICIOS_ENCA As FACTURA_SERVICIOS_ENCA
    Public Property fkID_FACTURA_SERVICIOS_ENCA() As FACTURA_SERVICIOS_ENCA
        Get
            Return _fkID_FACTURA_SERVICIOS_ENCA
        End Get
        Set(ByVal Value As FACTURA_SERVICIOS_ENCA)
            _fkID_FACTURA_SERVICIOS_ENCA = Value
        End Set
    End Property 

    Private _DESCRIPCION As String
    <Column(Name:="Descripcion", Storage:="DESCRIPCION", DbType:="VARCHAR(300) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 300)> _
    Public Property DESCRIPCION() As String
        Get
            Return _DESCRIPCION
        End Get
        Set(ByVal Value As String)
            _DESCRIPCION = Value
            OnPropertyChanged("DESCRIPCION")
        End Set
    End Property 

    Private _DESCRIPCIONOld As String
    Public Property DESCRIPCIONOld() As String
        Get
            Return _DESCRIPCIONOld
        End Get
        Set(ByVal Value As String)
            _DESCRIPCIONOld = Value
        End Set
    End Property 

    Private _CANTIDAD As Decimal
    <Column(Name:="Cantidad", Storage:="CANTIDAD", DbType:="NUMERIC(10,4)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=4)> _
    Public Property CANTIDAD() As Decimal
        Get
            Return _CANTIDAD
        End Get
        Set(ByVal Value As Decimal)
            _CANTIDAD = Value
            OnPropertyChanged("CANTIDAD")
        End Set
    End Property 

    Private _CANTIDADOld As Decimal
    Public Property CANTIDADOld() As Decimal
        Get
            Return _CANTIDADOld
        End Get
        Set(ByVal Value As Decimal)
            _CANTIDADOld = Value
        End Set
    End Property 

    Private _PRECIO_UNITARIO As Decimal
    <Column(Name:="Precio unitario", Storage:="PRECIO_UNITARIO", DbType:="NUMERIC(10,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)> _
    Public Property PRECIO_UNITARIO() As Decimal
        Get
            Return _PRECIO_UNITARIO
        End Get
        Set(ByVal Value As Decimal)
            _PRECIO_UNITARIO = Value
            OnPropertyChanged("PRECIO_UNITARIO")
        End Set
    End Property 

    Private _PRECIO_UNITARIOOld As Decimal
    Public Property PRECIO_UNITARIOOld() As Decimal
        Get
            Return _PRECIO_UNITARIOOld
        End Get
        Set(ByVal Value As Decimal)
            _PRECIO_UNITARIOOld = Value
        End Set
    End Property 

    Private _EXENTO As Decimal
    <Column(Name:="Exento", Storage:="EXENTO", DbType:="NUMERIC(10,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)> _
    Public Property EXENTO() As Decimal
        Get
            Return _EXENTO
        End Get
        Set(ByVal Value As Decimal)
            _EXENTO = Value
            OnPropertyChanged("EXENTO")
        End Set
    End Property 

    Private _EXENTOOld As Decimal
    Public Property EXENTOOld() As Decimal
        Get
            Return _EXENTOOld
        End Get
        Set(ByVal Value As Decimal)
            _EXENTOOld = Value
        End Set
    End Property 

    Private _AFECTO As Decimal
    <Column(Name:="Afecto", Storage:="AFECTO", DbType:="NUMERIC(10,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)> _
    Public Property AFECTO() As Decimal
        Get
            Return _AFECTO
        End Get
        Set(ByVal Value As Decimal)
            _AFECTO = Value
            OnPropertyChanged("AFECTO")
        End Set
    End Property 

    Private _AFECTOOld As Decimal
    Public Property AFECTOOld() As Decimal
        Get
            Return _AFECTOOld
        End Get
        Set(ByVal Value As Decimal)
            _AFECTOOld = Value
        End Set
    End Property 

    Private _USUARIO_CREA As String
    <Column(Name:="Usuario crea", Storage:="USUARIO_CREA", DbType:="VARCHAR(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
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
    <Column(Name:="Usuario act", Storage:="USUARIO_ACT", DbType:="VARCHAR(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
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
