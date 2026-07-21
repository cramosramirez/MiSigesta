''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.PLANILLA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row PLANILLA en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	05/12/2013	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="PLANILLA")> Public Class PLANILLA
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_CATORCENA As Int32, aCODIPROVEEDOR_TRANSPORTISTA As String, aID_TIPO_PLANILLA As Int32, aNOMBRE_ZAFRA As String, aCODIPROVEE As String, aCODISOCIO As String, aCANT_RECIBOS As Int32, aTONEL_CANA_ENTREGADA As Decimal, aAZUCAR_CATORCENA_REAL As Decimal, aVALOR As Decimal, aIVA As Decimal, aVALOR_BRUTO As Decimal, aRENTA As Decimal, aRETENCION_IVA As Decimal, aDESC_FLETE As Decimal, aDESC_CARGA As Decimal, aDESC_CARGA_CONTRA As Decimal, aDESC_BANCOS As Decimal, aDESC_COMBUSTIBLE As Decimal, aDESC_ANTICIPO As Decimal, aDESC_INTERES As Decimal, aDESC_AGROQUIMICO As Decimal, aDESC_SEGURO As Decimal, aDESC_RESPUESTOS As Decimal, aDESC_OTROS As Decimal, aPAGO_NETO As Decimal, aES_CONTRIBUYENTE As Boolean, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime, aDESC_SERVICIO_ROZA As Decimal, aNOMBRE_PROVEE_TRANS As String, aNO_CHEQUE As Int32, aID_CHEQUE_PLANILLA As Int32, aID_PLANILLA_BASE As Int32)
        Me._ID_CATORCENA = aID_CATORCENA
        Me._CODIPROVEEDOR_TRANSPORTISTA = aCODIPROVEEDOR_TRANSPORTISTA
        Me._ID_TIPO_PLANILLA = aID_TIPO_PLANILLA
        Me._NOMBRE_ZAFRA = aNOMBRE_ZAFRA
        Me._CODIPROVEE = aCODIPROVEE
        Me._CODISOCIO = aCODISOCIO
        Me._CANT_RECIBOS = aCANT_RECIBOS
        Me._TONEL_CANA_ENTREGADA = aTONEL_CANA_ENTREGADA
        Me._AZUCAR_CATORCENA_REAL = aAZUCAR_CATORCENA_REAL
        Me._VALOR = aVALOR
        Me._IVA = aIVA
        Me._VALOR_BRUTO = aVALOR_BRUTO
        Me._RENTA = aRENTA
        Me._RETENCION_IVA = aRETENCION_IVA
        Me._DESC_FLETE = aDESC_FLETE
        Me._DESC_CARGA = aDESC_CARGA
        Me._DESC_CARGA_CONTRA = aDESC_CARGA_CONTRA
        Me._DESC_BANCOS = aDESC_BANCOS
        Me._DESC_COMBUSTIBLE = aDESC_COMBUSTIBLE
        Me._DESC_ANTICIPO = aDESC_ANTICIPO
        Me._DESC_INTERES = aDESC_INTERES
        Me._DESC_AGROQUIMICO = aDESC_AGROQUIMICO
        Me._DESC_SEGURO = aDESC_SEGURO
        Me._DESC_RESPUESTOS = aDESC_RESPUESTOS
        Me._DESC_OTROS = aDESC_OTROS
        Me._PAGO_NETO = aPAGO_NETO
        Me._ES_CONTRIBUYENTE = aES_CONTRIBUYENTE
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
        Me._DESC_SERVICIO_ROZA = aDESC_SERVICIO_ROZA
        Me._NOMBRE_PROVEE_TRANS = aNOMBRE_PROVEE_TRANS
        Me._NO_CHEQUE = aNO_CHEQUE
        Me._ID_CHEQUE_PLANILLA = aID_CHEQUE_PLANILLA
        Me._ID_PLANILLA_BASE = aID_PLANILLA_BASE
    End Sub

