''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.ZAFRA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row ZAFRA en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	30/11/2018	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="ZAFRA")> Public Class ZAFRA
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_ZAFRA As Int32, aNOMBRE_ZAFRA As String, aDIAZAFRA As Int32, aCATORCENA As Int32, aFECHA_INICIO As DateTime, aFECHA_FINAL As DateTime, aPOL As Decimal, aHUMEDAD As Decimal, aPUREZA_MIEL As Decimal, aEFICIENCIA As Decimal, aPRECIO_LIBRA_AZUCAR As Decimal, aCONSTANTE_A As Decimal, aCONSTANTE_B As Decimal, aCONSTANTE_D As Decimal, aCONSTANTE_E As Decimal, aULTFECHA_CIERRE_DIARIO As DateTime, aACTIVA As Boolean, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime, aDISPO_INVE_ROZA As Decimal, aREND_MODFINAN As Decimal, aTARIFA_ROZA_MODFINAN As Decimal, aTARIFA_ALZA_MODFINAN As Decimal, aTARIFA_QUERQUEO As Decimal, aPUREZA_AZUCAR As Decimal)
        Me._ID_ZAFRA = aID_ZAFRA
        Me._NOMBRE_ZAFRA = aNOMBRE_ZAFRA
        Me._DIAZAFRA = aDIAZAFRA
        Me._CATORCENA = aCATORCENA
        Me._FECHA_INICIO = aFECHA_INICIO
        Me._FECHA_FINAL = aFECHA_FINAL
        Me._POL = aPOL
        Me._HUMEDAD = aHUMEDAD
        Me._PUREZA_MIEL = aPUREZA_MIEL
        Me._EFICIENCIA = aEFICIENCIA
        Me._PRECIO_LIBRA_AZUCAR = aPRECIO_LIBRA_AZUCAR
        Me._CONSTANTE_A = aCONSTANTE_A
        Me._CONSTANTE_B = aCONSTANTE_B
        Me._CONSTANTE_D = aCONSTANTE_D
        Me._CONSTANTE_E = aCONSTANTE_E
        Me._ULTFECHA_CIERRE_DIARIO = aULTFECHA_CIERRE_DIARIO
        Me._ACTIVA = aACTIVA
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
        Me._DISPO_INVE_ROZA = aDISPO_INVE_ROZA
        Me._REND_MODFINAN = aREND_MODFINAN
        Me._TARIFA_ROZA_MODFINAN = aTARIFA_ROZA_MODFINAN
        Me._TARIFA_ALZA_MODFINAN = aTARIFA_ALZA_MODFINAN
        Me._TARIFA_QUERQUEO = aTARIFA_QUERQUEO
        Me._PUREZA_AZUCAR = aPUREZA_AZUCAR
    End Sub

