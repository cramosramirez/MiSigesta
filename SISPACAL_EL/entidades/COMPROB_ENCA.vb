''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.COMPROB_ENCA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row COMPROB_ENCA en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/11/2023	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="COMPROB_ENCA")> Public Class COMPROB_ENCA
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_COMPROB_ENCA As Int32, aID_ZAFRA As Int32, aID_CATORCENA As Int32, aID_TIPO_PLANILLA As Int32, aID_TIPO_COMPROB As Int32, aSERIE As String, aNUM_DOCTO As Int32, aESTADO As String, aFECHA As DateTime, aCODIGO As String, aNOMBRES As String, aAPELLIDOS As String, aDIRECCION As String, aCODI_DEPTO As String, aCODI_MUNI As String, aNIT As String, aDUI As String, aNRC As String, aGIRO As String, aCORREO As String, aSUMAS As Decimal, aIVA As Decimal, aRENTA As Decimal, aSUBTOTAL As Decimal, aIVA_RETENIDO As Decimal, aTOTAL As Decimal, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aID_PLANILLA_COMPROB As Int32)
        Me._ID_COMPROB_ENCA = aID_COMPROB_ENCA
        Me._ID_ZAFRA = aID_ZAFRA
        Me._ID_CATORCENA = aID_CATORCENA
        Me._ID_TIPO_PLANILLA = aID_TIPO_PLANILLA
        Me._ID_TIPO_COMPROB = aID_TIPO_COMPROB
        Me._SERIE = aSERIE
        Me._NUM_DOCTO = aNUM_DOCTO
        Me._ESTADO = aESTADO
        Me._FECHA = aFECHA
        Me._CODIGO = aCODIGO
        Me._NOMBRES = aNOMBRES
        Me._APELLIDOS = aAPELLIDOS
        Me._DIRECCION = aDIRECCION
        Me._CODI_DEPTO = aCODI_DEPTO
        Me._CODI_MUNI = aCODI_MUNI
        Me._NIT = aNIT
        Me._DUI = aDUI
        Me._NRC = aNRC
        Me._GIRO = aGIRO
        Me._CORREO = aCORREO
        Me._SUMAS = aSUMAS
        Me._IVA = aIVA
        Me._RENTA = aRENTA
        Me._SUBTOTAL = aSUBTOTAL
        Me._IVA_RETENIDO = aIVA_RETENIDO
        Me._TOTAL = aTOTAL
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._ID_PLANILLA_COMPROB = aID_PLANILLA_COMPROB
    End Sub

