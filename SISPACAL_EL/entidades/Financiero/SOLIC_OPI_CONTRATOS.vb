''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.SOLIC_OPI_CONTRATOS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row SOLIC_OPI_CONTRATOS en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	31/05/2017	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="SOLIC_OPI_CONTRATOS")> Public Class SOLIC_OPI_CONTRATOS
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_OPI_CONTRATO As Int32, aID_OPI As Int32, aCODICONTRATO As String)
        Me._ID_OPI_CONTRATO = aID_OPI_CONTRATO
        Me._ID_OPI = aID_OPI
        Me._CODICONTRATO = aCODICONTRATO
    End Sub

#Region " Properties "

    Private _ID_OPI_CONTRATO As Int32
    <Column(Name:="Id opi contrato", Storage:="ID_OPI_CONTRATO", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_OPI_CONTRATO() As Int32
        Get
            Return _ID_OPI_CONTRATO
        End Get
        Set(ByVal Value As Int32)
            _ID_OPI_CONTRATO = Value
            OnPropertyChanged("ID_OPI_CONTRATO")
        End Set
    End Property 

    Private _ID_OPI As Int32
    <Column(Name:="Id opi", Storage:="ID_OPI", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_OPI() As Int32
        Get
            Return _ID_OPI
        End Get
        Set(ByVal Value As Int32)
            _ID_OPI = Value
            OnPropertyChanged("ID_OPI")
        End Set
    End Property 

    Private _ID_OPIOld As Int32
    Public Property ID_OPIOld() As Int32
        Get
            Return _ID_OPIOld
        End Get
        Set(ByVal Value As Int32)
            _ID_OPIOld = Value
        End Set
    End Property 

    Private _fkID_OPI As SOLIC_OPI
    Public Property fkID_OPI() As SOLIC_OPI
        Get
            Return _fkID_OPI
        End Get
        Set(ByVal Value As SOLIC_OPI)
            _fkID_OPI = Value
        End Set
    End Property 

    Private _CODICONTRATO As String
    <Column(Name:="Codicontrato", Storage:="CODICONTRATO", DbType:="CHAR(13)", Id:=False), _
     DataObjectField(False, False, True, 13)> _
    Public Property CODICONTRATO() As String
        Get
            Return _CODICONTRATO
        End Get
        Set(ByVal Value As String)
            _CODICONTRATO = Value
            OnPropertyChanged("CODICONTRATO")
        End Set
    End Property 

    Private _CODICONTRATOOld As String
    Public Property CODICONTRATOOld() As String
        Get
            Return _CODICONTRATOOld
        End Get
        Set(ByVal Value As String)
            _CODICONTRATOOld = Value
        End Set
    End Property 

    Private _fkCODICONTRATO As CONTRATO
    Public Property fkCODICONTRATO() As CONTRATO
        Get
            Return _fkCODICONTRATO
        End Get
        Set(ByVal Value As CONTRATO)
            _fkCODICONTRATO = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
