''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.TRANSPORTISTA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row TRANSPORTISTA en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	15/12/2017	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="TRANSPORTISTA")> Public Class TRANSPORTISTA
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aCODTRANSPORT As Int32, aACTIVO As Boolean, aNOMBRES As String, aAPELLIDOS As String, aNIT As String, aCREDITO_FISCAL As String, aTELEFONO As String, aNOMBRE_CH As String, aDIRECCION As String, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime, aDUI As String, aES_INGENIO As Boolean, aNOCUENTA As String, aCOD_SIGASI As Int32, aCOD_COMBUST As Int32, aCODIBANCO As Int32, aNUM_CUENTA As String, aES_CTA_CORRIENTE As Boolean, aPROFESION As String, aFECHA_NACIMIENTO As DateTime, aCODI_DEPTO As String, aCODI_MUNI As String, aCORREO As String, aID_TIPO_PERSONA As Int32, aACTIVIDAD As String)
        Me._CODTRANSPORT = aCODTRANSPORT
        Me._ACTIVO = aACTIVO
        Me._NOMBRES = aNOMBRES
        Me._APELLIDOS = aAPELLIDOS
        Me._NIT = aNIT
        Me._CREDITO_FISCAL = aCREDITO_FISCAL
        Me._TELEFONO = aTELEFONO
        Me._NOMBRE_CH = aNOMBRE_CH
        Me._DIRECCION = aDIRECCION
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
        Me._DUI = aDUI
        Me._ES_INGENIO = aES_INGENIO
        Me._NOCUENTA = aNOCUENTA
        Me._COD_SIGASI = aCOD_SIGASI
        Me._COD_COMBUST = aCOD_COMBUST
        Me._CODIBANCO = aCODIBANCO
        Me._NUM_CUENTA = aNUM_CUENTA
        Me._ES_CTA_CORRIENTE = aES_CTA_CORRIENTE
        Me._PROFESION = aPROFESION
        Me._FECHA_NACIMIENTO = aFECHA_NACIMIENTO
        Me._CODI_DEPTO = aCODI_DEPTO
        Me._CODI_MUNI = aCODI_MUNI
        Me._CORREO = aCORREO
        Me._ID_TIPO_PERSONA = aID_TIPO_PERSONA
        Me._ACTIVIDAD = aACTIVIDAD
    End Sub

