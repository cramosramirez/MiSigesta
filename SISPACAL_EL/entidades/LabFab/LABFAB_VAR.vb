''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.LABFAB_VAR
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row LABFAB_VAR en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	18/11/2015	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="LABFAB_VAR")> Public Class LABFAB_VAR
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_VAR As Int32, aID_ANALISIS As Int32, aID_TIPOVAR As Int32, aNOMBRE_VAR As String, aDESCRIP_VAR As String, aID_ANALISIS_REF As Int32, aTABLA_REF As String, aCOLUM1_REF As String, aCOLUM2_REF As String, aCOLUM_VALOR_REF As String, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime)
        Me._ID_VAR = aID_VAR
        Me._ID_ANALISIS = aID_ANALISIS
        Me._ID_TIPOVAR = aID_TIPOVAR
        Me._NOMBRE_VAR = aNOMBRE_VAR
        Me._DESCRIP_VAR = aDESCRIP_VAR
        Me._ID_ANALISIS_REF = aID_ANALISIS_REF
        Me._TABLA_REF = aTABLA_REF
        Me._COLUM1_REF = aCOLUM1_REF
        Me._COLUM2_REF = aCOLUM2_REF
        Me._COLUM_VALOR_REF = aCOLUM_VALOR_REF
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
    End Sub

#Region " Properties "

    Private _ID_VAR As Int32
    <Column(Name:="Id var", Storage:="ID_VAR", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_VAR() As Int32
        Get
            Return _ID_VAR
        End Get
        Set(ByVal Value As Int32)
            _ID_VAR = Value
            OnPropertyChanged("ID_VAR")
        End Set
    End Property 

    Private _ID_ANALISIS As Int32
    <Column(Name:="Id analisis", Storage:="ID_ANALISIS", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_ANALISIS() As Int32
        Get
            Return _ID_ANALISIS
        End Get
        Set(ByVal Value As Int32)
            _ID_ANALISIS = Value
            OnPropertyChanged("ID_ANALISIS")
        End Set
    End Property 

    Private _ID_ANALISISOld As Int32
    Public Property ID_ANALISISOld() As Int32
        Get
            Return _ID_ANALISISOld
        End Get
        Set(ByVal Value As Int32)
            _ID_ANALISISOld = Value
        End Set
    End Property 

    Private _fkID_ANALISIS As LABFAB_ANALISIS
    Public Property fkID_ANALISIS() As LABFAB_ANALISIS
        Get
            Return _fkID_ANALISIS
        End Get
        Set(ByVal Value As LABFAB_ANALISIS)
            _fkID_ANALISIS = Value
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

    Private _NOMBRE_VAR As String
    <Column(Name:="Nombre var", Storage:="NOMBRE_VAR", DbType:="VARCHAR(30) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 30)> _
    Public Property NOMBRE_VAR() As String
        Get
            Return _NOMBRE_VAR
        End Get
        Set(ByVal Value As String)
            _NOMBRE_VAR = Value
            OnPropertyChanged("NOMBRE")
        End Set
    End Property

    Private _NOMBRE_VAROld As String
    Public Property NOMBRE_VAROld() As String
        Get
            Return _NOMBRE_VAROld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_VAROld = Value
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

    Private _TABLA_REF As String
    <Column(Name:="Tabla ref", Storage:="TABLA_REF", DbType:="VARCHAR(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
    Public Property TABLA_REF() As String
        Get
            Return _TABLA_REF
        End Get
        Set(ByVal Value As String)
            _TABLA_REF = Value
            OnPropertyChanged("TABLA_REF")
        End Set
    End Property 

    Private _TABLA_REFOld As String
    Public Property TABLA_REFOld() As String
        Get
            Return _TABLA_REFOld
        End Get
        Set(ByVal Value As String)
            _TABLA_REFOld = Value
        End Set
    End Property 

    Private _COLUM1_REF As String
    <Column(Name:="Colum1 ref", Storage:="COLUM1_REF", DbType:="VARCHAR(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
    Public Property COLUM1_REF() As String
        Get
            Return _COLUM1_REF
        End Get
        Set(ByVal Value As String)
            _COLUM1_REF = Value
            OnPropertyChanged("COLUM1_REF")
        End Set
    End Property 

    Private _COLUM1_REFOld As String
    Public Property COLUM1_REFOld() As String
        Get
            Return _COLUM1_REFOld
        End Get
        Set(ByVal Value As String)
            _COLUM1_REFOld = Value
        End Set
    End Property 

    Private _COLUM2_REF As String
    <Column(Name:="Colum2 ref", Storage:="COLUM2_REF", DbType:="VARCHAR(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
    Public Property COLUM2_REF() As String
        Get
            Return _COLUM2_REF
        End Get
        Set(ByVal Value As String)
            _COLUM2_REF = Value
            OnPropertyChanged("COLUM2_REF")
        End Set
    End Property 

    Private _COLUM2_REFOld As String
    Public Property COLUM2_REFOld() As String
        Get
            Return _COLUM2_REFOld
        End Get
        Set(ByVal Value As String)
            _COLUM2_REFOld = Value
        End Set
    End Property 

    Private _COLUM_VALOR_REF As String
    <Column(Name:="Colum valor ref", Storage:="COLUM_VALOR_REF", DbType:="VARCHAR(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
    Public Property COLUM_VALOR_REF() As String
        Get
            Return _COLUM_VALOR_REF
        End Get
        Set(ByVal Value As String)
            _COLUM_VALOR_REF = Value
            OnPropertyChanged("COLUM_VALOR_REF")
        End Set
    End Property 

    Private _COLUM_VALOR_REFOld As String
    Public Property COLUM_VALOR_REFOld() As String
        Get
            Return _COLUM_VALOR_REFOld
        End Get
        Set(ByVal Value As String)
            _COLUM_VALOR_REFOld = Value
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
