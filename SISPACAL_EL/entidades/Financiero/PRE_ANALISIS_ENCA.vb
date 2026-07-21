''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.PRE_ANALISIS_ENCA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row PRE_ANALISIS_ENCA en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	26/12/2017	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="PRE_ANALISIS_ENCA")> Public Class PRE_ANALISIS_ENCA
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_ENCA As Int32, aUID_REF As String, aID_ZAFRA As Int32, aFECHA As DateTime, aCODIPROVEEDOR As String, aNOMBRE_PROVEEDOR As String, aCONTRATOS As String, aZONAS As String, aCAT_TC_MZ As Decimal, aCAT_TOTAL As Decimal, aCAT_PORC As Decimal, aCOMENTARIO As String, aIMPRESO As Boolean, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aCODIAGRON As String, aCODIAGRON2 As String, aCODIAGRON3 As String)
        Me._ID_ENCA = aID_ENCA
        Me._UID_REF = aUID_REF
        Me._ID_ZAFRA = aID_ZAFRA
        Me._FECHA = aFECHA
        Me._CODIPROVEEDOR = aCODIPROVEEDOR
        Me._NOMBRE_PROVEEDOR = aNOMBRE_PROVEEDOR
        Me._CONTRATOS = aCONTRATOS
        Me._ZONAS = aZONAS
        Me._CAT_TC_MZ = aCAT_TC_MZ
        Me._CAT_TOTAL = aCAT_TOTAL
        Me._CAT_PORC = aCAT_PORC
        Me._COMENTARIO = aCOMENTARIO
        Me._IMPRESO = aIMPRESO
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._CODIAGRON = aCODIAGRON
        Me._CODIAGRON2 = aCODIAGRON2
        Me._CODIAGRON3 = aCODIAGRON3
    End Sub

