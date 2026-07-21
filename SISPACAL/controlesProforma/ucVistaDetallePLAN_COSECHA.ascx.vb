Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetallePLAN_COSECHA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla PLAN_COSECHA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	29/11/2014	Created
''' </history>
''' --------------------------------------------------------------      ---------------
Partial Class controles_ucVistaDetallePLAN_COSECHA
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_PLAN_COSECHA As Int32
    Public Property ID_PLAN_COSECHA() As Int32
        Get
            If Me.ViewState("ID_PLAN_COSECHA") Is Nothing Then
                Return 0
            Else
                Return CInt(Me.ViewState("ID_PLAN_COSECHA"))
            End If
        End Get
        Set(ByVal Value As Int32)
            hfucVistaDetallePLAN_COSECHA.Clear()
            hfucVistaDetallePLAN_COSECHA.Add("MZ_SALDO", Nothing)
            hfucVistaDetallePLAN_COSECHA.Add("TONEL_SALDO", Nothing)
            hfucVistaDetallePLAN_COSECHA.Add("ID_TIPO_CANA", Nothing)
            hfucVistaDetallePLAN_COSECHA.Add("ID_TIPO_ROZA", Nothing)
            hfucVistaDetallePLAN_COSECHA.Add("ID_TIPO_ALZA", Nothing)
            hfucVistaDetallePLAN_COSECHA.Add("ID_TIPO_TRANS", Nothing)
            hfucVistaDetallePLAN_COSECHA.Add("ID_CARGADORA", Nothing)
            hfucVistaDetallePLAN_COSECHA.Add("TONEL_MZ_COSECHA", Nothing)
            Me._ID_PLAN_COSECHA = Value
            If Me.ViewState("ID_PLAN_COSECHA") Is Nothing Then Me.ViewState.Add("ID_PLAN_COSECHA", Value) Else Me.ViewState("ID_PLAN_COSECHA") = Value
            Me.txtID_PLAN_COSECHA.Text = CStr(Value)
            If Me._ID_PLAN_COSECHA > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property ID_ZAFRA() As Int32
        Get
            If Me.cbxZAFRA.Value Is Nothing Then Return -1
            Return Me.cbxZAFRA.Value
        End Get
        Set(ByVal value As Int32)
            Me.cbxZAFRA.Value = value
        End Set
    End Property

    Public Property MZ_SALDO() As Object
        Get
            Return Me.txtMZ_SALDO.Value
        End Get
        Set(ByVal value As Object)
            If IsNumeric(value) AndAlso value = -1 Then
                Me.txtMZ_SALDO.Value = Nothing
            Else
                Me.txtMZ_SALDO.Value = value
            End If
        End Set
    End Property

    Public Property TONEL_SALDO() As Object
        Get
            Return Me.txtTONEL_SALDO.Value
        End Get
        Set(ByVal value As Object)
            If IsNumeric(value) AndAlso value = -1 Then
                Me.txtTONEL_SALDO.Value = Nothing
            Else
                Me.txtTONEL_SALDO.Value = value
            End If
        End Set
    End Property

    Public Property MZ_COSECHA() As Decimal
        Get
            If Me.txtMZ_COSECHA.Value Is Nothing Then Return -1
            Return Me.txtMZ_COSECHA.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtMZ_COSECHA.Value = value
        End Set
    End Property

    Public Property TONEL_MZ_COSECHA() As Decimal
        Get
            If Me.ViewState("TONEL_MZ_COSECHA") Is Nothing Then
                Return 0
            Else
                Return CDec(Me.ViewState("TONEL_MZ_COSECHA"))
            End If
        End Get
        Set(ByVal value As Decimal)
            Me.ViewState("TONEL_MZ_COSECHA") = value
        End Set
    End Property

    Public Property TONEL_COSECHA() As Decimal
        Get
            If Me.txtTONEL_COSECHA.Value Is Nothing Then Return -1
            Return Me.txtTONEL_COSECHA.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtTONEL_COSECHA.Value = value
        End Set
    End Property

    Public Property CUOTA_DIARIA() As Decimal
        Get
            If Me.txtCUOTA_DIARIA.Value Is Nothing Then Return -1
            Return Me.txtCUOTA_DIARIA.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtCUOTA_DIARIA.Value = value
        End Set
    End Property

    Public Property FECHA_INI_COSECHA() As DateTime
        Get
            Return Me.dteFECHA_INI_COSECHA.Value
        End Get
        Set(ByVal value As DateTime)
            Me.dteFECHA_INI_COSECHA.Value = value
        End Set
    End Property

    Public Property FECHA_FIN_COSECHA() As DateTime
        Get
            Return Me.dteFECHA_FIN_COSECHA.Value
        End Get
        Set(ByVal value As DateTime)
            Me.dteFECHA_FIN_COSECHA.Value = value
        End Set
    End Property

    Public Property TOTAL_SEMANA() As Decimal
        Get
            If Me.txtTOTAL_SEMANA.Value Is Nothing Then Return -1
            Return Me.txtTOTAL_SEMANA.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtTOTAL_SEMANA.Value = value
        End Set
    End Property

    Public Property QUEMA_PROGRAMADA() As Boolean
        Get

            Return chkQuemaProgramada.Checked
        End Get
        Set(ByVal value As Boolean)
            chkQuemaProgramada.Checked = value
        End Set
    End Property

    Public Property QUEMA_NO_PROGRAMADA() As Boolean
        Get
            Return chkQuemaNoProgramada.Checked
        End Get
        Set(ByVal value As Boolean)
            chkQuemaNoProgramada.Checked = True
        End Set
    End Property

    Public Property ID_TIPO_CANA() As Object
        Get
            Return Me.cbxID_TIPO_CANA.Value
        End Get
        Set(ByVal value As Object)
            If IsNumeric(value) AndAlso value = -1 Then
                Me.cbxID_TIPO_CANA.Value = Nothing
            Else
                If Me.cbxID_TIPO_CANA.Items.FindByValue(CInt(value)) IsNot Nothing Then
                    Me.cbxID_TIPO_CANA.Value = value
                Else
                    Me.cbxID_TIPO_CANA.Value = Nothing
                End If
            End If
        End Set
    End Property

    Public Property ID_TIPO_ROZA() As Object
        Get
            Return Me.cbxID_TIPO_ROZA.Value
        End Get
        Set(ByVal value As Object)
            If IsNumeric(value) AndAlso value = -1 Then
                Me.cbxID_TIPO_ROZA.Value = Nothing
            Else
                If Me.cbxID_TIPO_ROZA.Items.FindByValue(CInt(value)) IsNot Nothing Then
                    Me.cbxID_TIPO_ROZA.Value = value
                Else
                    Me.cbxID_TIPO_ROZA.Value = Nothing
                End If
            End If
        End Set
    End Property

    Public Property ID_TIPO_ALZA() As Object
        Get
            Return Me.cbxID_TIPO_ALZA.Value
        End Get
        Set(ByVal value As Object)
            If IsNumeric(value) AndAlso value = -1 Then
                Me.cbxID_TIPO_ALZA.Value = Nothing
            Else
                If Me.cbxID_TIPO_ALZA.Items.FindByValue(CInt(value)) IsNot Nothing Then
                    Me.cbxID_TIPO_ALZA.Value = value
                Else
                    Me.cbxID_TIPO_ALZA.Value = Nothing
                End If
            End If
        End Set
    End Property

    Public Property ID_CARGADOR() As Int32
        Get
            If Me.txtID_CARGADOR.Value Is Nothing Then Return -1
            Return CInt(Me.txtID_CARGADOR.Value)
        End Get
        Set(ByVal value As Int32)
            Me.txtID_CARGADOR.Value = value
        End Set
    End Property

    Public Property ID_TIPOTRANS() As Object
        Get
            Return Me.cbxID_TIPO_TRANS.Value
        End Get
        Set(ByVal value As Object)
            If IsNumeric(value) AndAlso value = -1 Then
                Me.cbxID_TIPO_TRANS.Value = Nothing
            Else
                If Me.cbxID_TIPO_TRANS.Items.FindByValue(CInt(value)) IsNot Nothing Then
                    Me.cbxID_TIPO_TRANS.Value = value
                Else
                    Me.cbxID_TIPO_TRANS.Value = Nothing
                End If
            End If
        End Set
    End Property

    Public Property ID_CARGADORA() As Object
        Get
            Return Me.cbxCARGADORA.Value
        End Get
        Set(ByVal value As Object)
            If IsNumeric(value) AndAlso value = -1 Then
                Me.cbxCARGADORA.Value = Nothing
            Else
                If Me.cbxCARGADORA.Items.FindByValue(CInt(value)) IsNot Nothing Then
                    Me.cbxCARGADORA.Value = value
                Else
                    Me.cbxCARGADORA.Value = Nothing
                End If
            End If
        End Set
    End Property


    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cPLAN_COSECHA
    Private mEntidad As PLAN_COSECHA
    Public Event ErrorEvent(ByVal errorMessage As String)

    Public ReadOnly Property sError() As String
        Get
            Return _sError
        End Get
    End Property

    Public Property Enabled() As Boolean
        Get
            Return Me._Enabled
        End Get
        Set(ByVal Value As Boolean)
            Me._Enabled = Value
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

