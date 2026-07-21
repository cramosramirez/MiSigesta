''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.CENSO_LOTES
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row CENSO_LOTES en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	03/04/2014	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="CENSO_LOTES")> Public Class CENSO_LOTES
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_CENSO_LOTES As Int32, aID_ZAFRA As Int32, aACCESLOTE As String, aFECHA_VERIFICACION As DateTime, aREND_HISTO As Decimal, aMZ_ENTREGAR As Decimal, aTONEL_MZ_ENTREGAR As Decimal, aTONEL_ENTREGAR As Decimal, aLBS_ENTREGAR As Decimal, aVALOR_ENTREGAR As Decimal, aMZ_ENTREGADA As Decimal, aTONEL_MZ_ENTREGADA As Decimal, aTONEL_ENTREGADA As Decimal, aLBS_ENTREGADA As Decimal, aVALOR_ENTREGADA As Decimal, aMZ_CENSO As Decimal, aTONEL_MZ_CENSO As Decimal, aTONEL_CENSO As Decimal, aLBS_CENSO As Decimal, aVALOR_CENSO As Decimal, aID_CENSO As Int32, aID_MOTIVO_VARIACION As Int32, aOBSERVACION As String, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime)
        Me._ID_CENSO_LOTES = aID_CENSO_LOTES
        Me._ID_ZAFRA = aID_ZAFRA
        Me._ACCESLOTE = aACCESLOTE
        Me._FECHA_VERIFICACION = aFECHA_VERIFICACION
        Me._REND_HISTO = aREND_HISTO
        Me._MZ_ENTREGAR = aMZ_ENTREGAR
        Me._TONEL_MZ_ENTREGAR = aTONEL_MZ_ENTREGAR
        Me._TONEL_ENTREGAR = aTONEL_ENTREGAR
        Me._LBS_ENTREGAR = aLBS_ENTREGAR
        Me._VALOR_ENTREGAR = aVALOR_ENTREGAR
        Me._MZ_ENTREGADA = aMZ_ENTREGADA
        Me._TONEL_MZ_ENTREGADA = aTONEL_MZ_ENTREGADA
        Me._TONEL_ENTREGADA = aTONEL_ENTREGADA
        Me._LBS_ENTREGADA = aLBS_ENTREGADA
        Me._VALOR_ENTREGADA = aVALOR_ENTREGADA
        Me._MZ_CENSO = aMZ_CENSO
        Me._TONEL_MZ_CENSO = aTONEL_MZ_CENSO
        Me._TONEL_CENSO = aTONEL_CENSO
        Me._LBS_CENSO = aLBS_CENSO
        Me._VALOR_CENSO = aVALOR_CENSO
        Me._ID_CENSO = aID_CENSO
        Me._ID_MOTIVO_VARIACION = aID_MOTIVO_VARIACION
        Me._OBSERVACION = aOBSERVACION
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
    End Sub

