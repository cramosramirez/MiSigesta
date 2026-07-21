<Serializable(), Table(Name:="SUBLOTES")> Public Class SUBLOTES
    Inherits entidadBase

    Public Sub New()
    End Sub
    Private _ID_SUBLOTES As Int32
    <Column(Name:="ID_SUBLOTES", Storage:="ID_SUBLOTES", DBType:="INT NOT NULL", Id:=True),
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property ID_SUBLOTES() As Int32
        Get
            Return _ID_SUBLOTES
        End Get
        Set(ByVal Value As Int32)
            _ID_SUBLOTES = Value
            OnPropertyChanged("ID_SUBLOTES")
        End Set
    End Property
    Private _ID_MAESTRO As Int32
    <Column(Name:="ID_MAESTRO", Storage:="ID_MAESTRO", DBType:="INT NOT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property ID_MAESTRO() As Int32
        Get
            Return _ID_MAESTRO
        End Get
        Set(ByVal Value As Int32)
            _ID_MAESTRO = Value
            OnPropertyChanged("ID_MAESTRO")
        End Set
    End Property
    Private _CODIGO As String
    <Column(Name:="CODIGO", Storage:="CODIGO", DBType:="VARCHAR(50) NOT NULL", Id:=False),
     DataObjectField(False, False, True, 200)>
    Public Property CODIGO() As String
        Get
            Return _CODIGO
        End Get
        Set(ByVal Value As String)
            _CODIGO = Value
            OnPropertyChanged("CODIGO")
        End Set
    End Property
    Private _CORRELATIVO As Int32
    <Column(Name:="CORRELATIVO", Storage:="CORRELATIVO", DBType:="INT NOT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property CORRELATIVO() As Int32
        Get
            Return _CORRELATIVO
        End Get
        Set(ByVal Value As Int32)
            _CORRELATIVO = Value
            OnPropertyChanged("CORRELATIVO")
        End Set
    End Property
    Private _NOMBRE_PORCION As String
    <Column(Name:="NOMBRE_PORCION", Storage:="NOMBRE_PORCION", DBType:="VARCHAR(200) NOT NULL", Id:=False),
     DataObjectField(False, False, True, 200)>
    Public Property NOMBRE_PORCION() As String
        Get
            Return _NOMBRE_PORCION
        End Get
        Set(ByVal Value As String)
            _NOMBRE_PORCION = Value
            OnPropertyChanged("NOMBRE_PORCION")
        End Set
    End Property
    Private _CODIVARIEDA As String
    <Column(Name:="CODIVARIEDA", Storage:="CODIVARIEDA", DBType:="CHAR(3) NOT NULL", Id:=False),
     DataObjectField(False, False, True, 3)>
    Public Property CODIVARIEDA() As String
        Get
            Return _CODIVARIEDA
        End Get
        Set(ByVal Value As String)
            _CODIVARIEDA = Value
            OnPropertyChanged("CODIVARIEDA")
        End Set
    End Property
    Private _ID_TIPO_SIEMBRA As Int32
    <Column(Name:="ID_TIPO_SIEMBRA", Storage:="ID_TIPO_SIEMBRA", DBType:="NOT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property ID_TIPO_SIEMBRA() As Int32
        Get
            Return _ID_TIPO_SIEMBRA
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_SIEMBRA = Value
            OnPropertyChanged("ID_TIPO_SIEMBRA")
        End Set
    End Property
    Private _FECHA_SIEMBRA As DateTime
    <Column(Name:="FECHA_SIEMBRA", Storage:="FECHA_SIEMBRA", DBType:="DateTime NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property FECHA_SIEMBRA() As DateTime
        Get
            Return _FECHA_SIEMBRA
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_SIEMBRA = Value
            OnPropertyChanged("FECHA_SIEMBRA")
        End Set
    End Property
    Private _DISTANCIAMIENTO As Decimal
    <Column(Name:="DISTANCIAMIENTO", Storage:="DISTANCIAMIENTO", DBType:="NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)>
    Public Property DISTANCIAMIENTO() As Decimal
        Get
            Return _DISTANCIAMIENTO
        End Get
        Set(ByVal Value As Decimal)
            _DISTANCIAMIENTO = Value
            OnPropertyChanged("DISTANCIAMIENTO")
        End Set
    End Property
    Private _CICLO As Int32
    <Column(Name:="CICLO", Storage:="CICLO", DBType:="NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property CICLO() As Int32
        Get
            Return _CICLO
        End Get
        Set(ByVal Value As Int32)
            _CICLO = Value
            OnPropertyChanged("CICLO")
        End Set
    End Property
    Private _ZONA_RAMSAR As Boolean
    <Column(Name:="ZONA_RAMSAR", Storage:="ZONA_RAMSAR", DBType:="NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property ZONA_RAMSAR() As Boolean
        Get
            Return _ZONA_RAMSAR
        End Get
        Set(ByVal Value As Boolean)
            _ZONA_RAMSAR = Value
            OnPropertyChanged("ZONA_RAMSAR")
        End Set
    End Property
    Private _LONGITUD As String
    <Column(Name:="LONGITUD", Storage:="LONGITUD", DBType:="VARCHAR(50) NULL", Id:=False),
     DataObjectField(False, False, True, 50)>
    Public Property LONGITUD() As String
        Get
            Return _LONGITUD
        End Get
        Set(ByVal Value As String)
            _LONGITUD = Value
            OnPropertyChanged("LONGITUD")
        End Set
    End Property
    Private _LATITUD As String
    <Column(Name:="LATITUD", Storage:="LATITUD", DBType:="VARCHAR(50) NULL", Id:=False),
     DataObjectField(False, False, True, 50)>
    Public Property LATITUD() As String
        Get
            Return _LATITUD
        End Get
        Set(ByVal Value As String)
            _LATITUD = Value
            OnPropertyChanged("LATITUD")
        End Set
    End Property
    Private _ALTITUD As String
    <Column(Name:="ALTITUD", Storage:="ALTITUD", DBType:="VARCHAR(50) NULL", Id:=False),
     DataObjectField(False, False, True, 50)>
    Public Property ALTITUD() As String
        Get
            Return _ALTITUD
        End Get
        Set(ByVal Value As String)
            _ALTITUD = Value
            OnPropertyChanged("ALTITUD")
        End Set
    End Property

    Private _ID_RIESGO_PIEDRA As Int32
    <Column(Name:="ID_RIESGO_PIEDRA", Storage:="ID_RIESGO_PIEDRA", DBType:="INT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property ID_RIESGO_PIEDRA() As Int32
        Get
            Return _ID_RIESGO_PIEDRA
        End Get
        Set(ByVal Value As Int32)
            _ID_RIESGO_PIEDRA = Value
            OnPropertyChanged("ID_RIESGO_PIEDRA")
        End Set
    End Property
    Private _ID_ESTRATO As Int32
    <Column(Name:="ID_ESTRATO", Storage:="ID_ESTRATO", DBType:="INT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property ID_ESTRATO() As Int32
        Get
            Return _ID_ESTRATO
        End Get
        Set(ByVal Value As Int32)
            _ID_ESTRATO = Value
            OnPropertyChanged("ID_ESTRATO")
        End Set
    End Property
    Private _ID_TOPOGRAFIA As Int32
    <Column(Name:="ID_TOPOGRAFIA", Storage:="ID_TOPOGRAFIA", DBType:="INT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property ID_TOPOGRAFIA() As Int32
        Get
            Return _ID_TOPOGRAFIA
        End Get
        Set(ByVal Value As Int32)
            _ID_TOPOGRAFIA = Value
            OnPropertyChanged("ID_TOPOGRAFIA")
        End Set
    End Property
    Private _VIABILIDAD_RIEGO As Boolean
    <Column(Name:="VIABILIDAD_RIEGO", Storage:="VIABILIDAD_RIEGO", DBType:="NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property VIABILIDAD_RIEGO() As Boolean
        Get
            Return _VIABILIDAD_RIEGO
        End Get
        Set(ByVal Value As Boolean)
            _VIABILIDAD_RIEGO = Value
            OnPropertyChanged("VIABILIDAD_RIEGO")
        End Set
    End Property
    Private _AREA_CONTRATO As Decimal
    <Column(Name:="AREA_CONTRATO", Storage:="AREA_CONTRATO", DBType:="NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)>
    Public Property AREA_CONTRATO() As Decimal
        Get
            Return _AREA_CONTRATO
        End Get
        Set(ByVal Value As Decimal)
            _AREA_CONTRATO = Value
            OnPropertyChanged("AREA_CONTRATO")
        End Set
    End Property
    Private _AREA_PRODUCTIVA As Decimal
    <Column(Name:="AREA_PRODUCTIVA", Storage:="AREA_PRODUCTIVA", DBType:="NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)>
    Public Property AREA_PRODUCTIVA() As Decimal
        Get
            Return _AREA_PRODUCTIVA
        End Get
        Set(ByVal Value As Decimal)
            _AREA_PRODUCTIVA = Value
            OnPropertyChanged("AREA_PRODUCTIVA")
        End Set
    End Property

    Private _AREA_EFEC As Decimal
    <Column(Name:="AREA_EFEC", Storage:="AREA_EFEC", DBType:="NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)>
    Public Property AREA_EFEC() As Decimal
        Get
            Return _AREA_EFEC
        End Get
        Set(ByVal Value As Decimal)
            _AREA_EFEC = Value
            OnPropertyChanged("AREA_EFEC")
        End Set
    End Property
    Private _TC_MZ_EFEC As Double
    <Column(Name:="TC_MZ_EFEC", Storage:="TC_MZ_EFEC", DBType:="NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)>
    Public Property TC_MZ_EFEC() As Double
        Get
            Return _TC_MZ_EFEC
        End Get
        Set(ByVal Value As Double)
            _TC_MZ_EFEC = Value
            OnPropertyChanged("TC_MZ_EFEC")
        End Set
    End Property
    Private _TC_EFEC As Double
    <Column(Name:="TC_EFEC", Storage:="TC_EFEC", DBType:="NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)>
    Public Property TC_EFEC() As Double
        Get
            Return _TC_EFEC
        End Get
        Set(ByVal Value As Double)
            _TC_EFEC = Value
            OnPropertyChanged("TC_EFEC")
        End Set
    End Property
    Private _ID_USO_MAD As Int32
    <Column(Name:="ID_USO_MAD", Storage:="ID_USO_MAD", DBType:="INT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property ID_USO_MAD() As Int32
        Get
            Return _ID_USO_MAD
        End Get
        Set(ByVal Value As Int32)
            _ID_USO_MAD = Value
            OnPropertyChanged("ID_USO_MAD")
        End Set
    End Property
    Private _ID_TIPO As Int32
    <Column(Name:="ID_TIPO", Storage:="ID_TIPO", DBType:="INT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property ID_TIPO() As Int32
        Get
            Return _ID_TIPO
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO = Value
            OnPropertyChanged("ID_TIPO")
        End Set
    End Property
    Private _POTENCIAL_COSECHA_MECA As Boolean
    <Column(Name:="POTENCIAL_COSECHA_MECA", Storage:="POTENCIAL_COSECHA_MECA", DBType:="NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property POTENCIAL_COSECHA_MECA() As Boolean
        Get
            Return _POTENCIAL_COSECHA_MECA
        End Get
        Set(ByVal Value As Boolean)
            _POTENCIAL_COSECHA_MECA = Value
            OnPropertyChanged("POTENCIAL_COSECHA_MECA")
        End Set
    End Property
    Private _TIPO_QUEMA As String
    <Column(Name:="TIPO_QUEMA", Storage:="TIPO_QUEMA", DBType:="CHAR(1) NOT NULL", Id:=False), '-- Q: QUEMADO V: VERDE
     DataObjectField(False, False, True, 1)>
    Public Property TIPO_QUEMA() As String
        Get
            Return _TIPO_QUEMA
        End Get
        Set(ByVal Value As String)
            _TIPO_QUEMA = Value
            OnPropertyChanged("TIPO_QUEMA")
        End Set
    End Property
    Private _ID_TIPO_TRANS_VMT As Int32
    <Column(Name:="ID_TIPO_TRANS_VMT", Storage:="ID_TIPO_TRANS_VMT", DBType:="INT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property ID_TIPO_TRANS_VMT() As Int32
        Get
            Return _ID_TIPO_TRANS_VMT
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_TRANS_VMT = Value
            OnPropertyChanged("ID_TIPO_TRANS_VMT")
        End Set
    End Property
    Private _CIRCUITO As Decimal
    <Column(Name:="CIRCUITO", Storage:="CIRCUITO", DBType:="NUMERIC(10,2) NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)>
    Public Property CIRCUITO() As Decimal
        Get
            Return _CIRCUITO
        End Get
        Set(ByVal Value As Decimal)
            _CIRCUITO = Value
            OnPropertyChanged("CIRCUITO")
        End Set
    End Property
    Private _TARIFA As Decimal
    <Column(Name:="TARIFA", Storage:="TARIFA", DBType:="NUMERIC(10,2) NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)>
    Public Property TARIFA() As Decimal
        Get
            Return _TARIFA
        End Get
        Set(ByVal Value As Decimal)
            _TARIFA = Value
            OnPropertyChanged("TARIFA")
        End Set
    End Property
    Private _CARRET_PPAL As Decimal
    <Column(Name:="CARRET_PPAL", Storage:="CARRET_PPAL", DBType:="NUMERIC(10,2) NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)>
    Public Property CARRET_PPAL() As Decimal
        Get
            Return _CARRET_PPAL
        End Get
        Set(ByVal Value As Decimal)
            _CARRET_PPAL = Value
            OnPropertyChanged("CARRET_PPAL")
        End Set
    End Property
    Private _CARRET_SEC As Decimal
    <Column(Name:="CARRET_SEC", Storage:="CARRET_SEC", DBType:="NUMERIC(10,2) NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)>
    Public Property CARRET_SEC() As Decimal
        Get
            Return _CARRET_SEC
        End Get
        Set(ByVal Value As Decimal)
            _CARRET_SEC = Value
            OnPropertyChanged("CARRET_SEC")
        End Set
    End Property
    Private _REPARA_ACCESO As Boolean
    <Column(Name:="REPARA_ACCESO", Storage:="REPARA_ACCESO", DBType:="NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property REPARA_ACCESO() As Boolean
        Get
            Return _REPARA_ACCESO
        End Get
        Set(ByVal Value As Boolean)
            _REPARA_ACCESO = Value
            OnPropertyChanged("REPARA_ACCESO")
        End Set
    End Property

    Private _ID_TIPO_SUELO As Int32
    <Column(Name:="ID_TIPO_SUELO", Storage:="ID_TIPO_SUELO", DBType:="NOT NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property ID_TIPO_SUELO() As Int32
        Get
            Return _ID_TIPO_SUELO
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_SUELO = Value
            OnPropertyChanged("ID_TIPO_SUELO")
        End Set
    End Property

    Private _FECHA_COSECHA As DateTime
    <Column(Name:="FECHA_COSECHA", Storage:="FECHA_COSECHA", DBType:="DateTime NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property FECHA_COSECHA() As DateTime
        Get
            Return _FECHA_COSECHA
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_COSECHA = Value
            OnPropertyChanged("FECHA_COSECHA")
        End Set
    End Property

    Private _ACCESLOTE As String
    Public Property ACCESLOTE() As String
        Get
            Return _ACCESLOTE

        End Get
        Set(ByVal Value As String)
            _ACCESLOTE = Value
        End Set
    End Property

    Private _ES_CERRADO As Boolean
    <Column(Name:="ES_CERRADO", Storage:="ES_CERRADO", DBType:="NULL", Id:=False),
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property ES_CERRADO() As Boolean
        Get
            Return _ES_CERRADO
        End Get
        Set(ByVal Value As Boolean)
            _ES_CERRADO = Value
            OnPropertyChanged("ES_CERRADO")
        End Set
    End Property

End Class
