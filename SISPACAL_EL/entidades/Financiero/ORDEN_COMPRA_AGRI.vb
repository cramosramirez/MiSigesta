''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.ORDEN_COMPRA_AGRI
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row ORDEN_COMPRA_AGRI en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	12/07/2017	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="ORDEN_COMPRA_AGRI")> Public Class ORDEN_COMPRA_AGRI
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_ORDEN As Int32, aID_PROVEE As Int32, aNO_ORDEN As Int32, aCODI_ORDEN As String, aFECHA As DateTime, aID_SOLICITUD As Int32, aCODIPROVEEDOR As String, aCONDI_COMPRA As Int32, aSUB_TOTAL As Decimal, aIVA As Decimal, aTOTAL As Decimal, aCCF_NOMBRE As String, aLUGAR_ENTREGA As String, aCONTACTO As String, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aID_ZAFRA As Int32)
        Me._ID_ORDEN = aID_ORDEN
        Me._ID_PROVEE = aID_PROVEE
        Me._NO_ORDEN = aNO_ORDEN
        Me._CODI_ORDEN = aCODI_ORDEN
        Me._FECHA = aFECHA
        Me._ID_SOLICITUD = aID_SOLICITUD
        Me._CODIPROVEEDOR = aCODIPROVEEDOR
        Me._CONDI_COMPRA = aCONDI_COMPRA
        Me._SUB_TOTAL = aSUB_TOTAL
        Me._IVA = aIVA
        Me._TOTAL = aTOTAL
        Me._CCF_NOMBRE = aCCF_NOMBRE
        Me._LUGAR_ENTREGA = aLUGAR_ENTREGA
        Me._CONTACTO = aCONTACTO
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._ID_ZAFRA = aID_ZAFRA
    End Sub

