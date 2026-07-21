''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.CARGADORA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row CARGADORA en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	18/11/2013	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="CARGADORA")> Public Class CARGADORA
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_CARGADORA As Int32, aNOMBRE As String, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime, aES_PROPIA As Boolean, aID_PROVEEDOR_CARGA As Int32, aID_TIPO_CARGADORA As Int32, aTARIFA_SIN_TRIPULACION As Decimal, aTARIFA_CON_TRIPULACION As Decimal, aTARIFA_NORMAL As Decimal, aID_TIPO_ALZA As Int32, aPRECALIFI_AUTO As Boolean, ByVal aACTIVO As Boolean)
        Me._ID_CARGADORA = aID_CARGADORA
        Me._NOMBRE = aNOMBRE
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
        Me._ES_PROPIA = aES_PROPIA
        Me._ID_PROVEEDOR_CARGA = aID_PROVEEDOR_CARGA
        Me._ID_TIPO_CARGADORA = aID_TIPO_CARGADORA
        Me._TARIFA_SIN_TRIPULACION = aTARIFA_SIN_TRIPULACION
        Me._TARIFA_CON_TRIPULACION = aTARIFA_CON_TRIPULACION
        Me._TARIFA_NORMAL = aTARIFA_NORMAL
        Me._ID_TIPO_ALZA = aID_TIPO_ALZA
        Me._PRECALIFI_AUTO = aPRECALIFI_AUTO
        Me._ACTIVO = aACTIVO
    End Sub

