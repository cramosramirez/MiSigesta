''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.ACUKARDE
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row ACUKARDE en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	20/11/2023	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="ACUKARDE")> Public Class ACUKARDE
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID As Int32, aCODIGO As String, aMATERIAL As String, aTIPO_DOC As String, aDOCUMENTO As Decimal, aFECHA As DateTime, aUENT As Decimal, aUSAL As Decimal, aSALDO As Decimal, aVENT As Decimal, aVSAL As Decimal, aVSALDO As Decimal, aPROMEDIO As Decimal, aORDEN As Decimal, aPROVEEDOR As String, aCUENTA As String, aNOMCUENTA As String, aUNIDAD As String)
        Me._ID = aID
        Me._CODIGO = aCODIGO
        Me._MATERIAL = aMATERIAL
        Me._TIPO_DOC = aTIPO_DOC
        Me._DOCUMENTO = aDOCUMENTO
        Me._FECHA = aFECHA
        Me._UENT = aUENT
        Me._USAL = aUSAL
        Me._SALDO = aSALDO
        Me._VENT = aVENT
        Me._VSAL = aVSAL
        Me._VSALDO = aVSALDO
        Me._PROMEDIO = aPROMEDIO
        Me._ORDEN = aORDEN
        Me._PROVEEDOR = aPROVEEDOR
        Me._CUENTA = aCUENTA
        Me._NOMCUENTA = aNOMCUENTA
        Me._UNIDAD = aUNIDAD
    End Sub

