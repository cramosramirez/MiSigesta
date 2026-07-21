Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_WebUC
''' Class	 : WebUC.ddlPLAN_SEMANAL
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Web
''' de la tabla PLAN_SEMANAL
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	21/10/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_PLAN_SEMANAL"), ToolboxData("<{0}:ddlPLAN_SEMANAL runat=server></{0}:ddlPLAN_SEMANAL>")> _
Public Class ddlPLAN_SEMANAL
    Inherits ddlBase

    Private Sub RecuperarLista()
        Dim miComponente As New cPLAN_SEMANAL
        Dim Lista As New ListaPLAN_SEMANAL

        Lista = miComponente.ObtenerLista()
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
    ''' Función que Recupera el DropDownList con los Datos de la Tabla PLAN_SEMANAL.
    ''' </summary>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar()
        RecuperarLista()
    End Sub

   

End Class
