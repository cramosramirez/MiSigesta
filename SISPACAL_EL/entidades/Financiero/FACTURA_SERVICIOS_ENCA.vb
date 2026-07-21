''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.FACTURA_SERVICIOS_ENCA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row FACTURA_SERVICIOS_ENCA en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	15/07/2015	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="FACTURA_SERVICIOS_ENCA")> Public Class FACTURA_SERVICIOS_ENCA
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_FACTURA_SERVICIOS_ENCA As Int32, aNO_DOCTO As Int32, aTIPO_DOCTO As String, aFECHA_EMISION As DateTime, aESTADO As String, aCODICONTRATO As String, aCODIPROVEEDOR As String, aNOMBRE_PROVEEDOR As String, aGIRO As String, aDIRECCION As String, aDUI As String, aNIT As String, aNRC As String, aEXENTO As Decimal, aAFECTO As Decimal, aPORC_DESCUENTO As Decimal, aDESCUENTO As Decimal, aSUMAS As Decimal, aIVA As Decimal, aTOTAL As Decimal, aCANT_LETRAS As String, aID_ZAFRA As Int32, aZAFRA As String, aUID_FACTURA_SERVICIOS As Guid, aUID_REFERENCIA As Guid, aID_CUENTA_FINAN As Int32, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime, aUSUARIO_ANUL As String, aFECHA_ANUL As DateTime)
        Me._ID_FACTURA_SERVICIOS_ENCA = aID_FACTURA_SERVICIOS_ENCA
        Me._NO_DOCTO = aNO_DOCTO
        Me._TIPO_DOCTO = aTIPO_DOCTO
        Me._FECHA_EMISION = aFECHA_EMISION
        Me._ESTADO = aESTADO
        Me._CODICONTRATO = aCODICONTRATO
        Me._CODIPROVEEDOR = aCODIPROVEEDOR
        Me._NOMBRE_PROVEEDOR = aNOMBRE_PROVEEDOR
        Me._GIRO = aGIRO
        Me._DIRECCION = aDIRECCION
        Me._DUI = aDUI
        Me._NIT = aNIT
        Me._NRC = aNRC
        Me._EXENTO = aEXENTO
        Me._AFECTO = aAFECTO
        Me._PORC_DESCUENTO = aPORC_DESCUENTO
        Me._DESCUENTO = aDESCUENTO
        Me._SUMAS = aSUMAS
        Me._IVA = aIVA
        Me._TOTAL = aTOTAL
        Me._CANT_LETRAS = aCANT_LETRAS
        Me._ID_ZAFRA = aID_ZAFRA
        Me._ZAFRA = aZAFRA
        Me._UID_FACTURA_SERVICIOS = aUID_FACTURA_SERVICIOS
        Me._UID_REFERENCIA = aUID_REFERENCIA
        Me._ID_CUENTA_FINAN = aID_CUENTA_FINAN
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
        Me._USUARIO_ANUL = aUSUARIO_ANUL
        Me._FECHA_ANUL = aFECHA_ANUL
    End Sub

