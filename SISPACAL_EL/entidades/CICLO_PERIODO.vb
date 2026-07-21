''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.CICLO_PERIODO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row CICLO_PERIODO en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	27/10/2014	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="CICLO_PERIODO")> Public Class CICLO_PERIODO
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_CICLO_PERIODO As Int32, aID_CICLO As Int32, aFECHA As DateTime, aSEMANA As Int32, aCATORCENA As Int32, aTERCIO As Int32, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime, aSUB_TERCIO As String, aTC_DIA As Decimal)
        Me._ID_CICLO_PERIODO = aID_CICLO_PERIODO
        Me._ID_CICLO = aID_CICLO
        Me._FECHA = aFECHA
        Me._SEMANA = aSEMANA
        Me._CATORCENA = aCATORCENA
        Me._TERCIO = aTERCIO
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
        Me._SUB_TERCIO = aSUB_TERCIO
        Me._TC_DIA = aTC_DIA
    End Sub

#Region " Properties "

    Private _ID_CICLO_PERIODO As Int32
    <Column(Name:="Id ciclo periodo", Storage:="ID_CICLO_PERIODO", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_CICLO_PERIODO() As Int32
        Get
            Return _ID_CICLO_PERIODO
        End Get
        Set(ByVal Value As Int32)
            _ID_CICLO_PERIODO = Value
            OnPropertyChanged("ID_CICLO_PERIODO")
        End Set
    End Property 

    Private _ID_CICLO As Int32
    <Column(Name:="Id ciclo", Storage:="ID_CICLO", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_CICLO() As Int32
        Get
            Return _ID_CICLO
        End Get
        Set(ByVal Value As Int32)
            _ID_CICLO = Value
            OnPropertyChanged("ID_CICLO")
        End Set
    End Property 

    Private _ID_CICLOOld As Int32
    Public Property ID_CICLOOld() As Int32
        Get
            Return _ID_CICLOOld
        End Get
        Set(ByVal Value As Int32)
            _ID_CICLOOld = Value
        End Set
    End Property 

    Private _fkID_CICLO As CICLO
    Public Property fkID_CICLO() As CICLO
        Get
            Return _fkID_CICLO
        End Get
        Set(ByVal Value As CICLO)
            _fkID_CICLO = Value
        End Set
    End Property 

    Private _FECHA As DateTime
    <Column(Name:="Fecha", Storage:="FECHA", DbType:="DATETIME NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
    Public Property FECHA() As DateTime
        Get
            Return _FECHA
        End Get
        Set(ByVal Value As DateTime)
            _FECHA = Value
            OnPropertyChanged("FECHA")
        End Set
    End Property 

    Private _FECHAOld As DateTime
    Public Property FECHAOld() As DateTime
        Get
            Return _FECHAOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHAOld = Value
        End Set
    End Property 

    Private _SEMANA As Int32
    <Column(Name:="Semana", Storage:="SEMANA", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property SEMANA() As Int32
        Get
            Return _SEMANA
        End Get
        Set(ByVal Value As Int32)
            _SEMANA = Value
            OnPropertyChanged("SEMANA")
        End Set
    End Property 

    Private _SEMANAOld As Int32
    Public Property SEMANAOld() As Int32
        Get
            Return _SEMANAOld
        End Get
        Set(ByVal Value As Int32)
            _SEMANAOld = Value
        End Set
    End Property 

    Private _CATORCENA As Int32
    <Column(Name:="Catorcena", Storage:="CATORCENA", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property CATORCENA() As Int32
        Get
            Return _CATORCENA
        End Get
        Set(ByVal Value As Int32)
            _CATORCENA = Value
            OnPropertyChanged("CATORCENA")
        End Set
    End Property 

    Private _CATORCENAOld As Int32
    Public Property CATORCENAOld() As Int32
        Get
            Return _CATORCENAOld
        End Get
        Set(ByVal Value As Int32)
            _CATORCENAOld = Value
        End Set
    End Property 

    Private _TERCIO As Int32
    <Column(Name:="Tercio", Storage:="TERCIO", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property TERCIO() As Int32
        Get
            Return _TERCIO
        End Get
        Set(ByVal Value As Int32)
            _TERCIO = Value
            OnPropertyChanged("TERCIO")
        End Set
    End Property 

    Private _TERCIOOld As Int32
    Public Property TERCIOOld() As Int32
        Get
            Return _TERCIOOld
        End Get
        Set(ByVal Value As Int32)
            _TERCIOOld = Value
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

    Private _SUB_TERCIO As String
    <Column(Name:="Sub tercio", Storage:="SUB_TERCIO", DbType:="VARCHAR(20)", Id:=False), _
     DataObjectField(False, False, True, 20)> _
    Public Property SUB_TERCIO() As String
        Get
            Return _SUB_TERCIO
        End Get
        Set(ByVal Value As String)
            _SUB_TERCIO = Value
            OnPropertyChanged("SUB_TERCIO")
        End Set
    End Property 

    Private _SUB_TERCIOOld As String
    Public Property SUB_TERCIOOld() As String
        Get
            Return _SUB_TERCIOOld
        End Get
        Set(ByVal Value As String)
            _SUB_TERCIOOld = Value
        End Set
    End Property 

    Private _TC_DIA As Decimal
    <Column(Name:="Tc dia", Storage:="TC_DIA", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property TC_DIA() As Decimal
        Get
            Return _TC_DIA
        End Get
        Set(ByVal Value As Decimal)
            _TC_DIA = Value
            OnPropertyChanged("TC_DIA")
        End Set
    End Property 

    Private _TC_DIAOld As Decimal
    Public Property TC_DIAOld() As Decimal
        Get
            Return _TC_DIAOld
        End Get
        Set(ByVal Value As Decimal)
            _TC_DIAOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
