''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.SALBODE_ENCA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row SALBODE_ENCA en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	15/08/2017	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="SALBODE_ENCA")> Public Class SALBODE_ENCA
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_SALBODE_ENCA As Int32, aID_ZAFRA As Int32, aNO_DOCUMENTO As Int32, aFECHA As DateTime, aUSUARIO_CREACION As String, aFECHA_CREACION As DateTime, aNUMS_SOLICITUDES As String, aRETIRO_PROD As Boolean)
        Me._ID_SALBODE_ENCA = aID_SALBODE_ENCA
        Me._ID_ZAFRA = aID_ZAFRA
        Me._NO_DOCUMENTO = aNO_DOCUMENTO
        Me._FECHA = aFECHA
        Me._USUARIO_CREACION = aUSUARIO_CREACION
        Me._FECHA_CREACION = aFECHA_CREACION
        Me._NUMS_SOLICITUDES = aNUMS_SOLICITUDES
        Me._RETIRO_PROD = aRETIRO_PROD
    End Sub

#Region " Properties "

    Private _ID_SALBODE_ENCA As Int32
    <Column(Name:="Id salbode enca", Storage:="ID_SALBODE_ENCA", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_SALBODE_ENCA() As Int32
        Get
            Return _ID_SALBODE_ENCA
        End Get
        Set(ByVal Value As Int32)
            _ID_SALBODE_ENCA = Value
            OnPropertyChanged("ID_SALBODE_ENCA")
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

    Private _NO_DOCUMENTO As Int32
    <Column(Name:="No documento", Storage:="NO_DOCUMENTO", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property NO_DOCUMENTO() As Int32
        Get
            Return _NO_DOCUMENTO
        End Get
        Set(ByVal Value As Int32)
            _NO_DOCUMENTO = Value
            OnPropertyChanged("NO_DOCUMENTO")
        End Set
    End Property 

    Private _NO_DOCUMENTOOld As Int32
    Public Property NO_DOCUMENTOOld() As Int32
        Get
            Return _NO_DOCUMENTOOld
        End Get
        Set(ByVal Value As Int32)
            _NO_DOCUMENTOOld = Value
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

    Private _USUARIO_CREACION As String
    <Column(Name:="Usuario creacion", Storage:="USUARIO_CREACION", DbType:="VARCHAR(100) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 100)> _
    Public Property USUARIO_CREACION() As String
        Get
            Return _USUARIO_CREACION
        End Get
        Set(ByVal Value As String)
            _USUARIO_CREACION = Value
            OnPropertyChanged("USUARIO_CREACION")
        End Set
    End Property 

    Private _USUARIO_CREACIONOld As String
    Public Property USUARIO_CREACIONOld() As String
        Get
            Return _USUARIO_CREACIONOld
        End Get
        Set(ByVal Value As String)
            _USUARIO_CREACIONOld = Value
        End Set
    End Property 

    Private _FECHA_CREACION As DateTime
    <Column(Name:="Fecha creacion", Storage:="FECHA_CREACION", DbType:="DATETIME NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
    Public Property FECHA_CREACION() As DateTime
        Get
            Return _FECHA_CREACION
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_CREACION = Value
            OnPropertyChanged("FECHA_CREACION")
        End Set
    End Property 

    Private _FECHA_CREACIONOld As DateTime
    Public Property FECHA_CREACIONOld() As DateTime
        Get
            Return _FECHA_CREACIONOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_CREACIONOld = Value
        End Set
    End Property 

    Private _NUMS_SOLICITUDES As String
    <Column(Name:="Nums solicitudes", Storage:="NUMS_SOLICITUDES", DbType:="VARCHAR(7000)", Id:=False), _
     DataObjectField(False, False, True, 7000)> _
    Public Property NUMS_SOLICITUDES() As String
        Get
            Return _NUMS_SOLICITUDES
        End Get
        Set(ByVal Value As String)
            _NUMS_SOLICITUDES = Value
            OnPropertyChanged("NUMS_SOLICITUDES")
        End Set
    End Property

    Private _NUMS_SOLICITUDESOld As String
    Public Property NUMS_SOLICITUDESOld() As String
        Get
            Return _NUMS_SOLICITUDESOld
        End Get
        Set(ByVal Value As String)
            _NUMS_SOLICITUDESOld = Value
        End Set
    End Property 

    Private _RETIRO_PROD As Boolean
    <Column(Name:="Retiro prod", Storage:="RETIRO_PROD", DbType:="BIT NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 1)> _
    Public Property RETIRO_PROD() As Boolean
        Get
            Return _RETIRO_PROD
        End Get
        Set(ByVal Value As Boolean)
            _RETIRO_PROD = Value
            OnPropertyChanged("RETIRO_PROD")
        End Set
    End Property 

    Private _RETIRO_PRODOld As Boolean
    Public Property RETIRO_PRODOld() As Boolean
        Get
            Return _RETIRO_PRODOld
        End Get
        Set(ByVal Value As Boolean)
            _RETIRO_PRODOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
