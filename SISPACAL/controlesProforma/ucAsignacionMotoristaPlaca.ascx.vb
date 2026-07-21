Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores


Partial Class controlesProforma_ucAsignacionMotoristaPlaca
    Inherits ucBase


    Private Function ActualizarSeleccionMotorista() As String
        Try
            Dim lTransporteMotoristas As listaMOTORISTA_VEHICULO
            Dim lMotoristasSelect As listaMOTORISTA
            Dim idTransporte As Int32 = -1
            Dim lPlacas As listaTRANSPORTE
            Dim lCargaBefore As New List(Of Int32)
            Dim lCargaAfter As New List(Of Int32)
            Dim bTransporteAsignada As New cMOTORISTA_VEHICULO
            Dim lMotoristaAsignado As MOTORISTA_VEHICULO

            lPlacas = Me.ucListaTRANSPORTE1.DevolverSeleccionados
            If lPlacas IsNot Nothing AndAlso lPlacas.Count > 0 Then
                idTransporte = lPlacas(0).ID_TRANSPORTE
            End If
            If idTransporte = -1 Then Return ""

            'Placas ya asignadas
            lTransporteMotoristas = bTransporteAsignada.ObtenerListaPorTRANSPORTE(idTransporte)
            If lTransporteMotoristas IsNot Nothing AndAlso lTransporteMotoristas.Count > 0 Then
                For Each aEntidad As MOTORISTA_VEHICULO In lTransporteMotoristas
                    lCargaBefore.Add(aEntidad.ID_MOTORISTA)
                Next
            End If

            'Motoristas a asignar
            lMotoristasSelect = ucListaMOTORISTA1.DevolverSeleccionados
            If lMotoristasSelect IsNot Nothing AndAlso lMotoristasSelect.Count > 0 Then
                For Each aEntidad As MOTORISTA In lMotoristasSelect
                    lCargaAfter.Add(aEntidad.ID_MOTORISTA)
                Next
            End If

            'Agregar motoristas que no estén asignados
            For i As Int32 = 0 To lCargaAfter.Count - 1
                If Not lCargaBefore.Contains(lCargaAfter(i)) Then
                    lMotoristaAsignado = New MOTORISTA_VEHICULO
                    lMotoristaAsignado.ID_MOTORISTA_VEHI = 0
                    lMotoristaAsignado.ID_TRANSPORTE = idTransporte
                    lMotoristaAsignado.ID_MOTORISTA = lCargaAfter(i)
                    lMotoristaAsignado.USUARIO_CREA = Me.ObtenerUsuario
                    lMotoristaAsignado.FECHA_CREA = cFechaHora.ObtenerFechaHora
                    bTransporteAsignada.ActualizarMOTORISTA_VEHICULO(lMotoristaAsignado)
                End If
            Next

            'Quitar operadores que no se seleccionaron
            For i As Int32 = 0 To lCargaBefore.Count - 1
                If Not lCargaAfter.Contains(lCargaBefore(i)) Then
                    Dim lEntidad As MOTORISTA_VEHICULO = bTransporteAsignada.ObtenerMOTORISTA_VEHICULOPorTRANSPORTE_MOTORISTA(idTransporte, lCargaBefore(i))
                    If lEntidad IsNot Nothing Then bTransporteAsignada.EliminarMOTORISTA_VEHICULO(lEntidad.ID_MOTORISTA_VEHI)
                End If
            Next
            Return ""

        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Private Sub CargarMotoristasAsignadosPlaca()
        Dim idTransporte As Int32 = -1
        Dim lTransporte As listaTRANSPORTE
        Dim lMotoristasXTransporte As listaMOTORISTA_VEHICULO

        
        lTransporte = Me.ucListaTRANSPORTE1.DevolverSeleccionados
        If lTransporte IsNot Nothing AndAlso lTransporte.Count > 0 Then
            idTransporte = lTransporte(0).ID_TRANSPORTE
        End If
        lMotoristasXTransporte = (New cMOTORISTA_VEHICULO).ObtenerListaPorTRANSPORTE(idTransporte)

        If Me.chkVerSoloAsignados.Checked Then
            Me.ucListaMOTORISTA1.CargarDatosPorTRANSPORTE(idTransporte)
        Else
            Me.ucListaMOTORISTA1.CargarDatos()
        End If
        Me.ucListaMOTORISTA1.QuitarSeleccion()

        For Each lEntidad As MOTORISTA_VEHICULO In lMotoristasXTransporte
            Me.ucListaMOTORISTA1.SeleccionarFila = lEntidad.ID_MOTORISTA
        Next
    End Sub

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Me.Inicializar()
        End If
        Me.ucListaTRANSPORTE1.CargarDatos()
    End Sub

    Private Sub Inicializar()
        Me.ucBarraNavegacion1.PermitirNavegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucBarraNavegacion1.CrearOpcion("Guardar", "Guardar", True, IconoBarra.Guardar, "", "", True)
        Me.ucBarraNavegacion1.CargarOpciones()
    End Sub

    Protected Sub ucListaTRANSPORTE1_Seleccionado(ID_TRANSPORTE As Integer) Handles ucListaTRANSPORTE1.Seleccionado
        Me.CargarMotoristasAsignadosPlaca()
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        Select Case CommandName
            Case "Guardar"
                Dim sError As String = ""

                sError = Me.ActualizarSeleccionMotorista()
                If sError <> "" Then
                    AsignarMensaje(sError, True, False)
                    Return
                End If
                AsignarMensaje("", True, False)
                AsignarMensaje("Se guardo la asignacion para la Placa", False, True, True)
                Me.CargarMotoristasAsignadosPlaca()
        End Select
    End Sub

    Protected Sub chkVerSoloAsignados_CheckedChanged(sender As Object, e As EventArgs) Handles chkVerSoloAsignados.CheckedChanged
        Me.CargarMotoristasAsignadosPlaca()
    End Sub
End Class
