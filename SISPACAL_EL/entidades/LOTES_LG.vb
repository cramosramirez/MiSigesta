''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.LOTES_LG
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row LOTES_LG en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	10/08/2020	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="LOTES_LG")> Public Class LOTES_LG
    Inherits entidadBase

#Region " Metodos Generador "



    Public Sub New(aACCESLOTE As String, aANIOZAFRA As String, aCODIPROVEEDOR As String, aCODILOTE As String, aCODIAGRON As String, aCODIVARIEDA As String, aCODIUBICACION As String, aCODICONTRATO As String, aNOMBLOTE As String, aAREA As Decimal, aTONELADAS As Decimal, aTONEL_TC As Decimal, aZONA As String, aEDAD_LOTE As Decimal, aUSER_CREA As String, aFECHA_CREA As DateTime, aUSER_ACT As String, aFECHA_ACT As DateTime, aID_MAESTRO As Int32, aTIPO_DERECHO As Int32, aSUB_ZONA As String, aID_LOTE_TRASPASO As Int32, aAREA_CANA As Decimal, aRIESGO_PIEDRA As Boolean, aREPARA_ACCESO As Boolean, aSIN_ACCESO_PROPIO As Boolean)
        Me._ACCESLOTE = aACCESLOTE
        Me._ANIOZAFRA = aANIOZAFRA
        Me._CODIPROVEEDOR = aCODIPROVEEDOR
        Me._CODILOTE = aCODILOTE
        Me._CODIAGRON = aCODIAGRON
        Me._CODIVARIEDA = aCODIVARIEDA
        Me._CODIUBICACION = aCODIUBICACION
        Me._CODICONTRATO = aCODICONTRATO
        Me._NOMBLOTE = aNOMBLOTE
        Me._AREA = aAREA
        Me._TONELADAS = aTONELADAS
        Me._TONEL_TC = aTONEL_TC
        Me._ZONA = aZONA
        Me._EDAD_LOTE = aEDAD_LOTE
        Me._USER_CREA = aUSER_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USER_ACT = aUSER_ACT
        Me._FECHA_ACT = aFECHA_ACT
        Me._ID_MAESTRO = aID_MAESTRO
        Me._TIPO_DERECHO = aTIPO_DERECHO
        Me._SUB_ZONA = aSUB_ZONA
        Me._ID_LOTE_TRASPASO = aID_LOTE_TRASPASO
        Me._AREA_CANA = aAREA_CANA
        Me._RIESGO_PIEDRA = aRIESGO_PIEDRA
        Me._REPARA_ACCESO = aREPARA_ACCESO
        Me._SIN_ACCESO_PROPIO = aSIN_ACCESO_PROPIO
    End Sub

