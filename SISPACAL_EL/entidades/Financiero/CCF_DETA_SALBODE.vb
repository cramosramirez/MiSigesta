''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.CCF_DETA_SALBODE
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row CCF_DETA_SALBODE en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	05/09/2017	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="CCF_DETA_SALBODE")> Public Class CCF_DETA_SALBODE
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_CCF_DETA_SAL As Int32, aID_CCF_ENCA As Int32, aID_SALBODE_DETA As Int32, aID_SOLICITUD As Int32, aID_PRODUCTO As Int32, aNOMBRE_PRODUCTO As String, aPRESENTACION As String, aCANTIDAD_CCF As Decimal, aPRECIO_UNITARIO_CCF As Decimal, aTOTAL_CCF As Decimal)
        Me._ID_CCF_DETA_SAL = aID_CCF_DETA_SAL
        Me._ID_CCF_ENCA = aID_CCF_ENCA
        Me._ID_SALBODE_DETA = aID_SALBODE_DETA
        Me._ID_SOLICITUD = aID_SOLICITUD
        Me._ID_PRODUCTO = aID_PRODUCTO
        Me._NOMBRE_PRODUCTO = aNOMBRE_PRODUCTO
        Me._PRESENTACION = aPRESENTACION
        Me._CANTIDAD_CCF = aCANTIDAD_CCF
        Me._PRECIO_UNITARIO_CCF = aPRECIO_UNITARIO_CCF
        Me._TOTAL_CCF = aTOTAL_CCF
    End Sub

