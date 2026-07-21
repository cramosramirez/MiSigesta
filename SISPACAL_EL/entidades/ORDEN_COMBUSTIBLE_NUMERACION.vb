''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.ORDEN_COMBUSTIBLE_NUMERACION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row ORDEN_COMBUSTIBLE_NUMERACION en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	05/12/2013	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="ORDEN_COMBUSTIBLE_NUMERACION")> Public Class ORDEN_COMBUSTIBLE_NUMERACION
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_ORDEN_COMBUSTIBLE_NUM As Int32, aID_ZAFRA As Int32, aSERIE_ORDEN_COMBUSTIBLE As String, aNO_INICIAL As Int32, aNO_FINAL As Int32, aULT_NUM_ASIGNADO As Int32, aES_INGENIO As Boolean, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime)
        Me._ID_ORDEN_COMBUSTIBLE_NUM = aID_ORDEN_COMBUSTIBLE_NUM
        Me._ID_ZAFRA = aID_ZAFRA
        Me._SERIE_ORDEN_COMBUSTIBLE = aSERIE_ORDEN_COMBUSTIBLE
        Me._NO_INICIAL = aNO_INICIAL
        Me._NO_FINAL = aNO_FINAL
        Me._ULT_NUM_ASIGNADO = aULT_NUM_ASIGNADO
        Me._ES_INGENIO = aES_INGENIO
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
    End Sub

#Region " Properties "

    Private _ID_ORDEN_COMBUSTIBLE_NUM As Int32
    <Column(Name:="Id orden combustible num", Storage:="ID_ORDEN_COMBUSTIBLE_NUM", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_ORDEN_COMBUSTIBLE_NUM() As Int32
        Get
            Return _ID_ORDEN_COMBUSTIBLE_NUM
        End Get
        Set(ByVal Value As Int32)
            _ID_ORDEN_COMBUSTIBLE_NUM = Value
            OnPropertyChanged("ID_ORDEN_COMBUSTIBLE_NUM")
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

    Private _SERIE_ORDEN_COMBUSTIBLE As String
    <Column(Name:="Serie orden combustible", Storage:="SERIE_ORDEN_COMBUSTIBLE", DbType:="VARCHAR(10) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 10)> _
    Public Property SERIE_ORDEN_COMBUSTIBLE() As String
        Get
            Return _SERIE_ORDEN_COMBUSTIBLE
        End Get
        Set(ByVal Value As String)
            _SERIE_ORDEN_COMBUSTIBLE = Value
            OnPropertyChanged("SERIE_ORDEN_COMBUSTIBLE")
        End Set
    End Property 

    Private _SERIE_ORDEN_COMBUSTIBLEOld As String
    Public Property SERIE_ORDEN_COMBUSTIBLEOld() As String
        Get
            Return _SERIE_ORDEN_COMBUSTIBLEOld
        End Get
        Set(ByVal Value As String)
            _SERIE_ORDEN_COMBUSTIBLEOld = Value
        End Set
    End Property 

    Private _NO_INICIAL As Int32
    <Column(Name:="No inicial", Storage:="NO_INICIAL", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property NO_INICIAL() As Int32
        Get
            Return _NO_INICIAL
        End Get
        Set(ByVal Value As Int32)
            _NO_INICIAL = Value
            OnPropertyChanged("NO_INICIAL")
        End Set
    End Property 

    Private _NO_INICIALOld As Int32
    Public Property NO_INICIALOld() As Int32
        Get
            Return _NO_INICIALOld
        End Get
        Set(ByVal Value As Int32)
            _NO_INICIALOld = Value
        End Set
    End Property 

    Private _NO_FINAL As Int32
    <Column(Name:="No final", Storage:="NO_FINAL", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property NO_FINAL() As Int32
        Get
            Return _NO_FINAL
        End Get
        Set(ByVal Value As Int32)
            _NO_FINAL = Value
            OnPropertyChanged("NO_FINAL")
        End Set
    End Property 

    Private _NO_FINALOld As Int32
    Public Property NO_FINALOld() As Int32
        Get
            Return _NO_FINALOld
        End Get
        Set(ByVal Value As Int32)
            _NO_FINALOld = Value
        End Set
    End Property 

    Private _ULT_NUM_ASIGNADO As Int32
    <Column(Name:="Ult num asignado", Storage:="ULT_NUM_ASIGNADO", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ULT_NUM_ASIGNADO() As Int32
        Get
            Return _ULT_NUM_ASIGNADO
        End Get
        Set(ByVal Value As Int32)
            _ULT_NUM_ASIGNADO = Value
            OnPropertyChanged("ULT_NUM_ASIGNADO")
        End Set
    End Property 

    Private _ULT_NUM_ASIGNADOOld As Int32
    Public Property ULT_NUM_ASIGNADOOld() As Int32
        Get
            Return _ULT_NUM_ASIGNADOOld
        End Get
        Set(ByVal Value As Int32)
            _ULT_NUM_ASIGNADOOld = Value
        End Set
    End Property 

    Private _ES_INGENIO As Boolean
    <Column(Name:="Es ingenio", Storage:="ES_INGENIO", DbType:="BIT NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 1)> _
    Public Property ES_INGENIO() As Boolean
        Get
            Return _ES_INGENIO
        End Get
        Set(ByVal Value As Boolean)
            _ES_INGENIO = Value
            OnPropertyChanged("ES_INGENIO")
        End Set
    End Property 

    Private _ES_INGENIOOld As Boolean
    Public Property ES_INGENIOOld() As Boolean
        Get
            Return _ES_INGENIOOld
        End Get
        Set(ByVal Value As Boolean)
            _ES_INGENIOOld = Value
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
