''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.CHEQUE_PARTIDA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row CHEQUE_PARTIDA en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	06/12/2013	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="CHEQUE_PARTIDA")> Public Class CHEQUE_PARTIDA
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(ByVal aID_CHEQUE_PARTIDA As Int32, ByVal aID_CHEQUE_PLANILLA As Int32, ByVal aORDEN As Int32, ByVal aCUENTA_CONTABLE As String, ByVal aDESCRIPCION_CUENTA As String, ByVal aDESCRIPCION_ADICIONAL As String, ByVal aDEBE As Decimal, ByVal aHABER As Decimal, ByVal aUSUARIO_CREA As String, ByVal aFECHA_CREA As DateTime, ByVal aUSUARIO_ACT As String, ByVal aFECHA_ACT As DateTime)
        Me._ID_CHEQUE_PARTIDA = aID_CHEQUE_PARTIDA
        Me._ID_CHEQUE_PLANILLA = aID_CHEQUE_PLANILLA
        Me._ORDEN = aORDEN
        Me._CUENTA_CONTABLE = aCUENTA_CONTABLE
        Me._DESCRIPCION_CUENTA = aDESCRIPCION_CUENTA
        Me._DESCRIPCION_ADICIONAL = aDESCRIPCION_ADICIONAL
        Me._DEBE = aDEBE
        Me._HABER = aHABER
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
    End Sub

#Region " Properties "

    Private _ID_CHEQUE_PARTIDA As Int32
    <Column(Name:="Id cheque partida", Storage:="ID_CHEQUE_PARTIDA", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_CHEQUE_PARTIDA() As Int32
        Get
            Return _ID_CHEQUE_PARTIDA
        End Get
        Set(ByVal Value As Int32)
            _ID_CHEQUE_PARTIDA = Value
            OnPropertyChanged("ID_CHEQUE_PARTIDA")
        End Set
    End Property 

    Private _ID_CHEQUE_PLANILLA As Int32
    <Column(Name:="Id cheque planilla", Storage:="ID_CHEQUE_PLANILLA", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_CHEQUE_PLANILLA() As Int32
        Get
            Return _ID_CHEQUE_PLANILLA
        End Get
        Set(ByVal Value As Int32)
            _ID_CHEQUE_PLANILLA = Value
            OnPropertyChanged("ID_CHEQUE_PLANILLA")
        End Set
    End Property 

    Private _ID_CHEQUE_PLANILLAOld As Int32
    Public Property ID_CHEQUE_PLANILLAOld() As Int32
        Get
            Return _ID_CHEQUE_PLANILLAOld
        End Get
        Set(ByVal Value As Int32)
            _ID_CHEQUE_PLANILLAOld = Value
        End Set
    End Property 

    Private _fkID_CHEQUE_PLANILLA As CHEQUE_PLANILLA
    Public Property fkID_CHEQUE_PLANILLA() As CHEQUE_PLANILLA
        Get
            Return _fkID_CHEQUE_PLANILLA
        End Get
        Set(ByVal Value As CHEQUE_PLANILLA)
            _fkID_CHEQUE_PLANILLA = Value
        End Set
    End Property 

    Private _ORDEN As Int32
    <Column(Name:="Orden", Storage:="ORDEN", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
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

    Private _CUENTA_CONTABLE As String
    <Column(Name:="Cuenta contable", Storage:="CUENTA_CONTABLE", DbType:="VARCHAR(100) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 100)> _
    Public Property CUENTA_CONTABLE() As String
        Get
            Return _CUENTA_CONTABLE
        End Get
        Set(ByVal Value As String)
            _CUENTA_CONTABLE = Value
            OnPropertyChanged("CUENTA_CONTABLE")
        End Set
    End Property 

    Private _CUENTA_CONTABLEOld As String
    Public Property CUENTA_CONTABLEOld() As String
        Get
            Return _CUENTA_CONTABLEOld
        End Get
        Set(ByVal Value As String)
            _CUENTA_CONTABLEOld = Value
        End Set
    End Property 

    Private _DESCRIPCION_CUENTA As String
    <Column(Name:="Descripcion cuenta", Storage:="DESCRIPCION_CUENTA", DbType:="VARCHAR(200) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 200)> _
    Public Property DESCRIPCION_CUENTA() As String
        Get
            Return _DESCRIPCION_CUENTA
        End Get
        Set(ByVal Value As String)
            _DESCRIPCION_CUENTA = Value
            OnPropertyChanged("DESCRIPCION_CUENTA")
        End Set
    End Property 

    Private _DESCRIPCION_CUENTAOld As String
    Public Property DESCRIPCION_CUENTAOld() As String
        Get
            Return _DESCRIPCION_CUENTAOld
        End Get
        Set(ByVal Value As String)
            _DESCRIPCION_CUENTAOld = Value
        End Set
    End Property 

    Private _DESCRIPCION_ADICIONAL As String
    <Column(Name:="Descripcion adicional", Storage:="DESCRIPCION_ADICIONAL", DbType:="VARCHAR(200)", Id:=False), _
     DataObjectField(False, False, True, 200)> _
    Public Property DESCRIPCION_ADICIONAL() As String
        Get
            Return _DESCRIPCION_ADICIONAL
        End Get
        Set(ByVal Value As String)
            _DESCRIPCION_ADICIONAL = Value
            OnPropertyChanged("DESCRIPCION_ADICIONAL")
        End Set
    End Property 

    Private _DESCRIPCION_ADICIONALOld As String
    Public Property DESCRIPCION_ADICIONALOld() As String
        Get
            Return _DESCRIPCION_ADICIONALOld
        End Get
        Set(ByVal Value As String)
            _DESCRIPCION_ADICIONALOld = Value
        End Set
    End Property 

    Private _DEBE As Decimal
    <Column(Name:="Debe", Storage:="DEBE", DbType:="NUMERIC(20,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)> _
    Public Property DEBE() As Decimal
        Get
            Return _DEBE
        End Get
        Set(ByVal Value As Decimal)
            _DEBE = Value
            OnPropertyChanged("DEBE")
        End Set
    End Property 

    Private _DEBEOld As Decimal
    Public Property DEBEOld() As Decimal
        Get
            Return _DEBEOld
        End Get
        Set(ByVal Value As Decimal)
            _DEBEOld = Value
        End Set
    End Property 

    Private _HABER As Decimal
    <Column(Name:="Haber", Storage:="HABER", DbType:="NUMERIC(20,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)> _
    Public Property HABER() As Decimal
        Get
            Return _HABER
        End Get
        Set(ByVal Value As Decimal)
            _HABER = Value
            OnPropertyChanged("HABER")
        End Set
    End Property 

    Private _HABEROld As Decimal
    Public Property HABEROld() As Decimal
        Get
            Return _HABEROld
        End Get
        Set(ByVal Value As Decimal)
            _HABEROld = Value
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

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