#Region " Properties "

    Private _ID_ENCA As Int32
    <Column(Name:="Id enca", Storage:="ID_ENCA", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_ENCA() As Int32
        Get
            Return _ID_ENCA
        End Get
        Set(ByVal Value As Int32)
            _ID_ENCA = Value
            OnPropertyChanged("ID_ENCA")
        End Set
    End Property 

    Private _UID_REF As String
    <Column(Name:="Uid ref", Storage:="UID_REF", DbType:="VARCHAR(50)", Id:=False), _
     DataObjectField(False, False, True, 50)> _
    Public Property UID_REF() As String
        Get
            Return _UID_REF
        End Get
        Set(ByVal Value As String)
            _UID_REF = Value
            OnPropertyChanged("UID_REF")
        End Set
    End Property 

    Private _UID_REFOld As String
    Public Property UID_REFOld() As String
        Get
            Return _UID_REFOld
        End Get
        Set(ByVal Value As String)
            _UID_REFOld = Value
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

    Private _FECHA As DateTime
    <Column(Name:="Fecha", Storage:="FECHA", DbType:="DATETIME", Id:=False), _
     DataObjectField(False, False, True)> _
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

    Private _CODIPROVEEDOR As String
    <Column(Name:="Codiproveedor", Storage:="CODIPROVEEDOR", DbType:="VARCHAR(10)", Id:=False), _
     DataObjectField(False, False, True, 10)> _
    Public Property CODIPROVEEDOR() As String
        Get
            Return _CODIPROVEEDOR
        End Get
        Set(ByVal Value As String)
            _CODIPROVEEDOR = Value
            OnPropertyChanged("CODIPROVEEDOR")
        End Set
    End Property 

    Private _CODIPROVEEDOROld As String
    Public Property CODIPROVEEDOROld() As String
        Get
            Return _CODIPROVEEDOROld
        End Get
        Set(ByVal Value As String)
            _CODIPROVEEDOROld = Value
        End Set
    End Property 

    Private _NOMBRE_PROVEEDOR As String
    <Column(Name:="Nombre proveedor", Storage:="NOMBRE_PROVEEDOR", DbType:="VARCHAR(300)", Id:=False), _
     DataObjectField(False, False, True, 300)> _
    Public Property NOMBRE_PROVEEDOR() As String
        Get
            Return _NOMBRE_PROVEEDOR
        End Get
        Set(ByVal Value As String)
            _NOMBRE_PROVEEDOR = Value
            OnPropertyChanged("NOMBRE_PROVEEDOR")
        End Set
    End Property 

    Private _NOMBRE_PROVEEDOROld As String
    Public Property NOMBRE_PROVEEDOROld() As String
        Get
            Return _NOMBRE_PROVEEDOROld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_PROVEEDOROld = Value
        End Set
    End Property 

    Private _CONTRATOS As String
    <Column(Name:="Contratos", Storage:="CONTRATOS", DbType:="VARCHAR(1000)", Id:=False), _
     DataObjectField(False, False, True, 1000)> _
    Public Property CONTRATOS() As String
        Get
            Return _CONTRATOS
        End Get
        Set(ByVal Value As String)
            _CONTRATOS = Value
            OnPropertyChanged("CONTRATOS")
        End Set
    End Property 

    Private _CONTRATOSOld As String
    Public Property CONTRATOSOld() As String
        Get
            Return _CONTRATOSOld
        End Get
        Set(ByVal Value As String)
            _CONTRATOSOld = Value
        End Set
    End Property 

    Private _ZONAS As String
    <Column(Name:="Zonas", Storage:="ZONAS", DbType:="VARCHAR(1000)", Id:=False), _
     DataObjectField(False, False, True, 1000)> _
    Public Property ZONAS() As String
        Get
            Return _ZONAS
        End Get
        Set(ByVal Value As String)
            _ZONAS = Value
            OnPropertyChanged("ZONAS")
        End Set
    End Property 

    Private _ZONASOld As String
    Public Property ZONASOld() As String
        Get
            Return _ZONASOld
        End Get
        Set(ByVal Value As String)
            _ZONASOld = Value
        End Set
    End Property 

    Private _CAT_TC_MZ As Decimal
    <Column(Name:="Cat tc mz", Storage:="CAT_TC_MZ", DbType:="NUMERIC(20,4)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=4)> _
    Public Property CAT_TC_MZ() As Decimal
        Get
            Return _CAT_TC_MZ
        End Get
        Set(ByVal Value As Decimal)
            _CAT_TC_MZ = Value
            OnPropertyChanged("CAT_TC_MZ")
        End Set
    End Property 

    Private _CAT_TC_MZOld As Decimal
    Public Property CAT_TC_MZOld() As Decimal
        Get
            Return _CAT_TC_MZOld
        End Get
        Set(ByVal Value As Decimal)
            _CAT_TC_MZOld = Value
        End Set
    End Property 

    Private _CAT_TOTAL As Decimal
    <Column(Name:="Cat total", Storage:="CAT_TOTAL", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property CAT_TOTAL() As Decimal
        Get
            Return _CAT_TOTAL
        End Get
        Set(ByVal Value As Decimal)
            _CAT_TOTAL = Value
            OnPropertyChanged("CAT_TOTAL")
        End Set
    End Property 

    Private _CAT_TOTALOld As Decimal
    Public Property CAT_TOTALOld() As Decimal
        Get
            Return _CAT_TOTALOld
        End Get
        Set(ByVal Value As Decimal)
            _CAT_TOTALOld = Value
        End Set
    End Property 

    Private _CAT_PORC As Decimal
    <Column(Name:="Cat porc", Storage:="CAT_PORC", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property CAT_PORC() As Decimal
        Get
            Return _CAT_PORC
        End Get
        Set(ByVal Value As Decimal)
            _CAT_PORC = Value
            OnPropertyChanged("CAT_PORC")
        End Set
    End Property 

    Private _CAT_PORCOld As Decimal
    Public Property CAT_PORCOld() As Decimal
        Get
            Return _CAT_PORCOld
        End Get
        Set(ByVal Value As Decimal)
            _CAT_PORCOld = Value
        End Set
    End Property 

    Private _COMENTARIO As String
    <Column(Name:="Comentario", Storage:="COMENTARIO", DbType:="VARCHAR(2000)", Id:=False), _
     DataObjectField(False, False, True, 2000)> _
    Public Property COMENTARIO() As String
        Get
            Return _COMENTARIO
        End Get
        Set(ByVal Value As String)
            _COMENTARIO = Value
            OnPropertyChanged("COMENTARIO")
        End Set
    End Property 

    Private _COMENTARIOOld As String
    Public Property COMENTARIOOld() As String
        Get
            Return _COMENTARIOOld
        End Get
        Set(ByVal Value As String)
            _COMENTARIOOld = Value
        End Set
    End Property 

    Private _IMPRESO As Boolean
    <Column(Name:="Impreso", Storage:="IMPRESO", DbType:="BIT", Id:=False), _
     DataObjectField(False, False, True, 1)> _
    Public Property IMPRESO() As Boolean
        Get
            Return _IMPRESO
        End Get
        Set(ByVal Value As Boolean)
            _IMPRESO = Value
            OnPropertyChanged("IMPRESO")
        End Set
    End Property 

    Private _IMPRESOOld As Boolean
    Public Property IMPRESOOld() As Boolean
        Get
            Return _IMPRESOOld
        End Get
        Set(ByVal Value As Boolean)
            _IMPRESOOld = Value
        End Set
    End Property 

    Private _USUARIO_CREA As String
    <Column(Name:="Usuario crea", Storage:="USUARIO_CREA", DbType:="VARCHAR(200)", Id:=False), _
     DataObjectField(False, False, True, 200)> _
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

    Private _CODIAGRON As String
    <Column(Name:="Codiagron", Storage:="CODIAGRON", DbType:="VARCHAR(8)", Id:=False), _
     DataObjectField(False, False, True, 8)> _
    Public Property CODIAGRON() As String
        Get
            Return _CODIAGRON
        End Get
        Set(ByVal Value As String)
            _CODIAGRON = Value
            OnPropertyChanged("CODIAGRON")
        End Set
    End Property 

    Private _CODIAGRONOld As String
    Public Property CODIAGRONOld() As String
        Get
            Return _CODIAGRONOld
        End Get
        Set(ByVal Value As String)
            _CODIAGRONOld = Value
        End Set
    End Property 

    Private _CODIAGRON2 As String
    <Column(Name:="Codiagron2", Storage:="CODIAGRON2", DbType:="VARCHAR(8)", Id:=False), _
     DataObjectField(False, False, True, 8)> _
    Public Property CODIAGRON2() As String
        Get
            Return _CODIAGRON2
        End Get
        Set(ByVal Value As String)
            _CODIAGRON2 = Value
            OnPropertyChanged("CODIAGRON2")
        End Set
    End Property 

    Private _CODIAGRON2Old As String
    Public Property CODIAGRON2Old() As String
        Get
            Return _CODIAGRON2Old
        End Get
        Set(ByVal Value As String)
            _CODIAGRON2Old = Value
        End Set
    End Property 

    Private _CODIAGRON3 As String
    <Column(Name:="Codiagron3", Storage:="CODIAGRON3", DbType:="VARCHAR(8)", Id:=False), _
     DataObjectField(False, False, True, 8)> _
    Public Property CODIAGRON3() As String
        Get
            Return _CODIAGRON3
        End Get
        Set(ByVal Value As String)
            _CODIAGRON3 = Value
            OnPropertyChanged("CODIAGRON3")
        End Set
    End Property 

    Private _CODIAGRON3Old As String
    Public Property CODIAGRON3Old() As String
        Get
            Return _CODIAGRON3Old
        End Get
        Set(ByVal Value As String)
            _CODIAGRON3Old = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
