''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.CAPACIDAD_TIPO_TRANS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row CAPACIDAD_TIPO_TRANS en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	08/12/2015	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="CAPACIDAD_TIPO_TRANS")> Public Class CAPACIDAD_TIPO_TRANS
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_CAPACIDAD As Int32, aID_TIPO_CANA As Int32, aID_TIPO_TRANS As Int32, aCAPACIDAD_TC As Decimal)
        Me._ID_CAPACIDAD = aID_CAPACIDAD
        Me._ID_TIPO_CANA = aID_TIPO_CANA
        Me._ID_TIPO_TRANS = aID_TIPO_TRANS
        Me._CAPACIDAD_TC = aCAPACIDAD_TC
    End Sub

#Region " Properties "

    Private _ID_CAPACIDAD As Int32
    <Column(Name:="Id capacidad", Storage:="ID_CAPACIDAD", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_CAPACIDAD() As Int32
        Get
            Return _ID_CAPACIDAD
        End Get
        Set(ByVal Value As Int32)
            _ID_CAPACIDAD = Value
            OnPropertyChanged("ID_CAPACIDAD")
        End Set
    End Property 

    Private _ID_TIPO_CANA As Int32
    <Column(Name:="Id tipo cana", Storage:="ID_TIPO_CANA", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_TIPO_CANA() As Int32
        Get
            Return _ID_TIPO_CANA
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_CANA = Value
            OnPropertyChanged("ID_TIPO_CANA")
        End Set
    End Property 

    Private _ID_TIPO_CANAOld As Int32
    Public Property ID_TIPO_CANAOld() As Int32
        Get
            Return _ID_TIPO_CANAOld
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_CANAOld = Value
        End Set
    End Property 

    Private _fkID_TIPO_CANA As TIPOS_GENERALES
    Public Property fkID_TIPO_CANA() As TIPOS_GENERALES
        Get
            Return _fkID_TIPO_CANA
        End Get
        Set(ByVal Value As TIPOS_GENERALES)
            _fkID_TIPO_CANA = Value
        End Set
    End Property 

    Private _ID_TIPO_TRANS As Int32
    <Column(Name:="Id tipo trans", Storage:="ID_TIPO_TRANS", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_TIPO_TRANS() As Int32
        Get
            Return _ID_TIPO_TRANS
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_TRANS = Value
            OnPropertyChanged("ID_TIPO_TRANS")
        End Set
    End Property 

    Private _ID_TIPO_TRANSOld As Int32
    Public Property ID_TIPO_TRANSOld() As Int32
        Get
            Return _ID_TIPO_TRANSOld
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_TRANSOld = Value
        End Set
    End Property 

    Private _fkID_TIPO_TRANS As TIPOS_GENERALES
    Public Property fkID_TIPO_TRANS() As TIPOS_GENERALES
        Get
            Return _fkID_TIPO_TRANS
        End Get
        Set(ByVal Value As TIPOS_GENERALES)
            _fkID_TIPO_TRANS = Value
        End Set
    End Property 

    Private _CAPACIDAD_TC As Decimal
    <Column(Name:="Capacidad tc", Storage:="CAPACIDAD_TC", DbType:="NUMERIC(8,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=8, Scale:=2)> _
    Public Property CAPACIDAD_TC() As Decimal
        Get
            Return _CAPACIDAD_TC
        End Get
        Set(ByVal Value As Decimal)
            _CAPACIDAD_TC = Value
            OnPropertyChanged("CAPACIDAD_TC")
        End Set
    End Property 

    Private _CAPACIDAD_TCOld As Decimal
    Public Property CAPACIDAD_TCOld() As Decimal
        Get
            Return _CAPACIDAD_TCOld
        End Get
        Set(ByVal Value As Decimal)
            _CAPACIDAD_TCOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
