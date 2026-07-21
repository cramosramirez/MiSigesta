''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.REQDETA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row REQDETA en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	08/05/2015	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="REQDETA")> Public Class REQDETA
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_REQDETA As Int32, aID_REQENCA As Int32, aCODIGO As String, aCANTIDAD As String, aUNIDAD As String, aDESCRIPCION As String, aOBSERVACION As String, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime)
        Me._ID_REQDETA = aID_REQDETA
        Me._ID_REQENCA = aID_REQENCA
        Me._CODIGO = aCODIGO
        Me._CANTIDAD = aCANTIDAD
        Me._UNIDAD = aUNIDAD
        Me._DESCRIPCION = aDESCRIPCION
        Me._OBSERVACION = aOBSERVACION
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
    End Sub

#Region " Properties "

    Private _ID_REQDETA As Int32
    <Column(Name:="Id reqdeta", Storage:="ID_REQDETA", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_REQDETA() As Int32
        Get
            Return _ID_REQDETA
        End Get
        Set(ByVal Value As Int32)
            _ID_REQDETA = Value
            OnPropertyChanged("ID_REQDETA")
        End Set
    End Property 

    Private _ID_REQENCA As Int32
    <Column(Name:="Id reqenca", Storage:="ID_REQENCA", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_REQENCA() As Int32
        Get
            Return _ID_REQENCA
        End Get
        Set(ByVal Value As Int32)
            _ID_REQENCA = Value
            OnPropertyChanged("ID_REQENCA")
        End Set
    End Property 

    Private _ID_REQENCAOld As Int32
    Public Property ID_REQENCAOld() As Int32
        Get
            Return _ID_REQENCAOld
        End Get
        Set(ByVal Value As Int32)
            _ID_REQENCAOld = Value
        End Set
    End Property 

    Private _fkID_REQENCA As REQENCA
    Public Property fkID_REQENCA() As REQENCA
        Get
            Return _fkID_REQENCA
        End Get
        Set(ByVal Value As REQENCA)
            _fkID_REQENCA = Value
        End Set
    End Property 

    Private _CODIGO As String
    <Column(Name:="Codigo", Storage:="CODIGO", DbType:="VARCHAR(50)", Id:=False), _
     DataObjectField(False, False, True, 50)> _
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

    Private _CANTIDAD As String
    <Column(Name:="Cantidad", Storage:="CANTIDAD", DbType:="VARCHAR(10)", Id:=False), _
     DataObjectField(False, False, True, 10)> _
    Public Property CANTIDAD() As String
        Get
            Return _CANTIDAD
        End Get
        Set(ByVal Value As String)
            _CANTIDAD = Value
            OnPropertyChanged("CANTIDAD")
        End Set
    End Property 

    Private _CANTIDADOld As String
    Public Property CANTIDADOld() As String
        Get
            Return _CANTIDADOld
        End Get
        Set(ByVal Value As String)
            _CANTIDADOld = Value
        End Set
    End Property 

    Private _UNIDAD As String
    <Column(Name:="Unidad", Storage:="UNIDAD", DbType:="VARCHAR(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
    Public Property UNIDAD() As String
        Get
            Return _UNIDAD
        End Get
        Set(ByVal Value As String)
            _UNIDAD = Value
            OnPropertyChanged("UNIDAD")
        End Set
    End Property 

    Private _UNIDADOld As String
    Public Property UNIDADOld() As String
        Get
            Return _UNIDADOld
        End Get
        Set(ByVal Value As String)
            _UNIDADOld = Value
        End Set
    End Property 

    Private _DESCRIPCION As String
    <Column(Name:="Descripcion", Storage:="DESCRIPCION", DbType:="VARCHAR(300)", Id:=False), _
     DataObjectField(False, False, True, 300)> _
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

    Private _OBSERVACION As String
    <Column(Name:="Observacion", Storage:="OBSERVACION", DbType:="VARCHAR(1000)", Id:=False), _
     DataObjectField(False, False, True, 1000)> _
    Public Property OBSERVACION() As String
        Get
            Return _OBSERVACION
        End Get
        Set(ByVal Value As String)
            _OBSERVACION = Value
            OnPropertyChanged("OBSERVACION")
        End Set
    End Property 

    Private _OBSERVACIONOld As String
    Public Property OBSERVACIONOld() As String
        Get
            Return _OBSERVACIONOld
        End Get
        Set(ByVal Value As String)
            _OBSERVACIONOld = Value
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
