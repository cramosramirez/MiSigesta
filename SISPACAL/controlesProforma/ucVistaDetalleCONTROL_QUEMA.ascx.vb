Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores
Imports DevExpress.Web

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetalleCONTROL_QUEMA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla CONTROL_QUEMA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	20/01/2015	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleCONTROL_QUEMA
    Inherits ucBase

#Region "Propiedades"

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

    Private _ID_CONTROL_QUEMA As Int32
    Public Property ID_CONTROL_QUEMA() As Int32
        Get
            Return 0
        End Get
        Set(ByVal Value As Int32)
            Me._ID_CONTROL_QUEMA = Value
            Me.txtID_CONTROL_QUEMA.Text = CStr(Value)
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
    Private mComponente As New cCONTROL_QUEMA
    Private mEntidad As CONTROL_QUEMA

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
    End Sub


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla CONTROL_QUEMA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/01/2015	Created
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
            Me.ucListaCONTROL_QUEMA1.CargarDatosPorZAFRA_LOTE(Me.cbxZAFRA.Value, moduloEntidad.ACCESLOTE)
        End If

        Me.rblTIPO_QUEMA.Value = Nothing

        Dim lLoteCosecha As LOTES_COSECHA = (New cLOTES_COSECHA).ObtenerLOTES_COSECHAPorLOTE_ZAFRA(moduloEntidad.ACCESLOTE, moduloEntidad.ID_ZAFRA)
        If lLoteCosecha IsNot Nothing Then
            Dim lTecnico As AGRONOMO = (New cAGRONOMO).ObtenerAGRONOMO(lLoteCosecha.CODIAGRON)

            If lTecnico IsNot Nothing Then Me.txtTECNICO_ZONA.Text = lTecnico.NOMBRE_AGRONOMO + " " + lTecnico.APELLIDO_AGRONOMO
            Me.txtSALDO_QUEMA.Value = lLoteCosecha.SALDO_QUEMA
            Me.trHORAS_QUEMA.Visible = True
            Me.SetSaldoPorTipoQuema(lLoteCosecha.ID_ZAFRA, lLoteCosecha.ACCESLOTE)
        Else
            Me.txtSALDO_QUEMA.Value = 0
            Me.trHORAS_QUEMA.Visible = False
        End If
        Me.CargarSubLotes()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/01/2015	Created
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
        Me.txtENTRADAS.ClientEnabled = edicion
        Me.txtSALDO_QUEMA.ClientEnabled = False
        Me.txtHORAS_QUEMA_PROG.ClientEnabled = False
        Me.txtHORAS_QUEMA_NOPROG.ClientEnabled = False
        Me.dteFECHA_HORA_QUEMA.ClientEnabled = edicion
        Me.rblTIPO_QUEMA.ClientEnabled = edicion
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
    End Sub


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/01/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.txtCODIPROVEE.Text = ""
        Me.txtCODISOCIO.Text = ""
        Me.dteFECHA_HORA_QUEMA.Value = Nothing
        Me.txtNOMBRE_PROVEEDOR.Text = ""
        Me.txtCODILOTE.Text = ""
        Me.txtNOMLOTE.Text = ""
        Me.txtVARIEDAD.Text = ""
        Me.txtENTRADAS.Value = Nothing
        Me.txtSALDO_QUEMA.Value = Nothing
        Me.txtHORAS_QUEMA_PROG.Text = "00:00"
        Me.txtHORAS_QUEMA_NOPROG.Text = "00:00"
        Me.txtTECNICO_ZONA.Text = ""
        Me.chkES_PROYECCION.Checked = False
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        If lZafra IsNot Nothing Then
            Me.cbxZAFRA.Value = lZafra.ID_ZAFRA
        End If
        Me.ucListaCONTROL_QUEMA1.CargarDatosPorZAFRA_LOTE(-2, "*")
        Me.CargarSubLotes()
    End Sub

    Private Sub CargarSubLotes()
        Dim lista As listaSUBLOTES = (New cSUBLOTES).ObtenerListaPorLOTES_COSECHA(Me.ID_LOTES_COSECHA)
        If lista Is Nothing Then lista = New listaSUBLOTES
        cbxSUBLOTES.DataSource = lista
        cbxSUBLOTES.DataBind()
        cbxSUBLOTES.SelectedIndex = -1
    End Sub

    Public Function LiquidarSaldoQuema(Optional LIQUIDAR_COMO_PROYECCION As Boolean = False) As String
        Dim bControlQuema As New cCONTROL_QUEMA
        Dim lControlQuema As New CONTROL_QUEMA
        Dim bLoteCosecha As New cLOTES_COSECHA
        Dim listaSaldoQuema As listaCONTROL_QUEMA_SALDO
        Dim lLoteCosecha As LOTES_COSECHA = (New cLOTES_COSECHA).ObtenerLOTES_COSECHAPorLOTE_ZAFRA(Me.ACCESLOTE, cbxZAFRA.Value)

        If lLoteCosecha IsNot Nothing Then
            listaSaldoQuema = (New cCONTROL_QUEMA_SALDO).ObtenerListaPorCriterios(lLoteCosecha.ID_ZAFRA, lLoteCosecha.ACCESLOTE, Nothing, -1, -1, -1, LIQUIDAR_COMO_PROYECCION, True)
            If listaSaldoQuema IsNot Nothing AndAlso listaSaldoQuema.Count > 0 Then
                For Each lQuemaSaldo As CONTROL_QUEMA_SALDO In listaSaldoQuema
                    If lQuemaSaldo.SALDO > 0 Then
                        lControlQuema = New CONTROL_QUEMA

                        lControlQuema.ID_CONTROL_QUEMA = 0
                        lControlQuema.ID_ZAFRA = cbxZAFRA.Value
                        lControlQuema.ACCESLOTE = Me.ACCESLOTE
                        lControlQuema.CONCEPTO = "MOVIMIENTO DE LIQUIDACION DE SALDO " + cFechaHora.ObtenerFechaHora.ToString("dd/MM/yyyy HH:mm")
                        lControlQuema.CODIGO_REF = "AJUSTE"
                        lControlQuema.ID_REF = -1
                        lControlQuema.ENTRADAS = 0
                        lControlQuema.SALIDAS = lQuemaSaldo.SALDO
                        lControlQuema.SALDO = 0
                        lControlQuema.QUEMA_PROGRAMADA = lQuemaSaldo.QUEMA_PROGRAMADA
                        lControlQuema.QUEMA_NOPROG = lQuemaSaldo.QUEMA_NOPROG
                        lControlQuema.CANA_VERDE = lQuemaSaldo.CANA_VERDE
                        lControlQuema.FECHA_HORA_QUEMA = lQuemaSaldo.FECHA_HORA_QUEMA
                        lControlQuema.USUARIO_CREA = Me.ObtenerUsuario
                        lControlQuema.FECHA_CREA = cFechaHora.ObtenerFechaHora
                        lControlQuema.USUARIO_ACT = Me.ObtenerUsuario
                        lControlQuema.FECHA_ACT = cFechaHora.ObtenerFechaHora
                        lControlQuema.ID_CONTROL_QUEMA_REF = -1
                        lControlQuema.ES_PROYECCION = LIQUIDAR_COMO_PROYECCION
                        lControlQuema.ID_QUEMA_SALDO = lQuemaSaldo.ID_QUEMA_SALDO
                        lControlQuema.ID_SUBLOTES = lQuemaSaldo.ID_SUBLOTES
                        If bControlQuema.ActualizarCONTROL_QUEMA(lControlQuema) < 1 Then
                            Return "* Error al actualizar Control de Quema: " + mComponente.sError
                        End If
                    End If
                Next
            Else
                Return "* El inventario de Quema no posee saldo " + If(LIQUIDAR_COMO_PROYECCION, "proyectado", "")
            End If
            
            lLoteCosecha.USUARIO_ACT = Me.ObtenerUsuario
            lLoteCosecha.FECHA_ACT = cFechaHora.ObtenerFechaHora
            If bLoteCosecha.ActualizarLOTES_COSECHA(lLoteCosecha) < 1 Then
                Return "Error al actualizar el Saldo del Lote para esta Zafra: " + bLoteCosecha.sError
            End If
            Me.SetSaldoPorTipoQuema(lLoteCosecha.ID_ZAFRA, lLoteCosecha.ACCESLOTE)
        End If
        Me.ucListaCONTROL_QUEMA1.DataBind()
        AsignarMensaje("El Saldo de Quema se liquido con exito", False, True, True)
        Return ""
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla CONTROL_QUEMA
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/01/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim bLoteCosecha As New cLOTES_COSECHA
        Dim lLoteCosecha As LOTES_COSECHA
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        Dim fechaHoraUltiMovQuema As DateTime
        mEntidad = New CONTROL_QUEMA

        If Me.cbxZAFRA.Value Is Nothing Then
            Return "* No se ha especificado la Zafra"
        End If
        If Me.txtENTRADAS.Value Is Nothing OrElse Me.txtENTRADAS.Value = 0 Then
            Return "* Asigne un valor a Cantidad Quemada (TC)"
        End If
        If Me.dteFECHA_HORA_QUEMA.Value Is Nothing Then
            Return "* Ingrese la fecha y hora de quema"
        End If

        If Me.TIPO_INGRESO = TipoIngresoQuemaRoza.Ejecutada Then
            If Me.dteFECHA_HORA_QUEMA.Date > cFechaHora.ObtenerFechaHora Then
                Return "* Fecha de quema no puede ser mayor a la fecha actual"
            End If
        Else
            If Me.dteFECHA_HORA_QUEMA.Date <= cFechaHora.ObtenerFechaHora Then
                Return "* Fecha de quema no puede ser menor a la fecha actual debido a que es una proyeccion"
            End If
        End If

        If DateDiff(DateInterval.Day, Me.dteFECHA_HORA_QUEMA.Date, cFechaHora.ObtenerFechaHora) > 7 Then
            Return "* Fecha de quema no puede ser menor a 7 dias"
        End If
        If rblTIPO_QUEMA.Value Is Nothing Then
            Return "* Seleccione el tipo de quema"
        End If
        If Me.cbxSUBLOTES.Value Is Nothing Then
            Return "* Seleccione una porción"
        End If
        fechaHoraUltiMovQuema = (New cCONTROL_QUEMA).ObtenerULTIMA_FECHA_ROZA_DISPO_MOVTO(Me.cbxZAFRA.Value, Me.ACCESLOTE)
        'If fechaHoraUltiMovQuema <> #12:00:00 AM# AndAlso fechaHoraUltiMovQuema > Me.dteFECHA_HORA_QUEMA.Date Then
        '    Return "* Fecha/hora de quema no puede ser menor a la fecha del último movimiento"
        'End If

        lLoteCosecha = (New cLOTES_COSECHA).ObtenerLOTES_COSECHAPorLOTE_ZAFRA(Me.ACCESLOTE, Me.cbxZAFRA.Value)

        mEntidad.ID_CONTROL_QUEMA = 0
        mEntidad.ID_ZAFRA = Me.cbxZAFRA.Value
        mEntidad.ACCESLOTE = Me.ACCESLOTE
        mEntidad.FECHA_HORA_QUEMA = Me.dteFECHA_HORA_QUEMA.Date
        mEntidad.CONCEPTO = If(Me.TIPO_INGRESO = TipoIngresoQuemaRoza.Ejecutada, "QUEMA DEL DIA", "QUEMA PROYECTADA")
        mEntidad.CODIGO_REF = If(Me.TIPO_INGRESO = TipoIngresoQuemaRoza.Ejecutada, "QUEMADIA", "PROYECCION")
        mEntidad.ID_REF = -1
        mEntidad.ENTRADAS = Me.txtENTRADAS.Value
        mEntidad.SALIDAS = 0
        If lLoteCosecha IsNot Nothing Then
            mEntidad.SALDO = lLoteCosecha.SALDO_QUEMA + mEntidad.ENTRADAS
            lLoteCosecha.SALDO_QUEMA = lLoteCosecha.SALDO_QUEMA + mEntidad.ENTRADAS
            'Determinar la fecha de roza dispo
        Else
            mEntidad.SALDO = mEntidad.ENTRADAS
        End If
        Select Case Me.rblTIPO_QUEMA.Value
            Case 1
                mEntidad.QUEMA_PROGRAMADA = True
                mEntidad.QUEMA_NOPROG = False
                mEntidad.CANA_VERDE = False
            Case 2
                mEntidad.QUEMA_PROGRAMADA = False
                mEntidad.QUEMA_NOPROG = True
                mEntidad.CANA_VERDE = False
            Case 3
                mEntidad.QUEMA_PROGRAMADA = False
                mEntidad.QUEMA_NOPROG = False
                mEntidad.CANA_VERDE = True
        End Select
        mEntidad.USUARIO_CREA = Me.ObtenerUsuario
        mEntidad.FECHA_CREA = cFechaHora.ObtenerFechaHora
        mEntidad.USUARIO_ACT = Me.ObtenerUsuario
        mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
        mEntidad.ID_CONTROL_QUEMA_REF = -1
        mEntidad.ES_PROYECCION = Me.chkES_PROYECCION.Checked
        mEntidad.ID_SUBLOTES = Me.cbxSUBLOTES.Value

        'If Me.TIPO_INGRESO = TipoIngresoQuemaRoza.Ejecutada Then
        '    'Liquidar el saldo proyectado con fecha menor o igual a la fecha del movimiento de quema
        '    Dim lstControlQuemaSaldo As listaCONTROL_QUEMA_SALDO = (New cCONTROL_QUEMA_SALDO).ObtenerListaPorCriterios(mEntidad.ID_ZAFRA, mEntidad.ACCESLOTE, -1, -1, -1, 1, True)
        '    If lstControlQuemaSaldo IsNot Nothing AndAlso lstControlQuemaSaldo.Count > 0 Then
        '        For Each lQuemaSaldo As CONTROL_QUEMA_SALDO In lstControlQuemaSaldo
        '            If lQuemaSaldo.FECHA_HORA_QUEMA <= mEntidad.FECHA_HORA_QUEMA AndAlso lQuemaSaldo.SALDO > 0 Then
        '                'Crear movimiento de liquidación de Saldo
        '                Dim lLiquidaProyeccion As New CONTROL_QUEMA
        '                lLiquidaProyeccion.ID_CONTROL_QUEMA = 0
        '                lLiquidaProyeccion.ID_ZAFRA = Me.cbxZAFRA.Value
        '                lLiquidaProyeccion.ACCESLOTE = Me.ACCESLOTE
        '                lLiquidaProyeccion.FECHA_HORA_QUEMA = lQuemaSaldo.FECHA_HORA_QUEMA
        '                lLiquidaProyeccion.CONCEPTO = "MOVIMIENTO AUTOMATICO DE LIQUIDACION DE SALDO PROYECTADO " + cFechaHora.ObtenerFechaHora.ToString("dd/MM/yyyy HH:mm")
        '                lLiquidaProyeccion.CODIGO_REF = "AJUSTE"
        '                lLiquidaProyeccion.ID_REF = -1
        '                lLiquidaProyeccion.ENTRADAS = 0
        '                lLiquidaProyeccion.SALIDAS = lQuemaSaldo.SALDO
        '                lLiquidaProyeccion.SALDO = 0
        '                lLiquidaProyeccion.QUEMA_PROGRAMADA = lQuemaSaldo.QUEMA_PROGRAMADA
        '                lLiquidaProyeccion.QUEMA_NOPROG = lQuemaSaldo.QUEMA_NOPROG
        '                lLiquidaProyeccion.CANA_VERDE = lQuemaSaldo.CANA_VERDE
        '                lLiquidaProyeccion.USUARIO_CREA = Me.ObtenerUsuario
        '                lLiquidaProyeccion.FECHA_CREA = cFechaHora.ObtenerFechaHora
        '                lLiquidaProyeccion.USUARIO_ACT = Me.ObtenerUsuario
        '                lLiquidaProyeccion.FECHA_ACT = cFechaHora.ObtenerFechaHora
        '                lLiquidaProyeccion.ID_CONTROL_QUEMA_REF = -1
        '                lLiquidaProyeccion.ES_PROYECCION = lQuemaSaldo.ES_PROYECCION
        '                lLiquidaProyeccion.ID_QUEMA_SALDO = lQuemaSaldo.ID_QUEMA_SALDO
        '                mComponente.ActualizarCONTROL_QUEMA(lLiquidaProyeccion)
        '            End If
        '        Next
        '    End If
        'End If
        If mComponente.ActualizarCONTROL_QUEMA(mEntidad) < 1 Then
            Return "Error al actualizar Control de Quema: " + mComponente.sError
        End If
        If bLoteCosecha.ActualizarLOTES_COSECHA(lLoteCosecha) < 1 Then
            Return "Error al actualizar el Saldo del Lote para esta Zafra: " + bLoteCosecha.sError
        End If
        Me.txtENTRADAS.Value = Nothing
        Me.dteFECHA_HORA_QUEMA.Value = Nothing
        Me.txtSALDO_QUEMA.Value = lLoteCosecha.SALDO_QUEMA
        Me.rblTIPO_QUEMA.Value = Nothing
        Me.ucListaCONTROL_QUEMA1.DataBind()
        Me.SetSaldoPorTipoQuema(lLoteCosecha.ID_ZAFRA, lLoteCosecha.ACCESLOTE)
        AsignarMensaje("La Quema/Cosecha se registro con exito. Se ha actualizado el Saldo de Quema/Cosecha", False, True, True)

        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function

    Private Sub SetSaldoPorTipoQuema(ByVal ID_ZAFRA As Int32, ByVal ACCESLOTE As String)
        Dim lTipoQuema As Dictionary(Of String, Decimal)
        Dim lHorasQuema As Dictionary(Of String, Int32)
        Dim horas As Int32 = 0
        Dim minutos As Int32 = 0

        lTipoQuema = mComponente.ObtenerSaldoTipoQuemaPorZAFRA_LOTE(ID_ZAFRA, ACCESLOTE)
        If lTipoQuema IsNot Nothing AndAlso lTipoQuema.Count > 0 Then
            Me.txtSALDO_QUEMA_PROGRAMADA.Value = lTipoQuema("QUEMA_PROGRAMADA")
            Me.txtSALDO_QUEMA_NOPROG.Value = lTipoQuema("QUEMA_NOPROG")
            Me.txtCANA_VERDE.Value = lTipoQuema("CANA_VERDE")
        End If

        lHorasQuema = mComponente.ObtenerHorasQuemaTranscurridas(ID_ZAFRA, ACCESLOTE)
        If lHorasQuema IsNot Nothing AndAlso lHorasQuema.Count > 0 Then
            Me.txtHORAS_QUEMA_PROG.Text = lHorasQuema("QP").ToString
            Me.txtHORAS_QUEMA_NOPROG.Text = lHorasQuema("QNP").ToString
            If lHorasQuema("QP") = 0 AndAlso lHorasQuema("QNP") = 0 Then Me.trHORAS_QUEMA.Visible = False Else Me.trHORAS_QUEMA.Visible = True
        Else
            Me.trHORAS_QUEMA.Visible = False
        End If
    End Sub

    Private Sub ConfigPorTipoCana(ByVal ID_TIPO_CANA As Int32)
        Select Case ID_TIPO_CANA
            Case Enumeradores.CAT.TipoCana.PicadaMecanizada
                Me.rblTIPO_QUEMA.ClientEnabled = False
                Me.rblTIPO_QUEMA.Value = 3
                Dim item As LayoutItem = Me.ASPxFormLayout1.FindItemOrGroupByName("lyiDescripCosecha")
                If item IsNot Nothing Then
                    item.Caption = "Cuota de Cosecha (TC)"
                End If

            Case Else
                Me.rblTIPO_QUEMA.ClientEnabled = True
                Me.rblTIPO_QUEMA.Value = Nothing
                Dim item As LayoutItem = Me.ASPxFormLayout1.FindItemOrGroupByName("lyiDescripCosecha")
                If item IsNot Nothing Then
                    item.Caption = "Cantidad Quemada (TC)"
                End If
        End Select
    End Sub
End Class
