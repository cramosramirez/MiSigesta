''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.CHEQUERA_PLANILLA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row CHEQUERA_PLANILLA en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	06/12/2013	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="CHEQUERA_PLANILLA")> Public Class CHEQUERA_PLANILLA
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_CHEQUERA As Int32, aID_CUENTA As Int32, aSERIE As String, aNO_CHEQUE_INICIAL As Int32, aNO_CHEQUE_FINAL As Int32, aULT_CHEQUE_ASIGNADO As Int32, aACTIVO As Boolean, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime)
        Me._ID_CHEQUERA = aID_CHEQUERA
        Me._ID_CUENTA = aID_CUENTA
        Me._SERIE = aSERIE
        Me._NO_CHEQUE_INICIAL = aNO_CHEQUE_INICIAL
        Me._NO_CHEQUE_FINAL = aNO_CHEQUE_FINAL
        Me._ULT_CHEQUE_ASIGNADO = aULT_CHEQUE_ASIGNADO
        Me._ACTIVO = aACTIVO
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
    End Sub

#Region " Properties "

    Private _ID_CHEQUERA As Int32
    <Column(Name:="Id chequera", Storage:="ID_CHEQUERA", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_CHEQUERA() As Int32
        Get
            Return _ID_CHEQUERA
        End Get
        Set(ByVal Value As Int32)
            _ID_CHEQUERA = Value
            OnPropertyChanged("ID_CHEQUERA")
        End Set
    End Property 

    Private _ID_CUENTA As Int32
    <Column(Name:="Id cuenta", Storage:="ID_CUENTA", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_CUENTA() As Int32
        Get
            Return _ID_CUENTA
        End Get
        Set(ByVal Value As Int32)
            _ID_CUENTA = Value
            OnPropertyChanged("ID_CUENTA")
        End Set
    End Property 

    Private _ID_CUENTAOld As Int32
    Public Property ID_CUENTAOld() As Int32
        Get
            Return _ID_CUENTAOld
        End Get
        Set(ByVal Value As Int32)
            _ID_CUENTAOld = Value
        End Set
    End Property 

    Private _fkID_CUENTA As CUENTA_BANCARIA
    Public Property fkID_CUENTA() As CUENTA_BANCARIA
        Get
            Return _fkID_CUENTA
        End Get
        Set(ByVal Value As CUENTA_BANCARIA)
            _fkID_CUENTA = Value
        End Set
    End Property 

    Private _SERIE As String
    <Column(Name:="Serie", Storage:="SERIE", DbType:="VARCHAR(20) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 20)> _
    Public Property SERIE() As String
        Get
            Return _SERIE
        End Get
        Set(ByVal Value As String)
            _SERIE = Value
            OnPropertyChanged("SERIE")
        End Set
    End Property 

    Private _SERIEOld As String
    Public Property SERIEOld() As String
        Get
            Return _SERIEOld
        End Get
        Set(ByVal Value As String)
            _SERIEOld = Value
        End Set
    End Property 

    Private _NO_CHEQUE_INICIAL As Int32
    <Column(Name:="No cheque inicial", Storage:="NO_CHEQUE_INICIAL", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property NO_CHEQUE_INICIAL() As Int32
        Get
            Return _NO_CHEQUE_INICIAL
        End Get
        Set(ByVal Value As Int32)
            _NO_CHEQUE_INICIAL = Value
            OnPropertyChanged("NO_CHEQUE_INICIAL")
        End Set
    End Property 

    Private _NO_CHEQUE_INICIALOld As Int32
    Public Property NO_CHEQUE_INICIALOld() As Int32
        Get
            Return _NO_CHEQUE_INICIALOld
        End Get
        Set(ByVal Value As Int32)
            _NO_CHEQUE_INICIALOld = Value
        End Set
    End Property 

    Private _NO_CHEQUE_FINAL As Int32
    <Column(Name:="No cheque final", Storage:="NO_CHEQUE_FINAL", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property NO_CHEQUE_FINAL() As Int32
        Get
            Return _NO_CHEQUE_FINAL
        End Get
        Set(ByVal Value As Int32)
            _NO_CHEQUE_FINAL = Value
            OnPropertyChanged("NO_CHEQUE_FINAL")
        End Set
    End Property 

    Private _NO_CHEQUE_FINALOld As Int32
    Public Property NO_CHEQUE_FINALOld() As Int32
        Get
            Return _NO_CHEQUE_FINALOld
        End Get
        Set(ByVal Value As Int32)
            _NO_CHEQUE_FINALOld = Value
        End Set
    End Property 

    Private _ULT_CHEQUE_ASIGNADO As Int32
    <Column(Name:="Ult cheque asignado", Storage:="ULT_CHEQUE_ASIGNADO", DbType:="INT NULL", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ULT_CHEQUE_ASIGNADO() As Int32
        Get
            Return _ULT_CHEQUE_ASIGNADO
        End Get
        Set(ByVal Value As Int32)
            _ULT_CHEQUE_ASIGNADO = Value
            OnPropertyChanged("ULT_CHEQUE_ASIGNADO")
        End Set
    End Property

    Private _ULT_CHEQUE_ASIGNADOOld As Int32
    Public Property ULT_CHEQUE_ASIGNADOOld() As Int32
        Get
            Return _ULT_CHEQUE_ASIGNADOOld
        End Get
        Set(ByVal Value As Int32)
            _ULT_CHEQUE_ASIGNADOOld = Value
        End Set
    End Property 

    Private _ACTIVO As Boolean
    <Column(Name:="Activo", Storage:="ACTIVO", DbType:="BIT NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 1)> _
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
