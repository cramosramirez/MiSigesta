''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.REMESA_ENCA_PRODU
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row REMESA_ENCA_PRODU en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	11/09/2017	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="REMESA_ENCA_PRODU")> Public Class REMESA_ENCA_PRODU
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_REMESA_ENCA As Int32, aCODIPROVEEDOR As String, aCODIBANCO As Int32, aFECHA_REMESA As DateTime, aUID_REMESA_ENCA As Guid, aNO_REMESA As String, aOBSERVACION As String, aABONO_CAPITAL As Decimal, aABONO_INTERES As Decimal, aABONO_INTERES_IVA As Decimal, aTOTAL As Decimal, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime)
        Me._ID_REMESA_ENCA = aID_REMESA_ENCA
        Me._CODIPROVEEDOR = aCODIPROVEEDOR
        Me._CODIBANCO = aCODIBANCO
        Me._FECHA_REMESA = aFECHA_REMESA
        Me._UID_REMESA_ENCA = aUID_REMESA_ENCA
        Me._NO_REMESA = aNO_REMESA
        Me._OBSERVACION = aOBSERVACION
        Me._ABONO_CAPITAL = aABONO_CAPITAL
        Me._ABONO_INTERES = aABONO_INTERES
        Me._ABONO_INTERES_IVA = aABONO_INTERES_IVA
        Me._TOTAL = aTOTAL
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
    End Sub

#Region " Properties "

    Private _ID_REMESA_ENCA As Int32
    <Column(Name:="Id remesa enca", Storage:="ID_REMESA_ENCA", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_REMESA_ENCA() As Int32
        Get
            Return _ID_REMESA_ENCA
        End Get
        Set(ByVal Value As Int32)
            _ID_REMESA_ENCA = Value
            OnPropertyChanged("ID_REMESA_ENCA")
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

    Private _CODIBANCO As Int32
    <Column(Name:="Codibanco", Storage:="CODIBANCO", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property CODIBANCO() As Int32
        Get
            Return _CODIBANCO
        End Get
        Set(ByVal Value As Int32)
            _CODIBANCO = Value
            OnPropertyChanged("CODIBANCO")
        End Set
    End Property 

    Private _CODIBANCOOld As Int32
    Public Property CODIBANCOOld() As Int32
        Get
            Return _CODIBANCOOld
        End Get
        Set(ByVal Value As Int32)
            _CODIBANCOOld = Value
        End Set
    End Property 

    Private _fkCODIBANCO As BANCOS
    Public Property fkCODIBANCO() As BANCOS
        Get
            Return _fkCODIBANCO
        End Get
        Set(ByVal Value As BANCOS)
            _fkCODIBANCO = Value
        End Set
    End Property 

    Private _FECHA_REMESA As DateTime
    <Column(Name:="Fecha remesa", Storage:="FECHA_REMESA", DbType:="DATETIME NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
    Public Property FECHA_REMESA() As DateTime
        Get
            Return _FECHA_REMESA
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_REMESA = Value
            OnPropertyChanged("FECHA_REMESA")
        End Set
    End Property 

    Private _FECHA_REMESAOld As DateTime
    Public Property FECHA_REMESAOld() As DateTime
        Get
            Return _FECHA_REMESAOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_REMESAOld = Value
        End Set
    End Property 

    Private _UID_REMESA_ENCA As Guid
    <Column(Name:="Uid remesa enca", Storage:="UID_REMESA_ENCA", DbType:="UNIQUEIDENTIFIER(36, 0) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 16)> _
    Public Property UID_REMESA_ENCA() As Guid
        Get
            Return _UID_REMESA_ENCA
        End Get
        Set(ByVal Value As Guid)
            _UID_REMESA_ENCA = Value
            OnPropertyChanged("UID_REMESA_ENCA")
        End Set
    End Property 

    Private _UID_REMESA_ENCAOld As Guid
    Public Property UID_REMESA_ENCAOld() As Guid
        Get
            Return _UID_REMESA_ENCAOld
        End Get
        Set(ByVal Value As Guid)
            _UID_REMESA_ENCAOld = Value
        End Set
    End Property 

    Private _NO_REMESA As String
    <Column(Name:="No remesa", Storage:="NO_REMESA", DbType:="VARCHAR(150) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 150)> _
    Public Property NO_REMESA() As String
        Get
            Return _NO_REMESA
        End Get
        Set(ByVal Value As String)
            _NO_REMESA = Value
            OnPropertyChanged("NO_REMESA")
        End Set
    End Property 

    Private _NO_REMESAOld As String
    Public Property NO_REMESAOld() As String
        Get
            Return _NO_REMESAOld
        End Get
        Set(ByVal Value As String)
            _NO_REMESAOld = Value
        End Set
    End Property 

    Private _OBSERVACION As String
    <Column(Name:="Observacion", Storage:="OBSERVACION", DbType:="VARCHAR(300) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 300)> _
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

    Private _ABONO_CAPITAL As Decimal
    <Column(Name:="Abono capital", Storage:="ABONO_CAPITAL", DbType:="NUMERIC(20,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)> _
    Public Property ABONO_CAPITAL() As Decimal
        Get
            Return _ABONO_CAPITAL
        End Get
        Set(ByVal Value As Decimal)
            _ABONO_CAPITAL = Value
            OnPropertyChanged("ABONO_CAPITAL")
        End Set
    End Property 

    Private _ABONO_CAPITALOld As Decimal
    Public Property ABONO_CAPITALOld() As Decimal
        Get
            Return _ABONO_CAPITALOld
        End Get
        Set(ByVal Value As Decimal)
            _ABONO_CAPITALOld = Value
        End Set
    End Property 

    Private _ABONO_INTERES As Decimal
    <Column(Name:="Abono interes", Storage:="ABONO_INTERES", DbType:="NUMERIC(20,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)> _
    Public Property ABONO_INTERES() As Decimal
        Get
            Return _ABONO_INTERES
        End Get
        Set(ByVal Value As Decimal)
            _ABONO_INTERES = Value
            OnPropertyChanged("ABONO_INTERES")
        End Set
    End Property 

    Private _ABONO_INTERESOld As Decimal
    Public Property ABONO_INTERESOld() As Decimal
        Get
            Return _ABONO_INTERESOld
        End Get
        Set(ByVal Value As Decimal)
            _ABONO_INTERESOld = Value
        End Set
    End Property 

    Private _ABONO_INTERES_IVA As Decimal
    <Column(Name:="Abono interes iva", Storage:="ABONO_INTERES_IVA", DbType:="NUMERIC(20,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)> _
    Public Property ABONO_INTERES_IVA() As Decimal
        Get
            Return _ABONO_INTERES_IVA
        End Get
        Set(ByVal Value As Decimal)
            _ABONO_INTERES_IVA = Value
            OnPropertyChanged("ABONO_INTERES_IVA")
        End Set
    End Property 

    Private _ABONO_INTERES_IVAOld As Decimal
    Public Property ABONO_INTERES_IVAOld() As Decimal
        Get
            Return _ABONO_INTERES_IVAOld
        End Get
        Set(ByVal Value As Decimal)
            _ABONO_INTERES_IVAOld = Value
        End Set
    End Property 

    Private _TOTAL As Decimal
    <Column(Name:="Total", Storage:="TOTAL", DbType:="NUMERIC(20,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)> _
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
