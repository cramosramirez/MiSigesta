Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_WebUC
''' Class	 : WebUC.ddlEQUIPO_MEDICION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Web
''' de la tabla EQUIPO_MEDICION
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	18/09/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_EQUIPO"), ToolboxData("<{0}:ddlEQUIPO_MEDICION runat=server></{0}:ddlEQUIPO_MEDICION>")> _
Public Class ddlEQUIPO_MEDICION
    Inherits ddlBase

    Private Sub RecuperarLista()
        Dim miComponente As New cEQUIPO_MEDICION
        Dim Lista As New ListaEQUIPO_MEDICION

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NOMBRE_EQUIPO"
        Me.DataValueField = "ID_EQUIPO"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el DropDownList con los Datos de la Tabla EQUIPO_MEDICION.
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

End Class
