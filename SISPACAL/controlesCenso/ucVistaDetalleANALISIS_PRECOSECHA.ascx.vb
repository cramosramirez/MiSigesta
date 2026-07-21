Imports SISPACAL.BL
Imports SISPACAL.EL
Imports DevExpress.Web

Partial Class controlesCenso_ucVistaDetalleANALISIS_PRECOSECHA
    Inherits ucBase

#Region "Propiedades"

    Private _ID_ANALISIS_PRE As Int32
    Public Property ID_ANALISIS_PRE() As Int32
        Get
            Return Me.txtID_ANALISIS_PRE.Text
        End Get
        Set(ByVal Value As Int32)
            Me._ID_ANALISIS_PRE = Value
            Me.txtID_ANALISIS_PRE.Text = Value
            If Me._ID_ANALISIS_PRE > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property CODIPROVEE() As String
        Get
            Return Me.speCODIPROVEE.Text
        End Get
        Set(ByVal value As String)
            Me.speCODIPROVEE.Text = value.ToString()
        End Set
    End Property

    Public Property NOMBRE_PROVEEDOR() As String
        Get
            Return Me.txtNOMBRE_PROVEEDOR.Text
        End Get
        Set(ByVal value As String)
            Me.txtNOMBRE_PROVEEDOR.Text = value.ToString()
        End Set
    End Property

    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cANALISIS_PRECOSECHA
    Private mEntidad As ANALISIS_PRECOSECHA
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
        'Introducir aquí el código de usuario para inicializar la página
        If Not Me.ViewState("nuevo") Is Nothing Then Me._nuevo = Me.ViewState("nuevo")
        If Not Me.ViewState("ID_ANALISIS_PRE") Is Nothing Then Me._ID_ANALISIS_PRE = Me.ViewState("ID_ANALISIS_PRE")
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información del registro de la tabla PROVEEDOR
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/06/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()
        Dim lLote As LOTES
        Dim codiProveedor As String = ""

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New ANALISIS_PRECOSECHA
        mEntidad.ID_ANALISIS_PRE = ID_ANALISIS_PRE

        If mComponente.ObtenerANALISIS_PRECOSECHA(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If

        dteFECHA_MUESTRA.Date = mEntidad.FECHA_MUESTRA
        speNO_MUESTRA.Value = mEntidad.NO_MUESTRA
        speNO_ANALISIS.Value = mEntidad.NO_ANALISIS

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

        Me.ucListaLOTES1.CargarDatosPorZAFRA_CONTRATADA_PROVEEDOR_CONTRATADO(mEntidad.ID_ZAFRA, codiProveedor, cProceso.ObtenerCODIAGRON(Me.ObtenerUsuario))
        Me.ucListaLOTES1.SeleccionarFila = mEntidad.ACCESLOTE
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/06/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.txtID_ANALISIS_PRE.ClientEnabled = False
        Me.cbxZAFRA.ClientEnabled = False
        Me.dteFECHA_MUESTRA.ClientEnabled = edicion
        Me.speNO_MUESTRA.ClientEnabled = False
        Me.speNO_ANALISIS.ClientEnabled = False
        Me.speCODIPROVEE.ClientEnabled = edicion
        Me.txtNOMBRE_PROVEEDOR.ClientEnabled = False
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/06/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.txtID_ANALISIS_PRE.Text = ""
        Me.dteFECHA_MUESTRA.Value = Nothing
        Me.speNO_MUESTRA.Value = Nothing
        Me.speNO_ANALISIS.Value = Nothing
        Me.speCODIPROVEE.Value = Nothing
        'Me.speCODISOCIO.Value = Nothing
        Me.txtNOMBRE_PROVEEDOR.Value = Nothing
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        If lZafra IsNot Nothing Then
            Me.cbxZAFRA.Value = lZafra.ID_ZAFRA
        End If
        Me.ucListaLOTES1.CargarDatosPorZAFRA_CONTRATADA_PROVEEDOR_CONTRATADO(-1, "", "")
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Guarda la información del registro en la tabla PROVEEDOR
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/06/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        Dim lLoteSelect As listaLOTES

        mEntidad = New ANALISIS_PRECOSECHA
        If Me._nuevo Then
            mEntidad.USUARIO_CREA = Me.ObtenerUsuario
            mEntidad.FECHA_CREA = cFechaHora.ObtenerFechaHora
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_CT = cFechaHora.ObtenerFechaHora
            mEntidad.NO_MUESTRA = 0
            mEntidad.NO_ANALISIS = 0
        Else
            mEntidad = mComponente.ObtenerANALISIS_PRECOSECHA(Me.txtID_ANALISIS_PRE.Text)
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_CT = cFechaHora.ObtenerFechaHora
            mEntidad.NO_MUESTRA = Me.speNO_MUESTRA.Value
            mEntidad.NO_ANALISIS = Me.speNO_ANALISIS.Value
        End If
        If Me.speCODIPROVEE.Text = "" Then
            Return "Ingrese el Codigo de Proveedor/Socio"
        End If
        If Me.dteFECHA_MUESTRA.Date = #12:00:00 AM# Then
            Return "Ingrese la Fecha de Muestra"
        End If
        mEntidad.ID_ZAFRA = cbxZAFRA.Value
        mEntidad.FECHA_MUESTRA = Me.dteFECHA_MUESTRA.Date

        lLoteSelect = ucListaLOTES1.DevolverSeleccionados()
        If lLoteSelect.Count = 0 Then
            Return "Seleccione el lote donde proviene la muestra muestra"
        End If
        mEntidad.ID_SUBLOTES = -1
        mEntidad.ACCESLOTE = lLoteSelect(0).ACCESLOTE

        If mComponente.ActualizarANALISIS_PRECOSECHA(mEntidad) < 0 Then
            Return "No se Guardo el registro. " + mComponente.sError
        End If
       
        Me.txtID_ANALISIS_PRE.Text = mEntidad.ID_ANALISIS_PRE.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        ScriptManager.RegisterClientScriptBlock(Me, Page.GetType, "script", "MostrarOrdenAnalisisPreCosecha(" + mEntidad.ID_ANALISIS_PRE.ToString + ")", True)
        Me.AsignarMensaje("Orden de Analisis emitida con exito", False, True, True)
        Return ""
    End Function

    Private Sub ObtenerProveedor()
        Me.txtNOMBRE_PROVEEDOR.Text = ""
        If Me.speCODIPROVEE.Text <> "" AndAlso Utilerias.EsNumeroEntero(Me.speCODIPROVEE.Text) Then
            Dim lCodiprovee As String = Utilerias.FormatoCODIPROVEE(Me.speCODIPROVEE.Text) + Utilerias.FormatoCODISOCIO(0)
            Dim lProveedor As PROVEEDOR = (New cPROVEEDOR).ObtenerPROVEEDOR(lCodiprovee)
            If lProveedor IsNot Nothing Then
                Me.txtNOMBRE_PROVEEDOR.Text = lProveedor.NOMBRES + " " + lProveedor.APELLIDOS
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

    Protected Sub speCODIPROVEE_ValueChanged(sender As Object, e As System.EventArgs) Handles speCODIPROVEE.ValueChanged
        Me.ObtenerProveedor()
    End Sub
End Class
