''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.PLANTILLA_TRANS_COLU
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row PLANTILLA_TRANS_COLU en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	14/11/2017	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="PLANTILLA_TRANS_COLU")> Public Class PLANTILLA_TRANS_COLU
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_PLANTI_COLU As Int32, aUID_REFERENCIA As Guid, aORDEN_HOJA As Int32, aORDEN_DESCTO As Int32, aID_PROVEE As Int32, aCODIBANCO As Int32, aID_CUENTA_FINAN As Int32, aCONCEPTO As String, aUSUARIO_CREA As String, aFECHA_CREA As DateTime)
        Me._ID_PLANTI_COLU = aID_PLANTI_COLU
        Me._UID_REFERENCIA = aUID_REFERENCIA
        Me._ORDEN_HOJA = aORDEN_HOJA
        Me._ORDEN_DESCTO = aORDEN_DESCTO
        Me._ID_PROVEE = aID_PROVEE
        Me._CODIBANCO = aCODIBANCO
        Me._ID_CUENTA_FINAN = aID_CUENTA_FINAN
        Me._CONCEPTO = aCONCEPTO
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
    End Sub

#Region " Properties "

    Private _ID_PLANTI_COLU As Int32
    <Column(Name:="Id planti colu", Storage:="ID_PLANTI_COLU", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_PLANTI_COLU() As Int32
        Get
            Return _ID_PLANTI_COLU
        End Get
        Set(ByVal Value As Int32)
            _ID_PLANTI_COLU = Value
            OnPropertyChanged("ID_PLANTI_COLU")
        End Set
    End Property 

    Private _UID_REFERENCIA As Guid
    <Column(Name:="Uid referencia", Storage:="UID_REFERENCIA", DbType:="UNIQUEIDENTIFIER(36, 0)", Id:=False), _
     DataObjectField(False, False, True, 16)> _
    Public Property UID_REFERENCIA() As Guid
        Get
            Return _UID_REFERENCIA
        End Get
        Set(ByVal Value As Guid)
            _UID_REFERENCIA = Value
            OnPropertyChanged("UID_REFERENCIA")
        End Set
    End Property 

    Private _UID_REFERENCIAOld As Guid
    Public Property UID_REFERENCIAOld() As Guid
        Get
            Return _UID_REFERENCIAOld
        End Get
        Set(ByVal Value As Guid)
            _UID_REFERENCIAOld = Value
        End Set
    End Property 

    Private _ORDEN_HOJA As Int32
    <Column(Name:="Orden hoja", Storage:="ORDEN_HOJA", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ORDEN_HOJA() As Int32
        Get
            Return _ORDEN_HOJA
        End Get
        Set(ByVal Value As Int32)
            _ORDEN_HOJA = Value
            OnPropertyChanged("ORDEN_HOJA")
        End Set
    End Property 

    Private _ORDEN_HOJAOld As Int32
    Public Property ORDEN_HOJAOld() As Int32
        Get
            Return _ORDEN_HOJAOld
        End Get
        Set(ByVal Value As Int32)
            _ORDEN_HOJAOld = Value
        End Set
    End Property 

    Private _ORDEN_DESCTO As Int32
    <Column(Name:="Orden descto", Storage:="ORDEN_DESCTO", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ORDEN_DESCTO() As Int32
        Get
            Return _ORDEN_DESCTO
        End Get
        Set(ByVal Value As Int32)
            _ORDEN_DESCTO = Value
            OnPropertyChanged("ORDEN_DESCTO")
        End Set
    End Property 

    Private _ORDEN_DESCTOOld As Int32
    Public Property ORDEN_DESCTOOld() As Int32
        Get
            Return _ORDEN_DESCTOOld
        End Get
        Set(ByVal Value As Int32)
            _ORDEN_DESCTOOld = Value
        End Set
    End Property 

    Private _ID_PROVEE As Int32
    <Column(Name:="Id provee", Storage:="ID_PROVEE", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_PROVEE() As Int32
        Get
            Return _ID_PROVEE
        End Get
        Set(ByVal Value As Int32)
            _ID_PROVEE = Value
            OnPropertyChanged("ID_PROVEE")
        End Set
    End Property 

    Private _ID_PROVEEOld As Int32
    Public Property ID_PROVEEOld() As Int32
        Get
            Return _ID_PROVEEOld
        End Get
        Set(ByVal Value As Int32)
            _ID_PROVEEOld = Value
        End Set
    End Property 

    Private _CODIBANCO As Int32
    <Column(Name:="Codibanco", Storage:="CODIBANCO", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
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

    Private _ID_CUENTA_FINAN As Int32
    <Column(Name:="Id cuenta finan", Storage:="ID_CUENTA_FINAN", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_CUENTA_FINAN() As Int32
        Get
            Return _ID_CUENTA_FINAN
        End Get
        Set(ByVal Value As Int32)
            _ID_CUENTA_FINAN = Value
            OnPropertyChanged("ID_CUENTA_FINAN")
        End Set
    End Property 

    Private _ID_CUENTA_FINANOld As Int32
    Public Property ID_CUENTA_FINANOld() As Int32
        Get
            Return _ID_CUENTA_FINANOld
        End Get
        Set(ByVal Value As Int32)
            _ID_CUENTA_FINANOld = Value
        End Set
    End Property 

    Private _CONCEPTO As String
    <Column(Name:="Concepto", Storage:="CONCEPTO", DbType:="VARCHAR(200)", Id:=False), _
     DataObjectField(False, False, True, 200)> _
    Public Property CONCEPTO() As String
        Get
            Return _CONCEPTO
        End Get
        Set(ByVal Value As String)
            _CONCEPTO = Value
            OnPropertyChanged("CONCEPTO")
        End Set
    End Property 

    Private _CONCEPTOOld As String
    Public Property CONCEPTOOld() As String
        Get
            Return _CONCEPTOOld
        End Get
        Set(ByVal Value As String)
            _CONCEPTOOld = Value
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
    <Column(Name:="Fecha crea", Storage:="FECHA_CREA", DbType:="DATETIME", Id:=False), _
     DataObjectField(False, False, True)> _
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

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
