''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.SOLIC_OIP_LOTE
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row SOLIC_OIP_LOTE en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	13/07/2020	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="SOLIC_OIP_LOTE")> Public Class SOLIC_OIP_LOTE
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_SOLI_LOTE As Int32, aID_OPI As Int32, aACCESLOTE As String, aMZ As Decimal, aTONEL_ESTI As Decimal, aPROPORCION As Decimal, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime, aID_ZAFRA As Integer)
        Me._ID_SOLI_LOTE = aID_SOLI_LOTE
        Me._ID_OPI = aID_OPI
        Me._ACCESLOTE = aACCESLOTE
        Me._MZ = aMZ
        Me._TONEL_ESTI = aTONEL_ESTI
        Me._PROPORCION = aPROPORCION
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
        Me._ID_ZAFRA = aID_ZAFRA
    End Sub

#Region " Properties "

    Private _ID_SOLI_LOTE As Int32
    <Column(Name:="Id soli lote", Storage:="ID_SOLI_LOTE", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_SOLI_LOTE() As Int32
        Get
            Return _ID_SOLI_LOTE
        End Get
        Set(ByVal Value As Int32)
            _ID_SOLI_LOTE = Value
            OnPropertyChanged("ID_SOLI_LOTE")
        End Set
    End Property 

    Private _ID_OPI As Int32
    <Column(Name:="Id opi", Storage:="ID_OPI", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_OPI() As Int32
        Get
            Return _ID_OPI
        End Get
        Set(ByVal Value As Int32)
            _ID_OPI = Value
            OnPropertyChanged("ID_OPI")
        End Set
    End Property 

    Private _ID_OPIOld As Int32
    Public Property ID_OPIOld() As Int32
        Get
            Return _ID_OPIOld
        End Get
        Set(ByVal Value As Int32)
            _ID_OPIOld = Value
        End Set
    End Property 

    Private _fkID_OPI As SOLIC_OPI
    Public Property fkID_OPI() As SOLIC_OPI
        Get
            Return _fkID_OPI
        End Get
        Set(ByVal Value As SOLIC_OPI)
            _fkID_OPI = Value
        End Set
    End Property 

    Private _ACCESLOTE As String
    <Column(Name:="Acceslote", Storage:="ACCESLOTE", DbType:="CHAR(21) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 21)> _
    Public Property ACCESLOTE() As String
        Get
            Return _ACCESLOTE
        End Get
        Set(ByVal Value As String)
            _ACCESLOTE = Value
            OnPropertyChanged("ACCESLOTE")
        End Set
    End Property 

    Private _ACCESLOTEOld As String
    Public Property ACCESLOTEOld() As String
        Get
            Return _ACCESLOTEOld
        End Get
        Set(ByVal Value As String)
            _ACCESLOTEOld = Value
        End Set
    End Property 

    Private _fkACCESLOTE As LOTES
    Public Property fkACCESLOTE() As LOTES
        Get
            Return _fkACCESLOTE
        End Get
        Set(ByVal Value As LOTES)
            _fkACCESLOTE = Value
        End Set
    End Property 

    Private _MZ As Decimal
    <Column(Name:="Mz", Storage:="MZ", DbType:="NUMERIC(10,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)> _
    Public Property MZ() As Decimal
        Get
            Return _MZ
        End Get
        Set(ByVal Value As Decimal)
            _MZ = Value
            OnPropertyChanged("MZ")
        End Set
    End Property 

    Private _MZOld As Decimal
    Public Property MZOld() As Decimal
        Get
            Return _MZOld
        End Get
        Set(ByVal Value As Decimal)
            _MZOld = Value
        End Set
    End Property 

    Private _TONEL_ESTI As Decimal
    <Column(Name:="Tonel esti", Storage:="TONEL_ESTI", DbType:="NUMERIC(10,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)> _
    Public Property TONEL_ESTI() As Decimal
        Get
            Return _TONEL_ESTI
        End Get
        Set(ByVal Value As Decimal)
            _TONEL_ESTI = Value
            OnPropertyChanged("TONEL_ESTI")
        End Set
    End Property 

    Private _TONEL_ESTIOld As Decimal
    Public Property TONEL_ESTIOld() As Decimal
        Get
            Return _TONEL_ESTIOld
        End Get
        Set(ByVal Value As Decimal)
            _TONEL_ESTIOld = Value
        End Set
    End Property 

    Private _PROPORCION As Decimal
    <Column(Name:="Proporcion", Storage:="PROPORCION", DbType:="NUMERIC(20,8) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=8)> _
    Public Property PROPORCION() As Decimal
        Get
            Return _PROPORCION
        End Get
        Set(ByVal Value As Decimal)
            _PROPORCION = Value
            OnPropertyChanged("PROPORCION")
        End Set
    End Property 

    Private _PROPORCIONOld As Decimal
    Public Property PROPORCIONOld() As Decimal
        Get
            Return _PROPORCIONOld
        End Get
        Set(ByVal Value As Decimal)
            _PROPORCIONOld = Value
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

    Private _ID_ZAFRA As Int32
    <Column(Name:="Id zafra", Storage:="ID_ZAFRA", DBType:="INT NOT NULL", Id:=False),
     DataObjectField(False, False, False)>
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

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
