''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.CATORCENA_ZAFRA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row CATORCENA_ZAFRA en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	12/11/2013	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="CATORCENA_ZAFRA")> Public Class CATORCENA_ZAFRA
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_CATORCENA As Int32, aID_ZAFRA As Int32, aCATORCENA As Int32, aAZUCAR_PRODUCIDA As Decimal, aAZUCAR_CALC1 As Decimal, aEFICIENCIA_REAL As Decimal, aFECHA_INICIO As DateTime, aFECHA_FIN As DateTime, aUSUARIO_CIERRE As String, aFECHA_CIERRE As DateTime, aRENDIMIENTO As Decimal, aTONELADA_PRODUCIDA As Decimal, aPOL_CANA As Decimal, aFECHA_PAGO As DateTime)
        Me._ID_CATORCENA = aID_CATORCENA
        Me._ID_ZAFRA = aID_ZAFRA
        Me._CATORCENA = aCATORCENA
        Me._AZUCAR_PRODUCIDA = aAZUCAR_PRODUCIDA
        Me._AZUCAR_CALC1 = aAZUCAR_CALC1
        Me._EFICIENCIA_REAL = aEFICIENCIA_REAL
        Me._FECHA_INICIO = aFECHA_INICIO
        Me._FECHA_FIN = aFECHA_FIN
        Me._USUARIO_CIERRE = aUSUARIO_CIERRE
        Me._FECHA_CIERRE = aFECHA_CIERRE
        Me._RENDIMIENTO = aRENDIMIENTO
        Me._TONELADA_PRODUCIDA = aTONELADA_PRODUCIDA
        Me._POL_CANA = aPOL_CANA
        Me._FECHA_PAGO = aFECHA_PAGO
    End Sub

#Region " Properties "

    Private _ID_CATORCENA As Int32
    <Column(Name:="Id catorcena", Storage:="ID_CATORCENA", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_CATORCENA() As Int32
        Get
            Return _ID_CATORCENA
        End Get
        Set(ByVal Value As Int32)
            _ID_CATORCENA = Value
            OnPropertyChanged("ID_CATORCENA")
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

    Private _CATORCENA As Int32
    <Column(Name:="Catorcena", Storage:="CATORCENA", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property CATORCENA() As Int32
        Get
            Return _CATORCENA
        End Get
        Set(ByVal Value As Int32)
            _CATORCENA = Value
            OnPropertyChanged("CATORCENA")
        End Set
    End Property 

    Private _CATORCENAOld As Int32
    Public Property CATORCENAOld() As Int32
        Get
            Return _CATORCENAOld
        End Get
        Set(ByVal Value As Int32)
            _CATORCENAOld = Value
        End Set
    End Property 

    Private _AZUCAR_PRODUCIDA As Decimal
    <Column(Name:="Azucar producida", Storage:="AZUCAR_PRODUCIDA", DbType:="NUMERIC(20,6) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=6)> _
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
    <Column(Name:="Eficiencia real", Storage:="EFICIENCIA_REAL", DbType:="NUMERIC(20,6) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=6)> _
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

    Private _FECHA_INICIO As DateTime
    <Column(Name:="Fecha inicio", Storage:="FECHA_INICIO", DbType:="DATETIME NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
    Public Property FECHA_INICIO() As DateTime
        Get
            Return _FECHA_INICIO
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_INICIO = Value
            OnPropertyChanged("FECHA_INICIO")
        End Set
    End Property 

    Private _FECHA_INICIOOld As DateTime
    Public Property FECHA_INICIOOld() As DateTime
        Get
            Return _FECHA_INICIOOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_INICIOOld = Value
        End Set
    End Property 

    Private _FECHA_FIN As DateTime
    <Column(Name:="Fecha fin", Storage:="FECHA_FIN", DbType:="DATETIME NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
    Public Property FECHA_FIN() As DateTime
        Get
            Return _FECHA_FIN
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_FIN = Value
            OnPropertyChanged("FECHA_FIN")
        End Set
    End Property 

    Private _FECHA_FINOld As DateTime
    Public Property FECHA_FINOld() As DateTime
        Get
            Return _FECHA_FINOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_FINOld = Value
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

    Private _RENDIMIENTO As Decimal
    <Column(Name:="Rendimiento", Storage:="RENDIMIENTO", DbType:="NUMERIC(20,6)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=6)> _
    Public Property RENDIMIENTO() As Decimal
        Get
            Return _RENDIMIENTO
        End Get
        Set(ByVal Value As Decimal)
            _RENDIMIENTO = Value
            OnPropertyChanged("RENDIMIENTO")
        End Set
    End Property 

    Private _RENDIMIENTOOld As Decimal
    Public Property RENDIMIENTOOld() As Decimal
        Get
            Return _RENDIMIENTOOld
        End Get
        Set(ByVal Value As Decimal)
            _RENDIMIENTOOld = Value
        End Set
    End Property 

    Private _TONELADA_PRODUCIDA As Decimal
    <Column(Name:="Tonelada producida", Storage:="TONELADA_PRODUCIDA", DbType:="NUMERIC(20,6)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=6)> _
    Public Property TONELADA_PRODUCIDA() As Decimal
        Get
            Return _TONELADA_PRODUCIDA
        End Get
        Set(ByVal Value As Decimal)
            _TONELADA_PRODUCIDA = Value
            OnPropertyChanged("TONELADA_PRODUCIDA")
        End Set
    End Property 

    Private _TONELADA_PRODUCIDAOld As Decimal
    Public Property TONELADA_PRODUCIDAOld() As Decimal
        Get
            Return _TONELADA_PRODUCIDAOld
        End Get
        Set(ByVal Value As Decimal)
            _TONELADA_PRODUCIDAOld = Value
        End Set
    End Property 

    Private _POL_CANA As Decimal
    <Column(Name:="Pol cana", Storage:="POL_CANA", DbType:="NUMERIC(20,6)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=6)> _
    Public Property POL_CANA() As Decimal
        Get
            Return _POL_CANA
        End Get
        Set(ByVal Value As Decimal)
            _POL_CANA = Value
            OnPropertyChanged("POL_CANA")
        End Set
    End Property 

    Private _POL_CANAOld As Decimal
    Public Property POL_CANAOld() As Decimal
        Get
            Return _POL_CANAOld
        End Get
        Set(ByVal Value As Decimal)
            _POL_CANAOld = Value
        End Set
    End Property 

    Private _FECHA_PAGO As DateTime
    <Column(Name:="Fecha pago", Storage:="FECHA_PAGO", DbType:="DATETIME", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_PAGO() As DateTime
        Get
            Return _FECHA_PAGO
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_PAGO = Value
            OnPropertyChanged("FECHA_PAGO")
        End Set
    End Property 

    Private _FECHA_PAGOOld As DateTime
    Public Property FECHA_PAGOOld() As DateTime
        Get
            Return _FECHA_PAGOOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_PAGOOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
    Private _PLANILLACATORCENA_ZAFRA As ListaPLANILLA
    Public Property PLANILLACATORCENA_ZAFRA() As ListaPLANILLA
        Get
            Return _PLANILLACATORCENA_ZAFRA
        End Get
        Set(ByVal Value As ListaPLANILLA)
            _PLANILLACATORCENA_ZAFRA = Value
        End Set
    End Property 

#End Region
#End Region
End Class
