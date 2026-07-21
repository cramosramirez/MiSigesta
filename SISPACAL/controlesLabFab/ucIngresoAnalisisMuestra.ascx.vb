Imports SISPACAL.EL.Enumeradores

Partial Class controlesLabFab_ucIngresoAnalisisMuestra
    Inherits ucBase

    Private _tipo_operacion As TipoOperacionAnalisisFab
    Public Property TIPO_OPERACION As TipoOperacionAnalisisFab
        Get
            Return _tipo_operacion
        End Get
        Set(ByVal value As TipoOperacionAnalisisFab)
            _tipo_operacion = value
        End Set
    End Property

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Inicializar()
        End If
    End Sub

    Private Sub Inicializar()
        Me.ucBarraNavegacion1.PermitirNavegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False

        Me.ucBarraNavegacion1.CrearOpcion("Guardar", "Guardar Analisis", False, IconoBarra.Guardar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Cancelar", "Cancelar", False, IconoBarra.Cancelar, "", "", True)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", True)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", True)

        Me.ucBarraNavegacion1.CargarOpciones()
        Me.ucVistaDetalleLABFAB_ANALISISXDIA1.Visible = True
        Me.ucVistaDetalleLABFAB_ANALISISXDIA1.LimpiarControles()
        Me.ucVistaDetalleLABFAB_ANALISISXDIA1.ID_ANALISISXDIA = 0
    End Sub


    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
         Select CommandName
            Case "Guardar"
                Dim sError As String
                sError = Me.ucVistaDetalleLABFAB_ANALISISXDIA1.Actualizar()
                If sError <> "" Then
                    AsignarMensaje(sError, True, False)
                    Return
                End If
                AsignarMensaje("", True, False)
                Me.ucVistaDetalleLABFAB_ANALISISXDIA1.LimpiarControles()
                Me.ucVistaDetalleLABFAB_ANALISISXDIA1.ID_ANALISISXDIA = 0
        End Select
    End Sub
End Class
