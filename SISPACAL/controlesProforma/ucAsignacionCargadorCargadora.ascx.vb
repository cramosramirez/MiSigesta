Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores

Partial Class controlesProforma_ucAsignacionCargadorCargadora
    Inherits ucBase

    Private Function ActualizarSeleccionCargador() As String
        Try
            Dim lCargadorasOperadores As listaCARGADORA_ASIGNADA
            Dim lOperadoresSelect As listaCARGADOR
            Dim idCargadora As Int32 = -1
            Dim idZafra As Int32 = -1
            Dim lCargadoras As listaCARGADORA
            Dim lCargaBefore As New List(Of Int32)
            Dim lCargaAfter As New List(Of Int32)
            Dim bCargadoraAsignada As New cCARGADORA_ASIGNADA
            Dim lCargadoraAsignada As CARGADORA_ASIGNADA

            If Me.cbxZAFRA.Value IsNot Nothing Then idZafra = CInt(Me.cbxZAFRA.Value)
            lCargadoras = Me.ucListaCARGADORA1.DevolverSeleccionados
            If lCargadoras IsNot Nothing AndAlso lCargadoras.Count > 0 Then
                idCargadora = lCargadoras(0).ID_CARGADORA
            End If
            If idZafra = -1 OrElse idCargadora = -1 Then Return ""

            'Cargadoras ya asignadas
            lCargadorasOperadores = bCargadoraAsignada.ObtenerListaPorZAFRA_CARGADORA(idZafra, idCargadora)
            If lCargadorasOperadores IsNot Nothing AndAlso lCargadorasOperadores.Count > 0 Then
                For Each aEntidad As CARGADORA_ASIGNADA In lCargadorasOperadores
                    lCargaBefore.Add(aEntidad.ID_CARGADOR)
                Next
            End If

            'Operadores a asignar
            lOperadoresSelect = ucListaCARGADOR1.DevolverSeleccionados
            If lOperadoresSelect IsNot Nothing AndAlso lOperadoresSelect.Count > 0 Then
                For Each aEntidad As CARGADOR In lOperadoresSelect
                    lCargaAfter.Add(aEntidad.ID_CARGADOR)
                Next
            End If

            'Agregar operadores que no estén asignadas
            For i As Int32 = 0 To lCargaAfter.Count - 1
                If Not lCargaBefore.Contains(lCargaAfter(i)) Then
                    lCargadoraAsignada = New CARGADORA_ASIGNADA
                    lCargadoraAsignada.ID_ZAFRA = idZafra
                    lCargadoraAsignada.ID_CARGADORA = idCargadora
                    lCargadoraAsignada.ID_CARGADOR = lCargaAfter(i)
                    lCargadoraAsignada.USUARIO_CREA = Me.ObtenerUsuario
                    lCargadoraAsignada.FECHA_CREA = cFechaHora.ObtenerFechaHora
                    lCargadoraAsignada.USUARIO_ACT = Me.ObtenerUsuario
                    lCargadoraAsignada.FECHA_ACT = cFechaHora.ObtenerFechaHora
                    bCargadoraAsignada.ActualizarCARGADORA_ASIGNADA(lCargadoraAsignada)
                End If
            Next

            'Quitar operadores que no se seleccionaron
            For i As Int32 = 0 To lCargaBefore.Count - 1
                If Not lCargaAfter.Contains(lCargaBefore(i)) Then
                    Dim lEntidad As CARGADORA_ASIGNADA = bCargadoraAsignada.ObtenerCARGADORA_ASIGNADA(idZafra, idCargadora, lCargaBefore(i))
                    If lEntidad IsNot Nothing Then bCargadoraAsignada.EliminarCARGADORA_ASIGNADA(lEntidad.ID_CARGADORA_ASIG)
                End If
            Next

        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Private Sub CargarOperadoresAsignadosCargadora()
        Dim idCargadora As Int32 = -1
        Dim idZafra As Int32 = -1
        Dim lCargadoras As listaCARGADORA
        Dim lOperadoresXZona As listaCARGADORA_ASIGNADA

        Me.ucListaCARGADOR1.CargarDatos()
        Me.ucListaCARGADOR1.QuitarSeleccion()
        If Me.cbxZAFRA.Value IsNot Nothing Then idZafra = CInt(Me.cbxZAFRA.Value)
        lCargadoras = Me.ucListaCARGADORA1.DevolverSeleccionados
        If lCargadoras IsNot Nothing AndAlso lCargadoras.Count > 0 Then
            idCargadora = lCargadoras(0).ID_CARGADORA
        End If
        lOperadoresXZona = (New cCARGADORA_ASIGNADA).ObtenerListaPorZAFRA_CARGADORA(idZafra, idCargadora)

        For Each lEntidad As CARGADORA_ASIGNADA In lOperadoresXZona
            Me.ucListaCARGADOR1.SeleccionarFila = lEntidad.ID_CARGADOR
        Next
    End Sub

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Me.Inicializar()
        End If
        Me.ucListaCARGADORA1.CargarDatos()
        Me.ucListaCARGADOR1.CargarDatos()
    End Sub

    Private Sub Inicializar()
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        If lZafra IsNot Nothing Then
            Me.cbxZAFRA.Value = lZafra.ID_ZAFRA
            Me.ucListaCARGADORA1.Filtro = "[TIPO_CARGADORA] = 'INJIBOA'"
            Me.ucListaCARGADOR1.Filtro = "[ES_EMPLEADO_INGENIO] = True"

        End If
        Me.ucBarraNavegacion1.PermitirNavegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucBarraNavegacion1.CrearOpcion("Guardar", "Guardar", True, IconoBarra.Guardar, "", "", True)
        Me.ucBarraNavegacion1.CargarOpciones()
    End Sub

    Protected Sub cbxZAFRA_ValueChanged(sender As Object, e As System.EventArgs) Handles cbxZAFRA.ValueChanged
        Me.ucListaCARGADORA1.QuitarSeleccion()
        Me.ucListaCARGADOR1.QuitarSeleccion()
    End Sub

    Protected Sub ucListaCARGADORA1_Seleccionado(ID_CARGADORA As Integer) Handles ucListaCARGADORA1.Seleccionado
        Me.CargarOperadoresAsignadosCargadora()
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        Select Case CommandName
            Case "Guardar"
                Dim sError As String = ""

                sError = Me.ActualizarSeleccionCargador()
                If sError <> "" Then
                    AsignarMensaje(sError, True, False)
                    Return
                End If
                AsignarMensaje("", True, False)
                AsignarMensaje("Se guarda la asignación para la Cargadora", False, True, True)
                Me.CargarOperadoresAsignadosCargadora()
        End Select
    End Sub
End Class
