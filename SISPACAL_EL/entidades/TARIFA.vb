''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.TARIFA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row TARIFA en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	29/09/2013	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="TARIFA")> Public Class TARIFA
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aCODITARIFA As String, aCORTA As Decimal, aLARGA As Decimal, aUSER_CREA As Int32, aFECHA_CREA As DateTime, aUSER_ACT As Int32, aFECHA_ACT As DateTime)
        Me._CODITARIFA = aCODITARIFA
        Me._CORTA = aCORTA
        Me._LARGA = aLARGA
        Me._USER_CREA = aUSER_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USER_ACT = aUSER_ACT
        Me._FECHA_ACT = aFECHA_ACT
    End Sub

#Region " Properties "

    Private _CODITARIFA As String
    <Column(Name:="Coditarifa", Storage:="CODITARIFA", DbType:="CHAR(6) NOT NULL", Id:=True), _
     DataObjectField(True, False, False, 6)> _
    Public Property CODITARIFA() As String
        Get
            Return _CODITARIFA
        End Get
        Set(ByVal Value As String)
            _CODITARIFA = Value
            OnPropertyChanged("CODITARIFA")
        End Set
    End Property 

    Private _CORTA As Decimal
    <Column(Name:="Corta", Storage:="CORTA", DbType:="NUMERIC(6,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=6, Scale:=2)> _
    Public Property CORTA() As Decimal
        Get
            Return _CORTA
        End Get
        Set(ByVal Value As Decimal)
            _CORTA = Value
            OnPropertyChanged("CORTA")
        End Set
    End Property 

    Private _CORTAOld As Decimal
    Public Property CORTAOld() As Decimal
        Get
            Return _CORTAOld
        End Get
        Set(ByVal Value As Decimal)
            _CORTAOld = Value
        End Set
    End Property 

    Private _LARGA As Decimal
    <Column(Name:="Larga", Storage:="LARGA", DbType:="NUMERIC(6,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=6, Scale:=2)> _
    Public Property LARGA() As Decimal
        Get
            Return _LARGA
        End Get
        Set(ByVal Value As Decimal)
            _LARGA = Value
            OnPropertyChanged("LARGA")
        End Set
    End Property 

    Private _LARGAOld As Decimal
    Public Property LARGAOld() As Decimal
        Get
            Return _LARGAOld
        End Get
        Set(ByVal Value As Decimal)
            _LARGAOld = Value
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

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
