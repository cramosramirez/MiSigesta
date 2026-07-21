Imports SISPACAL.EL.Enumeradores

Partial Class controles_ucBascula
    Inherits ucBase

    Private _tipo_operacion As TipoOperacion
    Public Property TIPO_OPERACION As TipoOperacion
        Get
            Return _tipo_operacion
        End Get
        Set(ByVal value As TipoOperacion)
            _tipo_operacion = value
        End Set
    End Property

    Public Sub InicializarDetalle()
        Me.ucBarraNavegacion1.PermitirNavegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucVistaDetalleBASCULA1.TIPO_OPERACION = TIPO_OPERACION
        Select Case TIPO_OPERACION
            Case TipoOperacion.Edicion
                lblTitulo.Text = "Corrección de Captura de Peso en Bascula"
                Me.ucBarraNavegacion1.CrearOpcion("GuardarDatosBascula", "Guardar", False, IconoBarra.Guardar, "", "", True)
                Me.ucBarraNavegacion1.CrearOpcion("CancelarDatosBascula", "Cancelar", False, IconoBarra.Cancelar, "", "", True)
                Me.ucBarraNavegacion1.VerOpcion("GuardarDatosBascula", True)
                Me.ucBarraNavegacion1.VerOpcion("CancelarDatosBascula", True)
            Case TipoOperacion.Consulta
                Me.ucBarraNavegacion1.CrearOpcion("NuevaConsulta", "Nueva Consulta", False, IconoBarra.Consulta, "", "", True)
                lblTitulo.Text = "Consulta de Captura de Peso en Bascula"
        End Select
        Me.ucBarraNavegacion1.CargarOpciones()
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Me.InicializarDetalle()
        End If
    End Sub

    Protected Sub ucBarraNavegacion1_Guardar(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucBarraNavegacion1.Guardar
        Dim lResult As String = Me.ucVistaDetalleBASCULA1.Actualizar()
        If lResult = "" Then
            ucVistaDetalleBASCULA1.LimpiarControles()
            ucVistaDetalleBASCULA1.ID_BASCULA = 0
        End If
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(ByVal CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        Select Case CommandName
            Case "CancelarDatosBascula"
                ucVistaDetalleBASCULA1.LimpiarControles()
                ucVistaDetalleBASCULA1.ID_BASCULA = 0

            Case "GuardarDatosBascula"
                Dim lResult As String = Me.ucVistaDetalleBASCULA1.Actualizar()
                If lResult = "" Then
                    ucVistaDetalleBASCULA1.LimpiarControles()
                    ucVistaDetalleBASCULA1.ID_BASCULA = 0
                End If

            Case "NuevaConsulta"
                ucVistaDetalleBASCULA1.TIPO_OPERACION = TipoOperacion.Consulta
        End Select
    End Sub

End Class
