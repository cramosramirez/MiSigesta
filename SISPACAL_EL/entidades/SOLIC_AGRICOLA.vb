''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.SOLIC_AGRICOLA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row SOLIC_AGRICOLA en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	08/06/2017	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="SOLIC_AGRICOLA")> Public Class SOLIC_AGRICOLA
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_SOLICITUD As Int32, aID_ZAFRA As Int32, aNUM_SOLICITUD As Int32, aCODIPROVEEDOR As String, aNOMBRE_PROVEEDOR As String, aACTIVIDAD As String, aFECHA_SOLIC As DateTime, aFECHA_APLICA As DateTime, aDUI As String, aNIT As String, aNRC As String, aTIPO_CONTRIBUYENTE As Int32, aSUB_TOTAL As Decimal, aIVA As Decimal, aTOTAL As Decimal, aESTADO As Int32, aOBSERVACIONES As String, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime, aZAFRA As String, aCODIAGRON As String, aCODICONTRATO As String, aUID_SOLIC_AGRICOLA As Guid, aID_CATEGORIA As Int32, aID_CUENTA_FINAN As Int32, aCONDI_COMPRA As Int32, aCONTRATOS As String, aFOVIAL_COTRANS As Decimal)
        Me._ID_SOLICITUD = aID_SOLICITUD
        Me._ID_ZAFRA = aID_ZAFRA
        Me._NUM_SOLICITUD = aNUM_SOLICITUD
        Me._CODIPROVEEDOR = aCODIPROVEEDOR
        Me._NOMBRE_PROVEEDOR = aNOMBRE_PROVEEDOR
        Me._ACTIVIDAD = aACTIVIDAD
        Me._FECHA_SOLIC = aFECHA_SOLIC
        Me._FECHA_APLICA = aFECHA_APLICA
        Me._DUI = aDUI
        Me._NIT = aNIT
        Me._NRC = aNRC
        Me._TIPO_CONTRIBUYENTE = aTIPO_CONTRIBUYENTE
        Me._SUB_TOTAL = aSUB_TOTAL
        Me._IVA = aIVA
        Me._TOTAL = aTOTAL
        Me._ESTADO = aESTADO
        Me._OBSERVACIONES = aOBSERVACIONES
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
        Me._ZAFRA = aZAFRA
        Me._CODIAGRON = aCODIAGRON
        Me._CODICONTRATO = aCODICONTRATO
        Me._UID_SOLIC_AGRICOLA = aUID_SOLIC_AGRICOLA
        Me._ID_CATEGORIA = aID_CATEGORIA
        Me._ID_CUENTA_FINAN = aID_CUENTA_FINAN
        Me._CONDI_COMPRA = aCONDI_COMPRA
        Me._CONTRATOS = aCONTRATOS
        Me._FOVIAL_COTRANS = aFOVIAL_COTRANS
    End Sub

