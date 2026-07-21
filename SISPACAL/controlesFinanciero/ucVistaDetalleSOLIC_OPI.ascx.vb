Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetalleSOLIC_OPI
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla SOLIC_OPI
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	28/06/2015	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleSOLIC_OPI
    Inherits ucBase

#Region "Propiedades"

    Private _ID_OPI As Int32
    Public Property ID_OPI() As Int32
        Get
            If Me.ViewState("ID_OPI") IsNot Nothing Then
                Return CInt(Me.ViewState("ID_OPI"))
            Else
                Return -1
            End If
        End Get
        Set(ByVal Value As Int32)
            Me.ViewState("ID_OPI") = Value
            Me.lblREFERENCIA_LOTES.Text = Guid.NewGuid.ToString
            If Me.ViewState("ID_OPI") > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property LISTA_SOLIC_OIP_LOTE As listaSOLIC_OIP_LOTE
        Set(value As listaSOLIC_OIP_LOTE)
            Dim i As Int32 = 1
            If value IsNot Nothing Then
                For Each lEntidad As SOLIC_OIP_LOTE In value
                    If lEntidad.ID_SOLI_LOTE = 0 Then
                        lEntidad.ID_SOLI_LOTE = i
                        i += 1
                    End If
                    lEntidad.REFERENCIA = Me.lblREFERENCIA_LOTES.Text
                Next
            Else
                value = New listaSOLIC_OIP_LOTE
            End If
            Session(Me.lblREFERENCIA_LOTES.Text) = value
        End Set
        Get
            If Session(Me.lblREFERENCIA_LOTES.Text) IsNot Nothing Then Return TryCast(Session(Me.lblREFERENCIA_LOTES.Text), listaSOLIC_OIP_LOTE) Else Return New listaSOLIC_OIP_LOTE
        End Get
    End Property

    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cSOLIC_OPI
    Private mEntidad As SOLIC_OPI
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
        If Not Me.ViewState("ID_OPI") Is Nothing Then Me._ID_OPI = Me.ViewState("ID_OPI")

    End Sub


    Public Sub CargarDetalleOIPLotes()
        If Me.lblREFERENCIA_LOTES.Text <> "" Then
            Me.ucListaSOLIC_OIP_LOTE1.CargarDatosCache(Me.lblREFERENCIA_LOTES.Text)
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla SOLIC_OPI
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/06/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()
        Dim lProveedor As PROVEEDOR
        Dim listOPIContratos As listaSOLIC_OPI_CONTRATOS
        Dim listaContratos As New List(Of String)

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New SOLIC_OPI
        mEntidad.ID_OPI = ID_OPI

        If mComponente.ObtenerSOLIC_OPI(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        lProveedor = (New cPROVEEDOR).ObtenerPROVEEDOR(mEntidad.CODIPROVEEDOR)
        Me.txtID_OPI.Text = mEntidad.ID_OPI.ToString()
        Me.cbxZAFRA.Value = mEntidad.ID_ZAFRA
        Me.txtNUM_OPI_ZAFRA.Text = mEntidad.NUM_OPI_ZAFRA
        Me.txtCODIPROVEE.Text = Utilerias.RecuperarCODIPROVEE(mEntidad.CODIPROVEEDOR)
        If lProveedor IsNot Nothing Then
            Me.txtNOMBRE_PROVEEDOR.Text = lProveedor.NOMBRES + " " + lProveedor.APELLIDOS
        End If
        Me.dteFECHA_SOLIC.Date = mEntidad.FECHA
        Me.cbxCODIBANCO.Value = mEntidad.CODIBANCO
        Me.speMONTO.Value = mEntidad.MONTO
        Me.speINTERES.Value = mEntidad.INTERES
        Me.speIVA_INTERES.Value = mEntidad.IVA_INTERES
        Me.spePORC_DESCTO.Value = mEntidad.PORC_DESCTO
        Me.spePORC_DESCTO_PLA.Value = mEntidad.PORC_DESCTO_PLA
        Me.chkAceptada.Checked = mEntidad.ES_ACEPTADA
        Me.speNUM_OPI_PROVEE_ZAFRA.Value = mEntidad.NUM_OPI_PROVEE_ZAFRA
        Me.cbxESTADO.Value = mEntidad.ID_ESTADO
        Me.ObtenerContratos(lProveedor.CODIPROVEE)

        listOPIContratos = (New cSOLIC_OPI_CONTRATOS).ObtenerListaPorSOLIC_OPI(mEntidad.ID_OPI)
        If listOPIContratos IsNot Nothing AndAlso listOPIContratos.Count > 0 Then
            For i As Int32 = 0 To listOPIContratos.Count - 1
                listaContratos.Add(listOPIContratos(i).CODICONTRATO)
            Next
        End If
        Me.ucListaCONTRATO1.SeleccionarRegistros(listaContratos)

        Me.LISTA_SOLIC_OIP_LOTE = (New cSOLIC_OIP_LOTE).ObtenerListaPorSOLIC_OPI(ID_OPI)
        Me.CargarDetalleOIPLotes()
        Me.ucListaSOLIC_OIP_LOTE1.SeleccionarTodos()
    End Sub



    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/06/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.cbxZAFRA.ClientEnabled = Me._nuevo
        Me.txtCODIPROVEE.ClientEnabled = Me._nuevo
        Me.txtNOMBRE_PROVEEDOR.ClientEnabled = False
        Me.dteFECHA_SOLIC.ClientEnabled = Me._nuevo OrElse edicion
        Me.txtNUM_OPI_ZAFRA.ClientEnabled = False
        Me.cbxCODIBANCO.ClientEnabled = Me._nuevo OrElse edicion
        Me.speMONTO.ClientEnabled = Me._nuevo OrElse edicion
        Me.speINTERES.ClientEnabled = Me._nuevo OrElse edicion
        Me.speIVA_INTERES.ClientEnabled = Me._nuevo OrElse edicion
        Me.spePORC_DESCTO.ClientEnabled = Me._nuevo OrElse edicion
        Me.spePORC_DESCTO_PLA.ClientEnabled = Not Me._nuevo
        Me.speNUM_OPI_PROVEE_ZAFRA.ClientEnabled = Me._nuevo OrElse edicion
        Me.chkAceptada.ClientEnabled = False
        Me.cbxESTADO.ClientEnabled = False

        Me.ucListaSOLIC_OIP_LOTE1.MostrarCheckVariaSeleccion = edicion 'Me._nuevo AndAlso edicion
        Me.ucListaSOLIC_OIP_LOTE1.PermitirEditar = False 'Me._nuevo AndAlso edicion
        Me.ucListaSOLIC_OIP_LOTE1.PermitirEditarInline = False 'Me._nuevo AndAlso edicion
        If Me._nuevo Then Me.ucListaSOLIC_OIP_LOTE1.QuitarSelecciones()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/06/2015	Created
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
        Me.ObtenerContratos("-")
        Me.dteFECHA_SOLIC.Value = Nothing
        Me.txtNUM_OPI_ZAFRA.Text = ""
        Me.cbxCODIBANCO.Value = Nothing
        Me.speMONTO.Value = Nothing
        Me.speINTERES.Value = Nothing
        Me.speIVA_INTERES.Value = Nothing
        Me.spePORC_DESCTO.Value = Nothing
        Me.spePORC_DESCTO_PLA.Value = Nothing
        Me.speNUM_OPI_PROVEE_ZAFRA.Value = Nothing
        Me.chkAceptada.ClientEnabled = False
        Me.chkAceptada.Checked = False
        Me.cbxESTADO.Value = 1

        Me.chkSelectTodosLotes.ClientEnabled = True
        Me.chkSelectTodosLotes.Checked = False
        Me.CargarDetalleOIPLotes()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla SOLIC_OPI
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/06/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim bContratoProvision As New cCONTRATO_CTAS_PROVI
        Dim bSolicOIPLotes As New cSOLIC_OIP_LOTE
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        mEntidad = New SOLIC_OPI
        If Me._nuevo Then
            mEntidad.ID_OPI = 0
            mEntidad.NUM_OPI_ZAFRA = 0
            mEntidad.UID_OPI_CONTRATO = Guid.NewGuid
            mEntidad.USUARIO_CREA = Me.ObtenerUsuario
            mEntidad.FECHA_CREA = cFechaHora.ObtenerFechaHora
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
        Else
            mEntidad = (New cSOLIC_OPI).ObtenerSOLIC_OPI(CInt(Me.txtID_OPI.Text))
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
        End If
        If cbxZAFRA.Text = "" Then
            Return "Seleccione la zafra"
        End If
        If txtCODIPROVEE.Text = "" Then
            Return "Ingrese el codigo de proveedor"
        End If
        'If Me.ucListaCONTRATO1.DevolverSeleccionados.Count = 0 Then
        '    Return "No ha seleccionado ningún contrato"
        'End If
        If cbxCODIBANCO.Text = "" Then
            Return "Seleccione el Banco"
        End If
        If Me.spePORC_DESCTO.Value Is Nothing OrElse Me.spePORC_DESCTO.Value <= 0 Then
            Return "Ingrese el porcentaje a descontar sobre entregas"
        End If
        If Me.spePORC_DESCTO.Value Is Nothing OrElse Me.spePORC_DESCTO.Value > 100 Then
            Return "El porcentaje a descontar sobre entregas no puede ser mayor al 100%"
        End If
        If Me.speNUM_OPI_PROVEE_ZAFRA.Value Is Nothing OrElse Me.speNUM_OPI_PROVEE_ZAFRA.Value <= 0 Then
            Return "Ingrese el numero de orden de la OIP"
        End If
        mEntidad.ID_ZAFRA = cbxZAFRA.Value
        mEntidad.CODIPROVEEDOR = Utilerias.FormatearCODIPROVEEDOR(Me.txtCODIPROVEE.Value)
        mEntidad.FECHA = Me.dteFECHA_SOLIC.Value
        mEntidad.CODIBANCO = Me.cbxCODIBANCO.Value
        mEntidad.MONTO = Me.speMONTO.Value
        If speINTERES.Value = Nothing Then
            mEntidad.INTERES = 0
        Else
            mEntidad.INTERES = Convert.ToDecimal(speINTERES.Value)
        End If
        If speIVA_INTERES.Value = Nothing Then
            mEntidad.IVA_INTERES = 0
        Else
            mEntidad.IVA_INTERES = Convert.ToDecimal(speIVA_INTERES.Value)
        End If
        mEntidad.PORC_DESCTO = Me.spePORC_DESCTO.Value
        mEntidad.PORC_DESCTO_PLA = Me.spePORC_DESCTO_PLA.Value
        mEntidad.ZAFRA = Me.cbxZAFRA.Text
        mEntidad.NUM_OPI_PROVEE_ZAFRA = Me.speNUM_OPI_PROVEE_ZAFRA.Value
        mEntidad.ID_ESTADO = cbxESTADO.Value

        If mComponente.ActualizarSOLIC_OPI(mEntidad) < 0 Then
            Return "Error al Guardar registro."
        End If

        '*********** Actualizar lista de contratos a los que aplica la OIP ************
        Dim listaContratosBase As listaSOLIC_OPI_CONTRATOS = (New cSOLIC_OPI_CONTRATOS).ObtenerListaPorSOLIC_OPI(mEntidad.ID_OPI)
        Dim listaContratos As listaCONTRATO = Me.ucListaCONTRATO1.DevolverSeleccionados
        Dim listaContratosSelecc As New List(Of String)
        Dim listaContratosBaseAux As New List(Of String)
        Dim bSoliOipContra As New cSOLIC_OPI_CONTRATOS

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
                Dim lSoliOipContra As New SOLIC_OPI_CONTRATOS
                lSoliOipContra.ID_OPI_CONTRATO = 0
                lSoliOipContra.ID_OPI = mEntidad.ID_OPI
                lSoliOipContra.CODICONTRATO = listaContratosSelecc(i)

                bSoliOipContra.ActualizarSOLIC_OPI_CONTRATOS(lSoliOipContra)
                listaContratosBaseAux.Add(listaContratosSelecc(i))
            End If
        Next

        'Eliminar contratos que están en la base y no estén en los seleccionados
        For i As Int32 = 0 To listaContratosBaseAux.Count - 1
            If Not listaContratosSelecc.Contains(listaContratosBaseAux(i)) Then
                bSoliOipContra.EliminarPorSOLIC_OPI_CONTRATO(mEntidad.ID_OPI, listaContratosBaseAux(i))
            End If
        Next

        '*************************************
        'Lotes en Solicitud: Creación Registro 
        '*************************************
        Dim lSolicOIPLote As SOLIC_OIP_LOTE
        For Each lEntidad As SOLIC_OIP_LOTE In ucListaSOLIC_OIP_LOTE1.DevolverSeleccionados
            If Me._nuevo Then
                lSolicOIPLote = New SOLIC_OIP_LOTE
                lSolicOIPLote.ID_SOLI_LOTE = 0
                lSolicOIPLote.ID_OPI = mEntidad.ID_OPI
                lSolicOIPLote.ID_ZAFRA = cbxZAFRA.Value
                lSolicOIPLote.ACCESLOTE = lEntidad.ACCESLOTE
                lSolicOIPLote.MZ = lEntidad.MZ
                lSolicOIPLote.TONEL_ESTI = lEntidad.TONEL_ESTI
                lSolicOIPLote.USUARIO_CREA = Me.ObtenerUsuario
                lSolicOIPLote.FECHA_CREA = cFechaHora.ObtenerFechaHora
                lSolicOIPLote.USUARIO_ACT = Me.ObtenerUsuario
                lSolicOIPLote.FECHA_ACT = cFechaHora.ObtenerFechaHora
                bSolicOIPLotes.ActualizarSOLIC_OIP_LOTE(lSolicOIPLote)
            End If
        Next

        If Me._nuevo Then ScriptManager.RegisterClientScriptBlock(Me, Page.GetType, "script", "MostrarOPI(" + mEntidad.ID_OPI.ToString + "); " + _
                                                                            "MostrarAnalisisFinanciero(4," + mEntidad.ID_OPI.ToString + ")", True)

        Me.txtID_OPI.Text = mEntidad.ID_OPI.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function

    Public Function Anular() As String
        Dim bSolicOPI As New cSOLIC_OPI
        Dim mEntidad As SOLIC_OPI
        Dim lRet As Int32 = 0
        Dim sError As String

        mEntidad = (New cSOLIC_OPI).ObtenerSOLIC_OPI(Me.ID_OPI)
        mEntidad.ID_ESTADO = EstadoSolicAgricola.Anulada
        mEntidad.USUARIO_ACT = Me.ObtenerUsuario
        mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora

        bSolicOPI.ActualizarSOLIC_OPI(mEntidad)
        sError = bSolicOPI.sError

        If sError <> "" Then Return sError

        Me.ID_OPI = mEntidad.ID_OPI
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function

    Public Function AceptarOIP() As String
        Dim bContratoProvision As New cCONTRATO_CTAS_PROVI
        Dim sError As New String("")
        Dim alDatos As New ArrayList

        sError = Me.Actualizar
        If sError <> "" Then Return sError

        mEntidad = New SOLIC_OPI
        mEntidad = (New cSOLIC_OPI).ObtenerSOLIC_OPI(CInt(Me.txtID_OPI.Text))
        mEntidad.USUARIO_ACT = Me.ObtenerUsuario
        mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
        mEntidad.PORC_DESCTO_PLA = Me.spePORC_DESCTO_PLA.Value
        mEntidad.ES_ACEPTADA = True
        mEntidad.ID_ESTADO = EstadoSolicAgricola.Aceptada

        If mComponente.ActualizarSOLIC_OPI(mEntidad) < 0 Then
            Return "Error al Guardar registro."
        End If
        Return ""
    End Function

    Protected Sub txtCODIPROVEE_ValueChanged(sender As Object, e As System.EventArgs) Handles txtCODIPROVEE.ValueChanged
        Me.ObtenerProveedor()
        Me.chkSelectTodosLotes.Checked = False
        Me.ucListaSOLIC_OIP_LOTE1.QuitarSelecciones()
    End Sub

    Private Sub ObtenerProveedor()
        Me.txtNOMBRE_PROVEEDOR.Text = ""
        If Me.txtCODIPROVEE.Text <> "" AndAlso Utilerias.EsNumeroEntero(Me.txtCODIPROVEE.Text) Then
            Dim lCodiprovee As String = Utilerias.FormatoCODIPROVEE(Me.txtCODIPROVEE.Text) + Utilerias.FormatoCODISOCIO(0)
            Dim lProveedor As PROVEEDOR = (New cPROVEEDOR).ObtenerPROVEEDOR(lCodiprovee)
            If lProveedor IsNot Nothing Then
                Me.txtNOMBRE_PROVEEDOR.Text = lProveedor.NOMBRES + " " + lProveedor.APELLIDOS
                Me.ObtenerLotes()
            End If
        End If
    End Sub

    Private Sub ObtenerLotes()
        Dim sCodiProveedor As String

        If Not Utilerias.EsNumeroEntero(txtCODIPROVEE.Value) Then
            sCodiProveedor = Utilerias.FormatoCODIPROVEE(0)
        Else
            sCodiProveedor = Utilerias.FormatoCODIPROVEE(txtCODIPROVEE.Value) + Utilerias.FormatoCODISOCIO(0)
        End If
        Me.LISTA_SOLIC_OIP_LOTE = (New cSOLIC_OIP_LOTE).ObtenerListaPorZAFRA_CONTRATADA_PROVEEDOR_CONTRATADO(cbxZAFRA.Value, sCodiProveedor)
        Me.CargarDetalleOIPLotes()
        Me.chkSelectTodosLotes.Checked = False
        Me.ucListaSOLIC_OIP_LOTE1.QuitarSelecciones()
    End Sub


    Private Sub ObtenerContratos(ByVal CODIPROVEE As String)
        Me.ucListaCONTRATO1.CargarDatosPorCriterios(Me.cbxZAFRA.Value, -1, CODIPROVEE, "")
    End Sub

    Private Sub chkSelectTodosLotes_CheckedChanged(sender As Object, e As EventArgs) Handles chkSelectTodosLotes.CheckedChanged
        If Me.chkSelectTodosLotes.Checked Then
            Me.ucListaSOLIC_OIP_LOTE1.SeleccionarTodos()
        Else
            Me.ucListaSOLIC_OIP_LOTE1.QuitarSelecciones()
        End If
    End Sub
End Class
