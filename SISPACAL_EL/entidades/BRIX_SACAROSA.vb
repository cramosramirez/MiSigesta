''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.BRIX_SACAROSA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row BRIX_SACAROSA en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	09/10/2014	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="BRIX_SACAROSA")> Public Class BRIX_SACAROSA
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_BRIX_SACA As Int32, aBRIX As Decimal, aGRAMOS_SACAROSA As Decimal, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime)
        Me._ID_BRIX_SACA = aID_BRIX_SACA
        Me._BRIX = aBRIX
        Me._GRAMOS_SACAROSA = aGRAMOS_SACAROSA
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
    End Sub

#Region " Properties "

    Private _ID_BRIX_SACA As Int32
    <Column(Name:="Id brix saca", Storage:="ID_BRIX_SACA", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_BRIX_SACA() As Int32
        Get
            Return _ID_BRIX_SACA
        End Get
        Set(ByVal Value As Int32)
            _ID_BRIX_SACA = Value
            OnPropertyChanged("ID_BRIX_SACA")
        End Set
    End Property 

    Private _BRIX As Decimal
    <Column(Name:="Brix", Storage:="BRIX", DbType:="NUMERIC(5,1) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=5, Scale:=1)> _
    Public Property BRIX() As Decimal
        Get
            Return _BRIX
        End Get
        Set(ByVal Value As Decimal)
            _BRIX = Value
            OnPropertyChanged("BRIX")
        End Set
    End Property 

    Private _BRIXOld As Decimal
    Public Property BRIXOld() As Decimal
        Get
            Return _BRIXOld
        End Get
        Set(ByVal Value As Decimal)
            _BRIXOld = Value
        End Set
    End Property 

    Private _GRAMOS_SACAROSA As Decimal
    <Column(Name:="Gramos sacarosa", Storage:="GRAMOS_SACAROSA", DbType:="NUMERIC(10,8) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=8)> _
    Public Property GRAMOS_SACAROSA() As Decimal
        Get
            Return _GRAMOS_SACAROSA
        End Get
        Set(ByVal Value As Decimal)
            _GRAMOS_SACAROSA = Value
            OnPropertyChanged("GRAMOS_SACAROSA")
        End Set
    End Property 

    Private _GRAMOS_SACAROSAOld As Decimal
    Public Property GRAMOS_SACAROSAOld() As Decimal
        Get
            Return _GRAMOS_SACAROSAOld
        End Get
        Set(ByVal Value As Decimal)
            _GRAMOS_SACAROSAOld = Value
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
