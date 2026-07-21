Imports SISPACAL.EL.Enumeradores

Partial Class controles_ucComprobanteEnvio
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
        Me.ucEnvioProforma1.Visible = True
        Me.ucEnvioProforma1.TIPO_OPERACION = TIPO_OPERACION
        Select Case TIPO_OPERACION
            Case TipoOperacion.RegistroProforma
                lblTitulo.Text = "Registro de Proforma de Envío"
                Me.ucBarraNavegacion1.CrearOpcion("GuardarProforma", "Registrar Proforma", False, IconoBarra.Guardar, "", "", True)
                Me.ucBarraNavegacion1.CrearOpcion("CancelarProforma", "Cancelar", False, IconoBarra.Cancelar, "", "", True)
                Me.ucBarraNavegacion1.VerOpcion("GuardarProforma", True)
                Me.ucBarraNavegacion1.VerOpcion("CancelarProforma", True)
            Case TipoOperacion.Recepcion
                lblTitulo.Text = "Recepción de Caña"
                Me.ucBarraNavegacion1.CrearOpcion("GuardarEnvio", "Guardar", False, IconoBarra.Guardar, "", "", True)
                'Me.ucBarraNavegacion1.CrearOpcion("MostrarLotesContrato", "Mostrar lotes del Contrato", False, IconoBarra.Lote, "", "", True) '
                'Me.ucBarraNavegacion1.CrearOpcion("MostrarLotesProveedor", "Mostrar lotes del Proveedor", False, IconoBarra.Proveedor, "", "", True) '
                Me.ucBarraNavegacion1.CrearOpcion("CancelarEnvio", "Cancelar", False, IconoBarra.Cancelar, "", "", True)
                Me.ucBarraNavegacion1.VerOpcion("GuardarEnvio", True)
                Me.ucBarraNavegacion1.VerOpcion("CancelarEnvio", True)
            Case TipoOperacion.Edicion, TipoOperacion.EdicionParcialBascula
                If TIPO_OPERACION = TipoOperacion.Edicion Then
                    lblTitulo.Text = "Corrección de envío de Caña"
                    Me.ucBarraNavegacion1.CrearOpcion("GuardarEnvio", "Guardar", False, IconoBarra.Guardar, "", "", True)
                    'Me.ucBarraNavegacion1.CrearOpcion("MostrarLotesProveedor", "Mostrar lotes del Proveedor", False, IconoBarra.Proveedor, "", "", True) '
                End If
                If TIPO_OPERACION = TipoOperacion.EdicionParcialBascula Then
                    lblTitulo.Text = "Corrección de envío de Caña en Bascula"
                    Me.ucBarraNavegacion1.CrearOpcion("GuardarEnvio", "Guardar", False, IconoBarra.Guardar, "", "", True)
                End If
                Me.ucBarraNavegacion1.CrearOpcion("CancelarEnvio", "Cancelar", False, IconoBarra.Cancelar, "", "", True)
                Me.ucBarraNavegacion1.VerOpcion("GuardarEnvio", True)
                Me.ucBarraNavegacion1.VerOpcion("CancelarEnvio", True)
            Case TipoOperacion.Consulta
                Me.ucBarraNavegacion1.CrearOpcion("NuevaConsulta", "Nueva Consulta", False, IconoBarra.Consulta, "", "", True)
                lblTitulo.Text = "Consulta de envío de Caña"
            Case (TipoOperacion.Anulacion)
                Me.ucBarraNavegacion1.CrearOpcion("AnularEnvio", "Anular", False, IconoBarra.Anular, "", "", True)
                Me.ucBarraNavegacion1.CrearOpcion("CancelarEnvio", "Cancelar", False, IconoBarra.Cancelar, "", "", True)
                Me.ucBarraNavegacion1.VerOpcion("AnularEnvio", True)
                Me.ucBarraNavegacion1.VerOpcion("CancelarEnvio", True)
                lblTitulo.Text = "Anulación envío de Caña"
            Case (TipoOperacion.Eliminacion)
                Me.ucBarraNavegacion1.CrearOpcion("Eliminar", "Eliminar", False, IconoBarra.Eliminar, "", "", True)
                Me.ucBarraNavegacion1.CrearOpcion("CancelarEnvio", "Cancelar", False, IconoBarra.Cancelar, "", "", True)
                Me.ucBarraNavegacion1.VerOpcion("Eliminar", True)
                Me.ucBarraNavegacion1.VerOpcion("CancelarEnvio", True)
                lblTitulo.Text = "Eliminar envío de Caña"
        End Select
        Me.ucBarraNavegacion1.CargarOpciones()
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Me.InicializarDetalle()
        End If
    End Sub

    'Protected Sub ucBarraNavegacion1_OpcionSeleccionada(ByVal CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
    '    Select Case CommandName
    '        Case "CancelarEnvio"
    '            ucVistaDetalleENVIO1.LimpiarControles()
    '            ucVistaDetalleENVIO1.Enabled = False
    '            ucVistaDetalleENVIO1.ID_ENVIO = 0

    '        Case "GuardarEnvio"
    '            Dim lResult As String = Me.ucVistaDetalleENVIO1.Actualizar()
    '            If lResult = "" Then
    '                ucVistaDetalleENVIO1.LimpiarControles()
    '                ucVistaDetalleENVIO1.ID_ENVIO = 0
    '            Else
    '                AsignarMensaje(lResult, True, False)
    '            End If

    '        Case "AnularEnvio"
    '            Dim lResult As String = Me.ucVistaDetalleENVIO1.Anular()
    '            If lResult = "" Then
    '                ucVistaDetalleENVIO1.LimpiarControles()
    '                ucVistaDetalleENVIO1.ID_ENVIO = 0
    '            Else
    '                AsignarMensaje(lResult, True, False)
    '            End If

    '        Case "NuevaConsulta"
    '            ucVistaDetalleENVIO1.TIPO_OPERACION = TipoOperacion.Consulta

    '        Case "Eliminar"
    '            Dim lResult As String = Me.ucVistaDetalleENVIO1.Eliminar()
    '            If lResult = "" Then
    '                ucVistaDetalleENVIO1.LimpiarControles()
    '                ucVistaDetalleENVIO1.ID_ENVIO = 0
    '            Else
    '                AsignarMensaje(lResult, True, False)
    '            End If
    '    End Select
    'End Sub
    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(ByVal CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        Me.AsignarMensaje("", True, False)

        Select Case CommandName
            Case "CancelarEnvio"
                ucEnvioProforma1.LimpiarControles()
                ucEnvioProforma1.Enabled = False
                ucEnvioProforma1.ID_ENVIO = 0

            Case "CancelarProforma"
                ucEnvioProforma1.LimpiarControles()
                ucEnvioProforma1.Enabled = False
                ucEnvioProforma1.ID_PROFORMA = 0

            Case "GuardarProforma"
                Dim lResult As String = Me.ucEnvioProforma1.ActualizarProforma()
                If lResult = "" Then
                    ucEnvioProforma1.LimpiarControles()
                    ucEnvioProforma1.ID_PROFORMA = 0
                Else
                    AsignarMensaje(lResult, True, False)
                End If

            Case "GuardarEnvio"
                Dim lResult As String = Me.ucEnvioProforma1.Actualizar()
                If lResult = "" Then
                    ucEnvioProforma1.LimpiarControles()
                    ucEnvioProforma1.ID_ENVIO = 0
                Else
                    AsignarMensaje(lResult, True, False)
                End If

            Case "AnularEnvio"
                Dim lResult As String = Me.ucEnvioProforma1.Anular()
                If lResult = "" Then
                    ucEnvioProforma1.LimpiarControles()
                    ucEnvioProforma1.ID_ENVIO = 0
                Else
                    AsignarMensaje(lResult, True, False)
                End If

            Case "MostrarLotesContrato"
                'Dim lResult As String = Me.ucEnvioProforma1.MostrarLotesDelContrato
                'AsignarMensaje(lResult, True, False)

            Case "MostrarLotesProveedor"
                'Dim lResult As String = Me.ucEnvioProforma1.MostrarLotesProveedorEnZafra
                'AsignarMensaje(lResult, True, False)

            Case "NuevaConsulta"
                ucEnvioProforma1.TIPO_OPERACION = TipoOperacion.Consulta

            Case "Eliminar"
                Dim lResult As String = Me.ucEnvioProforma1.Eliminar()
                If lResult = "" Then
                    ucEnvioProforma1.LimpiarControles()
                    ucEnvioProforma1.ID_ENVIO = 0
                Else
                    AsignarMensaje(lResult, True, False)
                End If
        End Select
    End Sub
End Class
