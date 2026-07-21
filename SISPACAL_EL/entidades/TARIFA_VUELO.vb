''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.TARIFA_VUELO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row TARIFA_VUELO en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	16/10/2014	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="TARIFA_VUELO")> Public Class TARIFA_VUELO
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_TARIFA As Int32, aID_PROVEE As Int32, aMEDIO_APLICA As String, aPRECIO As Decimal, aOTRO_CARGO As Decimal, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime, aZAFRA As String)
        Me._ID_TARIFA = aID_TARIFA
        Me._ID_PROVEE = aID_PROVEE
        Me._MEDIO_APLICA = aMEDIO_APLICA
        Me._PRECIO = aPRECIO
        Me._OTRO_CARGO = aOTRO_CARGO
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
        Me._ZAFRA = aZAFRA
    End Sub

#Region " Properties "

    Private _ID_TARIFA As Int32
    <Column(Name:="Id tarifa", Storage:="ID_TARIFA", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_TARIFA() As Int32
        Get
            Return _ID_TARIFA
        End Get
        Set(ByVal Value As Int32)
            _ID_TARIFA = Value
            OnPropertyChanged("ID_TARIFA")
        End Set
    End Property 

    Private _ID_PROVEE As Int32
    <Column(Name:="Id provee", Storage:="ID_PROVEE", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_PROVEE() As Int32
        Get
            Return _ID_PROVEE
        End Get
        Set(ByVal Value As Int32)
            _ID_PROVEE = Value
            OnPropertyChanged("ID_PROVEE")
        End Set
    End Property 

    Private _ID_PROVEEOld As Int32
    Public Property ID_PROVEEOld() As Int32
        Get
            Return _ID_PROVEEOld
        End Get
        Set(ByVal Value As Int32)
            _ID_PROVEEOld = Value
        End Set
    End Property 

    Private _fkID_PROVEE As PROVEEDOR_AGRICOLA
    Public Property fkID_PROVEE() As PROVEEDOR_AGRICOLA
        Get
            Return _fkID_PROVEE
        End Get
        Set(ByVal Value As PROVEEDOR_AGRICOLA)
            _fkID_PROVEE = Value
        End Set
    End Property 

    Private _MEDIO_APLICA As String
    <Column(Name:="Medio aplica", Storage:="MEDIO_APLICA", DbType:="CHAR(1) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 1)> _
    Public Property MEDIO_APLICA() As String
        Get
            Return _MEDIO_APLICA
        End Get
        Set(ByVal Value As String)
            _MEDIO_APLICA = Value
            OnPropertyChanged("MEDIO_APLICA")
        End Set
    End Property 

    Private _MEDIO_APLICAOld As String
    Public Property MEDIO_APLICAOld() As String
        Get
            Return _MEDIO_APLICAOld
        End Get
        Set(ByVal Value As String)
            _MEDIO_APLICAOld = Value
        End Set
    End Property 

    Private _PRECIO As Decimal
    <Column(Name:="Precio", Storage:="PRECIO", DbType:="NUMERIC(10,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)> _
    Public Property PRECIO() As Decimal
        Get
            Return _PRECIO
        End Get
        Set(ByVal Value As Decimal)
            _PRECIO = Value
            OnPropertyChanged("PRECIO")
        End Set
    End Property 

    Private _PRECIOOld As Decimal
    Public Property PRECIOOld() As Decimal
        Get
            Return _PRECIOOld
        End Get
        Set(ByVal Value As Decimal)
            _PRECIOOld = Value
        End Set
    End Property 

    Private _OTRO_CARGO As Decimal
    <Column(Name:="Otro cargo", Storage:="OTRO_CARGO", DbType:="NUMERIC(10,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)> _
    Public Property OTRO_CARGO() As Decimal
        Get
            Return _OTRO_CARGO
        End Get
        Set(ByVal Value As Decimal)
            _OTRO_CARGO = Value
            OnPropertyChanged("OTRO_CARGO")
        End Set
    End Property 

    Private _OTRO_CARGOOld As Decimal
    Public Property OTRO_CARGOOld() As Decimal
        Get
            Return _OTRO_CARGOOld
        End Get
        Set(ByVal Value As Decimal)
            _OTRO_CARGOOld = Value
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

    Private _ZAFRA As String
    <Column(Name:="Zafra", Storage:="ZAFRA", DbType:="VARCHAR(9) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 9)> _
    Public Property ZAFRA() As String
        Get
            Return _ZAFRA
        End Get
        Set(ByVal Value As String)
            _ZAFRA = Value
            OnPropertyChanged("ZAFRA")
        End Set
    End Property 

    Private _ZAFRAOld As String
    Public Property ZAFRAOld() As String
        Get
            Return _ZAFRAOld
        End Get
        Set(ByVal Value As String)
            _ZAFRAOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
