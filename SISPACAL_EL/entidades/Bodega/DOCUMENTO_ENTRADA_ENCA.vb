''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.DOCUMENTO_ENTRADA_ENCA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row DOCUMENTO_ENTRADA_ENCA en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	14/06/2018	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="DOCUMENTO_ENTRADA_ENCA")> Public Class DOCUMENTO_ENTRADA_ENCA
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_DOCENTRA_ENCA As Int32, aID_BODEGA As Int32, aNO_DOCUMENTO As Int32, aFEC_DOCTO As DateTime, aID_TIPO_MOVTO As Int32, aUID_DOCUMENTO As Guid, aTOTAL As Decimal, aID_PROVEE As Int32, aFORMA_ENTREGA As Int32, aID_ORDEN As Int32, aNO_COMPROB As String, aID_TIPO_COMPROB As Int32, aFECHA_COMPROB As DateTime, aOBSERVACIONES As String, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime, aID_DOCSAL_ENCA As Int32, aID_ZAFRA As Int32)
        Me._ID_DOCENTRA_ENCA = aID_DOCENTRA_ENCA
        Me._ID_BODEGA = aID_BODEGA
        Me._NO_DOCUMENTO = aNO_DOCUMENTO
        Me._FEC_DOCTO = aFEC_DOCTO
        Me._ID_TIPO_MOVTO = aID_TIPO_MOVTO
        Me._UID_DOCUMENTO = aUID_DOCUMENTO
        Me._TOTAL = aTOTAL
        Me._ID_PROVEE = aID_PROVEE
        Me._FORMA_ENTREGA = aFORMA_ENTREGA
        Me._ID_ORDEN = aID_ORDEN
        Me._NO_COMPROB = aNO_COMPROB
        Me._ID_TIPO_COMPROB = aID_TIPO_COMPROB
        Me._FECHA_COMPROB = aFECHA_COMPROB
        Me._OBSERVACIONES = aOBSERVACIONES
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
        Me._ID_DOCSAL_ENCA = aID_DOCSAL_ENCA
        Me._ID_ZAFRA = aID_ZAFRA
    End Sub

