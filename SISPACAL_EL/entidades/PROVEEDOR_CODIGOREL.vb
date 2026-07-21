''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.PROVEEDOR_CODIGOREL
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row PROVEEDOR_CODIGOREL en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	26/05/2015	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="PROVEEDOR_CODIGOREL")> Public Class PROVEEDOR_CODIGOREL
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_PROVEE_CODIGOREL As Int32, aCODIPROVEEDOR As String, aCODIPROVEEDOR_REL As String, aUSUARIO_ACT As String, aFECHA_ACT As DateTime)
        Me._ID_PROVEE_CODIGOREL = aID_PROVEE_CODIGOREL
        Me._CODIPROVEEDOR = aCODIPROVEEDOR
        Me._CODIPROVEEDOR_REL = aCODIPROVEEDOR_REL
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
    End Sub

#Region " Properties "

    Private _ID_PROVEE_CODIGOREL As Int32
    <Column(Name:="Id provee codigorel", Storage:="ID_PROVEE_CODIGOREL", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_PROVEE_CODIGOREL() As Int32
        Get
            Return _ID_PROVEE_CODIGOREL
        End Get
        Set(ByVal Value As Int32)
            _ID_PROVEE_CODIGOREL = Value
            OnPropertyChanged("ID_PROVEE_CODIGOREL")
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

    Private _CODIPROVEEDOR_REL As String
    <Column(Name:="Codiproveedor rel", Storage:="CODIPROVEEDOR_REL", DbType:="CHAR(10)", Id:=False), _
     DataObjectField(False, False, True, 10)> _
    Public Property CODIPROVEEDOR_REL() As String
        Get
            Return _CODIPROVEEDOR_REL
        End Get
        Set(ByVal Value As String)
            _CODIPROVEEDOR_REL = Value
            OnPropertyChanged("CODIPROVEEDOR_REL")
        End Set
    End Property 

    Private _CODIPROVEEDOR_RELOld As String
    Public Property CODIPROVEEDOR_RELOld() As String
        Get
            Return _CODIPROVEEDOR_RELOld
        End Get
        Set(ByVal Value As String)
            _CODIPROVEEDOR_RELOld = Value
        End Set
    End Property 

    Private _fkCODIPROVEEDOR_REL As PROVEEDOR
    Public Property fkCODIPROVEEDOR_REL() As PROVEEDOR
        Get
            Return _fkCODIPROVEEDOR_REL
        End Get
        Set(ByVal Value As PROVEEDOR)
            _fkCODIPROVEEDOR_REL = Value
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
