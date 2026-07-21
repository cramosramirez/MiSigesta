''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.ANALISIS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row ANALISIS en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	21/02/2019	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="ANALISIS")> Public Class ANALISIS
    Inherits entidadBase

#Region " Metodos Generador "


    Public Sub New(aID_ANALISIS As Int32, aID_ENVIO As Int32, aBAGAZO_BRUTO As Decimal, aBAGAZO_NETO As Decimal, aPOL As Decimal, aBRIX As Decimal, aFIBRA_CANA As Decimal, aHUMEDAD As Decimal, aPOL_JUGO As Decimal, aJUGO_CANA As Decimal, aPOL_CANA As Decimal, aPUREZA_JUGO As Decimal, aPUREZA_AZUCAR As Decimal, aSJM As Decimal, aRENDIA_CALC1 As Decimal, aRENDIA_CALC2 As Decimal, aRENDIA_REAL As Decimal, aRENCATORCENA_REAL As Decimal, aAZUCAR_CALC1 As Decimal, aAZUCAR_CALC2 As Decimal, aAZUCAR_REAL As Decimal, aAZUCAR_CATORCENA_REAL As Decimal, aPAGO_INI_CALC As Decimal, aPAGO_INI_REAL As Decimal, aPAGO_CATORCENA_REAL As Decimal, aUSUARIO_LEE_BAGAZO_BRUTO As String, aFECHA_LEE_BAGAZO_BRUTO As DateTime, aUSUARIO_LEE_BAGAZO_TARA As String, aFECHA_LEE_BAGAZO_TARA As DateTime, aUSUARIO_LEE_POL As String, aFECHA_LEE_POL As DateTime, aUSUARIO_LEE_BRIX As String, aFECHA_LEE_BRIX As DateTime, aPOL_LECTURA As Decimal, aPH As Decimal, aAZUCAR_REDUCTORES As Decimal, aES_ANOMALO As Boolean, aRENDIA85_ANOMALO As Decimal, aAPLICAR_REND_DIA As Boolean)
        Me._ID_ANALISIS = aID_ANALISIS
        Me._ID_ENVIO = aID_ENVIO
        Me._BAGAZO_BRUTO = aBAGAZO_BRUTO
        Me._BAGAZO_NETO = aBAGAZO_NETO
        Me._POL = aPOL
        Me._BRIX = aBRIX
        Me._FIBRA_CANA = aFIBRA_CANA
        Me._HUMEDAD = aHUMEDAD
        Me._POL_JUGO = aPOL_JUGO
        Me._JUGO_CANA = aJUGO_CANA
        Me._POL_CANA = aPOL_CANA
        Me._PUREZA_JUGO = aPUREZA_JUGO
        Me._PUREZA_AZUCAR = aPUREZA_AZUCAR
        Me._SJM = aSJM
        Me._RENDIA_CALC1 = aRENDIA_CALC1
        Me._RENDIA_CALC2 = aRENDIA_CALC2
        Me._RENDIA_REAL = aRENDIA_REAL
        Me._RENCATORCENA_REAL = aRENCATORCENA_REAL
        Me._AZUCAR_CALC1 = aAZUCAR_CALC1
        Me._AZUCAR_CALC2 = aAZUCAR_CALC2
        Me._AZUCAR_REAL = aAZUCAR_REAL
        Me._AZUCAR_CATORCENA_REAL = aAZUCAR_CATORCENA_REAL
        Me._PAGO_INI_CALC = aPAGO_INI_CALC
        Me._PAGO_INI_REAL = aPAGO_INI_REAL
        Me._PAGO_CATORCENA_REAL = aPAGO_CATORCENA_REAL
        Me._USUARIO_LEE_BAGAZO_BRUTO = aUSUARIO_LEE_BAGAZO_BRUTO
        Me._FECHA_LEE_BAGAZO_BRUTO = aFECHA_LEE_BAGAZO_BRUTO
        Me._USUARIO_LEE_BAGAZO_TARA = aUSUARIO_LEE_BAGAZO_TARA
        Me._FECHA_LEE_BAGAZO_TARA = aFECHA_LEE_BAGAZO_TARA
        Me._USUARIO_LEE_POL = aUSUARIO_LEE_POL
        Me._FECHA_LEE_POL = aFECHA_LEE_POL
        Me._USUARIO_LEE_BRIX = aUSUARIO_LEE_BRIX
        Me._FECHA_LEE_BRIX = aFECHA_LEE_BRIX
        Me._POL_LECTURA = aPOL_LECTURA
        Me._PH = aPH
        Me._AZUCAR_REDUCTORES = aAZUCAR_REDUCTORES
        Me._ES_ANOMALO = aES_ANOMALO
        Me._RENDIA85_ANOMALO = aRENDIA85_ANOMALO
        Me._APLICAR_REND_DIA = aAPLICAR_REND_DIA
    End Sub

