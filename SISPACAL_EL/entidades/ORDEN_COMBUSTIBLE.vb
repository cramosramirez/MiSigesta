''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.ORDEN_COMBUSTIBLE
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row ORDEN_COMBUSTIBLE en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	30/10/2018	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="ORDEN_COMBUSTIBLE")> Public Class ORDEN_COMBUSTIBLE
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_ORDEN_COMBUS As Int32, aID_ZAFRA As Int32, aID_PROVEEDOR_COMBUS As Int32, aID_TRANSPORTE As Int32, aID_MOTORISTA As Int32, aFECHA_EMISION As DateTime, aNOMBRES_MOTORISTA As String, aAPELLIDOS_MOTORISTA As String, aPLACA As String, aFECHA_DESPACHO As DateTime, aNO_FACTURA_CCF As String, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime, aDUI As String, aLICENCIA As String, aESTADO As String, aFECHA_ANULACION As DateTime, aMOTIVO_ANULACION As String, aNO_ORDEN As String, aID_ORDEN_COMBUSTIBLE_NUM As Int32, aTOTAL As Decimal, aCODIGO As String, aID_TIPO_PROVEEDOR As Int32, aID_CATORCENA As Int32, aNIT As String, aNRC As String, aCODIBARRA As String, aID_SECCION As Int32, aOBSERVACION As String, aID_MOTORISTA_VEHI As Int32)
        Me._ID_ORDEN_COMBUS = aID_ORDEN_COMBUS
        Me._ID_ZAFRA = aID_ZAFRA
        Me._ID_PROVEEDOR_COMBUS = aID_PROVEEDOR_COMBUS
        Me._ID_TRANSPORTE = aID_TRANSPORTE
        Me._ID_MOTORISTA = aID_MOTORISTA
        Me._FECHA_EMISION = aFECHA_EMISION
        Me._NOMBRES_MOTORISTA = aNOMBRES_MOTORISTA
        Me._APELLIDOS_MOTORISTA = aAPELLIDOS_MOTORISTA
        Me._PLACA = aPLACA
        Me._FECHA_DESPACHO = aFECHA_DESPACHO
        Me._NO_FACTURA_CCF = aNO_FACTURA_CCF
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
        Me._DUI = aDUI
        Me._LICENCIA = aLICENCIA
        Me._ESTADO = aESTADO
        Me._FECHA_ANULACION = aFECHA_ANULACION
        Me._MOTIVO_ANULACION = aMOTIVO_ANULACION
        Me._NO_ORDEN = aNO_ORDEN
        Me._ID_ORDEN_COMBUSTIBLE_NUM = aID_ORDEN_COMBUSTIBLE_NUM
        Me._TOTAL = aTOTAL
        Me._CODIGO = aCODIGO
        Me._ID_TIPO_PROVEEDOR = aID_TIPO_PROVEEDOR
        Me._ID_CATORCENA = aID_CATORCENA
        Me._NIT = aNIT
        Me._NRC = aNRC
        Me._CODIBARRA = aCODIBARRA
        Me._ID_SECCION = aID_SECCION
        Me._OBSERVACION = aOBSERVACION
        Me._ID_MOTORISTA_VEHI = aID_MOTORISTA_VEHI
    End Sub

