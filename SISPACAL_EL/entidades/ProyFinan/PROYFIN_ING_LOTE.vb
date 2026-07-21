''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.PROYFIN_ING_LOTE
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row PROYFIN_ING_LOTE en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	23/01/2020	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="PROYFIN_ING_LOTE")> Public Class PROYFIN_ING_LOTE
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_PROYFIN_ING_LOTE As Int32, aID_PROYFIN_ING As Int32, aACCESLOTE As String, aNO_CONTRATO As Int32, aCICLO As Int32, aCICLO1 As Int32, aMZ1 As Decimal, aTC_MZ1 As Decimal, aTC1 As Decimal, aREND1 As Decimal, aLBS1 As Decimal, aCICLO2 As Int32, aMZ2 As Decimal, aTC_MZ2 As Decimal, aTC2 As Decimal, aREND2 As Decimal, aLBS2 As Decimal, aCICLO3 As Int32, aMZ3 As Decimal, aTC_MZ3 As Decimal, aTC3 As Decimal, aREND3 As Decimal, aLBS3 As Decimal, aCICLO4 As Int32, aMZ4 As Decimal, aTC_MZ4 As Decimal, aTC4 As Decimal, aREND4 As Decimal, aLBS4 As Decimal, aCICLO5 As Int32, aMZ5 As Decimal, aTC_MZ5 As Decimal, aTC5 As Decimal, aREND5 As Decimal, aLBS5 As Decimal, aCICLO6 As Int32, aMZ6 As Decimal, aTC_MZ6 As Decimal, aTC6 As Decimal, aREND6 As Decimal, aLBS6 As Decimal, aCICLO7 As Int32, aMZ7 As Decimal, aTC_MZ7 As Decimal, aTC7 As Decimal, aREND7 As Decimal, aLBS7 As Decimal)
        Me._ID_PROYFIN_ING_LOTE = aID_PROYFIN_ING_LOTE
        Me._ID_PROYFIN_ING = aID_PROYFIN_ING
        Me._ACCESLOTE = aACCESLOTE
        Me._NO_CONTRATO = aNO_CONTRATO
        Me._CICLO = aCICLO
        Me._CICLO1 = aCICLO1
        Me._MZ1 = aMZ1
        Me._TC_MZ1 = aTC_MZ1
        Me._TC1 = aTC1
        Me._REND1 = aREND1
        Me._LBS1 = aLBS1
        Me._CICLO2 = aCICLO2
        Me._MZ2 = aMZ2
        Me._TC_MZ2 = aTC_MZ2
        Me._TC2 = aTC2
        Me._REND2 = aREND2
        Me._LBS2 = aLBS2
        Me._CICLO3 = aCICLO3
        Me._MZ3 = aMZ3
        Me._TC_MZ3 = aTC_MZ3
        Me._TC3 = aTC3
        Me._REND3 = aREND3
        Me._LBS3 = aLBS3
        Me._CICLO4 = aCICLO4
        Me._MZ4 = aMZ4
        Me._TC_MZ4 = aTC_MZ4
        Me._TC4 = aTC4
        Me._REND4 = aREND4
        Me._LBS4 = aLBS4
        Me._CICLO5 = aCICLO5
        Me._MZ5 = aMZ5
        Me._TC_MZ5 = aTC_MZ5
        Me._TC5 = aTC5
        Me._REND5 = aREND5
        Me._LBS5 = aLBS5
        Me._CICLO6 = aCICLO6
        Me._MZ6 = aMZ6
        Me._TC_MZ6 = aTC_MZ6
        Me._TC6 = aTC6
        Me._REND6 = aREND6
        Me._LBS6 = aLBS6
        Me._CICLO7 = aCICLO7
        Me._MZ7 = aMZ7
        Me._TC_MZ7 = aTC_MZ7
        Me._TC7 = aTC7
        Me._REND7 = aREND7
        Me._LBS7 = aLBS7
    End Sub

