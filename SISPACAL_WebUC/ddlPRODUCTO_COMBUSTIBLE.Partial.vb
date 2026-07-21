Partial Public Class ddlPRODUCTO_COMBUSTIBLE

    Private Sub RecuperarLista(ByVal agregarVacio As Boolean, ByVal agregarTodos As Boolean)
        Dim miComponente As New cPRODUCTO_COMBUSTIBLE
        Dim Lista As New listaPRODUCTO_COMBUSTIBLE

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        If agregarVacio Then
            Dim lEntidad As New PRODUCTO_COMBUSTIBLE
            lEntidad.ID_PRODUCTO = -1
            lEntidad.NOMBRE_PRODUCTO = "[Vacio]"
            Lista.Insertar(0, lEntidad)
        End If

        If agregarTodos Then
            Dim lEntidad As New PRODUCTO_COMBUSTIBLE
            lEntidad.ID_PRODUCTO = -1
            lEntidad.NOMBRE_PRODUCTO = "[Todos]"
            Lista.Insertar(0, lEntidad)
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NOMBRE_PRODUCTO"
        Me.DataValueField = "ID_PRODUCTO"
        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el ComboBox filtrada por los parámetros de la Tabla Padre.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	09/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar(Optional ByVal agregarVacio As Boolean = False, Optional ByVal agregarTodos As Boolean = False)
        RecuperarLista(agregarVacio, agregarTodos)
    End Sub
End Class