#Region " Properties "

    Private _ID_CATORCENA As Int32
    <Column(Name:="Id catorcena", Storage:="ID_CATORCENA", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_CATORCENA() As Int32
        Get
            Return _ID_CATORCENA
        End Get
        Set(ByVal Value As Int32)
            _ID_CATORCENA = Value
            OnPropertyChanged("ID_CATORCENA")
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
    <Column(Name:="Codiproveedor transportista", Storage:="CODIPROVEEDOR_TRANSPORTISTA", DbType:="VARCHAR(10) NOT NULL", Id:=True), _
     DataObjectField(True, False, False, 10)> _
    Public Property CODIPROVEEDOR_TRANSPORTISTA() As String
        Get
            Return _CODIPROVEEDOR_TRANSPORTISTA
        End Get
        Set(ByVal Value As String)
            _CODIPROVEEDOR_TRANSPORTISTA = Value
            OnPropertyChanged("CODIPROVEEDOR_TRANSPORTISTA")
        End Set
    End Property 

    Private _ID_TIPO_PLANILLA As Int32
    <Column(Name:="Id tipo planilla", Storage:="ID_TIPO_PLANILLA", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_TIPO_PLANILLA() As Int32
        Get
            Return _ID_TIPO_PLANILLA
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_PLANILLA = Value
            OnPropertyChanged("ID_TIPO_PLANILLA")
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

    Private _NOMBRE_ZAFRA As String
    <Column(Name:="Nombre zafra", Storage:="NOMBRE_ZAFRA", DbType:="VARCHAR(200) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 200)> _
    Public Property NOMBRE_ZAFRA() As String
        Get
            Return _NOMBRE_ZAFRA
        End Get
        Set(ByVal Value As String)
            _NOMBRE_ZAFRA = Value
            OnPropertyChanged("NOMBRE_ZAFRA")
        End Set
    End Property 

    Private _NOMBRE_ZAFRAOld As String
    Public Property NOMBRE_ZAFRAOld() As String
        Get
            Return _NOMBRE_ZAFRAOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_ZAFRAOld = Value
        End Set
    End Property 

    Private _CODIPROVEE As String
    <Column(Name:="Codiprovee", Storage:="CODIPROVEE", DbType:="VARCHAR(6)", Id:=False), _
     DataObjectField(False, False, True, 6)> _
    Public Property CODIPROVEE() As String
        Get
            Return _CODIPROVEE
        End Get
        Set(ByVal Value As String)
            _CODIPROVEE = Value
            OnPropertyChanged("CODIPROVEE")
        End Set
    End Property 

    Private _CODIPROVEEOld As String
    Public Property CODIPROVEEOld() As String
        Get
            Return _CODIPROVEEOld
        End Get
        Set(ByVal Value As String)
            _CODIPROVEEOld = Value
        End Set
    End Property 

    Private _CODISOCIO As String
    <Column(Name:="Codisocio", Storage:="CODISOCIO", DbType:="VARCHAR(4)", Id:=False), _
     DataObjectField(False, False, True, 4)> _
    Public Property CODISOCIO() As String
        Get
            Return _CODISOCIO
        End Get
        Set(ByVal Value As String)
            _CODISOCIO = Value
            OnPropertyChanged("CODISOCIO")
        End Set
    End Property 

    Private _CODISOCIOOld As String
    Public Property CODISOCIOOld() As String
        Get
            Return _CODISOCIOOld
        End Get
        Set(ByVal Value As String)
            _CODISOCIOOld = Value
        End Set
    End Property 

    Private _CANT_RECIBOS As Int32
    <Column(Name:="Cant recibos", Storage:="CANT_RECIBOS", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property CANT_RECIBOS() As Int32
        Get
            Return _CANT_RECIBOS
        End Get
        Set(ByVal Value As Int32)
            _CANT_RECIBOS = Value
            OnPropertyChanged("CANT_RECIBOS")
        End Set
    End Property 

    Private _CANT_RECIBOSOld As Int32
    Public Property CANT_RECIBOSOld() As Int32
        Get
            Return _CANT_RECIBOSOld
        End Get
        Set(ByVal Value As Int32)
            _CANT_RECIBOSOld = Value
        End Set
    End Property 

    Private _TONEL_CANA_ENTREGADA As Decimal
    <Column(Name:="Tonel cana entregada", Storage:="TONEL_CANA_ENTREGADA", DbType:="NUMERIC(10,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=2)> _
    Public Property TONEL_CANA_ENTREGADA() As Decimal
        Get
            Return _TONEL_CANA_ENTREGADA
        End Get
        Set(ByVal Value As Decimal)
            _TONEL_CANA_ENTREGADA = Value
            OnPropertyChanged("TONEL_CANA_ENTREGADA")
        End Set
    End Property 

    Private _TONEL_CANA_ENTREGADAOld As Decimal
    Public Property TONEL_CANA_ENTREGADAOld() As Decimal
        Get
            Return _TONEL_CANA_ENTREGADAOld
        End Get
        Set(ByVal Value As Decimal)
            _TONEL_CANA_ENTREGADAOld = Value
        End Set
    End Property 

    Private _AZUCAR_CATORCENA_REAL As Decimal
    <Column(Name:="Azucar catorcena real", Storage:="AZUCAR_CATORCENA_REAL", DbType:="NUMERIC(20,6)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=6)> _
    Public Property AZUCAR_CATORCENA_REAL() As Decimal
        Get
            Return _AZUCAR_CATORCENA_REAL
        End Get
        Set(ByVal Value As Decimal)
            _AZUCAR_CATORCENA_REAL = Value
            OnPropertyChanged("AZUCAR_CATORCENA_REAL")
        End Set
    End Property 

    Private _AZUCAR_CATORCENA_REALOld As Decimal
    Public Property AZUCAR_CATORCENA_REALOld() As Decimal
        Get
            Return _AZUCAR_CATORCENA_REALOld
        End Get
        Set(ByVal Value As Decimal)
            _AZUCAR_CATORCENA_REALOld = Value
        End Set
    End Property 

    Private _VALOR As Decimal
    <Column(Name:="Valor", Storage:="VALOR", DbType:="NUMERIC(20,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)> _
    Public Property VALOR() As Decimal
        Get
            Return _VALOR
        End Get
        Set(ByVal Value As Decimal)
            _VALOR = Value
            OnPropertyChanged("VALOR")
        End Set
    End Property 

    Private _VALOROld As Decimal
    Public Property VALOROld() As Decimal
        Get
            Return _VALOROld
        End Get
        Set(ByVal Value As Decimal)
            _VALOROld = Value
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

    Private _VALOR_BRUTO As Decimal
    <Column(Name:="Valor bruto", Storage:="VALOR_BRUTO", DbType:="NUMERIC(20,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)> _
    Public Property VALOR_BRUTO() As Decimal
        Get
            Return _VALOR_BRUTO
        End Get
        Set(ByVal Value As Decimal)
            _VALOR_BRUTO = Value
            OnPropertyChanged("VALOR_BRUTO")
        End Set
    End Property 

    Private _VALOR_BRUTOOld As Decimal
    Public Property VALOR_BRUTOOld() As Decimal
        Get
            Return _VALOR_BRUTOOld
        End Get
        Set(ByVal Value As Decimal)
            _VALOR_BRUTOOld = Value
        End Set
    End Property 

    Private _RENTA As Decimal
    <Column(Name:="Renta", Storage:="RENTA", DbType:="NUMERIC(20,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)> _
    Public Property RENTA() As Decimal
        Get
            Return _RENTA
        End Get
        Set(ByVal Value As Decimal)
            _RENTA = Value
            OnPropertyChanged("RENTA")
        End Set
    End Property 

    Private _RENTAOld As Decimal
    Public Property RENTAOld() As Decimal
        Get
            Return _RENTAOld
        End Get
        Set(ByVal Value As Decimal)
            _RENTAOld = Value
        End Set
    End Property 

    Private _RETENCION_IVA As Decimal
    <Column(Name:="Retencion iva", Storage:="RETENCION_IVA", DbType:="NUMERIC(20,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)> _
    Public Property RETENCION_IVA() As Decimal
        Get
            Return _RETENCION_IVA
        End Get
        Set(ByVal Value As Decimal)
            _RETENCION_IVA = Value
            OnPropertyChanged("RETENCION_IVA")
        End Set
    End Property 

    Private _RETENCION_IVAOld As Decimal
    Public Property RETENCION_IVAOld() As Decimal
        Get
            Return _RETENCION_IVAOld
        End Get
        Set(ByVal Value As Decimal)
            _RETENCION_IVAOld = Value
        End Set
    End Property 

    Private _DESC_FLETE As Decimal
    <Column(Name:="Desc flete", Storage:="DESC_FLETE", DbType:="NUMERIC(20,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)> _
    Public Property DESC_FLETE() As Decimal
        Get
            Return _DESC_FLETE
        End Get
        Set(ByVal Value As Decimal)
            _DESC_FLETE = Value
            OnPropertyChanged("DESC_FLETE")
        End Set
    End Property 

    Private _DESC_FLETEOld As Decimal
    Public Property DESC_FLETEOld() As Decimal
        Get
            Return _DESC_FLETEOld
        End Get
        Set(ByVal Value As Decimal)
            _DESC_FLETEOld = Value
        End Set
    End Property 

    Private _DESC_CARGA As Decimal
    <Column(Name:="Desc carga", Storage:="DESC_CARGA", DbType:="NUMERIC(20,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)> _
    Public Property DESC_CARGA() As Decimal
        Get
            Return _DESC_CARGA
        End Get
        Set(ByVal Value As Decimal)
            _DESC_CARGA = Value
            OnPropertyChanged("DESC_CARGA")
        End Set
    End Property 

    Private _DESC_CARGAOld As Decimal
    Public Property DESC_CARGAOld() As Decimal
        Get
            Return _DESC_CARGAOld
        End Get
        Set(ByVal Value As Decimal)
            _DESC_CARGAOld = Value
        End Set
    End Property 

    Private _DESC_CARGA_CONTRA As Decimal
    <Column(Name:="Desc carga contra", Storage:="DESC_CARGA_CONTRA", DbType:="NUMERIC(20,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)> _
    Public Property DESC_CARGA_CONTRA() As Decimal
        Get
            Return _DESC_CARGA_CONTRA
        End Get
        Set(ByVal Value As Decimal)
            _DESC_CARGA_CONTRA = Value
            OnPropertyChanged("DESC_CARGA_CONTRA")
        End Set
    End Property 

    Private _DESC_CARGA_CONTRAOld As Decimal
    Public Property DESC_CARGA_CONTRAOld() As Decimal
        Get
            Return _DESC_CARGA_CONTRAOld
        End Get
        Set(ByVal Value As Decimal)
            _DESC_CARGA_CONTRAOld = Value
        End Set
    End Property 

    Private _DESC_BANCOS As Decimal
    <Column(Name:="Desc bancos", Storage:="DESC_BANCOS", DbType:="NUMERIC(20,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)> _
    Public Property DESC_BANCOS() As Decimal
        Get
            Return _DESC_BANCOS
        End Get
        Set(ByVal Value As Decimal)
            _DESC_BANCOS = Value
            OnPropertyChanged("DESC_BANCOS")
        End Set
    End Property 

    Private _DESC_BANCOSOld As Decimal
    Public Property DESC_BANCOSOld() As Decimal
        Get
            Return _DESC_BANCOSOld
        End Get
        Set(ByVal Value As Decimal)
            _DESC_BANCOSOld = Value
        End Set
    End Property 

    Private _DESC_COMBUSTIBLE As Decimal
    <Column(Name:="Desc combustible", Storage:="DESC_COMBUSTIBLE", DbType:="NUMERIC(20,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)> _
    Public Property DESC_COMBUSTIBLE() As Decimal
        Get
            Return _DESC_COMBUSTIBLE
        End Get
        Set(ByVal Value As Decimal)
            _DESC_COMBUSTIBLE = Value
            OnPropertyChanged("DESC_COMBUSTIBLE")
        End Set
    End Property 

    Private _DESC_COMBUSTIBLEOld As Decimal
    Public Property DESC_COMBUSTIBLEOld() As Decimal
        Get
            Return _DESC_COMBUSTIBLEOld
        End Get
        Set(ByVal Value As Decimal)
            _DESC_COMBUSTIBLEOld = Value
        End Set
    End Property 

    Private _DESC_ANTICIPO As Decimal
    <Column(Name:="Desc anticipo", Storage:="DESC_ANTICIPO", DbType:="NUMERIC(20,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)> _
    Public Property DESC_ANTICIPO() As Decimal
        Get
            Return _DESC_ANTICIPO
        End Get
        Set(ByVal Value As Decimal)
            _DESC_ANTICIPO = Value
            OnPropertyChanged("DESC_ANTICIPO")
        End Set
    End Property 

    Private _DESC_ANTICIPOOld As Decimal
    Public Property DESC_ANTICIPOOld() As Decimal
        Get
            Return _DESC_ANTICIPOOld
        End Get
        Set(ByVal Value As Decimal)
            _DESC_ANTICIPOOld = Value
        End Set
    End Property 

    Private _DESC_INTERES As Decimal
    <Column(Name:="Desc interes", Storage:="DESC_INTERES", DbType:="NUMERIC(20,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)> _
    Public Property DESC_INTERES() As Decimal
        Get
            Return _DESC_INTERES
        End Get
        Set(ByVal Value As Decimal)
            _DESC_INTERES = Value
            OnPropertyChanged("DESC_INTERES")
        End Set
    End Property 

    Private _DESC_INTERESOld As Decimal
    Public Property DESC_INTERESOld() As Decimal
        Get
            Return _DESC_INTERESOld
        End Get
        Set(ByVal Value As Decimal)
            _DESC_INTERESOld = Value
        End Set
    End Property 

    Private _DESC_AGROQUIMICO As Decimal
    <Column(Name:="Desc agroquimico", Storage:="DESC_AGROQUIMICO", DbType:="NUMERIC(20,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)> _
    Public Property DESC_AGROQUIMICO() As Decimal
        Get
            Return _DESC_AGROQUIMICO
        End Get
        Set(ByVal Value As Decimal)
            _DESC_AGROQUIMICO = Value
            OnPropertyChanged("DESC_AGROQUIMICO")
        End Set
    End Property 

    Private _DESC_AGROQUIMICOOld As Decimal
    Public Property DESC_AGROQUIMICOOld() As Decimal
        Get
            Return _DESC_AGROQUIMICOOld
        End Get
        Set(ByVal Value As Decimal)
            _DESC_AGROQUIMICOOld = Value
        End Set
    End Property 

    Private _DESC_SEGURO As Decimal
    <Column(Name:="Desc seguro", Storage:="DESC_SEGURO", DbType:="NUMERIC(20,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)> _
    Public Property DESC_SEGURO() As Decimal
        Get
            Return _DESC_SEGURO
        End Get
        Set(ByVal Value As Decimal)
            _DESC_SEGURO = Value
            OnPropertyChanged("DESC_SEGURO")
        End Set
    End Property 

    Private _DESC_SEGUROOld As Decimal
    Public Property DESC_SEGUROOld() As Decimal
        Get
            Return _DESC_SEGUROOld
        End Get
        Set(ByVal Value As Decimal)
            _DESC_SEGUROOld = Value
        End Set
    End Property 

    Private _DESC_RESPUESTOS As Decimal
    <Column(Name:="Desc respuestos", Storage:="DESC_RESPUESTOS", DbType:="NUMERIC(20,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)> _
    Public Property DESC_RESPUESTOS() As Decimal
        Get
            Return _DESC_RESPUESTOS
        End Get
        Set(ByVal Value As Decimal)
            _DESC_RESPUESTOS = Value
            OnPropertyChanged("DESC_RESPUESTOS")
        End Set
    End Property 

    Private _DESC_RESPUESTOSOld As Decimal
    Public Property DESC_RESPUESTOSOld() As Decimal
        Get
            Return _DESC_RESPUESTOSOld
        End Get
        Set(ByVal Value As Decimal)
            _DESC_RESPUESTOSOld = Value
        End Set
    End Property 

    Private _DESC_OTROS As Decimal
    <Column(Name:="Desc otros", Storage:="DESC_OTROS", DbType:="NUMERIC(20,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)> _
    Public Property DESC_OTROS() As Decimal
        Get
            Return _DESC_OTROS
        End Get
        Set(ByVal Value As Decimal)
            _DESC_OTROS = Value
            OnPropertyChanged("DESC_OTROS")
        End Set
    End Property 

    Private _DESC_OTROSOld As Decimal
    Public Property DESC_OTROSOld() As Decimal
        Get
            Return _DESC_OTROSOld
        End Get
        Set(ByVal Value As Decimal)
            _DESC_OTROSOld = Value
        End Set
    End Property 

    Private _PAGO_NETO As Decimal
    <Column(Name:="Pago neto", Storage:="PAGO_NETO", DbType:="NUMERIC(20,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)> _
    Public Property PAGO_NETO() As Decimal
        Get
            Return _PAGO_NETO
        End Get
        Set(ByVal Value As Decimal)
            _PAGO_NETO = Value
            OnPropertyChanged("PAGO_NETO")
        End Set
    End Property 

    Private _PAGO_NETOOld As Decimal
    Public Property PAGO_NETOOld() As Decimal
        Get
            Return _PAGO_NETOOld
        End Get
        Set(ByVal Value As Decimal)
            _PAGO_NETOOld = Value
        End Set
    End Property 

    Private _ES_CONTRIBUYENTE As Boolean
    <Column(Name:="Es contribuyente", Storage:="ES_CONTRIBUYENTE", DbType:="BIT NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 1)> _
    Public Property ES_CONTRIBUYENTE() As Boolean
        Get
            Return _ES_CONTRIBUYENTE
        End Get
        Set(ByVal Value As Boolean)
            _ES_CONTRIBUYENTE = Value
            OnPropertyChanged("ES_CONTRIBUYENTE")
        End Set
    End Property 

    Private _ES_CONTRIBUYENTEOld As Boolean
    Public Property ES_CONTRIBUYENTEOld() As Boolean
        Get
            Return _ES_CONTRIBUYENTEOld
        End Get
        Set(ByVal Value As Boolean)
            _ES_CONTRIBUYENTEOld = Value
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

    Private _DESC_SERVICIO_ROZA As Decimal
    <Column(Name:="Desc servicio roza", Storage:="DESC_SERVICIO_ROZA", DbType:="NUMERIC(20,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)> _
    Public Property DESC_SERVICIO_ROZA() As Decimal
        Get
            Return _DESC_SERVICIO_ROZA
        End Get
        Set(ByVal Value As Decimal)
            _DESC_SERVICIO_ROZA = Value
            OnPropertyChanged("DESC_SERVICIO_ROZA")
        End Set
    End Property 

    Private _DESC_SERVICIO_ROZAOld As Decimal
    Public Property DESC_SERVICIO_ROZAOld() As Decimal
        Get
            Return _DESC_SERVICIO_ROZAOld
        End Get
        Set(ByVal Value As Decimal)
            _DESC_SERVICIO_ROZAOld = Value
        End Set
    End Property 

    Private _NOMBRE_PROVEE_TRANS As String
    <Column(Name:="Nombre provee trans", Storage:="NOMBRE_PROVEE_TRANS", DbType:="VARCHAR(120)", Id:=False), _
     DataObjectField(False, False, True, 120)> _
    Public Property NOMBRE_PROVEE_TRANS() As String
        Get
            Return _NOMBRE_PROVEE_TRANS
        End Get
        Set(ByVal Value As String)
            _NOMBRE_PROVEE_TRANS = Value
            OnPropertyChanged("NOMBRE_PROVEE_TRANS")
        End Set
    End Property 

    Private _NOMBRE_PROVEE_TRANSOld As String
    Public Property NOMBRE_PROVEE_TRANSOld() As String
        Get
            Return _NOMBRE_PROVEE_TRANSOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_PROVEE_TRANSOld = Value
        End Set
    End Property 

    Private _NO_CHEQUE As Int32
    <Column(Name:="No cheque", Storage:="NO_CHEQUE", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property NO_CHEQUE() As Int32
        Get
            Return _NO_CHEQUE
        End Get
        Set(ByVal Value As Int32)
            _NO_CHEQUE = Value
            OnPropertyChanged("NO_CHEQUE")
        End Set
    End Property 

    Private _NO_CHEQUEOld As Int32
    Public Property NO_CHEQUEOld() As Int32
        Get
            Return _NO_CHEQUEOld
        End Get
        Set(ByVal Value As Int32)
            _NO_CHEQUEOld = Value
        End Set
    End Property 

    Private _ID_CHEQUE_PLANILLA As Int32
    <Column(Name:="Id cheque planilla", Storage:="ID_CHEQUE_PLANILLA", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_CHEQUE_PLANILLA() As Int32
        Get
            Return _ID_CHEQUE_PLANILLA
        End Get
        Set(ByVal Value As Int32)
            _ID_CHEQUE_PLANILLA = Value
            OnPropertyChanged("ID_CHEQUE_PLANILLA")
        End Set
    End Property 

    Private _ID_CHEQUE_PLANILLAOld As Int32
    Public Property ID_CHEQUE_PLANILLAOld() As Int32
        Get
            Return _ID_CHEQUE_PLANILLAOld
        End Get
        Set(ByVal Value As Int32)
            _ID_CHEQUE_PLANILLAOld = Value
        End Set
    End Property


    Private _ID_PLANILLA_BASE As Int32
    <Column(Name:="Id planilla base", Storage:="ID_PLANILLA_BASE", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_PLANILLA_BASE() As Int32
        Get
            Return _ID_PLANILLA_BASE
        End Get
        Set(ByVal Value As Int32)
            _ID_PLANILLA_BASE = Value
            OnPropertyChanged("ID_PLANILLA_BASE")
        End Set
    End Property

    Private _ID_PLANILLA_BASEOld As Int32
    Public Property ID_PLANILLA_BASEOld() As Int32
        Get
            Return _ID_PLANILLA_BASEOld
        End Get
        Set(ByVal Value As Int32)
            _ID_PLANILLA_BASEOld = Value
        End Set
    End Property



    Private _fkID_CHEQUE_PLANILLA As CHEQUE_PLANILLA
    Public Property fkID_CHEQUE_PLANILLA() As CHEQUE_PLANILLA
        Get
            Return _fkID_CHEQUE_PLANILLA
        End Get
        Set(ByVal Value As CHEQUE_PLANILLA)
            _fkID_CHEQUE_PLANILLA = Value
        End Set
    End Property

    Private _ID_TIPO_PROVEEDOR As Int32
    <Column(Name:="Id tipo proveedor", Storage:="ID_TIPO_PROVEEDOR", DBType:="INT NOT NULL", Id:=True),
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)>
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


#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