#Region " Properties "

    Private _ID_SOLICITUD As Int32
    <Column(Name:="Id solicitud", Storage:="ID_SOLICITUD", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_SOLICITUD() As Int32
        Get
            Return _ID_SOLICITUD
        End Get
        Set(ByVal Value As Int32)
            _ID_SOLICITUD = Value
            OnPropertyChanged("ID_SOLICITUD")
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

    Private _NUM_SOLICITUD As Int32
    <Column(Name:="Num solicitud", Storage:="NUM_SOLICITUD", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property NUM_SOLICITUD() As Int32
        Get
            Return _NUM_SOLICITUD
        End Get
        Set(ByVal Value As Int32)
            _NUM_SOLICITUD = Value
            OnPropertyChanged("NUM_SOLICITUD")
        End Set
    End Property 

    Private _NUM_SOLICITUDOld As Int32
    Public Property NUM_SOLICITUDOld() As Int32
        Get
            Return _NUM_SOLICITUDOld
        End Get
        Set(ByVal Value As Int32)
            _NUM_SOLICITUDOld = Value
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

    Private _ACTIVIDAD As String
    <Column(Name:="Actividad", Storage:="ACTIVIDAD", DbType:="VARCHAR(100) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 100)> _
    Public Property ACTIVIDAD() As String
        Get
            Return _ACTIVIDAD
        End Get
        Set(ByVal Value As String)
            _ACTIVIDAD = Value
            OnPropertyChanged("ACTIVIDAD")
        End Set
    End Property 

    Private _ACTIVIDADOld As String
    Public Property ACTIVIDADOld() As String
        Get
            Return _ACTIVIDADOld
        End Get
        Set(ByVal Value As String)
            _ACTIVIDADOld = Value
        End Set
    End Property 

    Private _FECHA_SOLIC As DateTime
    <Column(Name:="Fecha solic", Storage:="FECHA_SOLIC", DbType:="DATETIME NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
    Public Property FECHA_SOLIC() As DateTime
        Get
            Return _FECHA_SOLIC
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_SOLIC = Value
            OnPropertyChanged("FECHA_SOLIC")
        End Set
    End Property 

    Private _FECHA_SOLICOld As DateTime
    Public Property FECHA_SOLICOld() As DateTime
        Get
            Return _FECHA_SOLICOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_SOLICOld = Value
        End Set
    End Property 

    Private _FECHA_APLICA As DateTime
    <Column(Name:="Fecha aplica", Storage:="FECHA_APLICA", DbType:="DATETIME", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_APLICA() As DateTime
        Get
            Return _FECHA_APLICA
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_APLICA = Value
            OnPropertyChanged("FECHA_APLICA")
        End Set
    End Property 

    Private _FECHA_APLICAOld As DateTime
    Public Property FECHA_APLICAOld() As DateTime
        Get
            Return _FECHA_APLICAOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_APLICAOld = Value
        End Set
    End Property 

    Private _DUI As String
    <Column(Name:="Dui", Storage:="DUI", DbType:="VARCHAR(9)", Id:=False), _
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

    Private _NIT As String
    <Column(Name:="Nit", Storage:="NIT", DbType:="VARCHAR(14)", Id:=False), _
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
    <Column(Name:="Nrc", Storage:="NRC", DbType:="CHAR(10)", Id:=False), _
     DataObjectField(False, False, True, 10)> _
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

    Private _TIPO_CONTRIBUYENTE As Int32
    <Column(Name:="Tipo contribuyente", Storage:="TIPO_CONTRIBUYENTE", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property TIPO_CONTRIBUYENTE() As Int32
        Get
            Return _TIPO_CONTRIBUYENTE
        End Get
        Set(ByVal Value As Int32)
            _TIPO_CONTRIBUYENTE = Value
            OnPropertyChanged("TIPO_CONTRIBUYENTE")
        End Set
    End Property 

    Private _TIPO_CONTRIBUYENTEOld As Int32
    Public Property TIPO_CONTRIBUYENTEOld() As Int32
        Get
            Return _TIPO_CONTRIBUYENTEOld
        End Get
        Set(ByVal Value As Int32)
            _TIPO_CONTRIBUYENTEOld = Value
        End Set
    End Property 

    Private _SUB_TOTAL As Decimal
    <Column(Name:="Sub total", Storage:="SUB_TOTAL", DbType:="NUMERIC(20,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)> _
    Public Property SUB_TOTAL() As Decimal
        Get
            Return _SUB_TOTAL
        End Get
        Set(ByVal Value As Decimal)
            _SUB_TOTAL = Value
            OnPropertyChanged("SUB_TOTAL")
        End Set
    End Property 

    Private _SUB_TOTALOld As Decimal
    Public Property SUB_TOTALOld() As Decimal
        Get
            Return _SUB_TOTALOld
        End Get
        Set(ByVal Value As Decimal)
            _SUB_TOTALOld = Value
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

    Private _TOTAL As Decimal
    <Column(Name:="Total", Storage:="TOTAL", DbType:="NUMERIC(20,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)> _
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

    Private _ESTADO As Int32
    <Column(Name:="Estado", Storage:="ESTADO", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ESTADO() As Int32
        Get
            Return _ESTADO
        End Get
        Set(ByVal Value As Int32)
            _ESTADO = Value
            OnPropertyChanged("ESTADO")
        End Set
    End Property 

    Private _ESTADOOld As Int32
    Public Property ESTADOOld() As Int32
        Get
            Return _ESTADOOld
        End Get
        Set(ByVal Value As Int32)
            _ESTADOOld = Value
        End Set
    End Property 

    Private _OBSERVACIONES As String
    <Column(Name:="Observaciones", Storage:="OBSERVACIONES", DbType:="VARCHAR(1000)", Id:=False), _
     DataObjectField(False, False, True, 1000)> _
    Public Property OBSERVACIONES() As String
        Get
            Return _OBSERVACIONES
        End Get
        Set(ByVal Value As String)
            _OBSERVACIONES = Value
            OnPropertyChanged("OBSERVACIONES")
        End Set
    End Property 

    Private _OBSERVACIONESOld As String
    Public Property OBSERVACIONESOld() As String
        Get
            Return _OBSERVACIONESOld
        End Get
        Set(ByVal Value As String)
            _OBSERVACIONESOld = Value
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

    Private _CODIAGRON As String
    <Column(Name:="Codiagron", Storage:="CODIAGRON", DbType:="CHAR(8)", Id:=False), _
     DataObjectField(False, False, True, 8)> _
    Public Property CODIAGRON() As String
        Get
            Return _CODIAGRON
        End Get
        Set(ByVal Value As String)
            _CODIAGRON = Value
            OnPropertyChanged("CODIAGRON")
        End Set
    End Property 

    Private _CODIAGRONOld As String
    Public Property CODIAGRONOld() As String
        Get
            Return _CODIAGRONOld
        End Get
        Set(ByVal Value As String)
            _CODIAGRONOld = Value
        End Set
    End Property 

    Private _CODICONTRATO As String
    <Column(Name:="Codicontrato", Storage:="CODICONTRATO", DbType:="NCHAR(26)", Id:=False), _
     DataObjectField(False, False, True, 26)> _
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

    Private _UID_SOLIC_AGRICOLA As Guid
    <Column(Name:="Uid solic agricola", Storage:="UID_SOLIC_AGRICOLA", DBType:="UNIQUEIDENTIFIER(36, 0)", Id:=False),
     DataObjectField(False, False, True, 16)>
    Public Property UID_SOLIC_AGRICOLA() As Guid
        Get
            Return _UID_SOLIC_AGRICOLA
        End Get
        Set(ByVal Value As Guid)
            _UID_SOLIC_AGRICOLA = Value
            OnPropertyChanged("UID_SOLIC_AGRICOLA")
        End Set
    End Property 

    Private _UID_SOLIC_AGRICOLAOld As Guid
    Public Property UID_SOLIC_AGRICOLAOld() As Guid
        Get
            Return _UID_SOLIC_AGRICOLAOld
        End Get
        Set(ByVal Value As Guid)
            _UID_SOLIC_AGRICOLAOld = Value
        End Set
    End Property 

    Private _ID_CATEGORIA As Int32
    <Column(Name:="Id categoria", Storage:="ID_CATEGORIA", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_CATEGORIA() As Int32
        Get
            Return _ID_CATEGORIA
        End Get
        Set(ByVal Value As Int32)
            _ID_CATEGORIA = Value
            OnPropertyChanged("ID_CATEGORIA")
        End Set
    End Property 

    Private _ID_CATEGORIAOld As Int32
    Public Property ID_CATEGORIAOld() As Int32
        Get
            Return _ID_CATEGORIAOld
        End Get
        Set(ByVal Value As Int32)
            _ID_CATEGORIAOld = Value
        End Set
    End Property 

    Private _fkID_CATEGORIA As CATEGORIA_PROD
    Public Property fkID_CATEGORIA() As CATEGORIA_PROD
        Get
            Return _fkID_CATEGORIA
        End Get
        Set(ByVal Value As CATEGORIA_PROD)
            _fkID_CATEGORIA = Value
        End Set
    End Property 

    Private _ID_CUENTA_FINAN As Int32
    <Column(Name:="Id cuenta finan", Storage:="ID_CUENTA_FINAN", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
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

    Private _CONDI_COMPRA As Int32
    <Column(Name:="Condi compra", Storage:="CONDI_COMPRA", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property CONDI_COMPRA() As Int32
        Get
            Return _CONDI_COMPRA
        End Get
        Set(ByVal Value As Int32)
            _CONDI_COMPRA = Value
            OnPropertyChanged("CONDI_COMPRA")
        End Set
    End Property 

    Private _CONDI_COMPRAOld As Int32
    Public Property CONDI_COMPRAOld() As Int32
        Get
            Return _CONDI_COMPRAOld
        End Get
        Set(ByVal Value As Int32)
            _CONDI_COMPRAOld = Value
        End Set
    End Property


    Private _CONTRATOS As String
    <Column(Name:="Contratos", Storage:="CONTRATOS", DbType:="VARCHAR(200)", Id:=False), _
     DataObjectField(False, False, True, 1000)> _
    Public Property CONTRATOS() As String
        Get
            Return _CONTRATOS
        End Get
        Set(ByVal Value As String)
            _CONTRATOS = Value
            OnPropertyChanged("CONTRATOS")
        End Set
    End Property

    Private _CONTRATOSOld As String
    Public Property CONTRATOSOld() As String
        Get
            Return _CONTRATOSOld
        End Get
        Set(ByVal Value As String)
            _CONTRATOSOld = Value
        End Set
    End Property

    Private _FOVIAL_COTRANS As Decimal
    <Column(Name:="FOVIAL_COTRANS", Storage:="FOVIAL_COTRANS", DbType:="NUMERIC(20,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)> _
    Public Property FOVIAL_COTRANS() As Decimal
        Get
            Return _FOVIAL_COTRANS
        End Get
        Set(ByVal Value As Decimal)
            _FOVIAL_COTRANS = Value
            OnPropertyChanged("FOVIAL_COTRANS")
        End Set
    End Property

    Private _FOVIAL_COTRANSOld As Decimal
    Public Property FOVIAL_COTRANSOld() As Decimal
        Get
            Return _FOVIAL_COTRANSOld
        End Get
        Set(ByVal Value As Decimal)
            _FOVIAL_COTRANSOld = Value
        End Set
    End Property

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
