Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetalleCONTROL_ROZA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla CONTROL_ROZA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	29/11/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleCONTROL_ROZA
    Inherits ucBase
 
#Region"Propiedades"

    Public Property TIPO_INGRESO As TipoIngresoQuemaRoza
        Get
            If Me.ViewState("TIPO_INGRESO") Is Nothing Then
                Return -1
            Else
                Return CInt(Me.ViewState("TIPO_INGRESO"))
            End If
        End Get
        Set(value As TipoIngresoQuemaRoza)
            Me.ViewState("TIPO_INGRESO") = value
        End Set
    End Property

    Private _ID_LOTES_COSECHA As Int32
    Public Property ID_LOTES_COSECHA() As Int32
        Get
            Return _ID_LOTES_COSECHA
        End Get
        Set(ByVal Value As Int32)
            Me.Nuevo()
            _ID_LOTES_COSECHA = Value
            Session("controlRoza_IdLotesCosecha") = Value
            If Value > 0 Then
                Me.CargarDatos()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property ACCESLOTE() As String
        Get
            If Me.ViewState("ACCESLOTE") Is Nothing Then
                Return ""
            Else
                Return Me.ViewState("ACCESLOTE")
            End If
        End Get
        Set(ByVal value As String)
            Me.ViewState("ACCESLOTE") = value
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
                    Me.cbxID_TIPO_ROZA.Value = CInt(value)
                Else
                    Me.cbxID_TIPO_ROZA.Value = Nothing
                End If
            End If
        End Set
    End Property

    Public Property ID_PROVEEDOR_ROZA() As Object
        Get
            Return Me.cbxID_PROVEEDOR_ROZA.Value
        End Get
        Set(ByVal value As Object)
            If IsNumeric(value) AndAlso value = -1 Then
                Me.cbxID_PROVEEDOR_ROZA.Value = Nothing
            Else
                If Me.cbxID_PROVEEDOR_ROZA.Items.FindByValue(CInt(value)) IsNot Nothing Then
                    Me.cbxID_PROVEEDOR_ROZA.Value = CInt(value)
                Else
                    Me.cbxID_PROVEEDOR_ROZA.Value = Nothing
                End If
            End If
        End Set
    End Property

    Private _ID_CONTROL_ROZA As Int32
    Public Property ID_CONTROL_ROZA() As Int32
        Get
            Return 0
        End Get
        Set(ByVal Value As Int32)
            Me._ID_CONTROL_ROZA = Value
            Me.txtID_CONTROL_ROZA.Text = CStr(Value)
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


    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cCONTROL_ROZA
    Private mEntidad As CONTROL_ROZA

    Private moduloComponente As New cLOTES_COSECHA
    Private moduloEntidad As LOTES_COSECHA
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

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquÃ­ el cÃ³digo de usuario para inicializar la pÃ¡gina
        If Not Me.ViewState("nuevo") Is Nothing Then Me._nuevo = Me.ViewState("nuevo")
        If Not Me.ViewState("ID_LOTES_COSECHA") Is Nothing Then Me._ID_LOTES_COSECHA = Me.ViewState("ID_LOTES_COSECHA")
    End Sub


    'Private Sub CargarSubLotes(Optional ID_SUBLOTE_SELECCIONAR As Int32 = -1)
    '    Dim lista As listaSUBLOTES = (New cSUBLOTES).ObtenerListaPorLOTES_COSECHA(Me.ID_LOTES_COSECHA)
    '    If lista Is Nothing Then lista = New listaSUBLOTES
    '    cbxSUBLOTES.DataSource = lista
    '    cbxSUBLOTES.DataBind()
    '    If ID_SUBLOTE_SELECCIONAR = -1 Then
    '        cbxSUBLOTES.SelectedIndex = -1
    '    Else
    '        cbxSUBLOTES.Value = ID_SUBLOTE_SELECCIONAR
    '    End If

    'End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla CONTROL_ROZA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        moduloEntidad = New LOTES_COSECHA
        moduloEntidad.ID_LOTES_COSECHA = ID_LOTES_COSECHA
        If moduloComponente.ObtenerLOTES_COSECHA(moduloEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.ACCESLOTE = moduloEntidad.ACCESLOTE
        Me.cbxZAFRA.Value = moduloEntidad.ID_ZAFRA
        Dim lLote As LOTES = (New cLOTES).ObtenerLOTES(moduloEntidad.ACCESLOTE)
        If lLote IsNot Nothing Then
            Dim lProveedor As PROVEEDOR = (New cPROVEEDOR).ObtenerPROVEEDOR(lLote.CODIPROVEEDOR)

            Me.txtCODIPROVEE.Text = CInt(lProveedor.CODIPROVEE).ToString
            If lProveedor.CODISOCIO <> Utilerias.FormatoCODISOCIO(0) Then Me.txtCODISOCIO.Text = CInt(lProveedor.CODISOCIO).ToString
            Me.txtNOMBRE_PROVEEDOR.Text = lProveedor.NOMBRES + " " + lProveedor.APELLIDOS
        
            Me.txtCODILOTE.Text = lLote.CODILOTE
            Me.txtNOMLOTE.Text = lLote.NOMBLOTE
            Dim lVariedad As VARIEDAD = (New cVARIEDAD).ObtenerVARIEDAD(lLote.CODIVARIEDA)
            If lVariedad IsNot Nothing Then Me.txtVARIEDAD.Text = lVariedad.NOM_VARIEDAD
            Me.ucListaCONTROL_ROZA_SALDO1.CargarDatosPorCriterios(Me.cbxZAFRA.Value, Me.ACCESLOTE, -1, -1, -1, "", "", -1, -1, -1, "", -1, -1, 1, -1, -1)
            Me.ucListaCONTROL_ROZA_SALDO1.QuitarSeleccion()
        End If

        Dim lLoteCosecha As LOTES_COSECHA = (New cLOTES_COSECHA).ObtenerLOTES_COSECHAPorLOTE_ZAFRA(moduloEntidad.ACCESLOTE, moduloEntidad.ID_ZAFRA)
        If lLoteCosecha IsNot Nothing Then
            Dim lTecnico As AGRONOMO = (New cAGRONOMO).ObtenerAGRONOMO(lLoteCosecha.CODIAGRON)
            Dim dRozaEjecutada As Decimal = _
                (New cCONTROL_ROZA).ObtenerRozaEjecutadaPorZAFRA_LOTE(lLoteCosecha.ID_ZAFRA, lLoteCosecha.ACCESLOTE)

            If lTecnico IsNot Nothing Then Me.txtTECNICO_ZONA.Text = lTecnico.NOMBRE_AGRONOMO + " " + lTecnico.APELLIDO_AGRONOMO
            Me.cbxID_TIPO_CANA.Value = lLoteCosecha.ID_TIPO_CANA
            Me.txtSALDO_ROZA.Value = lLoteCosecha.SALDO_ROZA
            Me.txtSALDO_QUEMA.Value = lLoteCosecha.SALDO_QUEMA
            Me.txtESTICANA.Value = lLoteCosecha.TONEL_CENSO
            Me.txtROZA_EJECUTADA.Value = dRozaEjecutada
            Me.txtDIF_ESTICANA_ROZA.Value = lLoteCosecha.TONEL_CENSO - dRozaEjecutada
            Me.SetSaldoPorTipoQuema(lLoteCosecha.ID_ZAFRA, lLoteCosecha.ACCESLOTE)
        Else
            Me.txtSALDO_ROZA.Value = 0
        End If
        Dim lDiaZafra As DIA_ZAFRA
        lDiaZafra = (New cDIA_ZAFRA).ObtenerDiaZafraActivo(moduloEntidad.ID_ZAFRA)
        If lDiaZafra IsNot Nothing Then Me.txtDIAZAFRA.Value = lDiaZafra.DIAZAFRA
        Me.CargarTipoRoza()
        Me.CargarProveedorRoza()
        'Me.CargarQuemaDisponible(moduloEntidad.ID_ZAFRA, moduloEntidad.ACCESLOTE)
        'Me.CargarSubLotes()
    End Sub

    Public Sub ControlRozaSaldoActualizar()
        Me.ucListaCONTROL_ROZA_SALDO1.CargarDatosPorCriterios(Me.cbxZAFRA.Value, Me.ACCESLOTE, -1, -1, -1, "", "", -1, -1, -1, "", -1, -1, 1, -1, -1)
        Me.ucListaCONTROL_ROZA_SALDO1.QuitarSeleccion()
    End Sub

    Private Sub CargarQuemaDisponible(ByVal idZafra As Int32, ByVal acceslote As String, ByVal idSubLotes As Int32)
        Dim lista As listaCONTROL_QUEMA_SALDO = (New cCONTROL_QUEMA_SALDO).ObtenerListaPorCriterios(idZafra, acceslote, Nothing, -1, -1, -1, -1, 0, idSubLotes, "FECHA_HORA_QUEMA", "ASC")
        Dim lControlQuema As New CONTROL_QUEMA_SALDO

        If lista Is Nothing Then lista = New listaCONTROL_QUEMA_SALDO
        For i As Int32 = 0 To lista.Count - 1
            lista(i).USUARIO_CREA = If(lista(i).QUEMA_PROGRAMADA, "QUEMA PROGRAMADA: ", "QUEMA NO PROGRAM:  ") + lista(i).FECHA_HORA_QUEMA.ToString("dd/MM/yyyy HH:mm") + " - SALDO DISPONIBLE: " + lista(i).SALDO.ToString("#,##0.00") + If(lista(0).ES_PROYECCION, " (PROYECTADA)", "")
        Next

        lControlQuema.ID_QUEMA_SALDO = -1
        lControlQuema.USUARIO_CREA = "(NO APLICA QUEMA)"
        lista.Insertar(lista.Count, lControlQuema)

        Me.cbxQuemaDisponible.DataSource = lista
        Me.cbxQuemaDisponible.DataBind()
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
        Me.cbxZAFRA.ClientEnabled = False
        Me.txtCODIPROVEE.ClientEnabled = False
        Me.txtCODISOCIO.ClientEnabled = False
        Me.txtNOMBRE_PROVEEDOR.ClientEnabled = False
        Me.txtNOMLOTE.ClientEnabled = False
        Me.txtCODILOTE.ClientEnabled = False
        Me.txtVARIEDAD.ClientEnabled = False
        Me.txtDIAZAFRA.ClientEnabled = False
        Me.txtENTRADAS.ClientEnabled = edicion
        Me.txtSALDO_ROZA.ClientEnabled = False
        Me.dteFECHA_HORA_ROZA.ClientEnabled = edicion
        Me.txtESTICANA.ClientEnabled = False
        Me.txtROZA_EJECUTADA.ClientEnabled = False
        Me.txtDIF_ESTICANA_ROZA.ClientEnabled = False
        Me.txtQUEMA_QUEMA_PROGRAMADA.ClientEnabled = False
        Me.txtQUEMA_QUEMA_NOPROG.ClientEnabled = False
        Me.txtQUEMA_CANA_VERDE.ClientEnabled = False
        Me.txtSALDO_QUEMA_PROGRAMADA.ClientEnabled = False
        Me.txtSALDO_QUEMA_NOPROG.ClientEnabled = False
        Me.txtCANA_VERDE.ClientEnabled = False
        Me.txtTECNICO_ZONA.ClientEnabled = False
        Me.chkES_PROYECCION.ClientEnabled = False
        If Me.TIPO_INGRESO = TipoIngresoQuemaRoza.Proyectada Then
            Me.chkES_PROYECCION.Checked = True
            Me.chkES_PROYECCION.ClientVisible = True
        Else
            Me.chkES_PROYECCION.Checked = False
            Me.chkES_PROYECCION.ClientVisible = False
        End If
        'Me.chkQuerqueo.ClientEnabled = edicion
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
        Me.txtCODIPROVEE.Text = ""
        Me.txtCODISOCIO.Text = ""
        Me.dteFECHA_HORA_ROZA.Value = Nothing
        Me.txtNOMBRE_PROVEEDOR.Text = ""
        Me.txtCODILOTE.Text = ""
        Me.txtNOMLOTE.Text = ""
        Me.txtVARIEDAD.Text = ""
        Me.txtDIAZAFRA.Value = Nothing
        Me.txtENTRADAS.Value = Nothing
        Me.txtSALDO_ROZA.Value = Nothing
        Me.cbxID_TIPO_CANA.Value = Nothing
        Me.cbxID_TIPO_ROZA.Value = Nothing
        Me.cbxID_PROVEEDOR_ROZA.Value = Nothing
        Me.chkES_PROYECCION.Checked = False
        'Me.chkQuerqueo.Checked = False
        Me.txtTECNICO_ZONA.Text = ""
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        Dim lDiaZafra As DIA_ZAFRA
        If lZafra IsNot Nothing Then
            Me.cbxZAFRA.Value = lZafra.ID_ZAFRA
            lDiaZafra = (New cDIA_ZAFRA).ObtenerDiaZafraActivo(lZafra.ID_ZAFRA)
            If lDiaZafra IsNot Nothing Then Me.txtDIAZAFRA.Value = lDiaZafra.DIAZAFRA
        End If
        Me.ucListaCONTROL_ROZA1.CargarDatosPorZAFRA_LOTE(-2, "*", "ID_CONTROL_ROZA", "DESC")
        'Me.CargarSubLotes()
    End Sub

    Private Sub CargarTipoRoza()
        Dim lOrigen As listaTIPOS_GENERALES = (New cTIPOS_GENERALES).ObtenerListaPorCriterios(-1, Enumeradores.CAT.TipoCAT.Roza, -1)
        Dim lDestino As New listaTIPOS_GENERALES

        If Me.cbxID_TIPO_CANA.Value IsNot Nothing Then
            Dim lPermitido As List(Of Int32) = configuracion.RozaEnTipoCana(Me.cbxID_TIPO_CANA.Value)
            For Each lTipo As TIPOS_GENERALES In lOrigen
                If lPermitido.Contains(lTipo.ID_TIPO) Then
                    lDestino.Add(lTipo)
                End If
            Next
        End If
        Me.cbxID_TIPO_ROZA.DataSource = lDestino
        Me.cbxID_TIPO_ROZA.DataBind()
        Me.cbxID_TIPO_ROZA.Text = ""
    End Sub

    Private Sub CargarProveedorRoza()
        Dim lProveedores As New listaPROVEEDOR_ROZA

        If Me.cbxID_TIPO_ROZA.Value IsNot Nothing Then
            lProveedores = (New cPROVEEDOR_ROZA).ObtenerListaPorTIPO_ROZA(Me.cbxID_TIPO_ROZA.Value)
        End If
        If lProveedores IsNot Nothing AndAlso lProveedores.Count > 0 Then
            For i As Integer = 0 To lProveedores.Count - 1
                If Not Left(lProveedores(i).NOMBRE_PROVEEDOR_ROZA, 2) = "RZ" Then
                    lProveedores(i).NOMBRE_PROVEEDOR_ROZA = lProveedores(i).CODIGO + " - " + lProveedores(i).NOMBRE_PROVEEDOR_ROZA.Trim + " " + lProveedores(i).APELLIDOS.Trim
                End If
            Next

        End If
        Me.cbxID_PROVEEDOR_ROZA.DataSource = lProveedores
        Me.cbxID_PROVEEDOR_ROZA.DataBind()
        Me.cbxID_PROVEEDOR_ROZA.Text = ""
        If Me.cbxID_PROVEEDOR_ROZA.Items.Count = 1 Then Me.cbxID_PROVEEDOR_ROZA.SelectedIndex = 0
    End Sub

    Public Function ControlRozaSaldoSelecionado() As CONTROL_ROZA_SALDO
        Dim listaRoza As listaCONTROL_ROZA_SALDO = Me.ucListaCONTROL_ROZA_SALDO1.DevolverSeleccionados
        If listaRoza IsNot Nothing AndAlso listaRoza.Count > 0 Then
            Return listaRoza(0)
        Else
            Return Nothing
        End If
    End Function

    Public Function LiquidarSaldoRoza(ByVal ID_ROZA_SALDO As Int32, Optional TC As Decimal = -1) As String
        Dim bControlRoza As New cCONTROL_ROZA
        Dim lControlRoza As New CONTROL_ROZA
        Dim bControlRozaSaldo As New cCONTROL_ROZA_SALDO
        Dim lControlRozaSaldo As CONTROL_ROZA_SALDO
        Dim lDiaZafra As DIA_ZAFRA
        Dim lLotesCosecha As LOTES_COSECHA
        Dim bLotesCosecha As New cLOTES_COSECHA

        lControlRozaSaldo = bControlRozaSaldo.ObtenerCONTROL_ROZA_SALDO(ID_ROZA_SALDO)
        If lControlRozaSaldo IsNot Nothing Then
            If lControlRozaSaldo.SALDO = 0 Then
                Return "* El inventario de Roza seleccionado no posee saldo"
            End If
            lControlRoza.ID_CONTROL_ROZA = 0
            lControlRoza.ID_ZAFRA = Me.cbxZAFRA.Value
            lControlRoza.ACCESLOTE = Me.ACCESLOTE
            lDiaZafra = (New cDIA_ZAFRA).ObtenerDiaZafraActivo(Me.cbxZAFRA.Value)
            If lDiaZafra IsNot Nothing Then lControlRoza.DIAZAFRA = lDiaZafra.DIAZAFRA
            lControlRoza.FECHA_HORA_QUEMA = lControlRozaSaldo.FECHA_HORA_QUEMA
            lControlRoza.FECHA_HORA_ROZA = lControlRozaSaldo.FECHA_HORA_ROZA
            lControlRoza.ID_PROVEEDOR_ROZA = -1
            If TC = -1 Then
                TC = lControlRozaSaldo.SALDO
                lControlRoza.CONCEPTO = "MOVIMIENTO DE LIQUIDACION TOTAL DE SALDO EN FECHA " + cFechaHora.ObtenerFechaHora.ToString("dd/MM/yyyy HH:mm")
            Else
                lControlRoza.CONCEPTO = "MOVIMIENTO DE LIQUIDACION PARCIAL DE SALDO EN FECHA " + cFechaHora.ObtenerFechaHora.ToString("dd/MM/yyyy HH:mm")
            End If
            lControlRoza.CODIGO_REF = "AJUSTE"
            lControlRoza.ID_REF = -1
            lControlRoza.ENTRADAS = 0
            lControlRoza.SALIDAS = TC
            lControlRoza.SALDO = 0
            lControlRoza.ID_TIPO_CANA = lControlRozaSaldo.ID_TIPO_CANA
            lControlRoza.ID_TIPO_ROZA = lControlRozaSaldo.ID_TIPO_ROZA
            lControlRoza.USUARIO_CREA = Me.ObtenerUsuario
            lControlRoza.FECHA_CREA = cFechaHora.ObtenerFechaHora
            lControlRoza.USUARIO_ACT = Me.ObtenerUsuario
            lControlRoza.FECHA_ACT = cFechaHora.ObtenerFechaHora
            lControlRoza.QUEMA_PROGRAMADA = lControlRozaSaldo.QUEMA_PROGRAMADA
            lControlRoza.QUEMA_NOPROG = lControlRozaSaldo.QUEMA_NOPROG
            lControlRoza.CANA_VERDE = lControlRozaSaldo.CANA_VERDE
            lControlRoza.ID_ROZA_SALDO = lControlRozaSaldo.ID_ROZA_SALDO
            lControlRoza.ES_PROYECCION = lControlRozaSaldo.ES_PROYECCION
            lControlRoza.ID_SUBLOTES = lControlRozaSaldo.ID_SUBLOTES

            If bControlRoza.ActualizarCONTROL_ROZA(lControlRoza) <> 1 Then
                Return "Error al actualizar Control de Roza: " + mComponente.sError
            End If

            lLotesCosecha = (New cLOTES_COSECHA).ObtenerLOTES_COSECHAPorLOTE_ZAFRA(Me.ACCESLOTE, Me.cbxZAFRA.Value)
            If lLotesCosecha IsNot Nothing Then
                lLotesCosecha.USUARIO_ACT = Me.ObtenerUsuario
                lLotesCosecha.FECHA_ACT = cFechaHora.ObtenerFechaHora
                If bLotesCosecha.ActualizarLOTES_COSECHA(lLotesCosecha) < 1 Then
                    Return "Error al actualizar el Saldo del Lote para esta Zafra: " + bControlRozaSaldo.sError
                End If
            End If

            lLotesCosecha = (New cLOTES_COSECHA).ObtenerLOTES_COSECHAPorLOTE_ZAFRA(Me.ACCESLOTE, Me.cbxZAFRA.Value)
            Me.txtSALDO_ROZA.Value = lLotesCosecha.SALDO_ROZA
            Me.txtSALDO_QUEMA.Value = lLotesCosecha.SALDO_QUEMA
            Dim dRozaEjecutada As Decimal = _
                (New cCONTROL_ROZA).ObtenerRozaEjecutadaPorZAFRA_LOTE(lLotesCosecha.ID_ZAFRA, lLotesCosecha.ACCESLOTE)

            Me.txtROZA_EJECUTADA.Value = dRozaEjecutada
            Me.txtESTICANA.Value = lLotesCosecha.TONEL_CENSO
            Me.txtDIF_ESTICANA_ROZA.Value = lLotesCosecha.TONEL_CENSO - dRozaEjecutada
            Me.SetSaldoPorTipoQuema(lLotesCosecha.ID_ZAFRA, lLotesCosecha.ACCESLOTE)
            Me.ControlRozaSaldoActualizar()
        Else
            Return "* Seleccione un inventario de Roza."
        End If

        AsignarMensaje("El inventario de Roza seleccionado se liquido con exito", False, True, True)
        Return ""
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla CONTROL_ROZA
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
        Dim bLoteControlQuema As New cCONTROL_QUEMA
        Dim bLoteCosecha As New cLOTES_COSECHA
        Dim lLoteCosecha As LOTES_COSECHA
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        Dim lDiaZafra As DIA_ZAFRA
        'Dim fechaHoraUltiMovRoza As DateTime
        Dim acum As Decimal = 0
        Dim saldoQuema As Decimal = 0
        Dim montoRoza As Decimal = 0
        Dim lQuemaDisponible As CONTROL_QUEMA_SALDO
        mEntidad = New CONTROL_ROZA

        If Me.cbxZAFRA.Value Is Nothing Then
            Return "* No se ha especificado la Zafra"
        End If
        If Me.txtENTRADAS.Value Is Nothing OrElse Me.txtENTRADAS.Value = 0 Then
            Return "* Asigne un valor a Roza del Di­a"
        End If
        If Me.dteFECHA_HORA_ROZA.Value Is Nothing Then
            Return "* Ingrese la fecha y hora de roza"
        End If
        If Me.TIPO_INGRESO = TipoIngresoQuemaRoza.Ejecutada Then
            If Me.dteFECHA_HORA_ROZA.Date > cFechaHora.ObtenerFechaHora Then
                Return "* Fecha de roza no puede ser mayor a la fecha actual"
            End If
        Else
            If Me.dteFECHA_HORA_ROZA.Date <= cFechaHora.ObtenerFechaHora Then
                Return "* Fecha de roza no puede ser menor a la fecha actual debido a que es una proyeccion"
            End If
        End If

        If Math.Abs(DateDiff(DateInterval.Day, Me.dteFECHA_HORA_ROZA.Date, cFechaHora.ObtenerFechaHora)) > 7 Then
            Return "* Fecha de roza no puede ser menor a 7 dias"
        End If
        If Me.cbxID_TIPO_CANA.Value Is Nothing Then
            Return "* Seleccione la forma de cosecha"
        End If
        If Me.cbxID_TIPO_ROZA.Value Is Nothing Then
            Return "* Seleccione el tipo de roza"
        End If
        If Me.cbxID_PROVEEDOR_ROZA.Items.Count > 0 AndAlso Me.cbxID_PROVEEDOR_ROZA.Value Is Nothing Then
            Return "* Seleccione el proveedor de roza"
        End If
        If Me.cbxSUBLOTES.Value Is Nothing Then
            Return "* Seleccione una porción"
        End If
        If Me.cbxQuemaDisponible.Value Is Nothing Then
            Return "* Seleccione la Quema disponible"
        End If
        If Me.cbxQuemaDisponible.Value > 0 Then
            'Validar que el saldo de la quema sea mayor o igual a la roza
            lQuemaDisponible = (New cCONTROL_QUEMA_SALDO).ObtenerCONTROL_QUEMA_SALDO(Me.cbxQuemaDisponible.Value)
            If lQuemaDisponible IsNot Nothing Then
                If Me.dteFECHA_HORA_ROZA.Date < lQuemaDisponible.FECHA_HORA_QUEMA Then
                    Return "* La fecha/hora de roza no puede ser menor a la fecha de quema " + lQuemaDisponible.FECHA_HORA_QUEMA.ToString("dd/MM/yyyy hh:mm tt")
                End If
                If lQuemaDisponible.SALDO < Me.txtENTRADAS.Value Then
                    Return "* Las Toneladas Rozadas sobrepasan el saldo de Quema. Ingrese movimiento de Quema para el Lote"
                End If
            End If
        End If


        'fechaHoraUltiMovRoza = (New cCONTROL_ROZA).ObtenerULTIMA_FECHA_ROZA_DISPO_MOVTO(Me.cbxZAFRA.Value, Me.ACCESLOTE)
        'If fechaHoraUltiMovRoza <> #12:00:00 AM# AndAlso fechaHoraUltiMovRoza > Me.dteFECHA_HORA_ROZA.Date Then
        '    Return "* Fecha/hora de roza no puede ser menor a la fecha del último movimiento"
        'End If


        ' ************************************************************************************************
        'Validar la fecha de roza y el tipo de roza contra la primera salida del inventario de quema
        'Dim inventarioQuema As listaCONTROL_QUEMA_SALDO
        'Dim bCtrlQuema As New cCONTROL_QUEMA_SALDO

        'inventarioQuema = bCtrlQuema.ObtenerPS_CONTROL_QUEMA(Me.cbxZAFRA.Value, Me.ACCESLOTE)

        'If inventarioQuema IsNot Nothing AndAlso inventarioQuema.Count > 0 Then
        '    If Me.dteFECHA_HORA_ROZA.Date < inventarioQuema(0).FECHA_HORA_QUEMA Then
        '        Return "* La fecha/hora de roza no puede ser menor a la proxima fecha de salida del inventario de quema " + inventarioQuema(0).FECHA_HORA_QUEMA.ToString("dd/MM/yyyy hh:mm tt") + ". No puede rozar antes de quemar"
        '    End If
        '    saldoQuema = 0
        '    For i As Int32 = 0 To inventarioQuema.Count - 1
        '        saldoQuema += inventarioQuema(i).SALDO
        '    Next
        '    If saldoQuema - Me.txtENTRADAS.Value < 0 Then
        '        Return "* Las Toneladas Rozadas sobrepasan el saldo de Quema. Ingrese movimiento de Quema para el Lote"
        '    End If
        'Else
        '    Return "* No existe movimiento de Quema para el Lote. Verifique el saldo de Quema del lote"
        'End If
        ' *************************************************************************************************       

        lLoteCosecha = (New cLOTES_COSECHA).ObtenerLOTES_COSECHAPorLOTE_ZAFRA(Me.ACCESLOTE, Me.cbxZAFRA.Value)
        montoRoza = CDec(Me.txtENTRADAS.Value)

        mEntidad.ID_CONTROL_ROZA = 0
        mEntidad.ID_ZAFRA = Me.cbxZAFRA.Value
        mEntidad.ACCESLOTE = Me.ACCESLOTE
        lDiaZafra = (New cDIA_ZAFRA).ObtenerDiaZafraActivo(Me.cbxZAFRA.Value)
        If lDiaZafra IsNot Nothing Then mEntidad.DIAZAFRA = lDiaZafra.DIAZAFRA
        mEntidad.FECHA_HORA_ROZA = Me.dteFECHA_HORA_ROZA.Date
        If Not Utilerias.EsNumeroEntero(Me.cbxID_PROVEEDOR_ROZA.Value) OrElse Me.cbxID_PROVEEDOR_ROZA.Value Is Nothing OrElse Me.cbxID_PROVEEDOR_ROZA.Value = 0 Then
            mEntidad.ID_PROVEEDOR_ROZA = -1
        Else
            mEntidad.ID_PROVEEDOR_ROZA = Me.cbxID_PROVEEDOR_ROZA.Value
        End If
        mEntidad.CONCEPTO = If(Me.TIPO_INGRESO = TipoIngresoQuemaRoza.Ejecutada, "ROZA EJECUTADA", "ROZA PROYECTADA")
        mEntidad.CODIGO_REF = If(Me.TIPO_INGRESO = TipoIngresoQuemaRoza.Ejecutada, "ROZADIA", "PROYECCION")
        mEntidad.ENTRADAS = Me.txtENTRADAS.Value
        mEntidad.SALIDAS = 0
        If lLoteCosecha IsNot Nothing Then
            mEntidad.SALDO = lLoteCosecha.SALDO_ROZA + mEntidad.ENTRADAS
            lLoteCosecha.SALDO_ROZA = lLoteCosecha.SALDO_ROZA + mEntidad.ENTRADAS
        Else
            mEntidad.SALDO = mEntidad.ENTRADAS
        End If
        mEntidad.ID_TIPO_CANA = Me.cbxID_TIPO_CANA.Value
        mEntidad.ID_TIPO_ROZA = Me.cbxID_TIPO_ROZA.Value
        mEntidad.USUARIO_CREA = Me.ObtenerUsuario
        mEntidad.FECHA_CREA = cFechaHora.ObtenerFechaHora
        mEntidad.USUARIO_ACT = Me.ObtenerUsuario
        mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
        If lQuemaDisponible IsNot Nothing Then
            mEntidad.ID_REF = lQuemaDisponible.ID_QUEMA_SALDO
            mEntidad.QUEMA_PROGRAMADA = lQuemaDisponible.QUEMA_PROGRAMADA
            mEntidad.QUEMA_NOPROG = lQuemaDisponible.QUEMA_NOPROG
            mEntidad.CANA_VERDE = False
            mEntidad.FECHA_HORA_QUEMA = lQuemaDisponible.FECHA_HORA_QUEMA
        Else
            mEntidad.ID_REF = -1
            mEntidad.QUEMA_PROGRAMADA = False
            mEntidad.QUEMA_NOPROG = False
            mEntidad.CANA_VERDE = True
            mEntidad.FECHA_HORA_QUEMA = Nothing
        End If
        mEntidad.ES_PROYECCION = Me.chkES_PROYECCION.Checked
        mEntidad.ID_ROZA_SALDO = -1
        If Me.cbxPROVEEDOR_QUERQUEO.Value = -1 Then
            mEntidad.ES_QUERQUEO = False
            mEntidad.ID_PROVEE_QQ = -1
        Else
            mEntidad.ES_QUERQUEO = True
            mEntidad.ID_PROVEE_QQ = Convert.ToInt32(Me.cbxPROVEEDOR_QUERQUEO.Value)
        End If
        mEntidad.ID_SUBLOTES = Me.cbxSUBLOTES.Value


        'If Me.TIPO_INGRESO = TipoIngresoQuemaRoza.Ejecutada Then
        '    'Liquidar el saldo proyectado con fecha menor o igual a la fecha del movimiento de quema
        '    Dim lstControlRozaSaldo As listaCONTROL_ROZA_SALDO = (New cCONTROL_ROZA_SALDO).ObtenerListaPorCriterios(mEntidad.ID_ZAFRA, mEntidad.ACCESLOTE, -1, -1, -1, -1, -1, -1, "", -1, 1, True)
        '    If lstControlRozaSaldo IsNot Nothing AndAlso lstControlRozaSaldo.Count > 0 Then
        '        For Each lRozaSaldo As CONTROL_ROZA_SALDO In lstControlRozaSaldo
        '            If lRozaSaldo.FECHA_HORA_ROZA <= mEntidad.FECHA_HORA_ROZA AndAlso lRozaSaldo.SALDO > 0 Then
        '                'Crear movimiento de liquidación de Saldo
        '                Dim lLiquidaProyeccion As New CONTROL_ROZA
        '                lLiquidaProyeccion.ID_CONTROL_ROZA = 0
        '                lLiquidaProyeccion.ID_ZAFRA = Me.cbxZAFRA.Value
        '                lLiquidaProyeccion.ACCESLOTE = Me.ACCESLOTE
        '                lLiquidaProyeccion.DIAZAFRA = 0
        '                lLiquidaProyeccion.FECHA_HORA_QUEMA = lRozaSaldo.FECHA_HORA_QUEMA
        '                lLiquidaProyeccion.FECHA_HORA_ROZA = lRozaSaldo.FECHA_HORA_ROZA
        '                lLiquidaProyeccion.CONCEPTO = "MOVIMIENTO AUTOMATICO DE LIQUIDACION DE SALDO PROYECTADO " + cFechaHora.ObtenerFechaHora.ToString("dd/MM/yyyy HH:mm")
        '                lLiquidaProyeccion.CODIGO_REF = "AJUSTE"
        '                lLiquidaProyeccion.ID_REF = -1
        '                lLiquidaProyeccion.ENTRADAS = 0
        '                lLiquidaProyeccion.SALIDAS = lRozaSaldo.SALDO
        '                lLiquidaProyeccion.SALDO = 0
        '                lLiquidaProyeccion.ID_PROVEEDOR_ROZA = lRozaSaldo.ID_PROVEEDOR_ROZA
        '                lLiquidaProyeccion.ID_TIPO_CANA = lRozaSaldo.ID_TIPO_CANA
        '                lLiquidaProyeccion.ID_TIPO_ROZA = lRozaSaldo.ID_TIPO_ROZA
        '                lLiquidaProyeccion.QUEMA_PROGRAMADA = lRozaSaldo.QUEMA_PROGRAMADA
        '                lLiquidaProyeccion.QUEMA_NOPROG = lRozaSaldo.QUEMA_NOPROG
        '                lLiquidaProyeccion.CANA_VERDE = lRozaSaldo.CANA_VERDE
        '                lLiquidaProyeccion.USUARIO_CREA = Me.ObtenerUsuario
        '                lLiquidaProyeccion.FECHA_CREA = cFechaHora.ObtenerFechaHora
        '                lLiquidaProyeccion.USUARIO_ACT = Me.ObtenerUsuario
        '                lLiquidaProyeccion.FECHA_ACT = cFechaHora.ObtenerFechaHora
        '                lLiquidaProyeccion.ID_REF = -1
        '                lLiquidaProyeccion.ES_PROYECCION = lRozaSaldo.ES_PROYECCION
        '                lLiquidaProyeccion.ID_ROZA_SALDO = lRozaSaldo.ID_ROZA_SALDO
        '                mComponente.ActualizarCONTROL_ROZA(lLiquidaProyeccion)
        '            End If
        '        Next
        '    End If
        'End If

        If mComponente.ActualizarCONTROL_ROZA(mEntidad) <> 1 Then
            Return "Error al actualizar Control de Roza: " + mComponente.sError
        End If

        'Actualizar inventario de quema   
        If lQuemaDisponible IsNot Nothing Then
            If montoRoza > 0 Then
                Dim lControlQuema As New CONTROL_QUEMA
                lControlQuema.ID_CONTROL_QUEMA = 0
                lControlQuema.ID_ZAFRA = cbxZAFRA.Value
                lControlQuema.ACCESLOTE = Me.ACCESLOTE
                lControlQuema.CONCEPTO = "ROZA EJECUTADA DEL " + mEntidad.FECHA_HORA_ROZA.ToString("dd/MM/yyyy HH:mm")
                lControlQuema.CODIGO_REF = "ROZADIA"
                lControlQuema.ID_REF = mEntidad.ID_CONTROL_ROZA
                lControlQuema.ENTRADAS = 0
                lControlQuema.SALIDAS = montoRoza
                lControlQuema.SALDO = lQuemaDisponible.SALDO - montoRoza
                lControlQuema.QUEMA_PROGRAMADA = lQuemaDisponible.QUEMA_PROGRAMADA
                lControlQuema.QUEMA_NOPROG = lQuemaDisponible.QUEMA_NOPROG
                lControlQuema.CANA_VERDE = lQuemaDisponible.CANA_VERDE
                lControlQuema.FECHA_HORA_QUEMA = Me.dteFECHA_HORA_ROZA.Date
                lControlQuema.USUARIO_CREA = Me.ObtenerUsuario
                lControlQuema.FECHA_CREA = cFechaHora.ObtenerFechaHora
                lControlQuema.USUARIO_ACT = Me.ObtenerUsuario
                lControlQuema.FECHA_ACT = cFechaHora.ObtenerFechaHora
                lControlQuema.ID_CONTROL_QUEMA_REF = -1
                lControlQuema.ES_PROYECCION = lQuemaDisponible.ES_PROYECCION
                lControlQuema.ID_QUEMA_SALDO = lQuemaDisponible.ID_QUEMA_SALDO
                lControlQuema.ID_SUBLOTES = lQuemaDisponible.ID_SUBLOTES
                If bLoteControlQuema.ActualizarCONTROL_QUEMA(lControlQuema) <= 0 Then
                    Return "Error al actualizar Control de Quema: " + mComponente.sError
                End If
                montoRoza = 0
            End If
        End If

        'Dim lControlQuema As New CONTROL_QUEMA
        'For i As Int32 = 0 To inventarioQuema.Count - 1
        '    If montoRoza > 0 Then
        '        If inventarioQuema(i).SALDO - montoRoza >= 0 Then
        '            lControlQuema = New CONTROL_QUEMA
        '            lControlQuema.ID_CONTROL_QUEMA = 0
        '            lControlQuema.ID_ZAFRA = cbxZAFRA.Value
        '            lControlQuema.ACCESLOTE = Me.ACCESLOTE
        '            lControlQuema.CONCEPTO = "ROZA EJECUTADA DEL " + mEntidad.FECHA_HORA_ROZA.ToString("dd/MM/yyyy HH:mm")
        '            lControlQuema.CODIGO_REF = "ROZADIA"
        '            lControlQuema.ID_REF = -1
        '            lControlQuema.ENTRADAS = 0
        '            lControlQuema.SALIDAS = montoRoza
        '            lControlQuema.SALDO = 0
        '            lControlQuema.QUEMA_PROGRAMADA = inventarioQuema(i).QUEMA_PROGRAMADA
        '            lControlQuema.QUEMA_NOPROG = inventarioQuema(i).QUEMA_NOPROG
        '            lControlQuema.CANA_VERDE = inventarioQuema(i).CANA_VERDE
        '            lControlQuema.FECHA_HORA_QUEMA = Me.dteFECHA_HORA_ROZA.Date
        '            lControlQuema.USUARIO_CREA = Me.ObtenerUsuario
        '            lControlQuema.FECHA_CREA = cFechaHora.ObtenerFechaHora
        '            lControlQuema.USUARIO_ACT = Me.ObtenerUsuario
        '            lControlQuema.FECHA_ACT = cFechaHora.ObtenerFechaHora
        '            lControlQuema.ID_CONTROL_QUEMA_REF = -1
        '            lControlQuema.ES_PROYECCION = inventarioQuema(i).ES_PROYECCION
        '            lControlQuema.ID_QUEMA_SALDO = inventarioQuema(i).ID_QUEMA_SALDO
        '            If bLoteControlQuema.ActualizarCONTROL_QUEMA(lControlQuema) <> 1 Then
        '                Return "Error al actualizar Control de Quema: " + mComponente.sError
        '            End If
        '            montoRoza = 0
        '            Exit For
        '        Else
        '            lControlQuema = New CONTROL_QUEMA
        '            lControlQuema.ID_CONTROL_QUEMA = 0
        '            lControlQuema.ID_ZAFRA = cbxZAFRA.Value
        '            lControlQuema.ACCESLOTE = Me.ACCESLOTE
        '            lControlQuema.CONCEPTO = "ROZA EJECUTADA DEL " + mEntidad.FECHA_HORA_ROZA.ToString("dd/MM/yyyy HH:mm")
        '            lControlQuema.CODIGO_REF = "ROZADIA"
        '            lControlQuema.ID_REF = -1
        '            lControlQuema.ENTRADAS = 0
        '            lControlQuema.SALIDAS = inventarioQuema(i).SALDO
        '            lControlQuema.SALDO = 0
        '            lControlQuema.QUEMA_PROGRAMADA = inventarioQuema(i).QUEMA_PROGRAMADA
        '            lControlQuema.QUEMA_NOPROG = inventarioQuema(i).QUEMA_NOPROG
        '            lControlQuema.CANA_VERDE = inventarioQuema(i).CANA_VERDE
        '            lControlQuema.FECHA_HORA_QUEMA = Me.dteFECHA_HORA_ROZA.Date
        '            lControlQuema.USUARIO_CREA = Me.ObtenerUsuario
        '            lControlQuema.FECHA_CREA = cFechaHora.ObtenerFechaHora
        '            lControlQuema.USUARIO_ACT = Me.ObtenerUsuario
        '            lControlQuema.FECHA_ACT = cFechaHora.ObtenerFechaHora
        '            lControlQuema.ID_CONTROL_QUEMA_REF = -1
        '            lControlQuema.ES_PROYECCION = inventarioQuema(i).ES_PROYECCION
        '            lControlQuema.ID_QUEMA_SALDO = inventarioQuema(i).ID_QUEMA_SALDO
        '            If bLoteControlQuema.ActualizarCONTROL_QUEMA(lControlQuema) <> 1 Then
        '                Return "Error al actualizar Control de Quema: " + mComponente.sError
        '            End If
        '            montoRoza -= inventarioQuema(i).SALDO
        '        End If
        '    Else
        '        Exit For
        '    End If
        'Next

        If bLoteCosecha.ActualizarLOTES_COSECHA(lLoteCosecha) < 1 Then
            Return "Error al actualizar el Saldo del Lote para esta Zafra: " + bLoteCosecha.sError
        End If
        Me.cbxQuemaDisponible.Value = Nothing
        Me.txtENTRADAS.Value = Nothing
        Me.dteFECHA_HORA_ROZA.Value = Nothing
        Me.cbxID_TIPO_ROZA.Value = Nothing
        Me.CargarTipoRoza()
        Me.CargarProveedorRoza()
        Me.cbxID_PROVEEDOR_ROZA.Value = Nothing
        'Me.chkQuerqueo.Checked = False

        lLoteCosecha = (New cLOTES_COSECHA).ObtenerLOTES_COSECHAPorLOTE_ZAFRA(Me.ACCESLOTE, Me.cbxZAFRA.Value)
        Me.txtSALDO_ROZA.Value = lLoteCosecha.SALDO_ROZA
        Me.txtSALDO_QUEMA.Value = lLoteCosecha.SALDO_QUEMA
        Me.txtESTICANA.Value = lLoteCosecha.TONEL_CENSO

        Dim dRozaEjecutada As Decimal = _
                (New cCONTROL_ROZA).ObtenerRozaEjecutadaPorZAFRA_LOTE(lLoteCosecha.ID_ZAFRA, lLoteCosecha.ACCESLOTE)

        Me.txtROZA_EJECUTADA.Value = dRozaEjecutada
        Me.txtDIF_ESTICANA_ROZA.Value = lLoteCosecha.TONEL_CENSO - dRozaEjecutada
        Me.SetSaldoPorTipoQuema(lLoteCosecha.ID_ZAFRA, lLoteCosecha.ACCESLOTE)
        'Me.CargarQuemaDisponible(Me.cbxZAFRA.Value, Me.ACCESLOTE)
        Me.ucListaCONTROL_ROZA_SALDO1.QuitarSeleccion()
        Me.ucListaCONTROL_ROZA_SALDO1.DataBind()
        Me.ucListaCONTROL_ROZA1.DataBind()
        AsignarMensaje("La Roza ejecutada se registro con exito. Se ha actualizado el Saldo de Roza", False, True, True)

        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function

    Protected Sub cbxID_TIPO_ROZA_ValueChanged(sender As Object, e As System.EventArgs) Handles cbxID_TIPO_ROZA.ValueChanged
        Me.CargarProveedorRoza()
    End Sub

    Protected Sub cbxID_TIPO_CANA_ValueChanged(sender As Object, e As System.EventArgs) Handles cbxID_TIPO_CANA.ValueChanged
        Me.CargarTipoRoza()
        Me.CargarProveedorRoza()
    End Sub

    Protected Sub cpINVENTARIO_ROZA_Callback(sender As Object, e As DevExpress.Web.CallbackEventArgsBase) Handles cpINVENTARIO_ROZA.Callback
        If e.Parameter = "SeleccionRoza" Then
            Dim lista As listaCONTROL_ROZA_SALDO = Me.ucListaCONTROL_ROZA_SALDO1.DevolverSeleccionados
            If lista IsNot Nothing AndAlso lista.Count > 0 Then
                Me.ucListaCONTROL_ROZA1.CargarDatosPorCONTROL_SALDO_ROZA(lista(0).ID_ROZA_SALDO, "ID_CONTROL_ROZA", "DESC")
            End If
        End If
    End Sub

    Private Sub SetSaldoPorTipoQuema(ByVal ID_ZAFRA As Int32, ByVal ACCESLOTE As String)
        Dim lTipoQuema As Dictionary(Of String, Decimal)
        Dim lLoteCosecha As LOTES_COSECHA = (New cLOTES_COSECHA).ObtenerLOTES_COSECHAPorLOTE_ZAFRA(ACCESLOTE, ID_ZAFRA)

        lTipoQuema = (New cCONTROL_QUEMA).ObtenerSaldoTipoQuemaPorZAFRA_LOTE(ID_ZAFRA, ACCESLOTE)
        If lTipoQuema IsNot Nothing AndAlso lTipoQuema.Count > 0 Then
            Me.txtQUEMA_QUEMA_PROGRAMADA.Value = lTipoQuema("QUEMA_PROGRAMADA")
            Me.txtQUEMA_QUEMA_NOPROG.Value = lTipoQuema("QUEMA_NOPROG")
            Me.txtQUEMA_CANA_VERDE.Value = lTipoQuema("CANA_VERDE")
            Me.txtSALDO_QUEMA.Value = lTipoQuema("QUEMA_PROGRAMADA") + lTipoQuema("QUEMA_NOPROG") + lTipoQuema("CANA_VERDE")
        End If

        lTipoQuema = (New cCONTROL_ROZA).ObtenerSaldoRozaPorTipoQuemaPorZAFRA_LOTE(ID_ZAFRA, ACCESLOTE)
        If lTipoQuema IsNot Nothing AndAlso lTipoQuema.Count > 0 Then
            Me.txtSALDO_QUEMA_PROGRAMADA.Value = lTipoQuema("QUEMA_PROGRAMADA")
            Me.txtSALDO_QUEMA_NOPROG.Value = lTipoQuema("QUEMA_NOPROG")
            Me.txtCANA_VERDE.Value = lTipoQuema("CANA_VERDE")
            Me.txtSALDO_ROZA.Value = lTipoQuema("QUEMA_PROGRAMADA") + lTipoQuema("QUEMA_NOPROG") + lTipoQuema("CANA_VERDE")
        End If

        If lLoteCosecha IsNot Nothing Then
            Me.txtESTICANA.Value = lLoteCosecha.TONEL_CENSO
            Me.txtROZA_EJECUTADA.Value = (New cCONTROL_ROZA).ObtenerRozaEjecutadaPorZAFRA_LOTE(ID_ZAFRA, ACCESLOTE)
            Me.txtDIF_ESTICANA_ROZA.Value = lLoteCosecha.TONEL_CENSO - (New cCONTROL_ROZA).ObtenerRozaEjecutadaPorZAFRA_LOTE(ID_ZAFRA, ACCESLOTE)
        End If
    End Sub


    Private Sub cbxSUBLOTES_ValueChanged(sender As Object, e As EventArgs) Handles cbxSUBLOTES.ValueChanged
        Dim idSublotes As Integer = -1
        If cbxSUBLOTES.Value IsNot Nothing Then
            idSublotes = Convert.ToInt32(cbxSUBLOTES.Value)
            Me.CargarQuemaDisponible(Me.cbxZAFRA.Value, Me.ACCESLOTE, idSublotes)
        End If
    End Sub

End Class
