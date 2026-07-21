''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.CHEQUE_PLANILLA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row CHEQUE_PLANILLA en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	10/01/2014	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="CHEQUE_PLANILLA")> Public Class CHEQUE_PLANILLA
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_CHEQUE_PLANILLA As Int32, aID_CHEQUERA As Int32, aNO_CHEQUE As Int32, aMONTO_CHEQUE As Decimal, aCANTIDAD_LETRAS As String, aTITULAR_CHEQUE As String, aESTADO As String, aFECHA_EMISION As DateTime, aFECHA_ANULACION As DateTime, aMOTIVO_ANULACION As String, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime, aNO_PARTIDA_PH As Int32, aID_CATORCENA As Int32, aID_TIPO_PLANILLA As Int32, aCODIPROVEEDOR_TRANSPORTISTA As String)
        Me._ID_CHEQUE_PLANILLA = aID_CHEQUE_PLANILLA
        Me._ID_CHEQUERA = aID_CHEQUERA
        Me._NO_CHEQUE = aNO_CHEQUE
        Me._MONTO_CHEQUE = aMONTO_CHEQUE
        Me._CANTIDAD_LETRAS = aCANTIDAD_LETRAS
        Me._TITULAR_CHEQUE = aTITULAR_CHEQUE
        Me._ESTADO = aESTADO
        Me._FECHA_EMISION = aFECHA_EMISION
        Me._FECHA_ANULACION = aFECHA_ANULACION
        Me._MOTIVO_ANULACION = aMOTIVO_ANULACION
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
        Me._NO_PARTIDA_PH = aNO_PARTIDA_PH
        Me._ID_CATORCENA = aID_CATORCENA
        Me._ID_TIPO_PLANILLA = aID_TIPO_PLANILLA
        Me._CODIPROVEEDOR_TRANSPORTISTA = aCODIPROVEEDOR_TRANSPORTISTA
    End Sub

