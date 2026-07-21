''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.BASE_PROVEEDORES_MH
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row BASE_PROVEEDORES_MH en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	13/10/2022	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="BASE_PROVEEDORES_MH")> Public Class BASE_PROVEEDORES_MH
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_BASE_PROVEE As Int32, aDUI As String, aNIT As String, aNOMBRES As String, aAPELLIDOS As String, aTELEFONO As String, aDIRECCION As String, aCODI_DEPTO As String, aCODI_MUNI As String, aCORREO As String, aNRC As String, aID_TIPO_PERSONA As Int32, aACTIVIDAD As String)
        Me._ID_BASE_PROVEE = aID_BASE_PROVEE
        Me._DUI = aDUI
        Me._NIT = aNIT
        Me._NOMBRES = aNOMBRES
        Me._APELLIDOS = aAPELLIDOS
        Me._TELEFONO = aTELEFONO
        Me._DIRECCION = aDIRECCION
        Me._CODI_DEPTO = aCODI_DEPTO
        Me._CODI_MUNI = aCODI_MUNI
        Me._CORREO = aCORREO
        Me._NRC = aNRC
        Me._ID_TIPO_PERSONA = aID_TIPO_PERSONA
        Me._ACTIVIDAD = aACTIVIDAD
    End Sub

#Region " Properties "

    Private _ID_BASE_PROVEE As Int32
    <Column(Name:="Id base provee", Storage:="ID_BASE_PROVEE", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_BASE_PROVEE() As Int32
        Get
            Return _ID_BASE_PROVEE
        End Get
        Set(ByVal Value As Int32)
            _ID_BASE_PROVEE = Value
            OnPropertyChanged("ID_BASE_PROVEE")
        End Set
    End Property 

    Private _DUI As String
    <Column(Name:="Dui", Storage:="DUI", DbType:="VARCHAR(15)", Id:=False), _
     DataObjectField(False, False, True, 15)> _
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
    <Column(Name:="Nit", Storage:="NIT", DbType:="VARCHAR(20)", Id:=False), _
     DataObjectField(False, False, True, 20)> _
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

    Private _NOMBRES As String
    <Column(Name:="Nombres", Storage:="NOMBRES", DbType:="VARCHAR(150)", Id:=False), _
     DataObjectField(False, False, True, 150)> _
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
    <Column(Name:="Apellidos", Storage:="APELLIDOS", DbType:="VARCHAR(150)", Id:=False), _
     DataObjectField(False, False, True, 150)> _
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

    Private _DIRECCION As String
    <Column(Name:="Direccion", Storage:="DIRECCION", DbType:="VARCHAR(250)", Id:=False), _
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

    Private _CORREO As String
    <Column(Name:="Correo", Storage:="CORREO", DbType:="NVARCHAR(400)", Id:=False), _
     DataObjectField(False, False, True, 400)> _
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

    Private _NRC As String
    <Column(Name:="Nrc", Storage:="NRC", DbType:="VARCHAR(15)", Id:=False), _
     DataObjectField(False, False, True, 15)> _
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

    Private _ACTIVIDAD As String
    <Column(Name:="Actividad", Storage:="ACTIVIDAD", DbType:="VARCHAR(300)", Id:=False), _
     DataObjectField(False, False, True, 300)> _
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

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
