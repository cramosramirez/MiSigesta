''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.REQENCA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row REQENCA en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	10/06/2015	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="REQENCA")> Public Class REQENCA
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_REQENCA As Int32, aID_PERIODOREQ As Int32, aID_SECCION As Int32, aID_SOLICITANTE As Int32, aNO_REQ As Int32, aFECHA_EMISION As DateTime, aNO_REQ_PH As String, aFECHA_REQ_PH As DateTime, aNO_ORDEN_PH As String, aFECHA_ORDEN_PH As DateTime, aTOTAL_ORDEN_PH As Decimal, aAFECTO_ORDEN_PH As Decimal, aIVA_ORDEN_PH As Decimal, aNO_INGRESO_ALM As String, aFECHA_INGRESO_ALM As DateTime, aNO_QUEDAN As String, aFECHA_QUEDAN As DateTime, aUSO As String, aUSUARIO_APROB As String, aFECHA_APROB As DateTime, aUSUARIO_NOAPROB As String, aFECHA_NOAPROB As DateTime, aUSUARIO_ANUL As String, aFECHA_ANUL As DateTime, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime, aCODI_REQ As String, aORDEN_LOCAL As Boolean, aFECHA_INGRESO_EST As DateTime, aCOMENTARIO_EST As String, aTOTAL_INGRESO_ALM As Decimal, aAFECTO_INGRESO_ALM As Decimal, aIVA_INGRESO_ALM As Decimal, aTOTAL_QUEDAN As Decimal, aAFECTO_QUEDAN As Decimal, aIVA_QUEDAN As Decimal, aSECCION As String, aEQUIPO As String, aPROPOSITO As Int32, aCOMPRA_LOCAL As Boolean, aFECHA_MAX_SUMIN As DateTime, aFECHA_RECIBOREQ As DateTime, aPROVEE_INVITADOS As String, aPROVEE_ADJUDICADO_ORDEN As String, aFECHA_ESTI_INGRESO_ORDEN As DateTime, aTIPO_DOCCOMPRA_ALM As Int32, aNO_DOCCOMPRA_ALM As String, aNO_CHEQUE_CHQ As String, aBANCO_CHQ As String, aFECHA_CHQ As DateTime, aMONTO_CHQ As Decimal, aID_REQETAPA As Int32)
        Me._ID_REQENCA = aID_REQENCA
        Me._ID_PERIODOREQ = aID_PERIODOREQ
        Me._ID_SECCION = aID_SECCION
        Me._ID_SOLICITANTE = aID_SOLICITANTE
        Me._NO_REQ = aNO_REQ
        Me._FECHA_EMISION = aFECHA_EMISION
        Me._NO_REQ_PH = aNO_REQ_PH
        Me._FECHA_REQ_PH = aFECHA_REQ_PH
        Me._NO_ORDEN_PH = aNO_ORDEN_PH
        Me._FECHA_ORDEN_PH = aFECHA_ORDEN_PH
        Me._TOTAL_ORDEN_PH = aTOTAL_ORDEN_PH
        Me._AFECTO_ORDEN_PH = aAFECTO_ORDEN_PH
        Me._IVA_ORDEN_PH = aIVA_ORDEN_PH
        Me._NO_INGRESO_ALM = aNO_INGRESO_ALM
        Me._FECHA_INGRESO_ALM = aFECHA_INGRESO_ALM
        Me._NO_QUEDAN = aNO_QUEDAN
        Me._FECHA_QUEDAN = aFECHA_QUEDAN
        Me._USO = aUSO
        Me._USUARIO_APROB = aUSUARIO_APROB
        Me._FECHA_APROB = aFECHA_APROB
        Me._USUARIO_NOAPROB = aUSUARIO_NOAPROB
        Me._FECHA_NOAPROB = aFECHA_NOAPROB
        Me._USUARIO_ANUL = aUSUARIO_ANUL
        Me._FECHA_ANUL = aFECHA_ANUL
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
        Me._CODI_REQ = aCODI_REQ
        Me._ORDEN_LOCAL = aORDEN_LOCAL
        Me._FECHA_INGRESO_EST = aFECHA_INGRESO_EST
        Me._COMENTARIO_EST = aCOMENTARIO_EST
        Me._TOTAL_INGRESO_ALM = aTOTAL_INGRESO_ALM
        Me._AFECTO_INGRESO_ALM = aAFECTO_INGRESO_ALM
        Me._IVA_INGRESO_ALM = aIVA_INGRESO_ALM
        Me._TOTAL_QUEDAN = aTOTAL_QUEDAN
        Me._AFECTO_QUEDAN = aAFECTO_QUEDAN
        Me._IVA_QUEDAN = aIVA_QUEDAN
        Me._SECCION = aSECCION
        Me._EQUIPO = aEQUIPO
        Me._PROPOSITO = aPROPOSITO
        Me._COMPRA_LOCAL = aCOMPRA_LOCAL
        Me._FECHA_MAX_SUMIN = aFECHA_MAX_SUMIN
        Me._FECHA_RECIBOREQ = aFECHA_RECIBOREQ
        Me._PROVEE_INVITADOS = aPROVEE_INVITADOS
        Me._PROVEE_ADJUDICADO_ORDEN = aPROVEE_ADJUDICADO_ORDEN
        Me._FECHA_ESTI_INGRESO_ORDEN = aFECHA_ESTI_INGRESO_ORDEN
        Me._TIPO_DOCCOMPRA_ALM = aTIPO_DOCCOMPRA_ALM
        Me._NO_DOCCOMPRA_ALM = aNO_DOCCOMPRA_ALM
        Me._NO_CHEQUE_CHQ = aNO_CHEQUE_CHQ
        Me._BANCO_CHQ = aBANCO_CHQ
        Me._FECHA_CHQ = aFECHA_CHQ
        Me._MONTO_CHQ = aMONTO_CHQ
        Me._ID_REQETAPA = aID_REQETAPA
    End Sub

