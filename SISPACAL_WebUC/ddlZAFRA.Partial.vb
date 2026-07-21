Partial Public Class ddlZAFRA
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el DropDownList con los Datos de la Tabla ZAFRA.
    ''' </summary>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	15/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarZafraActiva()
        Dim miComponente As New cZAFRA
        Dim Lista As New listaZAFRA
        Dim lEntidad As ZAFRA

        lEntidad = miComponente.ObtenerZafraActiva
        If lEntidad Is Nothing Then
            Me.Items.Clear()
            Return
        End If
        Lista.Add(lEntidad)

        Me.DataSource = Lista
        Me.DataTextField = "NOMBRE_ZAFRA"
        Me.DataValueField = "ID_ZAFRA"

        Me.DataBind()
    End Sub
End Class
