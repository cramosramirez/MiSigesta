''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.UBICACION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row UBICACION en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	29/09/2013	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="UBICACION")> Public Class UBICACION
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aCODIUBICACION As String, aCODITARIFA As String, aDEPARTAMENTO As String, aMUNICIPIO As String, aCANTON As String, aKILOMETRO As Decimal, aUSER_CREA As Int32, aFECHA_CREA As DateTime, aUSER_ACT As Int32, aFECHA_ACT As DateTime)
        Me._CODIUBICACION = aCODIUBICACION
        Me._CODITARIFA = aCODITARIFA
        Me._DEPARTAMENTO = aDEPARTAMENTO
        Me._MUNICIPIO = aMUNICIPIO
        Me._CANTON = aCANTON
        Me._KILOMETRO = aKILOMETRO
        Me._USER_CREA = aUSER_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USER_ACT = aUSER_ACT
        Me._FECHA_ACT = aFECHA_ACT
    End Sub

#Region " Properties "

    Private _CODIUBICACION As String
    <Column(Name:="Codiubicacion", Storage:="CODIUBICACION", DbType:="CHAR(6) NOT NULL", Id:=True), _
     DataObjectField(True, False, False, 6)> _
    Public Property CODIUBICACION() As String
        Get
            Return _CODIUBICACION
        End Get
        Set(ByVal Value As String)
            _CODIUBICACION = Value
            OnPropertyChanged("CODIUBICACION")
        End Set
    End Property 

    Private _CODITARIFA As String
    <Column(Name:="Coditarifa", Storage:="CODITARIFA", DbType:="CHAR(6)", Id:=False), _
     DataObjectField(False, False, True, 6)> _
    Public Property CODITARIFA() As String
        Get
            Return _CODITARIFA
        End Get
        Set(ByVal Value As String)
            _CODITARIFA = Value
            OnPropertyChanged("CODITARIFA")
        End Set
    End Property 

    Private _CODITARIFAOld As String
    Public Property CODITARIFAOld() As String
        Get
            Return _CODITARIFAOld
        End Get
        Set(ByVal Value As String)
            _CODITARIFAOld = Value
        End Set
    End Property 

    Private _fkCODITARIFA As TARIFA
    Public Property fkCODITARIFA() As TARIFA
        Get
            Return _fkCODITARIFA
        End Get
        Set(ByVal Value As TARIFA)
            _fkCODITARIFA = Value
        End Set
    End Property 

    Private _DEPARTAMENTO As String
    <Column(Name:="Departamento", Storage:="DEPARTAMENTO", DbType:="CHAR(36)", Id:=False), _
     DataObjectField(False, False, True, 36)> _
    Public Property DEPARTAMENTO() As String
        Get
            Return _DEPARTAMENTO
        End Get
        Set(ByVal Value As String)
            _DEPARTAMENTO = Value
            OnPropertyChanged("DEPARTAMENTO")
        End Set
    End Property 

    Private _DEPARTAMENTOOld As String
    Public Property DEPARTAMENTOOld() As String
        Get
            Return _DEPARTAMENTOOld
        End Get
        Set(ByVal Value As String)
            _DEPARTAMENTOOld = Value
        End Set
    End Property 

    Private _MUNICIPIO As String
    <Column(Name:="Municipio", Storage:="MUNICIPIO", DbType:="CHAR(36)", Id:=False), _
     DataObjectField(False, False, True, 36)> _
    Public Property MUNICIPIO() As String
        Get
            Return _MUNICIPIO
        End Get
        Set(ByVal Value As String)
            _MUNICIPIO = Value
            OnPropertyChanged("MUNICIPIO")
        End Set
    End Property 

    Private _MUNICIPIOOld As String
    Public Property MUNICIPIOOld() As String
        Get
            Return _MUNICIPIOOld
        End Get
        Set(ByVal Value As String)
            _MUNICIPIOOld = Value
        End Set
    End Property 

    Private _CANTON As String
    <Column(Name:="Canton", Storage:="CANTON", DbType:="CHAR(36)", Id:=False), _
     DataObjectField(False, False, True, 36)> _
    Public Property CANTON() As String
        Get
            Return _CANTON
        End Get
        Set(ByVal Value As String)
            _CANTON = Value
            OnPropertyChanged("CANTON")
        End Set
    End Property 

    Private _CANTONOld As String
    Public Property CANTONOld() As String
        Get
            Return _CANTONOld
        End Get
        Set(ByVal Value As String)
            _CANTONOld = Value
        End Set
    End Property 

    Private _KILOMETRO As Decimal
    <Column(Name:="Kilometro", Storage:="KILOMETRO", DbType:="NUMERIC(6,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=6, Scale:=2)> _
    Public Property KILOMETRO() As Decimal
        Get
            Return _KILOMETRO
        End Get
        Set(ByVal Value As Decimal)
            _KILOMETRO = Value
            OnPropertyChanged("KILOMETRO")
        End Set
    End Property 

    Private _KILOMETROOld As Decimal
    Public Property KILOMETROOld() As Decimal
        Get
            Return _KILOMETROOld
        End Get
        Set(ByVal Value As Decimal)
            _KILOMETROOld = Value
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
