''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.CONTROL_ENTREGA_LOTE
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row CONTROL_ENTREGA_LOTE en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	29/11/2014	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="CONTROL_ENTREGA_LOTE")> Public Class CONTROL_ENTREGA_LOTE
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_CTRL_ENTREGA_LOTE As Int32, aID_ZAFRA As Int32, aACCESLOTE As String, aDIAZAFRA As Int32, aCONCEPTO As String, aCODIGO_REF As String, aID_REF As Int32, aINICIAL As Decimal, aSALIDAS As Decimal, aSALDO As Decimal, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime)
        Me._ID_CTRL_ENTREGA_LOTE = aID_CTRL_ENTREGA_LOTE
        Me._ID_ZAFRA = aID_ZAFRA
        Me._ACCESLOTE = aACCESLOTE
        Me._DIAZAFRA = aDIAZAFRA
        Me._CONCEPTO = aCONCEPTO
        Me._CODIGO_REF = aCODIGO_REF
        Me._ID_REF = aID_REF
        Me._INICIAL = aINICIAL
        Me._SALIDAS = aSALIDAS
        Me._SALDO = aSALDO
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
    End Sub

#Region " Properties "

    Private _ID_CTRL_ENTREGA_LOTE As Int32
    <Column(Name:="Id ctrl entrega lote", Storage:="ID_CTRL_ENTREGA_LOTE", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_CTRL_ENTREGA_LOTE() As Int32
        Get
            Return _ID_CTRL_ENTREGA_LOTE
        End Get
        Set(ByVal Value As Int32)
            _ID_CTRL_ENTREGA_LOTE = Value
            OnPropertyChanged("ID_CTRL_ENTREGA_LOTE")
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

    Private _DIAZAFRA As Int32
    <Column(Name:="Diazafra", Storage:="DIAZAFRA", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property DIAZAFRA() As Int32
        Get
            Return _DIAZAFRA
        End Get
        Set(ByVal Value As Int32)
            _DIAZAFRA = Value
            OnPropertyChanged("DIAZAFRA")
        End Set
    End Property 

    Private _DIAZAFRAOld As Int32
    Public Property DIAZAFRAOld() As Int32
        Get
            Return _DIAZAFRAOld
        End Get
        Set(ByVal Value As Int32)
            _DIAZAFRAOld = Value
        End Set
    End Property 

    Private _CONCEPTO As String
    <Column(Name:="Concepto", Storage:="CONCEPTO", DbType:="VARCHAR(200) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 200)> _
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

    Private _CODIGO_REF As String
    <Column(Name:="Codigo ref", Storage:="CODIGO_REF", DbType:="CHAR(10) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 10)> _
    Public Property CODIGO_REF() As String
        Get
            Return _CODIGO_REF
        End Get
        Set(ByVal Value As String)
            _CODIGO_REF = Value
            OnPropertyChanged("CODIGO_REF")
        End Set
    End Property 

    Private _CODIGO_REFOld As String
    Public Property CODIGO_REFOld() As String
        Get
            Return _CODIGO_REFOld
        End Get
        Set(ByVal Value As String)
            _CODIGO_REFOld = Value
        End Set
    End Property 

    Private _ID_REF As Int32
    <Column(Name:="Id ref", Storage:="ID_REF", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_REF() As Int32
        Get
            Return _ID_REF
        End Get
        Set(ByVal Value As Int32)
            _ID_REF = Value
            OnPropertyChanged("ID_REF")
        End Set
    End Property 

    Private _ID_REFOld As Int32
    Public Property ID_REFOld() As Int32
        Get
            Return _ID_REFOld
        End Get
        Set(ByVal Value As Int32)
            _ID_REFOld = Value
        End Set
    End Property 

    Private _INICIAL As Decimal
    <Column(Name:="Inicial", Storage:="INICIAL", DbType:="NUMERIC(10,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)> _
    Public Property INICIAL() As Decimal
        Get
            Return _INICIAL
        End Get
        Set(ByVal Value As Decimal)
            _INICIAL = Value
            OnPropertyChanged("INICIAL")
        End Set
    End Property 

    Private _INICIALOld As Decimal
    Public Property INICIALOld() As Decimal
        Get
            Return _INICIALOld
        End Get
        Set(ByVal Value As Decimal)
            _INICIALOld = Value
        End Set
    End Property 

    Private _SALIDAS As Decimal
    <Column(Name:="Salidas", Storage:="SALIDAS", DbType:="NUMERIC(10,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)> _
    Public Property SALIDAS() As Decimal
        Get
            Return _SALIDAS
        End Get
        Set(ByVal Value As Decimal)
            _SALIDAS = Value
            OnPropertyChanged("SALIDAS")
        End Set
    End Property 

    Private _SALIDASOld As Decimal
    Public Property SALIDASOld() As Decimal
        Get
            Return _SALIDASOld
        End Get
        Set(ByVal Value As Decimal)
            _SALIDASOld = Value
        End Set
    End Property 

    Private _SALDO As Decimal
    <Column(Name:="Saldo", Storage:="SALDO", DbType:="NUMERIC(10,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)> _
    Public Property SALDO() As Decimal
        Get
            Return _SALDO
        End Get
        Set(ByVal Value As Decimal)
            _SALDO = Value
            OnPropertyChanged("SALDO")
        End Set
    End Property 

    Private _SALDOOld As Decimal
    Public Property SALDOOld() As Decimal
        Get
            Return _SALDOOld
        End Get
        Set(ByVal Value As Decimal)
            _SALDOOld = Value
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
