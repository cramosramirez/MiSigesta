''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.PRE_ANALISIS_DETA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row PRE_ANALISIS_DETA en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	22/05/2017	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="PRE_ANALISIS_DETA")> Public Class PRE_ANALISIS_DETA
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_DETA As Int32, aID_ENCA As Int32, aUID_REF As String, aORDEN As Int32, aNUMERO As String, aDESCRIPCION As String, aMONTO1 As Decimal, aMONTO2 As Decimal, aMONTO3 As Decimal, aMONTO4 As Decimal, aMONTO5 As Decimal, aMONTO6 As Decimal, aTOTAL As Decimal, aTARIFA_CAT As String, aTARIFA_CAT_DESCRIP As String, aID_CATE As Int32, aID_CATE_REF As Int32, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aEDITAR As Boolean, aNEGRITA As Boolean)
        Me._ID_DETA = aID_DETA
        Me._ID_ENCA = aID_ENCA
        Me._UID_REF = aUID_REF
        Me._ORDEN = aORDEN
        Me._NUMERO = aNUMERO
        Me._DESCRIPCION = aDESCRIPCION
        Me._MONTO1 = aMONTO1
        Me._MONTO2 = aMONTO2
        Me._MONTO3 = aMONTO3
        Me._MONTO4 = aMONTO4
        Me._MONTO5 = aMONTO5
        Me._MONTO6 = aMONTO6
        Me._TOTAL = aTOTAL
        Me._TARIFA_CAT = aTARIFA_CAT
        Me._TARIFA_CAT_DESCRIP = aTARIFA_CAT_DESCRIP
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

    Private _fkID_ENCA As PRE_ANALISIS_ENCA
    Public Property fkID_ENCA() As PRE_ANALISIS_ENCA
        Get
            Return _fkID_ENCA
        End Get
        Set(ByVal Value As PRE_ANALISIS_ENCA)
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

    Private _TARIFA_CAT As String
    <Column(Name:="Tarifa cat", Storage:="TARIFA_CAT", DbType:="VARCHAR(1000)", Id:=False), _
     DataObjectField(False, False, True, 1000)> _
    Public Property TARIFA_CAT() As String
        Get
            Return _TARIFA_CAT
        End Get
        Set(ByVal Value As String)
            _TARIFA_CAT = Value
            OnPropertyChanged("TARIFA_CAT")
        End Set
    End Property 

    Private _TARIFA_CATOld As String
    Public Property TARIFA_CATOld() As String
        Get
            Return _TARIFA_CATOld
        End Get
        Set(ByVal Value As String)
            _TARIFA_CATOld = Value
        End Set
    End Property 

    Private _TARIFA_CAT_DESCRIP As String
    <Column(Name:="Tarifa cat descrip", Storage:="TARIFA_CAT_DESCRIP", DbType:="VARCHAR(1000)", Id:=False), _
     DataObjectField(False, False, True, 1000)> _
    Public Property TARIFA_CAT_DESCRIP() As String
        Get
            Return _TARIFA_CAT_DESCRIP
        End Get
        Set(ByVal Value As String)
            _TARIFA_CAT_DESCRIP = Value
            OnPropertyChanged("TARIFA_CAT_DESCRIP")
        End Set
    End Property 

    Private _TARIFA_CAT_DESCRIPOld As String
    Public Property TARIFA_CAT_DESCRIPOld() As String
        Get
            Return _TARIFA_CAT_DESCRIPOld
        End Get
        Set(ByVal Value As String)
            _TARIFA_CAT_DESCRIPOld = Value
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

    Private _MONTO1 As Decimal
    <Column(Name:="Monto1", Storage:="MONTO1", DbType:="NUMERIC(20,4)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=4)> _
    Public Property MONTO1() As Decimal
        Get
            Return _MONTO1
        End Get
        Set(ByVal Value As Decimal)
            _MONTO1 = Value
            OnPropertyChanged("MONTO1")
        End Set
    End Property

    Private _MONTO1Old As Decimal
    Public Property MONTO1Old() As Decimal
        Get
            Return _MONTO1Old
        End Get
        Set(ByVal Value As Decimal)
            _MONTO1Old = Value
        End Set
    End Property

    Private _MONTO2 As Decimal
    <Column(Name:="Monto2", Storage:="MONTO2", DbType:="NUMERIC(20,4)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=4)> _
    Public Property MONTO2() As Decimal
        Get
            Return _MONTO2
        End Get
        Set(ByVal Value As Decimal)
            _MONTO2 = Value
            OnPropertyChanged("MONTO2")
        End Set
    End Property

    Private _MONTO2Old As Decimal
    Public Property MONTO2Old() As Decimal
        Get
            Return _MONTO2Old
        End Get
        Set(ByVal Value As Decimal)
            _MONTO2Old = Value
        End Set
    End Property



    Private _MONTO3 As Decimal
    <Column(Name:="Monto3", Storage:="MONTO3", DbType:="NUMERIC(20,4)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=4)> _
    Public Property MONTO3() As Decimal
        Get
            Return _MONTO3
        End Get
        Set(ByVal Value As Decimal)
            _MONTO3 = Value
            OnPropertyChanged("MONTO3")
        End Set
    End Property


    Private _MONTO4 As Decimal
    <Column(Name:="Monto4", Storage:="MONTO4", DbType:="NUMERIC(20,4)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=4)> _
    Public Property MONTO4() As Decimal
        Get
            Return _MONTO4
        End Get
        Set(ByVal Value As Decimal)
            _MONTO4 = Value
            OnPropertyChanged("MONTO4")
        End Set
    End Property

    Private _MONTO4Old As Decimal
    Public Property MONTO4Old() As Decimal
        Get
            Return _MONTO4Old
        End Get
        Set(ByVal Value As Decimal)
            _MONTO4Old = Value
        End Set
    End Property

    Private _MONTO5 As Decimal
    <Column(Name:="Monto5", Storage:="MONTO5", DbType:="NUMERIC(20,4)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=4)> _
    Public Property MONTO5() As Decimal
        Get
            Return _MONTO5
        End Get
        Set(ByVal Value As Decimal)
            _MONTO5 = Value
            OnPropertyChanged("MONTO5")
        End Set
    End Property

    Private _MONTO5Old As Decimal
    Public Property MONTO5Old() As Decimal
        Get
            Return _MONTO5Old
        End Get
        Set(ByVal Value As Decimal)
            _MONTO5Old = Value
        End Set
    End Property

    Private _MONTO6 As Decimal
    <Column(Name:="Monto6", Storage:="MONTO6", DbType:="NUMERIC(20,4)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=4)> _
    Public Property MONTO6() As Decimal
        Get
            Return _MONTO6
        End Get
        Set(ByVal Value As Decimal)
            _MONTO6 = Value
            OnPropertyChanged("MONTO6")
        End Set
    End Property

    Private _MONTO6Old As Decimal
    Public Property MONTO6Old() As Decimal
        Get
            Return _MONTO6Old
        End Get
        Set(ByVal Value As Decimal)
            _MONTO6Old = Value
        End Set
    End Property

    Private _TOTAL As Decimal
    <Column(Name:="TOTAL", Storage:="TOTAL", DbType:="NUMERIC(20,4)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=4)> _
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


#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
