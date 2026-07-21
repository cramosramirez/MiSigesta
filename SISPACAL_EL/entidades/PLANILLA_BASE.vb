''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.PLANILLA_BASE
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row PLANILLA_BASE en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	18/10/2017	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="PLANILLA_BASE")> Public Class PLANILLA_BASE
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_PLANILLA_BASE As Int32, aID_ZAFRA As Int32, aID_CATORCENA As Int32, aID_TIPO_PLANILLA As Int32, aFECHA_INICIO As DateTime, aFECHA_FIN As DateTime, aFECHA_PAGO As DateTime, aNO_ANTICIPO As Int32, aNO_ANTICIPO_LETRAS As String, aVALOR_UNIT_PAGO As Decimal, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime, aCONCEPTO As String)
        Me._ID_PLANILLA_BASE = aID_PLANILLA_BASE
        Me._ID_ZAFRA = aID_ZAFRA
        Me._ID_CATORCENA = aID_CATORCENA
        Me._ID_TIPO_PLANILLA = aID_TIPO_PLANILLA
        Me._FECHA_INICIO = aFECHA_INICIO
        Me._FECHA_FIN = aFECHA_FIN
        Me._FECHA_PAGO = aFECHA_PAGO
        Me._NO_ANTICIPO = aNO_ANTICIPO
        Me._NO_ANTICIPO_LETRAS = aNO_ANTICIPO_LETRAS
        Me._VALOR_UNIT_PAGO = aVALOR_UNIT_PAGO
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
        Me._CONCEPTO = aCONCEPTO
    End Sub

#Region " Properties "

    Private _ID_PLANILLA_BASE As Int32
    <Column(Name:="Id planilla base", Storage:="ID_PLANILLA_BASE", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_PLANILLA_BASE() As Int32
        Get
            Return _ID_PLANILLA_BASE
        End Get
        Set(ByVal Value As Int32)
            _ID_PLANILLA_BASE = Value
            OnPropertyChanged("ID_PLANILLA_BASE")
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

    Private _ID_TIPO_PLANILLA As Int32
    <Column(Name:="Id tipo planilla", Storage:="ID_TIPO_PLANILLA", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_TIPO_PLANILLA() As Int32
        Get
            Return _ID_TIPO_PLANILLA
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_PLANILLA = Value
            OnPropertyChanged("ID_TIPO_PLANILLA")
        End Set
    End Property 

    Private _ID_TIPO_PLANILLAOld As Int32
    Public Property ID_TIPO_PLANILLAOld() As Int32
        Get
            Return _ID_TIPO_PLANILLAOld
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_PLANILLAOld = Value
        End Set
    End Property 

    Private _fkID_TIPO_PLANILLA As TIPO_PLANILLA
    Public Property fkID_TIPO_PLANILLA() As TIPO_PLANILLA
        Get
            Return _fkID_TIPO_PLANILLA
        End Get
        Set(ByVal Value As TIPO_PLANILLA)
            _fkID_TIPO_PLANILLA = Value
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

    Private _FECHA_FIN As DateTime
    <Column(Name:="Fecha fin", Storage:="FECHA_FIN", DbType:="DATETIME NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
    Public Property FECHA_FIN() As DateTime
        Get
            Return _FECHA_FIN
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_FIN = Value
            OnPropertyChanged("FECHA_FIN")
        End Set
    End Property 

    Private _FECHA_FINOld As DateTime
    Public Property FECHA_FINOld() As DateTime
        Get
            Return _FECHA_FINOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_FINOld = Value
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

    Private _NO_ANTICIPO As Int32
    <Column(Name:="No anticipo", Storage:="NO_ANTICIPO", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
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
    <Column(Name:="No anticipo letras", Storage:="NO_ANTICIPO_LETRAS", DbType:="VARCHAR(255)", Id:=False), _
     DataObjectField(False, False, True, 255)> _
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

    Private _VALOR_UNIT_PAGO As Decimal
    <Column(Name:="Valor unit pago", Storage:="VALOR_UNIT_PAGO", DbType:="NUMERIC(22,20)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=22, Scale:=20)> _
    Public Property VALOR_UNIT_PAGO() As Decimal
        Get
            Return _VALOR_UNIT_PAGO
        End Get
        Set(ByVal Value As Decimal)
            _VALOR_UNIT_PAGO = Value
            OnPropertyChanged("VALOR_UNIT_PAGO")
        End Set
    End Property 

    Private _VALOR_UNIT_PAGOOld As Decimal
    Public Property VALOR_UNIT_PAGOOld() As Decimal
        Get
            Return _VALOR_UNIT_PAGOOld
        End Get
        Set(ByVal Value As Decimal)
            _VALOR_UNIT_PAGOOld = Value
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

    Private _CONCEPTO As String
    <Column(Name:="Concepto", Storage:="CONCEPTO", DbType:="VARCHAR(255)", Id:=False), _
     DataObjectField(False, False, True, 255)> _
    Public Property CONCEPTO() As String
        Get
            Return _CONCEPTO
        End Get
        Set(ByVal Value As String)
            _CONCEPTO = Value
            OnPropertyChanged("CONCEPTO")
        End Set
    End Property 

    Private _CONCEPTOOld As String
    Public Property CONCEPTOOld() As String
        Get
            Return _CONCEPTOOld
        End Get
        Set(ByVal Value As String)
            _CONCEPTOOld = Value
        End Set
    End Property

    Private _FECHA_COMPROB As DateTime
    <Column(Name:="Fecha comprobantes", Storage:="FECHA_COMPROB", DBType:="DATETIME", Id:=False),
     DataObjectField(False, False, True)>
    Public Property FECHA_COMPROB() As DateTime
        Get
            Return _FECHA_COMPROB
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_COMPROB = Value
            OnPropertyChanged("FECHA_COMPROB")
        End Set
    End Property

    Private _FECHA_COMPROBOld As DateTime
    Public Property FECHA_COMPROBOld() As DateTime
        Get
            Return _FECHA_COMPROBOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_COMPROBOld = Value
        End Set
    End Property


    Private _CTACONTA_PLANI_CANA As String
    <Column(Name:="CTACONTA_PLANI_CANA", Storage:="CTACONTA_PLANI_CANA", DBType:="VARCHAR(30)", Id:=False),
     DataObjectField(False, False, True, 30)>
    Public Property CTACONTA_PLANI_CANA() As String
        Get
            Return _CTACONTA_PLANI_CANA
        End Get
        Set(ByVal Value As String)
            _CTACONTA_PLANI_CANA = Value
            OnPropertyChanged("CTACONTA_PLANI_CANA")
        End Set
    End Property

    Private _CTACONTA_PLANI_CANAOld As String
    Public Property CTACONTA_PLANI_CANAOld() As String
        Get
            Return _CTACONTA_PLANI_CANAOld
        End Get
        Set(ByVal Value As String)
            _CTACONTA_PLANI_CANAOld = Value
        End Set
    End Property

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
