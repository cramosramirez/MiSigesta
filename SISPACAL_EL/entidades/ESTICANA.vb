''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.ESTICANA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row ESTICANA en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	19/01/2015	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="ESTICANA")> Public Class ESTICANA
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_ESTICANA As Int32, aACCESLOTE As String, aID_ZAFRA As Int32, aFECHA_ROZA As DateTime, aREND_COSECHA As Decimal, aMZ_ENTREGAR As Decimal, aTONEL_MZ_ENTREGAR As Decimal, aTONEL_ENTREGAR As Decimal, aLBS_ENTREGAR As Decimal, aVALOR_ENTREGAR As Decimal, aMZ_ENTREGADA As Decimal, aTONEL_MZ_ENTREGADA As Decimal, aTONEL_ENTREGADA As Decimal, aLBS_ENTREGADA As Decimal, aVALOR_ENTREGADA As Decimal, aMZ_CENSO As Decimal, aTONEL_MZ_CENSO As Decimal, aTONEL_CENSO As Decimal, aLBS_CENSO As Decimal, aVALOR_CENSO As Decimal, aFIN_LOTE As Boolean, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime, aCODIAGRON As String, aFECHA_SIEMBRA As DateTime, aID_TIPO_CANA As Int32, aID_TIPO_ROZA As Int32, aID_TIPO_ALZA As Int32, aID_TIPO_TRANS As Int32, aFAB_SEMANA As Int32, aFAB_CATORCENA As Int32, aFAB_SUBTERCIO As String, aFAB_TERCIO As Int32, aTARIFA_ROZA As Decimal, aTARIFA_ALZA As Decimal, aTARIFA_TRANS As Decimal, aTARIFA_CORTA As Decimal, aTARIFA_LARGA As Decimal, aSALDO_ROZA As Decimal, aEDAD_LOTE As Int32, aSALDO_QUEMA As Decimal, aFECHA_ROZA_DISPO As DateTime, ByVal aTONEL_SALDO_VAR As Decimal, ByVal aTONEL_SEMILLA As Decimal, ByVal aFECHA_CIERRE As DateTime, ByVal aHORAS_GRACIA_ENTREGA As Int32)
        Me._ID_ESTICANA = aID_ESTICANA
        Me._ACCESLOTE = aACCESLOTE
        Me._ID_ZAFRA = aID_ZAFRA
        Me._FECHA_ROZA = aFECHA_ROZA
        Me._REND_COSECHA = aREND_COSECHA
        Me._MZ_ENTREGAR = aMZ_ENTREGAR
        Me._TONEL_MZ_ENTREGAR = aTONEL_MZ_ENTREGAR
        Me._TONEL_ENTREGAR = aTONEL_ENTREGAR
        Me._LBS_ENTREGAR = aLBS_ENTREGAR
        Me._VALOR_ENTREGAR = aVALOR_ENTREGAR
        Me._MZ_ENTREGADA = aMZ_ENTREGADA
        Me._TONEL_MZ_ENTREGADA = aTONEL_MZ_ENTREGADA
        Me._TONEL_ENTREGADA = aTONEL_ENTREGADA
        Me._LBS_ENTREGADA = aLBS_ENTREGADA
        Me._VALOR_ENTREGADA = aVALOR_ENTREGADA
        Me._MZ_CENSO = aMZ_CENSO
        Me._TONEL_MZ_CENSO = aTONEL_MZ_CENSO
        Me._TONEL_CENSO = aTONEL_CENSO
        Me._LBS_CENSO = aLBS_CENSO
        Me._VALOR_CENSO = aVALOR_CENSO
        Me._FIN_LOTE = aFIN_LOTE
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
        Me._CODIAGRON = aCODIAGRON
        Me._FECHA_SIEMBRA = aFECHA_SIEMBRA
        Me._ID_TIPO_CANA = aID_TIPO_CANA
        Me._ID_TIPO_ROZA = aID_TIPO_ROZA
        Me._ID_TIPO_ALZA = aID_TIPO_ALZA
        Me._ID_TIPO_TRANS = aID_TIPO_TRANS
        Me._FAB_SEMANA = aFAB_SEMANA
        Me._FAB_CATORCENA = aFAB_CATORCENA
        Me._FAB_SUBTERCIO = aFAB_SUBTERCIO
        Me._FAB_TERCIO = aFAB_TERCIO
        Me._TARIFA_ROZA = aTARIFA_ROZA
        Me._TARIFA_ALZA = aTARIFA_ALZA
        Me._TARIFA_TRANS = aTARIFA_TRANS
        Me._TARIFA_CORTA = aTARIFA_CORTA
        Me._TARIFA_LARGA = aTARIFA_LARGA
        Me._SALDO_ROZA = aSALDO_ROZA
        Me._EDAD_LOTE = aEDAD_LOTE
        Me._SALDO_QUEMA = aSALDO_QUEMA
        Me._FECHA_ROZA_DISPO = aFECHA_ROZA_DISPO
        Me._TONEL_SALDO_VAR = aTONEL_SALDO_VAR
        Me._TONEL_SEMILLA = aTONEL_SEMILLA
        Me._FECHA_CIERRE = aFECHA_CIERRE
        Me._HORAS_GRACIA_ENTREGA = aHORAS_GRACIA_ENTREGA
    End Sub

