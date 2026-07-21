Imports SISPACAL.EL.Enumeradores

Partial Class controlesProforma_ucRegistroProforma
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

        Select Case TIPO_OPERACION
            Case TipoOperacion.RegistroProforma
                lblTitulo.Text = "Registro de Proforma de Envío"
                Me.ucBarraNavegacion1.CrearOpcion("GuardarProforma", "Registrar Proforma", False, IconoBarra.Guardar, "", "", True)
                Me.ucBarraNavegacion1.CrearOpcion("CancelarProforma", "Cancelar", False, IconoBarra.Cancelar, "", "", True)
                Me.ucBarraNavegacion1.VerOpcion("GuardarProforma", True)
                Me.ucBarraNavegacion1.VerOpcion("CancelarProforma", True)
            Case TipoOperacion.CambioFechaQuemaRoza
                lblTitulo.Text = "Cambio de Fecha Quema / Roza"
                Me.ucBarraNavegacion1.CrearOpcion("GuardarProforma", "Guardar Cambio Fecha Proforma", False, IconoBarra.Guardar, "", "", True)
                Me.ucBarraNavegacion1.CrearOpcion("CancelarProforma", "Cancelar", False, IconoBarra.Cancelar, "", "", True)
                Me.ucBarraNavegacion1.VerOpcion("GuardarProforma", True)
                Me.ucBarraNavegacion1.VerOpcion("CancelarProforma", True)
            Case TipoOperacion.AnulacionProforma
                lblTitulo.Text = "Anulación de Proforma de Envío"
                Me.ucBarraNavegacion1.CrearOpcion("AnularProforma", "Anular Proforma", False, IconoBarra.Anular, "", "", True)
                Me.ucBarraNavegacion1.CrearOpcion("CancelarProforma", "Cancelar", False, IconoBarra.Cancelar, "", "", True)
                Me.ucBarraNavegacion1.VerOpcion("AnularProforma", True)
                Me.ucBarraNavegacion1.VerOpcion("CancelarProforma", True)
            Case TipoOperacion.ConsultaProforma
                lblTitulo.Text = "Consulta de Proforma de Envío"
                Me.ucBarraNavegacion1.CrearOpcion("ImprimirProforma", "Imprimir Proforma", False, IconoBarra.Anular, "", "", True)
                Me.ucBarraNavegacion1.CrearOpcion("CancelarProforma", "Cancelar", False, IconoBarra.Cancelar, "", "", True)
                Me.ucBarraNavegacion1.VerOpcion("ImprimirProforma", True)
                Me.ucBarraNavegacion1.VerOpcion("CancelarProforma", True)
        End Select
        Me.ucEnvioProforma1.TIPO_OPERACION = TIPO_OPERACION
        Me.ucBarraNavegacion1.CargarOpciones()
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Me.Inicializar()
        End If
    End Sub
    
    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(ByVal CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        Select Case CommandName

            Case "CancelarProforma"
                AsignarMensaje("", True, False)
                ucEnvioProforma1.LimpiarControles()
                ucEnvioProforma1.Enabled = False
                ucEnvioProforma1.ID_PROFORMA = 0
                AsignarMensaje("", True, False)

            Case "GuardarProforma"
                Dim lResult As String = Me.ucEnvioProforma1.ActualizarProforma()
                If lResult = "" Then
                    ucEnvioProforma1.LimpiarControles()
                    ucEnvioProforma1.ID_PROFORMA = 0
                    AsignarMensaje("", True, False)
                Else
                    AsignarMensaje(lResult, True, False)
                End If

            Case "AnularProforma"
                Dim lResult As String = Me.ucEnvioProforma1.ActualizarProforma()
                If lResult = "" Then
                    ucEnvioProforma1.LimpiarControles()
                    ucEnvioProforma1.ID_PROFORMA = 0
                    AsignarMensaje("", True, False)
                Else
                    AsignarMensaje(lResult, True, False)
                End If

            Case "ImprimirProforma"
                Dim lResult As String = Me.ucEnvioProforma1.ActualizarProforma()
                If lResult = "" Then
                    ucEnvioProforma1.LimpiarControles()
                    ucEnvioProforma1.ID_PROFORMA = 0
                    AsignarMensaje("", True, False)
                Else
                    AsignarMensaje(lResult, True, False)
                End If
        End Select
    End Sub
End Class


