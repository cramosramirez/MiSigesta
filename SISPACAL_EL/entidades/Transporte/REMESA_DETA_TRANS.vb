''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.REMESA_DETA_TRANS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row REMESA_DETA_TRANS en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	03/01/2018	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="REMESA_DETA_TRANS")> Public Class REMESA_DETA_TRANS
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_REMESA_DETA As Int32, aID_REMESA_ENCA As Int32, aID_CREDITO_ENCA As Int32, aUID_REMESA_DETA As Guid, aABONO_CAPITAL As Decimal, aABONO_INTERES As Decimal, aABONO_INTERES_IVA As Decimal)
        Me._ID_REMESA_DETA = aID_REMESA_DETA
        Me._ID_REMESA_ENCA = aID_REMESA_ENCA
        Me._ID_CREDITO_ENCA = aID_CREDITO_ENCA
        Me._UID_REMESA_DETA = aUID_REMESA_DETA
        Me._ABONO_CAPITAL = aABONO_CAPITAL
        Me._ABONO_INTERES = aABONO_INTERES
        Me._ABONO_INTERES_IVA = aABONO_INTERES_IVA
    End Sub

#Region " Properties "

    Private _ID_REMESA_DETA As Int32
    <Column(Name:="Id remesa deta", Storage:="ID_REMESA_DETA", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_REMESA_DETA() As Int32
        Get
            Return _ID_REMESA_DETA
        End Get
        Set(ByVal Value As Int32)
            _ID_REMESA_DETA = Value
            OnPropertyChanged("ID_REMESA_DETA")
        End Set
    End Property 

    Private _ID_REMESA_ENCA As Int32
    <Column(Name:="Id remesa enca", Storage:="ID_REMESA_ENCA", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_REMESA_ENCA() As Int32
        Get
            Return _ID_REMESA_ENCA
        End Get
        Set(ByVal Value As Int32)
            _ID_REMESA_ENCA = Value
            OnPropertyChanged("ID_REMESA_ENCA")
        End Set
    End Property 

    Private _ID_REMESA_ENCAOld As Int32
    Public Property ID_REMESA_ENCAOld() As Int32
        Get
            Return _ID_REMESA_ENCAOld
        End Get
        Set(ByVal Value As Int32)
            _ID_REMESA_ENCAOld = Value
        End Set
    End Property 

    Private _fkID_REMESA_ENCA As REMESA_ENCA_TRANS
    Public Property fkID_REMESA_ENCA() As REMESA_ENCA_TRANS
        Get
            Return _fkID_REMESA_ENCA
        End Get
        Set(ByVal Value As REMESA_ENCA_TRANS)
            _fkID_REMESA_ENCA = Value
        End Set
    End Property 

    Private _ID_CREDITO_ENCA As Int32
    <Column(Name:="Id credito enca", Storage:="ID_CREDITO_ENCA", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_CREDITO_ENCA() As Int32
        Get
            Return _ID_CREDITO_ENCA
        End Get
        Set(ByVal Value As Int32)
            _ID_CREDITO_ENCA = Value
            OnPropertyChanged("ID_CREDITO_ENCA")
        End Set
    End Property 

    Private _ID_CREDITO_ENCAOld As Int32
    Public Property ID_CREDITO_ENCAOld() As Int32
        Get
            Return _ID_CREDITO_ENCAOld
        End Get
        Set(ByVal Value As Int32)
            _ID_CREDITO_ENCAOld = Value
        End Set
    End Property 

    Private _fkID_CREDITO_ENCA As CREDITO_ENCA_TRANS
    Public Property fkID_CREDITO_ENCA() As CREDITO_ENCA_TRANS
        Get
            Return _fkID_CREDITO_ENCA
        End Get
        Set(ByVal Value As CREDITO_ENCA_TRANS)
            _fkID_CREDITO_ENCA = Value
        End Set
    End Property 

    Private _UID_REMESA_DETA As Guid
    <Column(Name:="Uid remesa deta", Storage:="UID_REMESA_DETA", DbType:="UNIQUEIDENTIFIER(36, 0) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 16)> _
    Public Property UID_REMESA_DETA() As Guid
        Get
            Return _UID_REMESA_DETA
        End Get
        Set(ByVal Value As Guid)
            _UID_REMESA_DETA = Value
            OnPropertyChanged("UID_REMESA_DETA")
        End Set
    End Property 

    Private _UID_REMESA_DETAOld As Guid
    Public Property UID_REMESA_DETAOld() As Guid
        Get
            Return _UID_REMESA_DETAOld
        End Get
        Set(ByVal Value As Guid)
            _UID_REMESA_DETAOld = Value
        End Set
    End Property 

    Private _ABONO_CAPITAL As Decimal
    <Column(Name:="Abono capital", Storage:="ABONO_CAPITAL", DbType:="NUMERIC(20,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)> _
    Public Property ABONO_CAPITAL() As Decimal
        Get
            Return _ABONO_CAPITAL
        End Get
        Set(ByVal Value As Decimal)
            _ABONO_CAPITAL = Value
            OnPropertyChanged("ABONO_CAPITAL")
        End Set
    End Property 

    Private _ABONO_CAPITALOld As Decimal
    Public Property ABONO_CAPITALOld() As Decimal
        Get
            Return _ABONO_CAPITALOld
        End Get
        Set(ByVal Value As Decimal)
            _ABONO_CAPITALOld = Value
        End Set
    End Property 

    Private _ABONO_INTERES As Decimal
    <Column(Name:="Abono interes", Storage:="ABONO_INTERES", DbType:="NUMERIC(20,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)> _
    Public Property ABONO_INTERES() As Decimal
        Get
            Return _ABONO_INTERES
        End Get
        Set(ByVal Value As Decimal)
            _ABONO_INTERES = Value
            OnPropertyChanged("ABONO_INTERES")
        End Set
    End Property 

    Private _ABONO_INTERESOld As Decimal
    Public Property ABONO_INTERESOld() As Decimal
        Get
            Return _ABONO_INTERESOld
        End Get
        Set(ByVal Value As Decimal)
            _ABONO_INTERESOld = Value
        End Set
    End Property 

    Private _ABONO_INTERES_IVA As Decimal
    <Column(Name:="Abono interes iva", Storage:="ABONO_INTERES_IVA", DbType:="NUMERIC(20,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)> _
    Public Property ABONO_INTERES_IVA() As Decimal
        Get
            Return _ABONO_INTERES_IVA
        End Get
        Set(ByVal Value As Decimal)
            _ABONO_INTERES_IVA = Value
            OnPropertyChanged("ABONO_INTERES_IVA")
        End Set
    End Property 

    Private _ABONO_INTERES_IVAOld As Decimal
    Public Property ABONO_INTERES_IVAOld() As Decimal
        Get
            Return _ABONO_INTERES_IVAOld
        End Get
        Set(ByVal Value As Decimal)
            _ABONO_INTERES_IVAOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