#Region " Properties "

    Private _ID_ESTICANA As Int32
    <Column(Name:="Id esticana", Storage:="ID_ESTICANA", DBType:="INT NOT NULL", Id:=True),
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property ID_ESTICANA() As Int32
        Get
            Return _ID_ESTICANA
        End Get
        Set(ByVal Value As Int32)
            _ID_ESTICANA = Value
            OnPropertyChanged("ID_ESTICANA")
        End Set
    End Property

    Private _ACCESLOTE As String
    <Column(Name:="Acceslote", Storage:="ACCESLOTE", DBType:="CHAR(21) NOT NULL", Id:=False),
     DataObjectField(False, False, True, 21)>
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

    Private _ID_ZAFRA As Int32
    <Column(Name:="Id zafra", Storage:="ID_ZAFRA", DBType:="INT NOT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)>
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

    Private _FECHA_ROZA As DateTime
    <Column(Name:="Fecha roza", Storage:="FECHA_ROZA", DBType:="DATETIME", Id:=False),
     DataObjectField(False, False, True)>
    Public Property FECHA_ROZA() As DateTime
        Get
            Return _FECHA_ROZA
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_ROZA = Value
            OnPropertyChanged("FECHA_ROZA")
        End Set
    End Property

    Private _FECHA_ROZAOld As DateTime
    Public Property FECHA_ROZAOld() As DateTime
        Get
            Return _FECHA_ROZAOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_ROZAOld = Value
        End Set
    End Property

    Private _REND_COSECHA As Decimal
    <Column(Name:="Rend cosecha", Storage:="REND_COSECHA", DBType:="NUMERIC(11,4) NOT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=11, Scale:=4)>
    Public Property REND_COSECHA() As Decimal
        Get
            Return _REND_COSECHA
        End Get
        Set(ByVal Value As Decimal)
            _REND_COSECHA = Value
            OnPropertyChanged("REND_COSECHA")
        End Set
    End Property

    Private _REND_COSECHAOld As Decimal
    Public Property REND_COSECHAOld() As Decimal
        Get
            Return _REND_COSECHAOld
        End Get
        Set(ByVal Value As Decimal)
            _REND_COSECHAOld = Value
        End Set
    End Property

    Private _MZ_ENTREGAR As Decimal
    <Column(Name:="Mz entregar", Storage:="MZ_ENTREGAR", DBType:="NUMERIC(10,2) NOT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)>
    Public Property MZ_ENTREGAR() As Decimal
        Get
            Return _MZ_ENTREGAR
        End Get
        Set(ByVal Value As Decimal)
            _MZ_ENTREGAR = Value
            OnPropertyChanged("MZ_ENTREGAR")
        End Set
    End Property

    Private _MZ_ENTREGAROld As Decimal
    Public Property MZ_ENTREGAROld() As Decimal
        Get
            Return _MZ_ENTREGAROld
        End Get
        Set(ByVal Value As Decimal)
            _MZ_ENTREGAROld = Value
        End Set
    End Property

    Private _TONEL_MZ_ENTREGAR As Decimal
    <Column(Name:="Tonel mz entregar", Storage:="TONEL_MZ_ENTREGAR", DBType:="NUMERIC(10,2) NOT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)>
    Public Property TONEL_MZ_ENTREGAR() As Decimal
        Get
            Return _TONEL_MZ_ENTREGAR
        End Get
        Set(ByVal Value As Decimal)
            _TONEL_MZ_ENTREGAR = Value
            OnPropertyChanged("TONEL_MZ_ENTREGAR")
        End Set
    End Property

    Private _TONEL_MZ_ENTREGAROld As Decimal
    Public Property TONEL_MZ_ENTREGAROld() As Decimal
        Get
            Return _TONEL_MZ_ENTREGAROld
        End Get
        Set(ByVal Value As Decimal)
            _TONEL_MZ_ENTREGAROld = Value
        End Set
    End Property

    Private _TONEL_ENTREGAR As Decimal
    <Column(Name:="Tonel entregar", Storage:="TONEL_ENTREGAR", DBType:="NUMERIC(10,2) NOT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)>
    Public Property TONEL_ENTREGAR() As Decimal
        Get
            Return _TONEL_ENTREGAR
        End Get
        Set(ByVal Value As Decimal)
            _TONEL_ENTREGAR = Value
            OnPropertyChanged("TONEL_ENTREGAR")
        End Set
    End Property

    Private _TONEL_ENTREGAROld As Decimal
    Public Property TONEL_ENTREGAROld() As Decimal
        Get
            Return _TONEL_ENTREGAROld
        End Get
        Set(ByVal Value As Decimal)
            _TONEL_ENTREGAROld = Value
        End Set
    End Property

    Private _LBS_ENTREGAR As Decimal
    <Column(Name:="Lbs entregar", Storage:="LBS_ENTREGAR", DBType:="NUMERIC(10,2) NOT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)>
    Public Property LBS_ENTREGAR() As Decimal
        Get
            Return _LBS_ENTREGAR
        End Get
        Set(ByVal Value As Decimal)
            _LBS_ENTREGAR = Value
            OnPropertyChanged("LBS_ENTREGAR")
        End Set
    End Property

    Private _LBS_ENTREGAROld As Decimal
    Public Property LBS_ENTREGAROld() As Decimal
        Get
            Return _LBS_ENTREGAROld
        End Get
        Set(ByVal Value As Decimal)
            _LBS_ENTREGAROld = Value
        End Set
    End Property

    Private _VALOR_ENTREGAR As Decimal
    <Column(Name:="Valor entregar", Storage:="VALOR_ENTREGAR", DBType:="NUMERIC(18,2) NOT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=18, Scale:=2)>
    Public Property VALOR_ENTREGAR() As Decimal
        Get
            Return _VALOR_ENTREGAR
        End Get
        Set(ByVal Value As Decimal)
            _VALOR_ENTREGAR = Value
            OnPropertyChanged("VALOR_ENTREGAR")
        End Set
    End Property

    Private _VALOR_ENTREGAROld As Decimal
    Public Property VALOR_ENTREGAROld() As Decimal
        Get
            Return _VALOR_ENTREGAROld
        End Get
        Set(ByVal Value As Decimal)
            _VALOR_ENTREGAROld = Value
        End Set
    End Property

    Private _MZ_ENTREGADA As Decimal
    <Column(Name:="Mz entregada", Storage:="MZ_ENTREGADA", DBType:="NUMERIC(10,2) NOT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)>
    Public Property MZ_ENTREGADA() As Decimal
        Get
            Return _MZ_ENTREGADA
        End Get
        Set(ByVal Value As Decimal)
            _MZ_ENTREGADA = Value
            OnPropertyChanged("MZ_ENTREGADA")
        End Set
    End Property

    Private _MZ_ENTREGADAOld As Decimal
    Public Property MZ_ENTREGADAOld() As Decimal
        Get
            Return _MZ_ENTREGADAOld
        End Get
        Set(ByVal Value As Decimal)
            _MZ_ENTREGADAOld = Value
        End Set
    End Property

    Private _TONEL_MZ_ENTREGADA As Decimal
    <Column(Name:="Tonel mz entregada", Storage:="TONEL_MZ_ENTREGADA", DBType:="NUMERIC(10,2) NOT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)>
    Public Property TONEL_MZ_ENTREGADA() As Decimal
        Get
            Return _TONEL_MZ_ENTREGADA
        End Get
        Set(ByVal Value As Decimal)
            _TONEL_MZ_ENTREGADA = Value
            OnPropertyChanged("TONEL_MZ_ENTREGADA")
        End Set
    End Property

    Private _TONEL_MZ_ENTREGADAOld As Decimal
    Public Property TONEL_MZ_ENTREGADAOld() As Decimal
        Get
            Return _TONEL_MZ_ENTREGADAOld
        End Get
        Set(ByVal Value As Decimal)
            _TONEL_MZ_ENTREGADAOld = Value
        End Set
    End Property

    Private _TONEL_ENTREGADA As Decimal
    <Column(Name:="Tonel entregada", Storage:="TONEL_ENTREGADA", DBType:="NUMERIC(10,2) NOT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)>
    Public Property TONEL_ENTREGADA() As Decimal
        Get
            Return _TONEL_ENTREGADA
        End Get
        Set(ByVal Value As Decimal)
            _TONEL_ENTREGADA = Value
            OnPropertyChanged("TONEL_ENTREGADA")
        End Set
    End Property

    Private _TONEL_ENTREGADAOld As Decimal
    Public Property TONEL_ENTREGADAOld() As Decimal
        Get
            Return _TONEL_ENTREGADAOld
        End Get
        Set(ByVal Value As Decimal)
            _TONEL_ENTREGADAOld = Value
        End Set
    End Property

    Private _LBS_ENTREGADA As Decimal
    <Column(Name:="Lbs entregada", Storage:="LBS_ENTREGADA", DBType:="NUMERIC(10,2) NOT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)>
    Public Property LBS_ENTREGADA() As Decimal
        Get
            Return _LBS_ENTREGADA
        End Get
        Set(ByVal Value As Decimal)
            _LBS_ENTREGADA = Value
            OnPropertyChanged("LBS_ENTREGADA")
        End Set
    End Property

    Private _LBS_ENTREGADAOld As Decimal
    Public Property LBS_ENTREGADAOld() As Decimal
        Get
            Return _LBS_ENTREGADAOld
        End Get
        Set(ByVal Value As Decimal)
            _LBS_ENTREGADAOld = Value
        End Set
    End Property

    Private _VALOR_ENTREGADA As Decimal
    <Column(Name:="Valor entregada", Storage:="VALOR_ENTREGADA", DBType:="NUMERIC(18,2) NOT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=18, Scale:=2)>
    Public Property VALOR_ENTREGADA() As Decimal
        Get
            Return _VALOR_ENTREGADA
        End Get
        Set(ByVal Value As Decimal)
            _VALOR_ENTREGADA = Value
            OnPropertyChanged("VALOR_ENTREGADA")
        End Set
    End Property

    Private _VALOR_ENTREGADAOld As Decimal
    Public Property VALOR_ENTREGADAOld() As Decimal
        Get
            Return _VALOR_ENTREGADAOld
        End Get
        Set(ByVal Value As Decimal)
            _VALOR_ENTREGADAOld = Value
        End Set
    End Property

    Private _MZ_CENSO As Decimal
    <Column(Name:="Mz censo", Storage:="MZ_CENSO", DBType:="NUMERIC(10,2) NOT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)>
    Public Property MZ_CENSO() As Decimal
        Get
            Return _MZ_CENSO
        End Get
        Set(ByVal Value As Decimal)
            _MZ_CENSO = Value
            OnPropertyChanged("MZ_CENSO")
        End Set
    End Property

    Private _MZ_CENSOOld As Decimal
    Public Property MZ_CENSOOld() As Decimal
        Get
            Return _MZ_CENSOOld
        End Get
        Set(ByVal Value As Decimal)
            _MZ_CENSOOld = Value
        End Set
    End Property

    Private _TONEL_MZ_CENSO As Decimal
    <Column(Name:="Tonel mz censo", Storage:="TONEL_MZ_CENSO", DBType:="NUMERIC(10,2) NOT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)>
    Public Property TONEL_MZ_CENSO() As Decimal
        Get
            Return _TONEL_MZ_CENSO
        End Get
        Set(ByVal Value As Decimal)
            _TONEL_MZ_CENSO = Value
            OnPropertyChanged("TONEL_MZ_CENSO")
        End Set
    End Property

    Private _TONEL_MZ_CENSOOld As Decimal
    Public Property TONEL_MZ_CENSOOld() As Decimal
        Get
            Return _TONEL_MZ_CENSOOld
        End Get
        Set(ByVal Value As Decimal)
            _TONEL_MZ_CENSOOld = Value
        End Set
    End Property

    Private _TONEL_CENSO As Decimal
    <Column(Name:="Tonel censo", Storage:="TONEL_CENSO", DBType:="NUMERIC(10,2) NOT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)>
    Public Property TONEL_CENSO() As Decimal
        Get
            Return _TONEL_CENSO
        End Get
        Set(ByVal Value As Decimal)
            _TONEL_CENSO = Value
            OnPropertyChanged("TONEL_CENSO")
        End Set
    End Property

    Private _TONEL_CENSOOld As Decimal
    Public Property TONEL_CENSOOld() As Decimal
        Get
            Return _TONEL_CENSOOld
        End Get
        Set(ByVal Value As Decimal)
            _TONEL_CENSOOld = Value
        End Set
    End Property

    Private _LBS_CENSO As Decimal
    <Column(Name:="Lbs censo", Storage:="LBS_CENSO", DBType:="NUMERIC(10,2) NOT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)>
    Public Property LBS_CENSO() As Decimal
        Get
            Return _LBS_CENSO
        End Get
        Set(ByVal Value As Decimal)
            _LBS_CENSO = Value
            OnPropertyChanged("LBS_CENSO")
        End Set
    End Property

    Private _LBS_CENSOOld As Decimal
    Public Property LBS_CENSOOld() As Decimal
        Get
            Return _LBS_CENSOOld
        End Get
        Set(ByVal Value As Decimal)
            _LBS_CENSOOld = Value
        End Set
    End Property

    Private _VALOR_CENSO As Decimal
    <Column(Name:="Valor censo", Storage:="VALOR_CENSO", DBType:="NUMERIC(18,2) NOT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=18, Scale:=2)>
    Public Property VALOR_CENSO() As Decimal
        Get
            Return _VALOR_CENSO
        End Get
        Set(ByVal Value As Decimal)
            _VALOR_CENSO = Value
            OnPropertyChanged("VALOR_CENSO")
        End Set
    End Property

    Private _VALOR_CENSOOld As Decimal
    Public Property VALOR_CENSOOld() As Decimal
        Get
            Return _VALOR_CENSOOld
        End Get
        Set(ByVal Value As Decimal)
            _VALOR_CENSOOld = Value
        End Set
    End Property

    Private _FIN_LOTE As Boolean
    <Column(Name:="Fin lote", Storage:="FIN_LOTE", DBType:="BIT NOT NULL", Id:=False),
     DataObjectField(False, False, False, 1)>
    Public Property FIN_LOTE() As Boolean
        Get
            Return _FIN_LOTE
        End Get
        Set(ByVal Value As Boolean)
            _FIN_LOTE = Value
            OnPropertyChanged("FIN_LOTE")
        End Set
    End Property

    Private _FIN_LOTEOld As Boolean
    Public Property FIN_LOTEOld() As Boolean
        Get
            Return _FIN_LOTEOld
        End Get
        Set(ByVal Value As Boolean)
            _FIN_LOTEOld = Value
        End Set
    End Property

    Private _USUARIO_CREA As String
    <Column(Name:="Usuario crea", Storage:="USUARIO_CREA", DBType:="VARCHAR(100) NOT NULL", Id:=False),
     DataObjectField(False, False, False, 100)>
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
    <Column(Name:="Fecha crea", Storage:="FECHA_CREA", DBType:="DATETIME NOT NULL", Id:=False),
     DataObjectField(False, False, False)>
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
    <Column(Name:="Usuario act", Storage:="USUARIO_ACT", DBType:="VARCHAR(100) NOT NULL", Id:=False),
     DataObjectField(False, False, False, 100)>
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
    <Column(Name:="Fecha act", Storage:="FECHA_ACT", DBType:="DATETIME NOT NULL", Id:=False),
     DataObjectField(False, False, False)>
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

    Private _CODIAGRON As String
    <Column(Name:="Codiagron", Storage:="CODIAGRON", DBType:="CHAR(8)", Id:=False),
     DataObjectField(False, False, True, 8)>
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

    Private _fkCODIAGRON As AGRONOMO
    Public Property fkCODIAGRON() As AGRONOMO
        Get
            Return _fkCODIAGRON
        End Get
        Set(ByVal Value As AGRONOMO)
            _fkCODIAGRON = Value
        End Set
    End Property

    Private _FECHA_SIEMBRA As DateTime
    <Column(Name:="Fecha siembra", Storage:="FECHA_SIEMBRA", DBType:="DATETIME", Id:=False),
     DataObjectField(False, False, True)>
    Public Property FECHA_SIEMBRA() As DateTime
        Get
            Return _FECHA_SIEMBRA
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_SIEMBRA = Value
            OnPropertyChanged("FECHA_SIEMBRA")
        End Set
    End Property

    Private _FECHA_SIEMBRAOld As DateTime
    Public Property FECHA_SIEMBRAOld() As DateTime
        Get
            Return _FECHA_SIEMBRAOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_SIEMBRAOld = Value
        End Set
    End Property

    Private _ID_TIPO_CANA As Int32
    <Column(Name:="Id tipo cana", Storage:="ID_TIPO_CANA", DBType:="INT", Id:=False),
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)>
    Public Property ID_TIPO_CANA() As Int32
        Get
            Return _ID_TIPO_CANA
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_CANA = Value
            OnPropertyChanged("ID_TIPO_CANA")
        End Set
    End Property

    Private _ID_TIPO_CANAOld As Int32
    Public Property ID_TIPO_CANAOld() As Int32
        Get
            Return _ID_TIPO_CANAOld
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_CANAOld = Value
        End Set
    End Property

    Private _fkID_TIPO_CANA As TIPOS_GENERALES
    Public Property fkID_TIPO_CANA() As TIPOS_GENERALES
        Get
            Return _fkID_TIPO_CANA
        End Get
        Set(ByVal Value As TIPOS_GENERALES)
            _fkID_TIPO_CANA = Value
        End Set
    End Property

    Private _ID_TIPO_ROZA As Int32
    <Column(Name:="Id tipo roza", Storage:="ID_TIPO_ROZA", DBType:="INT", Id:=False),
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)>
    Public Property ID_TIPO_ROZA() As Int32
        Get
            Return _ID_TIPO_ROZA
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_ROZA = Value
            OnPropertyChanged("ID_TIPO_ROZA")
        End Set
    End Property

    Private _ID_TIPO_ROZAOld As Int32
    Public Property ID_TIPO_ROZAOld() As Int32
        Get
            Return _ID_TIPO_ROZAOld
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_ROZAOld = Value
        End Set
    End Property

    Private _fkID_TIPO_ROZA As TIPOS_GENERALES
    Public Property fkID_TIPO_ROZA() As TIPOS_GENERALES
        Get
            Return _fkID_TIPO_ROZA
        End Get
        Set(ByVal Value As TIPOS_GENERALES)
            _fkID_TIPO_ROZA = Value
        End Set
    End Property

    Private _ID_TIPO_ALZA As Int32
    <Column(Name:="Id tipo alza", Storage:="ID_TIPO_ALZA", DBType:="INT", Id:=False),
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)>
    Public Property ID_TIPO_ALZA() As Int32
        Get
            Return _ID_TIPO_ALZA
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_ALZA = Value
            OnPropertyChanged("ID_TIPO_ALZA")
        End Set
    End Property

    Private _ID_TIPO_ALZAOld As Int32
    Public Property ID_TIPO_ALZAOld() As Int32
        Get
            Return _ID_TIPO_ALZAOld
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_ALZAOld = Value
        End Set
    End Property

    Private _fkID_TIPO_ALZA As TIPOS_GENERALES
    Public Property fkID_TIPO_ALZA() As TIPOS_GENERALES
        Get
            Return _fkID_TIPO_ALZA
        End Get
        Set(ByVal Value As TIPOS_GENERALES)
            _fkID_TIPO_ALZA = Value
        End Set
    End Property

    Private _ID_TIPO_TRANS As Int32
    <Column(Name:="Id tipo trans", Storage:="ID_TIPO_TRANS", DBType:="INT", Id:=False),
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)>
    Public Property ID_TIPO_TRANS() As Int32
        Get
            Return _ID_TIPO_TRANS
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_TRANS = Value
            OnPropertyChanged("ID_TIPO_TRANS")
        End Set
    End Property

    Private _ID_TIPO_TRANSOld As Int32
    Public Property ID_TIPO_TRANSOld() As Int32
        Get
            Return _ID_TIPO_TRANSOld
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_TRANSOld = Value
        End Set
    End Property

    Private _fkID_TIPO_TRANS As TIPOS_GENERALES
    Public Property fkID_TIPO_TRANS() As TIPOS_GENERALES
        Get
            Return _fkID_TIPO_TRANS
        End Get
        Set(ByVal Value As TIPOS_GENERALES)
            _fkID_TIPO_TRANS = Value
        End Set
    End Property

    Private _FAB_SEMANA As Int32
    <Column(Name:="Fab semana", Storage:="FAB_SEMANA", DBType:="INT", Id:=False),
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)>
    Public Property FAB_SEMANA() As Int32
        Get
            Return _FAB_SEMANA
        End Get
        Set(ByVal Value As Int32)
            _FAB_SEMANA = Value
            OnPropertyChanged("FAB_SEMANA")
        End Set
    End Property

    Private _FAB_SEMANAOld As Int32
    Public Property FAB_SEMANAOld() As Int32
        Get
            Return _FAB_SEMANAOld
        End Get
        Set(ByVal Value As Int32)
            _FAB_SEMANAOld = Value
        End Set
    End Property

    Private _FAB_CATORCENA As Int32
    <Column(Name:="Fab catorcena", Storage:="FAB_CATORCENA", DBType:="INT", Id:=False),
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)>
    Public Property FAB_CATORCENA() As Int32
        Get
            Return _FAB_CATORCENA
        End Get
        Set(ByVal Value As Int32)
            _FAB_CATORCENA = Value
            OnPropertyChanged("FAB_CATORCENA")
        End Set
    End Property

    Private _FAB_CATORCENAOld As Int32
    Public Property FAB_CATORCENAOld() As Int32
        Get
            Return _FAB_CATORCENAOld
        End Get
        Set(ByVal Value As Int32)
            _FAB_CATORCENAOld = Value
        End Set
    End Property

    Private _FAB_SUBTERCIO As String
    <Column(Name:="Fab subtercio", Storage:="FAB_SUBTERCIO", DBType:="VARCHAR(20)", Id:=False),
     DataObjectField(False, False, True, 20)>
    Public Property FAB_SUBTERCIO() As String
        Get
            Return _FAB_SUBTERCIO
        End Get
        Set(ByVal Value As String)
            _FAB_SUBTERCIO = Value
            OnPropertyChanged("FAB_SUBTERCIO")
        End Set
    End Property

    Private _FAB_SUBTERCIOOld As String
    Public Property FAB_SUBTERCIOOld() As String
        Get
            Return _FAB_SUBTERCIOOld
        End Get
        Set(ByVal Value As String)
            _FAB_SUBTERCIOOld = Value
        End Set
    End Property

    Private _FAB_TERCIO As Int32
    <Column(Name:="Fab tercio", Storage:="FAB_TERCIO", DBType:="INT", Id:=False),
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)>
    Public Property FAB_TERCIO() As Int32
        Get
            Return _FAB_TERCIO
        End Get
        Set(ByVal Value As Int32)
            _FAB_TERCIO = Value
            OnPropertyChanged("FAB_TERCIO")
        End Set
    End Property

    Private _FAB_TERCIOOld As Int32
    Public Property FAB_TERCIOOld() As Int32
        Get
            Return _FAB_TERCIOOld
        End Get
        Set(ByVal Value As Int32)
            _FAB_TERCIOOld = Value
        End Set
    End Property

    Private _TARIFA_ROZA As Decimal
    <Column(Name:="Tarifa roza", Storage:="TARIFA_ROZA", DBType:="NUMERIC(10,6)", Id:=False),
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=6)>
    Public Property TARIFA_ROZA() As Decimal
        Get
            Return _TARIFA_ROZA
        End Get
        Set(ByVal Value As Decimal)
            _TARIFA_ROZA = Value
            OnPropertyChanged("TARIFA_ROZA")
        End Set
    End Property

    Private _TARIFA_ROZAOld As Decimal
    Public Property TARIFA_ROZAOld() As Decimal
        Get
            Return _TARIFA_ROZAOld
        End Get
        Set(ByVal Value As Decimal)
            _TARIFA_ROZAOld = Value
        End Set
    End Property

    Private _TARIFA_ALZA As Decimal
    <Column(Name:="Tarifa alza", Storage:="TARIFA_ALZA", DBType:="NUMERIC(5,2)", Id:=False),
     DataObjectField(False, False, True), Precision(Precision:=5, Scale:=2)>
    Public Property TARIFA_ALZA() As Decimal
        Get
            Return _TARIFA_ALZA
        End Get
        Set(ByVal Value As Decimal)
            _TARIFA_ALZA = Value
            OnPropertyChanged("TARIFA_ALZA")
        End Set
    End Property

    Private _TARIFA_ALZAOld As Decimal
    Public Property TARIFA_ALZAOld() As Decimal
        Get
            Return _TARIFA_ALZAOld
        End Get
        Set(ByVal Value As Decimal)
            _TARIFA_ALZAOld = Value
        End Set
    End Property

    Private _TARIFA_TRANS As Decimal
    <Column(Name:="Tarifa trans", Storage:="TARIFA_TRANS", DBType:="NUMERIC(5,2)", Id:=False),
     DataObjectField(False, False, True), Precision(Precision:=5, Scale:=2)>
    Public Property TARIFA_TRANS() As Decimal
        Get
            Return _TARIFA_TRANS
        End Get
        Set(ByVal Value As Decimal)
            _TARIFA_TRANS = Value
            OnPropertyChanged("TARIFA_TRANS")
        End Set
    End Property

    Private _TARIFA_TRANSOld As Decimal
    Public Property TARIFA_TRANSOld() As Decimal
        Get
            Return _TARIFA_TRANSOld
        End Get
        Set(ByVal Value As Decimal)
            _TARIFA_TRANSOld = Value
        End Set
    End Property

    Private _TARIFA_CORTA As Decimal
    <Column(Name:="Tarifa corta", Storage:="TARIFA_CORTA", DBType:="NUMERIC(5,2)", Id:=False),
     DataObjectField(False, False, True), Precision(Precision:=5, Scale:=2)>
    Public Property TARIFA_CORTA() As Decimal
        Get
            Return _TARIFA_CORTA
        End Get
        Set(ByVal Value As Decimal)
            _TARIFA_CORTA = Value
            OnPropertyChanged("TARIFA_CORTA")
        End Set
    End Property

    Private _TARIFA_CORTAOld As Decimal
    Public Property TARIFA_CORTAOld() As Decimal
        Get
            Return _TARIFA_CORTAOld
        End Get
        Set(ByVal Value As Decimal)
            _TARIFA_CORTAOld = Value
        End Set
    End Property

    Private _TARIFA_LARGA As Decimal
    <Column(Name:="Tarifa larga", Storage:="TARIFA_LARGA", DBType:="NUMERIC(5,2)", Id:=False),
     DataObjectField(False, False, True), Precision(Precision:=5, Scale:=2)>
    Public Property TARIFA_LARGA() As Decimal
        Get
            Return _TARIFA_LARGA
        End Get
        Set(ByVal Value As Decimal)
            _TARIFA_LARGA = Value
            OnPropertyChanged("TARIFA_LARGA")
        End Set
    End Property

    Private _TARIFA_LARGAOld As Decimal
    Public Property TARIFA_LARGAOld() As Decimal
        Get
            Return _TARIFA_LARGAOld
        End Get
        Set(ByVal Value As Decimal)
            _TARIFA_LARGAOld = Value
        End Set
    End Property

    Private _SALDO_ROZA As Decimal
    <Column(Name:="Saldo roza", Storage:="SALDO_ROZA", DBType:="NUMERIC(10,2) NOT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)>
    Public Property SALDO_ROZA() As Decimal
        Get
            Return _SALDO_ROZA
        End Get
        Set(ByVal Value As Decimal)
            _SALDO_ROZA = Value
            OnPropertyChanged("SALDO_ROZA")
        End Set
    End Property

    Private _SALDO_ROZAOld As Decimal
    Public Property SALDO_ROZAOld() As Decimal
        Get
            Return _SALDO_ROZAOld
        End Get
        Set(ByVal Value As Decimal)
            _SALDO_ROZAOld = Value
        End Set
    End Property

    Private _EDAD_LOTE As Int32
    <Column(Name:="Edad lote", Storage:="EDAD_LOTE", DBType:="INT NOT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property EDAD_LOTE() As Int32
        Get
            Return _EDAD_LOTE
        End Get
        Set(ByVal Value As Int32)
            _EDAD_LOTE = Value
            OnPropertyChanged("EDAD_LOTE")
        End Set
    End Property

    Private _EDAD_LOTEOld As Int32
    Public Property EDAD_LOTEOld() As Int32
        Get
            Return _EDAD_LOTEOld
        End Get
        Set(ByVal Value As Int32)
            _EDAD_LOTEOld = Value
        End Set
    End Property

    Private _SALDO_QUEMA As Decimal
    <Column(Name:="Saldo quema", Storage:="SALDO_QUEMA", DBType:="NUMERIC(10,2) NOT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)>
    Public Property SALDO_QUEMA() As Decimal
        Get
            Return _SALDO_QUEMA
        End Get
        Set(ByVal Value As Decimal)
            _SALDO_QUEMA = Value
            OnPropertyChanged("SALDO_QUEMA")
        End Set
    End Property

    Private _SALDO_QUEMAOld As Decimal
    Public Property SALDO_QUEMAOld() As Decimal
        Get
            Return _SALDO_QUEMAOld
        End Get
        Set(ByVal Value As Decimal)
            _SALDO_QUEMAOld = Value
        End Set
    End Property


    Private _FECHA_ROZA_DISPO As DateTime
    <Column(Name:="Fecha roza", Storage:="FECHA_ROZA_DISPO", DBType:="DATETIME", Id:=False),
     DataObjectField(False, False, True)>
    Public Property FECHA_ROZA_DISPO() As DateTime
        Get
            Return _FECHA_ROZA_DISPO
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_ROZA_DISPO = Value
            OnPropertyChanged("FECHA_ROZA_DISPO")
        End Set
    End Property

    Private _FECHA_ROZA_DISPOOld As DateTime
    Public Property FECHA_ROZA_DISPOOld() As DateTime
        Get
            Return _FECHA_ROZA_DISPOOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_ROZA_DISPOOld = Value
        End Set
    End Property



    Private _TONEL_SALDO_VAR As Decimal
    <Column(Name:="Tonel saldo var", Storage:="TONEL_SALDO_VAR", DBType:="NUMERIC(10,2) NOT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)>
    Public Property TONEL_SALDO_VAR() As Decimal
        Get
            Return _TONEL_SALDO_VAR
        End Get
        Set(ByVal Value As Decimal)
            _TONEL_SALDO_VAR = Value
            OnPropertyChanged("TONEL_SALDO_VAR")
        End Set
    End Property

    Private _TONEL_SALDO_VAROld As Decimal
    Public Property TONEL_SALDO_VAROld() As Decimal
        Get
            Return _TONEL_SALDO_VAROld
        End Get
        Set(ByVal Value As Decimal)
            _TONEL_SALDO_VAROld = Value
        End Set
    End Property



    Private _TONEL_SEMILLA As Decimal
    <Column(Name:="Tonel semilla", Storage:="TONEL_SEMILLA", DBType:="NUMERIC(10,2) NOT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)>
    Public Property TONEL_SEMILLA() As Decimal
        Get
            Return _TONEL_SEMILLA
        End Get
        Set(ByVal Value As Decimal)
            _TONEL_SEMILLA = Value
            OnPropertyChanged("TONEL_SEMILLA")
        End Set
    End Property

    Private _TONEL_SEMILLAOld As Decimal
    Public Property TONEL_SEMILLAOld() As Decimal
        Get
            Return _TONEL_SEMILLAOld
        End Get
        Set(ByVal Value As Decimal)
            _TONEL_SEMILLAOld = Value
        End Set
    End Property


    Private _FECHA_CIERRE As DateTime
    <Column(Name:="Fecha cierre", Storage:="FECHA_CIERRE", DBType:="DATETIME", Id:=False),
     DataObjectField(False, False, True)>
    Public Property FECHA_CIERRE() As DateTime
        Get
            Return _FECHA_CIERRE
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_CIERRE = Value
            OnPropertyChanged("FECHA_CIERRE")
        End Set
    End Property

    Private __FECHA_CIERREOld As DateTime
    Public Property _FECHA_CIERREOld() As DateTime
        Get
            Return __FECHA_CIERREOld
        End Get
        Set(ByVal Value As DateTime)
            __FECHA_CIERREOld = Value
        End Set
    End Property

    Private _HORAS_GRACIA_ENTREGA As Decimal
    <Column(Name:="Horas gracia entrega", Storage:="HORAS_GRACIA_ENTREGA", DBType:="INT", Id:=False),
    DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)>
    Public Property HORAS_GRACIA_ENTREGA() As Int32
        Get
            Return _HORAS_GRACIA_ENTREGA
        End Get
        Set(ByVal Value As Int32)
            _HORAS_GRACIA_ENTREGA = Value
            OnPropertyChanged("HORAS_GRACIA_ENTREGA")
        End Set
    End Property

    Private _HORAS_GRACIA_ENTREGAOld As Int32
    Public Property HORAS_GRACIA_ENTREGAOld() As Int32
        Get
            Return _HORAS_GRACIA_ENTREGAOld
        End Get
        Set(ByVal Value As Int32)
            _HORAS_GRACIA_ENTREGAOld = Value
        End Set
    End Property

    Private _CODILOTE As String
    <Column(Name:="CODILOTE", Storage:="CODILOTE", DBType:="CHAR(5) NOT NULL", Id:=False),
     DataObjectField(False, False, True, 5)>
    Public Property CODILOTE() As String
        Get
            Return _CODILOTE
        End Get
        Set(ByVal Value As String)
            _CODILOTE = Value
            OnPropertyChanged("CODILOTE")
        End Set
    End Property

    Private _CODILOTEOld As String
    Public Property CODILOTEOld() As String
        Get
            Return _CODILOTEOld
        End Get
        Set(ByVal Value As String)
            _CODILOTEOld = Value
        End Set
    End Property

    Private _NOMBLOTE As String
    <Column(Name:="NOMBLOTE", Storage:="NOMBLOTE", DBType:="CHAR(60) NOT NULL", Id:=False),
     DataObjectField(False, False, True, 60)>
    Public Property NOMBLOTE() As String
        Get
            Return _NOMBLOTE
        End Get
        Set(ByVal Value As String)
            _NOMBLOTE = Value
            OnPropertyChanged("NOMBLOTE")
        End Set
    End Property

    Private _NOMBLOTEOld As String
    Public Property NOMBLOTEOld() As String
        Get
            Return _NOMBLOTEOld
        End Get
        Set(ByVal Value As String)
            _NOMBLOTEOld = Value
        End Set
    End Property

    Private _CODIPROVEEDOR As String
    <Column(Name:="CODIPROVEEDOR", Storage:="CODIPROVEEDOR", DBType:="CHAR(10) NOT NULL", Id:=False),
     DataObjectField(False, False, True, 10)>
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

    Private _CONTRATADO As Boolean
    <Column(Name:="CONTRATADO", Storage:="CONTRATADO", DBType:="BIT NOT NULL", Id:=False),
     DataObjectField(False, False, True)>
    Public Property CONTRATADO() As Boolean
        Get
            Return _CONTRATADO
        End Get
        Set(ByVal Value As Boolean)
            _CONTRATADO = Value
            OnPropertyChanged("CONTRATADO")
        End Set
    End Property

    Private _CONTRATADOOld As Boolean
    Public Property CONTRATADOOld() As Boolean
        Get
            Return _CONTRATADOOld
        End Get
        Set(ByVal Value As Boolean)
            _CONTRATADOOld = Value
        End Set
    End Property

    Private _ID_MAESTRO As Int32
    <Column(Name:="ID_MAESTRO", Storage:="ID_MAESTRO", DBType:="INT NOT NULL", Id:=True),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property ID_MAESTRO() As Int32
        Get
            Return _ID_MAESTRO
        End Get
        Set(ByVal Value As Int32)
            _ID_MAESTRO = Value
            OnPropertyChanged("ID_MAESTRO")
        End Set
    End Property

    Private _ID_MAESTROOld As Int32
    Public Property ID_MAESTROOld() As Int32
        Get
            Return _ID_MAESTROOld
        End Get
        Set(ByVal Value As Int32)
            _ID_MAESTROOld = Value
        End Set
    End Property
#End Region

#Region " Relaciones "
#End Region
#End Region
End Class

