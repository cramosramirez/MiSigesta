''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.CONTRATO_TRANS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row CONTRATO_TRANS en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	22/09/2017	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="CONTRATO_TRANS")> Public Class CONTRATO_TRANS
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_CONTRA_TRANS As Int32, aCOD_CONTRATO As String, aNO_CONTRATO As Int32, aID_ZAFRA As Int32, aFECINI As DateTime, aFECFIN As DateTime, aLUGAR_CORTE As String, aFECHA_CONTRA As DateTime, aCODTRANSPORT As Int32, aNOMBRE_TRANS As String, aNIT_TRANS As String, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime)
        Me._ID_CONTRA_TRANS = aID_CONTRA_TRANS
        Me._COD_CONTRATO = aCOD_CONTRATO
        Me._NO_CONTRATO = aNO_CONTRATO
        Me._ID_ZAFRA = aID_ZAFRA
        Me._FECINI = aFECINI
        Me._FECFIN = aFECFIN
        Me._LUGAR_CORTE = aLUGAR_CORTE
        Me._FECHA_CONTRA = aFECHA_CONTRA
        Me._CODTRANSPORT = aCODTRANSPORT
        Me._NOMBRE_TRANS = aNOMBRE_TRANS
        Me._NIT_TRANS = aNIT_TRANS
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
    End Sub

#Region " Properties "

    Private _ID_CONTRA_TRANS As Int32
    <Column(Name:="Id contra trans", Storage:="ID_CONTRA_TRANS", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_CONTRA_TRANS() As Int32
        Get
            Return _ID_CONTRA_TRANS
        End Get
        Set(ByVal Value As Int32)
            _ID_CONTRA_TRANS = Value
            OnPropertyChanged("ID_CONTRA_TRANS")
        End Set
    End Property 

    Private _COD_CONTRATO As String
    <Column(Name:="Cod contrato", Storage:="COD_CONTRATO", DbType:="VARCHAR(20)", Id:=False), _
     DataObjectField(False, False, True, 20)> _
    Public Property COD_CONTRATO() As String
        Get
            Return _COD_CONTRATO
        End Get
        Set(ByVal Value As String)
            _COD_CONTRATO = Value
            OnPropertyChanged("COD_CONTRATO")
        End Set
    End Property 

    Private _COD_CONTRATOOld As String
    Public Property COD_CONTRATOOld() As String
        Get
            Return _COD_CONTRATOOld
        End Get
        Set(ByVal Value As String)
            _COD_CONTRATOOld = Value
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

    Private _FECINI As DateTime
    <Column(Name:="Fecini", Storage:="FECINI", DbType:="DATETIME", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECINI() As DateTime
        Get
            Return _FECINI
        End Get
        Set(ByVal Value As DateTime)
            _FECINI = Value
            OnPropertyChanged("FECINI")
        End Set
    End Property 

    Private _FECINIOld As DateTime
    Public Property FECINIOld() As DateTime
        Get
            Return _FECINIOld
        End Get
        Set(ByVal Value As DateTime)
            _FECINIOld = Value
        End Set
    End Property 

    Private _FECFIN As DateTime
    <Column(Name:="Fecfin", Storage:="FECFIN", DbType:="DATETIME", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECFIN() As DateTime
        Get
            Return _FECFIN
        End Get
        Set(ByVal Value As DateTime)
            _FECFIN = Value
            OnPropertyChanged("FECFIN")
        End Set
    End Property 

    Private _FECFINOld As DateTime
    Public Property FECFINOld() As DateTime
        Get
            Return _FECFINOld
        End Get
        Set(ByVal Value As DateTime)
            _FECFINOld = Value
        End Set
    End Property 

    Private _LUGAR_CORTE As String
    <Column(Name:="Lugar corte", Storage:="LUGAR_CORTE", DbType:="VARCHAR(1000)", Id:=False), _
     DataObjectField(False, False, True, 1000)> _
    Public Property LUGAR_CORTE() As String
        Get
            Return _LUGAR_CORTE
        End Get
        Set(ByVal Value As String)
            _LUGAR_CORTE = Value
            OnPropertyChanged("LUGAR_CORTE")
        End Set
    End Property 

    Private _LUGAR_CORTEOld As String
    Public Property LUGAR_CORTEOld() As String
        Get
            Return _LUGAR_CORTEOld
        End Get
        Set(ByVal Value As String)
            _LUGAR_CORTEOld = Value
        End Set
    End Property 

    Private _FECHA_CONTRA As DateTime
    <Column(Name:="Fecha contra", Storage:="FECHA_CONTRA", DbType:="DATETIME", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_CONTRA() As DateTime
        Get
            Return _FECHA_CONTRA
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_CONTRA = Value
            OnPropertyChanged("FECHA_CONTRA")
        End Set
    End Property 

    Private _FECHA_CONTRAOld As DateTime
    Public Property FECHA_CONTRAOld() As DateTime
        Get
            Return _FECHA_CONTRAOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_CONTRAOld = Value
        End Set
    End Property 

    Private _CODTRANSPORT As Int32
    <Column(Name:="Codtransport", Storage:="CODTRANSPORT", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property CODTRANSPORT() As Int32
        Get
            Return _CODTRANSPORT
        End Get
        Set(ByVal Value As Int32)
            _CODTRANSPORT = Value
            OnPropertyChanged("CODTRANSPORT")
        End Set
    End Property 

    Private _CODTRANSPORTOld As Int32
    Public Property CODTRANSPORTOld() As Int32
        Get
            Return _CODTRANSPORTOld
        End Get
        Set(ByVal Value As Int32)
            _CODTRANSPORTOld = Value
        End Set
    End Property 

    Private _fkCODTRANSPORT As TRANSPORTISTA
    Public Property fkCODTRANSPORT() As TRANSPORTISTA
        Get
            Return _fkCODTRANSPORT
        End Get
        Set(ByVal Value As TRANSPORTISTA)
            _fkCODTRANSPORT = Value
        End Set
    End Property 

    Private _NOMBRE_TRANS As String
    <Column(Name:="Nombre trans", Storage:="NOMBRE_TRANS", DbType:="VARCHAR(200)", Id:=False), _
     DataObjectField(False, False, True, 200)> _
    Public Property NOMBRE_TRANS() As String
        Get
            Return _NOMBRE_TRANS
        End Get
        Set(ByVal Value As String)
            _NOMBRE_TRANS = Value
            OnPropertyChanged("NOMBRE_TRANS")
        End Set
    End Property 

    Private _NOMBRE_TRANSOld As String
    Public Property NOMBRE_TRANSOld() As String
        Get
            Return _NOMBRE_TRANSOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_TRANSOld = Value
        End Set
    End Property 

    Private _NIT_TRANS As String
    <Column(Name:="Nit trans", Storage:="NIT_TRANS", DbType:="VARCHAR(20)", Id:=False), _
     DataObjectField(False, False, True, 20)> _
    Public Property NIT_TRANS() As String
        Get
            Return _NIT_TRANS
        End Get
        Set(ByVal Value As String)
            _NIT_TRANS = Value
            OnPropertyChanged("NIT_TRANS")
        End Set
    End Property 

    Private _NIT_TRANSOld As String
    Public Property NIT_TRANSOld() As String
        Get
            Return _NIT_TRANSOld
        End Get
        Set(ByVal Value As String)
            _NIT_TRANSOld = Value
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

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
