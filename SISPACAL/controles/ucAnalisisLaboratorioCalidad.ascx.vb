Imports SISPACAL.EL.Enumeradores

Partial Class controles_ucAnalisisLaboratorioCalidad
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

    Public Property MOSTRAR_RENDIMIENTOS As Boolean
        Get
            Return Me.ucVistaDetalleANALISIS1.MOSTRAR_RENDIMIENTOS
        End Get
        Set(value As Boolean)
            Me.ucVistaDetalleANALISIS1.MOSTRAR_RENDIMIENTOS = value
        End Set
    End Property


    Public Sub InicializarDetalle()
        Me.AsignarTituloOpcion("Usuario")
        Me.ucBarraNavegacion1.PermitirNavegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucVistaDetalleANALISIS1.TIPO_OPERACION = TIPO_OPERACION
        Select Case TIPO_OPERACION
            Case TipoOperacion.Edicion
                lblTitulo.Text = "Corrección de Análisis de Laboratorio de Calidad"
                Me.ucBarraNavegacion1.CrearOpcion("GuardarAnalisis", "Guardar", False, IconoBarra.Guardar, "", "", True)
                Me.ucBarraNavegacion1.CrearOpcion("CancelarAnalisis", "Cancelar", False, IconoBarra.Cancelar, "", "", True)
                Me.ucBarraNavegacion1.VerOpcion("GuardarAnalisis", True)
                Me.ucBarraNavegacion1.VerOpcion("CancelarAnalisis", True)
            Case TipoOperacion.Consulta
                Me.ucBarraNavegacion1.CrearOpcion("NuevaConsulta", "Nueva Consulta", False, IconoBarra.Consulta, "", "", True)
                lblTitulo.Text = "Consulta de Análisis de Laboratorio de Calidad"
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
        Dim lResult As String = Me.ucVistaDetalleANALISIS1.Actualizar()
        If lResult = "" Then
            ucVistaDetalleANALISIS1.LimpiarControles()
            ucVistaDetalleANALISIS1.ID_ANALISIS = 0
        End If
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(ByVal CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        Select Case CommandName
            Case "CancelarAnalisis"
                ucVistaDetalleANALISIS1.LimpiarControles()
                ucVistaDetalleANALISIS1.ID_ANALISIS = 0

            Case "GuardarAnalisis"
                Dim lResult As String = Me.ucVistaDetalleANALISIS1.Actualizar()
                If lResult = "" Then
                    ucVistaDetalleANALISIS1.LimpiarControles()
                    ucVistaDetalleANALISIS1.ID_ANALISIS = 0
                End If

            Case "NuevaConsulta"
                ucVistaDetalleANALISIS1.TIPO_OPERACION = TipoOperacion.Consulta
        End Select
    End Sub
End Class
