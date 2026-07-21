''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.PROVEEDOR
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row PROVEEDOR en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	13/01/2017	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="PROVEEDOR")> Public Class PROVEEDOR
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aCODIPROVEEDOR As String, aCODIPROVEE As String, aCODISOCIO As String, aAPELLIDOS As String, aNOMBRES As String, aEDAD As String, aDIRECCION As String, aTELEFONO As String, aCELULAR As String, aDUI As String, aNIT As String, aCREDITFISCAL As String, aPROFESION As String, aNOMBRENIT As String, aAPODERADO As String, aDUI_APODERADO As String, aNIT_APODERADO As String, aUSER_CREA As Int32, aFECHA_CREA As DateTime, aUSER_ACT As Int32, aFECHA_ACT As DateTime, aFECHA_NAC As DateTime, aTIPO_CONTRIBUYENTE As Int32, aACTIVIDAD As String, aCODIBANCO As Int32, aNUM_CUENTA As String, aES_CTA_CORRIENTE As Boolean, aCODI_DEPTO As String, aCODI_MUNI As String, aCORREO As String, aID_TIPO_PERSONA As Int32)
        Me._CODIPROVEEDOR = aCODIPROVEEDOR
        Me._CODIPROVEE = aCODIPROVEE
        Me._CODISOCIO = aCODISOCIO
        Me._APELLIDOS = aAPELLIDOS
        Me._NOMBRES = aNOMBRES
        Me._EDAD = aEDAD
        Me._DIRECCION = aDIRECCION
        Me._TELEFONO = aTELEFONO
        Me._CELULAR = aCELULAR
        Me._DUI = aDUI
        Me._NIT = aNIT
        Me._CREDITFISCAL = aCREDITFISCAL
        Me._PROFESION = aPROFESION
        Me._NOMBRENIT = aNOMBRENIT
        Me._APODERADO = aAPODERADO
        Me._DUI_APODERADO = aDUI_APODERADO
        Me._NIT_APODERADO = aNIT_APODERADO
        Me._USER_CREA = aUSER_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USER_ACT = aUSER_ACT
        Me._FECHA_ACT = aFECHA_ACT
        Me._FECHA_NAC = aFECHA_NAC
        Me._TIPO_CONTRIBUYENTE = aTIPO_CONTRIBUYENTE
        Me._ACTIVIDAD = aACTIVIDAD
        Me._CODIBANCO = aCODIBANCO
        Me._NUM_CUENTA = aNUM_CUENTA
        Me._ES_CTA_CORRIENTE = aES_CTA_CORRIENTE
        Me._CODI_DEPTO = aCODI_DEPTO
        Me._CODI_MUNI = aCODI_MUNI
        Me._CORREO = aCORREO
        Me._ID_TIPO_PERSONA = aID_TIPO_PERSONA
    End Sub

