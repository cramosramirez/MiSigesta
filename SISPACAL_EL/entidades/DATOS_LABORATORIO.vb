''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.DATOS_LABORATORIO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row DATOS_LABORATORIO en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	29/10/2013	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="DATOS_LABORATORIO")> Public Class DATOS_LABORATORIO
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New(aID_DATOS_LAB As Int32, aID_ANALISIS As Int32, aANALISTA As String, aLBS_MUESTRA As Decimal, aLBS_PUNTAS_TIERNA As Decimal, aLBS_CANA_SECA As Decimal, aLBS_MAMONES As Decimal, aLBS_BAJERA As Decimal, aLBS_TIERRA_RAICES As Decimal, aLBS_PIEDRA As Decimal, aLBS_CANA_LIMPIA As Decimal, aOBSERVACION As String, aPORC_PUNTAS_TIERNA As Decimal, aPORC_CANA_SECA As Decimal, aPORC_MAMONES As Decimal, aPORC_BAJERA As Decimal, aPORC_TIERRA_RAICES As Decimal, aPORC_PIEDRA As Decimal, aPORC_CANA_LIMPIA As Decimal, aPORC_MATERIA_EXTRA As Decimal, aABSORVANCIA As Decimal, aDEXTRANA As Decimal, aACIDEZ As Decimal, aREDUCTORES As Decimal, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime, _
                   ByVal aALMIDON_JUGO As Decimal, ByVal aBRIX_DILU As Decimal, ByVal aABSORBANCIA_ALMIDON As Decimal)
        Me._ID_DATOS_LAB = aID_DATOS_LAB
        Me._ID_ANALISIS = aID_ANALISIS
        Me._ANALISTA = aANALISTA
        Me._LBS_MUESTRA = aLBS_MUESTRA
        Me._LBS_PUNTAS_TIERNA = aLBS_PUNTAS_TIERNA
        Me._LBS_CANA_SECA = aLBS_CANA_SECA
        Me._LBS_MAMONES = aLBS_MAMONES
        Me._LBS_BAJERA = aLBS_BAJERA
        Me._LBS_TIERRA_RAICES = aLBS_TIERRA_RAICES
        Me._LBS_PIEDRA = aLBS_PIEDRA
        Me._LBS_CANA_LIMPIA = aLBS_CANA_LIMPIA
        Me._OBSERVACION = aOBSERVACION
        Me._PORC_PUNTAS_TIERNA = aPORC_PUNTAS_TIERNA
        Me._PORC_CANA_SECA = aPORC_CANA_SECA
        Me._PORC_MAMONES = aPORC_MAMONES
        Me._PORC_BAJERA = aPORC_BAJERA
        Me._PORC_TIERRA_RAICES = aPORC_TIERRA_RAICES
        Me._PORC_PIEDRA = aPORC_PIEDRA
        Me._PORC_CANA_LIMPIA = aPORC_CANA_LIMPIA
        Me._PORC_MATERIA_EXTRA = aPORC_MATERIA_EXTRA
        Me._ABSORVANCIA = aABSORVANCIA
        Me._DEXTRANA = aDEXTRANA
        Me._ACIDEZ = aACIDEZ
        Me._REDUCTORES = aREDUCTORES
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
        Me._ALMIDON_JUGO = aALMIDON_JUGO
        Me._BRIX_DILU = aBRIX_DILU
        Me._ABSORBANCIA_ALMIDON = aABSORBANCIA_ALMIDON
    End Sub

