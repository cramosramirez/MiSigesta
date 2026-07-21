Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetallePROYFIN_ING
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla PROYFIN_ING
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	23/01/2020	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetallePROYFIN_ING
    Inherits ucBase
 
#Region"Propiedades"


    Public Property ID_PROYFIN_ING() As Int32
        Get
            If Me.ViewState("ID_PROYFIN_ING") IsNot Nothing Then
                Return CInt(Me.ViewState("ID_PROYFIN_ING"))
            Else
                Return -1
            End If
        End Get
        Set(ByVal Value As Int32)
            Me.ViewState("ID_PROYFIN_ING") = Value
            If Value > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public ReadOnly Property CODIPROVEE As Integer
        Get
            If Me.speCODIPROVEE.Value Is Nothing Then
                Return -1
            Else
                Return CInt(Me.speCODIPROVEE.Value)
            End If
        End Get
    End Property

    Public ReadOnly Property ID_ZAFRA As Integer
        Get
            If Me.cbxZAFRA.Value Is Nothing Then
                Return -1
            Else
                Return CInt(Me.cbxZAFRA.Value)
            End If
        End Get
    End Property
   
    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cPROYFIN_ING
    Private mEntidad As PROYFIN_ING
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
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla PROYFIN_ING
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New PROYFIN_ING
        mEntidad.ID_PROYFIN_ING = ID_PROYFIN_ING
 
        If mComponente.ObtenerPROYFIN_ING(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        'Me.ddlPROVEEDORCODIPROVEEDOR.Enabled = edicion
        'Me.txtID_ZAFRA.Enabled = edicion
        'Me.deFECHA.Enabled = edicion
        'Me.txtVIP.Enabled = edicion
        'Me.txtUSUARIO_CREA.Enabled = edicion
        'Me.deFECHA_CREA.Enabled = edicion
        'Me.txtUSUARIO_ACT.Enabled = edicion
        'Me.deFECHA_ACT.Enabled = edicion
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/01/2020	Created
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
        Me.txtNOMBRE_PROVEEDOR.Text = ""
        Me.ucListaPROYFIN_ING_LOTE1.AplicarEstilo()
        Me.ucListaPROYFIN_ING_LOTE1.AsignarEncabezadoColumnas(-1)
        Me.ucListaPROYFIN_ING_LOTE1.CargarDatosPorPROYFIN_ING(-1)
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla PROYFIN_ING
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        mEntidad = New PROYFIN_ING

        If Me.ID_PROYFIN_ING > 0 Then
            mEntidad = (New cPROYFIN_ING).ObtenerPROYFIN_ING(Me.ID_PROYFIN_ING)
            mEntidad.EN_PROCESO = False
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora

            If mComponente.ActualizarPROYFIN_ING(mEntidad) <> 1 Then
                Me.AsignarMensaje("Error al Guardar registro.", True, True)
                Return "Error al Guardar registro."
            End If
        End If

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function

    Private Sub Limpiar()
        Me.speCODIPROVEE.Value = Nothing
        Me.txtNOMBRE_PROVEEDOR.Text = ""
    End Sub

    Protected Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Me.ucBusquedaProveedor1.Inicializar()
        Me.pcBusquedaProveedor.ShowOnPageLoad = True
    End Sub

    Protected Sub ucBusquedaProveedor1_Aceptar(CODIPROVEEDOR As String) Handles ucBusquedaProveedor1.Aceptar
        Dim lProveedor As PROVEEDOR = (New cPROVEEDOR).ObtenerPROVEEDOR(CODIPROVEEDOR)

        If lProveedor IsNot Nothing Then
            Me.speCODIPROVEE.Text = Utilerias.RecuperarCODIPROVEE(lProveedor.CODIPROVEEDOR)
            Me.txtNOMBRE_PROVEEDOR.Text = lProveedor.NOMBRES + " " + lProveedor.APELLIDOS
            Me.speCODIPROVEE_ValueChanged(speCODIPROVEE, New System.EventArgs)
        End If
        Me.pcBusquedaProveedor.ShowOnPageLoad = False
    End Sub

    Protected Sub ucBusquedaProveedor1_Cancelar() Handles ucBusquedaProveedor1.Cancelar
        Me.pcBusquedaProveedor.ShowOnPageLoad = False
    End Sub

    Protected Sub speCODIPROVEE_ValueChanged(sender As Object, e As EventArgs) Handles speCODIPROVEE.ValueChanged
        If Me.speCODIPROVEE.Value IsNot Nothing Then
            Dim sCodiProvee As String = Utilerias.FormatearCODIPROVEEDOR(CInt(Me.speCODIPROVEE.Value))
            Dim lProveedor As PROVEEDOR = (New cPROVEEDOR).ObtenerPROVEEDOR(sCodiProvee)

            If lProveedor IsNot Nothing Then
                Me.txtNOMBRE_PROVEEDOR.Text = lProveedor.NOMBRES + " " + lProveedor.APELLIDOS
            End If

            Me.CargarLotesParaProyeccion()
        Else
            Me.txtNOMBRE_PROVEEDOR.Text = ""
        End If
    End Sub

    Public Sub CargarLotesParaProyeccion()
        Dim bProyFinanIng As New cPROYFIN_ING
        Dim id As Integer = 0
        Dim sCodiproveedor As String = ""

        sCodiproveedor = Utilerias.FormatearCODIPROVEEDOR(CInt(Me.speCODIPROVEE.Value))
        id = bProyFinanIng.PROC_Iniciar_ProyFinan_Productor(sCodiproveedor, Me.cbxZAFRA.Value, Me.ObtenerUsuario)
        Me.ucListaPROYFIN_ING_LOTE1.AsignarEncabezadoColumnas(Me.cbxZAFRA.Value)

        If id > 0 Then
            Me.ViewState("ID_PROYFIN_ING") = id
            Me.ucListaPROYFIN_ING_LOTE1.CargarDatosPorPROYFIN_ING(id)
        End If
    End Sub

    Public Sub CargarProduccionDeLotes()
        Dim lstLotesProyFinan As listaPROYFIN_ING_LOTE
        Dim bProyFinanIng As New cPROYFIN_ING
        Dim id As Integer = 0

        lstLotesProyFinan = ucListaPROYFIN_ING_LOTE1.DevolverSeleccionados
        If lstLotesProyFinan Is Nothing OrElse lstLotesProyFinan.Count = 0 Then
            Me.AsignarMensaje("Seleccione los lotes a incluir en la proyeccion de ingresos", False, True)
            Return
        Else
            For i As Integer = 0 To lstLotesProyFinan.Count - 1
                id = bProyFinanIng.PROC_Generar_ProyFinan_Lote(Me.cbxZAFRA.Value, lstLotesProyFinan(i).ID_PROYFIN_ING_LOTE, lstLotesProyFinan(i).ACCESLOTE)
            Next
            Me.ucListaPROYFIN_ING_LOTE1.QuitarSeleccion()
            Me.ucListaPROYFIN_ING_LOTE1.DataBind()
        End If


    End Sub
End Class