#Region " Properties "

    Private _ID_FACTURA_SERVICIOS_ENCA As Int32
    <Column(Name:="Id factura servicios enca", Storage:="ID_FACTURA_SERVICIOS_ENCA", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_FACTURA_SERVICIOS_ENCA() As Int32
        Get
            Return _ID_FACTURA_SERVICIOS_ENCA
        End Get
        Set(ByVal Value As Int32)
            _ID_FACTURA_SERVICIOS_ENCA = Value
            OnPropertyChanged("ID_FACTURA_SERVICIOS_ENCA")
        End Set
    End Property 

    Private _NO_DOCTO As Int32
    <Column(Name:="No docto", Storage:="NO_DOCTO", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property NO_DOCTO() As Int32
        Get
            Return _NO_DOCTO
        End Get
        Set(ByVal Value As Int32)
            _NO_DOCTO = Value
            OnPropertyChanged("NO_DOCTO")
        End Set
    End Property 

    Private _NO_DOCTOOld As Int32
    Public Property NO_DOCTOOld() As Int32
        Get
            Return _NO_DOCTOOld
        End Get
        Set(ByVal Value As Int32)
            _NO_DOCTOOld = Value
        End Set
    End Property 

    Private _TIPO_DOCTO As String
    <Column(Name:="Tipo docto", Storage:="TIPO_DOCTO", DbType:="CHAR(3) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 3)> _
    Public Property TIPO_DOCTO() As String
        Get
            Return _TIPO_DOCTO
        End Get
        Set(ByVal Value As String)
            _TIPO_DOCTO = Value
            OnPropertyChanged("TIPO_DOCTO")
        End Set
    End Property 

    Private _TIPO_DOCTOOld As String
    Public Property TIPO_DOCTOOld() As String
        Get
            Return _TIPO_DOCTOOld
        End Get
        Set(ByVal Value As String)
            _TIPO_DOCTOOld = Value
        End Set
    End Property 

    Private _FECHA_EMISION As DateTime
    <Column(Name:="Fecha emision", Storage:="FECHA_EMISION", DbType:="DATETIME NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
    Public Property FECHA_EMISION() As DateTime
        Get
            Return _FECHA_EMISION
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_EMISION = Value
            OnPropertyChanged("FECHA_EMISION")
        End Set
    End Property 

    Private _FECHA_EMISIONOld As DateTime
    Public Property FECHA_EMISIONOld() As DateTime
        Get
            Return _FECHA_EMISIONOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_EMISIONOld = Value
        End Set
    End Property 

    Private _ESTADO As String
    <Column(Name:="Estado", Storage:="ESTADO", DbType:="CHAR(1) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 1)> _
    Public Property ESTADO() As String
        Get
            Return _ESTADO
        End Get
        Set(ByVal Value As String)
            _ESTADO = Value
            OnPropertyChanged("ESTADO")
        End Set
    End Property 

    Private _ESTADOOld As String
    Public Property ESTADOOld() As String
        Get
            Return _ESTADOOld
        End Get
        Set(ByVal Value As String)
            _ESTADOOld = Value
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

    Private _CODIPROVEEDOR As String
    <Column(Name:="Codiproveedor", Storage:="CODIPROVEEDOR", DbType:="CHAR(10) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 10)> _
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

    Private _fkCODIPROVEEDOR As PROVEEDOR
    Public Property fkCODIPROVEEDOR() As PROVEEDOR
        Get
            Return _fkCODIPROVEEDOR
        End Get
        Set(ByVal Value As PROVEEDOR)
            _fkCODIPROVEEDOR = Value
        End Set
    End Property 

    Private _NOMBRE_PROVEEDOR As String
    <Column(Name:="Nombre proveedor", Storage:="NOMBRE_PROVEEDOR", DbType:="VARCHAR(72) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 72)> _
    Public Property NOMBRE_PROVEEDOR() As String
        Get
            Return _NOMBRE_PROVEEDOR
        End Get
        Set(ByVal Value As String)
            _NOMBRE_PROVEEDOR = Value
            OnPropertyChanged("NOMBRE_PROVEEDOR")
        End Set
    End Property 

    Private _NOMBRE_PROVEEDOROld As String
    Public Property NOMBRE_PROVEEDOROld() As String
        Get
            Return _NOMBRE_PROVEEDOROld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_PROVEEDOROld = Value
        End Set
    End Property 

    Private _GIRO As String
    <Column(Name:="Giro", Storage:="GIRO", DbType:="VARCHAR(300) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 300)> _
    Public Property GIRO() As String
        Get
            Return _GIRO
        End Get
        Set(ByVal Value As String)
            _GIRO = Value
            OnPropertyChanged("GIRO")
        End Set
    End Property 

    Private _GIROOld As String
    Public Property GIROOld() As String
        Get
            Return _GIROOld
        End Get
        Set(ByVal Value As String)
            _GIROOld = Value
        End Set
    End Property 

    Private _DIRECCION As String
    <Column(Name:="Direccion", Storage:="DIRECCION", DbType:="VARCHAR(500) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 500)> _
    Public Property DIRECCION() As String
        Get
            Return _DIRECCION
        End Get
        Set(ByVal Value As String)
            _DIRECCION = Value
            OnPropertyChanged("DIRECCION")
        End Set
    End Property 

    Private _DIRECCIONOld As String
    Public Property DIRECCIONOld() As String
        Get
            Return _DIRECCIONOld
        End Get
        Set(ByVal Value As String)
            _DIRECCIONOld = Value
        End Set
    End Property 

    Private _DUI As String
    <Column(Name:="Dui", Storage:="DUI", DbType:="VARCHAR(9) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 9)> _
    Public Property DUI() As String
        Get
            Return _DUI
        End Get
        Set(ByVal Value As String)
            _DUI = Value
            OnPropertyChanged("DUI")
        End Set
    End Property 

    Private _DUIOld As String
    Public Property DUIOld() As String
        Get
            Return _DUIOld
        End Get
        Set(ByVal Value As String)
            _DUIOld = Value
        End Set
    End Property 

    Private _NIT As String
    <Column(Name:="Nit", Storage:="NIT", DbType:="VARCHAR(14) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 14)> _
    Public Property NIT() As String
        Get
            Return _NIT
        End Get
        Set(ByVal Value As String)
            _NIT = Value
            OnPropertyChanged("NIT")
        End Set
    End Property 

    Private _NITOld As String
    Public Property NITOld() As String
        Get
            Return _NITOld
        End Get
        Set(ByVal Value As String)
            _NITOld = Value
        End Set
    End Property 

    Private _NRC As String
    <Column(Name:="Nrc", Storage:="NRC", DbType:="VARCHAR(10) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 10)> _
    Public Property NRC() As String
        Get
            Return _NRC
        End Get
        Set(ByVal Value As String)
            _NRC = Value
            OnPropertyChanged("NRC")
        End Set
    End Property 

    Private _NRCOld As String
    Public Property NRCOld() As String
        Get
            Return _NRCOld
        End Get
        Set(ByVal Value As String)
            _NRCOld = Value
        End Set
    End Property 

    Private _EXENTO As Decimal
    <Column(Name:="Exento", Storage:="EXENTO", DbType:="NUMERIC(10,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)> _
    Public Property EXENTO() As Decimal
        Get
            Return _EXENTO
        End Get
        Set(ByVal Value As Decimal)
            _EXENTO = Value
            OnPropertyChanged("EXENTO")
        End Set
    End Property 

    Private _EXENTOOld As Decimal
    Public Property EXENTOOld() As Decimal
        Get
            Return _EXENTOOld
        End Get
        Set(ByVal Value As Decimal)
            _EXENTOOld = Value
        End Set
    End Property 

    Private _AFECTO As Decimal
    <Column(Name:="Afecto", Storage:="AFECTO", DbType:="NUMERIC(10,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)> _
    Public Property AFECTO() As Decimal
        Get
            Return _AFECTO
        End Get
        Set(ByVal Value As Decimal)
            _AFECTO = Value
            OnPropertyChanged("AFECTO")
        End Set
    End Property 

    Private _AFECTOOld As Decimal
    Public Property AFECTOOld() As Decimal
        Get
            Return _AFECTOOld
        End Get
        Set(ByVal Value As Decimal)
            _AFECTOOld = Value
        End Set
    End Property 

    Private _PORC_DESCUENTO As Decimal
    <Column(Name:="Porc descuento", Storage:="PORC_DESCUENTO", DbType:="NUMERIC(8,3) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=8, Scale:=3)> _
    Public Property PORC_DESCUENTO() As Decimal
        Get
            Return _PORC_DESCUENTO
        End Get
        Set(ByVal Value As Decimal)
            _PORC_DESCUENTO = Value
            OnPropertyChanged("PORC_DESCUENTO")
        End Set
    End Property 

    Private _PORC_DESCUENTOOld As Decimal
    Public Property PORC_DESCUENTOOld() As Decimal
        Get
            Return _PORC_DESCUENTOOld
        End Get
        Set(ByVal Value As Decimal)
            _PORC_DESCUENTOOld = Value
        End Set
    End Property 

    Private _DESCUENTO As Decimal
    <Column(Name:="Descuento", Storage:="DESCUENTO", DbType:="NUMERIC(10,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)> _
    Public Property DESCUENTO() As Decimal
        Get
            Return _DESCUENTO
        End Get
        Set(ByVal Value As Decimal)
            _DESCUENTO = Value
            OnPropertyChanged("DESCUENTO")
        End Set
    End Property 

    Private _DESCUENTOOld As Decimal
    Public Property DESCUENTOOld() As Decimal
        Get
            Return _DESCUENTOOld
        End Get
        Set(ByVal Value As Decimal)
            _DESCUENTOOld = Value
        End Set
    End Property 

    Private _SUMAS As Decimal
    <Column(Name:="Sumas", Storage:="SUMAS", DbType:="NUMERIC(10,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)> _
    Public Property SUMAS() As Decimal
        Get
            Return _SUMAS
        End Get
        Set(ByVal Value As Decimal)
            _SUMAS = Value
            OnPropertyChanged("SUMAS")
        End Set
    End Property 

    Private _SUMASOld As Decimal
    Public Property SUMASOld() As Decimal
        Get
            Return _SUMASOld
        End Get
        Set(ByVal Value As Decimal)
            _SUMASOld = Value
        End Set
    End Property 

    Private _IVA As Decimal
    <Column(Name:="Iva", Storage:="IVA", DbType:="NUMERIC(10,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)> _
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

    Private _TOTAL As Decimal
    <Column(Name:="Total", Storage:="TOTAL", DbType:="NUMERIC(10,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)> _
    Public Property TOTAL() As Decimal
        Get
            Return _TOTAL
        End Get
        Set(ByVal Value As Decimal)
            _TOTAL = Value
            OnPropertyChanged("TOTAL")
        End Set
    End Property 

    Private _TOTALOld As Decimal
    Public Property TOTALOld() As Decimal
        Get
            Return _TOTALOld
        End Get
        Set(ByVal Value As Decimal)
            _TOTALOld = Value
        End Set
    End Property 

    Private _CANT_LETRAS As String
    <Column(Name:="Cant letras", Storage:="CANT_LETRAS", DbType:="VARCHAR(300) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 300)> _
    Public Property CANT_LETRAS() As String
        Get
            Return _CANT_LETRAS
        End Get
        Set(ByVal Value As String)
            _CANT_LETRAS = Value
            OnPropertyChanged("CANT_LETRAS")
        End Set
    End Property 

    Private _CANT_LETRASOld As String
    Public Property CANT_LETRASOld() As String
        Get
            Return _CANT_LETRASOld
        End Get
        Set(ByVal Value As String)
            _CANT_LETRASOld = Value
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

    Private _UID_FACTURA_SERVICIOS As Guid
    <Column(Name:="Uid factura servicios", Storage:="UID_FACTURA_SERVICIOS", DbType:="UNIQUEIDENTIFIER(36, 0) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 16)> _
    Public Property UID_FACTURA_SERVICIOS() As Guid
        Get
            Return _UID_FACTURA_SERVICIOS
        End Get
        Set(ByVal Value As Guid)
            _UID_FACTURA_SERVICIOS = Value
            OnPropertyChanged("UID_FACTURA_SERVICIOS")
        End Set
    End Property 

    Private _UID_FACTURA_SERVICIOSOld As Guid
    Public Property UID_FACTURA_SERVICIOSOld() As Guid
        Get
            Return _UID_FACTURA_SERVICIOSOld
        End Get
        Set(ByVal Value As Guid)
            _UID_FACTURA_SERVICIOSOld = Value
        End Set
    End Property 

    Private _UID_REFERENCIA As Guid
    <Column(Name:="Uid referencia", Storage:="UID_REFERENCIA", DbType:="UNIQUEIDENTIFIER(36, 0) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 16)> _
    Public Property UID_REFERENCIA() As Guid
        Get
            Return _UID_REFERENCIA
        End Get
        Set(ByVal Value As Guid)
            _UID_REFERENCIA = Value
            OnPropertyChanged("UID_REFERENCIA")
        End Set
    End Property 

    Private _UID_REFERENCIAOld As Guid
    Public Property UID_REFERENCIAOld() As Guid
        Get
            Return _UID_REFERENCIAOld
        End Get
        Set(ByVal Value As Guid)
            _UID_REFERENCIAOld = Value
        End Set
    End Property 

    Private _ID_CUENTA_FINAN As Int32
    <Column(Name:="Id cuenta finan", Storage:="ID_CUENTA_FINAN", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_CUENTA_FINAN() As Int32
        Get
            Return _ID_CUENTA_FINAN
        End Get
        Set(ByVal Value As Int32)
            _ID_CUENTA_FINAN = Value
            OnPropertyChanged("ID_CUENTA_FINAN")
        End Set
    End Property 

    Private _ID_CUENTA_FINANOld As Int32
    Public Property ID_CUENTA_FINANOld() As Int32
        Get
            Return _ID_CUENTA_FINANOld
        End Get
        Set(ByVal Value As Int32)
            _ID_CUENTA_FINANOld = Value
        End Set
    End Property 

    Private _fkID_CUENTA_FINAN As CUENTA_FINAN
    Public Property fkID_CUENTA_FINAN() As CUENTA_FINAN
        Get
            Return _fkID_CUENTA_FINAN
        End Get
        Set(ByVal Value As CUENTA_FINAN)
            _fkID_CUENTA_FINAN = Value
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
    <Column(Name:="Usuario act", Storage:="USUARIO_ACT", DbType:="VARCHAR(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
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

    Private _USUARIO_ANUL As String
    <Column(Name:="Usuario anul", Storage:="USUARIO_ANUL", DbType:="VARCHAR(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
    Public Property USUARIO_ANUL() As String
        Get
            Return _USUARIO_ANUL
        End Get
        Set(ByVal Value As String)
            _USUARIO_ANUL = Value
            OnPropertyChanged("USUARIO_ANUL")
        End Set
    End Property 

    Private _USUARIO_ANULOld As String
    Public Property USUARIO_ANULOld() As String
        Get
            Return _USUARIO_ANULOld
        End Get
        Set(ByVal Value As String)
            _USUARIO_ANULOld = Value
        End Set
    End Property 

    Private _FECHA_ANUL As DateTime
    <Column(Name:="Fecha anul", Storage:="FECHA_ANUL", DbType:="DATETIME NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
    Public Property FECHA_ANUL() As DateTime
        Get
            Return _FECHA_ANUL
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_ANUL = Value
            OnPropertyChanged("FECHA_ANUL")
        End Set
    End Property 

    Private _FECHA_ANULOld As DateTime
    Public Property FECHA_ANULOld() As DateTime
        Get
            Return _FECHA_ANULOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_ANULOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