#Region " Properties "

    Private _ID_DATOS_LAB As Int32
    <Column(Name:="Id datos lab", Storage:="ID_DATOS_LAB", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_DATOS_LAB() As Int32
        Get
            Return _ID_DATOS_LAB
        End Get
        Set(ByVal Value As Int32)
            _ID_DATOS_LAB = Value
            OnPropertyChanged("ID_DATOS_LAB")
        End Set
    End Property 

    Private _ID_ANALISIS As Int32
    <Column(Name:="Id analisis", Storage:="ID_ANALISIS", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_ANALISIS() As Int32
        Get
            Return _ID_ANALISIS
        End Get
        Set(ByVal Value As Int32)
            _ID_ANALISIS = Value
            OnPropertyChanged("ID_ANALISIS")
        End Set
    End Property 

    Private _ID_ANALISISOld As Int32
    Public Property ID_ANALISISOld() As Int32
        Get
            Return _ID_ANALISISOld
        End Get
        Set(ByVal Value As Int32)
            _ID_ANALISISOld = Value
        End Set
    End Property 

    Private _fkID_ANALISIS As ANALISIS
    Public Property fkID_ANALISIS() As ANALISIS
        Get
            Return _fkID_ANALISIS
        End Get
        Set(ByVal Value As ANALISIS)
            _fkID_ANALISIS = Value
        End Set
    End Property 

    Private _ANALISTA As String
    <Column(Name:="Analista", Storage:="ANALISTA", DbType:="VARCHAR(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
    Public Property ANALISTA() As String
        Get
            Return _ANALISTA
        End Get
        Set(ByVal Value As String)
            _ANALISTA = Value
            OnPropertyChanged("ANALISTA")
        End Set
    End Property 

    Private _ANALISTAOld As String
    Public Property ANALISTAOld() As String
        Get
            Return _ANALISTAOld
        End Get
        Set(ByVal Value As String)
            _ANALISTAOld = Value
        End Set
    End Property 

    Private _LBS_MUESTRA As Decimal
    <Column(Name:="Lbs muestra", Storage:="LBS_MUESTRA", DbType:="NUMERIC(20,4)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=4)> _
    Public Property LBS_MUESTRA() As Decimal
        Get
            Return _LBS_MUESTRA
        End Get
        Set(ByVal Value As Decimal)
            _LBS_MUESTRA = Value
            OnPropertyChanged("LBS_MUESTRA")
        End Set
    End Property 

    Private _LBS_MUESTRAOld As Decimal
    Public Property LBS_MUESTRAOld() As Decimal
        Get
            Return _LBS_MUESTRAOld
        End Get
        Set(ByVal Value As Decimal)
            _LBS_MUESTRAOld = Value
        End Set
    End Property 

    Private _LBS_PUNTAS_TIERNA As Decimal
    <Column(Name:="Lbs puntas tierna", Storage:="LBS_PUNTAS_TIERNA", DbType:="NUMERIC(20,4)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=4)> _
    Public Property LBS_PUNTAS_TIERNA() As Decimal
        Get
            Return _LBS_PUNTAS_TIERNA
        End Get
        Set(ByVal Value As Decimal)
            _LBS_PUNTAS_TIERNA = Value
            OnPropertyChanged("LBS_PUNTAS_TIERNA")
        End Set
    End Property 

    Private _LBS_PUNTAS_TIERNAOld As Decimal
    Public Property LBS_PUNTAS_TIERNAOld() As Decimal
        Get
            Return _LBS_PUNTAS_TIERNAOld
        End Get
        Set(ByVal Value As Decimal)
            _LBS_PUNTAS_TIERNAOld = Value
        End Set
    End Property 

    Private _LBS_CANA_SECA As Decimal
    <Column(Name:="Lbs cana seca", Storage:="LBS_CANA_SECA", DbType:="NUMERIC(20,4)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=4)> _
    Public Property LBS_CANA_SECA() As Decimal
        Get
            Return _LBS_CANA_SECA
        End Get
        Set(ByVal Value As Decimal)
            _LBS_CANA_SECA = Value
            OnPropertyChanged("LBS_CANA_SECA")
        End Set
    End Property 

    Private _LBS_CANA_SECAOld As Decimal
    Public Property LBS_CANA_SECAOld() As Decimal
        Get
            Return _LBS_CANA_SECAOld
        End Get
        Set(ByVal Value As Decimal)
            _LBS_CANA_SECAOld = Value
        End Set
    End Property 

    Private _LBS_MAMONES As Decimal
    <Column(Name:="Lbs mamones", Storage:="LBS_MAMONES", DbType:="NUMERIC(20,4)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=4)> _
    Public Property LBS_MAMONES() As Decimal
        Get
            Return _LBS_MAMONES
        End Get
        Set(ByVal Value As Decimal)
            _LBS_MAMONES = Value
            OnPropertyChanged("LBS_MAMONES")
        End Set
    End Property 

    Private _LBS_MAMONESOld As Decimal
    Public Property LBS_MAMONESOld() As Decimal
        Get
            Return _LBS_MAMONESOld
        End Get
        Set(ByVal Value As Decimal)
            _LBS_MAMONESOld = Value
        End Set
    End Property 

    Private _LBS_BAJERA As Decimal
    <Column(Name:="Lbs bajera", Storage:="LBS_BAJERA", DbType:="NUMERIC(20,4)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=4)> _
    Public Property LBS_BAJERA() As Decimal
        Get
            Return _LBS_BAJERA
        End Get
        Set(ByVal Value As Decimal)
            _LBS_BAJERA = Value
            OnPropertyChanged("LBS_BAJERA")
        End Set
    End Property 

    Private _LBS_BAJERAOld As Decimal
    Public Property LBS_BAJERAOld() As Decimal
        Get
            Return _LBS_BAJERAOld
        End Get
        Set(ByVal Value As Decimal)
            _LBS_BAJERAOld = Value
        End Set
    End Property 

    Private _LBS_TIERRA_RAICES As Decimal
    <Column(Name:="Lbs tierra raices", Storage:="LBS_TIERRA_RAICES", DbType:="NUMERIC(20,4)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=4)> _
    Public Property LBS_TIERRA_RAICES() As Decimal
        Get
            Return _LBS_TIERRA_RAICES
        End Get
        Set(ByVal Value As Decimal)
            _LBS_TIERRA_RAICES = Value
            OnPropertyChanged("LBS_TIERRA_RAICES")
        End Set
    End Property 

    Private _LBS_TIERRA_RAICESOld As Decimal
    Public Property LBS_TIERRA_RAICESOld() As Decimal
        Get
            Return _LBS_TIERRA_RAICESOld
        End Get
        Set(ByVal Value As Decimal)
            _LBS_TIERRA_RAICESOld = Value
        End Set
    End Property 

    Private _LBS_PIEDRA As Decimal
    <Column(Name:="Lbs piedra", Storage:="LBS_PIEDRA", DbType:="NUMERIC(20,4)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=4)> _
    Public Property LBS_PIEDRA() As Decimal
        Get
            Return _LBS_PIEDRA
        End Get
        Set(ByVal Value As Decimal)
            _LBS_PIEDRA = Value
            OnPropertyChanged("LBS_PIEDRA")
        End Set
    End Property 

    Private _LBS_PIEDRAOld As Decimal
    Public Property LBS_PIEDRAOld() As Decimal
        Get
            Return _LBS_PIEDRAOld
        End Get
        Set(ByVal Value As Decimal)
            _LBS_PIEDRAOld = Value
        End Set
    End Property 

    Private _LBS_CANA_LIMPIA As Decimal
    <Column(Name:="Lbs cana limpia", Storage:="LBS_CANA_LIMPIA", DbType:="NUMERIC(20,4)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=4)> _
    Public Property LBS_CANA_LIMPIA() As Decimal
        Get
            Return _LBS_CANA_LIMPIA
        End Get
        Set(ByVal Value As Decimal)
            _LBS_CANA_LIMPIA = Value
            OnPropertyChanged("LBS_CANA_LIMPIA")
        End Set
    End Property 

    Private _LBS_CANA_LIMPIAOld As Decimal
    Public Property LBS_CANA_LIMPIAOld() As Decimal
        Get
            Return _LBS_CANA_LIMPIAOld
        End Get
        Set(ByVal Value As Decimal)
            _LBS_CANA_LIMPIAOld = Value
        End Set
    End Property 

    Private _OBSERVACION As String
    <Column(Name:="Observacion", Storage:="OBSERVACION", DbType:="VARCHAR(500)", Id:=False), _
     DataObjectField(False, False, True, 500)> _
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

    Private _PORC_PUNTAS_TIERNA As Decimal
    <Column(Name:="Porc puntas tierna", Storage:="PORC_PUNTAS_TIERNA", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property PORC_PUNTAS_TIERNA() As Decimal
        Get
            Return _PORC_PUNTAS_TIERNA
        End Get
        Set(ByVal Value As Decimal)
            _PORC_PUNTAS_TIERNA = Value
            OnPropertyChanged("PORC_PUNTAS_TIERNA")
        End Set
    End Property 

    Private _PORC_PUNTAS_TIERNAOld As Decimal
    Public Property PORC_PUNTAS_TIERNAOld() As Decimal
        Get
            Return _PORC_PUNTAS_TIERNAOld
        End Get
        Set(ByVal Value As Decimal)
            _PORC_PUNTAS_TIERNAOld = Value
        End Set
    End Property 

    Private _PORC_CANA_SECA As Decimal
    <Column(Name:="Porc cana seca", Storage:="PORC_CANA_SECA", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property PORC_CANA_SECA() As Decimal
        Get
            Return _PORC_CANA_SECA
        End Get
        Set(ByVal Value As Decimal)
            _PORC_CANA_SECA = Value
            OnPropertyChanged("PORC_CANA_SECA")
        End Set
    End Property 

    Private _PORC_CANA_SECAOld As Decimal
    Public Property PORC_CANA_SECAOld() As Decimal
        Get
            Return _PORC_CANA_SECAOld
        End Get
        Set(ByVal Value As Decimal)
            _PORC_CANA_SECAOld = Value
        End Set
    End Property 

    Private _PORC_MAMONES As Decimal
    <Column(Name:="Porc mamones", Storage:="PORC_MAMONES", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property PORC_MAMONES() As Decimal
        Get
            Return _PORC_MAMONES
        End Get
        Set(ByVal Value As Decimal)
            _PORC_MAMONES = Value
            OnPropertyChanged("PORC_MAMONES")
        End Set
    End Property 

    Private _PORC_MAMONESOld As Decimal
    Public Property PORC_MAMONESOld() As Decimal
        Get
            Return _PORC_MAMONESOld
        End Get
        Set(ByVal Value As Decimal)
            _PORC_MAMONESOld = Value
        End Set
    End Property 

    Private _PORC_BAJERA As Decimal
    <Column(Name:="Porc bajera", Storage:="PORC_BAJERA", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property PORC_BAJERA() As Decimal
        Get
            Return _PORC_BAJERA
        End Get
        Set(ByVal Value As Decimal)
            _PORC_BAJERA = Value
            OnPropertyChanged("PORC_BAJERA")
        End Set
    End Property 

    Private _PORC_BAJERAOld As Decimal
    Public Property PORC_BAJERAOld() As Decimal
        Get
            Return _PORC_BAJERAOld
        End Get
        Set(ByVal Value As Decimal)
            _PORC_BAJERAOld = Value
        End Set
    End Property 

    Private _PORC_TIERRA_RAICES As Decimal
    <Column(Name:="Porc tierra raices", Storage:="PORC_TIERRA_RAICES", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property PORC_TIERRA_RAICES() As Decimal
        Get
            Return _PORC_TIERRA_RAICES
        End Get
        Set(ByVal Value As Decimal)
            _PORC_TIERRA_RAICES = Value
            OnPropertyChanged("PORC_TIERRA_RAICES")
        End Set
    End Property 

    Private _PORC_TIERRA_RAICESOld As Decimal
    Public Property PORC_TIERRA_RAICESOld() As Decimal
        Get
            Return _PORC_TIERRA_RAICESOld
        End Get
        Set(ByVal Value As Decimal)
            _PORC_TIERRA_RAICESOld = Value
        End Set
    End Property 

    Private _PORC_PIEDRA As Decimal
    <Column(Name:="Porc piedra", Storage:="PORC_PIEDRA", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property PORC_PIEDRA() As Decimal
        Get
            Return _PORC_PIEDRA
        End Get
        Set(ByVal Value As Decimal)
            _PORC_PIEDRA = Value
            OnPropertyChanged("PORC_PIEDRA")
        End Set
    End Property 

    Private _PORC_PIEDRAOld As Decimal
    Public Property PORC_PIEDRAOld() As Decimal
        Get
            Return _PORC_PIEDRAOld
        End Get
        Set(ByVal Value As Decimal)
            _PORC_PIEDRAOld = Value
        End Set
    End Property 

    Private _PORC_CANA_LIMPIA As Decimal
    <Column(Name:="Porc cana limpia", Storage:="PORC_CANA_LIMPIA", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property PORC_CANA_LIMPIA() As Decimal
        Get
            Return _PORC_CANA_LIMPIA
        End Get
        Set(ByVal Value As Decimal)
            _PORC_CANA_LIMPIA = Value
            OnPropertyChanged("PORC_CANA_LIMPIA")
        End Set
    End Property 

    Private _PORC_CANA_LIMPIAOld As Decimal
    Public Property PORC_CANA_LIMPIAOld() As Decimal
        Get
            Return _PORC_CANA_LIMPIAOld
        End Get
        Set(ByVal Value As Decimal)
            _PORC_CANA_LIMPIAOld = Value
        End Set
    End Property 

    Private _PORC_MATERIA_EXTRA As Decimal
    <Column(Name:="Porc materia extra", Storage:="PORC_MATERIA_EXTRA", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property PORC_MATERIA_EXTRA() As Decimal
        Get
            Return _PORC_MATERIA_EXTRA
        End Get
        Set(ByVal Value As Decimal)
            _PORC_MATERIA_EXTRA = Value
            OnPropertyChanged("PORC_MATERIA_EXTRA")
        End Set
    End Property 

    Private _PORC_MATERIA_EXTRAOld As Decimal
    Public Property PORC_MATERIA_EXTRAOld() As Decimal
        Get
            Return _PORC_MATERIA_EXTRAOld
        End Get
        Set(ByVal Value As Decimal)
            _PORC_MATERIA_EXTRAOld = Value
        End Set
    End Property 

    Private _ABSORVANCIA As Decimal
    <Column(Name:="Absorvancia", Storage:="ABSORVANCIA", DbType:="NUMERIC(20,4)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=4)> _
    Public Property ABSORVANCIA() As Decimal
        Get
            Return _ABSORVANCIA
        End Get
        Set(ByVal Value As Decimal)
            _ABSORVANCIA = Value
            OnPropertyChanged("ABSORVANCIA")
        End Set
    End Property 

    Private _ABSORVANCIAOld As Decimal
    Public Property ABSORVANCIAOld() As Decimal
        Get
            Return _ABSORVANCIAOld
        End Get
        Set(ByVal Value As Decimal)
            _ABSORVANCIAOld = Value
        End Set
    End Property 

    Private _DEXTRANA As Decimal
    <Column(Name:="Dextrana", Storage:="DEXTRANA", DbType:="NUMERIC(20,4)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=4)> _
    Public Property DEXTRANA() As Decimal
        Get
            Return _DEXTRANA
        End Get
        Set(ByVal Value As Decimal)
            _DEXTRANA = Value
            OnPropertyChanged("DEXTRANA")
        End Set
    End Property 

    Private _DEXTRANAOld As Decimal
    Public Property DEXTRANAOld() As Decimal
        Get
            Return _DEXTRANAOld
        End Get
        Set(ByVal Value As Decimal)
            _DEXTRANAOld = Value
        End Set
    End Property 

    Private _ACIDEZ As Decimal
    <Column(Name:="Acidez", Storage:="ACIDEZ", DbType:="NUMERIC(20,4)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=4)> _
    Public Property ACIDEZ() As Decimal
        Get
            Return _ACIDEZ
        End Get
        Set(ByVal Value As Decimal)
            _ACIDEZ = Value
            OnPropertyChanged("ACIDEZ")
        End Set
    End Property 

    Private _ACIDEZOld As Decimal
    Public Property ACIDEZOld() As Decimal
        Get
            Return _ACIDEZOld
        End Get
        Set(ByVal Value As Decimal)
            _ACIDEZOld = Value
        End Set
    End Property 

    Private _REDUCTORES As Decimal
    <Column(Name:="Reductores", Storage:="REDUCTORES", DbType:="NUMERIC(20,4)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=4)> _
    Public Property REDUCTORES() As Decimal
        Get
            Return _REDUCTORES
        End Get
        Set(ByVal Value As Decimal)
            _REDUCTORES = Value
            OnPropertyChanged("REDUCTORES")
        End Set
    End Property 

    Private _REDUCTORESOld As Decimal
    Public Property REDUCTORESOld() As Decimal
        Get
            Return _REDUCTORESOld
        End Get
        Set(ByVal Value As Decimal)
            _REDUCTORESOld = Value
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
    <Column(Name:="Fecha act", Storage:="FECHA_ACT", DbType:="DATETIME", Id:=False), _
     DataObjectField(False, False, True)> _
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

    Private _ABSORBANCIA_ALMIDON As Decimal
    <Column(Name:="Absorbancia Almidon", Storage:="ABSORBANCIA_ALMIDON", DbType:="NUMERIC(8,3)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=8, Scale:=3)> _
    Public Property ABSORBANCIA_ALMIDON() As Decimal
        Get
            Return _ABSORBANCIA_ALMIDON
        End Get
        Set(ByVal Value As Decimal)
            _ABSORBANCIA_ALMIDON = Value
            OnPropertyChanged("ABSORBANCIA_ALMIDON")
        End Set
    End Property

    Private _ABSORBANCIA_ALMIDONOld As Decimal
    Public Property ABSORBANCIA_ALMIDONOld() As Decimal
        Get
            Return _ABSORBANCIA_ALMIDONOld
        End Get
        Set(ByVal Value As Decimal)
            _ABSORBANCIA_ALMIDONOld = Value
        End Set
    End Property

    Private _BRIX_DILU As Decimal
    <Column(Name:="Brix Dilu", Storage:="BRIX_DILU", DbType:="NUMERIC(8,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=8, Scale:=2)> _
    Public Property BRIX_DILU() As Decimal
        Get
            Return _BRIX_DILU
        End Get
        Set(ByVal Value As Decimal)
            _BRIX_DILU = Value
            OnPropertyChanged("BRIX_DILU")
        End Set
    End Property

    Private _BRIX_DILUOld As Decimal
    Public Property BRIX_DILUOld() As Decimal
        Get
            Return _BRIX_DILUOld
        End Get
        Set(ByVal Value As Decimal)
            _BRIX_DILUOld = Value
        End Set
    End Property

    Private _ALMIDON_JUGO As Decimal
    <Column(Name:="Almidon jugo", Storage:="ALMIDON_JUGO", DbType:="NUMERIC(20,6)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=6)> _
    Public Property ALMIDON_JUGO() As Decimal
        Get
            Return _ALMIDON_JUGO
        End Get
        Set(ByVal Value As Decimal)
            _ALMIDON_JUGO = Value
            OnPropertyChanged("ALMIDON_JUGO")
        End Set
    End Property

    Private _ALMIDON_JUGOOld As Decimal
    Public Property ALMIDON_JUGOOld() As Decimal
        Get
            Return _ALMIDON_JUGOOld
        End Get
        Set(ByVal Value As Decimal)
            _ALMIDON_JUGOOld = Value
        End Set
    End Property

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