#Region " Properties "

    Private _CODIPROVEEDOR As String
    <Column(Name:="Codiproveedor", Storage:="CODIPROVEEDOR", DbType:="CHAR(10) NOT NULL", Id:=True), _
     DataObjectField(True, False, False, 10)> _
    Public Property CODIPROVEEDOR() As String
        Get
            Return _CODIPROVEEDOR
        End Get
        Set(ByVal Value As String)
            _CODIPROVEEDOR = Value
            OnPropertyChanged("CODIPROVEEDOR")
        End Set
    End Property 

    Private _CODIPROVEE As String
    <Column(Name:="Codiprovee", Storage:="CODIPROVEE", DbType:="CHAR(6)", Id:=False), _
     DataObjectField(False, False, True, 6)> _
    Public Property CODIPROVEE() As String
        Get
            Return _CODIPROVEE
        End Get
        Set(ByVal Value As String)
            _CODIPROVEE = Value
            OnPropertyChanged("CODIPROVEE")
        End Set
    End Property 

    Private _CODIPROVEEOld As String
    Public Property CODIPROVEEOld() As String
        Get
            Return _CODIPROVEEOld
        End Get
        Set(ByVal Value As String)
            _CODIPROVEEOld = Value
        End Set
    End Property 

    Private _CODISOCIO As String
    <Column(Name:="Codisocio", Storage:="CODISOCIO", DbType:="CHAR(4)", Id:=False), _
     DataObjectField(False, False, True, 4)> _
    Public Property CODISOCIO() As String
        Get
            Return _CODISOCIO
        End Get
        Set(ByVal Value As String)
            _CODISOCIO = Value
            OnPropertyChanged("CODISOCIO")
        End Set
    End Property 

    Private _CODISOCIOOld As String
    Public Property CODISOCIOOld() As String
        Get
            Return _CODISOCIOOld
        End Get
        Set(ByVal Value As String)
            _CODISOCIOOld = Value
        End Set
    End Property 

    Private _APELLIDOS As String
    <Column(Name:="Apellidos", Storage:="APELLIDOS", DBType:="CHAR(150)", Id:=False),
     DataObjectField(False, False, True, 150)>
    Public Property APELLIDOS() As String
        Get
            Return _APELLIDOS
        End Get
        Set(ByVal Value As String)
            _APELLIDOS = Value
            OnPropertyChanged("APELLIDOS")
        End Set
    End Property 

    Private _APELLIDOSOld As String
    Public Property APELLIDOSOld() As String
        Get
            Return _APELLIDOSOld
        End Get
        Set(ByVal Value As String)
            _APELLIDOSOld = Value
        End Set
    End Property 

    Private _NOMBRES As String
    <Column(Name:="Nombres", Storage:="NOMBRES", DBType:="CHAR(150)", Id:=False),
     DataObjectField(False, False, True, 150)>
    Public Property NOMBRES() As String
        Get
            Return _NOMBRES
        End Get
        Set(ByVal Value As String)
            _NOMBRES = Value
            OnPropertyChanged("NOMBRES")
        End Set
    End Property 

    Private _NOMBRESOld As String
    Public Property NOMBRESOld() As String
        Get
            Return _NOMBRESOld
        End Get
        Set(ByVal Value As String)
            _NOMBRESOld = Value
        End Set
    End Property 

    Private _EDAD As String
    <Column(Name:="Edad", Storage:="EDAD", DbType:="VARCHAR(3)", Id:=False), _
     DataObjectField(False, False, True, 3)> _
    Public Property EDAD() As String
        Get
            Return _EDAD
        End Get
        Set(ByVal Value As String)
            _EDAD = Value
            OnPropertyChanged("EDAD")
        End Set
    End Property 

    Private _EDADOld As String
    Public Property EDADOld() As String
        Get
            Return _EDADOld
        End Get
        Set(ByVal Value As String)
            _EDADOld = Value
        End Set
    End Property 

    Private _DIRECCION As String
    <Column(Name:="Direccion", Storage:="DIRECCION", DbType:="CHAR(250)", Id:=False), _
     DataObjectField(False, False, True, 250)> _
    Public Property DIRECCION() As String
        Get
            Return _DIRECCION
        End Get
        Set(ByVal Value As String)
            _DIRECCION = Value
            OnPropertyChanged("DIRECCION")
        End Set
    End Property 

    Private _DIRECCIONOld As String
    Public Property DIRECCIONOld() As String
        Get
            Return _DIRECCIONOld
        End Get
        Set(ByVal Value As String)
            _DIRECCIONOld = Value
        End Set
    End Property 

    Private _TELEFONO As String
    <Column(Name:="Telefono", Storage:="TELEFONO", DBType:="CHAR(100)", Id:=False),
     DataObjectField(False, False, True, 100)>
    Public Property TELEFONO() As String
        Get
            Return _TELEFONO
        End Get
        Set(ByVal Value As String)
            _TELEFONO = Value
            OnPropertyChanged("TELEFONO")
        End Set
    End Property 

    Private _TELEFONOOld As String
    Public Property TELEFONOOld() As String
        Get
            Return _TELEFONOOld
        End Get
        Set(ByVal Value As String)
            _TELEFONOOld = Value
        End Set
    End Property 

    Private _CELULAR As String
    <Column(Name:="Celular", Storage:="CELULAR", DBType:="CHAR(100)", Id:=False),
     DataObjectField(False, False, True, 100)>
    Public Property CELULAR() As String
        Get
            Return _CELULAR
        End Get
        Set(ByVal Value As String)
            _CELULAR = Value
            OnPropertyChanged("CELULAR")
        End Set
    End Property 

    Private _CELULAROld As String
    Public Property CELULAROld() As String
        Get
            Return _CELULAROld
        End Get
        Set(ByVal Value As String)
            _CELULAROld = Value
        End Set
    End Property 

    Private _DUI As String
    <Column(Name:="Dui", Storage:="DUI", DbType:="CHAR(10)", Id:=False), _
     DataObjectField(False, False, True, 10)> _
    Public Property DUI() As String
        Get
            Return _DUI
        End Get
        Set(ByVal Value As String)
            _DUI = Value
            OnPropertyChanged("DUI")
        End Set
    End Property 

    Private _DUIOld As String
    Public Property DUIOld() As String
        Get
            Return _DUIOld
        End Get
        Set(ByVal Value As String)
            _DUIOld = Value
        End Set
    End Property 

    Private _NIT As String
    <Column(Name:="Nit", Storage:="NIT", DbType:="CHAR(17)", Id:=False), _
     DataObjectField(False, False, True, 17)> _
    Public Property NIT() As String
        Get
            Return _NIT
        End Get
        Set(ByVal Value As String)
            _NIT = Value
            OnPropertyChanged("NIT")
        End Set
    End Property 

    Private _NITOld As String
    Public Property NITOld() As String
        Get
            Return _NITOld
        End Get
        Set(ByVal Value As String)
            _NITOld = Value
        End Set
    End Property 

    Private _CREDITFISCAL As String
    <Column(Name:="Creditfiscal", Storage:="CREDITFISCAL", DbType:="CHAR(10)", Id:=False), _
     DataObjectField(False, False, True, 10)> _
    Public Property CREDITFISCAL() As String
        Get
            Return _CREDITFISCAL
        End Get
        Set(ByVal Value As String)
            _CREDITFISCAL = Value
            OnPropertyChanged("CREDITFISCAL")
        End Set
    End Property 

    Private _CREDITFISCALOld As String
    Public Property CREDITFISCALOld() As String
        Get
            Return _CREDITFISCALOld
        End Get
        Set(ByVal Value As String)
            _CREDITFISCALOld = Value
        End Set
    End Property 

    Private _PROFESION As String
    <Column(Name:="Profesion", Storage:="PROFESION", DBType:="CHAR(200)", Id:=False),
     DataObjectField(False, False, True, 200)>
    Public Property PROFESION() As String
        Get
            Return _PROFESION
        End Get
        Set(ByVal Value As String)
            _PROFESION = Value
            OnPropertyChanged("PROFESION")
        End Set
    End Property 

    Private _PROFESIONOld As String
    Public Property PROFESIONOld() As String
        Get
            Return _PROFESIONOld
        End Get
        Set(ByVal Value As String)
            _PROFESIONOld = Value
        End Set
    End Property 

    Private _NOMBRENIT As String
    <Column(Name:="Nombrenit", Storage:="NOMBRENIT", DBType:="CHAR(200)", Id:=False),
     DataObjectField(False, False, True, 200)>
    Public Property NOMBRENIT() As String
        Get
            Return _NOMBRENIT
        End Get
        Set(ByVal Value As String)
            _NOMBRENIT = Value
            OnPropertyChanged("NOMBRENIT")
        End Set
    End Property 

    Private _NOMBRENITOld As String
    Public Property NOMBRENITOld() As String
        Get
            Return _NOMBRENITOld
        End Get
        Set(ByVal Value As String)
            _NOMBRENITOld = Value
        End Set
    End Property 

    Private _APODERADO As String
    <Column(Name:="Apoderado", Storage:="APODERADO", DbType:="CHAR(60)", Id:=False), _
     DataObjectField(False, False, True, 60)> _
    Public Property APODERADO() As String
        Get
            Return _APODERADO
        End Get
        Set(ByVal Value As String)
            _APODERADO = Value
            OnPropertyChanged("APODERADO")
        End Set
    End Property 

    Private _APODERADOOld As String
    Public Property APODERADOOld() As String
        Get
            Return _APODERADOOld
        End Get
        Set(ByVal Value As String)
            _APODERADOOld = Value
        End Set
    End Property 

    Private _DUI_APODERADO As String
    <Column(Name:="Dui apoderado", Storage:="DUI_APODERADO", DbType:="CHAR(10)", Id:=False), _
     DataObjectField(False, False, True, 10)> _
    Public Property DUI_APODERADO() As String
        Get
            Return _DUI_APODERADO
        End Get
        Set(ByVal Value As String)
            _DUI_APODERADO = Value
            OnPropertyChanged("DUI_APODERADO")
        End Set
    End Property 

    Private _DUI_APODERADOOld As String
    Public Property DUI_APODERADOOld() As String
        Get
            Return _DUI_APODERADOOld
        End Get
        Set(ByVal Value As String)
            _DUI_APODERADOOld = Value
        End Set
    End Property 

    Private _NIT_APODERADO As String
    <Column(Name:="Nit apoderado", Storage:="NIT_APODERADO", DbType:="CHAR(17)", Id:=False), _
     DataObjectField(False, False, True, 17)> _
    Public Property NIT_APODERADO() As String
        Get
            Return _NIT_APODERADO
        End Get
        Set(ByVal Value As String)
            _NIT_APODERADO = Value
            OnPropertyChanged("NIT_APODERADO")
        End Set
    End Property 

    Private _NIT_APODERADOOld As String
    Public Property NIT_APODERADOOld() As String
        Get
            Return _NIT_APODERADOOld
        End Get
        Set(ByVal Value As String)
            _NIT_APODERADOOld = Value
        End Set
    End Property 

    Private _USER_CREA As Int32
    <Column(Name:="User crea", Storage:="USER_CREA", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property USER_CREA() As Int32
        Get
            Return _USER_CREA
        End Get
        Set(ByVal Value As Int32)
            _USER_CREA = Value
            OnPropertyChanged("USER_CREA")
        End Set
    End Property 

    Private _USER_CREAOld As Int32
    Public Property USER_CREAOld() As Int32
        Get
            Return _USER_CREAOld
        End Get
        Set(ByVal Value As Int32)
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

    Private _USER_ACT As Int32
    <Column(Name:="User act", Storage:="USER_ACT", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property USER_ACT() As Int32
        Get
            Return _USER_ACT
        End Get
        Set(ByVal Value As Int32)
            _USER_ACT = Value
            OnPropertyChanged("USER_ACT")
        End Set
    End Property 

    Private _USER_ACTOld As Int32
    Public Property USER_ACTOld() As Int32
        Get
            Return _USER_ACTOld
        End Get
        Set(ByVal Value As Int32)
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

    Private _FECHA_NAC As DateTime
    <Column(Name:="Fecha nac", Storage:="FECHA_NAC", DbType:="DATETIME", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_NAC() As DateTime
        Get
            Return _FECHA_NAC
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_NAC = Value
            OnPropertyChanged("FECHA_NAC")
        End Set
    End Property 

    Private _FECHA_NACOld As DateTime
    Public Property FECHA_NACOld() As DateTime
        Get
            Return _FECHA_NACOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_NACOld = Value
        End Set
    End Property 

    Private _TIPO_CONTRIBUYENTE As Int32
    <Column(Name:="Tipo contribuyente", Storage:="TIPO_CONTRIBUYENTE", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property TIPO_CONTRIBUYENTE() As Int32
        Get
            Return _TIPO_CONTRIBUYENTE
        End Get
        Set(ByVal Value As Int32)
            _TIPO_CONTRIBUYENTE = Value
            OnPropertyChanged("TIPO_CONTRIBUYENTE")
        End Set
    End Property 

    Private _TIPO_CONTRIBUYENTEOld As Int32
    Public Property TIPO_CONTRIBUYENTEOld() As Int32
        Get
            Return _TIPO_CONTRIBUYENTEOld
        End Get
        Set(ByVal Value As Int32)
            _TIPO_CONTRIBUYENTEOld = Value
        End Set
    End Property 

    Private _ACTIVIDAD As String
    <Column(Name:="Actividad", Storage:="ACTIVIDAD", DbType:="VARCHAR(1000)", Id:=False), _
     DataObjectField(False, False, True, 1000)> _
    Public Property ACTIVIDAD() As String
        Get
            Return _ACTIVIDAD
        End Get
        Set(ByVal Value As String)
            _ACTIVIDAD = Value
            OnPropertyChanged("ACTIVIDAD")
        End Set
    End Property 

    Private _ACTIVIDADOld As String
    Public Property ACTIVIDADOld() As String
        Get
            Return _ACTIVIDADOld
        End Get
        Set(ByVal Value As String)
            _ACTIVIDADOld = Value
        End Set
    End Property 

    Private _CODIBANCO As Int32
    <Column(Name:="Codibanco", Storage:="CODIBANCO", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property CODIBANCO() As Int32
        Get
            Return _CODIBANCO
        End Get
        Set(ByVal Value As Int32)
            _CODIBANCO = Value
            OnPropertyChanged("CODIBANCO")
        End Set
    End Property 

    Private _CODIBANCOOld As Int32
    Public Property CODIBANCOOld() As Int32
        Get
            Return _CODIBANCOOld
        End Get
        Set(ByVal Value As Int32)
            _CODIBANCOOld = Value
        End Set
    End Property 

    Private _NUM_CUENTA As String
    <Column(Name:="Num cuenta", Storage:="NUM_CUENTA", DbType:="VARCHAR(30)", Id:=False), _
     DataObjectField(False, False, True, 30)> _
    Public Property NUM_CUENTA() As String
        Get
            Return _NUM_CUENTA
        End Get
        Set(ByVal Value As String)
            _NUM_CUENTA = Value
            OnPropertyChanged("NUM_CUENTA")
        End Set
    End Property 

    Private _NUM_CUENTAOld As String
    Public Property NUM_CUENTAOld() As String
        Get
            Return _NUM_CUENTAOld
        End Get
        Set(ByVal Value As String)
            _NUM_CUENTAOld = Value
        End Set
    End Property 

    Private _ES_CTA_CORRIENTE As Boolean
    <Column(Name:="Es cta corriente", Storage:="ES_CTA_CORRIENTE", DbType:="BIT", Id:=False), _
     DataObjectField(False, False, True, 1)> _
    Public Property ES_CTA_CORRIENTE() As Boolean
        Get
            Return _ES_CTA_CORRIENTE
        End Get
        Set(ByVal Value As Boolean)
            _ES_CTA_CORRIENTE = Value
            OnPropertyChanged("ES_CTA_CORRIENTE")
        End Set
    End Property 

    Private _ES_CTA_CORRIENTEOld As Boolean
    Public Property ES_CTA_CORRIENTEOld() As Boolean
        Get
            Return _ES_CTA_CORRIENTEOld
        End Get
        Set(ByVal Value As Boolean)
            _ES_CTA_CORRIENTEOld = Value
        End Set
    End Property

    Private _CODI_DEPTO As String
    <Column(Name:="Codi depto", Storage:="CODI_DEPTO", DBType:="CHAR(2)", Id:=False),
     DataObjectField(False, False, True, 2)>
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

    Private _fkCODI_DEPTO As MUNICIPIO
    Public Property fkCODI_DEPTO() As MUNICIPIO
        Get
            Return _fkCODI_DEPTO
        End Get
        Set(ByVal Value As MUNICIPIO)
            _fkCODI_DEPTO = Value
        End Set
    End Property

    Private _CODI_MUNI As String
    <Column(Name:="Codi muni", Storage:="CODI_MUNI", DBType:="CHAR(2)", Id:=False),
     DataObjectField(False, False, True, 2)>
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

    Private _fkCODI_MUNI As MUNICIPIO
    Public Property fkCODI_MUNI() As MUNICIPIO
        Get
            Return _fkCODI_MUNI
        End Get
        Set(ByVal Value As MUNICIPIO)
            _fkCODI_MUNI = Value
        End Set
    End Property

    Private _CORREO As String
    <Column(Name:="Correo", Storage:="CORREO", DBType:="NVARCHAR(400)", Id:=False),
     DataObjectField(False, False, True, 400)>
    Public Property CORREO() As String
        Get
            Return _CORREO
        End Get
        Set(ByVal Value As String)
            _CORREO = Value
            OnPropertyChanged("CORREO")
        End Set
    End Property

    Private _CORREOOld As String
    Public Property CORREOOld() As String
        Get
            Return _CORREOOld
        End Get
        Set(ByVal Value As String)
            _CORREOOld = Value
        End Set
    End Property

    Private _ID_TIPO_PERSONA As Int32
    <Column(Name:="Id tipo persona", Storage:="ID_TIPO_PERSONA", DBType:="INT", Id:=False),
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)>
    Public Property ID_TIPO_PERSONA() As Int32
        Get
            Return _ID_TIPO_PERSONA
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_PERSONA = Value
            OnPropertyChanged("ID_TIPO_PERSONA")
        End Set
    End Property

    Private _ID_TIPO_PERSONAOld As Int32
    Public Property ID_TIPO_PERSONAOld() As Int32
        Get
            Return _ID_TIPO_PERSONAOld
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_PERSONAOld = Value
        End Set
    End Property

    Private _fkID_TIPO_PERSONA As TIPO_PERSONA
    Public Property fkID_TIPO_PERSONA() As TIPO_PERSONA
        Get
            Return _fkID_TIPO_PERSONA
        End Get
        Set(ByVal Value As TIPO_PERSONA)
            _fkID_TIPO_PERSONA = Value
        End Set
    End Property
#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
