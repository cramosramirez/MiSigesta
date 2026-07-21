Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores
Imports System.Collections.Generic

Partial Class controles_ucPlanillaAnticipos
    Inherits ucBase

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Inicializar()
        End If
    End Sub

    Private Sub Inicializar()
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        Me.ddlZAFRAID_ZAFRA.Recuperar()

        If lZafra IsNot Nothing Then
            Me.ddlZAFRAID_ZAFRA.SelectedValue = lZafra.ID_ZAFRA

            'Recuperar catorcena por Zafra
            Me.ddlCATORCENA_ZAFRA1.RecuperarPorZAFRA(lZafra.ID_ZAFRA, True, False)

            Dim lCatorcena As CATORCENA_ZAFRA
            lCatorcena = (New cCATORCENA_ZAFRA).ObtenerUltimaCatorcenaCerradaZafra(ddlZAFRAID_ZAFRA.SelectedValue)
            If lCatorcena IsNot Nothing Then Me.ddlCATORCENA_ZAFRA1.SelectedValue = lCatorcena.ID_CATORCENA
        End If
        Me.lblTitulo.Text = "Generar Planilla de Anticipo"
        Me.ucBarraNavegacion1.PermitirNavegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucBarraNavegacion1.CrearOpcion("Generar", "Generar", False, IconoBarra.Generar, "", "", True)
        Me.ucBarraNavegacion1.VerOpcion("Generar", True)
        Me.ucBarraNavegacion1.CargarOpciones()
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        If CommandName = "Generar" Then
            If Me.ddlZAFRAID_ZAFRA.SelectedValue Is Nothing Then
                Me.AsignarMensaje("* Seleccione la zafra", True)
                Return
            End If
            If Me.ddlCATORCENA_ZAFRA1.SelectedValue Is Nothing Then
                Me.AsignarMensaje("* Seleccione la catorcena", True)
                Return
            End If
            If Not Utilerias.EsNumeroEntero(Me.txtNO_ANTICIPO.Text) Then
                Me.AsignarMensaje("* El numero de anticipo debe ser numerico", True)
                Return
            End If
            If Me.txtCONCEPTO.Text.Trim = "" Then
                Me.AsignarMensaje("* Ingrese el concepto del anticipo", True)
                Return
            End If
            If Not IsNumeric(Me.txtVALOR_ANTICIPO.Text) Then
                Me.AsignarMensaje("* El valor del anticipo debe ser numerico", True)
                Return
            Else
                Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZAFRA(Me.ddlZAFRAID_ZAFRA.SelectedValue)
                If lZafra IsNot Nothing Then
                    If Convert.ToDecimal(Me.txtVALOR_ANTICIPO.Text) > lZafra.PRECIO_LIBRA_AZUCAR Then
                        Me.AsignarMensaje("* El valor del anticipo no puede ser mayor que el VIP", True)
                        Return
                    End If
                End If
            End If
          
            'Generar/Regenerar planilla
            Dim bPlanilla As New cPLANILLA
            Dim lRet As Integer

            lRet = bPlanilla.GenerarPlanillaAnticipoCaneros(Convert.ToInt32(Me.ddlZAFRAID_ZAFRA.SelectedValue), Convert.ToInt32(Me.ddlCATORCENA_ZAFRA1.SelectedValue), Convert.ToInt32(Me.txtNO_ANTICIPO.Text), Convert.ToDecimal(Me.txtVALOR_ANTICIPO.Text), Me.txtCONCEPTO.Text.Trim)
            If lRet <= 0 Then
                MostrarMensaje("No se logro generar la planilla", "Error")
                Return
            End If
            Me.txtNO_ANTICIPO.Text = ""
            Me.txtVALOR_ANTICIPO.Text = ""
            Me.txtCONCEPTO.Text = ""
            MostrarMensaje("La planilla de anticipos fue generada con exito!", "Error")
        End If
    End Sub

    Protected Sub ddlZAFRAID_ZAFRA_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles ddlZAFRAID_ZAFRA.SelectedIndexChanged
        'Recuperar catorcena por Zafra
        Me.ddlCATORCENA_ZAFRA1.RecuperarPorZAFRA(ddlZAFRAID_ZAFRA.SelectedValue, True, False)

        Dim lCatorcena As CATORCENA_ZAFRA
        lCatorcena = (New cCATORCENA_ZAFRA).ObtenerUltimaCatorcenaCerradaZafra(ddlZAFRAID_ZAFRA.SelectedValue)
        If lCatorcena IsNot Nothing Then Me.ddlCATORCENA_ZAFRA1.SelectedValue = lCatorcena.ID_CATORCENA
    End Sub
End Class