#Region " Properties "

    Private _ID As Int32
    <Column(Name:="Id", Storage:="ID", DBType:="INT NULL", Id:=True),
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property ID() As Int32
        Get
            Return _ID
        End Get
        Set(ByVal Value As Int32)
            _ID = Value
            OnPropertyChanged("ID")
        End Set
    End Property 

    Private _CODIGO As String
    <Column(Name:="Codigo", Storage:="CODIGO", DBType:="CHAR(10) NULL", Id:=False),
     DataObjectField(False, False, True, 10)>
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

    Private _MATERIAL As String
    <Column(Name:="Material", Storage:="MATERIAL", DBType:="CHAR(100) NULL", Id:=False),
     DataObjectField(False, False, True, 100)>
    Public Property MATERIAL() As String
        Get
            Return _MATERIAL
        End Get
        Set(ByVal Value As String)
            _MATERIAL = Value
            OnPropertyChanged("MATERIAL")
        End Set
    End Property 

    Private _MATERIALOld As String
    Public Property MATERIALOld() As String
        Get
            Return _MATERIALOld
        End Get
        Set(ByVal Value As String)
            _MATERIALOld = Value
        End Set
    End Property 

    Private _TIPO_DOC As String
    <Column(Name:="Tipo doc", Storage:="TIPO_DOC", DBType:="CHAR(3) NULL", Id:=False),
     DataObjectField(False, False, True, 3)>
    Public Property TIPO_DOC() As String
        Get
            Return _TIPO_DOC
        End Get
        Set(ByVal Value As String)
            _TIPO_DOC = Value
            OnPropertyChanged("TIPO_DOC")
        End Set
    End Property 

    Private _TIPO_DOCOld As String
    Public Property TIPO_DOCOld() As String
        Get
            Return _TIPO_DOCOld
        End Get
        Set(ByVal Value As String)
            _TIPO_DOCOld = Value
        End Set
    End Property 

    Private _DOCUMENTO As Decimal
    <Column(Name:="Documento", Storage:="DOCUMENTO", DBType:="NUMERIC(10,0) NULL", Id:=False),
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=0)>
    Public Property DOCUMENTO() As Decimal
        Get
            Return _DOCUMENTO
        End Get
        Set(ByVal Value As Decimal)
            _DOCUMENTO = Value
            OnPropertyChanged("DOCUMENTO")
        End Set
    End Property 

    Private _DOCUMENTOOld As Decimal
    Public Property DOCUMENTOOld() As Decimal
        Get
            Return _DOCUMENTOOld
        End Get
        Set(ByVal Value As Decimal)
            _DOCUMENTOOld = Value
        End Set
    End Property 

    Private _FECHA As DateTime
    <Column(Name:="Fecha", Storage:="FECHA", DBType:="DATETIME NULL", Id:=False),
     DataObjectField(False, False, True)>
    Public Property FECHA() As DateTime
        Get
            Return _FECHA
        End Get
        Set(ByVal Value As DateTime)
            _FECHA = Value
            OnPropertyChanged("FECHA")
        End Set
    End Property 

    Private _FECHAOld As DateTime
    Public Property FECHAOld() As DateTime
        Get
            Return _FECHAOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHAOld = Value
        End Set
    End Property 

    Private _UENT As Decimal
    <Column(Name:="Uent", Storage:="UENT", DBType:="NUMERIC(14,2) NULL", Id:=False),
     DataObjectField(False, False, True), Precision(Precision:=14, Scale:=2)>
    Public Property UENT() As Decimal
        Get
            Return _UENT
        End Get
        Set(ByVal Value As Decimal)
            _UENT = Value
            OnPropertyChanged("UENT")
        End Set
    End Property 

    Private _UENTOld As Decimal
    Public Property UENTOld() As Decimal
        Get
            Return _UENTOld
        End Get
        Set(ByVal Value As Decimal)
            _UENTOld = Value
        End Set
    End Property 

    Private _USAL As Decimal
    <Column(Name:="Usal", Storage:="USAL", DBType:="NUMERIC(14,2) NULL", Id:=False),
     DataObjectField(False, False, True), Precision(Precision:=14, Scale:=2)>
    Public Property USAL() As Decimal
        Get
            Return _USAL
        End Get
        Set(ByVal Value As Decimal)
            _USAL = Value
            OnPropertyChanged("USAL")
        End Set
    End Property 

    Private _USALOld As Decimal
    Public Property USALOld() As Decimal
        Get
            Return _USALOld
        End Get
        Set(ByVal Value As Decimal)
            _USALOld = Value
        End Set
    End Property 

    Private _SALDO As Decimal
    <Column(Name:="Saldo", Storage:="SALDO", DBType:="NUMERIC(14,2) NULL", Id:=False),
     DataObjectField(False, False, True), Precision(Precision:=14, Scale:=2)>
    Public Property SALDO() As Decimal
        Get
            Return _SALDO
        End Get
        Set(ByVal Value As Decimal)
            _SALDO = Value
            OnPropertyChanged("SALDO")
        End Set
    End Property 

    Private _SALDOOld As Decimal
    Public Property SALDOOld() As Decimal
        Get
            Return _SALDOOld
        End Get
        Set(ByVal Value As Decimal)
            _SALDOOld = Value
        End Set
    End Property 

    Private _VENT As Decimal
    <Column(Name:="Vent", Storage:="VENT", DBType:="NUMERIC(14,2) NULL", Id:=False),
     DataObjectField(False, False, True), Precision(Precision:=14, Scale:=2)>
    Public Property VENT() As Decimal
        Get
            Return _VENT
        End Get
        Set(ByVal Value As Decimal)
            _VENT = Value
            OnPropertyChanged("VENT")
        End Set
    End Property 

    Private _VENTOld As Decimal
    Public Property VENTOld() As Decimal
        Get
            Return _VENTOld
        End Get
        Set(ByVal Value As Decimal)
            _VENTOld = Value
        End Set
    End Property 

    Private _VSAL As Decimal
    <Column(Name:="Vsal", Storage:="VSAL", DBType:="NUMERIC(14,2) NULL", Id:=False),
     DataObjectField(False, False, True), Precision(Precision:=14, Scale:=2)>
    Public Property VSAL() As Decimal
        Get
            Return _VSAL
        End Get
        Set(ByVal Value As Decimal)
            _VSAL = Value
            OnPropertyChanged("VSAL")
        End Set
    End Property 

    Private _VSALOld As Decimal
    Public Property VSALOld() As Decimal
        Get
            Return _VSALOld
        End Get
        Set(ByVal Value As Decimal)
            _VSALOld = Value
        End Set
    End Property 

    Private _VSALDO As Decimal
    <Column(Name:="Vsaldo", Storage:="VSALDO", DBType:="NUMERIC(14,2) NULL", Id:=False),
     DataObjectField(False, False, True), Precision(Precision:=14, Scale:=2)>
    Public Property VSALDO() As Decimal
        Get
            Return _VSALDO
        End Get
        Set(ByVal Value As Decimal)
            _VSALDO = Value
            OnPropertyChanged("VSALDO")
        End Set
    End Property 

    Private _VSALDOOld As Decimal
    Public Property VSALDOOld() As Decimal
        Get
            Return _VSALDOOld
        End Get
        Set(ByVal Value As Decimal)
            _VSALDOOld = Value
        End Set
    End Property 

    Private _PROMEDIO As Decimal
    <Column(Name:="Promedio", Storage:="PROMEDIO", DBType:="NUMERIC(19,8) NULL", Id:=False),
     DataObjectField(False, False, True), Precision(Precision:=19, Scale:=8)>
    Public Property PROMEDIO() As Decimal
        Get
            Return _PROMEDIO
        End Get
        Set(ByVal Value As Decimal)
            _PROMEDIO = Value
            OnPropertyChanged("PROMEDIO")
        End Set
    End Property 

    Private _PROMEDIOOld As Decimal
    Public Property PROMEDIOOld() As Decimal
        Get
            Return _PROMEDIOOld
        End Get
        Set(ByVal Value As Decimal)
            _PROMEDIOOld = Value
        End Set
    End Property 

    Private _ORDEN As Decimal
    <Column(Name:="Orden", Storage:="ORDEN", DBType:="NUMERIC(1,0) NULL", Id:=False),
     DataObjectField(False, False, True), Precision(Precision:=1, Scale:=0)>
    Public Property ORDEN() As Decimal
        Get
            Return _ORDEN
        End Get
        Set(ByVal Value As Decimal)
            _ORDEN = Value
            OnPropertyChanged("ORDEN")
        End Set
    End Property 

    Private _ORDENOld As Decimal
    Public Property ORDENOld() As Decimal
        Get
            Return _ORDENOld
        End Get
        Set(ByVal Value As Decimal)
            _ORDENOld = Value
        End Set
    End Property 

    Private _PROVEEDOR As String
    <Column(Name:="Proveedor", Storage:="PROVEEDOR", DBType:="CHAR(18) NULL", Id:=False),
     DataObjectField(False, False, True, 18)>
    Public Property PROVEEDOR() As String
        Get
            Return _PROVEEDOR
        End Get
        Set(ByVal Value As String)
            _PROVEEDOR = Value
            OnPropertyChanged("PROVEEDOR")
        End Set
    End Property 

    Private _PROVEEDOROld As String
    Public Property PROVEEDOROld() As String
        Get
            Return _PROVEEDOROld
        End Get
        Set(ByVal Value As String)
            _PROVEEDOROld = Value
        End Set
    End Property 

    Private _CUENTA As String
    <Column(Name:="Cuenta", Storage:="CUENTA", DBType:="CHAR(30) NULL", Id:=False),
     DataObjectField(False, False, True, 30)>
    Public Property CUENTA() As String
        Get
            Return _CUENTA
        End Get
        Set(ByVal Value As String)
            _CUENTA = Value
            OnPropertyChanged("CUENTA")
        End Set
    End Property 

    Private _CUENTAOld As String
    Public Property CUENTAOld() As String
        Get
            Return _CUENTAOld
        End Get
        Set(ByVal Value As String)
            _CUENTAOld = Value
        End Set
    End Property 

    Private _NOMCUENTA As String
    <Column(Name:="Nomcuenta", Storage:="NOMCUENTA", DBType:="CHAR(50) NULL", Id:=False),
     DataObjectField(False, False, True, 50)>
    Public Property NOMCUENTA() As String
        Get
            Return _NOMCUENTA
        End Get
        Set(ByVal Value As String)
            _NOMCUENTA = Value
            OnPropertyChanged("NOMCUENTA")
        End Set
    End Property 

    Private _NOMCUENTAOld As String
    Public Property NOMCUENTAOld() As String
        Get
            Return _NOMCUENTAOld
        End Get
        Set(ByVal Value As String)
            _NOMCUENTAOld = Value
        End Set
    End Property 

    Private _UNIDAD As String
    <Column(Name:="Unidad", Storage:="UNIDAD", DBType:="CHAR(5) NULL", Id:=False),
     DataObjectField(False, False, True, 5)>
    Public Property UNIDAD() As String
        Get
            Return _UNIDAD
        End Get
        Set(ByVal Value As String)
            _UNIDAD = Value
            OnPropertyChanged("UNIDAD")
        End Set
    End Property 

    Private _UNIDADOld As String
    Public Property UNIDADOld() As String
        Get
            Return _UNIDADOld
        End Get
        Set(ByVal Value As String)
            _UNIDADOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
