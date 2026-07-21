''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.LABFAB_ANALISIS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row LABFAB_ANALISIS en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	17/11/2015	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="LABFAB_ANALISIS")> Public Class LABFAB_ANALISIS
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_ANALISIS As Int32, aID_MUESTRA As Int32, aNOMBRE_ANALISIS As String, aFORMULA As String, aOBSERVACIONES As String, aCANT_ANALISIS As Int32, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime, aORDEN_EJEC As Int32)
        Me._ID_ANALISIS = aID_ANALISIS
        Me._ID_MUESTRA = aID_MUESTRA
        Me._NOMBRE_ANALISIS = aNOMBRE_ANALISIS
        Me._FORMULA = aFORMULA
        Me._OBSERVACIONES = aOBSERVACIONES
        Me._CANT_ANALISIS = aCANT_ANALISIS
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
        Me._ORDEN_EJEC = aORDEN_EJEC
    End Sub

#Region " Properties "

    Private _ID_ANALISIS As Int32
    <Column(Name:="Id analisis", Storage:="ID_ANALISIS", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_ANALISIS() As Int32
        Get
            Return _ID_ANALISIS
        End Get
        Set(ByVal Value As Int32)
            _ID_ANALISIS = Value
            OnPropertyChanged("ID_ANALISIS")
        End Set
    End Property 

    Private _ID_MUESTRA As Int32
    <Column(Name:="Id muestra", Storage:="ID_MUESTRA", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_MUESTRA() As Int32
        Get
            Return _ID_MUESTRA
        End Get
        Set(ByVal Value As Int32)
            _ID_MUESTRA = Value
            OnPropertyChanged("ID_MUESTRA")
        End Set
    End Property 

    Private _ID_MUESTRAOld As Int32
    Public Property ID_MUESTRAOld() As Int32
        Get
            Return _ID_MUESTRAOld
        End Get
        Set(ByVal Value As Int32)
            _ID_MUESTRAOld = Value
        End Set
    End Property 

    Private _fkID_MUESTRA As LABFAB_MUESTRA
    Public Property fkID_MUESTRA() As LABFAB_MUESTRA
        Get
            Return _fkID_MUESTRA
        End Get
        Set(ByVal Value As LABFAB_MUESTRA)
            _fkID_MUESTRA = Value
        End Set
    End Property 

    Private _NOMBRE_ANALISIS As String
    <Column(Name:="Nombre analisis", Storage:="NOMBRE_ANALISIS", DbType:="VARCHAR(100) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 100)> _
    Public Property NOMBRE_ANALISIS() As String
        Get
            Return _NOMBRE_ANALISIS
        End Get
        Set(ByVal Value As String)
            _NOMBRE_ANALISIS = Value
            OnPropertyChanged("NOMBRE_ANALISIS")
        End Set
    End Property 

    Private _NOMBRE_ANALISISOld As String
    Public Property NOMBRE_ANALISISOld() As String
        Get
            Return _NOMBRE_ANALISISOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_ANALISISOld = Value
        End Set
    End Property 

    Private _FORMULA As String
    <Column(Name:="Formula", Storage:="FORMULA", DbType:="VARCHAR(200) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 200)> _
    Public Property FORMULA() As String
        Get
            Return _FORMULA
        End Get
        Set(ByVal Value As String)
            _FORMULA = Value
            OnPropertyChanged("FORMULA")
        End Set
    End Property 

    Private _FORMULAOld As String
    Public Property FORMULAOld() As String
        Get
            Return _FORMULAOld
        End Get
        Set(ByVal Value As String)
            _FORMULAOld = Value
        End Set
    End Property 

    Private _OBSERVACIONES As String
    <Column(Name:="Observaciones", Storage:="OBSERVACIONES", DbType:="VARCHAR(500) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 500)> _
    Public Property OBSERVACIONES() As String
        Get
            Return _OBSERVACIONES
        End Get
        Set(ByVal Value As String)
            _OBSERVACIONES = Value
            OnPropertyChanged("OBSERVACIONES")
        End Set
    End Property 

    Private _OBSERVACIONESOld As String
    Public Property OBSERVACIONESOld() As String
        Get
            Return _OBSERVACIONESOld
        End Get
        Set(ByVal Value As String)
            _OBSERVACIONESOld = Value
        End Set
    End Property 

    Private _CANT_ANALISIS As Int32
    <Column(Name:="Cant analisis", Storage:="CANT_ANALISIS", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property CANT_ANALISIS() As Int32
        Get
            Return _CANT_ANALISIS
        End Get
        Set(ByVal Value As Int32)
            _CANT_ANALISIS = Value
            OnPropertyChanged("CANT_ANALISIS")
        End Set
    End Property 

    Private _CANT_ANALISISOld As Int32
    Public Property CANT_ANALISISOld() As Int32
        Get
            Return _CANT_ANALISISOld
        End Get
        Set(ByVal Value As Int32)
            _CANT_ANALISISOld = Value
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



    Private _ORDEN_EJEC As Int32
    <Column(Name:="Orden Ejec", Storage:="ORDEN_EJEC", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ORDEN_EJEC() As Int32
        Get
            Return _ORDEN_EJEC
        End Get
        Set(ByVal Value As Int32)
            _ORDEN_EJEC = Value
            OnPropertyChanged("ORDEN_EJEC")
        End Set
    End Property

    Private _ORDEN_EJECOld As Int32
    Public Property ORDEN_EJECOld() As Int32
        Get
            Return _ORDEN_EJECOld
        End Get
        Set(ByVal Value As Int32)
            _ORDEN_EJECOld = Value
        End Set
    End Property



#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
