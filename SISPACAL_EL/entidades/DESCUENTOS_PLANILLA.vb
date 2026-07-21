''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.DESCUENTOS_PLANILLA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row DESCUENTOS_PLANILLA en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	16/11/2017	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="DESCUENTOS_PLANILLA")> Public Class DESCUENTOS_PLANILLA
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_DESCUENTO_PLANILLA As Int32, aID_CATORCENA As Int32, aCODIPROVEEDOR_TRANSPORTISTA As String, aID_TIPO_PLANILLA As Int32, aID_TIPO_DESCTO As Int32, aID_APLICACION_DESCTO As Int32, aMONTO_DESCUENTO As Decimal, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime, aIVA As Decimal, aCODIBANCO As Int32, aID_CREDITO_ENCA As Int32, aID_CREDITO_ENCA_TRANS As Int32)
        Me._ID_DESCUENTO_PLANILLA = aID_DESCUENTO_PLANILLA
        Me._ID_CATORCENA = aID_CATORCENA
        Me._CODIPROVEEDOR_TRANSPORTISTA = aCODIPROVEEDOR_TRANSPORTISTA
        Me._ID_TIPO_PLANILLA = aID_TIPO_PLANILLA
        Me._ID_TIPO_DESCTO = aID_TIPO_DESCTO
        Me._ID_APLICACION_DESCTO = aID_APLICACION_DESCTO
        Me._MONTO_DESCUENTO = aMONTO_DESCUENTO
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
        Me._IVA = aIVA
        Me._CODIBANCO = aCODIBANCO
        Me._ID_CREDITO_ENCA = aID_CREDITO_ENCA
        Me._ID_CREDITO_ENCA_TRANS = aID_CREDITO_ENCA_TRANS
    End Sub

