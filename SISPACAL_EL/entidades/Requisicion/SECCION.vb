''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.SECCION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row SECCION en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	14/06/2015	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="SECCION")> Public Class SECCION
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_SECCION As Int32, aCODIGO As String, aNOMBRE_SECCION As String, aVER_REQUISICION As Boolean, aVER_ORDEN_COMB As Boolean)
        Me._ID_SECCION = aID_SECCION
        Me._CODIGO = aCODIGO
        Me._NOMBRE_SECCION = aNOMBRE_SECCION
        Me._VER_REQUISICION = aVER_REQUISICION
        Me._VER_ORDEN_COMB = aVER_ORDEN_COMB
    End Sub

#Region " Properties "

    Private _ID_SECCION As Int32
    <Column(Name:="Id seccion", Storage:="ID_SECCION", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_SECCION() As Int32
        Get
            Return _ID_SECCION
        End Get
        Set(ByVal Value As Int32)
            _ID_SECCION = Value
            OnPropertyChanged("ID_SECCION")
        End Set
    End Property 

    Private _CODIGO As String
    <Column(Name:="Codigo", Storage:="CODIGO", DbType:="VARCHAR(2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 2)> _
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

    Private _NOMBRE_SECCION As String
    <Column(Name:="Nombre seccion", Storage:="NOMBRE_SECCION", DbType:="VARCHAR(100) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 100)> _
    Public Property NOMBRE_SECCION() As String
        Get
            Return _NOMBRE_SECCION
        End Get
        Set(ByVal Value As String)
            _NOMBRE_SECCION = Value
            OnPropertyChanged("NOMBRE_SECCION")
        End Set
    End Property 

    Private _NOMBRE_SECCIONOld As String
    Public Property NOMBRE_SECCIONOld() As String
        Get
            Return _NOMBRE_SECCIONOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_SECCIONOld = Value
        End Set
    End Property 

    Private _VER_REQUISICION As Boolean
    <Column(Name:="Ver requisicion", Storage:="VER_REQUISICION", DbType:="BIT", Id:=False), _
     DataObjectField(False, False, True, 1)> _
    Public Property VER_REQUISICION() As Boolean
        Get
            Return _VER_REQUISICION
        End Get
        Set(ByVal Value As Boolean)
            _VER_REQUISICION = Value
            OnPropertyChanged("VER_REQUISICION")
        End Set
    End Property 

    Private _VER_REQUISICIONOld As Boolean
    Public Property VER_REQUISICIONOld() As Boolean
        Get
            Return _VER_REQUISICIONOld
        End Get
        Set(ByVal Value As Boolean)
            _VER_REQUISICIONOld = Value
        End Set
    End Property 

    Private _VER_ORDEN_COMB As Boolean
    <Column(Name:="Ver orden comb", Storage:="VER_ORDEN_COMB", DbType:="BIT", Id:=False), _
     DataObjectField(False, False, True, 1)> _
    Public Property VER_ORDEN_COMB() As Boolean
        Get
            Return _VER_ORDEN_COMB
        End Get
        Set(ByVal Value As Boolean)
            _VER_ORDEN_COMB = Value
            OnPropertyChanged("VER_ORDEN_COMB")
        End Set
    End Property 

    Private _VER_ORDEN_COMBOld As Boolean
    Public Property VER_ORDEN_COMBOld() As Boolean
        Get
            Return _VER_ORDEN_COMBOld
        End Get
        Set(ByVal Value As Boolean)
            _VER_ORDEN_COMBOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