#Region " Properties "

    Private _ID_COMPROB_ENCA As Int32
    <Column(Name:="Id comprob enca", Storage:="ID_COMPROB_ENCA", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_COMPROB_ENCA() As Int32
        Get
            Return _ID_COMPROB_ENCA
        End Get
        Set(ByVal Value As Int32)
            _ID_COMPROB_ENCA = Value
            OnPropertyChanged("ID_COMPROB_ENCA")
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

    Private _fkID_ZAFRA As ZAFRA
    Public Property fkID_ZAFRA() As ZAFRA
        Get
            Return _fkID_ZAFRA
        End Get
        Set(ByVal Value As ZAFRA)
            _fkID_ZAFRA = Value
        End Set
    End Property 

    Private _ID_CATORCENA As Int32
    <Column(Name:="Id catorcena", Storage:="ID_CATORCENA", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_CATORCENA() As Int32
        Get
            Return _ID_CATORCENA
        End Get
        Set(ByVal Value As Int32)
            _ID_CATORCENA = Value
            OnPropertyChanged("ID_CATORCENA")
        End Set
    End Property 

    Private _ID_CATORCENAOld As Int32
    Public Property ID_CATORCENAOld() As Int32
        Get
            Return _ID_CATORCENAOld
        End Get
        Set(ByVal Value As Int32)
            _ID_CATORCENAOld = Value
        End Set
    End Property 

    Private _fkID_CATORCENA As CATORCENA_ZAFRA
    Public Property fkID_CATORCENA() As CATORCENA_ZAFRA
        Get
            Return _fkID_CATORCENA
        End Get
        Set(ByVal Value As CATORCENA_ZAFRA)
            _fkID_CATORCENA = Value
        End Set
    End Property 

    Private _ID_TIPO_PLANILLA As Int32
    <Column(Name:="Id tipo planilla", Storage:="ID_TIPO_PLANILLA", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_TIPO_PLANILLA() As Int32
        Get
            Return _ID_TIPO_PLANILLA
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_PLANILLA = Value
            OnPropertyChanged("ID_TIPO_PLANILLA")
        End Set
    End Property 

    Private _ID_TIPO_PLANILLAOld As Int32
    Public Property ID_TIPO_PLANILLAOld() As Int32
        Get
            Return _ID_TIPO_PLANILLAOld
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_PLANILLAOld = Value
        End Set
    End Property 

    Private _fkID_TIPO_PLANILLA As TIPO_PLANILLA
    Public Property fkID_TIPO_PLANILLA() As TIPO_PLANILLA
        Get
            Return _fkID_TIPO_PLANILLA
        End Get
        Set(ByVal Value As TIPO_PLANILLA)
            _fkID_TIPO_PLANILLA = Value
        End Set
    End Property 

    Private _ID_TIPO_COMPROB As Int32
    <Column(Name:="Id tipo comprob", Storage:="ID_TIPO_COMPROB", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_TIPO_COMPROB() As Int32
        Get
            Return _ID_TIPO_COMPROB
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_COMPROB = Value
            OnPropertyChanged("ID_TIPO_COMPROB")
        End Set
    End Property 

    Private _ID_TIPO_COMPROBOld As Int32
    Public Property ID_TIPO_COMPROBOld() As Int32
        Get
            Return _ID_TIPO_COMPROBOld
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_COMPROBOld = Value
        End Set
    End Property 

    Private _fkID_TIPO_COMPROB As TIPO_COMPROB
    Public Property fkID_TIPO_COMPROB() As TIPO_COMPROB
        Get
            Return _fkID_TIPO_COMPROB
        End Get
        Set(ByVal Value As TIPO_COMPROB)
            _fkID_TIPO_COMPROB = Value
        End Set
    End Property 

    Private _SERIE As String
    <Column(Name:="Serie", Storage:="SERIE", DbType:="VARCHAR(30) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 30)> _
    Public Property SERIE() As String
        Get
            Return _SERIE
        End Get
        Set(ByVal Value As String)
            _SERIE = Value
            OnPropertyChanged("SERIE")
        End Set
    End Property 

    Private _SERIEOld As String
    Public Property SERIEOld() As String
        Get
            Return _SERIEOld
        End Get
        Set(ByVal Value As String)
            _SERIEOld = Value
        End Set
    End Property 

    Private _NUM_DOCTO As Int32
    <Column(Name:="Num docto", Storage:="NUM_DOCTO", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property NUM_DOCTO() As Int32
        Get
            Return _NUM_DOCTO
        End Get
        Set(ByVal Value As Int32)
            _NUM_DOCTO = Value
            OnPropertyChanged("NUM_DOCTO")
        End Set
    End Property 

    Private _NUM_DOCTOOld As Int32
    Public Property NUM_DOCTOOld() As Int32
        Get
            Return _NUM_DOCTOOld
        End Get
        Set(ByVal Value As Int32)
            _NUM_DOCTOOld = Value
        End Set
    End Property 

    Private _ESTADO As String
    <Column(Name:="Estado", Storage:="ESTADO", DbType:="CHAR(1) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 1)> _
    Public Property ESTADO() As String
        Get
            Return _ESTADO
        End Get
        Set(ByVal Value As String)
            _ESTADO = Value
            OnPropertyChanged("ESTADO")
        End Set
    End Property 

    Private _ESTADOOld As String
    Public Property ESTADOOld() As String
        Get
            Return _ESTADOOld
        End Get
        Set(ByVal Value As String)
            _ESTADOOld = Value
        End Set
    End Property 

    Private _FECHA As DateTime
    <Column(Name:="Fecha", Storage:="FECHA", DbType:="DATETIME NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
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

    Private _CODIGO As String
    <Column(Name:="Codigo", Storage:="CODIGO", DbType:="VARCHAR(20) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 20)> _
    Public Property CODIGO() As String
        Get
            Return _CODIGO
        End Get
        Set(ByVal Value As String)
            _CODIGO = Value
            OnPropertyChanged("CODIGO")
        End Set
    End Property 

    Private _CODIGOOld As String
    Public Property CODIGOOld() As String
        Get
            Return _CODIGOOld
        End Get
        Set(ByVal Value As String)
            _CODIGOOld = Value
        End Set
    End Property 

    Private _NOMBRES As String
    <Column(Name:="Nombres", Storage:="NOMBRES", DbType:="VARCHAR(100) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 100)> _
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
    <Column(Name:="Apellidos", Storage:="APELLIDOS", DbType:="VARCHAR(100) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 100)> _
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

    Private _DIRECCION As String
    <Column(Name:="Direccion", Storage:="DIRECCION", DbType:="VARCHAR(200) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 200)> _
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

    Private _CODI_DEPTO As String
    <Column(Name:="Codi depto", Storage:="CODI_DEPTO", DbType:="CHAR(2)", Id:=False), _
     DataObjectField(False, False, True, 2)> _
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
    <Column(Name:="Codi muni", Storage:="CODI_MUNI", DbType:="CHAR(2)", Id:=False), _
     DataObjectField(False, False, True, 2)> _
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

    Private _NIT As String
    <Column(Name:="Nit", Storage:="NIT", DbType:="VARCHAR(20) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 20)> _
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

    Private _DUI As String
    <Column(Name:="Dui", Storage:="DUI", DbType:="VARCHAR(20) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 20)> _
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

    Private _NRC As String
    <Column(Name:="Nrc", Storage:="NRC", DbType:="VARCHAR(10) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 10)> _
    Public Property NRC() As String
        Get
            Return _NRC
        End Get
        Set(ByVal Value As String)
            _NRC = Value
            OnPropertyChanged("NRC")
        End Set
    End Property 

    Private _NRCOld As String
    Public Property NRCOld() As String
        Get
            Return _NRCOld
        End Get
        Set(ByVal Value As String)
            _NRCOld = Value
        End Set
    End Property 

    Private _GIRO As String
    <Column(Name:="Giro", Storage:="GIRO", DbType:="VARCHAR(500) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 500)> _
    Public Property GIRO() As String
        Get
            Return _GIRO
        End Get
        Set(ByVal Value As String)
            _GIRO = Value
            OnPropertyChanged("GIRO")
        End Set
    End Property 

    Private _GIROOld As String
    Public Property GIROOld() As String
        Get
            Return _GIROOld
        End Get
        Set(ByVal Value As String)
            _GIROOld = Value
        End Set
    End Property 

    Private _CORREO As String
    <Column(Name:="Correo", Storage:="CORREO", DbType:="VARCHAR(100) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 100)> _
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

    Private _SUMAS As Decimal
    <Column(Name:="Sumas", Storage:="SUMAS", DbType:="NUMERIC(20,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)> _
    Public Property SUMAS() As Decimal
        Get
            Return _SUMAS
        End Get
        Set(ByVal Value As Decimal)
            _SUMAS = Value
            OnPropertyChanged("SUMAS")
        End Set
    End Property 

    Private _SUMASOld As Decimal
    Public Property SUMASOld() As Decimal
        Get
            Return _SUMASOld
        End Get
        Set(ByVal Value As Decimal)
            _SUMASOld = Value
        End Set
    End Property 

    Private _IVA As Decimal
    <Column(Name:="Iva", Storage:="IVA", DbType:="NUMERIC(20,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)> _
    Public Property IVA() As Decimal
        Get
            Return _IVA
        End Get
        Set(ByVal Value As Decimal)
            _IVA = Value
            OnPropertyChanged("IVA")
        End Set
    End Property 

    Private _IVAOld As Decimal
    Public Property IVAOld() As Decimal
        Get
            Return _IVAOld
        End Get
        Set(ByVal Value As Decimal)
            _IVAOld = Value
        End Set
    End Property 

    Private _RENTA As Decimal
    <Column(Name:="Renta", Storage:="RENTA", DbType:="NUMERIC(20,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)> _
    Public Property RENTA() As Decimal
        Get
            Return _RENTA
        End Get
        Set(ByVal Value As Decimal)
            _RENTA = Value
            OnPropertyChanged("RENTA")
        End Set
    End Property 

    Private _RENTAOld As Decimal
    Public Property RENTAOld() As Decimal
        Get
            Return _RENTAOld
        End Get
        Set(ByVal Value As Decimal)
            _RENTAOld = Value
        End Set
    End Property 

    Private _SUBTOTAL As Decimal
    <Column(Name:="Subtotal", Storage:="SUBTOTAL", DbType:="NUMERIC(20,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)> _
    Public Property SUBTOTAL() As Decimal
        Get
            Return _SUBTOTAL
        End Get
        Set(ByVal Value As Decimal)
            _SUBTOTAL = Value
            OnPropertyChanged("SUBTOTAL")
        End Set
    End Property 

    Private _SUBTOTALOld As Decimal
    Public Property SUBTOTALOld() As Decimal
        Get
            Return _SUBTOTALOld
        End Get
        Set(ByVal Value As Decimal)
            _SUBTOTALOld = Value
        End Set
    End Property 

    Private _IVA_RETENIDO As Decimal
    <Column(Name:="Iva retenido", Storage:="IVA_RETENIDO", DbType:="NUMERIC(20,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)> _
    Public Property IVA_RETENIDO() As Decimal
        Get
            Return _IVA_RETENIDO
        End Get
        Set(ByVal Value As Decimal)
            _IVA_RETENIDO = Value
            OnPropertyChanged("IVA_RETENIDO")
        End Set
    End Property 

    Private _IVA_RETENIDOOld As Decimal
    Public Property IVA_RETENIDOOld() As Decimal
        Get
            Return _IVA_RETENIDOOld
        End Get
        Set(ByVal Value As Decimal)
            _IVA_RETENIDOOld = Value
        End Set
    End Property 

    Private _TOTAL As Decimal
    <Column(Name:="Total", Storage:="TOTAL", DbType:="NUMERIC(20,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)> _
    Public Property TOTAL() As Decimal
        Get
            Return _TOTAL
        End Get
        Set(ByVal Value As Decimal)
            _TOTAL = Value
            OnPropertyChanged("TOTAL")
        End Set
    End Property 

    Private _TOTALOld As Decimal
    Public Property TOTALOld() As Decimal
        Get
            Return _TOTALOld
        End Get
        Set(ByVal Value As Decimal)
            _TOTALOld = Value
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

    Private _ID_PLANILLA_COMPROB As Int32
    <Column(Name:="Id planilla comprob", Storage:="ID_PLANILLA_COMPROB", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_PLANILLA_COMPROB() As Int32
        Get
            Return _ID_PLANILLA_COMPROB
        End Get
        Set(ByVal Value As Int32)
            _ID_PLANILLA_COMPROB = Value
            OnPropertyChanged("ID_PLANILLA_COMPROB")
        End Set
    End Property 

    Private _ID_PLANILLA_COMPROBOld As Int32
    Public Property ID_PLANILLA_COMPROBOld() As Int32
        Get
            Return _ID_PLANILLA_COMPROBOld
        End Get
        Set(ByVal Value As Int32)
            _ID_PLANILLA_COMPROBOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
