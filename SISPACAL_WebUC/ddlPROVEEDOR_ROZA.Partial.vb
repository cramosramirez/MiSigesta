Partial Public Class ddlPROVEEDOR_ROZA
    Public Sub Recuperar(ByVal agregarVacio As Boolean, ByVal agregarTodos As Boolean)
        Dim miComponente As New cPROVEEDOR_ROZA
        Dim Lista As New listaPROVEEDOR_ROZA

        Lista = miComponente.ObtenerLista(False, False, "NOMBRE_PROVEEDOR_ROZA")
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
        End If

        If agregarVacio Then
            Dim lEntidad As New PROVEEDOR_ROZA
            lEntidad.ID_PROVEEDOR_ROZA = -1
            lEntidad.NOMBRE_PROVEEDOR_ROZA = " "
            Lista.Insertar(0, lEntidad)
        End If

        If agregarTodos Then
            Dim lEntidad As New PROVEEDOR_ROZA
            lEntidad.ID_PROVEEDOR_ROZA = -1
            lEntidad.NOMBRE_PROVEEDOR_ROZA = "[Todos]"
            Lista.Insertar(0, lEntidad)
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NOMBRE_PROVEEDOR_ROZA"
        Me.DataValueField = "ID_PROVEEDOR_ROZA"

        Me.DataBind()
    End Sub
End Class
