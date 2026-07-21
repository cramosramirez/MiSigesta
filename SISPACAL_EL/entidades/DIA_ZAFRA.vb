''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.DIA_ZAFRA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row DIA_ZAFRA en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	20/09/2013	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="DIA_ZAFRA")> Public Class DIA_ZAFRA
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_DIA_ZAFRA As Int32, aID_ZAFRA As Int32, aDIAZAFRA As Int32, aFECHA As DateTime, aAZUCAR_PRODUCIDA As Decimal, aAZUCAR_CALC1 As Decimal, aEFICIENCIA_REAL As Decimal, aUSUARIO_CIERRE As String, aFECHA_CIERRE As DateTime, aHORA_CIERRE As DateTime)
        Me._ID_DIA_ZAFRA = aID_DIA_ZAFRA
        Me._ID_ZAFRA = aID_ZAFRA
        Me._DIAZAFRA = aDIAZAFRA
        Me._FECHA = aFECHA
        Me._AZUCAR_PRODUCIDA = aAZUCAR_PRODUCIDA
        Me._AZUCAR_CALC1 = aAZUCAR_CALC1
        Me._EFICIENCIA_REAL = aEFICIENCIA_REAL
        Me._USUARIO_CIERRE = aUSUARIO_CIERRE
        Me._FECHA_CIERRE = aFECHA_CIERRE
        Me._HORA_CIERRE = aHORA_CIERRE
    End Sub

#Region " Properties "

    Private _ID_DIA_ZAFRA As Int32
    <Column(Name:="Id dia zafra", Storage:="ID_DIA_ZAFRA", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_DIA_ZAFRA() As Int32
        Get
            Return _ID_DIA_ZAFRA
        End Get
        Set(ByVal Value As Int32)
            _ID_DIA_ZAFRA = Value
            OnPropertyChanged("ID_DIA_ZAFRA")
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

    Private _DIAZAFRA As Int32
    <Column(Name:="Diazafra", Storage:="DIAZAFRA", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property DIAZAFRA() As Int32
        Get
            Return _DIAZAFRA
        End Get
        Set(ByVal Value As Int32)
            _DIAZAFRA = Value
            OnPropertyChanged("DIAZAFRA")
        End Set
    End Property 

    Private _DIAZAFRAOld As Int32
    Public Property DIAZAFRAOld() As Int32
        Get
            Return _DIAZAFRAOld
        End Get
        Set(ByVal Value As Int32)
            _DIAZAFRAOld = Value
        End Set
    End Property 

    Private _FECHA As DateTime
    <Column(Name:="Fecha", Storage:="FECHA", DbType:="DATE NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
    Public Property FECHA() As DateTime
        Get
            Return _FECHA
        End Get
        Set(ByVal Value As DateTime)
            _FECHA = Value
            OnPropertyChanged("FECHA")
        End Set
    End Property 

    Private _FECHAOld As DateTime
    Public Property FECHAOld() As DateTime
        Get
            Return _FECHAOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHAOld = Value
        End Set
    End Property 

    Private _AZUCAR_PRODUCIDA As Decimal
    <Column(Name:="Azucar producida", Storage:="AZUCAR_PRODUCIDA", DbType:="NUMERIC(20,6) NULL", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=6)> _
    Public Property AZUCAR_PRODUCIDA() As Decimal
        Get
            Return _AZUCAR_PRODUCIDA
        End Get
        Set(ByVal Value As Decimal)
            _AZUCAR_PRODUCIDA = Value
            OnPropertyChanged("AZUCAR_PRODUCIDA")
        End Set
    End Property

    Private _AZUCAR_PRODUCIDAOld As Decimal
    Public Property AZUCAR_PRODUCIDAOld() As Decimal
        Get
            Return _AZUCAR_PRODUCIDAOld
        End Get
        Set(ByVal Value As Decimal)
            _AZUCAR_PRODUCIDAOld = Value
        End Set
    End Property 

    Private _AZUCAR_CALC1 As Decimal
    <Column(Name:="Azucar calc1", Storage:="AZUCAR_CALC1", DbType:="NUMERIC(20,6) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=6)> _
    Public Property AZUCAR_CALC1() As Decimal
        Get
            Return _AZUCAR_CALC1
        End Get
        Set(ByVal Value As Decimal)
            _AZUCAR_CALC1 = Value
            OnPropertyChanged("AZUCAR_CALC1")
        End Set
    End Property 

    Private _AZUCAR_CALC1Old As Decimal
    Public Property AZUCAR_CALC1Old() As Decimal
        Get
            Return _AZUCAR_CALC1Old
        End Get
        Set(ByVal Value As Decimal)
            _AZUCAR_CALC1Old = Value
        End Set
    End Property 

    Private _EFICIENCIA_REAL As Decimal
    <Column(Name:="Eficiencia real", Storage:="EFICIENCIA_REAL", DbType:="NUMERIC(20,6) NULL", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=6)> _
    Public Property EFICIENCIA_REAL() As Decimal
        Get
            Return _EFICIENCIA_REAL
        End Get
        Set(ByVal Value As Decimal)
            _EFICIENCIA_REAL = Value
            OnPropertyChanged("EFICIENCIA_REAL")
        End Set
    End Property

    Private _EFICIENCIA_REALOld As Decimal
    Public Property EFICIENCIA_REALOld() As Decimal
        Get
            Return _EFICIENCIA_REALOld
        End Get
        Set(ByVal Value As Decimal)
            _EFICIENCIA_REALOld = Value
        End Set
    End Property 

    Private _USUARIO_CIERRE As String
    <Column(Name:="Usuario cierre", Storage:="USUARIO_CIERRE", DbType:="VARCHAR(100) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 100)> _
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
    <Column(Name:="Fecha cierre", Storage:="FECHA_CIERRE", DbType:="DATETIME NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
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

    Private _HORA_CIERRE As DateTime
    <Column(Name:="Hora Cierre", Storage:="HORA_CIERRE", DbType:="DATETIME NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
    Public Property HORA_CIERRE() As DateTime
        Get
            Return _HORA_CIERRE
        End Get
        Set(ByVal Value As DateTime)
            _HORA_CIERRE = Value
            OnPropertyChanged("HORA_CIERRE")
        End Set
    End Property

    Private _HORA_CIERREOld As DateTime
    Public Property HORA_CIERREOld() As DateTime
        Get
            Return _HORA_CIERREOld
        End Get
        Set(ByVal Value As DateTime)
            _HORA_CIERREOld = Value
        End Set
    End Property

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
