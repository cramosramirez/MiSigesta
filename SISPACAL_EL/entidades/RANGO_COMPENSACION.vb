''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.RANGO_COMPENSACION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row RANGO_COMPENSACION en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	13/01/2015	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="RANGO_COMPENSACION")> Public Class RANGO_COMPENSACION
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_RANGO_COMPE As Int32, aID_ZAFRA As Int32, aID_CATORCENA As Int32, aREND_INICIAL As Decimal, aREND_FINAL As Decimal, aVALOR_UNIT_PAGO As Decimal, aDESCRIPCION As String, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime)
        Me._ID_RANGO_COMPE = aID_RANGO_COMPE
        Me._ID_ZAFRA = aID_ZAFRA
        Me._ID_CATORCENA = aID_CATORCENA
        Me._REND_INICIAL = aREND_INICIAL
        Me._REND_FINAL = aREND_FINAL
        Me._VALOR_UNIT_PAGO = aVALOR_UNIT_PAGO
        Me._DESCRIPCION = aDESCRIPCION
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
    End Sub

#Region " Properties "

    Private _ID_RANGO_COMPE As Int32
    <Column(Name:="Id rango compe", Storage:="ID_RANGO_COMPE", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_RANGO_COMPE() As Int32
        Get
            Return _ID_RANGO_COMPE
        End Get
        Set(ByVal Value As Int32)
            _ID_RANGO_COMPE = Value
            OnPropertyChanged("ID_RANGO_COMPE")
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

    Private _ID_CATORCENA As Int32
    <Column(Name:="Id catorcena", Storage:="ID_CATORCENA", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_CATORCENA() As Int32
        Get
            Return _ID_CATORCENA
        End Get
        Set(ByVal Value As Int32)
            _ID_CATORCENA = Value
            OnPropertyChanged("ID_CATORCENA")
        End Set
    End Property 

    Private _ID_CATORCENAOld As Int32
    Public Property ID_CATORCENAOld() As Int32
        Get
            Return _ID_CATORCENAOld
        End Get
        Set(ByVal Value As Int32)
            _ID_CATORCENAOld = Value
        End Set
    End Property 

    Private _fkID_CATORCENA As CATORCENA_ZAFRA
    Public Property fkID_CATORCENA() As CATORCENA_ZAFRA
        Get
            Return _fkID_CATORCENA
        End Get
        Set(ByVal Value As CATORCENA_ZAFRA)
            _fkID_CATORCENA = Value
        End Set
    End Property 

    Private _REND_INICIAL As Decimal
    <Column(Name:="Rend inicial", Storage:="REND_INICIAL", DbType:="NUMERIC(10,4) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=4)> _
    Public Property REND_INICIAL() As Decimal
        Get
            Return _REND_INICIAL
        End Get
        Set(ByVal Value As Decimal)
            _REND_INICIAL = Value
            OnPropertyChanged("REND_INICIAL")
        End Set
    End Property 

    Private _REND_INICIALOld As Decimal
    Public Property REND_INICIALOld() As Decimal
        Get
            Return _REND_INICIALOld
        End Get
        Set(ByVal Value As Decimal)
            _REND_INICIALOld = Value
        End Set
    End Property 

    Private _REND_FINAL As Decimal
    <Column(Name:="Rend final", Storage:="REND_FINAL", DbType:="NUMERIC(10,4) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=4)> _
    Public Property REND_FINAL() As Decimal
        Get
            Return _REND_FINAL
        End Get
        Set(ByVal Value As Decimal)
            _REND_FINAL = Value
            OnPropertyChanged("REND_FINAL")
        End Set
    End Property 

    Private _REND_FINALOld As Decimal
    Public Property REND_FINALOld() As Decimal
        Get
            Return _REND_FINALOld
        End Get
        Set(ByVal Value As Decimal)
            _REND_FINALOld = Value
        End Set
    End Property 

    Private _VALOR_UNIT_PAGO As Decimal
    <Column(Name:="Valor unit pago", Storage:="VALOR_UNIT_PAGO", DbType:="NUMERIC(22,20) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=22, Scale:=20)> _
    Public Property VALOR_UNIT_PAGO() As Decimal
        Get
            Return _VALOR_UNIT_PAGO
        End Get
        Set(ByVal Value As Decimal)
            _VALOR_UNIT_PAGO = Value
            OnPropertyChanged("VALOR_UNIT_PAGO")
        End Set
    End Property 

    Private _VALOR_UNIT_PAGOOld As Decimal
    Public Property VALOR_UNIT_PAGOOld() As Decimal
        Get
            Return _VALOR_UNIT_PAGOOld
        End Get
        Set(ByVal Value As Decimal)
            _VALOR_UNIT_PAGOOld = Value
        End Set
    End Property 

    Private _DESCRIPCION As String
    <Column(Name:="Descripcion", Storage:="DESCRIPCION", DbType:="VARCHAR(200)", Id:=False), _
     DataObjectField(False, False, True, 200)> _
    Public Property DESCRIPCION() As String
        Get
            Return _DESCRIPCION
        End Get
        Set(ByVal Value As String)
            _DESCRIPCION = Value
            OnPropertyChanged("DESCRIPCION")
        End Set
    End Property 

    Private _DESCRIPCIONOld As String
    Public Property DESCRIPCIONOld() As String
        Get
            Return _DESCRIPCIONOld
        End Get
        Set(ByVal Value As String)
            _DESCRIPCIONOld = Value
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
