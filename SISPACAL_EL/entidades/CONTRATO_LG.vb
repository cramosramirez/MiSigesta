''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.CONTRATO_LG
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row CONTRATO_LG en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	10/08/2020	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="CONTRATO_LG")> Public Class CONTRATO_LG
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aCODICONTRATO As String, aANIOZAFRA As String, aCODIPROVEEDOR As String, aFECHA_CONTRATOCB As DateTime, aESTADO_CONTRATOCB As Int32, aFINANCOADO As String, aFINAN_NUMERO As String, aTOTALMZ_CONTRATOCB As Decimal, aTONELADAS_CONTRATOCB As Decimal, aOBSERVACIONES_CONTRATOCB As String, aUSER_CREA As String, aFECHA_CREA As DateTime, aUSER_ACT As String, aFECHA_ACT As DateTime, aNO_REGISTRO As String, aFECHA_REGISTRO As DateTime, aAPELLIDOS As String, aNOMBRES As String, aDIRECCION As String, aTELEFONO As String, aCELULAR As String, aDUI As String, aNIT As String, aCREDITFISCAL As String, aAPODERADO As String, aDUI_APODERADO As String, aNIT_APODERADO As String, aID_ZAFRA As Int32, aNO_CONTRATO As Int32, aTIPO_CONTRATO As Int32, aFECHA_CONTRA_LEGAL As DateTime, aEDAD As Int32)
        Me._CODICONTRATO = aCODICONTRATO
        Me._ANIOZAFRA = aANIOZAFRA
        Me._CODIPROVEEDOR = aCODIPROVEEDOR
        Me._FECHA_CONTRATOCB = aFECHA_CONTRATOCB
        Me._ESTADO_CONTRATOCB = aESTADO_CONTRATOCB
        Me._FINANCOADO = aFINANCOADO
        Me._FINAN_NUMERO = aFINAN_NUMERO
        Me._TOTALMZ_CONTRATOCB = aTOTALMZ_CONTRATOCB
        Me._TONELADAS_CONTRATOCB = aTONELADAS_CONTRATOCB
        Me._OBSERVACIONES_CONTRATOCB = aOBSERVACIONES_CONTRATOCB
        Me._USER_CREA = aUSER_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USER_ACT = aUSER_ACT
        Me._FECHA_ACT = aFECHA_ACT
        Me._NO_REGISTRO = aNO_REGISTRO
        Me._FECHA_REGISTRO = aFECHA_REGISTRO
        Me._APELLIDOS = aAPELLIDOS
        Me._NOMBRES = aNOMBRES
        Me._DIRECCION = aDIRECCION
        Me._TELEFONO = aTELEFONO
        Me._CELULAR = aCELULAR
        Me._DUI = aDUI
        Me._NIT = aNIT
        Me._CREDITFISCAL = aCREDITFISCAL
        Me._APODERADO = aAPODERADO
        Me._DUI_APODERADO = aDUI_APODERADO
        Me._NIT_APODERADO = aNIT_APODERADO
        Me._ID_ZAFRA = aID_ZAFRA
        Me._NO_CONTRATO = aNO_CONTRATO
        Me._TIPO_CONTRATO = aTIPO_CONTRATO
        Me._FECHA_CONTRA_LEGAL = aFECHA_CONTRA_LEGAL
        Me._EDAD = aEDAD
    End Sub

