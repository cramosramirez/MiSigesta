''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.CUENTA_PROVEEDOR
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row CUENTA_PROVEEDOR en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	17/01/2014	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="CUENTA_PROVEEDOR")> Public Class CUENTA_PROVEEDOR
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_CUENTA_PROVEEDOR As Int32, aCUENTA As String, aCODIGO As String, aID_TIPO_PROVEEDOR As Int32, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime)
        Me._ID_CUENTA_PROVEEDOR = aID_CUENTA_PROVEEDOR
        Me._CUENTA = aCUENTA
        Me._CODIGO = aCODIGO
        Me._ID_TIPO_PROVEEDOR = aID_TIPO_PROVEEDOR
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
    End Sub

#Region " Properties "

    Private _ID_CUENTA_PROVEEDOR As Int32
    <Column(Name:="Id cuenta proveedor", Storage:="ID_CUENTA_PROVEEDOR", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_CUENTA_PROVEEDOR() As Int32
        Get
            Return _ID_CUENTA_PROVEEDOR
        End Get
        Set(ByVal Value As Int32)
            _ID_CUENTA_PROVEEDOR = Value
            OnPropertyChanged("ID_CUENTA_PROVEEDOR")
        End Set
    End Property 

    Private _CUENTA As String
    <Column(Name:="Cuenta", Storage:="CUENTA", DbType:="VARCHAR(20) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 20)> _
    Public Property CUENTA() As String
        Get
            Return _CUENTA
        End Get
        Set(ByVal Value As String)
            _CUENTA = Value
            OnPropertyChanged("CUENTA")
        End Set
    End Property 

    Private _CUENTAOld As String
    Public Property CUENTAOld() As String
        Get
            Return _CUENTAOld
        End Get
        Set(ByVal Value As String)
            _CUENTAOld = Value
        End Set
    End Property 

    Private _CODIGO As String
    <Column(Name:="Codigo", Storage:="CODIGO", DbType:="VARCHAR(10) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 10)> _
    Public Property CODIGO() As String
        Get
            Return _CODIGO
        End Get
        Set(ByVal Value As String)
            _CODIGO = Value
            OnPropertyChanged("CODIGO")
        End Set
    End Property 

    Private _CODIGOOld As String
    Public Property CODIGOOld() As String
        Get
            Return _CODIGOOld
        End Get
        Set(ByVal Value As String)
            _CODIGOOld = Value
        End Set
    End Property 

    Private _ID_TIPO_PROVEEDOR As Int32
    <Column(Name:="Id tipo proveedor", Storage:="ID_TIPO_PROVEEDOR", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_TIPO_PROVEEDOR() As Int32
        Get
            Return _ID_TIPO_PROVEEDOR
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_PROVEEDOR = Value
            OnPropertyChanged("ID_TIPO_PROVEEDOR")
        End Set
    End Property 

    Private _ID_TIPO_PROVEEDOROld As Int32
    Public Property ID_TIPO_PROVEEDOROld() As Int32
        Get
            Return _ID_TIPO_PROVEEDOROld
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_PROVEEDOROld = Value
        End Set
    End Property 

    Private _fkID_TIPO_PROVEEDOR As TIPO_PROVEEDOR
    Public Property fkID_TIPO_PROVEEDOR() As TIPO_PROVEEDOR
        Get
            Return _fkID_TIPO_PROVEEDOR
        End Get
        Set(ByVal Value As TIPO_PROVEEDOR)
            _fkID_TIPO_PROVEEDOR = Value
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
