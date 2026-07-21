''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.TRANSPORTE
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row TRANSPORTE en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	25/09/2017	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="TRANSPORTE")> Public Class TRANSPORTE
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_TRANSPORTE As Int32, aPLACA As String, aCODTRANSPORT As Int32, aID_TIPOTRANS As Int32, aREMOLQUE As String, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime, aMARCA As String, aCAPACIDAD As Decimal, aANIO As String)
        Me._ID_TRANSPORTE = aID_TRANSPORTE
        Me._PLACA = aPLACA
        Me._CODTRANSPORT = aCODTRANSPORT
        Me._ID_TIPOTRANS = aID_TIPOTRANS
        Me._REMOLQUE = aREMOLQUE
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
        Me._MARCA = aMARCA
        Me._CAPACIDAD = aCAPACIDAD
        Me._ANIO = aANIO
    End Sub

#Region " Properties "

    Private _ID_TRANSPORTE As Int32
    <Column(Name:="Id transporte", Storage:="ID_TRANSPORTE", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_TRANSPORTE() As Int32
        Get
            Return _ID_TRANSPORTE
        End Get
        Set(ByVal Value As Int32)
            _ID_TRANSPORTE = Value
            OnPropertyChanged("ID_TRANSPORTE")
        End Set
    End Property 

    Private _PLACA As String
    <Column(Name:="Placa", Storage:="PLACA", DbType:="VARCHAR(100) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 100)> _
    Public Property PLACA() As String
        Get
            Return _PLACA
        End Get
        Set(ByVal Value As String)
            _PLACA = Value
            OnPropertyChanged("PLACA")
        End Set
    End Property 

    Private _PLACAOld As String
    Public Property PLACAOld() As String
        Get
            Return _PLACAOld
        End Get
        Set(ByVal Value As String)
            _PLACAOld = Value
        End Set
    End Property 

    Private _CODTRANSPORT As Int32
    <Column(Name:="Codtransport", Storage:="CODTRANSPORT", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property CODTRANSPORT() As Int32
        Get
            Return _CODTRANSPORT
        End Get
        Set(ByVal Value As Int32)
            _CODTRANSPORT = Value
            OnPropertyChanged("CODTRANSPORT")
        End Set
    End Property 

    Private _CODTRANSPORTOld As Int32
    Public Property CODTRANSPORTOld() As Int32
        Get
            Return _CODTRANSPORTOld
        End Get
        Set(ByVal Value As Int32)
            _CODTRANSPORTOld = Value
        End Set
    End Property 

    Private _fkCODTRANSPORT As TRANSPORTISTA
    Public Property fkCODTRANSPORT() As TRANSPORTISTA
        Get
            Return _fkCODTRANSPORT
        End Get
        Set(ByVal Value As TRANSPORTISTA)
            _fkCODTRANSPORT = Value
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

    Private _fkID_TIPOTRANS As TIPO_TRANSPORTE
    Public Property fkID_TIPOTRANS() As TIPO_TRANSPORTE
        Get
            Return _fkID_TIPOTRANS
        End Get
        Set(ByVal Value As TIPO_TRANSPORTE)
            _fkID_TIPOTRANS = Value
        End Set
    End Property 

    Private _REMOLQUE As String
    <Column(Name:="Remolque", Storage:="REMOLQUE", DbType:="VARCHAR(10)", Id:=False), _
     DataObjectField(False, False, True, 10)> _
    Public Property REMOLQUE() As String
        Get
            Return _REMOLQUE
        End Get
        Set(ByVal Value As String)
            _REMOLQUE = Value
            OnPropertyChanged("REMOLQUE")
        End Set
    End Property 

    Private _REMOLQUEOld As String
    Public Property REMOLQUEOld() As String
        Get
            Return _REMOLQUEOld
        End Get
        Set(ByVal Value As String)
            _REMOLQUEOld = Value
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

    Private _MARCA As String
    <Column(Name:="Marca", Storage:="MARCA", DbType:="VARCHAR(50)", Id:=False), _
     DataObjectField(False, False, True, 50)> _
    Public Property MARCA() As String
        Get
            Return _MARCA
        End Get
        Set(ByVal Value As String)
            _MARCA = Value
            OnPropertyChanged("MARCA")
        End Set
    End Property 

    Private _MARCAOld As String
    Public Property MARCAOld() As String
        Get
            Return _MARCAOld
        End Get
        Set(ByVal Value As String)
            _MARCAOld = Value
        End Set
    End Property 

    Private _CAPACIDAD As Decimal
    <Column(Name:="Capacidad", Storage:="CAPACIDAD", DbType:="NUMERIC(10,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=2)> _
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

    Private _ANIO As String
    <Column(Name:="Anio", Storage:="ANIO", DbType:="CHAR(4)", Id:=False), _
     DataObjectField(False, False, True, 4)> _
    Public Property ANIO() As String
        Get
            Return _ANIO
        End Get
        Set(ByVal Value As String)
            _ANIO = Value
            OnPropertyChanged("ANIO")
        End Set
    End Property 

    Private _ANIOOld As String
    Public Property ANIOOld() As String
        Get
            Return _ANIOOld
        End Get
        Set(ByVal Value As String)
            _ANIOOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
