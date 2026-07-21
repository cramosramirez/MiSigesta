Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_WebUC
''' Class	 : WebUC.ddlTIPO_LECTURA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Web
''' de la tabla TIPO_LECTURA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	18/09/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_TIPO_LECTURA"), ToolboxData("<{0}:ddlTIPO_LECTURA runat=server></{0}:ddlTIPO_LECTURA>")> _
Public Class ddlTIPO_LECTURA
    Inherits ddlBase

    Private Sub RecuperarLista()
        Dim miComponente As New cTIPO_LECTURA
        Dim Lista As New ListaTIPO_LECTURA

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NOMBRE_TIPO_LECTURA"
        Me.DataValueField = "ID_TIPO_LECTURA"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el DropDownList con los Datos de la Tabla TIPO_LECTURA.
    ''' </summary>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar()
        RecuperarLista()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla EQUIPO_MEDICION .
    ''' </summary>
    ''' <param name="ID_EQUIPO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorEQUIPO_MEDICION(ByVal ID_EQUIPO As Int32)
        Dim miComponente As New cTIPO_LECTURA
        Dim Lista As New ListaTIPO_LECTURA

        Lista = miComponente.ObtenerListaPorEQUIPO_MEDICION(ID_EQUIPO)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NOMBRE_TIPO_LECTURA"
        Me.DataValueField = "ID_TIPO_LECTURA"

        Me.DataBind()

    End Sub

End Class
