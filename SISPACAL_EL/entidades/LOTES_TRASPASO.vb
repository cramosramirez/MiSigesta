''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.LOTES_TRASPASO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row LOTES_TRASPASO en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	06/01/2015	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="LOTES_TRASPASO")> Public Class LOTES_TRASPASO
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_LOTE_TRASPASO As Int32, aACCESLOTE As String, aANIOZAFRA As String, aCODIPROVEEDOR As String, aCODILOTE As String, aCODIVARIEDA As String, aCODICONTRATO As String, aNOMBLOTE As String, aAREA As Decimal, aTONELADAS As Decimal, aTONEL_TC As Decimal, aZONA As String, aEDAD_LOTE As Decimal, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aID_MAESTRO As Int32, aTIPO_DERECHO As Int32, aSUB_ZONA As String, aID_ZAFRA_TRASPASO As Int32)
        Me._ID_LOTE_TRASPASO = aID_LOTE_TRASPASO
        Me._ACCESLOTE = aACCESLOTE
        Me._ANIOZAFRA = aANIOZAFRA
        Me._CODIPROVEEDOR = aCODIPROVEEDOR
        Me._CODILOTE = aCODILOTE
        Me._CODIVARIEDA = aCODIVARIEDA
        Me._CODICONTRATO = aCODICONTRATO
        Me._NOMBLOTE = aNOMBLOTE
        Me._AREA = aAREA
        Me._TONELADAS = aTONELADAS
        Me._TONEL_TC = aTONEL_TC
        Me._ZONA = aZONA
        Me._EDAD_LOTE = aEDAD_LOTE
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._ID_MAESTRO = aID_MAESTRO
        Me._TIPO_DERECHO = aTIPO_DERECHO
        Me._SUB_ZONA = aSUB_ZONA
        Me._ID_ZAFRA_TRASPASO = aID_ZAFRA_TRASPASO
    End Sub