#Region " Properties "

    Private _ID_ZAFRA As Int32
    <Column(Name:="Id zafra", Storage:="ID_ZAFRA", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_ZAFRA() As Int32
        Get
            Return _ID_ZAFRA
        End Get
        Set(ByVal Value As Int32)
            _ID_ZAFRA = Value
            OnPropertyChanged("ID_ZAFRA")
        End Set
    End Property 

    Private _NOMBRE_ZAFRA As String
    <Column(Name:="Nombre zafra", Storage:="NOMBRE_ZAFRA", DbType:="VARCHAR(200) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 200)> _
    Public Property NOMBRE_ZAFRA() As String
        Get
            Return _NOMBRE_ZAFRA
        End Get
        Set(ByVal Value As String)
            _NOMBRE_ZAFRA = Value
            OnPropertyChanged("NOMBRE_ZAFRA")
        End Set
    End Property 

    Private _NOMBRE_ZAFRAOld As String
    Public Property NOMBRE_ZAFRAOld() As String
        Get
            Return _NOMBRE_ZAFRAOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_ZAFRAOld = Value
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

    Private _CATORCENA As Int32
    <Column(Name:="Catorcena", Storage:="CATORCENA", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
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

    Private _POL As Decimal
    <Column(Name:="Pol", Storage:="POL", DbType:="NUMERIC(20,6) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=6)> _
    Public Property POL() As Decimal
        Get
            Return _POL
        End Get
        Set(ByVal Value As Decimal)
            _POL = Value
            OnPropertyChanged("POL")
        End Set
    End Property 

    Private _POLOld As Decimal
    Public Property POLOld() As Decimal
        Get
            Return _POLOld
        End Get
        Set(ByVal Value As Decimal)
            _POLOld = Value
        End Set
    End Property 

    Private _HUMEDAD As Decimal
    <Column(Name:="Humedad", Storage:="HUMEDAD", DbType:="NUMERIC(20,6) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=6)> _
    Public Property HUMEDAD() As Decimal
        Get
            Return _HUMEDAD
        End Get
        Set(ByVal Value As Decimal)
            _HUMEDAD = Value
            OnPropertyChanged("HUMEDAD")
        End Set
    End Property 

    Private _HUMEDADOld As Decimal
    Public Property HUMEDADOld() As Decimal
        Get
            Return _HUMEDADOld
        End Get
        Set(ByVal Value As Decimal)
            _HUMEDADOld = Value
        End Set
    End Property 

    Private _PUREZA_MIEL As Decimal
    <Column(Name:="Pureza miel", Storage:="PUREZA_MIEL", DbType:="NUMERIC(20,6) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=6)> _
    Public Property PUREZA_MIEL() As Decimal
        Get
            Return _PUREZA_MIEL
        End Get
        Set(ByVal Value As Decimal)
            _PUREZA_MIEL = Value
            OnPropertyChanged("PUREZA_MIEL")
        End Set
    End Property 

    Private _PUREZA_MIELOld As Decimal
    Public Property PUREZA_MIELOld() As Decimal
        Get
            Return _PUREZA_MIELOld
        End Get
        Set(ByVal Value As Decimal)
            _PUREZA_MIELOld = Value
        End Set
    End Property 

    Private _EFICIENCIA As Decimal
    <Column(Name:="Eficiencia", Storage:="EFICIENCIA", DbType:="NUMERIC(20,6) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=6)> _
    Public Property EFICIENCIA() As Decimal
        Get
            Return _EFICIENCIA
        End Get
        Set(ByVal Value As Decimal)
            _EFICIENCIA = Value
            OnPropertyChanged("EFICIENCIA")
        End Set
    End Property 

    Private _EFICIENCIAOld As Decimal
    Public Property EFICIENCIAOld() As Decimal
        Get
            Return _EFICIENCIAOld
        End Get
        Set(ByVal Value As Decimal)
            _EFICIENCIAOld = Value
        End Set
    End Property 

    Private _PRECIO_LIBRA_AZUCAR As Decimal
    <Column(Name:="Precio libra azucar", Storage:="PRECIO_LIBRA_AZUCAR", DbType:="NUMERIC(20,6) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=6)> _
    Public Property PRECIO_LIBRA_AZUCAR() As Decimal
        Get
            Return _PRECIO_LIBRA_AZUCAR
        End Get
        Set(ByVal Value As Decimal)
            _PRECIO_LIBRA_AZUCAR = Value
            OnPropertyChanged("PRECIO_LIBRA_AZUCAR")
        End Set
    End Property 

    Private _PRECIO_LIBRA_AZUCAROld As Decimal
    Public Property PRECIO_LIBRA_AZUCAROld() As Decimal
        Get
            Return _PRECIO_LIBRA_AZUCAROld
        End Get
        Set(ByVal Value As Decimal)
            _PRECIO_LIBRA_AZUCAROld = Value
        End Set
    End Property 

    Private _CONSTANTE_A As Decimal
    <Column(Name:="Constante a", Storage:="CONSTANTE_A", DbType:="NUMERIC(9,6) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=9, Scale:=6)> _
    Public Property CONSTANTE_A() As Decimal
        Get
            Return _CONSTANTE_A
        End Get
        Set(ByVal Value As Decimal)
            _CONSTANTE_A = Value
            OnPropertyChanged("CONSTANTE_A")
        End Set
    End Property 

    Private _CONSTANTE_AOld As Decimal
    Public Property CONSTANTE_AOld() As Decimal
        Get
            Return _CONSTANTE_AOld
        End Get
        Set(ByVal Value As Decimal)
            _CONSTANTE_AOld = Value
        End Set
    End Property 

    Private _CONSTANTE_B As Decimal
    <Column(Name:="Constante b", Storage:="CONSTANTE_B", DbType:="NUMERIC(9,6) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=9, Scale:=6)> _
    Public Property CONSTANTE_B() As Decimal
        Get
            Return _CONSTANTE_B
        End Get
        Set(ByVal Value As Decimal)
            _CONSTANTE_B = Value
            OnPropertyChanged("CONSTANTE_B")
        End Set
    End Property 

    Private _CONSTANTE_BOld As Decimal
    Public Property CONSTANTE_BOld() As Decimal
        Get
            Return _CONSTANTE_BOld
        End Get
        Set(ByVal Value As Decimal)
            _CONSTANTE_BOld = Value
        End Set
    End Property 

    Private _CONSTANTE_D As Decimal
    <Column(Name:="Constante d", Storage:="CONSTANTE_D", DbType:="NUMERIC(9,6) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=9, Scale:=6)> _
    Public Property CONSTANTE_D() As Decimal
        Get
            Return _CONSTANTE_D
        End Get
        Set(ByVal Value As Decimal)
            _CONSTANTE_D = Value
            OnPropertyChanged("CONSTANTE_D")
        End Set
    End Property 

    Private _CONSTANTE_DOld As Decimal
    Public Property CONSTANTE_DOld() As Decimal
        Get
            Return _CONSTANTE_DOld
        End Get
        Set(ByVal Value As Decimal)
            _CONSTANTE_DOld = Value
        End Set
    End Property 

    Private _CONSTANTE_E As Decimal
    <Column(Name:="Constante e", Storage:="CONSTANTE_E", DbType:="NUMERIC(9,6) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=9, Scale:=6)> _
    Public Property CONSTANTE_E() As Decimal
        Get
            Return _CONSTANTE_E
        End Get
        Set(ByVal Value As Decimal)
            _CONSTANTE_E = Value
            OnPropertyChanged("CONSTANTE_E")
        End Set
    End Property 

    Private _CONSTANTE_EOld As Decimal
    Public Property CONSTANTE_EOld() As Decimal
        Get
            Return _CONSTANTE_EOld
        End Get
        Set(ByVal Value As Decimal)
            _CONSTANTE_EOld = Value
        End Set
    End Property 

    Private _ULTFECHA_CIERRE_DIARIO As DateTime
    <Column(Name:="Ultfecha cierre diario", Storage:="ULTFECHA_CIERRE_DIARIO", DbType:="DATE", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property ULTFECHA_CIERRE_DIARIO() As DateTime
        Get
            Return _ULTFECHA_CIERRE_DIARIO
        End Get
        Set(ByVal Value As DateTime)
            _ULTFECHA_CIERRE_DIARIO = Value
            OnPropertyChanged("ULTFECHA_CIERRE_DIARIO")
        End Set
    End Property 

    Private _ULTFECHA_CIERRE_DIARIOOld As DateTime
    Public Property ULTFECHA_CIERRE_DIARIOOld() As DateTime
        Get
            Return _ULTFECHA_CIERRE_DIARIOOld
        End Get
        Set(ByVal Value As DateTime)
            _ULTFECHA_CIERRE_DIARIOOld = Value
        End Set
    End Property 

    Private _ACTIVA As Boolean
    <Column(Name:="Activa", Storage:="ACTIVA", DbType:="BIT NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 1)> _
    Public Property ACTIVA() As Boolean
        Get
            Return _ACTIVA
        End Get
        Set(ByVal Value As Boolean)
            _ACTIVA = Value
            OnPropertyChanged("ACTIVA")
        End Set
    End Property 

    Private _ACTIVAOld As Boolean
    Public Property ACTIVAOld() As Boolean
        Get
            Return _ACTIVAOld
        End Get
        Set(ByVal Value As Boolean)
            _ACTIVAOld = Value
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

    Private _DISPO_INVE_ROZA As Decimal
    <Column(Name:="Dispo inve roza", Storage:="DISPO_INVE_ROZA", DbType:="NUMERIC(5,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=5, Scale:=2)> _
    Public Property DISPO_INVE_ROZA() As Decimal
        Get
            Return _DISPO_INVE_ROZA
        End Get
        Set(ByVal Value As Decimal)
            _DISPO_INVE_ROZA = Value
            OnPropertyChanged("DISPO_INVE_ROZA")
        End Set
    End Property 

    Private _DISPO_INVE_ROZAOld As Decimal
    Public Property DISPO_INVE_ROZAOld() As Decimal
        Get
            Return _DISPO_INVE_ROZAOld
        End Get
        Set(ByVal Value As Decimal)
            _DISPO_INVE_ROZAOld = Value
        End Set
    End Property 

    Private _REND_MODFINAN As Decimal
    <Column(Name:="Rend modfinan", Storage:="REND_MODFINAN", DbType:="NUMERIC(20,6)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=6)> _
    Public Property REND_MODFINAN() As Decimal
        Get
            Return _REND_MODFINAN
        End Get
        Set(ByVal Value As Decimal)
            _REND_MODFINAN = Value
            OnPropertyChanged("REND_MODFINAN")
        End Set
    End Property 

    Private _REND_MODFINANOld As Decimal
    Public Property REND_MODFINANOld() As Decimal
        Get
            Return _REND_MODFINANOld
        End Get
        Set(ByVal Value As Decimal)
            _REND_MODFINANOld = Value
        End Set
    End Property 

    Private _TARIFA_ROZA_MODFINAN As Decimal
    <Column(Name:="Tarifa roza modfinan", Storage:="TARIFA_ROZA_MODFINAN", DbType:="NUMERIC(20,6)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=6)> _
    Public Property TARIFA_ROZA_MODFINAN() As Decimal
        Get
            Return _TARIFA_ROZA_MODFINAN
        End Get
        Set(ByVal Value As Decimal)
            _TARIFA_ROZA_MODFINAN = Value
            OnPropertyChanged("TARIFA_ROZA_MODFINAN")
        End Set
    End Property 

    Private _TARIFA_ROZA_MODFINANOld As Decimal
    Public Property TARIFA_ROZA_MODFINANOld() As Decimal
        Get
            Return _TARIFA_ROZA_MODFINANOld
        End Get
        Set(ByVal Value As Decimal)
            _TARIFA_ROZA_MODFINANOld = Value
        End Set
    End Property 

    Private _TARIFA_ALZA_MODFINAN As Decimal
    <Column(Name:="Tarifa alza modfinan", Storage:="TARIFA_ALZA_MODFINAN", DbType:="NUMERIC(20,6)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=6)> _
    Public Property TARIFA_ALZA_MODFINAN() As Decimal
        Get
            Return _TARIFA_ALZA_MODFINAN
        End Get
        Set(ByVal Value As Decimal)
            _TARIFA_ALZA_MODFINAN = Value
            OnPropertyChanged("TARIFA_ALZA_MODFINAN")
        End Set
    End Property 

    Private _TARIFA_ALZA_MODFINANOld As Decimal
    Public Property TARIFA_ALZA_MODFINANOld() As Decimal
        Get
            Return _TARIFA_ALZA_MODFINANOld
        End Get
        Set(ByVal Value As Decimal)
            _TARIFA_ALZA_MODFINANOld = Value
        End Set
    End Property 

    Private _TARIFA_QUERQUEO As Decimal
    <Column(Name:="Tarifa querqueo", Storage:="TARIFA_QUERQUEO", DbType:="NUMERIC(10,4)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=4)> _
    Public Property TARIFA_QUERQUEO() As Decimal
        Get
            Return _TARIFA_QUERQUEO
        End Get
        Set(ByVal Value As Decimal)
            _TARIFA_QUERQUEO = Value
            OnPropertyChanged("TARIFA_QUERQUEO")
        End Set
    End Property 

    Private _TARIFA_QUERQUEOOld As Decimal
    Public Property TARIFA_QUERQUEOOld() As Decimal
        Get
            Return _TARIFA_QUERQUEOOld
        End Get
        Set(ByVal Value As Decimal)
            _TARIFA_QUERQUEOOld = Value
        End Set
    End Property 

    Private _PUREZA_AZUCAR As Decimal
    <Column(Name:="PUREZA_AZUCAR", Storage:="PUREZA_AZUCAR", DbType:="NUMERIC(20,6)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=6)> _
    Public Property PUREZA_AZUCAR() As Decimal
        Get
            Return _PUREZA_AZUCAR
        End Get
        Set(ByVal Value As Decimal)
            _PUREZA_AZUCAR = Value
            OnPropertyChanged("PUREZA_AZUCAR")
        End Set
    End Property

    Private _PUREZA_AZUCAROld As Decimal
    Public Property PUREZA_AZUCAROld() As Decimal
        Get
            Return _PUREZA_AZUCAROld
        End Get
        Set(ByVal Value As Decimal)
            _PUREZA_AZUCAROld = Value
        End Set
    End Property


    Private _CAPTURA_POL_BRIX_SIMULTANEA As Boolean
    <Column(Name:="Activa", Storage:="CAPTURA_POL_BRIX_SIMULTANEA", DBType:="BIT NOT NULL", Id:=False),
     DataObjectField(False, False, False, 1)>
    Public Property CAPTURA_POL_BRIX_SIMULTANEA() As Boolean
        Get
            Return _CAPTURA_POL_BRIX_SIMULTANEA
        End Get
        Set(ByVal Value As Boolean)
            _CAPTURA_POL_BRIX_SIMULTANEA = Value
            OnPropertyChanged("CAPTURA_POL_BRIX_SIMULTANEA")
        End Set
    End Property

    Private _CAPTURA_POL_BRIX_SIMULTANEAOld As Boolean
    Public Property CAPTURA_POL_BRIX_SIMULTANEAOld() As Boolean
        Get
            Return _CAPTURA_POL_BRIX_SIMULTANEAOld
        End Get
        Set(ByVal Value As Boolean)
            _CAPTURA_POL_BRIX_SIMULTANEAOld = Value
        End Set
    End Property

    Private _VIP_UNIDAD_TRADICIONAL As Decimal
    <Column(Name:="VIP Unidad tradicional", Storage:="VIP_UNIDAD_TRADICIONAL", DBType:="NUMERIC(20,6) NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=6)>
    Public Property VIP_UNIDAD_TRADICIONAL() As Decimal
        Get
            Return _VIP_UNIDAD_TRADICIONAL
        End Get
        Set(ByVal Value As Decimal)
            _VIP_UNIDAD_TRADICIONAL = Value
            OnPropertyChanged("VIP_UNIDAD_TRADICIONAL")
        End Set
    End Property

    Private _VIP_UNIDAD_TRADICIONALOld As Decimal
    Public Property VIP_UNIDAD_TRADICIONALOld() As Decimal
        Get
            Return _VIP_UNIDAD_TRADICIONALOld
        End Get
        Set(ByVal Value As Decimal)
            _VIP_UNIDAD_TRADICIONALOld = Value
        End Set
    End Property

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