#Region " Properties "

    Private _ID_ANALISIS As Int32
    <Column(Name:="Id analisis", Storage:="ID_ANALISIS", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_ANALISIS() As Int32
        Get
            Return _ID_ANALISIS
        End Get
        Set(ByVal Value As Int32)
            _ID_ANALISIS = Value
            OnPropertyChanged("ID_ANALISIS")
        End Set
    End Property 

    Private _ID_ENVIO As Int32
    <Column(Name:="Id envio", Storage:="ID_ENVIO", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_ENVIO() As Int32
        Get
            Return _ID_ENVIO
        End Get
        Set(ByVal Value As Int32)
            _ID_ENVIO = Value
            OnPropertyChanged("ID_ENVIO")
        End Set
    End Property 

    Private _ID_ENVIOOld As Int32
    Public Property ID_ENVIOOld() As Int32
        Get
            Return _ID_ENVIOOld
        End Get
        Set(ByVal Value As Int32)
            _ID_ENVIOOld = Value
        End Set
    End Property 

    Private _fkID_ENVIO As ENVIO
    Public Property fkID_ENVIO() As ENVIO
        Get
            Return _fkID_ENVIO
        End Get
        Set(ByVal Value As ENVIO)
            _fkID_ENVIO = Value
        End Set
    End Property 

    Private _BAGAZO_BRUTO As Decimal
    <Column(Name:="Bagazo bruto", Storage:="BAGAZO_BRUTO", DbType:="NUMERIC(20,6)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=6)> _
    Public Property BAGAZO_BRUTO() As Decimal
        Get
            Return _BAGAZO_BRUTO
        End Get
        Set(ByVal Value As Decimal)
            _BAGAZO_BRUTO = Value
            OnPropertyChanged("BAGAZO_BRUTO")
        End Set
    End Property 

    Private _BAGAZO_BRUTOOld As Decimal
    Public Property BAGAZO_BRUTOOld() As Decimal
        Get
            Return _BAGAZO_BRUTOOld
        End Get
        Set(ByVal Value As Decimal)
            _BAGAZO_BRUTOOld = Value
        End Set
    End Property 

    Private _BAGAZO_NETO As Decimal
    <Column(Name:="Bagazo neto", Storage:="BAGAZO_NETO", DbType:="NUMERIC(20,6)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=6)> _
    Public Property BAGAZO_NETO() As Decimal
        Get
            Return _BAGAZO_NETO
        End Get
        Set(ByVal Value As Decimal)
            _BAGAZO_NETO = Value
            OnPropertyChanged("BAGAZO_NETO")
        End Set
    End Property 

    Private _BAGAZO_NETOOld As Decimal
    Public Property BAGAZO_NETOOld() As Decimal
        Get
            Return _BAGAZO_NETOOld
        End Get
        Set(ByVal Value As Decimal)
            _BAGAZO_NETOOld = Value
        End Set
    End Property 

    Private _POL As Decimal
    <Column(Name:="Pol", Storage:="POL", DbType:="NUMERIC(20,6)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=6)> _
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

    Private _BRIX As Decimal
    <Column(Name:="Brix", Storage:="BRIX", DbType:="NUMERIC(20,6)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=6)> _
    Public Property BRIX() As Decimal
        Get
            Return _BRIX
        End Get
        Set(ByVal Value As Decimal)
            _BRIX = Value
            OnPropertyChanged("BRIX")
        End Set
    End Property 

    Private _BRIXOld As Decimal
    Public Property BRIXOld() As Decimal
        Get
            Return _BRIXOld
        End Get
        Set(ByVal Value As Decimal)
            _BRIXOld = Value
        End Set
    End Property 

    Private _FIBRA_CANA As Decimal
    <Column(Name:="Fibra cana", Storage:="FIBRA_CANA", DbType:="NUMERIC(20,6)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=6)> _
    Public Property FIBRA_CANA() As Decimal
        Get
            Return _FIBRA_CANA
        End Get
        Set(ByVal Value As Decimal)
            _FIBRA_CANA = Value
            OnPropertyChanged("FIBRA_CANA")
        End Set
    End Property 

    Private _FIBRA_CANAOld As Decimal
    Public Property FIBRA_CANAOld() As Decimal
        Get
            Return _FIBRA_CANAOld
        End Get
        Set(ByVal Value As Decimal)
            _FIBRA_CANAOld = Value
        End Set
    End Property 

    Private _HUMEDAD As Decimal
    <Column(Name:="Humedad", Storage:="HUMEDAD", DbType:="NUMERIC(20,6)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=6)> _
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

    Private _POL_JUGO As Decimal
    <Column(Name:="Pol jugo", Storage:="POL_JUGO", DbType:="NUMERIC(20,6)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=6)> _
    Public Property POL_JUGO() As Decimal
        Get
            Return _POL_JUGO
        End Get
        Set(ByVal Value As Decimal)
            _POL_JUGO = Value
            OnPropertyChanged("POL_JUGO")
        End Set
    End Property 

    Private _POL_JUGOOld As Decimal
    Public Property POL_JUGOOld() As Decimal
        Get
            Return _POL_JUGOOld
        End Get
        Set(ByVal Value As Decimal)
            _POL_JUGOOld = Value
        End Set
    End Property 

    Private _JUGO_CANA As Decimal
    <Column(Name:="Jugo cana", Storage:="JUGO_CANA", DbType:="NUMERIC(20,6)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=6)> _
    Public Property JUGO_CANA() As Decimal
        Get
            Return _JUGO_CANA
        End Get
        Set(ByVal Value As Decimal)
            _JUGO_CANA = Value
            OnPropertyChanged("JUGO_CANA")
        End Set
    End Property 

    Private _JUGO_CANAOld As Decimal
    Public Property JUGO_CANAOld() As Decimal
        Get
            Return _JUGO_CANAOld
        End Get
        Set(ByVal Value As Decimal)
            _JUGO_CANAOld = Value
        End Set
    End Property 

    Private _POL_CANA As Decimal
    <Column(Name:="Pol cana", Storage:="POL_CANA", DbType:="NUMERIC(20,6)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=6)> _
    Public Property POL_CANA() As Decimal
        Get
            Return _POL_CANA
        End Get
        Set(ByVal Value As Decimal)
            _POL_CANA = Value
            OnPropertyChanged("POL_CANA")
        End Set
    End Property 

    Private _POL_CANAOld As Decimal
    Public Property POL_CANAOld() As Decimal
        Get
            Return _POL_CANAOld
        End Get
        Set(ByVal Value As Decimal)
            _POL_CANAOld = Value
        End Set
    End Property 

    Private _PUREZA_JUGO As Decimal
    <Column(Name:="Pureza jugo", Storage:="PUREZA_JUGO", DbType:="NUMERIC(20,6)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=6)> _
    Public Property PUREZA_JUGO() As Decimal
        Get
            Return _PUREZA_JUGO
        End Get
        Set(ByVal Value As Decimal)
            _PUREZA_JUGO = Value
            OnPropertyChanged("PUREZA_JUGO")
        End Set
    End Property 

    Private _PUREZA_JUGOOld As Decimal
    Public Property PUREZA_JUGOOld() As Decimal
        Get
            Return _PUREZA_JUGOOld
        End Get
        Set(ByVal Value As Decimal)
            _PUREZA_JUGOOld = Value
        End Set
    End Property 

    Private _PUREZA_AZUCAR As Decimal
    <Column(Name:="Pureza azucar", Storage:="PUREZA_AZUCAR", DbType:="NUMERIC(20,6)", Id:=False), _
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

    Private _SJM As Decimal
    <Column(Name:="Sjm", Storage:="SJM", DbType:="NUMERIC(20,6)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=6)> _
    Public Property SJM() As Decimal
        Get
            Return _SJM
        End Get
        Set(ByVal Value As Decimal)
            _SJM = Value
            OnPropertyChanged("SJM")
        End Set
    End Property 

    Private _SJMOld As Decimal
    Public Property SJMOld() As Decimal
        Get
            Return _SJMOld
        End Get
        Set(ByVal Value As Decimal)
            _SJMOld = Value
        End Set
    End Property 

    Private _RENDIA_CALC1 As Decimal
    <Column(Name:="Rendia calc1", Storage:="RENDIA_CALC1", DbType:="NUMERIC(20,6)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=6)> _
    Public Property RENDIA_CALC1() As Decimal
        Get
            Return _RENDIA_CALC1
        End Get
        Set(ByVal Value As Decimal)
            _RENDIA_CALC1 = Value
            OnPropertyChanged("RENDIA_CALC1")
        End Set
    End Property 

    Private _RENDIA_CALC1Old As Decimal
    Public Property RENDIA_CALC1Old() As Decimal
        Get
            Return _RENDIA_CALC1Old
        End Get
        Set(ByVal Value As Decimal)
            _RENDIA_CALC1Old = Value
        End Set
    End Property 

    Private _RENDIA_CALC2 As Decimal
    <Column(Name:="Rendia calc2", Storage:="RENDIA_CALC2", DbType:="NUMERIC(20,6)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=6)> _
    Public Property RENDIA_CALC2() As Decimal
        Get
            Return _RENDIA_CALC2
        End Get
        Set(ByVal Value As Decimal)
            _RENDIA_CALC2 = Value
            OnPropertyChanged("RENDIA_CALC2")
        End Set
    End Property 

    Private _RENDIA_CALC2Old As Decimal
    Public Property RENDIA_CALC2Old() As Decimal
        Get
            Return _RENDIA_CALC2Old
        End Get
        Set(ByVal Value As Decimal)
            _RENDIA_CALC2Old = Value
        End Set
    End Property 

    Private _RENDIA_REAL As Decimal
    <Column(Name:="Rendia real", Storage:="RENDIA_REAL", DbType:="NUMERIC(20,6)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=6)> _
    Public Property RENDIA_REAL() As Decimal
        Get
            Return _RENDIA_REAL
        End Get
        Set(ByVal Value As Decimal)
            _RENDIA_REAL = Value
            OnPropertyChanged("RENDIA_REAL")
        End Set
    End Property 

    Private _RENDIA_REALOld As Decimal
    Public Property RENDIA_REALOld() As Decimal
        Get
            Return _RENDIA_REALOld
        End Get
        Set(ByVal Value As Decimal)
            _RENDIA_REALOld = Value
        End Set
    End Property 

    Private _RENCATORCENA_REAL As Decimal
    <Column(Name:="Rencatorcena real", Storage:="RENCATORCENA_REAL", DbType:="NUMERIC(20,6)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=6)> _
    Public Property RENCATORCENA_REAL() As Decimal
        Get
            Return _RENCATORCENA_REAL
        End Get
        Set(ByVal Value As Decimal)
            _RENCATORCENA_REAL = Value
            OnPropertyChanged("RENCATORCENA_REAL")
        End Set
    End Property 

    Private _RENCATORCENA_REALOld As Decimal
    Public Property RENCATORCENA_REALOld() As Decimal
        Get
            Return _RENCATORCENA_REALOld
        End Get
        Set(ByVal Value As Decimal)
            _RENCATORCENA_REALOld = Value
        End Set
    End Property 

    Private _AZUCAR_CALC1 As Decimal
    <Column(Name:="Azucar calc1", Storage:="AZUCAR_CALC1", DbType:="NUMERIC(20,6)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=6)> _
    Public Property AZUCAR_CALC1() As Decimal
        Get
            Return _AZUCAR_CALC1
        End Get
        Set(ByVal Value As Decimal)
            _AZUCAR_CALC1 = Value
            OnPropertyChanged("AZUCAR_CALC1")
        End Set
    End Property 

    Private _AZUCAR_CALC1Old As Decimal
    Public Property AZUCAR_CALC1Old() As Decimal
        Get
            Return _AZUCAR_CALC1Old
        End Get
        Set(ByVal Value As Decimal)
            _AZUCAR_CALC1Old = Value
        End Set
    End Property 

    Private _AZUCAR_CALC2 As Decimal
    <Column(Name:="Azucar calc2", Storage:="AZUCAR_CALC2", DbType:="NUMERIC(20,6)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=6)> _
    Public Property AZUCAR_CALC2() As Decimal
        Get
            Return _AZUCAR_CALC2
        End Get
        Set(ByVal Value As Decimal)
            _AZUCAR_CALC2 = Value
            OnPropertyChanged("AZUCAR_CALC2")
        End Set
    End Property 

    Private _AZUCAR_CALC2Old As Decimal
    Public Property AZUCAR_CALC2Old() As Decimal
        Get
            Return _AZUCAR_CALC2Old
        End Get
        Set(ByVal Value As Decimal)
            _AZUCAR_CALC2Old = Value
        End Set
    End Property 

    Private _AZUCAR_REAL As Decimal
    <Column(Name:="Azucar real", Storage:="AZUCAR_REAL", DbType:="NUMERIC(20,6)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=6)> _
    Public Property AZUCAR_REAL() As Decimal
        Get
            Return _AZUCAR_REAL
        End Get
        Set(ByVal Value As Decimal)
            _AZUCAR_REAL = Value
            OnPropertyChanged("AZUCAR_REAL")
        End Set
    End Property 

    Private _AZUCAR_REALOld As Decimal
    Public Property AZUCAR_REALOld() As Decimal
        Get
            Return _AZUCAR_REALOld
        End Get
        Set(ByVal Value As Decimal)
            _AZUCAR_REALOld = Value
        End Set
    End Property 

    Private _AZUCAR_CATORCENA_REAL As Decimal
    <Column(Name:="Azucar catorcena real", Storage:="AZUCAR_CATORCENA_REAL", DbType:="NUMERIC(20,6)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=6)> _
    Public Property AZUCAR_CATORCENA_REAL() As Decimal
        Get
            Return _AZUCAR_CATORCENA_REAL
        End Get
        Set(ByVal Value As Decimal)
            _AZUCAR_CATORCENA_REAL = Value
            OnPropertyChanged("AZUCAR_CATORCENA_REAL")
        End Set
    End Property 

    Private _AZUCAR_CATORCENA_REALOld As Decimal
    Public Property AZUCAR_CATORCENA_REALOld() As Decimal
        Get
            Return _AZUCAR_CATORCENA_REALOld
        End Get
        Set(ByVal Value As Decimal)
            _AZUCAR_CATORCENA_REALOld = Value
        End Set
    End Property 

    Private _PAGO_INI_CALC As Decimal
    <Column(Name:="Pago ini calc", Storage:="PAGO_INI_CALC", DbType:="NUMERIC(20,6)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=6)> _
    Public Property PAGO_INI_CALC() As Decimal
        Get
            Return _PAGO_INI_CALC
        End Get
        Set(ByVal Value As Decimal)
            _PAGO_INI_CALC = Value
            OnPropertyChanged("PAGO_INI_CALC")
        End Set
    End Property 

    Private _PAGO_INI_CALCOld As Decimal
    Public Property PAGO_INI_CALCOld() As Decimal
        Get
            Return _PAGO_INI_CALCOld
        End Get
        Set(ByVal Value As Decimal)
            _PAGO_INI_CALCOld = Value
        End Set
    End Property 

    Private _PAGO_INI_REAL As Decimal
    <Column(Name:="Pago ini real", Storage:="PAGO_INI_REAL", DbType:="NUMERIC(20,6)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=6)> _
    Public Property PAGO_INI_REAL() As Decimal
        Get
            Return _PAGO_INI_REAL
        End Get
        Set(ByVal Value As Decimal)
            _PAGO_INI_REAL = Value
            OnPropertyChanged("PAGO_INI_REAL")
        End Set
    End Property 

    Private _PAGO_INI_REALOld As Decimal
    Public Property PAGO_INI_REALOld() As Decimal
        Get
            Return _PAGO_INI_REALOld
        End Get
        Set(ByVal Value As Decimal)
            _PAGO_INI_REALOld = Value
        End Set
    End Property 

    Private _PAGO_CATORCENA_REAL As Decimal
    <Column(Name:="Pago catorcena real", Storage:="PAGO_CATORCENA_REAL", DbType:="NUMERIC(20,6)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=6)> _
    Public Property PAGO_CATORCENA_REAL() As Decimal
        Get
            Return _PAGO_CATORCENA_REAL
        End Get
        Set(ByVal Value As Decimal)
            _PAGO_CATORCENA_REAL = Value
            OnPropertyChanged("PAGO_CATORCENA_REAL")
        End Set
    End Property 

    Private _PAGO_CATORCENA_REALOld As Decimal
    Public Property PAGO_CATORCENA_REALOld() As Decimal
        Get
            Return _PAGO_CATORCENA_REALOld
        End Get
        Set(ByVal Value As Decimal)
            _PAGO_CATORCENA_REALOld = Value
        End Set
    End Property 

    Private _USUARIO_LEE_BAGAZO_BRUTO As String
    <Column(Name:="Usuario lee bagazo bruto", Storage:="USUARIO_LEE_BAGAZO_BRUTO", DbType:="VARCHAR(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
    Public Property USUARIO_LEE_BAGAZO_BRUTO() As String
        Get
            Return _USUARIO_LEE_BAGAZO_BRUTO
        End Get
        Set(ByVal Value As String)
            _USUARIO_LEE_BAGAZO_BRUTO = Value
            OnPropertyChanged("USUARIO_LEE_BAGAZO_BRUTO")
        End Set
    End Property 

    Private _USUARIO_LEE_BAGAZO_BRUTOOld As String
    Public Property USUARIO_LEE_BAGAZO_BRUTOOld() As String
        Get
            Return _USUARIO_LEE_BAGAZO_BRUTOOld
        End Get
        Set(ByVal Value As String)
            _USUARIO_LEE_BAGAZO_BRUTOOld = Value
        End Set
    End Property 

    Private _FECHA_LEE_BAGAZO_BRUTO As DateTime
    <Column(Name:="Fecha lee bagazo bruto", Storage:="FECHA_LEE_BAGAZO_BRUTO", DbType:="DATETIME", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_LEE_BAGAZO_BRUTO() As DateTime
        Get
            Return _FECHA_LEE_BAGAZO_BRUTO
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_LEE_BAGAZO_BRUTO = Value
            OnPropertyChanged("FECHA_LEE_BAGAZO_BRUTO")
        End Set
    End Property 

    Private _FECHA_LEE_BAGAZO_BRUTOOld As DateTime
    Public Property FECHA_LEE_BAGAZO_BRUTOOld() As DateTime
        Get
            Return _FECHA_LEE_BAGAZO_BRUTOOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_LEE_BAGAZO_BRUTOOld = Value
        End Set
    End Property 

    Private _USUARIO_LEE_BAGAZO_TARA As String
    <Column(Name:="Usuario lee bagazo tara", Storage:="USUARIO_LEE_BAGAZO_TARA", DbType:="VARCHAR(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
    Public Property USUARIO_LEE_BAGAZO_TARA() As String
        Get
            Return _USUARIO_LEE_BAGAZO_TARA
        End Get
        Set(ByVal Value As String)
            _USUARIO_LEE_BAGAZO_TARA = Value
            OnPropertyChanged("USUARIO_LEE_BAGAZO_TARA")
        End Set
    End Property 

    Private _USUARIO_LEE_BAGAZO_TARAOld As String
    Public Property USUARIO_LEE_BAGAZO_TARAOld() As String
        Get
            Return _USUARIO_LEE_BAGAZO_TARAOld
        End Get
        Set(ByVal Value As String)
            _USUARIO_LEE_BAGAZO_TARAOld = Value
        End Set
    End Property 

    Private _FECHA_LEE_BAGAZO_TARA As DateTime
    <Column(Name:="Fecha lee bagazo tara", Storage:="FECHA_LEE_BAGAZO_TARA", DbType:="DATETIME", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_LEE_BAGAZO_TARA() As DateTime
        Get
            Return _FECHA_LEE_BAGAZO_TARA
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_LEE_BAGAZO_TARA = Value
            OnPropertyChanged("FECHA_LEE_BAGAZO_TARA")
        End Set
    End Property 

    Private _FECHA_LEE_BAGAZO_TARAOld As DateTime
    Public Property FECHA_LEE_BAGAZO_TARAOld() As DateTime
        Get
            Return _FECHA_LEE_BAGAZO_TARAOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_LEE_BAGAZO_TARAOld = Value
        End Set
    End Property 

    Private _USUARIO_LEE_POL As String
    <Column(Name:="Usuario lee pol", Storage:="USUARIO_LEE_POL", DbType:="VARCHAR(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
    Public Property USUARIO_LEE_POL() As String
        Get
            Return _USUARIO_LEE_POL
        End Get
        Set(ByVal Value As String)
            _USUARIO_LEE_POL = Value
            OnPropertyChanged("USUARIO_LEE_POL")
        End Set
    End Property 

    Private _USUARIO_LEE_POLOld As String
    Public Property USUARIO_LEE_POLOld() As String
        Get
            Return _USUARIO_LEE_POLOld
        End Get
        Set(ByVal Value As String)
            _USUARIO_LEE_POLOld = Value
        End Set
    End Property 

    Private _FECHA_LEE_POL As DateTime
    <Column(Name:="Fecha lee pol", Storage:="FECHA_LEE_POL", DbType:="DATETIME", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_LEE_POL() As DateTime
        Get
            Return _FECHA_LEE_POL
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_LEE_POL = Value
            OnPropertyChanged("FECHA_LEE_POL")
        End Set
    End Property 

    Private _FECHA_LEE_POLOld As DateTime
    Public Property FECHA_LEE_POLOld() As DateTime
        Get
            Return _FECHA_LEE_POLOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_LEE_POLOld = Value
        End Set
    End Property 

    Private _USUARIO_LEE_BRIX As String
    <Column(Name:="Usuario lee brix", Storage:="USUARIO_LEE_BRIX", DbType:="VARCHAR(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
    Public Property USUARIO_LEE_BRIX() As String
        Get
            Return _USUARIO_LEE_BRIX
        End Get
        Set(ByVal Value As String)
            _USUARIO_LEE_BRIX = Value
            OnPropertyChanged("USUARIO_LEE_BRIX")
        End Set
    End Property 

    Private _USUARIO_LEE_BRIXOld As String
    Public Property USUARIO_LEE_BRIXOld() As String
        Get
            Return _USUARIO_LEE_BRIXOld
        End Get
        Set(ByVal Value As String)
            _USUARIO_LEE_BRIXOld = Value
        End Set
    End Property 

    Private _FECHA_LEE_BRIX As DateTime
    <Column(Name:="Fecha lee brix", Storage:="FECHA_LEE_BRIX", DbType:="DATETIME", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_LEE_BRIX() As DateTime
        Get
            Return _FECHA_LEE_BRIX
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_LEE_BRIX = Value
            OnPropertyChanged("FECHA_LEE_BRIX")
        End Set
    End Property 

    Private _FECHA_LEE_BRIXOld As DateTime
    Public Property FECHA_LEE_BRIXOld() As DateTime
        Get
            Return _FECHA_LEE_BRIXOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_LEE_BRIXOld = Value
        End Set
    End Property 

    Private _POL_LECTURA As Decimal
    <Column(Name:="Pol lectura", Storage:="POL_LECTURA", DbType:="NUMERIC(20,6)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=6)> _
    Public Property POL_LECTURA() As Decimal
        Get
            Return _POL_LECTURA
        End Get
        Set(ByVal Value As Decimal)
            _POL_LECTURA = Value
            OnPropertyChanged("POL_LECTURA")
        End Set
    End Property 

    Private _POL_LECTURAOld As Decimal
    Public Property POL_LECTURAOld() As Decimal
        Get
            Return _POL_LECTURAOld
        End Get
        Set(ByVal Value As Decimal)
            _POL_LECTURAOld = Value
        End Set
    End Property 

    Private _PH As Decimal
    <Column(Name:="Ph", Storage:="PH", DbType:="NUMERIC(20,4)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=4)> _
    Public Property PH() As Decimal
        Get
            Return _PH
        End Get
        Set(ByVal Value As Decimal)
            _PH = Value
            OnPropertyChanged("PH")
        End Set
    End Property 

    Private _PHOld As Decimal
    Public Property PHOld() As Decimal
        Get
            Return _PHOld
        End Get
        Set(ByVal Value As Decimal)
            _PHOld = Value
        End Set
    End Property 

    Private _AZUCAR_REDUCTORES As Decimal
    <Column(Name:="Azucar reductores", Storage:="AZUCAR_REDUCTORES", DbType:="NUMERIC(20,6)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=6)> _
    Public Property AZUCAR_REDUCTORES() As Decimal
        Get
            Return _AZUCAR_REDUCTORES
        End Get
        Set(ByVal Value As Decimal)
            _AZUCAR_REDUCTORES = Value
            OnPropertyChanged("AZUCAR_REDUCTORES")
        End Set
    End Property 

    Private _AZUCAR_REDUCTORESOld As Decimal
    Public Property AZUCAR_REDUCTORESOld() As Decimal
        Get
            Return _AZUCAR_REDUCTORESOld
        End Get
        Set(ByVal Value As Decimal)
            _AZUCAR_REDUCTORESOld = Value
        End Set
    End Property 

    Private _ES_ANOMALO As Boolean
    <Column(Name:="Es anomalo", Storage:="ES_ANOMALO", DbType:="BIT", Id:=False), _
     DataObjectField(False, False, True, 1)> _
    Public Property ES_ANOMALO() As Boolean
        Get
            Return _ES_ANOMALO
        End Get
        Set(ByVal Value As Boolean)
            _ES_ANOMALO = Value
            OnPropertyChanged("ES_ANOMALO")
        End Set
    End Property 

    Private _ES_ANOMALOOld As Boolean
    Public Property ES_ANOMALOOld() As Boolean
        Get
            Return _ES_ANOMALOOld
        End Get
        Set(ByVal Value As Boolean)
            _ES_ANOMALOOld = Value
        End Set
    End Property 

    Private _RENDIA85_ANOMALO As Decimal
    <Column(Name:="Rendia85 anomalo", Storage:="RENDIA85_ANOMALO", DbType:="NUMERIC(20,6)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=6)> _
    Public Property RENDIA85_ANOMALO() As Decimal
        Get
            Return _RENDIA85_ANOMALO
        End Get
        Set(ByVal Value As Decimal)
            _RENDIA85_ANOMALO = Value
            OnPropertyChanged("RENDIA85_ANOMALO")
        End Set
    End Property 

    Private _RENDIA85_ANOMALOOld As Decimal
    Public Property RENDIA85_ANOMALOOld() As Decimal
        Get
            Return _RENDIA85_ANOMALOOld
        End Get
        Set(ByVal Value As Decimal)
            _RENDIA85_ANOMALOOld = Value
        End Set
    End Property 

    Private _APLICAR_REND_DIA As Boolean
    <Column(Name:="Aplicar rend dia", Storage:="APLICAR_REND_DIA", DbType:="BIT", Id:=False), _
     DataObjectField(False, False, True, 1)> _
    Public Property APLICAR_REND_DIA() As Boolean
        Get
            Return _APLICAR_REND_DIA
        End Get
        Set(ByVal Value As Boolean)
            _APLICAR_REND_DIA = Value
            OnPropertyChanged("APLICAR_REND_DIA")
        End Set
    End Property 

    Private _APLICAR_REND_DIAOld As Boolean
    Public Property APLICAR_REND_DIAOld() As Boolean
        Get
            Return _APLICAR_REND_DIAOld
        End Get
        Set(ByVal Value As Boolean)
            _APLICAR_REND_DIAOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
