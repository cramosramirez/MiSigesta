''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.LABFAB_VARSXANALISIS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row LABFAB_VARSXANALISIS en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	20/11/2015	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="LABFAB_VARSXANALISIS")> Public Class LABFAB_VARSXANALISIS
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_VARXANALISIS As Int32, aID_ANALISISXDIA As Int32, aID_VAR As Int32, aNOMBRE_VAR As String, aVALOR As Decimal, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime)
        Me._ID_VARXANALISIS = aID_VARXANALISIS
        Me._ID_ANALISISXDIA = aID_ANALISISXDIA
        Me._ID_VAR = aID_VAR
        Me._NOMBRE_VAR = aNOMBRE_VAR
        Me._VALOR = aVALOR
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
    End Sub

#Region " Properties "

    Private _ID_VARXANALISIS As Int32
    <Column(Name:="Id varxanalisis", Storage:="ID_VARXANALISIS", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_VARXANALISIS() As Int32
        Get
            Return _ID_VARXANALISIS
        End Get
        Set(ByVal Value As Int32)
            _ID_VARXANALISIS = Value
            OnPropertyChanged("ID_VARXANALISIS")
        End Set
    End Property 

    Private _ID_ANALISISXDIA As Int32
    <Column(Name:="Id analisisxdia", Storage:="ID_ANALISISXDIA", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_ANALISISXDIA() As Int32
        Get
            Return _ID_ANALISISXDIA
        End Get
        Set(ByVal Value As Int32)
            _ID_ANALISISXDIA = Value
            OnPropertyChanged("ID_ANALISISXDIA")
        End Set
    End Property 

    Private _ID_ANALISISXDIAOld As Int32
    Public Property ID_ANALISISXDIAOld() As Int32
        Get
            Return _ID_ANALISISXDIAOld
        End Get
        Set(ByVal Value As Int32)
            _ID_ANALISISXDIAOld = Value
        End Set
    End Property 

    Private _fkID_ANALISISXDIA As LABFAB_ANALISISXDIA
    Public Property fkID_ANALISISXDIA() As LABFAB_ANALISISXDIA
        Get
            Return _fkID_ANALISISXDIA
        End Get
        Set(ByVal Value As LABFAB_ANALISISXDIA)
            _fkID_ANALISISXDIA = Value
        End Set
    End Property 

    Private _ID_VAR As Int32
    <Column(Name:="Id var", Storage:="ID_VAR", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_VAR() As Int32
        Get
            Return _ID_VAR
        End Get
        Set(ByVal Value As Int32)
            _ID_VAR = Value
            OnPropertyChanged("ID_VAR")
        End Set
    End Property 

    Private _ID_VAROld As Int32
    Public Property ID_VAROld() As Int32
        Get
            Return _ID_VAROld
        End Get
        Set(ByVal Value As Int32)
            _ID_VAROld = Value
        End Set
    End Property 

    Private _NOMBRE_VAR As String
    <Column(Name:="Nombre var", Storage:="NOMBRE_VAR", DbType:="VARCHAR(30) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 30)> _
    Public Property NOMBRE_VAR() As String
        Get
            Return _NOMBRE_VAR
        End Get
        Set(ByVal Value As String)
            _NOMBRE_VAR = Value
            OnPropertyChanged("NOMBRE_VAR")
        End Set
    End Property 

    Private _NOMBRE_VAROld As String
    Public Property NOMBRE_VAROld() As String
        Get
            Return _NOMBRE_VAROld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_VAROld = Value
        End Set
    End Property 

    Private _VALOR As Decimal
    <Column(Name:="Valor", Storage:="VALOR", DbType:="NUMERIC(20,8)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=8)> _
    Public Property VALOR() As Decimal
        Get
            Return _VALOR
        End Get
        Set(ByVal Value As Decimal)
            _VALOR = Value
            OnPropertyChanged("VALOR")
        End Set
    End Property 

    Private _VALOROld As Decimal
    Public Property VALOROld() As Decimal
        Get
            Return _VALOROld
        End Get
        Set(ByVal Value As Decimal)
            _VALOROld = Value
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
