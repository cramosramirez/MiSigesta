''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.SOLIC_AGRICOLA_LOTE
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row SOLIC_AGRICOLA_LOTE en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	04/09/2017	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="SOLIC_AGRICOLA_LOTE")> Public Class SOLIC_AGRICOLA_LOTE
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_SOLIC_AGRI_LOTE As Int32, aID_SOLICITUD As Int32, aID_ZAFRA As Int32, aACCESLOTE As String, aMZ As Decimal, aTONEL_ESTI As Decimal, aRIEGO_APLICADO As Boolean, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime, aZAFRA As String, aCODIVARIEDA As String)
        Me._ID_SOLIC_AGRI_LOTE = aID_SOLIC_AGRI_LOTE
        Me._ID_SOLICITUD = aID_SOLICITUD
        Me._ID_ZAFRA = aID_ZAFRA
        Me._ACCESLOTE = aACCESLOTE
        Me._MZ = aMZ
        Me._TONEL_ESTI = aTONEL_ESTI
        Me._RIEGO_APLICADO = aRIEGO_APLICADO
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
        Me._ZAFRA = aZAFRA
        Me._CODIVARIEDA = aCODIVARIEDA
    End Sub

#Region " Properties "

    Private _ID_SOLIC_AGRI_LOTE As Int32
    <Column(Name:="Id solic agri lote", Storage:="ID_SOLIC_AGRI_LOTE", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_SOLIC_AGRI_LOTE() As Int32
        Get
            Return _ID_SOLIC_AGRI_LOTE
        End Get
        Set(ByVal Value As Int32)
            _ID_SOLIC_AGRI_LOTE = Value
            OnPropertyChanged("ID_SOLIC_AGRI_LOTE")
        End Set
    End Property 

    Private _ID_SOLICITUD As Int32
    <Column(Name:="Id solicitud", Storage:="ID_SOLICITUD", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_SOLICITUD() As Int32
        Get
            Return _ID_SOLICITUD
        End Get
        Set(ByVal Value As Int32)
            _ID_SOLICITUD = Value
            OnPropertyChanged("ID_SOLICITUD")
        End Set
    End Property 

    Private _ID_SOLICITUDOld As Int32
    Public Property ID_SOLICITUDOld() As Int32
        Get
            Return _ID_SOLICITUDOld
        End Get
        Set(ByVal Value As Int32)
            _ID_SOLICITUDOld = Value
        End Set
    End Property 

    Private _fkID_SOLICITUD As SOLIC_AGRICOLA
    Public Property fkID_SOLICITUD() As SOLIC_AGRICOLA
        Get
            Return _fkID_SOLICITUD
        End Get
        Set(ByVal Value As SOLIC_AGRICOLA)
            _fkID_SOLICITUD = Value
        End Set
    End Property 

    Private _ID_ZAFRA As Int32
    <Column(Name:="Id zafra", Storage:="ID_ZAFRA", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
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

    Private _RIEGO_APLICADO As Boolean
    <Column(Name:="Riego aplicado", Storage:="RIEGO_APLICADO", DbType:="BIT NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 1)> _
    Public Property RIEGO_APLICADO() As Boolean
        Get
            Return _RIEGO_APLICADO
        End Get
        Set(ByVal Value As Boolean)
            _RIEGO_APLICADO = Value
            OnPropertyChanged("RIEGO_APLICADO")
        End Set
    End Property 

    Private _RIEGO_APLICADOOld As Boolean
    Public Property RIEGO_APLICADOOld() As Boolean
        Get
            Return _RIEGO_APLICADOOld
        End Get
        Set(ByVal Value As Boolean)
            _RIEGO_APLICADOOld = Value
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

    Private _ZAFRA As String
    <Column(Name:="Zafra", Storage:="ZAFRA", DbType:="VARCHAR(9) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 9)> _
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

    Private _CODIVARIEDA As String
    <Column(Name:="Codivarieda", Storage:="CODIVARIEDA", DbType:="CHAR(3)", Id:=False), _
     DataObjectField(False, False, True, 3)> _
    Public Property CODIVARIEDA() As String
        Get
            Return _CODIVARIEDA
        End Get
        Set(ByVal Value As String)
            _CODIVARIEDA = Value
            OnPropertyChanged("CODIVARIEDA")
        End Set
    End Property 

    Private _CODIVARIEDAOld As String
    Public Property CODIVARIEDAOld() As String
        Get
            Return _CODIVARIEDAOld
        End Get
        Set(ByVal Value As String)
            _CODIVARIEDAOld = Value
        End Set
    End Property 

    Private _fkCODIVARIEDA As VARIEDAD
    Public Property fkCODIVARIEDA() As VARIEDAD
        Get
            Return _fkCODIVARIEDA
        End Get
        Set(ByVal Value As VARIEDAD)
            _fkCODIVARIEDA = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
