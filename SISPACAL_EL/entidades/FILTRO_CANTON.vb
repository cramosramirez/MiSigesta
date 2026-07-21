''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.FILTRO_CANTON
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row FILTRO_CANTON en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	12/09/2014	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="FILTRO_CANTON")> Public Class FILTRO_CANTON
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_FILTRO_CANTON As Int32, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aCODI_DEPTO As String, aCODI_MUNI As String, aCODI_CANTON As String)
        Me._ID_FILTRO_CANTON = aID_FILTRO_CANTON
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._CODI_DEPTO = aCODI_DEPTO
        Me._CODI_MUNI = aCODI_MUNI
        Me._CODI_CANTON = aCODI_CANTON
    End Sub

#Region " Properties "

    Private _ID_FILTRO_CANTON As Int32
    <Column(Name:="Id filtro canton", Storage:="ID_FILTRO_CANTON", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_FILTRO_CANTON() As Int32
        Get
            Return _ID_FILTRO_CANTON
        End Get
        Set(ByVal Value As Int32)
            _ID_FILTRO_CANTON = Value
            OnPropertyChanged("ID_FILTRO_CANTON")
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

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
