''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.SOLIC_ANTICIPO_ZAFRA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row SOLIC_ANTICIPO_ZAFRA en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	20/09/2017	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="SOLIC_ANTICIPO_ZAFRA")> Public Class SOLIC_ANTICIPO_ZAFRA
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_ANTI_ZAFRA As Int32, aID_ANTICIPO As Int32, aID_ZAFRA As Int32, aFECHA_ULTMOV As DateTime, aCUOTA As Decimal, aUSUARIO_CREA As String, aFECHA_CREA As DateTime)
        Me._ID_ANTI_ZAFRA = aID_ANTI_ZAFRA
        Me._ID_ANTICIPO = aID_ANTICIPO
        Me._ID_ZAFRA = aID_ZAFRA
        Me._FECHA_ULTMOV = aFECHA_ULTMOV
        Me._CUOTA = aCUOTA
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
    End Sub

#Region " Properties "

    Private _ID_ANTI_ZAFRA As Int32
    <Column(Name:="Id anti zafra", Storage:="ID_ANTI_ZAFRA", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_ANTI_ZAFRA() As Int32
        Get
            Return _ID_ANTI_ZAFRA
        End Get
        Set(ByVal Value As Int32)
            _ID_ANTI_ZAFRA = Value
            OnPropertyChanged("ID_ANTI_ZAFRA")
        End Set
    End Property 

    Private _ID_ANTICIPO As Int32
    <Column(Name:="Id anticipo", Storage:="ID_ANTICIPO", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_ANTICIPO() As Int32
        Get
            Return _ID_ANTICIPO
        End Get
        Set(ByVal Value As Int32)
            _ID_ANTICIPO = Value
            OnPropertyChanged("ID_ANTICIPO")
        End Set
    End Property 

    Private _ID_ANTICIPOOld As Int32
    Public Property ID_ANTICIPOOld() As Int32
        Get
            Return _ID_ANTICIPOOld
        End Get
        Set(ByVal Value As Int32)
            _ID_ANTICIPOOld = Value
        End Set
    End Property 

    Private _fkID_ANTICIPO As SOLIC_ANTICIPO
    Public Property fkID_ANTICIPO() As SOLIC_ANTICIPO
        Get
            Return _fkID_ANTICIPO
        End Get
        Set(ByVal Value As SOLIC_ANTICIPO)
            _fkID_ANTICIPO = Value
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

    Private _fkID_ZAFRA As ZAFRA
    Public Property fkID_ZAFRA() As ZAFRA
        Get
            Return _fkID_ZAFRA
        End Get
        Set(ByVal Value As ZAFRA)
            _fkID_ZAFRA = Value
        End Set
    End Property 

    Private _FECHA_ULTMOV As DateTime
    <Column(Name:="Fecha ultmov", Storage:="FECHA_ULTMOV", DbType:="DATETIME NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
    Public Property FECHA_ULTMOV() As DateTime
        Get
            Return _FECHA_ULTMOV
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_ULTMOV = Value
            OnPropertyChanged("FECHA_ULTMOV")
        End Set
    End Property 

    Private _FECHA_ULTMOVOld As DateTime
    Public Property FECHA_ULTMOVOld() As DateTime
        Get
            Return _FECHA_ULTMOVOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_ULTMOVOld = Value
        End Set
    End Property 

    Private _CUOTA As Decimal
    <Column(Name:="Cuota", Storage:="CUOTA", DbType:="NUMERIC(20,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)> _
    Public Property CUOTA() As Decimal
        Get
            Return _CUOTA
        End Get
        Set(ByVal Value As Decimal)
            _CUOTA = Value
            OnPropertyChanged("CUOTA")
        End Set
    End Property 

    Private _CUOTAOld As Decimal
    Public Property CUOTAOld() As Decimal
        Get
            Return _CUOTAOld
        End Get
        Set(ByVal Value As Decimal)
            _CUOTAOld = Value
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

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