#Region " Properties "

    Private _ID_PROYFIN_ING_LOTE As Int32
    <Column(Name:="Id proyfin ing lote", Storage:="ID_PROYFIN_ING_LOTE", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_PROYFIN_ING_LOTE() As Int32
        Get
            Return _ID_PROYFIN_ING_LOTE
        End Get
        Set(ByVal Value As Int32)
            _ID_PROYFIN_ING_LOTE = Value
            OnPropertyChanged("ID_PROYFIN_ING_LOTE")
        End Set
    End Property 

    Private _ID_PROYFIN_ING As Int32
    <Column(Name:="Id proyfin ing", Storage:="ID_PROYFIN_ING", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_PROYFIN_ING() As Int32
        Get
            Return _ID_PROYFIN_ING
        End Get
        Set(ByVal Value As Int32)
            _ID_PROYFIN_ING = Value
            OnPropertyChanged("ID_PROYFIN_ING")
        End Set
    End Property 

    Private _ID_PROYFIN_INGOld As Int32
    Public Property ID_PROYFIN_INGOld() As Int32
        Get
            Return _ID_PROYFIN_INGOld
        End Get
        Set(ByVal Value As Int32)
            _ID_PROYFIN_INGOld = Value
        End Set
    End Property 

    Private _fkID_PROYFIN_ING As PROYFIN_ING
    Public Property fkID_PROYFIN_ING() As PROYFIN_ING
        Get
            Return _fkID_PROYFIN_ING
        End Get
        Set(ByVal Value As PROYFIN_ING)
            _fkID_PROYFIN_ING = Value
        End Set
    End Property 

    Private _ACCESLOTE As String
    <Column(Name:="Acceslote", Storage:="ACCESLOTE", DbType:="CHAR(21)", Id:=False), _
     DataObjectField(False, False, True, 21)> _
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

    Private _NO_CONTRATO As Int32
    <Column(Name:="No contrato", Storage:="NO_CONTRATO", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property NO_CONTRATO() As Int32
        Get
            Return _NO_CONTRATO
        End Get
        Set(ByVal Value As Int32)
            _NO_CONTRATO = Value
            OnPropertyChanged("NO_CONTRATO")
        End Set
    End Property 

    Private _NO_CONTRATOOld As Int32
    Public Property NO_CONTRATOOld() As Int32
        Get
            Return _NO_CONTRATOOld
        End Get
        Set(ByVal Value As Int32)
            _NO_CONTRATOOld = Value
        End Set
    End Property 

    Private _CICLO As Int32
    <Column(Name:="Ciclo", Storage:="CICLO", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property CICLO() As Int32
        Get
            Return _CICLO
        End Get
        Set(ByVal Value As Int32)
            _CICLO = Value
            OnPropertyChanged("CICLO")
        End Set
    End Property 

    Private _CICLOOld As Int32
    Public Property CICLOOld() As Int32
        Get
            Return _CICLOOld
        End Get
        Set(ByVal Value As Int32)
            _CICLOOld = Value
        End Set
    End Property 

    Private _CICLO1 As Int32
    <Column(Name:="Ciclo1", Storage:="CICLO1", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property CICLO1() As Int32
        Get
            Return _CICLO1
        End Get
        Set(ByVal Value As Int32)
            _CICLO1 = Value
            OnPropertyChanged("CICLO1")
        End Set
    End Property 

    Private _CICLO1Old As Int32
    Public Property CICLO1Old() As Int32
        Get
            Return _CICLO1Old
        End Get
        Set(ByVal Value As Int32)
            _CICLO1Old = Value
        End Set
    End Property 

    Private _MZ1 As Decimal
    <Column(Name:="Mz1", Storage:="MZ1", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property MZ1() As Decimal
        Get
            Return _MZ1
        End Get
        Set(ByVal Value As Decimal)
            _MZ1 = Value
            OnPropertyChanged("MZ1")
        End Set
    End Property 

    Private _MZ1Old As Decimal
    Public Property MZ1Old() As Decimal
        Get
            Return _MZ1Old
        End Get
        Set(ByVal Value As Decimal)
            _MZ1Old = Value
        End Set
    End Property 

    Private _TC_MZ1 As Decimal
    <Column(Name:="Tc mz1", Storage:="TC_MZ1", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property TC_MZ1() As Decimal
        Get
            Return _TC_MZ1
        End Get
        Set(ByVal Value As Decimal)
            _TC_MZ1 = Value
            OnPropertyChanged("TC_MZ1")
        End Set
    End Property 

    Private _TC_MZ1Old As Decimal
    Public Property TC_MZ1Old() As Decimal
        Get
            Return _TC_MZ1Old
        End Get
        Set(ByVal Value As Decimal)
            _TC_MZ1Old = Value
        End Set
    End Property 

    Private _TC1 As Decimal
    <Column(Name:="Tc1", Storage:="TC1", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property TC1() As Decimal
        Get
            Return _TC1
        End Get
        Set(ByVal Value As Decimal)
            _TC1 = Value
            OnPropertyChanged("TC1")
        End Set
    End Property 

    Private _TC1Old As Decimal
    Public Property TC1Old() As Decimal
        Get
            Return _TC1Old
        End Get
        Set(ByVal Value As Decimal)
            _TC1Old = Value
        End Set
    End Property 

    Private _REND1 As Decimal
    <Column(Name:="Rend1", Storage:="REND1", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property REND1() As Decimal
        Get
            Return _REND1
        End Get
        Set(ByVal Value As Decimal)
            _REND1 = Value
            OnPropertyChanged("REND1")
        End Set
    End Property 

    Private _REND1Old As Decimal
    Public Property REND1Old() As Decimal
        Get
            Return _REND1Old
        End Get
        Set(ByVal Value As Decimal)
            _REND1Old = Value
        End Set
    End Property 

    Private _LBS1 As Decimal
    <Column(Name:="Lbs1", Storage:="LBS1", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property LBS1() As Decimal
        Get
            Return _LBS1
        End Get
        Set(ByVal Value As Decimal)
            _LBS1 = Value
            OnPropertyChanged("LBS1")
        End Set
    End Property 

    Private _LBS1Old As Decimal
    Public Property LBS1Old() As Decimal
        Get
            Return _LBS1Old
        End Get
        Set(ByVal Value As Decimal)
            _LBS1Old = Value
        End Set
    End Property 

    Private _CICLO2 As Int32
    <Column(Name:="Ciclo2", Storage:="CICLO2", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property CICLO2() As Int32
        Get
            Return _CICLO2
        End Get
        Set(ByVal Value As Int32)
            _CICLO2 = Value
            OnPropertyChanged("CICLO2")
        End Set
    End Property 

    Private _CICLO2Old As Int32
    Public Property CICLO2Old() As Int32
        Get
            Return _CICLO2Old
        End Get
        Set(ByVal Value As Int32)
            _CICLO2Old = Value
        End Set
    End Property 

    Private _MZ2 As Decimal
    <Column(Name:="Mz2", Storage:="MZ2", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property MZ2() As Decimal
        Get
            Return _MZ2
        End Get
        Set(ByVal Value As Decimal)
            _MZ2 = Value
            OnPropertyChanged("MZ2")
        End Set
    End Property 

    Private _MZ2Old As Decimal
    Public Property MZ2Old() As Decimal
        Get
            Return _MZ2Old
        End Get
        Set(ByVal Value As Decimal)
            _MZ2Old = Value
        End Set
    End Property 

    Private _TC_MZ2 As Decimal
    <Column(Name:="Tc mz2", Storage:="TC_MZ2", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property TC_MZ2() As Decimal
        Get
            Return _TC_MZ2
        End Get
        Set(ByVal Value As Decimal)
            _TC_MZ2 = Value
            OnPropertyChanged("TC_MZ2")
        End Set
    End Property 

    Private _TC_MZ2Old As Decimal
    Public Property TC_MZ2Old() As Decimal
        Get
            Return _TC_MZ2Old
        End Get
        Set(ByVal Value As Decimal)
            _TC_MZ2Old = Value
        End Set
    End Property 

    Private _TC2 As Decimal
    <Column(Name:="Tc2", Storage:="TC2", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property TC2() As Decimal
        Get
            Return _TC2
        End Get
        Set(ByVal Value As Decimal)
            _TC2 = Value
            OnPropertyChanged("TC2")
        End Set
    End Property 

    Private _TC2Old As Decimal
    Public Property TC2Old() As Decimal
        Get
            Return _TC2Old
        End Get
        Set(ByVal Value As Decimal)
            _TC2Old = Value
        End Set
    End Property 

    Private _REND2 As Decimal
    <Column(Name:="Rend2", Storage:="REND2", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property REND2() As Decimal
        Get
            Return _REND2
        End Get
        Set(ByVal Value As Decimal)
            _REND2 = Value
            OnPropertyChanged("REND2")
        End Set
    End Property 

    Private _REND2Old As Decimal
    Public Property REND2Old() As Decimal
        Get
            Return _REND2Old
        End Get
        Set(ByVal Value As Decimal)
            _REND2Old = Value
        End Set
    End Property 

    Private _LBS2 As Decimal
    <Column(Name:="Lbs2", Storage:="LBS2", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property LBS2() As Decimal
        Get
            Return _LBS2
        End Get
        Set(ByVal Value As Decimal)
            _LBS2 = Value
            OnPropertyChanged("LBS2")
        End Set
    End Property 

    Private _LBS2Old As Decimal
    Public Property LBS2Old() As Decimal
        Get
            Return _LBS2Old
        End Get
        Set(ByVal Value As Decimal)
            _LBS2Old = Value
        End Set
    End Property 

    Private _CICLO3 As Int32
    <Column(Name:="Ciclo3", Storage:="CICLO3", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property CICLO3() As Int32
        Get
            Return _CICLO3
        End Get
        Set(ByVal Value As Int32)
            _CICLO3 = Value
            OnPropertyChanged("CICLO3")
        End Set
    End Property 

    Private _CICLO3Old As Int32
    Public Property CICLO3Old() As Int32
        Get
            Return _CICLO3Old
        End Get
        Set(ByVal Value As Int32)
            _CICLO3Old = Value
        End Set
    End Property 

    Private _MZ3 As Decimal
    <Column(Name:="Mz3", Storage:="MZ3", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property MZ3() As Decimal
        Get
            Return _MZ3
        End Get
        Set(ByVal Value As Decimal)
            _MZ3 = Value
            OnPropertyChanged("MZ3")
        End Set
    End Property 

    Private _MZ3Old As Decimal
    Public Property MZ3Old() As Decimal
        Get
            Return _MZ3Old
        End Get
        Set(ByVal Value As Decimal)
            _MZ3Old = Value
        End Set
    End Property 

    Private _TC_MZ3 As Decimal
    <Column(Name:="Tc mz3", Storage:="TC_MZ3", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property TC_MZ3() As Decimal
        Get
            Return _TC_MZ3
        End Get
        Set(ByVal Value As Decimal)
            _TC_MZ3 = Value
            OnPropertyChanged("TC_MZ3")
        End Set
    End Property 

    Private _TC_MZ3Old As Decimal
    Public Property TC_MZ3Old() As Decimal
        Get
            Return _TC_MZ3Old
        End Get
        Set(ByVal Value As Decimal)
            _TC_MZ3Old = Value
        End Set
    End Property 

    Private _TC3 As Decimal
    <Column(Name:="Tc3", Storage:="TC3", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property TC3() As Decimal
        Get
            Return _TC3
        End Get
        Set(ByVal Value As Decimal)
            _TC3 = Value
            OnPropertyChanged("TC3")
        End Set
    End Property 

    Private _TC3Old As Decimal
    Public Property TC3Old() As Decimal
        Get
            Return _TC3Old
        End Get
        Set(ByVal Value As Decimal)
            _TC3Old = Value
        End Set
    End Property 

    Private _REND3 As Decimal
    <Column(Name:="Rend3", Storage:="REND3", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property REND3() As Decimal
        Get
            Return _REND3
        End Get
        Set(ByVal Value As Decimal)
            _REND3 = Value
            OnPropertyChanged("REND3")
        End Set
    End Property 

    Private _REND3Old As Decimal
    Public Property REND3Old() As Decimal
        Get
            Return _REND3Old
        End Get
        Set(ByVal Value As Decimal)
            _REND3Old = Value
        End Set
    End Property 

    Private _LBS3 As Decimal
    <Column(Name:="Lbs3", Storage:="LBS3", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property LBS3() As Decimal
        Get
            Return _LBS3
        End Get
        Set(ByVal Value As Decimal)
            _LBS3 = Value
            OnPropertyChanged("LBS3")
        End Set
    End Property 

    Private _LBS3Old As Decimal
    Public Property LBS3Old() As Decimal
        Get
            Return _LBS3Old
        End Get
        Set(ByVal Value As Decimal)
            _LBS3Old = Value
        End Set
    End Property 

    Private _CICLO4 As Int32
    <Column(Name:="Ciclo4", Storage:="CICLO4", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property CICLO4() As Int32
        Get
            Return _CICLO4
        End Get
        Set(ByVal Value As Int32)
            _CICLO4 = Value
            OnPropertyChanged("CICLO4")
        End Set
    End Property 

    Private _CICLO4Old As Int32
    Public Property CICLO4Old() As Int32
        Get
            Return _CICLO4Old
        End Get
        Set(ByVal Value As Int32)
            _CICLO4Old = Value
        End Set
    End Property 

    Private _MZ4 As Decimal
    <Column(Name:="Mz4", Storage:="MZ4", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property MZ4() As Decimal
        Get
            Return _MZ4
        End Get
        Set(ByVal Value As Decimal)
            _MZ4 = Value
            OnPropertyChanged("MZ4")
        End Set
    End Property 

    Private _MZ4Old As Decimal
    Public Property MZ4Old() As Decimal
        Get
            Return _MZ4Old
        End Get
        Set(ByVal Value As Decimal)
            _MZ4Old = Value
        End Set
    End Property 

    Private _TC_MZ4 As Decimal
    <Column(Name:="Tc mz4", Storage:="TC_MZ4", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property TC_MZ4() As Decimal
        Get
            Return _TC_MZ4
        End Get
        Set(ByVal Value As Decimal)
            _TC_MZ4 = Value
            OnPropertyChanged("TC_MZ4")
        End Set
    End Property 

    Private _TC_MZ4Old As Decimal
    Public Property TC_MZ4Old() As Decimal
        Get
            Return _TC_MZ4Old
        End Get
        Set(ByVal Value As Decimal)
            _TC_MZ4Old = Value
        End Set
    End Property 

    Private _TC4 As Decimal
    <Column(Name:="Tc4", Storage:="TC4", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property TC4() As Decimal
        Get
            Return _TC4
        End Get
        Set(ByVal Value As Decimal)
            _TC4 = Value
            OnPropertyChanged("TC4")
        End Set
    End Property 

    Private _TC4Old As Decimal
    Public Property TC4Old() As Decimal
        Get
            Return _TC4Old
        End Get
        Set(ByVal Value As Decimal)
            _TC4Old = Value
        End Set
    End Property 

    Private _REND4 As Decimal
    <Column(Name:="Rend4", Storage:="REND4", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property REND4() As Decimal
        Get
            Return _REND4
        End Get
        Set(ByVal Value As Decimal)
            _REND4 = Value
            OnPropertyChanged("REND4")
        End Set
    End Property 

    Private _REND4Old As Decimal
    Public Property REND4Old() As Decimal
        Get
            Return _REND4Old
        End Get
        Set(ByVal Value As Decimal)
            _REND4Old = Value
        End Set
    End Property 

    Private _LBS4 As Decimal
    <Column(Name:="Lbs4", Storage:="LBS4", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property LBS4() As Decimal
        Get
            Return _LBS4
        End Get
        Set(ByVal Value As Decimal)
            _LBS4 = Value
            OnPropertyChanged("LBS4")
        End Set
    End Property 

    Private _LBS4Old As Decimal
    Public Property LBS4Old() As Decimal
        Get
            Return _LBS4Old
        End Get
        Set(ByVal Value As Decimal)
            _LBS4Old = Value
        End Set
    End Property 

    Private _CICLO5 As Int32
    <Column(Name:="Ciclo5", Storage:="CICLO5", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property CICLO5() As Int32
        Get
            Return _CICLO5
        End Get
        Set(ByVal Value As Int32)
            _CICLO5 = Value
            OnPropertyChanged("CICLO5")
        End Set
    End Property 

    Private _CICLO5Old As Int32
    Public Property CICLO5Old() As Int32
        Get
            Return _CICLO5Old
        End Get
        Set(ByVal Value As Int32)
            _CICLO5Old = Value
        End Set
    End Property 

    Private _MZ5 As Decimal
    <Column(Name:="Mz5", Storage:="MZ5", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property MZ5() As Decimal
        Get
            Return _MZ5
        End Get
        Set(ByVal Value As Decimal)
            _MZ5 = Value
            OnPropertyChanged("MZ5")
        End Set
    End Property 

    Private _MZ5Old As Decimal
    Public Property MZ5Old() As Decimal
        Get
            Return _MZ5Old
        End Get
        Set(ByVal Value As Decimal)
            _MZ5Old = Value
        End Set
    End Property 

    Private _TC_MZ5 As Decimal
    <Column(Name:="Tc mz5", Storage:="TC_MZ5", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property TC_MZ5() As Decimal
        Get
            Return _TC_MZ5
        End Get
        Set(ByVal Value As Decimal)
            _TC_MZ5 = Value
            OnPropertyChanged("TC_MZ5")
        End Set
    End Property 

    Private _TC_MZ5Old As Decimal
    Public Property TC_MZ5Old() As Decimal
        Get
            Return _TC_MZ5Old
        End Get
        Set(ByVal Value As Decimal)
            _TC_MZ5Old = Value
        End Set
    End Property 

    Private _TC5 As Decimal
    <Column(Name:="Tc5", Storage:="TC5", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property TC5() As Decimal
        Get
            Return _TC5
        End Get
        Set(ByVal Value As Decimal)
            _TC5 = Value
            OnPropertyChanged("TC5")
        End Set
    End Property 

    Private _TC5Old As Decimal
    Public Property TC5Old() As Decimal
        Get
            Return _TC5Old
        End Get
        Set(ByVal Value As Decimal)
            _TC5Old = Value
        End Set
    End Property 

    Private _REND5 As Decimal
    <Column(Name:="Rend5", Storage:="REND5", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property REND5() As Decimal
        Get
            Return _REND5
        End Get
        Set(ByVal Value As Decimal)
            _REND5 = Value
            OnPropertyChanged("REND5")
        End Set
    End Property 

    Private _REND5Old As Decimal
    Public Property REND5Old() As Decimal
        Get
            Return _REND5Old
        End Get
        Set(ByVal Value As Decimal)
            _REND5Old = Value
        End Set
    End Property 

    Private _LBS5 As Decimal
    <Column(Name:="Lbs5", Storage:="LBS5", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property LBS5() As Decimal
        Get
            Return _LBS5
        End Get
        Set(ByVal Value As Decimal)
            _LBS5 = Value
            OnPropertyChanged("LBS5")
        End Set
    End Property 

    Private _LBS5Old As Decimal
    Public Property LBS5Old() As Decimal
        Get
            Return _LBS5Old
        End Get
        Set(ByVal Value As Decimal)
            _LBS5Old = Value
        End Set
    End Property 

    Private _CICLO6 As Int32
    <Column(Name:="Ciclo6", Storage:="CICLO6", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property CICLO6() As Int32
        Get
            Return _CICLO6
        End Get
        Set(ByVal Value As Int32)
            _CICLO6 = Value
            OnPropertyChanged("CICLO6")
        End Set
    End Property 

    Private _CICLO6Old As Int32
    Public Property CICLO6Old() As Int32
        Get
            Return _CICLO6Old
        End Get
        Set(ByVal Value As Int32)
            _CICLO6Old = Value
        End Set
    End Property 

    Private _MZ6 As Decimal
    <Column(Name:="Mz6", Storage:="MZ6", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property MZ6() As Decimal
        Get
            Return _MZ6
        End Get
        Set(ByVal Value As Decimal)
            _MZ6 = Value
            OnPropertyChanged("MZ6")
        End Set
    End Property 

    Private _MZ6Old As Decimal
    Public Property MZ6Old() As Decimal
        Get
            Return _MZ6Old
        End Get
        Set(ByVal Value As Decimal)
            _MZ6Old = Value
        End Set
    End Property 

    Private _TC_MZ6 As Decimal
    <Column(Name:="Tc mz6", Storage:="TC_MZ6", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property TC_MZ6() As Decimal
        Get
            Return _TC_MZ6
        End Get
        Set(ByVal Value As Decimal)
            _TC_MZ6 = Value
            OnPropertyChanged("TC_MZ6")
        End Set
    End Property 

    Private _TC_MZ6Old As Decimal
    Public Property TC_MZ6Old() As Decimal
        Get
            Return _TC_MZ6Old
        End Get
        Set(ByVal Value As Decimal)
            _TC_MZ6Old = Value
        End Set
    End Property 

    Private _TC6 As Decimal
    <Column(Name:="Tc6", Storage:="TC6", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property TC6() As Decimal
        Get
            Return _TC6
        End Get
        Set(ByVal Value As Decimal)
            _TC6 = Value
            OnPropertyChanged("TC6")
        End Set
    End Property 

    Private _TC6Old As Decimal
    Public Property TC6Old() As Decimal
        Get
            Return _TC6Old
        End Get
        Set(ByVal Value As Decimal)
            _TC6Old = Value
        End Set
    End Property 

    Private _REND6 As Decimal
    <Column(Name:="Rend6", Storage:="REND6", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property REND6() As Decimal
        Get
            Return _REND6
        End Get
        Set(ByVal Value As Decimal)
            _REND6 = Value
            OnPropertyChanged("REND6")
        End Set
    End Property 

    Private _REND6Old As Decimal
    Public Property REND6Old() As Decimal
        Get
            Return _REND6Old
        End Get
        Set(ByVal Value As Decimal)
            _REND6Old = Value
        End Set
    End Property 

    Private _LBS6 As Decimal
    <Column(Name:="Lbs6", Storage:="LBS6", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property LBS6() As Decimal
        Get
            Return _LBS6
        End Get
        Set(ByVal Value As Decimal)
            _LBS6 = Value
            OnPropertyChanged("LBS6")
        End Set
    End Property 

    Private _LBS6Old As Decimal
    Public Property LBS6Old() As Decimal
        Get
            Return _LBS6Old
        End Get
        Set(ByVal Value As Decimal)
            _LBS6Old = Value
        End Set
    End Property 

    Private _CICLO7 As Int32
    <Column(Name:="Ciclo7", Storage:="CICLO7", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property CICLO7() As Int32
        Get
            Return _CICLO7
        End Get
        Set(ByVal Value As Int32)
            _CICLO7 = Value
            OnPropertyChanged("CICLO7")
        End Set
    End Property 

    Private _CICLO7Old As Int32
    Public Property CICLO7Old() As Int32
        Get
            Return _CICLO7Old
        End Get
        Set(ByVal Value As Int32)
            _CICLO7Old = Value
        End Set
    End Property 

    Private _MZ7 As Decimal
    <Column(Name:="Mz7", Storage:="MZ7", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property MZ7() As Decimal
        Get
            Return _MZ7
        End Get
        Set(ByVal Value As Decimal)
            _MZ7 = Value
            OnPropertyChanged("MZ7")
        End Set
    End Property 

    Private _MZ7Old As Decimal
    Public Property MZ7Old() As Decimal
        Get
            Return _MZ7Old
        End Get
        Set(ByVal Value As Decimal)
            _MZ7Old = Value
        End Set
    End Property 

    Private _TC_MZ7 As Decimal
    <Column(Name:="Tc mz7", Storage:="TC_MZ7", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property TC_MZ7() As Decimal
        Get
            Return _TC_MZ7
        End Get
        Set(ByVal Value As Decimal)
            _TC_MZ7 = Value
            OnPropertyChanged("TC_MZ7")
        End Set
    End Property 

    Private _TC_MZ7Old As Decimal
    Public Property TC_MZ7Old() As Decimal
        Get
            Return _TC_MZ7Old
        End Get
        Set(ByVal Value As Decimal)
            _TC_MZ7Old = Value
        End Set
    End Property 

    Private _TC7 As Decimal
    <Column(Name:="Tc7", Storage:="TC7", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property TC7() As Decimal
        Get
            Return _TC7
        End Get
        Set(ByVal Value As Decimal)
            _TC7 = Value
            OnPropertyChanged("TC7")
        End Set
    End Property 

    Private _TC7Old As Decimal
    Public Property TC7Old() As Decimal
        Get
            Return _TC7Old
        End Get
        Set(ByVal Value As Decimal)
            _TC7Old = Value
        End Set
    End Property 

    Private _REND7 As Decimal
    <Column(Name:="Rend7", Storage:="REND7", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property REND7() As Decimal
        Get
            Return _REND7
        End Get
        Set(ByVal Value As Decimal)
            _REND7 = Value
            OnPropertyChanged("REND7")
        End Set
    End Property 

    Private _REND7Old As Decimal
    Public Property REND7Old() As Decimal
        Get
            Return _REND7Old
        End Get
        Set(ByVal Value As Decimal)
            _REND7Old = Value
        End Set
    End Property 

    Private _LBS7 As Decimal
    <Column(Name:="Lbs7", Storage:="LBS7", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property LBS7() As Decimal
        Get
            Return _LBS7
        End Get
        Set(ByVal Value As Decimal)
            _LBS7 = Value
            OnPropertyChanged("LBS7")
        End Set
    End Property 

    Private _LBS7Old As Decimal
    Public Property LBS7Old() As Decimal
        Get
            Return _LBS7Old
        End Get
        Set(ByVal Value As Decimal)
            _LBS7Old = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
