''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.RECIBO_CANA_ANULADO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row RECIBO_CANA_ANULADO en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	07/11/2013	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="RECIBO_CANA_ANULADO")> Public Class RECIBO_CANA_ANULADO
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_RECIBO_CANA_ANUL As Int32, aNUMRECIBO_CANA As Int32, aFECHA_ANULACION As DateTime, aMOTIVO_ANULACION As String, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime, aID_ZAFRA As Int32, aID_ENVIO As Int32)
        Me._ID_RECIBO_CANA_ANUL = aID_RECIBO_CANA_ANUL
        Me._NUMRECIBO_CANA = aNUMRECIBO_CANA
        Me._FECHA_ANULACION = aFECHA_ANULACION
        Me._MOTIVO_ANULACION = aMOTIVO_ANULACION
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
        Me._ID_ZAFRA = aID_ZAFRA
        Me._ID_ENVIO = aID_ENVIO
    End Sub

#Region " Properties "

    Private _ID_RECIBO_CANA_ANUL As Int32
    <Column(Name:="Id recibo cana anul", Storage:="ID_RECIBO_CANA_ANUL", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_RECIBO_CANA_ANUL() As Int32
        Get
            Return _ID_RECIBO_CANA_ANUL
        End Get
        Set(ByVal Value As Int32)
            _ID_RECIBO_CANA_ANUL = Value
            OnPropertyChanged("ID_RECIBO_CANA_ANUL")
        End Set
    End Property 

    Private _NUMRECIBO_CANA As Int32
    <Column(Name:="Numrecibo cana", Storage:="NUMRECIBO_CANA", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property NUMRECIBO_CANA() As Int32
        Get
            Return _NUMRECIBO_CANA
        End Get
        Set(ByVal Value As Int32)
            _NUMRECIBO_CANA = Value
            OnPropertyChanged("NUMRECIBO_CANA")
        End Set
    End Property 

    Private _NUMRECIBO_CANAOld As Int32
    Public Property NUMRECIBO_CANAOld() As Int32
        Get
            Return _NUMRECIBO_CANAOld
        End Get
        Set(ByVal Value As Int32)
            _NUMRECIBO_CANAOld = Value
        End Set
    End Property 

    Private _FECHA_ANULACION As DateTime
    <Column(Name:="Fecha anulacion", Storage:="FECHA_ANULACION", DbType:="DATETIME", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_ANULACION() As DateTime
        Get
            Return _FECHA_ANULACION
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_ANULACION = Value
            OnPropertyChanged("FECHA_ANULACION")
        End Set
    End Property 

    Private _FECHA_ANULACIONOld As DateTime
    Public Property FECHA_ANULACIONOld() As DateTime
        Get
            Return _FECHA_ANULACIONOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_ANULACIONOld = Value
        End Set
    End Property 

    Private _MOTIVO_ANULACION As String
    <Column(Name:="Motivo anulacion", Storage:="MOTIVO_ANULACION", DbType:="VARCHAR(1000)", Id:=False), _
     DataObjectField(False, False, True, 1000)> _
    Public Property MOTIVO_ANULACION() As String
        Get
            Return _MOTIVO_ANULACION
        End Get
        Set(ByVal Value As String)
            _MOTIVO_ANULACION = Value
            OnPropertyChanged("MOTIVO_ANULACION")
        End Set
    End Property 

    Private _MOTIVO_ANULACIONOld As String
    Public Property MOTIVO_ANULACIONOld() As String
        Get
            Return _MOTIVO_ANULACIONOld
        End Get
        Set(ByVal Value As String)
            _MOTIVO_ANULACIONOld = Value
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

    Private _ID_ENVIO As Int32
    <Column(Name:="Id envio", Storage:="ID_ENVIO", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_ENVIO() As Int32
        Get
            Return _ID_ENVIO
        End Get
        Set(ByVal Value As Int32)
            _ID_ENVIO = Value
            OnPropertyChanged("ID_ENVIO")
        End Set
    End Property 

    Private _ID_ENVIOOld As Int32
    Public Property ID_ENVIOOld() As Int32
        Get
            Return _ID_ENVIOOld
        End Get
        Set(ByVal Value As Int32)
            _ID_ENVIOOld = Value
        End Set
    End Property 

    Private _fkID_ENVIO As ENVIO
    Public Property fkID_ENVIO() As ENVIO
        Get
            Return _fkID_ENVIO
        End Get
        Set(ByVal Value As ENVIO)
            _fkID_ENVIO = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
