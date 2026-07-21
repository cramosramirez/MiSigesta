''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.PERIODOREQ
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row PERIODOREQ en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	14/05/2015	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="PERIODOREQ")> Public Class PERIODOREQ
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_PERIODOREQ As Int32, aDESCRIP_PERIODO As String, aACTIVO As Boolean, aUSUARIO_CREACION As String, aFECHA_CREACION As DateTime, aUSUARIO_CIERRE As String, aFECHA_CIERRE As DateTime, aFECHA_INICIO As DateTime, aFECHA_FIN As DateTime, aCODIGO As String)
        Me._ID_PERIODOREQ = aID_PERIODOREQ
        Me._DESCRIP_PERIODO = aDESCRIP_PERIODO
        Me._ACTIVO = aACTIVO
        Me._USUARIO_CREACION = aUSUARIO_CREACION
        Me._FECHA_CREACION = aFECHA_CREACION
        Me._USUARIO_CIERRE = aUSUARIO_CIERRE
        Me._FECHA_CIERRE = aFECHA_CIERRE
        Me._FECHA_INICIO = aFECHA_INICIO
        Me._FECHA_FIN = aFECHA_FIN
        Me._CODIGO = aCODIGO
    End Sub

#Region " Properties "

    Private _ID_PERIODOREQ As Int32
    <Column(Name:="Id periodoreq", Storage:="ID_PERIODOREQ", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_PERIODOREQ() As Int32
        Get
            Return _ID_PERIODOREQ
        End Get
        Set(ByVal Value As Int32)
            _ID_PERIODOREQ = Value
            OnPropertyChanged("ID_PERIODOREQ")
        End Set
    End Property 

    Private _DESCRIP_PERIODO As String
    <Column(Name:="Descrip periodo", Storage:="DESCRIP_PERIODO", DbType:="VARCHAR(500) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 500)> _
    Public Property DESCRIP_PERIODO() As String
        Get
            Return _DESCRIP_PERIODO
        End Get
        Set(ByVal Value As String)
            _DESCRIP_PERIODO = Value
            OnPropertyChanged("DESCRIP_PERIODO")
        End Set
    End Property 

    Private _DESCRIP_PERIODOOld As String
    Public Property DESCRIP_PERIODOOld() As String
        Get
            Return _DESCRIP_PERIODOOld
        End Get
        Set(ByVal Value As String)
            _DESCRIP_PERIODOOld = Value
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

    Private _USUARIO_CIERRE As String
    <Column(Name:="Usuario cierre", Storage:="USUARIO_CIERRE", DbType:="VARCHAR(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
    Public Property USUARIO_CIERRE() As String
        Get
            Return _USUARIO_CIERRE
        End Get
        Set(ByVal Value As String)
            _USUARIO_CIERRE = Value
            OnPropertyChanged("USUARIO_CIERRE")
        End Set
    End Property 

    Private _USUARIO_CIERREOld As String
    Public Property USUARIO_CIERREOld() As String
        Get
            Return _USUARIO_CIERREOld
        End Get
        Set(ByVal Value As String)
            _USUARIO_CIERREOld = Value
        End Set
    End Property 

    Private _FECHA_CIERRE As DateTime
    <Column(Name:="Fecha cierre", Storage:="FECHA_CIERRE", DbType:="DATETIME", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_CIERRE() As DateTime
        Get
            Return _FECHA_CIERRE
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_CIERRE = Value
            OnPropertyChanged("FECHA_CIERRE")
        End Set
    End Property 

    Private _FECHA_CIERREOld As DateTime
    Public Property FECHA_CIERREOld() As DateTime
        Get
            Return _FECHA_CIERREOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_CIERREOld = Value
        End Set
    End Property 

    Private _FECHA_INICIO As DateTime
    <Column(Name:="Fecha inicio", Storage:="FECHA_INICIO", DbType:="DATETIME", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_INICIO() As DateTime
        Get
            Return _FECHA_INICIO
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_INICIO = Value
            OnPropertyChanged("FECHA_INICIO")
        End Set
    End Property 

    Private _FECHA_INICIOOld As DateTime
    Public Property FECHA_INICIOOld() As DateTime
        Get
            Return _FECHA_INICIOOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_INICIOOld = Value
        End Set
    End Property 

    Private _FECHA_FIN As DateTime
    <Column(Name:="Fecha fin", Storage:="FECHA_FIN", DbType:="DATETIME", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_FIN() As DateTime
        Get
            Return _FECHA_FIN
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_FIN = Value
            OnPropertyChanged("FECHA_FIN")
        End Set
    End Property 

    Private _FECHA_FINOld As DateTime
    Public Property FECHA_FINOld() As DateTime
        Get
            Return _FECHA_FINOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_FINOld = Value
        End Set
    End Property 

    Private _CODIGO As String
    <Column(Name:="Codigo", Storage:="CODIGO", DbType:="VARCHAR(20)", Id:=False), _
     DataObjectField(False, False, True, 20)> _
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

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
