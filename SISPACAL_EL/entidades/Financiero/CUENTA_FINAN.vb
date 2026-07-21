''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.CUENTA_FINAN
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row CUENTA_FINAN en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	15/07/2015	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="CUENTA_FINAN")> Public Class CUENTA_FINAN
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_CUENTA_FINAN As Int32, aCODIGO_CUENTA As String, aNOMBRE_CUENTA As String, aDESCRIP_CUENTA As String, aTIPO_FTO As Int32, aAPLICA_SOLIC_AGRICOLA As Boolean, aAPLICA_ANALIS_FTO As Boolean, aAPLICA_FACTURACION As Boolean, aAPLICA_INTERES As Boolean, aAPLICA_EMISION_CHEQ As Boolean, aAPLICA_DESCTO_PLA As Boolean, aPORC_SUBSIDIO As Decimal, aZAFRA As String, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime)
        Me._ID_CUENTA_FINAN = aID_CUENTA_FINAN
        Me._CODIGO_CUENTA = aCODIGO_CUENTA
        Me._NOMBRE_CUENTA = aNOMBRE_CUENTA
        Me._DESCRIP_CUENTA = aDESCRIP_CUENTA
        Me._TIPO_FTO = aTIPO_FTO
        Me._APLICA_SOLIC_AGRICOLA = aAPLICA_SOLIC_AGRICOLA
        Me._APLICA_ANALIS_FTO = aAPLICA_ANALIS_FTO
        Me._APLICA_FACTURACION = aAPLICA_FACTURACION
        Me._APLICA_INTERES = aAPLICA_INTERES
        Me._APLICA_EMISION_CHEQ = aAPLICA_EMISION_CHEQ
        Me._APLICA_DESCTO_PLA = aAPLICA_DESCTO_PLA
        Me._PORC_SUBSIDIO = aPORC_SUBSIDIO
        Me._ZAFRA = aZAFRA
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
    End Sub

