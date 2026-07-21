''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.PRE_ANALISIS_DOCTO_TRANS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row PRE_ANALISIS_DOCTO_TRANS en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	06/11/2017	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="PRE_ANALISIS_DOCTO_TRANS")> Public Class PRE_ANALISIS_DOCTO_TRANS
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_AUX As Int32, aID_ENCA As Int32, aCATEGORIA As String, aORDEN As Int32, aID_CUENTA_FINAN As Int32, aFECHA As DateTime, aZAFRA As String, aIDENTIFICADOR As Int32, aNUM_SOLIC As String, aCONDICION_COMPRA As String, aMONTO As Decimal, aUID_DOCUMENTO As Guid)
        Me._ID_AUX = aID_AUX
        Me._ID_ENCA = aID_ENCA
        Me._CATEGORIA = aCATEGORIA
        Me._ORDEN = aORDEN
        Me._ID_CUENTA_FINAN = aID_CUENTA_FINAN
        Me._FECHA = aFECHA
        Me._ZAFRA = aZAFRA
        Me._IDENTIFICADOR = aIDENTIFICADOR
        Me._NUM_SOLIC = aNUM_SOLIC
        Me._CONDICION_COMPRA = aCONDICION_COMPRA
        Me._MONTO = aMONTO
        Me._UID_DOCUMENTO = aUID_DOCUMENTO
    End Sub

