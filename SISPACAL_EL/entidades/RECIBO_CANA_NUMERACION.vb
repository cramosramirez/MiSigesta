''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.RECIBO_CANA_NUMERACION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row RECIBO_CANA_NUMERACION en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	04/11/2013	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="RECIBO_CANA_NUMERACION")> Public Class RECIBO_CANA_NUMERACION
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_RECIBO_CANA_NUM As Int32, aNUM_INICIAL As Int32, aNUM_FINAL As Int32, aULT_NUM_ASIGNADO As Int32, aACTIVO As Boolean, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime)
        Me._ID_RECIBO_CANA_NUM = aID_RECIBO_CANA_NUM
        Me._NUM_INICIAL = aNUM_INICIAL
        Me._NUM_FINAL = aNUM_FINAL
        Me._ULT_NUM_ASIGNADO = aULT_NUM_ASIGNADO
        Me._ACTIVO = aACTIVO
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
    End Sub

#Region " Properties "

    Private _ID_RECIBO_CANA_NUM As Int32
    <Column(Name:="Id recibo cana num", Storage:="ID_RECIBO_CANA_NUM", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_RECIBO_CANA_NUM() As Int32
        Get
            Return _ID_RECIBO_CANA_NUM
        End Get
        Set(ByVal Value As Int32)
            _ID_RECIBO_CANA_NUM = Value
            OnPropertyChanged("ID_RECIBO_CANA_NUM")
        End Set
    End Property 

    Private _NUM_INICIAL As Int32
    <Column(Name:="Num inicial", Storage:="NUM_INICIAL", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property NUM_INICIAL() As Int32
        Get
            Return _NUM_INICIAL
        End Get
        Set(ByVal Value As Int32)
            _NUM_INICIAL = Value
            OnPropertyChanged("NUM_INICIAL")
        End Set
    End Property 

    Private _NUM_INICIALOld As Int32
    Public Property NUM_INICIALOld() As Int32
        Get
            Return _NUM_INICIALOld
        End Get
        Set(ByVal Value As Int32)
            _NUM_INICIALOld = Value
        End Set
    End Property 

    Private _NUM_FINAL As Int32
    <Column(Name:="Num final", Storage:="NUM_FINAL", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property NUM_FINAL() As Int32
        Get
            Return _NUM_FINAL
        End Get
        Set(ByVal Value As Int32)
            _NUM_FINAL = Value
            OnPropertyChanged("NUM_FINAL")
        End Set
    End Property 

    Private _NUM_FINALOld As Int32
    Public Property NUM_FINALOld() As Int32
        Get
            Return _NUM_FINALOld
        End Get
        Set(ByVal Value As Int32)
            _NUM_FINALOld = Value
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
