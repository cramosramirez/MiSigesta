''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.ANTICIPO_CANA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row ANTICIPO_CANA en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	03/11/2014	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="ANTICIPO_CANA")> Public Class ANTICIPO_CANA
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_ANTICIPO_CANA As Int32, aID_ZAFRA As Int32, aID_CATORCENA As Int32, aNO_ANTICIPO As Int32, aNO_ANTICIPO_LETRAS As String, aVALOR_ANTICIPO As Decimal, aFECHA_INICIO As DateTime, aFECHA_FINAL As DateTime, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime, aFECHA_PAGO As DateTime, aES_COMP_VFP As Boolean)
        Me._ID_ANTICIPO_CANA = aID_ANTICIPO_CANA
        Me._ID_ZAFRA = aID_ZAFRA
        Me._ID_CATORCENA = aID_CATORCENA
        Me._NO_ANTICIPO = aNO_ANTICIPO
        Me._NO_ANTICIPO_LETRAS = aNO_ANTICIPO_LETRAS
        Me._VALOR_ANTICIPO = aVALOR_ANTICIPO
        Me._FECHA_INICIO = aFECHA_INICIO
        Me._FECHA_FINAL = aFECHA_FINAL
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
        Me._FECHA_PAGO = aFECHA_PAGO
        Me._ES_COMP_VFP = aES_COMP_VFP
    End Sub

#Region " Properties "

    Private _ID_ANTICIPO_CANA As Int32
    <Column(Name:="Id anticipo cana", Storage:="ID_ANTICIPO_CANA", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_ANTICIPO_CANA() As Int32
        Get
            Return _ID_ANTICIPO_CANA
        End Get
        Set(ByVal Value As Int32)
            _ID_ANTICIPO_CANA = Value
            OnPropertyChanged("ID_ANTICIPO_CANA")
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

    Private _ID_CATORCENA As Int32
    <Column(Name:="Id catorcena", Storage:="ID_CATORCENA", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_CATORCENA() As Int32
        Get
            Return _ID_CATORCENA
        End Get
        Set(ByVal Value As Int32)
            _ID_CATORCENA = Value
            OnPropertyChanged("ID_CATORCENA")
        End Set
    End Property 

    Private _ID_CATORCENAOld As Int32
    Public Property ID_CATORCENAOld() As Int32
        Get
            Return _ID_CATORCENAOld
        End Get
        Set(ByVal Value As Int32)
            _ID_CATORCENAOld = Value
        End Set
    End Property 

    Private _fkID_CATORCENA As CATORCENA_ZAFRA
    Public Property fkID_CATORCENA() As CATORCENA_ZAFRA
        Get
            Return _fkID_CATORCENA
        End Get
        Set(ByVal Value As CATORCENA_ZAFRA)
            _fkID_CATORCENA = Value
        End Set
    End Property 

    Private _NO_ANTICIPO As Int32
    <Column(Name:="No anticipo", Storage:="NO_ANTICIPO", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property NO_ANTICIPO() As Int32
        Get
            Return _NO_ANTICIPO
        End Get
        Set(ByVal Value As Int32)
            _NO_ANTICIPO = Value
            OnPropertyChanged("NO_ANTICIPO")
        End Set
    End Property 

    Private _NO_ANTICIPOOld As Int32
    Public Property NO_ANTICIPOOld() As Int32
        Get
            Return _NO_ANTICIPOOld
        End Get
        Set(ByVal Value As Int32)
            _NO_ANTICIPOOld = Value
        End Set
    End Property 

    Private _NO_ANTICIPO_LETRAS As String
    <Column(Name:="No anticipo letras", Storage:="NO_ANTICIPO_LETRAS", DbType:="VARCHAR(50) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 50)> _
    Public Property NO_ANTICIPO_LETRAS() As String
        Get
            Return _NO_ANTICIPO_LETRAS
        End Get
        Set(ByVal Value As String)
            _NO_ANTICIPO_LETRAS = Value
            OnPropertyChanged("NO_ANTICIPO_LETRAS")
        End Set
    End Property 

    Private _NO_ANTICIPO_LETRASOld As String
    Public Property NO_ANTICIPO_LETRASOld() As String
        Get
            Return _NO_ANTICIPO_LETRASOld
        End Get
        Set(ByVal Value As String)
            _NO_ANTICIPO_LETRASOld = Value
        End Set
    End Property 

    Private _VALOR_ANTICIPO As Decimal
    <Column(Name:="Valor anticipo", Storage:="VALOR_ANTICIPO", DbType:="NUMERIC(22,20) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=22, Scale:=20)> _
    Public Property VALOR_ANTICIPO() As Decimal
        Get
            Return _VALOR_ANTICIPO
        End Get
        Set(ByVal Value As Decimal)
            _VALOR_ANTICIPO = Value
            OnPropertyChanged("VALOR_ANTICIPO")
        End Set
    End Property 

    Private _VALOR_ANTICIPOOld As Decimal
    Public Property VALOR_ANTICIPOOld() As Decimal
        Get
            Return _VALOR_ANTICIPOOld
        End Get
        Set(ByVal Value As Decimal)
            _VALOR_ANTICIPOOld = Value
        End Set
    End Property 

    Private _FECHA_INICIO As DateTime
    <Column(Name:="Fecha inicio", Storage:="FECHA_INICIO", DbType:="DATETIME NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
    Public Property FECHA_INICIO() As DateTime
        Get
            Return _FECHA_INICIO
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_INICIO = Value
            OnPropertyChanged("FECHA_INICIO")
        End Set
    End Property 

    Private _FECHA_INICIOOld As DateTime
    Public Property FECHA_INICIOOld() As DateTime
        Get
            Return _FECHA_INICIOOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_INICIOOld = Value
        End Set
    End Property 

    Private _FECHA_FINAL As DateTime
    <Column(Name:="Fecha final", Storage:="FECHA_FINAL", DbType:="DATETIME NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
    Public Property FECHA_FINAL() As DateTime
        Get
            Return _FECHA_FINAL
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_FINAL = Value
            OnPropertyChanged("FECHA_FINAL")
        End Set
    End Property 

    Private _FECHA_FINALOld As DateTime
    Public Property FECHA_FINALOld() As DateTime
        Get
            Return _FECHA_FINALOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_FINALOld = Value
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

    Private _FECHA_PAGO As DateTime
    <Column(Name:="Fecha pago", Storage:="FECHA_PAGO", DbType:="DATETIME", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_PAGO() As DateTime
        Get
            Return _FECHA_PAGO
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_PAGO = Value
            OnPropertyChanged("FECHA_PAGO")
        End Set
    End Property 

    Private _FECHA_PAGOOld As DateTime
    Public Property FECHA_PAGOOld() As DateTime
        Get
            Return _FECHA_PAGOOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_PAGOOld = Value
        End Set
    End Property 

    Private _ES_COMP_VFP As Boolean
    <Column(Name:="Es comp vfp", Storage:="ES_COMP_VFP", DbType:="BIT NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 1)> _
    Public Property ES_COMP_VFP() As Boolean
        Get
            Return _ES_COMP_VFP
        End Get
        Set(ByVal Value As Boolean)
            _ES_COMP_VFP = Value
            OnPropertyChanged("ES_COMP_VFP")
        End Set
    End Property 

    Private _ES_COMP_VFPOld As Boolean
    Public Property ES_COMP_VFPOld() As Boolean
        Get
            Return _ES_COMP_VFPOld
        End Get
        Set(ByVal Value As Boolean)
            _ES_COMP_VFPOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