#End Region

#Region "CAT"
    Private Sub CargarTipoRoza()
        Dim lOrigen As listaTIPOS_GENERALES = (New cTIPOS_GENERALES).ObtenerListaPorCriterios(-1, Enumeradores.CAT.TipoCAT.Roza, -1)
        Dim lDestino As New listaTIPOS_GENERALES

        If cbxID_TIPO_CANA.Value IsNot Nothing Then
            Dim lPermitido As List(Of Int32) = configuracion.RozaEnTipoCana(CInt(cbxID_TIPO_CANA.Value))
            For Each lTipo As TIPOS_GENERALES In lOrigen
                If lPermitido.Contains(lTipo.ID_TIPO) Then
                    lDestino.Add(lTipo)
                End If
            Next
        End If
        Me.cbxID_TIPO_ROZA.DataSource = lDestino
        Me.cbxID_TIPO_ROZA.DataBind()
    End Sub

    Private Sub CargarTipoAlza()
        Dim lOrigen As listaTIPOS_GENERALES = (New cTIPOS_GENERALES).ObtenerListaPorCriterios(-1, Enumeradores.CAT.TipoCAT.Alza, -1)
        Dim lDestino As New listaTIPOS_GENERALES

        If cbxID_TIPO_CANA.Value IsNot Nothing AndAlso cbxID_TIPO_ROZA.Value IsNot Nothing Then
            Dim lPermitido As List(Of Int32) = configuracion.AlzaEnTipoCana(CInt(cbxID_TIPO_CANA.Value), CInt(cbxID_TIPO_ROZA.Value))
            For Each lTipo As TIPOS_GENERALES In lOrigen
                If lPermitido.Contains(lTipo.ID_TIPO) Then
                    lDestino.Add(lTipo)
                End If
            Next
        End If
        Me.cbxID_TIPO_ALZA.DataSource = lDestino
        Me.cbxID_TIPO_ALZA.DataBind()
    End Sub

    Private Sub CargarTipoTransporte()
        Dim lOrigen As listaTIPOS_GENERALES = (New cTIPOS_GENERALES).ObtenerListaPorCriterios(-1, Enumeradores.CAT.TipoCAT.Transporte, -1)
        Dim lDestino As New listaTIPOS_GENERALES

        If cbxID_TIPO_CANA.Value IsNot Nothing Then
            Dim lPermitido As List(Of Int32) = configuracion.TransporteEnTipoCana(CInt(cbxID_TIPO_CANA.Value))
            For Each lTipo As TIPOS_GENERALES In lOrigen
                If lPermitido.Contains(lTipo.ID_TIPO) Then
                    lDestino.Add(lTipo)
                End If
            Next
        End If
        Me.cbxID_TIPO_TRANS.DataSource = lDestino
        Me.cbxID_TIPO_TRANS.DataBind()
    End Sub

    Private Sub CargarCargadoras()
        Dim lCargadoras As New listaCARGADORA
        Me.cbxCARGADORA.Text = ""
        lCargadoras = (New cCARGADORA).ObtenerListaPorTIPO_ALZA(Me.cbxID_TIPO_ALZA.Value)
        Me.cbxCARGADORA.DataSource = lCargadoras
        Me.cbxCARGADORA.DataBind()
    End Sub
