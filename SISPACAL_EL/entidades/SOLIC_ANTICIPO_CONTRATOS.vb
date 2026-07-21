''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.SOLIC_ANTICIPO_CONTRATOS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row SOLIC_ANTICIPO_CONTRATOS en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	31/05/2017	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="SOLIC_ANTICIPO_CONTRATOS")> Public Class SOLIC_ANTICIPO_CONTRATOS
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_ANTI_CONTRATO As Int32, aID_ANTICIPO As Int32, aCODICONTRATO As String)
        Me._ID_ANTI_CONTRATO = aID_ANTI_CONTRATO
        Me._ID_ANTICIPO = aID_ANTICIPO
        Me._CODICONTRATO = aCODICONTRATO
    End Sub

#Region " Properties "

    Private _ID_ANTI_CONTRATO As Int32
    <Column(Name:="Id anti contrato", Storage:="ID_ANTI_CONTRATO", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_ANTI_CONTRATO() As Int32
        Get
            Return _ID_ANTI_CONTRATO
        End Get
        Set(ByVal Value As Int32)
            _ID_ANTI_CONTRATO = Value
            OnPropertyChanged("ID_ANTI_CONTRATO")
        End Set
    End Property 

    Private _ID_ANTICIPO As Int32
    <Column(Name:="Id anticipo", Storage:="ID_ANTICIPO", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
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
