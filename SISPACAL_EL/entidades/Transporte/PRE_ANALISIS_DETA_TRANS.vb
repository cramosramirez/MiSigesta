''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.PRE_ANALISIS_DETA_TRANS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row PRE_ANALISIS_DETA_TRANS en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	06/11/2017	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="PRE_ANALISIS_DETA_TRANS")> Public Class PRE_ANALISIS_DETA_TRANS
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_DETA As Int32, aID_ENCA As Int32, aUID_REF As String, aORDEN As Int32, aNUMERO As String, aDESCRIPCION As String, aMONTO As Decimal, aUNIDADES As String, aID_CATE As Int32, aID_CATE_REF As Int32, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aEDITAR As Boolean, aNEGRITA As Boolean)
        Me._ID_DETA = aID_DETA
        Me._ID_ENCA = aID_ENCA
        Me._UID_REF = aUID_REF
        Me._ORDEN = aORDEN
        Me._NUMERO = aNUMERO
        Me._DESCRIPCION = aDESCRIPCION
        Me._MONTO = aMONTO
        Me._UNIDADES = aUNIDADES
        Me._ID_CATE = aID_CATE
        Me._ID_CATE_REF = aID_CATE_REF
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._EDITAR = aEDITAR
        Me._NEGRITA = aNEGRITA
    End Sub

#Region " Properties "

    Private _ID_DETA As Int32
    <Column(Name:="Id deta", Storage:="ID_DETA", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_DETA() As Int32
        Get
            Return _ID_DETA
        End Get
        Set(ByVal Value As Int32)
            _ID_DETA = Value
            OnPropertyChanged("ID_DETA")
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

    Private _UID_REF As String
    <Column(Name:="Uid ref", Storage:="UID_REF", DbType:="VARCHAR(200)", Id:=False), _
     DataObjectField(False, False, True, 200)> _
    Public Property UID_REF() As String
        Get
            Return _UID_REF
        End Get
        Set(ByVal Value As String)
            _UID_REF = Value
            OnPropertyChanged("UID_REF")
        End Set
    End Property 

    Private _UID_REFOld As String
    Public Property UID_REFOld() As String
        Get
            Return _UID_REFOld
        End Get
        Set(ByVal Value As String)
            _UID_REFOld = Value
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

    Private _NUMERO As String
    <Column(Name:="Numero", Storage:="NUMERO", DbType:="VARCHAR(3)", Id:=False), _
     DataObjectField(False, False, True, 3)> _
    Public Property NUMERO() As String
        Get
            Return _NUMERO
        End Get
        Set(ByVal Value As String)
            _NUMERO = Value
            OnPropertyChanged("NUMERO")
        End Set
    End Property 

    Private _NUMEROOld As String
    Public Property NUMEROOld() As String
        Get
            Return _NUMEROOld
        End Get
        Set(ByVal Value As String)
            _NUMEROOld = Value
        End Set
    End Property 

    Private _DESCRIPCION As String
    <Column(Name:="Descripcion", Storage:="DESCRIPCION", DbType:="VARCHAR(1000)", Id:=False), _
     DataObjectField(False, False, True, 1000)> _
    Public Property DESCRIPCION() As String
        Get
            Return _DESCRIPCION
        End Get
        Set(ByVal Value As String)
            _DESCRIPCION = Value
            OnPropertyChanged("DESCRIPCION")
        End Set
    End Property 

    Private _DESCRIPCIONOld As String
    Public Property DESCRIPCIONOld() As String
        Get
            Return _DESCRIPCIONOld
        End Get
        Set(ByVal Value As String)
            _DESCRIPCIONOld = Value
        End Set
    End Property 

    Private _MONTO As Decimal
    <Column(Name:="Monto", Storage:="MONTO", DbType:="NUMERIC(20,4)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=4)> _
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

    Private _UNIDADES As String
    <Column(Name:="Unidades", Storage:="UNIDADES", DbType:="VARCHAR(1000)", Id:=False), _
     DataObjectField(False, False, True, 1000)> _
    Public Property UNIDADES() As String
        Get
            Return _UNIDADES
        End Get
        Set(ByVal Value As String)
            _UNIDADES = Value
            OnPropertyChanged("UNIDADES")
        End Set
    End Property 

    Private _UNIDADESOld As String
    Public Property UNIDADESOld() As String
        Get
            Return _UNIDADESOld
        End Get
        Set(ByVal Value As String)
            _UNIDADESOld = Value
        End Set
    End Property 

    Private _ID_CATE As Int32
    <Column(Name:="Id cate", Storage:="ID_CATE", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_CATE() As Int32
        Get
            Return _ID_CATE
        End Get
        Set(ByVal Value As Int32)
            _ID_CATE = Value
            OnPropertyChanged("ID_CATE")
        End Set
    End Property 

    Private _ID_CATEOld As Int32
    Public Property ID_CATEOld() As Int32
        Get
            Return _ID_CATEOld
        End Get
        Set(ByVal Value As Int32)
            _ID_CATEOld = Value
        End Set
    End Property 

    Private _ID_CATE_REF As Int32
    <Column(Name:="Id cate ref", Storage:="ID_CATE_REF", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_CATE_REF() As Int32
        Get
            Return _ID_CATE_REF
        End Get
        Set(ByVal Value As Int32)
            _ID_CATE_REF = Value
            OnPropertyChanged("ID_CATE_REF")
        End Set
    End Property 

    Private _ID_CATE_REFOld As Int32
    Public Property ID_CATE_REFOld() As Int32
        Get
            Return _ID_CATE_REFOld
        End Get
        Set(ByVal Value As Int32)
            _ID_CATE_REFOld = Value
        End Set
    End Property 

    Private _USUARIO_CREA As String
    <Column(Name:="Usuario crea", Storage:="USUARIO_CREA", DbType:="VARCHAR(200)", Id:=False), _
     DataObjectField(False, False, True, 200)> _
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

    Private _EDITAR As Boolean
    <Column(Name:="Editar", Storage:="EDITAR", DbType:="BIT", Id:=False), _
     DataObjectField(False, False, True, 1)> _
    Public Property EDITAR() As Boolean
        Get
            Return _EDITAR
        End Get
        Set(ByVal Value As Boolean)
            _EDITAR = Value
            OnPropertyChanged("EDITAR")
        End Set
    End Property 

    Private _EDITAROld As Boolean
    Public Property EDITAROld() As Boolean
        Get
            Return _EDITAROld
        End Get
        Set(ByVal Value As Boolean)
            _EDITAROld = Value
        End Set
    End Property 

    Private _NEGRITA As Boolean
    <Column(Name:="Negrita", Storage:="NEGRITA", DbType:="BIT", Id:=False), _
     DataObjectField(False, False, True, 1)> _
    Public Property NEGRITA() As Boolean
        Get
            Return _NEGRITA
        End Get
        Set(ByVal Value As Boolean)
            _NEGRITA = Value
            OnPropertyChanged("NEGRITA")
        End Set
    End Property 

    Private _NEGRITAOld As Boolean
    Public Property NEGRITAOld() As Boolean
        Get
            Return _NEGRITAOld
        End Get
        Set(ByVal Value As Boolean)
            _NEGRITAOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
