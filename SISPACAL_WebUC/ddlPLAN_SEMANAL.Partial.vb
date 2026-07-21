Partial Public Class ddlPLAN_SEMANAL

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla PLAN_CATORCENA .
    ''' </summary>
    ''' <param name="ID_PLAN_CATORCENA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorPLAN_CATORCENA(ByVal ID_PLAN_CATORCENA As Int32)
        Dim miComponente As New cPLAN_SEMANAL
        Dim Lista As New ListaPLAN_SEMANAL

        Lista = miComponente.ObtenerListaPorPLAN_CATORCENA(ID_PLAN_CATORCENA)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "DESCRIPCION_FECHAS"
        Me.DataValueField = "ID_PLAN_SEMANAL"

        Me.DataBind()

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el DropDownList con los Datos de la Tabla TIPO_CANA.
    ''' </summary>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/08/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorPLAN_CATORCENA(ByVal ID_PLAN_CATORCENA As Int32, ByVal agregarVacio As Boolean, ByVal agregarTodos As Boolean)
        Dim miComponente As New cPLAN_SEMANAL
        Dim Lista As New listaPLAN_SEMANAL

        Lista = miComponente.ObtenerListaPorPLAN_CATORCENA(ID_PLAN_CATORCENA)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        If agregarVacio Then
            Dim lEntidad As New PLAN_SEMANAL
            lEntidad.ID_PLAN_SEMANAL = 0
            lEntidad.DESCRIPCION_FECHAS = " "
            Lista.Insertar(0, lEntidad)
        End If

        If agregarTodos Then
            Dim lEntidad As New PLAN_SEMANAL
            lEntidad.ID_PLAN_SEMANAL = 0
            lEntidad.DESCRIPCION_FECHAS = "[Todos]"
            Lista.Insertar(0, lEntidad)
        End If

        Me.DataSource = Lista
        Me.DataTextField = "DESCRIPCION_FECHAS"
        Me.DataValueField = "ID_PLAN_SEMANAL"

        Me.DataBind()
    End Sub
End Class
