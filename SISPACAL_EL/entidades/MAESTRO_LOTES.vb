''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.MAESTRO_LOTES
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row MAESTRO_LOTES en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/01/2020	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="MAESTRO_LOTES")> Public Class MAESTRO_LOTES
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_MAESTRO As Int32, aCUI As String, aCODI_DEPTO As String, aCODI_MUNI As String, aCODI_CANTON As String, aZONA As String, aSUB_ZONA As String, aCORRELATIVO As String, aCODIPROVEEDOR As String, aNOMBRE_COMER As String, aCODILOTE_COMER As String, aMZ_CULTIVADA As Decimal, aCODIVARIEDA As String, aID_COMPOR As Int32, aCOD_TIPO_SUELO As String, aID_COND_SIEMBRA As Int32, aID_NIVEL_HUMEDAD As Int32, aNO_CORTE As Int16, aMSNM As Decimal, aKM_CARRETERA As Decimal, aKM_TIERRA As Decimal, aRIESGO_PIEDRA As Boolean, aFECHA_SIEMBRA As DateTime, aFECHA_CORTE As DateTime, aPROD_TC As Decimal, aPROD_LB As Decimal, aFACTOR_DESPOBLA As Decimal, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime, aCODICONTRATO As Int32, aTIPO_DERECHO As Int32, aID_TIPO_CANA As Int32, aID_TIPO_ROZA As Int32, aID_TIPO_ALZA As Int32, aID_TIPO_TRANS As Int32, aCODIAGRON As String, aTARIFA_ROZA As Decimal, aTARIFA_ALZA As Decimal, aTARIFA_TRANS As Decimal, aTARIFA_CORTA As Decimal, aTARIFA_LARGA As Decimal, aREPARA_ACCESO As Boolean, aSIN_ACCESO_PROPIO As Boolean, aHACIENDA As String)
        Me._ID_MAESTRO = aID_MAESTRO
        Me._CUI = aCUI
        Me._CODI_DEPTO = aCODI_DEPTO
        Me._CODI_MUNI = aCODI_MUNI
        Me._CODI_CANTON = aCODI_CANTON
        Me._ZONA = aZONA
        Me._SUB_ZONA = aSUB_ZONA
        Me._CORRELATIVO = aCORRELATIVO
        Me._CODIPROVEEDOR = aCODIPROVEEDOR
        Me._NOMBRE_COMER = aNOMBRE_COMER
        Me._CODILOTE_COMER = aCODILOTE_COMER
        Me._MZ_CULTIVADA = aMZ_CULTIVADA
        Me._CODIVARIEDA = aCODIVARIEDA
        Me._ID_COMPOR = aID_COMPOR
        Me._COD_TIPO_SUELO = aCOD_TIPO_SUELO
        Me._ID_COND_SIEMBRA = aID_COND_SIEMBRA
        Me._ID_NIVEL_HUMEDAD = aID_NIVEL_HUMEDAD
        Me._NO_CORTE = aNO_CORTE
        Me._MSNM = aMSNM
        Me._KM_CARRETERA = aKM_CARRETERA
        Me._KM_TIERRA = aKM_TIERRA
        Me._RIESGO_PIEDRA = aRIESGO_PIEDRA
        Me._FECHA_SIEMBRA = aFECHA_SIEMBRA
        Me._FECHA_CORTE = aFECHA_CORTE
        Me._PROD_TC = aPROD_TC
        Me._PROD_LB = aPROD_LB
        Me._FACTOR_DESPOBLA = aFACTOR_DESPOBLA
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
        Me._CODICONTRATO = aCODICONTRATO
        Me._TIPO_DERECHO = aTIPO_DERECHO
        Me._ID_TIPO_CANA = aID_TIPO_CANA
        Me._ID_TIPO_ROZA = aID_TIPO_ROZA
        Me._ID_TIPO_ALZA = aID_TIPO_ALZA
        Me._ID_TIPO_TRANS = aID_TIPO_TRANS
        Me._CODIAGRON = aCODIAGRON
        Me._TARIFA_ROZA = aTARIFA_ROZA
        Me._TARIFA_ALZA = aTARIFA_ALZA
        Me._TARIFA_TRANS = aTARIFA_TRANS
        Me._TARIFA_CORTA = aTARIFA_CORTA
        Me._TARIFA_LARGA = aTARIFA_LARGA
        Me._REPARA_ACCESO = aREPARA_ACCESO
        Me._SIN_ACCESO_PROPIO = aSIN_ACCESO_PROPIO
        Me._HACIENDA = aHACIENDA
    End Sub

