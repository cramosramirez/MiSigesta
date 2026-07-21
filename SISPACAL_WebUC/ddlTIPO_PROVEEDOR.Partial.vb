Partial Public Class ddlTIPO_PROVEEDOR

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
    Public Sub RecuperarParaCombustible(ByVal agregarVacio As Boolean, ByVal agregarTodos As Boolean)
        Dim miComponente As New cTIPO_PROVEEDOR
        Dim Lista As New listaTIPO_PROVEEDOR
        Dim lEntidad As TIPO_PROVEEDOR

        lEntidad = miComponente.ObtenerTIPO_PROVEEDOR(Enumeradores.TipoProveedor.Cañero)
        Lista.Add(lEntidad)
        lEntidad = miComponente.ObtenerTIPO_PROVEEDOR(Enumeradores.TipoProveedor.Transportista)
        Lista.Add(lEntidad)
        lEntidad = New TIPO_PROVEEDOR
        lEntidad.ID_TIPO_PROVEEDOR = 300
        lEntidad.NOMBRE_TIPO_PROVEEDOR = "INJIBOA"
        Lista.Add(lEntidad)
        
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        If agregarVacio Then
            lEntidad = New TIPO_PROVEEDOR
            lEntidad.ID_TIPO_PROVEEDOR = -1
            lEntidad.NOMBRE_TIPO_PROVEEDOR = "[Vacio]"
            Lista.Insertar(0, lEntidad)
        End If

        If agregarTodos Then
            lEntidad = New TIPO_PROVEEDOR
            lEntidad.ID_TIPO_PROVEEDOR = -1
            lEntidad.NOMBRE_TIPO_PROVEEDOR = "[Todos]"
            Lista.Insertar(0, lEntidad)
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NOMBRE_TIPO_PROVEEDOR"
        Me.DataValueField = "ID_TIPO_PROVEEDOR"

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
    Public Sub RecuperarParaCombustible()
        Dim miComponente As New cTIPO_PROVEEDOR
        Dim Lista As New listaTIPO_PROVEEDOR
        Dim lEntidad As TIPO_PROVEEDOR

        lEntidad = miComponente.ObtenerTIPO_PROVEEDOR(Enumeradores.TipoProveedor.Transportista)
        Lista.Add(lEntidad)

        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NOMBRE_TIPO_PROVEEDOR"
        Me.DataValueField = "ID_TIPO_PROVEEDOR"

        Me.DataBind()

    End Sub
End Class