#Region " Properties "

    Private _CODICONTRATO As String
    <Column(Name:="Codicontrato", Storage:="CODICONTRATO", DbType:="CHAR(13) NOT NULL", Id:=True), _
     DataObjectField(True, False, False, 13)> _
    Public Property CODICONTRATO() As String
        Get
            Return _CODICONTRATO
        End Get
        Set(ByVal Value As String)
            _CODICONTRATO = Value
            OnPropertyChanged("CODICONTRATO")
        End Set
    End Property 

    Private _ANIOZAFRA As String
    <Column(Name:="Aniozafra", Storage:="ANIOZAFRA", DbType:="VARCHAR(9)", Id:=False), _
     DataObjectField(False, False, True, 9)> _
    Public Property ANIOZAFRA() As String
        Get
            Return _ANIOZAFRA
        End Get
        Set(ByVal Value As String)
            _ANIOZAFRA = Value
            OnPropertyChanged("ANIOZAFRA")
        End Set
    End Property 

    Private _ANIOZAFRAOld As String
    Public Property ANIOZAFRAOld() As String
        Get
            Return _ANIOZAFRAOld
        End Get
        Set(ByVal Value As String)
            _ANIOZAFRAOld = Value
        End Set
    End Property 

    Private _CODIPROVEEDOR As String
    <Column(Name:="Codiproveedor", Storage:="CODIPROVEEDOR", DbType:="CHAR(10)", Id:=False), _
     DataObjectField(False, False, True, 10)> _
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

    Private _FECHA_CONTRATOCB As DateTime
    <Column(Name:="Fecha contratocb", Storage:="FECHA_CONTRATOCB", DbType:="DATETIME", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_CONTRATOCB() As DateTime
        Get
            Return _FECHA_CONTRATOCB
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_CONTRATOCB = Value
            OnPropertyChanged("FECHA_CONTRATOCB")
        End Set
    End Property 

    Private _FECHA_CONTRATOCBOld As DateTime
    Public Property FECHA_CONTRATOCBOld() As DateTime
        Get
            Return _FECHA_CONTRATOCBOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_CONTRATOCBOld = Value
        End Set
    End Property 

    Private _ESTADO_CONTRATOCB As Int32
    <Column(Name:="Estado contratocb", Storage:="ESTADO_CONTRATOCB", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ESTADO_CONTRATOCB() As Int32
        Get
            Return _ESTADO_CONTRATOCB
        End Get
        Set(ByVal Value As Int32)
            _ESTADO_CONTRATOCB = Value
            OnPropertyChanged("ESTADO_CONTRATOCB")
        End Set
    End Property 

    Private _ESTADO_CONTRATOCBOld As Int32
    Public Property ESTADO_CONTRATOCBOld() As Int32
        Get
            Return _ESTADO_CONTRATOCBOld
        End Get
        Set(ByVal Value As Int32)
            _ESTADO_CONTRATOCBOld = Value
        End Set
    End Property 

    Private _FINANCOADO As String
    <Column(Name:="Financoado", Storage:="FINANCOADO", DbType:="VARCHAR(200)", Id:=False), _
     DataObjectField(False, False, True, 200)> _
    Public Property FINANCOADO() As String
        Get
            Return _FINANCOADO
        End Get
        Set(ByVal Value As String)
            _FINANCOADO = Value
            OnPropertyChanged("FINANCOADO")
        End Set
    End Property 

    Private _FINANCOADOOld As String
    Public Property FINANCOADOOld() As String
        Get
            Return _FINANCOADOOld
        End Get
        Set(ByVal Value As String)
            _FINANCOADOOld = Value
        End Set
    End Property 

    Private _FINAN_NUMERO As String
    <Column(Name:="Finan numero", Storage:="FINAN_NUMERO", DbType:="VARCHAR(4)", Id:=False), _
     DataObjectField(False, False, True, 4)> _
    Public Property FINAN_NUMERO() As String
        Get
            Return _FINAN_NUMERO
        End Get
        Set(ByVal Value As String)
            _FINAN_NUMERO = Value
            OnPropertyChanged("FINAN_NUMERO")
        End Set
    End Property 

    Private _FINAN_NUMEROOld As String
    Public Property FINAN_NUMEROOld() As String
        Get
            Return _FINAN_NUMEROOld
        End Get
        Set(ByVal Value As String)
            _FINAN_NUMEROOld = Value
        End Set
    End Property 

    Private _TOTALMZ_CONTRATOCB As Decimal
    <Column(Name:="Totalmz contratocb", Storage:="TOTALMZ_CONTRATOCB", DbType:="NUMERIC(10,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=2)> _
    Public Property TOTALMZ_CONTRATOCB() As Decimal
        Get
            Return _TOTALMZ_CONTRATOCB
        End Get
        Set(ByVal Value As Decimal)
            _TOTALMZ_CONTRATOCB = Value
            OnPropertyChanged("TOTALMZ_CONTRATOCB")
        End Set
    End Property 

    Private _TOTALMZ_CONTRATOCBOld As Decimal
    Public Property TOTALMZ_CONTRATOCBOld() As Decimal
        Get
            Return _TOTALMZ_CONTRATOCBOld
        End Get
        Set(ByVal Value As Decimal)
            _TOTALMZ_CONTRATOCBOld = Value
        End Set
    End Property 

    Private _TONELADAS_CONTRATOCB As Decimal
    <Column(Name:="Toneladas contratocb", Storage:="TONELADAS_CONTRATOCB", DbType:="NUMERIC(10,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=2)> _
    Public Property TONELADAS_CONTRATOCB() As Decimal
        Get
            Return _TONELADAS_CONTRATOCB
        End Get
        Set(ByVal Value As Decimal)
            _TONELADAS_CONTRATOCB = Value
            OnPropertyChanged("TONELADAS_CONTRATOCB")
        End Set
    End Property 

    Private _TONELADAS_CONTRATOCBOld As Decimal
    Public Property TONELADAS_CONTRATOCBOld() As Decimal
        Get
            Return _TONELADAS_CONTRATOCBOld
        End Get
        Set(ByVal Value As Decimal)
            _TONELADAS_CONTRATOCBOld = Value
        End Set
    End Property 

    Private _OBSERVACIONES_CONTRATOCB As String
    <Column(Name:="Observaciones contratocb", Storage:="OBSERVACIONES_CONTRATOCB", DbType:="VARCHAR(80)", Id:=False), _
     DataObjectField(False, False, True, 80)> _
    Public Property OBSERVACIONES_CONTRATOCB() As String
        Get
            Return _OBSERVACIONES_CONTRATOCB
        End Get
        Set(ByVal Value As String)
            _OBSERVACIONES_CONTRATOCB = Value
            OnPropertyChanged("OBSERVACIONES_CONTRATOCB")
        End Set
    End Property 

    Private _OBSERVACIONES_CONTRATOCBOld As String
    Public Property OBSERVACIONES_CONTRATOCBOld() As String
        Get
            Return _OBSERVACIONES_CONTRATOCBOld
        End Get
        Set(ByVal Value As String)
            _OBSERVACIONES_CONTRATOCBOld = Value
        End Set
    End Property 

    Private _USER_CREA As String
    <Column(Name:="User crea", Storage:="USER_CREA", DbType:="VARCHAR(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
    Public Property USER_CREA() As String
        Get
            Return _USER_CREA
        End Get
        Set(ByVal Value As String)
            _USER_CREA = Value
            OnPropertyChanged("USER_CREA")
        End Set
    End Property 

    Private _USER_CREAOld As String
    Public Property USER_CREAOld() As String
        Get
            Return _USER_CREAOld
        End Get
        Set(ByVal Value As String)
            _USER_CREAOld = Value
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

    Private _USER_ACT As String
    <Column(Name:="User act", Storage:="USER_ACT", DbType:="VARCHAR(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
    Public Property USER_ACT() As String
        Get
            Return _USER_ACT
        End Get
        Set(ByVal Value As String)
            _USER_ACT = Value
            OnPropertyChanged("USER_ACT")
        End Set
    End Property 

    Private _USER_ACTOld As String
    Public Property USER_ACTOld() As String
        Get
            Return _USER_ACTOld
        End Get
        Set(ByVal Value As String)
            _USER_ACTOld = Value
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

    Private _NO_REGISTRO As String
    <Column(Name:="No registro", Storage:="NO_REGISTRO", DbType:="NVARCHAR(40)", Id:=False), _
     DataObjectField(False, False, True, 40)> _
    Public Property NO_REGISTRO() As String
        Get
            Return _NO_REGISTRO
        End Get
        Set(ByVal Value As String)
            _NO_REGISTRO = Value
            OnPropertyChanged("NO_REGISTRO")
        End Set
    End Property 

    Private _NO_REGISTROOld As String
    Public Property NO_REGISTROOld() As String
        Get
            Return _NO_REGISTROOld
        End Get
        Set(ByVal Value As String)
            _NO_REGISTROOld = Value
        End Set
    End Property 

    Private _FECHA_REGISTRO As DateTime
    <Column(Name:="Fecha registro", Storage:="FECHA_REGISTRO", DbType:="DATETIME", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_REGISTRO() As DateTime
        Get
            Return _FECHA_REGISTRO
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_REGISTRO = Value
            OnPropertyChanged("FECHA_REGISTRO")
        End Set
    End Property 

    Private _FECHA_REGISTROOld As DateTime
    Public Property FECHA_REGISTROOld() As DateTime
        Get
            Return _FECHA_REGISTROOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_REGISTROOld = Value
        End Set
    End Property 

    Private _APELLIDOS As String
    <Column(Name:="Apellidos", Storage:="APELLIDOS", DbType:="CHAR(36)", Id:=False), _
     DataObjectField(False, False, True, 36)> _
    Public Property APELLIDOS() As String
        Get
            Return _APELLIDOS
        End Get
        Set(ByVal Value As String)
            _APELLIDOS = Value
            OnPropertyChanged("APELLIDOS")
        End Set
    End Property 

    Private _APELLIDOSOld As String
    Public Property APELLIDOSOld() As String
        Get
            Return _APELLIDOSOld
        End Get
        Set(ByVal Value As String)
            _APELLIDOSOld = Value
        End Set
    End Property 

    Private _NOMBRES As String
    <Column(Name:="Nombres", Storage:="NOMBRES", DbType:="CHAR(36)", Id:=False), _
     DataObjectField(False, False, True, 36)> _
    Public Property NOMBRES() As String
        Get
            Return _NOMBRES
        End Get
        Set(ByVal Value As String)
            _NOMBRES = Value
            OnPropertyChanged("NOMBRES")
        End Set
    End Property 

    Private _NOMBRESOld As String
    Public Property NOMBRESOld() As String
        Get
            Return _NOMBRESOld
        End Get
        Set(ByVal Value As String)
            _NOMBRESOld = Value
        End Set
    End Property 

    Private _DIRECCION As String
    <Column(Name:="Direccion", Storage:="DIRECCION", DbType:="CHAR(250)", Id:=False), _
     DataObjectField(False, False, True, 250)> _
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

    Private _TELEFONO As String
    <Column(Name:="Telefono", Storage:="TELEFONO", DbType:="CHAR(8)", Id:=False), _
     DataObjectField(False, False, True, 8)> _
    Public Property TELEFONO() As String
        Get
            Return _TELEFONO
        End Get
        Set(ByVal Value As String)
            _TELEFONO = Value
            OnPropertyChanged("TELEFONO")
        End Set
    End Property 

    Private _TELEFONOOld As String
    Public Property TELEFONOOld() As String
        Get
            Return _TELEFONOOld
        End Get
        Set(ByVal Value As String)
            _TELEFONOOld = Value
        End Set
    End Property 

    Private _CELULAR As String
    <Column(Name:="Celular", Storage:="CELULAR", DbType:="CHAR(8)", Id:=False), _
     DataObjectField(False, False, True, 8)> _
    Public Property CELULAR() As String
        Get
            Return _CELULAR
        End Get
        Set(ByVal Value As String)
            _CELULAR = Value
            OnPropertyChanged("CELULAR")
        End Set
    End Property 

    Private _CELULAROld As String
    Public Property CELULAROld() As String
        Get
            Return _CELULAROld
        End Get
        Set(ByVal Value As String)
            _CELULAROld = Value
        End Set
    End Property 

    Private _DUI As String
    <Column(Name:="Dui", Storage:="DUI", DbType:="CHAR(10)", Id:=False), _
     DataObjectField(False, False, True, 10)> _
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
    <Column(Name:="Nit", Storage:="NIT", DbType:="CHAR(17)", Id:=False), _
     DataObjectField(False, False, True, 17)> _
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

    Private _CREDITFISCAL As String
    <Column(Name:="Creditfiscal", Storage:="CREDITFISCAL", DbType:="CHAR(10)", Id:=False), _
     DataObjectField(False, False, True, 10)> _
    Public Property CREDITFISCAL() As String
        Get
            Return _CREDITFISCAL
        End Get
        Set(ByVal Value As String)
            _CREDITFISCAL = Value
            OnPropertyChanged("CREDITFISCAL")
        End Set
    End Property 

    Private _CREDITFISCALOld As String
    Public Property CREDITFISCALOld() As String
        Get
            Return _CREDITFISCALOld
        End Get
        Set(ByVal Value As String)
            _CREDITFISCALOld = Value
        End Set
    End Property 

    Private _APODERADO As String
    <Column(Name:="Apoderado", Storage:="APODERADO", DbType:="CHAR(60)", Id:=False), _
     DataObjectField(False, False, True, 60)> _
    Public Property APODERADO() As String
        Get
            Return _APODERADO
        End Get
        Set(ByVal Value As String)
            _APODERADO = Value
            OnPropertyChanged("APODERADO")
        End Set
    End Property 

    Private _APODERADOOld As String
    Public Property APODERADOOld() As String
        Get
            Return _APODERADOOld
        End Get
        Set(ByVal Value As String)
            _APODERADOOld = Value
        End Set
    End Property 

    Private _DUI_APODERADO As String
    <Column(Name:="Dui apoderado", Storage:="DUI_APODERADO", DbType:="CHAR(10)", Id:=False), _
     DataObjectField(False, False, True, 10)> _
    Public Property DUI_APODERADO() As String
        Get
            Return _DUI_APODERADO
        End Get
        Set(ByVal Value As String)
            _DUI_APODERADO = Value
            OnPropertyChanged("DUI_APODERADO")
        End Set
    End Property 

    Private _DUI_APODERADOOld As String
    Public Property DUI_APODERADOOld() As String
        Get
            Return _DUI_APODERADOOld
        End Get
        Set(ByVal Value As String)
            _DUI_APODERADOOld = Value
        End Set
    End Property 

    Private _NIT_APODERADO As String
    <Column(Name:="Nit apoderado", Storage:="NIT_APODERADO", DbType:="CHAR(17)", Id:=False), _
     DataObjectField(False, False, True, 17)> _
    Public Property NIT_APODERADO() As String
        Get
            Return _NIT_APODERADO
        End Get
        Set(ByVal Value As String)
            _NIT_APODERADO = Value
            OnPropertyChanged("NIT_APODERADO")
        End Set
    End Property 

    Private _NIT_APODERADOOld As String
    Public Property NIT_APODERADOOld() As String
        Get
            Return _NIT_APODERADOOld
        End Get
        Set(ByVal Value As String)
            _NIT_APODERADOOld = Value
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

    Private _NO_CONTRATO As Int32
    <Column(Name:="No contrato", Storage:="NO_CONTRATO", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property NO_CONTRATO() As Int32
        Get
            Return _NO_CONTRATO
        End Get
        Set(ByVal Value As Int32)
            _NO_CONTRATO = Value
            OnPropertyChanged("NO_CONTRATO")
        End Set
    End Property 

    Private _NO_CONTRATOOld As Int32
    Public Property NO_CONTRATOOld() As Int32
        Get
            Return _NO_CONTRATOOld
        End Get
        Set(ByVal Value As Int32)
            _NO_CONTRATOOld = Value
        End Set
    End Property 

    Private _TIPO_CONTRATO As Int32
    <Column(Name:="Tipo contrato", Storage:="TIPO_CONTRATO", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property TIPO_CONTRATO() As Int32
        Get
            Return _TIPO_CONTRATO
        End Get
        Set(ByVal Value As Int32)
            _TIPO_CONTRATO = Value
            OnPropertyChanged("TIPO_CONTRATO")
        End Set
    End Property 

    Private _TIPO_CONTRATOOld As Int32
    Public Property TIPO_CONTRATOOld() As Int32
        Get
            Return _TIPO_CONTRATOOld
        End Get
        Set(ByVal Value As Int32)
            _TIPO_CONTRATOOld = Value
        End Set
    End Property 

    Private _FECHA_CONTRA_LEGAL As DateTime
    <Column(Name:="Fecha contra legal", Storage:="FECHA_CONTRA_LEGAL", DbType:="DATETIME", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_CONTRA_LEGAL() As DateTime
        Get
            Return _FECHA_CONTRA_LEGAL
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_CONTRA_LEGAL = Value
            OnPropertyChanged("FECHA_CONTRA_LEGAL")
        End Set
    End Property 

    Private _FECHA_CONTRA_LEGALOld As DateTime
    Public Property FECHA_CONTRA_LEGALOld() As DateTime
        Get
            Return _FECHA_CONTRA_LEGALOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_CONTRA_LEGALOld = Value
        End Set
    End Property 

    Private _EDAD As Int32
    <Column(Name:="Edad", Storage:="EDAD", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property EDAD() As Int32
        Get
            Return _EDAD
        End Get
        Set(ByVal Value As Int32)
            _EDAD = Value
            OnPropertyChanged("EDAD")
        End Set
    End Property 

    Private _EDADOld As Int32
    Public Property EDADOld() As Int32
        Get
            Return _EDADOld
        End Get
        Set(ByVal Value As Int32)
            _EDADOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
