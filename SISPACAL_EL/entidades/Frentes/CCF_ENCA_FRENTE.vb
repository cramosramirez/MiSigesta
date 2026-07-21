<Serializable(), Table(Name:="CCF_ENCA_FRENTE")>
Public Class CCF_ENCA_FRENTE
    Inherits entidadBase

    Public Sub New()
    End Sub

    Private _ID_CCF_ENCA As Int32
    <Column(Name:="ID_CCF_ENCA", Storage:="ID_CCF_ENCA", DBType:="INT NOT NULL", Id:=True),
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property ID_CCF_ENCA() As Int32
        Get
            Return _ID_CCF_ENCA
        End Get
        Set(ByVal Value As Int32)
            _ID_CCF_ENCA = Value
            OnPropertyChanged("ID_CCF_ENCA")
        End Set
    End Property

    Private _ID_TIPO_PROVEEDOR As Int32
    <Column(Name:="ID_TIPO_PROVEEDOR", Storage:="ID_TIPO_PROVEEDOR", DBType:="INT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property ID_TIPO_PROVEEDOR() As Int32
        Get
            Return _ID_TIPO_PROVEEDOR
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_PROVEEDOR = Value
            OnPropertyChanged("ID_TIPO_PROVEEDOR")
        End Set
    End Property

    Private _ID_FRENTE As Int32
    <Column(Name:="ID_FRENTE", Storage:="ID_FRENTE", DBType:="INT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property ID_FRENTE() As Int32
        Get
            Return _ID_FRENTE
        End Get
        Set(ByVal Value As Int32)
            _ID_FRENTE = Value
            OnPropertyChanged("ID_FRENTE")
        End Set
    End Property

    Private _COD_FRENTE As String
    <Column(Name:="COD_FRENTE", Storage:="COD_FRENTE", DBType:="VARCHAR(30) NULL", Id:=False),
     DataObjectField(False, False, True, 30)>
    Public Property COD_FRENTE() As String
        Get
            Return _COD_FRENTE
        End Get
        Set(ByVal Value As String)
            _COD_FRENTE = Value
            OnPropertyChanged("COD_FRENTE")
        End Set
    End Property

    Private _NOM_FRENTE As String
    <Column(Name:="NOM_FRENTE", Storage:="NOM_FRENTE", DBType:="VARCHAR(100) NULL", Id:=False),
     DataObjectField(False, False, True, 100)>
    Public Property NOM_FRENTE() As String
        Get
            Return _NOM_FRENTE
        End Get
        Set(ByVal Value As String)
            _NOM_FRENTE = Value
            OnPropertyChanged("NOM_FRENTE")
        End Set
    End Property

    Private _ID_ZAFRA As Int32
    <Column(Name:="ID_ZAFRA", Storage:="ID_ZAFRA", DBType:="INT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property ID_ZAFRA() As Int32
        Get
            Return _ID_ZAFRA
        End Get
        Set(ByVal Value As Int32)
            _ID_ZAFRA = Value
            OnPropertyChanged("ID_ZAFRA")
        End Set
    End Property

    Private _ID_SOLICITUD As Int32
    <Column(Name:="ID_SOLICITUD", Storage:="ID_SOLICITUD", DBType:="INT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property ID_SOLICITUD() As Int32
        Get
            Return _ID_SOLICITUD
        End Get
        Set(ByVal Value As Int32)
            _ID_SOLICITUD = Value
            OnPropertyChanged("ID_SOLICITUD")
        End Set
    End Property

    Private _ID_CUENTA_FINAN As Int32
    <Column(Name:="ID_CUENTA_FINAN", Storage:="ID_CUENTA_FINAN", DBType:="INT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property ID_CUENTA_FINAN() As Int32
        Get
            Return _ID_CUENTA_FINAN
        End Get
        Set(ByVal Value As Int32)
            _ID_CUENTA_FINAN = Value
            OnPropertyChanged("ID_CUENTA_FINAN")
        End Set
    End Property

    Private _ID_TIPO_COMPROB As Int32
    <Column(Name:="ID_TIPO_COMPROB", Storage:="ID_TIPO_COMPROB", DBType:="INT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property ID_TIPO_COMPROB() As Int32
        Get
            Return _ID_TIPO_COMPROB
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_COMPROB = Value
            OnPropertyChanged("ID_TIPO_COMPROB")
        End Set
    End Property

    Private _ID_PROVEE As Int32
    <Column(Name:="ID_PROVEE", Storage:="ID_PROVEE", DBType:="INT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property ID_PROVEE() As Int32
        Get
            Return _ID_PROVEE
        End Get
        Set(ByVal Value As Int32)
            _ID_PROVEE = Value
            OnPropertyChanged("ID_PROVEE")
        End Set
    End Property

    Private _NO_CCF As String
    <Column(Name:="NO_CCF", Storage:="NO_CCF", DBType:="VARCHAR(20) NULL", Id:=False),
     DataObjectField(False, False, True, 20)>
    Public Property NO_CCF() As String
        Get
            Return _NO_CCF
        End Get
        Set(ByVal Value As String)
            _NO_CCF = Value
            OnPropertyChanged("NO_CCF")
        End Set
    End Property

    Private _CONDI_COMPRA As Int32
    <Column(Name:="CONDI_COMPRA", Storage:="CONDI_COMPRA", DBType:="INT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property CONDI_COMPRA() As Int32
        Get
            Return _CONDI_COMPRA
        End Get
        Set(ByVal Value As Int32)
            _CONDI_COMPRA = Value
            OnPropertyChanged("CONDI_COMPRA")
        End Set
    End Property

    Private _UID_CCF As Guid
    <Column(Name:="UID_CCF", Storage:="UID_CCF", DBType:="UNIQUEIDENTIFIER(36, 0)", Id:=False),
     DataObjectField(False, False, True, 36)>
    Public Property UID_CCF() As Guid
        Get
            Return _UID_CCF
        End Get
        Set(ByVal Value As Guid)
            _UID_CCF = Value
            OnPropertyChanged("UID_CCF")
        End Set
    End Property

    Private _FECHA As DateTime
    <Column(Name:="FECHA", Storage:="FECHA", DBType:="DATETIME NULL", Id:=False),
     DataObjectField(False, False, False)>
    Public Property FECHA() As DateTime
        Get
            Return _FECHA
        End Get
        Set(ByVal Value As DateTime)
            _FECHA = Value
            OnPropertyChanged("FECHA")
        End Set
    End Property

    Private _SUB_TOTAL As Decimal
    <Column(Name:="SUB_TOTAL", Storage:="SUB_TOTAL", DBType:="NUMERIC(20,2) NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)>
    Public Property SUB_TOTAL() As Decimal
        Get
            Return _SUB_TOTAL
        End Get
        Set(ByVal Value As Decimal)
            _SUB_TOTAL = Value
            OnPropertyChanged("SUB_TOTAL")
        End Set
    End Property

    Private _DESCTO_PORC As Decimal
    <Column(Name:="DESCTO_PORC", Storage:="DESCTO_PORC", DBType:="NUMERIC(20,2) NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)>
    Public Property DESCTO_PORC() As Decimal
        Get
            Return _DESCTO_PORC
        End Get
        Set(ByVal Value As Decimal)
            _DESCTO_PORC = Value
            OnPropertyChanged("DESCTO_PORC")
        End Set
    End Property

    Private _DESCTO_MONTO As Decimal
    <Column(Name:="DESCTO_MONTO", Storage:="DESCTO_MONTO", DBType:="NUMERIC(20,2) NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)>
    Public Property DESCTO_MONTO() As Decimal
        Get
            Return _DESCTO_MONTO
        End Get
        Set(ByVal Value As Decimal)
            _DESCTO_MONTO = Value
            OnPropertyChanged("DESCTO_MONTO")
        End Set
    End Property

    Private _SUMAS As Decimal
    <Column(Name:="SUMAS", Storage:="SUMAS", DBType:="NUMERIC(20,2) NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)>
    Public Property SUMAS() As Decimal
        Get
            Return _SUMAS
        End Get
        Set(ByVal Value As Decimal)
            _SUMAS = Value
            OnPropertyChanged("SUMAS")
        End Set
    End Property

    Private _IVA As Decimal
    <Column(Name:="IVA", Storage:="IVA", DBType:="NUMERIC(20,2) NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)>
    Public Property IVA() As Decimal
        Get
            Return _IVA
        End Get
        Set(ByVal Value As Decimal)
            _IVA = Value
            OnPropertyChanged("IVA")
        End Set
    End Property

    Private _TOTAL As Decimal
    <Column(Name:="TOTAL", Storage:="TOTAL", DBType:="NUMERIC(20,2) NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)>
    Public Property TOTAL() As Decimal
        Get
            Return _TOTAL
        End Get
        Set(ByVal Value As Decimal)
            _TOTAL = Value
            OnPropertyChanged("TOTAL")
        End Set
    End Property

    Private _USUARIO_CREACION As String
    <Column(Name:="USUARIO_CREACION", Storage:="USUARIO_CREACION", DBType:="VARCHAR(100) NULL", Id:=False),
     DataObjectField(False, False, True, 100)>
    Public Property USUARIO_CREACION() As String
        Get
            Return _USUARIO_CREACION
        End Get
        Set(ByVal Value As String)
            _USUARIO_CREACION = Value
            OnPropertyChanged("USUARIO_CREACION")
        End Set
    End Property

    Private _FECHA_CREACION As DateTime
    <Column(Name:="FECHA_CREACION", Storage:="FECHA_CREACION", DBType:="DATETIME NULL", Id:=False),
     DataObjectField(False, False, False)>
    Public Property FECHA_CREACION() As DateTime
        Get
            Return _FECHA_CREACION
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_CREACION = Value
            OnPropertyChanged("FECHA_CREACION")
        End Set
    End Property

    Private _CTA_CONTABLE As String
    <Column(Name:="CTA_CONTABLE", Storage:="CTA_CONTABLE", DBType:="VARCHAR(50)", Id:=False),
     DataObjectField(False, False, True, 50)>
    Public Property CTA_CONTABLE() As String
        Get
            Return _CTA_CONTABLE
        End Get
        Set(ByVal Value As String)
            _CTA_CONTABLE = Value
            OnPropertyChanged("CTA_CONTABLE")
        End Set
    End Property

End Class