#Region " Properties "

    Private _ID_DESCUENTO_PLANILLA As Int32
    <Column(Name:="Id descuento planilla", Storage:="ID_DESCUENTO_PLANILLA", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_DESCUENTO_PLANILLA() As Int32
        Get
            Return _ID_DESCUENTO_PLANILLA
        End Get
        Set(ByVal Value As Int32)
            _ID_DESCUENTO_PLANILLA = Value
            OnPropertyChanged("ID_DESCUENTO_PLANILLA")
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

    Private _CODIPROVEEDOR_TRANSPORTISTA As String
    <Column(Name:="Codiproveedor transportista", Storage:="CODIPROVEEDOR_TRANSPORTISTA", DbType:="VARCHAR(10) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 10)> _
    Public Property CODIPROVEEDOR_TRANSPORTISTA() As String
        Get
            Return _CODIPROVEEDOR_TRANSPORTISTA
        End Get
        Set(ByVal Value As String)
            _CODIPROVEEDOR_TRANSPORTISTA = Value
            OnPropertyChanged("CODIPROVEEDOR_TRANSPORTISTA")
        End Set
    End Property 

    Private _CODIPROVEEDOR_TRANSPORTISTAOld As String
    Public Property CODIPROVEEDOR_TRANSPORTISTAOld() As String
        Get
            Return _CODIPROVEEDOR_TRANSPORTISTAOld
        End Get
        Set(ByVal Value As String)
            _CODIPROVEEDOR_TRANSPORTISTAOld = Value
        End Set
    End Property 

    Private _fkCODIPROVEEDOR_TRANSPORTISTA As PLANILLA
    Public Property fkCODIPROVEEDOR_TRANSPORTISTA() As PLANILLA
        Get
            Return _fkCODIPROVEEDOR_TRANSPORTISTA
        End Get
        Set(ByVal Value As PLANILLA)
            _fkCODIPROVEEDOR_TRANSPORTISTA = Value
        End Set
    End Property 

    Private _ID_TIPO_PLANILLA As Int32
    <Column(Name:="Id tipo planilla", Storage:="ID_TIPO_PLANILLA", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_TIPO_PLANILLA() As Int32
        Get
            Return _ID_TIPO_PLANILLA
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_PLANILLA = Value
            OnPropertyChanged("ID_TIPO_PLANILLA")
        End Set
    End Property 

    Private _ID_TIPO_PLANILLAOld As Int32
    Public Property ID_TIPO_PLANILLAOld() As Int32
        Get
            Return _ID_TIPO_PLANILLAOld
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_PLANILLAOld = Value
        End Set
    End Property 

    Private _fkID_TIPO_PLANILLA As TIPO_PLANILLA
    Public Property fkID_TIPO_PLANILLA() As TIPO_PLANILLA
        Get
            Return _fkID_TIPO_PLANILLA
        End Get
        Set(ByVal Value As TIPO_PLANILLA)
            _fkID_TIPO_PLANILLA = Value
        End Set
    End Property 

    Private _ID_TIPO_DESCTO As Int32
    <Column(Name:="Id tipo descto", Storage:="ID_TIPO_DESCTO", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_TIPO_DESCTO() As Int32
        Get
            Return _ID_TIPO_DESCTO
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_DESCTO = Value
            OnPropertyChanged("ID_TIPO_DESCTO")
        End Set
    End Property 

    Private _ID_TIPO_DESCTOOld As Int32
    Public Property ID_TIPO_DESCTOOld() As Int32
        Get
            Return _ID_TIPO_DESCTOOld
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_DESCTOOld = Value
        End Set
    End Property 

    Private _fkID_TIPO_DESCTO As TIPO_DESCUENTO
    Public Property fkID_TIPO_DESCTO() As TIPO_DESCUENTO
        Get
            Return _fkID_TIPO_DESCTO
        End Get
        Set(ByVal Value As TIPO_DESCUENTO)
            _fkID_TIPO_DESCTO = Value
        End Set
    End Property 

    Private _ID_APLICACION_DESCTO As Int32
    <Column(Name:="Id aplicacion descto", Storage:="ID_APLICACION_DESCTO", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_APLICACION_DESCTO() As Int32
        Get
            Return _ID_APLICACION_DESCTO
        End Get
        Set(ByVal Value As Int32)
            _ID_APLICACION_DESCTO = Value
            OnPropertyChanged("ID_APLICACION_DESCTO")
        End Set
    End Property 

    Private _ID_APLICACION_DESCTOOld As Int32
    Public Property ID_APLICACION_DESCTOOld() As Int32
        Get
            Return _ID_APLICACION_DESCTOOld
        End Get
        Set(ByVal Value As Int32)
            _ID_APLICACION_DESCTOOld = Value
        End Set
    End Property 

    Private _fkID_APLICACION_DESCTO As APLICACION_DESCTO
    Public Property fkID_APLICACION_DESCTO() As APLICACION_DESCTO
        Get
            Return _fkID_APLICACION_DESCTO
        End Get
        Set(ByVal Value As APLICACION_DESCTO)
            _fkID_APLICACION_DESCTO = Value
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

    Private _IVA As Decimal
    <Column(Name:="Iva", Storage:="IVA", DbType:="NUMERIC(20,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)> _
    Public Property IVA() As Decimal
        Get
            Return _IVA
        End Get
        Set(ByVal Value As Decimal)
            _IVA = Value
            OnPropertyChanged("IVA")
        End Set
    End Property 

    Private _IVAOld As Decimal
    Public Property IVAOld() As Decimal
        Get
            Return _IVAOld
        End Get
        Set(ByVal Value As Decimal)
            _IVAOld = Value
        End Set
    End Property 

    Private _CODIBANCO As Int32
    <Column(Name:="Codibanco", Storage:="CODIBANCO", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property CODIBANCO() As Int32
        Get
            Return _CODIBANCO
        End Get
        Set(ByVal Value As Int32)
            _CODIBANCO = Value
            OnPropertyChanged("CODIBANCO")
        End Set
    End Property 

    Private _CODIBANCOOld As Int32
    Public Property CODIBANCOOld() As Int32
        Get
            Return _CODIBANCOOld
        End Get
        Set(ByVal Value As Int32)
            _CODIBANCOOld = Value
        End Set
    End Property 

    Private _fkCODIBANCO As BANCOS
    Public Property fkCODIBANCO() As BANCOS
        Get
            Return _fkCODIBANCO
        End Get
        Set(ByVal Value As BANCOS)
            _fkCODIBANCO = Value
        End Set
    End Property 

    Private _ID_CREDITO_ENCA As Int32
    <Column(Name:="Id credito enca", Storage:="ID_CREDITO_ENCA", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_CREDITO_ENCA() As Int32
        Get
            Return _ID_CREDITO_ENCA
        End Get
        Set(ByVal Value As Int32)
            _ID_CREDITO_ENCA = Value
            OnPropertyChanged("ID_CREDITO_ENCA")
        End Set
    End Property 

    Private _ID_CREDITO_ENCAOld As Int32
    Public Property ID_CREDITO_ENCAOld() As Int32
        Get
            Return _ID_CREDITO_ENCAOld
        End Get
        Set(ByVal Value As Int32)
            _ID_CREDITO_ENCAOld = Value
        End Set
    End Property 

    Private _fkID_CREDITO_ENCA As CREDITO_ENCA
    Public Property fkID_CREDITO_ENCA() As CREDITO_ENCA
        Get
            Return _fkID_CREDITO_ENCA
        End Get
        Set(ByVal Value As CREDITO_ENCA)
            _fkID_CREDITO_ENCA = Value
        End Set
    End Property 

    Private _ID_CREDITO_ENCA_TRANS As Int32
    <Column(Name:="Id credito enca trans", Storage:="ID_CREDITO_ENCA_TRANS", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_CREDITO_ENCA_TRANS() As Int32
        Get
            Return _ID_CREDITO_ENCA_TRANS
        End Get
        Set(ByVal Value As Int32)
            _ID_CREDITO_ENCA_TRANS = Value
            OnPropertyChanged("ID_CREDITO_ENCA_TRANS")
        End Set
    End Property 

    Private _ID_CREDITO_ENCA_TRANSOld As Int32
    Public Property ID_CREDITO_ENCA_TRANSOld() As Int32
        Get
            Return _ID_CREDITO_ENCA_TRANSOld
        End Get
        Set(ByVal Value As Int32)
            _ID_CREDITO_ENCA_TRANSOld = Value
        End Set
    End Property 

    Private _fkID_CREDITO_ENCA_TRANS As CREDITO_ENCA_TRANS
    Public Property fkID_CREDITO_ENCA_TRANS() As CREDITO_ENCA_TRANS
        Get
            Return _fkID_CREDITO_ENCA_TRANS
        End Get
        Set(ByVal Value As CREDITO_ENCA_TRANS)
            _fkID_CREDITO_ENCA_TRANS = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
