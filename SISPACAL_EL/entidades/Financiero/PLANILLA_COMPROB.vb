''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.PLANILLA_COMPROB
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row PLANILLA_COMPROB en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	13/09/2019	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="PLANILLA_COMPROB")> Public Class PLANILLA_COMPROB
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_PLANILLA_COMPROB As Int32, aID_CATORCENA As Int32, aCODIPROVEEDOR_TRANSPORTISTA As String, aNOMBRE_CLIENTE As String, aID_TIPO_PLANILLA As Int32, aID_TIPO_COMPROB As Int32, aSERIE As String, aNO_DOCTO As Int32, aESTADO As String, aFECHA_EMISION As DateTime, aNRC As String, aTIPO_CONTRIBUYENTE As Int32, aAFECTO As Decimal, aEXENTO As Decimal, aIVA As Decimal, aRETENCION As Decimal, aPERCEPCION As Decimal, aVTA_SUJETO_EXCLUIDO As Decimal, aTOTAL As Decimal, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime)
        Me._ID_PLANILLA_COMPROB = aID_PLANILLA_COMPROB
        Me._ID_CATORCENA = aID_CATORCENA
        Me._CODIPROVEEDOR_TRANSPORTISTA = aCODIPROVEEDOR_TRANSPORTISTA
        Me._NOMBRE_CLIENTE = aNOMBRE_CLIENTE
        Me._ID_TIPO_PLANILLA = aID_TIPO_PLANILLA
        Me._ID_TIPO_COMPROB = aID_TIPO_COMPROB
        Me._SERIE = aSERIE
        Me._NO_DOCTO = aNO_DOCTO
        Me._ESTADO = aESTADO
        Me._FECHA_EMISION = aFECHA_EMISION
        Me._NRC = aNRC
        Me._TIPO_CONTRIBUYENTE = aTIPO_CONTRIBUYENTE
        Me._AFECTO = aAFECTO
        Me._EXENTO = aEXENTO
        Me._IVA = aIVA
        Me._RETENCION = aRETENCION
        Me._PERCEPCION = aPERCEPCION
        Me._VTA_SUJETO_EXCLUIDO = aVTA_SUJETO_EXCLUIDO
        Me._TOTAL = aTOTAL
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
    End Sub

