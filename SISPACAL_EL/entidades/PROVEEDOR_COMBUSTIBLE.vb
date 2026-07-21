''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.PROVEEDOR_COMBUSTIBLE
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row PROVEEDOR_COMBUSTIBLE en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	18/11/2013	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="PROVEEDOR_COMBUSTIBLE")> Public Class PROVEEDOR_COMBUSTIBLE
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_PROVEEDOR_COMBUS As Int32, aNOMBRE_PROVEEDOR_COMBUS As String, aNIT As String, aDUI As String, aCREDITO_FISCAL As String, aES_CONTRIBUYENTE As Boolean, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime)
        Me._ID_PROVEEDOR_COMBUS = aID_PROVEEDOR_COMBUS
        Me._NOMBRE_PROVEEDOR_COMBUS = aNOMBRE_PROVEEDOR_COMBUS
        Me._NIT = aNIT
        Me._DUI = aDUI
        Me._CREDITO_FISCAL = aCREDITO_FISCAL
        Me._ES_CONTRIBUYENTE = aES_CONTRIBUYENTE
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
    End Sub

#Region " Properties "

    Private _ID_PROVEEDOR_COMBUS As Int32
    <Column(Name:="Id proveedor combus", Storage:="ID_PROVEEDOR_COMBUS", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_PROVEEDOR_COMBUS() As Int32
        Get
            Return _ID_PROVEEDOR_COMBUS
        End Get
        Set(ByVal Value As Int32)
            _ID_PROVEEDOR_COMBUS = Value
            OnPropertyChanged("ID_PROVEEDOR_COMBUS")
        End Set
    End Property 

    Private _NOMBRE_PROVEEDOR_COMBUS As String
    <Column(Name:="Nombre proveedor combus", Storage:="NOMBRE_PROVEEDOR_COMBUS", DbType:="VARCHAR(200) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 200)> _
    Public Property NOMBRE_PROVEEDOR_COMBUS() As String
        Get
            Return _NOMBRE_PROVEEDOR_COMBUS
        End Get
        Set(ByVal Value As String)
            _NOMBRE_PROVEEDOR_COMBUS = Value
            OnPropertyChanged("NOMBRE_PROVEEDOR_COMBUS")
        End Set
    End Property 

    Private _NOMBRE_PROVEEDOR_COMBUSOld As String
    Public Property NOMBRE_PROVEEDOR_COMBUSOld() As String
        Get
            Return _NOMBRE_PROVEEDOR_COMBUSOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_PROVEEDOR_COMBUSOld = Value
        End Set
    End Property 

    Private _NIT As String
    <Column(Name:="Nit", Storage:="NIT", DbType:="CHAR(14)", Id:=False), _
     DataObjectField(False, False, True, 14)> _
    Public Property NIT() As String
        Get
            Return _NIT
        End Get
        Set(ByVal Value As String)
            _NIT = Value
            OnPropertyChanged("NIT")
        End Set
    End Property 

    Private _NITOld As String
    Public Property NITOld() As String
        Get
            Return _NITOld
        End Get
        Set(ByVal Value As String)
            _NITOld = Value
        End Set
    End Property 

    Private _DUI As String
    <Column(Name:="Dui", Storage:="DUI", DbType:="CHAR(9)", Id:=False), _
     DataObjectField(False, False, True, 9)> _
    Public Property DUI() As String
        Get
            Return _DUI
        End Get
        Set(ByVal Value As String)
            _DUI = Value
            OnPropertyChanged("DUI")
        End Set
    End Property 

    Private _DUIOld As String
    Public Property DUIOld() As String
        Get
            Return _DUIOld
        End Get
        Set(ByVal Value As String)
            _DUIOld = Value
        End Set
    End Property 

    Private _CREDITO_FISCAL As String
    <Column(Name:="Credito fiscal", Storage:="CREDITO_FISCAL", DbType:="VARCHAR(20)", Id:=False), _
     DataObjectField(False, False, True, 20)> _
    Public Property CREDITO_FISCAL() As String
        Get
            Return _CREDITO_FISCAL
        End Get
        Set(ByVal Value As String)
            _CREDITO_FISCAL = Value
            OnPropertyChanged("CREDITO_FISCAL")
        End Set
    End Property 

    Private _CREDITO_FISCALOld As String
    Public Property CREDITO_FISCALOld() As String
        Get
            Return _CREDITO_FISCALOld
        End Get
        Set(ByVal Value As String)
            _CREDITO_FISCALOld = Value
        End Set
    End Property 

    Private _ES_CONTRIBUYENTE As Boolean
    <Column(Name:="Es contribuyente", Storage:="ES_CONTRIBUYENTE", DbType:="BIT NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 1)> _
    Public Property ES_CONTRIBUYENTE() As Boolean
        Get
            Return _ES_CONTRIBUYENTE
        End Get
        Set(ByVal Value As Boolean)
            _ES_CONTRIBUYENTE = Value
            OnPropertyChanged("ES_CONTRIBUYENTE")
        End Set
    End Property 

    Private _ES_CONTRIBUYENTEOld As Boolean
    Public Property ES_CONTRIBUYENTEOld() As Boolean
        Get
            Return _ES_CONTRIBUYENTEOld
        End Get
        Set(ByVal Value As Boolean)
            _ES_CONTRIBUYENTEOld = Value
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
