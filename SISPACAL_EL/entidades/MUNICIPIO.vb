''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.MUNICIPIO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row MUNICIPIO en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	19/05/2014	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="MUNICIPIO")> Public Class MUNICIPIO
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aCODI_DEPTO As String, aCODI_MUNI As String, aNOMBRE_MUNI As String, aPOSICION_GEO As String, aCOORDENADAS As String, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime)
        Me._CODI_DEPTO = aCODI_DEPTO
        Me._CODI_MUNI = aCODI_MUNI
        Me._NOMBRE_MUNI = aNOMBRE_MUNI
        Me._POSICION_GEO = aPOSICION_GEO
        Me._COORDENADAS = aCOORDENADAS
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
    End Sub

#Region " Properties "

    Private _CODI_DEPTO As String
    <Column(Name:="Codi depto", Storage:="CODI_DEPTO", DbType:="CHAR(2) NOT NULL", Id:=True), _
     DataObjectField(True, False, False, 2)> _
    Public Property CODI_DEPTO() As String
        Get
            Return _CODI_DEPTO
        End Get
        Set(ByVal Value As String)
            _CODI_DEPTO = Value
            OnPropertyChanged("CODI_DEPTO")
        End Set
    End Property 

    Private _fkCODI_DEPTO As DEPARTAMENTO
    Public Property fkCODI_DEPTO() As DEPARTAMENTO
        Get
            Return _fkCODI_DEPTO
        End Get
        Set(ByVal Value As DEPARTAMENTO)
            _fkCODI_DEPTO = Value
        End Set
    End Property 

    Private _CODI_MUNI As String
    <Column(Name:="Codi muni", Storage:="CODI_MUNI", DbType:="CHAR(2) NOT NULL", Id:=True), _
     DataObjectField(True, False, False, 2)> _
    Public Property CODI_MUNI() As String
        Get
            Return _CODI_MUNI
        End Get
        Set(ByVal Value As String)
            _CODI_MUNI = Value
            OnPropertyChanged("CODI_MUNI")
        End Set
    End Property 

    Private _NOMBRE_MUNI As String
    <Column(Name:="Nombre muni", Storage:="NOMBRE_MUNI", DbType:="VARCHAR(100) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 100)> _
    Public Property NOMBRE_MUNI() As String
        Get
            Return _NOMBRE_MUNI
        End Get
        Set(ByVal Value As String)
            _NOMBRE_MUNI = Value
            OnPropertyChanged("NOMBRE_MUNI")
        End Set
    End Property 

    Private _NOMBRE_MUNIOld As String
    Public Property NOMBRE_MUNIOld() As String
        Get
            Return _NOMBRE_MUNIOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_MUNIOld = Value
        End Set
    End Property 

    Private _POSICION_GEO As String
    <Column(Name:="Posicion geo", Storage:="POSICION_GEO", DbType:="VARCHAR(500)", Id:=False), _
     DataObjectField(False, False, True, 500)> _
    Public Property POSICION_GEO() As String
        Get
            Return _POSICION_GEO
        End Get
        Set(ByVal Value As String)
            _POSICION_GEO = Value
            OnPropertyChanged("POSICION_GEO")
        End Set
    End Property 

    Private _POSICION_GEOOld As String
    Public Property POSICION_GEOOld() As String
        Get
            Return _POSICION_GEOOld
        End Get
        Set(ByVal Value As String)
            _POSICION_GEOOld = Value
        End Set
    End Property 

    Private _COORDENADAS As String
    <Column(Name:="Coordenadas", Storage:="COORDENADAS", DbType:="TEXT", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property COORDENADAS() As String
        Get
            Return _COORDENADAS
        End Get
        Set(ByVal Value As String)
            _COORDENADAS = Value
            OnPropertyChanged("COORDENADAS")
        End Set
    End Property 

    Private _COORDENADASOld As String
    Public Property COORDENADASOld() As String
        Get
            Return _COORDENADASOld
        End Get
        Set(ByVal Value As String)
            _COORDENADASOld = Value
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
    Private _CANTONMUNICIPIO As ListaCANTON
    Public Property CANTONMUNICIPIO() As ListaCANTON
        Get
            Return _CANTONMUNICIPIO
        End Get
        Set(ByVal Value As ListaCANTON)
            _CANTONMUNICIPIO = Value
        End Set
    End Property 

#End Region
#End Region
End Class