#Region " Properties "

    Private _ID_AUX As Int32
    <Column(Name:="Id aux", Storage:="ID_AUX", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_AUX() As Int32
        Get
            Return _ID_AUX
        End Get
        Set(ByVal Value As Int32)
            _ID_AUX = Value
            OnPropertyChanged("ID_AUX")
        End Set
    End Property 

    Private _ID_ENCA As Int32
    <Column(Name:="Id enca", Storage:="ID_ENCA", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_ENCA() As Int32
        Get
            Return _ID_ENCA
        End Get
        Set(ByVal Value As Int32)
            _ID_ENCA = Value
            OnPropertyChanged("ID_ENCA")
        End Set
    End Property 

    Private _ID_ENCAOld As Int32
    Public Property ID_ENCAOld() As Int32
        Get
            Return _ID_ENCAOld
        End Get
        Set(ByVal Value As Int32)
            _ID_ENCAOld = Value
        End Set
    End Property 

    Private _fkID_ENCA As PRE_ANALISIS_ENCA_TRANS
    Public Property fkID_ENCA() As PRE_ANALISIS_ENCA_TRANS
        Get
            Return _fkID_ENCA
        End Get
        Set(ByVal Value As PRE_ANALISIS_ENCA_TRANS)
            _fkID_ENCA = Value
        End Set
    End Property 

    Private _CATEGORIA As String
    <Column(Name:="Categoria", Storage:="CATEGORIA", DbType:="VARCHAR(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
    Public Property CATEGORIA() As String
        Get
            Return _CATEGORIA
        End Get
        Set(ByVal Value As String)
            _CATEGORIA = Value
            OnPropertyChanged("CATEGORIA")
        End Set
    End Property 

    Private _CATEGORIAOld As String
    Public Property CATEGORIAOld() As String
        Get
            Return _CATEGORIAOld
        End Get
        Set(ByVal Value As String)
            _CATEGORIAOld = Value
        End Set
    End Property 

    Private _ORDEN As Int32
    <Column(Name:="Orden", Storage:="ORDEN", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ORDEN() As Int32
        Get
            Return _ORDEN
        End Get
        Set(ByVal Value As Int32)
            _ORDEN = Value
            OnPropertyChanged("ORDEN")
        End Set
    End Property 

    Private _ORDENOld As Int32
    Public Property ORDENOld() As Int32
        Get
            Return _ORDENOld
        End Get
        Set(ByVal Value As Int32)
            _ORDENOld = Value
        End Set
    End Property 

    Private _ID_CUENTA_FINAN As Int32
    <Column(Name:="Id cuenta finan", Storage:="ID_CUENTA_FINAN", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_CUENTA_FINAN() As Int32
        Get
            Return _ID_CUENTA_FINAN
        End Get
        Set(ByVal Value As Int32)
            _ID_CUENTA_FINAN = Value
            OnPropertyChanged("ID_CUENTA_FINAN")
        End Set
    End Property 

    Private _ID_CUENTA_FINANOld As Int32
    Public Property ID_CUENTA_FINANOld() As Int32
        Get
            Return _ID_CUENTA_FINANOld
        End Get
        Set(ByVal Value As Int32)
            _ID_CUENTA_FINANOld = Value
        End Set
    End Property 

    Private _fkID_CUENTA_FINAN As CUENTA_FINAN
    Public Property fkID_CUENTA_FINAN() As CUENTA_FINAN
        Get
            Return _fkID_CUENTA_FINAN
        End Get
        Set(ByVal Value As CUENTA_FINAN)
            _fkID_CUENTA_FINAN = Value
        End Set
    End Property 

    Private _FECHA As DateTime
    <Column(Name:="Fecha", Storage:="FECHA", DbType:="DATETIME", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA() As DateTime
        Get
            Return _FECHA
        End Get
        Set(ByVal Value As DateTime)
            _FECHA = Value
            OnPropertyChanged("FECHA")
        End Set
    End Property 

    Private _FECHAOld As DateTime
    Public Property FECHAOld() As DateTime
        Get
            Return _FECHAOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHAOld = Value
        End Set
    End Property 

    Private _ZAFRA As String
    <Column(Name:="Zafra", Storage:="ZAFRA", DbType:="VARCHAR(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
    Public Property ZAFRA() As String
        Get
            Return _ZAFRA
        End Get
        Set(ByVal Value As String)
            _ZAFRA = Value
            OnPropertyChanged("ZAFRA")
        End Set
    End Property 

    Private _ZAFRAOld As String
    Public Property ZAFRAOld() As String
        Get
            Return _ZAFRAOld
        End Get
        Set(ByVal Value As String)
            _ZAFRAOld = Value
        End Set
    End Property 

    Private _IDENTIFICADOR As Int32
    <Column(Name:="Identificador", Storage:="IDENTIFICADOR", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property IDENTIFICADOR() As Int32
        Get
            Return _IDENTIFICADOR
        End Get
        Set(ByVal Value As Int32)
            _IDENTIFICADOR = Value
            OnPropertyChanged("IDENTIFICADOR")
        End Set
    End Property 

    Private _IDENTIFICADOROld As Int32
    Public Property IDENTIFICADOROld() As Int32
        Get
            Return _IDENTIFICADOROld
        End Get
        Set(ByVal Value As Int32)
            _IDENTIFICADOROld = Value
        End Set
    End Property 

    Private _NUM_SOLIC As String
    <Column(Name:="Num solic", Storage:="NUM_SOLIC", DbType:="VARCHAR(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
    Public Property NUM_SOLIC() As String
        Get
            Return _NUM_SOLIC
        End Get
        Set(ByVal Value As String)
            _NUM_SOLIC = Value
            OnPropertyChanged("NUM_SOLIC")
        End Set
    End Property 

    Private _NUM_SOLICOld As String
    Public Property NUM_SOLICOld() As String
        Get
            Return _NUM_SOLICOld
        End Get
        Set(ByVal Value As String)
            _NUM_SOLICOld = Value
        End Set
    End Property 

    Private _CONDICION_COMPRA As String
    <Column(Name:="Condicion compra", Storage:="CONDICION_COMPRA", DbType:="VARCHAR(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
    Public Property CONDICION_COMPRA() As String
        Get
            Return _CONDICION_COMPRA
        End Get
        Set(ByVal Value As String)
            _CONDICION_COMPRA = Value
            OnPropertyChanged("CONDICION_COMPRA")
        End Set
    End Property 

    Private _CONDICION_COMPRAOld As String
    Public Property CONDICION_COMPRAOld() As String
        Get
            Return _CONDICION_COMPRAOld
        End Get
        Set(ByVal Value As String)
            _CONDICION_COMPRAOld = Value
        End Set
    End Property 

    Private _MONTO As Decimal
    <Column(Name:="Monto", Storage:="MONTO", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property MONTO() As Decimal
        Get
            Return _MONTO
        End Get
        Set(ByVal Value As Decimal)
            _MONTO = Value
            OnPropertyChanged("MONTO")
        End Set
    End Property 

    Private _MONTOOld As Decimal
    Public Property MONTOOld() As Decimal
        Get
            Return _MONTOOld
        End Get
        Set(ByVal Value As Decimal)
            _MONTOOld = Value
        End Set
    End Property 

    Private _UID_DOCUMENTO As Guid
    <Column(Name:="Uid documento", Storage:="UID_DOCUMENTO", DbType:="UNIQUEIDENTIFIER(36, 0)", Id:=False), _
     DataObjectField(False, False, True, 16)> _
    Public Property UID_DOCUMENTO() As Guid
        Get
            Return _UID_DOCUMENTO
        End Get
        Set(ByVal Value As Guid)
            _UID_DOCUMENTO = Value
            OnPropertyChanged("UID_DOCUMENTO")
        End Set
    End Property 

    Private _UID_DOCUMENTOOld As Guid
    Public Property UID_DOCUMENTOOld() As Guid
        Get
            Return _UID_DOCUMENTOOld
        End Get
        Set(ByVal Value As Guid)
            _UID_DOCUMENTOOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
