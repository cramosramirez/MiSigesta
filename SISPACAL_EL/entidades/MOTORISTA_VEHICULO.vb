''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.MOTORISTA_VEHICULO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row MOTORISTA_VEHICULO en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	26/11/2018	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="MOTORISTA_VEHICULO")> Public Class MOTORISTA_VEHICULO
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_MOTORISTA_VEHI As Int32, aID_MOTORISTA As Int32, aID_TRANSPORTE As Int32, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aES_PARTICULAR As Boolean, aVER_ORDEN_COMB As Boolean, aVER_PROFORMA As Boolean, aID_LIC As Int32, aACTIVO As Boolean, aCASTIGADO As Boolean, aID_ZAFRA As Int32, aUSUARIO_ACT As String, aFECHA_ACT As DateTime, aID_CARGADORA As Int32)
        Me._ID_MOTORISTA_VEHI = aID_MOTORISTA_VEHI
        Me._ID_MOTORISTA = aID_MOTORISTA
        Me._ID_TRANSPORTE = aID_TRANSPORTE
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._ES_PARTICULAR = aES_PARTICULAR
        Me._VER_ORDEN_COMB = aVER_ORDEN_COMB
        Me._VER_PROFORMA = aVER_PROFORMA
        Me._ID_LIC = aID_LIC
        Me._ACTIVO = aACTIVO
        Me._CASTIGADO = aCASTIGADO
        Me._ID_ZAFRA = aID_ZAFRA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
        Me._ID_CARGADORA = aID_CARGADORA
    End Sub