#Region " Properties "

    Private _ID_ORDEN As Int32
    <Column(Name:="Id orden", Storage:="ID_ORDEN", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_ORDEN() As Int32
        Get
            Return _ID_ORDEN
        End Get
        Set(ByVal Value As Int32)
            _ID_ORDEN = Value
            OnPropertyChanged("ID_ORDEN")
        End Set
    End Property 

    Private _ID_PROVEE As Int32
    <Column(Name:="Id provee", Storage:="ID_PROVEE", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_PROVEE() As Int32
        Get
            Return _ID_PROVEE
        End Get
        Set(ByVal Value As Int32)
            _ID_PROVEE = Value
            OnPropertyChanged("ID_PROVEE")
        End Set
    End Property 

    Private _ID_PROVEEOld As Int32
    Public Property ID_PROVEEOld() As Int32
        Get
            Return _ID_PROVEEOld
        End Get
        Set(ByVal Value As Int32)
            _ID_PROVEEOld = Value
        End Set
    End Property 

    Private _fkID_PROVEE As PROVEEDOR_AGRICOLA
    Public Property fkID_PROVEE() As PROVEEDOR_AGRICOLA
        Get
            Return _fkID_PROVEE
        End Get
        Set(ByVal Value As PROVEEDOR_AGRICOLA)
            _fkID_PROVEE = Value
        End Set
    End Property 

    Private _NO_ORDEN As Int32
    <Column(Name:="No orden", Storage:="NO_ORDEN", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property NO_ORDEN() As Int32
        Get
            Return _NO_ORDEN
        End Get
        Set(ByVal Value As Int32)
            _NO_ORDEN = Value
            OnPropertyChanged("NO_ORDEN")
        End Set
    End Property 

    Private _NO_ORDENOld As Int32
    Public Property NO_ORDENOld() As Int32
        Get
            Return _NO_ORDENOld
        End Get
        Set(ByVal Value As Int32)
            _NO_ORDENOld = Value
        End Set
    End Property 

    Private _CODI_ORDEN As String
    <Column(Name:="Codi orden", Storage:="CODI_ORDEN", DbType:="VARCHAR(50) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 50)> _
    Public Property CODI_ORDEN() As String
        Get
            Return _CODI_ORDEN
        End Get
        Set(ByVal Value As String)
            _CODI_ORDEN = Value
            OnPropertyChanged("CODI_ORDEN")
        End Set
    End Property 

    Private _CODI_ORDENOld As String
    Public Property CODI_ORDENOld() As String
        Get
            Return _CODI_ORDENOld
        End Get
        Set(ByVal Value As String)
            _CODI_ORDENOld = Value
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

    Private _ID_SOLICITUD As Int32
    <Column(Name:="Id solicitud", Storage:="ID_SOLICITUD", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_SOLICITUD() As Int32
        Get
            Return _ID_SOLICITUD
        End Get
        Set(ByVal Value As Int32)
            _ID_SOLICITUD = Value
            OnPropertyChanged("ID_SOLICITUD")
        End Set
    End Property 

    Private _ID_SOLICITUDOld As Int32
    Public Property ID_SOLICITUDOld() As Int32
        Get
            Return _ID_SOLICITUDOld
        End Get
        Set(ByVal Value As Int32)
            _ID_SOLICITUDOld = Value
        End Set
    End Property 

    Private _fkID_SOLICITUD As SOLIC_AGRICOLA
    Public Property fkID_SOLICITUD() As SOLIC_AGRICOLA
        Get
            Return _fkID_SOLICITUD
        End Get
        Set(ByVal Value As SOLIC_AGRICOLA)
            _fkID_SOLICITUD = Value
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

    Private _CONDI_COMPRA As Int32
    <Column(Name:="Condi compra", Storage:="CONDI_COMPRA", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property CONDI_COMPRA() As Int32
        Get
            Return _CONDI_COMPRA
        End Get
        Set(ByVal Value As Int32)
            _CONDI_COMPRA = Value
            OnPropertyChanged("CONDI_COMPRA")
        End Set
    End Property 

    Private _CONDI_COMPRAOld As Int32
    Public Property CONDI_COMPRAOld() As Int32
        Get
            Return _CONDI_COMPRAOld
        End Get
        Set(ByVal Value As Int32)
            _CONDI_COMPRAOld = Value
        End Set
    End Property 

    Private _SUB_TOTAL As Decimal
    <Column(Name:="Sub total", Storage:="SUB_TOTAL", DbType:="NUMERIC(20,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)> _
    Public Property SUB_TOTAL() As Decimal
        Get
            Return _SUB_TOTAL
        End Get
        Set(ByVal Value As Decimal)
            _SUB_TOTAL = Value
            OnPropertyChanged("SUB_TOTAL")
        End Set
    End Property 

    Private _SUB_TOTALOld As Decimal
    Public Property SUB_TOTALOld() As Decimal
        Get
            Return _SUB_TOTALOld
        End Get
        Set(ByVal Value As Decimal)
            _SUB_TOTALOld = Value
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

    Private _CCF_NOMBRE As String
    <Column(Name:="Ccf nombre", Storage:="CCF_NOMBRE", DbType:="VARCHAR(100) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 100)> _
    Public Property CCF_NOMBRE() As String
        Get
            Return _CCF_NOMBRE
        End Get
        Set(ByVal Value As String)
            _CCF_NOMBRE = Value
            OnPropertyChanged("CCF_NOMBRE")
        End Set
    End Property 

    Private _CCF_NOMBREOld As String
    Public Property CCF_NOMBREOld() As String
        Get
            Return _CCF_NOMBREOld
        End Get
        Set(ByVal Value As String)
            _CCF_NOMBREOld = Value
        End Set
    End Property 

    Private _LUGAR_ENTREGA As String
    <Column(Name:="Lugar entrega", Storage:="LUGAR_ENTREGA", DbType:="VARCHAR(200) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 200)> _
    Public Property LUGAR_ENTREGA() As String
        Get
            Return _LUGAR_ENTREGA
        End Get
        Set(ByVal Value As String)
            _LUGAR_ENTREGA = Value
            OnPropertyChanged("LUGAR_ENTREGA")
        End Set
    End Property 

    Private _LUGAR_ENTREGAOld As String
    Public Property LUGAR_ENTREGAOld() As String
        Get
            Return _LUGAR_ENTREGAOld
        End Get
        Set(ByVal Value As String)
            _LUGAR_ENTREGAOld = Value
        End Set
    End Property 

    Private _CONTACTO As String
    <Column(Name:="Contacto", Storage:="CONTACTO", DbType:="VARCHAR(100) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 100)> _
    Public Property CONTACTO() As String
        Get
            Return _CONTACTO
        End Get
        Set(ByVal Value As String)
            _CONTACTO = Value
            OnPropertyChanged("CONTACTO")
        End Set
    End Property 

    Private _CONTACTOOld As String
    Public Property CONTACTOOld() As String
        Get
            Return _CONTACTOOld
        End Get
        Set(ByVal Value As String)
            _CONTACTOOld = Value
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

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
