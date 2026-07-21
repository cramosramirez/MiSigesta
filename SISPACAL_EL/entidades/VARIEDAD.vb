''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.VARIEDAD
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row VARIEDAD en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	09/09/2014	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="VARIEDAD")> Public Class VARIEDAD
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aCODIVARIEDA As String, aNOM_VARIEDAD As String, aDESCRP_VARIEDAD As String, aUSER_CREA As Int32, aFECHA_CREA As DateTime, aUSER_ACT As Int32, aFECHA_ACT As DateTime, aID_TIPO As Int32, aID_SUB_TIPO As Int32)
        Me._CODIVARIEDA = aCODIVARIEDA
        Me._NOM_VARIEDAD = aNOM_VARIEDAD
        Me._DESCRP_VARIEDAD = aDESCRP_VARIEDAD
        Me._USER_CREA = aUSER_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USER_ACT = aUSER_ACT
        Me._FECHA_ACT = aFECHA_ACT
        Me._ID_TIPO = aID_TIPO
        Me._ID_SUB_TIPO = aID_SUB_TIPO
    End Sub

#Region " Properties "

    Private _CODIVARIEDA As String
    <Column(Name:="Codivarieda", Storage:="CODIVARIEDA", DbType:="CHAR(3) NOT NULL", Id:=True), _
     DataObjectField(True, False, False, 3)> _
    Public Property CODIVARIEDA() As String
        Get
            Return _CODIVARIEDA
        End Get
        Set(ByVal Value As String)
            _CODIVARIEDA = Value
            OnPropertyChanged("CODIVARIEDA")
        End Set
    End Property 

    Private _NOM_VARIEDAD As String
    <Column(Name:="Nom variedad", Storage:="NOM_VARIEDAD", DbType:="VARCHAR(50) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 50)> _
    Public Property NOM_VARIEDAD() As String
        Get
            Return _NOM_VARIEDAD
        End Get
        Set(ByVal Value As String)
            _NOM_VARIEDAD = Value
            OnPropertyChanged("NOM_VARIEDAD")
        End Set
    End Property 

    Private _NOM_VARIEDADOld As String
    Public Property NOM_VARIEDADOld() As String
        Get
            Return _NOM_VARIEDADOld
        End Get
        Set(ByVal Value As String)
            _NOM_VARIEDADOld = Value
        End Set
    End Property 

    Private _DESCRP_VARIEDAD As String
    <Column(Name:="Descrp variedad", Storage:="DESCRP_VARIEDAD", DbType:="VARCHAR(50)", Id:=False), _
     DataObjectField(False, False, True, 50)> _
    Public Property DESCRP_VARIEDAD() As String
        Get
            Return _DESCRP_VARIEDAD
        End Get
        Set(ByVal Value As String)
            _DESCRP_VARIEDAD = Value
            OnPropertyChanged("DESCRP_VARIEDAD")
        End Set
    End Property 

    Private _DESCRP_VARIEDADOld As String
    Public Property DESCRP_VARIEDADOld() As String
        Get
            Return _DESCRP_VARIEDADOld
        End Get
        Set(ByVal Value As String)
            _DESCRP_VARIEDADOld = Value
        End Set
    End Property 

    Private _USER_CREA As Int32
    <Column(Name:="User crea", Storage:="USER_CREA", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property USER_CREA() As Int32
        Get
            Return _USER_CREA
        End Get
        Set(ByVal Value As Int32)
            _USER_CREA = Value
            OnPropertyChanged("USER_CREA")
        End Set
    End Property 

    Private _USER_CREAOld As Int32
    Public Property USER_CREAOld() As Int32
        Get
            Return _USER_CREAOld
        End Get
        Set(ByVal Value As Int32)
            _USER_CREAOld = Value
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

    Private _USER_ACT As Int32
    <Column(Name:="User act", Storage:="USER_ACT", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property USER_ACT() As Int32
        Get
            Return _USER_ACT
        End Get
        Set(ByVal Value As Int32)
            _USER_ACT = Value
            OnPropertyChanged("USER_ACT")
        End Set
    End Property 

    Private _USER_ACTOld As Int32
    Public Property USER_ACTOld() As Int32
        Get
            Return _USER_ACTOld
        End Get
        Set(ByVal Value As Int32)
            _USER_ACTOld = Value
        End Set
    End Property 

    Private _FECHA_ACT As DateTime
    <Column(Name:="Fecha act", Storage:="FECHA_ACT", DbType:="DATETIME", Id:=False), _
     DataObjectField(False, False, True)> _
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

    Private _ID_TIPO As Int32
    <Column(Name:="Id tipo", Storage:="ID_TIPO", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_TIPO() As Int32
        Get
            Return _ID_TIPO
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO = Value
            OnPropertyChanged("ID_TIPO")
        End Set
    End Property 

    Private _ID_TIPOOld As Int32
    Public Property ID_TIPOOld() As Int32
        Get
            Return _ID_TIPOOld
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPOOld = Value
        End Set
    End Property 

    Private _fkID_TIPO As TIPOS_GENERALES
    Public Property fkID_TIPO() As TIPOS_GENERALES
        Get
            Return _fkID_TIPO
        End Get
        Set(ByVal Value As TIPOS_GENERALES)
            _fkID_TIPO = Value
        End Set
    End Property 

    Private _ID_SUB_TIPO As Int32
    <Column(Name:="Id sub tipo", Storage:="ID_SUB_TIPO", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_SUB_TIPO() As Int32
        Get
            Return _ID_SUB_TIPO
        End Get
        Set(ByVal Value As Int32)
            _ID_SUB_TIPO = Value
            OnPropertyChanged("ID_SUB_TIPO")
        End Set
    End Property 

    Private _ID_SUB_TIPOOld As Int32
    Public Property ID_SUB_TIPOOld() As Int32
        Get
            Return _ID_SUB_TIPOOld
        End Get
        Set(ByVal Value As Int32)
            _ID_SUB_TIPOOld = Value
        End Set
    End Property 

    Private _fkID_SUB_TIPO As TIPOS_GENERALES
    Public Property fkID_SUB_TIPO() As TIPOS_GENERALES
        Get
            Return _fkID_SUB_TIPO
        End Get
        Set(ByVal Value As TIPOS_GENERALES)
            _fkID_SUB_TIPO = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
