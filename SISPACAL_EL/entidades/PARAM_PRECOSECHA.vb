''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.PARAM_PRECOSECHA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row PARAM_PRECOSECHA en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	18/09/2014	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="PARAM_PRECOSECHA")> Public Class PARAM_PRECOSECHA
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_PARAM_PRECOSECHA As Int32, aID_ZAFRA As Int32, aCTE_A_DEXTRA As Decimal, aCTE_B_DEXTRA As Decimal, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_CT As DateTime)
        Me._ID_PARAM_PRECOSECHA = aID_PARAM_PRECOSECHA
        Me._ID_ZAFRA = aID_ZAFRA
        Me._CTE_A_DEXTRA = aCTE_A_DEXTRA
        Me._CTE_B_DEXTRA = aCTE_B_DEXTRA
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_CT = aFECHA_CT
    End Sub

#Region " Properties "

    Private _ID_PARAM_PRECOSECHA As Int32
    <Column(Name:="Id param precosecha", Storage:="ID_PARAM_PRECOSECHA", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_PARAM_PRECOSECHA() As Int32
        Get
            Return _ID_PARAM_PRECOSECHA
        End Get
        Set(ByVal Value As Int32)
            _ID_PARAM_PRECOSECHA = Value
            OnPropertyChanged("ID_PARAM_PRECOSECHA")
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

    Private _CTE_A_DEXTRA As Decimal
    <Column(Name:="Cte a dextra", Storage:="CTE_A_DEXTRA", DbType:="NUMERIC(15,6) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=15, Scale:=6)> _
    Public Property CTE_A_DEXTRA() As Decimal
        Get
            Return _CTE_A_DEXTRA
        End Get
        Set(ByVal Value As Decimal)
            _CTE_A_DEXTRA = Value
            OnPropertyChanged("CTE_A_DEXTRA")
        End Set
    End Property 

    Private _CTE_A_DEXTRAOld As Decimal
    Public Property CTE_A_DEXTRAOld() As Decimal
        Get
            Return _CTE_A_DEXTRAOld
        End Get
        Set(ByVal Value As Decimal)
            _CTE_A_DEXTRAOld = Value
        End Set
    End Property 

    Private _CTE_B_DEXTRA As Decimal
    <Column(Name:="Cte b dextra", Storage:="CTE_B_DEXTRA", DbType:="NUMERIC(15,6) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=15, Scale:=6)> _
    Public Property CTE_B_DEXTRA() As Decimal
        Get
            Return _CTE_B_DEXTRA
        End Get
        Set(ByVal Value As Decimal)
            _CTE_B_DEXTRA = Value
            OnPropertyChanged("CTE_B_DEXTRA")
        End Set
    End Property 

    Private _CTE_B_DEXTRAOld As Decimal
    Public Property CTE_B_DEXTRAOld() As Decimal
        Get
            Return _CTE_B_DEXTRAOld
        End Get
        Set(ByVal Value As Decimal)
            _CTE_B_DEXTRAOld = Value
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

    Private _FECHA_CT As DateTime
    <Column(Name:="Fecha ct", Storage:="FECHA_CT", DbType:="DATETIME NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
    Public Property FECHA_CT() As DateTime
        Get
            Return _FECHA_CT
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_CT = Value
            OnPropertyChanged("FECHA_CT")
        End Set
    End Property 

    Private _FECHA_CTOld As DateTime
    Public Property FECHA_CTOld() As DateTime
        Get
            Return _FECHA_CTOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_CTOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