#End Region

    Private Sub CalcularTotal_TC_Semana()
        'Dim lLoteCosecha As LOTES_COSECHA = (New cLOTES_COSECHA).ObtenerLOTES_COSECHAPorLOTE_ZAFRA(   
        Dim mCuotaDiaria As Decimal = 0
        Dim mDias As Int32 = 0
        If Me.txtCUOTA_DIARIA.Value IsNot Nothing Then
            mCuotaDiaria = Me.txtCUOTA_DIARIA.Value
        End If
        If dteFECHA_INI_COSECHA.Value IsNot Nothing AndAlso dteFECHA_FIN_COSECHA.Value IsNot Nothing Then
            mDias = DateAndTime.DateDiff(DateInterval.Day, dteFECHA_INI_COSECHA.Value, dteFECHA_FIN_COSECHA.Value) + 1
        End If
        Me.txtTONEL_COSECHA.Value = Me.txtMZ_COSECHA.Value * Me.TONEL_MZ_COSECHA

        If mCuotaDiaria > 0 Then
            Me.txtTOTAL_SEMANA.Value = Math.Round(Me.txtMZ_COSECHA.Value * Me.TONEL_MZ_COSECHA / mCuotaDiaria, 2)
        Else
            Me.txtTOTAL_SEMANA.Value = 0
        End If
    End Sub

    Public Sub ObtenerSaldoLote()
        Dim lLoteCosecha As LOTES_COSECHA = Nothing
        For Each lLote As LOTES In ucListaLOTES1.DevolverSeleccionados
            lLoteCosecha = (New cLOTES_COSECHA).ObtenerLOTES_COSECHAPorLOTE_ZAFRA(lLote.ACCESLOTE, Me.cbxZAFRA.Value)
            Exit For
        Next
        If lLoteCosecha IsNot Nothing Then
            hfucVistaDetallePLAN_COSECHA("MZ_SALDO") = lLoteCosecha.MZ_ENTREGAR
            hfucVistaDetallePLAN_COSECHA("TONEL_SALDO") = lLoteCosecha.TONEL_ENTREGAR

            hfucVistaDetallePLAN_COSECHA("ID_TIPO_CANA") = lLoteCosecha.ID_TIPO_CANA
            hfucVistaDetallePLAN_COSECHA("ID_TIPO_ROZA") = lLoteCosecha.ID_TIPO_ROZA
            hfucVistaDetallePLAN_COSECHA("ID_TIPO_ALZA") = lLoteCosecha.ID_TIPO_ALZA
            hfucVistaDetallePLAN_COSECHA("ID_TIPO_TRANS") = lLoteCosecha.ID_TIPO_TRANS
            hfucVistaDetallePLAN_COSECHA("ID_CARGADORA") = -1
            hfucVistaDetallePLAN_COSECHA("TONEL_MZ_COSECHA") = lLoteCosecha.TONEL_MZ_CENSO
        Else
            hfucVistaDetallePLAN_COSECHA("MZ_SALDO") = -1
            hfucVistaDetallePLAN_COSECHA("TONEL_SALDO") = -1

            hfucVistaDetallePLAN_COSECHA("ID_TIPO_CANA") = -1
            hfucVistaDetallePLAN_COSECHA("ID_TIPO_ROZA") = -1
            hfucVistaDetallePLAN_COSECHA("ID_TIPO_ALZA") = -1
            hfucVistaDetallePLAN_COSECHA("ID_TIPO_TRANS") = -1
            hfucVistaDetallePLAN_COSECHA("ID_CARGADORA") = -1
            hfucVistaDetallePLAN_COSECHA("TONEL_MZ_COSECHA") = 0
        End If
        Me.SetEstadoControl()
        Me.CalcularTotal_TC_Semana()
    End Sub

    Private Sub SetEstadoControl()
        If hfucVistaDetallePLAN_COSECHA.Contains("MZ_SALDO") Then Me.MZ_SALDO = hfucVistaDetallePLAN_COSECHA("MZ_SALDO")
        If hfucVistaDetallePLAN_COSECHA.Contains("TONEL_SALDO") Then Me.TONEL_SALDO = hfucVistaDetallePLAN_COSECHA("TONEL_SALDO")

        If hfucVistaDetallePLAN_COSECHA.Contains("ID_TIPO_CANA") Then Me.ID_TIPO_CANA = hfucVistaDetallePLAN_COSECHA("ID_TIPO_CANA")
        Me.CargarTipoRoza()
        If hfucVistaDetallePLAN_COSECHA.Contains("ID_TIPO_ROZA") Then Me.ID_TIPO_ROZA = hfucVistaDetallePLAN_COSECHA("ID_TIPO_ROZA")
        Me.CargarTipoAlza()
        If hfucVistaDetallePLAN_COSECHA.Contains("ID_TIPO_ALZA") Then Me.ID_TIPO_ALZA = hfucVistaDetallePLAN_COSECHA("ID_TIPO_ALZA")
        Me.CargarTipoTransporte()
        If hfucVistaDetallePLAN_COSECHA.Contains("ID_TIPO_TRANS") Then Me.ID_TIPOTRANS = hfucVistaDetallePLAN_COSECHA("ID_TIPO_TRANS")
        Me.CargarCargadoras()
        If hfucVistaDetallePLAN_COSECHA.Contains("ID_CARGADORA") Then Me.ID_CARGADORA = hfucVistaDetallePLAN_COSECHA("ID_CARGADORA")
        If hfucVistaDetallePLAN_COSECHA.Contains("TONEL_MZ_COSECHA") Then Me.TONEL_MZ_COSECHA = hfucVistaDetallePLAN_COSECHA("TONEL_MZ_COSECHA")
        Select Case True
            Case Me.chkQuemaProgramada.Checked
                Me.dteFECHA_ESTIM_QUEMA.ClientEnabled = True
                Me.dteFECHA_REAL_QUEMA.ClientEnabled = True
                Me.dteFECHA_QUEMA_NOPROG.ClientEnabled = False
            Case Me.chkQuemaNoProgramada.Checked
                Me.dteFECHA_ESTIM_QUEMA.ClientEnabled = False
                Me.dteFECHA_REAL_QUEMA.ClientEnabled = False
                Me.dteFECHA_QUEMA_NOPROG.ClientEnabled = True
            Case Me.chkCanaVerde.Checked
                Me.dteFECHA_ESTIM_QUEMA.ClientEnabled = False
                Me.dteFECHA_REAL_QUEMA.ClientEnabled = False
                Me.dteFECHA_QUEMA_NOPROG.ClientEnabled = False
        End Select
    End Sub

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquÃ­ el cÃ³digo de usuario para inicializar la pÃ¡gina
        If Not Me.ViewState("nuevo") Is Nothing Then Me._nuevo = Me.ViewState("nuevo")
        If Not Me.ViewState("ID_PLAN_COSECHA") Is Nothing Then Me._ID_PLAN_COSECHA = Me.ViewState("ID_PLAN_COSECHA")
        Me.SetEstadoControl()
        Me.ObtenerLotes()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla PLAN_COSECHA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()
        Dim lLote As LOTES
        Dim lLoteCosecha As LOTES_COSECHA
        Dim codiProveedor As String = ""

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New PLAN_COSECHA
        mEntidad.ID_PLAN_COSECHA = ID_PLAN_COSECHA

        If mComponente.ObtenerPLAN_COSECHA(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If

        lLoteCosecha = (New cLOTES_COSECHA).ObtenerLOTES_COSECHAPorLOTE_ZAFRA(mEntidad.ACCESLOTE, mEntidad.ID_ZAFRA)

        Me.txtID_PLAN_COSECHA.Text = mEntidad.ID_PLAN_COSECHA.ToString()
        lLote = (New cLOTES).ObtenerLOTES(mEntidad.ACCESLOTE)
        If lLote IsNot Nothing Then
            Dim lContrato As CONTRATO
            Dim lProveedor As PROVEEDOR

            lContrato = (New cCONTRATO).ObtenerCONTRATO(lLote.CODICONTRATO)
            codiProveedor = lContrato.CODIPROVEEDOR
            lProveedor = (New cPROVEEDOR).ObtenerPROVEEDOR(codiProveedor)
            speCODIPROVEE.Value = Convert.ToInt32(lProveedor.CODIPROVEE)
            txtNOMBRE_PROVEEDOR.Text = lProveedor.NOMBRES + " " + lProveedor.APELLIDOS
        End If
        Me.cbxZAFRA.Value = mEntidad.ID_ZAFRA
        Me.txtMZ_SALDO.Value = mEntidad.MZ_SALDO
        Me.txtTONEL_SALDO.Value = mEntidad.TONEL_SALDO

        If mEntidad.CUOTA_DIARIA = 0 Then
            Me.txtMZ_COSECHA.Value = lLoteCosecha.MZ_CENSO
            Me.txtTC_MZ_COSECHA.Value = lLoteCosecha.TONEL_MZ_CENSO
            Me.TONEL_MZ_COSECHA = lLoteCosecha.TONEL_MZ_CENSO
            Me.txtTONEL_COSECHA.Value = mEntidad.TONEL_COSECHA
            Me.txtCUOTA_DIARIA.Value = mEntidad.CUOTA_DIARIA
            Me.dteFECHA_INI_COSECHA.Value = mEntidad.FECHA_INI_COSECHA
            Me.dteFECHA_FIN_COSECHA.Value = mEntidad.FECHA_FIN_COSECHA
            Me.txtTOTAL_SEMANA.Value = mEntidad.TOTAL_SEMANA
        Else
            Me.txtMZ_COSECHA.Value = mEntidad.MZ_COSECHA
            If mEntidad.TONEL_MZ_COSECHA = 0 Then
                Me.txtTC_MZ_COSECHA.Value = lLoteCosecha.TONEL_MZ_CENSO
                Me.TONEL_MZ_COSECHA = lLoteCosecha.TONEL_MZ_CENSO
            Else
                Me.txtTC_MZ_COSECHA.Value = mEntidad.TONEL_MZ_COSECHA
                Me.TONEL_MZ_COSECHA = mEntidad.TONEL_MZ_COSECHA
            End If
            Me.txtTONEL_COSECHA.Value = mEntidad.TONEL_COSECHA
            Me.txtCUOTA_DIARIA.Value = mEntidad.CUOTA_DIARIA
            Me.dteFECHA_INI_COSECHA.Value = mEntidad.FECHA_INI_COSECHA
            Me.dteFECHA_FIN_COSECHA.Value = mEntidad.FECHA_FIN_COSECHA
            Me.txtTOTAL_SEMANA.Value = mEntidad.TOTAL_SEMANA
        End If
        Me.chkQuemaProgramada.Checked = mEntidad.QUEMA_PROGRAMADA
        Me.chkQuemaNoProgramada.Checked = mEntidad.QUEMA_NO_PROGRAMADA
        Me.chkCanaVerde.Checked = mEntidad.CANA_VERDE
        Select Case True
            Case mEntidad.QUEMA_PROGRAMADA
                Me.dteFECHA_ESTIM_QUEMA.Value = mEntidad.FECHA_ESTIM_QUEMA
                Me.dteFECHA_REAL_QUEMA.Value = mEntidad.FECHA_REAL_QUEMA
                Me.dteFECHA_QUEMA_NOPROG.Value = Nothing
            Case mEntidad.QUEMA_NO_PROGRAMADA
                Me.dteFECHA_ESTIM_QUEMA.Value = Nothing
                Me.dteFECHA_REAL_QUEMA.Value = Nothing
                Me.dteFECHA_QUEMA_NOPROG.Value = mEntidad.FECHA_QUEMA_NOPROG
            Case Else
                Me.dteFECHA_ESTIM_QUEMA.Value = Nothing
                Me.dteFECHA_REAL_QUEMA.Value = Nothing
                Me.dteFECHA_QUEMA_NOPROG.Value = Nothing
        End Select
        If mEntidad.ID_TIPO_CANA <> -1 Then Me.cbxID_TIPO_CANA.Value = mEntidad.ID_TIPO_CANA
        Me.CargarTipoRoza()
        If mEntidad.ID_TIPO_ROZA <> -1 Then Me.cbxID_TIPO_ROZA.Value = mEntidad.ID_TIPO_ROZA
        Me.CargarTipoAlza()
        If mEntidad.ID_TIPO_ALZA <> -1 Then Me.cbxID_TIPO_ALZA.Value = mEntidad.ID_TIPO_ALZA
        If Me.cbxID_TIPO_ALZA.Value = CAT.TipoAlza.AlzaManualParticular OrElse _
            Me.cbxID_TIPO_ALZA.Value = CAT.TipoAlza.AlzaManualProductor Then
            Me.txtID_CARGADOR.Value = "33"
            Me.txtNOMBRE_CARGADOR.Value = "CARGADO A MANO"
            Me.txtID_CARGADOR.ClientEnabled = False
        Else
            Me.txtID_CARGADOR.ClientEnabled = True
            Me.txtID_CARGADOR.Text = ""
            Me.txtNOMBRE_CARGADOR.Text = ""
        End If
        Me.CargarTipoTransporte()
        If mEntidad.ID_TIPOTRANS <> -1 Then Me.cbxID_TIPO_TRANS.Value = mEntidad.ID_TIPOTRANS
        hfucVistaDetallePLAN_COSECHA("MZ_SALDO") = mEntidad.MZ_SALDO
        hfucVistaDetallePLAN_COSECHA("TONEL_SALDO") = mEntidad.TONEL_SALDO
        hfucVistaDetallePLAN_COSECHA("ID_TIPO_CANA") = mEntidad.ID_TIPO_CANA
        hfucVistaDetallePLAN_COSECHA("ID_TIPO_ROZA") = mEntidad.ID_TIPO_ROZA
        hfucVistaDetallePLAN_COSECHA("ID_TIPO_ALZA") = mEntidad.ID_TIPO_ALZA
        hfucVistaDetallePLAN_COSECHA("ID_TIPO_TRANS") = mEntidad.ID_TIPOTRANS
        hfucVistaDetallePLAN_COSECHA("TONEL_MZ_COSECHA") = Me.TONEL_MZ_COSECHA

        Me.CargarCargadoras()
        hfucVistaDetallePLAN_COSECHA("ID_CARGADORA") = mEntidad.ID_CARGADORA
        If cbxCARGADORA.Items.FindByValue(mEntidad.ID_CARGADORA) IsNot Nothing Then
            cbxCARGADORA.Value = mEntidad.ID_CARGADORA
        End If

        If mEntidad.ID_CARGADOR <> -1 Then
            Dim lCargador As CARGADOR = (New cCARGADOR).ObtenerCARGADOR(mEntidad.ID_CARGADOR)
            If lCargador IsNot Nothing Then
                Me.txtID_CARGADOR.Value = mEntidad.ID_CARGADOR
                Me.txtNOMBRE_CARGADOR.Text = lCargador.NOMBRE_CARGADOR
            Else
                Me.txtNOMBRE_CARGADOR.Text = ""
            End If
        End If
        Me.ucListaLOTES1.ID_ZAFRA = Me.cbxZAFRA.Value
        Me.ucListaLOTES1.QuitarFiltros()
        Me.ucListaLOTES1.CargarDatosPorZAFRA_CONTRATADA_PROVEEDOR_CONTRATADO(mEntidad.ID_ZAFRA, codiProveedor, cProceso.ObtenerCODIAGRON(Me.ObtenerUsuario))
        Me.ucListaLOTES1.SeleccionarFila = mEntidad.ACCESLOTE
        Me.CalcularTotal_TC_Semana()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.cbxZAFRA.Enabled = False
        Me.speCODIPROVEE.ClientEnabled = Me._nuevo
        Me.ucListaLOTES1.MostrarCheckUnaSeleccion = Me._nuevo
        Me.ucListaLOTES1.Habilitar = Me._nuevo
        Me.txtNOMBRE_PROVEEDOR.ClientEnabled = False
        Me.txtMZ_SALDO.ClientEnabled = False
        Me.txtTONEL_SALDO.ClientEnabled = False
        Me.txtMZ_COSECHA.ClientEnabled = Me._nuevo OrElse edicion
        Me.txtTC_MZ_COSECHA.ClientEnabled = False
        Me.txtTONEL_COSECHA.ClientEnabled = False
        Me.txtCUOTA_DIARIA.ClientEnabled = Me._nuevo OrElse edicion
        Me.dteFECHA_INI_COSECHA.ClientEnabled = edicion
        Me.dteFECHA_FIN_COSECHA.ClientEnabled = edicion
        Me.txtTOTAL_SEMANA.ClientEnabled = False
        Me.chkQuemaProgramada.ClientEnabled = edicion
        Me.chkQuemaNoProgramada.ClientEnabled = edicion
        Me.chkCanaVerde.ClientEnabled = edicion
        Me.dteFECHA_ESTIM_QUEMA.ClientEnabled = edicion
        Me.dteFECHA_REAL_QUEMA.ClientEnabled = edicion
        Me.dteFECHA_QUEMA_NOPROG.ClientEnabled = edicion
        Me.cbxID_TIPO_CANA.ClientEnabled = edicion
        Me.cbxID_TIPO_ROZA.ClientEnabled = edicion
        Me.cbxID_TIPO_ALZA.ClientEnabled = edicion
        Me.cbxID_TIPO_TRANS.ClientEnabled = edicion
        Me.cbxCARGADORA.ClientEnabled = edicion
        Me.txtID_CARGADOR.ClientEnabled = edicion AndAlso Me.cbxID_TIPO_ALZA.Value <> CAT.TipoAlza.AlzaManualParticular _
                AndAlso Me.cbxID_TIPO_ALZA.Value <> CAT.TipoAlza.AlzaManualProductor
        Me.txtNOMBRE_CARGADOR.ClientEnabled = False
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        If lZafra IsNot Nothing Then
            Me.cbxZAFRA.Value = lZafra.ID_ZAFRA
        End If
        Me.speCODIPROVEE.Value = Nothing
        Me.txtNOMBRE_PROVEEDOR.Value = Nothing
        Me.txtMZ_SALDO.Value = Nothing
        Me.txtTONEL_SALDO.Value = Nothing
        Me.txtMZ_COSECHA.Value = Nothing
        Me.txtTC_MZ_COSECHA.Value = Nothing
        Me.txtTONEL_COSECHA.Value = Nothing
        Me.txtCUOTA_DIARIA.Value = Nothing
        Me.dteFECHA_INI_COSECHA.Value = Nothing
        Me.dteFECHA_FIN_COSECHA.Value = Nothing
        Me.txtTOTAL_SEMANA.Value = Nothing
        Me.chkQuemaProgramada.Checked = False
        Me.chkQuemaNoProgramada.Checked = False
        Me.chkCanaVerde.Checked = False
        Me.dteFECHA_ESTIM_QUEMA.Value = Nothing
        Me.dteFECHA_REAL_QUEMA.Value = Nothing
        Me.dteFECHA_QUEMA_NOPROG.Value = Nothing
        Me.cbxID_TIPO_CANA.Value = Nothing
        Me.cbxID_TIPO_ROZA.Value = Nothing
        Me.cbxID_TIPO_ALZA.Value = Nothing
        Me.cbxID_TIPO_TRANS.Value = Nothing
        Me.cbxCARGADORA.Value = Nothing
        Me.txtID_CARGADOR.Value = Nothing
        Me.txtNOMBRE_CARGADOR.Value = Nothing
        Me.ucListaLOTES1.CargarDatosPorZAFRA_CONTRATADA_PROVEEDOR_CONTRATADO(-1, "", "")
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla PLAN_COSECHA
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        Dim lLoteSelect As listaLOTES

        mEntidad = New PLAN_COSECHA
        If Me._nuevo Then
            mEntidad.ID_PLAN_COSECHA = 0
            mEntidad.USUARIO_CREA = Me.ObtenerUsuario
            mEntidad.FECHA_CREA = cFechaHora.ObtenerFechaHora
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
        Else
            mEntidad = (New cPLAN_COSECHA).ObtenerPLAN_COSECHA(Me.ID_PLAN_COSECHA)
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
        End If
        mEntidad.ID_ZAFRA = Me.cbxZAFRA.Value

        lLoteSelect = ucListaLOTES1.DevolverSeleccionados()
        If lLoteSelect.Count = 0 Then
            Return "Seleccione un lote para programarlo"
        End If
        'If Me.chkQuemaProgramada.Checked AndAlso Me.chkQuemaNoProgramada.Checked Then
        '    Return "No puede elegir quema programada y no programada al mismo tiempo"
        'End If
        If Me.cbxID_TIPO_CANA.Items.FindByText(Me.cbxID_TIPO_CANA.Text) Is Nothing Then
            Return "Tipo de cana no valido"
        End If
        If Me.cbxID_TIPO_ROZA.Items.FindByText(Me.cbxID_TIPO_ROZA.Text) Is Nothing Then
            Return "Tipo de roza no valido"
        End If
        If Me.cbxID_TIPO_ALZA.Items.FindByText(Me.cbxID_TIPO_ALZA.Text) Is Nothing Then
            Return "Tipo de alza no valido"
        End If
        If Me.cbxID_TIPO_TRANS.Items.FindByText(Me.cbxID_TIPO_TRANS.Text) Is Nothing Then
            Return "Tipo de transporte no valido"
        End If

        mEntidad.ACCESLOTE = lLoteSelect(0).ACCESLOTE
        mEntidad.MZ_SALDO = Me.txtMZ_SALDO.Value
        mEntidad.TONEL_SALDO = Me.txtTONEL_SALDO.Value
        mEntidad.MZ_COSECHA = Me.txtMZ_COSECHA.Value
        mEntidad.TONEL_MZ_COSECHA = Me.TONEL_MZ_COSECHA
        mEntidad.TONEL_COSECHA = Me.txtTONEL_COSECHA.Value
        mEntidad.CUOTA_DIARIA = Me.txtCUOTA_DIARIA.Value
        mEntidad.FECHA_INI_COSECHA = Me.dteFECHA_INI_COSECHA.Value
        mEntidad.FECHA_FIN_COSECHA = Me.dteFECHA_FIN_COSECHA.Value
        mEntidad.TOTAL_SEMANA = Me.txtTOTAL_SEMANA.Value
        'mEntidad.QUEMA_PROGRAMADA = Me.chkQuemaProgramada.Checked
        'mEntidad.QUEMA_NO_PROGRAMADA = Me.chkQuemaNoProgramada.Checked
        'mEntidad.CANA_VERDE = Me.chkCanaVerde.Checked
        'Select Case True
        '    Case Me.chkQuemaProgramada.Checked
        '        If Me.dteFECHA_ESTIM_QUEMA.Value Is Nothing Then
        '            Return "Ingrese fecha estimada de quema"
        '        End If
        '        mEntidad.FECHA_ESTIM_QUEMA = Me.dteFECHA_ESTIM_QUEMA.Value
        '        mEntidad.FECHA_REAL_QUEMA = Me.dteFECHA_REAL_QUEMA.Value
        '        mEntidad.FECHA_QUEMA_NOPROG = Nothing
        '    Case Me.chkQuemaNoProgramada.Checked
        '        mEntidad.FECHA_ESTIM_QUEMA = Nothing
        '        mEntidad.FECHA_REAL_QUEMA = Nothing
        '        If Me.dteFECHA_QUEMA_NOPROG.Value Is Nothing Then
        '            Return "Seleccione fecha de quema no programada"
        '        End If
        '        mEntidad.FECHA_QUEMA_NOPROG = CDate(Me.dteFECHA_QUEMA_NOPROG.Value)
        '    Case Me.chkCanaVerde.Checked
        '        Me.dteFECHA_ESTIM_QUEMA.Value = Nothing
        '        Me.dteFECHA_REAL_QUEMA.Value = Nothing
        '        Me.dteFECHA_QUEMA_NOPROG.Value = Nothing
        '    Case Else
        '        Return "Marque un tipo de quema"
        'End Select
        mEntidad.ID_TIPO_CANA = Me.cbxID_TIPO_CANA.Value
        mEntidad.ID_TIPO_ROZA = Me.cbxID_TIPO_ROZA.Value
        mEntidad.ID_TIPO_ALZA = Me.cbxID_TIPO_ALZA.Value
        mEntidad.ID_TIPOTRANS = Me.cbxID_TIPO_TRANS.Value
        If Me.cbxID_TIPO_TRANS.Value = CAT.TipoTransporte.CamionProductor OrElse _
            Me.cbxID_TIPO_TRANS.Value = CAT.TipoTransporte._3EjesProductor OrElse _
            Me.cbxID_TIPO_TRANS.Value = CAT.TipoTransporte.RastraProductor Then
            mEntidad.TRANSPORTE_PROPIO = True
        Else
            mEntidad.TRANSPORTE_PROPIO = False
        End If
        'mEntidad.ID_CARGADORA = Me.cbxCARGADORA.Value
        'mEntidad.ID_CARGADOR = Me.txtID_CARGADOR.Value
        If Me.cbxID_TIPO_TRANS.Value = CAT.TipoTransporte.CamionProductor OrElse _
           Me.cbxID_TIPO_TRANS.Value = CAT.TipoTransporte.RastraProductor OrElse _
           Me.cbxID_TIPO_TRANS.Value = CAT.TipoTransporte._3EjesProductor Then
            mEntidad.TRANSPORTE_PROPIO = True
        Else
            mEntidad.TRANSPORTE_PROPIO = False
        End If
        mEntidad.ID_CARGADORA = -1
        mEntidad.ID_CARGADOR = -1

        'Dim lCosechadora As CARGADORA
        'If Me.cbxCARGADORA.Value Is Nothing Then
        '    Return "Seleccione una Cosechadora o Cargadora"
        'End If
        'lCosechadora = (New cCARGADORA).ObtenerCARGADORA(Me.cbxCARGADORA.Value)

        If mComponente.ActualizarPLAN_COSECHA(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_PLAN_COSECHA.Text = mEntidad.ID_PLAN_COSECHA.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function

    
    Protected Sub speCODIPROVEE_ValueChanged(sender As Object, e As System.EventArgs) Handles speCODIPROVEE.ValueChanged
        Me.ObtenerProveedor()
    End Sub

    Private Sub ObtenerProveedor()
        Me.txtNOMBRE_PROVEEDOR.Text = ""
        If Me.speCODIPROVEE.Text <> "" AndAlso Utilerias.EsNumeroEntero(Me.speCODIPROVEE.Text) Then
            Dim lCodiprovee As String = Utilerias.FormatoCODIPROVEE(Me.speCODIPROVEE.Text) + Utilerias.FormatoCODISOCIO(0)
            Dim lProveedor As PROVEEDOR = (New cPROVEEDOR).ObtenerPROVEEDOR(lCodiprovee)
            If lProveedor IsNot Nothing Then
                Me.txtNOMBRE_PROVEEDOR.Text = lProveedor.NOMBRES + " " + lProveedor.APELLIDOS
                Me.ucListaLOTES1.ID_ZAFRA = Me.cbxZAFRA.Value
                ObtenerLotes()
            End If
        End If
    End Sub

    Private Sub ObtenerLotes()
        Dim sCodiProveedor As String
        If Not Utilerias.EsNumeroEntero(speCODIPROVEE.Value) Then
            sCodiProveedor = Utilerias.FormatoCODIPROVEE(0)
        Else
            sCodiProveedor = Utilerias.FormatoCODIPROVEE(speCODIPROVEE.Value) + Utilerias.FormatoCODISOCIO(0)
            ucListaLOTES1.CargarDatosPorZAFRA_CONTRATADA_PROVEEDOR_CONTRATADO(cbxZAFRA.Value, sCodiProveedor, cProceso.ObtenerCODIAGRON(Me.ObtenerUsuario))
        End If
    End Sub

    Protected Sub txtCUOTA_DIARIA_ValueChanged(sender As Object, e As System.EventArgs) Handles txtCUOTA_DIARIA.ValueChanged
        Me.CalcularTotal_TC_Semana()
        Me.dteFECHA_INI_COSECHA.Focus()
    End Sub

    Protected Sub dteFECHA_INI_COSECHA_ValueChanged(sender As Object, e As System.EventArgs) Handles dteFECHA_INI_COSECHA.ValueChanged
        Me.CalcularTotal_TC_Semana()
        Me.dteFECHA_FIN_COSECHA.Focus()
    End Sub

    Protected Sub dteFECHA_FIN_COSECHA_ValueChanged(sender As Object, e As System.EventArgs) Handles dteFECHA_FIN_COSECHA.ValueChanged
        Me.CalcularTotal_TC_Semana()
        Me.cbxID_TIPO_CANA.Focus()
    End Sub

    Protected Sub cbxID_TIPO_CANA_ValueChanged(sender As Object, e As System.EventArgs) Handles cbxID_TIPO_CANA.ValueChanged
        Me.CargarTipoRoza()
        Me.CargarTipoAlza()
        Me.CargarTipoTransporte()
        Me.CargarCargadoras()
    End Sub

    Protected Sub cbxID_TIPO_ROZA_ValueChanged(sender As Object, e As System.EventArgs) Handles cbxID_TIPO_ROZA.ValueChanged
        Me.CargarTipoAlza()
        Me.CargarCargadoras()
    End Sub

    Protected Sub txtID_CARGADOR_ValueChanged(sender As Object, e As System.EventArgs) Handles txtID_CARGADOR.ValueChanged
        Dim entidad As CARGADOR

        txtNOMBRE_CARGADOR.Text = ""
        If txtID_CARGADOR.Text <> "" Then
            entidad = (New cCARGADOR).ObtenerCARGADOR(Convert.ToInt32(txtID_CARGADOR.Value))
            If entidad IsNot Nothing Then
                Me.txtNOMBRE_CARGADOR.Text = entidad.NOMBRE_CARGADOR
            Else
                AsignarMensaje(" * Codigo de cargador no esta registrado", True, False)
                txtID_CARGADOR.Text = ""
                txtID_CARGADOR.Focus()
            End If
        End If
    End Sub

    Protected Sub cbxID_TIPO_ALZA_ValueChanged(sender As Object, e As EventArgs) Handles cbxID_TIPO_ALZA.ValueChanged
        Me.CargarCargadoras()
        If Me.cbxID_TIPO_ALZA.Value = CAT.TipoAlza.AlzaManualParticular OrElse _
            Me.cbxID_TIPO_ALZA.Value = CAT.TipoAlza.AlzaManualProductor Then
            Me.txtID_CARGADOR.Value = "33"
            Me.txtID_CARGADOR.ClientEnabled = False
            Me.txtID_CARGADOR_ValueChanged(sender, e)
        Else
            Me.txtID_CARGADOR.ClientEnabled = True
            Me.txtID_CARGADOR.Text = ""
            Me.txtNOMBRE_CARGADOR.Text = ""
        End If
        Me.cbxCARGADORA.Focus()
    End Sub

    Protected Sub txtMZ_COSECHA_ValueChanged(sender As Object, e As EventArgs) Handles txtMZ_COSECHA.ValueChanged
        Me.CalcularTotal_TC_Semana()
        Me.dteFECHA_INI_COSECHA.Focus()
    End Sub
End Class
