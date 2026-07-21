Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucMantCOMPROB_ENCA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para el Mantenimiento de la tabla COMPROB_ENCA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/11/2023	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucMantCOMPROB_ENCA
    Inherits ucBase


    Private Sub Inicializar()
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        Me.ucBarraNavegacion1.PermitirNavegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucBarraNavegacion1.CrearOpcion("Buscar", "Buscar", False, IconoBarra.Buscar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Guardar", "Guardar", True, IconoBarra.Guardar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Cancelar", "Cancelar", False, IconoBarra.Cancelar, "", "", True)
        Me.ucBarraNavegacion1.CargarOpciones()

        If lZafra IsNot Nothing Then
            Me.cbxZAFRA.Value = lZafra.ID_ZAFRA
        End If
        Me.CargarCatorcenas()
        Me.cbxTIPO_PLANILLA.SelectedIndex = 0
    End Sub

    Public Sub InicializarLista()
        Me.ucBarraNavegacion1.VerOpcion("Buscar", True)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", False)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", False)
        Me.ucCriteriosComprobEnca.Visible = True
        Me.ucListaCOMPROB_ENCA1.Visible = True
        Me.ucVistaDetalleCREFISCAL_PROVEEDOR1.Visible = False
    End Sub

    Private Sub InicializarDetalle()
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.VerOpcion("Buscar", False)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", True)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", True)
        Me.ucCriteriosComprobEnca.Visible = False
        Me.ucListaCOMPROB_ENCA1.Visible = False
        Me.ucVistaDetalleCREFISCAL_PROVEEDOR1.Visible = True
    End Sub

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquÃ­ el cÃ³digo de usuario para inicializar la pÃ¡gina
        If Not IsPostBack Then
            Me.Inicializar()
            Me.InicializarLista()
        End If
    End Sub
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla COMPROB_ENCA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/11/2023	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Try
            Dim iIdCatorcena As Integer
            Dim iIdTipoPlanilla As Integer

            If Me.cbxCATORCENA_ZAFRA.Value Is Nothing Then
                Me.AsignarMensaje("Seleccione la catorcena", False, True, True)
                Return 0
            End If

            If Me.cbxTIPO_PLANILLA.Value Is Nothing Then
                Me.AsignarMensaje("Seleccione el tipo de planilla", False, True, True)
                Return 0
            End If

            iIdCatorcena = Convert.ToInt32(cbxCATORCENA_ZAFRA.Value)
            iIdTipoPlanilla = Convert.ToInt32(cbxTIPO_PLANILLA.Value)

            Return ucListaCOMPROB_ENCA1.CargarDatosPorCriterios(iIdCatorcena, iIdTipoPlanilla)

        Catch ex As Exception
            Return -1
        End Try
        Return 1
    End Function

    Private Sub CargarCatorcenas()
        Dim lista As listaCATORCENA_ZAFRA

        If Me.cbxZAFRA.Value IsNot Nothing Then
            lista = (New cCATORCENA_ZAFRA).ObtenerListaPorZAFRA(Me.cbxZAFRA.Value, False, False, "CATORCENA", "DESC")
        Else
            lista = New listaCATORCENA_ZAFRA
        End If
        Me.cbxCATORCENA_ZAFRA.DataSource = lista
        Me.cbxCATORCENA_ZAFRA.DataBind()
        If Me.cbxCATORCENA_ZAFRA.Items.Count > 0 Then Me.cbxCATORCENA_ZAFRA.SelectedIndex = 0
    End Sub

    Protected Sub cbxZAFRA_ValueChanged(sender As Object, e As EventArgs) Handles cbxZAFRA.ValueChanged
        Me.CargarCatorcenas()
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        Select Case CommandName
            Case "Buscar"
                Me.CargarDatos()

            Case "Guardar"
                Dim sError As String
                sError = Me.ucVistaDetalleCREFISCAL_PROVEEDOR1.Actualizar()
                If sError <> "" Then
                    AsignarMensaje(sError, True, False)
                    Return
                End If
                AsignarMensaje("", True, False)
                AsignarMensaje("El comprobante fiscal se guardo con exito.", False, True, True)
                Me.ucListaCOMPROB_ENCA1.DataBind()
                Me.ucVistaDetalleCREFISCAL_PROVEEDOR1.LimpiarControles()
                Me.ucVistaDetalleCREFISCAL_PROVEEDOR1.ID_COMPROB_ENCA = 0
                Me.InicializarLista()
                Me.ucVistaDetalleCREFISCAL_PROVEEDOR1.DataBind()
                Return

            Case "Cancelar"
                Me.AsignarMensaje("", True, False)
                Me.ucVistaDetalleCREFISCAL_PROVEEDOR1.LimpiarControles()
                Me.ucVistaDetalleCREFISCAL_PROVEEDOR1.ID_COMPROB_ENCA = 0
                Me.InicializarLista()
        End Select
    End Sub

    Private Sub ucListaCOMPROB_ENCA1_Editando(ID_COMPROB_ENCA As Integer) Handles ucListaCOMPROB_ENCA1.Editando
        Me.InicializarDetalle()
        Me.ucVistaDetalleCREFISCAL_PROVEEDOR1.ID_COMPROB_ENCA = ID_COMPROB_ENCA
    End Sub

    Private Sub ucListaCOMPROB_ENCA1_Desasociar(ID_COMPROB_ENCA As Integer) Handles ucListaCOMPROB_ENCA1.Desasociar
        Dim bCreditFiscal As New cCREFISCAL_PROVEEDOR
        Dim listaCreditFiscal As listaCREFISCAL_PROVEEDOR

        listaCreditFiscal = bCreditFiscal.ObtenerListaPorCOMPROB_ENCA(ID_COMPROB_ENCA)
        If listaCreditFiscal IsNot Nothing AndAlso listaCreditFiscal.Count > 0 Then
            For i As Integer = 0 To listaCreditFiscal.Count - 1
                bCreditFiscal.EliminarCREFISCAL_PROVEEDOR(listaCreditFiscal(i).ID_CCF)
            Next
            Me.ucListaCOMPROB_ENCA1.DataBind()
            AsignarMensaje("El comprobante fiscal se ha desasociado del comprobante de retención.", False, True, True)
        Else
            AsignarMensaje("No existe comprobante fiscal asociado.", False, True, True)
        End If


    End Sub
End Class