#Region " Properties "

    Private _ID_CHEQUE_PLANILLA As Int32
    <Column(Name:="Id cheque planilla", Storage:="ID_CHEQUE_PLANILLA", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_CHEQUE_PLANILLA() As Int32
        Get
            Return _ID_CHEQUE_PLANILLA
        End Get
        Set(ByVal Value As Int32)
            _ID_CHEQUE_PLANILLA = Value
            OnPropertyChanged("ID_CHEQUE_PLANILLA")
        End Set
    End Property 

    Private _ID_CHEQUERA As Int32
    <Column(Name:="Id chequera", Storage:="ID_CHEQUERA", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_CHEQUERA() As Int32
        Get
            Return _ID_CHEQUERA
        End Get
        Set(ByVal Value As Int32)
            _ID_CHEQUERA = Value
            OnPropertyChanged("ID_CHEQUERA")
        End Set
    End Property 

    Private _ID_CHEQUERAOld As Int32
    Public Property ID_CHEQUERAOld() As Int32
        Get
            Return _ID_CHEQUERAOld
        End Get
        Set(ByVal Value As Int32)
            _ID_CHEQUERAOld = Value
        End Set
    End Property 

    Private _fkID_CHEQUERA As CHEQUERA_PLANILLA
    Public Property fkID_CHEQUERA() As CHEQUERA_PLANILLA
        Get
            Return _fkID_CHEQUERA
        End Get
        Set(ByVal Value As CHEQUERA_PLANILLA)
            _fkID_CHEQUERA = Value
        End Set
    End Property 

    Private _NO_CHEQUE As Int32
    <Column(Name:="No cheque", Storage:="NO_CHEQUE", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property NO_CHEQUE() As Int32
        Get
            Return _NO_CHEQUE
        End Get
        Set(ByVal Value As Int32)
            _NO_CHEQUE = Value
            OnPropertyChanged("NO_CHEQUE")
        End Set
    End Property 

    Private _NO_CHEQUEOld As Int32
    Public Property NO_CHEQUEOld() As Int32
        Get
            Return _NO_CHEQUEOld
        End Get
        Set(ByVal Value As Int32)
            _NO_CHEQUEOld = Value
        End Set
    End Property 

    Private _MONTO_CHEQUE As Decimal
    <Column(Name:="Monto cheque", Storage:="MONTO_CHEQUE", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property MONTO_CHEQUE() As Decimal
        Get
            Return _MONTO_CHEQUE
        End Get
        Set(ByVal Value As Decimal)
            _MONTO_CHEQUE = Value
            OnPropertyChanged("MONTO_CHEQUE")
        End Set
    End Property 

    Private _MONTO_CHEQUEOld As Decimal
    Public Property MONTO_CHEQUEOld() As Decimal
        Get
            Return _MONTO_CHEQUEOld
        End Get
        Set(ByVal Value As Decimal)
            _MONTO_CHEQUEOld = Value
        End Set
    End Property 

    Private _CANTIDAD_LETRAS As String
    <Column(Name:="Cantidad letras", Storage:="CANTIDAD_LETRAS", DbType:="VARCHAR(200)", Id:=False), _
     DataObjectField(False, False, True, 200)> _
    Public Property CANTIDAD_LETRAS() As String
        Get
            Return _CANTIDAD_LETRAS
        End Get
        Set(ByVal Value As String)
            _CANTIDAD_LETRAS = Value
            OnPropertyChanged("CANTIDAD_LETRAS")
        End Set
    End Property 

    Private _CANTIDAD_LETRASOld As String
    Public Property CANTIDAD_LETRASOld() As String
        Get
            Return _CANTIDAD_LETRASOld
        End Get
        Set(ByVal Value As String)
            _CANTIDAD_LETRASOld = Value
        End Set
    End Property 

    Private _TITULAR_CHEQUE As String
    <Column(Name:="Titular cheque", Storage:="TITULAR_CHEQUE", DbType:="VARCHAR(120)", Id:=False), _
     DataObjectField(False, False, True, 120)> _
    Public Property TITULAR_CHEQUE() As String
        Get
            Return _TITULAR_CHEQUE
        End Get
        Set(ByVal Value As String)
            _TITULAR_CHEQUE = Value
            OnPropertyChanged("TITULAR_CHEQUE")
        End Set
    End Property 

    Private _TITULAR_CHEQUEOld As String
    Public Property TITULAR_CHEQUEOld() As String
        Get
            Return _TITULAR_CHEQUEOld
        End Get
        Set(ByVal Value As String)
            _TITULAR_CHEQUEOld = Value
        End Set
    End Property 

    Private _ESTADO As String
    <Column(Name:="Estado", Storage:="ESTADO", DbType:="CHAR(1) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 1)> _
    Public Property ESTADO() As String
        Get
            Return _ESTADO
        End Get
        Set(ByVal Value As String)
            _ESTADO = Value
            OnPropertyChanged("ESTADO")
        End Set
    End Property 

    Private _ESTADOOld As String
    Public Property ESTADOOld() As String
        Get
            Return _ESTADOOld
        End Get
        Set(ByVal Value As String)
            _ESTADOOld = Value
        End Set
    End Property 

    Private _FECHA_EMISION As DateTime
    <Column(Name:="Fecha emision", Storage:="FECHA_EMISION", DbType:="DATETIME", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_EMISION() As DateTime
        Get
            Return _FECHA_EMISION
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_EMISION = Value
            OnPropertyChanged("FECHA_EMISION")
        End Set
    End Property 

    Private _FECHA_EMISIONOld As DateTime
    Public Property FECHA_EMISIONOld() As DateTime
        Get
            Return _FECHA_EMISIONOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_EMISIONOld = Value
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

    Private _NO_PARTIDA_PH As Int32
    <Column(Name:="No partida ph", Storage:="NO_PARTIDA_PH", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property NO_PARTIDA_PH() As Int32
        Get
            Return _NO_PARTIDA_PH
        End Get
        Set(ByVal Value As Int32)
            _NO_PARTIDA_PH = Value
            OnPropertyChanged("NO_PARTIDA_PH")
        End Set
    End Property 

    Private _NO_PARTIDA_PHOld As Int32
    Public Property NO_PARTIDA_PHOld() As Int32
        Get
            Return _NO_PARTIDA_PHOld
        End Get
        Set(ByVal Value As Int32)
            _NO_PARTIDA_PHOld = Value
        End Set
    End Property 

    Private _ID_CATORCENA As Int32
    <Column(Name:="Id catorcena", Storage:="ID_CATORCENA", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_CATORCENA() As Int32
        Get
            Return _ID_CATORCENA
        End Get
        Set(ByVal Value As Int32)
            _ID_CATORCENA = Value
            OnPropertyChanged("ID_CATORCENA")
        End Set
    End Property 

    Private _ID_CATORCENAOld As Int32
    Public Property ID_CATORCENAOld() As Int32
        Get
            Return _ID_CATORCENAOld
        End Get
        Set(ByVal Value As Int32)
            _ID_CATORCENAOld = Value
        End Set
    End Property 

    Private _fkID_CATORCENA As CATORCENA_ZAFRA
    Public Property fkID_CATORCENA() As CATORCENA_ZAFRA
        Get
            Return _fkID_CATORCENA
        End Get
        Set(ByVal Value As CATORCENA_ZAFRA)
            _fkID_CATORCENA = Value
        End Set
    End Property 

    Private _ID_TIPO_PLANILLA As Int32
    <Column(Name:="Id tipo planilla", Storage:="ID_TIPO_PLANILLA", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_TIPO_PLANILLA() As Int32
        Get
            Return _ID_TIPO_PLANILLA
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_PLANILLA = Value
            OnPropertyChanged("ID_TIPO_PLANILLA")
        End Set
    End Property 

    Private _ID_TIPO_PLANILLAOld As Int32
    Public Property ID_TIPO_PLANILLAOld() As Int32
        Get
            Return _ID_TIPO_PLANILLAOld
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_PLANILLAOld = Value
        End Set
    End Property 

    Private _fkID_TIPO_PLANILLA As TIPO_PLANILLA
    Public Property fkID_TIPO_PLANILLA() As TIPO_PLANILLA
        Get
            Return _fkID_TIPO_PLANILLA
        End Get
        Set(ByVal Value As TIPO_PLANILLA)
            _fkID_TIPO_PLANILLA = Value
        End Set
    End Property 

    Private _CODIPROVEEDOR_TRANSPORTISTA As String
    <Column(Name:="Codiproveedor transportista", Storage:="CODIPROVEEDOR_TRANSPORTISTA", DbType:="VARCHAR(10)", Id:=False), _
     DataObjectField(False, False, True, 10)> _
    Public Property CODIPROVEEDOR_TRANSPORTISTA() As String
        Get
            Return _CODIPROVEEDOR_TRANSPORTISTA
        End Get
        Set(ByVal Value As String)
            _CODIPROVEEDOR_TRANSPORTISTA = Value
            OnPropertyChanged("CODIPROVEEDOR_TRANSPORTISTA")
        End Set
    End Property 

    Private _CODIPROVEEDOR_TRANSPORTISTAOld As String
    Public Property CODIPROVEEDOR_TRANSPORTISTAOld() As String
        Get
            Return _CODIPROVEEDOR_TRANSPORTISTAOld
        End Get
        Set(ByVal Value As String)
            _CODIPROVEEDOR_TRANSPORTISTAOld = Value
        End Set
    End Property 

    Private _fkCODIPROVEEDOR_TRANSPORTISTA As PLANILLA
    Public Property fkCODIPROVEEDOR_TRANSPORTISTA() As PLANILLA
        Get
            Return _fkCODIPROVEEDOR_TRANSPORTISTA
        End Get
        Set(ByVal Value As PLANILLA)
            _fkCODIPROVEEDOR_TRANSPORTISTA = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
