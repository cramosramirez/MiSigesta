''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.PRE_ANALISIS_ENCA_TRANS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row PRE_ANALISIS_ENCA_TRANS en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	06/11/2017	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="PRE_ANALISIS_ENCA_TRANS")> Public Class PRE_ANALISIS_ENCA_TRANS
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_ENCA As Int32, aUID_REF As String, aID_ZAFRA As Int32, aFECHA As DateTime, aCODTRANSPORT As Int32, aNOMBRE_TRANSPORTISTA As String, aUNIDADES As Int32, aNO_VIAJES As Decimal, aTC_PROM_VIAJE As Decimal, aTC_TOTALES As Decimal, aTC_FLETE As Decimal, aVALOR_TOTAL As Decimal, aCOMENTARIO As String, aIMPRESO As Boolean, aUSUARIO_CREA As String, aFECHA_CREA As DateTime)
        Me._ID_ENCA = aID_ENCA
        Me._UID_REF = aUID_REF
        Me._ID_ZAFRA = aID_ZAFRA
        Me._FECHA = aFECHA
        Me._CODTRANSPORT = aCODTRANSPORT
        Me._NOMBRE_TRANSPORTISTA = aNOMBRE_TRANSPORTISTA
        Me._UNIDADES = aUNIDADES
        Me._NO_VIAJES = aNO_VIAJES
        Me._TC_PROM_VIAJE = aTC_PROM_VIAJE
        Me._TC_TOTALES = aTC_TOTALES
        Me._TC_FLETE = aTC_FLETE
        Me._VALOR_TOTAL = aVALOR_TOTAL
        Me._COMENTARIO = aCOMENTARIO
        Me._IMPRESO = aIMPRESO
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
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

    Private _CODTRANSPORT As Int32
    <Column(Name:="Codtransport", Storage:="CODTRANSPORT", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property CODTRANSPORT() As Int32
        Get
            Return _CODTRANSPORT
        End Get
        Set(ByVal Value As Int32)
            _CODTRANSPORT = Value
            OnPropertyChanged("CODTRANSPORT")
        End Set
    End Property 

    Private _CODTRANSPORTOld As Int32
    Public Property CODTRANSPORTOld() As Int32
        Get
            Return _CODTRANSPORTOld
        End Get
        Set(ByVal Value As Int32)
            _CODTRANSPORTOld = Value
        End Set
    End Property 

    Private _NOMBRE_TRANSPORTISTA As String
    <Column(Name:="Nombre transportista", Storage:="NOMBRE_TRANSPORTISTA", DbType:="VARCHAR(300)", Id:=False), _
     DataObjectField(False, False, True, 300)> _
    Public Property NOMBRE_TRANSPORTISTA() As String
        Get
            Return _NOMBRE_TRANSPORTISTA
        End Get
        Set(ByVal Value As String)
            _NOMBRE_TRANSPORTISTA = Value
            OnPropertyChanged("NOMBRE_TRANSPORTISTA")
        End Set
    End Property 

    Private _NOMBRE_TRANSPORTISTAOld As String
    Public Property NOMBRE_TRANSPORTISTAOld() As String
        Get
            Return _NOMBRE_TRANSPORTISTAOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_TRANSPORTISTAOld = Value
        End Set
    End Property 

    Private _UNIDADES As Int32
    <Column(Name:="Unidades", Storage:="UNIDADES", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property UNIDADES() As Int32
        Get
            Return _UNIDADES
        End Get
        Set(ByVal Value As Int32)
            _UNIDADES = Value
            OnPropertyChanged("UNIDADES")
        End Set
    End Property 

    Private _UNIDADESOld As Int32
    Public Property UNIDADESOld() As Int32
        Get
            Return _UNIDADESOld
        End Get
        Set(ByVal Value As Int32)
            _UNIDADESOld = Value
        End Set
    End Property 

    Private _NO_VIAJES As Decimal
    <Column(Name:="No viajes", Storage:="NO_VIAJES", DbType:="NUMERIC(10,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=2)> _
    Public Property NO_VIAJES() As Decimal
        Get
            Return _NO_VIAJES
        End Get
        Set(ByVal Value As Decimal)
            _NO_VIAJES = Value
            OnPropertyChanged("NO_VIAJES")
        End Set
    End Property 

    Private _NO_VIAJESOld As Decimal
    Public Property NO_VIAJESOld() As Decimal
        Get
            Return _NO_VIAJESOld
        End Get
        Set(ByVal Value As Decimal)
            _NO_VIAJESOld = Value
        End Set
    End Property 

    Private _TC_PROM_VIAJE As Decimal
    <Column(Name:="Tc prom viaje", Storage:="TC_PROM_VIAJE", DbType:="NUMERIC(10,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=2)> _
    Public Property TC_PROM_VIAJE() As Decimal
        Get
            Return _TC_PROM_VIAJE
        End Get
        Set(ByVal Value As Decimal)
            _TC_PROM_VIAJE = Value
            OnPropertyChanged("TC_PROM_VIAJE")
        End Set
    End Property 

    Private _TC_PROM_VIAJEOld As Decimal
    Public Property TC_PROM_VIAJEOld() As Decimal
        Get
            Return _TC_PROM_VIAJEOld
        End Get
        Set(ByVal Value As Decimal)
            _TC_PROM_VIAJEOld = Value
        End Set
    End Property 

    Private _TC_TOTALES As Decimal
    <Column(Name:="Tc totales", Storage:="TC_TOTALES", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property TC_TOTALES() As Decimal
        Get
            Return _TC_TOTALES
        End Get
        Set(ByVal Value As Decimal)
            _TC_TOTALES = Value
            OnPropertyChanged("TC_TOTALES")
        End Set
    End Property 

    Private _TC_TOTALESOld As Decimal
    Public Property TC_TOTALESOld() As Decimal
        Get
            Return _TC_TOTALESOld
        End Get
        Set(ByVal Value As Decimal)
            _TC_TOTALESOld = Value
        End Set
    End Property 

    Private _TC_FLETE As Decimal
    <Column(Name:="Tc flete", Storage:="TC_FLETE", DbType:="NUMERIC(10,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=2)> _
    Public Property TC_FLETE() As Decimal
        Get
            Return _TC_FLETE
        End Get
        Set(ByVal Value As Decimal)
            _TC_FLETE = Value
            OnPropertyChanged("TC_FLETE")
        End Set
    End Property 

    Private _TC_FLETEOld As Decimal
    Public Property TC_FLETEOld() As Decimal
        Get
            Return _TC_FLETEOld
        End Get
        Set(ByVal Value As Decimal)
            _TC_FLETEOld = Value
        End Set
    End Property 

    Private _VALOR_TOTAL As Decimal
    <Column(Name:="Valor total", Storage:="VALOR_TOTAL", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property VALOR_TOTAL() As Decimal
        Get
            Return _VALOR_TOTAL
        End Get
        Set(ByVal Value As Decimal)
            _VALOR_TOTAL = Value
            OnPropertyChanged("VALOR_TOTAL")
        End Set
    End Property 

    Private _VALOR_TOTALOld As Decimal
    Public Property VALOR_TOTALOld() As Decimal
        Get
            Return _VALOR_TOTALOld
        End Get
        Set(ByVal Value As Decimal)
            _VALOR_TOTALOld = Value
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

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
