''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.MEMBRE_GREMIAL
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row MEMBRE_GREMIAL en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	31/05/2017	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="MEMBRE_GREMIAL")> Public Class MEMBRE_GREMIAL
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_MEMBRE_GREMIAL As Int32, aCODIPROVEEDOR As String, aNUM_MEMBRE_GREMIAL As Int32, aFECHA As DateTime, aID_GREMIAL As Int32, aMONTO_X_TC As Decimal, aUID_MEMBRE_CONTRATO As Guid, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime, aID_ZAFRA As Int32, aZAFRA As String, aACTIVO As Boolean)
        Me._ID_MEMBRE_GREMIAL = aID_MEMBRE_GREMIAL
        Me._CODIPROVEEDOR = aCODIPROVEEDOR
        Me._NUM_MEMBRE_GREMIAL = aNUM_MEMBRE_GREMIAL
        Me._FECHA = aFECHA
        Me._ID_GREMIAL = aID_GREMIAL
        Me._MONTO_X_TC = aMONTO_X_TC
        Me._UID_MEMBRE_CONTRATO = aUID_MEMBRE_CONTRATO
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
        Me._ID_ZAFRA = aID_ZAFRA
        Me._ZAFRA = aZAFRA
        Me._ACTIVO = aACTIVO
    End Sub

#Region " Properties "

    Private _ID_MEMBRE_GREMIAL As Int32
    <Column(Name:="Id membre gremial", Storage:="ID_MEMBRE_GREMIAL", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_MEMBRE_GREMIAL() As Int32
        Get
            Return _ID_MEMBRE_GREMIAL
        End Get
        Set(ByVal Value As Int32)
            _ID_MEMBRE_GREMIAL = Value
            OnPropertyChanged("ID_MEMBRE_GREMIAL")
        End Set
    End Property 

    Private _CODIPROVEEDOR As String
    <Column(Name:="Codiproveedor", Storage:="CODIPROVEEDOR", DbType:="CHAR(10) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 10)> _
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

    Private _NUM_MEMBRE_GREMIAL As Int32
    <Column(Name:="Num membre gremial", Storage:="NUM_MEMBRE_GREMIAL", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property NUM_MEMBRE_GREMIAL() As Int32
        Get
            Return _NUM_MEMBRE_GREMIAL
        End Get
        Set(ByVal Value As Int32)
            _NUM_MEMBRE_GREMIAL = Value
            OnPropertyChanged("NUM_MEMBRE_GREMIAL")
        End Set
    End Property 

    Private _NUM_MEMBRE_GREMIALOld As Int32
    Public Property NUM_MEMBRE_GREMIALOld() As Int32
        Get
            Return _NUM_MEMBRE_GREMIALOld
        End Get
        Set(ByVal Value As Int32)
            _NUM_MEMBRE_GREMIALOld = Value
        End Set
    End Property 

    Private _FECHA As DateTime
    <Column(Name:="Fecha", Storage:="FECHA", DbType:="DATETIME NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
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

    Private _ID_GREMIAL As Int32
    <Column(Name:="Id gremial", Storage:="ID_GREMIAL", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_GREMIAL() As Int32
        Get
            Return _ID_GREMIAL
        End Get
        Set(ByVal Value As Int32)
            _ID_GREMIAL = Value
            OnPropertyChanged("ID_GREMIAL")
        End Set
    End Property 

    Private _ID_GREMIALOld As Int32
    Public Property ID_GREMIALOld() As Int32
        Get
            Return _ID_GREMIALOld
        End Get
        Set(ByVal Value As Int32)
            _ID_GREMIALOld = Value
        End Set
    End Property 

    Private _MONTO_X_TC As Decimal
    <Column(Name:="Monto x tc", Storage:="MONTO_X_TC", DbType:="NUMERIC(20,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)> _
    Public Property MONTO_X_TC() As Decimal
        Get
            Return _MONTO_X_TC
        End Get
        Set(ByVal Value As Decimal)
            _MONTO_X_TC = Value
            OnPropertyChanged("MONTO_X_TC")
        End Set
    End Property 

    Private _MONTO_X_TCOld As Decimal
    Public Property MONTO_X_TCOld() As Decimal
        Get
            Return _MONTO_X_TCOld
        End Get
        Set(ByVal Value As Decimal)
            _MONTO_X_TCOld = Value
        End Set
    End Property 

    Private _UID_MEMBRE_CONTRATO As Guid
    <Column(Name:="Uid membre contrato", Storage:="UID_MEMBRE_CONTRATO", DbType:="UNIQUEIDENTIFIER(36, 0)", Id:=False), _
     DataObjectField(False, False, True, 16)> _
    Public Property UID_MEMBRE_CONTRATO() As Guid
        Get
            Return _UID_MEMBRE_CONTRATO
        End Get
        Set(ByVal Value As Guid)
            _UID_MEMBRE_CONTRATO = Value
            OnPropertyChanged("UID_MEMBRE_CONTRATO")
        End Set
    End Property 

    Private _UID_MEMBRE_CONTRATOOld As Guid
    Public Property UID_MEMBRE_CONTRATOOld() As Guid
        Get
            Return _UID_MEMBRE_CONTRATOOld
        End Get
        Set(ByVal Value As Guid)
            _UID_MEMBRE_CONTRATOOld = Value
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

    Private _ID_ZAFRA As Int32
    <Column(Name:="Id zafra", Storage:="ID_ZAFRA", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
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

    Private _ACTIVO As Boolean
    <Column(Name:="Activo", Storage:="ACTIVO", DbType:="BIT", Id:=False), _
     DataObjectField(False, False, True, 1)> _
    Public Property ACTIVO() As Boolean
        Get
            Return _ACTIVO
        End Get
        Set(ByVal Value As Boolean)
            _ACTIVO = Value
            OnPropertyChanged("ACTIVO")
        End Set
    End Property 

    Private _ACTIVOOld As Boolean
    Public Property ACTIVOOld() As Boolean
        Get
            Return _ACTIVOOld
        End Get
        Set(ByVal Value As Boolean)
            _ACTIVOOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
