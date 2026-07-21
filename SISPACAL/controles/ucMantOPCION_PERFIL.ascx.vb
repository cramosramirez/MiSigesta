Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucMantOPCION_PERFIL
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para el Mantenimiento de la tabla OPCION_PERFIL
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	31/08/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucMantOPCION_PERFIL
    Inherits ucBase

#Region "Inicializaciones Mantenimiento"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Inicializa la Lista de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla OPCION_PERFIL
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	31/08/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Inicializar()
        Me.ucBarraNavegacion1.PermitirNavegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucBarraNavegacion1.CrearOpcion("Guardar", "Guardar", True, IconoBarra.Guardar, "", "", True)
        Me.ucBarraNavegacion1.CargarOpciones()
    End Sub

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquÃ­ el cÃ³digo de usuario para inicializar la pÃ¡gina
        If Not IsPostBack Then
            Me.Inicializar()
        End If
    End Sub

    Protected Sub cbxPERFIL_ValueChanged(sender As Object, e As System.EventArgs) Handles cbxPERFIL.ValueChanged
        If Me.cbxPERFIL.Value IsNot Nothing Then
            Me.ucListaOPCION1.ID_PERFIL = Me.cbxPERFIL.Value
        Else
            Me.ucListaOPCION1.ID_PERFIL = -1
        End If
        Me.ucListaOPCION1.PermitirSeleccionar = True
        Me.ucListaOPCION1.PermitirSeleccionarTodos = True
        Me.ucListaOPCION1.PermitirSeleccionarPorCheckBox = True
        Me.ucListaOPCION1.SeleccionarOpcionesPorRol(Me.cbxPERFIL.Value)
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        If CommandName = "Guardar" Then
            Dim sError As String = ""

            If Me.cbxPERFIL.Value Is Nothing Then
                Me.AsignarMensaje("* Seleccione el perfil a modificar", True, False)
                Return
            End If
            sError = Me.ucListaOPCION1.Actualizar()
            If sError <> "" Then
                AsignarMensaje(sError, True, False)
                Return
            End If
            AsignarMensaje("Las opciones asignadas al perfil " + Me.cbxPERFIL.Text + " han sido guardadas", False, True, True)
            Me.ucListaOPCION1.DataBind()
        End If
    End Sub
End Class
