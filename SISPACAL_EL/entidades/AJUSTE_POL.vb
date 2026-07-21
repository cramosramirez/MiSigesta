''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.AJUSTE_POL
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row AJUSTE_POL en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	01/10/2013	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="AJUSTE_POL")> Public Class AJUSTE_POL
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aDENSIDAD As Int32, aDENSIAPARE As Decimal, aPESOESP As Decimal, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime)
        Me._DENSIDAD = aDENSIDAD
        Me._DENSIAPARE = aDENSIAPARE
        Me._PESOESP = aPESOESP
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
    End Sub

#Region " Properties "

    Private _DENSIDAD As Int32
    <Column(Name:="Densidad", Storage:="DENSIDAD", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property DENSIDAD() As Int32
        Get
            Return _DENSIDAD
        End Get
        Set(ByVal Value As Int32)
            _DENSIDAD = Value
            OnPropertyChanged("DENSIDAD")
        End Set
    End Property 

    Private _DENSIAPARE As Decimal
    <Column(Name:="Densiapare", Storage:="DENSIAPARE", DbType:="NUMERIC(10,6) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=6)> _
    Public Property DENSIAPARE() As Decimal
        Get
            Return _DENSIAPARE
        End Get
        Set(ByVal Value As Decimal)
            _DENSIAPARE = Value
            OnPropertyChanged("DENSIAPARE")
        End Set
    End Property 

    Private _DENSIAPAREOld As Decimal
    Public Property DENSIAPAREOld() As Decimal
        Get
            Return _DENSIAPAREOld
        End Get
        Set(ByVal Value As Decimal)
            _DENSIAPAREOld = Value
        End Set
    End Property 

    Private _PESOESP As Decimal
    <Column(Name:="Pesoesp", Storage:="PESOESP", DbType:="NUMERIC(10,6) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=6)> _
    Public Property PESOESP() As Decimal
        Get
            Return _PESOESP
        End Get
        Set(ByVal Value As Decimal)
            _PESOESP = Value
            OnPropertyChanged("PESOESP")
        End Set
    End Property 

    Private _PESOESPOld As Decimal
    Public Property PESOESPOld() As Decimal
        Get
            Return _PESOESPOld
        End Get
        Set(ByVal Value As Decimal)
            _PESOESPOld = Value
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
