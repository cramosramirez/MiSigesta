Partial Public Class ddlCATORCENA_ZAFRA

    Public Sub RecuperarCatorcenaActiva(ByVal ID_ZAFRA As Int32)
        Dim miComponente As New cCATORCENA_ZAFRA
        Dim Lista As New listaCATORCENA_ZAFRA
        Dim lEntidad As CATORCENA_ZAFRA = miComponente.ObtenerCatorcenaActiva(ID_ZAFRA)

        If lEntidad IsNot Nothing Then
            Lista.Add(lEntidad)
        End If
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "CATORCENA"
        Me.DataValueField = "ID_CATORCENA"

        Me.DataBind()

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla CATORCENA_ZAFRA .
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/01/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorZAFRA(ByVal ID_ZAFRA As Int32, ByVal agregarVacio As Boolean, ByVal agregarTodos As Boolean)

        Dim miComponente As New cCATORCENA_ZAFRA
        Dim Lista As New listaCATORCENA_ZAFRA
        Dim lEntidad As CATORCENA_ZAFRA

        Lista = miComponente.ObtenerListaPorZAFRA(ID_ZAFRA)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
        End If

        If agregarVacio Then
            lEntidad = New CATORCENA_ZAFRA
            lEntidad.ID_CATORCENA = -1
            lEntidad.NO_CATORCENA = "[SIN CATORCENA]"
            Lista.Insertar(0, lEntidad)
        End If

        If agregarTodos Then
            lEntidad = New CATORCENA_ZAFRA
            lEntidad.ID_CATORCENA = -1
            lEntidad.NO_CATORCENA = "[TODOS]"
            Lista.Insertar(0, lEntidad)
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NO_CATORCENA"
        Me.DataValueField = "ID_CATORCENA"

        Me.DataBind()
    End Sub
End Class