#Region " Properties "

    Private _ID_MOTORISTA_VEHI As Int32
    <Column(Name:="Id motorista vehi", Storage:="ID_MOTORISTA_VEHI", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_MOTORISTA_VEHI() As Int32
        Get
            Return _ID_MOTORISTA_VEHI
        End Get
        Set(ByVal Value As Int32)
            _ID_MOTORISTA_VEHI = Value
            OnPropertyChanged("ID_MOTORISTA_VEHI")
        End Set
    End Property 

    Private _ID_MOTORISTA As Int32
    <Column(Name:="Id motorista", Storage:="ID_MOTORISTA", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_MOTORISTA() As Int32
        Get
            Return _ID_MOTORISTA
        End Get
        Set(ByVal Value As Int32)
            _ID_MOTORISTA = Value
            OnPropertyChanged("ID_MOTORISTA")
        End Set
    End Property 

    Private _ID_MOTORISTAOld As Int32
    Public Property ID_MOTORISTAOld() As Int32
        Get
            Return _ID_MOTORISTAOld
        End Get
        Set(ByVal Value As Int32)
            _ID_MOTORISTAOld = Value
        End Set
    End Property 

    Private _fkID_MOTORISTA As MOTORISTA
    Public Property fkID_MOTORISTA() As MOTORISTA
        Get
            Return _fkID_MOTORISTA
        End Get
        Set(ByVal Value As MOTORISTA)
            _fkID_MOTORISTA = Value
        End Set
    End Property 

    Private _ID_TRANSPORTE As Int32
    <Column(Name:="Id transporte", Storage:="ID_TRANSPORTE", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_TRANSPORTE() As Int32
        Get
            Return _ID_TRANSPORTE
        End Get
        Set(ByVal Value As Int32)
            _ID_TRANSPORTE = Value
            OnPropertyChanged("ID_TRANSPORTE")
        End Set
    End Property 

    Private _ID_TRANSPORTEOld As Int32
    Public Property ID_TRANSPORTEOld() As Int32
        Get
            Return _ID_TRANSPORTEOld
        End Get
        Set(ByVal Value As Int32)
            _ID_TRANSPORTEOld = Value
        End Set
    End Property 

    Private _fkID_TRANSPORTE As TRANSPORTE
    Public Property fkID_TRANSPORTE() As TRANSPORTE
        Get
            Return _fkID_TRANSPORTE
        End Get
        Set(ByVal Value As TRANSPORTE)
            _fkID_TRANSPORTE = Value
        End Set
    End Property 

    Private _USUARIO_CREA As String
    <Column(Name:="Usuario crea", Storage:="USUARIO_CREA", DbType:="VARCHAR(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
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

    Private _ES_PARTICULAR As Boolean
    <Column(Name:="Es particular", Storage:="ES_PARTICULAR", DbType:="BIT", Id:=False), _
     DataObjectField(False, False, True, 1)> _
    Public Property ES_PARTICULAR() As Boolean
        Get
            Return _ES_PARTICULAR
        End Get
        Set(ByVal Value As Boolean)
            _ES_PARTICULAR = Value
            OnPropertyChanged("ES_PARTICULAR")
        End Set
    End Property 

    Private _ES_PARTICULAROld As Boolean
    Public Property ES_PARTICULAROld() As Boolean
        Get
            Return _ES_PARTICULAROld
        End Get
        Set(ByVal Value As Boolean)
            _ES_PARTICULAROld = Value
        End Set
    End Property 

    Private _VER_ORDEN_COMB As Boolean
    <Column(Name:="Ver orden comb", Storage:="VER_ORDEN_COMB", DbType:="BIT", Id:=False), _
     DataObjectField(False, False, True, 1)> _
    Public Property VER_ORDEN_COMB() As Boolean
        Get
            Return _VER_ORDEN_COMB
        End Get
        Set(ByVal Value As Boolean)
            _VER_ORDEN_COMB = Value
            OnPropertyChanged("VER_ORDEN_COMB")
        End Set
    End Property 

    Private _VER_ORDEN_COMBOld As Boolean
    Public Property VER_ORDEN_COMBOld() As Boolean
        Get
            Return _VER_ORDEN_COMBOld
        End Get
        Set(ByVal Value As Boolean)
            _VER_ORDEN_COMBOld = Value
        End Set
    End Property 

    Private _VER_PROFORMA As Boolean
    <Column(Name:="Ver proforma", Storage:="VER_PROFORMA", DbType:="BIT", Id:=False), _
     DataObjectField(False, False, True, 1)> _
    Public Property VER_PROFORMA() As Boolean
        Get
            Return _VER_PROFORMA
        End Get
        Set(ByVal Value As Boolean)
            _VER_PROFORMA = Value
            OnPropertyChanged("VER_PROFORMA")
        End Set
    End Property 

    Private _VER_PROFORMAOld As Boolean
    Public Property VER_PROFORMAOld() As Boolean
        Get
            Return _VER_PROFORMAOld
        End Get
        Set(ByVal Value As Boolean)
            _VER_PROFORMAOld = Value
        End Set
    End Property 

    Private _ID_LIC As Int32
    <Column(Name:="Id lic", Storage:="ID_LIC", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_LIC() As Int32
        Get
            Return _ID_LIC
        End Get
        Set(ByVal Value As Int32)
            _ID_LIC = Value
            OnPropertyChanged("ID_LIC")
        End Set
    End Property 

    Private _ID_LICOld As Int32
    Public Property ID_LICOld() As Int32
        Get
            Return _ID_LICOld
        End Get
        Set(ByVal Value As Int32)
            _ID_LICOld = Value
        End Set
    End Property 

    Private _ACTIVO As Boolean
    <Column(Name:="Activo", Storage:="ACTIVO", DbType:="BIT", Id:=False), _
     DataObjectField(False, False, True, 1)> _
    Public Property ACTIVO() As Boolean
        Get
            Return _ACTIVO
        End Get
        Set(ByVal Value As Boolean)
            _ACTIVO = Value
            OnPropertyChanged("ACTIVO")
        End Set
    End Property 

    Private _ACTIVOOld As Boolean
    Public Property ACTIVOOld() As Boolean
        Get
            Return _ACTIVOOld
        End Get
        Set(ByVal Value As Boolean)
            _ACTIVOOld = Value
        End Set
    End Property 

    Private _CASTIGADO As Boolean
    <Column(Name:="Castigado", Storage:="CASTIGADO", DbType:="BIT", Id:=False), _
     DataObjectField(False, False, True, 1)> _
    Public Property CASTIGADO() As Boolean
        Get
            Return _CASTIGADO
        End Get
        Set(ByVal Value As Boolean)
            _CASTIGADO = Value
            OnPropertyChanged("CASTIGADO")
        End Set
    End Property 

    Private _CASTIGADOOld As Boolean
    Public Property CASTIGADOOld() As Boolean
        Get
            Return _CASTIGADOOld
        End Get
        Set(ByVal Value As Boolean)
            _CASTIGADOOld = Value
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

    Private _USUARIO_ACT As String
    <Column(Name:="Usuario act", Storage:="USUARIO_ACT", DbType:="VARCHAR(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
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

    Private _ID_CARGADORA As Int32
    <Column(Name:="Id cargadora", Storage:="ID_CARGADORA", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_CARGADORA() As Int32
        Get
            Return _ID_CARGADORA
        End Get
        Set(ByVal Value As Int32)
            _ID_CARGADORA = Value
            OnPropertyChanged("ID_CARGADORA")
        End Set
    End Property 

    Private _ID_CARGADORAOld As Int32
    Public Property ID_CARGADORAOld() As Int32
        Get
            Return _ID_CARGADORAOld
        End Get
        Set(ByVal Value As Int32)
            _ID_CARGADORAOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