#Region " Properties "

    Private _CODTRANSPORT As Int32
    <Column(Name:="Codtransport", Storage:="CODTRANSPORT", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property CODTRANSPORT() As Int32
        Get
            Return _CODTRANSPORT
        End Get
        Set(ByVal Value As Int32)
            _CODTRANSPORT = Value
            OnPropertyChanged("CODTRANSPORT")
        End Set
    End Property 

    Private _ACTIVO As Boolean
    <Column(Name:="Activo", Storage:="ACTIVO", DbType:="BIT NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 1)> _
    Public Property ACTIVO() As Boolean
        Get
            Return _ACTIVO
        End Get
        Set(ByVal Value As Boolean)
            _ACTIVO = Value
            OnPropertyChanged("ACTIVO")
        End Set
    End Property 

    Private _ACTIVOOld As Boolean
    Public Property ACTIVOOld() As Boolean
        Get
            Return _ACTIVOOld
        End Get
        Set(ByVal Value As Boolean)
            _ACTIVOOld = Value
        End Set
    End Property 

    Private _NOMBRES As String
    <Column(Name:="Nombres", Storage:="NOMBRES", DbType:="VARCHAR(60) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 60)> _
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

    Private _APELLIDOS As String
    <Column(Name:="Apellidos", Storage:="APELLIDOS", DbType:="VARCHAR(60)", Id:=False), _
     DataObjectField(False, False, True, 60)> _
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

    Private _NIT As String
    <Column(Name:="Nit", Storage:="NIT", DbType:="CHAR(14)", Id:=False), _
     DataObjectField(False, False, True, 14)> _
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

    Private _CREDITO_FISCAL As String
    <Column(Name:="Credito fiscal", Storage:="CREDITO_FISCAL", DbType:="VARCHAR(20)", Id:=False), _
     DataObjectField(False, False, True, 20)> _
    Public Property CREDITO_FISCAL() As String
        Get
            Return _CREDITO_FISCAL
        End Get
        Set(ByVal Value As String)
            _CREDITO_FISCAL = Value
            OnPropertyChanged("CREDITO_FISCAL")
        End Set
    End Property 

    Private _CREDITO_FISCALOld As String
    Public Property CREDITO_FISCALOld() As String
        Get
            Return _CREDITO_FISCALOld
        End Get
        Set(ByVal Value As String)
            _CREDITO_FISCALOld = Value
        End Set
    End Property 

    Private _TELEFONO As String
    <Column(Name:="Telefono", Storage:="TELEFONO", DBType:="VARCHAR(100)", Id:=False),
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

    Private _NOMBRE_CH As String
    <Column(Name:="Nombre ch", Storage:="NOMBRE_CH", DbType:="VARCHAR(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
    Public Property NOMBRE_CH() As String
        Get
            Return _NOMBRE_CH
        End Get
        Set(ByVal Value As String)
            _NOMBRE_CH = Value
            OnPropertyChanged("NOMBRE_CH")
        End Set
    End Property 

    Private _NOMBRE_CHOld As String
    Public Property NOMBRE_CHOld() As String
        Get
            Return _NOMBRE_CHOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_CHOld = Value
        End Set
    End Property 

    Private _DIRECCION As String
    <Column(Name:="Direccion", Storage:="DIRECCION", DbType:="VARCHAR(300)", Id:=False), _
     DataObjectField(False, False, True, 300)> _
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

    Private _USUARIO_CREA As String
    <Column(Name:="Usuario crea", Storage:="USUARIO_CREA", DbType:="VARCHAR(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
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
    <Column(Name:="Usuario act", Storage:="USUARIO_ACT", DbType:="VARCHAR(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
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

    Private _DUI As String
    <Column(Name:="Dui", Storage:="DUI", DbType:="CHAR(9)", Id:=False), _
     DataObjectField(False, False, True, 9)> _
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

    Private _ES_INGENIO As Boolean
    <Column(Name:="Es ingenio", Storage:="ES_INGENIO", DbType:="BIT", Id:=False), _
     DataObjectField(False, False, True, 1)> _
    Public Property ES_INGENIO() As Boolean
        Get
            Return _ES_INGENIO
        End Get
        Set(ByVal Value As Boolean)
            _ES_INGENIO = Value
            OnPropertyChanged("ES_INGENIO")
        End Set
    End Property 

    Private _ES_INGENIOOld As Boolean
    Public Property ES_INGENIOOld() As Boolean
        Get
            Return _ES_INGENIOOld
        End Get
        Set(ByVal Value As Boolean)
            _ES_INGENIOOld = Value
        End Set
    End Property 

    Private _NOCUENTA As String
    <Column(Name:="Nocuenta", Storage:="NOCUENTA", DbType:="VARCHAR(20)", Id:=False), _
     DataObjectField(False, False, True, 20)> _
    Public Property NOCUENTA() As String
        Get
            Return _NOCUENTA
        End Get
        Set(ByVal Value As String)
            _NOCUENTA = Value
            OnPropertyChanged("NOCUENTA")
        End Set
    End Property 

    Private _NOCUENTAOld As String
    Public Property NOCUENTAOld() As String
        Get
            Return _NOCUENTAOld
        End Get
        Set(ByVal Value As String)
            _NOCUENTAOld = Value
        End Set
    End Property 

    Private _COD_SIGASI As Int32
    <Column(Name:="Cod sigasi", Storage:="COD_SIGASI", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property COD_SIGASI() As Int32
        Get
            Return _COD_SIGASI
        End Get
        Set(ByVal Value As Int32)
            _COD_SIGASI = Value
            OnPropertyChanged("COD_SIGASI")
        End Set
    End Property 

    Private _COD_SIGASIOld As Int32
    Public Property COD_SIGASIOld() As Int32
        Get
            Return _COD_SIGASIOld
        End Get
        Set(ByVal Value As Int32)
            _COD_SIGASIOld = Value
        End Set
    End Property 

    Private _COD_COMBUST As Int32
    <Column(Name:="Cod combust", Storage:="COD_COMBUST", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property COD_COMBUST() As Int32
        Get
            Return _COD_COMBUST
        End Get
        Set(ByVal Value As Int32)
            _COD_COMBUST = Value
            OnPropertyChanged("COD_COMBUST")
        End Set
    End Property 

    Private _COD_COMBUSTOld As Int32
    Public Property COD_COMBUSTOld() As Int32
        Get
            Return _COD_COMBUSTOld
        End Get
        Set(ByVal Value As Int32)
            _COD_COMBUSTOld = Value
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

    Private _fkCODIBANCO As BANCOS
    Public Property fkCODIBANCO() As BANCOS
        Get
            Return _fkCODIBANCO
        End Get
        Set(ByVal Value As BANCOS)
            _fkCODIBANCO = Value
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

    Private _PROFESION As String
    <Column(Name:="Profesion", Storage:="PROFESION", DbType:="VARCHAR(150)", Id:=False), _
     DataObjectField(False, False, True, 150)> _
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

    Private _FECHA_NACIMIENTO As DateTime
    <Column(Name:="Fecha nacimiento", Storage:="FECHA_NACIMIENTO", DBType:="DATE", Id:=False),
     DataObjectField(False, False, True)>
    Public Property FECHA_NACIMIENTO() As DateTime
        Get
            Return _FECHA_NACIMIENTO
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_NACIMIENTO = Value
            OnPropertyChanged("FECHA_NACIMIENTO")
        End Set
    End Property

    Private _FECHA_NACIMIENTOOld As DateTime
    Public Property FECHA_NACIMIENTOOld() As DateTime
        Get
            Return _FECHA_NACIMIENTOOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_NACIMIENTOOld = Value
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

    Private _ACTIVIDAD As String
    <Column(Name:="Actividad", Storage:="ACTIVIDAD", DBType:="VARCHAR(300)", Id:=False),
     DataObjectField(False, False, True, 300)>
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

    Private _ACTIVIDAD2 As String
    <Column(Name:="ACTIVIDAD2", Storage:="ACTIVIDAD2", DBType:="VARCHAR(300)", Id:=False),
     DataObjectField(False, False, True, 300)>
    Public Property ACTIVIDAD2() As String
        Get
            Return _ACTIVIDAD2
        End Get
        Set(ByVal Value As String)
            _ACTIVIDAD2 = Value
            OnPropertyChanged("ACTIVIDAD2")
        End Set
    End Property

    Private _ACTIVIDAD2Old As String
    Public Property ACTIVIDAD2Old() As String
        Get
            Return _ACTIVIDAD2Old
        End Get
        Set(ByVal Value As String)
            _ACTIVIDAD2Old = Value
        End Set
    End Property

    Private _ACTIVIDAD3 As String
    <Column(Name:="ACTIVIDAD3", Storage:="ACTIVIDAD3", DBType:="VARCHAR(300)", Id:=False),
     DataObjectField(False, False, True, 300)>
    Public Property ACTIVIDAD3() As String
        Get
            Return _ACTIVIDAD3
        End Get
        Set(ByVal Value As String)
            _ACTIVIDAD3 = Value
            OnPropertyChanged("ACTIVIDAD3")
        End Set
    End Property

    Private _ACTIVIDAD3Old As String
    Public Property ACTIVIDAD3Old() As String
        Get
            Return _ACTIVIDAD3Old
        End Get
        Set(ByVal Value As String)
            _ACTIVIDAD3Old = Value
        End Set
    End Property
#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