#Region " Properties "

    Private _ID_ORDEN_COMBUS As Int32
    <Column(Name:="Id orden combus", Storage:="ID_ORDEN_COMBUS", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_ORDEN_COMBUS() As Int32
        Get
            Return _ID_ORDEN_COMBUS
        End Get
        Set(ByVal Value As Int32)
            _ID_ORDEN_COMBUS = Value
            OnPropertyChanged("ID_ORDEN_COMBUS")
        End Set
    End Property 

    Private _ID_ZAFRA As Int32
    <Column(Name:="Id zafra", Storage:="ID_ZAFRA", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
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

    Private _ID_PROVEEDOR_COMBUS As Int32
    <Column(Name:="Id proveedor combus", Storage:="ID_PROVEEDOR_COMBUS", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_PROVEEDOR_COMBUS() As Int32
        Get
            Return _ID_PROVEEDOR_COMBUS
        End Get
        Set(ByVal Value As Int32)
            _ID_PROVEEDOR_COMBUS = Value
            OnPropertyChanged("ID_PROVEEDOR_COMBUS")
        End Set
    End Property 

    Private _ID_PROVEEDOR_COMBUSOld As Int32
    Public Property ID_PROVEEDOR_COMBUSOld() As Int32
        Get
            Return _ID_PROVEEDOR_COMBUSOld
        End Get
        Set(ByVal Value As Int32)
            _ID_PROVEEDOR_COMBUSOld = Value
        End Set
    End Property 

    Private _fkID_PROVEEDOR_COMBUS As PROVEEDOR_COMBUSTIBLE
    Public Property fkID_PROVEEDOR_COMBUS() As PROVEEDOR_COMBUSTIBLE
        Get
            Return _fkID_PROVEEDOR_COMBUS
        End Get
        Set(ByVal Value As PROVEEDOR_COMBUSTIBLE)
            _fkID_PROVEEDOR_COMBUS = Value
        End Set
    End Property 

    Private _ID_TRANSPORTE As Int32
    <Column(Name:="Id transporte", Storage:="ID_TRANSPORTE", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_TRANSPORTE() As Int32
        Get
            Return _ID_TRANSPORTE
        End Get
        Set(ByVal Value As Int32)
            _ID_TRANSPORTE = Value
            OnPropertyChanged("ID_TRANSPORTE")
        End Set
    End Property 

    Private _ID_TRANSPORTEOld As Int32
    Public Property ID_TRANSPORTEOld() As Int32
        Get
            Return _ID_TRANSPORTEOld
        End Get
        Set(ByVal Value As Int32)
            _ID_TRANSPORTEOld = Value
        End Set
    End Property 

    Private _ID_MOTORISTA As Int32
    <Column(Name:="Id motorista", Storage:="ID_MOTORISTA", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_MOTORISTA() As Int32
        Get
            Return _ID_MOTORISTA
        End Get
        Set(ByVal Value As Int32)
            _ID_MOTORISTA = Value
            OnPropertyChanged("ID_MOTORISTA")
        End Set
    End Property 

    Private _ID_MOTORISTAOld As Int32
    Public Property ID_MOTORISTAOld() As Int32
        Get
            Return _ID_MOTORISTAOld
        End Get
        Set(ByVal Value As Int32)
            _ID_MOTORISTAOld = Value
        End Set
    End Property 

    Private _FECHA_EMISION As DateTime
    <Column(Name:="Fecha emision", Storage:="FECHA_EMISION", DbType:="DATETIME", Id:=False), _
     DataObjectField(False, False, True)> _
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

    Private _NOMBRES_MOTORISTA As String
    <Column(Name:="Nombres motorista", Storage:="NOMBRES_MOTORISTA", DbType:="VARCHAR(60)", Id:=False), _
     DataObjectField(False, False, True, 60)> _
    Public Property NOMBRES_MOTORISTA() As String
        Get
            Return _NOMBRES_MOTORISTA
        End Get
        Set(ByVal Value As String)
            _NOMBRES_MOTORISTA = Value
            OnPropertyChanged("NOMBRES_MOTORISTA")
        End Set
    End Property 

    Private _NOMBRES_MOTORISTAOld As String
    Public Property NOMBRES_MOTORISTAOld() As String
        Get
            Return _NOMBRES_MOTORISTAOld
        End Get
        Set(ByVal Value As String)
            _NOMBRES_MOTORISTAOld = Value
        End Set
    End Property 

    Private _APELLIDOS_MOTORISTA As String
    <Column(Name:="Apellidos motorista", Storage:="APELLIDOS_MOTORISTA", DbType:="VARCHAR(60)", Id:=False), _
     DataObjectField(False, False, True, 60)> _
    Public Property APELLIDOS_MOTORISTA() As String
        Get
            Return _APELLIDOS_MOTORISTA
        End Get
        Set(ByVal Value As String)
            _APELLIDOS_MOTORISTA = Value
            OnPropertyChanged("APELLIDOS_MOTORISTA")
        End Set
    End Property 

    Private _APELLIDOS_MOTORISTAOld As String
    Public Property APELLIDOS_MOTORISTAOld() As String
        Get
            Return _APELLIDOS_MOTORISTAOld
        End Get
        Set(ByVal Value As String)
            _APELLIDOS_MOTORISTAOld = Value
        End Set
    End Property 

    Private _PLACA As String
    <Column(Name:="Placa", Storage:="PLACA", DbType:="VARCHAR(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
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

    Private _FECHA_DESPACHO As DateTime
    <Column(Name:="Fecha despacho", Storage:="FECHA_DESPACHO", DbType:="DATETIME", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_DESPACHO() As DateTime
        Get
            Return _FECHA_DESPACHO
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_DESPACHO = Value
            OnPropertyChanged("FECHA_DESPACHO")
        End Set
    End Property 

    Private _FECHA_DESPACHOOld As DateTime
    Public Property FECHA_DESPACHOOld() As DateTime
        Get
            Return _FECHA_DESPACHOOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_DESPACHOOld = Value
        End Set
    End Property 

    Private _NO_FACTURA_CCF As String
    <Column(Name:="No factura ccf", Storage:="NO_FACTURA_CCF", DbType:="VARCHAR(30)", Id:=False), _
     DataObjectField(False, False, True, 30)> _
    Public Property NO_FACTURA_CCF() As String
        Get
            Return _NO_FACTURA_CCF
        End Get
        Set(ByVal Value As String)
            _NO_FACTURA_CCF = Value
            OnPropertyChanged("NO_FACTURA_CCF")
        End Set
    End Property 

    Private _NO_FACTURA_CCFOld As String
    Public Property NO_FACTURA_CCFOld() As String
        Get
            Return _NO_FACTURA_CCFOld
        End Get
        Set(ByVal Value As String)
            _NO_FACTURA_CCFOld = Value
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

    Private _DUI As String
    <Column(Name:="Dui", Storage:="DUI", DbType:="CHAR(9)", Id:=False), _
     DataObjectField(False, False, True, 9)> _
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

    Private _LICENCIA As String
    <Column(Name:="Licencia", Storage:="LICENCIA", DBType:="CHAR(14)", Id:=False),
     DataObjectField(False, False, True, 14)>
    Public Property LICENCIA() As String
        Get
            Return _LICENCIA
        End Get
        Set(ByVal Value As String)
            _LICENCIA = Value
            OnPropertyChanged("LICENCIA")
        End Set
    End Property 

    Private _LICENCIAOld As String
    Public Property LICENCIAOld() As String
        Get
            Return _LICENCIAOld
        End Get
        Set(ByVal Value As String)
            _LICENCIAOld = Value
        End Set
    End Property 

    Private _ESTADO As String
    <Column(Name:="Estado", Storage:="ESTADO", DbType:="CHAR(1)", Id:=False), _
     DataObjectField(False, False, True, 1)> _
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

    Private _FECHA_ANULACION As DateTime
    <Column(Name:="Fecha anulacion", Storage:="FECHA_ANULACION", DbType:="DATETIME", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_ANULACION() As DateTime
        Get
            Return _FECHA_ANULACION
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_ANULACION = Value
            OnPropertyChanged("FECHA_ANULACION")
        End Set
    End Property 

    Private _FECHA_ANULACIONOld As DateTime
    Public Property FECHA_ANULACIONOld() As DateTime
        Get
            Return _FECHA_ANULACIONOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_ANULACIONOld = Value
        End Set
    End Property 

    Private _MOTIVO_ANULACION As String
    <Column(Name:="Motivo anulacion", Storage:="MOTIVO_ANULACION", DbType:="VARCHAR(1000)", Id:=False), _
     DataObjectField(False, False, True, 1000)> _
    Public Property MOTIVO_ANULACION() As String
        Get
            Return _MOTIVO_ANULACION
        End Get
        Set(ByVal Value As String)
            _MOTIVO_ANULACION = Value
            OnPropertyChanged("MOTIVO_ANULACION")
        End Set
    End Property 

    Private _MOTIVO_ANULACIONOld As String
    Public Property MOTIVO_ANULACIONOld() As String
        Get
            Return _MOTIVO_ANULACIONOld
        End Get
        Set(ByVal Value As String)
            _MOTIVO_ANULACIONOld = Value
        End Set
    End Property 

    Private _NO_ORDEN As String
    <Column(Name:="No orden", Storage:="NO_ORDEN", DbType:="VARCHAR(30)", Id:=False), _
     DataObjectField(False, False, True, 30)> _
    Public Property NO_ORDEN() As String
        Get
            Return _NO_ORDEN
        End Get
        Set(ByVal Value As String)
            _NO_ORDEN = Value
            OnPropertyChanged("NO_ORDEN")
        End Set
    End Property 

    Private _NO_ORDENOld As String
    Public Property NO_ORDENOld() As String
        Get
            Return _NO_ORDENOld
        End Get
        Set(ByVal Value As String)
            _NO_ORDENOld = Value
        End Set
    End Property 

    Private _ID_ORDEN_COMBUSTIBLE_NUM As Int32
    <Column(Name:="Id orden combustible num", Storage:="ID_ORDEN_COMBUSTIBLE_NUM", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_ORDEN_COMBUSTIBLE_NUM() As Int32
        Get
            Return _ID_ORDEN_COMBUSTIBLE_NUM
        End Get
        Set(ByVal Value As Int32)
            _ID_ORDEN_COMBUSTIBLE_NUM = Value
            OnPropertyChanged("ID_ORDEN_COMBUSTIBLE_NUM")
        End Set
    End Property 

    Private _ID_ORDEN_COMBUSTIBLE_NUMOld As Int32
    Public Property ID_ORDEN_COMBUSTIBLE_NUMOld() As Int32
        Get
            Return _ID_ORDEN_COMBUSTIBLE_NUMOld
        End Get
        Set(ByVal Value As Int32)
            _ID_ORDEN_COMBUSTIBLE_NUMOld = Value
        End Set
    End Property 

    Private _TOTAL As Decimal
    <Column(Name:="Total", Storage:="TOTAL", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
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

    Private _CODIGO As String
    <Column(Name:="Codigo", Storage:="CODIGO", DbType:="VARCHAR(20) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 20)> _
    Public Property CODIGO() As String
        Get
            Return _CODIGO
        End Get
        Set(ByVal Value As String)
            _CODIGO = Value
            OnPropertyChanged("CODIGO")
        End Set
    End Property 

    Private _CODIGOOld As String
    Public Property CODIGOOld() As String
        Get
            Return _CODIGOOld
        End Get
        Set(ByVal Value As String)
            _CODIGOOld = Value
        End Set
    End Property 

    Private _ID_TIPO_PROVEEDOR As Int32
    <Column(Name:="Id tipo proveedor", Storage:="ID_TIPO_PROVEEDOR", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_TIPO_PROVEEDOR() As Int32
        Get
            Return _ID_TIPO_PROVEEDOR
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_PROVEEDOR = Value
            OnPropertyChanged("ID_TIPO_PROVEEDOR")
        End Set
    End Property 

    Private _ID_TIPO_PROVEEDOROld As Int32
    Public Property ID_TIPO_PROVEEDOROld() As Int32
        Get
            Return _ID_TIPO_PROVEEDOROld
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_PROVEEDOROld = Value
        End Set
    End Property 

    Private _fkID_TIPO_PROVEEDOR As TIPO_PROVEEDOR
    Public Property fkID_TIPO_PROVEEDOR() As TIPO_PROVEEDOR
        Get
            Return _fkID_TIPO_PROVEEDOR
        End Get
        Set(ByVal Value As TIPO_PROVEEDOR)
            _fkID_TIPO_PROVEEDOR = Value
        End Set
    End Property 

    Private _ID_CATORCENA As Int32
    <Column(Name:="Id catorcena", Storage:="ID_CATORCENA", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
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

    Private _NIT As String
    <Column(Name:="Nit", Storage:="NIT", DbType:="CHAR(14)", Id:=False), _
     DataObjectField(False, False, True, 14)> _
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
    <Column(Name:="Nrc", Storage:="NRC", DbType:="VARCHAR(20)", Id:=False), _
     DataObjectField(False, False, True, 20)> _
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

    Private _CODIBARRA As String
    <Column(Name:="Codibarra", Storage:="CODIBARRA", DbType:="CHAR(10)", Id:=False), _
     DataObjectField(False, False, True, 10)> _
    Public Property CODIBARRA() As String
        Get
            Return _CODIBARRA
        End Get
        Set(ByVal Value As String)
            _CODIBARRA = Value
            OnPropertyChanged("CODIBARRA")
        End Set
    End Property 

    Private _CODIBARRAOld As String
    Public Property CODIBARRAOld() As String
        Get
            Return _CODIBARRAOld
        End Get
        Set(ByVal Value As String)
            _CODIBARRAOld = Value
        End Set
    End Property 

    Private _ID_SECCION As Int32
    <Column(Name:="Id seccion", Storage:="ID_SECCION", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_SECCION() As Int32
        Get
            Return _ID_SECCION
        End Get
        Set(ByVal Value As Int32)
            _ID_SECCION = Value
            OnPropertyChanged("ID_SECCION")
        End Set
    End Property 

    Private _ID_SECCIONOld As Int32
    Public Property ID_SECCIONOld() As Int32
        Get
            Return _ID_SECCIONOld
        End Get
        Set(ByVal Value As Int32)
            _ID_SECCIONOld = Value
        End Set
    End Property 

    Private _fkID_SECCION As SECCION
    Public Property fkID_SECCION() As SECCION
        Get
            Return _fkID_SECCION
        End Get
        Set(ByVal Value As SECCION)
            _fkID_SECCION = Value
        End Set
    End Property 

    Private _OBSERVACION As String
    <Column(Name:="Observacion", Storage:="OBSERVACION", DbType:="VARCHAR(600)", Id:=False), _
     DataObjectField(False, False, True, 600)> _
    Public Property OBSERVACION() As String
        Get
            Return _OBSERVACION
        End Get
        Set(ByVal Value As String)
            _OBSERVACION = Value
            OnPropertyChanged("OBSERVACION")
        End Set
    End Property 

    Private _OBSERVACIONOld As String
    Public Property OBSERVACIONOld() As String
        Get
            Return _OBSERVACIONOld
        End Get
        Set(ByVal Value As String)
            _OBSERVACIONOld = Value
        End Set
    End Property


    Private _ID_MOTORISTA_VEHI As Int32
    <Column(Name:="Id Motorista Vehi", Storage:="ID_MOTORISTA_VEHI", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_MOTORISTA_VEHI() As Int32
        Get
            Return _ID_MOTORISTA_VEHI
        End Get
        Set(ByVal Value As Int32)
            _ID_MOTORISTA_VEHI = Value
            OnPropertyChanged("ID_MOTORISTA_VEHI")
        End Set
    End Property

    Private _ID_MOTORISTA_VEHIOld As Int32
    Public Property ID_MOTORISTA_VEHIOld() As Int32
        Get
            Return _ID_MOTORISTA_VEHIOld
        End Get
        Set(ByVal Value As Int32)
            _ID_MOTORISTA_VEHIOld = Value
        End Set
    End Property

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