#Region " Properties "

    Private _ID_CCF_DETA_SAL As Int32
    <Column(Name:="Id ccf deta sal", Storage:="ID_CCF_DETA_SAL", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_CCF_DETA_SAL() As Int32
        Get
            Return _ID_CCF_DETA_SAL
        End Get
        Set(ByVal Value As Int32)
            _ID_CCF_DETA_SAL = Value
            OnPropertyChanged("ID_CCF_DETA_SAL")
        End Set
    End Property 

    Private _ID_CCF_ENCA As Int32
    <Column(Name:="Id ccf enca", Storage:="ID_CCF_ENCA", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_CCF_ENCA() As Int32
        Get
            Return _ID_CCF_ENCA
        End Get
        Set(ByVal Value As Int32)
            _ID_CCF_ENCA = Value
            OnPropertyChanged("ID_CCF_ENCA")
        End Set
    End Property 

    Private _ID_CCF_ENCAOld As Int32
    Public Property ID_CCF_ENCAOld() As Int32
        Get
            Return _ID_CCF_ENCAOld
        End Get
        Set(ByVal Value As Int32)
            _ID_CCF_ENCAOld = Value
        End Set
    End Property 

    Private _fkID_CCF_ENCA As CCF_ENCA
    Public Property fkID_CCF_ENCA() As CCF_ENCA
        Get
            Return _fkID_CCF_ENCA
        End Get
        Set(ByVal Value As CCF_ENCA)
            _fkID_CCF_ENCA = Value
        End Set
    End Property 

    Private _ID_SALBODE_DETA As Int32
    <Column(Name:="Id salbode deta", Storage:="ID_SALBODE_DETA", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_SALBODE_DETA() As Int32
        Get
            Return _ID_SALBODE_DETA
        End Get
        Set(ByVal Value As Int32)
            _ID_SALBODE_DETA = Value
            OnPropertyChanged("ID_SALBODE_DETA")
        End Set
    End Property 

    Private _ID_SALBODE_DETAOld As Int32
    Public Property ID_SALBODE_DETAOld() As Int32
        Get
            Return _ID_SALBODE_DETAOld
        End Get
        Set(ByVal Value As Int32)
            _ID_SALBODE_DETAOld = Value
        End Set
    End Property 

    Private _fkID_SALBODE_DETA As SALBODE_DETA
    Public Property fkID_SALBODE_DETA() As SALBODE_DETA
        Get
            Return _fkID_SALBODE_DETA
        End Get
        Set(ByVal Value As SALBODE_DETA)
            _fkID_SALBODE_DETA = Value
        End Set
    End Property 

    Private _ID_SOLICITUD As Int32
    <Column(Name:="Id solicitud", Storage:="ID_SOLICITUD", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_SOLICITUD() As Int32
        Get
            Return _ID_SOLICITUD
        End Get
        Set(ByVal Value As Int32)
            _ID_SOLICITUD = Value
            OnPropertyChanged("ID_SOLICITUD")
        End Set
    End Property 

    Private _ID_SOLICITUDOld As Int32
    Public Property ID_SOLICITUDOld() As Int32
        Get
            Return _ID_SOLICITUDOld
        End Get
        Set(ByVal Value As Int32)
            _ID_SOLICITUDOld = Value
        End Set
    End Property 

    Private _fkID_SOLICITUD As SOLIC_AGRICOLA
    Public Property fkID_SOLICITUD() As SOLIC_AGRICOLA
        Get
            Return _fkID_SOLICITUD
        End Get
        Set(ByVal Value As SOLIC_AGRICOLA)
            _fkID_SOLICITUD = Value
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

    Private _fkID_PRODUCTO As PRODUCTO
    Public Property fkID_PRODUCTO() As PRODUCTO
        Get
            Return _fkID_PRODUCTO
        End Get
        Set(ByVal Value As PRODUCTO)
            _fkID_PRODUCTO = Value
        End Set
    End Property 

    Private _NOMBRE_PRODUCTO As String
    <Column(Name:="Nombre producto", Storage:="NOMBRE_PRODUCTO", DbType:="VARCHAR(100) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 100)> _
    Public Property NOMBRE_PRODUCTO() As String
        Get
            Return _NOMBRE_PRODUCTO
        End Get
        Set(ByVal Value As String)
            _NOMBRE_PRODUCTO = Value
            OnPropertyChanged("NOMBRE_PRODUCTO")
        End Set
    End Property 

    Private _NOMBRE_PRODUCTOOld As String
    Public Property NOMBRE_PRODUCTOOld() As String
        Get
            Return _NOMBRE_PRODUCTOOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_PRODUCTOOld = Value
        End Set
    End Property 

    Private _PRESENTACION As String
    <Column(Name:="Presentacion", Storage:="PRESENTACION", DbType:="VARCHAR(50)", Id:=False), _
     DataObjectField(False, False, True, 50)> _
    Public Property PRESENTACION() As String
        Get
            Return _PRESENTACION
        End Get
        Set(ByVal Value As String)
            _PRESENTACION = Value
            OnPropertyChanged("PRESENTACION")
        End Set
    End Property 

    Private _PRESENTACIONOld As String
    Public Property PRESENTACIONOld() As String
        Get
            Return _PRESENTACIONOld
        End Get
        Set(ByVal Value As String)
            _PRESENTACIONOld = Value
        End Set
    End Property 

    Private _CANTIDAD_CCF As Decimal
    <Column(Name:="Cantidad ccf", Storage:="CANTIDAD_CCF", DbType:="NUMERIC(10,4) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=4)> _
    Public Property CANTIDAD_CCF() As Decimal
        Get
            Return _CANTIDAD_CCF
        End Get
        Set(ByVal Value As Decimal)
            _CANTIDAD_CCF = Value
            OnPropertyChanged("CANTIDAD_CCF")
        End Set
    End Property 

    Private _CANTIDAD_CCFOld As Decimal
    Public Property CANTIDAD_CCFOld() As Decimal
        Get
            Return _CANTIDAD_CCFOld
        End Get
        Set(ByVal Value As Decimal)
            _CANTIDAD_CCFOld = Value
        End Set
    End Property 

    Private _PRECIO_UNITARIO_CCF As Decimal
    <Column(Name:="Precio unitario ccf", Storage:="PRECIO_UNITARIO_CCF", DbType:="NUMERIC(10,4) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=4)> _
    Public Property PRECIO_UNITARIO_CCF() As Decimal
        Get
            Return _PRECIO_UNITARIO_CCF
        End Get
        Set(ByVal Value As Decimal)
            _PRECIO_UNITARIO_CCF = Value
            OnPropertyChanged("PRECIO_UNITARIO_CCF")
        End Set
    End Property 

    Private _PRECIO_UNITARIO_CCFOld As Decimal
    Public Property PRECIO_UNITARIO_CCFOld() As Decimal
        Get
            Return _PRECIO_UNITARIO_CCFOld
        End Get
        Set(ByVal Value As Decimal)
            _PRECIO_UNITARIO_CCFOld = Value
        End Set
    End Property 

    Private _TOTAL_CCF As Decimal
    <Column(Name:="Total ccf", Storage:="TOTAL_CCF", DbType:="NUMERIC(10,4) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=4)> _
    Public Property TOTAL_CCF() As Decimal
        Get
            Return _TOTAL_CCF
        End Get
        Set(ByVal Value As Decimal)
            _TOTAL_CCF = Value
            OnPropertyChanged("TOTAL_CCF")
        End Set
    End Property 

    Private _TOTAL_CCFOld As Decimal
    Public Property TOTAL_CCFOld() As Decimal
        Get
            Return _TOTAL_CCFOld
        End Get
        Set(ByVal Value As Decimal)
            _TOTAL_CCFOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