#Region " Properties "

    Private _ACCESLOTE As String
    <Column(Name:="Acceslote", Storage:="ACCESLOTE", DbType:="CHAR(21) NOT NULL", Id:=True), _
     DataObjectField(True, False, False, 21)> _
    Public Property ACCESLOTE() As String
        Get
            Return _ACCESLOTE
        End Get
        Set(ByVal Value As String)
            _ACCESLOTE = Value
            OnPropertyChanged("ACCESLOTE")
        End Set
    End Property 

    Private _ANIOZAFRA As String
    <Column(Name:="Aniozafra", Storage:="ANIOZAFRA", DbType:="CHAR(9)", Id:=False), _
     DataObjectField(False, False, True, 9)> _
    Public Property ANIOZAFRA() As String
        Get
            Return _ANIOZAFRA
        End Get
        Set(ByVal Value As String)
            _ANIOZAFRA = Value
            OnPropertyChanged("ANIOZAFRA")
        End Set
    End Property 

    Private _ANIOZAFRAOld As String
    Public Property ANIOZAFRAOld() As String
        Get
            Return _ANIOZAFRAOld
        End Get
        Set(ByVal Value As String)
            _ANIOZAFRAOld = Value
        End Set
    End Property


    Private _fkCODIPROVEEDOR As PROVEEDOR
    Public Property fkCODIPROVEEDOR() As PROVEEDOR
        Get
            Return _fkCODIPROVEEDOR
        End Get
        Set(ByVal Value As PROVEEDOR)
            _fkCODIPROVEEDOR = Value
        End Set
    End Property 

    Private _CODILOTE As String
    <Column(Name:="Codilote", Storage:="CODILOTE", DbType:="CHAR(5)", Id:=False), _
     DataObjectField(False, False, True, 5)> _
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

    Private _CODIAGRON As String
    <Column(Name:="Codiagron", Storage:="CODIAGRON", DbType:="CHAR(8)", Id:=False), _
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

    Private _fkCODIAGRON As AGRONOMO
    Public Property fkCODIAGRON() As AGRONOMO
        Get
            Return _fkCODIAGRON
        End Get
        Set(ByVal Value As AGRONOMO)
            _fkCODIAGRON = Value
        End Set
    End Property 

    Private _CODIVARIEDA As String
    <Column(Name:="Codivarieda", Storage:="CODIVARIEDA", DbType:="CHAR(3)", Id:=False), _
     DataObjectField(False, False, True, 3)> _
    Public Property CODIVARIEDA() As String
        Get
            Return _CODIVARIEDA
        End Get
        Set(ByVal Value As String)
            _CODIVARIEDA = Value
            OnPropertyChanged("CODIVARIEDA")
        End Set
    End Property 

    Private _CODIVARIEDAOld As String
    Public Property CODIVARIEDAOld() As String
        Get
            Return _CODIVARIEDAOld
        End Get
        Set(ByVal Value As String)
            _CODIVARIEDAOld = Value
        End Set
    End Property 

    Private _fkCODIVARIEDA As VARIEDAD
    Public Property fkCODIVARIEDA() As VARIEDAD
        Get
            Return _fkCODIVARIEDA
        End Get
        Set(ByVal Value As VARIEDAD)
            _fkCODIVARIEDA = Value
        End Set
    End Property 

    Private _CODIUBICACION As String
    <Column(Name:="Codiubicacion", Storage:="CODIUBICACION", DbType:="CHAR(6)", Id:=False), _
     DataObjectField(False, False, True, 6)> _
    Public Property CODIUBICACION() As String
        Get
            Return _CODIUBICACION
        End Get
        Set(ByVal Value As String)
            _CODIUBICACION = Value
            OnPropertyChanged("CODIUBICACION")
        End Set
    End Property 

    Private _CODIUBICACIONOld As String
    Public Property CODIUBICACIONOld() As String
        Get
            Return _CODIUBICACIONOld
        End Get
        Set(ByVal Value As String)
            _CODIUBICACIONOld = Value
        End Set
    End Property 

    Private _fkCODIUBICACION As UBICACION
    Public Property fkCODIUBICACION() As UBICACION
        Get
            Return _fkCODIUBICACION
        End Get
        Set(ByVal Value As UBICACION)
            _fkCODIUBICACION = Value
        End Set
    End Property 

    Private _CODICONTRATO As String
    <Column(Name:="Codicontrato", Storage:="CODICONTRATO", DbType:="CHAR(13)", Id:=False), _
     DataObjectField(False, False, True, 13)> _
    Public Property CODICONTRATO() As String
        Get
            Return _CODICONTRATO
        End Get
        Set(ByVal Value As String)
            _CODICONTRATO = Value
            OnPropertyChanged("CODICONTRATO")
        End Set
    End Property 

    Private _CODICONTRATOOld As String
    Public Property CODICONTRATOOld() As String
        Get
            Return _CODICONTRATOOld
        End Get
        Set(ByVal Value As String)
            _CODICONTRATOOld = Value
        End Set
    End Property 

    Private _fkCODICONTRATO As CONTRATO_LG
    Public Property fkCODICONTRATO() As CONTRATO_LG
        Get
            Return _fkCODICONTRATO
        End Get
        Set(ByVal Value As CONTRATO_LG)
            _fkCODICONTRATO = Value
        End Set
    End Property 

    Private _NOMBLOTE As String
    <Column(Name:="Nomblote", Storage:="NOMBLOTE", DbType:="CHAR(60)", Id:=False), _
     DataObjectField(False, False, True, 60)> _
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

    Private _AREA As Decimal
    <Column(Name:="Area", Storage:="AREA", DbType:="NUMERIC(10,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=2)> _
    Public Property AREA() As Decimal
        Get
            Return _AREA
        End Get
        Set(ByVal Value As Decimal)
            _AREA = Value
            OnPropertyChanged("AREA")
        End Set
    End Property 

    Private _AREAOld As Decimal
    Public Property AREAOld() As Decimal
        Get
            Return _AREAOld
        End Get
        Set(ByVal Value As Decimal)
            _AREAOld = Value
        End Set
    End Property 

    Private _TONELADAS As Decimal
    <Column(Name:="Toneladas", Storage:="TONELADAS", DbType:="NUMERIC(10,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=2)> _
    Public Property TONELADAS() As Decimal
        Get
            Return _TONELADAS
        End Get
        Set(ByVal Value As Decimal)
            _TONELADAS = Value
            OnPropertyChanged("TONELADAS")
        End Set
    End Property 

    Private _TONELADASOld As Decimal
    Public Property TONELADASOld() As Decimal
        Get
            Return _TONELADASOld
        End Get
        Set(ByVal Value As Decimal)
            _TONELADASOld = Value
        End Set
    End Property 

    Private _TONEL_TC As Decimal
    <Column(Name:="Tonel tc", Storage:="TONEL_TC", DbType:="NUMERIC(10,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=2)> _
    Public Property TONEL_TC() As Decimal
        Get
            Return _TONEL_TC
        End Get
        Set(ByVal Value As Decimal)
            _TONEL_TC = Value
            OnPropertyChanged("TONEL_TC")
        End Set
    End Property 

    Private _TONEL_TCOld As Decimal
    Public Property TONEL_TCOld() As Decimal
        Get
            Return _TONEL_TCOld
        End Get
        Set(ByVal Value As Decimal)
            _TONEL_TCOld = Value
        End Set
    End Property 

    Private _ZONA As String
    <Column(Name:="Zona", Storage:="ZONA", DbType:="CHAR(2)", Id:=False), _
     DataObjectField(False, False, True, 2)> _
    Public Property ZONA() As String
        Get
            Return _ZONA
        End Get
        Set(ByVal Value As String)
            _ZONA = Value
            OnPropertyChanged("ZONA")
        End Set
    End Property 

    Private _ZONAOld As String
    Public Property ZONAOld() As String
        Get
            Return _ZONAOld
        End Get
        Set(ByVal Value As String)
            _ZONAOld = Value
        End Set
    End Property 

    Private _EDAD_LOTE As Decimal
    <Column(Name:="Edad lote", Storage:="EDAD_LOTE", DbType:="NUMERIC(5,0)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=5, Scale:=0)> _
    Public Property EDAD_LOTE() As Decimal
        Get
            Return _EDAD_LOTE
        End Get
        Set(ByVal Value As Decimal)
            _EDAD_LOTE = Value
            OnPropertyChanged("EDAD_LOTE")
        End Set
    End Property 

    Private _EDAD_LOTEOld As Decimal
    Public Property EDAD_LOTEOld() As Decimal
        Get
            Return _EDAD_LOTEOld
        End Get
        Set(ByVal Value As Decimal)
            _EDAD_LOTEOld = Value
        End Set
    End Property 

    Private _USER_CREA As String
    <Column(Name:="User crea", Storage:="USER_CREA", DbType:="VARCHAR(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
    Public Property USER_CREA() As String
        Get
            Return _USER_CREA
        End Get
        Set(ByVal Value As String)
            _USER_CREA = Value
            OnPropertyChanged("USER_CREA")
        End Set
    End Property 

    Private _USER_CREAOld As String
    Public Property USER_CREAOld() As String
        Get
            Return _USER_CREAOld
        End Get
        Set(ByVal Value As String)
            _USER_CREAOld = Value
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

    Private _USER_ACT As String
    <Column(Name:="User act", Storage:="USER_ACT", DbType:="VARCHAR(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
    Public Property USER_ACT() As String
        Get
            Return _USER_ACT
        End Get
        Set(ByVal Value As String)
            _USER_ACT = Value
            OnPropertyChanged("USER_ACT")
        End Set
    End Property 

    Private _USER_ACTOld As String
    Public Property USER_ACTOld() As String
        Get
            Return _USER_ACTOld
        End Get
        Set(ByVal Value As String)
            _USER_ACTOld = Value
        End Set
    End Property 

    Private _FECHA_ACT As DateTime
    <Column(Name:="Fecha act", Storage:="FECHA_ACT", DbType:="DATETIME", Id:=False), _
     DataObjectField(False, False, True)> _
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

    Private _ID_MAESTRO As Int32
    <Column(Name:="Id maestro", Storage:="ID_MAESTRO", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
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

    Private _fkID_MAESTRO As MAESTRO_LOTES
    Public Property fkID_MAESTRO() As MAESTRO_LOTES
        Get
            Return _fkID_MAESTRO
        End Get
        Set(ByVal Value As MAESTRO_LOTES)
            _fkID_MAESTRO = Value
        End Set
    End Property 

    Private _TIPO_DERECHO As Int32
    <Column(Name:="Tipo derecho", Storage:="TIPO_DERECHO", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property TIPO_DERECHO() As Int32
        Get
            Return _TIPO_DERECHO
        End Get
        Set(ByVal Value As Int32)
            _TIPO_DERECHO = Value
            OnPropertyChanged("TIPO_DERECHO")
        End Set
    End Property 

    Private _TIPO_DERECHOOld As Int32
    Public Property TIPO_DERECHOOld() As Int32
        Get
            Return _TIPO_DERECHOOld
        End Get
        Set(ByVal Value As Int32)
            _TIPO_DERECHOOld = Value
        End Set
    End Property 

    Private _SUB_ZONA As String
    <Column(Name:="Sub zona", Storage:="SUB_ZONA", DbType:="VARCHAR(6)", Id:=False), _
     DataObjectField(False, False, True, 6)> _
    Public Property SUB_ZONA() As String
        Get
            Return _SUB_ZONA
        End Get
        Set(ByVal Value As String)
            _SUB_ZONA = Value
            OnPropertyChanged("SUB_ZONA")
        End Set
    End Property 

    Private _SUB_ZONAOld As String
    Public Property SUB_ZONAOld() As String
        Get
            Return _SUB_ZONAOld
        End Get
        Set(ByVal Value As String)
            _SUB_ZONAOld = Value
        End Set
    End Property 

    Private _ID_LOTE_TRASPASO As Int32
    <Column(Name:="Id lote traspaso", Storage:="ID_LOTE_TRASPASO", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_LOTE_TRASPASO() As Int32
        Get
            Return _ID_LOTE_TRASPASO
        End Get
        Set(ByVal Value As Int32)
            _ID_LOTE_TRASPASO = Value
            OnPropertyChanged("ID_LOTE_TRASPASO")
        End Set
    End Property 

    Private _ID_LOTE_TRASPASOOld As Int32
    Public Property ID_LOTE_TRASPASOOld() As Int32
        Get
            Return _ID_LOTE_TRASPASOOld
        End Get
        Set(ByVal Value As Int32)
            _ID_LOTE_TRASPASOOld = Value
        End Set
    End Property 

    Private _fkID_LOTE_TRASPASO As LOTES_TRASPASO
    Public Property fkID_LOTE_TRASPASO() As LOTES_TRASPASO
        Get
            Return _fkID_LOTE_TRASPASO
        End Get
        Set(ByVal Value As LOTES_TRASPASO)
            _fkID_LOTE_TRASPASO = Value
        End Set
    End Property 

    Private _AREA_CANA As Decimal
    <Column(Name:="Area cana", Storage:="AREA_CANA", DbType:="NUMERIC(10,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=2)> _
    Public Property AREA_CANA() As Decimal
        Get
            Return _AREA_CANA
        End Get
        Set(ByVal Value As Decimal)
            _AREA_CANA = Value
            OnPropertyChanged("AREA_CANA")
        End Set
    End Property 

    Private _AREA_CANAOld As Decimal
    Public Property AREA_CANAOld() As Decimal
        Get
            Return _AREA_CANAOld
        End Get
        Set(ByVal Value As Decimal)
            _AREA_CANAOld = Value
        End Set
    End Property 

    Private _RIESGO_PIEDRA As Boolean
    <Column(Name:="Riesgo piedra", Storage:="RIESGO_PIEDRA", DbType:="BIT", Id:=False), _
     DataObjectField(False, False, True, 1)> _
    Public Property RIESGO_PIEDRA() As Boolean
        Get
            Return _RIESGO_PIEDRA
        End Get
        Set(ByVal Value As Boolean)
            _RIESGO_PIEDRA = Value
            OnPropertyChanged("RIESGO_PIEDRA")
        End Set
    End Property 

    Private _RIESGO_PIEDRAOld As Boolean
    Public Property RIESGO_PIEDRAOld() As Boolean
        Get
            Return _RIESGO_PIEDRAOld
        End Get
        Set(ByVal Value As Boolean)
            _RIESGO_PIEDRAOld = Value
        End Set
    End Property 

    Private _REPARA_ACCESO As Boolean
    <Column(Name:="Repara acceso", Storage:="REPARA_ACCESO", DbType:="BIT", Id:=False), _
     DataObjectField(False, False, True, 1)> _
    Public Property REPARA_ACCESO() As Boolean
        Get
            Return _REPARA_ACCESO
        End Get
        Set(ByVal Value As Boolean)
            _REPARA_ACCESO = Value
            OnPropertyChanged("REPARA_ACCESO")
        End Set
    End Property 

    Private _REPARA_ACCESOOld As Boolean
    Public Property REPARA_ACCESOOld() As Boolean
        Get
            Return _REPARA_ACCESOOld
        End Get
        Set(ByVal Value As Boolean)
            _REPARA_ACCESOOld = Value
        End Set
    End Property 

    Private _SIN_ACCESO_PROPIO As Boolean
    <Column(Name:="Sin acceso propio", Storage:="SIN_ACCESO_PROPIO", DbType:="BIT", Id:=False), _
     DataObjectField(False, False, True, 1)> _
    Public Property SIN_ACCESO_PROPIO() As Boolean
        Get
            Return _SIN_ACCESO_PROPIO
        End Get
        Set(ByVal Value As Boolean)
            _SIN_ACCESO_PROPIO = Value
            OnPropertyChanged("SIN_ACCESO_PROPIO")
        End Set
    End Property 

    Private _SIN_ACCESO_PROPIOOld As Boolean
    Public Property SIN_ACCESO_PROPIOOld() As Boolean
        Get
            Return _SIN_ACCESO_PROPIOOld
        End Get
        Set(ByVal Value As Boolean)
            _SIN_ACCESO_PROPIOOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
