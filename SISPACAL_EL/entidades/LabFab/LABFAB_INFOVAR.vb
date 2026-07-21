''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.LABFAB_INFOVAR
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row LABFAB_INFOVAR en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	28/11/2015	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="LABFAB_INFOVAR")> Public Class LABFAB_INFOVAR
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_INFOVAR As Int32, aID_INFO As Int32, aID_TIPOVAR As Int32, aID_CATEG As Int32, aORDEN As Int32, aNOMBRE_INFOVAR As String, aDESCRIP_VAR As String, aID_ANALISIS_REF As Int32, aID_INFOVAR_REF As Int32, aSQLREPO As String)
        Me._ID_INFOVAR = aID_INFOVAR
        Me._ID_INFO = aID_INFO
        Me._ID_TIPOVAR = aID_TIPOVAR
        Me._ID_CATEG = aID_CATEG
        Me._ORDEN = aORDEN
        Me._NOMBRE_INFOVAR = aNOMBRE_INFOVAR
        Me._DESCRIP_VAR = aDESCRIP_VAR
        Me._ID_ANALISIS_REF = aID_ANALISIS_REF
        Me._ID_INFOVAR_REF = aID_INFOVAR_REF
        Me._SQLREPO = aSQLREPO
    End Sub

#Region " Properties "

    Private _ID_INFOVAR As Int32
    <Column(Name:="Id infovar", Storage:="ID_INFOVAR", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_INFOVAR() As Int32
        Get
            Return _ID_INFOVAR
        End Get
        Set(ByVal Value As Int32)
            _ID_INFOVAR = Value
            OnPropertyChanged("ID_INFOVAR")
        End Set
    End Property 

    Private _ID_INFO As Int32
    <Column(Name:="Id info", Storage:="ID_INFO", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_INFO() As Int32
        Get
            Return _ID_INFO
        End Get
        Set(ByVal Value As Int32)
            _ID_INFO = Value
            OnPropertyChanged("ID_INFO")
        End Set
    End Property 

    Private _ID_INFOOld As Int32
    Public Property ID_INFOOld() As Int32
        Get
            Return _ID_INFOOld
        End Get
        Set(ByVal Value As Int32)
            _ID_INFOOld = Value
        End Set
    End Property 

    Private _fkID_INFO As LABFAB_INFORME
    Public Property fkID_INFO() As LABFAB_INFORME
        Get
            Return _fkID_INFO
        End Get
        Set(ByVal Value As LABFAB_INFORME)
            _fkID_INFO = Value
        End Set
    End Property 

    Private _ID_TIPOVAR As Int32
    <Column(Name:="Id tipovar", Storage:="ID_TIPOVAR", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_TIPOVAR() As Int32
        Get
            Return _ID_TIPOVAR
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPOVAR = Value
            OnPropertyChanged("ID_TIPOVAR")
        End Set
    End Property 

    Private _ID_TIPOVAROld As Int32
    Public Property ID_TIPOVAROld() As Int32
        Get
            Return _ID_TIPOVAROld
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPOVAROld = Value
        End Set
    End Property 

    Private _fkID_TIPOVAR As LABFAB_TIPOVAR
    Public Property fkID_TIPOVAR() As LABFAB_TIPOVAR
        Get
            Return _fkID_TIPOVAR
        End Get
        Set(ByVal Value As LABFAB_TIPOVAR)
            _fkID_TIPOVAR = Value
        End Set
    End Property 

    Private _ID_CATEG As Int32
    <Column(Name:="Id categ", Storage:="ID_CATEG", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_CATEG() As Int32
        Get
            Return _ID_CATEG
        End Get
        Set(ByVal Value As Int32)
            _ID_CATEG = Value
            OnPropertyChanged("ID_CATEG")
        End Set
    End Property 

    Private _ID_CATEGOld As Int32
    Public Property ID_CATEGOld() As Int32
        Get
            Return _ID_CATEGOld
        End Get
        Set(ByVal Value As Int32)
            _ID_CATEGOld = Value
        End Set
    End Property 

    Private _fkID_CATEG As LABFAB_CATEGORIA
    Public Property fkID_CATEG() As LABFAB_CATEGORIA
        Get
            Return _fkID_CATEG
        End Get
        Set(ByVal Value As LABFAB_CATEGORIA)
            _fkID_CATEG = Value
        End Set
    End Property 

    Private _ORDEN As Int32
    <Column(Name:="Orden", Storage:="ORDEN", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ORDEN() As Int32
        Get
            Return _ORDEN
        End Get
        Set(ByVal Value As Int32)
            _ORDEN = Value
            OnPropertyChanged("ORDEN")
        End Set
    End Property 

    Private _ORDENOld As Int32
    Public Property ORDENOld() As Int32
        Get
            Return _ORDENOld
        End Get
        Set(ByVal Value As Int32)
            _ORDENOld = Value
        End Set
    End Property 

    Private _NOMBRE_INFOVAR As String
    <Column(Name:="Nombre infovar", Storage:="NOMBRE_INFOVAR", DbType:="VARCHAR(200) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 200)> _
    Public Property NOMBRE_INFOVAR() As String
        Get
            Return _NOMBRE_INFOVAR
        End Get
        Set(ByVal Value As String)
            _NOMBRE_INFOVAR = Value
            OnPropertyChanged("NOMBRE_INFOVAR")
        End Set
    End Property 

    Private _NOMBRE_INFOVAROld As String
    Public Property NOMBRE_INFOVAROld() As String
        Get
            Return _NOMBRE_INFOVAROld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_INFOVAROld = Value
        End Set
    End Property 

    Private _DESCRIP_VAR As String
    <Column(Name:="Descrip var", Storage:="DESCRIP_VAR", DbType:="VARCHAR(200) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 200)> _
    Public Property DESCRIP_VAR() As String
        Get
            Return _DESCRIP_VAR
        End Get
        Set(ByVal Value As String)
            _DESCRIP_VAR = Value
            OnPropertyChanged("DESCRIP_VAR")
        End Set
    End Property 

    Private _DESCRIP_VAROld As String
    Public Property DESCRIP_VAROld() As String
        Get
            Return _DESCRIP_VAROld
        End Get
        Set(ByVal Value As String)
            _DESCRIP_VAROld = Value
        End Set
    End Property 

    Private _ID_ANALISIS_REF As Int32
    <Column(Name:="Id analisis ref", Storage:="ID_ANALISIS_REF", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_ANALISIS_REF() As Int32
        Get
            Return _ID_ANALISIS_REF
        End Get
        Set(ByVal Value As Int32)
            _ID_ANALISIS_REF = Value
            OnPropertyChanged("ID_ANALISIS_REF")
        End Set
    End Property 

    Private _ID_ANALISIS_REFOld As Int32
    Public Property ID_ANALISIS_REFOld() As Int32
        Get
            Return _ID_ANALISIS_REFOld
        End Get
        Set(ByVal Value As Int32)
            _ID_ANALISIS_REFOld = Value
        End Set
    End Property 

    Private _ID_INFOVAR_REF As Int32
    <Column(Name:="Id infovar ref", Storage:="ID_INFOVAR_REF", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_INFOVAR_REF() As Int32
        Get
            Return _ID_INFOVAR_REF
        End Get
        Set(ByVal Value As Int32)
            _ID_INFOVAR_REF = Value
            OnPropertyChanged("ID_INFOVAR_REF")
        End Set
    End Property 

    Private _ID_INFOVAR_REFOld As Int32
    Public Property ID_INFOVAR_REFOld() As Int32
        Get
            Return _ID_INFOVAR_REFOld
        End Get
        Set(ByVal Value As Int32)
            _ID_INFOVAR_REFOld = Value
        End Set
    End Property 

    Private _SQLREPO As String
    <Column(Name:="Sqlrepo", Storage:="SQLREPO", DbType:="VARCHAR(3000)", Id:=False), _
     DataObjectField(False, False, True, 3000)> _
    Public Property SQLREPO() As String
        Get
            Return _SQLREPO
        End Get
        Set(ByVal Value As String)
            _SQLREPO = Value
            OnPropertyChanged("SQLREPO")
        End Set
    End Property 

    Private _SQLREPOOld As String
    Public Property SQLREPOOld() As String
        Get
            Return _SQLREPOOld
        End Get
        Set(ByVal Value As String)
            _SQLREPOOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
