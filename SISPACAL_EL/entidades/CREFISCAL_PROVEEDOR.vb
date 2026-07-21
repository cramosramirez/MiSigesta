''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.CREFISCAL_PROVEEDOR
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row CREFISCAL_PROVEEDOR en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/11/2023	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="CREFISCAL_PROVEEDOR")> Public Class CREFISCAL_PROVEEDOR
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_CCF As Int32, aID_COMPROB_ENCA As Int32, aID_TIPO_COMPROB As Int32, aFECHA As DateTime, aNUMERO As String, aSERIE As String, aCODI_GENERACION As String, aSELLO_RECEPCION As String, aUSUARIO_CREA As String, aFECHA_CREA As DateTime)
        Me._ID_CCF = aID_CCF
        Me._ID_COMPROB_ENCA = aID_COMPROB_ENCA
        Me._ID_TIPO_COMPROB = aID_TIPO_COMPROB
        Me._FECHA = aFECHA
        Me._NUMERO = aNUMERO
        Me._SERIE = aSERIE
        Me._CODI_GENERACION = aCODI_GENERACION
        Me._SELLO_RECEPCION = aSELLO_RECEPCION
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
    End Sub

#Region " Properties "

    Private _ID_CCF As Int32
    <Column(Name:="Id ccf", Storage:="ID_CCF", DBType:="INT NOT NULL", Id:=True),
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)>
    Public Property ID_CCF() As Int32
        Get
            Return _ID_CCF
        End Get
        Set(ByVal Value As Int32)
            _ID_CCF = Value
            OnPropertyChanged("ID_CCF")
        End Set
    End Property 

    Private _ID_COMPROB_ENCA As Int32
    <Column(Name:="Id comprob enca", Storage:="ID_COMPROB_ENCA", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_COMPROB_ENCA() As Int32
        Get
            Return _ID_COMPROB_ENCA
        End Get
        Set(ByVal Value As Int32)
            _ID_COMPROB_ENCA = Value
            OnPropertyChanged("ID_COMPROB_ENCA")
        End Set
    End Property 

    Private _ID_COMPROB_ENCAOld As Int32
    Public Property ID_COMPROB_ENCAOld() As Int32
        Get
            Return _ID_COMPROB_ENCAOld
        End Get
        Set(ByVal Value As Int32)
            _ID_COMPROB_ENCAOld = Value
        End Set
    End Property 

    Private _fkID_COMPROB_ENCA As COMPROB_ENCA
    Public Property fkID_COMPROB_ENCA() As COMPROB_ENCA
        Get
            Return _fkID_COMPROB_ENCA
        End Get
        Set(ByVal Value As COMPROB_ENCA)
            _fkID_COMPROB_ENCA = Value
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

    Private _NUMERO As String
    <Column(Name:="Numero", Storage:="NUMERO", DbType:="VARCHAR(31)", Id:=False), _
     DataObjectField(False, False, True, 31)> _
    Public Property NUMERO() As String
        Get
            Return _NUMERO
        End Get
        Set(ByVal Value As String)
            _NUMERO = Value
            OnPropertyChanged("NUMERO")
        End Set
    End Property 

    Private _NUMEROOld As String
    Public Property NUMEROOld() As String
        Get
            Return _NUMEROOld
        End Get
        Set(ByVal Value As String)
            _NUMEROOld = Value
        End Set
    End Property 

    Private _SERIE As String
    <Column(Name:="Serie", Storage:="SERIE", DBType:="VARCHAR(20) NULL", Id:=False),
     DataObjectField(False, False, True, 20)>
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

    Private _CODI_GENERACION As String
    <Column(Name:="Codi generacion", Storage:="CODI_GENERACION", DBType:="VARCHAR(40) NULL", Id:=False),
     DataObjectField(False, False, True, 40)>
    Public Property CODI_GENERACION() As String
        Get
            Return _CODI_GENERACION
        End Get
        Set(ByVal Value As String)
            _CODI_GENERACION = Value
            OnPropertyChanged("CODI_GENERACION")
        End Set
    End Property 

    Private _CODI_GENERACIONOld As String
    Public Property CODI_GENERACIONOld() As String
        Get
            Return _CODI_GENERACIONOld
        End Get
        Set(ByVal Value As String)
            _CODI_GENERACIONOld = Value
        End Set
    End Property 

    Private _SELLO_RECEPCION As String
    <Column(Name:="Sello recepcion", Storage:="SELLO_RECEPCION", DBType:="VARCHAR(40) NULL", Id:=False),
     DataObjectField(False, False, True, 40)>
    Public Property SELLO_RECEPCION() As String
        Get
            Return _SELLO_RECEPCION
        End Get
        Set(ByVal Value As String)
            _SELLO_RECEPCION = Value
            OnPropertyChanged("SELLO_RECEPCION")
        End Set
    End Property 

    Private _SELLO_RECEPCIONOld As String
    Public Property SELLO_RECEPCIONOld() As String
        Get
            Return _SELLO_RECEPCIONOld
        End Get
        Set(ByVal Value As String)
            _SELLO_RECEPCIONOld = Value
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

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
