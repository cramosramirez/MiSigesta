Imports System.Data
Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.DL
Imports System.Collections.Generic

Partial Class controles_ucTarifaRoza
    Inherits ucBase

    Public Property NOMBRE_ZAFRA As String
        Get
            If Me.ViewState("NOMBRE_ZAFRA") Is Nothing Then Return ""
            Return Me.ViewState("NOMBRE_ZAFRA")
        End Get
        Set(ByVal value As String)
            Me.ViewState("NOMBRE_ZAFRA") = value
        End Set
    End Property

    Public Sub Inicializar()
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        If lZafra IsNot Nothing Then
            Me.cbxZAFRA.Value = lZafra.ID_ZAFRA
            Me.NOMBRE_ZAFRA = lZafra.NOMBRE_ZAFRA
        End If
        Me.cbxZAFRA.ClientEnabled = False
        Me.lblTitulo.Text = "Tarifa Servicio de Roza"
        Me.ucBarraNavegacion1.PermitirNavegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucBarraNavegacion1.CrearOpcion("Buscar", "Buscar", False, Enumeradores.IconoBarra.Buscar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Aplicar", "Aplicar", False, Enumeradores.IconoBarra.Aplicar, "", "", True)
        Me.ucBarraNavegacion1.VerOpcion("Aplicar", True)
        Me.ucBarraNavegacion1.CargarOpciones()
    End Sub

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Me.Inicializar()
        End If
    End Sub

    Public Sub CargarLotesPorCriterios()
        Dim sCodiProvee As String = ""
        Dim sCodiSocio As String = ""

        If Me.speCODIPROVEE.Value IsNot Nothing AndAlso Me.speCODIPROVEE.Value <> 0 Then sCodiProvee = Utilerias.FormatoCODIPROVEE(Me.speCODIPROVEE.Value)
        If Me.speCODISOCIO.Value IsNot Nothing AndAlso Me.speCODISOCIO.Value <> 0 Then sCodiSocio = Utilerias.FormatoCODISOCIO(Me.speCODISOCIO.Value)
        Me.ucListaLOTES_COSECHA1.CargarDatosPorCriterios(Me.cbxZAFRA.Value, Me.cbxZONA.Value, sCodiProvee, sCodiSocio, Me.txtNOMBRE_PRODUCTOR.Text, "", -1, "", Me.ObtenerUsuario)
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        AsignarMensaje("", True, False)
        Select Case CommandName
            Case "Buscar"
                Me.CargarLotesPorCriterios()

            Case "Aplicar"
                Dim lstLotesCosecha As listaLOTES_COSECHA = Me.ucListaLOTES_COSECHA1.DevolverSeleccionados
                Dim bLotesCosecha As New cLOTES_COSECHA

                If Me.speTARIFA_ROZA.Value Is Nothing OrElse Me.speTARIFA_ROZA.Value = 0 Then
                    Me.AsignarMensaje("Ingrese la tarifa de roza a aplicar", False, True, True)
                    Return
                End If

                If lstLotesCosecha IsNot Nothing AndAlso lstLotesCosecha.Count > 0 Then
                    For i As Int32 = 0 To lstLotesCosecha.Count - 1
                        Dim lEntidad As LOTES_COSECHA = (New cLOTES_COSECHA).ObtenerLOTES_COSECHA(lstLotesCosecha(i).ID_LOTES_COSECHA)
                        If lEntidad IsNot Nothing Then
                            lEntidad.TARIFA_ROZA = CDec(Me.speTARIFA_ROZA.Value)
                            bLotesCosecha.ActualizarLOTES_COSECHA(lEntidad)
                        End If
                    Next
                    Me.CargarLotesPorCriterios()
                    Me.speTARIFA_ROZA.Value = Nothing
                    Me.chkTodosLotes.Checked = False
                    Me.ucListaLOTES_COSECHA1.QuitarSelecciones()
                    Me.AsignarMensaje("Tarifa aplicada con exito", False, True, True)
                Else
                    Me.AsignarMensaje("No se han seleccionado lotes", False, True, True)
                End If
        End Select
    End Sub

    Protected Sub chkTodosLotes_CheckedChanged(sender As Object, e As EventArgs) Handles chkTodosLotes.CheckedChanged
        If Me.chkTodosLotes.Checked Then
            Me.ucListaLOTES_COSECHA1.SeleccionarTodos()
        Else
            Me.ucListaLOTES_COSECHA1.QuitarSelecciones()
        End If
    End Sub
End Class
