Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_WebUC
''' Class	 : WebUC.ddlAPLICACION_DESCTO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Web
''' de la tabla APLICACION_DESCTO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	01/10/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_APLICACION_DESCTO"), ToolboxData("<{0}:ddlAPLICACION_DESCTO runat=server></{0}:ddlAPLICACION_DESCTO>")> _
Public Class ddlAPLICACION_DESCTO
    Inherits ddlBase

    Private Sub RecuperarLista()
        Dim miComponente As New cAPLICACION_DESCTO
        Dim Lista As New ListaAPLICACION_DESCTO

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NOMBRE_APLICACION_DESCTO"
        Me.DataValueField = "ID_APLICACION_DESCTO"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el DropDownList con los Datos de la Tabla APLICACION_DESCTO.
    ''' </summary>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/10/2013	Created
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
        Dim miComponente As New cAPLICACION_DESCTO
        Dim Lista As New listaAPLICACION_DESCTO

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        If agregarVacio Then
            Dim lEntidad As New APLICACION_DESCTO
            lEntidad.ID_APLICACION_DESCTO = 0
            lEntidad.NOMBRE_APLICACION_DESCTO = " "
            Lista.Insertar(0, lEntidad)
        End If

        If agregarTodos Then
            Dim lEntidad As New APLICACION_DESCTO
            lEntidad.ID_APLICACION_DESCTO = 0
            lEntidad.NOMBRE_APLICACION_DESCTO = "[Todos]"
            Lista.Insertar(0, lEntidad)
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NOMBRE_APLICACION_DESCTO"
        Me.DataValueField = "ID_APLICACION_DESCTO"

        Me.DataBind()
    End Sub

End Class