#Region " Properties "

    Private _ID_CUENTA_FINAN As Int32
    <Column(Name:="Id cuenta finan", Storage:="ID_CUENTA_FINAN", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_CUENTA_FINAN() As Int32
        Get
            Return _ID_CUENTA_FINAN
        End Get
        Set(ByVal Value As Int32)
            _ID_CUENTA_FINAN = Value
            OnPropertyChanged("ID_CUENTA_FINAN")
        End Set
    End Property 

    Private _CODIGO_CUENTA As String
    <Column(Name:="Codigo cuenta", Storage:="CODIGO_CUENTA", DbType:="VARCHAR(10) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 10)> _
    Public Property CODIGO_CUENTA() As String
        Get
            Return _CODIGO_CUENTA
        End Get
        Set(ByVal Value As String)
            _CODIGO_CUENTA = Value
            OnPropertyChanged("CODIGO_CUENTA")
        End Set
    End Property 

    Private _CODIGO_CUENTAOld As String
    Public Property CODIGO_CUENTAOld() As String
        Get
            Return _CODIGO_CUENTAOld
        End Get
        Set(ByVal Value As String)
            _CODIGO_CUENTAOld = Value
        End Set
    End Property 

    Private _NOMBRE_CUENTA As String
    <Column(Name:="Nombre cuenta", Storage:="NOMBRE_CUENTA", DbType:="VARCHAR(150) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 150)> _
    Public Property NOMBRE_CUENTA() As String
        Get
            Return _NOMBRE_CUENTA
        End Get
        Set(ByVal Value As String)
            _NOMBRE_CUENTA = Value
            OnPropertyChanged("NOMBRE_CUENTA")
        End Set
    End Property 

    Private _NOMBRE_CUENTAOld As String
    Public Property NOMBRE_CUENTAOld() As String
        Get
            Return _NOMBRE_CUENTAOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_CUENTAOld = Value
        End Set
    End Property 

    Private _DESCRIP_CUENTA As String
    <Column(Name:="Descrip cuenta", Storage:="DESCRIP_CUENTA", DbType:="VARCHAR(200)", Id:=False), _
     DataObjectField(False, False, True, 200)> _
    Public Property DESCRIP_CUENTA() As String
        Get
            Return _DESCRIP_CUENTA
        End Get
        Set(ByVal Value As String)
            _DESCRIP_CUENTA = Value
            OnPropertyChanged("DESCRIP_CUENTA")
        End Set
    End Property 

    Private _DESCRIP_CUENTAOld As String
    Public Property DESCRIP_CUENTAOld() As String
        Get
            Return _DESCRIP_CUENTAOld
        End Get
        Set(ByVal Value As String)
            _DESCRIP_CUENTAOld = Value
        End Set
    End Property 

    Private _TIPO_FTO As Int32
    <Column(Name:="Tipo fto", Storage:="TIPO_FTO", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property TIPO_FTO() As Int32
        Get
            Return _TIPO_FTO
        End Get
        Set(ByVal Value As Int32)
            _TIPO_FTO = Value
            OnPropertyChanged("TIPO_FTO")
        End Set
    End Property 

    Private _TIPO_FTOOld As Int32
    Public Property TIPO_FTOOld() As Int32
        Get
            Return _TIPO_FTOOld
        End Get
        Set(ByVal Value As Int32)
            _TIPO_FTOOld = Value
        End Set
    End Property 

    Private _APLICA_SOLIC_AGRICOLA As Boolean
    <Column(Name:="Aplica solic agricola", Storage:="APLICA_SOLIC_AGRICOLA", DbType:="BIT NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 1)> _
    Public Property APLICA_SOLIC_AGRICOLA() As Boolean
        Get
            Return _APLICA_SOLIC_AGRICOLA
        End Get
        Set(ByVal Value As Boolean)
            _APLICA_SOLIC_AGRICOLA = Value
            OnPropertyChanged("APLICA_SOLIC_AGRICOLA")
        End Set
    End Property 

    Private _APLICA_SOLIC_AGRICOLAOld As Boolean
    Public Property APLICA_SOLIC_AGRICOLAOld() As Boolean
        Get
            Return _APLICA_SOLIC_AGRICOLAOld
        End Get
        Set(ByVal Value As Boolean)
            _APLICA_SOLIC_AGRICOLAOld = Value
        End Set
    End Property 

    Private _APLICA_ANALIS_FTO As Boolean
    <Column(Name:="Aplica analis fto", Storage:="APLICA_ANALIS_FTO", DbType:="BIT NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 1)> _
    Public Property APLICA_ANALIS_FTO() As Boolean
        Get
            Return _APLICA_ANALIS_FTO
        End Get
        Set(ByVal Value As Boolean)
            _APLICA_ANALIS_FTO = Value
            OnPropertyChanged("APLICA_ANALIS_FTO")
        End Set
    End Property 

    Private _APLICA_ANALIS_FTOOld As Boolean
    Public Property APLICA_ANALIS_FTOOld() As Boolean
        Get
            Return _APLICA_ANALIS_FTOOld
        End Get
        Set(ByVal Value As Boolean)
            _APLICA_ANALIS_FTOOld = Value
        End Set
    End Property 

    Private _APLICA_FACTURACION As Boolean
    <Column(Name:="Aplica facturacion", Storage:="APLICA_FACTURACION", DbType:="BIT NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 1)> _
    Public Property APLICA_FACTURACION() As Boolean
        Get
            Return _APLICA_FACTURACION
        End Get
        Set(ByVal Value As Boolean)
            _APLICA_FACTURACION = Value
            OnPropertyChanged("APLICA_FACTURACION")
        End Set
    End Property 

    Private _APLICA_FACTURACIONOld As Boolean
    Public Property APLICA_FACTURACIONOld() As Boolean
        Get
            Return _APLICA_FACTURACIONOld
        End Get
        Set(ByVal Value As Boolean)
            _APLICA_FACTURACIONOld = Value
        End Set
    End Property 

    Private _APLICA_INTERES As Boolean
    <Column(Name:="Aplica interes", Storage:="APLICA_INTERES", DbType:="BIT NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 1)> _
    Public Property APLICA_INTERES() As Boolean
        Get
            Return _APLICA_INTERES
        End Get
        Set(ByVal Value As Boolean)
            _APLICA_INTERES = Value
            OnPropertyChanged("APLICA_INTERES")
        End Set
    End Property 

    Private _APLICA_INTERESOld As Boolean
    Public Property APLICA_INTERESOld() As Boolean
        Get
            Return _APLICA_INTERESOld
        End Get
        Set(ByVal Value As Boolean)
            _APLICA_INTERESOld = Value
        End Set
    End Property 

    Private _APLICA_EMISION_CHEQ As Boolean
    <Column(Name:="Aplica emision cheq", Storage:="APLICA_EMISION_CHEQ", DbType:="BIT NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 1)> _
    Public Property APLICA_EMISION_CHEQ() As Boolean
        Get
            Return _APLICA_EMISION_CHEQ
        End Get
        Set(ByVal Value As Boolean)
            _APLICA_EMISION_CHEQ = Value
            OnPropertyChanged("APLICA_EMISION_CHEQ")
        End Set
    End Property 

    Private _APLICA_EMISION_CHEQOld As Boolean
    Public Property APLICA_EMISION_CHEQOld() As Boolean
        Get
            Return _APLICA_EMISION_CHEQOld
        End Get
        Set(ByVal Value As Boolean)
            _APLICA_EMISION_CHEQOld = Value
        End Set
    End Property 

    Private _APLICA_DESCTO_PLA As Boolean
    <Column(Name:="Aplica descto pla", Storage:="APLICA_DESCTO_PLA", DbType:="BIT NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 1)> _
    Public Property APLICA_DESCTO_PLA() As Boolean
        Get
            Return _APLICA_DESCTO_PLA
        End Get
        Set(ByVal Value As Boolean)
            _APLICA_DESCTO_PLA = Value
            OnPropertyChanged("APLICA_DESCTO_PLA")
        End Set
    End Property 

    Private _APLICA_DESCTO_PLAOld As Boolean
    Public Property APLICA_DESCTO_PLAOld() As Boolean
        Get
            Return _APLICA_DESCTO_PLAOld
        End Get
        Set(ByVal Value As Boolean)
            _APLICA_DESCTO_PLAOld = Value
        End Set
    End Property 

    Private _PORC_SUBSIDIO As Decimal
    <Column(Name:="Porc subsidio", Storage:="PORC_SUBSIDIO", DbType:="NUMERIC(8,3) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=8, Scale:=3)> _
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
