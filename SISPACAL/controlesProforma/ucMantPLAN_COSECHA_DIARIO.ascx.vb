Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucMantPLAN_COSECHA_DIARIO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para el Mantenimiento de la tabla PLAN_COSECHA_DIARIO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	16/03/2015	Created
''' </history>  
''' -----------------------------------------------------------------------------
Partial Class controles_ucMantPLAN_COSECHA_DIARIO
    Inherits ucBase


    Private Sub Inicializar()
        Dim bPlanCosechaDiario As New cPLAN_COSECHA_DIARIO
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        Dim lDiaZafra As DIA_ZAFRA = (New cDIA_ZAFRA).ObtenerDiaZafraActivo(lZafra.ID_ZAFRA)
        Dim codiAgron As String = cProceso.ObtenerCODIAGRON(Me.ObtenerUsuario)
        Me.ucBarraNavegacion1.PermitirNavegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucBarraNavegacion1.CrearOpcion("Buscar", "Buscar", False, IconoBarra.Buscar, "", "", True)
        Me.ucBarraNavegacion1.CargarOpciones()
        If lZafra IsNot Nothing Then
            Me.cbxZAFRA.Value = lZafra.ID_ZAFRA
        End If
        If lDiaZafra IsNot Nothing Then Me.speDIAZAFRA.Value = lDiaZafra.DIAZAFRA Else Me.speDIAZAFRA.Value = 1

        If bPlanCosechaDiario.GenerarPropuestaCosechaDiaria(lZafra.ID_ZAFRA, lDiaZafra.FECHA, Me.ObtenerUsuario, cFechaHora.ObtenerFechaHora) < 0 Then
            Me.AsignarMensaje("Error al actualizar el Plan de Cosecha Diario: " + bPlanCosechaDiario.sError, True, False, False)
            Return
        End If
        Me.AsignarMensaje("", True, False, False)
        Me.CargarDatos()
    End Sub

    Private Sub CargarDatos()
        Dim ID_ZAFRA As Int32 = -1
        Dim CODIPROVEE As String = ""
        Dim CODISOCIO As String = ""

        If Me.cbxZAFRA.Value IsNot Nothing Then ID_ZAFRA = cbxZAFRA.Value
        If Me.speCODIPROVEE.Text <> "" Then CODIPROVEE = Utilerias.FormatoCODIPROVEE(CInt(Me.speCODIPROVEE.Text))
        If Me.speCODISOCIO.Text <> "" Then CODISOCIO = Utilerias.FormatoCODISOCIO(CInt(Me.speCODISOCIO.Text))
        Me.ucListaPLAN_COSECHA_DIARIO1.CargarDatosPorCriterios(ID_ZAFRA, Me.cbxZONA.Value, Me.speDIAZAFRA.Value, CODIPROVEE, CODISOCIO, Me.txtNOMBRE_PROVEEDOR.Text.Trim.ToUpper)
    End Sub

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Me.Inicializar()
        End If
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        Select CommandName
            Case "Buscar"
                Me.CargarDatos()
        End Select
    End Sub
End Class
