Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores
Imports System.Data
Imports System.IO

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetalleSOLIC_ANTICIPO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla SOLIC_ANTICIPO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	17/06/2015	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleSOLIC_ANTICIPO
    Inherits ucBase

#Region "Propiedades"


    Public Property ID_ANTICIPO() As Int32
        Get
            If Me.ViewState("ID_ANTICIPO") IsNot Nothing Then
                Return CInt(Me.ViewState("ID_ANTICIPO"))
            Else
                Return -1
            End If
        End Get
        Set(ByVal Value As Int32)
            Me.ViewState("ID_ANTICIPO") = Value
            Me.lblREFERENCIA.Text = Guid.NewGuid.ToString
            Me.lblREFERENCIA_LOTES.Text = Guid.NewGuid.ToString
            Me.lblREFERENCIA_LIQFINAN.Text = Guid.NewGuid.ToString
            If Value > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property


    Public Property LISTA_SOLIC_ANTICIPO_LOTE As listaSOLIC_ANTICIPO_LOTE
        Set(value As listaSOLIC_ANTICIPO_LOTE)
            Dim i As Int32 = 1
            If value IsNot Nothing Then
                For Each lEntidad As SOLIC_ANTICIPO_LOTE In value
                    If lEntidad.ID_SOLI_LOTE = 0 Then
                        lEntidad.ID_SOLI_LOTE = i
                        i += 1
                    End If
                    lEntidad.REFERENCIA = Me.lblREFERENCIA_LOTES.Text
                Next
            Else
                value = New listaSOLIC_ANTICIPO_LOTE
            End If
            Session(Me.lblREFERENCIA_LOTES.Text) = value
        End Set
        Get
            If Session(Me.lblREFERENCIA_LOTES.Text) IsNot Nothing Then Return TryCast(Session(Me.lblREFERENCIA_LOTES.Text), listaSOLIC_ANTICIPO_LOTE) Else Return New listaSOLIC_ANTICIPO_LOTE
        End Get
    End Property

    Public Property LISTA_SOLIC_ANTICIPO_ZAFRA As listaSOLIC_ANTICIPO_ZAFRA
        Set(value As listaSOLIC_ANTICIPO_ZAFRA)
            Session(Me.lblREFERENCIA.Text) = value
        End Set
        Get
            If Session(Me.lblREFERENCIA.Text) IsNot Nothing Then Return TryCast(Session(Me.lblREFERENCIA.Text), listaSOLIC_ANTICIPO_ZAFRA) Else Return New listaSOLIC_ANTICIPO_ZAFRA
        End Get
    End Property

    Public Property LISTA_SOLIC_ANTICIPO_LIQFINAN As listaSOLIC_ANTICIPO_LIQFINAN
        Set(value As listaSOLIC_ANTICIPO_LIQFINAN)
            Session(Me.lblREFERENCIA_LIQFINAN.Text) = value
        End Set
        Get
            If Session(Me.lblREFERENCIA_LIQFINAN.Text) IsNot Nothing Then Return TryCast(Session(Me.lblREFERENCIA_LIQFINAN.Text), listaSOLIC_ANTICIPO_LIQFINAN) Else Return New listaSOLIC_ANTICIPO_LIQFINAN
        End Get
    End Property


    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cSOLIC_ANTICIPO
    Private mEntidad As SOLIC_ANTICIPO
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

    Public Sub LimpiarSesion()
        If lblREFERENCIA.Text <> "" Then
            If Session(lblREFERENCIA.Text) IsNot Nothing Then
                Session.Remove(lblREFERENCIA.Text)
            End If
        End If
        If lblREFERENCIA_LOTES.Text <> "" Then
            Session.Remove(lblREFERENCIA_LOTES.Text)
        End If
    End Sub

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquÃ­ el cÃ³digo de usuario para inicializar la pÃ¡gina
        If Not Me.ViewState("nuevo") Is Nothing Then Me._nuevo = Me.ViewState("nuevo")

    End Sub

    Public Sub CargarDetalleAnticipoZafra()
        If Me.lblREFERENCIA.Text <> "" Then
            Me.ucListaSOLIC_ANTICIPO_ZAFRA1.CargarDatosCache(Me.lblREFERENCIA.Text)
        End If
    End Sub

    Public Sub CargarDetalleAnticipoLotes()
        If Me.lblREFERENCIA_LOTES.Text <> "" Then
            Me.ucListaSOLIC_ANTICIPO_LOTE1.CargarDatosCache(Me.lblREFERENCIA_LOTES.Text)
        End If
    End Sub

    Public Sub CargarDetalleAnticipoLiqFinan()
        If Me.lblREFERENCIA_LIQFINAN.Text <> "" Then
            Me.ucListaSOLIC_ANTICIPO_LIQFINAN1.CargarDatosCache(Me.lblREFERENCIA_LIQFINAN.Text)
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla SOLIC_ANTICIPO
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	17/06/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()
        Dim lProveedor As PROVEEDOR
        Dim listSoliContratos As listaSOLIC_ANTICIPO_CONTRATOS
        Dim listaContratos As New List(Of String)
        Dim listaLiqFinan As listaSOLIC_ANTICIPO_LIQFINAN
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New SOLIC_ANTICIPO
        mEntidad.ID_ANTICIPO = ID_ANTICIPO

        If mComponente.ObtenerSOLIC_ANTICIPO(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_ANTICIPO.Text = mEntidad.ID_ANTICIPO.ToString()
        Me.cbxZAFRA.Value = mEntidad.ID_ZAFRA
        Me.txtNUM_ANTICIPO.Text = mEntidad.NUM_ANTICIPO
        Me.txtCODIPROVEE.Text = Utilerias.RecuperarCODIPROVEE(mEntidad.CODIPROVEEDOR)
        Me.dteFECHA_SOLIC.Date = mEntidad.FECHA
        Me.dteFECHA_CHEQUE.Value = If(mEntidad.FECHA_CHEQUE = #12:00:00 AM#, Nothing, mEntidad.FECHA_CHEQUE)
        lProveedor = (New cPROVEEDOR).ObtenerPROVEEDOR(mEntidad.CODIPROVEEDOR)
        If lProveedor IsNot Nothing Then
            Me.txtNOMBRE_PROVEEDOR.Text = lProveedor.NOMBRES + " " + lProveedor.APELLIDOS
        End If
        Me.txtCONCEPTO.Text = mEntidad.CONCEPTO
        Me.speMONTO.Value = mEntidad.MONTO
        Me.spePORC_INTERES.Value = If(mEntidad.PORC_INTERES = -1, Nothing, mEntidad.PORC_INTERES)

        Me.cbxTIPO_FINANCIAMIENTO.Value = mEntidad.ID_CUENTA_FINAN
        Me.txtCHQ_NO.Text = mEntidad.CHQ_NO
        Me.dteFECHA_VENCE.Date = If(mEntidad.FECHA_VENCE = #12:00:00 AM#, Nothing, mEntidad.FECHA_VENCE)
        Me.spePLAZO_MESES.Value = If(mEntidad.PLAZO_MESES = -1, Nothing, mEntidad.PLAZO_MESES)
        Me.cbxESTADO.Value = mEntidad.ID_ESTADO
        Me.dtePeriodoPagoDel.Value = mEntidad.PERFECHA_INI
        Me.dtePeriodoPagoAl.Value = mEntidad.PERFECHA_FIN
        Me.txtDESTINO.Text = mEntidad.DESTINO

        Me.chkAceptada.Checked = mEntidad.ES_ACEPTADA
        Me.ObtenerContratos(lProveedor.CODIPROVEE)
        Me.cbxZAFRAdeta.Value = Nothing
        Me.dteFECHA_ULTMOV.Value = Nothing
        Me.speCUOTA.Value = 0

        listSoliContratos = (New cSOLIC_ANTICIPO_CONTRATOS).ObtenerListaPorSOLIC_ANTICIPO(mEntidad.ID_ANTICIPO)
        If listSoliContratos IsNot Nothing AndAlso listSoliContratos.Count > 0 Then
            For i As Int32 = 0 To listSoliContratos.Count - 1
                listaContratos.Add(listSoliContratos(i).CODICONTRATO)
            Next
        End If
        Me.ucListaCONTRATO1.SeleccionarRegistros(listaContratos)

        Me.LISTA_SOLIC_ANTICIPO_ZAFRA = (New cSOLIC_ANTICIPO_ZAFRA).ObtenerListaPorSOLIC_ANTICIPO(Me.ID_ANTICIPO)
        Me.CargarDetalleAnticipoZafra()

        Me.LISTA_SOLIC_ANTICIPO_LOTE = (New cSOLIC_ANTICIPO_LOTE).ObtenerListaPorSOLIC_ANTICIPO(ID_ANTICIPO)
        Me.CargarDetalleAnticipoLotes()
        Me.ucListaSOLIC_ANTICIPO_LOTE1.SeleccionarTodos()
        If Me.LISTA_SOLIC_ANTICIPO_LOTE Is Nothing OrElse Me.LISTA_SOLIC_ANTICIPO_LOTE.Count = 0 Then
            ObtenerLotes()
        End If
        '*** Liquidación de saldos por Solicitud de anticipo
        listaLiqFinan = (New cSOLIC_ANTICIPO_LIQFINAN).ObtenerListaPorSOLIC_ANTICIPO(mEntidad.ID_ANTICIPO)
        If listaLiqFinan IsNot Nothing AndAlso listaLiqFinan.Count > 0 Then
            For i As Integer = 0 To listaLiqFinan.Count - 1
                listaLiqFinan(i).UID_REFERENCIA = Me.lblREFERENCIA_LIQFINAN.Text
            Next
        Else
            listaLiqFinan = New listaSOLIC_ANTICIPO_LIQFINAN
        End If
        Me.LISTA_SOLIC_ANTICIPO_LIQFINAN = listaLiqFinan
        Me.CargarDetalleAnticipoLiqFinan()
        Me.ActualizarTOTAL_LIQUIDAR()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	17/06/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.cbxZAFRA.ClientEnabled = Me._nuevo
        Me.txtCODIPROVEE.ClientEnabled = Me._nuevo
        Me.txtNOMBRE_PROVEEDOR.ClientEnabled = False
        Me.dteFECHA_SOLIC.ClientEnabled = Me._nuevo
        Me.txtCONCEPTO.ClientEnabled = Me._nuevo OrElse edicion
        Me.dteFECHA_CHEQUE.ClientEnabled = Me._nuevo OrElse edicion
        Me.speMONTO.ClientEnabled = Me._nuevo OrElse edicion
        Me.spePORC_INTERES.ClientEnabled = Me._nuevo OrElse edicion
        Me.chkAceptada.ClientEnabled = False

        Me.cbxTIPO_FINANCIAMIENTO.ClientEnabled = Me._nuevo
        Me.txtCHQ_NO.ClientEnabled = Me._nuevo OrElse edicion
        Me.dteFECHA_VENCE.ClientEnabled = Me._nuevo OrElse edicion
        Me.cbxESTADO.ClientEnabled = False
        Me.dtePeriodoPagoDel.ClientEnabled = Me._nuevo OrElse edicion
        Me.dtePeriodoPagoAl.ClientEnabled = Me._nuevo OrElse edicion
        Me.txtDESTINO.ClientEnabled = Me._nuevo OrElse edicion

        Me.ConfigVencimientoPlazo()

        Me.ucListaSOLIC_ANTICIPO_LOTE1.MostrarCheckVariaSeleccion = edicion 'Me._nuevo AndAlso edicion
        Me.ucListaSOLIC_ANTICIPO_LOTE1.PermitirEditar = False 'Me._nuevo AndAlso edicion
        Me.ucListaSOLIC_ANTICIPO_LOTE1.PermitirEditarInline = False 'Me._nuevo AndAlso edicion
        If Me._nuevo Then Me.ucListaSOLIC_ANTICIPO_LOTE1.QuitarSelecciones()

        ASPxPageControl1.TabPages(1).ClientEnabled = (cbxTIPO_FINANCIAMIENTO.Value = Enumeradores.CuentaFinanciamiento.Mutuos)
        ASPxPageControl1.TabPages(2).ClientEnabled = (cbxTIPO_FINANCIAMIENTO.Value = Enumeradores.CuentaFinanciamiento.Anticipos OrElse cbxTIPO_FINANCIAMIENTO.Value = Enumeradores.CuentaFinanciamiento.Mutuos)
        ASPxPageControl1.ActiveTabIndex = 0
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	17/06/2015	Created
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
        Me.txtCODIPROVEE.Text = ""
        Me.txtNOMBRE_PROVEEDOR.Text = ""
        Me.dteFECHA_SOLIC.Value = cFechaHora.ObtenerFecha
        Me.txtCONCEPTO.Text = ""
        Me.speMONTO.Value = 0
        Me.cbxESTADO.Value = 1
        Me.spePORC_INTERES.Value = Nothing
        Me.chkAceptada.Checked = False
        Me.dtePeriodoPagoDel.Value = Nothing
        Me.dtePeriodoPagoAl.Value = Nothing
        Me.lblTotalLiquidar.Text = "$ 0.00"
        Me.txtDESTINO.Text = ""

        Me.cbxTIPO_FINANCIAMIENTO.Value = Nothing
        Me.txtCHQ_NO.Text = ""
        Me.dteFECHA_VENCE.Value = Nothing
        Me.spePLAZO_MESES.Value = Nothing
        Me.dtePeriodoPagoDel.Value = Nothing
        Me.dtePeriodoPagoAl.Value = Nothing
        Me.LISTA_SOLIC_ANTICIPO_ZAFRA = New listaSOLIC_ANTICIPO_ZAFRA
        Me.chkSelectTodosLotes.ClientEnabled = True
        Me.chkSelectTodosLotes.Checked = False
        Me.CargarDetalleAnticipoLotes()
        Me.CargarDetalleAnticipoZafra()
        Me.LISTA_SOLIC_ANTICIPO_LIQFINAN = New listaSOLIC_ANTICIPO_LIQFINAN
        Me.CargarDetalleAnticipoLiqFinan()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla SOLIC_ANTICIPO
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	17/06/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim bContratoProvision As New cCONTRATO_CTAS_PROVI
        Dim bSolicAnticipoLotes As New cSOLIC_ANTICIPO_LOTE
        Dim bSolicAnticipoLiqFinan As New cSOLIC_ANTICIPO_LIQFINAN
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        Dim totalLiquidar As Decimal = 0

        mEntidad = New SOLIC_ANTICIPO
        If Me._nuevo Then
            mEntidad.ID_ANTICIPO = 0
            mEntidad.USUARIO_CREA = Me.ObtenerUsuario
            mEntidad.FECHA_CREA = cFechaHora.ObtenerFechaHora
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFecha
            mEntidad.UID_ANTICIPO_CONTRATO = Guid.NewGuid
            mEntidad.NUM_ANTICIPO = 0
        Else
            mEntidad = (New cSOLIC_ANTICIPO).ObtenerSOLIC_ANTICIPO(Me.ID_ANTICIPO)
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFecha
        End If
        If cbxZAFRA.Text = "" Then
            Return "Seleccione la zafra"
        End If
        If Me.cbxTIPO_FINANCIAMIENTO.Value Is Nothing Then
            Return "Seleccione el Tipo de Financiamiento"
        End If
        If txtCODIPROVEE.Text = "" Then
            Return "Ingrese el codigo de proveedor"
        End If
        If Me.speMONTO.Value Is Nothing OrElse Me.speMONTO.Value <= 0 Then
            Return "Ingrese el monto del anticipo"
        End If
        'If Me.ucListaCONTRATO1.DevolverSeleccionados.Count = 0 Then
        '    Return "No ha seleccionado ningún contrato"
        'End If
        If ucListaSOLIC_ANTICIPO_LOTE1.DevolverSeleccionados.Count = 0 Then
            Return "Seleccione algun lote"
        End If

        totalLiquidar = Me.ActualizarTOTAL_LIQUIDAR
        If totalLiquidar > Convert.ToDecimal(Me.speMONTO.Value) Then
            Return "El total a liquidar de financimientos no puede ser mayor que el valor del préstamo"
        End If

        mEntidad.ID_CUENTA_FINAN = Me.cbxTIPO_FINANCIAMIENTO.Value
        mEntidad.ID_ZAFRA = cbxZAFRA.Value
        mEntidad.CODIPROVEEDOR = Utilerias.FormatearCODIPROVEEDOR(Me.txtCODIPROVEE.Value)
        mEntidad.FECHA = cFechaHora.ObtenerFecha
        mEntidad.FECHA_CHEQUE = If(Me.dteFECHA_CHEQUE.Value Is Nothing, #12:00:00 AM#, Me.dteFECHA_CHEQUE.Date)
        mEntidad.PORC_INTERES = If(Me.spePORC_INTERES.Value = Nothing, -1, Me.spePORC_INTERES.Value)
        mEntidad.CONCEPTO = Me.txtCONCEPTO.Text.Trim.ToUpper
        mEntidad.MONTO = Me.speMONTO.Value
        mEntidad.ID_ZAFRA = Me.cbxZAFRA.Value
        mEntidad.ZAFRA = Me.cbxZAFRA.Text
        mEntidad.CHQ_NO = Me.txtCHQ_NO.Text.Trim
        mEntidad.PLAZO_MESES = If(Me.spePLAZO_MESES.Value Is Nothing OrElse Me.spePLAZO_MESES.Value = 0, -1, Me.spePLAZO_MESES.Value)
        mEntidad.FECHA_VENCE = If(Me.dteFECHA_VENCE.Value Is Nothing, #12:00:00 AM#, Me.dteFECHA_VENCE.Date)
        mEntidad.ES_ACEPTADA = Me.chkAceptada.Checked
        mEntidad.ID_ESTADO = cbxESTADO.Value
        mEntidad.PERFECHA_INI = dtePeriodoPagoDel.Value
        mEntidad.PERFECHA_FIN = dtePeriodoPagoAl.Value
        mEntidad.DESTINO = Me.txtDESTINO.Text.Trim.ToUpper

        If Me.cbxTIPO_FINANCIAMIENTO.Value = CuentaFinanciamiento.PlanillasPago Then
            If Me.dtePeriodoPagoDel.Value = #12:00:00 AM# OrElse Me.dtePeriodoPagoAl.Value = #12:00:00 AM# Then
                Return "Ingrese el periodo de pago"
            End If
        End If

        If mComponente.ActualizarSOLIC_ANTICIPO(mEntidad) < 0 Then
            Return "Error al Guardar registro. " + mComponente.sError
        End If

        '*********** Actualizar lista de contratos a los que aplica la OIP ************
        Dim listaContratosBase As listaSOLIC_ANTICIPO_CONTRATOS = (New cSOLIC_ANTICIPO_CONTRATOS).ObtenerListaPorSOLIC_ANTICIPO(mEntidad.ID_ANTICIPO)
        Dim listaContratos As listaCONTRATO = Me.ucListaCONTRATO1.DevolverSeleccionados
        Dim listaContratosSelecc As New List(Of String)
        Dim listaContratosBaseAux As New List(Of String)
        Dim bSoliContra As New cSOLIC_ANTICIPO_CONTRATOS

        If listaContratosBase IsNot Nothing AndAlso listaContratosBase.Count > 0 Then
            For i As Int32 = 0 To listaContratosBase.Count - 1
                ' Contratos en la base
                listaContratosBaseAux.Add(listaContratosBase(i).CODICONTRATO)
            Next
        End If
        If listaContratos IsNot Nothing AndAlso listaContratos.Count > 0 Then
            For i As Int32 = 0 To listaContratos.Count - 1
                'Contratos seleccionados
                listaContratosSelecc.Add(listaContratos(i).CODICONTRATO)
            Next
        End If

        'Agregar contratos seleccionados que no estén en la base
        For i As Int32 = 0 To listaContratosSelecc.Count - 1
            If Not listaContratosBaseAux.Contains(listaContratosSelecc(i)) Then
                Dim lSolipContra As New SOLIC_ANTICIPO_CONTRATOS
                lSolipContra.ID_ANTI_CONTRATO = 0
                lSolipContra.ID_ANTICIPO = mEntidad.ID_ANTICIPO
                lSolipContra.CODICONTRATO = listaContratosSelecc(i)

                bSoliContra.ActualizarSOLIC_ANTICIPO_CONTRATOS(lSolipContra)
                listaContratosBaseAux.Add(listaContratosSelecc(i))
            End If
        Next

        'Eliminar contratos que están en la base y no estén en los seleccionados
        For i As Int32 = 0 To listaContratosBaseAux.Count - 1
            If Not listaContratosSelecc.Contains(listaContratosBaseAux(i)) Then
                bSoliContra.EliminarPorSOLIC_ANTICIPO_CONTRATO(mEntidad.ID_ANTICIPO, listaContratosBaseAux(i))
            End If
        Next

        '*************************************
        'Lotes en Solicitud: Creación Registro 
        '*************************************
        Dim lSolicAnticipoLote As SOLIC_ANTICIPO_LOTE
        For Each lEntidad As SOLIC_ANTICIPO_LOTE In ucListaSOLIC_ANTICIPO_LOTE1.DevolverSeleccionados
            If Me._nuevo Then
                lSolicAnticipoLote = New SOLIC_ANTICIPO_LOTE
                lSolicAnticipoLote.ID_SOLI_LOTE = 0
                lSolicAnticipoLote.ID_ANTICIPO = mEntidad.ID_ANTICIPO
                lSolicAnticipoLote.ID_ZAFRA = cbxZAFRA.Value
                lSolicAnticipoLote.ACCESLOTE = lEntidad.ACCESLOTE
                lSolicAnticipoLote.MZ = lEntidad.MZ
                lSolicAnticipoLote.TONEL_ESTI = lEntidad.TONEL_ESTI
                lSolicAnticipoLote.USUARIO_CREA = Me.ObtenerUsuario
                lSolicAnticipoLote.FECHA_CREA = cFechaHora.ObtenerFechaHora
                lSolicAnticipoLote.USUARIO_ACT = Me.ObtenerUsuario
                lSolicAnticipoLote.FECHA_ACT = cFechaHora.ObtenerFechaHora
                bSolicAnticipoLotes.ActualizarSOLIC_ANTICIPO_LOTE(lSolicAnticipoLote)
            End If
        Next

        'Eliminar liquidaciones que están en la base y no estén en los seleccionados
        bSolicAnticipoLiqFinan.EliminarPorSOLIC_ANTICIPO(mEntidad.ID_ANTICIPO)
        '*************************************************
        'Liquidacion de financiamientos: Creación Registro 
        '*************************************************
        Dim lstLiqFinan As listaSOLIC_ANTICIPO_LIQFINAN = Me.LISTA_SOLIC_ANTICIPO_LIQFINAN
        Dim lSolicLiqFinan As SOLIC_ANTICIPO_LIQFINAN
        If lstLiqFinan IsNot Nothing AndAlso lstLiqFinan.Count > 0 Then
            For i As Integer = 0 To lstLiqFinan.Count - 1
                If (lstLiqFinan(i).ABONO + lstLiqFinan(i).INTERES_ABO + lstLiqFinan(i).INTERES_IVA_ABO) > 0 Then
                    lSolicLiqFinan = New SOLIC_ANTICIPO_LIQFINAN
                    lSolicLiqFinan = lstLiqFinan(i)
                    lSolicLiqFinan.ID_ANTICIPO = mEntidad.ID_ANTICIPO
                    lSolicLiqFinan.ID_ANTI_LIQ = 0
                    lSolicLiqFinan.UID_REFERENCIA = Guid.NewGuid.ToString()
                    bSolicAnticipoLiqFinan.ActualizarSOLIC_ANTICIPO_LIQFINAN(lSolicLiqFinan)
                End If
            Next
        End If

        If Not Me._nuevo AndAlso mEntidad.ES_ACEPTADA AndAlso Me.cbxTIPO_FINANCIAMIENTO.Value = CuentaFinanciamiento.Mutuos AndAlso Me.LISTA_SOLIC_ANTICIPO_ZAFRA.Count > 0 Then
            Dim bSolicAnticipoZafra As New cSOLIC_ANTICIPO_ZAFRA

            'Eliminar zafras que no se encuentren en el Nuevo listado
            Dim listaOld As listaSOLIC_ANTICIPO_ZAFRA = bSolicAnticipoZafra.ObtenerListaPorSOLIC_ANTICIPO(mEntidad.ID_ANTICIPO)
            If listaOld IsNot Nothing AndAlso listaOld.Count > 0 Then
                For Each lEntidadOld As SOLIC_ANTICIPO_ZAFRA In listaOld
                    Dim existe As Boolean = False

                    For Each lEntidadNew As SOLIC_ANTICIPO_ZAFRA In Me.LISTA_SOLIC_ANTICIPO_ZAFRA
                        If lEntidadNew.ID_ZAFRA = lEntidadOld.ID_ZAFRA Then
                            existe = True
                        End If
                    Next
                    If Not existe Then bSolicAnticipoZafra.EliminarSOLIC_ANTICIPO_ZAFRA(lEntidadOld.ID_ANTI_ZAFRA)
                Next
            End If

            'Actualizar información de zafras
            For Each lEntidad As SOLIC_ANTICIPO_ZAFRA In Me.LISTA_SOLIC_ANTICIPO_ZAFRA
                Dim lVerificar As SOLIC_ANTICIPO_ZAFRA = bSolicAnticipoZafra.ObtenerPorZafraAnticipo(lEntidad.ID_ZAFRA, mEntidad.ID_ANTICIPO)
                If lVerificar IsNot Nothing Then
                    lEntidad.ID_ANTI_ZAFRA = lVerificar.ID_ANTI_ZAFRA
                    lEntidad.ID_ANTICIPO = mEntidad.ID_ANTICIPO
                Else
                    lEntidad.ID_ANTI_ZAFRA = 0
                    lEntidad.ID_ANTICIPO = mEntidad.ID_ANTICIPO
                    lEntidad.USUARIO_CREA = Me.ObtenerUsuario
                    lEntidad.FECHA_CREA = cFechaHora.ObtenerFechaHora
                End If
                bSolicAnticipoZafra.ActualizarSOLIC_ANTICIPO_ZAFRA(lEntidad)
            Next
        End If

        If Me._nuevo AndAlso _
            (Me.cbxTIPO_FINANCIAMIENTO.Value = CuentaFinanciamiento.PlanillasPago OrElse _
             Me.cbxTIPO_FINANCIAMIENTO.Value = CuentaFinanciamiento.PagoIntereses OrElse _
             Me.cbxTIPO_FINANCIAMIENTO.Value = CuentaFinanciamiento.CajaChica) Then ScriptManager.RegisterClientScriptBlock(Me, Page.GetType, "script", "MostrarAnalisisFinanciero(5," + mEntidad.ID_ANTICIPO.ToString + ");" + "MostrarSolicAnticipo(" + mEntidad.ID_ANTICIPO.ToString + ")", True)
        If Me._nuevo AndAlso Me.cbxTIPO_FINANCIAMIENTO.Value = CuentaFinanciamiento.Anticipos Then ScriptManager.RegisterClientScriptBlock(Me, Page.GetType, "script", "MostrarAnalisisFinanciero(5," + mEntidad.ID_ANTICIPO.ToString + ");" + "MostrarSolicAnticipo(" + mEntidad.ID_ANTICIPO.ToString + ")", True)
        If Me._nuevo AndAlso Me.cbxTIPO_FINANCIAMIENTO.Value = CuentaFinanciamiento.Mutuos Then ScriptManager.RegisterClientScriptBlock(Me, Page.GetType, "script", "MostrarAnalisisFinanciero(5," + mEntidad.ID_ANTICIPO.ToString + ");", True)


        Me.txtID_ANTICIPO.Text = mEntidad.ID_ANTICIPO.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function

    Public Function Anular() As String
        Dim bSolicAnticipo As New cSOLIC_ANTICIPO
        Dim mEntidad As SOLIC_ANTICIPO
        Dim lRet As Int32 = 0
        Dim sError As String

        mEntidad = (New cSOLIC_ANTICIPO).ObtenerSOLIC_ANTICIPO(Me.ID_ANTICIPO)
        mEntidad.ID_ESTADO = EstadoSolicAgricola.Anulada
        mEntidad.USUARIO_ACT = Me.ObtenerUsuario
        mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora

        bSolicAnticipo.ActualizarSOLIC_ANTICIPO(mEntidad)
        sError = bSolicAnticipo.sError

        If sError <> "" Then Return sError

        Me.ID_ANTICIPO = mEntidad.ID_ANTICIPO
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function

    Public Function AceptarAnticipo() As String
        Dim bSolicAnticipoZafra As New cSOLIC_ANTICIPO_ZAFRA
        Dim bSolicAnticipoLiqFinan As New cSOLIC_ANTICIPO_LIQFINAN
        Dim sError As New String("")
        Dim alDatos As New ArrayList

        sError = Me.Actualizar
        If sError <> "" Then Return sError

        If Me.txtCHQ_NO.Text.Trim = "" Then
            Return "Ingrese el No. de Cheque"
        End If
        If Me.dteFECHA_CHEQUE.Value Is Nothing Then
            Return "Ingrese la fecha del cheque"
        End If
        If Me.spePORC_INTERES.Value Is Nothing OrElse Me.spePORC_INTERES.Value < 0 Then
            Return "Ingrese la tasa de interes"
        End If
        If Me.cbxTIPO_FINANCIAMIENTO.Value = CuentaFinanciamiento.Mutuos Then
            If Me.spePLAZO_MESES.Value Is Nothing Then
                Return "Ingrese el plazo en meses"
            End If
            If Me.dteFECHA_VENCE.Value = Nothing Then
                Return "Ingrese la fecha de vencimiento"
            End If
            If Me.LISTA_SOLIC_ANTICIPO_ZAFRA Is Nothing OrElse Me.LISTA_SOLIC_ANTICIPO_ZAFRA.Count = 0 Then
                Return "Ingrese alguna zafra en las que se cubrira cuota"
            End If
        End If

        mEntidad = New SOLIC_ANTICIPO
        mEntidad = (New cSOLIC_ANTICIPO).ObtenerSOLIC_ANTICIPO(CInt(Me.txtID_ANTICIPO.Text))
        mEntidad.USUARIO_ACT = Me.ObtenerUsuario
        mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
        mEntidad.FECHA_CHEQUE = Me.dteFECHA_CHEQUE.Date
        mEntidad.PORC_INTERES = Me.spePORC_INTERES.Value
        mEntidad.CHQ_NO = Me.txtCHQ_NO.Text
        mEntidad.PLAZO_MESES = Me.spePLAZO_MESES.Value
        mEntidad.FECHA_VENCE = Me.dteFECHA_VENCE.Date
        mEntidad.ES_ACEPTADA = True
        mEntidad.ID_ESTADO = EstadoSolicAgricola.Aceptada
        mEntidad.PERFECHA_INI = Me.dtePeriodoPagoDel.Value
        mEntidad.PERFECHA_FIN = Me.dtePeriodoPagoAl.Value
        mEntidad.DESTINO = Me.txtDESTINO.Text.Trim.ToUpper

        If Me.cbxTIPO_FINANCIAMIENTO.Value = CuentaFinanciamiento.Anticipos OrElse Me.cbxTIPO_FINANCIAMIENTO.Value = CuentaFinanciamiento.PlanillasPago OrElse _
            Me.cbxTIPO_FINANCIAMIENTO.Value = CuentaFinanciamiento.PagoIntereses OrElse Me.cbxTIPO_FINANCIAMIENTO.Value = CuentaFinanciamiento.CajaChica Then
            Dim lEntidad As New SOLIC_ANTICIPO_ZAFRA

            If Me.LISTA_SOLIC_ANTICIPO_ZAFRA Is Nothing Then Me.LISTA_SOLIC_ANTICIPO_ZAFRA = New listaSOLIC_ANTICIPO_ZAFRA
            lEntidad.ID_ANTI_ZAFRA = 0
            lEntidad.ID_ANTICIPO = mEntidad.ID_ANTICIPO
            lEntidad.ID_ZAFRA = mEntidad.ID_ZAFRA
            lEntidad.FECHA_ULTMOV = mEntidad.FECHA_CHEQUE
            lEntidad.CUOTA = mEntidad.MONTO
            lEntidad.USUARIO_CREA = Me.ObtenerUsuario
            lEntidad.FECHA_CREA = cFechaHora.ObtenerFechaHora
            Me.LISTA_SOLIC_ANTICIPO_ZAFRA.Add(lEntidad)
        End If

        'Registrar zafras
        For Each l As SOLIC_ANTICIPO_ZAFRA In Me.LISTA_SOLIC_ANTICIPO_ZAFRA
            l.ID_ANTI_ZAFRA = 0
            l.ID_ANTICIPO = mEntidad.ID_ANTICIPO
            l.USUARIO_CREA = Me.ObtenerUsuario
            l.FECHA_CREA = cFechaHora.ObtenerFechaHora
            bSolicAnticipoZafra.ActualizarSOLIC_ANTICIPO_ZAFRA(l)
        Next

        'Registrar financiamientos a liquidar
        'Eliminar liquidaciones que están en la base y no estén en los seleccionados
        bSolicAnticipoLiqFinan.EliminarPorSOLIC_ANTICIPO(mEntidad.ID_ANTICIPO)
        '*************************************************
        'Liquidacion de financiamientos: Creación Registro 
        '*************************************************
        Dim lstLiqFinan As listaSOLIC_ANTICIPO_LIQFINAN = Me.LISTA_SOLIC_ANTICIPO_LIQFINAN
        Dim lSolicLiqFinan As SOLIC_ANTICIPO_LIQFINAN
        If lstLiqFinan IsNot Nothing AndAlso lstLiqFinan.Count > 0 Then
            For i As Integer = 0 To lstLiqFinan.Count - 1
                If (lstLiqFinan(i).ABONO + lstLiqFinan(i).INTERES_ABO + lstLiqFinan(i).INTERES_IVA_ABO) > 0 Then
                    lSolicLiqFinan = New SOLIC_ANTICIPO_LIQFINAN
                    lSolicLiqFinan = lstLiqFinan(i)
                    lSolicLiqFinan.ID_ANTICIPO = mEntidad.ID_ANTICIPO
                    lSolicLiqFinan.ID_ANTI_LIQ = 0
                    lSolicLiqFinan.UID_REFERENCIA = Guid.NewGuid.ToString()
                    bSolicAnticipoLiqFinan.ActualizarSOLIC_ANTICIPO_LIQFINAN(lSolicLiqFinan)
                End If
            Next
        End If

        If mComponente.ActualizarSOLIC_ANTICIPO(mEntidad) < 0 Then
            Return "Error al Guardar registro."
        End If
        Return ""
    End Function

    Protected Sub txtCODIPROVEE_ValueChanged(sender As Object, e As System.EventArgs) Handles txtCODIPROVEE.ValueChanged
        Me.ObtenerProveedor()
        Me.chkSelectTodosLotes.Checked = False
        Me.ucListaSOLIC_ANTICIPO_LOTE1.QuitarSelecciones()
    End Sub

    Private Sub ObtenerProveedor()
        Me.txtNOMBRE_PROVEEDOR.Text = ""
        If Me.txtCODIPROVEE.Text <> "" AndAlso Utilerias.EsNumeroEntero(Me.txtCODIPROVEE.Text) Then
            Dim lCodiprovee As String = Utilerias.FormatoCODIPROVEE(Me.txtCODIPROVEE.Text) + Utilerias.FormatoCODISOCIO(0)
            Dim lProveedor As PROVEEDOR = (New cPROVEEDOR).ObtenerPROVEEDOR(lCodiprovee)
            Dim lZafraActiva As ZAFRA = (New cZAFRA).ObtenerZafraActiva

            If lProveedor IsNot Nothing Then
                Me.txtNOMBRE_PROVEEDOR.Text = lProveedor.NOMBRES + " " + lProveedor.APELLIDOS
                Me.ObtenerContratos(Utilerias.FormatoCODIPROVEE(Me.txtCODIPROVEE.Text))
                Me.ObtenerLotes()
                Me.IniciarCargaLiquidacionFinanciamientos(lProveedor.CODIPROVEEDOR, lZafraActiva.ID_ZAFRA)
            End If
        End If
    End Sub

    Public Sub IniciarCargaLiquidacionFinanciamientos(ByVal Optional CODIPROVEEDOR As String = "", Optional ID_ZAFRA As Integer = -1)
        '*** Cargando por primera vez financiamientos pendientes de todas las zafra menores a la zafra activa
        Dim lista As New listaSOLIC_ANTICIPO_LIQFINAN
        If CODIPROVEEDOR <> "" AndAlso ID_ZAFRA <> -1 Then
            lista = (New cSOLIC_ANTICIPO_LIQFINAN).ObtenerListaPorCriterios(CODIPROVEEDOR, ID_ZAFRA)
        Else
            If Me.txtCODIPROVEE.Text <> "" AndAlso Utilerias.EsNumeroEntero(Me.txtCODIPROVEE.Text) Then
                Dim lCodiprovee As String = Utilerias.FormatoCODIPROVEE(Me.txtCODIPROVEE.Text) + Utilerias.FormatoCODISOCIO(0)
                Dim lProveedor As PROVEEDOR = (New cPROVEEDOR).ObtenerPROVEEDOR(lCodiprovee)
                Dim lZafraActiva As ZAFRA = (New cZAFRA).ObtenerZafraActiva

                If lProveedor IsNot Nothing Then
                    lista = (New cSOLIC_ANTICIPO_LIQFINAN).ObtenerListaPorCriterios(lProveedor.CODIPROVEEDOR, lZafraActiva.ID_ZAFRA)
                End If
            End If
        End If
        If lista IsNot Nothing AndAlso lista.Count > 0 Then
            For i = 0 To lista.Count - 1
                lista(i).UID_REFERENCIA = Me.lblREFERENCIA_LIQFINAN.Text
            Next
        Else
            lista = New listaSOLIC_ANTICIPO_LIQFINAN
        End If
        Me.LISTA_SOLIC_ANTICIPO_LIQFINAN = lista
        Me.CargarDetalleAnticipoLiqFinan()
        Me.ActualizarTOTAL_LIQUIDAR()
    End Sub

    Private Sub ObtenerLotes()
        Dim sCodiProveedor As String

        If Not Utilerias.EsNumeroEntero(txtCODIPROVEE.Value) Then
            sCodiProveedor = Utilerias.FormatoCODIPROVEE(0)
        Else
            sCodiProveedor = Utilerias.FormatoCODIPROVEE(txtCODIPROVEE.Value) + Utilerias.FormatoCODISOCIO(0)
        End If

        Me.LISTA_SOLIC_ANTICIPO_LOTE = (New cSOLIC_ANTICIPO_LOTE).ObtenerListaPorZAFRA_CONTRATADA_PROVEEDOR_CONTRATADO(cbxZAFRA.Value, sCodiProveedor)
        Me.CargarDetalleAnticipoLotes()
        Me.chkSelectTodosLotes.Checked = False
        Me.ucListaSOLIC_ANTICIPO_LOTE1.QuitarSelecciones()
    End Sub

    Private Sub ObtenerContratos(ByVal CODIPROVEE As String)
        Me.ucListaCONTRATO1.CargarDatosPorCriterios(Me.cbxZAFRA.Value, -1, CODIPROVEE, "")
    End Sub

    Private Sub ConfigVencimientoPlazo()
        trVENCIMIENTO_PLAZO.Visible = (cbxTIPO_FINANCIAMIENTO.Value = Enumeradores.CuentaFinanciamiento.Mutuos)
    End Sub

    Private Function ObtenerIdAntiZafra(ByVal lista As listaSOLIC_ANTICIPO_ZAFRA) As Int32
        Dim Id As Int32 = 0
        For i As Integer = 0 To lista.Count - 1
            If lista(i).ID_ANTI_ZAFRA > Id Then
                Id = lista(i).ID_ANTI_ZAFRA
            End If
        Next
        Return (Id + 1)
    End Function

    Protected Sub btnAgregarZafra_Click(sender As Object, e As EventArgs) Handles btnAgregarZafra.Click
        If Me.cbxZAFRAdeta.Value Is Nothing Then
            Me.AsignarMensaje("* Seleccione una zafra", True, False)
            Return
        End If
        If Me.dteFECHA_ULTMOV.Date = #12:00:00 AM# Then
            Me.AsignarMensaje("* Ingrese la fecha de último movimiento", True, False)
            Return
        End If
        If Me.speCUOTA.Value = Nothing OrElse Me.speCUOTA.Value = 0 Then
            Me.AsignarMensaje("* Ingrese el monto de la cuota", True, False)
            Return
        End If

        Dim lEntidad As New SOLIC_ANTICIPO_ZAFRA

        If LISTA_SOLIC_ANTICIPO_ZAFRA Is Nothing Then LISTA_SOLIC_ANTICIPO_ZAFRA = New listaSOLIC_ANTICIPO_ZAFRA

        'Verificar si la zafra ya está agregada
        For Each l As SOLIC_ANTICIPO_ZAFRA In LISTA_SOLIC_ANTICIPO_ZAFRA
            If l.ID_ZAFRA = Me.cbxZAFRAdeta.Value Then
                Me.AsignarMensaje("* La zafra seleccionada ya está incluida", True, False)
                Return
            End If
        Next
        lEntidad.ID_ANTI_ZAFRA = Me.ObtenerIdAntiZafra(LISTA_SOLIC_ANTICIPO_ZAFRA)
        lEntidad.ID_ANTICIPO = 0
        lEntidad.ID_ZAFRA = Me.cbxZAFRAdeta.Value
        lEntidad.FECHA_ULTMOV = Me.dteFECHA_ULTMOV.Date
        lEntidad.CUOTA = Me.speCUOTA.Value
        lEntidad.REFERENCIA = Me.lblREFERENCIA.Text

        LISTA_SOLIC_ANTICIPO_ZAFRA.Add(lEntidad)
        Me.CargarDetalleAnticipoZafra()

        Me.cbxZAFRAdeta.Value = Nothing
        Me.dteFECHA_ULTMOV.Value = Nothing
        Me.speCUOTA.Value = 0
    End Sub

    Protected Sub cbxZAFRA_ValueChanged(sender As Object, e As EventArgs) Handles cbxZAFRA.ValueChanged
        If Me.txtCODIPROVEE.Text = "" Then
            Me.ObtenerContratos("*")
        Else
            Me.ObtenerContratos(Utilerias.FormatoCODIPROVEE(Me.txtCODIPROVEE.Text))
        End If
    End Sub

    Private Sub chkSelectTodosLotes_CheckedChanged(sender As Object, e As EventArgs) Handles chkSelectTodosLotes.CheckedChanged
        If Me.chkSelectTodosLotes.Checked Then
            Me.ucListaSOLIC_ANTICIPO_LOTE1.SeleccionarTodos()
        Else
            Me.ucListaSOLIC_ANTICIPO_LOTE1.QuitarSelecciones()
        End If
    End Sub

    Private Sub cbxTIPO_FINANCIAMIENTO_ValueChanged(sender As Object, e As EventArgs) Handles cbxTIPO_FINANCIAMIENTO.ValueChanged
        ASPxPageControl1.TabPages(2).ClientEnabled = (cbxTIPO_FINANCIAMIENTO.Value = Enumeradores.CuentaFinanciamiento.Mutuos OrElse
            cbxTIPO_FINANCIAMIENTO.Value = Enumeradores.CuentaFinanciamiento.Anticipos)
    End Sub

    Private Sub ucListaSOLIC_ANTICIPO_LIQFINAN1_Liquidar(ID_ANTI_LIQ As Integer) Handles ucListaSOLIC_ANTICIPO_LIQFINAN1.Liquidar
        Me.ActualizarTOTAL_LIQUIDAR()
    End Sub

    Function ActualizarTOTAL_LIQUIDAR() As Decimal
        Dim lista As listaSOLIC_ANTICIPO_LIQFINAN = Me.LISTA_SOLIC_ANTICIPO_LIQFINAN
        Dim total As Decimal = 0

        If lista IsNot Nothing AndAlso lista.Count > 0 Then
            For i As Integer = 0 To lista.Count - 1
                total += lista(i).ABONO + lista(i).INTERES_ABO + lista(i).INTERES_IVA_ABO
            Next
            Me.lblTotalLiquidar.Text = total.ToString("$ #,##0.00")
        Else
            Me.lblTotalLiquidar.Text = "$ 0.00"
        End If

        Return total
    End Function
End Class