#Region " Properties "

    Private _ID_LOTE_TRASPASO As Int32
    <Column(Name:="Id lote traspaso", Storage:="ID_LOTE_TRASPASO", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_LOTE_TRASPASO() As Int32
        Get
            Return _ID_LOTE_TRASPASO
        End Get
        Set(ByVal Value As Int32)
            _ID_LOTE_TRASPASO = Value
            OnPropertyChanged("ID_LOTE_TRASPASO")
        End Set
    End Property 

    Private _ACCESLOTE As String
    <Column(Name:="Acceslote", Storage:="ACCESLOTE", DbType:="CHAR(21) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 21)> _
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

    Private _ANIOZAFRA As String
    <Column(Name:="Aniozafra", Storage:="ANIOZAFRA", DbType:="CHAR(9)", Id:=False), _
     DataObjectField(False, False, True, 9)> _
    Public Property ANIOZAFRA() As String
        Get
            Return _ANIOZAFRA
        End Get
        Set(ByVal Value As String)
            _ANIOZAFRA = Value
            OnPropertyChanged("ANIOZAFRA")
        End Set
    End Property 

    Private _ANIOZAFRAOld As String
    Public Property ANIOZAFRAOld() As String
        Get
            Return _ANIOZAFRAOld
        End Get
        Set(ByVal Value As String)
            _ANIOZAFRAOld = Value
        End Set
    End Property 

    Private _CODIPROVEEDOR As String
    <Column(Name:="Codiproveedor", Storage:="CODIPROVEEDOR", DbType:="CHAR(10)", Id:=False), _
     DataObjectField(False, False, True, 10)> _
    Public Property CODIPROVEEDOR() As String
        Get
            Return _CODIPROVEEDOR
        End Get
        Set(ByVal Value As String)
            _CODIPROVEEDOR = Value
            OnPropertyChanged("CODIPROVEEDOR")
        End Set
    End Property 

    Private _CODIPROVEEDOROld As String
    Public Property CODIPROVEEDOROld() As String
        Get
            Return _CODIPROVEEDOROld
        End Get
        Set(ByVal Value As String)
            _CODIPROVEEDOROld = Value
        End Set
    End Property 

    Private _CODILOTE As String
    <Column(Name:="Codilote", Storage:="CODILOTE", DbType:="CHAR(5)", Id:=False), _
     DataObjectField(False, False, True, 5)> _
    Public Property CODILOTE() As String
        Get
            Return _CODILOTE
        End Get
        Set(ByVal Value As String)
            _CODILOTE = Value
            OnPropertyChanged("CODILOTE")
        End Set
    End Property 

    Private _CODILOTEOld As String
    Public Property CODILOTEOld() As String
        Get
            Return _CODILOTEOld
        End Get
        Set(ByVal Value As String)
            _CODILOTEOld = Value
        End Set
    End Property 

    Private _CODIVARIEDA As String
    <Column(Name:="Codivarieda", Storage:="CODIVARIEDA", DbType:="CHAR(3)", Id:=False), _
     DataObjectField(False, False, True, 3)> _
    Public Property CODIVARIEDA() As String
        Get
            Return _CODIVARIEDA
        End Get
        Set(ByVal Value As String)
            _CODIVARIEDA = Value
            OnPropertyChanged("CODIVARIEDA")
        End Set
    End Property 

    Private _CODIVARIEDAOld As String
    Public Property CODIVARIEDAOld() As String
        Get
            Return _CODIVARIEDAOld
        End Get
        Set(ByVal Value As String)
            _CODIVARIEDAOld = Value
        End Set
    End Property 

    Private _CODICONTRATO As String
    <Column(Name:="Codicontrato", Storage:="CODICONTRATO", DbType:="CHAR(13)", Id:=False), _
     DataObjectField(False, False, True, 13)> _
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

    Private _NOMBLOTE As String
    <Column(Name:="Nomblote", Storage:="NOMBLOTE", DbType:="CHAR(60)", Id:=False), _
     DataObjectField(False, False, True, 60)> _
    Public Property NOMBLOTE() As String
        Get
            Return _NOMBLOTE
        End Get
        Set(ByVal Value As String)
            _NOMBLOTE = Value
            OnPropertyChanged("NOMBLOTE")
        End Set
    End Property 

    Private _NOMBLOTEOld As String
    Public Property NOMBLOTEOld() As String
        Get
            Return _NOMBLOTEOld
        End Get
        Set(ByVal Value As String)
            _NOMBLOTEOld = Value
        End Set
    End Property 

    Private _AREA As Decimal
    <Column(Name:="Area", Storage:="AREA", DbType:="NUMERIC(10,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=2)> _
    Public Property AREA() As Decimal
        Get
            Return _AREA
        End Get
        Set(ByVal Value As Decimal)
            _AREA = Value
            OnPropertyChanged("AREA")
        End Set
    End Property 

    Private _AREAOld As Decimal
    Public Property AREAOld() As Decimal
        Get
            Return _AREAOld
        End Get
        Set(ByVal Value As Decimal)
            _AREAOld = Value
        End Set
    End Property 

    Private _TONELADAS As Decimal
    <Column(Name:="Toneladas", Storage:="TONELADAS", DbType:="NUMERIC(10,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=2)> _
    Public Property TONELADAS() As Decimal
        Get
            Return _TONELADAS
        End Get
        Set(ByVal Value As Decimal)
            _TONELADAS = Value
            OnPropertyChanged("TONELADAS")
        End Set
    End Property 

    Private _TONELADASOld As Decimal
    Public Property TONELADASOld() As Decimal
        Get
            Return _TONELADASOld
        End Get
        Set(ByVal Value As Decimal)
            _TONELADASOld = Value
        End Set
    End Property 

    Private _TONEL_TC As Decimal
    <Column(Name:="Tonel tc", Storage:="TONEL_TC", DbType:="NUMERIC(10,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=2)> _
    Public Property TONEL_TC() As Decimal
        Get
            Return _TONEL_TC
        End Get
        Set(ByVal Value As Decimal)
            _TONEL_TC = Value
            OnPropertyChanged("TONEL_TC")
        End Set
    End Property 

    Private _TONEL_TCOld As Decimal
    Public Property TONEL_TCOld() As Decimal
        Get
            Return _TONEL_TCOld
        End Get
        Set(ByVal Value As Decimal)
            _TONEL_TCOld = Value
        End Set
    End Property 

    Private _ZONA As String
    <Column(Name:="Zona", Storage:="ZONA", DbType:="CHAR(2)", Id:=False), _
     DataObjectField(False, False, True, 2)> _
    Public Property ZONA() As String
        Get
            Return _ZONA
        End Get
        Set(ByVal Value As String)
            _ZONA = Value
            OnPropertyChanged("ZONA")
        End Set
    End Property 

    Private _ZONAOld As String
    Public Property ZONAOld() As String
        Get
            Return _ZONAOld
        End Get
        Set(ByVal Value As String)
            _ZONAOld = Value
        End Set
    End Property 

    Private _EDAD_LOTE As Decimal
    <Column(Name:="Edad lote", Storage:="EDAD_LOTE", DbType:="NUMERIC(5,0)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=5, Scale:=0)> _
    Public Property EDAD_LOTE() As Decimal
        Get
            Return _EDAD_LOTE
        End Get
        Set(ByVal Value As Decimal)
            _EDAD_LOTE = Value
            OnPropertyChanged("EDAD_LOTE")
        End Set
    End Property 

    Private _EDAD_LOTEOld As Decimal
    Public Property EDAD_LOTEOld() As Decimal
        Get
            Return _EDAD_LOTEOld
        End Get
        Set(ByVal Value As Decimal)
            _EDAD_LOTEOld = Value
        End Set
    End Property 

    Private _USUARIO_CREA As String
    <Column(Name:="Usuario crea", Storage:="USUARIO_CREA", DbType:="VARCHAR(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
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
    <Column(Name:="Fecha crea", Storage:="FECHA_CREA", DbType:="DATETIME", Id:=False), _
     DataObjectField(False, False, True)> _
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

    Private _ID_MAESTRO As Int32
    <Column(Name:="Id maestro", Storage:="ID_MAESTRO", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_MAESTRO() As Int32
        Get
            Return _ID_MAESTRO
        End Get
        Set(ByVal Value As Int32)
            _ID_MAESTRO = Value
            OnPropertyChanged("ID_MAESTRO")
        End Set
    End Property 

    Private _ID_MAESTROOld As Int32
    Public Property ID_MAESTROOld() As Int32
        Get
            Return _ID_MAESTROOld
        End Get
        Set(ByVal Value As Int32)
            _ID_MAESTROOld = Value
        End Set
    End Property 

    Private _TIPO_DERECHO As Int32
    <Column(Name:="Tipo derecho", Storage:="TIPO_DERECHO", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property TIPO_DERECHO() As Int32
        Get
            Return _TIPO_DERECHO
        End Get
        Set(ByVal Value As Int32)
            _TIPO_DERECHO = Value
            OnPropertyChanged("TIPO_DERECHO")
        End Set
    End Property 

    Private _TIPO_DERECHOOld As Int32
    Public Property TIPO_DERECHOOld() As Int32
        Get
            Return _TIPO_DERECHOOld
        End Get
        Set(ByVal Value As Int32)
            _TIPO_DERECHOOld = Value
        End Set
    End Property 

    Private _SUB_ZONA As String
    <Column(Name:="Sub zona", Storage:="SUB_ZONA", DbType:="VARCHAR(6)", Id:=False), _
     DataObjectField(False, False, True, 6)> _
    Public Property SUB_ZONA() As String
        Get
            Return _SUB_ZONA
        End Get
        Set(ByVal Value As String)
            _SUB_ZONA = Value
            OnPropertyChanged("SUB_ZONA")
        End Set
    End Property 

    Private _SUB_ZONAOld As String
    Public Property SUB_ZONAOld() As String
        Get
            Return _SUB_ZONAOld
        End Get
        Set(ByVal Value As String)
            _SUB_ZONAOld = Value
        End Set
    End Property

    Private _ID_ZAFRA_TRASPASO As Int32
    <Column(Name:="Id zafra traspaso", Storage:="ID_ZAFRA_TRASPASO", DBType:="INT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property ID_ZAFRA_TRASPASO() As Int32
        Get
            Return _ID_ZAFRA_TRASPASO
        End Get
        Set(ByVal Value As Int32)
            _ID_ZAFRA_TRASPASO = Value
            OnPropertyChanged("ID_ZAFRA_TRASPASO")
        End Set
    End Property

    Private _ID_ZAFRA_TRASPASOOld As Int32
    Public Property ID_ZAFRA_TRASPASOOld() As Int32
        Get
            Return _ID_ZAFRA_TRASPASOOld
        End Get
        Set(ByVal Value As Int32)
            _ID_ZAFRA_TRASPASOOld = Value
        End Set
    End Property

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