#Region " Properties "

    Private _ID_REQENCA As Int32
    <Column(Name:="Id reqenca", Storage:="ID_REQENCA", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_REQENCA() As Int32
        Get
            Return _ID_REQENCA
        End Get
        Set(ByVal Value As Int32)
            _ID_REQENCA = Value
            OnPropertyChanged("ID_REQENCA")
        End Set
    End Property 

    Private _ID_PERIODOREQ As Int32
    <Column(Name:="Id periodoreq", Storage:="ID_PERIODOREQ", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_PERIODOREQ() As Int32
        Get
            Return _ID_PERIODOREQ
        End Get
        Set(ByVal Value As Int32)
            _ID_PERIODOREQ = Value
            OnPropertyChanged("ID_PERIODOREQ")
        End Set
    End Property 

    Private _ID_PERIODOREQOld As Int32
    Public Property ID_PERIODOREQOld() As Int32
        Get
            Return _ID_PERIODOREQOld
        End Get
        Set(ByVal Value As Int32)
            _ID_PERIODOREQOld = Value
        End Set
    End Property 

    Private _fkID_PERIODOREQ As PERIODOREQ
    Public Property fkID_PERIODOREQ() As PERIODOREQ
        Get
            Return _fkID_PERIODOREQ
        End Get
        Set(ByVal Value As PERIODOREQ)
            _fkID_PERIODOREQ = Value
        End Set
    End Property 

    Private _ID_SECCION As Int32
    <Column(Name:="Id seccion", Storage:="ID_SECCION", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_SECCION() As Int32
        Get
            Return _ID_SECCION
        End Get
        Set(ByVal Value As Int32)
            _ID_SECCION = Value
            OnPropertyChanged("ID_SECCION")
        End Set
    End Property 

    Private _ID_SECCIONOld As Int32
    Public Property ID_SECCIONOld() As Int32
        Get
            Return _ID_SECCIONOld
        End Get
        Set(ByVal Value As Int32)
            _ID_SECCIONOld = Value
        End Set
    End Property 

    Private _fkID_SECCION As SECCION
    Public Property fkID_SECCION() As SECCION
        Get
            Return _fkID_SECCION
        End Get
        Set(ByVal Value As SECCION)
            _fkID_SECCION = Value
        End Set
    End Property 

    Private _ID_SOLICITANTE As Int32
    <Column(Name:="Id solicitante", Storage:="ID_SOLICITANTE", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_SOLICITANTE() As Int32
        Get
            Return _ID_SOLICITANTE
        End Get
        Set(ByVal Value As Int32)
            _ID_SOLICITANTE = Value
            OnPropertyChanged("ID_SOLICITANTE")
        End Set
    End Property 

    Private _ID_SOLICITANTEOld As Int32
    Public Property ID_SOLICITANTEOld() As Int32
        Get
            Return _ID_SOLICITANTEOld
        End Get
        Set(ByVal Value As Int32)
            _ID_SOLICITANTEOld = Value
        End Set
    End Property 

    Private _fkID_SOLICITANTE As SOLICITANTE
    Public Property fkID_SOLICITANTE() As SOLICITANTE
        Get
            Return _fkID_SOLICITANTE
        End Get
        Set(ByVal Value As SOLICITANTE)
            _fkID_SOLICITANTE = Value
        End Set
    End Property 

    Private _NO_REQ As Int32
    <Column(Name:="No req", Storage:="NO_REQ", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property NO_REQ() As Int32
        Get
            Return _NO_REQ
        End Get
        Set(ByVal Value As Int32)
            _NO_REQ = Value
            OnPropertyChanged("NO_REQ")
        End Set
    End Property 

    Private _NO_REQOld As Int32
    Public Property NO_REQOld() As Int32
        Get
            Return _NO_REQOld
        End Get
        Set(ByVal Value As Int32)
            _NO_REQOld = Value
        End Set
    End Property 

    Private _FECHA_EMISION As DateTime
    <Column(Name:="Fecha emision", Storage:="FECHA_EMISION", DbType:="DATETIME NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
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

    Private _NO_REQ_PH As String
    <Column(Name:="No req ph", Storage:="NO_REQ_PH", DbType:="VARCHAR(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
    Public Property NO_REQ_PH() As String
        Get
            Return _NO_REQ_PH
        End Get
        Set(ByVal Value As String)
            _NO_REQ_PH = Value
            OnPropertyChanged("NO_REQ_PH")
        End Set
    End Property 

    Private _NO_REQ_PHOld As String
    Public Property NO_REQ_PHOld() As String
        Get
            Return _NO_REQ_PHOld
        End Get
        Set(ByVal Value As String)
            _NO_REQ_PHOld = Value
        End Set
    End Property 

    Private _FECHA_REQ_PH As DateTime
    <Column(Name:="Fecha req ph", Storage:="FECHA_REQ_PH", DbType:="DATETIME", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_REQ_PH() As DateTime
        Get
            Return _FECHA_REQ_PH
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_REQ_PH = Value
            OnPropertyChanged("FECHA_REQ_PH")
        End Set
    End Property 

    Private _FECHA_REQ_PHOld As DateTime
    Public Property FECHA_REQ_PHOld() As DateTime
        Get
            Return _FECHA_REQ_PHOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_REQ_PHOld = Value
        End Set
    End Property 

    Private _NO_ORDEN_PH As String
    <Column(Name:="No orden ph", Storage:="NO_ORDEN_PH", DbType:="VARCHAR(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
    Public Property NO_ORDEN_PH() As String
        Get
            Return _NO_ORDEN_PH
        End Get
        Set(ByVal Value As String)
            _NO_ORDEN_PH = Value
            OnPropertyChanged("NO_ORDEN_PH")
        End Set
    End Property 

    Private _NO_ORDEN_PHOld As String
    Public Property NO_ORDEN_PHOld() As String
        Get
            Return _NO_ORDEN_PHOld
        End Get
        Set(ByVal Value As String)
            _NO_ORDEN_PHOld = Value
        End Set
    End Property 

    Private _FECHA_ORDEN_PH As DateTime
    <Column(Name:="Fecha orden ph", Storage:="FECHA_ORDEN_PH", DbType:="DATETIME", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_ORDEN_PH() As DateTime
        Get
            Return _FECHA_ORDEN_PH
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_ORDEN_PH = Value
            OnPropertyChanged("FECHA_ORDEN_PH")
        End Set
    End Property 

    Private _FECHA_ORDEN_PHOld As DateTime
    Public Property FECHA_ORDEN_PHOld() As DateTime
        Get
            Return _FECHA_ORDEN_PHOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_ORDEN_PHOld = Value
        End Set
    End Property 

    Private _TOTAL_ORDEN_PH As Decimal
    <Column(Name:="Total orden ph", Storage:="TOTAL_ORDEN_PH", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property TOTAL_ORDEN_PH() As Decimal
        Get
            Return _TOTAL_ORDEN_PH
        End Get
        Set(ByVal Value As Decimal)
            _TOTAL_ORDEN_PH = Value
            OnPropertyChanged("TOTAL_ORDEN_PH")
        End Set
    End Property 

    Private _TOTAL_ORDEN_PHOld As Decimal
    Public Property TOTAL_ORDEN_PHOld() As Decimal
        Get
            Return _TOTAL_ORDEN_PHOld
        End Get
        Set(ByVal Value As Decimal)
            _TOTAL_ORDEN_PHOld = Value
        End Set
    End Property 

    Private _AFECTO_ORDEN_PH As Decimal
    <Column(Name:="Afecto orden ph", Storage:="AFECTO_ORDEN_PH", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property AFECTO_ORDEN_PH() As Decimal
        Get
            Return _AFECTO_ORDEN_PH
        End Get
        Set(ByVal Value As Decimal)
            _AFECTO_ORDEN_PH = Value
            OnPropertyChanged("AFECTO_ORDEN_PH")
        End Set
    End Property 

    Private _AFECTO_ORDEN_PHOld As Decimal
    Public Property AFECTO_ORDEN_PHOld() As Decimal
        Get
            Return _AFECTO_ORDEN_PHOld
        End Get
        Set(ByVal Value As Decimal)
            _AFECTO_ORDEN_PHOld = Value
        End Set
    End Property 

    Private _IVA_ORDEN_PH As Decimal
    <Column(Name:="Iva orden ph", Storage:="IVA_ORDEN_PH", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property IVA_ORDEN_PH() As Decimal
        Get
            Return _IVA_ORDEN_PH
        End Get
        Set(ByVal Value As Decimal)
            _IVA_ORDEN_PH = Value
            OnPropertyChanged("IVA_ORDEN_PH")
        End Set
    End Property 

    Private _IVA_ORDEN_PHOld As Decimal
    Public Property IVA_ORDEN_PHOld() As Decimal
        Get
            Return _IVA_ORDEN_PHOld
        End Get
        Set(ByVal Value As Decimal)
            _IVA_ORDEN_PHOld = Value
        End Set
    End Property 

    Private _NO_INGRESO_ALM As String
    <Column(Name:="No ingreso alm", Storage:="NO_INGRESO_ALM", DbType:="VARCHAR(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
    Public Property NO_INGRESO_ALM() As String
        Get
            Return _NO_INGRESO_ALM
        End Get
        Set(ByVal Value As String)
            _NO_INGRESO_ALM = Value
            OnPropertyChanged("NO_INGRESO_ALM")
        End Set
    End Property 

    Private _NO_INGRESO_ALMOld As String
    Public Property NO_INGRESO_ALMOld() As String
        Get
            Return _NO_INGRESO_ALMOld
        End Get
        Set(ByVal Value As String)
            _NO_INGRESO_ALMOld = Value
        End Set
    End Property 

    Private _FECHA_INGRESO_ALM As DateTime
    <Column(Name:="Fecha ingreso alm", Storage:="FECHA_INGRESO_ALM", DbType:="DATETIME", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_INGRESO_ALM() As DateTime
        Get
            Return _FECHA_INGRESO_ALM
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_INGRESO_ALM = Value
            OnPropertyChanged("FECHA_INGRESO_ALM")
        End Set
    End Property 

    Private _FECHA_INGRESO_ALMOld As DateTime
    Public Property FECHA_INGRESO_ALMOld() As DateTime
        Get
            Return _FECHA_INGRESO_ALMOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_INGRESO_ALMOld = Value
        End Set
    End Property 

    Private _NO_QUEDAN As String
    <Column(Name:="No quedan", Storage:="NO_QUEDAN", DbType:="VARCHAR(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
    Public Property NO_QUEDAN() As String
        Get
            Return _NO_QUEDAN
        End Get
        Set(ByVal Value As String)
            _NO_QUEDAN = Value
            OnPropertyChanged("NO_QUEDAN")
        End Set
    End Property 

    Private _NO_QUEDANOld As String
    Public Property NO_QUEDANOld() As String
        Get
            Return _NO_QUEDANOld
        End Get
        Set(ByVal Value As String)
            _NO_QUEDANOld = Value
        End Set
    End Property 

    Private _FECHA_QUEDAN As DateTime
    <Column(Name:="Fecha quedan", Storage:="FECHA_QUEDAN", DbType:="DATETIME", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_QUEDAN() As DateTime
        Get
            Return _FECHA_QUEDAN
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_QUEDAN = Value
            OnPropertyChanged("FECHA_QUEDAN")
        End Set
    End Property 

    Private _FECHA_QUEDANOld As DateTime
    Public Property FECHA_QUEDANOld() As DateTime
        Get
            Return _FECHA_QUEDANOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_QUEDANOld = Value
        End Set
    End Property 

    Private _USO As String
    <Column(Name:="Uso", Storage:="USO", DbType:="VARCHAR(2000)", Id:=False), _
     DataObjectField(False, False, True, 2000)> _
    Public Property USO() As String
        Get
            Return _USO
        End Get
        Set(ByVal Value As String)
            _USO = Value
            OnPropertyChanged("USO")
        End Set
    End Property 

    Private _USOOld As String
    Public Property USOOld() As String
        Get
            Return _USOOld
        End Get
        Set(ByVal Value As String)
            _USOOld = Value
        End Set
    End Property 

    Private _USUARIO_APROB As String
    <Column(Name:="Usuario aprob", Storage:="USUARIO_APROB", DbType:="VARCHAR(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
    Public Property USUARIO_APROB() As String
        Get
            Return _USUARIO_APROB
        End Get
        Set(ByVal Value As String)
            _USUARIO_APROB = Value
            OnPropertyChanged("USUARIO_APROB")
        End Set
    End Property 

    Private _USUARIO_APROBOld As String
    Public Property USUARIO_APROBOld() As String
        Get
            Return _USUARIO_APROBOld
        End Get
        Set(ByVal Value As String)
            _USUARIO_APROBOld = Value
        End Set
    End Property 

    Private _FECHA_APROB As DateTime
    <Column(Name:="Fecha aprob", Storage:="FECHA_APROB", DbType:="DATETIME", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_APROB() As DateTime
        Get
            Return _FECHA_APROB
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_APROB = Value
            OnPropertyChanged("FECHA_APROB")
        End Set
    End Property 

    Private _FECHA_APROBOld As DateTime
    Public Property FECHA_APROBOld() As DateTime
        Get
            Return _FECHA_APROBOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_APROBOld = Value
        End Set
    End Property 

    Private _USUARIO_NOAPROB As String
    <Column(Name:="Usuario noaprob", Storage:="USUARIO_NOAPROB", DbType:="VARCHAR(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
    Public Property USUARIO_NOAPROB() As String
        Get
            Return _USUARIO_NOAPROB
        End Get
        Set(ByVal Value As String)
            _USUARIO_NOAPROB = Value
            OnPropertyChanged("USUARIO_NOAPROB")
        End Set
    End Property 

    Private _USUARIO_NOAPROBOld As String
    Public Property USUARIO_NOAPROBOld() As String
        Get
            Return _USUARIO_NOAPROBOld
        End Get
        Set(ByVal Value As String)
            _USUARIO_NOAPROBOld = Value
        End Set
    End Property 

    Private _FECHA_NOAPROB As DateTime
    <Column(Name:="Fecha noaprob", Storage:="FECHA_NOAPROB", DbType:="DATETIME", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_NOAPROB() As DateTime
        Get
            Return _FECHA_NOAPROB
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_NOAPROB = Value
            OnPropertyChanged("FECHA_NOAPROB")
        End Set
    End Property 

    Private _FECHA_NOAPROBOld As DateTime
    Public Property FECHA_NOAPROBOld() As DateTime
        Get
            Return _FECHA_NOAPROBOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_NOAPROBOld = Value
        End Set
    End Property 

    Private _USUARIO_ANUL As String
    <Column(Name:="Usuario anul", Storage:="USUARIO_ANUL", DbType:="VARCHAR(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
    Public Property USUARIO_ANUL() As String
        Get
            Return _USUARIO_ANUL
        End Get
        Set(ByVal Value As String)
            _USUARIO_ANUL = Value
            OnPropertyChanged("USUARIO_ANUL")
        End Set
    End Property 

    Private _USUARIO_ANULOld As String
    Public Property USUARIO_ANULOld() As String
        Get
            Return _USUARIO_ANULOld
        End Get
        Set(ByVal Value As String)
            _USUARIO_ANULOld = Value
        End Set
    End Property 

    Private _FECHA_ANUL As DateTime
    <Column(Name:="Fecha anul", Storage:="FECHA_ANUL", DbType:="DATETIME", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_ANUL() As DateTime
        Get
            Return _FECHA_ANUL
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_ANUL = Value
            OnPropertyChanged("FECHA_ANUL")
        End Set
    End Property 

    Private _FECHA_ANULOld As DateTime
    Public Property FECHA_ANULOld() As DateTime
        Get
            Return _FECHA_ANULOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_ANULOld = Value
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

    Private _CODI_REQ As String
    <Column(Name:="Codi req", Storage:="CODI_REQ", DbType:="CHAR(20)", Id:=False), _
     DataObjectField(False, False, True, 20)> _
    Public Property CODI_REQ() As String
        Get
            Return _CODI_REQ
        End Get
        Set(ByVal Value As String)
            _CODI_REQ = Value
            OnPropertyChanged("CODI_REQ")
        End Set
    End Property 

    Private _CODI_REQOld As String
    Public Property CODI_REQOld() As String
        Get
            Return _CODI_REQOld
        End Get
        Set(ByVal Value As String)
            _CODI_REQOld = Value
        End Set
    End Property 

    Private _ORDEN_LOCAL As Boolean
    <Column(Name:="Orden local", Storage:="ORDEN_LOCAL", DbType:="BIT", Id:=False), _
     DataObjectField(False, False, True, 1)> _
    Public Property ORDEN_LOCAL() As Boolean
        Get
            Return _ORDEN_LOCAL
        End Get
        Set(ByVal Value As Boolean)
            _ORDEN_LOCAL = Value
            OnPropertyChanged("ORDEN_LOCAL")
        End Set
    End Property 

    Private _ORDEN_LOCALOld As Boolean
    Public Property ORDEN_LOCALOld() As Boolean
        Get
            Return _ORDEN_LOCALOld
        End Get
        Set(ByVal Value As Boolean)
            _ORDEN_LOCALOld = Value
        End Set
    End Property 

    Private _FECHA_INGRESO_EST As DateTime
    <Column(Name:="Fecha ingreso est", Storage:="FECHA_INGRESO_EST", DbType:="DATETIME", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_INGRESO_EST() As DateTime
        Get
            Return _FECHA_INGRESO_EST
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_INGRESO_EST = Value
            OnPropertyChanged("FECHA_INGRESO_EST")
        End Set
    End Property 

    Private _FECHA_INGRESO_ESTOld As DateTime
    Public Property FECHA_INGRESO_ESTOld() As DateTime
        Get
            Return _FECHA_INGRESO_ESTOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_INGRESO_ESTOld = Value
        End Set
    End Property 

    Private _COMENTARIO_EST As String
    <Column(Name:="Comentario est", Storage:="COMENTARIO_EST", DbType:="VARCHAR(1000)", Id:=False), _
     DataObjectField(False, False, True, 1000)> _
    Public Property COMENTARIO_EST() As String
        Get
            Return _COMENTARIO_EST
        End Get
        Set(ByVal Value As String)
            _COMENTARIO_EST = Value
            OnPropertyChanged("COMENTARIO_EST")
        End Set
    End Property 

    Private _COMENTARIO_ESTOld As String
    Public Property COMENTARIO_ESTOld() As String
        Get
            Return _COMENTARIO_ESTOld
        End Get
        Set(ByVal Value As String)
            _COMENTARIO_ESTOld = Value
        End Set
    End Property 

    Private _TOTAL_INGRESO_ALM As Decimal
    <Column(Name:="Total ingreso alm", Storage:="TOTAL_INGRESO_ALM", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property TOTAL_INGRESO_ALM() As Decimal
        Get
            Return _TOTAL_INGRESO_ALM
        End Get
        Set(ByVal Value As Decimal)
            _TOTAL_INGRESO_ALM = Value
            OnPropertyChanged("TOTAL_INGRESO_ALM")
        End Set
    End Property 

    Private _TOTAL_INGRESO_ALMOld As Decimal
    Public Property TOTAL_INGRESO_ALMOld() As Decimal
        Get
            Return _TOTAL_INGRESO_ALMOld
        End Get
        Set(ByVal Value As Decimal)
            _TOTAL_INGRESO_ALMOld = Value
        End Set
    End Property 

    Private _AFECTO_INGRESO_ALM As Decimal
    <Column(Name:="Afecto ingreso alm", Storage:="AFECTO_INGRESO_ALM", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property AFECTO_INGRESO_ALM() As Decimal
        Get
            Return _AFECTO_INGRESO_ALM
        End Get
        Set(ByVal Value As Decimal)
            _AFECTO_INGRESO_ALM = Value
            OnPropertyChanged("AFECTO_INGRESO_ALM")
        End Set
    End Property 

    Private _AFECTO_INGRESO_ALMOld As Decimal
    Public Property AFECTO_INGRESO_ALMOld() As Decimal
        Get
            Return _AFECTO_INGRESO_ALMOld
        End Get
        Set(ByVal Value As Decimal)
            _AFECTO_INGRESO_ALMOld = Value
        End Set
    End Property 

    Private _IVA_INGRESO_ALM As Decimal
    <Column(Name:="Iva ingreso alm", Storage:="IVA_INGRESO_ALM", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property IVA_INGRESO_ALM() As Decimal
        Get
            Return _IVA_INGRESO_ALM
        End Get
        Set(ByVal Value As Decimal)
            _IVA_INGRESO_ALM = Value
            OnPropertyChanged("IVA_INGRESO_ALM")
        End Set
    End Property 

    Private _IVA_INGRESO_ALMOld As Decimal
    Public Property IVA_INGRESO_ALMOld() As Decimal
        Get
            Return _IVA_INGRESO_ALMOld
        End Get
        Set(ByVal Value As Decimal)
            _IVA_INGRESO_ALMOld = Value
        End Set
    End Property 

    Private _TOTAL_QUEDAN As Decimal
    <Column(Name:="Total quedan", Storage:="TOTAL_QUEDAN", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property TOTAL_QUEDAN() As Decimal
        Get
            Return _TOTAL_QUEDAN
        End Get
        Set(ByVal Value As Decimal)
            _TOTAL_QUEDAN = Value
            OnPropertyChanged("TOTAL_QUEDAN")
        End Set
    End Property 

    Private _TOTAL_QUEDANOld As Decimal
    Public Property TOTAL_QUEDANOld() As Decimal
        Get
            Return _TOTAL_QUEDANOld
        End Get
        Set(ByVal Value As Decimal)
            _TOTAL_QUEDANOld = Value
        End Set
    End Property 

    Private _AFECTO_QUEDAN As Decimal
    <Column(Name:="Afecto quedan", Storage:="AFECTO_QUEDAN", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property AFECTO_QUEDAN() As Decimal
        Get
            Return _AFECTO_QUEDAN
        End Get
        Set(ByVal Value As Decimal)
            _AFECTO_QUEDAN = Value
            OnPropertyChanged("AFECTO_QUEDAN")
        End Set
    End Property 

    Private _AFECTO_QUEDANOld As Decimal
    Public Property AFECTO_QUEDANOld() As Decimal
        Get
            Return _AFECTO_QUEDANOld
        End Get
        Set(ByVal Value As Decimal)
            _AFECTO_QUEDANOld = Value
        End Set
    End Property 

    Private _IVA_QUEDAN As Decimal
    <Column(Name:="Iva quedan", Storage:="IVA_QUEDAN", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property IVA_QUEDAN() As Decimal
        Get
            Return _IVA_QUEDAN
        End Get
        Set(ByVal Value As Decimal)
            _IVA_QUEDAN = Value
            OnPropertyChanged("IVA_QUEDAN")
        End Set
    End Property 

    Private _IVA_QUEDANOld As Decimal
    Public Property IVA_QUEDANOld() As Decimal
        Get
            Return _IVA_QUEDANOld
        End Get
        Set(ByVal Value As Decimal)
            _IVA_QUEDANOld = Value
        End Set
    End Property 

    Private _SECCION As String
    <Column(Name:="Seccion", Storage:="SECCION", DbType:="VARCHAR(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
    Public Property SECCION() As String
        Get
            Return _SECCION
        End Get
        Set(ByVal Value As String)
            _SECCION = Value
            OnPropertyChanged("SECCION")
        End Set
    End Property 

    Private _SECCIONOld As String
    Public Property SECCIONOld() As String
        Get
            Return _SECCIONOld
        End Get
        Set(ByVal Value As String)
            _SECCIONOld = Value
        End Set
    End Property 

    Private _EQUIPO As String
    <Column(Name:="Equipo", Storage:="EQUIPO", DbType:="VARCHAR(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
    Public Property EQUIPO() As String
        Get
            Return _EQUIPO
        End Get
        Set(ByVal Value As String)
            _EQUIPO = Value
            OnPropertyChanged("EQUIPO")
        End Set
    End Property 

    Private _EQUIPOOld As String
    Public Property EQUIPOOld() As String
        Get
            Return _EQUIPOOld
        End Get
        Set(ByVal Value As String)
            _EQUIPOOld = Value
        End Set
    End Property 

    Private _PROPOSITO As Int32
    <Column(Name:="Proposito", Storage:="PROPOSITO", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property PROPOSITO() As Int32
        Get
            Return _PROPOSITO
        End Get
        Set(ByVal Value As Int32)
            _PROPOSITO = Value
            OnPropertyChanged("PROPOSITO")
        End Set
    End Property 

    Private _PROPOSITOOld As Int32
    Public Property PROPOSITOOld() As Int32
        Get
            Return _PROPOSITOOld
        End Get
        Set(ByVal Value As Int32)
            _PROPOSITOOld = Value
        End Set
    End Property 

    Private _COMPRA_LOCAL As Boolean
    <Column(Name:="Compra local", Storage:="COMPRA_LOCAL", DbType:="BIT", Id:=False), _
     DataObjectField(False, False, True, 1)> _
    Public Property COMPRA_LOCAL() As Boolean
        Get
            Return _COMPRA_LOCAL
        End Get
        Set(ByVal Value As Boolean)
            _COMPRA_LOCAL = Value
            OnPropertyChanged("COMPRA_LOCAL")
        End Set
    End Property 

    Private _COMPRA_LOCALOld As Boolean
    Public Property COMPRA_LOCALOld() As Boolean
        Get
            Return _COMPRA_LOCALOld
        End Get
        Set(ByVal Value As Boolean)
            _COMPRA_LOCALOld = Value
        End Set
    End Property 

    Private _FECHA_MAX_SUMIN As DateTime
    <Column(Name:="Fecha max sumin", Storage:="FECHA_MAX_SUMIN", DbType:="DATETIME", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_MAX_SUMIN() As DateTime
        Get
            Return _FECHA_MAX_SUMIN
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_MAX_SUMIN = Value
            OnPropertyChanged("FECHA_MAX_SUMIN")
        End Set
    End Property 

    Private _FECHA_MAX_SUMINOld As DateTime
    Public Property FECHA_MAX_SUMINOld() As DateTime
        Get
            Return _FECHA_MAX_SUMINOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_MAX_SUMINOld = Value
        End Set
    End Property 

    Private _FECHA_RECIBOREQ As DateTime
    <Column(Name:="Fecha reciboreq", Storage:="FECHA_RECIBOREQ", DbType:="DATETIME", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_RECIBOREQ() As DateTime
        Get
            Return _FECHA_RECIBOREQ
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_RECIBOREQ = Value
            OnPropertyChanged("FECHA_RECIBOREQ")
        End Set
    End Property 

    Private _FECHA_RECIBOREQOld As DateTime
    Public Property FECHA_RECIBOREQOld() As DateTime
        Get
            Return _FECHA_RECIBOREQOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_RECIBOREQOld = Value
        End Set
    End Property 

    Private _PROVEE_INVITADOS As String
    <Column(Name:="Provee invitados", Storage:="PROVEE_INVITADOS", DbType:="VARCHAR(2000)", Id:=False), _
     DataObjectField(False, False, True, 2000)> _
    Public Property PROVEE_INVITADOS() As String
        Get
            Return _PROVEE_INVITADOS
        End Get
        Set(ByVal Value As String)
            _PROVEE_INVITADOS = Value
            OnPropertyChanged("PROVEE_INVITADOS")
        End Set
    End Property 

    Private _PROVEE_INVITADOSOld As String
    Public Property PROVEE_INVITADOSOld() As String
        Get
            Return _PROVEE_INVITADOSOld
        End Get
        Set(ByVal Value As String)
            _PROVEE_INVITADOSOld = Value
        End Set
    End Property 

    Private _PROVEE_ADJUDICADO_ORDEN As String
    <Column(Name:="Provee adjudicado orden", Storage:="PROVEE_ADJUDICADO_ORDEN", DbType:="VARCHAR(300)", Id:=False), _
     DataObjectField(False, False, True, 300)> _
    Public Property PROVEE_ADJUDICADO_ORDEN() As String
        Get
            Return _PROVEE_ADJUDICADO_ORDEN
        End Get
        Set(ByVal Value As String)
            _PROVEE_ADJUDICADO_ORDEN = Value
            OnPropertyChanged("PROVEE_ADJUDICADO_ORDEN")
        End Set
    End Property 

    Private _PROVEE_ADJUDICADO_ORDENOld As String
    Public Property PROVEE_ADJUDICADO_ORDENOld() As String
        Get
            Return _PROVEE_ADJUDICADO_ORDENOld
        End Get
        Set(ByVal Value As String)
            _PROVEE_ADJUDICADO_ORDENOld = Value
        End Set
    End Property 

    Private _FECHA_ESTI_INGRESO_ORDEN As DateTime
    <Column(Name:="Fecha esti ingreso orden", Storage:="FECHA_ESTI_INGRESO_ORDEN", DbType:="DATETIME", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_ESTI_INGRESO_ORDEN() As DateTime
        Get
            Return _FECHA_ESTI_INGRESO_ORDEN
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_ESTI_INGRESO_ORDEN = Value
            OnPropertyChanged("FECHA_ESTI_INGRESO_ORDEN")
        End Set
    End Property 

    Private _FECHA_ESTI_INGRESO_ORDENOld As DateTime
    Public Property FECHA_ESTI_INGRESO_ORDENOld() As DateTime
        Get
            Return _FECHA_ESTI_INGRESO_ORDENOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_ESTI_INGRESO_ORDENOld = Value
        End Set
    End Property 

    Private _TIPO_DOCCOMPRA_ALM As Int32
    <Column(Name:="Tipo doccompra alm", Storage:="TIPO_DOCCOMPRA_ALM", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property TIPO_DOCCOMPRA_ALM() As Int32
        Get
            Return _TIPO_DOCCOMPRA_ALM
        End Get
        Set(ByVal Value As Int32)
            _TIPO_DOCCOMPRA_ALM = Value
            OnPropertyChanged("TIPO_DOCCOMPRA_ALM")
        End Set
    End Property 

    Private _TIPO_DOCCOMPRA_ALMOld As Int32
    Public Property TIPO_DOCCOMPRA_ALMOld() As Int32
        Get
            Return _TIPO_DOCCOMPRA_ALMOld
        End Get
        Set(ByVal Value As Int32)
            _TIPO_DOCCOMPRA_ALMOld = Value
        End Set
    End Property 

    Private _NO_DOCCOMPRA_ALM As String
    <Column(Name:="No doccompra alm", Storage:="NO_DOCCOMPRA_ALM", DbType:="VARCHAR(50)", Id:=False), _
   DataObjectField(False, False, True, 50)> _
    Public Property NO_DOCCOMPRA_ALM() As String
        Get
            Return _NO_DOCCOMPRA_ALM
        End Get
        Set(ByVal Value As String)
            _NO_DOCCOMPRA_ALM = Value
            OnPropertyChanged("NO_DOCCOMPRA_ALM")
        End Set
    End Property

    Private _NO_DOCCOMPRA_ALMOld As String
    Public Property NO_DOCCOMPRA_ALMOld() As String
        Get
            Return _NO_DOCCOMPRA_ALMOld
        End Get
        Set(ByVal Value As String)
            _NO_DOCCOMPRA_ALMOld = Value
        End Set
    End Property

    Private _NO_CHEQUE_CHQ As String
    <Column(Name:="No cheque chq", Storage:="NO_CHEQUE_CHQ", DbType:="VARCHAR(50)", Id:=False), _
     DataObjectField(False, False, True, 50)> _
    Public Property NO_CHEQUE_CHQ() As String
        Get
            Return _NO_CHEQUE_CHQ
        End Get
        Set(ByVal Value As String)
            _NO_CHEQUE_CHQ = Value
            OnPropertyChanged("NO_CHEQUE_CHQ")
        End Set
    End Property 

    Private _NO_CHEQUE_CHQOld As String
    Public Property NO_CHEQUE_CHQOld() As String
        Get
            Return _NO_CHEQUE_CHQOld
        End Get
        Set(ByVal Value As String)
            _NO_CHEQUE_CHQOld = Value
        End Set
    End Property 

    Private _BANCO_CHQ As String
    <Column(Name:="Banco chq", Storage:="BANCO_CHQ", DbType:="VARCHAR(150)", Id:=False), _
     DataObjectField(False, False, True, 150)> _
    Public Property BANCO_CHQ() As String
        Get
            Return _BANCO_CHQ
        End Get
        Set(ByVal Value As String)
            _BANCO_CHQ = Value
            OnPropertyChanged("BANCO_CHQ")
        End Set
    End Property 

    Private _BANCO_CHQOld As String
    Public Property BANCO_CHQOld() As String
        Get
            Return _BANCO_CHQOld
        End Get
        Set(ByVal Value As String)
            _BANCO_CHQOld = Value
        End Set
    End Property 

    Private _FECHA_CHQ As DateTime
    <Column(Name:="Fecha chq", Storage:="FECHA_CHQ", DbType:="DATETIME", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_CHQ() As DateTime
        Get
            Return _FECHA_CHQ
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_CHQ = Value
            OnPropertyChanged("FECHA_CHQ")
        End Set
    End Property 

    Private _FECHA_CHQOld As DateTime
    Public Property FECHA_CHQOld() As DateTime
        Get
            Return _FECHA_CHQOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_CHQOld = Value
        End Set
    End Property 

    Private _MONTO_CHQ As Decimal
    <Column(Name:="Monto chq", Storage:="MONTO_CHQ", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property MONTO_CHQ() As Decimal
        Get
            Return _MONTO_CHQ
        End Get
        Set(ByVal Value As Decimal)
            _MONTO_CHQ = Value
            OnPropertyChanged("MONTO_CHQ")
        End Set
    End Property 

    Private _MONTO_CHQOld As Decimal
    Public Property MONTO_CHQOld() As Decimal
        Get
            Return _MONTO_CHQOld
        End Get
        Set(ByVal Value As Decimal)
            _MONTO_CHQOld = Value
        End Set
    End Property 

    Private _ID_REQETAPA As Int32
    <Column(Name:="Id reqetapa", Storage:="ID_REQETAPA", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_REQETAPA() As Int32
        Get
            Return _ID_REQETAPA
        End Get
        Set(ByVal Value As Int32)
            _ID_REQETAPA = Value
            OnPropertyChanged("ID_REQETAPA")
        End Set
    End Property 

    Private _ID_REQETAPAOld As Int32
    Public Property ID_REQETAPAOld() As Int32
        Get
            Return _ID_REQETAPAOld
        End Get
        Set(ByVal Value As Int32)
            _ID_REQETAPAOld = Value
        End Set
    End Property 

    Private _fkID_REQETAPA As REQETAPA
    Public Property fkID_REQETAPA() As REQETAPA
        Get
            Return _fkID_REQETAPA
        End Get
        Set(ByVal Value As REQETAPA)
            _fkID_REQETAPA = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
