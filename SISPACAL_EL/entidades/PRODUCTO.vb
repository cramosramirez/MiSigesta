''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.PRODUCTO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row PRODUCTO en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	28/11/2019	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="PRODUCTO")> Public Class PRODUCTO
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_PRODUCTO As Int32, aNOMBRE_PRODUCTO As String, aID_CATEGORIA As Int32, aID_UNIDAD As Int32, aPRECIO_UNITARIO As Decimal, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime, aZAFRA As String, aVENTSEMA_INI As Int32, aVENTSEMA_FIN As Int32, aNOMBRE_COMERCIAL As String, aID_CUENTA_FINAN As Int32, aPRESENTACION As String, aPORC_SUBSIDIO As Decimal, aID_ZAFRA As Int32, aACTIVO As Boolean, aEXISTENCIA As Decimal, aEN_CONSIGNA As Boolean, aID_PROVEE As Int32, aAPLICA_CESC As Boolean)
        Me._ID_PRODUCTO = aID_PRODUCTO
        Me._NOMBRE_PRODUCTO = aNOMBRE_PRODUCTO
        Me._ID_CATEGORIA = aID_CATEGORIA
        Me._ID_UNIDAD = aID_UNIDAD
        Me._PRECIO_UNITARIO = aPRECIO_UNITARIO
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
        Me._ZAFRA = aZAFRA
        Me._VENTSEMA_INI = aVENTSEMA_INI
        Me._VENTSEMA_FIN = aVENTSEMA_FIN
        Me._NOMBRE_COMERCIAL = aNOMBRE_COMERCIAL
        Me._ID_CUENTA_FINAN = aID_CUENTA_FINAN
        Me._PRESENTACION = aPRESENTACION
        Me._PORC_SUBSIDIO = aPORC_SUBSIDIO
        Me._ID_ZAFRA = aID_ZAFRA
        Me._ACTIVO = aACTIVO
        Me._EXISTENCIA = aEXISTENCIA
        Me._EN_CONSIGNA = aEN_CONSIGNA
        Me._ID_PROVEE = aID_PROVEE
        Me._APLICA_CESC = aAPLICA_CESC
    End Sub

