''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.ZAFGAS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row ZAFGAS en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	09/12/2013	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="ZAFGAS")> Public Class ZAFGAS
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aMEDIO As String, aEFICIENCIA As Decimal, aCAPACIDAD As Decimal, aGASBASE As Decimal, aGASPRECIO As Decimal, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime)
        Me._MEDIO = aMEDIO
        Me._EFICIENCIA = aEFICIENCIA
        Me._CAPACIDAD = aCAPACIDAD
        Me._GASBASE = aGASBASE
        Me._GASPRECIO = aGASPRECIO
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
    End Sub

#Region " Properties "

    Private _MEDIO As String
    <Column(Name:="Medio", Storage:="MEDIO", DbType:="VARCHAR(3) NOT NULL", Id:=True), _
     DataObjectField(True, False, False, 3)> _
    Public Property MEDIO() As String
        Get
            Return _MEDIO
        End Get
        Set(ByVal Value As String)
            _MEDIO = Value
            OnPropertyChanged("MEDIO")
        End Set
    End Property 

    Private _EFICIENCIA As Decimal
    <Column(Name:="Eficiencia", Storage:="EFICIENCIA", DbType:="NUMERIC(6,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=6, Scale:=2)> _
    Public Property EFICIENCIA() As Decimal
        Get
            Return _EFICIENCIA
        End Get
        Set(ByVal Value As Decimal)
            _EFICIENCIA = Value
            OnPropertyChanged("EFICIENCIA")
        End Set
    End Property 

    Private _EFICIENCIAOld As Decimal
    Public Property EFICIENCIAOld() As Decimal
        Get
            Return _EFICIENCIAOld
        End Get
        Set(ByVal Value As Decimal)
            _EFICIENCIAOld = Value
        End Set
    End Property 

    Private _CAPACIDAD As Decimal
    <Column(Name:="Capacidad", Storage:="CAPACIDAD", DbType:="NUMERIC(3,0) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=3, Scale:=0)> _
    Public Property CAPACIDAD() As Decimal
        Get
            Return _CAPACIDAD
        End Get
        Set(ByVal Value As Decimal)
            _CAPACIDAD = Value
            OnPropertyChanged("CAPACIDAD")
        End Set
    End Property 

    Private _CAPACIDADOld As Decimal
    Public Property CAPACIDADOld() As Decimal
        Get
            Return _CAPACIDADOld
        End Get
        Set(ByVal Value As Decimal)
            _CAPACIDADOld = Value
        End Set
    End Property 

    Private _GASBASE As Decimal
    <Column(Name:="Gasbase", Storage:="GASBASE", DbType:="NUMERIC(7,4) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=7, Scale:=4)> _
    Public Property GASBASE() As Decimal
        Get
            Return _GASBASE
        End Get
        Set(ByVal Value As Decimal)
            _GASBASE = Value
            OnPropertyChanged("GASBASE")
        End Set
    End Property 

    Private _GASBASEOld As Decimal
    Public Property GASBASEOld() As Decimal
        Get
            Return _GASBASEOld
        End Get
        Set(ByVal Value As Decimal)
            _GASBASEOld = Value
        End Set
    End Property 

    Private _GASPRECIO As Decimal
    <Column(Name:="Gasprecio", Storage:="GASPRECIO", DbType:="NUMERIC(7,4) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=7, Scale:=4)> _
    Public Property GASPRECIO() As Decimal
        Get
            Return _GASPRECIO
        End Get
        Set(ByVal Value As Decimal)
            _GASPRECIO = Value
            OnPropertyChanged("GASPRECIO")
        End Set
    End Property 

    Private _GASPRECIOOld As Decimal
    Public Property GASPRECIOOld() As Decimal
        Get
            Return _GASPRECIOOld
        End Get
        Set(ByVal Value As Decimal)
            _GASPRECIOOld = Value
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

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
