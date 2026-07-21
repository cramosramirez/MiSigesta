''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.PROVEEDOR_CARGA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row PROVEEDOR_CARGA en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	18/11/2013	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="PROVEEDOR_CARGA")> Public Class PROVEEDOR_CARGA
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_PROVEEDOR_CARGA As Int32, aNOMBRE_PROVEEDOR_CARGA As String, aNIT As String, aDUI As String, aCREDITO_FISCAL As String, aES_CONTRIBUYENTE As Boolean, aES_INGENIO As Boolean, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime)
        Me._ID_PROVEEDOR_CARGA = aID_PROVEEDOR_CARGA
        Me._NOMBRE_PROVEEDOR_CARGA = aNOMBRE_PROVEEDOR_CARGA
        Me._NIT = aNIT
        Me._DUI = aDUI
        Me._CREDITO_FISCAL = aCREDITO_FISCAL
        Me._ES_CONTRIBUYENTE = aES_CONTRIBUYENTE
        Me._ES_INGENIO = aES_INGENIO
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
    End Sub

#Region " Properties "

    Private _ID_PROVEEDOR_CARGA As Int32
    <Column(Name:="Id proveedor carga", Storage:="ID_PROVEEDOR_CARGA", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_PROVEEDOR_CARGA() As Int32
        Get
            Return _ID_PROVEEDOR_CARGA
        End Get
        Set(ByVal Value As Int32)
            _ID_PROVEEDOR_CARGA = Value
            OnPropertyChanged("ID_PROVEEDOR_CARGA")
        End Set
    End Property 

    Private _NOMBRE_PROVEEDOR_CARGA As String
    <Column(Name:="Nombre proveedor carga", Storage:="NOMBRE_PROVEEDOR_CARGA", DbType:="VARCHAR(200) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 200)> _
    Public Property NOMBRE_PROVEEDOR_CARGA() As String
        Get
            Return _NOMBRE_PROVEEDOR_CARGA
        End Get
        Set(ByVal Value As String)
            _NOMBRE_PROVEEDOR_CARGA = Value
            OnPropertyChanged("NOMBRE_PROVEEDOR_CARGA")
        End Set
    End Property 

    Private _NOMBRE_PROVEEDOR_CARGAOld As String
    Public Property NOMBRE_PROVEEDOR_CARGAOld() As String
        Get
            Return _NOMBRE_PROVEEDOR_CARGAOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_PROVEEDOR_CARGAOld = Value
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

    Private _ES_INGENIO As Boolean
    <Column(Name:="Es ingenio", Storage:="ES_INGENIO", DbType:="BIT NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 1)> _
    Public Property ES_INGENIO() As Boolean
        Get
            Return _ES_INGENIO
        End Get
        Set(ByVal Value As Boolean)
            _ES_INGENIO = Value
            OnPropertyChanged("ES_INGENIO")
        End Set
    End Property 

    Private _ES_INGENIOOld As Boolean
    Public Property ES_INGENIOOld() As Boolean
        Get
            Return _ES_INGENIOOld
        End Get
        Set(ByVal Value As Boolean)
            _ES_INGENIOOld = Value
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



    Private _TELEFONO As String
    <Column(Name:="TELEFONO", Storage:="TELEFONO", DBType:="VARCHAR(100) NULL", Id:=False),
     DataObjectField(False, False, True, 100)>
    Public Property TELEFONO() As String
        Get
            Return _TELEFONO
        End Get
        Set(ByVal Value As String)
            _TELEFONO = Value
            OnPropertyChanged("TELEFONO")
        End Set
    End Property

    Private _TELEFONOOld As String
    Public Property TELEFONOOld() As String
        Get
            Return _TELEFONOOld
        End Get
        Set(ByVal Value As String)
            _TELEFONOOld = Value
        End Set
    End Property


    Private _ACTIVIDAD As String
    <Column(Name:="ACTIVIDAD", Storage:="ACTIVIDAD", DBType:="VARCHAR(300) NULL", Id:=False),
     DataObjectField(False, False, True, 300)>
    Public Property ACTIVIDAD() As String
        Get
            Return _ACTIVIDAD
        End Get
        Set(ByVal Value As String)
            _ACTIVIDAD = Value
            OnPropertyChanged("ACTIVIDAD")
        End Set
    End Property

    Private _ACTIVIDADOld As String
    Public Property ACTIVIDADOld() As String
        Get
            Return _ACTIVIDADOld
        End Get
        Set(ByVal Value As String)
            _ACTIVIDADOld = Value
        End Set
    End Property

    Private _DIRECCION As String
    <Column(Name:="DIRECCION", Storage:="DIRECCION", DBType:="VARCHAR(300) NULL", Id:=False),
     DataObjectField(False, False, True, 300)>
    Public Property DIRECCION() As String
        Get
            Return _DIRECCION
        End Get
        Set(ByVal Value As String)
            _DIRECCION = Value
            OnPropertyChanged("DIRECCION")
        End Set
    End Property

    Private _DIRECCIONOld As String
    Public Property DIRECCIONOld() As String
        Get
            Return _DIRECCIONOld
        End Get
        Set(ByVal Value As String)
            _DIRECCIONOld = Value
        End Set
    End Property


    Private _CORREO As String
    <Column(Name:="CORREO", Storage:="CORREO", DBType:="VARCHAR(100) NULL", Id:=False),
     DataObjectField(False, False, True, 100)>
    Public Property CORREO() As String
        Get
            Return _CORREO
        End Get
        Set(ByVal Value As String)
            _CORREO = Value
            OnPropertyChanged("CORREO")
        End Set
    End Property

    Private _CORREOOld As String
    Public Property CORREOOld() As String
        Get
            Return _CORREOOld
        End Get
        Set(ByVal Value As String)
            _CORREOOld = Value
        End Set
    End Property


    Private _CODIGO As String
    <Column(Name:="CODIGO", Storage:="CODIGO", DBType:="VARCHAR(10) NULL", Id:=False),
     DataObjectField(False, False, True, 10)>
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

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
