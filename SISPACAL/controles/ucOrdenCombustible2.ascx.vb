Imports SISPACAL.EL.Enumeradores

Partial Class controles_ucOrdenCombustible2
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
        Me.ucVistaDetalleORDEN_COMBUSTIBLEV21.TIPO_OPERACION = TIPO_OPERACION
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

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Me.Inicializar()
        End If
    End Sub

    Protected Sub ucBarraNavegacion1_Guardar(sender As Object, e As EventArgs) Handles ucBarraNavegacion1.Guardar
        Dim lResult As String = Me.ucVistaDetalleORDEN_COMBUSTIBLEV21.Actualizar()
        If lResult = "" Then
            ucVistaDetalleORDEN_COMBUSTIBLEV21.LimpiarControles()
            ucVistaDetalleORDEN_COMBUSTIBLEV21.ID_ORDEN_COMBUS = 0
        End If
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        Select Case CommandName
            Case "Cancelar"
                ucVistaDetalleORDEN_COMBUSTIBLEV21.LimpiarControles()
                ucVistaDetalleORDEN_COMBUSTIBLEV21.Enabled = (ucVistaDetalleORDEN_COMBUSTIBLEV21.TIPO_OPERACION = TipoOperacion.Emision)
                ucVistaDetalleORDEN_COMBUSTIBLEV21.ID_ORDEN_COMBUS = 0

            Case "Guardar"
                Dim lResult As String = Me.ucVistaDetalleORDEN_COMBUSTIBLEV21.Actualizar()
                If lResult = "" Then
                    ucVistaDetalleORDEN_COMBUSTIBLEV21.LimpiarControles()
                    ucVistaDetalleORDEN_COMBUSTIBLEV21.Enabled = (ucVistaDetalleORDEN_COMBUSTIBLEV21.TIPO_OPERACION = TipoOperacion.Emision)
                    ucVistaDetalleORDEN_COMBUSTIBLEV21.ID_ORDEN_COMBUS = 0
                End If
        End Select
    End Sub
End Class