#Region " Properties "

    Private _ID_CARGADORA As Int32
    <Column(Name:="Id cargadora", Storage:="ID_CARGADORA", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_CARGADORA() As Int32
        Get
            Return _ID_CARGADORA
        End Get
        Set(ByVal Value As Int32)
            _ID_CARGADORA = Value
            OnPropertyChanged("ID_CARGADORA")
        End Set
    End Property 

    Private _NOMBRE As String
    <Column(Name:="Nombre", Storage:="NOMBRE", DbType:="VARCHAR(40) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 40)> _
    Public Property NOMBRE() As String
        Get
            Return _NOMBRE
        End Get
        Set(ByVal Value As String)
            _NOMBRE = Value
            OnPropertyChanged("NOMBRE")
        End Set
    End Property 

    Private _NOMBREOld As String
    Public Property NOMBREOld() As String
        Get
            Return _NOMBREOld
        End Get
        Set(ByVal Value As String)
            _NOMBREOld = Value
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

    Private _ES_PROPIA As Boolean
    <Column(Name:="Es propia", Storage:="ES_PROPIA", DBType:="BIT", Id:=False),
     DataObjectField(False, False, True, 1)>
    Public Property ES_PROPIA() As Boolean
        Get
            Return _ES_PROPIA
        End Get
        Set(ByVal Value As Boolean)
            _ES_PROPIA = Value
            OnPropertyChanged("ES_PROPIA")
        End Set
    End Property 

    Private _ES_PROPIAOld As Boolean
    Public Property ES_PROPIAOld() As Boolean
        Get
            Return _ES_PROPIAOld
        End Get
        Set(ByVal Value As Boolean)
            _ES_PROPIAOld = Value
        End Set
    End Property 

    Private _ID_PROVEEDOR_CARGA As Int32
    <Column(Name:="Id proveedor carga", Storage:="ID_PROVEEDOR_CARGA", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_PROVEEDOR_CARGA() As Int32
        Get
            Return _ID_PROVEEDOR_CARGA
        End Get
        Set(ByVal Value As Int32)
            _ID_PROVEEDOR_CARGA = Value
            OnPropertyChanged("ID_PROVEEDOR_CARGA")
        End Set
    End Property 

    Private _ID_PROVEEDOR_CARGAOld As Int32
    Public Property ID_PROVEEDOR_CARGAOld() As Int32
        Get
            Return _ID_PROVEEDOR_CARGAOld
        End Get
        Set(ByVal Value As Int32)
            _ID_PROVEEDOR_CARGAOld = Value
        End Set
    End Property 

    Private _fkID_PROVEEDOR_CARGA As PROVEEDOR_CARGA
    Public Property fkID_PROVEEDOR_CARGA() As PROVEEDOR_CARGA
        Get
            Return _fkID_PROVEEDOR_CARGA
        End Get
        Set(ByVal Value As PROVEEDOR_CARGA)
            _fkID_PROVEEDOR_CARGA = Value
        End Set
    End Property 

    Private _ID_TIPO_CARGADORA As Int32
    <Column(Name:="Id tipo cargadora", Storage:="ID_TIPO_CARGADORA", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_TIPO_CARGADORA() As Int32
        Get
            Return _ID_TIPO_CARGADORA
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_CARGADORA = Value
            OnPropertyChanged("ID_TIPO_CARGADORA")
        End Set
    End Property 

    Private _ID_TIPO_CARGADORAOld As Int32
    Public Property ID_TIPO_CARGADORAOld() As Int32
        Get
            Return _ID_TIPO_CARGADORAOld
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_CARGADORAOld = Value
        End Set
    End Property 

    Private _fkID_TIPO_CARGADORA As TIPO_CARGADORA
    Public Property fkID_TIPO_CARGADORA() As TIPO_CARGADORA
        Get
            Return _fkID_TIPO_CARGADORA
        End Get
        Set(ByVal Value As TIPO_CARGADORA)
            _fkID_TIPO_CARGADORA = Value
        End Set
    End Property 

    Private _TARIFA_SIN_TRIPULACION As Decimal
    <Column(Name:="Tarifa sin tripulacion", Storage:="TARIFA_SIN_TRIPULACION", DbType:="NUMERIC(5,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=5, Scale:=2)> _
    Public Property TARIFA_SIN_TRIPULACION() As Decimal
        Get
            Return _TARIFA_SIN_TRIPULACION
        End Get
        Set(ByVal Value As Decimal)
            _TARIFA_SIN_TRIPULACION = Value
            OnPropertyChanged("TARIFA_SIN_TRIPULACION")
        End Set
    End Property 

    Private _TARIFA_SIN_TRIPULACIONOld As Decimal
    Public Property TARIFA_SIN_TRIPULACIONOld() As Decimal
        Get
            Return _TARIFA_SIN_TRIPULACIONOld
        End Get
        Set(ByVal Value As Decimal)
            _TARIFA_SIN_TRIPULACIONOld = Value
        End Set
    End Property 

    Private _TARIFA_CON_TRIPULACION As Decimal
    <Column(Name:="Tarifa con tripulacion", Storage:="TARIFA_CON_TRIPULACION", DbType:="NUMERIC(5,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=5, Scale:=2)> _
    Public Property TARIFA_CON_TRIPULACION() As Decimal
        Get
            Return _TARIFA_CON_TRIPULACION
        End Get
        Set(ByVal Value As Decimal)
            _TARIFA_CON_TRIPULACION = Value
            OnPropertyChanged("TARIFA_CON_TRIPULACION")
        End Set
    End Property 

    Private _TARIFA_CON_TRIPULACIONOld As Decimal
    Public Property TARIFA_CON_TRIPULACIONOld() As Decimal
        Get
            Return _TARIFA_CON_TRIPULACIONOld
        End Get
        Set(ByVal Value As Decimal)
            _TARIFA_CON_TRIPULACIONOld = Value
        End Set
    End Property 

    Private _TARIFA_NORMAL As Decimal
    <Column(Name:="Tarifa normal", Storage:="TARIFA_NORMAL", DbType:="NUMERIC(5,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=5, Scale:=2)> _
    Public Property TARIFA_NORMAL() As Decimal
        Get
            Return _TARIFA_NORMAL
        End Get
        Set(ByVal Value As Decimal)
            _TARIFA_NORMAL = Value
            OnPropertyChanged("TARIFA_NORMAL")
        End Set
    End Property 

    Private _TARIFA_NORMALOld As Decimal
    Public Property TARIFA_NORMALOld() As Decimal
        Get
            Return _TARIFA_NORMALOld
        End Get
        Set(ByVal Value As Decimal)
            _TARIFA_NORMALOld = Value
        End Set
    End Property

    Private _ID_TIPO_ALZA As Int32
    <Column(Name:="Id tipo alza", Storage:="ID_TIPO_ALZA", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_TIPO_ALZA() As Int32
        Get
            Return _ID_TIPO_ALZA
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_ALZA = Value
            OnPropertyChanged("ID_TIPO_ALZA")
        End Set
    End Property
    Private _ID_TIPO_ALZAOld As Int32
    Public Property ID_TIPO_ALZAOld() As Int32
        Get
            Return _ID_TIPO_ALZAOld
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_ALZAOld = Value
        End Set
    End Property

    Private _PRECALIFI_AUTO As Boolean
    <Column(Name:="PRECALIFI_AUTO", Storage:="PRECALIFI_AUTO", DBType:="BIT", Id:=False),
     DataObjectField(False, False, True, 1)>
    Public Property PRECALIFI_AUTO() As Boolean
        Get
            Return _PRECALIFI_AUTO
        End Get
        Set(ByVal Value As Boolean)
            _PRECALIFI_AUTO = Value
            OnPropertyChanged("PRECALIFI_AUTO")
        End Set
    End Property

    Private _PRECALIFI_AUTOOld As Boolean
    Public Property PRECALIFI_AUTOOld() As Boolean
        Get
            Return _PRECALIFI_AUTOOld
        End Get
        Set(ByVal Value As Boolean)
            _PRECALIFI_AUTOOld = Value
        End Set
    End Property

    Private _ACTIVO As Boolean
    <Column(Name:="Activo", Storage:="ACTIVO", DBType:="BIT NOT NULL", Id:=False),
     DataObjectField(False, False, False, 1)>
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

    Private _TARIFA_PAGAR_CARGADORA As Decimal
    <Column(Name:="Tarifa pagar cargadora", Storage:="TARIFA_PAGAR_CARGADORA", DBType:="NUMERIC(5,2)", Id:=False),
     DataObjectField(False, False, True), Precision(Precision:=5, Scale:=2)>
    Public Property TARIFA_PAGAR_CARGADORA() As Decimal
        Get
            Return _TARIFA_PAGAR_CARGADORA
        End Get
        Set(ByVal Value As Decimal)
            _TARIFA_PAGAR_CARGADORA = Value
            OnPropertyChanged("TARIFA_PAGAR_CARGADORA")
        End Set
    End Property

    Private _TARIFA_PAGAR_CARGADORAOld As Decimal
    Public Property TARIFA_PAGAR_CARGADORAOld() As Decimal
        Get
            Return _TARIFA_PAGAR_CARGADORAOld
        End Get
        Set(ByVal Value As Decimal)
            _TARIFA_PAGAR_CARGADORAOld = Value
        End Set
    End Property
#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
