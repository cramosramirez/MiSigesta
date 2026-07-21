''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.TIPOS_GENERALES
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row TIPOS_GENERALES en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	09/09/2014	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="TIPOS_GENERALES")> Public Class TIPOS_GENERALES
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_TIPO As Int32, aID_TIPO_TABLA As Int32, aID_TIPO_PADRE As Int32, aNOM_TIPO As String, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime)
        Me._ID_TIPO = aID_TIPO
        Me._ID_TIPO_TABLA = aID_TIPO_TABLA
        Me._ID_TIPO_PADRE = aID_TIPO_PADRE
        Me._NOM_TIPO = aNOM_TIPO
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
    End Sub

#Region " Properties "

    Private _ID_TIPO As Int32
    <Column(Name:="Id tipo", Storage:="ID_TIPO", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_TIPO() As Int32
        Get
            Return _ID_TIPO
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO = Value
            OnPropertyChanged("ID_TIPO")
        End Set
    End Property 

    Private _ID_TIPO_TABLA As Int32
    <Column(Name:="Id tipo tabla", Storage:="ID_TIPO_TABLA", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_TIPO_TABLA() As Int32
        Get
            Return _ID_TIPO_TABLA
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_TABLA = Value
            OnPropertyChanged("ID_TIPO_TABLA")
        End Set
    End Property 

    Private _ID_TIPO_TABLAOld As Int32
    Public Property ID_TIPO_TABLAOld() As Int32
        Get
            Return _ID_TIPO_TABLAOld
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_TABLAOld = Value
        End Set
    End Property 

    Private _fkID_TIPO_TABLA As TIPOS_GENERALES
    Public Property fkID_TIPO_TABLA() As TIPOS_GENERALES
        Get
            Return _fkID_TIPO_TABLA
        End Get
        Set(ByVal Value As TIPOS_GENERALES)
            _fkID_TIPO_TABLA = Value
        End Set
    End Property 

    Private _ID_TIPO_PADRE As Int32
    <Column(Name:="Id tipo padre", Storage:="ID_TIPO_PADRE", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_TIPO_PADRE() As Int32
        Get
            Return _ID_TIPO_PADRE
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_PADRE = Value
            OnPropertyChanged("ID_TIPO_PADRE")
        End Set
    End Property 

    Private _ID_TIPO_PADREOld As Int32
    Public Property ID_TIPO_PADREOld() As Int32
        Get
            Return _ID_TIPO_PADREOld
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_PADREOld = Value
        End Set
    End Property 

    Private _fkID_TIPO_PADRE As TIPOS_GENERALES
    Public Property fkID_TIPO_PADRE() As TIPOS_GENERALES
        Get
            Return _fkID_TIPO_PADRE
        End Get
        Set(ByVal Value As TIPOS_GENERALES)
            _fkID_TIPO_PADRE = Value
        End Set
    End Property 

    Private _NOM_TIPO As String
    <Column(Name:="Nom tipo", Storage:="NOM_TIPO", DbType:="VARCHAR(100) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 100)> _
    Public Property NOM_TIPO() As String
        Get
            Return _NOM_TIPO
        End Get
        Set(ByVal Value As String)
            _NOM_TIPO = Value
            OnPropertyChanged("NOM_TIPO")
        End Set
    End Property 

    Private _NOM_TIPOOld As String
    Public Property NOM_TIPOOld() As String
        Get
            Return _NOM_TIPOOld
        End Get
        Set(ByVal Value As String)
            _NOM_TIPOOld = Value
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
