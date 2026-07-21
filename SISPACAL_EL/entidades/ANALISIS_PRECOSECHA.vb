''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.ANALISIS_PRECOSECHA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row ANALISIS_PRECOSECHA en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	24/09/2014	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="ANALISIS_PRECOSECHA")> Public Class ANALISIS_PRECOSECHA
    Inherits entidadBase

#Region " Metodos Generador "


    Public Sub New(aID_ANALISIS_PRE As Int32, aACCESLOTE As String, aID_ZAFRA As Int32, aNO_ANALISIS As Int32, aFECHA_MUESTRA As DateTime, aNO_MUESTRA As Int32, aAREA_MUESTRA As Decimal, aBAGAZO_BRUTO As Decimal, aBAGAZO_NETO As Decimal, aPOL As Decimal, aBRIX As Decimal, aFIBRA_CANA As Decimal, aHUMEDAD As Decimal, aPOL_JUGO As Decimal, aJUGO_CANA As Decimal, aPOL_CANA As Decimal, aPUREZA_JUGO As Decimal, aPUREZA_AZUCAR As Decimal, aSJM As Decimal, aRENDIA_CALC1 As Decimal, aRENDIA_CALC2 As Decimal, aPOL_LECTURA As Decimal, aPH As Decimal, aAZUCAR_REDUCTORES As Decimal, aCANT_JUGO_ML As Decimal, aVOL_TITULANTE As Decimal, aOBSERVACION As String, aALMIDON_JUGO As Decimal, aACIDEZ_JUGO As Decimal, aABSORVANCIA As Decimal, aDEXTRANA As Decimal, aUSUARIO_LEE_BAGAZO_BRUTO As String, aFECHA_LEE_BAGAZO_BRUTO As DateTime, aUSUARIO_LEE_BAGAZO_TARA As String, aFECHA_LEE_BAGAZO_TARA As DateTime, aUSUARIO_LEE_POL As String, aFECHA_LEE_POL As DateTime, aUSUARIO_LEE_BRIX As String, aFECHA_LEE_BRIX As DateTime, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_CT As DateTime, aBRIX_DILU As Decimal, aABSORBANCIA_ALMIDON As Decimal, aID_SUBLOTES As Integer)
        Me._ID_ANALISIS_PRE = aID_ANALISIS_PRE
        Me._ACCESLOTE = aACCESLOTE
        Me._ID_ZAFRA = aID_ZAFRA
        Me._NO_ANALISIS = aNO_ANALISIS
        Me._FECHA_MUESTRA = aFECHA_MUESTRA
        Me._NO_MUESTRA = aNO_MUESTRA
        Me._AREA_MUESTRA = aAREA_MUESTRA
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
        Me._POL_LECTURA = aPOL_LECTURA
        Me._PH = aPH
        Me._AZUCAR_REDUCTORES = aAZUCAR_REDUCTORES
        Me._CANT_JUGO_ML = aCANT_JUGO_ML
        Me._VOL_TITULANTE = aVOL_TITULANTE
        Me._OBSERVACION = aOBSERVACION
        Me._ALMIDON_JUGO = aALMIDON_JUGO
        Me._ACIDEZ_JUGO = aACIDEZ_JUGO
        Me._ABSORVANCIA = aABSORVANCIA
        Me._DEXTRANA = aDEXTRANA
        Me._USUARIO_LEE_BAGAZO_BRUTO = aUSUARIO_LEE_BAGAZO_BRUTO
        Me._FECHA_LEE_BAGAZO_BRUTO = aFECHA_LEE_BAGAZO_BRUTO
        Me._USUARIO_LEE_BAGAZO_TARA = aUSUARIO_LEE_BAGAZO_TARA
        Me._FECHA_LEE_BAGAZO_TARA = aFECHA_LEE_BAGAZO_TARA
        Me._USUARIO_LEE_POL = aUSUARIO_LEE_POL
        Me._FECHA_LEE_POL = aFECHA_LEE_POL
        Me._USUARIO_LEE_BRIX = aUSUARIO_LEE_BRIX
        Me._FECHA_LEE_BRIX = aFECHA_LEE_BRIX
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_CT = aFECHA_CT
        Me._BRIX_DILU = aBRIX_DILU
        Me._ABSORBANCIA_ALMIDON = aABSORBANCIA_ALMIDON
        Me._ID_SUBLOTES = aID_SUBLOTES
    End Sub

