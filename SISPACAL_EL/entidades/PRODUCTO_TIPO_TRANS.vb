''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.PRODUCTO_TIPO_TRANS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row PRODUCTO_TIPO_TRANS en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	30/10/2018	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="PRODUCTO_TIPO_TRANS")> Public Class PRODUCTO_TIPO_TRANS
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_PRODTT As Int32, aID_PRODUCTO As Int32, aID_TIPOTRANS As Int32, aCANTIDAD_AUTO As Decimal, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime)
        Me._ID_PRODTT = aID_PRODTT
        Me._ID_PRODUCTO = aID_PRODUCTO
        Me._ID_TIPOTRANS = aID_TIPOTRANS
        Me._CANTIDAD_AUTO = aCANTIDAD_AUTO
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
    End Sub

#Region " Properties "

    Private _ID_PRODTT As Int32
    <Column(Name:="Id prodtt", Storage:="ID_PRODTT", DbType:="INT IDENTITY NOT NULL", Id:=True), _
     DataObjectField(True, True, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_PRODTT() As Int32
        Get
            Return _ID_PRODTT
        End Get
        Set(ByVal Value As Int32)
            _ID_PRODTT = Value
            OnPropertyChanged("ID_PRODTT")
        End Set
    End Property 

    Private _ID_PRODUCTO As Int32
    <Column(Name:="Id producto", Storage:="ID_PRODUCTO", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_PRODUCTO() As Int32
        Get
            Return _ID_PRODUCTO
        End Get
        Set(ByVal Value As Int32)
            _ID_PRODUCTO = Value
            OnPropertyChanged("ID_PRODUCTO")
        End Set
    End Property 

    Private _ID_PRODUCTOOld As Int32
    Public Property ID_PRODUCTOOld() As Int32
        Get
            Return _ID_PRODUCTOOld
        End Get
        Set(ByVal Value As Int32)
            _ID_PRODUCTOOld = Value
        End Set
    End Property 

    Private _ID_TIPOTRANS As Int32
    <Column(Name:="Id tipotrans", Storage:="ID_TIPOTRANS", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_TIPOTRANS() As Int32
        Get
            Return _ID_TIPOTRANS
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPOTRANS = Value
            OnPropertyChanged("ID_TIPOTRANS")
        End Set
    End Property 

    Private _ID_TIPOTRANSOld As Int32
    Public Property ID_TIPOTRANSOld() As Int32
        Get
            Return _ID_TIPOTRANSOld
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPOTRANSOld = Value
        End Set
    End Property 

    Private _CANTIDAD_AUTO As Decimal
    <Column(Name:="Cantidad auto", Storage:="CANTIDAD_AUTO", DbType:="NUMERIC(10,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)> _
    Public Property CANTIDAD_AUTO() As Decimal
        Get
            Return _CANTIDAD_AUTO
        End Get
        Set(ByVal Value As Decimal)
            _CANTIDAD_AUTO = Value
            OnPropertyChanged("CANTIDAD_AUTO")
        End Set
    End Property 

    Private _CANTIDAD_AUTOOld As Decimal
    Public Property CANTIDAD_AUTOOld() As Decimal
        Get
            Return _CANTIDAD_AUTOOld
        End Get
        Set(ByVal Value As Decimal)
            _CANTIDAD_AUTOOld = Value
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