#Region " Properties "

    Private _ID_PRODUCTO As Int32
    <Column(Name:="Id producto", Storage:="ID_PRODUCTO", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_PRODUCTO() As Int32
        Get
            Return _ID_PRODUCTO
        End Get
        Set(ByVal Value As Int32)
            _ID_PRODUCTO = Value
            OnPropertyChanged("ID_PRODUCTO")
        End Set
    End Property 

    Private _NOMBRE_PRODUCTO As String
    <Column(Name:="Nombre producto", Storage:="NOMBRE_PRODUCTO", DbType:="VARCHAR(100) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 100)> _
    Public Property NOMBRE_PRODUCTO() As String
        Get
            Return _NOMBRE_PRODUCTO
        End Get
        Set(ByVal Value As String)
            _NOMBRE_PRODUCTO = Value
            OnPropertyChanged("NOMBRE_PRODUCTO")
        End Set
    End Property 

    Private _NOMBRE_PRODUCTOOld As String
    Public Property NOMBRE_PRODUCTOOld() As String
        Get
            Return _NOMBRE_PRODUCTOOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_PRODUCTOOld = Value
        End Set
    End Property 

    Private _ID_CATEGORIA As Int32
    <Column(Name:="Id categoria", Storage:="ID_CATEGORIA", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
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

    Private _ID_UNIDAD As Int32
    <Column(Name:="Id unidad", Storage:="ID_UNIDAD", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_UNIDAD() As Int32
        Get
            Return _ID_UNIDAD
        End Get
        Set(ByVal Value As Int32)
            _ID_UNIDAD = Value
            OnPropertyChanged("ID_UNIDAD")
        End Set
    End Property 

    Private _ID_UNIDADOld As Int32
    Public Property ID_UNIDADOld() As Int32
        Get
            Return _ID_UNIDADOld
        End Get
        Set(ByVal Value As Int32)
            _ID_UNIDADOld = Value
        End Set
    End Property 

    Private _fkID_UNIDAD As UNIDAD_MEDIDA
    Public Property fkID_UNIDAD() As UNIDAD_MEDIDA
        Get
            Return _fkID_UNIDAD
        End Get
        Set(ByVal Value As UNIDAD_MEDIDA)
            _fkID_UNIDAD = Value
        End Set
    End Property 

    Private _PRECIO_UNITARIO As Decimal
    <Column(Name:="Precio unitario", Storage:="PRECIO_UNITARIO", DbType:="NUMERIC(20,4) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=4)> _
    Public Property PRECIO_UNITARIO() As Decimal
        Get
            Return _PRECIO_UNITARIO
        End Get
        Set(ByVal Value As Decimal)
            _PRECIO_UNITARIO = Value
            OnPropertyChanged("PRECIO_UNITARIO")
        End Set
    End Property 

    Private _PRECIO_UNITARIOOld As Decimal
    Public Property PRECIO_UNITARIOOld() As Decimal
        Get
            Return _PRECIO_UNITARIOOld
        End Get
        Set(ByVal Value As Decimal)
            _PRECIO_UNITARIOOld = Value
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

    Private _VENTSEMA_INI As Int32
    <Column(Name:="Ventsema ini", Storage:="VENTSEMA_INI", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property VENTSEMA_INI() As Int32
        Get
            Return _VENTSEMA_INI
        End Get
        Set(ByVal Value As Int32)
            _VENTSEMA_INI = Value
            OnPropertyChanged("VENTSEMA_INI")
        End Set
    End Property 

    Private _VENTSEMA_INIOld As Int32
    Public Property VENTSEMA_INIOld() As Int32
        Get
            Return _VENTSEMA_INIOld
        End Get
        Set(ByVal Value As Int32)
            _VENTSEMA_INIOld = Value
        End Set
    End Property 

    Private _VENTSEMA_FIN As Int32
    <Column(Name:="Ventsema fin", Storage:="VENTSEMA_FIN", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property VENTSEMA_FIN() As Int32
        Get
            Return _VENTSEMA_FIN
        End Get
        Set(ByVal Value As Int32)
            _VENTSEMA_FIN = Value
            OnPropertyChanged("VENTSEMA_FIN")
        End Set
    End Property 

    Private _VENTSEMA_FINOld As Int32
    Public Property VENTSEMA_FINOld() As Int32
        Get
            Return _VENTSEMA_FINOld
        End Get
        Set(ByVal Value As Int32)
            _VENTSEMA_FINOld = Value
        End Set
    End Property 

    Private _NOMBRE_COMERCIAL As String
    <Column(Name:="Nombre comercial", Storage:="NOMBRE_COMERCIAL", DbType:="VARCHAR(200)", Id:=False), _
     DataObjectField(False, False, True, 200)> _
    Public Property NOMBRE_COMERCIAL() As String
        Get
            Return _NOMBRE_COMERCIAL
        End Get
        Set(ByVal Value As String)
            _NOMBRE_COMERCIAL = Value
            OnPropertyChanged("NOMBRE_COMERCIAL")
        End Set
    End Property 

    Private _NOMBRE_COMERCIALOld As String
    Public Property NOMBRE_COMERCIALOld() As String
        Get
            Return _NOMBRE_COMERCIALOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_COMERCIALOld = Value
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

    Private _PRESENTACION As String
    <Column(Name:="Presentacion", Storage:="PRESENTACION", DbType:="VARCHAR(50)", Id:=False), _
     DataObjectField(False, False, True, 50)> _
    Public Property PRESENTACION() As String
        Get
            Return _PRESENTACION
        End Get
        Set(ByVal Value As String)
            _PRESENTACION = Value
            OnPropertyChanged("PRESENTACION")
        End Set
    End Property 

    Private _PRESENTACIONOld As String
    Public Property PRESENTACIONOld() As String
        Get
            Return _PRESENTACIONOld
        End Get
        Set(ByVal Value As String)
            _PRESENTACIONOld = Value
        End Set
    End Property 

    Private _PORC_SUBSIDIO As Decimal
    <Column(Name:="Porc subsidio", Storage:="PORC_SUBSIDIO", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property PORC_SUBSIDIO() As Decimal
        Get
            Return _PORC_SUBSIDIO
        End Get
        Set(ByVal Value As Decimal)
            _PORC_SUBSIDIO = Value
            OnPropertyChanged("PORC_SUBSIDIO")
        End Set
    End Property 

    Private _PORC_SUBSIDIOOld As Decimal
    Public Property PORC_SUBSIDIOOld() As Decimal
        Get
            Return _PORC_SUBSIDIOOld
        End Get
        Set(ByVal Value As Decimal)
            _PORC_SUBSIDIOOld = Value
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

    Private _ACTIVO As Boolean
    <Column(Name:="Activo", Storage:="ACTIVO", DbType:="BIT", Id:=False), _
     DataObjectField(False, False, True, 1)> _
    Public Property ACTIVO() As Boolean
        Get
            Return _ACTIVO
        End Get
        Set(ByVal Value As Boolean)
            _ACTIVO = Value
            OnPropertyChanged("ACTIVO")
        End Set
    End Property 

    Private _ACTIVOOld As Boolean
    Public Property ACTIVOOld() As Boolean
        Get
            Return _ACTIVOOld
        End Get
        Set(ByVal Value As Boolean)
            _ACTIVOOld = Value
        End Set
    End Property 

    Private _EXISTENCIA As Decimal
    <Column(Name:="Existencia", Storage:="EXISTENCIA", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property EXISTENCIA() As Decimal
        Get
            Return _EXISTENCIA
        End Get
        Set(ByVal Value As Decimal)
            _EXISTENCIA = Value
            OnPropertyChanged("EXISTENCIA")
        End Set
    End Property 

    Private _EXISTENCIAOld As Decimal
    Public Property EXISTENCIAOld() As Decimal
        Get
            Return _EXISTENCIAOld
        End Get
        Set(ByVal Value As Decimal)
            _EXISTENCIAOld = Value
        End Set
    End Property 

    Private _EN_CONSIGNA As Boolean
    <Column(Name:="En consigna", Storage:="EN_CONSIGNA", DbType:="BIT NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 1)> _
    Public Property EN_CONSIGNA() As Boolean
        Get
            Return _EN_CONSIGNA
        End Get
        Set(ByVal Value As Boolean)
            _EN_CONSIGNA = Value
            OnPropertyChanged("EN_CONSIGNA")
        End Set
    End Property 

    Private _EN_CONSIGNAOld As Boolean
    Public Property EN_CONSIGNAOld() As Boolean
        Get
            Return _EN_CONSIGNAOld
        End Get
        Set(ByVal Value As Boolean)
            _EN_CONSIGNAOld = Value
        End Set
    End Property 

    Private _ID_PROVEE As Int32
    <Column(Name:="Id provee", Storage:="ID_PROVEE", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_PROVEE() As Int32
        Get
            Return _ID_PROVEE
        End Get
        Set(ByVal Value As Int32)
            _ID_PROVEE = Value
            OnPropertyChanged("ID_PROVEE")
        End Set
    End Property 

    Private _ID_PROVEEOld As Int32
    Public Property ID_PROVEEOld() As Int32
        Get
            Return _ID_PROVEEOld
        End Get
        Set(ByVal Value As Int32)
            _ID_PROVEEOld = Value
        End Set
    End Property 

    Private _fkID_PROVEE As PROVEEDOR_AGRICOLA
    Public Property fkID_PROVEE() As PROVEEDOR_AGRICOLA
        Get
            Return _fkID_PROVEE
        End Get
        Set(ByVal Value As PROVEEDOR_AGRICOLA)
            _fkID_PROVEE = Value
        End Set
    End Property 

    Private _APLICA_CESC As Boolean
    <Column(Name:="Aplica cesc", Storage:="APLICA_CESC", DbType:="BIT NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 1)> _
    Public Property APLICA_CESC() As Boolean
        Get
            Return _APLICA_CESC
        End Get
        Set(ByVal Value As Boolean)
            _APLICA_CESC = Value
            OnPropertyChanged("APLICA_CESC")
        End Set
    End Property 

    Private _APLICA_CESCOld As Boolean
    Public Property APLICA_CESCOld() As Boolean
        Get
            Return _APLICA_CESCOld
        End Get
        Set(ByVal Value As Boolean)
            _APLICA_CESCOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
