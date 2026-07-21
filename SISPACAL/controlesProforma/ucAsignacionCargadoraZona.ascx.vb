Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores

Partial Class controlesProforma_ucAsignacionCargadoraZona
    Inherits ucBase

    Private Function ActualizarSeleccionCargadoras() As String
        Try

            Dim lCargadorasXZona As listaZONA_CARGADORA
            Dim lCargadorasSelect As listaCARGADORA
            Dim sZona As String = ""
            Dim idZafra As Int32 = -1
            Dim lZonas As listaZONAS
            Dim lCargaBefore As New List(Of Int32)
            Dim lCargaAfter As New List(Of Int32)
            Dim bZonaCargadora As New cZONA_CARGADORA
            Dim lZonaCargadora As ZONA_CARGADORA

            If Me.cbxZAFRA.Value IsNot Nothing Then idZafra = CInt(Me.cbxZAFRA.Value)
            lZonas = Me.ucListaZONAS1.DevolverSeleccionados
            If lZonas IsNot Nothing AndAlso lZonas.Count > 0 Then
                sZona = lZonas(0).ZONA
            End If
            If idZafra = -1 OrElse sZona = "" Then Return ""

            'Cargadoras ya asignadas
            lCargadorasXZona = (New cZONA_CARGADORA).ObtenerListaPorZAFRA_ZONA(idZafra, sZona)
            If lCargadorasXZona IsNot Nothing AndAlso lCargadorasXZona.Count > 0 Then
                For Each aEntidad As ZONA_CARGADORA In lCargadorasXZona
                    lCargaBefore.Add(aEntidad.ID_CARGADORA)
                Next
            End If

            'Cargadoras a asignar
            lCargadorasSelect = ucListaCARGADORA1.DevolverSeleccionados
            If lCargadorasSelect IsNot Nothing AndAlso lCargadorasSelect.Count > 0 Then
                For Each aEntidad As CARGADORA In lCargadorasSelect
                    lCargaAfter.Add(aEntidad.ID_CARGADORA)
                Next
            End If

            'Agregar cargadoras que no estén asignadas
            For i As Int32 = 0 To lCargaAfter.Count - 1
                If Not lCargaBefore.Contains(lCargaAfter(i)) Then
                    lZonaCargadora = New ZONA_CARGADORA
                    lZonaCargadora.ID_ZAFRA = idZafra
                    lZonaCargadora.ZONA = sZona
                    lZonaCargadora.ID_CARGADORA = lCargaAfter(i)
                    lZonaCargadora.USUARIO_ACT = Me.ObtenerUsuario
                    lZonaCargadora.FECHA_ACT = cFechaHora.ObtenerFechaHora
                    bZonaCargadora.ActualizarZONA_CARGADORA(lZonaCargadora)
                End If
            Next

            'Quitar cargadoras que no se seleccionaron
            For i As Int32 = 0 To lCargaBefore.Count - 1
                If Not lCargaAfter.Contains(lCargaBefore(i)) Then
                    Dim lEntidad As ZONA_CARGADORA = (New cZONA_CARGADORA).ObtenerZONA_CARGADORA(idZafra, sZona, lCargaBefore(i))
                    If lEntidad IsNot Nothing Then bZonaCargadora.EliminarZONA_CARGADORA(lEntidad.ID_ZONA_CARGA)
                End If
            Next
            Return ""

        Catch ex As Exception
            Return ex.Message
        End Try
        
    End Function

    Private Sub CargarCargadorasAsignadasZona()
        Dim sZona As String = ""
        Dim idZafra As Int32 = -1
        Dim lZonas As listaZONAS
        Dim lCargadorasXZona As listaZONA_CARGADORA

        Me.ucListaCARGADORA1.CargarDatos()
        Me.ucListaCARGADORA1.QuitarSeleccion()
        If Me.cbxZAFRA.Value IsNot Nothing Then idZafra = CInt(Me.cbxZAFRA.Value)
        lZonas = Me.ucListaZONAS1.DevolverSeleccionados
        If lZonas IsNot Nothing AndAlso lZonas.Count > 0 Then
            sZona = lZonas(0).ZONA
        End If
        lCargadorasXZona = (New cZONA_CARGADORA).ObtenerListaPorZAFRA_ZONA(idZafra, sZona)

        For Each lEntidad As ZONA_CARGADORA In lCargadorasXZona
            Me.ucListaCARGADORA1.SeleccionarFila = lEntidad.ID_CARGADORA
        Next
    End Sub

    Private Sub Inicializar()
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        If lZafra IsNot Nothing Then
            Me.cbxZAFRA.Value = lZafra.ID_ZAFRA
            Me.ucListaCARGADORA1.Filtro = "[TIPO_CARGADORA] = 'INJIBOA'"
            Me.ucListaZONAS1.CargarDatosZONAS_ACTIVAS()
        End If
        Me.ucBarraNavegacion1.PermitirNavegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucBarraNavegacion1.CrearOpcion("Guardar", "Guardar", True, IconoBarra.Guardar, "", "", True)
        Me.ucBarraNavegacion1.CargarOpciones()
    End Sub

    Protected Sub cbxZAFRA_ValueChanged(sender As Object, e As System.EventArgs) Handles cbxZAFRA.ValueChanged
        Me.ucListaZONAS1.QuitarSeleccion()
        'Me.ucListaCARGADORA1.QuitarFiltros()
        Me.ucListaCARGADORA1.QuitarSeleccion()
    End Sub

    Protected Sub ucListaZONAS1_Seleccionado(ZONA As String) Handles ucListaZONAS1.Seleccionado
        Me.CargarCargadorasAsignadasZona()
    End Sub

    Protected Sub Page_PreRender(sender As Object, e As System.EventArgs) Handles Me.PreRender
        If Not IsPostBack Then
            Me.Inicializar()
        End If
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        Select CommandName
            Case "Guardar"
                Dim sError As String = ""

                sError = Me.ActualizarSeleccionCargadoras()
                If sError <> "" Then
                    AsignarMensaje(sError, True, False)
                    Return
                End If
                AsignarMensaje("", True, False)
                AsignarMensaje("Se guarda la asignación para la Zona", False, True, True)
                Me.CargarCargadorasAsignadasZona()
        End Select
    End Sub
End Class