#Region " Properties "

    Private _ID_CENSO_LOTES As Int32
    <Column(Name:="Id censo lotes", Storage:="ID_CENSO_LOTES", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_CENSO_LOTES() As Int32
        Get
            Return _ID_CENSO_LOTES
        End Get
        Set(ByVal Value As Int32)
            _ID_CENSO_LOTES = Value
            OnPropertyChanged("ID_CENSO_LOTES")
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

    Private _fkID_ZAFRA As ZAFRA
    Public Property fkID_ZAFRA() As ZAFRA
        Get
            Return _fkID_ZAFRA
        End Get
        Set(ByVal Value As ZAFRA)
            _fkID_ZAFRA = Value
        End Set
    End Property 

    Private _ACCESLOTE As String
    <Column(Name:="Acceslote", Storage:="ACCESLOTE", DbType:="CHAR(21) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 21)> _
    Public Property ACCESLOTE() As String
        Get
            Return _ACCESLOTE
        End Get
        Set(ByVal Value As String)
            _ACCESLOTE = Value
            OnPropertyChanged("ACCESLOTE")
        End Set
    End Property 

    Private _ACCESLOTEOld As String
    Public Property ACCESLOTEOld() As String
        Get
            Return _ACCESLOTEOld
        End Get
        Set(ByVal Value As String)
            _ACCESLOTEOld = Value
        End Set
    End Property 

    Private _fkACCESLOTE As LOTES
    Public Property fkACCESLOTE() As LOTES
        Get
            Return _fkACCESLOTE
        End Get
        Set(ByVal Value As LOTES)
            _fkACCESLOTE = Value
        End Set
    End Property 

    Private _FECHA_VERIFICACION As DateTime
    <Column(Name:="Fecha verificacion", Storage:="FECHA_VERIFICACION", DbType:="DATETIME NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
    Public Property FECHA_VERIFICACION() As DateTime
        Get
            Return _FECHA_VERIFICACION
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_VERIFICACION = Value
            OnPropertyChanged("FECHA_VERIFICACION")
        End Set
    End Property 

    Private _FECHA_VERIFICACIONOld As DateTime
    Public Property FECHA_VERIFICACIONOld() As DateTime
        Get
            Return _FECHA_VERIFICACIONOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_VERIFICACIONOld = Value
        End Set
    End Property

    Private _REND_HISTO As Decimal
    <Column(Name:="Rend historico", Storage:="REND_HISTO", DbType:="NUMERIC(11,4)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=11, Scale:=4)> _
    Public Property REND_HISTO() As Decimal
        Get
            Return _REND_HISTO
        End Get
        Set(ByVal Value As Decimal)
            _REND_HISTO = Value
            OnPropertyChanged("REND_HISTO")
        End Set
    End Property
    Private _REND_HISTOOld As Decimal
    Public Property REND_HISTOOld() As Decimal
        Get
            Return _REND_HISTOOld
        End Get
        Set(ByVal Value As Decimal)
            _REND_HISTOOld = Value
        End Set
    End Property

    Private _MZ_ENTREGAR As Decimal
    <Column(Name:="Mz entregar", Storage:="MZ_ENTREGAR", DbType:="NUMERIC(10,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)> _
    Public Property MZ_ENTREGAR() As Decimal
        Get
            Return _MZ_ENTREGAR
        End Get
        Set(ByVal Value As Decimal)
            _MZ_ENTREGAR = Value
            OnPropertyChanged("MZ_ENTREGAR")
        End Set
    End Property 

    Private _MZ_ENTREGAROld As Decimal
    Public Property MZ_ENTREGAROld() As Decimal
        Get
            Return _MZ_ENTREGAROld
        End Get
        Set(ByVal Value As Decimal)
            _MZ_ENTREGAROld = Value
        End Set
    End Property 

    Private _TONEL_MZ_ENTREGAR As Decimal
    <Column(Name:="Tonel mz entregar", Storage:="TONEL_MZ_ENTREGAR", DbType:="NUMERIC(10,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)> _
    Public Property TONEL_MZ_ENTREGAR() As Decimal
        Get
            Return _TONEL_MZ_ENTREGAR
        End Get
        Set(ByVal Value As Decimal)
            _TONEL_MZ_ENTREGAR = Value
            OnPropertyChanged("TONEL_MZ_ENTREGAR")
        End Set
    End Property 

    Private _TONEL_MZ_ENTREGAROld As Decimal
    Public Property TONEL_MZ_ENTREGAROld() As Decimal
        Get
            Return _TONEL_MZ_ENTREGAROld
        End Get
        Set(ByVal Value As Decimal)
            _TONEL_MZ_ENTREGAROld = Value
        End Set
    End Property 

    Private _TONEL_ENTREGAR As Decimal
    <Column(Name:="Tonel entregar", Storage:="TONEL_ENTREGAR", DbType:="NUMERIC(10,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)> _
    Public Property TONEL_ENTREGAR() As Decimal
        Get
            Return _TONEL_ENTREGAR
        End Get
        Set(ByVal Value As Decimal)
            _TONEL_ENTREGAR = Value
            OnPropertyChanged("TONEL_ENTREGAR")
        End Set
    End Property 

    Private _TONEL_ENTREGAROld As Decimal
    Public Property TONEL_ENTREGAROld() As Decimal
        Get
            Return _TONEL_ENTREGAROld
        End Get
        Set(ByVal Value As Decimal)
            _TONEL_ENTREGAROld = Value
        End Set
    End Property 

    Private _LBS_ENTREGAR As Decimal
    <Column(Name:="Lbs entregar", Storage:="LBS_ENTREGAR", DbType:="NUMERIC(10,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)> _
    Public Property LBS_ENTREGAR() As Decimal
        Get
            Return _LBS_ENTREGAR
        End Get
        Set(ByVal Value As Decimal)
            _LBS_ENTREGAR = Value
            OnPropertyChanged("LBS_ENTREGAR")
        End Set
    End Property 

    Private _LBS_ENTREGAROld As Decimal
    Public Property LBS_ENTREGAROld() As Decimal
        Get
            Return _LBS_ENTREGAROld
        End Get
        Set(ByVal Value As Decimal)
            _LBS_ENTREGAROld = Value
        End Set
    End Property 

    Private _VALOR_ENTREGAR As Decimal
    <Column(Name:="Valor entregar", Storage:="VALOR_ENTREGAR", DbType:="NUMERIC(18,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=18, Scale:=2)> _
    Public Property VALOR_ENTREGAR() As Decimal
        Get
            Return _VALOR_ENTREGAR
        End Get
        Set(ByVal Value As Decimal)
            _VALOR_ENTREGAR = Value
            OnPropertyChanged("VALOR_ENTREGAR")
        End Set
    End Property 

    Private _VALOR_ENTREGAROld As Decimal
    Public Property VALOR_ENTREGAROld() As Decimal
        Get
            Return _VALOR_ENTREGAROld
        End Get
        Set(ByVal Value As Decimal)
            _VALOR_ENTREGAROld = Value
        End Set
    End Property 

    Private _MZ_ENTREGADA As Decimal
    <Column(Name:="Mz entregada", Storage:="MZ_ENTREGADA", DbType:="NUMERIC(10,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)> _
    Public Property MZ_ENTREGADA() As Decimal
        Get
            Return _MZ_ENTREGADA
        End Get
        Set(ByVal Value As Decimal)
            _MZ_ENTREGADA = Value
            OnPropertyChanged("MZ_ENTREGADA")
        End Set
    End Property 

    Private _MZ_ENTREGADAOld As Decimal
    Public Property MZ_ENTREGADAOld() As Decimal
        Get
            Return _MZ_ENTREGADAOld
        End Get
        Set(ByVal Value As Decimal)
            _MZ_ENTREGADAOld = Value
        End Set
    End Property 

    Private _TONEL_MZ_ENTREGADA As Decimal
    <Column(Name:="Tonel mz entregada", Storage:="TONEL_MZ_ENTREGADA", DbType:="NUMERIC(10,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)> _
    Public Property TONEL_MZ_ENTREGADA() As Decimal
        Get
            Return _TONEL_MZ_ENTREGADA
        End Get
        Set(ByVal Value As Decimal)
            _TONEL_MZ_ENTREGADA = Value
            OnPropertyChanged("TONEL_MZ_ENTREGADA")
        End Set
    End Property 

    Private _TONEL_MZ_ENTREGADAOld As Decimal
    Public Property TONEL_MZ_ENTREGADAOld() As Decimal
        Get
            Return _TONEL_MZ_ENTREGADAOld
        End Get
        Set(ByVal Value As Decimal)
            _TONEL_MZ_ENTREGADAOld = Value
        End Set
    End Property 

    Private _TONEL_ENTREGADA As Decimal
    <Column(Name:="Tonel entregada", Storage:="TONEL_ENTREGADA", DbType:="NUMERIC(10,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)> _
    Public Property TONEL_ENTREGADA() As Decimal
        Get
            Return _TONEL_ENTREGADA
        End Get
        Set(ByVal Value As Decimal)
            _TONEL_ENTREGADA = Value
            OnPropertyChanged("TONEL_ENTREGADA")
        End Set
    End Property 

    Private _TONEL_ENTREGADAOld As Decimal
    Public Property TONEL_ENTREGADAOld() As Decimal
        Get
            Return _TONEL_ENTREGADAOld
        End Get
        Set(ByVal Value As Decimal)
            _TONEL_ENTREGADAOld = Value
        End Set
    End Property 

    Private _LBS_ENTREGADA As Decimal
    <Column(Name:="Lbs entregada", Storage:="LBS_ENTREGADA", DbType:="NUMERIC(10,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)> _
    Public Property LBS_ENTREGADA() As Decimal
        Get
            Return _LBS_ENTREGADA
        End Get
        Set(ByVal Value As Decimal)
            _LBS_ENTREGADA = Value
            OnPropertyChanged("LBS_ENTREGADA")
        End Set
    End Property 

    Private _LBS_ENTREGADAOld As Decimal
    Public Property LBS_ENTREGADAOld() As Decimal
        Get
            Return _LBS_ENTREGADAOld
        End Get
        Set(ByVal Value As Decimal)
            _LBS_ENTREGADAOld = Value
        End Set
    End Property 

    Private _VALOR_ENTREGADA As Decimal
    <Column(Name:="Valor entregada", Storage:="VALOR_ENTREGADA", DbType:="NUMERIC(18,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=18, Scale:=2)> _
    Public Property VALOR_ENTREGADA() As Decimal
        Get
            Return _VALOR_ENTREGADA
        End Get
        Set(ByVal Value As Decimal)
            _VALOR_ENTREGADA = Value
            OnPropertyChanged("VALOR_ENTREGADA")
        End Set
    End Property 

    Private _VALOR_ENTREGADAOld As Decimal
    Public Property VALOR_ENTREGADAOld() As Decimal
        Get
            Return _VALOR_ENTREGADAOld
        End Get
        Set(ByVal Value As Decimal)
            _VALOR_ENTREGADAOld = Value
        End Set
    End Property 

    Private _MZ_CENSO As Decimal
    <Column(Name:="Mz censo", Storage:="MZ_CENSO", DbType:="NUMERIC(10,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)> _
    Public Property MZ_CENSO() As Decimal
        Get
            Return _MZ_CENSO
        End Get
        Set(ByVal Value As Decimal)
            _MZ_CENSO = Value
            OnPropertyChanged("MZ_CENSO")
        End Set
    End Property 

    Private _MZ_CENSOOld As Decimal
    Public Property MZ_CENSOOld() As Decimal
        Get
            Return _MZ_CENSOOld
        End Get
        Set(ByVal Value As Decimal)
            _MZ_CENSOOld = Value
        End Set
    End Property 

    Private _TONEL_MZ_CENSO As Decimal
    <Column(Name:="Tonel mz censo", Storage:="TONEL_MZ_CENSO", DbType:="NUMERIC(10,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)> _
    Public Property TONEL_MZ_CENSO() As Decimal
        Get
            Return _TONEL_MZ_CENSO
        End Get
        Set(ByVal Value As Decimal)
            _TONEL_MZ_CENSO = Value
            OnPropertyChanged("TONEL_MZ_CENSO")
        End Set
    End Property 

    Private _TONEL_MZ_CENSOOld As Decimal
    Public Property TONEL_MZ_CENSOOld() As Decimal
        Get
            Return _TONEL_MZ_CENSOOld
        End Get
        Set(ByVal Value As Decimal)
            _TONEL_MZ_CENSOOld = Value
        End Set
    End Property 

    Private _TONEL_CENSO As Decimal
    <Column(Name:="Tonel censo", Storage:="TONEL_CENSO", DbType:="NUMERIC(10,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)> _
    Public Property TONEL_CENSO() As Decimal
        Get
            Return _TONEL_CENSO
        End Get
        Set(ByVal Value As Decimal)
            _TONEL_CENSO = Value
            OnPropertyChanged("TONEL_CENSO")
        End Set
    End Property 

    Private _TONEL_CENSOOld As Decimal
    Public Property TONEL_CENSOOld() As Decimal
        Get
            Return _TONEL_CENSOOld
        End Get
        Set(ByVal Value As Decimal)
            _TONEL_CENSOOld = Value
        End Set
    End Property 

    Private _LBS_CENSO As Decimal
    <Column(Name:="Lbs censo", Storage:="LBS_CENSO", DbType:="NUMERIC(10,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)> _
    Public Property LBS_CENSO() As Decimal
        Get
            Return _LBS_CENSO
        End Get
        Set(ByVal Value As Decimal)
            _LBS_CENSO = Value
            OnPropertyChanged("LBS_CENSO")
        End Set
    End Property 

    Private _LBS_CENSOOld As Decimal
    Public Property LBS_CENSOOld() As Decimal
        Get
            Return _LBS_CENSOOld
        End Get
        Set(ByVal Value As Decimal)
            _LBS_CENSOOld = Value
        End Set
    End Property 

    Private _VALOR_CENSO As Decimal
    <Column(Name:="Valor censo", Storage:="VALOR_CENSO", DbType:="NUMERIC(18,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=18, Scale:=2)> _
    Public Property VALOR_CENSO() As Decimal
        Get
            Return _VALOR_CENSO
        End Get
        Set(ByVal Value As Decimal)
            _VALOR_CENSO = Value
            OnPropertyChanged("VALOR_CENSO")
        End Set
    End Property 

    Private _VALOR_CENSOOld As Decimal
    Public Property VALOR_CENSOOld() As Decimal
        Get
            Return _VALOR_CENSOOld
        End Get
        Set(ByVal Value As Decimal)
            _VALOR_CENSOOld = Value
        End Set
    End Property 

    Private _ID_CENSO As Int32
    <Column(Name:="Id censo", Storage:="ID_CENSO", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_CENSO() As Int32
        Get
            Return _ID_CENSO
        End Get
        Set(ByVal Value As Int32)
            _ID_CENSO = Value
            OnPropertyChanged("ID_CENSO")
        End Set
    End Property 

    Private _ID_CENSOOld As Int32
    Public Property ID_CENSOOld() As Int32
        Get
            Return _ID_CENSOOld
        End Get
        Set(ByVal Value As Int32)
            _ID_CENSOOld = Value
        End Set
    End Property 

    Private _fkID_CENSO As CENSO
    Public Property fkID_CENSO() As CENSO
        Get
            Return _fkID_CENSO
        End Get
        Set(ByVal Value As CENSO)
            _fkID_CENSO = Value
        End Set
    End Property 

    Private _ID_MOTIVO_VARIACION As Int32
    <Column(Name:="Id motivo variacion", Storage:="ID_MOTIVO_VARIACION", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_MOTIVO_VARIACION() As Int32
        Get
            Return _ID_MOTIVO_VARIACION
        End Get
        Set(ByVal Value As Int32)
            _ID_MOTIVO_VARIACION = Value
            OnPropertyChanged("ID_MOTIVO_VARIACION")
        End Set
    End Property

    Private _ID_MOTIVO_VARIACIONOld As Int32
    Public Property ID_MOTIVO_VARIACIONOld() As Int32
        Get
            Return _ID_MOTIVO_VARIACIONOld
        End Get
        Set(ByVal Value As Int32)
            _ID_MOTIVO_VARIACIONOld = Value
        End Set
    End Property 

    Private _fkID_MOTIVO_VARIACION As MOTIVO_VARIACION
    Public Property fkID_MOTIVO_VARIACION() As MOTIVO_VARIACION
        Get
            Return _fkID_MOTIVO_VARIACION
        End Get
        Set(ByVal Value As MOTIVO_VARIACION)
            _fkID_MOTIVO_VARIACION = Value
        End Set
    End Property 

    Private _OBSERVACION As String
    <Column(Name:="Observacion", Storage:="OBSERVACION", DbType:="VARCHAR(500)", Id:=False), _
     DataObjectField(False, False, True, 500)> _
    Public Property OBSERVACION() As String
        Get
            Return _OBSERVACION
        End Get
        Set(ByVal Value As String)
            _OBSERVACION = Value
            OnPropertyChanged("OBSERVACION")
        End Set
    End Property 

    Private _OBSERVACIONOld As String
    Public Property OBSERVACIONOld() As String
        Get
            Return _OBSERVACIONOld
        End Get
        Set(ByVal Value As String)
            _OBSERVACIONOld = Value
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
