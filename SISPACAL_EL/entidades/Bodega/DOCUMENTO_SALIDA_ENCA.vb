''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.DOCUMENTO_SALIDA_ENCA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row DOCUMENTO_SALIDA_ENCA en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	14/06/2018	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="DOCUMENTO_SALIDA_ENCA")> Public Class DOCUMENTO_SALIDA_ENCA
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_DOCSAL_ENCA As Int32, aNO_DOCUMENTO As Int32, aID_TIPO_MOVTO As Int32, aFECHA_DOCTO As DateTime, aUID_DOCUMENTO As Guid, aID_BODEGA As Int32, aOBSERVACIONES As String, aENTREGADO As String, aRECIBIDO As String, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime, aID_SALBODE_ENCA As Int32, aID_ZAFRA As Int32)
        Me._ID_DOCSAL_ENCA = aID_DOCSAL_ENCA
        Me._NO_DOCUMENTO = aNO_DOCUMENTO
        Me._ID_TIPO_MOVTO = aID_TIPO_MOVTO
        Me._FECHA_DOCTO = aFECHA_DOCTO
        Me._UID_DOCUMENTO = aUID_DOCUMENTO
        Me._ID_BODEGA = aID_BODEGA
        Me._OBSERVACIONES = aOBSERVACIONES
        Me._ENTREGADO = aENTREGADO
        Me._RECIBIDO = aRECIBIDO
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
        Me._ID_SALBODE_ENCA = aID_SALBODE_ENCA
        Me._ID_ZAFRA = aID_ZAFRA
    End Sub

#Region " Properties "

    Private _ID_DOCSAL_ENCA As Int32
    <Column(Name:="Id docsal enca", Storage:="ID_DOCSAL_ENCA", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_DOCSAL_ENCA() As Int32
        Get
            Return _ID_DOCSAL_ENCA
        End Get
        Set(ByVal Value As Int32)
            _ID_DOCSAL_ENCA = Value
            OnPropertyChanged("ID_DOCSAL_ENCA")
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

    Private _FECHA_DOCTO As DateTime
    <Column(Name:="Fecha docto", Storage:="FECHA_DOCTO", DbType:="DATETIME NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
    Public Property FECHA_DOCTO() As DateTime
        Get
            Return _FECHA_DOCTO
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_DOCTO = Value
            OnPropertyChanged("FECHA_DOCTO")
        End Set
    End Property 

    Private _FECHA_DOCTOOld As DateTime
    Public Property FECHA_DOCTOOld() As DateTime
        Get
            Return _FECHA_DOCTOOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_DOCTOOld = Value
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

    Private _ID_BODEGA As Int32
    <Column(Name:="Id bodega", Storage:="ID_BODEGA", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
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

    Private _ENTREGADO As String
    <Column(Name:="Entregado", Storage:="ENTREGADO", DbType:="VARCHAR(200)", Id:=False), _
     DataObjectField(False, False, True, 200)> _
    Public Property ENTREGADO() As String
        Get
            Return _ENTREGADO
        End Get
        Set(ByVal Value As String)
            _ENTREGADO = Value
            OnPropertyChanged("ENTREGADO")
        End Set
    End Property 

    Private _ENTREGADOOld As String
    Public Property ENTREGADOOld() As String
        Get
            Return _ENTREGADOOld
        End Get
        Set(ByVal Value As String)
            _ENTREGADOOld = Value
        End Set
    End Property 

    Private _RECIBIDO As String
    <Column(Name:="Recibido", Storage:="RECIBIDO", DbType:="VARCHAR(200)", Id:=False), _
     DataObjectField(False, False, True, 200)> _
    Public Property RECIBIDO() As String
        Get
            Return _RECIBIDO
        End Get
        Set(ByVal Value As String)
            _RECIBIDO = Value
            OnPropertyChanged("RECIBIDO")
        End Set
    End Property 

    Private _RECIBIDOOld As String
    Public Property RECIBIDOOld() As String
        Get
            Return _RECIBIDOOld
        End Get
        Set(ByVal Value As String)
            _RECIBIDOOld = Value
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

    Private _ID_SALBODE_ENCA As Int32
    <Column(Name:="Id salbode enca", Storage:="ID_SALBODE_ENCA", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_SALBODE_ENCA() As Int32
        Get
            Return _ID_SALBODE_ENCA
        End Get
        Set(ByVal Value As Int32)
            _ID_SALBODE_ENCA = Value
            OnPropertyChanged("ID_SALBODE_ENCA")
        End Set
    End Property 

    Private _ID_SALBODE_ENCAOld As Int32
    Public Property ID_SALBODE_ENCAOld() As Int32
        Get
            Return _ID_SALBODE_ENCAOld
        End Get
        Set(ByVal Value As Int32)
            _ID_SALBODE_ENCAOld = Value
        End Set
    End Property 

    Private _fkID_SALBODE_ENCA As SALBODE_ENCA
    Public Property fkID_SALBODE_ENCA() As SALBODE_ENCA
        Get
            Return _fkID_SALBODE_ENCA
        End Get
        Set(ByVal Value As SALBODE_ENCA)
            _fkID_SALBODE_ENCA = Value
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
