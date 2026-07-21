Imports SISPACAL.EL
Imports SISPACAL.BL
Imports SISPACAL.EL.Enumeradores

Partial Class controlesMadurante_ucMantSOLIC_APLICA_LOTE
    Inherits ucBase

    Private Sub Inicializar()
        Dim lZafraActiva As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        If lZafraActiva IsNot Nothing Then
            Me.cbxZAFRA.Value = lZafraActiva.ID_ZAFRA
        End If

        Me.ucBarraNavegacion1.PermitirNavegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False

        Me.ucBarraNavegacion1.CrearOpcion("Buscar", "Buscar", False, IconoBarra.Buscar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("GuardarAplicacion", "Aplicar cambio de fecha para lotes marcados", True, "~\imagenes\helicoptero2.png", "", "", False)
        Me.ucBarraNavegacion1.CrearOpcion("Eliminar", "Eliminar aplicación para lotes marcados", False, IconoBarra.Eliminar, "", "", True)
        Me.ucBarraNavegacion1.VerOpcion("Buscar", True)
        Me.ucBarraNavegacion1.VerOpcion("GuardarAplicacion", True)
        Me.ucBarraNavegacion1.VerOpcion("Eliminar", True)
        Me.ucBarraNavegacion1.CargarOpciones()
    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Inicializar()
        End If
    End Sub

    Private Sub Buscar()
        Dim mIdZafra As Int32 = Me.cbxZAFRA.Value
        Dim mNumSolic As Int32 = If(Me.speNUM_SOLICITUD.Value = Nothing, -1, CInt(Me.speNUM_SOLICITUD.Value))
        Dim mCodiProvee As String = IIf(Me.speCODIPROVEE.Value = Nothing, "", Utilerias.FormatearCODIPROVEEDOR(Me.speCODIPROVEE.Value))
        Dim mZona As String = IIf(Me.cbxZONA.Value = Nothing, "", Me.cbxZONA.Value)
        Dim mIdCuentaFinan As Integer = IIf(Me.cbxCUENTA_FINANCIAMIENTO.Value = Nothing, -1, CInt(Me.cbxCUENTA_FINANCIAMIENTO.Value))

        Me.ucListaSOLIC_APLICA_LOTE1.CargarDatosPorCriterios(mIdZafra, "", mNumSolic, mCodiProvee, mZona, mIdCuentaFinan)
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        Select Case CommandName
            Case "Buscar"
                Me.Buscar()

            Case "GuardarAplicacion"
                Dim bSolicAplicaLote As New cSOLIC_APLICA_LOTE
                Dim lista As listaSOLIC_APLICA_LOTE = Me.ucListaSOLIC_APLICA_LOTE1.DevolverSeleccionados


                If lista Is Nothing OrElse lista.Count = 0 Then
                    Me.AsignarMensaje("Seleccione los lotes a los que desea cambiar la fecha de aplicación", False, True, True)
                    Return
                End If
                If Me.dteFECHA_APLICACION.Value Is Nothing Then
                    Me.AsignarMensaje("Ingrese la fecha de aplicación", False, True, True)
                    Return
                End If
                For Each lEntidad As SOLIC_APLICA_LOTE In lista
                    lEntidad.FECHA_APLICA = Me.dteFECHA_APLICACION.Date
                    lEntidad.USUARIO_ACT = Me.ObtenerUsuario
                    lEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
                    bSolicAplicaLote.ActualizarSOLIC_APLICA_LOTE(lEntidad)
                Next
                Me.dteFECHA_APLICACION.Value = Nothing
                Me.AsignarMensaje("Se ha realizado el cambio de fecha de aplicacion", False, True, True)
                Me.Buscar()

            Case "Eliminar"
                Dim bSolicAplicaLote As New cSOLIC_APLICA_LOTE
                Dim lista As listaSOLIC_APLICA_LOTE = Me.ucListaSOLIC_APLICA_LOTE1.DevolverSeleccionados

                If lista Is Nothing OrElse lista.Count = 0 Then
                    Me.AsignarMensaje("Seleccione los lotes a los que desea eliminar la aplicación", False, True, True)
                    Return
                End If
                For Each lEntidad As SOLIC_APLICA_LOTE In lista
                    bSolicAplicaLote.EliminarSOLIC_APLICA_LOTE(lEntidad.ID_SOLIC_APLICA_LOTE)
                Next
                Me.AsignarMensaje("Se han eliminado las aplicaciones seleccionadas", False, True, True)
                Me.Buscar()
        End Select

    End Sub

    Protected Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Me.ucBusquedaProveedor1.Inicializar()
        Me.pcBusquedaProveedor.ShowOnPageLoad = True
    End Sub

    Protected Sub ucBusquedaProveedor1_Aceptar(CODIPROVEEDOR As String) Handles ucBusquedaProveedor1.Aceptar
        Dim lProveedor As PROVEEDOR = (New cPROVEEDOR).ObtenerPROVEEDOR(CODIPROVEEDOR)

        If lProveedor IsNot Nothing Then
            Me.speCODIPROVEE.Text = Utilerias.RecuperarCODIPROVEE(lProveedor.CODIPROVEEDOR)
            Me.txtNOMBRE_PROVEEDOR.Text = lProveedor.NOMBRES + " " + lProveedor.APELLIDOS
        End If
        Me.pcBusquedaProveedor.ShowOnPageLoad = False
    End Sub

    Protected Sub ucBusquedaProveedor1_Cancelar() Handles ucBusquedaProveedor1.Cancelar
        Me.pcBusquedaProveedor.ShowOnPageLoad = False
    End Sub
End Class
