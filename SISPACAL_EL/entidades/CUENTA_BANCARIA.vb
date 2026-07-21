''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.CUENTA_BANCARIA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row CUENTA_BANCARIA en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	05/12/2013	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="CUENTA_BANCARIA")> Public Class CUENTA_BANCARIA
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_CUENTA As Int32, aNO_CUENTA As String, aCODIBANCO As Int32, aCUENTA_CONTABLE As String, aDESCRIPCION_CUENTA As String, aACTIVO As Boolean, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime)
        Me._ID_CUENTA = aID_CUENTA
        Me._NO_CUENTA = aNO_CUENTA
        Me._CODIBANCO = aCODIBANCO
        Me._CUENTA_CONTABLE = aCUENTA_CONTABLE
        Me._DESCRIPCION_CUENTA = aDESCRIPCION_CUENTA
        Me._ACTIVO = aACTIVO
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
    End Sub

#Region " Properties "

    Private _ID_CUENTA As Int32
    <Column(Name:="Id cuenta", Storage:="ID_CUENTA", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_CUENTA() As Int32
        Get
            Return _ID_CUENTA
        End Get
        Set(ByVal Value As Int32)
            _ID_CUENTA = Value
            OnPropertyChanged("ID_CUENTA")
        End Set
    End Property 

    Private _NO_CUENTA As String
    <Column(Name:="No cuenta", Storage:="NO_CUENTA", DbType:="VARCHAR(50) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 50)> _
    Public Property NO_CUENTA() As String
        Get
            Return _NO_CUENTA
        End Get
        Set(ByVal Value As String)
            _NO_CUENTA = Value
            OnPropertyChanged("NO_CUENTA")
        End Set
    End Property 

    Private _NO_CUENTAOld As String
    Public Property NO_CUENTAOld() As String
        Get
            Return _NO_CUENTAOld
        End Get
        Set(ByVal Value As String)
            _NO_CUENTAOld = Value
        End Set
    End Property 

    Private _CODIBANCO As Int32
    <Column(Name:="Codibanco", Storage:="CODIBANCO", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property CODIBANCO() As Int32
        Get
            Return _CODIBANCO
        End Get
        Set(ByVal Value As Int32)
            _CODIBANCO = Value
            OnPropertyChanged("CODIBANCO")
        End Set
    End Property 

    Private _CODIBANCOOld As Int32
    Public Property CODIBANCOOld() As Int32
        Get
            Return _CODIBANCOOld
        End Get
        Set(ByVal Value As Int32)
            _CODIBANCOOld = Value
        End Set
    End Property 

    Private _fkCODIBANCO As BANCOS
    Public Property fkCODIBANCO() As BANCOS
        Get
            Return _fkCODIBANCO
        End Get
        Set(ByVal Value As BANCOS)
            _fkCODIBANCO = Value
        End Set
    End Property 

    Private _CUENTA_CONTABLE As String
    <Column(Name:="Cuenta contable", Storage:="CUENTA_CONTABLE", DbType:="VARCHAR(100) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 100)> _
    Public Property CUENTA_CONTABLE() As String
        Get
            Return _CUENTA_CONTABLE
        End Get
        Set(ByVal Value As String)
            _CUENTA_CONTABLE = Value
            OnPropertyChanged("CUENTA_CONTABLE")
        End Set
    End Property 

    Private _CUENTA_CONTABLEOld As String
    Public Property CUENTA_CONTABLEOld() As String
        Get
            Return _CUENTA_CONTABLEOld
        End Get
        Set(ByVal Value As String)
            _CUENTA_CONTABLEOld = Value
        End Set
    End Property 

    Private _DESCRIPCION_CUENTA As String
    <Column(Name:="Descripcion cuenta", Storage:="DESCRIPCION_CUENTA", DbType:="VARCHAR(200) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 200)> _
    Public Property DESCRIPCION_CUENTA() As String
        Get
            Return _DESCRIPCION_CUENTA
        End Get
        Set(ByVal Value As String)
            _DESCRIPCION_CUENTA = Value
            OnPropertyChanged("DESCRIPCION_CUENTA")
        End Set
    End Property 

    Private _DESCRIPCION_CUENTAOld As String
    Public Property DESCRIPCION_CUENTAOld() As String
        Get
            Return _DESCRIPCION_CUENTAOld
        End Get
        Set(ByVal Value As String)
            _DESCRIPCION_CUENTAOld = Value
        End Set
    End Property 

    Private _ACTIVO As Boolean
    <Column(Name:="Activo", Storage:="ACTIVO", DbType:="BIT NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 1)> _
    Public Property ACTIVO() As Boolean
        Get
            Return _ACTIVO
        End Get
        Set(ByVal Value As Boolean)
            _ACTIVO = Value
            OnPropertyChanged("ACTIVO")
        End Set
    End Property 

    Private _ACTIVOOld As Boolean
    Public Property ACTIVOOld() As Boolean
        Get
            Return _ACTIVOOld
        End Get
        Set(ByVal Value As Boolean)
            _ACTIVOOld = Value
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
