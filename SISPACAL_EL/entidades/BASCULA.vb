''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.BASCULA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row BASCULA en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	11/09/2013	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="BASCULA")> Public Class BASCULA
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New(aID_BASCULA As Int32, aID_ENVIO As Int32, aBRUTO As Decimal, aTARA As Decimal, aNETOLIBRAS As Decimal, aNETOTONEL As Decimal, aUSUARIO_LEE_BRUTO As String, aFECHA_LEE_BRUTO As DateTime, aUSUARIO_LEE_TARA As String, aFECHA_LEE_TARA As DateTime)
        Me._ID_BASCULA = aID_BASCULA
        Me._ID_ENVIO = aID_ENVIO
        Me._BRUTO = aBRUTO
        Me._TARA = aTARA
        Me._NETOLIBRAS = aNETOLIBRAS
        Me._NETOTONEL = aNETOTONEL
        Me._USUARIO_LEE_BRUTO = aUSUARIO_LEE_BRUTO
        Me._FECHA_LEE_BRUTO = aFECHA_LEE_BRUTO
        Me._USUARIO_LEE_TARA = aUSUARIO_LEE_TARA
        Me._FECHA_LEE_TARA = aFECHA_LEE_TARA
    End Sub

#Region " Properties "

    Private _ID_BASCULA As Int32
    <Column(Name:="Id bascula", Storage:="ID_BASCULA", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_BASCULA() As Int32
        Get
            Return _ID_BASCULA
        End Get
        Set(ByVal Value As Int32)
            _ID_BASCULA = Value
            OnPropertyChanged("ID_BASCULA")
        End Set
    End Property 

    Private _ID_ENVIO As Int32
    <Column(Name:="Id envio", Storage:="ID_ENVIO", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_ENVIO() As Int32
        Get
            Return _ID_ENVIO
        End Get
        Set(ByVal Value As Int32)
            _ID_ENVIO = Value
            OnPropertyChanged("ID_ENVIO")
        End Set
    End Property 

    Private _ID_ENVIOOld As Int32
    Public Property ID_ENVIOOld() As Int32
        Get
            Return _ID_ENVIOOld
        End Get
        Set(ByVal Value As Int32)
            _ID_ENVIOOld = Value
        End Set
    End Property 

    Private _fkID_ENVIO As ENVIO
    Public Property fkID_ENVIO() As ENVIO
        Get
            Return _fkID_ENVIO
        End Get
        Set(ByVal Value As ENVIO)
            _fkID_ENVIO = Value
        End Set
    End Property 

    Private _BRUTO As Decimal
    <Column(Name:="Bruto", Storage:="BRUTO", DbType:="NUMERIC(10,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=2)> _
    Public Property BRUTO() As Decimal
        Get
            Return _BRUTO
        End Get
        Set(ByVal Value As Decimal)
            _BRUTO = Value
            OnPropertyChanged("BRUTO")
        End Set
    End Property 

    Private _BRUTOOld As Decimal
    Public Property BRUTOOld() As Decimal
        Get
            Return _BRUTOOld
        End Get
        Set(ByVal Value As Decimal)
            _BRUTOOld = Value
        End Set
    End Property 

    Private _TARA As Decimal
    <Column(Name:="Tara", Storage:="TARA", DbType:="NUMERIC(10,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=2)> _
    Public Property TARA() As Decimal
        Get
            Return _TARA
        End Get
        Set(ByVal Value As Decimal)
            _TARA = Value
            OnPropertyChanged("TARA")
        End Set
    End Property 

    Private _TARAOld As Decimal
    Public Property TARAOld() As Decimal
        Get
            Return _TARAOld
        End Get
        Set(ByVal Value As Decimal)
            _TARAOld = Value
        End Set
    End Property 

    Private _NETOLIBRAS As Decimal
    <Column(Name:="Netolibras", Storage:="NETOLIBRAS", DbType:="NUMERIC(10,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=2)> _
    Public Property NETOLIBRAS() As Decimal
        Get
            Return _NETOLIBRAS
        End Get
        Set(ByVal Value As Decimal)
            _NETOLIBRAS = Value
            OnPropertyChanged("NETOLIBRAS")
        End Set
    End Property 

    Private _NETOLIBRASOld As Decimal
    Public Property NETOLIBRASOld() As Decimal
        Get
            Return _NETOLIBRASOld
        End Get
        Set(ByVal Value As Decimal)
            _NETOLIBRASOld = Value
        End Set
    End Property 

    Private _NETOTONEL As Decimal
    <Column(Name:="Netotonel", Storage:="NETOTONEL", DbType:="NUMERIC(10,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=2)> _
    Public Property NETOTONEL() As Decimal
        Get
            Return _NETOTONEL
        End Get
        Set(ByVal Value As Decimal)
            _NETOTONEL = Value
            OnPropertyChanged("NETOTONEL")
        End Set
    End Property 

    Private _NETOTONELOld As Decimal
    Public Property NETOTONELOld() As Decimal
        Get
            Return _NETOTONELOld
        End Get
        Set(ByVal Value As Decimal)
            _NETOTONELOld = Value
        End Set
    End Property 

    Private _USUARIO_LEE_BRUTO As String
    <Column(Name:="Usuario lee bruto", Storage:="USUARIO_LEE_BRUTO", DbType:="VARCHAR(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
    Public Property USUARIO_LEE_BRUTO() As String
        Get
            Return _USUARIO_LEE_BRUTO
        End Get
        Set(ByVal Value As String)
            _USUARIO_LEE_BRUTO = Value
            OnPropertyChanged("USUARIO_LEE_BRUTO")
        End Set
    End Property 

    Private _USUARIO_LEE_BRUTOOld As String
    Public Property USUARIO_LEE_BRUTOOld() As String
        Get
            Return _USUARIO_LEE_BRUTOOld
        End Get
        Set(ByVal Value As String)
            _USUARIO_LEE_BRUTOOld = Value
        End Set
    End Property 

    Private _FECHA_LEE_BRUTO As DateTime
    <Column(Name:="Fecha lee bruto", Storage:="FECHA_LEE_BRUTO", DbType:="DATETIME", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_LEE_BRUTO() As DateTime
        Get
            Return _FECHA_LEE_BRUTO
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_LEE_BRUTO = Value
            OnPropertyChanged("FECHA_LEE_BRUTO")
        End Set
    End Property 

    Private _FECHA_LEE_BRUTOOld As DateTime
    Public Property FECHA_LEE_BRUTOOld() As DateTime
        Get
            Return _FECHA_LEE_BRUTOOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_LEE_BRUTOOld = Value
        End Set
    End Property 

    Private _USUARIO_LEE_TARA As String
    <Column(Name:="Usuario lee tara", Storage:="USUARIO_LEE_TARA", DbType:="VARCHAR(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
    Public Property USUARIO_LEE_TARA() As String
        Get
            Return _USUARIO_LEE_TARA
        End Get
        Set(ByVal Value As String)
            _USUARIO_LEE_TARA = Value
            OnPropertyChanged("USUARIO_LEE_TARA")
        End Set
    End Property 

    Private _USUARIO_LEE_TARAOld As String
    Public Property USUARIO_LEE_TARAOld() As String
        Get
            Return _USUARIO_LEE_TARAOld
        End Get
        Set(ByVal Value As String)
            _USUARIO_LEE_TARAOld = Value
        End Set
    End Property 

    Private _FECHA_LEE_TARA As DateTime
    <Column(Name:="Fecha lee tara", Storage:="FECHA_LEE_TARA", DbType:="DATETIME", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_LEE_TARA() As DateTime
        Get
            Return _FECHA_LEE_TARA
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_LEE_TARA = Value
            OnPropertyChanged("FECHA_LEE_TARA")
        End Set
    End Property 

    Private _FECHA_LEE_TARAOld As DateTime
    Public Property FECHA_LEE_TARAOld() As DateTime
        Get
            Return _FECHA_LEE_TARAOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_LEE_TARAOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
