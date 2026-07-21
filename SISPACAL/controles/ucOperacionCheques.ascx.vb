Imports SISPACAL.EL.Enumeradores

Partial Class controles_ucOperacionCheques
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

    Public Sub Inicializar()
        Me.ucBarraNavegacion1.PermitirNavegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucBarraNavegacion1.CargarOpciones()
        Me.ucControlCheques1.TIPO_OPERACION = TIPO_OPERACION
        Select Case TIPO_OPERACION
            Case TipoOperacion.Emision
                lblTitulo.Text = "Emisión de Cheques"
                Me.ucBarraNavegacion1.CrearOpcion("Emitir", "Emitir cheques", False, IconoBarra.Generar, "", "", True)
                Me.ucBarraNavegacion1.CrearOpcion("VistaPrevia", "Vista previa", False, IconoBarra.VistaPrevia, "", "", True)
                Me.ucBarraNavegacion1.CrearOpcion("Cancelar", "Cancelar", False, IconoBarra.Cancelar, "", "", True)
                Me.ucBarraNavegacion1.VerOpcion("Guardar", True)
                Me.ucBarraNavegacion1.VerOpcion("VistaPreliminar", True)
                Me.ucBarraNavegacion1.VerOpcion("Cancelar", True)
            Case TipoOperacion.Anulacion
                lblTitulo.Text = "Anulación de Cheques"
                Me.ucBarraNavegacion1.CrearOpcion("Buscar", "Buscar", False, IconoBarra.Buscar, "", "", True)
                Me.ucBarraNavegacion1.CrearOpcion("Anular", "Eliminar", False, IconoBarra.Eliminar, "", "", True)
                Me.ucBarraNavegacion1.CrearOpcion("Cancelar", "Cancelar", False, IconoBarra.Cancelar, "", "", True)
                Me.ucBarraNavegacion1.VerOpcion("Buscar", True)
                Me.ucBarraNavegacion1.VerOpcion("Cancelar", True)
        End Select
        Me.ucBarraNavegacion1.CargarOpciones()
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Me.Inicializar()
        End If
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(ByVal CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        Me.AsignarMensaje("", True, False)
        Select Case CommandName
            Case "Emitir"
                Me.ucControlCheques1.EmitirCheques()

            Case "VistaPrevia"
                Me.ucControlCheques1.CargarChequesPendientesEmitir()

            Case "Buscar"
                Me.ucControlCheques1.CargarChequesPlanilla()

            Case "Cancelar"
                Me.ucControlCheques1.Nuevo()

            Case "Anular"
                Me.ucControlCheques1.AnularCheques()
        End Select
    End Sub
End Class
