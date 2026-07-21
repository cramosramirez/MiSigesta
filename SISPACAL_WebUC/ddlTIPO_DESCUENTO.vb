Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_WebUC
''' Class	 : WebUC.ddlTIPO_DESCUENTO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Web
''' de la tabla TIPO_DESCUENTO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	01/11/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_TIPO_DESCTO"), ToolboxData("<{0}:ddlTIPO_DESCUENTO runat=server></{0}:ddlTIPO_DESCUENTO>")> _
Public Class ddlTIPO_DESCUENTO
    Inherits ddlBase

    Private Sub RecuperarLista()
        Dim miComponente As New cTIPO_DESCUENTO
        Dim Lista As New ListaTIPO_DESCUENTO

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NOMBRE_TIPO_DESCTO"
        Me.DataValueField = "ID_TIPO_DESCTO"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el DropDownList con los Datos de la Tabla TIPO_DESCUENTO.
    ''' </summary>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar()
        RecuperarLista()
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
    Public Sub Recuperar(ByVal agregarVacio As Boolean, ByVal agregarTodos As Boolean)
        Dim miComponente As New cTIPO_DESCUENTO
        Dim Lista As New listaTIPO_DESCUENTO

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        If agregarVacio Then
            Dim lEntidad As New TIPO_DESCUENTO
            lEntidad.ID_TIPO_DESCTO = 0
            lEntidad.NOMBRE_TIPO_DESCTO = " "
            Lista.Insertar(0, lEntidad)
        End If

        If agregarTodos Then
            Dim lEntidad As New TIPO_DESCUENTO
            lEntidad.ID_TIPO_DESCTO = 0
            lEntidad.NOMBRE_TIPO_DESCTO = "[Todos]"
            Lista.Insertar(0, lEntidad)
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NOMBRE_TIPO_DESCTO"
        Me.DataValueField = "ID_TIPO_DESCTO"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla GRUPO_DESCUENTOS .
    ''' </summary>
    ''' <param name="ID_GRUPO_DESC"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorGRUPO_DESCUENTOS(ByVal ID_GRUPO_DESC As Int32)
        Dim miComponente As New cTIPO_DESCUENTO
        Dim Lista As New ListaTIPO_DESCUENTO

        Lista = miComponente.ObtenerListaPorGRUPO_DESCUENTOS(ID_GRUPO_DESC)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NOMBRE_TIPO_DESCTO"
        Me.DataValueField = "ID_TIPO_DESCTO"

        Me.DataBind()

    End Sub

End Class
