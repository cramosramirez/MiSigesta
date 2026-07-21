''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.PROVEEDOR_QUERQUEO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row PROVEEDOR_QUERQUEO en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	28/11/2022	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="PROVEEDOR_QUERQUEO")> Public Class PROVEEDOR_QUERQUEO
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_PROVEE_QQ As Int32, aID_TIPO_PERSONA As Int32, aCODISIS As String, aNOMBRES As String, aAPELLIDOS As String, aNIT As String, aDUI As String, aNRC As String, aDIRECCION As String, aTELEFONO As String, aCORREO As String, aCODI_DEPTO As String, aCODI_MUNI As String, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime)
        Me._ID_PROVEE_QQ = aID_PROVEE_QQ
        Me._ID_TIPO_PERSONA = aID_TIPO_PERSONA
        Me._CODISIS = aCODISIS
        Me._NOMBRES = aNOMBRES
        Me._APELLIDOS = aAPELLIDOS
        Me._NIT = aNIT
        Me._DUI = aDUI
        Me._NRC = aNRC
        Me._DIRECCION = aDIRECCION
        Me._TELEFONO = aTELEFONO
        Me._CORREO = aCORREO
        Me._CODI_DEPTO = aCODI_DEPTO
        Me._CODI_MUNI = aCODI_MUNI
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
    End Sub

#Region " Properties "

    Private _ID_PROVEE_QQ As Int32
    <Column(Name:="Id provee qq", Storage:="ID_PROVEE_QQ", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_PROVEE_QQ() As Int32
        Get
            Return _ID_PROVEE_QQ
        End Get
        Set(ByVal Value As Int32)
            _ID_PROVEE_QQ = Value
            OnPropertyChanged("ID_PROVEE_QQ")
        End Set
    End Property 

    Private _ID_TIPO_PERSONA As Int32
    <Column(Name:="Id tipo persona", Storage:="ID_TIPO_PERSONA", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
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

    Private _CODISIS As String
    <Column(Name:="Codisis", Storage:="CODISIS", DbType:="VARCHAR(20)", Id:=False), _
     DataObjectField(False, False, True, 20)> _
    Public Property CODISIS() As String
        Get
            Return _CODISIS
        End Get
        Set(ByVal Value As String)
            _CODISIS = Value
            OnPropertyChanged("CODISIS")
        End Set
    End Property 

    Private _CODISISOld As String
    Public Property CODISISOld() As String
        Get
            Return _CODISISOld
        End Get
        Set(ByVal Value As String)
            _CODISISOld = Value
        End Set
    End Property 

    Private _NOMBRES As String
    <Column(Name:="Nombres", Storage:="NOMBRES", DbType:="VARCHAR(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
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
    <Column(Name:="Apellidos", Storage:="APELLIDOS", DbType:="VARCHAR(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
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
    <Column(Name:="Nit", Storage:="NIT", DbType:="VARCHAR(14)", Id:=False), _
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

    Private _DUI As String
    <Column(Name:="Dui", Storage:="DUI", DbType:="VARCHAR(9)", Id:=False), _
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

    Private _NRC As String
    <Column(Name:="Nrc", Storage:="NRC", DbType:="VARCHAR(20)", Id:=False), _
     DataObjectField(False, False, True, 20)> _
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

    Private _TELEFONO As String
    <Column(Name:="Telefono", Storage:="TELEFONO", DbType:="VARCHAR(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
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

    Private _CORREO As String
    <Column(Name:="Correo", Storage:="CORREO", DbType:="VARCHAR(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
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

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
