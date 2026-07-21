Imports SISPACAL.EL.Enumeradores
Imports CrystalDecisions.CrystalReports.Engine

Partial Class controles_ucOrdenCombustible
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
        Me.AsignarTituloOpcion("Usuario")
        Me.ucBarraNavegacion1.PermitirNavegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucVistaDetalleORDEN_COMBUSTIBLE1.TIPO_OPERACION = TIPO_OPERACION
        Select Case TIPO_OPERACION
            Case TipoOperacion.Emision
                lblTitulo.Text = "EMISIÓN DE ORDEN DE ENTREGA DE COMBUSTIBLE"

            Case TipoOperacion.Anulacion
                lblTitulo.Text = "ANULACIÓN DE ORDEN DE ENTREGA DE COMBUSTIBLE"

            Case TipoOperacion.Facturacion
                lblTitulo.Text = "FACTURACIÓN DE ORDEN DE ENTREGA DE COMBUSTIBLE"
        End Select
        Me.ucBarraNavegacion1.CrearOpcion("Guardar", "Guardar", False, IconoBarra.Guardar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Cancelar", "Cancelar", False, IconoBarra.Cancelar, "", "", True)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", True)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", True)
        Me.ucBarraNavegacion1.CargarOpciones()
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Me.Inicializar()
        End If
    End Sub

    Protected Sub ucBarraNavegacion1_Guardar(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucBarraNavegacion1.Guardar
        Dim lResult As String = Me.ucVistaDetalleORDEN_COMBUSTIBLE1.Actualizar()
        If lResult = "" Then
            ucVistaDetalleORDEN_COMBUSTIBLE1.LimpiarControles()
            ucVistaDetalleORDEN_COMBUSTIBLE1.ID_ORDEN_COMBUS = 0
        End If
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(ByVal CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        Select Case CommandName
            Case "Cancelar"
                ucVistaDetalleORDEN_COMBUSTIBLE1.LimpiarControles()
                ucVistaDetalleORDEN_COMBUSTIBLE1.Enabled = (ucVistaDetalleORDEN_COMBUSTIBLE1.TIPO_OPERACION = TipoOperacion.Emision)
                ucVistaDetalleORDEN_COMBUSTIBLE1.ID_ORDEN_COMBUS = 0

            Case "Guardar"
                Dim lResult As String = Me.ucVistaDetalleORDEN_COMBUSTIBLE1.Actualizar()
                If lResult = "" Then
                    ucVistaDetalleORDEN_COMBUSTIBLE1.LimpiarControles()
                    ucVistaDetalleORDEN_COMBUSTIBLE1.Enabled = (ucVistaDetalleORDEN_COMBUSTIBLE1.TIPO_OPERACION = TipoOperacion.Emision)
                    ucVistaDetalleORDEN_COMBUSTIBLE1.ID_ORDEN_COMBUS = 0
                End If
        End Select
    End Sub
End Class
