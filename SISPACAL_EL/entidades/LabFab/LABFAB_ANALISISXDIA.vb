''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.LABFAB_ANALISISXDIA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row LABFAB_ANALISISXDIA en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	20/11/2015	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="LABFAB_ANALISISXDIA")> Public Class LABFAB_ANALISISXDIA
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_ANALISISXDIA As Int32, aID_DIAZAFRA As Int32, aID_ZAFRA As Int32, aDIAZAFRA As Int32, aID_ANALISIS As Int32, aNO_ANALISIS As Int32, aVALOR As Decimal, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime)
        Me._ID_ANALISISXDIA = aID_ANALISISXDIA
        Me._ID_DIAZAFRA = aID_DIAZAFRA
        Me._ID_ZAFRA = aID_ZAFRA
        Me._DIAZAFRA = aDIAZAFRA
        Me._ID_ANALISIS = aID_ANALISIS
        Me._NO_ANALISIS = aNO_ANALISIS
        Me._VALOR = aVALOR
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
    End Sub

#Region " Properties "

    Private _ID_ANALISISXDIA As Int32
    <Column(Name:="Id analisisxdia", Storage:="ID_ANALISISXDIA", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_ANALISISXDIA() As Int32
        Get
            Return _ID_ANALISISXDIA
        End Get
        Set(ByVal Value As Int32)
            _ID_ANALISISXDIA = Value
            OnPropertyChanged("ID_ANALISISXDIA")
        End Set
    End Property 

    Private _ID_DIAZAFRA As Int32
    <Column(Name:="Id diazafra", Storage:="ID_DIAZAFRA", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_DIAZAFRA() As Int32
        Get
            Return _ID_DIAZAFRA
        End Get
        Set(ByVal Value As Int32)
            _ID_DIAZAFRA = Value
            OnPropertyChanged("ID_DIAZAFRA")
        End Set
    End Property 

    Private _ID_DIAZAFRAOld As Int32
    Public Property ID_DIAZAFRAOld() As Int32
        Get
            Return _ID_DIAZAFRAOld
        End Get
        Set(ByVal Value As Int32)
            _ID_DIAZAFRAOld = Value
        End Set
    End Property 

    Private _fkID_DIAZAFRA As LABFAB_DIAZAFRA
    Public Property fkID_DIAZAFRA() As LABFAB_DIAZAFRA
        Get
            Return _fkID_DIAZAFRA
        End Get
        Set(ByVal Value As LABFAB_DIAZAFRA)
            _fkID_DIAZAFRA = Value
        End Set
    End Property 

    Private _ID_ZAFRA As Int32
    <Column(Name:="Id zafra", Storage:="ID_ZAFRA", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_ZAFRA() As Int32
        Get
            Return _ID_ZAFRA
        End Get
        Set(ByVal Value As Int32)
            _ID_ZAFRA = Value
            OnPropertyChanged("ID_ZAFRA")
        End Set
    End Property 

    Private _ID_ZAFRAOld As Int32
    Public Property ID_ZAFRAOld() As Int32
        Get
            Return _ID_ZAFRAOld
        End Get
        Set(ByVal Value As Int32)
            _ID_ZAFRAOld = Value
        End Set
    End Property 

    Private _DIAZAFRA As Int32
    <Column(Name:="Diazafra", Storage:="DIAZAFRA", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property DIAZAFRA() As Int32
        Get
            Return _DIAZAFRA
        End Get
        Set(ByVal Value As Int32)
            _DIAZAFRA = Value
            OnPropertyChanged("DIAZAFRA")
        End Set
    End Property 

    Private _DIAZAFRAOld As Int32
    Public Property DIAZAFRAOld() As Int32
        Get
            Return _DIAZAFRAOld
        End Get
        Set(ByVal Value As Int32)
            _DIAZAFRAOld = Value
        End Set
    End Property 

    Private _ID_ANALISIS As Int32
    <Column(Name:="Id analisis", Storage:="ID_ANALISIS", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_ANALISIS() As Int32
        Get
            Return _ID_ANALISIS
        End Get
        Set(ByVal Value As Int32)
            _ID_ANALISIS = Value
            OnPropertyChanged("ID_ANALISIS")
        End Set
    End Property 

    Private _ID_ANALISISOld As Int32
    Public Property ID_ANALISISOld() As Int32
        Get
            Return _ID_ANALISISOld
        End Get
        Set(ByVal Value As Int32)
            _ID_ANALISISOld = Value
        End Set
    End Property 

    Private _fkID_ANALISIS As LABFAB_ANALISIS
    Public Property fkID_ANALISIS() As LABFAB_ANALISIS
        Get
            Return _fkID_ANALISIS
        End Get
        Set(ByVal Value As LABFAB_ANALISIS)
            _fkID_ANALISIS = Value
        End Set
    End Property 

    Private _NO_ANALISIS As Int32
    <Column(Name:="No analisis", Storage:="NO_ANALISIS", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property NO_ANALISIS() As Int32
        Get
            Return _NO_ANALISIS
        End Get
        Set(ByVal Value As Int32)
            _NO_ANALISIS = Value
            OnPropertyChanged("NO_ANALISIS")
        End Set
    End Property 

    Private _NO_ANALISISOld As Int32
    Public Property NO_ANALISISOld() As Int32
        Get
            Return _NO_ANALISISOld
        End Get
        Set(ByVal Value As Int32)
            _NO_ANALISISOld = Value
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