#Region " Properties "

    Private _ID_MAESTRO As Int32
    <Column(Name:="Id maestro", Storage:="ID_MAESTRO", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_MAESTRO() As Int32
        Get
            Return _ID_MAESTRO
        End Get
        Set(ByVal Value As Int32)
            _ID_MAESTRO = Value
            OnPropertyChanged("ID_MAESTRO")
        End Set
    End Property 

    Private _CUI As String
    <Column(Name:="Cui", Storage:="CUI", DbType:="CHAR(21) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 21)> _
    Public Property CUI() As String
        Get
            Return _CUI
        End Get
        Set(ByVal Value As String)
            _CUI = Value
            OnPropertyChanged("CUI")
        End Set
    End Property 

    Private _CUIOld As String
    Public Property CUIOld() As String
        Get
            Return _CUIOld
        End Get
        Set(ByVal Value As String)
            _CUIOld = Value
        End Set
    End Property 

    Private _CODI_DEPTO As String
    <Column(Name:="Codi depto", Storage:="CODI_DEPTO", DbType:="CHAR(2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 2)> _
    Public Property CODI_DEPTO() As String
        Get
            Return _CODI_DEPTO
        End Get
        Set(ByVal Value As String)
            _CODI_DEPTO = Value
            OnPropertyChanged("CODI_DEPTO")
        End Set
    End Property 

    Private _CODI_DEPTOOld As String
    Public Property CODI_DEPTOOld() As String
        Get
            Return _CODI_DEPTOOld
        End Get
        Set(ByVal Value As String)
            _CODI_DEPTOOld = Value
        End Set
    End Property 

    Private _fkCODI_DEPTO As CANTON
    Public Property fkCODI_DEPTO() As CANTON
        Get
            Return _fkCODI_DEPTO
        End Get
        Set(ByVal Value As CANTON)
            _fkCODI_DEPTO = Value
        End Set
    End Property 

    Private _CODI_MUNI As String
    <Column(Name:="Codi muni", Storage:="CODI_MUNI", DbType:="CHAR(2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 2)> _
    Public Property CODI_MUNI() As String
        Get
            Return _CODI_MUNI
        End Get
        Set(ByVal Value As String)
            _CODI_MUNI = Value
            OnPropertyChanged("CODI_MUNI")
        End Set
    End Property 

    Private _CODI_MUNIOld As String
    Public Property CODI_MUNIOld() As String
        Get
            Return _CODI_MUNIOld
        End Get
        Set(ByVal Value As String)
            _CODI_MUNIOld = Value
        End Set
    End Property 

    Private _fkCODI_MUNI As CANTON
    Public Property fkCODI_MUNI() As CANTON
        Get
            Return _fkCODI_MUNI
        End Get
        Set(ByVal Value As CANTON)
            _fkCODI_MUNI = Value
        End Set
    End Property 

    Private _CODI_CANTON As String
    <Column(Name:="Codi canton", Storage:="CODI_CANTON", DbType:="CHAR(2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 2)> _
    Public Property CODI_CANTON() As String
        Get
            Return _CODI_CANTON
        End Get
        Set(ByVal Value As String)
            _CODI_CANTON = Value
            OnPropertyChanged("CODI_CANTON")
        End Set
    End Property 

    Private _CODI_CANTONOld As String
    Public Property CODI_CANTONOld() As String
        Get
            Return _CODI_CANTONOld
        End Get
        Set(ByVal Value As String)
            _CODI_CANTONOld = Value
        End Set
    End Property 

    Private _fkCODI_CANTON As CANTON
    Public Property fkCODI_CANTON() As CANTON
        Get
            Return _fkCODI_CANTON
        End Get
        Set(ByVal Value As CANTON)
            _fkCODI_CANTON = Value
        End Set
    End Property 

    Private _ZONA As String
    <Column(Name:="Zona", Storage:="ZONA", DbType:="VARCHAR(2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 2)> _
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

    Private _fkZONA As ZONAS
    Public Property fkZONA() As ZONAS
        Get
            Return _fkZONA
        End Get
        Set(ByVal Value As ZONAS)
            _fkZONA = Value
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

    Private _fkSUB_ZONA As SUB_ZONAS
    Public Property fkSUB_ZONA() As SUB_ZONAS
        Get
            Return _fkSUB_ZONA
        End Get
        Set(ByVal Value As SUB_ZONAS)
            _fkSUB_ZONA = Value
        End Set
    End Property 

    Private _CORRELATIVO As String
    <Column(Name:="Correlativo", Storage:="CORRELATIVO", DbType:="CHAR(3) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 3)> _
    Public Property CORRELATIVO() As String
        Get
            Return _CORRELATIVO
        End Get
        Set(ByVal Value As String)
            _CORRELATIVO = Value
            OnPropertyChanged("CORRELATIVO")
        End Set
    End Property 

    Private _CORRELATIVOOld As String
    Public Property CORRELATIVOOld() As String
        Get
            Return _CORRELATIVOOld
        End Get
        Set(ByVal Value As String)
            _CORRELATIVOOld = Value
        End Set
    End Property 

    Private _CODIPROVEEDOR As String
    <Column(Name:="Codiproveedor", Storage:="CODIPROVEEDOR", DbType:="CHAR(10) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 10)> _
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

    Private _NOMBRE_COMER As String
    <Column(Name:="Nombre comer", Storage:="NOMBRE_COMER", DbType:="VARCHAR(200) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 200)> _
    Public Property NOMBRE_COMER() As String
        Get
            Return _NOMBRE_COMER
        End Get
        Set(ByVal Value As String)
            _NOMBRE_COMER = Value
            OnPropertyChanged("NOMBRE_COMER")
        End Set
    End Property 

    Private _NOMBRE_COMEROld As String
    Public Property NOMBRE_COMEROld() As String
        Get
            Return _NOMBRE_COMEROld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_COMEROld = Value
        End Set
    End Property 

    Private _CODILOTE_COMER As String
    <Column(Name:="Codilote comer", Storage:="CODILOTE_COMER", DBType:="CHAR(10)", Id:=False),
     DataObjectField(False, False, True, 10)>
    Public Property CODILOTE_COMER() As String
        Get
            Return _CODILOTE_COMER
        End Get
        Set(ByVal Value As String)
            _CODILOTE_COMER = Value
            OnPropertyChanged("CODILOTE_COMER")
        End Set
    End Property 

    Private _CODILOTE_COMEROld As String
    Public Property CODILOTE_COMEROld() As String
        Get
            Return _CODILOTE_COMEROld
        End Get
        Set(ByVal Value As String)
            _CODILOTE_COMEROld = Value
        End Set
    End Property 

    Private _MZ_CULTIVADA As Decimal
    <Column(Name:="Mz cultivada", Storage:="MZ_CULTIVADA", DbType:="NUMERIC(10,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)> _
    Public Property MZ_CULTIVADA() As Decimal
        Get
            Return _MZ_CULTIVADA
        End Get
        Set(ByVal Value As Decimal)
            _MZ_CULTIVADA = Value
            OnPropertyChanged("MZ_CULTIVADA")
        End Set
    End Property 

    Private _MZ_CULTIVADAOld As Decimal
    Public Property MZ_CULTIVADAOld() As Decimal
        Get
            Return _MZ_CULTIVADAOld
        End Get
        Set(ByVal Value As Decimal)
            _MZ_CULTIVADAOld = Value
        End Set
    End Property 

    Private _CODIVARIEDA As String
    <Column(Name:="Codivarieda", Storage:="CODIVARIEDA", DbType:="CHAR(3) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 3)> _
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

    Private _ID_COMPOR As Int32
    <Column(Name:="Id compor", Storage:="ID_COMPOR", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_COMPOR() As Int32
        Get
            Return _ID_COMPOR
        End Get
        Set(ByVal Value As Int32)
            _ID_COMPOR = Value
            OnPropertyChanged("ID_COMPOR")
        End Set
    End Property 

    Private _ID_COMPOROld As Int32
    Public Property ID_COMPOROld() As Int32
        Get
            Return _ID_COMPOROld
        End Get
        Set(ByVal Value As Int32)
            _ID_COMPOROld = Value
        End Set
    End Property 

    Private _fkID_COMPOR As COMPORTAMIENTO_CANA
    Public Property fkID_COMPOR() As COMPORTAMIENTO_CANA
        Get
            Return _fkID_COMPOR
        End Get
        Set(ByVal Value As COMPORTAMIENTO_CANA)
            _fkID_COMPOR = Value
        End Set
    End Property 

   

    Private _COD_TIPO_SUELOOld As String
    Public Property COD_TIPO_SUELOOld() As String
        Get
            Return _COD_TIPO_SUELOOld
        End Get
        Set(ByVal Value As String)
            _COD_TIPO_SUELOOld = Value
        End Set
    End Property 

    Private _fkCOD_TIPO_SUELO As TIPO_SUELO
    Public Property fkCOD_TIPO_SUELO() As TIPO_SUELO
        Get
            Return _fkCOD_TIPO_SUELO
        End Get
        Set(ByVal Value As TIPO_SUELO)
            _fkCOD_TIPO_SUELO = Value
        End Set
    End Property 

    Private _ID_COND_SIEMBRA As Int32
    <Column(Name:="Id cond siembra", Storage:="ID_COND_SIEMBRA", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_COND_SIEMBRA() As Int32
        Get
            Return _ID_COND_SIEMBRA
        End Get
        Set(ByVal Value As Int32)
            _ID_COND_SIEMBRA = Value
            OnPropertyChanged("ID_COND_SIEMBRA")
        End Set
    End Property 

    Private _ID_COND_SIEMBRAOld As Int32
    Public Property ID_COND_SIEMBRAOld() As Int32
        Get
            Return _ID_COND_SIEMBRAOld
        End Get
        Set(ByVal Value As Int32)
            _ID_COND_SIEMBRAOld = Value
        End Set
    End Property 

    Private _fkID_COND_SIEMBRA As CONDICION_SIEMBRA
    Public Property fkID_COND_SIEMBRA() As CONDICION_SIEMBRA
        Get
            Return _fkID_COND_SIEMBRA
        End Get
        Set(ByVal Value As CONDICION_SIEMBRA)
            _fkID_COND_SIEMBRA = Value
        End Set
    End Property 

    Private _ID_NIVEL_HUMEDAD As Int32
    <Column(Name:="Id nivel humedad", Storage:="ID_NIVEL_HUMEDAD", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_NIVEL_HUMEDAD() As Int32
        Get
            Return _ID_NIVEL_HUMEDAD
        End Get
        Set(ByVal Value As Int32)
            _ID_NIVEL_HUMEDAD = Value
            OnPropertyChanged("ID_NIVEL_HUMEDAD")
        End Set
    End Property 

    Private _ID_NIVEL_HUMEDADOld As Int32
    Public Property ID_NIVEL_HUMEDADOld() As Int32
        Get
            Return _ID_NIVEL_HUMEDADOld
        End Get
        Set(ByVal Value As Int32)
            _ID_NIVEL_HUMEDADOld = Value
        End Set
    End Property 

    Private _fkID_NIVEL_HUMEDAD As NIVEL_HUMEDAD
    Public Property fkID_NIVEL_HUMEDAD() As NIVEL_HUMEDAD
        Get
            Return _fkID_NIVEL_HUMEDAD
        End Get
        Set(ByVal Value As NIVEL_HUMEDAD)
            _fkID_NIVEL_HUMEDAD = Value
        End Set
    End Property 

    Private _NO_CORTE As Int16
    <Column(Name:="No corte", Storage:="NO_CORTE", DbType:="SMALLINT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property NO_CORTE() As Int16
        Get
            Return _NO_CORTE
        End Get
        Set(ByVal Value As Int16)
            _NO_CORTE = Value
            OnPropertyChanged("NO_CORTE")
        End Set
    End Property 

    Private _NO_CORTEOld As Int16
    Public Property NO_CORTEOld() As Int16
        Get
            Return _NO_CORTEOld
        End Get
        Set(ByVal Value As Int16)
            _NO_CORTEOld = Value
        End Set
    End Property 

    Private _MSNM As Decimal
    <Column(Name:="Msnm", Storage:="MSNM", DbType:="NUMERIC(10,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=2)> _
    Public Property MSNM() As Decimal
        Get
            Return _MSNM
        End Get
        Set(ByVal Value As Decimal)
            _MSNM = Value
            OnPropertyChanged("MSNM")
        End Set
    End Property 

    Private _MSNMOld As Decimal
    Public Property MSNMOld() As Decimal
        Get
            Return _MSNMOld
        End Get
        Set(ByVal Value As Decimal)
            _MSNMOld = Value
        End Set
    End Property 

    Private _KM_CARRETERA As Decimal
    <Column(Name:="Km carretera", Storage:="KM_CARRETERA", DbType:="NUMERIC(10,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)> _
    Public Property KM_CARRETERA() As Decimal
        Get
            Return _KM_CARRETERA
        End Get
        Set(ByVal Value As Decimal)
            _KM_CARRETERA = Value
            OnPropertyChanged("KM_CARRETERA")
        End Set
    End Property 

    Private _KM_CARRETERAOld As Decimal
    Public Property KM_CARRETERAOld() As Decimal
        Get
            Return _KM_CARRETERAOld
        End Get
        Set(ByVal Value As Decimal)
            _KM_CARRETERAOld = Value
        End Set
    End Property 

    Private _KM_TIERRA As Decimal
    <Column(Name:="Km tierra", Storage:="KM_TIERRA", DbType:="NUMERIC(10,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)> _
    Public Property KM_TIERRA() As Decimal
        Get
            Return _KM_TIERRA
        End Get
        Set(ByVal Value As Decimal)
            _KM_TIERRA = Value
            OnPropertyChanged("KM_TIERRA")
        End Set
    End Property 

    Private _KM_TIERRAOld As Decimal
    Public Property KM_TIERRAOld() As Decimal
        Get
            Return _KM_TIERRAOld
        End Get
        Set(ByVal Value As Decimal)
            _KM_TIERRAOld = Value
        End Set
    End Property 

    Private _RIESGO_PIEDRA As Boolean
    <Column(Name:="Riesgo piedra", Storage:="RIESGO_PIEDRA", DbType:="BIT NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 1)> _
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

    Private _FECHA_SIEMBRA As DateTime
    <Column(Name:="Fecha siembra", Storage:="FECHA_SIEMBRA", DbType:="DATETIME", Id:=False), _
     DataObjectField(False, False, True)> _
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

    Private _FECHA_CORTE As DateTime
    <Column(Name:="Fecha corte", Storage:="FECHA_CORTE", DbType:="DATETIME", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_CORTE() As DateTime
        Get
            Return _FECHA_CORTE
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_CORTE = Value
            OnPropertyChanged("FECHA_CORTE")
        End Set
    End Property 

    Private _FECHA_CORTEOld As DateTime
    Public Property FECHA_CORTEOld() As DateTime
        Get
            Return _FECHA_CORTEOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_CORTEOld = Value
        End Set
    End Property 

    Private _PROD_TC As Decimal
    <Column(Name:="Prod tc", Storage:="PROD_TC", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property PROD_TC() As Decimal
        Get
            Return _PROD_TC
        End Get
        Set(ByVal Value As Decimal)
            _PROD_TC = Value
            OnPropertyChanged("PROD_TC")
        End Set
    End Property 

    Private _PROD_TCOld As Decimal
    Public Property PROD_TCOld() As Decimal
        Get
            Return _PROD_TCOld
        End Get
        Set(ByVal Value As Decimal)
            _PROD_TCOld = Value
        End Set
    End Property 

    Private _PROD_LB As Decimal
    <Column(Name:="Prod lb", Storage:="PROD_LB", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property PROD_LB() As Decimal
        Get
            Return _PROD_LB
        End Get
        Set(ByVal Value As Decimal)
            _PROD_LB = Value
            OnPropertyChanged("PROD_LB")
        End Set
    End Property 

    Private _PROD_LBOld As Decimal
    Public Property PROD_LBOld() As Decimal
        Get
            Return _PROD_LBOld
        End Get
        Set(ByVal Value As Decimal)
            _PROD_LBOld = Value
        End Set
    End Property 

    Private _FACTOR_DESPOBLA As Decimal
    <Column(Name:="Factor despobla", Storage:="FACTOR_DESPOBLA", DbType:="NUMERIC(10,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=2)> _
    Public Property FACTOR_DESPOBLA() As Decimal
        Get
            Return _FACTOR_DESPOBLA
        End Get
        Set(ByVal Value As Decimal)
            _FACTOR_DESPOBLA = Value
            OnPropertyChanged("FACTOR_DESPOBLA")
        End Set
    End Property 

    Private _FACTOR_DESPOBLAOld As Decimal
    Public Property FACTOR_DESPOBLAOld() As Decimal
        Get
            Return _FACTOR_DESPOBLAOld
        End Get
        Set(ByVal Value As Decimal)
            _FACTOR_DESPOBLAOld = Value
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

    Private _CODICONTRATO As Int32
    <Column(Name:="Codicontrato", Storage:="CODICONTRATO", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property CODICONTRATO() As Int32
        Get
            Return _CODICONTRATO
        End Get
        Set(ByVal Value As Int32)
            _CODICONTRATO = Value
            OnPropertyChanged("CODICONTRATO")
        End Set
    End Property 

    Private _CODICONTRATOOld As Int32
    Public Property CODICONTRATOOld() As Int32
        Get
            Return _CODICONTRATOOld
        End Get
        Set(ByVal Value As Int32)
            _CODICONTRATOOld = Value
        End Set
    End Property 

    Private _TIPO_DERECHO As Int32
    <Column(Name:="Tipo derecho", Storage:="TIPO_DERECHO", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
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

    Private _ID_TIPO_CANA As Int32
    <Column(Name:="Id tipo cana", Storage:="ID_TIPO_CANA", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
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
    <Column(Name:="Id tipo roza", Storage:="ID_TIPO_ROZA", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
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
    <Column(Name:="Id tipo alza", Storage:="ID_TIPO_ALZA", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
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
    <Column(Name:="Id tipo trans", Storage:="ID_TIPO_TRANS", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
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

    Private _TARIFA_ROZA As Decimal
    <Column(Name:="Tarifa roza", Storage:="TARIFA_ROZA", DbType:="NUMERIC(10,6)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=6)> _
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
    <Column(Name:="Tarifa alza", Storage:="TARIFA_ALZA", DbType:="NUMERIC(5,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=5, Scale:=2)> _
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
    <Column(Name:="Tarifa trans", Storage:="TARIFA_TRANS", DBType:="NUMERIC(20,6)", Id:=False),
     DataObjectField(False, False, True), Precision(Precision:=5, Scale:=6)>
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
    <Column(Name:="Tarifa corta", Storage:="TARIFA_CORTA", DBType:="NUMERIC(20,6)", Id:=False),
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=6)>
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
    <Column(Name:="Tarifa larga", Storage:="TARIFA_LARGA", DBType:="NUMERIC(20,6)", Id:=False),
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=6)>
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



    Private _TARIFA_LARGA_T3S3 As Decimal
    <Column(Name:="Tarifa larga T3S3", Storage:="TARIFA_LARGA_T3S3", DBType:="NUMERIC(20,6)", Id:=False),
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=6)>
    Public Property TARIFA_LARGA_T3S3() As Decimal
        Get
            Return _TARIFA_LARGA_T3S3
        End Get
        Set(ByVal Value As Decimal)
            _TARIFA_LARGA_T3S3 = Value
            OnPropertyChanged("TARIFA_LARGA_T3S3")
        End Set
    End Property

    Private _TARIFA_LARGA_T3S3Old As Decimal
    Public Property TARIFA_LARGA_T3S3Old() As Decimal
        Get
            Return _TARIFA_LARGA_T3S3Old
        End Get
        Set(ByVal Value As Decimal)
            _TARIFA_LARGA_T3S3Old = Value
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

    Private _HACIENDA As String
    <Column(Name:="Hacienda", Storage:="HACIENDA", DBType:="VARCHAR(200) NOT NULL", Id:=False),
     DataObjectField(False, False, False, 200)>
    Public Property HACIENDA() As String
        Get
            Return _HACIENDA
        End Get
        Set(ByVal Value As String)
            _HACIENDA = Value
            OnPropertyChanged("HACIENDA")
        End Set
    End Property

    Private _HACIENDAOld As String
    Public Property HACIENDAOld() As String
        Get
            Return _HACIENDAOld
        End Get
        Set(ByVal Value As String)
            _HACIENDAOld = Value
        End Set
    End Property


    Private _ESTADO As String
    <Column(Name:="ESTADO", Storage:="ESTADO", DBType:="VARCHAR(1) NULL", Id:=False),
     DataObjectField(False, False, False, 1)>
    Public Property ESTADO() As String
        Get
            Return _ESTADO
        End Get
        Set(ByVal Value As String)
            _ESTADO = Value
            OnPropertyChanged("ESTADO")
        End Set
    End Property

    Private _ID_SUBLOTES As Int32
    <Column(Name:="ID_SUBLOTES", Storage:="ID_SUBLOTES", DBType:="INT NULL", Id:=False),
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
#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