#Region " Properties "

    Private _ID_PLANILLA_COMPROB As Int32
    <Column(Name:="Id planilla comprob", Storage:="ID_PLANILLA_COMPROB", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_PLANILLA_COMPROB() As Int32
        Get
            Return _ID_PLANILLA_COMPROB
        End Get
        Set(ByVal Value As Int32)
            _ID_PLANILLA_COMPROB = Value
            OnPropertyChanged("ID_PLANILLA_COMPROB")
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

    Private _NOMBRE_CLIENTE As String
    <Column(Name:="Nombre cliente", Storage:="NOMBRE_CLIENTE", DbType:="VARCHAR(200) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 200)> _
    Public Property NOMBRE_CLIENTE() As String
        Get
            Return _NOMBRE_CLIENTE
        End Get
        Set(ByVal Value As String)
            _NOMBRE_CLIENTE = Value
            OnPropertyChanged("NOMBRE_CLIENTE")
        End Set
    End Property 

    Private _NOMBRE_CLIENTEOld As String
    Public Property NOMBRE_CLIENTEOld() As String
        Get
            Return _NOMBRE_CLIENTEOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_CLIENTEOld = Value
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

    Private _ID_TIPO_COMPROB As Int32
    <Column(Name:="Id tipo comprob", Storage:="ID_TIPO_COMPROB", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_TIPO_COMPROB() As Int32
        Get
            Return _ID_TIPO_COMPROB
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_COMPROB = Value
            OnPropertyChanged("ID_TIPO_COMPROB")
        End Set
    End Property 

    Private _ID_TIPO_COMPROBOld As Int32
    Public Property ID_TIPO_COMPROBOld() As Int32
        Get
            Return _ID_TIPO_COMPROBOld
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_COMPROBOld = Value
        End Set
    End Property 

    Private _fkID_TIPO_COMPROB As TIPO_COMPROB
    Public Property fkID_TIPO_COMPROB() As TIPO_COMPROB
        Get
            Return _fkID_TIPO_COMPROB
        End Get
        Set(ByVal Value As TIPO_COMPROB)
            _fkID_TIPO_COMPROB = Value
        End Set
    End Property 

    Private _SERIE As String
    <Column(Name:="Serie", Storage:="SERIE", DbType:="VARCHAR(20) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 20)> _
    Public Property SERIE() As String
        Get
            Return _SERIE
        End Get
        Set(ByVal Value As String)
            _SERIE = Value
            OnPropertyChanged("SERIE")
        End Set
    End Property 

    Private _SERIEOld As String
    Public Property SERIEOld() As String
        Get
            Return _SERIEOld
        End Get
        Set(ByVal Value As String)
            _SERIEOld = Value
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

    Private _FECHA_EMISION As DateTime
    <Column(Name:="Fecha emision", Storage:="FECHA_EMISION", DbType:="DATE NOT NULL", Id:=False), _
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

    Private _NRC As String
    <Column(Name:="Nrc", Storage:="NRC", DbType:="VARCHAR(50) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 50)> _
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
    <Column(Name:="Tipo contribuyente", Storage:="TIPO_CONTRIBUYENTE", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
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

    Private _AFECTO As Decimal
    <Column(Name:="Afecto", Storage:="AFECTO", DbType:="NUMERIC(20,6) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=6)> _
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

    Private _EXENTO As Decimal
    <Column(Name:="Exento", Storage:="EXENTO", DbType:="NUMERIC(20,6) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=6)> _
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

    Private _IVA As Decimal
    <Column(Name:="Iva", Storage:="IVA", DbType:="NUMERIC(20,6) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=6)> _
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

    Private _RETENCION As Decimal
    <Column(Name:="Retencion", Storage:="RETENCION", DbType:="NUMERIC(20,6) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=6)> _
    Public Property RETENCION() As Decimal
        Get
            Return _RETENCION
        End Get
        Set(ByVal Value As Decimal)
            _RETENCION = Value
            OnPropertyChanged("RETENCION")
        End Set
    End Property 

    Private _RETENCIONOld As Decimal
    Public Property RETENCIONOld() As Decimal
        Get
            Return _RETENCIONOld
        End Get
        Set(ByVal Value As Decimal)
            _RETENCIONOld = Value
        End Set
    End Property 

    Private _PERCEPCION As Decimal
    <Column(Name:="Percepcion", Storage:="PERCEPCION", DbType:="NUMERIC(20,6) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=6)> _
    Public Property PERCEPCION() As Decimal
        Get
            Return _PERCEPCION
        End Get
        Set(ByVal Value As Decimal)
            _PERCEPCION = Value
            OnPropertyChanged("PERCEPCION")
        End Set
    End Property 

    Private _PERCEPCIONOld As Decimal
    Public Property PERCEPCIONOld() As Decimal
        Get
            Return _PERCEPCIONOld
        End Get
        Set(ByVal Value As Decimal)
            _PERCEPCIONOld = Value
        End Set
    End Property 

    Private _VTA_SUJETO_EXCLUIDO As Decimal
    <Column(Name:="Vta sujeto excluido", Storage:="VTA_SUJETO_EXCLUIDO", DbType:="NUMERIC(20,6) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=6)> _
    Public Property VTA_SUJETO_EXCLUIDO() As Decimal
        Get
            Return _VTA_SUJETO_EXCLUIDO
        End Get
        Set(ByVal Value As Decimal)
            _VTA_SUJETO_EXCLUIDO = Value
            OnPropertyChanged("VTA_SUJETO_EXCLUIDO")
        End Set
    End Property 

    Private _VTA_SUJETO_EXCLUIDOOld As Decimal
    Public Property VTA_SUJETO_EXCLUIDOOld() As Decimal
        Get
            Return _VTA_SUJETO_EXCLUIDOOld
        End Get
        Set(ByVal Value As Decimal)
            _VTA_SUJETO_EXCLUIDOOld = Value
        End Set
    End Property 

    Private _TOTAL As Decimal
    <Column(Name:="Total", Storage:="TOTAL", DbType:="NUMERIC(20,6) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=6)> _
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

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