#Region " Properties "

    Private _ID_DOCENTRA_ENCA As Int32
    <Column(Name:="Id docentra enca", Storage:="ID_DOCENTRA_ENCA", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_DOCENTRA_ENCA() As Int32
        Get
            Return _ID_DOCENTRA_ENCA
        End Get
        Set(ByVal Value As Int32)
            _ID_DOCENTRA_ENCA = Value
            OnPropertyChanged("ID_DOCENTRA_ENCA")
        End Set
    End Property 

    Private _ID_BODEGA As Int32
    <Column(Name:="Id bodega", Storage:="ID_BODEGA", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_BODEGA() As Int32
        Get
            Return _ID_BODEGA
        End Get
        Set(ByVal Value As Int32)
            _ID_BODEGA = Value
            OnPropertyChanged("ID_BODEGA")
        End Set
    End Property 

    Private _ID_BODEGAOld As Int32
    Public Property ID_BODEGAOld() As Int32
        Get
            Return _ID_BODEGAOld
        End Get
        Set(ByVal Value As Int32)
            _ID_BODEGAOld = Value
        End Set
    End Property 

    Private _fkID_BODEGA As BODEGA
    Public Property fkID_BODEGA() As BODEGA
        Get
            Return _fkID_BODEGA
        End Get
        Set(ByVal Value As BODEGA)
            _fkID_BODEGA = Value
        End Set
    End Property 

    Private _NO_DOCUMENTO As Int32
    <Column(Name:="No documento", Storage:="NO_DOCUMENTO", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property NO_DOCUMENTO() As Int32
        Get
            Return _NO_DOCUMENTO
        End Get
        Set(ByVal Value As Int32)
            _NO_DOCUMENTO = Value
            OnPropertyChanged("NO_DOCUMENTO")
        End Set
    End Property 

    Private _NO_DOCUMENTOOld As Int32
    Public Property NO_DOCUMENTOOld() As Int32
        Get
            Return _NO_DOCUMENTOOld
        End Get
        Set(ByVal Value As Int32)
            _NO_DOCUMENTOOld = Value
        End Set
    End Property 

    Private _FEC_DOCTO As DateTime
    <Column(Name:="Fec docto", Storage:="FEC_DOCTO", DbType:="DATETIME", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FEC_DOCTO() As DateTime
        Get
            Return _FEC_DOCTO
        End Get
        Set(ByVal Value As DateTime)
            _FEC_DOCTO = Value
            OnPropertyChanged("FEC_DOCTO")
        End Set
    End Property 

    Private _FEC_DOCTOOld As DateTime
    Public Property FEC_DOCTOOld() As DateTime
        Get
            Return _FEC_DOCTOOld
        End Get
        Set(ByVal Value As DateTime)
            _FEC_DOCTOOld = Value
        End Set
    End Property 

    Private _ID_TIPO_MOVTO As Int32
    <Column(Name:="Id tipo movto", Storage:="ID_TIPO_MOVTO", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_TIPO_MOVTO() As Int32
        Get
            Return _ID_TIPO_MOVTO
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_MOVTO = Value
            OnPropertyChanged("ID_TIPO_MOVTO")
        End Set
    End Property 

    Private _ID_TIPO_MOVTOOld As Int32
    Public Property ID_TIPO_MOVTOOld() As Int32
        Get
            Return _ID_TIPO_MOVTOOld
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_MOVTOOld = Value
        End Set
    End Property 

    Private _fkID_TIPO_MOVTO As TIPO_MOVTO
    Public Property fkID_TIPO_MOVTO() As TIPO_MOVTO
        Get
            Return _fkID_TIPO_MOVTO
        End Get
        Set(ByVal Value As TIPO_MOVTO)
            _fkID_TIPO_MOVTO = Value
        End Set
    End Property 

    Private _UID_DOCUMENTO As Guid
    <Column(Name:="Uid documento", Storage:="UID_DOCUMENTO", DbType:="UNIQUEIDENTIFIER(36, 0) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 16)> _
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

    Private _TOTAL As Decimal
    <Column(Name:="Total", Storage:="TOTAL", DbType:="NUMERIC(20,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)> _
    Public Property TOTAL() As Decimal
        Get
            Return _TOTAL
        End Get
        Set(ByVal Value As Decimal)
            _TOTAL = Value
            OnPropertyChanged("TOTAL")
        End Set
    End Property 

    Private _TOTALOld As Decimal
    Public Property TOTALOld() As Decimal
        Get
            Return _TOTALOld
        End Get
        Set(ByVal Value As Decimal)
            _TOTALOld = Value
        End Set
    End Property 

    Private _ID_PROVEE As Int32
    <Column(Name:="Id provee", Storage:="ID_PROVEE", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_PROVEE() As Int32
        Get
            Return _ID_PROVEE
        End Get
        Set(ByVal Value As Int32)
            _ID_PROVEE = Value
            OnPropertyChanged("ID_PROVEE")
        End Set
    End Property 

    Private _ID_PROVEEOld As Int32
    Public Property ID_PROVEEOld() As Int32
        Get
            Return _ID_PROVEEOld
        End Get
        Set(ByVal Value As Int32)
            _ID_PROVEEOld = Value
        End Set
    End Property 

    Private _fkID_PROVEE As PROVEEDOR_AGRICOLA
    Public Property fkID_PROVEE() As PROVEEDOR_AGRICOLA
        Get
            Return _fkID_PROVEE
        End Get
        Set(ByVal Value As PROVEEDOR_AGRICOLA)
            _fkID_PROVEE = Value
        End Set
    End Property 

    Private _FORMA_ENTREGA As Int32
    <Column(Name:="Forma entrega", Storage:="FORMA_ENTREGA", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property FORMA_ENTREGA() As Int32
        Get
            Return _FORMA_ENTREGA
        End Get
        Set(ByVal Value As Int32)
            _FORMA_ENTREGA = Value
            OnPropertyChanged("FORMA_ENTREGA")
        End Set
    End Property 

    Private _FORMA_ENTREGAOld As Int32
    Public Property FORMA_ENTREGAOld() As Int32
        Get
            Return _FORMA_ENTREGAOld
        End Get
        Set(ByVal Value As Int32)
            _FORMA_ENTREGAOld = Value
        End Set
    End Property 

    Private _ID_ORDEN As Int32
    <Column(Name:="Id orden", Storage:="ID_ORDEN", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_ORDEN() As Int32
        Get
            Return _ID_ORDEN
        End Get
        Set(ByVal Value As Int32)
            _ID_ORDEN = Value
            OnPropertyChanged("ID_ORDEN")
        End Set
    End Property 

    Private _ID_ORDENOld As Int32
    Public Property ID_ORDENOld() As Int32
        Get
            Return _ID_ORDENOld
        End Get
        Set(ByVal Value As Int32)
            _ID_ORDENOld = Value
        End Set
    End Property 

    Private _fkID_ORDEN As ORDEN_COMPRA_AGRI
    Public Property fkID_ORDEN() As ORDEN_COMPRA_AGRI
        Get
            Return _fkID_ORDEN
        End Get
        Set(ByVal Value As ORDEN_COMPRA_AGRI)
            _fkID_ORDEN = Value
        End Set
    End Property 

    Private _NO_COMPROB As String
    <Column(Name:="No comprob", Storage:="NO_COMPROB", DbType:="VARCHAR(20)", Id:=False), _
     DataObjectField(False, False, True, 20)> _
    Public Property NO_COMPROB() As String
        Get
            Return _NO_COMPROB
        End Get
        Set(ByVal Value As String)
            _NO_COMPROB = Value
            OnPropertyChanged("NO_COMPROB")
        End Set
    End Property 

    Private _NO_COMPROBOld As String
    Public Property NO_COMPROBOld() As String
        Get
            Return _NO_COMPROBOld
        End Get
        Set(ByVal Value As String)
            _NO_COMPROBOld = Value
        End Set
    End Property 

    Private _ID_TIPO_COMPROB As Int32
    <Column(Name:="Id tipo comprob", Storage:="ID_TIPO_COMPROB", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_TIPO_COMPROB() As Int32
        Get
            Return _ID_TIPO_COMPROB
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_COMPROB = Value
            OnPropertyChanged("ID_TIPO_COMPROB")
        End Set
    End Property 

    Private _ID_TIPO_COMPROBOld As Int32
    Public Property ID_TIPO_COMPROBOld() As Int32
        Get
            Return _ID_TIPO_COMPROBOld
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_COMPROBOld = Value
        End Set
    End Property 

    Private _fkID_TIPO_COMPROB As TIPO_COMPROB
    Public Property fkID_TIPO_COMPROB() As TIPO_COMPROB
        Get
            Return _fkID_TIPO_COMPROB
        End Get
        Set(ByVal Value As TIPO_COMPROB)
            _fkID_TIPO_COMPROB = Value
        End Set
    End Property 

    Private _FECHA_COMPROB As DateTime
    <Column(Name:="Fecha comprob", Storage:="FECHA_COMPROB", DbType:="DATETIME", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_COMPROB() As DateTime
        Get
            Return _FECHA_COMPROB
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_COMPROB = Value
            OnPropertyChanged("FECHA_COMPROB")
        End Set
    End Property 

    Private _FECHA_COMPROBOld As DateTime
    Public Property FECHA_COMPROBOld() As DateTime
        Get
            Return _FECHA_COMPROBOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_COMPROBOld = Value
        End Set
    End Property 

    Private _OBSERVACIONES As String
    <Column(Name:="Observaciones", Storage:="OBSERVACIONES", DbType:="VARCHAR(1000)", Id:=False), _
     DataObjectField(False, False, True, 1000)> _
    Public Property OBSERVACIONES() As String
        Get
            Return _OBSERVACIONES
        End Get
        Set(ByVal Value As String)
            _OBSERVACIONES = Value
            OnPropertyChanged("OBSERVACIONES")
        End Set
    End Property 

    Private _OBSERVACIONESOld As String
    Public Property OBSERVACIONESOld() As String
        Get
            Return _OBSERVACIONESOld
        End Get
        Set(ByVal Value As String)
            _OBSERVACIONESOld = Value
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

    Private _ID_DOCSAL_ENCA As Int32
    <Column(Name:="Id docsal enca", Storage:="ID_DOCSAL_ENCA", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_DOCSAL_ENCA() As Int32
        Get
            Return _ID_DOCSAL_ENCA
        End Get
        Set(ByVal Value As Int32)
            _ID_DOCSAL_ENCA = Value
            OnPropertyChanged("ID_DOCSAL_ENCA")
        End Set
    End Property 

    Private _ID_DOCSAL_ENCAOld As Int32
    Public Property ID_DOCSAL_ENCAOld() As Int32
        Get
            Return _ID_DOCSAL_ENCAOld
        End Get
        Set(ByVal Value As Int32)
            _ID_DOCSAL_ENCAOld = Value
        End Set
    End Property 

    Private _fkID_DOCSAL_ENCA As DOCUMENTO_SALIDA_ENCA
    Public Property fkID_DOCSAL_ENCA() As DOCUMENTO_SALIDA_ENCA
        Get
            Return _fkID_DOCSAL_ENCA
        End Get
        Set(ByVal Value As DOCUMENTO_SALIDA_ENCA)
            _fkID_DOCSAL_ENCA = Value
        End Set
    End Property 

    Private _ID_ZAFRA As Int32
    <Column(Name:="Id zafra", Storage:="ID_ZAFRA", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
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

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
