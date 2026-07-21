''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.LABFAB_DIAZAFRA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row LABFAB_DIAZAFRA en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	17/11/2015	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="LABFAB_DIAZAFRA")> Public Class LABFAB_DIAZAFRA
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_DIAZAFRA As Int32, aDIAZAFRA As Int32, aID_ZAFRA As Int32, aCIERRE_LABFAB As DateTime, aACTIVO As Boolean)
        Me._ID_DIAZAFRA = aID_DIAZAFRA
        Me._DIAZAFRA = aDIAZAFRA
        Me._ID_ZAFRA = aID_ZAFRA
        Me._CIERRE_LABFAB = aCIERRE_LABFAB
        Me._ACTIVO = aACTIVO
    End Sub

#Region " Properties "

    Private _ID_DIAZAFRA As Int32
    <Column(Name:="Id diazafra", Storage:="ID_DIAZAFRA", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_DIAZAFRA() As Int32
        Get
            Return _ID_DIAZAFRA
        End Get
        Set(ByVal Value As Int32)
            _ID_DIAZAFRA = Value
            OnPropertyChanged("ID_DIAZAFRA")
        End Set
    End Property 

    Private _DIAZAFRA As Int32
    <Column(Name:="Diazafra", Storage:="DIAZAFRA", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property DIAZAFRA() As Int32
        Get
            Return _DIAZAFRA
        End Get
        Set(ByVal Value As Int32)
            _DIAZAFRA = Value
            OnPropertyChanged("DIAZAFRA")
        End Set
    End Property 

    Private _DIAZAFRAOld As Int32
    Public Property DIAZAFRAOld() As Int32
        Get
            Return _DIAZAFRAOld
        End Get
        Set(ByVal Value As Int32)
            _DIAZAFRAOld = Value
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

    Private _CIERRE_LABFAB As DateTime
    <Column(Name:="Cierre labfab", Storage:="CIERRE_LABFAB", DbType:="DATETIME NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
    Public Property CIERRE_LABFAB() As DateTime
        Get
            Return _CIERRE_LABFAB
        End Get
        Set(ByVal Value As DateTime)
            _CIERRE_LABFAB = Value
            OnPropertyChanged("CIERRE_LABFAB")
        End Set
    End Property 

    Private _CIERRE_LABFABOld As DateTime
    Public Property CIERRE_LABFABOld() As DateTime
        Get
            Return _CIERRE_LABFABOld
        End Get
        Set(ByVal Value As DateTime)
            _CIERRE_LABFABOld = Value
        End Set
    End Property 

    Private _ACTIVO As Boolean
    <Column(Name:="Activo", Storage:="ACTIVO", DbType:="BIT NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 1)> _
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