#Region " Properties "

    Private _ID_ANALISIS_PRE As Int32
    <Column(Name:="Id analisis pre", Storage:="ID_ANALISIS_PRE", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_ANALISIS_PRE() As Int32
        Get
            Return _ID_ANALISIS_PRE
        End Get
        Set(ByVal Value As Int32)
            _ID_ANALISIS_PRE = Value
            OnPropertyChanged("ID_ANALISIS_PRE")
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

    Private _NO_ANALISIS As Int32
    <Column(Name:="No analisis", Storage:="NO_ANALISIS", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property NO_ANALISIS() As Int32
        Get
            Return _NO_ANALISIS
        End Get
        Set(ByVal Value As Int32)
            _NO_ANALISIS = Value
            OnPropertyChanged("NO_ANALISIS")
        End Set
    End Property 

    Private _NO_ANALISISOld As Int32
    Public Property NO_ANALISISOld() As Int32
        Get
            Return _NO_ANALISISOld
        End Get
        Set(ByVal Value As Int32)
            _NO_ANALISISOld = Value
        End Set
    End Property 

    Private _FECHA_MUESTRA As DateTime
    <Column(Name:="Fecha muestra", Storage:="FECHA_MUESTRA", DbType:="DATETIME NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
    Public Property FECHA_MUESTRA() As DateTime
        Get
            Return _FECHA_MUESTRA
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_MUESTRA = Value
            OnPropertyChanged("FECHA_MUESTRA")
        End Set
    End Property 

    Private _FECHA_MUESTRAOld As DateTime
    Public Property FECHA_MUESTRAOld() As DateTime
        Get
            Return _FECHA_MUESTRAOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_MUESTRAOld = Value
        End Set
    End Property 

    Private _NO_MUESTRA As Int32
    <Column(Name:="No muestra", Storage:="NO_MUESTRA", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property NO_MUESTRA() As Int32
        Get
            Return _NO_MUESTRA
        End Get
        Set(ByVal Value As Int32)
            _NO_MUESTRA = Value
            OnPropertyChanged("NO_MUESTRA")
        End Set
    End Property 

    Private _NO_MUESTRAOld As Int32
    Public Property NO_MUESTRAOld() As Int32
        Get
            Return _NO_MUESTRAOld
        End Get
        Set(ByVal Value As Int32)
            _NO_MUESTRAOld = Value
        End Set
    End Property 

    Private _AREA_MUESTRA As Decimal
    <Column(Name:="Area muestra", Storage:="AREA_MUESTRA", DbType:="NUMERIC(10,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=2)> _
    Public Property AREA_MUESTRA() As Decimal
        Get
            Return _AREA_MUESTRA
        End Get
        Set(ByVal Value As Decimal)
            _AREA_MUESTRA = Value
            OnPropertyChanged("AREA_MUESTRA")
        End Set
    End Property 

    Private _AREA_MUESTRAOld As Decimal
    Public Property AREA_MUESTRAOld() As Decimal
        Get
            Return _AREA_MUESTRAOld
        End Get
        Set(ByVal Value As Decimal)
            _AREA_MUESTRAOld = Value
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

    Private _CANT_JUGO_ML As Decimal
    <Column(Name:="Cant jugo ml", Storage:="CANT_JUGO_ML", DbType:="NUMERIC(20,6)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=6)> _
    Public Property CANT_JUGO_ML() As Decimal
        Get
            Return _CANT_JUGO_ML
        End Get
        Set(ByVal Value As Decimal)
            _CANT_JUGO_ML = Value
            OnPropertyChanged("CANT_JUGO_ML")
        End Set
    End Property 

    Private _CANT_JUGO_MLOld As Decimal
    Public Property CANT_JUGO_MLOld() As Decimal
        Get
            Return _CANT_JUGO_MLOld
        End Get
        Set(ByVal Value As Decimal)
            _CANT_JUGO_MLOld = Value
        End Set
    End Property 

    Private _VOL_TITULANTE As Decimal
    <Column(Name:="Vol titulante", Storage:="VOL_TITULANTE", DbType:="NUMERIC(20,6)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=6)> _
    Public Property VOL_TITULANTE() As Decimal
        Get
            Return _VOL_TITULANTE
        End Get
        Set(ByVal Value As Decimal)
            _VOL_TITULANTE = Value
            OnPropertyChanged("VOL_TITULANTE")
        End Set
    End Property 

    Private _VOL_TITULANTEOld As Decimal
    Public Property VOL_TITULANTEOld() As Decimal
        Get
            Return _VOL_TITULANTEOld
        End Get
        Set(ByVal Value As Decimal)
            _VOL_TITULANTEOld = Value
        End Set
    End Property 

    Private _OBSERVACION As String
    <Column(Name:="Observacion", Storage:="OBSERVACION", DbType:="VARCHAR(3000)", Id:=False), _
     DataObjectField(False, False, True, 3000)> _
    Public Property OBSERVACION() As String
        Get
            Return _OBSERVACION
        End Get
        Set(ByVal Value As String)
            _OBSERVACION = Value
            OnPropertyChanged("OBSERVACION")
        End Set
    End Property 

    Private _OBSERVACIONOld As String
    Public Property OBSERVACIONOld() As String
        Get
            Return _OBSERVACIONOld
        End Get
        Set(ByVal Value As String)
            _OBSERVACIONOld = Value
        End Set
    End Property 

    Private _ALMIDON_JUGO As Decimal
    <Column(Name:="Almidon jugo", Storage:="ALMIDON_JUGO", DbType:="NUMERIC(20,6)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=6)> _
    Public Property ALMIDON_JUGO() As Decimal
        Get
            Return _ALMIDON_JUGO
        End Get
        Set(ByVal Value As Decimal)
            _ALMIDON_JUGO = Value
            OnPropertyChanged("ALMIDON_JUGO")
        End Set
    End Property 

    Private _ALMIDON_JUGOOld As Decimal
    Public Property ALMIDON_JUGOOld() As Decimal
        Get
            Return _ALMIDON_JUGOOld
        End Get
        Set(ByVal Value As Decimal)
            _ALMIDON_JUGOOld = Value
        End Set
    End Property 

    Private _ACIDEZ_JUGO As Decimal
    <Column(Name:="Acidez jugo", Storage:="ACIDEZ_JUGO", DbType:="NUMERIC(20,6)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=6)> _
    Public Property ACIDEZ_JUGO() As Decimal
        Get
            Return _ACIDEZ_JUGO
        End Get
        Set(ByVal Value As Decimal)
            _ACIDEZ_JUGO = Value
            OnPropertyChanged("ACIDEZ_JUGO")
        End Set
    End Property 

    Private _ACIDEZ_JUGOOld As Decimal
    Public Property ACIDEZ_JUGOOld() As Decimal
        Get
            Return _ACIDEZ_JUGOOld
        End Get
        Set(ByVal Value As Decimal)
            _ACIDEZ_JUGOOld = Value
        End Set
    End Property 

    Private _ABSORVANCIA As Decimal
    <Column(Name:="Absorvancia", Storage:="ABSORVANCIA", DbType:="NUMERIC(20,4)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=4)> _
    Public Property ABSORVANCIA() As Decimal
        Get
            Return _ABSORVANCIA
        End Get
        Set(ByVal Value As Decimal)
            _ABSORVANCIA = Value
            OnPropertyChanged("ABSORVANCIA")
        End Set
    End Property 

    Private _ABSORVANCIAOld As Decimal
    Public Property ABSORVANCIAOld() As Decimal
        Get
            Return _ABSORVANCIAOld
        End Get
        Set(ByVal Value As Decimal)
            _ABSORVANCIAOld = Value
        End Set
    End Property 

    Private _DEXTRANA As Decimal
    <Column(Name:="Dextrana", Storage:="DEXTRANA", DbType:="NUMERIC(20,4)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=4)> _
    Public Property DEXTRANA() As Decimal
        Get
            Return _DEXTRANA
        End Get
        Set(ByVal Value As Decimal)
            _DEXTRANA = Value
            OnPropertyChanged("DEXTRANA")
        End Set
    End Property 

    Private _DEXTRANAOld As Decimal
    Public Property DEXTRANAOld() As Decimal
        Get
            Return _DEXTRANAOld
        End Get
        Set(ByVal Value As Decimal)
            _DEXTRANAOld = Value
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

    Private _BRIX_DILU As Decimal
    <Column(Name:="Brix Dilu", Storage:="BRIX_DILU", DbType:="NUMERIC(20,4)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=8, Scale:=2)> _
    Public Property BRIX_DILU() As Decimal
        Get
            Return _BRIX_DILU
        End Get
        Set(ByVal Value As Decimal)
            _BRIX_DILU = Value
            OnPropertyChanged("BRIX_DILU")
        End Set
    End Property

    Private _BRIX_DILUOld As Decimal
    Public Property BRIX_DILUOld() As Decimal
        Get
            Return _BRIX_DILUOld
        End Get
        Set(ByVal Value As Decimal)
            _BRIX_DILUOld = Value
        End Set
    End Property


    Private _ABSORBANCIA_ALMIDON As Decimal
    <Column(Name:="Absorbancia Almidon", Storage:="ABSORBANCIA_ALMIDON", DbType:="NUMERIC(20,4)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=8, Scale:=3)> _
    Public Property ABSORBANCIA_ALMIDON() As Decimal
        Get
            Return _ABSORBANCIA_ALMIDON
        End Get
        Set(ByVal Value As Decimal)
            _ABSORBANCIA_ALMIDON = Value
            OnPropertyChanged("ABSORBANCIA_ALMIDON")
        End Set
    End Property

    Private _ABSORBANCIA_ALMIDONOld As Decimal
    Public Property ABSORBANCIA_ALMIDONOld() As Decimal
        Get
            Return _ABSORBANCIA_ALMIDONOld
        End Get
        Set(ByVal Value As Decimal)
            _ABSORBANCIA_ALMIDONOld = Value
        End Set
    End Property


    Private _ID_SUBLOTES As Int32
    <Column(Name:="Id SUBLOTES", Storage:="ID_SUBLOTES", DBType:="INT NOT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property ID_SUBLOTES() As Int32
        Get
            Return _ID_SUBLOTES
        End Get
        Set(ByVal Value As Int32)
            _ID_SUBLOTES = Value
            OnPropertyChanged("ID_SUBLOTES")
        End Set
    End Property

    Private _ID_SUBLOTESOld As Int32
    Public Property ID_SUBLOTESOld() As Int32
        Get
            Return _ID_SUBLOTESOld
        End Get
        Set(ByVal Value As Int32)
            _ID_SUBLOTESOld = Value
        End Set
    End Property

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
