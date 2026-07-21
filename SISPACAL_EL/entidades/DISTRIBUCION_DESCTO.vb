''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.DISTRIBUCION_DESCTO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row DISTRIBUCION_DESCTO en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	01/10/2013	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="DISTRIBUCION_DESCTO")> Public Class DISTRIBUCION_DESCTO
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_DISTRIB_DESCTO As Int32, aCODICONTRATO As String, aACCESLOTE As String, aID_DESCUENTO_PLANILLA As Int32, aMONTO_DESCUENTO As Decimal, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime)
        Me._ID_DISTRIB_DESCTO = aID_DISTRIB_DESCTO
        Me._CODICONTRATO = aCODICONTRATO
        Me._ACCESLOTE = aACCESLOTE
        Me._ID_DESCUENTO_PLANILLA = aID_DESCUENTO_PLANILLA
        Me._MONTO_DESCUENTO = aMONTO_DESCUENTO
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
    End Sub

#Region " Properties "

    Private _ID_DISTRIB_DESCTO As Int32
    <Column(Name:="Id distrib descto", Storage:="ID_DISTRIB_DESCTO", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_DISTRIB_DESCTO() As Int32
        Get
            Return _ID_DISTRIB_DESCTO
        End Get
        Set(ByVal Value As Int32)
            _ID_DISTRIB_DESCTO = Value
            OnPropertyChanged("ID_DISTRIB_DESCTO")
        End Set
    End Property 

    Private _CODICONTRATO As String
    <Column(Name:="Codicontrato", Storage:="CODICONTRATO", DbType:="CHAR(13) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 13)> _
    Public Property CODICONTRATO() As String
        Get
            Return _CODICONTRATO
        End Get
        Set(ByVal Value As String)
            _CODICONTRATO = Value
            OnPropertyChanged("CODICONTRATO")
        End Set
    End Property 

    Private _CODICONTRATOOld As String
    Public Property CODICONTRATOOld() As String
        Get
            Return _CODICONTRATOOld
        End Get
        Set(ByVal Value As String)
            _CODICONTRATOOld = Value
        End Set
    End Property 

    Private _fkCODICONTRATO As CONTRATO
    Public Property fkCODICONTRATO() As CONTRATO
        Get
            Return _fkCODICONTRATO
        End Get
        Set(ByVal Value As CONTRATO)
            _fkCODICONTRATO = Value
        End Set
    End Property 

    Private _ACCESLOTE As String
    <Column(Name:="Acceslote", Storage:="ACCESLOTE", DbType:="CHAR(21)", Id:=False), _
     DataObjectField(False, False, True, 21)> _
    Public Property ACCESLOTE() As String
        Get
            Return _ACCESLOTE
        End Get
        Set(ByVal Value As String)
            _ACCESLOTE = Value
            OnPropertyChanged("ACCESLOTE")
        End Set
    End Property 

    Private _ACCESLOTEOld As String
    Public Property ACCESLOTEOld() As String
        Get
            Return _ACCESLOTEOld
        End Get
        Set(ByVal Value As String)
            _ACCESLOTEOld = Value
        End Set
    End Property 

    Private _fkACCESLOTE As LOTES
    Public Property fkACCESLOTE() As LOTES
        Get
            Return _fkACCESLOTE
        End Get
        Set(ByVal Value As LOTES)
            _fkACCESLOTE = Value
        End Set
    End Property 

    Private _ID_DESCUENTO_PLANILLA As Int32
    <Column(Name:="Id descuento planilla", Storage:="ID_DESCUENTO_PLANILLA", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_DESCUENTO_PLANILLA() As Int32
        Get
            Return _ID_DESCUENTO_PLANILLA
        End Get
        Set(ByVal Value As Int32)
            _ID_DESCUENTO_PLANILLA = Value
            OnPropertyChanged("ID_DESCUENTO_PLANILLA")
        End Set
    End Property 

    Private _ID_DESCUENTO_PLANILLAOld As Int32
    Public Property ID_DESCUENTO_PLANILLAOld() As Int32
        Get
            Return _ID_DESCUENTO_PLANILLAOld
        End Get
        Set(ByVal Value As Int32)
            _ID_DESCUENTO_PLANILLAOld = Value
        End Set
    End Property 

    Private _fkID_DESCUENTO_PLANILLA As DESCUENTOS_PLANILLA
    Public Property fkID_DESCUENTO_PLANILLA() As DESCUENTOS_PLANILLA
        Get
            Return _fkID_DESCUENTO_PLANILLA
        End Get
        Set(ByVal Value As DESCUENTOS_PLANILLA)
            _fkID_DESCUENTO_PLANILLA = Value
        End Set
    End Property 

    Private _MONTO_DESCUENTO As Decimal
    <Column(Name:="Monto descuento", Storage:="MONTO_DESCUENTO", DbType:="NUMERIC(20,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)> _
    Public Property MONTO_DESCUENTO() As Decimal
        Get
            Return _MONTO_DESCUENTO
        End Get
        Set(ByVal Value As Decimal)
            _MONTO_DESCUENTO = Value
            OnPropertyChanged("MONTO_DESCUENTO")
        End Set
    End Property 

    Private _MONTO_DESCUENTOOld As Decimal
    Public Property MONTO_DESCUENTOOld() As Decimal
        Get
            Return _MONTO_DESCUENTOOld
        End Get
        Set(ByVal Value As Decimal)
            _MONTO_DESCUENTOOld = Value
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
