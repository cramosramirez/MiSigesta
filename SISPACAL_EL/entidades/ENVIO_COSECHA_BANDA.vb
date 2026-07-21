''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.ENVIO_COSECHA_BANDA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row ENVIO_COSECHA_BANDA en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	25/11/2019	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="ENVIO_COSECHA_BANDA")> Public Class ENVIO_COSECHA_BANDA
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_ENVIO_BANDA As Int32, aID_ENVIO As Int32, aVALOR_TARIFA As Decimal, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime, aID_CARGADOR1 As Int32, aID_CARGADOR2 As Int32)
        Me._ID_ENVIO_BANDA = aID_ENVIO_BANDA
        Me._ID_ENVIO = aID_ENVIO
        Me._VALOR_TARIFA = aVALOR_TARIFA
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
        Me._ID_CARGADOR1 = aID_CARGADOR1
        Me._ID_CARGADOR2 = aID_CARGADOR2
    End Sub

#Region " Properties "

    Private _ID_ENVIO_BANDA As Int32
    <Column(Name:="Id envio banda", Storage:="ID_ENVIO_BANDA", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_ENVIO_BANDA() As Int32
        Get
            Return _ID_ENVIO_BANDA
        End Get
        Set(ByVal Value As Int32)
            _ID_ENVIO_BANDA = Value
            OnPropertyChanged("ID_ENVIO_BANDA")
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

    Private _VALOR_TARIFA As Decimal
    <Column(Name:="Valor tarifa", Storage:="VALOR_TARIFA", DbType:="NUMERIC(8,5) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=8, Scale:=5)> _
    Public Property VALOR_TARIFA() As Decimal
        Get
            Return _VALOR_TARIFA
        End Get
        Set(ByVal Value As Decimal)
            _VALOR_TARIFA = Value
            OnPropertyChanged("VALOR_TARIFA")
        End Set
    End Property 

    Private _VALOR_TARIFAOld As Decimal
    Public Property VALOR_TARIFAOld() As Decimal
        Get
            Return _VALOR_TARIFAOld
        End Get
        Set(ByVal Value As Decimal)
            _VALOR_TARIFAOld = Value
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

    Private _USUARIO_ACT As String
    <Column(Name:="Usuario act", Storage:="USUARIO_ACT", DbType:="VARCHAR(100) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 100)> _
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
    <Column(Name:="Fecha act", Storage:="FECHA_ACT", DbType:="DATETIME NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
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

    Private _ID_CARGADOR1 As Int32
    <Column(Name:="Id cargador1", Storage:="ID_CARGADOR1", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_CARGADOR1() As Int32
        Get
            Return _ID_CARGADOR1
        End Get
        Set(ByVal Value As Int32)
            _ID_CARGADOR1 = Value
            OnPropertyChanged("ID_CARGADOR1")
        End Set
    End Property 

    Private _ID_CARGADOR1Old As Int32
    Public Property ID_CARGADOR1Old() As Int32
        Get
            Return _ID_CARGADOR1Old
        End Get
        Set(ByVal Value As Int32)
            _ID_CARGADOR1Old = Value
        End Set
    End Property 

    Private _fkID_CARGADOR1 As CARGADOR
    Public Property fkID_CARGADOR1() As CARGADOR
        Get
            Return _fkID_CARGADOR1
        End Get
        Set(ByVal Value As CARGADOR)
            _fkID_CARGADOR1 = Value
        End Set
    End Property 

    Private _ID_CARGADOR2 As Int32
    <Column(Name:="Id cargador2", Storage:="ID_CARGADOR2", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_CARGADOR2() As Int32
        Get
            Return _ID_CARGADOR2
        End Get
        Set(ByVal Value As Int32)
            _ID_CARGADOR2 = Value
            OnPropertyChanged("ID_CARGADOR2")
        End Set
    End Property 

    Private _ID_CARGADOR2Old As Int32
    Public Property ID_CARGADOR2Old() As Int32
        Get
            Return _ID_CARGADOR2Old
        End Get
        Set(ByVal Value As Int32)
            _ID_CARGADOR2Old = Value
        End Set
    End Property 

    Private _fkID_CARGADOR2 As CARGADOR
    Public Property fkID_CARGADOR2() As CARGADOR
        Get
            Return _fkID_CARGADOR2
        End Get
        Set(ByVal Value As CARGADOR)
            _fkID_CARGADOR2 = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
